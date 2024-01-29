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
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int position;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public AudioClip audioClip;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float[] audioArr;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x10F2A48", Offset = "0x10F2A48", VA = "0x10F2A48")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10F3460", Offset = "0x10F3460", VA = "0x10F3460")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10F3508", Offset = "0x10F3508", VA = "0x10F3508")]
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
	[Address(RVA = "0x10F16F4", Offset = "0x10F16F4", VA = "0x10F16F4")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10F187C", Offset = "0x10F187C", VA = "0x10F187C")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x10F2960", Offset = "0x10F2960", VA = "0x10F2960")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10F1984", Offset = "0x10F1984", VA = "0x10F1984")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x10F2064", Offset = "0x10F2064", VA = "0x10F2064")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10F2A68", Offset = "0x10F2A68", VA = "0x10F2A68")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x10F2A6C", Offset = "0x10F2A6C", VA = "0x10F2A6C")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x10F2C54", Offset = "0x10F2C54", VA = "0x10F2C54")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x10F2EE4", Offset = "0x10F2EE4", VA = "0x10F2EE4")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x10F2FA8", Offset = "0x10F2FA8", VA = "0x10F2FA8")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x10F3048", Offset = "0x10F3048", VA = "0x10F3048")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x10F2D44", Offset = "0x10F2D44", VA = "0x10F2D44")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10F3148", Offset = "0x10F3148", VA = "0x10F3148")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10F3378", Offset = "0x10F3378", VA = "0x10F3378")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000004")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000015")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000120")]
		Sine,
		[Token(Token = "0x4000121")]
		Square,
		[Token(Token = "0x4000122")]
		Sawtooth,
		[Token(Token = "0x4000123")]
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
	[Address(RVA = "0x10F1850", Offset = "0x10F1850", VA = "0x10F1850")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x10F3408", Offset = "0x10F3408", VA = "0x10F3408")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x10F3410", Offset = "0x10F3410", VA = "0x10F3410")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x10F3418", Offset = "0x10F3418", VA = "0x10F3418")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x10F3424", Offset = "0x10F3424", VA = "0x10F3424")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x10F3430", Offset = "0x10F3430", VA = "0x10F3430")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x10F343C", Offset = "0x10F343C", VA = "0x10F343C")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10F3448", Offset = "0x10F3448", VA = "0x10F3448")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10F3450", Offset = "0x10F3450", VA = "0x10F3450")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10F3458", Offset = "0x10F3458", VA = "0x10F3458")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC3A4", Offset = "0x5CC3A4")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private int <>1__state;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private object <>2__current;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LeanTester <>4__this;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x10F4C0C", Offset = "0x10F4C0C", VA = "0x10F4C0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x10F4C9C", Offset = "0x10F4C9C", VA = "0x10F4C9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x10F4A08", Offset = "0x10F4A08", VA = "0x10F4A08")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x10F4A3C", Offset = "0x10F4A3C", VA = "0x10F4A3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x10F4A40", Offset = "0x10F4A40", VA = "0x10F4A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x10F4C14", Offset = "0x10F4C14", VA = "0x10F4C14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float timeout;

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10F4958", Offset = "0x10F4958", VA = "0x10F4958")]
	public void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10F497C", Offset = "0x10F497C", VA = "0x10F497C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5CC554", Offset = "0x5CC554")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10F4A28", Offset = "0x10F4A28", VA = "0x10F4A28")]
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
	[Address(RVA = "0x10F3510", Offset = "0x10F3510", VA = "0x10F3510")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10F35A0", Offset = "0x10F35A0", VA = "0x10F35A0")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10F47A4", Offset = "0x10F47A4", VA = "0x10F47A4")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10F3EB4", Offset = "0x10F3EB4", VA = "0x10F3EB4")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10F4828", Offset = "0x10F4828", VA = "0x10F4828")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10F4038", Offset = "0x10F4038", VA = "0x10F4038")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x10F40B0", Offset = "0x10F40B0", VA = "0x10F40B0")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x10F431C", Offset = "0x10F431C", VA = "0x10F431C")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x10F48B4", Offset = "0x10F48B4", VA = "0x10F48B4")]
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
		[Address(RVA = "0x10F4DCC", Offset = "0x10F4DCC", VA = "0x10F4DCC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000002")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x10F4E58", Offset = "0x10F4E58", VA = "0x10F4E58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static int tweensRunning
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x10F4EE4", Offset = "0x10F4EE4", VA = "0x10F4EE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x10FA9FC", Offset = "0x10FA9FC", VA = "0x10FA9FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x10F4CA4", Offset = "0x10F4CA4", VA = "0x10F4CA4")]
	public static void init()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x10F4D34", Offset = "0x10F4D34", VA = "0x10F4D34")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x10F500C", Offset = "0x10F500C", VA = "0x10F500C")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x10F5590", Offset = "0x10F5590", VA = "0x10F5590")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x10F5810", Offset = "0x10F5810", VA = "0x10F5810")]
	public void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x10F5FB0", Offset = "0x10F5FB0", VA = "0x10F5FB0")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x10F6040", Offset = "0x10F6040", VA = "0x10F6040")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x10F5888", Offset = "0x10F5888", VA = "0x10F5888")]
	public static void update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x10D60C8", Offset = "0x10D60C8", VA = "0x10D60C8")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x10F60B8", Offset = "0x10F60B8", VA = "0x10F60B8")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x10F6740", Offset = "0x10F6740", VA = "0x10F6740")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x10E452C", Offset = "0x10E452C", VA = "0x10E452C")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x10F69B4", Offset = "0x10F69B4", VA = "0x10F69B4")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x10F6A30", Offset = "0x10F6A30", VA = "0x10F6A30")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x10F6D94", Offset = "0x10F6D94", VA = "0x10F6D94")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x10F6E18", Offset = "0x10F6E18", VA = "0x10F6E18")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x10F7244", Offset = "0x10F7244", VA = "0x10F7244")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x10F72E8", Offset = "0x10F72E8", VA = "0x10F72E8")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10F7748", Offset = "0x10F7748", VA = "0x10F7748")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x10F790C", Offset = "0x10F790C", VA = "0x10F790C")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x10F7990", Offset = "0x10F7990", VA = "0x10F7990")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x10F7E20", Offset = "0x10F7E20", VA = "0x10F7E20")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10F828C", Offset = "0x10F828C", VA = "0x10F828C")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10F830C", Offset = "0x10F830C", VA = "0x10F830C")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x10F86A0", Offset = "0x10F86A0", VA = "0x10F86A0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5CC5CC", Offset = "0x5CC5CC")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10F8720", Offset = "0x10F8720", VA = "0x10F8720")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x10F88B0", Offset = "0x10F88B0", VA = "0x10F88B0")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10F8AF0", Offset = "0x10F8AF0", VA = "0x10F8AF0")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10F8C50", Offset = "0x10F8C50", VA = "0x10F8C50")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x10F8DA0", Offset = "0x10F8DA0", VA = "0x10F8DA0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5CC614", Offset = "0x5CC614")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x10F8E20", Offset = "0x10F8E20", VA = "0x10F8E20")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x10F8FA0", Offset = "0x10F8FA0", VA = "0x10F8FA0")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x10F91D0", Offset = "0x10F91D0", VA = "0x10F91D0")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x10F9530", Offset = "0x10F9530", VA = "0x10F9530")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x10F95D0", Offset = "0x10F95D0", VA = "0x10F95D0")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x10F97A4", Offset = "0x10F97A4", VA = "0x10F97A4")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x10F9988", Offset = "0x10F9988", VA = "0x10F9988")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x10D45C0", Offset = "0x10D45C0", VA = "0x10D45C0")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x10FA35C", Offset = "0x10FA35C", VA = "0x10FA35C")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x10FA3EC", Offset = "0x10FA3EC", VA = "0x10FA3EC")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x10FAAA4", Offset = "0x10FAAA4", VA = "0x10FAAA4")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x10FABDC", Offset = "0x10FABDC", VA = "0x10FABDC")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x10FAD74", Offset = "0x10FAD74", VA = "0x10FAD74")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x10EECC0", Offset = "0x10EECC0", VA = "0x10EECC0")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x10FAEB0", Offset = "0x10FAEB0", VA = "0x10FAEB0")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x10FAFEC", Offset = "0x10FAFEC", VA = "0x10FAFEC")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x10FB100", Offset = "0x10FB100", VA = "0x10FB100")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x10FB214", Offset = "0x10FB214", VA = "0x10FB214")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x10FB328", Offset = "0x10FB328", VA = "0x10FB328")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x10FB41C", Offset = "0x10FB41C", VA = "0x10FB41C")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x10FB5BC", Offset = "0x10FB5BC", VA = "0x10FB5BC")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x10FB744", Offset = "0x10FB744", VA = "0x10FB744")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x10EF2FC", Offset = "0x10EF2FC", VA = "0x10EF2FC")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x10EF594", Offset = "0x10EF594", VA = "0x10EF594")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x10EF770", Offset = "0x10EF770", VA = "0x10EF770")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x10EF980", Offset = "0x10EF980", VA = "0x10EF980")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x10FB8CC", Offset = "0x10FB8CC", VA = "0x10FB8CC")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x10FBA04", Offset = "0x10FBA04", VA = "0x10FBA04")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x10FBAD8", Offset = "0x10FBAD8", VA = "0x10FBAD8")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x10FBC10", Offset = "0x10FBC10", VA = "0x10FBC10")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x10FBEAC", Offset = "0x10FBEAC", VA = "0x10FBEAC")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x10FC000", Offset = "0x10FC000", VA = "0x10FC000")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x10FC154", Offset = "0x10FC154", VA = "0x10FC154")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x10FC2E4", Offset = "0x10FC2E4", VA = "0x10FC2E4")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x10FC438", Offset = "0x10FC438", VA = "0x10FC438")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x10FC5C8", Offset = "0x10FC5C8", VA = "0x10FC5C8")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x10FC708", Offset = "0x10FC708", VA = "0x10FC708")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x10FC848", Offset = "0x10FC848", VA = "0x10FC848")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x10FC93C", Offset = "0x10FC93C", VA = "0x10FC93C")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x10FCA30", Offset = "0x10FCA30", VA = "0x10FCA30")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x10FCB24", Offset = "0x10FCB24", VA = "0x10FCB24")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x10FCBF8", Offset = "0x10FCBF8", VA = "0x10FCBF8")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x10FCE94", Offset = "0x10FCE94", VA = "0x10FCE94")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x10FCF88", Offset = "0x10FCF88", VA = "0x10FCF88")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x10FD07C", Offset = "0x10FD07C", VA = "0x10FD07C")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x10FD170", Offset = "0x10FD170", VA = "0x10FD170")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x10FD2C4", Offset = "0x10FD2C4", VA = "0x10FD2C4")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x10FD418", Offset = "0x10FD418", VA = "0x10FD418")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x10FD534", Offset = "0x10FD534", VA = "0x10FD534")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x10FD608", Offset = "0x10FD608", VA = "0x10FD608")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x10FD72C", Offset = "0x10FD72C", VA = "0x10FD72C")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x10FD800", Offset = "0x10FD800", VA = "0x10FD800")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x10FD8F4", Offset = "0x10FD8F4", VA = "0x10FD8F4")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x10FD9E8", Offset = "0x10FD9E8", VA = "0x10FD9E8")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x10FDADC", Offset = "0x10FDADC", VA = "0x10FDADC")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x10FDBF8", Offset = "0x10FDBF8", VA = "0x10FDBF8")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x10FDD24", Offset = "0x10FDD24", VA = "0x10FDD24")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x10FDDF8", Offset = "0x10FDDF8", VA = "0x10FDDF8")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x10FDF38", Offset = "0x10FDF38", VA = "0x10FDF38")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x10FE02C", Offset = "0x10FE02C", VA = "0x10FE02C")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x10FE120", Offset = "0x10FE120", VA = "0x10FE120")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x10FE214", Offset = "0x10FE214", VA = "0x10FE214")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x10FE354", Offset = "0x10FE354", VA = "0x10FE354")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x10FE494", Offset = "0x10FE494", VA = "0x10FE494")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x10FE624", Offset = "0x10FE624", VA = "0x10FE624")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x10FE72C", Offset = "0x10FE72C", VA = "0x10FE72C")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x10FE914", Offset = "0x10FE914", VA = "0x10FE914")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x10FEAC8", Offset = "0x10FEAC8", VA = "0x10FEAC8")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x10FEC7C", Offset = "0x10FEC7C", VA = "0x10FEC7C")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x10FEECC", Offset = "0x10FEECC", VA = "0x10FEECC")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x10FF11C", Offset = "0x10FF11C", VA = "0x10FF11C")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x10FF2E0", Offset = "0x10FF2E0", VA = "0x10FF2E0")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x10FF448", Offset = "0x10FF448", VA = "0x10FF448")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x10FF5EC", Offset = "0x10FF5EC", VA = "0x10FF5EC")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x10FF764", Offset = "0x10FF764", VA = "0x10FF764")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x10FF8D8", Offset = "0x10FF8D8", VA = "0x10FF8D8")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x10FF9E0", Offset = "0x10FF9E0", VA = "0x10FF9E0")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x10FFB08", Offset = "0x10FFB08", VA = "0x10FFB08")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x10FFC30", Offset = "0x10FFC30", VA = "0x10FFC30")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x10FFD58", Offset = "0x10FFD58", VA = "0x10FFD58")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x10FFEE4", Offset = "0x10FFEE4", VA = "0x10FFEE4")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x1100050", Offset = "0x1100050", VA = "0x1100050")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x11001B4", Offset = "0x11001B4", VA = "0x11001B4")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x1100318", Offset = "0x1100318", VA = "0x1100318")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x1100420", Offset = "0x1100420", VA = "0x1100420")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x1100564", Offset = "0x1100564", VA = "0x1100564")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x110068C", Offset = "0x110068C", VA = "0x110068C")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x1100828", Offset = "0x1100828", VA = "0x1100828")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x11008C4", Offset = "0x11008C4", VA = "0x11008C4")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1100A30", Offset = "0x1100A30", VA = "0x1100A30")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1100A58", Offset = "0x1100A58", VA = "0x1100A58")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1100A78", Offset = "0x1100A78", VA = "0x1100A78")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1100ADC", Offset = "0x1100ADC", VA = "0x1100ADC")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1100CC8", Offset = "0x1100CC8", VA = "0x1100CC8")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1100D5C", Offset = "0x1100D5C", VA = "0x1100D5C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x1100E48", Offset = "0x1100E48", VA = "0x1100E48")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1100F6C", Offset = "0x1100F6C", VA = "0x1100F6C")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1100F90", Offset = "0x1100F90", VA = "0x1100F90")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1100FBC", Offset = "0x1100FBC", VA = "0x1100FBC")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1101024", Offset = "0x1101024", VA = "0x1101024")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1101070", Offset = "0x1101070", VA = "0x1101070")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1101098", Offset = "0x1101098", VA = "0x1101098")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x11010D0", Offset = "0x11010D0", VA = "0x11010D0")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x110113C", Offset = "0x110113C", VA = "0x110113C")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1101168", Offset = "0x1101168", VA = "0x1101168")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x11011A0", Offset = "0x11011A0", VA = "0x11011A0")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1101210", Offset = "0x1101210", VA = "0x1101210")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1101240", Offset = "0x1101240", VA = "0x1101240")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1101280", Offset = "0x1101280", VA = "0x1101280")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x11012FC", Offset = "0x11012FC", VA = "0x11012FC")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x11013B4", Offset = "0x11013B4", VA = "0x11013B4")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1101468", Offset = "0x1101468", VA = "0x1101468")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x110152C", Offset = "0x110152C", VA = "0x110152C")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x11015E4", Offset = "0x11015E4", VA = "0x11015E4")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x110169C", Offset = "0x110169C", VA = "0x110169C")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x11017C8", Offset = "0x11017C8", VA = "0x11017C8")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x110189C", Offset = "0x110189C", VA = "0x110189C")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x110196C", Offset = "0x110196C", VA = "0x110196C")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x10E0C54", Offset = "0x10E0C54", VA = "0x10E0C54")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x10E06B0", Offset = "0x10E06B0", VA = "0x10E06B0")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1101A98", Offset = "0x1101A98", VA = "0x1101A98")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x1101BA4", Offset = "0x1101BA4", VA = "0x1101BA4")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1101BEC", Offset = "0x1101BEC", VA = "0x1101BEC")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1101C40", Offset = "0x1101C40", VA = "0x1101C40")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x10E1300", Offset = "0x10E1300", VA = "0x10E1300")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x10E157C", Offset = "0x10E157C", VA = "0x10E157C")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x10E17EC", Offset = "0x10E17EC", VA = "0x10E17EC")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x1101CE4", Offset = "0x1101CE4", VA = "0x1101CE4")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x1101D70", Offset = "0x1101D70", VA = "0x1101D70")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1102488", Offset = "0x1102488", VA = "0x1102488")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x1102884", Offset = "0x1102884", VA = "0x1102884")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x1102514", Offset = "0x1102514", VA = "0x1102514")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x11029AC", Offset = "0x11029AC", VA = "0x11029AC")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x1102A30", Offset = "0x1102A30", VA = "0x1102A30")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x1102D94", Offset = "0x1102D94", VA = "0x1102D94")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000A")]
public class LTUtility
{
	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x10E2AD4", Offset = "0x10E2AD4", VA = "0x10E2AD4")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x10F16EC", Offset = "0x10F16EC", VA = "0x10F16EC")]
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
	[Address(RVA = "0x10D38A8", Offset = "0x10D38A8", VA = "0x10D38A8")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x10D3E5C", Offset = "0x10D3E5C", VA = "0x10D3E5C")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x10D3CF4", Offset = "0x10D3CF4", VA = "0x10D3CF4")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x10D4080", Offset = "0x10D4080", VA = "0x10D4080")]
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
		[Address(RVA = "0x10D46C4", Offset = "0x10D46C4", VA = "0x10D46C4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x10D40B0", Offset = "0x10D40B0", VA = "0x10D40B0")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x10D40B8", Offset = "0x10D40B8", VA = "0x10D40B8")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x10D40E0", Offset = "0x10D40E0", VA = "0x10D40E0")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x10D46CC", Offset = "0x10D46CC", VA = "0x10D46CC")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x10D48C8", Offset = "0x10D48C8", VA = "0x10D48C8")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x10D4AA8", Offset = "0x10D4AA8", VA = "0x10D4AA8")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x10D4C88", Offset = "0x10D4C88", VA = "0x10D4C88")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x10D4D3C", Offset = "0x10D4D3C", VA = "0x10D4D3C")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x10D4E00", Offset = "0x10D4E00", VA = "0x10D4E00")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x10D4EB4", Offset = "0x10D4EB4", VA = "0x10D4EB4")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x10D4FEC", Offset = "0x10D4FEC", VA = "0x10D4FEC")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x10D50DC", Offset = "0x10D50DC", VA = "0x10D50DC")]
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
	[Address(RVA = "0x10E2C28", Offset = "0x10E2C28", VA = "0x10E2C28")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x10F0130", Offset = "0x10F0130", VA = "0x10F0130")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x10EFC48", Offset = "0x10EFC48", VA = "0x10EFC48")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x10F06CC", Offset = "0x10F06CC", VA = "0x10F06CC")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x10F0170", Offset = "0x10F0170", VA = "0x10F0170")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x10F0940", Offset = "0x10F0940", VA = "0x10F0940")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x10E3BB8", Offset = "0x10E3BB8", VA = "0x10E3BB8")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x10E3924", Offset = "0x10E3924", VA = "0x10E3924")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x10E3DE4", Offset = "0x10E3DE4", VA = "0x10E3DE4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x10E3B04", Offset = "0x10E3B04", VA = "0x10E3B04")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x10F0AB0", Offset = "0x10F0AB0", VA = "0x10F0AB0")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x10E4044", Offset = "0x10E4044", VA = "0x10E4044")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x10F0B74", Offset = "0x10F0B74", VA = "0x10F0B74")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x10F0C88", Offset = "0x10F0C88", VA = "0x10F0C88")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x10F0D70", Offset = "0x10F0D70", VA = "0x10F0D70")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x10F0EE8", Offset = "0x10F0EE8", VA = "0x10F0EE8")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x10F11D8", Offset = "0x10F11D8", VA = "0x10F11D8")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x10F11E8", Offset = "0x10F11E8", VA = "0x10F11E8")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x10F1488", Offset = "0x10F1488", VA = "0x10F1488")]
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
	[HideInInspector]
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
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000006")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x10ECC4C", Offset = "0x10ECC4C", VA = "0x10ECC4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000007")]
	public int id
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x10ED6D0", Offset = "0x10ED6D0", VA = "0x10ED6D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000008")]
	public float x
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x10EE5C0", Offset = "0x10EE5C0", VA = "0x10EE5C0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x10EE5CC", Offset = "0x10EE5CC", VA = "0x10EE5CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public float y
	{
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x10EE5D8", Offset = "0x10EE5D8", VA = "0x10EE5D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x10EE5E4", Offset = "0x10EE5E4", VA = "0x10EE5E4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float width
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x10EE5F0", Offset = "0x10EE5F0", VA = "0x10EE5F0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x10EE5FC", Offset = "0x10EE5FC", VA = "0x10EE5FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float height
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x10EE608", Offset = "0x10EE608", VA = "0x10EE608")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x10EE614", Offset = "0x10EE614", VA = "0x10EE614")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public Rect rect
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x10E9B6C", Offset = "0x10E9B6C", VA = "0x10E9B6C")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x10E9F98", Offset = "0x10E9F98", VA = "0x10E9F98")]
		set
		{
		}
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x10EE158", Offset = "0x10EE158", VA = "0x10EE158")]
	public LTRect()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x10E2690", Offset = "0x10E2690", VA = "0x10E2690")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x10EE2E4", Offset = "0x10EE2E4", VA = "0x10EE2E4")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x10EE3D0", Offset = "0x10EE3D0", VA = "0x10EE3D0")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x10EE4B8", Offset = "0x10EE4B8", VA = "0x10EE4B8")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x10ED6E0", Offset = "0x10ED6E0", VA = "0x10ED6E0")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x10EE22C", Offset = "0x10EE22C", VA = "0x10EE22C")]
	public void reset()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x10EA520", Offset = "0x10EA520", VA = "0x10EA520")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x10EE620", Offset = "0x10EE620", VA = "0x10EE620")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x10EE628", Offset = "0x10EE628", VA = "0x10EE628")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x10EE630", Offset = "0x10EE630", VA = "0x10EE630")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x10EE650", Offset = "0x10EE650", VA = "0x10EE650")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x10EE658", Offset = "0x10EE658", VA = "0x10EE658")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x10EE660", Offset = "0x10EE660", VA = "0x10EE660")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x10EE684", Offset = "0x10EE684", VA = "0x10EE684")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x10EE704", Offset = "0x10EE704", VA = "0x10EE704")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x10EE70C", Offset = "0x10EE70C", VA = "0x10EE70C", Slot = "3")]
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
	[Address(RVA = "0x10EAA84", Offset = "0x10EAA84", VA = "0x10EAA84")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000010")]
public class LTGUI
{
	[Token(Token = "0x2000017")]
	public enum Element_Type
	{
		[Token(Token = "0x4000129")]
		Texture,
		[Token(Token = "0x400012A")]
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
	[Address(RVA = "0x10EAAAC", Offset = "0x10EAAAC", VA = "0x10EAAAC")]
	public static void init()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x10EABD0", Offset = "0x10EABD0", VA = "0x10EABD0")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x10EADFC", Offset = "0x10EADFC", VA = "0x10EADFC")]
	public static void reset()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x10EB09C", Offset = "0x10EB09C", VA = "0x10EB09C")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x10EC8C8", Offset = "0x10EC8C8", VA = "0x10EC8C8")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x10EC9CC", Offset = "0x10EC9CC", VA = "0x10EC9CC")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x10ECC60", Offset = "0x10ECC60", VA = "0x10ECC60")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x10ECDCC", Offset = "0x10ECDCC", VA = "0x10ECDCC")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x10ECE9C", Offset = "0x10ECE9C", VA = "0x10ECE9C")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x10ED540", Offset = "0x10ED540", VA = "0x10ED540")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x10ED610", Offset = "0x10ED610", VA = "0x10ED610")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x10ECF5C", Offset = "0x10ECF5C", VA = "0x10ECF5C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x10ED6EC", Offset = "0x10ED6EC", VA = "0x10ED6EC")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x10EDCC4", Offset = "0x10EDCC4", VA = "0x10EDCC4")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x10EDF84", Offset = "0x10EDF84", VA = "0x10EDF84")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x10EDE44", Offset = "0x10EDE44", VA = "0x10EDE44")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x10EE08C", Offset = "0x10EE08C", VA = "0x10EE08C")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000011")]
public class LTDescr
{
	[Token(Token = "0x2000018")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000019")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC3B4", Offset = "0x5CC3B4")]
	private sealed class <>c
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static ActionMethodDelegate <>9__110_0;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__111_0;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x10EA998", Offset = "0x10EA998", VA = "0x10EA998")]
		public <>c()
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x10EA9A0", Offset = "0x10EA9A0", VA = "0x10EA9A0")]
		internal void <setCallback>b__110_0()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x10EA9A4", Offset = "0x10EA9A4", VA = "0x10EA9A4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC3E4", Offset = "0x5CC3E4")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC3F4", Offset = "0x5CC3F4")]
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
		[Address(RVA = "0x10D51E8", Offset = "0x10D51E8", VA = "0x10D51E8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x10D51FC", Offset = "0x10D51FC", VA = "0x10D51FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public Vector3 to
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x10D5208", Offset = "0x10D5208", VA = "0x10D5208")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x10D521C", Offset = "0x10D521C", VA = "0x10D521C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x10D5228", Offset = "0x10D5228", VA = "0x10D5228")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC65C", Offset = "0x5CC65C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x10D5230", Offset = "0x10D5230", VA = "0x10D5230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC66C", Offset = "0x5CC66C")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x10D5238", Offset = "0x10D5238", VA = "0x10D5238")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC67C", Offset = "0x5CC67C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x10D5240", Offset = "0x10D5240", VA = "0x10D5240")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC68C", Offset = "0x5CC68C")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public int uniqueId
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x10D60B8", Offset = "0x10D60B8", VA = "0x10D60B8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public int id
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x10D5F24", Offset = "0x10D5F24", VA = "0x10D5F24")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000013")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x10D61E8", Offset = "0x10D61E8", VA = "0x10D61E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x10D61F0", Offset = "0x10D61F0", VA = "0x10D61F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x10D5248", Offset = "0x10D5248", VA = "0x10D5248", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x10D5F34", Offset = "0x10D5F34", VA = "0x10D5F34")]
	public LTDescr()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x10D5FB8", Offset = "0x10D5FB8", VA = "0x10D5FB8")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x5CC69C", Offset = "0x5CC69C")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x10D61F8", Offset = "0x10D61F8", VA = "0x10D61F8")]
	public void reset()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x10D644C", Offset = "0x10D644C", VA = "0x10D644C")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x10D651C", Offset = "0x10D651C", VA = "0x10D651C")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x10D65D8", Offset = "0x10D65D8", VA = "0x10D65D8")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x10D6694", Offset = "0x10D6694", VA = "0x10D6694")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x10D6750", Offset = "0x10D6750", VA = "0x10D6750")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x10D680C", Offset = "0x10D680C", VA = "0x10D680C")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x10D68C8", Offset = "0x10D68C8", VA = "0x10D68C8")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x10D68D4", Offset = "0x10D68D4", VA = "0x10D68D4")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x10D6990", Offset = "0x10D6990", VA = "0x10D6990")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x10D6A4C", Offset = "0x10D6A4C", VA = "0x10D6A4C")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x10D6B08", Offset = "0x10D6B08", VA = "0x10D6B08")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x10D6BC4", Offset = "0x10D6BC4", VA = "0x10D6BC4")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x10D6C80", Offset = "0x10D6C80", VA = "0x10D6C80")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x10D6D3C", Offset = "0x10D6D3C", VA = "0x10D6D3C")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x10D6DF8", Offset = "0x10D6DF8", VA = "0x10D6DF8")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x10D6EB4", Offset = "0x10D6EB4", VA = "0x10D6EB4")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x10D6F70", Offset = "0x10D6F70", VA = "0x10D6F70")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x10D702C", Offset = "0x10D702C", VA = "0x10D702C")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x10D70E8", Offset = "0x10D70E8", VA = "0x10D70E8")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x10D71A4", Offset = "0x10D71A4", VA = "0x10D71A4")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x10D7260", Offset = "0x10D7260", VA = "0x10D7260")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x10D731C", Offset = "0x10D731C", VA = "0x10D731C")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x10D73D8", Offset = "0x10D73D8", VA = "0x10D73D8")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x10D7494", Offset = "0x10D7494", VA = "0x10D7494")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x10D7550", Offset = "0x10D7550", VA = "0x10D7550")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x10D760C", Offset = "0x10D760C", VA = "0x10D760C")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x10D76C8", Offset = "0x10D76C8", VA = "0x10D76C8")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x10D7784", Offset = "0x10D7784", VA = "0x10D7784")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x10D7840", Offset = "0x10D7840", VA = "0x10D7840")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x10D78FC", Offset = "0x10D78FC", VA = "0x10D78FC")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x10D79B8", Offset = "0x10D79B8", VA = "0x10D79B8")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x10D7A74", Offset = "0x10D7A74", VA = "0x10D7A74")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x10D7AF0", Offset = "0x10D7AF0", VA = "0x10D7AF0")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x10D7BAC", Offset = "0x10D7BAC", VA = "0x10D7BAC")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x10D7C68", Offset = "0x10D7C68", VA = "0x10D7C68")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x10D7D24", Offset = "0x10D7D24", VA = "0x10D7D24")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x10D7DE0", Offset = "0x10D7DE0", VA = "0x10D7DE0")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x10D7E9C", Offset = "0x10D7E9C", VA = "0x10D7E9C")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x10D7F58", Offset = "0x10D7F58", VA = "0x10D7F58")]
	private void callback()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x10D848C", Offset = "0x10D848C", VA = "0x10D848C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x10D85F0", Offset = "0x10D85F0", VA = "0x10D85F0")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x10D8754", Offset = "0x10D8754", VA = "0x10D8754")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x10D8810", Offset = "0x10D8810", VA = "0x10D8810")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x10D88CC", Offset = "0x10D88CC", VA = "0x10D88CC")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x10D8988", Offset = "0x10D8988", VA = "0x10D8988")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x10D8A44", Offset = "0x10D8A44", VA = "0x10D8A44")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x10D8B00", Offset = "0x10D8B00", VA = "0x10D8B00")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x10D8BBC", Offset = "0x10D8BBC", VA = "0x10D8BBC")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x10D8C78", Offset = "0x10D8C78", VA = "0x10D8C78")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x10D8D34", Offset = "0x10D8D34", VA = "0x10D8D34")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x10D8DF0", Offset = "0x10D8DF0", VA = "0x10D8DF0")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x10D8EAC", Offset = "0x10D8EAC", VA = "0x10D8EAC")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x10D8F68", Offset = "0x10D8F68", VA = "0x10D8F68")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x10D9024", Offset = "0x10D9024", VA = "0x10D9024")]
	private void init()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x10D98C4", Offset = "0x10D98C4", VA = "0x10D98C4")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x10D9A40", Offset = "0x10D9A40", VA = "0x10D9A40")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x10D9A58", Offset = "0x10D9A58", VA = "0x10D9A58")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x10D968C", Offset = "0x10D968C", VA = "0x10D968C")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x10DA0AC", Offset = "0x10DA0AC", VA = "0x10DA0AC")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x10DA194", Offset = "0x10DA194", VA = "0x10DA194")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x10DA870", Offset = "0x10DA870", VA = "0x10DA870")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x10DAD40", Offset = "0x10DAD40", VA = "0x10DAD40")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x10DB260", Offset = "0x10DB260", VA = "0x10DB260")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x10DB734", Offset = "0x10DB734", VA = "0x10DB734")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x10DBC58", Offset = "0x10DBC58", VA = "0x10DBC58")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x10DC170", Offset = "0x10DC170", VA = "0x10DC170")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x10DC5B8", Offset = "0x10DC5B8", VA = "0x10DC5B8")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x10DC9F8", Offset = "0x10DC9F8", VA = "0x10DC9F8")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10DCE44", Offset = "0x10DCE44", VA = "0x10DCE44")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x10DD04C", Offset = "0x10DD04C", VA = "0x10DD04C")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x10DD068", Offset = "0x10DD068", VA = "0x10DD068")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x10DD074", Offset = "0x10DD074", VA = "0x10DD074")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x10DD0B4", Offset = "0x10DD0B4", VA = "0x10DD0B4")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x10DD0BC", Offset = "0x10DD0BC", VA = "0x10DD0BC")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x10DD278", Offset = "0x10DD278", VA = "0x10DD278")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x10DE5D0", Offset = "0x10DE5D0", VA = "0x10DE5D0")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x10DD398", Offset = "0x10DD398", VA = "0x10DD398")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x10DD308", Offset = "0x10DD308", VA = "0x10DD308")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x10DD428", Offset = "0x10DD428", VA = "0x10DD428")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x10DD4B8", Offset = "0x10DD4B8", VA = "0x10DD4B8")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x10DD548", Offset = "0x10DD548", VA = "0x10DD548")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x10DD5D8", Offset = "0x10DD5D8", VA = "0x10DD5D8")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x10DD668", Offset = "0x10DD668", VA = "0x10DD668")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x10DD6F8", Offset = "0x10DD6F8", VA = "0x10DD6F8")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x10DD788", Offset = "0x10DD788", VA = "0x10DD788")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x10DD818", Offset = "0x10DD818", VA = "0x10DD818")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x10DD8A8", Offset = "0x10DD8A8", VA = "0x10DD8A8")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x10DD938", Offset = "0x10DD938", VA = "0x10DD938")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x10DD9C8", Offset = "0x10DD9C8", VA = "0x10DD9C8")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x10DDA58", Offset = "0x10DDA58", VA = "0x10DDA58")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x10DDAE8", Offset = "0x10DDAE8", VA = "0x10DDAE8")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x10DDB78", Offset = "0x10DDB78", VA = "0x10DDB78")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x10DDC08", Offset = "0x10DDC08", VA = "0x10DDC08")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x10DDC98", Offset = "0x10DDC98", VA = "0x10DDC98")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x10DDD28", Offset = "0x10DDD28", VA = "0x10DDD28")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x10DDDB8", Offset = "0x10DDDB8", VA = "0x10DDDB8")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x10DDE48", Offset = "0x10DDE48", VA = "0x10DDE48")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x10DDED8", Offset = "0x10DDED8", VA = "0x10DDED8")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x10DDF68", Offset = "0x10DDF68", VA = "0x10DDF68")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x10DDFF8", Offset = "0x10DDFF8", VA = "0x10DDFF8")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x10DE088", Offset = "0x10DE088", VA = "0x10DE088")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x10DE118", Offset = "0x10DE118", VA = "0x10DE118")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x10DE1A8", Offset = "0x10DE1A8", VA = "0x10DE1A8")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x10DE238", Offset = "0x10DE238", VA = "0x10DE238")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x10DE2C8", Offset = "0x10DE2C8", VA = "0x10DE2C8")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x10DE358", Offset = "0x10DE358", VA = "0x10DE358")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x10DE3E8", Offset = "0x10DE3E8", VA = "0x10DE3E8")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x10DE4DC", Offset = "0x10DE4DC", VA = "0x10DE4DC")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x10DE660", Offset = "0x10DE660", VA = "0x10DE660")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x10DE7A4", Offset = "0x10DE7A4", VA = "0x10DE7A4")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x10DE8D4", Offset = "0x10DE8D4", VA = "0x10DE8D4")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x10DE9B0", Offset = "0x10DE9B0", VA = "0x10DE9B0")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x10DEAD4", Offset = "0x10DEAD4", VA = "0x10DEAD4")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x10DEBAC", Offset = "0x10DEBAC", VA = "0x10DEBAC")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x10DED9C", Offset = "0x10DED9C", VA = "0x10DED9C")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x10DEE7C", Offset = "0x10DEE7C", VA = "0x10DEE7C")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x10DEF7C", Offset = "0x10DEF7C", VA = "0x10DEF7C")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x10DF0C4", Offset = "0x10DF0C4", VA = "0x10DF0C4")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x10DF1D8", Offset = "0x10DF1D8", VA = "0x10DF1D8")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x10DF2DC", Offset = "0x10DF2DC", VA = "0x10DF2DC")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x10DF4C0", Offset = "0x10DF4C0", VA = "0x10DF4C0")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x10DF5B8", Offset = "0x10DF5B8", VA = "0x10DF5B8")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x10DF6C0", Offset = "0x10DF6C0", VA = "0x10DF6C0")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x10DF818", Offset = "0x10DF818", VA = "0x10DF818")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x10DF984", Offset = "0x10DF984", VA = "0x10DF984")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x10DFAE0", Offset = "0x10DFAE0", VA = "0x10DFAE0")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x10DFC10", Offset = "0x10DFC10", VA = "0x10DFC10")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x10DFD34", Offset = "0x10DFD34", VA = "0x10DFD34")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x10DFE5C", Offset = "0x10DFE5C", VA = "0x10DFE5C")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x10E008C", Offset = "0x10E008C", VA = "0x10E008C")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x10E01CC", Offset = "0x10E01CC", VA = "0x10E01CC")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x10E032C", Offset = "0x10E032C", VA = "0x10E032C")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x10E0528", Offset = "0x10E0528", VA = "0x10E0528")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x10E0784", Offset = "0x10E0784", VA = "0x10E0784")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x10E09E0", Offset = "0x10E09E0", VA = "0x10E09E0")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x10E0D0C", Offset = "0x10E0D0C", VA = "0x10E0D0C")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x10E0E88", Offset = "0x10E0E88", VA = "0x10E0E88")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x10E0FD4", Offset = "0x10E0FD4", VA = "0x10E0FD4")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x10E11E0", Offset = "0x10E11E0", VA = "0x10E11E0")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x10E145C", Offset = "0x10E145C", VA = "0x10E145C")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x10E16CC", Offset = "0x10E16CC", VA = "0x10E16CC")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x10E19F8", Offset = "0x10E19F8", VA = "0x10E19F8")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x10E1A00", Offset = "0x10E1A00", VA = "0x10E1A00")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x10E1A08", Offset = "0x10E1A08", VA = "0x10E1A08")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x10E1A10", Offset = "0x10E1A10", VA = "0x10E1A10")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x10E1ABC", Offset = "0x10E1ABC", VA = "0x10E1ABC")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x10E1B9C", Offset = "0x10E1B9C", VA = "0x10E1B9C")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x10E1BD4", Offset = "0x10E1BD4", VA = "0x10E1BD4")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x10E1D28", Offset = "0x10E1D28", VA = "0x10E1D28")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x10E1D74", Offset = "0x10E1D74", VA = "0x10E1D74")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x10E1D80", Offset = "0x10E1D80", VA = "0x10E1D80")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x10E1D88", Offset = "0x10E1D88", VA = "0x10E1D88")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x10E1D94", Offset = "0x10E1D94", VA = "0x10E1D94")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x10E1D9C", Offset = "0x10E1D9C", VA = "0x10E1D9C")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x10E1DBC", Offset = "0x10E1DBC", VA = "0x10E1DBC")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x10E1DE4", Offset = "0x10E1DE4", VA = "0x10E1DE4")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x10E1E30", Offset = "0x10E1E30", VA = "0x10E1E30")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x10E1E38", Offset = "0x10E1E38", VA = "0x10E1E38")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x10E1E48", Offset = "0x10E1E48", VA = "0x10E1E48")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x10E1E58", Offset = "0x10E1E58", VA = "0x10E1E58")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x10E1E68", Offset = "0x10E1E68", VA = "0x10E1E68")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x10E1E78", Offset = "0x10E1E78", VA = "0x10E1E78")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x10E1E88", Offset = "0x10E1E88", VA = "0x10E1E88")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x10E1E94", Offset = "0x10E1E94", VA = "0x10E1E94")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x10E1EB0", Offset = "0x10E1EB0", VA = "0x10E1EB0")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x10E1EB8", Offset = "0x10E1EB8", VA = "0x10E1EB8")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x10E1ED4", Offset = "0x10E1ED4", VA = "0x10E1ED4")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x10E1F10", Offset = "0x10E1F10", VA = "0x10E1F10")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x10E1F50", Offset = "0x10E1F50", VA = "0x10E1F50")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x10E1F90", Offset = "0x10E1F90", VA = "0x10E1F90")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x10E1FF4", Offset = "0x10E1FF4", VA = "0x10E1FF4")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x10E202C", Offset = "0x10E202C", VA = "0x10E202C")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x10E206C", Offset = "0x10E206C", VA = "0x10E206C")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x10E20AC", Offset = "0x10E20AC", VA = "0x10E20AC")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x10E20EC", Offset = "0x10E20EC", VA = "0x10E20EC")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x10E212C", Offset = "0x10E212C", VA = "0x10E212C")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x10E216C", Offset = "0x10E216C", VA = "0x10E216C")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x10E21AC", Offset = "0x10E21AC", VA = "0x10E21AC")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x10E21EC", Offset = "0x10E21EC", VA = "0x10E21EC")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x10E2224", Offset = "0x10E2224", VA = "0x10E2224")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x10E225C", Offset = "0x10E225C", VA = "0x10E225C")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x10E22C0", Offset = "0x10E22C0", VA = "0x10E22C0")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x10E2324", Offset = "0x10E2324", VA = "0x10E2324")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x10E2380", Offset = "0x10E2380", VA = "0x10E2380")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x10E23DC", Offset = "0x10E23DC", VA = "0x10E23DC")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x10E240C", Offset = "0x10E240C", VA = "0x10E240C")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x10E2528", Offset = "0x10E2528", VA = "0x10E2528")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x10E25AC", Offset = "0x10E25AC", VA = "0x10E25AC")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x10E25E4", Offset = "0x10E25E4", VA = "0x10E25E4")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x10E2748", Offset = "0x10E2748", VA = "0x10E2748")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x10E2778", Offset = "0x10E2778", VA = "0x10E2778")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x10E27C4", Offset = "0x10E27C4", VA = "0x10E27C4")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x10E27CC", Offset = "0x10E27CC", VA = "0x10E27CC")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x10E1E28", Offset = "0x10E1E28", VA = "0x10E1E28")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x10E27FC", Offset = "0x10E27FC", VA = "0x10E27FC")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x10E2804", Offset = "0x10E2804", VA = "0x10E2804")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x10E280C", Offset = "0x10E280C", VA = "0x10E280C")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x10E2814", Offset = "0x10E2814", VA = "0x10E2814")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x10E2858", Offset = "0x10E2858", VA = "0x10E2858")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x10E2890", Offset = "0x10E2890", VA = "0x10E2890")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x10E2C68", Offset = "0x10E2C68", VA = "0x10E2C68")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x10E2C70", Offset = "0x10E2C70", VA = "0x10E2C70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC6F0", Offset = "0x5CC6F0")]
	private void <setMoveX>b__71_0()
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x10E2CB4", Offset = "0x10E2CB4", VA = "0x10E2CB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC700", Offset = "0x5CC700")]
	private void <setMoveX>b__71_1()
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x10E2D98", Offset = "0x10E2D98", VA = "0x10E2D98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC710", Offset = "0x5CC710")]
	private void <setMoveY>b__72_0()
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x10E2DDC", Offset = "0x10E2DDC", VA = "0x10E2DDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC720", Offset = "0x5CC720")]
	private void <setMoveY>b__72_1()
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x10E2EB8", Offset = "0x10E2EB8", VA = "0x10E2EB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC730", Offset = "0x5CC730")]
	private void <setMoveZ>b__73_0()
	{
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x10E2EFC", Offset = "0x10E2EFC", VA = "0x10E2EFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC740", Offset = "0x5CC740")]
	private void <setMoveZ>b__73_1()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x10E2FDC", Offset = "0x10E2FDC", VA = "0x10E2FDC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC750", Offset = "0x5CC750")]
	private void <setMoveLocalX>b__74_0()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x10E3020", Offset = "0x10E3020", VA = "0x10E3020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC760", Offset = "0x5CC760")]
	private void <setMoveLocalX>b__74_1()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x10E3104", Offset = "0x10E3104", VA = "0x10E3104")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC770", Offset = "0x5CC770")]
	private void <setMoveLocalY>b__75_0()
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x10E3148", Offset = "0x10E3148", VA = "0x10E3148")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC780", Offset = "0x5CC780")]
	private void <setMoveLocalY>b__75_1()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x10E3224", Offset = "0x10E3224", VA = "0x10E3224")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC790", Offset = "0x5CC790")]
	private void <setMoveLocalZ>b__76_0()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x10E3268", Offset = "0x10E3268", VA = "0x10E3268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7A0", Offset = "0x5CC7A0")]
	private void <setMoveLocalZ>b__76_1()
	{
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x10E3348", Offset = "0x10E3348", VA = "0x10E3348")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7B0", Offset = "0x5CC7B0")]
	private void <setMoveCurved>b__78_0()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x10E353C", Offset = "0x10E353C", VA = "0x10E353C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7C0", Offset = "0x5CC7C0")]
	private void <setMoveCurvedLocal>b__79_0()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x10E3730", Offset = "0x10E3730", VA = "0x10E3730")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7D0", Offset = "0x5CC7D0")]
	private void <setMoveSpline>b__80_0()
	{
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x10E3BF0", Offset = "0x10E3BF0", VA = "0x10E3BF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7E0", Offset = "0x5CC7E0")]
	private void <setMoveSplineLocal>b__81_0()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x10E40F8", Offset = "0x10E40F8", VA = "0x10E40F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC7F0", Offset = "0x5CC7F0")]
	private void <setScaleX>b__82_0()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x10E413C", Offset = "0x10E413C", VA = "0x10E413C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC800", Offset = "0x5CC800")]
	private void <setScaleX>b__82_1()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x10E4220", Offset = "0x10E4220", VA = "0x10E4220")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC810", Offset = "0x5CC810")]
	private void <setScaleY>b__83_0()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x10E4264", Offset = "0x10E4264", VA = "0x10E4264")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC820", Offset = "0x5CC820")]
	private void <setScaleY>b__83_1()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x10E4340", Offset = "0x10E4340", VA = "0x10E4340")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC830", Offset = "0x5CC830")]
	private void <setScaleZ>b__84_0()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x10E4384", Offset = "0x10E4384", VA = "0x10E4384")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC840", Offset = "0x5CC840")]
	private void <setScaleZ>b__84_1()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x10E4464", Offset = "0x10E4464", VA = "0x10E4464")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC850", Offset = "0x5CC850")]
	private void <setRotateX>b__85_0()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x10E461C", Offset = "0x10E461C", VA = "0x10E461C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC860", Offset = "0x5CC860")]
	private void <setRotateX>b__85_1()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x10E4700", Offset = "0x10E4700", VA = "0x10E4700")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC870", Offset = "0x5CC870")]
	private void <setRotateY>b__86_0()
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x10E47C8", Offset = "0x10E47C8", VA = "0x10E47C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC880", Offset = "0x5CC880")]
	private void <setRotateY>b__86_1()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x10E48A4", Offset = "0x10E48A4", VA = "0x10E48A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC890", Offset = "0x5CC890")]
	private void <setRotateZ>b__87_0()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x10E496C", Offset = "0x10E496C", VA = "0x10E496C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8A0", Offset = "0x5CC8A0")]
	private void <setRotateZ>b__87_1()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x10E4A4C", Offset = "0x10E4A4C", VA = "0x10E4A4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8B0", Offset = "0x5CC8B0")]
	private void <setRotateAround>b__88_0()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x10E4AB4", Offset = "0x10E4AB4", VA = "0x10E4AB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8C0", Offset = "0x5CC8C0")]
	private void <setRotateAround>b__88_1()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x10E4ED0", Offset = "0x10E4ED0", VA = "0x10E4ED0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8D0", Offset = "0x5CC8D0")]
	private void <setRotateAroundLocal>b__89_0()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x10E4F38", Offset = "0x10E4F38", VA = "0x10E4F38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8E0", Offset = "0x5CC8E0")]
	private void <setRotateAroundLocal>b__89_1()
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x10E537C", Offset = "0x10E537C", VA = "0x10E537C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC8F0", Offset = "0x5CC8F0")]
	private void <setAlpha>b__90_0()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x10E5C48", Offset = "0x10E5C48", VA = "0x10E5C48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC900", Offset = "0x5CC900")]
	private void <setAlpha>b__90_2()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x10E5E58", Offset = "0x10E5E58", VA = "0x10E5E58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC910", Offset = "0x5CC910")]
	private void <setAlpha>b__90_1()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x10E607C", Offset = "0x10E607C", VA = "0x10E607C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC920", Offset = "0x5CC920")]
	private void <setTextAlpha>b__91_0()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x10E6184", Offset = "0x10E6184", VA = "0x10E6184")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC930", Offset = "0x5CC930")]
	private void <setTextAlpha>b__91_1()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x10E61D0", Offset = "0x10E61D0", VA = "0x10E61D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC940", Offset = "0x5CC940")]
	private void <setAlphaVertex>b__92_0()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x10E62C8", Offset = "0x10E62C8", VA = "0x10E62C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC950", Offset = "0x5CC950")]
	private void <setAlphaVertex>b__92_1()
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x10E6638", Offset = "0x10E6638", VA = "0x10E6638")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC960", Offset = "0x5CC960")]
	private void <setColor>b__93_0()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x10E6EFC", Offset = "0x10E6EFC", VA = "0x10E6EFC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC970", Offset = "0x5CC970")]
	private void <setColor>b__93_1()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x10E7204", Offset = "0x10E7204", VA = "0x10E7204")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC980", Offset = "0x5CC980")]
	private void <setCallbackColor>b__94_0()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x10E7254", Offset = "0x10E7254", VA = "0x10E7254")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC990", Offset = "0x5CC990")]
	private void <setCallbackColor>b__94_1()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x10E7544", Offset = "0x10E7544", VA = "0x10E7544")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9A0", Offset = "0x5CC9A0")]
	private void <setTextColor>b__95_0()
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x10E7668", Offset = "0x10E7668", VA = "0x10E7668")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9B0", Offset = "0x5CC9B0")]
	private void <setTextColor>b__95_1()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x10E7858", Offset = "0x10E7858", VA = "0x10E7858")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9C0", Offset = "0x5CC9C0")]
	private void <setCanvasAlpha>b__96_0()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x10E79E0", Offset = "0x10E79E0", VA = "0x10E79E0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9D0", Offset = "0x5CC9D0")]
	private void <setCanvasAlpha>b__96_1()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x10E7C34", Offset = "0x10E7C34", VA = "0x10E7C34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9E0", Offset = "0x5CC9E0")]
	private void <setCanvasGroupAlpha>b__97_0()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x10E7CD0", Offset = "0x10E7CD0", VA = "0x10E7CD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC9F0", Offset = "0x5CC9F0")]
	private void <setCanvasGroupAlpha>b__97_1()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x10E7DA0", Offset = "0x10E7DA0", VA = "0x10E7DA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA00", Offset = "0x5CCA00")]
	private void <setCanvasColor>b__98_0()
	{
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x10E7F44", Offset = "0x10E7F44", VA = "0x10E7F44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA10", Offset = "0x5CCA10")]
	private void <setCanvasColor>b__98_1()
	{
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x10E81A4", Offset = "0x10E81A4", VA = "0x10E81A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA20", Offset = "0x5CCA20")]
	private void <setCanvasMoveX>b__99_0()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x10E81E8", Offset = "0x10E81E8", VA = "0x10E81E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA30", Offset = "0x5CCA30")]
	private void <setCanvasMoveX>b__99_1()
	{
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x10E82A8", Offset = "0x10E82A8", VA = "0x10E82A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA40", Offset = "0x5CCA40")]
	private void <setCanvasMoveY>b__100_0()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x10E82EC", Offset = "0x10E82EC", VA = "0x10E82EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA50", Offset = "0x5CCA50")]
	private void <setCanvasMoveY>b__100_1()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x10E83AC", Offset = "0x10E83AC", VA = "0x10E83AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA60", Offset = "0x5CCA60")]
	private void <setCanvasMoveZ>b__101_0()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x10E83F0", Offset = "0x10E83F0", VA = "0x10E83F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA70", Offset = "0x5CCA70")]
	private void <setCanvasMoveZ>b__101_1()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x10E84B0", Offset = "0x10E84B0", VA = "0x10E84B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA80", Offset = "0x5CCA80")]
	private void <setCanvasRotateAround>b__103_0()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x10E8818", Offset = "0x10E8818", VA = "0x10E8818")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCA90", Offset = "0x5CCA90")]
	private void <setCanvasRotateAroundLocal>b__104_0()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x10E8BF4", Offset = "0x10E8BF4", VA = "0x10E8BF4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAA0", Offset = "0x5CCAA0")]
	private void <setCanvasPlaySprite>b__105_0()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x10E8C78", Offset = "0x10E8C78", VA = "0x10E8C78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAB0", Offset = "0x5CCAB0")]
	private void <setCanvasPlaySprite>b__105_1()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x10E8E5C", Offset = "0x10E8E5C", VA = "0x10E8E5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAC0", Offset = "0x5CCAC0")]
	private void <setCanvasMove>b__106_0()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x10E8EA4", Offset = "0x10E8EA4", VA = "0x10E8EA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAD0", Offset = "0x5CCAD0")]
	private void <setCanvasMove>b__106_1()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x10E8F00", Offset = "0x10E8F00", VA = "0x10E8F00")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAE0", Offset = "0x5CCAE0")]
	private void <setCanvasScale>b__107_0()
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x10E8F48", Offset = "0x10E8F48", VA = "0x10E8F48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCAF0", Offset = "0x5CCAF0")]
	private void <setCanvasScale>b__107_1()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x10E8FA4", Offset = "0x10E8FA4", VA = "0x10E8FA4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB00", Offset = "0x5CCB00")]
	private void <setCanvasSizeDelta>b__108_0()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x10E9068", Offset = "0x10E9068", VA = "0x10E9068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB10", Offset = "0x5CCB10")]
	private void <setCanvasSizeDelta>b__108_1()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x10E9144", Offset = "0x10E9144", VA = "0x10E9144")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB20", Offset = "0x5CCB20")]
	private void <setMove>b__112_0()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x10E918C", Offset = "0x10E918C", VA = "0x10E918C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB30", Offset = "0x5CCB30")]
	private void <setMove>b__112_1()
	{
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x10E925C", Offset = "0x10E925C", VA = "0x10E925C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB40", Offset = "0x5CCB40")]
	private void <setMoveLocal>b__113_0()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x10E92A4", Offset = "0x10E92A4", VA = "0x10E92A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB50", Offset = "0x5CCB50")]
	private void <setMoveLocal>b__113_1()
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x10E9374", Offset = "0x10E9374", VA = "0x10E9374")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB60", Offset = "0x5CCB60")]
	private void <setMoveToTransform>b__114_0()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x10E93BC", Offset = "0x10E93BC", VA = "0x10E93BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB70", Offset = "0x5CCB70")]
	private void <setMoveToTransform>b__114_1()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x10E956C", Offset = "0x10E956C", VA = "0x10E956C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB80", Offset = "0x5CCB80")]
	private void <setRotate>b__115_0()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x10E9698", Offset = "0x10E9698", VA = "0x10E9698")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCB90", Offset = "0x5CCB90")]
	private void <setRotate>b__115_1()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x10E9768", Offset = "0x10E9768", VA = "0x10E9768")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBA0", Offset = "0x5CCBA0")]
	private void <setRotateLocal>b__116_0()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x10E9894", Offset = "0x10E9894", VA = "0x10E9894")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBB0", Offset = "0x5CCBB0")]
	private void <setRotateLocal>b__116_1()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x10E9964", Offset = "0x10E9964", VA = "0x10E9964")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBC0", Offset = "0x5CCBC0")]
	private void <setScale>b__117_0()
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x10E99AC", Offset = "0x10E99AC", VA = "0x10E99AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBD0", Offset = "0x5CCBD0")]
	private void <setScale>b__117_1()
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x10E9A7C", Offset = "0x10E9A7C", VA = "0x10E9A7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBE0", Offset = "0x5CCBE0")]
	private void <setGUIMove>b__118_0()
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x10E9E48", Offset = "0x10E9E48", VA = "0x10E9E48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCBF0", Offset = "0x5CCBF0")]
	private void <setGUIMove>b__118_1()
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x10E9FA8", Offset = "0x10E9FA8", VA = "0x10E9FA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC00", Offset = "0x5CCC00")]
	private void <setGUIMoveMargin>b__119_0()
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x10EA0C4", Offset = "0x10EA0C4", VA = "0x10EA0C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC10", Offset = "0x5CCC10")]
	private void <setGUIMoveMargin>b__119_1()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x10EA160", Offset = "0x10EA160", VA = "0x10EA160")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC20", Offset = "0x5CCC20")]
	private void <setGUIScale>b__120_0()
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x10EA250", Offset = "0x10EA250", VA = "0x10EA250")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC30", Offset = "0x5CCC30")]
	private void <setGUIScale>b__120_1()
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x10EA3A4", Offset = "0x10EA3A4", VA = "0x10EA3A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC40", Offset = "0x5CCC40")]
	private void <setGUIAlpha>b__121_0()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x10EA3E4", Offset = "0x10EA3E4", VA = "0x10EA3E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC50", Offset = "0x5CCC50")]
	private void <setGUIAlpha>b__121_1()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x10EA44C", Offset = "0x10EA44C", VA = "0x10EA44C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC60", Offset = "0x5CCC60")]
	private void <setGUIRotate>b__122_0()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x10EA8B0", Offset = "0x10EA8B0", VA = "0x10EA8B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC70", Offset = "0x5CCC70")]
	private void <setGUIRotate>b__122_1()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x10EA918", Offset = "0x10EA918", VA = "0x10EA918")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC80", Offset = "0x5CCC80")]
	private void <setDelayedSound>b__123_0()
	{
	}
}
[Token(Token = "0x2000012")]
public class LTDescrOptional
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC404", Offset = "0x5CC404")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC414", Offset = "0x5CC414")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC424", Offset = "0x5CC424")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC434", Offset = "0x5CC434")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC444", Offset = "0x5CC444")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC454", Offset = "0x5CC454")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC464", Offset = "0x5CC464")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int initFrameCount;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC474", Offset = "0x5CC474")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC484", Offset = "0x5CC484")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC494", Offset = "0x5CC494")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4A4", Offset = "0x5CC4A4")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4B4", Offset = "0x5CC4B4")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4C4", Offset = "0x5CC4C4")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4D4", Offset = "0x5CC4D4")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4E4", Offset = "0x5CC4E4")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC4F4", Offset = "0x5CC4F4")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC504", Offset = "0x5CC504")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC514", Offset = "0x5CC514")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC524", Offset = "0x5CC524")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC534", Offset = "0x5CC534")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CC544", Offset = "0x5CC544")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x17000014")]
	public Transform toTrans
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10E9564", Offset = "0x10E9564", VA = "0x10E9564")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCC90", Offset = "0x5CCC90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10E1BCC", Offset = "0x10E1BCC", VA = "0x10E1BCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCA0", Offset = "0x5CCCA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public Vector3 point
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x10DD024", Offset = "0x10DD024", VA = "0x10DD024")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCB0", Offset = "0x5CCCB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10E27B8", Offset = "0x10E27B8", VA = "0x10E27B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCC0", Offset = "0x5CCCC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Vector3 axis
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10DD038", Offset = "0x10DD038", VA = "0x10DD038")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCD0", Offset = "0x5CCCD0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x10DA188", Offset = "0x10DA188", VA = "0x10DA188")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCE0", Offset = "0x5CCCE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public float lastVal
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x10E4EB0", Offset = "0x10E4EB0", VA = "0x10E4EB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCCF0", Offset = "0x5CCCF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10E4EC8", Offset = "0x10E4EC8", VA = "0x10E4EC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD00", Offset = "0x5CCD00")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Quaternion origRotation
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x10E4EB8", Offset = "0x10E4EB8", VA = "0x10E4EB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD10", Offset = "0x5CCD10")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x10D7AE0", Offset = "0x10D7AE0", VA = "0x10D7AE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD20", Offset = "0x5CCD20")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public LTBezierPath path
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x10D9A30", Offset = "0x10D9A30", VA = "0x10D9A30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD30", Offset = "0x5CCD30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10E2520", Offset = "0x10E2520", VA = "0x10E2520")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD40", Offset = "0x5CCD40")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public LTSpline spline
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10D9A38", Offset = "0x10D9A38", VA = "0x10D9A38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD50", Offset = "0x5CCD50")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x10E2C60", Offset = "0x10E2C60", VA = "0x10E2C60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD60", Offset = "0x5CCD60")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public LTRect ltRect
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x10DA08C", Offset = "0x10DA08C", VA = "0x10DA08C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD70", Offset = "0x5CCD70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x10E25DC", Offset = "0x10E25DC", VA = "0x10E25DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD80", Offset = "0x5CCD80")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x10EAA54", Offset = "0x10EAA54", VA = "0x10EAA54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCD90", Offset = "0x5CCD90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10E2064", Offset = "0x10E2064", VA = "0x10E2064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDA0", Offset = "0x5CCDA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x10EAA5C", Offset = "0x10EAA5C", VA = "0x10EAA5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDB0", Offset = "0x5CCDB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10E20A4", Offset = "0x10E20A4", VA = "0x10E20A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDC0", Offset = "0x5CCDC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10EAA64", Offset = "0x10EAA64", VA = "0x10EAA64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDD0", Offset = "0x5CCDD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10E20E4", Offset = "0x10E20E4", VA = "0x10E20E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDE0", Offset = "0x5CCDE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10EAA6C", Offset = "0x10EAA6C", VA = "0x10EAA6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCDF0", Offset = "0x5CCDF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x10E2124", Offset = "0x10E2124", VA = "0x10E2124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE00", Offset = "0x5CCE00")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x10EAA74", Offset = "0x10EAA74", VA = "0x10EAA74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE10", Offset = "0x5CCE10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x10E2164", Offset = "0x10E2164", VA = "0x10E2164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE20", Offset = "0x5CCE20")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x10EAA7C", Offset = "0x10EAA7C", VA = "0x10EAA7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE30", Offset = "0x5CCE30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x10E231C", Offset = "0x10E231C", VA = "0x10E231C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE40", Offset = "0x5CCE40")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x10E71EC", Offset = "0x10E71EC", VA = "0x10E71EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE50", Offset = "0x5CCE50")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x10E21A4", Offset = "0x10E21A4", VA = "0x10E21A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE60", Offset = "0x5CCE60")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x10E71F4", Offset = "0x10E71F4", VA = "0x10E71F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE70", Offset = "0x5CCE70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10E21E4", Offset = "0x10E21E4", VA = "0x10E21E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE80", Offset = "0x5CCE80")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Action onComplete
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x10DA09C", Offset = "0x10DA09C", VA = "0x10DA09C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCE90", Offset = "0x5CCE90")]
		get
		{
			return null;
		}
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x10E1F48", Offset = "0x10E1F48", VA = "0x10E1F48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCEA0", Offset = "0x5CCEA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10DA0A4", Offset = "0x10DA0A4", VA = "0x10DA0A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCEB0", Offset = "0x5CCEB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10E1F88", Offset = "0x10E1F88", VA = "0x10E1F88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCEC0", Offset = "0x5CCEC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public object onCompleteParam
	{
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10DA094", Offset = "0x10DA094", VA = "0x10DA094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCED0", Offset = "0x5CCED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10E1FEC", Offset = "0x10E1FEC", VA = "0x10E1FEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCEE0", Offset = "0x5CCEE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public object onUpdateParam
	{
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10E71FC", Offset = "0x10E71FC", VA = "0x10E71FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCEF0", Offset = "0x5CCEF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10E22B8", Offset = "0x10E22B8", VA = "0x10E22B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCF00", Offset = "0x5CCF00")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public Action onStart
	{
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x10D9684", Offset = "0x10D9684", VA = "0x10D9684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCF10", Offset = "0x5CCF10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10E2888", Offset = "0x10E2888", VA = "0x10E2888")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5CCF20", Offset = "0x5CCF20")]
		set
		{
		}
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x10D6384", Offset = "0x10D6384", VA = "0x10D6384")]
	public void reset()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x10D9EBC", Offset = "0x10D9EBC", VA = "0x10D9EBC")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x10D5FB0", Offset = "0x10D5FB0", VA = "0x10D5FB0")]
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
		[Address(RVA = "0x10EEB4C", Offset = "0x10EEB4C", VA = "0x10EEB4C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x10EEB5C", Offset = "0x10EEB5C", VA = "0x10EEB5C")]
	public void reset()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x10EEB70", Offset = "0x10EEB70", VA = "0x10EEB70")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x10EEB90", Offset = "0x10EEB90", VA = "0x10EEB90")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x10EF178", Offset = "0x10EF178", VA = "0x10EF178")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x10EF208", Offset = "0x10EF208", VA = "0x10EF208")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x10EF260", Offset = "0x10EF260", VA = "0x10EF260")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x10EF4C0", Offset = "0x10EF4C0", VA = "0x10EF4C0")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x10EF6CC", Offset = "0x10EF6CC", VA = "0x10EF6CC")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x10EF8A4", Offset = "0x10EF8A4", VA = "0x10EF8A4")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x10EF434", Offset = "0x10EF434", VA = "0x10EF434")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x10EFAB4", Offset = "0x10EFAB4", VA = "0x10EFAB4")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x10EFB10", Offset = "0x10EFB10", VA = "0x10EFB10")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x10EFB40", Offset = "0x10EFB40", VA = "0x10EFB40")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x10EFC3C", Offset = "0x10EFC3C", VA = "0x10EFC3C")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x10EFC40", Offset = "0x10EFC40", VA = "0x10EFC40")]
	public LTSeq()
	{
	}
}
namespace DentedPixel;

[Token(Token = "0x2000014")]
public class LeanDummy
{
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x10D38A0", Offset = "0x10D38A0", VA = "0x10D38A0")]
	public LeanDummy()
	{
	}
}
