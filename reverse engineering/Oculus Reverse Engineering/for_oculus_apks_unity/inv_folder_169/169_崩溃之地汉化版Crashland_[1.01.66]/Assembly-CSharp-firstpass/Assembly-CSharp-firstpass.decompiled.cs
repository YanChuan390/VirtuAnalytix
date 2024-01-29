using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using Crosstales.Common.Model.Enum;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
[Token(Token = "0x2000002")]
public class LeanAudioStream
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int position;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public AudioClip audioClip;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float[] audioArr;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x20143F0", Offset = "0x20143F0", VA = "0x20143F0")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2014E08", Offset = "0x2014E08", VA = "0x2014E08")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2014EB0", Offset = "0x2014EB0", VA = "0x2014EB0")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000003")]
public class LeanAudio
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static float[] longList;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x201309C", Offset = "0x201309C", VA = "0x201309C")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2013224", Offset = "0x2013224", VA = "0x2013224")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2014308", Offset = "0x2014308", VA = "0x2014308")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x201332C", Offset = "0x201332C", VA = "0x201332C")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2013A0C", Offset = "0x2013A0C", VA = "0x2013A0C")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2014410", Offset = "0x2014410", VA = "0x2014410")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2014414", Offset = "0x2014414", VA = "0x2014414")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x20145FC", Offset = "0x20145FC", VA = "0x20145FC")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x201488C", Offset = "0x201488C", VA = "0x201488C")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2014950", Offset = "0x2014950", VA = "0x2014950")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x20149F0", Offset = "0x20149F0", VA = "0x20149F0")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x20146EC", Offset = "0x20146EC", VA = "0x20146EC")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2014AF0", Offset = "0x2014AF0", VA = "0x2014AF0")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2014D20", Offset = "0x2014D20", VA = "0x2014D20")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000004")]
public class LeanAudioOptions
{
	[Token(Token = "0x200001D")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x400016A")]
		Sine,
		[Token(Token = "0x400016B")]
		Square,
		[Token(Token = "0x400016C")]
		Sawtooth,
		[Token(Token = "0x400016D")]
		Noise
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3[] vibrato;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] modulation;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int frequencyRate;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float waveNoiseScale;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float waveNoiseInfluence;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useSetData;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x20131F8", Offset = "0x20131F8", VA = "0x20131F8")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2014DB0", Offset = "0x2014DB0", VA = "0x2014DB0")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2014DB8", Offset = "0x2014DB8", VA = "0x2014DB8")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2014DC0", Offset = "0x2014DC0", VA = "0x2014DC0")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2014DCC", Offset = "0x2014DCC", VA = "0x2014DCC")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2014DD8", Offset = "0x2014DD8", VA = "0x2014DD8")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2014DE4", Offset = "0x2014DE4", VA = "0x2014DE4")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2014DF0", Offset = "0x2014DF0", VA = "0x2014DF0")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2014DF8", Offset = "0x2014DF8", VA = "0x2014DF8")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2014E00", Offset = "0x2014E00", VA = "0x2014E00")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDA0", Offset = "0x5BFDA0")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeanTester <>4__this;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000049")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0x20165B4", Offset = "0x20165B4", VA = "0x20165B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0x2016644", Offset = "0x2016644", VA = "0x2016644", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x20163B0", Offset = "0x20163B0", VA = "0x20163B0")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x20163E4", Offset = "0x20163E4", VA = "0x20163E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x20163E8", Offset = "0x20163E8", VA = "0x20163E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x20165BC", Offset = "0x20165BC", VA = "0x20165BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float timeout;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2016300", Offset = "0x2016300", VA = "0x2016300")]
	public void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2016324", Offset = "0x2016324", VA = "0x2016324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5BFFB0", Offset = "0x5BFFB0")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x20163D0", Offset = "0x20163D0", VA = "0x20163D0")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000006")]
public class LeanTest
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2014EB8", Offset = "0x2014EB8", VA = "0x2014EB8")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2014F48", Offset = "0x2014F48", VA = "0x2014F48")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x201614C", Offset = "0x201614C", VA = "0x201614C")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x201585C", Offset = "0x201585C", VA = "0x201585C")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x20161D0", Offset = "0x20161D0", VA = "0x20161D0")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x20159E0", Offset = "0x20159E0", VA = "0x20159E0")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2015A58", Offset = "0x2015A58", VA = "0x2015A58")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2015CC4", Offset = "0x2015CC4", VA = "0x2015CC4")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x201625C", Offset = "0x201625C", VA = "0x201625C")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000007")]
public enum TweenAction
{
	[Token(Token = "0x4000019")]
	MOVE_X,
	[Token(Token = "0x400001A")]
	MOVE_Y,
	[Token(Token = "0x400001B")]
	MOVE_Z,
	[Token(Token = "0x400001C")]
	MOVE_LOCAL_X,
	[Token(Token = "0x400001D")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x400001E")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x400001F")]
	MOVE_CURVED,
	[Token(Token = "0x4000020")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x4000021")]
	MOVE_SPLINE,
	[Token(Token = "0x4000022")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x4000023")]
	SCALE_X,
	[Token(Token = "0x4000024")]
	SCALE_Y,
	[Token(Token = "0x4000025")]
	SCALE_Z,
	[Token(Token = "0x4000026")]
	ROTATE_X,
	[Token(Token = "0x4000027")]
	ROTATE_Y,
	[Token(Token = "0x4000028")]
	ROTATE_Z,
	[Token(Token = "0x4000029")]
	ROTATE_AROUND,
	[Token(Token = "0x400002A")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x400002B")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x400002C")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x400002D")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x400002E")]
	ALPHA,
	[Token(Token = "0x400002F")]
	TEXT_ALPHA,
	[Token(Token = "0x4000030")]
	CANVAS_ALPHA,
	[Token(Token = "0x4000031")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x4000032")]
	ALPHA_VERTEX,
	[Token(Token = "0x4000033")]
	COLOR,
	[Token(Token = "0x4000034")]
	CALLBACK_COLOR,
	[Token(Token = "0x4000035")]
	TEXT_COLOR,
	[Token(Token = "0x4000036")]
	CANVAS_COLOR,
	[Token(Token = "0x4000037")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000038")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x4000039")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x400003A")]
	CALLBACK,
	[Token(Token = "0x400003B")]
	MOVE,
	[Token(Token = "0x400003C")]
	MOVE_LOCAL,
	[Token(Token = "0x400003D")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x400003E")]
	ROTATE,
	[Token(Token = "0x400003F")]
	ROTATE_LOCAL,
	[Token(Token = "0x4000040")]
	SCALE,
	[Token(Token = "0x4000041")]
	VALUE3,
	[Token(Token = "0x4000042")]
	GUI_MOVE,
	[Token(Token = "0x4000043")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x4000044")]
	GUI_SCALE,
	[Token(Token = "0x4000045")]
	GUI_ALPHA,
	[Token(Token = "0x4000046")]
	GUI_ROTATE,
	[Token(Token = "0x4000047")]
	DELAYED_SOUND,
	[Token(Token = "0x4000048")]
	CANVAS_MOVE,
	[Token(Token = "0x4000049")]
	CANVAS_SCALE,
	[Token(Token = "0x400004A")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x2000008")]
public enum LeanTweenType
{
	[Token(Token = "0x400004C")]
	notUsed,
	[Token(Token = "0x400004D")]
	linear,
	[Token(Token = "0x400004E")]
	easeOutQuad,
	[Token(Token = "0x400004F")]
	easeInQuad,
	[Token(Token = "0x4000050")]
	easeInOutQuad,
	[Token(Token = "0x4000051")]
	easeInCubic,
	[Token(Token = "0x4000052")]
	easeOutCubic,
	[Token(Token = "0x4000053")]
	easeInOutCubic,
	[Token(Token = "0x4000054")]
	easeInQuart,
	[Token(Token = "0x4000055")]
	easeOutQuart,
	[Token(Token = "0x4000056")]
	easeInOutQuart,
	[Token(Token = "0x4000057")]
	easeInQuint,
	[Token(Token = "0x4000058")]
	easeOutQuint,
	[Token(Token = "0x4000059")]
	easeInOutQuint,
	[Token(Token = "0x400005A")]
	easeInSine,
	[Token(Token = "0x400005B")]
	easeOutSine,
	[Token(Token = "0x400005C")]
	easeInOutSine,
	[Token(Token = "0x400005D")]
	easeInExpo,
	[Token(Token = "0x400005E")]
	easeOutExpo,
	[Token(Token = "0x400005F")]
	easeInOutExpo,
	[Token(Token = "0x4000060")]
	easeInCirc,
	[Token(Token = "0x4000061")]
	easeOutCirc,
	[Token(Token = "0x4000062")]
	easeInOutCirc,
	[Token(Token = "0x4000063")]
	easeInBounce,
	[Token(Token = "0x4000064")]
	easeOutBounce,
	[Token(Token = "0x4000065")]
	easeInOutBounce,
	[Token(Token = "0x4000066")]
	easeInBack,
	[Token(Token = "0x4000067")]
	easeOutBack,
	[Token(Token = "0x4000068")]
	easeInOutBack,
	[Token(Token = "0x4000069")]
	easeInElastic,
	[Token(Token = "0x400006A")]
	easeOutElastic,
	[Token(Token = "0x400006B")]
	easeInOutElastic,
	[Token(Token = "0x400006C")]
	easeSpring,
	[Token(Token = "0x400006D")]
	easeShake,
	[Token(Token = "0x400006E")]
	punch,
	[Token(Token = "0x400006F")]
	once,
	[Token(Token = "0x4000070")]
	clamp,
	[Token(Token = "0x4000071")]
	pingPong,
	[Token(Token = "0x4000072")]
	animationCurve
}
[Token(Token = "0x2000009")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static LTSeq[] sequences;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTDescr[] tweens;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static int[] tweensFinished;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr tween;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int tweenMaxSearch;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int maxTweens;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static int maxSequences;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int frameRendered;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static float dtEstimated;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public static float dtManual;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static float dtActual;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static uint global_counter;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int i;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int j;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static int finishedCnt;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public static AnimationCurve punch;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static AnimationCurve shake;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int maxTweenReached;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static int startSearch;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public static LTDescr d;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static GameObject[] goListeners;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int eventsMaxSearch;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public static int EVENTS_MAX;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000001")]
	public static int maxSearch
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2016774", Offset = "0x2016774", VA = "0x2016774")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2016800", Offset = "0x2016800", VA = "0x2016800")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static int tweensRunning
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x201688C", Offset = "0x201688C", VA = "0x201688C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x201C678", Offset = "0x201C678", VA = "0x201C678")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x201664C", Offset = "0x201664C", VA = "0x201664C")]
	public static void init()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x20166DC", Offset = "0x20166DC", VA = "0x20166DC")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x20169B4", Offset = "0x20169B4", VA = "0x20169B4")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2016F3C", Offset = "0x2016F3C", VA = "0x2016F3C")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x20171BC", Offset = "0x20171BC", VA = "0x20171BC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2017964", Offset = "0x2017964", VA = "0x2017964")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x20179F4", Offset = "0x20179F4", VA = "0x20179F4")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2017234", Offset = "0x2017234", VA = "0x2017234")]
	public static void update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2018100", Offset = "0x2018100", VA = "0x2018100")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2017A70", Offset = "0x2017A70", VA = "0x2017A70")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2018220", Offset = "0x2018220", VA = "0x2018220")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2018494", Offset = "0x2018494", VA = "0x2018494")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2018584", Offset = "0x2018584", VA = "0x2018584")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2018600", Offset = "0x2018600", VA = "0x2018600")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2018990", Offset = "0x2018990", VA = "0x2018990")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2018A14", Offset = "0x2018A14", VA = "0x2018A14")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2018E6C", Offset = "0x2018E6C", VA = "0x2018E6C")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2018F10", Offset = "0x2018F10", VA = "0x2018F10")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x201939C", Offset = "0x201939C", VA = "0x201939C")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2019560", Offset = "0x2019560", VA = "0x2019560")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x20195E4", Offset = "0x20195E4", VA = "0x20195E4")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2019AAC", Offset = "0x2019AAC", VA = "0x2019AAC")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2019F10", Offset = "0x2019F10", VA = "0x2019F10")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2019F90", Offset = "0x2019F90", VA = "0x2019F90")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x201A324", Offset = "0x201A324", VA = "0x201A324")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C0028", Offset = "0x5C0028")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x201A3A4", Offset = "0x201A3A4", VA = "0x201A3A4")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x201A528", Offset = "0x201A528", VA = "0x201A528")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x201A75C", Offset = "0x201A75C", VA = "0x201A75C")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x201A8B0", Offset = "0x201A8B0", VA = "0x201A8B0")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x201AA04", Offset = "0x201AA04", VA = "0x201AA04")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C0070", Offset = "0x5C0070")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x201AA84", Offset = "0x201AA84", VA = "0x201AA84")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x201AC08", Offset = "0x201AC08", VA = "0x201AC08")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x201AE3C", Offset = "0x201AE3C", VA = "0x201AE3C")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x201B19C", Offset = "0x201B19C", VA = "0x201B19C")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x201B23C", Offset = "0x201B23C", VA = "0x201B23C")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x201B410", Offset = "0x201B410", VA = "0x201B410")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x201B5F4", Offset = "0x201B5F4", VA = "0x201B5F4")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x20112E0", Offset = "0x20112E0", VA = "0x20112E0")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x201BFC8", Offset = "0x201BFC8", VA = "0x201BFC8")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x201C058", Offset = "0x201C058", VA = "0x201C058")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x201C720", Offset = "0x201C720", VA = "0x201C720")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x201C870", Offset = "0x201C870", VA = "0x201C870")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x201C9FC", Offset = "0x201C9FC", VA = "0x201C9FC")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x200FE2C", Offset = "0x200FE2C", VA = "0x200FE2C")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x201CB3C", Offset = "0x201CB3C", VA = "0x201CB3C")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x201CC78", Offset = "0x201CC78", VA = "0x201CC78")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x201CD90", Offset = "0x201CD90", VA = "0x201CD90")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x201CEA8", Offset = "0x201CEA8", VA = "0x201CEA8")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x201CFC0", Offset = "0x201CFC0", VA = "0x201CFC0")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x201D0B8", Offset = "0x201D0B8", VA = "0x201D0B8")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x201D250", Offset = "0x201D250", VA = "0x201D250")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x201D3C0", Offset = "0x201D3C0", VA = "0x201D3C0")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2010468", Offset = "0x2010468", VA = "0x2010468")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x20106F4", Offset = "0x20106F4", VA = "0x20106F4")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x20108C8", Offset = "0x20108C8", VA = "0x20108C8")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2010AC0", Offset = "0x2010AC0", VA = "0x2010AC0")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x201D530", Offset = "0x201D530", VA = "0x201D530")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x201D684", Offset = "0x201D684", VA = "0x201D684")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x201D75C", Offset = "0x201D75C", VA = "0x201D75C")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x201D898", Offset = "0x201D898", VA = "0x201D898")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x201DB7C", Offset = "0x201DB7C", VA = "0x201DB7C")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x201DCEC", Offset = "0x201DCEC", VA = "0x201DCEC")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x201DE5C", Offset = "0x201DE5C", VA = "0x201DE5C")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x201E008", Offset = "0x201E008", VA = "0x201E008")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x201E178", Offset = "0x201E178", VA = "0x201E178")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x201E324", Offset = "0x201E324", VA = "0x201E324")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x201E464", Offset = "0x201E464", VA = "0x201E464")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x201E5A4", Offset = "0x201E5A4", VA = "0x201E5A4")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x201E69C", Offset = "0x201E69C", VA = "0x201E69C")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x201E794", Offset = "0x201E794", VA = "0x201E794")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x201E88C", Offset = "0x201E88C", VA = "0x201E88C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x201E964", Offset = "0x201E964", VA = "0x201E964")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x201EC48", Offset = "0x201EC48", VA = "0x201EC48")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x201ED40", Offset = "0x201ED40", VA = "0x201ED40")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x201EE38", Offset = "0x201EE38", VA = "0x201EE38")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x201EF30", Offset = "0x201EF30", VA = "0x201EF30")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x201F0A0", Offset = "0x201F0A0", VA = "0x201F0A0")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x201F210", Offset = "0x201F210", VA = "0x201F210")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x201F33C", Offset = "0x201F33C", VA = "0x201F33C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x201F414", Offset = "0x201F414", VA = "0x201F414")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x201F538", Offset = "0x201F538", VA = "0x201F538")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x201F610", Offset = "0x201F610", VA = "0x201F610")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x201F708", Offset = "0x201F708", VA = "0x201F708")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x201F800", Offset = "0x201F800", VA = "0x201F800")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x201F8F8", Offset = "0x201F8F8", VA = "0x201F8F8")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x201FA28", Offset = "0x201FA28", VA = "0x201FA28")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x201FB58", Offset = "0x201FB58", VA = "0x201FB58")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x201FC30", Offset = "0x201FC30", VA = "0x201FC30")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x201FD70", Offset = "0x201FD70", VA = "0x201FD70")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x201FE68", Offset = "0x201FE68", VA = "0x201FE68")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x201FF60", Offset = "0x201FF60", VA = "0x201FF60")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2020058", Offset = "0x2020058", VA = "0x2020058")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x20201A4", Offset = "0x20201A4", VA = "0x20201A4")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x20202F4", Offset = "0x20202F4", VA = "0x20202F4")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x202049C", Offset = "0x202049C", VA = "0x202049C")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x20205A8", Offset = "0x20205A8", VA = "0x20205A8")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x20207B0", Offset = "0x20207B0", VA = "0x20207B0")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2020970", Offset = "0x2020970", VA = "0x2020970")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2020B30", Offset = "0x2020B30", VA = "0x2020B30")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2020D7C", Offset = "0x2020D7C", VA = "0x2020D7C")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2020FC8", Offset = "0x2020FC8", VA = "0x2020FC8")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2021198", Offset = "0x2021198", VA = "0x2021198")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2021314", Offset = "0x2021314", VA = "0x2021314")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x20214D8", Offset = "0x20214D8", VA = "0x20214D8")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2021664", Offset = "0x2021664", VA = "0x2021664")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x20217EC", Offset = "0x20217EC", VA = "0x20217EC")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2021908", Offset = "0x2021908", VA = "0x2021908")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2021A44", Offset = "0x2021A44", VA = "0x2021A44")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x2021B80", Offset = "0x2021B80", VA = "0x2021B80")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2021CBC", Offset = "0x2021CBC", VA = "0x2021CBC")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2021E5C", Offset = "0x2021E5C", VA = "0x2021E5C")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2021FDC", Offset = "0x2021FDC", VA = "0x2021FDC")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2022158", Offset = "0x2022158", VA = "0x2022158")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x20222D4", Offset = "0x20222D4", VA = "0x20222D4")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x20223F0", Offset = "0x20223F0", VA = "0x20223F0")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2022548", Offset = "0x2022548", VA = "0x2022548")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2022684", Offset = "0x2022684", VA = "0x2022684")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2022824", Offset = "0x2022824", VA = "0x2022824")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x20228E8", Offset = "0x20228E8", VA = "0x20228E8")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2022B14", Offset = "0x2022B14", VA = "0x2022B14")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x2022B3C", Offset = "0x2022B3C", VA = "0x2022B3C")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2022B5C", Offset = "0x2022B5C", VA = "0x2022B5C")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2022BC0", Offset = "0x2022BC0", VA = "0x2022BC0")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2022DAC", Offset = "0x2022DAC", VA = "0x2022DAC")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2022E40", Offset = "0x2022E40", VA = "0x2022E40")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2022F2C", Offset = "0x2022F2C", VA = "0x2022F2C")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2023050", Offset = "0x2023050", VA = "0x2023050")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2023074", Offset = "0x2023074", VA = "0x2023074")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x20230A0", Offset = "0x20230A0", VA = "0x20230A0")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2023108", Offset = "0x2023108", VA = "0x2023108")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2023154", Offset = "0x2023154", VA = "0x2023154")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x202317C", Offset = "0x202317C", VA = "0x202317C")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x20231B4", Offset = "0x20231B4", VA = "0x20231B4")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2023220", Offset = "0x2023220", VA = "0x2023220")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x202324C", Offset = "0x202324C", VA = "0x202324C")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2023284", Offset = "0x2023284", VA = "0x2023284")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x20232F4", Offset = "0x20232F4", VA = "0x20232F4")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2023324", Offset = "0x2023324", VA = "0x2023324")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2023364", Offset = "0x2023364", VA = "0x2023364")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x20233E0", Offset = "0x20233E0", VA = "0x20233E0")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2023498", Offset = "0x2023498", VA = "0x2023498")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x202354C", Offset = "0x202354C", VA = "0x202354C")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2023610", Offset = "0x2023610", VA = "0x2023610")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x20236C8", Offset = "0x20236C8", VA = "0x20236C8")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2023780", Offset = "0x2023780", VA = "0x2023780")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x20238AC", Offset = "0x20238AC", VA = "0x20238AC")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2023980", Offset = "0x2023980", VA = "0x2023980")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2023A50", Offset = "0x2023A50", VA = "0x2023A50")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2023B7C", Offset = "0x2023B7C", VA = "0x2023B7C")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2023C38", Offset = "0x2023C38", VA = "0x2023C38")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2023D0C", Offset = "0x2023D0C", VA = "0x2023D0C")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2023E18", Offset = "0x2023E18", VA = "0x2023E18")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2023E60", Offset = "0x2023E60", VA = "0x2023E60")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2023EB4", Offset = "0x2023EB4", VA = "0x2023EB4")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2023F58", Offset = "0x2023F58", VA = "0x2023F58")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x20240B4", Offset = "0x20240B4", VA = "0x20240B4")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2024204", Offset = "0x2024204", VA = "0x2024204")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2024410", Offset = "0x2024410", VA = "0x2024410")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x202449C", Offset = "0x202449C", VA = "0x202449C")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2024BB4", Offset = "0x2024BB4", VA = "0x2024BB4")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2024FB0", Offset = "0x2024FB0", VA = "0x2024FB0")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2024C40", Offset = "0x2024C40", VA = "0x2024C40")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x20250D8", Offset = "0x20250D8", VA = "0x20250D8")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x202515C", Offset = "0x202515C", VA = "0x202515C")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x20254BC", Offset = "0x20254BC", VA = "0x20254BC")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000A")]
public class LTUtility
{
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2012F40", Offset = "0x2012F40", VA = "0x2012F40")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2013094", Offset = "0x2013094", VA = "0x2013094")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200000B")]
public class LTBezier
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float length;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private Vector3 a;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 aa;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 bb;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 cc;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float len;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float[] arcLengths;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1108564", Offset = "0x1108564", VA = "0x1108564")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1108B18", Offset = "0x1108B18", VA = "0x1108B18")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x11089B0", Offset = "0x11089B0", VA = "0x11089B0")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1108D3C", Offset = "0x1108D3C", VA = "0x1108D3C")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000C")]
public class LTBezierPath
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3[] pts;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float length;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool orientToPath;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool orientToPath2d;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private LTBezier[] beziers;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float[] lengthRatio;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int currentBezier;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int previousBezier;

	[Token(Token = "0x17000005")]
	public float distance
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1109284", Offset = "0x1109284", VA = "0x1109284")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1108D6C", Offset = "0x1108D6C", VA = "0x1108D6C")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1108D74", Offset = "0x1108D74", VA = "0x1108D74")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1108D9C", Offset = "0x1108D9C", VA = "0x1108D9C")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x110928C", Offset = "0x110928C", VA = "0x110928C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1109488", Offset = "0x1109488", VA = "0x1109488")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1109668", Offset = "0x1109668", VA = "0x1109668")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1109848", Offset = "0x1109848", VA = "0x1109848")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x11098FC", Offset = "0x11098FC", VA = "0x11098FC")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x11099C0", Offset = "0x11099C0", VA = "0x11099C0")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1109A74", Offset = "0x1109A74", VA = "0x1109A74")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1109BAC", Offset = "0x1109BAC", VA = "0x1109BAC")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1109C9C", Offset = "0x1109C9C", VA = "0x1109C9C")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x200000D")]
public class LTSpline
{
	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float distance;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool constantSpeed;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int ptsAdjLength;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int numSections;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int currPt;

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2010D80", Offset = "0x2010D80", VA = "0x2010D80")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x20112A0", Offset = "0x20112A0", VA = "0x20112A0")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2010DB8", Offset = "0x2010DB8", VA = "0x2010DB8")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2011940", Offset = "0x2011940", VA = "0x2011940")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x20113E4", Offset = "0x20113E4", VA = "0x20113E4")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2011BB4", Offset = "0x2011BB4", VA = "0x2011BB4")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2011D24", Offset = "0x2011D24", VA = "0x2011D24")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2011D5C", Offset = "0x2011D5C", VA = "0x2011D5C")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2011F3C", Offset = "0x2011F3C", VA = "0x2011F3C")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x201219C", Offset = "0x201219C", VA = "0x201219C")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2012250", Offset = "0x2012250", VA = "0x2012250")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2012314", Offset = "0x2012314", VA = "0x2012314")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x20123C8", Offset = "0x20123C8", VA = "0x20123C8")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x20124DC", Offset = "0x20124DC", VA = "0x20124DC")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x20125C4", Offset = "0x20125C4", VA = "0x20125C4")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x201273C", Offset = "0x201273C", VA = "0x201273C")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2012A2C", Offset = "0x2012A2C", VA = "0x2012A2C")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2012A3C", Offset = "0x2012A3C", VA = "0x2012A3C")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2012CDC", Offset = "0x2012CDC", VA = "0x2012CDC")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class LTRect
{
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Rect _rect;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float alpha;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float rotation;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 pivot;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 margin;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rect relativeRect;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool rotateEnabled;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x5BFE00", Offset = "0x5BFE00")]
	public bool rotateFinished;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool alphaEnabled;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public string labelStr;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public GUIStyle style;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool useColor;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Color color;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	public bool useSimpleScale;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
	public bool sizeByHeight;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Texture texture;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int _id;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "HideInInspector", RVA = "0x5BFE10", Offset = "0x5BFE10")]
	public int counter;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000006")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x11208A8", Offset = "0x11208A8", VA = "0x11208A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x112132C", Offset = "0x112132C", VA = "0x112132C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x112221C", Offset = "0x112221C", VA = "0x112221C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1122228", Offset = "0x1122228", VA = "0x1122228")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1122234", Offset = "0x1122234", VA = "0x1122234")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1122240", Offset = "0x1122240", VA = "0x1122240")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x112224C", Offset = "0x112224C", VA = "0x112224C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1122258", Offset = "0x1122258", VA = "0x1122258")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1122264", Offset = "0x1122264", VA = "0x1122264")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1122270", Offset = "0x1122270", VA = "0x1122270")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x111D7C8", Offset = "0x111D7C8", VA = "0x111D7C8")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x111DBF4", Offset = "0x111DBF4", VA = "0x111DBF4")]
		set
		{
		}
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1121DB4", Offset = "0x1121DB4", VA = "0x1121DB4")]
	public LTRect()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1116B24", Offset = "0x1116B24", VA = "0x1116B24")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1121F40", Offset = "0x1121F40", VA = "0x1121F40")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x112202C", Offset = "0x112202C", VA = "0x112202C")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1122114", Offset = "0x1122114", VA = "0x1122114")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x112133C", Offset = "0x112133C", VA = "0x112133C")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1121E88", Offset = "0x1121E88", VA = "0x1121E88")]
	public void reset()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x111E17C", Offset = "0x111E17C", VA = "0x111E17C")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x112227C", Offset = "0x112227C", VA = "0x112227C")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1122284", Offset = "0x1122284", VA = "0x1122284")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x112228C", Offset = "0x112228C", VA = "0x112228C")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x11222AC", Offset = "0x11222AC", VA = "0x11222AC")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x11222B4", Offset = "0x11222B4", VA = "0x11222B4")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x11222BC", Offset = "0x11222BC", VA = "0x11222BC")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x11222E0", Offset = "0x11222E0", VA = "0x11222E0")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x1122360", Offset = "0x1122360", VA = "0x1122360")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1122368", Offset = "0x1122368", VA = "0x1122368", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
public class LTEvent
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public object data;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x111E6E0", Offset = "0x111E6E0", VA = "0x111E6E0")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000010")]
public class LTGUI
{
	[Token(Token = "0x200001F")]
	public enum Element_Type
	{
		[Token(Token = "0x4000173")]
		Texture,
		[Token(Token = "0x4000174")]
		Label
	}

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static LTRect[] levels;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static int[] levelDepths;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static Rect[] buttons;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] buttonLevels;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static LTRect r;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static Color color;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static bool isGUIEnabled;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int global_counter;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x111E708", Offset = "0x111E708", VA = "0x111E708")]
	public static void init()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x111E82C", Offset = "0x111E82C", VA = "0x111E82C")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x111EA58", Offset = "0x111EA58", VA = "0x111EA58")]
	public static void reset()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x111ECF8", Offset = "0x111ECF8", VA = "0x111ECF8")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1120524", Offset = "0x1120524", VA = "0x1120524")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1120628", Offset = "0x1120628", VA = "0x1120628")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x11208BC", Offset = "0x11208BC", VA = "0x11208BC")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1120A28", Offset = "0x1120A28", VA = "0x1120A28")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1120AF8", Offset = "0x1120AF8", VA = "0x1120AF8")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x112119C", Offset = "0x112119C", VA = "0x112119C")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x112126C", Offset = "0x112126C", VA = "0x112126C")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1120BB8", Offset = "0x1120BB8", VA = "0x1120BB8")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1121348", Offset = "0x1121348", VA = "0x1121348")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1121920", Offset = "0x1121920", VA = "0x1121920")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1121BE0", Offset = "0x1121BE0", VA = "0x1121BE0")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1121AA0", Offset = "0x1121AA0", VA = "0x1121AA0")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1121CE8", Offset = "0x1121CE8", VA = "0x1121CE8")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000011")]
public class LTDescr
{
	[Token(Token = "0x2000020")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000021")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDB0", Offset = "0x5BFDB0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static ActionMethodDelegate <>9__110_0;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__111_0;

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x111E5F4", Offset = "0x111E5F4", VA = "0x111E5F4")]
		public <>c()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x111E5FC", Offset = "0x111E5FC", VA = "0x111E5FC")]
		internal void <setCallback>b__110_0()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x111E600", Offset = "0x111E600", VA = "0x111E600")]
		internal void <setValue3>b__111_0()
		{
		}
	}

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public bool toggle;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public bool useEstimatedTime;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public bool useFrames;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public bool useManualTime;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public bool usesNormalDt;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public bool hasInitiliazed;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
	public bool hasPhysics;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onCompleteOnStart;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useRecursion;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float ratioPassed;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float passed;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float time;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float lastVal;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private uint _id;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int loopCount;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float direction;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float directionLast;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float overshoot;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float period;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float scale;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool destroyOnComplete;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform trans;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public LTRect ltRect;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	internal Vector3 fromInternal;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	internal Vector3 toInternal;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	internal Vector3 diff;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TweenAction type;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private LeanTweenType easeType;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LeanTweenType loopType;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool hasUpdateCallback;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE20", Offset = "0x5BFE20")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE30", Offset = "0x5BFE30")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RectTransform rectTransform;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public Text uiText;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Image uiImage;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public RawImage rawImage;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Sprite[] sprites;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public LTDescrOptional _optional;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x1700000D")]
	public Vector3 from
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1109DA8", Offset = "0x1109DA8", VA = "0x1109DA8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1109DBC", Offset = "0x1109DBC", VA = "0x1109DBC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Vector3 to
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1109DC8", Offset = "0x1109DC8", VA = "0x1109DC8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1109DDC", Offset = "0x1109DDC", VA = "0x1109DDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1109DE8", Offset = "0x1109DE8", VA = "0x1109DE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C00B8", Offset = "0x5C00B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1109DF0", Offset = "0x1109DF0", VA = "0x1109DF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C00C8", Offset = "0x5C00C8")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1109DF8", Offset = "0x1109DF8", VA = "0x1109DF8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C00D8", Offset = "0x5C00D8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1109E00", Offset = "0x1109E00", VA = "0x1109E00")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C00E8", Offset = "0x5C00E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int uniqueId
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x110AC7C", Offset = "0x110AC7C", VA = "0x110AC7C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public int id
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x110AAE4", Offset = "0x110AAE4", VA = "0x110AAE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000013")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x110AC8C", Offset = "0x110AC8C", VA = "0x110AC8C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x110AC94", Offset = "0x110AC94", VA = "0x110AC94")]
		set
		{
		}
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1109E08", Offset = "0x1109E08", VA = "0x1109E08", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x110AAF4", Offset = "0x110AAF4", VA = "0x110AAF4")]
	public LTDescr()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x110AB78", Offset = "0x110AB78", VA = "0x110AB78")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5C00F8", Offset = "0x5C00F8")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x110AC98", Offset = "0x110AC98", VA = "0x110AC98")]
	public void reset()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x110AEEC", Offset = "0x110AEEC", VA = "0x110AEEC")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x110AFBC", Offset = "0x110AFBC", VA = "0x110AFBC")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x110B078", Offset = "0x110B078", VA = "0x110B078")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x110B134", Offset = "0x110B134", VA = "0x110B134")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x110B1F0", Offset = "0x110B1F0", VA = "0x110B1F0")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x110B2AC", Offset = "0x110B2AC", VA = "0x110B2AC")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x110B368", Offset = "0x110B368", VA = "0x110B368")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x110B374", Offset = "0x110B374", VA = "0x110B374")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x110B430", Offset = "0x110B430", VA = "0x110B430")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x110B4EC", Offset = "0x110B4EC", VA = "0x110B4EC")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x110B5A8", Offset = "0x110B5A8", VA = "0x110B5A8")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x110B664", Offset = "0x110B664", VA = "0x110B664")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x110B720", Offset = "0x110B720", VA = "0x110B720")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x110B7DC", Offset = "0x110B7DC", VA = "0x110B7DC")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x110B898", Offset = "0x110B898", VA = "0x110B898")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x110B954", Offset = "0x110B954", VA = "0x110B954")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x110BA10", Offset = "0x110BA10", VA = "0x110BA10")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x110BACC", Offset = "0x110BACC", VA = "0x110BACC")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x110BB88", Offset = "0x110BB88", VA = "0x110BB88")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x110BC44", Offset = "0x110BC44", VA = "0x110BC44")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x110BD00", Offset = "0x110BD00", VA = "0x110BD00")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x110BDBC", Offset = "0x110BDBC", VA = "0x110BDBC")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x110BE78", Offset = "0x110BE78", VA = "0x110BE78")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x110BF34", Offset = "0x110BF34", VA = "0x110BF34")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x110BFF0", Offset = "0x110BFF0", VA = "0x110BFF0")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x110C0AC", Offset = "0x110C0AC", VA = "0x110C0AC")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x110C168", Offset = "0x110C168", VA = "0x110C168")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x110C224", Offset = "0x110C224", VA = "0x110C224")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x110C2E0", Offset = "0x110C2E0", VA = "0x110C2E0")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x110C39C", Offset = "0x110C39C", VA = "0x110C39C")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x110C458", Offset = "0x110C458", VA = "0x110C458")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x110C514", Offset = "0x110C514", VA = "0x110C514")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x110C590", Offset = "0x110C590", VA = "0x110C590")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x110C64C", Offset = "0x110C64C", VA = "0x110C64C")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x110C708", Offset = "0x110C708", VA = "0x110C708")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x110C7C4", Offset = "0x110C7C4", VA = "0x110C7C4")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x110C880", Offset = "0x110C880", VA = "0x110C880")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x110C93C", Offset = "0x110C93C", VA = "0x110C93C")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x110C9F8", Offset = "0x110C9F8", VA = "0x110C9F8")]
	private void callback()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x110CF2C", Offset = "0x110CF2C", VA = "0x110CF2C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x110D090", Offset = "0x110D090", VA = "0x110D090")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x110D1F4", Offset = "0x110D1F4", VA = "0x110D1F4")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x110D2B0", Offset = "0x110D2B0", VA = "0x110D2B0")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x110D36C", Offset = "0x110D36C", VA = "0x110D36C")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x110D428", Offset = "0x110D428", VA = "0x110D428")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x110D4E4", Offset = "0x110D4E4", VA = "0x110D4E4")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x110D5A0", Offset = "0x110D5A0", VA = "0x110D5A0")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x110D65C", Offset = "0x110D65C", VA = "0x110D65C")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x110D718", Offset = "0x110D718", VA = "0x110D718")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x110D7D4", Offset = "0x110D7D4", VA = "0x110D7D4")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x110D890", Offset = "0x110D890", VA = "0x110D890")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x110D94C", Offset = "0x110D94C", VA = "0x110D94C")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x110DA08", Offset = "0x110DA08", VA = "0x110DA08")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x110DAC4", Offset = "0x110DAC4", VA = "0x110DAC4")]
	private void init()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x110E364", Offset = "0x110E364", VA = "0x110E364")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x110E4E0", Offset = "0x110E4E0", VA = "0x110E4E0")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x110E4F8", Offset = "0x110E4F8", VA = "0x110E4F8")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x110E12C", Offset = "0x110E12C", VA = "0x110E12C")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x110EB4C", Offset = "0x110EB4C", VA = "0x110EB4C")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x110EC34", Offset = "0x110EC34", VA = "0x110EC34")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x110F310", Offset = "0x110F310", VA = "0x110F310")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x110F7E0", Offset = "0x110F7E0", VA = "0x110F7E0")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x110FD00", Offset = "0x110FD00", VA = "0x110FD00")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x11101D4", Offset = "0x11101D4", VA = "0x11101D4")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x11106F8", Offset = "0x11106F8", VA = "0x11106F8")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1110C10", Offset = "0x1110C10", VA = "0x1110C10")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1111058", Offset = "0x1111058", VA = "0x1111058")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1111498", Offset = "0x1111498", VA = "0x1111498")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x11118E4", Offset = "0x11118E4", VA = "0x11118E4")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1111AEC", Offset = "0x1111AEC", VA = "0x1111AEC")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1111B08", Offset = "0x1111B08", VA = "0x1111B08")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1111B14", Offset = "0x1111B14", VA = "0x1111B14")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1111B54", Offset = "0x1111B54", VA = "0x1111B54")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1111B5C", Offset = "0x1111B5C", VA = "0x1111B5C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1111D18", Offset = "0x1111D18", VA = "0x1111D18")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1113070", Offset = "0x1113070", VA = "0x1113070")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1111E38", Offset = "0x1111E38", VA = "0x1111E38")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1111DA8", Offset = "0x1111DA8", VA = "0x1111DA8")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1111EC8", Offset = "0x1111EC8", VA = "0x1111EC8")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1111F58", Offset = "0x1111F58", VA = "0x1111F58")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1111FE8", Offset = "0x1111FE8", VA = "0x1111FE8")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1112078", Offset = "0x1112078", VA = "0x1112078")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1112108", Offset = "0x1112108", VA = "0x1112108")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1112198", Offset = "0x1112198", VA = "0x1112198")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1112228", Offset = "0x1112228", VA = "0x1112228")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x11122B8", Offset = "0x11122B8", VA = "0x11122B8")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1112348", Offset = "0x1112348", VA = "0x1112348")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x11123D8", Offset = "0x11123D8", VA = "0x11123D8")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1112468", Offset = "0x1112468", VA = "0x1112468")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x11124F8", Offset = "0x11124F8", VA = "0x11124F8")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1112588", Offset = "0x1112588", VA = "0x1112588")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1112618", Offset = "0x1112618", VA = "0x1112618")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x11126A8", Offset = "0x11126A8", VA = "0x11126A8")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1112738", Offset = "0x1112738", VA = "0x1112738")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x11127C8", Offset = "0x11127C8", VA = "0x11127C8")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1112858", Offset = "0x1112858", VA = "0x1112858")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x11128E8", Offset = "0x11128E8", VA = "0x11128E8")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1112978", Offset = "0x1112978", VA = "0x1112978")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1112A08", Offset = "0x1112A08", VA = "0x1112A08")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1112A98", Offset = "0x1112A98", VA = "0x1112A98")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1112B28", Offset = "0x1112B28", VA = "0x1112B28")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1112BB8", Offset = "0x1112BB8", VA = "0x1112BB8")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1112C48", Offset = "0x1112C48", VA = "0x1112C48")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1112CD8", Offset = "0x1112CD8", VA = "0x1112CD8")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1112D68", Offset = "0x1112D68", VA = "0x1112D68")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1112DF8", Offset = "0x1112DF8", VA = "0x1112DF8")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1112E88", Offset = "0x1112E88", VA = "0x1112E88")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1112F7C", Offset = "0x1112F7C", VA = "0x1112F7C")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1113100", Offset = "0x1113100", VA = "0x1113100")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1113244", Offset = "0x1113244", VA = "0x1113244")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1113374", Offset = "0x1113374", VA = "0x1113374")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1113450", Offset = "0x1113450", VA = "0x1113450")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1113574", Offset = "0x1113574", VA = "0x1113574")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x111364C", Offset = "0x111364C", VA = "0x111364C")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x111383C", Offset = "0x111383C", VA = "0x111383C")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x111391C", Offset = "0x111391C", VA = "0x111391C")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x1113A1C", Offset = "0x1113A1C", VA = "0x1113A1C")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x1113B64", Offset = "0x1113B64", VA = "0x1113B64")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x1113C78", Offset = "0x1113C78", VA = "0x1113C78")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1113D7C", Offset = "0x1113D7C", VA = "0x1113D7C")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1113F60", Offset = "0x1113F60", VA = "0x1113F60")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1114058", Offset = "0x1114058", VA = "0x1114058")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1114160", Offset = "0x1114160", VA = "0x1114160")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x11142B8", Offset = "0x11142B8", VA = "0x11142B8")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1114424", Offset = "0x1114424", VA = "0x1114424")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1114580", Offset = "0x1114580", VA = "0x1114580")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x11146B0", Offset = "0x11146B0", VA = "0x11146B0")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x11147D4", Offset = "0x11147D4", VA = "0x11147D4")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x11148FC", Offset = "0x11148FC", VA = "0x11148FC")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1114B2C", Offset = "0x1114B2C", VA = "0x1114B2C")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1114C6C", Offset = "0x1114C6C", VA = "0x1114C6C")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1114DCC", Offset = "0x1114DCC", VA = "0x1114DCC")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x1114FC8", Offset = "0x1114FC8", VA = "0x1114FC8")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1115154", Offset = "0x1115154", VA = "0x1115154")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x11153B0", Offset = "0x11153B0", VA = "0x11153B0")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1115634", Offset = "0x1115634", VA = "0x1115634")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x11157B0", Offset = "0x11157B0", VA = "0x11157B0")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x11158FC", Offset = "0x11158FC", VA = "0x11158FC")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1115B08", Offset = "0x1115B08", VA = "0x1115B08")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x1115C34", Offset = "0x1115C34", VA = "0x1115C34")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1115D60", Offset = "0x1115D60", VA = "0x1115D60")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1115E8C", Offset = "0x1115E8C", VA = "0x1115E8C")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1115E94", Offset = "0x1115E94", VA = "0x1115E94")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1115E9C", Offset = "0x1115E9C", VA = "0x1115E9C")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1115EA4", Offset = "0x1115EA4", VA = "0x1115EA4")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1115F50", Offset = "0x1115F50", VA = "0x1115F50")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1116030", Offset = "0x1116030", VA = "0x1116030")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1116068", Offset = "0x1116068", VA = "0x1116068")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x11161BC", Offset = "0x11161BC", VA = "0x11161BC")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1116208", Offset = "0x1116208", VA = "0x1116208")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1116214", Offset = "0x1116214", VA = "0x1116214")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x111621C", Offset = "0x111621C", VA = "0x111621C")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1116228", Offset = "0x1116228", VA = "0x1116228")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1116230", Offset = "0x1116230", VA = "0x1116230")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x1116250", Offset = "0x1116250", VA = "0x1116250")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1116278", Offset = "0x1116278", VA = "0x1116278")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x11162C4", Offset = "0x11162C4", VA = "0x11162C4")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x11162CC", Offset = "0x11162CC", VA = "0x11162CC")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x11162DC", Offset = "0x11162DC", VA = "0x11162DC")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x11162EC", Offset = "0x11162EC", VA = "0x11162EC")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x11162FC", Offset = "0x11162FC", VA = "0x11162FC")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x111630C", Offset = "0x111630C", VA = "0x111630C")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x111631C", Offset = "0x111631C", VA = "0x111631C")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x1116328", Offset = "0x1116328", VA = "0x1116328")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x1116344", Offset = "0x1116344", VA = "0x1116344")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x111634C", Offset = "0x111634C", VA = "0x111634C")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x1116368", Offset = "0x1116368", VA = "0x1116368")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x11163A4", Offset = "0x11163A4", VA = "0x11163A4")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x11163E4", Offset = "0x11163E4", VA = "0x11163E4")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1116424", Offset = "0x1116424", VA = "0x1116424")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1116488", Offset = "0x1116488", VA = "0x1116488")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x11164C0", Offset = "0x11164C0", VA = "0x11164C0")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x1116500", Offset = "0x1116500", VA = "0x1116500")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x1116540", Offset = "0x1116540", VA = "0x1116540")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x1116580", Offset = "0x1116580", VA = "0x1116580")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x11165C0", Offset = "0x11165C0", VA = "0x11165C0")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x1116600", Offset = "0x1116600", VA = "0x1116600")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x1116640", Offset = "0x1116640", VA = "0x1116640")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1116680", Offset = "0x1116680", VA = "0x1116680")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x11166B8", Offset = "0x11166B8", VA = "0x11166B8")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x11166F0", Offset = "0x11166F0", VA = "0x11166F0")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x1116754", Offset = "0x1116754", VA = "0x1116754")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x11167B8", Offset = "0x11167B8", VA = "0x11167B8")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1116814", Offset = "0x1116814", VA = "0x1116814")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1116870", Offset = "0x1116870", VA = "0x1116870")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x11168A0", Offset = "0x11168A0", VA = "0x11168A0")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x11169BC", Offset = "0x11169BC", VA = "0x11169BC")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1116A40", Offset = "0x1116A40", VA = "0x1116A40")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1116A78", Offset = "0x1116A78", VA = "0x1116A78")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1116BDC", Offset = "0x1116BDC", VA = "0x1116BDC")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1116C0C", Offset = "0x1116C0C", VA = "0x1116C0C")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1116C58", Offset = "0x1116C58", VA = "0x1116C58")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1116C60", Offset = "0x1116C60", VA = "0x1116C60")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x11162BC", Offset = "0x11162BC", VA = "0x11162BC")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1116C90", Offset = "0x1116C90", VA = "0x1116C90")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1116C98", Offset = "0x1116C98", VA = "0x1116C98")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1116CA0", Offset = "0x1116CA0", VA = "0x1116CA0")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1116CA8", Offset = "0x1116CA8", VA = "0x1116CA8")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1116CEC", Offset = "0x1116CEC", VA = "0x1116CEC")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1116D24", Offset = "0x1116D24", VA = "0x1116D24")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1116F60", Offset = "0x1116F60", VA = "0x1116F60")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1116F68", Offset = "0x1116F68", VA = "0x1116F68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C014C", Offset = "0x5C014C")]
	private void <setMoveX>b__71_0()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1116FAC", Offset = "0x1116FAC", VA = "0x1116FAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C015C", Offset = "0x5C015C")]
	private void <setMoveX>b__71_1()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1117090", Offset = "0x1117090", VA = "0x1117090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C016C", Offset = "0x5C016C")]
	private void <setMoveY>b__72_0()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x11170D4", Offset = "0x11170D4", VA = "0x11170D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C017C", Offset = "0x5C017C")]
	private void <setMoveY>b__72_1()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x11171B0", Offset = "0x11171B0", VA = "0x11171B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C018C", Offset = "0x5C018C")]
	private void <setMoveZ>b__73_0()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x11171F4", Offset = "0x11171F4", VA = "0x11171F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C019C", Offset = "0x5C019C")]
	private void <setMoveZ>b__73_1()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x11172D4", Offset = "0x11172D4", VA = "0x11172D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01AC", Offset = "0x5C01AC")]
	private void <setMoveLocalX>b__74_0()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1117318", Offset = "0x1117318", VA = "0x1117318")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01BC", Offset = "0x5C01BC")]
	private void <setMoveLocalX>b__74_1()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x11173FC", Offset = "0x11173FC", VA = "0x11173FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01CC", Offset = "0x5C01CC")]
	private void <setMoveLocalY>b__75_0()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1117440", Offset = "0x1117440", VA = "0x1117440")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01DC", Offset = "0x5C01DC")]
	private void <setMoveLocalY>b__75_1()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x111751C", Offset = "0x111751C", VA = "0x111751C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01EC", Offset = "0x5C01EC")]
	private void <setMoveLocalZ>b__76_0()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x1117560", Offset = "0x1117560", VA = "0x1117560")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C01FC", Offset = "0x5C01FC")]
	private void <setMoveLocalZ>b__76_1()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x1117640", Offset = "0x1117640", VA = "0x1117640")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C020C", Offset = "0x5C020C")]
	private void <setMoveCurved>b__78_0()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x1117834", Offset = "0x1117834", VA = "0x1117834")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C021C", Offset = "0x5C021C")]
	private void <setMoveCurvedLocal>b__79_0()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x1117A28", Offset = "0x1117A28", VA = "0x1117A28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C022C", Offset = "0x5C022C")]
	private void <setMoveSpline>b__80_0()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1117C24", Offset = "0x1117C24", VA = "0x1117C24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C023C", Offset = "0x5C023C")]
	private void <setMoveSplineLocal>b__81_0()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x1117E20", Offset = "0x1117E20", VA = "0x1117E20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C024C", Offset = "0x5C024C")]
	private void <setScaleX>b__82_0()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1117E64", Offset = "0x1117E64", VA = "0x1117E64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C025C", Offset = "0x5C025C")]
	private void <setScaleX>b__82_1()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x1117F48", Offset = "0x1117F48", VA = "0x1117F48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C026C", Offset = "0x5C026C")]
	private void <setScaleY>b__83_0()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x1117F8C", Offset = "0x1117F8C", VA = "0x1117F8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C027C", Offset = "0x5C027C")]
	private void <setScaleY>b__83_1()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1118068", Offset = "0x1118068", VA = "0x1118068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C028C", Offset = "0x5C028C")]
	private void <setScaleZ>b__84_0()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x11180AC", Offset = "0x11180AC", VA = "0x11180AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C029C", Offset = "0x5C029C")]
	private void <setScaleZ>b__84_1()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x111818C", Offset = "0x111818C", VA = "0x111818C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02AC", Offset = "0x5C02AC")]
	private void <setRotateX>b__85_0()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x1118258", Offset = "0x1118258", VA = "0x1118258")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02BC", Offset = "0x5C02BC")]
	private void <setRotateX>b__85_1()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x111833C", Offset = "0x111833C", VA = "0x111833C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02CC", Offset = "0x5C02CC")]
	private void <setRotateY>b__86_0()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x1118408", Offset = "0x1118408", VA = "0x1118408")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02DC", Offset = "0x5C02DC")]
	private void <setRotateY>b__86_1()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x11184E4", Offset = "0x11184E4", VA = "0x11184E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02EC", Offset = "0x5C02EC")]
	private void <setRotateZ>b__87_0()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x11185B0", Offset = "0x11185B0", VA = "0x11185B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C02FC", Offset = "0x5C02FC")]
	private void <setRotateZ>b__87_1()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x1118690", Offset = "0x1118690", VA = "0x1118690")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C030C", Offset = "0x5C030C")]
	private void <setRotateAround>b__88_0()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x11186F8", Offset = "0x11186F8", VA = "0x11186F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C031C", Offset = "0x5C031C")]
	private void <setRotateAround>b__88_1()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x1118B14", Offset = "0x1118B14", VA = "0x1118B14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C032C", Offset = "0x5C032C")]
	private void <setRotateAroundLocal>b__89_0()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x1118B7C", Offset = "0x1118B7C", VA = "0x1118B7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C033C", Offset = "0x5C033C")]
	private void <setRotateAroundLocal>b__89_1()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x1118FC0", Offset = "0x1118FC0", VA = "0x1118FC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C034C", Offset = "0x5C034C")]
	private void <setAlpha>b__90_0()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x111988C", Offset = "0x111988C", VA = "0x111988C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C035C", Offset = "0x5C035C")]
	private void <setAlpha>b__90_2()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x1119A9C", Offset = "0x1119A9C", VA = "0x1119A9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C036C", Offset = "0x5C036C")]
	private void <setAlpha>b__90_1()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x1119CC0", Offset = "0x1119CC0", VA = "0x1119CC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C037C", Offset = "0x5C037C")]
	private void <setTextAlpha>b__91_0()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x1119DC8", Offset = "0x1119DC8", VA = "0x1119DC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C038C", Offset = "0x5C038C")]
	private void <setTextAlpha>b__91_1()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x1119E14", Offset = "0x1119E14", VA = "0x1119E14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C039C", Offset = "0x5C039C")]
	private void <setAlphaVertex>b__92_0()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x1119F0C", Offset = "0x1119F0C", VA = "0x1119F0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03AC", Offset = "0x5C03AC")]
	private void <setAlphaVertex>b__92_1()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x111A27C", Offset = "0x111A27C", VA = "0x111A27C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03BC", Offset = "0x5C03BC")]
	private void <setColor>b__93_0()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x111AB40", Offset = "0x111AB40", VA = "0x111AB40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03CC", Offset = "0x5C03CC")]
	private void <setColor>b__93_1()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x111AE48", Offset = "0x111AE48", VA = "0x111AE48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03DC", Offset = "0x5C03DC")]
	private void <setCallbackColor>b__94_0()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x111AE98", Offset = "0x111AE98", VA = "0x111AE98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03EC", Offset = "0x5C03EC")]
	private void <setCallbackColor>b__94_1()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x111B188", Offset = "0x111B188", VA = "0x111B188")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C03FC", Offset = "0x5C03FC")]
	private void <setTextColor>b__95_0()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x111B2AC", Offset = "0x111B2AC", VA = "0x111B2AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C040C", Offset = "0x5C040C")]
	private void <setTextColor>b__95_1()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x111B49C", Offset = "0x111B49C", VA = "0x111B49C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C041C", Offset = "0x5C041C")]
	private void <setCanvasAlpha>b__96_0()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x111B624", Offset = "0x111B624", VA = "0x111B624")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C042C", Offset = "0x5C042C")]
	private void <setCanvasAlpha>b__96_1()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x111B878", Offset = "0x111B878", VA = "0x111B878")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C043C", Offset = "0x5C043C")]
	private void <setCanvasGroupAlpha>b__97_0()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x111B914", Offset = "0x111B914", VA = "0x111B914")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C044C", Offset = "0x5C044C")]
	private void <setCanvasGroupAlpha>b__97_1()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x111B9E4", Offset = "0x111B9E4", VA = "0x111B9E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C045C", Offset = "0x5C045C")]
	private void <setCanvasColor>b__98_0()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x111BB88", Offset = "0x111BB88", VA = "0x111BB88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C046C", Offset = "0x5C046C")]
	private void <setCanvasColor>b__98_1()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x111BDE8", Offset = "0x111BDE8", VA = "0x111BDE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C047C", Offset = "0x5C047C")]
	private void <setCanvasMoveX>b__99_0()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x111BE2C", Offset = "0x111BE2C", VA = "0x111BE2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C048C", Offset = "0x5C048C")]
	private void <setCanvasMoveX>b__99_1()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x111BEEC", Offset = "0x111BEEC", VA = "0x111BEEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C049C", Offset = "0x5C049C")]
	private void <setCanvasMoveY>b__100_0()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x111BF30", Offset = "0x111BF30", VA = "0x111BF30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04AC", Offset = "0x5C04AC")]
	private void <setCanvasMoveY>b__100_1()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x111BFF0", Offset = "0x111BFF0", VA = "0x111BFF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04BC", Offset = "0x5C04BC")]
	private void <setCanvasMoveZ>b__101_0()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x111C034", Offset = "0x111C034", VA = "0x111C034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04CC", Offset = "0x5C04CC")]
	private void <setCanvasMoveZ>b__101_1()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x111C0F4", Offset = "0x111C0F4", VA = "0x111C0F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04DC", Offset = "0x5C04DC")]
	private void <setCanvasRotateAround>b__103_0()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x111C45C", Offset = "0x111C45C", VA = "0x111C45C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04EC", Offset = "0x5C04EC")]
	private void <setCanvasRotateAroundLocal>b__104_0()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x111C838", Offset = "0x111C838", VA = "0x111C838")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C04FC", Offset = "0x5C04FC")]
	private void <setCanvasPlaySprite>b__105_0()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x111C8BC", Offset = "0x111C8BC", VA = "0x111C8BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C050C", Offset = "0x5C050C")]
	private void <setCanvasPlaySprite>b__105_1()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x111CAA0", Offset = "0x111CAA0", VA = "0x111CAA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C051C", Offset = "0x5C051C")]
	private void <setCanvasMove>b__106_0()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x111CAE8", Offset = "0x111CAE8", VA = "0x111CAE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C052C", Offset = "0x5C052C")]
	private void <setCanvasMove>b__106_1()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x111CB44", Offset = "0x111CB44", VA = "0x111CB44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C053C", Offset = "0x5C053C")]
	private void <setCanvasScale>b__107_0()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x111CB8C", Offset = "0x111CB8C", VA = "0x111CB8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C054C", Offset = "0x5C054C")]
	private void <setCanvasScale>b__107_1()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x111CBE8", Offset = "0x111CBE8", VA = "0x111CBE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C055C", Offset = "0x5C055C")]
	private void <setCanvasSizeDelta>b__108_0()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x111CCAC", Offset = "0x111CCAC", VA = "0x111CCAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C056C", Offset = "0x5C056C")]
	private void <setCanvasSizeDelta>b__108_1()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x111CD88", Offset = "0x111CD88", VA = "0x111CD88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C057C", Offset = "0x5C057C")]
	private void <setMove>b__112_0()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x111CDD0", Offset = "0x111CDD0", VA = "0x111CDD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C058C", Offset = "0x5C058C")]
	private void <setMove>b__112_1()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x111CEA0", Offset = "0x111CEA0", VA = "0x111CEA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C059C", Offset = "0x5C059C")]
	private void <setMoveLocal>b__113_0()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x111CEE8", Offset = "0x111CEE8", VA = "0x111CEE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05AC", Offset = "0x5C05AC")]
	private void <setMoveLocal>b__113_1()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x111CFB8", Offset = "0x111CFB8", VA = "0x111CFB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05BC", Offset = "0x5C05BC")]
	private void <setMoveToTransform>b__114_0()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x111D000", Offset = "0x111D000", VA = "0x111D000")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05CC", Offset = "0x5C05CC")]
	private void <setMoveToTransform>b__114_1()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x111D1B0", Offset = "0x111D1B0", VA = "0x111D1B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05DC", Offset = "0x5C05DC")]
	private void <setRotate>b__115_0()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x111D2E8", Offset = "0x111D2E8", VA = "0x111D2E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05EC", Offset = "0x5C05EC")]
	private void <setRotate>b__115_1()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x111D3B8", Offset = "0x111D3B8", VA = "0x111D3B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C05FC", Offset = "0x5C05FC")]
	private void <setRotateLocal>b__116_0()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x111D4F0", Offset = "0x111D4F0", VA = "0x111D4F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C060C", Offset = "0x5C060C")]
	private void <setRotateLocal>b__116_1()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x111D5C0", Offset = "0x111D5C0", VA = "0x111D5C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C061C", Offset = "0x5C061C")]
	private void <setScale>b__117_0()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x111D608", Offset = "0x111D608", VA = "0x111D608")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C062C", Offset = "0x5C062C")]
	private void <setScale>b__117_1()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x111D6D8", Offset = "0x111D6D8", VA = "0x111D6D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C063C", Offset = "0x5C063C")]
	private void <setGUIMove>b__118_0()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x111DAA4", Offset = "0x111DAA4", VA = "0x111DAA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C064C", Offset = "0x5C064C")]
	private void <setGUIMove>b__118_1()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x111DC04", Offset = "0x111DC04", VA = "0x111DC04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C065C", Offset = "0x5C065C")]
	private void <setGUIMoveMargin>b__119_0()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x111DD20", Offset = "0x111DD20", VA = "0x111DD20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C066C", Offset = "0x5C066C")]
	private void <setGUIMoveMargin>b__119_1()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x111DDBC", Offset = "0x111DDBC", VA = "0x111DDBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C067C", Offset = "0x5C067C")]
	private void <setGUIScale>b__120_0()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x111DEAC", Offset = "0x111DEAC", VA = "0x111DEAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C068C", Offset = "0x5C068C")]
	private void <setGUIScale>b__120_1()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x111E000", Offset = "0x111E000", VA = "0x111E000")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C069C", Offset = "0x5C069C")]
	private void <setGUIAlpha>b__121_0()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x111E040", Offset = "0x111E040", VA = "0x111E040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06AC", Offset = "0x5C06AC")]
	private void <setGUIAlpha>b__121_1()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x111E0A8", Offset = "0x111E0A8", VA = "0x111E0A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06BC", Offset = "0x5C06BC")]
	private void <setGUIRotate>b__122_0()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x111E50C", Offset = "0x111E50C", VA = "0x111E50C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06CC", Offset = "0x5C06CC")]
	private void <setGUIRotate>b__122_1()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x111E574", Offset = "0x111E574", VA = "0x111E574")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06DC", Offset = "0x5C06DC")]
	private void <setDelayedSound>b__123_0()
	{
	}
}
[Token(Token = "0x2000012")]
public class LTDescrOptional
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE40", Offset = "0x5BFE40")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE50", Offset = "0x5BFE50")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE60", Offset = "0x5BFE60")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE70", Offset = "0x5BFE70")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE80", Offset = "0x5BFE80")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFE90", Offset = "0x5BFE90")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEA0", Offset = "0x5BFEA0")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int initFrameCount;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEB0", Offset = "0x5BFEB0")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEC0", Offset = "0x5BFEC0")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFED0", Offset = "0x5BFED0")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEE0", Offset = "0x5BFEE0")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFEF0", Offset = "0x5BFEF0")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF00", Offset = "0x5BFF00")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF10", Offset = "0x5BFF10")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF20", Offset = "0x5BFF20")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF30", Offset = "0x5BFF30")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF40", Offset = "0x5BFF40")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF50", Offset = "0x5BFF50")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF60", Offset = "0x5BFF60")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF70", Offset = "0x5BFF70")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF80", Offset = "0x5BFF80")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x17000014")]
	public Transform toTrans
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x111D1A8", Offset = "0x111D1A8", VA = "0x111D1A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06EC", Offset = "0x5C06EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1116060", Offset = "0x1116060", VA = "0x1116060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C06FC", Offset = "0x5C06FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Vector3 point
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1111AC4", Offset = "0x1111AC4", VA = "0x1111AC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C070C", Offset = "0x5C070C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1116C4C", Offset = "0x1116C4C", VA = "0x1116C4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C071C", Offset = "0x5C071C")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Vector3 axis
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1111AD8", Offset = "0x1111AD8", VA = "0x1111AD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C072C", Offset = "0x5C072C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x110EC28", Offset = "0x110EC28", VA = "0x110EC28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C073C", Offset = "0x5C073C")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public float lastVal
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1118AF4", Offset = "0x1118AF4", VA = "0x1118AF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C074C", Offset = "0x5C074C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x1118B0C", Offset = "0x1118B0C", VA = "0x1118B0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C075C", Offset = "0x5C075C")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Quaternion origRotation
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1118AFC", Offset = "0x1118AFC", VA = "0x1118AFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C076C", Offset = "0x5C076C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x110C580", Offset = "0x110C580", VA = "0x110C580")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C077C", Offset = "0x5C077C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public LTBezierPath path
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x110E4D0", Offset = "0x110E4D0", VA = "0x110E4D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C078C", Offset = "0x5C078C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x11169B4", Offset = "0x11169B4", VA = "0x11169B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C079C", Offset = "0x5C079C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public LTSpline spline
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x110E4D8", Offset = "0x110E4D8", VA = "0x110E4D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07AC", Offset = "0x5C07AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1116F58", Offset = "0x1116F58", VA = "0x1116F58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07BC", Offset = "0x5C07BC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public LTRect ltRect
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x110EB2C", Offset = "0x110EB2C", VA = "0x110EB2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07CC", Offset = "0x5C07CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1116A70", Offset = "0x1116A70", VA = "0x1116A70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07DC", Offset = "0x5C07DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x111E6B0", Offset = "0x111E6B0", VA = "0x111E6B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07EC", Offset = "0x5C07EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x11164F8", Offset = "0x11164F8", VA = "0x11164F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C07FC", Offset = "0x5C07FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x111E6B8", Offset = "0x111E6B8", VA = "0x111E6B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C080C", Offset = "0x5C080C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1116538", Offset = "0x1116538", VA = "0x1116538")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C081C", Offset = "0x5C081C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x111E6C0", Offset = "0x111E6C0", VA = "0x111E6C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C082C", Offset = "0x5C082C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1116578", Offset = "0x1116578", VA = "0x1116578")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C083C", Offset = "0x5C083C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x111E6C8", Offset = "0x111E6C8", VA = "0x111E6C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C084C", Offset = "0x5C084C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x11165B8", Offset = "0x11165B8", VA = "0x11165B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C085C", Offset = "0x5C085C")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x111E6D0", Offset = "0x111E6D0", VA = "0x111E6D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C086C", Offset = "0x5C086C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x11165F8", Offset = "0x11165F8", VA = "0x11165F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C087C", Offset = "0x5C087C")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x111E6D8", Offset = "0x111E6D8", VA = "0x111E6D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C088C", Offset = "0x5C088C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x11167B0", Offset = "0x11167B0", VA = "0x11167B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C089C", Offset = "0x5C089C")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x111AE30", Offset = "0x111AE30", VA = "0x111AE30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08AC", Offset = "0x5C08AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1116638", Offset = "0x1116638", VA = "0x1116638")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08BC", Offset = "0x5C08BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x111AE38", Offset = "0x111AE38", VA = "0x111AE38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08CC", Offset = "0x5C08CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1116678", Offset = "0x1116678", VA = "0x1116678")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08DC", Offset = "0x5C08DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Action onComplete
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x110EB3C", Offset = "0x110EB3C", VA = "0x110EB3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08EC", Offset = "0x5C08EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x11163DC", Offset = "0x11163DC", VA = "0x11163DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C08FC", Offset = "0x5C08FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x110EB44", Offset = "0x110EB44", VA = "0x110EB44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C090C", Offset = "0x5C090C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x111641C", Offset = "0x111641C", VA = "0x111641C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C091C", Offset = "0x5C091C")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public object onCompleteParam
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x110EB34", Offset = "0x110EB34", VA = "0x110EB34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C092C", Offset = "0x5C092C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1116480", Offset = "0x1116480", VA = "0x1116480")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C093C", Offset = "0x5C093C")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public object onUpdateParam
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x111AE40", Offset = "0x111AE40", VA = "0x111AE40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C094C", Offset = "0x5C094C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x111674C", Offset = "0x111674C", VA = "0x111674C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C095C", Offset = "0x5C095C")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public Action onStart
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x110E124", Offset = "0x110E124", VA = "0x110E124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C096C", Offset = "0x5C096C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1116D1C", Offset = "0x1116D1C", VA = "0x1116D1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C097C", Offset = "0x5C097C")]
		set
		{
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x110AE24", Offset = "0x110AE24", VA = "0x110AE24")]
	public void reset()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x110E95C", Offset = "0x110E95C", VA = "0x110E95C")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x110AB70", Offset = "0x110AB70", VA = "0x110AB70")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000013")]
public class LTSeq
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public LTSeq previous;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public LTSeq current;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTDescr tween;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float totalDelay;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeScale;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int debugIter;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint counter;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toggle;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private uint _id;

	[Token(Token = "0x17000029")]
	public int id
	{
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x200FCB8", Offset = "0x200FCB8", VA = "0x200FCB8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x200FCC8", Offset = "0x200FCC8", VA = "0x200FCC8")]
	public void reset()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x200FCDC", Offset = "0x200FCDC", VA = "0x200FCDC")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x200FCFC", Offset = "0x200FCFC", VA = "0x200FCFC")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x20102E4", Offset = "0x20102E4", VA = "0x20102E4")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2010374", Offset = "0x2010374", VA = "0x2010374")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x20103CC", Offset = "0x20103CC", VA = "0x20103CC")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x2010630", Offset = "0x2010630", VA = "0x2010630")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x2010824", Offset = "0x2010824", VA = "0x2010824")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x20109F4", Offset = "0x20109F4", VA = "0x20109F4")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x2010598", Offset = "0x2010598", VA = "0x2010598")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x2010BEC", Offset = "0x2010BEC", VA = "0x2010BEC")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x2010C4C", Offset = "0x2010C4C", VA = "0x2010C4C")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x2010C7C", Offset = "0x2010C7C", VA = "0x2010C7C")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2010D74", Offset = "0x2010D74", VA = "0x2010D74")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2010D78", Offset = "0x2010D78", VA = "0x2010D78")]
	public LTSeq()
	{
	}
}
namespace DentedPixel
{
	[Token(Token = "0x2000014")]
	public class LeanDummy
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x110855C", Offset = "0x110855C", VA = "0x110855C")]
		public LeanDummy()
		{
		}
	}
}
namespace Crosstales
{
	[Token(Token = "0x2000015")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x2000023")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDC0", Offset = "0x5BFDC0")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string str;

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1106508", Offset = "0x1106508", VA = "0x1106508")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1108544", Offset = "0x1108544", VA = "0x1108544")]
			internal bool <CTContainsAny>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDD0", Offset = "0x5BFDD0")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000179")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string str;

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1106700", Offset = "0x1106700", VA = "0x1106700")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1108550", Offset = "0x1108550", VA = "0x1108550")]
			internal bool <CTContainsAll>b__0(string searchTerm)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000025")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDE0", Offset = "0x5BFDE0")]
		private sealed class <>c__20<T>
		{
			[Token(Token = "0x400017A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__20<T> <>9;

			[Token(Token = "0x400017B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__20_0;

			[Token(Token = "0x6000327")]
			public <>c__20()
			{
			}

			[Token(Token = "0x6000328")]
			internal string <CTToString>b__20_0(T element)
			{
				return null;
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x110610C", Offset = "0x110610C", VA = "0x110610C")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11061F8", Offset = "0x11061F8", VA = "0x11061F8")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1103304", Offset = "0x1103304", VA = "0x1103304")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1105700", Offset = "0x1105700", VA = "0x1105700")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1106240", Offset = "0x1106240", VA = "0x1106240")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1106318", Offset = "0x1106318", VA = "0x1106318")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1106510", Offset = "0x1106510", VA = "0x1106510")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x60002A4")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x1106708", Offset = "0x1106708", VA = "0x1106708")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x11069D4", Offset = "0x11069D4", VA = "0x11069D4")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x1106C00", Offset = "0x1106C00", VA = "0x1106C00")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x1106E78", Offset = "0x1106E78", VA = "0x1106E78")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x60002AB")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x1107144", Offset = "0x1107144", VA = "0x1107144")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x1107674", Offset = "0x1107674", VA = "0x1107674")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x1107ADC", Offset = "0x1107ADC", VA = "0x1107ADC")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x1107FAC", Offset = "0x1107FAC", VA = "0x1107FAC")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x11084DC", Offset = "0x11084DC", VA = "0x11084DC")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x2000016")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x400011F")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000120")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000121")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000122")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000123")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x4000124")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x4000125")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x4000126")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x4000127")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x4000128")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x4000129")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x400012A")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x400012B")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x400012C")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x400012D")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x400012E")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x400012F")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000130")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000131")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x4000132")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x4000133")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x4000134")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x4000135")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x4000136")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x4000137")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x4000138")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x4000139")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x400013A")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x400013B")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x400013C")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static string PREFIX_HTTP;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string PREFIX_HTTPS;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x1700002A")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1100ED8", Offset = "0x1100ED8", VA = "0x1100ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x1101074", Offset = "0x1101074", VA = "0x1101074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1101344", Offset = "0x1101344", VA = "0x1101344")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public abstract class BaseHelper
	{
		[Serializable]
		[Token(Token = "0x2000026")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFDF0", Offset = "0x5BFDF0")]
		private sealed class <>c
		{
			[Token(Token = "0x400017C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public static Func<string, bool> <>9__61_0;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<string, string> <>9__61_1;

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x1104E40", Offset = "0x1104E40", VA = "0x1104E40")]
			public <>c()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1104E48", Offset = "0x1104E48", VA = "0x1104E48")]
			internal bool <GetFiles>b__61_0(string extension)
			{
				return default(bool);
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1104EF8", Offset = "0x1104EF8", VA = "0x1104EF8")]
			internal string <GetFiles>b__61_1(string q)
			{
				return null;
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		protected static readonly Regex lineEndingsRegex;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly Regex cleanSpacesRegex;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected static readonly Regex cleanTagsRegex;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x4000155")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x1700002C")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x11014BC", Offset = "0x11014BC", VA = "0x11014BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x11014D8", Offset = "0x11014D8", VA = "0x11014D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002E")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x11014E0", Offset = "0x11014E0", VA = "0x11014E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x11014E8", Offset = "0x11014E8", VA = "0x11014E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x11014F0", Offset = "0x11014F0", VA = "0x11014F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x11015C0", Offset = "0x11015C0", VA = "0x11015C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000032")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x11015C8", Offset = "0x11015C8", VA = "0x11015C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x11015D0", Offset = "0x11015D0", VA = "0x11015D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x11015D8", Offset = "0x11015D8", VA = "0x11015D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x11015E0", Offset = "0x11015E0", VA = "0x11015E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x11015E8", Offset = "0x11015E8", VA = "0x11015E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x11015F0", Offset = "0x11015F0", VA = "0x11015F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x11015F8", Offset = "0x11015F8", VA = "0x11015F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x1100F8C", Offset = "0x1100F8C", VA = "0x1100F8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1101670", Offset = "0x1101670", VA = "0x1101670")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1101714", Offset = "0x1101714", VA = "0x1101714")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x11017E4", Offset = "0x11017E4", VA = "0x11017E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public static bool isEditor
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x1101888", Offset = "0x1101888", VA = "0x1101888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x110105C", Offset = "0x110105C", VA = "0x110105C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1101064", Offset = "0x1101064", VA = "0x1101064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x110106C", Offset = "0x110106C", VA = "0x110106C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public static bool isEditorMode
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1101958", Offset = "0x1101958", VA = "0x1101958")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x11019D4", Offset = "0x11019D4", VA = "0x11019D4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x11019DC", Offset = "0x11019DC", VA = "0x11019DC")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x17000044")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1101AD8", Offset = "0x1101AD8", VA = "0x1101AD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1101BB0", Offset = "0x1101BB0", VA = "0x1101BB0")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1101DF4", Offset = "0x1101DF4", VA = "0x1101DF4")]
		public static bool hasActiveClip(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1101FD4", Offset = "0x1101FD4", VA = "0x1101FD4")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1101158", Offset = "0x1101158", VA = "0x1101158")]
		public static string ValidatePath(string path, bool addEndDelimiter = true)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11022CC", Offset = "0x11022CC", VA = "0x11022CC")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11025EC", Offset = "0x11025EC", VA = "0x11025EC")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1102B68", Offset = "0x1102B68", VA = "0x1102B68")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1102D80", Offset = "0x1102D80", VA = "0x1102D80")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1103120", Offset = "0x1103120", VA = "0x1103120")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x11033C4", Offset = "0x11033C4", VA = "0x11033C4")]
		public static string ClearTags(string text)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11034B0", Offset = "0x11034B0", VA = "0x11034B0")]
		public static string ClearSpaces(string text)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1103590", Offset = "0x1103590", VA = "0x1103590")]
		public static string ClearLineEndings(string text)
		{
			return null;
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x110367C", Offset = "0x110367C", VA = "0x110367C")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1103980", Offset = "0x1103980", VA = "0x1103980")]
		public static string FormatBytesToHRF(long bytes)
		{
			return null;
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1103CE0", Offset = "0x1103CE0", VA = "0x1103CE0")]
		public static string FormatSecondsToHourMinSec(double seconds)
		{
			return null;
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1104528", Offset = "0x1104528", VA = "0x1104528")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1102FA0", Offset = "0x1102FA0", VA = "0x1102FA0")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1104754", Offset = "0x1104754", VA = "0x1104754")]
		public static void FileCopy(string inputFile, string outputFile, bool move = false)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1104AE4", Offset = "0x1104AE4", VA = "0x1104AE4")]
		public static void ShowFileLocation(string file)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1104BA0", Offset = "0x1104BA0", VA = "0x1104BA0")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1104C5C", Offset = "0x1104C5C", VA = "0x1104C5C")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public static class CTPlayerPrefs
	{
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly SerializableDictionary<string, string> content;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly string fileName;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1104F00", Offset = "0x1104F00", VA = "0x1104F00")]
		static CTPlayerPrefs()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1105078", Offset = "0x1105078", VA = "0x1105078")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1105134", Offset = "0x1105134", VA = "0x1105134")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11051E8", Offset = "0x11051E8", VA = "0x11051E8")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x11052A4", Offset = "0x11052A4", VA = "0x11052A4")]
		public static void Save()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11053FC", Offset = "0x11053FC", VA = "0x11053FC")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11054B8", Offset = "0x11054B8", VA = "0x11054B8")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1105558", Offset = "0x1105558", VA = "0x1105558")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11055F8", Offset = "0x11055F8", VA = "0x11055F8")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11057C8", Offset = "0x11057C8", VA = "0x11057C8")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1105928", Offset = "0x1105928", VA = "0x1105928")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1105AD0", Offset = "0x1105AD0", VA = "0x1105AD0")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1105B70", Offset = "0x1105B70", VA = "0x1105B70")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1105C10", Offset = "0x1105C10", VA = "0x1105C10")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1105D24", Offset = "0x1105D24", VA = "0x1105D24")]
		public static void SetDate(string key, DateTime value)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFF90", Offset = "0x5BFF90")]
		private int <Timeout>k__BackingField;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5BFFA0", Offset = "0x5BFFA0")]
		private int <ConnectionLimit>k__BackingField;

		[Token(Token = "0x17000045")]
		public int Timeout
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x1105E34", Offset = "0x1105E34", VA = "0x1105E34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B0C", Offset = "0x5C0B0C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x1105E3C", Offset = "0x1105E3C", VA = "0x1105E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B1C", Offset = "0x5C0B1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000046")]
		public int ConnectionLimit
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x1105E44", Offset = "0x1105E44", VA = "0x1105E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B2C", Offset = "0x5C0B2C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x1105E4C", Offset = "0x1105E4C", VA = "0x1105E4C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5C0B3C", Offset = "0x5C0B3C")]
			set
			{
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1105E54", Offset = "0x1105E54", VA = "0x1105E54")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1105E78", Offset = "0x1105E78", VA = "0x1105E78")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1105EA0", Offset = "0x1105EA0", VA = "0x1105EA0")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1105F2C", Offset = "0x1105F2C", VA = "0x1105F2C", Slot = "17")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class SerializableDictionary<TKey, TVal> : Dictionary<TKey, TVal>, IXmlSerializable, ISerializable
	{
		[Token(Token = "0x400015A")]
		private const string ItemNodeName = "Item";

		[Token(Token = "0x400015B")]
		private const string KeyNodeName = "Key";

		[Token(Token = "0x400015C")]
		private const string ValueNodeName = "Value";

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XmlSerializer keySerializer;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private XmlSerializer valueSerializer;

		[Token(Token = "0x17000047")]
		private XmlSerializer ValueSerializer
		{
			[Token(Token = "0x6000309")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		private XmlSerializer KeySerializer
		{
			[Token(Token = "0x600030A")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FE")]
		public SerializableDictionary()
		{
		}

		[Token(Token = "0x60002FF")]
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary)
		{
		}

		[Token(Token = "0x6000300")]
		public SerializableDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000301")]
		public SerializableDictionary(int capacity)
		{
		}

		[Token(Token = "0x6000302")]
		public SerializableDictionary(IDictionary<TKey, TVal> dictionary, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000303")]
		public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000304")]
		protected SerializableDictionary(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000305")]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000306")]
		private void System.Xml.Serialization.IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		[Token(Token = "0x6000307")]
		private void System.Xml.Serialization.IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		[Token(Token = "0x6000308")]
		private XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema()
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	public static class XmlHelper
	{
		[Token(Token = "0x600030B")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x600030C")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x600030D")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x600030F")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x200001C")]
	public enum Platform
	{
		[Token(Token = "0x4000160")]
		Windows,
		[Token(Token = "0x4000161")]
		OSX,
		[Token(Token = "0x4000162")]
		Linux,
		[Token(Token = "0x4000163")]
		IOS,
		[Token(Token = "0x4000164")]
		Android,
		[Token(Token = "0x4000165")]
		WSA,
		[Token(Token = "0x4000166")]
		Web,
		[Token(Token = "0x4000167")]
		Unsupported,
		[Token(Token = "0x4000168")]
		MaryTTS
	}
}
