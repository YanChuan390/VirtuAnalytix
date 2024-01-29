using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
namespace CafofoStudio;

[Token(Token = "0x2000002")]
public abstract class AmbienceMixer<P> : MonoBehaviour where P : AmbientPreset
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	public bool playOnAwake;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	public List<P> presets;

	[Token(Token = "0x17000001")]
	[SerializeField]
	protected abstract List<SoundElement> elements
	{
		[Token(Token = "0x6000001")]
		get;
	}

	[Token(Token = "0x6000002")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000003")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	public void Play()
	{
	}

	[Token(Token = "0x6000005")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000006")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000007")]
	public abstract void ApplyPreset(P selectedPreset);

	[Token(Token = "0x6000008")]
	protected AmbienceMixer()
	{
	}
}
[Token(Token = "0x2000003")]
public abstract class AmbientPreset : ScriptableObject
{
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x18")]
	public string presetName;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10E018C", Offset = "0x10E018C", VA = "0x10E018C")]
	protected AmbientPreset()
	{
	}
}
[Token(Token = "0x2000004")]
public interface ISoundSubElement
{
	[Token(Token = "0x600000A")]
	void InitializeAudioSources(GameObject parent, AudioMixerGroup outputMixer);

	[Token(Token = "0x600000B")]
	void CalculateIntensity(float intensity, float volumeMultiplier);

	[Token(Token = "0x600000C")]
	void SetOutputMixerGroup(AudioMixerGroup overrideOutputMixer);

	[Token(Token = "0x600000D")]
	void Play();

	[Token(Token = "0x600000E")]
	void Stop();
}
[Token(Token = "0x2000005")]
public static class ListExtensions
{
	[Token(Token = "0x600000F")]
	public static void Shuffle<T>(this List<T> list)
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class SoundElement
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string soundName;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private AudioMixerGroup overrideOutputMixer;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float intensity;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string maxIntensityLabel;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string minIntensityLabel;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float volumeMultiplier;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private List<SoundSubElementSample> sampleSubElements;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private List<SoundSubElementLoop> loopSubElements;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10E01E4", Offset = "0x10E01E4", VA = "0x10E01E4")]
	public void InitializeAudioSources(GameObject parent)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x10E0610", Offset = "0x10E0610", VA = "0x10E0610")]
	private void CalculateIntensity()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x10E0984", Offset = "0x10E0984", VA = "0x10E0984")]
	public void UpdateSampleTimer()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x10E0B08", Offset = "0x10E0B08", VA = "0x10E0B08")]
	public void SetIntensity(float intensity)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x10E0B88", Offset = "0x10E0B88", VA = "0x10E0B88")]
	public float GetIntensity()
	{
		return default(float);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x10E0B90", Offset = "0x10E0B90", VA = "0x10E0B90")]
	public void SetVolumeMultiplier(float volumeMultiplier)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x10E0CC8", Offset = "0x10E0CC8", VA = "0x10E0CC8")]
	public float GetVolumeMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x10E0CD0", Offset = "0x10E0CD0", VA = "0x10E0CD0")]
	public void SetOutputMixerGroup(AudioMixerGroup overrideOutputMixer)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x10E103C", Offset = "0x10E103C", VA = "0x10E103C")]
	public AudioMixerGroup GetOutputMixerGroup()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x10E1044", Offset = "0x10E1044", VA = "0x10E1044")]
	public void Play()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10E12EC", Offset = "0x10E12EC", VA = "0x10E12EC")]
	public void Stop()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10E158C", Offset = "0x10E158C", VA = "0x10E158C")]
	public SoundElement()
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class SoundSubElementLoop : ISoundSubElement
{
	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private bool isAditive;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<AudioClip> audioClips;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x20")]
	private List<AudioSource> loopAudioSources;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10E03B0", Offset = "0x10E03B0", VA = "0x10E03B0", Slot = "4")]
	public void InitializeAudioSources(GameObject parent, AudioMixerGroup outputMixer)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10E07C4", Offset = "0x10E07C4", VA = "0x10E07C4", Slot = "5")]
	public void CalculateIntensity(float intensity, float volumeMultiplier)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10E159C", Offset = "0x10E159C", VA = "0x10E159C")]
	private void CalculateAditiveIntensity(float intensity, float volumeMultiplier)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10E1690", Offset = "0x10E1690", VA = "0x10E1690")]
	private void CalculateCrossfadeIntensity(float intensity, float volumeMultiplier)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x10E17F4", Offset = "0x10E17F4", VA = "0x10E17F4")]
	private float CalculateCrossfade(float periodLength, float intensity)
	{
		return default(float);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10E0E90", Offset = "0x10E0E90", VA = "0x10E0E90", Slot = "6")]
	public void SetOutputMixerGroup(AudioMixerGroup overrideOutputMixer)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10E11EC", Offset = "0x10E11EC", VA = "0x10E11EC", Slot = "7")]
	public void Play()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10E1490", Offset = "0x10E1490", VA = "0x10E1490", Slot = "8")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10E182C", Offset = "0x10E182C", VA = "0x10E182C")]
	public SoundSubElementLoop()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class SoundSubElementSample : ISoundSubElement
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private List<AudioClip> audioClips;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56D4BC", Offset = "0x56D4BC")]
	public float lowIntensityMinSeconds;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56D4F4", Offset = "0x56D4F4")]
	public float lowIntensityMaxSeconds;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56D52C", Offset = "0x56D52C")]
	public float highIntensityMinSeconds;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x56D564", Offset = "0x56D564")]
	public float highIntensityMaxSeconds;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	private float nextSampleCountdown;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	private List<int> availableSoundIndexes;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	private List<AudioSource> audioSourcePool;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x40")]
	private bool isPlaying;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	private GameObject mParentGO;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x50")]
	private AudioMixerGroup mOutputMixer;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10E0594", Offset = "0x10E0594", VA = "0x10E0594", Slot = "4")]
	public void InitializeAudioSources(GameObject parent, AudioMixerGroup outputMixer)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x10E08C0", Offset = "0x10E08C0", VA = "0x10E08C0", Slot = "5")]
	public void CalculateIntensity(float intensity, float volumeMultiplier)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x10E0A80", Offset = "0x10E0A80", VA = "0x10E0A80")]
	public void UpdateSampleTimer(float intensity, float volumeMultiplier)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x10E183C", Offset = "0x10E183C", VA = "0x10E183C")]
	private void PlayAnySample(float volumeMultiplier)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x10E1B28", Offset = "0x10E1B28", VA = "0x10E1B28")]
	private int GetRandomSoundIndex()
	{
		return default(int);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x10E194C", Offset = "0x10E194C", VA = "0x10E194C")]
	private AudioSource GetAudioSource()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x10E0F30", Offset = "0x10E0F30", VA = "0x10E0F30", Slot = "6")]
	public void SetOutputMixerGroup(AudioMixerGroup overrideOutputMixer)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x10E12E0", Offset = "0x10E12E0", VA = "0x10E12E0", Slot = "7")]
	public void Play()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x10E1584", Offset = "0x10E1584", VA = "0x10E1584", Slot = "8")]
	public void Stop()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x10E1C2C", Offset = "0x10E1C2C", VA = "0x10E1C2C")]
	public SoundSubElementSample()
	{
	}
}
[Token(Token = "0x2000009")]
public class VillageAmbienceMixer : AmbienceMixer<VillageAmbiencePreset>
{
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SoundElement _birds;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SoundElement _rain;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SoundElement _waterStream;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SoundElement _fire;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SoundElement _crowd;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private SoundElement _blacksmith;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SoundElement _lumbermill;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SoundElement _humanActivity;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private SoundElement _farmAnimals;

	[Token(Token = "0x17000002")]
	public SoundElement Birds
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x10E1C9C", Offset = "0x10E1C9C", VA = "0x10E1C9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x10E1CA4", Offset = "0x10E1CA4", VA = "0x10E1CA4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public SoundElement Rain
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x10E1CA8", Offset = "0x10E1CA8", VA = "0x10E1CA8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x10E1CB0", Offset = "0x10E1CB0", VA = "0x10E1CB0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public SoundElement WaterStream
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x10E1CB4", Offset = "0x10E1CB4", VA = "0x10E1CB4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x10E1CBC", Offset = "0x10E1CBC", VA = "0x10E1CBC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public SoundElement Fire
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x10E1CC0", Offset = "0x10E1CC0", VA = "0x10E1CC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x10E1CC8", Offset = "0x10E1CC8", VA = "0x10E1CC8")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public SoundElement Crowd
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x10E1CCC", Offset = "0x10E1CCC", VA = "0x10E1CCC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x10E1CD4", Offset = "0x10E1CD4", VA = "0x10E1CD4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public SoundElement Blacksmith
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x10E1CD8", Offset = "0x10E1CD8", VA = "0x10E1CD8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x10E1CE0", Offset = "0x10E1CE0", VA = "0x10E1CE0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public SoundElement Lumbermill
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x10E1CE4", Offset = "0x10E1CE4", VA = "0x10E1CE4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x10E1CEC", Offset = "0x10E1CEC", VA = "0x10E1CEC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public SoundElement HumanActivity
	{
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x10E1CF0", Offset = "0x10E1CF0", VA = "0x10E1CF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x10E1CF8", Offset = "0x10E1CF8", VA = "0x10E1CF8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public SoundElement FarmAnimals
	{
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x10E1CFC", Offset = "0x10E1CFC", VA = "0x10E1CFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x10E1D04", Offset = "0x10E1D04", VA = "0x10E1D04")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	protected override List<SoundElement> elements
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x10E1D08", Offset = "0x10E1D08", VA = "0x10E1D08", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x10E1E18", Offset = "0x10E1E18", VA = "0x10E1E18", Slot = "5")]
	public override void ApplyPreset(VillageAmbiencePreset selectedPreset)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10E1F5C", Offset = "0x10E1F5C", VA = "0x10E1F5C")]
	public VillageAmbienceMixer()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x56D3A8", Offset = "0x56D3A8")]
public class VillageAmbiencePreset : AmbientPreset
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D62C", Offset = "0x56D62C")]
	public float birdsIntensity;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D644", Offset = "0x56D644")]
	public float birdsVolumeMultiplier;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D65C", Offset = "0x56D65C")]
	public float rainIntensity;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D674", Offset = "0x56D674")]
	public float rainVolumeMultiplier;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D68C", Offset = "0x56D68C")]
	public float waterStreamIntensity;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D6A4", Offset = "0x56D6A4")]
	public float waterStreamVolumeMultiplier;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D6BC", Offset = "0x56D6BC")]
	public float fireIntensity;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D6D4", Offset = "0x56D6D4")]
	public float fireVolumeMultiplier;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D6EC", Offset = "0x56D6EC")]
	public float crowdIntensity;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D704", Offset = "0x56D704")]
	public float crowdVolumeMultiplier;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D71C", Offset = "0x56D71C")]
	public float blacksmithIntensity;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D734", Offset = "0x56D734")]
	public float blacksmithVolumeMultiplier;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D74C", Offset = "0x56D74C")]
	public float lumbermillIntensity;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D764", Offset = "0x56D764")]
	public float lumbermillVolumeMultiplier;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D77C", Offset = "0x56D77C")]
	public float humanActivityIntensity;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D794", Offset = "0x56D794")]
	public float humanActivityVolumeMultiplier;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D7AC", Offset = "0x56D7AC")]
	public float farmAnimalsIntensity;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x56D7C4", Offset = "0x56D7C4")]
	public float farmAnimalsVolumeMultiplier;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x10E1FAC", Offset = "0x10E1FAC", VA = "0x10E1FAC")]
	public VillageAmbiencePreset()
	{
	}
}
