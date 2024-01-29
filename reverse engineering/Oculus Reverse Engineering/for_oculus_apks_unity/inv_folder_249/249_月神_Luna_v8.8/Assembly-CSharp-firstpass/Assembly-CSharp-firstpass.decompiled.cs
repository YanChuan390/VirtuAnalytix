using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public interface ILeanTween
{
	[Token(Token = "0x17000001")]
	GameObject tweenEmpty
	{
		[Token(Token = "0x600001C")]
		get;
	}

	[Token(Token = "0x6000001")]
	void removeTween(int i, int uniqueId);

	[Token(Token = "0x6000002")]
	void removeTween(int i);

	[Token(Token = "0x6000003")]
	Vector3[] add(Vector3[] a, Vector3 b);

	[Token(Token = "0x6000004")]
	float closestRot(float from, float to);

	[Token(Token = "0x6000005")]
	void cancelAll();

	[Token(Token = "0x6000006")]
	void cancelAll(bool callComplete);

	[Token(Token = "0x6000007")]
	void cancel(GameObject gameObject);

	[Token(Token = "0x6000008")]
	void cancel(GameObject gameObject, bool callOnComplete);

	[Token(Token = "0x6000009")]
	void cancel(GameObject gameObject, int uniqueId);

	[Token(Token = "0x600000A")]
	void cancel(LTRect ltRect, int uniqueId);

	[Token(Token = "0x600000B")]
	void cancel(int uniqueId);

	[Token(Token = "0x600000C")]
	void cancel(int uniqueId, bool callOnComplete);

	[Token(Token = "0x600000D")]
	LTDescr descr(int uniqueId);

	[Token(Token = "0x600000E")]
	LTDescr description(int uniqueId);

	[Token(Token = "0x600000F")]
	LTDescr[] descriptions([Optional] GameObject gameObject);

	[Token(Token = "0x6000010")]
	void pause(int uniqueId);

	[Token(Token = "0x6000011")]
	void pause(GameObject gameObject);

	[Token(Token = "0x6000012")]
	void pauseAll();

	[Token(Token = "0x6000013")]
	void resumeAll();

	[Token(Token = "0x6000014")]
	void resume(int uniqueId);

	[Token(Token = "0x6000015")]
	void resume(GameObject gameObject);

	[Token(Token = "0x6000016")]
	bool isTweening([Optional] GameObject gameObject);

	[Token(Token = "0x6000017")]
	bool isTweening(int uniqueId);

	[Token(Token = "0x6000018")]
	bool isTweening(LTRect ltRect);

	[Token(Token = "0x6000019")]
	void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform);

	[Token(Token = "0x600001A")]
	LTDescr options(LTDescr seed);

	[Token(Token = "0x600001B")]
	LTDescr options();

	[Token(Token = "0x600001D")]
	LTDescr alpha(GameObject gameObject, float to, float time);

	[Token(Token = "0x600001E")]
	LTDescr alpha(LTRect ltRect, float to, float time);

	[Token(Token = "0x600001F")]
	LTDescr alphaVertex(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000020")]
	LTDescr color(GameObject gameObject, Color to, float time);

	[Token(Token = "0x6000021")]
	LTDescr delayedCall(float delayTime, Action callback);

	[Token(Token = "0x6000022")]
	LTDescr delayedCall(float delayTime, Action<object> callback);

	[Token(Token = "0x6000023")]
	LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback);

	[Token(Token = "0x6000024")]
	LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback);

	[Token(Token = "0x6000025")]
	LTDescr destroyAfter(LTRect rect, float delayTime);

	[Token(Token = "0x6000026")]
	LTDescr move(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x6000027")]
	LTDescr move(GameObject gameObject, Vector2 to, float time);

	[Token(Token = "0x6000028")]
	LTDescr move(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x6000029")]
	LTDescr move(GameObject gameObject, LTBezierPath to, float time);

	[Token(Token = "0x600002A")]
	LTDescr move(GameObject gameObject, LTSpline to, float time);

	[Token(Token = "0x600002B")]
	LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x600002C")]
	LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x600002D")]
	LTDescr move(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x600002E")]
	LTDescr moveMargin(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x600002F")]
	LTDescr moveX(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000030")]
	LTDescr moveY(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000031")]
	LTDescr moveZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000032")]
	LTDescr moveLocal(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x6000033")]
	LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time);

	[Token(Token = "0x6000034")]
	LTDescr moveLocalX(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000035")]
	LTDescr moveLocalY(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000036")]
	LTDescr moveLocalZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000037")]
	LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time);

	[Token(Token = "0x6000038")]
	LTDescr moveLocal(GameObject gameObject, LTSpline to, float time);

	[Token(Token = "0x6000039")]
	LTDescr move(GameObject gameObject, Transform to, float time);

	[Token(Token = "0x600003A")]
	LTDescr rotate(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x600003B")]
	LTDescr rotate(LTRect ltRect, float to, float time);

	[Token(Token = "0x600003C")]
	LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x600003D")]
	LTDescr rotateX(GameObject gameObject, float to, float time);

	[Token(Token = "0x600003E")]
	LTDescr rotateY(GameObject gameObject, float to, float time);

	[Token(Token = "0x600003F")]
	LTDescr rotateZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000040")]
	LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time);

	[Token(Token = "0x6000041")]
	LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time);

	[Token(Token = "0x6000042")]
	LTDescr scale(GameObject gameObject, Vector3 to, float time);

	[Token(Token = "0x6000043")]
	LTDescr scale(LTRect ltRect, Vector2 to, float time);

	[Token(Token = "0x6000044")]
	LTDescr scaleX(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000045")]
	LTDescr scaleY(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000046")]
	LTDescr scaleZ(GameObject gameObject, float to, float time);

	[Token(Token = "0x6000047")]
	LTDescr value(GameObject gameObject, float from, float to, float time);

	[Token(Token = "0x6000048")]
	LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time);

	[Token(Token = "0x6000049")]
	LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time);

	[Token(Token = "0x600004A")]
	LTDescr value(GameObject gameObject, Color from, Color to, float time);

	[Token(Token = "0x600004B")]
	LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time);

	[Token(Token = "0x600004C")]
	LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time);

	[Token(Token = "0x600004D")]
	LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time);

	[Token(Token = "0x600004E")]
	LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time);

	[Token(Token = "0x600004F")]
	LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time);

	[Token(Token = "0x6000050")]
	LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time);

	[Token(Token = "0x6000051")]
	LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume);

	[Token(Token = "0x6000052")]
	LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume);

	[Token(Token = "0x6000053")]
	LTDescr play(RectTransform rectTransform, Sprite[] sprites);

	[Token(Token = "0x6000054")]
	LTDescr textAlpha(RectTransform rectTransform, float to, float time);

	[Token(Token = "0x6000055")]
	LTDescr textColor(RectTransform rectTransform, Color to, float time);

	[Token(Token = "0x6000056")]
	LTDescr move(RectTransform rectTrans, Vector3 to, float time);

	[Token(Token = "0x6000057")]
	LTDescr moveX(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x6000058")]
	LTDescr moveY(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x6000059")]
	LTDescr moveZ(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x600005A")]
	LTDescr rotate(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x600005B")]
	LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time);

	[Token(Token = "0x600005C")]
	LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time);

	[Token(Token = "0x600005D")]
	LTDescr scale(RectTransform rectTrans, Vector3 to, float time);

	[Token(Token = "0x600005E")]
	LTDescr alpha(RectTransform rectTrans, float to, float time);

	[Token(Token = "0x600005F")]
	LTDescr color(RectTransform rectTrans, Color to, float time);
}
[Token(Token = "0x2000003")]
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

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB64134", Offset = "0xB64134", VA = "0xB64134")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB64954", Offset = "0xB64954", VA = "0xB64954")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB649DC", Offset = "0xB649DC", VA = "0xB649DC")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000004")]
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

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xB6348C", Offset = "0xB6348C", VA = "0xB6348C")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB635B0", Offset = "0xB635B0", VA = "0xB635B0")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB64074", Offset = "0xB64074", VA = "0xB64074")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB63688", Offset = "0xB63688", VA = "0xB63688")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB63B0C", Offset = "0xB63B0C", VA = "0xB63B0C")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB64160", Offset = "0xB64160", VA = "0xB64160")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB64164", Offset = "0xB64164", VA = "0xB64164")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xB642D4", Offset = "0xB642D4", VA = "0xB642D4")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB644E0", Offset = "0xB644E0", VA = "0xB644E0")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB64594", Offset = "0xB64594", VA = "0xB64594")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xB64620", Offset = "0xB64620", VA = "0xB64620")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xB643B0", Offset = "0xB643B0", VA = "0xB643B0")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB646E4", Offset = "0xB646E4", VA = "0xB646E4")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB64884", Offset = "0xB64884", VA = "0xB64884")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000005")]
public class LeanAudioOptions
{
	[Token(Token = "0x20000CC")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000667")]
		Sine,
		[Token(Token = "0x4000668")]
		Square,
		[Token(Token = "0x4000669")]
		Sawtooth,
		[Token(Token = "0x400066A")]
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

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB6358C", Offset = "0xB6358C", VA = "0xB6358C")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB64900", Offset = "0xB64900", VA = "0xB64900")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xB64908", Offset = "0xB64908", VA = "0xB64908")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB64910", Offset = "0xB64910", VA = "0xB64910")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB64918", Offset = "0xB64918", VA = "0xB64918")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB64924", Offset = "0xB64924", VA = "0xB64924")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xB64930", Offset = "0xB64930", VA = "0xB64930")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB6493C", Offset = "0xB6493C", VA = "0xB6493C")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB64944", Offset = "0xB64944", VA = "0xB64944")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xB6494C", Offset = "0xB6494C", VA = "0xB6494C")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x20000CD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE70", Offset = "0x73EE70")]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xB659B8", Offset = "0xB659B8", VA = "0xB659B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xB65A24", Offset = "0xB65A24", VA = "0xB65A24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0xB65814", Offset = "0xB65814", VA = "0xB65814")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0xB65850", Offset = "0xB65850", VA = "0xB65850", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0xB65854", Offset = "0xB65854", VA = "0xB65854", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xB659C0", Offset = "0xB659C0", VA = "0xB659C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xB65774", Offset = "0xB65774", VA = "0xB65774")]
	public void Start()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xB657A0", Offset = "0xB657A0", VA = "0xB657A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x744B3C", Offset = "0x744B3C")]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xB65840", Offset = "0xB65840", VA = "0xB65840")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000007")]
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

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xB649E4", Offset = "0xB649E4", VA = "0xB649E4")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xB64A60", Offset = "0xB64A60", VA = "0xB64A60")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xB65600", Offset = "0xB65600", VA = "0xB65600")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xB64FF4", Offset = "0xB64FF4", VA = "0xB64FF4")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xB65670", Offset = "0xB65670", VA = "0xB65670")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xB65128", Offset = "0xB65128", VA = "0xB65128")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xB65188", Offset = "0xB65188", VA = "0xB65188")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xB652FC", Offset = "0xB652FC", VA = "0xB652FC")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xB656E8", Offset = "0xB656E8", VA = "0xB656E8")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000008")]
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
[Token(Token = "0x2000009")]
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
[Token(Token = "0x200000A")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTDescr[] tweens;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] tweensFinished;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static LTDescr tween;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int tweenMaxSearch;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static int maxTweens;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int frameRendered;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static float dtEstimated;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public static float dtManual;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static float dtActual;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static int i;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static int j;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int finishedCnt;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static AnimationCurve punch;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static AnimationCurve shake;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int maxTweenReached;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public static int startSearch;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static LTDescr d;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static GameObject[] goListeners;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static int eventsMaxSearch;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public static int EVENTS_MAX;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000002")]
	public static int maxSearch
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB65DA0", Offset = "0xB65DA0", VA = "0xB65DA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000003")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB65E08", Offset = "0xB65E08", VA = "0xB65E08")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000004")]
	public static int tweensRunning
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB65E70", Offset = "0xB65E70", VA = "0xB65E70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000005")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB69414", Offset = "0xB69414", VA = "0xB69414")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xB65A2C", Offset = "0xB65A2C", VA = "0xB65A2C")]
	public static void init()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xB65A94", Offset = "0xB65A94", VA = "0xB65A94")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xB65F58", Offset = "0xB65F58", VA = "0xB65F58")]
	public static void reset()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xB660EC", Offset = "0xB660EC", VA = "0xB660EC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xB66568", Offset = "0xB66568", VA = "0xB66568")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xB665D8", Offset = "0xB665D8", VA = "0xB665D8")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xB66148", Offset = "0xB66148", VA = "0xB66148")]
	public static void update()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xB4F5F4", Offset = "0xB4F5F4", VA = "0xB4F5F4")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xB66634", Offset = "0xB66634", VA = "0xB66634")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xB669F0", Offset = "0xB669F0", VA = "0xB669F0")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xB5AAB8", Offset = "0xB5AAB8", VA = "0xB5AAB8")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xB66BB4", Offset = "0xB66BB4", VA = "0xB66BB4")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xB66C14", Offset = "0xB66C14", VA = "0xB66C14")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xB66E1C", Offset = "0xB66E1C", VA = "0xB66E1C")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xB66E84", Offset = "0xB66E84", VA = "0xB66E84")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xB670F0", Offset = "0xB670F0", VA = "0xB670F0")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB67178", Offset = "0xB67178", VA = "0xB67178")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xB67430", Offset = "0xB67430", VA = "0xB67430")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xB67568", Offset = "0xB67568", VA = "0xB67568")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xB675D0", Offset = "0xB675D0", VA = "0xB675D0")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xB6776C", Offset = "0xB6776C", VA = "0xB6776C")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xB67A08", Offset = "0xB67A08", VA = "0xB67A08")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xB67A6C", Offset = "0xB67A6C", VA = "0xB67A6C")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xB67CB0", Offset = "0xB67CB0", VA = "0xB67CB0")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x744BA0", Offset = "0x744BA0")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xB67D14", Offset = "0xB67D14", VA = "0xB67D14")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xB67E20", Offset = "0xB67E20", VA = "0xB67E20")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xB67FA8", Offset = "0xB67FA8", VA = "0xB67FA8")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xB680A8", Offset = "0xB680A8", VA = "0xB680A8")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xB6819C", Offset = "0xB6819C", VA = "0xB6819C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x744BD8", Offset = "0x744BD8")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xB68200", Offset = "0xB68200", VA = "0xB68200")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xB68300", Offset = "0xB68300", VA = "0xB68300")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xB6847C", Offset = "0xB6847C", VA = "0xB6847C")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xB686B0", Offset = "0xB686B0", VA = "0xB686B0")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xB68734", Offset = "0xB68734", VA = "0xB68734")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB68868", Offset = "0xB68868", VA = "0xB68868")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB689A4", Offset = "0xB689A4", VA = "0xB689A4")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xB4E3B4", Offset = "0xB4E3B4", VA = "0xB4E3B4")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB69038", Offset = "0xB69038", VA = "0xB69038")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xB690AC", Offset = "0xB690AC", VA = "0xB690AC")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xB6948C", Offset = "0xB6948C", VA = "0xB6948C")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xB69594", Offset = "0xB69594", VA = "0xB69594")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xB696D4", Offset = "0xB696D4", VA = "0xB696D4")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xB697CC", Offset = "0xB697CC", VA = "0xB697CC")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xB698C4", Offset = "0xB698C4", VA = "0xB698C4")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xB699A4", Offset = "0xB699A4", VA = "0xB699A4")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xB69A84", Offset = "0xB69A84", VA = "0xB69A84")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xB69B64", Offset = "0xB69B64", VA = "0xB69B64")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB69C2C", Offset = "0xB69C2C", VA = "0xB69C2C")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xB69D7C", Offset = "0xB69D7C", VA = "0xB69D7C")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xB69EB4", Offset = "0xB69EB4", VA = "0xB69EB4")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xB69FEC", Offset = "0xB69FEC", VA = "0xB69FEC")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xB6A0F8", Offset = "0xB6A0F8", VA = "0xB6A0F8")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB6A204", Offset = "0xB6A204", VA = "0xB6A204")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xB6A308", Offset = "0xB6A308", VA = "0xB6A308")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB6A40C", Offset = "0xB6A40C", VA = "0xB6A40C")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB6A518", Offset = "0xB6A518", VA = "0xB6A518")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB6A5C8", Offset = "0xB6A5C8", VA = "0xB6A5C8")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xB6A6B8", Offset = "0xB6A6B8", VA = "0xB6A6B8")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB6A874", Offset = "0xB6A874", VA = "0xB6A874")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xB6A970", Offset = "0xB6A970", VA = "0xB6A970")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xB6AA6C", Offset = "0xB6AA6C", VA = "0xB6AA6C")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xB6ABA4", Offset = "0xB6ABA4", VA = "0xB6ABA4")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xB6ACA0", Offset = "0xB6ACA0", VA = "0xB6ACA0")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xB6ADD8", Offset = "0xB6ADD8", VA = "0xB6ADD8")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xB6AEEC", Offset = "0xB6AEEC", VA = "0xB6AEEC")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB6B000", Offset = "0xB6B000", VA = "0xB6B000")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB6B0C8", Offset = "0xB6B0C8", VA = "0xB6B0C8")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xB6B190", Offset = "0xB6B190", VA = "0xB6B190")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB6B258", Offset = "0xB6B258", VA = "0xB6B258")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xB6B308", Offset = "0xB6B308", VA = "0xB6B308")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xB6B4C4", Offset = "0xB6B4C4", VA = "0xB6B4C4")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xB6B58C", Offset = "0xB6B58C", VA = "0xB6B58C")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xB6B654", Offset = "0xB6B654", VA = "0xB6B654")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xB6B71C", Offset = "0xB6B71C", VA = "0xB6B71C")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xB6B818", Offset = "0xB6B818", VA = "0xB6B818")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xB6B914", Offset = "0xB6B914", VA = "0xB6B914")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xB6BA0C", Offset = "0xB6BA0C", VA = "0xB6BA0C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xB6BABC", Offset = "0xB6BABC", VA = "0xB6BABC")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xB6BBAC", Offset = "0xB6BBAC", VA = "0xB6BBAC")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xB6BC5C", Offset = "0xB6BC5C", VA = "0xB6BC5C")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xB6BD24", Offset = "0xB6BD24", VA = "0xB6BD24")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xB6BDEC", Offset = "0xB6BDEC", VA = "0xB6BDEC")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xB6BEB4", Offset = "0xB6BEB4", VA = "0xB6BEB4")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xB6BFB0", Offset = "0xB6BFB0", VA = "0xB6BFB0")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xB6C0B0", Offset = "0xB6C0B0", VA = "0xB6C0B0")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xB6C160", Offset = "0xB6C160", VA = "0xB6C160")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xB6C274", Offset = "0xB6C274", VA = "0xB6C274")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xB6C33C", Offset = "0xB6C33C", VA = "0xB6C33C")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xB6C404", Offset = "0xB6C404", VA = "0xB6C404")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xB6C4CC", Offset = "0xB6C4CC", VA = "0xB6C4CC")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xB6C5DC", Offset = "0xB6C5DC", VA = "0xB6C5DC")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xB6C6F0", Offset = "0xB6C6F0", VA = "0xB6C6F0")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xB6C844", Offset = "0xB6C844", VA = "0xB6C844")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xB6C928", Offset = "0xB6C928", VA = "0xB6C928")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xB6CAAC", Offset = "0xB6CAAC", VA = "0xB6CAAC")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xB6CC14", Offset = "0xB6CC14", VA = "0xB6CC14")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xB6CD7C", Offset = "0xB6CD7C", VA = "0xB6CD7C")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xB6CF48", Offset = "0xB6CF48", VA = "0xB6CF48")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xB6D114", Offset = "0xB6D114", VA = "0xB6D114")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xB6D28C", Offset = "0xB6D28C", VA = "0xB6D28C")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xB6D3B4", Offset = "0xB6D3B4", VA = "0xB6D3B4")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xB6D518", Offset = "0xB6D518", VA = "0xB6D518")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xB6D648", Offset = "0xB6D648", VA = "0xB6D648")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xB6D774", Offset = "0xB6D774", VA = "0xB6D774")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xB6D850", Offset = "0xB6D850", VA = "0xB6D850")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xB6D940", Offset = "0xB6D940", VA = "0xB6D940")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xB6DA30", Offset = "0xB6DA30", VA = "0xB6DA30")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xB6DB20", Offset = "0xB6DB20", VA = "0xB6DB20")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xB6DC48", Offset = "0xB6DC48", VA = "0xB6DC48")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xB6DD5C", Offset = "0xB6DD5C", VA = "0xB6DD5C")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xB6DE78", Offset = "0xB6DE78", VA = "0xB6DE78")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xB6DF94", Offset = "0xB6DF94", VA = "0xB6DF94")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xB6E070", Offset = "0xB6E070", VA = "0xB6E070")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xB6E184", Offset = "0xB6E184", VA = "0xB6E184")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xB6E274", Offset = "0xB6E274", VA = "0xB6E274")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xB6E3B8", Offset = "0xB6E3B8", VA = "0xB6E3B8")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xB6E40C", Offset = "0xB6E40C", VA = "0xB6E40C")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xB6E518", Offset = "0xB6E518", VA = "0xB6E518")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xB6E530", Offset = "0xB6E530", VA = "0xB6E530")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xB6E540", Offset = "0xB6E540", VA = "0xB6E540")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xB6E590", Offset = "0xB6E590", VA = "0xB6E590")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xB6E6CC", Offset = "0xB6E6CC", VA = "0xB6E6CC")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xB6E754", Offset = "0xB6E754", VA = "0xB6E754")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xB6E820", Offset = "0xB6E820", VA = "0xB6E820")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xB6E924", Offset = "0xB6E924", VA = "0xB6E924")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xB6E938", Offset = "0xB6E938", VA = "0xB6E938")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xB6E954", Offset = "0xB6E954", VA = "0xB6E954")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xB6E9A8", Offset = "0xB6E9A8", VA = "0xB6E9A8")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xB6E9DC", Offset = "0xB6E9DC", VA = "0xB6E9DC")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xB6E9F4", Offset = "0xB6E9F4", VA = "0xB6E9F4")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xB6EA1C", Offset = "0xB6EA1C", VA = "0xB6EA1C")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xB6EA74", Offset = "0xB6EA74", VA = "0xB6EA74")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xB6EA90", Offset = "0xB6EA90", VA = "0xB6EA90")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xB6EAB8", Offset = "0xB6EAB8", VA = "0xB6EAB8")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xB6EB14", Offset = "0xB6EB14", VA = "0xB6EB14")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xB6EB34", Offset = "0xB6EB34", VA = "0xB6EB34")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xB6EB64", Offset = "0xB6EB64", VA = "0xB6EB64")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xB6EBCC", Offset = "0xB6EBCC", VA = "0xB6EBCC")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xB6EC64", Offset = "0xB6EC64", VA = "0xB6EC64")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xB6ECF8", Offset = "0xB6ECF8", VA = "0xB6ECF8")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xB6ED9C", Offset = "0xB6ED9C", VA = "0xB6ED9C")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xB6EE34", Offset = "0xB6EE34", VA = "0xB6EE34")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xB6EECC", Offset = "0xB6EECC", VA = "0xB6EECC")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xB6EFBC", Offset = "0xB6EFBC", VA = "0xB6EFBC")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xB6F068", Offset = "0xB6F068", VA = "0xB6F068")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xB6F114", Offset = "0xB6F114", VA = "0xB6F114")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xB57CF4", Offset = "0xB57CF4", VA = "0xB57CF4")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xB57750", Offset = "0xB57750", VA = "0xB57750")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xB6F20C", Offset = "0xB6F20C", VA = "0xB6F20C")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xB6F2E4", Offset = "0xB6F2E4", VA = "0xB6F2E4")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xB6F318", Offset = "0xB6F318", VA = "0xB6F318")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xB6F358", Offset = "0xB6F358", VA = "0xB6F358")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xB582D4", Offset = "0xB582D4", VA = "0xB582D4")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xB58510", Offset = "0xB58510", VA = "0xB58510")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xB5873C", Offset = "0xB5873C", VA = "0xB5873C")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xB6F3F0", Offset = "0xB6F3F0", VA = "0xB6F3F0")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xB6F468", Offset = "0xB6F468", VA = "0xB6F468")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xB6F8FC", Offset = "0xB6F8FC", VA = "0xB6F8FC")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xB6F974", Offset = "0xB6F974", VA = "0xB6F974")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xB6FBA8", Offset = "0xB6FBA8", VA = "0xB6FBA8")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xB6FC10", Offset = "0xB6FC10", VA = "0xB6FC10")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xB6FE38", Offset = "0xB6FE38", VA = "0xB6FE38")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200000B")]
public class LTUtility
{
	[Token(Token = "0x6000130")]
	[Address(RVA = "0xB59658", Offset = "0xB59658", VA = "0xB59658")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xB63484", Offset = "0xB63484", VA = "0xB63484")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200000C")]
public class LTBezier
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xB4DAC8", Offset = "0xB4DAC8", VA = "0xB4DAC8")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xB4DF1C", Offset = "0xB4DF1C", VA = "0xB4DF1C")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xB4DE44", Offset = "0xB4DE44", VA = "0xB4DE44")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xB4E028", Offset = "0xB4E028", VA = "0xB4E028")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000D")]
public class LTBezierPath
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x17000006")]
	public float distance
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xB4E474", Offset = "0xB4E474", VA = "0xB4E474")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xB4E04C", Offset = "0xB4E04C", VA = "0xB4E04C")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xB4E054", Offset = "0xB4E054", VA = "0xB4E054")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xB4E084", Offset = "0xB4E084", VA = "0xB4E084")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xB4E47C", Offset = "0xB4E47C", VA = "0xB4E47C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xB4E550", Offset = "0xB4E550", VA = "0xB4E550")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xB4E6D8", Offset = "0xB4E6D8", VA = "0xB4E6D8")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xB4E884", Offset = "0xB4E884", VA = "0xB4E884")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xB4E928", Offset = "0xB4E928", VA = "0xB4E928")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xB4E9CC", Offset = "0xB4E9CC", VA = "0xB4E9CC")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xB4EA70", Offset = "0xB4EA70", VA = "0xB4EA70")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xB4EB54", Offset = "0xB4EB54", VA = "0xB4EB54")]
	public float getRationInOneRange(float ratio)
	{
		return default(float);
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xB4EC00", Offset = "0xB4EC00", VA = "0xB4EC00")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class LTSpline
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xB5971C", Offset = "0xB5971C", VA = "0xB5971C")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xB62350", Offset = "0xB62350", VA = "0xB62350")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xB61FA8", Offset = "0xB61FA8", VA = "0xB61FA8")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xB627E4", Offset = "0xB627E4", VA = "0xB627E4")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xB6239C", Offset = "0xB6239C", VA = "0xB6239C")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xB629A8", Offset = "0xB629A8", VA = "0xB629A8")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xB5A354", Offset = "0xB5A354", VA = "0xB5A354")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xB5A128", Offset = "0xB5A128", VA = "0xB5A128")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xB5A504", Offset = "0xB5A504", VA = "0xB5A504")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xB5A2B0", Offset = "0xB5A2B0", VA = "0xB5A2B0")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB62AF4", Offset = "0xB62AF4", VA = "0xB62AF4")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB5A700", Offset = "0xB5A700", VA = "0xB5A700")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xB62B98", Offset = "0xB62B98", VA = "0xB62B98")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xB62C6C", Offset = "0xB62C6C", VA = "0xB62C6C")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xB62D3C", Offset = "0xB62D3C", VA = "0xB62D3C")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xB62EA8", Offset = "0xB62EA8", VA = "0xB62EA8")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xB630F0", Offset = "0xB630F0", VA = "0xB630F0")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xB63104", Offset = "0xB63104", VA = "0xB63104")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xB632E8", Offset = "0xB632E8", VA = "0xB632E8")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200000F")]
public class LTRect
{
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000007")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0xB608F8", Offset = "0xB608F8", VA = "0xB608F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000008")]
	public int id
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xB61074", Offset = "0xB61074", VA = "0xB61074")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000009")]
	public float x
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB61BDC", Offset = "0xB61BDC", VA = "0xB61BDC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xB61BE8", Offset = "0xB61BE8", VA = "0xB61BE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public float y
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xB61BF4", Offset = "0xB61BF4", VA = "0xB61BF4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xB61C00", Offset = "0xB61C00", VA = "0xB61C00")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float width
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xB61C0C", Offset = "0xB61C0C", VA = "0xB61C0C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xB61C18", Offset = "0xB61C18", VA = "0xB61C18")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float height
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xB61C24", Offset = "0xB61C24", VA = "0xB61C24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xB61C30", Offset = "0xB61C30", VA = "0xB61C30")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public Rect rect
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB5EB00", Offset = "0xB5EB00", VA = "0xB5EB00")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB61C3C", Offset = "0xB61C3C", VA = "0xB61C3C")]
		set
		{
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xB61778", Offset = "0xB61778", VA = "0xB61778")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xB59320", Offset = "0xB59320", VA = "0xB59320")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xB618D4", Offset = "0xB618D4", VA = "0xB618D4")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xB619C4", Offset = "0xB619C4", VA = "0xB619C4")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xB61AC4", Offset = "0xB61AC4", VA = "0xB61AC4")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xB61080", Offset = "0xB61080", VA = "0xB61080")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0xB61850", Offset = "0xB61850", VA = "0xB61850")]
	public void reset()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xB5F18C", Offset = "0xB5F18C", VA = "0xB5F18C")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xB61C48", Offset = "0xB61C48", VA = "0xB61C48")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xB61C50", Offset = "0xB61C50", VA = "0xB61C50")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xB61C5C", Offset = "0xB61C5C", VA = "0xB61C5C")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xB61C70", Offset = "0xB61C70", VA = "0xB61C70")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xB61C78", Offset = "0xB61C78", VA = "0xB61C78")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xB61C80", Offset = "0xB61C80", VA = "0xB61C80")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xB61C94", Offset = "0xB61C94", VA = "0xB61C94")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xB61D10", Offset = "0xB61D10", VA = "0xB61D10")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xB61D1C", Offset = "0xB61D1C", VA = "0xB61D1C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000010")]
public class LTEvent
{
	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xB5F6FC", Offset = "0xB5F6FC", VA = "0xB5F6FC")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000011")]
public class LTGUI
{
	[Token(Token = "0x20000CE")]
	public enum Element_Type
	{
		[Token(Token = "0x4000670")]
		Texture,
		[Token(Token = "0x4000671")]
		Label
	}

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xB5F738", Offset = "0xB5F738", VA = "0xB5F738")]
	public static void init()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xB5F808", Offset = "0xB5F808", VA = "0xB5F808")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xB5F990", Offset = "0xB5F990", VA = "0xB5F990")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xB5FB24", Offset = "0xB5FB24", VA = "0xB5FB24")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xB6069C", Offset = "0xB6069C", VA = "0xB6069C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xB6077C", Offset = "0xB6077C", VA = "0xB6077C")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xB60908", Offset = "0xB60908", VA = "0xB60908")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xB60A0C", Offset = "0xB60A0C", VA = "0xB60A0C")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xB60ACC", Offset = "0xB60ACC", VA = "0xB60ACC")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xB60F28", Offset = "0xB60F28", VA = "0xB60F28")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xB60FE8", Offset = "0xB60FE8", VA = "0xB60FE8")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xB60B5C", Offset = "0xB60B5C", VA = "0xB60B5C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xB61088", Offset = "0xB61088", VA = "0xB61088")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xB613C0", Offset = "0xB613C0", VA = "0xB613C0")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xB61600", Offset = "0xB61600", VA = "0xB61600")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xB614E4", Offset = "0xB614E4", VA = "0xB614E4")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xB616D4", Offset = "0xB616D4", VA = "0xB616D4")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000012")]
public class LTDescrOptional
{
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFA0", Offset = "0x73EFA0")]
	private Transform <toTrans>k__BackingField;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFB0", Offset = "0x73EFB0")]
	private Vector3 <point>k__BackingField;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFC0", Offset = "0x73EFC0")]
	private Vector3 <axis>k__BackingField;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFD0", Offset = "0x73EFD0")]
	private float <lastVal>k__BackingField;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFE0", Offset = "0x73EFE0")]
	private Quaternion <origRotation>k__BackingField;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EFF0", Offset = "0x73EFF0")]
	private LTBezierPath <path>k__BackingField;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F000", Offset = "0x73F000")]
	private LTSpline <spline>k__BackingField;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F010", Offset = "0x73F010")]
	private LTRect <ltRect>k__BackingField;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F020", Offset = "0x73F020")]
	private Action<float> <onUpdateFloat>k__BackingField;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F030", Offset = "0x73F030")]
	private Action<float, float> <onUpdateFloatRatio>k__BackingField;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F040", Offset = "0x73F040")]
	private Action<float, object> <onUpdateFloatObject>k__BackingField;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F050", Offset = "0x73F050")]
	private Action<Vector2> <onUpdateVector2>k__BackingField;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F060", Offset = "0x73F060")]
	private Action<Vector3> <onUpdateVector3>k__BackingField;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F070", Offset = "0x73F070")]
	private Action<Vector3, object> <onUpdateVector3Object>k__BackingField;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F080", Offset = "0x73F080")]
	private Action<Color> <onUpdateColor>k__BackingField;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F090", Offset = "0x73F090")]
	private Action<Color, object> <onUpdateColorObject>k__BackingField;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0A0", Offset = "0x73F0A0")]
	private Action <onComplete>k__BackingField;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0B0", Offset = "0x73F0B0")]
	private Action<object> <onCompleteObject>k__BackingField;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0C0", Offset = "0x73F0C0")]
	private object <onCompleteParam>k__BackingField;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0D0", Offset = "0x73F0D0")]
	private object <onUpdateParam>k__BackingField;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0E0", Offset = "0x73F0E0")]
	private Action <onStart>k__BackingField;

	[Token(Token = "0x1700000E")]
	public Transform toTrans
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0xB5F594", Offset = "0xB5F594", VA = "0xB5F594")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C10", Offset = "0x744C10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xB5F59C", Offset = "0xB5F59C", VA = "0xB5F59C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C20", Offset = "0x744C20")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Vector3 point
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xB5F5A4", Offset = "0xB5F5A4", VA = "0xB5F5A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C30", Offset = "0x744C30")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600018A")]
		[Address(RVA = "0xB5F5B0", Offset = "0xB5F5B0", VA = "0xB5F5B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C40", Offset = "0x744C40")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Vector3 axis
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB5F5BC", Offset = "0xB5F5BC", VA = "0xB5F5BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C50", Offset = "0x744C50")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB5F5C8", Offset = "0xB5F5C8", VA = "0xB5F5C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C60", Offset = "0x744C60")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public float lastVal
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0xB5F5D4", Offset = "0xB5F5D4", VA = "0xB5F5D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C70", Offset = "0x744C70")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB5F5DC", Offset = "0xB5F5DC", VA = "0xB5F5DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C80", Offset = "0x744C80")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public Quaternion origRotation
	{
		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB5F5E4", Offset = "0xB5F5E4", VA = "0xB5F5E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744C90", Offset = "0x744C90")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB5F5F0", Offset = "0xB5F5F0", VA = "0xB5F5F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CA0", Offset = "0x744CA0")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public LTBezierPath path
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB5F5FC", Offset = "0xB5F5FC", VA = "0xB5F5FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CB0", Offset = "0x744CB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB5F604", Offset = "0xB5F604", VA = "0xB5F604")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CC0", Offset = "0x744CC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public LTSpline spline
	{
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB5F60C", Offset = "0xB5F60C", VA = "0xB5F60C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CD0", Offset = "0x744CD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB5F614", Offset = "0xB5F614", VA = "0xB5F614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CE0", Offset = "0x744CE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public LTRect ltRect
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB5F61C", Offset = "0xB5F61C", VA = "0xB5F61C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744CF0", Offset = "0x744CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB5F624", Offset = "0xB5F624", VA = "0xB5F624")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D00", Offset = "0x744D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB5F62C", Offset = "0xB5F62C", VA = "0xB5F62C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D10", Offset = "0x744D10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB5F634", Offset = "0xB5F634", VA = "0xB5F634")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D20", Offset = "0x744D20")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB5F63C", Offset = "0xB5F63C", VA = "0xB5F63C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D30", Offset = "0x744D30")]
		get
		{
			return null;
		}
		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB5F644", Offset = "0xB5F644", VA = "0xB5F644")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D40", Offset = "0x744D40")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0xB5F64C", Offset = "0xB5F64C", VA = "0xB5F64C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D50", Offset = "0x744D50")]
		get
		{
			return null;
		}
		[Token(Token = "0x600019C")]
		[Address(RVA = "0xB5F654", Offset = "0xB5F654", VA = "0xB5F654")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D60", Offset = "0x744D60")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x600019D")]
		[Address(RVA = "0xB5F65C", Offset = "0xB5F65C", VA = "0xB5F65C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D70", Offset = "0x744D70")]
		get
		{
			return null;
		}
		[Token(Token = "0x600019E")]
		[Address(RVA = "0xB5F664", Offset = "0xB5F664", VA = "0xB5F664")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D80", Offset = "0x744D80")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xB5F66C", Offset = "0xB5F66C", VA = "0xB5F66C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744D90", Offset = "0x744D90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xB5F674", Offset = "0xB5F674", VA = "0xB5F674")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DA0", Offset = "0x744DA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xB5F67C", Offset = "0xB5F67C", VA = "0xB5F67C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DB0", Offset = "0x744DB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xB5F684", Offset = "0xB5F684", VA = "0xB5F684")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DC0", Offset = "0x744DC0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xB5F68C", Offset = "0xB5F68C", VA = "0xB5F68C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DD0", Offset = "0x744DD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xB5F694", Offset = "0xB5F694", VA = "0xB5F694")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DE0", Offset = "0x744DE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB5F69C", Offset = "0xB5F69C", VA = "0xB5F69C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744DF0", Offset = "0x744DF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xB5F6A4", Offset = "0xB5F6A4", VA = "0xB5F6A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E00", Offset = "0x744E00")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Action onComplete
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB5F6AC", Offset = "0xB5F6AC", VA = "0xB5F6AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E10", Offset = "0x744E10")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xB5F6B4", Offset = "0xB5F6B4", VA = "0xB5F6B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E20", Offset = "0x744E20")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xB5F6BC", Offset = "0xB5F6BC", VA = "0xB5F6BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E30", Offset = "0x744E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xB5F6C4", Offset = "0xB5F6C4", VA = "0xB5F6C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E40", Offset = "0x744E40")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public object onCompleteParam
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB5F6CC", Offset = "0xB5F6CC", VA = "0xB5F6CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E50", Offset = "0x744E50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB5F6D4", Offset = "0xB5F6D4", VA = "0xB5F6D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E60", Offset = "0x744E60")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public object onUpdateParam
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB5F6DC", Offset = "0xB5F6DC", VA = "0xB5F6DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E70", Offset = "0x744E70")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xB5F6E4", Offset = "0xB5F6E4", VA = "0xB5F6E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E80", Offset = "0x744E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Action onStart
	{
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB5F6EC", Offset = "0xB5F6EC", VA = "0xB5F6EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744E90", Offset = "0x744E90")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xB5F6F4", Offset = "0xB5F6F4", VA = "0xB5F6F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744EA0", Offset = "0x744EA0")]
		set
		{
		}
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xB4F860", Offset = "0xB4F860", VA = "0xB4F860")]
	public void reset()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xB52570", Offset = "0xB52570", VA = "0xB52570")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xB4F504", Offset = "0xB4F504", VA = "0xB4F504")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000013")]
public class LTDescr
{
	[Token(Token = "0x20000CF")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x20000D0")]
	public delegate void ActionMethodDelegate();

	[Serializable]
	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE80", Offset = "0x73EE80")]
	private sealed class <>c
	{
		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ActionMethodDelegate <>9__111_0;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static ActionMethodDelegate <>9__112_0;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0xB5F4E0", Offset = "0xB5F4E0", VA = "0xB5F4E0")]
		public <>c()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0xB5F4E8", Offset = "0xB5F4E8", VA = "0xB5F4E8")]
		internal void <setCallback>b__111_0()
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0xB5F4EC", Offset = "0xB5F4EC", VA = "0xB5F4EC")]
		internal void <setValue3>b__112_0()
		{
		}
	}

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public LTRect ltRect;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal Vector3 fromInternal;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	internal Vector3 toInternal;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal Vector3 diff;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TweenAction type;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public LeanTweenType tweenType;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LeanTweenType loopType;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool hasUpdateCallback;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F0F0", Offset = "0x73F0F0")]
	private ActionMethodDelegate <easeInternal>k__BackingField;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F100", Offset = "0x73F100")]
	private ActionMethodDelegate <initInternal>k__BackingField;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RectTransform rectTransform;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text uiText;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Image uiImage;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RawImage rawImage;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Sprite[] sprites;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public LTDescrOptional _optional;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static uint global_counter;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float val;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float dt;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static Vector3 newVect;

	[Token(Token = "0x17000023")]
	public Vector3 from
	{
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xB4ECDC", Offset = "0xB4ECDC", VA = "0xB4ECDC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xB4ECE8", Offset = "0xB4ECE8", VA = "0xB4ECE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Vector3 to
	{
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xB4ECF4", Offset = "0xB4ECF4", VA = "0xB4ECF4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xB4ED00", Offset = "0xB4ED00", VA = "0xB4ED00")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xB4ED0C", Offset = "0xB4ED0C", VA = "0xB4ED0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744EB0", Offset = "0x744EB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xB4ED14", Offset = "0xB4ED14", VA = "0xB4ED14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744EC0", Offset = "0x744EC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xB4ED1C", Offset = "0xB4ED1C", VA = "0xB4ED1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744ED0", Offset = "0x744ED0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xB4ED24", Offset = "0xB4ED24", VA = "0xB4ED24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744EE0", Offset = "0x744EE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public int uniqueId
	{
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xB4F5E4", Offset = "0xB4F5E4", VA = "0xB4F5E4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000028")]
	public int id
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB4F48C", Offset = "0xB4F48C", VA = "0xB4F48C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB4F6DC", Offset = "0xB4F6DC", VA = "0xB4F6DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xB4F6E4", Offset = "0xB4F6E4", VA = "0xB4F6E4")]
		set
		{
		}
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xB4ED2C", Offset = "0xB4ED2C", VA = "0xB4ED2C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xB4F49C", Offset = "0xB4F49C", VA = "0xB4F49C")]
	public LTDescr()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xB4F50C", Offset = "0xB4F50C", VA = "0xB4F50C")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x744EF0", Offset = "0x744EF0")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xB4F6E8", Offset = "0xB4F6E8", VA = "0xB4F6E8")]
	public void reset()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xB4F8F4", Offset = "0xB4F8F4", VA = "0xB4F8F4")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xB4F99C", Offset = "0xB4F99C", VA = "0xB4F99C")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xB4FA38", Offset = "0xB4FA38", VA = "0xB4FA38")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xB4FAD4", Offset = "0xB4FAD4", VA = "0xB4FAD4")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xB4FB70", Offset = "0xB4FB70", VA = "0xB4FB70")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xB4FC0C", Offset = "0xB4FC0C", VA = "0xB4FC0C")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xB4FCA8", Offset = "0xB4FCA8", VA = "0xB4FCA8")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xB4FCB0", Offset = "0xB4FCB0", VA = "0xB4FCB0")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xB4FD4C", Offset = "0xB4FD4C", VA = "0xB4FD4C")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xB4FDE8", Offset = "0xB4FDE8", VA = "0xB4FDE8")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xB4FE84", Offset = "0xB4FE84", VA = "0xB4FE84")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xB4FF20", Offset = "0xB4FF20", VA = "0xB4FF20")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xB4FFBC", Offset = "0xB4FFBC", VA = "0xB4FFBC")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xB50058", Offset = "0xB50058", VA = "0xB50058")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xB500F4", Offset = "0xB500F4", VA = "0xB500F4")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xB50190", Offset = "0xB50190", VA = "0xB50190")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xB5022C", Offset = "0xB5022C", VA = "0xB5022C")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xB502C8", Offset = "0xB502C8", VA = "0xB502C8")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xB50364", Offset = "0xB50364", VA = "0xB50364")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xB50400", Offset = "0xB50400", VA = "0xB50400")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xB5049C", Offset = "0xB5049C", VA = "0xB5049C")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xB50538", Offset = "0xB50538", VA = "0xB50538")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xB505D4", Offset = "0xB505D4", VA = "0xB505D4")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xB50670", Offset = "0xB50670", VA = "0xB50670")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xB5070C", Offset = "0xB5070C", VA = "0xB5070C")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xB507A8", Offset = "0xB507A8", VA = "0xB507A8")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xB50844", Offset = "0xB50844", VA = "0xB50844")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xB508E0", Offset = "0xB508E0", VA = "0xB508E0")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xB5097C", Offset = "0xB5097C", VA = "0xB5097C")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xB50A18", Offset = "0xB50A18", VA = "0xB50A18")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xB50AB4", Offset = "0xB50AB4", VA = "0xB50AB4")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xB50B50", Offset = "0xB50B50", VA = "0xB50B50")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xB50BA0", Offset = "0xB50BA0", VA = "0xB50BA0")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xB50C3C", Offset = "0xB50C3C", VA = "0xB50C3C")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xB50CD8", Offset = "0xB50CD8", VA = "0xB50CD8")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xB50D74", Offset = "0xB50D74", VA = "0xB50D74")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xB50E10", Offset = "0xB50E10", VA = "0xB50E10")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xB50EAC", Offset = "0xB50EAC", VA = "0xB50EAC")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xB50F48", Offset = "0xB50F48", VA = "0xB50F48")]
	private void callback()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xB5121C", Offset = "0xB5121C", VA = "0xB5121C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xB51328", Offset = "0xB51328", VA = "0xB51328")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xB51434", Offset = "0xB51434", VA = "0xB51434")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xB514D0", Offset = "0xB514D0", VA = "0xB514D0")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xB5156C", Offset = "0xB5156C", VA = "0xB5156C")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xB51608", Offset = "0xB51608", VA = "0xB51608")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xB516A4", Offset = "0xB516A4", VA = "0xB516A4")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xB51740", Offset = "0xB51740", VA = "0xB51740")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xB517DC", Offset = "0xB517DC", VA = "0xB517DC")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xB51878", Offset = "0xB51878", VA = "0xB51878")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xB51914", Offset = "0xB51914", VA = "0xB51914")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xB519B0", Offset = "0xB519B0", VA = "0xB519B0")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xB51A4C", Offset = "0xB51A4C", VA = "0xB51A4C")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xB51AE8", Offset = "0xB51AE8", VA = "0xB51AE8")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xB51B84", Offset = "0xB51B84", VA = "0xB51B84")]
	private void init()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xB52044", Offset = "0xB52044", VA = "0xB52044")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xB5216C", Offset = "0xB5216C", VA = "0xB5216C")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xB52190", Offset = "0xB52190", VA = "0xB52190")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xB51F48", Offset = "0xB51F48", VA = "0xB51F48")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xB5275C", Offset = "0xB5275C", VA = "0xB5275C")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xB52840", Offset = "0xB52840", VA = "0xB52840")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xB52C90", Offset = "0xB52C90", VA = "0xB52C90")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xB5302C", Offset = "0xB5302C", VA = "0xB5302C")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xB5340C", Offset = "0xB5340C", VA = "0xB5340C")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xB537B0", Offset = "0xB537B0", VA = "0xB537B0")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xB53B74", Offset = "0xB53B74", VA = "0xB53B74")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xB53F50", Offset = "0xB53F50", VA = "0xB53F50")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xB54290", Offset = "0xB54290", VA = "0xB54290")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xB54610", Offset = "0xB54610", VA = "0xB54610")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xB54730", Offset = "0xB54730", VA = "0xB54730")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xB54748", Offset = "0xB54748", VA = "0xB54748")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xB54754", Offset = "0xB54754", VA = "0xB54754")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xB54778", Offset = "0xB54778", VA = "0xB54778")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xB54780", Offset = "0xB54780", VA = "0xB54780")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xB548BC", Offset = "0xB548BC", VA = "0xB548BC")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xB558D4", Offset = "0xB558D4", VA = "0xB558D4")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xB549AC", Offset = "0xB549AC", VA = "0xB549AC")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xB54934", Offset = "0xB54934", VA = "0xB54934")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xB54A24", Offset = "0xB54A24", VA = "0xB54A24")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xB54A9C", Offset = "0xB54A9C", VA = "0xB54A9C")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xB54B14", Offset = "0xB54B14", VA = "0xB54B14")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xB54B8C", Offset = "0xB54B8C", VA = "0xB54B8C")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xB54C04", Offset = "0xB54C04", VA = "0xB54C04")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xB54C7C", Offset = "0xB54C7C", VA = "0xB54C7C")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xB54CF4", Offset = "0xB54CF4", VA = "0xB54CF4")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xB54D6C", Offset = "0xB54D6C", VA = "0xB54D6C")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xB54DE4", Offset = "0xB54DE4", VA = "0xB54DE4")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xB54E5C", Offset = "0xB54E5C", VA = "0xB54E5C")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xB54ED4", Offset = "0xB54ED4", VA = "0xB54ED4")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xB54F4C", Offset = "0xB54F4C", VA = "0xB54F4C")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xB54FC4", Offset = "0xB54FC4", VA = "0xB54FC4")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xB5503C", Offset = "0xB5503C", VA = "0xB5503C")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xB550B4", Offset = "0xB550B4", VA = "0xB550B4")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xB5512C", Offset = "0xB5512C", VA = "0xB5512C")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xB551A4", Offset = "0xB551A4", VA = "0xB551A4")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xB5521C", Offset = "0xB5521C", VA = "0xB5521C")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xB55294", Offset = "0xB55294", VA = "0xB55294")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xB5530C", Offset = "0xB5530C", VA = "0xB5530C")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xB55384", Offset = "0xB55384", VA = "0xB55384")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xB553FC", Offset = "0xB553FC", VA = "0xB553FC")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xB55474", Offset = "0xB55474", VA = "0xB55474")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xB554EC", Offset = "0xB554EC", VA = "0xB554EC")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xB55564", Offset = "0xB55564", VA = "0xB55564")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xB555DC", Offset = "0xB555DC", VA = "0xB555DC")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xB55654", Offset = "0xB55654", VA = "0xB55654")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xB556CC", Offset = "0xB556CC", VA = "0xB556CC")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xB55744", Offset = "0xB55744", VA = "0xB55744")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xB5580C", Offset = "0xB5580C", VA = "0xB5580C")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xB5594C", Offset = "0xB5594C", VA = "0xB5594C")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xB55A40", Offset = "0xB55A40", VA = "0xB55A40")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xB55B88", Offset = "0xB55B88", VA = "0xB55B88")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xB55C5C", Offset = "0xB55C5C", VA = "0xB55C5C")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xB55D58", Offset = "0xB55D58", VA = "0xB55D58")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xB55E28", Offset = "0xB55E28", VA = "0xB55E28")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xB55FE8", Offset = "0xB55FE8", VA = "0xB55FE8")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xB560C0", Offset = "0xB560C0", VA = "0xB560C0")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xB561B8", Offset = "0xB561B8", VA = "0xB561B8")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xB56318", Offset = "0xB56318", VA = "0xB56318")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xB563FC", Offset = "0xB563FC", VA = "0xB563FC")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xB564F8", Offset = "0xB564F8", VA = "0xB564F8")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xB566C0", Offset = "0xB566C0", VA = "0xB566C0")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xB567B0", Offset = "0xB567B0", VA = "0xB567B0")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xB568B0", Offset = "0xB568B0", VA = "0xB568B0")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xB56A20", Offset = "0xB56A20", VA = "0xB56A20")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xB56B5C", Offset = "0xB56B5C", VA = "0xB56B5C")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xB56C88", Offset = "0xB56C88", VA = "0xB56C88")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xB56D98", Offset = "0xB56D98", VA = "0xB56D98")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xB56EA0", Offset = "0xB56EA0", VA = "0xB56EA0")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xB56FA8", Offset = "0xB56FA8", VA = "0xB56FA8")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xB571A8", Offset = "0xB571A8", VA = "0xB571A8")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xB572C4", Offset = "0xB572C4", VA = "0xB572C4")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xB573F4", Offset = "0xB573F4", VA = "0xB573F4")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xB575D0", Offset = "0xB575D0", VA = "0xB575D0")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xB57820", Offset = "0xB57820", VA = "0xB57820")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xB57A7C", Offset = "0xB57A7C", VA = "0xB57A7C")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xB57D8C", Offset = "0xB57D8C", VA = "0xB57D8C")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xB57EBC", Offset = "0xB57EBC", VA = "0xB57EBC")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xB57FD8", Offset = "0xB57FD8", VA = "0xB57FD8")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xB581CC", Offset = "0xB581CC", VA = "0xB581CC")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xB58408", Offset = "0xB58408", VA = "0xB58408")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xB58634", Offset = "0xB58634", VA = "0xB58634")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xB588FC", Offset = "0xB588FC", VA = "0xB588FC")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xB58904", Offset = "0xB58904", VA = "0xB58904")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xB5890C", Offset = "0xB5890C", VA = "0xB5890C")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xB58914", Offset = "0xB58914", VA = "0xB58914")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xB589AC", Offset = "0xB589AC", VA = "0xB589AC")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xB58A74", Offset = "0xB58A74", VA = "0xB58A74")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xB58A94", Offset = "0xB58A94", VA = "0xB58A94")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xB58B90", Offset = "0xB58B90", VA = "0xB58B90")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xB58BE0", Offset = "0xB58BE0", VA = "0xB58BE0")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xB58BEC", Offset = "0xB58BEC", VA = "0xB58BEC")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xB58BF8", Offset = "0xB58BF8", VA = "0xB58BF8")]
	public LTDescr setId(uint id)
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xB58C7C", Offset = "0xB58C7C", VA = "0xB58C7C")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xB58C98", Offset = "0xB58C98", VA = "0xB58C98")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xB58CCC", Offset = "0xB58CCC", VA = "0xB58CCC")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xB58D20", Offset = "0xB58D20", VA = "0xB58D20")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xB58D28", Offset = "0xB58D28", VA = "0xB58D28")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xB58D38", Offset = "0xB58D38", VA = "0xB58D38")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xB58D48", Offset = "0xB58D48", VA = "0xB58D48")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xB58D58", Offset = "0xB58D58", VA = "0xB58D58")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xB58D68", Offset = "0xB58D68", VA = "0xB58D68")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xB58D78", Offset = "0xB58D78", VA = "0xB58D78")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xB58D84", Offset = "0xB58D84", VA = "0xB58D84")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xB58DA4", Offset = "0xB58DA4", VA = "0xB58DA4")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xB58DAC", Offset = "0xB58DAC", VA = "0xB58DAC")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xB58DCC", Offset = "0xB58DCC", VA = "0xB58DCC")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xB58DF8", Offset = "0xB58DF8", VA = "0xB58DF8")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xB58E20", Offset = "0xB58E20", VA = "0xB58E20")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xB58E48", Offset = "0xB58E48", VA = "0xB58E48")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xB58E84", Offset = "0xB58E84", VA = "0xB58E84")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xB58EAC", Offset = "0xB58EAC", VA = "0xB58EAC")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xB58ED4", Offset = "0xB58ED4", VA = "0xB58ED4")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xB58EFC", Offset = "0xB58EFC", VA = "0xB58EFC")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xB58F24", Offset = "0xB58F24", VA = "0xB58F24")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xB58F4C", Offset = "0xB58F4C", VA = "0xB58F4C")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xB58F74", Offset = "0xB58F74", VA = "0xB58F74")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xB58F9C", Offset = "0xB58F9C", VA = "0xB58F9C")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xB58FC4", Offset = "0xB58FC4", VA = "0xB58FC4")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xB58FEC", Offset = "0xB58FEC", VA = "0xB58FEC")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xB59014", Offset = "0xB59014", VA = "0xB59014")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xB59050", Offset = "0xB59050", VA = "0xB59050")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xB5908C", Offset = "0xB5908C", VA = "0xB5908C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xB590C8", Offset = "0xB590C8", VA = "0xB590C8")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xB59104", Offset = "0xB59104", VA = "0xB59104")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xB59124", Offset = "0xB59124", VA = "0xB59124")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xB591EC", Offset = "0xB591EC", VA = "0xB591EC")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0xB59258", Offset = "0xB59258", VA = "0xB59258")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0xB59278", Offset = "0xB59278", VA = "0xB59278")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0xB593DC", Offset = "0xB593DC", VA = "0xB593DC")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0xB593FC", Offset = "0xB593FC", VA = "0xB593FC")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0xB59420", Offset = "0xB59420", VA = "0xB59420")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0xB5942C", Offset = "0xB5942C", VA = "0xB5942C")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0xB58D14", Offset = "0xB58D14", VA = "0xB58D14")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0xB5944C", Offset = "0xB5944C", VA = "0xB5944C")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xB59458", Offset = "0xB59458", VA = "0xB59458")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xB59460", Offset = "0xB59460", VA = "0xB59460")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xB59468", Offset = "0xB59468", VA = "0xB59468")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xB59494", Offset = "0xB59494", VA = "0xB59494")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xB594B4", Offset = "0xB594B4", VA = "0xB594B4")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xB59758", Offset = "0xB59758", VA = "0xB59758")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xB59768", Offset = "0xB59768", VA = "0xB59768")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F28", Offset = "0x744F28")]
	private void <setMoveX>b__72_0()
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xB5979C", Offset = "0xB5979C", VA = "0xB5979C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F38", Offset = "0x744F38")]
	private void <setMoveX>b__72_1()
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xB59840", Offset = "0xB59840", VA = "0xB59840")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F48", Offset = "0x744F48")]
	private void <setMoveY>b__73_0()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xB59874", Offset = "0xB59874", VA = "0xB59874")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F58", Offset = "0x744F58")]
	private void <setMoveY>b__73_1()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xB59910", Offset = "0xB59910", VA = "0xB59910")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F68", Offset = "0x744F68")]
	private void <setMoveZ>b__74_0()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xB59944", Offset = "0xB59944", VA = "0xB59944")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F78", Offset = "0x744F78")]
	private void <setMoveZ>b__74_1()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xB599E4", Offset = "0xB599E4", VA = "0xB599E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F88", Offset = "0x744F88")]
	private void <setMoveLocalX>b__75_0()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xB59A18", Offset = "0xB59A18", VA = "0xB59A18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744F98", Offset = "0x744F98")]
	private void <setMoveLocalX>b__75_1()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xB59ABC", Offset = "0xB59ABC", VA = "0xB59ABC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FA8", Offset = "0x744FA8")]
	private void <setMoveLocalY>b__76_0()
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xB59AF0", Offset = "0xB59AF0", VA = "0xB59AF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FB8", Offset = "0x744FB8")]
	private void <setMoveLocalY>b__76_1()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xB59B8C", Offset = "0xB59B8C", VA = "0xB59B8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FC8", Offset = "0x744FC8")]
	private void <setMoveLocalZ>b__77_0()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xB59BC0", Offset = "0xB59BC0", VA = "0xB59BC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FD8", Offset = "0x744FD8")]
	private void <setMoveLocalZ>b__77_1()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xB59C60", Offset = "0xB59C60", VA = "0xB59C60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FE8", Offset = "0x744FE8")]
	private void <setMoveCurved>b__79_0()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xB59DF8", Offset = "0xB59DF8", VA = "0xB59DF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x744FF8", Offset = "0x744FF8")]
	private void <setMoveCurvedLocal>b__80_0()
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xB59F90", Offset = "0xB59F90", VA = "0xB59F90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745008", Offset = "0x745008")]
	private void <setMoveSpline>b__81_0()
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xB5A36C", Offset = "0xB5A36C", VA = "0xB5A36C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745018", Offset = "0x745018")]
	private void <setMoveSplineLocal>b__82_0()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xB5A7A4", Offset = "0xB5A7A4", VA = "0xB5A7A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745028", Offset = "0x745028")]
	private void <setScaleX>b__83_0()
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xB5A7D8", Offset = "0xB5A7D8", VA = "0xB5A7D8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745038", Offset = "0x745038")]
	private void <setScaleX>b__83_1()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xB5A87C", Offset = "0xB5A87C", VA = "0xB5A87C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745048", Offset = "0x745048")]
	private void <setScaleY>b__84_0()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xB5A8B0", Offset = "0xB5A8B0", VA = "0xB5A8B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745058", Offset = "0x745058")]
	private void <setScaleY>b__84_1()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xB5A94C", Offset = "0xB5A94C", VA = "0xB5A94C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745068", Offset = "0x745068")]
	private void <setScaleZ>b__85_0()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xB5A980", Offset = "0xB5A980", VA = "0xB5A980")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745078", Offset = "0x745078")]
	private void <setScaleZ>b__85_1()
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xB5AA20", Offset = "0xB5AA20", VA = "0xB5AA20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745088", Offset = "0x745088")]
	private void <setRotateX>b__86_0()
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xB5AB7C", Offset = "0xB5AB7C", VA = "0xB5AB7C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745098", Offset = "0x745098")]
	private void <setRotateX>b__86_1()
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xB5AC20", Offset = "0xB5AC20", VA = "0xB5AC20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450A8", Offset = "0x7450A8")]
	private void <setRotateY>b__87_0()
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xB5ACB8", Offset = "0xB5ACB8", VA = "0xB5ACB8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450B8", Offset = "0x7450B8")]
	private void <setRotateY>b__87_1()
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xB5AD54", Offset = "0xB5AD54", VA = "0xB5AD54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450C8", Offset = "0x7450C8")]
	private void <setRotateZ>b__88_0()
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xB5ADEC", Offset = "0xB5ADEC", VA = "0xB5ADEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450D8", Offset = "0x7450D8")]
	private void <setRotateZ>b__88_1()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xB5AE8C", Offset = "0xB5AE8C", VA = "0xB5AE8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450E8", Offset = "0x7450E8")]
	private void <setRotateAround>b__89_0()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xB5AED8", Offset = "0xB5AED8", VA = "0xB5AED8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7450F8", Offset = "0x7450F8")]
	private void <setRotateAround>b__89_1()
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xB5B10C", Offset = "0xB5B10C", VA = "0xB5B10C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745108", Offset = "0x745108")]
	private void <setRotateAroundLocal>b__90_0()
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xB5B158", Offset = "0xB5B158", VA = "0xB5B158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745118", Offset = "0x745118")]
	private void <setRotateAroundLocal>b__90_1()
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xB5B400", Offset = "0xB5B400", VA = "0xB5B400")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745128", Offset = "0x745128")]
	private void <setAlpha>b__91_0()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xB5B9B0", Offset = "0xB5B9B0", VA = "0xB5B9B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745138", Offset = "0x745138")]
	private void <setAlpha>b__91_2()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xB5BB84", Offset = "0xB5BB84", VA = "0xB5BB84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745148", Offset = "0x745148")]
	private void <setAlpha>b__91_1()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xB5BD70", Offset = "0xB5BD70", VA = "0xB5BD70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745158", Offset = "0x745158")]
	private void <setTextAlpha>b__92_0()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xB5BE38", Offset = "0xB5BE38", VA = "0xB5BE38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745168", Offset = "0x745168")]
	private void <setTextAlpha>b__92_1()
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xB5BECC", Offset = "0xB5BECC", VA = "0xB5BECC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745178", Offset = "0x745178")]
	private void <setAlphaVertex>b__93_0()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xB5BF68", Offset = "0xB5BF68", VA = "0xB5BF68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745188", Offset = "0x745188")]
	private void <setAlphaVertex>b__93_1()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xB5C1F4", Offset = "0xB5C1F4", VA = "0xB5C1F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745198", Offset = "0x745198")]
	private void <setColor>b__94_0()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xB5C790", Offset = "0xB5C790", VA = "0xB5C790")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451A8", Offset = "0x7451A8")]
	private void <setColor>b__94_1()
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xB5CA2C", Offset = "0xB5CA2C", VA = "0xB5CA2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451B8", Offset = "0x7451B8")]
	private void <setCallbackColor>b__95_0()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xB5CA80", Offset = "0xB5CA80", VA = "0xB5CA80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451C8", Offset = "0x7451C8")]
	private void <setCallbackColor>b__95_1()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xB5CD1C", Offset = "0xB5CD1C", VA = "0xB5CD1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451D8", Offset = "0x7451D8")]
	private void <setTextColor>b__96_0()
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xB5CDE8", Offset = "0xB5CDE8", VA = "0xB5CDE8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451E8", Offset = "0x7451E8")]
	private void <setTextColor>b__96_1()
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xB5CF8C", Offset = "0xB5CF8C", VA = "0xB5CF8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7451F8", Offset = "0x7451F8")]
	private void <setCanvasAlpha>b__97_0()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xB5D0C0", Offset = "0xB5D0C0", VA = "0xB5D0C0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745208", Offset = "0x745208")]
	private void <setCanvasAlpha>b__97_1()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xB5D2F4", Offset = "0xB5D2F4", VA = "0xB5D2F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745218", Offset = "0x745218")]
	private void <setCanvasGroupAlpha>b__98_0()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xB5D36C", Offset = "0xB5D36C", VA = "0xB5D36C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745228", Offset = "0x745228")]
	private void <setCanvasGroupAlpha>b__98_1()
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xB5D3F0", Offset = "0xB5D3F0", VA = "0xB5D3F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745238", Offset = "0x745238")]
	private void <setCanvasColor>b__99_0()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xB5D524", Offset = "0xB5D524", VA = "0xB5D524")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745248", Offset = "0x745248")]
	private void <setCanvasColor>b__99_1()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xB5D748", Offset = "0xB5D748", VA = "0xB5D748")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745258", Offset = "0x745258")]
	private void <setCanvasMoveX>b__100_0()
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xB5D77C", Offset = "0xB5D77C", VA = "0xB5D77C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745268", Offset = "0x745268")]
	private void <setCanvasMoveX>b__100_1()
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xB5D810", Offset = "0xB5D810", VA = "0xB5D810")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745278", Offset = "0x745278")]
	private void <setCanvasMoveY>b__101_0()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xB5D844", Offset = "0xB5D844", VA = "0xB5D844")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745288", Offset = "0x745288")]
	private void <setCanvasMoveY>b__101_1()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xB5D8DC", Offset = "0xB5D8DC", VA = "0xB5D8DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745298", Offset = "0x745298")]
	private void <setCanvasMoveZ>b__102_0()
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xB5D910", Offset = "0xB5D910", VA = "0xB5D910")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452A8", Offset = "0x7452A8")]
	private void <setCanvasMoveZ>b__102_1()
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xB5D9A8", Offset = "0xB5D9A8", VA = "0xB5D9A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452B8", Offset = "0x7452B8")]
	private void <setCanvasRotateAround>b__104_0()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xB5DBB0", Offset = "0xB5DBB0", VA = "0xB5DBB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452C8", Offset = "0x7452C8")]
	private void <setCanvasRotateAroundLocal>b__105_0()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xB5DE18", Offset = "0xB5DE18", VA = "0xB5DE18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452D8", Offset = "0x7452D8")]
	private void <setCanvasPlaySprite>b__106_0()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xB5DE88", Offset = "0xB5DE88", VA = "0xB5DE88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452E8", Offset = "0x7452E8")]
	private void <setCanvasPlaySprite>b__106_1()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xB5E014", Offset = "0xB5E014", VA = "0xB5E014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7452F8", Offset = "0x7452F8")]
	private void <setCanvasMove>b__107_0()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xB5E04C", Offset = "0xB5E04C", VA = "0xB5E04C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745308", Offset = "0x745308")]
	private void <setCanvasMove>b__107_1()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xB5E090", Offset = "0xB5E090", VA = "0xB5E090")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745318", Offset = "0x745318")]
	private void <setCanvasScale>b__108_0()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xB5E0C8", Offset = "0xB5E0C8", VA = "0xB5E0C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745328", Offset = "0x745328")]
	private void <setCanvasScale>b__108_1()
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xB5E10C", Offset = "0xB5E10C", VA = "0xB5E10C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745338", Offset = "0x745338")]
	private void <setCanvasSizeDelta>b__109_0()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xB5E1A8", Offset = "0xB5E1A8", VA = "0xB5E1A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745348", Offset = "0x745348")]
	private void <setCanvasSizeDelta>b__109_1()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xB5E260", Offset = "0xB5E260", VA = "0xB5E260")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745358", Offset = "0x745358")]
	private void <setMove>b__113_0()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xB5E298", Offset = "0xB5E298", VA = "0xB5E298")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745368", Offset = "0x745368")]
	private void <setMove>b__113_1()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xB5E358", Offset = "0xB5E358", VA = "0xB5E358")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745378", Offset = "0x745378")]
	private void <setMoveLocal>b__114_0()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xB5E390", Offset = "0xB5E390", VA = "0xB5E390")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745388", Offset = "0x745388")]
	private void <setMoveLocal>b__114_1()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xB5E450", Offset = "0xB5E450", VA = "0xB5E450")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745398", Offset = "0x745398")]
	private void <setMoveToTransform>b__115_0()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xB5E488", Offset = "0xB5E488", VA = "0xB5E488")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453A8", Offset = "0x7453A8")]
	private void <setMoveToTransform>b__115_1()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xB5E5DC", Offset = "0xB5E5DC", VA = "0xB5E5DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453B8", Offset = "0x7453B8")]
	private void <setRotate>b__116_0()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xB5E6D4", Offset = "0xB5E6D4", VA = "0xB5E6D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453C8", Offset = "0x7453C8")]
	private void <setRotate>b__116_1()
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xB5E794", Offset = "0xB5E794", VA = "0xB5E794")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453D8", Offset = "0x7453D8")]
	private void <setRotateLocal>b__117_0()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xB5E88C", Offset = "0xB5E88C", VA = "0xB5E88C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453E8", Offset = "0x7453E8")]
	private void <setRotateLocal>b__117_1()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xB5E94C", Offset = "0xB5E94C", VA = "0xB5E94C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7453F8", Offset = "0x7453F8")]
	private void <setScale>b__118_0()
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xB5E984", Offset = "0xB5E984", VA = "0xB5E984")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745408", Offset = "0x745408")]
	private void <setScale>b__118_1()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xB5EA44", Offset = "0xB5EA44", VA = "0xB5EA44")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745418", Offset = "0x745418")]
	private void <setGUIMove>b__119_0()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xB5ED1C", Offset = "0xB5ED1C", VA = "0xB5ED1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745428", Offset = "0x745428")]
	private void <setGUIMove>b__119_1()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xB5EE04", Offset = "0xB5EE04", VA = "0xB5EE04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745438", Offset = "0x745438")]
	private void <setGUIMoveMargin>b__120_0()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xB5EEAC", Offset = "0xB5EEAC", VA = "0xB5EEAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745448", Offset = "0x745448")]
	private void <setGUIMoveMargin>b__120_1()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xB5EF08", Offset = "0xB5EF08", VA = "0xB5EF08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745458", Offset = "0x745458")]
	private void <setGUIScale>b__121_0()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xB5EFC4", Offset = "0xB5EFC4", VA = "0xB5EFC4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745468", Offset = "0x745468")]
	private void <setGUIScale>b__121_1()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xB5F0AC", Offset = "0xB5F0AC", VA = "0xB5F0AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745478", Offset = "0x745478")]
	private void <setGUIAlpha>b__122_0()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xB5F0DC", Offset = "0xB5F0DC", VA = "0xB5F0DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745488", Offset = "0x745488")]
	private void <setGUIAlpha>b__122_1()
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xB5F11C", Offset = "0xB5F11C", VA = "0xB5F11C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745498", Offset = "0x745498")]
	private void <setGUIRotate>b__123_0()
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xB5F430", Offset = "0xB5F430", VA = "0xB5F430")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7454A8", Offset = "0x7454A8")]
	private void <setGUIRotate>b__123_1()
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xB5F470", Offset = "0xB5F470", VA = "0xB5F470")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7454B8", Offset = "0x7454B8")]
	private void <setDelayedSound>b__124_0()
	{
	}
}
[Token(Token = "0x2000014")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xB4D500", Offset = "0xB4D500", VA = "0xB4D500")]
	public void Start()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xB4D6BC", Offset = "0xB4D6BC", VA = "0xB4D6BC", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xB4D9D0", Offset = "0xB4D9D0", VA = "0xB4D9D0")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000015")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xB4D9E0", Offset = "0xB4D9E0", VA = "0xB4D9E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xB4DAC0", Offset = "0xB4DAC0", VA = "0xB4DAC0")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000016")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public enum Mode
		{
			[Token(Token = "0x4000676")]
			Trigger,
			[Token(Token = "0x4000677")]
			Replace,
			[Token(Token = "0x4000678")]
			Activate,
			[Token(Token = "0x4000679")]
			Enable,
			[Token(Token = "0x400067A")]
			Animate,
			[Token(Token = "0x400067B")]
			Deactivate
		}

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xDA5278", Offset = "0xDA5278", VA = "0xDA5278")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xDA56E4", Offset = "0xDA56E4", VA = "0xDA56E4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xDA56E8", Offset = "0xDA56E8", VA = "0xDA56E8")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x6000887")]
			[Address(RVA = "0xDA6074", Offset = "0xDA6074", VA = "0xDA6074")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class ReplacementList
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x6000888")]
			[Address(RVA = "0xDA607C", Offset = "0xDA607C", VA = "0xDA607C")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xDA5700", Offset = "0xDA5700", VA = "0xDA5700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xDA606C", Offset = "0xDA606C", VA = "0xDA606C")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Vector3andSpace
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000889")]
			[Address(RVA = "0xDA624C", Offset = "0xDA624C", VA = "0xDA624C")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xDA60DC", Offset = "0xDA60DC", VA = "0xDA60DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xDA6104", Offset = "0xDA6104", VA = "0xDA6104")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xDA6244", Offset = "0xDA6244", VA = "0xDA6244")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class CameraRefocus
	{
		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xDA625C", Offset = "0xDA625C", VA = "0xDA625C")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xDA62BC", Offset = "0xDA62BC", VA = "0xDA62BC")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xDA62C4", Offset = "0xDA62C4", VA = "0xDA62C4")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xDA62CC", Offset = "0xDA62CC", VA = "0xDA62CC")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xDA642C", Offset = "0xDA642C", VA = "0xDA642C")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xDA6480", Offset = "0xDA6480", VA = "0xDA6480")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xDA6528", Offset = "0xDA6528", VA = "0xDA6528")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xDA6648", Offset = "0xDA6648", VA = "0xDA6648")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EE90", Offset = "0x73EE90")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600088D")]
				[Address(RVA = "0xDA6FAC", Offset = "0xDA6FAC", VA = "0xDA6FAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600088F")]
				[Address(RVA = "0xDA7018", Offset = "0xDA7018", VA = "0xDA7018", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0xDA6D30", Offset = "0xDA6D30", VA = "0xDA6D30")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0xDA6D64", Offset = "0xDA6D64", VA = "0xDA6D64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0xDA6D68", Offset = "0xDA6D68", VA = "0xDA6D68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0xDA6FB4", Offset = "0xDA6FB4", VA = "0xDA6FB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012D")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400012E")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400012F")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000130")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000131")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000132")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xDA6894", Offset = "0xDA6894", VA = "0xDA6894")]
		private void Update()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xDA6CAC", Offset = "0xDA6CAC", VA = "0xDA6CAC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7454C8", Offset = "0x7454C8")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xDA6BFC", Offset = "0xDA6BFC", VA = "0xDA6BFC")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xDA6D5C", Offset = "0xDA6D5C", VA = "0xDA6D5C")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xDA7020", Offset = "0xDA7020", VA = "0xDA7020")]
		private void Start()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xDA7054", Offset = "0xDA7054", VA = "0xDA7054")]
		private void Update()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xDA72D4", Offset = "0xDA72D4", VA = "0xDA72D4")]
		public DynamicShadowSettings()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xDA7ABC", Offset = "0xDA7ABC", VA = "0xDA7ABC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xDA7BA0", Offset = "0xDA7BA0", VA = "0xDA7BA0")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001E")]
	public class FOVKick
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEA0", Offset = "0x73EEA0")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000893")]
				[Address(RVA = "0xDA78EC", Offset = "0xDA78EC", VA = "0xDA78EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000895")]
				[Address(RVA = "0xDA7958", Offset = "0xDA7958", VA = "0xDA7958", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0xDA74AC", Offset = "0xDA74AC", VA = "0xDA74AC")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0xDA7784", Offset = "0xDA7784", VA = "0xDA7784", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0xDA7788", Offset = "0xDA7788", VA = "0xDA7788", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0xDA78F4", Offset = "0xDA78F4", VA = "0xDA78F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEB0", Offset = "0x73EEB0")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000095")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000899")]
				[Address(RVA = "0xDA7710", Offset = "0xDA7710", VA = "0xDA7710", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600089B")]
				[Address(RVA = "0xDA777C", Offset = "0xDA777C", VA = "0xDA777C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0xDA754C", Offset = "0xDA754C", VA = "0xDA754C")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0xDA7594", Offset = "0xDA7594", VA = "0xDA7594", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0xDA7598", Offset = "0xDA7598", VA = "0xDA7598", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0xDA7718", Offset = "0xDA7718", VA = "0xDA7718", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xDA7308", Offset = "0xDA7308", VA = "0xDA7308")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xDA734C", Offset = "0xDA734C", VA = "0xDA734C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xDA7430", Offset = "0xDA7430", VA = "0xDA7430")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xDA7438", Offset = "0xDA7438", VA = "0xDA7438")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x74552C", Offset = "0x74552C")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xDA74D8", Offset = "0xDA74D8", VA = "0xDA74D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745590", Offset = "0x745590")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xDA7578", Offset = "0xDA7578", VA = "0xDA7578")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C0D8", Offset = "0x73C0D8")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x400014B")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xDA7960", Offset = "0xDA7960", VA = "0xDA7960")]
		private void Start()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xDA79CC", Offset = "0xDA79CC", VA = "0xDA79CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xDA7AB4", Offset = "0xDA7AB4", VA = "0xDA7AB4")]
		public FPSCounter()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000020")]
	public class LerpControlledBob
	{
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEC0", Offset = "0x73EEC0")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089F")]
				[Address(RVA = "0xDA7E98", Offset = "0xDA7E98", VA = "0xDA7E98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A1")]
				[Address(RVA = "0xDA7F04", Offset = "0xDA7F04", VA = "0xDA7F04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0xDA7C7C", Offset = "0xDA7C7C", VA = "0xDA7C7C")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0xDA7CB0", Offset = "0xDA7CB0", VA = "0xDA7CB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0xDA7CB4", Offset = "0xDA7CB4", VA = "0xDA7CB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xDA7EA0", Offset = "0xDA7EA0", VA = "0xDA7EA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xDA7C00", Offset = "0xDA7C00", VA = "0xDA7C00")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xDA7C08", Offset = "0xDA7C08", VA = "0xDA7C08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7455F4", Offset = "0x7455F4")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xDA7CA8", Offset = "0xDA7CA8", VA = "0xDA7CA8")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EED0", Offset = "0x73EED0")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000099")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0xDA8318", Offset = "0xDA8318", VA = "0xDA8318", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A7")]
				[Address(RVA = "0xDA8384", Offset = "0xDA8384", VA = "0xDA8384", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xDA80A8", Offset = "0xDA80A8", VA = "0xDA80A8")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xDA80DC", Offset = "0xDA80DC", VA = "0xDA80DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xDA80E0", Offset = "0xDA80E0", VA = "0xDA80E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xDA8320", Offset = "0xDA8320", VA = "0xDA8320", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xDA7F0C", Offset = "0xDA7F0C", VA = "0xDA7F0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xDA7FF8", Offset = "0xDA7FF8", VA = "0xDA7FF8")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xDA8024", Offset = "0xDA8024", VA = "0xDA8024")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745658", Offset = "0x745658")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xDA80D4", Offset = "0xDA80D4", VA = "0xDA80D4")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEE0", Offset = "0x73EEE0")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400069A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0xDA878C", Offset = "0xDA878C", VA = "0xDA878C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AD")]
				[Address(RVA = "0xDA87F8", Offset = "0xDA87F8", VA = "0xDA87F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xDA8400", Offset = "0xDA8400", VA = "0xDA8400")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xDA844C", Offset = "0xDA844C", VA = "0xDA844C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xDA8450", Offset = "0xDA8450", VA = "0xDA8450", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xDA8794", Offset = "0xDA8794", VA = "0xDA8794", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xDA838C", Offset = "0xDA838C", VA = "0xDA838C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7456BC", Offset = "0x7456BC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xDA842C", Offset = "0xDA842C", VA = "0xDA842C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xDA8438", Offset = "0xDA8438", VA = "0xDA8438")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x20000DC")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400069E")]
			Standalone,
			[Token(Token = "0x400069F")]
			Mobile
		}

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xDA8800", Offset = "0xDA8800", VA = "0xDA8800")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xDA8804", Offset = "0xDA8804", VA = "0xDA8804")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xDA8820", Offset = "0xDA8820", VA = "0xDA8820")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xDA8BB4", Offset = "0xDA8BB4", VA = "0xDA8BB4")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x600031B")]
		[Address(RVA = "0xDA8C2C", Offset = "0xDA8C2C", VA = "0xDA8C2C")]
		private void Start()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0xDA8C30", Offset = "0xDA8C30", VA = "0xDA8C30")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xDA8F68", Offset = "0xDA8F68", VA = "0xDA8F68")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		public enum Action
		{
			[Token(Token = "0x40006A1")]
			Activate,
			[Token(Token = "0x40006A2")]
			Deactivate,
			[Token(Token = "0x40006A3")]
			Destroy,
			[Token(Token = "0x40006A4")]
			ReloadLevel,
			[Token(Token = "0x40006A5")]
			Call
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		public class Entry
		{
			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xDA96DC", Offset = "0xDA96DC", VA = "0xDA96DC")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public class Entries
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xDA92F8", Offset = "0xDA92F8", VA = "0xDA92F8")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EEF0", Offset = "0x73EEF0")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0xDA93D0", Offset = "0xDA93D0", VA = "0xDA93D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B5")]
				[Address(RVA = "0xDA943C", Offset = "0xDA943C", VA = "0xDA943C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xDA920C", Offset = "0xDA920C", VA = "0xDA920C")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xDA9300", Offset = "0xDA9300", VA = "0xDA9300", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xDA9304", Offset = "0xDA9304", VA = "0xDA9304", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xDA93D8", Offset = "0xDA93D8", VA = "0xDA93D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF00", Offset = "0x73EF00")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700009F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008B9")]
				[Address(RVA = "0xDA9514", Offset = "0xDA9514", VA = "0xDA9514", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008BB")]
				[Address(RVA = "0xDA9580", Offset = "0xDA9580", VA = "0xDA9580", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0xDA9238", Offset = "0xDA9238", VA = "0xDA9238")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xDA9444", Offset = "0xDA9444", VA = "0xDA9444", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0xDA9448", Offset = "0xDA9448", VA = "0xDA9448", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xDA951C", Offset = "0xDA951C", VA = "0xDA951C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF10", Offset = "0x73EF10")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x170000A1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008BF")]
				[Address(RVA = "0xDA9668", Offset = "0xDA9668", VA = "0xDA9668", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C1")]
				[Address(RVA = "0xDA96D4", Offset = "0xDA96D4", VA = "0xDA96D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xDA9264", Offset = "0xDA9264", VA = "0xDA9264")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xDA9588", Offset = "0xDA9588", VA = "0xDA9588", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0xDA958C", Offset = "0xDA958C", VA = "0xDA958C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0xDA9670", Offset = "0xDA9670", VA = "0xDA9670", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xDA8F7C", Offset = "0xDA8F7C", VA = "0xDA8F7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xDA90B0", Offset = "0xDA90B0", VA = "0xDA90B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745720", Offset = "0x745720")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xDA9124", Offset = "0xDA9124", VA = "0xDA9124")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745784", Offset = "0x745784")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xDA9198", Offset = "0xDA9198", VA = "0xDA9198")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7457E8", Offset = "0x7457E8")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xDA9290", Offset = "0xDA9290", VA = "0xDA9290")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xDA96E4", Offset = "0xDA96E4", VA = "0xDA96E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xDA973C", Offset = "0xDA973C", VA = "0xDA973C")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xDA97DC", Offset = "0xDA97DC", VA = "0xDA97DC")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E3")]
		public class WaypointList
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xDAA660", Offset = "0xDAA660", VA = "0xDAA660")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		public struct RoutePoint
		{
			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x64E514", Offset = "0x64E514", VA = "0x64E514")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F1F0", Offset = "0x73F1F0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x1700002A")]
		public float Length
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0xDA97EC", Offset = "0xDA97EC", VA = "0xDA97EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74584C", Offset = "0x74584C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0xDA97F4", Offset = "0xDA97F4", VA = "0xDA97F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74585C", Offset = "0x74585C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0xDA97FC", Offset = "0xDA97FC", VA = "0xDA97FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xDA981C", Offset = "0xDA981C", VA = "0xDA981C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xDA9B64", Offset = "0xDA9B64", VA = "0xDA9B64")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xDA9C74", Offset = "0xDA9C74", VA = "0xDA9C74")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xDA9FFC", Offset = "0xDA9FFC", VA = "0xDA9FFC")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xDA987C", Offset = "0xDA987C", VA = "0xDA987C")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xDAA358", Offset = "0xDAA358", VA = "0xDAA358")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xDAA5E4", Offset = "0xDAA5E4", VA = "0xDAA5E4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xDAA360", Offset = "0xDAA360", VA = "0xDAA360")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xDAA5EC", Offset = "0xDAA5EC", VA = "0xDAA5EC")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40006B8")]
			SmoothAlongRoute,
			[Token(Token = "0x40006B9")]
			PointToPoint
		}

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F270", Offset = "0x73F270")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F280", Offset = "0x73F280")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F290", Offset = "0x73F290")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x1700002C")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xDAA6C0", Offset = "0xDAA6C0", VA = "0xDAA6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74586C", Offset = "0x74586C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000333")]
			[Address(RVA = "0xDAA6D4", Offset = "0xDAA6D4", VA = "0xDAA6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74587C", Offset = "0x74587C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000334")]
			[Address(RVA = "0xDAA6E8", Offset = "0xDAA6E8", VA = "0xDAA6E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74588C", Offset = "0x74588C")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xDAA6FC", Offset = "0xDAA6FC", VA = "0xDAA6FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74589C", Offset = "0x74589C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x6000336")]
			[Address(RVA = "0xDAA710", Offset = "0xDAA710", VA = "0xDAA710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7458AC", Offset = "0x7458AC")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xDAA724", Offset = "0xDAA724", VA = "0xDAA724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7458BC", Offset = "0x7458BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xDAA738", Offset = "0xDAA738", VA = "0xDAA738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xDAA820", Offset = "0xDAA820", VA = "0xDAA820")]
		public void Reset()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xDAA904", Offset = "0xDAA904", VA = "0xDAA904")]
		private void Update()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xDAAE78", Offset = "0xDAAE78", VA = "0xDAAE78")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xDAB050", Offset = "0xDAB050", VA = "0xDAB050")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C13C", Offset = "0x73C13C")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xC4646C", Offset = "0xC4646C", VA = "0xC4646C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xC46504", Offset = "0xC46504", VA = "0xC46504")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xC469D0", Offset = "0xC469D0", VA = "0xC469D0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0xC46F20", Offset = "0xC46F20", VA = "0xC46F20")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF20", Offset = "0x73EF20")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C7")]
				[Address(RVA = "0xC47758", Offset = "0xC47758", VA = "0xC47758", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C9")]
				[Address(RVA = "0xC477C4", Offset = "0xC477C4", VA = "0xC477C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xC46FA8", Offset = "0xC46FA8", VA = "0xC46FA8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xC47160", Offset = "0xC47160", VA = "0xC47160", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0xC47164", Offset = "0xC47164", VA = "0xC47164", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0xC47760", Offset = "0xC47760", VA = "0xC47760", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0xC46F34", Offset = "0xC46F34", VA = "0xC46F34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7458CC", Offset = "0x7458CC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0xC46FD4", Offset = "0xC46FD4", VA = "0xC46FD4")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0xC47158", Offset = "0xC47158", VA = "0xC47158")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF30", Offset = "0x73EF30")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008CD")]
				[Address(RVA = "0xC47B90", Offset = "0xC47B90", VA = "0xC47B90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008CF")]
				[Address(RVA = "0xC47BFC", Offset = "0xC47BFC", VA = "0xC47BFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xC47840", Offset = "0xC47840", VA = "0xC47840")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xC4787C", Offset = "0xC4787C", VA = "0xC4787C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xC47880", Offset = "0xC47880", VA = "0xC47880", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xC47B98", Offset = "0xC47B98", VA = "0xC47B98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x6000344")]
		[Address(RVA = "0xC477CC", Offset = "0xC477CC", VA = "0xC477CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745930", Offset = "0x745930")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xC4786C", Offset = "0xC4786C", VA = "0xC4786C")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF40", Offset = "0x73EF40")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008D3")]
				[Address(RVA = "0xC48024", Offset = "0xC48024", VA = "0xC48024", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008D5")]
				[Address(RVA = "0xC48090", Offset = "0xC48090", VA = "0xC48090", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xC47CDC", Offset = "0xC47CDC", VA = "0xC47CDC")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xC47D34", Offset = "0xC47D34", VA = "0xC47D34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xC47D38", Offset = "0xC47D38", VA = "0xC47D38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xC4802C", Offset = "0xC4802C", VA = "0xC4802C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xC47C04", Offset = "0xC47C04", VA = "0xC47C04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xC47C5C", Offset = "0xC47C5C", VA = "0xC47C5C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x745994", Offset = "0x745994")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xC47D08", Offset = "0xC47D08", VA = "0xC47D08")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xC47D10", Offset = "0xC47D10", VA = "0xC47D10")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xC48098", Offset = "0xC48098", VA = "0xC48098")]
		private void Start()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xC480F0", Offset = "0xC480F0", VA = "0xC480F0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xC48188", Offset = "0xC48188", VA = "0xC48188")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xC48198", Offset = "0xC48198", VA = "0xC48198")]
		private void Start()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xC48208", Offset = "0xC48208", VA = "0xC48208")]
		private void Update()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xC4846C", Offset = "0xC4846C", VA = "0xC4846C")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xC48494", Offset = "0xC48494", VA = "0xC48494")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xC484A4", Offset = "0xC484A4", VA = "0xC484A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xC48670", Offset = "0xC48670", VA = "0xC48670")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xC4868C", Offset = "0xC4868C", VA = "0xC4868C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xC48820", Offset = "0xC48820", VA = "0xC48820")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xC48830", Offset = "0xC48830", VA = "0xC48830")]
		private void Start()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xC488FC", Offset = "0xC488FC", VA = "0xC488FC")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC48904", Offset = "0xC48904", VA = "0xC48904")]
		private void Start()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC4895C", Offset = "0xC4895C", VA = "0xC4895C")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC48BF0", Offset = "0xC48BF0", VA = "0xC48BF0")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x2000033")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1351F68", Offset = "0x1351F68", VA = "0x1351F68")]
		private void Update()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x13521B0", Offset = "0x13521B0", VA = "0x13521B0")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C1B0", Offset = "0x73C1B0")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x600035C")]
		[Address(RVA = "0xDAB06C", Offset = "0xDAB06C", VA = "0xDAB06C")]
		public void Awake()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xDAB090", Offset = "0xDAB090", VA = "0xDAB090")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xDAB0F0", Offset = "0xDAB0F0", VA = "0xDAB0F0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xDAB150", Offset = "0xDAB150", VA = "0xDAB150")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C224", Offset = "0x73C224")]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x6000360")]
		[Address(RVA = "0xDAB158", Offset = "0xDAB158", VA = "0xDAB158")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class MeshContainer
	{
		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xDAB160", Offset = "0xDAB160", VA = "0xDAB160")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xDAB1B8", Offset = "0xDAB1B8", VA = "0xDAB1B8")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C298", Offset = "0x73C298")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_SharedMaterial;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xDAB1FC", Offset = "0xDAB1FC", VA = "0xDAB1FC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xDAB31C", Offset = "0xDAB31C", VA = "0xDAB31C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xDAB630", Offset = "0xDAB630", VA = "0xDAB630")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xDAB6EC", Offset = "0xDAB6EC", VA = "0xDAB6EC")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xDAB7F8", Offset = "0xDAB7F8", VA = "0xDAB7F8")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xDAC0F4", Offset = "0xDAC0F4", VA = "0xDAC0F4")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xDAC154", Offset = "0xDAC154", VA = "0xDAC154")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xDAC254", Offset = "0xDAC254", VA = "0xDAC254")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xDAC2B4", Offset = "0xDAC2B4", VA = "0xDAC2B4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xDAB964", Offset = "0xDAB964", VA = "0xDAB964")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xDAC314", Offset = "0xDAC314", VA = "0xDAC314")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xDAC828", Offset = "0xDAC828", VA = "0xDAC828")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xDAC37C", Offset = "0xDAC37C", VA = "0xDAC37C")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xDACA70", Offset = "0xDACA70", VA = "0xDACA70")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xDAC640", Offset = "0xDAC640", VA = "0xDAC640")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xDACA90", Offset = "0xDACA90", VA = "0xDACA90")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C30C", Offset = "0x73C30C")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x134F73C", Offset = "0x134F73C", VA = "0x134F73C")]
		public void Start()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x134F82C", Offset = "0x134F82C", VA = "0x134F82C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x134FA5C", Offset = "0x134FA5C", VA = "0x134FA5C")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x20000E9")]
		public enum WaterMode
		{
			[Token(Token = "0x40006C6")]
			Simple,
			[Token(Token = "0x40006C7")]
			Reflective,
			[Token(Token = "0x40006C8")]
			Refractive
		}

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x134FA64", Offset = "0x134FA64", VA = "0x134FA64")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1351624", Offset = "0x1351624", VA = "0x1351624")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1351920", Offset = "0x1351920", VA = "0x1351920")]
		private void Update()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1350F38", Offset = "0x1350F38", VA = "0x1350F38")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x135052C", Offset = "0x135052C", VA = "0x135052C")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1350518", Offset = "0x1350518", VA = "0x1350518")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x13503C8", Offset = "0x13503C8", VA = "0x13503C8")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x135143C", Offset = "0x135143C", VA = "0x135143C")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1351198", Offset = "0x1351198", VA = "0x1351198")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1351BB4", Offset = "0x1351BB4", VA = "0x1351BB4")]
		public Water()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public enum WaterQuality
	{
		[Token(Token = "0x40001C3")]
		High = 2,
		[Token(Token = "0x40001C4")]
		Medium = 1,
		[Token(Token = "0x40001C5")]
		Low = 0
	}
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1351C90", Offset = "0x1351C90", VA = "0x1351C90")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1351E14", Offset = "0x1351E14", VA = "0x1351E14")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1351ECC", Offset = "0x1351ECC", VA = "0x1351ECC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1351F50", Offset = "0x1351F50", VA = "0x1351F50")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x13521B8", Offset = "0x13521B8", VA = "0x13521B8")]
		public void Start()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x13521BC", Offset = "0x13521BC", VA = "0x13521BC")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1352360", Offset = "0x1352360", VA = "0x1352360")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x135247C", Offset = "0x135247C", VA = "0x135247C")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x200003D")]
	public enum AAMode
	{
		[Token(Token = "0x40001CC")]
		FXAA2,
		[Token(Token = "0x40001CD")]
		FXAA3Console,
		[Token(Token = "0x40001CE")]
		FXAA1PresetA,
		[Token(Token = "0x40001CF")]
		FXAA1PresetB,
		[Token(Token = "0x40001D0")]
		NFAA,
		[Token(Token = "0x40001D1")]
		SSAA,
		[Token(Token = "0x40001D2")]
		DLAA
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C3B0", Offset = "0x73C3B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C3B0", Offset = "0x73C3B0")]
	public class Antialiasing : PostEffectsBase
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AAMode mode;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool showGeneratedNormals;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float offsetScale;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float blurRadius;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeThresholdMin;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float edgeThreshold;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgeSharpness;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool dlaaSharp;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader ssaaShader;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material ssaa;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dlaaShader;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dlaa;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader nfaaShader;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material nfaa;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader shaderFXAAPreset2;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material materialFXAAPreset2;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Shader shaderFXAAPreset3;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Material materialFXAAPreset3;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Shader shaderFXAAII;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Material materialFXAAII;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader shaderFXAAIII;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Material materialFXAAIII;

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC48C68", Offset = "0xC48C68", VA = "0xC48C68")]
		public Material CurrentAAMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xC48CCC", Offset = "0xC48CCC", VA = "0xC48CCC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xC48DBC", Offset = "0xC48DBC", VA = "0xC48DBC")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC4930C", Offset = "0xC4930C", VA = "0xC4930C")]
		public Antialiasing()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C448", Offset = "0x73C448")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C448", Offset = "0x73C448")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x20000EA")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40006CA")]
			Ghosting,
			[Token(Token = "0x40006CB")]
			Anamorphic,
			[Token(Token = "0x40006CC")]
			Combined
		}

		[Token(Token = "0x20000EB")]
		public enum TweakMode
		{
			[Token(Token = "0x40006CE")]
			Basic,
			[Token(Token = "0x40006CF")]
			Complex
		}

		[Token(Token = "0x20000EC")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40006D1")]
			Auto,
			[Token(Token = "0x40006D2")]
			On,
			[Token(Token = "0x40006D3")]
			Off
		}

		[Token(Token = "0x20000ED")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40006D5")]
			Screen,
			[Token(Token = "0x40006D6")]
			Add
		}

		[Token(Token = "0x20000EE")]
		public enum BloomQuality
		{
			[Token(Token = "0x40006D8")]
			Cheap,
			[Token(Token = "0x40006D9")]
			High
		}

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode tweakMode;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BloomQuality quality;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float flareRotation;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC49330", Offset = "0xC49330", VA = "0xC49330", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC493D0", Offset = "0xC493D0", VA = "0xC493D0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC4A798", Offset = "0xC4A798", VA = "0xC4A798")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC4A594", Offset = "0xC4A594", VA = "0xC4A594")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC4A290", Offset = "0xC4A290", VA = "0xC4A290")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC4A1A8", Offset = "0xC4A1A8", VA = "0xC4A1A8")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC4A380", Offset = "0xC4A380", VA = "0xC4A380")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC4A868", Offset = "0xC4A868", VA = "0xC4A868")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public enum LensflareStyle34
	{
		[Token(Token = "0x4000208")]
		Ghosting,
		[Token(Token = "0x4000209")]
		Anamorphic,
		[Token(Token = "0x400020A")]
		Combined
	}
	[Token(Token = "0x2000041")]
	public enum TweakMode34
	{
		[Token(Token = "0x400020C")]
		Basic,
		[Token(Token = "0x400020D")]
		Complex
	}
	[Token(Token = "0x2000042")]
	public enum HDRBloomMode
	{
		[Token(Token = "0x400020F")]
		Auto,
		[Token(Token = "0x4000210")]
		On,
		[Token(Token = "0x4000211")]
		Off
	}
	[Token(Token = "0x2000043")]
	public enum BloomScreenBlendMode
	{
		[Token(Token = "0x4000213")]
		Screen,
		[Token(Token = "0x4000214")]
		Add
	}
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C4E0", Offset = "0x73C4E0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C4E0", Offset = "0x73C4E0")]
	public class BloomAndFlares : PostEffectsBase
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool doHdr;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC4A9E8", Offset = "0xC4A9E8", VA = "0xC4A9E8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC4AAC4", Offset = "0xC4AAC4", VA = "0xC4AAC4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC4BA18", Offset = "0xC4BA18", VA = "0xC4BA18")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC4B824", Offset = "0xC4B824", VA = "0xC4B824")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC4B5A0", Offset = "0xC4B5A0", VA = "0xC4B5A0")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xC4B6D0", Offset = "0xC4B6D0", VA = "0xC4B6D0")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xC4BACC", Offset = "0xC4BACC", VA = "0xC4BACC")]
		public BloomAndFlares()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C578", Offset = "0x73C578")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C578", Offset = "0x73C578")]
	public class BloomOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000EF")]
		public enum Resolution
		{
			[Token(Token = "0x40006DB")]
			Low,
			[Token(Token = "0x40006DC")]
			High
		}

		[Token(Token = "0x20000F0")]
		public enum BlurType
		{
			[Token(Token = "0x40006DE")]
			Standard,
			[Token(Token = "0x40006DF")]
			Sgx
		}

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F2A0", Offset = "0x73F2A0")]
		public float threshold;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F2B8", Offset = "0x73F2B8")]
		public float intensity;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F2D0", Offset = "0x73F2D0")]
		public float blurSize;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Resolution resolution;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F2E8", Offset = "0x73F2E8")]
		public int blurIterations;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public BlurType blurType;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC4BC38", Offset = "0xC4BC38", VA = "0xC4BC38", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xC4BC9C", Offset = "0xC4BC9C", VA = "0xC4BC9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xC4BD4C", Offset = "0xC4BD4C", VA = "0xC4BD4C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xC4C128", Offset = "0xC4C128", VA = "0xC4C128")]
		public BloomOptimized()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C610", Offset = "0x73C610")]
	public class Blur : MonoBehaviour
	{
		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F300", Offset = "0x73F300")]
		public int iterations;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F318", Offset = "0x73F318")]
		public float blurSpread;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Shader blurShader;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material m_Material;

		[Token(Token = "0x1700002F")]
		protected Material material
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xC4C14C", Offset = "0xC4C14C", VA = "0xC4C14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC4C284", Offset = "0xC4C284", VA = "0xC4C284")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC4C380", Offset = "0xC4C380", VA = "0xC4C380")]
		protected void Start()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC4C440", Offset = "0xC4C440", VA = "0xC4C440")]
		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC4C5EC", Offset = "0xC4C5EC", VA = "0xC4C5EC")]
		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC4C76C", Offset = "0xC4C76C", VA = "0xC4C76C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC4C8DC", Offset = "0xC4C8DC", VA = "0xC4C8DC")]
		public Blur()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C65C", Offset = "0x73C65C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C65C", Offset = "0x73C65C")]
	public class BlurOptimized : PostEffectsBase
	{
		[Token(Token = "0x20000F1")]
		public enum BlurType
		{
			[Token(Token = "0x40006E1")]
			StandardGauss,
			[Token(Token = "0x40006E2")]
			SgxGauss
		}

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F330", Offset = "0x73F330")]
		public int downsample;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F348", Offset = "0x73F348")]
		public float blurSize;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F360", Offset = "0x73F360")]
		public int blurIterations;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public BlurType blurType;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xD92598", Offset = "0xD92598", VA = "0xD92598", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xD92B24", Offset = "0xD92B24", VA = "0xD92B24")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xD92BD4", Offset = "0xD92BD4", VA = "0xD92BD4")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xD92F94", Offset = "0xD92F94", VA = "0xD92F94")]
		public BlurOptimized()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C6F4", Offset = "0x73C6F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C6F4", Offset = "0x73C6F4")]
	public class CameraMotionBlur : PostEffectsBase
	{
		[Token(Token = "0x20000F2")]
		public enum MotionBlurFilter
		{
			[Token(Token = "0x40006E4")]
			CameraMotion,
			[Token(Token = "0x40006E5")]
			LocalBlur,
			[Token(Token = "0x40006E6")]
			Reconstruction,
			[Token(Token = "0x40006E7")]
			ReconstructionDX11,
			[Token(Token = "0x40006E8")]
			ReconstructionDisc
		}

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float MAX_RADIUS;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MotionBlurFilter filterType;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool preview;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 previewScale;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float movementScale;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float rotationScale;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float maxVelocity;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minVelocity;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float velocityScale;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float softZDistance;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int velocityDownsample;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask excludeLayers;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GameObject tmpCam;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shader;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dx11MotionBlurShader;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Shader replacementClear;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Material motionBlurMaterial;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11MotionBlurMaterial;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Texture2D noiseTexture;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float jitter;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool showVelocity;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float showVelocityScale;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Matrix4x4 currentViewProjMat;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Matrix4x4[] currentStereoViewProjMat;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Matrix4x4 prevViewProjMat;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Matrix4x4[] prevStereoViewProjMat;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private int prevFrameCount;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private bool wasActive;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3 prevFrameForward;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 prevFrameUp;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 prevFramePos;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Camera _camera;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xD93028", Offset = "0xD93028", VA = "0xD93028")]
		private void CalculateViewProjection()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xD932F8", Offset = "0xD932F8", VA = "0xD932F8")]
		private new void Start()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xD935A0", Offset = "0xD935A0", VA = "0xD935A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xD93664", Offset = "0xD93664", VA = "0xD93664")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xD937C8", Offset = "0xD937C8", VA = "0xD937C8", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xD938AC", Offset = "0xD938AC", VA = "0xD938AC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xD933F8", Offset = "0xD933F8", VA = "0xD933F8")]
		private void Remember()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xD952C4", Offset = "0xD952C4", VA = "0xD952C4")]
		private Camera GetTmpCam()
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xD951D8", Offset = "0xD951D8", VA = "0xD951D8")]
		private void StartFrame()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xD952B4", Offset = "0xD952B4", VA = "0xD952B4")]
		private static int divRoundUp(int x, int d)
		{
			return default(int);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xD95608", Offset = "0xD95608", VA = "0xD95608")]
		public CameraMotionBlur()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C78C", Offset = "0x73C78C")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		[Token(Token = "0x20000F3")]
		public enum ColorCorrectionMode
		{
			[Token(Token = "0x40006EA")]
			Simple,
			[Token(Token = "0x40006EB")]
			Advanced
		}

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float saturation;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public ColorCorrectionMode mode;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xD95754", Offset = "0xD95754", VA = "0xD95754")]
		private new void Start()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xD95790", Offset = "0xD95790", VA = "0xD95790")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xD95794", Offset = "0xD95794", VA = "0xD95794", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xD959F4", Offset = "0xD959F4", VA = "0xD959F4")]
		public void UpdateParameters()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xD95DF0", Offset = "0xD95DF0", VA = "0xD95DF0")]
		private void UpdateTextures()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xD95DF4", Offset = "0xD95DF4", VA = "0xD95DF4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xD960FC", Offset = "0xD960FC", VA = "0xD960FC")]
		public ColorCorrectionCurves()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C7D8", Offset = "0x73C7D8")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Shader shader;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material material;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture3D converted3DLut;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string basedOnTempTex;

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xD96734", Offset = "0xD96734", VA = "0xD96734", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xD96788", Offset = "0xD96788", VA = "0xD96788")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xD96830", Offset = "0xD96830", VA = "0xD96830")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xD968D8", Offset = "0xD968D8", VA = "0xD968D8")]
		public void SetIdentityLut()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xD96AE0", Offset = "0xD96AE0", VA = "0xD96AE0")]
		public bool ValidDimensions(Texture2D tex2d)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xD96BD8", Offset = "0xD96BD8", VA = "0xD96BD8")]
		public void Convert(Texture2D temp2DTex, string path)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xD96EFC", Offset = "0xD96EFC", VA = "0xD96EFC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xD970F0", Offset = "0xD970F0", VA = "0xD970F0")]
		public ColorCorrectionLookup()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C824", Offset = "0x73C824")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xD97144", Offset = "0xD97144", VA = "0xD97144")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xD972C4", Offset = "0xD972C4", VA = "0xD972C4")]
		public ColorCorrectionRamp()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C870", Offset = "0x73C870")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C870", Offset = "0x73C870")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F378", Offset = "0x73F378")]
		public float intensity;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F390", Offset = "0x73F390")]
		public float threshold;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F3AC", Offset = "0x73F3AC")]
		public float blurSpread;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xD972D4", Offset = "0xD972D4", VA = "0xD972D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xD97344", Offset = "0xD97344", VA = "0xD97344")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xD976B0", Offset = "0xD976B0", VA = "0xD976B0")]
		public ContrastEnhance()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C908", Offset = "0x73C908")]
	public class ContrastStretch : MonoBehaviour
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F3C4", Offset = "0x73F3C4")]
		public float adaptationSpeed;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F3E0", Offset = "0x73F3E0")]
		public float limitMinimum;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F3F8", Offset = "0x73F3F8")]
		public float limitMaximum;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture[] adaptRenderTex;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int curAdaptIndex;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader shaderLum;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_materialLum;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderReduce;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_materialReduce;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader shaderAdapt;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_materialAdapt;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader shaderApply;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_materialApply;

		[Token(Token = "0x17000030")]
		protected Material materialLum
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0xD976C4", Offset = "0xD976C4", VA = "0xD976C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		protected Material materialReduce
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xD9778C", Offset = "0xD9778C", VA = "0xD9778C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		protected Material materialAdapt
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0xD97854", Offset = "0xD97854", VA = "0xD97854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		protected Material materialApply
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xD9791C", Offset = "0xD9791C", VA = "0xD9791C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xD979E4", Offset = "0xD979E4", VA = "0xD979E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xD97A78", Offset = "0xD97A78", VA = "0xD97A78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xD97BCC", Offset = "0xD97BCC", VA = "0xD97BCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xD97E04", Offset = "0xD97E04", VA = "0xD97E04")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xD9806C", Offset = "0xD9806C", VA = "0xD9806C")]
		private void CalculateAdaptation(Texture curTexture)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xD98288", Offset = "0xD98288", VA = "0xD98288")]
		public ContrastStretch()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C954", Offset = "0x73C954")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C954", Offset = "0x73C954")]
	public class CreaseShading : PostEffectsBase
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensity;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int softness;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spread;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader depthFetchShader;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material depthFetchMaterial;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader creaseApplyShader;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material creaseApplyMaterial;

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xD98308", Offset = "0xD98308", VA = "0xD98308", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xD98380", Offset = "0xD98380", VA = "0xD98380")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xD9872C", Offset = "0xD9872C", VA = "0xD9872C")]
		public CreaseShading()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73C9EC", Offset = "0x73C9EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73C9EC", Offset = "0x73C9EC")]
	public class DepthOfField : PostEffectsBase
	{
		[Token(Token = "0x20000F4")]
		public enum BlurType
		{
			[Token(Token = "0x40006ED")]
			DiscBlur,
			[Token(Token = "0x40006EE")]
			DX11
		}

		[Token(Token = "0x20000F5")]
		public enum BlurSampleCount
		{
			[Token(Token = "0x40006F0")]
			Low,
			[Token(Token = "0x40006F1")]
			Medium,
			[Token(Token = "0x40006F2")]
			High
		}

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool visualizeFocus;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float focalLength;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float focalSize;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float aperture;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform focalTransform;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxBlurSize;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool highResolution;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BlurType blurType;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public BlurSampleCount blurSampleCount;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool nearBlur;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float foregroundOverlap;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader dofHdrShader;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material dofHdrMaterial;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Shader dx11BokehShader;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material dx11bokehMaterial;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float dx11BokehThreshold;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float dx11SpawnHeuristic;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Texture2D dx11BokehTexture;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float dx11BokehScale;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float dx11BokehIntensity;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float focalDistance01;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ComputeBuffer cbDrawArgs;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ComputeBuffer cbPoints;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float internalBlurWidth;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Camera cachedCamera;

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xD98744", Offset = "0xD98744", VA = "0xD98744", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xD988EC", Offset = "0xD988EC", VA = "0xD988EC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xD98968", Offset = "0xD98968", VA = "0xD98968")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xD98A70", Offset = "0xD98A70", VA = "0xD98A70")]
		private void ReleaseComputeResources()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xD987C8", Offset = "0xD987C8", VA = "0xD987C8")]
		private void CreateComputeResources()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xD98AB4", Offset = "0xD98AB4", VA = "0xD98AB4")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xD98C14", Offset = "0xD98C14", VA = "0xD98C14")]
		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xD98F3C", Offset = "0xD98F3C", VA = "0xD98F3C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xD9A584", Offset = "0xD9A584", VA = "0xD9A584")]
		public DepthOfField()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CA84", Offset = "0x73CA84")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CA84", Offset = "0x73CA84")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		[Token(Token = "0x20000F6")]
		public enum Dof34QualitySetting
		{
			[Token(Token = "0x40006F4")]
			OnlyBackground = 1,
			[Token(Token = "0x40006F5")]
			BackgroundAndForeground
		}

		[Token(Token = "0x20000F7")]
		public enum DofResolution
		{
			[Token(Token = "0x40006F7")]
			High = 2,
			[Token(Token = "0x40006F8")]
			Medium,
			[Token(Token = "0x40006F9")]
			Low
		}

		[Token(Token = "0x20000F8")]
		public enum DofBlurriness
		{
			[Token(Token = "0x40006FB")]
			Low = 1,
			[Token(Token = "0x40006FC")]
			High = 2,
			[Token(Token = "0x40006FD")]
			VeryHigh = 4
		}

		[Token(Token = "0x20000F9")]
		public enum BokehDestination
		{
			[Token(Token = "0x40006FF")]
			Background = 1,
			[Token(Token = "0x4000700")]
			Foreground,
			[Token(Token = "0x4000701")]
			BackgroundAndForeground
		}

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dof34QualitySetting quality;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public DofResolution resolution;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float focalPoint;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float smoothness;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float focalSize;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public DofBlurriness bluriness;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool visualize;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public BokehDestination bokehDestination;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xD9A5E4", Offset = "0xD9A5E4", VA = "0xD9A5E4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xD9A6BC", Offset = "0xD9A6BC", VA = "0xD9A6BC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xD9A7C4", Offset = "0xD9A7C4", VA = "0xD9A7C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xD9AA04", Offset = "0xD9AA04", VA = "0xD9AA04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xD9AA80", Offset = "0xD9AA80", VA = "0xD9AA80")]
		private float FocalDistance01(float worldDist)
		{
			return default(float);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xD9ABE0", Offset = "0xD9ABE0", VA = "0xD9ABE0")]
		private int GetDividerBasedOnQuality()
		{
			return default(int);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xD9AC04", Offset = "0xD9AC04", VA = "0xD9AC04")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return default(int);
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xD9AC28", Offset = "0xD9AC28", VA = "0xD9AC28")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xD9BA10", Offset = "0xD9BA10", VA = "0xD9BA10")]
		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xD9C0C0", Offset = "0xD9C0C0", VA = "0xD9C0C0")]
		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xD9C530", Offset = "0xD9C530", VA = "0xD9C530")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xD9B8C0", Offset = "0xD9B8C0", VA = "0xD9B8C0")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xD9BCB0", Offset = "0xD9BCB0", VA = "0xD9BCB0")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xD9C384", Offset = "0xD9C384", VA = "0xD9C384")]
		private void ReleaseTextures()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xD9B588", Offset = "0xD9B588", VA = "0xD9B588")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xD9CA20", Offset = "0xD9CA20", VA = "0xD9CA20")]
		public DepthOfFieldDeprecated()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CB1C", Offset = "0x73CB1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CB1C", Offset = "0x73CB1C")]
	public class EdgeDetection : PostEffectsBase
	{
		[Token(Token = "0x20000FA")]
		public enum EdgeDetectMode
		{
			[Token(Token = "0x4000703")]
			TriangleDepthNormals,
			[Token(Token = "0x4000704")]
			RobertsCrossDepthNormals,
			[Token(Token = "0x4000705")]
			SobelDepth,
			[Token(Token = "0x4000706")]
			SobelDepthThin,
			[Token(Token = "0x4000707")]
			TriangleLuminance
		}

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeDetectMode mode;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sensitivityDepth;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float sensitivityNormals;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float lumThreshold;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float edgeExp;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sampleDist;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float edgesOnly;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Color edgesOnlyBgColor;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader edgeDetectShader;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material edgeDetectMaterial;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private EdgeDetectMode oldMode;

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xD9CAFC", Offset = "0xD9CAFC", VA = "0xD9CAFC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xD9CC3C", Offset = "0xD9CC3C", VA = "0xD9CC3C")]
		private new void Start()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xD9CB74", Offset = "0xD9CB74", VA = "0xD9CB74")]
		private void SetCameraFlag()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xD9CC48", Offset = "0xD9CC48", VA = "0xD9CC48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xD9CC4C", Offset = "0xD9CC4C", VA = "0xD9CC4C")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xD9CE3C", Offset = "0xD9CE3C", VA = "0xD9CE3C")]
		public EdgeDetection()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CBB4", Offset = "0x73CBB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CBB4", Offset = "0x73CBB4")]
	public class Fisheye : PostEffectsBase
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F410", Offset = "0x73F410")]
		public float strengthX;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F428", Offset = "0x73F428")]
		public float strengthY;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader fishEyeShader;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material fisheyeMaterial;

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xD9CE8C", Offset = "0xD9CE8C", VA = "0xD9CE8C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xD9CEE4", Offset = "0xD9CEE4", VA = "0xD9CEE4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xD9D058", Offset = "0xD9D058", VA = "0xD9D058")]
		public Fisheye()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CC4C", Offset = "0x73CC4C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CC4C", Offset = "0x73CC4C")]
	internal class GlobalFog : PostEffectsBase
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F440", Offset = "0x73F440")]
		public bool distanceFog;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F478", Offset = "0x73F478")]
		public bool excludeFarPixels;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F4B0", Offset = "0x73F4B0")]
		public bool useRadialDistance;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F4E8", Offset = "0x73F4E8")]
		public bool heightFog;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F520", Offset = "0x73F520")]
		public float height;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F558", Offset = "0x73F558")]
		public float heightDensity;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F574", Offset = "0x73F574")]
		public float startDistance;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader fogShader;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material fogMaterial;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xD9D070", Offset = "0xD9D070", VA = "0xD9D070", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xD9D0C8", Offset = "0xD9D0C8", VA = "0xD9D0C8")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xD9D710", Offset = "0xD9D710", VA = "0xD9D710")]
		public GlobalFog()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CCE4", Offset = "0x73CCE4")]
	public class Grayscale : ImageEffectBase
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture textureRamp;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F5AC", Offset = "0x73F5AC")]
		public float rampOffset;

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xD9D730", Offset = "0xD9D730", VA = "0xD9D730")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xD9D80C", Offset = "0xD9D80C", VA = "0xD9D80C")]
		public Grayscale()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CD30", Offset = "0x73CD30")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CD30", Offset = "0x73CD30")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x17000034")]
		protected Material material
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xD971FC", Offset = "0xD971FC", VA = "0xD971FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xD9D814", Offset = "0xD9D814", VA = "0xD9D814", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xD9D8C4", Offset = "0xD9D8C4", VA = "0xD9D8C4", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xD972CC", Offset = "0xD972CC", VA = "0xD972CC")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CDB8", Offset = "0x73CDB8")]
	public class ImageEffects
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0xD9D974", Offset = "0xD9D974", VA = "0xD9D974")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xD9DBF4", Offset = "0xD9DBF4", VA = "0xD9DBF4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x745A18", Offset = "0x745A18")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xD9DC6C", Offset = "0xD9DC6C", VA = "0xD9DC6C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x745A50", Offset = "0x745A50")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xD9DCEC", Offset = "0xD9DCEC", VA = "0xD9DCEC")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000057")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CDF0", Offset = "0x73CDF0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CDF0", Offset = "0x73CDF0")]
	public class MotionBlur : ImageEffectBase
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F5C4", Offset = "0x73F5C4")]
		public float blurAmount;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool extraBlur;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RenderTexture accumTexture;

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xD9DCF4", Offset = "0xD9DCF4", VA = "0xD9DCF4", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xD9DCF8", Offset = "0xD9DCF8", VA = "0xD9DCF8", Slot = "5")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xD9DD6C", Offset = "0xD9DD6C", VA = "0xD9DD6C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xD9E0F8", Offset = "0xD9E0F8", VA = "0xD9E0F8")]
		public MotionBlur()
		{
		}
	}
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CE88", Offset = "0x73CE88")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CE88", Offset = "0x73CE88")]
	public class NoiseAndGrain : PostEffectsBase
	{
		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float midGrey;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float softness;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool monochrome;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xD9E10C", Offset = "0xD9E10C", VA = "0xD9E10C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xD9E184", Offset = "0xD9E184", VA = "0xD9E184")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xD9EAA8", Offset = "0xD9EAA8", VA = "0xD9EAA8")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xD9EE28", Offset = "0xD9EE28", VA = "0xD9EE28")]
		public NoiseAndGrain()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CF20", Offset = "0x73CF20")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73CF20", Offset = "0x73CF20")]
	public class NoiseAndScratches : MonoBehaviour
	{
		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool monochrome;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F5E0", Offset = "0x73F5E0")]
		public float grainIntensityMin;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F5F8", Offset = "0x73F5F8")]
		public float grainIntensityMax;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F610", Offset = "0x73F610")]
		public float grainSize;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F630", Offset = "0x73F630")]
		public float scratchIntensityMin;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F648", Offset = "0x73F648")]
		public float scratchIntensityMax;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F660", Offset = "0x73F660")]
		public float scratchFPS;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F678", Offset = "0x73F678")]
		public float scratchJitter;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float scratchX;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float scratchY;

		[Token(Token = "0x17000035")]
		protected Material material
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xD9F070", Offset = "0xD9F070", VA = "0xD9F070")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xD9EF30", Offset = "0xD9EF30", VA = "0xD9EF30")]
		protected void Start()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xD9F1D0", Offset = "0xD9F1D0", VA = "0xD9F1D0")]
		protected void OnDisable()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xD9F2D4", Offset = "0xD9F2D4", VA = "0xD9F2D4")]
		private void SanitizeParameters()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xD9F410", Offset = "0xD9F410", VA = "0xD9F410")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xD9F764", Offset = "0xD9F764", VA = "0xD9F764")]
		public NoiseAndScratches()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73CFB8", Offset = "0x73CFB8")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Material> createdMaterials;

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xD926FC", Offset = "0xD926FC", VA = "0xD926FC")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xD9F7C4", Offset = "0xD9F7C4", VA = "0xD9F7C4")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xD9F9A4", Offset = "0xD9F9A4", VA = "0xD9F9A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xD9F9B0", Offset = "0xD9F9B0", VA = "0xD9F9B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xD9F9B4", Offset = "0xD9F9B4", VA = "0xD9F9B4")]
		private void RemoveCreatedMaterials()
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xD9FA68", Offset = "0xD9FA68", VA = "0xD9FA68")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xD9FA70", Offset = "0xD9FA70", VA = "0xD9FA70", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xD95784", Offset = "0xD95784", VA = "0xD95784")]
		protected void Start()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xD925F0", Offset = "0xD925F0", VA = "0xD925F0")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xD93850", Offset = "0xD93850", VA = "0xD93850")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xD9FB20", Offset = "0xD9FB20", VA = "0xD9FB20")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xD92A7C", Offset = "0xD92A7C", VA = "0xD92A7C")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xD9FB28", Offset = "0xD9FB28", VA = "0xD9FB28")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xD9F798", Offset = "0xD9F798", VA = "0xD9F798")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xD9FD30", Offset = "0xD9FD30", VA = "0xD9FD30")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xD92FAC", Offset = "0xD92FAC", VA = "0xD92FAC")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E02C", Offset = "0x73E02C")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0xDA00B0", Offset = "0xDA00B0", VA = "0xDA00B0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xDA011C", Offset = "0xDA011C", VA = "0xDA011C")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xDA0398", Offset = "0xDA0398", VA = "0xDA0398")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xDA0714", Offset = "0xDA0714", VA = "0xDA0714")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xDA08C4", Offset = "0xDA08C4", VA = "0xDA08C4")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x200005C")]
	internal class Quads
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xDA08CC", Offset = "0xDA08CC", VA = "0xDA08CC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xD9A820", Offset = "0xD9A820", VA = "0xD9A820")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xD9C75C", Offset = "0xD9C75C", VA = "0xD9C75C")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xDA09EC", Offset = "0xDA09EC", VA = "0xDA09EC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xDA0F20", Offset = "0xDA0F20", VA = "0xDA0F20")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E0A0", Offset = "0x73E0A0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E0A0", Offset = "0x73E0A0")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x20000FB")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x4000709")]
			Additive,
			[Token(Token = "0x400070A")]
			ScreenBlend,
			[Token(Token = "0x400070B")]
			Multiply,
			[Token(Token = "0x400070C")]
			Overlay,
			[Token(Token = "0x400070D")]
			AlphaBlend
		}

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D texture;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader overlayShader;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material overlayMaterial;

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xDA0F2C", Offset = "0xDA0F2C", VA = "0xDA0F2C", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xDA0F84", Offset = "0xDA0F84", VA = "0xDA0F84")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xDA10EC", Offset = "0xDA10EC", VA = "0xDA10EC")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E138", Offset = "0x73E138")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E138", Offset = "0x73E138")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F690", Offset = "0x73F690")]
		public float intensity;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F6A8", Offset = "0x73F6A8")]
		public float radius;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F6C4", Offset = "0x73F6C4")]
		public int blurIterations;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F6DC", Offset = "0x73F6DC")]
		public float blurFilterDistance;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F6F4", Offset = "0x73F6F4")]
		public int downsample;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Texture2D rand;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader aoShader;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material aoMaterial;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xDA10FC", Offset = "0xDA10FC", VA = "0xDA10FC", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xDA1154", Offset = "0xDA1154", VA = "0xDA1154")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xDA11FC", Offset = "0xDA11FC", VA = "0xDA11FC")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xDA1A20", Offset = "0xDA1A20", VA = "0xDA1A20")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E1D0", Offset = "0x73E1D0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E1D0", Offset = "0x73E1D0")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x20000FC")]
		public enum SSAOSamples
		{
			[Token(Token = "0x400070F")]
			Low,
			[Token(Token = "0x4000710")]
			Medium,
			[Token(Token = "0x4000711")]
			High
		}

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F70C", Offset = "0x73F70C")]
		public float m_Radius;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F728", Offset = "0x73F728")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F740", Offset = "0x73F740")]
		public int m_Blur;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F758", Offset = "0x73F758")]
		public int m_Downsampling;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F770", Offset = "0x73F770")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F78C", Offset = "0x73F78C")]
		public float m_MinZ;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xDA1A3C", Offset = "0xDA1A3C", VA = "0xDA1A3C")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xDA1AF0", Offset = "0xDA1AF0", VA = "0xDA1AF0")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xDA1B8C", Offset = "0xDA1B8C", VA = "0xDA1B8C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xDA1B94", Offset = "0xDA1B94", VA = "0xDA1B94")]
		private void Start()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xDA1D28", Offset = "0xDA1D28", VA = "0xDA1D28")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xDA1C6C", Offset = "0xDA1C6C", VA = "0xDA1C6C")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xDA1DA0", Offset = "0xDA1DA0", VA = "0xDA1DA0")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xDA2464", Offset = "0xDA2464", VA = "0xDA2464")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E268", Offset = "0x73E268")]
	public class SepiaTone : ImageEffectBase
	{
		[Token(Token = "0x6000441")]
		[Address(RVA = "0xDA249C", Offset = "0xDA249C", VA = "0xDA249C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xDA252C", Offset = "0xDA252C", VA = "0xDA252C")]
		public SepiaTone()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E2B4", Offset = "0x73E2B4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E2B4", Offset = "0x73E2B4")]
	public class SunShafts : PostEffectsBase
	{
		[Token(Token = "0x20000FD")]
		public enum SunShaftsResolution
		{
			[Token(Token = "0x4000713")]
			Low,
			[Token(Token = "0x4000714")]
			Normal,
			[Token(Token = "0x4000715")]
			High
		}

		[Token(Token = "0x20000FE")]
		public enum ShaftsScreenBlendMode
		{
			[Token(Token = "0x4000717")]
			Screen,
			[Token(Token = "0x4000718")]
			Add
		}

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SunShaftsResolution resolution;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public ShaftsScreenBlendMode screenBlendMode;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float maxRadius;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xDA2534", Offset = "0xDA2534", VA = "0xDA2534", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xDA259C", Offset = "0xDA259C", VA = "0xDA259C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xDA2D9C", Offset = "0xDA2D9C", VA = "0xDA2D9C")]
		public SunShafts()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E34C", Offset = "0x73E34C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E34C", Offset = "0x73E34C")]
	internal class TiltShift : PostEffectsBase
	{
		[Token(Token = "0x20000FF")]
		public enum TiltShiftMode
		{
			[Token(Token = "0x400071A")]
			TiltShiftMode,
			[Token(Token = "0x400071B")]
			IrisMode
		}

		[Token(Token = "0x2000100")]
		public enum TiltShiftQuality
		{
			[Token(Token = "0x400071D")]
			Preview,
			[Token(Token = "0x400071E")]
			Low,
			[Token(Token = "0x400071F")]
			Normal,
			[Token(Token = "0x4000720")]
			High
		}

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TiltShiftMode mode;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public TiltShiftQuality quality;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F7A8", Offset = "0x73F7A8")]
		public float blurArea;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F7C0", Offset = "0x73F7C0")]
		public float maxBlurSize;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F7D8", Offset = "0x73F7D8")]
		public int downsample;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Shader tiltShiftShader;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material tiltShiftMaterial;

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xDA2E44", Offset = "0xDA2E44", VA = "0xDA2E44", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xDA2E9C", Offset = "0xDA2E9C", VA = "0xDA2E9C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xDA3140", Offset = "0xDA3140", VA = "0xDA3140")]
		public TiltShift()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E3D4", Offset = "0x73E3D4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E3D4", Offset = "0x73E3D4")]
	public class Tonemapping : PostEffectsBase
	{
		[Token(Token = "0x2000101")]
		public enum TonemapperType
		{
			[Token(Token = "0x4000722")]
			SimpleReinhard,
			[Token(Token = "0x4000723")]
			UserCurve,
			[Token(Token = "0x4000724")]
			Hable,
			[Token(Token = "0x4000725")]
			Photographic,
			[Token(Token = "0x4000726")]
			OptimizedHejiDawson,
			[Token(Token = "0x4000727")]
			AdaptiveReinhard,
			[Token(Token = "0x4000728")]
			AdaptiveReinhardAutoWhite
		}

		[Token(Token = "0x2000102")]
		public enum AdaptiveTexSize
		{
			[Token(Token = "0x400072A")]
			Square16 = 0x10,
			[Token(Token = "0x400072B")]
			Square32 = 0x20,
			[Token(Token = "0x400072C")]
			Square64 = 0x40,
			[Token(Token = "0x400072D")]
			Square128 = 0x80,
			[Token(Token = "0x400072E")]
			Square256 = 0x100,
			[Token(Token = "0x400072F")]
			Square512 = 0x200,
			[Token(Token = "0x4000730")]
			Square1024 = 0x400
		}

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TonemapperType type;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public AdaptiveTexSize adaptiveTextureSize;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve remapCurve;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Texture2D curveTex;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float exposureAdjustment;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float middleGrey;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float white;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float adaptionSpeed;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader tonemapper;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool validRenderTextureFormat;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material tonemapMaterial;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RenderTexture rt;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RenderTextureFormat rtFormat;

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xDA3158", Offset = "0xDA3158", VA = "0xDA3158", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xDA3298", Offset = "0xDA3298", VA = "0xDA3298")]
		public float UpdateCurve()
		{
			return default(float);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xDA354C", Offset = "0xDA354C", VA = "0xDA354C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xDA36A4", Offset = "0xDA36A4", VA = "0xDA36A4")]
		private bool CreateInternalRenderTexture()
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xDA3798", Offset = "0xDA3798", VA = "0xDA3798")]
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xDA3FB0", Offset = "0xDA3FB0", VA = "0xDA3FB0")]
		public Tonemapping()
		{
		}
	}
	[Token(Token = "0x2000064")]
	internal class Triangles
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xDA3FDC", Offset = "0xDA3FDC", VA = "0xDA3FDC")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xDA4120", Offset = "0xDA4120", VA = "0xDA4120")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xDA4304", Offset = "0xDA4304", VA = "0xDA4304")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xDA45C8", Offset = "0xDA45C8", VA = "0xDA45C8")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xDA4A04", Offset = "0xDA4A04", VA = "0xDA4A04")]
		public Triangles()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E46C", Offset = "0x73E46C")]
	public class Twirl : ImageEffectBase
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F7F0", Offset = "0x73F7F0")]
		public float angle;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xDA4A10", Offset = "0xDA4A10", VA = "0xDA4A10")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xDA4A54", Offset = "0xDA4A54", VA = "0xDA4A54")]
		public Twirl()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73E4B8", Offset = "0x73E4B8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E4B8", Offset = "0x73E4B8")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		[Token(Token = "0x2000103")]
		public enum AberrationMode
		{
			[Token(Token = "0x4000732")]
			Simple,
			[Token(Token = "0x4000733")]
			Advanced
		}

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AberrationMode mode;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float intensity;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float axialAberration;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float blur;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blurDistance;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xDA4AD0", Offset = "0xDA4AD0", VA = "0xDA4AD0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xDA4B54", Offset = "0xDA4B54", VA = "0xDA4B54")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xDA5184", Offset = "0xDA5184", VA = "0xDA5184")]
		public VignetteAndChromaticAberration()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E550", Offset = "0x73E550")]
	public class Vortex : ImageEffectBase
	{
		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 radius;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float angle;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector2 center;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xDA51B8", Offset = "0xDA51B8", VA = "0xDA51B8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xDA51FC", Offset = "0xDA51FC", VA = "0xDA51FC")]
		public Vortex()
		{
		}
	}
}
namespace RootMotion
{
	[Serializable]
	[Token(Token = "0x2000068")]
	public enum Axis
	{
		[Token(Token = "0x4000381")]
		X,
		[Token(Token = "0x4000382")]
		Y,
		[Token(Token = "0x4000383")]
		Z
	}
	[Token(Token = "0x2000069")]
	public class AxisTools
	{
		[Token(Token = "0x600045C")]
		[Address(RVA = "0xE41770", Offset = "0xE41770", VA = "0xE41770")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0xE41830", Offset = "0xE41830", VA = "0xE41830")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xE418DC", Offset = "0xE418DC", VA = "0xE418DC")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xE41AC4", Offset = "0xE41AC4", VA = "0xE41AC4")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xE419F8", Offset = "0xE419F8", VA = "0xE419F8")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xE41BE0", Offset = "0xE41BE0", VA = "0xE41BE0")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xE41E10", Offset = "0xE41E10", VA = "0xE41E10")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006A")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xE420D8", Offset = "0xE420D8", VA = "0xE420D8")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000036")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xE41E64", Offset = "0xE41E64", VA = "0xE41E64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xE42154", Offset = "0xE42154", VA = "0xE42154")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xE41E18", Offset = "0xE41E18", VA = "0xE41E18")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public enum BoneType
		{
			[Token(Token = "0x4000738")]
			Unassigned,
			[Token(Token = "0x4000739")]
			Spine,
			[Token(Token = "0x400073A")]
			Head,
			[Token(Token = "0x400073B")]
			Arm,
			[Token(Token = "0x400073C")]
			Leg,
			[Token(Token = "0x400073D")]
			Tail,
			[Token(Token = "0x400073E")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public enum BoneSide
		{
			[Token(Token = "0x4000740")]
			Center,
			[Token(Token = "0x4000741")]
			Left,
			[Token(Token = "0x4000742")]
			Right
		}

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xE423C8", Offset = "0xE423C8", VA = "0xE423C8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xE426C0", Offset = "0xE426C0", VA = "0xE426C0")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xE42908", Offset = "0xE42908", VA = "0xE42908")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xE4298C", Offset = "0xE4298C", VA = "0xE4298C")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xE42A3C", Offset = "0xE42A3C", VA = "0xE42A3C")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xE42570", Offset = "0xE42570", VA = "0xE42570")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xE42868", Offset = "0xE42868", VA = "0xE42868")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xE4327C", Offset = "0xE4327C", VA = "0xE4327C")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xE43094", Offset = "0xE43094", VA = "0xE43094")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xE43188", Offset = "0xE43188", VA = "0xE43188")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xE42C5C", Offset = "0xE42C5C", VA = "0xE42C5C")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xE42D10", Offset = "0xE42D10", VA = "0xE42D10")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xE42DC4", Offset = "0xE42DC4", VA = "0xE42DC4")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE42E78", Offset = "0xE42E78", VA = "0xE42E78")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE42F2C", Offset = "0xE42F2C", VA = "0xE42F2C")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xE42FE0", Offset = "0xE42FE0", VA = "0xE42FE0")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xE4349C", Offset = "0xE4349C", VA = "0xE4349C")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xE42B6C", Offset = "0xE42B6C", VA = "0xE42B6C")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xE43408", Offset = "0xE43408", VA = "0xE43408")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xE4350C", Offset = "0xE4350C", VA = "0xE4350C")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xE435E8", Offset = "0xE435E8", VA = "0xE435E8")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xE43388", Offset = "0xE43388", VA = "0xE43388")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xE4330C", Offset = "0xE4330C", VA = "0xE4330C")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class BipedReferences
	{
		[Token(Token = "0x2000107")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x170000A9")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x60008D8")]
				[Address(RVA = "0xE48600", Offset = "0xE48600", VA = "0xE48600")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x65001C", Offset = "0x65001C", VA = "0x65001C")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000038")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xE45144", Offset = "0xE45144", VA = "0xE45144", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public bool isEmpty
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xE45530", Offset = "0xE45530", VA = "0xE45530")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE45540", Offset = "0xE45540", VA = "0xE45540", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE4596C", Offset = "0xE4596C", VA = "0xE4596C", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE45D9C", Offset = "0xE45D9C", VA = "0xE45D9C")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE463B4", Offset = "0xE463B4", VA = "0xE463B4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xE45FEC", Offset = "0xE45FEC", VA = "0xE45FEC")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xE46B6C", Offset = "0xE46B6C", VA = "0xE46B6C")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xE46C64", Offset = "0xE46C64", VA = "0xE46C64")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xE471CC", Offset = "0xE471CC", VA = "0xE471CC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE46FC8", Offset = "0xE46FC8", VA = "0xE46FC8")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xE46E3C", Offset = "0xE46E3C", VA = "0xE46E3C")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE46D04", Offset = "0xE46D04", VA = "0xE46D04")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE470D0", Offset = "0xE470D0", VA = "0xE470D0")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE472CC", Offset = "0xE472CC", VA = "0xE472CC")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xE47DE0", Offset = "0xE47DE0", VA = "0xE47DE0")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xE47858", Offset = "0xE47858", VA = "0xE47858")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xE480D8", Offset = "0xE480D8", VA = "0xE480D8")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xE47BFC", Offset = "0xE47BFC", VA = "0xE47BFC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xE480E0", Offset = "0xE480E0", VA = "0xE480E0")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xE480E8", Offset = "0xE480E8", VA = "0xE480E8")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xE482AC", Offset = "0xE482AC", VA = "0xE482AC")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xE484C8", Offset = "0xE484C8", VA = "0xE484C8")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xE45F7C", Offset = "0xE45F7C", VA = "0xE45F7C")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xE48608", Offset = "0xE48608", VA = "0xE48608")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xE48610", Offset = "0xE48610", VA = "0xE48610")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xE48750", Offset = "0xE48750", VA = "0xE48750")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class Hierarchy
	{
		[Token(Token = "0x6000499")]
		[Address(RVA = "0xC41BA0", Offset = "0xC41BA0", VA = "0xC41BA0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xC41DA4", Offset = "0xC41DA4", VA = "0xC41DA4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xC41C38", Offset = "0xC41C38", VA = "0xC41C38")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xC41EC4", Offset = "0xC41EC4", VA = "0xC41EC4")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC41FF0", Offset = "0xC41FF0", VA = "0xC41FF0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC4229C", Offset = "0xC4229C", VA = "0xC4229C")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC423BC", Offset = "0xC423BC", VA = "0xC423BC")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xC42548", Offset = "0xC42548", VA = "0xC42548")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xC428E0", Offset = "0xC428E0", VA = "0xC428E0")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC426C8", Offset = "0xC426C8", VA = "0xC426C8")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC42A84", Offset = "0xC42A84", VA = "0xC42A84")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public enum InterpolationMode
	{
		[Token(Token = "0x40003AF")]
		None,
		[Token(Token = "0x40003B0")]
		InOutCubic,
		[Token(Token = "0x40003B1")]
		InOutQuintic,
		[Token(Token = "0x40003B2")]
		InOutSine,
		[Token(Token = "0x40003B3")]
		InQuintic,
		[Token(Token = "0x40003B4")]
		InQuartic,
		[Token(Token = "0x40003B5")]
		InCubic,
		[Token(Token = "0x40003B6")]
		InQuadratic,
		[Token(Token = "0x40003B7")]
		InElastic,
		[Token(Token = "0x40003B8")]
		InElasticSmall,
		[Token(Token = "0x40003B9")]
		InElasticBig,
		[Token(Token = "0x40003BA")]
		InSine,
		[Token(Token = "0x40003BB")]
		InBack,
		[Token(Token = "0x40003BC")]
		OutQuintic,
		[Token(Token = "0x40003BD")]
		OutQuartic,
		[Token(Token = "0x40003BE")]
		OutCubic,
		[Token(Token = "0x40003BF")]
		OutInCubic,
		[Token(Token = "0x40003C0")]
		OutInQuartic,
		[Token(Token = "0x40003C1")]
		OutElastic,
		[Token(Token = "0x40003C2")]
		OutElasticSmall,
		[Token(Token = "0x40003C3")]
		OutElasticBig,
		[Token(Token = "0x40003C4")]
		OutSine,
		[Token(Token = "0x40003C5")]
		OutBack,
		[Token(Token = "0x40003C6")]
		OutBackCubic,
		[Token(Token = "0x40003C7")]
		OutBackQuartic,
		[Token(Token = "0x40003C8")]
		BackInCubic,
		[Token(Token = "0x40003C9")]
		BackInQuartic
	}
	[Token(Token = "0x2000071")]
	public class Interp
	{
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC42A8C", Offset = "0xC42A8C", VA = "0xC42A8C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC434FC", Offset = "0xC434FC", VA = "0xC434FC")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC43604", Offset = "0xC43604", VA = "0xC43604")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC42DFC", Offset = "0xC42DFC", VA = "0xC42DFC")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xC42E08", Offset = "0xC42E08", VA = "0xC42E08")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xC42E30", Offset = "0xC42E30", VA = "0xC42E30")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xC42E6C", Offset = "0xC42E6C", VA = "0xC42E6C")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xC42E84", Offset = "0xC42E84", VA = "0xC42E84")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xC42E98", Offset = "0xC42E98", VA = "0xC42E98")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xC42EAC", Offset = "0xC42EAC", VA = "0xC42EAC")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xC42EBC", Offset = "0xC42EBC", VA = "0xC42EBC")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xC42F04", Offset = "0xC42F04", VA = "0xC42F04")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xC42F3C", Offset = "0xC42F3C", VA = "0xC42F3C")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xC42F64", Offset = "0xC42F64", VA = "0xC42F64")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC43700", Offset = "0xC43700", VA = "0xC43700")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xC42F98", Offset = "0xC42F98", VA = "0xC42F98")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC42FC0", Offset = "0xC42FC0", VA = "0xC42FC0")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC42FF0", Offset = "0xC42FF0", VA = "0xC42FF0")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC43024", Offset = "0xC43024", VA = "0xC43024")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC43068", Offset = "0xC43068", VA = "0xC43068")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC430CC", Offset = "0xC430CC", VA = "0xC430CC")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC43130", Offset = "0xC43130", VA = "0xC43130")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC43184", Offset = "0xC43184", VA = "0xC43184")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC431D8", Offset = "0xC431D8", VA = "0xC431D8")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC43270", Offset = "0xC43270", VA = "0xC43270")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC43304", Offset = "0xC43304", VA = "0xC43304")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xC43734", Offset = "0xC43734", VA = "0xC43734")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xC433A8", Offset = "0xC433A8", VA = "0xC433A8")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xC4348C", Offset = "0xC4348C", VA = "0xC4348C")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xC434BC", Offset = "0xC434BC", VA = "0xC434BC")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC4381C", Offset = "0xC4381C", VA = "0xC4381C")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xC43824", Offset = "0xC43824", VA = "0xC43824")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xC43894", Offset = "0xC43894", VA = "0xC43894")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000073")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xC43904", Offset = "0xC43904", VA = "0xC43904")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC43960", Offset = "0xC43960", VA = "0xC43960")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC43A34", Offset = "0xC43A34", VA = "0xC43A34")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC43978", Offset = "0xC43978", VA = "0xC43978")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC43A4C", Offset = "0xC43A4C", VA = "0xC43A4C")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC43AF0", Offset = "0xC43AF0", VA = "0xC43AF0")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC43B1C", Offset = "0xC43B1C", VA = "0xC43B1C")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC43B6C", Offset = "0xC43B6C", VA = "0xC43B6C")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC43BD8", Offset = "0xC43BD8", VA = "0xC43BD8")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC43CD0", Offset = "0xC43CD0", VA = "0xC43CD0")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC43DAC", Offset = "0xC43DAC", VA = "0xC43DAC")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC43E0C", Offset = "0xC43E0C", VA = "0xC43E0C")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000074")]
	public static class QuaTools
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC43E3C", Offset = "0xC43E3C", VA = "0xC43E3C")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC43F88", Offset = "0xC43F88", VA = "0xC43F88")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC440D4", Offset = "0xC440D4", VA = "0xC440D4")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC441E8", Offset = "0xC441E8", VA = "0xC441E8")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xC36740", Offset = "0xC36740", VA = "0xC36740")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC442FC", Offset = "0xC442FC", VA = "0xC442FC")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC3ABEC", Offset = "0xC3ABEC", VA = "0xC3ABEC")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC443CC", Offset = "0xC443CC", VA = "0xC443CC")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xC44650", Offset = "0xC44650", VA = "0xC44650")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC44864", Offset = "0xC44864", VA = "0xC44864")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC449E4", Offset = "0xC449E4", VA = "0xC449E4")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}
	}
	[Token(Token = "0x2000075")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x1700003A")]
		public static T instance
		{
			[Token(Token = "0x60004DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DD")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60004DE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F81C", Offset = "0x73F81C")]
		public bool fixTransforms;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700003B")]
		private bool animatePhysics
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xC44C8C", Offset = "0xC44C8C", VA = "0xC44C8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		private bool isAnimated
		{
			[Token(Token = "0x60004EA")]
			[Address(RVA = "0xC44F90", Offset = "0xC44F90", VA = "0xC44F90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC44B54", Offset = "0xC44B54", VA = "0xC44B54")]
		public void Disable()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC44BEC", Offset = "0xC44BEC", VA = "0xC44BEC", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC44BF0", Offset = "0xC44BF0", VA = "0xC44BF0", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC44BF4", Offset = "0xC44BF4", VA = "0xC44BF4", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC44BF8", Offset = "0xC44BF8", VA = "0xC44BF8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC44C88", Offset = "0xC44C88", VA = "0xC44C88")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC44C30", Offset = "0xC44C30", VA = "0xC44C30")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC44F40", Offset = "0xC44F40", VA = "0xC44F40")]
		private void Update()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC44D7C", Offset = "0xC44D7C", VA = "0xC44D7C")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xC4504C", Offset = "0xC4504C", VA = "0xC4504C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xC450A8", Offset = "0xC450A8", VA = "0xC450A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xC45108", Offset = "0xC45108", VA = "0xC45108")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xC39228", Offset = "0xC39228", VA = "0xC39228")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xC45150", Offset = "0xC45150", VA = "0xC45150")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xC45208", Offset = "0xC45208", VA = "0xC45208")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC452C0", Offset = "0xC452C0", VA = "0xC452C0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC45378", Offset = "0xC45378", VA = "0xC45378")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public static class V3Tools
	{
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC45380", Offset = "0xC45380", VA = "0xC45380")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xC45478", Offset = "0xC45478", VA = "0xC45478")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC45570", Offset = "0xC45570", VA = "0xC45570")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xC45668", Offset = "0xC45668", VA = "0xC45668")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xC45768", Offset = "0xC45768", VA = "0xC45768")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xC459A4", Offset = "0xC459A4", VA = "0xC459A4")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xC45BF4", Offset = "0xC45BF4", VA = "0xC45BF4")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xC45E04", Offset = "0xC45E04", VA = "0xC45E04")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000079")]
	public static class Warning
	{
		[Token(Token = "0x2000108")]
		public delegate void Logger(string message);

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xC45FE0", Offset = "0xC45FE0", VA = "0xC45FE0")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC33D44", Offset = "0xC33D44", VA = "0xC33D44")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200007A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E5AC", Offset = "0x73E5AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E5AC", Offset = "0x73E5AC")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xE493EC", Offset = "0xE493EC", VA = "0xE493EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745B28", Offset = "0x745B28")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xE49438", Offset = "0xE49438", VA = "0xE49438")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745B60", Offset = "0x745B60")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xE49484", Offset = "0xE49484", VA = "0xE49484")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745B98", Offset = "0x745B98")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xE494D0", Offset = "0xE494D0", VA = "0xE494D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745BD0", Offset = "0x745BD0")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xE4951C", Offset = "0xE4951C", VA = "0xE4951C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xE495BC", Offset = "0xE495BC", VA = "0xE495BC")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xE495DC", Offset = "0xE495DC", VA = "0xE495DC")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xE4960C", Offset = "0xE4960C", VA = "0xE4960C")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE4963C", Offset = "0xE4963C", VA = "0xE4963C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xE4967C", Offset = "0xE4967C", VA = "0xE4967C")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xE496C0", Offset = "0xE496C0", VA = "0xE496C0")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE496E4", Offset = "0xE496E4", VA = "0xE496E4")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE49708", Offset = "0xE49708", VA = "0xE49708")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE49734", Offset = "0xE49734", VA = "0xE49734")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE49764", Offset = "0xE49764", VA = "0xE49764")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE49794", Offset = "0xE49794", VA = "0xE49794")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE4953C", Offset = "0xE4953C", VA = "0xE4953C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE497C0", Offset = "0xE497C0", VA = "0xE497C0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE497CC", Offset = "0xE497CC", VA = "0xE497CC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE497D8", Offset = "0xE497D8", VA = "0xE497D8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xE49ACC", Offset = "0xE49ACC", VA = "0xE49ACC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xE49B7C", Offset = "0xE49B7C", VA = "0xE49B7C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE49ECC", Offset = "0xE49ECC", VA = "0xE49ECC", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE4A3D0", Offset = "0xE4A3D0", VA = "0xE4A3D0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xE4A404", Offset = "0xE4A404", VA = "0xE4A404")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700003D")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xE49984", Offset = "0xE49984", VA = "0xE49984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000517")]
			[Address(RVA = "0xE4A5CC", Offset = "0xE4A5CC", VA = "0xE4A5CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE49D50", Offset = "0xE49D50", VA = "0xE49D50")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xE4A484", Offset = "0xE4A484", VA = "0xE4A484")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public abstract class Constraint
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x1700003F")]
		public bool isValid
		{
			[Token(Token = "0x600051A")]
			[Address(RVA = "0xE4ABD8", Offset = "0xE4ABD8", VA = "0xE4ABD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600051B")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE4AC48", Offset = "0xE4AC48", VA = "0xE4AC48")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE4AC50", Offset = "0xE4AC50", VA = "0xE4AC50", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE4AD60", Offset = "0xE4AD60", VA = "0xE4AD60")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE4AD68", Offset = "0xE4AD68", VA = "0xE4AD68")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000040")]
		private bool positionChanged
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xE4AF38", Offset = "0xE4AF38", VA = "0xE4AF38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xE4AD94", Offset = "0xE4AD94", VA = "0xE4AD94", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xE4AFF4", Offset = "0xE4AFF4", VA = "0xE4AFF4")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xE4AFFC", Offset = "0xE4AFFC", VA = "0xE4AFFC")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xE4B028", Offset = "0xE4B028", VA = "0xE4B028", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xE4B154", Offset = "0xE4B154", VA = "0xE4B154")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xE4B15C", Offset = "0xE4B15C", VA = "0xE4B15C")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000041")]
		private bool rotationChanged
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0xE4B330", Offset = "0xE4B330", VA = "0xE4B330")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xE4B188", Offset = "0xE4B188", VA = "0xE4B188", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xE4B400", Offset = "0xE4B400", VA = "0xE4B400")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xE4B408", Offset = "0xE4B408", VA = "0xE4B408")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class Constraints
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F854", Offset = "0x73F854")]
		public float positionWeight;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F86C", Offset = "0x73F86C")]
		public float rotationWeight;

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xE4B434", Offset = "0xE4B434", VA = "0xE4B434")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xE49E74", Offset = "0xE49E74", VA = "0xE49E74")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xE4A068", Offset = "0xE4A068", VA = "0xE4A068")]
		public void Update()
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xE4A798", Offset = "0xE4A798", VA = "0xE4A798")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class Finger
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F884", Offset = "0x73F884")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73F884", Offset = "0x73F884")]
		public float weight;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F8D8", Offset = "0x73F8D8")]
		public Transform bone1;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F910", Offset = "0x73F910")]
		public Transform bone2;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F948", Offset = "0x73F948")]
		public Transform bone3;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F980", Offset = "0x73F980")]
		public Transform tip;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73F9B8", Offset = "0x73F9B8")]
		public Transform target;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73F9F0", Offset = "0x73F9F0")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKSolverLimb solver;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x17000042")]
		public bool initiated
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xE5277C", Offset = "0xE5277C", VA = "0xE5277C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745C08", Offset = "0x745C08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xE52784", Offset = "0xE52784", VA = "0xE52784")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745C18", Offset = "0x745C18")]
			private set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xE52790", Offset = "0xE52790", VA = "0xE52790")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xE527B4", Offset = "0xE527B4", VA = "0xE527B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xE527D8", Offset = "0xE527D8", VA = "0xE527D8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xE527FC", Offset = "0xE527FC", VA = "0xE527FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xE52820", Offset = "0xE52820", VA = "0xE52820")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xE52920", Offset = "0xE52920", VA = "0xE52920")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xE52B94", Offset = "0xE52B94", VA = "0xE52B94")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xE52C64", Offset = "0xE52C64", VA = "0xE52C64")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xE52F20", Offset = "0xE52F20", VA = "0xE52F20")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FA00", Offset = "0x73FA00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FA00", Offset = "0x73FA00")]
		public float weight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73FA54", Offset = "0x73FA54")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000045")]
		public bool initiated
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xE52F30", Offset = "0xE52F30", VA = "0xE52F30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745C28", Offset = "0x745C28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xE52F38", Offset = "0xE52F38", VA = "0xE52F38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745C38", Offset = "0x745C38")]
			private set
			{
			}
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xE52F44", Offset = "0xE52F44", VA = "0xE52F44")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xE52FD8", Offset = "0xE52FD8", VA = "0xE52FD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745C48", Offset = "0x745C48")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xE53304", Offset = "0xE53304", VA = "0xE53304")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xE53478", Offset = "0xE53478", VA = "0xE53478")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xE531F8", Offset = "0xE531F8", VA = "0xE531F8")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xE535FC", Offset = "0xE535FC", VA = "0xE535FC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xE536C4", Offset = "0xE536C4", VA = "0xE536C4")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xE53754", Offset = "0xE53754", VA = "0xE53754")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xE537C8", Offset = "0xE537C8", VA = "0xE537C8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xE537CC", Offset = "0xE537CC", VA = "0xE537CC", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xE537D0", Offset = "0xE537D0", VA = "0xE537D0")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x2000109")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FA64", Offset = "0x73FA64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FA64", Offset = "0x73FA64")]
		public float weight;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FAB8", Offset = "0x73FAB8")]
		public Grounding solver;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000547")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xE54814", Offset = "0xE54814", VA = "0xE54814")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xE54AF0", Offset = "0xE54AF0", VA = "0xE54AF0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xE5495C", Offset = "0xE5495C", VA = "0xE5495C")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xE54B24", Offset = "0xE54B24", VA = "0xE54B24")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054C")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600054D")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xE54D30", Offset = "0xE54D30", VA = "0xE54D30")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E60C", Offset = "0x73E60C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E60C", Offset = "0x73E60C")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FAF0", Offset = "0x73FAF0")]
		public BipedIK ik;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FB28", Offset = "0x73FB28")]
		public float spineBend;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FB60", Offset = "0x73FB60")]
		public float spineSpeed;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE550A0", Offset = "0xE550A0", VA = "0xE550A0", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745C80", Offset = "0x745C80")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xE550EC", Offset = "0xE550EC", VA = "0xE550EC", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745CB8", Offset = "0x745CB8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xE55138", Offset = "0xE55138", VA = "0xE55138", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xE55250", Offset = "0xE55250", VA = "0xE55250")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xE55304", Offset = "0xE55304", VA = "0xE55304")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE553B8", Offset = "0xE553B8", VA = "0xE553B8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE55900", Offset = "0xE55900", VA = "0xE55900")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xE55958", Offset = "0xE55958", VA = "0xE55958")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xE5612C", Offset = "0xE5612C", VA = "0xE5612C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xE56298", Offset = "0xE56298", VA = "0xE56298")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xE56428", Offset = "0xE56428", VA = "0xE56428")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xE565A0", Offset = "0xE565A0", VA = "0xE565A0")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E66C", Offset = "0x73E66C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E66C", Offset = "0x73E66C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		public class SpineEffector
		{
			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742254", Offset = "0x742254")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74228C", Offset = "0x74228C")]
			public float horizontalWeight;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7422C4", Offset = "0x7422C4")]
			public float verticalWeight;

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xE57430", Offset = "0xE57430", VA = "0xE57430")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FB98", Offset = "0x73FB98")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FBD0", Offset = "0x73FBD0")]
		public float spineBend;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FC08", Offset = "0x73FC08")]
		public float spineSpeed;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xE56620", Offset = "0xE56620", VA = "0xE56620")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745CF0", Offset = "0x745CF0")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xE5666C", Offset = "0xE5666C", VA = "0xE5666C", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745D28", Offset = "0x745D28")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xE566B8", Offset = "0xE566B8", VA = "0xE566B8", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745D60", Offset = "0x745D60")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xE56704", Offset = "0xE56704", VA = "0xE56704", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE56784", Offset = "0xE56784", VA = "0xE56784")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xE56820", Offset = "0xE56820", VA = "0xE56820")]
		private void Update()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xE56AE0", Offset = "0xE56AE0", VA = "0xE56AE0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xE56AEC", Offset = "0xE56AEC", VA = "0xE56AEC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xE568DC", Offset = "0xE568DC", VA = "0xE568DC")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xE56AF8", Offset = "0xE56AF8", VA = "0xE56AF8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xE56FB0", Offset = "0xE56FB0", VA = "0xE56FB0")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xE57174", Offset = "0xE57174", VA = "0xE57174")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xE572AC", Offset = "0xE572AC", VA = "0xE572AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xE573B0", Offset = "0xE573B0", VA = "0xE573B0")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E6CC", Offset = "0x73E6CC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E6CC", Offset = "0x73E6CC")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FC40", Offset = "0x73FC40")]
		public Transform pelvis;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FC78", Offset = "0x73FC78")]
		public Transform characterRoot;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FCB0", Offset = "0x73FCB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FCB0", Offset = "0x73FCB0")]
		public float rootRotationWeight;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FD04", Offset = "0x73FD04")]
		public float rootRotationSpeed;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FD3C", Offset = "0x73FD3C")]
		public float maxRootRotationAngle;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xE57440", Offset = "0xE57440", VA = "0xE57440", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745D98", Offset = "0x745D98")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xE5748C", Offset = "0xE5748C", VA = "0xE5748C", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745DD0", Offset = "0x745DD0")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xE574D8", Offset = "0xE574D8", VA = "0xE574D8", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xE574F0", Offset = "0xE574F0", VA = "0xE574F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xE576E0", Offset = "0xE576E0", VA = "0xE576E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xE577F0", Offset = "0xE577F0", VA = "0xE577F0")]
		private void Update()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xE57E40", Offset = "0xE57E40", VA = "0xE57E40")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xE58234", Offset = "0xE58234", VA = "0xE58234")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xE584AC", Offset = "0xE584AC", VA = "0xE584AC")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xE587D8", Offset = "0xE587D8", VA = "0xE587D8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xE58970", Offset = "0xE58970", VA = "0xE58970")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xE58B3C", Offset = "0xE58B3C", VA = "0xE58B3C")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E72C", Offset = "0x73E72C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E72C", Offset = "0x73E72C")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x200010B")]
		public struct Foot
		{
			[Token(Token = "0x4000748")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000749")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x650080", Offset = "0x650080", VA = "0x650080")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FD74", Offset = "0x73FD74")]
		public Grounding forelegSolver;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FDAC", Offset = "0x73FDAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FDAC", Offset = "0x73FDAC")]
		public float rootRotationWeight;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FE00", Offset = "0x73FE00")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FE00", Offset = "0x73FE00")]
		public float minRootRotation;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FE58", Offset = "0x73FE58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FE58", Offset = "0x73FE58")]
		public float maxRootRotation;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FEB0", Offset = "0x73FEB0")]
		public float rootRotationSpeed;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FEE8", Offset = "0x73FEE8")]
		public float maxLegOffset;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FF20", Offset = "0x73FF20")]
		public float maxForeLegOffset;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FF58", Offset = "0x73FF58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x73FF58", Offset = "0x73FF58")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FFAC", Offset = "0x73FFAC")]
		public Transform characterRoot;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x73FFE4", Offset = "0x73FFE4")]
		public Transform pelvis;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74001C", Offset = "0x74001C")]
		public Transform lastSpineBone;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740054", Offset = "0x740054")]
		public Transform head;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xE58BBC", Offset = "0xE58BBC", VA = "0xE58BBC", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745E08", Offset = "0x745E08")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xE58C08", Offset = "0xE58C08", VA = "0xE58C08", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745E40", Offset = "0x745E40")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xE58C54", Offset = "0xE58C54", VA = "0xE58C54", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xE58C88", Offset = "0xE58C88", VA = "0xE58C88")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xE58DBC", Offset = "0xE58DBC", VA = "0xE58DBC")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xE58F78", Offset = "0xE58F78", VA = "0xE58F78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xE58FF0", Offset = "0xE58FF0", VA = "0xE58FF0")]
		private void Update()
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xE590A8", Offset = "0xE590A8", VA = "0xE590A8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xE5939C", Offset = "0xE5939C", VA = "0xE5939C")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xE596E4", Offset = "0xE596E4", VA = "0xE596E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xE59830", Offset = "0xE59830", VA = "0xE59830")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xE59BCC", Offset = "0xE59BCC", VA = "0xE59BCC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xE5A3D0", Offset = "0xE5A3D0", VA = "0xE5A3D0")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xE5A694", Offset = "0xE5A694", VA = "0xE5A694")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xE5A7F8", Offset = "0xE5A7F8", VA = "0xE5A7F8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xE5AAE0", Offset = "0xE5AAE0", VA = "0xE5AAE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xE5AB24", Offset = "0xE5AB24", VA = "0xE5AB24")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xE5ACE8", Offset = "0xE5ACE8", VA = "0xE5ACE8")]
		public GrounderQuadruped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		public enum Quality
		{
			[Token(Token = "0x400074D")]
			Fastest,
			[Token(Token = "0x400074E")]
			Simple,
			[Token(Token = "0x400074F")]
			Best
		}

		[Token(Token = "0x200010D")]
		public class Leg
		{
			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7422FC", Offset = "0x7422FC")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74230C", Offset = "0x74230C")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x4000752")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x4000753")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74231C", Offset = "0x74231C")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x4000754")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74232C", Offset = "0x74232C")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x4000755")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74233C", Offset = "0x74233C")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x4000756")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74234C", Offset = "0x74234C")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000757")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74235C", Offset = "0x74235C")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000758")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000759")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x400075A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x400075B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x400075C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x400075D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x400075E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x170000AA")]
			public bool isGrounded
			{
				[Token(Token = "0x60008E3")]
				[Address(RVA = "0xF8FEAC", Offset = "0xF8FEAC", VA = "0xF8FEAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747964", Offset = "0x747964")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008E4")]
				[Address(RVA = "0xF8FEB4", Offset = "0xF8FEB4", VA = "0xF8FEB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747974", Offset = "0x747974")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AB")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60008E5")]
				[Address(RVA = "0xF8FEC0", Offset = "0xF8FEC0", VA = "0xF8FEC0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747984", Offset = "0x747984")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0xF8FECC", Offset = "0xF8FECC", VA = "0xF8FECC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747994", Offset = "0x747994")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AC")]
			public bool initiated
			{
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0xF8FED8", Offset = "0xF8FED8", VA = "0xF8FED8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479A4", Offset = "0x7479A4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0xF8FEE0", Offset = "0xF8FEE0", VA = "0xF8FEE0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479B4", Offset = "0x7479B4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AD")]
			public float heightFromGround
			{
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0xF8FEEC", Offset = "0xF8FEEC", VA = "0xF8FEEC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479C4", Offset = "0x7479C4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0xF8FEF4", Offset = "0xF8FEF4", VA = "0xF8FEF4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479D4", Offset = "0x7479D4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public Vector3 velocity
			{
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0xF8FEFC", Offset = "0xF8FEFC", VA = "0xF8FEFC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479E4", Offset = "0x7479E4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0xF8FF08", Offset = "0xF8FF08", VA = "0xF8FF08")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7479F4", Offset = "0x7479F4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public Transform transform
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0xF8FF14", Offset = "0xF8FF14", VA = "0xF8FF14")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A04", Offset = "0x747A04")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008EE")]
				[Address(RVA = "0xF8FF1C", Offset = "0xF8FF1C", VA = "0xF8FF1C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A14", Offset = "0x747A14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public float IKOffset
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0xF8FF24", Offset = "0xF8FF24", VA = "0xF8FF24")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A24", Offset = "0x747A24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60008F0")]
				[Address(RVA = "0xF8FF2C", Offset = "0xF8FF2C", VA = "0xF8FF2C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A34", Offset = "0x747A34")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0xF912E4", Offset = "0xF912E4", VA = "0xF912E4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000B2")]
			private float rootYOffset
			{
				[Token(Token = "0x60008FE")]
				[Address(RVA = "0xF915F0", Offset = "0xF915F0", VA = "0xF915F0")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xF8FF34", Offset = "0xF8FF34", VA = "0xF8FF34")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xF9001C", Offset = "0xF9001C", VA = "0xF9001C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xF90068", Offset = "0xF90068", VA = "0xF90068")]
			public void Reset()
			{
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xF9011C", Offset = "0xF9011C", VA = "0xF9011C")]
			public void Process()
			{
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xF90F60", Offset = "0xF90F60", VA = "0xF90F60")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xF9098C", Offset = "0xF9098C", VA = "0xF9098C")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0xF9146C", Offset = "0xF9146C", VA = "0xF9146C")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0xF90BE8", Offset = "0xF90BE8", VA = "0xF90BE8")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0xF90CF0", Offset = "0xF90CF0", VA = "0xF90CF0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0xF9156C", Offset = "0xF9156C", VA = "0xF9156C")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0xF91374", Offset = "0xF91374", VA = "0xF91374")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0xF91730", Offset = "0xF91730", VA = "0xF91730")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0xF9182C", Offset = "0xF9182C", VA = "0xF9182C")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x200010E")]
		public class Pelvis
		{
			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74236C", Offset = "0x74236C")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74237C", Offset = "0x74237C")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x4000765")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x4000766")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000B3")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x6000900")]
				[Address(RVA = "0xF918D4", Offset = "0xF918D4", VA = "0xF918D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A44", Offset = "0x747A44")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000901")]
				[Address(RVA = "0xF918E0", Offset = "0xF918E0", VA = "0xF918E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A54", Offset = "0x747A54")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			public float heightOffset
			{
				[Token(Token = "0x6000902")]
				[Address(RVA = "0xF918EC", Offset = "0xF918EC", VA = "0xF918EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A64", Offset = "0x747A64")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000903")]
				[Address(RVA = "0xF918F4", Offset = "0xF918F4", VA = "0xF918F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A74", Offset = "0x747A74")]
				private set
				{
				}
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0xF918FC", Offset = "0xF918FC", VA = "0xF918FC")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0xF91970", Offset = "0xF91970", VA = "0xF91970")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000906")]
			[Address(RVA = "0xF9190C", Offset = "0xF9190C", VA = "0xF9190C")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0xF91A24", Offset = "0xF91A24", VA = "0xF91A24")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0xF91C78", Offset = "0xF91C78", VA = "0xF91C78")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74009C", Offset = "0x74009C")]
		public LayerMask layers;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7400D4", Offset = "0x7400D4")]
		public float maxStep;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74010C", Offset = "0x74010C")]
		public float heightOffset;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740144", Offset = "0x740144")]
		public float footSpeed;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74017C", Offset = "0x74017C")]
		public float footRadius;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7401B4", Offset = "0x7401B4")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740200", Offset = "0x740200")]
		public float prediction;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740238", Offset = "0x740238")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740238", Offset = "0x740238")]
		public float footRotationWeight;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74028C", Offset = "0x74028C")]
		public float footRotationSpeed;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7402C4", Offset = "0x7402C4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7402C4", Offset = "0x7402C4")]
		public float maxFootRotationAngle;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74031C", Offset = "0x74031C")]
		public bool rotateSolver;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740354", Offset = "0x740354")]
		public float pelvisSpeed;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74038C", Offset = "0x74038C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74038C", Offset = "0x74038C")]
		public float pelvisDamper;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7403E0", Offset = "0x7403E0")]
		public float lowerPelvisWeight;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740418", Offset = "0x740418")]
		public float liftPelvisWeight;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740450", Offset = "0x740450")]
		public float rootSphereCastRadius;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740488", Offset = "0x740488")]
		public Quality quality;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7404C0", Offset = "0x7404C0")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7404D0", Offset = "0x7404D0")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7404E0", Offset = "0x7404E0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7404F0", Offset = "0x7404F0")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x740500", Offset = "0x740500")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000046")]
		public Leg[] legs
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xE5ADF8", Offset = "0xE5ADF8", VA = "0xE5ADF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745E78", Offset = "0x745E78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xE5AE00", Offset = "0xE5AE00", VA = "0xE5AE00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745E88", Offset = "0x745E88")]
			private set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xE5AE08", Offset = "0xE5AE08", VA = "0xE5AE08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745E98", Offset = "0x745E98")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xE5AE10", Offset = "0xE5AE10", VA = "0xE5AE10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745EA8", Offset = "0x745EA8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public bool isGrounded
		{
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xE5AE18", Offset = "0xE5AE18", VA = "0xE5AE18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745EB8", Offset = "0x745EB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xE5AE20", Offset = "0xE5AE20", VA = "0xE5AE20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745EC8", Offset = "0x745EC8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Transform root
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xE5AE2C", Offset = "0xE5AE2C", VA = "0xE5AE2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745ED8", Offset = "0x745ED8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xE5AE34", Offset = "0xE5AE34", VA = "0xE5AE34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745EE8", Offset = "0x745EE8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xE5AE3C", Offset = "0xE5AE3C", VA = "0xE5AE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745EF8", Offset = "0x745EF8")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xE5AE58", Offset = "0xE5AE58", VA = "0xE5AE58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x745F08", Offset = "0x745F08")]
			private set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public bool rootGrounded
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xE5AE78", Offset = "0xE5AE78", VA = "0xE5AE78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public Vector3 up
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xE5620C", Offset = "0xE5620C", VA = "0xE5620C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004D")]
		private bool useRootRotation
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xE5B3AC", Offset = "0xE5B3AC", VA = "0xE5B3AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xE5AED0", Offset = "0xE5AED0", VA = "0xE5AED0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xE5B2B8", Offset = "0xE5B2B8", VA = "0xE5B2B8")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xE55678", Offset = "0xE55678", VA = "0xE55678")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xE55EB0", Offset = "0xE55EB0", VA = "0xE55EB0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xE57C24", Offset = "0xE57C24", VA = "0xE57C24")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xE551B8", Offset = "0xE551B8", VA = "0xE551B8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xE5B394", Offset = "0xE5B394", VA = "0xE5B394")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xE5B47C", Offset = "0xE5B47C", VA = "0xE5B47C")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xE5B5E4", Offset = "0xE5B5E4", VA = "0xE5B5E4")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xE5B6E8", Offset = "0xE5B6E8", VA = "0xE5B6E8")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xE54DE8", Offset = "0xE54DE8", VA = "0xE54DE8")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E78C", Offset = "0x73E78C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E78C", Offset = "0x73E78C")]
	public class AimIK : IK
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xE48784", Offset = "0xE48784", VA = "0xE48784", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745F18", Offset = "0x745F18")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xE487D0", Offset = "0xE487D0", VA = "0xE487D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745F50", Offset = "0x745F50")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xE4881C", Offset = "0xE4881C", VA = "0xE4881C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745F88", Offset = "0x745F88")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xE48868", Offset = "0xE48868", VA = "0xE48868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745FC0", Offset = "0x745FC0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xE488B4", Offset = "0xE488B4", VA = "0xE488B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x745FF8", Offset = "0x745FF8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xE48900", Offset = "0xE48900", VA = "0xE48900", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xE48908", Offset = "0xE48908", VA = "0xE48908")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E7EC", Offset = "0x73E7EC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E7EC", Offset = "0x73E7EC")]
	public class CCDIK : IK
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xE4AA38", Offset = "0xE4AA38", VA = "0xE4AA38", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746030", Offset = "0x746030")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xE4AA84", Offset = "0xE4AA84", VA = "0xE4AA84", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746068", Offset = "0x746068")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xE4AAD0", Offset = "0xE4AAD0", VA = "0xE4AAD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7460A0", Offset = "0x7460A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xE4AB1C", Offset = "0xE4AB1C", VA = "0xE4AB1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7460D8", Offset = "0x7460D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xE4AB68", Offset = "0xE4AB68", VA = "0xE4AB68", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xE4AB70", Offset = "0xE4AB70", VA = "0xE4AB70")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E84C", Offset = "0x73E84C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E84C", Offset = "0x73E84C")]
	public class FABRIK : IK
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xE4B4A4", Offset = "0xE4B4A4", VA = "0xE4B4A4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746110", Offset = "0x746110")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xE4B4F0", Offset = "0xE4B4F0", VA = "0xE4B4F0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746148", Offset = "0x746148")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xE4B53C", Offset = "0xE4B53C", VA = "0xE4B53C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746180", Offset = "0x746180")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xE4B588", Offset = "0xE4B588", VA = "0xE4B588")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7461B8", Offset = "0x7461B8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xE4B5D4", Offset = "0xE4B5D4", VA = "0xE4B5D4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xE4B5DC", Offset = "0xE4B5DC", VA = "0xE4B5DC")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E8AC", Offset = "0x73E8AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E8AC", Offset = "0x73E8AC")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xE4BC70", Offset = "0xE4BC70", VA = "0xE4BC70", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7461F0", Offset = "0x7461F0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xE4BCBC", Offset = "0xE4BCBC", VA = "0xE4BCBC", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746228", Offset = "0x746228")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xE4BD08", Offset = "0xE4BD08", VA = "0xE4BD08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746260", Offset = "0x746260")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xE4BD54", Offset = "0xE4BD54", VA = "0xE4BD54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746298", Offset = "0x746298")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xE4BDA0", Offset = "0xE4BDA0", VA = "0xE4BDA0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xE4BDA8", Offset = "0xE4BDA8", VA = "0xE4BDA8")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E90C", Offset = "0x73E90C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E90C", Offset = "0x73E90C")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xE53838", Offset = "0xE53838", VA = "0xE53838", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7462D0", Offset = "0x7462D0")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xE53884", Offset = "0xE53884", VA = "0xE53884", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746308", Offset = "0x746308")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xE538D0", Offset = "0xE538D0", VA = "0xE538D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746340", Offset = "0x746340")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xE5391C", Offset = "0xE5391C", VA = "0xE5391C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746378", Offset = "0x746378")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xE53968", Offset = "0xE53968", VA = "0xE53968")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7463B0", Offset = "0x7463B0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xE539B4", Offset = "0xE539B4", VA = "0xE539B4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7463E8", Offset = "0x7463E8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xE53A00", Offset = "0xE53A00", VA = "0xE53A00")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xE53A24", Offset = "0xE53A24", VA = "0xE53A24", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xE53A2C", Offset = "0xE53A2C", VA = "0xE53A2C")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xE53BEC", Offset = "0xE53BEC", VA = "0xE53BEC")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xE53F40", Offset = "0xE53F40", VA = "0xE53F40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746420", Offset = "0x746420")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xE53F64", Offset = "0xE53F64", VA = "0xE53F64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746458", Offset = "0x746458")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xE5401C", Offset = "0xE5401C", VA = "0xE5401C")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60005C5")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xF94954", Offset = "0xF94954", VA = "0xF94954", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xF94A40", Offset = "0xF94A40", VA = "0xF94A40", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xF94C04", Offset = "0xF94C04", VA = "0xF94C04", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60005C9")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60005CA")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xF94C64", Offset = "0xF94C64", VA = "0xF94C64")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740510", Offset = "0x740510")]
		public IK[] IKComponents;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740548", Offset = "0x740548")]
		public Animator animator;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700004E")]
		private bool animatePhysics
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xF97C70", Offset = "0xF97C70", VA = "0xF97C70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xF97D0C", Offset = "0xF97D0C", VA = "0xF97D0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xF97D84", Offset = "0xF97D84", VA = "0xF97D84")]
		private void Update()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xF97E54", Offset = "0xF97E54", VA = "0xF97E54")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xF97E90", Offset = "0xF97E90", VA = "0xF97E90")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xF97DB8", Offset = "0xF97DB8", VA = "0xF97DB8")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xF97F24", Offset = "0xF97F24", VA = "0xF97F24")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E96C", Offset = "0x73E96C")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xC37964", Offset = "0xC37964", VA = "0xC37964", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746490", Offset = "0x746490")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xC379D0", Offset = "0xC379D0", VA = "0xC379D0", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7464C8", Offset = "0x7464C8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xC37A3C", Offset = "0xC37A3C", VA = "0xC37A3C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746500", Offset = "0x746500")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xC37A88", Offset = "0xC37A88", VA = "0xC37A88")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746538", Offset = "0x746538")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xC37AD4", Offset = "0xC37AD4", VA = "0xC37AD4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xC37ADC", Offset = "0xC37ADC", VA = "0xC37ADC")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73E9A4", Offset = "0x73E9A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73E9A4", Offset = "0x73E9A4")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xC37B44", Offset = "0xC37B44", VA = "0xC37B44", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746570", Offset = "0x746570")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xC37B90", Offset = "0xC37B90", VA = "0xC37B90", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7465A8", Offset = "0x7465A8")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xC37BDC", Offset = "0xC37BDC", VA = "0xC37BDC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7465E0", Offset = "0x7465E0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xC37C28", Offset = "0xC37C28", VA = "0xC37C28")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746618", Offset = "0x746618")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xC37C74", Offset = "0xC37C74", VA = "0xC37C74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xC37C7C", Offset = "0xC37C7C", VA = "0xC37C7C")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EA04", Offset = "0x73EA04")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EA04", Offset = "0x73EA04")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xC37CE4", Offset = "0xC37CE4", VA = "0xC37CE4", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746650", Offset = "0x746650")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xC37D30", Offset = "0xC37D30", VA = "0xC37D30", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746688", Offset = "0x746688")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xC37D7C", Offset = "0xC37D7C", VA = "0xC37D7C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7466C0", Offset = "0x7466C0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0xC37DC8", Offset = "0xC37DC8", VA = "0xC37DC8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7466F8", Offset = "0x7466F8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xC37E14", Offset = "0xC37E14", VA = "0xC37E14", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xC37E1C", Offset = "0xC37E1C", VA = "0xC37E1C")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EA64", Offset = "0x73EA64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EA64", Offset = "0x73EA64")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xC4010C", Offset = "0xC4010C", VA = "0xC4010C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746730", Offset = "0x746730")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xC40158", Offset = "0xC40158", VA = "0xC40158", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746768", Offset = "0x746768")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xC401A4", Offset = "0xC401A4", VA = "0xC401A4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7467A0", Offset = "0x7467A0")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xC401F0", Offset = "0xC401F0", VA = "0xC401F0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7467D8", Offset = "0x7467D8")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xC4023C", Offset = "0xC4023C", VA = "0xC4023C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xC40244", Offset = "0xC40244", VA = "0xC40244")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EAC4", Offset = "0x73EAC4")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x200010F")]
		public class References
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x400076B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x400076C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x170000B5")]
			public bool isFilled
			{
				[Token(Token = "0x600090A")]
				[Address(RVA = "0xC4136C", Offset = "0xC4136C", VA = "0xC4136C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000B6")]
			public bool isEmpty
			{
				[Token(Token = "0x600090B")]
				[Address(RVA = "0xC40EF0", Offset = "0xC40EF0", VA = "0xC40EF0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0xC41758", Offset = "0xC41758", VA = "0xC41758")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xC40AD8", Offset = "0xC40AD8", VA = "0xC40AD8")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0xC41750", Offset = "0xC41750", VA = "0xC41750")]
			public References()
			{
			}
		}

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0x740580", Offset = "0x740580")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740580", Offset = "0x740580")]
		public References references;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7405FC", Offset = "0x7405FC")]
		public IKSolverVR solver;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xC4098C", Offset = "0xC4098C", VA = "0xC4098C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746810", Offset = "0x746810")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xC409F8", Offset = "0xC409F8", VA = "0xC409F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746848", Offset = "0x746848")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xC40A64", Offset = "0xC40A64", VA = "0xC40A64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746880", Offset = "0x746880")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xC40AB0", Offset = "0xC40AB0", VA = "0xC40AB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7468B8", Offset = "0x7468B8")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xC40E4C", Offset = "0xC40E4C", VA = "0xC40E4C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7468F0", Offset = "0x7468F0")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xC40E74", Offset = "0xC40E74", VA = "0xC40E74", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xC40E7C", Offset = "0xC40E7C", VA = "0xC40E7C", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xC416C8", Offset = "0xC416C8", VA = "0xC416C8")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740634", Offset = "0x740634")]
		public float pull;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74064C", Offset = "0x74064C")]
		public float pin;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xE4B644", Offset = "0xE4B644", VA = "0xE4B644")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xE4B710", Offset = "0xE4B710", VA = "0xE4B710")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xE4B730", Offset = "0xE4B730", VA = "0xE4B730")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xE4BB0C", Offset = "0xE4BB0C", VA = "0xE4BB0C")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xE4B808", Offset = "0xE4B808", VA = "0xE4B808")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xE4BC08", Offset = "0xE4BC08", VA = "0xE4BC08")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xE4BE10", Offset = "0xE4BE10", VA = "0xE4BE10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xE4C380", Offset = "0xE4C380", VA = "0xE4C380")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xE4C544", Offset = "0xE4C544", VA = "0xE4C544")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xE4C640", Offset = "0xE4C640", VA = "0xE4C640")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000110")]
		public class BendBone
		{
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74238C", Offset = "0x74238C")]
			public Transform transform;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7423C4", Offset = "0x7423C4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7423C4", Offset = "0x7423C4")]
			public float weight;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xE4F710", Offset = "0xE4F710", VA = "0xE4F710")]
			public BendBone()
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0xE4F790", Offset = "0xE4F790", VA = "0xE4F790")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0xE4CE00", Offset = "0xE4CE00", VA = "0xE4CE00")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0xE4D200", Offset = "0xE4D200", VA = "0xE4D200")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740664", Offset = "0x740664")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x74069C", Offset = "0x74069C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74069C", Offset = "0x74069C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74069C", Offset = "0x74069C")]
		public float positionWeight;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740714", Offset = "0x740714")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740714", Offset = "0x740714")]
		public float bodyWeight;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740768", Offset = "0x740768")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740768", Offset = "0x740768")]
		public float thighWeight;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7407BC", Offset = "0x7407BC")]
		public bool handsPullBody;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7407F4", Offset = "0x7407F4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7407F4", Offset = "0x7407F4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7407F4", Offset = "0x7407F4")]
		public float rotationWeight;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74086C", Offset = "0x74086C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74086C", Offset = "0x74086C")]
		public float bodyClampWeight;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7408C0", Offset = "0x7408C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7408C0", Offset = "0x7408C0")]
		public float headClampWeight;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740914", Offset = "0x740914")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740914", Offset = "0x740914")]
		public float bendWeight;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740968", Offset = "0x740968")]
		public BendBone[] bendBones;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x7409A0", Offset = "0x7409A0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7409A0", Offset = "0x7409A0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7409A0", Offset = "0x7409A0")]
		public float CCDWeight;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740A18", Offset = "0x740A18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740A18", Offset = "0x740A18")]
		public float roll;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740A6C", Offset = "0x740A6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740A6C", Offset = "0x740A6C")]
		public float damper;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740AC4", Offset = "0x740AC4")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x740AFC", Offset = "0x740AFC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740AFC", Offset = "0x740AFC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740AFC", Offset = "0x740AFC")]
		public float postStretchWeight;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740B74", Offset = "0x740B74")]
		public float maxStretch;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740BAC", Offset = "0x740BAC")]
		public float stretchDamper;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740BE4", Offset = "0x740BE4")]
		public bool fixHead;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740C1C", Offset = "0x740C1C")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0x740C54", Offset = "0x740C54")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740C8C", Offset = "0x740C8C")]
		public float chestDirectionWeight;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xE4C648", Offset = "0xE4C648", VA = "0xE4C648")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xE4C980", Offset = "0xE4C980", VA = "0xE4C980")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xE4CE38", Offset = "0xE4CE38", VA = "0xE4CE38")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xE4D228", Offset = "0xE4D228", VA = "0xE4D228")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xE4DBC4", Offset = "0xE4DBC4", VA = "0xE4DBC4")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xE4DF18", Offset = "0xE4DF18", VA = "0xE4DF18")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xE4E2C4", Offset = "0xE4E2C4", VA = "0xE4E2C4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xE4ED5C", Offset = "0xE4ED5C", VA = "0xE4ED5C")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xE4D8E8", Offset = "0xE4D8E8", VA = "0xE4D8E8")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xE4EF88", Offset = "0xE4EF88", VA = "0xE4EF88")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xE4EC10", Offset = "0xE4EC10", VA = "0xE4EC10")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xE4EA74", Offset = "0xE4EA74", VA = "0xE4EA74")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xE4F304", Offset = "0xE4F304", VA = "0xE4F304")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xE4F590", Offset = "0xE4F590", VA = "0xE4F590")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x2000111")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742438", Offset = "0x742438")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742448", Offset = "0x742448")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000B7")]
			public float nominalDistance
			{
				[Token(Token = "0x6000912")]
				[Address(RVA = "0xE5270C", Offset = "0xE5270C", VA = "0xE5270C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A84", Offset = "0x747A84")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000913")]
				[Address(RVA = "0xE52714", Offset = "0xE52714", VA = "0xE52714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747A94", Offset = "0x747A94")]
				private set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			public bool isRigid
			{
				[Token(Token = "0x6000914")]
				[Address(RVA = "0xE5271C", Offset = "0xE5271C", VA = "0xE5271C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AA4", Offset = "0x747AA4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000915")]
				[Address(RVA = "0xE52724", Offset = "0xE52724", VA = "0xE52724")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AB4", Offset = "0x747AB4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0xE52730", Offset = "0xE52730", VA = "0xE52730")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0xE503EC", Offset = "0xE503EC", VA = "0xE503EC")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0xE5094C", Offset = "0xE5094C", VA = "0xE5094C")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000919")]
			[Address(RVA = "0xE523F4", Offset = "0xE523F4", VA = "0xE523F4")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000112")]
		public enum Smoothing
		{
			[Token(Token = "0x400078C")]
			None,
			[Token(Token = "0x400078D")]
			Exponential,
			[Token(Token = "0x400078E")]
			Cubic
		}

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740CA4", Offset = "0x740CA4")]
		public float pin;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740CBC", Offset = "0x740CBC")]
		public float pull;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740CD4", Offset = "0x740CD4")]
		public float push;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740CEC", Offset = "0x740CEC")]
		public float pushParent;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D04", Offset = "0x740D04")]
		public float reach;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x40004B9")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xE4F834", Offset = "0xE4F834", VA = "0xE4F834")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xE4F900", Offset = "0xE4F900", VA = "0xE4F900")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xE4FA0C", Offset = "0xE4FA0C", VA = "0xE4FA0C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xE4FB30", Offset = "0xE4FB30", VA = "0xE4FB30")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xE4FC10", Offset = "0xE4FC10", VA = "0xE4FC10")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xE4FD18", Offset = "0xE4FD18", VA = "0xE4FD18")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xE50448", Offset = "0xE50448", VA = "0xE50448")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xE4FEB0", Offset = "0xE4FEB0", VA = "0xE4FEB0")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xE50B5C", Offset = "0xE50B5C", VA = "0xE50B5C")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xE50F10", Offset = "0xE50F10", VA = "0xE50F10")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xE51300", Offset = "0xE51300", VA = "0xE51300")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xE5188C", Offset = "0xE5188C", VA = "0xE5188C")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xE51E80", Offset = "0xE51E80", VA = "0xE51E80")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xE52120", Offset = "0xE52120", VA = "0xE52120")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xE51D78", Offset = "0xE51D78", VA = "0xE51D78")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xE51674", Offset = "0xE51674", VA = "0xE51674")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE51CF8", Offset = "0xE51CF8", VA = "0xE51CF8")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE52218", Offset = "0xE52218", VA = "0xE52218")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xE51C10", Offset = "0xE51C10", VA = "0xE51C10")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE52008", Offset = "0xE52008", VA = "0xE52008")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D1C", Offset = "0x740D1C")]
		public float weight;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x740D34", Offset = "0x740D34")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x1700004F")]
		public bool initiated
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0xF94E3C", Offset = "0xF94E3C", VA = "0xF94E3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746928", Offset = "0x746928")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0xF94E44", Offset = "0xF94E44", VA = "0xF94E44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746938", Offset = "0x746938")]
			private set
			{
			}
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xF94C6C", Offset = "0xF94C6C", VA = "0xF94C6C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xF94E50", Offset = "0xF94E50", VA = "0xF94E50")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xF94ED4", Offset = "0xF94ED4", VA = "0xF94ED4")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xF94F80", Offset = "0xF94F80", VA = "0xF94F80")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xF94F8C", Offset = "0xF94F8C", VA = "0xF94F8C")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xF954CC", Offset = "0xF954CC", VA = "0xF954CC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xF956FC", Offset = "0xF956FC", VA = "0xF956FC")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xF95BA0", Offset = "0xF95BA0", VA = "0xF95BA0")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xF95294", Offset = "0xF95294", VA = "0xF95294")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xF953B0", Offset = "0xF953B0", VA = "0xF953B0")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class IKEffector
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D44", Offset = "0x740D44")]
		public float positionWeight;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D5C", Offset = "0x740D5C")]
		public float rotationWeight;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x740D74", Offset = "0x740D74")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D84", Offset = "0x740D84")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000050")]
		public bool isEndEffector
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0xF96264", Offset = "0xF96264", VA = "0xF96264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746948", Offset = "0x746948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0xF9626C", Offset = "0xF9626C", VA = "0xF9626C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746958", Offset = "0x746958")]
			private set
			{
			}
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xF961F4", Offset = "0xF961F4", VA = "0xF961F4")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xF96278", Offset = "0xF96278", VA = "0xF96278")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xF9634C", Offset = "0xF9634C", VA = "0xF9634C")]
		public IKEffector()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xF96488", Offset = "0xF96488", VA = "0xF96488")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xF965E0", Offset = "0xF965E0", VA = "0xF965E0")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xF968D4", Offset = "0xF968D4", VA = "0xF968D4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xF96B6C", Offset = "0xF96B6C", VA = "0xF96B6C")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xF96CB4", Offset = "0xF96CB4", VA = "0xF96CB4")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xF96D60", Offset = "0xF96D60", VA = "0xF96D60")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xF973BC", Offset = "0xF973BC", VA = "0xF973BC")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xF9742C", Offset = "0xF9742C", VA = "0xF9742C")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xF9763C", Offset = "0xF9763C", VA = "0xF9763C")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xF97980", Offset = "0xF97980", VA = "0xF97980")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		public class BoneMap
		{
			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x400079A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x400079B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x400079C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x400079D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x400079E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x400079F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40007A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40007A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40007A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40007A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40007A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000B9")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x600091B")]
				[Address(RVA = "0xF981A4", Offset = "0xF981A4", VA = "0xF981A4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000BA")]
			public bool isNodeBone
			{
				[Token(Token = "0x600091E")]
				[Address(RVA = "0xF98310", Offset = "0xF98310", VA = "0xF98310")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000BB")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x6000932")]
				[Address(RVA = "0xF98904", Offset = "0xF98904", VA = "0xF98904")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0xF98178", Offset = "0xF98178", VA = "0xF98178")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0xF98270", Offset = "0xF98270", VA = "0xF98270")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0xF982C0", Offset = "0xF982C0", VA = "0xF982C0")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x600091F")]
			[Address(RVA = "0xF98320", Offset = "0xF98320", VA = "0xF98320")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0xF98410", Offset = "0xF98410", VA = "0xF98410")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0xF98418", Offset = "0xF98418", VA = "0xF98418")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0xF985B8", Offset = "0xF985B8", VA = "0xF985B8")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0xF986C4", Offset = "0xF986C4", VA = "0xF986C4")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0xF98754", Offset = "0xF98754", VA = "0xF98754")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x6000925")]
			[Address(RVA = "0xF98B28", Offset = "0xF98B28", VA = "0xF98B28")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0xF98B60", Offset = "0xF98B60", VA = "0xF98B60")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0xF98B98", Offset = "0xF98B98", VA = "0xF98B98")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0xF98BC0", Offset = "0xF98BC0", VA = "0xF98BC0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0xF98CEC", Offset = "0xF98CEC", VA = "0xF98CEC")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0xF99030", Offset = "0xF99030", VA = "0xF99030")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600092B")]
			[Address(RVA = "0xF99064", Offset = "0xF99064", VA = "0xF99064")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0xF99200", Offset = "0xF99200", VA = "0xF99200")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0xF99270", Offset = "0xF99270", VA = "0xF99270")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x600092E")]
			[Address(RVA = "0xF994BC", Offset = "0xF994BC", VA = "0xF994BC")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0xF996EC", Offset = "0xF996EC", VA = "0xF996EC")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0xF99808", Offset = "0xF99808", VA = "0xF99808")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xF98E34", Offset = "0xF98E34", VA = "0xF98E34")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xF9999C", Offset = "0xF9999C", VA = "0xF9999C")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xF97F2C", Offset = "0xF97F2C", VA = "0xF97F2C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xF97F34", Offset = "0xF97F34", VA = "0xF97F34", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xF97F38", Offset = "0xF97F38", VA = "0xF97F38")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xF98068", Offset = "0xF98068", VA = "0xF98068")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xF98170", Offset = "0xF98170", VA = "0xF98170")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740D9C", Offset = "0x740D9C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xF999B4", Offset = "0xF999B4", VA = "0xF999B4", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xF99A54", Offset = "0xF99A54", VA = "0xF99A54")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xF99AD8", Offset = "0xF99AD8", VA = "0xF99AD8")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xF99B70", Offset = "0xF99B70", VA = "0xF99B70")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xF99B88", Offset = "0xF99B88", VA = "0xF99B88")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xF99BA4", Offset = "0xF99BA4", VA = "0xF99BA4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xF99C44", Offset = "0xF99C44", VA = "0xF99C44")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xF99C5C", Offset = "0xF99C5C", VA = "0xF99C5C")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009E")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public enum BoneMapType
		{
			[Token(Token = "0x40007A6")]
			Parent,
			[Token(Token = "0x40007A7")]
			Bone1,
			[Token(Token = "0x40007A8")]
			Bone2,
			[Token(Token = "0x40007A9")]
			Bone3
		}

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740DB4", Offset = "0x740DB4")]
		public float maintainRotationWeight;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740DCC", Offset = "0x740DCC")]
		public float weight;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xF99C80", Offset = "0xF99C80", VA = "0xF99C80", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xF99D04", Offset = "0xF99D04", VA = "0xF99D04")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xF99DD8", Offset = "0xF99DD8", VA = "0xF99DD8")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xF9A138", Offset = "0xF9A138", VA = "0xF9A138")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xF9A238", Offset = "0xF9A238", VA = "0xF9A238")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xF9A364", Offset = "0xF9A364", VA = "0xF9A364")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xF9A370", Offset = "0xF9A370", VA = "0xF9A370")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xF9A418", Offset = "0xF9A418", VA = "0xF9A418")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xF9A4D0", Offset = "0xF9A4D0", VA = "0xF9A4D0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xF9A748", Offset = "0xF9A748", VA = "0xF9A748")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xF9A800", Offset = "0xF9A800", VA = "0xF9A800")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740DE4", Offset = "0x740DE4")]
		public int iterations;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740DFC", Offset = "0x740DFC")]
		public float twistWeight;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xF9A96C", Offset = "0xF9A96C", VA = "0xF9A96C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xF9AC54", Offset = "0xF9AC54", VA = "0xF9AC54")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xF9AD70", Offset = "0xF9AD70", VA = "0xF9AD70")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xF9AEC0", Offset = "0xF9AEC0", VA = "0xF9AEC0")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xF9AED0", Offset = "0xF9AED0", VA = "0xF9AED0")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xF9AF40", Offset = "0xF9AF40", VA = "0xF9AF40")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xF9AFC8", Offset = "0xF9AFC8", VA = "0xF9AFC8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xF9B658", Offset = "0xF9B658", VA = "0xF9B658")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xF9B694", Offset = "0xF9B694", VA = "0xF9B694")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xF9B98C", Offset = "0xF9B98C", VA = "0xF9B98C")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xF9BD40", Offset = "0xF9BD40", VA = "0xF9BD40")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xF9BE34", Offset = "0xF9BE34", VA = "0xF9BE34")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xF9BEFC", Offset = "0xF9BEFC", VA = "0xF9BEFC")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A0")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000115")]
		public class Point
		{
			[Token(Token = "0x40007AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40007AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742458", Offset = "0x742458")]
			public float weight;

			[Token(Token = "0x40007AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40007AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40007AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40007AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x6000934")]
			[Address(RVA = "0xF9DA48", Offset = "0xF9DA48", VA = "0xF9DA48")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xF9DA98", Offset = "0xF9DA98", VA = "0xF9DA98")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0xF9DC20", Offset = "0xF9DC20", VA = "0xF9DC20")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0xF9DC58", Offset = "0xF9DC58", VA = "0xF9DC58")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0xF9DC90", Offset = "0xF9DC90", VA = "0xF9DC90")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xF9DCE0", Offset = "0xF9DCE0", VA = "0xF9DCE0")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0xF9D538", Offset = "0xF9D538", VA = "0xF9D538")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		public class Bone : Point
		{
			[Token(Token = "0x40007B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40007B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40007B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40007B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000BC")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0xF9CAFC", Offset = "0xF9CAFC", VA = "0xF9CAFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x600093C")]
				[Address(RVA = "0xF9CBF0", Offset = "0xF9CBF0", VA = "0xF9CBF0")]
				set
				{
				}
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xF9CC78", Offset = "0xF9CC78", VA = "0xF9CC78")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0xF9CF40", Offset = "0xF9CF40", VA = "0xF9CF40")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0xF9D21C", Offset = "0xF9D21C", VA = "0xF9D21C")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0xF9D48C", Offset = "0xF9D48C", VA = "0xF9D48C")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0xF9D4B4", Offset = "0xF9D4B4", VA = "0xF9D4B4")]
			public Bone()
			{
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0xF9D5B8", Offset = "0xF9D5B8", VA = "0xF9D5B8")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0xF9D650", Offset = "0xF9D650", VA = "0xF9D650")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000117")]
		public class Node : Point
		{
			[Token(Token = "0x40007B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40007B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40007B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x6000944")]
			[Address(RVA = "0xF9D9E4", Offset = "0xF9D9E4", VA = "0xF9D9E4")]
			public Node()
			{
			}

			[Token(Token = "0x6000945")]
			[Address(RVA = "0xF9D9E8", Offset = "0xF9D9E8", VA = "0xF9D9E8")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000946")]
			[Address(RVA = "0xF9DA10", Offset = "0xF9DA10", VA = "0xF9DA10")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x2000118")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x2000119")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x740E24", Offset = "0x740E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740E24", Offset = "0x740E24")]
		public float IKPositionWeight;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x740E78", Offset = "0x740E78")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000051")]
		public bool initiated
		{
			[Token(Token = "0x6000668")]
			[Address(RVA = "0xF9C540", Offset = "0xF9C540", VA = "0xF9C540")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746968", Offset = "0x746968")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000669")]
			[Address(RVA = "0xF9C548", Offset = "0xF9C548", VA = "0xF9C548")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746978", Offset = "0x746978")]
			private set
			{
			}
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xF9C1FC", Offset = "0xF9C1FC", VA = "0xF9C1FC")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xF94AB8", Offset = "0xF94AB8", VA = "0xF94AB8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xF949D8", Offset = "0xF949D8", VA = "0xF949D8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xF9C494", Offset = "0xF9C494", VA = "0xF9C494", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xF9C4A0", Offset = "0xF9C4A0", VA = "0xF9C4A0")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xF9C4AC", Offset = "0xF9C4AC", VA = "0xF9C4AC")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xF9C4B4", Offset = "0xF9C4B4", VA = "0xF9C4B4")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xF9C538", Offset = "0xF9C538", VA = "0xF9C538")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x600066A")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x600066B")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x600066C")]
		public abstract void FixTransforms();

		[Token(Token = "0x600066D")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x600066E")]
		protected abstract void OnInitiate();

		[Token(Token = "0x600066F")]
		protected abstract void OnUpdate();

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xF9C554", Offset = "0xF9C554", VA = "0xF9C554")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xF9C56C", Offset = "0xF9C56C", VA = "0xF9C56C")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xF9C6A4", Offset = "0xF9C6A4", VA = "0xF9C6A4")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xF9C75C", Offset = "0xF9C75C", VA = "0xF9C75C")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xF9CAE4", Offset = "0xF9CAE4", VA = "0xF9CAE4")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740EC0", Offset = "0x740EC0")]
		public float poleWeight;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740ED8", Offset = "0x740ED8")]
		public float clampWeight;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740EF0", Offset = "0x740EF0")]
		public int clampSmoothing;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000052")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0xF9DE80", Offset = "0xF9DE80", VA = "0xF9DE80")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0xF9DF4C", Offset = "0xF9DF4C", VA = "0xF9DF4C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000054")]
		protected override int minBones
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0xF9ECE8", Offset = "0xF9ECE8", VA = "0xF9ECE8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000055")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xF9F294", Offset = "0xF9F294", VA = "0xF9F294", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xF9DD80", Offset = "0xF9DD80", VA = "0xF9DD80")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xF9E018", Offset = "0xF9E018", VA = "0xF9E018", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xF9E2AC", Offset = "0xF9E2AC", VA = "0xF9E2AC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xF9EC2C", Offset = "0xF9EC2C", VA = "0xF9EC2C")]
		private void Solve()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xF9E854", Offset = "0xF9E854", VA = "0xF9E854")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xF9ECF0", Offset = "0xF9ECF0", VA = "0xF9ECF0")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xF9F314", Offset = "0xF9F314", VA = "0xF9F314")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xF9F424", Offset = "0xF9F424", VA = "0xF9F424")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xF9F4DC", Offset = "0xF9F4DC", VA = "0xF9F4DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xF9FAF4", Offset = "0xF9FAF4", VA = "0xF9FAF4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xFA0290", Offset = "0xFA0290", VA = "0xFA0290")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xFA09EC", Offset = "0xFA09EC", VA = "0xFA09EC")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A3")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000056")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0xFA1CA4", Offset = "0xFA1CA4", VA = "0xFA1CA4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xFA09F0", Offset = "0xFA09F0", VA = "0xFA09F0")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xFA1160", Offset = "0xFA1160", VA = "0xFA1160")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xFA1298", Offset = "0xFA1298", VA = "0xFA1298", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xFA1334", Offset = "0xFA1334", VA = "0xFA1334", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xFA1928", Offset = "0xFA1928", VA = "0xFA1928", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xFA1CAC", Offset = "0xFA1CAC", VA = "0xFA1CAC")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xFA0AC4", Offset = "0xFA0AC4", VA = "0xFA0AC4")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xFA1244", Offset = "0xFA1244", VA = "0xFA1244")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xFA1C3C", Offset = "0xFA1C3C", VA = "0xFA1C3C")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xFA0F84", Offset = "0xFA0F84", VA = "0xFA0F84")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xFA2528", Offset = "0xFA2528", VA = "0xFA2528")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xFA2630", Offset = "0xFA2630", VA = "0xFA2630")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xFA275C", Offset = "0xFA275C", VA = "0xFA275C")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xFA287C", Offset = "0xFA287C", VA = "0xFA287C")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xFA1658", Offset = "0xFA1658", VA = "0xFA1658")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xFA17C0", Offset = "0xFA17C0", VA = "0xFA17C0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xFA2A70", Offset = "0xFA2A70", VA = "0xFA2A70")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xFA1F84", Offset = "0xFA1F84", VA = "0xFA1F84")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xFA1234", Offset = "0xFA1234", VA = "0xFA1234")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xFA3224", Offset = "0xFA3224", VA = "0xFA3224")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xFA2C50", Offset = "0xFA2C50", VA = "0xFA2C50")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xFA1DC4", Offset = "0xFA1DC4", VA = "0xFA1DC4")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFA1EAC", Offset = "0xFA1EAC", VA = "0xFA1EAC")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xFA32F0", Offset = "0xFA32F0", VA = "0xFA32F0")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A4")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F08", Offset = "0x740F08")]
		public float rootPin;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xFA3364", Offset = "0xFA3364", VA = "0xFA3364", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xFA3C6C", Offset = "0xFA3C6C", VA = "0xFA3C6C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xFA3D0C", Offset = "0xFA3D0C", VA = "0xFA3D0C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFA3DAC", Offset = "0xFA3DAC", VA = "0xFA3DAC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFA3EB4", Offset = "0xFA3EB4", VA = "0xFA3EB4")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFA3F60", Offset = "0xFA3F60", VA = "0xFA3F60", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xFA44F8", Offset = "0xFA44F8", VA = "0xFA44F8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xFA46F0", Offset = "0xFA46F0", VA = "0xFA46F0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xFA45AC", Offset = "0xFA45AC", VA = "0xFA45AC")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xFA41BC", Offset = "0xFA41BC", VA = "0xFA41BC")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xFA478C", Offset = "0xFA478C", VA = "0xFA478C")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A5")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F20", Offset = "0x740F20")]
		public int iterations;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xFA4804", Offset = "0xFA4804", VA = "0xFA4804")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xFA4908", Offset = "0xFA4908", VA = "0xFA4908")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xFA496C", Offset = "0xFA496C", VA = "0xFA496C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xF96190", Offset = "0xF96190", VA = "0xF96190")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xF95208", Offset = "0xF95208", VA = "0xF95208")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xFA4AA0", Offset = "0xFA4AA0", VA = "0xFA4AA0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xFA4C20", Offset = "0xFA4C20", VA = "0xFA4C20", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xFA4D94", Offset = "0xFA4D94", VA = "0xFA4D94", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xFA4FA0", Offset = "0xFA4FA0", VA = "0xFA4FA0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xFA506C", Offset = "0xFA506C", VA = "0xFA506C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xFA5144", Offset = "0xFA5144", VA = "0xFA5144", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFA52B8", Offset = "0xFA52B8", VA = "0xFA52B8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFA5470", Offset = "0xFA5470", VA = "0xFA5470", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xFA56A8", Offset = "0xFA56A8", VA = "0xFA56A8", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xFA5994", Offset = "0xFA5994", VA = "0xFA5994", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xFA59E8", Offset = "0xFA59E8", VA = "0xFA59E8", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xFA5AD0", Offset = "0xFA5AD0", VA = "0xFA5AD0")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A6")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x4000536")]
		Body,
		[Token(Token = "0x4000537")]
		LeftShoulder,
		[Token(Token = "0x4000538")]
		RightShoulder,
		[Token(Token = "0x4000539")]
		LeftThigh,
		[Token(Token = "0x400053A")]
		RightThigh,
		[Token(Token = "0x400053B")]
		LeftHand,
		[Token(Token = "0x400053C")]
		RightHand,
		[Token(Token = "0x400053D")]
		LeftFoot,
		[Token(Token = "0x400053E")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x20000A7")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000540")]
		LeftArm,
		[Token(Token = "0x4000541")]
		RightArm,
		[Token(Token = "0x4000542")]
		LeftLeg,
		[Token(Token = "0x4000543")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F38", Offset = "0x740F38")]
		public float spineStiffness;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F50", Offset = "0x740F50")]
		public float pullBodyVertical;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F68", Offset = "0x740F68")]
		public float pullBodyHorizontal;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x740F80", Offset = "0x740F80")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000057")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xFA5BB0", Offset = "0xFA5BB0", VA = "0xFA5BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0xFA5BB8", Offset = "0xFA5BB8", VA = "0xFA5BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0xFA5BC0", Offset = "0xFA5BC0", VA = "0xFA5BC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xFA5BC8", Offset = "0xFA5BC8", VA = "0xFA5BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xFA5BD0", Offset = "0xFA5BD0", VA = "0xFA5BD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xFA5BD8", Offset = "0xFA5BD8", VA = "0xFA5BD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xFA5BE0", Offset = "0xFA5BE0", VA = "0xFA5BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xFA5BE8", Offset = "0xFA5BE8", VA = "0xFA5BE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xFA5BF0", Offset = "0xFA5BF0", VA = "0xFA5BF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xFA5BF8", Offset = "0xFA5BF8", VA = "0xFA5BF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0xFA5C38", Offset = "0xFA5C38", VA = "0xFA5C38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xFA5C78", Offset = "0xFA5C78", VA = "0xFA5C78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0xFA5CB8", Offset = "0xFA5CB8", VA = "0xFA5CB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0xFA5CF8", Offset = "0xFA5CF8", VA = "0xFA5CF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0xFA5D34", Offset = "0xFA5D34", VA = "0xFA5D34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xFA5D74", Offset = "0xFA5D74", VA = "0xFA5D74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0xFA5DB4", Offset = "0xFA5DB4", VA = "0xFA5DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xFA5DF4", Offset = "0xFA5DF4", VA = "0xFA5DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0xFA7D90", Offset = "0xFA7D90", VA = "0xFA7D90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746988", Offset = "0x746988")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0xFA7D9C", Offset = "0xFA7D9C", VA = "0xFA7D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746998", Offset = "0x746998")]
			private set
			{
			}
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xFA5E30", Offset = "0xFA5E30", VA = "0xFA5E30")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xFA5F44", Offset = "0xFA5F44", VA = "0xFA5F44")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xFA5E84", Offset = "0xFA5E84", VA = "0xFA5E84")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xFA6024", Offset = "0xFA6024", VA = "0xFA6024")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xF93584", Offset = "0xF93584", VA = "0xF93584")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFA60FC", Offset = "0xFA60FC", VA = "0xFA60FC")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFA61BC", Offset = "0xFA61BC", VA = "0xFA61BC")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFA6278", Offset = "0xFA6278", VA = "0xFA6278")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFA6334", Offset = "0xFA6334", VA = "0xFA6334")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xFA633C", Offset = "0xFA633C", VA = "0xFA633C")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xFA6378", Offset = "0xFA6378", VA = "0xFA6378")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFA6448", Offset = "0xFA6448", VA = "0xFA6448", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFA65DC", Offset = "0xFA65DC", VA = "0xFA65DC")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFA7698", Offset = "0xFA7698", VA = "0xFA7698")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xFA7B3C", Offset = "0xFA7B3C", VA = "0xFA7B3C")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFA7BA4", Offset = "0xFA7BA4", VA = "0xFA7BA4")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFA79B4", Offset = "0xFA79B4", VA = "0xFA79B4")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xFA7A78", Offset = "0xFA7A78", VA = "0xFA7A78")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xFA7DA8", Offset = "0xFA7DA8", VA = "0xFA7DA8")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xFA7E88", Offset = "0xFA7E88", VA = "0xFA7E88", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xFA7FD4", Offset = "0xFA7FD4", VA = "0xFA7FD4")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xFA8164", Offset = "0xFA8164", VA = "0xFA8164")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xFA8364", Offset = "0xFA8364", VA = "0xFA8364")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xFA8574", Offset = "0xFA8574", VA = "0xFA8574", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xFA88EC", Offset = "0xFA88EC", VA = "0xFA88EC", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xFA89F4", Offset = "0xFA89F4", VA = "0xFA89F4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700006A")]
		protected virtual int minBones
		{
			[Token(Token = "0x60006EF")]
			[Address(RVA = "0xFA9260", Offset = "0xFA9260", VA = "0xFA9260", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xFA9268", Offset = "0xFA9268", VA = "0xFA9268", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0xFA9270", Offset = "0xFA9270", VA = "0xFA9270", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60006F5")]
			[Address(RVA = "0xFA9280", Offset = "0xFA9280", VA = "0xFA9280", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700006E")]
		protected float positionOffset
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xFA01CC", Offset = "0xFA01CC", VA = "0xFA01CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xFA8A00", Offset = "0xFA8A00", VA = "0xFA8A00")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFA8B90", Offset = "0xFA8B90", VA = "0xFA8B90")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFA8CD8", Offset = "0xFA8CD8", VA = "0xFA8CD8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFA8D48", Offset = "0xFA8D48", VA = "0xFA8D48", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFA8DC4", Offset = "0xFA8DC4", VA = "0xFA8DC4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFA9154", Offset = "0xFA9154", VA = "0xFA9154", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFA915C", Offset = "0xFA915C", VA = "0xFA915C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xFA9278", Offset = "0xFA9278", VA = "0xFA9278", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xFA927C", Offset = "0xFA927C", VA = "0xFA927C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xF9F568", Offset = "0xF9F568", VA = "0xF9F568")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xF9FE28", Offset = "0xF9FE28", VA = "0xF9FE28")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xFA93C0", Offset = "0xFA93C0", VA = "0xFA93C0")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xF9F3A8", Offset = "0xF9F3A8", VA = "0xF9F3A8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AA")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740F90", Offset = "0x740F90")]
		public float IKRotationWeight;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xEA11C4", Offset = "0xEA11C4", VA = "0xEA11C4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xEA153C", Offset = "0xEA153C", VA = "0xEA153C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xEA15B0", Offset = "0xEA15B0", VA = "0xEA15B0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xEA170C", Offset = "0xEA170C", VA = "0xEA170C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xEA18A8", Offset = "0xEA18A8", VA = "0xEA18A8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xEA1904", Offset = "0xEA1904", VA = "0xEA1904", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xEA1960", Offset = "0xEA1960", VA = "0xEA1960", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xEA1CE0", Offset = "0xEA1CE0", VA = "0xEA1CE0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xEA1D0C", Offset = "0xEA1D0C", VA = "0xEA1D0C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xEA19C8", Offset = "0xEA19C8", VA = "0xEA19C8")]
		private void Read()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xEA1E10", Offset = "0xEA1E10", VA = "0xEA1E10")]
		private void Write()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xEA2360", Offset = "0xEA2360", VA = "0xEA2360")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x200011A")]
		public enum BendModifier
		{
			[Token(Token = "0x40007BA")]
			Animation,
			[Token(Token = "0x40007BB")]
			Target,
			[Token(Token = "0x40007BC")]
			Parent,
			[Token(Token = "0x40007BD")]
			Arm,
			[Token(Token = "0x40007BE")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200011B")]
		public struct AxisDirection
		{
			[Token(Token = "0x40007BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40007C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40007C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x6509D0", Offset = "0x6509D0", VA = "0x6509D0")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740FA8", Offset = "0x740FA8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740FC0", Offset = "0x740FC0")]
		public float bendModifierWeight;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x1700006F")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0xEA3C48", Offset = "0xEA3C48", VA = "0xEA3C48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xEA2560", Offset = "0xEA2560", VA = "0xEA2560")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xEA25B4", Offset = "0xEA25B4", VA = "0xEA25B4")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xEA26C8", Offset = "0xEA26C8", VA = "0xEA26C8", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xEA2D48", Offset = "0xEA2D48", VA = "0xEA2D48", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xEA38F0", Offset = "0xEA38F0", VA = "0xEA38F0", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xEA3A3C", Offset = "0xEA3A3C", VA = "0xEA3A3C")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xEA3BC0", Offset = "0xEA3BC0", VA = "0xEA3BC0")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xEA2A4C", Offset = "0xEA2A4C", VA = "0xEA2A4C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xEA2E78", Offset = "0xEA2E78", VA = "0xEA2E78")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x170000BD")]
			public Vector3 forward
			{
				[Token(Token = "0x6000954")]
				[Address(RVA = "0xEA5B24", Offset = "0xEA5B24", VA = "0xEA5B24")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000950")]
			[Address(RVA = "0xEA6288", Offset = "0xEA6288", VA = "0xEA6288")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000951")]
			[Address(RVA = "0xEA4ED4", Offset = "0xEA4ED4", VA = "0xEA4ED4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0xEA521C", Offset = "0xEA521C", VA = "0xEA521C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0xEA5F30", Offset = "0xEA5F30", VA = "0xEA5F30")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740FD8", Offset = "0x740FD8")]
		public float bodyWeight;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x740FF0", Offset = "0x740FF0")]
		public float headWeight;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741008", Offset = "0x741008")]
		public float eyesWeight;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741020", Offset = "0x741020")]
		public float clampWeight;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741038", Offset = "0x741038")]
		public float clampWeightHead;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741050", Offset = "0x741050")]
		public float clampWeightEyes;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741068", Offset = "0x741068")]
		public int clampSmoothing;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] headForwards;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000070")]
		private bool spineIsValid
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0xEA4600", Offset = "0xEA4600", VA = "0xEA4600")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0xEA47E8", Offset = "0xEA47E8", VA = "0xEA47E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000072")]
		private bool headIsValid
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xEA46EC", Offset = "0xEA46EC", VA = "0xEA46EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		private bool headIsEmpty
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xEA4810", Offset = "0xEA4810", VA = "0xEA4810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		private bool eyesIsValid
		{
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xEA46FC", Offset = "0xEA46FC", VA = "0xEA46FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xEA4890", Offset = "0xEA4890", VA = "0xEA4890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xEA3CC4", Offset = "0xEA3CC4", VA = "0xEA3CC4")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xEA3D48", Offset = "0xEA3D48", VA = "0xEA3D48")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xEA3DF4", Offset = "0xEA3DF4", VA = "0xEA3DF4")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xEA3EBC", Offset = "0xEA3EBC", VA = "0xEA3EBC")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xEA3FA8", Offset = "0xEA3FA8", VA = "0xEA3FA8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xEA40B4", Offset = "0xEA40B4", VA = "0xEA40B4")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xEA41FC", Offset = "0xEA41FC", VA = "0xEA41FC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xEA432C", Offset = "0xEA432C", VA = "0xEA432C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xEA4468", Offset = "0xEA4468", VA = "0xEA4468", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xEA48B8", Offset = "0xEA48B8", VA = "0xEA48B8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xEA4AF0", Offset = "0xEA4AF0", VA = "0xEA4AF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xEA4C98", Offset = "0xEA4C98", VA = "0xEA4C98")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xEA4F00", Offset = "0xEA4F00", VA = "0xEA4F00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xEA5360", Offset = "0xEA5360", VA = "0xEA5360", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xEA5464", Offset = "0xEA5464", VA = "0xEA5464")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xEA5658", Offset = "0xEA5658", VA = "0xEA5658")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xEA58B8", Offset = "0xEA58B8", VA = "0xEA58B8")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xEA5BF0", Offset = "0xEA5BF0", VA = "0xEA5BF0")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xEA4D48", Offset = "0xEA4D48", VA = "0xEA4D48")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xEA60A0", Offset = "0xEA60A0", VA = "0xEA60A0")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200011D")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40007C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40007C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000955")]
			[Address(RVA = "0xEA7874", Offset = "0xEA7874", VA = "0xEA7874")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xEA8428", Offset = "0xEA8428", VA = "0xEA8428")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x6000957")]
			[Address(RVA = "0xEA25FC", Offset = "0xEA25FC", VA = "0xEA25FC")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0xEA84F0", Offset = "0xEA84F0", VA = "0xEA84F0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741080", Offset = "0x741080")]
		public float IKRotationWeight;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xEA6290", Offset = "0xEA6290", VA = "0xEA6290")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xEA6484", Offset = "0xEA6484", VA = "0xEA6484")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xEA663C", Offset = "0xEA663C", VA = "0xEA663C")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xEA6648", Offset = "0xEA6648", VA = "0xEA6648")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xEA66CC", Offset = "0xEA66CC", VA = "0xEA66CC")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xEA66D8", Offset = "0xEA66D8", VA = "0xEA66D8")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xEA66E0", Offset = "0xEA66E0", VA = "0xEA66E0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xEA67E4", Offset = "0xEA67E4", VA = "0xEA67E4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xEA6908", Offset = "0xEA6908", VA = "0xEA6908", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xEA6954", Offset = "0xEA6954", VA = "0xEA6954", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xEA69A0", Offset = "0xEA69A0", VA = "0xEA69A0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xEA6D84", Offset = "0xEA6D84", VA = "0xEA6D84")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xEA6DE0", Offset = "0xEA6DE0", VA = "0xEA6DE0")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xEA738C", Offset = "0xEA738C", VA = "0xEA738C")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xEA75A4", Offset = "0xEA75A4", VA = "0xEA75A4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xEA7768", Offset = "0xEA7768", VA = "0xEA7768")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xEA76E0", Offset = "0xEA76E0", VA = "0xEA76E0")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xEA7A14", Offset = "0xEA7A14", VA = "0xEA7A14", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xEA84E4", Offset = "0xEA84E4", VA = "0xEA84E4", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xEA84E8", Offset = "0xEA84E8", VA = "0xEA84E8", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xEA84EC", Offset = "0xEA84EC", VA = "0xEA84EC", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xEA8128", Offset = "0xEA8128", VA = "0xEA8128")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xEA3AB0", Offset = "0xEA3AB0", VA = "0xEA3AB0")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000148")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000903")]
				YawPitch,
				[Token(Token = "0x4000904")]
				FromTo
			}

			[Token(Token = "0x40007C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742470", Offset = "0x742470")]
			public Transform target;

			[Token(Token = "0x40007C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7424A8", Offset = "0x7424A8")]
			public Transform bendGoal;

			[Token(Token = "0x40007C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7424E0", Offset = "0x7424E0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7424E0", Offset = "0x7424E0")]
			public float positionWeight;

			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742534", Offset = "0x742534")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742534", Offset = "0x742534")]
			public float rotationWeight;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742588", Offset = "0x742588")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7425C0", Offset = "0x7425C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7425C0", Offset = "0x7425C0")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742614", Offset = "0x742614")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742614", Offset = "0x742614")]
			public float bendGoalWeight;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742668", Offset = "0x742668")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742668", Offset = "0x742668")]
			public float swivelOffset;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7426C4", Offset = "0x7426C4")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7426FC", Offset = "0x7426FC")]
			public Vector3 palmToThumbAxis;

			[NonSerialized]
			[Token(Token = "0x40007CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40007CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40007D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40007D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40007D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742774", Offset = "0x742774")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40007D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742784", Offset = "0x742784")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40007D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private bool hasShoulder;

			[Token(Token = "0x40007D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40007D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40007D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Quaternion chestRotation;

			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestForward;

			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 chestUp;

			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40007DB")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40007DC")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000BE")]
			public Vector3 position
			{
				[Token(Token = "0x6000959")]
				[Address(RVA = "0xEB0530", Offset = "0xEB0530", VA = "0xEB0530")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AC4", Offset = "0x747AC4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600095A")]
				[Address(RVA = "0xEB053C", Offset = "0xEB053C", VA = "0xEB053C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AD4", Offset = "0x747AD4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public Quaternion rotation
			{
				[Token(Token = "0x600095B")]
				[Address(RVA = "0xEB0548", Offset = "0xEB0548", VA = "0xEB0548")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AE4", Offset = "0x747AE4")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600095C")]
				[Address(RVA = "0xEB0554", Offset = "0xEB0554", VA = "0xEB0554")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747AF4", Offset = "0x747AF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600095D")]
				[Address(RVA = "0xEB0560", Offset = "0xEB0560", VA = "0xEB0560")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C1")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600095E")]
				[Address(RVA = "0xEB059C", Offset = "0xEB059C", VA = "0xEB059C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600095F")]
				[Address(RVA = "0xEB05DC", Offset = "0xEB05DC", VA = "0xEB05DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000960")]
				[Address(RVA = "0xEB061C", Offset = "0xEB061C", VA = "0xEB061C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0xEB065C", Offset = "0xEB065C", VA = "0xEB065C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0xEB0DD0", Offset = "0xEB0DD0", VA = "0xEB0DD0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0xEB0FCC", Offset = "0xEB0FCC", VA = "0xEB0FCC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xEAE798", Offset = "0xEAE798", VA = "0xEAE798")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0xEB20C4", Offset = "0xEB20C4", VA = "0xEB20C4", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0xEB2134", Offset = "0xEB2134", VA = "0xEB2134", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0xEB1078", Offset = "0xEB1078", VA = "0xEB1078")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0xEB1380", Offset = "0xEB1380", VA = "0xEB1380")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xEB2278", Offset = "0xEB2278", VA = "0xEB2278")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0xEB034C", Offset = "0xEB034C", VA = "0xEB034C")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200011F")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40007DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742794", Offset = "0x742794")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x40007DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7427A4", Offset = "0x7427A4")]
			private float <mag>k__BackingField;

			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x170000C4")]
			public float sqrMag
			{
				[Token(Token = "0x6000970")]
				[Address(RVA = "0xEB243C", Offset = "0xEB243C", VA = "0xEB243C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B04", Offset = "0x747B04")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000971")]
				[Address(RVA = "0xEB2444", Offset = "0xEB2444", VA = "0xEB2444")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B14", Offset = "0x747B14")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C5")]
			public float mag
			{
				[Token(Token = "0x6000972")]
				[Address(RVA = "0xEB244C", Offset = "0xEB244C", VA = "0xEB244C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B24", Offset = "0x747B24")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000973")]
				[Address(RVA = "0xEB2454", Offset = "0xEB2454", VA = "0xEB2454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B34", Offset = "0x747B34")]
				private set
				{
				}
			}

			[Token(Token = "0x600096B")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x600096C")]
			public abstract void PreSolve();

			[Token(Token = "0x600096D")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600096E")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x600096F")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000974")]
			[Address(RVA = "0xEA2284", Offset = "0xEA2284", VA = "0xEA2284")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0xEB2758", Offset = "0xEB2758", VA = "0xEB2758")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0xEB28CC", Offset = "0xEB28CC", VA = "0xEB28CC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xEB2B68", Offset = "0xEB2B68", VA = "0xEB2B68")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xEAE544", Offset = "0xEAE544", VA = "0xEAE544")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xEB1F18", Offset = "0xEB1F18", VA = "0xEB1F18")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0xEB2BBC", Offset = "0xEB2BBC", VA = "0xEB2BBC")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xEB2D04", Offset = "0xEB2D04", VA = "0xEB2D04")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0xEB23A4", Offset = "0xEB23A4", VA = "0xEB23A4")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000120")]
		public class Footstep
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7427C4", Offset = "0x7427C4")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000C6")]
			public bool isStepping
			{
				[Token(Token = "0x600097D")]
				[Address(RVA = "0xEB2D2C", Offset = "0xEB2D2C", VA = "0xEB2D2C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000C7")]
			public float stepProgress
			{
				[Token(Token = "0x600097E")]
				[Address(RVA = "0xEB2D40", Offset = "0xEB2D40", VA = "0xEB2D40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B44", Offset = "0x747B44")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600097F")]
				[Address(RVA = "0xEB2D48", Offset = "0xEB2D48", VA = "0xEB2D48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B54", Offset = "0x747B54")]
				private set
				{
				}
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0xEB2D50", Offset = "0xEB2D50", VA = "0xEB2D50")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0xEB2E80", Offset = "0xEB2E80", VA = "0xEB2E80")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0xEB2FB0", Offset = "0xEB2FB0", VA = "0xEB2FB0")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0xEB30BC", Offset = "0xEB30BC", VA = "0xEB30BC")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0xEB3294", Offset = "0xEB3294", VA = "0xEB3294")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0xEB3480", Offset = "0xEB3480", VA = "0xEB3480")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000121")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7427D4", Offset = "0x7427D4")]
			public Transform target;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74280C", Offset = "0x74280C")]
			public Transform bendGoal;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742844", Offset = "0x742844")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742844", Offset = "0x742844")]
			public float positionWeight;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742898", Offset = "0x742898")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742898", Offset = "0x742898")]
			public float rotationWeight;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7428EC", Offset = "0x7428EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7428EC", Offset = "0x7428EC")]
			public float bendGoalWeight;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742940", Offset = "0x742940")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742940", Offset = "0x742940")]
			public float swivelOffset;

			[NonSerialized]
			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7429FC", Offset = "0x7429FC")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742A0C", Offset = "0x742A0C")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742A1C", Offset = "0x742A1C")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742A2C", Offset = "0x742A2C")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x170000C8")]
			public Vector3 position
			{
				[Token(Token = "0x6000986")]
				[Address(RVA = "0xEB36A0", Offset = "0xEB36A0", VA = "0xEB36A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B64", Offset = "0x747B64")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000987")]
				[Address(RVA = "0xEB36AC", Offset = "0xEB36AC", VA = "0xEB36AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B74", Offset = "0x747B74")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000988")]
				[Address(RVA = "0xEB36B8", Offset = "0xEB36B8", VA = "0xEB36B8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B84", Offset = "0x747B84")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000989")]
				[Address(RVA = "0xEB36C4", Offset = "0xEB36C4", VA = "0xEB36C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747B94", Offset = "0x747B94")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CA")]
			public bool hasToes
			{
				[Token(Token = "0x600098A")]
				[Address(RVA = "0xEB36D0", Offset = "0xEB36D0", VA = "0xEB36D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BA4", Offset = "0x747BA4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600098B")]
				[Address(RVA = "0xEB36D8", Offset = "0xEB36D8", VA = "0xEB36D8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BB4", Offset = "0x747BB4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600098C")]
				[Address(RVA = "0xEB36E4", Offset = "0xEB36E4", VA = "0xEB36E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private VirtualBone calf
			{
				[Token(Token = "0x600098D")]
				[Address(RVA = "0xEB3720", Offset = "0xEB3720", VA = "0xEB3720")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CD")]
			private VirtualBone foot
			{
				[Token(Token = "0x600098E")]
				[Address(RVA = "0xEB3760", Offset = "0xEB3760", VA = "0xEB3760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CE")]
			private VirtualBone toes
			{
				[Token(Token = "0x600098F")]
				[Address(RVA = "0xEB37A0", Offset = "0xEB37A0", VA = "0xEB37A0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000990")]
				[Address(RVA = "0xEAE374", Offset = "0xEAE374", VA = "0xEAE374")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D0")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000991")]
				[Address(RVA = "0xEB37E0", Offset = "0xEB37E0", VA = "0xEB37E0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BC4", Offset = "0x747BC4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000992")]
				[Address(RVA = "0xEB37EC", Offset = "0xEB37EC", VA = "0xEB37EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BD4", Offset = "0x747BD4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0xEB37F8", Offset = "0xEB37F8", VA = "0xEB37F8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0xEB3CA4", Offset = "0xEB3CA4", VA = "0xEB3CA4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0xEB43A8", Offset = "0xEB43A8", VA = "0xEB43A8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0xEB42A4", Offset = "0xEB42A4", VA = "0xEB42A4")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0xEB407C", Offset = "0xEB407C", VA = "0xEB407C")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0xEA1F34", Offset = "0xEA1F34", VA = "0xEA1F34")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0xEB4960", Offset = "0xEB4960", VA = "0xEB4960", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600099A")]
			[Address(RVA = "0xEB4AA0", Offset = "0xEB4AA0", VA = "0xEB4AA0", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0xEA24B4", Offset = "0xEA24B4", VA = "0xEA24B4")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000122")]
		public class Locomotion
		{
			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742A3C", Offset = "0x742A3C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742A3C", Offset = "0x742A3C")]
			public float weight;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742A90", Offset = "0x742A90")]
			public float footDistance;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742AC8", Offset = "0x742AC8")]
			public float stepThreshold;

			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742B00", Offset = "0x742B00")]
			public float angleThreshold;

			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742B38", Offset = "0x742B38")]
			public float comAngleMlp;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742B70", Offset = "0x742B70")]
			public float maxVelocity;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742BA8", Offset = "0x742BA8")]
			public float velocityFactor;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742BE0", Offset = "0x742BE0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742BE0", Offset = "0x742BE0")]
			public float maxLegStretch;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742C38", Offset = "0x742C38")]
			public float rootSpeed;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742C70", Offset = "0x742C70")]
			public float stepSpeed;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742CA8", Offset = "0x742CA8")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742CE0", Offset = "0x742CE0")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742D18", Offset = "0x742D18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742D18", Offset = "0x742D18")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742D70", Offset = "0x742D70")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742DA8", Offset = "0x742DA8")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742DE0", Offset = "0x742DE0")]
			public Vector3 offset;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742E58", Offset = "0x742E58")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742E90", Offset = "0x742E90")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x742EC8", Offset = "0x742EC8")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000D1")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0xEB4B50", Offset = "0xEB4B50", VA = "0xEB4B50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BE4", Offset = "0x747BE4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600099D")]
				[Address(RVA = "0xEB4B5C", Offset = "0xEB4B5C", VA = "0xEB4B5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747BF4", Offset = "0x747BF4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000D2")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x60009A3")]
				[Address(RVA = "0xEB4FAC", Offset = "0xEB4FAC", VA = "0xEB4FAC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D3")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0xEB4FF4", Offset = "0xEB4FF4", VA = "0xEB4FF4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000D4")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x60009A5")]
				[Address(RVA = "0xEB5040", Offset = "0xEB5040", VA = "0xEB5040")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000D5")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x60009A6")]
				[Address(RVA = "0xEB5088", Offset = "0xEB5088", VA = "0xEB5088")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0xEAC620", Offset = "0xEAC620", VA = "0xEAC620")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0xEAA5A8", Offset = "0xEAA5A8", VA = "0xEAA5A8")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0xEA99D8", Offset = "0xEA99D8", VA = "0xEA99D8")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0xEA9820", Offset = "0xEA9820", VA = "0xEA9820")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0xEACF60", Offset = "0xEACF60", VA = "0xEACF60")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0xEB4BB0", Offset = "0xEB4BB0", VA = "0xEB4BB0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0xEB4D54", Offset = "0xEB4D54", VA = "0xEB4D54")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0xEB4DE0", Offset = "0xEB4DE0", VA = "0xEB4DE0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0xEB0448", Offset = "0xEB0448", VA = "0xEB0448")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000123")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742ED8", Offset = "0x742ED8")]
			public Transform headTarget;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742F10", Offset = "0x742F10")]
			public Transform pelvisTarget;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742F48", Offset = "0x742F48")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742F48", Offset = "0x742F48")]
			public float positionWeight;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742F9C", Offset = "0x742F9C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742F9C", Offset = "0x742F9C")]
			public float rotationWeight;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742FF0", Offset = "0x742FF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x742FF0", Offset = "0x742FF0")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743044", Offset = "0x743044")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743044", Offset = "0x743044")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743098", Offset = "0x743098")]
			public Transform chestGoal;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7430D0", Offset = "0x7430D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7430D0", Offset = "0x7430D0")]
			public float chestGoalWeight;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743124", Offset = "0x743124")]
			public float minHeadHeight;

			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74315C", Offset = "0x74315C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74315C", Offset = "0x74315C")]
			public float bodyPosStiffness;

			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7431B0", Offset = "0x7431B0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7431B0", Offset = "0x7431B0")]
			public float bodyRotStiffness;

			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743204", Offset = "0x743204")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x743204", Offset = "0x743204")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743204", Offset = "0x743204")]
			public float neckStiffness;

			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74327C", Offset = "0x74327C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74327C", Offset = "0x74327C")]
			public float chestClampWeight;

			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7432D0", Offset = "0x7432D0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7432D0", Offset = "0x7432D0")]
			public float headClampWeight;

			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743324", Offset = "0x743324")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743324", Offset = "0x743324")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743378", Offset = "0x743378")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743378", Offset = "0x743378")]
			public float maxRootAngle;

			[NonSerialized]
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x4000840")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7434B0", Offset = "0x7434B0")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000841")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			private Quaternion headRotation;

			[Token(Token = "0x4000842")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000843")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000844")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private int pelvisIndex;

			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
			private int spineIndex;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
			private int chestIndex;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private int neckIndex;

			[Token(Token = "0x400084C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
			private int headIndex;

			[Token(Token = "0x400084D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
			private float length;

			[Token(Token = "0x400084E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
			private bool hasChest;

			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
			private bool hasNeck;

			[Token(Token = "0x4000850")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private float headHeight;

			[Token(Token = "0x4000851")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
			private float sizeMlp;

			[Token(Token = "0x4000852")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
			private Vector3 chestForward;

			[Token(Token = "0x170000D6")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x60009AB")]
				[Address(RVA = "0xEAA828", Offset = "0xEAA828", VA = "0xEAA828")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x60009AC")]
				[Address(RVA = "0xEB50D4", Offset = "0xEB50D4", VA = "0xEB50D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			public VirtualBone chest
			{
				[Token(Token = "0x60009AD")]
				[Address(RVA = "0xEAE738", Offset = "0xEAE738", VA = "0xEAE738")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private VirtualBone neck
			{
				[Token(Token = "0x60009AE")]
				[Address(RVA = "0xEB511C", Offset = "0xEB511C", VA = "0xEB511C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			public VirtualBone head
			{
				[Token(Token = "0x60009AF")]
				[Address(RVA = "0xEB4B68", Offset = "0xEB4B68", VA = "0xEB4B68")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DB")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x60009B0")]
				[Address(RVA = "0xEB5164", Offset = "0xEB5164", VA = "0xEB5164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747C04", Offset = "0x747C04")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x60009B1")]
				[Address(RVA = "0xEB5178", Offset = "0xEB5178", VA = "0xEB5178")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747C14", Offset = "0x747C14")]
				private set
				{
				}
			}

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0xEB518C", Offset = "0xEB518C", VA = "0xEB518C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0xEB5C14", Offset = "0xEB5C14", VA = "0xEB5C14", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0xEB5DE8", Offset = "0xEB5DE8", VA = "0xEB5DE8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0xEB630C", Offset = "0xEB630C", VA = "0xEB630C")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0xEAC91C", Offset = "0xEAC91C", VA = "0xEAC91C")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0xEB7484", Offset = "0xEB7484", VA = "0xEB7484")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0xEB7814", Offset = "0xEB7814", VA = "0xEB7814", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0xEB7A30", Offset = "0xEB7A30", VA = "0xEB7A30", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0xEB6540", Offset = "0xEB6540", VA = "0xEB6540")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0xEAE3BC", Offset = "0xEAE3BC", VA = "0xEAE3BC")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0xEB6874", Offset = "0xEB6874", VA = "0xEB6874")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0xEB7B24", Offset = "0xEB7B24", VA = "0xEB7B24")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xEB7220", Offset = "0xEB7220", VA = "0xEB7220")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0xEB6FA0", Offset = "0xEB6FA0", VA = "0xEB6FA0")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xEB01C8", Offset = "0xEB01C8", VA = "0xEB01C8")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000124")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000854")]
			Pelvis,
			[Token(Token = "0x4000855")]
			Chest,
			[Token(Token = "0x4000856")]
			Head,
			[Token(Token = "0x4000857")]
			LeftHand,
			[Token(Token = "0x4000858")]
			RightHand,
			[Token(Token = "0x4000859")]
			LeftFoot,
			[Token(Token = "0x400085A")]
			RightFoot,
			[Token(Token = "0x400085B")]
			LeftHeel,
			[Token(Token = "0x400085C")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000125")]
		public enum RotationOffset
		{
			[Token(Token = "0x400085E")]
			Pelvis,
			[Token(Token = "0x400085F")]
			Chest,
			[Token(Token = "0x4000860")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000126")]
		public class VirtualBone
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000867")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0xEAC584", Offset = "0xEAC584", VA = "0xEAC584")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0xEAC600", Offset = "0xEAC600", VA = "0xEAC600")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0xEB7E44", Offset = "0xEB7E44", VA = "0xEB7E44")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0xEB245C", Offset = "0xEB245C", VA = "0xEB245C")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xEB2980", Offset = "0xEB2980", VA = "0xEB2980")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xEB80CC", Offset = "0xEB80CC", VA = "0xEB80CC")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xEB1150", Offset = "0xEB1150", VA = "0xEB1150")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0xEB82EC", Offset = "0xEB82EC", VA = "0xEB82EC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xEB1958", Offset = "0xEB1958", VA = "0xEB1958")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0xEB83B0", Offset = "0xEB83B0", VA = "0xEB83B0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0xEB6BF8", Offset = "0xEB6BF8", VA = "0xEB6BF8")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length)
			{
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0xEB85C8", Offset = "0xEB85C8", VA = "0xEB85C8")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0xEB86D0", Offset = "0xEB86D0", VA = "0xEB86D0")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPelvisLocalPosition;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741098", Offset = "0x741098")]
		public bool plantFeet;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7410D0", Offset = "0x7410D0")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7410E0", Offset = "0x7410E0")]
		public Spine spine;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741118", Offset = "0x741118")]
		public Arm leftArm;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741150", Offset = "0x741150")]
		public Arm rightArm;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741188", Offset = "0x741188")]
		public Leg leftLeg;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7411C0", Offset = "0x7411C0")]
		public Leg rightLeg;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7411F8", Offset = "0x7411F8")]
		public Locomotion locomotion;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000076")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0xEB0020", Offset = "0xEB0020", VA = "0xEB0020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469A8", Offset = "0x7469A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600075B")]
			[Address(RVA = "0xEB0028", Offset = "0xEB0028", VA = "0xEB0028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469B8", Offset = "0x7469B8")]
			private set
			{
			}
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xEA84F8", Offset = "0xEA84F8", VA = "0xEA84F8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xEA88F8", Offset = "0xEA88F8", VA = "0xEA88F8")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xEA879C", Offset = "0xEA879C", VA = "0xEA879C")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xEA92EC", Offset = "0xEA92EC", VA = "0xEA92EC")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xEA945C", Offset = "0xEA945C", VA = "0xEA945C")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xEA9500", Offset = "0xEA9500", VA = "0xEA9500")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xEA9694", Offset = "0xEA9694", VA = "0xEA9694")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0xEA9DB8", Offset = "0xEA9DB8", VA = "0xEA9DB8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xEAA870", Offset = "0xEAA870", VA = "0xEAA870", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xEAA9C4", Offset = "0xEAA9C4", VA = "0xEAA9C4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xEAAB18", Offset = "0xEAAB18", VA = "0xEAAB18", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xEAAB8C", Offset = "0xEAAB8C", VA = "0xEAAB8C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xEAAC00", Offset = "0xEAAC00", VA = "0xEAAC00", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xEAAE18", Offset = "0xEAAE18", VA = "0xEAAE18")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xEA8B94", Offset = "0xEA8B94", VA = "0xEA8B94")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xEA8D70", Offset = "0xEA8D70", VA = "0xEA8D70")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xEA91C4", Offset = "0xEA91C4", VA = "0xEA91C4")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xEA9F18", Offset = "0xEA9F18", VA = "0xEA9F18")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xEAB100", Offset = "0xEAB100", VA = "0xEAB100", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xEAB138", Offset = "0xEAB138", VA = "0xEAB138", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xEAC284", Offset = "0xEAC284", VA = "0xEAC284")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xEAA080", Offset = "0xEAA080", VA = "0xEAA080")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0xEAB1A4", Offset = "0xEAB1A4", VA = "0xEAB1A4")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0xEAC470", Offset = "0xEAC470", VA = "0xEAC470")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0xEAC538", Offset = "0xEAC538", VA = "0xEAC538")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xEAC128", Offset = "0xEAC128", VA = "0xEAC128")]
		private void Write()
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0xEAFA34", Offset = "0xEAFA34", VA = "0xEAFA34")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xEB0030", Offset = "0xEB0030", VA = "0xEB0030")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741230", Offset = "0x741230")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741230", Offset = "0x741230")]
		public float weight;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741284", Offset = "0x741284")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741284", Offset = "0x741284")]
		public float parentChildCrossfade;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 twistAxis;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 axis;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform parent;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform child;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0xC402AC", Offset = "0xC402AC", VA = "0xC402AC")]
		public void Relax()
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0xC40610", Offset = "0xC40610", VA = "0xC40610")]
		private void Start()
		{
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xC408F4", Offset = "0xC408F4", VA = "0xC408F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xC408F8", Offset = "0xC408F8", VA = "0xC408F8")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class InteractionEffector
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7412D8", Offset = "0x7412D8")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7412E8", Offset = "0x7412E8")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7412F8", Offset = "0x7412F8")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000077")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x6000763")]
			[Address(RVA = "0xEB8F24", Offset = "0xEB8F24", VA = "0xEB8F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469C8", Offset = "0x7469C8")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x6000764")]
			[Address(RVA = "0xEB8F2C", Offset = "0xEB8F2C", VA = "0xEB8F2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469D8", Offset = "0x7469D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool isPaused
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0xEB8F34", Offset = "0xEB8F34", VA = "0xEB8F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469E8", Offset = "0x7469E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000766")]
			[Address(RVA = "0xEB8F3C", Offset = "0xEB8F3C", VA = "0xEB8F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7469F8", Offset = "0x7469F8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0xEB8F48", Offset = "0xEB8F48", VA = "0xEB8F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746A08", Offset = "0x746A08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000768")]
			[Address(RVA = "0xEB8F50", Offset = "0xEB8F50", VA = "0xEB8F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746A18", Offset = "0x746A18")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public bool inInteraction
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0xEB8F58", Offset = "0xEB8F58", VA = "0xEB8F58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public float progress
		{
			[Token(Token = "0x6000772")]
			[Address(RVA = "0xEBB138", Offset = "0xEBB138", VA = "0xEBB138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xEB8FC8", Offset = "0xEB8FC8", VA = "0xEB8FC8")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xEB904C", Offset = "0xEB904C", VA = "0xEB904C")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xEB90F4", Offset = "0xEB90F4", VA = "0xEB90F4")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xEB9238", Offset = "0xEB9238", VA = "0xEB9238")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xEB9654", Offset = "0xEB9654", VA = "0xEB9654")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xEB978C", Offset = "0xEB978C", VA = "0xEB978C")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xEB97E8", Offset = "0xEB97E8", VA = "0xEB97E8")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xEB9E18", Offset = "0xEB9E18", VA = "0xEB9E18")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xEBA930", Offset = "0xEBA930", VA = "0xEBA930")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xEBAB6C", Offset = "0xEBAB6C", VA = "0xEBAB6C")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0xEBAFD8", Offset = "0xEBAFD8", VA = "0xEBAFD8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xEBB204", Offset = "0xEBB204", VA = "0xEBB204")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741308", Offset = "0x741308")]
		public LookAtIK ik;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741340", Offset = "0x741340")]
		public float lerpSpeed;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741378", Offset = "0x741378")]
		public float weightSpeed;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000777")]
		[Address(RVA = "0xEBB470", Offset = "0xEBB470", VA = "0xEBB470")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xEBB5EC", Offset = "0xEBB5EC", VA = "0xEBB5EC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xEBB838", Offset = "0xEBB838", VA = "0xEBB838")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xEBB934", Offset = "0xEBB934", VA = "0xEBB934")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0xEBBA04", Offset = "0xEBBA04", VA = "0xEBBA04")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EAFC", Offset = "0x73EAFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EAFC", Offset = "0x73EAFC")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000127")]
		public class InteractionEvent
		{
			[Token(Token = "0x4000868")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7434C0", Offset = "0x7434C0")]
			public float time;

			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7434F8", Offset = "0x7434F8")]
			public bool pause;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743530", Offset = "0x743530")]
			public bool pickUp;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743568", Offset = "0x743568")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x400086C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7435A0", Offset = "0x7435A0")]
			public Message[] messages;

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0xC31BD0", Offset = "0xC31BD0", VA = "0xC31BD0")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0xC31D8C", Offset = "0xC31D8C", VA = "0xC31D8C")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000128")]
		public class Message
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7435D8", Offset = "0x7435D8")]
			public string function;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743610", Offset = "0x743610")]
			public GameObject recipient;

			[Token(Token = "0x400086F")]
			private const string empty = "";

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0xC31C9C", Offset = "0xC31C9C", VA = "0xC31C9C")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0xC31D94", Offset = "0xC31D94", VA = "0xC31D94")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000129")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743648", Offset = "0x743648")]
			public Animator animator;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743680", Offset = "0x743680")]
			public Animation animation;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7436B8", Offset = "0x7436B8")]
			public string animationState;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7436F0", Offset = "0x7436F0")]
			public float crossfadeTime;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743728", Offset = "0x743728")]
			public int layer;

			[Token(Token = "0x4000875")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743760", Offset = "0x743760")]
			public bool resetNormalizedTime;

			[Token(Token = "0x4000876")]
			private const string empty = "";

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xC31928", Offset = "0xC31928", VA = "0xC31928")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xC31A1C", Offset = "0xC31A1C", VA = "0xC31A1C")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xC31AD8", Offset = "0xC31AD8", VA = "0xC31AD8")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0xC31BBC", Offset = "0xC31BBC", VA = "0xC31BBC")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012A")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000149")]
			public enum Type
			{
				[Token(Token = "0x4000906")]
				PositionWeight,
				[Token(Token = "0x4000907")]
				RotationWeight,
				[Token(Token = "0x4000908")]
				PositionOffsetX,
				[Token(Token = "0x4000909")]
				PositionOffsetY,
				[Token(Token = "0x400090A")]
				PositionOffsetZ,
				[Token(Token = "0x400090B")]
				Pull,
				[Token(Token = "0x400090C")]
				Reach,
				[Token(Token = "0x400090D")]
				RotateBoneWeight,
				[Token(Token = "0x400090E")]
				Push,
				[Token(Token = "0x400090F")]
				PushParent,
				[Token(Token = "0x4000910")]
				PoserWeight
			}

			[Token(Token = "0x4000877")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743798", Offset = "0x743798")]
			public Type type;

			[Token(Token = "0x4000878")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7437D0", Offset = "0x7437D0")]
			public AnimationCurve curve;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xC31DD4", Offset = "0xC31DD4", VA = "0xC31DD4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0xC31E00", Offset = "0xC31E00", VA = "0xC31E00")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200012B")]
		public class Multiplier
		{
			[Token(Token = "0x4000879")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743808", Offset = "0x743808")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400087A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743840", Offset = "0x743840")]
			public float multiplier;

			[Token(Token = "0x400087B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743878", Offset = "0x743878")]
			public WeightCurve.Type result;

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0xC31D9C", Offset = "0xC31D9C", VA = "0xC31D9C")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0xC31DF0", Offset = "0xC31DF0", VA = "0xC31DF0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7413C0", Offset = "0x7413C0")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7413F8", Offset = "0x7413F8")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741430", Offset = "0x741430")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741468", Offset = "0x741468")]
		private float <length>k__BackingField;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x741478", Offset = "0x741478")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700007C")]
		public float length
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0xEBBBE0", Offset = "0xEBBBE0", VA = "0xEBBBE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746B78", Offset = "0x746B78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000783")]
			[Address(RVA = "0xEBBBE8", Offset = "0xEBBBE8", VA = "0xEBBBE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746B88", Offset = "0x746B88")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xEBBBF0", Offset = "0xEBBBF0", VA = "0xEBBBF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746B98", Offset = "0x746B98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xEBBBF8", Offset = "0xEBBBF8", VA = "0xEBBBF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746BA8", Offset = "0x746BA8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xEBBE20", Offset = "0xEBBE20", VA = "0xEBBE20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public Transform targetsRoot
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0xEBB174", Offset = "0xEBB174", VA = "0xEBB174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xEBBA18", Offset = "0xEBBA18", VA = "0xEBBA18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746A28", Offset = "0x746A28")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xEBBA64", Offset = "0xEBBA64", VA = "0xEBBA64")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746A60", Offset = "0x746A60")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xEBBAB0", Offset = "0xEBBAB0", VA = "0xEBBAB0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746A98", Offset = "0x746A98")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xEBBAFC", Offset = "0xEBBAFC", VA = "0xEBBAFC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746AD0", Offset = "0x746AD0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0xEBBB48", Offset = "0xEBBB48", VA = "0xEBBB48")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746B08", Offset = "0x746B08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0xEBBB94", Offset = "0xEBBB94", VA = "0xEBBB94")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746B40", Offset = "0x746B40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0xEBBC00", Offset = "0xEBBC00", VA = "0xEBBC00")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0xEBBEB0", Offset = "0xEBBEB0", VA = "0xEBBEB0")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0xEB9D5C", Offset = "0xEB9D5C", VA = "0xEB9D5C")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0xEBC03C", Offset = "0xEBC03C", VA = "0xEBC03C")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0xEB9C00", Offset = "0xEB9C00", VA = "0xEB9C00")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xEB9D54", Offset = "0xEB9D54", VA = "0xEB9D54")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0xEBA4E8", Offset = "0xEBA4E8", VA = "0xEBA4E8")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0xEBAD84", Offset = "0xEBAD84", VA = "0xEBAD84")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xEBC710", Offset = "0xEBC710", VA = "0xEBC710")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0xEBC0BC", Offset = "0xEBC0BC", VA = "0xEBC0BC")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0xEBC044", Offset = "0xEBC044", VA = "0xEBC044")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xEBC6A0", Offset = "0xEBC6A0", VA = "0xEBC6A0")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xEBC714", Offset = "0xEBC714", VA = "0xEBC714")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xEBC784", Offset = "0xEBC784", VA = "0xEBC784")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746BB8", Offset = "0x746BB8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xEBC7D0", Offset = "0xEBC7D0", VA = "0xEBC7D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746BF0", Offset = "0x746BF0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0xEBC81C", Offset = "0xEBC81C", VA = "0xEBC81C")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EB5C", Offset = "0x73EB5C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EB5C", Offset = "0x73EB5C")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x200012D")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741488", Offset = "0x741488")]
		public string targetTag;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7414C0", Offset = "0x7414C0")]
		public float fadeInTime;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7414F8", Offset = "0x7414F8")]
		public float speed;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741530", Offset = "0x741530")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x741568", Offset = "0x741568")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741568", Offset = "0x741568")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x741568", Offset = "0x741568")]
		public Collider characterCollider;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7415EC", Offset = "0x7415EC")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x7415EC", Offset = "0x7415EC")]
		public Transform FPSCamera;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74164C", Offset = "0x74164C")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741684", Offset = "0x741684")]
		public float camRaycastDistance;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x7416BC", Offset = "0x7416BC")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x7416CC", Offset = "0x7416CC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7416CC", Offset = "0x7416CC")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74172C", Offset = "0x74172C")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000080")]
		public bool inInteraction
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0xC31FD0", Offset = "0xC31FD0", VA = "0xC31FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60007B8")]
			[Address(RVA = "0xC33DFC", Offset = "0xC33DFC", VA = "0xC33DFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xC33E04", Offset = "0xC33E04", VA = "0xC33E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xC33E0C", Offset = "0xC33E0C", VA = "0xC33E0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746D78", Offset = "0x746D78")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xC33E14", Offset = "0xC33E14", VA = "0xC33E14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x746D88", Offset = "0x746D88")]
			private set
			{
			}
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0xC31E08", Offset = "0xC31E08", VA = "0xC31E08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746C28", Offset = "0x746C28")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xC31E54", Offset = "0xC31E54", VA = "0xC31E54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746C60", Offset = "0x746C60")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xC31EA0", Offset = "0xC31EA0", VA = "0xC31EA0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746C98", Offset = "0x746C98")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xC31EEC", Offset = "0xC31EEC", VA = "0xC31EEC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746CD0", Offset = "0x746CD0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xC31F38", Offset = "0xC31F38", VA = "0xC31F38")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746D08", Offset = "0x746D08")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xC31F84", Offset = "0xC31F84", VA = "0xC31F84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746D40", Offset = "0x746D40")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xC3217C", Offset = "0xC3217C", VA = "0xC3217C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xC32258", Offset = "0xC32258", VA = "0xC32258")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xC32334", Offset = "0xC32334", VA = "0xC32334")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xC32400", Offset = "0xC32400", VA = "0xC32400")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xC32510", Offset = "0xC32510", VA = "0xC32510")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xC3263C", Offset = "0xC3263C", VA = "0xC3263C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xC326DC", Offset = "0xC326DC", VA = "0xC326DC")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xC3277C", Offset = "0xC3277C", VA = "0xC3277C")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xC3281C", Offset = "0xC3281C", VA = "0xC3281C")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xC3289C", Offset = "0xC3289C", VA = "0xC3289C")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xC3291C", Offset = "0xC3291C", VA = "0xC3291C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xC32990", Offset = "0xC32990", VA = "0xC32990")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xC32A24", Offset = "0xC32A24", VA = "0xC32A24")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xC32AC4", Offset = "0xC32AC4", VA = "0xC32AC4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xC32BA4", Offset = "0xC32BA4", VA = "0xC32BA4")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xC32E54", Offset = "0xC32E54", VA = "0xC32E54")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xC3303C", Offset = "0xC3303C", VA = "0xC3303C")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xC332D0", Offset = "0xC332D0", VA = "0xC332D0")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xC335DC", Offset = "0xC335DC", VA = "0xC335DC")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xC33628", Offset = "0xC33628", VA = "0xC33628")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xC336B0", Offset = "0xC336B0", VA = "0xC336B0")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xC337DC", Offset = "0xC337DC", VA = "0xC337DC")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xC33954", Offset = "0xC33954", VA = "0xC33954")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xC33C14", Offset = "0xC33C14", VA = "0xC33C14")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xC333D8", Offset = "0xC333D8", VA = "0xC333D8")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xC33E1C", Offset = "0xC33E1C", VA = "0xC33E1C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xC34498", Offset = "0xC34498", VA = "0xC34498")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xC344BC", Offset = "0xC344BC", VA = "0xC344BC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xC344DC", Offset = "0xC344DC", VA = "0xC344DC")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xC344FC", Offset = "0xC344FC", VA = "0xC344FC")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xC34568", Offset = "0xC34568", VA = "0xC34568")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xC34688", Offset = "0xC34688", VA = "0xC34688")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xC34788", Offset = "0xC34788", VA = "0xC34788")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xC34AF8", Offset = "0xC34AF8", VA = "0xC34AF8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xC34BE4", Offset = "0xC34BE4", VA = "0xC34BE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xC34E44", Offset = "0xC34E44", VA = "0xC34E44")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xC34208", Offset = "0xC34208", VA = "0xC34208")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xC34F84", Offset = "0xC34F84", VA = "0xC34F84")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xC350BC", Offset = "0xC350BC", VA = "0xC350BC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xC35160", Offset = "0xC35160", VA = "0xC35160")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xC35258", Offset = "0xC35258", VA = "0xC35258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xC3209C", Offset = "0xC3209C", VA = "0xC3209C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xC32D50", Offset = "0xC32D50", VA = "0xC32D50")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xC35500", Offset = "0xC35500", VA = "0xC35500")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746D98", Offset = "0x746D98")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0xC3554C", Offset = "0xC3554C", VA = "0xC3554C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746DD0", Offset = "0x746DD0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0xC35598", Offset = "0xC35598", VA = "0xC35598")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EBBC", Offset = "0x73EBBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EBBC", Offset = "0x73EBBC")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012E")]
		public class Multiplier
		{
			[Token(Token = "0x400087C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7438B0", Offset = "0x7438B0")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x400087D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7438E8", Offset = "0x7438E8")]
			public float multiplier;

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0xC369F0", Offset = "0xC369F0", VA = "0xC369F0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741764", Offset = "0x741764")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74179C", Offset = "0x74179C")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7417D4", Offset = "0x7417D4")]
		public float interactionSpeedMlp;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74180C", Offset = "0x74180C")]
		public Transform pivot;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741844", Offset = "0x741844")]
		public Vector3 twistAxis;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74187C", Offset = "0x74187C")]
		public float twistWeight;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7418B4", Offset = "0x7418B4")]
		public float swingWeight;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7418EC", Offset = "0x7418EC")]
		public bool rotateOnce;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0xC35F40", Offset = "0xC35F40", VA = "0xC35F40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746E08", Offset = "0x746E08")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0xC35F8C", Offset = "0xC35F8C", VA = "0xC35F8C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746E40", Offset = "0x746E40")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0xC35FD8", Offset = "0xC35FD8", VA = "0xC35FD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746E78", Offset = "0x746E78")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xC36024", Offset = "0xC36024", VA = "0xC36024")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746EB0", Offset = "0x746EB0")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xC36070", Offset = "0xC36070", VA = "0xC36070")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746EE8", Offset = "0x746EE8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xC360BC", Offset = "0xC360BC", VA = "0xC360BC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746F20", Offset = "0x746F20")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xC36108", Offset = "0xC36108", VA = "0xC36108")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xC36180", Offset = "0xC36180", VA = "0xC36180")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xC3621C", Offset = "0xC3621C", VA = "0xC3621C")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0xC368CC", Offset = "0xC368CC", VA = "0xC368CC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746F58", Offset = "0x746F58")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xC36918", Offset = "0xC36918", VA = "0xC36918")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746F90", Offset = "0x746F90")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0xC36964", Offset = "0xC36964", VA = "0xC36964")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EC1C", Offset = "0x73EC1C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EC1C", Offset = "0x73EC1C")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012F")]
		public class CharacterPosition
		{
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743920", Offset = "0x743920")]
			public bool use;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743958", Offset = "0x743958")]
			public Vector2 offset;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743990", Offset = "0x743990")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743990", Offset = "0x743990")]
			public float angleOffset;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7439EC", Offset = "0x7439EC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7439EC", Offset = "0x7439EC")]
			public float maxAngle;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743A44", Offset = "0x743A44")]
			public float radius;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743A7C", Offset = "0x743A7C")]
			public bool orbit;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743AB4", Offset = "0x743AB4")]
			public bool fixYAxis;

			[Token(Token = "0x170000DC")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60009E3")]
				[Address(RVA = "0xC37184", Offset = "0xC37184", VA = "0xC37184")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000DD")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60009E4")]
				[Address(RVA = "0xC371C0", Offset = "0xC371C0", VA = "0xC371C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0xC372B8", Offset = "0xC372B8", VA = "0xC372B8")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0xC37938", Offset = "0xC37938", VA = "0xC37938")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000130")]
		public class CameraPosition
		{
			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743AEC", Offset = "0x743AEC")]
			public Collider lookAtTarget;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743B24", Offset = "0x743B24")]
			public Vector3 direction;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743B5C", Offset = "0x743B5C")]
			public float maxDistance;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743B94", Offset = "0x743B94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x743B94", Offset = "0x743B94")]
			public float maxAngle;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743BEC", Offset = "0x743BEC")]
			public bool fixYAxis;

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0xC36C6C", Offset = "0xC36C6C", VA = "0xC36C6C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0xC36E14", Offset = "0xC36E14", VA = "0xC36E14")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0xC370F8", Offset = "0xC370F8", VA = "0xC370F8")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000131")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200014A")]
			public class Interaction
			{
				[Token(Token = "0x4000911")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744784", Offset = "0x744784")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000912")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7447BC", Offset = "0x7447BC")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000A4F")]
				[Address(RVA = "0xC3795C", Offset = "0xC3795C", VA = "0xC3795C")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x400088C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743C94", Offset = "0x743C94")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x400088D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743CCC", Offset = "0x743CCC")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x400088E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743D04", Offset = "0x743D04")]
			public Interaction[] interactions;

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0xC36AE0", Offset = "0xC36AE0", VA = "0xC36AE0")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0xC3794C", Offset = "0xC3794C", VA = "0xC3794C")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741924", Offset = "0x741924")]
		public Range[] ranges;

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0xC369F8", Offset = "0xC369F8", VA = "0xC369F8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x746FC8", Offset = "0x746FC8")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0xC36A44", Offset = "0xC36A44", VA = "0xC36A44")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747000", Offset = "0x747000")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xC36A90", Offset = "0xC36A90", VA = "0xC36A90")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747038", Offset = "0x747038")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xC36ADC", Offset = "0xC36ADC", VA = "0xC36ADC")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xC34934", Offset = "0xC34934", VA = "0xC34934")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xC36C0C", Offset = "0xC36C0C", VA = "0xC36C0C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x2000132")]
		public class Map
		{
			[Token(Token = "0x400088F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000890")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000891")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000892")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xE5439C", Offset = "0xE5439C", VA = "0xE5439C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0xE547BC", Offset = "0xE547BC", VA = "0xE547BC")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xE54770", Offset = "0xE54770", VA = "0xE54770")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0xE5455C", Offset = "0xE5455C", VA = "0xE5455C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xE540A0", Offset = "0xE540A0", VA = "0xE540A0", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747070", Offset = "0x747070")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xE54448", Offset = "0xE54448", VA = "0xE54448", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xE5444C", Offset = "0xE5444C", VA = "0xE5444C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xE54700", Offset = "0xE54700", VA = "0xE54700", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xE543D8", Offset = "0xE543D8", VA = "0xE543D8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xE542F0", Offset = "0xE542F0", VA = "0xE542F0")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xE5480C", Offset = "0xE5480C", VA = "0xE5480C")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xF91C80", Offset = "0xF91C80", VA = "0xF91C80", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xF91D38", Offset = "0xF91D38", VA = "0xF91D38", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xF91EF0", Offset = "0xF91EF0", VA = "0xF91EF0", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xF91FDC", Offset = "0xF91FDC", VA = "0xF91FDC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0xF91D94", Offset = "0xF91D94", VA = "0xF91D94")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xF923A4", Offset = "0xF923A4", VA = "0xF923A4")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74195C", Offset = "0x74195C")]
		public float weight;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741974", Offset = "0x741974")]
		public float localRotationWeight;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74198C", Offset = "0x74198C")]
		public float localPositionWeight;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60007F0")]
		public abstract void AutoMapping();

		[Token(Token = "0x60007F1")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60007F2")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60007F3")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0xC39168", Offset = "0xC39168", VA = "0xC39168", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xC391BC", Offset = "0xC391BC", VA = "0xC391BC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0xC391F8", Offset = "0xC391F8", VA = "0xC391F8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xC39210", Offset = "0xC39210", VA = "0xC39210")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x73EC7C", Offset = "0x73EC7C")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x2000133")]
		public class Rigidbone
		{
			[Token(Token = "0x4000893")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000894")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x4000895")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x400089B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x400089C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x400089D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xC397A8", Offset = "0xC397A8", VA = "0xC397A8")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0xC3A3FC", Offset = "0xC3A3FC", VA = "0xC3A3FC")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0xC3A1D8", Offset = "0xC3A1D8", VA = "0xC3A1D8")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x2000134")]
		public class Child
		{
			[Token(Token = "0x400089E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x400089F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40008A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0xC39908", Offset = "0xC39908", VA = "0xC39908")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0xC3A594", Offset = "0xC3A594", VA = "0xC3A594")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0xC3A544", Offset = "0xC3A544", VA = "0xC3A544")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF50", Offset = "0x73EF50")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000DE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009F9")]
				[Address(RVA = "0xC3AB78", Offset = "0xC3AB78", VA = "0xC3AB78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009FB")]
				[Address(RVA = "0xC3ABE4", Offset = "0xC3ABE4", VA = "0xC3ABE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0xC3996C", Offset = "0xC3996C", VA = "0xC3996C")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0xC3A930", Offset = "0xC3A930", VA = "0xC3A930", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0xC3A934", Offset = "0xC3A934", VA = "0xC3A934", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xC3AB80", Offset = "0xC3AB80", VA = "0xC3AB80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7419A4", Offset = "0x7419A4")]
		public IK ik;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7419DC", Offset = "0x7419DC")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741A14", Offset = "0x741A14")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741A4C", Offset = "0x741A4C")]
		public float applyVelocity;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741A84", Offset = "0x741A84")]
		public float applyAngularVelocity;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000083")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0xC39270", Offset = "0xC39270", VA = "0xC39270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		private bool ikUsed
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0xC39D70", Offset = "0xC39D70", VA = "0xC39D70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xC39238", Offset = "0xC39238", VA = "0xC39238")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xC392F4", Offset = "0xC392F4", VA = "0xC392F4")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xC39434", Offset = "0xC39434", VA = "0xC39434")]
		public void Start()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xC393C0", Offset = "0xC393C0", VA = "0xC393C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7470A8", Offset = "0x7470A8")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xC39998", Offset = "0xC39998", VA = "0xC39998")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xC39BF0", Offset = "0xC39BF0", VA = "0xC39BF0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xC39CB4", Offset = "0xC39CB4", VA = "0xC39CB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xC39F00", Offset = "0xC39F00", VA = "0xC39F00")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xC39D34", Offset = "0xC39D34", VA = "0xC39D34")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xC39EBC", Offset = "0xC39EBC", VA = "0xC39EBC")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xC39FA8", Offset = "0xC39FA8", VA = "0xC39FA8")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xC39F34", Offset = "0xC39F34", VA = "0xC39F34")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xC3934C", Offset = "0xC3934C", VA = "0xC3934C")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xC39C30", Offset = "0xC39C30", VA = "0xC39C30")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xC3A760", Offset = "0xC3A760", VA = "0xC3A760")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xC3A864", Offset = "0xC3A864", VA = "0xC3A864")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000085")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xC3C55C", Offset = "0xC3C55C", VA = "0xC3C55C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000086")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xC3C598", Offset = "0xC3C598", VA = "0xC3C598")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xC3C1D8", Offset = "0xC3C1D8", VA = "0xC3C1D8")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xC3C21C", Offset = "0xC3C21C", VA = "0xC3C21C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xC3C4AC", Offset = "0xC3C4AC", VA = "0xC3C4AC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xC3C524", Offset = "0xC3C524", VA = "0xC3C524")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000810")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000811")]
		[Address(RVA = "0xC3C3BC", Offset = "0xC3C3BC", VA = "0xC3C3BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0xC3C668", Offset = "0xC3C668", VA = "0xC3C668")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0xC3C66C", Offset = "0xC3C66C", VA = "0xC3C66C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0xC3C69C", Offset = "0xC3C69C", VA = "0xC3C69C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xC3C780", Offset = "0xC3C780", VA = "0xC3C780")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xC3CA00", Offset = "0xC3CA00", VA = "0xC3CA00")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xC3CABC", Offset = "0xC3CABC", VA = "0xC3CABC")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73ECE0", Offset = "0x73ECE0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73ECE0", Offset = "0x73ECE0")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741ACC", Offset = "0x741ACC")]
		public float limit;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741AE8", Offset = "0x741AE8")]
		public float twistLimit;

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xC3CB34", Offset = "0xC3CB34", VA = "0xC3CB34")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x74710C", Offset = "0x74710C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xC3CB80", Offset = "0xC3CB80", VA = "0xC3CB80")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747144", Offset = "0x747144")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xC3CBCC", Offset = "0xC3CBCC", VA = "0xC3CBCC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x74717C", Offset = "0x74717C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xC3CC18", Offset = "0xC3CC18", VA = "0xC3CC18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7471B4", Offset = "0x7471B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xC3CC64", Offset = "0xC3CC64", VA = "0xC3CC64", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xC3CD1C", Offset = "0xC3CD1C", VA = "0xC3CD1C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xC3CF64", Offset = "0xC3CF64", VA = "0xC3CF64")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73ED40", Offset = "0x73ED40")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73ED40", Offset = "0x73ED40")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xC3CF74", Offset = "0xC3CF74", VA = "0xC3CF74")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7471EC", Offset = "0x7471EC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xC3CFC0", Offset = "0xC3CFC0", VA = "0xC3CFC0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747224", Offset = "0x747224")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xC3D00C", Offset = "0xC3D00C", VA = "0xC3D00C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x74725C", Offset = "0x74725C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xC3D058", Offset = "0xC3D058", VA = "0xC3D058")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747294", Offset = "0x747294")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xC3D0A4", Offset = "0xC3D0A4", VA = "0xC3D0A4", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xC3D0CC", Offset = "0xC3D0CC", VA = "0xC3D0CC")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xC3D3CC", Offset = "0xC3D3CC", VA = "0xC3D3CC")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EDA0", Offset = "0x73EDA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EDA0", Offset = "0x73EDA0")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x2000136")]
		public class ReachCone
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40008A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000E0")]
			public Vector3 o
			{
				[Token(Token = "0x60009FC")]
				[Address(RVA = "0xC3F358", Offset = "0xC3F358", VA = "0xC3F358")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E1")]
			public Vector3 a
			{
				[Token(Token = "0x60009FD")]
				[Address(RVA = "0xC3F398", Offset = "0xC3F398", VA = "0xC3F398")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E2")]
			public Vector3 b
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0xC3F3DC", Offset = "0xC3F3DC", VA = "0xC3F3DC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E3")]
			public Vector3 c
			{
				[Token(Token = "0x60009FF")]
				[Address(RVA = "0xC3F420", Offset = "0xC3F420", VA = "0xC3F420")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000E4")]
			public bool isValid
			{
				[Token(Token = "0x6000A01")]
				[Address(RVA = "0xC3E4C8", Offset = "0xC3E4C8", VA = "0xC3E4C8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0xC3EB10", Offset = "0xC3EB10", VA = "0xC3EB10")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0xC3EC7C", Offset = "0xC3EC7C", VA = "0xC3EC7C")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000137")]
		public class LimitPoint
		{
			[Token(Token = "0x40008A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40008A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0xC3E4D8", Offset = "0xC3E4D8", VA = "0xC3E4D8")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741B14", Offset = "0x741B14")]
		public float twistLimit;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741B30", Offset = "0x741B30")]
		public int smoothIterations;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xC3D454", Offset = "0xC3D454", VA = "0xC3D454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7472CC", Offset = "0x7472CC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xC3D4A0", Offset = "0xC3D4A0", VA = "0xC3D4A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747304", Offset = "0x747304")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xC3D4EC", Offset = "0xC3D4EC", VA = "0xC3D4EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x74733C", Offset = "0x74733C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xC3D538", Offset = "0xC3D538", VA = "0xC3D538")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747374", Offset = "0x747374")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xC3D584", Offset = "0xC3D584", VA = "0xC3D584")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xC3DA54", Offset = "0xC3DA54", VA = "0xC3DA54", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xC3DB50", Offset = "0xC3DB50", VA = "0xC3DB50")]
		private void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xC3E110", Offset = "0xC3E110", VA = "0xC3E110")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xC3D624", Offset = "0xC3D624", VA = "0xC3D624")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xC3E55C", Offset = "0xC3E55C", VA = "0xC3E55C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xC3EE3C", Offset = "0xC3EE3C", VA = "0xC3EE3C")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xC3EE80", Offset = "0xC3EE80", VA = "0xC3EE80")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xC3EFC8", Offset = "0xC3EFC8", VA = "0xC3EFC8")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xC3DDD0", Offset = "0xC3DDD0", VA = "0xC3DDD0")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xC3F158", Offset = "0xC3F158", VA = "0xC3F158")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xC3F2F4", Offset = "0xC3F2F4", VA = "0xC3F2F4")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x73EE00", Offset = "0x73EE00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x73EE00", Offset = "0x73EE00")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x741BF0", Offset = "0x741BF0")]
		public float twistLimit;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xC3F464", Offset = "0xC3F464", VA = "0xC3F464")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7473AC", Offset = "0x7473AC")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xC3F4B0", Offset = "0xC3F4B0", VA = "0xC3F4B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x7473E4", Offset = "0x7473E4")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xC3F4FC", Offset = "0xC3F4FC", VA = "0xC3F4FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x74741C", Offset = "0x74741C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xC3F548", Offset = "0xC3F548", VA = "0xC3F548")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x747454", Offset = "0x747454")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xC3F594", Offset = "0xC3F594", VA = "0xC3F594")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xC3F5B0", Offset = "0xC3F5B0", VA = "0xC3F5B0", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xC3F668", Offset = "0xC3F668", VA = "0xC3F668")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xC3F994", Offset = "0xC3F994", VA = "0xC3F994")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000138")]
		public class Pose
		{
			[Token(Token = "0x40008AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40008AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40008AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40008AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40008AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40008AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0xE48A58", Offset = "0xE48A58", VA = "0xE48A58")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0xE48DCC", Offset = "0xE48DCC", VA = "0xE48DCC")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xE48DD4", Offset = "0xE48DD4", VA = "0xE48DD4")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xE48970", Offset = "0xE48970", VA = "0xE48970")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xE48CF4", Offset = "0xE48CF4", VA = "0xE48CF4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0xE48D64", Offset = "0xE48D64", VA = "0xE48D64")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000139")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200014B")]
			public class EffectorLink
			{
				[Token(Token = "0x4000913")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7447F4", Offset = "0x7447F4")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000914")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74482C", Offset = "0x74482C")]
				public float weight;

				[Token(Token = "0x6000A50")]
				[Address(RVA = "0xE493E4", Offset = "0xE493E4", VA = "0xE493E4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743D3C", Offset = "0x743D3C")]
			public Transform transform;

			[Token(Token = "0x40008B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743D74", Offset = "0x743D74")]
			public Transform relativeTo;

			[Token(Token = "0x40008B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743DAC", Offset = "0x743DAC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40008B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743DE4", Offset = "0x743DE4")]
			public float verticalWeight;

			[Token(Token = "0x40008B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743E1C", Offset = "0x743E1C")]
			public float horizontalWeight;

			[Token(Token = "0x40008B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743E54", Offset = "0x743E54")]
			public float speed;

			[Token(Token = "0x40008B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40008B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40008B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xE48F38", Offset = "0xE48F38", VA = "0xE48F38")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xE493BC", Offset = "0xE493BC", VA = "0xE493BC")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0xE493CC", Offset = "0xE493CC", VA = "0xE493CC")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741C44", Offset = "0x741C44")]
		public Body[] bodies;

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xE48DF0", Offset = "0xE48DF0", VA = "0xE48DF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xE493B4", Offset = "0xE493B4", VA = "0xE493B4")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741C7C", Offset = "0x741C7C")]
		public float tiltSpeed;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741CB4", Offset = "0x741CB4")]
		public float tiltSensitivity;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741CEC", Offset = "0x741CEC")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741D24", Offset = "0x741D24")]
		public OffsetPose poseRight;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xE4A7A0", Offset = "0xE4A7A0", VA = "0xE4A7A0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xE4A7E8", Offset = "0xE4A7E8", VA = "0xE4A7E8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xE4AA20", Offset = "0xE4AA20", VA = "0xE4AA20")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40008B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743E8C", Offset = "0x743E8C")]
			public string name;

			[Token(Token = "0x40008BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743EC4", Offset = "0x743EC4")]
			public Collider collider;

			[Token(Token = "0x40008BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743EFC", Offset = "0x743EFC")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40008BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x743F48", Offset = "0x743F48")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40008BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x743F58", Offset = "0x743F58")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40008BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x743F68", Offset = "0x743F68")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40008BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x743F78", Offset = "0x743F78")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40008C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40008C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40008C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000E5")]
			public bool inProgress
			{
				[Token(Token = "0x6000A0A")]
				[Address(RVA = "0xF92470", Offset = "0xF92470", VA = "0xF92470")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E6")]
			protected float crossFader
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0xF92A28", Offset = "0xF92A28", VA = "0xF92A28")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747C74", Offset = "0x747C74")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A0C")]
				[Address(RVA = "0xF92A30", Offset = "0xF92A30", VA = "0xF92A30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747C84", Offset = "0x747C84")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			protected float timer
			{
				[Token(Token = "0x6000A0D")]
				[Address(RVA = "0xF92A38", Offset = "0xF92A38", VA = "0xF92A38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747C94", Offset = "0x747C94")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A0E")]
				[Address(RVA = "0xF92A40", Offset = "0xF92A40", VA = "0xF92A40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CA4", Offset = "0x747CA4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E8")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A0F")]
				[Address(RVA = "0xF92A48", Offset = "0xF92A48", VA = "0xF92A48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CB4", Offset = "0x747CB4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A10")]
				[Address(RVA = "0xF92A54", Offset = "0xF92A54", VA = "0xF92A54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CC4", Offset = "0x747CC4")]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A11")]
				[Address(RVA = "0xF92A60", Offset = "0xF92A60", VA = "0xF92A60")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CD4", Offset = "0x747CD4")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A12")]
				[Address(RVA = "0xF92A6C", Offset = "0xF92A6C", VA = "0xF92A6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CE4", Offset = "0x747CE4")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0xF928F4", Offset = "0xF928F4", VA = "0xF928F4")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0xF92560", Offset = "0xF92560", VA = "0xF92560")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A15")]
			protected abstract float GetLength();

			[Token(Token = "0x6000A16")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000A17")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xF92A78", Offset = "0xF92A78", VA = "0xF92A78")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013B")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200014C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000915")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744864", Offset = "0x744864")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000916")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74489C", Offset = "0x74489C")]
				public float weight;

				[Token(Token = "0x4000917")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000918")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000A51")]
				[Address(RVA = "0xF93448", Offset = "0xF93448", VA = "0xF93448")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A52")]
				[Address(RVA = "0xF93234", Offset = "0xF93234", VA = "0xF93234")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A53")]
				[Address(RVA = "0xF936CC", Offset = "0xF936CC", VA = "0xF936CC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743F88", Offset = "0x743F88")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743FC0", Offset = "0x743FC0")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x743FF8", Offset = "0x743FF8")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0xF9303C", Offset = "0xF9303C", VA = "0xF9303C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xF931C0", Offset = "0xF931C0", VA = "0xF931C0", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xF93248", Offset = "0xF93248", VA = "0xF93248", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xF93570", Offset = "0xF93570", VA = "0xF93570")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013C")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200014D")]
			public class BoneLink
			{
				[Token(Token = "0x4000919")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7448D4", Offset = "0x7448D4")]
				public Transform bone;

				[Token(Token = "0x400091A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74490C", Offset = "0x74490C")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x74490C", Offset = "0x74490C")]
				public float weight;

				[Token(Token = "0x400091B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x400091C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000A54")]
				[Address(RVA = "0xF92E40", Offset = "0xF92E40", VA = "0xF92E40")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A55")]
				[Address(RVA = "0xF92BB8", Offset = "0xF92BB8", VA = "0xF92BB8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A56")]
				[Address(RVA = "0xF92FB4", Offset = "0xF92FB4", VA = "0xF92FB4")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40008C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744030", Offset = "0x744030")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40008C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744068", Offset = "0x744068")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40008C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xF92A8C", Offset = "0xF92A8C", VA = "0xF92A8C", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xF92B3C", Offset = "0xF92B3C", VA = "0xF92B3C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xF92BD4", Offset = "0xF92BD4", VA = "0xF92BD4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0xF92FA0", Offset = "0xF92FA0", VA = "0xF92FA0")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741D5C", Offset = "0x741D5C")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741D94", Offset = "0x741D94")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000087")]
		public bool inProgress
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0xF923AC", Offset = "0xF923AC", VA = "0xF923AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xF92484", Offset = "0xF92484", VA = "0xF92484", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xF926AC", Offset = "0xF926AC", VA = "0xF926AC")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xF92A20", Offset = "0xF92A20", VA = "0xF92A20")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x200013D")]
		public abstract class Offset
		{
			[Token(Token = "0x40008C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7440A0", Offset = "0x7440A0")]
			public string name;

			[Token(Token = "0x40008CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7440D8", Offset = "0x7440D8")]
			public Collider collider;

			[Token(Token = "0x40008CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744110", Offset = "0x744110")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74415C", Offset = "0x74415C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74416C", Offset = "0x74416C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74417C", Offset = "0x74417C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x74418C", Offset = "0x74418C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000EA")]
			protected float crossFader
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0xF93C98", Offset = "0xF93C98", VA = "0xF93C98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747CF4", Offset = "0x747CF4")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A22")]
				[Address(RVA = "0xF93CA0", Offset = "0xF93CA0", VA = "0xF93CA0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D04", Offset = "0x747D04")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EB")]
			protected float timer
			{
				[Token(Token = "0x6000A23")]
				[Address(RVA = "0xF93CA8", Offset = "0xF93CA8", VA = "0xF93CA8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D14", Offset = "0x747D14")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000A24")]
				[Address(RVA = "0xF93CB0", Offset = "0xF93CB0", VA = "0xF93CB0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D24", Offset = "0x747D24")]
				private set
				{
				}
			}

			[Token(Token = "0x170000EC")]
			protected Vector3 force
			{
				[Token(Token = "0x6000A25")]
				[Address(RVA = "0xF93CB8", Offset = "0xF93CB8", VA = "0xF93CB8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D34", Offset = "0x747D34")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A26")]
				[Address(RVA = "0xF93CC4", Offset = "0xF93CC4", VA = "0xF93CC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D44", Offset = "0x747D44")]
				private set
				{
				}
			}

			[Token(Token = "0x170000ED")]
			protected Vector3 point
			{
				[Token(Token = "0x6000A27")]
				[Address(RVA = "0xF93CD0", Offset = "0xF93CD0", VA = "0xF93CD0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D54", Offset = "0x747D54")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0xF93CDC", Offset = "0xF93CDC", VA = "0xF93CDC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x747D64", Offset = "0x747D64")]
				private set
				{
				}
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0xF93B50", Offset = "0xF93B50", VA = "0xF93B50")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0xF937AC", Offset = "0xF937AC", VA = "0xF937AC")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A2B")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000A2C")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000A2D")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0xF93CE8", Offset = "0xF93CE8", VA = "0xF93CE8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013E")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200014E")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x400091D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744960", Offset = "0x744960")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x400091E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744998", Offset = "0x744998")]
				public float weight;

				[Token(Token = "0x400091F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000920")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000A57")]
				[Address(RVA = "0xF941C0", Offset = "0xF941C0", VA = "0xF941C0")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A58")]
				[Address(RVA = "0xF93F74", Offset = "0xF93F74", VA = "0xF93F74")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A59")]
				[Address(RVA = "0xF942E0", Offset = "0xF942E0", VA = "0xF942E0")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74419C", Offset = "0x74419C")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7441D4", Offset = "0x7441D4")]
			public int upDirCurveIndex;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74420C", Offset = "0x74420C")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0xF93CFC", Offset = "0xF93CFC", VA = "0xF93CFC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0xF93F00", Offset = "0xF93F00", VA = "0xF93F00", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xF93F88", Offset = "0xF93F88", VA = "0xF93F88", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A32")]
			[Address(RVA = "0xF942C4", Offset = "0xF942C4", VA = "0xF942C4")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200013F")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200014F")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000921")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7449D0", Offset = "0x7449D0")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000922")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744A08", Offset = "0x744A08")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0x744A08", Offset = "0x744A08")]
				public float weight;

				[Token(Token = "0x4000923")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000924")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000A5A")]
				[Address(RVA = "0xF9478C", Offset = "0xF9478C", VA = "0xF9478C")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000A5B")]
				[Address(RVA = "0xF94454", Offset = "0xF94454", VA = "0xF94454")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000A5C")]
				[Address(RVA = "0xF948CC", Offset = "0xF948CC", VA = "0xF948CC")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744244", Offset = "0x744244")]
			public int curveIndex;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74427C", Offset = "0x74427C")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0xF942E8", Offset = "0xF942E8", VA = "0xF942E8", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000A34")]
			[Address(RVA = "0xF943D8", Offset = "0xF943D8", VA = "0xF943D8", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0xF94470", Offset = "0xF94470", VA = "0xF94470", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0xF948B8", Offset = "0xF948B8", VA = "0xF948B8")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741DCC", Offset = "0x741DCC")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741E04", Offset = "0x741E04")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xF936D4", Offset = "0xF936D4", VA = "0xF936D4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xF93900", Offset = "0xF93900", VA = "0xF93900")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xF93C90", Offset = "0xF93C90", VA = "0xF93C90")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000140")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000150")]
			public class EffectorLink
			{
				[Token(Token = "0x4000925")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744A5C", Offset = "0x744A5C")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000926")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744A94", Offset = "0x744A94")]
				public float weight;

				[Token(Token = "0x6000A5D")]
				[Address(RVA = "0xEB8F1C", Offset = "0xEB8F1C", VA = "0xEB8F1C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7442B4", Offset = "0x7442B4")]
			public Transform transform;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7442EC", Offset = "0x7442EC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744324", Offset = "0x744324")]
			public float speed;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74435C", Offset = "0x74435C")]
			public float acceleration;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744394", Offset = "0x744394")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x744394", Offset = "0x744394")]
			public float matchVelocity;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7443E8", Offset = "0x7443E8")]
			public float gravity;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0xEB89D0", Offset = "0xEB89D0", VA = "0xEB89D0")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0xEB8B70", Offset = "0xEB8B70", VA = "0xEB8B70")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000A39")]
			[Address(RVA = "0xEB8F00", Offset = "0xEB8F00", VA = "0xEB8F00")]
			public Body()
			{
			}
		}

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741E3C", Offset = "0x741E3C")]
		public Body[] bodies;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741E74", Offset = "0x741E74")]
		public OffsetLimits[] limits;

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xEB894C", Offset = "0xEB894C", VA = "0xEB894C")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xEB8AAC", Offset = "0xEB8AAC", VA = "0xEB8AAC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xEB8EF8", Offset = "0xEB8EF8", VA = "0xEB8EF8")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000141")]
		public class OffsetLimits
		{
			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744420", Offset = "0x744420")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744458", Offset = "0x744458")]
			public float spring;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744490", Offset = "0x744490")]
			public bool x;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7444C8", Offset = "0x7444C8")]
			public bool y;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744500", Offset = "0x744500")]
			public bool z;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744538", Offset = "0x744538")]
			public float minX;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744570", Offset = "0x744570")]
			public float maxX;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7445A8", Offset = "0x7445A8")]
			public float minY;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7445E0", Offset = "0x7445E0")]
			public float maxY;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744618", Offset = "0x744618")]
			public float minZ;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744650", Offset = "0x744650")]
			public float maxZ;

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0xC3814C", Offset = "0xC3814C", VA = "0xC3814C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000A3B")]
			[Address(RVA = "0xC38674", Offset = "0xC38674", VA = "0xC38674")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000A3C")]
			[Address(RVA = "0xC386A4", Offset = "0xC386A4", VA = "0xC386A4")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000A3D")]
			[Address(RVA = "0xC3877C", Offset = "0xC3877C", VA = "0xC3877C")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF60", Offset = "0x73EF60")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000EE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A41")]
				[Address(RVA = "0xC38600", Offset = "0xC38600", VA = "0xC38600", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0xC3866C", Offset = "0xC3866C", VA = "0xC3866C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A3E")]
			[Address(RVA = "0xC37F50", Offset = "0xC37F50", VA = "0xC37F50")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A3F")]
			[Address(RVA = "0xC384BC", Offset = "0xC384BC", VA = "0xC384BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xC384C0", Offset = "0xC384C0", VA = "0xC384C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xC38608", Offset = "0xC38608", VA = "0xC38608", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741EAC", Offset = "0x741EAC")]
		public float weight;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741EE4", Offset = "0x741EE4")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000088")]
		protected float deltaTime
		{
			[Token(Token = "0x6000850")]
			[Address(RVA = "0xC37E84", Offset = "0xC37E84", VA = "0xC37E84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000851")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xC37EB0", Offset = "0xC37EB0", VA = "0xC37EB0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xC37EDC", Offset = "0xC37EDC", VA = "0xC37EDC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x74748C", Offset = "0x74748C")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xC37F7C", Offset = "0xC37F7C", VA = "0xC37F7C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xC38088", Offset = "0xC38088", VA = "0xC38088")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xC383B0", Offset = "0xC383B0", VA = "0xC383B0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0xC384AC", Offset = "0xC384AC", VA = "0xC384AC")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x73EF70", Offset = "0x73EF70")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000F0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A47")]
				[Address(RVA = "0xC38BD8", Offset = "0xC38BD8", VA = "0xC38BD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A49")]
				[Address(RVA = "0xC38C44", Offset = "0xC38C44", VA = "0xC38C44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xC38850", Offset = "0xC38850", VA = "0xC38850")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A45")]
			[Address(RVA = "0xC38A94", Offset = "0xC38A94", VA = "0xC38A94", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A46")]
			[Address(RVA = "0xC38A98", Offset = "0xC38A98", VA = "0xC38A98", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A48")]
			[Address(RVA = "0xC38BE0", Offset = "0xC38BE0", VA = "0xC38BE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F1C", Offset = "0x741F1C")]
		public float weight;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F54", Offset = "0x741F54")]
		public VRIK ik;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000089")]
		protected float deltaTime
		{
			[Token(Token = "0x6000858")]
			[Address(RVA = "0xC38784", Offset = "0xC38784", VA = "0xC38784")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000859")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600085A")]
		[Address(RVA = "0xC387B0", Offset = "0xC387B0", VA = "0xC387B0", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0xC387DC", Offset = "0xC387DC", VA = "0xC387DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x7474F0", Offset = "0x7474F0")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0xC3887C", Offset = "0xC3887C", VA = "0xC3887C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0xC38988", Offset = "0xC38988", VA = "0xC38988", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0xC38A84", Offset = "0xC38A84", VA = "0xC38A84")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000144")]
		public class EffectorLink
		{
			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000A4A")]
			[Address(RVA = "0xC38D10", Offset = "0xC38D10", VA = "0xC38D10")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0xC39160", Offset = "0xC39160", VA = "0xC39160")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600085F")]
		[Address(RVA = "0xC38C4C", Offset = "0xC38C4C", VA = "0xC38C4C")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0xC39040", Offset = "0xC39040", VA = "0xC39040")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0xC39100", Offset = "0xC39100", VA = "0xC39100")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000145")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000151")]
			public class EffectorLink
			{
				[Token(Token = "0x4000927")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744ACC", Offset = "0x744ACC")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000928")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744B04", Offset = "0x744B04")]
				public float weight;

				[Token(Token = "0x6000A5E")]
				[Address(RVA = "0xC3C1D0", Offset = "0xC3C1D0", VA = "0xC3C1D0")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744688", Offset = "0x744688")]
			public Vector3 offset;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7446C0", Offset = "0x7446C0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7446C0", Offset = "0x7446C0")]
			public float additivity;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x744714", Offset = "0x744714")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74474C", Offset = "0x74474C")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0xC3AF74", Offset = "0xC3AF74", VA = "0xC3AF74")]
			public void Start()
			{
			}

			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0xC3BA98", Offset = "0xC3BA98", VA = "0xC3BA98")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0xC3C1B8", Offset = "0xC3C1B8", VA = "0xC3C1B8")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000146")]
		public enum Handedness
		{
			[Token(Token = "0x4000900")]
			Right,
			[Token(Token = "0x4000901")]
			Left
		}

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741F8C", Offset = "0x741F8C")]
		public AimIK aimIK;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741FC4", Offset = "0x741FC4")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x741FFC", Offset = "0x741FFC")]
		public Handedness handedness;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742034", Offset = "0x742034")]
		public bool twoHanded;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74206C", Offset = "0x74206C")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7420A4", Offset = "0x7420A4")]
		public float magnitudeRandom;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7420DC", Offset = "0x7420DC")]
		public Vector3 rotationRandom;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742114", Offset = "0x742114")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74214C", Offset = "0x74214C")]
		public float blendTime;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x742184", Offset = "0x742184")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x742184", Offset = "0x742184")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700008A")]
		public bool isFinished
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xC3AD40", Offset = "0xC3AD40", VA = "0xC3AD40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xC3BD54", Offset = "0xC3BD54", VA = "0xC3BD54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xC3BD98", Offset = "0xC3BD98", VA = "0xC3BD98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		private Transform primaryHand
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xC3BD14", Offset = "0xC3BD14", VA = "0xC3BD14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private Transform secondaryHand
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xC3BD34", Offset = "0xC3BD34", VA = "0xC3BD34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0xC3AD70", Offset = "0xC3AD70", VA = "0xC3AD70")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0xC3AD9C", Offset = "0xC3AD9C", VA = "0xC3AD9C")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0xC3B024", Offset = "0xC3B024", VA = "0xC3B024", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0xC3BDDC", Offset = "0xC3BDDC", VA = "0xC3BDDC")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0xC3BF28", Offset = "0xC3BF28", VA = "0xC3BF28")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xC3BF68", Offset = "0xC3BF68", VA = "0xC3BF68", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xC3C104", Offset = "0xC3C104", VA = "0xC3C104")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x7421E4", Offset = "0x7421E4")]
		public float weight;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x74221C", Offset = "0x74221C")]
		public float offset;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xC3F9A0", Offset = "0xC3F9A0", VA = "0xC3F9A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xC3FA7C", Offset = "0xC3FA7C", VA = "0xC3FA7C")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0xC3FB6C", Offset = "0xC3FB6C", VA = "0xC3FB6C")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xC3FFBC", Offset = "0xC3FFBC", VA = "0xC3FFBC")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xC3FFF8", Offset = "0xC3FFF8", VA = "0xC3FFF8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0xC400F4", Offset = "0xC400F4", VA = "0xC400F4")]
		public ShoulderRotator()
		{
		}
	}
}
namespace DentedPixel
{
	[Token(Token = "0x20000CA")]
	public class LeanDummy
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0xB4D9D8", Offset = "0xB4D9D8", VA = "0xB4D9D8")]
		public LeanDummy()
		{
		}
	}
}
