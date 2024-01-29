using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CodeStage.AdvancedFPSCounter.CountersData;
using CodeStage.AdvancedFPSCounter.Labels;
using CodeStage.AdvancedFPSCounter.Utils;
using Facepunch.Steamworks;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Profiling;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using VLB;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public class FacepunchSteamworksTest : MonoBehaviour
{
	private Client steamClient;

	private void OnEnable()
	{
		steamClient = new Client(220u);
		if (!steamClient.IsValid)
		{
			steamClient.Dispose();
			throw new Exception("Couldn't init Steam - is Steam running? Do you own Half-Life 2? Is steam_appid.txt in your project folder?");
		}
		Debug.Log("Hello " + steamClient.Username);
		Debug.Log("Your SteamID is " + steamClient.SteamId);
	}

	private void OnDisable()
	{
		if (steamClient != null)
		{
			steamClient.Dispose();
			steamClient = null;
		}
	}
}
public class LeanAudioStream
{
	public int position;

	public AudioClip audioClip;

	public float[] audioArr;

	public LeanAudioStream(float[] audioArr)
	{
		this.audioArr = audioArr;
	}

	public void OnAudioRead(float[] data)
	{
		for (int i = 0; i < data.Length; i++)
		{
			data[i] = audioArr[position];
			position++;
		}
	}

	public void OnAudioSetPosition(int newPosition)
	{
		position = newPosition;
	}
}
public class LeanAudio
{
	public static float MIN_FREQEUNCY_PERIOD = 0.000115f;

	public static int PROCESSING_ITERATIONS_MAX = 50000;

	public static float[] generatedWaveDistances;

	public static int generatedWaveDistancesCount = 0;

	private static float[] longList;

	public static LeanAudioOptions options()
	{
		if (generatedWaveDistances == null)
		{
			generatedWaveDistances = new float[PROCESSING_ITERATIONS_MAX];
			longList = new float[PROCESSING_ITERATIONS_MAX];
		}
		return new LeanAudioOptions();
	}

	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		if (options == null)
		{
			options = new LeanAudioOptions();
		}
		options.useSetData = false;
		createAudioFromWave(createAudioWave(volume, frequency, options), options);
		return options.stream;
	}

	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options = null)
	{
		if (options == null)
		{
			options = new LeanAudioOptions();
		}
		return createAudioFromWave(createAudioWave(volume, frequency, options), options);
	}

	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		float time = volume[volume.length - 1].time;
		int num = 0;
		float num2 = 0f;
		for (int i = 0; i < PROCESSING_ITERATIONS_MAX; i++)
		{
			float num3 = frequency.Evaluate(num2);
			if (num3 < MIN_FREQEUNCY_PERIOD)
			{
				num3 = MIN_FREQEUNCY_PERIOD;
			}
			float num4 = volume.Evaluate(num2 + 0.5f * num3);
			if (options.vibrato != null)
			{
				for (int j = 0; j < options.vibrato.Length; j++)
				{
					float num5 = Mathf.Abs(Mathf.Sin(1.5708f + num2 * (1f / options.vibrato[j][0]) * (float)Math.PI));
					float num6 = 1f - options.vibrato[j][1];
					num5 = options.vibrato[j][1] + num6 * num5;
					num4 *= num5;
				}
			}
			if (num2 + 0.5f * num3 >= time)
			{
				break;
			}
			if (num >= PROCESSING_ITERATIONS_MAX - 1)
			{
				Debug.LogError("LeanAudio has reached it's processing cap. To avoid this error increase the number of iterations ex: LeanAudio.PROCESSING_ITERATIONS_MAX = " + PROCESSING_ITERATIONS_MAX * 2);
				break;
			}
			int num7 = num / 2;
			num2 += num3;
			generatedWaveDistances[num7] = num2;
			longList[num] = num2;
			longList[num + 1] = ((i % 2 == 0) ? (0f - num4) : num4);
			num += 2;
		}
		num += -2;
		generatedWaveDistancesCount = num / 2;
		return num;
	}

	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		float num = longList[waveLength - 2];
		float[] array = new float[(int)((float)options.frequencyRate * num)];
		int num2 = 0;
		float num3 = longList[num2];
		float num4 = 0f;
		_ = longList[num2];
		float num5 = longList[num2 + 1];
		for (int i = 0; i < array.Length; i++)
		{
			float num6 = (float)i / (float)options.frequencyRate;
			if (num6 > longList[num2])
			{
				num4 = longList[num2];
				num2 += 2;
				num3 = longList[num2] - longList[num2 - 2];
				num5 = longList[num2 + 1];
			}
			float num7 = (num6 - num4) / num3;
			float num8 = Mathf.Sin(num7 * (float)Math.PI);
			if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Square)
			{
				if (num8 > 0f)
				{
					num8 = 1f;
				}
				if (num8 < 0f)
				{
					num8 = -1f;
				}
			}
			else if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Sawtooth)
			{
				float num9 = ((num8 > 0f) ? 1f : (-1f));
				num8 = ((!(num7 < 0.5f)) ? ((1f - num7) * 2f * num9) : (num7 * 2f * num9));
			}
			else if (options.waveStyle == LeanAudioOptions.LeanAudioWaveStyle.Noise)
			{
				float num10 = 1f - options.waveNoiseInfluence + Mathf.PerlinNoise(0f, num6 * options.waveNoiseScale) * options.waveNoiseInfluence;
				num8 *= num10;
			}
			num8 *= num5;
			if (options.modulation != null)
			{
				for (int j = 0; j < options.modulation.Length; j++)
				{
					float num11 = Mathf.Abs(Mathf.Sin(1.5708f + num6 * (1f / options.modulation[j][0]) * (float)Math.PI));
					float num12 = 1f - options.modulation[j][1];
					num11 = options.modulation[j][1] + num12 * num11;
					num8 *= num11;
				}
			}
			array[i] = num8;
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = null;
		if (options.useSetData)
		{
			audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, options.frequencyRate, stream: false, null, OnAudioSetPosition);
			audioClip.SetData(array, 0);
		}
		else
		{
			options.stream = new LeanAudioStream(array);
			audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, options.frequencyRate, stream: false, options.stream.OnAudioRead, options.stream.OnAudioSetPosition);
			options.stream.audioClip = audioClip;
		}
		return audioClip;
	}

	private static void OnAudioSetPosition(int newPosition)
	{
	}

	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		float time = curve[curve.length - 1].time;
		float[] array = new float[(int)((float)frequencyRate * time)];
		for (int i = 0; i < array.Length; i++)
		{
			float time2 = (float)i / (float)frequencyRate;
			array[i] = curve.Evaluate(time2);
		}
		int lengthSamples = array.Length;
		AudioClip audioClip = AudioClip.Create("Generated Audio", lengthSamples, 1, frequencyRate, stream: false);
		audioClip.SetData(array, 0);
		return audioClip;
	}

	public static AudioSource play(AudioClip audio, float volume)
	{
		AudioSource audioSource = playClipAt(audio, Vector3.zero);
		audioSource.volume = volume;
		return audioSource;
	}

	public static AudioSource play(AudioClip audio)
	{
		return playClipAt(audio, Vector3.zero);
	}

	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return playClipAt(audio, pos);
	}

	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		AudioSource audioSource = playClipAt(audio, pos);
		audioSource.minDistance = 1f;
		audioSource.volume = volume;
		return audioSource;
	}

	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		GameObject gameObject = new GameObject();
		gameObject.transform.position = pos;
		AudioSource audioSource = gameObject.AddComponent<AudioSource>();
		audioSource.clip = clip;
		audioSource.Play();
		UnityEngine.Object.Destroy(gameObject, clip.length);
		return audioSource;
	}

	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
		float[] array = new float[audioClip.samples * audioClip.channels];
		audioClip.GetData(array, 0);
		int i = 0;
		Keyframe[] array2 = new Keyframe[array.Length];
		for (; i < array.Length; i++)
		{
			array2[i] = new Keyframe((float)i * scaleX, array[i]);
		}
		curve = new AnimationCurve(array2);
	}
}
public class LeanAudioOptions
{
	public enum LeanAudioWaveStyle
	{
		Sine,
		Square,
		Sawtooth,
		Noise
	}

	public LeanAudioWaveStyle waveStyle;

	public Vector3[] vibrato;

	public Vector3[] modulation;

	public int frequencyRate = 44100;

	public float waveNoiseScale = 1000f;

	public float waveNoiseInfluence = 1f;

	public bool useSetData = true;

	public LeanAudioStream stream;

	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		this.frequencyRate = frequencyRate;
		return this;
	}

	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		this.vibrato = vibrato;
		return this;
	}

	public LeanAudioOptions setWaveSine()
	{
		waveStyle = LeanAudioWaveStyle.Sine;
		return this;
	}

	public LeanAudioOptions setWaveSquare()
	{
		waveStyle = LeanAudioWaveStyle.Square;
		return this;
	}

	public LeanAudioOptions setWaveSawtooth()
	{
		waveStyle = LeanAudioWaveStyle.Sawtooth;
		return this;
	}

	public LeanAudioOptions setWaveNoise()
	{
		waveStyle = LeanAudioWaveStyle.Noise;
		return this;
	}

	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		waveStyle = style;
		return this;
	}

	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		waveNoiseScale = waveScale;
		return this;
	}

	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		waveNoiseInfluence = influence;
		return this;
	}
}
public class LeanTester : MonoBehaviour
{
	public float timeout = 15f;

	public void Start()
	{
		StartCoroutine(timeoutCheck());
	}

	private IEnumerator timeoutCheck()
	{
		float pauseEndTime = Time.realtimeSinceStartup + timeout;
		while (Time.realtimeSinceStartup < pauseEndTime)
		{
			yield return 0;
		}
		if (!LeanTest.testsFinished)
		{
			Debug.Log(LeanTest.formatB("Tests timed out!"));
			LeanTest.overview();
		}
	}
}
public class LeanTest
{
	public static int expected = 0;

	private static int tests = 0;

	private static int passes = 0;

	public static float timeout = 15f;

	public static bool timeoutStarted = false;

	public static bool testsFinished = false;

	public static void debug(string name, bool didPass, string failExplaination = null)
	{
		expect(didPass, name, failExplaination);
	}

	public static void expect(bool didPass, string definition, string failExplaination = null)
	{
		float num = printOutLength(definition);
		int totalWidth = 40 - (int)(num * 1.05f);
		string text = "".PadRight(totalWidth, "_"[0]);
		string text2 = formatB(definition) + " " + text + " [ " + (didPass ? formatC("pass", "green") : formatC("fail", "red")) + " ]";
		if (!didPass && failExplaination != null)
		{
			text2 = text2 + " - " + failExplaination;
		}
		Debug.Log(text2);
		if (didPass)
		{
			passes++;
		}
		tests++;
		if (tests == expected && !testsFinished)
		{
			overview();
		}
		else if (tests > expected)
		{
			Debug.Log(formatB("Too many tests for a final report!") + " set LeanTest.expected = " + tests);
		}
		if (!timeoutStarted)
		{
			timeoutStarted = true;
			GameObject obj = new GameObject
			{
				name = "~LeanTest"
			};
			(obj.AddComponent(typeof(LeanTester)) as LeanTester).timeout = timeout;
			obj.hideFlags = HideFlags.HideAndDontSave;
		}
	}

	public static string padRight(int len)
	{
		string text = "";
		for (int i = 0; i < len; i++)
		{
			text += "_";
		}
		return text;
	}

	public static float printOutLength(string str)
	{
		float num = 0f;
		for (int i = 0; i < str.Length; i++)
		{
			num = ((str[i] != "I"[0]) ? ((str[i] != "J"[0]) ? (num + 1f) : (num + 0.85f)) : (num + 0.5f));
		}
		return num;
	}

	public static string formatBC(string str, string color)
	{
		return formatC(formatB(str), color);
	}

	public static string formatB(string str)
	{
		return "<b>" + str + "</b>";
	}

	public static string formatC(string str, string color)
	{
		return "<color=" + color + ">" + str + "</color>";
	}

	public static void overview()
	{
		testsFinished = true;
		int num = expected - passes;
		string text = ((num > 0) ? formatBC(string.Concat(num), "red") : string.Concat(num));
		Debug.Log(formatB("Final Report:") + " _____________________ PASSED: " + formatBC(string.Concat(passes), "green") + " FAILED: " + text + " ");
	}
}
public enum TweenAction
{
	MOVE_X,
	MOVE_Y,
	MOVE_Z,
	MOVE_LOCAL_X,
	MOVE_LOCAL_Y,
	MOVE_LOCAL_Z,
	MOVE_CURVED,
	MOVE_CURVED_LOCAL,
	MOVE_SPLINE,
	MOVE_SPLINE_LOCAL,
	SCALE_X,
	SCALE_Y,
	SCALE_Z,
	ROTATE_X,
	ROTATE_Y,
	ROTATE_Z,
	ROTATE_AROUND,
	ROTATE_AROUND_LOCAL,
	CANVAS_ROTATEAROUND,
	CANVAS_ROTATEAROUND_LOCAL,
	CANVAS_PLAYSPRITE,
	ALPHA,
	TEXT_ALPHA,
	CANVAS_ALPHA,
	CANVASGROUP_ALPHA,
	ALPHA_VERTEX,
	COLOR,
	CALLBACK_COLOR,
	TEXT_COLOR,
	CANVAS_COLOR,
	CANVAS_MOVE_X,
	CANVAS_MOVE_Y,
	CANVAS_MOVE_Z,
	CALLBACK,
	MOVE,
	MOVE_LOCAL,
	MOVE_TO_TRANSFORM,
	ROTATE,
	ROTATE_LOCAL,
	SCALE,
	VALUE3,
	GUI_MOVE,
	GUI_MOVE_MARGIN,
	GUI_SCALE,
	GUI_ALPHA,
	GUI_ROTATE,
	DELAYED_SOUND,
	CANVAS_MOVE,
	CANVAS_SCALE,
	CANVAS_SIZEDELTA
}
public enum LeanTweenType
{
	notUsed,
	linear,
	easeOutQuad,
	easeInQuad,
	easeInOutQuad,
	easeInCubic,
	easeOutCubic,
	easeInOutCubic,
	easeInQuart,
	easeOutQuart,
	easeInOutQuart,
	easeInQuint,
	easeOutQuint,
	easeInOutQuint,
	easeInSine,
	easeOutSine,
	easeInOutSine,
	easeInExpo,
	easeOutExpo,
	easeInOutExpo,
	easeInCirc,
	easeOutCirc,
	easeInOutCirc,
	easeInBounce,
	easeOutBounce,
	easeInOutBounce,
	easeInBack,
	easeOutBack,
	easeInOutBack,
	easeInElastic,
	easeOutElastic,
	easeInOutElastic,
	easeSpring,
	easeShake,
	punch,
	once,
	clamp,
	pingPong,
	animationCurve
}
public class LeanTween : MonoBehaviour
{
	public static bool throwErrors = true;

	public static float tau = (float)Math.PI * 2f;

	public static float PI_DIV2 = (float)Math.PI / 2f;

	private static LTSeq[] sequences;

	private static LTDescr[] tweens;

	private static int[] tweensFinished;

	private static LTDescr tween;

	private static int tweenMaxSearch = -1;

	private static int maxTweens = 400;

	private static int maxSequences = 400;

	private static int frameRendered = -1;

	private static GameObject _tweenEmpty;

	public static float dtEstimated = -1f;

	public static float dtManual;

	public static float dtActual;

	private static uint global_counter = 0u;

	private static int i;

	private static int j;

	private static int finishedCnt;

	public static AnimationCurve punch = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.112586f, 0.9976035f), new Keyframe(0.3120486f, -0.1720615f), new Keyframe(0.4316337f, 0.07030682f), new Keyframe(0.5524869f, -0.03141804f), new Keyframe(0.6549395f, 0.003909959f), new Keyframe(0.770987f, -0.009817753f), new Keyframe(0.8838775f, 0.001939224f), new Keyframe(1f, 0f));

	public static AnimationCurve shake = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.25f, 1f), new Keyframe(0.75f, -1f), new Keyframe(1f, 0f));

	private static int maxTweenReached;

	public static int startSearch = 0;

	public static LTDescr d;

	private static Action<LTEvent>[] eventListeners;

	private static GameObject[] goListeners;

	private static int eventsMaxSearch = 0;

	public static int EVENTS_MAX = 10;

	public static int LISTENERS_MAX = 10;

	private static int INIT_LISTENERS_MAX = LISTENERS_MAX;

	public static int maxSearch => tweenMaxSearch;

	public static int maxSimulataneousTweens => maxTweens;

	public static int tweensRunning
	{
		get
		{
			int num = 0;
			for (int i = 0; i <= tweenMaxSearch; i++)
			{
				if (tweens[i].toggle)
				{
					num++;
				}
			}
			return num;
		}
	}

	public static GameObject tweenEmpty
	{
		get
		{
			init(maxTweens);
			return _tweenEmpty;
		}
	}

	public static void init()
	{
		init(maxTweens);
	}

	public static void init(int maxSimultaneousTweens)
	{
		init(maxSimultaneousTweens, maxSequences);
	}

	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
		if (tweens == null)
		{
			maxTweens = maxSimultaneousTweens;
			tweens = new LTDescr[maxTweens];
			tweensFinished = new int[maxTweens];
			_tweenEmpty = new GameObject();
			_tweenEmpty.name = "~LeanTween";
			_tweenEmpty.AddComponent(typeof(LeanTween));
			_tweenEmpty.isStatic = true;
			_tweenEmpty.hideFlags = HideFlags.HideAndDontSave;
			UnityEngine.Object.DontDestroyOnLoad(_tweenEmpty);
			for (int i = 0; i < maxTweens; i++)
			{
				tweens[i] = new LTDescr();
			}
			SceneManager.sceneLoaded += onLevelWasLoaded54;
			sequences = new LTSeq[maxSimultaneousSequences];
			for (int j = 0; j < maxSimultaneousSequences; j++)
			{
				sequences[j] = new LTSeq();
			}
		}
	}

	public static void reset()
	{
		if (tweens != null)
		{
			for (int i = 0; i <= tweenMaxSearch; i++)
			{
				if (tweens[i] != null)
				{
					tweens[i].toggle = false;
				}
			}
		}
		tweens = null;
		UnityEngine.Object.Destroy(_tweenEmpty);
	}

	public void Update()
	{
		update();
	}

	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
		internalOnLevelWasLoaded(scene.buildIndex);
	}

	private static void internalOnLevelWasLoaded(int lvl)
	{
		LTGUI.reset();
	}

	public static void update()
	{
		if (frameRendered == Time.frameCount)
		{
			return;
		}
		init();
		dtEstimated = ((dtEstimated < 0f) ? 0f : (dtEstimated = Time.unscaledDeltaTime));
		dtActual = Time.deltaTime;
		maxTweenReached = 0;
		finishedCnt = 0;
		for (int i = 0; i <= tweenMaxSearch && i < maxTweens; i++)
		{
			tween = tweens[i];
			if (tween.toggle)
			{
				maxTweenReached = i;
				if (tween.updateInternal())
				{
					tweensFinished[finishedCnt] = i;
					finishedCnt++;
				}
			}
		}
		tweenMaxSearch = maxTweenReached;
		frameRendered = Time.frameCount;
		for (int j = 0; j < finishedCnt; j++)
		{
			LeanTween.j = tweensFinished[j];
			tween = tweens[LeanTween.j];
			removeTween(LeanTween.j);
			if (tween.hasExtraOnCompletes && tween.trans != null)
			{
				tween.callOnCompletes();
			}
		}
	}

	public static void removeTween(int i, int uniqueId)
	{
		if (tweens[i].uniqueId == uniqueId)
		{
			removeTween(i);
		}
	}

	public static void removeTween(int i)
	{
		if (!tweens[i].toggle)
		{
			return;
		}
		tweens[i].toggle = false;
		if (tweens[i].destroyOnComplete)
		{
			if (tweens[i].ltRect != null)
			{
				LTGUI.destroy(tweens[i].ltRect.id);
			}
			else if (tweens[i].trans != null && tweens[i].trans.gameObject != _tweenEmpty)
			{
				UnityEngine.Object.Destroy(tweens[i].trans.gameObject);
			}
		}
		startSearch = i;
		if (i + 1 >= tweenMaxSearch)
		{
			startSearch = 0;
		}
	}

	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		Vector3[] array = new Vector3[a.Length];
		for (i = 0; i < a.Length; i++)
		{
			array[i] = a[i] + b;
		}
		return array;
	}

	public static float closestRot(float from, float to)
	{
		float num = 0f - (360f - to);
		float num2 = 360f + to;
		float num3 = Mathf.Abs(to - from);
		float num4 = Mathf.Abs(num - from);
		float num5 = Mathf.Abs(num2 - from);
		if (num3 < num4 && num3 < num5)
		{
			return to;
		}
		if (num4 < num5)
		{
			return num;
		}
		return num2;
	}

	public static void cancelAll()
	{
		cancelAll(callComplete: false);
	}

	public static void cancelAll(bool callComplete)
	{
		init();
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].trans != null)
			{
				if (callComplete && tweens[i].optional.onComplete != null)
				{
					tweens[i].optional.onComplete();
				}
				removeTween(i);
			}
		}
	}

	public static void cancel(GameObject gameObject)
	{
		cancel(gameObject, callOnComplete: false);
	}

	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
		init();
		Transform transform = gameObject.transform;
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].toggle && tweens[i].trans == transform)
			{
				if (callOnComplete && tweens[i].optional.onComplete != null)
				{
					tweens[i].optional.onComplete();
				}
				removeTween(i);
			}
		}
	}

	public static void cancel(RectTransform rect)
	{
		cancel(rect.gameObject, callOnComplete: false);
	}

	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
		if (uniqueId < 0)
		{
			return;
		}
		init();
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (tweens[num].trans == null || (tweens[num].trans.gameObject == gameObject && tweens[num].counter == num2))
		{
			if (callOnComplete && tweens[num].optional.onComplete != null)
			{
				tweens[num].optional.onComplete();
			}
			removeTween(num);
		}
	}

	public static void cancel(LTRect ltRect, int uniqueId)
	{
		if (uniqueId >= 0)
		{
			init();
			int num = uniqueId & 0xFFFF;
			int num2 = uniqueId >> 16;
			if (tweens[num].ltRect == ltRect && tweens[num].counter == num2)
			{
				removeTween(num);
			}
		}
	}

	public static void cancel(int uniqueId)
	{
		cancel(uniqueId, callOnComplete: false);
	}

	public static void cancel(int uniqueId, bool callOnComplete)
	{
		if (uniqueId < 0)
		{
			return;
		}
		init();
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (num > tweens.Length - 1)
		{
			int num3 = num - tweens.Length;
			LTSeq lTSeq = sequences[num3];
			for (int i = 0; i < maxSequences; i++)
			{
				if (lTSeq.current.tween != null)
				{
					removeTween(lTSeq.current.tween.uniqueId & 0xFFFF);
				}
				if (lTSeq.previous != null)
				{
					lTSeq.current = lTSeq.previous;
					continue;
				}
				break;
			}
		}
		else if (tweens[num].counter == num2)
		{
			if (callOnComplete && tweens[num].optional.onComplete != null)
			{
				tweens[num].optional.onComplete();
			}
			removeTween(num);
		}
	}

	public static LTDescr descr(int uniqueId)
	{
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (tweens[num] != null && tweens[num].uniqueId == uniqueId && tweens[num].counter == num2)
		{
			return tweens[num];
		}
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].uniqueId == uniqueId && tweens[i].counter == num2)
			{
				return tweens[i];
			}
		}
		return null;
	}

	public static LTDescr description(int uniqueId)
	{
		return descr(uniqueId);
	}

	public static LTDescr[] descriptions(GameObject gameObject = null)
	{
		if (gameObject == null)
		{
			return null;
		}
		List<LTDescr> list = new List<LTDescr>();
		Transform transform = gameObject.transform;
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].toggle && tweens[i].trans == transform)
			{
				list.Add(tweens[i]);
			}
		}
		return list.ToArray();
	}

	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
		pause(uniqueId);
	}

	public static void pause(int uniqueId)
	{
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (tweens[num].counter == num2)
		{
			tweens[num].pause();
		}
	}

	public static void pause(GameObject gameObject)
	{
		Transform transform = gameObject.transform;
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].trans == transform)
			{
				tweens[i].pause();
			}
		}
	}

	public static void pauseAll()
	{
		init();
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			tweens[i].pause();
		}
	}

	public static void resumeAll()
	{
		init();
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			tweens[i].resume();
		}
	}

	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
		resume(uniqueId);
	}

	public static void resume(int uniqueId)
	{
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (tweens[num].counter == num2)
		{
			tweens[num].resume();
		}
	}

	public static void resume(GameObject gameObject)
	{
		Transform transform = gameObject.transform;
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].trans == transform)
			{
				tweens[i].resume();
			}
		}
	}

	public static bool isTweening(GameObject gameObject = null)
	{
		if (gameObject == null)
		{
			for (int i = 0; i <= tweenMaxSearch; i++)
			{
				if (tweens[i].toggle)
				{
					return true;
				}
			}
			return false;
		}
		Transform transform = gameObject.transform;
		for (int j = 0; j <= tweenMaxSearch; j++)
		{
			if (tweens[j].toggle && tweens[j].trans == transform)
			{
				return true;
			}
		}
		return false;
	}

	public static bool isTweening(RectTransform rect)
	{
		return isTweening(rect.gameObject);
	}

	public static bool isTweening(int uniqueId)
	{
		int num = uniqueId & 0xFFFF;
		int num2 = uniqueId >> 16;
		if (num < 0 || num >= maxTweens)
		{
			return false;
		}
		if (tweens[num].counter == num2 && tweens[num].toggle)
		{
			return true;
		}
		return false;
	}

	public static bool isTweening(LTRect ltRect)
	{
		for (int i = 0; i <= tweenMaxSearch; i++)
		{
			if (tweens[i].toggle && tweens[i].ltRect == ltRect)
			{
				return true;
			}
		}
		return false;
	}

	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, Transform arrowTransform = null)
	{
		Vector3 vector = a;
		Vector3 vector2 = -a + 3f * (b - c) + d;
		Vector3 vector3 = 3f * (a + c) - 6f * b;
		Vector3 vector4 = 3f * (b - a);
		if (arrowSize > 0f)
		{
			Vector3 position = arrowTransform.position;
			Quaternion rotation = arrowTransform.rotation;
			float num = 0f;
			for (float num2 = 1f; num2 <= 120f; num2 += 1f)
			{
				float num3 = num2 / 120f;
				Vector3 vector5 = ((vector2 * num3 + vector3) * num3 + vector4) * num3 + a;
				Gizmos.DrawLine(vector, vector5);
				num += (vector5 - vector).magnitude;
				if (num > 1f)
				{
					num -= 1f;
					arrowTransform.position = vector5;
					arrowTransform.LookAt(vector, Vector3.forward);
					Vector3 vector6 = arrowTransform.TransformDirection(Vector3.right);
					Vector3 normalized = (vector - vector5).normalized;
					Gizmos.DrawLine(vector5, vector5 + (vector6 + normalized) * arrowSize);
					vector6 = arrowTransform.TransformDirection(-Vector3.right);
					Gizmos.DrawLine(vector5, vector5 + (vector6 + normalized) * arrowSize);
				}
				vector = vector5;
			}
			arrowTransform.position = position;
			arrowTransform.rotation = rotation;
		}
		else
		{
			for (float num4 = 1f; num4 <= 30f; num4 += 1f)
			{
				float num3 = num4 / 30f;
				Vector3 vector5 = ((vector2 * num3 + vector3) * num3 + vector4) * num3 + a;
				Gizmos.DrawLine(vector, vector5);
				vector = vector5;
			}
		}
	}

	public static object logError(string error)
	{
		if (throwErrors)
		{
			Debug.LogError(error);
		}
		else
		{
			Debug.Log(error);
		}
		return null;
	}

	public static LTDescr options(LTDescr seed)
	{
		Debug.LogError("error this function is no longer used");
		return null;
	}

	public static LTDescr options()
	{
		init();
		bool flag = false;
		j = 0;
		i = startSearch;
		while (j <= maxTweens)
		{
			if (j >= maxTweens)
			{
				return logError("LeanTween - You have run out of available spaces for tweening. To avoid this error increase the number of spaces to available for tweening when you initialize the LeanTween class ex: LeanTween.init( " + maxTweens * 2 + " );") as LTDescr;
			}
			if (i >= maxTweens)
			{
				i = 0;
			}
			if (!tweens[i].toggle)
			{
				if (i + 1 > tweenMaxSearch)
				{
					tweenMaxSearch = i + 1;
				}
				startSearch = i + 1;
				flag = true;
				break;
			}
			j++;
			i++;
		}
		if (!flag)
		{
			logError("no available tween found!");
		}
		tweens[i].reset();
		global_counter++;
		if (global_counter > 32768)
		{
			global_counter = 0u;
		}
		tweens[i].setId((uint)i, global_counter);
		return tweens[i];
	}

	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		init(maxTweens);
		if (gameObject == null || tween == null)
		{
			return null;
		}
		tween.trans = gameObject.transform;
		tween.to = to;
		tween.time = time;
		return tween;
	}

	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		float time = 0.25f * (float)sprites.Length;
		return pushNewTween(rectTransform.gameObject, new Vector3((float)sprites.Length - 1f, 0f, 0f), time, options().setCanvasPlaySprite().setSprites(sprites).setRepeat(-1));
	}

	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		LTDescr lTDescr = pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setAlpha());
		SpriteRenderer component = gameObject.GetComponent<SpriteRenderer>();
		lTDescr.spriteRen = component;
		return lTDescr;
	}

	public static LTSeq sequence(bool initSequence = true)
	{
		init(maxTweens);
		for (int i = 0; i < sequences.Length; i++)
		{
			if ((sequences[i].tween != null && sequences[i].tween.toggle) || sequences[i].toggle)
			{
				continue;
			}
			LTSeq lTSeq = sequences[i];
			if (initSequence)
			{
				lTSeq.init((uint)(i + tweens.Length), global_counter);
				global_counter++;
				if (global_counter > 32768)
				{
					global_counter = 0u;
				}
			}
			else
			{
				lTSeq.reset();
			}
			return lTSeq;
		}
		return null;
	}

	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		ltRect.alphaEnabled = true;
		return pushNewTween(tweenEmpty, new Vector3(to, 0f, 0f), time, options().setGUIAlpha().setRect(ltRect));
	}

	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return pushNewTween(rectTransform.gameObject, new Vector3(to, 0f, 0f), time, options().setTextAlpha());
	}

	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return pushNewTween(rectTransform.gameObject, new Vector3(to, 0f, 0f), time, options().setTextAlpha());
	}

	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return pushNewTween(canvasGroup.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasGroupAlpha());
	}

	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setAlphaVertex());
	}

	public static LTDescr color(GameObject gameObject, UnityEngine.Color to, float time)
	{
		LTDescr lTDescr = pushNewTween(gameObject, new Vector3(1f, to.a, 0f), time, options().setColor().setPoint(new Vector3(to.r, to.g, to.b)));
		SpriteRenderer component = gameObject.GetComponent<SpriteRenderer>();
		lTDescr.spriteRen = component;
		return lTDescr;
	}

	public static LTDescr textColor(RectTransform rectTransform, UnityEngine.Color to, float time)
	{
		return pushNewTween(rectTransform.gameObject, new Vector3(1f, to.a, 0f), time, options().setTextColor().setPoint(new Vector3(to.r, to.g, to.b)));
	}

	public static LTDescr colorText(RectTransform rectTransform, UnityEngine.Color to, float time)
	{
		return pushNewTween(rectTransform.gameObject, new Vector3(1f, to.a, 0f), time, options().setTextColor().setPoint(new Vector3(to.r, to.g, to.b)));
	}

	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return pushNewTween(tweenEmpty, Vector3.zero, delayTime, options().setCallback().setOnComplete(callback));
	}

	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return pushNewTween(tweenEmpty, Vector3.zero, delayTime, options().setCallback().setOnComplete(callback));
	}

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return pushNewTween(gameObject, Vector3.zero, delayTime, options().setCallback().setOnComplete(callback));
	}

	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return pushNewTween(gameObject, Vector3.zero, delayTime, options().setCallback().setOnComplete(callback));
	}

	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return pushNewTween(tweenEmpty, Vector3.zero, delayTime, options().setCallback().setRect(rect).setDestroyOnComplete(doesDestroy: true));
	}

	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setMove());
	}

	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to.x, to.y, gameObject.transform.position.z), time, options().setMove());
	}

	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		d = options().setMoveCurved();
		if (d.optional.path == null)
		{
			d.optional.path = new LTBezierPath(to);
		}
		else
		{
			d.optional.path.setPoints(to);
		}
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		d = options().setMoveCurved();
		d.optional.path = to;
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		d = options().setMoveSpline();
		d.optional.spline = to;
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		d = options().setMoveSpline();
		d.optional.spline = new LTSpline(to);
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		d = options().setMoveSpline();
		d.optional.spline = to;
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		d = options().setMoveSplineLocal();
		d.optional.spline = new LTSpline(to);
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return pushNewTween(tweenEmpty, to, time, options().setGUIMove().setRect(ltRect));
	}

	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return pushNewTween(tweenEmpty, to, time, options().setGUIMoveMargin().setRect(ltRect));
	}

	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveX());
	}

	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveY());
	}

	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveZ());
	}

	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setMoveLocal());
	}

	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		d = options().setMoveCurvedLocal();
		if (d.optional.path == null)
		{
			d.optional.path = new LTBezierPath(to);
		}
		else
		{
			d.optional.path.setPoints(to);
		}
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveLocalX());
	}

	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveLocalY());
	}

	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setMoveLocalZ());
	}

	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		d = options().setMoveCurvedLocal();
		d.optional.path = to;
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		d = options().setMoveSplineLocal();
		d.optional.spline = to;
		return pushNewTween(gameObject, new Vector3(1f, 0f, 0f), time, d);
	}

	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return pushNewTween(gameObject, Vector3.zero, time, options().setTo(to).setMoveToTransform());
	}

	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setRotate());
	}

	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return pushNewTween(tweenEmpty, new Vector3(to, 0f, 0f), time, options().setGUIRotate().setRect(ltRect));
	}

	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setRotateLocal());
	}

	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setRotateX());
	}

	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setRotateY());
	}

	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setRotateZ());
	}

	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return pushNewTween(gameObject, new Vector3(add, 0f, 0f), time, options().setAxis(axis).setRotateAround());
	}

	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return pushNewTween(gameObject, new Vector3(add, 0f, 0f), time, options().setRotateAroundLocal().setAxis(axis));
	}

	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setScale());
	}

	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return pushNewTween(tweenEmpty, to, time, options().setGUIScale().setRect(ltRect));
	}

	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setScaleX());
	}

	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setScaleY());
	}

	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setScaleZ());
	}

	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setCallback().setFrom(new Vector3(from, 0f, 0f)));
	}

	public static LTDescr value(float from, float to, float time)
	{
		return pushNewTween(tweenEmpty, new Vector3(to, 0f, 0f), time, options().setCallback().setFrom(new Vector3(from, 0f, 0f)));
	}

	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to.x, to.y, 0f), time, options().setValue3().setTo(new Vector3(to.x, to.y, 0f)).setFrom(new Vector3(from.x, from.y, 0f)));
	}

	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setValue3().setFrom(from));
	}

	public static LTDescr value(GameObject gameObject, UnityEngine.Color from, UnityEngine.Color to, float time)
	{
		LTDescr lTDescr = pushNewTween(gameObject, new Vector3(1f, to.a, 0f), time, options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setFromColor(from)
			.setHasInitialized(has: false));
		SpriteRenderer component = gameObject.GetComponent<SpriteRenderer>();
		lTDescr.spriteRen = component;
		return lTDescr;
	}

	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setCallback().setTo(new Vector3(to, 0f, 0f)).setFrom(new Vector3(from, 0f, 0f))
			.setOnUpdate(callOnUpdate));
	}

	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setCallback().setTo(new Vector3(to, 0f, 0f)).setFrom(new Vector3(from, 0f, 0f))
			.setOnUpdateRatio(callOnUpdateRatio));
	}

	public static LTDescr value(GameObject gameObject, Action<UnityEngine.Color> callOnUpdate, UnityEngine.Color from, UnityEngine.Color to, float time)
	{
		return pushNewTween(gameObject, new Vector3(1f, to.a, 0f), time, options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setAxis(new Vector3(from.r, from.g, from.b))
			.setFrom(new Vector3(0f, from.a, 0f))
			.setHasInitialized(has: false)
			.setOnUpdateColor(callOnUpdate));
	}

	public static LTDescr value(GameObject gameObject, Action<UnityEngine.Color, object> callOnUpdate, UnityEngine.Color from, UnityEngine.Color to, float time)
	{
		return pushNewTween(gameObject, new Vector3(1f, to.a, 0f), time, options().setCallbackColor().setPoint(new Vector3(to.r, to.g, to.b)).setAxis(new Vector3(from.r, from.g, from.b))
			.setFrom(new Vector3(0f, from.a, 0f))
			.setHasInitialized(has: false)
			.setOnUpdateColor(callOnUpdate));
	}

	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to.x, to.y, 0f), time, options().setValue3().setTo(new Vector3(to.x, to.y, 0f)).setFrom(new Vector3(from.x, from.y, 0f))
			.setOnUpdateVector2(callOnUpdate));
	}

	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return pushNewTween(gameObject, to, time, options().setValue3().setTo(to).setFrom(from)
			.setOnUpdateVector3(callOnUpdate));
	}

	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return pushNewTween(gameObject, new Vector3(to, 0f, 0f), time, options().setCallback().setTo(new Vector3(to, 0f, 0f)).setFrom(new Vector3(from, 0f, 0f))
			.setOnUpdate(callOnUpdate, gameObject));
	}

	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return pushNewTween(tweenEmpty, pos, 0f, options().setDelayedSound().setTo(pos).setFrom(new Vector3(volume, 0f, 0f))
			.setAudio(audio));
	}

	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return pushNewTween(gameObject, pos, 0f, options().setDelayedSound().setTo(pos).setFrom(new Vector3(volume, 0f, 0f))
			.setAudio(audio));
	}

	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return pushNewTween(rectTrans.gameObject, to, time, options().setCanvasMove().setRect(rectTrans));
	}

	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasMoveX().setRect(rectTrans));
	}

	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasMoveY().setRect(rectTrans));
	}

	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasMoveZ().setRect(rectTrans));
	}

	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasRotateAround().setRect(rectTrans).setAxis(Vector3.forward));
	}

	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return pushNewTween(rectTrans.gameObject, to, time, options().setCanvasRotateAround().setRect(rectTrans).setAxis(Vector3.forward));
	}

	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasRotateAround().setRect(rectTrans).setAxis(axis));
	}

	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasRotateAroundLocal().setRect(rectTrans).setAxis(axis));
	}

	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return pushNewTween(rectTrans.gameObject, to, time, options().setCanvasScale().setRect(rectTrans));
	}

	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return pushNewTween(rectTrans.gameObject, to, time, options().setCanvasSizeDelta().setRect(rectTrans));
	}

	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(to, 0f, 0f), time, options().setCanvasAlpha().setRect(rectTrans));
	}

	public static LTDescr color(RectTransform rectTrans, UnityEngine.Color to, float time)
	{
		return pushNewTween(rectTrans.gameObject, new Vector3(1f, to.a, 0f), time, options().setCanvasColor().setRect(rectTrans).setPoint(new Vector3(to.r, to.g, to.b)));
	}

	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return tweenDescr.from.x + tweenDescr.diff.x * tweenDescr.optional.animationCurve.Evaluate(ratioPassed);
	}

	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return new Vector3(tweenDescr.from.x + tweenDescr.diff.x * tweenDescr.optional.animationCurve.Evaluate(ratioPassed), tweenDescr.from.y + tweenDescr.diff.y * tweenDescr.optional.animationCurve.Evaluate(ratioPassed), tweenDescr.from.z + tweenDescr.diff.z * tweenDescr.optional.animationCurve.Evaluate(ratioPassed));
	}

	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return (0f - diff) * ratioPassed * (ratioPassed - 2f) + start;
	}

	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return diff * ratioPassed * ratioPassed + start;
	}

	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		ratioPassed /= 0.5f;
		if (ratioPassed < 1f)
		{
			return diff / 2f * ratioPassed * ratioPassed + start;
		}
		ratioPassed -= 1f;
		return (0f - diff) / 2f * (ratioPassed * (ratioPassed - 2f) - 1f) + start;
	}

	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		ratioPassed /= 0.5f;
		if (ratioPassed < 1f)
		{
			return diff / 2f * ratioPassed * ratioPassed + start;
		}
		ratioPassed -= 1f;
		return -diff / 2f * (ratioPassed * (ratioPassed - 2f) - 1f) + start;
	}

	public static float linear(float start, float end, float val)
	{
		return Mathf.Lerp(start, end, val);
	}

	public static float clerp(float start, float end, float val)
	{
		float num = 0f;
		float num2 = 360f;
		float num3 = Mathf.Abs((num2 - num) / 2f);
		float num4 = 0f;
		float num5 = 0f;
		if (end - start < 0f - num3)
		{
			num5 = (num2 - start + end) * val;
			return start + num5;
		}
		if (end - start > num3)
		{
			num5 = (0f - (num2 - end + start)) * val;
			return start + num5;
		}
		return start + (end - start) * val;
	}

	public static float spring(float start, float end, float val)
	{
		val = Mathf.Clamp01(val);
		val = (Mathf.Sin(val * (float)Math.PI * (0.2f + 2.5f * val * val * val)) * Mathf.Pow(1f - val, 2.2f) + val) * (1f + 1.2f * (1f - val));
		return start + (end - start) * val;
	}

	public static float easeInQuad(float start, float end, float val)
	{
		end -= start;
		return end * val * val + start;
	}

	public static float easeOutQuad(float start, float end, float val)
	{
		end -= start;
		return (0f - end) * val * (val - 2f) + start;
	}

	public static float easeInOutQuad(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return end / 2f * val * val + start;
		}
		val -= 1f;
		return (0f - end) / 2f * (val * (val - 2f) - 1f) + start;
	}

	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		val /= 0.5f;
		if (val < 1f)
		{
			return diffBy2 * val2 + start;
		}
		val -= 1f;
		return (0f - diffBy2) * (val2 - 2f - 1f) + start;
	}

	public static float easeInCubic(float start, float end, float val)
	{
		end -= start;
		return end * val * val * val + start;
	}

	public static float easeOutCubic(float start, float end, float val)
	{
		val -= 1f;
		end -= start;
		return end * (val * val * val + 1f) + start;
	}

	public static float easeInOutCubic(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return end / 2f * val * val * val + start;
		}
		val -= 2f;
		return end / 2f * (val * val * val + 2f) + start;
	}

	public static float easeInQuart(float start, float end, float val)
	{
		end -= start;
		return end * val * val * val * val + start;
	}

	public static float easeOutQuart(float start, float end, float val)
	{
		val -= 1f;
		end -= start;
		return (0f - end) * (val * val * val * val - 1f) + start;
	}

	public static float easeInOutQuart(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return end / 2f * val * val * val * val + start;
		}
		val -= 2f;
		return (0f - end) / 2f * (val * val * val * val - 2f) + start;
	}

	public static float easeInQuint(float start, float end, float val)
	{
		end -= start;
		return end * val * val * val * val * val + start;
	}

	public static float easeOutQuint(float start, float end, float val)
	{
		val -= 1f;
		end -= start;
		return end * (val * val * val * val * val + 1f) + start;
	}

	public static float easeInOutQuint(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return end / 2f * val * val * val * val * val + start;
		}
		val -= 2f;
		return end / 2f * (val * val * val * val * val + 2f) + start;
	}

	public static float easeInSine(float start, float end, float val)
	{
		end -= start;
		return (0f - end) * Mathf.Cos(val / 1f * ((float)Math.PI / 2f)) + end + start;
	}

	public static float easeOutSine(float start, float end, float val)
	{
		end -= start;
		return end * Mathf.Sin(val / 1f * ((float)Math.PI / 2f)) + start;
	}

	public static float easeInOutSine(float start, float end, float val)
	{
		end -= start;
		return (0f - end) / 2f * (Mathf.Cos((float)Math.PI * val / 1f) - 1f) + start;
	}

	public static float easeInExpo(float start, float end, float val)
	{
		end -= start;
		return end * Mathf.Pow(2f, 10f * (val / 1f - 1f)) + start;
	}

	public static float easeOutExpo(float start, float end, float val)
	{
		end -= start;
		return end * (0f - Mathf.Pow(2f, -10f * val / 1f) + 1f) + start;
	}

	public static float easeInOutExpo(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return end / 2f * Mathf.Pow(2f, 10f * (val - 1f)) + start;
		}
		val -= 1f;
		return end / 2f * (0f - Mathf.Pow(2f, -10f * val) + 2f) + start;
	}

	public static float easeInCirc(float start, float end, float val)
	{
		end -= start;
		return (0f - end) * (Mathf.Sqrt(1f - val * val) - 1f) + start;
	}

	public static float easeOutCirc(float start, float end, float val)
	{
		val -= 1f;
		end -= start;
		return end * Mathf.Sqrt(1f - val * val) + start;
	}

	public static float easeInOutCirc(float start, float end, float val)
	{
		val /= 0.5f;
		end -= start;
		if (val < 1f)
		{
			return (0f - end) / 2f * (Mathf.Sqrt(1f - val * val) - 1f) + start;
		}
		val -= 2f;
		return end / 2f * (Mathf.Sqrt(1f - val * val) + 1f) + start;
	}

	public static float easeInBounce(float start, float end, float val)
	{
		end -= start;
		float num = 1f;
		return end - easeOutBounce(0f, end, num - val) + start;
	}

	public static float easeOutBounce(float start, float end, float val)
	{
		val /= 1f;
		end -= start;
		if (val < 0.36363637f)
		{
			return end * (7.5625f * val * val) + start;
		}
		if (val < 0.72727275f)
		{
			val -= 0.54545456f;
			return end * (7.5625f * val * val + 0.75f) + start;
		}
		if ((double)val < 0.9090909090909091)
		{
			val -= 0.8181818f;
			return end * (7.5625f * val * val + 0.9375f) + start;
		}
		val -= 21f / 22f;
		return end * (7.5625f * val * val + 63f / 64f) + start;
	}

	public static float easeInOutBounce(float start, float end, float val)
	{
		end -= start;
		float num = 1f;
		if (val < num / 2f)
		{
			return easeInBounce(0f, end, val * 2f) * 0.5f + start;
		}
		return easeOutBounce(0f, end, val * 2f - num) * 0.5f + end * 0.5f + start;
	}

	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		end -= start;
		val /= 1f;
		float num = 1.70158f * overshoot;
		return end * val * val * ((num + 1f) * val - num) + start;
	}

	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		float num = 1.70158f * overshoot;
		end -= start;
		val = val / 1f - 1f;
		return end * (val * val * ((num + 1f) * val + num) + 1f) + start;
	}

	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		float num = 1.70158f * overshoot;
		end -= start;
		val /= 0.5f;
		if (val < 1f)
		{
			num *= 1.525f * overshoot;
			return end / 2f * (val * val * ((num + 1f) * val - num)) + start;
		}
		val -= 2f;
		num *= 1.525f * overshoot;
		return end / 2f * (val * val * ((num + 1f) * val + num) + 2f) + start;
	}

	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		end -= start;
		float num = 0f;
		float num2 = 0f;
		if (val == 0f)
		{
			return start;
		}
		if (val == 1f)
		{
			return start + end;
		}
		if (num2 == 0f || num2 < Mathf.Abs(end))
		{
			num2 = end;
			num = period / 4f;
		}
		else
		{
			num = period / ((float)Math.PI * 2f) * Mathf.Asin(end / num2);
		}
		if (overshoot > 1f && val > 0.6f)
		{
			overshoot = 1f + (1f - val) / 0.4f * (overshoot - 1f);
		}
		val -= 1f;
		return start - num2 * Mathf.Pow(2f, 10f * val) * Mathf.Sin((val - num) * ((float)Math.PI * 2f) / period) * overshoot;
	}

	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		end -= start;
		float num = 0f;
		float num2 = 0f;
		if (val == 0f)
		{
			return start;
		}
		if (val == 1f)
		{
			return start + end;
		}
		if (num2 == 0f || num2 < Mathf.Abs(end))
		{
			num2 = end;
			num = period / 4f;
		}
		else
		{
			num = period / ((float)Math.PI * 2f) * Mathf.Asin(end / num2);
		}
		if (overshoot > 1f && val < 0.4f)
		{
			overshoot = 1f + val / 0.4f * (overshoot - 1f);
		}
		return start + end + num2 * Mathf.Pow(2f, -10f * val) * Mathf.Sin((val - num) * ((float)Math.PI * 2f) / period) * overshoot;
	}

	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		end -= start;
		float num = 0f;
		float num2 = 0f;
		if (val == 0f)
		{
			return start;
		}
		val /= 0.5f;
		if (val == 2f)
		{
			return start + end;
		}
		if (num2 == 0f || num2 < Mathf.Abs(end))
		{
			num2 = end;
			num = period / 4f;
		}
		else
		{
			num = period / ((float)Math.PI * 2f) * Mathf.Asin(end / num2);
		}
		if (overshoot > 1f)
		{
			if (val < 0.2f)
			{
				overshoot = 1f + val / 0.2f * (overshoot - 1f);
			}
			else if (val > 0.8f)
			{
				overshoot = 1f + (1f - val) / 0.2f * (overshoot - 1f);
			}
		}
		if (val < 1f)
		{
			val -= 1f;
			return start - 0.5f * (num2 * Mathf.Pow(2f, 10f * val) * Mathf.Sin((val - num) * ((float)Math.PI * 2f) / period)) * overshoot;
		}
		val -= 1f;
		return end + start + num2 * Mathf.Pow(2f, -10f * val) * Mathf.Sin((val - num) * ((float)Math.PI * 2f) / period) * 0.5f * overshoot;
	}

	public static void addListener(int eventId, Action<LTEvent> callback)
	{
		addListener(tweenEmpty, eventId, callback);
	}

	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		if (eventListeners == null)
		{
			INIT_LISTENERS_MAX = LISTENERS_MAX;
			eventListeners = new Action<LTEvent>[EVENTS_MAX * LISTENERS_MAX];
			goListeners = new GameObject[EVENTS_MAX * LISTENERS_MAX];
		}
		for (i = 0; i < INIT_LISTENERS_MAX; i++)
		{
			int num = eventId * INIT_LISTENERS_MAX + i;
			if (goListeners[num] == null || eventListeners[num] == null)
			{
				eventListeners[num] = callback;
				goListeners[num] = caller;
				if (i >= eventsMaxSearch)
				{
					eventsMaxSearch = i + 1;
				}
				return;
			}
			if (goListeners[num] == caller && object.Equals(eventListeners[num], callback))
			{
				return;
			}
		}
		Debug.LogError("You ran out of areas to add listeners, consider increasing LISTENERS_MAX, ex: LeanTween.LISTENERS_MAX = " + LISTENERS_MAX * 2);
	}

	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return removeListener(tweenEmpty, eventId, callback);
	}

	public static bool removeListener(int eventId)
	{
		int num = eventId * INIT_LISTENERS_MAX + i;
		eventListeners[num] = null;
		goListeners[num] = null;
		return true;
	}

	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		for (i = 0; i < eventsMaxSearch; i++)
		{
			int num = eventId * INIT_LISTENERS_MAX + i;
			if (goListeners[num] == caller && object.Equals(eventListeners[num], callback))
			{
				eventListeners[num] = null;
				goListeners[num] = null;
				return true;
			}
		}
		return false;
	}

	public static void dispatchEvent(int eventId)
	{
		dispatchEvent(eventId, null);
	}

	public static void dispatchEvent(int eventId, object data)
	{
		for (int i = 0; i < eventsMaxSearch; i++)
		{
			int num = eventId * INIT_LISTENERS_MAX + i;
			if (eventListeners[num] != null)
			{
				if ((bool)goListeners[num])
				{
					eventListeners[num](new LTEvent(eventId, data));
				}
				else
				{
					eventListeners[num] = null;
				}
			}
		}
	}
}
public class LTUtility
{
	public static Vector3[] reverse(Vector3[] arr)
	{
		int num = arr.Length;
		int num2 = 0;
		int num3 = num - 1;
		while (num2 < num3)
		{
			Vector3 vector = arr[num2];
			arr[num2] = arr[num3];
			arr[num3] = vector;
			num2++;
			num3--;
		}
		return arr;
	}
}
public class LTBezier
{
	public float length;

	private Vector3 a;

	private Vector3 aa;

	private Vector3 bb;

	private Vector3 cc;

	private float len;

	private float[] arcLengths;

	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
		this.a = a;
		aa = -a + 3f * (b - c) + d;
		bb = 3f * (a + c) - 6f * b;
		cc = 3f * (b - a);
		len = 1f / precision;
		arcLengths = new float[(int)len + 1];
		arcLengths[0] = 0f;
		Vector3 vector = a;
		float num = 0f;
		for (int i = 1; (float)i <= len; i++)
		{
			Vector3 vector2 = bezierPoint((float)i * precision);
			num += (vector - vector2).magnitude;
			arcLengths[i] = num;
			vector = vector2;
		}
		length = num;
	}

	private float map(float u)
	{
		float num = u * arcLengths[(int)len];
		int num2 = 0;
		int num3 = (int)len;
		int num4 = 0;
		while (num2 < num3)
		{
			num4 = num2 + ((int)((float)(num3 - num2) / 2f) | 0);
			if (arcLengths[num4] < num)
			{
				num2 = num4 + 1;
			}
			else
			{
				num3 = num4;
			}
		}
		if (arcLengths[num4] > num)
		{
			num4--;
		}
		if (num4 < 0)
		{
			num4 = 0;
		}
		return ((float)num4 + (num - arcLengths[num4]) / (arcLengths[num4 + 1] - arcLengths[num4])) / len;
	}

	private Vector3 bezierPoint(float t)
	{
		return ((aa * t + bb) * t + cc) * t + a;
	}

	public Vector3 point(float t)
	{
		return bezierPoint(map(t));
	}
}
public class LTBezierPath
{
	public Vector3[] pts;

	public float length;

	public bool orientToPath;

	public bool orientToPath2d;

	private LTBezier[] beziers;

	private float[] lengthRatio;

	private int currentBezier;

	private int previousBezier;

	public float distance => length;

	public LTBezierPath()
	{
	}

	public LTBezierPath(Vector3[] pts_)
	{
		setPoints(pts_);
	}

	public void setPoints(Vector3[] pts_)
	{
		if (pts_.Length < 4)
		{
			LeanTween.logError("LeanTween - When passing values for a vector path, you must pass four or more values!");
		}
		if (pts_.Length % 4 != 0)
		{
			LeanTween.logError("LeanTween - When passing values for a vector path, they must be in sets of four: controlPoint1, controlPoint2, endPoint2, controlPoint2, controlPoint2...");
		}
		pts = pts_;
		int num = 0;
		beziers = new LTBezier[pts.Length / 4];
		lengthRatio = new float[beziers.Length];
		length = 0f;
		for (int i = 0; i < pts.Length; i += 4)
		{
			beziers[num] = new LTBezier(pts[i], pts[i + 2], pts[i + 1], pts[i + 3], 0.05f);
			length += beziers[num].length;
			num++;
		}
		for (int i = 0; i < beziers.Length; i++)
		{
			lengthRatio[i] = beziers[i].length / length;
		}
	}

	public Vector3 point(float ratio)
	{
		float num = 0f;
		for (int i = 0; i < lengthRatio.Length; i++)
		{
			num += lengthRatio[i];
			if (num >= ratio)
			{
				return beziers[i].point((ratio - (num - lengthRatio[i])) / lengthRatio[i]);
			}
		}
		return beziers[lengthRatio.Length - 1].point(1f);
	}

	public void place2d(Transform transform, float ratio)
	{
		transform.position = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			Vector3 vector = point(ratio) - transform.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			transform.eulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void placeLocal2d(Transform transform, float ratio)
	{
		transform.localPosition = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			Vector3 vector = point(ratio) - transform.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			transform.localEulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void place(Transform transform, float ratio)
	{
		place(transform, ratio, Vector3.up);
	}

	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
		transform.position = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			transform.LookAt(point(ratio), worldUp);
		}
	}

	public void placeLocal(Transform transform, float ratio)
	{
		placeLocal(transform, ratio, Vector3.up);
	}

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
		ratio = getRationInOneRange(ratio);
		transform.localPosition = point(ratio);
		ratio = getRationInOneRange(ratio + 0.001f);
		if (ratio <= 1f)
		{
			transform.LookAt(transform.parent.TransformPoint(point(ratio)), worldUp);
		}
	}

	public float getRationInOneRange(float ratio)
	{
		if (ratio >= 0f && ratio <= 1f)
		{
			return ratio;
		}
		if (ratio < 0f)
		{
			return Mathf.Ceil(ratio) - ratio;
		}
		return ratio - Mathf.Floor(ratio);
	}

	public void gizmoDraw(float t = -1f)
	{
		Vector3 to = point(0f);
		for (int i = 1; i <= 120; i++)
		{
			float ratio = (float)i / 120f;
			Vector3 vector = point(ratio);
			Gizmos.color = ((previousBezier == currentBezier) ? UnityEngine.Color.magenta : UnityEngine.Color.grey);
			Gizmos.DrawLine(vector, to);
			to = vector;
			previousBezier = currentBezier;
		}
	}
}
[Serializable]
public class LTSpline
{
	public static int DISTANCE_COUNT = 3;

	public static int SUBLINE_COUNT = 20;

	public float distance;

	public bool constantSpeed = true;

	public Vector3[] pts;

	[NonSerialized]
	public Vector3[] ptsAdj;

	public int ptsAdjLength;

	public bool orientToPath;

	public bool orientToPath2d;

	private int numSections;

	private int currPt;

	public LTSpline(Vector3[] pts)
	{
		init(pts, constantSpeed: true);
	}

	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
		this.constantSpeed = constantSpeed;
		init(pts, constantSpeed);
	}

	private void init(Vector3[] pts, bool constantSpeed)
	{
		if (pts.Length < 4)
		{
			LeanTween.logError("LeanTween - When passing values for a spline path, you must pass four or more values!");
			return;
		}
		this.pts = new Vector3[pts.Length];
		Array.Copy(pts, this.pts, pts.Length);
		numSections = pts.Length - 3;
		float num = float.PositiveInfinity;
		Vector3 b = this.pts[1];
		float num2 = 0f;
		for (int i = 1; i < this.pts.Length - 1; i++)
		{
			float num3 = Vector3.Distance(this.pts[i], b);
			if (num3 < num)
			{
				num = num3;
			}
			num2 += num3;
		}
		if (!constantSpeed)
		{
			return;
		}
		num = num2 / (float)(numSections * SUBLINE_COUNT);
		float num4 = num / (float)SUBLINE_COUNT;
		int num5 = (int)Mathf.Ceil(num2 / num4) * DISTANCE_COUNT;
		if (num5 <= 1)
		{
			num5 = 2;
		}
		ptsAdj = new Vector3[num5];
		b = interp(0f);
		int num6 = 1;
		ptsAdj[0] = b;
		distance = 0f;
		for (int j = 0; j < num5 + 1; j++)
		{
			float num7 = (float)j / (float)num5;
			Vector3 vector = interp(num7);
			float num8 = Vector3.Distance(vector, b);
			if (num8 >= num4 || num7 >= 1f)
			{
				ptsAdj[num6] = vector;
				distance += num8;
				b = vector;
				num6++;
			}
		}
		ptsAdjLength = num6;
	}

	public Vector3 map(float u)
	{
		if (u >= 1f)
		{
			return pts[pts.Length - 2];
		}
		float num = u * (float)(ptsAdjLength - 1);
		int num2 = (int)Mathf.Floor(num);
		int num3 = (int)Mathf.Ceil(num);
		if (num2 < 0)
		{
			num2 = 0;
		}
		Vector3 vector = ptsAdj[num2];
		Vector3 vector2 = ptsAdj[num3];
		float num4 = num - (float)num2;
		return vector + (vector2 - vector) * num4;
	}

	public Vector3 interp(float t)
	{
		currPt = Mathf.Min(Mathf.FloorToInt(t * (float)numSections), numSections - 1);
		float num = t * (float)numSections - (float)currPt;
		Vector3 vector = pts[currPt];
		Vector3 vector2 = pts[currPt + 1];
		Vector3 vector3 = pts[currPt + 2];
		Vector3 vector4 = pts[currPt + 3];
		return 0.5f * ((-vector + 3f * vector2 - 3f * vector3 + vector4) * (num * num * num) + (2f * vector - 5f * vector2 + 4f * vector3 - vector4) * (num * num) + (-vector + vector3) * num + 2f * vector2);
	}

	public float ratioAtPoint(Vector3 pt)
	{
		float num = float.MaxValue;
		int num2 = 0;
		for (int i = 0; i < ptsAdjLength; i++)
		{
			float num3 = Vector3.Distance(pt, ptsAdj[i]);
			if (num3 < num)
			{
				num = num3;
				num2 = i;
			}
		}
		return (float)num2 / (float)(ptsAdjLength - 1);
	}

	public Vector3 point(float ratio)
	{
		float num = ((ratio > 1f) ? 1f : ratio);
		if (!constantSpeed)
		{
			return interp(num);
		}
		return map(num);
	}

	public void place2d(Transform transform, float ratio)
	{
		transform.position = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			Vector3 vector = point(ratio) - transform.position;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			transform.eulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void placeLocal2d(Transform transform, float ratio)
	{
		if (transform.parent == null)
		{
			place2d(transform, ratio);
			return;
		}
		transform.localPosition = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			Vector3 vector = point(ratio) - transform.localPosition;
			float z = Mathf.Atan2(vector.y, vector.x) * 57.29578f;
			transform.localEulerAngles = new Vector3(0f, 0f, z);
		}
	}

	public void place(Transform transform, float ratio)
	{
		place(transform, ratio, Vector3.up);
	}

	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
		transform.position = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			transform.LookAt(point(ratio), worldUp);
		}
	}

	public void placeLocal(Transform transform, float ratio)
	{
		placeLocal(transform, ratio, Vector3.up);
	}

	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
		transform.localPosition = point(ratio);
		ratio += 0.001f;
		if (ratio <= 1f)
		{
			transform.LookAt(transform.parent.TransformPoint(point(ratio)), worldUp);
		}
	}

	public void gizmoDraw(float t = -1f)
	{
		if (ptsAdj != null && ptsAdj.Length != 0)
		{
			Vector3 from = ptsAdj[0];
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
		}
	}

	public void drawGizmo(UnityEngine.Color color)
	{
		if (ptsAdjLength >= 4)
		{
			Vector3 from = ptsAdj[0];
			UnityEngine.Color color2 = Gizmos.color;
			Gizmos.color = color;
			for (int i = 0; i < ptsAdjLength; i++)
			{
				Vector3 vector = ptsAdj[i];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color2;
		}
	}

	public static void drawGizmo(Transform[] arr, UnityEngine.Color color)
	{
		if (arr.Length >= 4)
		{
			Vector3[] array = new Vector3[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				array[i] = arr[i].position;
			}
			LTSpline lTSpline = new LTSpline(array);
			Vector3 from = lTSpline.ptsAdj[0];
			UnityEngine.Color color2 = Gizmos.color;
			Gizmos.color = color;
			for (int j = 0; j < lTSpline.ptsAdjLength; j++)
			{
				Vector3 vector = lTSpline.ptsAdj[j];
				Gizmos.DrawLine(from, vector);
				from = vector;
			}
			Gizmos.color = color2;
		}
	}

	public static void drawLine(Transform[] arr, float width, UnityEngine.Color color)
	{
		_ = arr.Length;
		_ = 4;
	}

	public void drawLinesGLLines(Material outlineMaterial, UnityEngine.Color color, float width)
	{
		GL.PushMatrix();
		outlineMaterial.SetPass(0);
		GL.LoadPixelMatrix();
		GL.Begin(1);
		GL.Color(color);
		if (constantSpeed)
		{
			if (ptsAdjLength >= 4)
			{
				Vector3 v = ptsAdj[0];
				for (int i = 0; i < ptsAdjLength; i++)
				{
					Vector3 vector = ptsAdj[i];
					GL.Vertex(v);
					GL.Vertex(vector);
					v = vector;
				}
			}
		}
		else if (pts.Length >= 4)
		{
			Vector3 v2 = pts[0];
			float num = 1f / ((float)pts.Length * 10f);
			for (float num2 = 0f; num2 < 1f; num2 += num)
			{
				float t = num2 / 1f;
				Vector3 vector2 = interp(t);
				GL.Vertex(v2);
				GL.Vertex(vector2);
				v2 = vector2;
			}
		}
		GL.End();
		GL.PopMatrix();
	}

	public Vector3[] generateVectors()
	{
		if (pts.Length >= 4)
		{
			List<Vector3> list = new List<Vector3>();
			Vector3 item = pts[0];
			list.Add(item);
			float num = 1f / ((float)pts.Length * 10f);
			for (float num2 = 0f; num2 < 1f; num2 += num)
			{
				float t = num2 / 1f;
				Vector3 item2 = interp(t);
				list.Add(item2);
			}
			list.ToArray();
		}
		return null;
	}
}
[Serializable]
public class LTRect
{
	public Rect _rect;

	public float alpha = 1f;

	public float rotation;

	public Vector2 pivot;

	public Vector2 margin;

	public Rect relativeRect = new Rect(0f, 0f, float.PositiveInfinity, float.PositiveInfinity);

	public bool rotateEnabled;

	[HideInInspector]
	public bool rotateFinished;

	public bool alphaEnabled;

	public string labelStr;

	public LTGUI.Element_Type type;

	public GUIStyle style;

	public bool useColor;

	public UnityEngine.Color color = UnityEngine.Color.white;

	public bool fontScaleToFit;

	public bool useSimpleScale;

	public bool sizeByHeight;

	public Texture texture;

	private int _id = -1;

	[HideInInspector]
	public int counter;

	public static bool colorTouched;

	public bool hasInitiliazed => _id != -1;

	public int id => _id | (counter << 16);

	public float x
	{
		get
		{
			return _rect.x;
		}
		set
		{
			_rect.x = value;
		}
	}

	public float y
	{
		get
		{
			return _rect.y;
		}
		set
		{
			_rect.y = value;
		}
	}

	public float width
	{
		get
		{
			return _rect.width;
		}
		set
		{
			_rect.width = value;
		}
	}

	public float height
	{
		get
		{
			return _rect.height;
		}
		set
		{
			_rect.height = value;
		}
	}

	public Rect rect
	{
		get
		{
			if (colorTouched)
			{
				colorTouched = false;
				GUI.color = new UnityEngine.Color(GUI.color.r, GUI.color.g, GUI.color.b, 1f);
			}
			if (rotateEnabled)
			{
				if (rotateFinished)
				{
					rotateFinished = false;
					rotateEnabled = false;
					pivot = Vector2.zero;
				}
				else
				{
					GUIUtility.RotateAroundPivot(rotation, pivot);
				}
			}
			if (alphaEnabled)
			{
				GUI.color = new UnityEngine.Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
				colorTouched = true;
			}
			if (fontScaleToFit)
			{
				if (useSimpleScale)
				{
					style.fontSize = (int)(_rect.height * relativeRect.height);
				}
				else
				{
					style.fontSize = (int)_rect.height;
				}
			}
			return _rect;
		}
		set
		{
			_rect = value;
		}
	}

	public LTRect()
	{
		reset();
		rotateEnabled = (alphaEnabled = true);
		_rect = new Rect(0f, 0f, 1f, 1f);
	}

	public LTRect(Rect rect)
	{
		_rect = rect;
		reset();
	}

	public LTRect(float x, float y, float width, float height)
	{
		_rect = new Rect(x, y, width, height);
		alpha = 1f;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
	}

	public LTRect(float x, float y, float width, float height, float alpha)
	{
		_rect = new Rect(x, y, width, height);
		this.alpha = alpha;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
	}

	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
		_rect = new Rect(x, y, width, height);
		this.alpha = alpha;
		this.rotation = rotation;
		rotateEnabled = (alphaEnabled = false);
		if (rotation != 0f)
		{
			rotateEnabled = true;
			resetForRotation();
		}
	}

	public void setId(int id, int counter)
	{
		_id = id;
		this.counter = counter;
	}

	public void reset()
	{
		alpha = 1f;
		rotation = 0f;
		rotateEnabled = (alphaEnabled = false);
		margin = Vector2.zero;
		sizeByHeight = false;
		useColor = false;
	}

	public void resetForRotation()
	{
		Vector3 vector = new Vector3(GUI.matrix[0, 0], GUI.matrix[1, 1], GUI.matrix[2, 2]);
		if (pivot == Vector2.zero)
		{
			pivot = new Vector2((_rect.x + _rect.width * 0.5f) * vector.x + GUI.matrix[0, 3], (_rect.y + _rect.height * 0.5f) * vector.y + GUI.matrix[1, 3]);
		}
	}

	public LTRect setStyle(GUIStyle style)
	{
		this.style = style;
		return this;
	}

	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		this.fontScaleToFit = fontScaleToFit;
		return this;
	}

	public LTRect setColor(UnityEngine.Color color)
	{
		this.color = color;
		useColor = true;
		return this;
	}

	public LTRect setAlpha(float alpha)
	{
		this.alpha = alpha;
		return this;
	}

	public LTRect setLabel(string str)
	{
		labelStr = str;
		return this;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		this.useSimpleScale = useSimpleScale;
		this.relativeRect = relativeRect;
		return this;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		this.useSimpleScale = useSimpleScale;
		relativeRect = new Rect(0f, 0f, Screen.width, Screen.height);
		return this;
	}

	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		this.sizeByHeight = sizeByHeight;
		return this;
	}

	public override string ToString()
	{
		return "x:" + _rect.x + " y:" + _rect.y + " width:" + _rect.width + " height:" + _rect.height;
	}
}
public class LTEvent
{
	public int id;

	public object data;

	public LTEvent(int id, object data)
	{
		this.id = id;
		this.data = data;
	}
}
public class LTGUI
{
	public enum Element_Type
	{
		Texture,
		Label
	}

	public static int RECT_LEVELS = 5;

	public static int RECTS_PER_LEVEL = 10;

	public static int BUTTONS_MAX = 24;

	private static LTRect[] levels;

	private static int[] levelDepths;

	private static Rect[] buttons;

	private static int[] buttonLevels;

	private static int[] buttonLastFrame;

	private static LTRect r;

	private static UnityEngine.Color color = UnityEngine.Color.white;

	private static bool isGUIEnabled = false;

	private static int global_counter = 0;

	public static void init()
	{
		if (levels == null)
		{
			levels = new LTRect[RECT_LEVELS * RECTS_PER_LEVEL];
			levelDepths = new int[RECT_LEVELS];
		}
	}

	public static void initRectCheck()
	{
		if (buttons == null)
		{
			buttons = new Rect[BUTTONS_MAX];
			buttonLevels = new int[BUTTONS_MAX];
			buttonLastFrame = new int[BUTTONS_MAX];
			for (int i = 0; i < buttonLevels.Length; i++)
			{
				buttonLevels[i] = -1;
			}
		}
	}

	public static void reset()
	{
		if (isGUIEnabled)
		{
			isGUIEnabled = false;
			for (int i = 0; i < levels.Length; i++)
			{
				levels[i] = null;
			}
			for (int j = 0; j < levelDepths.Length; j++)
			{
				levelDepths[j] = 0;
			}
		}
	}

	public static void update(int updateLevel)
	{
		if (!isGUIEnabled)
		{
			return;
		}
		init();
		if (levelDepths[updateLevel] <= 0)
		{
			return;
		}
		color = GUI.color;
		int num = updateLevel * RECTS_PER_LEVEL;
		int num2 = num + levelDepths[updateLevel];
		for (int i = num; i < num2; i++)
		{
			r = levels[i];
			if (r == null)
			{
				continue;
			}
			if (r.useColor)
			{
				GUI.color = r.color;
			}
			if (r.type == Element_Type.Label)
			{
				if (r.style != null)
				{
					GUI.skin.label = r.style;
				}
				if (r.useSimpleScale)
				{
					GUI.Label(new Rect((r.rect.x + r.margin.x + r.relativeRect.x) * r.relativeRect.width, (r.rect.y + r.margin.y + r.relativeRect.y) * r.relativeRect.height, r.rect.width * r.relativeRect.width, r.rect.height * r.relativeRect.height), r.labelStr);
				}
				else
				{
					GUI.Label(new Rect(r.rect.x + r.margin.x, r.rect.y + r.margin.y, r.rect.width, r.rect.height), r.labelStr);
				}
			}
			else if (r.type == Element_Type.Texture && r.texture != null)
			{
				Vector2 vector = (r.useSimpleScale ? new Vector2(0f, r.rect.height * r.relativeRect.height) : new Vector2(r.rect.width, r.rect.height));
				if (r.sizeByHeight)
				{
					vector.x = (float)r.texture.width / (float)r.texture.height * vector.y;
				}
				if (r.useSimpleScale)
				{
					GUI.DrawTexture(new Rect((r.rect.x + r.margin.x + r.relativeRect.x) * r.relativeRect.width, (r.rect.y + r.margin.y + r.relativeRect.y) * r.relativeRect.height, vector.x, vector.y), r.texture);
				}
				else
				{
					GUI.DrawTexture(new Rect(r.rect.x + r.margin.x, r.rect.y + r.margin.y, vector.x, vector.y), r.texture);
				}
			}
		}
		GUI.color = color;
	}

	public static bool checkOnScreen(Rect rect)
	{
		bool num = rect.x + rect.width < 0f;
		bool flag = rect.x > (float)Screen.width;
		bool flag2 = rect.y > (float)Screen.height;
		bool flag3 = rect.y + rect.height < 0f;
		return !(num || flag || flag2 || flag3);
	}

	public static void destroy(int id)
	{
		int num = id & 0xFFFF;
		int num2 = id >> 16;
		if (id >= 0 && levels[num] != null && levels[num].hasInitiliazed && levels[num].counter == num2)
		{
			levels[num] = null;
		}
	}

	public static void destroyAll(int depth)
	{
		int num = depth * RECTS_PER_LEVEL + RECTS_PER_LEVEL;
		int num2 = depth * RECTS_PER_LEVEL;
		while (levels != null && num2 < num)
		{
			levels[num2] = null;
			num2++;
		}
	}

	public static LTRect label(Rect rect, string label, int depth)
	{
		return LTGUI.label(new LTRect(rect), label, depth);
	}

	public static LTRect label(LTRect rect, string label, int depth)
	{
		rect.type = Element_Type.Label;
		rect.labelStr = label;
		return element(rect, depth);
	}

	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return LTGUI.texture(new LTRect(rect), texture, depth);
	}

	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		rect.type = Element_Type.Texture;
		rect.texture = texture;
		return element(rect, depth);
	}

	public static LTRect element(LTRect rect, int depth)
	{
		isGUIEnabled = true;
		init();
		int num = depth * RECTS_PER_LEVEL + RECTS_PER_LEVEL;
		int num2 = 0;
		if (rect != null)
		{
			destroy(rect.id);
		}
		if (rect.type == Element_Type.Label && rect.style != null && rect.style.normal.textColor.a <= 0f)
		{
			Debug.LogWarning("Your GUI normal color has an alpha of zero, and will not be rendered.");
		}
		if (rect.relativeRect.width == float.PositiveInfinity)
		{
			rect.relativeRect = new Rect(0f, 0f, Screen.width, Screen.height);
		}
		for (int i = depth * RECTS_PER_LEVEL; i < num; i++)
		{
			r = levels[i];
			if (r == null)
			{
				r = rect;
				r.rotateEnabled = true;
				r.alphaEnabled = true;
				r.setId(i, global_counter);
				levels[i] = r;
				if (num2 >= levelDepths[depth])
				{
					levelDepths[depth] = num2 + 1;
				}
				global_counter++;
				return r;
			}
			num2++;
		}
		Debug.LogError("You ran out of GUI Element spaces");
		return null;
	}

	public static bool hasNoOverlap(Rect rect, int depth)
	{
		initRectCheck();
		bool result = true;
		bool flag = false;
		for (int i = 0; i < buttonLevels.Length; i++)
		{
			if (buttonLevels[i] >= 0)
			{
				if (buttonLastFrame[i] + 1 < Time.frameCount)
				{
					buttonLevels[i] = -1;
				}
				else if (buttonLevels[i] > depth && pressedWithinRect(buttons[i]))
				{
					result = false;
				}
			}
			if (!flag && buttonLevels[i] < 0)
			{
				flag = true;
				buttonLevels[i] = depth;
				buttons[i] = rect;
				buttonLastFrame[i] = Time.frameCount;
			}
		}
		return result;
	}

	public static bool pressedWithinRect(Rect rect)
	{
		Vector2 vector = firstTouch();
		if (vector.x < 0f)
		{
			return false;
		}
		float num = (float)Screen.height - vector.y;
		if (vector.x > rect.x && vector.x < rect.x + rect.width && num > rect.y)
		{
			return num < rect.y + rect.height;
		}
		return false;
	}

	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		vec2.y = (float)Screen.height - vec2.y;
		if (vec2.x > rect.x && vec2.x < rect.x + rect.width && vec2.y > rect.y)
		{
			return vec2.y < rect.y + rect.height;
		}
		return false;
	}

	public static Vector2 firstTouch()
	{
		if (Input.touchCount > 0)
		{
			return Input.touches[0].position;
		}
		if (Input.GetMouseButton(0))
		{
			return Input.mousePosition;
		}
		return new Vector2(float.NegativeInfinity, float.NegativeInfinity);
	}
}
public class LTDescr
{
	public delegate Vector3 EaseTypeDelegate();

	public delegate void ActionMethodDelegate();

	public bool toggle;

	public bool useEstimatedTime;

	public bool useFrames;

	public bool useManualTime;

	public bool usesNormalDt;

	public bool hasInitiliazed;

	public bool hasExtraOnCompletes;

	public bool hasPhysics;

	public bool onCompleteOnRepeat;

	public bool onCompleteOnStart;

	public bool useRecursion;

	public float ratioPassed;

	public float passed;

	public float delay;

	public float time;

	public float speed;

	public float lastVal;

	private uint _id;

	public int loopCount;

	public uint counter;

	public float direction;

	public float directionLast;

	public float overshoot;

	public float period;

	public float scale;

	public bool destroyOnComplete;

	public Transform trans;

	public LTRect ltRect;

	internal Vector3 fromInternal;

	internal Vector3 toInternal;

	internal Vector3 diff;

	internal Vector3 diffDiv2;

	public TweenAction type;

	private LeanTweenType easeType;

	public LeanTweenType loopType;

	public bool hasUpdateCallback;

	public EaseTypeDelegate easeMethod;

	public SpriteRenderer spriteRen;

	public RectTransform rectTransform;

	public Text uiText;

	public UnityEngine.UI.Image uiImage;

	public RawImage rawImage;

	public Sprite[] sprites;

	public LTDescrOptional _optional = new LTDescrOptional();

	public static float val;

	public static float dt;

	public static Vector3 newVect;

	public Vector3 from
	{
		get
		{
			return fromInternal;
		}
		set
		{
			fromInternal = value;
		}
	}

	public Vector3 to
	{
		get
		{
			return toInternal;
		}
		set
		{
			toInternal = value;
		}
	}

	public ActionMethodDelegate easeInternal { get; set; }

	public ActionMethodDelegate initInternal { get; set; }

	public int uniqueId => (int)(_id | (counter << 16));

	public int id => uniqueId;

	public LTDescrOptional optional
	{
		get
		{
			return _optional;
		}
		set
		{
			_optional = optional;
		}
	}

	public override string ToString()
	{
		return string.Concat((trans != null) ? ("name:" + trans.gameObject.name) : "gameObject:null", " toggle:", toggle.ToString(), " passed:", passed, " time:", time, " delay:", delay, " direction:", direction, " from:", from, " to:", to, " diff:", diff, " type:", type, " ease:", easeType, " useEstimatedTime:", useEstimatedTime.ToString(), " id:", id, " hasInitiliazed:", hasInitiliazed.ToString());
	}

	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		if (gameObject == trans.gameObject)
		{
			LeanTween.removeTween((int)_id, uniqueId);
		}
		return this;
	}

	public void reset()
	{
		toggle = (useRecursion = (usesNormalDt = true));
		trans = null;
		spriteRen = null;
		passed = (delay = (lastVal = 0f));
		hasUpdateCallback = (useEstimatedTime = (useFrames = (hasInitiliazed = (onCompleteOnRepeat = (destroyOnComplete = (onCompleteOnStart = (useManualTime = (hasExtraOnCompletes = false))))))));
		easeType = LeanTweenType.linear;
		loopType = LeanTweenType.once;
		loopCount = 0;
		direction = (directionLast = (overshoot = (scale = 1f)));
		period = 0.3f;
		speed = -1f;
		easeMethod = easeLinear;
		Vector3 vector = (to = Vector3.zero);
		from = vector;
		_optional.reset();
	}

	public LTDescr setMoveX()
	{
		type = TweenAction.MOVE_X;
		initInternal = delegate
		{
			fromInternal.x = trans.position.x;
		};
		easeInternal = delegate
		{
			trans.position = new Vector3(easeMethod().x, trans.position.y, trans.position.z);
		};
		return this;
	}

	public LTDescr setMoveY()
	{
		type = TweenAction.MOVE_Y;
		initInternal = delegate
		{
			fromInternal.x = trans.position.y;
		};
		easeInternal = delegate
		{
			trans.position = new Vector3(trans.position.x, easeMethod().x, trans.position.z);
		};
		return this;
	}

	public LTDescr setMoveZ()
	{
		type = TweenAction.MOVE_Z;
		initInternal = delegate
		{
			fromInternal.x = trans.position.z;
		};
		easeInternal = delegate
		{
			trans.position = new Vector3(trans.position.x, trans.position.y, easeMethod().x);
		};
		return this;
	}

	public LTDescr setMoveLocalX()
	{
		type = TweenAction.MOVE_LOCAL_X;
		initInternal = delegate
		{
			fromInternal.x = trans.localPosition.x;
		};
		easeInternal = delegate
		{
			trans.localPosition = new Vector3(easeMethod().x, trans.localPosition.y, trans.localPosition.z);
		};
		return this;
	}

	public LTDescr setMoveLocalY()
	{
		type = TweenAction.MOVE_LOCAL_Y;
		initInternal = delegate
		{
			fromInternal.x = trans.localPosition.y;
		};
		easeInternal = delegate
		{
			trans.localPosition = new Vector3(trans.localPosition.x, easeMethod().x, trans.localPosition.z);
		};
		return this;
	}

	public LTDescr setMoveLocalZ()
	{
		type = TweenAction.MOVE_LOCAL_Z;
		initInternal = delegate
		{
			fromInternal.x = trans.localPosition.z;
		};
		easeInternal = delegate
		{
			trans.localPosition = new Vector3(trans.localPosition.x, trans.localPosition.y, easeMethod().x);
		};
		return this;
	}

	private void initFromInternal()
	{
		fromInternal.x = 0f;
	}

	public LTDescr setMoveCurved()
	{
		type = TweenAction.MOVE_CURVED;
		initInternal = initFromInternal;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (_optional.path.orientToPath)
			{
				if (_optional.path.orientToPath2d)
				{
					_optional.path.place2d(trans, val);
				}
				else
				{
					_optional.path.place(trans, val);
				}
			}
			else
			{
				trans.position = _optional.path.point(val);
			}
		};
		return this;
	}

	public LTDescr setMoveCurvedLocal()
	{
		type = TweenAction.MOVE_CURVED_LOCAL;
		initInternal = initFromInternal;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (_optional.path.orientToPath)
			{
				if (_optional.path.orientToPath2d)
				{
					_optional.path.placeLocal2d(trans, val);
				}
				else
				{
					_optional.path.placeLocal(trans, val);
				}
			}
			else
			{
				trans.localPosition = _optional.path.point(val);
			}
		};
		return this;
	}

	public LTDescr setMoveSpline()
	{
		type = TweenAction.MOVE_SPLINE;
		initInternal = initFromInternal;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (_optional.spline.orientToPath)
			{
				if (_optional.spline.orientToPath2d)
				{
					_optional.spline.place2d(trans, val);
				}
				else
				{
					_optional.spline.place(trans, val);
				}
			}
			else
			{
				trans.position = _optional.spline.point(val);
			}
		};
		return this;
	}

	public LTDescr setMoveSplineLocal()
	{
		type = TweenAction.MOVE_SPLINE_LOCAL;
		initInternal = initFromInternal;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (_optional.spline.orientToPath)
			{
				if (_optional.spline.orientToPath2d)
				{
					_optional.spline.placeLocal2d(trans, val);
				}
				else
				{
					_optional.spline.placeLocal(trans, val);
				}
			}
			else
			{
				trans.localPosition = _optional.spline.point(val);
			}
		};
		return this;
	}

	public LTDescr setScaleX()
	{
		type = TweenAction.SCALE_X;
		initInternal = delegate
		{
			fromInternal.x = trans.localScale.x;
		};
		easeInternal = delegate
		{
			trans.localScale = new Vector3(easeMethod().x, trans.localScale.y, trans.localScale.z);
		};
		return this;
	}

	public LTDescr setScaleY()
	{
		type = TweenAction.SCALE_Y;
		initInternal = delegate
		{
			fromInternal.x = trans.localScale.y;
		};
		easeInternal = delegate
		{
			trans.localScale = new Vector3(trans.localScale.x, easeMethod().x, trans.localScale.z);
		};
		return this;
	}

	public LTDescr setScaleZ()
	{
		type = TweenAction.SCALE_Z;
		initInternal = delegate
		{
			fromInternal.x = trans.localScale.z;
		};
		easeInternal = delegate
		{
			trans.localScale = new Vector3(trans.localScale.x, trans.localScale.y, easeMethod().x);
		};
		return this;
	}

	public LTDescr setRotateX()
	{
		type = TweenAction.ROTATE_X;
		initInternal = delegate
		{
			fromInternal.x = trans.eulerAngles.x;
			toInternal.x = LeanTween.closestRot(fromInternal.x, toInternal.x);
		};
		easeInternal = delegate
		{
			trans.eulerAngles = new Vector3(easeMethod().x, trans.eulerAngles.y, trans.eulerAngles.z);
		};
		return this;
	}

	public LTDescr setRotateY()
	{
		type = TweenAction.ROTATE_Y;
		initInternal = delegate
		{
			fromInternal.x = trans.eulerAngles.y;
			toInternal.x = LeanTween.closestRot(fromInternal.x, toInternal.x);
		};
		easeInternal = delegate
		{
			trans.eulerAngles = new Vector3(trans.eulerAngles.x, easeMethod().x, trans.eulerAngles.z);
		};
		return this;
	}

	public LTDescr setRotateZ()
	{
		type = TweenAction.ROTATE_Z;
		initInternal = delegate
		{
			fromInternal.x = trans.eulerAngles.z;
			toInternal.x = LeanTween.closestRot(fromInternal.x, toInternal.x);
		};
		easeInternal = delegate
		{
			trans.eulerAngles = new Vector3(trans.eulerAngles.x, trans.eulerAngles.y, easeMethod().x);
		};
		return this;
	}

	public LTDescr setRotateAround()
	{
		type = TweenAction.ROTATE_AROUND;
		initInternal = delegate
		{
			fromInternal.x = 0f;
			_optional.origRotation = trans.rotation;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			Vector3 localPosition = trans.localPosition;
			Vector3 point = trans.TransformPoint(_optional.point);
			trans.RotateAround(point, _optional.axis, 0f - _optional.lastVal);
			Vector3 vector = localPosition - trans.localPosition;
			trans.localPosition = localPosition - vector;
			trans.rotation = _optional.origRotation;
			point = trans.TransformPoint(_optional.point);
			trans.RotateAround(point, _optional.axis, val);
			_optional.lastVal = val;
		};
		return this;
	}

	public LTDescr setRotateAroundLocal()
	{
		type = TweenAction.ROTATE_AROUND_LOCAL;
		initInternal = delegate
		{
			fromInternal.x = 0f;
			_optional.origRotation = trans.localRotation;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			Vector3 localPosition = trans.localPosition;
			trans.RotateAround(trans.TransformPoint(_optional.point), trans.TransformDirection(_optional.axis), 0f - _optional.lastVal);
			Vector3 vector = localPosition - trans.localPosition;
			trans.localPosition = localPosition - vector;
			trans.localRotation = _optional.origRotation;
			Vector3 point = trans.TransformPoint(_optional.point);
			trans.RotateAround(point, trans.TransformDirection(_optional.axis), val);
			_optional.lastVal = val;
		};
		return this;
	}

	public LTDescr setAlpha()
	{
		type = TweenAction.ALPHA;
		initInternal = delegate
		{
			SpriteRenderer component = trans.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				fromInternal.x = component.color.a;
			}
			else if (trans.GetComponent<Renderer>() != null && trans.GetComponent<Renderer>().material.HasProperty("_Color"))
			{
				fromInternal.x = trans.GetComponent<Renderer>().material.color.a;
			}
			else if (trans.GetComponent<Renderer>() != null && trans.GetComponent<Renderer>().material.HasProperty("_TintColor"))
			{
				UnityEngine.Color color = trans.GetComponent<Renderer>().material.GetColor("_TintColor");
				fromInternal.x = color.a;
			}
			else if (trans.childCount > 0)
			{
				foreach (Transform tran in trans)
				{
					if (tran.gameObject.GetComponent<Renderer>() != null)
					{
						UnityEngine.Color color2 = tran.gameObject.GetComponent<Renderer>().material.color;
						fromInternal.x = color2.a;
						break;
					}
				}
			}
			easeInternal = delegate
			{
				val = easeMethod().x;
				if (spriteRen != null)
				{
					spriteRen.color = new UnityEngine.Color(spriteRen.color.r, spriteRen.color.g, spriteRen.color.b, val);
					alphaRecursiveSprite(trans, val);
				}
				else
				{
					alphaRecursive(trans, val, useRecursion);
				}
			};
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (spriteRen != null)
			{
				spriteRen.color = new UnityEngine.Color(spriteRen.color.r, spriteRen.color.g, spriteRen.color.b, val);
				alphaRecursiveSprite(trans, val);
			}
			else
			{
				alphaRecursive(trans, val, useRecursion);
			}
		};
		return this;
	}

	public LTDescr setTextAlpha()
	{
		type = TweenAction.TEXT_ALPHA;
		initInternal = delegate
		{
			uiText = trans.GetComponent<Text>();
			fromInternal.x = ((uiText != null) ? uiText.color.a : 1f);
		};
		easeInternal = delegate
		{
			textAlphaRecursive(trans, easeMethod().x, useRecursion);
		};
		return this;
	}

	public LTDescr setAlphaVertex()
	{
		type = TweenAction.ALPHA_VERTEX;
		initInternal = delegate
		{
			fromInternal.x = (int)trans.GetComponent<MeshFilter>().mesh.colors32[0].a;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			Mesh mesh = trans.GetComponent<MeshFilter>().mesh;
			Vector3[] vertices = mesh.vertices;
			Color32[] array = new Color32[vertices.Length];
			if (array.Length == 0)
			{
				Color32 color = new Color32(byte.MaxValue, byte.MaxValue, byte.MaxValue, 0);
				array = new Color32[mesh.vertices.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = color;
				}
				mesh.colors32 = array;
			}
			Color32 color2 = mesh.colors32[0];
			color2 = new UnityEngine.Color((int)color2.r, (int)color2.g, (int)color2.b, val);
			for (int j = 0; j < vertices.Length; j++)
			{
				array[j] = color2;
			}
			mesh.colors32 = array;
		};
		return this;
	}

	public LTDescr setColor()
	{
		type = TweenAction.COLOR;
		initInternal = delegate
		{
			SpriteRenderer component = trans.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				setFromColor(component.color);
			}
			else if (trans.GetComponent<Renderer>() != null && trans.GetComponent<Renderer>().material.HasProperty("_Color"))
			{
				UnityEngine.Color color2 = trans.GetComponent<Renderer>().material.color;
				setFromColor(color2);
			}
			else if (trans.GetComponent<Renderer>() != null && trans.GetComponent<Renderer>().material.HasProperty("_TintColor"))
			{
				UnityEngine.Color color3 = trans.GetComponent<Renderer>().material.GetColor("_TintColor");
				setFromColor(color3);
			}
			else if (trans.childCount > 0)
			{
				foreach (Transform tran in trans)
				{
					if (tran.gameObject.GetComponent<Renderer>() != null)
					{
						UnityEngine.Color color4 = tran.gameObject.GetComponent<Renderer>().material.color;
						setFromColor(color4);
						break;
					}
				}
			}
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			UnityEngine.Color color = tweenColor(this, val);
			if (spriteRen != null)
			{
				spriteRen.color = color;
				colorRecursiveSprite(trans, color);
			}
			else if (type == TweenAction.COLOR)
			{
				colorRecursive(trans, color, useRecursion);
			}
			if (dt != 0f && _optional.onUpdateColor != null)
			{
				_optional.onUpdateColor(color);
			}
			else if (dt != 0f && _optional.onUpdateColorObject != null)
			{
				_optional.onUpdateColorObject(color, _optional.onUpdateParam);
			}
		};
		return this;
	}

	public LTDescr setCallbackColor()
	{
		type = TweenAction.CALLBACK_COLOR;
		initInternal = delegate
		{
			diff = new Vector3(1f, 0f, 0f);
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			UnityEngine.Color color = tweenColor(this, val);
			if (spriteRen != null)
			{
				spriteRen.color = color;
				colorRecursiveSprite(trans, color);
			}
			else if (type == TweenAction.COLOR)
			{
				colorRecursive(trans, color, useRecursion);
			}
			if (dt != 0f && _optional.onUpdateColor != null)
			{
				_optional.onUpdateColor(color);
			}
			else if (dt != 0f && _optional.onUpdateColorObject != null)
			{
				_optional.onUpdateColorObject(color, _optional.onUpdateParam);
			}
		};
		return this;
	}

	public LTDescr setTextColor()
	{
		type = TweenAction.TEXT_COLOR;
		initInternal = delegate
		{
			uiText = trans.GetComponent<Text>();
			setFromColor((uiText != null) ? uiText.color : UnityEngine.Color.white);
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			UnityEngine.Color color = tweenColor(this, val);
			uiText.color = color;
			if (dt != 0f && _optional.onUpdateColor != null)
			{
				_optional.onUpdateColor(color);
			}
			if (useRecursion && trans.childCount > 0)
			{
				textColorRecursive(trans, color);
			}
		};
		return this;
	}

	public LTDescr setCanvasAlpha()
	{
		type = TweenAction.CANVAS_ALPHA;
		initInternal = delegate
		{
			uiImage = trans.GetComponent<UnityEngine.UI.Image>();
			if (uiImage != null)
			{
				fromInternal.x = uiImage.color.a;
			}
			else
			{
				rawImage = trans.GetComponent<RawImage>();
				if (rawImage != null)
				{
					fromInternal.x = rawImage.color.a;
				}
				else
				{
					fromInternal.x = 1f;
				}
			}
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			if (uiImage != null)
			{
				UnityEngine.Color color = uiImage.color;
				color.a = val;
				uiImage.color = color;
			}
			else if (rawImage != null)
			{
				UnityEngine.Color color2 = rawImage.color;
				color2.a = val;
				rawImage.color = color2;
			}
			if (useRecursion)
			{
				alphaRecursive(rectTransform, val);
				textAlphaChildrenRecursive(rectTransform, val);
			}
		};
		return this;
	}

	public LTDescr setCanvasGroupAlpha()
	{
		type = TweenAction.CANVASGROUP_ALPHA;
		initInternal = delegate
		{
			fromInternal.x = trans.GetComponent<CanvasGroup>().alpha;
		};
		easeInternal = delegate
		{
			trans.GetComponent<CanvasGroup>().alpha = easeMethod().x;
		};
		return this;
	}

	public LTDescr setCanvasColor()
	{
		type = TweenAction.CANVAS_COLOR;
		initInternal = delegate
		{
			uiImage = trans.GetComponent<UnityEngine.UI.Image>();
			if (uiImage == null)
			{
				rawImage = trans.GetComponent<RawImage>();
				setFromColor((rawImage != null) ? rawImage.color : UnityEngine.Color.white);
			}
			else
			{
				setFromColor(uiImage.color);
			}
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			UnityEngine.Color color = tweenColor(this, val);
			if (uiImage != null)
			{
				uiImage.color = color;
			}
			else if (rawImage != null)
			{
				rawImage.color = color;
			}
			if (dt != 0f && _optional.onUpdateColor != null)
			{
				_optional.onUpdateColor(color);
			}
			if (useRecursion)
			{
				colorRecursive(rectTransform, color);
			}
		};
		return this;
	}

	public LTDescr setCanvasMoveX()
	{
		type = TweenAction.CANVAS_MOVE_X;
		initInternal = delegate
		{
			fromInternal.x = rectTransform.anchoredPosition3D.x;
		};
		easeInternal = delegate
		{
			Vector3 anchoredPosition3D = rectTransform.anchoredPosition3D;
			rectTransform.anchoredPosition3D = new Vector3(easeMethod().x, anchoredPosition3D.y, anchoredPosition3D.z);
		};
		return this;
	}

	public LTDescr setCanvasMoveY()
	{
		type = TweenAction.CANVAS_MOVE_Y;
		initInternal = delegate
		{
			fromInternal.x = rectTransform.anchoredPosition3D.y;
		};
		easeInternal = delegate
		{
			Vector3 anchoredPosition3D = rectTransform.anchoredPosition3D;
			rectTransform.anchoredPosition3D = new Vector3(anchoredPosition3D.x, easeMethod().x, anchoredPosition3D.z);
		};
		return this;
	}

	public LTDescr setCanvasMoveZ()
	{
		type = TweenAction.CANVAS_MOVE_Z;
		initInternal = delegate
		{
			fromInternal.x = rectTransform.anchoredPosition3D.z;
		};
		easeInternal = delegate
		{
			Vector3 anchoredPosition3D = rectTransform.anchoredPosition3D;
			rectTransform.anchoredPosition3D = new Vector3(anchoredPosition3D.x, anchoredPosition3D.y, easeMethod().x);
		};
		return this;
	}

	private void initCanvasRotateAround()
	{
		lastVal = 0f;
		fromInternal.x = 0f;
		_optional.origRotation = rectTransform.rotation;
	}

	public LTDescr setCanvasRotateAround()
	{
		type = TweenAction.CANVAS_ROTATEAROUND;
		initInternal = initCanvasRotateAround;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			RectTransform rectTransform = this.rectTransform;
			Vector3 localPosition = rectTransform.localPosition;
			rectTransform.RotateAround(rectTransform.TransformPoint(_optional.point), _optional.axis, 0f - val);
			Vector3 vector = localPosition - rectTransform.localPosition;
			rectTransform.localPosition = localPosition - vector;
			rectTransform.rotation = _optional.origRotation;
			rectTransform.RotateAround(rectTransform.TransformPoint(_optional.point), _optional.axis, val);
		};
		return this;
	}

	public LTDescr setCanvasRotateAroundLocal()
	{
		type = TweenAction.CANVAS_ROTATEAROUND_LOCAL;
		initInternal = initCanvasRotateAround;
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			RectTransform rectTransform = this.rectTransform;
			Vector3 localPosition = rectTransform.localPosition;
			rectTransform.RotateAround(rectTransform.TransformPoint(_optional.point), rectTransform.TransformDirection(_optional.axis), 0f - val);
			Vector3 vector = localPosition - rectTransform.localPosition;
			rectTransform.localPosition = localPosition - vector;
			rectTransform.rotation = _optional.origRotation;
			rectTransform.RotateAround(rectTransform.TransformPoint(_optional.point), rectTransform.TransformDirection(_optional.axis), val);
		};
		return this;
	}

	public LTDescr setCanvasPlaySprite()
	{
		type = TweenAction.CANVAS_PLAYSPRITE;
		initInternal = delegate
		{
			uiImage = trans.GetComponent<UnityEngine.UI.Image>();
			fromInternal.x = 0f;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			val = newVect.x;
			int num = (int)Mathf.Round(val);
			uiImage.sprite = sprites[num];
		};
		return this;
	}

	public LTDescr setCanvasMove()
	{
		type = TweenAction.CANVAS_MOVE;
		initInternal = delegate
		{
			fromInternal = rectTransform.anchoredPosition3D;
		};
		easeInternal = delegate
		{
			rectTransform.anchoredPosition3D = easeMethod();
		};
		return this;
	}

	public LTDescr setCanvasScale()
	{
		type = TweenAction.CANVAS_SCALE;
		initInternal = delegate
		{
			from = rectTransform.localScale;
		};
		easeInternal = delegate
		{
			rectTransform.localScale = easeMethod();
		};
		return this;
	}

	public LTDescr setCanvasSizeDelta()
	{
		type = TweenAction.CANVAS_SIZEDELTA;
		initInternal = delegate
		{
			from = rectTransform.sizeDelta;
		};
		easeInternal = delegate
		{
			rectTransform.sizeDelta = easeMethod();
		};
		return this;
	}

	private void callback()
	{
		newVect = easeMethod();
		val = newVect.x;
	}

	public LTDescr setCallback()
	{
		type = TweenAction.CALLBACK;
		initInternal = delegate
		{
		};
		easeInternal = callback;
		return this;
	}

	public LTDescr setValue3()
	{
		type = TweenAction.VALUE3;
		initInternal = delegate
		{
		};
		easeInternal = callback;
		return this;
	}

	public LTDescr setMove()
	{
		type = TweenAction.MOVE;
		initInternal = delegate
		{
			from = trans.position;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			trans.position = newVect;
		};
		return this;
	}

	public LTDescr setMoveLocal()
	{
		type = TweenAction.MOVE_LOCAL;
		initInternal = delegate
		{
			from = trans.localPosition;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			trans.localPosition = newVect;
		};
		return this;
	}

	public LTDescr setMoveToTransform()
	{
		type = TweenAction.MOVE_TO_TRANSFORM;
		initInternal = delegate
		{
			from = trans.position;
		};
		easeInternal = delegate
		{
			to = _optional.toTrans.position;
			diff = to - from;
			diffDiv2 = diff * 0.5f;
			newVect = easeMethod();
			trans.position = newVect;
		};
		return this;
	}

	public LTDescr setRotate()
	{
		type = TweenAction.ROTATE;
		initInternal = delegate
		{
			from = trans.eulerAngles;
			to = new Vector3(LeanTween.closestRot(fromInternal.x, toInternal.x), LeanTween.closestRot(from.y, to.y), LeanTween.closestRot(from.z, to.z));
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			trans.eulerAngles = newVect;
		};
		return this;
	}

	public LTDescr setRotateLocal()
	{
		type = TweenAction.ROTATE_LOCAL;
		initInternal = delegate
		{
			from = trans.localEulerAngles;
			to = new Vector3(LeanTween.closestRot(fromInternal.x, toInternal.x), LeanTween.closestRot(from.y, to.y), LeanTween.closestRot(from.z, to.z));
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			trans.localEulerAngles = newVect;
		};
		return this;
	}

	public LTDescr setScale()
	{
		type = TweenAction.SCALE;
		initInternal = delegate
		{
			from = trans.localScale;
		};
		easeInternal = delegate
		{
			newVect = easeMethod();
			trans.localScale = newVect;
		};
		return this;
	}

	public LTDescr setGUIMove()
	{
		type = TweenAction.GUI_MOVE;
		initInternal = delegate
		{
			from = new Vector3(_optional.ltRect.rect.x, _optional.ltRect.rect.y, 0f);
		};
		easeInternal = delegate
		{
			Vector3 vector = easeMethod();
			_optional.ltRect.rect = new Rect(vector.x, vector.y, _optional.ltRect.rect.width, _optional.ltRect.rect.height);
		};
		return this;
	}

	public LTDescr setGUIMoveMargin()
	{
		type = TweenAction.GUI_MOVE_MARGIN;
		initInternal = delegate
		{
			from = new Vector2(_optional.ltRect.margin.x, _optional.ltRect.margin.y);
		};
		easeInternal = delegate
		{
			Vector3 vector = easeMethod();
			_optional.ltRect.margin = new Vector2(vector.x, vector.y);
		};
		return this;
	}

	public LTDescr setGUIScale()
	{
		type = TweenAction.GUI_SCALE;
		initInternal = delegate
		{
			from = new Vector3(_optional.ltRect.rect.width, _optional.ltRect.rect.height, 0f);
		};
		easeInternal = delegate
		{
			Vector3 vector = easeMethod();
			_optional.ltRect.rect = new Rect(_optional.ltRect.rect.x, _optional.ltRect.rect.y, vector.x, vector.y);
		};
		return this;
	}

	public LTDescr setGUIAlpha()
	{
		type = TweenAction.GUI_ALPHA;
		initInternal = delegate
		{
			fromInternal.x = _optional.ltRect.alpha;
		};
		easeInternal = delegate
		{
			_optional.ltRect.alpha = easeMethod().x;
		};
		return this;
	}

	public LTDescr setGUIRotate()
	{
		type = TweenAction.GUI_ROTATE;
		initInternal = delegate
		{
			if (!_optional.ltRect.rotateEnabled)
			{
				_optional.ltRect.rotateEnabled = true;
				_optional.ltRect.resetForRotation();
			}
			fromInternal.x = _optional.ltRect.rotation;
		};
		easeInternal = delegate
		{
			_optional.ltRect.rotation = easeMethod().x;
		};
		return this;
	}

	public LTDescr setDelayedSound()
	{
		type = TweenAction.DELAYED_SOUND;
		initInternal = delegate
		{
			hasExtraOnCompletes = true;
		};
		easeInternal = callback;
		return this;
	}

	private void init()
	{
		hasInitiliazed = true;
		usesNormalDt = !useEstimatedTime && !useManualTime && !useFrames;
		if (useFrames)
		{
			optional.initFrameCount = Time.frameCount;
		}
		if (time <= 0f)
		{
			time = Mathf.Epsilon;
		}
		initInternal();
		diff = to - from;
		diffDiv2 = diff * 0.5f;
		if (_optional.onStart != null)
		{
			_optional.onStart();
		}
		if (onCompleteOnStart)
		{
			callOnCompletes();
		}
		if (speed >= 0f)
		{
			initSpeed();
		}
	}

	private void initSpeed()
	{
		if (type == TweenAction.MOVE_CURVED || type == TweenAction.MOVE_CURVED_LOCAL)
		{
			time = _optional.path.distance / speed;
		}
		else if (type == TweenAction.MOVE_SPLINE || type == TweenAction.MOVE_SPLINE_LOCAL)
		{
			time = _optional.spline.distance / speed;
		}
		else
		{
			time = (to - from).magnitude / speed;
		}
	}

	public LTDescr updateNow()
	{
		updateInternal();
		return this;
	}

	public bool updateInternal()
	{
		float num = direction;
		if (usesNormalDt)
		{
			dt = LeanTween.dtActual;
		}
		else if (useEstimatedTime)
		{
			dt = LeanTween.dtEstimated;
		}
		else if (useFrames)
		{
			dt = ((optional.initFrameCount != 0) ? 1 : 0);
			optional.initFrameCount = Time.frameCount;
		}
		else if (useManualTime)
		{
			dt = LeanTween.dtManual;
		}
		if (delay <= 0f && num != 0f)
		{
			if (trans == null)
			{
				return true;
			}
			if (!hasInitiliazed)
			{
				init();
			}
			dt *= num;
			passed += dt;
			ratioPassed = Mathf.Clamp01(passed / time);
			easeInternal();
			if (hasUpdateCallback)
			{
				_optional.callOnUpdate(val, ratioPassed);
			}
			if ((num > 0f) ? (passed >= time) : (passed <= 0f))
			{
				loopCount--;
				if (loopType == LeanTweenType.pingPong)
				{
					direction = 0f - num;
				}
				else
				{
					passed = Mathf.Epsilon;
				}
				int num2;
				if (loopCount != 0)
				{
					num2 = ((loopType == LeanTweenType.once) ? 1 : 0);
					if (num2 == 0 && onCompleteOnRepeat && hasExtraOnCompletes)
					{
						callOnCompletes();
					}
				}
				else
				{
					num2 = 1;
				}
				return (byte)num2 != 0;
			}
		}
		else
		{
			delay -= dt;
		}
		return false;
	}

	public void callOnCompletes()
	{
		if (type == TweenAction.GUI_ROTATE)
		{
			_optional.ltRect.rotateFinished = true;
		}
		if (type == TweenAction.DELAYED_SOUND)
		{
			AudioSource.PlayClipAtPoint((AudioClip)_optional.onCompleteParam, to, from.x);
		}
		if (_optional.onComplete != null)
		{
			_optional.onComplete();
		}
		else if (_optional.onCompleteObject != null)
		{
			_optional.onCompleteObject(_optional.onCompleteParam);
		}
	}

	public LTDescr setFromColor(UnityEngine.Color col)
	{
		from = new Vector3(0f, col.a, 0f);
		diff = new Vector3(1f, 0f, 0f);
		_optional.axis = new Vector3(col.r, col.g, col.b);
		return this;
	}

	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
		Renderer component = transform.gameObject.GetComponent<Renderer>();
		if (component != null)
		{
			Material[] materials = component.materials;
			foreach (Material material in materials)
			{
				if (material.HasProperty("_Color"))
				{
					material.color = new UnityEngine.Color(material.color.r, material.color.g, material.color.b, val);
				}
				else if (material.HasProperty("_TintColor"))
				{
					UnityEngine.Color color = material.GetColor("_TintColor");
					material.SetColor("_TintColor", new UnityEngine.Color(color.r, color.g, color.b, val));
				}
			}
		}
		if (!useRecursion || transform.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in transform)
		{
			alphaRecursive(item, val);
		}
	}

	private static void colorRecursive(Transform transform, UnityEngine.Color toColor, bool useRecursion = true)
	{
		Renderer component = transform.gameObject.GetComponent<Renderer>();
		if (component != null)
		{
			Material[] materials = component.materials;
			for (int i = 0; i < materials.Length; i++)
			{
				materials[i].color = toColor;
			}
		}
		if (!useRecursion || transform.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in transform)
		{
			colorRecursive(item, toColor);
		}
	}

	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
		if (rectTransform.childCount <= 0)
		{
			return;
		}
		foreach (RectTransform item in rectTransform)
		{
			MaskableGraphic component = item.GetComponent<UnityEngine.UI.Image>();
			if (component != null)
			{
				UnityEngine.Color color = component.color;
				color.a = val;
				component.color = color;
			}
			else
			{
				component = item.GetComponent<RawImage>();
				if (component != null)
				{
					UnityEngine.Color color2 = component.color;
					color2.a = val;
					component.color = color2;
				}
			}
			alphaRecursive(item, val, recursiveLevel + 1);
		}
	}

	private static void alphaRecursiveSprite(Transform transform, float val)
	{
		if (transform.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in transform)
		{
			SpriteRenderer component = item.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				component.color = new UnityEngine.Color(component.color.r, component.color.g, component.color.b, val);
			}
			alphaRecursiveSprite(item, val);
		}
	}

	private static void colorRecursiveSprite(Transform transform, UnityEngine.Color toColor)
	{
		if (transform.childCount <= 0)
		{
			return;
		}
		foreach (Transform item in transform)
		{
			SpriteRenderer component = transform.gameObject.GetComponent<SpriteRenderer>();
			if (component != null)
			{
				component.color = toColor;
			}
			colorRecursiveSprite(item, toColor);
		}
	}

	private static void colorRecursive(RectTransform rectTransform, UnityEngine.Color toColor)
	{
		if (rectTransform.childCount <= 0)
		{
			return;
		}
		foreach (RectTransform item in rectTransform)
		{
			MaskableGraphic component = item.GetComponent<UnityEngine.UI.Image>();
			if (component != null)
			{
				component.color = toColor;
			}
			else
			{
				component = item.GetComponent<RawImage>();
				if (component != null)
				{
					component.color = toColor;
				}
			}
			colorRecursive(item, toColor);
		}
	}

	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
		if (!useRecursion || trans.childCount <= 0)
		{
			return;
		}
		foreach (Transform tran in trans)
		{
			Text component = tran.GetComponent<Text>();
			if (component != null)
			{
				UnityEngine.Color color = component.color;
				color.a = val;
				component.color = color;
			}
			textAlphaChildrenRecursive(tran, val);
		}
	}

	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
		Text component = trans.GetComponent<Text>();
		if (component != null)
		{
			UnityEngine.Color color = component.color;
			color.a = val;
			component.color = color;
		}
		if (!useRecursion || trans.childCount <= 0)
		{
			return;
		}
		foreach (Transform tran in trans)
		{
			textAlphaRecursive(tran, val);
		}
	}

	private static void textColorRecursive(Transform trans, UnityEngine.Color toColor)
	{
		if (trans.childCount <= 0)
		{
			return;
		}
		foreach (Transform tran in trans)
		{
			Text component = tran.GetComponent<Text>();
			if (component != null)
			{
				component.color = toColor;
			}
			textColorRecursive(tran, toColor);
		}
	}

	private static UnityEngine.Color tweenColor(LTDescr tween, float val)
	{
		Vector3 vector = tween._optional.point - tween._optional.axis;
		float num = tween.to.y - tween.from.y;
		return new UnityEngine.Color(tween._optional.axis.x + vector.x * val, tween._optional.axis.y + vector.y * val, tween._optional.axis.z + vector.z * val, tween.from.y + num * val);
	}

	public LTDescr pause()
	{
		if (direction != 0f)
		{
			directionLast = direction;
			direction = 0f;
		}
		return this;
	}

	public LTDescr resume()
	{
		direction = directionLast;
		return this;
	}

	public LTDescr setAxis(Vector3 axis)
	{
		_optional.axis = axis;
		return this;
	}

	public LTDescr setDelay(float delay)
	{
		this.delay = delay;
		return this;
	}

	public LTDescr setEase(LeanTweenType easeType)
	{
		switch (easeType)
		{
		case LeanTweenType.linear:
			setEaseLinear();
			break;
		case LeanTweenType.easeOutQuad:
			setEaseOutQuad();
			break;
		case LeanTweenType.easeInQuad:
			setEaseInQuad();
			break;
		case LeanTweenType.easeInOutQuad:
			setEaseInOutQuad();
			break;
		case LeanTweenType.easeInCubic:
			setEaseInCubic();
			break;
		case LeanTweenType.easeOutCubic:
			setEaseOutCubic();
			break;
		case LeanTweenType.easeInOutCubic:
			setEaseInOutCubic();
			break;
		case LeanTweenType.easeInQuart:
			setEaseInQuart();
			break;
		case LeanTweenType.easeOutQuart:
			setEaseOutQuart();
			break;
		case LeanTweenType.easeInOutQuart:
			setEaseInOutQuart();
			break;
		case LeanTweenType.easeInQuint:
			setEaseInQuint();
			break;
		case LeanTweenType.easeOutQuint:
			setEaseOutQuint();
			break;
		case LeanTweenType.easeInOutQuint:
			setEaseInOutQuint();
			break;
		case LeanTweenType.easeInSine:
			setEaseInSine();
			break;
		case LeanTweenType.easeOutSine:
			setEaseOutSine();
			break;
		case LeanTweenType.easeInOutSine:
			setEaseInOutSine();
			break;
		case LeanTweenType.easeInExpo:
			setEaseInExpo();
			break;
		case LeanTweenType.easeOutExpo:
			setEaseOutExpo();
			break;
		case LeanTweenType.easeInOutExpo:
			setEaseInOutExpo();
			break;
		case LeanTweenType.easeInCirc:
			setEaseInCirc();
			break;
		case LeanTweenType.easeOutCirc:
			setEaseOutCirc();
			break;
		case LeanTweenType.easeInOutCirc:
			setEaseInOutCirc();
			break;
		case LeanTweenType.easeInBounce:
			setEaseInBounce();
			break;
		case LeanTweenType.easeOutBounce:
			setEaseOutBounce();
			break;
		case LeanTweenType.easeInOutBounce:
			setEaseInOutBounce();
			break;
		case LeanTweenType.easeInBack:
			setEaseInBack();
			break;
		case LeanTweenType.easeOutBack:
			setEaseOutBack();
			break;
		case LeanTweenType.easeInOutBack:
			setEaseInOutBack();
			break;
		case LeanTweenType.easeInElastic:
			setEaseInElastic();
			break;
		case LeanTweenType.easeOutElastic:
			setEaseOutElastic();
			break;
		case LeanTweenType.easeInOutElastic:
			setEaseInOutElastic();
			break;
		case LeanTweenType.punch:
			setEasePunch();
			break;
		case LeanTweenType.easeShake:
			setEaseShake();
			break;
		case LeanTweenType.easeSpring:
			setEaseSpring();
			break;
		default:
			setEaseLinear();
			break;
		}
		return this;
	}

	public LTDescr setEaseLinear()
	{
		easeType = LeanTweenType.linear;
		easeMethod = easeLinear;
		return this;
	}

	public LTDescr setEaseSpring()
	{
		easeType = LeanTweenType.easeSpring;
		easeMethod = easeSpring;
		return this;
	}

	public LTDescr setEaseInQuad()
	{
		easeType = LeanTweenType.easeInQuad;
		easeMethod = easeInQuad;
		return this;
	}

	public LTDescr setEaseOutQuad()
	{
		easeType = LeanTweenType.easeOutQuad;
		easeMethod = easeOutQuad;
		return this;
	}

	public LTDescr setEaseInOutQuad()
	{
		easeType = LeanTweenType.easeInOutQuad;
		easeMethod = easeInOutQuad;
		return this;
	}

	public LTDescr setEaseInCubic()
	{
		easeType = LeanTweenType.easeInCubic;
		easeMethod = easeInCubic;
		return this;
	}

	public LTDescr setEaseOutCubic()
	{
		easeType = LeanTweenType.easeOutCubic;
		easeMethod = easeOutCubic;
		return this;
	}

	public LTDescr setEaseInOutCubic()
	{
		easeType = LeanTweenType.easeInOutCubic;
		easeMethod = easeInOutCubic;
		return this;
	}

	public LTDescr setEaseInQuart()
	{
		easeType = LeanTweenType.easeInQuart;
		easeMethod = easeInQuart;
		return this;
	}

	public LTDescr setEaseOutQuart()
	{
		easeType = LeanTweenType.easeOutQuart;
		easeMethod = easeOutQuart;
		return this;
	}

	public LTDescr setEaseInOutQuart()
	{
		easeType = LeanTweenType.easeInOutQuart;
		easeMethod = easeInOutQuart;
		return this;
	}

	public LTDescr setEaseInQuint()
	{
		easeType = LeanTweenType.easeInQuint;
		easeMethod = easeInQuint;
		return this;
	}

	public LTDescr setEaseOutQuint()
	{
		easeType = LeanTweenType.easeOutQuint;
		easeMethod = easeOutQuint;
		return this;
	}

	public LTDescr setEaseInOutQuint()
	{
		easeType = LeanTweenType.easeInOutQuint;
		easeMethod = easeInOutQuint;
		return this;
	}

	public LTDescr setEaseInSine()
	{
		easeType = LeanTweenType.easeInSine;
		easeMethod = easeInSine;
		return this;
	}

	public LTDescr setEaseOutSine()
	{
		easeType = LeanTweenType.easeOutSine;
		easeMethod = easeOutSine;
		return this;
	}

	public LTDescr setEaseInOutSine()
	{
		easeType = LeanTweenType.easeInOutSine;
		easeMethod = easeInOutSine;
		return this;
	}

	public LTDescr setEaseInExpo()
	{
		easeType = LeanTweenType.easeInExpo;
		easeMethod = easeInExpo;
		return this;
	}

	public LTDescr setEaseOutExpo()
	{
		easeType = LeanTweenType.easeOutExpo;
		easeMethod = easeOutExpo;
		return this;
	}

	public LTDescr setEaseInOutExpo()
	{
		easeType = LeanTweenType.easeInOutExpo;
		easeMethod = easeInOutExpo;
		return this;
	}

	public LTDescr setEaseInCirc()
	{
		easeType = LeanTweenType.easeInCirc;
		easeMethod = easeInCirc;
		return this;
	}

	public LTDescr setEaseOutCirc()
	{
		easeType = LeanTweenType.easeOutCirc;
		easeMethod = easeOutCirc;
		return this;
	}

	public LTDescr setEaseInOutCirc()
	{
		easeType = LeanTweenType.easeInOutCirc;
		easeMethod = easeInOutCirc;
		return this;
	}

	public LTDescr setEaseInBounce()
	{
		easeType = LeanTweenType.easeInBounce;
		easeMethod = easeInBounce;
		return this;
	}

	public LTDescr setEaseOutBounce()
	{
		easeType = LeanTweenType.easeOutBounce;
		easeMethod = easeOutBounce;
		return this;
	}

	public LTDescr setEaseInOutBounce()
	{
		easeType = LeanTweenType.easeInOutBounce;
		easeMethod = easeInOutBounce;
		return this;
	}

	public LTDescr setEaseInBack()
	{
		easeType = LeanTweenType.easeInBack;
		easeMethod = easeInBack;
		return this;
	}

	public LTDescr setEaseOutBack()
	{
		easeType = LeanTweenType.easeOutBack;
		easeMethod = easeOutBack;
		return this;
	}

	public LTDescr setEaseInOutBack()
	{
		easeType = LeanTweenType.easeInOutBack;
		easeMethod = easeInOutBack;
		return this;
	}

	public LTDescr setEaseInElastic()
	{
		easeType = LeanTweenType.easeInElastic;
		easeMethod = easeInElastic;
		return this;
	}

	public LTDescr setEaseOutElastic()
	{
		easeType = LeanTweenType.easeOutElastic;
		easeMethod = easeOutElastic;
		return this;
	}

	public LTDescr setEaseInOutElastic()
	{
		easeType = LeanTweenType.easeInOutElastic;
		easeMethod = easeInOutElastic;
		return this;
	}

	public LTDescr setEasePunch()
	{
		_optional.animationCurve = LeanTween.punch;
		toInternal.x = from.x + to.x;
		easeMethod = tweenOnCurve;
		return this;
	}

	public LTDescr setEaseShake()
	{
		_optional.animationCurve = LeanTween.shake;
		toInternal.x = from.x + to.x;
		easeMethod = tweenOnCurve;
		return this;
	}

	private Vector3 tweenOnCurve()
	{
		return new Vector3(from.x + diff.x * _optional.animationCurve.Evaluate(ratioPassed), from.y + diff.y * _optional.animationCurve.Evaluate(ratioPassed), from.z + diff.z * _optional.animationCurve.Evaluate(ratioPassed));
	}

	private Vector3 easeInOutQuad()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			val *= val;
			return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
		}
		val = (1f - val) * (val - 3f) + 1f;
		return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
	}

	private Vector3 easeInQuad()
	{
		val = ratioPassed * ratioPassed;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeOutQuad()
	{
		val = ratioPassed;
		val = (0f - val) * (val - 2f);
		return diff * val + from;
	}

	private Vector3 easeLinear()
	{
		val = ratioPassed;
		return new Vector3(from.x + diff.x * val, from.y + diff.y * val, from.z + diff.z * val);
	}

	private Vector3 easeSpring()
	{
		val = Mathf.Clamp01(ratioPassed);
		val = (Mathf.Sin(val * (float)Math.PI * (0.2f + 2.5f * val * val * val)) * Mathf.Pow(1f - val, 2.2f) + val) * (1f + 1.2f * (1f - val));
		return from + diff * val;
	}

	private Vector3 easeInCubic()
	{
		val = ratioPassed * ratioPassed * ratioPassed;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeOutCubic()
	{
		val = ratioPassed - 1f;
		val = val * val * val + 1f;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutCubic()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			val = val * val * val;
			return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
		}
		val -= 2f;
		val = val * val * val + 2f;
		return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
	}

	private Vector3 easeInQuart()
	{
		val = ratioPassed * ratioPassed * ratioPassed * ratioPassed;
		return diff * val + from;
	}

	private Vector3 easeOutQuart()
	{
		val = ratioPassed - 1f;
		val = 0f - (val * val * val * val - 1f);
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutQuart()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			val = val * val * val * val;
			return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
		}
		val -= 2f;
		return -diffDiv2 * (val * val * val * val - 2f) + from;
	}

	private Vector3 easeInQuint()
	{
		val = ratioPassed;
		val = val * val * val * val * val;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeOutQuint()
	{
		val = ratioPassed - 1f;
		val = val * val * val * val * val + 1f;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutQuint()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			val = val * val * val * val * val;
			return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
		}
		val -= 2f;
		val = val * val * val * val * val + 2f;
		return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
	}

	private Vector3 easeInSine()
	{
		val = 0f - Mathf.Cos(ratioPassed * LeanTween.PI_DIV2);
		return new Vector3(diff.x * val + diff.x + from.x, diff.y * val + diff.y + from.y, diff.z * val + diff.z + from.z);
	}

	private Vector3 easeOutSine()
	{
		val = Mathf.Sin(ratioPassed * LeanTween.PI_DIV2);
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutSine()
	{
		val = 0f - (Mathf.Cos((float)Math.PI * ratioPassed) - 1f);
		return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
	}

	private Vector3 easeInExpo()
	{
		val = Mathf.Pow(2f, 10f * (ratioPassed - 1f));
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeOutExpo()
	{
		val = 0f - Mathf.Pow(2f, -10f * ratioPassed) + 1f;
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutExpo()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			return diffDiv2 * Mathf.Pow(2f, 10f * (val - 1f)) + from;
		}
		val -= 1f;
		return diffDiv2 * (0f - Mathf.Pow(2f, -10f * val) + 2f) + from;
	}

	private Vector3 easeInCirc()
	{
		val = 0f - (Mathf.Sqrt(1f - ratioPassed * ratioPassed) - 1f);
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeOutCirc()
	{
		val = ratioPassed - 1f;
		val = Mathf.Sqrt(1f - val * val);
		return new Vector3(diff.x * val + from.x, diff.y * val + from.y, diff.z * val + from.z);
	}

	private Vector3 easeInOutCirc()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			val = 0f - (Mathf.Sqrt(1f - val * val) - 1f);
			return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
		}
		val -= 2f;
		val = Mathf.Sqrt(1f - val * val) + 1f;
		return new Vector3(diffDiv2.x * val + from.x, diffDiv2.y * val + from.y, diffDiv2.z * val + from.z);
	}

	private Vector3 easeInBounce()
	{
		val = ratioPassed;
		val = 1f - val;
		return new Vector3(diff.x - LeanTween.easeOutBounce(0f, diff.x, val) + from.x, diff.y - LeanTween.easeOutBounce(0f, diff.y, val) + from.y, diff.z - LeanTween.easeOutBounce(0f, diff.z, val) + from.z);
	}

	private Vector3 easeOutBounce()
	{
		val = ratioPassed;
		float num2;
		float num;
		if (val < (num = 1f - 1.75f * overshoot / 2.75f))
		{
			val = 1f / num / num * val * val;
		}
		else if (val < (num2 = 1f - 0.75f * overshoot / 2.75f))
		{
			val -= (num + num2) / 2f;
			val = 7.5625f * val * val + 1f - 0.25f * overshoot * overshoot;
		}
		else if (val < (num = 1f - 0.25f * overshoot / 2.75f))
		{
			val -= (num + num2) / 2f;
			val = 7.5625f * val * val + 1f - 0.0625f * overshoot * overshoot;
		}
		else
		{
			val -= (num + 1f) / 2f;
			val = 7.5625f * val * val + 1f - 1f / 64f * overshoot * overshoot;
		}
		return diff * val + from;
	}

	private Vector3 easeInOutBounce()
	{
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			return new Vector3(LeanTween.easeInBounce(0f, diff.x, val) * 0.5f + from.x, LeanTween.easeInBounce(0f, diff.y, val) * 0.5f + from.y, LeanTween.easeInBounce(0f, diff.z, val) * 0.5f + from.z);
		}
		val -= 1f;
		return new Vector3(LeanTween.easeOutBounce(0f, diff.x, val) * 0.5f + diffDiv2.x + from.x, LeanTween.easeOutBounce(0f, diff.y, val) * 0.5f + diffDiv2.y + from.y, LeanTween.easeOutBounce(0f, diff.z, val) * 0.5f + diffDiv2.z + from.z);
	}

	private Vector3 easeInBack()
	{
		val = ratioPassed;
		val /= 1f;
		float num = 1.70158f * overshoot;
		return diff * val * val * ((num + 1f) * val - num) + from;
	}

	private Vector3 easeOutBack()
	{
		float num = 1.70158f * overshoot;
		val = ratioPassed / 1f - 1f;
		val = val * val * ((num + 1f) * val + num) + 1f;
		return diff * val + from;
	}

	private Vector3 easeInOutBack()
	{
		float num = 1.70158f * overshoot;
		val = ratioPassed * 2f;
		if (val < 1f)
		{
			num *= 1.525f * overshoot;
			return diffDiv2 * (val * val * ((num + 1f) * val - num)) + from;
		}
		val -= 2f;
		num *= 1.525f * overshoot;
		val = val * val * ((num + 1f) * val + num) + 2f;
		return diffDiv2 * val + from;
	}

	private Vector3 easeInElastic()
	{
		return new Vector3(LeanTween.easeInElastic(from.x, to.x, ratioPassed, overshoot, period), LeanTween.easeInElastic(from.y, to.y, ratioPassed, overshoot, period), LeanTween.easeInElastic(from.z, to.z, ratioPassed, overshoot, period));
	}

	private Vector3 easeOutElastic()
	{
		return new Vector3(LeanTween.easeOutElastic(from.x, to.x, ratioPassed, overshoot, period), LeanTween.easeOutElastic(from.y, to.y, ratioPassed, overshoot, period), LeanTween.easeOutElastic(from.z, to.z, ratioPassed, overshoot, period));
	}

	private Vector3 easeInOutElastic()
	{
		return new Vector3(LeanTween.easeInOutElastic(from.x, to.x, ratioPassed, overshoot, period), LeanTween.easeInOutElastic(from.y, to.y, ratioPassed, overshoot, period), LeanTween.easeInOutElastic(from.z, to.z, ratioPassed, overshoot, period));
	}

	public LTDescr setOvershoot(float overshoot)
	{
		this.overshoot = overshoot;
		return this;
	}

	public LTDescr setPeriod(float period)
	{
		this.period = period;
		return this;
	}

	public LTDescr setScale(float scale)
	{
		this.scale = scale;
		return this;
	}

	public LTDescr setEase(AnimationCurve easeCurve)
	{
		_optional.animationCurve = easeCurve;
		easeMethod = tweenOnCurve;
		easeType = LeanTweenType.animationCurve;
		return this;
	}

	public LTDescr setTo(Vector3 to)
	{
		if (hasInitiliazed)
		{
			this.to = to;
			diff = to - from;
		}
		else
		{
			this.to = to;
		}
		return this;
	}

	public LTDescr setTo(Transform to)
	{
		_optional.toTrans = to;
		return this;
	}

	public LTDescr setFrom(Vector3 from)
	{
		if ((bool)trans)
		{
			init();
		}
		this.from = from;
		diff = to - this.from;
		diffDiv2 = diff * 0.5f;
		return this;
	}

	public LTDescr setFrom(float from)
	{
		return setFrom(new Vector3(from, 0f, 0f));
	}

	public LTDescr setDiff(Vector3 diff)
	{
		this.diff = diff;
		return this;
	}

	public LTDescr setHasInitialized(bool has)
	{
		hasInitiliazed = has;
		return this;
	}

	public LTDescr setId(uint id, uint global_counter)
	{
		_id = id;
		counter = global_counter;
		return this;
	}

	public LTDescr setPassed(float passed)
	{
		this.passed = passed;
		return this;
	}

	public LTDescr setTime(float time)
	{
		float num = passed / this.time;
		passed = time * num;
		this.time = time;
		return this;
	}

	public LTDescr setSpeed(float speed)
	{
		this.speed = speed;
		if (hasInitiliazed)
		{
			initSpeed();
		}
		return this;
	}

	public LTDescr setRepeat(int repeat)
	{
		loopCount = repeat;
		if ((repeat > 1 && loopType == LeanTweenType.once) || (repeat < 0 && loopType == LeanTweenType.once))
		{
			loopType = LeanTweenType.clamp;
		}
		if (type == TweenAction.CALLBACK || type == TweenAction.CALLBACK_COLOR)
		{
			setOnCompleteOnRepeat(isOn: true);
		}
		return this;
	}

	public LTDescr setLoopType(LeanTweenType loopType)
	{
		this.loopType = loopType;
		return this;
	}

	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		this.useEstimatedTime = useEstimatedTime;
		usesNormalDt = false;
		return this;
	}

	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		useEstimatedTime = useUnScaledTime;
		usesNormalDt = false;
		return this;
	}

	public LTDescr setUseFrames(bool useFrames)
	{
		this.useFrames = useFrames;
		usesNormalDt = false;
		return this;
	}

	public LTDescr setUseManualTime(bool useManualTime)
	{
		this.useManualTime = useManualTime;
		usesNormalDt = false;
		return this;
	}

	public LTDescr setLoopCount(int loopCount)
	{
		loopType = LeanTweenType.clamp;
		this.loopCount = loopCount;
		return this;
	}

	public LTDescr setLoopOnce()
	{
		loopType = LeanTweenType.once;
		return this;
	}

	public LTDescr setLoopClamp()
	{
		loopType = LeanTweenType.clamp;
		if (loopCount == 0)
		{
			loopCount = -1;
		}
		return this;
	}

	public LTDescr setLoopClamp(int loops)
	{
		loopCount = loops;
		return this;
	}

	public LTDescr setLoopPingPong()
	{
		loopType = LeanTweenType.pingPong;
		if (loopCount == 0)
		{
			loopCount = -1;
		}
		return this;
	}

	public LTDescr setLoopPingPong(int loops)
	{
		loopType = LeanTweenType.pingPong;
		loopCount = ((loops == -1) ? loops : (loops * 2));
		return this;
	}

	public LTDescr setOnComplete(Action onComplete)
	{
		_optional.onComplete = onComplete;
		hasExtraOnCompletes = true;
		return this;
	}

	public LTDescr setOnComplete(Action<object> onComplete)
	{
		_optional.onCompleteObject = onComplete;
		hasExtraOnCompletes = true;
		return this;
	}

	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		_optional.onCompleteObject = onComplete;
		hasExtraOnCompletes = true;
		if (onCompleteParam != null)
		{
			_optional.onCompleteParam = onCompleteParam;
		}
		return this;
	}

	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		_optional.onCompleteParam = onCompleteParam;
		hasExtraOnCompletes = true;
		return this;
	}

	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		_optional.onUpdateFloat = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		_optional.onUpdateFloatRatio = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		_optional.onUpdateFloatObject = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		_optional.onUpdateVector2 = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		_optional.onUpdateVector3 = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateColor(Action<UnityEngine.Color> onUpdate)
	{
		_optional.onUpdateColor = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdateColor(Action<UnityEngine.Color, object> onUpdate)
	{
		_optional.onUpdateColorObject = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdate(Action<UnityEngine.Color> onUpdate)
	{
		_optional.onUpdateColor = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdate(Action<UnityEngine.Color, object> onUpdate)
	{
		_optional.onUpdateColorObject = onUpdate;
		hasUpdateCallback = true;
		return this;
	}

	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam = null)
	{
		_optional.onUpdateFloatObject = onUpdate;
		hasUpdateCallback = true;
		if (onUpdateParam != null)
		{
			_optional.onUpdateParam = onUpdateParam;
		}
		return this;
	}

	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam = null)
	{
		_optional.onUpdateVector3Object = onUpdate;
		hasUpdateCallback = true;
		if (onUpdateParam != null)
		{
			_optional.onUpdateParam = onUpdateParam;
		}
		return this;
	}

	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam = null)
	{
		_optional.onUpdateVector2 = onUpdate;
		hasUpdateCallback = true;
		if (onUpdateParam != null)
		{
			_optional.onUpdateParam = onUpdateParam;
		}
		return this;
	}

	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam = null)
	{
		_optional.onUpdateVector3 = onUpdate;
		hasUpdateCallback = true;
		if (onUpdateParam != null)
		{
			_optional.onUpdateParam = onUpdateParam;
		}
		return this;
	}

	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		_optional.onUpdateParam = onUpdateParam;
		return this;
	}

	public LTDescr setOrientToPath(bool doesOrient)
	{
		if (type == TweenAction.MOVE_CURVED || type == TweenAction.MOVE_CURVED_LOCAL)
		{
			if (_optional.path == null)
			{
				_optional.path = new LTBezierPath();
			}
			_optional.path.orientToPath = doesOrient;
		}
		else
		{
			_optional.spline.orientToPath = doesOrient;
		}
		return this;
	}

	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		setOrientToPath(doesOrient2d);
		if (type == TweenAction.MOVE_CURVED || type == TweenAction.MOVE_CURVED_LOCAL)
		{
			_optional.path.orientToPath2d = doesOrient2d;
		}
		else
		{
			_optional.spline.orientToPath2d = doesOrient2d;
		}
		return this;
	}

	public LTDescr setRect(LTRect rect)
	{
		_optional.ltRect = rect;
		return this;
	}

	public LTDescr setRect(Rect rect)
	{
		_optional.ltRect = new LTRect(rect);
		return this;
	}

	public LTDescr setPath(LTBezierPath path)
	{
		_optional.path = path;
		return this;
	}

	public LTDescr setPoint(Vector3 point)
	{
		_optional.point = point;
		return this;
	}

	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		destroyOnComplete = doesDestroy;
		return this;
	}

	public LTDescr setAudio(object audio)
	{
		_optional.onCompleteParam = audio;
		return this;
	}

	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		onCompleteOnRepeat = isOn;
		return this;
	}

	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		onCompleteOnStart = isOn;
		return this;
	}

	public LTDescr setRect(RectTransform rect)
	{
		rectTransform = rect;
		return this;
	}

	public LTDescr setSprites(Sprite[] sprites)
	{
		this.sprites = sprites;
		return this;
	}

	public LTDescr setFrameRate(float frameRate)
	{
		time = (float)sprites.Length / frameRate;
		return this;
	}

	public LTDescr setOnStart(Action onStart)
	{
		_optional.onStart = onStart;
		return this;
	}

	public LTDescr setDirection(float direction)
	{
		if (this.direction != -1f && this.direction != 1f)
		{
			Debug.LogWarning("You have passed an incorrect direction of '" + direction + "', direction must be -1f or 1f");
			return this;
		}
		if (this.direction != direction)
		{
			if (hasInitiliazed)
			{
				this.direction = direction;
			}
			else if (_optional.path != null)
			{
				_optional.path = new LTBezierPath(LTUtility.reverse(_optional.path.pts));
			}
			else if (_optional.spline != null)
			{
				_optional.spline = new LTSpline(LTUtility.reverse(_optional.spline.pts));
			}
		}
		return this;
	}

	public LTDescr setRecursive(bool useRecursion)
	{
		this.useRecursion = useRecursion;
		return this;
	}
}
public class LTDescrOptional
{
	public AnimationCurve animationCurve;

	public int initFrameCount;

	public Transform toTrans { get; set; }

	public Vector3 point { get; set; }

	public Vector3 axis { get; set; }

	public float lastVal { get; set; }

	public Quaternion origRotation { get; set; }

	public LTBezierPath path { get; set; }

	public LTSpline spline { get; set; }

	public LTRect ltRect { get; set; }

	public Action<float> onUpdateFloat { get; set; }

	public Action<float, float> onUpdateFloatRatio { get; set; }

	public Action<float, object> onUpdateFloatObject { get; set; }

	public Action<Vector2> onUpdateVector2 { get; set; }

	public Action<Vector3> onUpdateVector3 { get; set; }

	public Action<Vector3, object> onUpdateVector3Object { get; set; }

	public Action<UnityEngine.Color> onUpdateColor { get; set; }

	public Action<UnityEngine.Color, object> onUpdateColorObject { get; set; }

	public Action onComplete { get; set; }

	public Action<object> onCompleteObject { get; set; }

	public object onCompleteParam { get; set; }

	public object onUpdateParam { get; set; }

	public Action onStart { get; set; }

	public void reset()
	{
		animationCurve = null;
		onUpdateFloat = null;
		onUpdateFloatRatio = null;
		onUpdateVector2 = null;
		onUpdateVector3 = null;
		onUpdateFloatObject = null;
		onUpdateVector3Object = null;
		onUpdateColor = null;
		onComplete = null;
		onCompleteObject = null;
		onCompleteParam = null;
		onStart = null;
		point = Vector3.zero;
		initFrameCount = 0;
	}

	public void callOnUpdate(float val, float ratioPassed)
	{
		if (onUpdateFloat != null)
		{
			onUpdateFloat(val);
		}
		if (onUpdateFloatRatio != null)
		{
			onUpdateFloatRatio(val, ratioPassed);
		}
		else if (onUpdateFloatObject != null)
		{
			onUpdateFloatObject(val, onUpdateParam);
		}
		else if (onUpdateVector3Object != null)
		{
			onUpdateVector3Object(LTDescr.newVect, onUpdateParam);
		}
		else if (onUpdateVector3 != null)
		{
			onUpdateVector3(LTDescr.newVect);
		}
		else if (onUpdateVector2 != null)
		{
			onUpdateVector2(new Vector2(LTDescr.newVect.x, LTDescr.newVect.y));
		}
	}
}
public class LTSeq
{
	public LTSeq previous;

	public LTSeq current;

	public LTDescr tween;

	public float totalDelay;

	public float timeScale;

	private int debugIter;

	public uint counter;

	public bool toggle;

	private uint _id;

	public int id => (int)(_id | (counter << 16));

	public void reset()
	{
		previous = null;
		tween = null;
		totalDelay = 0f;
	}

	public void init(uint id, uint global_counter)
	{
		reset();
		_id = id;
		counter = global_counter;
		current = this;
	}

	private LTSeq addOn()
	{
		current.toggle = true;
		LTSeq lTSeq = current;
		current = LeanTween.sequence(initSequence: false);
		current.previous = lTSeq;
		lTSeq.toggle = false;
		current.totalDelay = lTSeq.totalDelay;
		current.debugIter = lTSeq.debugIter + 1;
		return current;
	}

	private float addPreviousDelays()
	{
		LTSeq lTSeq = current.previous;
		if (lTSeq != null && lTSeq.tween != null)
		{
			return current.totalDelay + lTSeq.tween.time;
		}
		return current.totalDelay;
	}

	public LTSeq append(float delay)
	{
		current.totalDelay += delay;
		return current;
	}

	public LTSeq append(Action callback)
	{
		LTDescr lTDescr = LeanTween.delayedCall(0f, callback);
		append(lTDescr);
		return addOn();
	}

	public LTSeq append(Action<object> callback, object obj)
	{
		append(LeanTween.delayedCall(0f, callback).setOnCompleteParam(obj));
		return addOn();
	}

	public LTSeq append(GameObject gameObject, Action callback)
	{
		append(LeanTween.delayedCall(gameObject, 0f, callback));
		return addOn();
	}

	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		append(LeanTween.delayedCall(gameObject, 0f, callback).setOnCompleteParam(obj));
		return addOn();
	}

	public LTSeq append(LTDescr tween)
	{
		current.tween = tween;
		current.totalDelay = addPreviousDelays();
		tween.setDelay(current.totalDelay);
		return addOn();
	}

	public LTSeq insert(LTDescr tween)
	{
		current.tween = tween;
		tween.setDelay(addPreviousDelays());
		return addOn();
	}

	public LTSeq setScale(float timeScale)
	{
		setScaleRecursive(current, timeScale, 500);
		return addOn();
	}

	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
		if (count <= 0)
		{
			return;
		}
		this.timeScale = timeScale;
		seq.totalDelay *= timeScale;
		if (seq.tween != null)
		{
			if (seq.tween.time != 0f)
			{
				seq.tween.setTime(seq.tween.time * timeScale);
			}
			seq.tween.setDelay(seq.tween.delay * timeScale);
		}
		if (seq.previous != null)
		{
			setScaleRecursive(seq.previous, timeScale, count - 1);
		}
	}

	public LTSeq reverse()
	{
		return addOn();
	}
}
namespace UnityStandardAssets.ImageEffects
{
	public enum AAMode
	{
		FXAA2,
		FXAA3Console,
		FXAA1PresetA,
		FXAA1PresetB,
		NFAA,
		SSAA,
		DLAA
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Antialiasing")]
	public class Antialiasing : PostEffectsBase
	{
		public AAMode mode = AAMode.FXAA3Console;

		public bool showGeneratedNormals;

		public float offsetScale = 0.2f;

		public float blurRadius = 18f;

		public float edgeThresholdMin = 0.05f;

		public float edgeThreshold = 0.2f;

		public float edgeSharpness = 4f;

		public bool dlaaSharp;

		public Shader ssaaShader;

		private Material ssaa;

		public Shader dlaaShader;

		private Material dlaa;

		public Shader nfaaShader;

		private Material nfaa;

		public Shader shaderFXAAPreset2;

		private Material materialFXAAPreset2;

		public Shader shaderFXAAPreset3;

		private Material materialFXAAPreset3;

		public Shader shaderFXAAII;

		private Material materialFXAAII;

		public Shader shaderFXAAIII;

		private Material materialFXAAIII;

		public Material CurrentAAMaterial()
		{
			Material material = null;
			return mode switch
			{
				AAMode.FXAA3Console => materialFXAAIII, 
				AAMode.FXAA2 => materialFXAAII, 
				AAMode.FXAA1PresetA => materialFXAAPreset2, 
				AAMode.FXAA1PresetB => materialFXAAPreset3, 
				AAMode.NFAA => nfaa, 
				AAMode.SSAA => ssaa, 
				AAMode.DLAA => dlaa, 
				_ => null, 
			};
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			materialFXAAPreset2 = CreateMaterial(shaderFXAAPreset2, materialFXAAPreset2);
			materialFXAAPreset3 = CreateMaterial(shaderFXAAPreset3, materialFXAAPreset3);
			materialFXAAII = CreateMaterial(shaderFXAAII, materialFXAAII);
			materialFXAAIII = CreateMaterial(shaderFXAAIII, materialFXAAIII);
			nfaa = CreateMaterial(nfaaShader, nfaa);
			ssaa = CreateMaterial(ssaaShader, ssaa);
			dlaa = CreateMaterial(dlaaShader, dlaa);
			if (!ssaaShader.isSupported)
			{
				NotSupported();
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
			}
			else if (mode == AAMode.FXAA3Console && materialFXAAIII != null)
			{
				materialFXAAIII.SetFloat("_EdgeThresholdMin", edgeThresholdMin);
				materialFXAAIII.SetFloat("_EdgeThreshold", edgeThreshold);
				materialFXAAIII.SetFloat("_EdgeSharpness", edgeSharpness);
				Graphics.Blit(source, destination, materialFXAAIII);
			}
			else if (mode == AAMode.FXAA1PresetB && materialFXAAPreset3 != null)
			{
				Graphics.Blit(source, destination, materialFXAAPreset3);
			}
			else if (mode == AAMode.FXAA1PresetA && materialFXAAPreset2 != null)
			{
				source.anisoLevel = 4;
				Graphics.Blit(source, destination, materialFXAAPreset2);
				source.anisoLevel = 0;
			}
			else if (mode == AAMode.FXAA2 && materialFXAAII != null)
			{
				Graphics.Blit(source, destination, materialFXAAII);
			}
			else if (mode == AAMode.SSAA && ssaa != null)
			{
				Graphics.Blit(source, destination, ssaa);
			}
			else if (mode == AAMode.DLAA && dlaa != null)
			{
				source.anisoLevel = 0;
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height);
				Graphics.Blit(source, temporary, dlaa, 0);
				Graphics.Blit(temporary, destination, dlaa, (!dlaaSharp) ? 1 : 2);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (mode == AAMode.NFAA && nfaa != null)
			{
				source.anisoLevel = 0;
				nfaa.SetFloat("_OffsetScale", offsetScale);
				nfaa.SetFloat("_BlurRadius", blurRadius);
				Graphics.Blit(source, destination, nfaa, showGeneratedNormals ? 1 : 0);
			}
			else
			{
				Graphics.Blit(source, destination);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		public enum LensFlareStyle
		{
			Ghosting,
			Anamorphic,
			Combined
		}

		public enum TweakMode
		{
			Basic,
			Complex
		}

		public enum HDRBloomMode
		{
			Auto,
			On,
			Off
		}

		public enum BloomScreenBlendMode
		{
			Screen,
			Add
		}

		public enum BloomQuality
		{
			Cheap,
			High
		}

		public TweakMode tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 2.5f;

		public BloomQuality quality = BloomQuality.High;

		public float bloomIntensity = 0.5f;

		public float bloomThreshold = 0.5f;

		public UnityEngine.Color bloomThresholdColor = UnityEngine.Color.white;

		public int bloomBlurIterations = 2;

		public int hollywoodFlareBlurIterations = 2;

		public float flareRotation;

		public LensFlareStyle lensflareMode = LensFlareStyle.Anamorphic;

		public float hollyStretchWidth = 2.5f;

		public float lensflareIntensity;

		public float lensflareThreshold = 0.3f;

		public float lensFlareSaturation = 0.75f;

		public UnityEngine.Color flareColorA = new UnityEngine.Color(0.4f, 0.4f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorB = new UnityEngine.Color(0.4f, 0.8f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorC = new UnityEngine.Color(0.8f, 0.4f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorD = new UnityEngine.Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader blurAndFlaresShader;

		private Material blurAndFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			blurAndFlaresMaterial = CheckShaderAndCreateMaterial(blurAndFlaresShader, blurAndFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode bloomScreenBlendMode = screenBlendMode;
			if (doHdr)
			{
				bloomScreenBlendMode = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			int width = source.width / 2;
			int height = source.height / 2;
			int width2 = source.width / 4;
			int height2 = source.height / 4;
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width2, height2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format);
			if (quality > BloomQuality.Cheap)
			{
				Graphics.Blit(source, temporary2, screenBlend, 2);
				RenderTexture temporary3 = RenderTexture.GetTemporary(width2, height2, 0, format);
				Graphics.Blit(temporary2, temporary3, screenBlend, 2);
				Graphics.Blit(temporary3, temporary, screenBlend, 6);
				RenderTexture.ReleaseTemporary(temporary3);
			}
			else
			{
				Graphics.Blit(source, temporary2);
				Graphics.Blit(temporary2, temporary, screenBlend, 6);
			}
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width2, height2, 0, format);
			BrightFilter(bloomThreshold * bloomThresholdColor, temporary, renderTexture);
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			else if (bloomBlurIterations > 10)
			{
				bloomBlurIterations = 10;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.25f) * sepBlurSpread;
				RenderTexture temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				temporary4 = RenderTexture.GetTemporary(width2, height2, 0, format);
				blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary4, blurAndFlaresMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary4;
				if (quality > BloomQuality.Cheap)
				{
					if (i == 0)
					{
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
						Graphics.Blit(renderTexture, temporary);
					}
					else
					{
						temporary.MarkRestoreExpected();
						Graphics.Blit(renderTexture, temporary, screenBlend, 10);
					}
				}
			}
			if (quality > BloomQuality.Cheap)
			{
				Graphics.SetRenderTarget(renderTexture);
				GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
				Graphics.Blit(temporary, renderTexture, screenBlend, 6);
			}
			if (lensflareIntensity > Mathf.Epsilon)
			{
				RenderTexture temporary5 = RenderTexture.GetTemporary(width2, height2, 0, format);
				if (lensflareMode == LensFlareStyle.Ghosting)
				{
					BrightFilter(lensflareThreshold, renderTexture, temporary5);
					if (quality > BloomQuality.Cheap)
					{
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f / (1f * (float)temporary.height), 0f, 0f));
						Graphics.SetRenderTarget(temporary);
						GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(1.5f / (1f * (float)temporary.width), 0f, 0f, 0f));
						Graphics.SetRenderTarget(temporary5);
						GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
					}
					Vignette(0.975f, temporary5, temporary5);
					BlendFlares(temporary5, renderTexture);
				}
				else
				{
					float num4 = 1f * Mathf.Cos(flareRotation);
					float num5 = 1f * Mathf.Sin(flareRotation);
					float num6 = hollyStretchWidth * 1f / num * num2;
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4, num5, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_Threshhold", new Vector4(lensflareThreshold, 1f, 0f, 0f));
					blurAndFlaresMaterial.SetVector("_TintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					blurAndFlaresMaterial.SetFloat("_Saturation", lensFlareSaturation);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 2);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 3);
					blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num4 * num6, num5 * num6, 0f, 0f));
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 2f);
					temporary5.DiscardContents();
					Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 1);
					blurAndFlaresMaterial.SetFloat("_StretchWidth", hollyStretchWidth * 4f);
					temporary.DiscardContents();
					Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 1);
					for (int j = 0; j < hollywoodFlareBlurIterations; j++)
					{
						num6 = hollyStretchWidth * 2f / num * num2;
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary5.DiscardContents();
						Graphics.Blit(temporary, temporary5, blurAndFlaresMaterial, 4);
						blurAndFlaresMaterial.SetVector("_Offsets", new Vector4(num6 * num4, num6 * num5, 0f, 0f));
						temporary.DiscardContents();
						Graphics.Blit(temporary5, temporary, blurAndFlaresMaterial, 4);
					}
					if (lensflareMode == LensFlareStyle.Anamorphic)
					{
						AddTo(1f, temporary, renderTexture);
					}
					else
					{
						Vignette(1f, temporary, temporary5);
						BlendFlares(temporary5, temporary);
						AddTo(1f, temporary, renderTexture);
					}
				}
				RenderTexture.ReleaseTemporary(temporary5);
			}
			int pass = (int)bloomScreenBlendMode;
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			if (quality > BloomQuality.Cheap)
			{
				RenderTexture temporary6 = RenderTexture.GetTemporary(width, height, 0, format);
				Graphics.Blit(renderTexture, temporary6);
				Graphics.Blit(temporary6, destination, screenBlend, pass);
				RenderTexture.ReleaseTemporary(temporary6);
			}
			else
			{
				Graphics.Blit(renderTexture, destination, screenBlend, pass);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			screenBlend.SetFloat("_Intensity", intensity_);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, screenBlend, 9);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			to.MarkRestoreExpected();
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", new Vector4(thresh, thresh, thresh, thresh));
			Graphics.Blit(from, to, brightPassFilterMaterial, 0);
		}

		private void BrightFilter(UnityEngine.Color threshColor, RenderTexture from, RenderTexture to)
		{
			brightPassFilterMaterial.SetVector("_Threshhold", threshColor);
			Graphics.Blit(from, to, brightPassFilterMaterial, 1);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				to.MarkRestoreExpected();
				Graphics.Blit((from == to) ? null : from, to, screenBlend, (from == to) ? 7 : 3);
			}
			else if (from != to)
			{
				Graphics.SetRenderTarget(to);
				GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
				Graphics.Blit(from, to);
			}
		}
	}
	public enum LensflareStyle34
	{
		Ghosting,
		Anamorphic,
		Combined
	}
	public enum TweakMode34
	{
		Basic,
		Complex
	}
	public enum HDRBloomMode
	{
		Auto,
		On,
		Off
	}
	public enum BloomScreenBlendMode
	{
		Screen,
		Add
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	public class BloomAndFlares : PostEffectsBase
	{
		public TweakMode34 tweakMode;

		public BloomScreenBlendMode screenBlendMode = BloomScreenBlendMode.Add;

		public HDRBloomMode hdr;

		private bool doHdr;

		public float sepBlurSpread = 1.5f;

		public float useSrcAlphaAsMask = 0.5f;

		public float bloomIntensity = 1f;

		public float bloomThreshold = 0.5f;

		public int bloomBlurIterations = 2;

		public bool lensflares;

		public int hollywoodFlareBlurIterations = 2;

		public LensflareStyle34 lensflareMode = LensflareStyle34.Anamorphic;

		public float hollyStretchWidth = 3.5f;

		public float lensflareIntensity = 1f;

		public float lensflareThreshold = 0.3f;

		public UnityEngine.Color flareColorA = new UnityEngine.Color(0.4f, 0.4f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorB = new UnityEngine.Color(0.4f, 0.8f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorC = new UnityEngine.Color(0.8f, 0.4f, 0.8f, 0.75f);

		public UnityEngine.Color flareColorD = new UnityEngine.Color(0.8f, 0.4f, 0f, 0.75f);

		public Texture2D lensFlareVignetteMask;

		public Shader lensFlareShader;

		private Material lensFlareMaterial;

		public Shader vignetteShader;

		private Material vignetteMaterial;

		public Shader separableBlurShader;

		private Material separableBlurMaterial;

		public Shader addBrightStuffOneOneShader;

		private Material addBrightStuffBlendOneOneMaterial;

		public Shader screenBlendShader;

		private Material screenBlend;

		public Shader hollywoodFlaresShader;

		private Material hollywoodFlaresMaterial;

		public Shader brightPassFilterShader;

		private Material brightPassFilterMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			screenBlend = CheckShaderAndCreateMaterial(screenBlendShader, screenBlend);
			lensFlareMaterial = CheckShaderAndCreateMaterial(lensFlareShader, lensFlareMaterial);
			vignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, vignetteMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			addBrightStuffBlendOneOneMaterial = CheckShaderAndCreateMaterial(addBrightStuffOneOneShader, addBrightStuffBlendOneOneMaterial);
			hollywoodFlaresMaterial = CheckShaderAndCreateMaterial(hollywoodFlaresShader, hollywoodFlaresMaterial);
			brightPassFilterMaterial = CheckShaderAndCreateMaterial(brightPassFilterShader, brightPassFilterMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			doHdr = false;
			if (hdr == HDRBloomMode.Auto)
			{
				doHdr = source.format == RenderTextureFormat.ARGBHalf && GetComponent<Camera>().allowHDR;
			}
			else
			{
				doHdr = hdr == HDRBloomMode.On;
			}
			doHdr = doHdr && supportHDRTextures;
			BloomScreenBlendMode pass = screenBlendMode;
			if (doHdr)
			{
				pass = BloomScreenBlendMode.Add;
			}
			RenderTextureFormat format = (doHdr ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Default);
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 2, source.height / 2, 0, format);
			RenderTexture temporary2 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			RenderTexture temporary4 = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0, format);
			float num = 1f * (float)source.width / (1f * (float)source.height);
			float num2 = 0.001953125f;
			Graphics.Blit(source, temporary, screenBlend, 2);
			Graphics.Blit(temporary, temporary2, screenBlend, 2);
			RenderTexture.ReleaseTemporary(temporary);
			BrightFilter(bloomThreshold, useSrcAlphaAsMask, temporary2, temporary3);
			temporary2.DiscardContents();
			if (bloomBlurIterations < 1)
			{
				bloomBlurIterations = 1;
			}
			for (int i = 0; i < bloomBlurIterations; i++)
			{
				float num3 = (1f + (float)i * 0.5f) * sepBlurSpread;
				separableBlurMaterial.SetVector("offsets", new Vector4(0f, num3 * num2, 0f, 0f));
				RenderTexture obj = ((i == 0) ? temporary3 : temporary2);
				Graphics.Blit(obj, temporary4, separableBlurMaterial);
				obj.DiscardContents();
				separableBlurMaterial.SetVector("offsets", new Vector4(num3 / num * num2, 0f, 0f, 0f));
				Graphics.Blit(temporary4, temporary2, separableBlurMaterial);
				temporary4.DiscardContents();
			}
			if (lensflares)
			{
				if (lensflareMode == LensflareStyle34.Ghosting)
				{
					BrightFilter(lensflareThreshold, 0f, temporary2, temporary4);
					temporary2.DiscardContents();
					Vignette(0.975f, temporary4, temporary3);
					temporary4.DiscardContents();
					BlendFlares(temporary3, temporary2);
					temporary3.DiscardContents();
				}
				else
				{
					hollywoodFlaresMaterial.SetVector("_threshold", new Vector4(lensflareThreshold, 1f / (1f - lensflareThreshold), 0f, 0f));
					hollywoodFlaresMaterial.SetVector("tintColor", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * flareColorA.a * lensflareIntensity);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 2);
					temporary4.DiscardContents();
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 3);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetVector("offsets", new Vector4(sepBlurSpread * 1f / num * num2, 0f, 0f, 0f));
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 2f);
					Graphics.Blit(temporary3, temporary4, hollywoodFlaresMaterial, 1);
					temporary3.DiscardContents();
					hollywoodFlaresMaterial.SetFloat("stretchWidth", hollyStretchWidth * 4f);
					Graphics.Blit(temporary4, temporary3, hollywoodFlaresMaterial, 1);
					temporary4.DiscardContents();
					if (lensflareMode == LensflareStyle34.Anamorphic)
					{
						for (int j = 0; j < hollywoodFlareBlurIterations; j++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
					else
					{
						for (int k = 0; k < hollywoodFlareBlurIterations; k++)
						{
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary3, temporary4, separableBlurMaterial);
							temporary3.DiscardContents();
							separableBlurMaterial.SetVector("offsets", new Vector4(hollyStretchWidth * 2f / num * num2, 0f, 0f, 0f));
							Graphics.Blit(temporary4, temporary3, separableBlurMaterial);
							temporary4.DiscardContents();
						}
						Vignette(1f, temporary3, temporary4);
						temporary3.DiscardContents();
						BlendFlares(temporary4, temporary3);
						temporary4.DiscardContents();
						AddTo(1f, temporary3, temporary2);
						temporary3.DiscardContents();
					}
				}
			}
			screenBlend.SetFloat("_Intensity", bloomIntensity);
			screenBlend.SetTexture("_ColorBuffer", source);
			Graphics.Blit(temporary2, destination, screenBlend, (int)pass);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
			RenderTexture.ReleaseTemporary(temporary4);
		}

		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
			addBrightStuffBlendOneOneMaterial.SetFloat("_Intensity", intensity_);
			Graphics.Blit(from, to, addBrightStuffBlendOneOneMaterial);
		}

		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
			lensFlareMaterial.SetVector("colorA", new Vector4(flareColorA.r, flareColorA.g, flareColorA.b, flareColorA.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorB", new Vector4(flareColorB.r, flareColorB.g, flareColorB.b, flareColorB.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorC", new Vector4(flareColorC.r, flareColorC.g, flareColorC.b, flareColorC.a) * lensflareIntensity);
			lensFlareMaterial.SetVector("colorD", new Vector4(flareColorD.r, flareColorD.g, flareColorD.b, flareColorD.a) * lensflareIntensity);
			Graphics.Blit(from, to, lensFlareMaterial);
		}

		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
			if (doHdr)
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f, 0f, 0f));
			}
			else
			{
				brightPassFilterMaterial.SetVector("threshold", new Vector4(thresh, 1f / (1f - thresh), 0f, 0f));
			}
			brightPassFilterMaterial.SetFloat("useSrcAlphaAsMask", useAlphaAsMask);
			Graphics.Blit(from, to, brightPassFilterMaterial);
		}

		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
			if ((bool)lensFlareVignetteMask)
			{
				screenBlend.SetTexture("_ColorBuffer", lensFlareVignetteMask);
				Graphics.Blit(from, to, screenBlend, 3);
			}
			else
			{
				vignetteMaterial.SetFloat("vignetteIntensity", amount);
				Graphics.Blit(from, to, vignetteMaterial);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	public class BloomOptimized : PostEffectsBase
	{
		public enum Resolution
		{
			Low,
			High
		}

		public enum BlurType
		{
			Standard,
			Sgx
		}

		[Range(0f, 1.5f)]
		public float threshold = 0.25f;

		[Range(0f, 2.5f)]
		public float intensity = 0.75f;

		[Range(0.25f, 5.5f)]
		public float blurSize = 1f;

		private Resolution resolution;

		[Range(1f, 4f)]
		public int blurIterations = 1;

		public BlurType blurType;

		public Shader fastBloomShader;

		private Material fastBloomMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fastBloomMaterial = CheckShaderAndCreateMaterial(fastBloomShader, fastBloomMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)fastBloomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(fastBloomMaterial);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int num = ((resolution == Resolution.Low) ? 4 : 2);
			float num2 = ((resolution == Resolution.Low) ? 0.5f : 1f);
			fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2, 0f, threshold, intensity));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, fastBloomMaterial, 1);
			int num3 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				fastBloomMaterial.SetVector("_Parameter", new Vector4(blurSize * num2 + (float)i * 1f, 0f, threshold, intensity));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 2 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, fastBloomMaterial, 3 + num3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			fastBloomMaterial.SetTexture("_Bloom", renderTexture);
			Graphics.Blit(source, destination, fastBloomMaterial, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Blur")]
	public class Blur : MonoBehaviour
	{
		[Range(0f, 10f)]
		public int iterations = 3;

		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		public Shader blurShader;

		private static Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(blurShader);
					m_Material.hideFlags = HideFlags.DontSave;
				}
				return m_Material;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!blurShader || !material.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		public void FourTapCone(RenderTexture source, RenderTexture dest, int iteration)
		{
			float num = 0.5f + (float)iteration * blurSpread;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void DownSample4x(RenderTexture source, RenderTexture dest)
		{
			float num = 1f;
			Graphics.BlitMultiTap(source, dest, material, new Vector2(0f - num, 0f - num), new Vector2(0f - num, num), new Vector2(num, num), new Vector2(num, 0f - num));
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			int width = source.width / 4;
			int height = source.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			DownSample4x(source, renderTexture);
			for (int i = 0; i < iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	public class BlurOptimized : PostEffectsBase
	{
		public enum BlurType
		{
			StandardGauss,
			SgxGauss
		}

		[Range(0f, 2f)]
		public int downsample = 1;

		[Range(0f, 10f)]
		public float blurSize = 3f;

		[Range(1f, 4f)]
		public int blurIterations = 2;

		public BlurType blurType;

		public Shader blurShader;

		private Material blurMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void OnDisable()
		{
			if ((bool)blurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(blurMaterial);
			}
		}

		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 1f / (1f * (float)(1 << downsample));
			blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num, (0f - blurSize) * num, 0f, 0f));
			source.filterMode = FilterMode.Bilinear;
			int width = source.width >> downsample;
			int height = source.height >> downsample;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
			renderTexture.filterMode = FilterMode.Bilinear;
			Graphics.Blit(source, renderTexture, blurMaterial, 0);
			int num2 = ((blurType != 0) ? 2 : 0);
			for (int i = 0; i < blurIterations; i++)
			{
				float num3 = (float)i * 1f;
				blurMaterial.SetVector("_Parameter", new Vector4(blurSize * num + num3, (0f - blurSize) * num - num3, 0f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 1 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
				temporary = RenderTexture.GetTemporary(width, height, 0, source.format);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(renderTexture, temporary, blurMaterial, 2 + num2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, destination);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	public class CameraMotionBlur : PostEffectsBase
	{
		public enum MotionBlurFilter
		{
			CameraMotion,
			LocalBlur,
			Reconstruction,
			ReconstructionDX11,
			ReconstructionDisc
		}

		private static float MAX_RADIUS = 10f;

		public MotionBlurFilter filterType = MotionBlurFilter.Reconstruction;

		public bool preview;

		public Vector3 previewScale = Vector3.one;

		public float movementScale;

		public float rotationScale = 1f;

		public float maxVelocity = 8f;

		public float minVelocity = 0.1f;

		public float velocityScale = 0.375f;

		public float softZDistance = 0.005f;

		public int velocityDownsample = 1;

		public LayerMask excludeLayers = 0;

		private GameObject tmpCam;

		public Shader shader;

		public Shader dx11MotionBlurShader;

		public Shader replacementClear;

		private Material motionBlurMaterial;

		private Material dx11MotionBlurMaterial;

		public Texture2D noiseTexture;

		public float jitter = 0.05f;

		public bool showVelocity;

		public float showVelocityScale = 1f;

		private Matrix4x4 currentViewProjMat;

		private Matrix4x4[] currentStereoViewProjMat;

		private Matrix4x4 prevViewProjMat;

		private Matrix4x4[] prevStereoViewProjMat;

		private int prevFrameCount;

		private bool wasActive;

		private Vector3 prevFrameForward = Vector3.forward;

		private Vector3 prevFrameUp = Vector3.up;

		private Vector3 prevFramePos = Vector3.zero;

		private Camera _camera;

		private void CalculateViewProjection()
		{
			Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
			Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
			currentViewProjMat = gPUProjectionMatrix * worldToCameraMatrix;
			if (_camera.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = _camera.GetStereoViewMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 stereoProjectionMatrix = _camera.GetStereoProjectionMatrix((i != 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					stereoProjectionMatrix = GL.GetGPUProjectionMatrix(stereoProjectionMatrix, renderIntoTexture: true);
					currentStereoViewProjMat[i] = stereoProjectionMatrix * stereoViewMatrix;
				}
			}
		}

		private new void Start()
		{
			CheckResources();
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			wasActive = base.gameObject.activeInHierarchy;
			currentStereoViewProjMat = new Matrix4x4[2];
			prevStereoViewProjMat = new Matrix4x4[2];
			CalculateViewProjection();
			Remember();
			wasActive = false;
		}

		private void OnEnable()
		{
			if (_camera == null)
			{
				_camera = GetComponent<Camera>();
			}
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			if (null != motionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(motionBlurMaterial);
				motionBlurMaterial = null;
			}
			if (null != dx11MotionBlurMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11MotionBlurMaterial);
				dx11MotionBlurMaterial = null;
			}
			if (null != tmpCam)
			{
				UnityEngine.Object.DestroyImmediate(tmpCam);
				tmpCam = null;
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true, needHdr: true);
			motionBlurMaterial = CheckShaderAndCreateMaterial(shader, motionBlurMaterial);
			if (supportDX11 && filterType == MotionBlurFilter.ReconstructionDX11)
			{
				dx11MotionBlurMaterial = CheckShaderAndCreateMaterial(dx11MotionBlurShader, dx11MotionBlurMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				StartFrame();
			}
			RenderTextureFormat format = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			RenderTexture temporary = RenderTexture.GetTemporary(divRoundUp(source.width, velocityDownsample), divRoundUp(source.height, velocityDownsample), 0, format);
			int num = 1;
			int num2 = 1;
			maxVelocity = Mathf.Max(2f, maxVelocity);
			float num3 = maxVelocity;
			bool flag = filterType == MotionBlurFilter.ReconstructionDX11 && dx11MotionBlurMaterial == null;
			if (filterType == MotionBlurFilter.Reconstruction || flag || filterType == MotionBlurFilter.ReconstructionDisc)
			{
				maxVelocity = Mathf.Min(maxVelocity, MAX_RADIUS);
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			else
			{
				num = divRoundUp(temporary.width, (int)maxVelocity);
				num2 = divRoundUp(temporary.height, (int)maxVelocity);
				num3 = temporary.width / num;
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, num2, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, num2, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if ((bool)noiseTexture)
			{
				noiseTexture.filterMode = FilterMode.Point;
			}
			source.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			CalculateViewProjection();
			if (base.gameObject.activeInHierarchy && !wasActive)
			{
				Remember();
			}
			wasActive = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(currentViewProjMat);
			motionBlurMaterial.SetMatrix("_InvViewProj", matrix4x);
			motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
			motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			if (_camera.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2]
				{
					Matrix4x4.Inverse(currentStereoViewProjMat[0]),
					Matrix4x4.Inverse(currentStereoViewProjMat[1])
				};
				Matrix4x4 value = prevStereoViewProjMat[0] * array[0];
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined0", value);
				motionBlurMaterial.SetMatrix("_StereoToPrevViewProjCombined1", prevStereoViewProjMat[1] * array[1]);
			}
			motionBlurMaterial.SetFloat("_MaxVelocity", num3);
			motionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
			motionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
			motionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
			motionBlurMaterial.SetFloat("_Jitter", jitter);
			motionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
			motionBlurMaterial.SetTexture("_VelTex", temporary);
			motionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
			motionBlurMaterial.SetTexture("_TileTexDebug", temporary2);
			if (preview)
			{
				Matrix4x4 worldToCameraMatrix = _camera.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gPUProjectionMatrix = GL.GetGPUProjectionMatrix(_camera.projectionMatrix, renderIntoTexture: true);
				prevViewProjMat = gPUProjectionMatrix * identity * worldToCameraMatrix;
				motionBlurMaterial.SetMatrix("_PrevViewProj", prevViewProjMat);
				motionBlurMaterial.SetMatrix("_ToPrevViewProjCombined", prevViewProjMat * matrix4x);
			}
			if (filterType == MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num4 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = prevFramePos - base.transform.position;
				float magnitude = rhs.magnitude;
				float num5 = 1f;
				num5 = Vector3.Angle(base.transform.up, prevFrameUp) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.x = rotationScale * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.y = rotationScale * num4 * num5;
				num5 = Vector3.Angle(base.transform.forward, prevFrameForward) / _camera.fieldOfView * ((float)source.width * 0.75f);
				zero.z = rotationScale * (1f - num4) * num5;
				if (magnitude > Mathf.Epsilon && movementScale > Mathf.Epsilon)
				{
					zero.w = movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)source.width * 0.5f);
					zero.x += movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)source.width * 0.5f);
					zero.y += movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)source.width * 0.5f);
				}
				if (preview)
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", new Vector4(previewScale.y, previewScale.x, 0f, previewScale.z) * 0.5f * _camera.fieldOfView);
				}
				else
				{
					motionBlurMaterial.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(source, temporary, motionBlurMaterial, 0);
				Camera camera = null;
				if (excludeLayers.value != 0)
				{
					camera = GetTmpCam();
				}
				if ((bool)camera && excludeLayers.value != 0 && (bool)replacementClear && replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = excludeLayers;
					camera.RenderWithShader(replacementClear, "");
				}
			}
			if (!preview && Time.frameCount != prevFrameCount)
			{
				prevFrameCount = Time.frameCount;
				Remember();
			}
			source.filterMode = FilterMode.Bilinear;
			if (showVelocity)
			{
				motionBlurMaterial.SetFloat("_DisplayVelocityScale", showVelocityScale);
				Graphics.Blit(temporary, destination, motionBlurMaterial, 1);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				dx11MotionBlurMaterial.SetFloat("_MinVelocity", minVelocity);
				dx11MotionBlurMaterial.SetFloat("_VelocityScale", velocityScale);
				dx11MotionBlurMaterial.SetFloat("_Jitter", jitter);
				dx11MotionBlurMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11MotionBlurMaterial.SetTexture("_VelTex", temporary);
				dx11MotionBlurMaterial.SetTexture("_NeighbourMaxTex", temporary3);
				dx11MotionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				dx11MotionBlurMaterial.SetFloat("_MaxRadiusOrKInPaper", num3);
				Graphics.Blit(temporary, temporary2, dx11MotionBlurMaterial, 0);
				Graphics.Blit(temporary2, temporary3, dx11MotionBlurMaterial, 1);
				Graphics.Blit(source, destination, dx11MotionBlurMaterial, 2);
			}
			else if (filterType == MotionBlurFilter.Reconstruction || flag)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 4);
			}
			else if (filterType == MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 6);
			}
			else if (filterType == MotionBlurFilter.ReconstructionDisc)
			{
				motionBlurMaterial.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, softZDistance));
				Graphics.Blit(temporary, temporary2, motionBlurMaterial, 2);
				Graphics.Blit(temporary2, temporary3, motionBlurMaterial, 3);
				Graphics.Blit(source, destination, motionBlurMaterial, 7);
			}
			else
			{
				Graphics.Blit(source, destination, motionBlurMaterial, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		private void Remember()
		{
			prevViewProjMat = currentViewProjMat;
			prevFrameForward = base.transform.forward;
			prevFrameUp = base.transform.up;
			prevFramePos = base.transform.position;
			prevStereoViewProjMat[0] = currentStereoViewProjMat[0];
			prevStereoViewProjMat[1] = currentStereoViewProjMat[1];
		}

		private Camera GetTmpCam()
		{
			if (tmpCam == null)
			{
				string text = "_" + _camera.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					tmpCam = new GameObject(text, typeof(Camera));
				}
				else
				{
					tmpCam = gameObject;
				}
			}
			tmpCam.hideFlags = HideFlags.DontSave;
			tmpCam.transform.position = _camera.transform.position;
			tmpCam.transform.rotation = _camera.transform.rotation;
			tmpCam.transform.localScale = _camera.transform.localScale;
			tmpCam.GetComponent<Camera>().CopyFrom(_camera);
			tmpCam.GetComponent<Camera>().enabled = false;
			tmpCam.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			tmpCam.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return tmpCam.GetComponent<Camera>();
		}

		private void StartFrame()
		{
			prevFramePos = Vector3.Slerp(prevFramePos, base.transform.position, 0.75f);
		}

		private static int divRoundUp(int x, int d)
		{
			return (x + d - 1) / d;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		public enum ColorCorrectionMode
		{
			Simple,
			Advanced
		}

		public AnimationCurve redChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve greenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve blueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public bool useDepthCorrection;

		public AnimationCurve zCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthRedChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthGreenChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		public AnimationCurve depthBlueChannel = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(1f, 1f));

		private Material ccMaterial;

		private Material ccDepthMaterial;

		private Material selectiveCcMaterial;

		private Texture2D rgbChannelTex;

		private Texture2D rgbDepthChannelTex;

		private Texture2D zCurveTex;

		public float saturation = 1f;

		public bool selectiveCc;

		public UnityEngine.Color selectiveFromColor = UnityEngine.Color.white;

		public UnityEngine.Color selectiveToColor = UnityEngine.Color.white;

		public ColorCorrectionMode mode;

		public bool updateTextures = true;

		public Shader colorCorrectionCurvesShader;

		public Shader simpleColorCorrectionCurvesShader;

		public Shader colorCorrectionSelectiveShader;

		private bool updateTexturesOnStartup = true;

		private new void Start()
		{
			base.Start();
			updateTexturesOnStartup = true;
		}

		private void Awake()
		{
		}

		public override bool CheckResources()
		{
			CheckSupport(mode == ColorCorrectionMode.Advanced);
			ccMaterial = CheckShaderAndCreateMaterial(simpleColorCorrectionCurvesShader, ccMaterial);
			ccDepthMaterial = CheckShaderAndCreateMaterial(colorCorrectionCurvesShader, ccDepthMaterial);
			selectiveCcMaterial = CheckShaderAndCreateMaterial(colorCorrectionSelectiveShader, selectiveCcMaterial);
			if (!rgbChannelTex)
			{
				rgbChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!rgbDepthChannelTex)
			{
				rgbDepthChannelTex = new Texture2D(256, 4, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			if (!zCurveTex)
			{
				zCurveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
			}
			rgbChannelTex.hideFlags = HideFlags.DontSave;
			rgbDepthChannelTex.hideFlags = HideFlags.DontSave;
			zCurveTex.hideFlags = HideFlags.DontSave;
			rgbChannelTex.wrapMode = TextureWrapMode.Clamp;
			rgbDepthChannelTex.wrapMode = TextureWrapMode.Clamp;
			zCurveTex.wrapMode = TextureWrapMode.Clamp;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public void UpdateParameters()
		{
			CheckResources();
			if (redChannel != null && greenChannel != null && blueChannel != null)
			{
				for (float num = 0f; num <= 1f; num += 0.003921569f)
				{
					float num2 = Mathf.Clamp(redChannel.Evaluate(num), 0f, 1f);
					float num3 = Mathf.Clamp(greenChannel.Evaluate(num), 0f, 1f);
					float num4 = Mathf.Clamp(blueChannel.Evaluate(num), 0f, 1f);
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new UnityEngine.Color(num2, num2, num2));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new UnityEngine.Color(num3, num3, num3));
					rgbChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new UnityEngine.Color(num4, num4, num4));
					float num5 = Mathf.Clamp(zCurve.Evaluate(num), 0f, 1f);
					zCurveTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new UnityEngine.Color(num5, num5, num5));
					num2 = Mathf.Clamp(depthRedChannel.Evaluate(num), 0f, 1f);
					num3 = Mathf.Clamp(depthGreenChannel.Evaluate(num), 0f, 1f);
					num4 = Mathf.Clamp(depthBlueChannel.Evaluate(num), 0f, 1f);
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 0, new UnityEngine.Color(num2, num2, num2));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 1, new UnityEngine.Color(num3, num3, num3));
					rgbDepthChannelTex.SetPixel((int)Mathf.Floor(num * 255f), 2, new UnityEngine.Color(num4, num4, num4));
				}
				rgbChannelTex.Apply();
				rgbDepthChannelTex.Apply();
				zCurveTex.Apply();
			}
		}

		private void UpdateTextures()
		{
			UpdateParameters();
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (updateTexturesOnStartup)
			{
				UpdateParameters();
				updateTexturesOnStartup = false;
			}
			if (useDepthCorrection)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			RenderTexture renderTexture = destination;
			if (selectiveCc)
			{
				renderTexture = RenderTexture.GetTemporary(source.width, source.height);
			}
			if (useDepthCorrection)
			{
				ccDepthMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccDepthMaterial.SetTexture("_ZCurve", zCurveTex);
				ccDepthMaterial.SetTexture("_RgbDepthTex", rgbDepthChannelTex);
				ccDepthMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccDepthMaterial);
			}
			else
			{
				ccMaterial.SetTexture("_RgbTex", rgbChannelTex);
				ccMaterial.SetFloat("_Saturation", saturation);
				Graphics.Blit(source, renderTexture, ccMaterial);
			}
			if (selectiveCc)
			{
				selectiveCcMaterial.SetColor("selColor", selectiveFromColor);
				selectiveCcMaterial.SetColor("targetColor", selectiveToColor);
				Graphics.Blit(renderTexture, destination, selectiveCcMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		public Shader shader;

		private Material material;

		public Texture3D converted3DLut;

		public string basedOnTempTex = "";

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			material = CheckShaderAndCreateMaterial(shader, material);
			if (!isSupported || !SystemInfo.supports3DTextures)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)material)
			{
				UnityEngine.Object.DestroyImmediate(material);
				material = null;
			}
		}

		private void OnDestroy()
		{
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = null;
		}

		public void SetIdentityLut()
		{
			int num = 16;
			UnityEngine.Color[] array = new UnityEngine.Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new UnityEngine.Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if ((bool)converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(converted3DLut);
			}
			converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
			converted3DLut.SetPixels(array);
			converted3DLut.Apply();
			basedOnTempTex = "";
		}

		public bool ValidDimensions(Texture2D tex2d)
		{
			if (!tex2d)
			{
				return false;
			}
			if (tex2d.height != Mathf.FloorToInt(Mathf.Sqrt(tex2d.width)))
			{
				return false;
			}
			return true;
		}

		public void Convert(Texture2D temp2DTex, string path)
		{
			if ((bool)temp2DTex)
			{
				int num = temp2DTex.width * temp2DTex.height;
				num = temp2DTex.height;
				if (!ValidDimensions(temp2DTex))
				{
					Debug.LogWarning("The given 2D texture " + temp2DTex.name + " cannot be used as a 3D LUT.");
					basedOnTempTex = "";
					return;
				}
				UnityEngine.Color[] pixels = temp2DTex.GetPixels();
				UnityEngine.Color[] array = new UnityEngine.Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if ((bool)converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(converted3DLut);
				}
				converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, mipChain: false);
				converted3DLut.SetPixels(array);
				converted3DLut.Apply();
				basedOnTempTex = path;
			}
			else
			{
				Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (converted3DLut == null)
			{
				SetIdentityLut();
			}
			int width = converted3DLut.width;
			converted3DLut.wrapMode = TextureWrapMode.Clamp;
			material.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			material.SetFloat("_Offset", 1f / (2f * (float)width));
			material.SetTexture("_ClutTex", converted3DLut);
			Graphics.Blit(source, destination, material, (QualitySettings.activeColorSpace == ColorSpace.Linear) ? 1 : 0);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Ramp)")]
	public class ColorCorrectionRamp : ImageEffectBase
	{
		public Texture textureRamp;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	public class ContrastEnhance : PostEffectsBase
	{
		[Range(0f, 1f)]
		public float intensity = 0.5f;

		[Range(0f, 0.999f)]
		public float threshold;

		private Material separableBlurMaterial;

		private Material contrastCompositeMaterial;

		[Range(0f, 1f)]
		public float blurSpread = 1f;

		public Shader separableBlurShader;

		public Shader contrastCompositeShader;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			contrastCompositeMaterial = CheckShaderAndCreateMaterial(contrastCompositeShader, contrastCompositeMaterial);
			separableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, separableBlurMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary, temporary2);
			RenderTexture.ReleaseTemporary(temporary);
			separableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 1f / (float)temporary2.height, 0f, 0f));
			RenderTexture temporary3 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary2, temporary3, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
			separableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 1f / (float)temporary2.width, 0f, 0f, 0f));
			temporary2 = RenderTexture.GetTemporary(width / 4, height / 4, 0);
			Graphics.Blit(temporary3, temporary2, separableBlurMaterial);
			RenderTexture.ReleaseTemporary(temporary3);
			contrastCompositeMaterial.SetTexture("_MainTexBlurred", temporary2);
			contrastCompositeMaterial.SetFloat("intensity", intensity);
			contrastCompositeMaterial.SetFloat("threshold", threshold);
			Graphics.Blit(source, destination, contrastCompositeMaterial);
			RenderTexture.ReleaseTemporary(temporary2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
	public class ContrastStretch : MonoBehaviour
	{
		[Range(0.0001f, 1f)]
		public float adaptationSpeed = 0.02f;

		[Range(0f, 1f)]
		public float limitMinimum = 0.2f;

		[Range(0f, 1f)]
		public float limitMaximum = 0.6f;

		private RenderTexture[] adaptRenderTex = new RenderTexture[2];

		private int curAdaptIndex;

		public Shader shaderLum;

		private Material m_materialLum;

		public Shader shaderReduce;

		private Material m_materialReduce;

		public Shader shaderAdapt;

		private Material m_materialAdapt;

		public Shader shaderApply;

		private Material m_materialApply;

		protected Material materialLum
		{
			get
			{
				if (m_materialLum == null)
				{
					m_materialLum = new Material(shaderLum);
					m_materialLum.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialLum;
			}
		}

		protected Material materialReduce
		{
			get
			{
				if (m_materialReduce == null)
				{
					m_materialReduce = new Material(shaderReduce);
					m_materialReduce.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialReduce;
			}
		}

		protected Material materialAdapt
		{
			get
			{
				if (m_materialAdapt == null)
				{
					m_materialAdapt = new Material(shaderAdapt);
					m_materialAdapt.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialAdapt;
			}
		}

		protected Material materialApply
		{
			get
			{
				if (m_materialApply == null)
				{
					m_materialApply = new Material(shaderApply);
					m_materialApply.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_materialApply;
			}
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shaderAdapt.isSupported || !shaderApply.isSupported || !shaderLum.isSupported || !shaderReduce.isSupported)
			{
				base.enabled = false;
			}
		}

		private void OnEnable()
		{
			for (int i = 0; i < 2; i++)
			{
				if (!adaptRenderTex[i])
				{
					adaptRenderTex[i] = new RenderTexture(1, 1, 0);
					adaptRenderTex[i].hideFlags = HideFlags.HideAndDontSave;
				}
			}
		}

		private void OnDisable()
		{
			for (int i = 0; i < 2; i++)
			{
				UnityEngine.Object.DestroyImmediate(adaptRenderTex[i]);
				adaptRenderTex[i] = null;
			}
			if ((bool)m_materialLum)
			{
				UnityEngine.Object.DestroyImmediate(m_materialLum);
			}
			if ((bool)m_materialReduce)
			{
				UnityEngine.Object.DestroyImmediate(m_materialReduce);
			}
			if ((bool)m_materialAdapt)
			{
				UnityEngine.Object.DestroyImmediate(m_materialAdapt);
			}
			if ((bool)m_materialApply)
			{
				UnityEngine.Object.DestroyImmediate(m_materialApply);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / 1, source.height / 1);
			Graphics.Blit(source, renderTexture, materialLum);
			while (renderTexture.width > 1 || renderTexture.height > 1)
			{
				int num = renderTexture.width / 2;
				if (num < 1)
				{
					num = 1;
				}
				int num2 = renderTexture.height / 2;
				if (num2 < 1)
				{
					num2 = 1;
				}
				RenderTexture temporary = RenderTexture.GetTemporary(num, num2);
				Graphics.Blit(renderTexture, temporary, materialReduce);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			CalculateAdaptation(renderTexture);
			materialApply.SetTexture("_AdaptTex", adaptRenderTex[curAdaptIndex]);
			Graphics.Blit(source, destination, materialApply);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		private void CalculateAdaptation(Texture curTexture)
		{
			int num = curAdaptIndex;
			curAdaptIndex = (curAdaptIndex + 1) % 2;
			float value = 1f - Mathf.Pow(1f - adaptationSpeed, 30f * Time.deltaTime);
			value = Mathf.Clamp(value, 0.01f, 1f);
			materialAdapt.SetTexture("_CurTex", curTexture);
			materialAdapt.SetVector("_AdaptParams", new Vector4(value, limitMinimum, limitMaximum, 0f));
			Graphics.SetRenderTarget(adaptRenderTex[curAdaptIndex]);
			GL.Clear(clearDepth: false, clearColor: true, UnityEngine.Color.black);
			Graphics.Blit(adaptRenderTex[num], adaptRenderTex[curAdaptIndex], materialAdapt);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Crease Shading")]
	public class CreaseShading : PostEffectsBase
	{
		public float intensity = 0.5f;

		public int softness = 1;

		public float spread = 1f;

		public Shader blurShader;

		private Material blurMaterial;

		public Shader depthFetchShader;

		private Material depthFetchMaterial;

		public Shader creaseApplyShader;

		private Material creaseApplyMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			blurMaterial = CheckShaderAndCreateMaterial(blurShader, blurMaterial);
			depthFetchMaterial = CheckShaderAndCreateMaterial(depthFetchShader, depthFetchMaterial);
			creaseApplyMaterial = CheckShaderAndCreateMaterial(creaseApplyShader, creaseApplyMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			float num = 1f * (float)width / (1f * (float)height);
			float num2 = 0.001953125f;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(width / 2, height / 2, 0);
			Graphics.Blit(source, temporary, depthFetchMaterial);
			Graphics.Blit(temporary, renderTexture);
			for (int i = 0; i < softness; i++)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(0f, spread * num2, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
				temporary2 = RenderTexture.GetTemporary(width / 2, height / 2, 0);
				blurMaterial.SetVector("offsets", new Vector4(spread * num2 / num, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, temporary2, blurMaterial);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary2;
			}
			creaseApplyMaterial.SetTexture("_HrDepthTex", temporary);
			creaseApplyMaterial.SetTexture("_LrDepthTex", renderTexture);
			creaseApplyMaterial.SetFloat("intensity", intensity);
			Graphics.Blit(source, destination, creaseApplyMaterial);
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	public class DepthOfField : PostEffectsBase
	{
		public enum BlurType
		{
			DiscBlur,
			DX11
		}

		public enum BlurSampleCount
		{
			Low,
			Medium,
			High
		}

		public bool visualizeFocus;

		public float focalLength = 10f;

		public float focalSize = 0.05f;

		public float aperture = 0.5f;

		public Transform focalTransform;

		public float maxBlurSize = 2f;

		public bool highResolution;

		public BlurType blurType;

		public BlurSampleCount blurSampleCount = BlurSampleCount.High;

		public bool nearBlur;

		public float foregroundOverlap = 1f;

		public Shader dofHdrShader;

		private Material dofHdrMaterial;

		public Shader dx11BokehShader;

		private Material dx11bokehMaterial;

		public float dx11BokehThreshold = 0.5f;

		public float dx11SpawnHeuristic = 0.0875f;

		public Texture2D dx11BokehTexture;

		public float dx11BokehScale = 1.2f;

		public float dx11BokehIntensity = 2.5f;

		private float focalDistance01 = 10f;

		private ComputeBuffer cbDrawArgs;

		private ComputeBuffer cbPoints;

		private float internalBlurWidth = 1f;

		private Camera cachedCamera;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofHdrMaterial = CheckShaderAndCreateMaterial(dofHdrShader, dofHdrMaterial);
			if (supportDX11 && blurType == BlurType.DX11)
			{
				dx11bokehMaterial = CheckShaderAndCreateMaterial(dx11BokehShader, dx11bokehMaterial);
				CreateComputeResources();
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnEnable()
		{
			cachedCamera = GetComponent<Camera>();
			cachedCamera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private void OnDisable()
		{
			ReleaseComputeResources();
			if ((bool)dofHdrMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dofHdrMaterial);
			}
			dofHdrMaterial = null;
			if ((bool)dx11bokehMaterial)
			{
				UnityEngine.Object.DestroyImmediate(dx11bokehMaterial);
			}
			dx11bokehMaterial = null;
		}

		private void ReleaseComputeResources()
		{
			if (cbDrawArgs != null)
			{
				cbDrawArgs.Release();
			}
			cbDrawArgs = null;
			if (cbPoints != null)
			{
				cbPoints.Release();
			}
			cbPoints = null;
		}

		private void CreateComputeResources()
		{
			if (cbDrawArgs == null)
			{
				cbDrawArgs = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[4] { 0, 1, 0, 0 };
				cbDrawArgs.SetData(data);
			}
			if (cbPoints == null)
			{
				cbPoints = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		private float FocalDistance01(float worldDist)
		{
			return cachedCamera.WorldToViewportPoint((worldDist - cachedCamera.nearClipPlane) * cachedCamera.transform.forward + cachedCamera.transform.position).z / (cachedCamera.farClipPlane - cachedCamera.nearClipPlane);
		}

		private void WriteCoc(RenderTexture fromTo, bool fgDilate)
		{
			dofHdrMaterial.SetTexture("_FgOverlap", null);
			if (nearBlur && fgDilate)
			{
				int width = fromTo.width / 2;
				int height = fromTo.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(fromTo, temporary, dofHdrMaterial, 4);
				float num = internalBlurWidth * foregroundOverlap;
				dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary, temporary2, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary);
				dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, fromTo.format);
				Graphics.Blit(temporary2, temporary, dofHdrMaterial, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				dofHdrMaterial.SetTexture("_FgOverlap", temporary);
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				fromTo.MarkRestoreExpected();
				Graphics.Blit(fromTo, fromTo, dofHdrMaterial, 0);
			}
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (aperture < 0f)
			{
				aperture = 0f;
			}
			if (maxBlurSize < 0.1f)
			{
				maxBlurSize = 0.1f;
			}
			focalSize = Mathf.Clamp(focalSize, 0f, 2f);
			internalBlurWidth = Mathf.Max(maxBlurSize, 0f);
			focalDistance01 = (focalTransform ? (cachedCamera.WorldToViewportPoint(focalTransform.position).z / cachedCamera.farClipPlane) : FocalDistance01(focalLength));
			dofHdrMaterial.SetVector("_CurveParams", new Vector4(1f, focalSize, 1f / (1f - aperture) - 1f, focalDistance01));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			RenderTexture renderTexture3 = null;
			RenderTexture renderTexture4 = null;
			float num = internalBlurWidth * foregroundOverlap;
			if (visualizeFocus)
			{
				WriteCoc(source, fgDilate: true);
				Graphics.Blit(source, destination, dofHdrMaterial, 16);
			}
			else if (blurType == BlurType.DX11 && (bool)dx11bokehMaterial)
			{
				if (highResolution)
				{
					internalBlurWidth = ((internalBlurWidth < 0.1f) ? 0.1f : internalBlurWidth);
					num = internalBlurWidth * foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0, source.format);
					WriteCoc(source, fgDilate: false);
					renderTexture3 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture4 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					Graphics.Blit(source, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					if (nearBlur)
					{
						Graphics.Blit(source, renderTexture4, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", nearBlur ? renderTexture4 : null);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(source, renderTexture, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture4, renderTexture, dofHdrMaterial, 3);
					}
					Graphics.Blit(renderTexture, temporary, dofHdrMaterial, 20);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, source, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(source, temporary, dofHdrMaterial, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					Graphics.Blit(temporary, destination);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
					num = internalBlurWidth * foregroundOverlap;
					WriteCoc(source, fgDilate: false);
					source.filterMode = FilterMode.Bilinear;
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					renderTexture3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					renderTexture4 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, renderTexture3, dofHdrMaterial, 15);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(renderTexture3, renderTexture4, dofHdrMaterial, 19);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(renderTexture4, renderTexture3, dofHdrMaterial, 19);
					RenderTexture renderTexture5 = null;
					if (nearBlur)
					{
						renderTexture5 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
						Graphics.Blit(source, renderTexture5, dofHdrMaterial, 4);
					}
					dx11bokehMaterial.SetTexture("_BlurredColor", renderTexture3);
					dx11bokehMaterial.SetFloat("_SpawnHeuristic", dx11SpawnHeuristic);
					dx11bokehMaterial.SetVector("_BokehParams", new Vector4(dx11BokehScale, dx11BokehIntensity, Mathf.Clamp(dx11BokehThreshold, 0.005f, 4f), internalBlurWidth));
					dx11bokehMaterial.SetTexture("_FgCocMask", renderTexture5);
					Graphics.SetRandomWriteTarget(1, cbPoints);
					Graphics.Blit(renderTexture, renderTexture2, dx11bokehMaterial, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(renderTexture3);
					RenderTexture.ReleaseTemporary(renderTexture4);
					if (nearBlur)
					{
						dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture5, renderTexture, dofHdrMaterial, 2);
						dofHdrMaterial.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture5, dofHdrMaterial, 2);
						Graphics.Blit(renderTexture5, renderTexture2, dofHdrMaterial, 3);
					}
					dofHdrMaterial.SetVector("_Offsets", new Vector4(internalBlurWidth, 0f, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture2, renderTexture, dofHdrMaterial, 5);
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0f, internalBlurWidth));
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(cbPoints, cbDrawArgs, 0);
					dx11bokehMaterial.SetBuffer("pointBuffer", cbPoints);
					dx11bokehMaterial.SetTexture("_MainTex", dx11BokehTexture);
					dx11bokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), internalBlurWidth));
					dx11bokehMaterial.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, cbDrawArgs, 0);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", renderTexture5);
					dofHdrMaterial.SetVector("_Offsets", 1f * (float)source.width / (1f * (float)renderTexture2.width) * internalBlurWidth * Vector4.one);
					Graphics.Blit(source, destination, dofHdrMaterial, 9);
					if ((bool)renderTexture5)
					{
						RenderTexture.ReleaseTemporary(renderTexture5);
					}
				}
			}
			else
			{
				source.filterMode = FilterMode.Bilinear;
				if (highResolution)
				{
					internalBlurWidth *= 2f;
				}
				WriteCoc(source, fgDilate: true);
				renderTexture = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				renderTexture2 = RenderTexture.GetTemporary(source.width >> 1, source.height >> 1, 0, source.format);
				int pass = ((blurSampleCount == BlurSampleCount.High || blurSampleCount == BlurSampleCount.Medium) ? 17 : 11);
				if (highResolution)
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.025f, internalBlurWidth));
					Graphics.Blit(source, destination, dofHdrMaterial, pass);
				}
				else
				{
					dofHdrMaterial.SetVector("_Offsets", new Vector4(0f, internalBlurWidth, 0.1f, internalBlurWidth));
					Graphics.Blit(source, renderTexture, dofHdrMaterial, 6);
					Graphics.Blit(renderTexture, renderTexture2, dofHdrMaterial, pass);
					dofHdrMaterial.SetTexture("_LowRez", renderTexture2);
					dofHdrMaterial.SetTexture("_FgOverlap", null);
					dofHdrMaterial.SetVector("_Offsets", Vector4.one * (1f * (float)source.width / (1f * (float)renderTexture2.width)) * internalBlurWidth);
					Graphics.Blit(source, destination, dofHdrMaterial, (blurSampleCount == BlurSampleCount.High) ? 18 : 12);
				}
			}
			if ((bool)renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if ((bool)renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		public enum Dof34QualitySetting
		{
			OnlyBackground = 1,
			BackgroundAndForeground
		}

		public enum DofResolution
		{
			High = 2,
			Medium,
			Low
		}

		public enum DofBlurriness
		{
			Low = 1,
			High = 2,
			VeryHigh = 4
		}

		public enum BokehDestination
		{
			Background = 1,
			Foreground,
			BackgroundAndForeground
		}

		private static int SMOOTH_DOWNSAMPLE_PASS = 6;

		private static float BOKEH_EXTRA_BLUR = 2f;

		public Dof34QualitySetting quality = Dof34QualitySetting.OnlyBackground;

		public DofResolution resolution = DofResolution.Low;

		public bool simpleTweakMode = true;

		public float focalPoint = 1f;

		public float smoothness = 0.5f;

		public float focalZDistance;

		public float focalZStartCurve = 1f;

		public float focalZEndCurve = 1f;

		private float focalStartCurve = 2f;

		private float focalEndCurve = 2f;

		private float focalDistance01 = 0.1f;

		public Transform objectFocus;

		public float focalSize;

		public DofBlurriness bluriness = DofBlurriness.High;

		public float maxBlurSpread = 1.75f;

		public float foregroundBlurExtrude = 1.15f;

		public Shader dofBlurShader;

		private Material dofBlurMaterial;

		public Shader dofShader;

		private Material dofMaterial;

		public bool visualize;

		public BokehDestination bokehDestination = BokehDestination.Background;

		private float widthOverHeight = 1.25f;

		private float oneOverBaseSize = 0.001953125f;

		public bool bokeh;

		public bool bokehSupport = true;

		public Shader bokehShader;

		public Texture2D bokehTexture;

		public float bokehScale = 2.4f;

		public float bokehIntensity = 0.15f;

		public float bokehThresholdContrast = 0.1f;

		public float bokehThresholdLuminance = 0.55f;

		public int bokehDownsample = 1;

		private Material bokehMaterial;

		private Camera _camera;

		private RenderTexture foregroundTexture;

		private RenderTexture mediumRezWorkTexture;

		private RenderTexture finalDefocus;

		private RenderTexture lowRezWorkTexture;

		private RenderTexture bokehSource;

		private RenderTexture bokehSource2;

		private void CreateMaterials()
		{
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
		}

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			dofBlurMaterial = CheckShaderAndCreateMaterial(dofBlurShader, dofBlurMaterial);
			dofMaterial = CheckShaderAndCreateMaterial(dofShader, dofMaterial);
			bokehSupport = bokehShader.isSupported;
			if (bokeh && bokehSupport && (bool)bokehShader)
			{
				bokehMaterial = CheckShaderAndCreateMaterial(bokehShader, bokehMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			Quads.Cleanup();
		}

		private void OnEnable()
		{
			_camera = GetComponent<Camera>();
			_camera.depthTextureMode |= DepthTextureMode.Depth;
		}

		private float FocalDistance01(float worldDist)
		{
			return _camera.WorldToViewportPoint((worldDist - _camera.nearClipPlane) * _camera.transform.forward + _camera.transform.position).z / (_camera.farClipPlane - _camera.nearClipPlane);
		}

		private int GetDividerBasedOnQuality()
		{
			int result = 1;
			if (resolution == DofResolution.Medium)
			{
				result = 2;
			}
			else if (resolution == DofResolution.Low)
			{
				result = 2;
			}
			return result;
		}

		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			int num = baseDivider;
			if (resolution == DofResolution.High)
			{
				num *= 2;
			}
			if (resolution == DofResolution.Low)
			{
				num *= 2;
			}
			return num;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (smoothness < 0.1f)
			{
				smoothness = 0.1f;
			}
			bokeh = bokeh && bokehSupport;
			float num = (bokeh ? BOKEH_EXTRA_BLUR : 1f);
			bool flag = quality > Dof34QualitySetting.OnlyBackground;
			float num2 = focalSize / (_camera.farClipPlane - _camera.nearClipPlane);
			if (simpleTweakMode)
			{
				focalDistance01 = (objectFocus ? (_camera.WorldToViewportPoint(objectFocus.position).z / _camera.farClipPlane) : FocalDistance01(focalPoint));
				focalStartCurve = focalDistance01 * smoothness;
				focalEndCurve = focalStartCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			else
			{
				if ((bool)objectFocus)
				{
					Vector3 vector = _camera.WorldToViewportPoint(objectFocus.position);
					vector.z /= _camera.farClipPlane;
					focalDistance01 = vector.z;
				}
				else
				{
					focalDistance01 = FocalDistance01(focalZDistance);
				}
				focalStartCurve = focalZStartCurve;
				focalEndCurve = focalZEndCurve;
				flag = flag && focalPoint > _camera.nearClipPlane + Mathf.Epsilon;
			}
			widthOverHeight = 1f * (float)source.width / (1f * (float)source.height);
			oneOverBaseSize = 0.001953125f;
			dofMaterial.SetFloat("_ForegroundBlurExtrude", foregroundBlurExtrude);
			dofMaterial.SetVector("_CurveParams", new Vector4(simpleTweakMode ? (1f / focalStartCurve) : focalStartCurve, simpleTweakMode ? (1f / focalEndCurve) : focalEndCurve, num2 * 0.5f, focalDistance01));
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)source.width), 1f / (1f * (float)source.height), 0f, 0f));
			int dividerBasedOnQuality = GetDividerBasedOnQuality();
			int lowResolutionDividerBasedOnQuality = GetLowResolutionDividerBasedOnQuality(dividerBasedOnQuality);
			AllocateTextures(flag, source, dividerBasedOnQuality, lowResolutionDividerBasedOnQuality);
			Graphics.Blit(source, source, dofMaterial, 3);
			Downsample(source, mediumRezWorkTexture);
			Blur(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 4, maxBlurSpread);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast, bokehThresholdLuminance, 0.95f, 0f));
				Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
				Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread * num);
			}
			else
			{
				Downsample(mediumRezWorkTexture, lowRezWorkTexture);
				Blur(lowRezWorkTexture, lowRezWorkTexture, bluriness, 0, maxBlurSpread);
			}
			dofBlurMaterial.SetTexture("_TapLow", lowRezWorkTexture);
			dofBlurMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(null, finalDefocus, dofBlurMaterial, 3);
			if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
			{
				AddBokeh(bokehSource2, bokehSource, finalDefocus);
			}
			dofMaterial.SetTexture("_TapLowBackground", finalDefocus);
			dofMaterial.SetTexture("_TapMedium", mediumRezWorkTexture);
			Graphics.Blit(source, flag ? foregroundTexture : destination, dofMaterial, visualize ? 2 : 0);
			if (flag)
			{
				Graphics.Blit(foregroundTexture, source, dofMaterial, 5);
				Downsample(source, mediumRezWorkTexture);
				BlurFg(mediumRezWorkTexture, mediumRezWorkTexture, DofBlurriness.Low, 2, maxBlurSpread);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					dofMaterial.SetVector("_Threshhold", new Vector4(bokehThresholdContrast * 0.5f, bokehThresholdLuminance, 0f, 0f));
					Graphics.Blit(mediumRezWorkTexture, bokehSource2, dofMaterial, 11);
					Graphics.Blit(mediumRezWorkTexture, lowRezWorkTexture);
					BlurFg(lowRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread * num);
				}
				else
				{
					BlurFg(mediumRezWorkTexture, lowRezWorkTexture, bluriness, 1, maxBlurSpread);
				}
				Graphics.Blit(lowRezWorkTexture, finalDefocus);
				dofMaterial.SetTexture("_TapLowForeground", finalDefocus);
				Graphics.Blit(source, destination, dofMaterial, visualize ? 1 : 4);
				if (bokeh && (BokehDestination.Foreground & bokehDestination) != 0)
				{
					AddBokeh(bokehSource2, bokehSource, destination);
				}
			}
			ReleaseTextures();
		}

		private void Blur(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurFg(RenderTexture from, RenderTexture to, DofBlurriness iterations, int blurPass, float spread)
		{
			dofBlurMaterial.SetTexture("_TapHigh", from);
			RenderTexture temporary = RenderTexture.GetTemporary(to.width, to.height);
			if (iterations > DofBlurriness.Low)
			{
				BlurHex(from, to, blurPass, spread, temporary);
				if (iterations > DofBlurriness.High)
				{
					dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
					Graphics.Blit(to, temporary, dofBlurMaterial, blurPass);
					dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
					Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
				}
			}
			else
			{
				dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
				Graphics.Blit(from, temporary, dofBlurMaterial, blurPass);
				dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
				Graphics.Blit(temporary, to, dofBlurMaterial, blurPass);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
			dofBlurMaterial.SetVector("offsets", new Vector4(0f, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(from, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, 0f, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, spread * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(to, tmp, dofBlurMaterial, blurPass);
			dofBlurMaterial.SetVector("offsets", new Vector4(spread / widthOverHeight * oneOverBaseSize, (0f - spread) * oneOverBaseSize, 0f, 0f));
			Graphics.Blit(tmp, to, dofBlurMaterial, blurPass);
		}

		private void Downsample(RenderTexture from, RenderTexture to)
		{
			dofMaterial.SetVector("_InvRenderTargetSize", new Vector4(1f / (1f * (float)to.width), 1f / (1f * (float)to.height), 0f, 0f));
			Graphics.Blit(from, to, dofMaterial, SMOOTH_DOWNSAMPLE_PASS);
		}

		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
			if (!bokehMaterial)
			{
				return;
			}
			Mesh[] meshes = Quads.GetMeshes(tempTex.width, tempTex.height);
			RenderTexture.active = tempTex;
			GL.Clear(clearDepth: false, clearColor: true, new UnityEngine.Color(0f, 0f, 0f, 0f));
			GL.PushMatrix();
			GL.LoadIdentity();
			bokehInfo.filterMode = FilterMode.Point;
			float num = (float)bokehInfo.width * 1f / ((float)bokehInfo.height * 1f);
			float num2 = 2f / (1f * (float)bokehInfo.width);
			num2 += bokehScale * maxBlurSpread * BOKEH_EXTRA_BLUR * oneOverBaseSize;
			bokehMaterial.SetTexture("_Source", bokehInfo);
			bokehMaterial.SetTexture("_MainTex", bokehTexture);
			bokehMaterial.SetVector("_ArScale", new Vector4(num2, num2 * num, 0.5f, 0.5f * num));
			bokehMaterial.SetFloat("_Intensity", bokehIntensity);
			bokehMaterial.SetPass(0);
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if ((bool)mesh)
				{
					Graphics.DrawMeshNow(mesh, Matrix4x4.identity);
				}
			}
			GL.PopMatrix();
			Graphics.Blit(tempTex, finalTarget, dofMaterial, 8);
			bokehInfo.filterMode = FilterMode.Bilinear;
		}

		private void ReleaseTextures()
		{
			if ((bool)foregroundTexture)
			{
				RenderTexture.ReleaseTemporary(foregroundTexture);
			}
			if ((bool)finalDefocus)
			{
				RenderTexture.ReleaseTemporary(finalDefocus);
			}
			if ((bool)mediumRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(mediumRezWorkTexture);
			}
			if ((bool)lowRezWorkTexture)
			{
				RenderTexture.ReleaseTemporary(lowRezWorkTexture);
			}
			if ((bool)bokehSource)
			{
				RenderTexture.ReleaseTemporary(bokehSource);
			}
			if ((bool)bokehSource2)
			{
				RenderTexture.ReleaseTemporary(bokehSource2);
			}
		}

		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
			foregroundTexture = null;
			if (blurForeground)
			{
				foregroundTexture = RenderTexture.GetTemporary(source.width, source.height, 0);
			}
			mediumRezWorkTexture = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			finalDefocus = RenderTexture.GetTemporary(source.width / divider, source.height / divider, 0);
			lowRezWorkTexture = RenderTexture.GetTemporary(source.width / lowTexDivider, source.height / lowTexDivider, 0);
			bokehSource = null;
			bokehSource2 = null;
			if (bokeh)
			{
				bokehSource = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource2 = RenderTexture.GetTemporary(source.width / (lowTexDivider * bokehDownsample), source.height / (lowTexDivider * bokehDownsample), 0, RenderTextureFormat.ARGBHalf);
				bokehSource.filterMode = FilterMode.Bilinear;
				bokehSource2.filterMode = FilterMode.Bilinear;
				RenderTexture.active = bokehSource2;
				GL.Clear(clearDepth: false, clearColor: true, new UnityEngine.Color(0f, 0f, 0f, 0f));
			}
			source.filterMode = FilterMode.Bilinear;
			finalDefocus.filterMode = FilterMode.Bilinear;
			mediumRezWorkTexture.filterMode = FilterMode.Bilinear;
			lowRezWorkTexture.filterMode = FilterMode.Bilinear;
			if ((bool)foregroundTexture)
			{
				foregroundTexture.filterMode = FilterMode.Bilinear;
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		public enum EdgeDetectMode
		{
			TriangleDepthNormals,
			RobertsCrossDepthNormals,
			SobelDepth,
			SobelDepthThin,
			TriangleLuminance
		}

		public EdgeDetectMode mode = EdgeDetectMode.SobelDepthThin;

		public float sensitivityDepth = 1f;

		public float sensitivityNormals = 1f;

		public float lumThreshold = 0.2f;

		public float edgeExp = 1f;

		public float sampleDist = 1f;

		public float edgesOnly;

		public UnityEngine.Color edgesOnlyBgColor = UnityEngine.Color.white;

		public Shader edgeDetectShader;

		private Material edgeDetectMaterial;

		private EdgeDetectMode oldMode = EdgeDetectMode.SobelDepthThin;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			edgeDetectMaterial = CheckShaderAndCreateMaterial(edgeDetectShader, edgeDetectMaterial);
			if (mode != oldMode)
			{
				SetCameraFlag();
			}
			oldMode = mode;
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private new void Start()
		{
			oldMode = mode;
		}

		private void SetCameraFlag()
		{
			if (mode == EdgeDetectMode.SobelDepth || mode == EdgeDetectMode.SobelDepthThin)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (mode == EdgeDetectMode.TriangleDepthNormals || mode == EdgeDetectMode.RobertsCrossDepthNormals)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		private void OnEnable()
		{
			SetCameraFlag();
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector2 vector = new Vector2(sensitivityDepth, sensitivityNormals);
			edgeDetectMaterial.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			edgeDetectMaterial.SetFloat("_BgFade", edgesOnly);
			edgeDetectMaterial.SetFloat("_SampleDistance", sampleDist);
			edgeDetectMaterial.SetVector("_BgColor", edgesOnlyBgColor);
			edgeDetectMaterial.SetFloat("_Exponent", edgeExp);
			edgeDetectMaterial.SetFloat("_Threshold", lumThreshold);
			Graphics.Blit(source, destination, edgeDetectMaterial, (int)mode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Displacement/Fisheye")]
	public class Fisheye : PostEffectsBase
	{
		public enum FadeEase
		{
			NONE,
			EASE_IN_CUBIC,
			EASE_OUT_CUBIC
		}

		[Range(0f, 1.5f)]
		public float strengthX = 0.05f;

		[Range(0f, 1.5f)]
		public float strengthY = 0.05f;

		public Shader fishEyeShader;

		private Material fisheyeMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			fisheyeMaterial = CheckShaderAndCreateMaterial(fishEyeShader, fisheyeMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			float num = 5f / 32f;
			float num2 = (float)source.width * 1f / ((float)source.height * 1f);
			fisheyeMaterial.SetVector("intensity", new Vector4(strengthX * num2 * num, strengthY * num, strengthX * num2 * num, strengthY * num));
			Graphics.Blit(source, destination, fisheyeMaterial);
		}

		public void FadeFishEye(bool enabled, float time, float strengthX, float strengthY, FadeEase ease = FadeEase.NONE)
		{
			StartCoroutine(FadeFishEyeRoutine(enabled, time, strengthX, strengthY));
		}

		private IEnumerator FadeFishEyeRoutine(bool enabled, float time, float strengthX, float strengthY, FadeEase ease = FadeEase.NONE)
		{
			float start;
			float end;
			if (enabled)
			{
				base.enabled = true;
				Fisheye fisheye = this;
				float num;
				start = (num = 0f);
				fisheye.strengthX = num;
				Fisheye fisheye2 = this;
				end = (num = 0f);
				fisheye2.strengthY = num;
			}
			else
			{
				start = strengthX;
				end = strengthY;
			}
			for (float counter = 0f; counter < time; counter += Time.deltaTime)
			{
				float val = (enabled ? (strengthX * counter / time) : (strengthX - strengthX * counter / time));
				float val2 = (enabled ? (strengthY * counter / time) : (strengthY - strengthY * counter / time));
				switch (ease)
				{
				case FadeEase.NONE:
					this.strengthX = val;
					this.strengthY = val2;
					break;
				case FadeEase.EASE_IN_CUBIC:
					this.strengthX = LeanTween.easeInBack(start, end, val, 1.15f);
					this.strengthY = LeanTween.easeInBack(start, end, val2, 1.15f);
					break;
				case FadeEase.EASE_OUT_CUBIC:
					this.strengthX = LeanTween.easeOutCubic(start, end, val);
					this.strengthY = LeanTween.easeOutCubic(start, end, val2);
					break;
				}
				yield return null;
			}
			if (enabled)
			{
				this.strengthX = strengthX;
				this.strengthY = strengthY;
			}
			else
			{
				base.enabled = false;
				this.strengthX = 0f;
				this.strengthY = 0f;
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		public Shader fogShader;

		private Material fogMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			fogMaterial = CheckShaderAndCreateMaterial(fogShader, fogMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || (!distanceFog && !heightFog))
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Transform obj = component.transform;
			Vector3[] array = new Vector3[4];
			component.CalculateFrustumCorners(new Rect(0f, 0f, 1f, 1f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 vector = obj.TransformVector(array[0]);
			Vector3 vector2 = obj.TransformVector(array[1]);
			Vector3 vector3 = obj.TransformVector(array[2]);
			Vector3 vector4 = obj.TransformVector(array[3]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector4);
			identity.SetRow(2, vector2);
			identity.SetRow(3, vector3);
			Vector3 position = obj.position;
			float num = position.y - height;
			float z = ((num <= 0f) ? 1f : 0f);
			float y = (excludeFarPixels ? 1f : 2f);
			fogMaterial.SetMatrix("_FrustumCornersWS", identity);
			fogMaterial.SetVector("_CameraWS", position);
			fogMaterial.SetVector("_HeightParams", new Vector4(height, num, z, heightDensity * 0.5f));
			fogMaterial.SetVector("_DistanceParams", new Vector4(0f - Mathf.Max(startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = (flag ? (fogEndDistance - fogStartDistance) : 0f);
			float num3 = ((Mathf.Abs(num2) > 0.0001f) ? (1f / num2) : 0f);
			Vector4 value = default(Vector4);
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = (flag ? (0f - num3) : 0f);
			value.w = (flag ? (fogEndDistance * num3) : 0f);
			fogMaterial.SetVector("_SceneFogParams", value);
			fogMaterial.SetVector("_SceneFogMode", new Vector4((float)fogMode, useRadialDistance ? 1 : 0, 0f, 0f));
			int num4 = 0;
			Graphics.Blit(pass: (!distanceFog || !heightFog) ? (distanceFog ? 1 : 2) : 0, source: source, dest: destination, mat: fogMaterial);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Grayscale")]
	public class Grayscale : ImageEffectBase
	{
		public Texture textureRamp;

		[Range(-1f, 1f)]
		public float rampOffset;

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			base.material.SetTexture("_RampTex", textureRamp);
			base.material.SetFloat("_RampOffset", rampOffset);
			Graphics.Blit(source, destination, base.material);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		public Shader shader;

		private Material m_Material;

		protected Material material
		{
			get
			{
				if (m_Material == null)
				{
					m_Material = new Material(shader);
					m_Material.hideFlags = HideFlags.HideAndDontSave;
				}
				return m_Material;
			}
		}

		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (!shader || !shader.isSupported)
			{
				base.enabled = false;
			}
		}

		protected virtual void OnDisable()
		{
			if ((bool)m_Material)
			{
				UnityEngine.Object.DestroyImmediate(m_Material);
			}
		}
	}
	[AddComponentMenu("")]
	public class ImageEffects
	{
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
			if (source.texelSize.y < 0f)
			{
				center.y = 1f - center.y;
				angle = 0f - angle;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, angle), Vector3.one);
			material.SetMatrix("_RotationMatrix", value);
			material.SetVector("_CenterRadius", new Vector4(center.x, center.y, radius.x, radius.y));
			material.SetFloat("_Angle", angle * ((float)Math.PI / 180f));
			Graphics.Blit(source, destination, material);
		}

		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest);
		}

		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
			Graphics.Blit(source, dest, material);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	[RequireComponent(typeof(Camera))]
	public class MotionBlur : ImageEffectBase
	{
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		public bool extraBlur;

		private RenderTexture accumTexture;

		protected override void Start()
		{
			base.Start();
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(accumTexture);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (accumTexture == null || accumTexture.width != source.width || accumTexture.height != source.height)
			{
				UnityEngine.Object.DestroyImmediate(accumTexture);
				accumTexture = new RenderTexture(source.width, source.height, 0);
				accumTexture.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(source, accumTexture);
			}
			if (extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
				accumTexture.MarkRestoreExpected();
				Graphics.Blit(accumTexture, temporary);
				Graphics.Blit(temporary, accumTexture);
				RenderTexture.ReleaseTemporary(temporary);
			}
			blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
			base.material.SetTexture("_MainTex", accumTexture);
			base.material.SetFloat("_AccumOrig", 1f - blurAmount);
			accumTexture.MarkRestoreExpected();
			Graphics.Blit(source, accumTexture, base.material);
			Graphics.Blit(accumTexture, destination);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		public float intensityMultiplier = 0.25f;

		public float generalIntensity = 0.5f;

		public float blackIntensity = 1f;

		public float whiteIntensity = 1f;

		public float midGrey = 0.2f;

		public bool dx11Grain;

		public float softness;

		public bool monochrome;

		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		public float monochromeTiling = 64f;

		public FilterMode filterMode = FilterMode.Bilinear;

		public Texture2D noiseTexture;

		public Shader noiseShader;

		private Material noiseMaterial;

		public Shader dx11NoiseShader;

		private Material dx11NoiseMaterial;

		private static float TILE_AMOUNT = 64f;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			noiseMaterial = CheckShaderAndCreateMaterial(noiseShader, noiseMaterial);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial = CheckShaderAndCreateMaterial(dx11NoiseShader, dx11NoiseMaterial);
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources() || null == noiseTexture)
			{
				Graphics.Blit(source, destination);
				if (null == noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			softness = Mathf.Clamp(softness, 0f, 0.99f);
			if (dx11Grain && supportDX11)
			{
				dx11NoiseMaterial.SetFloat("_DX11NoiseTime", Time.frameCount);
				dx11NoiseMaterial.SetTexture("_NoiseTex", noiseTexture);
				dx11NoiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
				dx11NoiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
				dx11NoiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
				if (softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
					DrawNoiseQuadGrid(source, temporary, dx11NoiseMaterial, noiseTexture, monochrome ? 3 : 2);
					dx11NoiseMaterial.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(source, destination, dx11NoiseMaterial, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					DrawNoiseQuadGrid(source, destination, dx11NoiseMaterial, noiseTexture, monochrome ? 1 : 0);
				}
				return;
			}
			if ((bool)noiseTexture)
			{
				noiseTexture.wrapMode = TextureWrapMode.Repeat;
				noiseTexture.filterMode = filterMode;
			}
			noiseMaterial.SetTexture("_NoiseTex", noiseTexture);
			noiseMaterial.SetVector("_NoisePerChannel", monochrome ? Vector3.one : intensities);
			noiseMaterial.SetVector("_NoiseTilingPerChannel", monochrome ? (Vector3.one * monochromeTiling) : tiling);
			noiseMaterial.SetVector("_MidGrey", new Vector3(midGrey, 1f / (1f - midGrey), -1f / midGrey));
			noiseMaterial.SetVector("_NoiseAmount", new Vector3(generalIntensity, blackIntensity, whiteIntensity) * intensityMultiplier);
			if (softness > Mathf.Epsilon)
			{
				RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)source.width * (1f - softness)), (int)((float)source.height * (1f - softness)));
				DrawNoiseQuadGrid(source, temporary2, noiseMaterial, noiseTexture, 2);
				noiseMaterial.SetTexture("_NoiseTex", temporary2);
				Graphics.Blit(source, destination, noiseMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				DrawNoiseQuadGrid(source, destination, noiseMaterial, noiseTexture, 0);
			}
		}

		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
			RenderTexture.active = dest;
			float num = (float)noise.width * 1f;
			float num2 = 1f * (float)source.width / TILE_AMOUNT;
			fxMaterial.SetTexture("_MainTex", source);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)source.width / (1f * (float)source.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)noise.width * 1f);
			fxMaterial.SetPass(passNr);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		public bool monochrome = true;

		private bool rgbFallback;

		[Range(0f, 5f)]
		public float grainIntensityMin = 0.1f;

		[Range(0f, 5f)]
		public float grainIntensityMax = 0.2f;

		[Range(0.1f, 50f)]
		public float grainSize = 2f;

		[Range(0f, 5f)]
		public float scratchIntensityMin = 0.05f;

		[Range(0f, 5f)]
		public float scratchIntensityMax = 0.25f;

		[Range(1f, 30f)]
		public float scratchFPS = 10f;

		[Range(0f, 1f)]
		public float scratchJitter = 0.01f;

		public Texture grainTexture;

		public Texture scratchTexture;

		public Shader shaderRGB;

		public Shader shaderYUV;

		private Material m_MaterialRGB;

		private Material m_MaterialYUV;

		private float scratchTimeLeft;

		private float scratchX;

		private float scratchY;

		protected Material material
		{
			get
			{
				if (m_MaterialRGB == null)
				{
					m_MaterialRGB = new Material(shaderRGB);
					m_MaterialRGB.hideFlags = HideFlags.HideAndDontSave;
				}
				if (m_MaterialYUV == null && !rgbFallback)
				{
					m_MaterialYUV = new Material(shaderYUV);
					m_MaterialYUV.hideFlags = HideFlags.HideAndDontSave;
				}
				if (rgbFallback || monochrome)
				{
					return m_MaterialRGB;
				}
				return m_MaterialYUV;
			}
		}

		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
			}
			else if (shaderRGB == null || shaderYUV == null)
			{
				Debug.Log("Noise shaders are not set up! Disabling noise effect.");
				base.enabled = false;
			}
			else if (!shaderRGB.isSupported)
			{
				base.enabled = false;
			}
			else if (!shaderYUV.isSupported)
			{
				rgbFallback = true;
			}
		}

		protected void OnDisable()
		{
			if ((bool)m_MaterialRGB)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialRGB);
			}
			if ((bool)m_MaterialYUV)
			{
				UnityEngine.Object.DestroyImmediate(m_MaterialYUV);
			}
		}

		private void SanitizeParameters()
		{
			grainIntensityMin = Mathf.Clamp(grainIntensityMin, 0f, 5f);
			grainIntensityMax = Mathf.Clamp(grainIntensityMax, 0f, 5f);
			scratchIntensityMin = Mathf.Clamp(scratchIntensityMin, 0f, 5f);
			scratchIntensityMax = Mathf.Clamp(scratchIntensityMax, 0f, 5f);
			scratchFPS = Mathf.Clamp(scratchFPS, 1f, 30f);
			scratchJitter = Mathf.Clamp(scratchJitter, 0f, 1f);
			grainSize = Mathf.Clamp(grainSize, 0.1f, 50f);
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			SanitizeParameters();
			if (scratchTimeLeft <= 0f)
			{
				scratchTimeLeft = UnityEngine.Random.value * 2f / scratchFPS;
				scratchX = UnityEngine.Random.value;
				scratchY = UnityEngine.Random.value;
			}
			scratchTimeLeft -= Time.deltaTime;
			Material material = this.material;
			material.SetTexture("_GrainTex", grainTexture);
			material.SetTexture("_ScratchTex", scratchTexture);
			float num = 1f / grainSize;
			material.SetVector("_GrainOffsetScale", new Vector4(UnityEngine.Random.value, UnityEngine.Random.value, (float)Screen.width / (float)grainTexture.width * num, (float)Screen.height / (float)grainTexture.height * num));
			material.SetVector("_ScratchOffsetScale", new Vector4(scratchX + UnityEngine.Random.value * scratchJitter, scratchY + UnityEngine.Random.value * scratchJitter, (float)Screen.width / (float)scratchTexture.width, (float)Screen.height / (float)scratchTexture.height));
			material.SetVector("_Intensity", new Vector4(UnityEngine.Random.Range(grainIntensityMin, grainIntensityMax), UnityEngine.Random.Range(scratchIntensityMin, scratchIntensityMax), 0f, 0f));
			Graphics.Blit(source, destination, material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class PostEffectsBase : MonoBehaviour
	{
		protected bool supportHDRTextures = true;

		protected bool supportDX11;

		protected bool isSupported = true;

		private List<Material> createdMaterials = new List<Material>();

		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				base.enabled = false;
				return null;
			}
			if (s.isSupported && (bool)m2Create && m2Create.shader == s)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				NotSupported();
				Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not supported on this platform!");
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			if (!s)
			{
				Debug.Log("Missing shader in " + ToString());
				return null;
			}
			if ((bool)m2Create && m2Create.shader == s && s.isSupported)
			{
				return m2Create;
			}
			if (!s.isSupported)
			{
				return null;
			}
			m2Create = new Material(s);
			createdMaterials.Add(m2Create);
			m2Create.hideFlags = HideFlags.DontSave;
			return m2Create;
		}

		private void OnEnable()
		{
			isSupported = true;
		}

		private void OnDestroy()
		{
			RemoveCreatedMaterials();
		}

		private void RemoveCreatedMaterials()
		{
			while (createdMaterials.Count > 0)
			{
				Material obj = createdMaterials[0];
				createdMaterials.RemoveAt(0);
				UnityEngine.Object.Destroy(obj);
			}
		}

		protected bool CheckSupport()
		{
			return CheckSupport(needDepth: false);
		}

		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + ToString() + " should be overwritten.");
			return isSupported;
		}

		protected void Start()
		{
			CheckResources();
		}

		protected bool CheckSupport(bool needDepth)
		{
			isSupported = true;
			supportHDRTextures = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			supportDX11 = SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			if (!SystemInfo.supportsImageEffects)
			{
				NotSupported();
				return false;
			}
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				NotSupported();
				return false;
			}
			if (needDepth)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			if (!CheckSupport(needDepth))
			{
				return false;
			}
			if (needHdr && !supportHDRTextures)
			{
				NotSupported();
				return false;
			}
			return true;
		}

		public bool Dx11Support()
		{
			return supportDX11;
		}

		protected void ReportAutoDisable()
		{
			Debug.LogWarning("The image effect " + ToString() + " has been disabled as it's not supported on the current platform.");
		}

		private bool CheckShader(Shader s)
		{
			Debug.Log("The shader " + s.ToString() + " on effect " + ToString() + " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			if (!s.isSupported)
			{
				NotSupported();
				return false;
			}
			return false;
		}

		protected void NotSupported()
		{
			base.enabled = false;
			isSupported = false;
		}

		protected void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Debug.Log("OnRenderImage in Helper called ...");
		}

		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(cameraForProjectionMatrix.projectionMatrix);
			float f = cameraForProjectionMatrix.fieldOfView * 0.5f * ((float)Math.PI / 180f);
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = cameraForProjectionMatrix.aspect;
			float num2 = aspect / (0f - num);
			float num3 = aspect / num;
			float num4 = 1f / (0f - num);
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= dist * num6;
			num3 *= dist * num6;
			num4 *= dist * num6;
			num5 *= dist * num6;
			float z = 0f - dist;
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawBorder(RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f + 1f / ((float)dest.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				float x2 = 1f - 1f / ((float)dest.width * 1f);
				x = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				x = 1f;
				y3 = 0f;
				y4 = 0f + 1f / ((float)dest.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				x = 1f;
				y3 = 1f - 1f / ((float)dest.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(0f, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(0f, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
			RenderTexture.active = dest;
			material.SetTexture("_MainTex", source);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < material.passCount; i++)
			{
				material.SetPass(i);
				GL.Begin(7);
				float y3;
				float y4;
				if (flag)
				{
					y3 = 1f;
					y4 = 0f;
				}
				else
				{
					y3 = 0f;
					y4 = 1f;
				}
				GL.TexCoord2(0f, y3);
				GL.Vertex3(x1, y1, 0.1f);
				GL.TexCoord2(1f, y3);
				GL.Vertex3(x2, y1, 0.1f);
				GL.TexCoord2(1f, y4);
				GL.Vertex3(x2, y2, 0.1f);
				GL.TexCoord2(0f, y4);
				GL.Vertex3(x1, y2, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
	internal class Quads
	{
		private static Mesh[] meshes;

		private static int currentQuads;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			Mesh[] array = meshes;
			foreach (Mesh mesh in array)
			{
				if (null == mesh)
				{
					return false;
				}
			}
			return true;
		}

		public static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentQuads == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 10833;
			int num2 = (currentQuads = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 4];
			Vector2[] array2 = new Vector2[triCount * 4];
			Vector2[] array3 = new Vector2[triCount * 4];
			int[] array4 = new int[triCount * 6];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 4;
				int num2 = i * 6;
				int num3 = triOffset + i;
				float num4 = Mathf.Floor(num3 % totalWidth) / (float)totalWidth;
				float num5 = Mathf.Floor(num3 / totalWidth) / (float)totalHeight;
				array[num + 3] = (array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f))));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array2[num + 3] = new Vector2(1f, 1f);
				array3[num] = new Vector2(num4, num5);
				array3[num + 1] = new Vector2(num4, num5);
				array3[num + 2] = new Vector2(num4, num5);
				array3[num + 3] = new Vector2(num4, num5);
				array4[num2] = num;
				array4[num2 + 1] = num + 1;
				array4[num2 + 2] = num + 2;
				array4[num2 + 3] = num + 1;
				array4[num2 + 4] = num + 2;
				array4[num2 + 5] = num + 3;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Other/Screen Overlay")]
	public class ScreenOverlay : PostEffectsBase
	{
		public enum OverlayBlendMode
		{
			Additive,
			ScreenBlend,
			Multiply,
			Overlay,
			AlphaBlend
		}

		public OverlayBlendMode blendMode = OverlayBlendMode.Overlay;

		public float intensity = 1f;

		public Texture2D texture;

		public Shader overlayShader;

		private Material overlayMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			overlayMaterial = CheckShaderAndCreateMaterial(overlayShader, overlayMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Vector4 value = new Vector4(1f, 0f, 0f, 1f);
			overlayMaterial.SetVector("_UV_Transform", value);
			overlayMaterial.SetFloat("_Intensity", intensity);
			overlayMaterial.SetTexture("_Overlay", texture);
			Graphics.Blit(source, destination, overlayMaterial, (int)blendMode);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		[Range(0f, 3f)]
		public int blurIterations = 1;

		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		[Range(0f, 1f)]
		public int downsample;

		public Texture2D rand;

		public Shader aoShader;

		private Material aoMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: true);
			aoMaterial = CheckShaderAndCreateMaterial(aoShader, aoMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnDisable()
		{
			if ((bool)aoMaterial)
			{
				UnityEngine.Object.DestroyImmediate(aoMaterial);
			}
			aoMaterial = null;
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			Camera component = GetComponent<Camera>();
			Matrix4x4 projectionMatrix = component.projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / projectionMatrix[0, 0], -2f / projectionMatrix[1, 1], (1f - projectionMatrix[0, 2]) / projectionMatrix[0, 0], (1f + projectionMatrix[1, 2]) / projectionMatrix[1, 1]);
			if (component.stereoEnabled)
			{
				Matrix4x4 stereoProjectionMatrix = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Left);
				Matrix4x4 stereoProjectionMatrix2 = component.GetStereoProjectionMatrix(Camera.StereoscopicEye.Right);
				Vector4 value2 = new Vector4(-2f / stereoProjectionMatrix[0, 0], -2f / stereoProjectionMatrix[1, 1], (1f - stereoProjectionMatrix[0, 2]) / stereoProjectionMatrix[0, 0], (1f + stereoProjectionMatrix[1, 2]) / stereoProjectionMatrix[1, 1]);
				Vector4 value3 = new Vector4(-2f / stereoProjectionMatrix2[0, 0], -2f / stereoProjectionMatrix2[1, 1], (1f - stereoProjectionMatrix2[0, 2]) / stereoProjectionMatrix2[0, 0], (1f + stereoProjectionMatrix2[1, 2]) / stereoProjectionMatrix2[1, 1]);
				aoMaterial.SetVector("_ProjInfoLeft", value2);
				aoMaterial.SetVector("_ProjInfoRight", value3);
			}
			aoMaterial.SetVector("_ProjInfo", value);
			aoMaterial.SetMatrix("_ProjectionInv", inverse);
			aoMaterial.SetTexture("_Rand", rand);
			aoMaterial.SetFloat("_Radius", radius);
			aoMaterial.SetFloat("_Radius2", radius * radius);
			aoMaterial.SetFloat("_Intensity", intensity);
			aoMaterial.SetFloat("_BlurFilterDistance", blurFilterDistance);
			int width = source.width;
			int height = source.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> downsample, height >> downsample);
			Graphics.Blit(source, renderTexture, aoMaterial, 0);
			if (downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < blurIterations; i++)
			{
				aoMaterial.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				aoMaterial.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, aoMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			aoMaterial.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(source, destination, aoMaterial, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		public enum SSAOSamples
		{
			Low,
			Medium,
			High
		}

		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		public SSAOSamples m_SampleCount = SSAOSamples.Medium;

		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		[Range(0f, 4f)]
		public int m_Blur = 2;

		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		public Shader m_SSAOShader;

		private Material m_SSAOMaterial;

		public Texture2D m_RandomTexture;

		private bool m_Supported;

		private static Material CreateMaterial(Shader shader)
		{
			if (!shader)
			{
				return null;
			}
			return new Material(shader)
			{
				hideFlags = HideFlags.HideAndDontSave
			};
		}

		private static void DestroyMaterial(Material mat)
		{
			if ((bool)mat)
			{
				UnityEngine.Object.DestroyImmediate(mat);
				mat = null;
			}
		}

		private void OnDisable()
		{
			DestroyMaterial(m_SSAOMaterial);
		}

		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				m_Supported = false;
				base.enabled = false;
				return;
			}
			CreateMaterials();
			if (!m_SSAOMaterial || m_SSAOMaterial.passCount != 5)
			{
				m_Supported = false;
				base.enabled = false;
			}
			else
			{
				m_Supported = true;
			}
		}

		private void OnEnable()
		{
			GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		private void CreateMaterials()
		{
			if (!m_SSAOMaterial && m_SSAOShader.isSupported)
			{
				m_SSAOMaterial = CreateMaterial(m_SSAOShader);
				m_SSAOMaterial.SetTexture("_RandomTexture", m_RandomTexture);
			}
		}

		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!m_Supported || !m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			CreateMaterials();
			m_Downsampling = Mathf.Clamp(m_Downsampling, 1, 6);
			m_Radius = Mathf.Clamp(m_Radius, 0.05f, 1f);
			m_MinZ = Mathf.Clamp(m_MinZ, 1E-05f, 0.5f);
			m_OcclusionIntensity = Mathf.Clamp(m_OcclusionIntensity, 0.5f, 4f);
			m_OcclusionAttenuation = Mathf.Clamp(m_OcclusionAttenuation, 0.2f, 2f);
			m_Blur = Mathf.Clamp(m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(source.width / m_Downsampling, source.height / m_Downsampling, 0);
			float fieldOfView = GetComponent<Camera>().fieldOfView;
			float farClipPlane = GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * ((float)Math.PI / 180f) * 0.5f) * farClipPlane;
			float x = num * GetComponent<Camera>().aspect;
			m_SSAOMaterial.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if ((bool)m_RandomTexture)
			{
				num2 = m_RandomTexture.width;
				num3 = m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			m_SSAOMaterial.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			m_SSAOMaterial.SetVector("_Params", new Vector4(m_Radius, m_MinZ, 1f / m_OcclusionAttenuation, m_OcclusionIntensity));
			bool num4 = m_Blur > 0;
			Graphics.Blit(num4 ? null : source, renderTexture, m_SSAOMaterial, (int)m_SampleCount);
			if (num4)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4((float)m_Blur / (float)source.width, 0f, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(source.width, source.height, 0);
				m_SSAOMaterial.SetVector("_TexelOffsetScale", new Vector4(0f, (float)m_Blur / (float)source.height, 0f, 0f));
				m_SSAOMaterial.SetTexture("_SSAO", temporary);
				Graphics.Blit(source, temporary2, m_SSAOMaterial, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			m_SSAOMaterial.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(source, destination, m_SSAOMaterial, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Sepia Tone")]
	public class SepiaTone : ImageEffectBase
	{
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			Graphics.Blit(source, destination, base.material);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	public class SunShafts : PostEffectsBase
	{
		public enum SunShaftsResolution
		{
			Low,
			Normal,
			High
		}

		public enum ShaftsScreenBlendMode
		{
			Screen,
			Add
		}

		public SunShaftsResolution resolution = SunShaftsResolution.Normal;

		public ShaftsScreenBlendMode screenBlendMode;

		public Transform sunTransform;

		public int radialBlurIterations = 2;

		public UnityEngine.Color sunColor = UnityEngine.Color.white;

		public UnityEngine.Color sunThreshold = new UnityEngine.Color(0.87f, 0.74f, 0.65f);

		public float sunShaftBlurRadius = 2.5f;

		public float sunShaftIntensity = 1.15f;

		public float maxRadius = 0.75f;

		public bool useDepthTexture = true;

		public Shader sunShaftsShader;

		private Material sunShaftsMaterial;

		public Shader simpleClearShader;

		private Material simpleClearMaterial;

		public override bool CheckResources()
		{
			CheckSupport(useDepthTexture);
			sunShaftsMaterial = CheckShaderAndCreateMaterial(sunShaftsShader, sunShaftsMaterial);
			simpleClearMaterial = CheckShaderAndCreateMaterial(simpleClearShader, simpleClearMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			if (useDepthTexture)
			{
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (resolution == SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (resolution == SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			vector = ((!sunTransform) ? new Vector3(0.5f, 0.5f, 0f) : GetComponent<Camera>().WorldToViewportPoint(sunTransform.position));
			int width = source.width / num;
			int height = source.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * sunShaftBlurRadius);
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			sunShaftsMaterial.SetVector("_SunThreshold", sunThreshold);
			if (!useDepthTexture)
			{
				RenderTextureFormat format = (GetComponent<Camera>().allowHDR ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default);
				RenderTexture renderTexture = (RenderTexture.active = RenderTexture.GetTemporary(source.width, source.height, 0, format));
				GL.ClearWithSkybox(clearDepth: false, GetComponent<Camera>());
				sunShaftsMaterial.SetTexture("_Skybox", renderTexture);
				Graphics.Blit(source, temporary, sunShaftsMaterial, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			else
			{
				Graphics.Blit(source, temporary, sunShaftsMaterial, 2);
			}
			DrawBorder(temporary, simpleClearMaterial);
			radialBlurIterations = Mathf.Clamp(radialBlurIterations, 1, 4);
			float num2 = sunShaftBlurRadius * 0.0013020834f;
			sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			sunShaftsMaterial.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, maxRadius));
			for (int i = 0; i < radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, sunShaftsMaterial, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				sunShaftsMaterial.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				sunShaftsMaterial.SetVector("_SunColor", new Vector4(sunColor.r, sunColor.g, sunColor.b, sunColor.a) * sunShaftIntensity);
			}
			else
			{
				sunShaftsMaterial.SetVector("_SunColor", Vector4.zero);
			}
			sunShaftsMaterial.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(source, destination, sunShaftsMaterial, (screenBlendMode != 0) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Tilt Shift (Lens Blur)")]
	internal class TiltShift : PostEffectsBase
	{
		public enum TiltShiftMode
		{
			TiltShiftMode,
			IrisMode
		}

		public enum TiltShiftQuality
		{
			Preview,
			Low,
			Normal,
			High
		}

		public TiltShiftMode mode;

		public TiltShiftQuality quality = TiltShiftQuality.Normal;

		[Range(0f, 15f)]
		public float blurArea = 1f;

		[Range(0f, 25f)]
		public float maxBlurSize = 5f;

		[Range(0f, 1f)]
		public int downsample;

		public Shader tiltShiftShader;

		private Material tiltShiftMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			tiltShiftMaterial = CheckShaderAndCreateMaterial(tiltShiftShader, tiltShiftMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			tiltShiftMaterial.SetFloat("_BlurSize", (maxBlurSize < 0f) ? 0f : maxBlurSize);
			tiltShiftMaterial.SetFloat("_BlurArea", blurArea);
			source.filterMode = FilterMode.Bilinear;
			RenderTexture renderTexture = destination;
			if ((float)downsample > 0f)
			{
				renderTexture = RenderTexture.GetTemporary(source.width >> downsample, source.height >> downsample, 0, source.format);
				renderTexture.filterMode = FilterMode.Bilinear;
			}
			int num = (int)quality;
			num *= 2;
			Graphics.Blit(source, renderTexture, tiltShiftMaterial, (mode == TiltShiftMode.TiltShiftMode) ? num : (num + 1));
			if (downsample > 0)
			{
				tiltShiftMaterial.SetTexture("_Blurred", renderTexture);
				Graphics.Blit(source, destination, tiltShiftMaterial, 8);
			}
			if (renderTexture != destination)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	public class Tonemapping : PostEffectsBase
	{
		public enum TonemapperType
		{
			SimpleReinhard,
			UserCurve,
			Hable,
			Photographic,
			OptimizedHejiDawson,
			AdaptiveReinhard,
			AdaptiveReinhardAutoWhite
		}

		public enum AdaptiveTexSize
		{
			Square16 = 0x10,
			Square32 = 0x20,
			Square64 = 0x40,
			Square128 = 0x80,
			Square256 = 0x100,
			Square512 = 0x200,
			Square1024 = 0x400
		}

		public TonemapperType type = TonemapperType.Photographic;

		public AdaptiveTexSize adaptiveTextureSize = AdaptiveTexSize.Square256;

		public AnimationCurve remapCurve;

		private Texture2D curveTex;

		public float exposureAdjustment = 1.5f;

		public float middleGrey = 0.4f;

		public float white = 2f;

		public float adaptionSpeed = 1.5f;

		public Shader tonemapper;

		public bool validRenderTextureFormat = true;

		private Material tonemapMaterial;

		private RenderTexture rt;

		private RenderTextureFormat rtFormat = RenderTextureFormat.ARGBHalf;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false, needHdr: true);
			tonemapMaterial = CheckShaderAndCreateMaterial(tonemapper, tonemapMaterial);
			if (!curveTex && type == TonemapperType.UserCurve)
			{
				curveTex = new Texture2D(256, 1, TextureFormat.ARGB32, mipChain: false, linear: true);
				curveTex.filterMode = FilterMode.Bilinear;
				curveTex.wrapMode = TextureWrapMode.Clamp;
				curveTex.hideFlags = HideFlags.DontSave;
			}
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		public float UpdateCurve()
		{
			float num = 1f;
			if (remapCurve.keys.Length < 1)
			{
				remapCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(2f, 1f));
			}
			if (remapCurve != null)
			{
				if (remapCurve.length > 0)
				{
					num = remapCurve[remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = remapCurve.Evaluate(num2 * 1f * num);
					curveTex.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new UnityEngine.Color(num3, num3, num3));
				}
				curveTex.Apply();
			}
			return 1f / num;
		}

		private void OnDisable()
		{
			if ((bool)rt)
			{
				UnityEngine.Object.DestroyImmediate(rt);
				rt = null;
			}
			if ((bool)tonemapMaterial)
			{
				UnityEngine.Object.DestroyImmediate(tonemapMaterial);
				tonemapMaterial = null;
			}
			if ((bool)curveTex)
			{
				UnityEngine.Object.DestroyImmediate(curveTex);
				curveTex = null;
			}
		}

		private bool CreateInternalRenderTexture()
		{
			if ((bool)rt)
			{
				return false;
			}
			rtFormat = (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf);
			rt = new RenderTexture(1, 1, 0, rtFormat);
			rt.hideFlags = HideFlags.DontSave;
			return true;
		}

		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			exposureAdjustment = ((exposureAdjustment < 0.001f) ? 0.001f : exposureAdjustment);
			if (type == TonemapperType.UserCurve)
			{
				float value = UpdateCurve();
				tonemapMaterial.SetFloat("_RangeScale", value);
				tonemapMaterial.SetTexture("_Curve", curveTex);
				Graphics.Blit(source, destination, tonemapMaterial, 4);
				return;
			}
			if (type == TonemapperType.SimpleReinhard)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 6);
				return;
			}
			if (type == TonemapperType.Hable)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 5);
				return;
			}
			if (type == TonemapperType.Photographic)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 8);
				return;
			}
			if (type == TonemapperType.OptimizedHejiDawson)
			{
				tonemapMaterial.SetFloat("_ExposureAdjustment", 0.5f * exposureAdjustment);
				Graphics.Blit(source, destination, tonemapMaterial, 7);
				return;
			}
			bool flag = CreateInternalRenderTexture();
			RenderTexture temporary = RenderTexture.GetTemporary((int)adaptiveTextureSize, (int)adaptiveTextureSize, 0, rtFormat);
			Graphics.Blit(source, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, rtFormat);
				num2 *= 2;
			}
			RenderTexture source2 = array[num - 1];
			Graphics.Blit(temporary, array[0], tonemapMaterial, 1);
			if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], tonemapMaterial, 9);
					source2 = array[j + 1];
				}
			}
			else if (type == TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source2 = array[k + 1];
				}
			}
			adaptionSpeed = ((adaptionSpeed < 0.001f) ? 0.001f : adaptionSpeed);
			tonemapMaterial.SetFloat("_AdaptionSpeed", adaptionSpeed);
			rt.MarkRestoreExpected();
			Graphics.Blit(source2, rt, tonemapMaterial, flag ? 3 : 2);
			middleGrey = ((middleGrey < 0.001f) ? 0.001f : middleGrey);
			tonemapMaterial.SetVector("_HdrParams", new Vector4(middleGrey, middleGrey, middleGrey, white * white));
			tonemapMaterial.SetTexture("_SmallTex", rt);
			if (type == TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 0);
			}
			else if (type == TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(source, destination, tonemapMaterial, 10);
			}
			else
			{
				Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(source, destination);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}
	}
	internal class Triangles
	{
		private static Mesh[] meshes;

		private static int currentTris;

		private static bool HasMeshes()
		{
			if (meshes == null)
			{
				return false;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null == meshes[i])
				{
					return false;
				}
			}
			return true;
		}

		private static void Cleanup()
		{
			if (meshes == null)
			{
				return;
			}
			for (int i = 0; i < meshes.Length; i++)
			{
				if (null != meshes[i])
				{
					UnityEngine.Object.DestroyImmediate(meshes[i]);
					meshes[i] = null;
				}
			}
			meshes = null;
		}

		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			if (HasMeshes() && currentTris == totalWidth * totalHeight)
			{
				return meshes;
			}
			int num = 21666;
			int num2 = (currentTris = totalWidth * totalHeight);
			meshes = new Mesh[Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num))];
			int num3 = 0;
			int num4 = 0;
			for (num3 = 0; num3 < num2; num3 += num)
			{
				int triCount = Mathf.FloorToInt(Mathf.Clamp(num2 - num3, 0, num));
				meshes[num4] = GetMesh(triCount, num3, totalWidth, totalHeight);
				num4++;
			}
			return meshes;
		}

		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			Mesh mesh = new Mesh();
			mesh.hideFlags = HideFlags.DontSave;
			Vector3[] array = new Vector3[triCount * 3];
			Vector2[] array2 = new Vector2[triCount * 3];
			Vector2[] array3 = new Vector2[triCount * 3];
			int[] array4 = new int[triCount * 3];
			for (int i = 0; i < triCount; i++)
			{
				int num = i * 3;
				int num2 = triOffset + i;
				float num3 = Mathf.Floor(num2 % totalWidth) / (float)totalWidth;
				float num4 = Mathf.Floor(num2 / totalWidth) / (float)totalHeight;
				array[num + 2] = (array[num + 1] = (array[num] = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f)));
				array2[num] = new Vector2(0f, 0f);
				array2[num + 1] = new Vector2(1f, 0f);
				array2[num + 2] = new Vector2(0f, 1f);
				array3[num] = new Vector2(num3, num4);
				array3[num + 1] = new Vector2(num3, num4);
				array3[num + 2] = new Vector2(num3, num4);
				array4[num] = num;
				array4[num + 1] = num + 1;
				array4[num + 2] = num + 2;
			}
			mesh.vertices = array;
			mesh.triangles = array4;
			mesh.uv = array2;
			mesh.uv2 = array3;
			return mesh;
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Twirl")]
	public class Twirl : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.3f, 0.3f);

		[Range(0f, 360f)]
		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		public enum AberrationMode
		{
			Simple,
			Advanced
		}

		public AberrationMode mode;

		public float intensity = 0.036f;

		public float chromaticAberration = 0.2f;

		public float axialAberration = 0.5f;

		public float blur;

		public float blurSpread = 0.75f;

		public float luminanceDependency = 0.25f;

		public float blurDistance = 2.5f;

		public Shader vignetteShader;

		public Shader separableBlurShader;

		public Shader chromAberrationShader;

		private Material m_VignetteMaterial;

		private Material m_SeparableBlurMaterial;

		private Material m_ChromAberrationMaterial;

		public override bool CheckResources()
		{
			CheckSupport(needDepth: false);
			m_VignetteMaterial = CheckShaderAndCreateMaterial(vignetteShader, m_VignetteMaterial);
			m_SeparableBlurMaterial = CheckShaderAndCreateMaterial(separableBlurShader, m_SeparableBlurMaterial);
			m_ChromAberrationMaterial = CheckShaderAndCreateMaterial(chromAberrationShader, m_ChromAberrationMaterial);
			if (!isSupported)
			{
				ReportAutoDisable();
			}
			return isSupported;
		}

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			if (!CheckResources())
			{
				Graphics.Blit(source, destination);
				return;
			}
			int width = source.width;
			int height = source.height;
			bool flag = Mathf.Abs(blur) > 0f || Mathf.Abs(intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, source.format);
				if (Mathf.Abs(blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
					Graphics.Blit(source, renderTexture2, m_ChromAberrationMaterial, 0);
					for (int i = 0; i < 2; i++)
					{
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(0f, blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(renderTexture2, temporary, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(renderTexture2);
						m_SeparableBlurMaterial.SetVector("offsets", new Vector4(blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, source.format);
						Graphics.Blit(temporary, renderTexture2, m_SeparableBlurMaterial);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				m_VignetteMaterial.SetFloat("_Intensity", 1f / (1f - intensity) - 1f);
				m_VignetteMaterial.SetFloat("_Blur", 1f / (1f - blur) - 1f);
				m_VignetteMaterial.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(source, renderTexture, m_VignetteMaterial, 0);
			}
			m_ChromAberrationMaterial.SetFloat("_ChromaticAberration", chromaticAberration);
			m_ChromAberrationMaterial.SetFloat("_AxialAberration", axialAberration);
			m_ChromAberrationMaterial.SetVector("_BlurDistance", new Vector2(0f - blurDistance, blurDistance));
			m_ChromAberrationMaterial.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				source.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit(flag ? renderTexture : source, destination, m_ChromAberrationMaterial, (mode != AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}
	}
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Displacement/Vortex")]
	public class Vortex : ImageEffectBase
	{
		public Vector2 radius = new Vector2(0.4f, 0.4f);

		public float angle = 50f;

		public Vector2 center = new Vector2(0.5f, 0.5f);

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
			ImageEffects.RenderDistortion(base.material, source, destination, angle, center, radius);
		}
	}
}
namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class BeamGeometry : MonoBehaviour
	{
		private VolumetricLightBeam m_Master;

		private Matrix4x4 m_ColorGradientMatrix;

		private MeshType m_CurrentMeshType;

		private Material m_CustomMaterial;

		private Plane m_ClippingPlaneWS;

		public MeshRenderer meshRenderer { get; private set; }

		public MeshFilter meshFilter { get; private set; }

		public Mesh coneMesh { get; private set; }

		public bool visible
		{
			get
			{
				return meshRenderer.enabled;
			}
			set
			{
				meshRenderer.enabled = value;
			}
		}

		public int sortingLayerID
		{
			get
			{
				return meshRenderer.sortingLayerID;
			}
			set
			{
				meshRenderer.sortingLayerID = value;
			}
		}

		public int sortingOrder
		{
			get
			{
				return meshRenderer.sortingOrder;
			}
			set
			{
				meshRenderer.sortingOrder = value;
			}
		}

		public static bool isCustomRenderPipelineSupported => true;

		private bool isNoiseEnabled
		{
			get
			{
				if (m_Master.noiseEnabled && m_Master.noiseIntensity > 0f)
				{
					return Noise3D.isSupported;
				}
				return false;
			}
		}

		private bool isClippingPlaneEnabled => m_ClippingPlaneWS.normal.sqrMagnitude > 0f;

		private bool isDepthBlendEnabled
		{
			get
			{
				if (!GpuInstancing.forceEnableDepthBlend)
				{
					return m_Master.depthBlendDistance > 0f;
				}
				return true;
			}
		}

		private void Start()
		{
			if (!m_Master)
			{
				UnityEngine.Object.DestroyImmediate(base.gameObject);
			}
		}

		private void OnDestroy()
		{
			if ((bool)m_CustomMaterial)
			{
				UnityEngine.Object.DestroyImmediate(m_CustomMaterial);
				m_CustomMaterial = null;
			}
		}

		private static bool IsUsingCustomRenderPipeline()
		{
			if (RenderPipelineManager.currentPipeline == null)
			{
				return GraphicsSettings.renderPipelineAsset != null;
			}
			return true;
		}

		private void OnEnable()
		{
			if (IsUsingCustomRenderPipeline())
			{
				UnityEngine.Experimental.Rendering.RenderPipeline.beginCameraRendering += OnBeginCameraRendering;
			}
		}

		private void OnDisable()
		{
			if (IsUsingCustomRenderPipeline())
			{
				UnityEngine.Experimental.Rendering.RenderPipeline.beginCameraRendering -= OnBeginCameraRendering;
			}
		}

		public void Initialize(VolumetricLightBeam master)
		{
			HideFlags proceduralObjectsHideFlags = Consts.ProceduralObjectsHideFlags;
			m_Master = master;
			base.transform.SetParent(master.transform, worldPositionStays: false);
			meshRenderer = base.gameObject.GetOrAddComponent<MeshRenderer>();
			meshRenderer.hideFlags = proceduralObjectsHideFlags;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = false;
			meshRenderer.lightProbeUsage = LightProbeUsage.Off;
			if (Config.Instance.actualRenderingMode != RenderingMode.GPUInstancing)
			{
				m_CustomMaterial = MaterialManager.NewMaterial(gpuInstanced: false);
				ApplyMaterial();
			}
			if (SortingLayer.IsValid(m_Master.sortingLayerID))
			{
				sortingLayerID = m_Master.sortingLayerID;
			}
			else
			{
				Debug.LogError($"Beam '{Utils.GetPath(m_Master.transform)}' has an invalid sortingLayerID ({m_Master.sortingLayerID}). Please fix it by setting a valid layer.");
			}
			sortingOrder = m_Master.sortingOrder;
			meshFilter = base.gameObject.GetOrAddComponent<MeshFilter>();
			meshFilter.hideFlags = proceduralObjectsHideFlags;
			base.gameObject.hideFlags = proceduralObjectsHideFlags;
		}

		public void RegenerateMesh()
		{
			if (Config.Instance.geometryOverrideLayer)
			{
				base.gameObject.layer = Config.Instance.geometryLayerID;
			}
			else
			{
				base.gameObject.layer = m_Master.gameObject.layer;
			}
			base.gameObject.tag = Config.Instance.geometryTag;
			if ((bool)coneMesh && m_CurrentMeshType == MeshType.Custom)
			{
				UnityEngine.Object.DestroyImmediate(coneMesh);
			}
			m_CurrentMeshType = m_Master.geomMeshType;
			switch (m_Master.geomMeshType)
			{
			case MeshType.Custom:
				coneMesh = MeshGenerator.GenerateConeZ_Radius(1f, 1f, 1f, m_Master.geomCustomSides, m_Master.geomCustomSegments, m_Master.geomCap, Config.Instance.useSinglePassShader);
				coneMesh.hideFlags = Consts.ProceduralObjectsHideFlags;
				meshFilter.mesh = coneMesh;
				break;
			case MeshType.Shared:
				coneMesh = GlobalMesh.Get();
				meshFilter.sharedMesh = coneMesh;
				break;
			default:
				Debug.LogError("Unsupported MeshType");
				break;
			}
			UpdateMaterialAndBounds();
		}

		private void ComputeLocalMatrix()
		{
			float num = Mathf.Max(m_Master.coneRadiusStart, m_Master.coneRadiusEnd);
			base.transform.localScale = new Vector3(num, num, m_Master.fadeEnd);
		}

		private bool ApplyMaterial()
		{
			MaterialManager.ColorGradient colorGradient = MaterialManager.ColorGradient.Off;
			if (m_Master.colorMode == ColorMode.Gradient)
			{
				colorGradient = ((Utils.GetFloatPackingPrecision() != Utils.FloatPackingPrecision.High) ? MaterialManager.ColorGradient.MatrixLow : MaterialManager.ColorGradient.MatrixHigh);
			}
			MaterialManager.StaticProperties staticProperties = new MaterialManager.StaticProperties
			{
				blendingMode = (MaterialManager.BlendingMode)m_Master.blendingMode,
				noise3D = (isNoiseEnabled ? MaterialManager.Noise3D.On : MaterialManager.Noise3D.Off),
				depthBlend = (isDepthBlendEnabled ? MaterialManager.DepthBlend.On : MaterialManager.DepthBlend.Off),
				colorGradient = colorGradient,
				clippingPlane = (isClippingPlaneEnabled ? MaterialManager.ClippingPlane.On : MaterialManager.ClippingPlane.Off)
			};
			Material material = null;
			if (Config.Instance.actualRenderingMode != RenderingMode.GPUInstancing)
			{
				material = m_CustomMaterial;
				if ((bool)material)
				{
					staticProperties.ApplyToMaterial(material);
				}
			}
			else
			{
				material = MaterialManager.GetInstancedMaterial(m_Master._INTERNAL_InstancedMaterialGroupID, staticProperties);
			}
			meshRenderer.material = material;
			return material != null;
		}

		private void SetMaterialProp(string name, float value)
		{
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.SetFloat(name, value);
			}
			else
			{
				MaterialManager.materialPropertyBlock.SetFloat(name, value);
			}
		}

		private void SetMaterialProp(string name, Vector4 value)
		{
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.SetVector(name, value);
			}
			else
			{
				MaterialManager.materialPropertyBlock.SetVector(name, value);
			}
		}

		private void SetMaterialProp(string name, UnityEngine.Color value)
		{
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.SetColor(name, value);
			}
			else
			{
				MaterialManager.materialPropertyBlock.SetColor(name, value);
			}
		}

		private void SetMaterialProp(string name, Matrix4x4 value)
		{
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.SetMatrix(name, value);
			}
			else
			{
				MaterialManager.materialPropertyBlock.SetMatrix(name, value);
			}
		}

		private void SendMaterialClippingPlaneProp()
		{
			SetMaterialProp("_ClippingPlaneWS", new Vector4(m_ClippingPlaneWS.normal.x, m_ClippingPlaneWS.normal.y, m_ClippingPlaneWS.normal.z, m_ClippingPlaneWS.distance));
		}

		public void UpdateMaterialAndBounds()
		{
			if (ApplyMaterial())
			{
				if (isClippingPlaneEnabled && m_CustomMaterial == null)
				{
					SendMaterialClippingPlaneProp();
				}
				float f = m_Master.coneAngle * ((float)Math.PI / 180f) / 2f;
				SetMaterialProp("_ConeSlopeCosSin", new Vector2(Mathf.Cos(f), Mathf.Sin(f)));
				Vector2 vector = new Vector2(Mathf.Max(m_Master.coneRadiusStart, 0.0001f), Mathf.Max(m_Master.coneRadiusEnd, 0.0001f));
				SetMaterialProp("_ConeRadius", vector);
				float value = Mathf.Sign(m_Master.coneApexOffsetZ) * Mathf.Max(Mathf.Abs(m_Master.coneApexOffsetZ), 0.0001f);
				SetMaterialProp("_ConeApexOffsetZ", value);
				if (m_Master.colorMode == ColorMode.Flat)
				{
					SetMaterialProp("_ColorFlat", m_Master.color);
				}
				else
				{
					Utils.FloatPackingPrecision floatPackingPrecision = Utils.GetFloatPackingPrecision();
					m_ColorGradientMatrix = m_Master.colorGradient.SampleInMatrix((int)floatPackingPrecision);
				}
				SetMaterialProp("_AlphaInside", m_Master.intensityInside);
				SetMaterialProp("_AlphaOutside", m_Master.intensityOutside);
				SetMaterialProp("_AttenuationLerpLinearQuad", m_Master.attenuationLerpLinearQuad);
				SetMaterialProp("_DistanceFadeStart", m_Master.fadeStart);
				SetMaterialProp("_DistanceFadeEnd", m_Master.fadeEnd);
				SetMaterialProp("_DistanceCamClipping", m_Master.cameraClippingDistance);
				SetMaterialProp("_FresnelPow", Mathf.Max(0.001f, m_Master.fresnelPow));
				SetMaterialProp("_GlareBehind", m_Master.glareBehind);
				SetMaterialProp("_GlareFrontal", m_Master.glareFrontal);
				SetMaterialProp("_DrawCap", m_Master.geomCap ? 1 : 0);
				if (isDepthBlendEnabled)
				{
					SetMaterialProp("_DepthBlendDistance", m_Master.depthBlendDistance);
				}
				if (isNoiseEnabled)
				{
					Noise3D.LoadIfNeeded();
					SetMaterialProp("_NoiseLocal", new Vector4(m_Master.noiseVelocityLocal.x, m_Master.noiseVelocityLocal.y, m_Master.noiseVelocityLocal.z, m_Master.noiseScaleLocal));
					SetMaterialProp("_NoiseParam", new Vector3(m_Master.noiseIntensity, m_Master.noiseVelocityUseGlobal ? 1f : 0f, m_Master.noiseScaleUseGlobal ? 1f : 0f));
				}
				if (m_CustomMaterial == null)
				{
					meshRenderer.SetPropertyBlock(MaterialManager.materialPropertyBlock);
				}
				ComputeLocalMatrix();
			}
		}

		public void SetClippingPlane(Plane planeWS)
		{
			m_ClippingPlaneWS = planeWS;
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.EnableKeyword("VLB_CLIPPING_PLANE");
				SendMaterialClippingPlaneProp();
			}
			else
			{
				UpdateMaterialAndBounds();
			}
		}

		public void SetClippingPlaneOff()
		{
			m_ClippingPlaneWS = default(Plane);
			if ((bool)m_CustomMaterial)
			{
				m_CustomMaterial.DisableKeyword("VLB_CLIPPING_PLANE");
			}
			else
			{
				UpdateMaterialAndBounds();
			}
		}

		private void OnBeginCameraRendering(Camera cam)
		{
			UpdateCameraRelatedProperties(cam);
		}

		private void OnWillRenderObject()
		{
			if (!IsUsingCustomRenderPipeline())
			{
				Camera current = Camera.current;
				if (current != null)
				{
					UpdateCameraRelatedProperties(current);
				}
			}
		}

		private void UpdateCameraRelatedProperties(Camera cam)
		{
			if ((bool)cam && (bool)m_Master)
			{
				if (m_CustomMaterial == null)
				{
					meshRenderer.GetPropertyBlock(MaterialManager.materialPropertyBlock);
				}
				Vector3 posOS = m_Master.transform.InverseTransformPoint(cam.transform.position);
				Vector3 normalized = base.transform.InverseTransformDirection(cam.transform.forward).normalized;
				float w = (cam.orthographic ? (-1f) : m_Master.GetInsideBeamFactorFromObjectSpacePos(posOS));
				SetMaterialProp("_CameraParams", new Vector4(normalized.x, normalized.y, normalized.z, w));
				if (m_Master.colorMode == ColorMode.Gradient)
				{
					SetMaterialProp("_ColorGradientMatrix", m_ColorGradientMatrix);
				}
				if (m_CustomMaterial == null)
				{
					meshRenderer.SetPropertyBlock(MaterialManager.materialPropertyBlock);
				}
				if (m_Master.depthBlendDistance > 0f)
				{
					cam.depthTextureMode |= DepthTextureMode.Depth;
				}
			}
		}
	}
	[HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : ScriptableObject
	{
		public bool geometryOverrideLayer = true;

		public int geometryLayerID = 1;

		public string geometryTag = "Untagged";

		public int geometryRenderQueue = 3000;

		public RenderPipeline renderPipeline;

		[Obsolete("Use 'renderingMode' instead")]
		public bool forceSinglePass;

		public RenderingMode renderingMode;

		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[FormerlySerializedAs("BeamShader")]
		[FormerlySerializedAs("beamShader")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader2Pass;

		public int sharedMeshSides = 24;

		public int sharedMeshSegments = 5;

		[Range(0.01f, 2f)]
		public float globalNoiseScale = 0.5f;

		public Vector3 globalNoiseVelocity = Consts.NoiseVelocityDefault;

		[HighlightNull]
		public TextAsset noise3DData;

		public int noise3DSize = 64;

		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[SerializeField]
		private int pluginVersion = -1;

		private static Config m_Instance;

		public RenderingMode actualRenderingMode
		{
			get
			{
				_ = renderingMode;
				_ = 2;
				return renderingMode;
			}
		}

		public bool useSinglePassShader => actualRenderingMode != RenderingMode.MultiPass;

		public Shader beamShader
		{
			get
			{
				if (!useSinglePassShader)
				{
					return beamShader2Pass;
				}
				return beamShader1Pass;
			}
		}

		public Vector4 globalNoiseParam => new Vector4(globalNoiseVelocity.x, globalNoiseVelocity.y, globalNoiseVelocity.z, globalNoiseScale);

		public static Config Instance
		{
			get
			{
				if (m_Instance == null)
				{
					m_Instance = Resources.LoadAll<Config>("")[0];
				}
				return m_Instance;
			}
		}

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
			OnRenderPipelineChanged(Instance.renderPipeline);
		}

		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
			bool enabled = BeamGeometry.isCustomRenderPipelineSupported && pipeline == RenderPipeline.SRP_4_0_0_or_higher;
			Utils.SetShaderKeywordEnabled("VLB_SRP_API", enabled);
		}

		public void Reset()
		{
			geometryOverrideLayer = true;
			geometryLayerID = 1;
			geometryTag = "Untagged";
			geometryRenderQueue = 3000;
			beamShader1Pass = Shader.Find("Hidden/VolumetricLightBeam1Pass");
			beamShader2Pass = Shader.Find("Hidden/VolumetricLightBeam2Pass");
			sharedMeshSides = 24;
			sharedMeshSegments = 5;
			globalNoiseScale = 0.5f;
			globalNoiseVelocity = Consts.NoiseVelocityDefault;
			noise3DData = Resources.Load("Noise3D_64x64x64") as TextAsset;
			noise3DSize = 64;
			dustParticlesPrefab = Resources.Load("DustParticles", typeof(ParticleSystem)) as ParticleSystem;
			renderPipeline = RenderPipeline.BuiltIn;
			renderingMode = RenderingMode.MultiPass;
		}

		public ParticleSystem NewVolumetricDustParticles()
		{
			if (!dustParticlesPrefab)
			{
				if (Application.isPlaying)
				{
					Debug.LogError("Failed to instantiate VolumetricDustParticles prefab.");
				}
				return null;
			}
			ParticleSystem particleSystem = UnityEngine.Object.Instantiate(dustParticlesPrefab);
			particleSystem.useAutoRandomSeed = false;
			particleSystem.name = "Dust Particles";
			particleSystem.gameObject.hideFlags = Consts.ProceduralObjectsHideFlags;
			particleSystem.gameObject.SetActive(value: true);
			return particleSystem;
		}

		private void OnEnable()
		{
			HandleBackwardCompatibility(pluginVersion, 1610);
			pluginVersion = 1610;
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			if (serializedVersion != newVersion)
			{
				if (serializedVersion < 1600)
				{
					renderingMode = (forceSinglePass ? RenderingMode.SinglePass : RenderingMode.MultiPass);
				}
				Utils.MarkObjectDirty(this);
			}
		}
	}
	public static class Consts
	{
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		public static readonly bool ProceduralObjectsVisibleInEditor = true;

		public static readonly UnityEngine.Color FlatColor = UnityEngine.Color.white;

		public const ColorMode ColorModeDefault = ColorMode.Flat;

		public const float IntensityDefault = 1f;

		public const float IntensityMin = 0f;

		public const float IntensityMax = 8f;

		public const float SpotAngleDefault = 35f;

		public const float SpotAngleMin = 0.1f;

		public const float SpotAngleMax = 179.9f;

		public const float ConeRadiusStart = 0.1f;

		public const MeshType GeomMeshType = MeshType.Shared;

		public const int GeomSidesDefault = 18;

		public const int GeomSidesMin = 3;

		public const int GeomSidesMax = 256;

		public const int GeomSegmentsDefault = 5;

		public const int GeomSegmentsMin = 0;

		public const int GeomSegmentsMax = 64;

		public const bool GeomCap = false;

		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		public const float AttenuationCustomBlending = 0.5f;

		public const float FadeStart = 0f;

		public const float FadeEnd = 3f;

		public const float FadeMinThreshold = 0.01f;

		public const float DepthBlendDistance = 2f;

		public const float CameraClippingDistance = 0.5f;

		public const float FresnelPowMaxValue = 10f;

		public const float FresnelPow = 8f;

		public const float GlareFrontal = 0.5f;

		public const float GlareBehind = 0.5f;

		public const float NoiseIntensityMin = 0f;

		public const float NoiseIntensityMax = 1f;

		public const float NoiseIntensityDefault = 0.5f;

		public const float NoiseScaleMin = 0.01f;

		public const float NoiseScaleMax = 2f;

		public const float NoiseScaleDefault = 0.5f;

		public static readonly Vector3 NoiseVelocityDefault = new Vector3(0.07f, 0.18f, 0.05f);

		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		public static readonly LayerMask DynOcclusionLayerMaskDefault = -1;

		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		public const int DynOcclusionWaitFrameCountDefault = 3;

		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		public const bool ConfigGeometryOverrideLayerDefault = true;

		public const int ConfigGeometryLayerIDDefault = 1;

		public const string ConfigGeometryTagDefault = "Untagged";

		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		public const int ConfigNoise3DSizeDefault = 64;

		public const int ConfigSharedMeshSides = 24;

		public const int ConfigSharedMeshSegments = 5;

		public static HideFlags ProceduralObjectsHideFlags
		{
			get
			{
				if (!ProceduralObjectsVisibleInEditor)
				{
					return HideFlags.HideAndDontSave;
				}
				return HideFlags.DontSave | HideFlags.NotEditable;
			}
		}
	}
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion/")]
	public class DynamicOcclusion : MonoBehaviour
	{
		public class HitResult
		{
			public Vector3 point;

			public Vector3 normal;

			public float distance;

			private Collider2D collider2D;

			private Collider collider3D;

			public bool hasCollider
			{
				get
				{
					if (!collider2D)
					{
						return collider3D;
					}
					return true;
				}
			}

			public HitResult(RaycastHit hit3D)
			{
				point = hit3D.point;
				normal = hit3D.normal;
				distance = hit3D.distance;
				collider3D = hit3D.collider;
				collider2D = null;
			}

			public HitResult(RaycastHit2D hit2D)
			{
				point = hit2D.point;
				normal = hit2D.normal;
				distance = hit2D.distance;
				collider2D = hit2D.collider;
				collider3D = null;
			}

			public HitResult()
			{
				point = Vector3.zero;
				normal = Vector3.zero;
				distance = 0f;
				collider2D = null;
				collider3D = null;
			}
		}

		private enum Direction
		{
			Up,
			Right,
			Down,
			Left
		}

		public OccluderDimensions dimensions;

		public LayerMask layerMask = Consts.DynOcclusionLayerMaskDefault;

		public float minOccluderArea;

		public int waitFrameCount = 3;

		public float minSurfaceRatio = 0.5f;

		public float maxSurfaceDot = 0.25f;

		public PlaneAlignment planeAlignment;

		public float planeOffset = 0.1f;

		private VolumetricLightBeam m_Master;

		private int m_FrameCountToWait;

		private float m_RangeMultiplier = 1f;

		private uint m_PrevNonSubHitDirectionId;

		private void OnValidate()
		{
			minOccluderArea = Mathf.Max(minOccluderArea, 0f);
			waitFrameCount = Mathf.Clamp(waitFrameCount, 1, 60);
		}

		private void OnEnable()
		{
			m_Master = GetComponent<VolumetricLightBeam>();
		}

		private void OnDisable()
		{
			SetHitNull();
		}

		private void Start()
		{
			if (Application.isPlaying)
			{
				TriggerZone component = GetComponent<TriggerZone>();
				if ((bool)component)
				{
					m_RangeMultiplier = Mathf.Max(1f, component.rangeMultiplier);
				}
			}
		}

		private void LateUpdate()
		{
			if (m_FrameCountToWait <= 0)
			{
				ProcessRaycasts();
				m_FrameCountToWait = waitFrameCount;
			}
			m_FrameCountToWait--;
		}

		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			float num = angleDiff * 0.5f;
			return Quaternion.Euler(UnityEngine.Random.Range(0f - num, num), UnityEngine.Random.Range(0f - num, num), UnityEngine.Random.Range(0f - num, num)) * direction;
		}

		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			if (dimensions != OccluderDimensions.Occluders2D)
			{
				return GetBestHit3D(rayPos, rayDir);
			}
			return GetBestHit2D(rayPos, rayDir);
		}

		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit[] array = Physics.RaycastAll(rayPos, rayDir, m_Master.fadeEnd * m_RangeMultiplier, layerMask.value);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].collider.isTrigger && array[i].collider.bounds.GetMaxArea2D() >= minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new HitResult(array[num]);
			}
			return new HitResult();
		}

		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			RaycastHit2D[] array = Physics2D.RaycastAll(new Vector2(rayPos.x, rayPos.y), new Vector2(rayDir.x, rayDir.y), m_Master.fadeEnd * m_RangeMultiplier, layerMask.value);
			int num = -1;
			float num2 = float.MaxValue;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].collider.isTrigger && array[i].collider.bounds.GetMaxArea2D() >= minOccluderArea && array[i].distance < num2)
				{
					num2 = array[i].distance;
					num = i;
				}
			}
			if (num != -1)
			{
				return new HitResult(array[num]);
			}
			return new HitResult();
		}

		private Vector3 GetDirection(uint dirInt)
		{
			dirInt %= (uint)Enum.GetValues(typeof(Direction)).Length;
			return dirInt switch
			{
				0u => base.transform.up, 
				1u => base.transform.right, 
				2u => -base.transform.up, 
				3u => -base.transform.right, 
				_ => Vector3.zero, 
			};
		}

		private bool IsHitValid(HitResult hit)
		{
			if (hit.hasCollider)
			{
				return Vector3.Dot(hit.normal, -base.transform.forward) >= maxSurfaceDot;
			}
			return false;
		}

		private void ProcessRaycasts()
		{
			HitResult hitResult = GetBestHit(base.transform.position, base.transform.forward);
			if (IsHitValid(hitResult))
			{
				if (minSurfaceRatio > 0.5f)
				{
					for (uint num = 0u; num < (uint)Enum.GetValues(typeof(Direction)).Length; num++)
					{
						Vector3 direction = GetDirection(num + m_PrevNonSubHitDirectionId);
						Vector3 vector = base.transform.position + direction * m_Master.coneRadiusStart * (minSurfaceRatio * 2f - 1f);
						Vector3 vector2 = base.transform.position + base.transform.forward * m_Master.fadeEnd + direction * m_Master.coneRadiusEnd * (minSurfaceRatio * 2f - 1f);
						HitResult bestHit = GetBestHit(vector, vector2 - vector);
						if (IsHitValid(bestHit))
						{
							if (bestHit.distance > hitResult.distance)
							{
								hitResult = bestHit;
							}
							continue;
						}
						m_PrevNonSubHitDirectionId = num;
						SetHitNull();
						return;
					}
				}
				SetHit(hitResult);
			}
			else
			{
				SetHitNull();
			}
		}

		private void SetHit(HitResult hit)
		{
			PlaneAlignment planeAlignment = this.planeAlignment;
			if (planeAlignment != 0 && planeAlignment == PlaneAlignment.Beam)
			{
				SetClippingPlane(new Plane(-base.transform.forward, hit.point));
			}
			else
			{
				SetClippingPlane(new Plane(hit.normal, hit.point));
			}
		}

		private void SetHitNull()
		{
			SetClippingPlaneOff();
		}

		private void SetClippingPlane(Plane planeWS)
		{
			planeWS = planeWS.TranslateCustom(planeWS.normal * planeOffset);
			m_Master.SetClippingPlane(planeWS);
		}

		private void SetClippingPlaneOff()
		{
			m_Master.SetClippingPlaneOff();
		}
	}
	public enum ColorMode
	{
		Flat,
		Gradient
	}
	public enum AttenuationEquation
	{
		Linear,
		Quadratic,
		Blend
	}
	public enum BlendingMode
	{
		Additive,
		SoftAdditive,
		TraditionalTransparency
	}
	public enum MeshType
	{
		Shared,
		Custom
	}
	public enum RenderPipeline
	{
		BuiltIn,
		SRP_4_0_0_or_higher
	}
	public enum RenderingMode
	{
		MultiPass,
		SinglePass,
		GPUInstancing
	}
	public enum RenderQueue
	{
		Custom = 0,
		Background = 1000,
		Geometry = 2000,
		AlphaTest = 2450,
		GeometryLast = 2500,
		Transparent = 3000,
		Overlay = 4000
	}
	public enum OccluderDimensions
	{
		Occluders3D,
		Occluders2D
	}
	public enum PlaneAlignment
	{
		Surface,
		Beam
	}
	public static class GlobalMesh
	{
		private static Mesh ms_Mesh;

		private static bool ms_DoubleSided;

		public static Mesh Get()
		{
			bool useSinglePassShader = Config.Instance.useSinglePassShader;
			if (ms_Mesh == null || ms_DoubleSided != useSinglePassShader)
			{
				Destroy();
				ms_Mesh = MeshGenerator.GenerateConeZ_Radius(1f, 1f, 1f, Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, cap: true, useSinglePassShader);
				ms_Mesh.hideFlags = Consts.ProceduralObjectsHideFlags;
				ms_DoubleSided = useSinglePassShader;
			}
			return ms_Mesh;
		}

		public static void Destroy()
		{
			if (ms_Mesh != null)
			{
				UnityEngine.Object.DestroyImmediate(ms_Mesh);
				ms_Mesh = null;
			}
		}
	}
	public static class GpuInstancing
	{
		public const bool isSupported = true;

		public static bool forceEnableDepthBlend => Config.Instance.actualRenderingMode == RenderingMode.GPUInstancing;

		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
			material.enableInstancing = enableInstancing;
			material.SetKeywordEnabled("VLB_GPU_INSTANCING", enableInstancing);
		}

		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			bool result = true;
			if (!CanBeBatched(beamA, ref reasons))
			{
				result = false;
			}
			if (!CanBeBatched(beamB, ref reasons))
			{
				result = false;
			}
			if (beamA.colorMode != beamB.colorMode)
			{
				AppendErrorMessage(ref reasons, "Color Mode mismatch");
				result = false;
			}
			if (beamA.blendingMode != beamB.blendingMode)
			{
				AppendErrorMessage(ref reasons, "Blending Mode mismatch");
				result = false;
			}
			if (beamA.noiseEnabled != beamB.noiseEnabled)
			{
				AppendErrorMessage(ref reasons, "3D Noise enabled mismatch");
				result = false;
			}
			if (!forceEnableDepthBlend && beamA.depthBlendDistance > 0f != beamB.depthBlendDistance > 0f)
			{
				AppendErrorMessage(ref reasons, "Opaque Geometry Blending mismatch");
				result = false;
			}
			return result;
		}

		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			bool result = true;
			if (beam.geomMeshType != 0)
			{
				AppendErrorMessage(ref reason, $"{beam.name} is not using shared mesh");
				result = false;
			}
			if ((bool)beam.GetComponent<DynamicOcclusion>())
			{
				AppendErrorMessage(ref reason, $"{beam.name}: dynamically occluded and non occluded beams cannot be batched together");
				result = false;
			}
			return result;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
			if (message != "")
			{
				message += "\n";
			}
			message = message + "- " + toAppend;
		}
	}
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
	}
	public class MaterialKeywordSRP
	{
		public const string kKeyword = "VLB_SRP_API";
	}
	public static class MaterialManager
	{
		public enum BlendingMode
		{
			Additive,
			SoftAdditive,
			TraditionalTransparency,
			Count
		}

		public enum Noise3D
		{
			Off,
			On,
			Count
		}

		public enum DepthBlend
		{
			Off,
			On,
			Count
		}

		public enum ColorGradient
		{
			Off,
			MatrixLow,
			MatrixHigh,
			Count
		}

		public enum ClippingPlane
		{
			Off,
			On,
			Count
		}

		public class StaticProperties
		{
			public BlendingMode blendingMode;

			public Noise3D noise3D;

			public DepthBlend depthBlend;

			public ColorGradient colorGradient;

			public ClippingPlane clippingPlane;

			public int materialID => (int)((int)((int)((int)((int)blendingMode * 2 + noise3D) * 2 + depthBlend) * 3 + colorGradient) * 2 + clippingPlane);

			public void ApplyToMaterial(Material mat)
			{
				mat.SetKeywordEnabled("VLB_ALPHA_AS_BLACK", BlendingMode_AlphaAsBlack[(int)blendingMode]);
				mat.SetInt("_BlendSrcFactor", (int)BlendingMode_SrcFactor[(int)blendingMode]);
				mat.SetInt("_BlendDstFactor", (int)BlendingMode_DstFactor[(int)blendingMode]);
				mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_LOW", colorGradient == ColorGradient.MatrixLow);
				mat.SetKeywordEnabled("VLB_COLOR_GRADIENT_MATRIX_HIGH", colorGradient == ColorGradient.MatrixHigh);
				mat.SetKeywordEnabled("VLB_DEPTH_BLEND", depthBlend == DepthBlend.On);
				mat.SetKeywordEnabled("VLB_NOISE_3D", noise3D == Noise3D.On);
				mat.SetKeywordEnabled("VLB_CLIPPING_PLANE", clippingPlane == ClippingPlane.On);
			}
		}

		private class MaterialsGroup
		{
			public Material[] materials = new Material[kStaticPropertiesCount];
		}

		public static MaterialPropertyBlock materialPropertyBlock = new MaterialPropertyBlock();

		private static readonly BlendMode[] BlendingMode_SrcFactor = new BlendMode[3]
		{
			BlendMode.One,
			BlendMode.OneMinusDstColor,
			BlendMode.SrcAlpha
		};

		private static readonly BlendMode[] BlendingMode_DstFactor = new BlendMode[3]
		{
			BlendMode.One,
			BlendMode.One,
			BlendMode.OneMinusSrcAlpha
		};

		private static readonly bool[] BlendingMode_AlphaAsBlack = new bool[3] { true, true, false };

		private static int kStaticPropertiesCount = 72;

		private static Hashtable ms_MaterialsGroup = new Hashtable(1);

		public static Material NewMaterial(bool gpuInstanced)
		{
			Shader beamShader = Config.Instance.beamShader;
			if (!beamShader)
			{
				Debug.LogError("Invalid Beam Shader set in VLB Config");
				return null;
			}
			Material obj = new Material(beamShader)
			{
				hideFlags = Consts.ProceduralObjectsHideFlags,
				renderQueue = Config.Instance.geometryRenderQueue
			};
			GpuInstancing.SetMaterialProperties(obj, gpuInstanced);
			return obj;
		}

		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			MaterialsGroup materialsGroup = (MaterialsGroup)ms_MaterialsGroup[groupID];
			if (materialsGroup == null)
			{
				materialsGroup = new MaterialsGroup();
				ms_MaterialsGroup[groupID] = materialsGroup;
			}
			int materialID = staticProps.materialID;
			Material material = materialsGroup.materials[materialID];
			if (material == null)
			{
				material = NewMaterial(gpuInstanced: true);
				if ((bool)material)
				{
					materialsGroup.materials[materialID] = material;
					staticProps.ApplyToMaterial(material);
				}
			}
			return material;
		}
	}
	public static class MeshGenerator
	{
		private const float kMinTruncatedRadius = 0.001f;

		private static float GetAngleOffset(int numSides)
		{
			if (numSides != 4)
			{
				return 0f;
			}
			return (float)Math.PI / 4f;
		}

		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			float radiusEnd = lengthZ * Mathf.Tan(coneAngle * ((float)Math.PI / 180f) * 0.5f);
			return GenerateConeZ_Radius(lengthZ, radiusStart, radiusEnd, numSides, numSegments, cap, doubleSided);
		}

		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return GenerateConeZ_RadiusAndAngle(lengthZ, 0f, coneAngle, numSides, numSegments, cap, doubleSided);
		}

		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			Mesh mesh = new Mesh();
			bool flag = false;
			flag = cap && radiusStart > 0f;
			radiusStart = Mathf.Max(radiusStart, 0.001f);
			int num = numSides * (numSegments + 2);
			int num2 = num;
			if (flag)
			{
				num2 += numSides + 1;
			}
			float angleOffset = GetAngleOffset(numSides);
			Vector3[] array = new Vector3[num2];
			for (int i = 0; i < numSides; i++)
			{
				float f = angleOffset + (float)Math.PI * 2f * (float)i / (float)numSides;
				float num3 = Mathf.Cos(f);
				float num4 = Mathf.Sin(f);
				for (int j = 0; j < numSegments + 2; j++)
				{
					float num5 = (float)j / (float)(numSegments + 1);
					float num6 = Mathf.Lerp(radiusStart, radiusEnd, num5);
					array[i + j * numSides] = new Vector3(num6 * num3, num6 * num4, num5 * lengthZ);
				}
			}
			if (flag)
			{
				int num7 = num;
				array[num7] = Vector3.zero;
				num7++;
				for (int k = 0; k < numSides; k++)
				{
					float f2 = angleOffset + (float)Math.PI * 2f * (float)k / (float)numSides;
					float num8 = Mathf.Cos(f2);
					float num9 = Mathf.Sin(f2);
					array[num7] = new Vector3(radiusStart * num8, radiusStart * num9, 0f);
					num7++;
				}
			}
			if (!doubleSided)
			{
				mesh.vertices = array;
			}
			else
			{
				Vector3[] array2 = new Vector3[array.Length * 2];
				array.CopyTo(array2, 0);
				array.CopyTo(array2, array.Length);
				mesh.vertices = array2;
			}
			Vector2[] array3 = new Vector2[num2];
			int num10 = 0;
			for (int l = 0; l < num; l++)
			{
				array3[num10++] = Vector2.zero;
			}
			if (flag)
			{
				for (int m = 0; m < numSides + 1; m++)
				{
					array3[num10++] = new Vector2(1f, 0f);
				}
			}
			if (!doubleSided)
			{
				mesh.uv = array3;
			}
			else
			{
				Vector2[] array4 = new Vector2[array3.Length * 2];
				array3.CopyTo(array4, 0);
				array3.CopyTo(array4, array3.Length);
				for (int n = 0; n < array3.Length; n++)
				{
					Vector2 vector = array4[n + array3.Length];
					array4[n + array3.Length] = new Vector2(vector.x, 1f);
				}
				mesh.uv = array4;
			}
			int num11 = numSides * 2 * Mathf.Max(numSegments + 1, 1) * 3;
			if (flag)
			{
				num11 += numSides * 3;
			}
			int[] array5 = new int[num11];
			int num12 = 0;
			for (int num13 = 0; num13 < numSides; num13++)
			{
				int num14 = num13 + 1;
				if (num14 == numSides)
				{
					num14 = 0;
				}
				for (int num15 = 0; num15 < numSegments + 1; num15++)
				{
					int num16 = num15 * numSides;
					array5[num12++] = num16 + num13;
					array5[num12++] = num16 + num14;
					array5[num12++] = num16 + num13 + numSides;
					array5[num12++] = num16 + num14 + numSides;
					array5[num12++] = num16 + num13 + numSides;
					array5[num12++] = num16 + num14;
				}
			}
			if (flag)
			{
				for (int num17 = 0; num17 < numSides - 1; num17++)
				{
					array5[num12++] = num;
					array5[num12++] = num + num17 + 2;
					array5[num12++] = num + num17 + 1;
				}
				array5[num12++] = num;
				array5[num12++] = num + 1;
				array5[num12++] = num + numSides;
			}
			if (!doubleSided)
			{
				mesh.triangles = array5;
			}
			else
			{
				int[] array6 = new int[array5.Length * 2];
				array5.CopyTo(array6, 0);
				for (int num18 = 0; num18 < array5.Length; num18 += 3)
				{
					array6[array5.Length + num18] = array5[num18] + num2;
					array6[array5.Length + num18 + 1] = array5[num18 + 2] + num2;
					array6[array5.Length + num18 + 2] = array5[num18 + 1] + num2;
				}
				mesh.triangles = array6;
			}
			Bounds bounds = new Bounds(new Vector3(0f, 0f, lengthZ * 0.5f), new Vector3(Mathf.Max(radiusStart, radiusEnd) * 2f, Mathf.Max(radiusStart, radiusEnd) * 2f, lengthZ));
			mesh.bounds = bounds;
			return mesh;
		}

		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			int num = numSides * (numSegments + 2);
			if (geomCap)
			{
				num += numSides + 1;
			}
			if (doubleSided)
			{
				num *= 2;
			}
			return num;
		}

		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			int num = numSides * (numSegments + 1) * 2 * 3;
			if (geomCap)
			{
				num += numSides * 3;
			}
			if (doubleSided)
			{
				num *= 2;
			}
			return num;
		}

		public static int GetSharedMeshVertexCount()
		{
			return GetVertexCount(Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, geomCap: true, Config.Instance.useSinglePassShader);
		}

		public static int GetSharedMeshIndicesCount()
		{
			return GetIndicesCount(Config.Instance.sharedMeshSides, Config.Instance.sharedMeshSegments, geomCap: true, Config.Instance.useSinglePassShader);
		}
	}
	public static class Noise3D
	{
		private static bool ms_IsSupportedChecked;

		private static bool ms_IsSupported;

		private static Texture3D ms_NoiseTexture;

		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		private const int kMinShaderLevel = 35;

		public static bool isSupported
		{
			get
			{
				if (!ms_IsSupportedChecked)
				{
					ms_IsSupported = SystemInfo.graphicsShaderLevel >= 35;
					if (!ms_IsSupported)
					{
						Debug.LogWarning(isNotSupportedString);
					}
					ms_IsSupportedChecked = true;
				}
				return ms_IsSupported;
			}
		}

		public static bool isProperlyLoaded => ms_NoiseTexture != null;

		public static string isNotSupportedString => $"3D Noise requires higher shader capabilities (Shader Model 3.5 / OpenGL ES 3.0), which are not available on the current platform: graphicsShaderLevel (current/required) = {SystemInfo.graphicsShaderLevel} / {35}";

		[RuntimeInitializeOnLoadMethod]
		private static void OnStartUp()
		{
			LoadIfNeeded();
		}

		public static void LoadIfNeeded()
		{
			if (!isSupported)
			{
				return;
			}
			if (ms_NoiseTexture == null)
			{
				ms_NoiseTexture = LoadTexture3D(Config.Instance.noise3DData, Config.Instance.noise3DSize);
				if ((bool)ms_NoiseTexture)
				{
					ms_NoiseTexture.hideFlags = HideFlags.HideAndDontSave;
				}
			}
			Shader.SetGlobalTexture("_VLB_NoiseTex3D", ms_NoiseTexture);
			Shader.SetGlobalVector("_VLB_NoiseGlobal", Config.Instance.globalNoiseParam);
		}

		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			if (textData == null)
			{
				Debug.LogErrorFormat("Fail to open Noise 3D Data");
				return null;
			}
			byte[] bytes = textData.bytes;
			int num = Mathf.Max(0, size * size * size);
			if (bytes.Length != num)
			{
				Debug.LogErrorFormat("Noise 3D Data file has not the proper size {0}x{0}x{0}", size);
				return null;
			}
			Texture3D texture3D = new Texture3D(size, size, size, TextureFormat.Alpha8, mipChain: false);
			UnityEngine.Color[] array = new UnityEngine.Color[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = new Color32(0, 0, 0, bytes[i]);
			}
			texture3D.SetPixels(array);
			texture3D.Apply();
			return texture3D;
		}
	}
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		public bool setIsTrigger = true;

		public float rangeMultiplier = 1f;

		private const int kMeshColliderNumSides = 8;

		private Mesh m_Mesh;

		private void Update()
		{
			VolumetricLightBeam component = GetComponent<VolumetricLightBeam>();
			if ((bool)component)
			{
				MeshCollider orAddComponent = base.gameObject.GetOrAddComponent<MeshCollider>();
				float lengthZ = component.fadeEnd * rangeMultiplier;
				float radiusEnd = Mathf.LerpUnclamped(component.coneRadiusStart, component.coneRadiusEnd, rangeMultiplier);
				m_Mesh = MeshGenerator.GenerateConeZ_Radius(lengthZ, component.coneRadiusStart, radiusEnd, 8, 0, cap: false, doubleSided: false);
				m_Mesh.hideFlags = Consts.ProceduralObjectsHideFlags;
				orAddComponent.sharedMesh = m_Mesh;
				if (setIsTrigger)
				{
					orAddComponent.convex = true;
					orAddComponent.isTrigger = true;
				}
				UnityEngine.Object.Destroy(this);
			}
		}
	}
	public static class Utils
	{
		public enum FloatPackingPrecision
		{
			High = 64,
			Low = 8,
			Undef = 0
		}

		private static FloatPackingPrecision ms_FloatPackingPrecision;

		private const int kFloatPackingHighMinShaderLevel = 35;

		public static string GetPath(Transform current)
		{
			if (current.parent == null)
			{
				return "/" + current.name;
			}
			return GetPath(current.parent) + "/" + current.name;
		}

		public static T NewWithComponent<T>(string name) where T : Component
		{
			return new GameObject(name, typeof(T)).GetComponent<T>();
		}

		public static T GetOrAddComponent<T>(this GameObject self) where T : Component
		{
			T val = self.GetComponent<T>();
			if (val == null)
			{
				val = self.AddComponent<T>();
			}
			return val;
		}

		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : Component
		{
			return self.gameObject.GetOrAddComponent<T>();
		}

		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return ((int)(object)mask & (int)(object)flags) == (int)(object)flags;
		}

		public static Vector2 xy(this Vector3 aVector)
		{
			return new Vector2(aVector.x, aVector.y);
		}

		public static Vector2 xz(this Vector3 aVector)
		{
			return new Vector2(aVector.x, aVector.z);
		}

		public static Vector2 yz(this Vector3 aVector)
		{
			return new Vector2(aVector.y, aVector.z);
		}

		public static Vector2 yx(this Vector3 aVector)
		{
			return new Vector2(aVector.y, aVector.x);
		}

		public static Vector2 zx(this Vector3 aVector)
		{
			return new Vector2(aVector.z, aVector.x);
		}

		public static Vector2 zy(this Vector3 aVector)
		{
			return new Vector2(aVector.z, aVector.y);
		}

		public static float GetVolumeCubic(this Bounds self)
		{
			return self.size.x * self.size.y * self.size.z;
		}

		public static float GetMaxArea2D(this Bounds self)
		{
			return Mathf.Max(Mathf.Max(self.size.x * self.size.y, self.size.y * self.size.z), self.size.x * self.size.z);
		}

		public static UnityEngine.Color Opaque(this UnityEngine.Color self)
		{
			return new UnityEngine.Color(self.r, self.g, self.b, 1f);
		}

		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, UnityEngine.Color color, float size = 1f)
		{
			Vector3 vector = Vector3.Cross(normal, (Mathf.Abs(Vector3.Dot(normal, Vector3.forward)) < 0.999f) ? Vector3.forward : Vector3.up).normalized * size;
			Vector3 vector2 = position + vector;
			Vector3 vector3 = position - vector;
			vector = Quaternion.AngleAxis(90f, normal) * vector;
			Vector3 vector4 = position + vector;
			Vector3 vector5 = position - vector;
			Gizmos.matrix = Matrix4x4.identity;
			Gizmos.color = color;
			Gizmos.DrawLine(vector2, vector3);
			Gizmos.DrawLine(vector4, vector5);
			Gizmos.DrawLine(vector2, vector4);
			Gizmos.DrawLine(vector4, vector3);
			Gizmos.DrawLine(vector3, vector5);
			Gizmos.DrawLine(vector5, vector2);
		}

		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			plane.distance += Vector3.Dot(translation.normalized, plane.normal) * translation.magnitude;
			return plane;
		}

		public static bool IsValid(this Plane plane)
		{
			return plane.normal.sqrMagnitude > 0.5f;
		}

		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
			if (enabled)
			{
				mat.EnableKeyword(name);
			}
			else
			{
				mat.DisableKeyword(name);
			}
		}

		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
			if (enabled)
			{
				Shader.EnableKeyword(name);
			}
			else
			{
				Shader.DisableKeyword(name);
			}
		}

		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			Matrix4x4 result = default(Matrix4x4);
			for (int i = 0; i < 16; i++)
			{
				UnityEngine.Color color = self.Evaluate(Mathf.Clamp01((float)i / 15f));
				result[i] = color.PackToFloat(floatPackingPrecision);
			}
			return result;
		}

		public static UnityEngine.Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			UnityEngine.Color[] array = new UnityEngine.Color[samplesCount];
			for (int i = 0; i < samplesCount; i++)
			{
				array[i] = self.Evaluate(Mathf.Clamp01((float)i / (float)(samplesCount - 1)));
			}
			return array;
		}

		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return new Vector4(Mathf.Floor(vec.x), Mathf.Floor(vec.y), Mathf.Floor(vec.z), Mathf.Floor(vec.w));
		}

		public static float PackToFloat(this UnityEngine.Color color, int floatPackingPrecision)
		{
			Vector4 vector = Vector4_Floor(color * (floatPackingPrecision - 1));
			return 0f + vector.x * (float)floatPackingPrecision * (float)floatPackingPrecision * (float)floatPackingPrecision + vector.y * (float)floatPackingPrecision * (float)floatPackingPrecision + vector.z * (float)floatPackingPrecision + vector.w;
		}

		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			if (ms_FloatPackingPrecision == FloatPackingPrecision.Undef)
			{
				ms_FloatPackingPrecision = ((SystemInfo.graphicsShaderLevel >= 35) ? FloatPackingPrecision.High : FloatPackingPrecision.Low);
			}
			return ms_FloatPackingPrecision;
		}

		public static void MarkCurrentSceneDirty()
		{
		}

		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	public static class Version
	{
		public const int Current = 1610;
	}
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeam))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		public enum Direction
		{
			Beam,
			Random
		}

		[Range(0f, 1f)]
		public float alpha = 0.5f;

		[Range(0.0001f, 0.1f)]
		public float size = 0.01f;

		public Direction direction = Direction.Random;

		public float speed = 0.03f;

		public float density = 5f;

		[Range(0f, 1f)]
		public float spawnMaxDistance = 0.7f;

		public bool cullingEnabled = true;

		public float cullingMaxDistance = 10f;

		public static bool isFeatureSupported = true;

		private ParticleSystem m_Particles;

		private ParticleSystemRenderer m_Renderer;

		private static bool ms_NoMainCameraLogged = false;

		private static Camera ms_MainCamera = null;

		private VolumetricLightBeam m_Master;

		public bool isCulled { get; private set; }

		public bool particlesAreInstantiated => m_Particles;

		public int particlesCurrentCount
		{
			get
			{
				if (!m_Particles)
				{
					return 0;
				}
				return m_Particles.particleCount;
			}
		}

		public int particlesMaxCount
		{
			get
			{
				if (!m_Particles)
				{
					return 0;
				}
				return m_Particles.main.maxParticles;
			}
		}

		public Camera mainCamera
		{
			get
			{
				if (!ms_MainCamera)
				{
					ms_MainCamera = Camera.main;
					if (!ms_MainCamera && !ms_NoMainCameraLogged)
					{
						Debug.LogErrorFormat(base.gameObject, "In order to use 'VolumetricDustParticles' culling, you must have a MainCamera defined in your scene.");
						ms_NoMainCameraLogged = true;
					}
				}
				return ms_MainCamera;
			}
		}

		private void Start()
		{
			isCulled = false;
			m_Master = GetComponent<VolumetricLightBeam>();
			InstantiateParticleSystem();
			SetActiveAndPlay();
		}

		private void InstantiateParticleSystem()
		{
			ParticleSystem[] componentsInChildren = GetComponentsInChildren<ParticleSystem>(includeInactive: true);
			for (int num = componentsInChildren.Length - 1; num >= 0; num--)
			{
				UnityEngine.Object.DestroyImmediate(componentsInChildren[num].gameObject);
			}
			m_Particles = Config.Instance.NewVolumetricDustParticles();
			if ((bool)m_Particles)
			{
				m_Particles.transform.SetParent(base.transform, worldPositionStays: false);
				m_Renderer = m_Particles.GetComponent<ParticleSystemRenderer>();
			}
		}

		private void OnEnable()
		{
			SetActiveAndPlay();
		}

		private void SetActiveAndPlay()
		{
			if ((bool)m_Particles)
			{
				m_Particles.gameObject.SetActive(value: true);
				SetParticleProperties();
				m_Particles.Play(withChildren: true);
			}
		}

		private void OnDisable()
		{
			if ((bool)m_Particles)
			{
				m_Particles.gameObject.SetActive(value: false);
			}
		}

		private void OnDestroy()
		{
			if ((bool)m_Particles)
			{
				UnityEngine.Object.DestroyImmediate(m_Particles.gameObject);
			}
			m_Particles = null;
		}

		private void Update()
		{
			if (Application.isPlaying)
			{
				UpdateCulling();
			}
			SetParticleProperties();
		}

		private void SetParticleProperties()
		{
			if (!m_Particles || !m_Particles.gameObject.activeSelf)
			{
				return;
			}
			float t = Mathf.Clamp01(1f - m_Master.fresnelPow / 10f);
			float num = m_Master.fadeEnd * spawnMaxDistance;
			float num2 = num * density;
			int maxParticles = (int)(num2 * 4f);
			ParticleSystem.MainModule main = m_Particles.main;
			ParticleSystem.MinMaxCurve startLifetime = main.startLifetime;
			startLifetime.mode = ParticleSystemCurveMode.TwoConstants;
			startLifetime.constantMin = 4f;
			startLifetime.constantMax = 6f;
			main.startLifetime = startLifetime;
			ParticleSystem.MinMaxCurve startSize = main.startSize;
			startSize.mode = ParticleSystemCurveMode.TwoConstants;
			startSize.constantMin = size * 0.9f;
			startSize.constantMax = size * 1.1f;
			main.startSize = startSize;
			ParticleSystem.MinMaxGradient startColor = main.startColor;
			if (m_Master.colorMode == ColorMode.Flat)
			{
				startColor.mode = ParticleSystemGradientMode.Color;
				UnityEngine.Color color = m_Master.color;
				color.a *= alpha;
				startColor.color = color;
			}
			else
			{
				startColor.mode = ParticleSystemGradientMode.Gradient;
				Gradient colorGradient = m_Master.colorGradient;
				GradientColorKey[] colorKeys = colorGradient.colorKeys;
				GradientAlphaKey[] alphaKeys = colorGradient.alphaKeys;
				for (int i = 0; i < alphaKeys.Length; i++)
				{
					alphaKeys[i].alpha *= alpha;
				}
				Gradient gradient = new Gradient();
				gradient.SetKeys(colorKeys, alphaKeys);
				startColor.gradient = gradient;
			}
			main.startColor = startColor;
			ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
			startSpeed.constant = speed;
			main.startSpeed = startSpeed;
			main.maxParticles = maxParticles;
			ParticleSystem.ShapeModule shape = m_Particles.shape;
			shape.shapeType = ParticleSystemShapeType.ConeVolume;
			shape.radius = m_Master.coneRadiusStart * Mathf.Lerp(0.3f, 1f, t);
			shape.angle = m_Master.coneAngle * 0.5f * Mathf.Lerp(0.7f, 1f, t);
			shape.length = num;
			shape.arc = 360f;
			shape.randomDirectionAmount = ((direction == Direction.Random) ? 1f : 0f);
			ParticleSystem.EmissionModule emission = m_Particles.emission;
			ParticleSystem.MinMaxCurve rateOverTime = emission.rateOverTime;
			rateOverTime.constant = num2;
			emission.rateOverTime = rateOverTime;
			if ((bool)m_Renderer)
			{
				m_Renderer.sortingLayerID = m_Master.sortingLayerID;
				m_Renderer.sortingOrder = m_Master.sortingOrder;
			}
		}

		private void UpdateCulling()
		{
			if (!m_Particles)
			{
				return;
			}
			bool flag = true;
			if (cullingEnabled && m_Master.hasGeometry)
			{
				if ((bool)mainCamera)
				{
					float num = cullingMaxDistance * cullingMaxDistance;
					flag = m_Master.bounds.SqrDistance(mainCamera.transform.position) <= num;
				}
				else
				{
					cullingEnabled = false;
				}
			}
			if (m_Particles.gameObject.activeSelf != flag)
			{
				m_Particles.gameObject.SetActive(flag);
				isCulled = !flag;
			}
			if (flag && !m_Particles.isPlaying)
			{
				m_Particles.Play();
			}
		}
	}
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
	public class VolumetricLightBeam : MonoBehaviour
	{
		public bool colorFromLight = true;

		public ColorMode colorMode;

		[ColorUsage(true, true)]
		[FormerlySerializedAs("colorValue")]
		public UnityEngine.Color color = Consts.FlatColor;

		public Gradient colorGradient;

		public bool intensityFromLight = true;

		public bool intensityModeAdvanced;

		[FormerlySerializedAs("alphaInside")]
		[Range(0f, 8f)]
		public float intensityInside = 1f;

		[FormerlySerializedAs("alphaOutside")]
		[FormerlySerializedAs("alpha")]
		[Range(0f, 8f)]
		public float intensityOutside = 1f;

		public BlendingMode blendingMode;

		[FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight = true;

		[Range(0.1f, 179.9f)]
		public float spotAngle = 35f;

		[FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart = 0.1f;

		public MeshType geomMeshType;

		[FormerlySerializedAs("geomSides")]
		public int geomCustomSides = 18;

		public int geomCustomSegments = 5;

		public bool geomCap;

		public bool fadeEndFromLight = true;

		public AttenuationEquation attenuationEquation = AttenuationEquation.Quadratic;

		[Range(0f, 1f)]
		public float attenuationCustomBlending = 0.5f;

		public float fadeStart;

		public float fadeEnd = 3f;

		public float depthBlendDistance = 2f;

		public float cameraClippingDistance = 0.5f;

		[Range(0f, 1f)]
		public float glareFrontal = 0.5f;

		[Range(0f, 1f)]
		public float glareBehind = 0.5f;

		[Obsolete("Use 'glareFrontal' instead")]
		public float boostDistanceInside = 0.5f;

		[Obsolete("This property has been merged with 'fresnelPow'")]
		public float fresnelPowInside = 6f;

		[FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow = 8f;

		public bool noiseEnabled;

		[Range(0f, 1f)]
		public float noiseIntensity = 0.5f;

		public bool noiseScaleUseGlobal = true;

		[Range(0.01f, 2f)]
		public float noiseScaleLocal = 0.5f;

		public bool noiseVelocityUseGlobal = true;

		public Vector3 noiseVelocityLocal = Consts.NoiseVelocityDefault;

		private Plane m_PlaneWS;

		[SerializeField]
		private int pluginVersion = -1;

		[FormerlySerializedAs("trackChangesDuringPlaytime")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[SerializeField]
		private int _SortingLayerID;

		[SerializeField]
		private int _SortingOrder;

		private BeamGeometry m_BeamGeom;

		private Coroutine m_CoPlaytimeUpdate;

		private Light _CachedLight;

		[Obsolete("Use 'intensitySimple' or 'intensityInside' instead")]
		public float alphaInside
		{
			get
			{
				return intensityInside;
			}
			set
			{
				intensityInside = value;
			}
		}

		[Obsolete("Use 'intensitySimple' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			get
			{
				return intensityOutside;
			}
			set
			{
				intensityOutside = value;
			}
		}

		public float intensityGlobal
		{
			get
			{
				return intensityOutside;
			}
			set
			{
				intensityInside = value;
				intensityOutside = value;
			}
		}

		public float coneAngle => Mathf.Atan2(coneRadiusEnd - coneRadiusStart, fadeEnd) * 57.29578f * 2f;

		public float coneRadiusEnd => fadeEnd * Mathf.Tan(spotAngle * ((float)Math.PI / 180f) * 0.5f);

		public float coneVolume
		{
			get
			{
				float num = coneRadiusStart;
				float num2 = coneRadiusEnd;
				return (float)Math.PI / 3f * (num * num + num * num2 + num2 * num2) * fadeEnd;
			}
		}

		public float coneApexOffsetZ
		{
			get
			{
				float num = coneRadiusStart / coneRadiusEnd;
				if (num != 1f)
				{
					return fadeEnd * num / (1f - num);
				}
				return float.MaxValue;
			}
		}

		public int geomSides
		{
			get
			{
				if (geomMeshType != MeshType.Custom)
				{
					return Config.Instance.sharedMeshSides;
				}
				return geomCustomSides;
			}
			set
			{
				geomCustomSides = value;
				Debug.LogWarning("The setter VLB.VolumetricLightBeam.geomSides is OBSOLETE and has been renamed to geomCustomSides.");
			}
		}

		public int geomSegments
		{
			get
			{
				if (geomMeshType != MeshType.Custom)
				{
					return Config.Instance.sharedMeshSegments;
				}
				return geomCustomSegments;
			}
			set
			{
				geomCustomSegments = value;
				Debug.LogWarning("The setter VLB.VolumetricLightBeam.geomSegments is OBSOLETE and has been renamed to geomCustomSegments.");
			}
		}

		public float attenuationLerpLinearQuad
		{
			get
			{
				if (attenuationEquation == AttenuationEquation.Linear)
				{
					return 0f;
				}
				if (attenuationEquation == AttenuationEquation.Quadratic)
				{
					return 1f;
				}
				return attenuationCustomBlending;
			}
		}

		public int sortingLayerID
		{
			get
			{
				return _SortingLayerID;
			}
			set
			{
				_SortingLayerID = value;
				if ((bool)m_BeamGeom)
				{
					m_BeamGeom.sortingLayerID = value;
				}
			}
		}

		public string sortingLayerName
		{
			get
			{
				return SortingLayer.IDToName(sortingLayerID);
			}
			set
			{
				sortingLayerID = SortingLayer.NameToID(value);
			}
		}

		public int sortingOrder
		{
			get
			{
				return _SortingOrder;
			}
			set
			{
				_SortingOrder = value;
				if ((bool)m_BeamGeom)
				{
					m_BeamGeom.sortingOrder = value;
				}
			}
		}

		public bool trackChangesDuringPlaytime
		{
			get
			{
				return _TrackChangesDuringPlaytime;
			}
			set
			{
				_TrackChangesDuringPlaytime = value;
				StartPlaytimeUpdateIfNeeded();
			}
		}

		public bool isCurrentlyTrackingChanges => m_CoPlaytimeUpdate != null;

		public bool hasGeometry => m_BeamGeom != null;

		public Bounds bounds
		{
			get
			{
				if (!(m_BeamGeom != null))
				{
					return new Bounds(Vector3.zero, Vector3.zero);
				}
				return m_BeamGeom.meshRenderer.bounds;
			}
		}

		public int blendingModeAsInt => Mathf.Clamp((int)blendingMode, 0, Enum.GetValues(typeof(BlendingMode)).Length);

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public string meshStats
		{
			get
			{
				Mesh mesh = (m_BeamGeom ? m_BeamGeom.coneMesh : null);
				if ((bool)mesh)
				{
					return $"Cone angle: {coneAngle:0.0} degrees\nMesh: {mesh.vertexCount} vertices, {mesh.triangles.Length / 3} triangles";
				}
				return "no mesh available";
			}
		}

		public int meshVerticesCount
		{
			get
			{
				if (!m_BeamGeom || !m_BeamGeom.coneMesh)
				{
					return 0;
				}
				return m_BeamGeom.coneMesh.vertexCount;
			}
		}

		public int meshTrianglesCount
		{
			get
			{
				if (!m_BeamGeom || !m_BeamGeom.coneMesh)
				{
					return 0;
				}
				return m_BeamGeom.coneMesh.triangles.Length / 3;
			}
		}

		private Light lightSpotAttached
		{
			get
			{
				if (_CachedLight == null)
				{
					_CachedLight = GetComponent<Light>();
				}
				if ((bool)_CachedLight && _CachedLight.type == LightType.Spot)
				{
					return _CachedLight;
				}
				return null;
			}
		}

		public void SetClippingPlane(Plane planeWS)
		{
			if ((bool)m_BeamGeom)
			{
				m_BeamGeom.SetClippingPlane(planeWS);
			}
			m_PlaneWS = planeWS;
		}

		public void SetClippingPlaneOff()
		{
			if ((bool)m_BeamGeom)
			{
				m_BeamGeom.SetClippingPlaneOff();
			}
			m_PlaneWS = default(Plane);
		}

		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			if (!m_PlaneWS.IsValid())
			{
				return false;
			}
			return !GeometryUtility.TestPlanesAABB(new Plane[1] { m_PlaneWS }, collider.bounds);
		}

		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return GetInsideBeamFactorFromObjectSpacePos(base.transform.InverseTransformPoint(posWS));
		}

		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			if (posOS.z < 0f)
			{
				return -1f;
			}
			Vector2 normalized = new Vector2(posOS.xy().magnitude, posOS.z + coneApexOffsetZ).normalized;
			return Mathf.Clamp((Mathf.Abs(Mathf.Sin(coneAngle * ((float)Math.PI / 180f) / 2f)) - Mathf.Abs(normalized.x)) / 0.1f, -1f, 1f);
		}

		[Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
			GenerateGeometry();
		}

		public virtual void GenerateGeometry()
		{
			HandleBackwardCompatibility(pluginVersion, 1610);
			pluginVersion = 1610;
			ValidateProperties();
			if (m_BeamGeom == null)
			{
				m_BeamGeom = Utils.NewWithComponent<BeamGeometry>("Beam Geometry");
				m_BeamGeom.Initialize(this);
			}
			m_BeamGeom.RegenerateMesh();
			m_BeamGeom.visible = base.enabled;
		}

		public virtual void UpdateAfterManualPropertyChange()
		{
			ValidateProperties();
			if ((bool)m_BeamGeom)
			{
				m_BeamGeom.UpdateMaterialAndBounds();
			}
		}

		private void Start()
		{
			GenerateGeometry();
		}

		private void OnEnable()
		{
			if ((bool)m_BeamGeom)
			{
				m_BeamGeom.visible = true;
			}
			StartPlaytimeUpdateIfNeeded();
		}

		private void OnDisable()
		{
			if ((bool)m_BeamGeom)
			{
				m_BeamGeom.visible = false;
			}
			m_CoPlaytimeUpdate = null;
		}

		private void StartPlaytimeUpdateIfNeeded()
		{
			if (Application.isPlaying && trackChangesDuringPlaytime && m_CoPlaytimeUpdate == null)
			{
				m_CoPlaytimeUpdate = StartCoroutine(CoPlaytimeUpdate());
			}
		}

		private IEnumerator CoPlaytimeUpdate()
		{
			while (trackChangesDuringPlaytime && base.enabled)
			{
				UpdateAfterManualPropertyChange();
				yield return null;
			}
			m_CoPlaytimeUpdate = null;
		}

		private void OnDestroy()
		{
			DestroyBeam();
		}

		private void DestroyBeam()
		{
			if ((bool)m_BeamGeom)
			{
				UnityEngine.Object.DestroyImmediate(m_BeamGeom.gameObject);
			}
			m_BeamGeom = null;
		}

		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
			if ((bool)lightSpot && lightSpot.type == LightType.Spot)
			{
				if (intensityFromLight)
				{
					intensityModeAdvanced = false;
					intensityGlobal = lightSpot.intensity;
				}
				if (fadeEndFromLight)
				{
					fadeEnd = lightSpot.range;
				}
				if (spotAngleFromLight)
				{
					spotAngle = lightSpot.spotAngle;
				}
				if (colorFromLight)
				{
					colorMode = ColorMode.Flat;
					color = lightSpot.color;
				}
			}
		}

		private void ClampProperties()
		{
			intensityInside = Mathf.Clamp(intensityInside, 0f, 8f);
			intensityOutside = Mathf.Clamp(intensityOutside, 0f, 8f);
			attenuationCustomBlending = Mathf.Clamp01(attenuationCustomBlending);
			fadeEnd = Mathf.Max(0.01f, fadeEnd);
			fadeStart = Mathf.Clamp(fadeStart, 0f, fadeEnd - 0.01f);
			spotAngle = Mathf.Clamp(spotAngle, 0.1f, 179.9f);
			coneRadiusStart = Mathf.Max(coneRadiusStart, 0f);
			depthBlendDistance = Mathf.Max(depthBlendDistance, 0f);
			cameraClippingDistance = Mathf.Max(cameraClippingDistance, 0f);
			geomCustomSides = Mathf.Clamp(geomCustomSides, 3, 256);
			geomCustomSegments = Mathf.Clamp(geomCustomSegments, 0, 64);
			fresnelPow = Mathf.Max(0f, fresnelPow);
			glareBehind = Mathf.Clamp01(glareBehind);
			glareFrontal = Mathf.Clamp01(glareFrontal);
			noiseIntensity = Mathf.Clamp(noiseIntensity, 0f, 1f);
		}

		private void ValidateProperties()
		{
			AssignPropertiesFromSpotLight(lightSpotAttached);
			ClampProperties();
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
			if (serializedVersion != -1 && serializedVersion != newVersion)
			{
				if (serializedVersion < 1301)
				{
					attenuationEquation = AttenuationEquation.Linear;
				}
				if (serializedVersion < 1501)
				{
					geomMeshType = MeshType.Custom;
					geomCustomSegments = 5;
				}
				if (serializedVersion < 1610)
				{
					intensityFromLight = false;
					intensityModeAdvanced = !Mathf.Approximately(intensityInside, intensityOutside);
				}
				Utils.MarkCurrentSceneDirty();
			}
		}
	}
}
namespace VLB_Samples
{
	[RequireComponent(typeof(Camera))]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[SerializeField]
		private KeyCode m_KeyCode = KeyCode.Space;

		private void Update()
		{
			if (Input.GetKeyDown(m_KeyCode))
			{
				Camera component = GetComponent<Camera>();
				int geometryLayerID = VLB.Config.Instance.geometryLayerID;
				int num = 1 << geometryLayerID;
				if ((component.cullingMask & num) == num)
				{
					component.cullingMask &= ~num;
				}
				else
				{
					component.cullingMask |= num;
				}
			}
		}
	}
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		private bool isInsideBeam;

		private Material m_Material;

		private Collider m_Collider;

		private void Start()
		{
			m_Collider = GetComponent<Collider>();
			MeshRenderer component = GetComponent<MeshRenderer>();
			if ((bool)component)
			{
				m_Material = component.material;
			}
		}

		private void Update()
		{
			if ((bool)m_Material)
			{
				m_Material.SetColor("_Color", isInsideBeam ? UnityEngine.Color.green : UnityEngine.Color.red);
			}
		}

		private void FixedUpdate()
		{
			isInsideBeam = false;
		}

		private void OnTriggerStay(Collider trigger)
		{
			VolumetricLightBeam component = trigger.GetComponent<VolumetricLightBeam>();
			if ((bool)component)
			{
				isInsideBeam = !component.IsColliderHiddenByDynamicOccluder(m_Collider);
			}
		}
	}
	[RequireComponent(typeof(Text))]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		private void Start()
		{
			GetComponent<Text>().text = (Noise3D.isSupported ? "" : Noise3D.isNotSupportedString);
		}
	}
	public class FreeCameraController : MonoBehaviour
	{
		public float cameraSensitivity = 90f;

		public float speedNormal = 10f;

		public float speedFactorSlow = 0.25f;

		public float speedFactorFast = 3f;

		public float speedClimb = 4f;

		private float rotationH;

		private float rotationV;

		private bool m_UseMouseView = true;

		private bool useMouseView
		{
			get
			{
				return m_UseMouseView;
			}
			set
			{
				m_UseMouseView = value;
				Cursor.lockState = (value ? CursorLockMode.Locked : CursorLockMode.None);
				Cursor.visible = !value;
			}
		}

		private void Start()
		{
			useMouseView = true;
			Vector3 eulerAngles = base.transform.rotation.eulerAngles;
			rotationH = eulerAngles.y;
			rotationV = eulerAngles.x;
			if (rotationV > 180f)
			{
				rotationV -= 360f;
			}
		}

		private void Update()
		{
			if (useMouseView)
			{
				rotationH += Input.GetAxis("Mouse X") * cameraSensitivity * Time.deltaTime;
				rotationV -= Input.GetAxis("Mouse Y") * cameraSensitivity * Time.deltaTime;
			}
			rotationV = Mathf.Clamp(rotationV, -90f, 90f);
			base.transform.rotation = Quaternion.AngleAxis(rotationH, Vector3.up);
			base.transform.rotation *= Quaternion.AngleAxis(rotationV, Vector3.right);
			float num = speedNormal;
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				num *= speedFactorFast;
			}
			else if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
			{
				num *= speedFactorSlow;
			}
			base.transform.position += base.transform.forward * num * Input.GetAxis("Vertical") * Time.deltaTime;
			base.transform.position += base.transform.right * num * Input.GetAxis("Horizontal") * Time.deltaTime;
			if (Input.GetKey(KeyCode.Q))
			{
				base.transform.position += Vector3.up * speedClimb * Time.deltaTime;
			}
			if (Input.GetKey(KeyCode.E))
			{
				base.transform.position += Vector3.down * speedClimb * Time.deltaTime;
			}
			if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1) || Input.GetMouseButtonDown(2))
			{
				useMouseView = !useMouseView;
			}
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				useMouseView = false;
			}
		}
	}
	public class LightGenerator : MonoBehaviour
	{
		[Range(1f, 100f)]
		[SerializeField]
		private int CountX = 10;

		[Range(1f, 100f)]
		[SerializeField]
		private int CountY = 10;

		[SerializeField]
		private float OffsetUnits = 1f;

		[SerializeField]
		private float PositionY = 1f;

		[SerializeField]
		private bool NoiseEnabled;

		[SerializeField]
		private bool AddLight = true;

		public void Generate()
		{
			for (int i = 0; i < CountX; i++)
			{
				for (int j = 0; j < CountY; j++)
				{
					GameObject gameObject = null;
					gameObject = ((!AddLight) ? new GameObject("Light_" + i + "_" + j, typeof(VolumetricLightBeam), typeof(Rotater)) : new GameObject("Light_" + i + "_" + j, typeof(Light), typeof(VolumetricLightBeam), typeof(Rotater)));
					gameObject.transform.position = new Vector3((float)i * OffsetUnits, PositionY, (float)j * OffsetUnits);
					gameObject.transform.rotation = Quaternion.Euler((float)UnityEngine.Random.Range(-45, 45) + 90f, UnityEngine.Random.Range(0, 360), 0f);
					VolumetricLightBeam component = gameObject.GetComponent<VolumetricLightBeam>();
					if (AddLight)
					{
						Light component2 = gameObject.GetComponent<Light>();
						component2.type = LightType.Spot;
						component2.color = new UnityEngine.Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1f);
						component2.range = UnityEngine.Random.Range(3f, 8f);
						component2.intensity = UnityEngine.Random.Range(0.2f, 5f);
						component2.spotAngle = UnityEngine.Random.Range(10f, 90f);
						if (VLB.Config.Instance.geometryOverrideLayer)
						{
							component2.cullingMask = ~(1 << VLB.Config.Instance.geometryLayerID);
						}
					}
					else
					{
						component.color = new UnityEngine.Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value, 1f);
						component.fadeEnd = UnityEngine.Random.Range(3f, 8f);
						component.spotAngle = UnityEngine.Random.Range(10f, 90f);
					}
					component.coneRadiusStart = UnityEngine.Random.Range(0f, 0.1f);
					component.geomCustomSides = UnityEngine.Random.Range(12, 36);
					component.fresnelPow = UnityEngine.Random.Range(1f, 7.5f);
					component.noiseEnabled = NoiseEnabled;
					gameObject.GetComponent<Rotater>().EulerSpeed = new Vector3(0f, UnityEngine.Random.Range(-500, 500), 0f);
				}
			}
		}
	}
	public class Rotater : MonoBehaviour
	{
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed = Vector3.zero;

		private void Update()
		{
			Vector3 eulerAngles = base.transform.rotation.eulerAngles;
			eulerAngles += EulerSpeed * Time.deltaTime;
			base.transform.rotation = Quaternion.Euler(eulerAngles);
		}
	}
}
namespace DentedPixel
{
	public class LeanDummy
	{
	}
}
namespace CodeStage.AdvancedFPSCounter
{
	public class APITester : MonoBehaviour
	{
		private int selectedTab;

		private readonly string[] tabs = new string[5] { "Common", "Look & Feel", "FPS Counter", "Memory Counter", "Device info" };

		private FPSLevel currentFPSLevel;

		private void Start()
		{
			AFPSCounter.AddToScene().fpsCounter.OnFPSLevelChange += OnFPSLevelChanged;
		}

		private void OnFPSLevelChanged(FPSLevel newLevel)
		{
			currentFPSLevel = newLevel;
		}

		private void OnGUI()
		{
			GUILayout.BeginArea(new Rect(40f, 150f, Screen.width - 80, Screen.height - 80));
			GUIStyle gUIStyle = new GUIStyle(GUI.skin.label)
			{
				richText = true
			};
			GUIStyle style = new GUIStyle(gUIStyle)
			{
				alignment = TextAnchor.UpperCenter
			};
			GUILayout.Label("GC.CollectionCount: " + GC.CollectionCount(0));
			GUILayout.Label("<b>Public API usage examples</b>", style);
			selectedTab = GUILayout.Toolbar(selectedTab, tabs);
			switch (selectedTab)
			{
			case 0:
				GUILayout.Space(10f);
				DrawCommonTab();
				break;
			case 1:
				GUILayout.Space(10f);
				DrawLookFeelTab();
				break;
			case 2:
				GUILayout.Space(10f);
				DrawFPSCounterTab();
				break;
			case 3:
				GUILayout.Space(10f);
				DrawMemoryCounterTab();
				break;
			case 4:
				GUILayout.Space(10f);
				DrawDeviceInfoTab();
				break;
			default:
				GUILayout.Label("Wrong tab!");
				break;
			}
			GUILayout.Space(5f);
			GUILayout.Label("<b>Raw counters values</b> (read using API)", gUIStyle);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical(GUILayout.ExpandWidth(expand: true), GUILayout.MinWidth(300f));
			GUILayout.Label(string.Concat("<size=11>  FPS: ", AFPSCounter.Instance.fpsCounter.LastValue, "  [", AFPSCounter.Instance.fpsCounter.LastMillisecondsValue, " MS]  AVG: ", AFPSCounter.Instance.fpsCounter.LastAverageValue, "  [", AFPSCounter.Instance.fpsCounter.LastAverageMillisecondsValue, " MS]\n  MIN: ", AFPSCounter.Instance.fpsCounter.LastMinimumValue, "  [", AFPSCounter.Instance.fpsCounter.LastMinMillisecondsValue, " MS]  MAX: ", AFPSCounter.Instance.fpsCounter.LastMaximumValue, "  [", AFPSCounter.Instance.fpsCounter.LastMaxMillisecondsValue, " MS]\n  RNDR: [", AFPSCounter.Instance.fpsCounter.LastRenderValue, " MS]\n  Level (direct / callback): ", AFPSCounter.Instance.fpsCounter.CurrentFpsLevel, " / ", currentFPSLevel, "</size>"));
			if (AFPSCounter.Instance.memoryCounter.Precise)
			{
				GUILayout.Label("<size=11>  Memory (Total, Allocated, Mono, Gfx):\n  " + (float)AFPSCounter.Instance.memoryCounter.LastTotalValue / 1048576f + ", " + (float)AFPSCounter.Instance.memoryCounter.LastAllocatedValue / 1048576f + ", " + (float)AFPSCounter.Instance.memoryCounter.LastMonoValue / 1048576f + ", " + (float)AFPSCounter.Instance.memoryCounter.LastGfxValue / 1048576f + "</size>");
			}
			else
			{
				GUILayout.Label("<size=11>  Memory (Total, Allocated, Mono, Gfx):\n  " + AFPSCounter.Instance.memoryCounter.LastTotalValue + ", " + AFPSCounter.Instance.memoryCounter.LastAllocatedValue + ", " + AFPSCounter.Instance.memoryCounter.LastMonoValue + ", " + AFPSCounter.Instance.memoryCounter.LastGfxValue + "</size>");
			}
			GUILayout.EndVertical();
			if (AFPSCounter.Instance.deviceInfoCounter.Enabled)
			{
				GUILayout.Label("<size=11>" + AFPSCounter.Instance.deviceInfoCounter.LastValue + "</size>");
			}
			GUILayout.EndHorizontal();
			GUILayout.EndArea();
		}

		private void DrawCommonTab()
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label("Operation Mode:", GUILayout.MaxWidth(100f));
			int operationMode = (int)AFPSCounter.Instance.OperationMode;
			operationMode = GUILayout.Toolbar(operationMode, new string[3]
			{
				OperationMode.Disabled.ToString(),
				OperationMode.Background.ToString(),
				OperationMode.Normal.ToString()
			});
			if (GUI.changed)
			{
				AFPSCounter.Instance.OperationMode = (OperationMode)operationMode;
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(10f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Hot Key:", GUILayout.MaxWidth(100f));
			int selected = (int)((AFPSCounter.Instance.hotKey == KeyCode.BackQuote) ? ((KeyCode)1) : AFPSCounter.Instance.hotKey);
			selected = GUILayout.Toolbar(selected, new string[2] { "None (disabled)", "BackQuote (`)" });
			AFPSCounter.Instance.hotKey = ((selected == 1) ? KeyCode.BackQuote : KeyCode.None);
			AFPSCounter.Instance.circleGesture = GUILayout.Toggle(AFPSCounter.Instance.circleGesture, "Circle Gesture", GUILayout.ExpandWidth(expand: false));
			GUILayout.EndHorizontal();
			GUI.enabled = selected == 1;
			GUILayout.Label("Hot Key modifiers:");
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.hotKeyCtrl = GUILayout.Toggle(AFPSCounter.Instance.hotKeyCtrl, "Ctrl / Cmd", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(10f);
			AFPSCounter.Instance.hotKeyAlt = GUILayout.Toggle(AFPSCounter.Instance.hotKeyAlt, "Alt", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(10f);
			AFPSCounter.Instance.hotKeyShift = GUILayout.Toggle(AFPSCounter.Instance.hotKeyShift, "Shift", GUILayout.ExpandWidth(expand: false));
			GUILayout.EndHorizontal();
			GUI.enabled = true;
			GUILayout.Space(10f);
			GUILayout.Label("KeepAlive enabled: " + AFPSCounter.Instance.KeepAlive);
			GUILayout.Space(5f);
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.ForceFrameRate = GUILayout.Toggle(AFPSCounter.Instance.ForceFrameRate, "Force FPS", GUILayout.Width(100f));
			AFPSCounter.Instance.ForcedFrameRate = (int)SliderLabel(AFPSCounter.Instance.ForcedFrameRate, -1f, 100f);
			GUILayout.EndHorizontal();
		}

		private void DrawLookFeelTab()
		{
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.PixelPerfect = GUILayout.Toggle(AFPSCounter.Instance.PixelPerfect, "Pixel Perfect", GUILayout.Width(100f));
			AFPSCounter.Instance.AutoScale = GUILayout.Toggle(AFPSCounter.Instance.AutoScale, "Auto scale", GUILayout.Width(100f));
			GUILayout.Label("Scale", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			AFPSCounter.Instance.ScaleFactor = SliderLabel(AFPSCounter.Instance.ScaleFactor, 0.1f, 10f);
			GUILayout.Space(30f);
			GUILayout.Label("Font Size", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			AFPSCounter.Instance.FontSize = (int)SliderLabel(AFPSCounter.Instance.FontSize, 1f, 100f);
			GUILayout.EndHorizontal();
			AFPSCounter.Instance.PaddingOffset = Vector2Slider(AFPSCounter.Instance.PaddingOffset, "Padding");
			GUILayout.BeginHorizontal();
			GUILayout.Label("Line spacing", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			AFPSCounter.Instance.LineSpacing = SliderLabel(AFPSCounter.Instance.LineSpacing, 0f, 10f);
			GUILayout.Space(30f);
			GUILayout.Label("Counters spacing", GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			AFPSCounter.Instance.CountersSpacing = (int)SliderLabel(AFPSCounter.Instance.CountersSpacing, 0f, 10f);
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.Background = GUILayout.Toggle(AFPSCounter.Instance.Background, "Background", GUILayout.Width(100f));
			GUILayout.Space(5f);
			GUI.enabled = AFPSCounter.Instance.Background;
			AFPSCounter.Instance.BackgroundColor = ColorSliders("Color", AFPSCounter.Instance.BackgroundColor);
			GUILayout.Label("Padding", GUILayout.Width(60f));
			AFPSCounter.Instance.BackgroundPadding = (int)SliderLabel(AFPSCounter.Instance.BackgroundPadding, 0f, 50f);
			GUI.enabled = true;
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.Shadow = GUILayout.Toggle(AFPSCounter.Instance.Shadow, "Shadow", GUILayout.Width(100f));
			GUILayout.Space(5f);
			GUI.enabled = AFPSCounter.Instance.Shadow;
			AFPSCounter.Instance.ShadowColor = ColorSliders("Color", AFPSCounter.Instance.ShadowColor);
			GUI.enabled = true;
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.Outline = GUILayout.Toggle(AFPSCounter.Instance.Outline, "Outline", GUILayout.Width(100f));
			GUILayout.Space(5f);
			GUI.enabled = AFPSCounter.Instance.Outline;
			AFPSCounter.Instance.OutlineColor = ColorSliders("Color", AFPSCounter.Instance.OutlineColor);
			GUI.enabled = true;
			GUILayout.EndHorizontal();
			GUILayout.Space(5f);
			Camera.main.backgroundColor = ColorSliders("Scene background color", Camera.main.backgroundColor);
		}

		private void DrawFPSCounterTab()
		{
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.fpsCounter.Enabled = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.Enabled, "Enabled");
			GUILayout.Label("Style: ", GUILayout.Width(35f));
			AFPSCounter.Instance.fpsCounter.Style = (FontStyle)GUILayout.Toolbar((int)AFPSCounter.Instance.fpsCounter.Style, new string[4] { "Normal", "Bold", "Italic", "Bold&Italic" });
			GUILayout.Label("Extra text: ", GUILayout.Width(70f));
			if (GUILayout.Button("Append", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.fpsCounter.ExtraText = "<b>Some</b> <color=#A76ED1>text</color>!";
			}
			if (GUILayout.Button("Remove", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.fpsCounter.ExtraText = null;
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(10f);
			AFPSCounter.Instance.fpsCounter.Anchor = (LabelAnchor)GUILayout.Toolbar((int)AFPSCounter.Instance.fpsCounter.Anchor, new string[6] { "UpperLeft", "UpperRight", "LowerLeft", "LowerRight", "UpperCenter", "LowerCenter" });
			GUILayout.BeginHorizontal();
			GUILayout.Label("Update Interval", GUILayout.Width(100f));
			AFPSCounter.Instance.fpsCounter.UpdateInterval = SliderLabel(AFPSCounter.Instance.fpsCounter.UpdateInterval, 0.1f, 10f);
			GUILayout.EndHorizontal();
			AFPSCounter.Instance.fpsCounter.Milliseconds = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.Milliseconds, "Milliseconds");
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.fpsCounter.Average = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.Average, "Average FPS", GUILayout.Width(100f));
			if (AFPSCounter.Instance.fpsCounter.Average)
			{
				GUILayout.Label("Samples", GUILayout.ExpandWidth(expand: false));
				AFPSCounter.Instance.fpsCounter.AverageSamples = (int)SliderLabel(AFPSCounter.Instance.fpsCounter.AverageSamples, 0f, 100f);
				GUILayout.Space(10f);
				AFPSCounter.Instance.fpsCounter.AverageMilliseconds = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.AverageMilliseconds, "Milliseconds");
				AFPSCounter.Instance.fpsCounter.AverageNewLine = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.AverageNewLine, "On new line");
				AFPSCounter.Instance.fpsCounter.resetAverageOnNewScene = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.resetAverageOnNewScene, "Reset On Load", GUILayout.ExpandWidth(expand: false));
				if (GUILayout.Button("Reset now!", GUILayout.ExpandWidth(expand: false)))
				{
					AFPSCounter.Instance.fpsCounter.ResetAverage();
				}
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.fpsCounter.MinMax = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.MinMax, "MinMax FPS", GUILayout.Width(100f));
			if (AFPSCounter.Instance.fpsCounter.MinMax)
			{
				GUILayout.Label("Delay", GUILayout.ExpandWidth(expand: false));
				AFPSCounter.Instance.fpsCounter.minMaxIntervalsToSkip = (int)SliderLabel(AFPSCounter.Instance.fpsCounter.minMaxIntervalsToSkip, 0f, 10f);
				GUILayout.Space(10f);
				AFPSCounter.Instance.fpsCounter.MinMaxMilliseconds = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.MinMaxMilliseconds, "Milliseconds");
				AFPSCounter.Instance.fpsCounter.MinMaxTwoLines = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.MinMaxTwoLines, "On two lines");
				AFPSCounter.Instance.fpsCounter.MinMaxNewLine = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.MinMaxNewLine, "On new line");
				AFPSCounter.Instance.fpsCounter.resetMinMaxOnNewScene = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.resetMinMaxOnNewScene, "Reset On Load", GUILayout.ExpandWidth(expand: false));
				if (GUILayout.Button("Reset now!", GUILayout.ExpandWidth(expand: false)))
				{
					AFPSCounter.Instance.fpsCounter.ResetMinMax();
				}
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.fpsCounter.Render = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.Render, "Render Time", GUILayout.Width(100f));
			if (AFPSCounter.Instance.fpsCounter.Render)
			{
				AFPSCounter.Instance.fpsCounter.RenderNewLine = GUILayout.Toggle(AFPSCounter.Instance.fpsCounter.RenderNewLine, "On new line");
			}
			GUILayout.EndHorizontal();
		}

		private void DrawMemoryCounterTab()
		{
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.memoryCounter.Enabled = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.Enabled, "Enabled");
			GUILayout.Label("Style: ", GUILayout.Width(35f));
			AFPSCounter.Instance.memoryCounter.Style = (FontStyle)GUILayout.Toolbar((int)AFPSCounter.Instance.memoryCounter.Style, new string[4] { "Normal", "Bold", "Italic", "Bold&Italic" });
			GUILayout.Label("Extra text: ", GUILayout.Width(70f));
			if (GUILayout.Button("Append", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.memoryCounter.ExtraText = "<b>Some</b> <color=#A76ED1>text</color>!";
			}
			if (GUILayout.Button("Remove", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.memoryCounter.ExtraText = null;
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(10f);
			AFPSCounter.Instance.memoryCounter.Anchor = (LabelAnchor)GUILayout.Toolbar((int)AFPSCounter.Instance.memoryCounter.Anchor, new string[6] { "UpperLeft", "UpperRight", "LowerLeft", "LowerRight", "UpperCenter", "LowerCenter" });
			GUILayout.Space(10f);
			GUILayout.BeginHorizontal();
			GUILayout.Label("Update Interval", GUILayout.Width(100f));
			AFPSCounter.Instance.memoryCounter.UpdateInterval = SliderLabel(AFPSCounter.Instance.memoryCounter.UpdateInterval, 0.1f, 10f);
			GUILayout.EndHorizontal();
			GUILayout.Space(10f);
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			AFPSCounter.Instance.memoryCounter.Precise = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.Precise, "Precise (uses more system resources)");
			AFPSCounter.Instance.memoryCounter.Total = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.Total, "Total reserved memory size");
			GUILayout.EndVertical();
			GUILayout.BeginVertical();
			AFPSCounter.Instance.memoryCounter.Allocated = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.Allocated, "Allocated memory size");
			AFPSCounter.Instance.memoryCounter.MonoUsage = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.MonoUsage, "Mono memory usage");
			AFPSCounter.Instance.memoryCounter.Gfx = GUILayout.Toggle(AFPSCounter.Instance.memoryCounter.Gfx, "GfxDriver memory");
			GUILayout.EndVertical();
			GUILayout.EndHorizontal();
		}

		private void DrawDeviceInfoTab()
		{
			GUILayout.BeginHorizontal();
			AFPSCounter.Instance.deviceInfoCounter.Enabled = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.Enabled, "Enabled");
			GUILayout.Label("Style: ", GUILayout.Width(35f));
			AFPSCounter.Instance.deviceInfoCounter.Style = (FontStyle)GUILayout.Toolbar((int)AFPSCounter.Instance.deviceInfoCounter.Style, new string[4] { "Normal", "Bold", "Italic", "Bold&Italic" });
			GUILayout.Label("Extra text: ", GUILayout.Width(70f));
			if (GUILayout.Button("Append", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.deviceInfoCounter.ExtraText = "<b>Some</b> <color=#A76ED1>text</color>!";
			}
			if (GUILayout.Button("Remove", GUILayout.ExpandWidth(expand: false)))
			{
				AFPSCounter.Instance.deviceInfoCounter.ExtraText = null;
			}
			GUILayout.EndHorizontal();
			GUILayout.Space(10f);
			AFPSCounter.Instance.deviceInfoCounter.Anchor = (LabelAnchor)GUILayout.Toolbar((int)AFPSCounter.Instance.deviceInfoCounter.Anchor, new string[6] { "UpperLeft", "UpperRight", "LowerLeft", "LowerRight", "UpperCenter", "LowerCenter" });
			GUILayout.Space(10f);
			using (new GUILayout.HorizontalScope())
			{
				using (new GUILayout.VerticalScope())
				{
					AFPSCounter.Instance.deviceInfoCounter.Platform = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.Platform, "Platform info");
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.CpuModel = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.CpuModel, "CPU info", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.CpuModelNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.CpuModelNewLine, "new line");
					}
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.GpuModel = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuModel, "GPU Model", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.GpuModelNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuModelNewLine, "new line");
					}
				}
				using (new GUILayout.VerticalScope())
				{
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.GpuApi = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuApi, "GPU API", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.GpuApiNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuApiNewLine, "new line");
					}
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.GpuSpec = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuSpec, "GPU Spec", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.GpuSpecNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.GpuSpecNewLine, "new line");
					}
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.RamSize = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.RamSize, "Total RAM size", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.RamSizeNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.RamSizeNewLine, "new line");
					}
				}
				using (new GUILayout.VerticalScope())
				{
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.ScreenData = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.ScreenData, "Display info", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.ScreenDataNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.ScreenDataNewLine, "new line");
					}
					using (new GUILayout.HorizontalScope())
					{
						AFPSCounter.Instance.deviceInfoCounter.DeviceModel = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.DeviceModel, "Device model", GUILayout.Width(150f));
						AFPSCounter.Instance.deviceInfoCounter.DeviceModelNewLine = GUILayout.Toggle(AFPSCounter.Instance.deviceInfoCounter.DeviceModelNewLine, "new line");
					}
				}
			}
		}

		private static float SliderLabel(float sliderValue, float sliderMinValue, float sliderMaxValue)
		{
			GUILayout.BeginHorizontal();
			GUILayout.BeginVertical();
			GUILayout.Space(8f);
			sliderValue = GUILayout.HorizontalSlider(sliderValue, sliderMinValue, sliderMaxValue);
			GUILayout.EndVertical();
			GUILayout.Space(10f);
			GUILayout.Label($"{sliderValue:F2}", GUILayout.ExpandWidth(expand: false));
			GUILayout.EndHorizontal();
			return sliderValue;
		}

		private UnityEngine.Color ColorSliders(string caption, UnityEngine.Color color)
		{
			GUILayout.BeginHorizontal();
			GUILayout.Label(caption, GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			GUILayout.Label("R:", GUILayout.Width(20f));
			color.r = SliderLabel(color.r, 0f, 1f);
			GUILayout.Space(5f);
			GUILayout.Label("G:", GUILayout.Width(20f));
			color.g = SliderLabel(color.g, 0f, 1f);
			GUILayout.Space(5f);
			GUILayout.Label("B:", GUILayout.Width(20f));
			color.b = SliderLabel(color.b, 0f, 1f);
			GUILayout.EndHorizontal();
			return color;
		}

		private Vector2 Vector2Slider(Vector2 input, string label)
		{
			Vector2 result = input;
			GUILayout.BeginHorizontal();
			GUILayout.Label(label, GUILayout.ExpandWidth(expand: false));
			GUILayout.Space(5f);
			GUILayout.Label("X: ", GUILayout.Width(20f));
			result.x = (int)SliderLabel(result.x, 0f, 100f);
			GUILayout.Space(30f);
			GUILayout.Label("Y:", GUILayout.Width(20f));
			result.y = (int)SliderLabel(result.y, 0f, 100f);
			GUILayout.EndHorizontal();
			return result;
		}
	}
	[AddComponentMenu("Code Stage/\ud83d\ude80 Advanced FPS Counter")]
	[DisallowMultipleComponent]
	[HelpURL("http://codestage.net/uas_files/afps/api/class_code_stage_1_1_advanced_f_p_s_counter_1_1_a_f_p_s_counter.html")]
	public class AFPSCounter : MonoBehaviour
	{
		private const string MenuPath = "Code Stage/\ud83d\ude80 Advanced FPS Counter";

		private const string ComponentName = "Advanced FPS Counter";

		internal const string LogPrefix = "[AFPSCounter]: ";

		internal const char NewLine = '\n';

		internal const char Space = ' ';

		public FPSCounterData fpsCounter = new FPSCounterData();

		public MemoryCounterData memoryCounter = new MemoryCounterData();

		public DeviceInfoCounterData deviceInfoCounter = new DeviceInfoCounterData();

		[Tooltip("Used to enable / disable plugin at runtime.\nSet to None to disable.")]
		public KeyCode hotKey = KeyCode.BackQuote;

		[Tooltip("Used to enable / disable plugin at runtime.\nMake two circle gestures with your finger \\ mouse to switch plugin on and off.")]
		public bool circleGesture;

		[Tooltip("Hot key modifier: any Control on Windows or any Command on Mac.")]
		public bool hotKeyCtrl;

		[Tooltip("Hot key modifier: any Shift.")]
		public bool hotKeyShift;

		[Tooltip("Hot key modifier: any Alt.")]
		public bool hotKeyAlt;

		[Tooltip("Prevents current or other topmost Game Object from destroying on level (scene) load.\nApplied once, on Start phase.")]
		[SerializeField]
		private bool keepAlive = true;

		private Canvas canvas;

		private CanvasScaler canvasScaler;

		private bool externalCanvas;

		private DrawableLabel[] labels;

		private int anchorsCount;

		private int cachedVSync = -1;

		private int cachedFrameRate = -1;

		private bool inited;

		private readonly List<Vector2> gesturePoints = new List<Vector2>();

		private int gestureCount;

		[Tooltip("Disabled: removes labels and stops all internal processes except Hot Key listener.\n\nBackground: removes labels keeping counters alive; use for hidden performance monitoring.\n\nNormal: shows labels and runs all internal processes as usual.")]
		[SerializeField]
		private OperationMode operationMode = OperationMode.Normal;

		[Tooltip("Allows to see how your game performs on specified frame rate.\nDoes not guarantee selected frame rate. Set -1 to render as fast as possible in current conditions.\nIMPORTANT: this option disables VSync while enabled!")]
		[SerializeField]
		private bool forceFrameRate;

		[Range(-1f, 200f)]
		[SerializeField]
		private int forcedFrameRate = -1;

		[Tooltip("Background for all texts. Cheapest effect. Overhead: 1 Draw Call.")]
		[SerializeField]
		private bool background = true;

		[Tooltip("Color of the background.")]
		[SerializeField]
		private UnityEngine.Color backgroundColor = new Color32(0, 0, 0, 155);

		[Tooltip("Padding of the background.")]
		[Range(0f, 30f)]
		[SerializeField]
		private int backgroundPadding = 5;

		[Tooltip("Shadow effect for all texts. This effect uses extra resources. Overhead: medium CPU and light GPU usage.")]
		[SerializeField]
		private bool shadow;

		[Tooltip("Color of the shadow effect.")]
		[SerializeField]
		private UnityEngine.Color shadowColor = new Color32(0, 0, 0, 128);

		[Tooltip("Distance of the shadow effect.")]
		[SerializeField]
		private Vector2 shadowDistance = new Vector2(1f, -1f);

		[Tooltip("Outline effect for all texts. Resource-heaviest effect. Overhead: huge CPU and medium GPU usage. Not recommended for use unless really necessary.")]
		[SerializeField]
		private bool outline;

		[Tooltip("Color of the outline effect.")]
		[SerializeField]
		private UnityEngine.Color outlineColor = new Color32(0, 0, 0, 128);

		[Tooltip("Distance of the outline effect.")]
		[SerializeField]
		private Vector2 outlineDistance = new Vector2(1f, -1f);

		[Tooltip("Controls own Canvas Scaler scale mode. Check to use ScaleWithScreenSize. Otherwise ConstantPixelSize will be used.")]
		[SerializeField]
		private bool autoScale;

		[Tooltip("Controls global scale of all texts.")]
		[Range(0f, 30f)]
		[SerializeField]
		private float scaleFactor = 1f;

		[Tooltip("Leave blank to use default font.")]
		[SerializeField]
		private Font labelsFont;

		[Tooltip("Set to 0 to use font size specified in the font importer.")]
		[Range(0f, 100f)]
		[SerializeField]
		private int fontSize = 14;

		[Tooltip("Space between lines in labels.")]
		[Range(0f, 10f)]
		[SerializeField]
		private float lineSpacing = 1f;

		[Tooltip("Lines count between different counters in a single label.")]
		[Range(0f, 10f)]
		[SerializeField]
		private int countersSpacing;

		[Tooltip("Pixel offset for anchored labels. Automatically applied to all labels.")]
		[SerializeField]
		private Vector2 paddingOffset = new Vector2(5f, 5f);

		[Tooltip("Controls own canvas Pixel Perfect property.")]
		[SerializeField]
		private bool pixelPerfect = true;

		[Tooltip("Sorting order to use for the canvas.\nSet higher value to get closer to the user.")]
		[SerializeField]
		private int sortingOrder = 10000;

		public bool KeepAlive => keepAlive;

		public OperationMode OperationMode
		{
			get
			{
				return operationMode;
			}
			set
			{
				if (operationMode == value || !Application.isPlaying)
				{
					return;
				}
				operationMode = value;
				if (operationMode != 0)
				{
					if (operationMode == OperationMode.Background)
					{
						for (int i = 0; i < anchorsCount; i++)
						{
							labels[i].Clear();
						}
					}
					OnEnable();
					fpsCounter.UpdateValue();
					memoryCounter.UpdateValue();
					deviceInfoCounter.UpdateValue();
					UpdateTexts();
				}
				else
				{
					OnDisable();
				}
			}
		}

		public bool ForceFrameRate
		{
			get
			{
				return forceFrameRate;
			}
			set
			{
				if (forceFrameRate != value && Application.isPlaying)
				{
					forceFrameRate = value;
					if (operationMode != 0)
					{
						RefreshForcedFrameRate();
					}
				}
			}
		}

		public int ForcedFrameRate
		{
			get
			{
				return forcedFrameRate;
			}
			set
			{
				if (forcedFrameRate != value && Application.isPlaying)
				{
					forcedFrameRate = value;
					if (operationMode != 0)
					{
						RefreshForcedFrameRate();
					}
				}
			}
		}

		public bool Background
		{
			get
			{
				return background;
			}
			set
			{
				if (background == value || !Application.isPlaying)
				{
					return;
				}
				background = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeBackground(background);
					}
				}
			}
		}

		public UnityEngine.Color BackgroundColor
		{
			get
			{
				return backgroundColor;
			}
			set
			{
				if (backgroundColor == value || !Application.isPlaying)
				{
					return;
				}
				backgroundColor = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeBackgroundColor(backgroundColor);
					}
				}
			}
		}

		public int BackgroundPadding
		{
			get
			{
				return backgroundPadding;
			}
			set
			{
				if (backgroundPadding == value || !Application.isPlaying)
				{
					return;
				}
				backgroundPadding = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeBackgroundPadding(backgroundPadding);
					}
				}
			}
		}

		public bool Shadow
		{
			get
			{
				return shadow;
			}
			set
			{
				if (shadow == value || !Application.isPlaying)
				{
					return;
				}
				shadow = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeShadow(shadow);
					}
				}
			}
		}

		public UnityEngine.Color ShadowColor
		{
			get
			{
				return shadowColor;
			}
			set
			{
				if (shadowColor == value || !Application.isPlaying)
				{
					return;
				}
				shadowColor = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeShadowColor(shadowColor);
					}
				}
			}
		}

		public Vector2 ShadowDistance
		{
			get
			{
				return shadowDistance;
			}
			set
			{
				if (shadowDistance == value || !Application.isPlaying)
				{
					return;
				}
				shadowDistance = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeShadowDistance(shadowDistance);
					}
				}
			}
		}

		public bool Outline
		{
			get
			{
				return outline;
			}
			set
			{
				if (outline == value || !Application.isPlaying)
				{
					return;
				}
				outline = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeOutline(outline);
					}
				}
			}
		}

		public UnityEngine.Color OutlineColor
		{
			get
			{
				return outlineColor;
			}
			set
			{
				if (outlineColor == value || !Application.isPlaying)
				{
					return;
				}
				outlineColor = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeOutlineColor(outlineColor);
					}
				}
			}
		}

		public Vector2 OutlineDistance
		{
			get
			{
				return outlineDistance;
			}
			set
			{
				if (outlineDistance == value || !Application.isPlaying)
				{
					return;
				}
				outlineDistance = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeOutlineDistance(outlineDistance);
					}
				}
			}
		}

		public bool AutoScale
		{
			get
			{
				return autoScale;
			}
			set
			{
				if (autoScale != value && Application.isPlaying)
				{
					autoScale = value;
					if (operationMode != 0 && labels != null && !(canvasScaler == null))
					{
						canvasScaler.uiScaleMode = (autoScale ? CanvasScaler.ScaleMode.ScaleWithScreenSize : CanvasScaler.ScaleMode.ConstantPixelSize);
					}
				}
			}
		}

		public float ScaleFactor
		{
			get
			{
				return scaleFactor;
			}
			set
			{
				if (!(Math.Abs(scaleFactor - value) < 0.001f) && Application.isPlaying)
				{
					scaleFactor = value;
					if (operationMode != 0 && !(canvasScaler == null))
					{
						canvasScaler.scaleFactor = scaleFactor;
					}
				}
			}
		}

		public Font LabelsFont
		{
			get
			{
				return labelsFont;
			}
			set
			{
				if (labelsFont == value || !Application.isPlaying)
				{
					return;
				}
				labelsFont = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeFont(labelsFont);
					}
				}
			}
		}

		public int FontSize
		{
			get
			{
				return fontSize;
			}
			set
			{
				if (fontSize == value || !Application.isPlaying)
				{
					return;
				}
				fontSize = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeFontSize(fontSize);
					}
				}
			}
		}

		public float LineSpacing
		{
			get
			{
				return lineSpacing;
			}
			set
			{
				if (Math.Abs(lineSpacing - value) < 0.001f || !Application.isPlaying)
				{
					return;
				}
				lineSpacing = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeLineSpacing(lineSpacing);
					}
				}
			}
		}

		public int CountersSpacing
		{
			get
			{
				return countersSpacing;
			}
			set
			{
				if (countersSpacing == value || !Application.isPlaying)
				{
					return;
				}
				countersSpacing = value;
				if (operationMode != 0 && labels != null)
				{
					UpdateTexts();
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].dirty = true;
					}
				}
			}
		}

		public Vector2 PaddingOffset
		{
			get
			{
				return paddingOffset;
			}
			set
			{
				if (paddingOffset == value || !Application.isPlaying)
				{
					return;
				}
				paddingOffset = value;
				if (operationMode != 0 && labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].ChangeOffset(paddingOffset);
					}
				}
			}
		}

		public bool PixelPerfect
		{
			get
			{
				return pixelPerfect;
			}
			set
			{
				if (pixelPerfect != value && Application.isPlaying)
				{
					pixelPerfect = value;
					if (operationMode != 0 && labels != null)
					{
						canvas.pixelPerfect = pixelPerfect;
					}
				}
			}
		}

		public int SortingOrder
		{
			get
			{
				return sortingOrder;
			}
			set
			{
				if (sortingOrder != value && Application.isPlaying)
				{
					sortingOrder = value;
					if (operationMode != 0 && !(canvas == null))
					{
						canvas.sortingOrder = sortingOrder;
					}
				}
			}
		}

		public static AFPSCounter Instance { get; private set; }

		private AFPSCounter()
		{
		}

		private static AFPSCounter GetOrCreateInstance(bool keepAlive)
		{
			if (Instance != null)
			{
				return Instance;
			}
			AFPSCounter aFPSCounter = UnityEngine.Object.FindObjectOfType<AFPSCounter>();
			if (aFPSCounter != null)
			{
				Instance = aFPSCounter;
			}
			else
			{
				CreateInScene(lookForExistingContainer: false).keepAlive = keepAlive;
			}
			return Instance;
		}

		public static AFPSCounter AddToScene()
		{
			return AddToScene(keepAlive: true);
		}

		public static AFPSCounter AddToScene(bool keepAlive)
		{
			return GetOrCreateInstance(keepAlive);
		}

		[Obsolete("Please use SelfDestroy() instead. This method will be removed in future updates.")]
		public static void Dispose()
		{
			SelfDestroy();
		}

		public static void SelfDestroy()
		{
			if (Instance != null)
			{
				Instance.DisposeInternal();
			}
		}

		internal static string Color32ToHex(Color32 color)
		{
			return color.r.ToString("x2") + color.g.ToString("x2") + color.b.ToString("x2") + color.a.ToString("x2");
		}

		private static AFPSCounter CreateInScene(bool lookForExistingContainer = true)
		{
			GameObject gameObject = (lookForExistingContainer ? GameObject.Find("Advanced FPS Counter") : null);
			if (gameObject == null)
			{
				gameObject = new GameObject("Advanced FPS Counter")
				{
					layer = LayerMask.NameToLayer("UI")
				};
			}
			return gameObject.AddComponent<AFPSCounter>();
		}

		private void Awake()
		{
			if (Instance != null && Instance.keepAlive)
			{
				UnityEngine.Object.Destroy(this);
				return;
			}
			Instance = this;
			fpsCounter.Init(this);
			memoryCounter.Init(this);
			deviceInfoCounter.Init(this);
			ConfigureCanvas();
			ConfigureLabels();
			inited = true;
		}

		private void Start()
		{
			if (keepAlive)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.transform.root.gameObject);
				SceneManager.sceneLoaded += OnLevelWasLoadedNew;
			}
		}

		private void Update()
		{
			if (inited)
			{
				ProcessHotKey();
				if (circleGesture && CircleGestureMade())
				{
					SwitchCounter();
				}
			}
		}

		private void OnLevelWasLoadedNew(Scene scene, LoadSceneMode mode)
		{
			OnLevelLoadedCallback();
		}

		private void OnLevelLoadedCallback()
		{
			if (inited && fpsCounter.Enabled)
			{
				fpsCounter.OnLevelLoadedCallback();
			}
		}

		private void OnEnable()
		{
			if (inited && operationMode != 0)
			{
				ActivateCounters();
				Invoke("RefreshForcedFrameRate", 0.5f);
			}
		}

		private void OnDisable()
		{
			if (inited)
			{
				DeactivateCounters();
				if (IsInvoking("RefreshForcedFrameRate"))
				{
					CancelInvoke("RefreshForcedFrameRate");
				}
				RefreshForcedFrameRate(disabling: true);
				for (int i = 0; i < anchorsCount; i++)
				{
					labels[i].Clear();
				}
			}
		}

		private void OnDestroy()
		{
			if (inited)
			{
				fpsCounter.Destroy();
				memoryCounter.Destroy();
				deviceInfoCounter.Destroy();
				if (labels != null)
				{
					for (int i = 0; i < anchorsCount; i++)
					{
						labels[i].Destroy();
					}
					Array.Clear(labels, 0, anchorsCount);
					labels = null;
				}
				inited = false;
			}
			if (canvas != null)
			{
				UnityEngine.Object.Destroy(canvas.gameObject);
			}
			if (base.transform.childCount <= 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			if (Instance == this)
			{
				Instance = null;
			}
		}

		internal void MakeDrawableLabelDirty(LabelAnchor anchor)
		{
			if (operationMode == OperationMode.Normal)
			{
				labels[(uint)anchor].dirty = true;
			}
		}

		internal void UpdateTexts()
		{
			if (operationMode != OperationMode.Normal)
			{
				return;
			}
			bool flag = false;
			if (fpsCounter.Enabled)
			{
				DrawableLabel drawableLabel = labels[(uint)fpsCounter.Anchor];
				if (drawableLabel.newText.Length > 0)
				{
					drawableLabel.newText.Append(new string('\n', countersSpacing + 1));
				}
				drawableLabel.newText.Append(fpsCounter.text);
				drawableLabel.dirty |= fpsCounter.dirty;
				fpsCounter.dirty = false;
				flag = true;
			}
			if (memoryCounter.Enabled)
			{
				DrawableLabel drawableLabel2 = labels[(uint)memoryCounter.Anchor];
				if (drawableLabel2.newText.Length > 0)
				{
					drawableLabel2.newText.Append(new string('\n', countersSpacing + 1));
				}
				drawableLabel2.newText.Append(memoryCounter.text);
				drawableLabel2.dirty |= memoryCounter.dirty;
				memoryCounter.dirty = false;
				flag = true;
			}
			if (deviceInfoCounter.Enabled)
			{
				DrawableLabel drawableLabel3 = labels[(uint)deviceInfoCounter.Anchor];
				if (drawableLabel3.newText.Length > 0)
				{
					drawableLabel3.newText.Append(new string('\n', countersSpacing + 1));
				}
				drawableLabel3.newText.Append(deviceInfoCounter.text);
				drawableLabel3.dirty |= deviceInfoCounter.dirty;
				deviceInfoCounter.dirty = false;
				flag = true;
			}
			if (flag)
			{
				for (int i = 0; i < anchorsCount; i++)
				{
					labels[i].CheckAndUpdate();
				}
			}
			else
			{
				for (int j = 0; j < anchorsCount; j++)
				{
					labels[j].Clear();
				}
			}
		}

		private void ConfigureCanvas()
		{
			if (GetComponentInParent<Canvas>() != null)
			{
				externalCanvas = true;
				RectTransform rectTransform = base.gameObject.GetComponent<RectTransform>();
				if (rectTransform == null)
				{
					rectTransform = base.gameObject.AddComponent<RectTransform>();
				}
				UIUtils.ResetRectTransform(rectTransform);
			}
			GameObject gameObject = new GameObject("CountersCanvas", typeof(Canvas));
			gameObject.tag = base.gameObject.tag;
			gameObject.layer = base.gameObject.layer;
			gameObject.transform.SetParent(base.transform, worldPositionStays: false);
			canvas = gameObject.GetComponent<Canvas>();
			UIUtils.ResetRectTransform(gameObject.GetComponent<RectTransform>());
			if (!externalCanvas)
			{
				canvas.renderMode = RenderMode.ScreenSpaceOverlay;
				canvas.pixelPerfect = pixelPerfect;
				canvas.sortingOrder = sortingOrder;
				canvasScaler = gameObject.AddComponent<CanvasScaler>();
				if (autoScale)
				{
					canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
				}
				else
				{
					canvasScaler.scaleFactor = scaleFactor;
				}
			}
		}

		private void ConfigureLabels()
		{
			anchorsCount = Enum.GetNames(typeof(LabelAnchor)).Length;
			labels = new DrawableLabel[anchorsCount];
			for (int i = 0; i < anchorsCount; i++)
			{
				labels[i] = new DrawableLabel(canvas.gameObject, (LabelAnchor)i, new LabelEffect(background, backgroundColor, backgroundPadding), new LabelEffect(shadow, shadowColor, shadowDistance), new LabelEffect(outline, outlineColor, outlineDistance), labelsFont, fontSize, lineSpacing, paddingOffset);
			}
		}

		private void DisposeInternal()
		{
			UnityEngine.Object.Destroy(this);
			if (Instance == this)
			{
				Instance = null;
			}
		}

		private void ProcessHotKey()
		{
			if (hotKey != 0 && Input.GetKeyDown(hotKey))
			{
				bool flag = true;
				if (hotKeyCtrl)
				{
					flag &= Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftCommand) || Input.GetKey(KeyCode.RightCommand);
				}
				if (hotKeyAlt)
				{
					flag &= Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightAlt);
				}
				if (hotKeyShift)
				{
					flag &= Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
				}
				if (flag)
				{
					SwitchCounter();
				}
			}
		}

		private bool CircleGestureMade()
		{
			int num = gesturePoints.Count;
			if (Input.GetMouseButton(0))
			{
				Vector2 vector = Input.mousePosition;
				if (num == 0 || (vector - gesturePoints[num - 1]).magnitude > 10f)
				{
					gesturePoints.Add(vector);
					num++;
				}
			}
			else if (Input.GetMouseButtonUp(0))
			{
				num = 0;
				gestureCount = 0;
				gesturePoints.Clear();
			}
			if (num < 10)
			{
				return false;
			}
			float num2 = 0f;
			Vector2 zero = Vector2.zero;
			Vector2 rhs = Vector2.zero;
			for (int i = 0; i < num - 2; i++)
			{
				Vector2 vector2 = gesturePoints[i + 1] - gesturePoints[i];
				zero += vector2;
				float magnitude = vector2.magnitude;
				num2 += magnitude;
				if (Vector2.Dot(vector2, rhs) < 0f)
				{
					gesturePoints.Clear();
					gestureCount = 0;
					return false;
				}
				rhs = vector2;
			}
			bool result = false;
			int num3 = (Screen.width + Screen.height) / 4;
			if (num2 > (float)num3 && zero.magnitude < (float)num3 / 2f)
			{
				gesturePoints.Clear();
				gestureCount++;
				if (gestureCount >= 2)
				{
					gestureCount = 0;
					result = true;
				}
			}
			return result;
		}

		private void SwitchCounter()
		{
			if (operationMode == OperationMode.Disabled)
			{
				OperationMode = OperationMode.Normal;
			}
			else if (operationMode == OperationMode.Normal)
			{
				OperationMode = OperationMode.Disabled;
			}
		}

		private void ActivateCounters()
		{
			fpsCounter.Activate();
			memoryCounter.Activate();
			deviceInfoCounter.Activate();
			if (fpsCounter.Enabled || memoryCounter.Enabled || deviceInfoCounter.Enabled)
			{
				UpdateTexts();
			}
		}

		private void DeactivateCounters()
		{
			if (!(Instance == null))
			{
				fpsCounter.Deactivate();
				memoryCounter.Deactivate();
				deviceInfoCounter.Deactivate();
			}
		}

		private void RefreshForcedFrameRate()
		{
			RefreshForcedFrameRate(disabling: false);
		}

		private void RefreshForcedFrameRate(bool disabling)
		{
			if (forceFrameRate && !disabling)
			{
				if (cachedVSync == -1)
				{
					cachedVSync = QualitySettings.vSyncCount;
					cachedFrameRate = Application.targetFrameRate;
					QualitySettings.vSyncCount = 0;
				}
				Application.targetFrameRate = forcedFrameRate;
			}
			else if (cachedVSync != -1)
			{
				QualitySettings.vSyncCount = cachedVSync;
				Application.targetFrameRate = cachedFrameRate;
				cachedVSync = -1;
			}
		}
	}
	public enum FPSLevel : byte
	{
		Normal,
		Warning,
		Critical
	}
	public enum OperationMode : byte
	{
		Disabled,
		Background,
		Normal
	}
}
namespace CodeStage.AdvancedFPSCounter.Utils
{
	[DisallowMultipleComponent]
	public class AFPSRenderRecorder : MonoBehaviour
	{
		private bool recording;

		private float renderTime;

		private void OnPreCull()
		{
			if (!recording && !(AFPSCounter.Instance == null))
			{
				recording = true;
				renderTime = Time.realtimeSinceStartup;
			}
		}

		private void OnPostRender()
		{
			if (recording && !(AFPSCounter.Instance == null))
			{
				recording = false;
				renderTime = Time.realtimeSinceStartup - renderTime;
				AFPSCounter.Instance.fpsCounter.AddRenderTime(renderTime * 1000f);
			}
		}
	}
	internal static class CachedNumbers
	{
		private const int IntMax = 1000;

		private static readonly string[] cachedFloatDigits = new string[10] { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09" };

		private static readonly string[] cachedIntegers = new string[1001]
		{
			"0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
			"10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
			"20", "21", "22", "23", "24", "25", "26", "27", "28", "29",
			"30", "31", "32", "33", "34", "35", "36", "37", "38", "39",
			"40", "41", "42", "43", "44", "45", "46", "47", "48", "49",
			"50", "51", "52", "53", "54", "55", "56", "57", "58", "59",
			"60", "61", "62", "63", "64", "65", "66", "67", "68", "69",
			"70", "71", "72", "73", "74", "75", "76", "77", "78", "79",
			"80", "81", "82", "83", "84", "85", "86", "87", "88", "89",
			"90", "91", "92", "93", "94", "95", "96", "97", "98", "99",
			"100", "101", "102", "103", "104", "105", "106", "107", "108", "109",
			"110", "111", "112", "113", "114", "115", "116", "117", "118", "119",
			"120", "121", "122", "123", "124", "125", "126", "127", "128", "129",
			"130", "131", "132", "133", "134", "135", "136", "137", "138", "139",
			"140", "141", "142", "143", "144", "145", "146", "147", "148", "149",
			"150", "151", "152", "153", "154", "155", "156", "157", "158", "159",
			"160", "161", "162", "163", "164", "165", "166", "167", "168", "169",
			"170", "171", "172", "173", "174", "175", "176", "177", "178", "179",
			"180", "181", "182", "183", "184", "185", "186", "187", "188", "189",
			"190", "191", "192", "193", "194", "195", "196", "197", "198", "199",
			"200", "201", "202", "203", "204", "205", "206", "207", "208", "209",
			"210", "211", "212", "213", "214", "215", "216", "217", "218", "219",
			"220", "221", "222", "223", "224", "225", "226", "227", "228", "229",
			"230", "231", "232", "233", "234", "235", "236", "237", "238", "239",
			"240", "241", "242", "243", "244", "245", "246", "247", "248", "249",
			"250", "251", "252", "253", "254", "255", "256", "257", "258", "259",
			"260", "261", "262", "263", "264", "265", "266", "267", "268", "269",
			"270", "271", "272", "273", "274", "275", "276", "277", "278", "279",
			"280", "281", "282", "283", "284", "285", "286", "287", "288", "289",
			"290", "291", "292", "293", "294", "295", "296", "297", "298", "299",
			"300", "301", "302", "303", "304", "305", "306", "307", "308", "309",
			"310", "311", "312", "313", "314", "315", "316", "317", "318", "319",
			"320", "321", "322", "323", "324", "325", "326", "327", "328", "329",
			"330", "331", "332", "333", "334", "335", "336", "337", "338", "339",
			"340", "341", "342", "343", "344", "345", "346", "347", "348", "349",
			"350", "351", "352", "353", "354", "355", "356", "357", "358", "359",
			"360", "361", "362", "363", "364", "365", "366", "367", "368", "369",
			"370", "371", "372", "373", "374", "375", "376", "377", "378", "379",
			"380", "381", "382", "383", "384", "385", "386", "387", "388", "389",
			"390", "391", "392", "393", "394", "395", "396", "397", "398", "399",
			"400", "401", "402", "403", "404", "405", "406", "407", "408", "409",
			"410", "411", "412", "413", "414", "415", "416", "417", "418", "419",
			"420", "421", "422", "423", "424", "425", "426", "427", "428", "429",
			"430", "431", "432", "433", "434", "435", "436", "437", "438", "439",
			"440", "441", "442", "443", "444", "445", "446", "447", "448", "449",
			"450", "451", "452", "453", "454", "455", "456", "457", "458", "459",
			"460", "461", "462", "463", "464", "465", "466", "467", "468", "469",
			"470", "471", "472", "473", "474", "475", "476", "477", "478", "479",
			"480", "481", "482", "483", "484", "485", "486", "487", "488", "489",
			"490", "491", "492", "493", "494", "495", "496", "497", "498", "499",
			"500", "501", "502", "503", "504", "505", "506", "507", "508", "509",
			"510", "511", "512", "513", "514", "515", "516", "517", "518", "519",
			"520", "521", "522", "523", "524", "525", "526", "527", "528", "529",
			"530", "531", "532", "533", "534", "535", "536", "537", "538", "539",
			"540", "541", "542", "543", "544", "545", "546", "547", "548", "549",
			"550", "551", "552", "553", "554", "555", "556", "557", "558", "559",
			"560", "561", "562", "563", "564", "565", "566", "567", "568", "569",
			"570", "571", "572", "573", "574", "575", "576", "577", "578", "579",
			"580", "581", "582", "583", "584", "585", "586", "587", "588", "589",
			"590", "591", "592", "593", "594", "595", "596", "597", "598", "599",
			"600", "601", "602", "603", "604", "605", "606", "607", "608", "609",
			"610", "611", "612", "613", "614", "615", "616", "617", "618", "619",
			"620", "621", "622", "623", "624", "625", "626", "627", "628", "629",
			"630", "631", "632", "633", "634", "635", "636", "637", "638", "639",
			"640", "641", "642", "643", "644", "645", "646", "647", "648", "649",
			"650", "651", "652", "653", "654", "655", "656", "657", "658", "659",
			"660", "661", "662", "663", "664", "665", "666", "667", "668", "669",
			"670", "671", "672", "673", "674", "675", "676", "677", "678", "679",
			"680", "681", "682", "683", "684", "685", "686", "687", "688", "689",
			"690", "691", "692", "693", "694", "695", "696", "697", "698", "699",
			"700", "701", "702", "703", "704", "705", "706", "707", "708", "709",
			"710", "711", "712", "713", "714", "715", "716", "717", "718", "719",
			"720", "721", "722", "723", "724", "725", "726", "727", "728", "729",
			"730", "731", "732", "733", "734", "735", "736", "737", "738", "739",
			"740", "741", "742", "743", "744", "745", "746", "747", "748", "749",
			"750", "751", "752", "753", "754", "755", "756", "757", "758", "759",
			"760", "761", "762", "763", "764", "765", "766", "767", "768", "769",
			"770", "771", "772", "773", "774", "775", "776", "777", "778", "779",
			"780", "781", "782", "783", "784", "785", "786", "787", "788", "789",
			"790", "791", "792", "793", "794", "795", "796", "797", "798", "799",
			"800", "801", "802", "803", "804", "805", "806", "807", "808", "809",
			"810", "811", "812", "813", "814", "815", "816", "817", "818", "819",
			"820", "821", "822", "823", "824", "825", "826", "827", "828", "829",
			"830", "831", "832", "833", "834", "835", "836", "837", "838", "839",
			"840", "841", "842", "843", "844", "845", "846", "847", "848", "849",
			"850", "851", "852", "853", "854", "855", "856", "857", "858", "859",
			"860", "861", "862", "863", "864", "865", "866", "867", "868", "869",
			"870", "871", "872", "873", "874", "875", "876", "877", "878", "879",
			"880", "881", "882", "883", "884", "885", "886", "887", "888", "889",
			"890", "891", "892", "893", "894", "895", "896", "897", "898", "899",
			"900", "901", "902", "903", "904", "905", "906", "907", "908", "909",
			"910", "911", "912", "913", "914", "915", "916", "917", "918", "919",
			"920", "921", "922", "923", "924", "925", "926", "927", "928", "929",
			"930", "931", "932", "933", "934", "935", "936", "937", "938", "939",
			"940", "941", "942", "943", "944", "945", "946", "947", "948", "949",
			"950", "951", "952", "953", "954", "955", "956", "957", "958", "959",
			"960", "961", "962", "963", "964", "965", "966", "967", "968", "969",
			"970", "971", "972", "973", "974", "975", "976", "977", "978", "979",
			"980", "981", "982", "983", "984", "985", "986", "987", "988", "989",
			"990", "991", "992", "993", "994", "995", "996", "997", "998", "999",
			"1000"
		};

		private static string ToStringLookup(long value, bool useFloatDigits = false)
		{
			if (value >= 0 && value <= 1000)
			{
				if (useFloatDigits && value < 10)
				{
					return cachedFloatDigits[value];
				}
				return cachedIntegers[value];
			}
			return value.ToString(CultureInfo.InvariantCulture);
		}

		internal static StringBuilder AppendLookup(this StringBuilder text, int value)
		{
			return text.Append(ToStringLookup(value));
		}

		internal static StringBuilder AppendLookup(this StringBuilder text, long value)
		{
			return text.Append(ToStringLookup(value));
		}

		internal static StringBuilder AppendLookup(this StringBuilder text, float value)
		{
			if (value <= 0f || value >= float.PositiveInfinity)
			{
				return text.Append("0.00");
			}
			int num = (int)value;
			int num2 = (int)((decimal)value % 1m * 100m);
			return text.Append(ToStringLookup(num)).Append('.').Append(ToStringLookup(num2, useFloatDigits: true));
		}
	}
	internal class UIUtils
	{
		internal static void ResetRectTransform(RectTransform rectTransform)
		{
			rectTransform.localRotation = Quaternion.identity;
			rectTransform.localScale = Vector3.one;
			rectTransform.pivot = new Vector2(0.5f, 0.5f);
			rectTransform.anchorMin = Vector2.zero;
			rectTransform.anchorMax = Vector2.one;
			rectTransform.anchoredPosition3D = Vector3.zero;
			rectTransform.offsetMin = Vector2.zero;
			rectTransform.offsetMax = Vector2.zero;
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.Labels
{
	internal class DrawableLabel
	{
		internal GameObject container;

		internal LabelAnchor anchor;

		internal StringBuilder newText;

		internal bool dirty;

		private GameObject labelGameObject;

		private RectTransform labelTransform;

		private ContentSizeFitter labelFitter;

		private HorizontalLayoutGroup labelGroup;

		private GameObject uiTextGameObject;

		private Text uiText;

		private Font font;

		private int fontSize;

		private float lineSpacing;

		private Vector2 pixelOffset;

		private readonly LabelEffect background;

		private UnityEngine.UI.Image backgroundImage;

		private readonly LabelEffect shadow;

		private Shadow shadowComponent;

		private readonly LabelEffect outline;

		private Outline outlineComponent;

		internal DrawableLabel(GameObject container, LabelAnchor anchor, LabelEffect background, LabelEffect shadow, LabelEffect outline, Font font, int fontSize, float lineSpacing, Vector2 pixelOffset)
		{
			this.container = container;
			this.anchor = anchor;
			this.background = background;
			this.shadow = shadow;
			this.outline = outline;
			this.font = font;
			this.fontSize = fontSize;
			this.lineSpacing = lineSpacing;
			this.pixelOffset = pixelOffset;
			NormalizeOffset();
			newText = new StringBuilder(1000);
		}

		internal void CheckAndUpdate()
		{
			if (newText.Length > 0)
			{
				if (uiText == null)
				{
					labelGameObject = new GameObject(anchor.ToString(), typeof(RectTransform));
					labelTransform = labelGameObject.GetComponent<RectTransform>();
					labelFitter = labelGameObject.AddComponent<ContentSizeFitter>();
					labelFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
					labelFitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;
					labelGroup = labelGameObject.AddComponent<HorizontalLayoutGroup>();
					labelGameObject.layer = container.layer;
					labelGameObject.tag = container.tag;
					labelGameObject.transform.SetParent(container.transform, worldPositionStays: false);
					uiTextGameObject = new GameObject("Text", typeof(Text));
					uiTextGameObject.transform.SetParent(labelGameObject.transform, worldPositionStays: false);
					uiText = uiTextGameObject.GetComponent<Text>();
					uiText.horizontalOverflow = HorizontalWrapMode.Overflow;
					uiText.verticalOverflow = VerticalWrapMode.Overflow;
					ApplyShadow();
					ApplyOutline();
					ApplyFont();
					uiText.fontSize = fontSize;
					uiText.lineSpacing = lineSpacing;
					UpdateTextPosition();
					ApplyBackground();
				}
				if (dirty)
				{
					uiText.text = newText.ToString();
					ApplyBackground();
					dirty = false;
				}
				newText.Length = 0;
			}
			else if (uiText != null)
			{
				Clear();
			}
		}

		internal void Clear()
		{
			newText.Length = 0;
			if (labelGameObject != null)
			{
				UnityEngine.Object.Destroy(labelGameObject);
				labelGameObject = null;
				labelTransform = null;
				uiText = null;
			}
			if (backgroundImage != null)
			{
				UnityEngine.Object.Destroy(backgroundImage);
				backgroundImage = null;
			}
		}

		internal void Destroy()
		{
			Clear();
			newText = null;
		}

		internal void ChangeFont(Font labelsFont)
		{
			font = labelsFont;
			ApplyFont();
			ApplyBackground();
		}

		internal void ChangeFontSize(int newSize)
		{
			fontSize = newSize;
			if (uiText != null)
			{
				uiText.fontSize = fontSize;
			}
			ApplyBackground();
		}

		internal void ChangeOffset(Vector2 newPixelOffset)
		{
			pixelOffset = newPixelOffset;
			NormalizeOffset();
			if (labelTransform != null)
			{
				labelTransform.anchoredPosition = pixelOffset;
			}
			ApplyBackground();
		}

		internal void ChangeLineSpacing(float newValueLineSpacing)
		{
			lineSpacing = newValueLineSpacing;
			if (uiText != null)
			{
				uiText.lineSpacing = newValueLineSpacing;
			}
			ApplyBackground();
		}

		internal void ChangeBackground(bool enabled)
		{
			background.enabled = enabled;
			ApplyBackground();
		}

		internal void ChangeBackgroundColor(UnityEngine.Color color)
		{
			background.color = color;
			ApplyBackground();
		}

		public void ChangeBackgroundPadding(int backgroundPadding)
		{
			background.padding = backgroundPadding;
			ApplyBackground();
		}

		internal void ChangeShadow(bool enabled)
		{
			shadow.enabled = enabled;
			ApplyShadow();
		}

		internal void ChangeShadowColor(UnityEngine.Color color)
		{
			shadow.color = color;
			ApplyShadow();
		}

		internal void ChangeShadowDistance(Vector2 distance)
		{
			shadow.distance = distance;
			ApplyShadow();
		}

		internal void ChangeOutline(bool enabled)
		{
			outline.enabled = enabled;
			ApplyOutline();
		}

		internal void ChangeOutlineColor(UnityEngine.Color color)
		{
			outline.color = color;
			ApplyOutline();
		}

		internal void ChangeOutlineDistance(Vector2 distance)
		{
			outline.distance = distance;
			ApplyOutline();
		}

		private void UpdateTextPosition()
		{
			labelTransform.localRotation = Quaternion.identity;
			labelTransform.sizeDelta = Vector2.zero;
			labelTransform.anchoredPosition = pixelOffset;
			switch (anchor)
			{
			case LabelAnchor.UpperLeft:
				uiText.alignment = TextAnchor.UpperLeft;
				labelTransform.anchorMin = Vector2.up;
				labelTransform.anchorMax = Vector2.up;
				labelTransform.pivot = new Vector2(0f, 1f);
				break;
			case LabelAnchor.UpperRight:
				uiText.alignment = TextAnchor.UpperRight;
				labelTransform.anchorMin = Vector2.one;
				labelTransform.anchorMax = Vector2.one;
				labelTransform.pivot = new Vector2(1f, 1f);
				break;
			case LabelAnchor.LowerLeft:
				uiText.alignment = TextAnchor.LowerLeft;
				labelTransform.anchorMin = Vector2.zero;
				labelTransform.anchorMax = Vector2.zero;
				labelTransform.pivot = new Vector2(0f, 0f);
				break;
			case LabelAnchor.LowerRight:
				uiText.alignment = TextAnchor.LowerRight;
				labelTransform.anchorMin = Vector2.right;
				labelTransform.anchorMax = Vector2.right;
				labelTransform.pivot = new Vector2(1f, 0f);
				break;
			case LabelAnchor.UpperCenter:
				uiText.alignment = TextAnchor.UpperCenter;
				labelTransform.anchorMin = new Vector2(0.5f, 1f);
				labelTransform.anchorMax = new Vector2(0.5f, 1f);
				labelTransform.pivot = new Vector2(0.5f, 1f);
				break;
			case LabelAnchor.LowerCenter:
				uiText.alignment = TextAnchor.LowerCenter;
				labelTransform.anchorMin = new Vector2(0.5f, 0f);
				labelTransform.anchorMax = new Vector2(0.5f, 0f);
				labelTransform.pivot = new Vector2(0.5f, 0f);
				break;
			default:
				Debug.LogWarning("[AFPSCounter]: Unknown label anchor!", uiText);
				uiText.alignment = TextAnchor.UpperLeft;
				labelTransform.anchorMin = Vector2.up;
				labelTransform.anchorMax = Vector2.up;
				break;
			}
		}

		private void NormalizeOffset()
		{
			switch (anchor)
			{
			case LabelAnchor.UpperLeft:
				pixelOffset.y = 0f - pixelOffset.y;
				break;
			case LabelAnchor.UpperRight:
				pixelOffset.x = 0f - pixelOffset.x;
				pixelOffset.y = 0f - pixelOffset.y;
				break;
			case LabelAnchor.LowerRight:
				pixelOffset.x = 0f - pixelOffset.x;
				break;
			case LabelAnchor.UpperCenter:
				pixelOffset.y = 0f - pixelOffset.y;
				pixelOffset.x = 0f;
				break;
			case LabelAnchor.LowerCenter:
				pixelOffset.x = 0f;
				break;
			default:
				pixelOffset.y = 0f - pixelOffset.y;
				break;
			case LabelAnchor.LowerLeft:
				break;
			}
		}

		private void ApplyBackground()
		{
			if (uiText == null)
			{
				return;
			}
			if (background.enabled && !backgroundImage)
			{
				backgroundImage = labelGameObject.AddComponent<UnityEngine.UI.Image>();
			}
			if (!background.enabled && (bool)backgroundImage)
			{
				UnityEngine.Object.Destroy(backgroundImage);
				backgroundImage = null;
			}
			if (backgroundImage != null)
			{
				if (backgroundImage.color != background.color)
				{
					backgroundImage.color = background.color;
				}
				if (labelGroup.padding.bottom != background.padding)
				{
					labelGroup.padding.top = background.padding;
					labelGroup.padding.left = background.padding;
					labelGroup.padding.right = background.padding;
					labelGroup.padding.bottom = background.padding;
					labelGroup.SetLayoutHorizontal();
				}
			}
		}

		private void ApplyShadow()
		{
			if (!(uiText == null))
			{
				if (shadow.enabled && !shadowComponent)
				{
					shadowComponent = uiTextGameObject.AddComponent<Shadow>();
				}
				if (!shadow.enabled && (bool)shadowComponent)
				{
					UnityEngine.Object.Destroy(shadowComponent);
				}
				if (shadowComponent != null)
				{
					shadowComponent.effectColor = shadow.color;
					shadowComponent.effectDistance = shadow.distance;
				}
			}
		}

		private void ApplyOutline()
		{
			if (!(uiText == null))
			{
				if (outline.enabled && !outlineComponent)
				{
					outlineComponent = uiTextGameObject.AddComponent<Outline>();
				}
				if (!outline.enabled && (bool)outlineComponent)
				{
					UnityEngine.Object.Destroy(outlineComponent);
				}
				if (outlineComponent != null)
				{
					outlineComponent.effectColor = outline.color;
					outlineComponent.effectDistance = outline.distance;
				}
			}
		}

		private void ApplyFont()
		{
			if (!(uiText == null))
			{
				if (font == null)
				{
					font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				}
				uiText.font = font;
			}
		}
	}
	public enum LabelAnchor : byte
	{
		UpperLeft,
		UpperRight,
		LowerLeft,
		LowerRight,
		UpperCenter,
		LowerCenter
	}
	internal class LabelEffect
	{
		public bool enabled;

		public UnityEngine.Color color;

		public Vector2 distance;

		public int padding;

		internal LabelEffect(bool enabled, UnityEngine.Color color, int padding)
			: this(enabled, color, Vector2.zero)
		{
			this.padding = padding;
		}

		internal LabelEffect(bool enabled, UnityEngine.Color color, Vector2 distance)
		{
			this.enabled = enabled;
			this.color = color;
			this.distance = distance;
		}
	}
}
namespace CodeStage.AdvancedFPSCounter.CountersData
{
	[Serializable]
	[AddComponentMenu("")]
	public abstract class BaseCounterData
	{
		protected const string BoldStart = "<b>";

		protected const string BoldEnd = "</b>";

		protected const string ItalicStart = "<i>";

		protected const string ItalicEnd = "</i>";

		internal StringBuilder text;

		internal bool dirty;

		[NonSerialized]
		protected AFPSCounter main;

		protected string colorCached;

		protected bool inited;

		[SerializeField]
		protected bool enabled = true;

		[Tooltip("Current anchoring label for the counter output.\nRefreshes both previous and specified label when switching anchor.")]
		[SerializeField]
		protected LabelAnchor anchor;

		[Tooltip("Regular color of the counter output.")]
		[SerializeField]
		protected UnityEngine.Color color;

		[Tooltip("Controls text style.")]
		[SerializeField]
		protected FontStyle style;

		[Tooltip("Additional text to append to the end of the counter in normal Operation Mode.")]
		protected string extraText;

		public bool Enabled
		{
			get
			{
				return enabled;
			}
			set
			{
				if (enabled != value && Application.isPlaying)
				{
					enabled = value;
					if (enabled)
					{
						Activate();
					}
					else
					{
						Deactivate();
					}
					main.UpdateTexts();
				}
			}
		}

		public LabelAnchor Anchor
		{
			get
			{
				return anchor;
			}
			set
			{
				if (anchor != value && Application.isPlaying)
				{
					LabelAnchor labelAnchor = anchor;
					anchor = value;
					if (enabled)
					{
						dirty = true;
						main.MakeDrawableLabelDirty(labelAnchor);
						main.UpdateTexts();
					}
				}
			}
		}

		public UnityEngine.Color Color
		{
			get
			{
				return color;
			}
			set
			{
				if (!(color == value) && Application.isPlaying)
				{
					color = value;
					if (enabled)
					{
						CacheCurrentColor();
						Refresh();
					}
				}
			}
		}

		public FontStyle Style
		{
			get
			{
				return style;
			}
			set
			{
				if (style != value && Application.isPlaying)
				{
					style = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public string ExtraText
		{
			get
			{
				return extraText;
			}
			set
			{
				if (!(extraText == value) && Application.isPlaying)
				{
					extraText = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public void Refresh()
		{
			if (enabled && Application.isPlaying)
			{
				UpdateValue(force: true);
				main.UpdateTexts();
			}
		}

		internal virtual void UpdateValue()
		{
			UpdateValue(force: false);
		}

		internal abstract void UpdateValue(bool force);

		internal void Init(AFPSCounter reference)
		{
			main = reference;
		}

		internal void Destroy()
		{
			main = null;
			if (text != null)
			{
				text.Remove(0, text.Length);
				text = null;
			}
		}

		internal virtual void Activate()
		{
			if (enabled && main.OperationMode != 0 && HasData())
			{
				if (text == null)
				{
					text = new StringBuilder(500);
				}
				else
				{
					text.Length = 0;
				}
				if (main.OperationMode == OperationMode.Normal && colorCached == null)
				{
					CacheCurrentColor();
				}
				PerformActivationActions();
				if (!inited)
				{
					PerformInitActions();
					inited = true;
				}
				UpdateValue();
			}
		}

		internal virtual void Deactivate()
		{
			if (inited)
			{
				if (text != null)
				{
					text.Length = 0;
				}
				main.MakeDrawableLabelDirty(anchor);
				PerformDeActivationActions();
				inited = false;
			}
		}

		protected virtual void PerformInitActions()
		{
		}

		protected virtual void PerformActivationActions()
		{
		}

		protected virtual void PerformDeActivationActions()
		{
		}

		protected abstract bool HasData();

		protected abstract void CacheCurrentColor();

		protected void ApplyTextStyles()
		{
			if (text.Length > 0)
			{
				switch (style)
				{
				case FontStyle.Bold:
					text.Insert(0, "<b>");
					text.Append("</b>");
					break;
				case FontStyle.Italic:
					text.Insert(0, "<i>");
					text.Append("</i>");
					break;
				case FontStyle.BoldAndItalic:
					text.Insert(0, "<b>");
					text.Append("</b>");
					text.Insert(0, "<i>");
					text.Append("</i>");
					break;
				default:
					throw new ArgumentOutOfRangeException();
				case FontStyle.Normal:
					break;
				}
			}
			if (!string.IsNullOrEmpty(extraText))
			{
				text.Append('\n').Append(extraText);
			}
		}
	}
	public abstract class UpdatableCounterData : BaseCounterData
	{
		protected Coroutine updateCoroutine;

		[Tooltip("Update interval in seconds.")]
		[Range(0.1f, 10f)]
		[SerializeField]
		protected float updateInterval = 0.5f;

		public float UpdateInterval
		{
			get
			{
				return updateInterval;
			}
			set
			{
				if (!(Math.Abs(updateInterval - value) < 0.001f) && Application.isPlaying)
				{
					updateInterval = value;
				}
			}
		}

		protected override void PerformInitActions()
		{
			base.PerformInitActions();
			StartUpdateCoroutine();
		}

		protected override void PerformDeActivationActions()
		{
			base.PerformDeActivationActions();
			StopUpdateCoroutine();
		}

		protected abstract IEnumerator UpdateCounter();

		private void StartUpdateCoroutine()
		{
			updateCoroutine = main.StartCoroutine(UpdateCounter());
		}

		private void StopUpdateCoroutine()
		{
			main.StopCoroutine(updateCoroutine);
		}
	}
	[Serializable]
	[AddComponentMenu("")]
	public class DeviceInfoCounterData : BaseCounterData
	{
		[Tooltip("Shows operating system & platform info.")]
		[SerializeField]
		private bool platform = true;

		[Tooltip("CPU model and cores (including virtual cores from Intel's Hyper Threading) count.")]
		[SerializeField]
		private bool cpuModel = true;

		[Tooltip("Check to show CPU model on new line.")]
		[SerializeField]
		private bool cpuModelNewLine = true;

		[Tooltip("Shows GPU model name.")]
		[SerializeField]
		private bool gpuModel = true;

		[Tooltip("Check to show GPU model on new line.")]
		[SerializeField]
		private bool gpuModelNewLine = true;

		[Tooltip("Shows graphics API version and type (if possible).")]
		[SerializeField]
		private bool gpuApi = true;

		[Tooltip("Check to show graphics API version on new line.")]
		[SerializeField]
		private bool gpuApiNewLine = true;

		[Tooltip("Shows graphics supported shader model (if possible), approximate pixel fill-rate (if possible) and total Video RAM size (if possible).")]
		[SerializeField]
		private bool gpuSpec = true;

		[Tooltip("Check to show graphics specs on new line.")]
		[SerializeField]
		private bool gpuSpecNewLine = true;

		[Tooltip("Shows total RAM size.")]
		[SerializeField]
		private bool ramSize = true;

		[Tooltip("Check to show RAM size on new line.")]
		[SerializeField]
		private bool ramSizeNewLine = true;

		[Tooltip("Shows screen resolution, size and DPI (if possible).")]
		[SerializeField]
		private bool screenData = true;

		[Tooltip("Check to show screen data on new line.")]
		[SerializeField]
		private bool screenDataNewLine = true;

		[Tooltip("Shows device model. Actual for mobile devices.")]
		[SerializeField]
		private bool deviceModel;

		[Tooltip("Check to show device model on new line.")]
		[SerializeField]
		private bool deviceModelNewLine = true;

		public bool Platform
		{
			get
			{
				return platform;
			}
			set
			{
				if (platform != value && Application.isPlaying)
				{
					platform = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool CpuModel
		{
			get
			{
				return cpuModel;
			}
			set
			{
				if (cpuModel != value && Application.isPlaying)
				{
					cpuModel = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool CpuModelNewLine
		{
			get
			{
				return cpuModelNewLine;
			}
			set
			{
				if (cpuModelNewLine != value && Application.isPlaying)
				{
					cpuModelNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuModel
		{
			get
			{
				return gpuModel;
			}
			set
			{
				if (gpuModel != value && Application.isPlaying)
				{
					gpuModel = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuModelNewLine
		{
			get
			{
				return gpuModelNewLine;
			}
			set
			{
				if (gpuModelNewLine != value && Application.isPlaying)
				{
					gpuModelNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuApi
		{
			get
			{
				return gpuApi;
			}
			set
			{
				if (gpuApi != value && Application.isPlaying)
				{
					gpuApi = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuApiNewLine
		{
			get
			{
				return gpuApiNewLine;
			}
			set
			{
				if (gpuApiNewLine != value && Application.isPlaying)
				{
					gpuApiNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuSpec
		{
			get
			{
				return gpuSpec;
			}
			set
			{
				if (gpuSpec != value && Application.isPlaying)
				{
					gpuSpec = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool GpuSpecNewLine
		{
			get
			{
				return gpuSpecNewLine;
			}
			set
			{
				if (gpuSpecNewLine != value && Application.isPlaying)
				{
					gpuSpecNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool RamSize
		{
			get
			{
				return ramSize;
			}
			set
			{
				if (ramSize != value && Application.isPlaying)
				{
					ramSize = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool RamSizeNewLine
		{
			get
			{
				return ramSizeNewLine;
			}
			set
			{
				if (ramSizeNewLine != value && Application.isPlaying)
				{
					ramSizeNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool ScreenData
		{
			get
			{
				return screenData;
			}
			set
			{
				if (screenData != value && Application.isPlaying)
				{
					screenData = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool ScreenDataNewLine
		{
			get
			{
				return screenDataNewLine;
			}
			set
			{
				if (screenDataNewLine != value && Application.isPlaying)
				{
					screenDataNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool DeviceModel
		{
			get
			{
				return deviceModel;
			}
			set
			{
				if (deviceModel != value && Application.isPlaying)
				{
					deviceModel = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool DeviceModelNewLine
		{
			get
			{
				return deviceModelNewLine;
			}
			set
			{
				if (deviceModelNewLine != value && Application.isPlaying)
				{
					deviceModelNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public string LastValue { get; private set; }

		internal DeviceInfoCounterData()
		{
			color = new Color32(172, 172, 172, byte.MaxValue);
			anchor = LabelAnchor.LowerLeft;
		}

		internal override void UpdateValue(bool force)
		{
			if (!inited && HasData())
			{
				Activate();
			}
			else if (inited && !HasData())
			{
				Deactivate();
			}
			else
			{
				if (!enabled)
				{
					return;
				}
				bool flag = false;
				if (text == null)
				{
					text = new StringBuilder(500);
				}
				else
				{
					text.Length = 0;
				}
				if (platform)
				{
					text.Append("OS: ").Append(SystemInfo.operatingSystem).Append(" [")
						.Append(Application.platform)
						.Append("]");
					flag = true;
				}
				if (cpuModel)
				{
					if (flag)
					{
						text.Append(cpuModelNewLine ? '\n' : ' ');
					}
					text.Append("CPU: ").Append(SystemInfo.processorType).Append(" [")
						.Append(SystemInfo.processorCount)
						.Append(" cores]");
					flag = true;
				}
				if (gpuModel)
				{
					if (flag)
					{
						text.Append(gpuModelNewLine ? '\n' : ' ');
					}
					text.Append("GPU: ").Append(SystemInfo.graphicsDeviceName);
					flag = true;
				}
				if (gpuApi)
				{
					if (flag)
					{
						text.Append(gpuApiNewLine ? '\n' : ' ');
					}
					if (gpuApiNewLine || !gpuModel)
					{
						text.Append("GPU: ");
					}
					text.Append(SystemInfo.graphicsDeviceVersion);
					text.Append(" [").Append(SystemInfo.graphicsDeviceType).Append("]");
					flag = true;
				}
				if (gpuSpec)
				{
					if (flag)
					{
						text.Append(gpuSpecNewLine ? '\n' : ' ');
					}
					if (gpuSpecNewLine || (!gpuModel && !gpuApi))
					{
						text.Append("GPU: SM: ");
					}
					else
					{
						text.Append("SM: ");
					}
					int graphicsShaderLevel = SystemInfo.graphicsShaderLevel;
					if (graphicsShaderLevel >= 10 && graphicsShaderLevel <= 99)
					{
						text.Append(graphicsShaderLevel /= 10).Append('.').Append(graphicsShaderLevel / 10);
					}
					else
					{
						text.Append("N/A");
					}
					text.Append(", VRAM: ");
					int graphicsMemorySize = SystemInfo.graphicsMemorySize;
					if (graphicsMemorySize > 0)
					{
						text.Append(graphicsMemorySize).Append(" MB");
					}
					else
					{
						text.Append("N/A");
					}
					flag = true;
				}
				if (ramSize)
				{
					if (flag)
					{
						text.Append(ramSizeNewLine ? '\n' : ' ');
					}
					int systemMemorySize = SystemInfo.systemMemorySize;
					if (systemMemorySize > 0)
					{
						text.Append("RAM: ").Append(systemMemorySize).Append(" MB");
						flag = true;
					}
					else
					{
						flag = false;
					}
				}
				if (screenData)
				{
					if (flag)
					{
						text.Append(screenDataNewLine ? '\n' : ' ');
					}
					Resolution currentResolution = Screen.currentResolution;
					text.Append("SCR: ").Append(currentResolution.width).Append("x")
						.Append(currentResolution.height)
						.Append("@")
						.Append(currentResolution.refreshRate)
						.Append("Hz [window size: ")
						.Append(Screen.width)
						.Append("x")
						.Append(Screen.height);
					float dpi = Screen.dpi;
					if (dpi > 0f)
					{
						text.Append(", DPI: ").Append(dpi).Append("]");
					}
					else
					{
						text.Append("]");
					}
					flag = true;
				}
				if (deviceModel)
				{
					if (flag)
					{
						text.Append(deviceModelNewLine ? '\n' : ' ');
					}
					text.Append("Model: ").Append(SystemInfo.deviceModel);
				}
				LastValue = text.ToString();
				if (main.OperationMode == OperationMode.Normal)
				{
					text.Insert(0, colorCached);
					text.Append("</color>");
					ApplyTextStyles();
				}
				else
				{
					text.Length = 0;
				}
				dirty = true;
			}
		}

		protected override bool HasData()
		{
			if (!cpuModel && !gpuModel && !ramSize)
			{
				return screenData;
			}
			return true;
		}

		protected override void CacheCurrentColor()
		{
			colorCached = "<color=#" + AFPSCounter.Color32ToHex(color) + ">";
		}
	}
	[Serializable]
	[AddComponentMenu("")]
	public class FPSCounterData : UpdatableCounterData
	{
		private const string ColorTextStart = "<color=#{0}>";

		private const string ColorTextEnd = "</color>";

		private const string FPSTextStart = "<color=#{0}>FPS: ";

		private const string MsTextStart = " <color=#{0}>[";

		private const string MsTextEnd = " MS]</color>";

		private const string MinTextStart = "<color=#{0}>MIN: ";

		private const string MaxTextStart = "<color=#{0}>MAX: ";

		private const string AvgTextStart = "<color=#{0}>AVG: ";

		private const string RenderTextStart = "<color=#{0}>REN: ";

		public int warningLevelValue = 50;

		public int criticalLevelValue = 20;

		[Tooltip("Average FPS counter accumulative data will be reset on new scene load if enabled.")]
		public bool resetAverageOnNewScene;

		[Tooltip("Minimum and maximum FPS readouts will be reset on new scene load if enabled")]
		public bool resetMinMaxOnNewScene;

		[Tooltip("Amount of update intervals to skip before recording minimum and maximum FPS.\nUse it to skip initialization performance spikes and drops.")]
		[Range(0f, 10f)]
		public int minMaxIntervalsToSkip = 3;

		internal float newValue;

		private string colorCachedMs;

		private string colorCachedMin;

		private string colorCachedMax;

		private string colorCachedAvg;

		private string colorCachedRender;

		private string colorWarningCached;

		private string colorWarningCachedMs;

		private string colorWarningCachedMin;

		private string colorWarningCachedMax;

		private string colorWarningCachedAvg;

		private string colorCriticalCached;

		private string colorCriticalCachedMs;

		private string colorCriticalCachedMin;

		private string colorCriticalCachedMax;

		private string colorCriticalCachedAvg;

		private int currentAverageSamples;

		private float currentAverageRaw;

		private float[] accumulatedAverageSamples;

		private int minMaxIntervalsSkipped;

		private float renderTimeBank;

		private int previousFrameCount;

		[Tooltip("Shows realtime FPS at the moment of the counter update scene start. Allows to hide FPS readout if necessary.")]
		[SerializeField]
		private bool realtimeFPS;

		[Tooltip("Shows time in milliseconds spent to render 1 frame.")]
		[SerializeField]
		private bool milliseconds;

		[Tooltip("Shows Average FPS calculated from specified Samples amount or since game / scene start, depending on Samples value and 'Reset On Load' toggle.")]
		[SerializeField]
		private bool average;

		[Tooltip("Shows time in milliseconds for the average FPS.")]
		[SerializeField]
		private bool averageMilliseconds;

		[Tooltip("Controls placing Average on the new line.")]
		[SerializeField]
		private bool averageNewLine;

		[Tooltip("Amount of last samples to get average from. Set 0 to get average from all samples since startup or level load.\nOne Sample recorded per one Interval.")]
		[Range(0f, 100f)]
		[SerializeField]
		private int averageSamples = 50;

		[Tooltip("Shows minimum and maximum FPS readouts since game / scene start, depending on 'Reset On Load' toggle.")]
		[SerializeField]
		private bool minMax;

		[Tooltip("Shows time in milliseconds for the Min Max FPS.")]
		[SerializeField]
		private bool minMaxMilliseconds;

		[Tooltip("Controls placing Min Max on the new line.")]
		[SerializeField]
		private bool minMaxNewLine;

		[Tooltip("Check to place Min Max on two separate lines. Otherwise they will be placed on a single line.")]
		[SerializeField]
		private bool minMaxTwoLines;

		[Tooltip("Shows time spent on Camera.Render excluding Image Effects. Add AFPSRenderRecorder to the cameras you wish to count.")]
		[SerializeField]
		private bool render;

		[Tooltip("Controls placing Render on the new line.")]
		[SerializeField]
		private bool renderNewLine;

		[Tooltip("Check to automatically add AFPSRenderRecorder to the Main Camera if present.")]
		[SerializeField]
		private bool renderAutoAdd = true;

		[Tooltip("Color of the FPS counter while FPS is between Critical and Warning levels.")]
		[SerializeField]
		private UnityEngine.Color colorWarning = new Color32(236, 224, 88, byte.MaxValue);

		[Tooltip("Color of the FPS counter while FPS is below Critical level.")]
		[SerializeField]
		private UnityEngine.Color colorCritical = new Color32(249, 91, 91, byte.MaxValue);

		[Tooltip("Color of the Render Time output.")]
		[SerializeField]
		protected UnityEngine.Color colorRender;

		public bool RealtimeFPS
		{
			get
			{
				return realtimeFPS;
			}
			set
			{
				if (realtimeFPS != value && Application.isPlaying)
				{
					realtimeFPS = value;
					if (!realtimeFPS)
					{
						LastValue = 0;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Milliseconds
		{
			get
			{
				return milliseconds;
			}
			set
			{
				if (milliseconds != value && Application.isPlaying)
				{
					milliseconds = value;
					if (!milliseconds)
					{
						LastMillisecondsValue = 0f;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Average
		{
			get
			{
				return average;
			}
			set
			{
				if (average != value && Application.isPlaying)
				{
					average = value;
					if (!average)
					{
						ResetAverage();
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool AverageMilliseconds
		{
			get
			{
				return averageMilliseconds;
			}
			set
			{
				if (averageMilliseconds != value && Application.isPlaying)
				{
					averageMilliseconds = value;
					if (!averageMilliseconds)
					{
						LastAverageMillisecondsValue = 0f;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool AverageNewLine
		{
			get
			{
				return averageNewLine;
			}
			set
			{
				if (averageNewLine != value && Application.isPlaying)
				{
					averageNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public int AverageSamples
		{
			get
			{
				return averageSamples;
			}
			set
			{
				if (averageSamples == value || !Application.isPlaying)
				{
					return;
				}
				averageSamples = value;
				if (!enabled)
				{
					return;
				}
				if (averageSamples > 0)
				{
					if (accumulatedAverageSamples == null)
					{
						accumulatedAverageSamples = new float[averageSamples];
					}
					else if (accumulatedAverageSamples.Length != averageSamples)
					{
						Array.Resize(ref accumulatedAverageSamples, averageSamples);
					}
				}
				else
				{
					accumulatedAverageSamples = null;
				}
				ResetAverage();
				Refresh();
			}
		}

		public bool MinMax
		{
			get
			{
				return minMax;
			}
			set
			{
				if (minMax != value && Application.isPlaying)
				{
					minMax = value;
					if (!minMax)
					{
						ResetMinMax();
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool MinMaxMilliseconds
		{
			get
			{
				return minMaxMilliseconds;
			}
			set
			{
				if (minMaxMilliseconds != value && Application.isPlaying)
				{
					minMaxMilliseconds = value;
					if (!minMaxMilliseconds)
					{
						LastMinMillisecondsValue = 0f;
						LastMaxMillisecondsValue = 0f;
					}
					else
					{
						LastMinMillisecondsValue = 1000f / (float)LastMinimumValue;
						LastMaxMillisecondsValue = 1000f / (float)LastMaximumValue;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool MinMaxNewLine
		{
			get
			{
				return minMaxNewLine;
			}
			set
			{
				if (minMaxNewLine != value && Application.isPlaying)
				{
					minMaxNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool MinMaxTwoLines
		{
			get
			{
				return minMaxTwoLines;
			}
			set
			{
				if (minMaxTwoLines != value && Application.isPlaying)
				{
					minMaxTwoLines = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Render
		{
			get
			{
				return render;
			}
			set
			{
				if (render == value || !Application.isPlaying)
				{
					return;
				}
				render = value;
				if (!render)
				{
					if (renderAutoAdd)
					{
						TryToRemoveRenderRecorder();
					}
					return;
				}
				previousFrameCount = Time.frameCount;
				if (renderAutoAdd)
				{
					TryToAddRenderRecorder();
				}
				Refresh();
			}
		}

		public bool RenderNewLine
		{
			get
			{
				return renderNewLine;
			}
			set
			{
				if (renderNewLine != value && Application.isPlaying)
				{
					renderNewLine = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool RenderAutoAdd
		{
			get
			{
				return renderAutoAdd;
			}
			set
			{
				if (renderAutoAdd != value && Application.isPlaying)
				{
					renderAutoAdd = value;
					if (enabled)
					{
						TryToAddRenderRecorder();
						Refresh();
					}
				}
			}
		}

		public UnityEngine.Color ColorWarning
		{
			get
			{
				return colorWarning;
			}
			set
			{
				if (!(colorWarning == value) && Application.isPlaying)
				{
					colorWarning = value;
					if (enabled)
					{
						CacheWarningColor();
						Refresh();
					}
				}
			}
		}

		public UnityEngine.Color ColorCritical
		{
			get
			{
				return colorCritical;
			}
			set
			{
				if (!(colorCritical == value) && Application.isPlaying)
				{
					colorCritical = value;
					if (enabled)
					{
						CacheCriticalColor();
						Refresh();
					}
				}
			}
		}

		public UnityEngine.Color ColorRender
		{
			get
			{
				return colorRender;
			}
			set
			{
				if (!(colorRender == value) && Application.isPlaying)
				{
					colorRender = value;
					if (enabled)
					{
						CacheCurrentColor();
						Refresh();
					}
				}
			}
		}

		public int LastValue { get; private set; }

		public float LastMillisecondsValue { get; private set; }

		public float LastRenderValue { get; private set; }

		public int LastAverageValue { get; private set; }

		public float LastAverageMillisecondsValue { get; private set; }

		public int LastMinimumValue { get; private set; }

		public int LastMaximumValue { get; private set; }

		public float LastMinMillisecondsValue { get; private set; }

		public float LastMaxMillisecondsValue { get; private set; }

		public FPSLevel CurrentFpsLevel { get; private set; }

		public event Action<FPSLevel> OnFPSLevelChange;

		internal FPSCounterData()
		{
			color = new Color32(85, 218, 102, byte.MaxValue);
			colorRender = new Color32(167, 110, 209, byte.MaxValue);
			style = FontStyle.Bold;
			realtimeFPS = true;
			milliseconds = true;
			render = false;
			renderNewLine = true;
			average = true;
			averageMilliseconds = true;
			averageNewLine = true;
			resetAverageOnNewScene = true;
			minMax = true;
			minMaxNewLine = true;
			resetMinMaxOnNewScene = true;
		}

		public void ResetAverage()
		{
			if (Application.isPlaying)
			{
				LastAverageValue = 0;
				currentAverageSamples = 0;
				currentAverageRaw = 0f;
				if (averageSamples > 0 && accumulatedAverageSamples != null)
				{
					Array.Clear(accumulatedAverageSamples, 0, accumulatedAverageSamples.Length);
				}
			}
		}

		public void ResetMinMax(bool withoutUpdate = false)
		{
			if (Application.isPlaying)
			{
				LastMinimumValue = -1;
				LastMaximumValue = -1;
				minMaxIntervalsSkipped = 0;
				UpdateValue(force: true);
				dirty = true;
			}
		}

		internal void OnLevelLoadedCallback()
		{
			if (minMax && resetMinMaxOnNewScene)
			{
				ResetMinMax();
			}
			if (average && resetAverageOnNewScene)
			{
				ResetAverage();
			}
			if (render && renderAutoAdd)
			{
				TryToAddRenderRecorder();
			}
		}

		internal void AddRenderTime(float time)
		{
			if (enabled && inited)
			{
				renderTimeBank += time;
			}
		}

		internal override void UpdateValue(bool force)
		{
			if (!enabled)
			{
				return;
			}
			if (!realtimeFPS && !average && !minMax && !render)
			{
				if (text.Length > 0)
				{
					text.Length = 0;
				}
				return;
			}
			int num = (int)newValue;
			if (LastValue != num || force)
			{
				LastValue = num;
				dirty = true;
			}
			if (LastValue <= criticalLevelValue)
			{
				if (LastValue != 0 && CurrentFpsLevel != FPSLevel.Critical)
				{
					CurrentFpsLevel = FPSLevel.Critical;
					if (this.OnFPSLevelChange != null)
					{
						this.OnFPSLevelChange(CurrentFpsLevel);
					}
				}
			}
			else if (LastValue < warningLevelValue)
			{
				if (LastValue != 0 && CurrentFpsLevel != FPSLevel.Warning)
				{
					CurrentFpsLevel = FPSLevel.Warning;
					if (this.OnFPSLevelChange != null)
					{
						this.OnFPSLevelChange(CurrentFpsLevel);
					}
				}
			}
			else if (LastValue != 0 && CurrentFpsLevel != 0)
			{
				CurrentFpsLevel = FPSLevel.Normal;
				if (this.OnFPSLevelChange != null)
				{
					this.OnFPSLevelChange(CurrentFpsLevel);
				}
			}
			if (dirty && milliseconds)
			{
				LastMillisecondsValue = 1000f / newValue;
			}
			if (render && renderTimeBank > 0f)
			{
				int frameCount = Time.frameCount;
				int num2 = frameCount - previousFrameCount;
				if (num2 == 0)
				{
					num2 = 1;
				}
				float num3 = renderTimeBank / (float)num2;
				if (Math.Abs(num3 - LastRenderValue) > 0.0001f || force)
				{
					LastRenderValue = num3;
					dirty = true;
				}
				previousFrameCount = frameCount;
				renderTimeBank = 0f;
			}
			int num4 = 0;
			if (average)
			{
				if (averageSamples == 0)
				{
					currentAverageSamples++;
					currentAverageRaw += ((float)LastValue - currentAverageRaw) / (float)currentAverageSamples;
				}
				else
				{
					if (accumulatedAverageSamples == null)
					{
						accumulatedAverageSamples = new float[averageSamples];
						ResetAverage();
					}
					accumulatedAverageSamples[currentAverageSamples % averageSamples] = LastValue;
					currentAverageSamples++;
					currentAverageRaw = GetAverageFromAccumulatedSamples();
				}
				num4 = Mathf.RoundToInt(currentAverageRaw);
				if (LastAverageValue != num4 || force)
				{
					LastAverageValue = num4;
					dirty = true;
					if (averageMilliseconds)
					{
						LastAverageMillisecondsValue = 1000f / (float)LastAverageValue;
					}
				}
			}
			if (minMax)
			{
				if (minMaxIntervalsSkipped <= minMaxIntervalsToSkip)
				{
					if (!force)
					{
						minMaxIntervalsSkipped++;
					}
				}
				else if (LastMinimumValue == -1)
				{
					dirty = true;
				}
				if (minMaxIntervalsSkipped > minMaxIntervalsToSkip && dirty)
				{
					if (LastMinimumValue == -1)
					{
						LastMinimumValue = LastValue;
						if (minMaxMilliseconds)
						{
							LastMinMillisecondsValue = 1000f / (float)LastMinimumValue;
						}
					}
					else if (LastValue < LastMinimumValue)
					{
						LastMinimumValue = LastValue;
						if (minMaxMilliseconds)
						{
							LastMinMillisecondsValue = 1000f / (float)LastMinimumValue;
						}
					}
					if (LastMaximumValue == -1)
					{
						LastMaximumValue = LastValue;
						if (minMaxMilliseconds)
						{
							LastMaxMillisecondsValue = 1000f / (float)LastMaximumValue;
						}
					}
					else if (LastValue > LastMaximumValue)
					{
						LastMaximumValue = LastValue;
						if (minMaxMilliseconds)
						{
							LastMaxMillisecondsValue = 1000f / (float)LastMaximumValue;
						}
					}
				}
			}
			if (!dirty || main.OperationMode != OperationMode.Normal)
			{
				return;
			}
			text.Length = 0;
			if (realtimeFPS)
			{
				string value = ((LastValue >= warningLevelValue) ? colorCached : ((LastValue > criticalLevelValue) ? colorWarningCached : colorCriticalCached));
				text.Append(value).AppendLookup(LastValue).Append("</color>");
				if (milliseconds)
				{
					value = ((LastValue >= warningLevelValue) ? colorCachedMs : ((LastValue > criticalLevelValue) ? colorWarningCachedMs : colorCriticalCachedMs));
					text.Append(value).AppendLookup(LastMillisecondsValue).Append(" MS]</color>");
				}
			}
			if (average)
			{
				if (realtimeFPS)
				{
					text.Append(averageNewLine ? '\n' : ' ');
				}
				string value = ((num4 >= warningLevelValue) ? colorCachedAvg : ((num4 > criticalLevelValue) ? colorWarningCachedAvg : colorCriticalCachedAvg));
				text.Append(value).AppendLookup(num4);
				if (averageMilliseconds)
				{
					text.Append(" [").AppendLookup(LastAverageMillisecondsValue).Append(" MS]");
				}
				text.Append("</color>");
			}
			if (minMax)
			{
				if (realtimeFPS || average)
				{
					text.Append(minMaxNewLine ? '\n' : ' ');
				}
				string value = ((LastMinimumValue >= warningLevelValue) ? colorCachedMin : ((LastMinimumValue > criticalLevelValue) ? colorWarningCachedMin : colorCriticalCachedMin));
				text.Append(value).AppendLookup(LastMinimumValue);
				if (minMaxMilliseconds)
				{
					text.Append(" [").AppendLookup(LastMinMillisecondsValue).Append(" MS]");
				}
				text.Append("</color>");
				text.Append(minMaxTwoLines ? '\n' : ' ');
				value = ((LastMaximumValue >= warningLevelValue) ? colorCachedMax : ((LastMaximumValue > criticalLevelValue) ? colorWarningCachedMax : colorCriticalCachedMax));
				text.Append(value).AppendLookup(LastMaximumValue);
				if (minMaxMilliseconds)
				{
					text.Append(" [").AppendLookup(LastMaxMillisecondsValue).Append(" MS]");
				}
				text.Append("</color>");
			}
			if (render)
			{
				if (realtimeFPS || average || minMax)
				{
					text.Append(renderNewLine ? '\n' : ' ');
				}
				text.Append(colorCachedRender).AppendLookup(LastRenderValue).Append(" MS")
					.Append("</color>");
			}
			ApplyTextStyles();
		}

		protected override void PerformActivationActions()
		{
			base.PerformActivationActions();
			LastValue = 0;
			LastMinimumValue = -1;
			if (render)
			{
				previousFrameCount = Time.frameCount;
				if (renderAutoAdd)
				{
					TryToAddRenderRecorder();
				}
			}
			if (main.OperationMode == OperationMode.Normal)
			{
				if (colorWarningCached == null)
				{
					CacheWarningColor();
				}
				if (colorCriticalCached == null)
				{
					CacheCriticalColor();
				}
				text.Append(colorCriticalCached).Append("0").Append("</color>");
				ApplyTextStyles();
				dirty = true;
			}
		}

		protected override void PerformDeActivationActions()
		{
			base.PerformDeActivationActions();
			ResetMinMax(withoutUpdate: true);
			ResetAverage();
			LastValue = 0;
			CurrentFpsLevel = FPSLevel.Normal;
		}

		protected override IEnumerator UpdateCounter()
		{
			while (true)
			{
				float previousUpdateTime = Time.unscaledTime;
				int previousUpdateFrames = Time.frameCount;
				while (Time.unscaledTime < previousUpdateTime + updateInterval)
				{
					yield return null;
				}
				float num = Time.unscaledTime - previousUpdateTime;
				int num2 = Time.frameCount - previousUpdateFrames;
				newValue = (float)num2 / num;
				UpdateValue(force: false);
				main.UpdateTexts();
			}
		}

		protected override bool HasData()
		{
			return true;
		}

		protected override void CacheCurrentColor()
		{
			string arg = AFPSCounter.Color32ToHex(color);
			colorCached = $"<color=#{arg}>FPS: ";
			colorCachedMs = $" <color=#{arg}>[";
			colorCachedMin = $"<color=#{arg}>MIN: ";
			colorCachedMax = $"<color=#{arg}>MAX: ";
			colorCachedAvg = $"<color=#{arg}>AVG: ";
			string arg2 = AFPSCounter.Color32ToHex(colorRender);
			colorCachedRender = $"<color=#{arg2}>REN: ";
		}

		protected void CacheWarningColor()
		{
			string arg = AFPSCounter.Color32ToHex(colorWarning);
			colorWarningCached = $"<color=#{arg}>FPS: ";
			colorWarningCachedMs = $" <color=#{arg}>[";
			colorWarningCachedMin = $"<color=#{arg}>MIN: ";
			colorWarningCachedMax = $"<color=#{arg}>MAX: ";
			colorWarningCachedAvg = $"<color=#{arg}>AVG: ";
		}

		protected void CacheCriticalColor()
		{
			string arg = AFPSCounter.Color32ToHex(colorCritical);
			colorCriticalCached = $"<color=#{arg}>FPS: ";
			colorCriticalCachedMs = $" <color=#{arg}>[";
			colorCriticalCachedMin = $"<color=#{arg}>MIN: ";
			colorCriticalCachedMax = $"<color=#{arg}>MAX: ";
			colorCriticalCachedAvg = $"<color=#{arg}>AVG: ";
		}

		private float GetAverageFromAccumulatedSamples()
		{
			float num = 0f;
			for (int i = 0; i < averageSamples; i++)
			{
				num += accumulatedAverageSamples[i];
			}
			if (currentAverageSamples < averageSamples)
			{
				return num / (float)currentAverageSamples;
			}
			return num / (float)averageSamples;
		}

		private static void TryToAddRenderRecorder()
		{
			Camera camera = Camera.main;
			if (!(camera == null) && camera.GetComponent<AFPSRenderRecorder>() == null)
			{
				camera.gameObject.AddComponent<AFPSRenderRecorder>();
			}
		}

		private static void TryToRemoveRenderRecorder()
		{
			Camera camera = Camera.main;
			if (!(camera == null))
			{
				AFPSRenderRecorder component = camera.GetComponent<AFPSRenderRecorder>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
		}
	}
	[Serializable]
	[AddComponentMenu("")]
	public class MemoryCounterData : UpdatableCounterData
	{
		public const long MemoryDivider = 1048576L;

		private const string TextStart = "<color=#{0}>";

		private const string LineStartTotal = "MEM TOTAL: ";

		private const string LineStartAllocated = "MEM ALLOC: ";

		private const string LineStartMono = "MEM MONO: ";

		private const string LineEnd = " MB";

		private const string TextEnd = "</color>";

		[Tooltip("Allows to output memory usage more precisely thus using a bit more system resources.")]
		[SerializeField]
		private bool precise = true;

		[Tooltip("Allows to see private memory amount reserved for application. This memory can’t be used by other applications.")]
		[SerializeField]
		private bool total = true;

		[Tooltip("Allows to see amount of memory, currently allocated by application.")]
		[SerializeField]
		private bool allocated = true;

		[Tooltip("Allows to see amount of memory, allocated by managed Mono objects, such as UnityEngine.Object and everything derived from it for example.")]
		[SerializeField]
		private bool monoUsage;

		[Tooltip("Allows to see amount of allocated memory for the graphics driver (dev builds only).")]
		[SerializeField]
		private bool gfx = true;

		public bool Precise
		{
			get
			{
				return precise;
			}
			set
			{
				if (precise != value && Application.isPlaying)
				{
					precise = value;
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Total
		{
			get
			{
				return total;
			}
			set
			{
				if (total != value && Application.isPlaying)
				{
					total = value;
					if (!total)
					{
						LastTotalValue = 0L;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Allocated
		{
			get
			{
				return allocated;
			}
			set
			{
				if (allocated != value && Application.isPlaying)
				{
					allocated = value;
					if (!allocated)
					{
						LastAllocatedValue = 0L;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool MonoUsage
		{
			get
			{
				return monoUsage;
			}
			set
			{
				if (monoUsage != value && Application.isPlaying)
				{
					monoUsage = value;
					if (!monoUsage)
					{
						LastMonoValue = 0L;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public bool Gfx
		{
			get
			{
				return gfx;
			}
			set
			{
				if (gfx != value && Application.isPlaying)
				{
					gfx = value;
					if (!gfx)
					{
						LastGfxValue = 0L;
					}
					if (enabled)
					{
						Refresh();
					}
				}
			}
		}

		public long LastTotalValue { get; private set; }

		public long LastAllocatedValue { get; private set; }

		public long LastMonoValue { get; private set; }

		public long LastGfxValue { get; private set; }

		internal MemoryCounterData()
		{
			color = new Color32(234, 238, 101, byte.MaxValue);
			style = FontStyle.Bold;
		}

		internal override void UpdateValue(bool force)
		{
			if (!enabled)
			{
				return;
			}
			if (force)
			{
				if (!inited && HasData())
				{
					Activate();
					return;
				}
				if (inited && !HasData())
				{
					Deactivate();
					return;
				}
			}
			if (total)
			{
				long totalReservedMemoryLong = Profiler.GetTotalReservedMemoryLong();
				long num = 0L;
				bool flag;
				if (precise)
				{
					flag = LastTotalValue != totalReservedMemoryLong;
				}
				else
				{
					num = totalReservedMemoryLong / 1048576;
					flag = LastTotalValue != num;
				}
				if (flag || force)
				{
					LastTotalValue = (precise ? totalReservedMemoryLong : num);
					dirty = true;
				}
			}
			if (allocated)
			{
				long totalAllocatedMemoryLong = Profiler.GetTotalAllocatedMemoryLong();
				long num2 = 0L;
				bool flag2;
				if (precise)
				{
					flag2 = LastAllocatedValue != totalAllocatedMemoryLong;
				}
				else
				{
					num2 = totalAllocatedMemoryLong / 1048576;
					flag2 = LastAllocatedValue != num2;
				}
				if (flag2 || force)
				{
					LastAllocatedValue = (precise ? totalAllocatedMemoryLong : num2);
					dirty = true;
				}
			}
			if (monoUsage)
			{
				long totalMemory = GC.GetTotalMemory(forceFullCollection: false);
				long num3 = 0L;
				bool flag3;
				if (precise)
				{
					flag3 = LastMonoValue != totalMemory;
				}
				else
				{
					num3 = totalMemory / 1048576;
					flag3 = LastMonoValue != num3;
				}
				if (flag3 || force)
				{
					LastMonoValue = (precise ? totalMemory : num3);
					dirty = true;
				}
			}
			if (!dirty || main.OperationMode != OperationMode.Normal)
			{
				return;
			}
			bool flag4 = false;
			text.Length = 0;
			text.Append(colorCached);
			if (total)
			{
				text.Append("MEM TOTAL: ");
				if (precise)
				{
					text.AppendLookup((float)LastTotalValue / 1048576f);
				}
				else
				{
					text.AppendLookup(LastTotalValue);
				}
				text.Append(" MB");
				flag4 = true;
			}
			if (allocated)
			{
				if (flag4)
				{
					text.Append('\n');
				}
				text.Append("MEM ALLOC: ");
				if (precise)
				{
					text.AppendLookup((float)LastAllocatedValue / 1048576f);
				}
				else
				{
					text.AppendLookup(LastAllocatedValue);
				}
				text.Append(" MB");
				flag4 = true;
			}
			if (monoUsage)
			{
				if (flag4)
				{
					text.Append('\n');
				}
				text.Append("MEM MONO: ");
				if (precise)
				{
					text.AppendLookup((float)LastMonoValue / 1048576f);
				}
				else
				{
					text.AppendLookup(LastMonoValue);
				}
				text.Append(" MB");
			}
			text.Append("</color>");
			ApplyTextStyles();
		}

		protected override void PerformActivationActions()
		{
			base.PerformActivationActions();
			if (!HasData())
			{
				return;
			}
			LastTotalValue = 0L;
			LastAllocatedValue = 0L;
			LastMonoValue = 0L;
			if (main.OperationMode != OperationMode.Normal)
			{
				return;
			}
			if (colorCached == null)
			{
				colorCached = $"<color=#{AFPSCounter.Color32ToHex(color)}>";
			}
			text.Append(colorCached);
			if (total)
			{
				if (precise)
				{
					text.Append("MEM TOTAL: ").Append("0.00").Append(" MB");
				}
				else
				{
					text.Append("MEM TOTAL: ").Append(0).Append(" MB");
				}
			}
			if (allocated)
			{
				if (text.Length > 0)
				{
					text.Append('\n');
				}
				if (precise)
				{
					text.Append("MEM ALLOC: ").Append("0.00").Append(" MB");
				}
				else
				{
					text.Append("MEM ALLOC: ").Append(0).Append(" MB");
				}
			}
			if (monoUsage)
			{
				if (text.Length > 0)
				{
					text.Append('\n');
				}
				if (precise)
				{
					text.Append("MEM MONO: ").Append("0.00").Append(" MB");
				}
				else
				{
					text.Append("MEM MONO: ").Append(0).Append(" MB");
				}
			}
			text.Append("</color>");
			ApplyTextStyles();
			dirty = true;
		}

		protected override void PerformDeActivationActions()
		{
			base.PerformDeActivationActions();
			if (text != null)
			{
				text.Length = 0;
			}
			main.MakeDrawableLabelDirty(anchor);
		}

		protected override IEnumerator UpdateCounter()
		{
			while (true)
			{
				UpdateValue();
				main.UpdateTexts();
				float previousUpdateTime = Time.unscaledTime;
				while (Time.unscaledTime < previousUpdateTime + updateInterval)
				{
					yield return null;
				}
			}
		}

		protected override bool HasData()
		{
			if (!total && !allocated && !monoUsage)
			{
				return gfx;
			}
			return true;
		}

		protected override void CacheCurrentColor()
		{
			colorCached = $"<color=#{AFPSCounter.Color32ToHex(color)}>";
		}
	}
}
