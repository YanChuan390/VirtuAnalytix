using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LeanAudioStream
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x12295F0", Offset = "0x12295F0", VA = "0x12295F0")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1229E2C", Offset = "0x1229E2C", VA = "0x1229E2C")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1229EB0", Offset = "0x1229EB0", VA = "0x1229EB0")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1228910", Offset = "0x1228910", VA = "0x1228910")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1228A6C", Offset = "0x1228A6C", VA = "0x1228A6C")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1229528", Offset = "0x1229528", VA = "0x1229528")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1228B48", Offset = "0x1228B48", VA = "0x1228B48")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1228FA8", Offset = "0x1228FA8", VA = "0x1228FA8")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1229624", Offset = "0x1229624", VA = "0x1229624")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1229628", Offset = "0x1229628", VA = "0x1229628")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x12297AC", Offset = "0x12297AC", VA = "0x12297AC")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x12299A4", Offset = "0x12299A4", VA = "0x12299A4")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1229A3C", Offset = "0x1229A3C", VA = "0x1229A3C")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1229ACC", Offset = "0x1229ACC", VA = "0x1229ACC")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1229868", Offset = "0x1229868", VA = "0x1229868")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1229B90", Offset = "0x1229B90", VA = "0x1229B90")]
	public static void printOutAudioClip(AudioClip audioClip, AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1229D40", Offset = "0x1229D40", VA = "0x1229D40")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000004")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000005")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000012")]
		Sine,
		[Token(Token = "0x4000013")]
		Square,
		[Token(Token = "0x4000014")]
		Sawtooth,
		[Token(Token = "0x4000015")]
		Noise
	}

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1228A48", Offset = "0x1228A48", VA = "0x1228A48")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1229DB8", Offset = "0x1229DB8", VA = "0x1229DB8")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1229DC0", Offset = "0x1229DC0", VA = "0x1229DC0")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1229DE8", Offset = "0x1229DE8", VA = "0x1229DE8")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1229DF0", Offset = "0x1229DF0", VA = "0x1229DF0")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1229DFC", Offset = "0x1229DFC", VA = "0x1229DFC")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1229E08", Offset = "0x1229E08", VA = "0x1229E08")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1229E14", Offset = "0x1229E14", VA = "0x1229E14")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1229E1C", Offset = "0x1229E1C", VA = "0x1229E1C")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1229E24", Offset = "0x1229E24", VA = "0x1229E24")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE84", Offset = "0x5FFE84")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x123857C", Offset = "0x123857C", VA = "0x123857C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x12385C4", Offset = "0x12385C4", VA = "0x12385C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x122AFEC", Offset = "0x122AFEC", VA = "0x122AFEC")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x12383F4", Offset = "0x12383F4", VA = "0x12383F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x12383F8", Offset = "0x12383F8", VA = "0x12383F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1238584", Offset = "0x1238584", VA = "0x1238584", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x122AF40", Offset = "0x122AF40", VA = "0x122AF40")]
	public void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x122AF6C", Offset = "0x122AF6C", VA = "0x122AF6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x6007EC", Offset = "0x6007EC")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x122B018", Offset = "0x122B018", VA = "0x122B018")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000008")]
public class LeanTest
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x1229EC0", Offset = "0x1229EC0", VA = "0x1229EC0")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1229F40", Offset = "0x1229F40", VA = "0x1229F40")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x122ADC4", Offset = "0x122ADC4", VA = "0x122ADC4")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x122A644", Offset = "0x122A644", VA = "0x122A644")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x122AE44", Offset = "0x122AE44", VA = "0x122AE44")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x122A77C", Offset = "0x122A77C", VA = "0x122A77C")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x122A7EC", Offset = "0x122A7EC", VA = "0x122A7EC")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x122A9E8", Offset = "0x122A9E8", VA = "0x122A9E8")]
	public static void overview()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x122AEB8", Offset = "0x122AEB8", VA = "0x122AEB8")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000009")]
public enum TweenAction
{
	[Token(Token = "0x4000022")]
	MOVE_X,
	[Token(Token = "0x4000023")]
	MOVE_Y,
	[Token(Token = "0x4000024")]
	MOVE_Z,
	[Token(Token = "0x4000025")]
	MOVE_LOCAL_X,
	[Token(Token = "0x4000026")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x4000027")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x4000028")]
	MOVE_CURVED,
	[Token(Token = "0x4000029")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x400002A")]
	MOVE_SPLINE,
	[Token(Token = "0x400002B")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x400002C")]
	SCALE_X,
	[Token(Token = "0x400002D")]
	SCALE_Y,
	[Token(Token = "0x400002E")]
	SCALE_Z,
	[Token(Token = "0x400002F")]
	ROTATE_X,
	[Token(Token = "0x4000030")]
	ROTATE_Y,
	[Token(Token = "0x4000031")]
	ROTATE_Z,
	[Token(Token = "0x4000032")]
	ROTATE_AROUND,
	[Token(Token = "0x4000033")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x4000034")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x4000035")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x4000036")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x4000037")]
	ALPHA,
	[Token(Token = "0x4000038")]
	TEXT_ALPHA,
	[Token(Token = "0x4000039")]
	CANVAS_ALPHA,
	[Token(Token = "0x400003A")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x400003B")]
	ALPHA_VERTEX,
	[Token(Token = "0x400003C")]
	COLOR,
	[Token(Token = "0x400003D")]
	CALLBACK_COLOR,
	[Token(Token = "0x400003E")]
	TEXT_COLOR,
	[Token(Token = "0x400003F")]
	CANVAS_COLOR,
	[Token(Token = "0x4000040")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000041")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x4000042")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x4000043")]
	CALLBACK,
	[Token(Token = "0x4000044")]
	MOVE,
	[Token(Token = "0x4000045")]
	MOVE_LOCAL,
	[Token(Token = "0x4000046")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x4000047")]
	ROTATE,
	[Token(Token = "0x4000048")]
	ROTATE_LOCAL,
	[Token(Token = "0x4000049")]
	SCALE,
	[Token(Token = "0x400004A")]
	VALUE3,
	[Token(Token = "0x400004B")]
	GUI_MOVE,
	[Token(Token = "0x400004C")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x400004D")]
	GUI_SCALE,
	[Token(Token = "0x400004E")]
	GUI_ALPHA,
	[Token(Token = "0x400004F")]
	GUI_ROTATE,
	[Token(Token = "0x4000050")]
	DELAYED_SOUND,
	[Token(Token = "0x4000051")]
	CANVAS_MOVE,
	[Token(Token = "0x4000052")]
	CANVAS_SCALE,
	[Token(Token = "0x4000053")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x200000A")]
public enum LeanTweenType
{
	[Token(Token = "0x4000055")]
	notUsed,
	[Token(Token = "0x4000056")]
	linear,
	[Token(Token = "0x4000057")]
	easeOutQuad,
	[Token(Token = "0x4000058")]
	easeInQuad,
	[Token(Token = "0x4000059")]
	easeInOutQuad,
	[Token(Token = "0x400005A")]
	easeInCubic,
	[Token(Token = "0x400005B")]
	easeOutCubic,
	[Token(Token = "0x400005C")]
	easeInOutCubic,
	[Token(Token = "0x400005D")]
	easeInQuart,
	[Token(Token = "0x400005E")]
	easeOutQuart,
	[Token(Token = "0x400005F")]
	easeInOutQuart,
	[Token(Token = "0x4000060")]
	easeInQuint,
	[Token(Token = "0x4000061")]
	easeOutQuint,
	[Token(Token = "0x4000062")]
	easeInOutQuint,
	[Token(Token = "0x4000063")]
	easeInSine,
	[Token(Token = "0x4000064")]
	easeOutSine,
	[Token(Token = "0x4000065")]
	easeInOutSine,
	[Token(Token = "0x4000066")]
	easeInExpo,
	[Token(Token = "0x4000067")]
	easeOutExpo,
	[Token(Token = "0x4000068")]
	easeInOutExpo,
	[Token(Token = "0x4000069")]
	easeInCirc,
	[Token(Token = "0x400006A")]
	easeOutCirc,
	[Token(Token = "0x400006B")]
	easeInOutCirc,
	[Token(Token = "0x400006C")]
	easeInBounce,
	[Token(Token = "0x400006D")]
	easeOutBounce,
	[Token(Token = "0x400006E")]
	easeInOutBounce,
	[Token(Token = "0x400006F")]
	easeInBack,
	[Token(Token = "0x4000070")]
	easeOutBack,
	[Token(Token = "0x4000071")]
	easeInOutBack,
	[Token(Token = "0x4000072")]
	easeInElastic,
	[Token(Token = "0x4000073")]
	easeOutElastic,
	[Token(Token = "0x4000074")]
	easeInOutElastic,
	[Token(Token = "0x4000075")]
	easeSpring,
	[Token(Token = "0x4000076")]
	easeShake,
	[Token(Token = "0x4000077")]
	punch,
	[Token(Token = "0x4000078")]
	once,
	[Token(Token = "0x4000079")]
	clamp,
	[Token(Token = "0x400007A")]
	pingPong,
	[Token(Token = "0x400007B")]
	animationCurve
}
[Token(Token = "0x200000B")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static LTDescr tween;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int tweenMaxSearch;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static int maxTweens;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int maxSequences;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int frameRendered;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static float dtEstimated;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public static float dtManual;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtActual;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static uint global_counter;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static int i;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static int j;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int finishedCnt;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static AnimationCurve punch;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve shake;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static int maxTweenReached;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public static int startSearch;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static LTDescr d;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static GameObject[] goListeners;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static int eventsMaxSearch;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public static int EVENTS_MAX;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000003")]
	public static int maxSearch
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x122B100", Offset = "0x122B100", VA = "0x122B100")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x122B164", Offset = "0x122B164", VA = "0x122B164")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x122B1C8", Offset = "0x122B1C8", VA = "0x122B1C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000006")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x122ECDC", Offset = "0x122ECDC", VA = "0x122ECDC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x122B028", Offset = "0x122B028", VA = "0x122B028")]
	public static void init()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x122B08C", Offset = "0x122B08C", VA = "0x122B08C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x122B2A4", Offset = "0x122B2A4", VA = "0x122B2A4")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x122B794", Offset = "0x122B794", VA = "0x122B794")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x122B930", Offset = "0x122B930", VA = "0x122B930")]
	public void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x122BDC4", Offset = "0x122BDC4", VA = "0x122BDC4")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x122BE38", Offset = "0x122BE38", VA = "0x122BE38")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x122B988", Offset = "0x122B988", VA = "0x122B988")]
	public static void update()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x122C25C", Offset = "0x122C25C", VA = "0x122C25C")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x122BE90", Offset = "0x122BE90", VA = "0x122BE90")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x122C338", Offset = "0x122C338", VA = "0x122C338")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x122C4DC", Offset = "0x122C4DC", VA = "0x122C4DC")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x122C52C", Offset = "0x122C52C", VA = "0x122C52C")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x122C588", Offset = "0x122C588", VA = "0x122C588")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x122C78C", Offset = "0x122C78C", VA = "0x122C78C")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x122C7F8", Offset = "0x122C7F8", VA = "0x122C7F8")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x122CA60", Offset = "0x122CA60", VA = "0x122CA60")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x122CAE0", Offset = "0x122CAE0", VA = "0x122CAE0")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x122CD94", Offset = "0x122CD94", VA = "0x122CD94")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x122CEC0", Offset = "0x122CEC0", VA = "0x122CEC0")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x122CF2C", Offset = "0x122CF2C", VA = "0x122CF2C")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x122D1D0", Offset = "0x122D1D0", VA = "0x122D1D0")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x122D464", Offset = "0x122D464", VA = "0x122D464")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x122D4CC", Offset = "0x122D4CC", VA = "0x122D4CC")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x122D75C", Offset = "0x122D75C", VA = "0x122D75C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6008A4", Offset = "0x6008A4")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x122D7C4", Offset = "0x122D7C4", VA = "0x122D7C4")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x122D8C4", Offset = "0x122D8C4", VA = "0x122D8C4")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x122DA40", Offset = "0x122DA40", VA = "0x122DA40")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x122DB28", Offset = "0x122DB28", VA = "0x122DB28")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x122DC10", Offset = "0x122DC10", VA = "0x122DC10")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6008DC", Offset = "0x6008DC")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x122DC78", Offset = "0x122DC78", VA = "0x122DC78")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x122DD78", Offset = "0x122DD78", VA = "0x122DD78")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x122DEF4", Offset = "0x122DEF4", VA = "0x122DEF4")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x122E120", Offset = "0x122E120", VA = "0x122E120")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x122E19C", Offset = "0x122E19C", VA = "0x122E19C")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x122E2C4", Offset = "0x122E2C4", VA = "0x122E2C4")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x122E3F4", Offset = "0x122E3F4", VA = "0x122E3F4")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1227780", Offset = "0x1227780", VA = "0x1227780")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x122E85C", Offset = "0x122E85C", VA = "0x122E85C")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x122E8D8", Offset = "0x122E8D8", VA = "0x122E8D8")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x122ED50", Offset = "0x122ED50", VA = "0x122ED50")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x122EE6C", Offset = "0x122EE6C", VA = "0x122EE6C")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x122EF64", Offset = "0x122EF64", VA = "0x122EF64")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1226944", Offset = "0x1226944", VA = "0x1226944")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x122F048", Offset = "0x122F048", VA = "0x122F048")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x122F104", Offset = "0x122F104", VA = "0x122F104")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x122F1B4", Offset = "0x122F1B4", VA = "0x122F1B4")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x122F264", Offset = "0x122F264", VA = "0x122F264")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x122F314", Offset = "0x122F314", VA = "0x122F314")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x122F3B4", Offset = "0x122F3B4", VA = "0x122F3B4")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x122F4CC", Offset = "0x122F4CC", VA = "0x122F4CC")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x122F5B0", Offset = "0x122F5B0", VA = "0x122F5B0")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1226CC8", Offset = "0x1226CC8", VA = "0x1226CC8")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1226EAC", Offset = "0x1226EAC", VA = "0x1226EAC")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1227010", Offset = "0x1227010", VA = "0x1227010")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1227188", Offset = "0x1227188", VA = "0x1227188")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x122F694", Offset = "0x122F694", VA = "0x122F694")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x122F774", Offset = "0x122F774", VA = "0x122F774")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x122F824", Offset = "0x122F824", VA = "0x122F824")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x122F8E8", Offset = "0x122F8E8", VA = "0x122F8E8")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x122FA90", Offset = "0x122FA90", VA = "0x122FA90")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x122FB74", Offset = "0x122FB74", VA = "0x122FB74")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x122FC58", Offset = "0x122FC58", VA = "0x122FC58")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x122FD88", Offset = "0x122FD88", VA = "0x122FD88")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x122FE6C", Offset = "0x122FE6C", VA = "0x122FE6C")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x122FF9C", Offset = "0x122FF9C", VA = "0x122FF9C")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1230060", Offset = "0x1230060", VA = "0x1230060")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1230124", Offset = "0x1230124", VA = "0x1230124")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x12301C4", Offset = "0x12301C4", VA = "0x12301C4")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1230264", Offset = "0x1230264", VA = "0x1230264")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1230304", Offset = "0x1230304", VA = "0x1230304")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x12303B4", Offset = "0x12303B4", VA = "0x12303B4")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x123055C", Offset = "0x123055C", VA = "0x123055C")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x12305FC", Offset = "0x12305FC", VA = "0x12305FC")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x123069C", Offset = "0x123069C", VA = "0x123069C")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x123073C", Offset = "0x123073C", VA = "0x123073C")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1230820", Offset = "0x1230820", VA = "0x1230820")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1230904", Offset = "0x1230904", VA = "0x1230904")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x12309D0", Offset = "0x12309D0", VA = "0x12309D0")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1230A80", Offset = "0x1230A80", VA = "0x1230A80")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1230B38", Offset = "0x1230B38", VA = "0x1230B38")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1230BE8", Offset = "0x1230BE8", VA = "0x1230BE8")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1230C88", Offset = "0x1230C88", VA = "0x1230C88")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1230D28", Offset = "0x1230D28", VA = "0x1230D28")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1230DC8", Offset = "0x1230DC8", VA = "0x1230DC8")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1230E9C", Offset = "0x1230E9C", VA = "0x1230E9C")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1230F70", Offset = "0x1230F70", VA = "0x1230F70")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1231020", Offset = "0x1231020", VA = "0x1231020")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x12310E4", Offset = "0x12310E4", VA = "0x12310E4")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1231184", Offset = "0x1231184", VA = "0x1231184")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1231224", Offset = "0x1231224", VA = "0x1231224")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x12312C4", Offset = "0x12312C4", VA = "0x12312C4")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1231388", Offset = "0x1231388", VA = "0x1231388")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1231448", Offset = "0x1231448", VA = "0x1231448")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1231534", Offset = "0x1231534", VA = "0x1231534")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1231618", Offset = "0x1231618", VA = "0x1231618")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1231774", Offset = "0x1231774", VA = "0x1231774")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1231864", Offset = "0x1231864", VA = "0x1231864")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1231954", Offset = "0x1231954", VA = "0x1231954")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1231A9C", Offset = "0x1231A9C", VA = "0x1231A9C")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1231BE4", Offset = "0x1231BE4", VA = "0x1231BE4")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1231CE4", Offset = "0x1231CE4", VA = "0x1231CE4")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x1231DF4", Offset = "0x1231DF4", VA = "0x1231DF4")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x1231EE8", Offset = "0x1231EE8", VA = "0x1231EE8")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x1231FE0", Offset = "0x1231FE0", VA = "0x1231FE0")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x12320D4", Offset = "0x12320D4", VA = "0x12320D4")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x12321A4", Offset = "0x12321A4", VA = "0x12321A4")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1232264", Offset = "0x1232264", VA = "0x1232264")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1232324", Offset = "0x1232324", VA = "0x1232324")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x12323E4", Offset = "0x12323E4", VA = "0x12323E4")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x12324C0", Offset = "0x12324C0", VA = "0x12324C0")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x12325AC", Offset = "0x12325AC", VA = "0x12325AC")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x12326A0", Offset = "0x12326A0", VA = "0x12326A0")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1232794", Offset = "0x1232794", VA = "0x1232794")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1232864", Offset = "0x1232864", VA = "0x1232864")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1232930", Offset = "0x1232930", VA = "0x1232930")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x12329F0", Offset = "0x12329F0", VA = "0x12329F0")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1232AE4", Offset = "0x1232AE4", VA = "0x1232AE4")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1232B30", Offset = "0x1232B30", VA = "0x1232B30")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1232C0C", Offset = "0x1232C0C", VA = "0x1232C0C")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1232C24", Offset = "0x1232C24", VA = "0x1232C24")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1232C34", Offset = "0x1232C34", VA = "0x1232C34")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1232C84", Offset = "0x1232C84", VA = "0x1232C84")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1232D04", Offset = "0x1232D04", VA = "0x1232D04")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1232D0C", Offset = "0x1232D0C", VA = "0x1232D0C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1232D70", Offset = "0x1232D70", VA = "0x1232D70")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1232E24", Offset = "0x1232E24", VA = "0x1232E24")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1232E38", Offset = "0x1232E38", VA = "0x1232E38")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1232E54", Offset = "0x1232E54", VA = "0x1232E54")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1232EA8", Offset = "0x1232EA8", VA = "0x1232EA8")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1232EE0", Offset = "0x1232EE0", VA = "0x1232EE0")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1232EF8", Offset = "0x1232EF8", VA = "0x1232EF8")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1232F20", Offset = "0x1232F20", VA = "0x1232F20")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1232F78", Offset = "0x1232F78", VA = "0x1232F78")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1232F94", Offset = "0x1232F94", VA = "0x1232F94")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1232FBC", Offset = "0x1232FBC", VA = "0x1232FBC")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1233018", Offset = "0x1233018", VA = "0x1233018")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x1233038", Offset = "0x1233038", VA = "0x1233038")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x1233068", Offset = "0x1233068", VA = "0x1233068")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x12330D0", Offset = "0x12330D0", VA = "0x12330D0")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x123310C", Offset = "0x123310C", VA = "0x123310C")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1233144", Offset = "0x1233144", VA = "0x1233144")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x123318C", Offset = "0x123318C", VA = "0x123318C")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x12331C8", Offset = "0x12331C8", VA = "0x12331C8")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1233204", Offset = "0x1233204", VA = "0x1233204")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1233278", Offset = "0x1233278", VA = "0x1233278")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x12332A0", Offset = "0x12332A0", VA = "0x12332A0")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x12332C8", Offset = "0x12332C8", VA = "0x12332C8")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x123331C", Offset = "0x123331C", VA = "0x123331C")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x12333B0", Offset = "0x12333B0", VA = "0x12333B0")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1233478", Offset = "0x1233478", VA = "0x1233478")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x123354C", Offset = "0x123354C", VA = "0x123354C")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1233580", Offset = "0x1233580", VA = "0x1233580")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x12335C0", Offset = "0x12335C0", VA = "0x12335C0")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1233658", Offset = "0x1233658", VA = "0x1233658")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1233734", Offset = "0x1233734", VA = "0x1233734")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x1233808", Offset = "0x1233808", VA = "0x1233808")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x123395C", Offset = "0x123395C", VA = "0x123395C")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x12339D0", Offset = "0x12339D0", VA = "0x12339D0")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1233EBC", Offset = "0x1233EBC", VA = "0x1233EBC")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1234174", Offset = "0x1234174", VA = "0x1234174")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1233F30", Offset = "0x1233F30", VA = "0x1233F30")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1234254", Offset = "0x1234254", VA = "0x1234254")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x12342C0", Offset = "0x12342C0", VA = "0x12342C0")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1234514", Offset = "0x1234514", VA = "0x1234514")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000C")]
public class LTUtility
{
	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1228860", Offset = "0x1228860", VA = "0x1228860")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1228908", Offset = "0x1228908", VA = "0x1228908")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200000D")]
public class LTBezier
{
	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x124ECC4", Offset = "0x124ECC4", VA = "0x124ECC4")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x124EF90", Offset = "0x124EF90", VA = "0x124EF90")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x124EF38", Offset = "0x124EF38", VA = "0x124EF38")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x124F0C4", Offset = "0x124F0C4", VA = "0x124F0C4")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000E")]
public class LTBezierPath
{
	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x17000007")]
	public float distance
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x124F4BC", Offset = "0x124F4BC", VA = "0x124F4BC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x124F0E8", Offset = "0x124F0E8", VA = "0x124F0E8")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x124F0F0", Offset = "0x124F0F0", VA = "0x124F0F0")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x124F120", Offset = "0x124F120", VA = "0x124F120")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x124F4C4", Offset = "0x124F4C4", VA = "0x124F4C4")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x124F59C", Offset = "0x124F59C", VA = "0x124F59C")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x124F654", Offset = "0x124F654", VA = "0x124F654")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x124F70C", Offset = "0x124F70C", VA = "0x124F70C")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x124F764", Offset = "0x124F764", VA = "0x124F764")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x124F804", Offset = "0x124F804", VA = "0x124F804")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x124F85C", Offset = "0x124F85C", VA = "0x124F85C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x124F998", Offset = "0x124F998", VA = "0x124F998")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x124F9D0", Offset = "0x124F9D0", VA = "0x124F9D0")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class LTSpline
{
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x122737C", Offset = "0x122737C", VA = "0x122737C")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1227734", Offset = "0x1227734", VA = "0x1227734")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x12273B8", Offset = "0x12273B8", VA = "0x12273B8")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1227A18", Offset = "0x1227A18", VA = "0x1227A18")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1227850", Offset = "0x1227850", VA = "0x1227850")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1227B2C", Offset = "0x1227B2C", VA = "0x1227B2C")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1227C08", Offset = "0x1227C08", VA = "0x1227C08")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1227C20", Offset = "0x1227C20", VA = "0x1227C20")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1227CD8", Offset = "0x1227CD8", VA = "0x1227CD8")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1227E2C", Offset = "0x1227E2C", VA = "0x1227E2C")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1227E84", Offset = "0x1227E84", VA = "0x1227E84")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1227F24", Offset = "0x1227F24", VA = "0x1227F24")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1227F7C", Offset = "0x1227F7C", VA = "0x1227F7C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x122804C", Offset = "0x122804C", VA = "0x122804C")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1228114", Offset = "0x1228114", VA = "0x1228114")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1228278", Offset = "0x1228278", VA = "0x1228278")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x12284C0", Offset = "0x12284C0", VA = "0x12284C0")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x12284D4", Offset = "0x12284D4", VA = "0x12284D4")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x12286B0", Offset = "0x12286B0", VA = "0x12286B0")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class LTRect
{
	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000008")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1224DBC", Offset = "0x1224DBC", VA = "0x1224DBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public int id
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1225678", Offset = "0x1225678", VA = "0x1225678")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000A")]
	public float x
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1226308", Offset = "0x1226308", VA = "0x1226308")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1226314", Offset = "0x1226314", VA = "0x1226314")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float y
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1226320", Offset = "0x1226320", VA = "0x1226320")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x122632C", Offset = "0x122632C", VA = "0x122632C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float width
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1226338", Offset = "0x1226338", VA = "0x1226338")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1226344", Offset = "0x1226344", VA = "0x1226344")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float height
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1226350", Offset = "0x1226350", VA = "0x1226350")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x122635C", Offset = "0x122635C", VA = "0x122635C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Rect rect
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x122494C", Offset = "0x122494C", VA = "0x122494C")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1226368", Offset = "0x1226368", VA = "0x1226368")]
		set
		{
		}
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1225CCC", Offset = "0x1225CCC", VA = "0x1225CCC")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1224FA8", Offset = "0x1224FA8", VA = "0x1224FA8")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1225DE8", Offset = "0x1225DE8", VA = "0x1225DE8")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1225EC0", Offset = "0x1225EC0", VA = "0x1225EC0")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1225FA0", Offset = "0x1225FA0", VA = "0x1225FA0")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1225684", Offset = "0x1225684", VA = "0x1225684")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x1225DA4", Offset = "0x1225DA4", VA = "0x1225DA4")]
	public void reset()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x1226098", Offset = "0x1226098", VA = "0x1226098")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x1226374", Offset = "0x1226374", VA = "0x1226374")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x122639C", Offset = "0x122639C", VA = "0x122639C")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x12263A8", Offset = "0x12263A8", VA = "0x12263A8")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x12263BC", Offset = "0x12263BC", VA = "0x12263BC")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x12263C4", Offset = "0x12263C4", VA = "0x12263C4")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x12263EC", Offset = "0x12263EC", VA = "0x12263EC")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1226400", Offset = "0x1226400", VA = "0x1226400")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x122646C", Offset = "0x122646C", VA = "0x122646C")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1226478", Offset = "0x1226478", VA = "0x1226478", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000011")]
public class LTEvent
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x122392C", Offset = "0x122392C", VA = "0x122392C")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000012")]
public class LTGUI
{
	[Token(Token = "0x2000013")]
	public enum Element_Type
	{
		[Token(Token = "0x40000D8")]
		Texture,
		[Token(Token = "0x40000D9")]
		Label
	}

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1223970", Offset = "0x1223970", VA = "0x1223970")]
	public static void init()
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1223A84", Offset = "0x1223A84", VA = "0x1223A84")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1223C40", Offset = "0x1223C40", VA = "0x1223C40")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1223DE0", Offset = "0x1223DE0", VA = "0x1223DE0")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1224B58", Offset = "0x1224B58", VA = "0x1224B58")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1224C38", Offset = "0x1224C38", VA = "0x1224C38")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1224DCC", Offset = "0x1224DCC", VA = "0x1224DCC")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x1224ED8", Offset = "0x1224ED8", VA = "0x1224ED8")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x122506C", Offset = "0x122506C", VA = "0x122506C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x1225518", Offset = "0x1225518", VA = "0x1225518")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x12255E8", Offset = "0x12255E8", VA = "0x12255E8")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x1225100", Offset = "0x1225100", VA = "0x1225100")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x122568C", Offset = "0x122568C", VA = "0x122568C")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x12259BC", Offset = "0x12259BC", VA = "0x12259BC")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1225B58", Offset = "0x1225B58", VA = "0x1225B58")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1225ADC", Offset = "0x1225ADC", VA = "0x1225ADC")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x1225C2C", Offset = "0x1225C2C", VA = "0x1225C2C")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000014")]
public class LTDescr
{
	[Token(Token = "0x2000015")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000016")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFE94", Offset = "0x5FFE94")]
	private sealed class <>c
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__110_0;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ActionMethodDelegate <>9__111_0;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x12381D0", Offset = "0x12381D0", VA = "0x12381D0")]
		public <>c()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x12381D8", Offset = "0x12381D8", VA = "0x12381D8")]
		internal void <setCallback>b__110_0()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x12381DC", Offset = "0x12381DC", VA = "0x12381DC")]
		internal void <setValue3>b__111_0()
		{
		}
	}

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LTRect ltRect;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal Vector3 fromInternal;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Vector3 toInternal;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal Vector3 diff;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TweenAction type;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private LeanTweenType easeType;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LeanTweenType loopType;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool hasUpdateCallback;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60067C", Offset = "0x60067C")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60068C", Offset = "0x60068C")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RectTransform rectTransform;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text uiText;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image uiImage;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RawImage rawImage;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Sprite[] sprites;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public LTDescrOptional _optional;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x1700000F")]
	public Vector3 from
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x124FAAC", Offset = "0x124FAAC", VA = "0x124FAAC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x124FAB8", Offset = "0x124FAB8", VA = "0x124FAB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Vector3 to
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x124FAC4", Offset = "0x124FAC4", VA = "0x124FAC4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x124FAD0", Offset = "0x124FAD0", VA = "0x124FAD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x124FADC", Offset = "0x124FADC", VA = "0x124FADC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600914", Offset = "0x600914")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x124FAE4", Offset = "0x124FAE4", VA = "0x124FAE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600924", Offset = "0x600924")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x124FAEC", Offset = "0x124FAEC", VA = "0x124FAEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600934", Offset = "0x600934")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x124FAF4", Offset = "0x124FAF4", VA = "0x124FAF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600944", Offset = "0x600944")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public int uniqueId
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x12506C4", Offset = "0x12506C4", VA = "0x12506C4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000014")]
	public int id
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1250558", Offset = "0x1250558", VA = "0x1250558")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000015")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x12506D4", Offset = "0x12506D4", VA = "0x12506D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x12506DC", Offset = "0x12506DC", VA = "0x12506DC")]
		set
		{
		}
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x124FAFC", Offset = "0x124FAFC", VA = "0x124FAFC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1250568", Offset = "0x1250568", VA = "0x1250568")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x12505E0", Offset = "0x12505E0", VA = "0x12505E0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x600954", Offset = "0x600954")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x12506E4", Offset = "0x12506E4", VA = "0x12506E4")]
	public void reset()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x125080C", Offset = "0x125080C", VA = "0x125080C")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x12508E8", Offset = "0x12508E8", VA = "0x12508E8")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x12509C8", Offset = "0x12509C8", VA = "0x12509C8")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1250AA8", Offset = "0x1250AA8", VA = "0x1250AA8")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1250B88", Offset = "0x1250B88", VA = "0x1250B88")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1250C68", Offset = "0x1250C68", VA = "0x1250C68")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1250D48", Offset = "0x1250D48", VA = "0x1250D48")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1250D50", Offset = "0x1250D50", VA = "0x1250D50")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1250E30", Offset = "0x1250E30", VA = "0x1250E30")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x1250F10", Offset = "0x1250F10", VA = "0x1250F10")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x1250FF0", Offset = "0x1250FF0", VA = "0x1250FF0")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x12510D0", Offset = "0x12510D0", VA = "0x12510D0")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x12511B0", Offset = "0x12511B0", VA = "0x12511B0")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x1251290", Offset = "0x1251290", VA = "0x1251290")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x1251370", Offset = "0x1251370", VA = "0x1251370")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x1251450", Offset = "0x1251450", VA = "0x1251450")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x1251530", Offset = "0x1251530", VA = "0x1251530")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x1251610", Offset = "0x1251610", VA = "0x1251610")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x12516F0", Offset = "0x12516F0", VA = "0x12516F0")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x12517D0", Offset = "0x12517D0", VA = "0x12517D0")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x12518B0", Offset = "0x12518B0", VA = "0x12518B0")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1251990", Offset = "0x1251990", VA = "0x1251990")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1251A70", Offset = "0x1251A70", VA = "0x1251A70")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1251B50", Offset = "0x1251B50", VA = "0x1251B50")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1251C30", Offset = "0x1251C30", VA = "0x1251C30")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1251D10", Offset = "0x1251D10", VA = "0x1251D10")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1251DF0", Offset = "0x1251DF0", VA = "0x1251DF0")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1251ED0", Offset = "0x1251ED0", VA = "0x1251ED0")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1251FB0", Offset = "0x1251FB0", VA = "0x1251FB0")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1252090", Offset = "0x1252090", VA = "0x1252090")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1252170", Offset = "0x1252170", VA = "0x1252170")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x1252250", Offset = "0x1252250", VA = "0x1252250")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x1252298", Offset = "0x1252298", VA = "0x1252298")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x1252378", Offset = "0x1252378", VA = "0x1252378")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x1252458", Offset = "0x1252458", VA = "0x1252458")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x1252538", Offset = "0x1252538", VA = "0x1252538")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x1252618", Offset = "0x1252618", VA = "0x1252618")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x12526F8", Offset = "0x12526F8", VA = "0x12526F8")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x12527D8", Offset = "0x12527D8", VA = "0x12527D8")]
	private void callback()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x125284C", Offset = "0x125284C", VA = "0x125284C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x125299C", Offset = "0x125299C", VA = "0x125299C")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x1252AEC", Offset = "0x1252AEC", VA = "0x1252AEC")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1252BCC", Offset = "0x1252BCC", VA = "0x1252BCC")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x1252CAC", Offset = "0x1252CAC", VA = "0x1252CAC")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x1252D8C", Offset = "0x1252D8C", VA = "0x1252D8C")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x1252E6C", Offset = "0x1252E6C", VA = "0x1252E6C")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x1252F4C", Offset = "0x1252F4C", VA = "0x1252F4C")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x125302C", Offset = "0x125302C", VA = "0x125302C")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x125310C", Offset = "0x125310C", VA = "0x125310C")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x12531EC", Offset = "0x12531EC", VA = "0x12531EC")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x12532CC", Offset = "0x12532CC", VA = "0x12532CC")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x12533AC", Offset = "0x12533AC", VA = "0x12533AC")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x125348C", Offset = "0x125348C", VA = "0x125348C")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x125356C", Offset = "0x125356C", VA = "0x125356C")]
	private void init()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x12537A4", Offset = "0x12537A4", VA = "0x12537A4")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1253858", Offset = "0x1253858", VA = "0x1253858")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x125387C", Offset = "0x125387C", VA = "0x125387C")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x12536A4", Offset = "0x12536A4", VA = "0x12536A4")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1253B74", Offset = "0x1253B74", VA = "0x1253B74")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1253BB4", Offset = "0x1253BB4", VA = "0x1253BB4")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1254020", Offset = "0x1254020", VA = "0x1254020")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x12543C0", Offset = "0x12543C0", VA = "0x12543C0")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x12547C0", Offset = "0x12547C0", VA = "0x12547C0")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1254B64", Offset = "0x1254B64", VA = "0x1254B64")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1254F20", Offset = "0x1254F20", VA = "0x1254F20")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1255314", Offset = "0x1255314", VA = "0x1255314")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1255684", Offset = "0x1255684", VA = "0x1255684")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x12559B4", Offset = "0x12559B4", VA = "0x12559B4")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1255D24", Offset = "0x1255D24", VA = "0x1255D24")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1255DA8", Offset = "0x1255DA8", VA = "0x1255DA8")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1255DC0", Offset = "0x1255DC0", VA = "0x1255DC0")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1255DCC", Offset = "0x1255DCC", VA = "0x1255DCC")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1255DF0", Offset = "0x1255DF0", VA = "0x1255DF0")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1255DF8", Offset = "0x1255DF8", VA = "0x1255DF8")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x1255F38", Offset = "0x1255F38", VA = "0x1255F38")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1257380", Offset = "0x1257380", VA = "0x1257380")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1256068", Offset = "0x1256068", VA = "0x1256068")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1255FD0", Offset = "0x1255FD0", VA = "0x1255FD0")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1256100", Offset = "0x1256100", VA = "0x1256100")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1256198", Offset = "0x1256198", VA = "0x1256198")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x1256230", Offset = "0x1256230", VA = "0x1256230")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x12562C8", Offset = "0x12562C8", VA = "0x12562C8")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1256360", Offset = "0x1256360", VA = "0x1256360")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x12563F8", Offset = "0x12563F8", VA = "0x12563F8")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x1256490", Offset = "0x1256490", VA = "0x1256490")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x1256528", Offset = "0x1256528", VA = "0x1256528")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x12565C0", Offset = "0x12565C0", VA = "0x12565C0")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1256658", Offset = "0x1256658", VA = "0x1256658")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x12566F0", Offset = "0x12566F0", VA = "0x12566F0")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1256788", Offset = "0x1256788", VA = "0x1256788")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1256820", Offset = "0x1256820", VA = "0x1256820")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x12568B8", Offset = "0x12568B8", VA = "0x12568B8")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1256950", Offset = "0x1256950", VA = "0x1256950")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x12569E8", Offset = "0x12569E8", VA = "0x12569E8")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1256A80", Offset = "0x1256A80", VA = "0x1256A80")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1256B18", Offset = "0x1256B18", VA = "0x1256B18")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x1256BB0", Offset = "0x1256BB0", VA = "0x1256BB0")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1256C48", Offset = "0x1256C48", VA = "0x1256C48")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1256CE0", Offset = "0x1256CE0", VA = "0x1256CE0")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x1256D78", Offset = "0x1256D78", VA = "0x1256D78")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1256E10", Offset = "0x1256E10", VA = "0x1256E10")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x1256EA8", Offset = "0x1256EA8", VA = "0x1256EA8")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1256F40", Offset = "0x1256F40", VA = "0x1256F40")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x1256FD8", Offset = "0x1256FD8", VA = "0x1256FD8")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x1257070", Offset = "0x1257070", VA = "0x1257070")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x1257108", Offset = "0x1257108", VA = "0x1257108")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x12571A0", Offset = "0x12571A0", VA = "0x12571A0")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1257290", Offset = "0x1257290", VA = "0x1257290")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1257418", Offset = "0x1257418", VA = "0x1257418")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x12574E4", Offset = "0x12574E4", VA = "0x12574E4")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x12575AC", Offset = "0x12575AC", VA = "0x12575AC")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x125763C", Offset = "0x125763C", VA = "0x125763C")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x12576E4", Offset = "0x12576E4", VA = "0x12576E4")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1257770", Offset = "0x1257770", VA = "0x1257770")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x125788C", Offset = "0x125788C", VA = "0x125788C")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1257920", Offset = "0x1257920", VA = "0x1257920")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x12579D4", Offset = "0x12579D4", VA = "0x12579D4")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1257AB4", Offset = "0x1257AB4", VA = "0x1257AB4")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1257B4C", Offset = "0x1257B4C", VA = "0x1257B4C")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1257C04", Offset = "0x1257C04", VA = "0x1257C04")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1257D18", Offset = "0x1257D18", VA = "0x1257D18")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x1257DC4", Offset = "0x1257DC4", VA = "0x1257DC4")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x1257E80", Offset = "0x1257E80", VA = "0x1257E80")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x1257F70", Offset = "0x1257F70", VA = "0x1257F70")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x1258058", Offset = "0x1258058", VA = "0x1258058")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x1258130", Offset = "0x1258130", VA = "0x1258130")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x12581D8", Offset = "0x12581D8", VA = "0x12581D8")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1258278", Offset = "0x1258278", VA = "0x1258278")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1258318", Offset = "0x1258318", VA = "0x1258318")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x1258418", Offset = "0x1258418", VA = "0x1258418")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x12584C0", Offset = "0x12584C0", VA = "0x12584C0")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x1258574", Offset = "0x1258574", VA = "0x1258574")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x1258664", Offset = "0x1258664", VA = "0x1258664")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x12587B8", Offset = "0x12587B8", VA = "0x12587B8")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x1258974", Offset = "0x1258974", VA = "0x1258974")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x1258B84", Offset = "0x1258B84", VA = "0x1258B84")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x1258C40", Offset = "0x1258C40", VA = "0x1258C40")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x1258D10", Offset = "0x1258D10", VA = "0x1258D10")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1258E58", Offset = "0x1258E58", VA = "0x1258E58")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1258F4C", Offset = "0x1258F4C", VA = "0x1258F4C")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1259040", Offset = "0x1259040", VA = "0x1259040")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x1259134", Offset = "0x1259134", VA = "0x1259134")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x125913C", Offset = "0x125913C", VA = "0x125913C")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1259144", Offset = "0x1259144", VA = "0x1259144")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x125914C", Offset = "0x125914C", VA = "0x125914C")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x1259200", Offset = "0x1259200", VA = "0x1259200")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1259230", Offset = "0x1259230", VA = "0x1259230")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x1259264", Offset = "0x1259264", VA = "0x1259264")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x125933C", Offset = "0x125933C", VA = "0x125933C")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x1259348", Offset = "0x1259348", VA = "0x1259348")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x1259354", Offset = "0x1259354", VA = "0x1259354")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x1259360", Offset = "0x1259360", VA = "0x1259360")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x125936C", Offset = "0x125936C", VA = "0x125936C")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x1259374", Offset = "0x1259374", VA = "0x1259374")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x1259390", Offset = "0x1259390", VA = "0x1259390")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x12593C4", Offset = "0x12593C4", VA = "0x12593C4")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x1259414", Offset = "0x1259414", VA = "0x1259414")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x125941C", Offset = "0x125941C", VA = "0x125941C")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x125942C", Offset = "0x125942C", VA = "0x125942C")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x125943C", Offset = "0x125943C", VA = "0x125943C")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x125944C", Offset = "0x125944C", VA = "0x125944C")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x125945C", Offset = "0x125945C", VA = "0x125945C")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x125946C", Offset = "0x125946C", VA = "0x125946C")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x1259478", Offset = "0x1259478", VA = "0x1259478")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x1259498", Offset = "0x1259498", VA = "0x1259498")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x12594A0", Offset = "0x12594A0", VA = "0x12594A0")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x12594C0", Offset = "0x12594C0", VA = "0x12594C0")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x12594F0", Offset = "0x12594F0", VA = "0x12594F0")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x125952C", Offset = "0x125952C", VA = "0x125952C")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x1259568", Offset = "0x1259568", VA = "0x1259568")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x12595C0", Offset = "0x12595C0", VA = "0x12595C0")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x12595FC", Offset = "0x12595FC", VA = "0x12595FC")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x1259638", Offset = "0x1259638", VA = "0x1259638")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x1259674", Offset = "0x1259674", VA = "0x1259674")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x12596B0", Offset = "0x12596B0", VA = "0x12596B0")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x12596EC", Offset = "0x12596EC", VA = "0x12596EC")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1259728", Offset = "0x1259728", VA = "0x1259728")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1259764", Offset = "0x1259764", VA = "0x1259764")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x12597A0", Offset = "0x12597A0", VA = "0x12597A0")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x12597DC", Offset = "0x12597DC", VA = "0x12597DC")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x1259818", Offset = "0x1259818", VA = "0x1259818")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1259870", Offset = "0x1259870", VA = "0x1259870")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x12598C8", Offset = "0x12598C8", VA = "0x12598C8")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1259920", Offset = "0x1259920", VA = "0x1259920")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x1259978", Offset = "0x1259978", VA = "0x1259978")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x12599AC", Offset = "0x12599AC", VA = "0x12599AC")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1259A7C", Offset = "0x1259A7C", VA = "0x1259A7C")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x1259AE4", Offset = "0x1259AE4", VA = "0x1259AE4")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x1259B18", Offset = "0x1259B18", VA = "0x1259B18")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x1259BC8", Offset = "0x1259BC8", VA = "0x1259BC8")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x1259BFC", Offset = "0x1259BFC", VA = "0x1259BFC")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x1259C20", Offset = "0x1259C20", VA = "0x1259C20")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x1259C2C", Offset = "0x1259C2C", VA = "0x1259C2C")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x1259408", Offset = "0x1259408", VA = "0x1259408")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x1259C60", Offset = "0x1259C60", VA = "0x1259C60")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x1259C6C", Offset = "0x1259C6C", VA = "0x1259C6C")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x1259C94", Offset = "0x1259C94", VA = "0x1259C94")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x1259CBC", Offset = "0x1259CBC", VA = "0x1259CBC")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x1259CE8", Offset = "0x1259CE8", VA = "0x1259CE8")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x1259D1C", Offset = "0x1259D1C", VA = "0x1259D1C")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x1259EF0", Offset = "0x1259EF0", VA = "0x1259EF0")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x1259EFC", Offset = "0x1259EFC", VA = "0x1259EFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60098C", Offset = "0x60098C")]
	private void <setMoveX>b__71_0()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x1259F30", Offset = "0x1259F30", VA = "0x1259F30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60099C", Offset = "0x60099C")]
	private void <setMoveX>b__71_1()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x1259FA8", Offset = "0x1259FA8", VA = "0x1259FA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009AC", Offset = "0x6009AC")]
	private void <setMoveY>b__72_0()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x1259FDC", Offset = "0x1259FDC", VA = "0x1259FDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009BC", Offset = "0x6009BC")]
	private void <setMoveY>b__72_1()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x125A050", Offset = "0x125A050", VA = "0x125A050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009CC", Offset = "0x6009CC")]
	private void <setMoveZ>b__73_0()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x125A084", Offset = "0x125A084", VA = "0x125A084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009DC", Offset = "0x6009DC")]
	private void <setMoveZ>b__73_1()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x125A0FC", Offset = "0x125A0FC", VA = "0x125A0FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009EC", Offset = "0x6009EC")]
	private void <setMoveLocalX>b__74_0()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x125A130", Offset = "0x125A130", VA = "0x125A130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6009FC", Offset = "0x6009FC")]
	private void <setMoveLocalX>b__74_1()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x125A1A8", Offset = "0x125A1A8", VA = "0x125A1A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A0C", Offset = "0x600A0C")]
	private void <setMoveLocalY>b__75_0()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x125A1DC", Offset = "0x125A1DC", VA = "0x125A1DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A1C", Offset = "0x600A1C")]
	private void <setMoveLocalY>b__75_1()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x125A250", Offset = "0x125A250", VA = "0x125A250")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A2C", Offset = "0x600A2C")]
	private void <setMoveLocalZ>b__76_0()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x125A284", Offset = "0x125A284", VA = "0x125A284")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A3C", Offset = "0x600A3C")]
	private void <setMoveLocalZ>b__76_1()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x125A2FC", Offset = "0x125A2FC", VA = "0x125A2FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A4C", Offset = "0x600A4C")]
	private void <setMoveCurved>b__78_0()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x125A434", Offset = "0x125A434", VA = "0x125A434")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A5C", Offset = "0x600A5C")]
	private void <setMoveCurvedLocal>b__79_0()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x125A56C", Offset = "0x125A56C", VA = "0x125A56C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A6C", Offset = "0x600A6C")]
	private void <setMoveSpline>b__80_0()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x125A650", Offset = "0x125A650", VA = "0x125A650")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A7C", Offset = "0x600A7C")]
	private void <setMoveSplineLocal>b__81_0()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x125A734", Offset = "0x125A734", VA = "0x125A734")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A8C", Offset = "0x600A8C")]
	private void <setScaleX>b__82_0()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x125A768", Offset = "0x125A768", VA = "0x125A768")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600A9C", Offset = "0x600A9C")]
	private void <setScaleX>b__82_1()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x125A7E0", Offset = "0x125A7E0", VA = "0x125A7E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600AAC", Offset = "0x600AAC")]
	private void <setScaleY>b__83_0()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x125A814", Offset = "0x125A814", VA = "0x125A814")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600ABC", Offset = "0x600ABC")]
	private void <setScaleY>b__83_1()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x125A888", Offset = "0x125A888", VA = "0x125A888")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600ACC", Offset = "0x600ACC")]
	private void <setScaleZ>b__84_0()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x125A8BC", Offset = "0x125A8BC", VA = "0x125A8BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600ADC", Offset = "0x600ADC")]
	private void <setScaleZ>b__84_1()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x125A934", Offset = "0x125A934", VA = "0x125A934")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600AEC", Offset = "0x600AEC")]
	private void <setRotateX>b__85_0()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x125A9CC", Offset = "0x125A9CC", VA = "0x125A9CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600AFC", Offset = "0x600AFC")]
	private void <setRotateX>b__85_1()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x125AA44", Offset = "0x125AA44", VA = "0x125AA44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B0C", Offset = "0x600B0C")]
	private void <setRotateY>b__86_0()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x125AADC", Offset = "0x125AADC", VA = "0x125AADC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B1C", Offset = "0x600B1C")]
	private void <setRotateY>b__86_1()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x125AB50", Offset = "0x125AB50", VA = "0x125AB50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B2C", Offset = "0x600B2C")]
	private void <setRotateZ>b__87_0()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x125ABE8", Offset = "0x125ABE8", VA = "0x125ABE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B3C", Offset = "0x600B3C")]
	private void <setRotateZ>b__87_1()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x125AC60", Offset = "0x125AC60", VA = "0x125AC60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B4C", Offset = "0x600B4C")]
	private void <setRotateAround>b__88_0()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x125ACA4", Offset = "0x125ACA4", VA = "0x125ACA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B5C", Offset = "0x600B5C")]
	private void <setRotateAround>b__88_1()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x125AE44", Offset = "0x125AE44", VA = "0x125AE44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B6C", Offset = "0x600B6C")]
	private void <setRotateAroundLocal>b__89_0()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x125AE88", Offset = "0x125AE88", VA = "0x125AE88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B7C", Offset = "0x600B7C")]
	private void <setRotateAroundLocal>b__89_1()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x125B0AC", Offset = "0x125B0AC", VA = "0x125B0AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B8C", Offset = "0x600B8C")]
	private void <setAlpha>b__90_0()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x125B664", Offset = "0x125B664", VA = "0x125B664")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600B9C", Offset = "0x600B9C")]
	private void <setAlpha>b__90_2()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x125B7D8", Offset = "0x125B7D8", VA = "0x125B7D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BAC", Offset = "0x600BAC")]
	private void <setAlpha>b__90_1()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x125B95C", Offset = "0x125B95C", VA = "0x125B95C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BBC", Offset = "0x600BBC")]
	private void <setTextAlpha>b__91_0()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x125BA38", Offset = "0x125BA38", VA = "0x125BA38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BCC", Offset = "0x600BCC")]
	private void <setTextAlpha>b__91_1()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x125BA74", Offset = "0x125BA74", VA = "0x125BA74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BDC", Offset = "0x600BDC")]
	private void <setAlphaVertex>b__92_0()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x125BB08", Offset = "0x125BB08", VA = "0x125BB08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BEC", Offset = "0x600BEC")]
	private void <setAlphaVertex>b__92_1()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x125BD50", Offset = "0x125BD50", VA = "0x125BD50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600BFC", Offset = "0x600BFC")]
	private void <setColor>b__93_0()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x125C2BC", Offset = "0x125C2BC", VA = "0x125C2BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C0C", Offset = "0x600C0C")]
	private void <setColor>b__93_1()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x125C4C4", Offset = "0x125C4C4", VA = "0x125C4C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C1C", Offset = "0x600C1C")]
	private void <setCallbackColor>b__94_0()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x125C4D8", Offset = "0x125C4D8", VA = "0x125C4D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C2C", Offset = "0x600C2C")]
	private void <setCallbackColor>b__94_1()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x125C6E0", Offset = "0x125C6E0", VA = "0x125C6E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C3C", Offset = "0x600C3C")]
	private void <setTextColor>b__95_0()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x125C7C0", Offset = "0x125C7C0", VA = "0x125C7C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C4C", Offset = "0x600C4C")]
	private void <setTextColor>b__95_1()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x125C918", Offset = "0x125C918", VA = "0x125C918")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C5C", Offset = "0x600C5C")]
	private void <setCanvasAlpha>b__96_0()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x125CA60", Offset = "0x125CA60", VA = "0x125CA60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C6C", Offset = "0x600C6C")]
	private void <setCanvasAlpha>b__96_1()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x125CBF4", Offset = "0x125CBF4", VA = "0x125CBF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C7C", Offset = "0x600C7C")]
	private void <setCanvasGroupAlpha>b__97_0()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x125CC5C", Offset = "0x125CC5C", VA = "0x125CC5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C8C", Offset = "0x600C8C")]
	private void <setCanvasGroupAlpha>b__97_1()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x125CCD8", Offset = "0x125CCD8", VA = "0x125CCD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600C9C", Offset = "0x600C9C")]
	private void <setCanvasColor>b__98_0()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x125CE20", Offset = "0x125CE20", VA = "0x125CE20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CAC", Offset = "0x600CAC")]
	private void <setCanvasColor>b__98_1()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x125CFFC", Offset = "0x125CFFC", VA = "0x125CFFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CBC", Offset = "0x600CBC")]
	private void <setCanvasMoveX>b__99_0()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x125D030", Offset = "0x125D030", VA = "0x125D030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CCC", Offset = "0x600CCC")]
	private void <setCanvasMoveX>b__99_1()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x125D098", Offset = "0x125D098", VA = "0x125D098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CDC", Offset = "0x600CDC")]
	private void <setCanvasMoveY>b__100_0()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x125D0CC", Offset = "0x125D0CC", VA = "0x125D0CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CEC", Offset = "0x600CEC")]
	private void <setCanvasMoveY>b__100_1()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x125D138", Offset = "0x125D138", VA = "0x125D138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600CFC", Offset = "0x600CFC")]
	private void <setCanvasMoveZ>b__101_0()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x125D16C", Offset = "0x125D16C", VA = "0x125D16C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D0C", Offset = "0x600D0C")]
	private void <setCanvasMoveZ>b__101_1()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x125D1D8", Offset = "0x125D1D8", VA = "0x125D1D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D1C", Offset = "0x600D1C")]
	private void <setCanvasRotateAround>b__103_0()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x125D358", Offset = "0x125D358", VA = "0x125D358")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D2C", Offset = "0x600D2C")]
	private void <setCanvasRotateAroundLocal>b__104_0()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x125D540", Offset = "0x125D540", VA = "0x125D540")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D3C", Offset = "0x600D3C")]
	private void <setCanvasPlaySprite>b__105_0()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x125D5AC", Offset = "0x125D5AC", VA = "0x125D5AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D4C", Offset = "0x600D4C")]
	private void <setCanvasPlaySprite>b__105_1()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x125D6F8", Offset = "0x125D6F8", VA = "0x125D6F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D5C", Offset = "0x600D5C")]
	private void <setCanvasMove>b__106_0()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x125D730", Offset = "0x125D730", VA = "0x125D730")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D6C", Offset = "0x600D6C")]
	private void <setCanvasMove>b__106_1()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x125D770", Offset = "0x125D770", VA = "0x125D770")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D7C", Offset = "0x600D7C")]
	private void <setCanvasScale>b__107_0()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x125D7A8", Offset = "0x125D7A8", VA = "0x125D7A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D8C", Offset = "0x600D8C")]
	private void <setCanvasScale>b__107_1()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x125D7E8", Offset = "0x125D7E8", VA = "0x125D7E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600D9C", Offset = "0x600D9C")]
	private void <setCanvasSizeDelta>b__108_0()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x125D820", Offset = "0x125D820", VA = "0x125D820")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DAC", Offset = "0x600DAC")]
	private void <setCanvasSizeDelta>b__108_1()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x125D860", Offset = "0x125D860", VA = "0x125D860")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DBC", Offset = "0x600DBC")]
	private void <setMove>b__112_0()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x125D898", Offset = "0x125D898", VA = "0x125D898")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DCC", Offset = "0x600DCC")]
	private void <setMove>b__112_1()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x125D918", Offset = "0x125D918", VA = "0x125D918")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DDC", Offset = "0x600DDC")]
	private void <setMoveLocal>b__113_0()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x125D950", Offset = "0x125D950", VA = "0x125D950")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DEC", Offset = "0x600DEC")]
	private void <setMoveLocal>b__113_1()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x125D9D0", Offset = "0x125D9D0", VA = "0x125D9D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600DFC", Offset = "0x600DFC")]
	private void <setMoveToTransform>b__114_0()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x125DA08", Offset = "0x125DA08", VA = "0x125DA08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E0C", Offset = "0x600E0C")]
	private void <setMoveToTransform>b__114_1()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x125DAD8", Offset = "0x125DAD8", VA = "0x125DAD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E1C", Offset = "0x600E1C")]
	private void <setRotate>b__115_0()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x125DBA8", Offset = "0x125DBA8", VA = "0x125DBA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E2C", Offset = "0x600E2C")]
	private void <setRotate>b__115_1()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x125DC28", Offset = "0x125DC28", VA = "0x125DC28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E3C", Offset = "0x600E3C")]
	private void <setRotateLocal>b__116_0()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x125DCF8", Offset = "0x125DCF8", VA = "0x125DCF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E4C", Offset = "0x600E4C")]
	private void <setRotateLocal>b__116_1()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x125DD78", Offset = "0x125DD78", VA = "0x125DD78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E5C", Offset = "0x600E5C")]
	private void <setScale>b__117_0()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x125DDB0", Offset = "0x125DDB0", VA = "0x125DDB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E6C", Offset = "0x600E6C")]
	private void <setScale>b__117_1()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x125DE30", Offset = "0x125DE30", VA = "0x125DE30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E7C", Offset = "0x600E7C")]
	private void <setGUIMove>b__118_0()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x125DEC8", Offset = "0x125DEC8", VA = "0x125DEC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E8C", Offset = "0x600E8C")]
	private void <setGUIMove>b__118_1()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x125DFA4", Offset = "0x125DFA4", VA = "0x125DFA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600E9C", Offset = "0x600E9C")]
	private void <setGUIMoveMargin>b__119_0()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x125DFD4", Offset = "0x125DFD4", VA = "0x125DFD4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600EAC", Offset = "0x600EAC")]
	private void <setGUIMoveMargin>b__119_1()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x125E018", Offset = "0x125E018", VA = "0x125E018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600EBC", Offset = "0x600EBC")]
	private void <setGUIScale>b__120_0()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x125E0B0", Offset = "0x125E0B0", VA = "0x125E0B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600ECC", Offset = "0x600ECC")]
	private void <setGUIScale>b__120_1()
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x125E18C", Offset = "0x125E18C", VA = "0x125E18C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600EDC", Offset = "0x600EDC")]
	private void <setGUIAlpha>b__121_0()
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x125E1B8", Offset = "0x125E1B8", VA = "0x125E1B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600EEC", Offset = "0x600EEC")]
	private void <setGUIAlpha>b__121_1()
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x125E1F8", Offset = "0x125E1F8", VA = "0x125E1F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600EFC", Offset = "0x600EFC")]
	private void <setGUIRotate>b__122_0()
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x125E268", Offset = "0x125E268", VA = "0x125E268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F0C", Offset = "0x600F0C")]
	private void <setGUIRotate>b__122_1()
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x125E2A8", Offset = "0x125E2A8", VA = "0x125E2A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F1C", Offset = "0x600F1C")]
	private void <setDelayedSound>b__123_0()
	{
	}
}
[Token(Token = "0x2000018")]
public class LTDescrOptional
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60069C", Offset = "0x60069C")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006AC", Offset = "0x6006AC")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006BC", Offset = "0x6006BC")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006CC", Offset = "0x6006CC")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006DC", Offset = "0x6006DC")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006EC", Offset = "0x6006EC")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006FC", Offset = "0x6006FC")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60070C", Offset = "0x60070C")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60071C", Offset = "0x60071C")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60072C", Offset = "0x60072C")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60073C", Offset = "0x60073C")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60074C", Offset = "0x60074C")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60075C", Offset = "0x60075C")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60076C", Offset = "0x60076C")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60077C", Offset = "0x60077C")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60078C", Offset = "0x60078C")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60079C", Offset = "0x60079C")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6007AC", Offset = "0x6007AC")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6007BC", Offset = "0x6007BC")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6007CC", Offset = "0x6007CC")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6007DC", Offset = "0x6007DC")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x17000016")]
	public Transform toTrans
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1223524", Offset = "0x1223524", VA = "0x1223524")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F2C", Offset = "0x600F2C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x122352C", Offset = "0x122352C", VA = "0x122352C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F3C", Offset = "0x600F3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Vector3 point
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1223534", Offset = "0x1223534", VA = "0x1223534")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F4C", Offset = "0x600F4C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1223540", Offset = "0x1223540", VA = "0x1223540")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F5C", Offset = "0x600F5C")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Vector3 axis
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x122354C", Offset = "0x122354C", VA = "0x122354C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F6C", Offset = "0x600F6C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1223558", Offset = "0x1223558", VA = "0x1223558")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F7C", Offset = "0x600F7C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float lastVal
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1223564", Offset = "0x1223564", VA = "0x1223564")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F8C", Offset = "0x600F8C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x122356C", Offset = "0x122356C", VA = "0x122356C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600F9C", Offset = "0x600F9C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public Quaternion origRotation
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1223574", Offset = "0x1223574", VA = "0x1223574")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FAC", Offset = "0x600FAC")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1223580", Offset = "0x1223580", VA = "0x1223580")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FBC", Offset = "0x600FBC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public LTBezierPath path
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x122358C", Offset = "0x122358C", VA = "0x122358C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FCC", Offset = "0x600FCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1223594", Offset = "0x1223594", VA = "0x1223594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FDC", Offset = "0x600FDC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public LTSpline spline
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x122359C", Offset = "0x122359C", VA = "0x122359C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FEC", Offset = "0x600FEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x12235A4", Offset = "0x12235A4", VA = "0x12235A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x600FFC", Offset = "0x600FFC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public LTRect ltRect
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x12235AC", Offset = "0x12235AC", VA = "0x12235AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60100C", Offset = "0x60100C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12235B4", Offset = "0x12235B4", VA = "0x12235B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60101C", Offset = "0x60101C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12235BC", Offset = "0x12235BC", VA = "0x12235BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60102C", Offset = "0x60102C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x12235C4", Offset = "0x12235C4", VA = "0x12235C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60103C", Offset = "0x60103C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x12235CC", Offset = "0x12235CC", VA = "0x12235CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60104C", Offset = "0x60104C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x12235D4", Offset = "0x12235D4", VA = "0x12235D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60105C", Offset = "0x60105C")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x12235DC", Offset = "0x12235DC", VA = "0x12235DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60106C", Offset = "0x60106C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x12235E4", Offset = "0x12235E4", VA = "0x12235E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60107C", Offset = "0x60107C")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x12235EC", Offset = "0x12235EC", VA = "0x12235EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60108C", Offset = "0x60108C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x12235F4", Offset = "0x12235F4", VA = "0x12235F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60109C", Offset = "0x60109C")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x12235FC", Offset = "0x12235FC", VA = "0x12235FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010AC", Offset = "0x6010AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1223604", Offset = "0x1223604", VA = "0x1223604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010BC", Offset = "0x6010BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x122360C", Offset = "0x122360C", VA = "0x122360C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010CC", Offset = "0x6010CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1223614", Offset = "0x1223614", VA = "0x1223614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010DC", Offset = "0x6010DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x122361C", Offset = "0x122361C", VA = "0x122361C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010EC", Offset = "0x6010EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1223624", Offset = "0x1223624", VA = "0x1223624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6010FC", Offset = "0x6010FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x122362C", Offset = "0x122362C", VA = "0x122362C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60110C", Offset = "0x60110C")]
		get
		{
			return null;
		}
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1223634", Offset = "0x1223634", VA = "0x1223634")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60111C", Offset = "0x60111C")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public Action onComplete
	{
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x122363C", Offset = "0x122363C", VA = "0x122363C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60112C", Offset = "0x60112C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1223644", Offset = "0x1223644", VA = "0x1223644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60113C", Offset = "0x60113C")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x122364C", Offset = "0x122364C", VA = "0x122364C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60114C", Offset = "0x60114C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x1223654", Offset = "0x1223654", VA = "0x1223654")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60115C", Offset = "0x60115C")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public object onCompleteParam
	{
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x122365C", Offset = "0x122365C", VA = "0x122365C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60116C", Offset = "0x60116C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x1223664", Offset = "0x1223664", VA = "0x1223664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60117C", Offset = "0x60117C")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public object onUpdateParam
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x122366C", Offset = "0x122366C", VA = "0x122366C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60118C", Offset = "0x60118C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1223674", Offset = "0x1223674", VA = "0x1223674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x60119C", Offset = "0x60119C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public Action onStart
	{
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x122367C", Offset = "0x122367C", VA = "0x122367C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6011AC", Offset = "0x6011AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x1223684", Offset = "0x1223684", VA = "0x1223684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6011BC", Offset = "0x6011BC")]
		set
		{
		}
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x122368C", Offset = "0x122368C", VA = "0x122368C")]
	public void reset()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x1223778", Offset = "0x1223778", VA = "0x1223778")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x1223924", Offset = "0x1223924", VA = "0x1223924")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000019")]
public class LTSeq
{
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	[Token(Token = "0x1700002B")]
	public int id
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x12267C8", Offset = "0x12267C8", VA = "0x12267C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x12267D8", Offset = "0x12267D8", VA = "0x12267D8")]
	public void reset()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x1226814", Offset = "0x1226814", VA = "0x1226814")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1226874", Offset = "0x1226874", VA = "0x1226874")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x1226BD8", Offset = "0x1226BD8", VA = "0x1226BD8")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x1226C18", Offset = "0x1226C18", VA = "0x1226C18")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x1226C44", Offset = "0x1226C44", VA = "0x1226C44")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x1226E08", Offset = "0x1226E08", VA = "0x1226E08")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x1226F7C", Offset = "0x1226F7C", VA = "0x1226F7C")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x12270DC", Offset = "0x12270DC", VA = "0x12270DC")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x1226D98", Offset = "0x1226D98", VA = "0x1226D98")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x1227254", Offset = "0x1227254", VA = "0x1227254")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x12272A4", Offset = "0x12272A4", VA = "0x12272A4")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x12272D0", Offset = "0x12272D0", VA = "0x12272D0")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x1227370", Offset = "0x1227370", VA = "0x1227370")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x1227374", Offset = "0x1227374", VA = "0x1227374")]
	public LTSeq()
	{
	}
}
[Token(Token = "0x200001A")]
public enum LensflareStyle34
{
	[Token(Token = "0x400012F")]
	Ghosting,
	[Token(Token = "0x4000130")]
	Anamorphic,
	[Token(Token = "0x4000131")]
	Combined
}
[Token(Token = "0x200001B")]
public enum TweakMode34
{
	[Token(Token = "0x4000133")]
	Basic,
	[Token(Token = "0x4000134")]
	Complex
}
[Token(Token = "0x200001C")]
public enum HDRBloomMode
{
	[Token(Token = "0x4000136")]
	Auto,
	[Token(Token = "0x4000137")]
	On,
	[Token(Token = "0x4000138")]
	Off
}
[Token(Token = "0x200001D")]
public enum BloomScreenBlendMode
{
	[Token(Token = "0x400013A")]
	Screen,
	[Token(Token = "0x400013B")]
	Add
}
[Token(Token = "0x200001E")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFEA4", Offset = "0x5FFEA4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FFEA4", Offset = "0x5FFEA4")]
public class BloomAndLensFlares : PostEffectsBase
{
	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public TweakMode34 tweakMode;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BloomScreenBlendMode screenBlendMode;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public HDRBloomMode hdr;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool doHdr;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sepBlurSpread;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float useSrcAlphaAsMask;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float bloomIntensity;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float bloomThreshhold;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int bloomBlurIterations;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool lensflares;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int hollywoodFlareBlurIterations;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LensflareStyle34 lensflareMode;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float hollyStretchWidth;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float lensflareIntensity;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float lensflareThreshhold;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color flareColorA;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color flareColorB;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Color flareColorC;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Color flareColorD;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float blurWidth;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Texture2D lensFlareVignetteMask;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Shader lensFlareShader;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Material lensFlareMaterial;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Shader vignetteShader;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Material vignetteMaterial;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Material separableBlurMaterial;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Shader addBrightStuffOneOneShader;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Material addBrightStuffBlendOneOneMaterial;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Shader screenBlendShader;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Material screenBlend;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Shader hollywoodFlaresShader;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Material hollywoodFlaresMaterial;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Shader brightPassFilterShader;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Material brightPassFilterMaterial;

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x124AB98", Offset = "0x124AB98", VA = "0x124AB98")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x124ACF8", Offset = "0x124ACF8", VA = "0x124ACF8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x124BD88", Offset = "0x124BD88", VA = "0x124BD88")]
	private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x124BB10", Offset = "0x124BB10", VA = "0x124BB10")]
	private void BlendFlares(RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x124B850", Offset = "0x124B850", VA = "0x124B850")]
	private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x124B998", Offset = "0x124B998", VA = "0x124B998")]
	private void Vignette(float amount, RenderTexture from, RenderTexture to)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x124BE44", Offset = "0x124BE44", VA = "0x124BE44")]
	public BloomAndLensFlares()
	{
	}
}
[Token(Token = "0x200001F")]
public enum ColorCorrectionMode
{
	[Token(Token = "0x4000160")]
	Simple,
	[Token(Token = "0x4000161")]
	Advanced
}
[Token(Token = "0x2000020")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FFF40", Offset = "0x5FFF40")]
public class ColorCorrectionCurves : PostEffectsBase
{
	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AnimationCurve redChannel;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AnimationCurve greenChannel;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve blueChannel;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool useDepthCorrection;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve zCurve;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve depthRedChannel;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve depthGreenChannel;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve depthBlueChannel;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material ccMaterial;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Material ccDepthMaterial;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material selectiveCcMaterial;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Texture2D rgbChannelTex;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Texture2D rgbDepthChannelTex;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Texture2D zCurveTex;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float saturation;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool selectiveCc;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Color selectiveFromColor;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color selectiveToColor;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public ColorCorrectionMode mode;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool updateTextures;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Shader colorCorrectionCurvesShader;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Shader simpleColorCorrectionCurvesShader;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Shader colorCorrectionSelectiveShader;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool updateTexturesOnStartup;

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x124BF80", Offset = "0x124BF80", VA = "0x124BF80")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x124BF8C", Offset = "0x124BF8C", VA = "0x124BF8C")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x124C268", Offset = "0x124C268", VA = "0x124C268")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x124C620", Offset = "0x124C620", VA = "0x124C620")]
	private void UpdateTextures()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x124C624", Offset = "0x124C624", VA = "0x124C624")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x124C944", Offset = "0x124C944", VA = "0x124C944")]
	public ColorCorrectionCurves()
	{
	}
}
[Token(Token = "0x2000021")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FFF8C", Offset = "0x5FFF8C")]
public class ColorCorrectionEffect : ImageEffectBase
{
	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x124C99C", Offset = "0x124C99C", VA = "0x124C99C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x124CB38", Offset = "0x124CB38", VA = "0x124CB38")]
	public ColorCorrectionEffect()
	{
	}
}
[Token(Token = "0x2000022")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5FFFD8", Offset = "0x5FFFD8")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x5FFFD8", Offset = "0x5FFFD8")]
internal class ContrastEnhance : PostEffectsBase
{
	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float intensity;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float threshhold;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material separableBlurMaterial;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material contrastCompositeMaterial;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blurSpread;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Shader separableBlurShader;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader contrastCompositeShader;

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x124CB48", Offset = "0x124CB48", VA = "0x124CB48")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x124CBE8", Offset = "0x124CBE8", VA = "0x124CBE8")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x124CF6C", Offset = "0x124CF6C", VA = "0x124CF6C")]
	public ContrastEnhance()
	{
	}
}
[Token(Token = "0x2000023")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600074", Offset = "0x600074")]
[ExecuteInEditMode]
public class ContrastStretchEffect : MonoBehaviour
{
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float adaptationSpeed;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float limitMinimum;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float limitMaximum;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RenderTexture[] adaptRenderTex;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int curAdaptIndex;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader shaderLum;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_materialLum;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderReduce;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_materialReduce;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader shaderAdapt;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_materialAdapt;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Shader shaderApply;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material m_materialApply;

	[Token(Token = "0x1700002C")]
	protected Material materialLum
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x124CF84", Offset = "0x124CF84", VA = "0x124CF84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002D")]
	protected Material materialReduce
	{
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x124D060", Offset = "0x124D060", VA = "0x124D060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	protected Material materialAdapt
	{
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x124D13C", Offset = "0x124D13C", VA = "0x124D13C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	protected Material materialApply
	{
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x124D218", Offset = "0x124D218", VA = "0x124D218")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x124D2F4", Offset = "0x124D2F4", VA = "0x124D2F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x124D388", Offset = "0x124D388", VA = "0x124D388")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x124D4EC", Offset = "0x124D4EC", VA = "0x124D4EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x124D728", Offset = "0x124D728", VA = "0x124D728")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x124D98C", Offset = "0x124D98C", VA = "0x124D98C")]
	private void CalculateAdaptation(Texture curTexture)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x124DB88", Offset = "0x124DB88", VA = "0x124DB88")]
	public ContrastStretchEffect()
	{
	}
}
[Token(Token = "0x2000024")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6000C0", Offset = "0x6000C0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6000C0", Offset = "0x6000C0")]
public class GlowEffect : MonoBehaviour
{
	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float glowIntensity;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int blurIterations;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float blurSpread;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color glowTint;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader compositeShader;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_CompositeMaterial;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader blurShader;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material m_BlurMaterial;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader downsampleShader;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_DownsampleMaterial;

	[Token(Token = "0x17000030")]
	protected Material compositeMaterial
	{
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x124DC10", Offset = "0x124DC10", VA = "0x124DC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	protected Material blurMaterial
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x124DCEC", Offset = "0x124DCEC", VA = "0x124DCEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000032")]
	protected Material downsampleMaterial
	{
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x124DDC8", Offset = "0x124DDC8", VA = "0x124DDC8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x124DEA4", Offset = "0x124DEA4", VA = "0x124DEA4")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x124DFF8", Offset = "0x124DFF8", VA = "0x124DFF8")]
	protected void Start()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x124E170", Offset = "0x124E170", VA = "0x124E170")]
	public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x124E294", Offset = "0x124E294", VA = "0x124E294")]
	private void DownSample4x(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x124E37C", Offset = "0x124E37C", VA = "0x124E37C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x124E5BC", Offset = "0x124E5BC", VA = "0x124E5BC")]
	public void BlitGlow(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x124E6B0", Offset = "0x124E6B0", VA = "0x124E6B0")]
	public GlowEffect()
	{
	}
}
[Token(Token = "0x2000025")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x60015C", Offset = "0x60015C")]
public class GrayscaleEffect : ImageEffectBase
{
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture textureRamp;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float rampOffset;

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x124E720", Offset = "0x124E720", VA = "0x124E720")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x124E810", Offset = "0x124E810", VA = "0x124E810")]
	public GrayscaleEffect()
	{
	}
}
[Token(Token = "0x2000026")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6001A8", Offset = "0x6001A8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6001A8", Offset = "0x6001A8")]
public class ImageEffectBase : MonoBehaviour
{
	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Shader shader;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material m_Material;

	[Token(Token = "0x17000033")]
	protected Material material
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x124CA5C", Offset = "0x124CA5C", VA = "0x124CA5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x124E818", Offset = "0x124E818", VA = "0x124E818", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x124E8C4", Offset = "0x124E8C4", VA = "0x124E8C4", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x124CB40", Offset = "0x124CB40", VA = "0x124CB40")]
	public ImageEffectBase()
	{
	}
}
[Token(Token = "0x2000027")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600234", Offset = "0x600234")]
public class ImageEffects
{
	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x124E970", Offset = "0x124E970", VA = "0x124E970")]
	public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x124EBC4", Offset = "0x124EBC4", VA = "0x124EBC4")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6011CC", Offset = "0x6011CC")]
	public static void Blit(RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x124EC38", Offset = "0x124EC38", VA = "0x124EC38")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x601204", Offset = "0x601204")]
	public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x124ECBC", Offset = "0x124ECBC", VA = "0x124ECBC")]
	public ImageEffects()
	{
	}
}
[Token(Token = "0x2000028")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60026C", Offset = "0x60026C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x60026C", Offset = "0x60026C")]
public class MotionBlur : ImageEffectBase
{
	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float blurAmount;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool extraBlur;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture accumTexture;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x1234B00", Offset = "0x1234B00", VA = "0x1234B00", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x1234B7C", Offset = "0x1234B7C", VA = "0x1234B7C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x1234F14", Offset = "0x1234F14", VA = "0x1234F14")]
	public MotionBlur()
	{
	}
}
[Token(Token = "0x2000029")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600308", Offset = "0x600308")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600308", Offset = "0x600308")]
public class NoiseEffect : MonoBehaviour
{
	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool monochrome;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private bool rgbFallback;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float grainIntensityMin;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float grainIntensityMax;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float grainSize;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scratchIntensityMin;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float scratchIntensityMax;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float scratchFPS;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float scratchJitter;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture grainTexture;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Texture scratchTexture;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Shader shaderRGB;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Shader shaderYUV;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material m_MaterialRGB;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material m_MaterialYUV;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float scratchTimeLeft;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float scratchX;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float scratchY;

	[Token(Token = "0x17000034")]
	protected Material material
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x123507C", Offset = "0x123507C", VA = "0x123507C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x1234F28", Offset = "0x1234F28", VA = "0x1234F28")]
	protected void Start()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x12351F0", Offset = "0x12351F0", VA = "0x12351F0")]
	protected void OnDisable()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x12352F0", Offset = "0x12352F0", VA = "0x12352F0")]
	private void SanitizeParameters()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x12353E4", Offset = "0x12353E4", VA = "0x12353E4")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x123576C", Offset = "0x123576C", VA = "0x123576C")]
	public NoiseEffect()
	{
	}
}
[Token(Token = "0x200002A")]
public class PostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	protected bool supportDX11;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	protected bool isSupported;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x12357A0", Offset = "0x12357A0", VA = "0x12357A0")]
	protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x1235C10", Offset = "0x1235C10", VA = "0x1235C10")]
	private Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x1235E28", Offset = "0x1235E28", VA = "0x1235E28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x1235E34", Offset = "0x1235E34", VA = "0x1235E34")]
	protected bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x1235E3C", Offset = "0x1235E3C", VA = "0x1235E3C")]
	protected bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1235F40", Offset = "0x1235F40", VA = "0x1235F40")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1235F9C", Offset = "0x1235F9C", VA = "0x1235F9C")]
	private bool Dx11Support()
	{
		return default(bool);
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x1235FA4", Offset = "0x1235FA4", VA = "0x1235FA4")]
	protected void ReportAutoDisable()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x1236070", Offset = "0x1236070", VA = "0x1236070")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1235BE4", Offset = "0x1235BE4", VA = "0x1235BE4")]
	private void NotSupported()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x123630C", Offset = "0x123630C", VA = "0x123630C")]
	protected void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1236688", Offset = "0x1236688", VA = "0x1236688")]
	public PostEffectsBase()
	{
	}
}
[Token(Token = "0x200002B")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6003A4", Offset = "0x6003A4")]
public class SepiaToneEffect : ImageEffectBase
{
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x12370DC", Offset = "0x12370DC", VA = "0x12370DC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x1237174", Offset = "0x1237174", VA = "0x1237174")]
	public SepiaToneEffect()
	{
	}
}
[Token(Token = "0x200002C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x6003F0", Offset = "0x6003F0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6003F0", Offset = "0x6003F0")]
public class SSAOEffect : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public enum SSAOSamples
	{
		[Token(Token = "0x40001C1")]
		Low,
		[Token(Token = "0x40001C2")]
		Medium,
		[Token(Token = "0x40001C3")]
		High
	}

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float m_Radius;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SSAOSamples m_SampleCount;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_OcclusionIntensity;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int m_Blur;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int m_Downsampling;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_OcclusionAttenuation;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_MinZ;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Shader m_SSAOShader;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Material m_SSAOMaterial;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D m_RandomTexture;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool m_Supported;

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x123669C", Offset = "0x123669C", VA = "0x123669C")]
	private static Material CreateMaterial(Shader shader)
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x123675C", Offset = "0x123675C", VA = "0x123675C")]
	private static void DestroyMaterial(Material mat)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x1236800", Offset = "0x1236800", VA = "0x1236800")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x1236808", Offset = "0x1236808", VA = "0x1236808")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x12369C0", Offset = "0x12369C0", VA = "0x12369C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x12368DC", Offset = "0x12368DC", VA = "0x12368DC")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x1236A38", Offset = "0x1236A38", VA = "0x1236A38")]
	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x12370A8", Offset = "0x12370A8", VA = "0x12370A8")]
	public SSAOEffect()
	{
	}
}
[Token(Token = "0x200002E")]
public enum SunShaftsResolution
{
	[Token(Token = "0x40001C5")]
	Low,
	[Token(Token = "0x40001C6")]
	Normal,
	[Token(Token = "0x40001C7")]
	High
}
[Token(Token = "0x200002F")]
public enum ShaftsScreenBlendMode
{
	[Token(Token = "0x40001C9")]
	Screen,
	[Token(Token = "0x40001CA")]
	Add
}
[Token(Token = "0x2000030")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x60048C", Offset = "0x60048C")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x60048C", Offset = "0x60048C")]
public class SunShafts : PostEffectsBase
{
	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SunShaftsResolution resolution;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ShaftsScreenBlendMode screenBlendMode;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform sunTransform;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int radialBlurIterations;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color sunColor;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float sunShaftBlurRadius;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float sunShaftIntensity;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float useSkyBoxAlpha;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float maxRadius;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool useDepthTexture;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Shader sunShaftsShader;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material sunShaftsMaterial;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Shader simpleClearShader;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Material simpleClearMaterial;

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x123717C", Offset = "0x123717C", VA = "0x123717C")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x123720C", Offset = "0x123720C", VA = "0x123720C")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x1237990", Offset = "0x1237990", VA = "0x1237990")]
	public SunShafts()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600528", Offset = "0x600528")]
public class TwirlEffect : ImageEffectBase
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

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x12379EC", Offset = "0x12379EC", VA = "0x12379EC")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x1237A38", Offset = "0x1237A38", VA = "0x1237A38")]
	public TwirlEffect()
	{
	}
}
[Token(Token = "0x2000032")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600574", Offset = "0x600574")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x600574", Offset = "0x600574")]
public class Vignetting : PostEffectsBase
{
	[Token(Token = "0x2000033")]
	public enum AberrationMode
	{
		[Token(Token = "0x40001EB")]
		Simple,
		[Token(Token = "0x40001EC")]
		Advanced
	}

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public AberrationMode mode;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float intensity;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float chromaticAberration;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float axialAberration;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float blur;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float blurSpread;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float luminanceDependency;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float blurDistance;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Shader vignetteShader;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Material vignetteMaterial;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Shader separableBlurShader;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material separableBlurMaterial;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Shader chromAberrationShader;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Material chromAberrationMaterial;

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x1237A54", Offset = "0x1237A54", VA = "0x1237A54")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x1237B08", Offset = "0x1237B08", VA = "0x1237B08")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x12380C8", Offset = "0x12380C8", VA = "0x12380C8")]
	public Vignetting()
	{
	}
}
[Token(Token = "0x2000034")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x600610", Offset = "0x600610")]
public class VortexEffect : ImageEffectBase
{
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 radius;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float angle;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 center;

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x1238104", Offset = "0x1238104", VA = "0x1238104")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x1238150", Offset = "0x1238150", VA = "0x1238150")]
	public VortexEffect()
	{
	}
}
namespace DentedPixel;

[Token(Token = "0x2000035")]
public class LeanDummy
{
	[Token(Token = "0x6000306")]
	[Address(RVA = "0x1229EB8", Offset = "0x1229EB8", VA = "0x1229EB8")]
	public LeanDummy()
	{
	}
}
