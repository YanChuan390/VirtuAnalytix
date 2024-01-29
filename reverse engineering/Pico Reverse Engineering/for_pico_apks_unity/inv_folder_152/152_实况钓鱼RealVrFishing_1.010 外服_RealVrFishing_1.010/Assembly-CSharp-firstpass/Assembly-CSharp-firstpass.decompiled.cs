using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using AMPInternal;
using AMPInternal.EventBinding;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xF288E8", Offset = "0xF288E8")]
public class AMPAudioSource : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xF28DB0", Offset = "0xF28DB0")]
	[SerializeField]
	private float _volume;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioSource _source;

	[Token(Token = "0x17000001")]
	public float Volume
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2CE3F88", Offset = "0x2CE3F88", VA = "0x2CE3F88")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2CE3F90", Offset = "0x2CE3F90", VA = "0x2CE3F90")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public AudioClip Clip
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2CE4058", Offset = "0x2CE4058", VA = "0x2CE4058")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2CE4074", Offset = "0x2CE4074", VA = "0x2CE4074")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public bool Loop
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2CE4090", Offset = "0x2CE4090", VA = "0x2CE4090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2CE40AC", Offset = "0x2CE40AC", VA = "0x2CE40AC")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2CE4030", Offset = "0x2CE4030", VA = "0x2CE4030")]
	private void OnVolumeChange(float masterVolume)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2CE40CC", Offset = "0x2CE40CC", VA = "0x2CE40CC")]
	private void OnPause()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2CE40E8", Offset = "0x2CE40E8", VA = "0x2CE40E8")]
	private void OnUnPause()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2CE4104", Offset = "0x2CE4104", VA = "0x2CE4104")]
	private void OnMuteChange(bool mute)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2CE4124", Offset = "0x2CE4124", VA = "0x2CE4124")]
	private void OnStopAll()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2CE4140", Offset = "0x2CE4140", VA = "0x2CE4140")]
	public void Play()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2CE4198", Offset = "0x2CE4198", VA = "0x2CE4198")]
	public void Stop()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2CE41B4", Offset = "0x2CE41B4", VA = "0x2CE41B4")]
	private void FlushAllCallbacks()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2CE423C", Offset = "0x2CE423C", VA = "0x2CE423C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2CE45CC", Offset = "0x2CE45CC", VA = "0x2CE45CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2CE4314", Offset = "0x2CE4314", VA = "0x2CE4314")]
	private void RegisterAllCallbacks()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2CE45D0", Offset = "0x2CE45D0", VA = "0x2CE45D0")]
	private void DeregisterAllCallbacks()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2CE4888", Offset = "0x2CE4888", VA = "0x2CE4888")]
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
	[Address(RVA = "0x2CE4898", Offset = "0x2CE4898", VA = "0x2CE4898")]
	private void ExecuteEvents(EventTriggerType DesiredEventTrigger)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2CE4CC0", Offset = "0x2CE4CC0", VA = "0x2CE4CC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2CE4CC8", Offset = "0x2CE4CC8", VA = "0x2CE4CC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2CE4CD0", Offset = "0x2CE4CD0", VA = "0x2CE4CD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2CE4CD8", Offset = "0x2CE4CD8", VA = "0x2CE4CD8")]
	private void OnCollisionEnter(Collision Col)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2CE4CE0", Offset = "0x2CE4CE0", VA = "0x2CE4CE0")]
	private void OnCollisionEnter2D(Collision2D Col)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2CE4CE8", Offset = "0x2CE4CE8", VA = "0x2CE4CE8")]
	private void OnTriggerEnter(Collider Col)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2CE4CF0", Offset = "0x2CE4CF0", VA = "0x2CE4CF0")]
	private void OnTriggerEnter2D(Collider2D Col)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2CE4CF8", Offset = "0x2CE4CF8", VA = "0x2CE4CF8")]
	private void OnCollisionExit(Collision Col)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2CE4D00", Offset = "0x2CE4D00", VA = "0x2CE4D00")]
	private void OnCollisionExit2D(Collision2D Col)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2CE4D08", Offset = "0x2CE4D08", VA = "0x2CE4D08")]
	private void OnTriggerExit(Collider Col)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2CE4D10", Offset = "0x2CE4D10", VA = "0x2CE4D10")]
	private void OnTriggerExit2D(Collider2D Col)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2CE4D18", Offset = "0x2CE4D18", VA = "0x2CE4D18")]
	public AMPEventBinder()
	{
	}
}
[Token(Token = "0x2000004")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xF2894C", Offset = "0xF2894C")]
public class ClipGroup : ScriptableObject
{
	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] Clips;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2CE6608", Offset = "0x2CE6608", VA = "0x2CE6608")]
	public ClipGroup()
	{
	}
}
[Token(Token = "0x2000005")]
public class DemoScript : MonoBehaviour
{
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2CE6610", Offset = "0x2CE6610", VA = "0x2CE6610")]
	public void PlayLoop(AudioClip clip)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2CE670C", Offset = "0x2CE670C", VA = "0x2CE670C")]
	public void Play2(Track DesiredTrack)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2CE695C", Offset = "0x2CE695C", VA = "0x2CE695C")]
	public void SetMusicVolume2(float DesiredVolume)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2CE69C8", Offset = "0x2CE69C8", VA = "0x2CE69C8")]
	public void SetSFXVolume2(float DesiredVolume)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x2CE6A34", Offset = "0x2CE6A34", VA = "0x2CE6A34")]
	public void Play(Playlist DesiredPlaylist)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2CE6B44", Offset = "0x2CE6B44", VA = "0x2CE6B44")]
	public void Play(SFXObject DesiredSFX)
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x2CE6BD4", Offset = "0x2CE6BD4", VA = "0x2CE6BD4")]
	public void Play(SFXGroup DesiredSFX)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x2CE6C50", Offset = "0x2CE6C50", VA = "0x2CE6C50")]
	public void PlayExplosions(SFXGroup DesiredSFX)
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x2CE6CD8", Offset = "0x2CE6CD8", VA = "0x2CE6CD8")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28DF0", Offset = "0xF28DF0")]
	public string Name;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28E28", Offset = "0xF28E28")]
	public AudioClip Soundtrack;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28E60", Offset = "0xF28E60")]
	public float SoundtrackVolume;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28E98", Offset = "0xF28E98")]
	public AudioClip TransitionSound;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28ED0", Offset = "0xF28ED0")]
	public float TransitionVolume;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28F08", Offset = "0xF28F08")]
	public bool KeepPlaybackTime;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28F40", Offset = "0xF28F40")]
	public float FadeLength;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public AudioObject Audio;

	[Token(Token = "0x17000004")]
	public bool IsNull
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2CE6FD8", Offset = "0x2CE6FD8", VA = "0x2CE6FD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x2CE6CE0", Offset = "0x2CE6CE0", VA = "0x2CE6CE0")]
	public AudioObject Play()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x2CE6CE8", Offset = "0x2CE6CE8", VA = "0x2CE6CE8")]
	public AudioObject Play(float PlayBackTime)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2CE6EAC", Offset = "0x2CE6EAC", VA = "0x2CE6EAC")]
	public AudioObject PlayTransition()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2CE7048", Offset = "0x2CE7048", VA = "0x2CE7048")]
	public static bool operator ==(Edition a, Edition b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2CE7130", Offset = "0x2CE7130", VA = "0x2CE7130", Slot = "0")]
	public override bool Equals(object o)
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2CE7260", Offset = "0x2CE7260", VA = "0x2CE7260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x2CE72E4", Offset = "0x2CE72E4", VA = "0x2CE72E4")]
	public static bool operator !=(Edition a, Edition b)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000007")]
public class MusicManager : SoundManager
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28BB0", Offset = "0xF28BB0")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string TrackName;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2CE75C0", Offset = "0x2CE75C0", VA = "0x2CE75C0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2CE9DE0", Offset = "0x2CE9DE0", VA = "0x2CE9DE0")]
		internal bool <FindTrackInLibrary>b__0(Track x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28BC0", Offset = "0xF28BC0")]
	private sealed class <DelayedPlay>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Track DesiredTrack;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float FadeDuration;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2CEA194", Offset = "0x2CEA194", VA = "0x2CEA194", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2CEA1FC", Offset = "0x2CEA1FC", VA = "0x2CEA1FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2CE7DC4", Offset = "0x2CE7DC4", VA = "0x2CE7DC4")]
		[DebuggerHidden]
		public <DelayedPlay>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2CEA0C4", Offset = "0x2CEA0C4", VA = "0x2CEA0C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2CEA0C8", Offset = "0x2CEA0C8", VA = "0x2CEA0C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2CEA19C", Offset = "0x2CEA19C", VA = "0x2CEA19C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28BD0", Offset = "0xF28BD0")]
	private sealed class <DelayedEndTrack>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2CEA054", Offset = "0x2CEA054", VA = "0x2CEA054", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2CEA0BC", Offset = "0x2CEA0BC", VA = "0x2CEA0BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2CE82BC", Offset = "0x2CE82BC", VA = "0x2CE82BC")]
		[DebuggerHidden]
		public <DelayedEndTrack>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2CE9F88", Offset = "0x2CE9F88", VA = "0x2CE9F88", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2CE9F8C", Offset = "0x2CE9F8C", VA = "0x2CE9F8C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2CEA05C", Offset = "0x2CEA05C", VA = "0x2CEA05C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28BE0", Offset = "0xF28BE0")]
	private sealed class <DelayedEndAudio>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioObject Audio;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x2CE9F18", Offset = "0x2CE9F18", VA = "0x2CE9F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x2CE9F80", Offset = "0x2CE9F80", VA = "0x2CE9F80", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2CE82E8", Offset = "0x2CE82E8", VA = "0x2CE82E8")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2CE9E54", Offset = "0x2CE9E54", VA = "0x2CE9E54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2CE9E58", Offset = "0x2CE9E58", VA = "0x2CE9E58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2CE9F20", Offset = "0x2CE9F20", VA = "0x2CE9F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28BF0", Offset = "0xF28BF0")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EditionName;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x2CE8B3C", Offset = "0x2CE8B3C", VA = "0x2CE8B3C")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2CE9E04", Offset = "0x2CE9E04", VA = "0x2CE9E04")]
		internal bool <SwitchEdition>b__0(Edition x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C00", Offset = "0xF28C00")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EditionName;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2CE8D3C", Offset = "0x2CE8D3C", VA = "0x2CE8D3C")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2CE9E18", Offset = "0x2CE9E18", VA = "0x2CE9E18")]
		internal bool <SwitchEdition>b__0(Edition x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C10", Offset = "0xF28C10")]
	private sealed class <DelayedSwitchEdition>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Delay;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Edition DesiredEdition;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float FadeOverride;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2CEA30C", Offset = "0x2CEA30C", VA = "0x2CEA30C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2CEA374", Offset = "0x2CEA374", VA = "0x2CEA374", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2CE9144", Offset = "0x2CE9144", VA = "0x2CE9144")]
		[DebuggerHidden]
		public <DelayedSwitchEdition>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2CEA204", Offset = "0x2CEA204", VA = "0x2CEA204", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2CEA208", Offset = "0x2CEA208", VA = "0x2CEA208", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2CEA314", Offset = "0x2CEA314", VA = "0x2CEA314", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C20", Offset = "0xF28C20")]
	private sealed class <>c__DisplayClass48_0
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EditionName;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2CE981C", Offset = "0x2CE981C", VA = "0x2CE981C")]
		public <>c__DisplayClass48_0()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2CE9E2C", Offset = "0x2CE9E2C", VA = "0x2CE9E2C")]
		internal bool <SwitchEdition>b__0(Edition x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C30", Offset = "0xF28C30")]
	private sealed class <>c__DisplayClass49_0
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EditionName;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2CE9A1C", Offset = "0x2CE9A1C", VA = "0x2CE9A1C")]
		public <>c__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2CE9E40", Offset = "0x2CE9E40", VA = "0x2CE9E40")]
		internal bool <SwitchEdition>b__0(Edition x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C40", Offset = "0xF28C40")]
	private sealed class <DelayedSwitchEdition>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Func<bool> DelayDelegate;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Edition DesiredEdition;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float FadeOverride;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2CEA484", Offset = "0x2CEA484", VA = "0x2CEA484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2CEA4EC", Offset = "0x2CEA4EC", VA = "0x2CEA4EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2CE9AF4", Offset = "0x2CE9AF4", VA = "0x2CE9AF4")]
		[DebuggerHidden]
		public <DelayedSwitchEdition>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2CEA37C", Offset = "0x2CEA37C", VA = "0x2CEA37C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2CEA380", Offset = "0x2CEA380", VA = "0x2CEA380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2CEA48C", Offset = "0x2CEA48C", VA = "0x2CEA48C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C50", Offset = "0xF28C50")]
	private sealed class <FadeDownAudio>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioObject Audio;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Target;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float FadeDuration;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MusicManager <>4__this;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <Rate>5__2;

		[Token(Token = "0x17000024")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2CEA644", Offset = "0x2CEA644", VA = "0x2CEA644", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2CEA6AC", Offset = "0x2CEA6AC", VA = "0x2CEA6AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2CE9C60", Offset = "0x2CE9C60", VA = "0x2CE9C60")]
		[DebuggerHidden]
		public <FadeDownAudio>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2CEA4F4", Offset = "0x2CEA4F4", VA = "0x2CEA4F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2CEA4F8", Offset = "0x2CEA4F8", VA = "0x2CEA4F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2CEA64C", Offset = "0x2CEA64C", VA = "0x2CEA64C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C60", Offset = "0xF28C60")]
	private sealed class <FadeUpAudio>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Target;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioObject Audio;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x2CEA7F0", Offset = "0x2CEA7F0", VA = "0x2CEA7F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x2CEA858", Offset = "0x2CEA858", VA = "0x2CEA858", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x2CE9C8C", Offset = "0x2CE9C8C", VA = "0x2CE9C8C")]
		[DebuggerHidden]
		public <FadeUpAudio>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2CEA6B4", Offset = "0x2CEA6B4", VA = "0x2CEA6B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2CEA6B8", Offset = "0x2CEA6B8", VA = "0x2CEA6B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2CEA7F8", Offset = "0x2CEA7F8", VA = "0x2CEA7F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C70", Offset = "0xF28C70")]
	private sealed class <VolumeFade>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Volume;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MusicManager <>4__this;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x2CEA9B8", Offset = "0x2CEA9B8", VA = "0x2CEA9B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x2CEAA20", Offset = "0x2CEAA20", VA = "0x2CEAA20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x2CE9D4C", Offset = "0x2CE9D4C", VA = "0x2CE9D4C")]
		[DebuggerHidden]
		public <VolumeFade>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2CEA860", Offset = "0x2CEA860", VA = "0x2CEA860", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x2CEA864", Offset = "0x2CEA864", VA = "0x2CEA864", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2CEA9C0", Offset = "0x2CEA9C0", VA = "0x2CEA9C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28F88", Offset = "0xF28F88")]
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
		[Address(RVA = "0x2CE7340", Offset = "0x2CE7340", VA = "0x2CE7340", Slot = "4")]
		get
		{
			return default(AudioObject.SoundType);
		}
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x2CE7348", Offset = "0x2CE7348", VA = "0x2CE7348", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2CE7454", Offset = "0x2CE7454", VA = "0x2CE7454")]
	private Track FindTrackInLibrary(string TrackName)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2CE75C8", Offset = "0x2CE75C8", VA = "0x2CE75C8")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2CE7680", Offset = "0x2CE7680", VA = "0x2CE7680")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName, float Delay, bool IsOneShot = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2CE7810", Offset = "0x2CE7810", VA = "0x2CE7810")]
	[BindableMethod]
	public Track PlayFromLibrary(string TrackName, float Delay, float FadeDuration, bool IsOneShot = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2CE78D4", Offset = "0x2CE78D4", VA = "0x2CE78D4")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2CE7944", Offset = "0x2CE7944", VA = "0x2CE7944")]
	public bool IsPlaying(Track DesiredTrack)
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2CE79C0", Offset = "0x2CE79C0", VA = "0x2CE79C0")]
	public bool IsPlaying(string TrackName)
	{
		return default(bool);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2CE7674", Offset = "0x2CE7674", VA = "0x2CE7674")]
	[BindableMethod]
	public void Play(Track DesiredTrack)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2CE773C", Offset = "0x2CE773C", VA = "0x2CE773C")]
	[BindableMethod]
	public void Play(Track DesiredTrack, float Delay, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2CE6778", Offset = "0x2CE6778", VA = "0x2CE6778")]
	[BindableMethod]
	public void Play(Track DesiredTrack, float Delay, float FadeDuration, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2CE7B00", Offset = "0x2CE7B00", VA = "0x2CE7B00")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF29E54", Offset = "0xF29E54")]
	private IEnumerator DelayedPlay(Track DesiredTrack, float Delay, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2CE7DF0", Offset = "0x2CE7DF0", VA = "0x2CE7DF0")]
	[BindableMethod]
	public void Stop()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2CE7E08", Offset = "0x2CE7E08", VA = "0x2CE7E08")]
	[BindableMethod]
	public void Stop(Track AudioTrack)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2CE7BB0", Offset = "0x2CE7BB0", VA = "0x2CE7BB0")]
	[BindableMethod]
	public void Stop(float FadeDuration)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2CE7E00", Offset = "0x2CE7E00", VA = "0x2CE7E00")]
	[BindableMethod]
	public void Stop(Track AudioTrack, float FadeDuration)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2CE7E14", Offset = "0x2CE7E14", VA = "0x2CE7E14")]
	private void Stop(Track AudioTrack, float FadeDuration, bool OneStopEnd)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2CE8088", Offset = "0x2CE8088", VA = "0x2CE8088")]
	public void SequenceEnd(Track AudioTrack, float RemainingTime)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2CE6FAC", Offset = "0x2CE6FAC", VA = "0x2CE6FAC")]
	public void SequenceEnd(AudioObject Audio, float RemainingTime)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2CE8188", Offset = "0x2CE8188", VA = "0x2CE8188")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF29EF8", Offset = "0xF29EF8")]
	private IEnumerator DelayedEndTrack(float Duration)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2CE8214", Offset = "0x2CE8214", VA = "0x2CE8214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF29F5C", Offset = "0xF29F5C")]
	private IEnumerator DelayedEndAudio(AudioObject Audio, float Duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2CE8314", Offset = "0x2CE8314", VA = "0x2CE8314")]
	[BindableMethod]
	public void Restart()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2CE8414", Offset = "0x2CE8414", VA = "0x2CE8414")]
	[BindableMethod]
	public void Restart(Track AudioTrack)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2CE841C", Offset = "0x2CE841C", VA = "0x2CE841C")]
	[BindableMethod]
	public void Restart(float FadeDuration)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2CE8320", Offset = "0x2CE8320", VA = "0x2CE8320")]
	[BindableMethod]
	public void Restart(Track AudioTrack, float FadeDuration)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2CE6DF0", Offset = "0x2CE6DF0", VA = "0x2CE6DF0")]
	public AudioObject StartAudio(AudioClip Audio)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2CE7A70", Offset = "0x2CE7A70", VA = "0x2CE7A70")]
	private void StopTrackDelay()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2CE7AB8", Offset = "0x2CE7AB8", VA = "0x2CE7AB8")]
	private void StopTrackEnd()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2CE8424", Offset = "0x2CE8424", VA = "0x2CE8424")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex, float Delay)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2CE861C", Offset = "0x2CE861C", VA = "0x2CE861C")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2CE8624", Offset = "0x2CE8624", VA = "0x2CE8624")]
	[BindableMethod]
	public void SwitchEdition(int EditionIndex, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2CE8940", Offset = "0x2CE8940", VA = "0x2CE8940")]
	[BindableMethod]
	public void SwitchEdition(string EditionName, float Delay = 0f)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2CE8B44", Offset = "0x2CE8B44", VA = "0x2CE8B44")]
	[BindableMethod]
	public void SwitchEdition(string EditionName, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2CE8D44", Offset = "0x2CE8D44", VA = "0x2CE8D44")]
	public void SwitchEdition(Edition DesiredEdition)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2CE85E0", Offset = "0x2CE85E0", VA = "0x2CE85E0")]
	public void SwitchEdition(Edition DesiredEdition, float Delay)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2CE87D8", Offset = "0x2CE87D8", VA = "0x2CE87D8")]
	public void SwitchEdition(Edition DesiredEdition, float Delay, float FadeOverride)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2CE8E08", Offset = "0x2CE8E08", VA = "0x2CE8E08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A050", Offset = "0xF2A050")]
	private IEnumerator DelayedSwitchEdition(Edition DesiredEdition, float Delay, float FadeOverride)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2CE9170", Offset = "0x2CE9170", VA = "0x2CE9170")]
	public void SwitchEdition(int EditionIndex, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2CE9360", Offset = "0x2CE9360", VA = "0x2CE9360")]
	public void SwitchEdition(int EditionIndex, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2CE9628", Offset = "0x2CE9628", VA = "0x2CE9628")]
	public void SwitchEdition(string EditionName, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2CE9824", Offset = "0x2CE9824", VA = "0x2CE9824")]
	public void SwitchEdition(string EditionName, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2CE9324", Offset = "0x2CE9324", VA = "0x2CE9324")]
	public void SwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2CE9514", Offset = "0x2CE9514", VA = "0x2CE9514")]
	public void SwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate, float FadeOverride)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2CE9A24", Offset = "0x2CE9A24", VA = "0x2CE9A24")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A0B4", Offset = "0xF2A0B4")]
	private IEnumerator DelayedSwitchEdition(Edition DesiredEdition, Func<bool> DelayDelegate, float FadeOverride)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x2CE6DFC", Offset = "0x2CE6DFC", VA = "0x2CE6DFC")]
	public void FadeAudio(AudioObject Audio, float FadeDuration, float Target)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x2CE9BB4", Offset = "0x2CE9BB4", VA = "0x2CE9BB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A118", Offset = "0xF2A118")]
	private IEnumerator FadeDownAudio(AudioObject Audio, float FadeDuration, float Target)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2CE9B20", Offset = "0x2CE9B20", VA = "0x2CE9B20")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A17C", Offset = "0xF2A17C")]
	private IEnumerator FadeUpAudio(AudioObject Audio, float FadeDuration, float Target)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2CE9CB8", Offset = "0x2CE9CB8", VA = "0x2CE9CB8", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A1E0", Offset = "0xF2A1E0")]
	protected override IEnumerator VolumeFade(float Volume, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2CE9D78", Offset = "0x2CE9D78", VA = "0x2CE9D78")]
	public MusicManager()
	{
	}
}
[Token(Token = "0x2000008")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xF289AC", Offset = "0xF289AC")]
public class Playlist : ScriptableObject
{
	[Token(Token = "0x200002B")]
	public enum ShuffleMode
	{
		[Token(Token = "0x40000CC")]
		None,
		[Token(Token = "0x40000CD")]
		Random,
		[Token(Token = "0x40000CE")]
		RandomUnique
	}

	[Token(Token = "0x200002C")]
	public enum CrossfadeMode
	{
		[Token(Token = "0x40000D0")]
		ForcedOn,
		[Token(Token = "0x40000D1")]
		ForcedOff,
		[Token(Token = "0x40000D2")]
		TrackDefined
	}

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF28FD0", Offset = "0xF28FD0")]
	public string PlaylistName;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29008", Offset = "0xF29008")]
	public ShuffleMode Shuffle;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29040", Offset = "0xF29040")]
	public CrossfadeMode Crossfade;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29078", Offset = "0xF29078")]
	public float CrossfadeDuration;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF290B0", Offset = "0xF290B0")]
	public float TrackGapDuration;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF290E8", Offset = "0xF290E8")]
	public Track[] Tracks;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29120", Offset = "0xF29120")]
	private bool <IsPlaying>k__BackingField;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29130", Offset = "0xF29130")]
	private Track <CurrentTrack>k__BackingField;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29140", Offset = "0xF29140")]
	private Track <LastTrack>k__BackingField;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int TrackID;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int NextTrackID;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Track> TracksToPlay;

	[Token(Token = "0x17000006")]
	public bool IsPlaying
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2CEAA28", Offset = "0x2CEAA28", VA = "0x2CEAA28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A244", Offset = "0xF2A244")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2CEAA30", Offset = "0x2CEAA30", VA = "0x2CEAA30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A254", Offset = "0xF2A254")]
		private set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Track CurrentTrack
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2CEAA3C", Offset = "0x2CEAA3C", VA = "0x2CEAA3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A264", Offset = "0xF2A264")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2CEAA44", Offset = "0x2CEAA44", VA = "0x2CEAA44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A274", Offset = "0xF2A274")]
		private set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Track LastTrack
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2CEAA4C", Offset = "0x2CEAA4C", VA = "0x2CEAA4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A284", Offset = "0xF2A284")]
		get
		{
			return null;
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2CEAA54", Offset = "0x2CEAA54", VA = "0x2CEAA54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A294", Offset = "0xF2A294")]
		private set
		{
		}
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2CEAA5C", Offset = "0x2CEAA5C", VA = "0x2CEAA5C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2CEAAA4", Offset = "0x2CEAAA4", VA = "0x2CEAAA4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2CEAB24", Offset = "0x2CEAB24", VA = "0x2CEAB24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2CEAAE4", Offset = "0x2CEAAE4", VA = "0x2CEAAE4")]
	private void Reset()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2CEAB64", Offset = "0x2CEAB64", VA = "0x2CEAB64")]
	public void Start()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2CEAE2C", Offset = "0x2CEAE2C", VA = "0x2CEAE2C")]
	public void Stop()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2CEAE6C", Offset = "0x2CEAE6C", VA = "0x2CEAE6C")]
	public float CalculateWaitTime()
	{
		return default(float);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2CEAFD4", Offset = "0x2CEAFD4", VA = "0x2CEAFD4")]
	public void PlayNext()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2CEACCC", Offset = "0x2CEACCC", VA = "0x2CEACCC")]
	private void SelectNext()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2CEB110", Offset = "0x2CEB110", VA = "0x2CEB110")]
	public Playlist()
	{
	}
}
[Token(Token = "0x2000009")]
public class PlaylistManager : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C80", Offset = "0xF28C80")]
	private sealed class <DelayedPlay>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PlaylistManager <>4__this;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Playlist DesiredPlaylist;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x2CEBC44", Offset = "0x2CEBC44", VA = "0x2CEBC44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x2CEBCAC", Offset = "0x2CEBCAC", VA = "0x2CEBCAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x2CEB778", Offset = "0x2CEB778", VA = "0x2CEB778")]
		[DebuggerHidden]
		public <DelayedPlay>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2CEBB7C", Offset = "0x2CEBB7C", VA = "0x2CEBB7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2CEBB80", Offset = "0x2CEBB80", VA = "0x2CEBB80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2CEBC4C", Offset = "0x2CEBC4C", VA = "0x2CEBC4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28C90", Offset = "0xF28C90")]
	private sealed class <PlayPlaylist>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlaylistManager <>4__this;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x2CEBE68", Offset = "0x2CEBE68", VA = "0x2CEBE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x2CEBED0", Offset = "0x2CEBED0", VA = "0x2CEBED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2CEB898", Offset = "0x2CEB898", VA = "0x2CEB898")]
		[DebuggerHidden]
		public <PlayPlaylist>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2CEBCB4", Offset = "0x2CEBCB4", VA = "0x2CEBCB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x2CEBCB8", Offset = "0x2CEBCB8", VA = "0x2CEBCB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2CEBE70", Offset = "0x2CEBE70", VA = "0x2CEBE70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CA0", Offset = "0xF28CA0")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PlaylistName;

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2CEBA30", Offset = "0x2CEBA30", VA = "0x2CEBA30")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x2CEBB58", Offset = "0x2CEBB58", VA = "0x2CEBB58")]
		internal bool <FindPlaylistInLibrary>b__0(Playlist x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29150", Offset = "0xF29150")]
	[SerializeField]
	private bool ScenePersistent;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2919C", Offset = "0xF2919C")]
	public Playlist[] PlaylistLibrary;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Playlist TargetPlaylist;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static PlaylistManager Main;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine TrackScheduler;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Coroutine DelayJob;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2CEB17C", Offset = "0x2CEB17C", VA = "0x2CEB17C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2CEB39C", Offset = "0x2CEB39C", VA = "0x2CEB39C")]
	private void ValidateIsPlaying(Track CurrentManagerTrack)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2CEB49C", Offset = "0x2CEB49C", VA = "0x2CEB49C")]
	private void ValidateOneShotEnd(Track CurrentManagerTrack, bool IsOneShot)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2CEB478", Offset = "0x2CEB478", VA = "0x2CEB478")]
	private void StopAllJobs()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2CEB5C4", Offset = "0x2CEB5C4", VA = "0x2CEB5C4")]
	private void StopDelayJob()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2CEB60C", Offset = "0x2CEB60C", VA = "0x2CEB60C")]
	private void StopTrackScheduler()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2CE6A98", Offset = "0x2CE6A98", VA = "0x2CE6A98")]
	[BindableMethod]
	public void Play(Playlist DesiredPlaylist, float Delay = 0f)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2CEB654", Offset = "0x2CEB654", VA = "0x2CEB654")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A2B4", Offset = "0xF2A2B4")]
	private IEnumerator DelayedPlay(Playlist DesiredPlaylist, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2CEB7A4", Offset = "0x2CEB7A4", VA = "0x2CEB7A4")]
	[BindableMethod]
	public void Stop()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2CEB6FC", Offset = "0x2CEB6FC", VA = "0x2CEB6FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A328", Offset = "0xF2A328")]
	private IEnumerator PlayPlaylist()
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2CEB8C4", Offset = "0x2CEB8C4", VA = "0x2CEB8C4")]
	private Playlist FindPlaylistInLibrary(string PlaylistName)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2CEBA38", Offset = "0x2CEBA38", VA = "0x2CEBA38")]
	[BindableMethod]
	public Playlist PlayFromLibrary(string PlaylistName, float Delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2CEBAEC", Offset = "0x2CEBAEC", VA = "0x2CEBAEC")]
	public PlaylistManager()
	{
	}
}
[Token(Token = "0x200000A")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xF28A18", Offset = "0xF28A18")]
public class SFXGroup : ScriptableObject
{
	[Token(Token = "0x2000030")]
	public enum RandomMode
	{
		[Token(Token = "0x40000DD")]
		AllowRepeats,
		[Token(Token = "0x40000DE")]
		DisallowRepeats,
		[Token(Token = "0x40000DF")]
		FullyUnique
	}

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF291D4", Offset = "0xF291D4")]
	public string GroupName;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2920C", Offset = "0xF2920C")]
	public SFXObject[] SFXObjects;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29244", Offset = "0xF29244")]
	public RandomMode Randomization;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int LastID;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<SFXObject> SFXObjectsToPlay;

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2CEBED8", Offset = "0x2CEBED8", VA = "0x2CEBED8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2CEBF20", Offset = "0x2CEBF20", VA = "0x2CEBF20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2CEBFBC", Offset = "0x2CEBFBC", VA = "0x2CEBFBC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2CEBF24", Offset = "0x2CEBF24", VA = "0x2CEBF24")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2CEBFC0", Offset = "0x2CEBFC0", VA = "0x2CEBFC0")]
	public Coroutine Play()
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2CEC1D4", Offset = "0x2CEC1D4", VA = "0x2CEC1D4")]
	public Coroutine Play(float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2CEC298", Offset = "0x2CEC298", VA = "0x2CEC298")]
	public Coroutine Play(float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2CEC364", Offset = "0x2CEC364", VA = "0x2CEC364")]
	public Coroutine Play(float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2CEC440", Offset = "0x2CEC440", VA = "0x2CEC440")]
	public Coroutine Play(Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2CEC590", Offset = "0x2CEC590", VA = "0x2CEC590")]
	public Coroutine Play(Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2CEC698", Offset = "0x2CEC698", VA = "0x2CEC698")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2CEC7B0", Offset = "0x2CEC7B0", VA = "0x2CEC7B0")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2CEC05C", Offset = "0x2CEC05C", VA = "0x2CEC05C")]
	private void SelectNext()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2CEC8D0", Offset = "0x2CEC8D0", VA = "0x2CEC8D0")]
	public SFXGroup()
	{
	}
}
[Serializable]
[Token(Token = "0x200000B")]
public struct SFXLayer
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2927C", Offset = "0xF2927C")]
	public string LayerName;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF292B4", Offset = "0xF292B4")]
	public AudioClip SFX;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF292EC", Offset = "0xF292EC")]
	public bool RandomizeVolume;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29324", Offset = "0xF29324")]
	public float FixedVolume;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2935C", Offset = "0xF2935C")]
	public float MinVolume;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29394", Offset = "0xF29394")]
	public float MaxVolume;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF293CC", Offset = "0xF293CC")]
	public bool RandomizePitch;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29404", Offset = "0xF29404")]
	public float FixedPitch;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2943C", Offset = "0xF2943C")]
	public float MinPitch;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29474", Offset = "0xF29474")]
	public float MaxPitch;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF294AC", Offset = "0xF294AC")]
	public bool DelaySFX;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF294E4", Offset = "0xF294E4")]
	public bool RandomizeDelay;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2951C", Offset = "0xF2951C")]
	public float FixedDelayTime;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29554", Offset = "0xF29554")]
	public float MinDelayTime;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2958C", Offset = "0xF2958C")]
	public float MaxDelayTime;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF295C4", Offset = "0xF295C4")]
	public bool Mute;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF295FC", Offset = "0xF295FC")]
	public bool BypassEffects;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29634", Offset = "0xF29634")]
	public bool BypassReverbZones;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2966C", Offset = "0xF2966C")]
	public int Priority;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF296A4", Offset = "0xF296A4")]
	public float StereoPan;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF296DC", Offset = "0xF296DC")]
	public float SpatialBlend;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29714", Offset = "0xF29714")]
	public float ReverbZoneMix;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioMixerGroup MixerOverride;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float MinDistance;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float MaxDistance;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AudioRolloffMode RolloffMode;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2CEC93C", Offset = "0x2CEC93C", VA = "0x2CEC93C")]
	public float GetDelayDuration()
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2CEC968", Offset = "0x2CEC968", VA = "0x2CEC968")]
	public float GetVolume(float VolumeMultiplier = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x2CEC9A4", Offset = "0x2CEC9A4", VA = "0x2CEC9A4")]
	public float GetPitch(float PitchMultiplier = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2CECA44", Offset = "0x2CECA44", VA = "0x2CECA44")]
	public Coroutine Play(float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x2CECDD0", Offset = "0x2CECDD0", VA = "0x2CECDD0")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x2CECCB4", Offset = "0x2CECCB4", VA = "0x2CECCB4")]
	private AudioObject PlaySFXAudio(float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2CECF80", Offset = "0x2CECF80", VA = "0x2CECF80")]
	private void CopySFXSettings(AudioObject TargetAudio)
	{
	}
}
[Token(Token = "0x200000C")]
public class SFXLoopManager : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CB0", Offset = "0xF28CB0")]
	private sealed class <>c
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Coroutine> <>9__19_0;

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2CEDD18", Offset = "0x2CEDD18", VA = "0x2CEDD18")]
		public <>c()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2CEDD20", Offset = "0x2CEDD20", VA = "0x2CEDD20")]
		internal bool <Stop>b__19_0(Coroutine x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CC0", Offset = "0xF28CC0")]
	private sealed class <FadeAndStop>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AMPAudioSource source;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeDuration;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXLoopManager <>4__this;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <rate>5__2;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x2CEDE6C", Offset = "0x2CEDE6C", VA = "0x2CEDE6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x2CEDED4", Offset = "0x2CEDED4", VA = "0x2CEDED4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2CED9F8", Offset = "0x2CED9F8", VA = "0x2CED9F8")]
		[DebuggerHidden]
		public <FadeAndStop>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x2CEDD2C", Offset = "0x2CEDD2C", VA = "0x2CEDD2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x2CEDD30", Offset = "0x2CEDD30", VA = "0x2CEDD30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2CEDE74", Offset = "0x2CEDE74", VA = "0x2CEDE74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF2974C", Offset = "0xF2974C")]
	[SerializeField]
	private bool ScenePersistent;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29798", Offset = "0xF29798")]
	private Transform <Parent>k__BackingField;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF297A8", Offset = "0xF297A8")]
	private static SFXLoopManager <Main>k__BackingField;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<AMPAudioSource> _pooledSources;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<AMPAudioSource> _activeSources;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Coroutine> _sequencedEvents;

	[Token(Token = "0x17000009")]
	public Transform Parent
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2CED270", Offset = "0x2CED270", VA = "0x2CED270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A39C", Offset = "0xF2A39C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2CED278", Offset = "0x2CED278", VA = "0x2CED278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A3AC", Offset = "0xF2A3AC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public static SFXLoopManager Main
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2CED280", Offset = "0x2CED280", VA = "0x2CED280")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A3BC", Offset = "0xF2A3BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2CED2D0", Offset = "0x2CED2D0", VA = "0x2CED2D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A3CC", Offset = "0xF2A3CC")]
		private set
		{
		}
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x2CED328", Offset = "0x2CED328", VA = "0x2CED328")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x2CED44C", Offset = "0x2CED44C", VA = "0x2CED44C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x2CED524", Offset = "0x2CED524", VA = "0x2CED524")]
	private AMPAudioSource GetSource()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x2CED61C", Offset = "0x2CED61C", VA = "0x2CED61C")]
	private void RemoveSource(AMPAudioSource source)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x2CED6E4", Offset = "0x2CED6E4", VA = "0x2CED6E4")]
	public AMPAudioSource Play(ClipGroup clipGroup, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x2CE6674", Offset = "0x2CE6674", VA = "0x2CE6674")]
	public AMPAudioSource Play(AudioClip clip, float volume = 1f)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x2CED754", Offset = "0x2CED754", VA = "0x2CED754")]
	public void Stop(AMPAudioSource source)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2CED7F0", Offset = "0x2CED7F0", VA = "0x2CED7F0")]
	public void Stop(AMPAudioSource source, float fadeDuration)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2CED950", Offset = "0x2CED950", VA = "0x2CED950")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A3DC", Offset = "0xF2A3DC")]
	private IEnumerator FadeAndStop(AMPAudioSource source, float fadeDuration)
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2CEDA24", Offset = "0x2CEDA24", VA = "0x2CEDA24")]
	public void StopAll()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x2CEDBD4", Offset = "0x2CEDBD4", VA = "0x2CEDBD4")]
	public SFXLoopManager()
	{
	}
}
[Token(Token = "0x200000D")]
public class SFXManager : SoundManager
{
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CD0", Offset = "0xF28CD0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SFXName;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2CEE15C", Offset = "0x2CEE15C", VA = "0x2CEE15C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2CF0A50", Offset = "0x2CF0A50", VA = "0x2CF0A50")]
		internal bool <FindSFXObjectInLibrary>b__0(SFXObject x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CE0", Offset = "0xF28CE0")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string SFXName;

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2CEE2D0", Offset = "0x2CEE2D0", VA = "0x2CEE2D0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2CF0980", Offset = "0x2CF0980", VA = "0x2CF0980")]
		internal bool <FindSFXGroupInLibrary>b__0(SFXGroup x)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28CF0", Offset = "0xF28CF0")]
	private sealed class <>c
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<Coroutine> <>9__35_0;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Predicate<Coroutine> <>9__36_0;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Predicate<Coroutine> <>9__37_0;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Predicate<Coroutine> <>9__38_0;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Predicate<Coroutine> <>9__54_0;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Predicate<Coroutine> <>9__55_0;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static Action <>9__59_0;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2CF092C", Offset = "0x2CF092C", VA = "0x2CF092C")]
		public <>c()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2CF0934", Offset = "0x2CF0934", VA = "0x2CF0934")]
		internal bool <PlaySuspended>b__35_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2CF0940", Offset = "0x2CF0940", VA = "0x2CF0940")]
		internal bool <PlaySuspended>b__36_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2CF094C", Offset = "0x2CF094C", VA = "0x2CF094C")]
		internal bool <PlaySuspended>b__37_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2CF0958", Offset = "0x2CF0958", VA = "0x2CF0958")]
		internal bool <PlaySuspended>b__38_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2CF0964", Offset = "0x2CF0964", VA = "0x2CF0964")]
		internal bool <SequenceEnd>b__54_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2CF0970", Offset = "0x2CF0970", VA = "0x2CF0970")]
		internal bool <SequenceEnd>b__55_0(Coroutine x)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2CF097C", Offset = "0x2CF097C", VA = "0x2CF097C")]
		internal void <.ctor>b__59_0()
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D00", Offset = "0xF28D00")]
	private sealed class <DelayedPlay>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXObject SFX;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Volume;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Pitch;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2CF0E4C", Offset = "0x2CF0E4C", VA = "0x2CF0E4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2CF0EB4", Offset = "0x2CF0EB4", VA = "0x2CF0EB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2CF006C", Offset = "0x2CF006C", VA = "0x2CF006C")]
		[DebuggerHidden]
		public <DelayedPlay>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2CF0D78", Offset = "0x2CF0D78", VA = "0x2CF0D78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2CF0D7C", Offset = "0x2CF0D7C", VA = "0x2CF0D7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2CF0E54", Offset = "0x2CF0E54", VA = "0x2CF0E54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D10", Offset = "0xF28D10")]
	private sealed class <DelayedPlay>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SFXObject SFX;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 Position;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Volume;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Pitch;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform Parent;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool IsGlobalPosition;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2CF0FA8", Offset = "0x2CF0FA8", VA = "0x2CF0FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x2CF1010", Offset = "0x2CF1010", VA = "0x2CF1010", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2CF0098", Offset = "0x2CF0098", VA = "0x2CF0098")]
		[DebuggerHidden]
		public <DelayedPlay>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2CF0EBC", Offset = "0x2CF0EBC", VA = "0x2CF0EBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2CF0EC0", Offset = "0x2CF0EC0", VA = "0x2CF0EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2CF0FB0", Offset = "0x2CF0FB0", VA = "0x2CF0FB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D20", Offset = "0xF28D20")]
	private sealed class <DelayedPlay>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXLayer SFX;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Vector3 Position;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float SFXVolume;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float SFXPitch;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Transform Parent;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool IsGlobalPosition;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x2CF10EC", Offset = "0x2CF10EC", VA = "0x2CF10EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x2CF1154", Offset = "0x2CF1154", VA = "0x2CF1154", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x2CF00C4", Offset = "0x2CF00C4", VA = "0x2CF00C4")]
		[DebuggerHidden]
		public <DelayedPlay>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x2CF1018", Offset = "0x2CF1018", VA = "0x2CF1018", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x2CF101C", Offset = "0x2CF101C", VA = "0x2CF101C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2CF10F4", Offset = "0x2CF10F4", VA = "0x2CF10F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D30", Offset = "0xF28D30")]
	private sealed class <DelayedPlay>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DelayDuration;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXLayer SFX;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float SFXVolume;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float SFXPitch;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2CF1220", Offset = "0x2CF1220", VA = "0x2CF1220", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2CF1288", Offset = "0x2CF1288", VA = "0x2CF1288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x2CF00F0", Offset = "0x2CF00F0", VA = "0x2CF00F0")]
		[DebuggerHidden]
		public <DelayedPlay>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2CF115C", Offset = "0x2CF115C", VA = "0x2CF115C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2CF1160", Offset = "0x2CF1160", VA = "0x2CF1160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x2CF1228", Offset = "0x2CF1228", VA = "0x2CF1228", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D40", Offset = "0xF28D40")]
	private sealed class <DelayedEndAudio>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Duration;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioObject Audio;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x2CF0B44", Offset = "0x2CF0B44", VA = "0x2CF0B44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2CF0BAC", Offset = "0x2CF0BAC", VA = "0x2CF0BAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2CF061C", Offset = "0x2CF061C", VA = "0x2CF061C")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x2CF0A74", Offset = "0x2CF0A74", VA = "0x2CF0A74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2CF0A78", Offset = "0x2CF0A78", VA = "0x2CF0A78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2CF0B4C", Offset = "0x2CF0B4C", VA = "0x2CF0B4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D50", Offset = "0xF28D50")]
	private sealed class <>c__DisplayClass57_0
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SFXManager <>4__this;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioObject Audio;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2CF09A4", Offset = "0x2CF09A4", VA = "0x2CF09A4")]
		public <>c__DisplayClass57_0()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2CF09AC", Offset = "0x2CF09AC", VA = "0x2CF09AC")]
		internal bool <DelayedEndAudio>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D60", Offset = "0xF28D60")]
	private sealed class <DelayedEndAudio>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SFXManager <>4__this;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioObject Audio;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private <>c__DisplayClass57_0 <>8__1;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x2CF0D08", Offset = "0x2CF0D08", VA = "0x2CF0D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x2CF0D70", Offset = "0x2CF0D70", VA = "0x2CF0D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2CF0648", Offset = "0x2CF0648", VA = "0x2CF0648")]
		[DebuggerHidden]
		public <DelayedEndAudio>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2CF0BB4", Offset = "0x2CF0BB4", VA = "0x2CF0BB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2CF0BB8", Offset = "0x2CF0BB8", VA = "0x2CF0BB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2CF0D10", Offset = "0x2CF0D10", VA = "0x2CF0D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D70", Offset = "0xF28D70")]
	private sealed class <VolumeFade>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Volume;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public SFXManager <>4__this;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeDuration;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <Rate>5__2;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x2CF13E8", Offset = "0x2CF13E8", VA = "0x2CF13E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x2CF1450", Offset = "0x2CF1450", VA = "0x2CF1450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2CF0708", Offset = "0x2CF0708", VA = "0x2CF0708")]
		[DebuggerHidden]
		public <VolumeFade>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2CF1290", Offset = "0x2CF1290", VA = "0x2CF1290", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2CF1294", Offset = "0x2CF1294", VA = "0x2CF1294", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2CF13F0", Offset = "0x2CF13F0", VA = "0x2CF13F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF297B8", Offset = "0xF297B8")]
	public SFXObject[] SFXObjectLibrary;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF297F0", Offset = "0xF297F0")]
	public SFXGroup[] SFXGroupLibrary;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static SFXManager Main;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action OnStopAll;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Coroutine> SequencedStartJobs;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<Coroutine> SequencedEndJobs;

	[Token(Token = "0x1700000B")]
	public override AudioObject.SoundType ManagerType
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2CEDEDC", Offset = "0x2CEDEDC", VA = "0x2CEDEDC", Slot = "4")]
		get
		{
			return default(AudioObject.SoundType);
		}
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x2CEDEE4", Offset = "0x2CEDEE4", VA = "0x2CEDEE4", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x2CEDFF0", Offset = "0x2CEDFF0", VA = "0x2CEDFF0")]
	[BindableMethod]
	private SFXObject FindSFXObjectInLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x2CEE164", Offset = "0x2CEE164", VA = "0x2CEE164")]
	[BindableMethod]
	private SFXGroup FindSFXGroupInLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x2CEE2D8", Offset = "0x2CEE2D8", VA = "0x2CEE2D8")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x2CEE388", Offset = "0x2CEE388", VA = "0x2CEE388")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x2CEE450", Offset = "0x2CEE450", VA = "0x2CEE450")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2CEE520", Offset = "0x2CEE520", VA = "0x2CEE520")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2CEE604", Offset = "0x2CEE604", VA = "0x2CEE604")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2CEE700", Offset = "0x2CEE700", VA = "0x2CEE700")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x2CEE808", Offset = "0x2CEE808", VA = "0x2CEE808")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2CEE924", Offset = "0x2CEE924", VA = "0x2CEE924")]
	[BindableMethod]
	public Coroutine PlayFromSFXObjectLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2CEEA48", Offset = "0x2CEEA48", VA = "0x2CEEA48")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName)
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x2CEEAFC", Offset = "0x2CEEAFC", VA = "0x2CEEAFC")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2CEEBDC", Offset = "0x2CEEBDC", VA = "0x2CEEBDC")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2CEECAC", Offset = "0x2CEECAC", VA = "0x2CEECAC")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2CEEDA8", Offset = "0x2CEEDA8", VA = "0x2CEEDA8")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2CEEECC", Offset = "0x2CEEECC", VA = "0x2CEEECC")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2CEEFF8", Offset = "0x2CEEFF8", VA = "0x2CEEFF8")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2CEF138", Offset = "0x2CEF138", VA = "0x2CEF138")]
	[BindableMethod]
	public Coroutine PlayFromSFXGroupLibrary(string SFXName, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2CE6BA4", Offset = "0x2CE6BA4", VA = "0x2CE6BA4")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2CEC280", Offset = "0x2CEC280", VA = "0x2CEC280")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2CEC34C", Offset = "0x2CEC34C", VA = "0x2CEC34C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2CEC428", Offset = "0x2CEC428", VA = "0x2CEC428")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x2CEC51C", Offset = "0x2CEC51C", VA = "0x2CEC51C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2CEC674", Offset = "0x2CEC674", VA = "0x2CEC674")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2CEC78C", Offset = "0x2CEC78C", VA = "0x2CEC78C")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2CEC8AC", Offset = "0x2CEC8AC", VA = "0x2CEC8AC")]
	[BindableMethod]
	public Coroutine Play(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2CEF7E4", Offset = "0x2CEF7E4", VA = "0x2CEF7E4")]
	public Coroutine PlaySuspended(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2CEFA1C", Offset = "0x2CEFA1C", VA = "0x2CEFA1C")]
	public Coroutine PlaySuspended(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2CECB24", Offset = "0x2CECB24", VA = "0x2CECB24")]
	public Coroutine PlaySuspended(SFXLayer SFX, float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2CEFD98", Offset = "0x2CEFD98", VA = "0x2CEFD98")]
	public Coroutine PlaySuspended(SFXLayer SFX, Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2CEF960", Offset = "0x2CEF960", VA = "0x2CEF960")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A5E0", Offset = "0xF2A5E0")]
	private IEnumerator DelayedPlay(SFXObject SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2CEFBD0", Offset = "0x2CEFBD0", VA = "0x2CEFBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A644", Offset = "0xF2A644")]
	private IEnumerator DelayedPlay(SFXObject SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2CEFF60", Offset = "0x2CEFF60", VA = "0x2CEFF60")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A6A8", Offset = "0xF2A6A8")]
	private IEnumerator DelayedPlay(SFXLayer SFX, Vector3 Position, float DelayDuration, float SFXVolume, float SFXPitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2CEFCD0", Offset = "0x2CEFCD0", VA = "0x2CEFCD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A70C", Offset = "0xF2A70C")]
	private IEnumerator DelayedPlay(SFXLayer SFX, float DelayDuration, float SFXVolume, float SFXPitch)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2CE6C38", Offset = "0x2CE6C38", VA = "0x2CE6C38")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2CEEBC4", Offset = "0x2CEEBC4", VA = "0x2CEEBC4")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2CE6CC0", Offset = "0x2CE6CC0", VA = "0x2CE6CC0")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2CEED90", Offset = "0x2CEED90", VA = "0x2CEED90")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2CEEEA8", Offset = "0x2CEEEA8", VA = "0x2CEEEA8")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2CEEFD4", Offset = "0x2CEEFD4", VA = "0x2CEEFD4")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2CEF114", Offset = "0x2CEF114", VA = "0x2CEF114")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2CEF25C", Offset = "0x2CEF25C", VA = "0x2CEF25C")]
	[BindableMethod]
	public Coroutine Play(SFXGroup SFX, Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2CF011C", Offset = "0x2CF011C", VA = "0x2CF011C")]
	private void EndAllStartJobs()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2CF01F0", Offset = "0x2CF01F0", VA = "0x2CF01F0")]
	private void EndAllEndJobs()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2CF02C4", Offset = "0x2CF02C4", VA = "0x2CF02C4")]
	public void StopAll()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2CF0384", Offset = "0x2CF0384", VA = "0x2CF0384")]
	public void SequenceEnd(AudioObject Audio, float RemainingTime)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2CED128", Offset = "0x2CED128", VA = "0x2CED128")]
	public void SequenceEnd(AudioObject Audio)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2CF04DC", Offset = "0x2CF04DC", VA = "0x2CF04DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A7F0", Offset = "0xF2A7F0")]
	private IEnumerator DelayedEndAudio(AudioObject Audio, float Duration)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2CF0584", Offset = "0x2CF0584", VA = "0x2CF0584")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A854", Offset = "0xF2A854")]
	private IEnumerator DelayedEndAudio(AudioObject Audio)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2CF0674", Offset = "0x2CF0674", VA = "0x2CF0674", Slot = "6")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xF2A8B8", Offset = "0xF2A8B8")]
	protected override IEnumerator VolumeFade(float Volume, float FadeDuration)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2CF0734", Offset = "0x2CF0734", VA = "0x2CF0734")]
	public SFXManager()
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xF28A84", Offset = "0xF28A84")]
public class SFXObject : ScriptableObject
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29838", Offset = "0xF29838")]
	public string SFXName;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29870", Offset = "0xF29870")]
	public SFXLayer[] SFXLayers;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF298A8", Offset = "0xF298A8")]
	public bool RandomizeVolume;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF298E0", Offset = "0xF298E0")]
	public float FixedVolume;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29918", Offset = "0xF29918")]
	public float MinVolume;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29950", Offset = "0xF29950")]
	public float MaxVolume;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29988", Offset = "0xF29988")]
	public bool RandomizePitch;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF299C0", Offset = "0xF299C0")]
	public float FixedPitch;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF299F8", Offset = "0xF299F8")]
	public float MinPitch;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29A30", Offset = "0xF29A30")]
	public float MaxPitch;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29A68", Offset = "0xF29A68")]
	public bool DelaySFX;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29AA0", Offset = "0xF29AA0")]
	public bool RandomizeDelay;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29AD8", Offset = "0xF29AD8")]
	public float FixedDelayTime;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29B10", Offset = "0xF29B10")]
	public float MinDelayTime;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29B48", Offset = "0xF29B48")]
	public float MaxDelayTime;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29B80", Offset = "0xF29B80")]
	public bool LimitPolyphony;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29BB8", Offset = "0xF29BB8")]
	public int MaxVoices;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29BF0", Offset = "0xF29BF0")]
	public float MinSeparation;

	[NonSerialized]
	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float LastPlayTimestamp;

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2CF1458", Offset = "0x2CF1458", VA = "0x2CF1458", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2CF14A0", Offset = "0x2CF14A0", VA = "0x2CF14A0")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2CF14A8", Offset = "0x2CF14A8", VA = "0x2CF14A8")]
	public SFXObject()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2CEF280", Offset = "0x2CEF280", VA = "0x2CEF280")]
	public float GetDelayDuration()
	{
		return default(float);
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2CF162C", Offset = "0x2CF162C", VA = "0x2CF162C")]
	public float GetVolumeMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2CF1648", Offset = "0x2CF1648", VA = "0x2CF1648")]
	public float GetPitchMultiplier()
	{
		return default(float);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2CEF2AC", Offset = "0x2CEF2AC", VA = "0x2CEF2AC")]
	public Coroutine Play(float DelayDuration)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2CEF328", Offset = "0x2CEF328", VA = "0x2CEF328")]
	public Coroutine Play(float DelayDuration, float Volume)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2CEF388", Offset = "0x2CEF388", VA = "0x2CEF388")]
	public Coroutine Play(float DelayDuration, float Volume, float Pitch)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2CEF4DC", Offset = "0x2CEF4DC", VA = "0x2CEF4DC")]
	public Coroutine Play(Vector3 Position, float DelayDuration, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2CEF598", Offset = "0x2CEF598", VA = "0x2CEF598")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2CEF638", Offset = "0x2CEF638", VA = "0x2CEF638")]
	public Coroutine Play(Vector3 Position, float DelayDuration, float Volume, float Pitch, [Optional] Transform Parent, bool IsGlobalPosition = true)
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xF28AF0", Offset = "0xF28AF0")]
public class Track : ScriptableObject
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D80", Offset = "0xF28D80")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioObject IntroAudio;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Length;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Overlap;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2CF1878", Offset = "0x2CF1878", VA = "0x2CF1878")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2CF1C1C", Offset = "0x2CF1C1C", VA = "0x2CF1C1C")]
		internal bool <PlayTrack>b__0()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29C28", Offset = "0xF29C28")]
	public string Name;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29C60", Offset = "0xF29C60")]
	public AudioClip Intro;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29C98", Offset = "0xF29C98")]
	public float IntroVolume;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29CD0", Offset = "0xF29CD0")]
	public float OverlapDuration;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29D08", Offset = "0xF29D08")]
	public Edition[] Editions;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public Coroutine DelayJob;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Edition CurrentEdition;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29D50", Offset = "0xF29D50")]
	private bool <IsOneShot>k__BackingField;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<AudioObject> ActiveAudio;

	[Token(Token = "0x1700000C")]
	public bool IsOneShot
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2CF1688", Offset = "0x2CF1688", VA = "0x2CF1688")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A91C", Offset = "0xF2A91C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2CF1690", Offset = "0x2CF1690", VA = "0x2CF1690")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A92C", Offset = "0xF2A92C")]
		private set
		{
		}
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2CF169C", Offset = "0x2CF169C", VA = "0x2CF169C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2CF16E4", Offset = "0x2CF16E4", VA = "0x2CF16E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2CF174C", Offset = "0x2CF174C", VA = "0x2CF174C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2CF1718", Offset = "0x2CF1718", VA = "0x2CF1718")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2CF1780", Offset = "0x2CF1780", VA = "0x2CF1780")]
	public Track()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2CE8D84", Offset = "0x2CE8D84", VA = "0x2CE8D84")]
	public void StopDelay()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2CE7BBC", Offset = "0x2CE7BBC", VA = "0x2CE7BBC")]
	public void PlayTrack(float FadeDuration = 0f, bool IsOneShot = false)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2CF19DC", Offset = "0x2CF19DC", VA = "0x2CF19DC")]
	public void SwitchEdition(int EditionIndex)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2CF1880", Offset = "0x2CF1880", VA = "0x2CF1880")]
	public void SwitchEdition(int EditionIndex, float FadeOverride)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2CF1B38", Offset = "0x2CF1B38", VA = "0x2CF1B38")]
	public void SwitchEdition(Edition DesiredEdition)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2CE8ECC", Offset = "0x2CE8ECC", VA = "0x2CE8ECC")]
	public void SwitchEdition(Edition DesiredEdition, float FadeOverride)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2CF1B74", Offset = "0x2CF1B74", VA = "0x2CF1B74")]
	public void Stop(AudioObject Audio)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2CF1BFC", Offset = "0x2CF1BFC", VA = "0x2CF1BFC")]
	public void StopTrack()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2CF1C08", Offset = "0x2CF1C08", VA = "0x2CF1C08")]
	public void StopTrack(float FadeDuration)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2CF1C10", Offset = "0x2CF1C10", VA = "0x2CF1C10")]
	public void StopTrack(bool FadeDuration)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2CE7F78", Offset = "0x2CE7F78", VA = "0x2CE7F78")]
	public void StopTrack(bool Fade, float FadeDuration)
	{
	}
}
namespace AMPInternal
{
	[Token(Token = "0x2000010")]
	public class AudioObject
	{
		[Token(Token = "0x200003F")]
		public enum SoundType
		{
			[Token(Token = "0x4000128")]
			Music,
			[Token(Token = "0x4000129")]
			SFX
		}

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource Source;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Coroutine FadeJob;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly SoundType AudioType;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float _AudioVolume;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _SourceVolume;

		[Token(Token = "0x1700000D")]
		public float length
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x2CE4D94", Offset = "0x2CE4D94", VA = "0x2CE4D94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700000E")]
		public float volume
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2CE4DF4", Offset = "0x2CE4DF4", VA = "0x2CE4DF4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2CE4DFC", Offset = "0x2CE4DFC", VA = "0x2CE4DFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float SourceVolume
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2CE4EA0", Offset = "0x2CE4EA0", VA = "0x2CE4EA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2CE4EA8", Offset = "0x2CE4EA8", VA = "0x2CE4EA8")]
			set
			{
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2CE4DC0", Offset = "0x2CE4DC0", VA = "0x2CE4DC0")]
		public AudioObject(SoundType AudioType)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2CE4EB8", Offset = "0x2CE4EB8", VA = "0x2CE4EB8")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2CE4ED4", Offset = "0x2CE4ED4", VA = "0x2CE4ED4")]
		public void UnPause()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2CE4EF0", Offset = "0x2CE4EF0", VA = "0x2CE4EF0")]
		public void Play()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2CE4F48", Offset = "0x2CE4F48", VA = "0x2CE4F48")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2CE4F78", Offset = "0x2CE4F78", VA = "0x2CE4F78")]
		public void StopFade()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public abstract class SoundManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000040")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28D90", Offset = "0xF28D90")]
		private sealed class <>c
		{
			[Token(Token = "0x400012A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400012B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__43_0;

			[Token(Token = "0x400012C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<float> <>9__43_1;

			[Token(Token = "0x400012D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Action <>9__43_2;

			[Token(Token = "0x400012E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Action <>9__43_3;

			[Token(Token = "0x400012F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Action<bool> <>9__43_4;

			[Token(Token = "0x60001BD")]
			[Address(RVA = "0x2CE62D8", Offset = "0x2CE62D8", VA = "0x2CE62D8")]
			public <>c()
			{
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2CE62E0", Offset = "0x2CE62E0", VA = "0x2CE62E0")]
			internal void <.ctor>b__43_0()
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x2CE62E4", Offset = "0x2CE62E4", VA = "0x2CE62E4")]
			internal void <.ctor>b__43_1(float x)
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x2CE62E8", Offset = "0x2CE62E8", VA = "0x2CE62E8")]
			internal void <.ctor>b__43_2()
			{
			}

			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x2CE62EC", Offset = "0x2CE62EC", VA = "0x2CE62EC")]
			internal void <.ctor>b__43_3()
			{
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2CE62F0", Offset = "0x2CE62F0", VA = "0x2CE62F0")]
			internal void <.ctor>b__43_4(bool x)
			{
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29D60", Offset = "0xF29D60")]
		public AudioMixerGroup Mixer;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xF29D98", Offset = "0xF29D98")]
		[SerializeField]
		private bool ScenePersistent;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF29DE4", Offset = "0xF29DE4")]
		private Transform <Parent>k__BackingField;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool _Paused;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool _Muted;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected float Volume;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action OnStateChange;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<float> OnVolumeChange;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action OnPause;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Action OnUnPause;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<bool> OnMuteChange;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<AudioObject> ActiveAudio;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected List<AudioObject> InactiveAudio;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Coroutine FadeJob;

		[Token(Token = "0x17000010")]
		public abstract AudioObject.SoundType ManagerType
		{
			[Token(Token = "0x6000104")]
			get;
		}

		[Token(Token = "0x17000011")]
		public Transform Parent
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2CE5338", Offset = "0x2CE5338", VA = "0x2CE5338")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A93C", Offset = "0xF2A93C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2CE5340", Offset = "0x2CE5340", VA = "0x2CE5340")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF2A94C", Offset = "0xF2A94C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool Paused
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2CE5348", Offset = "0x2CE5348", VA = "0x2CE5348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2CE5350", Offset = "0x2CE5350", VA = "0x2CE5350")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool Muted
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2CE5518", Offset = "0x2CE5518", VA = "0x2CE5518")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2CE5520", Offset = "0x2CE5520", VA = "0x2CE5520")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float MasterVolume
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2CE5708", Offset = "0x2CE5708", VA = "0x2CE5708")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2CE5710", Offset = "0x2CE5710", VA = "0x2CE5710")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public int CurrentAudioSourceCount
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2CE5870", Offset = "0x2CE5870", VA = "0x2CE5870")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2CE5760", Offset = "0x2CE5760", VA = "0x2CE5760")]
		private void FlushVolumeChange()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2CE58C0", Offset = "0x2CE58C0", VA = "0x2CE58C0")]
		[BindableMethod]
		public void RemoveInactive()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2CE5990", Offset = "0x2CE5990", VA = "0x2CE5990", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2CE5A7C", Offset = "0x2CE5A7C", VA = "0x2CE5A7C")]
		[BindableMethod]
		public void SetVolume(float Volume, float FadeDuration)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2CE5B50", Offset = "0x2CE5B50", VA = "0x2CE5B50")]
		[BindableMethod]
		public void SetVolume(float Volume)
		{
		}

		[Token(Token = "0x6000113")]
		protected abstract IEnumerator VolumeFade(float Volume, float FadeDuration);

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2CE5B08", Offset = "0x2CE5B08", VA = "0x2CE5B08")]
		protected void StopVolumeFade()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2CE5B94", Offset = "0x2CE5B94", VA = "0x2CE5B94")]
		public void StopAudio(AudioObject Audio)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2CE5450", Offset = "0x2CE5450", VA = "0x2CE5450")]
		[BindableMethod]
		public void Pause()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x2CE538C", Offset = "0x2CE538C", VA = "0x2CE538C")]
		[BindableMethod]
		public void UnPause()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2CE5630", Offset = "0x2CE5630", VA = "0x2CE5630")]
		[BindableMethod]
		public void Mute()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2CE555C", Offset = "0x2CE555C", VA = "0x2CE555C")]
		[BindableMethod]
		public void UnMute()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x2CE5C50", Offset = "0x2CE5C50", VA = "0x2CE5C50")]
		public AudioObject StartAudio(AudioClip Audio, bool Looping, bool AutoPlay = true)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x2CE5EB0", Offset = "0x2CE5EB0", VA = "0x2CE5EB0")]
		protected SoundManager()
		{
		}
	}
}
namespace AMPInternal.Coroutines.SFX
{
	[Token(Token = "0x2000012")]
	public sealed class WaitForUnpausedSeconds : CustomYieldInstruction
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float TimeRemaining;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private bool BypassPause;

		[Token(Token = "0x17000016")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x2CE51D4", Offset = "0x2CE51D4", VA = "0x2CE51D4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x2CE5194", Offset = "0x2CE5194", VA = "0x2CE5194")]
		public WaitForUnpausedSeconds(float Duration, bool BypassPause = false)
		{
		}
	}
	[Token(Token = "0x2000013")]
	public sealed class WaitForNextUnpausedFrame : CustomYieldInstruction
	{
		[Token(Token = "0x17000017")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x2CE5130", Offset = "0x2CE5130", VA = "0x2CE5130", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2CE518C", Offset = "0x2CE518C", VA = "0x2CE518C")]
		public WaitForNextUnpausedFrame()
		{
		}
	}
}
namespace AMPInternal.Coroutines.Music
{
	[Token(Token = "0x2000014")]
	public sealed class WaitForUnpausedSeconds : CustomYieldInstruction
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float TimeRemaining;

		[Token(Token = "0x17000018")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x2CE50A0", Offset = "0x2CE50A0", VA = "0x2CE50A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2CE506C", Offset = "0x2CE506C", VA = "0x2CE506C")]
		public WaitForUnpausedSeconds(float Duration)
		{
		}
	}
	[Token(Token = "0x2000015")]
	public sealed class WaitForNextUnpausedFrame : CustomYieldInstruction
	{
		[Token(Token = "0x17000019")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x2CE5008", Offset = "0x2CE5008", VA = "0x2CE5008", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2CE5064", Offset = "0x2CE5064", VA = "0x2CE5064")]
		public WaitForNextUnpausedFrame()
		{
		}
	}
}
namespace AMPInternal.Utilities
{
	[Token(Token = "0x2000016")]
	public static class StringFormatting
	{
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2CE6400", Offset = "0x2CE6400", VA = "0x2CE6400")]
		public static string FormatTime(float Duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000017")]
	public static class NumberManipulation
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2CE62F4", Offset = "0x2CE62F4", VA = "0x2CE62F4")]
		public static float DecimalPlaces(float Number, int dp)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000018")]
	public static class ListExtension
	{
		[Token(Token = "0x6000126")]
		public static int RandomIndex<T>(this List<T> Arr)
		{
			return default(int);
		}

		[Token(Token = "0x6000127")]
		public static T RandomElement<T>(this List<T> Arr)
		{
			return (T)null;
		}

		[Token(Token = "0x6000128")]
		public static T Pop<T>(this List<T> Arr, int Index)
		{
			return (T)null;
		}

		[Token(Token = "0x6000129")]
		public static T PopRandom<T>(this List<T> Arr)
		{
			return (T)null;
		}

		[Token(Token = "0x600012A")]
		public static void Randomize<T>(this List<T> Arr)
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class IEnumerableExtension
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF28DA0", Offset = "0xF28DA0")]
		private sealed class <>c__DisplayClass0_0<TSource, TID>
		{
			[Token(Token = "0x4000130")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HashSet<TID> KnownIDs;

			[Token(Token = "0x4000131")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Func<TSource, TID> IDSelector;

			[Token(Token = "0x60001C3")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60001C4")]
			internal bool <DistinctBy>b__0(TSource x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600012B")]
		public static IEnumerable<TSource> DistinctBy<TSource, TID>(this IEnumerable<TSource> Arr, Func<TSource, TID> IDSelector)
		{
			return null;
		}
	}
}
namespace AMPInternal.EventBinding
{
	[Serializable]
	[Token(Token = "0x200001A")]
	public class UnityObjectEvent : UnityEvent<object>
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2CE52E8", Offset = "0x2CE52E8", VA = "0x2CE52E8")]
		public UnityObjectEvent()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xF28B7C", Offset = "0xF28B7C")]
	public sealed class BindableMethod : Attribute
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2CE526C", Offset = "0x2CE526C", VA = "0x2CE526C")]
		public BindableMethod()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001C")]
	public class BindedEvent
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EventTriggerType EventTrigger;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityObjectEvent EventCallback;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type ManagerType;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2CE5274", Offset = "0x2CE5274", VA = "0x2CE5274")]
		public BindedEvent(string Name, EventTriggerType Trigger, UnityObjectEvent Callback, Type ManagerType)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2CE496C", Offset = "0x2CE496C", VA = "0x2CE496C")]
		public void Execute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public enum EventTriggerType
	{
		[Token(Token = "0x4000088")]
		None,
		[Token(Token = "0x4000089")]
		Start,
		[Token(Token = "0x400008A")]
		OnEnable,
		[Token(Token = "0x400008B")]
		OnDisable,
		[Token(Token = "0x400008C")]
		OnCollisionEnter,
		[Token(Token = "0x400008D")]
		OnCollisionEnter2D,
		[Token(Token = "0x400008E")]
		OnTriggerEnter,
		[Token(Token = "0x400008F")]
		OnTriggerEnter2D,
		[Token(Token = "0x4000090")]
		OnCollisionExit,
		[Token(Token = "0x4000091")]
		OnCollisionExit2D,
		[Token(Token = "0x4000092")]
		OnTriggerExit,
		[Token(Token = "0x4000093")]
		OnTriggerExit2D,
		[Token(Token = "0x4000094")]
		OnMouseDown,
		[Token(Token = "0x4000095")]
		OnMouseEnter,
		[Token(Token = "0x4000096")]
		OnMouseExit,
		[Token(Token = "0x4000097")]
		OnMouseUp
	}
}
