using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AMPInternal;
using AMPInternal.EventBinding;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[RequireComponent(typeof(AudioSource))]
public class AMPAudioSource : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 1f)]
	[SerializeField]
	private float _volume;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource _source;

	[Token(Token = "0x17000001")]
	public float Volume
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0xDCA6C4", Offset = "0xDCA6C4", VA = "0xDCA6C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0xDCA6CC", Offset = "0xDCA6CC", VA = "0xDCA6CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public AudioClip Clip
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xDCA774", Offset = "0xDCA774", VA = "0xDCA774")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xDCA790", Offset = "0xDCA790", VA = "0xDCA790")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool Loop
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0xDCA7AC", Offset = "0xDCA7AC", VA = "0xDCA7AC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0xDCA7C8", Offset = "0xDCA7C8", VA = "0xDCA7C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDCA74C", Offset = "0xDCA74C", VA = "0xDCA74C")]
	private void OnVolumeChange(float masterVolume)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDCA7E8", Offset = "0xDCA7E8", VA = "0xDCA7E8")]
	private void OnPause()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xDCA804", Offset = "0xDCA804", VA = "0xDCA804")]
	private void OnUnPause()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDCA820", Offset = "0xDCA820", VA = "0xDCA820")]
	private void OnMuteChange(bool mute)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDCA840", Offset = "0xDCA840", VA = "0xDCA840")]
	private void OnStopAll()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDCA85C", Offset = "0xDCA85C", VA = "0xDCA85C")]
	public void Play()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDCA8B0", Offset = "0xDCA8B0", VA = "0xDCA8B0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDCA8CC", Offset = "0xDCA8CC", VA = "0xDCA8CC")]
	private void FlushAllCallbacks()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDCA94C", Offset = "0xDCA94C", VA = "0xDCA94C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDCADC0", Offset = "0xDCADC0", VA = "0xDCADC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDCAA2C", Offset = "0xDCAA2C", VA = "0xDCAA2C")]
	private void RegisterAllCallbacks()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDCADC4", Offset = "0xDCADC4", VA = "0xDCADC4")]
	private void DeregisterAllCallbacks()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xDCB158", Offset = "0xDCB158", VA = "0xDCB158")]
	public AMPAudioSource()
	{
	}
}
[Token(Token = "0x2000003")]
public class AMPEventBinder : MonoBehaviour
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<BindedEvent> AllEvents;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xDCB168", Offset = "0xDCB168", VA = "0xDCB168")]
	private void ExecuteEvents(EventTriggerType DesiredEventTrigger)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xDCB5F8", Offset = "0xDCB5F8", VA = "0xDCB5F8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xDCB600", Offset = "0xDCB600", VA = "0xDCB600")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xDCB608", Offset = "0xDCB608", VA = "0xDCB608")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xDCB610", Offset = "0xDCB610", VA = "0xDCB610")]
	private void OnCollisionEnter(Collision Col)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xDCB618", Offset = "0xDCB618", VA = "0xDCB618")]
	private void OnCollisionEnter2D(Collision2D Col)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xDCB620", Offset = "0xDCB620", VA = "0xDCB620")]
	private void OnTriggerEnter(Collider Col)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xDCB628", Offset = "0xDCB628", VA = "0xDCB628")]
	private void OnTriggerEnter2D(Collider2D Col)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xDCB630", Offset = "0xDCB630", VA = "0xDCB630")]
	private void OnCollisionExit(Collision Col)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xDCB638", Offset = "0xDCB638", VA = "0xDCB638")]
	private void OnCollisionExit2D(Collision2D Col)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xDCB640", Offset = "0xDCB640", VA = "0xDCB640")]
	private void OnTriggerExit(Collider Col)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xDCB648", Offset = "0xDCB648", VA = "0xDCB648")]
	private void OnTriggerExit2D(Collider2D Col)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xDCB650", Offset = "0xDCB650", VA = "0xDCB650")]
	public AMPEventBinder()
	{
	}
}
[Token(Token = "0x2000004")]
[CreateAssetMenu(fileName = "ClipGroup", menuName = "AudioManager/ClipGroup")]
public class ClipGroup : ScriptableObject
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] Clips;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xDCB6D8", Offset = "0xDCB6D8", VA = "0xDCB6D8")]
	public ClipGroup()
	{
	}
}
[Token(Token = "0x2000005")]
public class DemoScript : MonoBehaviour
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0xDCB6E0", Offset = "0xDCB6E0", VA = "0xDCB6E0")]
	public void PlayLoop(AudioClip clip)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xDCB7D0", Offset = "0xDCB7D0", VA = "0xDCB7D0")]
	public void Play2(Track DesiredTrack)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xDCBA24", Offset = "0xDCBA24", VA = "0xDCBA24")]
	public void SetMusicVolume2(float DesiredVolume)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xDCBB00", Offset = "0xDCBB00", VA = "0xDCBB00")]
	public void SetSFXVolume2(float DesiredVolume)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xDCBB64", Offset = "0xDCBB64", VA = "0xDCBB64")]
	public void Play(Playlist DesiredPlaylist)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xDCBC5C", Offset = "0xDCBC5C", VA = "0xDCBC5C")]
	public void Play(SFXObject DesiredSFX)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xDCBCD8", Offset = "0xDCBCD8", VA = "0xDCBCD8")]
	public void Play(SFXGroup DesiredSFX)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xDCBD48", Offset = "0xDCBD48", VA = "0xDCBD48")]
	public void PlayExplosions(SFXGroup DesiredSFX)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xDCBDC4", Offset = "0xDCBDC4", VA = "0xDCBDC4")]
	public DemoScript()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public struct Edition
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[Tooltip("(Optional) The name of the Edition.")]
	public string Name;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[Tooltip("The AudioClip containing the soundtrack for this Edition.")]
	public AudioClip Soundtrack;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("The volume of the soundtrack in this Edition.")]
	public float SoundtrackVolume;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("(Optional) The AudioClip for the transition sound to be played when switching to this Edition of the Track.")]
	public AudioClip TransitionSound;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("The volume of the transition sound to this Edition.")]
	public float TransitionVolume;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Whether to play the soundtrack from the beginning when switching to this Edition or whether to retain the playback time from the previous Edition.")]
	public bool KeepPlaybackTime;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The duration of the cross-fade when switching to this Edition.")]
	public float FadeLength;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public AudioObject Audio;

	[Token(Token = "0x17000004")]
	public bool IsNull
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0xDCC4A4", Offset = "0xDCC4A4", VA = "0xDCC4A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xDCBDCC", Offset = "0xDCBDCC", VA = "0xDCBDCC")]
	public AudioObject Play()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xDCBDD4", Offset = "0xDCBDD4", VA = "0xDCBDD4")]
	public AudioObject Play(float PlayBackTime)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xDCC03C", Offset = "0xDCC03C", VA = "0xDCC03C")]
	public AudioObject PlayTransition()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xDCC504", Offset = "0xDCC504", VA = "0xDCC504")]
	public static bool operator ==(Edition a, Edition b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xDCC5C8", Offset = "0xDCC5C8", VA = "0xDCC5C8", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xDCC700", Offset = "0xDCC700", VA = "0xDCC700", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xDCC774", Offset = "0xDCC774", VA = "0xDCC774")]
	public static bool operator !=(Edition a, Edition b)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000007")]
public class MusicManager : SoundManager
{
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Track DesiredTrack;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float FadeDuration;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0xDCFA44", Offset = "0xDCFA44", VA = "0xDCFA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xDCFA8C", Offset = "0xDCFA8C", VA = "0xDCFA8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xDCD37C", Offset = "0xDCD37C", VA = "0xDCD37C")]
		[DebuggerHidden]
		public <DelayedPlay>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xDCF958", Offset = "0xDCF958", VA = "0xDCF958", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xDCF95C", Offset = "0xDCF95C", VA = "0xDCF95C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xDCFA4C", Offset = "0xDCFA4C", VA = "0xDCFA4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class <DelayedEndTrack>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xDCFB54", Offset = "0xDCFB54", VA = "0xDCFB54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xDCFB9C", Offset = "0xDCFB9C", VA = "0xDCFB9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xDCD85C", Offset = "0xDCD85C", VA = "0xDCD85C")]
		[DebuggerHidden]
		public <DelayedEndTrack>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xDCFA94", Offset = "0xDCFA94", VA = "0xDCFA94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xDCFA98", Offset = "0xDCFA98", VA = "0xDCFA98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xDCFB5C", Offset = "0xDCFB5C", VA = "0xDCFB5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <DelayedEndAudio>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioObject Audio;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xDCFD7C", Offset = "0xDCFD7C", VA = "0xDCFD7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xDCFDC4", Offset = "0xDCFDC4", VA = "0xDCFDC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xDCD884", Offset = "0xDCD884", VA = "0xDCD884")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xDCFBA4", Offset = "0xDCFBA4", VA = "0xDCFBA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xDCFBA8", Offset = "0xDCFBA8", VA = "0xDCFBA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xDCFD84", Offset = "0xDCFD84", VA = "0xDCFD84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <DelayedSwitchEdition>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Edition DesiredEdition;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float FadeOverride;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xDCFEF0", Offset = "0xDCFEF0", VA = "0xDCFEF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xDCFF38", Offset = "0xDCFF38", VA = "0xDCFF38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xDCE7D8", Offset = "0xDCE7D8", VA = "0xDCE7D8")]
		[DebuggerHidden]
		public <DelayedSwitchEdition>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xDCFDF4", Offset = "0xDCFDF4", VA = "0xDCFDF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xDCFDF8", Offset = "0xDCFDF8", VA = "0xDCFDF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xDCFEF8", Offset = "0xDCFEF8", VA = "0xDCFEF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class <DelayedSwitchEdition>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> DelayDelegate;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Edition DesiredEdition;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float FadeOverride;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xDD0064", Offset = "0xDD0064", VA = "0xDD0064", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xDD00AC", Offset = "0xDD00AC", VA = "0xDD00AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xDCF210", Offset = "0xDCF210", VA = "0xDCF210")]
		[DebuggerHidden]
		public <DelayedSwitchEdition>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xDCFF68", Offset = "0xDCFF68", VA = "0xDCFF68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xDCFF6C", Offset = "0xDCFF6C", VA = "0xDCFF6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xDD006C", Offset = "0xDD006C", VA = "0xDD006C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class <FadeDownAudio>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioObject Audio;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Target;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float FadeDuration;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MusicManager <>4__this;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <Rate>5__2;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xDD0200", Offset = "0xDD0200", VA = "0xDD0200", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xDD0248", Offset = "0xDD0248", VA = "0xDD0248", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xDCF3F0", Offset = "0xDCF3F0", VA = "0xDCF3F0")]
		[DebuggerHidden]
		public <FadeDownAudio>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xDD00B4", Offset = "0xDD00B4", VA = "0xDD00B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xDD00B8", Offset = "0xDD00B8", VA = "0xDD00B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xDD0208", Offset = "0xDD0208", VA = "0xDD0208", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class <FadeUpAudio>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Target;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioObject Audio;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xDD0380", Offset = "0xDD0380", VA = "0xDD0380", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xDD03C8", Offset = "0xDD03C8", VA = "0xDD03C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xDCF418", Offset = "0xDCF418", VA = "0xDCF418")]
		[DebuggerHidden]
		public <FadeUpAudio>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xDD0250", Offset = "0xDD0250", VA = "0xDD0250", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xDD0254", Offset = "0xDD0254", VA = "0xDD0254", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xDD0388", Offset = "0xDD0388", VA = "0xDD0388", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[CompilerGenerated]
	private sealed class <VolumeFade>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Volume;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xDD0548", Offset = "0xDD0548", VA = "0xDD0548", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xDD0590", Offset = "0xDD0590", VA = "0xDD0590", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xDCF4CC", Offset = "0xDCF4CC", VA = "0xDCF4CC")]
		[DebuggerHidden]
		public <VolumeFade>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xDD03D0", Offset = "0xDD03D0", VA = "0xDD03D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xDD03D4", Offset = "0xDD03D4", VA = "0xDD03D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xDD0550", Offset = "0xDD0550", VA = "0xDD0550", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Library of Tracks stored on the MusicManager so that Tracks can be started by name without needing a reference to the Track.")]
	public Track[] TrackLibrary;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static MusicManager Main;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Action<Track> OnTrackChangeCallback;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action<Track, bool> OnTrackStopCallback;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Track TargetTrack;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine DelayJob;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Coroutine EndJob;

	[Token(Token = "0x17000005")]
	public override AudioObject.SoundType ManagerType
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDCC7CC", Offset = "0xDCC7CC", VA = "0xDCC7CC", Slot = "4")]
		get
		{
			return default(AudioObject.SoundType);
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xDCC7D4", Offset = "0xDCC7D4", VA = "0xDCC7D4", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xDCC9DC", Offset = "0xDCC9DC", VA = "0xDCC9DC")]
	private Track FindTrackInLibrary(string TrackName)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xDCCB90", Offset = "0xDCCB90", VA = "0xDCCB90")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xDCCC38", Offset = "0xDCCC38", VA = "0xDCCC38")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName, float Delay, bool IsOneShot = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xDCCDA0", Offset = "0xDCCDA0", VA = "0xDCCDA0")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName, float Delay, float FadeDuration, bool IsOneShot = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xDCCE54", Offset = "0xDCCE54", VA = "0xDCCE54")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xDCCEB4", Offset = "0xDCCEB4", VA = "0xDCCEB4")]
	public bool IsPlaying(Track DesiredTrack)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xDCCF20", Offset = "0xDCCF20", VA = "0xDCCF20")]
	public bool IsPlaying(string TrackName)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xDCCC2C", Offset = "0xDCCC2C", VA = "0xDCCC2C")]
	[BindableMethod]
	public void Play(Track DesiredTrack)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xDCCCE4", Offset = "0xDCCCE4", VA = "0xDCCCE4")]
	[BindableMethod]
	public void Play(Track DesiredTrack, float Delay, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xDCB834", Offset = "0xDCB834", VA = "0xDCB834")]
	[BindableMethod]
	public void Play(Track DesiredTrack, float Delay, float FadeDuration, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xDCD048", Offset = "0xDCD048", VA = "0xDCD048")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__20))]
	private IEnumerator DelayedPlay(Track DesiredTrack, float Delay, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xDCD3A4", Offset = "0xDCD3A4", VA = "0xDCD3A4")]
	[BindableMethod]
	public void Stop()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xDCD3BC", Offset = "0xDCD3BC", VA = "0xDCD3BC")]
	[BindableMethod]
	public void Stop(Track AudioTrack)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xDCD0F0", Offset = "0xDCD0F0", VA = "0xDCD0F0")]
	[BindableMethod]
	public void Stop(float FadeDuration)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xDCD3B4", Offset = "0xDCD3B4", VA = "0xDCD3B4")]
	[BindableMethod]
	public void Stop(Track AudioTrack, float FadeDuration)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xDCD3C8", Offset = "0xDCD3C8", VA = "0xDCD3C8")]
	private void Stop(Track AudioTrack, float FadeDuration, bool OneStopEnd)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xDCD650", Offset = "0xDCD650", VA = "0xDCD650")]
	public void SequenceEnd(Track AudioTrack, float RemainingTime)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xDCC484", Offset = "0xDCC484", VA = "0xDCC484")]
	public void SequenceEnd(AudioObject Audio, float RemainingTime)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xDCD738", Offset = "0xDCD738", VA = "0xDCD738")]
	[IteratorStateMachine(typeof(<DelayedEndTrack>d__28))]
	private IEnumerator DelayedEndTrack(float Duration)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xDCD7BC", Offset = "0xDCD7BC", VA = "0xDCD7BC")]
	[IteratorStateMachine(typeof(<DelayedEndAudio>d__29))]
	private IEnumerator DelayedEndAudio(AudioObject Audio, float Duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xDCD8AC", Offset = "0xDCD8AC", VA = "0xDCD8AC")]
	[BindableMethod]
	public void Restart()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xDCD994", Offset = "0xDCD994", VA = "0xDCD994")]
	[BindableMethod]
	public void Restart(Track AudioTrack)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xDCD99C", Offset = "0xDCD99C", VA = "0xDCD99C")]
	[BindableMethod]
	public void Restart(float FadeDuration)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xDCD8B8", Offset = "0xDCD8B8", VA = "0xDCD8B8")]
	[BindableMethod]
	public void Restart(Track AudioTrack, float FadeDuration)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xDCBECC", Offset = "0xDCBECC", VA = "0xDCBECC")]
	public AudioObject StartAudio(AudioClip Audio)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xDCCFC0", Offset = "0xDCCFC0", VA = "0xDCCFC0")]
	private void StopTrackDelay()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xDCD004", Offset = "0xDCD004", VA = "0xDCD004")]
	private void StopTrackEnd()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xDCD9A4", Offset = "0xDCD9A4", VA = "0xDCD9A4")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex, float Delay)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xDCDBB4", Offset = "0xDCDBB4", VA = "0xDCDBB4")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xDCDBBC", Offset = "0xDCDBBC", VA = "0xDCDBBC")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xDCDEE4", Offset = "0xDCDEE4", VA = "0xDCDEE4")]
	[BindableMethod]
	public void SwitchEdition(string EditionName, float Delay = 0f)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xDCE120", Offset = "0xDCE120", VA = "0xDCE120")]
	[BindableMethod]
	public void SwitchEdition(string EditionName, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xDCE358", Offset = "0xDCE358", VA = "0xDCE358")]
	public void SwitchEdition(Edition DesiredEdition)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xDCDB7C", Offset = "0xDCDB7C", VA = "0xDCDB7C")]
	public void SwitchEdition(Edition DesiredEdition, float Delay)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xDCDD8C", Offset = "0xDCDD8C", VA = "0xDCDD8C")]
	public void SwitchEdition(Edition DesiredEdition, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xDCE410", Offset = "0xDCE410", VA = "0xDCE410")]
	[IteratorStateMachine(typeof(<DelayedSwitchEdition>d__45))]
	private IEnumerator DelayedSwitchEdition(Edition DesiredEdition, float Delay, float FadeOverride)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xDCE800", Offset = "0xDCE800", VA = "0xDCE800")]
	public void SwitchEdition(int EditionIndex, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xDCEA08", Offset = "0xDCEA08", VA = "0xDCEA08")]
	public void SwitchEdition(int EditionIndex, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xDCECDC", Offset = "0xDCECDC", VA = "0xDCECDC")]
	public void SwitchEdition(string EditionName, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDCEF10", Offset = "0xDCEF10", VA = "0xDCEF10")]
	public void SwitchEdition(string EditionName, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDCE9D0", Offset = "0xDCE9D0", VA = "0xDCE9D0")]
	public void SwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDCEBD8", Offset = "0xDCEBD8", VA = "0xDCEBD8")]
	public void SwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDCF148", Offset = "0xDCF148", VA = "0xDCF148")]
	[IteratorStateMachine(typeof(<DelayedSwitchEdition>d__52))]
	private IEnumerator DelayedSwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate, float FadeOverride)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xDCBF90", Offset = "0xDCBF90", VA = "0xDCBF90")]
	public void FadeAudio(AudioObject Audio, float FadeDuration, float Target)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xDCF34C", Offset = "0xDCF34C", VA = "0xDCF34C")]
	[IteratorStateMachine(typeof(<FadeDownAudio>d__54))]
	private IEnumerator FadeDownAudio(AudioObject Audio, float FadeDuration, float Target)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xDCF2C0", Offset = "0xDCF2C0", VA = "0xDCF2C0")]
	[IteratorStateMachine(typeof(<FadeUpAudio>d__55))]
	private IEnumerator FadeUpAudio(AudioObject Audio, float FadeDuration, float Target)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xDCF440", Offset = "0xDCF440", VA = "0xDCF440", Slot = "6")]
	[IteratorStateMachine(typeof(<VolumeFade>d__56))]
	protected override IEnumerator VolumeFade(float Volume, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xDCF4F4", Offset = "0xDCF4F4", VA = "0xDCF4F4")]
	public MusicManager()
	{
	}
}
[Token(Token = "0x2000015")]
[CreateAssetMenu(fileName = "Playlist", menuName = "AudioManager/Playlist", order = 2)]
public class Playlist : ScriptableObject
{
	[Token(Token = "0x2000016")]
	public enum ShuffleMode
	{
		[Token(Token = "0x4000054")]
		None,
		[Token(Token = "0x4000055")]
		Random,
		[Token(Token = "0x4000056")]
		RandomUnique
	}

	[Token(Token = "0x2000017")]
	public enum CrossfadeMode
	{
		[Token(Token = "0x4000058")]
		ForcedOn,
		[Token(Token = "0x4000059")]
		ForcedOff,
		[Token(Token = "0x400005A")]
		TrackDefined
	}

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("(Optional) The name of the Playlist.")]
	public string PlaylistName;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("The shuffling mode used for this Playlist.")]
	public ShuffleMode Shuffle;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("The crossfading mode for this Playlist.")]
	public CrossfadeMode Crossfade;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The duration of the crossfade between different Tracks (if Crossfade = ForcedOn).")]
	public float CrossfadeDuration;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The duration of the gap between subsequent tracks.")]
	public float TrackGapDuration;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The Tracks to play in this Playlist.")]
	public Track[] Tracks;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int TrackID;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int NextTrackID;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Track> TracksToPlay;

	[Token(Token = "0x17000016")]
	public bool IsPlaying
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xDD0598", Offset = "0xDD0598", VA = "0xDD0598")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xDD05A0", Offset = "0xDD05A0", VA = "0xDD05A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Track CurrentTrack
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xDD05AC", Offset = "0xDD05AC", VA = "0xDD05AC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xDD05B4", Offset = "0xDD05B4", VA = "0xDD05B4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Track LastTrack
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xDD05BC", Offset = "0xDD05BC", VA = "0xDD05BC")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xDD05C4", Offset = "0xDD05C4", VA = "0xDD05C4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xDD05CC", Offset = "0xDD05CC", VA = "0xDD05CC", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xDD0610", Offset = "0xDD0610", VA = "0xDD0610")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDD0678", Offset = "0xDD0678", VA = "0xDD0678")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xDD0644", Offset = "0xDD0644", VA = "0xDD0644")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDD06AC", Offset = "0xDD06AC", VA = "0xDD06AC")]
	public void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDD09B4", Offset = "0xDD09B4", VA = "0xDD09B4")]
	public void Stop()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xDD09E8", Offset = "0xDD09E8", VA = "0xDD09E8")]
	public float CalculateWaitTime()
	{
		return default(float);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xDD0B34", Offset = "0xDD0B34", VA = "0xDD0B34")]
	public void PlayNext()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xDD083C", Offset = "0xDD083C", VA = "0xDD083C")]
	private void SelectNext()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xDD0C54", Offset = "0xDD0C54", VA = "0xDD0C54")]
	public Playlist()
	{
	}
}
[Token(Token = "0x2000018")]
public class PlaylistManager : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlaylistManager <>4__this;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Playlist DesiredPlaylist;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xDD179C", Offset = "0xDD179C", VA = "0xDD179C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xDD17E4", Offset = "0xDD17E4", VA = "0xDD17E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xDD12E4", Offset = "0xDD12E4", VA = "0xDD12E4")]
		[DebuggerHidden]
		public <DelayedPlay>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xDD16E0", Offset = "0xDD16E0", VA = "0xDD16E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xDD16E4", Offset = "0xDD16E4", VA = "0xDD16E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xDD17A4", Offset = "0xDD17A4", VA = "0xDD17A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <PlayPlaylist>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlaylistManager <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xDD199C", Offset = "0xDD199C", VA = "0xDD199C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xDD19E4", Offset = "0xDD19E4", VA = "0xDD19E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xDD13FC", Offset = "0xDD13FC", VA = "0xDD13FC")]
		[DebuggerHidden]
		public <PlayPlaylist>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xDD17EC", Offset = "0xDD17EC", VA = "0xDD17EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xDD17F0", Offset = "0xDD17F0", VA = "0xDD17F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xDD19A4", Offset = "0xDD19A4", VA = "0xDD19A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Marks the GameObject as DontDestroyOnLoad to provide the manager with scene persistence (Note: manager must be present on a root GameObject for this functionality to work).")]
	[SerializeField]
	private bool ScenePersistent;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Library of Playlists stored on the PlaylistManager so that Playlist can be started by name without needing a reference to the Playlist.")]
	public Playlist[] PlaylistLibrary;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Playlist TargetPlaylist;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlaylistManager Main;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine TrackScheduler;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine DelayJob;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xDD0CB8", Offset = "0xDD0CB8", VA = "0xDD0CB8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xDD0F70", Offset = "0xDD0F70", VA = "0xDD0F70")]
	private void ValidateIsPlaying(Track CurrentManagerTrack)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xDD104C", Offset = "0xDD104C", VA = "0xDD104C")]
	private void ValidateOneShotEnd(Track CurrentManagerTrack, bool IsOneShot)
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xDD1034", Offset = "0xDD1034", VA = "0xDD1034")]
	private void StopAllJobs()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xDD1148", Offset = "0xDD1148", VA = "0xDD1148")]
	private void StopDelayJob()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xDD118C", Offset = "0xDD118C", VA = "0xDD118C")]
	private void StopTrackScheduler()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xDCBBC0", Offset = "0xDCBBC0", VA = "0xDCBBC0")]
	[BindableMethod]
	public void Play(Playlist DesiredPlaylist, float Delay = 0f)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xDD11D0", Offset = "0xDD11D0", VA = "0xDD11D0")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__13))]
	private IEnumerator DelayedPlay(Playlist DesiredPlaylist, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDD130C", Offset = "0xDD130C", VA = "0xDD130C")]
	[BindableMethod]
	public void Stop()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xDD1270", Offset = "0xDD1270", VA = "0xDD1270")]
	[IteratorStateMachine(typeof(<PlayPlaylist>d__15))]
	private IEnumerator PlayPlaylist()
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xDD1424", Offset = "0xDD1424", VA = "0xDD1424")]
	private Playlist FindPlaylistInLibrary(string PlaylistName)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDD15D8", Offset = "0xDD15D8", VA = "0xDD15D8")]
	[BindableMethod]
	public Playlist PlayFromLibrary(string PlaylistName, float Delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xDD167C", Offset = "0xDD167C", VA = "0xDD167C")]
	public PlaylistManager()
	{
	}
}
[Token(Token = "0x200001C")]
[CreateAssetMenu(fileName = "SFXGroup", menuName = "AudioManager/SFXGroup", order = 4)]
public class SFXGroup : ScriptableObject
{
	[Token(Token = "0x200001D")]
	public enum RandomMode
	{
		[Token(Token = "0x4000070")]
		AllowRepeats,
		[Token(Token = "0x4000071")]
		DisallowRepeats,
		[Token(Token = "0x4000072")]
		FullyUnique
	}

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("(Optional) The name of this SFXGroup.")]
	public string GroupName;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("The various different SFXObjects that belong to this SFXGroup.")]
	public SFXObject[] SFXObjects;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Randomization method to use for this SFXGroup.")]
	public RandomMode Randomization;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int LastID;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<SFXObject> SFXObjectsToPlay;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDD1A10", Offset = "0xDD1A10", VA = "0xDD1A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDD1A54", Offset = "0xDD1A54", VA = "0xDD1A54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDD1B08", Offset = "0xDD1B08", VA = "0xDD1B08")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDD1A58", Offset = "0xDD1A58", VA = "0xDD1A58")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDD1B0C", Offset = "0xDD1B0C", VA = "0xDD1B0C")]
	public Coroutine Play()
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDD1D1C", Offset = "0xDD1D1C", VA = "0xDD1D1C")]
	public Coroutine Play(float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDD1DC8", Offset = "0xDD1DC8", VA = "0xDD1DC8")]
	public Coroutine Play(float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDD1E7C", Offset = "0xDD1E7C", VA = "0xDD1E7C")]
	public Coroutine Play(float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xDD1F40", Offset = "0xDD1F40", VA = "0xDD1F40")]
	public Coroutine Play(Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDD2074", Offset = "0xDD2074", VA = "0xDD2074")]
	public Coroutine Play(Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDD2164", Offset = "0xDD2164", VA = "0xDD2164")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDD2264", Offset = "0xDD2264", VA = "0xDD2264")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDD1B98", Offset = "0xDD1B98", VA = "0xDD1B98")]
	private void SelectNext()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDD236C", Offset = "0xDD236C", VA = "0xDD236C")]
	public SFXGroup()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public struct SFXLayer
{
	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[Tooltip("The name of this SFXLayer.")]
	public string LayerName;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[Tooltip("The audio to be played in this SFXLayer.")]
	public AudioClip SFX;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip("If the volume of the sound should be randomised.")]
	public bool RandomizeVolume;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Tooltip("The volume of the SFXLayer.")]
	public float FixedVolume;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("The minimum volume of the SFXLayer.")]
	public float MinVolume;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("The maximum volume of the SFXLayer.")]
	public float MaxVolume;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the pitch of the sound should be randomised.")]
	public bool RandomizePitch;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("The pitch of the SFXLayer.")]
	public float FixedPitch;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The minimum pitch of the SFXLayer.")]
	public float MinPitch;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The maximum pitch of the SFXLayer.")]
	public float MaxPitch;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("If there should be a delay before playing this SFXLayer.")]
	public bool DelaySFX;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[Tooltip("If the delay time should be randomized.")]
	public bool RandomizeDelay;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Duration of the delay.")]
	public float FixedDelayTime;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Minimum duration of the delay.")]
	public float MinDelayTime;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("Maximum duration of the delay.")]
	public float MaxDelayTime;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("Mutes the sound.")]
	public bool Mute;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[Tooltip("Bypass any applied effects on the SFXLayer.")]
	public bool BypassEffects;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[Tooltip("Bypass any reverb zones.")]
	public bool BypassReverbZones;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The priority of the SFXLayer.")]
	public int Priority;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("Pans a playing sound in a stereo way (left or right). This only applies to sounds that are Mono or Stereo.")]
	public float StereoPan;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("Sets how much this SFXLayer is affected by 3D spatialisation calculations. 0.0 makes the sound full 2D, 1.0 makes it full 3D.")]
	public float SpatialBlend;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("The amount by which the signal from the AudioSource will be mixed into the global reverb associated with the Reverb Zones.")]
	public float ReverbZoneMix;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioMixerGroup MixerOverride;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float MinDistance;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float MaxDistance;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioRolloffMode RolloffMode;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDD23D0", Offset = "0xDD23D0", VA = "0xDD23D0")]
	public float GetDelayDuration()
	{
		return default(float);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDD23FC", Offset = "0xDD23FC", VA = "0xDD23FC")]
	public float GetVolume(float VolumeMultiplier = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDD2434", Offset = "0xDD2434", VA = "0xDD2434")]
	public float GetPitch(float PitchMultiplier = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDD2480", Offset = "0xDD2480", VA = "0xDD2480")]
	public Coroutine Play(float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDD2850", Offset = "0xDD2850", VA = "0xDD2850")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDD2744", Offset = "0xDD2744", VA = "0xDD2744")]
	private AudioObject PlaySFXAudio(float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xDD29EC", Offset = "0xDD29EC", VA = "0xDD29EC")]
	private void CopySFXSettings(AudioObject TargetAudio)
	{
	}
}
[Token(Token = "0x200001F")]
public class SFXLoopManager : MonoBehaviour
{
	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <FadeAndStop>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AMPAudioSource source;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeDuration;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXLoopManager <>4__this;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <rate>5__2;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xDD3B94", Offset = "0xDD3B94", VA = "0xDD3B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xDD3BDC", Offset = "0xDD3BDC", VA = "0xDD3BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xDD3694", Offset = "0xDD3694", VA = "0xDD3694")]
		[DebuggerHidden]
		public <FadeAndStop>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xDD3A60", Offset = "0xDD3A60", VA = "0xDD3A60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xDD3A64", Offset = "0xDD3A64", VA = "0xDD3A64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xDD3B9C", Offset = "0xDD3B9C", VA = "0xDD3B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Marks the GameObject as DontDestroyOnLoad to provide the manager with scene persistence (Note: manager must be present on a root GameObject for this functionality to work).")]
	[SerializeField]
	private bool ScenePersistent;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<AMPAudioSource> _pooledSources;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AMPAudioSource> _activeSources;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Coroutine> _sequencedEvents;

	[Token(Token = "0x1700001D")]
	public Transform Parent
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xDD2D8C", Offset = "0xDD2D8C", VA = "0xDD2D8C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xDD2D94", Offset = "0xDD2D94", VA = "0xDD2D94")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public static SFXLoopManager Main
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xDD2D9C", Offset = "0xDD2D9C", VA = "0xDD2D9C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xDD2DE4", Offset = "0xDD2DE4", VA = "0xDD2DE4")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xDD2E3C", Offset = "0xDD2E3C", VA = "0xDD2E3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xDD2F6C", Offset = "0xDD2F6C", VA = "0xDD2F6C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xDD3060", Offset = "0xDD3060", VA = "0xDD3060")]
	private AMPAudioSource GetSource()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xDD3208", Offset = "0xDD3208", VA = "0xDD3208")]
	private void RemoveSource(AMPAudioSource source)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xDD3330", Offset = "0xDD3330", VA = "0xDD3330")]
	public AMPAudioSource Play(ClipGroup clipGroup, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xDCB73C", Offset = "0xDCB73C", VA = "0xDCB73C")]
	public AMPAudioSource Play(AudioClip clip, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xDD3394", Offset = "0xDD3394", VA = "0xDD3394")]
	public void Stop(AMPAudioSource source)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xDD341C", Offset = "0xDD341C", VA = "0xDD341C")]
	public void Stop(AMPAudioSource source, float fadeDuration)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xDD35F4", Offset = "0xDD35F4", VA = "0xDD35F4")]
	[IteratorStateMachine(typeof(<FadeAndStop>d__20))]
	private IEnumerator FadeAndStop(AMPAudioSource source, float fadeDuration)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xDD36BC", Offset = "0xDD36BC", VA = "0xDD36BC")]
	public void StopAll()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xDD38D4", Offset = "0xDD38D4", VA = "0xDD38D4")]
	public SFXLoopManager()
	{
	}
}
[Token(Token = "0x2000022")]
public class SFXManager : SoundManager
{
	[Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXObject SFX;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Volume;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Pitch;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xDD683C", Offset = "0xDD683C", VA = "0xDD683C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0xDD6884", Offset = "0xDD6884", VA = "0xDD6884", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xDD5D58", Offset = "0xDD5D58", VA = "0xDD5D58")]
		[DebuggerHidden]
		public <DelayedPlay>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xDD673C", Offset = "0xDD673C", VA = "0xDD673C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xDD6740", Offset = "0xDD6740", VA = "0xDD6740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xDD6844", Offset = "0xDD6844", VA = "0xDD6844", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXObject SFX;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 Position;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Volume;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Pitch;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform Parent;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool IsGlobalPosition;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xDD696C", Offset = "0xDD696C", VA = "0xDD696C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0xDD69B4", Offset = "0xDD69B4", VA = "0xDD69B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xDD5D80", Offset = "0xDD5D80", VA = "0xDD5D80")]
		[DebuggerHidden]
		public <DelayedPlay>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xDD688C", Offset = "0xDD688C", VA = "0xDD688C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xDD6890", Offset = "0xDD6890", VA = "0xDD6890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xDD6974", Offset = "0xDD6974", VA = "0xDD6974", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXLayer SFX;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 Position;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float SFXVolume;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float SFXPitch;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Transform Parent;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool IsGlobalPosition;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xDD6A88", Offset = "0xDD6A88", VA = "0xDD6A88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xDD6AD0", Offset = "0xDD6AD0", VA = "0xDD6AD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xDD5DA8", Offset = "0xDD5DA8", VA = "0xDD5DA8")]
		[DebuggerHidden]
		public <DelayedPlay>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xDD69BC", Offset = "0xDD69BC", VA = "0xDD69BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xDD69C0", Offset = "0xDD69C0", VA = "0xDD69C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xDD6A90", Offset = "0xDD6A90", VA = "0xDD6A90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <DelayedPlay>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXLayer SFX;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float SFXVolume;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float SFXPitch;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0xDD6B94", Offset = "0xDD6B94", VA = "0xDD6B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0xDD6BDC", Offset = "0xDD6BDC", VA = "0xDD6BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xDD5DD0", Offset = "0xDD5DD0", VA = "0xDD5DD0")]
		[DebuggerHidden]
		public <DelayedPlay>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xDD6AD8", Offset = "0xDD6AD8", VA = "0xDD6AD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xDD6ADC", Offset = "0xDD6ADC", VA = "0xDD6ADC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xDD6B9C", Offset = "0xDD6B9C", VA = "0xDD6B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <DelayedEndAudio>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioObject Audio;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0xDD6CB0", Offset = "0xDD6CB0", VA = "0xDD6CB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0xDD6CF8", Offset = "0xDD6CF8", VA = "0xDD6CF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xDD6360", Offset = "0xDD6360", VA = "0xDD6360")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xDD6BE4", Offset = "0xDD6BE4", VA = "0xDD6BE4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xDD6BE8", Offset = "0xDD6BE8", VA = "0xDD6BE8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xDD6CB8", Offset = "0xDD6CB8", VA = "0xDD6CB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioObject Audio;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xDD6D00", Offset = "0xDD6D00", VA = "0xDD6D00")]
		public <>c__DisplayClass57_0()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xDD6D08", Offset = "0xDD6D08", VA = "0xDD6D08")]
		internal bool <DelayedEndAudio>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class <DelayedEndAudio>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioObject Audio;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass57_0 <>8__1;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xDD6F18", Offset = "0xDD6F18", VA = "0xDD6F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xDD6F60", Offset = "0xDD6F60", VA = "0xDD6F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xDD6388", Offset = "0xDD6388", VA = "0xDD6388")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xDD6DA0", Offset = "0xDD6DA0", VA = "0xDD6DA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xDD6DA4", Offset = "0xDD6DA4", VA = "0xDD6DA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xDD6F20", Offset = "0xDD6F20", VA = "0xDD6F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <VolumeFade>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Volume;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xDD7094", Offset = "0xDD7094", VA = "0xDD7094", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xDD70DC", Offset = "0xDD70DC", VA = "0xDD70DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xDD643C", Offset = "0xDD643C", VA = "0xDD643C")]
		[DebuggerHidden]
		public <VolumeFade>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xDD6F68", Offset = "0xDD6F68", VA = "0xDD6F68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xDD6F6C", Offset = "0xDD6F6C", VA = "0xDD6F6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xDD709C", Offset = "0xDD709C", VA = "0xDD709C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Library of SFXObjects stored on the SFXManager so that SFXObjects can be started by name without needing a reference to the SFXObject.")]
	public SFXObject[] SFXObjectLibrary;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Library of SFXGroups stored on the SFXManager so that SFXGroups can be started by name without needing a reference to the SFXGroup.")]
	public SFXGroup[] SFXGroupLibrary;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static SFXManager Main;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action OnStopAll;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Coroutine> SequencedStartJobs;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<Coroutine> SequencedEndJobs;

	[Token(Token = "0x17000021")]
	public override AudioObject.SoundType ManagerType
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xDD3BE4", Offset = "0xDD3BE4", VA = "0xDD3BE4", Slot = "4")]
		get
		{
			return default(AudioObject.SoundType);
		}
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xDD3BEC", Offset = "0xDD3BEC", VA = "0xDD3BEC", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xDD3D00", Offset = "0xDD3D00", VA = "0xDD3D00")]
	[BindableMethod]
	private SFXObject FindSFXObjectInLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xDD3EB4", Offset = "0xDD3EB4", VA = "0xDD3EB4")]
	[BindableMethod]
	private SFXGroup FindSFXGroupInLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xDD4068", Offset = "0xDD4068", VA = "0xDD4068")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xDD4108", Offset = "0xDD4108", VA = "0xDD4108")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xDD41C0", Offset = "0xDD41C0", VA = "0xDD41C0")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xDD4280", Offset = "0xDD4280", VA = "0xDD4280")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xDD4354", Offset = "0xDD4354", VA = "0xDD4354")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xDD4440", Offset = "0xDD4440", VA = "0xDD4440")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xDD4538", Offset = "0xDD4538", VA = "0xDD4538")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xDD4644", Offset = "0xDD4644", VA = "0xDD4644")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xDD4758", Offset = "0xDD4758", VA = "0xDD4758")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xDD47FC", Offset = "0xDD47FC", VA = "0xDD47FC")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xDD48C8", Offset = "0xDD48C8", VA = "0xDD48C8")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xDD4988", Offset = "0xDD4988", VA = "0xDD4988")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xDD4A70", Offset = "0xDD4A70", VA = "0xDD4A70")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xDD4B80", Offset = "0xDD4B80", VA = "0xDD4B80")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xDD4C98", Offset = "0xDD4C98", VA = "0xDD4C98")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xDD4DC4", Offset = "0xDD4DC4", VA = "0xDD4DC4")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xDCBCB4", Offset = "0xDCBCB4", VA = "0xDCBCB4")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xDD1DB4", Offset = "0xDD1DB4", VA = "0xDD1DB4")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xDD1E68", Offset = "0xDD1E68", VA = "0xDD1E68")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xDD1F2C", Offset = "0xDD1F2C", VA = "0xDD1F2C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xDD200C", Offset = "0xDD200C", VA = "0xDD200C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xDD2144", Offset = "0xDD2144", VA = "0xDD2144")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xDD2244", Offset = "0xDD2244", VA = "0xDD2244")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xDD234C", Offset = "0xDD234C", VA = "0xDD234C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xDD53F4", Offset = "0xDD53F4", VA = "0xDD53F4")]
	public Coroutine PlaySuspended(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xDD5688", Offset = "0xDD5688", VA = "0xDD5688")]
	public Coroutine PlaySuspended(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xDD2550", Offset = "0xDD2550", VA = "0xDD2550")]
	public Coroutine PlaySuspended(SFXLayer SFX, float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xDD5A40", Offset = "0xDD5A40", VA = "0xDD5A40")]
	public Coroutine PlaySuspended(SFXLayer SFX, Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xDD55D4", Offset = "0xDD55D4", VA = "0xDD55D4")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__39))]
	private IEnumerator DelayedPlay(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xDD58A0", Offset = "0xDD58A0", VA = "0xDD58A0")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__40))]
	private IEnumerator DelayedPlay(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xDD5C6C", Offset = "0xDD5C6C", VA = "0xDD5C6C")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__41))]
	private IEnumerator DelayedPlay(SFXLayer SFX, Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xDD5998", Offset = "0xDD5998", VA = "0xDD5998")]
	[IteratorStateMachine(typeof(<DelayedPlay>d__42))]
	private IEnumerator DelayedPlay(SFXLayer SFX, float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xDCBD34", Offset = "0xDCBD34", VA = "0xDCBD34")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xDD48B4", Offset = "0xDD48B4", VA = "0xDD48B4")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xDCBDB0", Offset = "0xDCBDB0", VA = "0xDCBDB0")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xDD4A5C", Offset = "0xDD4A5C", VA = "0xDD4A5C")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xDD4B60", Offset = "0xDD4B60", VA = "0xDD4B60")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xDD4C78", Offset = "0xDD4C78", VA = "0xDD4C78")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xDD4DA4", Offset = "0xDD4DA4", VA = "0xDD4DA4")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xDD4ED8", Offset = "0xDD4ED8", VA = "0xDD4ED8")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xDD5DF8", Offset = "0xDD5DF8", VA = "0xDD5DF8")]
	private void EndAllStartJobs()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xDD5ED8", Offset = "0xDD5ED8", VA = "0xDD5ED8")]
	private void EndAllEndJobs()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xDD5FB8", Offset = "0xDD5FB8", VA = "0xDD5FB8")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xDD6068", Offset = "0xDD6068", VA = "0xDD6068")]
	public void SequenceEnd(AudioObject Audio, float RemainingTime)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xDD2BD8", Offset = "0xDD2BD8", VA = "0xDD2BD8")]
	public void SequenceEnd(AudioObject Audio)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xDD6230", Offset = "0xDD6230", VA = "0xDD6230")]
	[IteratorStateMachine(typeof(<DelayedEndAudio>d__56))]
	private IEnumerator DelayedEndAudio(AudioObject Audio, float Duration)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xDD62D0", Offset = "0xDD62D0", VA = "0xDD62D0")]
	[IteratorStateMachine(typeof(<DelayedEndAudio>d__57))]
	private IEnumerator DelayedEndAudio(AudioObject Audio)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xDD63B0", Offset = "0xDD63B0", VA = "0xDD63B0", Slot = "6")]
	[IteratorStateMachine(typeof(<VolumeFade>d__58))]
	protected override IEnumerator VolumeFade(float Volume, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xDD6464", Offset = "0xDD6464", VA = "0xDD6464")]
	public SFXManager()
	{
	}
}
[Token(Token = "0x200002E")]
[CreateAssetMenu(fileName = "SFX", menuName = "AudioManager/SFXObject", order = 3)]
public class SFXObject : ScriptableObject
{
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("(Optional) The name of this SFXObject.")]
	public string SFXName;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("The different SFXLayers in this SFXObject.")]
	public SFXLayer[] SFXLayers;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("If the volume of the sound should be randomized.")]
	public bool RandomizeVolume;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The volume multiplier of the SFXObject.")]
	public float FixedVolume;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The minimum volume multiplier of the SFXObject.")]
	public float MinVolume;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("The maximum volume multiplier of the SFXObject.")]
	public float MaxVolume;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("If the pitch of the sound should be randomized.")]
	public bool RandomizePitch;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Tooltip("The pitch multiplier of the SFXObject.")]
	public float FixedPitch;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The minimum pitch multiplier of the SFXObject.")]
	public float MinPitch;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The maximum pitch multiplier of the SFXObject.")]
	public float MaxPitch;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("If there should be a global delay before playing this SFXObject.")]
	public bool DelaySFX;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[Tooltip("If the delay time should be randomized.")]
	public bool RandomizeDelay;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("Duration of the delay.")]
	public float FixedDelayTime;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("Minimum duration of the delay.")]
	public float MinDelayTime;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Tooltip("Maximum duration of the delay.")]
	public float MaxDelayTime;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("If polyphony limits should be applied. With polyphony limiting, the behaviour of simultaneous and overlapping sounds is controlled.")]
	public bool LimitPolyphony;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[Tooltip("The maximum number of voices for this SFXObject, or how many can be played in tandem. 0 results in infinite voices.")]
	public int MaxVoices;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("The minimum time separation between subsequent plays of this SFXObject; if the duration has not been surpassed, the SFXObject will not be played.")]
	public float MinSeparation;

	[NonSerialized]
	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float LastPlayTimestamp;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xDD70E4", Offset = "0xDD70E4", VA = "0xDD70E4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xDD7128", Offset = "0xDD7128", VA = "0xDD7128")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xDD7130", Offset = "0xDD7130", VA = "0xDD7130")]
	public SFXObject()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xDD4EF8", Offset = "0xDD4EF8", VA = "0xDD4EF8")]
	public float GetDelayDuration()
	{
		return default(float);
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xDD7210", Offset = "0xDD7210", VA = "0xDD7210")]
	public float GetVolumeMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xDD722C", Offset = "0xDD722C", VA = "0xDD722C")]
	public float GetPitchMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xDD4F24", Offset = "0xDD4F24", VA = "0xDD4F24")]
	public Coroutine Play(float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xDD4F94", Offset = "0xDD4F94", VA = "0xDD4F94")]
	public Coroutine Play(float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xDD4FE8", Offset = "0xDD4FE8", VA = "0xDD4FE8")]
	public Coroutine Play(float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xDD5120", Offset = "0xDD5120", VA = "0xDD5120")]
	public Coroutine Play(Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xDD51D0", Offset = "0xDD51D0", VA = "0xDD51D0")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xDD5264", Offset = "0xDD5264", VA = "0xDD5264")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}
}
[Token(Token = "0x200002F")]
[CreateAssetMenu(fileName = "Track", menuName = "AudioManager/Track", order = 1)]
public class Track : ScriptableObject
{
	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("(Optional) The name of the Track.")]
	public string Name;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("(Optional) The intro audio to be played before looping the main Edition.")]
	public AudioClip Intro;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The volume of the intro audio.")]
	public float IntroVolume;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Duration of the overlap between the end of the intro and the start of the first Edition.")]
	public float OverlapDuration;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The various different Editions contained in this track, where the first element is the main Edition that will be auto-played (Required 1+).")]
	public Edition[] Editions;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Coroutine DelayJob;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Edition CurrentEdition;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<AudioObject> ActiveAudio;

	[Token(Token = "0x17000030")]
	public bool IsOneShot
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xDD7260", Offset = "0xDD7260", VA = "0xDD7260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xDD7268", Offset = "0xDD7268", VA = "0xDD7268")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xDD7274", Offset = "0xDD7274", VA = "0xDD7274", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xDD72B8", Offset = "0xDD72B8", VA = "0xDD72B8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xDD72F0", Offset = "0xDD72F0", VA = "0xDD72F0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xDD72D4", Offset = "0xDD72D4", VA = "0xDD72D4")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xDD730C", Offset = "0xDD730C", VA = "0xDD730C")]
	public Track()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xDCE394", Offset = "0xDCE394", VA = "0xDCE394")]
	public void StopDelay()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xDCD0FC", Offset = "0xDCD0FC", VA = "0xDCD0FC")]
	public void PlayTrack(float FadeDuration = 0f, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xDD756C", Offset = "0xDD756C", VA = "0xDD756C")]
	public void SwitchEdition(int EditionIndex)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xDD7400", Offset = "0xDD7400", VA = "0xDD7400")]
	public void SwitchEdition(int EditionIndex, float FadeOverride)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xDD76D8", Offset = "0xDD76D8", VA = "0xDD76D8")]
	public void SwitchEdition(Edition DesiredEdition)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xDCE4CC", Offset = "0xDCE4CC", VA = "0xDCE4CC")]
	public void SwitchEdition(Edition DesiredEdition, float FadeOverride)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xDD7710", Offset = "0xDD7710", VA = "0xDD7710")]
	public void Stop(AudioObject Audio)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xDD779C", Offset = "0xDD779C", VA = "0xDD779C")]
	public void StopTrack()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xDD77A8", Offset = "0xDD77A8", VA = "0xDD77A8")]
	public void StopTrack(float FadeDuration)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xDD77B0", Offset = "0xDD77B0", VA = "0xDD77B0")]
	public void StopTrack(bool FadeDuration)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xDCD520", Offset = "0xDCD520", VA = "0xDCD520")]
	public void StopTrack(bool Fade, float FadeDuration)
	{
	}
}
namespace AMPInternal
{
	[Token(Token = "0x2000031")]
	public class AudioObject
	{
		[Token(Token = "0x2000032")]
		public enum SoundType
		{
			[Token(Token = "0x4000102")]
			Music,
			[Token(Token = "0x4000103")]
			SFX
		}

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource Source;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Coroutine FadeJob;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly SoundType AudioType;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _AudioVolume;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _SourceVolume;

		[Token(Token = "0x17000031")]
		public float length
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xDCC45C", Offset = "0xDCC45C", VA = "0xDCC45C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000032")]
		public float volume
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0xDD7828", Offset = "0xDD7828", VA = "0xDD7828")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xDCBEE8", Offset = "0xDCBEE8", VA = "0xDCBEE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public float SourceVolume
		{
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xDD7830", Offset = "0xDD7830", VA = "0xDD7830")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600018A")]
			[Address(RVA = "0xDCBED8", Offset = "0xDCBED8", VA = "0xDCBED8")]
			set
			{
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xDD77F8", Offset = "0xDD77F8", VA = "0xDD77F8")]
		public AudioObject(SoundType AudioType)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xDD7838", Offset = "0xDD7838", VA = "0xDD7838")]
		public void Pause()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xDD7854", Offset = "0xDD7854", VA = "0xDD7854")]
		public void UnPause()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xDD2B84", Offset = "0xDD2B84", VA = "0xDD2B84")]
		public void Play()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xDD7870", Offset = "0xDD7870", VA = "0xDD7870")]
		public void Stop()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xDCF238", Offset = "0xDCF238", VA = "0xDCF238")]
		public void StopFade()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public abstract class SoundManager : MonoBehaviour
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("(Optional) Audio mixer to set as the output of all audio handled by the SoundManager.")]
		public AudioMixerGroup Mixer;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("Marks the GameObject as DontDestroyOnLoad to provide the manager with scene persistence (Note: manager must be present on a root GameObject for this functionality to work).")]
		private bool ScenePersistent;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _Paused;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _Muted;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float Volume;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action OnStateChange;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<float> OnVolumeChange;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action OnPause;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action OnUnPause;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<bool> OnMuteChange;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<AudioObject> ActiveAudio;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected List<AudioObject> InactiveAudio;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Coroutine FadeJob;

		[Token(Token = "0x17000034")]
		public abstract AudioObject.SoundType ManagerType
		{
			[Token(Token = "0x6000190")]
			get;
		}

		[Token(Token = "0x17000035")]
		public Transform Parent
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xDD7894", Offset = "0xDD7894", VA = "0xDD7894")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xDD789C", Offset = "0xDD789C", VA = "0xDD789C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public bool Paused
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xDD78A4", Offset = "0xDD78A4", VA = "0xDD78A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xDD78AC", Offset = "0xDD78AC", VA = "0xDD78AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool Muted
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0xDD7A6C", Offset = "0xDD7A6C", VA = "0xDD7A6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xDD7A74", Offset = "0xDD7A74", VA = "0xDD7A74")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public float MasterVolume
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xDD7C44", Offset = "0xDD7C44", VA = "0xDD7C44")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xDD04FC", Offset = "0xDD04FC", VA = "0xDD04FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int CurrentAudioSourceCount
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xDD7D20", Offset = "0xDD7D20", VA = "0xDD7D20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xDD7C4C", Offset = "0xDD7C4C", VA = "0xDD7C4C")]
		private void FlushVolumeChange()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xDD7D68", Offset = "0xDD7D68", VA = "0xDD7D68")]
		[BindableMethod]
		public void RemoveInactive()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xDCC8E8", Offset = "0xDCC8E8", VA = "0xDCC8E8", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xDCBA88", Offset = "0xDCBA88", VA = "0xDCBA88")]
		[BindableMethod]
		public void SetVolume(float Volume, float FadeDuration)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xDD7EAC", Offset = "0xDD7EAC", VA = "0xDD7EAC")]
		[BindableMethod]
		public void SetVolume(float Volume)
		{
		}

		[Token(Token = "0x600019F")]
		protected abstract IEnumerator VolumeFade(float Volume, float FadeDuration);

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xDD7E68", Offset = "0xDD7E68", VA = "0xDD7E68")]
		protected void StopVolumeFade()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xDCFC5C", Offset = "0xDCFC5C", VA = "0xDCFC5C")]
		public void StopAudio(AudioObject Audio)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xDD79A0", Offset = "0xDD79A0", VA = "0xDD79A0")]
		[BindableMethod]
		public void Pause()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xDD78D8", Offset = "0xDD78D8", VA = "0xDD78D8")]
		[BindableMethod]
		public void UnPause()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xDD7B70", Offset = "0xDD7B70", VA = "0xDD7B70")]
		[BindableMethod]
		public void Mute()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xDD7AA0", Offset = "0xDD7AA0", VA = "0xDD7AA0")]
		[BindableMethod]
		public void UnMute()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xDCC130", Offset = "0xDCC130", VA = "0xDCC130")]
		public AudioObject StartAudio(AudioClip Audio, bool Looping, bool AutoPlay = true)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xDCF554", Offset = "0xDCF554", VA = "0xDCF554")]
		protected SoundManager()
		{
		}
	}
}
namespace AMPInternal.Coroutines.SFX
{
	[Token(Token = "0x2000035")]
	public sealed class WaitForUnpausedSeconds : CustomYieldInstruction
	{
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float TimeRemaining;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool BypassPause;

		[Token(Token = "0x1700003A")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xDD7F78", Offset = "0xDD7F78", VA = "0xDD7F78", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xDD6804", Offset = "0xDD6804", VA = "0xDD6804")]
		public WaitForUnpausedSeconds(float Duration, bool BypassPause = false)
		{
		}
	}
	[Token(Token = "0x2000036")]
	public sealed class WaitForNextUnpausedFrame : CustomYieldInstruction
	{
		[Token(Token = "0x1700003B")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xDD8008", Offset = "0xDD8008", VA = "0xDD8008", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xDD3B8C", Offset = "0xDD3B8C", VA = "0xDD3B8C")]
		public WaitForNextUnpausedFrame()
		{
		}
	}
}
namespace AMPInternal.Coroutines.Music
{
	[Token(Token = "0x2000037")]
	public sealed class WaitForUnpausedSeconds : CustomYieldInstruction
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float TimeRemaining;

		[Token(Token = "0x1700003C")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xDD805C", Offset = "0xDD805C", VA = "0xDD805C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xDCFA1C", Offset = "0xDCFA1C", VA = "0xDCFA1C")]
		public WaitForUnpausedSeconds(float Duration)
		{
		}
	}
	[Token(Token = "0x2000038")]
	public sealed class WaitForNextUnpausedFrame : CustomYieldInstruction
	{
		[Token(Token = "0x1700003D")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xDD80E4", Offset = "0xDD80E4", VA = "0xDD80E4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xDD01F8", Offset = "0xDD01F8", VA = "0xDD01F8")]
		public WaitForNextUnpausedFrame()
		{
		}
	}
}
namespace AMPInternal.Utilities
{
	[Token(Token = "0x2000039")]
	public static class StringFormatting
	{
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xDD8138", Offset = "0xDD8138", VA = "0xDD8138")]
		public static string FormatTime(float Duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public static class NumberManipulation
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xDD8344", Offset = "0xDD8344", VA = "0xDD8344")]
		public static float DecimalPlaces(float Number, int dp)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200003B")]
	public static class ListExtension
	{
		[Token(Token = "0x60001B9")]
		public static int RandomIndex<T>(this List<T> Arr)
		{
			return default(int);
		}

		[Token(Token = "0x60001BA")]
		public static T RandomElement<T>(this List<T> Arr)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BB")]
		public static T Pop<T>(this List<T> Arr, int Index)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BC")]
		public static T PopRandom<T>(this List<T> Arr)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BD")]
		public static void Randomize<T>(this List<T> Arr)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public static class IEnumerableExtension
	{
		[Token(Token = "0x60001BE")]
		public static IEnumerable<TSource> DistinctBy<TSource, TID>(this IEnumerable<TSource> Arr, Func<TSource, TID> IDSelector)
		{
			return null;
		}
	}
}
namespace AMPInternal.EventBinding
{
	[Serializable]
	[Token(Token = "0x200003E")]
	public class UnityObjectEvent : UnityEvent<object>
	{
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xDD83E8", Offset = "0xDD83E8", VA = "0xDD83E8")]
		public UnityObjectEvent()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class BindableMethod : Attribute
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xDD8430", Offset = "0xDD8430", VA = "0xDD8430")]
		public BindableMethod()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class BindedEvent
	{
		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EventTriggerType EventTrigger;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityObjectEvent EventCallback;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type ManagerType;

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xDD8438", Offset = "0xDD8438", VA = "0xDD8438")]
		public BindedEvent(string Name, EventTriggerType Trigger, UnityObjectEvent Callback, Type ManagerType)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xDCB220", Offset = "0xDCB220", VA = "0xDCB220")]
		public void Execute()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public enum EventTriggerType
	{
		[Token(Token = "0x4000122")]
		None,
		[Token(Token = "0x4000123")]
		Start,
		[Token(Token = "0x4000124")]
		OnEnable,
		[Token(Token = "0x4000125")]
		OnDisable,
		[Token(Token = "0x4000126")]
		OnCollisionEnter,
		[Token(Token = "0x4000127")]
		OnCollisionEnter2D,
		[Token(Token = "0x4000128")]
		OnTriggerEnter,
		[Token(Token = "0x4000129")]
		OnTriggerEnter2D,
		[Token(Token = "0x400012A")]
		OnCollisionExit,
		[Token(Token = "0x400012B")]
		OnCollisionExit2D,
		[Token(Token = "0x400012C")]
		OnTriggerExit,
		[Token(Token = "0x400012D")]
		OnTriggerExit2D,
		[Token(Token = "0x400012E")]
		OnMouseDown,
		[Token(Token = "0x400012F")]
		OnMouseEnter,
		[Token(Token = "0x4000130")]
		OnMouseExit,
		[Token(Token = "0x4000131")]
		OnMouseUp
	}
}
