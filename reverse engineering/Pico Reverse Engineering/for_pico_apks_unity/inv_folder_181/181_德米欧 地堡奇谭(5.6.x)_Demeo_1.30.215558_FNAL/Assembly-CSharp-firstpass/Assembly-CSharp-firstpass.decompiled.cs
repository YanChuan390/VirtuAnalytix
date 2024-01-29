using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Crosstales.BWF.Data;
using Crosstales.BWF.Filter;
using Crosstales.BWF.Model;
using Crosstales.BWF.Model.Enum;
using Crosstales.BWF.Provider;
using Crosstales.Common.Model.Enum;
using Crosstales.Common.Util;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x200000A")]
public static class AudioClipOptimizer
{
	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, string> AudioClipNameByInstanceId;

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xF7B8C4", Offset = "0xF7B8C4", VA = "0xF7B8C4")]
	public static string CachedName(this AudioClip clip)
	{
		return null;
	}
}
[Token(Token = "0x200000B")]
public static class MasterAudioReferenceHolder
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MasterAudio MasterAudio;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xF7BA94", Offset = "0xF7BA94", VA = "0xF7BA94")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	public static void ThisMethodWillBeCalledOnceAtTheStartOfTheProgram()
	{
	}
}
[Token(Token = "0x200000C")]
[AudioScriptOrder(-10)]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x17000011")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xF7BD7C", Offset = "0xF7BD7C", VA = "0xF7BD7C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public Transform Trans
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xF7BCFC", Offset = "0xF7BCFC", VA = "0xF7BCFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xF7BADC", Offset = "0xF7BADC", VA = "0xF7BADC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xF7BAE0", Offset = "0xF7BAE0", VA = "0xF7BAE0")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xF7BB0C", Offset = "0xF7BB0C", VA = "0xF7BB0C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xF7BBC4", Offset = "0xF7BBC4", VA = "0xF7BBC4")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xF7BDFC", Offset = "0xF7BDFC", VA = "0xF7BDFC")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200000D")]
public static class OculusAudioHelper
{
	[Token(Token = "0x600003B")]
	[Address(RVA = "0xF7BE04", Offset = "0xF7BE04", VA = "0xF7BE04")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xF7BE0C", Offset = "0xF7BE0C", VA = "0xF7BE0C")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xF7BE10", Offset = "0xF7BE10", VA = "0xF7BE10")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xF7BE14", Offset = "0xF7BE14", VA = "0xF7BE14")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xF7BE18", Offset = "0xF7BE18", VA = "0xF7BE18")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xF7BE1C", Offset = "0xF7BE1C", VA = "0xF7BE1C")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xF7BE20", Offset = "0xF7BE20", VA = "0xF7BE20")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200000E")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000013")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0xF7BE24", Offset = "0xF7BE24", VA = "0xF7BE24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xF7BE2C", Offset = "0xF7BE2C", VA = "0xF7BE2C")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xF7BE34", Offset = "0xF7BE34", VA = "0xF7BE34")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xF7BE38", Offset = "0xF7BE38", VA = "0xF7BE38")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xF7BE3C", Offset = "0xF7BE3C", VA = "0xF7BE3C")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xF7BE40", Offset = "0xF7BE40", VA = "0xF7BE40")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xF7BE44", Offset = "0xF7BE44", VA = "0xF7BE44")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xF7BE48", Offset = "0xF7BE48", VA = "0xF7BE48")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200000F")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _soundType;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _variationName;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _willFollowSource;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _isInsideTrigger;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool _hasPlayedSound;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _playVolume;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _exitFadeTime;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000014")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xF7C334", Offset = "0xF7C334", VA = "0xF7C334")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public Transform Trans
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xF7C86C", Offset = "0xF7C86C", VA = "0xF7C86C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xF7BE4C", Offset = "0xF7BE4C", VA = "0xF7BE4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xF7BE78", Offset = "0xF7BE78", VA = "0xF7BE78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xF7C004", Offset = "0xF7C004", VA = "0xF7C004")]
	public void UpdateAudioVariation(SoundGroupVariation newVariation)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xF7C020", Offset = "0xF7C020", VA = "0xF7C020")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xF7C2C8", Offset = "0xF7C2C8", VA = "0xF7C2C8")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xF7C3B4", Offset = "0xF7C3B4", VA = "0xF7C3B4")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xF7C788", Offset = "0xF7C788", VA = "0xF7C788")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xF7C254", Offset = "0xF7C254", VA = "0xF7C254")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xF7BED8", Offset = "0xF7BED8", VA = "0xF7BED8")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xF7C8EC", Offset = "0xF7C8EC", VA = "0xF7C8EC")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000010")]
public class LeanAudioStream
{
	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xF7C904", Offset = "0xF7C904", VA = "0xF7C904")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xF7C92C", Offset = "0xF7C92C", VA = "0xF7C92C")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xF7C9A0", Offset = "0xF7C9A0", VA = "0xF7C9A0")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000011")]
public class LeanAudio
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xF7C9A8", Offset = "0xF7C9A8", VA = "0xF7C9A8")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xF7CAD0", Offset = "0xF7CAD0", VA = "0xF7CAD0")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xF7D414", Offset = "0xF7D414", VA = "0xF7D414")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xF7CBA0", Offset = "0xF7CBA0", VA = "0xF7CBA0")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xF7CF2C", Offset = "0xF7CF2C", VA = "0xF7CF2C")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xF7D4D8", Offset = "0xF7D4D8", VA = "0xF7D4D8")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xF7D4DC", Offset = "0xF7D4DC", VA = "0xF7D4DC")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xF7D648", Offset = "0xF7D648", VA = "0xF7D648")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xF7D844", Offset = "0xF7D844", VA = "0xF7D844")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xF7D8EC", Offset = "0xF7D8EC", VA = "0xF7D8EC")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xF7D968", Offset = "0xF7D968", VA = "0xF7D968")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xF7D714", Offset = "0xF7D714", VA = "0xF7D714")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xF7DA18", Offset = "0xF7DA18", VA = "0xF7DA18")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xF7DBB4", Offset = "0xF7DBB4", VA = "0xF7DBB4")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000012")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000013")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x400003A")]
		Sine,
		[Token(Token = "0x400003B")]
		Square,
		[Token(Token = "0x400003C")]
		Sawtooth,
		[Token(Token = "0x400003D")]
		Noise
	}

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xF7CAAC", Offset = "0xF7CAAC", VA = "0xF7CAAC")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xF7DC14", Offset = "0xF7DC14", VA = "0xF7DC14")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xF7DC1C", Offset = "0xF7DC1C", VA = "0xF7DC1C")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xF7DC24", Offset = "0xF7DC24", VA = "0xF7DC24")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xF7DC2C", Offset = "0xF7DC2C", VA = "0xF7DC2C")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xF7DC38", Offset = "0xF7DC38", VA = "0xF7DC38")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xF7DC44", Offset = "0xF7DC44", VA = "0xF7DC44")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xF7DC50", Offset = "0xF7DC50", VA = "0xF7DC50")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xF7DC58", Offset = "0xF7DC58", VA = "0xF7DC58")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xF7DC60", Offset = "0xF7DC60", VA = "0xF7DC60")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000014")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xF7E214", Offset = "0xF7E214", VA = "0xF7E214", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xF7E25C", Offset = "0xF7E25C", VA = "0xF7E25C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xF7DCF0", Offset = "0xF7DCF0", VA = "0xF7DCF0")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xF7DD28", Offset = "0xF7DD28", VA = "0xF7DD28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xF7DD2C", Offset = "0xF7DD2C", VA = "0xF7DD2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xF7E21C", Offset = "0xF7E21C", VA = "0xF7E21C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xF7DC68", Offset = "0xF7DC68", VA = "0xF7DC68")]
	public void Start()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xF7DC88", Offset = "0xF7DC88", VA = "0xF7DC88")]
	[IteratorStateMachine(typeof(<timeoutCheck>d__2))]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xF7DD18", Offset = "0xF7DD18", VA = "0xF7DD18")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000016")]
public class LeanTest
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xF7E264", Offset = "0xF7E264", VA = "0xF7E264")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xF7E2D0", Offset = "0xF7E2D0", VA = "0xF7E2D0")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xF7EB80", Offset = "0xF7EB80", VA = "0xF7EB80")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xF7E8CC", Offset = "0xF7E8CC", VA = "0xF7E8CC")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xF7EBF4", Offset = "0xF7EBF4", VA = "0xF7EBF4")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xF7DE80", Offset = "0xF7DE80", VA = "0xF7DE80")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xF7E9F8", Offset = "0xF7E9F8", VA = "0xF7E9F8")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xF7DEEC", Offset = "0xF7DEEC", VA = "0xF7DEEC")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xF7EC5C", Offset = "0xF7EC5C", VA = "0xF7EC5C")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000017")]
public enum TweenAction
{
	[Token(Token = "0x400004A")]
	MOVE_X,
	[Token(Token = "0x400004B")]
	MOVE_Y,
	[Token(Token = "0x400004C")]
	MOVE_Z,
	[Token(Token = "0x400004D")]
	MOVE_LOCAL_X,
	[Token(Token = "0x400004E")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x400004F")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x4000050")]
	MOVE_CURVED,
	[Token(Token = "0x4000051")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x4000052")]
	MOVE_SPLINE,
	[Token(Token = "0x4000053")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x4000054")]
	SCALE_X,
	[Token(Token = "0x4000055")]
	SCALE_Y,
	[Token(Token = "0x4000056")]
	SCALE_Z,
	[Token(Token = "0x4000057")]
	ROTATE_X,
	[Token(Token = "0x4000058")]
	ROTATE_Y,
	[Token(Token = "0x4000059")]
	ROTATE_Z,
	[Token(Token = "0x400005A")]
	ROTATE_AROUND,
	[Token(Token = "0x400005B")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x400005C")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x400005D")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x400005E")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x400005F")]
	ALPHA,
	[Token(Token = "0x4000060")]
	TEXT_ALPHA,
	[Token(Token = "0x4000061")]
	CANVAS_ALPHA,
	[Token(Token = "0x4000062")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x4000063")]
	ALPHA_VERTEX,
	[Token(Token = "0x4000064")]
	COLOR,
	[Token(Token = "0x4000065")]
	CALLBACK_COLOR,
	[Token(Token = "0x4000066")]
	TEXT_COLOR,
	[Token(Token = "0x4000067")]
	CANVAS_COLOR,
	[Token(Token = "0x4000068")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000069")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x400006A")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x400006B")]
	CALLBACK,
	[Token(Token = "0x400006C")]
	MOVE,
	[Token(Token = "0x400006D")]
	MOVE_LOCAL,
	[Token(Token = "0x400006E")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x400006F")]
	ROTATE,
	[Token(Token = "0x4000070")]
	ROTATE_LOCAL,
	[Token(Token = "0x4000071")]
	SCALE,
	[Token(Token = "0x4000072")]
	VALUE3,
	[Token(Token = "0x4000073")]
	GUI_MOVE,
	[Token(Token = "0x4000074")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x4000075")]
	GUI_SCALE,
	[Token(Token = "0x4000076")]
	GUI_ALPHA,
	[Token(Token = "0x4000077")]
	GUI_ROTATE,
	[Token(Token = "0x4000078")]
	DELAYED_SOUND,
	[Token(Token = "0x4000079")]
	CANVAS_MOVE,
	[Token(Token = "0x400007A")]
	CANVAS_SCALE,
	[Token(Token = "0x400007B")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x2000018")]
public enum LeanTweenType
{
	[Token(Token = "0x400007D")]
	notUsed,
	[Token(Token = "0x400007E")]
	linear,
	[Token(Token = "0x400007F")]
	easeOutQuad,
	[Token(Token = "0x4000080")]
	easeInQuad,
	[Token(Token = "0x4000081")]
	easeInOutQuad,
	[Token(Token = "0x4000082")]
	easeInCubic,
	[Token(Token = "0x4000083")]
	easeOutCubic,
	[Token(Token = "0x4000084")]
	easeInOutCubic,
	[Token(Token = "0x4000085")]
	easeInQuart,
	[Token(Token = "0x4000086")]
	easeOutQuart,
	[Token(Token = "0x4000087")]
	easeInOutQuart,
	[Token(Token = "0x4000088")]
	easeInQuint,
	[Token(Token = "0x4000089")]
	easeOutQuint,
	[Token(Token = "0x400008A")]
	easeInOutQuint,
	[Token(Token = "0x400008B")]
	easeInSine,
	[Token(Token = "0x400008C")]
	easeOutSine,
	[Token(Token = "0x400008D")]
	easeInOutSine,
	[Token(Token = "0x400008E")]
	easeInExpo,
	[Token(Token = "0x400008F")]
	easeOutExpo,
	[Token(Token = "0x4000090")]
	easeInOutExpo,
	[Token(Token = "0x4000091")]
	easeInCirc,
	[Token(Token = "0x4000092")]
	easeOutCirc,
	[Token(Token = "0x4000093")]
	easeInOutCirc,
	[Token(Token = "0x4000094")]
	easeInBounce,
	[Token(Token = "0x4000095")]
	easeOutBounce,
	[Token(Token = "0x4000096")]
	easeInOutBounce,
	[Token(Token = "0x4000097")]
	easeInBack,
	[Token(Token = "0x4000098")]
	easeOutBack,
	[Token(Token = "0x4000099")]
	easeInOutBack,
	[Token(Token = "0x400009A")]
	easeInElastic,
	[Token(Token = "0x400009B")]
	easeOutElastic,
	[Token(Token = "0x400009C")]
	easeInOutElastic,
	[Token(Token = "0x400009D")]
	easeSpring,
	[Token(Token = "0x400009E")]
	easeShake,
	[Token(Token = "0x400009F")]
	punch,
	[Token(Token = "0x40000A0")]
	once,
	[Token(Token = "0x40000A1")]
	clamp,
	[Token(Token = "0x40000A2")]
	pingPong,
	[Token(Token = "0x40000A3")]
	animationCurve
}
[Token(Token = "0x2000019")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] tweensFinishedIds;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static LTDescr tween;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int tweenMaxSearch;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int maxTweens;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int maxSequences;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int frameRendered;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtEstimated;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static float dtManual;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static float dtActual;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static uint global_counter;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int i;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static int j;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int finishedCnt;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve punch;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static AnimationCurve shake;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static int maxTweenReached;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static int startSearch;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static LTDescr d;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x17000018")]
	public static int maxSearch
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xF7ED6C", Offset = "0xF7ED6C", VA = "0xF7ED6C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000019")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xF7EDC4", Offset = "0xF7EDC4", VA = "0xF7EDC4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001A")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xF7EE1C", Offset = "0xF7EE1C", VA = "0xF7EE1C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001B")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xF82CA0", Offset = "0xF82CA0", VA = "0xF82CA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xF7ECB4", Offset = "0xF7ECB4", VA = "0xF7ECB4")]
	public static void init()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xF7ED0C", Offset = "0xF7ED0C", VA = "0xF7ED0C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xF7EED4", Offset = "0xF7EED4", VA = "0xF7EED4")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xF7F390", Offset = "0xF7F390", VA = "0xF7F390")]
	public static void reset()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xF7F4D8", Offset = "0xF7F4D8", VA = "0xF7F4D8")]
	public void Update()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xF7F940", Offset = "0xF7F940", VA = "0xF7F940")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xF7F9A0", Offset = "0xF7F9A0", VA = "0xF7F9A0")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xF7F524", Offset = "0xF7F524", VA = "0xF7F524")]
	public static void update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xF80218", Offset = "0xF80218", VA = "0xF80218")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xF7FE10", Offset = "0xF7FE10", VA = "0xF7FE10")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xF80430", Offset = "0xF80430", VA = "0xF80430")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xF8059C", Offset = "0xF8059C", VA = "0xF8059C")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xF805EC", Offset = "0xF805EC", VA = "0xF805EC")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xF8063C", Offset = "0xF8063C", VA = "0xF8063C")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xF80804", Offset = "0xF80804", VA = "0xF80804")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xF8085C", Offset = "0xF8085C", VA = "0xF8085C")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xF80A78", Offset = "0xF80A78", VA = "0xF80A78")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xF80AEC", Offset = "0xF80AEC", VA = "0xF80AEC")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xF80D50", Offset = "0xF80D50", VA = "0xF80D50")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xF80E60", Offset = "0xF80E60", VA = "0xF80E60")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xF80EB8", Offset = "0xF80EB8", VA = "0xF80EB8")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xF810D8", Offset = "0xF810D8", VA = "0xF810D8")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xF81318", Offset = "0xF81318", VA = "0xF81318")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xF8136C", Offset = "0xF8136C", VA = "0xF8136C")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xF815F8", Offset = "0xF815F8", VA = "0xF815F8")]
	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xF8164C", Offset = "0xF8164C", VA = "0xF8164C")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xF81740", Offset = "0xF81740", VA = "0xF81740")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xF8189C", Offset = "0xF8189C", VA = "0xF8189C")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xF8196C", Offset = "0xF8196C", VA = "0xF8196C")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xF81A3C", Offset = "0xF81A3C", VA = "0xF81A3C")]
	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xF81A90", Offset = "0xF81A90", VA = "0xF81A90")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xF81B60", Offset = "0xF81B60", VA = "0xF81B60")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xF81CB0", Offset = "0xF81CB0", VA = "0xF81CB0")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xF81E90", Offset = "0xF81E90", VA = "0xF81E90")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xF81F00", Offset = "0xF81F00", VA = "0xF81F00")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xF81FFC", Offset = "0xF81FFC", VA = "0xF81FFC")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xF82110", Offset = "0xF82110", VA = "0xF82110")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xF82740", Offset = "0xF82740", VA = "0xF82740")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xF827E0", Offset = "0xF827E0", VA = "0xF827E0")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xF82850", Offset = "0xF82850", VA = "0xF82850")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xF82D08", Offset = "0xF82D08", VA = "0xF82D08")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xF82E10", Offset = "0xF82E10", VA = "0xF82E10")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xF8301C", Offset = "0xF8301C", VA = "0xF8301C")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xF831A0", Offset = "0xF831A0", VA = "0xF831A0")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xF833C8", Offset = "0xF833C8", VA = "0xF833C8")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xF83550", Offset = "0xF83550", VA = "0xF83550")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xF836B4", Offset = "0xF836B4", VA = "0xF836B4")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xF83758", Offset = "0xF83758", VA = "0xF83758")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xF838BC", Offset = "0xF838BC", VA = "0xF838BC")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xF83A08", Offset = "0xF83A08", VA = "0xF83A08")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xF83BD8", Offset = "0xF83BD8", VA = "0xF83BD8")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xF83D68", Offset = "0xF83D68", VA = "0xF83D68")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xF83E38", Offset = "0xF83E38", VA = "0xF83E38")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xF84060", Offset = "0xF84060", VA = "0xF84060")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xF84168", Offset = "0xF84168", VA = "0xF84168")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xF84250", Offset = "0xF84250", VA = "0xF84250")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xF84338", Offset = "0xF84338", VA = "0xF84338")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xF84428", Offset = "0xF84428", VA = "0xF84428")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xF84584", Offset = "0xF84584", VA = "0xF84584")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xF8463C", Offset = "0xF8463C", VA = "0xF8463C")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xF84BA4", Offset = "0xF84BA4", VA = "0xF84BA4")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xF84C50", Offset = "0xF84C50", VA = "0xF84C50")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xF84DBC", Offset = "0xF84DBC", VA = "0xF84DBC")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xF84EE8", Offset = "0xF84EE8", VA = "0xF84EE8")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xF84F94", Offset = "0xF84F94", VA = "0xF84F94")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xF85148", Offset = "0xF85148", VA = "0xF85148")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xF852B4", Offset = "0xF852B4", VA = "0xF852B4")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xF85420", Offset = "0xF85420", VA = "0xF85420")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xF85568", Offset = "0xF85568", VA = "0xF85568")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xF856B4", Offset = "0xF856B4", VA = "0xF856B4")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xF85800", Offset = "0xF85800", VA = "0xF85800")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xF8595C", Offset = "0xF8595C", VA = "0xF8595C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xF85B5C", Offset = "0xF85B5C", VA = "0xF85B5C")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xF85CA8", Offset = "0xF85CA8", VA = "0xF85CA8")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xF85DF4", Offset = "0xF85DF4", VA = "0xF85DF4")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xF85F40", Offset = "0xF85F40", VA = "0xF85F40")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xF85FEC", Offset = "0xF85FEC", VA = "0xF85FEC")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xF86098", Offset = "0xF86098", VA = "0xF86098")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xF86258", Offset = "0xF86258", VA = "0xF86258")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xF863B4", Offset = "0xF863B4", VA = "0xF863B4")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xF86514", Offset = "0xF86514", VA = "0xF86514")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xF86670", Offset = "0xF86670", VA = "0xF86670")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xF867BC", Offset = "0xF867BC", VA = "0xF867BC")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xF86908", Offset = "0xF86908", VA = "0xF86908")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xF86A54", Offset = "0xF86A54", VA = "0xF86A54")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xF86BF0", Offset = "0xF86BF0", VA = "0xF86BF0")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xF86D68", Offset = "0xF86D68", VA = "0xF86D68")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xF86EC4", Offset = "0xF86EC4", VA = "0xF86EC4")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xF87030", Offset = "0xF87030", VA = "0xF87030")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xF8717C", Offset = "0xF8717C", VA = "0xF8717C")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xF872C8", Offset = "0xF872C8", VA = "0xF872C8")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xF87414", Offset = "0xF87414", VA = "0xF87414")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xF87580", Offset = "0xF87580", VA = "0xF87580")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xF8762C", Offset = "0xF8762C", VA = "0xF8762C")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xF8786C", Offset = "0xF8786C", VA = "0xF8786C")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xF87934", Offset = "0xF87934", VA = "0xF87934")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xF87B68", Offset = "0xF87B68", VA = "0xF87B68")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xF87C90", Offset = "0xF87C90", VA = "0xF87C90")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xF87DB8", Offset = "0xF87DB8", VA = "0xF87DB8")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xF87EF4", Offset = "0xF87EF4", VA = "0xF87EF4")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xF88030", Offset = "0xF88030", VA = "0xF88030")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xF88160", Offset = "0xF88160", VA = "0xF88160")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xF8829C", Offset = "0xF8829C", VA = "0xF8829C")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xF883D4", Offset = "0xF883D4", VA = "0xF883D4")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xF885A0", Offset = "0xF885A0", VA = "0xF885A0")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xF88694", Offset = "0xF88694", VA = "0xF88694")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xF88814", Offset = "0xF88814", VA = "0xF88814")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xF8897C", Offset = "0xF8897C", VA = "0xF8897C")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xF88AE4", Offset = "0xF88AE4", VA = "0xF88AE4")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xF88C4C", Offset = "0xF88C4C", VA = "0xF88C4C")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xF88DFC", Offset = "0xF88DFC", VA = "0xF88DFC")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xF88EFC", Offset = "0xF88EFC", VA = "0xF88EFC")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xF88FD0", Offset = "0xF88FD0", VA = "0xF88FD0")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xF89164", Offset = "0xF89164", VA = "0xF89164")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xF892DC", Offset = "0xF892DC", VA = "0xF892DC")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xF89450", Offset = "0xF89450", VA = "0xF89450")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xF895B8", Offset = "0xF895B8", VA = "0xF895B8")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xF8974C", Offset = "0xF8974C", VA = "0xF8974C")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xF89794", Offset = "0xF89794", VA = "0xF89794")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xF8986C", Offset = "0xF8986C", VA = "0xF8986C")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xF89884", Offset = "0xF89884", VA = "0xF89884")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xF89894", Offset = "0xF89894", VA = "0xF89894")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xF898E4", Offset = "0xF898E4", VA = "0xF898E4")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xF89964", Offset = "0xF89964", VA = "0xF89964")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xF89988", Offset = "0xF89988", VA = "0xF89988")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xF899EC", Offset = "0xF899EC", VA = "0xF899EC")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xF89A9C", Offset = "0xF89A9C", VA = "0xF89A9C")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xF89AB0", Offset = "0xF89AB0", VA = "0xF89AB0")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xF89ACC", Offset = "0xF89ACC", VA = "0xF89ACC")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xF89B20", Offset = "0xF89B20", VA = "0xF89B20")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xF89B58", Offset = "0xF89B58", VA = "0xF89B58")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xF89B70", Offset = "0xF89B70", VA = "0xF89B70")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xF89B98", Offset = "0xF89B98", VA = "0xF89B98")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xF89BF0", Offset = "0xF89BF0", VA = "0xF89BF0")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xF89C0C", Offset = "0xF89C0C", VA = "0xF89C0C")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xF89C34", Offset = "0xF89C34", VA = "0xF89C34")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xF89C90", Offset = "0xF89C90", VA = "0xF89C90")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xF89CB0", Offset = "0xF89CB0", VA = "0xF89CB0")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xF89CE0", Offset = "0xF89CE0", VA = "0xF89CE0")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xF89D48", Offset = "0xF89D48", VA = "0xF89D48")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xF89D80", Offset = "0xF89D80", VA = "0xF89D80")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xF89DB4", Offset = "0xF89DB4", VA = "0xF89DB4")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xF89DF8", Offset = "0xF89DF8", VA = "0xF89DF8")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xF89E30", Offset = "0xF89E30", VA = "0xF89E30")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xF89E68", Offset = "0xF89E68", VA = "0xF89E68")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xF89ED8", Offset = "0xF89ED8", VA = "0xF89ED8")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xF89F00", Offset = "0xF89F00", VA = "0xF89F00")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xF89F28", Offset = "0xF89F28", VA = "0xF89F28")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xF89F7C", Offset = "0xF89F7C", VA = "0xF89F7C")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xF8A004", Offset = "0xF8A004", VA = "0xF8A004")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xF8A0CC", Offset = "0xF8A0CC", VA = "0xF8A0CC")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xF8A180", Offset = "0xF8A180", VA = "0xF8A180")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xF8A1B4", Offset = "0xF8A1B4", VA = "0xF8A1B4")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xF8A1F4", Offset = "0xF8A1F4", VA = "0xF8A1F4")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xF8A28C", Offset = "0xF8A28C", VA = "0xF8A28C")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xF8A364", Offset = "0xF8A364", VA = "0xF8A364")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xF8A434", Offset = "0xF8A434", VA = "0xF8A434")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xF8A584", Offset = "0xF8A584", VA = "0xF8A584")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xF8A5EC", Offset = "0xF8A5EC", VA = "0xF8A5EC")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xF8AA0C", Offset = "0xF8AA0C", VA = "0xF8AA0C")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xF8AC64", Offset = "0xF8AC64", VA = "0xF8AC64")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xF8AA74", Offset = "0xF8AA74", VA = "0xF8AA74")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xF8AD18", Offset = "0xF8AD18", VA = "0xF8AD18")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xF8AD70", Offset = "0xF8AD70", VA = "0xF8AD70")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xF8AF70", Offset = "0xF8AF70", VA = "0xF8AF70")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200001A")]
public class LTUtility
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0xF8B4E8", Offset = "0xF8B4E8", VA = "0xF8B4E8")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xF8B584", Offset = "0xF8B584", VA = "0xF8B584")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200001B")]
public class LTBezier
{
	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xF8B58C", Offset = "0xF8B58C", VA = "0xF8B58C")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xF8B860", Offset = "0xF8B860", VA = "0xF8B860")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xF8B808", Offset = "0xF8B808", VA = "0xF8B808")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xF8B980", Offset = "0xF8B980", VA = "0xF8B980")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200001C")]
public class LTBezierPath
{
	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x1700001C")]
	public float distance
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xF8B9A0", Offset = "0xF8B9A0", VA = "0xF8B9A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xF8B998", Offset = "0xF8B998", VA = "0xF8B998")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xF8483C", Offset = "0xF8483C", VA = "0xF8483C")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xF84868", Offset = "0xF84868", VA = "0xF84868")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xF8B9A8", Offset = "0xF8B9A8", VA = "0xF8B9A8")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xF8BA6C", Offset = "0xF8BA6C", VA = "0xF8BA6C")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xF8BB20", Offset = "0xF8BB20", VA = "0xF8BB20")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xF8BBD4", Offset = "0xF8BBD4", VA = "0xF8BBD4")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xF8BC40", Offset = "0xF8BC40", VA = "0xF8BC40")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xF8BCDC", Offset = "0xF8BCDC", VA = "0xF8BCDC")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xF8BD48", Offset = "0xF8BD48", VA = "0xF8BD48")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xF8BE30", Offset = "0xF8BE30", VA = "0xF8BE30")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class LTSpline
{
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xF84EB0", Offset = "0xF84EB0", VA = "0xF84EB0")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xF8C2F0", Offset = "0xF8C2F0", VA = "0xF8C2F0")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xF8BF10", Offset = "0xF8BF10", VA = "0xF8BF10")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xF8C534", Offset = "0xF8C534", VA = "0xF8C534")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xF8C330", Offset = "0xF8C330", VA = "0xF8C330")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xF8C630", Offset = "0xF8C630", VA = "0xF8C630")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xF8C75C", Offset = "0xF8C75C", VA = "0xF8C75C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xF8C774", Offset = "0xF8C774", VA = "0xF8C774")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xF8C828", Offset = "0xF8C828", VA = "0xF8C828")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xF8C960", Offset = "0xF8C960", VA = "0xF8C960")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xF8C9CC", Offset = "0xF8C9CC", VA = "0xF8C9CC")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xF8CA68", Offset = "0xF8CA68", VA = "0xF8CA68")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xF8CAD4", Offset = "0xF8CAD4", VA = "0xF8CAD4")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xF8CB94", Offset = "0xF8CB94", VA = "0xF8CB94")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xF8CC48", Offset = "0xF8CC48", VA = "0xF8CC48")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xF8CD94", Offset = "0xF8CD94", VA = "0xF8CD94")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xF8CFC4", Offset = "0xF8CFC4", VA = "0xF8CFC4")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xF8CFD4", Offset = "0xF8CFD4", VA = "0xF8CFD4")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xF8D19C", Offset = "0xF8D19C", VA = "0xF8D19C")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class LTRect
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x1700001D")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xF8DA50", Offset = "0xF8DA50", VA = "0xF8DA50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public int id
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xF802E8", Offset = "0xF802E8", VA = "0xF802E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001F")]
	public float x
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xF8DA68", Offset = "0xF8DA68", VA = "0xF8DA68")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xF8DA74", Offset = "0xF8DA74", VA = "0xF8DA74")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public float y
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0xF8DA80", Offset = "0xF8DA80", VA = "0xF8DA80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0xF8DA8C", Offset = "0xF8DA8C", VA = "0xF8DA8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public float width
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0xF8DA98", Offset = "0xF8DA98", VA = "0xF8DA98")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000164")]
		[Address(RVA = "0xF8DAA4", Offset = "0xF8DAA4", VA = "0xF8DAA4")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public float height
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0xF8DAB0", Offset = "0xF8DAB0", VA = "0xF8DAB0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xF8DABC", Offset = "0xF8DABC", VA = "0xF8DABC")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Rect rect
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0xF8DAC8", Offset = "0xF8DAC8", VA = "0xF8DAC8")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xF8DCB0", Offset = "0xF8DCB0", VA = "0xF8DCB0")]
		set
		{
		}
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xF8D3D0", Offset = "0xF8D3D0", VA = "0xF8D3D0")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xF8D4E0", Offset = "0xF8D4E0", VA = "0xF8D4E0")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xF8D578", Offset = "0xF8D578", VA = "0xF8D578")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xF8D63C", Offset = "0xF8D63C", VA = "0xF8D63C")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xF8D708", Offset = "0xF8D708", VA = "0xF8D708")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xF8DA60", Offset = "0xF8DA60", VA = "0xF8DA60")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xF8D474", Offset = "0xF8D474", VA = "0xF8D474")]
	public void reset()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xF8D7EC", Offset = "0xF8D7EC", VA = "0xF8D7EC")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xF8DCBC", Offset = "0xF8DCBC", VA = "0xF8DCBC")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xF8DCC4", Offset = "0xF8DCC4", VA = "0xF8DCC4")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xF8DCD0", Offset = "0xF8DCD0", VA = "0xF8DCD0")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xF8DCE4", Offset = "0xF8DCE4", VA = "0xF8DCE4")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xF8DCEC", Offset = "0xF8DCEC", VA = "0xF8DCEC")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xF8DCF4", Offset = "0xF8DCF4", VA = "0xF8DCF4")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xF8DD08", Offset = "0xF8DD08", VA = "0xF8DD08")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xF8DD70", Offset = "0xF8DD70", VA = "0xF8DD70")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xF8DD7C", Offset = "0xF8DD7C", VA = "0xF8DD7C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
public class LTEvent
{
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xF8AF40", Offset = "0xF8AF40", VA = "0xF8AF40")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000020")]
public class LTGUI
{
	[Token(Token = "0x2000021")]
	public enum Element_Type
	{
		[Token(Token = "0x4000101")]
		Texture,
		[Token(Token = "0x4000102")]
		Label
	}

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xF8E01C", Offset = "0xF8E01C", VA = "0xF8E01C")]
	public static void init()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xF8E0E8", Offset = "0xF8E0E8", VA = "0xF8E0E8")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xF7F9EC", Offset = "0xF7F9EC", VA = "0xF7F9EC")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xF8E23C", Offset = "0xF8E23C", VA = "0xF8E23C")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xF8EB68", Offset = "0xF8EB68", VA = "0xF8EB68")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xF802F4", Offset = "0xF802F4", VA = "0xF802F4")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xF8EC44", Offset = "0xF8EC44", VA = "0xF8EC44")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xF8ED20", Offset = "0xF8ED20", VA = "0xF8ED20")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xF8EDE4", Offset = "0xF8EDE4", VA = "0xF8EDE4")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xF8F194", Offset = "0xF8F194", VA = "0xF8F194")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF8F258", Offset = "0xF8F258", VA = "0xF8F258")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xF8EE60", Offset = "0xF8EE60", VA = "0xF8EE60")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xF8F2D0", Offset = "0xF8F2D0", VA = "0xF8F2D0")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xF8F590", Offset = "0xF8F590", VA = "0xF8F590")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xF8F714", Offset = "0xF8F714", VA = "0xF8F714")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xF8F6A4", Offset = "0xF8F6A4", VA = "0xF8F6A4")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xF8F7DC", Offset = "0xF8F7DC", VA = "0xF8F7DC")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000022")]
public class LTDescr
{
	[Token(Token = "0x2000023")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000024")]
	public delegate void ActionMethodDelegate();

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal Vector3 fromInternal;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	internal Vector3 toInternal;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal Vector3 diff;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TweenAction type;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private LeanTweenType easeType;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LeanTweenType loopType;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool hasUpdateCallback;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform rectTransform;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text uiText;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image uiImage;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage rawImage;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite[] sprites;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LTDescrOptional _optional;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x17000024")]
	public Vector3 from
	{
		[Token(Token = "0x6000185")]
		[Address(RVA = "0xF8F850", Offset = "0xF8F850", VA = "0xF8F850")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000186")]
		[Address(RVA = "0xF8F85C", Offset = "0xF8F85C", VA = "0xF8F85C")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Vector3 to
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0xF8F868", Offset = "0xF8F868", VA = "0xF8F868")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0xF8F874", Offset = "0xF8F874", VA = "0xF8F874")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0xF8F880", Offset = "0xF8F880", VA = "0xF8F880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018A")]
		[Address(RVA = "0xF8F888", Offset = "0xF8F888", VA = "0xF8F888")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xF8F890", Offset = "0xF8F890", VA = "0xF8F890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0xF8F898", Offset = "0xF8F898", VA = "0xF8F898")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public int uniqueId
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0xF802D8", Offset = "0xF802D8", VA = "0xF802D8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	public int id
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0xF7FE00", Offset = "0xF7FE00", VA = "0xF7FE00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002A")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0xF9016C", Offset = "0xF9016C", VA = "0xF9016C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000193")]
		[Address(RVA = "0xF90174", Offset = "0xF90174", VA = "0xF90174")]
		set
		{
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xF8F8A0", Offset = "0xF8F8A0", VA = "0xF8F8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xF7F320", Offset = "0xF7F320", VA = "0xF7F320")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xF900A8", Offset = "0xF900A8", VA = "0xF900A8")]
	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0xF82B68", Offset = "0xF82B68", VA = "0xF82B68")]
	public void reset()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0xF854AC", Offset = "0xF854AC", VA = "0xF854AC")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0xF855F4", Offset = "0xF855F4", VA = "0xF855F4")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0xF85740", Offset = "0xF85740", VA = "0xF85740")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0xF85BE8", Offset = "0xF85BE8", VA = "0xF85BE8")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xF85D34", Offset = "0xF85D34", VA = "0xF85D34")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xF85E80", Offset = "0xF85E80", VA = "0xF85E80")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xF90178", Offset = "0xF90178", VA = "0xF90178")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xF8477C", Offset = "0xF8477C", VA = "0xF8477C")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xF85A9C", Offset = "0xF85A9C", VA = "0xF85A9C")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0xF84CFC", Offset = "0xF84CFC", VA = "0xF84CFC")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xF85088", Offset = "0xF85088", VA = "0xF85088")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xF870BC", Offset = "0xF870BC", VA = "0xF870BC")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0xF87208", Offset = "0xF87208", VA = "0xF87208")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xF87354", Offset = "0xF87354", VA = "0xF87354")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xF866FC", Offset = "0xF866FC", VA = "0xF866FC")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xF86848", Offset = "0xF86848", VA = "0xF86848")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xF86994", Offset = "0xF86994", VA = "0xF86994")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xF86B30", Offset = "0xF86B30", VA = "0xF86B30")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xF86CA8", Offset = "0xF86CA8", VA = "0xF86CA8")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xF830E0", Offset = "0xF830E0", VA = "0xF830E0")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xF835F4", Offset = "0xF835F4", VA = "0xF835F4")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xF83948", Offset = "0xF83948", VA = "0xF83948")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0xF83AF8", Offset = "0xF83AF8", VA = "0xF83AF8")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0xF87A60", Offset = "0xF87A60", VA = "0xF87A60")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0xF83CA8", Offset = "0xF83CA8", VA = "0xF83CA8")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0xF894F8", Offset = "0xF894F8", VA = "0xF894F8")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0xF837FC", Offset = "0xF837FC", VA = "0xF837FC")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0xF8968C", Offset = "0xF8968C", VA = "0xF8968C")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xF888BC", Offset = "0xF888BC", VA = "0xF888BC")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xF88A24", Offset = "0xF88A24", VA = "0xF88A24")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xF88B8C", Offset = "0xF88B8C", VA = "0xF88B8C")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xF90180", Offset = "0xF90180", VA = "0xF90180")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xF88D3C", Offset = "0xF88D3C", VA = "0xF88D3C")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xF890A4", Offset = "0xF890A4", VA = "0xF890A4")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xF82F10", Offset = "0xF82F10", VA = "0xF82F10")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xF8874C", Offset = "0xF8874C", VA = "0xF8874C")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xF8921C", Offset = "0xF8921C", VA = "0xF8921C")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xF89390", Offset = "0xF89390", VA = "0xF89390")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xF901BC", Offset = "0xF901BC", VA = "0xF901BC")]
	private void callback()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xF83F1C", Offset = "0xF83F1C", VA = "0xF83F1C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xF8771C", Offset = "0xF8771C", VA = "0xF8771C")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xF844C4", Offset = "0xF844C4", VA = "0xF844C4")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xF8589C", Offset = "0xF8589C", VA = "0xF8589C")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xF86198", Offset = "0xF86198", VA = "0xF86198")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xF862F4", Offset = "0xF862F4", VA = "0xF862F4")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xF865B0", Offset = "0xF865B0", VA = "0xF865B0")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xF86E04", Offset = "0xF86E04", VA = "0xF86E04")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xF851F4", Offset = "0xF851F4", VA = "0xF851F4")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xF85360", Offset = "0xF85360", VA = "0xF85360")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xF86F70", Offset = "0xF86F70", VA = "0xF86F70")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xF83474", Offset = "0xF83474", VA = "0xF83474")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xF86454", Offset = "0xF86454", VA = "0xF86454")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xF884C4", Offset = "0xF884C4", VA = "0xF884C4")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xF90234", Offset = "0xF90234", VA = "0xF90234")]
	private void init()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xF90378", Offset = "0xF90378", VA = "0xF90378")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xF9046C", Offset = "0xF9046C", VA = "0xF9046C")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xF7FB34", Offset = "0xF7FB34", VA = "0xF7FB34")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xF80120", Offset = "0xF80120", VA = "0xF80120")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xF87B20", Offset = "0xF87B20", VA = "0xF87B20")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xF90484", Offset = "0xF90484", VA = "0xF90484")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xF908FC", Offset = "0xF908FC", VA = "0xF908FC")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xF90CE0", Offset = "0xF90CE0", VA = "0xF90CE0")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xF91120", Offset = "0xF91120", VA = "0xF91120")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xF914F8", Offset = "0xF914F8", VA = "0xF914F8")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xF918F8", Offset = "0xF918F8", VA = "0xF918F8")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xF91D30", Offset = "0xF91D30", VA = "0xF91D30")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xF920E8", Offset = "0xF920E8", VA = "0xF920E8")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xF92468", Offset = "0xF92468", VA = "0xF92468")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xF92824", Offset = "0xF92824", VA = "0xF92824")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xF81728", Offset = "0xF81728", VA = "0xF81728")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xF81A30", Offset = "0xF81A30", VA = "0xF81A30")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xF86B10", Offset = "0xF86B10", VA = "0xF86B10")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xF92880", Offset = "0xF92880", VA = "0xF92880")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xF92888", Offset = "0xF92888", VA = "0xF92888")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xF929C4", Offset = "0xF929C4", VA = "0xF929C4")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xF93BD4", Offset = "0xF93BD4", VA = "0xF93BD4")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xF92AD4", Offset = "0xF92AD4", VA = "0xF92AD4")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xF92A4C", Offset = "0xF92A4C", VA = "0xF92A4C")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xF92B5C", Offset = "0xF92B5C", VA = "0xF92B5C")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xF92BE4", Offset = "0xF92BE4", VA = "0xF92BE4")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xF92C6C", Offset = "0xF92C6C", VA = "0xF92C6C")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xF92CF4", Offset = "0xF92CF4", VA = "0xF92CF4")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xF92D7C", Offset = "0xF92D7C", VA = "0xF92D7C")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xF92E04", Offset = "0xF92E04", VA = "0xF92E04")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xF92E8C", Offset = "0xF92E8C", VA = "0xF92E8C")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xF92F14", Offset = "0xF92F14", VA = "0xF92F14")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xF92F9C", Offset = "0xF92F9C", VA = "0xF92F9C")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xF93024", Offset = "0xF93024", VA = "0xF93024")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xF930AC", Offset = "0xF930AC", VA = "0xF930AC")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xF93134", Offset = "0xF93134", VA = "0xF93134")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xF931BC", Offset = "0xF931BC", VA = "0xF931BC")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xF93244", Offset = "0xF93244", VA = "0xF93244")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xF932CC", Offset = "0xF932CC", VA = "0xF932CC")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xF93354", Offset = "0xF93354", VA = "0xF93354")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xF933DC", Offset = "0xF933DC", VA = "0xF933DC")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xF93464", Offset = "0xF93464", VA = "0xF93464")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xF934EC", Offset = "0xF934EC", VA = "0xF934EC")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xF93574", Offset = "0xF93574", VA = "0xF93574")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xF935FC", Offset = "0xF935FC", VA = "0xF935FC")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xF93684", Offset = "0xF93684", VA = "0xF93684")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xF9370C", Offset = "0xF9370C", VA = "0xF9370C")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xF93794", Offset = "0xF93794", VA = "0xF93794")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xF9381C", Offset = "0xF9381C", VA = "0xF9381C")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xF938A4", Offset = "0xF938A4", VA = "0xF938A4")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xF9392C", Offset = "0xF9392C", VA = "0xF9392C")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xF939B4", Offset = "0xF939B4", VA = "0xF939B4")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xF93A3C", Offset = "0xF93A3C", VA = "0xF93A3C")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xF93B08", Offset = "0xF93B08", VA = "0xF93B08")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0xF93C5C", Offset = "0xF93C5C", VA = "0xF93C5C")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xF93D1C", Offset = "0xF93D1C", VA = "0xF93D1C")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0xF93DC0", Offset = "0xF93DC0", VA = "0xF93DC0")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0xF93E38", Offset = "0xF93E38", VA = "0xF93E38")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0xF93EBC", Offset = "0xF93EBC", VA = "0xF93EBC")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0xF93F34", Offset = "0xF93F34", VA = "0xF93F34")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0xF94030", Offset = "0xF94030", VA = "0xF94030")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0xF940AC", Offset = "0xF940AC", VA = "0xF940AC")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0xF94138", Offset = "0xF94138", VA = "0xF94138")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0xF941E4", Offset = "0xF941E4", VA = "0xF941E4")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xF94264", Offset = "0xF94264", VA = "0xF94264")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xF942F4", Offset = "0xF942F4", VA = "0xF942F4")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xF943C8", Offset = "0xF943C8", VA = "0xF943C8")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xF9444C", Offset = "0xF9444C", VA = "0xF9444C")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xF944E0", Offset = "0xF944E0", VA = "0xF944E0")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xF9459C", Offset = "0xF9459C", VA = "0xF9459C")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xF9465C", Offset = "0xF9465C", VA = "0xF9465C")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xF94710", Offset = "0xF94710", VA = "0xF94710")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xF947A0", Offset = "0xF947A0", VA = "0xF947A0")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xF94828", Offset = "0xF94828", VA = "0xF94828")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xF948B0", Offset = "0xF948B0", VA = "0xF948B0")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xF9497C", Offset = "0xF9497C", VA = "0xF9497C")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xF94A0C", Offset = "0xF94A0C", VA = "0xF94A0C")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0xF94A98", Offset = "0xF94A98", VA = "0xF94A98")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0xF94B68", Offset = "0xF94B68", VA = "0xF94B68")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xF94C84", Offset = "0xF94C84", VA = "0xF94C84")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xF94DD4", Offset = "0xF94DD4", VA = "0xF94DD4")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xF94F9C", Offset = "0xF94F9C", VA = "0xF94F9C")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xF95044", Offset = "0xF95044", VA = "0xF95044")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xF950EC", Offset = "0xF950EC", VA = "0xF950EC")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xF951F0", Offset = "0xF951F0", VA = "0xF951F0")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xF952E4", Offset = "0xF952E4", VA = "0xF952E4")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xF953D8", Offset = "0xF953D8", VA = "0xF953D8")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xF954CC", Offset = "0xF954CC", VA = "0xF954CC")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xF954D4", Offset = "0xF954D4", VA = "0xF954D4")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xF954DC", Offset = "0xF954DC", VA = "0xF954DC")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xF954E4", Offset = "0xF954E4", VA = "0xF954E4")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xF8783C", Offset = "0xF8783C", VA = "0xF8783C")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xF8617C", Offset = "0xF8617C", VA = "0xF8617C")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xF874BC", Offset = "0xF874BC", VA = "0xF874BC")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xF9557C", Offset = "0xF9557C", VA = "0xF9557C")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xF95588", Offset = "0xF95588", VA = "0xF95588")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xF87B5C", Offset = "0xF87B5C", VA = "0xF87B5C")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xF82C94", Offset = "0xF82C94", VA = "0xF82C94")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xF95594", Offset = "0xF95594", VA = "0xF95594")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xF9559C", Offset = "0xF9559C", VA = "0xF9559C")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xF955B8", Offset = "0xF955B8", VA = "0xF955B8")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xF82FD8", Offset = "0xF82FD8", VA = "0xF82FD8")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xF955EC", Offset = "0xF955EC", VA = "0xF955EC")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xF955F4", Offset = "0xF955F4", VA = "0xF955F4")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xF95604", Offset = "0xF95604", VA = "0xF95604")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xF95614", Offset = "0xF95614", VA = "0xF95614")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xF95624", Offset = "0xF95624", VA = "0xF95624")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xF95634", Offset = "0xF95634", VA = "0xF95634")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0xF95644", Offset = "0xF95644", VA = "0xF95644")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xF95650", Offset = "0xF95650", VA = "0xF95650")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xF95670", Offset = "0xF95670", VA = "0xF95670")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xF95678", Offset = "0xF95678", VA = "0xF95678")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xF95698", Offset = "0xF95698", VA = "0xF95698")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xF8403C", Offset = "0xF8403C", VA = "0xF8403C")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xF84144", Offset = "0xF84144", VA = "0xF84144")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xF956C4", Offset = "0xF956C4", VA = "0xF956C4")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xF956F0", Offset = "0xF956F0", VA = "0xF956F0")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xF87C6C", Offset = "0xF87C6C", VA = "0xF87C6C")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xF87D94", Offset = "0xF87D94", VA = "0xF87D94")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xF95714", Offset = "0xF95714", VA = "0xF95714")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xF8813C", Offset = "0xF8813C", VA = "0xF8813C")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xF88278", Offset = "0xF88278", VA = "0xF88278")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xF87ED0", Offset = "0xF87ED0", VA = "0xF87ED0")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xF8800C", Offset = "0xF8800C", VA = "0xF8800C")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xF95738", Offset = "0xF95738", VA = "0xF95738")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xF9575C", Offset = "0xF9575C", VA = "0xF9575C")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xF883A8", Offset = "0xF883A8", VA = "0xF883A8")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xF95780", Offset = "0xF95780", VA = "0xF95780")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xF957AC", Offset = "0xF957AC", VA = "0xF957AC")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xF957D8", Offset = "0xF957D8", VA = "0xF957D8")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xF95804", Offset = "0xF95804", VA = "0xF95804")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xF95820", Offset = "0xF95820", VA = "0xF95820")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xF958E0", Offset = "0xF958E0", VA = "0xF958E0")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xF83534", Offset = "0xF83534", VA = "0xF83534")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xF95938", Offset = "0xF95938", VA = "0xF95938")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xF959D0", Offset = "0xF959D0", VA = "0xF959D0")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xF83BB8", Offset = "0xF83BB8", VA = "0xF83BB8")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xF8441C", Offset = "0xF8441C", VA = "0xF8441C")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xF88584", Offset = "0xF88584", VA = "0xF88584")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xF955E0", Offset = "0xF955E0", VA = "0xF955E0")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xF959EC", Offset = "0xF959EC", VA = "0xF959EC")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xF8880C", Offset = "0xF8880C", VA = "0xF8880C")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xF82FD0", Offset = "0xF82FD0", VA = "0xF82FD0")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xF959F8", Offset = "0xF959F8", VA = "0xF959F8")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xF95A20", Offset = "0xF95A20", VA = "0xF95A20")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xF95A3C", Offset = "0xF95A3C", VA = "0xF95A3C")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xF95C04", Offset = "0xF95C04", VA = "0xF95C04")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
[Token(Token = "0x2000026")]
public class LTDescrOptional
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x1700002B")]
	public Transform toTrans
	{
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xF9B1E4", Offset = "0xF9B1E4", VA = "0xF9B1E4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xF9B1EC", Offset = "0xF9B1EC", VA = "0xF9B1EC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public Vector3 point
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xF9B1F4", Offset = "0xF9B1F4", VA = "0xF9B1F4")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xF9B200", Offset = "0xF9B200", VA = "0xF9B200")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public Vector3 axis
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xF9B20C", Offset = "0xF9B20C", VA = "0xF9B20C")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xF9B218", Offset = "0xF9B218", VA = "0xF9B218")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public float lastVal
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xF9B224", Offset = "0xF9B224", VA = "0xF9B224")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xF9B22C", Offset = "0xF9B22C", VA = "0xF9B22C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public Quaternion origRotation
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xF9B234", Offset = "0xF9B234", VA = "0xF9B234")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xF9B240", Offset = "0xF9B240", VA = "0xF9B240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public LTBezierPath path
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xF9B24C", Offset = "0xF9B24C", VA = "0xF9B24C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xF9B254", Offset = "0xF9B254", VA = "0xF9B254")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public LTSpline spline
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xF9B25C", Offset = "0xF9B25C", VA = "0xF9B25C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xF9B264", Offset = "0xF9B264", VA = "0xF9B264")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public LTRect ltRect
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xF9B26C", Offset = "0xF9B26C", VA = "0xF9B26C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xF9B274", Offset = "0xF9B274", VA = "0xF9B274")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xF9B27C", Offset = "0xF9B27C", VA = "0xF9B27C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xF9B284", Offset = "0xF9B284", VA = "0xF9B284")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xF9B28C", Offset = "0xF9B28C", VA = "0xF9B28C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xF9B294", Offset = "0xF9B294", VA = "0xF9B294")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xF9B29C", Offset = "0xF9B29C", VA = "0xF9B29C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xF9B2A4", Offset = "0xF9B2A4", VA = "0xF9B2A4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xF9B2AC", Offset = "0xF9B2AC", VA = "0xF9B2AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xF9B2B4", Offset = "0xF9B2B4", VA = "0xF9B2B4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xF9B2BC", Offset = "0xF9B2BC", VA = "0xF9B2BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xF9B2C4", Offset = "0xF9B2C4", VA = "0xF9B2C4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xF9B2CC", Offset = "0xF9B2CC", VA = "0xF9B2CC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xF9B2D4", Offset = "0xF9B2D4", VA = "0xF9B2D4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xF9B2DC", Offset = "0xF9B2DC", VA = "0xF9B2DC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xF9B2E4", Offset = "0xF9B2E4", VA = "0xF9B2E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xF9B2EC", Offset = "0xF9B2EC", VA = "0xF9B2EC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xF9B2F4", Offset = "0xF9B2F4", VA = "0xF9B2F4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public Action onComplete
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xF9B2FC", Offset = "0xF9B2FC", VA = "0xF9B2FC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xF9B304", Offset = "0xF9B304", VA = "0xF9B304")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xF9B30C", Offset = "0xF9B30C", VA = "0xF9B30C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xF9B314", Offset = "0xF9B314", VA = "0xF9B314")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public object onCompleteParam
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xF9B31C", Offset = "0xF9B31C", VA = "0xF9B31C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xF9B324", Offset = "0xF9B324", VA = "0xF9B324")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public object onUpdateParam
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xF9B32C", Offset = "0xF9B32C", VA = "0xF9B32C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xF9B334", Offset = "0xF9B334", VA = "0xF9B334")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public Action onStart
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xF9B33C", Offset = "0xF9B33C", VA = "0xF9B33C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xF9B344", Offset = "0xF9B344", VA = "0xF9B344")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xF9B34C", Offset = "0xF9B34C", VA = "0xF9B34C")]
	public void reset()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xF9B3C8", Offset = "0xF9B3C8", VA = "0xF9B3C8")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xF9B51C", Offset = "0xF9B51C", VA = "0xF9B51C")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000027")]
public class LTSeq
{
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	[Token(Token = "0x17000040")]
	public int id
	{
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xF9B524", Offset = "0xF9B524", VA = "0xF9B524")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xF9B534", Offset = "0xF9B534", VA = "0xF9B534")]
	public void reset()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xF9B544", Offset = "0xF9B544", VA = "0xF9B544")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xF9B55C", Offset = "0xF9B55C", VA = "0xF9B55C")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xF9B5F0", Offset = "0xF9B5F0", VA = "0xF9B5F0")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xF9B62C", Offset = "0xF9B62C", VA = "0xF9B62C")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xF9B650", Offset = "0xF9B650", VA = "0xF9B650")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xF9B720", Offset = "0xF9B720", VA = "0xF9B720")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xF9B7B4", Offset = "0xF9B7B4", VA = "0xF9B7B4")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xF9B838", Offset = "0xF9B838", VA = "0xF9B838")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xF9B6CC", Offset = "0xF9B6CC", VA = "0xF9B6CC")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xF9B8DC", Offset = "0xF9B8DC", VA = "0xF9B8DC")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xF9B920", Offset = "0xF9B920", VA = "0xF9B920")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xF9B940", Offset = "0xF9B940", VA = "0xF9B940")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xF9B9D4", Offset = "0xF9B9D4", VA = "0xF9B9D4")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xF9B9D8", Offset = "0xF9B9D8", VA = "0xF9B9D8")]
	public LTSeq()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000028")]
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000301")]
		[Address(RVA = "0xF9B9E0", Offset = "0xF9B9E0", VA = "0xF9B9E0")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0xF9B9E8", Offset = "0xF9B9E8", VA = "0xF9B9E8")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0xF9B9F0", Offset = "0xF9B9F0", VA = "0xF9B9F0")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DentedPixel
{
	[Token(Token = "0x200002B")]
	public class LeanDummy
	{
		[Token(Token = "0x6000304")]
		[Address(RVA = "0xF9B9F8", Offset = "0xF9B9F8", VA = "0xF9B9F8")]
		public LeanDummy()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x200002C")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0xF9BA00", Offset = "0xF9BA00", VA = "0xF9BA00")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xF9BB9C", Offset = "0xF9BB9C", VA = "0xF9BB9C")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xF9BD10", Offset = "0xF9BD10", VA = "0xF9BD10")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xF9BE88", Offset = "0xF9BE88", VA = "0xF9BE88")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xF9BEF0", Offset = "0xF9BEF0", VA = "0xF9BEF0")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xF9BF58", Offset = "0xF9BF58", VA = "0xF9BF58")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xF9BFB0", Offset = "0xF9BFB0", VA = "0xF9BFB0")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xF9C028", Offset = "0xF9C028", VA = "0xF9C028")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xF9C080", Offset = "0xF9C080", VA = "0xF9C080")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xF9C0D8", Offset = "0xF9C0D8", VA = "0xF9C0D8")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0xF9C130", Offset = "0xF9C130", VA = "0xF9C130")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xF9C188", Offset = "0xF9C188", VA = "0xF9C188")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xF9C1E8", Offset = "0xF9C1E8", VA = "0xF9C1E8")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xF9C244", Offset = "0xF9C244", VA = "0xF9C244")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xF9C29C", Offset = "0xF9C29C", VA = "0xF9C29C")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000030")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xF9C3BC", Offset = "0xF9C3BC", VA = "0xF9C3BC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xF9C564", Offset = "0xF9C564", VA = "0xF9C564")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xF9C700", Offset = "0xF9C700", VA = "0xF9C700")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xF9C89C", Offset = "0xF9C89C", VA = "0xF9C89C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xF9CA38", Offset = "0xF9CA38", VA = "0xF9CA38")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xF9CBDC", Offset = "0xF9CBDC", VA = "0xF9CBDC")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xF9CE34", Offset = "0xF9CE34", VA = "0xF9CE34")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xF9D314", Offset = "0xF9D314", VA = "0xF9D314")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xF9D578", Offset = "0xF9D578", VA = "0xF9D578")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xF9D7E8", Offset = "0xF9D7E8", VA = "0xF9D7E8")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xF9D9AC", Offset = "0xF9D9AC", VA = "0xF9D9AC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0xF9DF9C", Offset = "0xF9DF9C", VA = "0xF9DF9C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0xF9E13C", Offset = "0xF9E13C", VA = "0xF9E13C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0xF9E2D4", Offset = "0xF9E2D4", VA = "0xF9E2D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0xF9E46C", Offset = "0xF9E46C", VA = "0xF9E46C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0xF9E5EC", Offset = "0xF9E5EC", VA = "0xF9E5EC")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xF9E9F4", Offset = "0xF9E9F4", VA = "0xF9E9F4")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xF9ECD4", Offset = "0xF9ECD4", VA = "0xF9ECD4")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xF9EFCC", Offset = "0xF9EFCC", VA = "0xF9EFCC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xF9F188", Offset = "0xF9F188", VA = "0xF9F188")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0xF9F790", Offset = "0xF9F790", VA = "0xF9F790")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xF9F92C", Offset = "0xF9F92C", VA = "0xF9F92C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xF9FAA0", Offset = "0xF9FAA0", VA = "0xF9FAA0")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xF9FC7C", Offset = "0xF9FC7C", VA = "0xF9FC7C")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200004B")]
		public static class Utils
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0xFA46C0", Offset = "0xFA46C0", VA = "0xFA46C0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xF9FF5C", Offset = "0xF9FF5C", VA = "0xF9FF5C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xFA00D0", Offset = "0xFA00D0", VA = "0xFA00D0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xFA026C", Offset = "0xFA026C", VA = "0xFA026C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xFA03E0", Offset = "0xFA03E0", VA = "0xFA03E0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xFA057C", Offset = "0xFA057C", VA = "0xFA057C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xFA06F0", Offset = "0xFA06F0", VA = "0xFA06F0")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xFA0888", Offset = "0xFA0888", VA = "0xFA0888")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xFA0A6C", Offset = "0xFA0A6C", VA = "0xFA0A6C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xFA0C08", Offset = "0xFA0C08", VA = "0xFA0C08")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xFA0DA4", Offset = "0xFA0DA4", VA = "0xFA0DA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xFA0F40", Offset = "0xFA0F40", VA = "0xFA0F40")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xFA10DC", Offset = "0xFA10DC", VA = "0xFA10DC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xFA1250", Offset = "0xFA1250", VA = "0xFA1250")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xFA13D4", Offset = "0xFA13D4", VA = "0xFA13D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xFA1570", Offset = "0xFA1570", VA = "0xFA1570")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xFA1704", Offset = "0xFA1704", VA = "0xFA1704")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xFA1898", Offset = "0xFA1898", VA = "0xFA1898")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xFA1A3C", Offset = "0xFA1A3C", VA = "0xFA1A3C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xFA1BD4", Offset = "0xFA1BD4", VA = "0xFA1BD4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xFA1D6C", Offset = "0xFA1D6C", VA = "0xFA1D6C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xFA1F04", Offset = "0xFA1F04", VA = "0xFA1F04")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xFA20A0", Offset = "0xFA20A0", VA = "0xFA20A0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xFA223C", Offset = "0xFA223C", VA = "0xFA223C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xFA23C0", Offset = "0xFA23C0", VA = "0xFA23C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xFA2548", Offset = "0xFA2548", VA = "0xFA2548")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xFA26D0", Offset = "0xFA26D0", VA = "0xFA26D0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xFA286C", Offset = "0xFA286C", VA = "0xFA286C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xFA2A10", Offset = "0xFA2A10", VA = "0xFA2A10")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xFA2BDC", Offset = "0xFA2BDC", VA = "0xFA2BDC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xFA2DB0", Offset = "0xFA2DB0", VA = "0xFA2DB0")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xFA31BC", Offset = "0xFA31BC", VA = "0xFA31BC")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xFA334C", Offset = "0xFA334C", VA = "0xFA334C")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xFA34CC", Offset = "0xFA34CC", VA = "0xFA34CC")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xFA364C", Offset = "0xFA364C", VA = "0xFA364C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xFA37D8", Offset = "0xFA37D8", VA = "0xFA37D8")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xFA3974", Offset = "0xFA3974", VA = "0xFA3974")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xFA3B50", Offset = "0xFA3B50", VA = "0xFA3B50")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xFA3CC4", Offset = "0xFA3CC4", VA = "0xFA3CC4")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xFA3EE4", Offset = "0xFA3EE4", VA = "0xFA3EE4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xFA40E4", Offset = "0xFA40E4", VA = "0xFA40E4")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xFA42E4", Offset = "0xFA42E4", VA = "0xFA42E4")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xFA44E4", Offset = "0xFA44E4", VA = "0xFA44E4")]
		public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000075")]
	public static class DOTweenModuleUnityVersion
	{
		[StructLayout(3)]
		[Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40001BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000435")]
			[Address(RVA = "0xFA6934", Offset = "0xFA6934", VA = "0xFA6934", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0xFA6B6C", Offset = "0xFA6B6C", VA = "0xFA6B6C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
		{
			[Token(Token = "0x40001BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xFA6B78", Offset = "0xFA6B78", VA = "0xFA6B78", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xFA6DD4", Offset = "0xFA6DD4", VA = "0xFA6DD4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
		{
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xFA6DE0", Offset = "0xFA6DE0", VA = "0xFA6DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0xFA7004", Offset = "0xFA7004", VA = "0xFA7004", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007B")]
		[CompilerGenerated]
		private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
		{
			[Token(Token = "0x40001C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int elapsedLoops;

			[Token(Token = "0x40001CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xFA7010", Offset = "0xFA7010", VA = "0xFA7010", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0xFA7250", Offset = "0xFA7250", VA = "0xFA7250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
		{
			[Token(Token = "0x40001CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float position;

			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600043D")]
			[Address(RVA = "0xFA725C", Offset = "0xFA725C", VA = "0xFA725C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0xFA74B4", Offset = "0xFA74B4", VA = "0xFA74B4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout(3)]
		[Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
		{
			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Tween t;

			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0xFA74C0", Offset = "0xFA74C0", VA = "0xFA74C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0xFA76EC", Offset = "0xFA76EC", VA = "0xFA76EC", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xFA5680", Offset = "0xFA5680", VA = "0xFA5680")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xFA5860", Offset = "0xFA5860", VA = "0xFA5860")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xFA5A4C", Offset = "0xFA5A4C", VA = "0xFA5A4C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xFA5B34", Offset = "0xFA5B34", VA = "0xFA5B34")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xFA5C1C", Offset = "0xFA5C1C", VA = "0xFA5C1C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xFA5D04", Offset = "0xFA5D04", VA = "0xFA5D04")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xFA5DFC", Offset = "0xFA5DFC", VA = "0xFA5DFC")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xFA5F04", Offset = "0xFA5F04", VA = "0xFA5F04")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xFA5FEC", Offset = "0xFA5FEC", VA = "0xFA5FEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xFA61E0", Offset = "0xFA61E0", VA = "0xFA61E0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xFA63D4", Offset = "0xFA63D4", VA = "0xFA63D4")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xFA649C", Offset = "0xFA649C", VA = "0xFA649C")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xFA6564", Offset = "0xFA6564", VA = "0xFA6564")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xFA662C", Offset = "0xFA662C", VA = "0xFA662C")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xFA6704", Offset = "0xFA6704", VA = "0xFA6704")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xFA67DC", Offset = "0xFA67DC", VA = "0xFA67DC")]
		[AsyncStateMachine(typeof(<AsyncWaitForStart>d__15))]
		public static Task AsyncWaitForStart(this Tween t)
		{
			return null;
		}
	}
	[Token(Token = "0x200007E")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x200007F")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000041")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000441")]
				[Address(RVA = "0xFA76F8", Offset = "0xFA76F8", VA = "0xFA76F8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0xFA5B0C", Offset = "0xFA5B0C", VA = "0xFA5B0C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000080")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000042")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000443")]
				[Address(RVA = "0xFA7728", Offset = "0xFA7728", VA = "0xFA7728", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0xFA5BF4", Offset = "0xFA5BF4", VA = "0xFA5BF4")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000081")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000043")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0xFA7788", Offset = "0xFA7788", VA = "0xFA7788", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0xFA5CDC", Offset = "0xFA5CDC", VA = "0xFA5CDC")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000082")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000044")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0xFA77A4", Offset = "0xFA77A4", VA = "0xFA77A4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0xFA5DCC", Offset = "0xFA5DCC", VA = "0xFA5DCC")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000083")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000045")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0xFA77E4", Offset = "0xFA77E4", VA = "0xFA77E4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0xFA5ECC", Offset = "0xFA5ECC", VA = "0xFA5ECC")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000084")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000046")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0xFA783C", Offset = "0xFA783C", VA = "0xFA783C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0xFA5FC4", Offset = "0xFA5FC4", VA = "0xFA5FC4")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x2000085")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000086")]
		public static class Physics
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xFA79CC", Offset = "0xFA79CC", VA = "0xFA79CC")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0xFA7ACC", Offset = "0xFA7ACC", VA = "0xFA7ACC")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0xFA7B58", Offset = "0xFA7B58", VA = "0xFA7B58")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0xFA7BE4", Offset = "0xFA7BE4", VA = "0xFA7BE4")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xFA7870", Offset = "0xFA7870", VA = "0xFA7870")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xFA7924", Offset = "0xFA7924", VA = "0xFA7924")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000087")]
	[AddComponentMenu("Dark Tonic/Master Audio/Ambient Sound")]
	[AudioScriptOrder(-20)]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("This option is useful if your caller ever moves, as it will make the Audio Source follow to the location of the caller every frame.")]
		public bool FollowCaller;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Tooltip("Using this option, the Audio Source will be updated every frame to the closest position on the caller's collider, if any. This will override the Follow Caller option above and happen instead.")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
		public Transform RuntimeFollower;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000047")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xFA7F30", Offset = "0xFA7F30", VA = "0xFA7F30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public Transform Trans
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xFA80F4", Offset = "0xFA80F4", VA = "0xFA80F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xFA7DB8", Offset = "0xFA7DB8", VA = "0xFA7DB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xFA7E10", Offset = "0xFA7E10", VA = "0xFA7E10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xFA7FB8", Offset = "0xFA7FB8", VA = "0xFA7FB8")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xFA8174", Offset = "0xFA8174", VA = "0xFA8174")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xFA8254", Offset = "0xFA8254", VA = "0xFA8254")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xFA8418", Offset = "0xFA8418", VA = "0xFA8418")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xFA8664", Offset = "0xFA8664", VA = "0xFA8664")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xFA887C", Offset = "0xFA887C", VA = "0xFA887C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0xFA8A94", Offset = "0xFA8A94", VA = "0xFA8A94")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xFA8E78", Offset = "0xFA8E78", VA = "0xFA8E78")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000088")]
	[AddComponentMenu("Dark Tonic/Master Audio/Button Clicker")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40001ED")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40001EE")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xFA8F14", Offset = "0xFA8F14", VA = "0xFA8F14")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xFA9154", Offset = "0xFA9154", VA = "0xFA9154")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xFA9384", Offset = "0xFA9384", VA = "0xFA9384")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xFA9418", Offset = "0xFA9418", VA = "0xFA9418")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xFA9648", Offset = "0xFA9648", VA = "0xFA9648")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000089")]
	[AudioScriptOrder(-30)]
	[AddComponentMenu("Dark Tonic/Master Audio/Event Sounds")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x200008A")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x4000278")]
			Legacy,
			[Token(Token = "0x4000279")]
			uGUI
		}

		[Token(Token = "0x200008B")]
		public enum EventType
		{
			[Token(Token = "0x400027B")]
			OnStart,
			[Token(Token = "0x400027C")]
			OnVisible,
			[Token(Token = "0x400027D")]
			OnInvisible,
			[Token(Token = "0x400027E")]
			OnCollision,
			[Token(Token = "0x400027F")]
			OnTriggerEnter,
			[Token(Token = "0x4000280")]
			OnTriggerExit,
			[Token(Token = "0x4000281")]
			OnMouseEnter,
			[Token(Token = "0x4000282")]
			OnMouseClick,
			[Token(Token = "0x4000283")]
			OnSpawned,
			[Token(Token = "0x4000284")]
			OnDespawned,
			[Token(Token = "0x4000285")]
			OnEnable,
			[Token(Token = "0x4000286")]
			OnDisable,
			[Token(Token = "0x4000287")]
			OnCollision2D,
			[Token(Token = "0x4000288")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000289")]
			OnTriggerExit2D,
			[Token(Token = "0x400028A")]
			OnParticleCollision,
			[Token(Token = "0x400028B")]
			UserDefinedEvent,
			[Token(Token = "0x400028C")]
			OnCollisionExit,
			[Token(Token = "0x400028D")]
			OnCollisionExit2D,
			[Token(Token = "0x400028E")]
			OnMouseUp,
			[Token(Token = "0x400028F")]
			OnMouseExit,
			[Token(Token = "0x4000290")]
			OnMouseDrag,
			[Token(Token = "0x4000291")]
			NGUIOnClick,
			[Token(Token = "0x4000292")]
			NGUIMouseDown,
			[Token(Token = "0x4000293")]
			NGUIMouseUp,
			[Token(Token = "0x4000294")]
			NGUIMouseEnter,
			[Token(Token = "0x4000295")]
			NGUIMouseExit,
			[Token(Token = "0x4000296")]
			MechanimStateChanged,
			[Token(Token = "0x4000297")]
			UnitySliderChanged,
			[Token(Token = "0x4000298")]
			UnityButtonClicked,
			[Token(Token = "0x4000299")]
			UnityPointerDown,
			[Token(Token = "0x400029A")]
			UnityPointerUp,
			[Token(Token = "0x400029B")]
			UnityPointerEnter,
			[Token(Token = "0x400029C")]
			UnityPointerExit,
			[Token(Token = "0x400029D")]
			UnityDrag,
			[Token(Token = "0x400029E")]
			UnityDrop,
			[Token(Token = "0x400029F")]
			UnityScroll,
			[Token(Token = "0x40002A0")]
			UnityUpdateSelected,
			[Token(Token = "0x40002A1")]
			UnitySelect,
			[Token(Token = "0x40002A2")]
			UnityDeselect,
			[Token(Token = "0x40002A3")]
			UnityMove,
			[Token(Token = "0x40002A4")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40002A5")]
			UnityBeginDrag,
			[Token(Token = "0x40002A6")]
			UnityEndDrag,
			[Token(Token = "0x40002A7")]
			UnitySubmit,
			[Token(Token = "0x40002A8")]
			UnityCancel,
			[Token(Token = "0x40002A9")]
			UnityToggle,
			[Token(Token = "0x40002AA")]
			OnTriggerStay,
			[Token(Token = "0x40002AB")]
			OnTriggerStay2D,
			[Token(Token = "0x40002AC")]
			CodeTriggeredEvent1,
			[Token(Token = "0x40002AD")]
			CodeTriggeredEvent2
		}

		[Token(Token = "0x200008C")]
		public enum GlidePitchType
		{
			[Token(Token = "0x40002AF")]
			None,
			[Token(Token = "0x40002B0")]
			RaisePitch,
			[Token(Token = "0x40002B1")]
			LowerPitch
		}

		[Token(Token = "0x200008D")]
		public enum VariationType
		{
			[Token(Token = "0x40002B3")]
			PlaySpecific,
			[Token(Token = "0x40002B4")]
			PlayRandom
		}

		[Token(Token = "0x200008E")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40002B6")]
			None,
			[Token(Token = "0x40002B7")]
			Stop,
			[Token(Token = "0x40002B8")]
			FadeOut
		}

		[Token(Token = "0x200008F")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40002BA")]
			None,
			[Token(Token = "0x40002BB")]
			FrameBased,
			[Token(Token = "0x40002BC")]
			TimeBased
		}

		[Token(Token = "0x2000090")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__129 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x1700004C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004A5")]
				[Address(RVA = "0xFD74D0", Offset = "0xFD74D0", VA = "0xFD74D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004A7")]
				[Address(RVA = "0xFD7518", Offset = "0xFD7518", VA = "0xFD7518", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0xFD731C", Offset = "0xFD731C", VA = "0xFD731C")]
			[DebuggerHidden]
			public <CoUpdate>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xFD7344", Offset = "0xFD7344", VA = "0xFD7344", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xFD7348", Offset = "0xFD7348", VA = "0xFD7348", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xFD74D8", Offset = "0xFD74D8", VA = "0xFD74D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup codeTriggeredEvent1Sound;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup codeTriggeredEvent2Sound;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useStartSound;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useVisibleSound;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useInvisibleSound;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useCollisionSound;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useDespawnedSound;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useEnableSound;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useDisableSound;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useCollision2dSound;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useCodeTriggeredEvent1Sound;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useCodeTriggeredEvent2Sound;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E7")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
		public bool useUnityDragSound;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EA")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EB")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
		public bool useUnityDropSound;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EE")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EF")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F3")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F5")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F6")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F7")]
		public bool useUnityCancelSound;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public bool useUnityToggleSound;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Slider _slider;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Toggle _toggle;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Button _button;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private bool _isVisible;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
		private bool _needsCoroutine;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private float? _triggerEnterTime;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Transform _trans;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Animator _anim;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private AudioEventGroup eventsToPlayDuringStart;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private bool startHappened;

		[Token(Token = "0x17000049")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0xFA9814", Offset = "0xFA9814", VA = "0xFA9814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0xFAB198", Offset = "0xFAB198", VA = "0xFAB198")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		private Transform Trans
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0xFAE50C", Offset = "0xFAE50C", VA = "0xFAE50C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xFA971C", Offset = "0xFA971C", VA = "0xFA971C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xFA9AAC", Offset = "0xFA9AAC", VA = "0xFA9AAC", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xFA9C58", Offset = "0xFA9C58", VA = "0xFA9C58")]
		[IteratorStateMachine(typeof(<CoUpdate>d__129))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xFA9CC0", Offset = "0xFA9CC0", VA = "0xFA9CC0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xFAA364", Offset = "0xFAA364", VA = "0xFAA364")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0xFAA38C", Offset = "0xFAA38C", VA = "0xFAA38C")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xFAA3A8", Offset = "0xFAA3A8", VA = "0xFAA3A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xFAA6A0", Offset = "0xFAA6A0", VA = "0xFAA6A0")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xFAAA48", Offset = "0xFAAA48", VA = "0xFAAA48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xFAAE20", Offset = "0xFAAE20", VA = "0xFAAE20")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xFAAF2C", Offset = "0xFAAF2C", VA = "0xFAAF2C")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xFAAF4C", Offset = "0xFAAF4C", VA = "0xFAAF4C")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xFAAF6C", Offset = "0xFAAF6C", VA = "0xFAAF6C")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xFAAF8C", Offset = "0xFAAF8C", VA = "0xFAAF8C")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xFAAFAC", Offset = "0xFAAFAC", VA = "0xFAAFAC")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xFAAFB0", Offset = "0xFAAFB0", VA = "0xFAAFB0")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xFAAFD0", Offset = "0xFAAFD0", VA = "0xFAAFD0")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xFAAFD4", Offset = "0xFAAFD4", VA = "0xFAAFD4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xFAAFF4", Offset = "0xFAAFF4", VA = "0xFAAFF4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xFAB014", Offset = "0xFAB014", VA = "0xFAB014")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xFAB034", Offset = "0xFAB034", VA = "0xFAB034")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xFAB038", Offset = "0xFAB038", VA = "0xFAB038")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xFAB058", Offset = "0xFAB058", VA = "0xFAB058")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xFAB078", Offset = "0xFAB078", VA = "0xFAB078")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xFAB098", Offset = "0xFAB098", VA = "0xFAB098")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xFAB0B8", Offset = "0xFAB0B8", VA = "0xFAB0B8")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xFAB0D8", Offset = "0xFAB0D8", VA = "0xFAB0D8")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xFAB0F8", Offset = "0xFAB0F8", VA = "0xFAB0F8")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xFAB118", Offset = "0xFAB118", VA = "0xFAB118")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xFAB138", Offset = "0xFAB138", VA = "0xFAB138")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xFAB168", Offset = "0xFAB168", VA = "0xFAB168")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xFAB180", Offset = "0xFAB180", VA = "0xFAB180")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xFAB1A8", Offset = "0xFAB1A8", VA = "0xFAB1A8")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xFAB1E0", Offset = "0xFAB1E0", VA = "0xFAB1E0")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xFAB200", Offset = "0xFAB200", VA = "0xFAB200")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xFAB238", Offset = "0xFAB238", VA = "0xFAB238")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xFAB278", Offset = "0xFAB278", VA = "0xFAB278")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xFAB298", Offset = "0xFAB298", VA = "0xFAB298")]
		public void ActivateCodeTriggeredEvent1()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xFAB2B0", Offset = "0xFAB2B0", VA = "0xFAB2B0")]
		public void ActivateCodeTriggeredEvent2()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xFAB2C8", Offset = "0xFAB2C8", VA = "0xFAB2C8")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0xFAB364", Offset = "0xFAB364", VA = "0xFAB364")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0xFAB52C", Offset = "0xFAB52C", VA = "0xFAB52C")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0xFAB77C", Offset = "0xFAB77C", VA = "0xFAB77C")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0xFAA138", Offset = "0xFAA138", VA = "0xFAA138")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xFAE1DC", Offset = "0xFAE1DC", VA = "0xFAE1DC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0xFAE374", Offset = "0xFAE374", VA = "0xFAE374")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0xFAB82C", Offset = "0xFAB82C", VA = "0xFAB82C")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0xFAB8B8", Offset = "0xFAB8B8", VA = "0xFAB8B8")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0xFAE58C", Offset = "0xFAE58C", VA = "0xFAE58C")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0xFA9D14", Offset = "0xFA9D14", VA = "0xFA9D14", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xFAE82C", Offset = "0xFAE82C", VA = "0xFAE82C", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xFAE900", Offset = "0xFAE900", VA = "0xFAE900", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xFAA9B8", Offset = "0xFAA9B8", VA = "0xFAA9B8", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xFAAD98", Offset = "0xFAAD98", VA = "0xFAAD98", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xFAE9D0", Offset = "0xFAE9D0", VA = "0xFAE9D0", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xFA9824", Offset = "0xFA9824", VA = "0xFA9824")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600049E")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xFAEA20", Offset = "0xFAEA20", VA = "0xFAEA20")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x1700004E")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0xFD7908", Offset = "0xFD7908", VA = "0xFD7908")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0xFD7910", Offset = "0xFD7910", VA = "0xFD7910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xFD7918", Offset = "0xFD7918", VA = "0xFD7918")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xFD7920", Offset = "0xFD7920", VA = "0xFD7920", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xFD79B8", Offset = "0xFD79B8", VA = "0xFD79B8")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xFD79C0", Offset = "0xFD79C0", VA = "0xFD79C0", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xFD7A58", Offset = "0xFD7A58", VA = "0xFD7A58")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xFD7A60", Offset = "0xFD7A60", VA = "0xFD7A60", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xFD7AF8", Offset = "0xFD7AF8", VA = "0xFD7AF8")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xFD7B00", Offset = "0xFD7B00", VA = "0xFD7B00", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xFD7B98", Offset = "0xFD7B98", VA = "0xFD7B98")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xFD7BA0", Offset = "0xFD7BA0", VA = "0xFD7BA0", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xFD7C38", Offset = "0xFD7C38", VA = "0xFD7C38")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xFD7C40", Offset = "0xFD7C40", VA = "0xFD7C40", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xFD7CD8", Offset = "0xFD7CD8", VA = "0xFD7CD8")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xFD7CE0", Offset = "0xFD7CE0", VA = "0xFD7CE0", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xFD7D78", Offset = "0xFD7D78", VA = "0xFD7D78")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xFD7D80", Offset = "0xFD7D80", VA = "0xFD7D80", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xFD7E18", Offset = "0xFD7E18", VA = "0xFD7E18")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xFD7E20", Offset = "0xFD7E20", VA = "0xFD7E20", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xFD7EB8", Offset = "0xFD7EB8", VA = "0xFD7EB8")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xFD7EC0", Offset = "0xFD7EC0", VA = "0xFD7EC0", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xFD7F58", Offset = "0xFD7F58", VA = "0xFD7F58")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xFD7F60", Offset = "0xFD7F60", VA = "0xFD7F60", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xFD7FF8", Offset = "0xFD7FF8", VA = "0xFD7FF8")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xFD8000", Offset = "0xFD8000", VA = "0xFD8000", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xFD8098", Offset = "0xFD8098", VA = "0xFD8098")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xFD80A0", Offset = "0xFD80A0", VA = "0xFD80A0", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xFD8138", Offset = "0xFD8138", VA = "0xFD8138")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xFD8140", Offset = "0xFD8140", VA = "0xFD8140", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xFD81D8", Offset = "0xFD81D8", VA = "0xFD81D8")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xFD81E0", Offset = "0xFD81E0", VA = "0xFD81E0", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xFD8278", Offset = "0xFD8278", VA = "0xFD8278")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xFD8280", Offset = "0xFD8280", VA = "0xFD8280", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xFD8318", Offset = "0xFD8318", VA = "0xFD8318")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	[AddComponentMenu("Dark Tonic/Master Audio/Footstep Sounds")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x20000A4")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x40002D3")]
			None,
			[Token(Token = "0x40002D4")]
			OnCollision,
			[Token(Token = "0x40002D5")]
			OnTriggerEnter,
			[Token(Token = "0x40002D6")]
			OnCollision2D,
			[Token(Token = "0x40002D7")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700004F")]
		private Transform Trans
		{
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0xFD86B0", Offset = "0xFD86B0", VA = "0xFD86B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xFD8320", Offset = "0xFD8320", VA = "0xFD8320")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xFD83A4", Offset = "0xFD83A4", VA = "0xFD83A4")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xFD8730", Offset = "0xFD8730", VA = "0xFD8730")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Retrigger Events Each Time Anim Loops w/o Exiting State")]
		[Tooltip("Select for event to re-fire each time animation loops without exiting state")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Fire A Custom Event When State Is Entered")]
		[Header("Enter Custom Event")]
		public bool fireEnterEvent;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Exit Custom Event")]
		[Tooltip("Fire a Custom Event when state is Exited")]
		public bool fireExitEvent;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Fire a Custom Event timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.")]
		[Header("Fire Custom EventTimed to Animation")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireEvent;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Fire Multiple Custom Events Timed to Anim")]
		[Tooltip("Fire a Custom Event with timed to the animation.  This allows you to time your Custom Events to the actions in you animation. Select the number of Custom Events to be fired, up to 4. Then set the time you want each Custom Event to fire with each subsequent time greater than the previous time.")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 4f)]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xFD87C4", Offset = "0xFD87C4", VA = "0xFD87C4", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xFD8924", Offset = "0xFD8924", VA = "0xFD8924", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xFD8BFC", Offset = "0xFD8BFC", VA = "0xFD8BFC", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xFD8890", Offset = "0xFD8890", VA = "0xFD8890")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xFD8CC8", Offset = "0xFD8CC8", VA = "0xFD8CC8")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Select For Sounds To Follow Object")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Select for sounds to retrigger each time animation loops without exiting state")]
		[Header("Retrigger Sounds Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Tooltip("Play a Sound Group when state is Entered")]
		[Header("Enter Sound Group")]
		public bool playEnterSound;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string enterVariationName;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Tooltip("Play a Sound Group when state is Exited")]
		[Header("Exit Sound Group")]
		public bool playExitSound;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string exitVariationName;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Play a Sound Group (Normal or Looped Chain Variation Mode) timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.  Select a stop time greater than the start time or leave stop time equals to zero and select Stop Anim Time Sound On Exit.  This can be used for Looped Chain Sound Groups since you have to define a stop time.")]
		[Header("Play Sound Group Timed to Animation")]
		public bool playAnimTimeSound;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[Tooltip("If selected, When To Stop Sound (below) will be used. Otherwise the sound will not be stopped unless you have Stop Anim Time Sound On Exit selected above.")]
		public bool useStopTime;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartSound;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStopSound;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string timedVariationName;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[Tooltip("Play a Sound Group with each variation timed to the animation.  This allows you to time your sounds to the actions in you animation.  Example: A sword swing combo where you want swoosh soundsor character grunts timed to the acceleration phase of the sword swing.  Select the number of sounds to be played, up to 4.  Then set the time you want each sound to start with each subsequent time greater than the previous time.")]
		[Header("Play Multiple Sounds Timed to Anim")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 4f)]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound4;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string multiTimedVariationName;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xFD8D38", Offset = "0xFD8D38", VA = "0xFD8D38", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xFD8F18", Offset = "0xFD8F18", VA = "0xFD8F18", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xFD94C4", Offset = "0xFD94C4", VA = "0xFD94C4", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xFD8E38", Offset = "0xFD8E38", VA = "0xFD8E38")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xFD8ECC", Offset = "0xFD8ECC", VA = "0xFD8ECC")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xFD96A0", Offset = "0xFD96A0", VA = "0xFD96A0")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x17000050")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xFD9734", Offset = "0xFD9734", VA = "0xFD9734")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xFD973C", Offset = "0xFD973C", VA = "0xFD973C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xFD9748", Offset = "0xFD9748", VA = "0xFD9748")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xFD9750", Offset = "0xFD9750", VA = "0xFD9750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0xFD975C", Offset = "0xFD975C", VA = "0xFD975C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xFD9764", Offset = "0xFD9764", VA = "0xFD9764")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xFD9714", Offset = "0xFD9714", VA = "0xFD9714")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A8")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xFD976C", Offset = "0xFD976C", VA = "0xFD976C")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A9")]
	public class AudioEvent
	{
		[Token(Token = "0x20000AA")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x400033F")]
			UseSliderValue,
			[Token(Token = "0x4000340")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x20000AB")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xFD99AC", Offset = "0xFD99AC", VA = "0xFD99AC")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool fireCustomEventAfterFade;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000053")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xFD9774", Offset = "0xFD9774", VA = "0xFD9774")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xFD97DC", Offset = "0xFD97DC", VA = "0xFD97DC")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xFD99E4", Offset = "0xFD99E4", VA = "0xFD99E4")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xFD9C2C", Offset = "0xFD9C2C", VA = "0xFD9C2C")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AE")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xFD9C54", Offset = "0xFD9C54", VA = "0xFD9C54")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AF")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xFD9C64", Offset = "0xFD9C64", VA = "0xFD9C64")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class CustomEvent
	{
		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x17000054")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xFD9E68", Offset = "0xFD9E68", VA = "0xFD9E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xFD9C74", Offset = "0xFD9C74", VA = "0xFD9C74")]
		public CustomEvent(string eventName)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xFD9D3C", Offset = "0xFD9D3C", VA = "0xFD9D3C")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xFD9E10", Offset = "0xFD9E10", VA = "0xFD9E10")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B1")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x17000055")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xFD9FE4", Offset = "0xFD9FE4", VA = "0xFD9FE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xFD9EB8", Offset = "0xFD9EB8", VA = "0xFD9EB8")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xFD9F8C", Offset = "0xFD9F8C", VA = "0xFD9F8C")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xFDA034", Offset = "0xFDA034", VA = "0xFDA034")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xFDA0E0", Offset = "0xFDA0E0", VA = "0xFDA0E0")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xFDA0E8", Offset = "0xFDA0E8", VA = "0xFDA0E8")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 10f)]
		public int importance;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isUninterruptible;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useLocalization;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool useRandomPitch;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int weight;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string clipAlias;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string resourceFileName;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isExpanded;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isChecked;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useFades;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fadeInTime;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeOutTime;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useCustomLooping;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int minCustomLoops;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int maxCustomLoops;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useIntroSilence;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float introSilenceMin;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float introSilenceMax;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool useRandomStartTime;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomStartMinPercent;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float randomEndPercent;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Transform _trans;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource _aud;

		[Token(Token = "0x17000056")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xFDA14C", Offset = "0xFDA14C", VA = "0xFDA14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xFDA1E0", Offset = "0xFDA1E0", VA = "0xFDA1E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0xFDA274", Offset = "0xFDA274", VA = "0xFDA274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0xFDA308", Offset = "0xFDA308", VA = "0xFDA308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0xFDA39C", Offset = "0xFDA39C", VA = "0xFDA39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xFDA430", Offset = "0xFDA430", VA = "0xFDA430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0xFDA4C4", Offset = "0xFDA4C4", VA = "0xFDA4C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public Transform Trans
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xFDA628", Offset = "0xFDA628", VA = "0xFDA628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0xFDA6A8", Offset = "0xFDA6A8", VA = "0xFDA6A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0xFDA8C0", Offset = "0xFDA8C0", VA = "0xFDA8C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xFDA954", Offset = "0xFDA954", VA = "0xFDA954")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useClipAgePriority;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool ignoreListenerPause;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 10f)]
		public int importance;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool isUninterruptible;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float spatialBlend;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string busName;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isExistingBus;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int limitPerXFrames;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float minimumTimeBetween;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool limitPolyphony;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int voiceLimitCount;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float despawnFadeTime;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xFDA990", Offset = "0xFDA990", VA = "0xFDA990")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class FootstepGroup
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xFDAB10", Offset = "0xFDAB10", VA = "0xFDAB10")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class GroupBus
	{
		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isExisting;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isTemporary;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.BusVoiceLimitExceededMode busVoiceLimitExceededMode;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color busColor;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool forceTo2D;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _originalVolume;

		[Token(Token = "0x17000060")]
		public int ActiveVoices
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xFDAF74", Offset = "0xFDAF74", VA = "0xFDAF74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000061")]
		public bool HasLiveActors
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0xFDAFBC", Offset = "0xFDAFBC", VA = "0xFDAFBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xFDB00C", Offset = "0xFDB00C", VA = "0xFDB00C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xFDB070", Offset = "0xFDB070", VA = "0xFDB070")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0xFDB078", Offset = "0xFDB078", VA = "0xFDB078")]
			set
			{
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xFDAD1C", Offset = "0xFDAD1C", VA = "0xFDAD1C")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xFDADF0", Offset = "0xFDADF0", VA = "0xFDADF0")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xFDAE48", Offset = "0xFDAE48", VA = "0xFDAE48")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xFDAF1C", Offset = "0xFDAF1C", VA = "0xFDAF1C")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xFDB080", Offset = "0xFDB080", VA = "0xFDB080")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B8")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xFDB150", Offset = "0xFDB150", VA = "0xFDB150")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B9")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xFDB160", Offset = "0xFDB160", VA = "0xFDB160")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000515")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000516")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x6000517")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000518")]
		void RegisterReceiver();

		[Token(Token = "0x6000519")]
		void UnregisterReceiver();

		[Token(Token = "0x600051A")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x20000BB")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000449")]
			None,
			[Token(Token = "0x400044A")]
			Stop,
			[Token(Token = "0x400044B")]
			FadeOut
		}

		[Token(Token = "0x20000BD")]
		public enum VariationSequence
		{
			[Token(Token = "0x400044D")]
			Randomized,
			[Token(Token = "0x400044E")]
			TopToBottom
		}

		[Token(Token = "0x20000BE")]
		public enum VariationMode
		{
			[Token(Token = "0x4000450")]
			Normal,
			[Token(Token = "0x4000451")]
			LoopedChain,
			[Token(Token = "0x4000452")]
			Dialog
		}

		[Token(Token = "0x20000BF")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000454")]
			Endless,
			[Token(Token = "0x4000455")]
			NumberOfLoops
		}

		[Token(Token = "0x20000C0")]
		public enum LimitMode
		{
			[Token(Token = "0x4000457")]
			None,
			[Token(Token = "0x4000458")]
			FrameBased,
			[Token(Token = "0x4000459")]
			TimeBased
		}

		[Token(Token = "0x4000409")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x400040A")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x400040B")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSelected;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isExpanded;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float groupMasterVolume;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retriggerPercentage;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ignoreListenerPause;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 10f)]
		public int importance;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isUninterruptible;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMin;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float chainLoopDelayMax;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int chainLoopNumLoops;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDialogFadeOut;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string comments;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool logSound;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public LimitMode limitMode;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int limitPerXFrames;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool limitPolyphony;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int voiceLimitCount;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float despawnFadeTime;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isSoloed;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		public bool isMuted;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int frames;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _objectName;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _originalVolume;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x17000064")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0xFDB8A8", Offset = "0xFDB8A8", VA = "0xFDB8A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0xFDB984", Offset = "0xFDB984", VA = "0xFDB984")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public int TotalVoices
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0xFDB9D0", Offset = "0xFDB9D0", VA = "0xFDB9D0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xFDB9F0", Offset = "0xFDB9F0", VA = "0xFDB9F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0xFDB634", Offset = "0xFDB634", VA = "0xFDB634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xFDB9FC", Offset = "0xFDB9FC", VA = "0xFDB9FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0xFDBA04", Offset = "0xFDBA04", VA = "0xFDBA04")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0xFDBA0C", Offset = "0xFDBA0C", VA = "0xFDBA0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public int ChainLoopCount
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xFDBAA4", Offset = "0xFDBAA4", VA = "0xFDBAA4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0xFDBAAC", Offset = "0xFDBAAC", VA = "0xFDBAAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public string GameObjectName
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0xFDBAB4", Offset = "0xFDBAB4", VA = "0xFDBAB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public MasterAudio.GroupPlayType GroupPlayType
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0xFDBAEC", Offset = "0xFDBAEC", VA = "0xFDBAEC")]
			get
			{
				return default(MasterAudio.GroupPlayType);
			}
		}

		[Token(Token = "0x1700006E")]
		public bool HasLiveActors
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xFDBC18", Offset = "0xFDBC18", VA = "0xFDBC18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0xFDBC68", Offset = "0xFDBC68", VA = "0xFDBC68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private Transform Trans
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xFDB4C0", Offset = "0xFDB4C0", VA = "0xFDB4C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0xFDB420", Offset = "0xFDB420", VA = "0xFDB420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xFDB1E4", Offset = "0xFDB1E4", VA = "0xFDB1E4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0xFDB280", Offset = "0xFDB280", VA = "0xFDB280")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xFDB31C", Offset = "0xFDB31C", VA = "0xFDB31C")]
		private void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xFDB540", Offset = "0xFDB540", VA = "0xFDB540")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xFDB700", Offset = "0xFDB700", VA = "0xFDB700")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xFDB77C", Offset = "0xFDB77C", VA = "0xFDB77C")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xFDB850", Offset = "0xFDB850", VA = "0xFDB850")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xFDBA78", Offset = "0xFDBA78", VA = "0xFDBA78")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xFDBA94", Offset = "0xFDBA94", VA = "0xFDBA94")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xFDBA9C", Offset = "0xFDBA9C", VA = "0xFDBA9C")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xFDBCD4", Offset = "0xFDBCD4", VA = "0xFDBCD4")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class MasterAudioSettings : SingletonScriptable<MasterAudioSettings>
	{
		[Token(Token = "0x400045A")]
		public const string AssetName = "MasterAudioSettings.asset";

		[Token(Token = "0x400045B")]
		public const string AssetFolder = "Assets/Resources/MasterAudio";

		[Token(Token = "0x400045C")]
		public const string ResourcePath = "MasterAudio/MasterAudioSettings";

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseDbScale;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool RemoveUnplayedDueToProbabilityVariation;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool UseCentsPitch;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool HideLogoNav;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool EditMAFolder;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string InstallationFolderPath;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.MixerWidthMode MixerWidthSetting;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool BusesShownInNarrow;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool ShowWelcomeWindowOnStart;

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xFDBED4", Offset = "0xFDBED4", VA = "0xFDBED4")]
		static MasterAudioSettings()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xFDC0D4", Offset = "0xFDC0D4", VA = "0xFDC0D4")]
		public MasterAudioSettings()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000538")]
		[Address(RVA = "0xFDC174", Offset = "0xFDC174", VA = "0xFDC174")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C3")]
	public class MusicSetting
	{
		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float sectionStartTime;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float sectionEndTime;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songStartedCustomEvent;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string songChangedCustomEvent;

		[Token(Token = "0x17000072")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0xFDC32C", Offset = "0xFDC32C", VA = "0xFDC32C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0xFDC344", Offset = "0xFDC344", VA = "0xFDC344")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		public float SongStartTime
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0xFDC3E0", Offset = "0xFDC3E0", VA = "0xFDC3E0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xFDC17C", Offset = "0xFDC17C", VA = "0xFDC17C")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xFDC41C", Offset = "0xFDC41C", VA = "0xFDC41C")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000C8")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xFDCD24", Offset = "0xFDCD24", VA = "0xFDCD24")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000547")]
		[Address(RVA = "0xFDCD34", Offset = "0xFDCD34", VA = "0xFDCD34")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CA")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xFDCC1C", Offset = "0xFDCC1C", VA = "0xFDCC1C")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CB")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xFDCBE4", Offset = "0xFDCBE4", VA = "0xFDCBE4")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CC")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xFDCC54", Offset = "0xFDCC54", VA = "0xFDCC54")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x20000CE")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000499")]
			Boolean,
			[Token(Token = "0x400049A")]
			String,
			[Token(Token = "0x400049B")]
			Integer,
			[Token(Token = "0x400049C")]
			Float
		}

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xFDCD3C", Offset = "0xFDCD3C", VA = "0xFDCD3C")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000CF")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xFDCBAC", Offset = "0xFDCBAC", VA = "0xFDCBAC")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600054D")]
		[Address(RVA = "0xFDCD8C", Offset = "0xFDCD8C", VA = "0xFDCD8C")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	[AudioScriptOrder(-40)]
	[RequireComponent(typeof(SoundGroupVariationUpdater))]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x20000D2")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x20000D3")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x20000D4")]
		public class PlaySoundParams
		{
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xFE19E8", Offset = "0xFE19E8", VA = "0xFE19E8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		public enum PitchMode
		{
			[Token(Token = "0x40004F4")]
			None,
			[Token(Token = "0x40004F5")]
			Gliding
		}

		[Token(Token = "0x20000D6")]
		public enum FadeMode
		{
			[Token(Token = "0x40004F7")]
			None,
			[Token(Token = "0x40004F8")]
			FadeInOut,
			[Token(Token = "0x40004F9")]
			FadeOutEarly,
			[Token(Token = "0x40004FA")]
			GradualFade
		}

		[Token(Token = "0x20000D7")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x40004FC")]
			AddToClipPitch,
			[Token(Token = "0x40004FD")]
			IgnoreClipPitch
		}

		[Token(Token = "0x20000D8")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x40004FF")]
			AddToClipVolume,
			[Token(Token = "0x4000500")]
			IgnoreClipVolume
		}

		[Token(Token = "0x20000D9")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000502")]
			None,
			[Token(Token = "0x4000503")]
			DetectEnd
		}

		[Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__113 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x17000097")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B0")]
				[Address(RVA = "0xFE1DB4", Offset = "0xFE1DB4", VA = "0xFE1DB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B2")]
				[Address(RVA = "0xFE1DFC", Offset = "0xFE1DFC", VA = "0xFE1DFC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xFE0520", Offset = "0xFE0520", VA = "0xFE0520")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__113(int <>1__state)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xFE1CF0", Offset = "0xFE1CF0", VA = "0xFE1CF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xFE1CF4", Offset = "0xFE1CF4", VA = "0xFE1CF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xFE1DBC", Offset = "0xFE1DBC", VA = "0xFE1DBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 10f)]
		public int importance;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isUninterruptible;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool useLocalization;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool useRandomPitch;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMin;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomPitchMax;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useRandomVolume;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMin;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float randomVolumeMax;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string clipAlias;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string resourceFileName;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_pitch;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float original_volume;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool isExpanded;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool isChecked;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool useFades;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeInTime;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float fadeOutTime;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useCustomLooping;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int minCustomLoops;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int maxCustomLoops;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useRandomStartTime;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMinPercent;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float randomEndPercent;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool useIntroSilence;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMin;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float introSilenceMax;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int frames;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string _objectName;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _maxVol;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _instanceId;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool? _audioLoops;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _maxLoops;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string _soundGroupName;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool _isStopRequested;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		private bool _isPaused;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		private bool _isWarmingPlay;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _trans;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject _go;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform _objectToFollow;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _attachToSource;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private string _resFileName;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private TransformFollower _ambientFollower;

		[Token(Token = "0x17000075")]
		public TransformFollower AmbientFollower
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xFE0FBC", Offset = "0xFE0FBC", VA = "0xFE0FBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xFE0FC4", Offset = "0xFE0FC4", VA = "0xFE0FC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xFE1058", Offset = "0xFE1058", VA = "0xFE1058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xFE10EC", Offset = "0xFE10EC", VA = "0xFE10EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xFE1180", Offset = "0xFE1180", VA = "0xFE1180")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xFE1214", Offset = "0xFE1214", VA = "0xFE1214")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xFE121C", Offset = "0xFE121C", VA = "0xFE121C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xFE1224", Offset = "0xFE1224", VA = "0xFE1224")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0xFE12B8", Offset = "0xFE12B8", VA = "0xFE12B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xFE12C0", Offset = "0xFE12C0", VA = "0xFE12C0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xFE13F0", Offset = "0xFE13F0", VA = "0xFE13F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0xFE13F8", Offset = "0xFE13F8", VA = "0xFE13F8")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xFE1400", Offset = "0xFE1400", VA = "0xFE1400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0xFDD504", Offset = "0xFDD504", VA = "0xFDD504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xFDE5AC", Offset = "0xFDE5AC", VA = "0xFDE5AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000081")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0xFE1608", Offset = "0xFE1608", VA = "0xFE1608")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000082")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0xFE163C", Offset = "0xFE163C", VA = "0xFE163C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0xFE166C", Offset = "0xFE166C", VA = "0xFE166C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public float LastTimePlayed
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xFE1708", Offset = "0xFE1708", VA = "0xFE1708")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0xFE1710", Offset = "0xFE1710", VA = "0xFE1710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xFE1718", Offset = "0xFE1718", VA = "0xFE1718")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public bool IsPlaying
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xFDD6B0", Offset = "0xFDD6B0", VA = "0xFDD6B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xFE1728", Offset = "0xFE1728", VA = "0xFE1728")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0xFDE4D0", Offset = "0xFDE4D0", VA = "0xFDE4D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int InstanceId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xFDECE8", Offset = "0xFDECE8", VA = "0xFDECE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public bool IsStopRequested
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0xFE1730", Offset = "0xFE1730", VA = "0xFE1730")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform Trans
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xFE0390", Offset = "0xFE0390", VA = "0xFE0390")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xFDD484", Offset = "0xFDD484", VA = "0xFDD484")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xFDD1AC", Offset = "0xFDD1AC", VA = "0xFDD1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xFDEC38", Offset = "0xFDEC38", VA = "0xFDEC38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		public string ResFileName
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xFDE8E4", Offset = "0xFDE8E4", VA = "0xFDE8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0xFDD9FC", Offset = "0xFDD9FC", VA = "0xFDD9FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xFE17C8", Offset = "0xFE17C8", VA = "0xFE17C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0xFE17D0", Offset = "0xFE17D0", VA = "0xFE17D0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0xFE17EC", Offset = "0xFE17EC", VA = "0xFE17EC")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public int MaxLoops
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0xFE1808", Offset = "0xFE1808", VA = "0xFE1808")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000093")]
		private bool Is2D
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0xFE1810", Offset = "0xFE1810", VA = "0xFE1810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0xFDDB6C", Offset = "0xFDDB6C", VA = "0xFDDB6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public bool IsPaused
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0xFE1838", Offset = "0xFE1838", VA = "0xFE1838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		public string GameObjectName
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0xFE185C", Offset = "0xFE185C", VA = "0xFE185C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0xFE1894", Offset = "0xFE1894", VA = "0xFE1894")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0xFDCD94", Offset = "0xFDCD94", VA = "0xFDCD94")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xFDCE34", Offset = "0xFDCE34", VA = "0xFDCE34")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0xFDCED4", Offset = "0xFDCED4", VA = "0xFDCED4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xFDCF74", Offset = "0xFDCF74", VA = "0xFDCF74")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xFDD014", Offset = "0xFDD014", VA = "0xFDD014")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xFDD240", Offset = "0xFDD240", VA = "0xFDD240")]
		private void Start()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xFDD6CC", Offset = "0xFDD6CC", VA = "0xFDD6CC")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xFDD71C", Offset = "0xFDD71C", VA = "0xFDD71C")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xFDD8B4", Offset = "0xFDD8B4", VA = "0xFDD8B4")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xFDD80C", Offset = "0xFDD80C", VA = "0xFDD80C")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xFDDD04", Offset = "0xFDDD04", VA = "0xFDDD04")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xFDDD9C", Offset = "0xFDDD9C", VA = "0xFDDD9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xFDDE48", Offset = "0xFDDE48", VA = "0xFDDE48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xFDDDA0", Offset = "0xFDDDA0", VA = "0xFDDDA0")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xFDE190", Offset = "0xFDE190", VA = "0xFDE190")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xFDE50C", Offset = "0xFDE50C", VA = "0xFDE50C")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xFDE4E4", Offset = "0xFDE4E4", VA = "0xFDE4E4")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xFDE9F8", Offset = "0xFDE9F8", VA = "0xFDE9F8")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xFDE5E0", Offset = "0xFDE5E0", VA = "0xFDE5E0")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xFDEDC8", Offset = "0xFDEDC8", VA = "0xFDEDC8")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xFDEE10", Offset = "0xFDEE10", VA = "0xFDEE10")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xFDF104", Offset = "0xFDF104", VA = "0xFDF104")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xFDF278", Offset = "0xFDF278", VA = "0xFDF278")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xFDF3E0", Offset = "0xFDF3E0", VA = "0xFDF3E0")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xFDF428", Offset = "0xFDF428", VA = "0xFDF428")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xFDF470", Offset = "0xFDF470", VA = "0xFDF470")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xFDF650", Offset = "0xFDF650", VA = "0xFDF650")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xFDFA84", Offset = "0xFDFA84", VA = "0xFDFA84")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xFDEA18", Offset = "0xFDEA18", VA = "0xFDEA18")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xFDFFAC", Offset = "0xFDFFAC", VA = "0xFDFFAC")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xFDFCD8", Offset = "0xFDFCD8", VA = "0xFDFCD8")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xFDDE4C", Offset = "0xFDDE4C", VA = "0xFDDE4C")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xFE0484", Offset = "0xFE0484", VA = "0xFE0484")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xFE04B8", Offset = "0xFE04B8", VA = "0xFE04B8")]
		[IteratorStateMachine(typeof(<WaitForLoadToUnloadClipAndDeactivate>d__113))]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xFE0548", Offset = "0xFE0548", VA = "0xFE0548")]
		public void FadeToVolume(float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xFE0950", Offset = "0xFE0950", VA = "0xFE0950")]
		public void FadeOutNowAndStop([Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xFE0C04", Offset = "0xFE0C04", VA = "0xFE0C04")]
		public void FadeOutNowAndStop(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xFE0D30", Offset = "0xFE0D30", VA = "0xFE0D30")]
		public void MoveToAmbientColliderPosition(Vector3 newPosition, TransformFollower follower)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xFE0D8C", Offset = "0xFE0D8C", VA = "0xFE0D8C")]
		public void UpdateAudioVariation(TransformFollower transformFollower)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xFE0E24", Offset = "0xFE0E24", VA = "0xFE0E24")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xFE0ECC", Offset = "0xFE0ECC", VA = "0xFE0ECC")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xFE12C8", Offset = "0xFE12C8", VA = "0xFE12C8")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xFE1840", Offset = "0xFE1840", VA = "0xFE1840")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xFDE9F0", Offset = "0xFDE9F0", VA = "0xFDE9F0")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xFE189C", Offset = "0xFE189C", VA = "0xFE189C")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	[AudioScriptOrder(-15)]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000DC")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x400053E")]
			None,
			[Token(Token = "0x400053F")]
			Play,
			[Token(Token = "0x4000540")]
			WaitForEnd,
			[Token(Token = "0x4000541")]
			StopOrRepeat
		}

		[Token(Token = "0x4000507")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000508")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _fadeOutEarlyCompletionCallback;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action _fadeToTargetCompletionCallback;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _glideToTargetPitch;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _framesPlayed;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float? _clipStartPosition;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float? _clipEndPosition;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _timesLooped;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isPaused;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private double _pauseTime;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x17000099")]
		public float ClipStartPosition
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xFE31F8", Offset = "0xFE31F8", VA = "0xFE31F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009A")]
		public float ClipEndPosition
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xFE1F20", Offset = "0xFE1F20", VA = "0xFE1F20")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		public int FramesPlayed
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xFE3FAC", Offset = "0xFE3FAC", VA = "0xFE3FAC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009C")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xFE3FB4", Offset = "0xFE3FB4", VA = "0xFE3FB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xFE400C", Offset = "0xFE400C", VA = "0xFE400C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xFE40B4", Offset = "0xFE40B4", VA = "0xFE40B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009F")]
		private Transform Trans
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xFE2580", Offset = "0xFE2580", VA = "0xFE2580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xFE1E98", Offset = "0xFE1E98", VA = "0xFE1E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xFE2608", Offset = "0xFE2608", VA = "0xFE2608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xFE1E04", Offset = "0xFE1E04", VA = "0xFE1E04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xFE3150", Offset = "0xFE3150", VA = "0xFE3150")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xFE2BA0", Offset = "0xFE2BA0", VA = "0xFE2BA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xFE3F48", Offset = "0xFE3F48", VA = "0xFE3F48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xFDF04C", Offset = "0xFDF04C", VA = "0xFDF04C")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xFE07D0", Offset = "0xFE07D0", VA = "0xFE07D0")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xFE0A74", Offset = "0xFE0A74", VA = "0xFE0A74")]
		public void FadeOutEarly(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xFDFEFC", Offset = "0xFDFEFC", VA = "0xFDFEFC")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xFDEB18", Offset = "0xFDEB18", VA = "0xFDEB18")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xFDED10", Offset = "0xFDED10", VA = "0xFDED10")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xFDFF38", Offset = "0xFDFF38", VA = "0xFDFF38")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xFE0444", Offset = "0xFE0444", VA = "0xFE0444")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xFE0420", Offset = "0xFE0420", VA = "0xFE0420")]
		public void StopFading()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xFDFA5C", Offset = "0xFDFA5C", VA = "0xFDFA5C")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xFE0410", Offset = "0xFE0410", VA = "0xFE0410")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xFE2514", Offset = "0xFE2514", VA = "0xFE2514")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xFE206C", Offset = "0xFE206C", VA = "0xFE206C")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xFE29C0", Offset = "0xFE29C0", VA = "0xFE29C0")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xFE2A5C", Offset = "0xFE2A5C", VA = "0xFE2A5C")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xFE2C20", Offset = "0xFE2C20", VA = "0xFE2C20")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xFE2C8C", Offset = "0xFE2C8C", VA = "0xFE2C8C")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xFE21D4", Offset = "0xFE21D4", VA = "0xFE21D4")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xFE334C", Offset = "0xFE334C", VA = "0xFE334C")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xFE349C", Offset = "0xFE349C", VA = "0xFE349C")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xFDF374", Offset = "0xFDF374", VA = "0xFDF374")]
		public void Pause()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xFDF548", Offset = "0xFDF548", VA = "0xFDF548")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xFDF6FC", Offset = "0xFDF6FC", VA = "0xFDF6FC")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xFE3534", Offset = "0xFE3534", VA = "0xFE3534")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xFE35E4", Offset = "0xFE35E4", VA = "0xFE35E4")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xFE3A14", Offset = "0xFE3A14", VA = "0xFE3A14")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xFE3A90", Offset = "0xFE3A90", VA = "0xFE3A90")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xFDDA90", Offset = "0xFDDA90", VA = "0xFDDA90")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xFE3B50", Offset = "0xFE3B50", VA = "0xFE3B50")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xFE415C", Offset = "0xFE415C", VA = "0xFE415C")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xFE41D4", Offset = "0xFE41D4", VA = "0xFE41D4")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xFE449C", Offset = "0xFE449C", VA = "0xFE449C")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0xFE4668", Offset = "0xFE4668", VA = "0xFE4668")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000DE")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000543")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000544")]
		private const int HighestPriority = 16;

		[Token(Token = "0x4000545")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xFDDCD4", Offset = "0xFDDCD4", VA = "0xFDDCD4")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xFDDCEC", Offset = "0xFDDCEC", VA = "0xFDDCEC")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0xFE4858", Offset = "0xFE4858", VA = "0xFE4858")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0xFE2690", Offset = "0xFE2690", VA = "0xFE2690")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x20000E0")]
		[CompilerGenerated]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x170000A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005F7")]
				[Address(RVA = "0xFE5DA0", Offset = "0xFE5DA0", VA = "0xFE5DA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005F9")]
				[Address(RVA = "0xFE5DE8", Offset = "0xFE5DE8", VA = "0xFE5DE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xFE52C0", Offset = "0xFE52C0", VA = "0xFE52C0")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xFE58A4", Offset = "0xFE58A4", VA = "0xFE58A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0xFE58A8", Offset = "0xFE58A8", VA = "0xFE58A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xFE5DA8", Offset = "0xFE5DA8", VA = "0xFE5DA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private bool <isWarmingCall>5__2;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__3;

			[Token(Token = "0x170000A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005FD")]
				[Address(RVA = "0xFE63E0", Offset = "0xFE63E0", VA = "0xFE63E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005FF")]
				[Address(RVA = "0xFE6428", Offset = "0xFE6428", VA = "0xFE6428", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0xFE52E8", Offset = "0xFE52E8", VA = "0xFE52E8")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xFE5DF0", Offset = "0xFE5DF0", VA = "0xFE5DF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0xFE5DF4", Offset = "0xFE5DF4", VA = "0xFE5DF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0xFE63E8", Offset = "0xFE63E8", VA = "0xFE63E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0xFE4870", Offset = "0xFE4870", VA = "0xFE4870")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0xFE4914", Offset = "0xFE4914", VA = "0xFE4914")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0xFE1738", Offset = "0xFE1738", VA = "0xFE1738")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0xFE4CC4", Offset = "0xFE4CC4", VA = "0xFE4CC4")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0xFE4A64", Offset = "0xFE4A64", VA = "0xFE4A64")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xFE4FDC", Offset = "0xFE4FDC", VA = "0xFE4FDC")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xFE5054", Offset = "0xFE5054", VA = "0xFE5054")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xFE5230", Offset = "0xFE5230", VA = "0xFE5230")]
		[IteratorStateMachine(typeof(<PopulateResourceSongToPlaylistControllerAsync>d__11))]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xFDE968", Offset = "0xFDE968", VA = "0xFDE968")]
		[IteratorStateMachine(typeof(<PopulateSourcesWithResourceClipAsync>d__12))]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xFE5310", Offset = "0xFE5310", VA = "0xFE5310")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xFE5498", Offset = "0xFE5498", VA = "0xFE5498")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xFE00C8", Offset = "0xFE00C8", VA = "0xFE00C8")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x20000E2")]
	[AudioScriptOrder(-50)]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		public enum JukeBoxDisplayMode
		{
			[Token(Token = "0x400062A")]
			DisplayAll,
			[Token(Token = "0x400062B")]
			DisplayActive
		}

		[Token(Token = "0x20000E4")]
		public enum BusVoiceLimitExceededMode
		{
			[Token(Token = "0x400062D")]
			DoNotPlayNewSound,
			[Token(Token = "0x400062E")]
			StopOldestSound,
			[Token(Token = "0x400062F")]
			StopFarthestSound,
			[Token(Token = "0x4000630")]
			StopLeastImportantSound
		}

		[Token(Token = "0x20000E5")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x4000632")]
			StopSound,
			[Token(Token = "0x4000633")]
			FadeSound
		}

		[Token(Token = "0x20000E6")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x4000635")]
			StopExistingSound,
			[Token(Token = "0x4000636")]
			FadeInSameSound
		}

		[Token(Token = "0x20000E7")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000638")]
			LateUpdate,
			[Token(Token = "0x4000639")]
			FixedUpdate
		}

		[Token(Token = "0x20000E8")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x400063B")]
			All,
			[Token(Token = "0x400063C")]
			OneAtRandom
		}

		[Token(Token = "0x20000E9")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400063E")]
			AllGroups,
			[Token(Token = "0x400063F")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000EA")]
		public enum RaycastMode
		{
			[Token(Token = "0x4000641")]
			Physics3D,
			[Token(Token = "0x4000642")]
			Physics2D
		}

		[Token(Token = "0x20000EB")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000644")]
			ForceAllTo2D,
			[Token(Token = "0x4000645")]
			ForceAllTo3D,
			[Token(Token = "0x4000646")]
			ForceAllToCustom,
			[Token(Token = "0x4000647")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000EC")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000649")]
			ForceAllTo2D,
			[Token(Token = "0x400064A")]
			ForceAllTo3D,
			[Token(Token = "0x400064B")]
			ForceAllToCustom,
			[Token(Token = "0x400064C")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000ED")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400064E")]
			ForceTo2D,
			[Token(Token = "0x400064F")]
			ForceTo3D,
			[Token(Token = "0x4000650")]
			ForceToCustom,
			[Token(Token = "0x4000651")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000EE")]
		public enum GroupPlayType
		{
			[Token(Token = "0x4000653")]
			Always,
			[Token(Token = "0x4000654")]
			WhenActorInAudibleRange,
			[Token(Token = "0x4000655")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000EF")]
		public enum DefaultGroupPlayType
		{
			[Token(Token = "0x4000657")]
			Always,
			[Token(Token = "0x4000658")]
			WhenActorInAudibleRange
		}

		[Token(Token = "0x20000F0")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x400065A")]
			Narrow,
			[Token(Token = "0x400065B")]
			Normal,
			[Token(Token = "0x400065C")]
			Wide
		}

		[Token(Token = "0x20000F1")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x400065E")]
			Always,
			[Token(Token = "0x400065F")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000660")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000661")]
			Never,
			[Token(Token = "0x4000662")]
			OnSameGameObject,
			[Token(Token = "0x4000663")]
			OnChildGameObject,
			[Token(Token = "0x4000664")]
			OnParentGameObject,
			[Token(Token = "0x4000665")]
			OnSameOrChildGameObject,
			[Token(Token = "0x4000666")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x20000F2")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x4000668")]
			All,
			[Token(Token = "0x4000669")]
			Closest,
			[Token(Token = "0x400066A")]
			Random
		}

		[Token(Token = "0x20000F3")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x400066C")]
			None,
			[Token(Token = "0x400066D")]
			Loading,
			[Token(Token = "0x400066E")]
			Loaded,
			[Token(Token = "0x400066F")]
			LoadFailed
		}

		[Token(Token = "0x20000F4")]
		public enum AudioLocation
		{
			[Token(Token = "0x4000671")]
			Clip,
			[Token(Token = "0x4000672")]
			ResourceFile
		}

		[Token(Token = "0x20000F5")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x4000674")]
			Beginning,
			[Token(Token = "0x4000675")]
			SpecificTime,
			[Token(Token = "0x4000676")]
			RandomTime,
			[Token(Token = "0x4000677")]
			Section
		}

		[Token(Token = "0x20000F6")]
		public enum BusCommand
		{
			[Token(Token = "0x4000679")]
			None,
			[Token(Token = "0x400067A")]
			FadeToVolume,
			[Token(Token = "0x400067B")]
			Mute,
			[Token(Token = "0x400067C")]
			Pause,
			[Token(Token = "0x400067D")]
			Solo,
			[Token(Token = "0x400067E")]
			Unmute,
			[Token(Token = "0x400067F")]
			Unpause,
			[Token(Token = "0x4000680")]
			Unsolo,
			[Token(Token = "0x4000681")]
			Stop,
			[Token(Token = "0x4000682")]
			ChangePitch,
			[Token(Token = "0x4000683")]
			ToggleMute,
			[Token(Token = "0x4000684")]
			StopBusOfTransform,
			[Token(Token = "0x4000685")]
			PauseBusOfTransform,
			[Token(Token = "0x4000686")]
			UnpauseBusOfTransform,
			[Token(Token = "0x4000687")]
			GlideByPitch,
			[Token(Token = "0x4000688")]
			StopOldBusVoices,
			[Token(Token = "0x4000689")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x20000F7")]
		public enum DragGroupMode
		{
			[Token(Token = "0x400068B")]
			OneGroupPerClip,
			[Token(Token = "0x400068C")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000F8")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x400068E")]
			PlaySound,
			[Token(Token = "0x400068F")]
			GroupControl,
			[Token(Token = "0x4000690")]
			BusControl,
			[Token(Token = "0x4000691")]
			PlaylistControl,
			[Token(Token = "0x4000692")]
			CustomEventControl,
			[Token(Token = "0x4000693")]
			GlobalControl,
			[Token(Token = "0x4000694")]
			UnityMixerControl,
			[Token(Token = "0x4000695")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000F9")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000697")]
			UseDeviceSetting,
			[Token(Token = "0x4000698")]
			SpecificLanguage,
			[Token(Token = "0x4000699")]
			DynamicallySet
		}

		[Token(Token = "0x20000FA")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400069B")]
			None,
			[Token(Token = "0x400069C")]
			TransitionToSnapshot,
			[Token(Token = "0x400069D")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000FB")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x400069F")]
			None,
			[Token(Token = "0x40006A0")]
			ChangePlaylist,
			[Token(Token = "0x40006A1")]
			FadeToVolume,
			[Token(Token = "0x40006A2")]
			PlaySong,
			[Token(Token = "0x40006A3")]
			PlayRandomSong,
			[Token(Token = "0x40006A4")]
			PlayNextSong,
			[Token(Token = "0x40006A5")]
			Pause,
			[Token(Token = "0x40006A6")]
			Resume,
			[Token(Token = "0x40006A7")]
			Stop,
			[Token(Token = "0x40006A8")]
			Mute,
			[Token(Token = "0x40006A9")]
			Unmute,
			[Token(Token = "0x40006AA")]
			ToggleMute,
			[Token(Token = "0x40006AB")]
			Restart,
			[Token(Token = "0x40006AC")]
			Start,
			[Token(Token = "0x40006AD")]
			StopLoopingCurrentSong,
			[Token(Token = "0x40006AE")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x40006AF")]
			AddSongToQueue
		}

		[Token(Token = "0x20000FC")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40006B1")]
			None,
			[Token(Token = "0x40006B2")]
			FireEvent
		}

		[Token(Token = "0x20000FD")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40006B4")]
			None,
			[Token(Token = "0x40006B5")]
			PauseMixer,
			[Token(Token = "0x40006B6")]
			UnpauseMixer,
			[Token(Token = "0x40006B7")]
			StopMixer,
			[Token(Token = "0x40006B8")]
			StopEverything,
			[Token(Token = "0x40006B9")]
			PauseEverything,
			[Token(Token = "0x40006BA")]
			UnpauseEverything,
			[Token(Token = "0x40006BB")]
			MuteEverything,
			[Token(Token = "0x40006BC")]
			UnmuteEverything,
			[Token(Token = "0x40006BD")]
			SetMasterMixerVolume,
			[Token(Token = "0x40006BE")]
			SetMasterPlaylistVolume,
			[Token(Token = "0x40006BF")]
			PauseAudioListener,
			[Token(Token = "0x40006C0")]
			UnpauseAudioListener
		}

		[Token(Token = "0x20000FE")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40006C2")]
			None,
			[Token(Token = "0x40006C3")]
			FadeToVolume,
			[Token(Token = "0x40006C4")]
			FadeOutAllOfSound,
			[Token(Token = "0x40006C5")]
			Mute,
			[Token(Token = "0x40006C6")]
			Pause,
			[Token(Token = "0x40006C7")]
			Solo,
			[Token(Token = "0x40006C8")]
			StopAllOfSound,
			[Token(Token = "0x40006C9")]
			Unmute,
			[Token(Token = "0x40006CA")]
			Unpause,
			[Token(Token = "0x40006CB")]
			Unsolo,
			[Token(Token = "0x40006CC")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40006CD")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40006CE")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40006CF")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40006D0")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40006D1")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40006D2")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40006D3")]
			RefillSoundGroupPool,
			[Token(Token = "0x40006D4")]
			RouteToBus,
			[Token(Token = "0x40006D5")]
			GlideByPitch,
			[Token(Token = "0x40006D6")]
			ToggleSoundGroup,
			[Token(Token = "0x40006D7")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x40006D8")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x40006D9")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x40006DA")]
			FadeOutOldSoundGroupVoices,
			[Token(Token = "0x40006DB")]
			FadeSoundGroupOfTransformToVolume
		}

		[Token(Token = "0x20000FF")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x40006DD")]
			None,
			[Token(Token = "0x40006DE")]
			SetBusVolume,
			[Token(Token = "0x40006DF")]
			SetGroupVolume,
			[Token(Token = "0x40006E0")]
			SetMixerVolume,
			[Token(Token = "0x40006E1")]
			SetMusicVolume,
			[Token(Token = "0x40006E2")]
			MixerMuteToggle,
			[Token(Token = "0x40006E3")]
			MusicMuteToggle
		}

		[Token(Token = "0x2000100")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x40006E5")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x40006E6")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x40006E7")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x2000101")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x40006E9")]
			MasterAudioLocation,
			[Token(Token = "0x40006EA")]
			CallerLocation,
			[Token(Token = "0x40006EB")]
			AttachToCaller
		}

		[Token(Token = "0x2000102")]
		public enum VariationCommand
		{
			[Token(Token = "0x40006ED")]
			None,
			[Token(Token = "0x40006EE")]
			Stop,
			[Token(Token = "0x40006EF")]
			Pause,
			[Token(Token = "0x40006F0")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x2000103")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x6000744")]
			[Address(RVA = "0xFE6430", Offset = "0xFE6430", VA = "0xFE6430")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000104")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0xFE6440", Offset = "0xFE6440", VA = "0xFE6440")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000105")]
		public class AudioInfo
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xFE6480", Offset = "0xFE6480", VA = "0xFE6480")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public class Playlist
		{
			[Token(Token = "0x2000107")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x4000712")]
				UseMasterSetting,
				[Token(Token = "0x4000713")]
				Override
			}

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly List<int> _actorInstanceIds;

			[Token(Token = "0x170000CF")]
			public bool HasLiveActors
			{
				[Token(Token = "0x600074A")]
				[Address(RVA = "0xFE6758", Offset = "0xFE6758", VA = "0xFE6758")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xFE64CC", Offset = "0xFE64CC", VA = "0xFE64CC")]
			public Playlist()
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xFE662C", Offset = "0xFE662C", VA = "0xFE662C")]
			public void AddActorInstanceId(int instanceId)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xFE6700", Offset = "0xFE6700", VA = "0xFE6700")]
			public void RemoveActorInstanceId(int instanceId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000108")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0xFE67A8", Offset = "0xFE67A8", VA = "0xFE67A8")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass274_0
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xFE68AC", Offset = "0xFE68AC", VA = "0xFE68AC")]
			public <>c__DisplayClass274_0()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0xFE68B4", Offset = "0xFE68B4", VA = "0xFE68B4")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[CompilerGenerated]
		private sealed class <PlaySoundAndWaitUntilFinished>d__274 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass274_0 <>8__1;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000757")]
				[Address(RVA = "0xFE6B80", Offset = "0xFE6B80", VA = "0xFE6B80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0xFE6BC8", Offset = "0xFE6BC8", VA = "0xFE6BC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xFE68C0", Offset = "0xFE68C0", VA = "0xFE68C0")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__274(int <>1__state)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0xFE68E8", Offset = "0xFE68E8", VA = "0xFE68E8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0xFE68EC", Offset = "0xFE68EC", VA = "0xFE68EC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xFE6B88", Offset = "0xFE6B88", VA = "0xFE6B88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass275_0
		{
			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xFE6BD0", Offset = "0xFE6BD0", VA = "0xFE6BD0")]
			public <>c__DisplayClass275_0()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0xFE6BD8", Offset = "0xFE6BD8", VA = "0xFE6BD8")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[CompilerGenerated]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__275 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass275_0 <>8__1;

			[Token(Token = "0x4000730")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000D2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0xFE6EC8", Offset = "0xFE6EC8", VA = "0xFE6EC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0xFE6F10", Offset = "0xFE6F10", VA = "0xFE6F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0xFE6BE4", Offset = "0xFE6BE4", VA = "0xFE6BE4")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0xFE6C0C", Offset = "0xFE6C0C", VA = "0xFE6C0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0xFE6C10", Offset = "0xFE6C10", VA = "0xFE6C10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xFE6ED0", Offset = "0xFE6ED0", VA = "0xFE6ED0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010E")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass276_0
		{
			[Token(Token = "0x4000731")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xFE6F18", Offset = "0xFE6F18", VA = "0xFE6F18")]
			public <>c__DisplayClass276_0()
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xFE6F20", Offset = "0xFE6F20", VA = "0xFE6F20")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200010F")]
		[CompilerGenerated]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__276 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000732")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000736")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass276_0 <>8__1;

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0xFE7210", Offset = "0xFE7210", VA = "0xFE7210", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000769")]
				[Address(RVA = "0xFE7258", Offset = "0xFE7258", VA = "0xFE7258", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xFE6F2C", Offset = "0xFE6F2C", VA = "0xFE6F2C")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__276(int <>1__state)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0xFE6F54", Offset = "0xFE6F54", VA = "0xFE6F54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xFE6F58", Offset = "0xFE6F58", VA = "0xFE6F58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xFE7218", Offset = "0xFE7218", VA = "0xFE7218", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400055A")]
		public const string VideoPlayersSoundGroupSelectedError = "Can't use specially named Sound Group for Video Players. Please select another.";

		[Token(Token = "0x400055B")]
		public const string VideoPlayerSoundGroupName = "_VideoPlayers";

		[Token(Token = "0x400055C")]
		public const string VideoPlayerBusName = "_VideoPlayers";

		[Token(Token = "0x400055D")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x400055E")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x400055F")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000560")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000561")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000562")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000563")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000564")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000565")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000566")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000567")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x4000568")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x4000569")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x400056A")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static List<string> ImportanceChoices;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000570")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x4000571")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x4000572")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x4000573")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000574")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x4000575")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x4000576")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x4000577")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000578")]
		private const int MaxComponents = 20;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool showGroupImportance;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool areGroupsExpanded;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool showVideoPlayerSettings;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool useTextPlaylistFilter;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string textPlaylistFilter;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool playListExpanded;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool playlistsExpanded;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float musicSpatialBlend;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public GroupPlayType groupPlayType;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public DefaultGroupPlayType defaultGroupPlayType;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float _masterAudioVolume;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useSpatializer;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool addOculusAudioSources;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x113")]
		public bool useGaplessAutoReschedule;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool useOcclusion;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool deletePreviewerAudioSourceWhenPlaying;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool showFadingSettings;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		public bool useClipAgePriority;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166")]
		public bool logOutOfVoices;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167")]
		public bool LogSounds;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool logCustomEvents;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool disableLogging;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		public bool showMusicDucking;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		public bool enableMusicDucking;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public float defaultUnduckTime;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public float crossFadeTime;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public bool showGroupSelect;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public JukeBoxDisplayMode jukeBoxDisplayMode;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public bool logPerfExpanded;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x195")]
		public bool willWarm;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x196")]
		public bool mixerSettingsExpanded;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioMixerUpdateMode mixerUpdateMode;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string newEventName;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool showCustomEvents;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int frames;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Dictionary<string, List<int>> _nonRandomChoices;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<ICustomEventReceiver> ValidReceivers;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<CustomEventCandidate> ValidReceiverCandidates;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private readonly List<string> AllSoundGroupNames;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private readonly List<string> AllBusNames;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private readonly List<AudioInfo> GroupsToDelete;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private readonly List<PlaylistController> ControllersToPause;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private readonly List<PlaylistController> ControllersToUnpause;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private readonly List<PlaylistController> ControllersToMute;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private readonly List<PlaylistController> ControllersToUnmute;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private readonly List<PlaylistController> ControllersToToggleMute;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private readonly List<PlaylistController> ControllersToStop;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private readonly List<PlaylistController> ControllersToFade;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private readonly List<PlaylistController> ControllersToTrigNext;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private readonly List<PlaylistController> ControllersToTrigRandom;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private readonly List<PlaylistController> ControllersToStart;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToTriggerNow;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		private float _repriTime;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private Transform _trans;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x359")]
		private bool _warming;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Transform _listenerTrans;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x170000AA")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0xFCECA0", Offset = "0xFCECA0", VA = "0xFCECA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xFCECFC", Offset = "0xFCECFC", VA = "0xFCECFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0xFD0DB8", Offset = "0xFD0DB8", VA = "0xFD0DB8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xFD0E14", Offset = "0xFD0E14", VA = "0xFD0E14")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0xFB8880", Offset = "0xFB8880", VA = "0xFB8880")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xFD0E78", Offset = "0xFD0E78", VA = "0xFD0E78")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public static Transform VideoPlayerSoundGroupTransform
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xFD25E8", Offset = "0xFD25E8", VA = "0xFD25E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0xFD2668", Offset = "0xFD2668", VA = "0xFD2668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0xFB16A0", Offset = "0xFB16A0", VA = "0xFB16A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0xFD27A8", Offset = "0xFD27A8", VA = "0xFD27A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0xFB8258", Offset = "0xFB8258", VA = "0xFB8258")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0xFD2858", Offset = "0xFD2858", VA = "0xFD2858")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000718")]
			[Address(RVA = "0xFC7050", Offset = "0xFC7050", VA = "0xFC7050")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0xFD28B4", Offset = "0xFD28B4", VA = "0xFD28B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071A")]
			[Address(RVA = "0xFCAEB0", Offset = "0xFCAEB0", VA = "0xFCAEB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0xFD2910", Offset = "0xFD2910", VA = "0xFD2910")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0xFD2918", Offset = "0xFD2918", VA = "0xFD2918")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0xFD2924", Offset = "0xFD2924", VA = "0xFD2924")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B6")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0xFCA88C", Offset = "0xFCA88C", VA = "0xFCA88C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0xFC155C", Offset = "0xFC155C", VA = "0xFC155C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0xFBE4E8", Offset = "0xFBE4E8", VA = "0xFBE4E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0xFD292C", Offset = "0xFD292C", VA = "0xFD292C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0xFC3A28", Offset = "0xFC3A28", VA = "0xFC3A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0xFB4F34", Offset = "0xFB4F34", VA = "0xFB4F34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0xFD2AFC", Offset = "0xFD2AFC", VA = "0xFD2AFC")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0xFB64B0", Offset = "0xFB64B0", VA = "0xFB64B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0xFD2B54", Offset = "0xFD2B54", VA = "0xFD2B54")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000727")]
			[Address(RVA = "0xFD2BAC", Offset = "0xFD2BAC", VA = "0xFD2BAC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public List<string> GroupNames
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0xFD2C08", Offset = "0xFD2C08", VA = "0xFD2C08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0xFD3014", Offset = "0xFD3014", VA = "0xFD3014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public List<string> BusNames
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0xFD316C", Offset = "0xFD316C", VA = "0xFD316C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0xFD337C", Offset = "0xFD337C", VA = "0xFD337C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0xFD358C", Offset = "0xFD358C", VA = "0xFD358C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public Transform Trans
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0xFB1860", Offset = "0xFB1860", VA = "0xFB1860")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0xFD36D8", Offset = "0xFD36D8", VA = "0xFD36D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0xFD36E0", Offset = "0xFD36E0", VA = "0xFD36E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0xFD3970", Offset = "0xFD3970", VA = "0xFD3970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0xFD3818", Offset = "0xFD3818", VA = "0xFD3818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0xFD3AF0", Offset = "0xFD3AF0", VA = "0xFD3AF0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0xFD3B4C", Offset = "0xFD3B4C", VA = "0xFD3B4C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xFB6428", Offset = "0xFB6428", VA = "0xFB6428")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0xFD3C90", Offset = "0xFD3C90", VA = "0xFD3C90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xFD3CEC", Offset = "0xFD3CEC", VA = "0xFD3CEC")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xFD3E6C", Offset = "0xFD3E6C", VA = "0xFD3E6C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0xFD3F2C", Offset = "0xFD3F2C", VA = "0xFD3F2C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CD")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0xFD4048", Offset = "0xFD4048", VA = "0xFD4048")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xFD4108", Offset = "0xFD4108", VA = "0xFD4108")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0xFD4160", Offset = "0xFD4160", VA = "0xFD4160")]
			set
			{
			}
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xFAF530", Offset = "0xFAF530", VA = "0xFAF530")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xFB307C", Offset = "0xFB307C", VA = "0xFB307C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xFB3228", Offset = "0xFB3228", VA = "0xFB3228")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xFB32C0", Offset = "0xFB32C0", VA = "0xFB32C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xFB3570", Offset = "0xFB3570", VA = "0xFB3570")]
		private void Update()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xFB4810", Offset = "0xFB4810", VA = "0xFB4810")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xFB48A4", Offset = "0xFB48A4", VA = "0xFB48A4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xFB4820", Offset = "0xFB4820", VA = "0xFB4820")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xFB1C38", Offset = "0xFB1C38", VA = "0xFB1C38")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xFB4E20", Offset = "0xFB4E20", VA = "0xFB4E20")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xFB5138", Offset = "0xFB5138", VA = "0xFB5138")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xFB4C24", Offset = "0xFB4C24", VA = "0xFB4C24")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xFB51B8", Offset = "0xFB51B8", VA = "0xFB51B8")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xFB48B8", Offset = "0xFB48B8", VA = "0xFB48B8")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xFB4744", Offset = "0xFB4744", VA = "0xFB4744")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xFB4404", Offset = "0xFB4404", VA = "0xFB4404")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xFB35F8", Offset = "0xFB35F8", VA = "0xFB35F8")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xFB37FC", Offset = "0xFB37FC", VA = "0xFB37FC")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xFB3B44", Offset = "0xFB3B44", VA = "0xFB3B44")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xFB3FC0", Offset = "0xFB3FC0", VA = "0xFB3FC0")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xFB3DD0", Offset = "0xFB3DD0", VA = "0xFB3DD0")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xFB3A30", Offset = "0xFB3A30", VA = "0xFB3A30")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xFB61C0", Offset = "0xFB61C0", VA = "0xFB61C0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0xFB624C", Offset = "0xFB624C", VA = "0xFB624C")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xFB710C", Offset = "0xFB710C", VA = "0xFB710C")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xFB7304", Offset = "0xFB7304", VA = "0xFB7304")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xFB74A4", Offset = "0xFB74A4", VA = "0xFB74A4")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xFB7658", Offset = "0xFB7658", VA = "0xFB7658")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xFB7838", Offset = "0xFB7838", VA = "0xFB7838")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xFB7A3C", Offset = "0xFB7A3C", VA = "0xFB7A3C")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xFB1DE4", Offset = "0xFB1DE4", VA = "0xFB1DE4")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xFB7C1C", Offset = "0xFB7C1C", VA = "0xFB7C1C")]
		[IteratorStateMachine(typeof(<PlaySoundAndWaitUntilFinished>d__274))]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xFB7CC4", Offset = "0xFB7CC4", VA = "0xFB7CC4")]
		[IteratorStateMachine(typeof(<PlaySound3DAtTransformAndWaitUntilFinished>d__275))]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xFB7D84", Offset = "0xFB7D84", VA = "0xFB7D84")]
		[IteratorStateMachine(typeof(<PlaySound3DFollowTransformAndWaitUntilFinished>d__276))]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xFB70E8", Offset = "0xFB70E8", VA = "0xFB70E8")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xFB6570", Offset = "0xFB6570", VA = "0xFB6570")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xFBA1C4", Offset = "0xFBA1C4", VA = "0xFBA1C4")]
		private static PlaySoundResult TryPlayVariationOrOtherMatches(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch, Transform sourceTrans, bool attachToSource, float delaySoundTime, bool useVector3, bool makePlaySoundResult, bool isChaining, bool isSingleSubscribedPlay, AudioInfo randomSource, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, bool forgetSoundPlayedOrScheduled, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop, List<int> otherChoices, bool hasRefilledPool, List<AudioInfo> sources, out bool soundSuccess)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xFB9E10", Offset = "0xFB9E10", VA = "0xFB9E10")]
		private static bool CanPlayDialogBasedOnImportanceOrIsNotDialog(string sType, AudioGroupInfo group, bool loggingEnabledForGrp, AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xFB8E5C", Offset = "0xFB8E5C", VA = "0xFB8E5C")]
		private static AudioInfo UseOnlyVariationIfOnlyOne(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp, AudioInfo randomSource, MasterAudioGroup maGroup, ref bool isSingleVarLoop)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xFB9B2C", Offset = "0xFB9B2C", VA = "0xFB9B2C")]
		private static bool IsActorTooFarAwayToPlay(string sType, Transform sourceTrans, AudioGroupInfo group, AudioInfo randomSource, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xFB99C8", Offset = "0xFB99C8", VA = "0xFB99C8")]
		private static bool VariationPassesProbabilityToPlayCheck(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xFB97F8", Offset = "0xFB97F8", VA = "0xFB97F8")]
		private static bool IsNoClipSilentPlay(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xFB9690", Offset = "0xFB9690", VA = "0xFB9690")]
		private static bool VariationIsUsable(AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xFB8F74", Offset = "0xFB8F74", VA = "0xFB8F74")]
		private static bool CanFindVariationToPlay(string sType, string variationName, bool isNonSpecific, bool canUseBusVoiceToStop, List<AudioInfo> sources, bool loggingEnabledForGrp, SoundGroupVariation busVoiceToStop, ref AudioInfo randomSource, ref List<int> choices, ref int? randomIndex, ref int pickedChoice, ref List<int> otherChoices)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xFB8B04", Offset = "0xFB8B04", VA = "0xFB8B04")]
		private static SoundGroupVariation FindBusVoiceToStop(GroupBus groupBus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xFB8A08", Offset = "0xFB8A08", VA = "0xFB8A08")]
		private static bool CanStopLimitedBusVoice(GroupBus groupBus, bool loggingEnabledForGrp, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xFB89E0", Offset = "0xFB89E0", VA = "0xFB89E0")]
		private static bool IsBusVoiceLimited(GroupBus groupBus)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xFB86B4", Offset = "0xFB86B4", VA = "0xFB86B4")]
		private static AudioInfo FindRetriggerableVariationInGroup(string variationName, bool isNonSpecific, List<AudioInfo> sources, MasterAudioGroup maGroup)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xFB865C", Offset = "0xFB865C", VA = "0xFB865C")]
		private static bool IsGroupPolyphonyLimited(MasterAudioGroup maGroup, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xFB84F4", Offset = "0xFB84F4", VA = "0xFB84F4")]
		private static bool IsReplayLimited(string sType, MasterAudioGroup maGroup, AudioGroupInfo group, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xFB8318", Offset = "0xFB8318", VA = "0xFB8318")]
		private static void LogIfSilentPlay(string sType, bool loggingEnabledForGrp, MasterAudioGroup maGroup)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xFB8180", Offset = "0xFB8180", VA = "0xFB8180")]
		private static bool SoundGroupHasVariations(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xFB7E44", Offset = "0xFB7E44", VA = "0xFB7E44")]
		private static bool IsSoundGroupValidAndReady(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xFBB350", Offset = "0xFBB350", VA = "0xFBB350")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xFBA718", Offset = "0xFBA718", VA = "0xFBA718")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xFBAE50", Offset = "0xFBAE50", VA = "0xFBAE50")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xFBA748", Offset = "0xFBA748", VA = "0xFBA748")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xFBBD70", Offset = "0xFBBD70", VA = "0xFBBD70")]
		private static void FadeOldestOrFarthestBusVoice(SoundGroupVariation busVoiceToStop, GroupBus groupBus)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xFBBE3C", Offset = "0xFBBE3C", VA = "0xFBBE3C")]
		public static void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xFBBEE4", Offset = "0xFBBEE4", VA = "0xFBBEE4")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource, SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xFBC0BC", Offset = "0xFBC0BC", VA = "0xFBC0BC")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xFBC4F8", Offset = "0xFBC4F8", VA = "0xFBC4F8")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xFBC7A0", Offset = "0xFBC7A0", VA = "0xFBC7A0")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xFBC964", Offset = "0xFBC964", VA = "0xFBC964")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xFBCBA0", Offset = "0xFBCBA0", VA = "0xFBCBA0")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xFBCD64", Offset = "0xFBCD64", VA = "0xFBCD64")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xFBCFA0", Offset = "0xFBCFA0", VA = "0xFBCFA0")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xFBD164", Offset = "0xFBD164", VA = "0xFBD164")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xFBD6E4", Offset = "0xFBD6E4", VA = "0xFBD6E4")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xFBD928", Offset = "0xFBD928", VA = "0xFBD928")]
		public static void FadeSoundGroupOfTransformToVolume(Transform sourceTrans, string sType, float fadeTime, float targetVolume)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xFB5CC4", Offset = "0xFB5CC4", VA = "0xFB5CC4")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xFBB0B4", Offset = "0xFBB0B4", VA = "0xFBB0B4")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xFBDB3C", Offset = "0xFBDB3C", VA = "0xFBDB3C")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xFBD358", Offset = "0xFBD358", VA = "0xFBD358")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xFBDE6C", Offset = "0xFBDE6C", VA = "0xFBDE6C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xFBE278", Offset = "0xFBE278", VA = "0xFBE278")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xFBE544", Offset = "0xFBE544", VA = "0xFBE544")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xFBF29C", Offset = "0xFBF29C", VA = "0xFBF29C")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xFBFAB8", Offset = "0xFBFAB8", VA = "0xFBFAB8")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xFBFE28", Offset = "0xFBFE28", VA = "0xFBFE28")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xFC0134", Offset = "0xFC0134", VA = "0xFC0134")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xFC02FC", Offset = "0xFC02FC", VA = "0xFC02FC")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xFC0588", Offset = "0xFC0588", VA = "0xFC0588")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xFC094C", Offset = "0xFC094C", VA = "0xFC094C")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xFC0C50", Offset = "0xFC0C50", VA = "0xFC0C50")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xFC0D60", Offset = "0xFC0D60", VA = "0xFC0D60")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xFC0F48", Offset = "0xFC0F48", VA = "0xFC0F48")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xFC1A7C", Offset = "0xFC1A7C", VA = "0xFC1A7C")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xFB5324", Offset = "0xFB5324", VA = "0xFB5324")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xFC21FC", Offset = "0xFC21FC", VA = "0xFC21FC")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xFC2290", Offset = "0xFC2290", VA = "0xFC2290")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xFC241C", Offset = "0xFC241C", VA = "0xFC241C")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xFC256C", Offset = "0xFC256C", VA = "0xFC256C")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xFC26E4", Offset = "0xFC26E4", VA = "0xFC26E4")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xFC2870", Offset = "0xFC2870", VA = "0xFC2870")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xFC2CB4", Offset = "0xFC2CB4", VA = "0xFC2CB4")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xFC2E74", Offset = "0xFC2E74", VA = "0xFC2E74")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xFC3014", Offset = "0xFC3014", VA = "0xFC3014")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xFC365C", Offset = "0xFC365C", VA = "0xFC365C")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xFC3E80", Offset = "0xFC3E80", VA = "0xFC3E80")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, int? creatorInstanceId, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xFC50C4", Offset = "0xFC50C4", VA = "0xFC50C4")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xFB5A20", Offset = "0xFB5A20", VA = "0xFB5A20")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xFB2F54", Offset = "0xFB2F54", VA = "0xFB2F54")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xFC5284", Offset = "0xFC5284", VA = "0xFC5284")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xFB18F4", Offset = "0xFB18F4", VA = "0xFB18F4")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xFC5528", Offset = "0xFC5528", VA = "0xFC5528")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xFC5370", Offset = "0xFC5370", VA = "0xFC5370")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xFB3360", Offset = "0xFB3360", VA = "0xFB3360")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xFC3BCC", Offset = "0xFC3BCC", VA = "0xFC3BCC")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xFC55BC", Offset = "0xFC55BC", VA = "0xFC55BC")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xFC5170", Offset = "0xFC5170", VA = "0xFC5170")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xFC1648", Offset = "0xFC1648", VA = "0xFC1648")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xFC19E8", Offset = "0xFC19E8", VA = "0xFC19E8")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xFC5954", Offset = "0xFC5954", VA = "0xFC5954")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xFC5A84", Offset = "0xFC5A84", VA = "0xFC5A84")]
		private static void UnsilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xFC581C", Offset = "0xFC581C", VA = "0xFC581C")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xFC5B20", Offset = "0xFC5B20", VA = "0xFC5B20")]
		private static void SilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xFC5BBC", Offset = "0xFC5BBC", VA = "0xFC5BBC")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xFBC294", Offset = "0xFBC294", VA = "0xFBC294")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xFC5CD4", Offset = "0xFC5CD4", VA = "0xFC5CD4")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xFC5DC0", Offset = "0xFC5DC0", VA = "0xFC5DC0")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xFC5F94", Offset = "0xFC5F94", VA = "0xFC5F94")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xFC60F0", Offset = "0xFC60F0", VA = "0xFC60F0")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xFC61C4", Offset = "0xFC61C4", VA = "0xFC61C4")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xFC632C", Offset = "0xFC632C", VA = "0xFC632C")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xFC6410", Offset = "0xFC6410", VA = "0xFC6410")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xFC656C", Offset = "0xFC656C", VA = "0xFC656C")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xFC6754", Offset = "0xFC6754", VA = "0xFC6754")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xFC693C", Offset = "0xFC693C", VA = "0xFC693C")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xFC6B90", Offset = "0xFC6B90", VA = "0xFC6B90")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xFC6DEC", Offset = "0xFC6DEC", VA = "0xFC6DEC")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xFC6E9C", Offset = "0xFC6E9C", VA = "0xFC6E9C")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xFC6F4C", Offset = "0xFC6F4C", VA = "0xFC6F4C")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xFC6FFC", Offset = "0xFC6FFC", VA = "0xFC6FFC")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xFC740C", Offset = "0xFC740C", VA = "0xFC740C")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xFC74C0", Offset = "0xFC74C0", VA = "0xFC74C0")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xFB6050", Offset = "0xFB6050", VA = "0xFB6050")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xFC15B8", Offset = "0xFC15B8", VA = "0xFC15B8")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xFC77D8", Offset = "0xFC77D8", VA = "0xFC77D8")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xFC7978", Offset = "0xFC7978", VA = "0xFC7978")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xFC7DE8", Offset = "0xFC7DE8", VA = "0xFC7DE8")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xFC7F98", Offset = "0xFC7F98", VA = "0xFC7F98")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xFC805C", Offset = "0xFC805C", VA = "0xFC805C")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xFC81D4", Offset = "0xFC81D4", VA = "0xFC81D4")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xFC7C38", Offset = "0xFC7C38", VA = "0xFC7C38")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xFC83B0", Offset = "0xFC83B0", VA = "0xFC83B0")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xFBB8D4", Offset = "0xFBB8D4", VA = "0xFBB8D4")]
		private static SoundGroupVariation FindLeastImportantSoundOnBus(GroupBus bus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xFBB5D8", Offset = "0xFBB5D8", VA = "0xFBB5D8")]
		private static SoundGroupVariation FindFarthestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xFBB380", Offset = "0xFBB380", VA = "0xFBB380")]
		private static SoundGroupVariation FindOldestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xFB5828", Offset = "0xFB5828", VA = "0xFB5828")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xFC8524", Offset = "0xFC8524", VA = "0xFC8524")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xFC8684", Offset = "0xFC8684", VA = "0xFC8684")]
		public static bool CreateBus(string busName, int? actorInstanceId, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xFC89B0", Offset = "0xFC89B0", VA = "0xFC89B0")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xFC8A38", Offset = "0xFC8A38", VA = "0xFC8A38")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xFBBCD0", Offset = "0xFBBCD0", VA = "0xFBBCD0")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xFC8EAC", Offset = "0xFC8EAC", VA = "0xFC8EAC")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xFC9314", Offset = "0xFC9314", VA = "0xFC9314")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xFC9540", Offset = "0xFC9540", VA = "0xFC9540")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xFC974C", Offset = "0xFC974C", VA = "0xFC974C")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xFB1B34", Offset = "0xFB1B34", VA = "0xFB1B34")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xFC8D08", Offset = "0xFC8D08", VA = "0xFC8D08")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xFC1800", Offset = "0xFC1800", VA = "0xFC1800")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xFC7B54", Offset = "0xFC7B54", VA = "0xFC7B54")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xFC9EA8", Offset = "0xFC9EA8", VA = "0xFC9EA8")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xFCA060", Offset = "0xFCA060", VA = "0xFCA060")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xFCA218", Offset = "0xFCA218", VA = "0xFCA218")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xFCA440", Offset = "0xFCA440", VA = "0xFCA440")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xFCA5E0", Offset = "0xFCA5E0", VA = "0xFCA5E0")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xFCA6F0", Offset = "0xFCA6F0", VA = "0xFCA6F0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xFCA8E8", Offset = "0xFCA8E8", VA = "0xFCA8E8")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xFCAA04", Offset = "0xFCAA04", VA = "0xFCAA04")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xFCAA68", Offset = "0xFCAA68", VA = "0xFCAA68")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xFC73AC", Offset = "0xFC73AC", VA = "0xFC73AC")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xFCADD8", Offset = "0xFCADD8", VA = "0xFCADD8")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xFCAF94", Offset = "0xFCAF94", VA = "0xFCAF94")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xFCAFF8", Offset = "0xFCAFF8", VA = "0xFCAFF8")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xFC7460", Offset = "0xFC7460", VA = "0xFC7460")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xFCB298", Offset = "0xFCB298", VA = "0xFCB298")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xFCB370", Offset = "0xFCB370", VA = "0xFCB370")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xFCB3D4", Offset = "0xFCB3D4", VA = "0xFCB3D4")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xFCB704", Offset = "0xFCB704", VA = "0xFCB704")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xFCB674", Offset = "0xFCB674", VA = "0xFCB674")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xFCB764", Offset = "0xFCB764", VA = "0xFCB764")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xFCB7C8", Offset = "0xFCB7C8", VA = "0xFCB7C8")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xFC6EEC", Offset = "0xFC6EEC", VA = "0xFC6EEC")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xFCBA68", Offset = "0xFCBA68", VA = "0xFCBA68")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xFCBAF8", Offset = "0xFCBAF8", VA = "0xFCBAF8")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xFCBB5C", Offset = "0xFCBB5C", VA = "0xFCBB5C")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xFC6F9C", Offset = "0xFC6F9C", VA = "0xFC6F9C")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xFCBDFC", Offset = "0xFCBDFC", VA = "0xFCBDFC")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xFCBE8C", Offset = "0xFCBE8C", VA = "0xFCBE8C")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xFCBEF0", Offset = "0xFCBEF0", VA = "0xFCBEF0")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xFC6E3C", Offset = "0xFC6E3C", VA = "0xFC6E3C")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xFCC190", Offset = "0xFCC190", VA = "0xFCC190")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xFCC224", Offset = "0xFCC224", VA = "0xFCC224")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xFCC288", Offset = "0xFCC288", VA = "0xFCC288")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xFCC5B8", Offset = "0xFCC5B8", VA = "0xFCC5B8")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xFCC528", Offset = "0xFCC528", VA = "0xFCC528")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xFCC618", Offset = "0xFCC618", VA = "0xFCC618")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xFCC67C", Offset = "0xFCC67C", VA = "0xFCC67C")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xFCC9AC", Offset = "0xFCC9AC", VA = "0xFCC9AC")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xFCC91C", Offset = "0xFCC91C", VA = "0xFCC91C")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xFCCA0C", Offset = "0xFCCA0C", VA = "0xFCCA0C")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xFCCA70", Offset = "0xFCCA70", VA = "0xFCCA70")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xFCCD2C", Offset = "0xFCCD2C", VA = "0xFCCD2C")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xFCCC98", Offset = "0xFCCC98", VA = "0xFCCC98")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xFCCD8C", Offset = "0xFCCD8C", VA = "0xFCCD8C")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xFCD104", Offset = "0xFCD104", VA = "0xFCD104")]
		public static void StartPlaylistOnClip(string playlistName, string clipName)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xFCCDFC", Offset = "0xFCCDFC", VA = "0xFCCDFC")]
		public static void StartPlaylist(string playlistControllerName, string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xFCD180", Offset = "0xFCD180", VA = "0xFCD180")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xFCD270", Offset = "0xFCD270", VA = "0xFCD270")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xFCD2D4", Offset = "0xFCD2D4", VA = "0xFCD2D4")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xFCD1E0", Offset = "0xFCD1E0", VA = "0xFCD1E0")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xFCD4FC", Offset = "0xFCD4FC", VA = "0xFCD4FC")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xFCD5EC", Offset = "0xFCD5EC", VA = "0xFCD5EC")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xFCD650", Offset = "0xFCD650", VA = "0xFCD650")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xFCD55C", Offset = "0xFCD55C", VA = "0xFCD55C")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xFCD878", Offset = "0xFCD878", VA = "0xFCD878")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xFCD8E4", Offset = "0xFCD8E4", VA = "0xFCD8E4")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xFCDA64", Offset = "0xFCDA64", VA = "0xFCDA64")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xFCDAD0", Offset = "0xFCDAD0", VA = "0xFCDAD0")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xFCDC50", Offset = "0xFCDC50", VA = "0xFCDC50")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xFCDCCC", Offset = "0xFCDCCC", VA = "0xFCDCCC")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xFCDE54", Offset = "0xFCDE54", VA = "0xFCDE54")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xFCDED0", Offset = "0xFCDED0", VA = "0xFCDED0")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xFCE2E0", Offset = "0xFCE2E0", VA = "0xFCE2E0")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xFCE18C", Offset = "0xFCE18C", VA = "0xFCE18C")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xFCE358", Offset = "0xFCE358", VA = "0xFCE358")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xFCE4DC", Offset = "0xFCE4DC", VA = "0xFCE4DC")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xFCE688", Offset = "0xFCE688", VA = "0xFCE688")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f, [Optional] string alias)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xFCE758", Offset = "0xFCE758", VA = "0xFCE758")]
		public static void AddSongToPlaylist(string playlistName, MusicSetting newSong)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xFCEDD0", Offset = "0xFCEDD0", VA = "0xFCEDD0")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xFCEF04", Offset = "0xFCEF04", VA = "0xFCEF04")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xFCF254", Offset = "0xFCF254", VA = "0xFCF254")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xFCF654", Offset = "0xFCF654", VA = "0xFCF654")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xFCFAA4", Offset = "0xFCFAA4", VA = "0xFCFAA4")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xFCFE10", Offset = "0xFCFE10", VA = "0xFCFE10")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, int? actorInstanceId, bool errorOnDuplicates, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xFD0128", Offset = "0xFD0128", VA = "0xFD0128")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, int? actorInstanceId, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0xFD04C0", Offset = "0xFD04C0", VA = "0xFD04C0")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xFD0668", Offset = "0xFD0668", VA = "0xFD0668")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xFB1FE8", Offset = "0xFB1FE8", VA = "0xFB1FE8")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xFCF110", Offset = "0xFCF110", VA = "0xFCF110")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xFD075C", Offset = "0xFD075C", VA = "0xFD075C")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xFD08BC", Offset = "0xFD08BC", VA = "0xFD08BC")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xFD0A1C", Offset = "0xFD0A1C", VA = "0xFD0A1C")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xFB808C", Offset = "0xFB808C", VA = "0xFB808C")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xFB88DC", Offset = "0xFB88DC", VA = "0xFB88DC")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xFBBC34", Offset = "0xFBBC34", VA = "0xFBBC34")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xFD0EDC", Offset = "0xFD0EDC", VA = "0xFD0EDC")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xFBBB98", Offset = "0xFBBB98", VA = "0xFBBB98")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xFD0FEC", Offset = "0xFD0FEC", VA = "0xFD0FEC")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xFCAD08", Offset = "0xFCAD08", VA = "0xFCAD08")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xFD11A8", Offset = "0xFD11A8", VA = "0xFD11A8")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xFD1404", Offset = "0xFD1404", VA = "0xFD1404")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xFD1670", Offset = "0xFD1670", VA = "0xFD1670")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xFD18CC", Offset = "0xFD18CC", VA = "0xFD18CC")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xFD1B28", Offset = "0xFD1B28", VA = "0xFD1B28")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xFD1D30", Offset = "0xFD1D30", VA = "0xFD1D30")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xFD20A0", Offset = "0xFD20A0", VA = "0xFD20A0")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xFD2234", Offset = "0xFD2234", VA = "0xFD2234")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xFD22AC", Offset = "0xFD22AC", VA = "0xFD22AC")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xFC0820", Offset = "0xFC0820", VA = "0xFC0820")]
		public static bool IsOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xFBF130", Offset = "0xFBF130", VA = "0xFBF130")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xFD1F50", Offset = "0xFD1F50", VA = "0xFD1F50")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xFD2388", Offset = "0xFD2388", VA = "0xFD2388")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xFD259C", Offset = "0xFD259C", VA = "0xFD259C")]
		public static bool IsVideoPlayersGroup(string groupName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xFBDA8C", Offset = "0xFBDA8C", VA = "0xFBDA8C")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xFD26C4", Offset = "0xFD26C4", VA = "0xFD26C4")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xFC3E20", Offset = "0xFC3E20", VA = "0xFC3E20")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xFD3FEC", Offset = "0xFD3FEC", VA = "0xFD3FEC")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xFD41BC", Offset = "0xFD41BC", VA = "0xFD41BC")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xFD4354", Offset = "0xFD4354", VA = "0xFD4354")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xFD44EC", Offset = "0xFD44EC", VA = "0xFD44EC")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xFD4684", Offset = "0xFD4684", VA = "0xFD4684")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xFD481C", Offset = "0xFD481C", VA = "0xFD481C")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000745")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000746")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000747")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000748")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000749")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x400074A")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x400074B")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x400074C")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400074D")]
		public const string Separator = ";";

		[Token(Token = "0x170000D6")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xFE77A0", Offset = "0xFE77A0", VA = "0xFE77A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0xFE7818", Offset = "0xFE7818", VA = "0xFE7818")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0xFE7934", Offset = "0xFE7934", VA = "0xFE7934")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0xFE79AC", Offset = "0xFE79AC", VA = "0xFE79AC")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0xFE7C1C", Offset = "0xFE7C1C", VA = "0xFE7C1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0xFE7CB0", Offset = "0xFE7CB0", VA = "0xFE7CB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public static float? MixerVolume
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0xFE7DE8", Offset = "0xFE7DE8", VA = "0xFE7DE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0xFE7E74", Offset = "0xFE7E74", VA = "0xFE7E74")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0xFE7FA4", Offset = "0xFE7FA4", VA = "0xFE7FA4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0xFE8038", Offset = "0xFE8038", VA = "0xFE8038")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static float? MusicVolume
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0xFE8170", Offset = "0xFE8170", VA = "0xFE8170")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0xFE81FC", Offset = "0xFE81FC", VA = "0xFE81FC")]
			set
			{
			}
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xFE75E0", Offset = "0xFE75E0", VA = "0xFE75E0")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0xFE7754", Offset = "0xFE7754", VA = "0xFE7754")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0xFE7864", Offset = "0xFE7864", VA = "0xFE7864")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0xFE78E8", Offset = "0xFE78E8", VA = "0xFE78E8")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0xFE79F8", Offset = "0xFE79F8", VA = "0xFE79F8")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0xFE7B98", Offset = "0xFE7B98", VA = "0xFE7B98")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0xFE832C", Offset = "0xFE832C", VA = "0xFE832C")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public abstract class SingletonScriptable<InstanceType> : ScriptableObject where InstanceType : ScriptableObject
	{
		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static string AssetNameToLoad;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static string ResourceNameToLoad;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<string> FoldersToCreate;

		[Token(Token = "0x600078D")]
		protected SingletonScriptable()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x200011A")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0xFE87C0", Offset = "0xFE87C0", VA = "0xFE87C0")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200011B")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x400076A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000792")]
			[Address(RVA = "0xFE87F0", Offset = "0xFE87F0", VA = "0xFE87F0")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200011C")]
		public enum MAItemType
		{
			[Token(Token = "0x400076C")]
			SoundGroups,
			[Token(Token = "0x400076D")]
			CustomEvents
		}

		[Token(Token = "0x200011D")]
		public enum TransferMode
		{
			[Token(Token = "0x400076F")]
			None,
			[Token(Token = "0x4000770")]
			Import,
			[Token(Token = "0x4000771")]
			Export
		}

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x600078F")]
		[Address(RVA = "0xFE84DC", Offset = "0xFE84DC", VA = "0xFE84DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0xFE8544", Offset = "0xFE8544", VA = "0xFE8544")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public static class AmbientUtil
	{
		[Token(Token = "0x4000772")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x4000773")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x4000774")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x4000775")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x170000DC")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0xFE8C80", Offset = "0xFE8C80", VA = "0xFE8C80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0xFE88C4", Offset = "0xFE88C4", VA = "0xFE88C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0xFE9114", Offset = "0xFE9114", VA = "0xFE9114")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public static int AmbientCount
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0xFE91A0", Offset = "0xFE91A0", VA = "0xFE91A0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0xFE9210", Offset = "0xFE9210", VA = "0xFE9210")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0xFE8820", Offset = "0xFE8820", VA = "0xFE8820")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0xFE8B64", Offset = "0xFE8B64", VA = "0xFE8B64")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0xFE8BF8", Offset = "0xFE8BF8", VA = "0xFE8BF8")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0xFE8C78", Offset = "0xFE8C78", VA = "0xFE8C78")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0xFE8F68", Offset = "0xFE8F68", VA = "0xFE8F68")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xFE904C", Offset = "0xFE904C", VA = "0xFE904C")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x600079F")]
		[Address(RVA = "0xFE92A4", Offset = "0xFE92A4", VA = "0xFE92A4")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0xFE93AC", Offset = "0xFE93AC", VA = "0xFE93AC")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000120")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xFE942C", Offset = "0xFE942C", VA = "0xFE942C")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xFE94A4", Offset = "0xFE94A4", VA = "0xFE94A4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xFE94FC", Offset = "0xFE94FC", VA = "0xFE94FC")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xFE95A0", Offset = "0xFE95A0", VA = "0xFE95A0")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xFE9654", Offset = "0xFE9654", VA = "0xFE9654")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xFE96F8", Offset = "0xFE96F8", VA = "0xFE96F8")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xFE97AC", Offset = "0xFE97AC", VA = "0xFE97AC")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xFE9864", Offset = "0xFE9864", VA = "0xFE9864")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xFE991C", Offset = "0xFE991C", VA = "0xFE991C")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xFE9974", Offset = "0xFE9974", VA = "0xFE9974")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xFE99DC", Offset = "0xFE99DC", VA = "0xFE99DC")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xFE9A44", Offset = "0xFE9A44", VA = "0xFE9A44")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xFE9A9C", Offset = "0xFE9A9C", VA = "0xFE9A9C")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xFE9B04", Offset = "0xFE9B04", VA = "0xFE9B04")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xFE9B6C", Offset = "0xFE9B6C", VA = "0xFE9B6C")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xFE9BC4", Offset = "0xFE9BC4", VA = "0xFE9BC4")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xFE9C2C", Offset = "0xFE9C2C", VA = "0xFE9C2C")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0xFE9C94", Offset = "0xFE9C94", VA = "0xFE9C94")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000121")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170000E1")]
		public Transform Trans
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0xFE9CFC", Offset = "0xFE9CFC", VA = "0xFE9CFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0xFE9D7C", Offset = "0xFE9D7C", VA = "0xFE9D7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0xFE9D8C", Offset = "0xFE9D8C", VA = "0xFE9D8C")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x2000122")]
	public static class AudioUtil
	{
		[Token(Token = "0x400077B")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400077C")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400077D")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000E2")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0xFE9DF8", Offset = "0xFE9DF8", VA = "0xFE9DF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E3")]
		public static float FrameTime
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0xFE9E00", Offset = "0xFE9E00", VA = "0xFE9E00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E4")]
		public static float Time
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0xFE9E08", Offset = "0xFE9E08", VA = "0xFE9E08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E5")]
		public static int FrameCount
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0xFE9E10", Offset = "0xFE9E10", VA = "0xFE9E10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0xFE9D94", Offset = "0xFE9D94", VA = "0xFE9D94")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xFE9DD0", Offset = "0xFE9DD0", VA = "0xFE9DD0")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xFE9DE4", Offset = "0xFE9DE4", VA = "0xFE9DE4")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0xFE9E18", Offset = "0xFE9E18", VA = "0xFE9E18")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xFE9E58", Offset = "0xFE9E58", VA = "0xFE9E58")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0xFE9F30", Offset = "0xFE9F30", VA = "0xFE9F30")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xFE9F70", Offset = "0xFE9F70", VA = "0xFE9F70")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0xFE9F88", Offset = "0xFE9F88", VA = "0xFE9F88")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0xFE9F98", Offset = "0xFE9F98", VA = "0xFE9F98")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0xFEA074", Offset = "0xFEA074", VA = "0xFEA074")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0xFEA0B0", Offset = "0xFEA0B0", VA = "0xFEA0B0")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0xFEA1AC", Offset = "0xFEA1AC", VA = "0xFEA1AC")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0xFEA128", Offset = "0xFEA128", VA = "0xFEA128")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0xFEA28C", Offset = "0xFEA28C", VA = "0xFEA28C")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xFEA314", Offset = "0xFEA314", VA = "0xFEA314")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xFEA33C", Offset = "0xFEA33C", VA = "0xFEA33C")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xFEA34C", Offset = "0xFEA34C", VA = "0xFEA34C")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0xFEA384", Offset = "0xFEA384", VA = "0xFEA384")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xFEA398", Offset = "0xFEA398", VA = "0xFEA398")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000123")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x2000124")]
		[CompilerGenerated]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000E6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0xFEA50C", Offset = "0xFEA50C", VA = "0xFEA50C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0xFEA554", Offset = "0xFEA554", VA = "0xFEA554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xFEA428", Offset = "0xFEA428", VA = "0xFEA428")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0xFEA450", Offset = "0xFEA450", VA = "0xFEA450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xFEA454", Offset = "0xFEA454", VA = "0xFEA454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0xFEA514", Offset = "0xFEA514", VA = "0xFEA514", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0xFEA3B8", Offset = "0xFEA3B8", VA = "0xFEA3B8")]
		[IteratorStateMachine(typeof(<WaitForActualSeconds>d__0))]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000125")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000E8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007DC")]
				[Address(RVA = "0xFEACD4", Offset = "0xFEACD4", VA = "0xFEACD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007DE")]
				[Address(RVA = "0xFEAD1C", Offset = "0xFEAD1C", VA = "0xFEAD1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xFEAA9C", Offset = "0xFEAA9C", VA = "0xFEAA9C")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xFEAB20", Offset = "0xFEAB20", VA = "0xFEAB20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xFEAB24", Offset = "0xFEAB24", VA = "0xFEAB24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0xFEACDC", Offset = "0xFEACDC", VA = "0xFEACDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0xFEA55C", Offset = "0xFEA55C", VA = "0xFEA55C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xFEA8E4", Offset = "0xFEA8E4", VA = "0xFEA8E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xFEAA08", Offset = "0xFEAA08", VA = "0xFEAA08")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xFEAA34", Offset = "0xFEAA34", VA = "0xFEAA34")]
		[IteratorStateMachine(typeof(<PlaySongWithDelay>d__7))]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0xFEAAC4", Offset = "0xFEAAC4", VA = "0xFEAAC4")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0xFEAD24", Offset = "0xFEAD24", VA = "0xFEAD24")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0xFEAD38", Offset = "0xFEAD38", VA = "0xFEAD38")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0xFEAD4C", Offset = "0xFEAD4C", VA = "0xFEAD4C")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xFEAD64", Offset = "0xFEAD64", VA = "0xFEAD64")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x2000128")]
	[AudioScriptOrder(-35)]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40007AC")]
			FirstEnableOnly,
			[Token(Token = "0x40007AD")]
			EveryEnable
		}

		[Token(Token = "0x4000789")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _instanceId;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000EA")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0xFECA44", Offset = "0xFECA44", VA = "0xFECA44")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EB")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0xFECAB8", Offset = "0xFECAB8", VA = "0xFECAB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public int InstanceId
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xFEC6F0", Offset = "0xFEC6F0", VA = "0xFEC6F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000ED")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0xFECAC0", Offset = "0xFECAC0", VA = "0xFECAC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xFEAF74", Offset = "0xFEAF74", VA = "0xFEAF74")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xFEB044", Offset = "0xFEB044", VA = "0xFEB044")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xFEB11C", Offset = "0xFEB11C", VA = "0xFEB11C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xFEB120", Offset = "0xFEB120", VA = "0xFEB120")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xFEB048", Offset = "0xFEB048", VA = "0xFEB048")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xFEB21C", Offset = "0xFEB21C", VA = "0xFEB21C")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xFEB8EC", Offset = "0xFEB8EC", VA = "0xFEB8EC")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0xFECA54", Offset = "0xFECA54", VA = "0xFECA54")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xFEC728", Offset = "0xFEC728", VA = "0xFEC728")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xFECAC8", Offset = "0xFECAC8", VA = "0xFECAC8")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x40007B5")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x40007B6")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0xFECF58", Offset = "0xFECF58", VA = "0xFECF58")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0xFED37C", Offset = "0xFED37C", VA = "0xFED37C")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0xFED3F0", Offset = "0xFED3F0", VA = "0xFED3F0")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0xFED4E4", Offset = "0xFED4E4", VA = "0xFED4E4")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0xFED624", Offset = "0xFED624", VA = "0xFED624")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xFED76C", Offset = "0xFED76C", VA = "0xFED76C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xFED8B0", Offset = "0xFED8B0", VA = "0xFED8B0")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xFED97C", Offset = "0xFED97C", VA = "0xFED97C")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0xFEDA88", Offset = "0xFEDA88", VA = "0xFEDA88")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xFEDC0C", Offset = "0xFEDC0C", VA = "0xFEDC0C")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0xFEDD60", Offset = "0xFEDD60", VA = "0xFEDD60")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0xFEDEDC", Offset = "0xFEDEDC", VA = "0xFEDEDC")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0xFEE030", Offset = "0xFEE030", VA = "0xFEE030")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0xFEE12C", Offset = "0xFEE12C", VA = "0xFEE12C")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0xFEE28C", Offset = "0xFEE28C", VA = "0xFEE28C")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0xFEE300", Offset = "0xFEE300", VA = "0xFEE300")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xFEE36C", Offset = "0xFEE36C", VA = "0xFEE36C")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xFEE4DC", Offset = "0xFEE4DC", VA = "0xFEE4DC")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xFED0B8", Offset = "0xFED0B8", VA = "0xFED0B8")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xFEE990", Offset = "0xFEE990", VA = "0xFEE990")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xFEEA38", Offset = "0xFEEA38", VA = "0xFEEA38")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xFEEAE0", Offset = "0xFEEAE0", VA = "0xFEEAE0")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x200012E")]
	[AudioScriptOrder(-80)]
	[RequireComponent(typeof(AudioSource))]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x200012F")]
		public enum FadeStatus
		{
			[Token(Token = "0x400081D")]
			NotFading,
			[Token(Token = "0x400081E")]
			FadingIn,
			[Token(Token = "0x400081F")]
			FadeingOut
		}

		[Token(Token = "0x2000130")]
		public enum AudioPlayType
		{
			[Token(Token = "0x4000821")]
			PlayNow,
			[Token(Token = "0x4000822")]
			Schedule,
			[Token(Token = "0x4000823")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000131")]
		public enum PlaylistStates
		{
			[Token(Token = "0x4000825")]
			NotInScene,
			[Token(Token = "0x4000826")]
			Stopped,
			[Token(Token = "0x4000827")]
			Playing,
			[Token(Token = "0x4000828")]
			Paused,
			[Token(Token = "0x4000829")]
			Crossfading
		}

		[Token(Token = "0x2000132")]
		public enum FadeMode
		{
			[Token(Token = "0x400082B")]
			None,
			[Token(Token = "0x400082C")]
			GradualFade
		}

		[Token(Token = "0x2000133")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x400082E")]
			NotDucking,
			[Token(Token = "0x400082F")]
			SetToDuck,
			[Token(Token = "0x4000830")]
			Ducked,
			[Token(Token = "0x4000831")]
			Unducking
		}

		[Token(Token = "0x2000134")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000135")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000136")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x2000137")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x40007B8")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40007B9")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40007BA")]
		private const double UniversalAudioReactionTime = 0.3;

		[Token(Token = "0x40007BB")]
		private const int NextScheduleTimeRecalcConsecutiveFrameCount = 5;

		[Token(Token = "0x40007BC")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40007BD")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40007BE")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool ignoreListenerPause;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _actorUpdater;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _unduckTime;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _go;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _name;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _lostFocus;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x162")]
		private bool _isLoopSectionSchedule;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private double? _loopSectionNextStartTime;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private AudioSource _audioClip;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private AudioSource _transClip;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private bool _nextSongRequested;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private int? _lastSongPosition;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private int _nextScheduleTimeRecalcDifferentFirstFrameNum;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private double? _nextScheduledTimeRecalcStart;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly Dictionary<AudioSource, double> _scheduledSongStartTimeByAudioSource;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongEndTimeByAudioSource;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public int _frames;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private AudioSource _audio1;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private AudioSource _audio2;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private string _activeSongAlias;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool _isPlayingQueuedSong;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x229")]
		private bool _isSongReplacingScheduledTrack;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Transform _trans;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private bool _willPersist;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private double? _songPauseTime;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private int framesOfSongPlayed;

		[Token(Token = "0x170000EE")]
		private bool WillSyncToOtherClip
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0xFF520C", Offset = "0xFF520C", VA = "0xFF520C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public bool CurrentSongIsPlaying
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0xFF53B0", Offset = "0xFF53B0", VA = "0xFF53B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0xFF6728", Offset = "0xFF6728", VA = "0xFF6728")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0xFF6774", Offset = "0xFF6774", VA = "0xFF6774")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0xFF677C", Offset = "0xFF677C", VA = "0xFF677C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public FadeStatus CurrentFadeStatus
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0xFF6788", Offset = "0xFF6788", VA = "0xFF6788")]
			get
			{
				return default(FadeStatus);
			}
		}

		[Token(Token = "0x170000F3")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0xFF265C", Offset = "0xFF265C", VA = "0xFF265C")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000F4")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0xFF0ED8", Offset = "0xFF0ED8", VA = "0xFF0ED8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0xFF2934", Offset = "0xFF2934", VA = "0xFF2934")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0xFF67B4", Offset = "0xFF67B4", VA = "0xFF67B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0xFF6800", Offset = "0xFF6800", VA = "0xFF6800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0xFF6808", Offset = "0xFF6808", VA = "0xFF6808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0xFF6810", Offset = "0xFF6810", VA = "0xFF6810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xFF6898", Offset = "0xFF6898", VA = "0xFF6898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xFF6928", Offset = "0xFF6928", VA = "0xFF6928")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0xFF6940", Offset = "0xFF6940", VA = "0xFF6940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0xFF6948", Offset = "0xFF6948", VA = "0xFF6948")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool IsFading
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0xFF6954", Offset = "0xFF6954", VA = "0xFF6954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0xFF4E20", Offset = "0xFF4E20", VA = "0xFF4E20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0xFF6974", Offset = "0xFF6974", VA = "0xFF6974")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xFF5504", Offset = "0xFF5504", VA = "0xFF5504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public bool HasPlaylist
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0xFF2C9C", Offset = "0xFF2C9C", VA = "0xFF2C9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000100")]
		public string PlaylistName
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0xFF69BC", Offset = "0xFF69BC", VA = "0xFF69BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		public MusicSetting CurrentSong
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xFF6A2C", Offset = "0xFF6A2C", VA = "0xFF6A2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private bool IsMuted
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0xFF6A34", Offset = "0xFF6A34", VA = "0xFF6A34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xFF2E20", Offset = "0xFF2E20", VA = "0xFF2E20")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0xFF24A4", Offset = "0xFF24A4", VA = "0xFF24A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000105")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xFF2524", Offset = "0xFF2524", VA = "0xFF2524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000106")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0xFF3810", Offset = "0xFF3810", VA = "0xFF3810")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public string ControllerName
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0xFEF618", Offset = "0xFEF618", VA = "0xFEF618")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0xFEFD24", Offset = "0xFEFD24", VA = "0xFEFD24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0xFF059C", Offset = "0xFF059C", VA = "0xFF059C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0xFF2630", Offset = "0xFF2630", VA = "0xFF2630")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010B")]
		private bool IsPlayingScheduledLoopSection
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0xFF1934", Offset = "0xFF1934", VA = "0xFF1934")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		private bool IsCurrentSongLoopSection
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0xFF1FCC", Offset = "0xFF1FCC", VA = "0xFF1FCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		private Transform Trans
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0xFF04C0", Offset = "0xFF04C0", VA = "0xFF04C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0xFF6A3C", Offset = "0xFF6A3C", VA = "0xFF6A3C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0xFEED08", Offset = "0xFEED08", VA = "0xFEED08")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0xFEEDA8", Offset = "0xFEEDA8", VA = "0xFEEDA8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0xFEA844", Offset = "0xFEA844", VA = "0xFEA844")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0xFEA968", Offset = "0xFEA968", VA = "0xFEA968")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0xFEEE48", Offset = "0xFEEE48", VA = "0xFEEE48")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0xFEEEE8", Offset = "0xFEEEE8", VA = "0xFEEEE8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0xFEEF88", Offset = "0xFEEF88", VA = "0xFEEF88")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0xFEF028", Offset = "0xFEF028", VA = "0xFEF028")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0xFEF0C8", Offset = "0xFEF0C8", VA = "0xFEF0C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0xFEF64C", Offset = "0xFEF64C", VA = "0xFEF64C")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0xFEF964", Offset = "0xFEF964", VA = "0xFEF964")]
		private void DetectAndRescheduleNextGaplessSongIfOff()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0xFF00DC", Offset = "0xFF00DC", VA = "0xFF00DC")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0xFF023C", Offset = "0xFF023C", VA = "0xFF023C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0xFEF8C0", Offset = "0xFEF8C0", VA = "0xFEF8C0")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0xFF02B4", Offset = "0xFF02B4", VA = "0xFF02B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0xFF0540", Offset = "0xFF0540", VA = "0xFF0540")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0xFF0654", Offset = "0xFF0654", VA = "0xFF0654")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0xFF0A90", Offset = "0xFF0A90", VA = "0xFF0A90")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0xFF0C14", Offset = "0xFF0C14", VA = "0xFF0C14")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0xFF0F98", Offset = "0xFF0F98", VA = "0xFF0F98")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0xFF0FA4", Offset = "0xFF0FA4", VA = "0xFF0FA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0xFEA5F0", Offset = "0xFEA5F0", VA = "0xFEA5F0")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0xFF2B4C", Offset = "0xFF2B4C", VA = "0xFF2B4C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0xFF2CAC", Offset = "0xFF2CAC", VA = "0xFF2CAC")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0xFF2D70", Offset = "0xFF2D70", VA = "0xFF2D70")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0xFF0594", Offset = "0xFF0594", VA = "0xFF0594")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0xFF2E18", Offset = "0xFF2E18", VA = "0xFF2E18")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0xFF2F74", Offset = "0xFF2F74", VA = "0xFF2F74")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0xFF3158", Offset = "0xFF3158", VA = "0xFF3158")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0xFF0970", Offset = "0xFF0970", VA = "0xFF0970")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0xFF3890", Offset = "0xFF3890", VA = "0xFF3890")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0xFF39A4", Offset = "0xFF39A4", VA = "0xFF39A4")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0xFF3A2C", Offset = "0xFF3A2C", VA = "0xFF3A2C")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0xFF3C04", Offset = "0xFF3C04", VA = "0xFF3C04")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0xFF3E88", Offset = "0xFF3E88", VA = "0xFF3E88")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0xFEAC4C", Offset = "0xFEAC4C", VA = "0xFEAC4C")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0xFF3FDC", Offset = "0xFF3FDC", VA = "0xFF3FDC")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0xFF4188", Offset = "0xFF4188", VA = "0xFF4188")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0xFF41F8", Offset = "0xFF41F8", VA = "0xFF41F8")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0xFF43E4", Offset = "0xFF43E4", VA = "0xFF43E4")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0xFF4574", Offset = "0xFF4574", VA = "0xFF4574")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0xFF4928", Offset = "0xFF4928", VA = "0xFF4928")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0xFF4BD8", Offset = "0xFF4BD8", VA = "0xFF4BD8")]
		public void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0xFF4C6C", Offset = "0xFF4C6C", VA = "0xFF4C6C")]
		public void DuckMusicForTime(SoundGroupVariationUpdater actorUpdater, float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0xFF4DF8", Offset = "0xFF4DF8", VA = "0xFF4DF8")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0xFF0860", Offset = "0xFF0860", VA = "0xFF0860")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0xFF4E80", Offset = "0xFF4E80", VA = "0xFF4E80")]
		public void StartPlaylist(string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0xFF4FE8", Offset = "0xFF4FE8", VA = "0xFF4FE8")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0xFF36B0", Offset = "0xFF36B0", VA = "0xFF36B0")]
		private void FinishPlaylistInit(bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0xFF4F58", Offset = "0xFF4F58", VA = "0xFF4F58")]
		public void RestartPlaylist([Optional] string clipName)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0xFF5120", Offset = "0xFF5120", VA = "0xFF5120")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0xFF5244", Offset = "0xFF5244", VA = "0xFF5244")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0xFF2754", Offset = "0xFF2754", VA = "0xFF2754")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0xFF0498", Offset = "0xFF0498", VA = "0xFF0498")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xFF05C0", Offset = "0xFF05C0", VA = "0xFF05C0")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xFF2550", Offset = "0xFF2550", VA = "0xFF2550")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xFF3C94", Offset = "0xFF3C94", VA = "0xFF3C94")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xFF19E8", Offset = "0xFF19E8", VA = "0xFF19E8")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType, bool isLoopSectionSchedule, bool isQueuedSong = false)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xFF6104", Offset = "0xFF6104", VA = "0xFF6104")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xFF55A8", Offset = "0xFF55A8", VA = "0xFF55A8")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xFF63B0", Offset = "0xFF63B0", VA = "0xFF63B0")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xFF456C", Offset = "0xFF456C", VA = "0xFF456C")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0xFF2844", Offset = "0xFF2844", VA = "0xFF2844")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0xFF61C0", Offset = "0xFF61C0", VA = "0xFF61C0")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0xFF644C", Offset = "0xFF644C", VA = "0xFF644C")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0xFF64F8", Offset = "0xFF64F8", VA = "0xFF64F8")]
		private double? GetLatestEndTime(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFEFDAC", Offset = "0xFEFDAC", VA = "0xFEFDAC")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause, bool addDspTime = true)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0xFF6298", Offset = "0xFF6298", VA = "0xFF6298")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0xFF1FF8", Offset = "0xFF1FF8", VA = "0xFF1FF8")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xFF23C0", Offset = "0xFF23C0", VA = "0xFF23C0")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0xFF284C", Offset = "0xFF284C", VA = "0xFF284C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0xFF671C", Offset = "0xFF671C", VA = "0xFF671C")]
		private void ResetDuckingState()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0xFF5478", Offset = "0xFF5478", VA = "0xFF5478")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0xFF697C", Offset = "0xFF697C", VA = "0xFF697C")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0xFF6A84", Offset = "0xFF6A84", VA = "0xFF6A84")]
		public PlaylistController()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x4000834")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x4000835")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x1700010F")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x600088F")]
			[Address(RVA = "0xFF7000", Offset = "0xFF7000", VA = "0xFF7000")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000110")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0xFF7090", Offset = "0xFF7090", VA = "0xFF7090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0xFF70DC", Offset = "0xFF70DC", VA = "0xFF70DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000112")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0xFF7088", Offset = "0xFF7088", VA = "0xFF7088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0xFEF78C", Offset = "0xFEF78C", VA = "0xFEF78C")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xFF7128", Offset = "0xFF7128", VA = "0xFF7128")]
		private static void SetSpatializerToggleOnSource(AudioSource source, bool enabled)
		{
		}
	}
	[Token(Token = "0x200013A")]
	public static class UtilStrings
	{
		[Token(Token = "0x6000895")]
		[Address(RVA = "0xFF716C", Offset = "0xFF716C", VA = "0xFF716C")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xFF71E4", Offset = "0xFF71E4", VA = "0xFF71E4")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x200013B")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x6000897")]
		[Address(RVA = "0xFF72C8", Offset = "0xFF72C8", VA = "0xFF72C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xFF72CC", Offset = "0xFF72CC", VA = "0xFF72CC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0xFF73F8", Offset = "0xFF73F8", VA = "0xFF73F8")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x200013C")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xFF7400", Offset = "0xFF7400", VA = "0xFF7400")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0xFF7460", Offset = "0xFF7460", VA = "0xFF7460")]
		private void Update()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xFF74F0", Offset = "0xFF74F0", VA = "0xFF74F0")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xFF74F8", Offset = "0xFF74F8", VA = "0xFF74F8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xFF75DC", Offset = "0xFF75DC", VA = "0xFF75DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0xFF7724", Offset = "0xFF7724", VA = "0xFF7724")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x200013E")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xFF772C", Offset = "0xFF772C", VA = "0xFF772C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xFF778C", Offset = "0xFF778C", VA = "0xFF778C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xFF7918", Offset = "0xFF7918", VA = "0xFF7918")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xFF7920", Offset = "0xFF7920", VA = "0xFF7920")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xFF79C8", Offset = "0xFF79C8", VA = "0xFF79C8")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0xFF79D0", Offset = "0xFF79D0", VA = "0xFF79D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xFF7A5C", Offset = "0xFF7A5C", VA = "0xFF7A5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0xFF7B38", Offset = "0xFF7B38", VA = "0xFF7B38")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0xFF7B40", Offset = "0xFF7B40", VA = "0xFF7B40")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0xFF7BE8", Offset = "0xFF7BE8", VA = "0xFF7BE8")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x4000842")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0xFF7BF0", Offset = "0xFF7BF0", VA = "0xFF7BF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0xFF7C7C", Offset = "0xFF7C7C", VA = "0xFF7C7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0xFF7C80", Offset = "0xFF7C80", VA = "0xFF7C80")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0xFF7C84", Offset = "0xFF7C84", VA = "0xFF7C84")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0xFF7C88", Offset = "0xFF7C88", VA = "0xFF7C88")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0xFF7EB4", Offset = "0xFF7EB4", VA = "0xFF7EB4")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x17000113")]
		private bool PlayerActive
		{
			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xFF7EE8", Offset = "0xFF7EE8", VA = "0xFF7EE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0xFF7EC4", Offset = "0xFF7EC4", VA = "0xFF7EC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0xFF7F04", Offset = "0xFF7F04", VA = "0xFF7F04")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0xFF7F7C", Offset = "0xFF7F7C", VA = "0xFF7F7C")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x2000144")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0xFF7F84", Offset = "0xFF7F84", VA = "0xFF7F84")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0xFF7F88", Offset = "0xFF7F88", VA = "0xFF7F88")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0xFF80E4", Offset = "0xFF80E4", VA = "0xFF80E4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0xFF8158", Offset = "0xFF8158", VA = "0xFF8158")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0xFF7F8C", Offset = "0xFF7F8C", VA = "0xFF7F8C", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0xFF82A8", Offset = "0xFF82A8", VA = "0xFF82A8", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0xFF83D8", Offset = "0xFF83D8", VA = "0xFF83D8", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0xFF80E8", Offset = "0xFF80E8", VA = "0xFF80E8", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0xFF8250", Offset = "0xFF8250", VA = "0xFF8250", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0xFF8450", Offset = "0xFF8450", VA = "0xFF8450", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0xFF85C8", Offset = "0xFF85C8", VA = "0xFF85C8")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0xFF8734", Offset = "0xFF8734", VA = "0xFF8734")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0xFF87DC", Offset = "0xFF87DC", VA = "0xFF87DC")]
		public MA_TestUI()
		{
		}
	}
}
namespace Crosstales
{
	[Token(Token = "0x2000146")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Vector3 flat;

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0xFF87E4", Offset = "0xFF87E4", VA = "0xFF87E4")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0xFF8884", Offset = "0xFF8884", VA = "0xFF8884")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0xFF88FC", Offset = "0xFF88FC", VA = "0xFF88FC")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0xFF8988", Offset = "0xFF8988", VA = "0xFF8988")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0xFF8998", Offset = "0xFF8998", VA = "0xFF8998")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0xFF89B8", Offset = "0xFF89B8", VA = "0xFF89B8")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0xFF8B14", Offset = "0xFF8B14", VA = "0xFF8B14")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0xFF8C70", Offset = "0xFF8C70", VA = "0xFF8C70")]
		public static string CTRemoveNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0xFF8CC4", Offset = "0xFF8CC4", VA = "0xFF8CC4")]
		public static string CTAddNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0xFF8D68", Offset = "0xFF8D68", VA = "0xFF8D68")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0xFF8D8C", Offset = "0xFF8D8C", VA = "0xFF8D8C")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0xFF8E04", Offset = "0xFF8E04", VA = "0xFF8E04")]
		public static bool CTisEmail(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0xFF8E84", Offset = "0xFF8E84", VA = "0xFF8E84")]
		public static bool CTisWebsite(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0xFF8F04", Offset = "0xFF8F04", VA = "0xFF8F04")]
		public static bool CTisCreditcard(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0xFF8F84", Offset = "0xFF8F84", VA = "0xFF8F84")]
		public static bool CTisIPv4(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0xFF9004", Offset = "0xFF9004", VA = "0xFF9004")]
		public static bool CTisAlphanumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0xFF9084", Offset = "0xFF9084", VA = "0xFF9084")]
		public static bool CThasLineEndings(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0xFF9104", Offset = "0xFF9104", VA = "0xFF9104")]
		public static bool CThasInvalidChars(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0xFF9184", Offset = "0xFF9184", VA = "0xFF9184")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0xFF91D8", Offset = "0xFF91D8", VA = "0xFF91D8")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0xFF922C", Offset = "0xFF922C", VA = "0xFF922C")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0xFF92CC", Offset = "0xFF92CC", VA = "0xFF92CC")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0xFF936C", Offset = "0xFF936C", VA = "0xFF936C")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0xFF9420", Offset = "0xFF9420", VA = "0xFF9420")]
		public static string CTToBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0xFF9528", Offset = "0xFF9528", VA = "0xFF9528")]
		public static string CTFromBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0xFF95C8", Offset = "0xFF95C8", VA = "0xFF95C8")]
		public static byte[] CTFromBase64ToByteArray(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0xFF9634", Offset = "0xFF9634", VA = "0xFF9634")]
		public static string CTToHex(this string str, bool addPrefix = false)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0xFF9784", Offset = "0xFF9784", VA = "0xFF9784")]
		public static string CTHexToString(this string hexString)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0xFF9964", Offset = "0xFF9964", VA = "0xFF9964")]
		public static Color32 CTHexToColor32(this string hexString)
		{
			return default(Color32);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xFF9BE8", Offset = "0xFF9BE8", VA = "0xFF9BE8")]
		public static Color CTHexToColor(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xFF9C78", Offset = "0xFF9C78", VA = "0xFF9C78")]
		public static byte[] CTToByteArray(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xFF9CCC", Offset = "0xFF9CCC", VA = "0xFF9CCC")]
		public static string CTClearTags(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0xFF9D78", Offset = "0xFF9D78", VA = "0xFF9D78")]
		public static string CTClearSpaces(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xFF9E1C", Offset = "0xFF9E1C", VA = "0xFF9E1C")]
		public static string CTClearLineEndings(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		[Token(Token = "0x60008E4")]
		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xFF9EC8", Offset = "0xFF9EC8", VA = "0xFF9EC8")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xFFA058", Offset = "0xFFA058", VA = "0xFFA058")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0xFFA198", Offset = "0xFFA198", VA = "0xFFA198")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xFFA308", Offset = "0xFFA308", VA = "0xFFA308")]
		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		public static string[] CTToStringArray<T>(this T[] array)
		{
			return null;
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xFFA498", Offset = "0xFFA498", VA = "0xFFA498")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xFFA62C", Offset = "0xFFA62C", VA = "0xFFA62C")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xFFA76C", Offset = "0xFFA76C", VA = "0xFFA76C")]
		public static Texture2D CTToTexture(this byte[] data, [Optional] Texture2D supportTexture)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0xFFA870", Offset = "0xFFA870", VA = "0xFFA870")]
		public static Sprite CTToSprite(this byte[] data, [Optional] Texture2D supportTexture)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xFFAA18", Offset = "0xFFAA18", VA = "0xFFAA18")]
		public static string CTToString(this byte[] data, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0xFF94BC", Offset = "0xFF94BC", VA = "0xFF94BC")]
		public static string CTToBase64(this byte[] data)
		{
			return null;
		}

		[Token(Token = "0x60008F0")]
		public static T[] GetColumn<T>(this T[,] matrix, int columnNumber)
		{
			return null;
		}

		[Token(Token = "0x60008F1")]
		public static T[] GetRow<T>(this T[,] matrix, int rowNumber)
		{
			return null;
		}

		[Token(Token = "0x60008F2")]
		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		[Token(Token = "0x60008F3")]
		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xFFAA60", Offset = "0xFFAA60", VA = "0xFFAA60")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0xFFAE8C", Offset = "0xFFAE8C", VA = "0xFFAE8C")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0xFFB254", Offset = "0xFFB254", VA = "0xFFB254")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0xFFB654", Offset = "0xFFB654", VA = "0xFFB654")]
		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		[Token(Token = "0x60008F8")]
		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "", bool appendNewLine = true, string delimiter = "; ")
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		public static void CTAddRange<K, V>(this IDictionary<K, V> dict, IDictionary<K, V> collection)
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0xFFBA80", Offset = "0xFFBA80", VA = "0xFFBA80")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0xFFBC80", Offset = "0xFFBC80", VA = "0xFFBC80")]
		public static string CTToHexRGB(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0xFFBD2C", Offset = "0xFFBD2C", VA = "0xFFBD2C")]
		public static string CTToHexRGB(this Color input)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0xFFBD34", Offset = "0xFFBD34", VA = "0xFFBD34")]
		public static string CTToHexRGBA(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0xFFBDE0", Offset = "0xFFBDE0", VA = "0xFFBDE0")]
		public static string CTToHexRGBA(this Color input)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0xFFBDE8", Offset = "0xFFBDE8", VA = "0xFFBDE8")]
		public static Vector3 CTVector3(this Color32 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0xFFBE80", Offset = "0xFFBE80", VA = "0xFFBE80")]
		public static Vector3 CTVector3(this Color color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0xFFBE84", Offset = "0xFFBE84", VA = "0xFFBE84")]
		public static Vector4 CTVector4(this Color32 color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0xFFBF2C", Offset = "0xFFBF2C", VA = "0xFFBF2C")]
		public static Vector4 CTVector4(this Color color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0xFFBF30", Offset = "0xFFBF30", VA = "0xFFBF30")]
		public static Vector2 CTMultiply(this Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0xFFBF3C", Offset = "0xFFBF3C", VA = "0xFFBF3C")]
		public static Vector3 CTMultiply(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0xFFBF4C", Offset = "0xFFBF4C", VA = "0xFFBF4C")]
		public static Vector3 CTFlatten(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0xFFBFD0", Offset = "0xFFBFD0", VA = "0xFFBFD0")]
		public static Quaternion CTQuaternion(this Vector3 eulerAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0xFFBFEC", Offset = "0xFFBFEC", VA = "0xFFBFEC")]
		public static Color CTColorRGB(this Vector3 rgb, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0xFFC028", Offset = "0xFFC028", VA = "0xFFC028")]
		public static Vector4 CTMultiply(this Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0xFFC03C", Offset = "0xFFC03C", VA = "0xFFC03C")]
		public static Quaternion CTQuaternion(this Vector4 angle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0xFFC040", Offset = "0xFFC040", VA = "0xFFC040")]
		public static Color CTColorRGBA(this Vector4 rgba)
		{
			return default(Color);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xFFC07C", Offset = "0xFFC07C", VA = "0xFFC07C")]
		public static Vector3 CTVector3(this Quaternion angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xFFC0A8", Offset = "0xFFC0A8", VA = "0xFFC0A8")]
		public static Vector4 CTVector4(this Quaternion angle)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xFFC0AC", Offset = "0xFFC0AC", VA = "0xFFC0AC")]
		public static Vector3 CTCorrectLossyScale(this Canvas canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0xFFC2C4", Offset = "0xFFC2C4", VA = "0xFFC2C4")]
		public static void CTGetLocalCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xFFC534", Offset = "0xFFC534", VA = "0xFFC534")]
		public static Vector3[] CTGetLocalCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0xFFC5EC", Offset = "0xFFC5EC", VA = "0xFFC5EC")]
		public static void CTGetScreenCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0xFFC8C8", Offset = "0xFFC8C8", VA = "0xFFC8C8")]
		public static Vector3[] CTGetScreenCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xFFC980", Offset = "0xFFC980", VA = "0xFFC980")]
		public static Bounds CTGetBounds(this RectTransform transform, float uiScaleFactor = 1f)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0xFFCEB0", Offset = "0xFFCEB0", VA = "0xFFCEB0")]
		public static void CTSetLeft(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xFFCF8C", Offset = "0xFFCF8C", VA = "0xFFCF8C")]
		public static void CTSetRight(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0xFFD068", Offset = "0xFFD068", VA = "0xFFD068")]
		public static void CTSetTop(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0xFFD144", Offset = "0xFFD144", VA = "0xFFD144")]
		public static void CTSetBottom(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0xFFD220", Offset = "0xFFD220", VA = "0xFFD220")]
		public static float CTGetLeft(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0xFFD2E0", Offset = "0xFFD2E0", VA = "0xFFD2E0")]
		public static float CTGetRight(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0xFFD3A0", Offset = "0xFFD3A0", VA = "0xFFD3A0")]
		public static float CTGetTop(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0xFFD468", Offset = "0xFFD468", VA = "0xFFD468")]
		public static float CTGetBottom(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0xFFD530", Offset = "0xFFD530", VA = "0xFFD530")]
		public static Vector4 CTGetLRTB(this RectTransform transform)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0xFFD638", Offset = "0xFFD638", VA = "0xFFD638")]
		public static void CTSetLRTB(this RectTransform transform, Vector4 lrtb)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0xFFD734", Offset = "0xFFD734", VA = "0xFFD734")]
		public static List<GameObject> CTFindAll(this Component component, string name, int maxDepth = 0)
		{
			return null;
		}

		[Token(Token = "0x600091F")]
		public static List<T> CTFindAll<T>(this Component component, string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xFFDF04", Offset = "0xFFDF04", VA = "0xFFDF04")]
		public static GameObject CTFind(this MonoBehaviour mb, string name)
		{
			return null;
		}

		[Token(Token = "0x6000921")]
		public static T CTFind<T>(this MonoBehaviour mb, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xFFE124", Offset = "0xFFE124", VA = "0xFFE124")]
		public static GameObject CTFind(this GameObject go, string name)
		{
			return null;
		}

		[Token(Token = "0x6000923")]
		public static T CTFind<T>(this GameObject go, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xFFE234", Offset = "0xFFE234", VA = "0xFFE234")]
		public static Bounds CTGetBounds(this GameObject go)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xFFE014", Offset = "0xFFE014", VA = "0xFFE014")]
		public static Transform CTFind(this Transform transform, string name)
		{
			return null;
		}

		[Token(Token = "0x6000926")]
		public static T CTFind<T>(this Transform transform, string name)
		{
			return (T)null;
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xFFE814", Offset = "0xFFE814", VA = "0xFFE814")]
		public static byte[] CTToPNG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xFFE9C0", Offset = "0xFFE9C0", VA = "0xFFE9C0")]
		public static byte[] CTToJPG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xFFEB6C", Offset = "0xFFEB6C", VA = "0xFFEB6C")]
		public static byte[] CTToTGA(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0xFFED18", Offset = "0xFFED18", VA = "0xFFED18")]
		public static byte[] CTToEXR(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0xFFE908", Offset = "0xFFE908", VA = "0xFFE908")]
		public static byte[] CTToPNG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0xFFEAB4", Offset = "0xFFEAB4", VA = "0xFFEAB4")]
		public static byte[] CTToJPG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0xFFEC60", Offset = "0xFFEC60", VA = "0xFFEC60")]
		public static byte[] CTToTGA(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0xFFEE0C", Offset = "0xFFEE0C", VA = "0xFFEE0C")]
		public static byte[] CTToEXR(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xFFEEC4", Offset = "0xFFEEC4", VA = "0xFFEEC4")]
		public static Sprite CTToSprite(this Texture2D texture, float pixelsPerUnit = 100f)
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xFFEFF4", Offset = "0xFFEFF4", VA = "0xFFEFF4")]
		public static Texture2D CTRotate90(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0xFFF344", Offset = "0xFFF344", VA = "0xFFF344")]
		public static Texture2D CTRotate180(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0xFFF560", Offset = "0xFFF560", VA = "0xFFF560")]
		public static Texture2D CTRotate270(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0xFFF834", Offset = "0xFFF834", VA = "0xFFF834")]
		public static Texture2D CTToTexture2D(this Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0xFFF93C", Offset = "0xFFF93C", VA = "0xFFF93C")]
		public static Texture2D CTFlipHorizontal(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0xFFFA78", Offset = "0xFFFA78", VA = "0xFFFA78")]
		public static Texture2D CTFlipVertical(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0xFFFBC0", Offset = "0xFFFBC0", VA = "0xFFFBC0")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xFFFCD0", Offset = "0xFFFCD0", VA = "0xFFFCD0")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xFFE464", Offset = "0xFFE464", VA = "0xFFE464")]
		private static Transform deepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0xFFDB08", Offset = "0xFFDB08", VA = "0xFFDB08")]
		private static List<Transform> getAllChildren(this Transform parent, int maxDepth = 0, [Optional] List<Transform> transformList, int depth = 0)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0xFFA610", Offset = "0xFFA610", VA = "0xFFA610")]
		private static float bytesToFloat(byte firstByte, byte secondByte)
		{
			return default(float);
		}
	}
}
namespace Crosstales.Common.Util
{
	[Token(Token = "0x200014F")]
	public abstract class BaseConstants
	{
		[Token(Token = "0x4000855")]
		public const string ASSET_AUTHOR = "crosstales LLC";

		[Token(Token = "0x4000856")]
		public const string ASSET_AUTHOR_URL = "https://www.crosstales.com";

		[Token(Token = "0x4000857")]
		public const string ASSET_CT_URL = "https://assetstore.unity.com/lists/crosstales-42213?aid=1011lNGT";

		[Token(Token = "0x4000858")]
		public const string ASSET_SOCIAL_DISCORD = "https://discord.gg/ZbZ2sh4";

		[Token(Token = "0x4000859")]
		public const string ASSET_SOCIAL_FACEBOOK = "https://www.facebook.com/crosstales/";

		[Token(Token = "0x400085A")]
		public const string ASSET_SOCIAL_TWITTER = "https://twitter.com/crosstales";

		[Token(Token = "0x400085B")]
		public const string ASSET_SOCIAL_YOUTUBE = "https://www.youtube.com/c/Crosstales";

		[Token(Token = "0x400085C")]
		public const string ASSET_SOCIAL_LINKEDIN = "https://www.linkedin.com/company/crosstales";

		[Token(Token = "0x400085D")]
		public const string ASSET_3P_PLAYMAKER = "https://assetstore.unity.com/packages/slug/368?aid=1011lNGT";

		[Token(Token = "0x400085E")]
		public const string ASSET_3P_VOLUMETRIC_AUDIO = "https://assetstore.unity.com/packages/slug/17125?aid=1011lNGT";

		[Token(Token = "0x400085F")]
		public const string ASSET_3P_ROCKTOMATE = "https://assetstore.unity.com/packages/slug/156311?aid=1011lNGT";

		[Token(Token = "0x4000860")]
		public const string ASSET_BWF = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x4000861")]
		public const string ASSET_DJ = "https://assetstore.unity.com/packages/slug/41993?aid=1011lNGT";

		[Token(Token = "0x4000862")]
		public const string ASSET_FB = "https://assetstore.unity.com/packages/slug/98713?aid=1011lNGT";

		[Token(Token = "0x4000863")]
		public const string ASSET_OC = "https://assetstore.unity.com/packages/slug/74688?aid=1011lNGT";

		[Token(Token = "0x4000864")]
		public const string ASSET_RADIO = "https://assetstore.unity.com/packages/slug/32034?aid=1011lNGT";

		[Token(Token = "0x4000865")]
		public const string ASSET_RTV = "https://assetstore.unity.com/packages/slug/41068?aid=1011lNGT";

		[Token(Token = "0x4000866")]
		public const string ASSET_TB = "https://assetstore.unity.com/packages/slug/98711?aid=1011lNGT";

		[Token(Token = "0x4000867")]
		public const string ASSET_TPB = "https://assetstore.unity.com/packages/slug/98714?aid=1011lNGT";

		[Token(Token = "0x4000868")]
		public const string ASSET_TPS = "https://assetstore.unity.com/packages/slug/60040?aid=1011lNGT";

		[Token(Token = "0x4000869")]
		public const string ASSET_TR = "https://assetstore.unity.com/packages/slug/61617?aid=1011lNGT";

		[Token(Token = "0x400086A")]
		public const int FACTOR_KB = 1024;

		[Token(Token = "0x400086B")]
		public const int FACTOR_MB = 1048576;

		[Token(Token = "0x400086C")]
		public const int FACTOR_GB = 1073741824;

		[Token(Token = "0x400086D")]
		public const float FLOAT_32768 = 32768f;

		[Token(Token = "0x400086E")]
		public const float FLOAT_TOLERANCE = 0.0001f;

		[Token(Token = "0x400086F")]
		public const string FORMAT_TWO_DECIMAL_PLACES = "0.00";

		[Token(Token = "0x4000870")]
		public const string FORMAT_NO_DECIMAL_PLACES = "0";

		[Token(Token = "0x4000871")]
		public const string FORMAT_PERCENT = "0%";

		[Token(Token = "0x4000872")]
		public const bool DEFAULT_DEBUG = false;

		[Token(Token = "0x4000873")]
		public const string PATH_DELIMITER_WINDOWS = "\\";

		[Token(Token = "0x4000874")]
		public const string PATH_DELIMITER_UNIX = "/";

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Regex REGEX_LINEENDINGS;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly Regex REGEX_EMAIL;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Regex REGEX_CREDITCARD;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly Regex REGEX_URL_WEB;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly Regex REGEX_IP_ADDRESS;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly Regex REGEX_INVALID_CHARS;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly Regex REGEX_ALPHANUMERIC;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly Regex REGEX_CLEAN_SPACES;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly Regex REGEX_CLEAN_TAGS;

		[Token(Token = "0x400087E")]
		public const string ALPHABET_LATIN_UPPERCASE = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		[Token(Token = "0x400087F")]
		public const string ALPHABET_LATIN_LOWERCASE = "abcdefghijklmnopqrstuvwxyz";

		[Token(Token = "0x4000880")]
		public const string ALPHABET_FRENCH_UPPERCASE = "ÀÂÄÆÇÈÉÊËÎÏÔŒÙÛÜ";

		[Token(Token = "0x4000881")]
		public const string ALPHABET_FRENCH_LOWERCASE = "àâäæçèéêëîïôœùûü";

		[Token(Token = "0x4000882")]
		public const string NUMBERS = "0123456789";

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool DEV_DEBUG;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string TEXT_TOSTRING_START;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string TEXT_TOSTRING_END;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string TEXT_TOSTRING_DELIMITER;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string TEXT_TOSTRING_DELIMITER_END;

		[Token(Token = "0x4000888")]
		public const string PREFIX_HTTP = "http://";

		[Token(Token = "0x4000889")]
		public const string PREFIX_HTTPS = "https://";

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static int PROCESS_KILL_TIME;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string CMD_WINDOWS_PATH;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static bool SHOW_BWF_BANNER;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public static bool SHOW_DJ_BANNER;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public static bool SHOW_FB_BANNER;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x83")]
		public static bool SHOW_OC_BANNER;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static bool SHOW_RADIO_BANNER;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public static bool SHOW_RTV_BANNER;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public static bool SHOW_TB_BANNER;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
		public static bool SHOW_TPB_BANNER;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static bool SHOW_TPS_BANNER;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public static bool SHOW_TR_BANNER;

		[Token(Token = "0x17000114")]
		public static string PREFIX_FILE
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x100007C", Offset = "0x100007C", VA = "0x100007C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x1000188", Offset = "0x1000188", VA = "0x1000188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1000458", Offset = "0x1000458", VA = "0x1000458")]
		protected BaseConstants()
		{
		}
	}
	[Token(Token = "0x2000150")]
	public abstract class BaseHelper
	{
		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly CultureInfo BaseCulture;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static readonly System.Random rnd;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool ApplicationIsPlaying;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string[] args;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int androidAPILevel;

		[Token(Token = "0x17000116")]
		public static bool isWindowsPlatform
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x1000780", Offset = "0x1000780", VA = "0x1000780")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x1000788", Offset = "0x1000788", VA = "0x1000788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x1000790", Offset = "0x1000790", VA = "0x1000790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x1000798", Offset = "0x1000798", VA = "0x1000798")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1000808", Offset = "0x1000808", VA = "0x1000808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1000810", Offset = "0x1000810", VA = "0x1000810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1000818", Offset = "0x1000818", VA = "0x1000818")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1000820", Offset = "0x1000820", VA = "0x1000820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1000828", Offset = "0x1000828", VA = "0x1000828")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1000830", Offset = "0x1000830", VA = "0x1000830")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1000838", Offset = "0x1000838", VA = "0x1000838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1000840", Offset = "0x1000840", VA = "0x1000840")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1000100", Offset = "0x1000100", VA = "0x1000100")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1000890", Offset = "0x1000890", VA = "0x1000890")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x10008F0", Offset = "0x10008F0", VA = "0x10008F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1000960", Offset = "0x1000960", VA = "0x1000960")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x10009C0", Offset = "0x10009C0", VA = "0x10009C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isEditor
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1000A10", Offset = "0x1000A10", VA = "0x1000A10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1000170", Offset = "0x1000170", VA = "0x1000170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x1000178", Offset = "0x1000178", VA = "0x1000178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1000180", Offset = "0x1000180", VA = "0x1000180")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1000A80", Offset = "0x1000A80", VA = "0x1000A80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1000AD4", Offset = "0x1000AD4", VA = "0x1000AD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1000ADC", Offset = "0x1000ADC", VA = "0x1000ADC")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x1700012E")]
		public static int AndroidAPILevel
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1000B5C", Offset = "0x1000B5C", VA = "0x1000B5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1000C58", Offset = "0x1000C58", VA = "0x1000C58")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1000F6C", Offset = "0x1000F6C", VA = "0x1000F6C")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1000FD4", Offset = "0x1000FD4", VA = "0x1000FD4")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1001158", Offset = "0x1001158", VA = "0x1001158")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1001424", Offset = "0x1001424", VA = "0x1001424")]
		public static string FormatBytesToHRF(long bytes, bool useSI = false)
		{
			return null;
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x10016EC", Offset = "0x10016EC", VA = "0x10016EC")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1001AF0", Offset = "0x1001AF0", VA = "0x1001AF0")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x1001C40", Offset = "0x1001C40", VA = "0x1001C40")]
		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = int.MaxValue, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1000D48", Offset = "0x1000D48", VA = "0x1000D48")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x1002450", Offset = "0x1002450", VA = "0x1002450")]
		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1002F78", Offset = "0x1002F78", VA = "0x1002F78")]
		public static object InvokeMethod(string className, string methodName, params object[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1003568", Offset = "0x1003568", VA = "0x1003568")]
		public static string GetArgument(string name)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x100368C", Offset = "0x100368C", VA = "0x100368C")]
		public static string[] GetArguments()
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x1001A80", Offset = "0x1001A80", VA = "0x1001A80")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x1003734", Offset = "0x1003734", VA = "0x1003734")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x10037CC", Offset = "0x10037CC", VA = "0x10037CC")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x10037FC", Offset = "0x10037FC", VA = "0x10037FC")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x1003804", Offset = "0x1003804", VA = "0x1003804")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1003874", Offset = "0x1003874", VA = "0x1003874")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x100387C", Offset = "0x100387C", VA = "0x100387C")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x10038EC", Offset = "0x10038EC", VA = "0x10038EC")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x100395C", Offset = "0x100395C", VA = "0x100395C")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x10039CC", Offset = "0x10039CC", VA = "0x10039CC")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x1003A50", Offset = "0x1003A50", VA = "0x1003A50")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x1003AF0", Offset = "0x1003AF0", VA = "0x1003AF0")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1003B64", Offset = "0x1003B64", VA = "0x1003B64")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1003BF8", Offset = "0x1003BF8", VA = "0x1003BF8")]
		public static Vector4 GetVector4(string key)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1003CB4", Offset = "0x1003CB4", VA = "0x1003CB4")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1003D40", Offset = "0x1003D40", VA = "0x1003D40")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1003DCC", Offset = "0x1003DCC", VA = "0x1003DCC")]
		public static SystemLanguage GetLanguage(string key)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1003ED0", Offset = "0x1003ED0", VA = "0x1003ED0")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1003F50", Offset = "0x1003F50", VA = "0x1003F50")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1003FD0", Offset = "0x1003FD0", VA = "0x1003FD0")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1004050", Offset = "0x1004050", VA = "0x1004050")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x10040C0", Offset = "0x10040C0", VA = "0x10040C0")]
		public static void SetDate(string key, DateTime value)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1004128", Offset = "0x1004128", VA = "0x1004128")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x10041DC", Offset = "0x10041DC", VA = "0x10041DC")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x10042BC", Offset = "0x10042BC", VA = "0x10042BC")]
		public static void SetVector4(string key, Vector4 value)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x1004484", Offset = "0x1004484", VA = "0x1004484")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x1004510", Offset = "0x1004510", VA = "0x1004510")]
		public static void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x100459C", Offset = "0x100459C", VA = "0x100459C")]
		public static void SetLanguage(string key, SystemLanguage language)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1004618", Offset = "0x1004618", VA = "0x1004618")]
		protected CTPlayerPrefs()
		{
		}
	}
	[Token(Token = "0x2000153")]
	public class CTWebClient : WebClient
	{
		[Token(Token = "0x1700012F")]
		public int Timeout
		{
			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1004620", Offset = "0x1004620", VA = "0x1004620")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1004628", Offset = "0x1004628", VA = "0x1004628")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1004630", Offset = "0x1004630", VA = "0x1004630")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1004638", Offset = "0x1004638", VA = "0x1004638")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x1004640", Offset = "0x1004640", VA = "0x1004640")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x100464C", Offset = "0x100464C", VA = "0x100464C")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x10046C0", Offset = "0x10046C0", VA = "0x10046C0")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x1004740", Offset = "0x1004740", VA = "0x1004740", Slot = "27")]
		protected override WebRequest GetWebRequest(Uri uri)
		{
			return null;
		}
	}
	[Token(Token = "0x2000154")]
	public abstract class FileHelper
	{
		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string applicationDataPath;

		[Token(Token = "0x17000131")]
		public static string StreamingAssetsPath
		{
			[Token(Token = "0x600099F")]
			[Address(RVA = "0x10048A0", Offset = "0x10048A0", VA = "0x10048A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x100497C", Offset = "0x100497C", VA = "0x100497C")]
		static FileHelper()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x10049CC", Offset = "0x10049CC", VA = "0x10049CC")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1000228", Offset = "0x1000228", VA = "0x1000228")]
		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true)
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1004B38", Offset = "0x1004B38", VA = "0x1004B38")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1004DB0", Offset = "0x1004DB0", VA = "0x1004DB0")]
		public static bool PathHasInvalidChars(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1004E40", Offset = "0x1004E40", VA = "0x1004E40")]
		public static bool FileHasInvalidChars(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1004ED0", Offset = "0x1004ED0", VA = "0x1004ED0")]
		public static string[] GetFilesForName(string path, bool isRecursive = false, params string[] filenames)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x10053DC", Offset = "0x10053DC", VA = "0x10053DC")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x1005590", Offset = "0x1005590", VA = "0x1005590")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x10057C4", Offset = "0x10057C4", VA = "0x10057C4")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x100595C", Offset = "0x100595C", VA = "0x100595C")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1005E78", Offset = "0x1005E78", VA = "0x1005E78")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x1006198", Offset = "0x1006198", VA = "0x1006198")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x10061E4", Offset = "0x10061E4", VA = "0x10061E4")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x1006288", Offset = "0x1006288", VA = "0x1006288")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1005CAC", Offset = "0x1005CAC", VA = "0x1005CAC")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x100632C", Offset = "0x100632C", VA = "0x100632C")]
		protected FileHelper()
		{
		}
	}
	[Token(Token = "0x2000156")]
	public class MemoryCacheStream : Stream
	{
		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] cache;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long writePosition;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long readPosition;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private long length;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int size;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private readonly int maxSize;

		[Token(Token = "0x17000132")]
		public override bool CanRead
		{
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1006560", Offset = "0x1006560", VA = "0x1006560", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public override bool CanSeek
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1006568", Offset = "0x1006568", VA = "0x1006568", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000134")]
		public override bool CanWrite
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1006570", Offset = "0x1006570", VA = "0x1006570", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000135")]
		public override long Position
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x1006578", Offset = "0x1006578", VA = "0x1006578", Slot = "13")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x1006580", Offset = "0x1006580", VA = "0x1006580", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public override long Length
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x10065FC", Offset = "0x10065FC", VA = "0x10065FC", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1006434", Offset = "0x1006434", VA = "0x1006434")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1006604", Offset = "0x1006604", VA = "0x1006604", Slot = "23")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1006608", Offset = "0x1006608", VA = "0x1006608", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1006714", Offset = "0x1006714", VA = "0x1006714", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1006758", Offset = "0x1006758", VA = "0x1006758", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x100691C", Offset = "0x100691C", VA = "0x100691C", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x1006864", Offset = "0x1006864", VA = "0x1006864")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x1006A5C", Offset = "0x1006A5C", VA = "0x1006A5C")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x10064B0", Offset = "0x10064B0", VA = "0x10064B0")]
		private void createCache()
		{
		}
	}
	[Token(Token = "0x2000157")]
	public abstract class NetworkHelper
	{
		[Token(Token = "0x40008A9")]
		protected const string file_prefix = "file://";

		[Token(Token = "0x40008AA")]
		protected const string content_prefix = "content://";

		[Token(Token = "0x17000137")]
		public static bool isInternetAvailable
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x1006B0C", Offset = "0x1006B0C", VA = "0x1006B0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1006B28", Offset = "0x1006B28", VA = "0x1006B28")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1006BDC", Offset = "0x1006BDC", VA = "0x1006BDC")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x10070EC", Offset = "0x10070EC", VA = "0x10070EC")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x1007254", Offset = "0x1007254", VA = "0x1007254")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x1004A34", Offset = "0x1004A34", VA = "0x1004A34")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x10073FC", Offset = "0x10073FC", VA = "0x10073FC")]
		public static string GetIP(string host)
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1006BD4", Offset = "0x1006BD4", VA = "0x1006BD4")]
		private static void openURL(string url)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x10075A0", Offset = "0x10075A0", VA = "0x10075A0")]
		protected NetworkHelper()
		{
		}
	}
	[Token(Token = "0x2000159")]
	[DisallowMultipleComponent]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("Don't destroy gameobject during scene switches (default: false).")]
		private bool dontDestroy;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string PrefabPath;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string GameObjectName;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static T instance;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly object lockObj;

		[Token(Token = "0x17000138")]
		public static T Instance
		{
			[Token(Token = "0x60009D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D1")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public bool DontDestroy
		{
			[Token(Token = "0x60009D2")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D3")]
			set
			{
			}
		}

		[Token(Token = "0x60009D4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60009D5")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x60009D6")]
		protected virtual void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60009D7")]
		public static void CreateInstance(bool searchExistingGameObject = true, bool deleteExistingInstance = false)
		{
		}

		[Token(Token = "0x60009D8")]
		public static void DeleteInstance()
		{
		}

		[Token(Token = "0x60009D9")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public class SingletonHelper
	{
		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool isInitialized;

		[Token(Token = "0x1700013A")]
		public static bool isQuitting
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1007620", Offset = "0x1007620", VA = "0x1007620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1007678", Offset = "0x1007678", VA = "0x1007678")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x10076D4", Offset = "0x10076D4", VA = "0x10076D4")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x10077C8", Offset = "0x10077C8", VA = "0x10077C8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x1007AD0", Offset = "0x1007AD0", VA = "0x1007AD0")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x1007C54", Offset = "0x1007C54", VA = "0x1007C54")]
		private static void onQuitting()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x1007DA8", Offset = "0x1007DA8", VA = "0x1007DA8")]
		public SingletonHelper()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public abstract class XmlHelper
	{
		[Token(Token = "0x60009E2")]
		public static void SerializeToFile<T>(T obj, string filename)
		{
		}

		[Token(Token = "0x60009E3")]
		public static string SerializeToString<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60009E4")]
		public static byte[] SerializeToByteArray<T>(T obj)
		{
			return null;
		}

		[Token(Token = "0x60009E5")]
		public static T DeserializeFromFile<T>(string filename, bool skipBOM = false)
		{
			return (T)null;
		}

		[Token(Token = "0x60009E6")]
		public static T DeserializeFromString<T>(string xmlAsString, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60009E7")]
		public static T DeserializeFromByteArray<T>(byte[] data)
		{
			return (T)null;
		}

		[Token(Token = "0x60009E8")]
		public static T DeserializeFromResource<T>(string resourceName, bool skipBOM = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1007DB0", Offset = "0x1007DB0", VA = "0x1007DB0")]
		protected XmlHelper()
		{
		}
	}
}
namespace Crosstales.Common.Model.Enum
{
	[Token(Token = "0x200015C")]
	public enum Platform
	{
		[Token(Token = "0x40008B5")]
		Windows,
		[Token(Token = "0x40008B6")]
		OSX,
		[Token(Token = "0x40008B7")]
		Linux,
		[Token(Token = "0x40008B8")]
		IOS,
		[Token(Token = "0x40008B9")]
		Android,
		[Token(Token = "0x40008BA")]
		WSA,
		[Token(Token = "0x40008BB")]
		Web,
		[Token(Token = "0x40008BC")]
		Unsupported
	}
	[Token(Token = "0x200015D")]
	public enum SampleRate
	{
		[Token(Token = "0x40008BE")]
		_8000Hz = 8000,
		[Token(Token = "0x40008BF")]
		_11025Hz = 11025,
		[Token(Token = "0x40008C0")]
		_22050Hz = 22050,
		[Token(Token = "0x40008C1")]
		_44100Hz = 44100,
		[Token(Token = "0x40008C2")]
		_48000Hz = 48000
	}
}
namespace Crosstales.BWF
{
	[Token(Token = "0x200015E")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_b_w_f_manager.html")]
	[ExecuteInEditMode]
	public class BWFManager : Singleton<BWFManager>
	{
		[Token(Token = "0x200015F")]
		public delegate void BWFReady();

		[Token(Token = "0x2000162")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string text;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ManagerMask mask;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool result;

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x100B668", Offset = "0x100B668", VA = "0x100B668")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x100B670", Offset = "0x100B670", VA = "0x100B670")]
			internal void <containsAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000163")]
		[CompilerGenerated]
		private sealed class <containsAsync>d__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string text;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ManagerMask mask;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BWFManager <>4__this;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass40_0 <>8__1;

			[Token(Token = "0x1700013D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A1F")]
				[Address(RVA = "0x100B824", Offset = "0x100B824", VA = "0x100B824", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0x100B86C", Offset = "0x100B86C", VA = "0x100B86C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x100AA3C", Offset = "0x100AA3C", VA = "0x100AA3C")]
			[DebuggerHidden]
			public <containsAsync>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x100B684", Offset = "0x100B684", VA = "0x100B684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x100B688", Offset = "0x100B688", VA = "0x100B688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x100B82C", Offset = "0x100B82C", VA = "0x100B82C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000164")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string text;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ManagerMask mask;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> result;

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x100B874", Offset = "0x100B874", VA = "0x100B874")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x100B87C", Offset = "0x100B87C", VA = "0x100B87C")]
			internal void <getAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000165")]
		[CompilerGenerated]
		private sealed class <getAllAsync>d__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string text;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ManagerMask mask;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public BWFManager <>4__this;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass41_0 <>8__1;

			[Token(Token = "0x1700013F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A27")]
				[Address(RVA = "0x100BA2C", Offset = "0x100BA2C", VA = "0x100BA2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000140")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A29")]
				[Address(RVA = "0x100BA74", Offset = "0x100BA74", VA = "0x100BA74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x100AA64", Offset = "0x100AA64", VA = "0x100AA64")]
			[DebuggerHidden]
			public <getAllAsync>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x100B890", Offset = "0x100B890", VA = "0x100B890", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x100B894", Offset = "0x100B894", VA = "0x100B894", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x100BA34", Offset = "0x100BA34", VA = "0x100BA34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass42_0
		{
			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string text;

			[Token(Token = "0x40008ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ManagerMask mask;

			[Token(Token = "0x40008EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool markOnly;

			[Token(Token = "0x40008EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string prefix;

			[Token(Token = "0x40008F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string postfix;

			[Token(Token = "0x40008F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x40008F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string result;

			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x100BA7C", Offset = "0x100BA7C", VA = "0x100BA7C")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x100BA84", Offset = "0x100BA84", VA = "0x100BA84")]
			internal void <replaceAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <replaceAllAsync>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string text;

			[Token(Token = "0x40008F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ManagerMask mask;

			[Token(Token = "0x40008F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool markOnly;

			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string prefix;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string postfix;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string[] sourceNames;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public BWFManager <>4__this;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass42_0 <>8__1;

			[Token(Token = "0x17000141")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A2F")]
				[Address(RVA = "0x100BC4C", Offset = "0x100BC4C", VA = "0x100BC4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000142")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A31")]
				[Address(RVA = "0x100BC94", Offset = "0x100BC94", VA = "0x100BC94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x100AA8C", Offset = "0x100AA8C", VA = "0x100AA8C")]
			[DebuggerHidden]
			public <replaceAllAsync>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x100BAA0", Offset = "0x100BAA0", VA = "0x100BAA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x100BAA4", Offset = "0x100BAA4", VA = "0x100BAA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x100BC54", Offset = "0x100BC54", VA = "0x100BC54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Disables the ordering of the 'GetAll'-method (prevent possible memory garbage).")]
		public bool DisableOrdering;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		private bool sentReady;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Thread worker;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<string> getAllResult;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Events")]
		public OnReady OnReady;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OnContainsCompleted OnContainsCompleted;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public OnGetAllCompleted OnGetAllCompleted;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public OnReplaceAllCompleted OnReplaceAllCompleted;

		[Token(Token = "0x1700013B")]
		public bool isReady
		{
			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x1007DB8", Offset = "0x1007DB8", VA = "0x1007DB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013C")]
		public int TotalRegexCount
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x10080AC", Offset = "0x10080AC", VA = "0x10080AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000008")]
		public event BWFReady OnBWFReady
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1008440", Offset = "0x1008440", VA = "0x1008440")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x10084DC", Offset = "0x10084DC", VA = "0x10084DC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event ContainsComplete OnContainsComplete
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x1008578", Offset = "0x1008578", VA = "0x1008578")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1008614", Offset = "0x1008614", VA = "0x1008614")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event GetAllComplete OnGetAllComplete
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x10086B0", Offset = "0x10086B0", VA = "0x10086B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x100874C", Offset = "0x100874C", VA = "0x100874C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event ReplaceAllComplete OnReplaceAllComplete
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x10087E8", Offset = "0x10087E8", VA = "0x10087E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x1008884", Offset = "0x1008884", VA = "0x1008884")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1008920", Offset = "0x1008920", VA = "0x1008920", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1008A0C", Offset = "0x1008A0C", VA = "0x1008A0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1008AC4", Offset = "0x1008AC4", VA = "0x1008AC4")]
		public void Load(ManagerMask mask = ManagerMask.All)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x10081B4", Offset = "0x10081B4", VA = "0x10081B4")]
		public List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1008F14", Offset = "0x1008F14", VA = "0x1008F14")]
		public bool Contains(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x10091E4", Offset = "0x10091E4", VA = "0x10091E4")]
		public void ContainsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1009290", Offset = "0x1009290", VA = "0x1009290")]
		public List<string> GetAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1009978", Offset = "0x1009978", VA = "0x1009978")]
		public void GetAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1009A24", Offset = "0x1009A24", VA = "0x1009A24")]
		public string ReplaceAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1009AC4", Offset = "0x1009AC4", VA = "0x1009AC4")]
		public string ReplaceAll(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1009DF8", Offset = "0x1009DF8", VA = "0x1009DF8")]
		public void ReplaceAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1009E88", Offset = "0x1009E88", VA = "0x1009E88")]
		public void ReplaceAllAsync(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1009F58", Offset = "0x1009F58", VA = "0x1009F58")]
		public string Mark(string text, List<string> unwantedWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x100A43C", Offset = "0x100A43C", VA = "0x100A43C")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x100A970", Offset = "0x100A970", VA = "0x100A970")]
		public string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1009204", Offset = "0x1009204", VA = "0x1009204")]
		[IteratorStateMachine(typeof(<containsAsync>d__40))]
		private IEnumerator containsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1009998", Offset = "0x1009998", VA = "0x1009998")]
		[IteratorStateMachine(typeof(<getAllAsync>d__41))]
		private IEnumerator getAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x1009EAC", Offset = "0x1009EAC", VA = "0x1009EAC")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__42))]
		private IEnumerator replaceAllAsync(string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x1008F5C", Offset = "0x1008F5C", VA = "0x1008F5C")]
		private static void contains(out bool result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x10092D8", Offset = "0x10092D8", VA = "0x10092D8")]
		private static void getAll(out List<string> result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x1009B10", Offset = "0x1009B10", VA = "0x1009B10")]
		private static void replaceAll(out string result, string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x1008A40", Offset = "0x1008A40", VA = "0x1008A40")]
		private void onBWFReady()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x1009128", Offset = "0x1009128", VA = "0x1009128")]
		private void onContainsComplete(string text, bool result)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x100985C", Offset = "0x100985C", VA = "0x100985C")]
		private void onGetAllComplete(string text, List<string> badWords)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x1009D3C", Offset = "0x1009D3C", VA = "0x1009D3C")]
		private void onReplaceAllComplete(string originalText, string cleanText)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x100B3A4", Offset = "0x100B3A4", VA = "0x100B3A4")]
		public BWFManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	public class OnReady : UnityEvent
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x100BC9C", Offset = "0x100BC9C", VA = "0x100BC9C")]
		public OnReady()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class OnContainsCompleted : UnityEvent<string, bool>
	{
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x100BCA4", Offset = "0x100BCA4", VA = "0x100BCA4")]
		public OnContainsCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016A")]
	public class OnGetAllCompleted : UnityEvent<string, string>
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x100BCEC", Offset = "0x100BCEC", VA = "0x100BCEC")]
		public OnGetAllCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public class OnReplaceAllCompleted : UnityEvent<string, string>
	{
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x100BD34", Offset = "0x100BD34", VA = "0x100BD34")]
		public OnReplaceAllCompleted()
		{
		}
	}
	[Token(Token = "0x200016C")]
	public delegate void ContainsComplete(string originalText, bool containsBadWords);
	[Token(Token = "0x200016D")]
	public delegate void GetAllComplete(string originalText, List<string> badWords);
	[Token(Token = "0x200016E")]
	public delegate void ReplaceAllComplete(string originalText, string cleanText);
}
namespace Crosstales.BWF.Util
{
	[Token(Token = "0x200016F")]
	public static class Config
	{
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DEBUG;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool DEBUG_BADWORDS;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool DEBUG_DOMAINS;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
		public static bool isLoaded;
	}
	[Token(Token = "0x2000170")]
	public abstract class Constants : BaseConstants
	{
		[Token(Token = "0x4000901")]
		public const string ASSET_NAME = "Bad Word Filter PRO";

		[Token(Token = "0x4000902")]
		public const string ASSET_NAME_SHORT = "BWF PRO";

		[Token(Token = "0x4000903")]
		public const string ASSET_VERSION = "2022.2.2";

		[Token(Token = "0x4000904")]
		public const int ASSET_BUILD = 20221202;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly DateTime ASSET_CREATED;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly DateTime ASSET_CHANGED;

		[Token(Token = "0x4000907")]
		public const string ASSET_PRO_URL = "https://assetstore.unity.com/packages/slug/26255?aid=1011lNGT";

		[Token(Token = "0x4000908")]
		public const string ASSET_UPDATE_CHECK_URL = "https://www.crosstales.com/media/assets/bwf_versions.txt";

		[Token(Token = "0x4000909")]
		public const string ASSET_CONTACT = "bwf@crosstales.com";

		[Token(Token = "0x400090A")]
		public const string ASSET_MANUAL_URL = "https://www.crosstales.com/media/data/assets/badwordfilter/BadWordFilter-doc.pdf";

		[Token(Token = "0x400090B")]
		public const string ASSET_API_URL = "https://www.crosstales.com/en/assets/badwordfilter/api";

		[Token(Token = "0x400090C")]
		public const string ASSET_FORUM_URL = "https://forum.unity.com/threads/bad-word-filter-pro-solution-against-profanity-and-obscenity.289960/";

		[Token(Token = "0x400090D")]
		public const string ASSET_WEB_URL = "https://www.crosstales.com/en/portfolio//badwordfilter/";

		[Token(Token = "0x400090E")]
		public const string ASSET_VIDEO_PROMO = "https://youtu.be/pXICeRKaRPM?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x400090F")]
		public const string ASSET_VIDEO_TUTORIAL = "https://youtu.be/W8FxFlIObWM?list=PLgtonIOr6Tb41XTMeeZ836tjHlKgOO84S";

		[Token(Token = "0x4000910")]
		public const string KEY_PREFIX = "BWF_CFG_";

		[Token(Token = "0x4000911")]
		public const string KEY_DEBUG = "BWF_CFG_DEBUG";

		[Token(Token = "0x4000912")]
		public const string KEY_DEBUG_BADWORDS = "BWF_CFG_DEBUG_BADWORDS";

		[Token(Token = "0x4000913")]
		public const string KEY_DEBUG_DOMAINS = "BWF_CFG_DEBUG_DOMAINS";

		[Token(Token = "0x4000914")]
		public const bool DEFAULT_DEBUG_BADWORDS = false;

		[Token(Token = "0x4000915")]
		public const bool DEFAULT_DEBUG_DOMAINS = false;

		[Token(Token = "0x4000916")]
		public const string MANAGER_SCENE_OBJECT_NAME = "BWF";

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static int WWW_TIMEOUT;

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x100C1CC", Offset = "0x100C1CC", VA = "0x100C1CC")]
		protected Constants()
		{
		}
	}
	[Token(Token = "0x2000171")]
	public abstract class Helper : BaseHelper
	{
		[Token(Token = "0x17000143")]
		public static bool isSupportedPlatform
		{
			[Token(Token = "0x6000A45")]
			[Address(RVA = "0x100C2C4", Offset = "0x100C2C4", VA = "0x100C2C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x100C2CC", Offset = "0x100C2CC", VA = "0x100C2CC")]
		public static void CreateSource()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x100C2D0", Offset = "0x100C2D0", VA = "0x100C2D0")]
		protected Helper()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class SetupProject
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x100C328", Offset = "0x100C328", VA = "0x100C328")]
		static SetupProject()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x100C32C", Offset = "0x100C32C", VA = "0x100C32C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void setup()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x100C578", Offset = "0x100C578", VA = "0x100C578")]
		public SetupProject()
		{
		}
	}
}
namespace Crosstales.BWF.Provider
{
	[Token(Token = "0x2000173")]
	public abstract class BadWordProvider : BaseProvider
	{
		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly List<BadWords> badwords;

		[Token(Token = "0x4000919")]
		private const string exactRegexStart = "(?<![\\w\\d])";

		[Token(Token = "0x400091A")]
		private const string exactRegexEnd = "s?(?![\\w\\d])";

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, List<string>> simpleBadwords;

		[Token(Token = "0x17000144")]
		public Dictionary<string, Regex> ExactBadwordsRegex
		{
			[Token(Token = "0x6000A4B")]
			[Address(RVA = "0x100C580", Offset = "0x100C580", VA = "0x100C580")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x100C588", Offset = "0x100C588", VA = "0x100C588")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x100C590", Offset = "0x100C590", VA = "0x100C590")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x100C598", Offset = "0x100C598", VA = "0x100C598")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public Dictionary<string, List<string>> SimpleBadwords
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x100C5A0", Offset = "0x100C5A0", VA = "0x100C5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x100C5A8", Offset = "0x100C5A8", VA = "0x100C5A8")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x100C5B0", Offset = "0x100C5B0", VA = "0x100C5B0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x100C5B4", Offset = "0x100C5B4", VA = "0x100C5B4", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x100C62C", Offset = "0x100C62C", VA = "0x100C62C", Slot = "10")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x100D290", Offset = "0x100D290", VA = "0x100D290")]
		protected BadWordProvider()
		{
		}
	}
	[Token(Token = "0x2000174")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_provider_1_1_bad_word_provider_text.html")]
	public class BadWordProviderText : BadWordProvider
	{
		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <loadWeb>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000920")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000921")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000922")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderText <>4__this;

			[Token(Token = "0x4000923")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Source src;

			[Token(Token = "0x4000924")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <uid>5__2;

			[Token(Token = "0x4000925")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x4000926")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<string> <list>5__4;

			[Token(Token = "0x17000147")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0x100EAF4", Offset = "0x100EAF4", VA = "0x100EAF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000148")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A64")]
				[Address(RVA = "0x100EB3C", Offset = "0x100EB3C", VA = "0x100EB3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x100DB24", Offset = "0x100DB24", VA = "0x100DB24")]
			[DebuggerHidden]
			public <loadWeb>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x100DC40", Offset = "0x100DC40", VA = "0x100DC40", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x100DC6C", Offset = "0x100DC6C", VA = "0x100DC6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x100EA44", Offset = "0x100EA44", VA = "0x100EA44")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x100EAFC", Offset = "0x100EAFC", VA = "0x100EAFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000177")]
		[CompilerGenerated]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000927")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000928")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000929")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordProviderText <>4__this;

			[Token(Token = "0x400092A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Source src;

			[Token(Token = "0x400092B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <uid>5__2;

			[Token(Token = "0x400092C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string> <list>5__3;

			[Token(Token = "0x17000149")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A68")]
				[Address(RVA = "0x100EFC8", Offset = "0x100EFC8", VA = "0x100EFC8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A6A")]
				[Address(RVA = "0x100F010", Offset = "0x100F010", VA = "0x100F010", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x100DB4C", Offset = "0x100DB4C", VA = "0x100DB4C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x100EB44", Offset = "0x100EB44", VA = "0x100EB44", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x100EB48", Offset = "0x100EB48", VA = "0x100EB48", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x100EFD0", Offset = "0x100EFD0", VA = "0x100EFD0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x100D544", Offset = "0x100D544", VA = "0x100D544", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x100DAB4", Offset = "0x100DAB4", VA = "0x100DAB4", Slot = "9")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x100DA40", Offset = "0x100DA40", VA = "0x100DA40")]
		[IteratorStateMachine(typeof(<loadWeb>d__2))]
		private IEnumerator loadWeb(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x100D9CC", Offset = "0x100D9CC", VA = "0x100D9CC")]
		[IteratorStateMachine(typeof(<loadResource>d__3))]
		private IEnumerator loadResource(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x100DB74", Offset = "0x100DB74", VA = "0x100DB74")]
		public BadWordProviderText()
		{
		}
	}
	[Token(Token = "0x2000178")]
	[ExecuteInEditMode]
	public abstract class BaseProvider : MonoBehaviour, IProvider
	{
		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Option1 (default: RegexOptions.IgnoreCase).")]
		[Header("Regex Options")]
		public RegexOptions RegexOption1;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Option2 (default: RegexOptions.CultureInvariant).")]
		public RegexOptions RegexOption2;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Option3 (default: RegexOptions.None).")]
		public RegexOptions RegexOption3;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Option4 (default: RegexOptions.None).")]
		public RegexOptions RegexOption4;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Option5 (default: RegexOptions.None).")]
		public RegexOptions RegexOption5;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[ContextMenuItem("Create Source", "createSource")]
		[Tooltip("All sources for this provider.")]
		[Header("Sources")]
		public List<Source> Sources;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Load Behaviour")]
		[Tooltip("Clears all existing bad words on 'Load' (default: true).")]
		public bool ClearOnLoad;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected readonly List<string> coRoutines;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static bool loggedUnsupportedPlatform;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool loading;

		[Token(Token = "0x1700014B")]
		public int RegexCount
		{
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x100F018", Offset = "0x100F018", VA = "0x100F018")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014C")]
		public bool isReady
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x100F12C", Offset = "0x100F12C", VA = "0x100F12C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x100F134", Offset = "0x100F134", VA = "0x100F134", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000A6E")]
		public abstract void Load();

		[Token(Token = "0x6000A6F")]
		public abstract void Save();

		[Token(Token = "0x6000A70")]
		protected abstract void init();

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x100F140", Offset = "0x100F140", VA = "0x100F140")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x100F14C", Offset = "0x100F14C", VA = "0x100F14C")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x100F328", Offset = "0x100F328", VA = "0x100F328")]
		protected void createSource()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x100D3D4", Offset = "0x100D3D4", VA = "0x100D3D4")]
		protected BaseProvider()
		{
		}
	}
	[Token(Token = "0x200017A")]
	public abstract class DomainProvider : BaseProvider
	{
		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected readonly List<Domains> domains;

		[Token(Token = "0x400093B")]
		private const string domainRegexStart = "\\b{0,1}((ht|f)tp(s?)\\:\\/\\/)?[\\w\\-\\.\\@]*[\\.]";

		[Token(Token = "0x400093C")]
		private const string domainRegexEnd = "(:\\d{1,5})?(\\/|\\b)";

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x1700014D")]
		public Dictionary<string, Regex> DomainsRegex
		{
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x100F410", Offset = "0x100F410", VA = "0x100F410")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x100F418", Offset = "0x100F418", VA = "0x100F418")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x100F420", Offset = "0x100F420", VA = "0x100F420")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x100F428", Offset = "0x100F428", VA = "0x100F428")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x100F430", Offset = "0x100F430", VA = "0x100F430")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x100F434", Offset = "0x100F434", VA = "0x100F434", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x100F4AC", Offset = "0x100F4AC", VA = "0x100F4AC", Slot = "10")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x100FF60", Offset = "0x100FF60", VA = "0x100FF60")]
		protected DomainProvider()
		{
		}
	}
	[Token(Token = "0x200017B")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_provider_1_1_domain_provider_text.html")]
	public class DomainProviderText : DomainProvider
	{
		[Token(Token = "0x200017D")]
		[CompilerGenerated]
		private sealed class <loadWeb>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000941")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000942")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000943")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderText <>4__this;

			[Token(Token = "0x4000944")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Source src;

			[Token(Token = "0x4000945")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <uid>5__2;

			[Token(Token = "0x4000946")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x4000947")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<string> <list>5__4;

			[Token(Token = "0x1700014F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A8D")]
				[Address(RVA = "0x10116F0", Offset = "0x10116F0", VA = "0x10116F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000150")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A8F")]
				[Address(RVA = "0x1011738", Offset = "0x1011738", VA = "0x1011738", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1010720", Offset = "0x1010720", VA = "0x1010720")]
			[DebuggerHidden]
			public <loadWeb>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x101083C", Offset = "0x101083C", VA = "0x101083C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1010868", Offset = "0x1010868", VA = "0x1010868", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1011640", Offset = "0x1011640", VA = "0x1011640")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x10116F8", Offset = "0x10116F8", VA = "0x10116F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private sealed class <loadResource>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000948")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000949")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400094A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainProviderText <>4__this;

			[Token(Token = "0x400094B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Source src;

			[Token(Token = "0x400094C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <uid>5__2;

			[Token(Token = "0x400094D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<string> <list>5__3;

			[Token(Token = "0x17000151")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A93")]
				[Address(RVA = "0x1011BC4", Offset = "0x1011BC4", VA = "0x1011BC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000152")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A95")]
				[Address(RVA = "0x1011C0C", Offset = "0x1011C0C", VA = "0x1011C0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1010748", Offset = "0x1010748", VA = "0x1010748")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1011740", Offset = "0x1011740", VA = "0x1011740", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1011744", Offset = "0x1011744", VA = "0x1011744", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1011BCC", Offset = "0x1011BCC", VA = "0x1011BCC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1010140", Offset = "0x1010140", VA = "0x1010140", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x10106B0", Offset = "0x10106B0", VA = "0x10106B0", Slot = "9")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x101063C", Offset = "0x101063C", VA = "0x101063C")]
		[IteratorStateMachine(typeof(<loadWeb>d__2))]
		private IEnumerator loadWeb(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x10105C8", Offset = "0x10105C8", VA = "0x10105C8")]
		[IteratorStateMachine(typeof(<loadResource>d__3))]
		private IEnumerator loadResource(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x1010770", Offset = "0x1010770", VA = "0x1010770")]
		public DomainProviderText()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public interface IProvider
	{
		[Token(Token = "0x17000153")]
		bool isReady
		{
			[Token(Token = "0x6000A96")]
			get;
			[Token(Token = "0x6000A97")]
			set;
		}

		[Token(Token = "0x6000A98")]
		void Load();

		[Token(Token = "0x6000A99")]
		void Save();
	}
}
namespace Crosstales.BWF.Model
{
	[Serializable]
	[Token(Token = "0x2000180")]
	public class BadWords
	{
		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> BadWordList;

		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x100E660", Offset = "0x100E660", VA = "0x100E660")]
		public BadWords(Source source, IEnumerable<string> badWordList)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x1011C14", Offset = "0x1011C14", VA = "0x1011C14", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1011DEC", Offset = "0x1011DEC", VA = "0x1011DEC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x1011F3C", Offset = "0x1011F3C", VA = "0x1011F3C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x2000181")]
	public class Domains
	{
		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Source Source;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> DomainList;

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x101125C", Offset = "0x101125C", VA = "0x101125C")]
		public Domains(Source source, IEnumerable<string> domainList)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x1011F44", Offset = "0x1011F44", VA = "0x1011F44", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x101211C", Offset = "0x101211C", VA = "0x101211C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x101226C", Offset = "0x101226C", VA = "0x101226C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace Crosstales.BWF.Model.Enum
{
	[Token(Token = "0x2000182")]
	[Flags]
	public enum ManagerMask
	{
		[Token(Token = "0x4000953")]
		None = 0,
		[Token(Token = "0x4000954")]
		All = 1,
		[Token(Token = "0x4000955")]
		BadWord = 2,
		[Token(Token = "0x4000956")]
		Domain = 4,
		[Token(Token = "0x4000957")]
		Capitalization = 8,
		[Token(Token = "0x4000958")]
		Punctuation = 0x10
	}
	[Token(Token = "0x2000183")]
	public enum ReplaceMode
	{
		[Token(Token = "0x400095A")]
		Default,
		[Token(Token = "0x400095B")]
		NonLettersOrDigits,
		[Token(Token = "0x400095C")]
		LeetSpeak,
		[Token(Token = "0x400095D")]
		LeetSpeakAdvanced
	}
}
namespace Crosstales.BWF.Manager
{
	[Token(Token = "0x2000184")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_bad_word_manager.html")]
	[DisallowMultipleComponent]
	public class BadWordManager : BaseManager<BadWordManager, BadWordFilter>
	{
		[Token(Token = "0x2000186")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass50_0
		{
			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BadWordManager <>4__this;

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool result;

			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x1012CF0", Offset = "0x1012CF0", VA = "0x1012CF0")]
			public <>c__DisplayClass50_0()
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1012CF8", Offset = "0x1012CF8", VA = "0x1012CF8")]
			internal void <containsAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000187")]
		[CompilerGenerated]
		private sealed class <containsAsync>d__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass50_0 <>8__1;

			[Token(Token = "0x1700015F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ACB")]
				[Address(RVA = "0x1012ED4", Offset = "0x1012ED4", VA = "0x1012ED4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000160")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ACD")]
				[Address(RVA = "0x1012F1C", Offset = "0x1012F1C", VA = "0x1012F1C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1012B88", Offset = "0x1012B88", VA = "0x1012B88")]
			[DebuggerHidden]
			public <containsAsync>d__50(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x1012D24", Offset = "0x1012D24", VA = "0x1012D24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x1012D28", Offset = "0x1012D28", VA = "0x1012D28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x1012EDC", Offset = "0x1012EDC", VA = "0x1012EDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000188")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass51_0
		{
			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BadWordManager <>4__this;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> result;

			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x1012F24", Offset = "0x1012F24", VA = "0x1012F24")]
			public <>c__DisplayClass51_0()
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x1012F2C", Offset = "0x1012F2C", VA = "0x1012F2C")]
			internal void <getAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000189")]
		[CompilerGenerated]
		private sealed class <getAllAsync>d__51 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass51_0 <>8__1;

			[Token(Token = "0x17000161")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000AD3")]
				[Address(RVA = "0x1013100", Offset = "0x1013100", VA = "0x1013100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000162")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000AD5")]
				[Address(RVA = "0x1013148", Offset = "0x1013148", VA = "0x1013148", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x1012BB0", Offset = "0x1012BB0", VA = "0x1012BB0")]
			[DebuggerHidden]
			public <getAllAsync>d__51(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x1012F54", Offset = "0x1012F54", VA = "0x1012F54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x1012F58", Offset = "0x1012F58", VA = "0x1012F58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x1013108", Offset = "0x1013108", VA = "0x1013108", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200018A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass52_0
		{
			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BadWordManager <>4__this;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool markOnly;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string prefix;

			[Token(Token = "0x4000982")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string postfix;

			[Token(Token = "0x4000983")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string[] sourceNames;

			[Token(Token = "0x4000984")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string result;

			[Token(Token = "0x6000AD6")]
			[Address(RVA = "0x1013150", Offset = "0x1013150", VA = "0x1013150")]
			public <>c__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x1013158", Offset = "0x1013158", VA = "0x1013158")]
			internal void <replaceAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x200018B")]
		[CompilerGenerated]
		private sealed class <replaceAllAsync>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BadWordManager <>4__this;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool markOnly;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string prefix;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string postfix;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string[] sourceNames;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass52_0 <>8__1;

			[Token(Token = "0x17000163")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000ADB")]
				[Address(RVA = "0x1013348", Offset = "0x1013348", VA = "0x1013348", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000164")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000ADD")]
				[Address(RVA = "0x1013390", Offset = "0x1013390", VA = "0x1013390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x1012BD8", Offset = "0x1012BD8", VA = "0x1012BD8")]
			[DebuggerHidden]
			public <replaceAllAsync>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x101318C", Offset = "0x101318C", VA = "0x101318C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1013190", Offset = "0x1013190", VA = "0x1013190", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x1013350", Offset = "0x1013350", VA = "0x1013350", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Replace characters for bad words (default: *).")]
		[Header("Specific Settings")]
		[FormerlySerializedAs("ReplaceChars")]
		private string replaceChars;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Replace mode operations on the input string (default: Default).")]
		private ReplaceMode mode;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Remove unnecessary spaces between letters in the input string (default: false).")]
		[SerializeField]
		private bool removeSpaces;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[SerializeField]
		[Tooltip("Use simple detection algorithm. This is the way to check for Chinese, Japanese, Korean and Thai bad words (default: false).")]
		[FormerlySerializedAs("SimpleCheck")]
		private bool simpleCheck;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[FormerlySerializedAs("BadWordProviderLTR")]
		[Header("Bad Word Providers")]
		[Tooltip("List of all left-to-right providers.")]
		[SerializeField]
		private List<BadWordProvider> badWordProviderLTR;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[FormerlySerializedAs("BadWordProviderRTL")]
		[Tooltip("List of all right-to-left providers.")]
		[SerializeField]
		private List<BadWordProvider> badWordProviderRTL;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public OnGetAllCompleted OnGetAllCompleted;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public OnReplaceAllCompleted OnReplaceAllCompleted;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Thread worker;

		[Token(Token = "0x17000154")]
		public string ReplaceChars
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x1012274", Offset = "0x1012274", VA = "0x1012274")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x1012290", Offset = "0x1012290", VA = "0x1012290")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public ReplaceMode Mode
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x10122B0", Offset = "0x10122B0", VA = "0x10122B0")]
			get
			{
				return default(ReplaceMode);
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x10122CC", Offset = "0x10122CC", VA = "0x10122CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool RemoveSpaces
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x10122EC", Offset = "0x10122EC", VA = "0x10122EC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x1012308", Offset = "0x1012308", VA = "0x1012308")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool SimpleCheck
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x101232C", Offset = "0x101232C", VA = "0x101232C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x1012348", Offset = "0x1012348", VA = "0x1012348")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x101236C", Offset = "0x101236C", VA = "0x101236C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x1012374", Offset = "0x1012374", VA = "0x1012374")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x101237C", Offset = "0x101237C", VA = "0x101237C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x1012384", Offset = "0x1012384", VA = "0x1012384")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x1008EE4", Offset = "0x1008EE4", VA = "0x1008EE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public int TotalRegexCount
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x101238C", Offset = "0x101238C", VA = "0x101238C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015C")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x10124A4", Offset = "0x10124A4", VA = "0x10124A4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x10124AC", Offset = "0x10124AC", VA = "0x10124AC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x10124B4", Offset = "0x10124B4", VA = "0x10124B4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x10124BC", Offset = "0x10124BC", VA = "0x10124BC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x10125A4", Offset = "0x10125A4", VA = "0x10125A4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1012660", Offset = "0x1012660", VA = "0x1012660", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x101274C", Offset = "0x101274C", VA = "0x101274C")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x1008C48", Offset = "0x1008C48", VA = "0x1008C48")]
		public void Load()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x100AAB4", Offset = "0x100AAB4", VA = "0x100AAB4")]
		public bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x1012988", Offset = "0x1012988", VA = "0x1012988")]
		public void ContainsAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x100ACEC", Offset = "0x100ACEC", VA = "0x100ACEC")]
		public List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x1012A24", Offset = "0x1012A24", VA = "0x1012A24")]
		public void GetAllAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x100B09C", Offset = "0x100B09C", VA = "0x100B09C")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1012AC0", Offset = "0x1012AC0", VA = "0x1012AC0")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x100A668", Offset = "0x100A668", VA = "0x100A668")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x10129A8", Offset = "0x10129A8", VA = "0x10129A8")]
		[IteratorStateMachine(typeof(<containsAsync>d__50))]
		private IEnumerator containsAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x1012A44", Offset = "0x1012A44", VA = "0x1012A44")]
		[IteratorStateMachine(typeof(<getAllAsync>d__51))]
		private IEnumerator getAllAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1012AE4", Offset = "0x1012AE4", VA = "0x1012AE4")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__52))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x1012C00", Offset = "0x1012C00", VA = "0x1012C00")]
		public BadWordManager()
		{
		}
	}
	[Token(Token = "0x200018C")]
	[ExecuteInEditMode]
	public abstract class BaseManager<S, T> : Singleton<S> where S : Singleton<S> where T : BaseFilter
	{
		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[Tooltip("Disables the ordering of the 'GetAll'-method (prevent possible memory garbage).")]
		private bool disableOrdering;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T filter;

		[Token(Token = "0x17000165")]
		public bool DisableOrdering
		{
			[Token(Token = "0x6000ADE")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ADF")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public bool isReady
		{
			[Token(Token = "0x6000AE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000167")]
		protected abstract OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000AE1")]
			get;
		}

		[Token(Token = "0x17000168")]
		protected abstract OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000AE2")]
			get;
		}

		[Token(Token = "0x17000169")]
		protected abstract OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000AE3")]
			get;
		}

		[Token(Token = "0x1400000C")]
		public event ContainsComplete OnContainsComplete
		{
			[Token(Token = "0x6000AE4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AE5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event GetAllComplete OnGetAllComplete
		{
			[Token(Token = "0x6000AE6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AE7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event ReplaceAllComplete OnReplaceAllComplete
		{
			[Token(Token = "0x6000AE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000AE9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000AEA")]
		private void Start()
		{
		}

		[Token(Token = "0x6000AEB")]
		public string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000AEC")]
		protected void onContainsComplete(string text, bool result)
		{
		}

		[Token(Token = "0x6000AED")]
		protected void onGetAllComplete(string text, List<string> badWords)
		{
		}

		[Token(Token = "0x6000AEE")]
		protected void onReplaceAllComplete(string originalText, string cleanText)
		{
		}

		[Token(Token = "0x6000AEF")]
		protected BaseManager()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_capitalization_manager.html")]
	[DisallowMultipleComponent]
	public class CapitalizationManager : BaseManager<CapitalizationManager, CapitalizationFilter>
	{
		[Token(Token = "0x200018E")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool result;

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x1013918", Offset = "0x1013918", VA = "0x1013918")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x1013920", Offset = "0x1013920", VA = "0x1013920")]
			internal void <containsAsync>b__0()
			{
			}
		}

		[Token(Token = "0x200018F")]
		[CompilerGenerated]
		private sealed class <containsAsync>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x1700016E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B0A")]
				[Address(RVA = "0x1013AF4", Offset = "0x1013AF4", VA = "0x1013AF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0C")]
				[Address(RVA = "0x1013B3C", Offset = "0x1013B3C", VA = "0x1013B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x1013850", Offset = "0x1013850", VA = "0x1013850")]
			[DebuggerHidden]
			public <containsAsync>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x101394C", Offset = "0x101394C", VA = "0x101394C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1013950", Offset = "0x1013950", VA = "0x1013950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x1013AFC", Offset = "0x1013AFC", VA = "0x1013AFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> result;

			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x1013B44", Offset = "0x1013B44", VA = "0x1013B44")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x1013B4C", Offset = "0x1013B4C", VA = "0x1013B4C")]
			internal void <getAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000191")]
		[CompilerGenerated]
		private sealed class <getAllAsync>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass27_0 <>8__1;

			[Token(Token = "0x17000170")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B12")]
				[Address(RVA = "0x1013D14", Offset = "0x1013D14", VA = "0x1013D14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000171")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B14")]
				[Address(RVA = "0x1013D5C", Offset = "0x1013D5C", VA = "0x1013D5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x1013878", Offset = "0x1013878", VA = "0x1013878")]
			[DebuggerHidden]
			public <getAllAsync>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x1013B74", Offset = "0x1013B74", VA = "0x1013B74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x1013B78", Offset = "0x1013B78", VA = "0x1013B78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x1013D1C", Offset = "0x1013D1C", VA = "0x1013D1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool markOnly;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string prefix;

			[Token(Token = "0x40009AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string postfix;

			[Token(Token = "0x40009AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string result;

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x1013D64", Offset = "0x1013D64", VA = "0x1013D64")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x1013D6C", Offset = "0x1013D6C", VA = "0x1013D6C")]
			internal void <replaceAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000193")]
		[CompilerGenerated]
		private sealed class <replaceAllAsync>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CapitalizationManager <>4__this;

			[Token(Token = "0x40009B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool markOnly;

			[Token(Token = "0x40009B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string prefix;

			[Token(Token = "0x40009B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string postfix;

			[Token(Token = "0x40009B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass28_0 <>8__1;

			[Token(Token = "0x17000172")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B1A")]
				[Address(RVA = "0x1013F50", Offset = "0x1013F50", VA = "0x1013F50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000173")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B1C")]
				[Address(RVA = "0x1013F98", Offset = "0x1013F98", VA = "0x1013F98", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x10138A0", Offset = "0x10138A0", VA = "0x10138A0")]
			[DebuggerHidden]
			public <replaceAllAsync>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x1013D9C", Offset = "0x1013D9C", VA = "0x1013D9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x1013DA0", Offset = "0x1013DA0", VA = "0x1013DA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x1013F58", Offset = "0x1013F58", VA = "0x1013F58", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Specific Settings")]
		[FormerlySerializedAs("CapitalizationCharsNumber")]
		[Tooltip("Defines the number of allowed capital letters in a row. (default: 3).")]
		[SerializeField]
		private int capitalizationCharsNumber;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		[Token(Token = "0x4000995")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OnGetAllCompleted OnGetAllCompleted;

		[Token(Token = "0x4000996")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OnReplaceAllCompleted OnReplaceAllCompleted;

		[Token(Token = "0x4000997")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Thread worker;

		[Token(Token = "0x1700016A")]
		public int CapitalizationCharsNumber
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x1013398", Offset = "0x1013398", VA = "0x1013398")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x10133B4", Offset = "0x10133B4", VA = "0x10133B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x10133E4", Offset = "0x10133E4", VA = "0x10133E4", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x10133EC", Offset = "0x10133EC", VA = "0x10133EC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x10133F4", Offset = "0x10133F4", VA = "0x10133F4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x10133FC", Offset = "0x10133FC", VA = "0x10133FC", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x10134E4", Offset = "0x10134E4", VA = "0x10134E4", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x10135D0", Offset = "0x10135D0", VA = "0x10135D0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x101360C", Offset = "0x101360C", VA = "0x101360C")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x1008DD4", Offset = "0x1008DD4", VA = "0x1008DD4")]
		public void Load()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x100AB6C", Offset = "0x100AB6C", VA = "0x100AB6C")]
		public bool Contains(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x1013670", Offset = "0x1013670", VA = "0x1013670")]
		public void ContainsAsync(string text)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x100AE74", Offset = "0x100AE74", VA = "0x100AE74")]
		public List<string> GetAll(string text)
		{
			return null;
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x1013704", Offset = "0x1013704", VA = "0x1013704")]
		public void GetAllAsync(string text)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x100B1BC", Offset = "0x100B1BC", VA = "0x100B1BC")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x1013798", Offset = "0x1013798", VA = "0x1013798")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x100A788", Offset = "0x100A788", VA = "0x100A788")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x1013690", Offset = "0x1013690", VA = "0x1013690")]
		[IteratorStateMachine(typeof(<containsAsync>d__26))]
		private IEnumerator containsAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x1013724", Offset = "0x1013724", VA = "0x1013724")]
		[IteratorStateMachine(typeof(<getAllAsync>d__27))]
		private IEnumerator getAllAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x10137BC", Offset = "0x10137BC", VA = "0x10137BC")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__28))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x10138C8", Offset = "0x10138C8", VA = "0x10138C8")]
		public CapitalizationManager()
		{
		}
	}
	[Token(Token = "0x2000194")]
	[DisallowMultipleComponent]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_domain_manager.html")]
	public class DomainManager : BaseManager<DomainManager, DomainFilter>
	{
		[Token(Token = "0x2000196")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x40009C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool result;

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0x1014704", Offset = "0x1014704", VA = "0x1014704")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x101470C", Offset = "0x101470C", VA = "0x101470C")]
			internal void <containsAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000197")]
		[CompilerGenerated]
		private sealed class <containsAsync>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x40009C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass34_0 <>8__1;

			[Token(Token = "0x1700017B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B3E")]
				[Address(RVA = "0x10148E8", Offset = "0x10148E8", VA = "0x10148E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B40")]
				[Address(RVA = "0x1014930", Offset = "0x1014930", VA = "0x1014930", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x101459C", Offset = "0x101459C", VA = "0x101459C")]
			[DebuggerHidden]
			public <containsAsync>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x1014738", Offset = "0x1014738", VA = "0x1014738", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x101473C", Offset = "0x101473C", VA = "0x101473C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x10148F0", Offset = "0x10148F0", VA = "0x10148F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000198")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40009C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string[] sourceNames;

			[Token(Token = "0x40009CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<string> result;

			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x1014938", Offset = "0x1014938", VA = "0x1014938")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x1014940", Offset = "0x1014940", VA = "0x1014940")]
			internal void <getAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class <getAllAsync>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string[] sourceNames;

			[Token(Token = "0x40009D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private <>c__DisplayClass35_0 <>8__1;

			[Token(Token = "0x1700017D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B46")]
				[Address(RVA = "0x1014B14", Offset = "0x1014B14", VA = "0x1014B14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B48")]
				[Address(RVA = "0x1014B5C", Offset = "0x1014B5C", VA = "0x1014B5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x10145C4", Offset = "0x10145C4", VA = "0x10145C4")]
			[DebuggerHidden]
			public <getAllAsync>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1014968", Offset = "0x1014968", VA = "0x1014968", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x101496C", Offset = "0x101496C", VA = "0x101496C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x1014B1C", Offset = "0x1014B1C", VA = "0x1014B1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019A")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40009D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool markOnly;

			[Token(Token = "0x40009D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string prefix;

			[Token(Token = "0x40009D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string postfix;

			[Token(Token = "0x40009D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string[] sourceNames;

			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string result;

			[Token(Token = "0x6000B49")]
			[Address(RVA = "0x1014B64", Offset = "0x1014B64", VA = "0x1014B64")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x1014B6C", Offset = "0x1014B6C", VA = "0x1014B6C")]
			internal void <replaceAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x200019B")]
		[CompilerGenerated]
		private sealed class <replaceAllAsync>d__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DomainManager <>4__this;

			[Token(Token = "0x40009DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool markOnly;

			[Token(Token = "0x40009DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string prefix;

			[Token(Token = "0x40009DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string postfix;

			[Token(Token = "0x40009E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public string[] sourceNames;

			[Token(Token = "0x40009E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private <>c__DisplayClass36_0 <>8__1;

			[Token(Token = "0x1700017F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B4E")]
				[Address(RVA = "0x1014D5C", Offset = "0x1014D5C", VA = "0x1014D5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000180")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B50")]
				[Address(RVA = "0x1014DA4", Offset = "0x1014DA4", VA = "0x1014DA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x10145EC", Offset = "0x10145EC", VA = "0x10145EC")]
			[DebuggerHidden]
			public <replaceAllAsync>d__36(int <>1__state)
			{
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x1014BA0", Offset = "0x1014BA0", VA = "0x1014BA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x1014BA4", Offset = "0x1014BA4", VA = "0x1014BA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x1014D64", Offset = "0x1014D64", VA = "0x1014D64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("ReplaceChars")]
		[Header("Specific Settings")]
		[Tooltip("Replace characters for domains (default: *).")]
		[SerializeField]
		private string replaceChars;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Domain Providers")]
		[Tooltip("List of all domain providers.")]
		[SerializeField]
		[FormerlySerializedAs("DomainProvider")]
		private List<DomainProvider> domainProvider;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OnGetAllCompleted OnGetAllCompleted;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OnReplaceAllCompleted OnReplaceAllCompleted;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Thread worker;

		[Token(Token = "0x17000174")]
		public string ReplaceChars
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x1013FA0", Offset = "0x1013FA0", VA = "0x1013FA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x1013FBC", Offset = "0x1013FBC", VA = "0x1013FBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1013FDC", Offset = "0x1013FDC", VA = "0x1013FDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1013FE4", Offset = "0x1013FE4", VA = "0x1013FE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x1008EFC", Offset = "0x1008EFC", VA = "0x1008EFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		public int TotalRegexCount
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1013FEC", Offset = "0x1013FEC", VA = "0x1013FEC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000178")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x1014104", Offset = "0x1014104", VA = "0x1014104", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x101410C", Offset = "0x101410C", VA = "0x101410C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x1014114", Offset = "0x1014114", VA = "0x1014114", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x101411C", Offset = "0x101411C", VA = "0x101411C", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x1014204", Offset = "0x1014204", VA = "0x1014204")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x101424C", Offset = "0x101424C", VA = "0x101424C", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1014338", Offset = "0x1014338", VA = "0x1014338")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1008D48", Offset = "0x1008D48", VA = "0x1008D48")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x100AB10", Offset = "0x100AB10", VA = "0x100AB10")]
		public bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x101439C", Offset = "0x101439C", VA = "0x101439C")]
		public void ContainsAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x100ADB0", Offset = "0x100ADB0", VA = "0x100ADB0")]
		public List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1014438", Offset = "0x1014438", VA = "0x1014438")]
		public void GetAllAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x100B12C", Offset = "0x100B12C", VA = "0x100B12C")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x10144D4", Offset = "0x10144D4", VA = "0x10144D4")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x100A6F8", Offset = "0x100A6F8", VA = "0x100A6F8")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x10143BC", Offset = "0x10143BC", VA = "0x10143BC")]
		[IteratorStateMachine(typeof(<containsAsync>d__34))]
		private IEnumerator containsAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x1014458", Offset = "0x1014458", VA = "0x1014458")]
		[IteratorStateMachine(typeof(<getAllAsync>d__35))]
		private IEnumerator getAllAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x10144F8", Offset = "0x10144F8", VA = "0x10144F8")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__36))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1014614", Offset = "0x1014614", VA = "0x1014614")]
		public DomainManager()
		{
		}
	}
	[Token(Token = "0x200019C")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_manager_1_1_punctuation_manager.html")]
	[DisallowMultipleComponent]
	public class PunctuationManager : BaseManager<PunctuationManager, PunctuationFilter>
	{
		[Token(Token = "0x200019D")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40009E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x40009E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool result;

			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x101532C", Offset = "0x101532C", VA = "0x101532C")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x1015334", Offset = "0x1015334", VA = "0x1015334")]
			internal void <containsAsync>b__0()
			{
			}
		}

		[Token(Token = "0x200019E")]
		[CompilerGenerated]
		private sealed class <containsAsync>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x40009ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass26_0 <>8__1;

			[Token(Token = "0x17000185")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B6B")]
				[Address(RVA = "0x1015508", Offset = "0x1015508", VA = "0x1015508", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000186")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B6D")]
				[Address(RVA = "0x1015550", Offset = "0x1015550", VA = "0x1015550", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x1015264", Offset = "0x1015264", VA = "0x1015264")]
			[DebuggerHidden]
			public <containsAsync>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x1015360", Offset = "0x1015360", VA = "0x1015360", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x1015364", Offset = "0x1015364", VA = "0x1015364", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x1015510", Offset = "0x1015510", VA = "0x1015510", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200019F")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40009EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x40009F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<string> result;

			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x1015558", Offset = "0x1015558", VA = "0x1015558")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x1015560", Offset = "0x1015560", VA = "0x1015560")]
			internal void <getAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x20001A0")]
		[CompilerGenerated]
		private sealed class <getAllAsync>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x40009F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x40009F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass27_0 <>8__1;

			[Token(Token = "0x17000187")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B73")]
				[Address(RVA = "0x1015728", Offset = "0x1015728", VA = "0x1015728", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000188")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B75")]
				[Address(RVA = "0x1015770", Offset = "0x1015770", VA = "0x1015770", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x101528C", Offset = "0x101528C", VA = "0x101528C")]
			[DebuggerHidden]
			public <getAllAsync>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x1015588", Offset = "0x1015588", VA = "0x1015588", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x101558C", Offset = "0x101558C", VA = "0x101558C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x1015730", Offset = "0x1015730", VA = "0x1015730", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20001A1")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40009F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x40009F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool markOnly;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string prefix;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string postfix;

			[Token(Token = "0x40009FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string result;

			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x1015778", Offset = "0x1015778", VA = "0x1015778")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x1015780", Offset = "0x1015780", VA = "0x1015780")]
			internal void <replaceAllAsync>b__0()
			{
			}
		}

		[Token(Token = "0x20001A2")]
		[CompilerGenerated]
		private sealed class <replaceAllAsync>d__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PunctuationManager <>4__this;

			[Token(Token = "0x4000A00")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string text;

			[Token(Token = "0x4000A01")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool markOnly;

			[Token(Token = "0x4000A02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string prefix;

			[Token(Token = "0x4000A03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string postfix;

			[Token(Token = "0x4000A04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass28_0 <>8__1;

			[Token(Token = "0x17000189")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000B7B")]
				[Address(RVA = "0x1015964", Offset = "0x1015964", VA = "0x1015964", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700018A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B7D")]
				[Address(RVA = "0x10159AC", Offset = "0x10159AC", VA = "0x10159AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x10152B4", Offset = "0x10152B4", VA = "0x10152B4")]
			[DebuggerHidden]
			public <replaceAllAsync>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x10157B0", Offset = "0x10157B0", VA = "0x10157B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x10157B4", Offset = "0x10157B4", VA = "0x10157B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x101596C", Offset = "0x101596C", VA = "0x101596C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Defines the number of allowed punctuation letters in a row (default: 3).")]
		[Header("Specific Settings")]
		[FormerlySerializedAs("PunctuationCharsNumber")]
		private int punctuationCharsNumber;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Events")]
		public OnContainsCompleted OnContainsCompleted;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OnGetAllCompleted OnGetAllCompleted;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OnReplaceAllCompleted OnReplaceAllCompleted;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Thread worker;

		[Token(Token = "0x17000181")]
		public int PunctuationCharsNumber
		{
			[Token(Token = "0x6000B51")]
			[Address(RVA = "0x1014DAC", Offset = "0x1014DAC", VA = "0x1014DAC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x1014DC8", Offset = "0x1014DC8", VA = "0x1014DC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x1014DF8", Offset = "0x1014DF8", VA = "0x1014DF8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x1014E00", Offset = "0x1014E00", VA = "0x1014E00", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x1014E08", Offset = "0x1014E08", VA = "0x1014E08", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x1014E10", Offset = "0x1014E10", VA = "0x1014E10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x1014EF8", Offset = "0x1014EF8", VA = "0x1014EF8", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x1014FE4", Offset = "0x1014FE4", VA = "0x1014FE4")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x1015020", Offset = "0x1015020", VA = "0x1015020")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x1008E5C", Offset = "0x1008E5C", VA = "0x1008E5C")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x100AC2C", Offset = "0x100AC2C", VA = "0x100AC2C")]
		public bool Contains(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1015084", Offset = "0x1015084", VA = "0x1015084")]
		public void ContainsAsync(string text)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x100AF88", Offset = "0x100AF88", VA = "0x100AF88")]
		public List<string> GetAll(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1015118", Offset = "0x1015118", VA = "0x1015118")]
		public void GetAllAsync(string text)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x100B2B0", Offset = "0x100B2B0", VA = "0x100B2B0")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x10151AC", Offset = "0x10151AC", VA = "0x10151AC")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x100A87C", Offset = "0x100A87C", VA = "0x100A87C")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x10150A4", Offset = "0x10150A4", VA = "0x10150A4")]
		[IteratorStateMachine(typeof(<containsAsync>d__26))]
		private IEnumerator containsAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x1015138", Offset = "0x1015138", VA = "0x1015138")]
		[IteratorStateMachine(typeof(<getAllAsync>d__27))]
		private IEnumerator getAllAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x10151D0", Offset = "0x10151D0", VA = "0x10151D0")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__28))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x10152DC", Offset = "0x10152DC", VA = "0x10152DC")]
		public PunctuationManager()
		{
		}
	}
}
namespace Crosstales.BWF.Filter
{
	[Token(Token = "0x20001A3")]
	public class BadWordFilter : BaseFilter
	{
		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ReplaceMode Mode;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RemoveSpaces;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool SimpleCheck;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<BadWordProvider> tempBadWordProviderLTR;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly List<BadWordProvider> tempBadWordProviderRTL;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, Regex> exactBadwordsRegex;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly Dictionary<string, List<Regex>> debugExactBadwordsRegex;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly Dictionary<string, List<string>> simpleBadwords;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool ready;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool readyFirstime;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<BadWordProvider> badWordProviderLTR;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private List<BadWordProvider> badWordProviderRTL;

		[Token(Token = "0x1700018B")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x6000B7E")]
			[Address(RVA = "0x10159B4", Offset = "0x10159B4", VA = "0x10159B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x10159BC", Offset = "0x10159BC", VA = "0x10159BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x1015D64", Offset = "0x1015D64", VA = "0x1015D64")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x1015D6C", Offset = "0x1015D6C", VA = "0x1015D6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public override bool isReady
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x1016114", Offset = "0x1016114", VA = "0x1016114", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x10127B0", Offset = "0x10127B0", VA = "0x10127B0")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters = "*", ReplaceMode mode = ReplaceMode.Default, bool simpleCheck = false, bool removeSpaces = false, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x1016FF0", Offset = "0x1016FF0", VA = "0x1016FF0", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x1017C1C", Offset = "0x1017C1C", VA = "0x1017C1C", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x101B20C", Offset = "0x101B20C", VA = "0x101B20C", Slot = "15")]
		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x101CF60", Offset = "0x101CF60", VA = "0x101CF60")]
		private string replaceCapture(string text, Capture capture, bool markOnly, string prefix, string postfix, int offset)
		{
			return null;
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x1017BC8", Offset = "0x1017BC8", VA = "0x1017BC8")]
		protected string replaceText(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x101DE20", Offset = "0x101DE20", VA = "0x101DE20")]
		private static string replaceNonLettersOrDigits(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x101D0BC", Offset = "0x101D0BC", VA = "0x101D0BC")]
		private static string replaceSpacesBetweenLetters(string text, int maxTextLength = 1)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x101D2CC", Offset = "0x101D2CC", VA = "0x101D2CC")]
		private static string replaceLeetToText(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x101D81C", Offset = "0x101D81C", VA = "0x101D81C")]
		private static string replaceLeetAdvancedToText(string input)
		{
			return null;
		}
	}
	[Token(Token = "0x20001A8")]
	public abstract class BaseFilter : IFilter
	{
		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool DisableOrdering;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected readonly Dictionary<string, Source> sources;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected readonly List<string> getAllResult;

		[Token(Token = "0x1700018E")]
		public virtual List<Source> Sources
		{
			[Token(Token = "0x6000BCF")]
			[Address(RVA = "0x1020564", Offset = "0x1020564", VA = "0x1020564", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		public abstract bool isReady
		{
			[Token(Token = "0x6000BD0")]
			get;
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0x102048C", Offset = "0x102048C", VA = "0x102048C")]
		public BaseFilter(bool disableOrdering)
		{
		}

		[Token(Token = "0x6000BD1")]
		public abstract bool Contains(string text, params string[] sourceNames);

		[Token(Token = "0x6000BD2")]
		public abstract List<string> GetAll(string text, params string[] sourceNames);

		[Token(Token = "0x6000BD3")]
		public abstract string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames);

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x102080C", Offset = "0x102080C", VA = "0x102080C", Slot = "16")]
		public virtual string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x1020AD4", Offset = "0x1020AD4", VA = "0x1020AD4", Slot = "17")]
		public virtual string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x10207A4", Offset = "0x10207A4", VA = "0x10207A4")]
		protected static void logFilterNotReady()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1020AEC", Offset = "0x1020AEC", VA = "0x1020AEC")]
		protected static void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x1020CEC", Offset = "0x1020CEC", VA = "0x1020CEC")]
		protected static void logContains()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1020DD0", Offset = "0x1020DD0", VA = "0x1020DD0")]
		protected static void logGetAll()
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x1020EB4", Offset = "0x1020EB4", VA = "0x1020EB4")]
		protected static void logReplaceAll()
		{
		}
	}
	[Token(Token = "0x20001AA")]
	public class CapitalizationFilter : BaseFilter
	{
		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int characterNumber;

		[Token(Token = "0x17000190")]
		public Regex RegularExpression
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x102107C", Offset = "0x102107C", VA = "0x102107C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x1021084", Offset = "0x1021084", VA = "0x1021084")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public int CharacterNumber
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x102108C", Offset = "0x102108C", VA = "0x102108C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x1021094", Offset = "0x1021094", VA = "0x1021094")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public override bool isReady
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x1021170", Offset = "0x1021170", VA = "0x1021170", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x1021178", Offset = "0x1021178", VA = "0x1021178")]
		public CapitalizationFilter(int capitalizationCharsNumber = 3, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x10211A4", Offset = "0x10211A4", VA = "0x10211A4", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1021204", Offset = "0x1021204", VA = "0x1021204", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x10219B8", Offset = "0x10219B8", VA = "0x10219B8", Slot = "15")]
		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	public class DomainFilter : BaseFilter
	{
		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string ReplaceCharacters;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<DomainProvider> domainProvider;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly List<DomainProvider> tempDomainProvider;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<string, Regex> domainsRegex;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<string, List<Regex>> debugDomainsRegex;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool ready;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool readyFirstime;

		[Token(Token = "0x17000193")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x1022150", Offset = "0x1022150", VA = "0x1022150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x1022158", Offset = "0x1022158", VA = "0x1022158")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public override bool isReady
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x10224C8", Offset = "0x10224C8", VA = "0x10224C8", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x1022CC4", Offset = "0x1022CC4", VA = "0x1022CC4")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters = "*", bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x1022DF0", Offset = "0x1022DF0", VA = "0x1022DF0", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x102351C", Offset = "0x102351C", VA = "0x102351C", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x10255C8", Offset = "0x10255C8", VA = "0x10255C8", Slot = "15")]
		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}
	}
	[Token(Token = "0x20001B1")]
	public interface IFilter
	{
		[Token(Token = "0x17000195")]
		List<Source> Sources
		{
			[Token(Token = "0x6000C1F")]
			get;
		}

		[Token(Token = "0x17000196")]
		bool isReady
		{
			[Token(Token = "0x6000C20")]
			get;
		}

		[Token(Token = "0x6000C21")]
		bool Contains(string text, params string[] sourceNames);

		[Token(Token = "0x6000C22")]
		List<string> GetAll(string text, params string[] sourceNames);

		[Token(Token = "0x6000C23")]
		string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames);

		[Token(Token = "0x6000C24")]
		string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames);

		[Token(Token = "0x6000C25")]
		string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>");
	}
	[Token(Token = "0x20001B2")]
	public class PunctuationFilter : BaseFilter
	{
		[Token(Token = "0x4000A89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int characterNumber;

		[Token(Token = "0x17000197")]
		public Regex RegularExpression
		{
			[Token(Token = "0x6000C26")]
			[Address(RVA = "0x1027A2C", Offset = "0x1027A2C", VA = "0x1027A2C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x1027A34", Offset = "0x1027A34", VA = "0x1027A34")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public int CharacterNumber
		{
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x1027A3C", Offset = "0x1027A3C", VA = "0x1027A3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x1027A44", Offset = "0x1027A44", VA = "0x1027A44")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public override bool isReady
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x1027B20", Offset = "0x1027B20", VA = "0x1027B20", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x1027B28", Offset = "0x1027B28", VA = "0x1027B28")]
		public PunctuationFilter(int punctuationCharacterNumber = 3, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x1027B54", Offset = "0x1027B54", VA = "0x1027B54", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x1027BB4", Offset = "0x1027BB4", VA = "0x1027BB4", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x1028368", Offset = "0x1028368", VA = "0x1028368", Slot = "15")]
		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}
	}
}
namespace Crosstales.BWF.Data
{
	[Serializable]
	[Token(Token = "0x20001B4")]
	[HelpURL("https://www.crosstales.com/media/data/assets/badwordfilter/api/class_crosstales_1_1_b_w_f_1_1_data_1_1_source.html")]
	[CreateAssetMenu(fileName = "New Source", menuName = "Bad Word Filter PRO/Source", order = 1000)]
	public class Source : ScriptableObject
	{
		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Name of the source.")]
		[SerializeField]
		[Header("Information")]
		[FormerlySerializedAs("Name")]
		private string sourceName;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Culture of the source (ISO 639-1).")]
		[SerializeField]
		[FormerlySerializedAs("Culture")]
		private string culture;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Description for the source (optional).")]
		[FormerlySerializedAs("Description")]
		private string description;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Icon to represent the source (e.g. country flag, optional)")]
		[FormerlySerializedAs("Icon")]
		[SerializeField]
		private Sprite icon;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("URL")]
		[SerializeField]
		[Header("Settings")]
		[Tooltip("URL of a text file containing all regular expressions for this source. Add also the protocol-type ('http://', 'file://' etc.).")]
		private string url;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[FormerlySerializedAs("Resource")]
		[SerializeField]
		[Tooltip("Text file containing all regular expressions for this source.")]
		private TextAsset resource;

		[Token(Token = "0x1700019A")]
		public string SourceName
		{
			[Token(Token = "0x6000C36")]
			[Address(RVA = "0x1028B10", Offset = "0x1028B10", VA = "0x1028B10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x1028B18", Offset = "0x1028B18", VA = "0x1028B18")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public string Culture
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x1028B20", Offset = "0x1028B20", VA = "0x1028B20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x1028B28", Offset = "0x1028B28", VA = "0x1028B28")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public string Description
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x1028B30", Offset = "0x1028B30", VA = "0x1028B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x1028B38", Offset = "0x1028B38", VA = "0x1028B38")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public Sprite Icon
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x1028B40", Offset = "0x1028B40", VA = "0x1028B40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x1028B48", Offset = "0x1028B48", VA = "0x1028B48")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public string URL
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x1028B50", Offset = "0x1028B50", VA = "0x1028B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x1028B58", Offset = "0x1028B58", VA = "0x1028B58")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public TextAsset Resource
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x1028B60", Offset = "0x1028B60", VA = "0x1028B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x1028B68", Offset = "0x1028B68", VA = "0x1028B68")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public int RegexCount
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x1028B70", Offset = "0x1028B70", VA = "0x1028B70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x1028B78", Offset = "0x1028B78", VA = "0x1028B78")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x1028B80", Offset = "0x1028B80", VA = "0x1028B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x1028E90", Offset = "0x1028E90", VA = "0x1028E90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x102900C", Offset = "0x102900C", VA = "0x102900C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x10290FC", Offset = "0x10290FC", VA = "0x10290FC")]
		public Source()
		{
		}
	}
}
