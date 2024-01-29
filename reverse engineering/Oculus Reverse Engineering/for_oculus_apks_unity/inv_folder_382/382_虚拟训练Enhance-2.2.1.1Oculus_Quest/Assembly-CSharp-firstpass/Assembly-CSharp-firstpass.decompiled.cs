using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Array2DEditor;
using Il2CppDummyDll;
using SRDebugger.Internal;
using SRDebugger.Scripts;
using SRDebugger.Services;
using SRDebugger.UI;
using SRDebugger.UI.Controls;
using SRDebugger.UI.Controls.Data;
using SRDebugger.UI.Other;
using SRF;
using SRF.Components;
using SRF.Helpers;
using SRF.Service;
using SRF.UI;
using SRF.UI.Layout;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExampleScript : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Array2DBool array2DBool;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabToInstantiate;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1340A64", Offset = "0x1340A64", VA = "0x1340A64")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1340EEC", Offset = "0x1340EEC", VA = "0x1340EEC")]
	public ExampleScript()
	{
	}
}
[Token(Token = "0x2000003")]
public class iTween : MonoBehaviour
{
	[Token(Token = "0x2000136")]
	private delegate float EasingFunction(float start, float end, float Value);

	[Token(Token = "0x2000137")]
	private delegate void ApplyTween();

	[Token(Token = "0x2000138")]
	public enum EaseType
	{
		[Token(Token = "0x40005F6")]
		easeInQuad,
		[Token(Token = "0x40005F7")]
		easeOutQuad,
		[Token(Token = "0x40005F8")]
		easeInOutQuad,
		[Token(Token = "0x40005F9")]
		easeInCubic,
		[Token(Token = "0x40005FA")]
		easeOutCubic,
		[Token(Token = "0x40005FB")]
		easeInOutCubic,
		[Token(Token = "0x40005FC")]
		easeInQuart,
		[Token(Token = "0x40005FD")]
		easeOutQuart,
		[Token(Token = "0x40005FE")]
		easeInOutQuart,
		[Token(Token = "0x40005FF")]
		easeInQuint,
		[Token(Token = "0x4000600")]
		easeOutQuint,
		[Token(Token = "0x4000601")]
		easeInOutQuint,
		[Token(Token = "0x4000602")]
		easeInSine,
		[Token(Token = "0x4000603")]
		easeOutSine,
		[Token(Token = "0x4000604")]
		easeInOutSine,
		[Token(Token = "0x4000605")]
		easeInExpo,
		[Token(Token = "0x4000606")]
		easeOutExpo,
		[Token(Token = "0x4000607")]
		easeInOutExpo,
		[Token(Token = "0x4000608")]
		easeInCirc,
		[Token(Token = "0x4000609")]
		easeOutCirc,
		[Token(Token = "0x400060A")]
		easeInOutCirc,
		[Token(Token = "0x400060B")]
		linear,
		[Token(Token = "0x400060C")]
		spring,
		[Token(Token = "0x400060D")]
		easeInBounce,
		[Token(Token = "0x400060E")]
		easeOutBounce,
		[Token(Token = "0x400060F")]
		easeInOutBounce,
		[Token(Token = "0x4000610")]
		easeInBack,
		[Token(Token = "0x4000611")]
		easeOutBack,
		[Token(Token = "0x4000612")]
		easeInOutBack,
		[Token(Token = "0x4000613")]
		easeInElastic,
		[Token(Token = "0x4000614")]
		easeOutElastic,
		[Token(Token = "0x4000615")]
		easeInOutElastic,
		[Token(Token = "0x4000616")]
		punch
	}

	[Token(Token = "0x2000139")]
	public enum LoopType
	{
		[Token(Token = "0x4000618")]
		none,
		[Token(Token = "0x4000619")]
		loop,
		[Token(Token = "0x400061A")]
		pingPong
	}

	[Token(Token = "0x200013A")]
	public enum NamedValueColor
	{
		[Token(Token = "0x400061C")]
		_Color,
		[Token(Token = "0x400061D")]
		_SpecColor,
		[Token(Token = "0x400061E")]
		_Emission,
		[Token(Token = "0x400061F")]
		_ReflectColor
	}

	[Token(Token = "0x200013B")]
	public static class Defaults
	{
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float time;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float delay;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static NamedValueColor namedColorValue;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static LoopType loopType;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static EaseType easeType;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float lookSpeed;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool isLocal;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static Space space;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static bool orientToPath;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static Color color;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static float updateTimePercentage;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static float updateTime;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static float lookAhead;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static bool useRealTime;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static Vector3 up;
	}

	[Token(Token = "0x200013C")]
	private class CRSpline
	{
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3[] pts;

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x2268DC4", Offset = "0x2268DC4", VA = "0x2268DC4")]
		public CRSpline(params Vector3[] pts)
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x2268E54", Offset = "0x2268E54", VA = "0x2268E54")]
		public Vector3 Interp(float t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200013D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A928", Offset = "0xB6A928")]
	private sealed class <TweenDelay>d__145 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700020A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x2268960", Offset = "0x2268960", VA = "0x2268960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x22689CC", Offset = "0x22689CC", VA = "0x22689CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x2268858", Offset = "0x2268858", VA = "0x2268858")]
		[DebuggerHidden]
		public <TweenDelay>d__145(int <>1__state)
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x2268884", Offset = "0x2268884", VA = "0x2268884", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x2268888", Offset = "0x2268888", VA = "0x2268888", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x2268968", Offset = "0x2268968", VA = "0x2268968", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A938", Offset = "0xB6A938")]
	private sealed class <TweenRestart>d__147 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700020C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x2268AE4", Offset = "0x2268AE4", VA = "0x2268AE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x2268B50", Offset = "0x2268B50", VA = "0x2268B50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x22689D4", Offset = "0x22689D4", VA = "0x22689D4")]
		[DebuggerHidden]
		public <TweenRestart>d__147(int <>1__state)
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x2268A00", Offset = "0x2268A00", VA = "0x2268A00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x2268A04", Offset = "0x2268A04", VA = "0x2268A04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x2268AEC", Offset = "0x2268AEC", VA = "0x2268AEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A948", Offset = "0xB6A948")]
	private sealed class <Start>d__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public iTween <>4__this;

		[Token(Token = "0x1700020E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x22687E4", Offset = "0x22687E4", VA = "0x22687E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700020F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x2268850", Offset = "0x2268850", VA = "0x2268850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x2268708", Offset = "0x2268708", VA = "0x2268708")]
		[DebuggerHidden]
		public <Start>d__229(int <>1__state)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x2268734", Offset = "0x2268734", VA = "0x2268734", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x2268738", Offset = "0x2268738", VA = "0x2268738", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x22687EC", Offset = "0x22687EC", VA = "0x22687EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static List<Hashtable> tweens;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string id;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string type;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string method;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public EaseType easeType;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float delay;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LoopType loopType;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool isRunning;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool isPaused;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _name;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float runningTime;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float percentage;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float delayStarted;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool kinematic;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	private bool isLocal;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	private bool loop;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	private bool reverse;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool wasPaused;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	private bool physics;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Hashtable tweenArguments;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Space space;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private EasingFunction ease;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ApplyTween apply;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioSource audioSource;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3[] vector3s;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector2[] vector2s;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Color[,] colors;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float[] floats;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Rect[] rects;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CRSpline path;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 preUpdate;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Vector3 postUpdate;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private NamedValueColor namedcolorvalue;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float lastRealTime;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool useRealTime;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Transform thisTransform;

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1A564A0", Offset = "0x1A564A0", VA = "0x1A564A0")]
	public static void Init(GameObject target)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1A56724", Offset = "0x1A56724", VA = "0x1A56724")]
	public static void ValueTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1A57708", Offset = "0x1A57708", VA = "0x1A57708")]
	public static void FadeFrom(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1A579F0", Offset = "0x1A579F0", VA = "0x1A579F0")]
	public static void FadeFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1A58488", Offset = "0x1A58488", VA = "0x1A58488")]
	public static void FadeTo(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1A58638", Offset = "0x1A58638", VA = "0x1A58638")]
	public static void FadeTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1A58BDC", Offset = "0x1A58BDC", VA = "0x1A58BDC")]
	public static void ColorFrom(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1A57A64", Offset = "0x1A57A64", VA = "0x1A57A64")]
	public static void ColorFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1A58DB8", Offset = "0x1A58DB8", VA = "0x1A58DB8")]
	public static void ColorTo(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1A586AC", Offset = "0x1A586AC", VA = "0x1A586AC")]
	public static void ColorTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1A58F94", Offset = "0x1A58F94", VA = "0x1A58F94")]
	public static void AudioFrom(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1A591C0", Offset = "0x1A591C0", VA = "0x1A591C0")]
	public static void AudioFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1A595D4", Offset = "0x1A595D4", VA = "0x1A595D4")]
	public static void AudioTo(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1A59800", Offset = "0x1A59800", VA = "0x1A59800")]
	public static void AudioTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1A59960", Offset = "0x1A59960", VA = "0x1A59960")]
	public static void Stab(GameObject target, AudioClip audioclip, float delay)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1A59AF4", Offset = "0x1A59AF4", VA = "0x1A59AF4")]
	public static void Stab(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1A59BA8", Offset = "0x1A59BA8", VA = "0x1A59BA8")]
	public static void LookFrom(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1A59D74", Offset = "0x1A59D74", VA = "0x1A59D74")]
	public static void LookFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1A5A408", Offset = "0x1A5A408", VA = "0x1A5A408")]
	public static void LookTo(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1A5A5D4", Offset = "0x1A5A5D4", VA = "0x1A5A5D4")]
	public static void LookTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1A5A8F8", Offset = "0x1A5A8F8", VA = "0x1A5A8F8")]
	public static void MoveTo(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1A5AAC4", Offset = "0x1A5AAC4", VA = "0x1A5AAC4")]
	public static void MoveTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1A5AE68", Offset = "0x1A5AE68", VA = "0x1A5AE68")]
	public static void MoveFrom(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1A5B034", Offset = "0x1A5B034", VA = "0x1A5B034")]
	public static void MoveFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1A5B97C", Offset = "0x1A5B97C", VA = "0x1A5B97C")]
	public static void MoveAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1A5BB48", Offset = "0x1A5BB48", VA = "0x1A5BB48")]
	public static void MoveAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1A56558", Offset = "0x1A56558", VA = "0x1A56558")]
	public static void MoveBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1A5BC28", Offset = "0x1A5BC28", VA = "0x1A5BC28")]
	public static void MoveBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1A5BD08", Offset = "0x1A5BD08", VA = "0x1A5BD08")]
	public static void ScaleTo(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1A5BED4", Offset = "0x1A5BED4", VA = "0x1A5BED4")]
	public static void ScaleTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1A5C270", Offset = "0x1A5C270", VA = "0x1A5C270")]
	public static void ScaleFrom(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1A5C43C", Offset = "0x1A5C43C", VA = "0x1A5C43C")]
	public static void ScaleFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1A5C914", Offset = "0x1A5C914", VA = "0x1A5C914")]
	public static void ScaleAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1A5CAE0", Offset = "0x1A5CAE0", VA = "0x1A5CAE0")]
	public static void ScaleAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x1A5CBC0", Offset = "0x1A5CBC0", VA = "0x1A5CBC0")]
	public static void ScaleBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1A5CD8C", Offset = "0x1A5CD8C", VA = "0x1A5CD8C")]
	public static void ScaleBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1A5CE6C", Offset = "0x1A5CE6C", VA = "0x1A5CE6C")]
	public static void RotateTo(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1A5D038", Offset = "0x1A5D038", VA = "0x1A5D038")]
	public static void RotateTo(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1A5D3DC", Offset = "0x1A5D3DC", VA = "0x1A5D3DC")]
	public static void RotateFrom(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1A5D5A8", Offset = "0x1A5D5A8", VA = "0x1A5D5A8")]
	public static void RotateFrom(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1A5DB44", Offset = "0x1A5DB44", VA = "0x1A5DB44")]
	public static void RotateAdd(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1A5DD10", Offset = "0x1A5DD10", VA = "0x1A5DD10")]
	public static void RotateAdd(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1A5DDF0", Offset = "0x1A5DDF0", VA = "0x1A5DDF0")]
	public static void RotateBy(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1A5DFBC", Offset = "0x1A5DFBC", VA = "0x1A5DFBC")]
	public static void RotateBy(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1A5E09C", Offset = "0x1A5E09C", VA = "0x1A5E09C")]
	public static void ShakePosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1A5E268", Offset = "0x1A5E268", VA = "0x1A5E268")]
	public static void ShakePosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1A5E348", Offset = "0x1A5E348", VA = "0x1A5E348")]
	public static void ShakeScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1A5E514", Offset = "0x1A5E514", VA = "0x1A5E514")]
	public static void ShakeScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1A5E5F4", Offset = "0x1A5E5F4", VA = "0x1A5E5F4")]
	public static void ShakeRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x1A5E7C0", Offset = "0x1A5E7C0", VA = "0x1A5E7C0")]
	public static void ShakeRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1A5E8A0", Offset = "0x1A5E8A0", VA = "0x1A5E8A0")]
	public static void PunchPosition(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1A5EA6C", Offset = "0x1A5EA6C", VA = "0x1A5EA6C")]
	public static void PunchPosition(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1A5EB90", Offset = "0x1A5EB90", VA = "0x1A5EB90")]
	public static void PunchRotation(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1A5ED5C", Offset = "0x1A5ED5C", VA = "0x1A5ED5C")]
	public static void PunchRotation(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1A5EE80", Offset = "0x1A5EE80", VA = "0x1A5EE80")]
	public static void PunchScale(GameObject target, Vector3 amount, float time)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1A5F04C", Offset = "0x1A5F04C", VA = "0x1A5F04C")]
	public static void PunchScale(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1A5F170", Offset = "0x1A5F170", VA = "0x1A5F170")]
	private void GenerateTargets()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1A60224", Offset = "0x1A60224", VA = "0x1A60224")]
	private void GenerateRectTargets()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1A600A0", Offset = "0x1A600A0", VA = "0x1A600A0")]
	private void GenerateColorTargets()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1A5FE38", Offset = "0x1A5FE38", VA = "0x1A5FE38")]
	private void GenerateVector3Targets()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1A5FB9C", Offset = "0x1A5FB9C", VA = "0x1A5FB9C")]
	private void GenerateVector2Targets()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1A5F99C", Offset = "0x1A5F99C", VA = "0x1A5F99C")]
	private void GenerateFloatTargets()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1A60368", Offset = "0x1A60368", VA = "0x1A60368")]
	private void GenerateColorToTargets()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1A60CFC", Offset = "0x1A60CFC", VA = "0x1A60CFC")]
	private void GenerateAudioToTargets()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1A65BA4", Offset = "0x1A65BA4", VA = "0x1A65BA4")]
	private void GenerateStabTargets()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1A65348", Offset = "0x1A65348", VA = "0x1A65348")]
	private void GenerateLookToTargets()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1A61010", Offset = "0x1A61010", VA = "0x1A61010")]
	private void GenerateMoveToPathTargets()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1A61758", Offset = "0x1A61758", VA = "0x1A61758")]
	private void GenerateMoveToTargets()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1A61DAC", Offset = "0x1A61DAC", VA = "0x1A61DAC")]
	private void GenerateMoveByTargets()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1A623B8", Offset = "0x1A623B8", VA = "0x1A623B8")]
	private void GenerateScaleToTargets()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1A62914", Offset = "0x1A62914", VA = "0x1A62914")]
	private void GenerateScaleByTargets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1A62D78", Offset = "0x1A62D78", VA = "0x1A62D78")]
	private void GenerateScaleAddTargets()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1A631D0", Offset = "0x1A631D0", VA = "0x1A631D0")]
	private void GenerateRotateToTargets()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1A63808", Offset = "0x1A63808", VA = "0x1A63808")]
	private void GenerateRotateAddTargets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1A63C68", Offset = "0x1A63C68", VA = "0x1A63C68")]
	private void GenerateRotateByTargets()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1A64134", Offset = "0x1A64134", VA = "0x1A64134")]
	private void GenerateShakePositionTargets()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1A64434", Offset = "0x1A64434", VA = "0x1A64434")]
	private void GenerateShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1A64708", Offset = "0x1A64708", VA = "0x1A64708")]
	private void GenerateShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1A649DC", Offset = "0x1A649DC", VA = "0x1A649DC")]
	private void GeneratePunchPositionTargets()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1A64D20", Offset = "0x1A64D20", VA = "0x1A64D20")]
	private void GeneratePunchRotationTargets()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1A65038", Offset = "0x1A65038", VA = "0x1A65038")]
	private void GeneratePunchScaleTargets()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1A662B0", Offset = "0x1A662B0", VA = "0x1A662B0")]
	private void ApplyRectTargets()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1A665B8", Offset = "0x1A665B8", VA = "0x1A665B8")]
	private void ApplyColorTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1A667F4", Offset = "0x1A667F4", VA = "0x1A667F4")]
	private void ApplyVector3Targets()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1A669F4", Offset = "0x1A669F4", VA = "0x1A669F4")]
	private void ApplyVector2Targets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1A66BA0", Offset = "0x1A66BA0", VA = "0x1A66BA0")]
	private void ApplyFloatTargets()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1A66D04", Offset = "0x1A66D04", VA = "0x1A66D04")]
	private void ApplyColorToTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1A6728C", Offset = "0x1A6728C", VA = "0x1A6728C")]
	private void ApplyAudioToTargets()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1A67404", Offset = "0x1A67404", VA = "0x1A67404")]
	private void ApplyStabTargets()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1A67408", Offset = "0x1A67408", VA = "0x1A67408")]
	private void ApplyMoveToPathTargets()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1A67770", Offset = "0x1A67770", VA = "0x1A67770")]
	private void ApplyMoveToTargets()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1A67988", Offset = "0x1A67988", VA = "0x1A67988")]
	private void ApplyMoveByTargets()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1A67CD4", Offset = "0x1A67CD4", VA = "0x1A67CD4")]
	private void ApplyScaleToTargets()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1A67E48", Offset = "0x1A67E48", VA = "0x1A67E48")]
	private void ApplyLookToTargets()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x1A6802C", Offset = "0x1A6802C", VA = "0x1A6802C")]
	private void ApplyRotateToTargets()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1A68368", Offset = "0x1A68368", VA = "0x1A68368")]
	private void ApplyRotateAddTargets()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1A68608", Offset = "0x1A68608", VA = "0x1A68608")]
	private void ApplyShakePositionTargets()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1A68A34", Offset = "0x1A68A34", VA = "0x1A68A34")]
	private void ApplyShakeScaleTargets()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1A68C54", Offset = "0x1A68C54", VA = "0x1A68C54")]
	private void ApplyShakeRotationTargets()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1A68ED0", Offset = "0x1A68ED0", VA = "0x1A68ED0")]
	private void ApplyPunchPositionTargets()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1A69390", Offset = "0x1A69390", VA = "0x1A69390")]
	private void ApplyPunchRotationTargets()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1A696F0", Offset = "0x1A696F0", VA = "0x1A696F0")]
	private void ApplyPunchScaleTargets()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1A69958", Offset = "0x1A69958", VA = "0x1A69958")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D634", Offset = "0xB6D634")]
	private IEnumerator TweenDelay()
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1A699CC", Offset = "0x1A699CC", VA = "0x1A699CC")]
	private void TweenStart()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1A6A388", Offset = "0x1A6A388", VA = "0x1A6A388")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D698", Offset = "0xB6D698")]
	private IEnumerator TweenRestart()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x1A6A3FC", Offset = "0x1A6A3FC", VA = "0x1A6A3FC")]
	private void TweenUpdate()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1A6A4E0", Offset = "0x1A6A4E0", VA = "0x1A6A4E0")]
	private void TweenComplete()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1A6A5B0", Offset = "0x1A6A5B0", VA = "0x1A6A5B0")]
	private void TweenLoop()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1A6A654", Offset = "0x1A6A654", VA = "0x1A6A654")]
	public static Rect RectUpdate(Rect currentValue, Rect targetValue, float speed)
	{
		return default(Rect);
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1A6A81C", Offset = "0x1A6A81C", VA = "0x1A6A81C")]
	public static Vector3 Vector3Update(Vector3 currentValue, Vector3 targetValue, float speed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1A6A928", Offset = "0x1A6A928", VA = "0x1A6A928")]
	public static Vector2 Vector2Update(Vector2 currentValue, Vector2 targetValue, float speed)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1A6A7DC", Offset = "0x1A6A7DC", VA = "0x1A6A7DC")]
	public static float FloatUpdate(float currentValue, float targetValue, float speed)
	{
		return default(float);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1A6AA0C", Offset = "0x1A6AA0C", VA = "0x1A6AA0C")]
	public static void FadeUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1A6B4CC", Offset = "0x1A6B4CC", VA = "0x1A6B4CC")]
	public static void FadeUpdate(GameObject target, float alpha, float time)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1A6AAD0", Offset = "0x1A6AAD0", VA = "0x1A6AAD0")]
	public static void ColorUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1A6B67C", Offset = "0x1A6B67C", VA = "0x1A6B67C")]
	public static void ColorUpdate(GameObject target, Color color, float time)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1A6B858", Offset = "0x1A6B858", VA = "0x1A6B858")]
	public static void AudioUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1A6BD10", Offset = "0x1A6BD10", VA = "0x1A6BD10")]
	public static void AudioUpdate(GameObject target, float volume, float pitch, float time)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1A6BF3C", Offset = "0x1A6BF3C", VA = "0x1A6BF3C")]
	public static void RotateUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1A6C570", Offset = "0x1A6C570", VA = "0x1A6C570")]
	public static void RotateUpdate(GameObject target, Vector3 rotation, float time)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1A6C73C", Offset = "0x1A6C73C", VA = "0x1A6C73C")]
	public static void ScaleUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1A6CD2C", Offset = "0x1A6CD2C", VA = "0x1A6CD2C")]
	public static void ScaleUpdate(GameObject target, Vector3 scale, float time)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1A6CEF8", Offset = "0x1A6CEF8", VA = "0x1A6CEF8")]
	public static void MoveUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1A6E09C", Offset = "0x1A6E09C", VA = "0x1A6E09C")]
	public static void MoveUpdate(GameObject target, Vector3 position, float time)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1A6D768", Offset = "0x1A6D768", VA = "0x1A6D768")]
	public static void LookUpdate(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1A6E268", Offset = "0x1A6E268", VA = "0x1A6E268")]
	public static void LookUpdate(GameObject target, Vector3 looktarget, float time)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1A6E434", Offset = "0x1A6E434", VA = "0x1A6E434")]
	public static float PathLength(Transform[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1A66134", Offset = "0x1A66134", VA = "0x1A66134")]
	public static float PathLength(Vector3[] path)
	{
		return default(float);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1A6ED3C", Offset = "0x1A6ED3C", VA = "0x1A6ED3C")]
	public static void PutOnPath(GameObject target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1A6EDF0", Offset = "0x1A6EDF0", VA = "0x1A6EDF0")]
	public static void PutOnPath(Transform target, Vector3[] path, float percent)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1A6EE8C", Offset = "0x1A6EE8C", VA = "0x1A6EE8C")]
	public static void PutOnPath(GameObject target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1A6EFD8", Offset = "0x1A6EFD8", VA = "0x1A6EFD8")]
	public static void PutOnPath(Transform target, Transform[] path, float percent)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1A6F10C", Offset = "0x1A6F10C", VA = "0x1A6F10C")]
	public static Vector3 PointOnPath(Transform[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1A6F224", Offset = "0x1A6F224", VA = "0x1A6F224")]
	public static void DrawLine(Vector3[] line)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1A6F4A0", Offset = "0x1A6F4A0", VA = "0x1A6F4A0")]
	public static void DrawLine(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1A6F568", Offset = "0x1A6F568", VA = "0x1A6F568")]
	public static void DrawLine(Transform[] line)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1A6F6E4", Offset = "0x1A6F6E4", VA = "0x1A6F6E4")]
	public static void DrawLine(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1A6F840", Offset = "0x1A6F840", VA = "0x1A6F840")]
	public static void DrawLineGizmos(Vector3[] line)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1A6F928", Offset = "0x1A6F928", VA = "0x1A6F928")]
	public static void DrawLineGizmos(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1A6F9F0", Offset = "0x1A6F9F0", VA = "0x1A6F9F0")]
	public static void DrawLineGizmos(Transform[] line)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1A6FB6C", Offset = "0x1A6FB6C", VA = "0x1A6FB6C")]
	public static void DrawLineGizmos(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1A6FCC8", Offset = "0x1A6FCC8", VA = "0x1A6FCC8")]
	public static void DrawLineHandles(Vector3[] line)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1A6FDB0", Offset = "0x1A6FDB0", VA = "0x1A6FDB0")]
	public static void DrawLineHandles(Vector3[] line, Color color)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1A6FE78", Offset = "0x1A6FE78", VA = "0x1A6FE78")]
	public static void DrawLineHandles(Transform[] line)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1A6FFF4", Offset = "0x1A6FFF4", VA = "0x1A6FFF4")]
	public static void DrawLineHandles(Transform[] line, Color color)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1A70150", Offset = "0x1A70150", VA = "0x1A70150")]
	public static Vector3 PointOnPath(Vector3[] path, float percent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1A701C8", Offset = "0x1A701C8", VA = "0x1A701C8")]
	public static void DrawPath(Vector3[] path)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1A704A8", Offset = "0x1A704A8", VA = "0x1A704A8")]
	public static void DrawPath(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1A70570", Offset = "0x1A70570", VA = "0x1A70570")]
	public static void DrawPath(Transform[] path)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1A706EC", Offset = "0x1A706EC", VA = "0x1A706EC")]
	public static void DrawPath(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1A70848", Offset = "0x1A70848", VA = "0x1A70848")]
	public static void DrawPathGizmos(Vector3[] path)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1A70930", Offset = "0x1A70930", VA = "0x1A70930")]
	public static void DrawPathGizmos(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1A709F8", Offset = "0x1A709F8", VA = "0x1A709F8")]
	public static void DrawPathGizmos(Transform[] path)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1A70B74", Offset = "0x1A70B74", VA = "0x1A70B74")]
	public static void DrawPathGizmos(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1A70CD0", Offset = "0x1A70CD0", VA = "0x1A70CD0")]
	public static void DrawPathHandles(Vector3[] path)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x1A70DB8", Offset = "0x1A70DB8", VA = "0x1A70DB8")]
	public static void DrawPathHandles(Vector3[] path, Color color)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1A70E80", Offset = "0x1A70E80", VA = "0x1A70E80")]
	public static void DrawPathHandles(Transform[] path)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1A70FFC", Offset = "0x1A70FFC", VA = "0x1A70FFC")]
	public static void DrawPathHandles(Transform[] path, Color color)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1A71158", Offset = "0x1A71158", VA = "0x1A71158")]
	public static void Resume(GameObject target)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1A7127C", Offset = "0x1A7127C", VA = "0x1A7127C")]
	public static void Resume(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1A71570", Offset = "0x1A71570", VA = "0x1A71570")]
	public static void Resume(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x1A716D4", Offset = "0x1A716D4", VA = "0x1A716D4")]
	public static void Resume(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1A71AB0", Offset = "0x1A71AB0", VA = "0x1A71AB0")]
	public static void Resume()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1A71BD4", Offset = "0x1A71BD4", VA = "0x1A71BD4")]
	public static void Resume(string type)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1A71E08", Offset = "0x1A71E08", VA = "0x1A71E08")]
	public static void Pause(GameObject target)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1A71F60", Offset = "0x1A71F60", VA = "0x1A71F60")]
	public static void Pause(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1A72254", Offset = "0x1A72254", VA = "0x1A72254")]
	public static void Pause(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1A7240C", Offset = "0x1A7240C", VA = "0x1A7240C")]
	public static void Pause(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1A7283C", Offset = "0x1A7283C", VA = "0x1A7283C")]
	public static void Pause()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1A72960", Offset = "0x1A72960", VA = "0x1A72960")]
	public static void Pause(string type)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1A72B94", Offset = "0x1A72B94", VA = "0x1A72B94")]
	public static int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1A72C0C", Offset = "0x1A72C0C", VA = "0x1A72C0C")]
	public static int Count(string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1A72DF0", Offset = "0x1A72DF0", VA = "0x1A72DF0")]
	public static int Count(GameObject target)
	{
		return default(int);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1A72E58", Offset = "0x1A72E58", VA = "0x1A72E58")]
	public static int Count(GameObject target, string type)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1A72FC0", Offset = "0x1A72FC0", VA = "0x1A72FC0")]
	public static void Stop()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1A73230", Offset = "0x1A73230", VA = "0x1A73230")]
	public static void Stop(string type)
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1A735C0", Offset = "0x1A735C0", VA = "0x1A735C0")]
	public static void StopByName(string name)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1A73114", Offset = "0x1A73114", VA = "0x1A73114")]
	public static void Stop(GameObject target)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1A73910", Offset = "0x1A73910", VA = "0x1A73910")]
	public static void Stop(GameObject target, bool includechildren)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1A73464", Offset = "0x1A73464", VA = "0x1A73464")]
	public static void Stop(GameObject target, string type)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1A737F4", Offset = "0x1A737F4", VA = "0x1A737F4")]
	public static void StopByName(GameObject target, string name)
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1A73C04", Offset = "0x1A73C04", VA = "0x1A73C04")]
	public static void Stop(GameObject target, string type, bool includechildren)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1A73FD8", Offset = "0x1A73FD8", VA = "0x1A73FD8")]
	public static void StopByName(GameObject target, string name, bool includechildren)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1A578B8", Offset = "0x1A578B8", VA = "0x1A578B8")]
	public static Hashtable Hash(params object[] args)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1A7436C", Offset = "0x1A7436C", VA = "0x1A7436C")]
	private iTween(Hashtable h)
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1A74398", Offset = "0x1A74398", VA = "0x1A74398")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1A75408", Offset = "0x1A75408", VA = "0x1A75408")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D6FC", Offset = "0xB6D6FC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1A7547C", Offset = "0x1A7547C", VA = "0x1A7547C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1A754BC", Offset = "0x1A754BC", VA = "0x1A754BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1A754FC", Offset = "0x1A754FC", VA = "0x1A754FC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1A75610", Offset = "0x1A75610", VA = "0x1A75610")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1A7568C", Offset = "0x1A7568C", VA = "0x1A7568C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1A6F30C", Offset = "0x1A6F30C", VA = "0x1A6F30C")]
	private static void DrawLineHelper(Vector3[] line, Color color, string method)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1A702B0", Offset = "0x1A702B0", VA = "0x1A702B0")]
	private static void DrawPathHelper(Vector3[] path, Color color, string method)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1A6E63C", Offset = "0x1A6E63C", VA = "0x1A6E63C")]
	private static Vector3[] PathControlPointGenerator(Vector3[] path)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1A6E908", Offset = "0x1A6E908", VA = "0x1A6E908")]
	private static Vector3 Interp(Vector3[] pts, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1A575B0", Offset = "0x1A575B0", VA = "0x1A575B0")]
	private static void Launch(GameObject target, Hashtable args)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1A56C04", Offset = "0x1A56C04", VA = "0x1A56C04")]
	private static Hashtable CleanArgs(Hashtable args)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x1A75690", Offset = "0x1A75690", VA = "0x1A75690")]
	private static string GenerateID()
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1A743D4", Offset = "0x1A743D4", VA = "0x1A743D4")]
	private void RetrieveArgs()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1A75710", Offset = "0x1A75710", VA = "0x1A75710")]
	private void GetEasingFunction()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1A6A468", Offset = "0x1A6A468", VA = "0x1A6A468")]
	private void UpdatePercentage()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1A69B48", Offset = "0x1A69B48", VA = "0x1A69B48")]
	private void CallBack(string callbackType)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1A65EC8", Offset = "0x1A65EC8", VA = "0x1A65EC8")]
	private void Dispose()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1A69E28", Offset = "0x1A69E28", VA = "0x1A69E28")]
	private void ConflictCheck()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1A6A384", Offset = "0x1A6A384", VA = "0x1A6A384")]
	private void EnableKinematic()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1A6A650", Offset = "0x1A6A650", VA = "0x1A6A650")]
	private void DisableKinematic()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1A75638", Offset = "0x1A75638", VA = "0x1A75638")]
	private void ResumeDelay()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1A75B04", Offset = "0x1A75B04", VA = "0x1A75B04")]
	private float linear(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1A66068", Offset = "0x1A66068", VA = "0x1A66068")]
	private float clerp(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1A75B8C", Offset = "0x1A75B8C", VA = "0x1A75B8C")]
	private float spring(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1A75C90", Offset = "0x1A75C90", VA = "0x1A75C90")]
	private float easeInQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1A75CA4", Offset = "0x1A75CA4", VA = "0x1A75CA4")]
	private float easeOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1A75CC0", Offset = "0x1A75CC0", VA = "0x1A75CC0")]
	private float easeInOutQuad(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1A75D14", Offset = "0x1A75D14", VA = "0x1A75D14")]
	private float easeInCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1A75D2C", Offset = "0x1A75D2C", VA = "0x1A75D2C")]
	private float easeOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1A75D54", Offset = "0x1A75D54", VA = "0x1A75D54")]
	private float easeInOutCubic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1A75DAC", Offset = "0x1A75DAC", VA = "0x1A75DAC")]
	private float easeInQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1A75DC8", Offset = "0x1A75DC8", VA = "0x1A75DC8")]
	private float easeOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1A75DF0", Offset = "0x1A75DF0", VA = "0x1A75DF0")]
	private float easeInOutQuart(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1A75E4C", Offset = "0x1A75E4C", VA = "0x1A75E4C")]
	private float easeInQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1A75E6C", Offset = "0x1A75E6C", VA = "0x1A75E6C")]
	private float easeOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1A75E9C", Offset = "0x1A75E9C", VA = "0x1A75E9C")]
	private float easeInOutQuint(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1A75F04", Offset = "0x1A75F04", VA = "0x1A75F04")]
	private float easeInSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1A75F9C", Offset = "0x1A75F9C", VA = "0x1A75F9C")]
	private float easeOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1A76030", Offset = "0x1A76030", VA = "0x1A76030")]
	private float easeInOutSine(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1A760D4", Offset = "0x1A760D4", VA = "0x1A760D4")]
	private float easeInExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1A7616C", Offset = "0x1A7616C", VA = "0x1A7616C")]
	private float easeOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1A76204", Offset = "0x1A76204", VA = "0x1A76204")]
	private float easeInOutExpo(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1A762F4", Offset = "0x1A762F4", VA = "0x1A762F4")]
	private float easeInCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1A763A0", Offset = "0x1A763A0", VA = "0x1A763A0")]
	private float easeOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x1A7644C", Offset = "0x1A7644C", VA = "0x1A7644C")]
	private float easeInOutCirc(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1A76544", Offset = "0x1A76544", VA = "0x1A76544")]
	private float easeInBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x1A76580", Offset = "0x1A76580", VA = "0x1A76580")]
	private float easeOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1A76650", Offset = "0x1A76650", VA = "0x1A76650")]
	private float easeInOutBounce(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1A766D4", Offset = "0x1A766D4", VA = "0x1A766D4")]
	private float easeInBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1A76704", Offset = "0x1A76704", VA = "0x1A76704")]
	private float easeOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1A76744", Offset = "0x1A76744", VA = "0x1A76744")]
	private float easeInOutBack(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1A692D0", Offset = "0x1A692D0", VA = "0x1A692D0")]
	private float punch(float amplitude, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1A767C8", Offset = "0x1A767C8", VA = "0x1A767C8")]
	private float easeInElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1A768B0", Offset = "0x1A768B0", VA = "0x1A768B0")]
	private float easeOutElastic(float start, float end, float value)
	{
		return default(float);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1A76994", Offset = "0x1A76994", VA = "0x1A76994")]
	private float easeInOutElastic(float start, float end, float value)
	{
		return default(float);
	}
}
[Token(Token = "0x2000004")]
public static class SRDebug
{
	[Token(Token = "0x4000028")]
	public const string Version = "1.7.1";

	[Token(Token = "0x17000001")]
	public static IDebugService Instance
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x11485B8", Offset = "0x11485B8", VA = "0x11485B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1148620", Offset = "0x1148620", VA = "0x1148620")]
	public static void Init()
	{
	}
}
[Token(Token = "0x2000005")]
public class SROptions
{
	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB6A958", Offset = "0xB6A958")]
	public sealed class NumberRangeAttribute : Attribute
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly double Max;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly double Min;

		[Token(Token = "0x6000A93")]
		[Address(RVA = "0x12CC448", Offset = "0x12CC448", VA = "0x12CC448")]
		public NumberRangeAttribute(double min, double max)
		{
		}
	}

	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB6A96C", Offset = "0xB6A96C")]
	public sealed class IncrementAttribute : Attribute
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly double Increment;

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x12CC414", Offset = "0x12CC414", VA = "0x12CC414")]
		public IncrementAttribute(double increment)
		{
		}
	}

	[Token(Token = "0x2000142")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB6A980", Offset = "0xB6A980")]
	public sealed class SortAttribute : Attribute
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int SortPriority;

		[Token(Token = "0x6000A95")]
		[Address(RVA = "0x12CC480", Offset = "0x12CC480", VA = "0x12CC480")]
		public SortAttribute(int priority)
		{
		}
	}

	[Token(Token = "0x2000143")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB6A994", Offset = "0xB6A994")]
	public sealed class DisplayNameAttribute : Attribute
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x6000A96")]
		[Address(RVA = "0x12CC3E8", Offset = "0x12CC3E8", VA = "0x12CC3E8")]
		public DisplayNameAttribute(string name)
		{
		}
	}

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly SROptions _current;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int _instrumentIDToUnlock;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int _dayToday;

	[Token(Token = "0x17000002")]
	public static SROptions Current
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x12CBDBC", Offset = "0x12CBDBC", VA = "0x12CBDBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000001")]
	public event SROptionsPropertyChanged PropertyChanged
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x12CBE24", Offset = "0x12CBE24", VA = "0x12CBE24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D760", Offset = "0xB6D760")]
		add
		{
		}
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x12CBEC8", Offset = "0x12CBEC8", VA = "0x12CBEC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D770", Offset = "0xB6D770")]
		remove
		{
		}
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x12CBF6C", Offset = "0x12CBF6C", VA = "0x12CBF6C")]
	public void OnPropertyChanged(string propertyName)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x12CC36C", Offset = "0x12CC36C", VA = "0x12CC36C")]
	public SROptions()
	{
	}
}
[Token(Token = "0x2000006")]
public delegate void SROptionsPropertyChanged(object sender, string propertyName);
[Token(Token = "0x2000007")]
public static class SRDebugUtil
{
	[Token(Token = "0x400002D")]
	public const int LineBufferCount = 512;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ACC8", Offset = "0xB6ACC8")]
	private static bool <IsFixedUpdate>k__BackingField;

	[Token(Token = "0x17000003")]
	public static bool IsFixedUpdate
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x11486CC", Offset = "0x11486CC", VA = "0x11486CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D780", Offset = "0xB6D780")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x114871C", Offset = "0x114871C", VA = "0x114871C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D790", Offset = "0xB6D790")]
		set
		{
		}
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1148774", Offset = "0x1148774", VA = "0x1148774")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void AssertNotNull(object value, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1148930", Offset = "0x1148930", VA = "0x1148930")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void Assert(bool condition, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1148A74", Offset = "0x1148A74", VA = "0x1148A74")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6D810", Offset = "0xB6D810")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssertNotNull(object value, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1148A78", Offset = "0x1148A78", VA = "0x1148A78")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6D86C", Offset = "0xB6D86C")]
	[DebuggerNonUserCode]
	[DebuggerStepThrough]
	public static void EditorAssert(bool condition, [Optional] string message, [Optional] MonoBehaviour instance)
	{
	}
}
[Token(Token = "0x2000008")]
public static class SRFileUtil
{
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x12C9870", Offset = "0x12C9870", VA = "0x12C9870")]
	public static void DeleteDirectory(string path)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x12C9950", Offset = "0x12C9950", VA = "0x12C9950")]
	public static string GetBytesReadable(long i)
	{
		return null;
	}
}
[Token(Token = "0x2000009")]
public static class SRInstantiate
{
	[Token(Token = "0x600010A")]
	public static T Instantiate<T>(T prefab) where T : UnityEngine.Component
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x12C9AF0", Offset = "0x12C9AF0", VA = "0x12C9AF0")]
	public static GameObject Instantiate(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	public static T Instantiate<T>(T prefab, Vector3 position, Quaternion rotation) where T : UnityEngine.Component
	{
		return null;
	}
}
[Token(Token = "0x200000A")]
public static class SRMath
{
	[Token(Token = "0x2000144")]
	public enum EaseType
	{
		[Token(Token = "0x400063F")]
		Linear,
		[Token(Token = "0x4000640")]
		QuadEaseOut,
		[Token(Token = "0x4000641")]
		QuadEaseIn,
		[Token(Token = "0x4000642")]
		QuadEaseInOut,
		[Token(Token = "0x4000643")]
		QuadEaseOutIn,
		[Token(Token = "0x4000644")]
		ExpoEaseOut,
		[Token(Token = "0x4000645")]
		ExpoEaseIn,
		[Token(Token = "0x4000646")]
		ExpoEaseInOut,
		[Token(Token = "0x4000647")]
		ExpoEaseOutIn,
		[Token(Token = "0x4000648")]
		CubicEaseOut,
		[Token(Token = "0x4000649")]
		CubicEaseIn,
		[Token(Token = "0x400064A")]
		CubicEaseInOut,
		[Token(Token = "0x400064B")]
		CubicEaseOutIn,
		[Token(Token = "0x400064C")]
		QuartEaseOut,
		[Token(Token = "0x400064D")]
		QuartEaseIn,
		[Token(Token = "0x400064E")]
		QuartEaseInOut,
		[Token(Token = "0x400064F")]
		QuartEaseOutIn,
		[Token(Token = "0x4000650")]
		QuintEaseOut,
		[Token(Token = "0x4000651")]
		QuintEaseIn,
		[Token(Token = "0x4000652")]
		QuintEaseInOut,
		[Token(Token = "0x4000653")]
		QuintEaseOutIn,
		[Token(Token = "0x4000654")]
		CircEaseOut,
		[Token(Token = "0x4000655")]
		CircEaseIn,
		[Token(Token = "0x4000656")]
		CircEaseInOut,
		[Token(Token = "0x4000657")]
		CircEaseOutIn,
		[Token(Token = "0x4000658")]
		SineEaseOut,
		[Token(Token = "0x4000659")]
		SineEaseIn,
		[Token(Token = "0x400065A")]
		SineEaseInOut,
		[Token(Token = "0x400065B")]
		SineEaseOutIn,
		[Token(Token = "0x400065C")]
		ElasticEaseOut,
		[Token(Token = "0x400065D")]
		ElasticEaseIn,
		[Token(Token = "0x400065E")]
		ElasticEaseInOut,
		[Token(Token = "0x400065F")]
		ElasticEaseOutIn,
		[Token(Token = "0x4000660")]
		BounceEaseOut,
		[Token(Token = "0x4000661")]
		BounceEaseIn,
		[Token(Token = "0x4000662")]
		BounceEaseInOut,
		[Token(Token = "0x4000663")]
		BounceEaseOutIn,
		[Token(Token = "0x4000664")]
		BackEaseOut,
		[Token(Token = "0x4000665")]
		BackEaseIn,
		[Token(Token = "0x4000666")]
		BackEaseInOut,
		[Token(Token = "0x4000667")]
		BackEaseOutIn
	}

	[Token(Token = "0x2000145")]
	private static class TweenFunctions
	{
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x12CA70C", Offset = "0x12CA70C", VA = "0x12CA70C")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x12CA7F4", Offset = "0x12CA7F4", VA = "0x12CA7F4")]
		public static float ExpoEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x12CA898", Offset = "0x12CA898", VA = "0x12CA898")]
		public static float ExpoEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x12CA940", Offset = "0x12CA940", VA = "0x12CA940")]
		public static float ExpoEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x12CAA54", Offset = "0x12CAA54", VA = "0x12CAA54")]
		public static float ExpoEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x12CADA0", Offset = "0x12CADA0", VA = "0x12CADA0")]
		public static float CircEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x12CAE50", Offset = "0x12CAE50", VA = "0x12CAE50")]
		public static float CircEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x12CAF00", Offset = "0x12CAF00", VA = "0x12CAF00")]
		public static float CircEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x12CAFFC", Offset = "0x12CAFFC", VA = "0x12CAFFC")]
		public static float CircEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x12CA71C", Offset = "0x12CA71C", VA = "0x12CA71C")]
		public static float QuadEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x12CA738", Offset = "0x12CA738", VA = "0x12CA738")]
		public static float QuadEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x12CA74C", Offset = "0x12CA74C", VA = "0x12CA74C")]
		public static float QuadEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x12CA7A0", Offset = "0x12CA7A0", VA = "0x12CA7A0")]
		public static float QuadEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x12CB028", Offset = "0x12CB028", VA = "0x12CB028")]
		public static float SineEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x12CB0C0", Offset = "0x12CB0C0", VA = "0x12CB0C0")]
		public static float SineEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x12CB15C", Offset = "0x12CB15C", VA = "0x12CB15C")]
		public static float SineEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x12CB260", Offset = "0x12CB260", VA = "0x12CB260")]
		public static float SineEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x12CAA80", Offset = "0x12CAA80", VA = "0x12CAA80")]
		public static float CubicEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x12CAAA8", Offset = "0x12CAAA8", VA = "0x12CAAA8")]
		public static float CubicEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x12CAAC0", Offset = "0x12CAAC0", VA = "0x12CAAC0")]
		public static float CubicEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x12CAB14", Offset = "0x12CAB14", VA = "0x12CAB14")]
		public static float CubicEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x12CAB74", Offset = "0x12CAB74", VA = "0x12CAB74")]
		public static float QuartEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x12CAB9C", Offset = "0x12CAB9C", VA = "0x12CAB9C")]
		public static float QuartEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x12CABB8", Offset = "0x12CABB8", VA = "0x12CABB8")]
		public static float QuartEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x12CAC14", Offset = "0x12CAC14", VA = "0x12CAC14")]
		public static float QuartEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x12CAC7C", Offset = "0x12CAC7C", VA = "0x12CAC7C")]
		public static float QuintEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x12CACAC", Offset = "0x12CACAC", VA = "0x12CACAC")]
		public static float QuintEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x12CACCC", Offset = "0x12CACCC", VA = "0x12CACCC")]
		public static float QuintEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x12CAD30", Offset = "0x12CAD30", VA = "0x12CAD30")]
		public static float QuintEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x12CB28C", Offset = "0x12CB28C", VA = "0x12CB28C")]
		public static float ElasticEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x12CB378", Offset = "0x12CB378", VA = "0x12CB378")]
		public static float ElasticEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x12CB470", Offset = "0x12CB470", VA = "0x12CB470")]
		public static float ElasticEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x12CB5D8", Offset = "0x12CB5D8", VA = "0x12CB5D8")]
		public static float ElasticEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x12CB604", Offset = "0x12CB604", VA = "0x12CB604")]
		public static float BounceEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x12CB6D4", Offset = "0x12CB6D4", VA = "0x12CB6D4")]
		public static float BounceEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x12CB708", Offset = "0x12CB708", VA = "0x12CB708")]
		public static float BounceEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x12CB788", Offset = "0x12CB788", VA = "0x12CB788")]
		public static float BounceEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x12CB7E0", Offset = "0x12CB7E0", VA = "0x12CB7E0")]
		public static float BackEaseOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x12CB820", Offset = "0x12CB820", VA = "0x12CB820")]
		public static float BackEaseIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x12CB850", Offset = "0x12CB850", VA = "0x12CB850")]
		public static float BackEaseInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x12CB8D0", Offset = "0x12CB8D0", VA = "0x12CB8D0")]
		public static float BackEaseOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x12C9B60", Offset = "0x12C9B60", VA = "0x12C9B60")]
	public static float LerpUnclamped(float from, float to, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x12C9B78", Offset = "0x12C9B78", VA = "0x12C9B78")]
	public static Vector3 LerpUnclamped(Vector3 from, Vector3 to, float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x12C9BD8", Offset = "0x12C9BD8", VA = "0x12C9BD8")]
	public static float FacingNormalized(Vector3 dir1, Vector3 dir2)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x12C9CE4", Offset = "0x12C9CE4", VA = "0x12C9CE4")]
	public static float WrapAngle(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x12C9D24", Offset = "0x12C9D24", VA = "0x12C9D24")]
	public static float NearestAngle(float to, float angle1, float angle2)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x12C9DCC", Offset = "0x12C9DCC", VA = "0x12C9DCC")]
	public static int Wrap(int max, int value)
	{
		return default(int);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x12C9E88", Offset = "0x12C9E88", VA = "0x12C9E88")]
	public static float Wrap(float max, float value)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x12C9EB0", Offset = "0x12C9EB0", VA = "0x12C9EB0")]
	public static float Average(float v1, float v2)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x12C9EC0", Offset = "0x12C9EC0", VA = "0x12C9EC0")]
	public static float Angle(Vector2 direction)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x12C9FF4", Offset = "0x12C9FF4", VA = "0x12C9FF4")]
	public static float Ease(float from, float to, float t, EaseType type)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x12CB95C", Offset = "0x12CB95C", VA = "0x12CB95C")]
	public static float SpringLerp(float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x12CBA48", Offset = "0x12CBA48", VA = "0x12CBA48")]
	public static float SpringLerp(float from, float to, float strength, float deltaTime)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x12CBAE4", Offset = "0x12CBAE4", VA = "0x12CBAE4")]
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x12CBBB0", Offset = "0x12CBBB0", VA = "0x12CBBB0")]
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x12CBC84", Offset = "0x12CBC84", VA = "0x12CBC84")]
	public static float SmoothClamp(float value, float min, float max, float scrollMax, EaseType easeType = EaseType.ExpoEaseOut)
	{
		return default(float);
	}
}
[Token(Token = "0x200000B")]
[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB68668", Offset = "0xB68668")]
public sealed class InjectAttribute : Attribute
{
	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1340F98", Offset = "0x1340F98", VA = "0x1340F98")]
	public InjectAttribute()
	{
	}
}
[Token(Token = "0x200000C")]
public static class DependencyInjector
{
	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Dictionary<Type, object> components;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly object placeholder;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<Type, FieldInfo[]> cachedFields;

	[Token(Token = "0x4000032")]
	private const BindingFlags FIELD_FLAGS = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly List<FieldInfo> injectFieldsBuffer;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x133FEA0", Offset = "0x133FEA0", VA = "0x133FEA0")]
	public static void InjectObject(object target)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x133FFD8", Offset = "0x133FFD8", VA = "0x133FFD8")]
	private static FieldInfo[] GetFields(Type type)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x134046C", Offset = "0x134046C", VA = "0x134046C")]
	public static void Inject(this MonoBehaviour target)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1340274", Offset = "0x1340274", VA = "0x1340274")]
	private static FieldInfo[] GetInjectFields(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x13404D0", Offset = "0x13404D0", VA = "0x13404D0")]
	private static bool HasInjectAttribute(MemberInfo member)
	{
		return default(bool);
	}

	[Token(Token = "0x6000122")]
	public static T Resolve<T>()
	{
		return (T)null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x13400C8", Offset = "0x13400C8", VA = "0x13400C8")]
	private static object Resolve(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	public static void ReplaceComponent<T>(T newComponent)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1340654", Offset = "0x1340654", VA = "0x1340654")]
	public static void ClearCache()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1340578", Offset = "0x1340578", VA = "0x1340578")]
	private static object CreateComponent(Type type)
	{
		return null;
	}
}
[Token(Token = "0x200000D")]
public class UITest
{
	[Token(Token = "0x2000146")]
	public class MB : MonoBehaviour
	{
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x12CE054", Offset = "0x12CE054", VA = "0x12CE054")]
		public MB()
		{
		}
	}

	[Token(Token = "0x2000147")]
	protected abstract class Condition
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string param;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string objectName;

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x12CD8E8", Offset = "0x12CD8E8", VA = "0x12CD8E8")]
		public Condition()
		{
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x12CDB80", Offset = "0x12CDB80", VA = "0x12CDB80")]
		public Condition(string param)
		{
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x12CDBAC", Offset = "0x12CDBAC", VA = "0x12CDBAC")]
		public Condition(string objectName, string param)
		{
		}

		[Token(Token = "0x6000AC4")]
		public abstract bool Satisfied();

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x12CDBE4", Offset = "0x12CDBE4", VA = "0x12CDBE4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000148")]
	protected class LabelTextAppeared : Condition
	{
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x12CCE30", Offset = "0x12CCE30", VA = "0x12CCE30")]
		public LabelTextAppeared(string objectName, string param)
		{
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x12CDD38", Offset = "0x12CDD38", VA = "0x12CDD38", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x12CDD54", Offset = "0x12CDD54", VA = "0x12CDD54")]
		private string GetErrorMessage()
		{
			return null;
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x12CE050", Offset = "0x12CE050", VA = "0x12CE050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000149")]
	protected class SceneLoaded : Condition
	{
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x12CCFA4", Offset = "0x12CCFA4", VA = "0x12CCFA4")]
		public SceneLoaded(string param)
		{
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x12CE2B4", Offset = "0x12CE2B4", VA = "0x12CE2B4", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014A")]
	protected class ObjectAnimationPlaying : Condition
	{
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x12CE05C", Offset = "0x12CE05C", VA = "0x12CE05C")]
		public ObjectAnimationPlaying(string objectName, string param)
		{
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x12CE094", Offset = "0x12CE094", VA = "0x12CE094", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200014B")]
	protected class ObjectAppeared<T> : Condition where T : UnityEngine.Component
	{
		[Token(Token = "0x6000ACE")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACF")]
		public ObjectAppeared()
		{
		}
	}

	[Token(Token = "0x200014C")]
	protected class ObjectDisappeared<T> : Condition where T : UnityEngine.Component
	{
		[Token(Token = "0x6000AD0")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD1")]
		public ObjectDisappeared()
		{
		}
	}

	[Token(Token = "0x200014D")]
	protected class ObjectAppeared : Condition
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected string path;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject o;

		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x12CD138", Offset = "0x12CD138", VA = "0x12CD138")]
		public ObjectAppeared(string path)
		{
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x12CE104", Offset = "0x12CE104", VA = "0x12CE104", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x12CE1AC", Offset = "0x12CE1AC", VA = "0x12CE1AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x200014E")]
	protected class ObjectDisappeared : ObjectAppeared
	{
		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x12CE20C", Offset = "0x12CE20C", VA = "0x12CE20C")]
		public ObjectDisappeared(string path)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x12CE238", Offset = "0x12CE238", VA = "0x12CE238", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x12CE254", Offset = "0x12CE254", VA = "0x12CE254", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x200014F")]
	protected class BoolCondition : Condition
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<bool> _getter;

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x12CD8BC", Offset = "0x12CD8BC", VA = "0x12CD8BC")]
		public BoolCondition(Func<bool> getter)
		{
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x12CD8F0", Offset = "0x12CD8F0", VA = "0x12CD8F0", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x12CD950", Offset = "0x12CD950", VA = "0x12CD950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000150")]
	protected class ButtonAccessible : Condition
	{
		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject button;

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x12CD3D8", Offset = "0x12CD3D8", VA = "0x12CD3D8")]
		public ButtonAccessible(GameObject button)
		{
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x12CD9B0", Offset = "0x12CD9B0", VA = "0x12CD9B0", Slot = "4")]
		public override bool Satisfied()
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x12CDAF0", Offset = "0x12CDAF0", VA = "0x12CDAF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x12CD9CC", Offset = "0x12CD9CC", VA = "0x12CD9CC")]
		private string GetAccessibilityMessage()
		{
			return null;
		}
	}

	[Token(Token = "0x2000151")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9A8", Offset = "0xB6A9A8")]
	private sealed class <LoadSceneInternal>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string name;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x17000210")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x12CCFD0", Offset = "0x12CCFD0", VA = "0x12CCFD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000211")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x12CD03C", Offset = "0x12CD03C", VA = "0x12CD03C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x12CC818", Offset = "0x12CC818", VA = "0x12CC818")]
		[DebuggerHidden]
		public <LoadSceneInternal>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x12CCEDC", Offset = "0x12CCEDC", VA = "0x12CCEDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x12CCEE0", Offset = "0x12CCEE0", VA = "0x12CCEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x12CCFD8", Offset = "0x12CCFD8", VA = "0x12CCFD8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9B8", Offset = "0xB6A9B8")]
	private sealed class <WaitForInternal>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Condition condition;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string stackTrace;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <time>5__2;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__3;

		[Token(Token = "0x17000212")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x12CD678", Offset = "0x12CD678", VA = "0x12CD678", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000213")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AEA")]
			[Address(RVA = "0x12CD6E4", Offset = "0x12CD6E4", VA = "0x12CD6E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x12CCC84", Offset = "0x12CCC84", VA = "0x12CCC84")]
		[DebuggerHidden]
		public <WaitForInternal>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x12CD478", Offset = "0x12CD478", VA = "0x12CD478", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x12CD47C", Offset = "0x12CD47C", VA = "0x12CD47C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x12CD680", Offset = "0x12CD680", VA = "0x12CD680", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9C8", Offset = "0xB6A9C8")]
	private sealed class <PressInternal>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string buttonName;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ObjectAppeared <buttonAppeared>5__2;

		[Token(Token = "0x17000214")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x12CD164", Offset = "0x12CD164", VA = "0x12CD164", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000215")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x12CD1D0", Offset = "0x12CD1D0", VA = "0x12CD1D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x12CCCB0", Offset = "0x12CCCB0", VA = "0x12CCCB0")]
		[DebuggerHidden]
		public <PressInternal>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x12CD044", Offset = "0x12CD044", VA = "0x12CD044", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x12CD048", Offset = "0x12CD048", VA = "0x12CD048", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x12CD16C", Offset = "0x12CD16C", VA = "0x12CD16C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000154")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9D8", Offset = "0xB6A9D8")]
	private sealed class <PressInternal>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UITest <>4__this;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject o;

		[Token(Token = "0x17000216")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x12CD404", Offset = "0x12CD404", VA = "0x12CD404", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000217")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AF6")]
			[Address(RVA = "0x12CD470", Offset = "0x12CD470", VA = "0x12CD470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x12CCCDC", Offset = "0x12CCCDC", VA = "0x12CCCDC")]
		[DebuggerHidden]
		public <PressInternal>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x12CD1D8", Offset = "0x12CD1D8", VA = "0x12CD1D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x12CD1DC", Offset = "0x12CD1DC", VA = "0x12CD1DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x12CD40C", Offset = "0x12CD40C", VA = "0x12CD40C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9E8", Offset = "0xB6A9E8")]
	private sealed class <AssertLabelInternal>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UITest <>4__this;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string id;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x17000218")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x12CCE68", Offset = "0x12CCE68", VA = "0x12CCE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000219")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x12CCED4", Offset = "0x12CCED4", VA = "0x12CCED4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x12CCD08", Offset = "0x12CCD08", VA = "0x12CCD08")]
		[DebuggerHidden]
		public <AssertLabelInternal>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x12CCD68", Offset = "0x12CCD68", VA = "0x12CCD68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x12CCD6C", Offset = "0x12CCD6C", VA = "0x12CCD6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x12CCE70", Offset = "0x12CCE70", VA = "0x12CCE70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000156")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6A9F8", Offset = "0xB6A9F8")]
	private sealed class <WriteTextInternal>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string inputName;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UITest <>4__this;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string text;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectAppeared <inputAppeared>5__2;

		[Token(Token = "0x1700021A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x12CD848", Offset = "0x12CD848", VA = "0x12CD848", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700021B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x12CD8B4", Offset = "0x12CD8B4", VA = "0x12CD8B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x12CCD34", Offset = "0x12CCD34", VA = "0x12CCD34")]
		[DebuggerHidden]
		public <WriteTextInternal>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x12CD6EC", Offset = "0x12CD6EC", VA = "0x12CD6EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x12CD6F0", Offset = "0x12CD6F0", VA = "0x12CD6F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x12CD850", Offset = "0x12CD850", VA = "0x12CD850", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000034")]
	private const float WaitTimeout = 10f;

	[Token(Token = "0x4000035")]
	private const float WaitIntervalFrames = 10f;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MonoBehaviour mb;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x12CC4F8", Offset = "0x12CC4F8", VA = "0x12CC4F8")]
	protected void CreateMonoBehaviour()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x12CC60C", Offset = "0x12CC60C", VA = "0x12CC60C")]
	protected Coroutine WaitFor(Condition condition)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x12CC710", Offset = "0x12CC710", VA = "0x12CC710")]
	protected Coroutine LoadScene(string name)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x12CC798", Offset = "0x12CC798", VA = "0x12CC798")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D8D8", Offset = "0xB6D8D8")]
	private IEnumerator LoadSceneInternal(string name)
	{
		return null;
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x12CC844", Offset = "0x12CC844", VA = "0x12CC844")]
	protected Coroutine AssertLabel(string id, string text)
	{
		return null;
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x12CC95C", Offset = "0x12CC95C", VA = "0x12CC95C")]
	protected Coroutine Press(string buttonName)
	{
		return null;
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x12CCA64", Offset = "0x12CCA64", VA = "0x12CCA64")]
	protected Coroutine Press(GameObject o)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x12CCB6C", Offset = "0x12CCB6C", VA = "0x12CCB6C")]
	protected Coroutine WriteText(string inputName, string inputText)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x12CC690", Offset = "0x12CC690", VA = "0x12CC690")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D93C", Offset = "0xB6D93C")]
	private IEnumerator WaitForInternal(Condition condition, string stackTrace)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x12CC9E4", Offset = "0x12CC9E4", VA = "0x12CC9E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6D9A0", Offset = "0xB6D9A0")]
	private IEnumerator PressInternal(string buttonName)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x12CCAEC", Offset = "0x12CCAEC", VA = "0x12CCAEC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DA04", Offset = "0xB6DA04")]
	private IEnumerator PressInternal(GameObject o)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x12CC8D4", Offset = "0x12CC8D4", VA = "0x12CC8D4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DA68", Offset = "0xB6DA68")]
	private IEnumerator AssertLabelInternal(string id, string text)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x12CCBFC", Offset = "0x12CCBFC", VA = "0x12CCBFC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DACC", Offset = "0xB6DACC")]
	private IEnumerator WriteTextInternal(string inputName, string text)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x12CCD60", Offset = "0x12CCD60", VA = "0x12CCD60")]
	public UITest()
	{
	}
}
[Token(Token = "0x200000E")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x133DC6C", Offset = "0x133DC6C", VA = "0x133DC6C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x133DE28", Offset = "0x133DE28", VA = "0x133DE28", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x133E13C", Offset = "0x133E13C", VA = "0x133E13C")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x200000F")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000139")]
	[Address(RVA = "0x134097C", Offset = "0x134097C", VA = "0x134097C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1340A5C", Offset = "0x1340A5C", VA = "0x1340A5C")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000010")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xB6868C", Offset = "0xB6868C")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1340EF4", Offset = "0x1340EF4", VA = "0x1340EF4")]
	private void Update()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1340F90", Offset = "0x1340F90", VA = "0x1340F90")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000011")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000157")]
		public enum Mode
		{
			[Token(Token = "0x400068D")]
			Trigger,
			[Token(Token = "0x400068E")]
			Replace,
			[Token(Token = "0x400068F")]
			Activate,
			[Token(Token = "0x4000690")]
			Enable,
			[Token(Token = "0x4000691")]
			Animate,
			[Token(Token = "0x4000692")]
			Deactivate
		}

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x12D46CC", Offset = "0x12D46CC", VA = "0x12D46CC")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x12D4B38", Offset = "0x12D4B38", VA = "0x12D4B38")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12D4B3C", Offset = "0x12D4B3C", VA = "0x12D4B3C")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000158")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x12D54C8", Offset = "0x12D54C8", VA = "0x12D54C8")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000159")]
		public class ReplacementList
		{
			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x12D54D0", Offset = "0x12D54D0", VA = "0x12D54D0")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x12D4B54", Offset = "0x12D4B54", VA = "0x12D4B54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12D54C0", Offset = "0x12D54C0", VA = "0x12D54C0")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200015A")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x1A510A4", Offset = "0x1A510A4", VA = "0x1A510A4")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1A50F34", Offset = "0x1A50F34", VA = "0x1A50F34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1A50F5C", Offset = "0x1A50F5C", VA = "0x1A50F5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1A5109C", Offset = "0x1A5109C", VA = "0x1A5109C")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class CameraRefocus
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1A510B4", Offset = "0x1A510B4", VA = "0x1A510B4")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1A51114", Offset = "0x1A51114", VA = "0x1A51114")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1A5111C", Offset = "0x1A5111C", VA = "0x1A5111C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1A51124", Offset = "0x1A51124", VA = "0x1A51124")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1A51284", Offset = "0x1A51284", VA = "0x1A51284")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000015")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1A512D8", Offset = "0x1A512D8", VA = "0x1A512D8")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1A51380", Offset = "0x1A51380", VA = "0x1A51380")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1A514A0", Offset = "0x1A514A0", VA = "0x1A514A0")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA08", Offset = "0xB6AA08")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x1700021C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B09")]
				[Address(RVA = "0x1A51E04", Offset = "0x1A51E04", VA = "0x1A51E04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0B")]
				[Address(RVA = "0x1A51E70", Offset = "0x1A51E70", VA = "0x1A51E70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x1A51B88", Offset = "0x1A51B88", VA = "0x1A51B88")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x1A51BBC", Offset = "0x1A51BBC", VA = "0x1A51BBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x1A51BC0", Offset = "0x1A51BC0", VA = "0x1A51BC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x1A51E0C", Offset = "0x1A51E0C", VA = "0x1A51E0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000050")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000051")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000052")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000053")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000054")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000055")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1A516EC", Offset = "0x1A516EC", VA = "0x1A516EC")]
		private void Update()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1A51B04", Offset = "0x1A51B04", VA = "0x1A51B04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DB30", Offset = "0xB6DB30")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1A51A54", Offset = "0x1A51A54", VA = "0x1A51A54")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1A51BB4", Offset = "0x1A51BB4", VA = "0x1A51BB4")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1A51E78", Offset = "0x1A51E78", VA = "0x1A51E78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1A51EAC", Offset = "0x1A51EAC", VA = "0x1A51EAC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1A5212C", Offset = "0x1A5212C", VA = "0x1A5212C")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1A52914", Offset = "0x1A52914", VA = "0x1A52914")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1A529F8", Offset = "0x1A529F8", VA = "0x1A529F8")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class FOVKick
	{
		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA18", Offset = "0xB6AA18")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700021E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B0F")]
				[Address(RVA = "0x1A52744", Offset = "0x1A52744", VA = "0x1A52744", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700021F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B11")]
				[Address(RVA = "0x1A527B0", Offset = "0x1A527B0", VA = "0x1A527B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x1A52304", Offset = "0x1A52304", VA = "0x1A52304")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x1A525DC", Offset = "0x1A525DC", VA = "0x1A525DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x1A525E0", Offset = "0x1A525E0", VA = "0x1A525E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x1A5274C", Offset = "0x1A5274C", VA = "0x1A5274C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA28", Offset = "0xB6AA28")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000220")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B15")]
				[Address(RVA = "0x1A52568", Offset = "0x1A52568", VA = "0x1A52568", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000221")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B17")]
				[Address(RVA = "0x1A525D4", Offset = "0x1A525D4", VA = "0x1A525D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x1A523A4", Offset = "0x1A523A4", VA = "0x1A523A4")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x1A523EC", Offset = "0x1A523EC", VA = "0x1A523EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x1A523F0", Offset = "0x1A523F0", VA = "0x1A523F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x1A52570", Offset = "0x1A52570", VA = "0x1A52570", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1A52160", Offset = "0x1A52160", VA = "0x1A52160")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1A521A4", Offset = "0x1A521A4", VA = "0x1A521A4")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1A52288", Offset = "0x1A52288", VA = "0x1A52288")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1A52290", Offset = "0x1A52290", VA = "0x1A52290")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DB94", Offset = "0xB6DB94")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1A52330", Offset = "0x1A52330", VA = "0x1A52330")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DBF8", Offset = "0xB6DBF8")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1A523D0", Offset = "0x1A523D0", VA = "0x1A523D0")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB686F0", Offset = "0xB686F0")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400006A")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400006E")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1A527B8", Offset = "0x1A527B8", VA = "0x1A527B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1A52824", Offset = "0x1A52824", VA = "0x1A52824")]
		private void Update()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1A5290C", Offset = "0x1A5290C", VA = "0x1A5290C")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001B")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA38", Offset = "0xB6AA38")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000222")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1B")]
				[Address(RVA = "0x1A52CF0", Offset = "0x1A52CF0", VA = "0x1A52CF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000223")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B1D")]
				[Address(RVA = "0x1A52D5C", Offset = "0x1A52D5C", VA = "0x1A52D5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x1A52AD4", Offset = "0x1A52AD4", VA = "0x1A52AD4")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x1A52B08", Offset = "0x1A52B08", VA = "0x1A52B08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x1A52B0C", Offset = "0x1A52B0C", VA = "0x1A52B0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x1A52CF8", Offset = "0x1A52CF8", VA = "0x1A52CF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1A52A58", Offset = "0x1A52A58", VA = "0x1A52A58")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1A52A60", Offset = "0x1A52A60", VA = "0x1A52A60")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DC5C", Offset = "0xB6DC5C")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1A52B00", Offset = "0x1A52B00", VA = "0x1A52B00")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA48", Offset = "0xB6AA48")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000224")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B21")]
				[Address(RVA = "0x1A53170", Offset = "0x1A53170", VA = "0x1A53170", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000225")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B23")]
				[Address(RVA = "0x1A531DC", Offset = "0x1A531DC", VA = "0x1A531DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x1A52F00", Offset = "0x1A52F00", VA = "0x1A52F00")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1A52F34", Offset = "0x1A52F34", VA = "0x1A52F34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1A52F38", Offset = "0x1A52F38", VA = "0x1A52F38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1A53178", Offset = "0x1A53178", VA = "0x1A53178", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1A52D64", Offset = "0x1A52D64", VA = "0x1A52D64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1A52E50", Offset = "0x1A52E50", VA = "0x1A52E50")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1A52E7C", Offset = "0x1A52E7C", VA = "0x1A52E7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DCC0", Offset = "0xB6DCC0")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x1A52F2C", Offset = "0x1A52F2C", VA = "0x1A52F2C")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA58", Offset = "0xB6AA58")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000226")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B27")]
				[Address(RVA = "0x1A535E8", Offset = "0x1A535E8", VA = "0x1A535E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000227")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B29")]
				[Address(RVA = "0x1A53654", Offset = "0x1A53654", VA = "0x1A53654", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x1A53258", Offset = "0x1A53258", VA = "0x1A53258")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x1A532A4", Offset = "0x1A532A4", VA = "0x1A532A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x1A532A8", Offset = "0x1A532A8", VA = "0x1A532A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x1A535F0", Offset = "0x1A535F0", VA = "0x1A535F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1A531E4", Offset = "0x1A531E4", VA = "0x1A531E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DD24", Offset = "0xB6DD24")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x1A53284", Offset = "0x1A53284", VA = "0x1A53284")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x1A53290", Offset = "0x1A53290", VA = "0x1A53290")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000161")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x40006B5")]
			Standalone,
			[Token(Token = "0x40006B6")]
			Mobile
		}

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1A5365C", Offset = "0x1A5365C", VA = "0x1A5365C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1A53660", Offset = "0x1A53660", VA = "0x1A53660")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x1A5367C", Offset = "0x1A5367C", VA = "0x1A5367C")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1A53A10", Offset = "0x1A53A10", VA = "0x1A53A10")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GUIText camSwitchButton;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject[] objects;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x1A53A88", Offset = "0x1A53A88", VA = "0x1A53A88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x1A53AF4", Offset = "0x1A53AF4", VA = "0x1A53AF4")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1A53BD0", Offset = "0x1A53BD0", VA = "0x1A53BD0")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1A53BD8", Offset = "0x1A53BD8", VA = "0x1A53BD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1A53C14", Offset = "0x1A53C14", VA = "0x1A53C14")]
		private void Update()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1A53F9C", Offset = "0x1A53F9C", VA = "0x1A53F9C")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1A54060", Offset = "0x1A54060", VA = "0x1A54060")]
		private void Start()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1A54064", Offset = "0x1A54064", VA = "0x1A54064")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1A5439C", Offset = "0x1A5439C", VA = "0x1A5439C")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000162")]
		public enum Action
		{
			[Token(Token = "0x40006B8")]
			Activate,
			[Token(Token = "0x40006B9")]
			Deactivate,
			[Token(Token = "0x40006BA")]
			Destroy,
			[Token(Token = "0x40006BB")]
			ReloadLevel,
			[Token(Token = "0x40006BC")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class Entry
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000B2A")]
			[Address(RVA = "0x1A54B10", Offset = "0x1A54B10", VA = "0x1A54B10")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public class Entries
		{
			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x1A5472C", Offset = "0x1A5472C", VA = "0x1A5472C")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA68", Offset = "0xB6AA68")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000228")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B2F")]
				[Address(RVA = "0x1A54804", Offset = "0x1A54804", VA = "0x1A54804", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000229")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B31")]
				[Address(RVA = "0x1A54870", Offset = "0x1A54870", VA = "0x1A54870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x1A54640", Offset = "0x1A54640", VA = "0x1A54640")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x1A54734", Offset = "0x1A54734", VA = "0x1A54734", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x1A54738", Offset = "0x1A54738", VA = "0x1A54738", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x1A5480C", Offset = "0x1A5480C", VA = "0x1A5480C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA78", Offset = "0xB6AA78")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700022A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B35")]
				[Address(RVA = "0x1A54948", Offset = "0x1A54948", VA = "0x1A54948", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B37")]
				[Address(RVA = "0x1A549B4", Offset = "0x1A549B4", VA = "0x1A549B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x1A5466C", Offset = "0x1A5466C", VA = "0x1A5466C")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x1A54878", Offset = "0x1A54878", VA = "0x1A54878", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B34")]
			[Address(RVA = "0x1A5487C", Offset = "0x1A5487C", VA = "0x1A5487C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0x1A54950", Offset = "0x1A54950", VA = "0x1A54950", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA88", Offset = "0xB6AA88")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700022C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B3B")]
				[Address(RVA = "0x1A54A9C", Offset = "0x1A54A9C", VA = "0x1A54A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B3D")]
				[Address(RVA = "0x1A54B08", Offset = "0x1A54B08", VA = "0x1A54B08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0x1A54698", Offset = "0x1A54698", VA = "0x1A54698")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x1A549BC", Offset = "0x1A549BC", VA = "0x1A549BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x1A549C0", Offset = "0x1A549C0", VA = "0x1A549C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x1A54AA4", Offset = "0x1A54AA4", VA = "0x1A54AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1A543B0", Offset = "0x1A543B0", VA = "0x1A543B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1A544E4", Offset = "0x1A544E4", VA = "0x1A544E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DD88", Offset = "0xB6DD88")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1A54558", Offset = "0x1A54558", VA = "0x1A54558")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DDEC", Offset = "0xB6DDEC")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1A545CC", Offset = "0x1A545CC", VA = "0x1A545CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DE50", Offset = "0xB6DE50")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1A546C4", Offset = "0x1A546C4", VA = "0x1A546C4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1A54B18", Offset = "0x1A54B18", VA = "0x1A54B18")]
		private void Awake()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1A54B70", Offset = "0x1A54B70", VA = "0x1A54B70")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x1A54C10", Offset = "0x1A54C10", VA = "0x1A54C10")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000168")]
		public class WaypointList
		{
			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x1A55A94", Offset = "0x1A55A94", VA = "0x1A55A94")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000169")]
		public struct RoutePoint
		{
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0xC52704", Offset = "0xC52704", VA = "0xC52704")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ADB8", Offset = "0xB6ADB8")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000004")]
		public float Length
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1A54C20", Offset = "0x1A54C20", VA = "0x1A54C20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DEB4", Offset = "0xB6DEB4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1A54C28", Offset = "0x1A54C28", VA = "0x1A54C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DEC4", Offset = "0xB6DEC4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1A54C30", Offset = "0x1A54C30", VA = "0x1A54C30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1A54C50", Offset = "0x1A54C50", VA = "0x1A54C50")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1A54F98", Offset = "0x1A54F98", VA = "0x1A54F98")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1A550A8", Offset = "0x1A550A8", VA = "0x1A550A8")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1A55430", Offset = "0x1A55430", VA = "0x1A55430")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1A54CB0", Offset = "0x1A54CB0", VA = "0x1A54CB0")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1A5578C", Offset = "0x1A5578C", VA = "0x1A5578C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1A55A18", Offset = "0x1A55A18", VA = "0x1A55A18")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1A55794", Offset = "0x1A55794", VA = "0x1A55794")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1A55A20", Offset = "0x1A55A20", VA = "0x1A55A20")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200016A")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40006CF")]
			SmoothAlongRoute,
			[Token(Token = "0x40006D0")]
			PointToPoint
		}

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AE38", Offset = "0xB6AE38")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AE48", Offset = "0xB6AE48")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AE58", Offset = "0xB6AE58")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000006")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x1A55AF4", Offset = "0x1A55AF4", VA = "0x1A55AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DED4", Offset = "0xB6DED4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1A55B08", Offset = "0x1A55B08", VA = "0x1A55B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DEE4", Offset = "0xB6DEE4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1A55B1C", Offset = "0x1A55B1C", VA = "0x1A55B1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DEF4", Offset = "0xB6DEF4")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x1A55B30", Offset = "0x1A55B30", VA = "0x1A55B30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DF04", Offset = "0xB6DF04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x1A55B44", Offset = "0x1A55B44", VA = "0x1A55B44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DF14", Offset = "0xB6DF14")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1A55B58", Offset = "0x1A55B58", VA = "0x1A55B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6DF24", Offset = "0xB6DF24")]
			private set
			{
			}
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1A55B6C", Offset = "0x1A55B6C", VA = "0x1A55B6C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1A55C54", Offset = "0x1A55C54", VA = "0x1A55C54")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1A55D38", Offset = "0x1A55D38", VA = "0x1A55D38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1A562AC", Offset = "0x1A562AC", VA = "0x1A562AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1A56484", Offset = "0x1A56484", VA = "0x1A56484")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68754", Offset = "0xB68754")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x12D1ED0", Offset = "0x12D1ED0", VA = "0x12D1ED0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x12D1F68", Offset = "0x12D1F68", VA = "0x12D1F68")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x12D2434", Offset = "0x12D2434", VA = "0x12D2434")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x12D2984", Offset = "0x12D2984", VA = "0x12D2984")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AA98", Offset = "0xB6AA98")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700022E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B43")]
				[Address(RVA = "0x12D31BC", Offset = "0x12D31BC", VA = "0x12D31BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700022F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B45")]
				[Address(RVA = "0x12D3228", Offset = "0x12D3228", VA = "0x12D3228", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x12D2A0C", Offset = "0x12D2A0C", VA = "0x12D2A0C")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x12D2BC4", Offset = "0x12D2BC4", VA = "0x12D2BC4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x12D2BC8", Offset = "0x12D2BC8", VA = "0x12D2BC8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x12D31C4", Offset = "0x12D31C4", VA = "0x12D31C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x12D2998", Offset = "0x12D2998", VA = "0x12D2998")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DF34", Offset = "0xB6DF34")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x12D2A38", Offset = "0x12D2A38", VA = "0x12D2A38")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x12D2BBC", Offset = "0x12D2BBC", VA = "0x12D2BBC")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAA8", Offset = "0xB6AAA8")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000230")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B49")]
				[Address(RVA = "0x12D35F4", Offset = "0x12D35F4", VA = "0x12D35F4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000231")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B4B")]
				[Address(RVA = "0x12D3660", Offset = "0x12D3660", VA = "0x12D3660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x12D32A4", Offset = "0x12D32A4", VA = "0x12D32A4")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x12D32E0", Offset = "0x12D32E0", VA = "0x12D32E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x12D32E4", Offset = "0x12D32E4", VA = "0x12D32E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x12D35FC", Offset = "0x12D35FC", VA = "0x12D35FC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x12D3230", Offset = "0x12D3230", VA = "0x12D3230")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DF98", Offset = "0xB6DF98")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x12D32D0", Offset = "0x12D32D0", VA = "0x12D32D0")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAB8", Offset = "0xB6AAB8")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x17000232")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B4F")]
				[Address(RVA = "0x12D3A88", Offset = "0x12D3A88", VA = "0x12D3A88", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000233")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B51")]
				[Address(RVA = "0x12D3AF4", Offset = "0x12D3AF4", VA = "0x12D3AF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x12D3740", Offset = "0x12D3740", VA = "0x12D3740")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x12D3798", Offset = "0x12D3798", VA = "0x12D3798", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B4E")]
			[Address(RVA = "0x12D379C", Offset = "0x12D379C", VA = "0x12D379C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B50")]
			[Address(RVA = "0x12D3A90", Offset = "0x12D3A90", VA = "0x12D3A90", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x12D3668", Offset = "0x12D3668", VA = "0x12D3668")]
		private void Start()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x12D36C0", Offset = "0x12D36C0", VA = "0x12D36C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6DFFC", Offset = "0xB6DFFC")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x12D376C", Offset = "0x12D376C", VA = "0x12D376C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x12D3774", Offset = "0x12D3774", VA = "0x12D3774")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x12D3AFC", Offset = "0x12D3AFC", VA = "0x12D3AFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x12D3B54", Offset = "0x12D3B54", VA = "0x12D3B54")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x12D3BEC", Offset = "0x12D3BEC", VA = "0x12D3BEC")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x12D3BFC", Offset = "0x12D3BFC", VA = "0x12D3BFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x12D3C6C", Offset = "0x12D3C6C", VA = "0x12D3C6C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x12D3ED0", Offset = "0x12D3ED0", VA = "0x12D3ED0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x12D3EF8", Offset = "0x12D3EF8", VA = "0x12D3EF8")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x12D3F08", Offset = "0x12D3F08", VA = "0x12D3F08")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x12D40D4", Offset = "0x12D40D4", VA = "0x12D40D4")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x12D40F0", Offset = "0x12D40F0", VA = "0x12D40F0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x12D4284", Offset = "0x12D4284", VA = "0x12D4284")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x12D4294", Offset = "0x12D4294", VA = "0x12D4294")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x12D4360", Offset = "0x12D4360", VA = "0x12D4360")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x12D4368", Offset = "0x12D4368", VA = "0x12D4368")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x12D43C0", Offset = "0x12D43C0", VA = "0x12D43C0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x12D4654", Offset = "0x12D4654", VA = "0x12D4654")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000030")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x12CE2F8", Offset = "0x12CE2F8", VA = "0x12CE2F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x12CE588", Offset = "0x12CE588", VA = "0x12CE588")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x12CE70C", Offset = "0x12CE70C", VA = "0x12CE70C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x12CE78C", Offset = "0x12CE78C", VA = "0x12CE78C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x12CE878", Offset = "0x12CE878", VA = "0x12CE878", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x12CE924", Offset = "0x12CE924", VA = "0x12CE924")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x12CE98C", Offset = "0x12CE98C", VA = "0x12CE98C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x12CE990", Offset = "0x12CE990", VA = "0x12CE990")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x12CEA78", Offset = "0x12CEA78", VA = "0x12CEA78")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x12CEB60", Offset = "0x12CEB60", VA = "0x12CEB60")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x12CEC48", Offset = "0x12CEC48", VA = "0x12CEC48")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x12CED30", Offset = "0x12CED30", VA = "0x12CED30")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x12CEE18", Offset = "0x12CEE18", VA = "0x12CEE18")]
		public void Update()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x12CEE1C", Offset = "0x12CEE1C", VA = "0x12CEE1C")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200016E")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40006DD")]
			Hardware,
			[Token(Token = "0x40006DE")]
			Touch
		}

		[Token(Token = "0x200016F")]
		public class VirtualAxis
		{
			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D4F4", Offset = "0xB6D4F4")]
			private string <name>k__BackingField;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D504", Offset = "0xB6D504")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000234")]
			public string name
			{
				[Token(Token = "0x6000B52")]
				[Address(RVA = "0x12CFD84", Offset = "0x12CFD84", VA = "0x12CFD84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FE64", Offset = "0xB6FE64")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B53")]
				[Address(RVA = "0x12CFD8C", Offset = "0x12CFD8C", VA = "0x12CFD8C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FE74", Offset = "0xB6FE74")]
				private set
				{
				}
			}

			[Token(Token = "0x17000235")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000B54")]
				[Address(RVA = "0x12CFD94", Offset = "0x12CFD94", VA = "0x12CFD94")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FE84", Offset = "0xB6FE84")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B55")]
				[Address(RVA = "0x12CFD9C", Offset = "0x12CFD9C", VA = "0x12CFD9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FE94", Offset = "0xB6FE94")]
				private set
				{
				}
			}

			[Token(Token = "0x17000236")]
			public float GetValue
			{
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0x12CFDF0", Offset = "0x12CFDF0", VA = "0x12CFDF0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000237")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000B5B")]
				[Address(RVA = "0x12CFDF8", Offset = "0x12CFDF8", VA = "0x12CFDF8")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0x12CE464", Offset = "0x12CE464", VA = "0x12CE464")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0x12CFDA8", Offset = "0x12CFDA8", VA = "0x12CFDA8")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x12CE724", Offset = "0x12CE724", VA = "0x12CE724")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0x12CFDE8", Offset = "0x12CFDE8", VA = "0x12CFDE8")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000170")]
		public class VirtualButton
		{
			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D514", Offset = "0xB6D514")]
			private string <name>k__BackingField;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D524", Offset = "0xB6D524")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000238")]
			public string name
			{
				[Token(Token = "0x6000B5C")]
				[Address(RVA = "0x12CFE00", Offset = "0x12CFE00", VA = "0x12CFE00")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FEA4", Offset = "0xB6FEA4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000B5D")]
				[Address(RVA = "0x12CFE08", Offset = "0x12CFE08", VA = "0x12CFE08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FEB4", Offset = "0xB6FEB4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000239")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000B5E")]
				[Address(RVA = "0x12CFE10", Offset = "0x12CFE10", VA = "0x12CFE10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FEC4", Offset = "0xB6FEC4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000B5F")]
				[Address(RVA = "0x12CFE18", Offset = "0x12CFE18", VA = "0x12CFE18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6FED4", Offset = "0xB6FED4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700023A")]
			public bool GetButton
			{
				[Token(Token = "0x6000B65")]
				[Address(RVA = "0x12CFF74", Offset = "0x12CFF74", VA = "0x12CFF74")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700023B")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000B66")]
				[Address(RVA = "0x12CFF7C", Offset = "0x12CFF7C", VA = "0x12CFF7C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700023C")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000B67")]
				[Address(RVA = "0x12CFFAC", Offset = "0x12CFFAC", VA = "0x12CFFAC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x12CFE24", Offset = "0x12CFE24", VA = "0x12CFE24")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x12CFE60", Offset = "0x12CFE60", VA = "0x12CFE60")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000B62")]
			[Address(RVA = "0x12CFEA8", Offset = "0x12CFEA8", VA = "0x12CFEA8")]
			public void Pressed()
			{
			}

			[Token(Token = "0x6000B63")]
			[Address(RVA = "0x12CFEE0", Offset = "0x12CFEE0", VA = "0x12CFEE0")]
			public void Released()
			{
			}

			[Token(Token = "0x6000B64")]
			[Address(RVA = "0x12CFF0C", Offset = "0x12CFF0C", VA = "0x12CFF0C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000009")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x12CF9F8", Offset = "0x12CF9F8", VA = "0x12CF9F8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x12CEE24", Offset = "0x12CEE24", VA = "0x12CEE24")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x12CEEC4", Offset = "0x12CEEC4", VA = "0x12CEEC4")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x12CE3EC", Offset = "0x12CE3EC", VA = "0x12CE3EC")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x12CEFDC", Offset = "0x12CEFDC", VA = "0x12CEFDC")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x12CE498", Offset = "0x12CE498", VA = "0x12CE498")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x12CF1E8", Offset = "0x12CF1E8", VA = "0x12CF1E8")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x12CF38C", Offset = "0x12CF38C", VA = "0x12CF38C")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x12CF4E0", Offset = "0x12CF4E0", VA = "0x12CF4E0")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x12CE510", Offset = "0x12CE510", VA = "0x12CE510")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x12CF684", Offset = "0x12CF684", VA = "0x12CF684")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x12CF77C", Offset = "0x12CF77C", VA = "0x12CF77C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x12CF6EC", Offset = "0x12CF6EC", VA = "0x12CF6EC")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x12CF7E4", Offset = "0x12CF7E4", VA = "0x12CF7E4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x12CF864", Offset = "0x12CF864", VA = "0x12CF864")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x12CF8E4", Offset = "0x12CF8E4", VA = "0x12CF8E4")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x12CE9F8", Offset = "0x12CE9F8", VA = "0x12CE9F8")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x12CEAE0", Offset = "0x12CEAE0", VA = "0x12CEAE0")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x12CEBC8", Offset = "0x12CEBC8", VA = "0x12CEBC8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x12CED98", Offset = "0x12CED98", VA = "0x12CED98")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x12CECB0", Offset = "0x12CECB0", VA = "0x12CECB0")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x12CF964", Offset = "0x12CF964", VA = "0x12CF964")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x12CFA74", Offset = "0x12CFA74", VA = "0x12CFA74")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x12CFB74", Offset = "0x12CFB74", VA = "0x12CFB74")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x12CFC80", Offset = "0x12CFC80", VA = "0x12CFC80")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x12CFFDC", Offset = "0x12CFFDC", VA = "0x12CFFDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x12CFFE0", Offset = "0x12CFFE0", VA = "0x12CFFE0")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x12D0060", Offset = "0x12D0060", VA = "0x12D0060")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000171")]
		public enum AxisOption
		{
			[Token(Token = "0x40006E8")]
			Both,
			[Token(Token = "0x40006E9")]
			OnlyHorizontal,
			[Token(Token = "0x40006EA")]
			OnlyVertical
		}

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x12D0068", Offset = "0x12D0068", VA = "0x12D0068")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x12D01AC", Offset = "0x12D01AC", VA = "0x12D01AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x12D01E8", Offset = "0x12D01E8", VA = "0x12D01E8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x12D006C", Offset = "0x12D006C", VA = "0x12D006C")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x12D02DC", Offset = "0x12D02DC", VA = "0x12D02DC", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x12D049C", Offset = "0x12D049C", VA = "0x12D049C", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x12D04E4", Offset = "0x12D04E4", VA = "0x12D04E4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x12D04E8", Offset = "0x12D04E8", VA = "0x12D04E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x12D0538", Offset = "0x12D0538", VA = "0x12D0538")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x12D05A8", Offset = "0x12D05A8", VA = "0x12D05A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x12D05B8", Offset = "0x12D05B8", VA = "0x12D05B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x12D05B0", Offset = "0x12D05B0", VA = "0x12D05B0")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x12D0698", Offset = "0x12D0698", VA = "0x12D0698")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x12D0944", Offset = "0x12D0944", VA = "0x12D0944")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000172")]
		public enum AxisOptions
		{
			[Token(Token = "0x40006EC")]
			ForwardAxis,
			[Token(Token = "0x40006ED")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000173")]
		public class AxisMapping
		{
			[Token(Token = "0x20001DD")]
			public enum MappingType
			{
				[Token(Token = "0x4000861")]
				NamedAxis,
				[Token(Token = "0x4000862")]
				MousePositionX,
				[Token(Token = "0x4000863")]
				MousePositionY,
				[Token(Token = "0x4000864")]
				MousePositionZ
			}

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x12D1814", Offset = "0x12D1814", VA = "0x12D1814")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x12D1498", Offset = "0x12D1498", VA = "0x12D1498")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x12D155C", Offset = "0x12D155C", VA = "0x12D155C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x12D17EC", Offset = "0x12D17EC", VA = "0x12D17EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x12D1804", Offset = "0x12D1804", VA = "0x12D1804")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB687C8", Offset = "0xB687C8")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000174")]
		public enum AxisOption
		{
			[Token(Token = "0x40006F1")]
			Both,
			[Token(Token = "0x40006F2")]
			OnlyHorizontal,
			[Token(Token = "0x40006F3")]
			OnlyVertical
		}

		[Token(Token = "0x2000175")]
		public enum ControlStyle
		{
			[Token(Token = "0x40006F5")]
			Absolute,
			[Token(Token = "0x40006F6")]
			Relative,
			[Token(Token = "0x40006F7")]
			Swipe
		}

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x12D181C", Offset = "0x12D181C", VA = "0x12D181C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x12D1960", Offset = "0x12D1960", VA = "0x12D1960")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x12D1820", Offset = "0x12D1820", VA = "0x12D1820")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x12D19DC", Offset = "0x12D19DC", VA = "0x12D19DC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x12D1A4C", Offset = "0x12D1A4C", VA = "0x12D1A4C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x12D1B00", Offset = "0x12D1B00", VA = "0x12D1B00")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x12D1CD8", Offset = "0x12D1CD8", VA = "0x12D1CD8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x12D1D50", Offset = "0x12D1D50", VA = "0x12D1D50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x12D1E44", Offset = "0x12D1E44", VA = "0x12D1E44")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AE68", Offset = "0xB6AE68")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700000A")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x12D1EB8", Offset = "0x12D1EB8", VA = "0x12D1EB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E060", Offset = "0xB6E060")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x12D1EC4", Offset = "0x12D1EC4", VA = "0x12D1EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E070", Offset = "0xB6E070")]
			private set
			{
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x12CEF74", Offset = "0x12CEF74", VA = "0x12CEF74")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x12CF054", Offset = "0x12CF054", VA = "0x12CF054")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x12CF0BC", Offset = "0x12CF0BC", VA = "0x12CF0BC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x12CF260", Offset = "0x12CF260", VA = "0x12CF260")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x12CF448", Offset = "0x12CF448", VA = "0x12CF448")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x12CF558", Offset = "0x12CF558", VA = "0x12CF558")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x12CF5F0", Offset = "0x12CF5F0", VA = "0x12CF5F0")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x12CFB28", Offset = "0x12CFB28", VA = "0x12CFB28")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x12CFC2C", Offset = "0x12CFC2C", VA = "0x12CFC2C")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x12CFD34", Offset = "0x12CFD34", VA = "0x12CFD34")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000203")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000204")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000205")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000206")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000207")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000208")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000209")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600020A")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600020B")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600020C")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600020D")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12D10F8", Offset = "0x12D10F8", VA = "0x12D10F8")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000039")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x12D094C", Offset = "0x12D094C", VA = "0x12D094C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12D09E0", Offset = "0x12D09E0", VA = "0x12D09E0")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x12D0A6C", Offset = "0x12D0A6C", VA = "0x12D0A6C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x12D0B08", Offset = "0x12D0B08", VA = "0x12D0B08", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x12D0BC0", Offset = "0x12D0BC0", VA = "0x12D0BC0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x12D0C6C", Offset = "0x12D0C6C", VA = "0x12D0C6C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x12D0D0C", Offset = "0x12D0D0C", VA = "0x12D0D0C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x12D0DAC", Offset = "0x12D0DAC", VA = "0x12D0DAC", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x12D0E48", Offset = "0x12D0E48", VA = "0x12D0E48", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x12D0EF0", Offset = "0x12D0EF0", VA = "0x12D0EF0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x12D0FA0", Offset = "0x12D0FA0", VA = "0x12D0FA0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x12D1050", Offset = "0x12D1050", VA = "0x12D1050", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x12D10EC", Offset = "0x12D10EC", VA = "0x12D10EC", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x12CEEBC", Offset = "0x12CEEBC", VA = "0x12CEEBC")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x12D11B8", Offset = "0x12D11B8", VA = "0x12D11B8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12D11CC", Offset = "0x12D11CC", VA = "0x12D11CC", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x12D11D8", Offset = "0x12D11D8", VA = "0x12D11D8", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12D11E4", Offset = "0x12D11E4", VA = "0x12D11E4", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x12D11F0", Offset = "0x12D11F0", VA = "0x12D11F0", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12D1260", Offset = "0x12D1260", VA = "0x12D1260", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x12D12D0", Offset = "0x12D12D0", VA = "0x12D12D0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x12D1340", Offset = "0x12D1340", VA = "0x12D1340", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x12D13B0", Offset = "0x12D13B0", VA = "0x12D13B0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x12D1420", Offset = "0x12D1420", VA = "0x12D1420", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x12D1490", Offset = "0x12D1490", VA = "0x12D1490", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x12CEEC0", Offset = "0x12CEEC0", VA = "0x12CEEC0")]
		public StandaloneInput()
		{
		}
	}
}
namespace SRF
{
	[Token(Token = "0x200003B")]
	public static class Json
	{
		[Token(Token = "0x2000176")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x20001DE")]
			private enum TOKEN
			{
				[Token(Token = "0x4000866")]
				NONE,
				[Token(Token = "0x4000867")]
				CURLY_OPEN,
				[Token(Token = "0x4000868")]
				CURLY_CLOSE,
				[Token(Token = "0x4000869")]
				SQUARED_OPEN,
				[Token(Token = "0x400086A")]
				SQUARED_CLOSE,
				[Token(Token = "0x400086B")]
				COLON,
				[Token(Token = "0x400086C")]
				COMMA,
				[Token(Token = "0x400086D")]
				STRING,
				[Token(Token = "0x400086E")]
				NUMBER,
				[Token(Token = "0x400086F")]
				TRUE,
				[Token(Token = "0x4000870")]
				FALSE,
				[Token(Token = "0x4000871")]
				NULL
			}

			[Token(Token = "0x40006F8")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x1700023D")]
			private char PeekChar
			{
				[Token(Token = "0x6000B6A")]
				[Address(RVA = "0x12BD908", Offset = "0x12BD908", VA = "0x12BD908")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700023E")]
			private char NextChar
			{
				[Token(Token = "0x6000B6B")]
				[Address(RVA = "0x12BD990", Offset = "0x12BD990", VA = "0x12BD990")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700023F")]
			private string NextWord
			{
				[Token(Token = "0x6000B6C")]
				[Address(RVA = "0x12BDA18", Offset = "0x12BDA18", VA = "0x12BDA18")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000240")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000B6D")]
				[Address(RVA = "0x12BDB78", Offset = "0x12BDB78", VA = "0x12BDB78")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x12BD88C", Offset = "0x12BD88C", VA = "0x12BD88C")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x12BDDDC", Offset = "0x12BDDDC", VA = "0x12BDDDC", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x12BDAD8", Offset = "0x12BDAD8", VA = "0x12BDAD8")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x12BD6C8", Offset = "0x12BD6C8", VA = "0x12BD6C8")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x12BDE38", Offset = "0x12BDE38", VA = "0x12BDE38")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x12BE1E0", Offset = "0x12BE1E0", VA = "0x12BE1E0")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x12BDE10", Offset = "0x12BDE10", VA = "0x12BDE10")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x12BE2C0", Offset = "0x12BE2C0", VA = "0x12BE2C0")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x12BDF54", Offset = "0x12BDF54", VA = "0x12BDF54")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x12BE39C", Offset = "0x12BE39C", VA = "0x12BE39C")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x12BDD28", Offset = "0x12BDD28", VA = "0x12BDD28")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x2000177")]
		private sealed class Serializer
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x12BE47C", Offset = "0x12BE47C", VA = "0x12BE47C")]
			private Serializer()
			{
			}

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x12BD80C", Offset = "0x12BD80C", VA = "0x12BD80C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x12BE4E8", Offset = "0x12BE4E8", VA = "0x12BE4E8")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x12BEBD8", Offset = "0x12BEBD8", VA = "0x12BEBD8")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x12BE900", Offset = "0x12BE900", VA = "0x12BE900")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x6000B7D")]
			[Address(RVA = "0x12BE694", Offset = "0x12BE694", VA = "0x12BE694")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x12BEFE8", Offset = "0x12BEFE8", VA = "0x12BEFE8")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x12BD6BC", Offset = "0x12BD6BC", VA = "0x12BD6BC")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x12BD808", Offset = "0x12BD808", VA = "0x12BD808")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB6882C", Offset = "0xB6882C")]
	public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAC8", Offset = "0xB6AAC8")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRList<T> <>4__this;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x17000241")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000B82")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x17000242")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B84")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B7F")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000B80")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B81")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B83")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T[] _buffer;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int _count;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private EqualityComparer<T> _equalityComparer;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ReadOnlyCollection<T> _readOnlyWrapper;

		[Token(Token = "0x1700000B")]
		public T[] Buffer
		{
			[Token(Token = "0x600022E")]
			get
			{
				return null;
			}
			[Token(Token = "0x600022F")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		private EqualityComparer<T> EqualityComparer
		{
			[Token(Token = "0x6000230")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public int Count
		{
			[Token(Token = "0x6000231")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000232")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600023A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		public T Item
		{
			[Token(Token = "0x600023E")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600023F")]
			set
			{
			}
		}

		[Token(Token = "0x600022B")]
		public SRList()
		{
		}

		[Token(Token = "0x600022C")]
		public SRList(int capacity)
		{
		}

		[Token(Token = "0x600022D")]
		public SRList(IEnumerable<T> source)
		{
		}

		[Token(Token = "0x6000233")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E080", Offset = "0xB6E080")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000234")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x6000236")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000237")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000239")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600023B")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600023C")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x600023D")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000240")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000241")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000242")]
		public void AddRange(IEnumerable<T> range)
		{
		}

		[Token(Token = "0x6000243")]
		public void Clear(bool clean)
		{
		}

		[Token(Token = "0x6000244")]
		public void Clean()
		{
		}

		[Token(Token = "0x6000245")]
		public ReadOnlyCollection<T> AsReadOnly()
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		private void Expand()
		{
		}

		[Token(Token = "0x6000247")]
		public void Trim()
		{
		}

		[Token(Token = "0x6000248")]
		public void Sort(Comparison<T> comparer)
		{
		}
	}
	[Token(Token = "0x200003D")]
	public abstract class SRMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider _collider;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _transform;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody _rigidBody;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GameObject _gameObject;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody2D _rigidbody2D;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider2D _collider2D;

		[Token(Token = "0x17000010")]
		public Transform CachedTransform
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x12BFED4", Offset = "0x12BFED4", VA = "0x12BFED4")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		public Collider CachedCollider
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x12BFF64", Offset = "0x12BFF64", VA = "0x12BFF64")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		public Collider2D CachedCollider2D
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x12BFFFC", Offset = "0x12BFFFC", VA = "0x12BFFFC")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public Rigidbody CachedRigidBody
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x12C0094", Offset = "0x12C0094", VA = "0x12C0094")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public Rigidbody2D CachedRigidBody2D
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x12C012C", Offset = "0x12C012C", VA = "0x12C012C")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public GameObject CachedGameObject
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x12C01C4", Offset = "0x12C01C4", VA = "0x12C01C4")]
			[DebuggerStepThrough]
			[DebuggerNonUserCode]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public new Transform transform
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x12C0254", Offset = "0x12C0254", VA = "0x12C0254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public Collider collider
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x12C0258", Offset = "0x12C0258", VA = "0x12C0258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public Collider2D collider2D
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x12C025C", Offset = "0x12C025C", VA = "0x12C025C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Rigidbody rigidbody
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0x12C0260", Offset = "0x12C0260", VA = "0x12C0260")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public Rigidbody2D rigidbody2D
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x12C0264", Offset = "0x12C0264", VA = "0x12C0264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public new GameObject gameObject
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x12C0268", Offset = "0x12C0268", VA = "0x12C0268")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x12C026C", Offset = "0x12C026C", VA = "0x12C026C")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void AssertNotNull(object value, [Optional] string fieldName)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x12C0284", Offset = "0x12C0284", VA = "0x12C0284")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void Assert(bool condition, [Optional] string message)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x12C02A0", Offset = "0x12C02A0", VA = "0x12C02A0")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6E2A4", Offset = "0xB6E2A4")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssertNotNull(object value, [Optional] string fieldName)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x12C02B8", Offset = "0x12C02B8", VA = "0x12C02B8")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6E300", Offset = "0xB6E300")]
		[DebuggerNonUserCode]
		[DebuggerStepThrough]
		protected void EditorAssert(bool condition, [Optional] string message)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x12C02D4", Offset = "0x12C02D4", VA = "0x12C02D4")]
		protected SRMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB68864", Offset = "0xB68864")]
	public sealed class RequiredFieldAttribute : Attribute
	{
		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _autoCreate;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _autoSearch;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool _editorOnly;

		[Token(Token = "0x1700001C")]
		public bool AutoSearch
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x12BF298", Offset = "0x12BF298", VA = "0x12BF298")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x12BF2A0", Offset = "0x12BF2A0", VA = "0x12BF2A0")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool AutoCreate
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x12BF2AC", Offset = "0x12BF2AC", VA = "0x12BF2AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x12BF2B4", Offset = "0x12BF2B4", VA = "0x12BF2B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB70364", Offset = "0xB70364")]
		public bool EditorOnly
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x12BF2C0", Offset = "0x12BF2C0", VA = "0x12BF2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x12BF2C8", Offset = "0x12BF2C8", VA = "0x12BF2C8")]
			set
			{
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x12BF250", Offset = "0x12BF250", VA = "0x12BF250")]
		public RequiredFieldAttribute(bool autoSearch)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x12BF288", Offset = "0x12BF288", VA = "0x12BF288")]
		public RequiredFieldAttribute()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB68878", Offset = "0xB68878")]
	public class ImportAttribute : Attribute
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type Service;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x12BD688", Offset = "0x12BD688", VA = "0x12BD688")]
		public ImportAttribute()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x12BD690", Offset = "0x12BD690", VA = "0x12BD690")]
		public ImportAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public abstract class SRMonoBehaviourEx : SRMonoBehaviour
	{
		[Token(Token = "0x2000179")]
		private struct FieldInfo
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool AutoCreate;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool AutoSet;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public System.Reflection.FieldInfo Field;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Import;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type ImportType;
		}

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, IList<FieldInfo>> _checkedFields;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x12C02DC", Offset = "0x12C02DC", VA = "0x12C02DC")]
		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x12C0664", Offset = "0x12C0664", VA = "0x12C0664")]
		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x12C041C", Offset = "0x12C041C", VA = "0x12C041C")]
		private static List<FieldInfo> ScanType(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x12C0CD0", Offset = "0x12C0CD0", VA = "0x12C0CD0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x12BC8D0", Offset = "0x12BC8D0", VA = "0x12BC8D0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x12BCAA0", Offset = "0x12BCAA0", VA = "0x12BCAA0", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x12C0CD8", Offset = "0x12C0CD8", VA = "0x12C0CD8", Slot = "7")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x12BCA8C", Offset = "0x12BCA8C", VA = "0x12BCA8C", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x12C0CDC", Offset = "0x12C0CDC", VA = "0x12C0CDC", Slot = "9")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x12C0CE0", Offset = "0x12C0CE0", VA = "0x12C0CE0", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x12BCAAC", Offset = "0x12BCAAC", VA = "0x12BCAAC")]
		protected SRMonoBehaviourEx()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public static class Coroutines
	{
		[Token(Token = "0x200017A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAD8", Offset = "0xB6AAD8")]
		private sealed class <WaitForSecondsRealTime>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <endTime>5__2;

			[Token(Token = "0x17000243")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B88")]
				[Address(RVA = "0x12BCED4", Offset = "0x12BCED4", VA = "0x12BCED4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000244")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B8A")]
				[Address(RVA = "0x12BCF40", Offset = "0x12BCF40", VA = "0x12BCF40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x12BCE20", Offset = "0x12BCE20", VA = "0x12BCE20")]
			[DebuggerHidden]
			public <WaitForSecondsRealTime>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x12BCE4C", Offset = "0x12BCE4C", VA = "0x12BCE4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x12BCE50", Offset = "0x12BCE50", VA = "0x12BCE50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x12BCEDC", Offset = "0x12BCEDC", VA = "0x12BCEDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12BCDA4", Offset = "0x12BCDA4", VA = "0x12BCDA4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E35C", Offset = "0xB6E35C")]
		public static IEnumerator WaitForSecondsRealTime(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000042")]
	public static class SRFFloatExtensions
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x12BF2D4", Offset = "0x12BF2D4", VA = "0x12BF2D4")]
		public static float Sqr(this float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x12BF2DC", Offset = "0x12BF2DC", VA = "0x12BF2DC")]
		public static float SqrRt(this float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x12BF364", Offset = "0x12BF364", VA = "0x12BF364")]
		public static bool ApproxZero(this float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x12BF3D8", Offset = "0x12BF3D8", VA = "0x12BF3D8")]
		public static bool Approx(this float f, float f2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000043")]
	public static class SRFGameObjectExtensions
	{
		[Token(Token = "0x6000274")]
		public static T GetIComponent<T>(this GameObject t) where T : class
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		public static T GetComponentOrAdd<T>(this GameObject obj) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		public static void RemoveComponentIfExists<T>(this GameObject obj) where T : UnityEngine.Component
		{
		}

		[Token(Token = "0x6000277")]
		public static void RemoveComponentsIfExists<T>(this GameObject obj) where T : UnityEngine.Component
		{
		}

		[Token(Token = "0x6000278")]
		public static bool EnableComponentIfExists<T>(this GameObject obj, bool enable = true) where T : MonoBehaviour
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x12BF450", Offset = "0x12BF450", VA = "0x12BF450")]
		public static void SetLayerRecursive(this GameObject o, int layer)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x12BF480", Offset = "0x12BF480", VA = "0x12BF480")]
		private static void SetLayerInternal(Transform t, int layer)
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class SRFIListExtensions
	{
		[Token(Token = "0x600027B")]
		public static T Random<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x600027C")]
		public static T RandomOrDefault<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x600027D")]
		public static T PopLast<T>(this IList<T> list)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x2000045")]
	public static class SRFStringExtensions
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x12BF6F4", Offset = "0x12BF6F4", VA = "0x12BF6F4")]
		public static string Fmt(this string formatString, params object[] args)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public static class SRFTransformExtensions
	{
		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAE8", Offset = "0xB6AAE8")]
		private sealed class <GetChildren>d__0 : IEnumerable<Transform>, IEnumerable, IEnumerator<Transform>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Transform <>2__current;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform <>3__t;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <i>5__2;

			[Token(Token = "0x17000245")]
			private Transform System.Collections.Generic.IEnumerator<UnityEngine.Transform>.Current
			{
				[Token(Token = "0x6000B8E")]
				[Address(RVA = "0x12BFDAC", Offset = "0x12BFDAC", VA = "0x12BFDAC", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000246")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B90")]
				[Address(RVA = "0x12BFE18", Offset = "0x12BFE18", VA = "0x12BFE18", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B8B")]
			[Address(RVA = "0x12BF780", Offset = "0x12BF780", VA = "0x12BF780")]
			[DebuggerHidden]
			public <GetChildren>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000B8C")]
			[Address(RVA = "0x12BFD10", Offset = "0x12BFD10", VA = "0x12BFD10", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B8D")]
			[Address(RVA = "0x12BFD14", Offset = "0x12BFD14", VA = "0x12BFD14", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B8F")]
			[Address(RVA = "0x12BFDB4", Offset = "0x12BFDB4", VA = "0x12BFDB4", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000B91")]
			[Address(RVA = "0x12BFE20", Offset = "0x12BFE20", VA = "0x12BFE20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Transform> System.Collections.Generic.IEnumerable<UnityEngine.Transform>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B92")]
			[Address(RVA = "0x12BFED0", Offset = "0x12BFED0", VA = "0x12BFED0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12BF6FC", Offset = "0x12BF6FC", VA = "0x12BF6FC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E4A0", Offset = "0xB6E4A0")]
		public static IEnumerable<Transform> GetChildren(this Transform t)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12BF7B8", Offset = "0x12BF7B8", VA = "0x12BF7B8")]
		public static void ResetLocal(this Transform t)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x12BF87C", Offset = "0x12BF87C", VA = "0x12BF87C")]
		public static GameObject CreateChild(this Transform t, string name)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x12BF964", Offset = "0x12BF964", VA = "0x12BF964")]
		public static void SetParentMaintainLocals(this Transform t, Transform parent)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x12BF980", Offset = "0x12BF980", VA = "0x12BF980")]
		public static void SetLocals(this Transform t, Transform from)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x12BF9F4", Offset = "0x12BF9F4", VA = "0x12BF9F4")]
		public static void Match(this Transform t, Transform from)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12BFA50", Offset = "0x12BFA50", VA = "0x12BFA50")]
		public static void DestroyChildren(this Transform t)
		{
		}
	}
	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB688DC", Offset = "0xB688DC")]
	public class Hierarchy
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly char[] Seperator;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, Transform> Cache;

		[Token(Token = "0x1700001F")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB70374", Offset = "0xB70374")]
		public Transform Item
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x12BD2EC", Offset = "0x12BD2EC", VA = "0x12BD2EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x12BD350", Offset = "0x12BD350", VA = "0x12BD350")]
		public static Transform Get(string key)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x12BD5C4", Offset = "0x12BD5C4", VA = "0x12BD5C4")]
		public Hierarchy()
		{
		}
	}
}
namespace SRF.UI
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68914", Offset = "0xB68914")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68914", Offset = "0xB68914")]
	public class ContentFitText : UIBehaviour, ILayoutElement
	{
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SRText CopySource;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 Padding;

		[Token(Token = "0x17000020")]
		public float minWidth
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x12C2B04", Offset = "0x12C2B04", VA = "0x12C2B04", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public float preferredWidth
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x12C2BA8", Offset = "0x12C2BA8", VA = "0x12C2BA8", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public float flexibleWidth
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x12C2C4C", Offset = "0x12C2C4C", VA = "0x12C2C4C", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		public float minHeight
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x12C2CEC", Offset = "0x12C2CEC", VA = "0x12C2CEC", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public float preferredHeight
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x12C2D90", Offset = "0x12C2D90", VA = "0x12C2D90", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public float flexibleHeight
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x12C2E34", Offset = "0x12C2E34", VA = "0x12C2E34", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public int layoutPriority
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x12C2ED4", Offset = "0x12C2ED4", VA = "0x12C2ED4", Slot = "25")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x12C2EDC", Offset = "0x12C2EDC", VA = "0x12C2EDC", Slot = "17")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x12C2F00", Offset = "0x12C2F00", VA = "0x12C2F00", Slot = "18")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x12C2F24", Offset = "0x12C2F24", VA = "0x12C2F24", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x12C3124", Offset = "0x12C3124", VA = "0x12C3124")]
		private void CopySourceOnLayoutDirty(SRText srText)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x12C3128", Offset = "0x12C3128", VA = "0x12C3128", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x12C312C", Offset = "0x12C312C", VA = "0x12C312C", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x12C326C", Offset = "0x12C326C", VA = "0x12C326C", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x12C3270", Offset = "0x12C3270", VA = "0x12C3270", Slot = "11")]
		protected override void OnBeforeTransformParentChanged()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x12C2FC0", Offset = "0x12C2FC0", VA = "0x12C2FC0")]
		protected void SetDirty()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x12C3274", Offset = "0x12C3274", VA = "0x12C3274")]
		public ContentFitText()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB689AC", Offset = "0xB689AC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB689AC", Offset = "0xB689AC")]
	public class CopyLayoutElement : UIBehaviour, ILayoutElement
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool CopyMinHeight;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool CopyMinWidth;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool CopyPreferredHeight;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool CopyPreferredWidth;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RectTransform CopySource;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PaddingMinHeight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float PaddingMinWidth;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float PaddingPreferredHeight;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float PaddingPreferredWidth;

		[Token(Token = "0x17000027")]
		public float preferredWidth
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x12C327C", Offset = "0x12C327C", VA = "0x12C327C", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		public float preferredHeight
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x12C3334", Offset = "0x12C3334", VA = "0x12C3334", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000029")]
		public float minWidth
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x12C33EC", Offset = "0x12C33EC", VA = "0x12C33EC", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002A")]
		public float minHeight
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x12C34A4", Offset = "0x12C34A4", VA = "0x12C34A4", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002B")]
		public int layoutPriority
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x12C355C", Offset = "0x12C355C", VA = "0x12C355C", Slot = "25")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002C")]
		public float flexibleHeight
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x12C3564", Offset = "0x12C3564", VA = "0x12C3564", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002D")]
		public float flexibleWidth
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x12C356C", Offset = "0x12C356C", VA = "0x12C356C", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x12C3574", Offset = "0x12C3574", VA = "0x12C3574", Slot = "17")]
		public void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x12C3578", Offset = "0x12C3578", VA = "0x12C3578", Slot = "18")]
		public void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x12C357C", Offset = "0x12C357C", VA = "0x12C357C")]
		public CopyLayoutElement()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68A44", Offset = "0xB68A44")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68A44", Offset = "0xB68A44")]
	public class CopyPreferredSize : LayoutElement
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform CopySource;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PaddingHeight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PaddingWidth;

		[Token(Token = "0x1700002E")]
		public override float preferredWidth
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x12C3584", Offset = "0x12C3584", VA = "0x12C3584", Slot = "35")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002F")]
		public override float preferredHeight
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x12C3634", Offset = "0x12C3634", VA = "0x12C3634", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000030")]
		public override int layoutPriority
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x12C36E4", Offset = "0x12C36E4", VA = "0x12C36E4", Slot = "43")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x12C36EC", Offset = "0x12C36EC", VA = "0x12C36EC")]
		public CopyPreferredSize()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68ADC", Offset = "0xB68ADC")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68ADC", Offset = "0xB68ADC")]
	public class CopySizeIntoLayoutElement : LayoutElement
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RectTransform CopySource;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float PaddingHeight;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float PaddingWidth;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool SetPreferredSize;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool SetMinimumSize;

		[Token(Token = "0x17000031")]
		public override float preferredWidth
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x12C36F4", Offset = "0x12C36F4", VA = "0x12C36F4", Slot = "35")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public override float preferredHeight
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x12C37D4", Offset = "0x12C37D4", VA = "0x12C37D4", Slot = "37")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000033")]
		public override float minWidth
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x12C38B4", Offset = "0x12C38B4", VA = "0x12C38B4", Slot = "31")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public override float minHeight
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x12C3994", Offset = "0x12C3994", VA = "0x12C3994", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public override int layoutPriority
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x12C3A74", Offset = "0x12C3A74", VA = "0x12C3A74", Slot = "43")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x12C3A7C", Offset = "0x12C3A7C", VA = "0x12C3A7C")]
		public CopySizeIntoLayoutElement()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class DragHandle : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler, IDragHandler
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _delta;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _startValue;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform.Axis Axis;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool Invert;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxSize;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LayoutElement TargetLayoutElement;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public RectTransform TargetRectTransform;

		[Token(Token = "0x17000036")]
		private float Mult
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x12C3A84", Offset = "0x12C3A84", VA = "0x12C3A84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x12C3A9C", Offset = "0x12C3A9C", VA = "0x12C3A9C", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x12C3D10", Offset = "0x12C3D10", VA = "0x12C3D10", Slot = "6")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x12C40AC", Offset = "0x12C40AC", VA = "0x12C40AC", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x12C4280", Offset = "0x12C4280", VA = "0x12C4280")]
		private void Start()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x12C3AD0", Offset = "0x12C3AD0", VA = "0x12C3AD0")]
		private bool Verify()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x12C3BD0", Offset = "0x12C3BD0", VA = "0x12C3BD0")]
		private float GetCurrentValue()
		{
			return default(float);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x12C3F4C", Offset = "0x12C3F4C", VA = "0x12C3F4C")]
		private void SetCurrentValue(float value)
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x12C416C", Offset = "0x12C416C", VA = "0x12C416C")]
		private void CommitCurrentValue()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x12C3E80", Offset = "0x12C3E80", VA = "0x12C3E80")]
		private float GetMinSize()
		{
			return default(float);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x12C3F34", Offset = "0x12C3F34", VA = "0x12C3F34")]
		private float GetMaxSize()
		{
			return default(float);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x12C42E0", Offset = "0x12C42E0", VA = "0x12C42E0")]
		public DragHandle()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68B74", Offset = "0xB68B74")]
	[ExecuteInEditMode]
	public class FlashGraphic : UIBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float DecayTime;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Color DefaultColor;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color FlashColor;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Graphic Target;

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x12C42F0", Offset = "0x12C42F0", VA = "0x12C42F0", Slot = "17")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x12C432C", Offset = "0x12C432C", VA = "0x12C432C", Slot = "18")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x12C4368", Offset = "0x12C4368", VA = "0x12C4368", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x12C43B8", Offset = "0x12C43B8", VA = "0x12C43B8")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x12C43BC", Offset = "0x12C43BC", VA = "0x12C43BC")]
		public void Flash()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x12C4430", Offset = "0x12C4430", VA = "0x12C4430")]
		public FlashGraphic()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68BC0", Offset = "0xB68BC0")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68BC0", Offset = "0xB68BC0")]
	public class InheritColour : SRMonoBehaviour
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Graphic _graphic;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Graphic From;

		[Token(Token = "0x17000037")]
		private Graphic Graphic
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x12C44B4", Offset = "0x12C44B4", VA = "0x12C44B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x12C454C", Offset = "0x12C454C", VA = "0x12C454C")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x12C4618", Offset = "0x12C4618", VA = "0x12C4618")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x12C461C", Offset = "0x12C461C", VA = "0x12C461C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x12C4620", Offset = "0x12C4620", VA = "0x12C4620")]
		public InheritColour()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68C58", Offset = "0xB68C58")]
	public class LongPressButton : Button
	{
		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _handled;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ButtonClickedEvent _onLongPress;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _pressed;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private float _pressedTime;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float LongPressDuration;

		[Token(Token = "0x17000038")]
		public ButtonClickedEvent onLongPress
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x12C7168", Offset = "0x12C7168", VA = "0x12C7168")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x12C7170", Offset = "0x12C7170", VA = "0x12C7170")]
			set
			{
			}
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x12C7178", Offset = "0x12C7178", VA = "0x12C7178", Slot = "35")]
		public override void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x12C71A0", Offset = "0x12C71A0", VA = "0x12C71A0", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x12C71F4", Offset = "0x12C71F4", VA = "0x12C71F4", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x12C7228", Offset = "0x12C7228", VA = "0x12C7228", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x12C723C", Offset = "0x12C723C", VA = "0x12C723C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x12C72A4", Offset = "0x12C72A4", VA = "0x12C72A4")]
		public LongPressButton()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68C90", Offset = "0xB68C90")]
	public abstract class ResponsiveBase : SRMonoBehaviour
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _queueRefresh;

		[Token(Token = "0x17000039")]
		protected RectTransform RectTransform
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x12C7318", Offset = "0x12C7318", VA = "0x12C7318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x12C7380", Offset = "0x12C7380", VA = "0x12C7380")]
		protected void OnEnable()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x12C738C", Offset = "0x12C738C", VA = "0x12C738C")]
		protected void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x12C7398", Offset = "0x12C7398", VA = "0x12C7398")]
		protected void Update()
		{
		}

		[Token(Token = "0x60002D2")]
		protected abstract void Refresh();

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x12C73D0", Offset = "0x12C73D0", VA = "0x12C73D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6E574", Offset = "0xB6E574")]
		private void DoRefresh()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x12C73DC", Offset = "0x12C73DC", VA = "0x12C73DC")]
		protected ResponsiveBase()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68D04", Offset = "0xB68D04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68D04", Offset = "0xB68D04")]
	public class ResponsiveEnable : ResponsiveBase
	{
		[Token(Token = "0x200017C")]
		public enum Modes
		{
			[Token(Token = "0x400070F")]
			EnableAbove,
			[Token(Token = "0x4000710")]
			EnableBelow
		}

		[Serializable]
		[Token(Token = "0x200017D")]
		public struct Entry
		{
			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Behaviour[] Components;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject[] GameObjects;

			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Modes Mode;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float ThresholdHeight;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float ThresholdWidth;
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Entry[] Entries;

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x12C73E4", Offset = "0x12C73E4", VA = "0x12C73E4", Slot = "4")]
		protected override void Refresh()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x12C769C", Offset = "0x12C769C", VA = "0x12C769C")]
		public ResponsiveEnable()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68D9C", Offset = "0xB68D9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68D9C", Offset = "0xB68D9C")]
	public class ResponsiveResize : ResponsiveBase
	{
		[Serializable]
		[Token(Token = "0x200017E")]
		public struct Element
		{
			[Serializable]
			[Token(Token = "0x20001DF")]
			public struct SizeDefinition
			{
				[Token(Token = "0x4000872")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB6D5C4", Offset = "0xB6D5C4")]
				public float ElementWidth;

				[Token(Token = "0x4000873")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB6D5FC", Offset = "0xB6D5FC")]
				public float ThresholdWidth;
			}

			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SizeDefinition[] SizeDefinitions;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public RectTransform Target;
		}

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Element[] Elements;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x12C76FC", Offset = "0x12C76FC", VA = "0x12C76FC", Slot = "4")]
		protected override void Refresh()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x12C7918", Offset = "0x12C7918", VA = "0x12C7918")]
		public ResponsiveResize()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68E34", Offset = "0xB68E34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68E34", Offset = "0xB68E34")]
	public class ScrollToBottomBehaviour : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x12C87B0", Offset = "0x12C87B0", VA = "0x12C87B0")]
		public void Start()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x12C89F0", Offset = "0x12C89F0", VA = "0x12C89F0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x12C89F4", Offset = "0x12C89F4", VA = "0x12C89F4")]
		public void Trigger()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x12C8A44", Offset = "0x12C8A44", VA = "0x12C8A44")]
		private void OnScrollRectValueChanged(Vector2 position)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x12C8934", Offset = "0x12C8934", VA = "0x12C8934")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x12C8A48", Offset = "0x12C8A48", VA = "0x12C8A48")]
		private void SetVisible(bool truth)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x12C8AD4", Offset = "0x12C8AD4", VA = "0x12C8AD4")]
		public ScrollToBottomBehaviour()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68ECC", Offset = "0xB68ECC")]
	public class SRNumberButton : Button, IPointerClickHandler, IEventSystemHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000141")]
		private const float ExtraThreshold = 3f;

		[Token(Token = "0x4000142")]
		public const float Delay = 0.4f;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _delayTime;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _downTime;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool _isDown;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public double Amount;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public SRNumberSpinner TargetField;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x12C7978", Offset = "0x12C7978", VA = "0x12C7978", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x12C7AD0", Offset = "0x12C7AD0", VA = "0x12C7AD0", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x12C7AF8", Offset = "0x12C7AF8", VA = "0x12C7AF8", Slot = "43")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x12C79CC", Offset = "0x12C79CC", VA = "0x12C79CC")]
		private void Apply()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x12C7BD8", Offset = "0x12C7BD8", VA = "0x12C7BD8")]
		public SRNumberButton()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68F04", Offset = "0xB68F04")]
	public class SRNumberSpinner : InputField
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private double _currentValue;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private double _dragStartAmount;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private double _dragStep;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		public float DragSensitivity;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public double MaxValue;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public double MinValue;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x12C7BE8", Offset = "0x12C7BE8", VA = "0x12C7BE8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x12C7C90", Offset = "0x12C7C90", VA = "0x12C7C90", Slot = "69")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x12C7DB8", Offset = "0x12C7DB8", VA = "0x12C7DB8", Slot = "32")]
		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x12C7DBC", Offset = "0x12C7DBC", VA = "0x12C7DBC", Slot = "33")]
		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x12C7DC0", Offset = "0x12C7DC0", VA = "0x12C7DC0", Slot = "60")]
		public override void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x12C8080", Offset = "0x12C8080", VA = "0x12C8080", Slot = "61")]
		public override void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x12C8248", Offset = "0x12C8248", VA = "0x12C8248", Slot = "62")]
		public override void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x12C82BC", Offset = "0x12C82BC", VA = "0x12C82BC")]
		public SRNumberSpinner()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB68F3C", Offset = "0xB68F3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68F3C", Offset = "0xB68F3C")]
	public class SRRetinaScaler : SRMonoBehaviour
	{
		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _retinaScale;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int _thresholdDpi;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _disablePixelPerfect;

		[Token(Token = "0x1700003A")]
		public int ThresholdDpi
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x12C833C", Offset = "0x12C833C", VA = "0x12C833C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700003B")]
		public float RetinaScale
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x12C8344", Offset = "0x12C8344", VA = "0x12C8344")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x12C834C", Offset = "0x12C834C", VA = "0x12C834C")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x12C8414", Offset = "0x12C8414", VA = "0x12C8414")]
		public SRRetinaScaler()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68FC4", Offset = "0xB68FC4")]
	public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		[Serializable]
		[Token(Token = "0x200017F")]
		public class SpinEvent : UnityEvent
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x12C86D0", Offset = "0x12C86D0", VA = "0x12C86D0")]
			public SpinEvent()
			{
			}
		}

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _dragDelta;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private SpinEvent _onSpinDecrement;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private SpinEvent _onSpinIncrement;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float DragThreshold;

		[Token(Token = "0x1700003C")]
		public SpinEvent OnSpinIncrement
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x12C8428", Offset = "0x12C8428", VA = "0x12C8428")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x12C8430", Offset = "0x12C8430", VA = "0x12C8430")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public SpinEvent OnSpinDecrement
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x12C8438", Offset = "0x12C8438", VA = "0x12C8438")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x12C8440", Offset = "0x12C8440", VA = "0x12C8440")]
			set
			{
			}
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x12C8448", Offset = "0x12C8448", VA = "0x12C8448", Slot = "40")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x12C8450", Offset = "0x12C8450", VA = "0x12C8450", Slot = "39")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12C8578", Offset = "0x12C8578", VA = "0x12C8578")]
		private void OnIncrement(int amount)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x12C85CC", Offset = "0x12C85CC", VA = "0x12C85CC")]
		private void OnDecrement(int amount)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12C8620", Offset = "0x12C8620", VA = "0x12C8620")]
		public SRSpinner()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB68FFC", Offset = "0xB68FFC")]
	public class SRText : Text
	{
		[Token(Token = "0x14000002")]
		public event Action<SRText> LayoutDirty
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x12C3080", Offset = "0x12C3080", VA = "0x12C3080")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5AC", Offset = "0xB6E5AC")]
			add
			{
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x12C31C8", Offset = "0x12C31C8", VA = "0x12C31C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5BC", Offset = "0xB6E5BC")]
			remove
			{
			}
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x12C86D8", Offset = "0x12C86D8", VA = "0x12C86D8", Slot = "27")]
		public override void SetLayoutDirty()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12C8748", Offset = "0x12C8748", VA = "0x12C8748")]
		public SRText()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69034", Offset = "0xB69034")]
	public class StyleComponent : SRMonoBehaviour
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Style _activeStyle;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private StyleRoot _cachedRoot;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Graphic _graphic;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _hasStarted;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Image _image;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Selectable _selectable;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6AF28", Offset = "0xB6AF28")]
		[HideInInspector]
		private string _styleKey;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool IgnoreImage;

		[Token(Token = "0x1700003E")]
		public string StyleKey
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x12C8C34", Offset = "0x12C8C34", VA = "0x12C8C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x12C8C3C", Offset = "0x12C8C3C", VA = "0x12C8C3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x12C8E34", Offset = "0x12C8E34", VA = "0x12C8E34")]
		private void Start()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x12C8E60", Offset = "0x12C8E60", VA = "0x12C8E60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x12C8C48", Offset = "0x12C8C48", VA = "0x12C8C48")]
		public void Refresh(bool invalidateCache)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x12C8E74", Offset = "0x12C8E74", VA = "0x12C8E74")]
		private StyleRoot GetStyleRoot()
		{
			return null;
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x12C90E4", Offset = "0x12C90E4", VA = "0x12C90E4")]
		private void ApplyStyle()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x12C93CC", Offset = "0x12C93CC", VA = "0x12C93CC")]
		private void SRStyleDirty()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x12C9418", Offset = "0x12C9418", VA = "0x12C9418")]
		public StyleComponent()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69080", Offset = "0xB69080")]
	public sealed class StyleRoot : SRMonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StyleSheet _activeStyleSheet;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public StyleSheet StyleSheet;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x12C9000", Offset = "0x12C9000", VA = "0x12C9000")]
		public Style GetStyle(string key)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x12C9534", Offset = "0x12C9534", VA = "0x12C9534")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x12C9620", Offset = "0x12C9620", VA = "0x12C9620")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x12C9624", Offset = "0x12C9624", VA = "0x12C9624")]
		private void Update()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x12C95C0", Offset = "0x12C95C0", VA = "0x12C95C0")]
		private void OnStyleSheetChanged()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x12C96B8", Offset = "0x12C96B8", VA = "0x12C96B8")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x12C96C0", Offset = "0x12C96C0", VA = "0x12C96C0")]
		public StyleRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class Style
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color ActiveColor;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color DisabledColor;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color HoverColor;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Sprite Image;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color NormalColor;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x12C8ADC", Offset = "0x12C8ADC", VA = "0x12C8ADC")]
		public Style Copy()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x12C8BB4", Offset = "0x12C8BB4", VA = "0x12C8BB4")]
		public void CopyFrom(Style style)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x12C8B50", Offset = "0x12C8B50", VA = "0x12C8B50")]
		public Style()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class StyleSheet : ScriptableObject
	{
		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> _keys;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Style> _styles;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public StyleSheet Parent;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x12C9420", Offset = "0x12C9420", VA = "0x12C9420")]
		public Style GetStyle(string key, bool searchParent = true)
		{
			return null;
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x12C96C8", Offset = "0x12C96C8", VA = "0x12C96C8")]
		public StyleSheet()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB690CC", Offset = "0xB690CC")]
	public sealed class Unselectable : SRMonoBehaviour, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _suspectedSelected;

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12C9760", Offset = "0x12C9760", VA = "0x12C9760", Slot = "4")]
		public void OnSelect(BaseEventData eventData)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x12C976C", Offset = "0x12C976C", VA = "0x12C976C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12C9868", Offset = "0x12C9868", VA = "0x12C9868")]
		public Unselectable()
		{
		}
	}
}
namespace SRF.UI.Layout
{
	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69104", Offset = "0xB69104")]
	public class FlowLayoutGroup : LayoutGroup
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly IList<RectTransform> _rowList;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _layoutHeight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool ChildForceExpandHeight;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool ChildForceExpandWidth;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float Spacing;

		[Token(Token = "0x1700003F")]
		protected bool IsCenterAlign
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x12C4628", Offset = "0x12C4628", VA = "0x12C4628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		protected bool IsRightAlign
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0x12C4654", Offset = "0x12C4654", VA = "0x12C4654")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		protected bool IsMiddleAlign
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x12C4680", Offset = "0x12C4680", VA = "0x12C4680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		protected bool IsLowerAlign
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x12C46A4", Offset = "0x12C46A4", VA = "0x12C46A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x12C46C8", Offset = "0x12C46C8", VA = "0x12C46C8", Slot = "28")]
		public override void CalculateLayoutInputHorizontal()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12C4838", Offset = "0x12C4838", VA = "0x12C4838", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x12C4E20", Offset = "0x12C4E20", VA = "0x12C4E20", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x12C4E84", Offset = "0x12C4E84", VA = "0x12C4E84", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x12C489C", Offset = "0x12C489C", VA = "0x12C489C")]
		public float SetLayout(float width, int axis, bool layoutInput)
		{
			return default(float);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x12C4EEC", Offset = "0x12C4EEC", VA = "0x12C4EEC")]
		private float CalculateRowVerticalOffset(float groupHeight, float yOffset, float currentRowHeight)
		{
			return default(float);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x12C4F34", Offset = "0x12C4F34", VA = "0x12C4F34")]
		protected void LayoutRow(IList<RectTransform> contents, float rowWidth, float rowHeight, float maxWidth, float xOffset, float yOffset, int axis)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x12C4758", Offset = "0x12C4758", VA = "0x12C4758")]
		public float GetGreatestMinimumChildWidth()
		{
			return default(float);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x12C53D0", Offset = "0x12C53D0", VA = "0x12C53D0")]
		public FlowLayoutGroup()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public interface IVirtualView
	{
		[Token(Token = "0x6000323")]
		void SetDataContext(object data);
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6913C", Offset = "0xB6913C")]
	public class VirtualVerticalLayoutGroup : LayoutGroup, IPointerClickHandler, IEventSystemHandler
	{
		[Serializable]
		[Token(Token = "0x2000180")]
		public class SelectedItemChangedEvent : UnityEvent<object>
		{
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x12C7118", Offset = "0x12C7118", VA = "0x12C7118")]
			public SelectedItemChangedEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000181")]
		private class Row
		{
			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Data;

			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Index;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RectTransform Rect;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public StyleRoot Root;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IVirtualView View;

			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x12C7014", Offset = "0x12C7014", VA = "0x12C7014")]
			public Row()
			{
			}
		}

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly SRList<object> _itemList;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private readonly SRList<int> _visibleItemList;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _isDirty;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private SRList<Row> _rowCache;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ScrollRect _scrollRect;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _selectedIndex;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private object _selectedItem;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private SelectedItemChangedEvent _selectedItemChanged;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int _visibleItemCount;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private SRList<Row> _visibleRows;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public StyleSheet AltRowStyleSheet;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool EnableSelection;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public RectTransform ItemPrefab;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public int RowPadding;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public StyleSheet RowStyleSheet;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public StyleSheet SelectedRowStyleSheet;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float Spacing;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public bool StickToBottom;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _itemHeight;

		[Token(Token = "0x17000043")]
		public SelectedItemChangedEvent SelectedItemChanged
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x12C5440", Offset = "0x12C5440", VA = "0x12C5440")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x12C5448", Offset = "0x12C5448", VA = "0x12C5448")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public object SelectedItem
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x12C5450", Offset = "0x12C5450", VA = "0x12C5450")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x12C5458", Offset = "0x12C5458", VA = "0x12C5458")]
			set
			{
			}
		}

		[Token(Token = "0x17000045")]
		public override float minHeight
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x12C5710", Offset = "0x12C5710", VA = "0x12C5710", Slot = "33")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000046")]
		private ScrollRect ScrollRect
		{
			[Token(Token = "0x6000339")]
			[Address(RVA = "0x12C5CA4", Offset = "0x12C5CA4", VA = "0x12C5CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private bool AlignBottom
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x12C62CC", Offset = "0x12C62CC", VA = "0x12C62CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		private bool AlignTop
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x12C62F0", Offset = "0x12C62F0", VA = "0x12C62F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		private float ItemHeight
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x12C57DC", Offset = "0x12C57DC", VA = "0x12C57DC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x12C598C", Offset = "0x12C598C", VA = "0x12C598C", Slot = "40")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x12C5B18", Offset = "0x12C5B18", VA = "0x12C5B18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x12C5D3C", Offset = "0x12C5D3C", VA = "0x12C5D3C")]
		private void OnScrollRectValueChanged(Vector2 d)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x12C5E0C", Offset = "0x12C5E0C", VA = "0x12C5E0C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x12C6184", Offset = "0x12C6184", VA = "0x12C6184", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x12C61D0", Offset = "0x12C61D0", VA = "0x12C61D0")]
		protected void Update()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x12C55AC", Offset = "0x12C55AC", VA = "0x12C55AC")]
		protected void InvalidateItem(int itemIndex)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x12C6378", Offset = "0x12C6378", VA = "0x12C6378")]
		protected void RefreshIndexCache()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x12C5E34", Offset = "0x12C5E34", VA = "0x12C5E34")]
		protected void ScrollUpdate()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x12C65E8", Offset = "0x12C65E8", VA = "0x12C65E8", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12C664C", Offset = "0x12C664C", VA = "0x12C664C", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x12C6804", Offset = "0x12C6804", VA = "0x12C6804", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x12C56D0", Offset = "0x12C56D0", VA = "0x12C56D0")]
		private new void SetDirty()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x12C6928", Offset = "0x12C6928", VA = "0x12C6928")]
		public void AddItem(object item)
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x12C6A60", Offset = "0x12C6A60", VA = "0x12C6A60")]
		public void RemoveItem(object item)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x12C6B3C", Offset = "0x12C6B3C", VA = "0x12C6B3C")]
		public void ClearItems()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x12C6450", Offset = "0x12C6450", VA = "0x12C6450")]
		private Row GetRow(int forIndex)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x12C6310", Offset = "0x12C6310", VA = "0x12C6310")]
		private void RecycleRow(Row row)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x12C6DF0", Offset = "0x12C6DF0", VA = "0x12C6DF0")]
		private void PopulateRow(int index, Row row)
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x12C6C14", Offset = "0x12C6C14", VA = "0x12C6C14")]
		private Row CreateRow()
		{
			return null;
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x12C701C", Offset = "0x12C701C", VA = "0x12C701C")]
		public VirtualVerticalLayoutGroup()
		{
		}
	}
}
namespace SRF.Service
{
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB69174", Offset = "0xB69174")]
	public sealed class ServiceAttribute : Attribute
	{
		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AFC4", Offset = "0xB6AFC4")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004A")]
		public Type ServiceType
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x12C2A7C", Offset = "0x12C2A7C", VA = "0x12C2A7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5CC", Offset = "0xB6E5CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x12C2A84", Offset = "0x12C2A84", VA = "0x12C2A84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5DC", Offset = "0xB6E5DC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x12C2A50", Offset = "0x12C2A50", VA = "0x12C2A50")]
		public ServiceAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB69188", Offset = "0xB69188")]
	public sealed class ServiceSelectorAttribute : Attribute
	{
		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AFD4", Offset = "0xB6AFD4")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004B")]
		public Type ServiceType
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x12C2AF4", Offset = "0x12C2AF4", VA = "0x12C2AF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5EC", Offset = "0xB6E5EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x12C2AFC", Offset = "0x12C2AFC", VA = "0x12C2AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E5FC", Offset = "0xB6E5FC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x12C2AC8", Offset = "0x12C2AC8", VA = "0x12C2AC8")]
		public ServiceSelectorAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB6919C", Offset = "0xB6919C")]
	public sealed class ServiceConstructorAttribute : Attribute
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AFE4", Offset = "0xB6AFE4")]
		private Type <ServiceType>k__BackingField;

		[Token(Token = "0x1700004C")]
		public Type ServiceType
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x12C2AB8", Offset = "0x12C2AB8", VA = "0x12C2AB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E60C", Offset = "0xB6E60C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x12C2AC0", Offset = "0x12C2AC0", VA = "0x12C2AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E61C", Offset = "0xB6E61C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x12C2A8C", Offset = "0x12C2A8C", VA = "0x12C2A8C")]
		public ServiceConstructorAttribute(Type serviceType)
		{
		}
	}
	[Token(Token = "0x2000064")]
	public interface IAsyncService
	{
		[Token(Token = "0x1700004D")]
		bool IsLoaded
		{
			[Token(Token = "0x600034B")]
			get;
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class SRDependencyServiceBase<T> : SRServiceBase<T>, IAsyncService where T : class
	{
		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AAF8", Offset = "0xB6AAF8")]
		private sealed class <LoadDependencies>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRDependencyServiceBase<T> <>4__this;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type[] <>7__wrap1;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>7__wrap2;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IAsyncService <a>5__4;

			[Token(Token = "0x17000247")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B99")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000248")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B9B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B96")]
			[DebuggerHidden]
			public <LoadDependencies>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000B97")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B98")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B9A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _isLoaded;

		[Token(Token = "0x1700004E")]
		protected abstract Type[] Dependencies
		{
			[Token(Token = "0x600034C")]
			get;
		}

		[Token(Token = "0x1700004F")]
		public bool IsLoaded
		{
			[Token(Token = "0x600034D")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600034E")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6E62C", Offset = "0xB6E62C")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		[Token(Token = "0x600034F")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000350")]
		protected virtual void OnLoaded()
		{
		}

		[Token(Token = "0x6000351")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E664", Offset = "0xB6E664")]
		private IEnumerator LoadDependencies()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		protected SRDependencyServiceBase()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService where T : class where TImpl : UnityEngine.Component
	{
		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB08", Offset = "0xB6AB08")]
		private sealed class <LoadCoroutine>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public SRSceneServiceBase<T, TImpl> <>4__this;

			[Token(Token = "0x17000249")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B9F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BA1")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B9C")]
			[DebuggerHidden]
			public <LoadCoroutine>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000B9D")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B9E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BA0")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TImpl _rootObject;

		[Token(Token = "0x17000050")]
		protected abstract string SceneName
		{
			[Token(Token = "0x6000353")]
			get;
		}

		[Token(Token = "0x17000051")]
		protected TImpl RootObject
		{
			[Token(Token = "0x6000354")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000052")]
		public bool IsLoaded
		{
			[Token(Token = "0x6000355")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000356")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0xB6E6C8", Offset = "0xB6E6C8")]
		private void Log(string msg, UnityEngine.Object target)
		{
		}

		[Token(Token = "0x6000357")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000358")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000359")]
		protected virtual void OnLoaded()
		{
		}

		[Token(Token = "0x600035A")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E700", Offset = "0xB6E700")]
		private IEnumerator LoadCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600035B")]
		protected SRSceneServiceBase()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public abstract class SRServiceBase<T> : SRMonoBehaviourEx where T : class
	{
		[Token(Token = "0x600035C")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600035D")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600035E")]
		protected SRServiceBase()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB691B0", Offset = "0xB691B0")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager>
	{
		[Serializable]
		[Token(Token = "0x2000184")]
		private class Service
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Object;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type Type;

			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x12C168C", Offset = "0x12C168C", VA = "0x12C168C")]
			public Service()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000185")]
		private class ServiceStub
		{
			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Func<object> Constructor;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Type InterfaceType;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Func<Type> Selector;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Type Type;

			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x12C2940", Offset = "0x12C2940", VA = "0x12C2940", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x12C1D88", Offset = "0x12C1D88", VA = "0x12C1D88")]
			public ServiceStub()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB18", Offset = "0xB6AB18")]
		private sealed class <>c
		{
			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<ServiceStub, string> <>9__19_0;

			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x12C273C", Offset = "0x12C273C", VA = "0x12C273C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x12C2744", Offset = "0x12C2744", VA = "0x12C2744")]
			internal string <UpdateStubs>b__19_0(ServiceStub p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000187")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB28", Offset = "0xB6AB28")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ServiceSelectorAttribute attrib;

			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x12C264C", Offset = "0x12C264C", VA = "0x12C264C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000BA9")]
			[Address(RVA = "0x12C27F4", Offset = "0x12C27F4", VA = "0x12C27F4")]
			internal bool <ScanTypeForSelectors>b__0(ServiceStub p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB38", Offset = "0xB6AB38")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ServiceConstructorAttribute attrib;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public MethodInfo m;

			[Token(Token = "0x6000BAA")]
			[Address(RVA = "0x12C2654", Offset = "0x12C2654", VA = "0x12C2654")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000BAB")]
			[Address(RVA = "0x12C2888", Offset = "0x12C2888", VA = "0x12C2888")]
			internal bool <ScanTypeForConstructors>b__0(ServiceStub p)
			{
				return default(bool);
			}

			[Token(Token = "0x6000BAC")]
			[Address(RVA = "0x12C291C", Offset = "0x12C291C", VA = "0x12C291C")]
			internal object <ScanTypeForConstructors>b__1()
			{
				return null;
			}
		}

		[Token(Token = "0x4000186")]
		public const bool EnableLogging = false;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int LoadingCount;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<Service> _services;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<ServiceStub> _serviceStubs;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static bool _hasQuit;

		[Token(Token = "0x17000053")]
		public static bool IsLoading
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x12C0CE4", Offset = "0x12C0CE4", VA = "0x12C0CE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000360")]
		public static T GetService<T>() where T : class
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x12C0AF8", Offset = "0x12C0AF8", VA = "0x12C0AF8")]
		public static object GetService(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x12C0D54", Offset = "0x12C0D54", VA = "0x12C0D54")]
		private static object GetServiceInternal(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000363")]
		public static bool HasService<T>() where T : class
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x12C12B4", Offset = "0x12C12B4", VA = "0x12C12B4")]
		public static bool HasService(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000365")]
		public static void RegisterService<T>(object service) where T : class
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x12C13DC", Offset = "0x12C13DC", VA = "0x12C13DC")]
		private static void RegisterService(Type t, object service)
		{
		}

		[Token(Token = "0x6000367")]
		public static void UnRegisterService<T>() where T : class
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x12C0ED4", Offset = "0x12C0ED4", VA = "0x12C0ED4")]
		private static void UnRegisterService(Type t)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x12C1694", Offset = "0x12C1694", VA = "0x12C1694", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x12C1768", Offset = "0x12C1768", VA = "0x12C1768")]
		protected void UpdateStubs()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x12C1040", Offset = "0x12C1040", VA = "0x12C1040")]
		protected object AutoCreateService(Type t)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x12C1D1C", Offset = "0x12C1D1C", VA = "0x12C1D1C")]
		protected void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x12C1B90", Offset = "0x12C1B90", VA = "0x12C1B90")]
		private static object DefaultServiceConstructor(Type serviceIntType, Type implType)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x12C1A94", Offset = "0x12C1A94", VA = "0x12C1A94")]
		private void ScanType(Type type)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12C21DC", Offset = "0x12C21DC", VA = "0x12C21DC")]
		private static void ScanTypeForSelectors(Type t, List<ServiceStub> stubs)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x12C1D90", Offset = "0x12C1D90", VA = "0x12C1D90")]
		private static void ScanTypeForConstructors(Type t, List<ServiceStub> stubs)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x12C2628", Offset = "0x12C2628", VA = "0x12C2628")]
		private static MethodInfo[] GetStaticMethods(Type t)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x12C265C", Offset = "0x12C265C", VA = "0x12C265C")]
		public SRServiceManager()
		{
		}
	}
}
namespace SRF.Helpers
{
	[Token(Token = "0x2000069")]
	public static class AssetUtil
	{
	}
	[Token(Token = "0x200006A")]
	public class MethodReference
	{
		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MethodInfo _method;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _target;

		[Token(Token = "0x17000054")]
		public string MethodName
		{
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x12BCF94", Offset = "0x12BCF94", VA = "0x12BCF94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x12BCF48", Offset = "0x12BCF48", VA = "0x12BCF48")]
		public MethodReference(object target, MethodInfo method)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x12BCFB4", Offset = "0x12BCFB4", VA = "0x12BCFB4")]
		public object Invoke(object[] parameters)
		{
			return null;
		}
	}
	[Token(Token = "0x200006B")]
	public class PropertyReference
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly PropertyInfo _property;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object _target;

		[Token(Token = "0x17000055")]
		public string PropertyName
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x12BD02C", Offset = "0x12BD02C", VA = "0x12BD02C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public Type PropertyType
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x12BD04C", Offset = "0x12BD04C", VA = "0x12BD04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public bool CanRead
		{
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x12BD070", Offset = "0x12BD070", VA = "0x12BD070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public bool CanWrite
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x12BD09C", Offset = "0x12BD09C", VA = "0x12BD09C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x12BCFE0", Offset = "0x12BCFE0", VA = "0x12BCFE0")]
		public PropertyReference(object target, PropertyInfo property)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x12BD0C8", Offset = "0x12BD0C8", VA = "0x12BD0C8")]
		public object GetValue()
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x12BD15C", Offset = "0x12BD15C", VA = "0x12BD15C")]
		public void SetValue(object value)
		{
		}

		[Token(Token = "0x600037E")]
		public T GetAttribute<T>() where T : Attribute
		{
			return null;
		}
	}
	[Token(Token = "0x200006C")]
	public static class SRReflection
	{
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x12BD210", Offset = "0x12BD210", VA = "0x12BD210")]
		public static void SetPropertyValue(object obj, PropertyInfo p, object value)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x12BD118", Offset = "0x12BD118", VA = "0x12BD118")]
		public static object GetPropertyValue(object obj, PropertyInfo p)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		public static T GetAttribute<T>(MemberInfo t) where T : Attribute
		{
			return null;
		}
	}
}
namespace SRF.Components
{
	[Token(Token = "0x200006D")]
	public abstract class SRAutoSingleton<T> : SRMonoBehaviour where T : SRAutoSingleton<T>
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x17000059")]
		public static T Instance
		{
			[Token(Token = "0x6000382")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000383")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000384")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000385")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000386")]
		protected SRAutoSingleton()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public abstract class SRSingleton<T> : SRMonoBehaviour where T : SRSingleton<T>
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x1700005B")]
		public static T Instance
		{
			[Token(Token = "0x6000387")]
			[DebuggerStepThrough]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public static bool HasInstance
		{
			[Token(Token = "0x6000388")]
			[DebuggerStepThrough]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000389")]
		private void Register()
		{
		}

		[Token(Token = "0x600038A")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600038B")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600038C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600038D")]
		protected SRSingleton()
		{
		}
	}
}
namespace SRF.Internal
{
	[Token(Token = "0x200006F")]
	internal static class ComponentMenuPaths
	{
		[Token(Token = "0x4000191")]
		public const string PathRoot = "SRF";

		[Token(Token = "0x4000192")]
		public const string SRServiceManager = "SRF/Service/Service Manager";

		[Token(Token = "0x4000193")]
		public const string BehavioursRoot = "SRF/Behaviours";

		[Token(Token = "0x4000194")]
		public const string DestroyOnDisable = "SRF/Behaviours/Destroy On Disable";

		[Token(Token = "0x4000195")]
		public const string DontDestroyOnLoad = "SRF/Behaviours/Don't Destroy On Load";

		[Token(Token = "0x4000196")]
		public const string MatchTransform = "SRF/Behaviours/Match Transform";

		[Token(Token = "0x4000197")]
		public const string LookAt = "SRF/Behaviours/LookAt";

		[Token(Token = "0x4000198")]
		public const string MatchForwardDirection = "SRF/Behaviours/Match Forward Direction";

		[Token(Token = "0x4000199")]
		public const string MatchMainCameraForwardDirection = "SRF/Behaviours/Match Forward Direction (Main Camera)";

		[Token(Token = "0x400019A")]
		public const string RuntimePosition = "SRF/Behaviours/Runtime Position";

		[Token(Token = "0x400019B")]
		public const string ScrollTexture = "SRF/Behaviours/Scroll Texture";

		[Token(Token = "0x400019C")]
		public const string SmoothFloatBehaviour = "SRF/Behaviours/Smooth Float";

		[Token(Token = "0x400019D")]
		public const string SmoothFollow2D = "SRF/Behaviours/Smooth Follow (2D)";

		[Token(Token = "0x400019E")]
		public const string SpringFollow = "SRF/Behaviours/Spring Follow";

		[Token(Token = "0x400019F")]
		public const string SmoothMatchTransform = "SRF/Behaviours/Match Transform (Smooth)";

		[Token(Token = "0x40001A0")]
		public const string SpawnPrefab = "SRF/Behaviours/Spawn Prefab";

		[Token(Token = "0x40001A1")]
		public const string Velocity = "SRF/Behaviours/Velocity";

		[Token(Token = "0x40001A2")]
		public const string SmoothOscillate = "SRF/Behaviours/Smooth Oscillate";

		[Token(Token = "0x40001A3")]
		public const string SRDebugCamera = "SRF/Behaviours/Camera/SRDebugCamera";

		[Token(Token = "0x40001A4")]
		public const string ComponentsRoot = "SRF/Components";

		[Token(Token = "0x40001A5")]
		public const string SRLineRenderer = "SRF/Components/SRLineRenderer";

		[Token(Token = "0x40001A6")]
		public const string SelectionRoot = "SRF/Components/Selection Root";

		[Token(Token = "0x40001A7")]
		public const string SRSpriteFadeRenderer = "SRF/Components/Fade Renderer (Sprite)";

		[Token(Token = "0x40001A8")]
		public const string SRMaterialFadeRenderer = "SRF/Components/Fade Renderer (Material)";

		[Token(Token = "0x40001A9")]
		public const string SRCompositeFadeRenderer = "SRF/Components/Fade Renderer (Composite)";

		[Token(Token = "0x40001AA")]
		public const string UIRoot = "SRF/UI";

		[Token(Token = "0x40001AB")]
		public const string TiltOnTouch = "SRF/UI/Tilt On Touch";

		[Token(Token = "0x40001AC")]
		public const string ScaleOnTouch = "SRF/UI/Scale On Touch";

		[Token(Token = "0x40001AD")]
		public const string InheritColour = "SRF/UI/Inherit Colour";

		[Token(Token = "0x40001AE")]
		public const string FlashGraphic = "SRF/UI/Flash Graphic";

		[Token(Token = "0x40001AF")]
		public const string CopyPreferredSize = "SRF/UI/Copy Preferred Size";

		[Token(Token = "0x40001B0")]
		public const string CopyLayoutElement = "SRF/UI/Copy Layout Element";

		[Token(Token = "0x40001B1")]
		public const string CopySizeIntoLayoutElement = "SRF/UI/Copy Size Into Layout Element";

		[Token(Token = "0x40001B2")]
		public const string SRText = "SRF/UI/SRText";

		[Token(Token = "0x40001B3")]
		public const string Unselectable = "SRF/UI/Unselectable";

		[Token(Token = "0x40001B4")]
		public const string LongPressButton = "SRF/UI/Long Press Button";

		[Token(Token = "0x40001B5")]
		public const string ScrollToBottom = "SRF/UI/Scroll To Bottom Behaviour";

		[Token(Token = "0x40001B6")]
		public const string FlowLayoutGroup = "SRF/UI/Layout/Flow Layout Group";

		[Token(Token = "0x40001B7")]
		public const string VirtualVerticalLayoutGroup = "SRF/UI/Layout/VerticalLayoutGroup (Virtualizing)";

		[Token(Token = "0x40001B8")]
		public const string StyleRoot = "SRF/UI/Style Root";

		[Token(Token = "0x40001B9")]
		public const string StyleComponent = "SRF/UI/Style Component";

		[Token(Token = "0x40001BA")]
		public const string ResponsiveEnable = "SRF/UI/Responsive (Enable)";

		[Token(Token = "0x40001BB")]
		public const string ResponsiveResize = "SRF/UI/Responsive (Resize)";

		[Token(Token = "0x40001BC")]
		public const string RetinaScaler = "SRF/UI/Retina Scaler";

		[Token(Token = "0x40001BD")]
		public const string NumberButton = "SRF/UI/SRNumberButton";

		[Token(Token = "0x40001BE")]
		public const string NumberSpinner = "SRF/UI/SRNumberSpinner";

		[Token(Token = "0x40001BF")]
		public const string SRSpinner = "SRF/UI/Spinner";

		[Token(Token = "0x40001C0")]
		public const string ContentFitText = "SRF/UI/Content Fit Text";
	}
}
namespace SRDebugger
{
	[Token(Token = "0x2000070")]
	public static class AutoInitialize
	{
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1148D70", Offset = "0x1148D70", VA = "0x1148D70")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0xB6E794", Offset = "0xB6E794")]
		public static void OnLoad()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB691E8", Offset = "0xB691E8")]
	public interface IReadOnlyList<T> : IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x1700005D")]
		int Count
		{
			[Token(Token = "0x600038F")]
			get;
		}

		[Token(Token = "0x1700005E")]
		T Item
		{
			[Token(Token = "0x6000390")]
			get;
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB69220", Offset = "0xB69220")]
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
	{
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB48", Offset = "0xB6AB48")]
		private sealed class <GetEnumerator>d__18 : IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CircularBuffer<T> <>4__this;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ArraySegment<T>[] <>7__wrap1;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>7__wrap2;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ArraySegment<T> <segment>5__4;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__5;

			[Token(Token = "0x1700024B")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000BB0")]
				[DebuggerHidden]
				get
				{
					return (T)null;
				}
			}

			[Token(Token = "0x1700024C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BB2")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BAD")]
			[DebuggerHidden]
			public <GetEnumerator>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000BAE")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BAF")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BB1")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly T[] _buffer;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _end;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _count;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _start;

		[Token(Token = "0x1700005F")]
		public int Capacity
		{
			[Token(Token = "0x6000393")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000060")]
		public bool IsFull
		{
			[Token(Token = "0x6000394")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000395")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public int Count
		{
			[Token(Token = "0x6000396")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000063")]
		public T Item
		{
			[Token(Token = "0x6000397")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000398")]
			set
			{
			}
		}

		[Token(Token = "0x6000391")]
		public CircularBuffer(int capacity)
		{
		}

		[Token(Token = "0x6000392")]
		public CircularBuffer(int capacity, T[] items)
		{
		}

		[Token(Token = "0x6000399")]
		public void Clear()
		{
		}

		[Token(Token = "0x600039A")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E7A4", Offset = "0xB6E7A4")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		public T Front()
		{
			return (T)null;
		}

		[Token(Token = "0x600039D")]
		public T Back()
		{
			return (T)null;
		}

		[Token(Token = "0x600039E")]
		public void PushBack(T item)
		{
		}

		[Token(Token = "0x600039F")]
		public void PushFront(T item)
		{
		}

		[Token(Token = "0x60003A0")]
		public void PopBack()
		{
		}

		[Token(Token = "0x60003A1")]
		public void PopFront()
		{
		}

		[Token(Token = "0x60003A2")]
		public T[] ToArray()
		{
			return null;
		}

		[Token(Token = "0x60003A3")]
		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
		}

		[Token(Token = "0x60003A4")]
		private void Increment(ref int index)
		{
		}

		[Token(Token = "0x60003A5")]
		private void Decrement(ref int index)
		{
		}

		[Token(Token = "0x60003A6")]
		private int InternalIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x60003A7")]
		private ArraySegment<T> ArrayOne()
		{
			return default(ArraySegment<T>);
		}

		[Token(Token = "0x60003A8")]
		private ArraySegment<T> ArrayTwo()
		{
			return default(ArraySegment<T>);
		}
	}
	[Token(Token = "0x2000073")]
	public delegate void VisibilityChangedDelegate(bool isVisible);
	[Token(Token = "0x2000074")]
	public delegate void ActionCompleteCallback(bool success);
	[Token(Token = "0x2000075")]
	public sealed class InfoEntry
	{
		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB58", Offset = "0xB6AB58")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object value;

			[Token(Token = "0x6000BB3")]
			[Address(RVA = "0x11490B8", Offset = "0x11490B8", VA = "0x11490B8")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000BB4")]
			[Address(RVA = "0x11490C0", Offset = "0x11490C0", VA = "0x11490C0")]
			internal object <Create>b__0()
			{
				return null;
			}
		}

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AFF4", Offset = "0xB6AFF4")]
		private string <Title>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6B004", Offset = "0xB6B004")]
		private bool <IsPrivate>k__BackingField;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Func<object> _valueGetter;

		[Token(Token = "0x17000064")]
		public string Title
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x1148DB4", Offset = "0x1148DB4", VA = "0x1148DB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E808", Offset = "0xB6E808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x1148DBC", Offset = "0x1148DBC", VA = "0x1148DBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E818", Offset = "0xB6E818")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public object Value
		{
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x1148DC4", Offset = "0x1148DC4", VA = "0x1148DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public bool IsPrivate
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1148F2C", Offset = "0x1148F2C", VA = "0x1148F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E828", Offset = "0xB6E828")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1148F34", Offset = "0x1148F34", VA = "0x1148F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E838", Offset = "0xB6E838")]
			private set
			{
			}
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x1148F40", Offset = "0x1148F40", VA = "0x1148F40")]
		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1148FD4", Offset = "0x1148FD4", VA = "0x1148FD4")]
		public static InfoEntry Create(string name, object value, bool isPrivate = false)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1148FCC", Offset = "0x1148FCC", VA = "0x1148FCC")]
		public InfoEntry()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public enum DefaultTabs
	{
		[Token(Token = "0x40001C9")]
		SystemInformation,
		[Token(Token = "0x40001CA")]
		Options,
		[Token(Token = "0x40001CB")]
		Console,
		[Token(Token = "0x40001CC")]
		Profiler,
		[Token(Token = "0x40001CD")]
		BugReporter
	}
	[Token(Token = "0x2000077")]
	public enum PinAlignment
	{
		[Token(Token = "0x40001CF")]
		TopLeft,
		[Token(Token = "0x40001D0")]
		TopRight,
		[Token(Token = "0x40001D1")]
		BottomLeft,
		[Token(Token = "0x40001D2")]
		BottomRight,
		[Token(Token = "0x40001D3")]
		CenterLeft,
		[Token(Token = "0x40001D4")]
		CenterRight,
		[Token(Token = "0x40001D5")]
		TopCenter,
		[Token(Token = "0x40001D6")]
		BottomCenter
	}
	[Token(Token = "0x2000078")]
	public enum ConsoleAlignment
	{
		[Token(Token = "0x40001D8")]
		Top,
		[Token(Token = "0x40001D9")]
		Bottom
	}
	[Token(Token = "0x2000079")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x200018B")]
		public enum ShortcutActions
		{
			[Token(Token = "0x400073A")]
			None,
			[Token(Token = "0x400073B")]
			OpenSystemInfoTab,
			[Token(Token = "0x400073C")]
			OpenConsoleTab,
			[Token(Token = "0x400073D")]
			OpenOptionsTab,
			[Token(Token = "0x400073E")]
			OpenProfilerTab,
			[Token(Token = "0x400073F")]
			OpenBugReporterTab,
			[Token(Token = "0x4000740")]
			ClosePanel,
			[Token(Token = "0x4000741")]
			OpenPanel,
			[Token(Token = "0x4000742")]
			TogglePanel,
			[Token(Token = "0x4000743")]
			ShowBugReportPopover,
			[Token(Token = "0x4000744")]
			ToggleDockedConsole,
			[Token(Token = "0x4000745")]
			ToggleDockedProfiler
		}

		[Token(Token = "0x200018C")]
		public enum TriggerBehaviours
		{
			[Token(Token = "0x4000747")]
			TripleTap,
			[Token(Token = "0x4000748")]
			TapAndHold,
			[Token(Token = "0x4000749")]
			DoubleTap
		}

		[Token(Token = "0x200018D")]
		public enum TriggerEnableModes
		{
			[Token(Token = "0x400074B")]
			Enabled,
			[Token(Token = "0x400074C")]
			MobileOnly,
			[Token(Token = "0x400074D")]
			Off,
			[Token(Token = "0x400074E")]
			DevelopmentBuildsOnly
		}

		[Serializable]
		[Token(Token = "0x200018E")]
		public sealed class KeyboardShortcut
		{
			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			public ShortcutActions Action;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[SerializeField]
			public bool Alt;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[SerializeField]
			public bool Control;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			public KeyCode Key;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			public bool Shift;

			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x106C2F0", Offset = "0x106C2F0", VA = "0x106C2F0")]
			public KeyboardShortcut()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200018F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB68", Offset = "0xB6AB68")]
		private sealed class <>c
		{
			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<int, bool> <>9__38_0;

			[Token(Token = "0x6000BB7")]
			[Address(RVA = "0x106C978", Offset = "0x106C978", VA = "0x106C978")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BB8")]
			[Address(RVA = "0x106C980", Offset = "0x106C980", VA = "0x106C980")]
			internal bool <set_EntryCode>b__38_0(int p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001DA")]
		private const string ResourcesPath = "/usr/Resources/SRDebugger";

		[Token(Token = "0x40001DB")]
		private const string ResourcesName = "Settings";

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings _instance;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isEnabled;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool _autoLoad;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private DefaultTabs _defaultTab;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TriggerEnableModes _triggerEnableMode;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TriggerBehaviours _triggerBehaviour;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _enableKeyboardShortcuts;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private KeyboardShortcut[] _keyboardShortcuts;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private KeyboardShortcut[] _newKeyboardShortcuts;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _keyboardModifierControl;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		private bool _keyboardModifierAlt;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		private bool _keyboardModifierShift;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		private bool _keyboardEscapeClose;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private bool _enableBackgroundTransparency;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		private bool _collapseDuplicateLogEntries;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		[SerializeField]
		private bool _richTextInConsole;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		[SerializeField]
		private bool _requireEntryCode;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _requireEntryCodeEveryTime;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int[] _entryCode;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool _useDebugCamera;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int _debugLayer;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6B164", Offset = "0xB6B164")]
		private float _debugCameraDepth;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _apiKey;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _enableBugReporter;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private DefaultTabs[] _disabledTabs;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private PinAlignment _profilerAlignment;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private PinAlignment _optionsAlignment;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ConsoleAlignment _consoleAlignment;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private PinAlignment _triggerPosition;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private int _maximumConsoleEntries;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private bool _enableEventSystemCreation;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
		[SerializeField]
		private bool _automaticShowCursor;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float _uiScale;

		[Token(Token = "0x17000067")]
		public static Settings Instance
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x105FF84", Offset = "0x105FF84", VA = "0x105FF84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public bool IsEnabled
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x106C440", Offset = "0x106C440", VA = "0x106C440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public bool AutoLoad
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x106C448", Offset = "0x106C448", VA = "0x106C448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public DefaultTabs DefaultTab
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x106C450", Offset = "0x106C450", VA = "0x106C450")]
			get
			{
				return default(DefaultTabs);
			}
		}

		[Token(Token = "0x1700006B")]
		public TriggerEnableModes EnableTrigger
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x106C458", Offset = "0x106C458", VA = "0x106C458")]
			get
			{
				return default(TriggerEnableModes);
			}
		}

		[Token(Token = "0x1700006C")]
		public TriggerBehaviours TriggerBehaviour
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x106C460", Offset = "0x106C460", VA = "0x106C460")]
			get
			{
				return default(TriggerBehaviours);
			}
		}

		[Token(Token = "0x1700006D")]
		public bool EnableKeyboardShortcuts
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x106C468", Offset = "0x106C468", VA = "0x106C468")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public IList<KeyboardShortcut> KeyboardShortcuts
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x106C470", Offset = "0x106C470", VA = "0x106C470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public bool KeyboardEscapeClose
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x106C478", Offset = "0x106C478", VA = "0x106C478")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public bool EnableBackgroundTransparency
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x106C480", Offset = "0x106C480", VA = "0x106C480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public bool RequireCode
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x106C488", Offset = "0x106C488", VA = "0x106C488")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		public bool RequireEntryCodeEveryTime
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x106C490", Offset = "0x106C490", VA = "0x106C490")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public IList<int> EntryCode
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x106685C", Offset = "0x106685C", VA = "0x106685C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x106C498", Offset = "0x106C498", VA = "0x106C498")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool UseDebugCamera
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x106C688", Offset = "0x106C688", VA = "0x106C688")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public int DebugLayer
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x106C690", Offset = "0x106C690", VA = "0x106C690")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000076")]
		public float DebugCameraDepth
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x106C698", Offset = "0x106C698", VA = "0x106C698")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000077")]
		public bool CollapseDuplicateLogEntries
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x106C6A0", Offset = "0x106C6A0", VA = "0x106C6A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000078")]
		public bool RichTextInConsole
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x106C6A8", Offset = "0x106C6A8", VA = "0x106C6A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public string ApiKey
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x106C6B0", Offset = "0x106C6B0", VA = "0x106C6B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public bool EnableBugReporter
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x106C6B8", Offset = "0x106C6B8", VA = "0x106C6B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public IList<DefaultTabs> DisabledTabs
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x106C6C0", Offset = "0x106C6C0", VA = "0x106C6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public PinAlignment TriggerPosition
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x106C6C8", Offset = "0x106C6C8", VA = "0x106C6C8")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x1700007D")]
		public PinAlignment ProfilerAlignment
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x106C6D0", Offset = "0x106C6D0", VA = "0x106C6D0")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x1700007E")]
		public PinAlignment OptionsAlignment
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x106C6D8", Offset = "0x106C6D8", VA = "0x106C6D8")]
			get
			{
				return default(PinAlignment);
			}
		}

		[Token(Token = "0x1700007F")]
		public ConsoleAlignment ConsoleAlignment
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x106C6E0", Offset = "0x106C6E0", VA = "0x106C6E0")]
			get
			{
				return default(ConsoleAlignment);
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x106C6E8", Offset = "0x106C6E8", VA = "0x106C6E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public int MaximumConsoleEntries
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x106C6F0", Offset = "0x106C6F0", VA = "0x106C6F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x106C6F8", Offset = "0x106C6F8", VA = "0x106C6F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool EnableEventSystemGeneration
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x106C700", Offset = "0x106C700", VA = "0x106C700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x106C708", Offset = "0x106C708", VA = "0x106C708")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool AutomaticallyShowCursor
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x106C714", Offset = "0x106C714", VA = "0x106C714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public float UIScale
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x106C71C", Offset = "0x106C71C", VA = "0x106C71C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x106C724", Offset = "0x106C724", VA = "0x106C724")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event PropertyChangedEventHandler PropertyChanged
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x106C2F8", Offset = "0x106C2F8", VA = "0x106C2F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E848", Offset = "0xB6E848")]
			add
			{
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x106C39C", Offset = "0x106C39C", VA = "0x106C39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E858", Offset = "0xB6E858")]
			remove
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x106C108", Offset = "0x106C108", VA = "0x106C108")]
		private static KeyboardShortcut[] GetDefaultKeyboardShortcuts()
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x106BF74", Offset = "0x106BF74", VA = "0x106BF74")]
		private void UpgradeKeyboardShortcuts()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x106C7A0", Offset = "0x106C7A0", VA = "0x106C7A0")]
		private void OnPropertyChanged(string propertyName)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x106BEC4", Offset = "0x106BEC4", VA = "0x106BEC4")]
		private static Settings GetOrCreateInstance()
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x106C834", Offset = "0x106C834", VA = "0x106C834")]
		public Settings()
		{
		}
	}
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69258", Offset = "0xB69258")]
	public class SRDebuggerInit : SRMonoBehaviourEx
	{
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x114CAD0", Offset = "0x114CAD0", VA = "0x114CAD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x114CB08", Offset = "0x114CB08", VA = "0x114CB08", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x114CB90", Offset = "0x114CB90", VA = "0x114CB90")]
		public SRDebuggerInit()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public static class VersionInfo
	{
		[Token(Token = "0x40001FE")]
		public const string Version = "1.7.1";
	}
}
namespace SRDebugger.Scripts
{
	[Token(Token = "0x200007C")]
	public class DebuggerTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SRTab _aboutTabInstance;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DefaultTabs? _activeTab;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _hasStarted;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SRTab AboutTab;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B25C", Offset = "0xB6B25C")]
		public SRTabController TabController;

		[Token(Token = "0x17000084")]
		public DefaultTabs? ActiveTab
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x114CB98", Offset = "0x114CB98", VA = "0x114CB98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x114CD04", Offset = "0x114CD04", VA = "0x114CD04", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x114D1D8", Offset = "0x114D1D8", VA = "0x114D1D8")]
		public bool OpenTab(DefaultTabs tab)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x114D57C", Offset = "0x114D57C", VA = "0x114D57C")]
		public void ShowAboutTab()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x114D614", Offset = "0x114D614", VA = "0x114D614")]
		public DebuggerTabController()
		{
		}
	}
}
namespace SRDebugger.UI
{
	[Token(Token = "0x200007D")]
	public class ProfilerFPSLabel : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _nextUpdate;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ImportAttribute", RVA = "0xB6B26C", Offset = "0xB6B26C")]
		private IProfilerService _profilerService;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float UpdateFrequency;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B27C", Offset = "0xB6B27C")]
		[SerializeField]
		private Text _text;

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x1076AB4", Offset = "0x1076AB4", VA = "0x1076AB4", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1076AFC", Offset = "0x1076AFC", VA = "0x1076AFC")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1076C8C", Offset = "0x1076C8C", VA = "0x1076C8C")]
		public ProfilerFPSLabel()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class DebugPanelRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B2B4", Offset = "0xB6B2B4")]
		public Canvas Canvas;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B2C4", Offset = "0xB6B2C4")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B2D4", Offset = "0xB6B2D4")]
		public DebuggerTabController TabController;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1072D50", Offset = "0x1072D50", VA = "0x1072D50")]
		public void Close()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1072E30", Offset = "0x1072E30", VA = "0x1072E30")]
		public void CloseAndDestroy()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1072F10", Offset = "0x1072F10", VA = "0x1072F10")]
		public DebugPanelRoot()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class MobileMenuController : SRMonoBehaviourEx
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Button _closeButton;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _maxMenuWidth;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _peekAmount;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _targetXPosition;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B304", Offset = "0xB6B304")]
		public RectTransform Content;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B314", Offset = "0xB6B314")]
		public RectTransform Menu;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B324", Offset = "0xB6B324")]
		public Button OpenButton;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B334", Offset = "0xB6B334")]
		public SRTabController TabController;

		[Token(Token = "0x17000085")]
		public float PeekAmount
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1072F18", Offset = "0x1072F18", VA = "0x1072F18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000086")]
		public float MaxMenuWidth
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1072F20", Offset = "0x1072F20", VA = "0x1072F20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1072F28", Offset = "0x1072F28", VA = "0x1072F28", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1073654", Offset = "0x1073654", VA = "0x1073654", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1073220", Offset = "0x1073220", VA = "0x1073220")]
		private void CreateCloseButton()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1073840", Offset = "0x1073840", VA = "0x1073840")]
		private void SetRectSize(RectTransform rect)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1073930", Offset = "0x1073930", VA = "0x1073930")]
		private void CloseButtonClicked()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x107396C", Offset = "0x107396C", VA = "0x107396C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1073AB4", Offset = "0x1073AB4", VA = "0x1073AB4")]
		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1073AB8", Offset = "0x1073AB8", VA = "0x1073AB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6E868", Offset = "0xB6E868")]
		public void Open()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1073934", Offset = "0x1073934", VA = "0x1073934")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6E8A0", Offset = "0xB6E8A0")]
		public void Close()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1073B2C", Offset = "0x1073B2C", VA = "0x1073B2C")]
		public MobileMenuController()
		{
		}
	}
}
namespace SRDebugger.UI.Tabs
{
	[Token(Token = "0x2000080")]
	public class BugReportTabController : SRMonoBehaviourEx, IEnableTab
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B344", Offset = "0xB6B344")]
		public BugReportSheetController BugReportSheetPrefab;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B354", Offset = "0xB6B354")]
		public RectTransform Container;

		[Token(Token = "0x17000087")]
		public bool IsEnabled
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1076C9C", Offset = "0x1076C9C", VA = "0x1076C9C", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1076CBC", Offset = "0x1076CBC", VA = "0x1076CBC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1076DB0", Offset = "0x1076DB0", VA = "0x1076DB0")]
		private void TakingScreenshot()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1076E68", Offset = "0x1076E68", VA = "0x1076E68")]
		private void ScreenshotComplete()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1076F24", Offset = "0x1076F24", VA = "0x1076F24")]
		public BugReportTabController()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class ConsoleTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000215")]
		private const int MaxLength = 2600;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _consoleCanvas;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isDirty;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B364", Offset = "0xB6B364")]
		public ConsoleLogControl ConsoleLogControl;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B374", Offset = "0xB6B374")]
		public Toggle PinToggle;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B384", Offset = "0xB6B384")]
		public ScrollRect StackTraceScrollRect;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B394", Offset = "0xB6B394")]
		public Text StackTraceText;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3A4", Offset = "0xB6B3A4")]
		public Toggle ToggleErrors;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3B4", Offset = "0xB6B3B4")]
		public Text ToggleErrorsText;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3C4", Offset = "0xB6B3C4")]
		public Toggle ToggleInfo;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3D4", Offset = "0xB6B3D4")]
		public Text ToggleInfoText;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3E4", Offset = "0xB6B3E4")]
		public Toggle ToggleWarnings;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B3F4", Offset = "0xB6B3F4")]
		public Text ToggleWarningsText;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B404", Offset = "0xB6B404")]
		public Toggle FilterToggle;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B414", Offset = "0xB6B414")]
		public InputField FilterField;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B424", Offset = "0xB6B424")]
		public GameObject FilterBarContainer;

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1076F2C", Offset = "0x1076F2C", VA = "0x1076F2C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1077870", Offset = "0x1077870", VA = "0x1077870")]
		private void FilterToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1077928", Offset = "0x1077928", VA = "0x1077928")]
		private void FilterValueChanged(string filterText)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x10779E0", Offset = "0x10779E0", VA = "0x10779E0")]
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1077A94", Offset = "0x1077A94", VA = "0x1077A94")]
		private void PinToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1077B54", Offset = "0x1077B54", VA = "0x1077B54", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1077C68", Offset = "0x1077C68", VA = "0x1077C68", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1077C94", Offset = "0x1077C94", VA = "0x1077C94")]
		private void ConsoleLogSelectedItemChanged(object item)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1077D24", Offset = "0x1077D24", VA = "0x1077D24", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1077364", Offset = "0x1077364", VA = "0x1077364")]
		private void PopulateStackTraceArea(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1077528", Offset = "0x1077528", VA = "0x1077528")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1077D60", Offset = "0x1077D60", VA = "0x1077D60")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1077D6C", Offset = "0x1077D6C", VA = "0x1077D6C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1077E34", Offset = "0x1077E34", VA = "0x1077E34")]
		public ConsoleTabController()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1077E3C", Offset = "0x1077E3C", VA = "0x1077E3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E8D8", Offset = "0xB6E8D8")]
		private void <Start>b__16_0(bool isOn)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1077E48", Offset = "0x1077E48", VA = "0x1077E48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E8E8", Offset = "0xB6E8E8")]
		private void <Start>b__16_1(bool isOn)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1077E54", Offset = "0x1077E54", VA = "0x1077E54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E8F8", Offset = "0xB6E8F8")]
		private void <Start>b__16_2(bool isOn)
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class InfoTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000225")]
		public const char Tick = '✓';

		[Token(Token = "0x4000226")]
		public const char Cross = '×';

		[Token(Token = "0x4000227")]
		public const string NameColor = "#BCBCBC";

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, InfoBlock> _infoBlocks;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B434", Offset = "0xB6B434")]
		public InfoBlock InfoBlockPrefab;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B444", Offset = "0xB6B444")]
		public RectTransform LayoutContainer;

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1077E60", Offset = "0x1077E60", VA = "0x1077E60", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1077E88", Offset = "0x1077E88", VA = "0x1077E88")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1078400", Offset = "0x1078400", VA = "0x1078400")]
		private void FillInfoBlock(InfoBlock block, IList<InfoEntry> info)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1078354", Offset = "0x1078354", VA = "0x1078354")]
		private InfoBlock CreateBlock(string title)
		{
			return null;
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1078B38", Offset = "0x1078B38", VA = "0x1078B38")]
		public InfoTabController()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class OptionsTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000190")]
		private class CategoryInstance
		{
			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6D584", Offset = "0xB6D584")]
			private CategoryGroup <CategoryGroup>k__BackingField;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly List<OptionsControlBase> Options;

			[Token(Token = "0x1700024D")]
			public CategoryGroup CategoryGroup
			{
				[Token(Token = "0x6000BB9")]
				[Address(RVA = "0x12BC78C", Offset = "0x12BC78C", VA = "0x12BC78C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB700E4", Offset = "0xB700E4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000BBA")]
				[Address(RVA = "0x12BC794", Offset = "0x12BC794", VA = "0x12BC794")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB700F4", Offset = "0xB700F4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000BBB")]
			[Address(RVA = "0x12BC79C", Offset = "0x12BC79C", VA = "0x12BC79C")]
			public CategoryInstance(CategoryGroup group)
			{
			}
		}

		[Token(Token = "0x2000191")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB78", Offset = "0xB6AB78")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OptionsTabController <>4__this;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CategoryInstance categoryInstance;

			[Token(Token = "0x6000BBC")]
			[Address(RVA = "0x12BC758", Offset = "0x12BC758", VA = "0x12BC758")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000BBD")]
			[Address(RVA = "0x12BC760", Offset = "0x12BC760", VA = "0x12BC760")]
			internal void <CreateCategory>b__1(bool b)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000192")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB88", Offset = "0xB6AB88")]
		private sealed class <>c
		{
			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<OptionDefinition> <>9__30_0;

			[Token(Token = "0x6000BBF")]
			[Address(RVA = "0x12BC70C", Offset = "0x12BC70C", VA = "0x12BC70C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BC0")]
			[Address(RVA = "0x12BC714", Offset = "0x12BC714", VA = "0x12BC714")]
			internal int <CreateCategory>b__30_0(OptionDefinition d1, OptionDefinition d2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<OptionsControlBase> _controls;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<CategoryInstance> _categories;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _options;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _queueRefresh;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Canvas _optionCanvas;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B454", Offset = "0xB6B454")]
		public ActionControl ActionControlPrefab;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B464", Offset = "0xB6B464")]
		public CategoryGroup CategoryGroupPrefab;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B474", Offset = "0xB6B474")]
		public RectTransform ContentContainer;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B484", Offset = "0xB6B484")]
		public GameObject NoOptionsNotice;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B494", Offset = "0xB6B494")]
		public Toggle PinButton;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4A4", Offset = "0xB6B4A4")]
		public GameObject PinPromptSpacer;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4B4", Offset = "0xB6B4B4")]
		public GameObject PinPromptText;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool _isTogglingCategory;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1078BA8", Offset = "0x1078BA8", VA = "0x1078BA8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x10793B4", Offset = "0x10793B4", VA = "0x10793B4")]
		private void OnOptionPinnedStateChanged(OptionDefinition optionDefinition, bool isPinned)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x107945C", Offset = "0x107945C", VA = "0x107945C")]
		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1079618", Offset = "0x1079618", VA = "0x1079618")]
		private void OnOptionsValueChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x1079624", Offset = "0x1079624", VA = "0x1079624", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x1079734", Offset = "0x1079734", VA = "0x1079734", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1079B44", Offset = "0x1079B44", VA = "0x1079B44", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x1079D38", Offset = "0x1079D38", VA = "0x1079D38")]
		private void PanelOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x107985C", Offset = "0x107985C", VA = "0x107985C")]
		public void SetSelectionModeEnabled(bool isEnabled)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1079B84", Offset = "0x1079B84", VA = "0x1079B84")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1079FDC", Offset = "0x1079FDC", VA = "0x1079FDC")]
		private void CommitPinnedOptions()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1079E18", Offset = "0x1079E18", VA = "0x1079E18")]
		private void RefreshCategorySelection()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x107A36C", Offset = "0x107A36C", VA = "0x107A36C")]
		private void OnOptionSelectionToggle(bool selected)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x107A3A8", Offset = "0x107A3A8", VA = "0x107A3A8")]
		private void OnCategorySelectionToggle(CategoryInstance category, bool selected)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1078EA0", Offset = "0x1078EA0", VA = "0x1078EA0")]
		protected void Populate()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x107A470", Offset = "0x107A470", VA = "0x107A470")]
		protected void CreateCategory(string title, List<OptionDefinition> options)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1079480", Offset = "0x1079480", VA = "0x1079480")]
		private void Clear()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x107AAE0", Offset = "0x107AAE0", VA = "0x107AAE0")]
		public OptionsTabController()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class ProfilerTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isDirty;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4C4", Offset = "0xB6B4C4")]
		public Toggle PinToggle;

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x12BC820", Offset = "0x12BC820", VA = "0x12BC820", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x12BC9C0", Offset = "0x12BC9C0", VA = "0x12BC9C0")]
		private void PinToggleValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x12BCA80", Offset = "0x12BCA80", VA = "0x12BCA80", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x12BCA90", Offset = "0x12BCA90", VA = "0x12BCA90", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x12BC8D4", Offset = "0x12BC8D4", VA = "0x12BC8D4")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x12BCAA4", Offset = "0x12BCAA4", VA = "0x12BCAA4")]
		public ProfilerTabController()
		{
		}
	}
}
namespace SRDebugger.UI.Other
{
	[Token(Token = "0x2000085")]
	public class BugReportPopoverRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4D4", Offset = "0xB6B4D4")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4E4", Offset = "0xB6B4E4")]
		public RectTransform Container;

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1073B40", Offset = "0x1073B40", VA = "0x1073B40")]
		public BugReportPopoverRoot()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class BugReportSheetController : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000193")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AB98", Offset = "0xB6AB98")]
		private sealed class <SubmitCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BugReportSheetController <>4__this;

			[Token(Token = "0x1700024E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BC4")]
				[Address(RVA = "0x10745F8", Offset = "0x10745F8", VA = "0x10745F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700024F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BC6")]
				[Address(RVA = "0x1074664", Offset = "0x1074664", VA = "0x1074664", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BC1")]
			[Address(RVA = "0x1073FA4", Offset = "0x1073FA4", VA = "0x1073FA4")]
			[DebuggerHidden]
			public <SubmitCo>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000BC2")]
			[Address(RVA = "0x1074240", Offset = "0x1074240", VA = "0x1074240", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BC3")]
			[Address(RVA = "0x1074244", Offset = "0x1074244", VA = "0x1074244", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BC5")]
			[Address(RVA = "0x1074600", Offset = "0x1074600", VA = "0x1074600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B4F4", Offset = "0xB6B4F4")]
		public GameObject ButtonContainer;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B504", Offset = "0xB6B504")]
		public Text ButtonText;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B514", Offset = "0xB6B514")]
		public Button CancelButton;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Action CancelPressed;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B524", Offset = "0xB6B524")]
		public InputField DescriptionField;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B534", Offset = "0xB6B534")]
		public InputField EmailField;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B544", Offset = "0xB6B544")]
		public Slider ProgressBar;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B554", Offset = "0xB6B554")]
		public Text ResultMessageText;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Action ScreenshotComplete;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B564", Offset = "0xB6B564")]
		public Button SubmitButton;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action<bool, string> SubmitComplete;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Action TakingScreenshot;

		[Token(Token = "0x17000088")]
		public bool IsCancelButtonEnabled
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x1073B48", Offset = "0x1073B48", VA = "0x1073B48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x1073B74", Offset = "0x1073B74", VA = "0x1073B74")]
			set
			{
			}
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1073BB0", Offset = "0x1073BB0", VA = "0x1073BB0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1073D44", Offset = "0x1073D44", VA = "0x1073D44")]
		public void Submit()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1073F90", Offset = "0x1073F90", VA = "0x1073F90")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1073F1C", Offset = "0x1073F1C", VA = "0x1073F1C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E908", Offset = "0xB6E908")]
		private IEnumerator SubmitCo()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1073FD0", Offset = "0x1073FD0", VA = "0x1073FD0")]
		private void OnBugReportProgress(float progress)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1073FF4", Offset = "0x1073FF4", VA = "0x1073FF4")]
		private void OnBugReportComplete(bool didSucceed, string errorMessage)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1073BEC", Offset = "0x1073BEC", VA = "0x1073BEC")]
		protected void SetLoadingSpinnerVisible(bool visible)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1073CC8", Offset = "0x1073CC8", VA = "0x1073CC8")]
		protected void ClearForm()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x10740C0", Offset = "0x10740C0", VA = "0x10740C0")]
		protected void ShowErrorMessage(string userMessage, [Optional] string serverMessage)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1073C44", Offset = "0x1073C44", VA = "0x1073C44")]
		protected void ClearErrorMessage()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1073E40", Offset = "0x1073E40", VA = "0x1073E40")]
		protected void SetFormEnabled(bool e)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x10741E0", Offset = "0x10741E0", VA = "0x10741E0")]
		private string GetDefaultEmailFieldContents()
		{
			return null;
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1073EC0", Offset = "0x1073EC0", VA = "0x1073EC0")]
		private void SetDefaultEmailFieldContents(string value)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1074238", Offset = "0x1074238", VA = "0x1074238")]
		public BugReportSheetController()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class CategoryGroup : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B574", Offset = "0xB6B574")]
		public RectTransform Container;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B584", Offset = "0xB6B584")]
		public Text Header;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B594", Offset = "0xB6B594")]
		public GameObject Background;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B5A4", Offset = "0xB6B5A4")]
		public Toggle SelectionToggle;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject[] EnabledDuringSelectionMode;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x17000089")]
		public bool IsSelected
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x107466C", Offset = "0x107466C", VA = "0x107466C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x107468C", Offset = "0x107468C", VA = "0x107468C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool SelectionModeEnabled
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x107478C", Offset = "0x107478C", VA = "0x107478C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x1074794", Offset = "0x1074794", VA = "0x1074794")]
			set
			{
			}
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1074828", Offset = "0x1074828", VA = "0x1074828")]
		public CategoryGroup()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69290", Offset = "0xB69290")]
	public class ConfigureCanvasFromSettings : SRMonoBehaviour
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas _canvas;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CanvasScaler _canvasScaler;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float _originalScale;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _lastSetScale;

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1074890", Offset = "0x1074890", VA = "0x1074890")]
		private void Start()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1074A88", Offset = "0x1074A88", VA = "0x1074A88")]
		private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1074BA4", Offset = "0x1074BA4", VA = "0x1074BA4")]
		public ConfigureCanvasFromSettings()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ConsoleTabQuickViewControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x4000253")]
		private const int Max = 1000;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string MaxString;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _prevErrorCount;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _prevInfoCount;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _prevWarningCount;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "ImportAttribute", RVA = "0xB6B5B4", Offset = "0xB6B5B4")]
		public IConsoleService ConsoleService;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B5C4", Offset = "0xB6B5C4")]
		public Text ErrorCountText;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B5D4", Offset = "0xB6B5D4")]
		public Text InfoCountText;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B5E4", Offset = "0xB6B5E4")]
		public Text WarningCountText;

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1074BAC", Offset = "0x1074BAC", VA = "0x1074BAC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1074C54", Offset = "0x1074C54", VA = "0x1074C54", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1075108", Offset = "0x1075108", VA = "0x1075108")]
		private static bool HasChanged(int newCount, ref int oldCount, int max)
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x10751B4", Offset = "0x10751B4", VA = "0x10751B4")]
		public ConsoleTabQuickViewControl()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB692F4", Offset = "0xB692F4")]
	public class DebugPanelBackgroundBehaviour : SRMonoBehaviour
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string _defaultKey;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isTransparent;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private StyleComponent _styleComponent;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string TransparentStyleKey;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x107524C", Offset = "0x107524C", VA = "0x107524C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10752B8", Offset = "0x10752B8", VA = "0x10752B8")]
		private void Update()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1075344", Offset = "0x1075344", VA = "0x1075344")]
		public DebugPanelBackgroundBehaviour()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class DockConsoleController : SRMonoBehaviourEx, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000260")]
		public const float NonFocusOpacity = 0.65f;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isDirty;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		private bool _isDragging;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _pointersOver;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B5F4", Offset = "0xB6B5F4")]
		public GameObject BottomHandle;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B604", Offset = "0xB6B604")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B614", Offset = "0xB6B614")]
		public ConsoleLogControl Console;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B624", Offset = "0xB6B624")]
		public GameObject Dropdown;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B634", Offset = "0xB6B634")]
		public Image DropdownToggleSprite;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B644", Offset = "0xB6B644")]
		public Text TextErrors;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B654", Offset = "0xB6B654")]
		public Text TextInfo;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B664", Offset = "0xB6B664")]
		public Text TextWarnings;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B674", Offset = "0xB6B674")]
		public Toggle ToggleErrors;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B684", Offset = "0xB6B684")]
		public Toggle ToggleInfo;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B694", Offset = "0xB6B694")]
		public Toggle ToggleWarnings;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6A4", Offset = "0xB6B6A4")]
		public GameObject TopBar;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6B4", Offset = "0xB6B6B4")]
		public GameObject TopHandle;

		[Token(Token = "0x1700008B")]
		public bool IsVisible
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x107539C", Offset = "0x107539C", VA = "0x107539C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x1062AB8", Offset = "0x1062AB8", VA = "0x1062AB8")]
			set
			{
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x10753C0", Offset = "0x10753C0", VA = "0x10753C0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x107577C", Offset = "0x107577C", VA = "0x107577C", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x10758A0", Offset = "0x10758A0", VA = "0x10758A0", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x10758D0", Offset = "0x10758D0", VA = "0x10758D0", Slot = "9")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x10758F8", Offset = "0x10758F8", VA = "0x10758F8", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1075934", Offset = "0x1075934", VA = "0x1075934")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1062668", Offset = "0x1062668", VA = "0x1062668")]
		public void SetDropdownVisibility(bool visible)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10627EC", Offset = "0x10627EC", VA = "0x10627EC")]
		public void SetAlignmentMode(ConsoleAlignment alignment)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x10754D8", Offset = "0x10754D8", VA = "0x10754D8")]
		private void Refresh()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1075730", Offset = "0x1075730", VA = "0x1075730")]
		private void RefreshAlpha()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1075940", Offset = "0x1075940", VA = "0x1075940")]
		public void ToggleDropdownVisible()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x107597C", Offset = "0x107597C", VA = "0x107597C")]
		public void MenuButtonPressed()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1075A3C", Offset = "0x1075A3C", VA = "0x1075A3C")]
		public void ClearButtonPressed()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1075AF4", Offset = "0x1075AF4", VA = "0x1075AF4")]
		public void TogglesUpdated()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1075B70", Offset = "0x1075B70", VA = "0x1075B70", Slot = "11")]
		public void OnPointerEnter(PointerEventData e)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1075B7C", Offset = "0x1075B7C", VA = "0x1075B7C", Slot = "12")]
		public void OnPointerExit(PointerEventData e)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1075B84", Offset = "0x1075B84", VA = "0x1075B84")]
		public void OnBeginDrag()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1075B90", Offset = "0x1075B90", VA = "0x1075B90")]
		public void OnEndDrag()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1075B9C", Offset = "0x1075B9C", VA = "0x1075B9C")]
		public DockConsoleController()
		{
		}
	}
	[Token(Token = "0x200008C")]
	public class HandleManager : SRMonoBehaviour
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _hasSet;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public GameObject BottomHandle;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject BottomLeftHandle;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public GameObject BottomRightHandle;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public PinAlignment DefaultAlignment;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GameObject LeftHandle;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GameObject RightHandle;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public GameObject TopHandle;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public GameObject TopLeftHandle;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject TopRightHandle;

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1075BA4", Offset = "0x1075BA4", VA = "0x1075BA4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1065E00", Offset = "0x1065E00", VA = "0x1065E00")]
		public void SetAlignment(PinAlignment alignment)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1075BB8", Offset = "0x1075BB8", VA = "0x1075BB8")]
		private void SetActive(GameObject obj, bool active)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1075C60", Offset = "0x1075C60", VA = "0x1075C60")]
		public HandleManager()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public interface IEnableTab
	{
		[Token(Token = "0x1700008C")]
		bool IsEnabled
		{
			[Token(Token = "0x6000469")]
			get;
		}
	}
	[Token(Token = "0x200008E")]
	public class LoadingSpinnerBehaviour : SRMonoBehaviour
	{
		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _dt;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int FrameCount;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float SpinDuration;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1075C68", Offset = "0x1075C68", VA = "0x1075C68")]
		private void Update()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1075DAC", Offset = "0x1075DAC", VA = "0x1075DAC")]
		public LoadingSpinnerBehaviour()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class PinnedUIRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6C4", Offset = "0xB6B6C4")]
		public Canvas Canvas;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6D4", Offset = "0xB6B6D4")]
		public RectTransform Container;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6E4", Offset = "0xB6B6E4")]
		public DockConsoleController DockConsoleController;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B6F4", Offset = "0xB6B6F4")]
		public GameObject Options;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B704", Offset = "0xB6B704")]
		public FlowLayoutGroup OptionsLayoutGroup;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B714", Offset = "0xB6B714")]
		public GameObject Profiler;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B724", Offset = "0xB6B724")]
		public HandleManager ProfilerHandleManager;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B734", Offset = "0xB6B734")]
		public VerticalLayoutGroup ProfilerVerticalLayoutGroup;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1075DC4", Offset = "0x1075DC4", VA = "0x1075DC4")]
		public PinnedUIRoot()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69358", Offset = "0xB69358")]
	[ExecuteInEditMode]
	public class ScrollRectPatch : MonoBehaviour
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform Content;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Mask ReplaceMask;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RectTransform Viewport;

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10767AC", Offset = "0x10767AC", VA = "0x10767AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10768FC", Offset = "0x10768FC", VA = "0x10768FC")]
		public ScrollRectPatch()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB693CC", Offset = "0xB693CC")]
	public class ScrollSettingsBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000289")]
		public const float ScrollSensitivity = 40f;

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1076904", Offset = "0x1076904", VA = "0x1076904")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1076984", Offset = "0x1076984", VA = "0x1076984")]
		public ScrollSettingsBehaviour()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class SetLayerFromSettings : SRMonoBehaviour
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x107698C", Offset = "0x107698C", VA = "0x107698C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10769C8", Offset = "0x10769C8", VA = "0x10769C8")]
		public SetLayerFromSettings()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class SRTab : SRMonoBehaviourEx
	{
		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public RectTransform HeaderExtraContent;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB6B744", Offset = "0xB6B744")]
		[HideInInspector]
		public Sprite Icon;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RectTransform IconExtraContent;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string IconStyleKey;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int SortIndex;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public SRTabButton TabButton;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6B78C", Offset = "0xB6B78C")]
		private string _title;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _longTitle;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _key;

		[Token(Token = "0x1700008D")]
		public string Title
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x1075DCC", Offset = "0x1075DCC", VA = "0x1075DCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		public string LongTitle
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x1075DD4", Offset = "0x1075DD4", VA = "0x1075DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public string Key
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x1075E0C", Offset = "0x1075E0C", VA = "0x1075E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1075E14", Offset = "0x1075E14", VA = "0x1075E14")]
		public SRTab()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class SRTabController : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000194")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABA8", Offset = "0xB6ABA8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SRTabController <>4__this;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public SRTab tab;

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0x10764BC", Offset = "0x10764BC", VA = "0x10764BC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0x1076788", Offset = "0x1076788", VA = "0x1076788")]
			internal void <AddTab>b__0()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000195")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABB8", Offset = "0xB6ABB8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<SRTab> <>9__17_0;

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0x1076750", Offset = "0x1076750", VA = "0x1076750")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BCB")]
			[Address(RVA = "0x1076758", Offset = "0x1076758", VA = "0x1076758")]
			internal int <SortTabs>b__17_0(SRTab t1, SRTab t2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<SRTab> _tabs;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SRTab _activeTab;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B7F8", Offset = "0xB6B7F8")]
		public RectTransform TabButtonContainer;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B808", Offset = "0xB6B808")]
		public SRTabButton TabButtonPrefab;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B818", Offset = "0xB6B818")]
		public RectTransform TabContentsContainer;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B828", Offset = "0xB6B828")]
		public RectTransform TabHeaderContentContainer;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B838", Offset = "0xB6B838")]
		public Text TabHeaderText;

		[Token(Token = "0x17000090")]
		public SRTab ActiveTab
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x1075E6C", Offset = "0x1075E6C", VA = "0x1075E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x1075E74", Offset = "0x1075E74", VA = "0x1075E74")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public IList<SRTab> Tabs
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x10761E0", Offset = "0x10761E0", VA = "0x10761E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000004")]
		public event Action<SRTabController, SRTab> ActiveTabChanged
		{
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x10735B0", Offset = "0x10735B0", VA = "0x10735B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E96C", Offset = "0xB6E96C")]
			add
			{
			}
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x107379C", Offset = "0x107379C", VA = "0x107379C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E97C", Offset = "0xB6E97C")]
			remove
			{
			}
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x1076238", Offset = "0x1076238", VA = "0x1076238")]
		public void AddTab(SRTab tab, bool visibleInSidebar = true)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x1075E78", Offset = "0x1075E78", VA = "0x1075E78")]
		private void MakeActive(SRTab tab)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10764C4", Offset = "0x10764C4", VA = "0x10764C4")]
		private void SortTabs()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x107667C", Offset = "0x107667C", VA = "0x107667C")]
		public SRTabController()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class TriggerRoot : SRMonoBehaviourEx
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B858", Offset = "0xB6B858")]
		public Canvas Canvas;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B868", Offset = "0xB6B868")]
		public LongPressButton TapHoldButton;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B878", Offset = "0xB6B878")]
		public RectTransform TriggerTransform;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B888", Offset = "0xB6B888")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6B888", Offset = "0xB6B888")]
		public MultiTapButton TripleTapButton;

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10769D0", Offset = "0x10769D0", VA = "0x10769D0")]
		public TriggerRoot()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class VersionTextBehaviour : SRMonoBehaviourEx
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Format;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B8D4", Offset = "0xB6B8D4")]
		public Text Text;

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10769D8", Offset = "0x10769D8", VA = "0x10769D8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1076A5C", Offset = "0x1076A5C", VA = "0x1076A5C")]
		public VersionTextBehaviour()
		{
		}
	}
}
namespace SRDebugger.UI.Controls
{
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69430", Offset = "0xB69430")]
	public class ConsoleEntryView : SRMonoBehaviourEx, IVirtualView
	{
		[Token(Token = "0x40002A1")]
		public const string ConsoleBlobInfo = "Console_Info_Blob";

		[Token(Token = "0x40002A2")]
		public const string ConsoleBlobWarning = "Console_Warning_Blob";

		[Token(Token = "0x40002A3")]
		public const string ConsoleBlobError = "Console_Error_Blob";

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _count;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _hasCount;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ConsoleEntry _prevData;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private RectTransform _rectTransform;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B8E4", Offset = "0xB6B8E4")]
		public Text Count;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B8F4", Offset = "0xB6B8F4")]
		public CanvasGroup CountContainer;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B904", Offset = "0xB6B904")]
		public StyleComponent ImageStyle;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B914", Offset = "0xB6B914")]
		public Text Message;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B924", Offset = "0xB6B924")]
		public Text StackTrace;

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x106C98C", Offset = "0x106C98C", VA = "0x106C98C", Slot = "11")]
		public void SetDataContext(object data)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x106CC64", Offset = "0x106CC64", VA = "0x106CC64", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x106CD20", Offset = "0x106CD20", VA = "0x106CD20")]
		public ConsoleEntryView()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class ConsoleLogControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000196")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABC8", Offset = "0xB6ABC8")]
		private sealed class <ScrollToBottom>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ConsoleLogControl <>4__this;

			[Token(Token = "0x17000250")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BCF")]
				[Address(RVA = "0x106D750", Offset = "0x106D750", VA = "0x106D750", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000251")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD1")]
				[Address(RVA = "0x106D7BC", Offset = "0x106D7BC", VA = "0x106D7BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BCC")]
			[Address(RVA = "0x106D028", Offset = "0x106D028", VA = "0x106D028")]
			[DebuggerHidden]
			public <ScrollToBottom>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000BCD")]
			[Address(RVA = "0x106D5DC", Offset = "0x106D5DC", VA = "0x106D5DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BCE")]
			[Address(RVA = "0x106D5E0", Offset = "0x106D5E0", VA = "0x106D5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD0")]
			[Address(RVA = "0x106D758", Offset = "0x106D758", VA = "0x106D758", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B934", Offset = "0xB6B934")]
		[SerializeField]
		private VirtualVerticalLayoutGroup _consoleScrollLayoutGroup;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B96C", Offset = "0xB6B96C")]
		[SerializeField]
		private ScrollRect _consoleScrollRect;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isDirty;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector2? _scrollPosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _showErrors;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _showInfo;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _showWarnings;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Action<ConsoleEntry> SelectedItemChanged;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _filter;

		[Token(Token = "0x17000092")]
		public bool ShowErrors
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x106CD28", Offset = "0x106CD28", VA = "0x106CD28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x106CD30", Offset = "0x106CD30", VA = "0x106CD30")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool ShowWarnings
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x106CD50", Offset = "0x106CD50", VA = "0x106CD50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x106CD58", Offset = "0x106CD58", VA = "0x106CD58")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public bool ShowInfo
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x106CD6C", Offset = "0x106CD6C", VA = "0x106CD6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x106CD74", Offset = "0x106CD74", VA = "0x106CD74")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public bool EnableSelection
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x106CD88", Offset = "0x106CD88", VA = "0x106CD88")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x106CDA8", Offset = "0x106CDA8", VA = "0x106CDA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public string Filter
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x106CDCC", Offset = "0x106CDCC", VA = "0x106CDCC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x106CDD4", Offset = "0x106CDD4", VA = "0x106CDD4")]
			set
			{
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x106CE10", Offset = "0x106CE10", VA = "0x106CE10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x106CF74", Offset = "0x106CF74", VA = "0x106CF74", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x106CFB4", Offset = "0x106CFB4", VA = "0x106CFB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6E98C", Offset = "0xB6E98C")]
		private IEnumerator ScrollToBottom()
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x106D054", Offset = "0x106D054", VA = "0x106D054", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x106D168", Offset = "0x106D168", VA = "0x106D168")]
		private void OnSelectedItemChanged(object arg0)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x106D218", Offset = "0x106D218", VA = "0x106D218", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x106D2CC", Offset = "0x106D2CC", VA = "0x106D2CC")]
		private void Refresh()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x106CD44", Offset = "0x106CD44", VA = "0x106CD44")]
		private void SetIsDirty()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x106D5B8", Offset = "0x106D5B8", VA = "0x106D5B8")]
		private void ConsoleOnUpdated(IConsoleService console)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x106D5C4", Offset = "0x106D5C4", VA = "0x106D5C4")]
		public ConsoleLogControl()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class DataBoundControl : OptionsControlBase
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool _hasStarted;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool _isReadOnly;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private object _prevValue;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private PropertyReference _prop;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6B9A4", Offset = "0xB6B9A4")]
		private string <PropertyName>k__BackingField;

		[Token(Token = "0x17000097")]
		public PropertyReference Property
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x106F56C", Offset = "0x106F56C", VA = "0x106F56C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public bool IsReadOnly
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0x106F574", Offset = "0x106F574", VA = "0x106F574")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000099")]
		public string PropertyName
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x106F57C", Offset = "0x106F57C", VA = "0x106F57C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6E9F0", Offset = "0xB6E9F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x106F584", Offset = "0x106F584", VA = "0x106F584")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EA00", Offset = "0xB6EA00")]
			private set
			{
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x106F58C", Offset = "0x106F58C", VA = "0x106F58C")]
		public void Bind(string propertyName, PropertyReference prop)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x106DB6C", Offset = "0x106DB6C", VA = "0x106DB6C")]
		protected void UpdateValue(object newValue)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x106F610", Offset = "0x106F610", VA = "0x106F610", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x106DC0C", Offset = "0x106DC0C", VA = "0x106DC0C", Slot = "12")]
		protected virtual void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x60004A2")]
		protected abstract void OnValueUpdated(object newValue);

		[Token(Token = "0x60004A3")]
		public abstract bool CanBind(Type type, bool isReadOnly);

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x106DAC0", Offset = "0x106DAC0", VA = "0x106DAC0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x106F744", Offset = "0x106F744", VA = "0x106F744", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x106DD34", Offset = "0x106DD34", VA = "0x106DD34")]
		protected DataBoundControl()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class OptionsControlBase : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _selectionModeEnabled;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B9B4", Offset = "0xB6B9B4")]
		public Toggle SelectionModeToggle;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OptionDefinition Option;

		[Token(Token = "0x1700009A")]
		public bool SelectionModeEnabled
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x106F904", Offset = "0x106F904", VA = "0x106F904")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x106F90C", Offset = "0x106F90C", VA = "0x106F90C")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool IsSelected
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x106FA3C", Offset = "0x106FA3C", VA = "0x106FA3C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x106FA5C", Offset = "0x106FA5C", VA = "0x106FA5C")]
			set
			{
			}
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x106FB5C", Offset = "0x106FB5C", VA = "0x106FB5C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x106F784", Offset = "0x106F784", VA = "0x106F784", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x106FBAC", Offset = "0x106FBAC", VA = "0x106FBAC", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x106D9EC", Offset = "0x106D9EC", VA = "0x106D9EC")]
		protected OptionsControlBase()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class InfoBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B9C4", Offset = "0xB6B9C4")]
		public Text Content;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B9D4", Offset = "0xB6B9D4")]
		public Text Title;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x106F874", Offset = "0x106F874", VA = "0x106F874")]
		public InfoBlock()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class MultiTapButton : Button
	{
		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _lastTap;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _tapCount;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public int RequiredTapCount;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public float ResetTime;

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x106F87C", Offset = "0x106F87C", VA = "0x106F87C", Slot = "41")]
		public override void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x106F8F0", Offset = "0x106F8F0", VA = "0x106F8F0")]
		public MultiTapButton()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public delegate void PinEntryControlCallback(IList<int> result, bool didCancel);
	[Token(Token = "0x200009E")]
	public class PinEntryControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000197")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABD8", Offset = "0xB6ABD8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int number;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public PinEntryControl <>4__this;

			[Token(Token = "0x6000BD2")]
			[Address(RVA = "0x106FDC8", Offset = "0x106FDC8", VA = "0x106FDC8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x6000BD3")]
			[Address(RVA = "0x1070700", Offset = "0x1070700", VA = "0x1070700")]
			internal void <Awake>b__0()
			{
			}
		}

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _isVisible;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<int> _numbers;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B9E4", Offset = "0xB6B9E4")]
		public Image Background;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool CanCancel;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6B9F4", Offset = "0xB6B9F4")]
		public Button CancelButton;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA04", Offset = "0xB6BA04")]
		public Text CancelButtonText;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA14", Offset = "0xB6BA14")]
		public CanvasGroup CanvasGroup;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA24", Offset = "0xB6BA24")]
		public Animator DotAnimator;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Button[] NumberButtons;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Toggle[] NumberDots;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA34", Offset = "0xB6BA34")]
		public Text PromptText;

		[Token(Token = "0x14000005")]
		public event PinEntryControlCallback Complete
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x1064DF0", Offset = "0x1064DF0", VA = "0x1064DF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EA10", Offset = "0xB6EA10")]
			add
			{
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x106FBB0", Offset = "0x106FBB0", VA = "0x106FBB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EA20", Offset = "0xB6EA20")]
			remove
			{
			}
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x106FC54", Offset = "0x106FC54", VA = "0x106FC54", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x106FEE0", Offset = "0x106FEE0", VA = "0x106FEE0", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1064C48", Offset = "0x1064C48", VA = "0x1064C48")]
		public void Show()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1064D78", Offset = "0x1064D78", VA = "0x1064D78")]
		public void Hide()
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1064BE8", Offset = "0x1064BE8", VA = "0x1064BE8")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1064F58", Offset = "0x1064F58", VA = "0x1064F58")]
		public void PlayInvalidCodeAnimation()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1070114", Offset = "0x1070114", VA = "0x1070114")]
		protected void OnComplete()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x107058C", Offset = "0x107058C", VA = "0x107058C")]
		protected void OnCancel()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1070600", Offset = "0x1070600", VA = "0x1070600")]
		private void CancelButtonPressed()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1070034", Offset = "0x1070034", VA = "0x1070034")]
		public void PushNumber(int number)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x106FDD0", Offset = "0x106FDD0", VA = "0x106FDD0")]
		private void RefreshState()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1070678", Offset = "0x1070678", VA = "0x1070678")]
		public PinEntryControl()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class ProfilerMemoryBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x2000198")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABE8", Offset = "0xB6ABE8")]
		private sealed class <CleanUp>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ProfilerMemoryBlock <>4__this;

			[Token(Token = "0x17000252")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BD7")]
				[Address(RVA = "0x107285C", Offset = "0x107285C", VA = "0x107285C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000253")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BD9")]
				[Address(RVA = "0x10728C8", Offset = "0x10728C8", VA = "0x10728C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BD4")]
			[Address(RVA = "0x1072740", Offset = "0x1072740", VA = "0x1072740")]
			[DebuggerHidden]
			public <CleanUp>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x1072774", Offset = "0x1072774", VA = "0x1072774", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x1072778", Offset = "0x1072778", VA = "0x1072778", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BD8")]
			[Address(RVA = "0x1072864", Offset = "0x1072864", VA = "0x1072864", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _lastRefresh;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA54", Offset = "0xB6BA54")]
		public Text CurrentUsedText;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA64", Offset = "0xB6BA64")]
		public Slider Slider;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA74", Offset = "0xB6BA74")]
		public Text TotalAllocatedText;

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1072370", Offset = "0x1072370", VA = "0x1072370", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x10725A0", Offset = "0x10725A0", VA = "0x10725A0", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1072398", Offset = "0x1072398", VA = "0x1072398")]
		public void TriggerRefresh()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x10726A0", Offset = "0x10726A0", VA = "0x10726A0")]
		public void TriggerCleanup()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x10726CC", Offset = "0x10726CC", VA = "0x10726CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6EA30", Offset = "0xB6EA30")]
		private IEnumerator CleanUp()
		{
			return null;
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x107276C", Offset = "0x107276C", VA = "0x107276C")]
		public ProfilerMemoryBlock()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class ProfilerMonoBlock : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _lastRefresh;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA84", Offset = "0xB6BA84")]
		public Text CurrentUsedText;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BA94", Offset = "0xB6BA94")]
		public GameObject NotSupportedMessage;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAA4", Offset = "0xB6BAA4")]
		public Slider Slider;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAB4", Offset = "0xB6BAB4")]
		public Text TotalAllocatedText;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _isSupported;

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x10728D0", Offset = "0x10728D0", VA = "0x10728D0", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1072B98", Offset = "0x1072B98", VA = "0x1072B98", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1072950", Offset = "0x1072950", VA = "0x1072950")]
		public void TriggerRefresh()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1072C98", Offset = "0x1072C98", VA = "0x1072C98")]
		public void TriggerCollection()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1072D04", Offset = "0x1072D04", VA = "0x1072D04")]
		public ProfilerMonoBlock()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class ProfilerEnableControl : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _previousState;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAC4", Offset = "0xB6BAC4")]
		public Text ButtonText;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAD4", Offset = "0xB6BAD4")]
		public Button EnableButton;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAE4", Offset = "0xB6BAE4")]
		public Text Text;

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x10707D0", Offset = "0x10707D0", VA = "0x10707D0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x107091C", Offset = "0x107091C", VA = "0x107091C")]
		protected void UpdateLabels()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1070A58", Offset = "0x1070A58", VA = "0x1070A58", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1070AA8", Offset = "0x1070AA8", VA = "0x1070AA8")]
		public void ToggleProfiler()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1070B2C", Offset = "0x1070B2C", VA = "0x1070B2C")]
		public ProfilerEnableControl()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69494", Offset = "0xB69494")]
	public class ProfilerGraphAxisLabel : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _prevFrameTime;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float? _queuedFrameTime;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _yPosition;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BAF4", Offset = "0xB6BAF4")]
		public Text Text;

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1070B34", Offset = "0x1070B34", VA = "0x1070B34", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1070DE0", Offset = "0x1070DE0", VA = "0x1070DE0")]
		public void SetValue(float frameTime, float yPosition)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1070BA8", Offset = "0x1070BA8", VA = "0x1070BA8")]
		private void SetValueInternal(float frameTime)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1070E78", Offset = "0x1070E78", VA = "0x1070E78")]
		public ProfilerGraphAxisLabel()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB694F8", Offset = "0xB694F8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB694F8", Offset = "0xB694F8")]
	public class ProfilerGraphControl : Graphic
	{
		[Token(Token = "0x2000199")]
		public enum VerticalAlignments
		{
			[Token(Token = "0x400076C")]
			Top,
			[Token(Token = "0x400076D")]
			Bottom
		}

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public VerticalAlignments VerticalAlignment;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] ScaleSteps;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool FloatingScale;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool TargetFpsUseApplication;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		public bool DrawAxes;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int TargetFps;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool Clip;

		[Token(Token = "0x40002E9")]
		public const float DataPointMargin = 2f;

		[Token(Token = "0x40002EA")]
		public const float DataPointVerticalMargin = 2f;

		[Token(Token = "0x40002EB")]
		public const float DataPointWidth = 4f;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int VerticalPadding;

		[Token(Token = "0x40002ED")]
		public const int LineCount = 3;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color[] LineColours;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IProfilerService _profilerService;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private ProfilerGraphAxisLabel[] _axisLabels;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Rect _clipBounds;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<Vector3> _meshVertices;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<Color32> _meshVertexColors;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _meshTriangles;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1070E80", Offset = "0x1070E80", VA = "0x1070E80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1070F00", Offset = "0x1070F00", VA = "0x1070F00", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1070F08", Offset = "0x1070F08", VA = "0x1070F08")]
		protected void Update()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1070F18", Offset = "0x1070F18", VA = "0x1070F18", Slot = "43")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB6EA94", Offset = "0xB6EA94")]
		protected override void OnPopulateMesh(Mesh m)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1071748", Offset = "0x1071748", VA = "0x1071748")]
		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1071BC8", Offset = "0x1071BC8", VA = "0x1071BC8")]
		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1071E2C", Offset = "0x1071E2C", VA = "0x1071E2C")]
		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, Color c)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x107166C", Offset = "0x107166C", VA = "0x107166C")]
		protected ProfilerFrame GetFrame(int i)
		{
			return default(ProfilerFrame);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x10714F0", Offset = "0x10714F0", VA = "0x10714F0")]
		protected int CalculateVisibleDataPointCount()
		{
			return default(int);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x10715A8", Offset = "0x10715A8", VA = "0x10715A8")]
		protected int GetFrameBufferCurrentSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1072110", Offset = "0x1072110", VA = "0x1072110")]
		protected int GetFrameBufferMaxSize()
		{
			return default(int);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1071414", Offset = "0x1071414", VA = "0x1071414")]
		protected float CalculateMaxFrameTime()
		{
			return default(float);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1071AD8", Offset = "0x1071AD8", VA = "0x1071AD8")]
		private ProfilerGraphAxisLabel GetAxisLabel(int index)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x10721DC", Offset = "0x10721DC", VA = "0x10721DC")]
		public ProfilerGraphControl()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class SRTabButton : SRMonoBehaviourEx
	{
		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB04", Offset = "0xB6BB04")]
		public Behaviour ActiveToggle;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB14", Offset = "0xB6BB14")]
		public Button Button;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB24", Offset = "0xB6BB24")]
		public RectTransform ExtraContentContainer;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB34", Offset = "0xB6BB34")]
		public StyleComponent IconStyleComponent;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB44", Offset = "0xB6BB44")]
		public Text TitleText;

		[Token(Token = "0x1700009C")]
		public bool IsActive
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1072D0C", Offset = "0x1072D0C", VA = "0x1072D0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1072D28", Offset = "0x1072D28", VA = "0x1072D28")]
			set
			{
			}
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1072D48", Offset = "0x1072D48", VA = "0x1072D48")]
		public SRTabButton()
		{
		}
	}
}
namespace SRDebugger.UI.Controls.Data
{
	[Token(Token = "0x20000A5")]
	public class ActionControl : OptionsControlBase
	{
		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MethodReference _method;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB54", Offset = "0xB6BB54")]
		public Button Button;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB64", Offset = "0xB6BB64")]
		public Text Title;

		[Token(Token = "0x1700009D")]
		public MethodReference Method
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x106D7C4", Offset = "0x106D7C4", VA = "0x106D7C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x106D7CC", Offset = "0x106D7CC", VA = "0x106D7CC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x106D870", Offset = "0x106D870", VA = "0x106D870")]
		private void ButtonOnClick()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x106D9B8", Offset = "0x106D9B8", VA = "0x106D9B8")]
		public void SetMethod(string methodName, MethodReference method)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x106D9E4", Offset = "0x106D9E4", VA = "0x106D9E4")]
		public ActionControl()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class BoolControl : DataBoundControl
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB74", Offset = "0xB6BB74")]
		public Text Title;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB84", Offset = "0xB6BB84")]
		public Toggle Toggle;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x106D9F4", Offset = "0x106D9F4", VA = "0x106D9F4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x106DAFC", Offset = "0x106DAFC", VA = "0x106DAFC")]
		private void ToggleOnValueChanged(bool isOn)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x106DBBC", Offset = "0x106DBBC", VA = "0x106DBBC", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x106DC10", Offset = "0x106DC10", VA = "0x106DC10", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x106DCA8", Offset = "0x106DCA8", VA = "0x106DCA8", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x106DD2C", Offset = "0x106DD2C", VA = "0x106DD2C")]
		public BoolControl()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class EnumControl : DataBoundControl
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private object _lastValue;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string[] _names;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Array _values;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BB94", Offset = "0xB6BB94")]
		public LayoutElement ContentLayoutElement;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GameObject[] DisableOnReadOnly;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBA4", Offset = "0xB6BBA4")]
		public SRSpinner Spinner;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBB4", Offset = "0xB6BBB4")]
		public Text Title;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBC4", Offset = "0xB6BBC4")]
		public Text Value;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x106DD3C", Offset = "0x106DD3C", VA = "0x106DD3C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x106DD78", Offset = "0x106DD78", VA = "0x106DD78", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x106DFB8", Offset = "0x106DFB8", VA = "0x106DFB8", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x106E010", Offset = "0x106E010", VA = "0x106E010", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x106E03C", Offset = "0x106E03C", VA = "0x106E03C")]
		private void SetIndex(int i)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x106E084", Offset = "0x106E084", VA = "0x106E084")]
		public void GoToNext()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x106E0E4", Offset = "0x106E0E4", VA = "0x106E0E4")]
		public void GoToPrevious()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x106E144", Offset = "0x106E144", VA = "0x106E144")]
		public EnumControl()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class NumberControl : DataBoundControl
	{
		[Token(Token = "0x200019A")]
		public struct ValueRange
		{
			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double MaxValue;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public double MinValue;
		}

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Type[] IntegerTypes;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Type[] DecimalTypes;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<Type, ValueRange> ValueRanges;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string _lastValue;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Type _type;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject[] DisableOnReadOnly;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public SRNumberButton DownNumberButton;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBD4", Offset = "0xB6BBD4")]
		public SRNumberSpinner NumberSpinner;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBE4", Offset = "0xB6BBE4")]
		public Text Title;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SRNumberButton UpNumberButton;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x106E14C", Offset = "0x106E14C", VA = "0x106E14C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x106E218", Offset = "0x106E218", VA = "0x106E218")]
		private void OnValueChanged(string newValue)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x106E338", Offset = "0x106E338", VA = "0x106E338", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x106EB3C", Offset = "0x106EB3C", VA = "0x106EB3C", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x106EC00", Offset = "0x106EC00", VA = "0x106EC00", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x106E654", Offset = "0x106E654", VA = "0x106E654")]
		protected static bool IsIntegerType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x106E778", Offset = "0x106E778", VA = "0x106E778")]
		protected static bool IsDecimalType(Type t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x106E89C", Offset = "0x106E89C", VA = "0x106E89C")]
		protected double GetMaxValue(Type t)
		{
			return default(double);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x106E9EC", Offset = "0x106E9EC", VA = "0x106E9EC")]
		protected double GetMinValue(Type t)
		{
			return default(double);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x106EC98", Offset = "0x106EC98", VA = "0x106EC98")]
		public NumberControl()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class ReadOnlyControl : DataBoundControl
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BBF4", Offset = "0xB6BBF4")]
		public Text ValueText;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BC04", Offset = "0xB6BC04")]
		public Text Title;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x106F128", Offset = "0x106F128", VA = "0x106F128", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x106F164", Offset = "0x106F164", VA = "0x106F164", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x106F188", Offset = "0x106F188", VA = "0x106F188", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x106F224", Offset = "0x106F224", VA = "0x106F224", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x106F2C0", Offset = "0x106F2C0", VA = "0x106F2C0")]
		public ReadOnlyControl()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class StringControl : DataBoundControl
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BC14", Offset = "0xB6BC14")]
		public InputField InputField;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RequiredFieldAttribute", RVA = "0xB6BC24", Offset = "0xB6BC24")]
		public Text Title;

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x106F2C8", Offset = "0x106F2C8", VA = "0x106F2C8", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x106F394", Offset = "0x106F394", VA = "0x106F394")]
		private void OnValueChanged(string newValue)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x106F398", Offset = "0x106F398", VA = "0x106F398", Slot = "12")]
		protected override void OnBind(string propertyName, Type t)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x106F438", Offset = "0x106F438", VA = "0x106F438", Slot = "13")]
		protected override void OnValueUpdated(object newValue)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x106F4C8", Offset = "0x106F4C8", VA = "0x106F4C8", Slot = "14")]
		public override bool CanBind(Type type, bool isReadOnly)
		{
			return default(bool);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x106F564", Offset = "0x106F564", VA = "0x106F564")]
		public StringControl()
		{
		}
	}
}
namespace SRDebugger.Services
{
	[Token(Token = "0x20000AB")]
	public class BugReport
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<ConsoleEntry> ConsoleLog;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Email;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte[] ScreenshotData;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, Dictionary<string, object>> SystemInformation;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string UserDescription;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x114D61C", Offset = "0x114D61C", VA = "0x114D61C")]
		public BugReport()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public delegate void BugReportCompleteCallback(bool didSucceed, string errorMessage);
	[Token(Token = "0x20000AD")]
	public delegate void BugReportProgressCallback(float progress);
	[Token(Token = "0x20000AE")]
	public interface IBugReportService
	{
		[Token(Token = "0x600051C")]
		void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, [Optional] BugReportProgressCallback progressCallback);
	}
	[Token(Token = "0x20000AF")]
	public delegate void ConsoleUpdatedEventHandler(IConsoleService console);
	[Token(Token = "0x20000B0")]
	public interface IConsoleService
	{
		[Token(Token = "0x1700009E")]
		int ErrorCount
		{
			[Token(Token = "0x6000521")]
			get;
		}

		[Token(Token = "0x1700009F")]
		int WarningCount
		{
			[Token(Token = "0x6000522")]
			get;
		}

		[Token(Token = "0x170000A0")]
		int InfoCount
		{
			[Token(Token = "0x6000523")]
			get;
		}

		[Token(Token = "0x170000A1")]
		IReadOnlyList<ConsoleEntry> Entries
		{
			[Token(Token = "0x6000524")]
			get;
		}

		[Token(Token = "0x170000A2")]
		IReadOnlyList<ConsoleEntry> AllEntries
		{
			[Token(Token = "0x6000525")]
			get;
		}

		[Token(Token = "0x14000006")]
		event ConsoleUpdatedEventHandler Updated;

		[Token(Token = "0x6000528")]
		void Clear();
	}
	[Token(Token = "0x20000B1")]
	public class ConsoleEntry
	{
		[Token(Token = "0x400031A")]
		private const int MessagePreviewLength = 180;

		[Token(Token = "0x400031B")]
		private const int StackTracePreviewLength = 120;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string _messagePreview;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _stackTracePreview;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int Count;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public LogType LogType;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Message;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string StackTrace;

		[Token(Token = "0x170000A3")]
		public string MessagePreview
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x105F71C", Offset = "0x105F71C", VA = "0x105F71C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public string StackTracePreview
		{
			[Token(Token = "0x600052C")]
			[Address(RVA = "0x105F850", Offset = "0x105F850", VA = "0x105F850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x105F6B0", Offset = "0x105F6B0", VA = "0x105F6B0")]
		public ConsoleEntry()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x105F6C0", Offset = "0x105F6C0", VA = "0x105F6C0")]
		public ConsoleEntry(ConsoleEntry other)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x105F984", Offset = "0x105F984", VA = "0x105F984")]
		public bool Matches(ConsoleEntry other)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B2")]
	public interface IDebugCameraService
	{
		[Token(Token = "0x170000A5")]
		Camera Camera
		{
			[Token(Token = "0x600052E")]
			get;
		}
	}
	[Token(Token = "0x20000B3")]
	public interface IDebugPanelService
	{
		[Token(Token = "0x170000A6")]
		bool IsLoaded
		{
			[Token(Token = "0x600052F")]
			get;
		}

		[Token(Token = "0x170000A7")]
		bool IsVisible
		{
			[Token(Token = "0x6000530")]
			get;
			[Token(Token = "0x6000531")]
			set;
		}

		[Token(Token = "0x170000A8")]
		DefaultTabs? ActiveTab
		{
			[Token(Token = "0x6000532")]
			get;
		}

		[Token(Token = "0x14000007")]
		event Action<IDebugPanelService, bool> VisibilityChanged;

		[Token(Token = "0x6000535")]
		void Unload();

		[Token(Token = "0x6000536")]
		void OpenTab(DefaultTabs tab);
	}
	[Token(Token = "0x20000B4")]
	public interface IDebugService
	{
		[Token(Token = "0x170000A9")]
		Settings Settings
		{
			[Token(Token = "0x6000537")]
			get;
		}

		[Token(Token = "0x170000AA")]
		bool IsDebugPanelVisible
		{
			[Token(Token = "0x6000538")]
			get;
		}

		[Token(Token = "0x170000AB")]
		bool IsTriggerEnabled
		{
			[Token(Token = "0x6000539")]
			get;
			[Token(Token = "0x600053A")]
			set;
		}

		[Token(Token = "0x170000AC")]
		IDockConsoleService DockConsole
		{
			[Token(Token = "0x600053B")]
			get;
		}

		[Token(Token = "0x170000AD")]
		bool IsProfilerDocked
		{
			[Token(Token = "0x600053C")]
			get;
			[Token(Token = "0x600053D")]
			set;
		}

		[Token(Token = "0x14000008")]
		event VisibilityChangedDelegate PanelVisibilityChanged;

		[Token(Token = "0x600053E")]
		void AddSystemInfo(InfoEntry entry, string category = "Default");

		[Token(Token = "0x600053F")]
		void ShowDebugPanel(bool requireEntryCode = true);

		[Token(Token = "0x6000540")]
		void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true);

		[Token(Token = "0x6000541")]
		void HideDebugPanel();

		[Token(Token = "0x6000542")]
		void DestroyDebugPanel();

		[Token(Token = "0x6000543")]
		void AddOptionContainer(object container);

		[Token(Token = "0x6000544")]
		void RemoveOptionContainer(object container);

		[Token(Token = "0x6000545")]
		void PinAllOptions(string category);

		[Token(Token = "0x6000546")]
		void UnpinAllOptions(string category);

		[Token(Token = "0x6000547")]
		void PinOption(string name);

		[Token(Token = "0x6000548")]
		void UnpinOption(string name);

		[Token(Token = "0x6000549")]
		void ClearPinnedOptions();

		[Token(Token = "0x600054A")]
		void ShowBugReportSheet([Optional] ActionCompleteCallback onComplete, bool takeScreenshot = true, [Optional] string descriptionContent);

		[Token(Token = "0x600054D")]
		RectTransform EnableWorldSpaceMode();
	}
	[Token(Token = "0x20000B5")]
	public interface IDebugTriggerService
	{
		[Token(Token = "0x170000AE")]
		bool IsEnabled
		{
			[Token(Token = "0x600054E")]
			get;
			[Token(Token = "0x600054F")]
			set;
		}

		[Token(Token = "0x170000AF")]
		PinAlignment Position
		{
			[Token(Token = "0x6000550")]
			get;
			[Token(Token = "0x6000551")]
			set;
		}
	}
	[Token(Token = "0x20000B6")]
	public interface IDockConsoleService
	{
		[Token(Token = "0x170000B0")]
		bool IsVisible
		{
			[Token(Token = "0x6000552")]
			get;
			[Token(Token = "0x6000553")]
			set;
		}

		[Token(Token = "0x170000B1")]
		bool IsExpanded
		{
			[Token(Token = "0x6000554")]
			get;
			[Token(Token = "0x6000555")]
			set;
		}

		[Token(Token = "0x170000B2")]
		ConsoleAlignment Alignment
		{
			[Token(Token = "0x6000556")]
			get;
			[Token(Token = "0x6000557")]
			set;
		}
	}
	[Token(Token = "0x20000B7")]
	public interface IOptionsService
	{
		[Token(Token = "0x170000B3")]
		ICollection<OptionDefinition> Options
		{
			[Token(Token = "0x600055C")]
			get;
		}

		[Token(Token = "0x14000009")]
		event EventHandler OptionsUpdated;

		[Token(Token = "0x1400000A")]
		event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated;

		[Token(Token = "0x600055D")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB6EB44", Offset = "0xB6EB44")]
		void Scan(object obj);

		[Token(Token = "0x600055E")]
		void AddContainer(object obj);

		[Token(Token = "0x600055F")]
		void RemoveContainer(object obj);
	}
	[Token(Token = "0x20000B8")]
	public delegate void PinEntryCompleteCallback(bool validPinEntered);
	[Token(Token = "0x20000B9")]
	public interface IPinEntryService
	{
		[Token(Token = "0x170000B4")]
		bool IsShowingKeypad
		{
			[Token(Token = "0x6000564")]
			get;
		}

		[Token(Token = "0x6000565")]
		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true);

		[Token(Token = "0x6000566")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB6EB7C", Offset = "0xB6EB7C")]
		void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel);
	}
	[Token(Token = "0x20000BA")]
	public interface IPinnedUIService
	{
		[Token(Token = "0x170000B5")]
		bool IsProfilerPinned
		{
			[Token(Token = "0x6000569")]
			get;
			[Token(Token = "0x600056A")]
			set;
		}

		[Token(Token = "0x1400000B")]
		event Action<OptionDefinition, bool> OptionPinStateChanged;

		[Token(Token = "0x600056B")]
		void Pin(OptionDefinition option, int order = -1);

		[Token(Token = "0x600056C")]
		void Unpin(OptionDefinition option);

		[Token(Token = "0x600056D")]
		void UnpinAll();

		[Token(Token = "0x600056E")]
		bool HasPinned(OptionDefinition option);
	}
	[Token(Token = "0x20000BB")]
	public struct ProfilerFrame
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double FrameTime;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double OtherTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double RenderTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double UpdateTime;
	}
	[Token(Token = "0x20000BC")]
	public interface IProfilerService
	{
		[Token(Token = "0x170000B6")]
		float AverageFrameTime
		{
			[Token(Token = "0x600056F")]
			get;
		}

		[Token(Token = "0x170000B7")]
		float LastFrameTime
		{
			[Token(Token = "0x6000570")]
			get;
		}

		[Token(Token = "0x170000B8")]
		CircularBuffer<ProfilerFrame> FrameBuffer
		{
			[Token(Token = "0x6000571")]
			get;
		}
	}
	[Token(Token = "0x20000BD")]
	public interface ISystemInformationService
	{
		[Token(Token = "0x6000572")]
		IEnumerable<string> GetCategories();

		[Token(Token = "0x6000573")]
		IList<InfoEntry> GetInfo(string category);

		[Token(Token = "0x6000574")]
		void Add(InfoEntry info, string category = "Default");

		[Token(Token = "0x6000575")]
		Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false);
	}
}
namespace SRDebugger.Services.Implementation
{
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69594", Offset = "0xB69594")]
	public class BugReportApiService : SRServiceBase<IBugReportService>, IBugReportService
	{
		[Token(Token = "0x4000326")]
		public const float Timeout = 12f;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BugReportCompleteCallback _completeCallback;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string _errorMessage;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _isBusy;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _previousProgress;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BugReportProgressCallback _progressCallback;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BugReportApi _reportApi;

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x105FDEC", Offset = "0x105FDEC", VA = "0x105FDEC", Slot = "11")]
		public void SendBugReport(BugReport report, BugReportCompleteCallback completeHandler, [Optional] BugReportProgressCallback progressCallback)
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x106004C", Offset = "0x106004C", VA = "0x106004C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1060100", Offset = "0x1060100", VA = "0x1060100")]
		private void OnProgress(float progress)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1060110", Offset = "0x1060110", VA = "0x1060110")]
		private void OnComplete()
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x10601A4", Offset = "0x10601A4", VA = "0x10601A4", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x106024C", Offset = "0x106024C", VA = "0x106024C")]
		public BugReportApiService()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB695F8", Offset = "0xB695F8")]
	public class BugReportPopoverService : SRServiceBase<BugReportPopoverService>
	{
		[Token(Token = "0x200019B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ABF8", Offset = "0xB6ABF8")]
		private sealed class <OpenCo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool takeScreenshot;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public BugReportPopoverService <>4__this;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string descriptionText;

			[Token(Token = "0x17000254")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BDD")]
				[Address(RVA = "0x1060D4C", Offset = "0x1060D4C", VA = "0x1060D4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000255")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BDF")]
				[Address(RVA = "0x1060DB8", Offset = "0x1060DB8", VA = "0x1060DB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x10607C8", Offset = "0x10607C8", VA = "0x10607C8")]
			[DebuggerHidden]
			public <OpenCo>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x1060C04", Offset = "0x1060C04", VA = "0x1060C04", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x1060C08", Offset = "0x1060C08", VA = "0x1060C08", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x1060D54", Offset = "0x1060D54", VA = "0x1060D54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BugReportCompleteCallback _callback;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isVisible;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BugReportPopoverRoot _popover;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BugReportSheetController _sheet;

		[Token(Token = "0x170000B9")]
		public bool IsShowingPopover
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x106029C", Offset = "0x106029C", VA = "0x106029C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x10602A4", Offset = "0x10602A4", VA = "0x10602A4")]
		public void ShowBugReporter(BugReportCompleteCallback callback, bool takeScreenshotFirst = true, [Optional] string descriptionText)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x106073C", Offset = "0x106073C", VA = "0x106073C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6EBD4", Offset = "0xB6EBD4")]
		private IEnumerator OpenCo(bool takeScreenshot, string descriptionText)
		{
			return null;
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x10607F4", Offset = "0x10607F4", VA = "0x10607F4")]
		private void SubmitComplete(bool didSucceed, string errorMessage)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1060960", Offset = "0x1060960", VA = "0x1060960")]
		private void CancelPressed()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1060800", Offset = "0x1060800", VA = "0x1060800")]
		private void OnComplete(bool success, string errorMessage, bool close)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x10609B8", Offset = "0x10609B8", VA = "0x10609B8")]
		private void TakingScreenshot()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1060A5C", Offset = "0x1060A5C", VA = "0x1060A5C")]
		private void ScreenshotComplete()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1060B00", Offset = "0x1060B00", VA = "0x1060B00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1060454", Offset = "0x1060454", VA = "0x1060454")]
		private void Load()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1060BB4", Offset = "0x1060BB4", VA = "0x1060BB4")]
		public BugReportPopoverService()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB6965C", Offset = "0xB6965C")]
	public class DebugCameraServiceImpl : IDebugCameraService
	{
		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Camera _debugCamera;

		[Token(Token = "0x170000BA")]
		public Camera Camera
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1060F34", Offset = "0x1060F34", VA = "0x1060F34", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1060DC0", Offset = "0x1060DC0", VA = "0x1060DC0")]
		public DebugCameraServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB696C0", Offset = "0xB696C0")]
	public class DebugPanelServiceImpl : ScriptableObject, IDebugPanelService
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DebugPanelRoot _debugPanelRootObject;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isVisible;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool? _cursorWasVisible;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private CursorLockMode? _cursorLockMode;

		[Token(Token = "0x170000BB")]
		public DebugPanelRoot RootObject
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1061084", Offset = "0x1061084", VA = "0x1061084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public bool IsLoaded
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x106108C", Offset = "0x106108C", VA = "0x106108C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public bool IsVisible
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x10610FC", Offset = "0x10610FC", VA = "0x10610FC", Slot = "5")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1061134", Offset = "0x1061134", VA = "0x1061134", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public DefaultTabs? ActiveTab
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1061520", Offset = "0x1061520", VA = "0x1061520", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000C")]
		public event Action<IDebugPanelService, bool> VisibilityChanged
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1060F3C", Offset = "0x1060F3C", VA = "0x1060F3C", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC38", Offset = "0xB6EC38")]
			add
			{
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1060FE0", Offset = "0x1060FE0", VA = "0x1060FE0", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC48", Offset = "0xB6EC48")]
			remove
			{
			}
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x10615C4", Offset = "0x10615C4", VA = "0x10615C4", Slot = "11")]
		public void OpenTab(DefaultTabs tab)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1061620", Offset = "0x1061620", VA = "0x1061620", Slot = "10")]
		public void Unload()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1061374", Offset = "0x1061374", VA = "0x1061374")]
		private void Load()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1061710", Offset = "0x1061710", VA = "0x1061710")]
		public DebugPanelServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69724", Offset = "0xB69724")]
	public class DebugTriggerImpl : SRServiceBase<IDebugTriggerService>, IDebugTriggerService
	{
		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PinAlignment _position;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TriggerRoot _trigger;

		[Token(Token = "0x170000BF")]
		public bool IsEnabled
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1061718", Offset = "0x1061718", VA = "0x1061718", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x10617BC", Offset = "0x10617BC", VA = "0x10617BC", Slot = "12")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public PinAlignment Position
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1061BA0", Offset = "0x1061BA0", VA = "0x1061BA0", Slot = "13")]
			get
			{
				return default(PinAlignment);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1061BA8", Offset = "0x1061BA8", VA = "0x1061BA8", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1061D48", Offset = "0x1061D48", VA = "0x1061D48", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x10618B4", Offset = "0x10618B4", VA = "0x10618B4")]
		private void CreateTrigger()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1061E58", Offset = "0x1061E58", VA = "0x1061E58", Slot = "10")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1061EE8", Offset = "0x1061EE8", VA = "0x1061EE8")]
		private static void OnActiveSceneChanged(Scene s1, Scene s2)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1061EF0", Offset = "0x1061EF0", VA = "0x1061EF0")]
		private void OnTriggerButtonClick()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1061C4C", Offset = "0x1061C4C", VA = "0x1061C4C")]
		private static void SetTriggerPosition(RectTransform t, PinAlignment position)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1061FAC", Offset = "0x1061FAC", VA = "0x1061FAC")]
		public DebugTriggerImpl()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69788", Offset = "0xB69788")]
	public class DockConsoleServiceImpl : IDockConsoleService
	{
		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private ConsoleAlignment _alignment;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DockConsoleController _consoleRoot;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _didSuspendTrigger;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool _isExpanded;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _isVisible;

		[Token(Token = "0x170000C1")]
		public bool IsVisible
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x106203C", Offset = "0x106203C", VA = "0x106203C", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1062044", Offset = "0x1062044", VA = "0x1062044", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public bool IsExpanded
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1062588", Offset = "0x1062588", VA = "0x1062588", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1062590", Offset = "0x1062590", VA = "0x1062590", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public ConsoleAlignment Alignment
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1062744", Offset = "0x1062744", VA = "0x1062744", Slot = "8")]
			get
			{
				return default(ConsoleAlignment);
			}
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x106274C", Offset = "0x106274C", VA = "0x106274C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1061FFC", Offset = "0x1061FFC", VA = "0x1061FFC")]
		public DockConsoleServiceImpl()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x106212C", Offset = "0x106212C", VA = "0x106212C")]
		private void Load()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x10622C0", Offset = "0x10622C0", VA = "0x10622C0")]
		private void CheckTrigger()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB697EC", Offset = "0xB697EC")]
	public class KeyboardShortcutListenerService : SRServiceBase<KeyboardShortcutListenerService>
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Settings.KeyboardShortcut> _shortcuts;

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1062AEC", Offset = "0x1062AEC", VA = "0x1062AEC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1062BE4", Offset = "0x1062BE4", VA = "0x1062BE4")]
		private void ToggleTab(DefaultTabs t)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1062E60", Offset = "0x1062E60", VA = "0x1062E60")]
		private void ExecuteShortcut(Settings.KeyboardShortcut shortcut)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x10634C8", Offset = "0x10634C8", VA = "0x10634C8", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x106376C", Offset = "0x106376C", VA = "0x106376C")]
		public KeyboardShortcutListenerService()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69850", Offset = "0xB69850")]
	public class OptionsServiceImpl : IOptionsService
	{
		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<OptionDefinition> _options;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IList<OptionDefinition> _optionsReadonly;

		[Token(Token = "0x170000C4")]
		public ICollection<OptionDefinition> Options
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1063A4C", Offset = "0x1063A4C", VA = "0x1063A4C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1400000D")]
		public event EventHandler OptionsUpdated
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x10637BC", Offset = "0x10637BC", VA = "0x10637BC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC58", Offset = "0xB6EC58")]
			add
			{
			}
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1063860", Offset = "0x1063860", VA = "0x1063860", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC68", Offset = "0xB6EC68")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1063904", Offset = "0x1063904", VA = "0x1063904", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC78", Offset = "0xB6EC78")]
			add
			{
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x10639A8", Offset = "0x10639A8", VA = "0x10639A8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EC88", Offset = "0xB6EC88")]
			remove
			{
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1063A54", Offset = "0x1063A54", VA = "0x1063A54")]
		public OptionsServiceImpl()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1063C20", Offset = "0x1063C20", VA = "0x1063C20", Slot = "9")]
		public void Scan(object obj)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1063C24", Offset = "0x1063C24", VA = "0x1063C24", Slot = "10")]
		public void AddContainer(object obj)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1063EF8", Offset = "0x1063EF8", VA = "0x1063EF8", Slot = "11")]
		public void RemoveContainer(object obj)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x10642B8", Offset = "0x10642B8", VA = "0x10642B8")]
		private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1064330", Offset = "0x1064330", VA = "0x1064330")]
		private void OnSROptionsPropertyChanged(object sender, string propertyName)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1063E60", Offset = "0x1063E60", VA = "0x1063E60")]
		private void OnOptionsUpdated()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB698B4", Offset = "0xB698B4")]
	public class PinEntryServiceImpl : SRServiceBase<IPinEntryService>, IPinEntryService
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private PinEntryCompleteCallback _callback;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _isVisible;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PinEntryControl _pinControl;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<int> _requiredPin;

		[Token(Token = "0x170000C5")]
		public bool IsShowingKeypad
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x10643A4", Offset = "0x10643A4", VA = "0x10643A4", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x10643AC", Offset = "0x10643AC", VA = "0x10643AC", Slot = "12")]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool allowCancel = true)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1064CBC", Offset = "0x1064CBC", VA = "0x1064CBC", Slot = "13")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB6EC98", Offset = "0xB6EC98")]
		public void ShowPinEntry(IList<int> requiredPin, string message, PinEntryCompleteCallback callback, bool blockInput, bool allowCancel)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1064CC4", Offset = "0x1064CC4", VA = "0x1064CC4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1064830", Offset = "0x1064830", VA = "0x1064830")]
		private void Load()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1064E94", Offset = "0x1064E94", VA = "0x1064E94")]
		private void PinControlOnComplete(IList<int> result, bool didCancel)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x10645C4", Offset = "0x10645C4", VA = "0x10645C4")]
		private void VerifyPin(IList<int> pin)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1064FB4", Offset = "0x1064FB4", VA = "0x1064FB4")]
		public PinEntryServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69918", Offset = "0xB69918")]
	public class PinnedUIServiceImpl : SRServiceBase<IPinnedUIService>, IPinnedUIService
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<OptionsControlBase> _controlList;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<OptionDefinition, OptionsControlBase> _pinnedObjects;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool _queueRefresh;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PinnedUIRoot _uiRoot;

		[Token(Token = "0x170000C6")]
		public DockConsoleController DockConsoleController
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x1062A24", Offset = "0x1062A24", VA = "0x1062A24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public bool IsProfilerPinned
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x10654C8", Offset = "0x10654C8", VA = "0x10654C8", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x106556C", Offset = "0x106556C", VA = "0x106556C", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event Action<OptionDefinition, bool> OptionPinStateChanged
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1065380", Offset = "0x1065380", VA = "0x1065380", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECA8", Offset = "0xB6ECA8")]
			add
			{
			}
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x1065424", Offset = "0x1065424", VA = "0x1065424", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECB8", Offset = "0xB6ECB8")]
			remove
			{
			}
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1065618", Offset = "0x1065618", VA = "0x1065618", Slot = "15")]
		public void Pin(OptionDefinition obj, int order = -1)
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1065808", Offset = "0x1065808", VA = "0x1065808", Slot = "16")]
		public void Unpin(OptionDefinition obj)
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x106578C", Offset = "0x106578C", VA = "0x106578C")]
		private void OnPinnedStateChanged(OptionDefinition option, bool isPinned)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x106593C", Offset = "0x106593C", VA = "0x106593C", Slot = "17")]
		public void UnpinAll()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1065AB0", Offset = "0x1065AB0", VA = "0x1065AB0", Slot = "18")]
		public bool HasPinned(OptionDefinition option)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1065B18", Offset = "0x1065B18", VA = "0x1065B18", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1065030", Offset = "0x1065030", VA = "0x1065030")]
		private void Load()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1065BCC", Offset = "0x1065BCC", VA = "0x1065BCC")]
		private void UpdateAnchors()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1065F9C", Offset = "0x1065F9C", VA = "0x1065F9C", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1066080", Offset = "0x1066080", VA = "0x1066080")]
		private void OnOptionsUpdated(object sender, EventArgs eventArgs)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x10662D8", Offset = "0x10662D8", VA = "0x10662D8")]
		private void OptionsOnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x10662E4", Offset = "0x10662E4", VA = "0x10662E4")]
		private void OnDebugPanelVisibilityChanged(bool isVisible)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1065FDC", Offset = "0x1065FDC", VA = "0x1065FDC")]
		private void Refresh()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x10662F4", Offset = "0x10662F4", VA = "0x10662F4")]
		public PinnedUIServiceImpl()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB6997C", Offset = "0xB6997C")]
	public class SRDebugService : IDebugService
	{
		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC08", Offset = "0xB6AC08")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ActionCompleteCallback onComplete;

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x1068510", Offset = "0x1068510", VA = "0x1068510")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x1068AF8", Offset = "0x1068AF8", VA = "0x1068AF8")]
			internal void <ShowBugReportSheet>b__0(bool succeed, string message)
			{
			}
		}

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IDebugPanelService _debugPanelService;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly IDebugTriggerService _debugTrigger;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ISystemInformationService _informationService;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly IOptionsService _optionsService;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly IPinnedUIService _pinnedUiService;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool _entryCodeEnabled;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _hasAuthorised;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private DefaultTabs? _queuedTab;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RectTransform _worldSpaceTransform;

		[Token(Token = "0x170000C8")]
		public Settings Settings
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1066858", Offset = "0x1066858", VA = "0x1066858", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C9")]
		public bool IsDebugPanelVisible
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x10668CC", Offset = "0x10668CC", VA = "0x10668CC", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public bool IsTriggerEnabled
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1066984", Offset = "0x1066984", VA = "0x1066984", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x1066A38", Offset = "0x1066A38", VA = "0x1066A38", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public bool IsProfilerDocked
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1066B00", Offset = "0x1066B00", VA = "0x1066B00", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1066BB8", Offset = "0x1066BB8", VA = "0x1066BB8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public IDockConsoleService DockConsole
		{
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1068518", Offset = "0x1068518", VA = "0x1068518", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000010")]
		public event VisibilityChangedDelegate PanelVisibilityChanged
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1068520", Offset = "0x1068520", VA = "0x1068520", Slot = "24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECC8", Offset = "0xB6ECC8")]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x10685C4", Offset = "0x10685C4", VA = "0x10685C4", Slot = "25")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECD8", Offset = "0xB6ECD8")]
			remove
			{
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1066394", Offset = "0x1066394", VA = "0x1066394")]
		public SRDebugService()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1066C78", Offset = "0x1066C78", VA = "0x1066C78", Slot = "11")]
		public void AddSystemInfo(InfoEntry entry, string category = "Default")
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1066D48", Offset = "0x1066D48", VA = "0x1066D48", Slot = "12")]
		public void ShowDebugPanel(bool requireEntryCode = true)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1066FB8", Offset = "0x1066FB8", VA = "0x1066FB8", Slot = "13")]
		public void ShowDebugPanel(DefaultTabs tab, bool requireEntryCode = true)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1067150", Offset = "0x1067150", VA = "0x1067150", Slot = "14")]
		public void HideDebugPanel()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x106720C", Offset = "0x106720C", VA = "0x106720C", Slot = "15")]
		public void DestroyDebugPanel()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x106733C", Offset = "0x106733C", VA = "0x106733C", Slot = "16")]
		public void AddOptionContainer(object container)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1067404", Offset = "0x1067404", VA = "0x1067404", Slot = "17")]
		public void RemoveOptionContainer(object container)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x10674CC", Offset = "0x10674CC", VA = "0x10674CC", Slot = "18")]
		public void PinAllOptions(string category)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x106786C", Offset = "0x106786C", VA = "0x106786C", Slot = "19")]
		public void UnpinAllOptions(string category)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1067C08", Offset = "0x1067C08", VA = "0x1067C08", Slot = "20")]
		public void PinOption(string name)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1067FA8", Offset = "0x1067FA8", VA = "0x1067FA8", Slot = "21")]
		public void UnpinOption(string name)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1068344", Offset = "0x1068344", VA = "0x1068344", Slot = "22")]
		public void ClearPinnedOptions()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x10683FC", Offset = "0x10683FC", VA = "0x10683FC", Slot = "23")]
		public void ShowBugReportSheet([Optional] ActionCompleteCallback onComplete, bool takeScreenshot = true, [Optional] string descriptionContent)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1068668", Offset = "0x1068668", VA = "0x1068668")]
		private void DebugPanelServiceOnVisibilityChanged(IDebugPanelService debugPanelService, bool b)
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1066E38", Offset = "0x1066E38", VA = "0x1066E38")]
		private void PromptEntryCode()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1068790", Offset = "0x1068790", VA = "0x1068790", Slot = "26")]
		public RectTransform EnableWorldSpaceMode()
		{
			return null;
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1068A3C", Offset = "0x1068A3C", VA = "0x1068A3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECE8", Offset = "0xB6ECE8")]
		private void <PromptEntryCode>b__39_0(bool entered)
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB699E0", Offset = "0xB699E0")]
	public class StandardConsoleService : IConsoleService
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool _collapseEnabled;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool _hasCleared;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CircularBuffer<ConsoleEntry> _consoleEntries;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly object _threadLock;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BC84", Offset = "0xB6BC84")]
		private int <ErrorCount>k__BackingField;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BC94", Offset = "0xB6BC94")]
		private int <WarningCount>k__BackingField;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BCA4", Offset = "0xB6BCA4")]
		private int <InfoCount>k__BackingField;

		[Token(Token = "0x170000CD")]
		public int ErrorCount
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1068C3C", Offset = "0x1068C3C", VA = "0x1068C3C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ECF8", Offset = "0xB6ECF8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1068C44", Offset = "0x1068C44", VA = "0x1068C44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED08", Offset = "0xB6ED08")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public int WarningCount
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1068C4C", Offset = "0x1068C4C", VA = "0x1068C4C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED18", Offset = "0xB6ED18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x1068C54", Offset = "0x1068C54", VA = "0x1068C54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED28", Offset = "0xB6ED28")]
			private set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public int InfoCount
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1068C5C", Offset = "0x1068C5C", VA = "0x1068C5C", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED38", Offset = "0xB6ED38")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1068C64", Offset = "0x1068C64", VA = "0x1068C64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED48", Offset = "0xB6ED48")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public IReadOnlyList<ConsoleEntry> Entries
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1068DB4", Offset = "0x1068DB4", VA = "0x1068DB4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public IReadOnlyList<ConsoleEntry> AllEntries
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1068DD0", Offset = "0x1068DD0", VA = "0x1068DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000011")]
		public event ConsoleUpdatedEventHandler Updated
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1068C6C", Offset = "0x1068C6C", VA = "0x1068C6C", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED58", Offset = "0xB6ED58")]
			add
			{
			}
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1068D10", Offset = "0x1068D10", VA = "0x1068D10", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED68", Offset = "0xB6ED68")]
			remove
			{
			}
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1068B10", Offset = "0x1068B10", VA = "0x1068B10")]
		public StandardConsoleService()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1068DD8", Offset = "0x1068DD8", VA = "0x1068DD8", Slot = "11")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1068FE4", Offset = "0x1068FE4", VA = "0x1068FE4")]
		protected void OnEntryAdded(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x106920C", Offset = "0x106920C", VA = "0x106920C")]
		protected void OnEntryDuplicated(ConsoleEntry entry)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1068F20", Offset = "0x1068F20", VA = "0x1068F20")]
		private void OnUpdated()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x10692D0", Offset = "0x10692D0", VA = "0x10692D0")]
		private void UnityLogCallback(string condition, string stackTrace, LogType type)
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x10691BC", Offset = "0x10691BC", VA = "0x10691BC")]
		private void AdjustCounter(LogType type, int amount)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69A44", Offset = "0xB69A44")]
	public class StandardSystemInformationService : ISystemInformationService
	{
		[Token(Token = "0x200019D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC18", Offset = "0xB6AC18")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InfoEntry info;

			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x106B280", Offset = "0x106B280", VA = "0x106B280")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x106BDF8", Offset = "0x106BDF8", VA = "0x106BDF8")]
			internal bool <Add>b__0(InfoEntry p)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x200019E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC28", Offset = "0xB6AC28")]
		private sealed class <>c
		{
			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<object> <>9__6_0;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<object> <>9__6_1;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<object> <>9__6_2;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<object> <>9__6_3;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<object> <>9__6_4;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Func<object> <>9__6_5;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Func<object> <>9__6_6;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Func<object> <>9__6_7;

			[Token(Token = "0x6000BE5")]
			[Address(RVA = "0x106B8B0", Offset = "0x106B8B0", VA = "0x106B8B0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BE6")]
			[Address(RVA = "0x106B8B8", Offset = "0x106B8B8", VA = "0x106B8B8")]
			internal object <CreateDefaultSet>b__6_0()
			{
				return null;
			}

			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x106B95C", Offset = "0x106B95C", VA = "0x106B95C")]
			internal object <CreateDefaultSet>b__6_1()
			{
				return null;
			}

			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x106B9B8", Offset = "0x106B9B8", VA = "0x106B9B8")]
			internal object <CreateDefaultSet>b__6_2()
			{
				return null;
			}

			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x106BA1C", Offset = "0x106BA1C", VA = "0x106BA1C")]
			internal object <CreateDefaultSet>b__6_3()
			{
				return null;
			}

			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x106BA7C", Offset = "0x106BA7C", VA = "0x106BA7C")]
			internal object <CreateDefaultSet>b__6_4()
			{
				return null;
			}

			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x106BAD8", Offset = "0x106BAD8", VA = "0x106BAD8")]
			internal object <CreateDefaultSet>b__6_5()
			{
				return null;
			}

			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x106BB34", Offset = "0x106BB34", VA = "0x106BB34")]
			internal object <CreateDefaultSet>b__6_6()
			{
				return null;
			}

			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x106BC64", Offset = "0x106BC64", VA = "0x106BC64")]
			internal object <CreateDefaultSet>b__6_7()
			{
				return null;
			}
		}

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, IList<InfoEntry>> _info;

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x10694E8", Offset = "0x10694E8", VA = "0x10694E8")]
		public StandardSystemInformationService()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x106AEE0", Offset = "0x106AEE0", VA = "0x106AEE0", Slot = "4")]
		public IEnumerable<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x106AF38", Offset = "0x106AF38", VA = "0x106AF38", Slot = "5")]
		public IList<InfoEntry> GetInfo(string category)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x106B070", Offset = "0x106B070", VA = "0x106B070", Slot = "6")]
		public void Add(InfoEntry info, string category = "Default")
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x106B288", Offset = "0x106B288", VA = "0x106B288", Slot = "7")]
		public Dictionary<string, Dictionary<string, object>> CreateReport(bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1069560", Offset = "0x1069560", VA = "0x1069560")]
		private void CreateDefaultSet()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x106B714", Offset = "0x106B714", VA = "0x106B714")]
		private static string GetCloudManifestPrettyName(string name)
		{
			return null;
		}
	}
}
namespace SRDebugger.Profiler
{
	[Token(Token = "0x20000CB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69AA8", Offset = "0xB69AA8")]
	public class ProfilerCameraListener : MonoBehaviour
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera _camera;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Stopwatch _stopwatch;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<ProfilerCameraListener, double> RenderDurationCallback;

		[Token(Token = "0x170000D2")]
		protected Stopwatch Stopwatch
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x114BE9C", Offset = "0x114BE9C", VA = "0x114BE9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public Camera Camera
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x114BF08", Offset = "0x114BF08", VA = "0x114BF08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x114BFA0", Offset = "0x114BFA0", VA = "0x114BFA0")]
		private void OnPreCull()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x114BFE8", Offset = "0x114BFE8", VA = "0x114BFE8")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x114C0E4", Offset = "0x114C0E4", VA = "0x114C0E4")]
		public ProfilerCameraListener()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class ProfilerLateUpdateListener : MonoBehaviour
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action OnLateUpdate;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x114C0EC", Offset = "0x114C0EC", VA = "0x114C0EC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x114C100", Offset = "0x114C100", VA = "0x114C100")]
		public ProfilerLateUpdateListener()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "ServiceAttribute", RVA = "0xB69B0C", Offset = "0xB69B0C")]
	public class ProfilerServiceImpl : SRServiceBase<IProfilerService>, IProfilerService
	{
		[Token(Token = "0x4000365")]
		private const int FrameBufferSize = 400;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly SRList<ProfilerCameraListener> _cameraListeners;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly CircularBuffer<ProfilerFrame> _frameBuffer;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera[] _cameraCache;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ProfilerLateUpdateListener _lateUpdateListener;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private double _renderDuration;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int _reportedCameras;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Stopwatch _stopwatch;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private double _updateDuration;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private double _updateToRenderDuration;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BCC4", Offset = "0xB6BCC4")]
		private float <AverageFrameTime>k__BackingField;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BCD4", Offset = "0xB6BCD4")]
		private float <LastFrameTime>k__BackingField;

		[Token(Token = "0x170000D4")]
		public float AverageFrameTime
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x114C108", Offset = "0x114C108", VA = "0x114C108", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED78", Offset = "0xB6ED78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x114C110", Offset = "0x114C110", VA = "0x114C110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED88", Offset = "0xB6ED88")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public float LastFrameTime
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x114C118", Offset = "0x114C118", VA = "0x114C118", Slot = "12")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6ED98", Offset = "0xB6ED98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x114C120", Offset = "0x114C120", VA = "0x114C120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDA8", Offset = "0xB6EDA8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public CircularBuffer<ProfilerFrame> FrameBuffer
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x114C128", Offset = "0x114C128", VA = "0x114C128", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x114C130", Offset = "0x114C130", VA = "0x114C130")]
		protected void PushFrame(double totalTime, double updateTime, double renderTime)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x114C1B8", Offset = "0x114C1B8", VA = "0x114C1B8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x114C2F4", Offset = "0x114C2F4", VA = "0x114C2F4", Slot = "6")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x114C780", Offset = "0x114C780", VA = "0x114C780")]
		private void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x114C7C8", Offset = "0x114C7C8", VA = "0x114C7C8")]
		private void EndFrame()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x114C844", Offset = "0x114C844", VA = "0x114C844")]
		private void CameraDurationCallback(ProfilerCameraListener listener, double duration)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x114C8C8", Offset = "0x114C8C8", VA = "0x114C8C8")]
		private int GetExpectedCameraCount()
		{
			return default(int);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x114C4BC", Offset = "0x114C4BC", VA = "0x114C4BC")]
		private void CameraCheck()
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x114C9F4", Offset = "0x114C9F4", VA = "0x114C9F4")]
		public ProfilerServiceImpl()
		{
		}
	}
}
namespace SRDebugger.Internal
{
	[Token(Token = "0x20000CE")]
	public static class SRDebugApi
	{
		[Token(Token = "0x4000371")]
		public const string Protocol = "http://";

		[Token(Token = "0x4000372")]
		public const string EndPoint = "http://srdebugger.stompyrobot.uk";

		[Token(Token = "0x4000373")]
		public const string BugReportEndPoint = "http://srdebugger.stompyrobot.uk/report/submit";
	}
	[Token(Token = "0x20000CF")]
	public static class SRDebugApiUtil
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x114AE68", Offset = "0x114AE68", VA = "0x114AE68")]
		public static string ParseErrorException(WebException ex)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1149D98", Offset = "0x1149D98", VA = "0x1149D98")]
		public static string ParseErrorResponse(string response, string fallback = "Unexpected Response")
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x114B1B8", Offset = "0x114B1B8", VA = "0x114B1B8")]
		public static bool ReadResponse(HttpWebRequest request, out string result)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x114AF58", Offset = "0x114AF58", VA = "0x114AF58")]
		public static string ReadResponseStream(WebResponse stream)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D0")]
	public class BugReportApi
	{
		[Token(Token = "0x200019F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC38", Offset = "0xB6AC38")]
		private sealed class <Submit>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BugReportApi <>4__this;

			[Token(Token = "0x17000256")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BF1")]
				[Address(RVA = "0x114A268", Offset = "0x114A268", VA = "0x114A268", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000257")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BF3")]
				[Address(RVA = "0x114A2D4", Offset = "0x114A2D4", VA = "0x114A2D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x114925C", Offset = "0x114925C", VA = "0x114925C")]
			[DebuggerHidden]
			public <Submit>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x11499B4", Offset = "0x11499B4", VA = "0x11499B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x11499B8", Offset = "0x11499B8", VA = "0x11499B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x114A270", Offset = "0x114A270", VA = "0x114A270", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string _apiKey;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly BugReport _bugReport;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _isBusy;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WWW _www;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BCE4", Offset = "0xB6BCE4")]
		private bool <IsComplete>k__BackingField;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BCF4", Offset = "0xB6BCF4")]
		private bool <WasSuccessful>k__BackingField;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD04", Offset = "0xB6BD04")]
		private string <ErrorMessage>k__BackingField;

		[Token(Token = "0x170000D7")]
		public bool IsComplete
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1149100", Offset = "0x1149100", VA = "0x1149100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDB8", Offset = "0xB6EDB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1149108", Offset = "0x1149108", VA = "0x1149108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDC8", Offset = "0xB6EDC8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool WasSuccessful
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1149114", Offset = "0x1149114", VA = "0x1149114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDD8", Offset = "0xB6EDD8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x114911C", Offset = "0x114911C", VA = "0x114911C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDE8", Offset = "0xB6EDE8")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public string ErrorMessage
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1149128", Offset = "0x1149128", VA = "0x1149128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EDF8", Offset = "0xB6EDF8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1149130", Offset = "0x1149130", VA = "0x1149130")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EE08", Offset = "0xB6EE08")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public float Progress
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1149138", Offset = "0x1149138", VA = "0x1149138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x11490C8", Offset = "0x11490C8", VA = "0x11490C8")]
		public BugReportApi(BugReport report, string apiKey)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x11491E8", Offset = "0x11491E8", VA = "0x11491E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6EE18", Offset = "0xB6EE18")]
		public IEnumerator Submit()
		{
			return null;
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1149288", Offset = "0x1149288", VA = "0x1149288")]
		private void SetCompletionState(bool wasSuccessful)
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1149358", Offset = "0x1149358", VA = "0x1149358")]
		private static string BuildJsonRequest(BugReport report)
		{
			return null;
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x11494B8", Offset = "0x11494B8", VA = "0x11494B8")]
		private static IList<IList<string>> CreateConsoleDump()
		{
			return null;
		}
	}
	[Token(Token = "0x20000D1")]
	public class BugReportScreenshotUtil
	{
		[Token(Token = "0x20001A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC48", Offset = "0xB6AC48")]
		private sealed class <ScreenshotCaptureCo>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000258")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000BF7")]
				[Address(RVA = "0x114A55C", Offset = "0x114A55C", VA = "0x114A55C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000259")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000BF9")]
				[Address(RVA = "0x114A5C8", Offset = "0x114A5C8", VA = "0x114A5C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x114A33C", Offset = "0x114A33C", VA = "0x114A33C")]
			[DebuggerHidden]
			public <ScreenshotCaptureCo>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x114A370", Offset = "0x114A370", VA = "0x114A370", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x114A374", Offset = "0x114A374", VA = "0x114A374", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x114A564", Offset = "0x114A564", VA = "0x114A564", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static byte[] ScreenshotData;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x114A2DC", Offset = "0x114A2DC", VA = "0x114A2DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6EE7C", Offset = "0xB6EE7C")]
		public static IEnumerator ScreenshotCaptureCo()
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x114A368", Offset = "0x114A368", VA = "0x114A368")]
		public BugReportScreenshotUtil()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public static class OptionControlFactory
	{
		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC58", Offset = "0xB6AC58")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public OptionDefinition from;

			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x114ACB4", Offset = "0x114ACB4", VA = "0x114ACB4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x114ACBC", Offset = "0x114ACBC", VA = "0x114ACBC")]
			internal bool <CreateDataControl>b__0(DataBoundControl p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IList<DataBoundControl> _dataControlPrefabs;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ActionControl _actionControlPrefab;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x114A5D0", Offset = "0x114A5D0", VA = "0x114A5D0")]
		public static OptionsControlBase CreateControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x114ABAC", Offset = "0x114ABAC", VA = "0x114ABAC")]
		private static ActionControl CreateActionControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x114A7C0", Offset = "0x114A7C0", VA = "0x114A7C0")]
		private static DataBoundControl CreateDataControl(OptionDefinition from, [Optional] string categoryPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x20000D3")]
	public class OptionDefinition
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD14", Offset = "0xB6BD14")]
		private string <Name>k__BackingField;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD24", Offset = "0xB6BD24")]
		private string <Category>k__BackingField;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD34", Offset = "0xB6BD34")]
		private int <SortPriority>k__BackingField;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD44", Offset = "0xB6BD44")]
		private MethodReference <Method>k__BackingField;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6BD54", Offset = "0xB6BD54")]
		private PropertyReference <Property>k__BackingField;

		[Token(Token = "0x170000DB")]
		public string Name
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x114AE18", Offset = "0x114AE18", VA = "0x114AE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EEE0", Offset = "0xB6EEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x114AE20", Offset = "0x114AE20", VA = "0x114AE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EEF0", Offset = "0xB6EEF0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public string Category
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x114AE28", Offset = "0x114AE28", VA = "0x114AE28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF00", Offset = "0xB6EF00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x114AE30", Offset = "0x114AE30", VA = "0x114AE30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF10", Offset = "0xB6EF10")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public int SortPriority
		{
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x114AE38", Offset = "0x114AE38", VA = "0x114AE38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF20", Offset = "0xB6EF20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x114AE40", Offset = "0x114AE40", VA = "0x114AE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF30", Offset = "0xB6EF30")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public MethodReference Method
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x114AE48", Offset = "0x114AE48", VA = "0x114AE48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF40", Offset = "0xB6EF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x114AE50", Offset = "0x114AE50", VA = "0x114AE50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF50", Offset = "0xB6EF50")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public PropertyReference Property
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x114AE58", Offset = "0x114AE58", VA = "0x114AE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF60", Offset = "0xB6EF60")]
			get
			{
				return null;
			}
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x114AE60", Offset = "0x114AE60", VA = "0x114AE60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF70", Offset = "0xB6EF70")]
			private set
			{
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x114AD38", Offset = "0x114AD38", VA = "0x114AD38")]
		private OptionDefinition(string name, string category, int sortPriority)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x114AD78", Offset = "0x114AD78", VA = "0x114AD78")]
		public OptionDefinition(string name, string category, int sortPriority, MethodReference method)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x114ADC8", Offset = "0x114ADC8", VA = "0x114ADC8")]
		public OptionDefinition(string name, string category, int sortPriority, PropertyReference property)
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public static class SRDebugPaths
	{
		[Token(Token = "0x4000383")]
		public const string DataControlsResourcesPath = "SRDebugger/UI/Prefabs/Options";

		[Token(Token = "0x4000384")]
		public const string TriggerPrefabPath = "SRDebugger/UI/Prefabs/Trigger";

		[Token(Token = "0x4000385")]
		public const string DebugPanelPrefabPath = "SRDebugger/UI/Prefabs/DebugPanel";

		[Token(Token = "0x4000386")]
		public const string PinnedUIPrefabPath = "SRDebugger/UI/Prefabs/PinnedUI";

		[Token(Token = "0x4000387")]
		public const string DockConsolePrefabPath = "SRDebugger/UI/Prefabs/DockConsole";

		[Token(Token = "0x4000388")]
		public const string PinEntryPrefabPath = "SRDebugger/UI/Prefabs/PinEntry";

		[Token(Token = "0x4000389")]
		public const string BugReportPopoverPath = "SRDebugger/UI/Prefabs/BugReportPopover";

		[Token(Token = "0x400038A")]
		public const string BugReportSheetPath = "SRDebugger/UI/Prefabs/BugReportSheet";

		[Token(Token = "0x400038B")]
		public const string SettingsMenuItemPath = "Window/SRDebugger/Settings Window";

		[Token(Token = "0x400038C")]
		public const string WelcomeItemPath = "Window/SRDebugger/Welcome Guide";

		[Token(Token = "0x400038D")]
		public const string SROptionsMenuItemPath = "Window/SRDebugger/SROptions Window";

		[Token(Token = "0x400038E")]
		public const string EditorLogoPath = "UI/Sprites/Default/Logo.psd";
	}
	[Token(Token = "0x20000D5")]
	public static class Service
	{
		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IConsoleService _consoleService;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IDebugPanelService _debugPanelService;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IDebugTriggerService _debugTriggerService;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IPinnedUIService _pinnedUiService;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IDebugCameraService _debugCameraService;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IOptionsService _optionsService;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static IDockConsoleService _dockConsoleService;

		[Token(Token = "0x170000E0")]
		public static IConsoleService Console
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x1149918", Offset = "0x1149918", VA = "0x1149918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E1")]
		public static IDockConsoleService DockConsole
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x114BBA4", Offset = "0x114BBA4", VA = "0x114BBA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		public static IDebugPanelService Panel
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x114BC3C", Offset = "0x114BC3C", VA = "0x114BC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E3")]
		public static IDebugTriggerService Trigger
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x114BCD4", Offset = "0x114BCD4", VA = "0x114BCD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		public static IPinnedUIService PinnedUI
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x114BD6C", Offset = "0x114BD6C", VA = "0x114BD6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public static IDebugCameraService DebugCamera
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x114BB0C", Offset = "0x114BB0C", VA = "0x114BB0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public static IOptionsService Options
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x114BE04", Offset = "0x114BE04", VA = "0x114BE04")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000D6")]
	public class SRDebugStrings
	{
		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SRDebugStrings Current;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Console_MessageTruncated;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly string Console_NoStackTrace;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly string PinEntryPrompt;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string Profiler_DisableProfilerInfo;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string Profiler_EnableProfilerInfo;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly string Profiler_NoProInfo;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly string Profiler_NotSupported;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string ProfilerCameraListenerHelp;

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x114B2B4", Offset = "0x114B2B4", VA = "0x114B2B4")]
		public SRDebugStrings()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public static class SRDebuggerUtil
	{
		[Token(Token = "0x170000E7")]
		public static bool IsMobilePlatform
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x114B3DC", Offset = "0x114B3DC", VA = "0x114B3DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x114B418", Offset = "0x114B418", VA = "0x114B418")]
		public static bool EnsureEventSystemExists()
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x114B588", Offset = "0x114B588", VA = "0x114B588")]
		public static void CreateDefaultEventSystem()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x114B61C", Offset = "0x114B61C", VA = "0x114B61C")]
		public static ICollection<OptionDefinition> ScanForOptions(object obj)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x114B9D0", Offset = "0x114B9D0", VA = "0x114B9D0")]
		public static string GetNumberString(int value, int max, string exceedsMaxString)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x114BA0C", Offset = "0x114BA0C", VA = "0x114BA0C")]
		public static void ConfigureCanvas(Canvas canvas)
		{
		}
	}
}
namespace AttentionLab
{
	[Token(Token = "0x20000D8")]
	[DisallowMultipleComponent]
	public class Outline : MonoBehaviour
	{
		[Token(Token = "0x20001A2")]
		public enum Mode
		{
			[Token(Token = "0x4000787")]
			OutlineAll,
			[Token(Token = "0x4000788")]
			OutlineVisible,
			[Token(Token = "0x4000789")]
			OutlineHidden,
			[Token(Token = "0x400078A")]
			OutlineAndSilhouette,
			[Token(Token = "0x400078B")]
			SilhouetteOnly
		}

		[Serializable]
		[Token(Token = "0x20001A3")]
		private class ListVector3
		{
			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> data;

			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x133FC10", Offset = "0x133FC10", VA = "0x133FC10")]
			public ListVector3()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC68", Offset = "0xB6AC68")]
		private sealed class <>c
		{
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Vector3, int, KeyValuePair<Vector3, int>> <>9__30_0;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<Vector3, int>, Vector3> <>9__30_1;

			[Token(Token = "0x6000BFE")]
			[Address(RVA = "0x133FDA0", Offset = "0x133FDA0", VA = "0x133FDA0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x133FDA8", Offset = "0x133FDA8", VA = "0x133FDA8")]
			internal KeyValuePair<Vector3, int> <SmoothNormals>b__30_0(Vector3 vertex, int index)
			{
				return default(KeyValuePair<Vector3, int>);
			}

			[Token(Token = "0x6000C00")]
			[Address(RVA = "0x133FE38", Offset = "0x133FE38", VA = "0x133FE38")]
			internal Vector3 <SmoothNormals>b__30_1(KeyValuePair<Vector3, int> pair)
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<Mesh> registeredMeshes;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mode outlineMode;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color outlineColor;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6BD84", Offset = "0xB6BD84")]
		private float outlineWidth;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB6BDC4", Offset = "0xB6BDC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB6BDC4", Offset = "0xB6BDC4")]
		private bool precomputeOutline;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private List<Mesh> bakeKeys;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private List<ListVector3> bakeValues;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Renderer[] renderers;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material outlineMaskMaterial;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material outlineFillMaterial;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool needsUpdate;

		[Token(Token = "0x170000E8")]
		public Mode OutlineMode
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x133E638", Offset = "0x133E638", VA = "0x133E638")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x133E640", Offset = "0x133E640", VA = "0x133E640")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public Color OutlineColor
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x133E650", Offset = "0x133E650", VA = "0x133E650")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x133E65C", Offset = "0x133E65C", VA = "0x133E65C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public float OutlineWidth
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x133E670", Offset = "0x133E670", VA = "0x133E670")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x133E678", Offset = "0x133E678", VA = "0x133E678")]
			set
			{
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x133E688", Offset = "0x133E688", VA = "0x133E688")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x133EA74", Offset = "0x133EA74", VA = "0x133EA74")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x133EB90", Offset = "0x133EB90", VA = "0x133EB90")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x133EE10", Offset = "0x133EE10", VA = "0x133EE10")]
		private void Update()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x133EFDC", Offset = "0x133EFDC", VA = "0x133EFDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x133F0F8", Offset = "0x133F0F8", VA = "0x133F0F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x133EC70", Offset = "0x133EC70", VA = "0x133EC70")]
		private void Bake()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x133E7B8", Offset = "0x133E7B8", VA = "0x133E7B8")]
		private void LoadSmoothNormals()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x133F170", Offset = "0x133F170", VA = "0x133F170")]
		private List<Vector3> SmoothNormals(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x133EE24", Offset = "0x133EE24", VA = "0x133EE24")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x133FC18", Offset = "0x133FC18", VA = "0x133FC18")]
		public Outline()
		{
		}
	}
}
namespace PathCreation.Examples
{
	[Token(Token = "0x20000D9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69B80", Offset = "0xB69B80")]
	public class GeneratePathExample : MonoBehaviour
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool closedLoop;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform[] waypoints;

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1146A50", Offset = "0x1146A50", VA = "0x1146A50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1146B0C", Offset = "0x1146B0C", VA = "0x1146B0C")]
		public GeneratePathExample()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class PathFollower : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathCreator;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EndOfPathInstruction endOfPathInstruction;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float distanceTravelled;

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1146B1C", Offset = "0x1146B1C", VA = "0x1146B1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1146BF4", Offset = "0x1146BF4", VA = "0x1146BF4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1146D30", Offset = "0x1146D30", VA = "0x1146D30")]
		private void OnPathChanged()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1146D98", Offset = "0x1146D98", VA = "0x1146D98")]
		public PathFollower()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[ExecuteInEditMode]
	public class PathPlacer : PathSceneTool
	{
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject prefab;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject holder;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float spacing;

		[Token(Token = "0x40003B3")]
		private const float minSpacing = 0.1f;

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1146DA8", Offset = "0x1146DA8", VA = "0x1146DA8")]
		private void Generate()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1146FEC", Offset = "0x1146FEC", VA = "0x1146FEC")]
		private void DestroyObjects()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x11470C8", Offset = "0x11470C8", VA = "0x11470C8", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1147150", Offset = "0x1147150", VA = "0x1147150")]
		public PathPlacer()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	[ExecuteInEditMode]
	public abstract class PathSceneTool : MonoBehaviour
	{
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathCreator pathCreator;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoUpdate;

		[Token(Token = "0x170000EB")]
		protected VertexPath path
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x11472C0", Offset = "0x11472C0", VA = "0x11472C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000012")]
		public event Action onDestroyed
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x1147178", Offset = "0x1147178", VA = "0x1147178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF80", Offset = "0xB6EF80")]
			add
			{
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x114721C", Offset = "0x114721C", VA = "0x114721C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6EF90", Offset = "0xB6EF90")]
			remove
			{
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x11472DC", Offset = "0x11472DC", VA = "0x11472DC")]
		public void TriggerUpdate()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x11472E8", Offset = "0x11472E8", VA = "0x11472E8", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600066E")]
		protected abstract void PathUpdated();

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1147168", Offset = "0x1147168", VA = "0x1147168")]
		protected PathSceneTool()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class PathSpawner : MonoBehaviour
	{
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PathCreator pathPrefab;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PathFollower followerPrefab;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform[] spawnPoints;

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x11472FC", Offset = "0x11472FC", VA = "0x11472FC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1147494", Offset = "0x1147494", VA = "0x1147494")]
		public PathSpawner()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class RoadMeshCreator : PathSceneTool
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB6BEB4", Offset = "0xB6BEB4")]
		public float roadWidth;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6BEEC", Offset = "0xB6BEEC")]
		public float thickness;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool flattenSurface;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB6BF04", Offset = "0xB6BF04")]
		public Material roadMaterial;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material undersideMaterial;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float textureTiling;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private GameObject meshHolder;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshFilter meshFilter;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshRenderer meshRenderer;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Mesh mesh;

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x114749C", Offset = "0x114749C", VA = "0x114749C", Slot = "5")]
		protected override void PathUpdated()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1147A44", Offset = "0x1147A44", VA = "0x1147A44")]
		private void CreateRoadMesh()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1147534", Offset = "0x1147534", VA = "0x1147534")]
		private void AssignMeshComponents()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1147838", Offset = "0x1147838", VA = "0x1147838")]
		private void AssignMaterials()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x114858C", Offset = "0x114858C", VA = "0x114858C")]
		public RoadMeshCreator()
		{
		}
	}
}
namespace PaintIn3D
{
	[Token(Token = "0x20000DF")]
	public class P3dPaintBrush : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001A5")]
		public class SharedData
		{
			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Texture shape;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private P3dChannel shapeChannel;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private P3dModifierList modifiers;

			[Token(Token = "0x1700025A")]
			public Texture Shape
			{
				[Token(Token = "0x6000C02")]
				[Address(RVA = "0x1135EF0", Offset = "0x1135EF0", VA = "0x1135EF0")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000C01")]
				[Address(RVA = "0x1135EE8", Offset = "0x1135EE8", VA = "0x1135EE8")]
				set
				{
				}
			}

			[Token(Token = "0x1700025B")]
			public P3dChannel ShapeChannel
			{
				[Token(Token = "0x6000C04")]
				[Address(RVA = "0x1135F00", Offset = "0x1135F00", VA = "0x1135F00")]
				get
				{
					return default(P3dChannel);
				}
				[Token(Token = "0x6000C03")]
				[Address(RVA = "0x1135EF8", Offset = "0x1135EF8", VA = "0x1135EF8")]
				set
				{
				}
			}

			[Token(Token = "0x1700025C")]
			public P3dModifierList Modifiers
			{
				[Token(Token = "0x6000C05")]
				[Address(RVA = "0x1135F08", Offset = "0x1135F08", VA = "0x1135F08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C06")]
			[Address(RVA = "0x1135F74", Offset = "0x1135F74", VA = "0x1135F74")]
			public void Draw(Rect rect)
			{
			}

			[Token(Token = "0x6000C07")]
			[Address(RVA = "0x1135D34", Offset = "0x1135D34", VA = "0x1135D34")]
			public SharedData()
			{
			}
		}

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string category;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SharedData data;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintBrush> cachedInstances;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000EC")]
		public string Category
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1135CC0", Offset = "0x1135CC0", VA = "0x1135CC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1135CB8", Offset = "0x1135CB8", VA = "0x1135CB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public SharedData Data
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1135CC8", Offset = "0x1135CC8", VA = "0x1135CC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		public static List<P3dPaintBrush> CachedInstances
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x1135DC4", Offset = "0x1135DC4", VA = "0x1135DC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1135D3C", Offset = "0x1135D3C", VA = "0x1135D3C")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1135E6C", Offset = "0x1135E6C", VA = "0x1135E6C")]
		public P3dPaintBrush()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class P3dPaintMaterial : ScriptableObject, P3dShaderTemplate.IHasTemplate
	{
		[Serializable]
		[Token(Token = "0x20001A6")]
		public class Slot
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup Group;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Texture Texture;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Color Color;

			[Token(Token = "0x6000C08")]
			[Address(RVA = "0x1138294", Offset = "0x1138294", VA = "0x1138294")]
			public Slot()
			{
			}
		}

		[Token(Token = "0x20001A7")]
		public enum StyleType
		{
			[Token(Token = "0x4000797")]
			Seamless,
			[Token(Token = "0x4000798")]
			Decal
		}

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string category;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture2D thumbnail;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private StyleType style;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture shape;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private P3dShaderTemplate template;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<Slot> slots;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintMaterial> cachedInstances;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000EF")]
		public string Category
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1137D3C", Offset = "0x1137D3C", VA = "0x1137D3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x1137D34", Offset = "0x1137D34", VA = "0x1137D34")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public Texture2D Thumbnail
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1137D4C", Offset = "0x1137D4C", VA = "0x1137D4C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1137D44", Offset = "0x1137D44", VA = "0x1137D44")]
			set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public StyleType Style
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1137D5C", Offset = "0x1137D5C", VA = "0x1137D5C")]
			get
			{
				return default(StyleType);
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1137D54", Offset = "0x1137D54", VA = "0x1137D54")]
			set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public Texture Shape
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x1137D6C", Offset = "0x1137D6C", VA = "0x1137D6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x1137D64", Offset = "0x1137D64", VA = "0x1137D64")]
			set
			{
			}
		}

		[Token(Token = "0x170000F3")]
		public Material Material
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x1137D7C", Offset = "0x1137D7C", VA = "0x1137D7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x1137D74", Offset = "0x1137D74", VA = "0x1137D74")]
			set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public P3dShaderTemplate Template
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1137D8C", Offset = "0x1137D8C", VA = "0x1137D8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1137D84", Offset = "0x1137D84", VA = "0x1137D84")]
			set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public List<Slot> Slots
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1137D94", Offset = "0x1137D94", VA = "0x1137D94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		public static List<P3dPaintMaterial> CachedInstances
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1138050", Offset = "0x1138050", VA = "0x1138050")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1137E08", Offset = "0x1137E08", VA = "0x1137E08")]
		public static void Draw(P3dPaintMaterial paintMaterial, Rect rect)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1137F44", Offset = "0x1137F44", VA = "0x1137F44", Slot = "4")]
		public void SetTemplate(P3dShaderTemplate template)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1137F4C", Offset = "0x1137F4C", VA = "0x1137F4C", Slot = "5")]
		public P3dShaderTemplate GetTemplate()
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1137F54", Offset = "0x1137F54", VA = "0x1137F54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6EFA0", Offset = "0xB6EFA0")]
		public void ClearThumbnail()
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1137FC8", Offset = "0x1137FC8", VA = "0x1137FC8")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x11380F8", Offset = "0x11380F8", VA = "0x11380F8")]
		public Slot GetSlot(P3dGroup group)
		{
			return null;
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1138218", Offset = "0x1138218", VA = "0x1138218")]
		public P3dPaintMaterial()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class P3dScene : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20001A8")]
		public class Image
		{
			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup Group;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int MatId;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Width;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int Height;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte[] Pixels;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RenderTexture Current;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public RenderTexture Preview;

			[Token(Token = "0x1700025D")]
			public Image Clone
			{
				[Token(Token = "0x6000C09")]
				[Address(RVA = "0x1141430", Offset = "0x1141430", VA = "0x1141430")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C0A")]
			[Address(RVA = "0x11415D8", Offset = "0x11415D8", VA = "0x11415D8")]
			public void Save()
			{
			}

			[Token(Token = "0x6000C0B")]
			[Address(RVA = "0x11415D0", Offset = "0x11415D0", VA = "0x11415D0")]
			public Image()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001A9")]
		public class Layer
		{
			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Opacity;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<Image> Images;

			[Token(Token = "0x1700025E")]
			public Layer Clone
			{
				[Token(Token = "0x6000C0C")]
				[Address(RVA = "0x1141714", Offset = "0x1141714", VA = "0x1141714")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C0D")]
			[Address(RVA = "0x113FC1C", Offset = "0x113FC1C", VA = "0x113FC1C")]
			public Image GetImage(int matId, P3dGroup group)
			{
				return null;
			}

			[Token(Token = "0x6000C0E")]
			[Address(RVA = "0x113FEA0", Offset = "0x113FEA0", VA = "0x113FEA0")]
			public void Save()
			{
			}

			[Token(Token = "0x6000C0F")]
			[Address(RVA = "0x1140CB0", Offset = "0x1140CB0", VA = "0x1140CB0")]
			public Layer()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AA")]
		public class Slot
		{
			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool Dirty;

			[Token(Token = "0x40007A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RenderTexture Texture;

			[Token(Token = "0x6000C10")]
			[Address(RVA = "0x1140ABC", Offset = "0x1140ABC", VA = "0x1140ABC")]
			public Slot()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AB")]
		public class Mat : P3dShaderTemplate.IHasTemplate
		{
			[Token(Token = "0x40007A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Id;

			[Token(Token = "0x40007A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Name;

			[Token(Token = "0x40007A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Material Material;

			[Token(Token = "0x40007A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public P3dShaderTemplate Template;

			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int Width;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int Height;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<Slot> Slots;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Dictionary<P3dGroup, MergedLayer> MergedLayers;

			[NonSerialized]
			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MaterialPropertyBlock Properties;

			[Token(Token = "0x1700025F")]
			public Mat Clone
			{
				[Token(Token = "0x6000C11")]
				[Address(RVA = "0x114187C", Offset = "0x114187C", VA = "0x114187C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000260")]
			public bool SizesMatch
			{
				[Token(Token = "0x6000C12")]
				[Address(RVA = "0x1141914", Offset = "0x1141914", VA = "0x1141914")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000261")]
			public RenderTextureDescriptor Desc
			{
				[Token(Token = "0x6000C18")]
				[Address(RVA = "0x113FA24", Offset = "0x113FA24", VA = "0x113FA24")]
				get
				{
					return default(RenderTextureDescriptor);
				}
			}

			[Token(Token = "0x6000C13")]
			[Address(RVA = "0x1141AD0", Offset = "0x1141AD0", VA = "0x1141AD0")]
			public void Resize()
			{
			}

			[Token(Token = "0x6000C14")]
			[Address(RVA = "0x1141DA8", Offset = "0x1141DA8", VA = "0x1141DA8", Slot = "4")]
			public void SetTemplate(P3dShaderTemplate template)
			{
			}

			[Token(Token = "0x6000C15")]
			[Address(RVA = "0x1141DB0", Offset = "0x1141DB0", VA = "0x1141DB0", Slot = "5")]
			public P3dShaderTemplate GetTemplate()
			{
				return null;
			}

			[Token(Token = "0x6000C16")]
			[Address(RVA = "0x1141DB8", Offset = "0x1141DB8", VA = "0x1141DB8")]
			public Slot GetSlot(string name)
			{
				return null;
			}

			[Token(Token = "0x6000C17")]
			[Address(RVA = "0x1141F38", Offset = "0x1141F38", VA = "0x1141F38")]
			public Texture GetFinalTexture(P3dGroup group)
			{
				return null;
			}

			[Token(Token = "0x6000C19")]
			[Address(RVA = "0x113F954", Offset = "0x113F954", VA = "0x113F954")]
			public void UpdateMergedLayers(P3dGroup group)
			{
			}

			[Token(Token = "0x6000C1A")]
			[Address(RVA = "0x1140600", Offset = "0x1140600", VA = "0x1140600")]
			public Mat()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AC")]
		public class Obj
		{
			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh Mesh;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool Paintable;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public P3dCoord Coord;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform Transform;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 Position;

			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion Rotation;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 Scale;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<int> MatIds;

			[Token(Token = "0x17000262")]
			public Matrix4x4 Matrix
			{
				[Token(Token = "0x6000C1B")]
				[Address(RVA = "0x1141FD4", Offset = "0x1141FD4", VA = "0x1141FD4")]
				get
				{
					return default(Matrix4x4);
				}
			}

			[Token(Token = "0x17000263")]
			public Obj Clone
			{
				[Token(Token = "0x6000C1C")]
				[Address(RVA = "0x11420AC", Offset = "0x11420AC", VA = "0x11420AC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C1D")]
			[Address(RVA = "0x11409E4", Offset = "0x11409E4", VA = "0x11409E4")]
			public Obj()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001AD")]
		public class Cloner : IClone
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 Euler;

			[Token(Token = "0x40007BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool Flip;

			[Token(Token = "0x6000C1E")]
			[Address(RVA = "0x1140E8C", Offset = "0x1140E8C", VA = "0x1140E8C", Slot = "4")]
			public void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix)
			{
			}

			[Token(Token = "0x6000C1F")]
			[Address(RVA = "0x1140B98", Offset = "0x1140B98", VA = "0x1140B98")]
			public Cloner()
			{
			}
		}

		[Token(Token = "0x20001AE")]
		public class MergedLayer
		{
			[Token(Token = "0x40007BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderTexture Under;

			[Token(Token = "0x40007BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public RenderTexture Above;

			[Token(Token = "0x40007BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RenderTexture Final;

			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Layer Layer;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool Dirty;

			[Token(Token = "0x6000C20")]
			[Address(RVA = "0x113EB54", Offset = "0x113EB54", VA = "0x113EB54")]
			public void Clear()
			{
			}

			[Token(Token = "0x6000C21")]
			[Address(RVA = "0x1141FCC", Offset = "0x1141FCC", VA = "0x1141FCC")]
			public MergedLayer()
			{
			}
		}

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Layer> Layers;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Mat> Mats;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Obj> Objs;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public List<Cloner> Cloners;

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x113E724", Offset = "0x113E724", VA = "0x113E724")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x113EBF0", Offset = "0x113EBF0", VA = "0x113EBF0")]
		public void UpdateMergedLayers(Layer currentLayer)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x113FA9C", Offset = "0x113FA9C", VA = "0x113FA9C")]
		private static void TryBlendInto(ref RenderTexture renderTexture, Layer layer, int matId, P3dGroup group)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x113FDA4", Offset = "0x113FDA4", VA = "0x113FDA4")]
		public void Save()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x113FF9C", Offset = "0x113FF9C", VA = "0x113FF9C")]
		public void RemoveObj(Obj obj)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1140018", Offset = "0x1140018", VA = "0x1140018")]
		public Mat GetMat(int matId)
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1140134", Offset = "0x1140134", VA = "0x1140134")]
		public bool MatNameValid(string name, int maxCount = 1)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x114028C", Offset = "0x114028C", VA = "0x114028C")]
		public void RemoveMat(Mat mat)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1140308", Offset = "0x1140308", VA = "0x1140308")]
		public bool ObjExists(Transform source)
		{
			return default(bool);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1140454", Offset = "0x1140454", VA = "0x1140454")]
		public Mat AddMat(Material material, P3dShaderTemplate template, int size)
		{
			return null;
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1140698", Offset = "0x1140698", VA = "0x1140698")]
		public void AddObj(Transform source, Mesh mesh, Vector3 position, Quaternion rotation, Vector3 scale, Material[] materials, P3dShaderTemplate[] templates, int size)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1140AC4", Offset = "0x1140AC4", VA = "0x1140AC4")]
		public Cloner AddCloner(string name, Vector3 position, Vector3 euler)
		{
			return null;
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1140BA0", Offset = "0x1140BA0", VA = "0x1140BA0")]
		public void RemoveRepeater(Cloner repeater)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1140C1C", Offset = "0x1140C1C", VA = "0x1140C1C")]
		public Layer AddLayer()
		{
			return null;
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1140D28", Offset = "0x1140D28", VA = "0x1140D28")]
		public void RemoveLayer(Layer layer)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1140DA4", Offset = "0x1140DA4", VA = "0x1140DA4")]
		public P3dScene()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class P3dShaderTemplate : ScriptableObject
	{
		[Token(Token = "0x20001AF")]
		public interface IHasTemplate
		{
			[Token(Token = "0x6000C22")]
			void SetTemplate(P3dShaderTemplate template);

			[Token(Token = "0x6000C23")]
			P3dShaderTemplate GetTemplate();
		}

		[Token(Token = "0x20001B0")]
		public enum Channel
		{
			[Token(Token = "0x40007C2")]
			Red,
			[Token(Token = "0x40007C3")]
			Green,
			[Token(Token = "0x40007C4")]
			Blue,
			[Token(Token = "0x40007C5")]
			Alpha
		}

		[Serializable]
		[Token(Token = "0x20001B1")]
		public class Write
		{
			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dGroup SourceGroup;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Channel SourceChannel;

			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x1146498", Offset = "0x1146498", VA = "0x1146498")]
			public Write GetCopy()
			{
				return null;
			}

			[Token(Token = "0x6000C25")]
			[Address(RVA = "0x1146514", Offset = "0x1146514", VA = "0x1146514")]
			public Write()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20001B2")]
		public class Slot
		{
			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string Alias;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Write WriteR;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Write WriteG;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Write WriteB;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Write WriteA;

			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x1146458", Offset = "0x1146458", VA = "0x1146458")]
			public string GetAlias()
			{
				return null;
			}

			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x1146490", Offset = "0x1146490", VA = "0x1146490")]
			public Slot()
			{
			}
		}

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dShaderTemplate> tempInstances;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Shader shader;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Slot> slots;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<P3dShaderTemplate> cachedInstances;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170000F7")]
		public Shader Shader
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x11463AC", Offset = "0x11463AC", VA = "0x11463AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x11463A4", Offset = "0x11463A4", VA = "0x11463A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public List<Slot> Slots
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x113F8E0", Offset = "0x113F8E0", VA = "0x113F8E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x11460A0", Offset = "0x11460A0", VA = "0x11460A0")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1146128", Offset = "0x1146128", VA = "0x1146128")]
		public static List<P3dShaderTemplate> GetTemplates(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x11463B4", Offset = "0x11463B4", VA = "0x11463B4")]
		public P3dShaderTemplate()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69C04", Offset = "0xB69C04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69C04", Offset = "0xB69C04")]
	public class P3dCloneMirror : P3dClone
	{
		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool flip;

		[Token(Token = "0x170000F9")]
		public bool Flip
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x134517C", Offset = "0x134517C", VA = "0x134517C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1345170", Offset = "0x1345170", VA = "0x1345170")]
			set
			{
			}
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1345184", Offset = "0x1345184", VA = "0x1345184", Slot = "7")]
		public override void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1345748", Offset = "0x1345748", VA = "0x1345748")]
		public P3dCloneMirror()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public abstract class P3dConnectableLines : MonoBehaviour
	{
		[Token(Token = "0x20001B3")]
		private class Link
		{
			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Owner;

			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector3 EndPosition;

			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float Age;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool Preview;

			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x1349EE0", Offset = "0x1349EE0", VA = "0x1349EE0")]
			public Link()
			{
			}
		}

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected bool connectHits;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float hitSpacing;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int hitLimit;

		[NonSerialized]
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<Link> linkPool;

		[NonSerialized]
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected P3dHitCache hitCache;

		[Token(Token = "0x170000FA")]
		public bool ConnectHits
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1349198", Offset = "0x1349198", VA = "0x1349198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x134918C", Offset = "0x134918C", VA = "0x134918C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public float HitSpacing
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x13491A8", Offset = "0x13491A8", VA = "0x13491A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x13491A0", Offset = "0x13491A0", VA = "0x13491A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public int HitLimit
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x13491B8", Offset = "0x13491B8", VA = "0x13491B8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0x13491B0", Offset = "0x13491B0", VA = "0x13491B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x13491C0", Offset = "0x13491C0", VA = "0x13491C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x13491C8", Offset = "0x13491C8", VA = "0x13491C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6EFD8", Offset = "0xB6EFD8")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1349284", Offset = "0x1349284", VA = "0x1349284")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F010", Offset = "0xB6F010")]
		public void ResetConnections()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1349380", Offset = "0x1349380", VA = "0x1349380")]
		protected void BreakHits(object owner)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x134948C", Offset = "0x134948C", VA = "0x134948C")]
		protected void SubmitLine(bool preview, int priority, Vector3 position, Vector3 endPosition, Quaternion rotation, float pressure, object owner)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x1349EE8", Offset = "0x1349EE8", VA = "0x1349EE8", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x1349EEC", Offset = "0x1349EEC", VA = "0x1349EEC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1349A74", Offset = "0x1349A74", VA = "0x1349A74")]
		private bool TryGetLink(object owner, ref Link link)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x134A02C", Offset = "0x134A02C", VA = "0x134A02C")]
		protected P3dConnectableLines()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public abstract class P3dConnectablePoints : MonoBehaviour
	{
		[Token(Token = "0x20001B4")]
		private class Link
		{
			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object Owner;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 Position;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float Age;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool Preview;

			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x134AB64", Offset = "0x134AB64", VA = "0x134AB64")]
			public Link()
			{
			}
		}

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected bool connectHits;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float hitSpacing;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int hitLimit;

		[NonSerialized]
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<Link> linkPool;

		[NonSerialized]
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected P3dHitCache hitCache;

		[Token(Token = "0x170000FE")]
		public bool ConnectHits
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x134A228", Offset = "0x134A228", VA = "0x134A228")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x134A21C", Offset = "0x134A21C", VA = "0x134A21C")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public float HitSpacing
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x134A238", Offset = "0x134A238", VA = "0x134A238")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x134A230", Offset = "0x134A230", VA = "0x134A230")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public int HitLimit
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x134A248", Offset = "0x134A248", VA = "0x134A248")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x134A240", Offset = "0x134A240", VA = "0x134A240")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x134A250", Offset = "0x134A250", VA = "0x134A250")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x134A258", Offset = "0x134A258", VA = "0x134A258")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F048", Offset = "0xB6F048")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x134A270", Offset = "0x134A270", VA = "0x134A270")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F080", Offset = "0xB6F080")]
		public void ResetConnections()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x134A36C", Offset = "0x134A36C", VA = "0x134A36C")]
		protected void BreakHits(object owner)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x134A478", Offset = "0x134A478", VA = "0x134A478")]
		protected void SubmitPoint(bool preview, int priority, float pressure, Vector3 position, Quaternion rotation, object owner)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x134AB6C", Offset = "0x134AB6C", VA = "0x134AB6C", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x134AB70", Offset = "0x134AB70", VA = "0x134AB70", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x134A8E0", Offset = "0x134A8E0", VA = "0x134A8E0")]
		private bool TryGetLink(object owner, ref Link link)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x134ACB0", Offset = "0x134ACB0", VA = "0x134ACB0")]
		protected P3dConnectablePoints()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69C64", Offset = "0xB69C64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69C64", Offset = "0xB69C64")]
	public class P3dHitBetween : P3dConnectablePoints
	{
		[Token(Token = "0x20001B5")]
		public enum PhaseType
		{
			[Token(Token = "0x40007D8")]
			Update,
			[Token(Token = "0x40007D9")]
			FixedUpdate
		}

		[Token(Token = "0x20001B6")]
		public enum OrientationType
		{
			[Token(Token = "0x40007DB")]
			WorldUp,
			[Token(Token = "0x40007DC")]
			CameraUp
		}

		[Token(Token = "0x20001B7")]
		public enum NormalType
		{
			[Token(Token = "0x40007DE")]
			HitNormal,
			[Token(Token = "0x40007DF")]
			RayDirection
		}

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C0A4", Offset = "0xB6C0A4")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform pointA;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform pointB;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float fraction;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6C170", Offset = "0xB6C170")]
		[SerializeField]
		private float pressure;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform point;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LineRenderer line;

		[NonSerialized]
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float current;

		[Token(Token = "0x17000102")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x134DF78", Offset = "0x134DF78", VA = "0x134DF78")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x134DF70", Offset = "0x134DF70", VA = "0x134DF70")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public float Interval
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x134DF88", Offset = "0x134DF88", VA = "0x134DF88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x134DF80", Offset = "0x134DF80", VA = "0x134DF80")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public Transform PointA
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x134DF98", Offset = "0x134DF98", VA = "0x134DF98")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x134DF90", Offset = "0x134DF90", VA = "0x134DF90")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public Transform PointB
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x134DFA8", Offset = "0x134DFA8", VA = "0x134DFA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x134DFA0", Offset = "0x134DFA0", VA = "0x134DFA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public float Fraction
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x134DFB0", Offset = "0x134DFB0", VA = "0x134DFB0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000107")]
		public LayerMask Layers
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x134DFC0", Offset = "0x134DFC0", VA = "0x134DFC0")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x134DFB8", Offset = "0x134DFB8", VA = "0x134DFB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public OrientationType Orientation
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x134DFD0", Offset = "0x134DFD0", VA = "0x134DFD0")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x134DFC8", Offset = "0x134DFC8", VA = "0x134DFC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Camera Camera
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x134DFE0", Offset = "0x134DFE0", VA = "0x134DFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x134DFD8", Offset = "0x134DFD8", VA = "0x134DFD8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public NormalType Normal
		{
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x134DFF0", Offset = "0x134DFF0", VA = "0x134DFF0")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x134DFE8", Offset = "0x134DFE8", VA = "0x134DFE8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public float Offset
		{
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x134E000", Offset = "0x134E000", VA = "0x134E000")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x134DFF8", Offset = "0x134DFF8", VA = "0x134DFF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public float Pressure
		{
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x134E010", Offset = "0x134E010", VA = "0x134E010")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x134E008", Offset = "0x134E008", VA = "0x134E008")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public bool Preview
		{
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x134E024", Offset = "0x134E024", VA = "0x134E024")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x134E018", Offset = "0x134E018", VA = "0x134E018")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public int Priority
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x134E034", Offset = "0x134E034", VA = "0x134E034")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x134E02C", Offset = "0x134E02C", VA = "0x134E02C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public Transform Point
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x134E044", Offset = "0x134E044", VA = "0x134E044")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x134E03C", Offset = "0x134E03C", VA = "0x134E03C")]
			set
			{
			}
		}

		[Token(Token = "0x17000110")]
		public LineRenderer Line
		{
			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x134E054", Offset = "0x134E054", VA = "0x134E054")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x134E04C", Offset = "0x134E04C", VA = "0x134E04C")]
			set
			{
			}
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x134E05C", Offset = "0x134E05C", VA = "0x134E05C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F0B8", Offset = "0xB6F0B8")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x134E714", Offset = "0x134E714", VA = "0x134E714")]
		private void UpdatePointAndLine()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x134E960", Offset = "0x134E960", VA = "0x134E960", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x134EA4C", Offset = "0x134EA4C", VA = "0x134EA4C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x134EB04", Offset = "0x134EB04", VA = "0x134EB04", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x134EB08", Offset = "0x134EB08", VA = "0x134EB08", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x134EA9C", Offset = "0x134EA9C", VA = "0x134EA9C")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x134EB24", Offset = "0x134EB24", VA = "0x134EB24")]
		public P3dHitBetween()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class P3dHitCache
	{
		[NonSerialized]
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool cached;

		[NonSerialized]
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<IHitPoint> hitPoints;

		[NonSerialized]
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<IHitLine> hitLines;

		[NonSerialized]
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<IHitQuad> hitQuads;

		[NonSerialized]
		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<IHitRaycast> hitRaycasts;

		[NonSerialized]
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<IHit> hits;

		[Token(Token = "0x17000111")]
		public bool Cached
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x134EBB0", Offset = "0x134EBB0", VA = "0x134EBB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x134A9B4", Offset = "0x134A9B4", VA = "0x134A9B4")]
		public void InvokePoint(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1349D28", Offset = "0x1349D28", VA = "0x1349D28")]
		public void InvokeLine(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1349B48", Offset = "0x1349B48", VA = "0x1349B48")]
		public void InvokeQuad(GameObject gameObject, bool preview, int priority, float pressure, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x134E530", Offset = "0x134E530", VA = "0x134E530")]
		public void InvokeRaycast(GameObject gameObject, bool preview, int priority, float pressure, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x13491E0", Offset = "0x13491E0", VA = "0x13491E0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x134EBB8", Offset = "0x134EBB8", VA = "0x134EBB8")]
		private void Cache(GameObject gameObject)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x134A0C0", Offset = "0x134A0C0", VA = "0x134A0C0")]
		public P3dHitCache()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69CD4", Offset = "0xB69CD4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69CD4", Offset = "0xB69CD4")]
	public class P3dHitCollisions : MonoBehaviour
	{
		[Token(Token = "0x20001B8")]
		public enum OrientationType
		{
			[Token(Token = "0x40007E1")]
			WorldUp,
			[Token(Token = "0x40007E2")]
			CameraUp
		}

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C210", Offset = "0xB6C210")]
		[SerializeField]
		private float impactMin;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C25C", Offset = "0xB6C25C")]
		[SerializeField]
		private float impactPressure;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool onlyUseFirstContact;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float delay;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float raycastDistance;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject root;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float cooldown;

		[NonSerialized]
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private P3dHitCache hitCache;

		[Token(Token = "0x17000112")]
		public Camera Camera
		{
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x134EEAC", Offset = "0x134EEAC", VA = "0x134EEAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x134EEA4", Offset = "0x134EEA4", VA = "0x134EEA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000113")]
		public float Offset
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x134EEBC", Offset = "0x134EEBC", VA = "0x134EEBC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x134EEB4", Offset = "0x134EEB4", VA = "0x134EEB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public float ImpactMin
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x134EECC", Offset = "0x134EECC", VA = "0x134EECC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x134EEC4", Offset = "0x134EEC4", VA = "0x134EEC4")]
			set
			{
			}
		}

		[Token(Token = "0x17000115")]
		public float ImpactPressure
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x134EEDC", Offset = "0x134EEDC", VA = "0x134EEDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x134EED4", Offset = "0x134EED4", VA = "0x134EED4")]
			set
			{
			}
		}

		[Token(Token = "0x17000116")]
		public bool OnlyUseFirstContact
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x134EEF0", Offset = "0x134EEF0", VA = "0x134EEF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x134EEE4", Offset = "0x134EEE4", VA = "0x134EEE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000117")]
		public float Delay
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x134EF00", Offset = "0x134EF00", VA = "0x134EF00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x134EEF8", Offset = "0x134EEF8", VA = "0x134EEF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public LayerMask Layers
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x134EF10", Offset = "0x134EF10", VA = "0x134EF10")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x134EF08", Offset = "0x134EF08", VA = "0x134EF08")]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public OrientationType Orientation
		{
			[Token(Token = "0x600070C")]
			[Address(RVA = "0x134EF20", Offset = "0x134EF20", VA = "0x134EF20")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x134EF18", Offset = "0x134EF18", VA = "0x134EF18")]
			set
			{
			}
		}

		[Token(Token = "0x1700011A")]
		public float RaycastDistance
		{
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x134EF30", Offset = "0x134EF30", VA = "0x134EF30")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x134EF28", Offset = "0x134EF28", VA = "0x134EF28")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public bool Preview
		{
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x134EF44", Offset = "0x134EF44", VA = "0x134EF44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x134EF38", Offset = "0x134EF38", VA = "0x134EF38")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public int Priority
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x134EF54", Offset = "0x134EF54", VA = "0x134EF54")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x134EF4C", Offset = "0x134EF4C", VA = "0x134EF4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public GameObject Root
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x134EF9C", Offset = "0x134EF9C", VA = "0x134EF9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x134EF5C", Offset = "0x134EF5C", VA = "0x134EF5C")]
			set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x134EFA4", Offset = "0x134EFA4", VA = "0x134EFA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x134EF84", Offset = "0x134EF84", VA = "0x134EF84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F0F0", Offset = "0xB6F0F0")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x134EFAC", Offset = "0x134EFAC", VA = "0x134EFAC", Slot = "4")]
		protected virtual void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x134F58C", Offset = "0x134F58C", VA = "0x134F58C", Slot = "5")]
		protected virtual void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x134F590", Offset = "0x134F590", VA = "0x134F590", Slot = "6")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x134EFB0", Offset = "0x134EFB0", VA = "0x134EFB0")]
		private void CheckCollision(Collision collision)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x134F5C8", Offset = "0x134F5C8", VA = "0x134F5C8")]
		public P3dHitCollisions()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69D34", Offset = "0xB69D34")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69D34", Offset = "0xB69D34")]
	public class P3dHitExplosion : MonoBehaviour
	{
		[Token(Token = "0x20001B9")]
		public enum OrientationType
		{
			[Token(Token = "0x40007E4")]
			WorldUp,
			[Token(Token = "0x40007E5")]
			CameraUp
		}

		[Token(Token = "0x20001BA")]
		public enum NormalType
		{
			[Token(Token = "0x40007E7")]
			HitNormal,
			[Token(Token = "0x40007E8")]
			RayDirection
		}

		[Token(Token = "0x20001BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6AC78", Offset = "0xB6AC78")]
		private sealed class <DelayedOnHit>d__48 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pointB;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pointA;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public P3dHitExplosion <>4__this;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Ray <ray>5__2;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit <hit>5__3;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private float <distance01>5__4;

			[Token(Token = "0x17000264")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000C2D")]
				[Address(RVA = "0x134FED0", Offset = "0x134FED0", VA = "0x134FED0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000265")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000C2F")]
				[Address(RVA = "0x134FF3C", Offset = "0x134FF3C", VA = "0x134FF3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x134F924", Offset = "0x134F924", VA = "0x134F924")]
			[DebuggerHidden]
			public <DelayedOnHit>d__48(int <>1__state)
			{
			}

			[Token(Token = "0x6000C2B")]
			[Address(RVA = "0x134F9D8", Offset = "0x134F9D8", VA = "0x134F9D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000C2C")]
			[Address(RVA = "0x134F9DC", Offset = "0x134F9DC", VA = "0x134F9DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000C2E")]
			[Address(RVA = "0x134FED8", Offset = "0x134FED8", VA = "0x134FED8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int count;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float delayMax;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[NonSerialized]
		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private P3dHitCache hitCache;

		[Token(Token = "0x1700011F")]
		public float Radius
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x134F664", Offset = "0x134F664", VA = "0x134F664")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x134F65C", Offset = "0x134F65C", VA = "0x134F65C")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public int Count
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x134F674", Offset = "0x134F674", VA = "0x134F674")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x134F66C", Offset = "0x134F66C", VA = "0x134F66C")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public float DelayMax
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x134F684", Offset = "0x134F684", VA = "0x134F684")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x134F67C", Offset = "0x134F67C", VA = "0x134F67C")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public LayerMask Layers
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x134F694", Offset = "0x134F694", VA = "0x134F694")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x134F68C", Offset = "0x134F68C", VA = "0x134F68C")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x134F6A4", Offset = "0x134F6A4", VA = "0x134F6A4")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x134F69C", Offset = "0x134F69C", VA = "0x134F69C")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public Camera Camera
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x134F6B4", Offset = "0x134F6B4", VA = "0x134F6B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x134F6AC", Offset = "0x134F6AC", VA = "0x134F6AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public NormalType Normal
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x134F6C4", Offset = "0x134F6C4", VA = "0x134F6C4")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x134F6BC", Offset = "0x134F6BC", VA = "0x134F6BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public float Offset
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x134F6D4", Offset = "0x134F6D4", VA = "0x134F6D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x134F6CC", Offset = "0x134F6CC", VA = "0x134F6CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public bool Preview
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x134F6E8", Offset = "0x134F6E8", VA = "0x134F6E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x134F6DC", Offset = "0x134F6DC", VA = "0x134F6DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public int Priority
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x134F6F8", Offset = "0x134F6F8", VA = "0x134F6F8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x134F6F0", Offset = "0x134F6F0", VA = "0x134F6F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x134F700", Offset = "0x134F700", VA = "0x134F700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0x134F708", Offset = "0x134F708", VA = "0x134F708")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F128", Offset = "0xB6F128")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x134F720", Offset = "0x134F720", VA = "0x134F720", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0x134F724", Offset = "0x134F724", VA = "0x134F724")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F160", Offset = "0xB6F160")]
		public void ExplodeNow()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x134F874", Offset = "0x134F874", VA = "0x134F874")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB6F198", Offset = "0xB6F198")]
		private IEnumerator DelayedOnHit(Vector3 pointA, Vector3 pointB)
		{
			return null;
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0x134F950", Offset = "0x134F950", VA = "0x134F950")]
		public P3dHitExplosion()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69D94", Offset = "0xB69D94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69D94", Offset = "0xB69D94")]
	public class P3dHitNearby : P3dConnectablePoints
	{
		[Token(Token = "0x20001BC")]
		public enum PhaseType
		{
			[Token(Token = "0x40007F2")]
			Update,
			[Token(Token = "0x40007F3")]
			FixedUpdate
		}

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C3E8", Offset = "0xB6C3E8")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6C454", Offset = "0xB6C454")]
		[SerializeField]
		private float pressure;

		[NonSerialized]
		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float current;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector3 lastPosition;

		[Token(Token = "0x1700012A")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x134FF4C", Offset = "0x134FF4C", VA = "0x134FF4C")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x134FF44", Offset = "0x134FF44", VA = "0x134FF44")]
			set
			{
			}
		}

		[Token(Token = "0x1700012B")]
		public float Interval
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x134FF5C", Offset = "0x134FF5C", VA = "0x134FF5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x134FF54", Offset = "0x134FF54", VA = "0x134FF54")]
			set
			{
			}
		}

		[Token(Token = "0x1700012C")]
		public bool Preview
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x134FF70", Offset = "0x134FF70", VA = "0x134FF70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x134FF64", Offset = "0x134FF64", VA = "0x134FF64")]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public int Priority
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x134FF80", Offset = "0x134FF80", VA = "0x134FF80")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x134FF78", Offset = "0x134FF78", VA = "0x134FF78")]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public float Pressure
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x134FF90", Offset = "0x134FF90", VA = "0x134FF90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x134FF88", Offset = "0x134FF88", VA = "0x134FF88")]
			set
			{
			}
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x134FF98", Offset = "0x134FF98", VA = "0x134FF98")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F1FC", Offset = "0xB6F1FC")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x135004C", Offset = "0x135004C", VA = "0x135004C", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1350104", Offset = "0x1350104", VA = "0x1350104", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x135009C", Offset = "0x135009C", VA = "0x135009C")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x1350120", Offset = "0x1350120", VA = "0x1350120")]
		public P3dHitNearby()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69DF4", Offset = "0xB69DF4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69DF4", Offset = "0xB69DF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69DF4", Offset = "0xB69DF4")]
	public class P3dHitParticles : MonoBehaviour
	{
		[Token(Token = "0x20001BD")]
		public enum OrientationType
		{
			[Token(Token = "0x40007F5")]
			WorldUp,
			[Token(Token = "0x40007F6")]
			CameraUp
		}

		[Token(Token = "0x20001BE")]
		public enum NormalType
		{
			[Token(Token = "0x40007F8")]
			ParticleVelocity,
			[Token(Token = "0x40007F9")]
			CollisionNormal
		}

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int skip;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6C514", Offset = "0xB6C514")]
		private float pressure;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float pressureMinDistance;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float pressureMaxDistance;

		[NonSerialized]
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystem cachedParticleSystem;

		[NonSerialized]
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ParticleCollisionEvent> particleCollisionEvents;

		[NonSerialized]
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private P3dHitCache hitCache;

		[NonSerialized]
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int skipCounter;

		[Token(Token = "0x1700012F")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x13501A0", Offset = "0x13501A0", VA = "0x13501A0")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1350198", Offset = "0x1350198", VA = "0x1350198")]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public Camera Camera
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x13501B0", Offset = "0x13501B0", VA = "0x13501B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x13501A8", Offset = "0x13501A8", VA = "0x13501A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000131")]
		public NormalType Normal
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x13501C0", Offset = "0x13501C0", VA = "0x13501C0")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x13501B8", Offset = "0x13501B8", VA = "0x13501B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000132")]
		public float Offset
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x13501D0", Offset = "0x13501D0", VA = "0x13501D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x13501C8", Offset = "0x13501C8", VA = "0x13501C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000133")]
		public int Skip
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x13501E0", Offset = "0x13501E0", VA = "0x13501E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x13501D8", Offset = "0x13501D8", VA = "0x13501D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public bool Preview
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x13501F4", Offset = "0x13501F4", VA = "0x13501F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x13501E8", Offset = "0x13501E8", VA = "0x13501E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public int Priority
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1350204", Offset = "0x1350204", VA = "0x1350204")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x13501FC", Offset = "0x13501FC", VA = "0x13501FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public float Pressure
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1350214", Offset = "0x1350214", VA = "0x1350214")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x135020C", Offset = "0x135020C", VA = "0x135020C")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public float PressureMinDistance
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1350224", Offset = "0x1350224", VA = "0x1350224")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x135021C", Offset = "0x135021C", VA = "0x135021C")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public float PressureMaxDistance
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1350234", Offset = "0x1350234", VA = "0x1350234")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x135022C", Offset = "0x135022C", VA = "0x135022C")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public P3dHitCache HitCache
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x135023C", Offset = "0x135023C", VA = "0x135023C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1350244", Offset = "0x1350244", VA = "0x1350244")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F234", Offset = "0xB6F234")]
		public void ClearHitCache()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x135025C", Offset = "0x135025C", VA = "0x135025C", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x13502B4", Offset = "0x13502B4", VA = "0x13502B4", Slot = "5")]
		protected virtual void OnParticleCollision(GameObject hitGameObject)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1350874", Offset = "0x1350874", VA = "0x1350874")]
		public P3dHitParticles()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69EA0", Offset = "0xB69EA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69EA0", Offset = "0xB69EA0")]
	public class P3dHitScreen : P3dConnectablePoints
	{
		[Token(Token = "0x20001BF")]
		private class Link
		{
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dInputManager.Finger Finger;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Distance;

			[Token(Token = "0x6000C30")]
			[Address(RVA = "0x135191C", Offset = "0x135191C", VA = "0x135191C")]
			public Link()
			{
			}
		}

		[Token(Token = "0x20001C0")]
		public enum OrientationType
		{
			[Token(Token = "0x40007FD")]
			WorldUp,
			[Token(Token = "0x40007FE")]
			CameraUp
		}

		[Token(Token = "0x20001C1")]
		public enum NormalType
		{
			[Token(Token = "0x4000800")]
			HitNormal,
			[Token(Token = "0x4000801")]
			RayDirection,
			[Token(Token = "0x4000802")]
			CameraDirection
		}

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float spacing;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private KeyCode key;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private NormalType normal;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float offset;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float touchOffset;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool showPreview;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool storeStates;

		[NonSerialized]
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Link> links;

		[NonSerialized]
		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private P3dInputManager inputManager;

		[Token(Token = "0x1700013A")]
		public Camera Camera
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x135095C", Offset = "0x135095C", VA = "0x135095C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x1350954", Offset = "0x1350954", VA = "0x1350954")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public float Spacing
		{
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x135096C", Offset = "0x135096C", VA = "0x135096C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x1350964", Offset = "0x1350964", VA = "0x1350964")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public LayerMask Layers
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x135097C", Offset = "0x135097C", VA = "0x135097C")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x1350974", Offset = "0x1350974", VA = "0x1350974")]
			set
			{
			}
		}

		[Token(Token = "0x1700013D")]
		public KeyCode Key
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x135098C", Offset = "0x135098C", VA = "0x135098C")]
			get
			{
				return default(KeyCode);
			}
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1350984", Offset = "0x1350984", VA = "0x1350984")]
			set
			{
			}
		}

		[Token(Token = "0x1700013E")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x135099C", Offset = "0x135099C", VA = "0x135099C")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x1350994", Offset = "0x1350994", VA = "0x1350994")]
			set
			{
			}
		}

		[Token(Token = "0x1700013F")]
		public NormalType Normal
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x13509AC", Offset = "0x13509AC", VA = "0x13509AC")]
			get
			{
				return default(NormalType);
			}
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x13509A4", Offset = "0x13509A4", VA = "0x13509A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000140")]
		public float Offset
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x13509BC", Offset = "0x13509BC", VA = "0x13509BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x13509B4", Offset = "0x13509B4", VA = "0x13509B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000141")]
		public float TouchOffset
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x13509CC", Offset = "0x13509CC", VA = "0x13509CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x13509C4", Offset = "0x13509C4", VA = "0x13509C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public bool ShowPreview
		{
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x13509E0", Offset = "0x13509E0", VA = "0x13509E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600076F")]
			[Address(RVA = "0x13509D4", Offset = "0x13509D4", VA = "0x13509D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public int Priority
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0x13509F0", Offset = "0x13509F0", VA = "0x13509F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000771")]
			[Address(RVA = "0x13509E8", Offset = "0x13509E8", VA = "0x13509E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public bool StoreStates
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1350A04", Offset = "0x1350A04", VA = "0x1350A04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x13509F8", Offset = "0x13509F8", VA = "0x13509F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1350A0C", Offset = "0x1350A0C", VA = "0x1350A0C")]
		protected void LateUpdate()
		{
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x13514D4", Offset = "0x13514D4", VA = "0x13514D4")]
		private void Paint(P3dInputManager.Finger finger, bool down, bool up)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1350FB0", Offset = "0x1350FB0", VA = "0x1350FB0")]
		private void PaintAt(Vector2 screenPosition, bool preview, float pressure, object owner)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x1351800", Offset = "0x1351800", VA = "0x1351800")]
		private Link GetLink(P3dInputManager.Finger finger)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x1351924", Offset = "0x1351924", VA = "0x1351924")]
		public P3dHitScreen()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69F00", Offset = "0xB69F00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69F00", Offset = "0xB69F00")]
	public class P3dHitThrough : P3dConnectableLines
	{
		[Token(Token = "0x20001C2")]
		public enum PhaseType
		{
			[Token(Token = "0x4000804")]
			Update,
			[Token(Token = "0x4000805")]
			FixedUpdate
		}

		[Token(Token = "0x20001C3")]
		public enum OrientationType
		{
			[Token(Token = "0x4000807")]
			WorldUp,
			[Token(Token = "0x4000808")]
			CameraUp
		}

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PhaseType paintIn;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C634", Offset = "0xB6C634")]
		[SerializeField]
		private float interval;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform pointA;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform pointB;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private OrientationType orientation;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Camera _camera;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6C6C0", Offset = "0xB6C6C0")]
		[SerializeField]
		private float pressure;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int priority;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LineRenderer line;

		[NonSerialized]
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float current;

		[Token(Token = "0x17000145")]
		public PhaseType PaintIn
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x1351A7C", Offset = "0x1351A7C", VA = "0x1351A7C")]
			get
			{
				return default(PhaseType);
			}
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x1351A74", Offset = "0x1351A74", VA = "0x1351A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public float Interval
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x1351A8C", Offset = "0x1351A8C", VA = "0x1351A8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1351A84", Offset = "0x1351A84", VA = "0x1351A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public Transform PointA
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x1351A9C", Offset = "0x1351A9C", VA = "0x1351A9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x1351A94", Offset = "0x1351A94", VA = "0x1351A94")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public Transform PointB
		{
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1351AAC", Offset = "0x1351AAC", VA = "0x1351AAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1351AA4", Offset = "0x1351AA4", VA = "0x1351AA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public OrientationType Orientation
		{
			[Token(Token = "0x6000783")]
			[Address(RVA = "0x1351ABC", Offset = "0x1351ABC", VA = "0x1351ABC")]
			get
			{
				return default(OrientationType);
			}
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x1351AB4", Offset = "0x1351AB4", VA = "0x1351AB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public Camera Camera
		{
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1351ACC", Offset = "0x1351ACC", VA = "0x1351ACC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1351AC4", Offset = "0x1351AC4", VA = "0x1351AC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public float Pressure
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x1351ADC", Offset = "0x1351ADC", VA = "0x1351ADC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x1351AD4", Offset = "0x1351AD4", VA = "0x1351AD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public bool Preview
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x1351AF0", Offset = "0x1351AF0", VA = "0x1351AF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x1351AE4", Offset = "0x1351AE4", VA = "0x1351AE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public int Priority
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x1351B00", Offset = "0x1351B00", VA = "0x1351B00")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x1351AF8", Offset = "0x1351AF8", VA = "0x1351AF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public LineRenderer Line
		{
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x1351B10", Offset = "0x1351B10", VA = "0x1351B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x1351B08", Offset = "0x1351B08", VA = "0x1351B08")]
			set
			{
			}
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1351B18", Offset = "0x1351B18", VA = "0x1351B18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F26C", Offset = "0xB6F26C")]
		public void ManuallyHitNow()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1351E30", Offset = "0x1351E30", VA = "0x1351E30", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1351EE8", Offset = "0x1351EE8", VA = "0x1351EE8", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x135208C", Offset = "0x135208C", VA = "0x135208C", Slot = "7")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1351E80", Offset = "0x1351E80", VA = "0x1351E80")]
		private void UpdateHit()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x1351EEC", Offset = "0x1351EEC", VA = "0x1351EEC")]
		private void UpdatePointAndLine()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x13520A8", Offset = "0x13520A8", VA = "0x13520A8")]
		public P3dHitThrough()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class P3dInputManager
	{
		[Token(Token = "0x20001C4")]
		public class Finger
		{
			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int Index;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float Pressure;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool LastSet;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool Set;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 PositionA;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector2 PositionB;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector2 PositionC;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector2 PositionD;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<Vector2> SmoothPositions;

			[Token(Token = "0x17000266")]
			public bool Down
			{
				[Token(Token = "0x6000C31")]
				[Address(RVA = "0x1351494", Offset = "0x1351494", VA = "0x1351494")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000267")]
			public bool Up
			{
				[Token(Token = "0x6000C32")]
				[Address(RVA = "0x13514B4", Offset = "0x13514B4", VA = "0x13514B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x1352BC8", Offset = "0x1352BC8", VA = "0x1352BC8")]
			public Finger()
			{
			}
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<RaycastResult> tempRaycastResults;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static PointerEventData tempPointerEventData;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static EventSystem tempEventSystem;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Finger> fingers;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Stack<Finger> pool;

		[Token(Token = "0x1700014F")]
		public static float ScaleFactor
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x13518EC", Offset = "0x13518EC", VA = "0x13518EC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000150")]
		public List<Finger> Fingers
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x1352120", Offset = "0x1352120", VA = "0x1352120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1352128", Offset = "0x1352128", VA = "0x1352128")]
		public Vector2 GetAverageDeltaScaled()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1350F24", Offset = "0x1350F24", VA = "0x1350F24")]
		public static bool PointOverGui(Vector2 screenPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1352310", Offset = "0x1352310", VA = "0x1352310")]
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x135239C", Offset = "0x135239C", VA = "0x135239C")]
		public static List<RaycastResult> RaycastGui(Vector2 screenPosition, LayerMask layerMask)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x1350C14", Offset = "0x1350C14", VA = "0x1350C14")]
		public void Update(KeyCode key)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1352740", Offset = "0x1352740", VA = "0x1352740")]
		private void CreateFinger(int index, Vector2 screenPosition, float pressure)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x13528F4", Offset = "0x13528F4", VA = "0x13528F4")]
		private void UpdateFinger(int index, Vector2 screenPosition, float pressure, bool set)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1352C38", Offset = "0x1352C38", VA = "0x1352C38")]
		private static Vector2 Hermite(Vector2 a, Vector2 b, Vector2 c, Vector2 d, float t)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x1352DC4", Offset = "0x1352DC4", VA = "0x1352DC4")]
		private static float HermiteInterpolate(float y0, float y1, float y2, float y3, float mu, float mu2, float mu3)
		{
			return default(float);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1351A04", Offset = "0x1351A04", VA = "0x1351A04")]
		public P3dInputManager()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69F70", Offset = "0xB69F70")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB69F70", Offset = "0xB69F70")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB69F70", Offset = "0xB69F70")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB69F70", Offset = "0xB69F70")]
	public class P3dMaterialCloner : MonoBehaviour
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int index;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool copySplatData;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[SerializeField]
		private bool activated;

		[Token(Token = "0x17000151")]
		public int Index
		{
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x1352EE8", Offset = "0x1352EE8", VA = "0x1352EE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1352EE0", Offset = "0x1352EE0", VA = "0x1352EE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public bool CopySplatData
		{
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x1352EFC", Offset = "0x1352EFC", VA = "0x1352EFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x1352EF0", Offset = "0x1352EF0", VA = "0x1352EF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public bool Activated
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0x1352F04", Offset = "0x1352F04", VA = "0x1352F04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x1352F0C", Offset = "0x1352F0C", VA = "0x1352F0C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F2A4", Offset = "0xB6F2A4")]
		public void ResetActivation()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x1352F14", Offset = "0x1352F14", VA = "0x1352F14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F2DC", Offset = "0xB6F2DC")]
		public void Activate()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1353214", Offset = "0x1353214", VA = "0x1353214")]
		private void Replace(Renderer renderer, Material[] materials, Material oldMaterial, Material newMaterial)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1353368", Offset = "0x1353368", VA = "0x1353368")]
		public P3dMaterialCloner()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB6A044", Offset = "0xB6A044")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A044", Offset = "0xB6A044")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A044", Offset = "0xB6A044")]
	public class P3dModel : P3dLinkedBehaviour<P3dModel>
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected P3dPaintable paintable;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool includeScale;

		[NonSerialized]
		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Renderer cachedRenderer;

		[NonSerialized]
		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool cachedRendererSet;

		[NonSerialized]
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SkinnedMeshRenderer cachedSkinned;

		[NonSerialized]
		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MeshFilter cachedFilter;

		[NonSerialized]
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool cachedSkinnedSet;

		[NonSerialized]
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform cachedTransform;

		[NonSerialized]
		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject cachedGameObject;

		[NonSerialized]
		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material[] materials;

		[NonSerialized]
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private bool materialsSet;

		[NonSerialized]
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Mesh bakedMesh;

		[NonSerialized]
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool bakedMeshSet;

		[NonSerialized]
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		protected bool prepared;

		[NonSerialized]
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Mesh preparedMesh;

		[NonSerialized]
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Matrix4x4 preparedMatrix;

		[NonSerialized]
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int[] preparedTriangles;

		[NonSerialized]
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3[] preparedPositions;

		[NonSerialized]
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector2[] preparedCoord0;

		[NonSerialized]
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector2[] preparedCoord1;

		[NonSerialized]
		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dModel> tempModels;

		[Token(Token = "0x17000154")]
		public virtual P3dPaintable Paintable
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x1353378", Offset = "0x1353378", VA = "0x1353378", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x1353370", Offset = "0x1353370", VA = "0x1353370", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public virtual bool IncludeScale
		{
			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x135338C", Offset = "0x135338C", VA = "0x135338C", Slot = "9")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x1353380", Offset = "0x1353380", VA = "0x1353380", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool Prepared
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x13533A0", Offset = "0x13533A0", VA = "0x13533A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x1353394", Offset = "0x1353394", VA = "0x1353394")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public GameObject CachedGameObject
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x13533A8", Offset = "0x13533A8", VA = "0x13533A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		public Renderer CachedRenderer
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x13533B0", Offset = "0x13533B0", VA = "0x13533B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000159")]
		public Material[] Materials
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x13534C4", Offset = "0x13534C4", VA = "0x13534C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x13533E0", Offset = "0x13533E0", VA = "0x13533E0")]
		private void CacheRenderer()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1353520", Offset = "0x1353520", VA = "0x1353520")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F314", Offset = "0xB6F314")]
		public void DirtyMaterials()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x1353528", Offset = "0x1353528", VA = "0x1353528")]
		public static List<P3dModel> FindOverlap(Vector3 position, float radius, int layerMask)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1353834", Offset = "0x1353834", VA = "0x1353834")]
		public void GetPreparedPoints(int triangleIndex, ref Vector3 pointA, ref Vector3 pointB, ref Vector3 pointC)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1353A0C", Offset = "0x1353A0C", VA = "0x1353A0C")]
		public void GetPreparedCoords0(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x1353BC0", Offset = "0x1353BC0", VA = "0x1353BC0")]
		public void GetPreparedCoords1(int triangleIndex, ref Vector2 coordA, ref Vector2 coordB, ref Vector2 coordC)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1353D74", Offset = "0x1353D74", VA = "0x1353D74")]
		public void GetPrepared(ref Mesh mesh, ref Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x13540A0", Offset = "0x13540A0", VA = "0x13540A0", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x1354114", Offset = "0x1354114", VA = "0x1354114", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1354188", Offset = "0x1354188", VA = "0x1354188")]
		public P3dModel()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB6A100", Offset = "0xB6A100")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A100", Offset = "0xB6A100")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A100", Offset = "0xB6A100")]
	public class P3dPaintable : P3dModel
	{
		[Token(Token = "0x20001C5")]
		public enum ActivationType
		{
			[Token(Token = "0x4000813")]
			Awake,
			[Token(Token = "0x4000814")]
			OnEnable,
			[Token(Token = "0x4000815")]
			Start,
			[Token(Token = "0x4000816")]
			OnFirstUse
		}

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ActivationType activation;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private Vector3 baseScale;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private List<Renderer> otherRenderers;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private bool activated;

		[NonSerialized]
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<P3dPaintableTexture> paintableTextures;

		[NonSerialized]
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dMaterialCloner> tempMaterialCloners;

		[Token(Token = "0x1700015A")]
		public override P3dPaintable Paintable
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1139CAC", Offset = "0x1139CAC", VA = "0x1139CAC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x1139CA8", Offset = "0x1139CA8", VA = "0x1139CA8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700015B")]
		public ActivationType Activation
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1139CBC", Offset = "0x1139CBC", VA = "0x1139CBC")]
			get
			{
				return default(ActivationType);
			}
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x1139CB4", Offset = "0x1139CB4", VA = "0x1139CB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public Vector3 BaseScale
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x1139CD0", Offset = "0x1139CD0", VA = "0x1139CD0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x1139CC4", Offset = "0x1139CC4", VA = "0x1139CC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700015D")]
		public List<Renderer> OtherRenderers
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1139CE4", Offset = "0x1139CE4", VA = "0x1139CE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1139CDC", Offset = "0x1139CDC", VA = "0x1139CDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700015E")]
		public bool Activated
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1139CEC", Offset = "0x1139CEC", VA = "0x1139CEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015F")]
		public List<P3dPaintableTexture> PaintableTextures
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x1139CF4", Offset = "0x1139CF4", VA = "0x1139CF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1139CFC", Offset = "0x1139CFC", VA = "0x1139CFC")]
		public void ScaleSize(ref int width, ref int height)
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1139E54", Offset = "0x1139E54", VA = "0x1139E54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F34C", Offset = "0xB6F34C")]
		public void Activate()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x113A2CC", Offset = "0x113A2CC", VA = "0x113A2CC")]
		public void ClearAll(Color color)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x113A2D4", Offset = "0x113A2D4", VA = "0x113A2D4")]
		public void ClearAll(Texture texture, Color color)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x113A480", Offset = "0x113A480", VA = "0x113A480")]
		public void Register(P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x113A580", Offset = "0x113A580", VA = "0x113A580")]
		public void Unregister(P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x113A684", Offset = "0x113A684", VA = "0x113A684", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x113A69C", Offset = "0x113A69C", VA = "0x113A69C", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x113A7E8", Offset = "0x113A7E8", VA = "0x113A7E8", Slot = "12")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x113A804", Offset = "0x113A804", VA = "0x113A804")]
		public P3dPaintable()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A1BC", Offset = "0xB6A1BC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A1BC", Offset = "0xB6A1BC")]
	public class P3dPaintableManager : P3dLinkedBehaviour<P3dPaintableManager>
	{
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x113A6DC", Offset = "0x113A6DC", VA = "0x113A6DC")]
		public static P3dPaintableManager GetOrCreateInstance()
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1136A80", Offset = "0x1136A80", VA = "0x1136A80")]
		public static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x113A908", Offset = "0x113A908", VA = "0x113A908")]
		private static void DoSubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group, P3dModel targetModel, P3dPaintableTexture targetTexture)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x113ABD4", Offset = "0x113ABD4", VA = "0x113ABD4")]
		private static void SubmitAll(P3dCommand command, Vector3 position, float radius, int layerMask, P3dGroup group)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x113AA90", Offset = "0x113AA90", VA = "0x113AA90")]
		private static void SubmitAll(P3dCommand command, P3dModel model, P3dGroup group)
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x11376C8", Offset = "0x11376C8", VA = "0x11376C8")]
		public static void Submit(P3dCommand command, P3dModel model, P3dPaintableTexture paintableTexture)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x113ADF4", Offset = "0x113ADF4", VA = "0x113ADF4", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x113AEEC", Offset = "0x113AEEC", VA = "0x113AEEC")]
		private void ClearAll()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x113AF74", Offset = "0x113AF74", VA = "0x113AF74")]
		private void UpdateAll()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x113B36C", Offset = "0x113B36C", VA = "0x113B36C")]
		public P3dPaintableManager()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class P3dPaintableState
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RenderTexture Texture;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<P3dCommand> Commands;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Stack<P3dPaintableState> pool;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x113B3BC", Offset = "0x113B3BC", VA = "0x113B3BC")]
		public static P3dPaintableState Pop()
		{
			return null;
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x113B4FC", Offset = "0x113B4FC", VA = "0x113B4FC")]
		public void Write(RenderTexture current)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x113B6E4", Offset = "0x113B6E4", VA = "0x113B6E4")]
		public void Write(List<P3dCommand> commands)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x113B5C0", Offset = "0x113B5C0", VA = "0x113B5C0")]
		private void Clear()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x113B754", Offset = "0x113B754", VA = "0x113B754")]
		public void Pool()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x113B48C", Offset = "0x113B48C", VA = "0x113B48C")]
		public P3dPaintableState()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB6A22C", Offset = "0xB6A22C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB6A22C", Offset = "0xB6A22C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A22C", Offset = "0xB6A22C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A22C", Offset = "0xB6A22C")]
	public class P3dPaintableTexture : P3dLinkedBehaviour<P3dPaintableTexture>
	{
		[Token(Token = "0x20001C6")]
		public enum StateType
		{
			[Token(Token = "0x4000818")]
			None,
			[Token(Token = "0x4000819")]
			FullTextureCopy,
			[Token(Token = "0x400081A")]
			LocalCommandCopy
		}

		[Token(Token = "0x20001C7")]
		public enum MipType
		{
			[Token(Token = "0x400081C")]
			Auto,
			[Token(Token = "0x400081D")]
			ForceOn,
			[Token(Token = "0x400081E")]
			ForceOff
		}

		[Serializable]
		[Token(Token = "0x20001C8")]
		public class PaintableTextureEvent : UnityEvent<P3dPaintableTexture>
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x113D9EC", Offset = "0x113D9EC", VA = "0x113D9EC")]
			public PaintableTextureEvent()
			{
			}
		}

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dSlot slot;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6C7D0", Offset = "0xB6C7D0")]
		[SerializeField]
		private P3dCoord coord;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private StateType state;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int stateLimit;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string saveName;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string shaderKeyword;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RenderTextureFormat format;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private MipType mipMaps;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool keepUnpaintable;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int width;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int height;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Texture texture;

		[NonSerialized]
		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private P3dPaintable cachedPaintable;

		[NonSerialized]
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool cachedPaintableSet;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		[SerializeField]
		private bool activated;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RenderTexture current;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private RenderTexture preview;

		[NonSerialized]
		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<P3dPaintableState> paintableStates;

		[NonSerialized]
		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int stateIndex;

		[NonSerialized]
		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private P3dPaintable paintable;

		[NonSerialized]
		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool paintableSet;

		[NonSerialized]
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material material;

		[NonSerialized]
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool materialSet;

		[NonSerialized]
		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private List<P3dCommand> paintCommands;

		[NonSerialized]
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<P3dCommand> previewCommands;

		[NonSerialized]
		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<P3dCommand> localCommands;

		[NonSerialized]
		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dPaintableTexture> tempPaintableTextures;

		[Token(Token = "0x17000160")]
		public P3dSlot Slot
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x113B85C", Offset = "0x113B85C", VA = "0x113B85C")]
			get
			{
				return default(P3dSlot);
			}
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x113B854", Offset = "0x113B854", VA = "0x113B854")]
			set
			{
			}
		}

		[Token(Token = "0x17000161")]
		public P3dCoord Coord
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x113B870", Offset = "0x113B870", VA = "0x113B870")]
			get
			{
				return default(P3dCoord);
			}
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x113B868", Offset = "0x113B868", VA = "0x113B868")]
			set
			{
			}
		}

		[Token(Token = "0x17000162")]
		public P3dGroup Group
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x113B880", Offset = "0x113B880", VA = "0x113B880")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x113B878", Offset = "0x113B878", VA = "0x113B878")]
			set
			{
			}
		}

		[Token(Token = "0x17000163")]
		public StateType State
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x113B890", Offset = "0x113B890", VA = "0x113B890")]
			get
			{
				return default(StateType);
			}
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x113B888", Offset = "0x113B888", VA = "0x113B888")]
			set
			{
			}
		}

		[Token(Token = "0x17000164")]
		public int StateLimit
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x113B8A0", Offset = "0x113B8A0", VA = "0x113B8A0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x113B898", Offset = "0x113B898", VA = "0x113B898")]
			set
			{
			}
		}

		[Token(Token = "0x17000165")]
		public string SaveName
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x113B8B0", Offset = "0x113B8B0", VA = "0x113B8B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x113B8A8", Offset = "0x113B8A8", VA = "0x113B8A8")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public string ShaderKeyword
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x113B8C0", Offset = "0x113B8C0", VA = "0x113B8C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x113B8B8", Offset = "0x113B8B8", VA = "0x113B8B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000167")]
		public RenderTextureFormat Format
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x113B8D0", Offset = "0x113B8D0", VA = "0x113B8D0")]
			get
			{
				return default(RenderTextureFormat);
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x113B8C8", Offset = "0x113B8C8", VA = "0x113B8C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public MipType MipMaps
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x113B8E0", Offset = "0x113B8E0", VA = "0x113B8E0")]
			get
			{
				return default(MipType);
			}
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x113B8D8", Offset = "0x113B8D8", VA = "0x113B8D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public bool KeepUnpaintable
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x113B8F4", Offset = "0x113B8F4", VA = "0x113B8F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x113B8E8", Offset = "0x113B8E8", VA = "0x113B8E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public int Width
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x113B904", Offset = "0x113B904", VA = "0x113B904")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x113B8FC", Offset = "0x113B8FC", VA = "0x113B8FC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public int Height
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x113B914", Offset = "0x113B914", VA = "0x113B914")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x113B90C", Offset = "0x113B90C", VA = "0x113B90C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		public Color Color
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x113B928", Offset = "0x113B928", VA = "0x113B928")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x113B91C", Offset = "0x113B91C", VA = "0x113B91C")]
			set
			{
			}
		}

		[Token(Token = "0x1700016D")]
		public Texture Texture
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x113B93C", Offset = "0x113B93C", VA = "0x113B93C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x113B934", Offset = "0x113B934", VA = "0x113B934")]
			set
			{
			}
		}

		[Token(Token = "0x1700016E")]
		public bool Activated
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x113BBD4", Offset = "0x113BBD4", VA = "0x113BBD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016F")]
		public bool CanUndo
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x113BBDC", Offset = "0x113BBDC", VA = "0x113BBDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000170")]
		public bool CanRedo
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x113BBFC", Offset = "0x113BBFC", VA = "0x113BBFC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000171")]
		public List<P3dPaintableState> States
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x113BC70", Offset = "0x113BC70", VA = "0x113BC70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		public int StateIndex
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x113BC78", Offset = "0x113BC78", VA = "0x113BC78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000173")]
		public P3dPaintable CachedPaintable
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x113AB64", Offset = "0x113AB64", VA = "0x113AB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		public RenderTexture Current
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x113BCC0", Offset = "0x113BCC0", VA = "0x113BCC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x113BC80", Offset = "0x113BC80", VA = "0x113BC80")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public RenderTexture Preview
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x113BCC8", Offset = "0x113BCC8", VA = "0x113BCC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000176")]
		public bool CommandsPending
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x113D480", Offset = "0x113D480", VA = "0x113D480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000013")]
		public event Action<P3dCommand> OnAddCommand
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x113B944", Offset = "0x113B944", VA = "0x113B944")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F384", Offset = "0xB6F384")]
			add
			{
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x113B9E8", Offset = "0x113B9E8", VA = "0x113B9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F394", Offset = "0xB6F394")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event Action<bool> OnModified
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x113BA8C", Offset = "0x113BA8C", VA = "0x113BA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F3A4", Offset = "0xB6F3A4")]
			add
			{
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x113BB30", Offset = "0x113BB30", VA = "0x113BB30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F3B4", Offset = "0xB6F3B4")]
			remove
			{
			}
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x11374BC", Offset = "0x11374BC", VA = "0x11374BC")]
		public static List<P3dPaintableTexture> Filter(P3dModel model, P3dGroup group)
		{
			return null;
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x113BCD0", Offset = "0x113BCD0", VA = "0x113BCD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F3C4", Offset = "0xB6F3C4")]
		public void ClearStates()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x113BD8C", Offset = "0x113BD8C", VA = "0x113BD8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F3FC", Offset = "0xB6F3FC")]
		public void StoreState()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x113C0A4", Offset = "0x113C0A4", VA = "0x113C0A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F434", Offset = "0xB6F434")]
		public void Undo()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x113C5FC", Offset = "0x113C5FC", VA = "0x113C5FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F46C", Offset = "0xB6F46C")]
		public void Redo()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1137684", Offset = "0x1137684", VA = "0x1137684")]
		public Vector2 GetCoord(ref RaycastHit hit)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x113C354", Offset = "0x113C354", VA = "0x113C354")]
		private void RebuildFromCommands()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x113BEF4", Offset = "0x113BEF4", VA = "0x113BEF4")]
		private void AddState()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x113BE2C", Offset = "0x113BE2C", VA = "0x113BE2C")]
		private void TrimFuture()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x113BFCC", Offset = "0x113BFCC", VA = "0x113BFCC")]
		private void TrimPast()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x113C588", Offset = "0x113C588", VA = "0x113C588")]
		public void NotifyOnModified(bool preview)
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x113C710", Offset = "0x113C710", VA = "0x113C710")]
		public Texture2D GetReadableCopy()
		{
			return null;
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x113C784", Offset = "0x113C784", VA = "0x113C784")]
		public byte[] GetPngData()
		{
			return null;
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x113C858", Offset = "0x113C858", VA = "0x113C858")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F4A4", Offset = "0xB6F4A4")]
		public void Clear()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x113A3B4", Offset = "0x113A3B4", VA = "0x113A3B4")]
		public void Clear(Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x113C868", Offset = "0x113C868", VA = "0x113C868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F4DC", Offset = "0xB6F4DC")]
		public void Replace()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x113C878", Offset = "0x113C878", VA = "0x113C878")]
		public void Replace(Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x113C980", Offset = "0x113C980", VA = "0x113C980")]
		public bool Resize(int width, int height, bool copyContents = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x113CB68", Offset = "0x113CB68", VA = "0x113CB68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F514", Offset = "0xB6F514")]
		public void Save()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x113CB70", Offset = "0x113CB70", VA = "0x113CB70")]
		public void Save(string saveName)
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x113CC24", Offset = "0x113CC24", VA = "0x113CC24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F54C", Offset = "0xB6F54C")]
		public void Load()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x113CC30", Offset = "0x113CC30", VA = "0x113CC30")]
		public void Load(string saveName, bool replace = true)
		{
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x113CCCC", Offset = "0x113CCCC", VA = "0x113CCCC")]
		public void LoadFromData(byte[] data, bool allowResize = true)
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x113CDE8", Offset = "0x113CDE8", VA = "0x113CDE8")]
		public void HidePreview()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x113CEC8", Offset = "0x113CEC8", VA = "0x113CEC8")]
		public static void HideAllPreviews()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x113CF60", Offset = "0x113CF60", VA = "0x113CF60")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F584", Offset = "0xB6F584")]
		public void ClearSave()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x113CFD0", Offset = "0x113CFD0", VA = "0x113CFD0")]
		public static void ClearSave(string saveName)
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x113D03C", Offset = "0x113D03C", VA = "0x113D03C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F5BC", Offset = "0xB6F5BC")]
		public void UpdateMaterial()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x113D0D8", Offset = "0x113D0D8", VA = "0x113D0D8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F5F4", Offset = "0xB6F5F4")]
		public void CopySize()
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x113D298", Offset = "0x113D298", VA = "0x113D298")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F62C", Offset = "0xB6F62C")]
		public void CopyTexture()
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x1139FE4", Offset = "0x1139FE4", VA = "0x1139FE4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F664", Offset = "0xB6F664")]
		public void Activate()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x113D2DC", Offset = "0x113D2DC", VA = "0x113D2DC", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x113D36C", Offset = "0x113D36C", VA = "0x113D36C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x113D3D0", Offset = "0x113D3D0", VA = "0x113D3D0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x113ACE8", Offset = "0x113ACE8", VA = "0x113ACE8")]
		public void AddCommand(P3dCommand command)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x113C1D4", Offset = "0x113C1D4", VA = "0x113C1D4")]
		public void ClearCommands()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x113B010", Offset = "0x113B010", VA = "0x113B010")]
		public void ExecuteCommands(bool sendNotifications)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x113D4EC", Offset = "0x113D4EC", VA = "0x113D4EC")]
		private void ExecuteCommands(List<P3dCommand> commands, bool sendNotifications, ref RenderTexture main, ref RenderTexture swap, ref Mesh preparedMesh, ref Matrix4x4 preparedMatrix)
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x113D864", Offset = "0x113D864", VA = "0x113D864")]
		public P3dPaintableTexture()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public abstract class P3dPaintableTextureMonitor : MonoBehaviour
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dPaintableTexture paintableTexture;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dPaintableTexture registeredPaintableTexture;

		[Token(Token = "0x17000177")]
		public P3dPaintableTexture PaintableTexture
		{
			[Token(Token = "0x6000838")]
			[Address(RVA = "0x113DB24", Offset = "0x113DB24", VA = "0x113DB24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x113DA3C", Offset = "0x113DA3C", VA = "0x113DA3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public bool Registered
		{
			[Token(Token = "0x6000839")]
			[Address(RVA = "0x113DB2C", Offset = "0x113DB2C", VA = "0x113DB2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x113DA44", Offset = "0x113DA44", VA = "0x113DA44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F69C", Offset = "0xB6F69C")]
		public void Register()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x113DB9C", Offset = "0x113DB9C", VA = "0x113DB9C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F6D4", Offset = "0xB6F6D4")]
		public void Unregister()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x113DC70", Offset = "0x113DC70", VA = "0x113DC70", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x113DC74", Offset = "0x113DC74", VA = "0x113DC74", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x113DC78", Offset = "0x113DC78", VA = "0x113DC78", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600083F")]
		protected abstract void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview);

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x113DC80", Offset = "0x113DC80", VA = "0x113DC80")]
		private void HandleModified(bool preview)
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x113DD28", Offset = "0x113DD28", VA = "0x113DD28")]
		protected P3dPaintableTextureMonitor()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public abstract class P3dPaintableTextureMonitorMask : P3dPaintableTextureMonitor
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Mesh mesh;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected int total;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected bool baked;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Mesh bakedMesh;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector2Int bakedSize;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<bool> bakedPixels;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material cachedMaterial;

		[Token(Token = "0x17000179")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x113DD38", Offset = "0x113DD38", VA = "0x113DD38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x113DD30", Offset = "0x113DD30", VA = "0x113DD30")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public int Total
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x113DD40", Offset = "0x113DD40", VA = "0x113DD40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x113DD48", Offset = "0x113DD48", VA = "0x113DD48", Slot = "8")]
		protected virtual void ClearBake()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x113DDF0", Offset = "0x113DDF0", VA = "0x113DDF0")]
		protected void UpdateTotal(RenderTexture temporary, int width, int height, RenderTextureFormat format, int scale)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x113DF48", Offset = "0x113DF48", VA = "0x113DF48")]
		private void Bake(RenderTexture temporary, int width, int height, RenderTextureFormat format, int scale)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x113E48C", Offset = "0x113E48C", VA = "0x113E48C")]
		protected P3dPaintableTextureMonitorMask()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A300", Offset = "0xB6A300")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A300", Offset = "0xB6A300")]
	public class P3dPaintDecal : MonoBehaviour, IHit, IHitPoint, IHitLine, IHitQuad, IHitRaycast
	{
		[Token(Token = "0x20001C9")]
		public enum PaintType
		{
			[Token(Token = "0x4000820")]
			In3D,
			[Token(Token = "0x4000821")]
			OnUV
		}

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dModel targetModel;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private P3dPaintableTexture targetTexture;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PaintType paint;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Texture shape;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private P3dChannel shapeChannel;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CA4C", Offset = "0xB6CA4C")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CA8C", Offset = "0xB6CA8C")]
		[SerializeField]
		private float angle;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private Vector3 scale;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CB04", Offset = "0xB6CB04")]
		private float wrapping;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CB44", Offset = "0xB6CB44")]
		[SerializeField]
		private float normalFront;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CB84", Offset = "0xB6CB84")]
		[SerializeField]
		private float normalBack;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CBC4", Offset = "0xB6CBC4")]
		[SerializeField]
		private float normalFade;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Texture tileTexture;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Transform tileTransform;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6CC28", Offset = "0xB6CC28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CC28", Offset = "0xB6CC28")]
		[SerializeField]
		private float tileOpacity;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x1700017B")]
		public LayerMask Layers
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1136080", Offset = "0x1136080", VA = "0x1136080")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x1136078", Offset = "0x1136078", VA = "0x1136078")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public P3dModel TargetModel
		{
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x1136090", Offset = "0x1136090", VA = "0x1136090")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x1136088", Offset = "0x1136088", VA = "0x1136088")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public P3dGroup Group
		{
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x11360A0", Offset = "0x11360A0", VA = "0x11360A0")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x1136098", Offset = "0x1136098", VA = "0x1136098")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public P3dPaintableTexture TargetTexture
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x11360B0", Offset = "0x11360B0", VA = "0x11360B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x11360A8", Offset = "0x11360A8", VA = "0x11360A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public PaintType Paint
		{
			[Token(Token = "0x6000852")]
			[Address(RVA = "0x11360C0", Offset = "0x11360C0", VA = "0x11360C0")]
			get
			{
				return default(PaintType);
			}
			[Token(Token = "0x6000851")]
			[Address(RVA = "0x11360B8", Offset = "0x11360B8", VA = "0x11360B8")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000854")]
			[Address(RVA = "0x11360D4", Offset = "0x11360D4", VA = "0x11360D4")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000853")]
			[Address(RVA = "0x11360C8", Offset = "0x11360C8", VA = "0x11360C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public Texture Texture
		{
			[Token(Token = "0x6000856")]
			[Address(RVA = "0x11360F0", Offset = "0x11360F0", VA = "0x11360F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000855")]
			[Address(RVA = "0x11360E8", Offset = "0x11360E8", VA = "0x11360E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public Texture Shape
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0x1136100", Offset = "0x1136100", VA = "0x1136100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x11360F8", Offset = "0x11360F8", VA = "0x11360F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public P3dChannel ShapeChannel
		{
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x1136110", Offset = "0x1136110", VA = "0x1136110")]
			get
			{
				return default(P3dChannel);
			}
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1136108", Offset = "0x1136108", VA = "0x1136108")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public Color Color
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x1136124", Offset = "0x1136124", VA = "0x1136124")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1136118", Offset = "0x1136118", VA = "0x1136118")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public float Opacity
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1136138", Offset = "0x1136138", VA = "0x1136138")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1136130", Offset = "0x1136130", VA = "0x1136130")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public float Angle
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x1136148", Offset = "0x1136148", VA = "0x1136148")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1136140", Offset = "0x1136140", VA = "0x1136140")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x113615C", Offset = "0x113615C", VA = "0x113615C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x1136150", Offset = "0x1136150", VA = "0x1136150")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public float Radius
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x1136170", Offset = "0x1136170", VA = "0x1136170")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1136168", Offset = "0x1136168", VA = "0x1136168")]
			set
			{
			}
		}

		[Token(Token = "0x17000189")]
		public float Hardness
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1136180", Offset = "0x1136180", VA = "0x1136180")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x1136178", Offset = "0x1136178", VA = "0x1136178")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public float Wrapping
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1136190", Offset = "0x1136190", VA = "0x1136190")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1136188", Offset = "0x1136188", VA = "0x1136188")]
			set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public float NormalFront
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x11361A0", Offset = "0x11361A0", VA = "0x11361A0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1136198", Offset = "0x1136198", VA = "0x1136198")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public float NormalBack
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x11361B0", Offset = "0x11361B0", VA = "0x11361B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x11361A8", Offset = "0x11361A8", VA = "0x11361A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public float NormalFade
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x11361C0", Offset = "0x11361C0", VA = "0x11361C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x11361B8", Offset = "0x11361B8", VA = "0x11361B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018E")]
		public Texture TileTexture
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x11361D0", Offset = "0x11361D0", VA = "0x11361D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x11361C8", Offset = "0x11361C8", VA = "0x11361C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public Transform TileTransform
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x11361E0", Offset = "0x11361E0", VA = "0x11361E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x11361D8", Offset = "0x11361D8", VA = "0x11361D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000190")]
		public float TileOpacity
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x11361F0", Offset = "0x11361F0", VA = "0x11361F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x11361E8", Offset = "0x11361E8", VA = "0x11361E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x11361F8", Offset = "0x11361F8", VA = "0x11361F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x1136264", Offset = "0x1136264", VA = "0x1136264")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F70C", Offset = "0xB6F70C")]
		public void FlipHorizontal()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x1136274", Offset = "0x1136274", VA = "0x1136274")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F744", Offset = "0xB6F744")]
		public void FlipVertical()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x1136284", Offset = "0x1136284", VA = "0x1136284")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x1136304", Offset = "0x1136304", VA = "0x1136304")]
		public void IncrementAngle(float degrees)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x11363A4", Offset = "0x11363A4", VA = "0x11363A4")]
		public void MultiplyScale(float multiplier)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x1136440", Offset = "0x1136440", VA = "0x1136440")]
		public void MultiplyHardness(float multiplier)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1136450", Offset = "0x1136450", VA = "0x1136450", Slot = "4")]
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x1136C64", Offset = "0x1136C64", VA = "0x1136C64", Slot = "5")]
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1136EB8", Offset = "0x1136EB8", VA = "0x1136EB8", Slot = "6")]
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1137168", Offset = "0x1137168", VA = "0x1137168", Slot = "7")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1136674", Offset = "0x1136674", VA = "0x1136674")]
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1137748", Offset = "0x1137748", VA = "0x1137748")]
		public P3dPaintDecal()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A360", Offset = "0xB6A360")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A360", Offset = "0xB6A360")]
	public class P3dPaintFill : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x20001CA")]
		public enum RotationType
		{
			[Token(Token = "0x4000823")]
			World,
			[Token(Token = "0x4000824")]
			Normal
		}

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CCDC", Offset = "0xB6CCDC")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CD1C", Offset = "0xB6CD1C")]
		[SerializeField]
		private float minimum;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x17000192")]
		public P3dGroup Group
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x113785C", Offset = "0x113785C", VA = "0x113785C")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x1137854", Offset = "0x1137854", VA = "0x1137854")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000885")]
			[Address(RVA = "0x1137870", Offset = "0x1137870", VA = "0x1137870")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000884")]
			[Address(RVA = "0x1137864", Offset = "0x1137864", VA = "0x1137864")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public Texture Texture
		{
			[Token(Token = "0x6000887")]
			[Address(RVA = "0x113788C", Offset = "0x113788C", VA = "0x113788C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1137884", Offset = "0x1137884", VA = "0x1137884")]
			set
			{
			}
		}

		[Token(Token = "0x17000195")]
		public Color Color
		{
			[Token(Token = "0x6000889")]
			[Address(RVA = "0x11378A0", Offset = "0x11378A0", VA = "0x11378A0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1137894", Offset = "0x1137894", VA = "0x1137894")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public float Opacity
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x11378B4", Offset = "0x11378B4", VA = "0x11378B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088A")]
			[Address(RVA = "0x11378AC", Offset = "0x11378AC", VA = "0x11378AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public float Minimum
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x11378C4", Offset = "0x11378C4", VA = "0x11378C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600088C")]
			[Address(RVA = "0x11378BC", Offset = "0x11378BC", VA = "0x11378BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x600088E")]
			[Address(RVA = "0x11378CC", Offset = "0x11378CC", VA = "0x11378CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x1137938", Offset = "0x1137938", VA = "0x1137938")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x11379B8", Offset = "0x11379B8", VA = "0x11379B8", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1137C8C", Offset = "0x1137C8C", VA = "0x1137C8C")]
		public P3dPaintFill()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A3C0", Offset = "0xB6A3C0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A3C0", Offset = "0xB6A3C0")]
	public class P3dPaintReplace : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x17000199")]
		public P3dGroup Group
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0x11382D0", Offset = "0x11382D0", VA = "0x11382D0")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x11382C8", Offset = "0x11382C8", VA = "0x11382C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019A")]
		public Texture Texture
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0x11382E0", Offset = "0x11382E0", VA = "0x11382E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000894")]
			[Address(RVA = "0x11382D8", Offset = "0x11382D8", VA = "0x11382D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public Color Color
		{
			[Token(Token = "0x6000897")]
			[Address(RVA = "0x11382F4", Offset = "0x11382F4", VA = "0x11382F4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x11382E8", Offset = "0x11382E8", VA = "0x11382E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1138300", Offset = "0x1138300", VA = "0x1138300")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x113836C", Offset = "0x113836C", VA = "0x113836C", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x11385F8", Offset = "0x11385F8", VA = "0x11385F8")]
		public P3dPaintReplace()
		{
		}
	}
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A420", Offset = "0xB6A420")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A420", Offset = "0xB6A420")]
	public class P3dPaintReplaceChannels : MonoBehaviour, IHit, IHitRaycast
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Texture textureR;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Texture textureG;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture textureB;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Texture textureA;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector4 channelR;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Vector4 channelG;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Vector4 channelB;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector4 channelA;

		[Token(Token = "0x1700019D")]
		public P3dGroup Group
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1138634", Offset = "0x1138634", VA = "0x1138634")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x113862C", Offset = "0x113862C", VA = "0x113862C")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public Texture TextureR
		{
			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1138644", Offset = "0x1138644", VA = "0x1138644")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x113863C", Offset = "0x113863C", VA = "0x113863C")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public Texture TextureG
		{
			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1138654", Offset = "0x1138654", VA = "0x1138654")]
			get
			{
				return null;
			}
			[Token(Token = "0x600089F")]
			[Address(RVA = "0x113864C", Offset = "0x113864C", VA = "0x113864C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public Texture TextureB
		{
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1138664", Offset = "0x1138664", VA = "0x1138664")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x113865C", Offset = "0x113865C", VA = "0x113865C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public Texture TextureA
		{
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1138674", Offset = "0x1138674", VA = "0x1138674")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x113866C", Offset = "0x113866C", VA = "0x113866C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public Vector4 ChannelR
		{
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1138688", Offset = "0x1138688", VA = "0x1138688")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x113867C", Offset = "0x113867C", VA = "0x113867C")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public Vector4 ChannelG
		{
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x11386A0", Offset = "0x11386A0", VA = "0x11386A0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1138694", Offset = "0x1138694", VA = "0x1138694")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public Vector4 ChannelB
		{
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x11386B8", Offset = "0x11386B8", VA = "0x11386B8")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x11386AC", Offset = "0x11386AC", VA = "0x11386AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public Vector4 ChannelA
		{
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x11386D0", Offset = "0x11386D0", VA = "0x11386D0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x11386C4", Offset = "0x11386C4", VA = "0x11386C4")]
			set
			{
			}
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x11386DC", Offset = "0x11386DC", VA = "0x11386DC", Slot = "4")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x11388EC", Offset = "0x11388EC", VA = "0x11388EC")]
		public P3dPaintReplaceChannels()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A480", Offset = "0xB6A480")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A480", Offset = "0xB6A480")]
	public class P3dPaintSphere : MonoBehaviour, IHit, IHitPoint, IHitLine, IHitQuad, IHitRaycast
	{
		[Token(Token = "0x20001CB")]
		public enum RotationType
		{
			[Token(Token = "0x4000826")]
			World,
			[Token(Token = "0x4000827")]
			Normal
		}

		[Token(Token = "0x20001CC")]
		public enum PaintType
		{
			[Token(Token = "0x4000829")]
			In3D,
			[Token(Token = "0x400082A")]
			OnUV
		}

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask layers;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private P3dGroup group;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dModel targetModel;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private P3dPaintableTexture targetTexture;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PaintType paint;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CEAC", Offset = "0xB6CEAC")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CEEC", Offset = "0xB6CEEC")]
		[SerializeField]
		private float angle;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 scale;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private RotationType rotateTo;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Texture tileTexture;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Transform tileTransform;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6CF94", Offset = "0xB6CF94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6CF94", Offset = "0xB6CF94")]
		[SerializeField]
		private float tileOpacity;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private P3dModifierList modifiers;

		[Token(Token = "0x170001A6")]
		public LayerMask Layers
		{
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1138A10", Offset = "0x1138A10", VA = "0x1138A10")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x1138A08", Offset = "0x1138A08", VA = "0x1138A08")]
			set
			{
			}
		}

		[Token(Token = "0x170001A7")]
		public P3dGroup Group
		{
			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1138A20", Offset = "0x1138A20", VA = "0x1138A20")]
			get
			{
				return default(P3dGroup);
			}
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1138A18", Offset = "0x1138A18", VA = "0x1138A18")]
			set
			{
			}
		}

		[Token(Token = "0x170001A8")]
		public P3dModel TargetModel
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1138A30", Offset = "0x1138A30", VA = "0x1138A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1138A28", Offset = "0x1138A28", VA = "0x1138A28")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public P3dPaintableTexture TargetTexture
		{
			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1138A40", Offset = "0x1138A40", VA = "0x1138A40")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1138A38", Offset = "0x1138A38", VA = "0x1138A38")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public PaintType Paint
		{
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1138A50", Offset = "0x1138A50", VA = "0x1138A50")]
			get
			{
				return default(PaintType);
			}
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1138A48", Offset = "0x1138A48", VA = "0x1138A48")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x1138A68", Offset = "0x1138A68", VA = "0x1138A68")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1138A58", Offset = "0x1138A58", VA = "0x1138A58")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public Color Color
		{
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x1138A88", Offset = "0x1138A88", VA = "0x1138A88")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1138A7C", Offset = "0x1138A7C", VA = "0x1138A7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public float Opacity
		{
			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1138A9C", Offset = "0x1138A9C", VA = "0x1138A9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x1138A94", Offset = "0x1138A94", VA = "0x1138A94")]
			set
			{
			}
		}

		[Token(Token = "0x170001AE")]
		public float Angle
		{
			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x1138AAC", Offset = "0x1138AAC", VA = "0x1138AAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x1138AA4", Offset = "0x1138AA4", VA = "0x1138AA4")]
			set
			{
			}
		}

		[Token(Token = "0x170001AF")]
		public Vector3 Scale
		{
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1138AC0", Offset = "0x1138AC0", VA = "0x1138AC0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1138AB4", Offset = "0x1138AB4", VA = "0x1138AB4")]
			set
			{
			}
		}

		[Token(Token = "0x170001B0")]
		public RotationType RotateTo
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1138AD4", Offset = "0x1138AD4", VA = "0x1138AD4")]
			get
			{
				return default(RotationType);
			}
			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x1138ACC", Offset = "0x1138ACC", VA = "0x1138ACC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public float Radius
		{
			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x1138AE4", Offset = "0x1138AE4", VA = "0x1138AE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x1138ADC", Offset = "0x1138ADC", VA = "0x1138ADC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B2")]
		public float Hardness
		{
			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x1138AF4", Offset = "0x1138AF4", VA = "0x1138AF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1138AEC", Offset = "0x1138AEC", VA = "0x1138AEC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public Texture TileTexture
		{
			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1138B04", Offset = "0x1138B04", VA = "0x1138B04")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x1138AFC", Offset = "0x1138AFC", VA = "0x1138AFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001B4")]
		public Transform TileTransform
		{
			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x1138B14", Offset = "0x1138B14", VA = "0x1138B14")]
			get
			{
				return null;
			}
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x1138B0C", Offset = "0x1138B0C", VA = "0x1138B0C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B5")]
		public float TileOpacity
		{
			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x1138B24", Offset = "0x1138B24", VA = "0x1138B24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1138B1C", Offset = "0x1138B1C", VA = "0x1138B1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public P3dModifierList Modifiers
		{
			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x1138B2C", Offset = "0x1138B2C", VA = "0x1138B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x1138B98", Offset = "0x1138B98", VA = "0x1138B98")]
		public void IncrementOpacity(float delta)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1138C18", Offset = "0x1138C18", VA = "0x1138C18")]
		public void IncrementAngle(float degrees)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1138CB8", Offset = "0x1138CB8", VA = "0x1138CB8")]
		public void MultiplyRadius(float multiplier)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x1138CC8", Offset = "0x1138CC8", VA = "0x1138CC8")]
		public void MultiplyScale(float multiplier)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x1138D64", Offset = "0x1138D64", VA = "0x1138D64", Slot = "4")]
		public void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x113935C", Offset = "0x113935C", VA = "0x113935C", Slot = "5")]
		public void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x11395AC", Offset = "0x11395AC", VA = "0x11395AC", Slot = "6")]
		public void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1139858", Offset = "0x1139858", VA = "0x1139858", Slot = "7")]
		public void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1138F84", Offset = "0x1138F84", VA = "0x1138F84")]
		private Vector3 HandleHitCommon(bool preview, float pressure, int seed, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1139BAC", Offset = "0x1139BAC", VA = "0x1139BAC")]
		public P3dPaintSphere()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FC")]
	public struct P3dSlot
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Index;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xC37744", Offset = "0xC37744", VA = "0xC37744")]
		public P3dSlot(int newIndex, string newName)
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xC37750", Offset = "0xC37750", VA = "0xC37750")]
		public Material FindMaterial(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xC37758", Offset = "0xC37758", VA = "0xC37758")]
		public Texture FindTexture(GameObject gameObject)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xC37760", Offset = "0xC37760", VA = "0xC37760", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xC37768", Offset = "0xC37768", VA = "0xC37768", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x114666C", Offset = "0x114666C", VA = "0x114666C")]
		public static bool operator ==(P3dSlot a, P3dSlot b)
		{
			return default(bool);
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x114668C", Offset = "0x114668C", VA = "0x114668C")]
		public static bool operator !=(P3dSlot a, P3dSlot b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FD")]
	public static class P3dStateManager
	{
		[Token(Token = "0x170001B7")]
		public static bool CanUndo
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x11466AC", Offset = "0x11466AC", VA = "0x11466AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B8")]
		public static bool CanRedo
		{
			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x1146748", Offset = "0x1146748", VA = "0x1146748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x11467F0", Offset = "0x11467F0", VA = "0x11467F0")]
		public static void StoreAllStates()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1146888", Offset = "0x1146888", VA = "0x1146888")]
		public static void ClearAllStates()
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x1146920", Offset = "0x1146920", VA = "0x1146920")]
		public static void UndoAll()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x11469B8", Offset = "0x11469B8", VA = "0x11469B8")]
		public static void RedoAll()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public interface IClone
	{
		[Token(Token = "0x60008E7")]
		void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);
	}
	[Token(Token = "0x20000FF")]
	public interface IHit
	{
	}
	[Token(Token = "0x2000100")]
	public interface IHitLine
	{
		[Token(Token = "0x60008E8")]
		void HandleHitLine(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Quaternion rotation);
	}
	[Token(Token = "0x2000101")]
	public interface IHitPoint
	{
		[Token(Token = "0x60008E9")]
		void HandleHitPoint(bool preview, int priority, float pressure, int seed, Vector3 position, Quaternion rotation);
	}
	[Token(Token = "0x2000102")]
	public interface IHitQuad
	{
		[Token(Token = "0x60008EA")]
		void HandleHitQuad(bool preview, int priority, float pressure, int seed, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, Quaternion rotation);
	}
	[Token(Token = "0x2000103")]
	public interface IHitRaycast
	{
		[Token(Token = "0x60008EB")]
		void HandleHitRaycast(bool preview, int priority, float pressure, int seed, RaycastHit hit, Quaternion rotation);
	}
	[Serializable]
	[Token(Token = "0x2000104")]
	public struct P3dBlendMode
	{
		[Token(Token = "0x40004CF")]
		public const int ALPHA_BLEND = 0;

		[Token(Token = "0x40004D0")]
		public const int ALPHA_BLEND_INVERSE = 1;

		[Token(Token = "0x40004D1")]
		public const int ALPHA_BLEND_RGB = 2;

		[Token(Token = "0x40004D2")]
		public const int ADDITIVE = 3;

		[Token(Token = "0x40004D3")]
		public const int ADDITIVE_SOFT = 4;

		[Token(Token = "0x40004D4")]
		public const int SUBTRACTIVE = 5;

		[Token(Token = "0x40004D5")]
		public const int SUBTRACTIVE_SOFT = 6;

		[Token(Token = "0x40004D6")]
		public const int REPLACE = 7;

		[Token(Token = "0x40004D7")]
		public const int REPLACE_ORIGINAL = 8;

		[Token(Token = "0x40004D8")]
		public const int REPLACE_CUSTOM = 9;

		[Token(Token = "0x40004D9")]
		public const int MULTIPLY_INVERSE_RGB = 10;

		[Token(Token = "0x40004DA")]
		public const int BLUR = 11;

		[Token(Token = "0x40004DB")]
		public const int COUNT = 12;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly string[] NAMES;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Index;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Texture Texture;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color Color;

		[Token(Token = "0x170001B9")]
		public static P3dBlendMode AlphaBlend
		{
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x13442A0", Offset = "0x13442A0", VA = "0x13442A0")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BA")]
		public static P3dBlendMode AlphaBlendInverse
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x13442D0", Offset = "0x13442D0", VA = "0x13442D0")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BB")]
		public static P3dBlendMode AlphaBlendRGB
		{
			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x134430C", Offset = "0x134430C", VA = "0x134430C")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BC")]
		public static P3dBlendMode Additive
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x1344348", Offset = "0x1344348", VA = "0x1344348")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BD")]
		public static P3dBlendMode AdditiveSoft
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1344384", Offset = "0x1344384", VA = "0x1344384")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BE")]
		public static P3dBlendMode Subtractive
		{
			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x13443C0", Offset = "0x13443C0", VA = "0x13443C0")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001BF")]
		public static P3dBlendMode SubtractiveSoft
		{
			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x13443FC", Offset = "0x13443FC", VA = "0x13443FC")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C0")]
		public static P3dBlendMode Replace
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x1344438", Offset = "0x1344438", VA = "0x1344438")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C1")]
		public static P3dBlendMode ReplaceOriginal
		{
			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1344264", Offset = "0x1344264", VA = "0x1344264")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C2")]
		public static P3dBlendMode MultiplyInverseRGB
		{
			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x1344488", Offset = "0x1344488", VA = "0x1344488")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x170001C3")]
		public static P3dBlendMode Blur
		{
			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x13444C4", Offset = "0x13444C4", VA = "0x13444C4")]
			get
			{
				return default(P3dBlendMode);
			}
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x1344474", Offset = "0x1344474", VA = "0x1344474")]
		public static P3dBlendMode ReplaceCustom(Color color, Texture texture)
		{
			return default(P3dBlendMode);
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0xC3D988", Offset = "0xC3D988", VA = "0xC3D988")]
		public void Apply(Material material)
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x13445D0", Offset = "0x13445D0", VA = "0x13445D0")]
		public static string GetName(int index)
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x134467C", Offset = "0x134467C", VA = "0x134467C")]
		public static bool operator ==(P3dBlendMode a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x134468C", Offset = "0x134468C", VA = "0x134468C")]
		public static bool operator !=(P3dBlendMode a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x134469C", Offset = "0x134469C", VA = "0x134469C")]
		public static implicit operator int(P3dBlendMode a)
		{
			return default(int);
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xC3D990", Offset = "0xC3D990", VA = "0xC3D990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xC3D998", Offset = "0xC3D998", VA = "0xC3D998", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000105")]
	public enum P3dChannel
	{
		[Token(Token = "0x40004E1")]
		Red,
		[Token(Token = "0x40004E2")]
		Green,
		[Token(Token = "0x40004E3")]
		Blue,
		[Token(Token = "0x40004E4")]
		Alpha
	}
	[Token(Token = "0x2000106")]
	public abstract class P3dClone : P3dLinkedBehaviour<P3dClone>, IClone
	{
		[NonSerialized]
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int MatrixCount;

		[NonSerialized]
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int ClonerCount;

		[NonSerialized]
		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Matrix4x4> tempPosMatrices;

		[NonSerialized]
		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Matrix4x4> tempRotMatrices;

		[NonSerialized]
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<IClone> tempCloners;

		[Token(Token = "0x6000900")]
		public abstract void Transform(ref Matrix4x4 posMatrix, ref Matrix4x4 rotMatrix);

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1344AA4", Offset = "0x1344AA4", VA = "0x1344AA4")]
		public static void BuildCloners([Optional] List<IClone> cloners)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1344D64", Offset = "0x1344D64", VA = "0x1344D64")]
		public static void Clone(P3dCommand command, int clonerIndex, int matrixIndex)
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1345054", Offset = "0x1345054", VA = "0x1345054")]
		protected P3dClone()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public abstract class P3dCommand
	{
		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Preview;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Priority;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Index;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public P3dBlendMode Blend;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Material Material;

		[Token(Token = "0x170001C4")]
		public abstract bool RequireMesh
		{
			[Token(Token = "0x6000906")]
			get;
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x13457AC", Offset = "0x13457AC", VA = "0x13457AC")]
		public static int Compare(P3dCommand a, P3dCommand b)
		{
			return default(int);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x1344094", Offset = "0x1344094", VA = "0x1344094")]
		public void SetState(bool preview, int priority)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1345820", Offset = "0x1345820", VA = "0x1345820")]
		public void Apply(RenderTexture buffer)
		{
		}

		[Token(Token = "0x6000909")]
		public abstract void Apply();

		[Token(Token = "0x600090A")]
		public abstract void Pool();

		[Token(Token = "0x600090B")]
		public abstract void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix);

		[Token(Token = "0x600090C")]
		public abstract P3dCommand SpawnCopy();

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1345960", Offset = "0x1345960", VA = "0x1345960")]
		public P3dCommand SpawnCopyLocal(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1345A3C", Offset = "0x1345A3C", VA = "0x1345A3C")]
		public P3dCommand SpawnCopyWorld(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		protected T SpawnCopy<T>(Stack<T> pool) where T : P3dCommand, new()
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1345B08", Offset = "0x1345B08", VA = "0x1345B08")]
		protected P3dCommand()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class P3dCommandDecal : P3dCommand
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool In3D;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Position;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 EndPosition;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 Position2;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 EndPosition2;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int Extrusions;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Matrix4x4 Matrix;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Vector3 Direction;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public Color Color;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float Opacity;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float Hardness;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float Wrapping;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Texture Texture;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Texture Shape;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector4 ShapeChannel;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public Vector2 NormalFront;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Vector2 NormalBack;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public Texture TileTexture;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public Matrix4x4 TileMatrix;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float TileOpacity;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandDecal Instance;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandDecal> pool;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedSpotMaterials;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material[] cachedLineMaterials;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Material[] cachedQuadMaterials;

		[Token(Token = "0x170001C5")]
		public override bool RequireMesh
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0x1345B10", Offset = "0x1345B10", VA = "0x1345B10", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1345B18", Offset = "0x1345B18", VA = "0x1345B18")]
		static P3dCommandDecal()
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1345C40", Offset = "0x1345C40", VA = "0x1345C40", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1346084", Offset = "0x1346084", VA = "0x1346084", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1346108", Offset = "0x1346108", VA = "0x1346108", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x134630C", Offset = "0x134630C", VA = "0x134630C", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x134648C", Offset = "0x134648C", VA = "0x134648C")]
		public void SetShape(Quaternion rotation, Vector3 size, float angle)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x134677C", Offset = "0x134677C", VA = "0x134677C")]
		public void SetLocation(Vector3 position, bool in3D = true)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1346794", Offset = "0x1346794", VA = "0x1346794")]
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x13467B4", Offset = "0x13467B4", VA = "0x13467B4")]
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true)
		{
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x13467E8", Offset = "0x13467E8", VA = "0x13467E8")]
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1346824", Offset = "0x1346824", VA = "0x1346824")]
		public void ApplyAspect(Texture texture)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x13468F8", Offset = "0x13468F8", VA = "0x13468F8")]
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Texture shape, P3dChannel shapeChannel, float hardness, float wrapping, float normalBack, float normalFront, float normalFade, Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1345C38", Offset = "0x1345C38", VA = "0x1345C38")]
		public P3dCommandDecal()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class P3dCommandFill : P3dCommand
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture Texture;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Color;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float Opacity;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float Minimum;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandFill Instance;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandFill> pool;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedMaterials;

		[Token(Token = "0x170001C6")]
		public override bool RequireMesh
		{
			[Token(Token = "0x600091F")]
			[Address(RVA = "0x1346C84", Offset = "0x1346C84", VA = "0x1346C84", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1346C8C", Offset = "0x1346C8C", VA = "0x1346C8C")]
		static P3dCommandFill()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1346D6C", Offset = "0x1346D6C", VA = "0x1346D6C")]
		public static RenderTexture Blit(RenderTexture main, P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
			return null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1346F84", Offset = "0x1346F84", VA = "0x1346F84")]
		public static void Blit(ref RenderTexture main, ref RenderTexture swap, P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1347198", Offset = "0x1347198", VA = "0x1347198", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x13472D0", Offset = "0x13472D0", VA = "0x13472D0", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1347354", Offset = "0x1347354", VA = "0x1347354", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1347358", Offset = "0x1347358", VA = "0x1347358", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x13440A4", Offset = "0x13440A4", VA = "0x13440A4")]
		public void SetMaterial(P3dBlendMode blendMode, Texture texture, Color color, float opacity, float minimum)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1346D64", Offset = "0x1346D64", VA = "0x1346D64")]
		public P3dCommandFill()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class P3dCommandReplace : P3dCommand
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture Texture;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Color Color;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandReplace Instance;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandReplace> pool;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material cachedMaterial;

		[Token(Token = "0x170001C7")]
		public override bool RequireMesh
		{
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1347410", Offset = "0x1347410", VA = "0x1347410", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1347418", Offset = "0x1347418", VA = "0x1347418")]
		static P3dCommandReplace()
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x13474F4", Offset = "0x13474F4", VA = "0x13474F4")]
		public static void Blit(RenderTexture renderTexture, Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x13476F0", Offset = "0x13476F0", VA = "0x13476F0")]
		public static void BlitFast(RenderTexture renderTexture, Texture texture, Color tint)
		{
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1347810", Offset = "0x1347810", VA = "0x1347810", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x13478C4", Offset = "0x13478C4", VA = "0x13478C4", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1347948", Offset = "0x1347948", VA = "0x1347948", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x134794C", Offset = "0x134794C", VA = "0x134794C", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x134760C", Offset = "0x134760C", VA = "0x134760C")]
		public void SetMaterial(Texture texture, Color color)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x13474EC", Offset = "0x13474EC", VA = "0x13474EC")]
		public P3dCommandReplace()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class P3dCommandReplaceChannels : P3dCommand
	{
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture TextureR;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Texture TextureG;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Texture TextureB;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture TextureA;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector4 ChannelR;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector4 ChannelG;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector4 ChannelB;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector4 ChannelA;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandReplaceChannels Instance;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandReplaceChannels> pool;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material cachedMaterial;

		[Token(Token = "0x170001C8")]
		public override bool RequireMesh
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x13479F4", Offset = "0x13479F4", VA = "0x13479F4", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x13479FC", Offset = "0x13479FC", VA = "0x13479FC")]
		static P3dCommandReplaceChannels()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1347AD8", Offset = "0x1347AD8", VA = "0x1347AD8")]
		public static void Blit(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1347E30", Offset = "0x1347E30", VA = "0x1347E30")]
		public static void BlitFast(RenderTexture renderTexture, Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1348020", Offset = "0x1348020", VA = "0x1348020", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x13481A0", Offset = "0x13481A0", VA = "0x13481A0", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1348224", Offset = "0x1348224", VA = "0x1348224", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1348228", Offset = "0x1348228", VA = "0x1348228", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1347CC0", Offset = "0x1347CC0", VA = "0x1347CC0")]
		public void SetMaterial(Texture textureR, Texture textureG, Texture textureB, Texture textureA, Vector4 channelR, Vector4 channelG, Vector4 channelB, Vector4 channelA)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1347AD0", Offset = "0x1347AD0", VA = "0x1347AD0")]
		public P3dCommandReplaceChannels()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class P3dCommandSphere : P3dCommand
	{
		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool In3D;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Position;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 EndPosition;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 Position2;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Vector3 EndPosition2;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int Extrusions;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Matrix4x4 Matrix;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Color Color;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float Opacity;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float Hardness;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Texture TileTexture;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Matrix4x4 TileMatrix;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float TileOpacity;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static P3dCommandSphere Instance;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Stack<P3dCommandSphere> pool;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material[] cachedSpotMaterials;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material[] cachedLineMaterials;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Material[] cachedQuadMaterials;

		[Token(Token = "0x170001C9")]
		public override bool RequireMesh
		{
			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1348310", Offset = "0x1348310", VA = "0x1348310", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x1348318", Offset = "0x1348318", VA = "0x1348318")]
		static P3dCommandSphere()
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1348440", Offset = "0x1348440", VA = "0x1348440", Slot = "5")]
		public override void Apply()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x1348760", Offset = "0x1348760", VA = "0x1348760", Slot = "6")]
		public override void Pool()
		{
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x13487E4", Offset = "0x13487E4", VA = "0x13487E4", Slot = "7")]
		public override void Transform(Matrix4x4 posMatrix, Matrix4x4 rotMatrix)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x134898C", Offset = "0x134898C", VA = "0x134898C", Slot = "8")]
		public override P3dCommand SpawnCopy()
		{
			return null;
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x1348ABC", Offset = "0x1348ABC", VA = "0x1348ABC")]
		public void SetLocation(Vector3 position, bool in3D = true)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1348AD4", Offset = "0x1348AD4", VA = "0x1348AD4")]
		public void SetLocation(Vector3 position, Vector3 endPosition, bool in3D = true)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1348AF4", Offset = "0x1348AF4", VA = "0x1348AF4")]
		public void SetLocation(Vector3 positionA, Vector3 positionB, Vector3 positionC, bool in3D = true)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1348B28", Offset = "0x1348B28", VA = "0x1348B28")]
		public void SetLocation(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2, bool in3D = true)
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1348B64", Offset = "0x1348B64", VA = "0x1348B64")]
		public void ApplyAspect(Texture texture)
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1348C38", Offset = "0x1348C38", VA = "0x1348C38")]
		public void SetShape(float radius)
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1348D98", Offset = "0x1348D98", VA = "0x1348D98")]
		public void SetShape(Quaternion rotation, Vector3 size, float angle)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1348FA0", Offset = "0x1348FA0", VA = "0x1348FA0")]
		public void SetMaterial(P3dBlendMode blendMode, float hardness, Color color, float opacity, Texture tileTexture, Matrix4x4 tileMatrix, float tileOpacity)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1348438", Offset = "0x1348438", VA = "0x1348438")]
		public P3dCommandSphere()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public enum P3dCoord
	{
		[Token(Token = "0x4000532")]
		First,
		[Token(Token = "0x4000533")]
		Second,
		[Token(Token = "0x4000534")]
		Third,
		[Token(Token = "0x4000535")]
		Fourth
	}
	[Token(Token = "0x200010E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A4E0", Offset = "0xB6A4E0")]
	public class P3dCoordCopier : ScriptableObject
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh source;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Mesh mesh;

		[NonSerialized]
		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<BoneWeight> boneWeights;

		[NonSerialized]
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<Color32> colors;

		[NonSerialized]
		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Vector3> positions;

		[NonSerialized]
		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Vector3> normals;

		[NonSerialized]
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Vector4> tangents;

		[NonSerialized]
		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Vector4> coords0;

		[NonSerialized]
		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<Vector4> coords1;

		[NonSerialized]
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<Vector4> coords2;

		[NonSerialized]
		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<Vector4> coords3;

		[NonSerialized]
		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static List<int> indices;

		[Token(Token = "0x170001CA")]
		public Mesh Source
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x134ADC0", Offset = "0x134ADC0", VA = "0x134ADC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600094C")]
			[Address(RVA = "0x134ADB8", Offset = "0x134ADB8", VA = "0x134ADB8")]
			set
			{
			}
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x134ADC8", Offset = "0x134ADC8", VA = "0x134ADC8")]
		public void Generate()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x134B40C", Offset = "0x134B40C", VA = "0x134B40C", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x134B480", Offset = "0x134B480", VA = "0x134B480")]
		public P3dCoordCopier()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public struct P3dGroup
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private int index;

		[Token(Token = "0x6000952")]
		[Address(RVA = "0xC3D9A0", Offset = "0xC3D9A0", VA = "0xC3D9A0")]
		public P3dGroup(int newIndex)
		{
		}

		[Token(Token = "0x6000953")]
		[Address(RVA = "0x134B66C", Offset = "0x134B66C", VA = "0x134B66C")]
		public static implicit operator int(P3dGroup group)
		{
			return default(int);
		}

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x134B670", Offset = "0x134B670", VA = "0x134B670")]
		public static implicit operator P3dGroup(int index)
		{
			return default(P3dGroup);
		}

		[Token(Token = "0x6000955")]
		[Address(RVA = "0xC3D9A8", Offset = "0xC3D9A8", VA = "0xC3D9A8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public class P3dGroupData : ScriptableObject
	{
		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int index;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Color defaultColor;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Texture defaultTexture;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<P3dGroupData> cachedInstances;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool cachedInstancesSet;

		[Token(Token = "0x170001CB")]
		public int Index
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x134B688", Offset = "0x134B688", VA = "0x134B688")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x134B680", Offset = "0x134B680", VA = "0x134B680")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public Color DefaultColor
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x134B69C", Offset = "0x134B69C", VA = "0x134B69C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x134B690", Offset = "0x134B690", VA = "0x134B690")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public Texture DefaultTexture
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x134B6B0", Offset = "0x134B6B0", VA = "0x134B6B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x134B6A8", Offset = "0x134B6A8", VA = "0x134B6A8")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public static List<P3dGroupData> CachedInstances
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x134B7D4", Offset = "0x134B7D4", VA = "0x134B7D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x134B6B8", Offset = "0x134B6B8", VA = "0x134B6B8")]
		public string GetName(bool prefixNumber)
		{
			return null;
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x134B768", Offset = "0x134B768", VA = "0x134B768")]
		public static void UpdateCachedInstances()
		{
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0x134B87C", Offset = "0x134B87C", VA = "0x134B87C")]
		public static string GetGroupName(int index, bool prefixNumber)
		{
			return null;
		}

		[Token(Token = "0x6000960")]
		[Address(RVA = "0x134B954", Offset = "0x134B954", VA = "0x134B954")]
		public static P3dGroupData GetGroupData(int index)
		{
			return null;
		}

		[Token(Token = "0x6000961")]
		[Address(RVA = "0x134BAC4", Offset = "0x134BAC4", VA = "0x134BAC4")]
		public P3dGroupData()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public static class P3dHelper
	{
		[Token(Token = "0x4000548")]
		public const string HelpUrlPrefix = "http://carloswilkes.github.io/Documentation/PaintIn3D#";

		[Token(Token = "0x4000549")]
		public const string ComponentMenuPrefix = "Paint in 3D/";

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int uniqueSeed;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<UnityEngine.Random.State> states;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Mesh sphereMesh;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool sphereMeshSet;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Mesh quadMesh;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static bool quadMeshSet;

		[Token(Token = "0x6000963")]
		[Address(RVA = "0x134BB40", Offset = "0x134BB40", VA = "0x134BB40")]
		public static void BeginUniqueSeed()
		{
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x134BBD4", Offset = "0x134BBD4", VA = "0x134BBD4")]
		public static void BeginSeed(int seed)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x134BC80", Offset = "0x134BC80", VA = "0x134BC80")]
		public static void EndSeed()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x134BD84", Offset = "0x134BD84", VA = "0x134BD84")]
		public static Quaternion NormalToCameraRotation(Vector3 normal, [Optional] Camera optionalCamera)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x134BF24", Offset = "0x134BF24", VA = "0x134BF24")]
		public static Camera GetCamera([Optional] Camera camera)
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x134BFC8", Offset = "0x134BFC8", VA = "0x134BFC8")]
		public static Vector3 GetCameraUp([Optional] Camera camera)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x134C0BC", Offset = "0x134C0BC", VA = "0x134C0BC")]
		public static bool IndexInMask(int index, int mask)
		{
			return default(bool);
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1346ED4", Offset = "0x1346ED4", VA = "0x1346ED4")]
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc)
		{
			return null;
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x134C0D4", Offset = "0x134C0D4", VA = "0x134C0D4")]
		public static RenderTexture GetRenderTexture(RenderTextureDescriptor desc, bool sRGB)
		{
			return null;
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1342B18", Offset = "0x1342B18", VA = "0x1342B18")]
		public static RenderTexture ReleaseRenderTexture(RenderTexture renderTexture)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x134C1B0", Offset = "0x134C1B0", VA = "0x134C1B0")]
		public static bool CanReadPixels(TextureFormat format)
		{
			return default(bool);
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x134C1E4", Offset = "0x134C1E4", VA = "0x134C1E4")]
		public static void ReadPixelsLinearGamma(Texture2D texture2D, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x134C40C", Offset = "0x134C40C", VA = "0x134C40C")]
		public static void ReadPixels(Texture2D texture2D, RenderTexture renderTexture)
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x13425B4", Offset = "0x13425B4", VA = "0x13425B4")]
		public static bool Downsample(RenderTexture renderTexture, int steps, ref RenderTexture temporary)
		{
			return default(bool);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x134C684", Offset = "0x134C684", VA = "0x134C684")]
		public static bool HasMipMaps(Texture texture)
		{
			return default(bool);
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x134C800", Offset = "0x134C800", VA = "0x134C800")]
		public static Mesh GetSphereMesh()
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x134C930", Offset = "0x134C930", VA = "0x134C930")]
		public static Mesh GetQuadMesh()
		{
			return null;
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1342B34", Offset = "0x1342B34", VA = "0x1342B34")]
		public static Texture2D GetReadableCopy(RenderTexture renderTexture, TextureFormat format = TextureFormat.ARGB32, bool mipMaps = false)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x134CA60", Offset = "0x134CA60", VA = "0x134CA60")]
		public static Texture2D GetReadableCopy(Texture texture, TextureFormat format = TextureFormat.ARGB32, bool mipMaps = false, int width = 0, int height = 0)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x134CCEC", Offset = "0x134CCEC", VA = "0x134CCEC")]
		public static void SaveBytes(string saveName, byte[] data, bool save = true)
		{
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x134CD9C", Offset = "0x134CD9C", VA = "0x134CD9C")]
		public static byte[] LoadBytes(string saveName)
		{
			return null;
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x134CE30", Offset = "0x134CE30", VA = "0x134CE30")]
		public static bool SaveExists(string saveName)
		{
			return default(bool);
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x134CE38", Offset = "0x134CE38", VA = "0x134CE38")]
		public static void ClearSave(string saveName, bool save = true)
		{
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x134CE84", Offset = "0x134CE84", VA = "0x134CE84")]
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x134CF38", Offset = "0x134CF38", VA = "0x134CF38")]
		public static Vector3 GetPosition(Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x134D040", Offset = "0x134D040", VA = "0x134D040")]
		public static float GetRadius(Vector3 size)
		{
			return default(float);
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x134D120", Offset = "0x134D120", VA = "0x134D120")]
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition)
		{
			return default(float);
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x134D240", Offset = "0x134D240", VA = "0x134D240")]
		public static float GetRadius(Vector3 size, Vector3 position, Vector3 endPosition, Vector3 position2, Vector3 endPosition2)
		{
			return default(float);
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x134D4C8", Offset = "0x134D4C8", VA = "0x134D4C8")]
		public static Vector3 ScaleAspect(Vector3 size, float aspect)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x134D4E4", Offset = "0x134D4E4", VA = "0x134D4E4")]
		public static float GetAspect(Texture textureA, [Optional] Texture textureB)
		{
			return default(float);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x134D5F4", Offset = "0x134D5F4", VA = "0x134D5F4")]
		public static void Blit(RenderTexture renderTexture, Texture other)
		{
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1347104", Offset = "0x1347104", VA = "0x1347104")]
		public static void Blit(RenderTexture renderTexture, Material material)
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1346BBC", Offset = "0x1346BBC", VA = "0x1346BBC")]
		public static Vector4 IndexToVector(int index)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x134D788", Offset = "0x134D788", VA = "0x134D788")]
		public static void Draw(Material material, Mesh mesh, Matrix4x4 matrix, int subMesh, P3dCoord coord)
		{
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x134D688", Offset = "0x134D688", VA = "0x134D688")]
		public static void Draw(Material material)
		{
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x134D8D8", Offset = "0x134D8D8", VA = "0x134D8D8")]
		public static Texture2D CreateTexture(int width, int height, TextureFormat format, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x134D978", Offset = "0x134D978", VA = "0x134D978")]
		public static Material GetMaterial(GameObject gameObject, int materialIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x134DAA4", Offset = "0x134DAA4", VA = "0x134DAA4")]
		public static Material CloneMaterial(GameObject gameObject, int materialIndex = 0)
		{
			return null;
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x134DC48", Offset = "0x134DC48", VA = "0x134DC48")]
		public static Material AddMaterial(Renderer renderer, Shader shader, int materialIndex = -1)
		{
			return null;
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1346C6C", Offset = "0x1346C6C", VA = "0x1346C6C")]
		public static float Reciprocal(float a)
		{
			return default(float);
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x134DD9C", Offset = "0x134DD9C", VA = "0x134DD9C")]
		public static float Divide(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x134DDB0", Offset = "0x134DDB0", VA = "0x134DDB0")]
		public static int Mod(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x134DDC4", Offset = "0x134DDC4", VA = "0x134DDC4")]
		public static Vector3 Reciprocal3(Vector3 xyz)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x134DE68", Offset = "0x134DE68", VA = "0x134DE68")]
		public static float DampenFactor(float dampening, float elapsed)
		{
			return default(float);
		}

		[Token(Token = "0x6000990")]
		public static T Destroy<T>(T o) where T : UnityEngine.Object
		{
			return null;
		}
	}
	[Token(Token = "0x2000112")]
	public abstract class P3dLinkedBehaviour<T> : MonoBehaviour where T : P3dLinkedBehaviour<T>
	{
		[NonSerialized]
		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static T FirstInstance;

		[NonSerialized]
		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int InstanceCount;

		[NonSerialized]
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T PrevInstance;

		[NonSerialized]
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T NextInstance;

		[Token(Token = "0x6000992")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000993")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000994")]
		protected P3dLinkedBehaviour()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000113")]
	public abstract class P3dModifier
	{
		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool preview;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool unique;

		[Token(Token = "0x170001CF")]
		public bool Preview
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x1354260", Offset = "0x1354260", VA = "0x1354260")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1354254", Offset = "0x1354254", VA = "0x1354254")]
			set
			{
			}
		}

		[Token(Token = "0x170001D0")]
		public bool Unique
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1354274", Offset = "0x1354274", VA = "0x1354274")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1354268", Offset = "0x1354268", VA = "0x1354268")]
			set
			{
			}
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x135427C", Offset = "0x135427C", VA = "0x135427C")]
		public void ModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x1354340", Offset = "0x1354340", VA = "0x1354340", Slot = "4")]
		protected virtual void OnModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1354344", Offset = "0x1354344", VA = "0x1354344")]
		public void ModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x1354408", Offset = "0x1354408", VA = "0x1354408", Slot = "5")]
		protected virtual void OnModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x135440C", Offset = "0x135440C", VA = "0x135440C")]
		public void ModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x13544D0", Offset = "0x13544D0", VA = "0x13544D0", Slot = "6")]
		protected virtual void OnModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x13544D4", Offset = "0x13544D4", VA = "0x13544D4")]
		public void ModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1354598", Offset = "0x1354598", VA = "0x1354598", Slot = "7")]
		protected virtual void OnModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x135459C", Offset = "0x135459C", VA = "0x135459C")]
		public void ModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1354660", Offset = "0x1354660", VA = "0x1354660", Slot = "8")]
		protected virtual void OnModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1354664", Offset = "0x1354664", VA = "0x1354664")]
		public void ModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1354728", Offset = "0x1354728", VA = "0x1354728", Slot = "9")]
		protected virtual void OnModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x135472C", Offset = "0x135472C", VA = "0x135472C")]
		public void ModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x13547F0", Offset = "0x13547F0", VA = "0x13547F0", Slot = "10")]
		protected virtual void OnModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x13547F4", Offset = "0x13547F4", VA = "0x13547F4")]
		protected P3dModifier()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000114")]
	public class P3dModifierList : ISerializationCallbackReceiver
	{
		[NonSerialized]
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<P3dModifier> modifiers;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<string> types;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> jsons;

		[Token(Token = "0x170001D1")]
		public int Count
		{
			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1354804", Offset = "0x1354804", VA = "0x1354804")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x1354858", Offset = "0x1354858", VA = "0x1354858")]
		public void ModifyAngle(ref float angle, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x135498C", Offset = "0x135498C", VA = "0x135498C")]
		public void ModifyColor(ref Color color, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1354AC0", Offset = "0x1354AC0", VA = "0x1354AC0")]
		public void ModifyHardness(ref float hardness, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1354BF4", Offset = "0x1354BF4", VA = "0x1354BF4")]
		public void ModifyOpacity(ref float opacity, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1354D28", Offset = "0x1354D28", VA = "0x1354D28")]
		public void ModifyRadius(ref float radius, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1354E5C", Offset = "0x1354E5C", VA = "0x1354E5C")]
		public void ModifyTexture(ref Texture texture, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1354F90", Offset = "0x1354F90", VA = "0x1354F90")]
		public void ModifyPosition(ref Vector3 position, bool preview, float pressure)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x13550C4", Offset = "0x13550C4", VA = "0x13550C4", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x13553C4", Offset = "0x13553C4", VA = "0x13553C4", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x13555F8", Offset = "0x13555F8", VA = "0x13555F8")]
		public P3dModifierList()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	public class P3dModifyAngleRandom : P3dModifier
	{
		[Token(Token = "0x20001CD")]
		public enum BlendType
		{
			[Token(Token = "0x400082C")]
			Replace,
			[Token(Token = "0x400082D")]
			Multiply,
			[Token(Token = "0x400082E")]
			Increment
		}

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D2")]
		public float Min
		{
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x1355608", Offset = "0x1355608", VA = "0x1355608")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x1355600", Offset = "0x1355600", VA = "0x1355600")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public float Max
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1355618", Offset = "0x1355618", VA = "0x1355618")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x1355610", Offset = "0x1355610", VA = "0x1355610")]
			set
			{
			}
		}

		[Token(Token = "0x170001D4")]
		public BlendType Blend
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1355628", Offset = "0x1355628", VA = "0x1355628")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1355620", Offset = "0x1355620", VA = "0x1355620")]
			set
			{
			}
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x1355630", Offset = "0x1355630", VA = "0x1355630", Slot = "4")]
		protected override void OnModifyAngle(ref float angle, float pressure)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x135568C", Offset = "0x135568C", VA = "0x135568C")]
		public P3dModifyAngleRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000116")]
	public class P3dModifyColorRandom : P3dModifier
	{
		[Token(Token = "0x20001CE")]
		public enum BlendType
		{
			[Token(Token = "0x4000830")]
			Replace,
			[Token(Token = "0x4000831")]
			Multiply,
			[Token(Token = "0x4000832")]
			Increment
		}

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Gradient gradient;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D5")]
		public Gradient Gradient
		{
			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x135571C", Offset = "0x135571C", VA = "0x135571C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D6")]
		public BlendType Blend
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1355790", Offset = "0x1355790", VA = "0x1355790")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x1355788", Offset = "0x1355788", VA = "0x1355788")]
			set
			{
			}
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1355798", Offset = "0x1355798", VA = "0x1355798", Slot = "5")]
		protected override void OnModifyColor(ref Color color, float pressure)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x135583C", Offset = "0x135583C", VA = "0x135583C")]
		public P3dModifyColorRandom()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class P3dModifyHardnessPressure : P3dModifier
	{
		[Token(Token = "0x20001CF")]
		public enum BlendType
		{
			[Token(Token = "0x4000834")]
			Replace,
			[Token(Token = "0x4000835")]
			Multiply,
			[Token(Token = "0x4000836")]
			Increment
		}

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float hardness;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D7")]
		public float Hardness
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x13558C8", Offset = "0x13558C8", VA = "0x13558C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x13558C0", Offset = "0x13558C0", VA = "0x13558C0")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public BlendType Blend
		{
			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x13558D8", Offset = "0x13558D8", VA = "0x13558D8")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x13558D0", Offset = "0x13558D0", VA = "0x13558D0")]
			set
			{
			}
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x13558E0", Offset = "0x13558E0", VA = "0x13558E0", Slot = "6")]
		protected override void OnModifyHardness(ref float currentHardness, float pressure)
		{
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x1355938", Offset = "0x1355938", VA = "0x1355938")]
		public P3dModifyHardnessPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000118")]
	public class P3dModifyHardnessRandom : P3dModifier
	{
		[Token(Token = "0x20001D0")]
		public enum BlendType
		{
			[Token(Token = "0x4000838")]
			Replace,
			[Token(Token = "0x4000839")]
			Multiply,
			[Token(Token = "0x400083A")]
			Increment
		}

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001D9")]
		public float Min
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x13559CC", Offset = "0x13559CC", VA = "0x13559CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x13559C4", Offset = "0x13559C4", VA = "0x13559C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public float Max
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x13559DC", Offset = "0x13559DC", VA = "0x13559DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x13559D4", Offset = "0x13559D4", VA = "0x13559D4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public BlendType Blend
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x13559EC", Offset = "0x13559EC", VA = "0x13559EC")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x13559E4", Offset = "0x13559E4", VA = "0x13559E4")]
			set
			{
			}
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x13559F4", Offset = "0x13559F4", VA = "0x13559F4", Slot = "6")]
		protected override void OnModifyHardness(ref float hardness, float pressure)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x1355A50", Offset = "0x1355A50", VA = "0x1355A50")]
		public P3dModifyHardnessRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000119")]
	public class P3dModifyOpacityPressure : P3dModifier
	{
		[Token(Token = "0x20001D1")]
		public enum BlendType
		{
			[Token(Token = "0x400083C")]
			Replace,
			[Token(Token = "0x400083D")]
			Multiply,
			[Token(Token = "0x400083E")]
			Increment
		}

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float opacity;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001DC")]
		public float Opacity
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1355AEC", Offset = "0x1355AEC", VA = "0x1355AEC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1355AE4", Offset = "0x1355AE4", VA = "0x1355AE4")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public BlendType Blend
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1355AFC", Offset = "0x1355AFC", VA = "0x1355AFC")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1355AF4", Offset = "0x1355AF4", VA = "0x1355AF4")]
			set
			{
			}
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x1355B04", Offset = "0x1355B04", VA = "0x1355B04", Slot = "7")]
		protected override void OnModifyOpacity(ref float currentOpacity, float pressure)
		{
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x1355B5C", Offset = "0x1355B5C", VA = "0x1355B5C")]
		public P3dModifyOpacityPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011A")]
	public class P3dModifyOpacityRandom : P3dModifier
	{
		[Token(Token = "0x20001D2")]
		public enum BlendType
		{
			[Token(Token = "0x4000840")]
			Replace,
			[Token(Token = "0x4000841")]
			Multiply,
			[Token(Token = "0x4000842")]
			Increment
		}

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001DE")]
		public float Min
		{
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1355BF0", Offset = "0x1355BF0", VA = "0x1355BF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1355BE8", Offset = "0x1355BE8", VA = "0x1355BE8")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public float Max
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1355C00", Offset = "0x1355C00", VA = "0x1355C00")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1355BF8", Offset = "0x1355BF8", VA = "0x1355BF8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public BlendType Blend
		{
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1355C10", Offset = "0x1355C10", VA = "0x1355C10")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1355C08", Offset = "0x1355C08", VA = "0x1355C08")]
			set
			{
			}
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1355C18", Offset = "0x1355C18", VA = "0x1355C18", Slot = "7")]
		protected override void OnModifyOpacity(ref float opacity, float pressure)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1355C74", Offset = "0x1355C74", VA = "0x1355C74")]
		public P3dModifyOpacityRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011B")]
	public class P3dModifyPositionRandom : P3dModifier
	{
		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x170001E1")]
		public float Radius
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1355D10", Offset = "0x1355D10", VA = "0x1355D10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1355D08", Offset = "0x1355D08", VA = "0x1355D08")]
			set
			{
			}
		}

		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x1355D18", Offset = "0x1355D18", VA = "0x1355D18", Slot = "10")]
		protected override void OnModifyPosition(ref Vector3 position, float pressure)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x1355E04", Offset = "0x1355E04", VA = "0x1355E04")]
		public P3dModifyPositionRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011C")]
	public class P3dModifyRadiusPressure : P3dModifier
	{
		[Token(Token = "0x20001D3")]
		public enum BlendType
		{
			[Token(Token = "0x4000844")]
			Replace,
			[Token(Token = "0x4000845")]
			Multiply,
			[Token(Token = "0x4000846")]
			Increment
		}

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float radius;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001E2")]
		public float Radius
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1355E98", Offset = "0x1355E98", VA = "0x1355E98")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1355E90", Offset = "0x1355E90", VA = "0x1355E90")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public BlendType Blend
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1355EA8", Offset = "0x1355EA8", VA = "0x1355EA8")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1355EA0", Offset = "0x1355EA0", VA = "0x1355EA0")]
			set
			{
			}
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1355EB0", Offset = "0x1355EB0", VA = "0x1355EB0", Slot = "8")]
		protected override void OnModifyRadius(ref float currentRadius, float pressure)
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1355F08", Offset = "0x1355F08", VA = "0x1355F08")]
		public P3dModifyRadiusPressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011D")]
	public class P3dModifyRadiusRandom : P3dModifier
	{
		[Token(Token = "0x20001D4")]
		public enum BlendType
		{
			[Token(Token = "0x4000848")]
			Replace,
			[Token(Token = "0x4000849")]
			Multiply,
			[Token(Token = "0x400084A")]
			Increment
		}

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float min;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float max;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BlendType blend;

		[Token(Token = "0x170001E4")]
		public float Min
		{
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1355F9C", Offset = "0x1355F9C", VA = "0x1355F9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1355F94", Offset = "0x1355F94", VA = "0x1355F94")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public float Max
		{
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x1355FAC", Offset = "0x1355FAC", VA = "0x1355FAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x1355FA4", Offset = "0x1355FA4", VA = "0x1355FA4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public BlendType Blend
		{
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1355FBC", Offset = "0x1355FBC", VA = "0x1355FBC")]
			get
			{
				return default(BlendType);
			}
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x1355FB4", Offset = "0x1355FB4", VA = "0x1355FB4")]
			set
			{
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1355FC4", Offset = "0x1355FC4", VA = "0x1355FC4", Slot = "8")]
		protected override void OnModifyRadius(ref float radius, float pressure)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1356020", Offset = "0x1356020", VA = "0x1356020")]
		public P3dModifyRadiusRandom()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011E")]
	public class P3dModifyTexturePressure : P3dModifier
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float pressureMin;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float pressureMax;

		[Token(Token = "0x170001E7")]
		public Texture Texture
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x13560BC", Offset = "0x13560BC", VA = "0x13560BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x13560B4", Offset = "0x13560B4", VA = "0x13560B4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public float PressureMin
		{
			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x13560CC", Offset = "0x13560CC", VA = "0x13560CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x13560C4", Offset = "0x13560C4", VA = "0x13560C4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E9")]
		public float PressureMax
		{
			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x13560DC", Offset = "0x13560DC", VA = "0x13560DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x13560D4", Offset = "0x13560D4", VA = "0x13560D4")]
			set
			{
			}
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x13560E4", Offset = "0x13560E4", VA = "0x13560E4", Slot = "9")]
		protected override void OnModifyTexture(ref Texture currentTexture, float pressure)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1356108", Offset = "0x1356108", VA = "0x1356108")]
		public P3dModifyTexturePressure()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011F")]
	public class P3dModifyTextureRandom : P3dModifier
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string Group;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string Title;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<Texture> textures;

		[Token(Token = "0x170001EA")]
		public List<Texture> Textures
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1356198", Offset = "0x1356198", VA = "0x1356198")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x135620C", Offset = "0x135620C", VA = "0x135620C", Slot = "9")]
		protected override void OnModifyTexture(ref Texture texture, float pressure)
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x13562B0", Offset = "0x13562B0", VA = "0x13562B0")]
		public P3dModifyTextureRandom()
		{
		}
	}
	[Token(Token = "0x2000120")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A52C", Offset = "0xB6A52C")]
	public class P3dRenderingPipeline : ScriptableObject
	{
		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static P3dRenderingPipeline instance;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool isScriptable;

		[Token(Token = "0x170001EB")]
		public static bool IsScriptable
		{
			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x113E494", Offset = "0x113E494", VA = "0x113E494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000015")]
		public static event Action<bool> OnPipelineChanged
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x113E5AC", Offset = "0x113E5AC", VA = "0x113E5AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F77C", Offset = "0xB6F77C")]
			add
			{
			}
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x113E664", Offset = "0x113E664", VA = "0x113E664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB6F78C", Offset = "0xB6F78C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x113E71C", Offset = "0x113E71C", VA = "0x113E71C")]
		public P3dRenderingPipeline()
		{
		}
	}
	[Token(Token = "0x2000121")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A578", Offset = "0xB6A578")]
	public class P3dSeamFixer : ScriptableObject
	{
		[Token(Token = "0x20001D5")]
		private class Edge
		{
			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool Used;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int IndexA;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int IndexB;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector2 CoordA;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Vector2 CoordB;

			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x1144CD8", Offset = "0x1144CD8", VA = "0x1144CD8")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x20001D6")]
		private struct Point
		{
			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int Index;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector2 Coord;
		}

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float DebugScale;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh source;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB6D268", Offset = "0xB6D268")]
		[SerializeField]
		private P3dCoord coord;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float border;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Mesh mesh;

		[NonSerialized]
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<BoneWeight> boneWeights;

		[NonSerialized]
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<Color32> colors;

		[NonSerialized]
		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<Vector3> positions;

		[NonSerialized]
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static List<Vector3> normals;

		[NonSerialized]
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static List<Vector4> tangents;

		[NonSerialized]
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static List<Vector4> coords0;

		[NonSerialized]
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static List<Vector4> coords1;

		[NonSerialized]
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static List<Vector4> coords2;

		[NonSerialized]
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static List<Vector4> coords3;

		[NonSerialized]
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static List<int> indices;

		[NonSerialized]
		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static List<Edge> edges;

		[NonSerialized]
		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static List<Point> points;

		[NonSerialized]
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static List<int> insertions;

		[NonSerialized]
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static float areaThreshold;

		[NonSerialized]
		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private static float coordThreshold;

		[NonSerialized]
		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static Vector2 startCoord;

		[NonSerialized]
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static List<Vector3> deltaVertices;

		[NonSerialized]
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static List<Vector3> deltaNormals;

		[NonSerialized]
		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static List<Vector3> deltaTangents;

		[NonSerialized]
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static Mesh currentSource;

		[NonSerialized]
		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static Mesh currentOutput;

		[NonSerialized]
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static P3dCoord currentCoord;

		[NonSerialized]
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private static float currentBorder;

		[Token(Token = "0x170001EC")]
		public Mesh Source
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x11421A4", Offset = "0x11421A4", VA = "0x11421A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x114219C", Offset = "0x114219C", VA = "0x114219C")]
			set
			{
			}
		}

		[Token(Token = "0x170001ED")]
		public P3dCoord Coord
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x11421B4", Offset = "0x11421B4", VA = "0x11421B4")]
			get
			{
				return default(P3dCoord);
			}
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x11421AC", Offset = "0x11421AC", VA = "0x11421AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EE")]
		public float Threshold
		{
			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x11421C4", Offset = "0x11421C4", VA = "0x11421C4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x11421BC", Offset = "0x11421BC", VA = "0x11421BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EF")]
		public float Border
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x11421D4", Offset = "0x11421D4", VA = "0x11421D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x11421CC", Offset = "0x11421CC", VA = "0x11421CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x11421DC", Offset = "0x11421DC", VA = "0x11421DC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB6F79C", Offset = "0xB6F79C")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1142AE0", Offset = "0x1142AE0", VA = "0x1142AE0", Slot = "4")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x1142270", Offset = "0x1142270", VA = "0x1142270")]
		public static void Generate(Mesh source, ref Mesh output, P3dCoord coord, float threshold, float border)
		{
		}

		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x1142B54", Offset = "0x1142B54", VA = "0x1142B54")]
		private static void DoGenerate()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1143214", Offset = "0x1143214", VA = "0x1143214")]
		private static void AddTriangle(int a, int b, int c)
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x11448D0", Offset = "0x11448D0", VA = "0x11448D0")]
		private static void AddTriangle(int a, int b, int c, Vector2 coordA, Vector2 coordB, Vector2 coordC)
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x11449C0", Offset = "0x11449C0", VA = "0x11449C0")]
		private static void RemoveOrAddEdge(int a, int b, Vector2 coordA, Vector2 coordB)
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x11438C8", Offset = "0x11438C8", VA = "0x11438C8")]
		private static void TraceEdges(Vector2 head)
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x1144C24", Offset = "0x1144C24", VA = "0x1144C24")]
		private static bool Overlap(Vector2 delta)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1144CE0", Offset = "0x1144CE0", VA = "0x1144CE0")]
		private static void AddVertex(int index, Vector2 coord)
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x1145458", Offset = "0x1145458", VA = "0x1145458")]
		public P3dSeamFixer()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class P3dShader
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int _BaseChannel;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static int _BaseParallaxMap;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static int _BaseParallaxMap_Transform;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int _Buffer;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int _BufferSize;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int _Channel;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int _ChannelR;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int _ChannelG;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static int _ChannelB;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static int _ChannelA;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static int _Color;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static int _Direction;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static int _DstA;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static int _DstRGB;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static int _EndPosition;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static int _EndPosition2;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static int _Hardness;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int _In3D;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static int _ParallaxMap;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static int _ParallaxMap_Transform;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int _Position;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static int _Position2;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static int _ReplaceTexture;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static int _ReplaceColor;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static int _MainTex;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public static int _Matrix;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static int _Minimum;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public static int _NormalBack;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int _NormalFront;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public static int _Op;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static int _Opacity;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public static int _Shape;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static int _ShapeChannel;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static int _SrcA;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static int _SrcRGB;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static int _Texture;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static int _TextureR;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static int _TextureG;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public static int _TextureB;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public static int _TextureA;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static int _TileTexture;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public static int _TileMatrix;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public static int _TileOpacity;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static int _Wrapping;

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x1145738", Offset = "0x1145738", VA = "0x1145738")]
		static P3dShader()
		{
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x1145CFC", Offset = "0x1145CFC", VA = "0x1145CFC")]
		public static Shader Load(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x6000A1E")]
		[Address(RVA = "0x1145DE0", Offset = "0x1145DE0", VA = "0x1145DE0")]
		public static Material Build(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x6000A1F")]
		[Address(RVA = "0x1145E44", Offset = "0x1145E44", VA = "0x1145E44")]
		public static void BuildBlendMode(Material material, int index)
		{
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0x1145F24", Offset = "0x1145F24", VA = "0x1145F24")]
		public static Material[] BuildMaterialsBlendModes(string shaderName, [Optional] string keyword)
		{
			return null;
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0x113E424", Offset = "0x113E424", VA = "0x113E424")]
		public static Material BuildMaterial(string shaderName)
		{
			return null;
		}
	}
}
namespace PaintIn3D.Examples
{
	[Token(Token = "0x2000123")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A5C4", Offset = "0xB6A5C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A5C4", Offset = "0xB6A5C4")]
	public class P3dChannelCounter : P3dPaintableTextureMonitorMask
	{
		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LinkedList<P3dChannelCounter> Instances;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LinkedListNode<P3dChannelCounter> node;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int downsampleSteps;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6D2F4", Offset = "0xB6D2F4")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int solidR;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private int solidG;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int solidB;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int solidA;

		[Token(Token = "0x170001F0")]
		public int DownsampleSteps
		{
			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1340FA8", Offset = "0x1340FA8", VA = "0x1340FA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x1340FA0", Offset = "0x1340FA0", VA = "0x1340FA0")]
			set
			{
			}
		}

		[Token(Token = "0x170001F1")]
		public float Threshold
		{
			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1340FB8", Offset = "0x1340FB8", VA = "0x1340FB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1340FB0", Offset = "0x1340FB0", VA = "0x1340FB0")]
			set
			{
			}
		}

		[Token(Token = "0x170001F2")]
		public int SolidR
		{
			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1340FC0", Offset = "0x1340FC0", VA = "0x1340FC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F3")]
		public int SolidG
		{
			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1340FC8", Offset = "0x1340FC8", VA = "0x1340FC8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F4")]
		public int SolidB
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1340FD0", Offset = "0x1340FD0", VA = "0x1340FD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F5")]
		public int SolidA
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1340FD8", Offset = "0x1340FD8", VA = "0x1340FD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001F6")]
		public float RatioR
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1340FE0", Offset = "0x1340FE0", VA = "0x1340FE0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F7")]
		public float RatioG
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x1341008", Offset = "0x1341008", VA = "0x1341008")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F8")]
		public float RatioB
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1341030", Offset = "0x1341030", VA = "0x1341030")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F9")]
		public float RatioA
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1341058", Offset = "0x1341058", VA = "0x1341058")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FA")]
		public Vector4 RatioRGBA
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1341080", Offset = "0x1341080", VA = "0x1341080")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x13411AC", Offset = "0x13411AC", VA = "0x13411AC")]
		public static long GetTotal([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x1341458", Offset = "0x1341458", VA = "0x1341458")]
		public static long GetSolidR([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0x1341704", Offset = "0x1341704", VA = "0x1341704")]
		public static long GetSolidG([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x13419B0", Offset = "0x13419B0", VA = "0x13419B0")]
		public static long GetSolidB([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x1341C5C", Offset = "0x1341C5C", VA = "0x1341C5C")]
		public static long GetSolidA([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(long);
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x1341F08", Offset = "0x1341F08", VA = "0x1341F08")]
		public static Vector4 GetRatioRGBA([Optional] ICollection<P3dChannelCounter> counters)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x1342374", Offset = "0x1342374", VA = "0x1342374", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x1342408", Offset = "0x1342408", VA = "0x1342408", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x13424A0", Offset = "0x13424A0", VA = "0x13424A0", Slot = "7")]
		protected override void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview)
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1342878", Offset = "0x1342878", VA = "0x1342878")]
		private void Calculate(RenderTexture renderTexture, RenderTexture temporary, int scale)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x1342CE4", Offset = "0x1342CE4", VA = "0x1342CE4")]
		public P3dChannelCounter()
		{
		}
	}
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A634", Offset = "0xB6A634")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A634", Offset = "0xB6A634")]
	public class P3dColor : P3dLinkedBehaviour<P3dColor>
	{
		[Token(Token = "0x20001D7")]
		[SerializeField]
		private class Contribution
		{
			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dColorCounter Counter;

			[Token(Token = "0x4000853")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Solid;

			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x1343234", Offset = "0x1343234", VA = "0x1343234")]
			public Contribution()
			{
			}
		}

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Contribution> contributions;

		[Token(Token = "0x170001FB")]
		public Color Color
		{
			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0x1342D78", Offset = "0x1342D78", VA = "0x1342D78")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0x1342D6C", Offset = "0x1342D6C", VA = "0x1342D6C")]
			set
			{
			}
		}

		[Token(Token = "0x170001FC")]
		public int Total
		{
			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0x1342D84", Offset = "0x1342D84", VA = "0x1342D84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FD")]
		public int Solid
		{
			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0x1342EB8", Offset = "0x1342EB8", VA = "0x1342EB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001FE")]
		public float Ratio
		{
			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0x1342FEC", Offset = "0x1342FEC", VA = "0x1342FEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1343034", Offset = "0x1343034", VA = "0x1343034")]
		public void Contribute(P3dColorCounter counter, int solid)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x134310C", Offset = "0x134310C", VA = "0x134310C")]
		private bool TryGetContribution(P3dColorCounter counter, ref Contribution contribution)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x134323C", Offset = "0x134323C", VA = "0x134323C")]
		public P3dColor()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A694", Offset = "0xB6A694")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A694", Offset = "0xB6A694")]
	public class P3dColorCounter : P3dPaintableTextureMonitorMask
	{
		[Token(Token = "0x20001D8")]
		public class Contribution
		{
			[Token(Token = "0x4000854")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public P3dColor Color;

			[Token(Token = "0x4000855")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int Count;

			[Token(Token = "0x4000856")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float Ratio;

			[Token(Token = "0x4000857")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public byte R;

			[Token(Token = "0x4000858")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public byte G;

			[Token(Token = "0x4000859")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
			public byte B;

			[Token(Token = "0x400085A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
			public byte A;

			[Token(Token = "0x400085B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Stack<Contribution> Pool;

			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x1343C88", Offset = "0x1343C88", VA = "0x1343C88")]
			public Contribution()
			{
			}
		}

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LinkedList<P3dColorCounter> Instances;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private LinkedListNode<P3dColorCounter> node;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int downsampleSteps;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6D3A4", Offset = "0xB6D3A4")]
		[SerializeField]
		private float threshold;

		[NonSerialized]
		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Contribution> contributions;

		[Token(Token = "0x170001FF")]
		public int DownsampleSteps
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1343294", Offset = "0x1343294", VA = "0x1343294")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x134328C", Offset = "0x134328C", VA = "0x134328C")]
			set
			{
			}
		}

		[Token(Token = "0x17000200")]
		public float Threshold
		{
			[Token(Token = "0x6000A46")]
			[Address(RVA = "0x13432A4", Offset = "0x13432A4", VA = "0x13432A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x134329C", Offset = "0x134329C", VA = "0x134329C")]
			set
			{
			}
		}

		[Token(Token = "0x17000201")]
		public List<Contribution> Contributions
		{
			[Token(Token = "0x6000A47")]
			[Address(RVA = "0x13432AC", Offset = "0x13432AC", VA = "0x13432AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x13432B4", Offset = "0x13432B4", VA = "0x13432B4", Slot = "4")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x134334C", Offset = "0x134334C", VA = "0x134334C", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x13435A4", Offset = "0x13435A4", VA = "0x13435A4", Slot = "7")]
		protected override void UpdateMonitor(P3dPaintableTexture paintableTexture, bool preview)
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x13436B0", Offset = "0x13436B0", VA = "0x13436B0")]
		private void Calculate(RenderTexture renderTexture, RenderTexture temporary, int scale)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x1343B8C", Offset = "0x1343B8C", VA = "0x1343B8C")]
		private void ClearContributions()
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x13439FC", Offset = "0x13439FC", VA = "0x13439FC")]
		private void PrepareContributions()
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x13433EC", Offset = "0x13433EC", VA = "0x13433EC")]
		private void Contribute(int scale)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x1343C90", Offset = "0x1343C90", VA = "0x1343C90")]
		public P3dColorCounter()
		{
		}
	}
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB6A704", Offset = "0xB6A704")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB6A704", Offset = "0xB6A704")]
	public class P3dGraduallyFade : MonoBehaviour
	{
		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private P3dPaintableTexture paintableTexture;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private P3dBlendMode blendMode;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Texture texture;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB6D424", Offset = "0xB6D424")]
		[SerializeField]
		private float threshold;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float speed;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float counter;

		[Token(Token = "0x17000202")]
		public P3dPaintableTexture PaintableTexture
		{
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x1343DFC", Offset = "0x1343DFC", VA = "0x1343DFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x1343DF4", Offset = "0x1343DF4", VA = "0x1343DF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000203")]
		public P3dBlendMode BlendMode
		{
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x1343E10", Offset = "0x1343E10", VA = "0x1343E10")]
			get
			{
				return default(P3dBlendMode);
			}
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x1343E04", Offset = "0x1343E04", VA = "0x1343E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public Texture Texture
		{
			[Token(Token = "0x6000A56")]
			[Address(RVA = "0x1343E2C", Offset = "0x1343E2C", VA = "0x1343E2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A55")]
			[Address(RVA = "0x1343E24", Offset = "0x1343E24", VA = "0x1343E24")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		public Color Color
		{
			[Token(Token = "0x6000A58")]
			[Address(RVA = "0x1343E40", Offset = "0x1343E40", VA = "0x1343E40")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000A57")]
			[Address(RVA = "0x1343E34", Offset = "0x1343E34", VA = "0x1343E34")]
			set
			{
			}
		}

		[Token(Token = "0x17000206")]
		public float Threshold
		{
			[Token(Token = "0x6000A5A")]
			[Address(RVA = "0x1343E54", Offset = "0x1343E54", VA = "0x1343E54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A59")]
			[Address(RVA = "0x1343E4C", Offset = "0x1343E4C", VA = "0x1343E4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000207")]
		public float Speed
		{
			[Token(Token = "0x6000A5C")]
			[Address(RVA = "0x1343E64", Offset = "0x1343E64", VA = "0x1343E64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A5B")]
			[Address(RVA = "0x1343E5C", Offset = "0x1343E5C", VA = "0x1343E5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1343E6C", Offset = "0x1343E6C", VA = "0x1343E6C", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x13441BC", Offset = "0x13441BC", VA = "0x13441BC")]
		public P3dGraduallyFade()
		{
		}
	}
}
namespace Array2DEditor
{
	[Token(Token = "0x2000127")]
	public abstract class Array2D<T> : ScriptableObject
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		protected Vector2Int gridSize;

		[Token(Token = "0x17000208")]
		public Vector2Int GridSize
		{
			[Token(Token = "0x6000A5F")]
			get
			{
				return default(Vector2Int);
			}
		}

		[Token(Token = "0x6000A60")]
		protected abstract CellRow<T> GetCellRow(int idx);

		[Token(Token = "0x6000A61")]
		public T[,] GetCells()
		{
			return null;
		}

		[Token(Token = "0x6000A62")]
		protected Array2D()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000128")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB6A764", Offset = "0xB6A764")]
	public class CellRow<T>
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T[] row;

		[Token(Token = "0x17000209")]
		public T Item
		{
			[Token(Token = "0x6000A63")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x6000A64")]
		public CellRow()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000129")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB6A79C", Offset = "0xB6A79C")]
	public class Array2DBool : Array2D<bool>
	{
		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowBool[] cells;

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x133E144", Offset = "0x133E144", VA = "0x133E144", Slot = "4")]
		protected override CellRow<bool> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x133E188", Offset = "0x133E188", VA = "0x133E188")]
		public Array2DBool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012A")]
	public class CellRowBool : CellRow<bool>
	{
		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x133E4A0", Offset = "0x133E4A0", VA = "0x133E4A0")]
		public CellRowBool()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB6A7E8", Offset = "0xB6A7E8")]
	public class Array2DExampleEnum : Array2D<Enums.ExampleEnum>
	{
		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowExampleEnum[] cells;

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x133E1F0", Offset = "0x133E1F0", VA = "0x133E1F0", Slot = "4")]
		protected override CellRow<Enums.ExampleEnum> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x133E234", Offset = "0x133E234", VA = "0x133E234")]
		public Array2DExampleEnum()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012C")]
	public class CellRowExampleEnum : CellRow<Enums.ExampleEnum>
	{
		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x133E4F0", Offset = "0x133E4F0", VA = "0x133E4F0")]
		public CellRowExampleEnum()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB6A834", Offset = "0xB6A834")]
	public class Array2DFloat : Array2D<float>
	{
		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowFloat[] cells;

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x133E29C", Offset = "0x133E29C", VA = "0x133E29C", Slot = "4")]
		protected override CellRow<float> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x133E2E0", Offset = "0x133E2E0", VA = "0x133E2E0")]
		public Array2DFloat()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012E")]
	public class CellRowFloat : CellRow<float>
	{
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x133E540", Offset = "0x133E540", VA = "0x133E540")]
		public CellRowFloat()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB6A880", Offset = "0xB6A880")]
	public class Array2DInt : Array2D<int>
	{
		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowInt[] cells;

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x133E348", Offset = "0x133E348", VA = "0x133E348", Slot = "4")]
		protected override CellRow<int> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x133E38C", Offset = "0x133E38C", VA = "0x133E38C")]
		public Array2DInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000130")]
	public class CellRowInt : CellRow<int>
	{
		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x133E590", Offset = "0x133E590", VA = "0x133E590")]
		public CellRowInt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000131")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xB6A8CC", Offset = "0xB6A8CC")]
	public class Array2DString : Array2D<string>
	{
		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CellRowString[] cells;

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x133E3F4", Offset = "0x133E3F4", VA = "0x133E3F4", Slot = "4")]
		protected override CellRow<string> GetCellRow(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x133E438", Offset = "0x133E438", VA = "0x133E438")]
		public Array2DString()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000132")]
	public class CellRowString : CellRow<string>
	{
		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x133E5E0", Offset = "0x133E5E0", VA = "0x133E5E0")]
		public CellRowString()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public static class Consts
	{
		[Token(Token = "0x40005F1")]
		public const int defaultGridSize = 3;
	}
	[Token(Token = "0x2000134")]
	public class Enums
	{
		[Token(Token = "0x20001D9")]
		public enum ExampleEnum
		{
			[Token(Token = "0x400085D")]
			Empty,
			[Token(Token = "0x400085E")]
			Moving,
			[Token(Token = "0x400085F")]
			Normal
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x133E630", Offset = "0x133E630", VA = "0x133E630")]
		public Enums()
		{
		}
	}
}
