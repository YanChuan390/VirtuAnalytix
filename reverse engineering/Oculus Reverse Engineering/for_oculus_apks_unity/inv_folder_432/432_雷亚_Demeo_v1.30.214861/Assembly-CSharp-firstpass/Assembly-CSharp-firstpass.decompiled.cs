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
	[Address(RVA = "0x10C9F30", Offset = "0x10C9F30", VA = "0x10C9F30")]
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
	[Address(RVA = "0x10CA10C", Offset = "0x10CA10C", VA = "0x10CA10C")]
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
		[Address(RVA = "0x10CA42C", Offset = "0x10CA42C", VA = "0x10CA42C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000012")]
	public Transform Trans
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x10CA398", Offset = "0x10CA398", VA = "0x10CA398")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x10CA160", Offset = "0x10CA160", VA = "0x10CA160")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x10CA164", Offset = "0x10CA164", VA = "0x10CA164")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x10CA1A8", Offset = "0x10CA1A8", VA = "0x10CA1A8")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x10CA260", Offset = "0x10CA260", VA = "0x10CA260")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x10CA4C0", Offset = "0x10CA4C0", VA = "0x10CA4C0")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200000D")]
public static class OculusAudioHelper
{
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x10CA4C8", Offset = "0x10CA4C8", VA = "0x10CA4C8")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x10CA4D0", Offset = "0x10CA4D0", VA = "0x10CA4D0")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x10CA4D4", Offset = "0x10CA4D4", VA = "0x10CA4D4")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x10CA4D8", Offset = "0x10CA4D8", VA = "0x10CA4D8")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10CA4DC", Offset = "0x10CA4DC", VA = "0x10CA4DC")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x10CA4E0", Offset = "0x10CA4E0", VA = "0x10CA4E0")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x10CA4E4", Offset = "0x10CA4E4", VA = "0x10CA4E4")]
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
		[Address(RVA = "0x10CA4E8", Offset = "0x10CA4E8", VA = "0x10CA4E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10CA4F0", Offset = "0x10CA4F0", VA = "0x10CA4F0")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10CA4F8", Offset = "0x10CA4F8", VA = "0x10CA4F8")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x10CA4FC", Offset = "0x10CA4FC", VA = "0x10CA4FC")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x10CA500", Offset = "0x10CA500", VA = "0x10CA500")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x10CA504", Offset = "0x10CA504", VA = "0x10CA504")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x10CA508", Offset = "0x10CA508", VA = "0x10CA508")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10CA50C", Offset = "0x10CA50C", VA = "0x10CA50C")]
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
		[Address(RVA = "0x10CAA68", Offset = "0x10CAA68", VA = "0x10CAA68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public Transform Trans
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x10CAFE4", Offset = "0x10CAFE4", VA = "0x10CAFE4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x10CA510", Offset = "0x10CA510", VA = "0x10CA510")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x10CA53C", Offset = "0x10CA53C", VA = "0x10CA53C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x10CA6F4", Offset = "0x10CA6F4", VA = "0x10CA6F4")]
	public void UpdateAudioVariation(SoundGroupVariation newVariation)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x10CA710", Offset = "0x10CA710", VA = "0x10CA710")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x10CA9F0", Offset = "0x10CA9F0", VA = "0x10CA9F0")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x10CAAFC", Offset = "0x10CAAFC", VA = "0x10CAAFC")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x10CAF00", Offset = "0x10CAF00", VA = "0x10CAF00")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x10CA97C", Offset = "0x10CA97C", VA = "0x10CA97C")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x10CA59C", Offset = "0x10CA59C", VA = "0x10CA59C")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x10CB078", Offset = "0x10CB078", VA = "0x10CB078")]
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
	[Address(RVA = "0x10CB090", Offset = "0x10CB090", VA = "0x10CB090")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x10CB0C0", Offset = "0x10CB0C0", VA = "0x10CB0C0")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x10CB134", Offset = "0x10CB134", VA = "0x10CB134")]
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
	[Address(RVA = "0x10CB13C", Offset = "0x10CB13C", VA = "0x10CB13C")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x10CB284", Offset = "0x10CB284", VA = "0x10CB284")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x10CBBF0", Offset = "0x10CBBF0", VA = "0x10CBBF0")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x10CB354", Offset = "0x10CB354", VA = "0x10CB354")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x10CB6E0", Offset = "0x10CB6E0", VA = "0x10CB6E0")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x10CBCB4", Offset = "0x10CBCB4", VA = "0x10CBCB4")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x10CBCB8", Offset = "0x10CBCB8", VA = "0x10CBCB8")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x10CBE24", Offset = "0x10CBE24", VA = "0x10CBE24")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x10CC020", Offset = "0x10CC020", VA = "0x10CC020")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x10CC0C8", Offset = "0x10CC0C8", VA = "0x10CC0C8")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x10CC144", Offset = "0x10CC144", VA = "0x10CC144")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x10CBEF0", Offset = "0x10CBEF0", VA = "0x10CBEF0")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x10CC1F4", Offset = "0x10CC1F4", VA = "0x10CC1F4")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x10CC39C", Offset = "0x10CC39C", VA = "0x10CC39C")]
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
	[Address(RVA = "0x10CB260", Offset = "0x10CB260", VA = "0x10CB260")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x10CC3FC", Offset = "0x10CC3FC", VA = "0x10CC3FC")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x10CC404", Offset = "0x10CC404", VA = "0x10CC404")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x10CC420", Offset = "0x10CC420", VA = "0x10CC420")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x10CC428", Offset = "0x10CC428", VA = "0x10CC428")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x10CC434", Offset = "0x10CC434", VA = "0x10CC434")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x10CC440", Offset = "0x10CC440", VA = "0x10CC440")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x10CC44C", Offset = "0x10CC44C", VA = "0x10CC44C")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x10CC454", Offset = "0x10CC454", VA = "0x10CC454")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x10CC45C", Offset = "0x10CC45C", VA = "0x10CC45C")]
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
			[Address(RVA = "0x10CCAA0", Offset = "0x10CCAA0", VA = "0x10CCAA0", Slot = "4")]
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
			[Address(RVA = "0x10CCAE8", Offset = "0x10CCAE8", VA = "0x10CCAE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x10CC4F8", Offset = "0x10CC4F8", VA = "0x10CC4F8")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x10CC530", Offset = "0x10CC530", VA = "0x10CC530", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x10CC534", Offset = "0x10CC534", VA = "0x10CC534", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x10CCAA8", Offset = "0x10CCAA8", VA = "0x10CCAA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x10CC464", Offset = "0x10CC464", VA = "0x10CC464")]
	public void Start()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x10CC484", Offset = "0x10CC484", VA = "0x10CC484")]
	[IteratorStateMachine(typeof(<timeoutCheck>d__2))]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x10CC520", Offset = "0x10CC520", VA = "0x10CC520")]
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
	[Address(RVA = "0x10CCAF0", Offset = "0x10CCAF0", VA = "0x10CCAF0")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x10CCB5C", Offset = "0x10CCB5C", VA = "0x10CCB5C")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x10CD4F0", Offset = "0x10CD4F0", VA = "0x10CD4F0")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x10CD1D0", Offset = "0x10CD1D0", VA = "0x10CD1D0")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x10CD564", Offset = "0x10CD564", VA = "0x10CD564")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x10CC694", Offset = "0x10CC694", VA = "0x10CC694")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x10CD2FC", Offset = "0x10CD2FC", VA = "0x10CD2FC")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x10CC700", Offset = "0x10CC700", VA = "0x10CC700")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x10CD5CC", Offset = "0x10CD5CC", VA = "0x10CD5CC")]
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
		[Address(RVA = "0x10CD6DC", Offset = "0x10CD6DC", VA = "0x10CD6DC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000019")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x10CD734", Offset = "0x10CD734", VA = "0x10CD734")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001A")]
	public static int tweensRunning
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x10CD78C", Offset = "0x10CD78C", VA = "0x10CD78C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001B")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x10D1704", Offset = "0x10D1704", VA = "0x10D1704")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x10CD624", Offset = "0x10CD624", VA = "0x10CD624")]
	public static void init()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x10CD67C", Offset = "0x10CD67C", VA = "0x10CD67C")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x10CD844", Offset = "0x10CD844", VA = "0x10CD844")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x10CDD74", Offset = "0x10CDD74", VA = "0x10CDD74")]
	public static void reset()
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x10CDECC", Offset = "0x10CDECC", VA = "0x10CDECC")]
	public void Update()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x10CE34C", Offset = "0x10CE34C", VA = "0x10CE34C")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x10CE3AC", Offset = "0x10CE3AC", VA = "0x10CE3AC")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x10CDF18", Offset = "0x10CDF18", VA = "0x10CDF18")]
	public static void update()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x10CEC34", Offset = "0x10CEC34", VA = "0x10CEC34")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x10CE82C", Offset = "0x10CE82C", VA = "0x10CE82C")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x10CEE5C", Offset = "0x10CEE5C", VA = "0x10CEE5C")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x10CEFC8", Offset = "0x10CEFC8", VA = "0x10CEFC8")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x10CF018", Offset = "0x10CF018", VA = "0x10CF018")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x10CF068", Offset = "0x10CF068", VA = "0x10CF068")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x10CF230", Offset = "0x10CF230", VA = "0x10CF230")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x10CF288", Offset = "0x10CF288", VA = "0x10CF288")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x10CF4A4", Offset = "0x10CF4A4", VA = "0x10CF4A4")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x10CF518", Offset = "0x10CF518", VA = "0x10CF518")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x10CF77C", Offset = "0x10CF77C", VA = "0x10CF77C")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x10CF88C", Offset = "0x10CF88C", VA = "0x10CF88C")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x10CF8E4", Offset = "0x10CF8E4", VA = "0x10CF8E4")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x10CFB10", Offset = "0x10CFB10", VA = "0x10CFB10")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x10CFD50", Offset = "0x10CFD50", VA = "0x10CFD50")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x10CFDA4", Offset = "0x10CFDA4", VA = "0x10CFDA4")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x10D0034", Offset = "0x10D0034", VA = "0x10D0034")]
	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x10D0088", Offset = "0x10D0088", VA = "0x10D0088")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x10D017C", Offset = "0x10D017C", VA = "0x10D017C")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x10D02D8", Offset = "0x10D02D8", VA = "0x10D02D8")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x10D03A8", Offset = "0x10D03A8", VA = "0x10D03A8")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x10D0478", Offset = "0x10D0478", VA = "0x10D0478")]
	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x10D04CC", Offset = "0x10D04CC", VA = "0x10D04CC")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x10D059C", Offset = "0x10D059C", VA = "0x10D059C")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x10D06EC", Offset = "0x10D06EC", VA = "0x10D06EC")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x10D08CC", Offset = "0x10D08CC", VA = "0x10D08CC")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x10D093C", Offset = "0x10D093C", VA = "0x10D093C")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x10D0A38", Offset = "0x10D0A38", VA = "0x10D0A38")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x10D0B4C", Offset = "0x10D0B4C", VA = "0x10D0B4C")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x10D117C", Offset = "0x10D117C", VA = "0x10D117C")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x10D121C", Offset = "0x10D121C", VA = "0x10D121C")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x10D128C", Offset = "0x10D128C", VA = "0x10D128C")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x10D176C", Offset = "0x10D176C", VA = "0x10D176C")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x10D1884", Offset = "0x10D1884", VA = "0x10D1884")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x10D1AC4", Offset = "0x10D1AC4", VA = "0x10D1AC4")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x10D1C6C", Offset = "0x10D1C6C", VA = "0x10D1C6C")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x10D1E94", Offset = "0x10D1E94", VA = "0x10D1E94")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x10D2048", Offset = "0x10D2048", VA = "0x10D2048")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x10D21C4", Offset = "0x10D21C4", VA = "0x10D21C4")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x10D2268", Offset = "0x10D2268", VA = "0x10D2268")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x10D23E4", Offset = "0x10D23E4", VA = "0x10D23E4")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x10D2548", Offset = "0x10D2548", VA = "0x10D2548")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x10D273C", Offset = "0x10D273C", VA = "0x10D273C")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x10D28E4", Offset = "0x10D28E4", VA = "0x10D28E4")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x10D29B4", Offset = "0x10D29B4", VA = "0x10D29B4")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x10D2BFC", Offset = "0x10D2BFC", VA = "0x10D2BFC")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x10D2D04", Offset = "0x10D2D04", VA = "0x10D2D04")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x10D2DE0", Offset = "0x10D2DE0", VA = "0x10D2DE0")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x10D2EBC", Offset = "0x10D2EBC", VA = "0x10D2EBC")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x10D2FB4", Offset = "0x10D2FB4", VA = "0x10D2FB4")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x10D3128", Offset = "0x10D3128", VA = "0x10D3128")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x10D31E0", Offset = "0x10D31E0", VA = "0x10D31E0")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x10D37CC", Offset = "0x10D37CC", VA = "0x10D37CC")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x10D38A0", Offset = "0x10D38A0", VA = "0x10D38A0")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x10D3A4C", Offset = "0x10D3A4C", VA = "0x10D3A4C")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x10D3BA0", Offset = "0x10D3BA0", VA = "0x10D3BA0")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x10D3C74", Offset = "0x10D3C74", VA = "0x10D3C74")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x10D3E68", Offset = "0x10D3E68", VA = "0x10D3E68")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x10D3FF4", Offset = "0x10D3FF4", VA = "0x10D3FF4")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x10D4180", Offset = "0x10D4180", VA = "0x10D4180")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x10D42E0", Offset = "0x10D42E0", VA = "0x10D42E0")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x10D4444", Offset = "0x10D4444", VA = "0x10D4444")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x10D45A8", Offset = "0x10D45A8", VA = "0x10D45A8")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x10D471C", Offset = "0x10D471C", VA = "0x10D471C")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x10D4958", Offset = "0x10D4958", VA = "0x10D4958")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x10D4ABC", Offset = "0x10D4ABC", VA = "0x10D4ABC")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x10D4C20", Offset = "0x10D4C20", VA = "0x10D4C20")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x10D4D84", Offset = "0x10D4D84", VA = "0x10D4D84")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x10D4E58", Offset = "0x10D4E58", VA = "0x10D4E58")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x10D4F2C", Offset = "0x10D4F2C", VA = "0x10D4F2C")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x10D5118", Offset = "0x10D5118", VA = "0x10D5118")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x10D528C", Offset = "0x10D528C", VA = "0x10D528C")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x10D540C", Offset = "0x10D540C", VA = "0x10D540C")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x10D5580", Offset = "0x10D5580", VA = "0x10D5580")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x10D56E4", Offset = "0x10D56E4", VA = "0x10D56E4")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x10D5848", Offset = "0x10D5848", VA = "0x10D5848")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x10D59AC", Offset = "0x10D59AC", VA = "0x10D59AC")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x10D5B60", Offset = "0x10D5B60", VA = "0x10D5B60")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x10D5CF0", Offset = "0x10D5CF0", VA = "0x10D5CF0")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x10D5E64", Offset = "0x10D5E64", VA = "0x10D5E64")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x10D5FF0", Offset = "0x10D5FF0", VA = "0x10D5FF0")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x10D6154", Offset = "0x10D6154", VA = "0x10D6154")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x10D62B8", Offset = "0x10D62B8", VA = "0x10D62B8")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x10D641C", Offset = "0x10D641C", VA = "0x10D641C")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x10D6588", Offset = "0x10D6588", VA = "0x10D6588")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x10D6634", Offset = "0x10D6634", VA = "0x10D6634")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x10D6894", Offset = "0x10D6894", VA = "0x10D6894")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x10D695C", Offset = "0x10D695C", VA = "0x10D695C")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x10D6BB4", Offset = "0x10D6BB4", VA = "0x10D6BB4")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x10D6CDC", Offset = "0x10D6CDC", VA = "0x10D6CDC")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x10D6E04", Offset = "0x10D6E04", VA = "0x10D6E04")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x10D6F40", Offset = "0x10D6F40", VA = "0x10D6F40")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x10D707C", Offset = "0x10D707C", VA = "0x10D707C")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x10D71B0", Offset = "0x10D71B0", VA = "0x10D71B0")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x10D72F0", Offset = "0x10D72F0", VA = "0x10D72F0")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x10D7440", Offset = "0x10D7440", VA = "0x10D7440")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x10D7638", Offset = "0x10D7638", VA = "0x10D7638")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x10D7734", Offset = "0x10D7734", VA = "0x10D7734")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x10D78E8", Offset = "0x10D78E8", VA = "0x10D78E8")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x10D7A70", Offset = "0x10D7A70", VA = "0x10D7A70")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x10D7BF8", Offset = "0x10D7BF8", VA = "0x10D7BF8")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x10D7D80", Offset = "0x10D7D80", VA = "0x10D7D80")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x10D7F50", Offset = "0x10D7F50", VA = "0x10D7F50")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x10D8058", Offset = "0x10D8058", VA = "0x10D8058")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x10D8134", Offset = "0x10D8134", VA = "0x10D8134")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x10D82E8", Offset = "0x10D82E8", VA = "0x10D82E8")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x10D8480", Offset = "0x10D8480", VA = "0x10D8480")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x10D8614", Offset = "0x10D8614", VA = "0x10D8614")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x10D879C", Offset = "0x10D879C", VA = "0x10D879C")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x10D8950", Offset = "0x10D8950", VA = "0x10D8950")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x10D8998", Offset = "0x10D8998", VA = "0x10D8998")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x10D8A70", Offset = "0x10D8A70", VA = "0x10D8A70")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x10D8A88", Offset = "0x10D8A88", VA = "0x10D8A88")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x10D8A98", Offset = "0x10D8A98", VA = "0x10D8A98")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x10D8AE8", Offset = "0x10D8AE8", VA = "0x10D8AE8")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x10D8B68", Offset = "0x10D8B68", VA = "0x10D8B68")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x10D8B8C", Offset = "0x10D8B8C", VA = "0x10D8B8C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x10D8BF0", Offset = "0x10D8BF0", VA = "0x10D8BF0")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x10D8CA0", Offset = "0x10D8CA0", VA = "0x10D8CA0")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x10D8CB4", Offset = "0x10D8CB4", VA = "0x10D8CB4")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x10D8CD0", Offset = "0x10D8CD0", VA = "0x10D8CD0")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x10D8D24", Offset = "0x10D8D24", VA = "0x10D8D24")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x10D8D5C", Offset = "0x10D8D5C", VA = "0x10D8D5C")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x10D8D74", Offset = "0x10D8D74", VA = "0x10D8D74")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x10D8D9C", Offset = "0x10D8D9C", VA = "0x10D8D9C")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x10D8DF4", Offset = "0x10D8DF4", VA = "0x10D8DF4")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x10D8E10", Offset = "0x10D8E10", VA = "0x10D8E10")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x10D8E38", Offset = "0x10D8E38", VA = "0x10D8E38")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x10D8E94", Offset = "0x10D8E94", VA = "0x10D8E94")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x10D8EB4", Offset = "0x10D8EB4", VA = "0x10D8EB4")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x10D8EE4", Offset = "0x10D8EE4", VA = "0x10D8EE4")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x10D8F4C", Offset = "0x10D8F4C", VA = "0x10D8F4C")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x10D8F84", Offset = "0x10D8F84", VA = "0x10D8F84")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x10D8FB8", Offset = "0x10D8FB8", VA = "0x10D8FB8")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x10D8FFC", Offset = "0x10D8FFC", VA = "0x10D8FFC")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x10D9034", Offset = "0x10D9034", VA = "0x10D9034")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x10D906C", Offset = "0x10D906C", VA = "0x10D906C")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x10D90DC", Offset = "0x10D90DC", VA = "0x10D90DC")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x10D9104", Offset = "0x10D9104", VA = "0x10D9104")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x10D912C", Offset = "0x10D912C", VA = "0x10D912C")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x10D9180", Offset = "0x10D9180", VA = "0x10D9180")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x10D9208", Offset = "0x10D9208", VA = "0x10D9208")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x10D92D0", Offset = "0x10D92D0", VA = "0x10D92D0")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x10D9384", Offset = "0x10D9384", VA = "0x10D9384")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x10D93B8", Offset = "0x10D93B8", VA = "0x10D93B8")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x10D93F8", Offset = "0x10D93F8", VA = "0x10D93F8")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x10D9490", Offset = "0x10D9490", VA = "0x10D9490")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x10D9568", Offset = "0x10D9568", VA = "0x10D9568")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x10D9638", Offset = "0x10D9638", VA = "0x10D9638")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x10D9788", Offset = "0x10D9788", VA = "0x10D9788")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x10D97F0", Offset = "0x10D97F0", VA = "0x10D97F0")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x10D9C2C", Offset = "0x10D9C2C", VA = "0x10D9C2C")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x10D9E94", Offset = "0x10D9E94", VA = "0x10D9E94")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x10D9C94", Offset = "0x10D9C94", VA = "0x10D9C94")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x10D9F58", Offset = "0x10D9F58", VA = "0x10D9F58")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x10D9FB0", Offset = "0x10D9FB0", VA = "0x10D9FB0")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x10DA1CC", Offset = "0x10DA1CC", VA = "0x10DA1CC")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200001A")]
public class LTUtility
{
	[Token(Token = "0x600012F")]
	[Address(RVA = "0x10DA75C", Offset = "0x10DA75C", VA = "0x10DA75C")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x10DA7F8", Offset = "0x10DA7F8", VA = "0x10DA7F8")]
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
	[Address(RVA = "0x10DA800", Offset = "0x10DA800", VA = "0x10DA800")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x10DAAF0", Offset = "0x10DAAF0", VA = "0x10DAAF0")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x10DAA98", Offset = "0x10DAA98", VA = "0x10DAA98")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x10DAC10", Offset = "0x10DAC10", VA = "0x10DAC10")]
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
		[Address(RVA = "0x10DAC30", Offset = "0x10DAC30", VA = "0x10DAC30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x10DAC28", Offset = "0x10DAC28", VA = "0x10DAC28")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x10D341C", Offset = "0x10D341C", VA = "0x10D341C")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x10D3448", Offset = "0x10D3448", VA = "0x10D3448")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x10DAC38", Offset = "0x10DAC38", VA = "0x10DAC38")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x10DACFC", Offset = "0x10DACFC", VA = "0x10DACFC")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x10DADB0", Offset = "0x10DADB0", VA = "0x10DADB0")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x10DAE64", Offset = "0x10DAE64", VA = "0x10DAE64")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x10DAED0", Offset = "0x10DAED0", VA = "0x10DAED0")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x10DAF6C", Offset = "0x10DAF6C", VA = "0x10DAF6C")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x10DAFD8", Offset = "0x10DAFD8", VA = "0x10DAFD8")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x10DB0C0", Offset = "0x10DB0C0", VA = "0x10DB0C0")]
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
	[Address(RVA = "0x10D3B68", Offset = "0x10D3B68", VA = "0x10D3B68")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x10DB5AC", Offset = "0x10DB5AC", VA = "0x10DB5AC")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x10DB1A0", Offset = "0x10DB1A0", VA = "0x10DB1A0")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x10DB7F0", Offset = "0x10DB7F0", VA = "0x10DB7F0")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x10DB5EC", Offset = "0x10DB5EC", VA = "0x10DB5EC")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x10DB8EC", Offset = "0x10DB8EC", VA = "0x10DB8EC")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x10DBA18", Offset = "0x10DBA18", VA = "0x10DBA18")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x10DBA30", Offset = "0x10DBA30", VA = "0x10DBA30")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x10DBAE4", Offset = "0x10DBAE4", VA = "0x10DBAE4")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x10DBC1C", Offset = "0x10DBC1C", VA = "0x10DBC1C")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x10DBC88", Offset = "0x10DBC88", VA = "0x10DBC88")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x10DBD24", Offset = "0x10DBD24", VA = "0x10DBD24")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x10DBD90", Offset = "0x10DBD90", VA = "0x10DBD90")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x10DBE50", Offset = "0x10DBE50", VA = "0x10DBE50")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x10DBF04", Offset = "0x10DBF04", VA = "0x10DBF04")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x10DC050", Offset = "0x10DC050", VA = "0x10DC050")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x10DC280", Offset = "0x10DC280", VA = "0x10DC280")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x10DC290", Offset = "0x10DC290", VA = "0x10DC290")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x10DC458", Offset = "0x10DC458", VA = "0x10DC458")]
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
		[Address(RVA = "0x10DCD0C", Offset = "0x10DCD0C", VA = "0x10DCD0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001E")]
	public int id
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x10CED04", Offset = "0x10CED04", VA = "0x10CED04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001F")]
	public float x
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x10DCD24", Offset = "0x10DCD24", VA = "0x10DCD24")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x10DCD30", Offset = "0x10DCD30", VA = "0x10DCD30")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public float y
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x10DCD3C", Offset = "0x10DCD3C", VA = "0x10DCD3C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x10DCD48", Offset = "0x10DCD48", VA = "0x10DCD48")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public float width
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x10DCD54", Offset = "0x10DCD54", VA = "0x10DCD54")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x10DCD60", Offset = "0x10DCD60", VA = "0x10DCD60")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public float height
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x10DCD6C", Offset = "0x10DCD6C", VA = "0x10DCD6C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x10DCD78", Offset = "0x10DCD78", VA = "0x10DCD78")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Rect rect
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x10DCD84", Offset = "0x10DCD84", VA = "0x10DCD84")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x10DCF6C", Offset = "0x10DCF6C", VA = "0x10DCF6C")]
		set
		{
		}
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x10DC68C", Offset = "0x10DC68C", VA = "0x10DC68C")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x10DC79C", Offset = "0x10DC79C", VA = "0x10DC79C")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x10DC834", Offset = "0x10DC834", VA = "0x10DC834")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x10DC8F8", Offset = "0x10DC8F8", VA = "0x10DC8F8")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x10DC9C4", Offset = "0x10DC9C4", VA = "0x10DC9C4")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x10DCD1C", Offset = "0x10DCD1C", VA = "0x10DCD1C")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x10DC730", Offset = "0x10DC730", VA = "0x10DC730")]
	public void reset()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x10DCAA8", Offset = "0x10DCAA8", VA = "0x10DCAA8")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x10DCF78", Offset = "0x10DCF78", VA = "0x10DCF78")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x10DCF94", Offset = "0x10DCF94", VA = "0x10DCF94")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x10DCFA0", Offset = "0x10DCFA0", VA = "0x10DCFA0")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x10DCFB4", Offset = "0x10DCFB4", VA = "0x10DCFB4")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x10DCFBC", Offset = "0x10DCFBC", VA = "0x10DCFBC")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x10DCFD8", Offset = "0x10DCFD8", VA = "0x10DCFD8")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x10DCFEC", Offset = "0x10DCFEC", VA = "0x10DCFEC")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x10DD054", Offset = "0x10DD054", VA = "0x10DD054")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x10DD060", Offset = "0x10DD060", VA = "0x10DD060", Slot = "3")]
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
	[Address(RVA = "0x10DA194", Offset = "0x10DA194", VA = "0x10DA194")]
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
	[Address(RVA = "0x10DD3A0", Offset = "0x10DD3A0", VA = "0x10DD3A0")]
	public static void init()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x10DD494", Offset = "0x10DD494", VA = "0x10DD494")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x10CE3F8", Offset = "0x10CE3F8", VA = "0x10CE3F8")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x10DD61C", Offset = "0x10DD61C", VA = "0x10DD61C")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x10DDF5C", Offset = "0x10DDF5C", VA = "0x10DDF5C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x10CED10", Offset = "0x10CED10", VA = "0x10CED10")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x10DE038", Offset = "0x10DE038", VA = "0x10DE038")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x10DE120", Offset = "0x10DE120", VA = "0x10DE120")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x10DE1E4", Offset = "0x10DE1E4", VA = "0x10DE1E4")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x10DE604", Offset = "0x10DE604", VA = "0x10DE604")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x10DE6C8", Offset = "0x10DE6C8", VA = "0x10DE6C8")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x10DE26C", Offset = "0x10DE26C", VA = "0x10DE26C")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10DE74C", Offset = "0x10DE74C", VA = "0x10DE74C")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x10DEA0C", Offset = "0x10DEA0C", VA = "0x10DEA0C")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x10DEB90", Offset = "0x10DEB90", VA = "0x10DEB90")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x10DEB20", Offset = "0x10DEB20", VA = "0x10DEB20")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x10DEC58", Offset = "0x10DEC58", VA = "0x10DEC58")]
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
		[Address(RVA = "0x10DECCC", Offset = "0x10DECCC", VA = "0x10DECCC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x10DECD8", Offset = "0x10DECD8", VA = "0x10DECD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Vector3 to
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x10DECE4", Offset = "0x10DECE4", VA = "0x10DECE4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x10DECF0", Offset = "0x10DECF0", VA = "0x10DECF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x10DECFC", Offset = "0x10DECFC", VA = "0x10DECFC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x10DED04", Offset = "0x10DED04", VA = "0x10DED04")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x10DED0C", Offset = "0x10DED0C", VA = "0x10DED0C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x10DED14", Offset = "0x10DED14", VA = "0x10DED14")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public int uniqueId
	{
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x10CECF4", Offset = "0x10CECF4", VA = "0x10CECF4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	public int id
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x10CE81C", Offset = "0x10CE81C", VA = "0x10CE81C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002A")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x10DF7FC", Offset = "0x10DF7FC", VA = "0x10DF7FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x10DF804", Offset = "0x10DF804", VA = "0x10DF804")]
		set
		{
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x10DED1C", Offset = "0x10DED1C", VA = "0x10DED1C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x10CDCF8", Offset = "0x10CDCF8", VA = "0x10CDCF8")]
	public LTDescr()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x10DF738", Offset = "0x10DF738", VA = "0x10DF738")]
	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x10D15A4", Offset = "0x10D15A4", VA = "0x10D15A4")]
	public void reset()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x10D420C", Offset = "0x10D420C", VA = "0x10D420C")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x10D436C", Offset = "0x10D436C", VA = "0x10D436C")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x10D44D0", Offset = "0x10D44D0", VA = "0x10D44D0")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x10D49E4", Offset = "0x10D49E4", VA = "0x10D49E4")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x10D4B48", Offset = "0x10D4B48", VA = "0x10D4B48")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x10D4CAC", Offset = "0x10D4CAC", VA = "0x10D4CAC")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x10DF80C", Offset = "0x10DF80C", VA = "0x10DF80C")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x10D3344", Offset = "0x10D3344", VA = "0x10D3344")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x10D4880", Offset = "0x10D4880", VA = "0x10D4880")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x10D3974", Offset = "0x10D3974", VA = "0x10D3974")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x10D3D90", Offset = "0x10D3D90", VA = "0x10D3D90")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x10D607C", Offset = "0x10D607C", VA = "0x10D607C")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x10D61E0", Offset = "0x10D61E0", VA = "0x10D61E0")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x10D6344", Offset = "0x10D6344", VA = "0x10D6344")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x10D560C", Offset = "0x10D560C", VA = "0x10D560C")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x10D5770", Offset = "0x10D5770", VA = "0x10D5770")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x10D58D4", Offset = "0x10D58D4", VA = "0x10D58D4")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x10D5A88", Offset = "0x10D5A88", VA = "0x10D5A88")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x10D5C18", Offset = "0x10D5C18", VA = "0x10D5C18")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x10D1B94", Offset = "0x10D1B94", VA = "0x10D1B94")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x10D20EC", Offset = "0x10D20EC", VA = "0x10D20EC")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x10D2470", Offset = "0x10D2470", VA = "0x10D2470")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x10D2644", Offset = "0x10D2644", VA = "0x10D2644")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x10D6A94", Offset = "0x10D6A94", VA = "0x10D6A94")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x10D280C", Offset = "0x10D280C", VA = "0x10D280C")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x10D86C4", Offset = "0x10D86C4", VA = "0x10D86C4")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x10D230C", Offset = "0x10D230C", VA = "0x10D230C")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x10D8878", Offset = "0x10D8878", VA = "0x10D8878")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x10D7998", Offset = "0x10D7998", VA = "0x10D7998")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x10D7B20", Offset = "0x10D7B20", VA = "0x10D7B20")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x10D7CA8", Offset = "0x10D7CA8", VA = "0x10D7CA8")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x10DF814", Offset = "0x10DF814", VA = "0x10DF814")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x10D7E78", Offset = "0x10D7E78", VA = "0x10D7E78")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x10D8210", Offset = "0x10D8210", VA = "0x10D8210")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x10D198C", Offset = "0x10D198C", VA = "0x10D198C")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x10D77F4", Offset = "0x10D77F4", VA = "0x10D77F4")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x10D83A8", Offset = "0x10D83A8", VA = "0x10D83A8")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x10D853C", Offset = "0x10D853C", VA = "0x10D853C")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x10DF850", Offset = "0x10DF850", VA = "0x10DF850")]
	private void callback()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x10D2A8C", Offset = "0x10D2A8C", VA = "0x10D2A8C")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x10D6724", Offset = "0x10D6724", VA = "0x10D6724")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x10D3050", Offset = "0x10D3050", VA = "0x10D3050")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x10D4644", Offset = "0x10D4644", VA = "0x10D4644")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x10D5040", Offset = "0x10D5040", VA = "0x10D5040")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x10D51B4", Offset = "0x10D51B4", VA = "0x10D51B4")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x10D54A8", Offset = "0x10D54A8", VA = "0x10D54A8")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x10D5D8C", Offset = "0x10D5D8C", VA = "0x10D5D8C")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x10D3F1C", Offset = "0x10D3F1C", VA = "0x10D3F1C")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x10D40A8", Offset = "0x10D40A8", VA = "0x10D40A8")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x10D5F18", Offset = "0x10D5F18", VA = "0x10D5F18")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x10D1F48", Offset = "0x10D1F48", VA = "0x10D1F48")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x10D5334", Offset = "0x10D5334", VA = "0x10D5334")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x10D7538", Offset = "0x10D7538", VA = "0x10D7538")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x10DF8C8", Offset = "0x10DF8C8", VA = "0x10DF8C8")]
	private void init()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x10DFA0C", Offset = "0x10DFA0C", VA = "0x10DFA0C")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x10DFB00", Offset = "0x10DFB00", VA = "0x10DFB00")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x10CE550", Offset = "0x10CE550", VA = "0x10CE550")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x10CEB3C", Offset = "0x10CEB3C", VA = "0x10CEB3C")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x10D6B6C", Offset = "0x10D6B6C", VA = "0x10D6B6C")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x10DFB18", Offset = "0x10DFB18", VA = "0x10DFB18")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x10DFF90", Offset = "0x10DFF90", VA = "0x10DFF90")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x10E0374", Offset = "0x10E0374", VA = "0x10E0374")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x10E07B4", Offset = "0x10E07B4", VA = "0x10E07B4")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x10E0B8C", Offset = "0x10E0B8C", VA = "0x10E0B8C")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x10E0F8C", Offset = "0x10E0F8C", VA = "0x10E0F8C")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x10E13C4", Offset = "0x10E13C4", VA = "0x10E13C4")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x10E177C", Offset = "0x10E177C", VA = "0x10E177C")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x10E1AFC", Offset = "0x10E1AFC", VA = "0x10E1AFC")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x10E1EB8", Offset = "0x10E1EB8", VA = "0x10E1EB8")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x10D0164", Offset = "0x10D0164", VA = "0x10D0164")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x10D046C", Offset = "0x10D046C", VA = "0x10D046C")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x10D5A68", Offset = "0x10D5A68", VA = "0x10D5A68")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x10E1F14", Offset = "0x10E1F14", VA = "0x10E1F14")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x10E1F1C", Offset = "0x10E1F1C", VA = "0x10E1F1C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x10E2058", Offset = "0x10E2058", VA = "0x10E2058")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x10E3404", Offset = "0x10E3404", VA = "0x10E3404")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x10E2180", Offset = "0x10E2180", VA = "0x10E2180")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x10E20EC", Offset = "0x10E20EC", VA = "0x10E20EC")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x10E2214", Offset = "0x10E2214", VA = "0x10E2214")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x10E22A8", Offset = "0x10E22A8", VA = "0x10E22A8")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x10E233C", Offset = "0x10E233C", VA = "0x10E233C")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x10E23D0", Offset = "0x10E23D0", VA = "0x10E23D0")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x10E2464", Offset = "0x10E2464", VA = "0x10E2464")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x10E24F8", Offset = "0x10E24F8", VA = "0x10E24F8")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x10E258C", Offset = "0x10E258C", VA = "0x10E258C")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x10E2620", Offset = "0x10E2620", VA = "0x10E2620")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x10E26B4", Offset = "0x10E26B4", VA = "0x10E26B4")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x10E2748", Offset = "0x10E2748", VA = "0x10E2748")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x10E27DC", Offset = "0x10E27DC", VA = "0x10E27DC")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x10E2870", Offset = "0x10E2870", VA = "0x10E2870")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x10E2904", Offset = "0x10E2904", VA = "0x10E2904")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x10E2998", Offset = "0x10E2998", VA = "0x10E2998")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x10E2A2C", Offset = "0x10E2A2C", VA = "0x10E2A2C")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x10E2AC0", Offset = "0x10E2AC0", VA = "0x10E2AC0")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x10E2B54", Offset = "0x10E2B54", VA = "0x10E2B54")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x10E2BE8", Offset = "0x10E2BE8", VA = "0x10E2BE8")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x10E2C7C", Offset = "0x10E2C7C", VA = "0x10E2C7C")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x10E2D10", Offset = "0x10E2D10", VA = "0x10E2D10")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x10E2DA4", Offset = "0x10E2DA4", VA = "0x10E2DA4")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x10E2E38", Offset = "0x10E2E38", VA = "0x10E2E38")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x10E2ECC", Offset = "0x10E2ECC", VA = "0x10E2ECC")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x10E2F60", Offset = "0x10E2F60", VA = "0x10E2F60")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x10E2FF4", Offset = "0x10E2FF4", VA = "0x10E2FF4")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x10E3088", Offset = "0x10E3088", VA = "0x10E3088")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x10E311C", Offset = "0x10E311C", VA = "0x10E311C")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x10E31B0", Offset = "0x10E31B0", VA = "0x10E31B0")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x10E3244", Offset = "0x10E3244", VA = "0x10E3244")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x10E3324", Offset = "0x10E3324", VA = "0x10E3324")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x10E3498", Offset = "0x10E3498", VA = "0x10E3498")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x10E3558", Offset = "0x10E3558", VA = "0x10E3558")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x10E35FC", Offset = "0x10E35FC", VA = "0x10E35FC")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x10E3674", Offset = "0x10E3674", VA = "0x10E3674")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x10E36F8", Offset = "0x10E36F8", VA = "0x10E36F8")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x10E3770", Offset = "0x10E3770", VA = "0x10E3770")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x10E386C", Offset = "0x10E386C", VA = "0x10E386C")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x10E38E8", Offset = "0x10E38E8", VA = "0x10E38E8")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x10E3974", Offset = "0x10E3974", VA = "0x10E3974")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x10E3A20", Offset = "0x10E3A20", VA = "0x10E3A20")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x10E3AA0", Offset = "0x10E3AA0", VA = "0x10E3AA0")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x10E3B30", Offset = "0x10E3B30", VA = "0x10E3B30")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x10E3C04", Offset = "0x10E3C04", VA = "0x10E3C04")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x10E3C88", Offset = "0x10E3C88", VA = "0x10E3C88")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x10E3D1C", Offset = "0x10E3D1C", VA = "0x10E3D1C")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x10E3DD8", Offset = "0x10E3DD8", VA = "0x10E3DD8")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x10E3E98", Offset = "0x10E3E98", VA = "0x10E3E98")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x10E3F4C", Offset = "0x10E3F4C", VA = "0x10E3F4C")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x10E3FDC", Offset = "0x10E3FDC", VA = "0x10E3FDC")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x10E4064", Offset = "0x10E4064", VA = "0x10E4064")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x10E40EC", Offset = "0x10E40EC", VA = "0x10E40EC")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x10E41B8", Offset = "0x10E41B8", VA = "0x10E41B8")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x10E4248", Offset = "0x10E4248", VA = "0x10E4248")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x10E42D4", Offset = "0x10E42D4", VA = "0x10E42D4")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x10E43A4", Offset = "0x10E43A4", VA = "0x10E43A4")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x10E44C0", Offset = "0x10E44C0", VA = "0x10E44C0")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x10E4610", Offset = "0x10E4610", VA = "0x10E4610")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x10E47D8", Offset = "0x10E47D8", VA = "0x10E47D8")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x10E4880", Offset = "0x10E4880", VA = "0x10E4880")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x10E4928", Offset = "0x10E4928", VA = "0x10E4928")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x10E4A2C", Offset = "0x10E4A2C", VA = "0x10E4A2C")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x10E4B20", Offset = "0x10E4B20", VA = "0x10E4B20")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x10E4C14", Offset = "0x10E4C14", VA = "0x10E4C14")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x10E4D08", Offset = "0x10E4D08", VA = "0x10E4D08")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x10E4D10", Offset = "0x10E4D10", VA = "0x10E4D10")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x10E4D18", Offset = "0x10E4D18", VA = "0x10E4D18")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x10E4D20", Offset = "0x10E4D20", VA = "0x10E4D20")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x10D6864", Offset = "0x10D6864", VA = "0x10D6864")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x10D5018", Offset = "0x10D5018", VA = "0x10D5018")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x10D64C4", Offset = "0x10D64C4", VA = "0x10D64C4")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x10E4DCC", Offset = "0x10E4DCC", VA = "0x10E4DCC")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x10E4DD8", Offset = "0x10E4DD8", VA = "0x10E4DD8")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x10D6BA8", Offset = "0x10D6BA8", VA = "0x10D6BA8")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x10D16F8", Offset = "0x10D16F8", VA = "0x10D16F8")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x10E4DE4", Offset = "0x10E4DE4", VA = "0x10E4DE4")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x10E4DEC", Offset = "0x10E4DEC", VA = "0x10E4DEC")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x10E4E08", Offset = "0x10E4E08", VA = "0x10E4E08")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x10D1A80", Offset = "0x10D1A80", VA = "0x10D1A80")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x10E4E3C", Offset = "0x10E4E3C", VA = "0x10E4E3C")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x10E4E44", Offset = "0x10E4E44", VA = "0x10E4E44")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x10E4E54", Offset = "0x10E4E54", VA = "0x10E4E54")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x10E4E64", Offset = "0x10E4E64", VA = "0x10E4E64")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x10E4E74", Offset = "0x10E4E74", VA = "0x10E4E74")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x10E4E84", Offset = "0x10E4E84", VA = "0x10E4E84")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x10E4E94", Offset = "0x10E4E94", VA = "0x10E4E94")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x10E4EA0", Offset = "0x10E4EA0", VA = "0x10E4EA0")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x10E4EC0", Offset = "0x10E4EC0", VA = "0x10E4EC0")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x10E4EC8", Offset = "0x10E4EC8", VA = "0x10E4EC8")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x10E4EE8", Offset = "0x10E4EE8", VA = "0x10E4EE8")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x10D2BCC", Offset = "0x10D2BCC", VA = "0x10D2BCC")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x10D2CD4", Offset = "0x10D2CD4", VA = "0x10D2CD4")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x10E4F14", Offset = "0x10E4F14", VA = "0x10E4F14")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x10E4F68", Offset = "0x10E4F68", VA = "0x10E4F68")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x10D6CAC", Offset = "0x10D6CAC", VA = "0x10D6CAC")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x10D6DD4", Offset = "0x10D6DD4", VA = "0x10D6DD4")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x10E4F98", Offset = "0x10E4F98", VA = "0x10E4F98")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x10D7180", Offset = "0x10D7180", VA = "0x10D7180")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x10D72C0", Offset = "0x10D72C0", VA = "0x10D72C0")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x10D6F10", Offset = "0x10D6F10", VA = "0x10D6F10")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x10D704C", Offset = "0x10D704C", VA = "0x10D704C")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x10E4FC8", Offset = "0x10E4FC8", VA = "0x10E4FC8")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x10E4FF8", Offset = "0x10E4FF8", VA = "0x10E4FF8")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x10D73EC", Offset = "0x10D73EC", VA = "0x10D73EC")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x10E5028", Offset = "0x10E5028", VA = "0x10E5028")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x10E507C", Offset = "0x10E507C", VA = "0x10E507C")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x10E50D0", Offset = "0x10E50D0", VA = "0x10E50D0")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x10E5124", Offset = "0x10E5124", VA = "0x10E5124")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x10E514C", Offset = "0x10E514C", VA = "0x10E514C")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x10E521C", Offset = "0x10E521C", VA = "0x10E521C")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x10D2020", Offset = "0x10D2020", VA = "0x10D2020")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x10E5274", Offset = "0x10E5274", VA = "0x10E5274")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x10E5318", Offset = "0x10E5318", VA = "0x10E5318")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x10D271C", Offset = "0x10D271C", VA = "0x10D271C")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x10D2FA8", Offset = "0x10D2FA8", VA = "0x10D2FA8")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x10D7610", Offset = "0x10D7610", VA = "0x10D7610")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x10E4E30", Offset = "0x10E4E30", VA = "0x10E4E30")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x10E5340", Offset = "0x10E5340", VA = "0x10E5340")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x10D78CC", Offset = "0x10D78CC", VA = "0x10D78CC")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x10D1A64", Offset = "0x10D1A64", VA = "0x10D1A64")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x10E534C", Offset = "0x10E534C", VA = "0x10E534C")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x10E5374", Offset = "0x10E5374", VA = "0x10E5374")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x10E539C", Offset = "0x10E539C", VA = "0x10E539C")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x10E5578", Offset = "0x10E5578", VA = "0x10E5578")]
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
		[Address(RVA = "0x10EAC08", Offset = "0x10EAC08", VA = "0x10EAC08")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x10EAC10", Offset = "0x10EAC10", VA = "0x10EAC10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public Vector3 point
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x10EAC18", Offset = "0x10EAC18", VA = "0x10EAC18")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x10EAC24", Offset = "0x10EAC24", VA = "0x10EAC24")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public Vector3 axis
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x10EAC30", Offset = "0x10EAC30", VA = "0x10EAC30")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x10EAC3C", Offset = "0x10EAC3C", VA = "0x10EAC3C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public float lastVal
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x10EAC48", Offset = "0x10EAC48", VA = "0x10EAC48")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x10EAC50", Offset = "0x10EAC50", VA = "0x10EAC50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public Quaternion origRotation
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x10EAC58", Offset = "0x10EAC58", VA = "0x10EAC58")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x10EAC64", Offset = "0x10EAC64", VA = "0x10EAC64")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public LTBezierPath path
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x10EAC70", Offset = "0x10EAC70", VA = "0x10EAC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x10EAC78", Offset = "0x10EAC78", VA = "0x10EAC78")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public LTSpline spline
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x10EAC80", Offset = "0x10EAC80", VA = "0x10EAC80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x10EAC88", Offset = "0x10EAC88", VA = "0x10EAC88")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public LTRect ltRect
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x10EAC90", Offset = "0x10EAC90", VA = "0x10EAC90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x10EAC98", Offset = "0x10EAC98", VA = "0x10EAC98")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x10EACA0", Offset = "0x10EACA0", VA = "0x10EACA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x10EACA8", Offset = "0x10EACA8", VA = "0x10EACA8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x10EACB0", Offset = "0x10EACB0", VA = "0x10EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x10EACB8", Offset = "0x10EACB8", VA = "0x10EACB8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x10EACC0", Offset = "0x10EACC0", VA = "0x10EACC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x10EACC8", Offset = "0x10EACC8", VA = "0x10EACC8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x10EACD0", Offset = "0x10EACD0", VA = "0x10EACD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x10EACD8", Offset = "0x10EACD8", VA = "0x10EACD8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x10EACE0", Offset = "0x10EACE0", VA = "0x10EACE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x10EACE8", Offset = "0x10EACE8", VA = "0x10EACE8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x10EACF0", Offset = "0x10EACF0", VA = "0x10EACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x10EACF8", Offset = "0x10EACF8", VA = "0x10EACF8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x10EAD00", Offset = "0x10EAD00", VA = "0x10EAD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x10EAD08", Offset = "0x10EAD08", VA = "0x10EAD08")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x10EAD10", Offset = "0x10EAD10", VA = "0x10EAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x10EAD18", Offset = "0x10EAD18", VA = "0x10EAD18")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public Action onComplete
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x10EAD20", Offset = "0x10EAD20", VA = "0x10EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x10EAD28", Offset = "0x10EAD28", VA = "0x10EAD28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x10EAD30", Offset = "0x10EAD30", VA = "0x10EAD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x10EAD38", Offset = "0x10EAD38", VA = "0x10EAD38")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public object onCompleteParam
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x10EAD40", Offset = "0x10EAD40", VA = "0x10EAD40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x10EAD48", Offset = "0x10EAD48", VA = "0x10EAD48")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public object onUpdateParam
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x10EAD50", Offset = "0x10EAD50", VA = "0x10EAD50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x10EAD58", Offset = "0x10EAD58", VA = "0x10EAD58")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700003F")]
	public Action onStart
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x10EAD60", Offset = "0x10EAD60", VA = "0x10EAD60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x10EAD68", Offset = "0x10EAD68", VA = "0x10EAD68")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x10EAD70", Offset = "0x10EAD70", VA = "0x10EAD70")]
	public void reset()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x10EAE88", Offset = "0x10EAE88", VA = "0x10EAE88")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x10EAFDC", Offset = "0x10EAFDC", VA = "0x10EAFDC")]
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
		[Address(RVA = "0x10EAFE4", Offset = "0x10EAFE4", VA = "0x10EAFE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x10EAFF4", Offset = "0x10EAFF4", VA = "0x10EAFF4")]
	public void reset()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x10EB024", Offset = "0x10EB024", VA = "0x10EB024")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x10EB078", Offset = "0x10EB078", VA = "0x10EB078")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x10EB12C", Offset = "0x10EB12C", VA = "0x10EB12C")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x10EB168", Offset = "0x10EB168", VA = "0x10EB168")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x10EB18C", Offset = "0x10EB18C", VA = "0x10EB18C")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x10EB26C", Offset = "0x10EB26C", VA = "0x10EB26C")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x10EB300", Offset = "0x10EB300", VA = "0x10EB300")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x10EB384", Offset = "0x10EB384", VA = "0x10EB384")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x10EB208", Offset = "0x10EB208", VA = "0x10EB208")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x10EB428", Offset = "0x10EB428", VA = "0x10EB428")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x10EB474", Offset = "0x10EB474", VA = "0x10EB474")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x10EB494", Offset = "0x10EB494", VA = "0x10EB494")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x10EB528", Offset = "0x10EB528", VA = "0x10EB528")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x10EB52C", Offset = "0x10EB52C", VA = "0x10EB52C")]
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
		[Address(RVA = "0x10EB534", Offset = "0x10EB534", VA = "0x10EB534")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x10EB53C", Offset = "0x10EB53C", VA = "0x10EB53C")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x10EB544", Offset = "0x10EB544", VA = "0x10EB544")]
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
		[Address(RVA = "0x10EB54C", Offset = "0x10EB54C", VA = "0x10EB54C")]
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
		[Address(RVA = "0x10EB554", Offset = "0x10EB554", VA = "0x10EB554")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x10EB708", Offset = "0x10EB708", VA = "0x10EB708")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x10EB894", Offset = "0x10EB894", VA = "0x10EB894")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x10EBA34", Offset = "0x10EBA34", VA = "0x10EBA34")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x10EBA9C", Offset = "0x10EBA9C", VA = "0x10EBA9C")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x10EBB04", Offset = "0x10EBB04", VA = "0x10EBB04")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x10EBB5C", Offset = "0x10EBB5C", VA = "0x10EBB5C")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x10EBBD4", Offset = "0x10EBBD4", VA = "0x10EBBD4")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x10EBC2C", Offset = "0x10EBC2C", VA = "0x10EBC2C")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x10EBC84", Offset = "0x10EBC84", VA = "0x10EBC84")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x10EBCDC", Offset = "0x10EBCDC", VA = "0x10EBCDC")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x10EBD34", Offset = "0x10EBD34", VA = "0x10EBD34")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x10EBD94", Offset = "0x10EBD94", VA = "0x10EBD94")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x10EBDF0", Offset = "0x10EBDF0", VA = "0x10EBDF0")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x10EBE48", Offset = "0x10EBE48", VA = "0x10EBE48")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000030")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x10EBF68", Offset = "0x10EBF68", VA = "0x10EBF68")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x10EC120", Offset = "0x10EC120", VA = "0x10EC120")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x10EC2CC", Offset = "0x10EC2CC", VA = "0x10EC2CC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x10EC478", Offset = "0x10EC478", VA = "0x10EC478")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x10EC624", Offset = "0x10EC624", VA = "0x10EC624")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x10EC7D8", Offset = "0x10EC7D8", VA = "0x10EC7D8")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x10ECA40", Offset = "0x10ECA40", VA = "0x10ECA40")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x10ECF4C", Offset = "0x10ECF4C", VA = "0x10ECF4C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x10ED1C0", Offset = "0x10ED1C0", VA = "0x10ED1C0")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x10ED454", Offset = "0x10ED454", VA = "0x10ED454")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x10ED628", Offset = "0x10ED628", VA = "0x10ED628")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x200003C")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x10EDC3C", Offset = "0x10EDC3C", VA = "0x10EDC3C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x10EDDEC", Offset = "0x10EDDEC", VA = "0x10EDDEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x10EDF94", Offset = "0x10EDF94", VA = "0x10EDF94")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x10EE13C", Offset = "0x10EE13C", VA = "0x10EE13C")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x10EE2CC", Offset = "0x10EE2CC", VA = "0x10EE2CC")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x10EE700", Offset = "0x10EE700", VA = "0x10EE700")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x10EE9F4", Offset = "0x10EE9F4", VA = "0x10EE9F4")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x10EED0C", Offset = "0x10EED0C", VA = "0x10EED0C")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x10EEEE0", Offset = "0x10EEEE0", VA = "0x10EEEE0")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody2D target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000046")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x10EF50C", Offset = "0x10EF50C", VA = "0x10EF50C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x10EF6C0", Offset = "0x10EF6C0", VA = "0x10EF6C0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x10EF84C", Offset = "0x10EF84C", VA = "0x10EF84C")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x10EFA28", Offset = "0x10EFA28", VA = "0x10EFA28")]
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
			[Address(RVA = "0x10F47DC", Offset = "0x10F47DC", VA = "0x10F47DC")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x10EFD20", Offset = "0x10EFD20", VA = "0x10EFD20")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x10EFEAC", Offset = "0x10EFEAC", VA = "0x10EFEAC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x10F0060", Offset = "0x10F0060", VA = "0x10F0060")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x10F01EC", Offset = "0x10F01EC", VA = "0x10F01EC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x10F03A0", Offset = "0x10F03A0", VA = "0x10F03A0")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x10F052C", Offset = "0x10F052C", VA = "0x10F052C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x10F06DC", Offset = "0x10F06DC", VA = "0x10F06DC")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x10F08C0", Offset = "0x10F08C0", VA = "0x10F08C0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x10F0A6C", Offset = "0x10F0A6C", VA = "0x10F0A6C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x10F0C18", Offset = "0x10F0C18", VA = "0x10F0C18")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x10F0DC4", Offset = "0x10F0DC4", VA = "0x10F0DC4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x10F0F78", Offset = "0x10F0F78", VA = "0x10F0F78")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x10F1104", Offset = "0x10F1104", VA = "0x10F1104")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x10F12A0", Offset = "0x10F12A0", VA = "0x10F12A0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x10F144C", Offset = "0x10F144C", VA = "0x10F144C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x10F15F0", Offset = "0x10F15F0", VA = "0x10F15F0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x10F1794", Offset = "0x10F1794", VA = "0x10F1794")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x10F1948", Offset = "0x10F1948", VA = "0x10F1948")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x10F1AF0", Offset = "0x10F1AF0", VA = "0x10F1AF0")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x10F1C98", Offset = "0x10F1C98", VA = "0x10F1C98")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10F1E40", Offset = "0x10F1E40", VA = "0x10F1E40")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x10F1FEC", Offset = "0x10F1FEC", VA = "0x10F1FEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x10F2198", Offset = "0x10F2198", VA = "0x10F2198")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x10F2334", Offset = "0x10F2334", VA = "0x10F2334")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x10F24D4", Offset = "0x10F24D4", VA = "0x10F24D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x10F2674", Offset = "0x10F2674", VA = "0x10F2674")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x10F2820", Offset = "0x10F2820", VA = "0x10F2820")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x10F29DC", Offset = "0x10F29DC", VA = "0x10F29DC")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x10F2BC0", Offset = "0x10F2BC0", VA = "0x10F2BC0")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x10F2DAC", Offset = "0x10F2DAC", VA = "0x10F2DAC")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x10F31D4", Offset = "0x10F31D4", VA = "0x10F31D4")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x10F3374", Offset = "0x10F3374", VA = "0x10F3374")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x10F3504", Offset = "0x10F3504", VA = "0x10F3504")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x10F3694", Offset = "0x10F3694", VA = "0x10F3694")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x10F3830", Offset = "0x10F3830", VA = "0x10F3830")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x10F39E4", Offset = "0x10F39E4", VA = "0x10F39E4")]
		public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x10F3BDC", Offset = "0x10F3BDC", VA = "0x10F3BDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x10F3D68", Offset = "0x10F3D68", VA = "0x10F3D68")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x10F3FA0", Offset = "0x10F3FA0", VA = "0x10F3FA0")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x10F41B8", Offset = "0x10F41B8", VA = "0x10F41B8")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x10F43D0", Offset = "0x10F43D0", VA = "0x10F43D0")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x10F45E8", Offset = "0x10F45E8", VA = "0x10F45E8")]
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
			[Address(RVA = "0x10F6BD0", Offset = "0x10F6BD0", VA = "0x10F6BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x10F6E08", Offset = "0x10F6E08", VA = "0x10F6E08", Slot = "5")]
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
			[Address(RVA = "0x10F6E14", Offset = "0x10F6E14", VA = "0x10F6E14", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x10F7070", Offset = "0x10F7070", VA = "0x10F7070", Slot = "5")]
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
			[Address(RVA = "0x10F707C", Offset = "0x10F707C", VA = "0x10F707C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x10F72A0", Offset = "0x10F72A0", VA = "0x10F72A0", Slot = "5")]
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
			[Address(RVA = "0x10F72AC", Offset = "0x10F72AC", VA = "0x10F72AC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x10F74EC", Offset = "0x10F74EC", VA = "0x10F74EC", Slot = "5")]
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
			[Address(RVA = "0x10F74F8", Offset = "0x10F74F8", VA = "0x10F74F8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x10F7750", Offset = "0x10F7750", VA = "0x10F7750", Slot = "5")]
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
			[Address(RVA = "0x10F775C", Offset = "0x10F775C", VA = "0x10F775C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x10F7988", Offset = "0x10F7988", VA = "0x10F7988", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10F579C", Offset = "0x10F579C", VA = "0x10F579C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10F597C", Offset = "0x10F597C", VA = "0x10F597C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10F5B68", Offset = "0x10F5B68", VA = "0x10F5B68")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10F5C64", Offset = "0x10F5C64", VA = "0x10F5C64")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x10F5D60", Offset = "0x10F5D60", VA = "0x10F5D60")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10F5E5C", Offset = "0x10F5E5C", VA = "0x10F5E5C")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10F5F6C", Offset = "0x10F5F6C", VA = "0x10F5F6C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10F608C", Offset = "0x10F608C", VA = "0x10F608C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10F6188", Offset = "0x10F6188", VA = "0x10F6188")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x10F6394", Offset = "0x10F6394", VA = "0x10F6394")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x10F65A0", Offset = "0x10F65A0", VA = "0x10F65A0")]
		[AsyncStateMachine(typeof(<AsyncWaitForCompletion>d__10))]
		public static Task AsyncWaitForCompletion(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x10F668C", Offset = "0x10F668C", VA = "0x10F668C")]
		[AsyncStateMachine(typeof(<AsyncWaitForRewind>d__11))]
		public static Task AsyncWaitForRewind(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x10F6778", Offset = "0x10F6778", VA = "0x10F6778")]
		[AsyncStateMachine(typeof(<AsyncWaitForKill>d__12))]
		public static Task AsyncWaitForKill(this Tween t)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x10F6864", Offset = "0x10F6864", VA = "0x10F6864")]
		[AsyncStateMachine(typeof(<AsyncWaitForElapsedLoops>d__13))]
		public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
		{
			return null;
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x10F6958", Offset = "0x10F6958", VA = "0x10F6958")]
		[AsyncStateMachine(typeof(<AsyncWaitForPosition>d__14))]
		public static Task AsyncWaitForPosition(this Tween t, float position)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x10F6A54", Offset = "0x10F6A54", VA = "0x10F6A54")]
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
				[Address(RVA = "0x10F7994", Offset = "0x10F7994", VA = "0x10F7994", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x10F5C34", Offset = "0x10F5C34", VA = "0x10F5C34")]
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
				[Address(RVA = "0x10F79C4", Offset = "0x10F79C4", VA = "0x10F79C4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x10F5D30", Offset = "0x10F5D30", VA = "0x10F5D30")]
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
				[Address(RVA = "0x10F7A24", Offset = "0x10F7A24", VA = "0x10F7A24", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x10F5E2C", Offset = "0x10F5E2C", VA = "0x10F5E2C")]
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
				[Address(RVA = "0x10F7A40", Offset = "0x10F7A40", VA = "0x10F7A40", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x10F5F30", Offset = "0x10F5F30", VA = "0x10F5F30")]
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
				[Address(RVA = "0x10F7A80", Offset = "0x10F7A80", VA = "0x10F7A80", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x10F6048", Offset = "0x10F6048", VA = "0x10F6048")]
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
				[Address(RVA = "0x10F7AD8", Offset = "0x10F7AD8", VA = "0x10F7AD8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x10F6158", Offset = "0x10F6158", VA = "0x10F6158")]
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
			[Address(RVA = "0x10F7C68", Offset = "0x10F7C68", VA = "0x10F7C68")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x10F7D68", Offset = "0x10F7D68", VA = "0x10F7D68")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000451")]
			[Address(RVA = "0x10F7DF4", Offset = "0x10F7DF4", VA = "0x10F7DF4")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x10F7E80", Offset = "0x10F7E80", VA = "0x10F7E80")]
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
		[Address(RVA = "0x10F7B0C", Offset = "0x10F7B0C", VA = "0x10F7B0C")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x10F7BC0", Offset = "0x10F7BC0", VA = "0x10F7BC0")]
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
			[Address(RVA = "0x10F81CC", Offset = "0x10F81CC", VA = "0x10F81CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public Transform Trans
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x10F8398", Offset = "0x10F8398", VA = "0x10F8398")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x10F8054", Offset = "0x10F8054", VA = "0x10F8054")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x10F80AC", Offset = "0x10F80AC", VA = "0x10F80AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x10F8254", Offset = "0x10F8254", VA = "0x10F8254")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x10F842C", Offset = "0x10F842C", VA = "0x10F842C")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x10F850C", Offset = "0x10F850C", VA = "0x10F850C")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x10F86D0", Offset = "0x10F86D0", VA = "0x10F86D0")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10F8920", Offset = "0x10F8920", VA = "0x10F8920")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x10F8B38", Offset = "0x10F8B38", VA = "0x10F8B38")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x10F8D50", Offset = "0x10F8D50", VA = "0x10F8D50")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x10F919C", Offset = "0x10F919C", VA = "0x10F919C")]
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
		[Address(RVA = "0x10F9248", Offset = "0x10F9248", VA = "0x10F9248")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x10F949C", Offset = "0x10F949C", VA = "0x10F949C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10F96CC", Offset = "0x10F96CC", VA = "0x10F96CC")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x10F9760", Offset = "0x10F9760", VA = "0x10F9760")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x10F9990", Offset = "0x10F9990", VA = "0x10F9990")]
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
				[Address(RVA = "0x1128BA0", Offset = "0x1128BA0", VA = "0x1128BA0", Slot = "4")]
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
				[Address(RVA = "0x1128BE8", Offset = "0x1128BE8", VA = "0x1128BE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x11289E4", Offset = "0x11289E4", VA = "0x11289E4")]
			[DebuggerHidden]
			public <CoUpdate>d__129(int <>1__state)
			{
			}

			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x1128A0C", Offset = "0x1128A0C", VA = "0x1128A0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x1128A10", Offset = "0x1128A10", VA = "0x1128A10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x1128BA8", Offset = "0x1128BA8", VA = "0x1128BA8", Slot = "8")]
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
			[Address(RVA = "0x10F9C10", Offset = "0x10F9C10", VA = "0x10F9C10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x10FB5D8", Offset = "0x10FB5D8", VA = "0x10FB5D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		private Transform Trans
		{
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x10FEAA4", Offset = "0x10FEAA4", VA = "0x10FEAA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x10F9ADC", Offset = "0x10F9ADC", VA = "0x10F9ADC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x10F9EA8", Offset = "0x10F9EA8", VA = "0x10F9EA8", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x10FA060", Offset = "0x10FA060", VA = "0x10FA060")]
		[IteratorStateMachine(typeof(<CoUpdate>d__129))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x10FA0D4", Offset = "0x10FA0D4", VA = "0x10FA0D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x10FA790", Offset = "0x10FA790", VA = "0x10FA790")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x10FA7B8", Offset = "0x10FA7B8", VA = "0x10FA7B8")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10FA7D4", Offset = "0x10FA7D4", VA = "0x10FA7D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10FAAE0", Offset = "0x10FAAE0", VA = "0x10FAAE0")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x10FAE88", Offset = "0x10FAE88", VA = "0x10FAE88")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x10FB260", Offset = "0x10FB260", VA = "0x10FB260")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x10FB36C", Offset = "0x10FB36C", VA = "0x10FB36C")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10FB38C", Offset = "0x10FB38C", VA = "0x10FB38C")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x10FB3AC", Offset = "0x10FB3AC", VA = "0x10FB3AC")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x10FB3CC", Offset = "0x10FB3CC", VA = "0x10FB3CC")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10FB3EC", Offset = "0x10FB3EC", VA = "0x10FB3EC")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x10FB3F0", Offset = "0x10FB3F0", VA = "0x10FB3F0")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x10FB410", Offset = "0x10FB410", VA = "0x10FB410")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x10FB414", Offset = "0x10FB414", VA = "0x10FB414")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10FB434", Offset = "0x10FB434", VA = "0x10FB434")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x10FB454", Offset = "0x10FB454", VA = "0x10FB454")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x10FB474", Offset = "0x10FB474", VA = "0x10FB474")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x10FB478", Offset = "0x10FB478", VA = "0x10FB478")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x10FB498", Offset = "0x10FB498", VA = "0x10FB498")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x10FB4B8", Offset = "0x10FB4B8", VA = "0x10FB4B8")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x10FB4D8", Offset = "0x10FB4D8", VA = "0x10FB4D8")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x10FB4F8", Offset = "0x10FB4F8", VA = "0x10FB4F8")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x10FB518", Offset = "0x10FB518", VA = "0x10FB518")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x10FB538", Offset = "0x10FB538", VA = "0x10FB538")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x10FB558", Offset = "0x10FB558", VA = "0x10FB558")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x10FB578", Offset = "0x10FB578", VA = "0x10FB578")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x10FB5A8", Offset = "0x10FB5A8", VA = "0x10FB5A8")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x10FB5C0", Offset = "0x10FB5C0", VA = "0x10FB5C0")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x10FB5E8", Offset = "0x10FB5E8", VA = "0x10FB5E8")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x10FB620", Offset = "0x10FB620", VA = "0x10FB620")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x10FB640", Offset = "0x10FB640", VA = "0x10FB640")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x10FB678", Offset = "0x10FB678", VA = "0x10FB678")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x10FB6B8", Offset = "0x10FB6B8", VA = "0x10FB6B8")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x10FB6D8", Offset = "0x10FB6D8", VA = "0x10FB6D8")]
		public void ActivateCodeTriggeredEvent1()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x10FB6F0", Offset = "0x10FB6F0", VA = "0x10FB6F0")]
		public void ActivateCodeTriggeredEvent2()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x10FB708", Offset = "0x10FB708", VA = "0x10FB708")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x10FB7A4", Offset = "0x10FB7A4", VA = "0x10FB7A4")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x10FB96C", Offset = "0x10FB96C", VA = "0x10FB96C")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x10FBBC0", Offset = "0x10FBBC0", VA = "0x10FBBC0")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x10FA564", Offset = "0x10FA564", VA = "0x10FA564")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x10FE774", Offset = "0x10FE774", VA = "0x10FE774")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x10FE90C", Offset = "0x10FE90C", VA = "0x10FE90C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x10FBC70", Offset = "0x10FBC70", VA = "0x10FBC70")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x10FBCFC", Offset = "0x10FBCFC", VA = "0x10FBCFC")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x10FEB30", Offset = "0x10FEB30", VA = "0x10FEB30")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x10FA140", Offset = "0x10FA140", VA = "0x10FA140", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x10FEE3C", Offset = "0x10FEE3C", VA = "0x10FEE3C", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x10FEF10", Offset = "0x10FEF10", VA = "0x10FEF10", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x10FADF8", Offset = "0x10FADF8", VA = "0x10FADF8", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x10FB1D8", Offset = "0x10FB1D8", VA = "0x10FB1D8", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x10FEFE0", Offset = "0x10FEFE0", VA = "0x10FEFE0", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x10F9C20", Offset = "0x10F9C20", VA = "0x10F9C20")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600049E")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x10FF030", Offset = "0x10FF030", VA = "0x10FF030")]
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
			[Address(RVA = "0x1128FD8", Offset = "0x1128FD8", VA = "0x1128FD8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1128FE0", Offset = "0x1128FE0", VA = "0x1128FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1128FE8", Offset = "0x1128FE8", VA = "0x1128FE8")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1128FF0", Offset = "0x1128FF0", VA = "0x1128FF0", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1129088", Offset = "0x1129088", VA = "0x1129088")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1129090", Offset = "0x1129090", VA = "0x1129090", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1129128", Offset = "0x1129128", VA = "0x1129128")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000095")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1129130", Offset = "0x1129130", VA = "0x1129130", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x11291C8", Offset = "0x11291C8", VA = "0x11291C8")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x11291D0", Offset = "0x11291D0", VA = "0x11291D0", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1129268", Offset = "0x1129268", VA = "0x1129268")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1129270", Offset = "0x1129270", VA = "0x1129270", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1129308", Offset = "0x1129308", VA = "0x1129308")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1129310", Offset = "0x1129310", VA = "0x1129310", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x11293A8", Offset = "0x11293A8", VA = "0x11293A8")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x11293B0", Offset = "0x11293B0", VA = "0x11293B0", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1129448", Offset = "0x1129448", VA = "0x1129448")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1129450", Offset = "0x1129450", VA = "0x1129450", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x11294E8", Offset = "0x11294E8", VA = "0x11294E8")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x11294F0", Offset = "0x11294F0", VA = "0x11294F0", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1129588", Offset = "0x1129588", VA = "0x1129588")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1129590", Offset = "0x1129590", VA = "0x1129590", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1129628", Offset = "0x1129628", VA = "0x1129628")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1129630", Offset = "0x1129630", VA = "0x1129630", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x11296C8", Offset = "0x11296C8", VA = "0x11296C8")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x11296D0", Offset = "0x11296D0", VA = "0x11296D0", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1129768", Offset = "0x1129768", VA = "0x1129768")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1129770", Offset = "0x1129770", VA = "0x1129770", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1129808", Offset = "0x1129808", VA = "0x1129808")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1129810", Offset = "0x1129810", VA = "0x1129810", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x11298A8", Offset = "0x11298A8", VA = "0x11298A8")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x11298B0", Offset = "0x11298B0", VA = "0x11298B0", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1129948", Offset = "0x1129948", VA = "0x1129948")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1129950", Offset = "0x1129950", VA = "0x1129950", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x11299E8", Offset = "0x11299E8", VA = "0x11299E8")]
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
			[Address(RVA = "0x1129D80", Offset = "0x1129D80", VA = "0x1129D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x11299F0", Offset = "0x11299F0", VA = "0x11299F0")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1129A74", Offset = "0x1129A74", VA = "0x1129A74")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1129E14", Offset = "0x1129E14", VA = "0x1129E14")]
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
		[Address(RVA = "0x1129EB4", Offset = "0x1129EB4", VA = "0x1129EB4", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x112A02C", Offset = "0x112A02C", VA = "0x112A02C", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x112A304", Offset = "0x112A304", VA = "0x112A304", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1129F90", Offset = "0x1129F90", VA = "0x1129F90")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x112A3D0", Offset = "0x112A3D0", VA = "0x112A3D0")]
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
		[Address(RVA = "0x112A46C", Offset = "0x112A46C", VA = "0x112A46C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x112A664", Offset = "0x112A664", VA = "0x112A664", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x112AC10", Offset = "0x112AC10", VA = "0x112AC10", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x112A57C", Offset = "0x112A57C", VA = "0x112A57C")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x112A618", Offset = "0x112A618", VA = "0x112A618")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x112ADEC", Offset = "0x112ADEC", VA = "0x112ADEC")]
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
			[Address(RVA = "0x112AEB4", Offset = "0x112AEB4", VA = "0x112AEB4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x112AEBC", Offset = "0x112AEBC", VA = "0x112AEBC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x112AEC8", Offset = "0x112AEC8", VA = "0x112AEC8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x112AED0", Offset = "0x112AED0", VA = "0x112AED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x112AEDC", Offset = "0x112AEDC", VA = "0x112AEDC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x112AEE4", Offset = "0x112AEE4", VA = "0x112AEE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x112AE8C", Offset = "0x112AE8C", VA = "0x112AE8C")]
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
		[Address(RVA = "0x112AEEC", Offset = "0x112AEEC", VA = "0x112AEEC")]
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
			[Address(RVA = "0x112B1D0", Offset = "0x112B1D0", VA = "0x112B1D0")]
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
			[Address(RVA = "0x112AEF4", Offset = "0x112AEF4", VA = "0x112AEF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x112AF5C", Offset = "0x112AF5C", VA = "0x112AF5C")]
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
		[Address(RVA = "0x112B214", Offset = "0x112B214", VA = "0x112B214")]
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
		[Address(RVA = "0x112B4A0", Offset = "0x112B4A0", VA = "0x112B4A0")]
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
		[Address(RVA = "0x112B4C8", Offset = "0x112B4C8", VA = "0x112B4C8")]
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
		[Address(RVA = "0x112B4D8", Offset = "0x112B4D8", VA = "0x112B4D8")]
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
			[Address(RVA = "0x112B708", Offset = "0x112B708", VA = "0x112B708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x112B4E8", Offset = "0x112B4E8", VA = "0x112B4E8")]
		public CustomEvent(string eventName)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x112B5DC", Offset = "0x112B5DC", VA = "0x112B5DC")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x112B6B0", Offset = "0x112B6B0", VA = "0x112B6B0")]
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
			[Address(RVA = "0x112B884", Offset = "0x112B884", VA = "0x112B884")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x112B758", Offset = "0x112B758", VA = "0x112B758")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x112B82C", Offset = "0x112B82C", VA = "0x112B82C")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x112B8D4", Offset = "0x112B8D4", VA = "0x112B8D4")]
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
		[Address(RVA = "0x112B9A0", Offset = "0x112B9A0", VA = "0x112B9A0")]
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
		[Address(RVA = "0x112B9A8", Offset = "0x112B9A8", VA = "0x112B9A8")]
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
			[Address(RVA = "0x112BA14", Offset = "0x112BA14", VA = "0x112BA14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x112BABC", Offset = "0x112BABC", VA = "0x112BABC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60004FE")]
			[Address(RVA = "0x112BB64", Offset = "0x112BB64", VA = "0x112BB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x112BC0C", Offset = "0x112BC0C", VA = "0x112BC0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000500")]
			[Address(RVA = "0x112BCB4", Offset = "0x112BCB4", VA = "0x112BCB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x112BD5C", Offset = "0x112BD5C", VA = "0x112BD5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x112BE04", Offset = "0x112BE04", VA = "0x112BE04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public Transform Trans
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x112BF70", Offset = "0x112BF70", VA = "0x112BF70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x112C004", Offset = "0x112C004", VA = "0x112C004")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005F")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x112C21C", Offset = "0x112C21C", VA = "0x112C21C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x112C2C4", Offset = "0x112C2C4", VA = "0x112C2C4")]
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
		[Address(RVA = "0x112C300", Offset = "0x112C300", VA = "0x112C300")]
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
		[Address(RVA = "0x112C4C4", Offset = "0x112C4C4", VA = "0x112C4C4")]
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
			[Address(RVA = "0x112C958", Offset = "0x112C958", VA = "0x112C958")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000061")]
		public bool HasLiveActors
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x112C9A0", Offset = "0x112C9A0", VA = "0x112C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x112C9F0", Offset = "0x112C9F0", VA = "0x112C9F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000063")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x112CA54", Offset = "0x112CA54", VA = "0x112CA54")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x112CA5C", Offset = "0x112CA5C", VA = "0x112CA5C")]
			set
			{
			}
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x112C700", Offset = "0x112C700", VA = "0x112C700")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x112C7D4", Offset = "0x112C7D4", VA = "0x112C7D4")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x112C82C", Offset = "0x112C82C", VA = "0x112C82C")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x112C900", Offset = "0x112C900", VA = "0x112C900")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x112CA64", Offset = "0x112CA64", VA = "0x112CA64")]
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
		[Address(RVA = "0x112CB4C", Offset = "0x112CB4C", VA = "0x112CB4C")]
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
		[Address(RVA = "0x112CB5C", Offset = "0x112CB5C", VA = "0x112CB5C")]
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
			[Address(RVA = "0x112D2D8", Offset = "0x112D2D8", VA = "0x112D2D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000523")]
			[Address(RVA = "0x112D3B4", Offset = "0x112D3B4", VA = "0x112D3B4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public int TotalVoices
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x112D400", Offset = "0x112D400", VA = "0x112D400")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000067")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x112D420", Offset = "0x112D420", VA = "0x112D420")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x112D064", Offset = "0x112D064", VA = "0x112D064")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x112D42C", Offset = "0x112D42C", VA = "0x112D42C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x112D434", Offset = "0x112D434", VA = "0x112D434")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x112D43C", Offset = "0x112D43C", VA = "0x112D43C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public int ChainLoopCount
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0x112D500", Offset = "0x112D500", VA = "0x112D500")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600052E")]
			[Address(RVA = "0x112D508", Offset = "0x112D508", VA = "0x112D508")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public string GameObjectName
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x112D510", Offset = "0x112D510", VA = "0x112D510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public MasterAudio.GroupPlayType GroupPlayType
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x112D55C", Offset = "0x112D55C", VA = "0x112D55C")]
			get
			{
				return default(MasterAudio.GroupPlayType);
			}
		}

		[Token(Token = "0x1700006E")]
		public bool HasLiveActors
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x112D688", Offset = "0x112D688", VA = "0x112D688")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x112D6D8", Offset = "0x112D6D8", VA = "0x112D6D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private Transform Trans
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x112CEE4", Offset = "0x112CEE4", VA = "0x112CEE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x112CE34", Offset = "0x112CE34", VA = "0x112CE34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0x112CBEC", Offset = "0x112CBEC", VA = "0x112CBEC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600051C")]
			[Address(RVA = "0x112CC88", Offset = "0x112CC88", VA = "0x112CC88")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x112CD24", Offset = "0x112CD24", VA = "0x112CD24")]
		private void Start()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x112CF70", Offset = "0x112CF70", VA = "0x112CF70")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x112D130", Offset = "0x112D130", VA = "0x112D130")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x112D1AC", Offset = "0x112D1AC", VA = "0x112D1AC")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x112D280", Offset = "0x112D280", VA = "0x112D280")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x112D4A8", Offset = "0x112D4A8", VA = "0x112D4A8")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x112D4C4", Offset = "0x112D4C4", VA = "0x112D4C4")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x112D4F4", Offset = "0x112D4F4", VA = "0x112D4F4")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x112D744", Offset = "0x112D744", VA = "0x112D744")]
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
		[Address(RVA = "0x112D9A0", Offset = "0x112D9A0", VA = "0x112D9A0")]
		static MasterAudioSettings()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x112DBC4", Offset = "0x112DBC4", VA = "0x112DBC4")]
		public MasterAudioSettings()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x112DC70", Offset = "0x112DC70", VA = "0x112DC70")]
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
			[Address(RVA = "0x112DEAC", Offset = "0x112DEAC", VA = "0x112DEAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000073")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x112DEC4", Offset = "0x112DEC4", VA = "0x112DEC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000074")]
		public float SongStartTime
		{
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x112DF60", Offset = "0x112DF60", VA = "0x112DF60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x112DC78", Offset = "0x112DC78", VA = "0x112DC78")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x112DF9C", Offset = "0x112DF9C", VA = "0x112DF9C")]
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
		[Address(RVA = "0x112E968", Offset = "0x112E968", VA = "0x112E968")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x112E978", Offset = "0x112E978", VA = "0x112E978")]
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
		[Address(RVA = "0x112E840", Offset = "0x112E840", VA = "0x112E840")]
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
		[Address(RVA = "0x112E7F8", Offset = "0x112E7F8", VA = "0x112E7F8")]
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
		[Address(RVA = "0x112E888", Offset = "0x112E888", VA = "0x112E888")]
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
		[Address(RVA = "0x112E980", Offset = "0x112E980", VA = "0x112E980")]
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
		[Address(RVA = "0x112E7B0", Offset = "0x112E7B0", VA = "0x112E7B0")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x112E9EC", Offset = "0x112E9EC", VA = "0x112E9EC")]
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
			[Address(RVA = "0x1133958", Offset = "0x1133958", VA = "0x1133958")]
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
				[Address(RVA = "0x1133D64", Offset = "0x1133D64", VA = "0x1133D64", Slot = "4")]
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
				[Address(RVA = "0x1133DAC", Offset = "0x1133DAC", VA = "0x1133DAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1132374", Offset = "0x1132374", VA = "0x1132374")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__113(int <>1__state)
			{
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1133C98", Offset = "0x1133C98", VA = "0x1133C98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1133C9C", Offset = "0x1133C9C", VA = "0x1133C9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1133D6C", Offset = "0x1133D6C", VA = "0x1133D6C", Slot = "8")]
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
			[Address(RVA = "0x1132E44", Offset = "0x1132E44", VA = "0x1132E44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1132E4C", Offset = "0x1132E4C", VA = "0x1132E4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1132EF4", Offset = "0x1132EF4", VA = "0x1132EF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1132F9C", Offset = "0x1132F9C", VA = "0x1132F9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1133044", Offset = "0x1133044", VA = "0x1133044")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x11330EC", Offset = "0x11330EC", VA = "0x11330EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x11330F4", Offset = "0x11330F4", VA = "0x11330F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x11330FC", Offset = "0x11330FC", VA = "0x11330FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x11331A4", Offset = "0x11331A4", VA = "0x11331A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x11331AC", Offset = "0x11331AC", VA = "0x11331AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x11332F8", Offset = "0x11332F8", VA = "0x11332F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1133300", Offset = "0x1133300", VA = "0x1133300")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1133324", Offset = "0x1133324", VA = "0x1133324")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007F")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x112F184", Offset = "0x112F184", VA = "0x112F184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1130320", Offset = "0x1130320", VA = "0x1130320")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000081")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x113352C", Offset = "0x113352C", VA = "0x113352C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000082")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1133560", Offset = "0x1133560", VA = "0x1133560")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x11335A4", Offset = "0x11335A4", VA = "0x11335A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public float LastTimePlayed
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1133640", Offset = "0x1133640", VA = "0x1133640")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1133648", Offset = "0x1133648", VA = "0x1133648")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1133650", Offset = "0x1133650", VA = "0x1133650")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000086")]
		public bool IsPlaying
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x112F338", Offset = "0x112F338", VA = "0x112F338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1133660", Offset = "0x1133660", VA = "0x1133660")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x11301C4", Offset = "0x11301C4", VA = "0x11301C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public int InstanceId
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1130AC4", Offset = "0x1130AC4", VA = "0x1130AC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000089")]
		public bool IsStopRequested
		{
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1133668", Offset = "0x1133668", VA = "0x1133668")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public Transform Trans
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x113218C", Offset = "0x113218C", VA = "0x113218C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x112F0F8", Offset = "0x112F0F8", VA = "0x112F0F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x112EE0C", Offset = "0x112EE0C", VA = "0x112EE0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1130A14", Offset = "0x1130A14", VA = "0x1130A14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		public string ResFileName
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1130658", Offset = "0x1130658", VA = "0x1130658")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x112F698", Offset = "0x112F698", VA = "0x112F698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x1133700", Offset = "0x1133700", VA = "0x1133700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000091")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1133708", Offset = "0x1133708", VA = "0x1133708")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1133724", Offset = "0x1133724", VA = "0x1133724")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public int MaxLoops
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1133740", Offset = "0x1133740", VA = "0x1133740")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000093")]
		private bool Is2D
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1133748", Offset = "0x1133748", VA = "0x1133748")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000094")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x112F834", Offset = "0x112F834", VA = "0x112F834")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public bool IsPaused
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1133770", Offset = "0x1133770", VA = "0x1133770")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000096")]
		public string GameObjectName
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1133794", Offset = "0x1133794", VA = "0x1133794")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x11337E0", Offset = "0x11337E0", VA = "0x11337E0")]
			set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x112E9F4", Offset = "0x112E9F4", VA = "0x112E9F4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x112EA94", Offset = "0x112EA94", VA = "0x112EA94")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x112EB34", Offset = "0x112EB34", VA = "0x112EB34")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x112EBD4", Offset = "0x112EBD4", VA = "0x112EBD4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x112EC74", Offset = "0x112EC74", VA = "0x112EC74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x112EEB4", Offset = "0x112EEB4", VA = "0x112EEB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x112F354", Offset = "0x112F354", VA = "0x112F354")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x112F3A4", Offset = "0x112F3A4", VA = "0x112F3A4")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x112F53C", Offset = "0x112F53C", VA = "0x112F53C")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x112F494", Offset = "0x112F494", VA = "0x112F494")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x112F9CC", Offset = "0x112F9CC", VA = "0x112F9CC")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x112FA64", Offset = "0x112FA64", VA = "0x112FA64")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x112FB10", Offset = "0x112FB10", VA = "0x112FB10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x112FA68", Offset = "0x112FA68", VA = "0x112FA68")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x112FE68", Offset = "0x112FE68", VA = "0x112FE68")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1130220", Offset = "0x1130220", VA = "0x1130220")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x11301D8", Offset = "0x11301D8", VA = "0x11301D8")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x11307D4", Offset = "0x11307D4", VA = "0x11307D4")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1130354", Offset = "0x1130354", VA = "0x1130354")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x1130BBC", Offset = "0x1130BBC", VA = "0x1130BBC")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1130C04", Offset = "0x1130C04", VA = "0x1130C04")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1130F00", Offset = "0x1130F00", VA = "0x1130F00")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1131074", Offset = "0x1131074", VA = "0x1131074")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x11311DC", Offset = "0x11311DC", VA = "0x11311DC")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1131224", Offset = "0x1131224", VA = "0x1131224")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x113126C", Offset = "0x113126C", VA = "0x113126C")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x113144C", Offset = "0x113144C", VA = "0x113144C")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1131880", Offset = "0x1131880", VA = "0x1131880")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11307F4", Offset = "0x11307F4", VA = "0x11307F4")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1131DA8", Offset = "0x1131DA8", VA = "0x1131DA8")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1131AD4", Offset = "0x1131AD4", VA = "0x1131AD4")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x112FB14", Offset = "0x112FB14", VA = "0x112FB14")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11322CC", Offset = "0x11322CC", VA = "0x11322CC")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1132300", Offset = "0x1132300", VA = "0x1132300")]
		[IteratorStateMachine(typeof(<WaitForLoadToUnloadClipAndDeactivate>d__113))]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x113239C", Offset = "0x113239C", VA = "0x113239C")]
		public void FadeToVolume(float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11327AC", Offset = "0x11327AC", VA = "0x11327AC")]
		public void FadeOutNowAndStop([Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1132A70", Offset = "0x1132A70", VA = "0x1132A70")]
		public void FadeOutNowAndStop(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1132B9C", Offset = "0x1132B9C", VA = "0x1132B9C")]
		public void MoveToAmbientColliderPosition(Vector3 newPosition, TransformFollower follower)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1132C00", Offset = "0x1132C00", VA = "0x1132C00")]
		public void UpdateAudioVariation(TransformFollower transformFollower)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1132CAC", Offset = "0x1132CAC", VA = "0x1132CAC")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1132D54", Offset = "0x1132D54", VA = "0x1132D54")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11331D0", Offset = "0x11331D0", VA = "0x11331D0")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1133778", Offset = "0x1133778", VA = "0x1133778")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11307A8", Offset = "0x11307A8", VA = "0x11307A8")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11337E8", Offset = "0x11337E8", VA = "0x11337E8")]
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
			[Address(RVA = "0x1135200", Offset = "0x1135200", VA = "0x1135200")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009A")]
		public float ClipEndPosition
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1133EF8", Offset = "0x1133EF8", VA = "0x1133EF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		public int FramesPlayed
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1135FA8", Offset = "0x1135FA8", VA = "0x1135FA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009C")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1135FB0", Offset = "0x1135FB0", VA = "0x1135FB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1136008", Offset = "0x1136008", VA = "0x1136008")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x11360B0", Offset = "0x11360B0", VA = "0x11360B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009F")]
		private Transform Trans
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x1134558", Offset = "0x1134558", VA = "0x1134558")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1133E5C", Offset = "0x1133E5C", VA = "0x1133E5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x11345F4", Offset = "0x11345F4", VA = "0x11345F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x1133DB4", Offset = "0x1133DB4", VA = "0x1133DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A3")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x1135158", Offset = "0x1135158", VA = "0x1135158")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x1134BA0", Offset = "0x1134BA0", VA = "0x1134BA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1135F44", Offset = "0x1135F44", VA = "0x1135F44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1130E40", Offset = "0x1130E40", VA = "0x1130E40")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1132624", Offset = "0x1132624", VA = "0x1132624")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x11328D0", Offset = "0x11328D0", VA = "0x11328D0")]
		public void FadeOutEarly(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1131CF8", Offset = "0x1131CF8", VA = "0x1131CF8")]
		public void Initialize()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x11308F4", Offset = "0x11308F4", VA = "0x11308F4")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1130AEC", Offset = "0x1130AEC", VA = "0x1130AEC")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1131D34", Offset = "0x1131D34", VA = "0x1131D34")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1132274", Offset = "0x1132274", VA = "0x1132274")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1132250", Offset = "0x1132250", VA = "0x1132250")]
		public void StopFading()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1131858", Offset = "0x1131858", VA = "0x1131858")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1132218", Offset = "0x1132218", VA = "0x1132218")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x11344EC", Offset = "0x11344EC", VA = "0x11344EC")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1134044", Offset = "0x1134044", VA = "0x1134044")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x11349C0", Offset = "0x11349C0", VA = "0x11349C0")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1134A5C", Offset = "0x1134A5C", VA = "0x1134A5C")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1134C20", Offset = "0x1134C20", VA = "0x1134C20")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1134C8C", Offset = "0x1134C8C", VA = "0x1134C8C")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x11341AC", Offset = "0x11341AC", VA = "0x11341AC")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1135354", Offset = "0x1135354", VA = "0x1135354")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x11354A4", Offset = "0x11354A4", VA = "0x11354A4")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1131170", Offset = "0x1131170", VA = "0x1131170")]
		public void Pause()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1131344", Offset = "0x1131344", VA = "0x1131344")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x11314F8", Offset = "0x11314F8", VA = "0x11314F8")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x113553C", Offset = "0x113553C", VA = "0x113553C")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x11355EC", Offset = "0x11355EC", VA = "0x11355EC")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1135A1C", Offset = "0x1135A1C", VA = "0x1135A1C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1135A98", Offset = "0x1135A98", VA = "0x1135A98")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x112F738", Offset = "0x112F738", VA = "0x112F738")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1135B58", Offset = "0x1135B58", VA = "0x1135B58")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1136158", Offset = "0x1136158", VA = "0x1136158")]
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
		[Address(RVA = "0x11361D0", Offset = "0x11361D0", VA = "0x11361D0")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x11364B0", Offset = "0x11364B0", VA = "0x11364B0")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x113667C", Offset = "0x113667C", VA = "0x113667C")]
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
		[Address(RVA = "0x112F99C", Offset = "0x112F99C", VA = "0x112F99C")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x112F9B4", Offset = "0x112F9B4", VA = "0x112F9B4")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1136878", Offset = "0x1136878", VA = "0x1136878")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1134690", Offset = "0x1134690", VA = "0x1134690")]
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
				[Address(RVA = "0x1137F14", Offset = "0x1137F14", VA = "0x1137F14", Slot = "4")]
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
				[Address(RVA = "0x1137F5C", Offset = "0x1137F5C", VA = "0x1137F5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1137324", Offset = "0x1137324", VA = "0x1137324")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1137930", Offset = "0x1137930", VA = "0x1137930", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x1137934", Offset = "0x1137934", VA = "0x1137934", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1137F1C", Offset = "0x1137F1C", VA = "0x1137F1C", Slot = "8")]
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
				[Address(RVA = "0x11385D0", Offset = "0x11385D0", VA = "0x11385D0", Slot = "4")]
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
				[Address(RVA = "0x1138618", Offset = "0x1138618", VA = "0x1138618", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x113734C", Offset = "0x113734C", VA = "0x113734C")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1137F64", Offset = "0x1137F64", VA = "0x1137F64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1137F68", Offset = "0x1137F68", VA = "0x1137F68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x11385D8", Offset = "0x11385D8", VA = "0x11385D8", Slot = "8")]
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
		[Address(RVA = "0x1136890", Offset = "0x1136890", VA = "0x1136890")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1136934", Offset = "0x1136934", VA = "0x1136934")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1133670", Offset = "0x1133670", VA = "0x1133670")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1136CDC", Offset = "0x1136CDC", VA = "0x1136CDC")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1136A84", Offset = "0x1136A84", VA = "0x1136A84")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1137000", Offset = "0x1137000", VA = "0x1137000")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x113707C", Offset = "0x113707C", VA = "0x113707C")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x113725C", Offset = "0x113725C", VA = "0x113725C")]
		[IteratorStateMachine(typeof(<PopulateResourceSongToPlaylistControllerAsync>d__11))]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x11306E8", Offset = "0x11306E8", VA = "0x11306E8")]
		[IteratorStateMachine(typeof(<PopulateSourcesWithResourceClipAsync>d__12))]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1137374", Offset = "0x1137374", VA = "0x1137374")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x11374FC", Offset = "0x11374FC", VA = "0x11374FC")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1131EC4", Offset = "0x1131EC4", VA = "0x1131EC4")]
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
			[Address(RVA = "0x1138620", Offset = "0x1138620", VA = "0x1138620")]
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
			[Address(RVA = "0x1138660", Offset = "0x1138660", VA = "0x1138660")]
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
			[Address(RVA = "0x11386BC", Offset = "0x11386BC", VA = "0x11386BC")]
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
				[Address(RVA = "0x11389E8", Offset = "0x11389E8", VA = "0x11389E8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1138720", Offset = "0x1138720", VA = "0x1138720")]
			public Playlist()
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x11388BC", Offset = "0x11388BC", VA = "0x11388BC")]
			public void AddActorInstanceId(int instanceId)
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1138990", Offset = "0x1138990", VA = "0x1138990")]
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
			[Address(RVA = "0x1138A38", Offset = "0x1138A38", VA = "0x1138A38")]
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
			[Address(RVA = "0x1138B48", Offset = "0x1138B48", VA = "0x1138B48")]
			public <>c__DisplayClass274_0()
			{
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1138B50", Offset = "0x1138B50", VA = "0x1138B50")]
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
				[Address(RVA = "0x1138E3C", Offset = "0x1138E3C", VA = "0x1138E3C", Slot = "4")]
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
				[Address(RVA = "0x1138E84", Offset = "0x1138E84", VA = "0x1138E84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1138B5C", Offset = "0x1138B5C", VA = "0x1138B5C")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__274(int <>1__state)
			{
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1138B84", Offset = "0x1138B84", VA = "0x1138B84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1138B88", Offset = "0x1138B88", VA = "0x1138B88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1138E44", Offset = "0x1138E44", VA = "0x1138E44", Slot = "8")]
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
			[Address(RVA = "0x1138E8C", Offset = "0x1138E8C", VA = "0x1138E8C")]
			public <>c__DisplayClass275_0()
			{
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1138E94", Offset = "0x1138E94", VA = "0x1138E94")]
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
				[Address(RVA = "0x113919C", Offset = "0x113919C", VA = "0x113919C", Slot = "4")]
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
				[Address(RVA = "0x11391E4", Offset = "0x11391E4", VA = "0x11391E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1138EA0", Offset = "0x1138EA0", VA = "0x1138EA0")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1138EC8", Offset = "0x1138EC8", VA = "0x1138EC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x1138ECC", Offset = "0x1138ECC", VA = "0x1138ECC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x11391A4", Offset = "0x11391A4", VA = "0x11391A4", Slot = "8")]
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
			[Address(RVA = "0x11391EC", Offset = "0x11391EC", VA = "0x11391EC")]
			public <>c__DisplayClass276_0()
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0x11391F4", Offset = "0x11391F4", VA = "0x11391F4")]
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
				[Address(RVA = "0x11394FC", Offset = "0x11394FC", VA = "0x11394FC", Slot = "4")]
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
				[Address(RVA = "0x1139544", Offset = "0x1139544", VA = "0x1139544", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0x1139200", Offset = "0x1139200", VA = "0x1139200")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__276(int <>1__state)
			{
			}

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x1139228", Offset = "0x1139228", VA = "0x1139228", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x113922C", Offset = "0x113922C", VA = "0x113922C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000768")]
			[Address(RVA = "0x1139504", Offset = "0x1139504", VA = "0x1139504", Slot = "8")]
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
			[Address(RVA = "0x111FE14", Offset = "0x111FE14", VA = "0x111FE14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x111FE70", Offset = "0x111FE70", VA = "0x111FE70")]
			set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x1121FDC", Offset = "0x1121FDC", VA = "0x1121FDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x1122038", Offset = "0x1122038", VA = "0x1122038")]
			set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x1109204", Offset = "0x1109204", VA = "0x1109204")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x112209C", Offset = "0x112209C", VA = "0x112209C")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public static Transform VideoPlayerSoundGroupTransform
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0x11238C8", Offset = "0x11238C8", VA = "0x11238C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1123948", Offset = "0x1123948", VA = "0x1123948")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AF")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1101DC8", Offset = "0x1101DC8", VA = "0x1101DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1123A88", Offset = "0x1123A88", VA = "0x1123A88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B1")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1108BBC", Offset = "0x1108BBC", VA = "0x1108BBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1123B38", Offset = "0x1123B38", VA = "0x1123B38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1117F64", Offset = "0x1117F64", VA = "0x1117F64")]
			set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1123B94", Offset = "0x1123B94", VA = "0x1123B94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071A")]
			[Address(RVA = "0x111BEF4", Offset = "0x111BEF4", VA = "0x111BEF4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1123BF0", Offset = "0x1123BF0", VA = "0x1123BF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1123BF8", Offset = "0x1123BF8", VA = "0x1123BF8")]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1123C04", Offset = "0x1123C04", VA = "0x1123C04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B6")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x111B8C4", Offset = "0x111B8C4", VA = "0x111B8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1112178", Offset = "0x1112178", VA = "0x1112178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x110EFDC", Offset = "0x110EFDC", VA = "0x110EFDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1123C0C", Offset = "0x1123C0C", VA = "0x1123C0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1114874", Offset = "0x1114874", VA = "0x1114874")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1105734", Offset = "0x1105734", VA = "0x1105734")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1123DE0", Offset = "0x1123DE0", VA = "0x1123DE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1106CC0", Offset = "0x1106CC0", VA = "0x1106CC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1123E3C", Offset = "0x1123E3C", VA = "0x1123E3C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1123E94", Offset = "0x1123E94", VA = "0x1123E94")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public List<string> GroupNames
		{
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1123EF0", Offset = "0x1123EF0", VA = "0x1123EF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1124308", Offset = "0x1124308", VA = "0x1124308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public List<string> BusNames
		{
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x112446C", Offset = "0x112446C", VA = "0x112446C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x112468C", Offset = "0x112468C", VA = "0x112468C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x11248AC", Offset = "0x11248AC", VA = "0x11248AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public Transform Trans
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1101F98", Offset = "0x1101F98", VA = "0x1101F98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x11249FC", Offset = "0x11249FC", VA = "0x11249FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C5")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1124A04", Offset = "0x1124A04", VA = "0x1124A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1124CA4", Offset = "0x1124CA4", VA = "0x1124CA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1124B40", Offset = "0x1124B40", VA = "0x1124B40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1124E28", Offset = "0x1124E28", VA = "0x1124E28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1124E84", Offset = "0x1124E84", VA = "0x1124E84")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1106C38", Offset = "0x1106C38", VA = "0x1106C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1124FC8", Offset = "0x1124FC8", VA = "0x1124FC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1125024", Offset = "0x1125024", VA = "0x1125024")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x11251A4", Offset = "0x11251A4", VA = "0x11251A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1125264", Offset = "0x1125264", VA = "0x1125264")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CD")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1125380", Offset = "0x1125380", VA = "0x1125380")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1125440", Offset = "0x1125440", VA = "0x1125440")]
			get
			{
				return null;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1125498", Offset = "0x1125498", VA = "0x1125498")]
			set
			{
			}
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x10FFBA0", Offset = "0x10FFBA0", VA = "0x10FFBA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x11037F0", Offset = "0x11037F0", VA = "0x11037F0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x110399C", Offset = "0x110399C", VA = "0x110399C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x1103A50", Offset = "0x1103A50", VA = "0x1103A50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x1103D00", Offset = "0x1103D00", VA = "0x1103D00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1104FE4", Offset = "0x1104FE4", VA = "0x1104FE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1105078", Offset = "0x1105078", VA = "0x1105078")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1104FF4", Offset = "0x1104FF4", VA = "0x1104FF4")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x110238C", Offset = "0x110238C", VA = "0x110238C")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x110560C", Offset = "0x110560C", VA = "0x110560C")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1105948", Offset = "0x1105948", VA = "0x1105948")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1105404", Offset = "0x1105404", VA = "0x1105404")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x11059C8", Offset = "0x11059C8", VA = "0x11059C8")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x110508C", Offset = "0x110508C", VA = "0x110508C")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1104F18", Offset = "0x1104F18", VA = "0x1104F18")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1104BC0", Offset = "0x1104BC0", VA = "0x1104BC0")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1103D88", Offset = "0x1103D88", VA = "0x1103D88")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1103F8C", Offset = "0x1103F8C", VA = "0x1103F8C")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x11042E0", Offset = "0x11042E0", VA = "0x11042E0")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1104770", Offset = "0x1104770", VA = "0x1104770")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x110456C", Offset = "0x110456C", VA = "0x110456C")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x11041C0", Offset = "0x11041C0", VA = "0x11041C0")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x11069D0", Offset = "0x11069D0", VA = "0x11069D0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1106A5C", Offset = "0x1106A5C", VA = "0x1106A5C")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x11079E4", Offset = "0x11079E4", VA = "0x11079E4")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1107BDC", Offset = "0x1107BDC", VA = "0x1107BDC")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x1107D7C", Offset = "0x1107D7C", VA = "0x1107D7C")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1107F30", Offset = "0x1107F30", VA = "0x1107F30")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1108110", Offset = "0x1108110", VA = "0x1108110")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1108314", Offset = "0x1108314", VA = "0x1108314")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1102538", Offset = "0x1102538", VA = "0x1102538")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x11084F4", Offset = "0x11084F4", VA = "0x11084F4")]
		[IteratorStateMachine(typeof(<PlaySoundAndWaitUntilFinished>d__274))]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x11085C0", Offset = "0x11085C0", VA = "0x11085C0")]
		[IteratorStateMachine(typeof(<PlaySound3DAtTransformAndWaitUntilFinished>d__275))]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x11086B4", Offset = "0x11086B4", VA = "0x11086B4")]
		[IteratorStateMachine(typeof(<PlaySound3DFollowTransformAndWaitUntilFinished>d__276))]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x11079C0", Offset = "0x11079C0", VA = "0x11079C0")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x1106D80", Offset = "0x1106D80", VA = "0x1106D80")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x110AC74", Offset = "0x110AC74", VA = "0x110AC74")]
		private static PlaySoundResult TryPlayVariationOrOtherMatches(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch, Transform sourceTrans, bool attachToSource, float delaySoundTime, bool useVector3, bool makePlaySoundResult, bool isChaining, bool isSingleSubscribedPlay, AudioInfo randomSource, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, bool forgetSoundPlayedOrScheduled, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop, List<int> otherChoices, bool hasRefilledPool, List<AudioInfo> sources, out bool soundSuccess)
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x110A888", Offset = "0x110A888", VA = "0x110A888")]
		private static bool CanPlayDialogBasedOnImportanceOrIsNotDialog(string sType, AudioGroupInfo group, bool loggingEnabledForGrp, AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1109874", Offset = "0x1109874", VA = "0x1109874")]
		private static AudioInfo UseOnlyVariationIfOnlyOne(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp, AudioInfo randomSource, MasterAudioGroup maGroup, ref bool isSingleVarLoop)
		{
			return null;
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x110A5A4", Offset = "0x110A5A4", VA = "0x110A5A4")]
		private static bool IsActorTooFarAwayToPlay(string sType, Transform sourceTrans, AudioGroupInfo group, AudioInfo randomSource, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x110A440", Offset = "0x110A440", VA = "0x110A440")]
		private static bool VariationPassesProbabilityToPlayCheck(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x110A270", Offset = "0x110A270", VA = "0x110A270")]
		private static bool IsNoClipSilentPlay(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x110A0F8", Offset = "0x110A0F8", VA = "0x110A0F8")]
		private static bool VariationIsUsable(AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x110998C", Offset = "0x110998C", VA = "0x110998C")]
		private static bool CanFindVariationToPlay(string sType, string variationName, bool isNonSpecific, bool canUseBusVoiceToStop, List<AudioInfo> sources, bool loggingEnabledForGrp, SoundGroupVariation busVoiceToStop, ref AudioInfo randomSource, ref List<int> choices, ref int? randomIndex, ref int pickedChoice, ref List<int> otherChoices)
		{
			return default(bool);
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1109488", Offset = "0x1109488", VA = "0x1109488")]
		private static SoundGroupVariation FindBusVoiceToStop(GroupBus groupBus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x110938C", Offset = "0x110938C", VA = "0x110938C")]
		private static bool CanStopLimitedBusVoice(GroupBus groupBus, bool loggingEnabledForGrp, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1109364", Offset = "0x1109364", VA = "0x1109364")]
		private static bool IsBusVoiceLimited(GroupBus groupBus)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1109018", Offset = "0x1109018", VA = "0x1109018")]
		private static AudioInfo FindRetriggerableVariationInGroup(string variationName, bool isNonSpecific, List<AudioInfo> sources, MasterAudioGroup maGroup)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1108FC0", Offset = "0x1108FC0", VA = "0x1108FC0")]
		private static bool IsGroupPolyphonyLimited(MasterAudioGroup maGroup, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1108E58", Offset = "0x1108E58", VA = "0x1108E58")]
		private static bool IsReplayLimited(string sType, MasterAudioGroup maGroup, AudioGroupInfo group, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1108C7C", Offset = "0x1108C7C", VA = "0x1108C7C")]
		private static void LogIfSilentPlay(string sType, bool loggingEnabledForGrp, MasterAudioGroup maGroup)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1108AE4", Offset = "0x1108AE4", VA = "0x1108AE4")]
		private static bool SoundGroupHasVariations(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x11087A8", Offset = "0x11087A8", VA = "0x11087A8")]
		private static bool IsSoundGroupValidAndReady(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x110BE24", Offset = "0x110BE24", VA = "0x110BE24")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x110B1DC", Offset = "0x110B1DC", VA = "0x110B1DC")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x110B924", Offset = "0x110B924", VA = "0x110B924")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x110B20C", Offset = "0x110B20C", VA = "0x110B20C")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x110C844", Offset = "0x110C844", VA = "0x110C844")]
		private static void FadeOldestOrFarthestBusVoice(SoundGroupVariation busVoiceToStop, GroupBus groupBus)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x110C910", Offset = "0x110C910", VA = "0x110C910")]
		public static void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x110C9B8", Offset = "0x110C9B8", VA = "0x110C9B8")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource, SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x110CB90", Offset = "0x110CB90", VA = "0x110CB90")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x110CFCC", Offset = "0x110CFCC", VA = "0x110CFCC")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x110D274", Offset = "0x110D274", VA = "0x110D274")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x110D438", Offset = "0x110D438", VA = "0x110D438")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x110D674", Offset = "0x110D674", VA = "0x110D674")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x110D838", Offset = "0x110D838", VA = "0x110D838")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x110DA74", Offset = "0x110DA74", VA = "0x110DA74")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x110DC38", Offset = "0x110DC38", VA = "0x110DC38")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x110E1C0", Offset = "0x110E1C0", VA = "0x110E1C0")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x110E404", Offset = "0x110E404", VA = "0x110E404")]
		public static void FadeSoundGroupOfTransformToVolume(Transform sourceTrans, string sType, float fadeTime, float targetVolume)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x11064D4", Offset = "0x11064D4", VA = "0x11064D4")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x110BB88", Offset = "0x110BB88", VA = "0x110BB88")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x110E618", Offset = "0x110E618", VA = "0x110E618")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x110DE2C", Offset = "0x110DE2C", VA = "0x110DE2C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x110E950", Offset = "0x110E950", VA = "0x110E950")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x110ED64", Offset = "0x110ED64", VA = "0x110ED64")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x110F038", Offset = "0x110F038", VA = "0x110F038")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x110FE08", Offset = "0x110FE08", VA = "0x110FE08")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x111063C", Offset = "0x111063C", VA = "0x111063C")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x11109AC", Offset = "0x11109AC", VA = "0x11109AC")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1110CB8", Offset = "0x1110CB8", VA = "0x1110CB8")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1110E80", Offset = "0x1110E80", VA = "0x1110E80")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x111110C", Offset = "0x111110C", VA = "0x111110C")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x11114EC", Offset = "0x11114EC", VA = "0x11114EC")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x11117F0", Offset = "0x11117F0", VA = "0x11117F0")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1111900", Offset = "0x1111900", VA = "0x1111900")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1111AE8", Offset = "0x1111AE8", VA = "0x1111AE8")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x11126A4", Offset = "0x11126A4", VA = "0x11126A4")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1105B34", Offset = "0x1105B34", VA = "0x1105B34")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1112F98", Offset = "0x1112F98", VA = "0x1112F98")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x111302C", Offset = "0x111302C", VA = "0x111302C")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x11131B8", Offset = "0x11131B8", VA = "0x11131B8")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1113308", Offset = "0x1113308", VA = "0x1113308")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1113480", Offset = "0x1113480", VA = "0x1113480")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x111360C", Offset = "0x111360C", VA = "0x111360C")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1113AA4", Offset = "0x1113AA4", VA = "0x1113AA4")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1113C64", Offset = "0x1113C64", VA = "0x1113C64")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1113E04", Offset = "0x1113E04", VA = "0x1113E04")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x11144A8", Offset = "0x11144A8", VA = "0x11144A8")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1114CD8", Offset = "0x1114CD8", VA = "0x1114CD8")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, int? creatorInstanceId, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1115FBC", Offset = "0x1115FBC", VA = "0x1115FBC")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1106230", Offset = "0x1106230", VA = "0x1106230")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x11036C8", Offset = "0x11036C8", VA = "0x11036C8")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x111617C", Offset = "0x111617C", VA = "0x111617C")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1102038", Offset = "0x1102038", VA = "0x1102038")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x111642C", Offset = "0x111642C", VA = "0x111642C")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1116268", Offset = "0x1116268", VA = "0x1116268")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1103AF0", Offset = "0x1103AF0", VA = "0x1103AF0")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1114A20", Offset = "0x1114A20", VA = "0x1114A20")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x11164C0", Offset = "0x11164C0", VA = "0x11164C0")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1116068", Offset = "0x1116068", VA = "0x1116068")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1112264", Offset = "0x1112264", VA = "0x1112264")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1112610", Offset = "0x1112610", VA = "0x1112610")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x1116868", Offset = "0x1116868", VA = "0x1116868")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x1116998", Offset = "0x1116998", VA = "0x1116998")]
		private static void UnsilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x1116730", Offset = "0x1116730", VA = "0x1116730")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x1116A34", Offset = "0x1116A34", VA = "0x1116A34")]
		private static void SilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1116AD0", Offset = "0x1116AD0", VA = "0x1116AD0")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x110CD68", Offset = "0x110CD68", VA = "0x110CD68")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1116BE8", Offset = "0x1116BE8", VA = "0x1116BE8")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1116CD4", Offset = "0x1116CD4", VA = "0x1116CD4")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1116EA8", Offset = "0x1116EA8", VA = "0x1116EA8")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1117004", Offset = "0x1117004", VA = "0x1117004")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x11170D8", Offset = "0x11170D8", VA = "0x11170D8")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1117240", Offset = "0x1117240", VA = "0x1117240")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1117324", Offset = "0x1117324", VA = "0x1117324")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1117480", Offset = "0x1117480", VA = "0x1117480")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1117668", Offset = "0x1117668", VA = "0x1117668")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1117850", Offset = "0x1117850", VA = "0x1117850")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1117AA4", Offset = "0x1117AA4", VA = "0x1117AA4")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1117D00", Offset = "0x1117D00", VA = "0x1117D00")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1117DB0", Offset = "0x1117DB0", VA = "0x1117DB0")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1117E60", Offset = "0x1117E60", VA = "0x1117E60")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1117F10", Offset = "0x1117F10", VA = "0x1117F10")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1118320", Offset = "0x1118320", VA = "0x1118320")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x11183D4", Offset = "0x11183D4", VA = "0x11183D4")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1106860", Offset = "0x1106860", VA = "0x1106860")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x11121D4", Offset = "0x11121D4", VA = "0x11121D4")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x11186F4", Offset = "0x11186F4", VA = "0x11186F4")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1118894", Offset = "0x1118894", VA = "0x1118894")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1118D04", Offset = "0x1118D04", VA = "0x1118D04")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1118EB4", Offset = "0x1118EB4", VA = "0x1118EB4")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1118F78", Offset = "0x1118F78", VA = "0x1118F78")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x11190F0", Offset = "0x11190F0", VA = "0x11190F0")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1118B54", Offset = "0x1118B54", VA = "0x1118B54")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x11192CC", Offset = "0x11192CC", VA = "0x11192CC")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x110C3A8", Offset = "0x110C3A8", VA = "0x110C3A8")]
		private static SoundGroupVariation FindLeastImportantSoundOnBus(GroupBus bus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x110C0AC", Offset = "0x110C0AC", VA = "0x110C0AC")]
		private static SoundGroupVariation FindFarthestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x110BE54", Offset = "0x110BE54", VA = "0x110BE54")]
		private static SoundGroupVariation FindOldestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1106038", Offset = "0x1106038", VA = "0x1106038")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1119440", Offset = "0x1119440", VA = "0x1119440")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x11195A0", Offset = "0x11195A0", VA = "0x11195A0")]
		public static bool CreateBus(string busName, int? actorInstanceId, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1119900", Offset = "0x1119900", VA = "0x1119900")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1119988", Offset = "0x1119988", VA = "0x1119988")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x110C7A4", Offset = "0x110C7A4", VA = "0x110C7A4")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1119DFC", Offset = "0x1119DFC", VA = "0x1119DFC")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x111A2B8", Offset = "0x111A2B8", VA = "0x111A2B8")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x111A4E4", Offset = "0x111A4E4", VA = "0x111A4E4")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x111A6F0", Offset = "0x111A6F0", VA = "0x111A6F0")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1102288", Offset = "0x1102288", VA = "0x1102288")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1119C58", Offset = "0x1119C58", VA = "0x1119C58")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1112428", Offset = "0x1112428", VA = "0x1112428")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1118A70", Offset = "0x1118A70", VA = "0x1118A70")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x111AEB0", Offset = "0x111AEB0", VA = "0x111AEB0")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x111B068", Offset = "0x111B068", VA = "0x111B068")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x111B220", Offset = "0x111B220", VA = "0x111B220")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x111B448", Offset = "0x111B448", VA = "0x111B448")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x111B618", Offset = "0x111B618", VA = "0x111B618")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x111B728", Offset = "0x111B728", VA = "0x111B728")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x111B920", Offset = "0x111B920", VA = "0x111B920")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x111BA3C", Offset = "0x111BA3C", VA = "0x111BA3C")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x111BAA0", Offset = "0x111BAA0", VA = "0x111BAA0")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x11182C0", Offset = "0x11182C0", VA = "0x11182C0")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x111BE1C", Offset = "0x111BE1C", VA = "0x111BE1C")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x111BFD8", Offset = "0x111BFD8", VA = "0x111BFD8")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x111C03C", Offset = "0x111C03C", VA = "0x111C03C")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1118374", Offset = "0x1118374", VA = "0x1118374")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x111C2E8", Offset = "0x111C2E8", VA = "0x111C2E8")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x111C3C0", Offset = "0x111C3C0", VA = "0x111C3C0")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x111C424", Offset = "0x111C424", VA = "0x111C424")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x111C760", Offset = "0x111C760", VA = "0x111C760")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x111C6D0", Offset = "0x111C6D0", VA = "0x111C6D0")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x111C7C0", Offset = "0x111C7C0", VA = "0x111C7C0")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x111C824", Offset = "0x111C824", VA = "0x111C824")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1117E00", Offset = "0x1117E00", VA = "0x1117E00")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x111CAD0", Offset = "0x111CAD0", VA = "0x111CAD0")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x111CB60", Offset = "0x111CB60", VA = "0x111CB60")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x111CBC4", Offset = "0x111CBC4", VA = "0x111CBC4")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x1117EB0", Offset = "0x1117EB0", VA = "0x1117EB0")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x111CE70", Offset = "0x111CE70", VA = "0x111CE70")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x111CF00", Offset = "0x111CF00", VA = "0x111CF00")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x111CF64", Offset = "0x111CF64", VA = "0x111CF64")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1117D50", Offset = "0x1117D50", VA = "0x1117D50")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x111D210", Offset = "0x111D210", VA = "0x111D210")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x111D2A4", Offset = "0x111D2A4", VA = "0x111D2A4")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x111D308", Offset = "0x111D308", VA = "0x111D308")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x111D644", Offset = "0x111D644", VA = "0x111D644")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x111D5B4", Offset = "0x111D5B4", VA = "0x111D5B4")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x111D6A4", Offset = "0x111D6A4", VA = "0x111D6A4")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x111D708", Offset = "0x111D708", VA = "0x111D708")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x111DA44", Offset = "0x111DA44", VA = "0x111DA44")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x111D9B4", Offset = "0x111D9B4", VA = "0x111D9B4")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x111DAA4", Offset = "0x111DAA4", VA = "0x111DAA4")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x111DB08", Offset = "0x111DB08", VA = "0x111DB08")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x111DDCC", Offset = "0x111DDCC", VA = "0x111DDCC")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x111DD38", Offset = "0x111DD38", VA = "0x111DD38")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x111DE2C", Offset = "0x111DE2C", VA = "0x111DE2C")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x111E1B0", Offset = "0x111E1B0", VA = "0x111E1B0")]
		public static void StartPlaylistOnClip(string playlistName, string clipName)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x111DE9C", Offset = "0x111DE9C", VA = "0x111DE9C")]
		public static void StartPlaylist(string playlistControllerName, string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x111E22C", Offset = "0x111E22C", VA = "0x111E22C")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x111E31C", Offset = "0x111E31C", VA = "0x111E31C")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x111E380", Offset = "0x111E380", VA = "0x111E380")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x111E28C", Offset = "0x111E28C", VA = "0x111E28C")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x111E5B0", Offset = "0x111E5B0", VA = "0x111E5B0")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x111E6A0", Offset = "0x111E6A0", VA = "0x111E6A0")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x111E704", Offset = "0x111E704", VA = "0x111E704")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x111E610", Offset = "0x111E610", VA = "0x111E610")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x111E934", Offset = "0x111E934", VA = "0x111E934")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x111E9A0", Offset = "0x111E9A0", VA = "0x111E9A0")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x111EB20", Offset = "0x111EB20", VA = "0x111EB20")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x111EB8C", Offset = "0x111EB8C", VA = "0x111EB8C")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x111ED0C", Offset = "0x111ED0C", VA = "0x111ED0C")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x111ED88", Offset = "0x111ED88", VA = "0x111ED88")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x111EF10", Offset = "0x111EF10", VA = "0x111EF10")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x111EF8C", Offset = "0x111EF8C", VA = "0x111EF8C")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x111F3A8", Offset = "0x111F3A8", VA = "0x111F3A8")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x111F254", Offset = "0x111F254", VA = "0x111F254")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x111F420", Offset = "0x111F420", VA = "0x111F420")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x111F5BC", Offset = "0x111F5BC", VA = "0x111F5BC")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x111F768", Offset = "0x111F768", VA = "0x111F768")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f, [Optional] string alias)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x111F854", Offset = "0x111F854", VA = "0x111F854")]
		public static void AddSongToPlaylist(string playlistName, MusicSetting newSong)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x111FF44", Offset = "0x111FF44", VA = "0x111FF44")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x112008C", Offset = "0x112008C", VA = "0x112008C")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x11203F8", Offset = "0x11203F8", VA = "0x11203F8")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x11207F8", Offset = "0x11207F8", VA = "0x11207F8")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1120C48", Offset = "0x1120C48", VA = "0x1120C48")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1120FB8", Offset = "0x1120FB8", VA = "0x1120FB8")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, int? actorInstanceId, bool errorOnDuplicates, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1121304", Offset = "0x1121304", VA = "0x1121304")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, int? actorInstanceId, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x11216B8", Offset = "0x11216B8", VA = "0x11216B8")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x112186C", Offset = "0x112186C", VA = "0x112186C")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x110273C", Offset = "0x110273C", VA = "0x110273C")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x11202B4", Offset = "0x11202B4", VA = "0x11202B4")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1121960", Offset = "0x1121960", VA = "0x1121960")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1121ACC", Offset = "0x1121ACC", VA = "0x1121ACC")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1121C38", Offset = "0x1121C38", VA = "0x1121C38")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x11089F0", Offset = "0x11089F0", VA = "0x11089F0")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1109260", Offset = "0x1109260", VA = "0x1109260")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x110C708", Offset = "0x110C708", VA = "0x110C708")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1122100", Offset = "0x1122100", VA = "0x1122100")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x110C66C", Offset = "0x110C66C", VA = "0x110C66C")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1122210", Offset = "0x1122210", VA = "0x1122210")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x111BD4C", Offset = "0x111BD4C", VA = "0x111BD4C")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x1122438", Offset = "0x1122438", VA = "0x1122438")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x11226B8", Offset = "0x11226B8", VA = "0x11226B8")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1122924", Offset = "0x1122924", VA = "0x1122924")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1122B80", Offset = "0x1122B80", VA = "0x1122B80")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1122DDC", Offset = "0x1122DDC", VA = "0x1122DDC")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1122FF0", Offset = "0x1122FF0", VA = "0x1122FF0")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x112336C", Offset = "0x112336C", VA = "0x112336C")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1123514", Offset = "0x1123514", VA = "0x1123514")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x112358C", Offset = "0x112358C", VA = "0x112358C")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x11113C0", Offset = "0x11113C0", VA = "0x11113C0")]
		public static bool IsOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x110FC9C", Offset = "0x110FC9C", VA = "0x110FC9C")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x112321C", Offset = "0x112321C", VA = "0x112321C")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1123668", Offset = "0x1123668", VA = "0x1123668")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x112387C", Offset = "0x112387C", VA = "0x112387C")]
		public static bool IsVideoPlayersGroup(string groupName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x110E568", Offset = "0x110E568", VA = "0x110E568")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x11239A4", Offset = "0x11239A4", VA = "0x11239A4")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0x1114C78", Offset = "0x1114C78", VA = "0x1114C78")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x1125324", Offset = "0x1125324", VA = "0x1125324")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x11254F8", Offset = "0x11254F8", VA = "0x11254F8")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x1125690", Offset = "0x1125690", VA = "0x1125690")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1125828", Offset = "0x1125828", VA = "0x1125828")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x11259C0", Offset = "0x11259C0", VA = "0x11259C0")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x1125B58", Offset = "0x1125B58", VA = "0x1125B58")]
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
			[Address(RVA = "0x1139A8C", Offset = "0x1139A8C", VA = "0x1139A8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x1139B04", Offset = "0x1139B04", VA = "0x1139B04")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x1139C20", Offset = "0x1139C20", VA = "0x1139C20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x1139C98", Offset = "0x1139C98", VA = "0x1139C98")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x1139F08", Offset = "0x1139F08", VA = "0x1139F08")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1139F9C", Offset = "0x1139F9C", VA = "0x1139F9C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public static float? MixerVolume
		{
			[Token(Token = "0x6000786")]
			[Address(RVA = "0x113A0D4", Offset = "0x113A0D4", VA = "0x113A0D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x113A160", Offset = "0x113A160", VA = "0x113A160")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x113A290", Offset = "0x113A290", VA = "0x113A290")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x113A324", Offset = "0x113A324", VA = "0x113A324")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public static float? MusicVolume
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x113A45C", Offset = "0x113A45C", VA = "0x113A45C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x113A4E8", Offset = "0x113A4E8", VA = "0x113A4E8")]
			set
			{
			}
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x11398CC", Offset = "0x11398CC", VA = "0x11398CC")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1139A40", Offset = "0x1139A40", VA = "0x1139A40")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1139B50", Offset = "0x1139B50", VA = "0x1139B50")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1139BD4", Offset = "0x1139BD4", VA = "0x1139BD4")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1139CE4", Offset = "0x1139CE4", VA = "0x1139CE4")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1139E84", Offset = "0x1139E84", VA = "0x1139E84")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x113A618", Offset = "0x113A618", VA = "0x113A618")]
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
			[Address(RVA = "0x113AB28", Offset = "0x113AB28", VA = "0x113AB28")]
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
			[Address(RVA = "0x113AB64", Offset = "0x113AB64", VA = "0x113AB64")]
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
		[Address(RVA = "0x113A7C8", Offset = "0x113A7C8", VA = "0x113A7C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x113A830", Offset = "0x113A830", VA = "0x113A830")]
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
			[Address(RVA = "0x113B020", Offset = "0x113B020", VA = "0x113B020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x113AC44", Offset = "0x113AC44", VA = "0x113AC44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x113B4C8", Offset = "0x113B4C8", VA = "0x113B4C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public static int AmbientCount
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x113B554", Offset = "0x113B554", VA = "0x113B554")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000E0")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x113B5C4", Offset = "0x113B5C4", VA = "0x113B5C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x113ABA0", Offset = "0x113ABA0", VA = "0x113ABA0")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x113AF04", Offset = "0x113AF04", VA = "0x113AF04")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x113AF98", Offset = "0x113AF98", VA = "0x113AF98")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x113B018", Offset = "0x113B018", VA = "0x113B018")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x113B31C", Offset = "0x113B31C", VA = "0x113B31C")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x113B400", Offset = "0x113B400", VA = "0x113B400")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x113B65C", Offset = "0x113B65C", VA = "0x113B65C")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x113B764", Offset = "0x113B764", VA = "0x113B764")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000120")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x113B7E4", Offset = "0x113B7E4", VA = "0x113B7E4")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x113B85C", Offset = "0x113B85C", VA = "0x113B85C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x113B8B4", Offset = "0x113B8B4", VA = "0x113B8B4")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x113B958", Offset = "0x113B958", VA = "0x113B958")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x113BA0C", Offset = "0x113BA0C", VA = "0x113BA0C")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x113BAB0", Offset = "0x113BAB0", VA = "0x113BAB0")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x113BB64", Offset = "0x113BB64", VA = "0x113BB64")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x113BC1C", Offset = "0x113BC1C", VA = "0x113BC1C")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x113BCD4", Offset = "0x113BCD4", VA = "0x113BCD4")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x113BD2C", Offset = "0x113BD2C", VA = "0x113BD2C")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x113BD94", Offset = "0x113BD94", VA = "0x113BD94")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x113BDFC", Offset = "0x113BDFC", VA = "0x113BDFC")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x113BE54", Offset = "0x113BE54", VA = "0x113BE54")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x113BEBC", Offset = "0x113BEBC", VA = "0x113BEBC")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x113BF24", Offset = "0x113BF24", VA = "0x113BF24")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x113BF7C", Offset = "0x113BF7C", VA = "0x113BF7C")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x113BFE4", Offset = "0x113BFE4", VA = "0x113BFE4")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x113C04C", Offset = "0x113C04C", VA = "0x113C04C")]
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
			[Address(RVA = "0x113C0B4", Offset = "0x113C0B4", VA = "0x113C0B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x113C148", Offset = "0x113C148", VA = "0x113C148")]
		private void Update()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x113C158", Offset = "0x113C158", VA = "0x113C158")]
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
			[Address(RVA = "0x113C1C4", Offset = "0x113C1C4", VA = "0x113C1C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E3")]
		public static float FrameTime
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x113C1CC", Offset = "0x113C1CC", VA = "0x113C1CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E4")]
		public static float Time
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x113C1D4", Offset = "0x113C1D4", VA = "0x113C1D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E5")]
		public static int FrameCount
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x113C1DC", Offset = "0x113C1DC", VA = "0x113C1DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x113C160", Offset = "0x113C160", VA = "0x113C160")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x113C19C", Offset = "0x113C19C", VA = "0x113C19C")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x113C1B0", Offset = "0x113C1B0", VA = "0x113C1B0")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x113C1E4", Offset = "0x113C1E4", VA = "0x113C1E4")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x113C224", Offset = "0x113C224", VA = "0x113C224")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x113C2FC", Offset = "0x113C2FC", VA = "0x113C2FC")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x113C33C", Offset = "0x113C33C", VA = "0x113C33C")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x113C354", Offset = "0x113C354", VA = "0x113C354")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x113C364", Offset = "0x113C364", VA = "0x113C364")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x113C440", Offset = "0x113C440", VA = "0x113C440")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x113C47C", Offset = "0x113C47C", VA = "0x113C47C")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x113C578", Offset = "0x113C578", VA = "0x113C578")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x113C4F4", Offset = "0x113C4F4", VA = "0x113C4F4")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x113C658", Offset = "0x113C658", VA = "0x113C658")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x113C6E0", Offset = "0x113C6E0", VA = "0x113C6E0")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x113C708", Offset = "0x113C708", VA = "0x113C708")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x113C718", Offset = "0x113C718", VA = "0x113C718")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x113C750", Offset = "0x113C750", VA = "0x113C750")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x113C764", Offset = "0x113C764", VA = "0x113C764")]
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
				[Address(RVA = "0x113C8E0", Offset = "0x113C8E0", VA = "0x113C8E0", Slot = "4")]
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
				[Address(RVA = "0x113C928", Offset = "0x113C928", VA = "0x113C928", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0x113C7F4", Offset = "0x113C7F4", VA = "0x113C7F4")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60007CF")]
			[Address(RVA = "0x113C81C", Offset = "0x113C81C", VA = "0x113C81C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x113C820", Offset = "0x113C820", VA = "0x113C820", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x113C8E8", Offset = "0x113C8E8", VA = "0x113C8E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x113C784", Offset = "0x113C784", VA = "0x113C784")]
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
				[Address(RVA = "0x113D0F4", Offset = "0x113D0F4", VA = "0x113D0F4", Slot = "4")]
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
				[Address(RVA = "0x113D13C", Offset = "0x113D13C", VA = "0x113D13C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x113CE9C", Offset = "0x113CE9C", VA = "0x113CE9C")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x113CF28", Offset = "0x113CF28", VA = "0x113CF28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x113CF2C", Offset = "0x113CF2C", VA = "0x113CF2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x113D0FC", Offset = "0x113D0FC", VA = "0x113D0FC", Slot = "8")]
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
		[Address(RVA = "0x113C930", Offset = "0x113C930", VA = "0x113C930")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x113CCD8", Offset = "0x113CCD8", VA = "0x113CCD8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x113CDFC", Offset = "0x113CDFC", VA = "0x113CDFC")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x113CE28", Offset = "0x113CE28", VA = "0x113CE28")]
		[IteratorStateMachine(typeof(<PlaySongWithDelay>d__7))]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x113CEC4", Offset = "0x113CEC4", VA = "0x113CEC4")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x113D144", Offset = "0x113D144", VA = "0x113D144")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x113D158", Offset = "0x113D158", VA = "0x113D158")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x113D16C", Offset = "0x113D16C", VA = "0x113D16C")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x113D184", Offset = "0x113D184", VA = "0x113D184")]
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
			[Address(RVA = "0x113EF54", Offset = "0x113EF54", VA = "0x113EF54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000EB")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x113EFC8", Offset = "0x113EFC8", VA = "0x113EFC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public int InstanceId
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x113EBD8", Offset = "0x113EBD8", VA = "0x113EBD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000ED")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x113EFD0", Offset = "0x113EFD0", VA = "0x113EFD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x113D398", Offset = "0x113D398", VA = "0x113D398")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x113D474", Offset = "0x113D474", VA = "0x113D474")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x113D54C", Offset = "0x113D54C", VA = "0x113D54C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x113D550", Offset = "0x113D550", VA = "0x113D550")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x113D478", Offset = "0x113D478", VA = "0x113D478")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x113D64C", Offset = "0x113D64C", VA = "0x113D64C")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x113DD38", Offset = "0x113DD38", VA = "0x113DD38")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x113EF64", Offset = "0x113EF64", VA = "0x113EF64")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x113EC10", Offset = "0x113EC10", VA = "0x113EC10")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x113EFD8", Offset = "0x113EFD8", VA = "0x113EFD8")]
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
		[Address(RVA = "0x113F518", Offset = "0x113F518", VA = "0x113F518")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x113F9C0", Offset = "0x113F9C0", VA = "0x113F9C0")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x113FA34", Offset = "0x113FA34", VA = "0x113FA34")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x113FB28", Offset = "0x113FB28", VA = "0x113FB28")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x113FC68", Offset = "0x113FC68", VA = "0x113FC68")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x113FDB0", Offset = "0x113FDB0", VA = "0x113FDB0")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x113FEF4", Offset = "0x113FEF4", VA = "0x113FEF4")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x113FFC0", Offset = "0x113FFC0", VA = "0x113FFC0")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x11400CC", Offset = "0x11400CC", VA = "0x11400CC")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x1140250", Offset = "0x1140250", VA = "0x1140250")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x11403A4", Offset = "0x11403A4", VA = "0x11403A4")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1140520", Offset = "0x1140520", VA = "0x1140520")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1140674", Offset = "0x1140674", VA = "0x1140674")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1140770", Offset = "0x1140770", VA = "0x1140770")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x11408D0", Offset = "0x11408D0", VA = "0x11408D0")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1140944", Offset = "0x1140944", VA = "0x1140944")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x11409B0", Offset = "0x11409B0", VA = "0x11409B0")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1140B30", Offset = "0x1140B30", VA = "0x1140B30")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x113F6C4", Offset = "0x113F6C4", VA = "0x113F6C4")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x1141068", Offset = "0x1141068", VA = "0x1141068")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x1141110", Offset = "0x1141110", VA = "0x1141110")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x11411B8", Offset = "0x11411B8", VA = "0x11411B8")]
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
			[Address(RVA = "0x1147B74", Offset = "0x1147B74", VA = "0x1147B74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EF")]
		public bool CurrentSongIsPlaying
		{
			[Token(Token = "0x6000848")]
			[Address(RVA = "0x1147D18", Offset = "0x1147D18", VA = "0x1147D18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F0")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000857")]
			[Address(RVA = "0x11490D8", Offset = "0x11490D8", VA = "0x11490D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F1")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000859")]
			[Address(RVA = "0x1149124", Offset = "0x1149124", VA = "0x1149124")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600085A")]
			[Address(RVA = "0x114912C", Offset = "0x114912C", VA = "0x114912C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F2")]
		public FadeStatus CurrentFadeStatus
		{
			[Token(Token = "0x600085B")]
			[Address(RVA = "0x1149138", Offset = "0x1149138", VA = "0x1149138")]
			get
			{
				return default(FadeStatus);
			}
		}

		[Token(Token = "0x170000F3")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600085C")]
			[Address(RVA = "0x1144E50", Offset = "0x1144E50", VA = "0x1144E50")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000F4")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600085D")]
			[Address(RVA = "0x1143688", Offset = "0x1143688", VA = "0x1143688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600085E")]
			[Address(RVA = "0x114514C", Offset = "0x114514C", VA = "0x114514C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600085F")]
			[Address(RVA = "0x1149164", Offset = "0x1149164", VA = "0x1149164")]
			set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000860")]
			[Address(RVA = "0x11491BC", Offset = "0x11491BC", VA = "0x11491BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F7")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000861")]
			[Address(RVA = "0x11491C4", Offset = "0x11491C4", VA = "0x11491C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x11491CC", Offset = "0x11491CC", VA = "0x11491CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F9")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x1149254", Offset = "0x1149254", VA = "0x1149254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x11492E4", Offset = "0x11492E4", VA = "0x11492E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FB")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x11492FC", Offset = "0x11492FC", VA = "0x11492FC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x1149304", Offset = "0x1149304", VA = "0x1149304")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool IsFading
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x1149310", Offset = "0x1149310", VA = "0x1149310")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FD")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x114777C", Offset = "0x114777C", VA = "0x114777C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x1149330", Offset = "0x1149330", VA = "0x1149330")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x600086B")]
			[Address(RVA = "0x1147E6C", Offset = "0x1147E6C", VA = "0x1147E6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public bool HasPlaylist
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x11454CC", Offset = "0x11454CC", VA = "0x11454CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000100")]
		public string PlaylistName
		{
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x1149378", Offset = "0x1149378", VA = "0x1149378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000101")]
		public MusicSetting CurrentSong
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x11493E8", Offset = "0x11493E8", VA = "0x11493E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private bool IsMuted
		{
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x11493F0", Offset = "0x11493F0", VA = "0x11493F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000103")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0x1145650", Offset = "0x1145650", VA = "0x1145650")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000871")]
			[Address(RVA = "0x1144C98", Offset = "0x1144C98", VA = "0x1144C98")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000105")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1144D18", Offset = "0x1144D18", VA = "0x1144D18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000106")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1146048", Offset = "0x1146048", VA = "0x1146048")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000107")]
		public string ControllerName
		{
			[Token(Token = "0x6000874")]
			[Address(RVA = "0x1141D40", Offset = "0x1141D40", VA = "0x1141D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000875")]
			[Address(RVA = "0x1142460", Offset = "0x1142460", VA = "0x1142460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000109")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000876")]
			[Address(RVA = "0x1142CF8", Offset = "0x1142CF8", VA = "0x1142CF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1144E24", Offset = "0x1144E24", VA = "0x1144E24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010B")]
		private bool IsPlayingScheduledLoopSection
		{
			[Token(Token = "0x6000878")]
			[Address(RVA = "0x11440F8", Offset = "0x11440F8", VA = "0x11440F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010C")]
		private bool IsCurrentSongLoopSection
		{
			[Token(Token = "0x6000879")]
			[Address(RVA = "0x11447AC", Offset = "0x11447AC", VA = "0x11447AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		private Transform Trans
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x1142C10", Offset = "0x1142C10", VA = "0x1142C10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x600087B")]
			[Address(RVA = "0x11493F8", Offset = "0x11493F8", VA = "0x11493F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x11413E0", Offset = "0x11413E0", VA = "0x11413E0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x1141480", Offset = "0x1141480", VA = "0x1141480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x113CC38", Offset = "0x113CC38", VA = "0x113CC38")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x113CD5C", Offset = "0x113CD5C", VA = "0x113CD5C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x1141520", Offset = "0x1141520", VA = "0x1141520")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x11415C0", Offset = "0x11415C0", VA = "0x11415C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x1141660", Offset = "0x1141660", VA = "0x1141660")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1141700", Offset = "0x1141700", VA = "0x1141700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x11417A0", Offset = "0x11417A0", VA = "0x11417A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x1141D88", Offset = "0x1141D88", VA = "0x1141D88")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x11420A0", Offset = "0x11420A0", VA = "0x11420A0")]
		private void DetectAndRescheduleNextGaplessSongIfOff()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x1142818", Offset = "0x1142818", VA = "0x1142818")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x1142978", Offset = "0x1142978", VA = "0x1142978")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x1141FFC", Offset = "0x1141FFC", VA = "0x1141FFC")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x1142A04", Offset = "0x1142A04", VA = "0x1142A04")]
		private void Start()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1142C9C", Offset = "0x1142C9C", VA = "0x1142C9C")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x1142DB0", Offset = "0x1142DB0", VA = "0x1142DB0")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x1143208", Offset = "0x1143208", VA = "0x1143208")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x11433A8", Offset = "0x11433A8", VA = "0x11433A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x1143748", Offset = "0x1143748", VA = "0x1143748")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x1143754", Offset = "0x1143754", VA = "0x1143754")]
		private void Update()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x113C9D4", Offset = "0x113C9D4", VA = "0x113C9D4")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x114537C", Offset = "0x114537C", VA = "0x114537C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x11454DC", Offset = "0x11454DC", VA = "0x11454DC")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x11455A0", Offset = "0x11455A0", VA = "0x11455A0")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x1142CF0", Offset = "0x1142CF0", VA = "0x1142CF0")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000827")]
		[Address(RVA = "0x1145648", Offset = "0x1145648", VA = "0x1145648")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000828")]
		[Address(RVA = "0x11457A4", Offset = "0x11457A4", VA = "0x11457A4")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000829")]
		[Address(RVA = "0x1145988", Offset = "0x1145988", VA = "0x1145988")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x600082A")]
		[Address(RVA = "0x11430DC", Offset = "0x11430DC", VA = "0x11430DC")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x600082B")]
		[Address(RVA = "0x11460D4", Offset = "0x11460D4", VA = "0x11460D4")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x11461FC", Offset = "0x11461FC", VA = "0x11461FC")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x1146284", Offset = "0x1146284", VA = "0x1146284")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x114645C", Offset = "0x114645C", VA = "0x114645C")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x11466F4", Offset = "0x11466F4", VA = "0x11466F4")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x113D06C", Offset = "0x113D06C", VA = "0x113D06C")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x1146848", Offset = "0x1146848", VA = "0x1146848")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x11469F4", Offset = "0x11469F4", VA = "0x11469F4")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x1146A64", Offset = "0x1146A64", VA = "0x1146A64")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x1146C50", Offset = "0x1146C50", VA = "0x1146C50")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x1146DE0", Offset = "0x1146DE0", VA = "0x1146DE0")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x114720C", Offset = "0x114720C", VA = "0x114720C")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x1147528", Offset = "0x1147528", VA = "0x1147528")]
		public void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x11475BC", Offset = "0x11475BC", VA = "0x11475BC")]
		public void DuckMusicForTime(SoundGroupVariationUpdater actorUpdater, float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x1147754", Offset = "0x1147754", VA = "0x1147754")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x1142FCC", Offset = "0x1142FCC", VA = "0x1142FCC")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x11477DC", Offset = "0x11477DC", VA = "0x11477DC")]
		public void StartPlaylist(string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x1147944", Offset = "0x1147944", VA = "0x1147944")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x1145EE0", Offset = "0x1145EE0", VA = "0x1145EE0")]
		private void FinishPlaylistInit(bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x11478B4", Offset = "0x11478B4", VA = "0x11478B4")]
		public void RestartPlaylist([Optional] string clipName)
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x1147A88", Offset = "0x1147A88", VA = "0x1147A88")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x1147BAC", Offset = "0x1147BAC", VA = "0x1147BAC")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x1144F48", Offset = "0x1144F48", VA = "0x1144F48")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x1142BE8", Offset = "0x1142BE8", VA = "0x1142BE8")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1142D1C", Offset = "0x1142D1C", VA = "0x1142D1C")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x1144D44", Offset = "0x1144D44", VA = "0x1144D44")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x11464EC", Offset = "0x11464EC", VA = "0x11464EC")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x11441AC", Offset = "0x11441AC", VA = "0x11441AC")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType, bool isLoopSectionSchedule, bool isQueuedSong = false)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x1148A9C", Offset = "0x1148A9C", VA = "0x1148A9C")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x1147F10", Offset = "0x1147F10", VA = "0x1147F10")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1148D54", Offset = "0x1148D54", VA = "0x1148D54")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1146DD8", Offset = "0x1146DD8", VA = "0x1146DD8")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1145044", Offset = "0x1145044", VA = "0x1145044")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1148B58", Offset = "0x1148B58", VA = "0x1148B58")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1148DF0", Offset = "0x1148DF0", VA = "0x1148DF0")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1148E9C", Offset = "0x1148E9C", VA = "0x1148E9C")]
		private double? GetLatestEndTime(AudioSource src)
		{
			return null;
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x11424E8", Offset = "0x11424E8", VA = "0x11424E8")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause, bool addDspTime = true)
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1148C30", Offset = "0x1148C30", VA = "0x1148C30")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x11447D8", Offset = "0x11447D8", VA = "0x11447D8")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1144BAC", Offset = "0x1144BAC", VA = "0x1144BAC")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x114504C", Offset = "0x114504C", VA = "0x114504C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x11490C0", Offset = "0x11490C0", VA = "0x11490C0")]
		private void ResetDuckingState()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x1147DE0", Offset = "0x1147DE0", VA = "0x1147DE0")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x1149338", Offset = "0x1149338", VA = "0x1149338")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x1149440", Offset = "0x1149440", VA = "0x1149440")]
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
			[Address(RVA = "0x1149AC0", Offset = "0x1149AC0", VA = "0x1149AC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000110")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1149B50", Offset = "0x1149B50", VA = "0x1149B50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000111")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1149B9C", Offset = "0x1149B9C", VA = "0x1149B9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000112")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x6000892")]
			[Address(RVA = "0x1149B48", Offset = "0x1149B48", VA = "0x1149B48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1141EC8", Offset = "0x1141EC8", VA = "0x1141EC8")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1149BE8", Offset = "0x1149BE8", VA = "0x1149BE8")]
		private static void SetSpatializerToggleOnSource(AudioSource source, bool enabled)
		{
		}
	}
	[Token(Token = "0x200013A")]
	public static class UtilStrings
	{
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x1149C2C", Offset = "0x1149C2C", VA = "0x1149C2C")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x1149CA4", Offset = "0x1149CA4", VA = "0x1149CA4")]
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
		[Address(RVA = "0x1149D88", Offset = "0x1149D88", VA = "0x1149D88")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x1149D8C", Offset = "0x1149D8C", VA = "0x1149D8C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x1149EB8", Offset = "0x1149EB8", VA = "0x1149EB8")]
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
		[Address(RVA = "0x1149EC0", Offset = "0x1149EC0", VA = "0x1149EC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x1149F28", Offset = "0x1149F28", VA = "0x1149F28")]
		private void Update()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x1149FB8", Offset = "0x1149FB8", VA = "0x1149FB8")]
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
		[Address(RVA = "0x1149FC0", Offset = "0x1149FC0", VA = "0x1149FC0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x114A0B0", Offset = "0x114A0B0", VA = "0x114A0B0")]
		private void Update()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x114A1F8", Offset = "0x114A1F8", VA = "0x114A1F8")]
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
		[Address(RVA = "0x114A200", Offset = "0x114A200", VA = "0x114A200")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x114A26C", Offset = "0x114A26C", VA = "0x114A26C")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x114A3F8", Offset = "0x114A3F8", VA = "0x114A3F8")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x114A400", Offset = "0x114A400", VA = "0x114A400")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x114A4A8", Offset = "0x114A4A8", VA = "0x114A4A8")]
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
		[Address(RVA = "0x114A4B0", Offset = "0x114A4B0", VA = "0x114A4B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x114A548", Offset = "0x114A548", VA = "0x114A548")]
		private void Update()
		{
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x114A624", Offset = "0x114A624", VA = "0x114A624")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x2000141")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x114A62C", Offset = "0x114A62C", VA = "0x114A62C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x114A6D4", Offset = "0x114A6D4", VA = "0x114A6D4")]
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
		[Address(RVA = "0x114A6DC", Offset = "0x114A6DC", VA = "0x114A6DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x114A774", Offset = "0x114A774", VA = "0x114A774")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x114A778", Offset = "0x114A778", VA = "0x114A778")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x114A77C", Offset = "0x114A77C", VA = "0x114A77C")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x114A780", Offset = "0x114A780", VA = "0x114A780")]
		private void Update()
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x114A9AC", Offset = "0x114A9AC", VA = "0x114A9AC")]
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
			[Address(RVA = "0x114A9E0", Offset = "0x114A9E0", VA = "0x114A9E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x114A9BC", Offset = "0x114A9BC", VA = "0x114A9BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x114A9FC", Offset = "0x114A9FC", VA = "0x114A9FC")]
		private void Update()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x114AA74", Offset = "0x114AA74", VA = "0x114AA74")]
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
		[Address(RVA = "0x114AA7C", Offset = "0x114AA7C", VA = "0x114AA7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x114AA80", Offset = "0x114AA80", VA = "0x114AA80")]
		private void Start()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x114ABDC", Offset = "0x114ABDC", VA = "0x114ABDC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x114AC50", Offset = "0x114AC50", VA = "0x114AC50")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x114AA84", Offset = "0x114AA84", VA = "0x114AA84", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x114ADA0", Offset = "0x114ADA0", VA = "0x114ADA0", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x114AED0", Offset = "0x114AED0", VA = "0x114AED0", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x114ABE0", Offset = "0x114ABE0", VA = "0x114ABE0", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x114AD48", Offset = "0x114AD48", VA = "0x114AD48", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x114AF48", Offset = "0x114AF48", VA = "0x114AF48", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x114B0D4", Offset = "0x114B0D4", VA = "0x114B0D4")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x2000145")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x114B258", Offset = "0x114B258", VA = "0x114B258")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x114B300", Offset = "0x114B300", VA = "0x114B300")]
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
		[Address(RVA = "0x114B308", Offset = "0x114B308", VA = "0x114B308")]
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x114B3A8", Offset = "0x114B3A8", VA = "0x114B3A8")]
		public static string CTReverse(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x114B420", Offset = "0x114B420", VA = "0x114B420")]
		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x114B4AC", Offset = "0x114B4AC", VA = "0x114B4AC")]
		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x114B4BC", Offset = "0x114B4BC", VA = "0x114B4BC")]
		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x114B4DC", Offset = "0x114B4DC", VA = "0x114B4DC")]
		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x114B64C", Offset = "0x114B64C", VA = "0x114B64C")]
		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x114B7BC", Offset = "0x114B7BC", VA = "0x114B7BC")]
		public static string CTRemoveNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x114B810", Offset = "0x114B810", VA = "0x114B810")]
		public static string CTAddNewLines(this string str, string replacement = "#nl#", [Optional] string newLine)
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x114B8B4", Offset = "0x114B8B4", VA = "0x114B8B4")]
		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x114B8D8", Offset = "0x114B8D8", VA = "0x114B8D8")]
		public static bool CTisInteger(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x114B950", Offset = "0x114B950", VA = "0x114B950")]
		public static bool CTisEmail(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x114B9D0", Offset = "0x114B9D0", VA = "0x114B9D0")]
		public static bool CTisWebsite(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x114BA50", Offset = "0x114BA50", VA = "0x114BA50")]
		public static bool CTisCreditcard(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x114BAD0", Offset = "0x114BAD0", VA = "0x114BAD0")]
		public static bool CTisIPv4(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x114BB50", Offset = "0x114BB50", VA = "0x114BB50")]
		public static bool CTisAlphanumeric(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x114BBD0", Offset = "0x114BBD0", VA = "0x114BBD0")]
		public static bool CThasLineEndings(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x114BC50", Offset = "0x114BC50", VA = "0x114BC50")]
		public static bool CThasInvalidChars(this string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x114BCD0", Offset = "0x114BCD0", VA = "0x114BCD0")]
		public static bool CTStartsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x114BD24", Offset = "0x114BD24", VA = "0x114BD24")]
		public static bool CTEndsWith(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x114BD78", Offset = "0x114BD78", VA = "0x114BD78")]
		public static int CTLastIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x114BE18", Offset = "0x114BE18", VA = "0x114BE18")]
		public static int CTIndexOf(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x114BEB8", Offset = "0x114BEB8", VA = "0x114BEB8")]
		public static int CTIndexOf(this string str, string toCheck, int startIndex, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(int);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x114BF6C", Offset = "0x114BF6C", VA = "0x114BF6C")]
		public static string CTToBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x114C074", Offset = "0x114C074", VA = "0x114C074")]
		public static string CTFromBase64(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x114C114", Offset = "0x114C114", VA = "0x114C114")]
		public static byte[] CTFromBase64ToByteArray(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x114C180", Offset = "0x114C180", VA = "0x114C180")]
		public static string CTToHex(this string str, bool addPrefix = false)
		{
			return null;
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x114C2D0", Offset = "0x114C2D0", VA = "0x114C2D0")]
		public static string CTHexToString(this string hexString)
		{
			return null;
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x114C4B0", Offset = "0x114C4B0", VA = "0x114C4B0")]
		public static Color32 CTHexToColor32(this string hexString)
		{
			return default(Color32);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x114C734", Offset = "0x114C734", VA = "0x114C734")]
		public static Color CTHexToColor(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x114C7C4", Offset = "0x114C7C4", VA = "0x114C7C4")]
		public static byte[] CTToByteArray(this string str, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x114C818", Offset = "0x114C818", VA = "0x114C818")]
		public static string CTClearTags(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x114C8C4", Offset = "0x114C8C4", VA = "0x114C8C4")]
		public static string CTClearSpaces(this string str)
		{
			return null;
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x114C968", Offset = "0x114C968", VA = "0x114C968")]
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
		[Address(RVA = "0x114CA14", Offset = "0x114CA14", VA = "0x114CA14")]
		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x114CBA4", Offset = "0x114CBA4", VA = "0x114CBA4")]
		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x114CCE4", Offset = "0x114CCE4", VA = "0x114CCE4")]
		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x114CE54", Offset = "0x114CE54", VA = "0x114CE54")]
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
		[Address(RVA = "0x114CFE4", Offset = "0x114CFE4", VA = "0x114CFE4")]
		public static float[] CTToFloatArray(this byte[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x114D178", Offset = "0x114D178", VA = "0x114D178")]
		public static byte[] CTToByteArray(this float[] array, int count = 0)
		{
			return null;
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x114D2B8", Offset = "0x114D2B8", VA = "0x114D2B8")]
		public static Texture2D CTToTexture(this byte[] data, [Optional] Texture2D supportTexture)
		{
			return null;
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x114D3BC", Offset = "0x114D3BC", VA = "0x114D3BC")]
		public static Sprite CTToSprite(this byte[] data, [Optional] Texture2D supportTexture)
		{
			return null;
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x114D564", Offset = "0x114D564", VA = "0x114D564")]
		public static string CTToString(this byte[] data, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x114C008", Offset = "0x114C008", VA = "0x114C008")]
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
		[Address(RVA = "0x114D5AC", Offset = "0x114D5AC", VA = "0x114D5AC")]
		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x114D9D8", Offset = "0x114D9D8", VA = "0x114D9D8")]
		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x114DDA0", Offset = "0x114DDA0", VA = "0x114DDA0")]
		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x114E1A0", Offset = "0x114E1A0", VA = "0x114E1A0")]
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
		[Address(RVA = "0x114E5CC", Offset = "0x114E5CC", VA = "0x114E5CC")]
		public static byte[] CTReadFully(this Stream input)
		{
			return null;
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x114E7CC", Offset = "0x114E7CC", VA = "0x114E7CC")]
		public static string CTToHexRGB(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x114E878", Offset = "0x114E878", VA = "0x114E878")]
		public static string CTToHexRGB(this Color input)
		{
			return null;
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x114E880", Offset = "0x114E880", VA = "0x114E880")]
		public static string CTToHexRGBA(this Color32 input)
		{
			return null;
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x114E92C", Offset = "0x114E92C", VA = "0x114E92C")]
		public static string CTToHexRGBA(this Color input)
		{
			return null;
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x114E934", Offset = "0x114E934", VA = "0x114E934")]
		public static Vector3 CTVector3(this Color32 color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x114E9CC", Offset = "0x114E9CC", VA = "0x114E9CC")]
		public static Vector3 CTVector3(this Color color)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x114E9D0", Offset = "0x114E9D0", VA = "0x114E9D0")]
		public static Vector4 CTVector4(this Color32 color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x114EA78", Offset = "0x114EA78", VA = "0x114EA78")]
		public static Vector4 CTVector4(this Color color)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x114EA7C", Offset = "0x114EA7C", VA = "0x114EA7C")]
		public static Vector2 CTMultiply(this Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x114EA88", Offset = "0x114EA88", VA = "0x114EA88")]
		public static Vector3 CTMultiply(this Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x114EA98", Offset = "0x114EA98", VA = "0x114EA98")]
		public static Vector3 CTFlatten(this Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x114EB1C", Offset = "0x114EB1C", VA = "0x114EB1C")]
		public static Quaternion CTQuaternion(this Vector3 eulerAngle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x114EB38", Offset = "0x114EB38", VA = "0x114EB38")]
		public static Color CTColorRGB(this Vector3 rgb, float alpha = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x114EB74", Offset = "0x114EB74", VA = "0x114EB74")]
		public static Vector4 CTMultiply(this Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x114EB88", Offset = "0x114EB88", VA = "0x114EB88")]
		public static Quaternion CTQuaternion(this Vector4 angle)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x114EB8C", Offset = "0x114EB8C", VA = "0x114EB8C")]
		public static Color CTColorRGBA(this Vector4 rgba)
		{
			return default(Color);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x114EBC8", Offset = "0x114EBC8", VA = "0x114EBC8")]
		public static Vector3 CTVector3(this Quaternion angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x114EBF4", Offset = "0x114EBF4", VA = "0x114EBF4")]
		public static Vector4 CTVector4(this Quaternion angle)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x114EBF8", Offset = "0x114EBF8", VA = "0x114EBF8")]
		public static Vector3 CTCorrectLossyScale(this Canvas canvas)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x114EE10", Offset = "0x114EE10", VA = "0x114EE10")]
		public static void CTGetLocalCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x114F080", Offset = "0x114F080", VA = "0x114F080")]
		public static Vector3[] CTGetLocalCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x114F138", Offset = "0x114F138", VA = "0x114F138")]
		public static void CTGetScreenCorners(this RectTransform transform, Vector3[] fourCornersArray, Canvas canvas, float inset = 0f, bool corrected = false)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x114F414", Offset = "0x114F414", VA = "0x114F414")]
		public static Vector3[] CTGetScreenCorners(this RectTransform transform, Canvas canvas, float inset = 0f, bool corrected = false)
		{
			return null;
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x114F4CC", Offset = "0x114F4CC", VA = "0x114F4CC")]
		public static Bounds CTGetBounds(this RectTransform transform, float uiScaleFactor = 1f)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x114FA0C", Offset = "0x114FA0C", VA = "0x114FA0C")]
		public static void CTSetLeft(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x114FAE8", Offset = "0x114FAE8", VA = "0x114FAE8")]
		public static void CTSetRight(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x114FBC4", Offset = "0x114FBC4", VA = "0x114FBC4")]
		public static void CTSetTop(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x114FCA0", Offset = "0x114FCA0", VA = "0x114FCA0")]
		public static void CTSetBottom(this RectTransform transform, float value)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x114FD7C", Offset = "0x114FD7C", VA = "0x114FD7C")]
		public static float CTGetLeft(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x114FE3C", Offset = "0x114FE3C", VA = "0x114FE3C")]
		public static float CTGetRight(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x114FEFC", Offset = "0x114FEFC", VA = "0x114FEFC")]
		public static float CTGetTop(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x114FFC4", Offset = "0x114FFC4", VA = "0x114FFC4")]
		public static float CTGetBottom(this RectTransform transform)
		{
			return default(float);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x115008C", Offset = "0x115008C", VA = "0x115008C")]
		public static Vector4 CTGetLRTB(this RectTransform transform)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1150194", Offset = "0x1150194", VA = "0x1150194")]
		public static void CTSetLRTB(this RectTransform transform, Vector4 lrtb)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1150290", Offset = "0x1150290", VA = "0x1150290")]
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
		[Address(RVA = "0x1150A7C", Offset = "0x1150A7C", VA = "0x1150A7C")]
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
		[Address(RVA = "0x1150C9C", Offset = "0x1150C9C", VA = "0x1150C9C")]
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
		[Address(RVA = "0x1150DAC", Offset = "0x1150DAC", VA = "0x1150DAC")]
		public static Bounds CTGetBounds(this GameObject go)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1150B8C", Offset = "0x1150B8C", VA = "0x1150B8C")]
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
		[Address(RVA = "0x115138C", Offset = "0x115138C", VA = "0x115138C")]
		public static byte[] CTToPNG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x1151538", Offset = "0x1151538", VA = "0x1151538")]
		public static byte[] CTToJPG(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x11516E4", Offset = "0x11516E4", VA = "0x11516E4")]
		public static byte[] CTToTGA(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1151890", Offset = "0x1151890", VA = "0x1151890")]
		public static byte[] CTToEXR(this Sprite sprite)
		{
			return null;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x1151480", Offset = "0x1151480", VA = "0x1151480")]
		public static byte[] CTToPNG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x115162C", Offset = "0x115162C", VA = "0x115162C")]
		public static byte[] CTToJPG(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x11517D8", Offset = "0x11517D8", VA = "0x11517D8")]
		public static byte[] CTToTGA(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1151984", Offset = "0x1151984", VA = "0x1151984")]
		public static byte[] CTToEXR(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1151A3C", Offset = "0x1151A3C", VA = "0x1151A3C")]
		public static Sprite CTToSprite(this Texture2D texture, float pixelsPerUnit = 100f)
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1151B6C", Offset = "0x1151B6C", VA = "0x1151B6C")]
		public static Texture2D CTRotate90(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1151EBC", Offset = "0x1151EBC", VA = "0x1151EBC")]
		public static Texture2D CTRotate180(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x11520D8", Offset = "0x11520D8", VA = "0x11520D8")]
		public static Texture2D CTRotate270(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x11523AC", Offset = "0x11523AC", VA = "0x11523AC")]
		public static Texture2D CTToTexture2D(this Texture texture)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x11524B4", Offset = "0x11524B4", VA = "0x11524B4")]
		public static Texture2D CTFlipHorizontal(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x11525F0", Offset = "0x11525F0", VA = "0x11525F0")]
		public static Texture2D CTFlipVertical(this Texture2D texture)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1152738", Offset = "0x1152738", VA = "0x1152738")]
		public static bool CTHasActiveClip(this AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1152848", Offset = "0x1152848", VA = "0x1152848")]
		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1150FDC", Offset = "0x1150FDC", VA = "0x1150FDC")]
		private static Transform deepSearch(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1150678", Offset = "0x1150678", VA = "0x1150678")]
		private static List<Transform> getAllChildren(this Transform parent, int maxDepth = 0, [Optional] List<Transform> transformList, int depth = 0)
		{
			return null;
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x114D15C", Offset = "0x114D15C", VA = "0x114D15C")]
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
			[Address(RVA = "0x1152BF4", Offset = "0x1152BF4", VA = "0x1152BF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public static string APPLICATION_PATH
		{
			[Token(Token = "0x600094E")]
			[Address(RVA = "0x1152D00", Offset = "0x1152D00", VA = "0x1152D00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1152FD0", Offset = "0x1152FD0", VA = "0x1152FD0")]
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
			[Address(RVA = "0x1153390", Offset = "0x1153390", VA = "0x1153390")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public static bool isMacOSPlatform
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x1153398", Offset = "0x1153398", VA = "0x1153398")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000118")]
		public static bool isLinuxPlatform
		{
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x11533A0", Offset = "0x11533A0", VA = "0x11533A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000119")]
		public static bool isStandalonePlatform
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x11533A8", Offset = "0x11533A8", VA = "0x11533A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011A")]
		public static bool isAndroidPlatform
		{
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x1153418", Offset = "0x1153418", VA = "0x1153418")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public static bool isIOSPlatform
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x1153420", Offset = "0x1153420", VA = "0x1153420")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011C")]
		public static bool isTvOSPlatform
		{
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x1153428", Offset = "0x1153428", VA = "0x1153428")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011D")]
		public static bool isWSAPlatform
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x1153430", Offset = "0x1153430", VA = "0x1153430")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011E")]
		public static bool isXboxOnePlatform
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x1153438", Offset = "0x1153438", VA = "0x1153438")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011F")]
		public static bool isPS4Platform
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x1153440", Offset = "0x1153440", VA = "0x1153440")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000120")]
		public static bool isWebGLPlatform
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x1153448", Offset = "0x1153448", VA = "0x1153448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000121")]
		public static bool isWebPlatform
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x1153450", Offset = "0x1153450", VA = "0x1153450")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000122")]
		public static bool isWindowsBasedPlatform
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x1152C78", Offset = "0x1152C78", VA = "0x1152C78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000123")]
		public static bool isWSABasedPlatform
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x11534A0", Offset = "0x11534A0", VA = "0x11534A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000124")]
		public static bool isAppleBasedPlatform
		{
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1153500", Offset = "0x1153500", VA = "0x1153500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public static bool isIOSBasedPlatform
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1153570", Offset = "0x1153570", VA = "0x1153570")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		public static bool isMobilePlatform
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x11535D0", Offset = "0x11535D0", VA = "0x11535D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		public static bool isEditor
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1153620", Offset = "0x1153620", VA = "0x1153620")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000128")]
		public static bool isWindowsEditor
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x1152CE8", Offset = "0x1152CE8", VA = "0x1152CE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000129")]
		public static bool isMacOSEditor
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x1152CF0", Offset = "0x1152CF0", VA = "0x1152CF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012A")]
		public static bool isLinuxEditor
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x1152CF8", Offset = "0x1152CF8", VA = "0x1152CF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		public static bool isEditorMode
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x1153690", Offset = "0x1153690", VA = "0x1153690")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		public static bool isIL2CPP
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x11536E4", Offset = "0x11536E4", VA = "0x11536E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		public static Platform CurrentPlatform
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x11536EC", Offset = "0x11536EC", VA = "0x11536EC")]
			get
			{
				return default(Platform);
			}
		}

		[Token(Token = "0x1700012E")]
		public static int AndroidAPILevel
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x115376C", Offset = "0x115376C", VA = "0x115376C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600096A")]
		[Address(RVA = "0x1153868", Offset = "0x1153868", VA = "0x1153868")]
		static BaseHelper()
		{
		}

		[Token(Token = "0x600096B")]
		[Address(RVA = "0x1153BA8", Offset = "0x1153BA8", VA = "0x1153BA8")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x600096C")]
		[Address(RVA = "0x1153C10", Offset = "0x1153C10", VA = "0x1153C10")]
		public static string CreateString(string replaceChars, int stringLength)
		{
			return null;
		}

		[Token(Token = "0x600096D")]
		[Address(RVA = "0x1153D94", Offset = "0x1153D94", VA = "0x1153D94")]
		public static List<string> SplitStringToLines(string text, bool ignoreCommentedLines = true, int skipHeaderLines = 0, int skipFooterLines = 0)
		{
			return null;
		}

		[Token(Token = "0x600096E")]
		[Address(RVA = "0x1154068", Offset = "0x1154068", VA = "0x1154068")]
		public static string FormatBytesToHRF(long bytes, bool useSI = false)
		{
			return null;
		}

		[Token(Token = "0x600096F")]
		[Address(RVA = "0x1154330", Offset = "0x1154330", VA = "0x1154330")]
		public static string FormatSecondsToHRF(double seconds)
		{
			return null;
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0x1154764", Offset = "0x1154764", VA = "0x1154764")]
		public static Color HSVToRGB(float h, float s, float v, float a = 1f)
		{
			return default(Color);
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0x11548B4", Offset = "0x11548B4", VA = "0x11548B4")]
		public static string GenerateLoremIpsum(int length, int minSentences = 1, int maxSentences = int.MaxValue, int minWords = 1, int maxWords = 15)
		{
			return null;
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0x1153984", Offset = "0x1153984", VA = "0x1153984")]
		public static string LanguageToISO639(SystemLanguage language)
		{
			return null;
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0x11552F4", Offset = "0x11552F4", VA = "0x11552F4")]
		public static SystemLanguage ISO639ToLanguage(string isoCode)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x1155E1C", Offset = "0x1155E1C", VA = "0x1155E1C")]
		public static object InvokeMethod(string className, string methodName, params object[] parameters)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x1156414", Offset = "0x1156414", VA = "0x1156414")]
		public static string GetArgument(string name)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0x1156538", Offset = "0x1156538", VA = "0x1156538")]
		public static string[] GetArguments()
		{
			return null;
		}

		[Token(Token = "0x6000977")]
		[Address(RVA = "0x11546F4", Offset = "0x11546F4", VA = "0x11546F4")]
		private static string addLeadingZero(int value)
		{
			return null;
		}

		[Token(Token = "0x6000978")]
		[Address(RVA = "0x11565E4", Offset = "0x11565E4", VA = "0x11565E4")]
		protected BaseHelper()
		{
		}
	}
	[Token(Token = "0x2000152")]
	public abstract class CTPlayerPrefs
	{
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x1156688", Offset = "0x1156688", VA = "0x1156688")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x11566B8", Offset = "0x11566B8", VA = "0x11566B8")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x600097E")]
		[Address(RVA = "0x11566C0", Offset = "0x11566C0", VA = "0x11566C0")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600097F")]
		[Address(RVA = "0x1156730", Offset = "0x1156730", VA = "0x1156730")]
		public static void Save()
		{
		}

		[Token(Token = "0x6000980")]
		[Address(RVA = "0x1156738", Offset = "0x1156738", VA = "0x1156738")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000981")]
		[Address(RVA = "0x11567A8", Offset = "0x11567A8", VA = "0x11567A8")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000982")]
		[Address(RVA = "0x1156818", Offset = "0x1156818", VA = "0x1156818")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000983")]
		[Address(RVA = "0x1156888", Offset = "0x1156888", VA = "0x1156888")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0x115690C", Offset = "0x115690C", VA = "0x115690C")]
		public static DateTime GetDate(string key)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0x11569AC", Offset = "0x11569AC", VA = "0x11569AC")]
		public static Vector2 GetVector2(string key)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0x1156A20", Offset = "0x1156A20", VA = "0x1156A20")]
		public static Vector3 GetVector3(string key)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0x1156AB4", Offset = "0x1156AB4", VA = "0x1156AB4")]
		public static Vector4 GetVector4(string key)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000988")]
		[Address(RVA = "0x1156B70", Offset = "0x1156B70", VA = "0x1156B70")]
		public static Quaternion GetQuaternion(string key)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000989")]
		[Address(RVA = "0x1156BFC", Offset = "0x1156BFC", VA = "0x1156BFC")]
		public static Color GetColor(string key)
		{
			return default(Color);
		}

		[Token(Token = "0x600098A")]
		[Address(RVA = "0x1156C88", Offset = "0x1156C88", VA = "0x1156C88")]
		public static SystemLanguage GetLanguage(string key)
		{
			return default(SystemLanguage);
		}

		[Token(Token = "0x600098B")]
		[Address(RVA = "0x1156D8C", Offset = "0x1156D8C", VA = "0x1156D8C")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x600098C")]
		[Address(RVA = "0x1156E0C", Offset = "0x1156E0C", VA = "0x1156E0C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1156E8C", Offset = "0x1156E8C", VA = "0x1156E8C")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600098E")]
		[Address(RVA = "0x1156F0C", Offset = "0x1156F0C", VA = "0x1156F0C")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1156F7C", Offset = "0x1156F7C", VA = "0x1156F7C")]
		public static void SetDate(string key, DateTime value)
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x1156FE4", Offset = "0x1156FE4", VA = "0x1156FE4")]
		public static void SetVector2(string key, Vector2 value)
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x1157098", Offset = "0x1157098", VA = "0x1157098")]
		public static void SetVector3(string key, Vector3 value)
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1157178", Offset = "0x1157178", VA = "0x1157178")]
		public static void SetVector4(string key, Vector4 value)
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x1157370", Offset = "0x1157370", VA = "0x1157370")]
		public static void SetQuaternion(string key, Quaternion value)
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x11573FC", Offset = "0x11573FC", VA = "0x11573FC")]
		public static void SetColor(string key, Color value)
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x1157488", Offset = "0x1157488", VA = "0x1157488")]
		public static void SetLanguage(string key, SystemLanguage language)
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x1157504", Offset = "0x1157504", VA = "0x1157504")]
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
			[Address(RVA = "0x115750C", Offset = "0x115750C", VA = "0x115750C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x1157514", Offset = "0x1157514", VA = "0x1157514")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000130")]
		public int ConnectionLimit
		{
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x115751C", Offset = "0x115751C", VA = "0x115751C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600099A")]
			[Address(RVA = "0x1157524", Offset = "0x1157524", VA = "0x1157524")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x115752C", Offset = "0x115752C", VA = "0x115752C")]
		public CTWebClient()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x1157538", Offset = "0x1157538", VA = "0x1157538")]
		public CTWebClient(int timeout, int connectionLimit = 20)
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x11575AC", Offset = "0x11575AC", VA = "0x11575AC")]
		public WebRequest CTGetWebRequest(string uri)
		{
			return null;
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x115762C", Offset = "0x115762C", VA = "0x115762C", Slot = "27")]
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
			[Address(RVA = "0x115778C", Offset = "0x115778C", VA = "0x115778C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x1157868", Offset = "0x1157868", VA = "0x1157868")]
		static FileHelper()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x11578C8", Offset = "0x11578C8", VA = "0x11578C8")]
		[RuntimeInitializeOnLoadMethod]
		private static void initialize()
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0x1152DA0", Offset = "0x1152DA0", VA = "0x1152DA0")]
		public static string ValidatePath(string path, bool addEndDelimiter = true, bool preserveFile = true)
		{
			return null;
		}

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0x1157A40", Offset = "0x1157A40", VA = "0x1157A40")]
		public static string ValidateFile(string path)
		{
			return null;
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0x1157CB8", Offset = "0x1157CB8", VA = "0x1157CB8")]
		public static bool PathHasInvalidChars(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1157D48", Offset = "0x1157D48", VA = "0x1157D48")]
		public static bool FileHasInvalidChars(string file)
		{
			return default(bool);
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1157DD8", Offset = "0x1157DD8", VA = "0x1157DD8")]
		public static string[] GetFilesForName(string path, bool isRecursive = false, params string[] filenames)
		{
			return null;
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x11582FC", Offset = "0x11582FC", VA = "0x11582FC")]
		public static string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x11584C4", Offset = "0x11584C4", VA = "0x11584C4")]
		public static string[] GetDirectories(string path, bool isRecursive = false)
		{
			return null;
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0x11586F8", Offset = "0x11586F8", VA = "0x11586F8")]
		public static string[] GetDrives()
		{
			return null;
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0x1158890", Offset = "0x1158890", VA = "0x1158890")]
		public static void CopyPath(string sourcePath, string destPath, bool move = false)
		{
		}

		[Token(Token = "0x60009AB")]
		[Address(RVA = "0x1158DAC", Offset = "0x1158DAC", VA = "0x1158DAC")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x11590CC", Offset = "0x11590CC", VA = "0x11590CC")]
		public static void ShowPath(string path)
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x1159118", Offset = "0x1159118", VA = "0x1159118")]
		public static void ShowFile(string file)
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x11591BC", Offset = "0x11591BC", VA = "0x11591BC")]
		public static void OpenFile(string file)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x1158BE0", Offset = "0x1158BE0", VA = "0x1158BE0")]
		private static void copyAll(DirectoryInfo source, DirectoryInfo target)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x1159260", Offset = "0x1159260", VA = "0x1159260")]
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
			[Address(RVA = "0x11594B4", Offset = "0x11594B4", VA = "0x11594B4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000133")]
		public override bool CanSeek
		{
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x11594BC", Offset = "0x11594BC", VA = "0x11594BC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000134")]
		public override bool CanWrite
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x11594C4", Offset = "0x11594C4", VA = "0x11594C4", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000135")]
		public override long Position
		{
			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x11594CC", Offset = "0x11594CC", VA = "0x11594CC", Slot = "13")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x11594D4", Offset = "0x11594D4", VA = "0x11594D4", Slot = "14")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public override long Length
		{
			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x1159550", Offset = "0x1159550", VA = "0x1159550", Slot = "12")]
			get
			{
				return default(long);
			}
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x1159374", Offset = "0x1159374", VA = "0x1159374")]
		public MemoryCacheStream(int cacheSize = 65536, int maxCacheSize = 67108864)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x1159558", Offset = "0x1159558", VA = "0x1159558", Slot = "23")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x115955C", Offset = "0x115955C", VA = "0x115955C", Slot = "33")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default(long);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1159668", Offset = "0x1159668", VA = "0x1159668", Slot = "34")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x11596AC", Offset = "0x11596AC", VA = "0x11596AC", Slot = "35")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x1159870", Offset = "0x1159870", VA = "0x1159870", Slot = "38")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x11597B8", Offset = "0x11597B8", VA = "0x11597B8")]
		private int read(byte[] buff, int offset, int count)
		{
			return default(int);
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x11599B0", Offset = "0x11599B0", VA = "0x11599B0")]
		private void write(byte[] buff, int offset, int count)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x11593F0", Offset = "0x11593F0", VA = "0x11593F0")]
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
			[Address(RVA = "0x1159A60", Offset = "0x1159A60", VA = "0x1159A60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x1159A7C", Offset = "0x1159A7C", VA = "0x1159A7C")]
		public static bool OpenURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x1159B30", Offset = "0x1159B30", VA = "0x1159B30")]
		public static bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return default(bool);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x115A048", Offset = "0x115A048", VA = "0x115A048")]
		public static string ValidURLFromFilePath(string path)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x115A1B0", Offset = "0x115A1B0", VA = "0x115A1B0")]
		public static string CleanUrl(string url, bool removeProtocol = true, bool removeWWW = true, bool removeSlash = true)
		{
			return null;
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x115793C", Offset = "0x115793C", VA = "0x115793C")]
		public static bool isValidURL(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x115A358", Offset = "0x115A358", VA = "0x115A358")]
		public static string GetIP(string host)
		{
			return null;
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x1159B28", Offset = "0x1159B28", VA = "0x1159B28")]
		private static void openURL(string url)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x115A4FC", Offset = "0x115A4FC", VA = "0x115A4FC")]
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
			[Address(RVA = "0x115A588", Offset = "0x115A588", VA = "0x115A588")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x115A5E0", Offset = "0x115A5E0", VA = "0x115A5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x115A63C", Offset = "0x115A63C", VA = "0x115A63C")]
		static SingletonHelper()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x115A730", Offset = "0x115A730", VA = "0x115A730")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void initialize()
		{
		}

		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x115AA38", Offset = "0x115AA38", VA = "0x115AA38")]
		private static void onSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x115ABBC", Offset = "0x115ABBC", VA = "0x115ABBC")]
		private static void onQuitting()
		{
		}

		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x115AD10", Offset = "0x115AD10", VA = "0x115AD10")]
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
		[Address(RVA = "0x115AD18", Offset = "0x115AD18", VA = "0x115AD18")]
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
			[Address(RVA = "0x115E750", Offset = "0x115E750", VA = "0x115E750")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x115E758", Offset = "0x115E758", VA = "0x115E758")]
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
				[Address(RVA = "0x115E950", Offset = "0x115E950", VA = "0x115E950", Slot = "4")]
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
				[Address(RVA = "0x115E998", Offset = "0x115E998", VA = "0x115E998", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x115DAFC", Offset = "0x115DAFC", VA = "0x115DAFC")]
			[DebuggerHidden]
			public <containsAsync>d__40(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x115E76C", Offset = "0x115E76C", VA = "0x115E76C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x115E770", Offset = "0x115E770", VA = "0x115E770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x115E958", Offset = "0x115E958", VA = "0x115E958", Slot = "8")]
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
			[Address(RVA = "0x115E9A0", Offset = "0x115E9A0", VA = "0x115E9A0")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x115E9A8", Offset = "0x115E9A8", VA = "0x115E9A8")]
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
				[Address(RVA = "0x115EBA8", Offset = "0x115EBA8", VA = "0x115EBA8", Slot = "4")]
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
				[Address(RVA = "0x115EBF0", Offset = "0x115EBF0", VA = "0x115EBF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x115DB24", Offset = "0x115DB24", VA = "0x115DB24")]
			[DebuggerHidden]
			public <getAllAsync>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x115E9BC", Offset = "0x115E9BC", VA = "0x115E9BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x115E9C0", Offset = "0x115E9C0", VA = "0x115E9C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x115EBB0", Offset = "0x115EBB0", VA = "0x115EBB0", Slot = "8")]
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
			[Address(RVA = "0x115EBF8", Offset = "0x115EBF8", VA = "0x115EBF8")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x115EC00", Offset = "0x115EC00", VA = "0x115EC00")]
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
				[Address(RVA = "0x115EE38", Offset = "0x115EE38", VA = "0x115EE38", Slot = "4")]
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
				[Address(RVA = "0x115EE80", Offset = "0x115EE80", VA = "0x115EE80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x115DB4C", Offset = "0x115DB4C", VA = "0x115DB4C")]
			[DebuggerHidden]
			public <replaceAllAsync>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x115EC1C", Offset = "0x115EC1C", VA = "0x115EC1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x115EC20", Offset = "0x115EC20", VA = "0x115EC20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x115EE40", Offset = "0x115EE40", VA = "0x115EE40", Slot = "8")]
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
			[Address(RVA = "0x115AD20", Offset = "0x115AD20", VA = "0x115AD20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013C")]
		public int TotalRegexCount
		{
			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x115B014", Offset = "0x115B014", VA = "0x115B014")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000008")]
		public event BWFReady OnBWFReady
		{
			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x115B3B8", Offset = "0x115B3B8", VA = "0x115B3B8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x115B454", Offset = "0x115B454", VA = "0x115B454")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event ContainsComplete OnContainsComplete
		{
			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x115B4F0", Offset = "0x115B4F0", VA = "0x115B4F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x115B58C", Offset = "0x115B58C", VA = "0x115B58C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event GetAllComplete OnGetAllComplete
		{
			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x115B628", Offset = "0x115B628", VA = "0x115B628")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x115B6C4", Offset = "0x115B6C4", VA = "0x115B6C4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event ReplaceAllComplete OnReplaceAllComplete
		{
			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x115B760", Offset = "0x115B760", VA = "0x115B760")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x115B7FC", Offset = "0x115B7FC", VA = "0x115B7FC")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x115B898", Offset = "0x115B898", VA = "0x115B898", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x115B984", Offset = "0x115B984", VA = "0x115B984")]
		private void Update()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x115BA3C", Offset = "0x115BA3C", VA = "0x115BA3C")]
		public void Load(ManagerMask mask = ManagerMask.All)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x115B124", Offset = "0x115B124", VA = "0x115B124")]
		public List<Source> Sources(ManagerMask mask = ManagerMask.All)
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x115BEB0", Offset = "0x115BEB0", VA = "0x115BEB0")]
		public bool Contains(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x115C180", Offset = "0x115C180", VA = "0x115C180")]
		public void ContainsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x115C254", Offset = "0x115C254", VA = "0x115C254")]
		public List<string> GetAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x115C940", Offset = "0x115C940", VA = "0x115C940")]
		public void GetAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x115CA14", Offset = "0x115CA14", VA = "0x115CA14")]
		public string ReplaceAll(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x115CAB0", Offset = "0x115CAB0", VA = "0x115CAB0")]
		public string ReplaceAll(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x115CE28", Offset = "0x115CE28", VA = "0x115CE28")]
		public void ReplaceAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x115CEB8", Offset = "0x115CEB8", VA = "0x115CEB8")]
		public void ReplaceAllAsync(string text, ManagerMask mask, bool markOnly, string prefix, string postfix, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x115CFCC", Offset = "0x115CFCC", VA = "0x115CFCC")]
		public string Mark(string text, List<string> unwantedWords, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x115D4FC", Offset = "0x115D4FC", VA = "0x115D4FC")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x115DA30", Offset = "0x115DA30", VA = "0x115DA30")]
		public string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x115C1A0", Offset = "0x115C1A0", VA = "0x115C1A0")]
		[IteratorStateMachine(typeof(<containsAsync>d__40))]
		private IEnumerator containsAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x115C960", Offset = "0x115C960", VA = "0x115C960")]
		[IteratorStateMachine(typeof(<getAllAsync>d__41))]
		private IEnumerator getAllAsync(string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x115CEDC", Offset = "0x115CEDC", VA = "0x115CEDC")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__42))]
		private IEnumerator replaceAllAsync(string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x115BEF8", Offset = "0x115BEF8", VA = "0x115BEF8")]
		private static void contains(out bool result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x115C290", Offset = "0x115C290", VA = "0x115C290")]
		private static void getAll(out List<string> result, string text, ManagerMask mask = ManagerMask.All, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x115CAF0", Offset = "0x115CAF0", VA = "0x115CAF0")]
		private static void replaceAll(out string result, string text, ManagerMask mask = ManagerMask.All, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x115B9B8", Offset = "0x115B9B8", VA = "0x115B9B8")]
		private void onBWFReady()
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x115C0C4", Offset = "0x115C0C4", VA = "0x115C0C4")]
		private void onContainsComplete(string text, bool result)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x115C824", Offset = "0x115C824", VA = "0x115C824")]
		private void onGetAllComplete(string text, List<string> badWords)
		{
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x115CD6C", Offset = "0x115CD6C", VA = "0x115CD6C")]
		private void onReplaceAllComplete(string originalText, string cleanText)
		{
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x115E464", Offset = "0x115E464", VA = "0x115E464")]
		public BWFManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000168")]
	public class OnReady : UnityEvent
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0x115EE88", Offset = "0x115EE88", VA = "0x115EE88")]
		public OnReady()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000169")]
	public class OnContainsCompleted : UnityEvent<string, bool>
	{
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0x115EE90", Offset = "0x115EE90", VA = "0x115EE90")]
		public OnContainsCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016A")]
	public class OnGetAllCompleted : UnityEvent<string, string>
	{
		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x115EED8", Offset = "0x115EED8", VA = "0x115EED8")]
		public OnGetAllCompleted()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016B")]
	public class OnReplaceAllCompleted : UnityEvent<string, string>
	{
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x115EF20", Offset = "0x115EF20", VA = "0x115EF20")]
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
		[Address(RVA = "0x115F3E8", Offset = "0x115F3E8", VA = "0x115F3E8")]
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
			[Address(RVA = "0x115F4E0", Offset = "0x115F4E0", VA = "0x115F4E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x115F4E8", Offset = "0x115F4E8", VA = "0x115F4E8")]
		public static void CreateSource()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x115F4EC", Offset = "0x115F4EC", VA = "0x115F4EC")]
		protected Helper()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class SetupProject
	{
		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x115F544", Offset = "0x115F544", VA = "0x115F544")]
		static SetupProject()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x115F548", Offset = "0x115F548", VA = "0x115F548")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void setup()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x115F7FC", Offset = "0x115F7FC", VA = "0x115F7FC")]
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
			[Address(RVA = "0x115F804", Offset = "0x115F804", VA = "0x115F804")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4C")]
			[Address(RVA = "0x115F80C", Offset = "0x115F80C", VA = "0x115F80C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000145")]
		public Dictionary<string, List<Regex>> DebugExactBadwordsRegex
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x115F814", Offset = "0x115F814", VA = "0x115F814")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x115F81C", Offset = "0x115F81C", VA = "0x115F81C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public Dictionary<string, List<string>> SimpleBadwords
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x115F824", Offset = "0x115F824", VA = "0x115F824")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x115F82C", Offset = "0x115F82C", VA = "0x115F82C")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x115F834", Offset = "0x115F834", VA = "0x115F834")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x115F838", Offset = "0x115F838", VA = "0x115F838", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0x115F8B0", Offset = "0x115F8B0", VA = "0x115F8B0", Slot = "10")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x1160514", Offset = "0x1160514", VA = "0x1160514")]
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
				[Address(RVA = "0x1161EFC", Offset = "0x1161EFC", VA = "0x1161EFC", Slot = "4")]
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
				[Address(RVA = "0x1161F44", Offset = "0x1161F44", VA = "0x1161F44", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1160E24", Offset = "0x1160E24", VA = "0x1160E24")]
			[DebuggerHidden]
			public <loadWeb>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1160F4C", Offset = "0x1160F4C", VA = "0x1160F4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x1160F78", Offset = "0x1160F78", VA = "0x1160F78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1161E4C", Offset = "0x1161E4C", VA = "0x1161E4C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A63")]
			[Address(RVA = "0x1161F04", Offset = "0x1161F04", VA = "0x1161F04", Slot = "8")]
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
				[Address(RVA = "0x1162424", Offset = "0x1162424", VA = "0x1162424", Slot = "4")]
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
				[Address(RVA = "0x116246C", Offset = "0x116246C", VA = "0x116246C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x1160E4C", Offset = "0x1160E4C", VA = "0x1160E4C")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x1161F4C", Offset = "0x1161F4C", VA = "0x1161F4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1161F50", Offset = "0x1161F50", VA = "0x1161F50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x116242C", Offset = "0x116242C", VA = "0x116242C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1160804", Offset = "0x1160804", VA = "0x1160804", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1160DB4", Offset = "0x1160DB4", VA = "0x1160DB4", Slot = "9")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1160D24", Offset = "0x1160D24", VA = "0x1160D24")]
		[IteratorStateMachine(typeof(<loadWeb>d__2))]
		private IEnumerator loadWeb(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1160C94", Offset = "0x1160C94", VA = "0x1160C94")]
		[IteratorStateMachine(typeof(<loadResource>d__3))]
		private IEnumerator loadResource(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1160E74", Offset = "0x1160E74", VA = "0x1160E74")]
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
			[Address(RVA = "0x1162474", Offset = "0x1162474", VA = "0x1162474")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014C")]
		public bool isReady
		{
			[Token(Token = "0x6000A6C")]
			[Address(RVA = "0x1162590", Offset = "0x1162590", VA = "0x1162590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A6D")]
			[Address(RVA = "0x1162598", Offset = "0x1162598", VA = "0x1162598", Slot = "5")]
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
		[Address(RVA = "0x11625A4", Offset = "0x11625A4", VA = "0x11625A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x11625B0", Offset = "0x11625B0", VA = "0x11625B0")]
		protected void logNoResourcesAdded()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x11627F8", Offset = "0x11627F8", VA = "0x11627F8")]
		protected void createSource()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1160688", Offset = "0x1160688", VA = "0x1160688")]
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
			[Address(RVA = "0x11628EC", Offset = "0x11628EC", VA = "0x11628EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x11628F4", Offset = "0x11628F4", VA = "0x11628F4")]
			protected set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public Dictionary<string, List<Regex>> DebugDomainsRegex
		{
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x11628FC", Offset = "0x11628FC", VA = "0x11628FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1162904", Offset = "0x1162904", VA = "0x1162904")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x116290C", Offset = "0x116290C", VA = "0x116290C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1162910", Offset = "0x1162910", VA = "0x1162910", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1162988", Offset = "0x1162988", VA = "0x1162988", Slot = "10")]
		protected override void init()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x116343C", Offset = "0x116343C", VA = "0x116343C")]
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
				[Address(RVA = "0x1164D38", Offset = "0x1164D38", VA = "0x1164D38", Slot = "4")]
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
				[Address(RVA = "0x1164D80", Offset = "0x1164D80", VA = "0x1164D80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1163C60", Offset = "0x1163C60", VA = "0x1163C60")]
			[DebuggerHidden]
			public <loadWeb>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x6000A8A")]
			[Address(RVA = "0x1163D88", Offset = "0x1163D88", VA = "0x1163D88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A8B")]
			[Address(RVA = "0x1163DB4", Offset = "0x1163DB4", VA = "0x1163DB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A8C")]
			[Address(RVA = "0x1164C88", Offset = "0x1164C88", VA = "0x1164C88")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1164D40", Offset = "0x1164D40", VA = "0x1164D40", Slot = "8")]
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
				[Address(RVA = "0x1165260", Offset = "0x1165260", VA = "0x1165260", Slot = "4")]
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
				[Address(RVA = "0x11652A8", Offset = "0x11652A8", VA = "0x11652A8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1163C88", Offset = "0x1163C88", VA = "0x1163C88")]
			[DebuggerHidden]
			public <loadResource>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1164D88", Offset = "0x1164D88", VA = "0x1164D88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1164D8C", Offset = "0x1164D8C", VA = "0x1164D8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1165268", Offset = "0x1165268", VA = "0x1165268", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1163640", Offset = "0x1163640", VA = "0x1163640", Slot = "8")]
		public override void Load()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x1163BF0", Offset = "0x1163BF0", VA = "0x1163BF0", Slot = "9")]
		public override void Save()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x1163B60", Offset = "0x1163B60", VA = "0x1163B60")]
		[IteratorStateMachine(typeof(<loadWeb>d__2))]
		private IEnumerator loadWeb(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x1163AD0", Offset = "0x1163AD0", VA = "0x1163AD0")]
		[IteratorStateMachine(typeof(<loadResource>d__3))]
		private IEnumerator loadResource(Source src)
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x1163CB0", Offset = "0x1163CB0", VA = "0x1163CB0")]
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
		[Address(RVA = "0x1161A48", Offset = "0x1161A48", VA = "0x1161A48")]
		public BadWords(Source source, IEnumerable<string> badWordList)
		{
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x11652B0", Offset = "0x11652B0", VA = "0x11652B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x1165488", Offset = "0x1165488", VA = "0x1165488", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x11655D8", Offset = "0x11655D8", VA = "0x11655D8", Slot = "2")]
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
		[Address(RVA = "0x1164884", Offset = "0x1164884", VA = "0x1164884")]
		public Domains(Source source, IEnumerable<string> domainList)
		{
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x11655E0", Offset = "0x11655E0", VA = "0x11655E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x11657B8", Offset = "0x11657B8", VA = "0x11657B8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x1165908", Offset = "0x1165908", VA = "0x1165908", Slot = "2")]
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
			[Address(RVA = "0x11664B8", Offset = "0x11664B8", VA = "0x11664B8")]
			public <>c__DisplayClass50_0()
			{
			}

			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x11664C0", Offset = "0x11664C0", VA = "0x11664C0")]
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
				[Address(RVA = "0x11666F4", Offset = "0x11666F4", VA = "0x11666F4", Slot = "4")]
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
				[Address(RVA = "0x116673C", Offset = "0x116673C", VA = "0x116673C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x116633C", Offset = "0x116633C", VA = "0x116633C")]
			[DebuggerHidden]
			public <containsAsync>d__50(int <>1__state)
			{
			}

			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x11664EC", Offset = "0x11664EC", VA = "0x11664EC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x11664F0", Offset = "0x11664F0", VA = "0x11664F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ACC")]
			[Address(RVA = "0x11666FC", Offset = "0x11666FC", VA = "0x11666FC", Slot = "8")]
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
			[Address(RVA = "0x1166744", Offset = "0x1166744", VA = "0x1166744")]
			public <>c__DisplayClass51_0()
			{
			}

			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x116674C", Offset = "0x116674C", VA = "0x116674C")]
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
				[Address(RVA = "0x116698C", Offset = "0x116698C", VA = "0x116698C", Slot = "4")]
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
				[Address(RVA = "0x11669D4", Offset = "0x11669D4", VA = "0x11669D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x1166364", Offset = "0x1166364", VA = "0x1166364")]
			[DebuggerHidden]
			public <getAllAsync>d__51(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x116677C", Offset = "0x116677C", VA = "0x116677C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x1166780", Offset = "0x1166780", VA = "0x1166780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x1166994", Offset = "0x1166994", VA = "0x1166994", Slot = "8")]
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
			[Address(RVA = "0x11669DC", Offset = "0x11669DC", VA = "0x11669DC")]
			public <>c__DisplayClass52_0()
			{
			}

			[Token(Token = "0x6000AD7")]
			[Address(RVA = "0x11669E4", Offset = "0x11669E4", VA = "0x11669E4")]
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
				[Address(RVA = "0x1166C60", Offset = "0x1166C60", VA = "0x1166C60", Slot = "4")]
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
				[Address(RVA = "0x1166CA8", Offset = "0x1166CA8", VA = "0x1166CA8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000AD8")]
			[Address(RVA = "0x116638C", Offset = "0x116638C", VA = "0x116638C")]
			[DebuggerHidden]
			public <replaceAllAsync>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000AD9")]
			[Address(RVA = "0x1166A20", Offset = "0x1166A20", VA = "0x1166A20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000ADA")]
			[Address(RVA = "0x1166A24", Offset = "0x1166A24", VA = "0x1166A24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000ADC")]
			[Address(RVA = "0x1166C68", Offset = "0x1166C68", VA = "0x1166C68", Slot = "8")]
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
			[Address(RVA = "0x1165910", Offset = "0x1165910", VA = "0x1165910")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x116592C", Offset = "0x116592C", VA = "0x116592C")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public ReplaceMode Mode
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1165964", Offset = "0x1165964", VA = "0x1165964")]
			get
			{
				return default(ReplaceMode);
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x1165980", Offset = "0x1165980", VA = "0x1165980")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool RemoveSpaces
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x11659A0", Offset = "0x11659A0", VA = "0x11659A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x11659BC", Offset = "0x11659BC", VA = "0x11659BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000157")]
		public bool SimpleCheck
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x11659E0", Offset = "0x11659E0", VA = "0x11659E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x11659FC", Offset = "0x11659FC", VA = "0x11659FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000158")]
		public List<BadWordProvider> BadWordProviderLTR
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x1165A20", Offset = "0x1165A20", VA = "0x1165A20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x1165A28", Offset = "0x1165A28", VA = "0x1165A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000159")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x1165A30", Offset = "0x1165A30", VA = "0x1165A30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x1165A38", Offset = "0x1165A38", VA = "0x1165A38")]
			set
			{
			}
		}

		[Token(Token = "0x1700015A")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x115BE80", Offset = "0x115BE80", VA = "0x115BE80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015B")]
		public int TotalRegexCount
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x1165A40", Offset = "0x1165A40", VA = "0x1165A40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015C")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x1165B60", Offset = "0x1165B60", VA = "0x1165B60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015D")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1165B68", Offset = "0x1165B68", VA = "0x1165B68", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1165B70", Offset = "0x1165B70", VA = "0x1165B70", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AB3")]
		[Address(RVA = "0x1165B78", Offset = "0x1165B78", VA = "0x1165B78", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AB4")]
		[Address(RVA = "0x1165C60", Offset = "0x1165C60", VA = "0x1165C60")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000AB5")]
		[Address(RVA = "0x1165D1C", Offset = "0x1165D1C", VA = "0x1165D1C", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x1165E08", Offset = "0x1165E08", VA = "0x1165E08")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x115BBC0", Offset = "0x115BBC0", VA = "0x115BBC0")]
		public void Load()
		{
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x115DB74", Offset = "0x115DB74", VA = "0x115DB74")]
		public bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x11660A8", Offset = "0x11660A8", VA = "0x11660A8")]
		public void ContainsAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x115DDAC", Offset = "0x115DDAC", VA = "0x115DDAC")]
		public List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x116616C", Offset = "0x116616C", VA = "0x116616C")]
		public void GetAllAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x115E15C", Offset = "0x115E15C", VA = "0x115E15C")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1166230", Offset = "0x1166230", VA = "0x1166230")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x115D728", Offset = "0x115D728", VA = "0x115D728")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x11660C8", Offset = "0x11660C8", VA = "0x11660C8")]
		[IteratorStateMachine(typeof(<containsAsync>d__50))]
		private IEnumerator containsAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x116618C", Offset = "0x116618C", VA = "0x116618C")]
		[IteratorStateMachine(typeof(<getAllAsync>d__51))]
		private IEnumerator getAllAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1166254", Offset = "0x1166254", VA = "0x1166254")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__52))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x11663B4", Offset = "0x11663B4", VA = "0x11663B4")]
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
			[Address(RVA = "0x11672A0", Offset = "0x11672A0", VA = "0x11672A0")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x11672A8", Offset = "0x11672A8", VA = "0x11672A8")]
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
				[Address(RVA = "0x11674C8", Offset = "0x11674C8", VA = "0x11674C8", Slot = "4")]
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
				[Address(RVA = "0x1167510", Offset = "0x1167510", VA = "0x1167510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x11671D8", Offset = "0x11671D8", VA = "0x11671D8")]
			[DebuggerHidden]
			public <containsAsync>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x11672D4", Offset = "0x11672D4", VA = "0x11672D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x11672D8", Offset = "0x11672D8", VA = "0x11672D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x11674D0", Offset = "0x11674D0", VA = "0x11674D0", Slot = "8")]
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
			[Address(RVA = "0x1167518", Offset = "0x1167518", VA = "0x1167518")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x1167520", Offset = "0x1167520", VA = "0x1167520")]
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
				[Address(RVA = "0x1167748", Offset = "0x1167748", VA = "0x1167748", Slot = "4")]
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
				[Address(RVA = "0x1167790", Offset = "0x1167790", VA = "0x1167790", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x1167200", Offset = "0x1167200", VA = "0x1167200")]
			[DebuggerHidden]
			public <getAllAsync>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x1167550", Offset = "0x1167550", VA = "0x1167550", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x1167554", Offset = "0x1167554", VA = "0x1167554", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x1167750", Offset = "0x1167750", VA = "0x1167750", Slot = "8")]
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
			[Address(RVA = "0x1167798", Offset = "0x1167798", VA = "0x1167798")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x11677A0", Offset = "0x11677A0", VA = "0x11677A0")]
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
				[Address(RVA = "0x1167A04", Offset = "0x1167A04", VA = "0x1167A04", Slot = "4")]
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
				[Address(RVA = "0x1167A4C", Offset = "0x1167A4C", VA = "0x1167A4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x1167228", Offset = "0x1167228", VA = "0x1167228")]
			[DebuggerHidden]
			public <replaceAllAsync>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x11677D8", Offset = "0x11677D8", VA = "0x11677D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x11677DC", Offset = "0x11677DC", VA = "0x11677DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x1167A0C", Offset = "0x1167A0C", VA = "0x1167A0C", Slot = "8")]
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
			[Address(RVA = "0x1166CB0", Offset = "0x1166CB0", VA = "0x1166CB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x1166CCC", Offset = "0x1166CCC", VA = "0x1166CCC")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x1166CFC", Offset = "0x1166CFC", VA = "0x1166CFC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016C")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x1166D04", Offset = "0x1166D04", VA = "0x1166D04", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x1166D0C", Offset = "0x1166D0C", VA = "0x1166D0C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x1166D14", Offset = "0x1166D14", VA = "0x1166D14", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x1166DFC", Offset = "0x1166DFC", VA = "0x1166DFC", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x1166EE8", Offset = "0x1166EE8", VA = "0x1166EE8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x1166F24", Offset = "0x1166F24", VA = "0x1166F24")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x115BD60", Offset = "0x115BD60", VA = "0x115BD60")]
		public void Load()
		{
		}

		[Token(Token = "0x6000AFA")]
		[Address(RVA = "0x115DC2C", Offset = "0x115DC2C", VA = "0x115DC2C")]
		public bool Contains(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AFB")]
		[Address(RVA = "0x1166F88", Offset = "0x1166F88", VA = "0x1166F88")]
		public void ContainsAsync(string text)
		{
		}

		[Token(Token = "0x6000AFC")]
		[Address(RVA = "0x115DF34", Offset = "0x115DF34", VA = "0x115DF34")]
		public List<string> GetAll(string text)
		{
			return null;
		}

		[Token(Token = "0x6000AFD")]
		[Address(RVA = "0x1167038", Offset = "0x1167038", VA = "0x1167038")]
		public void GetAllAsync(string text)
		{
		}

		[Token(Token = "0x6000AFE")]
		[Address(RVA = "0x115E27C", Offset = "0x115E27C", VA = "0x115E27C")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000AFF")]
		[Address(RVA = "0x11670E8", Offset = "0x11670E8", VA = "0x11670E8")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
		}

		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x115D848", Offset = "0x115D848", VA = "0x115D848")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x1166FA8", Offset = "0x1166FA8", VA = "0x1166FA8")]
		[IteratorStateMachine(typeof(<containsAsync>d__26))]
		private IEnumerator containsAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x1167058", Offset = "0x1167058", VA = "0x1167058")]
		[IteratorStateMachine(typeof(<getAllAsync>d__27))]
		private IEnumerator getAllAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x116710C", Offset = "0x116710C", VA = "0x116710C")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__28))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B04")]
		[Address(RVA = "0x1167250", Offset = "0x1167250", VA = "0x1167250")]
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
			[Address(RVA = "0x116827C", Offset = "0x116827C", VA = "0x116827C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000B3A")]
			[Address(RVA = "0x1168284", Offset = "0x1168284", VA = "0x1168284")]
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
				[Address(RVA = "0x11684B8", Offset = "0x11684B8", VA = "0x11684B8", Slot = "4")]
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
				[Address(RVA = "0x1168500", Offset = "0x1168500", VA = "0x1168500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0x1168100", Offset = "0x1168100", VA = "0x1168100")]
			[DebuggerHidden]
			public <containsAsync>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x11682B0", Offset = "0x11682B0", VA = "0x11682B0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x11682B4", Offset = "0x11682B4", VA = "0x11682B4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x11684C0", Offset = "0x11684C0", VA = "0x11684C0", Slot = "8")]
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
			[Address(RVA = "0x1168508", Offset = "0x1168508", VA = "0x1168508")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x1168510", Offset = "0x1168510", VA = "0x1168510")]
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
				[Address(RVA = "0x1168750", Offset = "0x1168750", VA = "0x1168750", Slot = "4")]
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
				[Address(RVA = "0x1168798", Offset = "0x1168798", VA = "0x1168798", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x1168128", Offset = "0x1168128", VA = "0x1168128")]
			[DebuggerHidden]
			public <getAllAsync>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1168540", Offset = "0x1168540", VA = "0x1168540", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x1168544", Offset = "0x1168544", VA = "0x1168544", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x1168758", Offset = "0x1168758", VA = "0x1168758", Slot = "8")]
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
			[Address(RVA = "0x11687A0", Offset = "0x11687A0", VA = "0x11687A0")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000B4A")]
			[Address(RVA = "0x11687A8", Offset = "0x11687A8", VA = "0x11687A8")]
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
				[Address(RVA = "0x1168A24", Offset = "0x1168A24", VA = "0x1168A24", Slot = "4")]
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
				[Address(RVA = "0x1168A6C", Offset = "0x1168A6C", VA = "0x1168A6C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B4B")]
			[Address(RVA = "0x1168150", Offset = "0x1168150", VA = "0x1168150")]
			[DebuggerHidden]
			public <replaceAllAsync>d__36(int <>1__state)
			{
			}

			[Token(Token = "0x6000B4C")]
			[Address(RVA = "0x11687E4", Offset = "0x11687E4", VA = "0x11687E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B4D")]
			[Address(RVA = "0x11687E8", Offset = "0x11687E8", VA = "0x11687E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x1168A2C", Offset = "0x1168A2C", VA = "0x1168A2C", Slot = "8")]
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
			[Address(RVA = "0x1167A54", Offset = "0x1167A54", VA = "0x1167A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x1167A70", Offset = "0x1167A70", VA = "0x1167A70")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public List<DomainProvider> DomainProvider
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x1167AA8", Offset = "0x1167AA8", VA = "0x1167AA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x1167AB0", Offset = "0x1167AB0", VA = "0x1167AB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public List<Source> Sources
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x115BE98", Offset = "0x115BE98", VA = "0x115BE98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		public int TotalRegexCount
		{
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x1167AB8", Offset = "0x1167AB8", VA = "0x1167AB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000178")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x1167BD8", Offset = "0x1167BD8", VA = "0x1167BD8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000179")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x1167BE0", Offset = "0x1167BE0", VA = "0x1167BE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000B25")]
			[Address(RVA = "0x1167BE8", Offset = "0x1167BE8", VA = "0x1167BE8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x1167BF0", Offset = "0x1167BF0", VA = "0x1167BF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x1167CD8", Offset = "0x1167CD8", VA = "0x1167CD8")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B28")]
		[Address(RVA = "0x1167D1C", Offset = "0x1167D1C", VA = "0x1167D1C", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1167E08", Offset = "0x1167E08", VA = "0x1167E08")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x115BCCC", Offset = "0x115BCCC", VA = "0x115BCCC")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x115DBD0", Offset = "0x115DBD0", VA = "0x115DBD0")]
		public bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x1167E6C", Offset = "0x1167E6C", VA = "0x1167E6C")]
		public void ContainsAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x115DE70", Offset = "0x115DE70", VA = "0x115DE70")]
		public List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1167F30", Offset = "0x1167F30", VA = "0x1167F30")]
		public void GetAllAsync(string text, params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x115E1EC", Offset = "0x115E1EC", VA = "0x115E1EC")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x1167FF4", Offset = "0x1167FF4", VA = "0x1167FF4")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x115D7B8", Offset = "0x115D7B8", VA = "0x115D7B8")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x1167E8C", Offset = "0x1167E8C", VA = "0x1167E8C")]
		[IteratorStateMachine(typeof(<containsAsync>d__34))]
		private IEnumerator containsAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x1167F50", Offset = "0x1167F50", VA = "0x1167F50")]
		[IteratorStateMachine(typeof(<getAllAsync>d__35))]
		private IEnumerator getAllAsync(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x1168018", Offset = "0x1168018", VA = "0x1168018")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__36))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1168178", Offset = "0x1168178", VA = "0x1168178")]
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
			[Address(RVA = "0x1169064", Offset = "0x1169064", VA = "0x1169064")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x116906C", Offset = "0x116906C", VA = "0x116906C")]
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
				[Address(RVA = "0x116928C", Offset = "0x116928C", VA = "0x116928C", Slot = "4")]
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
				[Address(RVA = "0x11692D4", Offset = "0x11692D4", VA = "0x11692D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B68")]
			[Address(RVA = "0x1168F9C", Offset = "0x1168F9C", VA = "0x1168F9C")]
			[DebuggerHidden]
			public <containsAsync>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x1169098", Offset = "0x1169098", VA = "0x1169098", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x116909C", Offset = "0x116909C", VA = "0x116909C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x1169294", Offset = "0x1169294", VA = "0x1169294", Slot = "8")]
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
			[Address(RVA = "0x11692DC", Offset = "0x11692DC", VA = "0x11692DC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x11692E4", Offset = "0x11692E4", VA = "0x11692E4")]
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
				[Address(RVA = "0x116950C", Offset = "0x116950C", VA = "0x116950C", Slot = "4")]
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
				[Address(RVA = "0x1169554", Offset = "0x1169554", VA = "0x1169554", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x1168FC4", Offset = "0x1168FC4", VA = "0x1168FC4")]
			[DebuggerHidden]
			public <getAllAsync>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x1169314", Offset = "0x1169314", VA = "0x1169314", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B72")]
			[Address(RVA = "0x1169318", Offset = "0x1169318", VA = "0x1169318", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B74")]
			[Address(RVA = "0x1169514", Offset = "0x1169514", VA = "0x1169514", Slot = "8")]
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
			[Address(RVA = "0x116955C", Offset = "0x116955C", VA = "0x116955C")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000B77")]
			[Address(RVA = "0x1169564", Offset = "0x1169564", VA = "0x1169564")]
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
				[Address(RVA = "0x11697C8", Offset = "0x11697C8", VA = "0x11697C8", Slot = "4")]
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
				[Address(RVA = "0x1169810", Offset = "0x1169810", VA = "0x1169810", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x1168FEC", Offset = "0x1168FEC", VA = "0x1168FEC")]
			[DebuggerHidden]
			public <replaceAllAsync>d__28(int <>1__state)
			{
			}

			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x116959C", Offset = "0x116959C", VA = "0x116959C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x11695A0", Offset = "0x11695A0", VA = "0x11695A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B7C")]
			[Address(RVA = "0x11697D0", Offset = "0x11697D0", VA = "0x11697D0", Slot = "8")]
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
			[Address(RVA = "0x1168A74", Offset = "0x1168A74", VA = "0x1168A74")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B52")]
			[Address(RVA = "0x1168A90", Offset = "0x1168A90", VA = "0x1168A90")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		protected override OnContainsCompleted onContainsCompleted
		{
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x1168AC0", Offset = "0x1168AC0", VA = "0x1168AC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		protected override OnGetAllCompleted onGetAllCompleted
		{
			[Token(Token = "0x6000B54")]
			[Address(RVA = "0x1168AC8", Offset = "0x1168AC8", VA = "0x1168AC8", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		protected override OnReplaceAllCompleted onReplaceAllCompleted
		{
			[Token(Token = "0x6000B55")]
			[Address(RVA = "0x1168AD0", Offset = "0x1168AD0", VA = "0x1168AD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x1168AD8", Offset = "0x1168AD8", VA = "0x1168AD8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x1168BC0", Offset = "0x1168BC0", VA = "0x1168BC0", Slot = "6")]
		protected override void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x1168CAC", Offset = "0x1168CAC", VA = "0x1168CAC")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x1168CE8", Offset = "0x1168CE8", VA = "0x1168CE8")]
		public static void ResetObject()
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x115BDF0", Offset = "0x115BDF0", VA = "0x115BDF0")]
		public void Load()
		{
		}

		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x115DCEC", Offset = "0x115DCEC", VA = "0x115DCEC")]
		public bool Contains(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1168D4C", Offset = "0x1168D4C", VA = "0x1168D4C")]
		public void ContainsAsync(string text)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x115E048", Offset = "0x115E048", VA = "0x115E048")]
		public List<string> GetAll(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1168DFC", Offset = "0x1168DFC", VA = "0x1168DFC")]
		public void GetAllAsync(string text)
		{
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x115E370", Offset = "0x115E370", VA = "0x115E370")]
		public string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x1168EAC", Offset = "0x1168EAC", VA = "0x1168EAC")]
		public void ReplaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x115D93C", Offset = "0x115D93C", VA = "0x115D93C")]
		public string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x1168D6C", Offset = "0x1168D6C", VA = "0x1168D6C")]
		[IteratorStateMachine(typeof(<containsAsync>d__26))]
		private IEnumerator containsAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x1168E1C", Offset = "0x1168E1C", VA = "0x1168E1C")]
		[IteratorStateMachine(typeof(<getAllAsync>d__27))]
		private IEnumerator getAllAsync(string text)
		{
			return null;
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x1168ED0", Offset = "0x1168ED0", VA = "0x1168ED0")]
		[IteratorStateMachine(typeof(<replaceAllAsync>d__28))]
		private IEnumerator replaceAllAsync(string text, bool markOnly = false, string prefix = "", string postfix = "")
		{
			return null;
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x1169014", Offset = "0x1169014", VA = "0x1169014")]
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
			[Address(RVA = "0x1169818", Offset = "0x1169818", VA = "0x1169818")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B7F")]
			[Address(RVA = "0x1169820", Offset = "0x1169820", VA = "0x1169820")]
			set
			{
			}
		}

		[Token(Token = "0x1700018C")]
		public List<BadWordProvider> BadWordProviderRTL
		{
			[Token(Token = "0x6000B80")]
			[Address(RVA = "0x1169BE4", Offset = "0x1169BE4", VA = "0x1169BE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B81")]
			[Address(RVA = "0x1169BEC", Offset = "0x1169BEC", VA = "0x1169BEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700018D")]
		public override bool isReady
		{
			[Token(Token = "0x6000B82")]
			[Address(RVA = "0x1169FB0", Offset = "0x1169FB0", VA = "0x1169FB0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x1165E6C", Offset = "0x1165E6C", VA = "0x1165E6C")]
		public BadWordFilter(List<BadWordProvider> badWordProviderLTR, List<BadWordProvider> badWordProviderRTL, string replaceCharacters = "*", ReplaceMode mode = ReplaceMode.Default, bool simpleCheck = false, bool removeSpaces = false, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x116AEF4", Offset = "0x116AEF4", VA = "0x116AEF4", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x116BB8C", Offset = "0x116BB8C", VA = "0x116BB8C", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B86")]
		[Address(RVA = "0x116F3B8", Offset = "0x116F3B8", VA = "0x116F3B8", Slot = "15")]
		public override string ReplaceAll(string text, bool markOnly = false, string prefix = "", string postfix = "", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000B87")]
		[Address(RVA = "0x11711DC", Offset = "0x11711DC", VA = "0x11711DC")]
		private string replaceCapture(string text, Capture capture, bool markOnly, string prefix, string postfix, int offset)
		{
			return null;
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x116BB38", Offset = "0x116BB38", VA = "0x116BB38")]
		protected string replaceText(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x11720B8", Offset = "0x11720B8", VA = "0x11720B8")]
		private static string replaceNonLettersOrDigits(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x1171338", Offset = "0x1171338", VA = "0x1171338")]
		private static string replaceSpacesBetweenLetters(string text, int maxTextLength = 1)
		{
			return null;
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x1171564", Offset = "0x1171564", VA = "0x1171564")]
		private static string replaceLeetToText(string input)
		{
			return null;
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x1171AB4", Offset = "0x1171AB4", VA = "0x1171AB4")]
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
			[Address(RVA = "0x1174844", Offset = "0x1174844", VA = "0x1174844", Slot = "11")]
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
		[Address(RVA = "0x1174754", Offset = "0x1174754", VA = "0x1174754")]
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
		[Address(RVA = "0x1174AFC", Offset = "0x1174AFC", VA = "0x1174AFC", Slot = "16")]
		public virtual string Unmark(string text, string prefix = "<b><color=red>", string postfix = "</color></b>")
		{
			return null;
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x1174DC4", Offset = "0x1174DC4", VA = "0x1174DC4", Slot = "17")]
		public virtual string Mark(string text, bool replace = false, string prefix = "<b><color=red>", string postfix = "</color></b>", params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x1174A94", Offset = "0x1174A94", VA = "0x1174A94")]
		protected static void logFilterNotReady()
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1174DDC", Offset = "0x1174DDC", VA = "0x1174DDC")]
		protected static void logResourceNotFound(string res)
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x1175048", Offset = "0x1175048", VA = "0x1175048")]
		protected static void logContains()
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x117512C", Offset = "0x117512C", VA = "0x117512C")]
		protected static void logGetAll()
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x1175210", Offset = "0x1175210", VA = "0x1175210")]
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
			[Address(RVA = "0x11753E4", Offset = "0x11753E4", VA = "0x11753E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x11753EC", Offset = "0x11753EC", VA = "0x11753EC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public int CharacterNumber
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x11753F4", Offset = "0x11753F4", VA = "0x11753F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x11753FC", Offset = "0x11753FC", VA = "0x11753FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public override bool isReady
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x11754E4", Offset = "0x11754E4", VA = "0x11754E4", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x11754EC", Offset = "0x11754EC", VA = "0x11754EC")]
		public CapitalizationFilter(int capitalizationCharsNumber = 3, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1175518", Offset = "0x1175518", VA = "0x1175518", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1175578", Offset = "0x1175578", VA = "0x1175578", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BE7")]
		[Address(RVA = "0x1175D4C", Offset = "0x1175D4C", VA = "0x1175D4C", Slot = "15")]
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
			[Address(RVA = "0x1176504", Offset = "0x1176504", VA = "0x1176504")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x117650C", Offset = "0x117650C", VA = "0x117650C")]
			set
			{
			}
		}

		[Token(Token = "0x17000194")]
		public override bool isReady
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1176898", Offset = "0x1176898", VA = "0x1176898", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x11770C8", Offset = "0x11770C8", VA = "0x11770C8")]
		public DomainFilter(List<DomainProvider> domainProvider, string replaceCharacters = "*", bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x117722C", Offset = "0x117722C", VA = "0x117722C", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x1177968", Offset = "0x1177968", VA = "0x1177968", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x1179AC0", Offset = "0x1179AC0", VA = "0x1179AC0", Slot = "15")]
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
			[Address(RVA = "0x117BFD0", Offset = "0x117BFD0", VA = "0x117BFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C27")]
			[Address(RVA = "0x117BFD8", Offset = "0x117BFD8", VA = "0x117BFD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public int CharacterNumber
		{
			[Token(Token = "0x6000C28")]
			[Address(RVA = "0x117BFE0", Offset = "0x117BFE0", VA = "0x117BFE0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C29")]
			[Address(RVA = "0x117BFE8", Offset = "0x117BFE8", VA = "0x117BFE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public override bool isReady
		{
			[Token(Token = "0x6000C2A")]
			[Address(RVA = "0x117C0D0", Offset = "0x117C0D0", VA = "0x117C0D0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x117C0D8", Offset = "0x117C0D8", VA = "0x117C0D8")]
		public PunctuationFilter(int punctuationCharacterNumber = 3, bool disableOrdering = false)
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x117C104", Offset = "0x117C104", VA = "0x117C104", Slot = "13")]
		public override bool Contains(string text, params string[] sourceNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x117C164", Offset = "0x117C164", VA = "0x117C164", Slot = "14")]
		public override List<string> GetAll(string text, params string[] sourceNames)
		{
			return null;
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x117C938", Offset = "0x117C938", VA = "0x117C938", Slot = "15")]
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
			[Address(RVA = "0x117D100", Offset = "0x117D100", VA = "0x117D100")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C37")]
			[Address(RVA = "0x117D108", Offset = "0x117D108", VA = "0x117D108")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public string Culture
		{
			[Token(Token = "0x6000C38")]
			[Address(RVA = "0x117D110", Offset = "0x117D110", VA = "0x117D110")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C39")]
			[Address(RVA = "0x117D118", Offset = "0x117D118", VA = "0x117D118")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		public string Description
		{
			[Token(Token = "0x6000C3A")]
			[Address(RVA = "0x117D120", Offset = "0x117D120", VA = "0x117D120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3B")]
			[Address(RVA = "0x117D128", Offset = "0x117D128", VA = "0x117D128")]
			set
			{
			}
		}

		[Token(Token = "0x1700019D")]
		public Sprite Icon
		{
			[Token(Token = "0x6000C3C")]
			[Address(RVA = "0x117D130", Offset = "0x117D130", VA = "0x117D130")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3D")]
			[Address(RVA = "0x117D138", Offset = "0x117D138", VA = "0x117D138")]
			set
			{
			}
		}

		[Token(Token = "0x1700019E")]
		public string URL
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x117D140", Offset = "0x117D140", VA = "0x117D140")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x117D148", Offset = "0x117D148", VA = "0x117D148")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public TextAsset Resource
		{
			[Token(Token = "0x6000C40")]
			[Address(RVA = "0x117D150", Offset = "0x117D150", VA = "0x117D150")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x117D158", Offset = "0x117D158", VA = "0x117D158")]
			set
			{
			}
		}

		[Token(Token = "0x170001A0")]
		public int RegexCount
		{
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x117D160", Offset = "0x117D160", VA = "0x117D160")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x117D168", Offset = "0x117D168", VA = "0x117D168")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000C44")]
		[Address(RVA = "0x117D170", Offset = "0x117D170", VA = "0x117D170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000C45")]
		[Address(RVA = "0x117D480", Offset = "0x117D480", VA = "0x117D480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C46")]
		[Address(RVA = "0x117D5FC", Offset = "0x117D5FC", VA = "0x117D5FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x117D6EC", Offset = "0x117D6EC", VA = "0x117D6EC")]
		public Source()
		{
		}
	}
}
