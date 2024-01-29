using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AudioLoaderOptimizer
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x120C7E8", Offset = "0x120C7E8", VA = "0x120C7E8")]
	public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x120E2C4", Offset = "0x120E2C4", VA = "0x120E2C4")]
	public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x120ECB0", Offset = "0x120ECB0", VA = "0x120ECB0")]
	public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF68D8", Offset = "0xCF68D8")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x17000001")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x289B804", Offset = "0x289B804", VA = "0x289B804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x289DBC4", Offset = "0x289DBC4", VA = "0x289DBC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x289D6D4", Offset = "0x289D6D4", VA = "0x289D6D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x289B3E8", Offset = "0x289B3E8", VA = "0x289B3E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x289BE40", Offset = "0x289BE40", VA = "0x289BE40")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x289C22C", Offset = "0x289C22C", VA = "0x289C22C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x289C8B4", Offset = "0x289C8B4", VA = "0x289C8B4")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x289E0B8", Offset = "0x289E0B8", VA = "0x289E0B8")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000004")]
public static class OculusAudioHelper
{
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x289E1A8", Offset = "0x289E1A8", VA = "0x289E1A8")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x289E3DC", Offset = "0x289E3DC", VA = "0x289E3DC")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x289E61C", Offset = "0x289E61C", VA = "0x289E61C")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x289E84C", Offset = "0x289E84C", VA = "0x289E84C")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x289EA74", Offset = "0x289EA74", VA = "0x289EA74")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x289ECBC", Offset = "0x289ECBC", VA = "0x289ECBC")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x289EF04", Offset = "0x289EF04", VA = "0x289EF04")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x289A770", Offset = "0x289A770", VA = "0x289A770")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x289F41C", Offset = "0x289F41C", VA = "0x289F41C")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x289F650", Offset = "0x289F650", VA = "0x289F650")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x289F890", Offset = "0x289F890", VA = "0x289F890")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x289FAC0", Offset = "0x289FAC0", VA = "0x289FAC0")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x289FCF0", Offset = "0x289FCF0", VA = "0x289FCF0")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x289FF38", Offset = "0x289FF38", VA = "0x289FF38")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x28A0180", Offset = "0x28A0180", VA = "0x28A0180")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000006")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6DF4", Offset = "0xCF6DF4")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _soundType;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _variationName;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _willFollowSource;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _isInsideTrigger;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool _hasPlayedSound;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool _groupLoadFailed;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MasterAudioGroup _groupToPlay;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _playVolume;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float _exitFadeTime;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly List<Collider2D> _actorColliders2D;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<Collider2D, Vector3> _lastPositionByCollider2D;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000005")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x28A0D64", Offset = "0x28A0D64", VA = "0x28A0D64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x28A9D50", Offset = "0x28A9D50", VA = "0x28A9D50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x28ADA28", Offset = "0x28ADA28", VA = "0x28ADA28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x28A03C8", Offset = "0x28A03C8", VA = "0x28A03C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x28A13A4", Offset = "0x28A13A4", VA = "0x28A13A4")]
	private void Start()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x28A1684", Offset = "0x28A1684", VA = "0x28A1684")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x28A2428", Offset = "0x28A2428", VA = "0x28A2428")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x28A99C8", Offset = "0x28A99C8", VA = "0x28A99C8")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x28AA248", Offset = "0x28AA248", VA = "0x28AA248")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x28AC8E4", Offset = "0x28AC8E4", VA = "0x28AC8E4")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x28A542C", Offset = "0x28A542C", VA = "0x28A542C")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x28ADF1C", Offset = "0x28ADF1C", VA = "0x28ADF1C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x28AF15C", Offset = "0x28AF15C", VA = "0x28AF15C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x28A1A00", Offset = "0x28A1A00", VA = "0x28A1A00")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x28AF8E0", Offset = "0x28AF8E0", VA = "0x28AF8E0")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF68EC", Offset = "0xCF68EC")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x289F14C", Offset = "0x289F14C", VA = "0x289F14C")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF6900", Offset = "0xCF6900")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x289F23C", Offset = "0x289F23C", VA = "0x289F23C")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xCF6914", Offset = "0xCF6914")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x289F32C", Offset = "0x289F32C", VA = "0x289F32C")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCF6928", Offset = "0xCF6928")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6928", Offset = "0xCF6928")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6E3C", Offset = "0xCF6E3C")]
		public bool FollowCaller;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6E74", Offset = "0xCF6E74")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6EAC", Offset = "0xCF6EAC")]
		public Transform RuntimeFollower;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000008")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x12119BC", Offset = "0x12119BC", VA = "0x12119BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public Transform Trans
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1211D1C", Offset = "0x1211D1C", VA = "0x1211D1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x120F404", Offset = "0x120F404", VA = "0x120F404")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1210AB4", Offset = "0x1210AB4", VA = "0x1210AB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1212210", Offset = "0x1212210", VA = "0x1212210")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1212938", Offset = "0x1212938", VA = "0x1212938")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1213B04", Offset = "0x1213B04", VA = "0x1213B04")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1214CB4", Offset = "0x1214CB4", VA = "0x1214CB4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1215E88", Offset = "0x1215E88", VA = "0x1215E88")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x120F6AC", Offset = "0x120F6AC", VA = "0x120F6AC")]
		private void StartTrackers()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x121A344", Offset = "0x121A344", VA = "0x121A344")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCF6978", Offset = "0xCF6978")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000030")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x4000031")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x124689C", Offset = "0x124689C", VA = "0x124689C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1247F64", Offset = "0x1247F64", VA = "0x1247F64")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1249C88", Offset = "0x1249C88", VA = "0x1249C88")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x124A124", Offset = "0x124A124", VA = "0x124A124")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x124CE48", Offset = "0x124CE48", VA = "0x124CE48")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF69B0", Offset = "0xCF69B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCF69B0", Offset = "0xCF69B0")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000051")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x4000424")]
			Legacy,
			[Token(Token = "0x4000425")]
			uGUI
		}

		[Token(Token = "0x2000052")]
		public enum EventType
		{
			[Token(Token = "0x4000427")]
			OnStart,
			[Token(Token = "0x4000428")]
			OnVisible,
			[Token(Token = "0x4000429")]
			OnInvisible,
			[Token(Token = "0x400042A")]
			OnCollision,
			[Token(Token = "0x400042B")]
			OnTriggerEnter,
			[Token(Token = "0x400042C")]
			OnTriggerExit,
			[Token(Token = "0x400042D")]
			OnMouseEnter,
			[Token(Token = "0x400042E")]
			OnMouseClick,
			[Token(Token = "0x400042F")]
			OnSpawned,
			[Token(Token = "0x4000430")]
			OnDespawned,
			[Token(Token = "0x4000431")]
			OnEnable,
			[Token(Token = "0x4000432")]
			OnDisable,
			[Token(Token = "0x4000433")]
			OnCollision2D,
			[Token(Token = "0x4000434")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000435")]
			OnTriggerExit2D,
			[Token(Token = "0x4000436")]
			OnParticleCollision,
			[Token(Token = "0x4000437")]
			UserDefinedEvent,
			[Token(Token = "0x4000438")]
			OnCollisionExit,
			[Token(Token = "0x4000439")]
			OnCollisionExit2D,
			[Token(Token = "0x400043A")]
			OnMouseUp,
			[Token(Token = "0x400043B")]
			OnMouseExit,
			[Token(Token = "0x400043C")]
			OnMouseDrag,
			[Token(Token = "0x400043D")]
			NGUIOnClick,
			[Token(Token = "0x400043E")]
			NGUIMouseDown,
			[Token(Token = "0x400043F")]
			NGUIMouseUp,
			[Token(Token = "0x4000440")]
			NGUIMouseEnter,
			[Token(Token = "0x4000441")]
			NGUIMouseExit,
			[Token(Token = "0x4000442")]
			MechanimStateChanged,
			[Token(Token = "0x4000443")]
			UnitySliderChanged,
			[Token(Token = "0x4000444")]
			UnityButtonClicked,
			[Token(Token = "0x4000445")]
			UnityPointerDown,
			[Token(Token = "0x4000446")]
			UnityPointerUp,
			[Token(Token = "0x4000447")]
			UnityPointerEnter,
			[Token(Token = "0x4000448")]
			UnityPointerExit,
			[Token(Token = "0x4000449")]
			UnityDrag,
			[Token(Token = "0x400044A")]
			UnityDrop,
			[Token(Token = "0x400044B")]
			UnityScroll,
			[Token(Token = "0x400044C")]
			UnityUpdateSelected,
			[Token(Token = "0x400044D")]
			UnitySelect,
			[Token(Token = "0x400044E")]
			UnityDeselect,
			[Token(Token = "0x400044F")]
			UnityMove,
			[Token(Token = "0x4000450")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000451")]
			UnityBeginDrag,
			[Token(Token = "0x4000452")]
			UnityEndDrag,
			[Token(Token = "0x4000453")]
			UnitySubmit,
			[Token(Token = "0x4000454")]
			UnityCancel,
			[Token(Token = "0x4000455")]
			UnityToggle,
			[Token(Token = "0x4000456")]
			OnTriggerStay,
			[Token(Token = "0x4000457")]
			OnTriggerStay2D
		}

		[Token(Token = "0x2000053")]
		public enum GlidePitchType
		{
			[Token(Token = "0x4000459")]
			None,
			[Token(Token = "0x400045A")]
			RaisePitch,
			[Token(Token = "0x400045B")]
			LowerPitch
		}

		[Token(Token = "0x2000054")]
		public enum VariationType
		{
			[Token(Token = "0x400045D")]
			PlaySpecific,
			[Token(Token = "0x400045E")]
			PlayRandom
		}

		[Token(Token = "0x2000055")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000460")]
			None,
			[Token(Token = "0x4000461")]
			Stop,
			[Token(Token = "0x4000462")]
			FadeOut
		}

		[Token(Token = "0x2000056")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x4000464")]
			None,
			[Token(Token = "0x4000465")]
			FrameBased,
			[Token(Token = "0x4000466")]
			TimeBased
		}

		[Token(Token = "0x2000057")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BA4", Offset = "0xCF6BA4")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__1;

			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AudioEventGroup <chg>5__2;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool <matchState>5__3;

			[Token(Token = "0x170000B1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0xFDCD90", Offset = "0xFDCD90", VA = "0xFDCD90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xFDCF5C", Offset = "0xFDCF5C", VA = "0xFDCF5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xFDBC54", Offset = "0xFDBC54", VA = "0xFDBC54")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xFDBD54", Offset = "0xFDBD54", VA = "0xFDBD54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xFDBE34", Offset = "0xFDBE34", VA = "0xFDBE34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xFDCE7C", Offset = "0xFDCE7C", VA = "0xFDCE7C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BB4", Offset = "0xCF6BB4")]
		private sealed class <>c__DisplayClass175_0
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0xFDB85C", Offset = "0xFDB85C", VA = "0xFDB85C")]
			public <>c__DisplayClass175_0()
			{
			}

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0xFDB94C", Offset = "0xFDB94C", VA = "0xFDB94C")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x1700000A")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x12665EC", Offset = "0x12665EC", VA = "0x12665EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x1284338", Offset = "0x1284338", VA = "0x1284338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1265CD8", Offset = "0x1265CD8", VA = "0x1265CD8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1267838", Offset = "0x1267838", VA = "0x1267838", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x126848C", Offset = "0x126848C", VA = "0x126848C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7C30", Offset = "0xCF7C30")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x12685AC", Offset = "0x12685AC", VA = "0x12685AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x12707F8", Offset = "0x12707F8", VA = "0x12707F8")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1270C68", Offset = "0x1270C68", VA = "0x1270C68")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x12710C8", Offset = "0x12710C8", VA = "0x12710C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1272428", Offset = "0x1272428", VA = "0x1272428")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1274888", Offset = "0x1274888", VA = "0x1274888")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x127615C", Offset = "0x127615C", VA = "0x127615C")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x1276D98", Offset = "0x1276D98", VA = "0x1276D98")]
		private void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1277B58", Offset = "0x1277B58", VA = "0x1277B58")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x1278688", Offset = "0x1278688", VA = "0x1278688")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x1279158", Offset = "0x1279158", VA = "0x1279158")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1279C28", Offset = "0x1279C28", VA = "0x1279C28")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x127A6F8", Offset = "0x127A6F8", VA = "0x127A6F8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x127B1C8", Offset = "0x127B1C8", VA = "0x127B1C8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x127BE04", Offset = "0x127BE04", VA = "0x127BE04")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x127CBC4", Offset = "0x127CBC4", VA = "0x127CBC4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x127D6FC", Offset = "0x127D6FC", VA = "0x127D6FC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x127E1CC", Offset = "0x127E1CC", VA = "0x127E1CC")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x127E6A4", Offset = "0x127E6A4", VA = "0x127E6A4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x127EB7C", Offset = "0x127EB7C", VA = "0x127EB7C")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x127F054", Offset = "0x127F054", VA = "0x127F054")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x127F52C", Offset = "0x127F52C", VA = "0x127F52C")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x127F748", Offset = "0x127F748", VA = "0x127F748")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x127FC20", Offset = "0x127FC20", VA = "0x127FC20")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x127FE3C", Offset = "0x127FE3C", VA = "0x127FE3C")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1280314", Offset = "0x1280314", VA = "0x1280314")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x12807EC", Offset = "0x12807EC", VA = "0x12807EC")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1280CC4", Offset = "0x1280CC4", VA = "0x1280CC4")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1280EE4", Offset = "0x1280EE4", VA = "0x1280EE4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x12813B4", Offset = "0x12813B4", VA = "0x12813B4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x128188C", Offset = "0x128188C", VA = "0x128188C")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1281D64", Offset = "0x1281D64", VA = "0x1281D64")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x128223C", Offset = "0x128223C", VA = "0x128223C")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1282714", Offset = "0x1282714", VA = "0x1282714")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1282BEC", Offset = "0x1282BEC", VA = "0x1282BEC")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12830C4", Offset = "0x12830C4", VA = "0x12830C4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x128359C", Offset = "0x128359C", VA = "0x128359C")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1283A78", Offset = "0x1283A78", VA = "0x1283A78")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1283EE4", Offset = "0x1283EE4", VA = "0x1283EE4")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x12845B4", Offset = "0x12845B4", VA = "0x12845B4")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1284FF4", Offset = "0x1284FF4", VA = "0x1284FF4")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1285454", Offset = "0x1285454", VA = "0x1285454")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1285E94", Offset = "0x1285E94", VA = "0x1285E94")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x12863C4", Offset = "0x12863C4", VA = "0x12863C4")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x128681C", Offset = "0x128681C", VA = "0x128681C")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1286E88", Offset = "0x1286E88", VA = "0x1286E88")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1288250", Offset = "0x1288250", VA = "0x1288250")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x12895D4", Offset = "0x12895D4", VA = "0x12895D4")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x126F468", Offset = "0x126F468", VA = "0x126F468")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12A248C", Offset = "0x12A248C", VA = "0x12A248C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x12A32D4", Offset = "0x12A32D4", VA = "0x12A32D4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1289A8C", Offset = "0x1289A8C", VA = "0x1289A8C")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x128A2D4", Offset = "0x128A2D4", VA = "0x128A2D4")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x12A411C", Offset = "0x12A411C", VA = "0x12A411C")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1268A64", Offset = "0x1268A64", VA = "0x1268A64", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x12A5404", Offset = "0x12A5404", VA = "0x12A5404", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12A5F3C", Offset = "0x12A5F3C", VA = "0x12A5F3C", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1274384", Offset = "0x1274384", VA = "0x1274384", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1275C6C", Offset = "0x1275C6C", VA = "0x1275C6C", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x12A6894", Offset = "0x12A6894", VA = "0x12A6894", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1266868", Offset = "0x1266868", VA = "0x1266868")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x6000080")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12A6B8C", Offset = "0x12A6B8C", VA = "0x12A6B8C")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6EE4", Offset = "0xCF6EE4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF6EE4", Offset = "0xCF6EE4")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700000C")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xFE3984", Offset = "0xFE3984", VA = "0xFE3984")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7C94", Offset = "0xCF7C94")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xFE3B38", Offset = "0xFE3B38", VA = "0xFE3B38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CA4", Offset = "0xCF7CA4")]
			set
			{
			}
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFDD8D4", Offset = "0xFDD8D4", VA = "0xFDD8D4")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xFE1074", Offset = "0xFE1074", VA = "0xFE1074", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xFE1660", Offset = "0xFE1660", VA = "0xFE1660")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xFE174C", Offset = "0xFE174C", VA = "0xFE174C", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFE1D38", Offset = "0xFE1D38", VA = "0xFE1D38")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFE099C", Offset = "0xFE099C", VA = "0xFE099C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFE0F88", Offset = "0xFE0F88", VA = "0xFE0F88")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xFE1E24", Offset = "0xFE1E24", VA = "0xFE1E24", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xFE2410", Offset = "0xFE2410", VA = "0xFE2410")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xFDE774", Offset = "0xFDE774", VA = "0xFDE774", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xFDED60", Offset = "0xFDED60", VA = "0xFDED60")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFDEE4C", Offset = "0xFDEE4C", VA = "0xFDEE4C", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFDF438", Offset = "0xFDF438", VA = "0xFDF438")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFE24FC", Offset = "0xFE24FC", VA = "0xFE24FC", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFE2AE8", Offset = "0xFE2AE8", VA = "0xFE2AE8")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFE3CF8", Offset = "0xFE3CF8", VA = "0xFE3CF8", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFE42E4", Offset = "0xFE42E4", VA = "0xFE42E4")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xFE2BD4", Offset = "0xFE2BD4", VA = "0xFE2BD4", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xFE31C0", Offset = "0xFE31C0", VA = "0xFE31C0")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFDE09C", Offset = "0xFDE09C", VA = "0xFDE09C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFDE688", Offset = "0xFDE688", VA = "0xFDE688")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFE02C4", Offset = "0xFE02C4", VA = "0xFE02C4", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFE08B0", Offset = "0xFE08B0", VA = "0xFE08B0")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFDFBFC", Offset = "0xFDFBFC", VA = "0xFDFBFC", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFE01D8", Offset = "0xFE01D8", VA = "0xFE01D8")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFDD048", Offset = "0xFDD048", VA = "0xFDD048", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xFDD7E8", Offset = "0xFDD7E8", VA = "0xFDD7E8")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xFDF524", Offset = "0xFDF524", VA = "0xFDF524", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFDFB10", Offset = "0xFDFB10", VA = "0xFDFB10")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFE32AC", Offset = "0xFE32AC", VA = "0xFE32AC", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFE3898", Offset = "0xFE3898", VA = "0xFE3898")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFDD9C4", Offset = "0xFDD9C4", VA = "0xFDD9C4", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFDDFB0", Offset = "0xFDDFB0", VA = "0xFDDFB0")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xCF6A00", Offset = "0xCF6A00")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x2000059")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x400046F")]
			None,
			[Token(Token = "0x4000470")]
			OnCollision,
			[Token(Token = "0x4000471")]
			OnTriggerEnter,
			[Token(Token = "0x4000472")]
			OnCollision2D,
			[Token(Token = "0x4000473")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000D")]
		private Transform Trans
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xFF35A4", Offset = "0xFF35A4", VA = "0xFF35A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFEFD1C", Offset = "0xFEFD1C", VA = "0xFEFD1C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFF1EF0", Offset = "0xFF1EF0", VA = "0xFF1EF0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFF23D0", Offset = "0xFF23D0", VA = "0xFF23D0")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFF28B0", Offset = "0xFF28B0", VA = "0xFF28B0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFF2D90", Offset = "0xFF2D90", VA = "0xFF2D90")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFF01FC", Offset = "0xFF01FC", VA = "0xFF01FC")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFF59B0", Offset = "0xFF59B0", VA = "0xFF59B0")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6F20", Offset = "0xCF6F20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF6F20", Offset = "0xCF6F20")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6F80", Offset = "0xCF6F80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF6F80", Offset = "0xCF6F80")]
		public bool fireEnterEvent;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF6FF0", Offset = "0xCF6FF0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF6FF0", Offset = "0xCF6FF0")]
		public bool fireExitEvent;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7060", Offset = "0xCF7060")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF7060", Offset = "0xCF7060")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF70C0", Offset = "0xCF70C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF70C0", Offset = "0xCF70C0")]
		public float whenToFireEvent;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7124", Offset = "0xCF7124")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF7124", Offset = "0xCF7124")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF7184", Offset = "0xCF7184")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF719C", Offset = "0xCF719C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF719C", Offset = "0xCF719C")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF71F0", Offset = "0xCF71F0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF71F0", Offset = "0xCF71F0")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7244", Offset = "0xCF7244")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF7244", Offset = "0xCF7244")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7298", Offset = "0xCF7298")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF7298", Offset = "0xCF7298")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E11F74", Offset = "0x1E11F74", VA = "0x1E11F74", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E12D50", Offset = "0x1E12D50", VA = "0x1E12D50", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E15E4C", Offset = "0x1E15E4C", VA = "0x1E15E4C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1E127DC", Offset = "0x1E127DC", VA = "0x1E127DC")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E168E0", Offset = "0x1E168E0", VA = "0x1E168E0")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF72FC", Offset = "0xCF72FC")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7334", Offset = "0xCF7334")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF7334", Offset = "0xCF7334")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7394", Offset = "0xCF7394")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF7394", Offset = "0xCF7394")]
		public bool playEnterSound;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7404", Offset = "0xCF7404")]
		public string enterVariationName;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF743C", Offset = "0xCF743C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF743C", Offset = "0xCF743C")]
		public bool playExitSound;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF74AC", Offset = "0xCF74AC")]
		public string exitVariationName;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF74E4", Offset = "0xCF74E4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF74E4", Offset = "0xCF74E4")]
		public bool playAnimTimeSound;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7544", Offset = "0xCF7544")]
		public bool useStopTime;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF757C", Offset = "0xCF757C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF757C", Offset = "0xCF757C")]
		public float whenToStartSound;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF75D0", Offset = "0xCF75D0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF75D0", Offset = "0xCF75D0")]
		public float whenToStopSound;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7634", Offset = "0xCF7634")]
		public string timedVariationName;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF766C", Offset = "0xCF766C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xCF766C", Offset = "0xCF766C")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF76CC", Offset = "0xCF76CC")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF76E4", Offset = "0xCF76E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF76E4", Offset = "0xCF76E4")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7738", Offset = "0xCF7738")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF7738", Offset = "0xCF7738")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF778C", Offset = "0xCF778C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF778C", Offset = "0xCF778C")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF77E0", Offset = "0xCF77E0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF77E0", Offset = "0xCF77E0")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xCF7844", Offset = "0xCF7844")]
		public string multiTimedVariationName;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E17080", Offset = "0x1E17080", VA = "0x1E17080", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E18DFC", Offset = "0x1E18DFC", VA = "0x1E18DFC", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E1FBEC", Offset = "0x1E1FBEC", VA = "0x1E1FBEC", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E18170", Offset = "0x1E18170", VA = "0x1E18170")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E186E4", Offset = "0x1E186E4", VA = "0x1E186E4")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E21830", Offset = "0x1E21830", VA = "0x1E21830")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF787C", Offset = "0xCF787C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF787C", Offset = "0xCF787C")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF78B8", Offset = "0xCF78B8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF78B8", Offset = "0xCF78B8")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF78F4", Offset = "0xCF78F4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF78F4", Offset = "0xCF78F4")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700000E")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x1E30FD4", Offset = "0x1E30FD4", VA = "0x1E30FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CB4", Offset = "0xCF7CB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1E31198", Offset = "0x1E31198", VA = "0x1E31198")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CC4", Offset = "0xCF7CC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x1E31364", Offset = "0x1E31364", VA = "0x1E31364")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CD4", Offset = "0xCF7CD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1E31528", Offset = "0x1E31528", VA = "0x1E31528")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CE4", Offset = "0xCF7CE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1E316F4", Offset = "0x1E316F4", VA = "0x1E316F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7CF4", Offset = "0xCF7CF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1E318A8", Offset = "0x1E318A8", VA = "0x1E318A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D04", Offset = "0xCF7D04")]
			set
			{
			}
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E30A88", Offset = "0x1E30A88", VA = "0x1E30A88")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class AudioEvent
	{
		[Token(Token = "0x200005A")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000475")]
			UseSliderValue,
			[Token(Token = "0x4000476")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x200005B")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1223268", Offset = "0x1223268", VA = "0x1223268")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000011")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1221894", Offset = "0x1221894", VA = "0x1221894")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1221FB8", Offset = "0x1221FB8", VA = "0x1221FB8")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x122362C", Offset = "0x122362C", VA = "0x122362C")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x123CC64", Offset = "0x123CC64", VA = "0x123CC64")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000025")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1246374", Offset = "0x1246374", VA = "0x1246374")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000026")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1246668", Offset = "0x1246668", VA = "0x1246668")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000027")]
	public class CustomEvent
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x124E16C", Offset = "0x124E16C", VA = "0x124E16C")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000028")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x124E840", Offset = "0x124E840", VA = "0x124E840")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x124EC04", Offset = "0x124EC04", VA = "0x124EC04")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1250F20", Offset = "0x1250F20", VA = "0x1250F20")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF7930", Offset = "0xCF7930")]
		public int probabilityToPlay;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useIntroSilence;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float introSilenceMin;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float introSilenceMax;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform _trans;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioSource _aud;

		[Token(Token = "0x17000012")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x12512E8", Offset = "0x12512E8", VA = "0x12512E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x125183C", Offset = "0x125183C", VA = "0x125183C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x1251DA0", Offset = "0x1251DA0", VA = "0x1251DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x1252304", Offset = "0x1252304", VA = "0x1252304")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1252868", Offset = "0x1252868", VA = "0x1252868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1252DCC", Offset = "0x1252DCC", VA = "0x1252DCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1253330", Offset = "0x1253330", VA = "0x1253330")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public Transform Trans
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1253DA0", Offset = "0x1253DA0", VA = "0x1253DA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x12542FC", Offset = "0x12542FC", VA = "0x12542FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1255A90", Offset = "0x1255A90", VA = "0x1255A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1255FF4", Offset = "0x1255FF4", VA = "0x1255FF4")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string comments;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool logSound;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int busIndex;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float spatialBlend;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isExistingBus;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int limitPerXFrames;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float minimumTimeBetween;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool limitPolyphony;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int voiceLimitCount;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float despawnFadeTime;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1256AE4", Offset = "0x1256AE4", VA = "0x1256AE4")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class FootstepGroup
	{
		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xFEF460", Offset = "0xFEF460", VA = "0xFEF460")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002E")]
	public class GroupBus
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x1700001C")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xFF6710", Offset = "0xFF6710", VA = "0xFF6710")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001D")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xFF6A08", Offset = "0xFF6A08", VA = "0xFF6A08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001E")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xFF6E8C", Offset = "0xFF6E8C", VA = "0xFF6E8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xFF7108", Offset = "0xFF7108", VA = "0xFF7108")]
			set
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xFF5F0C", Offset = "0xFF5F0C", VA = "0xFF5F0C")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xFF640C", Offset = "0xFF640C", VA = "0xFF640C")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xFF738C", Offset = "0xFF738C", VA = "0xFF738C")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xFF7B6C", Offset = "0xFF7B6C", VA = "0xFF7B6C")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFF7E60", Offset = "0xFF7E60", VA = "0xFF7E60")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x60000E0")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x60000E1")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60000E2")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60000E3")]
		void RegisterReceiver();

		[Token(Token = "0x60000E4")]
		void UnregisterReceiver();

		[Token(Token = "0x60000E5")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x2000032")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x400047A")]
			None,
			[Token(Token = "0x400047B")]
			Stop,
			[Token(Token = "0x400047C")]
			FadeOut
		}

		[Token(Token = "0x200005D")]
		public enum VariationSequence
		{
			[Token(Token = "0x400047E")]
			Randomized,
			[Token(Token = "0x400047F")]
			TopToBottom
		}

		[Token(Token = "0x200005E")]
		public enum VariationMode
		{
			[Token(Token = "0x4000481")]
			Normal,
			[Token(Token = "0x4000482")]
			LoopedChain,
			[Token(Token = "0x4000483")]
			Dialog
		}

		[Token(Token = "0x200005F")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000485")]
			Endless,
			[Token(Token = "0x4000486")]
			NumberOfLoops
		}

		[Token(Token = "0x2000060")]
		public enum LimitMode
		{
			[Token(Token = "0x4000488")]
			None,
			[Token(Token = "0x4000489")]
			FrameBased,
			[Token(Token = "0x400048A")]
			TimeBased
		}

		[Token(Token = "0x40001DF")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x40001E0")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x40001E1")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7984", Offset = "0xCF7984")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF7984", Offset = "0xCF7984")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700001F")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1E0817C", Offset = "0x1E0817C", VA = "0x1E0817C")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x17000020")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1E0DA84", Offset = "0x1E0DA84", VA = "0x1E0DA84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1E0E218", Offset = "0x1E0E218", VA = "0x1E0E218")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public int TotalVoices
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1E0E580", Offset = "0x1E0E580", VA = "0x1E0E580")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1E0E8E4", Offset = "0x1E0E8E4", VA = "0x1E0E8E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1E0BBCC", Offset = "0x1E0BBCC", VA = "0x1E0BBCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x1E0EB6C", Offset = "0x1E0EB6C", VA = "0x1E0EB6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x1E0EDE0", Offset = "0x1E0EDE0", VA = "0x1E0EDE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1E0F064", Offset = "0x1E0F064", VA = "0x1E0F064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1E0FD90", Offset = "0x1E0FD90", VA = "0x1E0FD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D34", Offset = "0xCF7D34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1E0FF44", Offset = "0x1E0FF44", VA = "0x1E0FF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D44", Offset = "0xCF7D44")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public string GameObjectName
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1E1010C", Offset = "0x1E1010C", VA = "0x1E1010C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1E10638", Offset = "0x1E10638", VA = "0x1E10638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform Trans
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x1E08F28", Offset = "0x1E08F28", VA = "0x1E08F28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x1E0A0A8", Offset = "0x1E0A0A8", VA = "0x1E0A0A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1E07EAC", Offset = "0x1E07EAC", VA = "0x1E07EAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D14", Offset = "0xCF7D14")]
			add
			{
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1E08014", Offset = "0x1E08014", VA = "0x1E08014")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D24", Offset = "0xCF7D24")]
			remove
			{
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1E09484", Offset = "0x1E09484", VA = "0x1E09484")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1E0A680", Offset = "0x1E0A680", VA = "0x1E0A680")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1E0B2BC", Offset = "0x1E0B2BC", VA = "0x1E0B2BC")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1E0D3E8", Offset = "0x1E0D3E8", VA = "0x1E0D3E8")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1E0F378", Offset = "0x1E0F378", VA = "0x1E0F378")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1E0F7D4", Offset = "0x1E0F7D4", VA = "0x1E0F7D4")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1E0FB20", Offset = "0x1E0FB20", VA = "0x1E0FB20")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1E10958", Offset = "0x1E10958", VA = "0x1E10958")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1E11E84", Offset = "0x1E11E84", VA = "0x1E11E84")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class MusicSetting
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BC4", Offset = "0xCF6BC4")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1E26458", Offset = "0x1E26458", VA = "0x1E26458")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1E26818", Offset = "0x1E26818", VA = "0x1E26818")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BD4", Offset = "0xCF6BD4")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1E26548", Offset = "0x1E26548", VA = "0x1E26548")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1E26B30", Offset = "0x1E26B30", VA = "0x1E26B30")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000063")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BE4", Offset = "0xCF6BE4")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1E26638", Offset = "0x1E26638", VA = "0x1E26638")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1E26E48", Offset = "0x1E26E48", VA = "0x1E26E48")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000064")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6BF4", Offset = "0xCF6BF4")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1E26728", Offset = "0x1E26728", VA = "0x1E26728")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1E27160", Offset = "0x1E27160", VA = "0x1E27160")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700002C")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x1E22E5C", Offset = "0x1E22E5C", VA = "0x1E22E5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x1E23140", Offset = "0x1E23140", VA = "0x1E23140")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public float SongStartTime
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x1E23610", Offset = "0x1E23610", VA = "0x1E23610")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1E22154", Offset = "0x1E22154", VA = "0x1E22154")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1E23A94", Offset = "0x1E23A94", VA = "0x1E23A94")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1E27478", Offset = "0x1E27478", VA = "0x1E27478")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1E31A68", Offset = "0x1E31A68", VA = "0x1E31A68")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x28458A8", Offset = "0x28458A8", VA = "0x28458A8")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2845D78", Offset = "0x2845D78", VA = "0x2845D78")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2846248", Offset = "0x2846248", VA = "0x2846248")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x2000065")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000490")]
			Boolean,
			[Token(Token = "0x4000491")]
			String,
			[Token(Token = "0x4000492")]
			Integer,
			[Token(Token = "0x4000493")]
			Float
		}

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2846718", Offset = "0x2846718", VA = "0x2846718")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2846D58", Offset = "0x2846D58", VA = "0x2846D58")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2847228", Offset = "0x2847228", VA = "0x2847228")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6A48", Offset = "0xCF6A48")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCF6A48", Offset = "0xCF6A48")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000066")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000067")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000068")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x287E0C8", Offset = "0x287E0C8", VA = "0x287E0C8")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000069")]
		public enum PitchMode
		{
			[Token(Token = "0x40004A0")]
			None,
			[Token(Token = "0x40004A1")]
			Gliding
		}

		[Token(Token = "0x200006A")]
		public enum FadeMode
		{
			[Token(Token = "0x40004A3")]
			None,
			[Token(Token = "0x40004A4")]
			FadeInOut,
			[Token(Token = "0x40004A5")]
			FadeOutEarly,
			[Token(Token = "0x40004A6")]
			GradualFade
		}

		[Token(Token = "0x200006B")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x40004A8")]
			AddToClipPitch,
			[Token(Token = "0x40004A9")]
			IgnoreClipPitch
		}

		[Token(Token = "0x200006C")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x40004AB")]
			AddToClipVolume,
			[Token(Token = "0x40004AC")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200006D")]
		public enum DetectEndMode
		{
			[Token(Token = "0x40004AE")]
			None,
			[Token(Token = "0x40004AF")]
			DetectEnd
		}

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xCF79C0", Offset = "0xCF79C0")]
		public int probabilityToPlay;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_pitch;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_volume;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool isExpanded;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool isChecked;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool useFades;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeInTime;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeOutTime;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useCustomLooping;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int minCustomLoops;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int maxCustomLoops;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useIntroSilence;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float introSilenceMin;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMax;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeMaxVolume;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FadeMode curFadeMode;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PitchMode curPitchMode;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int frames;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _maxVol;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _instanceId;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool? _audioLoops;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _maxLoops;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _soundGroupName;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _isPaused;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _trans;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject _go;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _attachToSource;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private string _resFileName;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7A50", Offset = "0xCF7A50")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF7A50", Offset = "0xCF7A50")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x1700002F")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x287589C", Offset = "0x287589C", VA = "0x287589C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x2875E00", Offset = "0x2875E00", VA = "0x2875E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x2876364", Offset = "0x2876364", VA = "0x2876364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x28768C8", Offset = "0x28768C8", VA = "0x28768C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x28528AC", Offset = "0x28528AC", VA = "0x28528AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x2876E2C", Offset = "0x2876E2C", VA = "0x2876E2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x28770B0", Offset = "0x28770B0", VA = "0x28770B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x2860AD8", Offset = "0x2860AD8", VA = "0x2860AD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x2877614", Offset = "0x2877614", VA = "0x2877614")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x2874C8C", Offset = "0x2874C8C", VA = "0x2874C8C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x2878568", Offset = "0x2878568", VA = "0x2878568")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x28788BC", Offset = "0x28788BC", VA = "0x28788BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x284C060", Offset = "0x284C060", VA = "0x284C060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x285AB68", Offset = "0x285AB68", VA = "0x285AB68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x287A048", Offset = "0x287A048", VA = "0x287A048")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x287A58C", Offset = "0x287A58C", VA = "0x287A58C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x287AAC8", Offset = "0x287AAC8", VA = "0x287AAC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x287B2C0", Offset = "0x287B2C0", VA = "0x287B2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D94", Offset = "0xCF7D94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x287B484", Offset = "0x287B484", VA = "0x287B484")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7DA4", Offset = "0xCF7DA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2866E48", Offset = "0x2866E48", VA = "0x2866E48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public int InstanceId
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2860620", Offset = "0x2860620", VA = "0x2860620")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000040")]
		public Transform Trans
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x286D998", Offset = "0x286D998", VA = "0x286D998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public GameObject GameObj
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x284A5E8", Offset = "0x284A5E8", VA = "0x284A5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x284A084", Offset = "0x284A084", VA = "0x284A084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public bool AudioLoops
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x285FF5C", Offset = "0x285FF5C", VA = "0x285FF5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public string ResFileName
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x285D184", Offset = "0x285D184", VA = "0x285D184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2850C40", Offset = "0x2850C40", VA = "0x2850C40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x287B64C", Offset = "0x287B64C", VA = "0x287B64C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x287B8B8", Offset = "0x287B8B8", VA = "0x287B8B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x287BB48", Offset = "0x287BB48", VA = "0x287BB48")]
			set
			{
			}
		}

		[Token(Token = "0x17000048")]
		public int MaxLoops
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x287BDD8", Offset = "0x287BDD8", VA = "0x287BDD8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000049")]
		private bool Is2D
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x287C044", Offset = "0x287C044", VA = "0x287C044")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x285A664", Offset = "0x285A664", VA = "0x285A664")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004B")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x2851888", Offset = "0x2851888", VA = "0x2851888")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool IsPaused
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x287C644", Offset = "0x287C644", VA = "0x287C644")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2848AC4", Offset = "0x2848AC4", VA = "0x2848AC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D54", Offset = "0xCF7D54")]
			add
			{
			}
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2848C30", Offset = "0x2848C30", VA = "0x2848C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D64", Offset = "0xCF7D64")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2848D9C", Offset = "0x2848D9C", VA = "0x2848D9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D74", Offset = "0xCF7D74")]
			add
			{
			}
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2848F08", Offset = "0x2848F08", VA = "0x2848F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7D84", Offset = "0xCF7D84")]
			remove
			{
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2849074", Offset = "0x2849074", VA = "0x2849074")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x284AB44", Offset = "0x284AB44", VA = "0x284AB44")]
		private void Start()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x284D288", Offset = "0x284D288", VA = "0x284D288")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x284DACC", Offset = "0x284DACC", VA = "0x284DACC")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x284CDD0", Offset = "0x284CDD0", VA = "0x284CDD0")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x284EF30", Offset = "0x284EF30", VA = "0x284EF30")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x284E5F0", Offset = "0x284E5F0", VA = "0x284E5F0")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2852B18", Offset = "0x2852B18", VA = "0x2852B18")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x28530F0", Offset = "0x28530F0", VA = "0x28530F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x28538A0", Offset = "0x28538A0", VA = "0x28538A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x28533C8", Offset = "0x28533C8", VA = "0x28533C8")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x28566C4", Offset = "0x28566C4", VA = "0x28566C4")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2859E58", Offset = "0x2859E58", VA = "0x2859E58")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x285D6F0", Offset = "0x285D6F0", VA = "0x285D6F0")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x285999C", Offset = "0x285999C", VA = "0x285999C")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x285DC34", Offset = "0x285DC34", VA = "0x285DC34")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x285E284", Offset = "0x285E284", VA = "0x285E284")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x285B0AC", Offset = "0x285B0AC", VA = "0x285B0AC")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2861530", Offset = "0x2861530", VA = "0x2861530")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2861A20", Offset = "0x2861A20", VA = "0x2861A20")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2864004", Offset = "0x2864004", VA = "0x2864004")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2864EB4", Offset = "0x2864EB4", VA = "0x2864EB4")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2866234", Offset = "0x2866234", VA = "0x2866234")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2867A24", Offset = "0x2867A24", VA = "0x2867A24")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x286A2BC", Offset = "0x286A2BC", VA = "0x286A2BC")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x285E564", Offset = "0x285E564", VA = "0x285E564")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x286D2D8", Offset = "0x286D2D8", VA = "0x286D2D8")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x286BA60", Offset = "0x286BA60", VA = "0x286BA60")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x2853B78", Offset = "0x2853B78", VA = "0x2853B78")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x286EF5C", Offset = "0x286EF5C", VA = "0x286EF5C")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x2872460", Offset = "0x2872460", VA = "0x2872460")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2873DF4", Offset = "0x2873DF4", VA = "0x2873DF4")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x2874660", Offset = "0x2874660", VA = "0x2874660")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2874EF8", Offset = "0x2874EF8", VA = "0x2874EF8")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2877968", Offset = "0x2877968", VA = "0x2877968")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x287C8C0", Offset = "0x287C8C0", VA = "0x287C8C0")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x285D964", Offset = "0x285D964", VA = "0x285D964")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x287CF90", Offset = "0x287CF90", VA = "0x287CF90")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6AC0", Offset = "0xCF6AC0")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200006E")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x40004B1")]
			None,
			[Token(Token = "0x40004B2")]
			Play,
			[Token(Token = "0x40004B3")]
			WaitForEnd,
			[Token(Token = "0x40004B4")]
			StopOrRepeat
		}

		[Token(Token = "0x4000288")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000289")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x1700004D")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x288C948", Offset = "0x288C948", VA = "0x288C948")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x287F4C8", Offset = "0x287F4C8", VA = "0x287F4C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public int FramesPlayed
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x286B7F4", Offset = "0x286B7F4", VA = "0x286B7F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x287C3B4", Offset = "0x287C3B4", VA = "0x287C3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x2898308", Offset = "0x2898308", VA = "0x2898308")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000052")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x2898928", Offset = "0x2898928", VA = "0x2898928")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000053")]
		private Transform Trans
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x2883E90", Offset = "0x2883E90", VA = "0x2883E90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x287EEF0", Offset = "0x287EEF0", VA = "0x287EEF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x2884468", Offset = "0x2884468", VA = "0x2884468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x287E98C", Offset = "0x287E98C", VA = "0x287E98C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x288C328", Offset = "0x288C328", VA = "0x288C328")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000058")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x2885D8C", Offset = "0x2885D8C", VA = "0x2885D8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0x2897DA0", Offset = "0x2897DA0", VA = "0x2897DA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x28637A0", Offset = "0x28637A0", VA = "0x28637A0")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x28715A8", Offset = "0x28715A8", VA = "0x28715A8")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x2872CC8", Offset = "0x2872CC8", VA = "0x2872CC8")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x286C648", Offset = "0x286C648", VA = "0x286C648")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x285EF48", Offset = "0x285EF48", VA = "0x285EF48")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2860D44", Offset = "0x2860D44", VA = "0x2860D44")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x286CDA4", Offset = "0x286CDA4", VA = "0x286CDA4")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x286E6F8", Offset = "0x286E6F8", VA = "0x286E6F8")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x286E34C", Offset = "0x286E34C", VA = "0x286E34C")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x2869EB0", Offset = "0x2869EB0", VA = "0x2869EB0")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x286DEF4", Offset = "0x286DEF4", VA = "0x286DEF4")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x2883738", Offset = "0x2883738", VA = "0x2883738")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x288022C", Offset = "0x288022C", VA = "0x288022C")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2884A40", Offset = "0x2884A40", VA = "0x2884A40")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2885098", Offset = "0x2885098", VA = "0x2885098")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2886118", Offset = "0x2886118", VA = "0x2886118")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x28864E4", Offset = "0x28864E4", VA = "0x28864E4")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x2880F50", Offset = "0x2880F50", VA = "0x2880F50")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x288D804", Offset = "0x288D804", VA = "0x288D804")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x288F0CC", Offset = "0x288F0CC", VA = "0x288F0CC")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2865EE0", Offset = "0x2865EE0", VA = "0x2865EE0")]
		public void Pause()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x28670D8", Offset = "0x28670D8", VA = "0x28670D8")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x28681A4", Offset = "0x28681A4", VA = "0x28681A4")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x288FC10", Offset = "0x288FC10", VA = "0x288FC10")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x28908A0", Offset = "0x28908A0", VA = "0x28908A0")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x289331C", Offset = "0x289331C", VA = "0x289331C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x28939E8", Offset = "0x28939E8", VA = "0x28939E8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x285119C", Offset = "0x285119C", VA = "0x285119C")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x2894004", Offset = "0x2894004", VA = "0x2894004")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2898F48", Offset = "0x2898F48", VA = "0x2898F48")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x40002BC")]
		private const int MaxPriority = 0;

		[Token(Token = "0x40002BD")]
		private const int HighestPriority = 16;

		[Token(Token = "0x40002BE")]
		private const int LowestPriority = 128;

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1224340", Offset = "0x1224340", VA = "0x1224340")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x122462C", Offset = "0x122462C", VA = "0x122462C")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1224918", Offset = "0x1224918", VA = "0x1224918")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1224C04", Offset = "0x1224C04", VA = "0x1224C04")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x2000040")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x200006F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C04", Offset = "0xCF6C04")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MusicSetting songSetting;

			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string songResourceName;

			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string playlistName;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public PlaylistController controller;

			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__1;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private AudioClip <resAudioClip>5__2;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003C9")]
				[Address(RVA = "0x1235984", Offset = "0x1235984", VA = "0x1235984", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003CB")]
				[Address(RVA = "0x1235B50", Offset = "0x1235B50", VA = "0x1235B50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x122DB94", Offset = "0x122DB94", VA = "0x122DB94")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x12343AC", Offset = "0x12343AC", VA = "0x12343AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x123448C", Offset = "0x123448C", VA = "0x123448C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1235A70", Offset = "0x1235A70", VA = "0x1235A70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C14", Offset = "0xCF6C14")]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action successAction;

			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AudioClip <internetClip>5__1;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<AudioSource> <sources>5__2;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private UnityWebRequest <www>5__3;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private string[] <urlParts>5__4;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <i>5__5;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private SoundGroupVariation <aVar>5__6;

			[Token(Token = "0x170000B5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D0")]
				[Address(RVA = "0x1239C28", Offset = "0x1239C28", VA = "0x1239C28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D2")]
				[Address(RVA = "0x1239DF4", Offset = "0x1239DF4", VA = "0x1239DF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x122DDC8", Offset = "0x122DDC8", VA = "0x122DDC8")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1235C3C", Offset = "0x1235C3C", VA = "0x1235C3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1235EA4", Offset = "0x1235EA4", VA = "0x1235EA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1235D44", Offset = "0x1235D44", VA = "0x1235D44")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1239D14", Offset = "0x1239D14", VA = "0x1239D14", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000071")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C24", Offset = "0xCF6C24")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action successAction;

			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__1;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AudioClip <resAudioClip>5__2;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private List<AudioSource> <sources>5__3;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private int <i>5__4;

			[Token(Token = "0x170000B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003D6")]
				[Address(RVA = "0x123C9AC", Offset = "0x123C9AC", VA = "0x123C9AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003D8")]
				[Address(RVA = "0x123CB78", Offset = "0x123CB78", VA = "0x123CB78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x122F308", Offset = "0x122F308", VA = "0x122F308")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1239EE0", Offset = "0x1239EE0", VA = "0x1239EE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1239FC0", Offset = "0x1239FC0", VA = "0x1239FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x123CA98", Offset = "0x123CA98", VA = "0x123CA98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x12271E0", Offset = "0x12271E0", VA = "0x12271E0")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x12275D0", Offset = "0x12275D0", VA = "0x12275D0")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1227E54", Offset = "0x1227E54", VA = "0x1227E54")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x122945C", Offset = "0x122945C", VA = "0x122945C")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x12281F4", Offset = "0x12281F4", VA = "0x12281F4")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x122BB3C", Offset = "0x122BB3C", VA = "0x122BB3C")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x122BDE0", Offset = "0x122BDE0", VA = "0x122BDE0")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x122D168", Offset = "0x122D168", VA = "0x122D168")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x122DA50", Offset = "0x122DA50", VA = "0x122DA50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7DB4", Offset = "0xCF7DB4")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x122DC94", Offset = "0x122DC94", VA = "0x122DC94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7E18", Offset = "0xCF7E18")]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x122DEC8", Offset = "0x122DEC8", VA = "0x122DEC8")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x122F1D4", Offset = "0x122F1D4", VA = "0x122F1D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7E7C", Offset = "0xCF7E7C")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x122F408", Offset = "0x122F408", VA = "0x122F408")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1230178", Offset = "0x1230178", VA = "0x1230178")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1231AE0", Offset = "0x1231AE0", VA = "0x1231AE0")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1232598", Offset = "0x1232598", VA = "0x1232598")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6AD4", Offset = "0xCF6AD4")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x40004D5")]
			StopSound,
			[Token(Token = "0x40004D6")]
			FadeSound
		}

		[Token(Token = "0x2000073")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x40004D8")]
			StopExistingSound,
			[Token(Token = "0x40004D9")]
			FadeInSameSound
		}

		[Token(Token = "0x2000074")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40004DB")]
			LateUpdate,
			[Token(Token = "0x40004DC")]
			FixedUpdate
		}

		[Token(Token = "0x2000075")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40004DE")]
			All,
			[Token(Token = "0x40004DF")]
			OneAtRandom
		}

		[Token(Token = "0x2000076")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40004E1")]
			AllGroups,
			[Token(Token = "0x40004E2")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000077")]
		public enum RaycastMode
		{
			[Token(Token = "0x40004E4")]
			Physics3D,
			[Token(Token = "0x40004E5")]
			Physics2D
		}

		[Token(Token = "0x2000078")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40004E7")]
			ForceAllTo2D,
			[Token(Token = "0x40004E8")]
			ForceAllTo3D,
			[Token(Token = "0x40004E9")]
			ForceAllToCustom,
			[Token(Token = "0x40004EA")]
			AllowDifferentPerController
		}

		[Token(Token = "0x2000079")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40004EC")]
			ForceAllTo2D,
			[Token(Token = "0x40004ED")]
			ForceAllTo3D,
			[Token(Token = "0x40004EE")]
			ForceAllToCustom,
			[Token(Token = "0x40004EF")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x200007A")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40004F1")]
			ForceTo2D,
			[Token(Token = "0x40004F2")]
			ForceTo3D,
			[Token(Token = "0x40004F3")]
			ForceToCustom,
			[Token(Token = "0x40004F4")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x200007B")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x40004F6")]
			Loading,
			[Token(Token = "0x40004F7")]
			Loaded,
			[Token(Token = "0x40004F8")]
			Failed
		}

		[Token(Token = "0x200007C")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40004FA")]
			Narrow,
			[Token(Token = "0x40004FB")]
			Normal,
			[Token(Token = "0x40004FC")]
			Wide
		}

		[Token(Token = "0x200007D")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40004FE")]
			Always,
			[Token(Token = "0x40004FF")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000500")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000501")]
			Never,
			[Token(Token = "0x4000502")]
			OnSameGameObject,
			[Token(Token = "0x4000503")]
			OnChildGameObject,
			[Token(Token = "0x4000504")]
			OnParentGameObject,
			[Token(Token = "0x4000505")]
			OnSameOrChildGameObject,
			[Token(Token = "0x4000506")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x200007E")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x4000508")]
			All,
			[Token(Token = "0x4000509")]
			Closest,
			[Token(Token = "0x400050A")]
			Random
		}

		[Token(Token = "0x200007F")]
		public enum AudioLocation
		{
			[Token(Token = "0x400050C")]
			Clip,
			[Token(Token = "0x400050D")]
			ResourceFile,
			[Token(Token = "0x400050E")]
			FileOnInternet
		}

		[Token(Token = "0x2000080")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x4000510")]
			Beginning,
			[Token(Token = "0x4000511")]
			SpecificTime,
			[Token(Token = "0x4000512")]
			RandomTime
		}

		[Token(Token = "0x2000081")]
		public enum BusCommand
		{
			[Token(Token = "0x4000514")]
			None,
			[Token(Token = "0x4000515")]
			FadeToVolume,
			[Token(Token = "0x4000516")]
			Mute,
			[Token(Token = "0x4000517")]
			Pause,
			[Token(Token = "0x4000518")]
			Solo,
			[Token(Token = "0x4000519")]
			Unmute,
			[Token(Token = "0x400051A")]
			Unpause,
			[Token(Token = "0x400051B")]
			Unsolo,
			[Token(Token = "0x400051C")]
			Stop,
			[Token(Token = "0x400051D")]
			ChangePitch,
			[Token(Token = "0x400051E")]
			ToggleMute,
			[Token(Token = "0x400051F")]
			StopBusOfTransform,
			[Token(Token = "0x4000520")]
			PauseBusOfTransform,
			[Token(Token = "0x4000521")]
			UnpauseBusOfTransform,
			[Token(Token = "0x4000522")]
			GlideByPitch,
			[Token(Token = "0x4000523")]
			StopOldBusVoices,
			[Token(Token = "0x4000524")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x2000082")]
		public enum DragGroupMode
		{
			[Token(Token = "0x4000526")]
			OneGroupPerClip,
			[Token(Token = "0x4000527")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000083")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x4000529")]
			PlaySound,
			[Token(Token = "0x400052A")]
			GroupControl,
			[Token(Token = "0x400052B")]
			BusControl,
			[Token(Token = "0x400052C")]
			PlaylistControl,
			[Token(Token = "0x400052D")]
			CustomEventControl,
			[Token(Token = "0x400052E")]
			GlobalControl,
			[Token(Token = "0x400052F")]
			UnityMixerControl,
			[Token(Token = "0x4000530")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000084")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000532")]
			UseDeviceSetting,
			[Token(Token = "0x4000533")]
			SpecificLanguage,
			[Token(Token = "0x4000534")]
			DynamicallySet
		}

		[Token(Token = "0x2000085")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x4000536")]
			None,
			[Token(Token = "0x4000537")]
			TransitionToSnapshot,
			[Token(Token = "0x4000538")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x2000086")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x400053A")]
			None,
			[Token(Token = "0x400053B")]
			ChangePlaylist,
			[Token(Token = "0x400053C")]
			FadeToVolume,
			[Token(Token = "0x400053D")]
			PlaySong,
			[Token(Token = "0x400053E")]
			PlayRandomSong,
			[Token(Token = "0x400053F")]
			PlayNextSong,
			[Token(Token = "0x4000540")]
			Pause,
			[Token(Token = "0x4000541")]
			Resume,
			[Token(Token = "0x4000542")]
			Stop,
			[Token(Token = "0x4000543")]
			Mute,
			[Token(Token = "0x4000544")]
			Unmute,
			[Token(Token = "0x4000545")]
			ToggleMute,
			[Token(Token = "0x4000546")]
			Restart,
			[Token(Token = "0x4000547")]
			Start,
			[Token(Token = "0x4000548")]
			StopLoopingCurrentSong,
			[Token(Token = "0x4000549")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x400054A")]
			AddSongToQueue
		}

		[Token(Token = "0x2000087")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x400054C")]
			None,
			[Token(Token = "0x400054D")]
			FireEvent
		}

		[Token(Token = "0x2000088")]
		public enum GlobalCommand
		{
			[Token(Token = "0x400054F")]
			None,
			[Token(Token = "0x4000550")]
			PauseMixer,
			[Token(Token = "0x4000551")]
			UnpauseMixer,
			[Token(Token = "0x4000552")]
			StopMixer,
			[Token(Token = "0x4000553")]
			StopEverything,
			[Token(Token = "0x4000554")]
			PauseEverything,
			[Token(Token = "0x4000555")]
			UnpauseEverything,
			[Token(Token = "0x4000556")]
			MuteEverything,
			[Token(Token = "0x4000557")]
			UnmuteEverything,
			[Token(Token = "0x4000558")]
			SetMasterMixerVolume,
			[Token(Token = "0x4000559")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x2000089")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x400055B")]
			None,
			[Token(Token = "0x400055C")]
			FadeToVolume,
			[Token(Token = "0x400055D")]
			FadeOutAllOfSound,
			[Token(Token = "0x400055E")]
			Mute,
			[Token(Token = "0x400055F")]
			Pause,
			[Token(Token = "0x4000560")]
			Solo,
			[Token(Token = "0x4000561")]
			StopAllOfSound,
			[Token(Token = "0x4000562")]
			Unmute,
			[Token(Token = "0x4000563")]
			Unpause,
			[Token(Token = "0x4000564")]
			Unsolo,
			[Token(Token = "0x4000565")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x4000566")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x4000567")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x4000568")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x4000569")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x400056A")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x400056B")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x400056C")]
			RefillSoundGroupPool,
			[Token(Token = "0x400056D")]
			RouteToBus,
			[Token(Token = "0x400056E")]
			GlideByPitch,
			[Token(Token = "0x400056F")]
			ToggleSoundGroup,
			[Token(Token = "0x4000570")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000571")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x4000572")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x4000573")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x200008A")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000575")]
			None,
			[Token(Token = "0x4000576")]
			SetBusVolume,
			[Token(Token = "0x4000577")]
			SetGroupVolume,
			[Token(Token = "0x4000578")]
			SetMixerVolume,
			[Token(Token = "0x4000579")]
			SetMusicVolume,
			[Token(Token = "0x400057A")]
			MixerMuteToggle,
			[Token(Token = "0x400057B")]
			MusicMuteToggle
		}

		[Token(Token = "0x200008B")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x400057D")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x400057E")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x400057F")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x200008C")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000581")]
			MasterAudioLocation,
			[Token(Token = "0x4000582")]
			CallerLocation,
			[Token(Token = "0x4000583")]
			AttachToCaller
		}

		[Token(Token = "0x200008D")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000585")]
			None,
			[Token(Token = "0x4000586")]
			Stop,
			[Token(Token = "0x4000587")]
			Pause,
			[Token(Token = "0x4000588")]
			Unpause
		}

		[Token(Token = "0x200008E")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1E06C28", Offset = "0x1E06C28", VA = "0x1E06C28")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008F")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1E06214", Offset = "0x1E06214", VA = "0x1E06214")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class AudioInfo
		{
			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1E066F4", Offset = "0x1E066F4", VA = "0x1E066F4")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000091")]
		public class Playlist
		{
			[Token(Token = "0x20000BC")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x4000614")]
				UseMasterSetting,
				[Token(Token = "0x4000615")]
				Override
			}

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isTemporary;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool showMetadata;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1E07008", Offset = "0x1E07008", VA = "0x1E07008")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1E07AEC", Offset = "0x1E07AEC", VA = "0x1E07AEC")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C34", Offset = "0xCF6C34")]
		private sealed class <>c
		{
			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__220_0;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__221_0;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__222_0;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<GroupPitchGlideInfo> <>9__223_0;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<BusPitchGlideInfo> <>9__224_0;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<CustomEventCandidate> <>9__423_0;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__423_1;

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1DFC320", Offset = "0x1DFC320", VA = "0x1DFC320")]
			public <>c()
			{
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1DFC410", Offset = "0x1DFC410", VA = "0x1DFC410")]
			internal bool <PerformOcclusionFrequencyChanges>b__220_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1DFC6A8", Offset = "0x1DFC6A8", VA = "0x1DFC6A8")]
			internal bool <PerformBusFades>b__221_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1DFC940", Offset = "0x1DFC940", VA = "0x1DFC940")]
			internal bool <PerformGroupFades>b__222_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1DFCBD8", Offset = "0x1DFCBD8", VA = "0x1DFCBD8")]
			internal bool <PerformGroupPitchGlides>b__223_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1DFCE70", Offset = "0x1DFCE70", VA = "0x1DFCE70")]
			internal bool <PerformBusPitchGlides>b__224_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1DFD108", Offset = "0x1DFD108", VA = "0x1DFD108")]
			internal int <FireCustomEvent>b__423_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1DFD404", Offset = "0x1DFD404", VA = "0x1DFD404")]
			internal int <FireCustomEvent>b__423_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C44", Offset = "0xCF6C44")]
		private sealed class <>c__DisplayClass234_0
		{
			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1DFD700", Offset = "0x1DFD700", VA = "0x1DFD700")]
			public <>c__DisplayClass234_0()
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1DFD7F0", Offset = "0x1DFD7F0", VA = "0x1DFD7F0")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C54", Offset = "0xCF6C54")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__234 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action completedAction;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private <>c__DisplayClass234_0 <>8__1;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private PlaySoundResult <sound>5__2;

			[Token(Token = "0x170000B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003EC")]
				[Address(RVA = "0x1E05F5C", Offset = "0x1E05F5C", VA = "0x1E05F5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003EE")]
				[Address(RVA = "0x1E06128", Offset = "0x1E06128", VA = "0x1E06128", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1E04934", Offset = "0x1E04934", VA = "0x1E04934")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__234(int <>1__state)
			{
			}

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1E04A34", Offset = "0x1E04A34", VA = "0x1E04A34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1E04B14", Offset = "0x1E04B14", VA = "0x1E04B14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1E06048", Offset = "0x1E06048", VA = "0x1E06048", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C64", Offset = "0xCF6C64")]
		private sealed class <>c__DisplayClass235_0
		{
			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1DFDA64", Offset = "0x1DFDA64", VA = "0x1DFDA64")]
			public <>c__DisplayClass235_0()
			{
			}

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1DFDB54", Offset = "0x1DFDB54", VA = "0x1DFDB54")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C74", Offset = "0xCF6C74")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__235 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action completedAction;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private <>c__DisplayClass235_0 <>8__1;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private PlaySoundResult <sound>5__2;

			[Token(Token = "0x170000BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003F4")]
				[Address(RVA = "0x1E02D84", Offset = "0x1E02D84", VA = "0x1E02D84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003F6")]
				[Address(RVA = "0x1E02F50", Offset = "0x1E02F50", VA = "0x1E02F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1E01744", Offset = "0x1E01744", VA = "0x1E01744")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__235(int <>1__state)
			{
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1E01844", Offset = "0x1E01844", VA = "0x1E01844", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1E01924", Offset = "0x1E01924", VA = "0x1E01924", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1E02E70", Offset = "0x1E02E70", VA = "0x1E02E70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C84", Offset = "0xCF6C84")]
		private sealed class <>c__DisplayClass236_0
		{
			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1DFDDC8", Offset = "0x1DFDDC8", VA = "0x1DFDDC8")]
			public <>c__DisplayClass236_0()
			{
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1DFDEB8", Offset = "0x1DFDEB8", VA = "0x1DFDEB8")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6C94", Offset = "0xCF6C94")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__236 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Action completedAction;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private <>c__DisplayClass236_0 <>8__1;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private PlaySoundResult <sound>5__2;

			[Token(Token = "0x170000BD")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003FC")]
				[Address(RVA = "0x1E0467C", Offset = "0x1E0467C", VA = "0x1E0467C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000BE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003FE")]
				[Address(RVA = "0x1E04848", Offset = "0x1E04848", VA = "0x1E04848", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x1E0303C", Offset = "0x1E0303C", VA = "0x1E0303C")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__236(int <>1__state)
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1E0313C", Offset = "0x1E0313C", VA = "0x1E0313C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1E0321C", Offset = "0x1E0321C", VA = "0x1E0321C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x1E04768", Offset = "0x1E04768", VA = "0x1E04768", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CA4", Offset = "0xCF6CA4")]
		private sealed class <>c__DisplayClass269_0
		{
			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x1DFE12C", Offset = "0x1DFE12C", VA = "0x1DFE12C")]
			public <>c__DisplayClass269_0()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x1DFE21C", Offset = "0x1DFE21C", VA = "0x1DFE21C")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x1DFE474", Offset = "0x1DFE474", VA = "0x1DFE474")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CB4", Offset = "0xCF6CB4")]
		private sealed class <>c__DisplayClass277_0
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x1DFE6CC", Offset = "0x1DFE6CC", VA = "0x1DFE6CC")]
			public <>c__DisplayClass277_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1DFE7BC", Offset = "0x1DFE7BC", VA = "0x1DFE7BC")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CC4", Offset = "0xCF6CC4")]
		private sealed class <>c__DisplayClass280_0
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1DFEAC4", Offset = "0x1DFEAC4", VA = "0x1DFEAC4")]
			public <>c__DisplayClass280_0()
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1DFEBB4", Offset = "0x1DFEBB4", VA = "0x1DFEBB4")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CD4", Offset = "0xCF6CD4")]
		private sealed class <>c__DisplayClass332_0
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x1DFEEBC", Offset = "0x1DFEEBC", VA = "0x1DFEEBC")]
			public <>c__DisplayClass332_0()
			{
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1DFEFAC", Offset = "0x1DFEFAC", VA = "0x1DFEFAC")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CE4", Offset = "0xCF6CE4")]
		private sealed class <>c__DisplayClass336_0
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x1DFF2B4", Offset = "0x1DFF2B4", VA = "0x1DFF2B4")]
			public <>c__DisplayClass336_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1DFF3A4", Offset = "0x1DFF3A4", VA = "0x1DFF3A4")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6CF4", Offset = "0xCF6CF4")]
		private sealed class <>c__DisplayClass339_0
		{
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1DFF6AC", Offset = "0x1DFF6AC", VA = "0x1DFF6AC")]
			public <>c__DisplayClass339_0()
			{
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1DFF79C", Offset = "0x1DFF79C", VA = "0x1DFF79C")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D04", Offset = "0xCF6D04")]
		private sealed class <>c__DisplayClass419_0
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1DFFAA4", Offset = "0x1DFFAA4", VA = "0x1DFFAA4")]
			public <>c__DisplayClass419_0()
			{
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1DFFB94", Offset = "0x1DFFB94", VA = "0x1DFFB94")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D14", Offset = "0xCF6D14")]
		private sealed class <>c__DisplayClass420_0
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1DFFE9C", Offset = "0x1DFFE9C", VA = "0x1DFFE9C")]
			public <>c__DisplayClass420_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1DFFF8C", Offset = "0x1DFFF8C", VA = "0x1DFFF8C")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D24", Offset = "0xCF6D24")]
		private sealed class <>c__DisplayClass421_0
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x1E00294", Offset = "0x1E00294", VA = "0x1E00294")]
			public <>c__DisplayClass421_0()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1E00384", Offset = "0x1E00384", VA = "0x1E00384")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D34", Offset = "0xCF6D34")]
		private sealed class <>c__DisplayClass422_0
		{
			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1E0068C", Offset = "0x1E0068C", VA = "0x1E0068C")]
			public <>c__DisplayClass422_0()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1E0077C", Offset = "0x1E0077C", VA = "0x1E0077C")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D44", Offset = "0xCF6D44")]
		private sealed class <>c__DisplayClass424_0
		{
			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1E00A84", Offset = "0x1E00A84", VA = "0x1E00A84")]
			public <>c__DisplayClass424_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1E00B74", Offset = "0x1E00B74", VA = "0x1E00B74")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D54", Offset = "0xCF6D54")]
		private sealed class <>c__DisplayClass425_0
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x1E00E7C", Offset = "0x1E00E7C", VA = "0x1E00E7C")]
			public <>c__DisplayClass425_0()
			{
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1E00F6C", Offset = "0x1E00F6C", VA = "0x1E00F6C")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D64", Offset = "0xCF6D64")]
		private sealed class <>c__DisplayClass426_0
		{
			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1E012D8", Offset = "0x1E012D8", VA = "0x1E012D8")]
			public <>c__DisplayClass426_0()
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1E013C8", Offset = "0x1E013C8", VA = "0x1E013C8")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40002C4")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x40002C5")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x40002C6")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x40002C7")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x40002C8")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x40002C9")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x40002CA")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x40002CB")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x40002CC")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x40002CD")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x40002CE")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x40002CF")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x40002D0")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x40002D1")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40002D6")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40002D7")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40002D8")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40002D9")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40002DA")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40002DB")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40002DC")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40002DD")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40002DE")]
		private const int MaxComponents = 20;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float _repriTime;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Transform _trans;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool _soundsLoaded;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		private bool _warming;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7A8C", Offset = "0xCF7A8C")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF7A8C", Offset = "0xCF7A8C")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x1700005A")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x10E1010", Offset = "0x10E1010", VA = "0x10E1010")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x10E130C", Offset = "0x10E130C", VA = "0x10E130C")]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0x10EEAE4", Offset = "0x10EEAE4", VA = "0x10EEAE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0x10EEDE0", Offset = "0x10EEDE0", VA = "0x10EEDE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x600027C")]
			[Address(RVA = "0x1040248", Offset = "0x1040248", VA = "0x1040248")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x10EF0EC", Offset = "0x10EF0EC", VA = "0x10EF0EC")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x10F67AC", Offset = "0x10F67AC", VA = "0x10F67AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x1005710", Offset = "0x1005710", VA = "0x1005710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x10F715C", Offset = "0x10F715C", VA = "0x10F715C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x103FA34", Offset = "0x103FA34", VA = "0x103FA34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000061")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000294")]
			[Address(RVA = "0x10F7818", Offset = "0x10F7818", VA = "0x10F7818")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000295")]
			[Address(RVA = "0x109F47C", Offset = "0x109F47C", VA = "0x109F47C")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x10F7B14", Offset = "0x10F7B14", VA = "0x10F7B14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x10C440C", Offset = "0x10C440C", VA = "0x10C440C")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x104C198", Offset = "0x104C198", VA = "0x104C198")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x10F7E10", Offset = "0x10F7E10", VA = "0x10F7E10")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x10F8098", Offset = "0x10F8098", VA = "0x10F8098")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000065")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x10C0EBC", Offset = "0x10C0EBC", VA = "0x10C0EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x1070BC8", Offset = "0x1070BC8", VA = "0x1070BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x10F8314", Offset = "0x10F8314", VA = "0x10F8314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x10F8998", Offset = "0x10F8998", VA = "0x10F8998")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000069")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x1083054", Offset = "0x1083054", VA = "0x1083054")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x101CA28", Offset = "0x101CA28", VA = "0x101CA28")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x10F9554", Offset = "0x10F9554", VA = "0x10F9554")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public static bool SoundsReady
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x102B8C8", Offset = "0x102B8C8", VA = "0x102B8C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006C")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x10F97E8", Offset = "0x10F97E8", VA = "0x10F97E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF800C", Offset = "0xCF800C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x10F99C0", Offset = "0x10F99C0", VA = "0x10F99C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF801C", Offset = "0xCF801C")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x10F9BB0", Offset = "0x10F9BB0", VA = "0x10F9BB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x10FBF74", Offset = "0x10FBF74", VA = "0x10FBF74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public List<string> BusNames
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x10FC378", Offset = "0x10FC378", VA = "0x10FC378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x10FCCA8", Offset = "0x10FCCA8", VA = "0x10FCCA8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x10FD5D0", Offset = "0x10FD5D0", VA = "0x10FD5D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public Transform Trans
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x1006650", Offset = "0x1006650", VA = "0x1006650")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x10FDE80", Offset = "0x10FDE80", VA = "0x10FDE80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x10FE0FC", Offset = "0x10FE0FC", VA = "0x10FE0FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x10FEE08", Offset = "0x10FEE08", VA = "0x10FEE08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x10FEA04", Offset = "0x10FEA04", VA = "0x10FEA04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x10FF7BC", Offset = "0x10FF7BC", VA = "0x10FF7BC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x10FFAB8", Offset = "0x10FFAB8", VA = "0x10FFAB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x102B53C", Offset = "0x102B53C", VA = "0x102B53C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000079")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x110074C", Offset = "0x110074C", VA = "0x110074C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007A")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x1100A48", Offset = "0x1100A48", VA = "0x1100A48")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x1101328", Offset = "0x1101328", VA = "0x1101328")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x11017AC", Offset = "0x11017AC", VA = "0x11017AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700007C")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x110212C", Offset = "0x110212C", VA = "0x110212C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007D")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x11026C8", Offset = "0x11026C8", VA = "0x11026C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x1102948", Offset = "0x1102948", VA = "0x1102948")]
			set
			{
			}
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xFF8094", Offset = "0xFF8094", VA = "0xFF8094")]
		private void Awake()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x100F9B4", Offset = "0x100F9B4", VA = "0x100F9B4")]
		private void Start()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1010314", Offset = "0x1010314", VA = "0x1010314")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1011818", Offset = "0x1011818", VA = "0x1011818")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x101A774", Offset = "0x101A774", VA = "0x101A774")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x101AF80", Offset = "0x101AF80", VA = "0x101AF80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x101ABC0", Offset = "0x101ABC0", VA = "0x101ABC0")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x101C408", Offset = "0x101C408", VA = "0x101C408")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x101D458", Offset = "0x101D458", VA = "0x101D458")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x101B3D0", Offset = "0x101B3D0", VA = "0x101B3D0")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x101D7E0", Offset = "0x101D7E0", VA = "0x101D7E0")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x101F1D8", Offset = "0x101F1D8", VA = "0x101F1D8")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x101A008", Offset = "0x101A008", VA = "0x101A008")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1018784", Offset = "0x1018784", VA = "0x1018784")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1024014", Offset = "0x1024014", VA = "0x1024014")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1011F5C", Offset = "0x1011F5C", VA = "0x1011F5C")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x10152A8", Offset = "0x10152A8", VA = "0x10152A8")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x101758C", Offset = "0x101758C", VA = "0x101758C")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x10140B0", Offset = "0x10140B0", VA = "0x10140B0")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x102A5AC", Offset = "0x102A5AC", VA = "0x102A5AC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x102AA98", Offset = "0x102AA98", VA = "0x102AA98")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xFF4F88", Offset = "0xFF4F88", VA = "0xFF4F88")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x103B5B8", Offset = "0x103B5B8", VA = "0x103B5B8")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x103BFD0", Offset = "0x103BFD0", VA = "0x103BFD0")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x103C934", Offset = "0x103C934", VA = "0x103C934")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xFF3B00", Offset = "0xFF3B00", VA = "0xFF3B00")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x103D3D0", Offset = "0x103D3D0", VA = "0x103D3D0")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xFF4544", Offset = "0xFF4544", VA = "0xFF4544")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x103DE7C", Offset = "0x103DE7C", VA = "0x103DE7C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7EE0", Offset = "0xCF7EE0")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x103DFD0", Offset = "0x103DFD0", VA = "0x103DFD0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7F44", Offset = "0xCF7F44")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x103E144", Offset = "0x103E144", VA = "0x103E144")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF7FA8", Offset = "0xCF7FA8")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x103B234", Offset = "0x103B234", VA = "0x103B234")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x102BD04", Offset = "0x102BD04", VA = "0x102BD04")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1043E8C", Offset = "0x1043E8C", VA = "0x1043E8C")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x103FE70", Offset = "0x103FE70", VA = "0x103FE70")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1042B6C", Offset = "0x1042B6C", VA = "0x1042B6C")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x104533C", Offset = "0x104533C", VA = "0x104533C")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x104B1B4", Offset = "0x104B1B4", VA = "0x104B1B4")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x104C414", Offset = "0x104C414", VA = "0x104C414")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x104EC30", Offset = "0x104EC30", VA = "0x104EC30")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x104FC48", Offset = "0x104FC48", VA = "0x104FC48")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x10506E8", Offset = "0x10506E8", VA = "0x10506E8")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x10513C8", Offset = "0x10513C8", VA = "0x10513C8")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1051E68", Offset = "0x1051E68", VA = "0x1051E68")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1052B58", Offset = "0x1052B58", VA = "0x1052B58")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x10535F8", Offset = "0x10535F8", VA = "0x10535F8")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x10559AC", Offset = "0x10559AC", VA = "0x10559AC")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1028130", Offset = "0x1028130", VA = "0x1028130")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1044334", Offset = "0x1044334", VA = "0x1044334")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1057034", Offset = "0x1057034", VA = "0x1057034")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x105451C", Offset = "0x105451C", VA = "0x105451C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10582C0", Offset = "0x10582C0", VA = "0x10582C0")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1059CE8", Offset = "0x1059CE8", VA = "0x1059CE8")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x105B378", Offset = "0x105B378", VA = "0x105B378")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1061718", Offset = "0x1061718", VA = "0x1061718")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1064600", Offset = "0x1064600", VA = "0x1064600")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1066058", Offset = "0x1066058", VA = "0x1066058")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x10676B0", Offset = "0x10676B0", VA = "0x10676B0")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x106816C", Offset = "0x106816C", VA = "0x106816C")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1069768", Offset = "0x1069768", VA = "0x1069768")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x106ABBC", Offset = "0x106ABBC", VA = "0x106ABBC")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x106BDB0", Offset = "0x106BDB0", VA = "0x106BDB0")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x106C470", Offset = "0x106C470", VA = "0x106C470")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x106D4C8", Offset = "0x106D4C8", VA = "0x106D4C8")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1073240", Offset = "0x1073240", VA = "0x1073240")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1020D3C", Offset = "0x1020D3C", VA = "0x1020D3C")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1075C0C", Offset = "0x1075C0C", VA = "0x1075C0C")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x107601C", Offset = "0x107601C", VA = "0x107601C")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1076BF8", Offset = "0x1076BF8", VA = "0x1076BF8")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x10777D4", Offset = "0x10777D4", VA = "0x10777D4")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1078624", Offset = "0x1078624", VA = "0x1078624")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1079200", Offset = "0x1079200", VA = "0x1079200")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x107AF80", Offset = "0x107AF80", VA = "0x107AF80")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x107C720", Offset = "0x107C720", VA = "0x107C720")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x107D9F8", Offset = "0x107D9F8", VA = "0x107D9F8")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1080DFC", Offset = "0x1080DFC", VA = "0x1080DFC")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1084868", Offset = "0x1084868", VA = "0x1084868")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x108F820", Offset = "0x108F820", VA = "0x108F820")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1026B78", Offset = "0x1026B78", VA = "0x1026B78")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x100EF7C", Offset = "0x100EF7C", VA = "0x100EF7C")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x109079C", Offset = "0x109079C", VA = "0x109079C")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1006BB4", Offset = "0x1006BB4", VA = "0x1006BB4")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1091D84", Offset = "0x1091D84", VA = "0x1091D84")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1091018", Offset = "0x1091018", VA = "0x1091018")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1010780", Offset = "0x1010780", VA = "0x1010780")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1083704", Offset = "0x1083704", VA = "0x1083704")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1092218", Offset = "0x1092218", VA = "0x1092218")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x108FDC4", Offset = "0x108FDC4", VA = "0x108FDC4")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x10713C4", Offset = "0x10713C4", VA = "0x10713C4")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1072B40", Offset = "0x1072B40", VA = "0x1072B40")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1093D08", Offset = "0x1093D08", VA = "0x1093D08")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1094888", Offset = "0x1094888", VA = "0x1094888")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x109317C", Offset = "0x109317C", VA = "0x109317C")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1095388", Offset = "0x1095388", VA = "0x1095388")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1095E88", Offset = "0x1095E88", VA = "0x1095E88")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x104D704", Offset = "0x104D704", VA = "0x104D704")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x10967F8", Offset = "0x10967F8", VA = "0x10967F8")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1096EC0", Offset = "0x1096EC0", VA = "0x1096EC0")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1097FF4", Offset = "0x1097FF4", VA = "0x1097FF4")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x10989A0", Offset = "0x10989A0", VA = "0x10989A0")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1099038", Offset = "0x1099038", VA = "0x1099038")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x10998EC", Offset = "0x10998EC", VA = "0x10998EC")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x109A010", Offset = "0x109A010", VA = "0x109A010")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x109A8EC", Offset = "0x109A8EC", VA = "0x109A8EC")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x109B3EC", Offset = "0x109B3EC", VA = "0x109B3EC")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x109BEEC", Offset = "0x109BEEC", VA = "0x109BEEC")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x109CD14", Offset = "0x109CD14", VA = "0x109CD14")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x109DBD0", Offset = "0x109DBD0", VA = "0x109DBD0")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x109E2D0", Offset = "0x109E2D0", VA = "0x109E2D0")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x109E9D0", Offset = "0x109E9D0", VA = "0x109E9D0")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x109F0D0", Offset = "0x109F0D0", VA = "0x109F0D0")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x10A11B4", Offset = "0x10A11B4", VA = "0x10A11B4")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x10A18B8", Offset = "0x10A18B8", VA = "0x10A18B8")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1029778", Offset = "0x1029778", VA = "0x1029778")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1070EBC", Offset = "0x1070EBC", VA = "0x1070EBC")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x10A33C0", Offset = "0x10A33C0", VA = "0x10A33C0")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x10A42D4", Offset = "0x10A42D4", VA = "0x10A42D4")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x10A732C", Offset = "0x10A732C", VA = "0x10A732C")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x10A850C", Offset = "0x10A850C", VA = "0x10A850C")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x10A8E9C", Offset = "0x10A8E9C", VA = "0x10A8E9C")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x10A9EC0", Offset = "0x10A9EC0", VA = "0x10A9EC0")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x10A614C", Offset = "0x10A614C", VA = "0x10A614C")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x10AB38C", Offset = "0x10AB38C", VA = "0x10AB38C")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1040544", Offset = "0x1040544", VA = "0x1040544")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1025A1C", Offset = "0x1025A1C", VA = "0x1025A1C")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x10AC488", Offset = "0x10AC488", VA = "0x10AC488")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x10AD2B0", Offset = "0x10AD2B0", VA = "0x10AD2B0")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x10AE450", Offset = "0x10AE450", VA = "0x10AE450")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x10AE9C8", Offset = "0x10AE9C8", VA = "0x10AE9C8")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x104A654", Offset = "0x104A654", VA = "0x104A654")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x10B1ECC", Offset = "0x10B1ECC", VA = "0x10B1ECC")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x10B3A30", Offset = "0x10B3A30", VA = "0x10B3A30")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x10B57DC", Offset = "0x10B57DC", VA = "0x10B57DC")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x10B7234", Offset = "0x10B7234", VA = "0x10B7234")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x10076A8", Offset = "0x10076A8", VA = "0x10076A8")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x10B0B10", Offset = "0x10B0B10", VA = "0x10B0B10")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1071E74", Offset = "0x1071E74", VA = "0x1071E74")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x10A57A8", Offset = "0x10A57A8", VA = "0x10A57A8")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x10BB930", Offset = "0x10BB930", VA = "0x10BB930")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x10BCA44", Offset = "0x10BCA44", VA = "0x10BCA44")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x10BDB58", Offset = "0x10BDB58", VA = "0x10BDB58")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x10BEFD8", Offset = "0x10BEFD8", VA = "0x10BEFD8")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x10BF820", Offset = "0x10BF820", VA = "0x10BF820")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10C0020", Offset = "0x10C0020", VA = "0x10C0020")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x10C11B0", Offset = "0x10C11B0", VA = "0x10C11B0")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x10C1E1C", Offset = "0x10C1E1C", VA = "0x10C1E1C")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x10C210C", Offset = "0x10C210C", VA = "0x10C210C")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x10A0E5C", Offset = "0x10A0E5C", VA = "0x10A0E5C")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x10C3928", Offset = "0x10C3928", VA = "0x10C3928")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x10C5020", Offset = "0x10C5020", VA = "0x10C5020")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x10C5310", Offset = "0x10C5310", VA = "0x10C5310")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10A1560", Offset = "0x10A1560", VA = "0x10A1560")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10C61E4", Offset = "0x10C61E4", VA = "0x10C61E4")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10C6CC8", Offset = "0x10C6CC8", VA = "0x10C6CC8")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x10C6FB8", Offset = "0x10C6FB8", VA = "0x10C6FB8")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x10C859C", Offset = "0x10C859C", VA = "0x10C859C")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x10C7E8C", Offset = "0x10C7E8C", VA = "0x10C7E8C")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x10C88F4", Offset = "0x10C88F4", VA = "0x10C88F4")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x10C8BE4", Offset = "0x10C8BE4", VA = "0x10C8BE4")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x109E678", Offset = "0x109E678", VA = "0x109E678")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x10C9AB8", Offset = "0x10C9AB8", VA = "0x10C9AB8")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10CA1C8", Offset = "0x10CA1C8", VA = "0x10CA1C8")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x10CA4B8", Offset = "0x10CA4B8", VA = "0x10CA4B8")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x109ED78", Offset = "0x109ED78", VA = "0x109ED78")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x10CC384", Offset = "0x10CC384", VA = "0x10CC384")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x10CCA94", Offset = "0x10CCA94", VA = "0x10CCA94")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x10CCD84", Offset = "0x10CCD84", VA = "0x10CCD84")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x109DF78", Offset = "0x109DF78", VA = "0x109DF78")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10CDC58", Offset = "0x10CDC58", VA = "0x10CDC58")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10CE36C", Offset = "0x10CE36C", VA = "0x10CE36C")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x10CE65C", Offset = "0x10CE65C", VA = "0x10CE65C")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x10CFC40", Offset = "0x10CFC40", VA = "0x10CFC40")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x10CF530", Offset = "0x10CF530", VA = "0x10CF530")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x10CFF98", Offset = "0x10CFF98", VA = "0x10CFF98")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x10D0288", Offset = "0x10D0288", VA = "0x10D0288")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10D186C", Offset = "0x10D186C", VA = "0x10D186C")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x10D115C", Offset = "0x10D115C", VA = "0x10D115C")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x10D1BBC", Offset = "0x10D1BBC", VA = "0x10D1BBC")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x10D1EAC", Offset = "0x10D1EAC", VA = "0x10D1EAC")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x10D35C0", Offset = "0x10D35C0", VA = "0x10D35C0")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10D2EB0", Offset = "0x10D2EB0", VA = "0x10D2EB0")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10D3918", Offset = "0x10D3918", VA = "0x10D3918")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10D3C1C", Offset = "0x10D3C1C", VA = "0x10D3C1C")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10D4EA0", Offset = "0x10D4EA0", VA = "0x10D4EA0")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10D5908", Offset = "0x10D5908", VA = "0x10D5908")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10D5BF8", Offset = "0x10D5BF8", VA = "0x10D5BF8")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x10D51F8", Offset = "0x10D51F8", VA = "0x10D51F8")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10D6BFC", Offset = "0x10D6BFC", VA = "0x10D6BFC")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10D8664", Offset = "0x10D8664", VA = "0x10D8664")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x10D8954", Offset = "0x10D8954", VA = "0x10D8954")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10D6F54", Offset = "0x10D6F54", VA = "0x10D6F54")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10D9958", Offset = "0x10D9958", VA = "0x10D9958")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x10D9C5C", Offset = "0x10D9C5C", VA = "0x10D9C5C")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x10DAB40", Offset = "0x10DAB40", VA = "0x10DAB40")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10DAE4C", Offset = "0x10DAE4C", VA = "0x10DAE4C")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10DBD44", Offset = "0x10DBD44", VA = "0x10DBD44")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10DC068", Offset = "0x10DC068", VA = "0x10DC068")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x10DCF64", Offset = "0x10DCF64", VA = "0x10DCF64")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x10DD280", Offset = "0x10DD280", VA = "0x10DD280")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10DEBC4", Offset = "0x10DEBC4", VA = "0x10DEBC4")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x10DE178", Offset = "0x10DE178", VA = "0x10DE178")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x10DEF48", Offset = "0x10DEF48", VA = "0x10DEF48")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x10DF864", Offset = "0x10DF864", VA = "0x10DF864")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x10E0950", Offset = "0x10E0950", VA = "0x10E0950")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10E1B90", Offset = "0x10E1B90", VA = "0x10E1B90")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10E22D0", Offset = "0x10E22D0", VA = "0x10E22D0")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x10E412C", Offset = "0x10E412C", VA = "0x10E412C")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x10E55D4", Offset = "0x10E55D4", VA = "0x10E55D4")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x10E6D10", Offset = "0x10E6D10", VA = "0x10E6D10")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x10E87C8", Offset = "0x10E87C8", VA = "0x10E87C8")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10E98FC", Offset = "0x10E98FC", VA = "0x10E98FC")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x10EA4E0", Offset = "0x10EA4E0", VA = "0x10EA4E0")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10EB734", Offset = "0x10EB734", VA = "0x10EB734")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10EBFA0", Offset = "0x10EBFA0", VA = "0x10EBFA0")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1008130", Offset = "0x1008130", VA = "0x1008130")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10E4E00", Offset = "0x10E4E00", VA = "0x10E4E00")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x10EC67C", Offset = "0x10EC67C", VA = "0x10EC67C")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x10ECF18", Offset = "0x10ECF18", VA = "0x10ECF18")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x10ED7B4", Offset = "0x10ED7B4", VA = "0x10ED7B4")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x103E984", Offset = "0x103E984", VA = "0x103E984")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x103F2C8", Offset = "0x103F2C8", VA = "0x103F2C8")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x103E47C", Offset = "0x103E47C", VA = "0x103E47C")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x10EF3F8", Offset = "0x10EF3F8", VA = "0x10EF3F8")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10706D0", Offset = "0x10706D0", VA = "0x10706D0")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10EFA2C", Offset = "0x10EFA2C", VA = "0x10EFA2C")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10C2FE0", Offset = "0x10C2FE0", VA = "0x10C2FE0")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10EFF48", Offset = "0x10EFF48", VA = "0x10EFF48")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10F0D94", Offset = "0x10F0D94", VA = "0x10F0D94")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10F1BE0", Offset = "0x10F1BE0", VA = "0x10F1BE0")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x10F29B8", Offset = "0x10F29B8", VA = "0x10F29B8")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10F4254", Offset = "0x10F4254", VA = "0x10F4254")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10F4C30", Offset = "0x10F4C30", VA = "0x10F4C30")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x10F4FB8", Offset = "0x10F4FB8", VA = "0x10F4FB8")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x106A238", Offset = "0x106A238", VA = "0x106A238")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1060C78", Offset = "0x1060C78", VA = "0x1060C78")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x10F3878", Offset = "0x10F3878", VA = "0x10F3878")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10F55D8", Offset = "0x10F55D8", VA = "0x10F55D8")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1056A8C", Offset = "0x1056A8C", VA = "0x1056A8C")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10F6AA0", Offset = "0x10F6AA0", VA = "0x10F6AA0")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x1084574", Offset = "0x1084574", VA = "0x1084574")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x1101E3C", Offset = "0x1101E3C", VA = "0x1101E3C")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x1102BEC", Offset = "0x1102BEC", VA = "0x1102BEC")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x11034FC", Offset = "0x11034FC", VA = "0x11034FC")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x1103E0C", Offset = "0x1103E0C", VA = "0x1103E0C")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x110471C", Offset = "0x110471C", VA = "0x110471C")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x110502C", Offset = "0x110502C", VA = "0x110502C")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000372")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000373")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000374")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000375")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000376")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000377")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000378")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000379")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400037A")]
		public const string Separator = ";";

		[Token(Token = "0x1700007E")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x1E2881C", Offset = "0x1E2881C", VA = "0x1E2881C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x1E28DB4", Offset = "0x1E28DB4", VA = "0x1E28DB4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x1E299CC", Offset = "0x1E299CC", VA = "0x1E299CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x1E29F64", Offset = "0x1E29F64", VA = "0x1E29F64")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x1E2B7B0", Offset = "0x1E2B7B0", VA = "0x1E2B7B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x1E2BD08", Offset = "0x1E2BD08", VA = "0x1E2BD08")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x1E2C79C", Offset = "0x1E2C79C", VA = "0x1E2C79C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x1E2CCF0", Offset = "0x1E2CCF0", VA = "0x1E2CCF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60002CF")]
			[Address(RVA = "0x1E2D788", Offset = "0x1E2D788", VA = "0x1E2D788")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D0")]
			[Address(RVA = "0x1E2DCE0", Offset = "0x1E2DCE0", VA = "0x1E2DCE0")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0x1E2E774", Offset = "0x1E2E774", VA = "0x1E2E774")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0x1E2ECD0", Offset = "0x1E2ECD0", VA = "0x1E2ECD0")]
			set
			{
			}
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1E276AC", Offset = "0x1E276AC", VA = "0x1E276AC")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x1E28530", Offset = "0x1E28530", VA = "0x1E28530")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1E290A0", Offset = "0x1E290A0", VA = "0x1E290A0")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x1E296E0", Offset = "0x1E296E0", VA = "0x1E296E0")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1E2A250", Offset = "0x1E2A250", VA = "0x1E2A250")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1E2B170", Offset = "0x1E2B170", VA = "0x1E2B170")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1E2F768", Offset = "0x1E2F768", VA = "0x1E2F768")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000A7")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x2848334", Offset = "0x2848334", VA = "0x2848334")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000A8")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x28486FC", Offset = "0x28486FC", VA = "0x28486FC")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000A9")]
		public enum MAItemType
		{
			[Token(Token = "0x40005EA")]
			SoundGroups,
			[Token(Token = "0x40005EB")]
			CustomEvents
		}

		[Token(Token = "0x20000AA")]
		public enum TransferMode
		{
			[Token(Token = "0x40005ED")]
			None,
			[Token(Token = "0x40005EE")]
			Import,
			[Token(Token = "0x40005EF")]
			Export
		}

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x2847318", Offset = "0x2847318", VA = "0x2847318")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x284761C", Offset = "0x284761C", VA = "0x284761C")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public static class AmbientUtil
	{
		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D74", Offset = "0xCF6D74")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string variationName;

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x121F1A4", Offset = "0x121F1A4", VA = "0x121F1A4")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x12207DC", Offset = "0x12207DC", VA = "0x12207DC")]
			internal bool <InitAudioSourceFollower>b__0(SoundGroupVariation v)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000391")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x4000392")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x4000393")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x4000394")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x17000084")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x121D0EC", Offset = "0x121D0EC", VA = "0x121D0EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x121AECC", Offset = "0x121AECC", VA = "0x121AECC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x1220270", Offset = "0x1220270", VA = "0x1220270")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000087")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x12179BC", Offset = "0x12179BC", VA = "0x12179BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x121A8FC", Offset = "0x121A8FC", VA = "0x121A8FC")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1217060", Offset = "0x1217060", VA = "0x1217060")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x121EE88", Offset = "0x121EE88", VA = "0x121EE88")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1217CE4", Offset = "0x1217CE4", VA = "0x1217CE4")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x121F584", Offset = "0x121F584", VA = "0x121F584")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x121FD44", Offset = "0x121FD44", VA = "0x121FD44")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1220B5C", Offset = "0x1220B5C", VA = "0x1220B5C")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1221570", Offset = "0x1221570", VA = "0x1221570")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000046")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x123CFB4", Offset = "0x123CFB4", VA = "0x123CFB4")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x123D2DC", Offset = "0x123D2DC", VA = "0x123D2DC")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x123D5E4", Offset = "0x123D5E4", VA = "0x123D5E4")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x123D950", Offset = "0x123D950", VA = "0x123D950")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x123DCC8", Offset = "0x123DCC8", VA = "0x123DCC8")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x123E03C", Offset = "0x123E03C", VA = "0x123E03C")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x123E3B4", Offset = "0x123E3B4", VA = "0x123E3B4")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x123E74C", Offset = "0x123E74C", VA = "0x123E74C")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x123EAE4", Offset = "0x123EAE4", VA = "0x123EAE4")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x123EDE0", Offset = "0x123EDE0", VA = "0x123EDE0")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x123F0F4", Offset = "0x123F0F4", VA = "0x123F0F4")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x123F408", Offset = "0x123F408", VA = "0x123F408")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x123F704", Offset = "0x123F704", VA = "0x123F704")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x123FA18", Offset = "0x123FA18", VA = "0x123FA18")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x123FD2C", Offset = "0x123FD2C", VA = "0x123FD2C")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x1240028", Offset = "0x1240028", VA = "0x1240028")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x124033C", Offset = "0x124033C", VA = "0x124033C")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1240650", Offset = "0x1240650", VA = "0x1240650")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000047")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x17000088")]
		public Transform Trans
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x1240974", Offset = "0x1240974", VA = "0x1240974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1240ECC", Offset = "0x1240ECC", VA = "0x1240ECC")]
		private void Update()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1241148", Offset = "0x1241148", VA = "0x1241148")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x2000048")]
	public static class AudioUtil
	{
		[Token(Token = "0x400039B")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x400039C")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x400039D")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x17000089")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x1241BC8", Offset = "0x1241BC8", VA = "0x1241BC8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008A")]
		public static float FrameTime
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x1241EA4", Offset = "0x1241EA4", VA = "0x1241EA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008B")]
		public static float Time
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x1242180", Offset = "0x1242180", VA = "0x1242180")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008C")]
		public static int FrameCount
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x124245C", Offset = "0x124245C", VA = "0x124245C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1241238", Offset = "0x1241238", VA = "0x1241238")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x12415C8", Offset = "0x12415C8", VA = "0x12415C8")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x12418C8", Offset = "0x12418C8", VA = "0x12418C8")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1242728", Offset = "0x1242728", VA = "0x1242728")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1242AA8", Offset = "0x1242AA8", VA = "0x1242AA8")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x12431E0", Offset = "0x12431E0", VA = "0x12431E0")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x12437F8", Offset = "0x12437F8", VA = "0x12437F8")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1243B14", Offset = "0x1243B14", VA = "0x1243B14")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1226A34", Offset = "0x1226A34", VA = "0x1226A34")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1243E30", Offset = "0x1243E30", VA = "0x1243E30")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x12441B0", Offset = "0x12441B0", VA = "0x12441B0")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x12446A0", Offset = "0x12446A0", VA = "0x12446A0")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x122CC64", Offset = "0x122CC64", VA = "0x122CC64")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1245058", Offset = "0x1245058", VA = "0x1245058")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1245400", Offset = "0x1245400", VA = "0x1245400")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1245778", Offset = "0x1245778", VA = "0x1245778")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x12459FC", Offset = "0x12459FC", VA = "0x12459FC")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1245D84", Offset = "0x1245D84", VA = "0x1245D84")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1246078", Offset = "0x1246078", VA = "0x1246078")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000049")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D84", Offset = "0xCF6D84")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__1;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000421")]
				[Address(RVA = "0x124DEB4", Offset = "0x124DEB4", VA = "0x124DEB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000423")]
				[Address(RVA = "0x124E080", Offset = "0x124E080", VA = "0x124E080", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x124D638", Offset = "0x124D638", VA = "0x124D638")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x124D738", Offset = "0x124D738", VA = "0x124D738", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x124D818", Offset = "0x124D818", VA = "0x124D818", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x124DFA0", Offset = "0x124DFA0", VA = "0x124DFA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x124D51C", Offset = "0x124D51C", VA = "0x124D51C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF814C", Offset = "0xCF814C")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x200004A")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x121F294", Offset = "0x121F294", VA = "0x121F294")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x124ECF4", Offset = "0x124ECF4", VA = "0x124ECF4")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1239928", Offset = "0x1239928", VA = "0x1239928")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x121C054", Offset = "0x121C054", VA = "0x121C054")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6D94", Offset = "0xCF6D94")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <randomTime>5__1;

			[Token(Token = "0x170000C1")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000427")]
				[Address(RVA = "0x1250C68", Offset = "0x1250C68", VA = "0x1250C68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000429")]
				[Address(RVA = "0x1250E34", Offset = "0x1250E34", VA = "0x1250E34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x124FD1C", Offset = "0x124FD1C", VA = "0x124FD1C")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x1250120", Offset = "0x1250120", VA = "0x1250120", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x1250200", Offset = "0x1250200", VA = "0x1250200", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1250D54", Offset = "0x1250D54", VA = "0x1250D54", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x124EFE4", Offset = "0x124EFE4", VA = "0x124EFE4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x124F450", Offset = "0x124F450", VA = "0x124F450")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x124F7D8", Offset = "0x124F7D8", VA = "0x124F7D8")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x124FC00", Offset = "0x124FC00", VA = "0x124FC00")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xCF81D0", Offset = "0xCF81D0")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x124FE1C", Offset = "0x124FE1C", VA = "0x124FE1C")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6B18", Offset = "0xCF6B18")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40005FA")]
			FirstEnableOnly,
			[Token(Token = "0x40005FB")]
			EveryEnable
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6DA4", Offset = "0xCF6DA4")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x12624F4", Offset = "0x12624F4", VA = "0x12624F4")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x126599C", Offset = "0x126599C", VA = "0x126599C")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40003A2")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x1700008D")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x1263D04", Offset = "0x1263D04", VA = "0x1263D04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700008E")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1264274", Offset = "0x1264274", VA = "0x1264274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x12644E0", Offset = "0x12644E0", VA = "0x12644E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1257CFC", Offset = "0x1257CFC", VA = "0x1257CFC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1258430", Offset = "0x1258430", VA = "0x1258430")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1258E98", Offset = "0x1258E98", VA = "0x1258E98")]
		private void Start()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1259170", Offset = "0x1259170", VA = "0x1259170")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1258708", Offset = "0x1258708", VA = "0x1258708")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1259A50", Offset = "0x1259A50", VA = "0x1259A50")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x125BEC8", Offset = "0x125BEC8", VA = "0x125BEC8")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1263F64", Offset = "0x1263F64", VA = "0x1263F64")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x12625E4", Offset = "0x12625E4", VA = "0x12625E4")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x126475C", Offset = "0x126475C", VA = "0x126475C")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x40003C7")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x40003C8")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xFE43D0", Offset = "0xFE43D0", VA = "0xFE43D0")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xFE5DE0", Offset = "0xFE5DE0", VA = "0xFE5DE0")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xFE6104", Offset = "0xFE6104", VA = "0xFE6104")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0xFE6880", Offset = "0xFE6880", VA = "0xFE6880")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xFE7044", Offset = "0xFE7044", VA = "0xFE7044")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0xFE7808", Offset = "0xFE7808", VA = "0xFE7808")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xFE7FC8", Offset = "0xFE7FC8", VA = "0xFE7FC8")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xFE8598", Offset = "0xFE8598", VA = "0xFE8598")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xFE8D38", Offset = "0xFE8D38", VA = "0xFE8D38")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xFE97F8", Offset = "0xFE97F8", VA = "0xFE97F8")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xFE9F70", Offset = "0xFE9F70", VA = "0xFE9F70")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xFEAA38", Offset = "0xFEAA38", VA = "0xFEAA38")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xFEB1B8", Offset = "0xFEB1B8", VA = "0xFEB1B8")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xFEB744", Offset = "0xFEB744", VA = "0xFEB744")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xFEBEC8", Offset = "0xFEBEC8", VA = "0xFEBEC8")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xFEC1E4", Offset = "0xFEC1E4", VA = "0xFEC1E4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xFEC4EC", Offset = "0xFEC4EC", VA = "0xFEC4EC")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xFECFA8", Offset = "0xFECFA8", VA = "0xFECFA8")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xFE4E84", Offset = "0xFE4E84", VA = "0xFE4E84")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xFEE0B4", Offset = "0xFEE0B4", VA = "0xFEE0B4")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xFEE514", Offset = "0xFEE514", VA = "0xFEE514")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xFEE974", Offset = "0xFEE974", VA = "0xFEE974")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xCF6B2C", Offset = "0xCF6B2C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xCF6B2C", Offset = "0xCF6B2C")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40005FE")]
			PlayNow,
			[Token(Token = "0x40005FF")]
			Schedule,
			[Token(Token = "0x4000600")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000B1")]
		public enum PlaylistStates
		{
			[Token(Token = "0x4000602")]
			NotInScene,
			[Token(Token = "0x4000603")]
			Stopped,
			[Token(Token = "0x4000604")]
			Playing,
			[Token(Token = "0x4000605")]
			Paused,
			[Token(Token = "0x4000606")]
			Crossfading
		}

		[Token(Token = "0x20000B2")]
		public enum FadeMode
		{
			[Token(Token = "0x4000608")]
			None,
			[Token(Token = "0x4000609")]
			GradualFade
		}

		[Token(Token = "0x20000B3")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x400060B")]
			NotDucking,
			[Token(Token = "0x400060C")]
			SetToDuck,
			[Token(Token = "0x400060D")]
			Ducked
		}

		[Token(Token = "0x20000B4")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x20000B5")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000B6")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x20000B7")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6DB4", Offset = "0xCF6DB4")]
		private sealed class <>c__DisplayClass112_0
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x2842CB4", Offset = "0x2842CB4", VA = "0x2842CB4")]
			public <>c__DisplayClass112_0()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x2842DA4", Offset = "0x2842DA4", VA = "0x2842DA4")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6DC4", Offset = "0xCF6DC4")]
		private sealed class <>c__DisplayClass131_0
		{
			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x28431D8", Offset = "0x28431D8", VA = "0x28431D8")]
			public <>c__DisplayClass131_0()
			{
			}

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x28432C8", Offset = "0x28432C8", VA = "0x28432C8")]
			internal bool <QueuePlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6DD4", Offset = "0xCF6DD4")]
		private sealed class <>c__DisplayClass132_0
		{
			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x2843AC0", Offset = "0x2843AC0", VA = "0x2843AC0")]
			public <>c__DisplayClass132_0()
			{
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x2843BB0", Offset = "0x2843BB0", VA = "0x2843BB0")]
			internal bool <TriggerPlaylistClip>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x2843EB8", Offset = "0x2843EB8", VA = "0x2843EB8")]
			internal bool <TriggerPlaylistClip>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF6DE4", Offset = "0xCF6DE4")]
		private sealed class <>c__DisplayClass142_0
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x28445B0", Offset = "0x28445B0", VA = "0x28445B0")]
			public <>c__DisplayClass142_0()
			{
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x28446A0", Offset = "0x28446A0", VA = "0x28446A0")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x40003CA")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x40003CB")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40003CC")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40003CD")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40003CE")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40003CF")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private AudioSource _audio1;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private AudioSource _audio2;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private string _activeSongAlias;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Transform _trans;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool _willPersist;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private double? _songPauseTime;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private int framesOfSongPlayed;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7BB8", Offset = "0xCF7BB8")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF7BB8", Offset = "0xCF7BB8")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x221")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF7BF4", Offset = "0xCF7BF4")]
		[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0xCF7BF4", Offset = "0xCF7BF4")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x17000090")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x600037F")]
			[Address(RVA = "0x1E7529C", Offset = "0x1E7529C", VA = "0x1E7529C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1E6A88C", Offset = "0x1E6A88C", VA = "0x1E6A88C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000092")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1E75698", Offset = "0x1E75698", VA = "0x1E75698")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82B4", Offset = "0xCF82B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x1E7585C", Offset = "0x1E7585C", VA = "0x1E7585C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82C4", Offset = "0xCF82C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1E4AD90", Offset = "0x1E4AD90", VA = "0x1E4AD90")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x17000094")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x1E3F720", Offset = "0x1E3F720", VA = "0x1E3F720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x1E4D9C4", Offset = "0x1E4D9C4", VA = "0x1E4D9C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000387")]
			[Address(RVA = "0x1E75A28", Offset = "0x1E75A28", VA = "0x1E75A28")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000388")]
			[Address(RVA = "0x1E75CAC", Offset = "0x1E75CAC", VA = "0x1E75CAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000389")]
			[Address(RVA = "0x1E75F18", Offset = "0x1E75F18", VA = "0x1E75F18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x1E76184", Offset = "0x1E76184", VA = "0x1E76184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x1E76684", Offset = "0x1E76684", VA = "0x1E76684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0x1E76D70", Offset = "0x1E76D70", VA = "0x1E76D70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public bool IsCrossFading
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0x1E771C4", Offset = "0x1E771C4", VA = "0x1E771C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82D4", Offset = "0xCF82D4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600038E")]
			[Address(RVA = "0x1E77388", Offset = "0x1E77388", VA = "0x1E77388")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82E4", Offset = "0xCF82E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public bool IsFading
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0x1E77554", Offset = "0x1E77554", VA = "0x1E77554")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009D")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x1E677F8", Offset = "0x1E677F8", VA = "0x1E677F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x1E77850", Offset = "0x1E77850", VA = "0x1E77850")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x1E6AD90", Offset = "0x1E6AD90", VA = "0x1E6AD90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x1E4F0CC", Offset = "0x1E4F0CC", VA = "0x1E4F0CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A0")]
		public string PlaylistName
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x1E77F78", Offset = "0x1E77F78", VA = "0x1E77F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		private bool IsMuted
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x1E39B04", Offset = "0x1E39B04", VA = "0x1E39B04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1E50574", Offset = "0x1E50574", VA = "0x1E50574")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1E49970", Offset = "0x1E49970", VA = "0x1E49970")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1E49FAC", Offset = "0x1E49FAC", VA = "0x1E49FAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A5")]
		public GameObject GameObj
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x1E55DF4", Offset = "0x1E55DF4", VA = "0x1E55DF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public string ControllerName
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1E35A44", Offset = "0x1E35A44", VA = "0x1E35A44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public bool CanSchedule
		{
			[Token(Token = "0x600039C")]
			[Address(RVA = "0x1E47C40", Offset = "0x1E47C40", VA = "0x1E47C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A8")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x1E3A05C", Offset = "0x1E3A05C", VA = "0x1E3A05C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x1E4AA20", Offset = "0x1E4AA20", VA = "0x1E4AA20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		private Transform Trans
		{
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x1E3906C", Offset = "0x1E3906C", VA = "0x1E3906C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x1E78454", Offset = "0x1E78454", VA = "0x1E78454")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1E31B58", Offset = "0x1E31B58", VA = "0x1E31B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8234", Offset = "0xCF8234")]
			add
			{
			}
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1E31CC4", Offset = "0x1E31CC4", VA = "0x1E31CC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8244", Offset = "0xCF8244")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1E31E30", Offset = "0x1E31E30", VA = "0x1E31E30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8254", Offset = "0xCF8254")]
			add
			{
			}
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1E31F9C", Offset = "0x1E31F9C", VA = "0x1E31F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8264", Offset = "0xCF8264")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1E32108", Offset = "0x1E32108", VA = "0x1E32108")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8274", Offset = "0xCF8274")]
			add
			{
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1E32274", Offset = "0x1E32274", VA = "0x1E32274")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8284", Offset = "0xCF8284")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1E323E0", Offset = "0x1E323E0", VA = "0x1E323E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8294", Offset = "0xCF8294")]
			add
			{
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x1E3254C", Offset = "0x1E3254C", VA = "0x1E3254C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82A4", Offset = "0xCF82A4")]
			remove
			{
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1E326B8", Offset = "0x1E326B8", VA = "0x1E326B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1E35F80", Offset = "0x1E35F80", VA = "0x1E35F80")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1E3756C", Offset = "0x1E3756C", VA = "0x1E3756C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1E36EBC", Offset = "0x1E36EBC", VA = "0x1E36EBC")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1E37980", Offset = "0x1E37980", VA = "0x1E37980")]
		private void Start()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1E395C8", Offset = "0x1E395C8", VA = "0x1E395C8")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1E3AC68", Offset = "0x1E3AC68", VA = "0x1E3AC68")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1E3E4E8", Offset = "0x1E3E4E8", VA = "0x1E3E4E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1E3E9F0", Offset = "0x1E3E9F0", VA = "0x1E3E9F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1E3FCE8", Offset = "0x1E3FCE8", VA = "0x1E3FCE8")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1E3FF70", Offset = "0x1E3FF70", VA = "0x1E3FF70")]
		private void Update()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1E4CF28", Offset = "0x1E4CF28", VA = "0x1E4CF28")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1E4E454", Offset = "0x1E4E454", VA = "0x1E4E454")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1E4F348", Offset = "0x1E4F348", VA = "0x1E4F348")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1E4F90C", Offset = "0x1E4F90C", VA = "0x1E4F90C")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1E39D80", Offset = "0x1E39D80", VA = "0x1E39D80")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1E50298", Offset = "0x1E50298", VA = "0x1E50298")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1E51530", Offset = "0x1E51530", VA = "0x1E51530")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1E52704", Offset = "0x1E52704", VA = "0x1E52704")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1E3D55C", Offset = "0x1E3D55C", VA = "0x1E3D55C")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1E5704C", Offset = "0x1E5704C", VA = "0x1E5704C")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1E57EC4", Offset = "0x1E57EC4", VA = "0x1E57EC4")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1E58470", Offset = "0x1E58470", VA = "0x1E58470")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1E599D4", Offset = "0x1E599D4", VA = "0x1E599D4")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1E5EA98", Offset = "0x1E5EA98", VA = "0x1E5EA98")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1E5F3D8", Offset = "0x1E5F3D8", VA = "0x1E5F3D8")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1E5F984", Offset = "0x1E5F984", VA = "0x1E5F984")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1E60A1C", Offset = "0x1E60A1C", VA = "0x1E60A1C")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1E6107C", Offset = "0x1E6107C", VA = "0x1E6107C")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1E622DC", Offset = "0x1E622DC", VA = "0x1E622DC")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1E63490", Offset = "0x1E63490", VA = "0x1E63490")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x1E64B70", Offset = "0x1E64B70", VA = "0x1E64B70")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1E66014", Offset = "0x1E66014", VA = "0x1E66014")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1E6727C", Offset = "0x1E6727C", VA = "0x1E6727C")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1E3C554", Offset = "0x1E3C554", VA = "0x1E3C554")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1E67B10", Offset = "0x1E67B10", VA = "0x1E67B10")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1E689F0", Offset = "0x1E689F0", VA = "0x1E689F0")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x1E55368", Offset = "0x1E55368", VA = "0x1E55368")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1E68444", Offset = "0x1E68444", VA = "0x1E68444")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1E69464", Offset = "0x1E69464", VA = "0x1E69464")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1E69BF8", Offset = "0x1E69BF8", VA = "0x1E69BF8")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1E4B990", Offset = "0x1E4B990", VA = "0x1E4B990")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1E38C10", Offset = "0x1E38C10", VA = "0x1E38C10")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1E3A358", Offset = "0x1E3A358", VA = "0x1E3A358")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1E4A404", Offset = "0x1E4A404", VA = "0x1E4A404")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1E5D73C", Offset = "0x1E5D73C", VA = "0x1E5D73C")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1E59FAC", Offset = "0x1E59FAC", VA = "0x1E59FAC")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1E730A0", Offset = "0x1E730A0", VA = "0x1E730A0")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1E6B3DC", Offset = "0x1E6B3DC", VA = "0x1E6B3DC")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1E74894", Offset = "0x1E74894", VA = "0x1E74894")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1E631B4", Offset = "0x1E631B4", VA = "0x1E631B4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1E4C080", Offset = "0x1E4C080", VA = "0x1E4C080")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1E73644", Offset = "0x1E73644", VA = "0x1E73644")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1E74D94", Offset = "0x1E74D94", VA = "0x1E74D94")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1E56350", Offset = "0x1E56350", VA = "0x1E56350")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1E73F84", Offset = "0x1E73F84", VA = "0x1E73F84")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1E46054", Offset = "0x1E46054", VA = "0x1E46054")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1E47FD0", Offset = "0x1E47FD0", VA = "0x1E47FD0")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1E4C35C", Offset = "0x1E4C35C", VA = "0x1E4C35C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1E6A218", Offset = "0x1E6A218", VA = "0x1E6A218")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1E77B9C", Offset = "0x1E77B9C", VA = "0x1E77B9C")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1E7874C", Offset = "0x1E7874C", VA = "0x1E7874C")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1E7977C", Offset = "0x1E7977C", VA = "0x1E7977C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF82F4", Offset = "0xCF82F4")]
		private bool <FindOtherControllerInSameSyncGroup>b__141_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1E79CEC", Offset = "0x1E79CEC", VA = "0x1E79CEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xCF8304", Offset = "0xCF8304")]
		private bool <FinishLoadingNewSong>b__149_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200004F")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x4000421")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x4000422")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000AC")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x2899644", Offset = "0x2899644", VA = "0x2899644")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AD")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x2899E68", Offset = "0x2899E68", VA = "0x2899E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x289A1BC", Offset = "0x289A1BC", VA = "0x289A1BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x2899B9C", Offset = "0x2899B9C", VA = "0x2899B9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x289A510", Offset = "0x289A510", VA = "0x289A510")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x284FF88", Offset = "0x284FF88", VA = "0x284FF88")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x2000050")]
	public static class UtilStrings
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x289A9A8", Offset = "0x289A9A8", VA = "0x289A9A8")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x289AE8C", Offset = "0x289AE8C", VA = "0x289AE8C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
