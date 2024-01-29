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
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class AudioClipOptimizer
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<int, string> AudioClipNameByInstanceId;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x8AA550", Offset = "0x8AA550", VA = "0x8AA550")]
	public static string CachedName(this AudioClip clip)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CC9C", Offset = "0x75CC9C")]
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
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x8C9538", Offset = "0x8C9538", VA = "0x8C9538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x8C9948", Offset = "0x8C9948", VA = "0x8C9948")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x8C9744", Offset = "0x8C9744", VA = "0x8C9744")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8C94C0", Offset = "0x8C94C0", VA = "0x8C94C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8A9DA8", Offset = "0x8A9DA8", VA = "0x8A9DA8")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8AA134", Offset = "0x8AA134", VA = "0x8AA134")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8C95F0", Offset = "0x8C95F0", VA = "0x8C95F0")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8C99D4", Offset = "0x8C99D4", VA = "0x8C99D4")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x15AAA6C", Offset = "0x15AAA6C", VA = "0x15AAA6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x15AAA74", Offset = "0x15AAA74", VA = "0x15AAA74")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x15AAA7C", Offset = "0x15AAA7C", VA = "0x15AAA7C")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x15AAA80", Offset = "0x15AAA80", VA = "0x15AAA80")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x15AAA84", Offset = "0x15AAA84", VA = "0x15AAA84")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x15AAA88", Offset = "0x15AAA88", VA = "0x15AAA88")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x15AAA8C", Offset = "0x15AAA8C", VA = "0x15AAA8C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x15AAA90", Offset = "0x15AAA90", VA = "0x15AAA90")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D120", Offset = "0x75D120")]
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
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float _playVolume;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _exitFadeTime;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000005")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1B2BB3C", Offset = "0x1B2BB3C", VA = "0x1B2BB3C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public GameObject GameObj
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1B2C720", Offset = "0x1B2C720", VA = "0x1B2C720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public Transform Trans
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1B2CCF0", Offset = "0x1B2CCF0", VA = "0x1B2CCF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1B2BA68", Offset = "0x1B2BA68", VA = "0x1B2BA68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1B2BBF4", Offset = "0x1B2BBF4", VA = "0x1B2BBF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1B2BDB0", Offset = "0x1B2BDB0", VA = "0x1B2BDB0")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1B2C6A8", Offset = "0x1B2C6A8", VA = "0x1B2C6A8")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1B2C7AC", Offset = "0x1B2C7AC", VA = "0x1B2C7AC")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1B2CC00", Offset = "0x1B2CC00", VA = "0x1B2CC00")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1B2C214", Offset = "0x1B2C214", VA = "0x1B2C214")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1B2CD7C", Offset = "0x1B2CD7C", VA = "0x1B2CD7C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1B2CE98", Offset = "0x1B2CE98", VA = "0x1B2CE98")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1B2BC60", Offset = "0x1B2BC60", VA = "0x1B2BC60")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1B2CF90", Offset = "0x1B2CF90", VA = "0x1B2CF90")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x75CCB0", Offset = "0x75CCB0")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x8AFC18", Offset = "0x8AFC18", VA = "0x8AFC18")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x75CCC4", Offset = "0x75CCC4")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x15AAA5C", Offset = "0x15AAA5C", VA = "0x15AAA5C")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x75CCD8", Offset = "0x75CCD8")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x15AAA64", Offset = "0x15AAA64", VA = "0x15AAA64")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x75CCEC", Offset = "0x75CCEC")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CCEC", Offset = "0x75CCEC")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D168", Offset = "0x75D168")]
		public bool FollowCaller;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D1A0", Offset = "0x75D1A0")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D1D8", Offset = "0x75D1D8")]
		public Transform RuntimeFollower;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000008")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x8A68D8", Offset = "0x8A68D8", VA = "0x8A68D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000009")]
		public Transform Trans
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x8A71D8", Offset = "0x8A71D8", VA = "0x8A71D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x8A64CC", Offset = "0x8A64CC", VA = "0x8A64CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x8A6788", Offset = "0x8A6788", VA = "0x8A6788")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x8A6DD8", Offset = "0x8A6DD8", VA = "0x8A6DD8")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x8A76C8", Offset = "0x8A76C8", VA = "0x8A76C8")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x8A77BC", Offset = "0x8A77BC", VA = "0x8A77BC")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x8A7BBC", Offset = "0x8A7BBC", VA = "0x8A7BBC")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x8A7DE4", Offset = "0x8A7DE4", VA = "0x8A7DE4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x8A8054", Offset = "0x8A8054", VA = "0x8A8054")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x8A82C4", Offset = "0x8A82C4", VA = "0x8A82C4")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x8A9144", Offset = "0x8A9144", VA = "0x8A9144")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x75CD3C", Offset = "0x75CD3C")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x400002C")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x400002D")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x8AFC40", Offset = "0x8AFC40", VA = "0x8AFC40")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x8AFEA4", Offset = "0x8AFEA4", VA = "0x8AFEA4")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x8B02BC", Offset = "0x8B02BC", VA = "0x8B02BC")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x8B0354", Offset = "0x8B0354", VA = "0x8B0354")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x8B05A0", Offset = "0x8B05A0", VA = "0x8B05A0")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CD74", Offset = "0x75CD74")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x75CD74", Offset = "0x75CD74")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x200000C")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40000B5")]
			Legacy,
			[Token(Token = "0x40000B6")]
			uGUI
		}

		[Token(Token = "0x200000D")]
		public enum EventType
		{
			[Token(Token = "0x40000B8")]
			OnStart,
			[Token(Token = "0x40000B9")]
			OnVisible,
			[Token(Token = "0x40000BA")]
			OnInvisible,
			[Token(Token = "0x40000BB")]
			OnCollision,
			[Token(Token = "0x40000BC")]
			OnTriggerEnter,
			[Token(Token = "0x40000BD")]
			OnTriggerExit,
			[Token(Token = "0x40000BE")]
			OnMouseEnter,
			[Token(Token = "0x40000BF")]
			OnMouseClick,
			[Token(Token = "0x40000C0")]
			OnSpawned,
			[Token(Token = "0x40000C1")]
			OnDespawned,
			[Token(Token = "0x40000C2")]
			OnEnable,
			[Token(Token = "0x40000C3")]
			OnDisable,
			[Token(Token = "0x40000C4")]
			OnCollision2D,
			[Token(Token = "0x40000C5")]
			OnTriggerEnter2D,
			[Token(Token = "0x40000C6")]
			OnTriggerExit2D,
			[Token(Token = "0x40000C7")]
			OnParticleCollision,
			[Token(Token = "0x40000C8")]
			UserDefinedEvent,
			[Token(Token = "0x40000C9")]
			OnCollisionExit,
			[Token(Token = "0x40000CA")]
			OnCollisionExit2D,
			[Token(Token = "0x40000CB")]
			OnMouseUp,
			[Token(Token = "0x40000CC")]
			OnMouseExit,
			[Token(Token = "0x40000CD")]
			OnMouseDrag,
			[Token(Token = "0x40000CE")]
			NGUIOnClick,
			[Token(Token = "0x40000CF")]
			NGUIMouseDown,
			[Token(Token = "0x40000D0")]
			NGUIMouseUp,
			[Token(Token = "0x40000D1")]
			NGUIMouseEnter,
			[Token(Token = "0x40000D2")]
			NGUIMouseExit,
			[Token(Token = "0x40000D3")]
			MechanimStateChanged,
			[Token(Token = "0x40000D4")]
			UnitySliderChanged,
			[Token(Token = "0x40000D5")]
			UnityButtonClicked,
			[Token(Token = "0x40000D6")]
			UnityPointerDown,
			[Token(Token = "0x40000D7")]
			UnityPointerUp,
			[Token(Token = "0x40000D8")]
			UnityPointerEnter,
			[Token(Token = "0x40000D9")]
			UnityPointerExit,
			[Token(Token = "0x40000DA")]
			UnityDrag,
			[Token(Token = "0x40000DB")]
			UnityDrop,
			[Token(Token = "0x40000DC")]
			UnityScroll,
			[Token(Token = "0x40000DD")]
			UnityUpdateSelected,
			[Token(Token = "0x40000DE")]
			UnitySelect,
			[Token(Token = "0x40000DF")]
			UnityDeselect,
			[Token(Token = "0x40000E0")]
			UnityMove,
			[Token(Token = "0x40000E1")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40000E2")]
			UnityBeginDrag,
			[Token(Token = "0x40000E3")]
			UnityEndDrag,
			[Token(Token = "0x40000E4")]
			UnitySubmit,
			[Token(Token = "0x40000E5")]
			UnityCancel,
			[Token(Token = "0x40000E6")]
			UnityToggle,
			[Token(Token = "0x40000E7")]
			OnTriggerStay,
			[Token(Token = "0x40000E8")]
			OnTriggerStay2D,
			[Token(Token = "0x40000E9")]
			CodeTriggeredEvent1,
			[Token(Token = "0x40000EA")]
			CodeTriggeredEvent2
		}

		[Token(Token = "0x200000E")]
		public enum GlidePitchType
		{
			[Token(Token = "0x40000EC")]
			None,
			[Token(Token = "0x40000ED")]
			RaisePitch,
			[Token(Token = "0x40000EE")]
			LowerPitch
		}

		[Token(Token = "0x200000F")]
		public enum VariationType
		{
			[Token(Token = "0x40000F0")]
			PlaySpecific,
			[Token(Token = "0x40000F1")]
			PlayRandom
		}

		[Token(Token = "0x2000010")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40000F3")]
			None,
			[Token(Token = "0x40000F4")]
			Stop,
			[Token(Token = "0x40000F5")]
			FadeOut
		}

		[Token(Token = "0x2000011")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40000F7")]
			None,
			[Token(Token = "0x40000F8")]
			FrameBased,
			[Token(Token = "0x40000F9")]
			TimeBased
		}

		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CDC4", Offset = "0x75CDC4")]
		private sealed class <CoUpdate>d__127 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x1B2E454", Offset = "0x1B2E454", VA = "0x1B2E454", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x1B2E49C", Offset = "0x1B2E49C", VA = "0x1B2E49C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1B2E290", Offset = "0x1B2E290", VA = "0x1B2E290")]
			[DebuggerHidden]
			public <CoUpdate>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1B2E2BC", Offset = "0x1B2E2BC", VA = "0x1B2E2BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1B2E2C0", Offset = "0x1B2E2C0", VA = "0x1B2E2C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600007B")]
			[Address(RVA = "0x1B2E45C", Offset = "0x1B2E45C", VA = "0x1B2E45C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup codeTriggeredEvent1Sound;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup codeTriggeredEvent2Sound;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useStartSound;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useVisibleSound;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useInvisibleSound;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useCollisionSound;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useDespawnedSound;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useEnableSound;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useDisableSound;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useCollision2dSound;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useCodeTriggeredEvent1Sound;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useCodeTriggeredEvent2Sound;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E7")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E9")]
		public bool useUnityDragSound;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EA")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EB")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1ED")]
		public bool useUnityDropSound;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EE")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EF")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F1")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F2")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F3")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F5")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F6")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F7")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Slider _slider;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Toggle _toggle;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Button _button;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private bool _isVisible;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x219")]
		private bool _needsCoroutine;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private float? _triggerEnterTime;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Transform _trans;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Animator _anim;

		[Token(Token = "0x1700000A")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x8B6954", Offset = "0x8B6954", VA = "0x8B6954")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x8B886C", Offset = "0x8B886C", VA = "0x8B886C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x8B6868", Offset = "0x8B6868", VA = "0x8B6868")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x8B6BD0", Offset = "0x8B6BD0", VA = "0x8B6BD0", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x8B6D30", Offset = "0x8B6D30", VA = "0x8B6D30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75DD0C", Offset = "0x75DD0C")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x8B6D9C", Offset = "0x8B6D9C", VA = "0x8B6D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x8B7474", Offset = "0x8B7474", VA = "0x8B7474")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x8B749C", Offset = "0x8B749C", VA = "0x8B749C")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x8B74B8", Offset = "0x8B74B8", VA = "0x8B74B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x8B7774", Offset = "0x8B7774", VA = "0x8B7774")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x8B7B00", Offset = "0x8B7B00", VA = "0x8B7B00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x8B7F44", Offset = "0x8B7F44", VA = "0x8B7F44")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x8B8060", Offset = "0x8B8060", VA = "0x8B8060")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x8B817C", Offset = "0x8B817C", VA = "0x8B817C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x8B82C4", Offset = "0x8B82C4", VA = "0x8B82C4")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x8B83C0", Offset = "0x8B83C0", VA = "0x8B83C0")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x8B84E4", Offset = "0x8B84E4", VA = "0x8B84E4")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x8B8600", Offset = "0x8B8600", VA = "0x8B8600")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x8B8620", Offset = "0x8B8620", VA = "0x8B8620")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x8B8640", Offset = "0x8B8640", VA = "0x8B8640")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x8B8660", Offset = "0x8B8660", VA = "0x8B8660")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x8B8680", Offset = "0x8B8680", VA = "0x8B8680")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x8B8684", Offset = "0x8B8684", VA = "0x8B8684")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x8B86A4", Offset = "0x8B86A4", VA = "0x8B86A4")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x8B86A8", Offset = "0x8B86A8", VA = "0x8B86A8")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x8B86C8", Offset = "0x8B86C8", VA = "0x8B86C8")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x8B86E8", Offset = "0x8B86E8", VA = "0x8B86E8")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x8B8708", Offset = "0x8B8708", VA = "0x8B8708")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x8B870C", Offset = "0x8B870C", VA = "0x8B870C")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x8B872C", Offset = "0x8B872C", VA = "0x8B872C")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x8B874C", Offset = "0x8B874C", VA = "0x8B874C")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x8B876C", Offset = "0x8B876C", VA = "0x8B876C")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x8B878C", Offset = "0x8B878C", VA = "0x8B878C")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x8B87AC", Offset = "0x8B87AC", VA = "0x8B87AC")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x8B87CC", Offset = "0x8B87CC", VA = "0x8B87CC")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x8B87EC", Offset = "0x8B87EC", VA = "0x8B87EC")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x8B880C", Offset = "0x8B880C", VA = "0x8B880C")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x8B883C", Offset = "0x8B883C", VA = "0x8B883C")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x8B8854", Offset = "0x8B8854", VA = "0x8B8854")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x8B887C", Offset = "0x8B887C", VA = "0x8B887C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x8B88B4", Offset = "0x8B88B4", VA = "0x8B88B4")]
		private void OnClick()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x8B88D4", Offset = "0x8B88D4", VA = "0x8B88D4")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x8B890C", Offset = "0x8B890C", VA = "0x8B890C")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x8B895C", Offset = "0x8B895C", VA = "0x8B895C")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x8B897C", Offset = "0x8B897C", VA = "0x8B897C")]
		public void ActivateCodeTriggeredEvent1()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x8B8994", Offset = "0x8B8994", VA = "0x8B8994")]
		public void ActivateCodeTriggeredEvent2()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x8B89AC", Offset = "0x8B89AC", VA = "0x8B89AC")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x8B8A54", Offset = "0x8B8A54", VA = "0x8B8A54")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x8B8C38", Offset = "0x8B8C38", VA = "0x8B8C38")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x8B8E64", Offset = "0x8B8E64", VA = "0x8B8E64")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x8B7214", Offset = "0x8B7214", VA = "0x8B7214")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x8BB4BC", Offset = "0x8BB4BC", VA = "0x8BB4BC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x8BB6A4", Offset = "0x8BB6A4", VA = "0x8BB6A4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x8B8F1C", Offset = "0x8B8F1C", VA = "0x8B8F1C")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x8B9090", Offset = "0x8B9090", VA = "0x8B9090")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x8C49E8", Offset = "0x8C49E8", VA = "0x8C49E8")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x8B6DDC", Offset = "0x8B6DDC", VA = "0x8B6DDC", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x8C4E14", Offset = "0x8C4E14", VA = "0x8C4E14", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x8C4EF0", Offset = "0x8C4EF0", VA = "0x8C4EF0", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x8B7A68", Offset = "0x8B7A68", VA = "0x8B7A68", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x8B7EB4", Offset = "0x8B7EB4", VA = "0x8B7EB4", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x8C5908", Offset = "0x8C5908", VA = "0x8C5908", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x8B6964", Offset = "0x8B6964", VA = "0x8B6964")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x6000074")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x8C595C", Offset = "0x8C595C", VA = "0x8C595C")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D210", Offset = "0x75D210")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700000E")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x8C68D0", Offset = "0x8C68D0", VA = "0x8C68D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDBC", Offset = "0x75DDBC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x8C68D8", Offset = "0x8C68D8", VA = "0x8C68D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDCC", Offset = "0x75DDCC")]
			set
			{
			}
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x8C5F60", Offset = "0x8C5F60", VA = "0x8C5F60")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x8C64C8", Offset = "0x8C64C8", VA = "0x8C64C8", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x8C656C", Offset = "0x8C656C", VA = "0x8C656C")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x8C6574", Offset = "0x8C6574", VA = "0x8C6574", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x8C6618", Offset = "0x8C6618", VA = "0x8C6618")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x8C641C", Offset = "0x8C641C", VA = "0x8C641C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x8C64C0", Offset = "0x8C64C0", VA = "0x8C64C0")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000017")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x8C6620", Offset = "0x8C6620", VA = "0x8C6620", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x8C66C4", Offset = "0x8C66C4", VA = "0x8C66C4")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x8C60C0", Offset = "0x8C60C0", VA = "0x8C60C0", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8C6164", Offset = "0x8C6164", VA = "0x8C6164")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x8C616C", Offset = "0x8C616C", VA = "0x8C616C", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x8C6210", Offset = "0x8C6210", VA = "0x8C6210")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x8C66CC", Offset = "0x8C66CC", VA = "0x8C66CC", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x8C6770", Offset = "0x8C6770", VA = "0x8C6770")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x8C68E0", Offset = "0x8C68E0", VA = "0x8C68E0", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x8C6984", Offset = "0x8C6984", VA = "0x8C6984")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x8C6778", Offset = "0x8C6778", VA = "0x8C6778", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x8C681C", Offset = "0x8C681C", VA = "0x8C681C")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x8C6014", Offset = "0x8C6014", VA = "0x8C6014", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x8C60B8", Offset = "0x8C60B8", VA = "0x8C60B8")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x8C6370", Offset = "0x8C6370", VA = "0x8C6370", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x8C6414", Offset = "0x8C6414", VA = "0x8C6414")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x8C62C4", Offset = "0x8C62C4", VA = "0x8C62C4", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x8C6368", Offset = "0x8C6368", VA = "0x8C6368")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x8C5EB4", Offset = "0x8C5EB4", VA = "0x8C5EB4", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x8C5F58", Offset = "0x8C5F58", VA = "0x8C5F58")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x8C6218", Offset = "0x8C6218", VA = "0x8C6218", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x8C62BC", Offset = "0x8C62BC", VA = "0x8C62BC")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x8C6824", Offset = "0x8C6824", VA = "0x8C6824", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x8C68C8", Offset = "0x8C68C8", VA = "0x8C68C8")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x8C5F68", Offset = "0x8C5F68", VA = "0x8C5F68", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x8C600C", Offset = "0x8C600C", VA = "0x8C600C")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x75CDD4", Offset = "0x75CDD4")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x2000025")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000108")]
			None,
			[Token(Token = "0x4000109")]
			OnCollision,
			[Token(Token = "0x400010A")]
			OnTriggerEnter,
			[Token(Token = "0x400010B")]
			OnCollision2D,
			[Token(Token = "0x400010C")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000F")]
		private Transform Trans
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x8C9078", Offset = "0x8C9078", VA = "0x8C9078")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x8C8C1C", Offset = "0x8C8C1C", VA = "0x8C8C1C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x8C8F98", Offset = "0x8C8F98", VA = "0x8C8F98")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x8C8FE8", Offset = "0x8C8FE8", VA = "0x8C8FE8")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x8C8C6C", Offset = "0x8C8C6C", VA = "0x8C8C6C")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x8C9104", Offset = "0x8C9104", VA = "0x8C9104")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D220", Offset = "0x75D220")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D220", Offset = "0x75D220")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D280", Offset = "0x75D280")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D280", Offset = "0x75D280")]
		public bool fireEnterEvent;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D2F0", Offset = "0x75D2F0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D2F0", Offset = "0x75D2F0")]
		public bool fireExitEvent;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D360", Offset = "0x75D360")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D360", Offset = "0x75D360")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D3C0", Offset = "0x75D3C0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D3C0", Offset = "0x75D3C0")]
		public float whenToFireEvent;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D424", Offset = "0x75D424")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D424", Offset = "0x75D424")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D484", Offset = "0x75D484")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D49C", Offset = "0x75D49C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D49C", Offset = "0x75D49C")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D4F0", Offset = "0x75D4F0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D4F0", Offset = "0x75D4F0")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D544", Offset = "0x75D544")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D544", Offset = "0x75D544")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D598", Offset = "0x75D598")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D598", Offset = "0x75D598")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x159FB60", Offset = "0x159FB60", VA = "0x159FB60", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x159FCE4", Offset = "0x159FCE4", VA = "0x159FCE4", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x15A000C", Offset = "0x15A000C", VA = "0x15A000C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x159FC44", Offset = "0x159FC44", VA = "0x159FC44")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x15A00EC", Offset = "0x15A00EC", VA = "0x15A00EC")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D5FC", Offset = "0x75D5FC")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D634", Offset = "0x75D634")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D634", Offset = "0x75D634")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D694", Offset = "0x75D694")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D694", Offset = "0x75D694")]
		public bool playEnterSound;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D704", Offset = "0x75D704")]
		public string enterVariationName;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D73C", Offset = "0x75D73C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D73C", Offset = "0x75D73C")]
		public bool playExitSound;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D7AC", Offset = "0x75D7AC")]
		public string exitVariationName;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D7E4", Offset = "0x75D7E4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D7E4", Offset = "0x75D7E4")]
		public bool playAnimTimeSound;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D844", Offset = "0x75D844")]
		public bool useStopTime;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D87C", Offset = "0x75D87C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D87C", Offset = "0x75D87C")]
		public float whenToStartSound;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D8D0", Offset = "0x75D8D0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D8D0", Offset = "0x75D8D0")]
		public float whenToStopSound;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D934", Offset = "0x75D934")]
		public string timedVariationName;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D96C", Offset = "0x75D96C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x75D96C", Offset = "0x75D96C")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D9CC", Offset = "0x75D9CC")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75D9E4", Offset = "0x75D9E4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75D9E4", Offset = "0x75D9E4")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75DA38", Offset = "0x75DA38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DA38", Offset = "0x75DA38")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75DA8C", Offset = "0x75DA8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DA8C", Offset = "0x75DA8C")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75DAE0", Offset = "0x75DAE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DAE0", Offset = "0x75DAE0")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x75DB44", Offset = "0x75DB44")]
		public string multiTimedVariationName;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x15A0164", Offset = "0x15A0164", VA = "0x15A0164", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x15A03D8", Offset = "0x15A03D8", VA = "0x15A03D8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x15A0B90", Offset = "0x15A0B90", VA = "0x15A0B90", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x15A02E0", Offset = "0x15A02E0", VA = "0x15A02E0")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x15A0380", Offset = "0x15A0380", VA = "0x15A0380")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x15A0DD8", Offset = "0x15A0DD8", VA = "0x15A0DD8")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB7C", Offset = "0x75DB7C")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB8C", Offset = "0x75DB8C")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DB9C", Offset = "0x75DB9C")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x17000010")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x15A2EF4", Offset = "0x15A2EF4", VA = "0x15A2EF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDDC", Offset = "0x75DDDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x15A2EFC", Offset = "0x15A2EFC", VA = "0x15A2EFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDEC", Offset = "0x75DDEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x15A2F08", Offset = "0x15A2F08", VA = "0x15A2F08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DDFC", Offset = "0x75DDFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x15A2F10", Offset = "0x15A2F10", VA = "0x15A2F10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE0C", Offset = "0x75DE0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x15A2F1C", Offset = "0x15A2F1C", VA = "0x15A2F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE1C", Offset = "0x75DE1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x15A2F24", Offset = "0x15A2F24", VA = "0x15A2F24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE2C", Offset = "0x75DE2C")]
			set
			{
			}
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x15A2EC8", Offset = "0x15A2EC8", VA = "0x15A2EC8")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x8A91DC", Offset = "0x8A91DC", VA = "0x8A91DC")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002A")]
	public class AudioEvent
	{
		[Token(Token = "0x200002B")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000173")]
			UseSliderValue,
			[Token(Token = "0x4000174")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x200002C")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000175")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x1B2D1BC", Offset = "0x1B2D1BC", VA = "0x1B2D1BC")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000013")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x8AA740", Offset = "0x8AA740", VA = "0x8AA740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x8AA7A8", Offset = "0x8AA7A8", VA = "0x8AA7A8")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002D")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x8AA954", Offset = "0x8AA954", VA = "0x8AA954")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x8ACCC0", Offset = "0x8ACCC0", VA = "0x8ACCC0")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002F")]
	public class BusFadeInfo
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x8AFC20", Offset = "0x8AFC20", VA = "0x8AFC20")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x8AFC30", Offset = "0x8AFC30", VA = "0x8AFC30")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000031")]
	public class CustomEvent
	{
		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x17000014")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x8B08D0", Offset = "0x8B08D0", VA = "0x8B08D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x8B0708", Offset = "0x8B0708", VA = "0x8B0708")]
		public CustomEvent(string eventName)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x8B07CC", Offset = "0x8B07CC", VA = "0x8B07CC")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x8B086C", Offset = "0x8B086C", VA = "0x8B086C")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000032")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x17000015")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x8B0A28", Offset = "0x8B0A28", VA = "0x8B0A28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x8B0924", Offset = "0x8B0924", VA = "0x8B0924")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x8B09C4", Offset = "0x8B09C4", VA = "0x8B09C4")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x8B0A7C", Offset = "0x8B0A7C", VA = "0x8B0A7C")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x8B0B1C", Offset = "0x8B0B1C", VA = "0x8B0B1C")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000034")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x8B0D98", Offset = "0x8B0D98", VA = "0x8B0D98")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DBAC", Offset = "0x75DBAC")]
		public int probabilityToPlay;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DBC4", Offset = "0x75DBC4")]
		public int importance;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isUninterruptible;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useLocalization;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool useRandomPitch;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int weight;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string clipAlias;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string resourceFileName;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool isExpanded;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool isChecked;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool useFades;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float fadeInTime;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeOutTime;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool useCustomLooping;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int minCustomLoops;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int maxCustomLoops;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool useIntroSilence;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float introSilenceMin;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float introSilenceMax;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool useRandomStartTime;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomStartMinPercent;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float randomEndPercent;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Transform _trans;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource _aud;

		[Token(Token = "0x17000016")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x8B0E00", Offset = "0x8B0E00", VA = "0x8B0E00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x8B0EA0", Offset = "0x8B0EA0", VA = "0x8B0EA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x8B0F40", Offset = "0x8B0F40", VA = "0x8B0F40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x8B0FE0", Offset = "0x8B0FE0", VA = "0x8B0FE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x8B1080", Offset = "0x8B1080", VA = "0x8B1080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x8B1120", Offset = "0x8B1120", VA = "0x8B1120")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x8B11C0", Offset = "0x8B11C0", VA = "0x8B11C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public Transform Trans
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x8B1340", Offset = "0x8B1340", VA = "0x8B1340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x8B13CC", Offset = "0x8B13CC", VA = "0x8B13CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x8B1620", Offset = "0x8B1620", VA = "0x8B1620")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x8B16C0", Offset = "0x8B16C0", VA = "0x8B16C0")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool ignoreListenerPause;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DBDC", Offset = "0x75DBDC")]
		public int importance;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool isUninterruptible;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float spatialBlend;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string busName;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isExistingBus;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public int limitPerXFrames;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool limitPolyphony;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int voiceLimitCount;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float despawnFadeTime;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x8B16FC", Offset = "0x8B16FC", VA = "0x8B16FC")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000037")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x8C8AA0", Offset = "0x8C8AA0", VA = "0x8C8AA0")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000038")]
	public class GroupBus
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isExisting;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isTemporary;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.BusVoiceLimitExceededMode busVoiceLimitExceededMode;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color busColor;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool forceTo2D;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _originalVolume;

		[Token(Token = "0x17000020")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x8C9298", Offset = "0x8C9298", VA = "0x8C9298")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000021")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x8B33E4", Offset = "0x8B33E4", VA = "0x8B33E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x8C92E4", Offset = "0x8C92E4", VA = "0x8C92E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x8C934C", Offset = "0x8C934C", VA = "0x8C934C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x8C9354", Offset = "0x8C9354", VA = "0x8C9354")]
			set
			{
			}
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x8B45E8", Offset = "0x8B45E8", VA = "0x8B45E8")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x8B3380", Offset = "0x8B3380", VA = "0x8B3380")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x8C9194", Offset = "0x8C9194", VA = "0x8C9194")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x8C9234", Offset = "0x8C9234", VA = "0x8C9234")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x8C935C", Offset = "0x8C935C", VA = "0x8C935C")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x8C9430", Offset = "0x8C9430", VA = "0x8C9430")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x8C9440", Offset = "0x8C9440", VA = "0x8C9440")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x60000E3")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x60000E4")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60000E5")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60000E6")]
		void RegisterReceiver();

		[Token(Token = "0x60000E7")]
		void UnregisterReceiver();

		[Token(Token = "0x60000E8")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x200003C")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x200003D")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x400027D")]
			None,
			[Token(Token = "0x400027E")]
			Stop,
			[Token(Token = "0x400027F")]
			FadeOut
		}

		[Token(Token = "0x200003E")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000281")]
			Randomized,
			[Token(Token = "0x4000282")]
			TopToBottom
		}

		[Token(Token = "0x200003F")]
		public enum VariationMode
		{
			[Token(Token = "0x4000284")]
			Normal,
			[Token(Token = "0x4000285")]
			LoopedChain,
			[Token(Token = "0x4000286")]
			Dialog
		}

		[Token(Token = "0x2000040")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000288")]
			Endless,
			[Token(Token = "0x4000289")]
			NumberOfLoops
		}

		[Token(Token = "0x2000041")]
		public enum LimitMode
		{
			[Token(Token = "0x400028B")]
			None,
			[Token(Token = "0x400028C")]
			FrameBased,
			[Token(Token = "0x400028D")]
			TimeBased
		}

		[Token(Token = "0x400023D")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x400023E")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x400023F")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.DefaultGroupPlayType groupPlayType;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool isSelected;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isExpanded;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float groupMasterVolume;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int retriggerPercentage;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ignoreListenerPause;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DBF4", Offset = "0x75DBF4")]
		public int importance;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isUninterruptible;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMin;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float chainLoopDelayMax;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string comments;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool logSound;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x82")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public LimitMode limitMode;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int limitPerXFrames;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		public bool limitPolyphony;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int voiceLimitCount;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float despawnFadeTime;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public bool isSoloed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
		public bool isMuted;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD2")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int frames;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _objectName;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Transform _trans;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float _originalVolume;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly List<int> _actorInstanceIds;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC1C", Offset = "0x75DC1C")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x17000024")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x159F2CC", Offset = "0x159F2CC", VA = "0x159F2CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000025")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x159F3B8", Offset = "0x159F3B8", VA = "0x159F3B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000026")]
		public int TotalVoices
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x159F408", Offset = "0x159F408", VA = "0x159F408")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000027")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x159F42C", Offset = "0x159F42C", VA = "0x159F42C")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x159F04C", Offset = "0x159F04C", VA = "0x159F04C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x159F438", Offset = "0x159F438", VA = "0x159F438")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x159F440", Offset = "0x159F440", VA = "0x159F440")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x159F448", Offset = "0x159F448", VA = "0x159F448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x159F4E4", Offset = "0x159F4E4", VA = "0x159F4E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE5C", Offset = "0x75DE5C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x159F4EC", Offset = "0x159F4EC", VA = "0x159F4EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE6C", Offset = "0x75DE6C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public string GameObjectName
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x159F4F4", Offset = "0x159F4F4", VA = "0x159F4F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public MasterAudio.GroupPlayType GroupPlayType
		{
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x159F538", Offset = "0x159F538", VA = "0x159F538")]
			get
			{
				return default(MasterAudio.GroupPlayType);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool HasLiveActors
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x159F684", Offset = "0x159F684", VA = "0x159F684")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x159F6D8", Offset = "0x159F6D8", VA = "0x159F6D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		private Transform Trans
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x159EF00", Offset = "0x159EF00", VA = "0x159EF00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x159EE58", Offset = "0x159EE58", VA = "0x159EE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x159EC08", Offset = "0x159EC08", VA = "0x159EC08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE3C", Offset = "0x75DE3C")]
			add
			{
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x159ECA8", Offset = "0x159ECA8", VA = "0x159ECA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE4C", Offset = "0x75DE4C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x159ED48", Offset = "0x159ED48", VA = "0x159ED48")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x159EF8C", Offset = "0x159EF8C", VA = "0x159EF8C")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x159F138", Offset = "0x159F138", VA = "0x159F138")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x159F1C8", Offset = "0x159F1C8", VA = "0x159F1C8")]
		public void AddActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x159F268", Offset = "0x159F268", VA = "0x159F268")]
		public void RemoveActorInstanceId(int instanceId)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x159F4C0", Offset = "0x159F4C0", VA = "0x159F4C0")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x159F4D4", Offset = "0x159F4D4", VA = "0x159F4D4")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x159F4DC", Offset = "0x159F4DC", VA = "0x159F4DC")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x159F748", Offset = "0x159F748", VA = "0x159F748")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class MasterAudioSettings : SingletonScriptable<MasterAudioSettings>
	{
		[Token(Token = "0x400028E")]
		public const string AssetName = "MasterAudioSettings.asset";

		[Token(Token = "0x400028F")]
		public const string AssetFolder = "Assets/Resources/MasterAudio";

		[Token(Token = "0x4000290")]
		public const string ResourcePath = "MasterAudio/MasterAudioSettings";

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseDbScale;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool RemoveUnplayedDueToProbabilityVariation;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool UseCentsPitch;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool HideLogoNav;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool EditMAFolder;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string InstallationFolderPath;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MasterAudio.MixerWidthMode MixerWidthSetting;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool BusesShownInNarrow;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool ShowWelcomeWindowOnStart;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x159F934", Offset = "0x159F934", VA = "0x159F934")]
		static MasterAudioSettings()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x159FAB4", Offset = "0x159FAB4", VA = "0x159FAB4")]
		public MasterAudioSettings()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x159FB58", Offset = "0x159FB58", VA = "0x159FB58")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class MusicSetting
	{
		[Token(Token = "0x2000045")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CE1C", Offset = "0x75CE1C")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1B2F758", Offset = "0x1B2F758", VA = "0x1B2F758")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1B2F760", Offset = "0x1B2F760", VA = "0x1B2F760")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000046")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CE2C", Offset = "0x75CE2C")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1B2F78C", Offset = "0x1B2F78C", VA = "0x1B2F78C")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x600010F")]
			[Address(RVA = "0x1B2F794", Offset = "0x1B2F794", VA = "0x1B2F794")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CE3C", Offset = "0x75CE3C")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1B2F7C0", Offset = "0x1B2F7C0", VA = "0x1B2F7C0")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x6000111")]
			[Address(RVA = "0x1B2F7C8", Offset = "0x1B2F7C8", VA = "0x1B2F7C8")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CE4C", Offset = "0x75CE4C")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x40002B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x6000112")]
			[Address(RVA = "0x1B2F7F4", Offset = "0x1B2F7F4", VA = "0x1B2F7F4")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x6000113")]
			[Address(RVA = "0x1B2F7FC", Offset = "0x1B2F7FC", VA = "0x1B2F7FC")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x17000032")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x15A1008", Offset = "0x15A1008", VA = "0x15A1008")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x15A1024", Offset = "0x15A1024", VA = "0x15A1024")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000034")]
		public float SongStartTime
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x15A10C4", Offset = "0x15A10C4", VA = "0x15A10C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x15A0E50", Offset = "0x15A0E50", VA = "0x15A0E50")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x15A10F0", Offset = "0x15A10F0", VA = "0x15A10F0")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x15A1870", Offset = "0x15A1870", VA = "0x15A1870")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x15A2F2C", Offset = "0x15A2F2C", VA = "0x15A2F2C")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004B")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x15A1808", Offset = "0x15A1808", VA = "0x15A1808")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004C")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x15A17D4", Offset = "0x15A17D4", VA = "0x15A17D4")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x15A183C", Offset = "0x15A183C", VA = "0x15A183C")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004E")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x200004F")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x40002CB")]
			Boolean,
			[Token(Token = "0x40002CC")]
			String,
			[Token(Token = "0x40002CD")]
			Integer,
			[Token(Token = "0x40002CE")]
			Float
		}

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x15AAA94", Offset = "0x15AAA94", VA = "0x15AAA94")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000050")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x15A17A0", Offset = "0x15A17A0", VA = "0x15A17A0")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x15AAAF8", Offset = "0x15AAAF8", VA = "0x15AAAF8")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75CE5C", Offset = "0x75CE5C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CE5C", Offset = "0x75CE5C")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000054")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000055")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1B307DC", Offset = "0x1B307DC", VA = "0x1B307DC")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000056")]
		public enum PitchMode
		{
			[Token(Token = "0x4000325")]
			None,
			[Token(Token = "0x4000326")]
			Gliding
		}

		[Token(Token = "0x2000057")]
		public enum FadeMode
		{
			[Token(Token = "0x4000328")]
			None,
			[Token(Token = "0x4000329")]
			FadeInOut,
			[Token(Token = "0x400032A")]
			FadeOutEarly,
			[Token(Token = "0x400032B")]
			GradualFade
		}

		[Token(Token = "0x2000058")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x400032D")]
			AddToClipPitch,
			[Token(Token = "0x400032E")]
			IgnoreClipPitch
		}

		[Token(Token = "0x2000059")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000330")]
			AddToClipVolume,
			[Token(Token = "0x4000331")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200005A")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000333")]
			None,
			[Token(Token = "0x4000334")]
			DetectEnd
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CED0", Offset = "0x75CED0")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__112 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600017A")]
				[Address(RVA = "0x1B3078C", Offset = "0x1B3078C", VA = "0x1B3078C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600017C")]
				[Address(RVA = "0x1B307D4", Offset = "0x1B307D4", VA = "0x1B307D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1B3068C", Offset = "0x1B3068C", VA = "0x1B3068C")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__112(int <>1__state)
			{
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1B306B8", Offset = "0x1B306B8", VA = "0x1B306B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1B306BC", Offset = "0x1B306BC", VA = "0x1B306BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1B30794", Offset = "0x1B30794", VA = "0x1B30794", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DC2C", Offset = "0x75DC2C")]
		public int probabilityToPlay;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x75DC44", Offset = "0x75DC44")]
		public int importance;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isUninterruptible;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool useLocalization;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool useRandomPitch;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMin;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float randomPitchMax;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool useRandomVolume;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMin;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float randomVolumeMax;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string clipAlias;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string resourceFileName;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_pitch;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float original_volume;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool isExpanded;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool isChecked;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool useFades;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeInTime;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float fadeOutTime;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useCustomLooping;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int minCustomLoops;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public int maxCustomLoops;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float randomEndPercent;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool useIntroSilence;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMin;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float introSilenceMax;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public int frames;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private string _objectName;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _maxVol;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _instanceId;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool? _audioLoops;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _maxLoops;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private string _soundGroupName;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private bool _isStopRequested;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x125")]
		private bool _isPaused;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x126")]
		private bool _isWarmingPlay;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _trans;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private GameObject _go;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _attachToSource;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private string _resFileName;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC7C", Offset = "0x75DC7C")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x17000035")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x15AEEBC", Offset = "0x15AEEBC", VA = "0x15AEEBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x15AEF5C", Offset = "0x15AEF5C", VA = "0x15AEF5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x15AEFFC", Offset = "0x15AEFFC", VA = "0x15AEFFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x15AF09C", Offset = "0x15AF09C", VA = "0x15AF09C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x15AF13C", Offset = "0x15AF13C", VA = "0x15AF13C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x15AF144", Offset = "0x15AF144", VA = "0x15AF144")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x15AF14C", Offset = "0x15AF14C", VA = "0x15AF14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x15AF1EC", Offset = "0x15AF1EC", VA = "0x15AF1EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x15AF1F4", Offset = "0x15AF1F4", VA = "0x15AF1F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x15AF340", Offset = "0x15AF340", VA = "0x15AF340")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x15AF348", Offset = "0x15AF348", VA = "0x15AF348")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x15AF350", Offset = "0x15AF350", VA = "0x15AF350")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x15AB554", Offset = "0x15AB554", VA = "0x15AB554")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x15AC6C8", Offset = "0x15AC6C8", VA = "0x15AC6C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000040")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x15AF594", Offset = "0x15AF594", VA = "0x15AF594")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000041")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x15AF5D4", Offset = "0x15AF5D4", VA = "0x15AF5D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x15AF610", Offset = "0x15AF610", VA = "0x15AF610")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x15AF6B8", Offset = "0x15AF6B8", VA = "0x15AF6B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DF1C", Offset = "0x75DF1C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x15AF6C0", Offset = "0x15AF6C0", VA = "0x15AF6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DF2C", Offset = "0x75DF2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x15AF6C8", Offset = "0x15AF6C8", VA = "0x15AF6C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool IsPlaying
		{
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x15AD6C4", Offset = "0x15AD6C4", VA = "0x15AD6C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x15AF6D8", Offset = "0x15AF6D8", VA = "0x15AF6D8")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x15AC5A4", Offset = "0x15AC5A4", VA = "0x15AC5A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int InstanceId
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x15ACDF0", Offset = "0x15ACDF0", VA = "0x15ACDF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public bool IsStopRequested
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x15AF6E0", Offset = "0x15AF6E0", VA = "0x15AF6E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000049")]
		public Transform Trans
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x15AE2CC", Offset = "0x15AE2CC", VA = "0x15AE2CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public GameObject GameObj
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x15AB2B8", Offset = "0x15AB2B8", VA = "0x15AB2B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x15AB218", Offset = "0x15AB218", VA = "0x15AB218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x15ACD34", Offset = "0x15ACD34", VA = "0x15ACD34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public string ResFileName
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x15ACA38", Offset = "0x15ACA38", VA = "0x15ACA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0x15ABA7C", Offset = "0x15ABA7C", VA = "0x15ABA7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x15AF6E8", Offset = "0x15AF6E8", VA = "0x15AF6E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x15AF6F0", Offset = "0x15AF6F0", VA = "0x15AF6F0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x15AF70C", Offset = "0x15AF70C", VA = "0x15AF70C")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public int MaxLoops
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x15AF728", Offset = "0x15AF728", VA = "0x15AF728")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000052")]
		private bool Is2D
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x15AF730", Offset = "0x15AF730", VA = "0x15AF730")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x15ABC1C", Offset = "0x15ABC1C", VA = "0x15ABC1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool IsPaused
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x15AF75C", Offset = "0x15AF75C", VA = "0x15AF75C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public string GameObjectName
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x15AF778", Offset = "0x15AF778", VA = "0x15AF778")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x15AAD9C", Offset = "0x15AAD9C", VA = "0x15AAD9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE7C", Offset = "0x75DE7C")]
			add
			{
			}
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x15AAE40", Offset = "0x15AAE40", VA = "0x15AAE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE8C", Offset = "0x75DE8C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x15AAEE4", Offset = "0x15AAEE4", VA = "0x15AAEE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DE9C", Offset = "0x75DE9C")]
			add
			{
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x15AAF88", Offset = "0x15AAF88", VA = "0x15AAF88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DEAC", Offset = "0x75DEAC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x15AB02C", Offset = "0x15AB02C", VA = "0x15AB02C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x15AB344", Offset = "0x15AB344", VA = "0x15AB344")]
		private void Start()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x15AB724", Offset = "0x15AB724", VA = "0x15AB724")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x15AB778", Offset = "0x15AB778", VA = "0x15AB778")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x15AB920", Offset = "0x15AB920", VA = "0x15AB920")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x15AB874", Offset = "0x15AB874", VA = "0x15AB874")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x15ABDA8", Offset = "0x15ABDA8", VA = "0x15ABDA8")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x15ABE4C", Offset = "0x15ABE4C", VA = "0x15ABE4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x15ABF18", Offset = "0x15ABF18", VA = "0x15ABF18")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x15ABE50", Offset = "0x15ABE50", VA = "0x15ABE50")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x15AC254", Offset = "0x15AC254", VA = "0x15AC254")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x15AC5EC", Offset = "0x15AC5EC", VA = "0x15AC5EC")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x15AC5B8", Offset = "0x15AC5B8", VA = "0x15AC5B8")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x15ACADC", Offset = "0x15ACADC", VA = "0x15ACADC")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x15AC708", Offset = "0x15AC708", VA = "0x15AC708")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x15ACEEC", Offset = "0x15ACEEC", VA = "0x15ACEEC")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x15ACF38", Offset = "0x15ACF38", VA = "0x15ACF38")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x15AD240", Offset = "0x15AD240", VA = "0x15AD240")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x15AD3C8", Offset = "0x15AD3C8", VA = "0x15AD3C8")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x15AD548", Offset = "0x15AD548", VA = "0x15AD548")]
		public void PlayVideo()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x15AD594", Offset = "0x15AD594", VA = "0x15AD594")]
		public void StopVideo()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x15AD5E0", Offset = "0x15AD5E0", VA = "0x15AD5E0")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x15AD7DC", Offset = "0x15AD7DC", VA = "0x15AD7DC")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x15ADBE0", Offset = "0x15ADBE0", VA = "0x15ADBE0")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x15ACAFC", Offset = "0x15ACAFC", VA = "0x15ACAFC")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x15AE198", Offset = "0x15AE198", VA = "0x15AE198")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x15ADE7C", Offset = "0x15ADE7C", VA = "0x15ADE7C")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x15ABF1C", Offset = "0x15ABF1C", VA = "0x15ABF1C")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x15AE3DC", Offset = "0x15AE3DC", VA = "0x15AE3DC")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x15AE420", Offset = "0x15AE420", VA = "0x15AE420")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75DEBC", Offset = "0x75DEBC")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x15AE48C", Offset = "0x15AE48C", VA = "0x15AE48C")]
		public void FadeToVolume(float newVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x15AE8C4", Offset = "0x15AE8C4", VA = "0x15AE8C4")]
		public void FadeOutNowAndStop([Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x15AEBAC", Offset = "0x15AEBAC", VA = "0x15AEBAC")]
		public void FadeOutNowAndStop(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x15AECF4", Offset = "0x15AECF4", VA = "0x15AECF4")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x15AEDB0", Offset = "0x15AEDB0", VA = "0x15AEDB0")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x15AF1FC", Offset = "0x15AF1FC", VA = "0x15AF1FC")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x15AF764", Offset = "0x15AF764", VA = "0x15AF764")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x15ACAD4", Offset = "0x15ACAD4", VA = "0x15ACAD4")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x15AF7BC", Offset = "0x15AF7BC", VA = "0x15AF7BC")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CEE0", Offset = "0x75CEE0")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200005D")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x400036F")]
			None,
			[Token(Token = "0x4000370")]
			Play,
			[Token(Token = "0x4000371")]
			WaitForEnd,
			[Token(Token = "0x4000372")]
			StopOrRepeat
		}

		[Token(Token = "0x4000338")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000339")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Action _fadeOutEarlyCompletionCallback;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Action _fadeToTargetCompletionCallback;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _fadeOutStarted;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _lastFrameClipTime;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _glideToTargetPitch;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private int _framesPlayed;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float? _clipStartPosition;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float? _clipEndPosition;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x101")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _timesLooped;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isPaused;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private double _pauseTime;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x17000058")]
		public float ClipStartPosition
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x15B0D68", Offset = "0x15B0D68", VA = "0x15B0D68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000059")]
		public float ClipEndPosition
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x15AFA48", Offset = "0x15AFA48", VA = "0x15AFA48")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005A")]
		public int FramesPlayed
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x15B1A40", Offset = "0x15B1A40", VA = "0x15B1A40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x15B1A48", Offset = "0x15B1A48", VA = "0x15B1A48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x15B1AAC", Offset = "0x15B1AAC", VA = "0x15B1AAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005D")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x15B1B60", Offset = "0x15B1B60", VA = "0x15B1B60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005E")]
		private Transform Trans
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x15B00F0", Offset = "0x15B00F0", VA = "0x15B00F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x15AF9B4", Offset = "0x15AF9B4", VA = "0x15AF9B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x15B0184", Offset = "0x15B0184", VA = "0x15B0184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x15AF914", Offset = "0x15AF914", VA = "0x15AF914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x15B0CB4", Offset = "0x15B0CB4", VA = "0x15B0CB4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000063")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x15B0424", Offset = "0x15B0424", VA = "0x15B0424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000064")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x15B19D8", Offset = "0x15B19D8", VA = "0x15B19D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x15AD180", Offset = "0x15AD180", VA = "0x15AD180")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x15AE72C", Offset = "0x15AE72C", VA = "0x15AE72C")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x15AEA04", Offset = "0x15AEA04", VA = "0x15AEA04")]
		public void FadeOutEarly(float fadeTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x15AE0DC", Offset = "0x15AE0DC", VA = "0x15AE0DC")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x15ACC08", Offset = "0x15ACC08", VA = "0x15ACC08")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x15ACE24", Offset = "0x15ACE24", VA = "0x15ACE24")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x15AE118", Offset = "0x15AE118", VA = "0x15AE118")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x15AE398", Offset = "0x15AE398", VA = "0x15AE398")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x15AE368", Offset = "0x15AE368", VA = "0x15AE368")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x15ADBAC", Offset = "0x15ADBAC", VA = "0x15ADBAC")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x15AE358", Offset = "0x15AE358", VA = "0x15AE358")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x15B0074", Offset = "0x15B0074", VA = "0x15B0074")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x15AFB8C", Offset = "0x15AFB8C", VA = "0x15AFB8C")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x15B0218", Offset = "0x15B0218", VA = "0x15B0218")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x15B02C0", Offset = "0x15B02C0", VA = "0x15B02C0")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x15B04B0", Offset = "0x15B04B0", VA = "0x15B04B0")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x15B0528", Offset = "0x15B0528", VA = "0x15B0528")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x15AFD1C", Offset = "0x15AFD1C", VA = "0x15AFD1C")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x15B0EB8", Offset = "0x15B0EB8", VA = "0x15B0EB8")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x15B1028", Offset = "0x15B1028", VA = "0x15B1028")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x15AD4D0", Offset = "0x15AD4D0", VA = "0x15AD4D0")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x15AD6E0", Offset = "0x15AD6E0", VA = "0x15AD6E0")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x15AD88C", Offset = "0x15AD88C", VA = "0x15AD88C")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x15B10C4", Offset = "0x15B10C4", VA = "0x15B10C4")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x15B1188", Offset = "0x15B1188", VA = "0x15B1188")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x15B146C", Offset = "0x15B146C", VA = "0x15B146C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x15B14F4", Offset = "0x15B14F4", VA = "0x15B14F4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x15ABB1C", Offset = "0x15ABB1C", VA = "0x15ABB1C")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x15B15DC", Offset = "0x15B15DC", VA = "0x15B15DC")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x15B1C14", Offset = "0x15B1C14", VA = "0x15B1C14")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x8AAB0C", Offset = "0x8AAB0C", VA = "0x8AAB0C")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x8AAD80", Offset = "0x8AAD80", VA = "0x8AAD80")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x8AAF74", Offset = "0x8AAF74", VA = "0x8AAF74")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200005F")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000374")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000375")]
		private const int HighestPriority = 16;

		[Token(Token = "0x4000376")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x8AB188", Offset = "0x8AB188", VA = "0x8AB188")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x8AB1A4", Offset = "0x8AB1A4", VA = "0x8AB1A4")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x8AB1C0", Offset = "0x8AB1C0", VA = "0x8AB1C0")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x8AB1DC", Offset = "0x8AB1DC", VA = "0x8AB1DC")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x2000060")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CEF4", Offset = "0x75CEF4")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x1B2D778", Offset = "0x1B2D778", VA = "0x1B2D778", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C3")]
				[Address(RVA = "0x1B2D7C0", Offset = "0x1B2D7C0", VA = "0x1B2D7C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x1B2D1F8", Offset = "0x1B2D1F8", VA = "0x1B2D1F8")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x1B2D224", Offset = "0x1B2D224", VA = "0x1B2D224", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x1B2D228", Offset = "0x1B2D228", VA = "0x1B2D228", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1B2D780", Offset = "0x1B2D780", VA = "0x1B2D780", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000062")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF04", Offset = "0x75CF04")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001C7")]
				[Address(RVA = "0x1B2DE28", Offset = "0x1B2DE28", VA = "0x1B2DE28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001C9")]
				[Address(RVA = "0x1B2DE70", Offset = "0x1B2DE70", VA = "0x1B2DE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1B2D7C8", Offset = "0x1B2D7C8", VA = "0x1B2D7C8")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1B2D7F4", Offset = "0x1B2D7F4", VA = "0x1B2D7F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x1B2D7F8", Offset = "0x1B2D7F8", VA = "0x1B2D7F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x1B2DE30", Offset = "0x1B2DE30", VA = "0x1B2DE30", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x8AB5B0", Offset = "0x8AB5B0", VA = "0x8AB5B0")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x8AB660", Offset = "0x8AB660", VA = "0x8AB660")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x8AB7DC", Offset = "0x8AB7DC", VA = "0x8AB7DC")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x8ABB64", Offset = "0x8ABB64", VA = "0x8ABB64")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x8AB880", Offset = "0x8AB880", VA = "0x8AB880")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x8ABFD8", Offset = "0x8ABFD8", VA = "0x8ABFD8")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x8AC05C", Offset = "0x8AC05C", VA = "0x8AC05C")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x8AC200", Offset = "0x8AC200", VA = "0x8AC200")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75DF8C", Offset = "0x75DF8C")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x8AC294", Offset = "0x8AC294", VA = "0x8AC294")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75DFEC", Offset = "0x75DFEC")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x8AC320", Offset = "0x8AC320", VA = "0x8AC320")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x8AC4C4", Offset = "0x8AC4C4", VA = "0x8AC4C4")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x8AC770", Offset = "0x8AC770", VA = "0x8AC770")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75CF14", Offset = "0x75CF14")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum JukeBoxDisplayMode
		{
			[Token(Token = "0x400045A")]
			DisplayAll,
			[Token(Token = "0x400045B")]
			DisplayActive
		}

		[Token(Token = "0x2000065")]
		public enum BusVoiceLimitExceededMode
		{
			[Token(Token = "0x400045D")]
			DoNotPlayNewSound,
			[Token(Token = "0x400045E")]
			StopOldestSound,
			[Token(Token = "0x400045F")]
			StopFarthestSound,
			[Token(Token = "0x4000460")]
			StopLeastImportantSound
		}

		[Token(Token = "0x2000066")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x4000462")]
			StopSound,
			[Token(Token = "0x4000463")]
			FadeSound
		}

		[Token(Token = "0x2000067")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x4000465")]
			StopExistingSound,
			[Token(Token = "0x4000466")]
			FadeInSameSound
		}

		[Token(Token = "0x2000068")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000468")]
			LateUpdate,
			[Token(Token = "0x4000469")]
			FixedUpdate
		}

		[Token(Token = "0x2000069")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x400046B")]
			All,
			[Token(Token = "0x400046C")]
			OneAtRandom
		}

		[Token(Token = "0x200006A")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400046E")]
			AllGroups,
			[Token(Token = "0x400046F")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x200006B")]
		public enum RaycastMode
		{
			[Token(Token = "0x4000471")]
			Physics3D,
			[Token(Token = "0x4000472")]
			Physics2D
		}

		[Token(Token = "0x200006C")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000474")]
			ForceAllTo2D,
			[Token(Token = "0x4000475")]
			ForceAllTo3D,
			[Token(Token = "0x4000476")]
			ForceAllToCustom,
			[Token(Token = "0x4000477")]
			AllowDifferentPerController
		}

		[Token(Token = "0x200006D")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000479")]
			ForceAllTo2D,
			[Token(Token = "0x400047A")]
			ForceAllTo3D,
			[Token(Token = "0x400047B")]
			ForceAllToCustom,
			[Token(Token = "0x400047C")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x200006E")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400047E")]
			ForceTo2D,
			[Token(Token = "0x400047F")]
			ForceTo3D,
			[Token(Token = "0x4000480")]
			ForceToCustom,
			[Token(Token = "0x4000481")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x200006F")]
		public enum GroupPlayType
		{
			[Token(Token = "0x4000483")]
			Always,
			[Token(Token = "0x4000484")]
			WhenActorInAudibleRange,
			[Token(Token = "0x4000485")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x2000070")]
		public enum DefaultGroupPlayType
		{
			[Token(Token = "0x4000487")]
			Always,
			[Token(Token = "0x4000488")]
			WhenActorInAudibleRange
		}

		[Token(Token = "0x2000071")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x400048A")]
			Narrow,
			[Token(Token = "0x400048B")]
			Normal,
			[Token(Token = "0x400048C")]
			Wide
		}

		[Token(Token = "0x2000072")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x400048E")]
			Always,
			[Token(Token = "0x400048F")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000490")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000491")]
			Never,
			[Token(Token = "0x4000492")]
			OnSameGameObject,
			[Token(Token = "0x4000493")]
			OnChildGameObject,
			[Token(Token = "0x4000494")]
			OnParentGameObject,
			[Token(Token = "0x4000495")]
			OnSameOrChildGameObject,
			[Token(Token = "0x4000496")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x2000073")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x4000498")]
			All,
			[Token(Token = "0x4000499")]
			Closest,
			[Token(Token = "0x400049A")]
			Random
		}

		[Token(Token = "0x2000074")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x400049C")]
			None,
			[Token(Token = "0x400049D")]
			Loading,
			[Token(Token = "0x400049E")]
			Loaded,
			[Token(Token = "0x400049F")]
			LoadFailed
		}

		[Token(Token = "0x2000075")]
		public enum AudioLocation
		{
			[Token(Token = "0x40004A1")]
			Clip,
			[Token(Token = "0x40004A2")]
			ResourceFile
		}

		[Token(Token = "0x2000076")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x40004A4")]
			Beginning,
			[Token(Token = "0x40004A5")]
			SpecificTime,
			[Token(Token = "0x40004A6")]
			RandomTime
		}

		[Token(Token = "0x2000077")]
		public enum BusCommand
		{
			[Token(Token = "0x40004A8")]
			None,
			[Token(Token = "0x40004A9")]
			FadeToVolume,
			[Token(Token = "0x40004AA")]
			Mute,
			[Token(Token = "0x40004AB")]
			Pause,
			[Token(Token = "0x40004AC")]
			Solo,
			[Token(Token = "0x40004AD")]
			Unmute,
			[Token(Token = "0x40004AE")]
			Unpause,
			[Token(Token = "0x40004AF")]
			Unsolo,
			[Token(Token = "0x40004B0")]
			Stop,
			[Token(Token = "0x40004B1")]
			ChangePitch,
			[Token(Token = "0x40004B2")]
			ToggleMute,
			[Token(Token = "0x40004B3")]
			StopBusOfTransform,
			[Token(Token = "0x40004B4")]
			PauseBusOfTransform,
			[Token(Token = "0x40004B5")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40004B6")]
			GlideByPitch,
			[Token(Token = "0x40004B7")]
			StopOldBusVoices,
			[Token(Token = "0x40004B8")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x2000078")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40004BA")]
			OneGroupPerClip,
			[Token(Token = "0x40004BB")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000079")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40004BD")]
			PlaySound,
			[Token(Token = "0x40004BE")]
			GroupControl,
			[Token(Token = "0x40004BF")]
			BusControl,
			[Token(Token = "0x40004C0")]
			PlaylistControl,
			[Token(Token = "0x40004C1")]
			CustomEventControl,
			[Token(Token = "0x40004C2")]
			GlobalControl,
			[Token(Token = "0x40004C3")]
			UnityMixerControl,
			[Token(Token = "0x40004C4")]
			PersistentSettingsControl
		}

		[Token(Token = "0x200007A")]
		public enum LanguageMode
		{
			[Token(Token = "0x40004C6")]
			UseDeviceSetting,
			[Token(Token = "0x40004C7")]
			SpecificLanguage,
			[Token(Token = "0x40004C8")]
			DynamicallySet
		}

		[Token(Token = "0x200007B")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x40004CA")]
			None,
			[Token(Token = "0x40004CB")]
			TransitionToSnapshot,
			[Token(Token = "0x40004CC")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x200007C")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x40004CE")]
			None,
			[Token(Token = "0x40004CF")]
			ChangePlaylist,
			[Token(Token = "0x40004D0")]
			FadeToVolume,
			[Token(Token = "0x40004D1")]
			PlaySong,
			[Token(Token = "0x40004D2")]
			PlayRandomSong,
			[Token(Token = "0x40004D3")]
			PlayNextSong,
			[Token(Token = "0x40004D4")]
			Pause,
			[Token(Token = "0x40004D5")]
			Resume,
			[Token(Token = "0x40004D6")]
			Stop,
			[Token(Token = "0x40004D7")]
			Mute,
			[Token(Token = "0x40004D8")]
			Unmute,
			[Token(Token = "0x40004D9")]
			ToggleMute,
			[Token(Token = "0x40004DA")]
			Restart,
			[Token(Token = "0x40004DB")]
			Start,
			[Token(Token = "0x40004DC")]
			StopLoopingCurrentSong,
			[Token(Token = "0x40004DD")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x40004DE")]
			AddSongToQueue
		}

		[Token(Token = "0x200007D")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40004E0")]
			None,
			[Token(Token = "0x40004E1")]
			FireEvent
		}

		[Token(Token = "0x200007E")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40004E3")]
			None,
			[Token(Token = "0x40004E4")]
			PauseMixer,
			[Token(Token = "0x40004E5")]
			UnpauseMixer,
			[Token(Token = "0x40004E6")]
			StopMixer,
			[Token(Token = "0x40004E7")]
			StopEverything,
			[Token(Token = "0x40004E8")]
			PauseEverything,
			[Token(Token = "0x40004E9")]
			UnpauseEverything,
			[Token(Token = "0x40004EA")]
			MuteEverything,
			[Token(Token = "0x40004EB")]
			UnmuteEverything,
			[Token(Token = "0x40004EC")]
			SetMasterMixerVolume,
			[Token(Token = "0x40004ED")]
			SetMasterPlaylistVolume,
			[Token(Token = "0x40004EE")]
			PauseAudioListener,
			[Token(Token = "0x40004EF")]
			UnpauseAudioListener
		}

		[Token(Token = "0x200007F")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40004F1")]
			None,
			[Token(Token = "0x40004F2")]
			FadeToVolume,
			[Token(Token = "0x40004F3")]
			FadeOutAllOfSound,
			[Token(Token = "0x40004F4")]
			Mute,
			[Token(Token = "0x40004F5")]
			Pause,
			[Token(Token = "0x40004F6")]
			Solo,
			[Token(Token = "0x40004F7")]
			StopAllOfSound,
			[Token(Token = "0x40004F8")]
			Unmute,
			[Token(Token = "0x40004F9")]
			Unpause,
			[Token(Token = "0x40004FA")]
			Unsolo,
			[Token(Token = "0x40004FB")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40004FC")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40004FD")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40004FE")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40004FF")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x4000500")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x4000501")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000502")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000503")]
			RouteToBus,
			[Token(Token = "0x4000504")]
			GlideByPitch,
			[Token(Token = "0x4000505")]
			ToggleSoundGroup,
			[Token(Token = "0x4000506")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000507")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x4000508")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x4000509")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x2000080")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x400050B")]
			None,
			[Token(Token = "0x400050C")]
			SetBusVolume,
			[Token(Token = "0x400050D")]
			SetGroupVolume,
			[Token(Token = "0x400050E")]
			SetMixerVolume,
			[Token(Token = "0x400050F")]
			SetMusicVolume,
			[Token(Token = "0x4000510")]
			MixerMuteToggle,
			[Token(Token = "0x4000511")]
			MusicMuteToggle
		}

		[Token(Token = "0x2000081")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000513")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000514")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000515")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x2000082")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000517")]
			MasterAudioLocation,
			[Token(Token = "0x4000518")]
			CallerLocation,
			[Token(Token = "0x4000519")]
			AttachToCaller
		}

		[Token(Token = "0x2000083")]
		public enum VariationCommand
		{
			[Token(Token = "0x400051B")]
			None,
			[Token(Token = "0x400051C")]
			Stop,
			[Token(Token = "0x400051D")]
			Pause,
			[Token(Token = "0x400051E")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x2000084")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1B2F460", Offset = "0x1B2F460", VA = "0x1B2F460")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000085")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1B2F3BC", Offset = "0x1B2F3BC", VA = "0x1B2F3BC")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000086")]
		public class AudioInfo
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1B2F408", Offset = "0x1B2F408", VA = "0x1B2F408")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000087")]
		public class Playlist
		{
			[Token(Token = "0x2000088")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x4000540")]
				UseMasterSetting,
				[Token(Token = "0x4000541")]
				Override
			}

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private readonly List<int> _actorInstanceIds;

			[Token(Token = "0x1700008E")]
			public bool HasLiveActors
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x1B2F6CC", Offset = "0x1B2F6CC", VA = "0x1B2F6CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1B2F470", Offset = "0x1B2F470", VA = "0x1B2F470")]
			public Playlist()
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1B2F5C8", Offset = "0x1B2F5C8", VA = "0x1B2F5C8")]
			public void AddActorInstanceId(int instanceId)
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x1B2F668", Offset = "0x1B2F668", VA = "0x1B2F668")]
			public void RemoveActorInstanceId(int instanceId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000089")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x1B2F720", Offset = "0x1B2F720", VA = "0x1B2F720")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF28", Offset = "0x75CF28")]
		private sealed class <>c
		{
			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<GroupPitchGlideInfo> <>9__263_0;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<AudioInfo> <>9__280_0;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Comparison<CustomEventCandidate> <>9__485_0;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Comparison<CustomEventCandidate> <>9__485_1;

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x1B2E504", Offset = "0x1B2E504", VA = "0x1B2E504")]
			public <>c()
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x1B2E50C", Offset = "0x1B2E50C", VA = "0x1B2E50C")]
			internal bool <PerformGroupPitchGlides>b__263_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x1B2E52C", Offset = "0x1B2E52C", VA = "0x1B2E52C")]
			internal bool <CanPlayDialogBasedOnImportanceOrIsNotDialog>b__280_0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1B2E550", Offset = "0x1B2E550", VA = "0x1B2E550")]
			internal int <FireCustomEvent>b__485_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1B2E560", Offset = "0x1B2E560", VA = "0x1B2E560")]
			internal int <FireCustomEvent>b__485_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x200008B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF38", Offset = "0x75CF38")]
		private sealed class <>c__DisplayClass274_0
		{
			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1B2E574", Offset = "0x1B2E574", VA = "0x1B2E574")]
			public <>c__DisplayClass274_0()
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1B2E57C", Offset = "0x1B2E57C", VA = "0x1B2E57C")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF48", Offset = "0x75CF48")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__274 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass274_0 <>8__1;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x1700008F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000320")]
				[Address(RVA = "0x1B2F36C", Offset = "0x1B2F36C", VA = "0x1B2F36C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000090")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000322")]
				[Address(RVA = "0x1B2F3B4", Offset = "0x1B2F3B4", VA = "0x1B2F3B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1B2F068", Offset = "0x1B2F068", VA = "0x1B2F068")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__274(int <>1__state)
			{
			}

			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1B2F094", Offset = "0x1B2F094", VA = "0x1B2F094", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1B2F098", Offset = "0x1B2F098", VA = "0x1B2F098", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000321")]
			[Address(RVA = "0x1B2F374", Offset = "0x1B2F374", VA = "0x1B2F374", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF58", Offset = "0x75CF58")]
		private sealed class <>c__DisplayClass275_0
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x1B2E588", Offset = "0x1B2E588", VA = "0x1B2E588")]
			public <>c__DisplayClass275_0()
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1B2E590", Offset = "0x1B2E590", VA = "0x1B2E590")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF68", Offset = "0x75CF68")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__275 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass275_0 <>8__1;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x17000091")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0x1B2ECA8", Offset = "0x1B2ECA8", VA = "0x1B2ECA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000092")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x1B2ECF0", Offset = "0x1B2ECF0", VA = "0x1B2ECF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1B2E978", Offset = "0x1B2E978", VA = "0x1B2E978")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__275(int <>1__state)
			{
			}

			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1B2E9A4", Offset = "0x1B2E9A4", VA = "0x1B2E9A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1B2E9A8", Offset = "0x1B2E9A8", VA = "0x1B2E9A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x1B2ECB0", Offset = "0x1B2ECB0", VA = "0x1B2ECB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF78", Offset = "0x75CF78")]
		private sealed class <>c__DisplayClass276_0
		{
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x1B2E59C", Offset = "0x1B2E59C", VA = "0x1B2E59C")]
			public <>c__DisplayClass276_0()
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x1B2E5A4", Offset = "0x1B2E5A4", VA = "0x1B2E5A4")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF88", Offset = "0x75CF88")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__276 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass276_0 <>8__1;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x17000093")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0x1B2F018", Offset = "0x1B2F018", VA = "0x1B2F018", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000094")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0x1B2F060", Offset = "0x1B2F060", VA = "0x1B2F060", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x1B2ECF8", Offset = "0x1B2ECF8", VA = "0x1B2ECF8")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__276(int <>1__state)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x1B2ED24", Offset = "0x1B2ED24", VA = "0x1B2ED24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1B2ED28", Offset = "0x1B2ED28", VA = "0x1B2ED28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000331")]
			[Address(RVA = "0x1B2F020", Offset = "0x1B2F020", VA = "0x1B2F020", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CF98", Offset = "0x75CF98")]
		private sealed class <>c__DisplayClass290_0
		{
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MasterAudioGroup maGroup;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string variationName;

			[Token(Token = "0x6000333")]
			[Address(RVA = "0x1B2E5B0", Offset = "0x1B2E5B0", VA = "0x1B2E5B0")]
			public <>c__DisplayClass290_0()
			{
			}

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x1B2E5B8", Offset = "0x1B2E5B8", VA = "0x1B2E5B8")]
			internal bool <FindRetriggerableVariationInGroup>b__0(AudioInfo info)
			{
				return default(bool);
			}

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1B2E634", Offset = "0x1B2E634", VA = "0x1B2E634")]
			internal bool <FindRetriggerableVariationInGroup>b__1(AudioInfo info)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFA8", Offset = "0x75CFA8")]
		private sealed class <>c__DisplayClass328_0
		{
			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1B2E6D0", Offset = "0x1B2E6D0", VA = "0x1B2E6D0")]
			public <>c__DisplayClass328_0()
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1B2E6D8", Offset = "0x1B2E6D8", VA = "0x1B2E6D8")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1B2E6FC", Offset = "0x1B2E6FC", VA = "0x1B2E6FC")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFB8", Offset = "0x75CFB8")]
		private sealed class <>c__DisplayClass393_0
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x1B2E720", Offset = "0x1B2E720", VA = "0x1B2E720")]
			public <>c__DisplayClass393_0()
			{
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1B2E728", Offset = "0x1B2E728", VA = "0x1B2E728")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFC8", Offset = "0x75CFC8")]
		private sealed class <>c__DisplayClass481_0
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x1B2E74C", Offset = "0x1B2E74C", VA = "0x1B2E74C")]
			public <>c__DisplayClass481_0()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x1B2E754", Offset = "0x1B2E754", VA = "0x1B2E754")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFD8", Offset = "0x75CFD8")]
		private sealed class <>c__DisplayClass483_0
		{
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x600033D")]
			[Address(RVA = "0x1B2E7A4", Offset = "0x1B2E7A4", VA = "0x1B2E7A4")]
			public <>c__DisplayClass483_0()
			{
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x1B2E7AC", Offset = "0x1B2E7AC", VA = "0x1B2E7AC")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFE8", Offset = "0x75CFE8")]
		private sealed class <>c__DisplayClass487_0
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x600033F")]
			[Address(RVA = "0x1B2E7D0", Offset = "0x1B2E7D0", VA = "0x1B2E7D0")]
			public <>c__DisplayClass487_0()
			{
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x1B2E7D8", Offset = "0x1B2E7D8", VA = "0x1B2E7D8")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75CFF8", Offset = "0x75CFF8")]
		private sealed class <>c__DisplayClass488_0
		{
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x1B2E8A4", Offset = "0x1B2E8A4", VA = "0x1B2E8A4")]
			public <>c__DisplayClass488_0()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x1B2E8AC", Offset = "0x1B2E8AC", VA = "0x1B2E8AC")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400038A")]
		public const string VideoPlayersSoundGroupSelectedError = "Can't use specially named Sound Group for Video Players. Please select another.";

		[Token(Token = "0x400038B")]
		public const string VideoPlayerSoundGroupName = "_VideoPlayers";

		[Token(Token = "0x400038C")]
		public const string VideoPlayerBusName = "_VideoPlayers";

		[Token(Token = "0x400038D")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x400038E")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x400038F")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000390")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000391")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000392")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000393")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000394")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000395")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000396")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000397")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x4000398")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x4000399")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x400039A")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static List<string> ImportanceChoices;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x40003A0")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x40003A1")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x40003A2")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x40003A3")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x40003A4")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x40003A5")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x40003A6")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x40003A7")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x40003A8")]
		private const int MaxComponents = 20;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool showGroupImportance;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool showVideoPlayerSettings;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool useTextPlaylistFilter;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string textPlaylistFilter;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool playListExpanded;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
		public bool playlistsExpanded;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float musicSpatialBlend;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public GroupPlayType groupPlayType;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public DefaultGroupPlayType defaultGroupPlayType;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float _masterAudioVolume;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		public bool useSpatializer;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10F")]
		public bool addOculusAudioSources;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x112")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x113")]
		public bool useGaplessAutoReschedule;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x115")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public bool useOcclusion;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x152")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x153")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		public bool deletePreviewerAudioSourceWhenPlaying;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public bool showFadingSettings;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15D")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15E")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15F")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x165")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x166")]
		public bool logOutOfVoices;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x167")]
		public bool LogSounds;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public bool logCustomEvents;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
		public bool disableLogging;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16A")]
		public bool showMusicDucking;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16B")]
		public bool enableMusicDucking;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float defaultRiseVolStart;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		public float defaultUnduckTime;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		public float crossFadeTime;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		public bool showGroupSelect;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public JukeBoxDisplayMode jukeBoxDisplayMode;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
		public bool logPerfExpanded;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x195")]
		public bool willWarm;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x196")]
		public bool mixerSettingsExpanded;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioMixerUpdateMode mixerUpdateMode;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public string newEventName;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public bool showCustomEvents;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int frames;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Dictionary<string, List<int>> _nonRandomChoices;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<ICustomEventReceiver> ValidReceivers;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<CustomEventCandidate> ValidReceiverCandidates;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private readonly List<string> AllSoundGroupNames;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private readonly List<string> AllBusNames;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private readonly List<AudioInfo> GroupsToDelete;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private readonly List<PlaylistController> ControllersToPause;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private readonly List<PlaylistController> ControllersToUnpause;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private readonly List<PlaylistController> ControllersToMute;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private readonly List<PlaylistController> ControllersToUnmute;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private readonly List<PlaylistController> ControllersToToggleMute;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private readonly List<PlaylistController> ControllersToStop;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private readonly List<PlaylistController> ControllersToFade;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private readonly List<PlaylistController> ControllersToTrigNext;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private readonly List<PlaylistController> ControllersToTrigRandom;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private readonly List<PlaylistController> ControllersToStart;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToTriggerNow;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33C")]
		private float _repriTime;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private Transform _trans;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private bool _soundsLoaded;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x359")]
		private bool _warming;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static MasterAudio _instance;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static Transform _listenerTrans;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DC8C", Offset = "0x75DC8C")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x17000069")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x8DCD58", Offset = "0x8DCD58", VA = "0x8DCD58")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x8C4148", Offset = "0x8C4148", VA = "0x8C4148")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x8DD980", Offset = "0x8DD980", VA = "0x8DD980")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x8DD9E8", Offset = "0x8DD9E8", VA = "0x8DD9E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x8D1678", Offset = "0x8D1678", VA = "0x8D1678")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x8DDA58", Offset = "0x8DDA58", VA = "0x8DDA58")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public static Transform VideoPlayerSoundGroupTransform
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x8DEB50", Offset = "0x8DEB50", VA = "0x8DEB50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x8DEBDC", Offset = "0x8DEBDC", VA = "0x8DEBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x8A9748", Offset = "0x8A9748", VA = "0x8A9748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x8DED3C", Offset = "0x8DED3C", VA = "0x8DED3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public static bool IsWarming
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0x8B8FB4", Offset = "0x8B8FB4", VA = "0x8B8FB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public static bool MixerMuted
		{
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0x8DEDF4", Offset = "0x8DEDF4", VA = "0x8DEDF4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x8DA7C8", Offset = "0x8DA7C8", VA = "0x8DA7C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x8DEE5C", Offset = "0x8DEE5C", VA = "0x8DEE5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x8DB8DC", Offset = "0x8DB8DC", VA = "0x8DB8DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x8DEEC4", Offset = "0x8DEEC4", VA = "0x8DEEC4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x8DEECC", Offset = "0x8DEECC", VA = "0x8DEECC")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x8DEED8", Offset = "0x8DEED8", VA = "0x8DEED8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000075")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0x8DB508", Offset = "0x8DB508", VA = "0x8DB508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x8D81F0", Offset = "0x8D81F0", VA = "0x8D81F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x8BE1D4", Offset = "0x8BE1D4", VA = "0x8BE1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x8C0D78", Offset = "0x8C0D78", VA = "0x8C0D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x8A6968", Offset = "0x8A6968", VA = "0x8A6968")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x8A799C", Offset = "0x8A799C", VA = "0x8A799C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x8DEEE0", Offset = "0x8DEEE0", VA = "0x8DEEE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public static bool SoundsReady
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x8B2298", Offset = "0x8B2298", VA = "0x8B2298")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x8DEF44", Offset = "0x8DEF44", VA = "0x8DEF44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E220", Offset = "0x75E220")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x8DEFA8", Offset = "0x8DEFA8", VA = "0x8DEFA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E230", Offset = "0x75E230")]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x8DF014", Offset = "0x8DF014", VA = "0x8DF014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x8A9074", Offset = "0x8A9074", VA = "0x8A9074")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public List<string> BusNames
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0x8DF3D0", Offset = "0x8DF3D0", VA = "0x8DF3D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x8DF520", Offset = "0x8DF520", VA = "0x8DF520")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x8DF670", Offset = "0x8DF670", VA = "0x8DF670")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		public Transform Trans
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x8A9EA4", Offset = "0x8A9EA4", VA = "0x8A9EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x8DF788", Offset = "0x8DF788", VA = "0x8DF788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000084")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x8DF790", Offset = "0x8DF790", VA = "0x8DF790")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x8DF960", Offset = "0x8DF960", VA = "0x8DF960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x8DF890", Offset = "0x8DF890", VA = "0x8DF890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x8DFAA8", Offset = "0x8DFAA8", VA = "0x8DFAA8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x8C3FDC", Offset = "0x8C3FDC", VA = "0x8C3FDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x8CFA64", Offset = "0x8CFA64", VA = "0x8CFA64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x8DFB10", Offset = "0x8DFB10", VA = "0x8DFB10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008A")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0x8ABE28", Offset = "0x8ABE28", VA = "0x8ABE28")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0x8DFB78", Offset = "0x8DFB78", VA = "0x8DFB78")]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x8DFC50", Offset = "0x8DFC50", VA = "0x8DFC50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008C")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x8DFD94", Offset = "0x8DFD94", VA = "0x8DFD94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008D")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0x8DFE70", Offset = "0x8DFE70", VA = "0x8DFE70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000306")]
			[Address(RVA = "0x8DFED4", Offset = "0x8DFED4", VA = "0x8DFED4")]
			set
			{
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x8CB0E8", Offset = "0x8CB0E8", VA = "0x8CB0E8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x75E0EC", Offset = "0x75E0EC")]
		private static void Init()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x8CB184", Offset = "0x8CB184", VA = "0x8CB184")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x8CD450", Offset = "0x8CD450", VA = "0x8CD450")]
		private void Start()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x8CD5F8", Offset = "0x8CD5F8", VA = "0x8CD5F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x8CD8E4", Offset = "0x8CD8E4", VA = "0x8CD8E4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x8CEC68", Offset = "0x8CEC68", VA = "0x8CEC68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x8CED0C", Offset = "0x8CED0C", VA = "0x8CED0C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x8CEC78", Offset = "0x8CEC78", VA = "0x8CEC78")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x8CD28C", Offset = "0x8CD28C", VA = "0x8CD28C")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x8CF244", Offset = "0x8CF244", VA = "0x8CF244")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x8CF328", Offset = "0x8CF328", VA = "0x8CF328")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x8CF084", Offset = "0x8CF084", VA = "0x8CF084")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x8CF3B4", Offset = "0x8CF3B4", VA = "0x8CF3B4")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x8CED20", Offset = "0x8CED20", VA = "0x8CED20")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x8CEB88", Offset = "0x8CEB88", VA = "0x8CEB88")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x8CE864", Offset = "0x8CE864", VA = "0x8CE864")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x8CD978", Offset = "0x8CD978", VA = "0x8CD978")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x8CDBD0", Offset = "0x8CDBD0", VA = "0x8CDBD0")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x8CDF68", Offset = "0x8CDF68", VA = "0x8CDF68")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x8CE444", Offset = "0x8CE444", VA = "0x8CE444")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x8CE244", Offset = "0x8CE244", VA = "0x8CE244")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x8CDE4C", Offset = "0x8CDE4C", VA = "0x8CDE4C")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x8CF9C4", Offset = "0x8CF9C4", VA = "0x8CF9C4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x8B00F0", Offset = "0x8B00F0", VA = "0x8B00F0")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x8BB88C", Offset = "0x8BB88C", VA = "0x8BB88C")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x8D07BC", Offset = "0x8D07BC", VA = "0x8D07BC")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x8D0980", Offset = "0x8D0980", VA = "0x8D0980")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x8AD1B8", Offset = "0x8AD1B8", VA = "0x8AD1B8")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x8AD44C", Offset = "0x8AD44C", VA = "0x8AD44C")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x8AD70C", Offset = "0x8AD70C", VA = "0x8AD70C")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x8AD9A0", Offset = "0x8AD9A0", VA = "0x8AD9A0")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x8D0B6C", Offset = "0x8D0B6C", VA = "0x8D0B6C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75E100", Offset = "0x75E100")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x8ADC78", Offset = "0x8ADC78", VA = "0x8ADC78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75E160", Offset = "0x75E160")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x8ADDFC", Offset = "0x8ADDFC", VA = "0x8ADDFC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75E1C0", Offset = "0x75E1C0")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x8D0798", Offset = "0x8D0798", VA = "0x8D0798")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x8CFB00", Offset = "0x8CFB00", VA = "0x8CFB00")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x8D3140", Offset = "0x8D3140", VA = "0x8D3140")]
		private static PlaySoundResult TryPlayVariationOrOtherMatches(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch, Transform sourceTrans, bool attachToSource, float delaySoundTime, bool useVector3, bool makePlaySoundResult, bool isChaining, bool isSingleSubscribedPlay, AudioInfo randomSource, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, bool forgetSoundPlayedOrScheduled, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop, List<int> otherChoices, bool hasRefilledPool, List<AudioInfo> sources, out bool soundSuccess)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x8D2D40", Offset = "0x8D2D40", VA = "0x8D2D40")]
		private static bool CanPlayDialogBasedOnImportanceOrIsNotDialog(string sType, AudioGroupInfo group, bool loggingEnabledForGrp, AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x8D1CDC", Offset = "0x8D1CDC", VA = "0x8D1CDC")]
		private static AudioInfo UseOnlyVariationIfOnlyOne(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp, AudioInfo randomSource, MasterAudioGroup maGroup, ref bool isSingleVarLoop)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x8D2A70", Offset = "0x8D2A70", VA = "0x8D2A70")]
		private static bool IsActorTooFarAwayToPlay(string sType, Transform sourceTrans, AudioGroupInfo group, AudioInfo randomSource, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x8D28F0", Offset = "0x8D28F0", VA = "0x8D28F0")]
		private static bool VariationPassesProbabilityToPlayCheck(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x8D26F8", Offset = "0x8D26F8", VA = "0x8D26F8")]
		private static bool IsNoClipSilentPlay(string sType, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource, bool isChaining, AudioInfo randomSource, bool loggingEnabledForGrp, AudioGroupInfo group, bool isNonSpecific, int? randomIndex, List<int> choices, int pickedChoice)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x8D2564", Offset = "0x8D2564", VA = "0x8D2564")]
		private static bool VariationIsUsable(AudioInfo randomSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x8D1E04", Offset = "0x8D1E04", VA = "0x8D1E04")]
		private static bool CanFindVariationToPlay(string sType, string variationName, bool isNonSpecific, bool canUseBusVoiceToStop, List<AudioInfo> sources, bool loggingEnabledForGrp, SoundGroupVariation busVoiceToStop, ref AudioInfo randomSource, ref List<int> choices, ref int? randomIndex, ref int pickedChoice, ref List<int> otherChoices)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x8D1938", Offset = "0x8D1938", VA = "0x8D1938")]
		private static SoundGroupVariation FindBusVoiceToStop(GroupBus groupBus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x8D1820", Offset = "0x8D1820", VA = "0x8D1820")]
		private static bool CanStopLimitedBusVoice(GroupBus groupBus, bool loggingEnabledForGrp, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x8D17F8", Offset = "0x8D17F8", VA = "0x8D17F8")]
		private static bool IsBusVoiceLimited(GroupBus groupBus)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x8D1490", Offset = "0x8D1490", VA = "0x8D1490")]
		private static AudioInfo FindRetriggerableVariationInGroup(string variationName, bool isNonSpecific, List<AudioInfo> sources, MasterAudioGroup maGroup)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x8D142C", Offset = "0x8D142C", VA = "0x8D142C")]
		private static bool IsGroupPolyphonyLimited(MasterAudioGroup maGroup, AudioGroupInfo group)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x8D12B0", Offset = "0x8D12B0", VA = "0x8D12B0")]
		private static bool IsReplayLimited(string sType, MasterAudioGroup maGroup, AudioGroupInfo group, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x8D1098", Offset = "0x8D1098", VA = "0x8D1098")]
		private static void LogIfSilentPlay(string sType, bool loggingEnabledForGrp, MasterAudioGroup maGroup)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x8D0FB4", Offset = "0x8D0FB4", VA = "0x8D0FB4")]
		private static bool SoundGroupHasVariations(string sType, List<AudioInfo> sources, bool loggingEnabledForGrp)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x8D0C18", Offset = "0x8D0C18", VA = "0x8D0C18")]
		private static bool IsSoundGroupValidAndReady(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x8D4098", Offset = "0x8D4098", VA = "0x8D4098")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x8D36FC", Offset = "0x8D36FC", VA = "0x8D36FC")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x8D3E40", Offset = "0x8D3E40", VA = "0x8D3E40")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x8D3738", Offset = "0x8D3738", VA = "0x8D3738")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, SoundGroupVariation busVoiceToStop, GroupBus groupBus, bool canUseBusVoiceToStop, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x8D4A60", Offset = "0x8D4A60", VA = "0x8D4A60")]
		private static void FadeOldestOrFarthestBusVoice(SoundGroupVariation busVoiceToStop, GroupBus groupBus)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x8D4B4C", Offset = "0x8D4B4C", VA = "0x8D4B4C")]
		public static void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x8D4BFC", Offset = "0x8D4BFC", VA = "0x8D4BFC")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource, SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x8D4DF4", Offset = "0x8D4DF4", VA = "0x8D4DF4")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x8AE680", Offset = "0x8AE680", VA = "0x8AE680")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x8A7264", Offset = "0x8A7264", VA = "0x8A7264")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x8ADF20", Offset = "0x8ADF20", VA = "0x8ADF20")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x8AE430", Offset = "0x8AE430", VA = "0x8AE430")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x8AECC4", Offset = "0x8AECC4", VA = "0x8AECC4")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x8AF1D4", Offset = "0x8AF1D4", VA = "0x8AF1D4")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x8BFB20", Offset = "0x8BFB20", VA = "0x8BFB20")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x8A7454", Offset = "0x8A7454", VA = "0x8A7454")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x8BF388", Offset = "0x8BF388", VA = "0x8BF388")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x8BE378", Offset = "0x8BE378", VA = "0x8BE378")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x8D50B0", Offset = "0x8D50B0", VA = "0x8D50B0")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x8ACDCC", Offset = "0x8ACDCC", VA = "0x8ACDCC")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x8D5384", Offset = "0x8D5384", VA = "0x8D5384")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x8D5740", Offset = "0x8D5740", VA = "0x8D5740")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x8D5998", Offset = "0x8D5998", VA = "0x8D5998")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x8D6864", Offset = "0x8D6864", VA = "0x8D6864")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x8D6F2C", Offset = "0x8D6F2C", VA = "0x8D6F2C")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x8D72E4", Offset = "0x8D72E4", VA = "0x8D72E4")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x8D7628", Offset = "0x8D7628", VA = "0x8D7628")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x8D781C", Offset = "0x8D781C", VA = "0x8D781C")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x8D7AE4", Offset = "0x8D7AE4", VA = "0x8D7AE4")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x8D7E98", Offset = "0x8D7E98", VA = "0x8D7E98")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x8BE23C", Offset = "0x8BE23C", VA = "0x8BE23C")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x8AF434", Offset = "0x8AF434", VA = "0x8AF434")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x8BFD3C", Offset = "0x8BFD3C", VA = "0x8BFD3C")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x8D84D8", Offset = "0x8D84D8", VA = "0x8D84D8")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x8BE600", Offset = "0x8BE600", VA = "0x8BE600")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x8D8BE0", Offset = "0x8D8BE0", VA = "0x8D8BE0")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x8BF040", Offset = "0x8BF040", VA = "0x8BF040")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x8D8C88", Offset = "0x8D8C88", VA = "0x8D8C88")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x8D8E00", Offset = "0x8D8E00", VA = "0x8D8E00")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x8BF838", Offset = "0x8BF838", VA = "0x8BF838")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x8BEAA0", Offset = "0x8BEAA0", VA = "0x8BEAA0")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x8C0B98", Offset = "0x8C0B98", VA = "0x8C0B98")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x8C09D8", Offset = "0x8C09D8", VA = "0x8C09D8")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x8C03D4", Offset = "0x8C03D4", VA = "0x8C03D4")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x8B35F0", Offset = "0x8B35F0", VA = "0x8B35F0")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x8B4690", Offset = "0x8B4690", VA = "0x8B4690")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, int? creatorInstanceId, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x8D9244", Offset = "0x8D9244", VA = "0x8D9244")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x8CF554", Offset = "0x8CF554", VA = "0x8CF554")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x8BEEF4", Offset = "0x8BEEF4", VA = "0x8BEEF4")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x8BF728", Offset = "0x8BF728", VA = "0x8BF728")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x8CCF98", Offset = "0x8CCF98", VA = "0x8CCF98")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x8D95B0", Offset = "0x8D95B0", VA = "0x8D95B0")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x8D9428", Offset = "0x8D9428", VA = "0x8D9428")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x8CD69C", Offset = "0x8CD69C", VA = "0x8CD69C")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x8D8F98", Offset = "0x8D8F98", VA = "0x8D8F98")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x8D9654", Offset = "0x8D9654", VA = "0x8D9654")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x8D9304", Offset = "0x8D9304", VA = "0x8D9304")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x8BF1EC", Offset = "0x8BF1EC", VA = "0x8BF1EC")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x8B3F8C", Offset = "0x8B3F8C", VA = "0x8B3F8C")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x8D998C", Offset = "0x8D998C", VA = "0x8D998C")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x8D9AE0", Offset = "0x8D9AE0", VA = "0x8D9AE0")]
		private static void UnsilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x8D9830", Offset = "0x8D9830", VA = "0x8D9830")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x8D9B90", Offset = "0x8D9B90", VA = "0x8D9B90")]
		private static void SilenceGroup(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x8BF9E4", Offset = "0x8BF9E4", VA = "0x8BF9E4")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x8A6F2C", Offset = "0x8A6F2C", VA = "0x8A6F2C")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x8D9C40", Offset = "0x8D9C40", VA = "0x8D9C40")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x8D9D40", Offset = "0x8D9D40", VA = "0x8D9D40")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x8D9F60", Offset = "0x8D9F60", VA = "0x8D9F60")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x8DA0D8", Offset = "0x8DA0D8", VA = "0x8DA0D8")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x8DA1BC", Offset = "0x8DA1BC", VA = "0x8DA1BC")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x8DA340", Offset = "0x8DA340", VA = "0x8DA340")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x8DA438", Offset = "0x8DA438", VA = "0x8DA438")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x8C422C", Offset = "0x8C422C", VA = "0x8C422C")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x8C4404", Offset = "0x8C4404", VA = "0x8C4404")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x8C45DC", Offset = "0x8C45DC", VA = "0x8C45DC")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x8DA578", Offset = "0x8DA578", VA = "0x8DA578")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x8C498C", Offset = "0x8C498C", VA = "0x8C498C")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x8C48D4", Offset = "0x8C48D4", VA = "0x8C48D4")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x8C4930", Offset = "0x8C4930", VA = "0x8C4930")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x8C4814", Offset = "0x8C4814", VA = "0x8C4814")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x8C4874", Offset = "0x8C4874", VA = "0x8C4874")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x8DAB80", Offset = "0x8DAB80", VA = "0x8DAB80")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x8CF828", Offset = "0x8CF828", VA = "0x8CF828")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x8D8258", Offset = "0x8D8258", VA = "0x8D8258")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x8C2988", Offset = "0x8C2988", VA = "0x8C2988")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8C2074", Offset = "0x8C2074", VA = "0x8C2074")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x8C2298", Offset = "0x8C2298", VA = "0x8C2298")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x8C2488", Offset = "0x8C2488", VA = "0x8C2488")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x8C1B08", Offset = "0x8C1B08", VA = "0x8C1B08")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x8C2574", Offset = "0x8C2574", VA = "0x8C2574")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x8C2798", Offset = "0x8C2798", VA = "0x8C2798")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x8DAE70", Offset = "0x8DAE70", VA = "0x8DAE70")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x8D46A4", Offset = "0x8D46A4", VA = "0x8D46A4")]
		private static SoundGroupVariation FindLeastImportantSoundOnBus(GroupBus bus, MasterAudioGroup group)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x8D4360", Offset = "0x8D4360", VA = "0x8D4360")]
		private static SoundGroupVariation FindFarthestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x8D40CC", Offset = "0x8D40CC", VA = "0x8D40CC")]
		private static SoundGroupVariation FindOldestSoundOnBus(GroupBus bus)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x8C1CB8", Offset = "0x8C1CB8", VA = "0x8C1CB8")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x8C1EE4", Offset = "0x8C1EE4", VA = "0x8C1EE4")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x8B42C4", Offset = "0x8B42C4", VA = "0x8B42C4")]
		public static bool CreateBus(string busName, int? actorInstanceId, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x8B3438", Offset = "0x8B3438", VA = "0x8B3438")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x8DB014", Offset = "0x8DB014", VA = "0x8DB014")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x8D49A0", Offset = "0x8D49A0", VA = "0x8D49A0")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x8C0F20", Offset = "0x8C0F20", VA = "0x8C0F20")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x8C2D9C", Offset = "0x8C2D9C", VA = "0x8C2D9C")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x8C2B58", Offset = "0x8C2B58", VA = "0x8C2B58")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x8C139C", Offset = "0x8C139C", VA = "0x8C139C")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x8CD160", Offset = "0x8CD160", VA = "0x8CD160")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x8DB34C", Offset = "0x8DB34C", VA = "0x8DB34C")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x8D8300", Offset = "0x8D8300", VA = "0x8D8300")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x8B3248", Offset = "0x8B3248", VA = "0x8B3248")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x8AE1C8", Offset = "0x8AE1C8", VA = "0x8AE1C8")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x8AEF6C", Offset = "0x8AEF6C", VA = "0x8AEF6C")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x8AE988", Offset = "0x8AE988", VA = "0x8AE988")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x8B591C", Offset = "0x8B591C", VA = "0x8B591C")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x8B34D4", Offset = "0x8B34D4", VA = "0x8B34D4")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x8B3BF0", Offset = "0x8B3BF0", VA = "0x8B3BF0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x8DB570", Offset = "0x8DB570", VA = "0x8DB570")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x8DB6A0", Offset = "0x8DB6A0", VA = "0x8DB6A0")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x8BC9A0", Offset = "0x8BC9A0", VA = "0x8BC9A0")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x8BC934", Offset = "0x8BC934", VA = "0x8BC934")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x8DB7F4", Offset = "0x8DB7F4", VA = "0x8DB7F4")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x8DB9D0", Offset = "0x8DB9D0", VA = "0x8DB9D0")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x8BCC4C", Offset = "0x8BCC4C", VA = "0x8BCC4C")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x8BCBE0", Offset = "0x8BCBE0", VA = "0x8BCBE0")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x8DBA40", Offset = "0x8DBA40", VA = "0x8DBA40")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x8DBB28", Offset = "0x8DBB28", VA = "0x8DBB28")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x8BCEF8", Offset = "0x8BCEF8", VA = "0x8BCEF8")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x8BCE8C", Offset = "0x8BCE8C", VA = "0x8BCE8C")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x8DBB98", Offset = "0x8DBB98", VA = "0x8DBB98")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x8DBC30", Offset = "0x8DBC30", VA = "0x8DBC30")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x8BDA3C", Offset = "0x8BDA3C", VA = "0x8BDA3C")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x8BD9D0", Offset = "0x8BD9D0", VA = "0x8BD9D0")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x8DBCA0", Offset = "0x8DBCA0", VA = "0x8DBCA0")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x8DBD38", Offset = "0x8DBD38", VA = "0x8DBD38")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x8BDF94", Offset = "0x8BDF94", VA = "0x8BDF94")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x8BDF28", Offset = "0x8BDF28", VA = "0x8BDF28")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x8DBDA8", Offset = "0x8DBDA8", VA = "0x8DBDA8")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x8DBE40", Offset = "0x8DBE40", VA = "0x8DBE40")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x8BDCE8", Offset = "0x8BDCE8", VA = "0x8BDCE8")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x8BDC7C", Offset = "0x8BDC7C", VA = "0x8BDC7C")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x8DBEB0", Offset = "0x8DBEB0", VA = "0x8DBEB0")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x8DBF4C", Offset = "0x8DBF4C", VA = "0x8DBF4C")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x8BD790", Offset = "0x8BD790", VA = "0x8BD790")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x8BD724", Offset = "0x8BD724", VA = "0x8BD724")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x8DBFBC", Offset = "0x8DBFBC", VA = "0x8DBFBC")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x8DC054", Offset = "0x8DC054", VA = "0x8DC054")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x8BD4E4", Offset = "0x8BD4E4", VA = "0x8BD4E4")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x8BD478", Offset = "0x8BD478", VA = "0x8BD478")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x8DC0C4", Offset = "0x8DC0C4", VA = "0x8DC0C4")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x8DC15C", Offset = "0x8DC15C", VA = "0x8DC15C")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x8BBB04", Offset = "0x8BBB04", VA = "0x8BBB04")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x8BBA98", Offset = "0x8BBA98", VA = "0x8BBA98")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x8DC1CC", Offset = "0x8DC1CC", VA = "0x8DC1CC")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x8DC268", Offset = "0x8DC268", VA = "0x8DC268")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x8DC2E4", Offset = "0x8DC2E4", VA = "0x8DC2E4")]
		public static void StartPlaylistOnClip(string playlistName, string clipName)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x8BBD08", Offset = "0x8BBD08", VA = "0x8BBD08")]
		public static void StartPlaylist(string playlistControllerName, string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x8BC174", Offset = "0x8BC174", VA = "0x8BC174")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x8DC404", Offset = "0x8DC404", VA = "0x8DC404")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x8BC1E0", Offset = "0x8BC1E0", VA = "0x8BC1E0")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x8DC36C", Offset = "0x8DC36C", VA = "0x8DC36C")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x8BC3E4", Offset = "0x8BC3E4", VA = "0x8BC3E4")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x8DC50C", Offset = "0x8DC50C", VA = "0x8DC50C")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x8BC450", Offset = "0x8BC450", VA = "0x8BC450")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x8DC474", Offset = "0x8DC474", VA = "0x8DC474")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x8DC57C", Offset = "0x8DC57C", VA = "0x8DC57C")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x8BD2D8", Offset = "0x8BD2D8", VA = "0x8BD2D8")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x8DC5F4", Offset = "0x8DC5F4", VA = "0x8DC5F4")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x8BD138", Offset = "0x8BD138", VA = "0x8BD138")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x8DC66C", Offset = "0x8DC66C", VA = "0x8DC66C")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x8BBFCC", Offset = "0x8BBFCC", VA = "0x8BBFCC")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x8DC6F4", Offset = "0x8DC6F4", VA = "0x8DC6F4")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x8BC6D8", Offset = "0x8BC6D8", VA = "0x8BC6D8")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x8BC654", Offset = "0x8BC654", VA = "0x8BC654")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x8DC77C", Offset = "0x8DC77C", VA = "0x8DC77C")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x8B6114", Offset = "0x8B6114", VA = "0x8B6114")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x8B3DAC", Offset = "0x8B3DAC", VA = "0x8B3DAC")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x8DC8E0", Offset = "0x8DC8E0", VA = "0x8DC8E0")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f, [Optional] string alias)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x8DC9BC", Offset = "0x8DC9BC", VA = "0x8DC9BC")]
		public static void AddSongToPlaylist(string playlistName, MusicSetting newSong)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x8DCDC0", Offset = "0x8DCDC0", VA = "0x8DCDC0")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x8B62DC", Offset = "0x8B62DC", VA = "0x8B62DC")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x8C4FC8", Offset = "0x8C4FC8", VA = "0x8C4FC8")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x8C545C", Offset = "0x8C545C", VA = "0x8C545C")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x8DCF10", Offset = "0x8DCF10", VA = "0x8DCF10")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x8B5A80", Offset = "0x8B5A80", VA = "0x8B5A80")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, int? actorInstanceId, bool errorOnDuplicates, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x8B5D88", Offset = "0x8B5D88", VA = "0x8B5D88")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, int? actorInstanceId, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x8B3A00", Offset = "0x8B3A00", VA = "0x8B3A00")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x8DD228", Offset = "0x8DD228", VA = "0x8DD228")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x8C3000", Offset = "0x8C3000", VA = "0x8C3000")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x8C4CA0", Offset = "0x8C4CA0", VA = "0x8C4CA0")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x8DD338", Offset = "0x8DD338", VA = "0x8DD338")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x8DD4CC", Offset = "0x8DD4CC", VA = "0x8DD4CC")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x8DD660", Offset = "0x8DD660", VA = "0x8DD660")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x8D0E9C", Offset = "0x8D0E9C", VA = "0x8D0E9C")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x8D16E0", Offset = "0x8D16E0", VA = "0x8D16E0")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8A8984", Offset = "0x8A8984", VA = "0x8A8984")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8A8728", Offset = "0x8A8728", VA = "0x8A8728")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8AC6C0", Offset = "0x8AC6C0", VA = "0x8AC6C0")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8DDAC8", Offset = "0x8DDAC8", VA = "0x8DDAC8")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8DB710", Offset = "0x8DB710", VA = "0x8DB710")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8A652C", Offset = "0x8A652C", VA = "0x8A652C")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8A6B24", Offset = "0x8A6B24", VA = "0x8A6B24")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8DDC98", Offset = "0x8DDC98", VA = "0x8DDC98")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8DDEF4", Offset = "0x8DDEF4", VA = "0x8DDEF4")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8DE150", Offset = "0x8DE150", VA = "0x8DE150")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8DE358", Offset = "0x8DE358", VA = "0x8DE358")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8DE708", Offset = "0x8DE708", VA = "0x8DE708")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8C97D0", Offset = "0x8C97D0", VA = "0x8C97D0")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8C9854", Offset = "0x8C9854", VA = "0x8C9854")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8D7D50", Offset = "0x8D7D50", VA = "0x8D7D50")]
		public static bool IsOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8D66CC", Offset = "0x8D66CC", VA = "0x8D66CC")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8DE580", Offset = "0x8DE580", VA = "0x8DE580")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8DE890", Offset = "0x8DE890", VA = "0x8DE890")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8DEB00", Offset = "0x8DEB00", VA = "0x8DEB00")]
		public static bool IsVideoPlayersGroup(string groupName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x8D4FEC", Offset = "0x8D4FEC", VA = "0x8D4FEC")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x8DEC44", Offset = "0x8DEC44", VA = "0x8DEC44")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x8D91D8", Offset = "0x8D91D8", VA = "0x8D91D8")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x8DFD2C", Offset = "0x8DFD2C", VA = "0x8DFD2C")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x8DFF3C", Offset = "0x8DFF3C", VA = "0x8DFF3C")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8E00F8", Offset = "0x8E00F8", VA = "0x8E00F8")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8E02B4", Offset = "0x8E02B4", VA = "0x8E02B4")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8E0470", Offset = "0x8E0470", VA = "0x8E0470")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8E062C", Offset = "0x8E062C", VA = "0x8E062C")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000573")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000574")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000575")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000576")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000577")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000578")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000579")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x400057A")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400057B")]
		public const string Separator = ";";

		[Token(Token = "0x17000095")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x15A2040", Offset = "0x15A2040", VA = "0x15A2040")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x15A20BC", Offset = "0x15A20BC", VA = "0x15A20BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x15A21EC", Offset = "0x15A21EC", VA = "0x15A21EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x15A2268", Offset = "0x15A2268", VA = "0x15A2268")]
			set
			{
			}
		}

		[Token(Token = "0x17000097")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x15A2514", Offset = "0x15A2514", VA = "0x15A2514")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x15A25AC", Offset = "0x15A25AC", VA = "0x15A25AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public static float? MixerVolume
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x15A270C", Offset = "0x15A270C", VA = "0x15A270C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x15A279C", Offset = "0x15A279C", VA = "0x15A279C")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x15A28F0", Offset = "0x15A28F0", VA = "0x15A28F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x15A2988", Offset = "0x15A2988", VA = "0x15A2988")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public static float? MusicVolume
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x15A2AE8", Offset = "0x15A2AE8", VA = "0x15A2AE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x15A2B78", Offset = "0x15A2B78", VA = "0x15A2B78")]
			set
			{
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x15A1E58", Offset = "0x15A1E58", VA = "0x15A1E58")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x15A1FF0", Offset = "0x15A1FF0", VA = "0x15A1FF0")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x15A210C", Offset = "0x15A210C", VA = "0x15A210C")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x15A219C", Offset = "0x15A219C", VA = "0x15A219C")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x15A22B8", Offset = "0x15A22B8", VA = "0x15A22B8")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x15A2484", Offset = "0x15A2484", VA = "0x15A2484")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x15A2CCC", Offset = "0x15A2CCC", VA = "0x15A2CCC")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public abstract class SingletonScriptable<InstanceType> : ScriptableObject where InstanceType : ScriptableObject
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static string AssetNameToLoad;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static string ResourceNameToLoad;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static List<string> FoldersToCreate;

		[Token(Token = "0x6000356")]
		protected SingletonScriptable()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x200009B")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1B3060C", Offset = "0x1B3060C", VA = "0x1B3060C")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200009C")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1B3064C", Offset = "0x1B3064C", VA = "0x1B3064C")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200009D")]
		public enum MAItemType
		{
			[Token(Token = "0x400059A")]
			SoundGroups,
			[Token(Token = "0x400059B")]
			CustomEvents
		}

		[Token(Token = "0x200009E")]
		public enum TransferMode
		{
			[Token(Token = "0x400059D")]
			None,
			[Token(Token = "0x400059E")]
			Import,
			[Token(Token = "0x400059F")]
			Export
		}

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x15AAB00", Offset = "0x15AAB00", VA = "0x15AAB00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x15AAB74", Offset = "0x15AAB74", VA = "0x15AAB74")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public static class AmbientUtil
	{
		[Token(Token = "0x40005A0")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x40005A1")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x40005A2")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x40005A3")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x1700009B")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x8A9954", Offset = "0x8A9954", VA = "0x8A9954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x8A9298", Offset = "0x8A9298", VA = "0x8A9298")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x8AA1FC", Offset = "0x8AA1FC", VA = "0x8AA1FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009E")]
		public static int AmbientCount
		{
			[Token(Token = "0x6000365")]
			[Address(RVA = "0x8AA29C", Offset = "0x8AA29C", VA = "0x8AA29C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009F")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x8A8A34", Offset = "0x8A8A34", VA = "0x8A8A34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x8A91E4", Offset = "0x8A91E4", VA = "0x8A91E4")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x8A8854", Offset = "0x8A8854", VA = "0x8A8854")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x8A9E00", Offset = "0x8A9E00", VA = "0x8A9E00")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x8A8AD4", Offset = "0x8A8AD4", VA = "0x8A8AD4")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x8A9F44", Offset = "0x8A9F44", VA = "0x8A9F44")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x8AA054", Offset = "0x8AA054", VA = "0x8AA054")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x8AA3A0", Offset = "0x8AA3A0", VA = "0x8AA3A0")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x8AA4C4", Offset = "0x8AA4C4", VA = "0x8AA4C4")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A1")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x8ACCEC", Offset = "0x8ACCEC", VA = "0x8ACCEC")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x8ACD6C", Offset = "0x8ACD6C", VA = "0x8ACD6C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8AD110", Offset = "0x8AD110", VA = "0x8AD110")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x8AD390", Offset = "0x8AD390", VA = "0x8AD390")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8AD664", Offset = "0x8AD664", VA = "0x8AD664")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x8AD8E4", Offset = "0x8AD8E4", VA = "0x8AD8E4")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x8ADBB8", Offset = "0x8ADBB8", VA = "0x8ADBB8")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x8ADD3C", Offset = "0x8ADD3C", VA = "0x8ADD3C")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x8ADEC0", Offset = "0x8ADEC0", VA = "0x8ADEC0")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8AE158", Offset = "0x8AE158", VA = "0x8AE158")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x8AE3C0", Offset = "0x8AE3C0", VA = "0x8AE3C0")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x8AE620", Offset = "0x8AE620", VA = "0x8AE620")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x8AE918", Offset = "0x8AE918", VA = "0x8AE918")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x8AEBF4", Offset = "0x8AEBF4", VA = "0x8AEBF4")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x8AEC64", Offset = "0x8AEC64", VA = "0x8AEC64")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x8AEEFC", Offset = "0x8AEEFC", VA = "0x8AEEFC")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x8AF164", Offset = "0x8AF164", VA = "0x8AF164")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x8AF3C4", Offset = "0x8AF3C4", VA = "0x8AF3C4")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A2")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170000A0")]
		public Transform Trans
		{
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x8AF644", Offset = "0x8AF644", VA = "0x8AF644")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x8AF6D0", Offset = "0x8AF6D0", VA = "0x8AF6D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x8AF6E0", Offset = "0x8AF6E0", VA = "0x8AF6E0")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public static class AudioUtil
	{
		[Token(Token = "0x40005AA")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x40005AB")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x40005AC")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000A1")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x8AF760", Offset = "0x8AF760", VA = "0x8AF760")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A2")]
		public static float FrameTime
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x8AF768", Offset = "0x8AF768", VA = "0x8AF768")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A3")]
		public static float Time
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x8AF770", Offset = "0x8AF770", VA = "0x8AF770")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A4")]
		public static int FrameCount
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x8AF778", Offset = "0x8AF778", VA = "0x8AF778")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x8AF6E8", Offset = "0x8AF6E8", VA = "0x8AF6E8")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x8AF730", Offset = "0x8AF730", VA = "0x8AF730")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x8AF748", Offset = "0x8AF748", VA = "0x8AF748")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x8AF780", Offset = "0x8AF780", VA = "0x8AF780")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8AF7CC", Offset = "0x8AF7CC", VA = "0x8AF7CC")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x8AF818", Offset = "0x8AF818", VA = "0x8AF818")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x8AF858", Offset = "0x8AF858", VA = "0x8AF858")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x8AF874", Offset = "0x8AF874", VA = "0x8AF874")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x8AB4C8", Offset = "0x8AB4C8", VA = "0x8AB4C8")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x8AF884", Offset = "0x8AF884", VA = "0x8AF884")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x8AF8CC", Offset = "0x8AF8CC", VA = "0x8AF8CC")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x8AF9E8", Offset = "0x8AF9E8", VA = "0x8AF9E8")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x8AF958", Offset = "0x8AF958", VA = "0x8AF958")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x8AFAD4", Offset = "0x8AFAD4", VA = "0x8AFAD4")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x8AFB68", Offset = "0x8AFB68", VA = "0x8AFB68")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x8AFB94", Offset = "0x8AFB94", VA = "0x8AFB94")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x8AFBA4", Offset = "0x8AFBA4", VA = "0x8AFBA4")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x8AFBE0", Offset = "0x8AFBE0", VA = "0x8AFBE0")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x8AFBF4", Offset = "0x8AFBF4", VA = "0x8AFBF4")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000A4")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D028", Offset = "0x75D028")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x1B2DF6C", Offset = "0x1B2DF6C", VA = "0x1B2DF6C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600039C")]
				[Address(RVA = "0x1B2DFB4", Offset = "0x1B2DFB4", VA = "0x1B2DFB4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x1B2DE78", Offset = "0x1B2DE78", VA = "0x1B2DE78")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x1B2DEA4", Offset = "0x1B2DEA4", VA = "0x1B2DEA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x1B2DEA8", Offset = "0x1B2DEA8", VA = "0x1B2DEA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x1B2DF74", Offset = "0x1B2DF74", VA = "0x1B2DF74", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x8B0694", Offset = "0x8B0694", VA = "0x8B0694")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75E450", Offset = "0x75E450")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A6")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x8A9E8C", Offset = "0x8A9E8C", VA = "0x8A9E8C")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x8B0B24", Offset = "0x8B0B24", VA = "0x8B0B24")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x8B0B3C", Offset = "0x8B0B3C", VA = "0x8B0B3C")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x8A9580", Offset = "0x8A9580", VA = "0x8A9580")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D048", Offset = "0x75D048")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A9")]
				[Address(RVA = "0x1B2E124", Offset = "0x1B2E124", VA = "0x1B2E124", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003AB")]
				[Address(RVA = "0x1B2E16C", Offset = "0x1B2E16C", VA = "0x1B2E16C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x1B2DFBC", Offset = "0x1B2DFBC", VA = "0x1B2DFBC")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x1B2DFE8", Offset = "0x1B2DFE8", VA = "0x1B2DFE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1B2DFEC", Offset = "0x1B2DFEC", VA = "0x1B2DFEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1B2E12C", Offset = "0x1B2E12C", VA = "0x1B2E12C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x8B0B58", Offset = "0x8B0B58", VA = "0x8B0B58")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x8B0C00", Offset = "0x8B0C00", VA = "0x8B0C00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x8B0C94", Offset = "0x8B0C94", VA = "0x8B0C94")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x8B0CCC", Offset = "0x8B0CCC", VA = "0x8B0CCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x75E520", Offset = "0x75E520")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x8B0D38", Offset = "0x8B0D38", VA = "0x8B0D38")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75D058", Offset = "0x75D058")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000AA")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x40005DB")]
			FirstEnableOnly,
			[Token(Token = "0x40005DC")]
			EveryEnable
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D06C", Offset = "0x75D06C")]
		private sealed class <>c__DisplayClass40_0
		{
			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent anEvent;

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1B2E174", Offset = "0x1B2E174", VA = "0x1B2E174")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1B2E17C", Offset = "0x1B2E17C", VA = "0x1B2E17C")]
			internal bool <RemoveItems>b__0(CustomEvent cEvent)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D07C", Offset = "0x75D07C")]
		private sealed class <>c__DisplayClass40_1
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1B2E1D0", Offset = "0x1B2E1D0", VA = "0x1B2E1D0")]
			public <>c__DisplayClass40_1()
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1B2E1D8", Offset = "0x1B2E1D8", VA = "0x1B2E1D8")]
			internal bool <RemoveItems>b__1(CustomEventCategory category)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D08C", Offset = "0x75D08C")]
		private sealed class <>c__DisplayClass41_0
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MasterAudio.Playlist aPlaylist;

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1B2E22C", Offset = "0x1B2E22C", VA = "0x1B2E22C")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1B2E234", Offset = "0x1B2E234", VA = "0x1B2E234")]
			internal bool <CreateItems>b__0(MasterAudio.Playlist playlist)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005B8")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int _instanceId;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000A9")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x8B4688", Offset = "0x8B4688", VA = "0x8B4688")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AA")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x8B651C", Offset = "0x8B651C", VA = "0x8B651C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public int InstanceId
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x8B334C", Offset = "0x8B334C", VA = "0x8B334C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AC")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x8B6524", Offset = "0x8B6524", VA = "0x8B6524")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x8B1878", Offset = "0x8B1878", VA = "0x8B1878")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x8B1950", Offset = "0x8B1950", VA = "0x8B1950")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x8B1A48", Offset = "0x8B1A48", VA = "0x8B1A48")]
		private void Start()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x8B1A4C", Offset = "0x8B1A4C", VA = "0x8B1A4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x8B1954", Offset = "0x8B1954", VA = "0x8B1954")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x8B1B74", Offset = "0x8B1B74", VA = "0x8B1B74")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x8B2374", Offset = "0x8B2374", VA = "0x8B2374")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x8B6270", Offset = "0x8B6270", VA = "0x8B6270")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x8B4044", Offset = "0x8B4044", VA = "0x8B4044")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x8B652C", Offset = "0x8B652C", VA = "0x8B652C")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public static class OculusAudioHelper
	{
		[Token(Token = "0x170000AD")]
		public static bool OculusAudioOptionExists
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x15A1880", Offset = "0x15A1880", VA = "0x15A1880")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x15A1888", Offset = "0x15A1888", VA = "0x15A1888")]
		public static bool DarkTonicOculusAudioPackageInstalled()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x15A1890", Offset = "0x15A1890", VA = "0x15A1890")]
		public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x15A19BC", Offset = "0x15A19BC", VA = "0x15A19BC")]
		public static void AddOculusAudioSourceToAllVariations()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x15A1C08", Offset = "0x15A1C08", VA = "0x15A1C08")]
		public static void RemoveOculusAudioSourceFromAllVariations()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x15A1E40", Offset = "0x15A1E40", VA = "0x15A1E40")]
		public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x15A1E48", Offset = "0x15A1E48", VA = "0x15A1E48")]
		public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x15A1E50", Offset = "0x15A1E50", VA = "0x15A1E50")]
		public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x40005E4")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x40005E5")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x8C698C", Offset = "0x8C698C", VA = "0x8C698C")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x8C6DE4", Offset = "0x8C6DE4", VA = "0x8C6DE4")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x8C6E64", Offset = "0x8C6E64", VA = "0x8C6E64")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x8C6F98", Offset = "0x8C6F98", VA = "0x8C6F98")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x8C7118", Offset = "0x8C7118", VA = "0x8C7118")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x8C72A0", Offset = "0x8C72A0", VA = "0x8C72A0")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x8C7424", Offset = "0x8C7424", VA = "0x8C7424")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x8C7504", Offset = "0x8C7504", VA = "0x8C7504")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x8C7644", Offset = "0x8C7644", VA = "0x8C7644")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x8C77EC", Offset = "0x8C77EC", VA = "0x8C77EC")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x8C7974", Offset = "0x8C7974", VA = "0x8C7974")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x8C7B1C", Offset = "0x8C7B1C", VA = "0x8C7B1C")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x8C7CAC", Offset = "0x8C7CAC", VA = "0x8C7CAC")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x8C7DBC", Offset = "0x8C7DBC", VA = "0x8C7DBC")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x8C7F50", Offset = "0x8C7F50", VA = "0x8C7F50")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x8C7FD0", Offset = "0x8C7FD0", VA = "0x8C7FD0")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x8C8048", Offset = "0x8C8048", VA = "0x8C8048")]
		public static void Flush()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x8C81E4", Offset = "0x8C81E4", VA = "0x8C81E4")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x8C6AFC", Offset = "0x8C6AFC", VA = "0x8C6AFC")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x8C86EC", Offset = "0x8C86EC", VA = "0x8C86EC")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x8C8798", Offset = "0x8C8798", VA = "0x8C8798")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x8C8844", Offset = "0x8C8844", VA = "0x8C8844")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x75D09C", Offset = "0x75D09C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x75D09C", Offset = "0x75D09C")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000B1")]
		public enum FadeStatus
		{
			[Token(Token = "0x4000646")]
			NotFading,
			[Token(Token = "0x4000647")]
			FadingIn,
			[Token(Token = "0x4000648")]
			FadeingOut
		}

		[Token(Token = "0x20000B2")]
		public enum AudioPlayType
		{
			[Token(Token = "0x400064A")]
			PlayNow,
			[Token(Token = "0x400064B")]
			Schedule,
			[Token(Token = "0x400064C")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000B3")]
		public enum PlaylistStates
		{
			[Token(Token = "0x400064E")]
			NotInScene,
			[Token(Token = "0x400064F")]
			Stopped,
			[Token(Token = "0x4000650")]
			Playing,
			[Token(Token = "0x4000651")]
			Paused,
			[Token(Token = "0x4000652")]
			Crossfading
		}

		[Token(Token = "0x20000B4")]
		public enum FadeMode
		{
			[Token(Token = "0x4000654")]
			None,
			[Token(Token = "0x4000655")]
			GradualFade
		}

		[Token(Token = "0x20000B5")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000657")]
			NotDucking,
			[Token(Token = "0x4000658")]
			SetToDuck,
			[Token(Token = "0x4000659")]
			Ducked,
			[Token(Token = "0x400065A")]
			Unducking
		}

		[Token(Token = "0x20000B6")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x20000B7")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000B8")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x20000B9")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75D110", Offset = "0x75D110")]
		private sealed class <>c__DisplayClass155_0
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x1B2F828", Offset = "0x1B2F828", VA = "0x1B2F828")]
			public <>c__DisplayClass155_0()
			{
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0x1B2F830", Offset = "0x1B2F830", VA = "0x1B2F830")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x40005E7")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40005E8")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40005E9")]
		private const double UniversalAudioReactionTime = 0.3;

		[Token(Token = "0x40005EA")]
		private const int NextScheduleTimeRecalcConsecutiveFrameCount = 5;

		[Token(Token = "0x40005EB")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40005EC")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40005ED")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool ignoreListenerPause;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _actorUpdater;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _unduckTime;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private MusicSetting _currentSong;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private GameObject _go;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private string _name;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool _lostFocus;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private AudioSource _audioClip;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private AudioSource _transClip;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private bool _nextSongRequested;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x181")]
		private bool _nextSongScheduled;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private int? _lastSongPosition;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _nextScheduleTimeRecalcDifferentFirstFrameNum;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private double? _nextScheduledTimeRecalcStart;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public int _frames;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private AudioSource _audio1;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private AudioSource _audio2;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private string _activeSongAlias;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Transform _trans;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private bool _willPersist;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private double? _songPauseTime;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private int framesOfSongPlayed;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCDC", Offset = "0x75DCDC")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x251")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75DCEC", Offset = "0x75DCEC")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000AE")]
		private bool WillSyncToOtherClip
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x15A91B0", Offset = "0x15A91B0", VA = "0x15A91B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public bool CurrentSongIsPlaying
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x15A9370", Offset = "0x15A9370", VA = "0x15A9370")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x15AA50C", Offset = "0x15AA50C", VA = "0x15AA50C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0x15AA564", Offset = "0x15AA564", VA = "0x15AA564")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E650", Offset = "0x75E650")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0x15AA56C", Offset = "0x15AA56C", VA = "0x15AA56C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E660", Offset = "0x75E660")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public FadeStatus CurrentFadeStatus
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x15AA578", Offset = "0x15AA578", VA = "0x15AA578")]
			get
			{
				return default(FadeStatus);
			}
		}

		[Token(Token = "0x170000B3")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x15A5E98", Offset = "0x15A5E98", VA = "0x15A5E98")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000B4")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x15A5030", Offset = "0x15A5030", VA = "0x15A5030")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x15A6324", Offset = "0x15A6324", VA = "0x15A6324")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x15AA5A4", Offset = "0x15AA5A4", VA = "0x15AA5A4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000430")]
			[Address(RVA = "0x15AA5F4", Offset = "0x15AA5F4", VA = "0x15AA5F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0x15AA5FC", Offset = "0x15AA5FC", VA = "0x15AA5FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0x15AA604", Offset = "0x15AA604", VA = "0x15AA604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x15AA698", Offset = "0x15AA698", VA = "0x15AA698")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x15AA734", Offset = "0x15AA734", VA = "0x15AA734")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x15AA74C", Offset = "0x15AA74C", VA = "0x15AA74C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E670", Offset = "0x75E670")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x15AA754", Offset = "0x15AA754", VA = "0x15AA754")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E680", Offset = "0x75E680")]
			private set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public bool IsFading
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x15AA760", Offset = "0x15AA760", VA = "0x15AA760")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BD")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x15A8D5C", Offset = "0x15A8D5C", VA = "0x15A8D5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x15AA780", Offset = "0x15AA780", VA = "0x15AA780")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x15A94C0", Offset = "0x15A94C0", VA = "0x15A94C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public bool HasPlaylist
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0x15A6680", Offset = "0x15A6680", VA = "0x15A6680")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public string PlaylistName
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0x15AA7CC", Offset = "0x15AA7CC", VA = "0x15AA7CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public MusicSetting CurrentSong
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0x15AA840", Offset = "0x15AA840", VA = "0x15AA840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private bool IsMuted
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0x15AA848", Offset = "0x15AA848", VA = "0x15AA848")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0x15A67FC", Offset = "0x15A67FC", VA = "0x15A67FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0x15A5CAC", Offset = "0x15A5CAC", VA = "0x15A5CAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C5")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000442")]
			[Address(RVA = "0x15A5D38", Offset = "0x15A5D38", VA = "0x15A5D38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C6")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0x15A7090", Offset = "0x15A7090", VA = "0x15A7090")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public string ControllerName
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0x15A3A28", Offset = "0x15A3A28", VA = "0x15A3A28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0x15A3FD8", Offset = "0x15A3FD8", VA = "0x15A3FD8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000446")]
			[Address(RVA = "0x15A4734", Offset = "0x15A4734", VA = "0x15A4734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x15A5E5C", Offset = "0x15A5E5C", VA = "0x15A5E5C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CB")]
		private Transform Trans
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15A4640", Offset = "0x15A4640", VA = "0x15A4640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x15AA850", Offset = "0x15AA850", VA = "0x15AA850")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x15A2F34", Offset = "0x15A2F34", VA = "0x15A2F34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E5D0", Offset = "0x75E5D0")]
			add
			{
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x15A2FD8", Offset = "0x15A2FD8", VA = "0x15A2FD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E5E0", Offset = "0x75E5E0")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x15A307C", Offset = "0x15A307C", VA = "0x15A307C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E5F0", Offset = "0x75E5F0")]
			add
			{
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x15A3120", Offset = "0x15A3120", VA = "0x15A3120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E600", Offset = "0x75E600")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x15A31C4", Offset = "0x15A31C4", VA = "0x15A31C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E610", Offset = "0x75E610")]
			add
			{
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x15A3268", Offset = "0x15A3268", VA = "0x15A3268")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E620", Offset = "0x75E620")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x15A330C", Offset = "0x15A330C", VA = "0x15A330C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E630", Offset = "0x75E630")]
			add
			{
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x15A33B0", Offset = "0x15A33B0", VA = "0x15A33B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x75E640", Offset = "0x75E640")]
			remove
			{
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x15A3454", Offset = "0x15A3454", VA = "0x15A3454")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x15A3A68", Offset = "0x15A3A68", VA = "0x15A3A68")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x15A3C84", Offset = "0x15A3C84", VA = "0x15A3C84")]
		private void DetectAndRescheduleNextGaplessSongIfOff()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x15A41F4", Offset = "0x15A41F4", VA = "0x15A41F4")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x15A436C", Offset = "0x15A436C", VA = "0x15A436C")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x15A3BD4", Offset = "0x15A3BD4", VA = "0x15A3BD4")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x15A43F4", Offset = "0x15A43F4", VA = "0x15A43F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x15A46CC", Offset = "0x15A46CC", VA = "0x15A46CC")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x15A4804", Offset = "0x15A4804", VA = "0x15A4804")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x15A4CB8", Offset = "0x15A4CB8", VA = "0x15A4CB8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x15A4DBC", Offset = "0x15A4DBC", VA = "0x15A4DBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x15A5104", Offset = "0x15A5104", VA = "0x15A5104")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x15A5110", Offset = "0x15A5110", VA = "0x15A5110")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x15A6190", Offset = "0x15A6190", VA = "0x15A6190")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x15A6514", Offset = "0x15A6514", VA = "0x15A6514")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x15A6690", Offset = "0x15A6690", VA = "0x15A6690")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x15A6740", Offset = "0x15A6740", VA = "0x15A6740")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x15A472C", Offset = "0x15A472C", VA = "0x15A472C")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x15A67F4", Offset = "0x15A67F4", VA = "0x15A67F4")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x15A696C", Offset = "0x15A696C", VA = "0x15A696C")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x15A6B7C", Offset = "0x15A6B7C", VA = "0x15A6B7C")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x15A4B84", Offset = "0x15A4B84", VA = "0x15A4B84")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x15A711C", Offset = "0x15A711C", VA = "0x15A711C")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x15A7248", Offset = "0x15A7248", VA = "0x15A7248")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x15A72DC", Offset = "0x15A72DC", VA = "0x15A72DC")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x15A74D8", Offset = "0x15A74D8", VA = "0x15A74D8")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x15A7D1C", Offset = "0x15A7D1C", VA = "0x15A7D1C")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x15A7E58", Offset = "0x15A7E58", VA = "0x15A7E58")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x15A7EEC", Offset = "0x15A7EEC", VA = "0x15A7EEC")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x15A8098", Offset = "0x15A8098", VA = "0x15A8098")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x15A810C", Offset = "0x15A810C", VA = "0x15A810C")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x15A8308", Offset = "0x15A8308", VA = "0x15A8308")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x15A84BC", Offset = "0x15A84BC", VA = "0x15A84BC")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x15A881C", Offset = "0x15A881C", VA = "0x15A881C")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x15A8AF0", Offset = "0x15A8AF0", VA = "0x15A8AF0")]
		public void EndDucking(SoundGroupVariationUpdater actorUpdater)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x15A8B90", Offset = "0x15A8B90", VA = "0x15A8B90")]
		public void DuckMusicForTime(SoundGroupVariationUpdater actorUpdater, float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x15A8D2C", Offset = "0x15A8D2C", VA = "0x15A8D2C")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x15A4A54", Offset = "0x15A4A54", VA = "0x15A4A54")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x15A8DC8", Offset = "0x15A8DC8", VA = "0x15A8DC8")]
		public void StartPlaylist(string playlistName, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x15A8F54", Offset = "0x15A8F54", VA = "0x15A8F54")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x15A6F88", Offset = "0x15A6F88", VA = "0x15A6F88")]
		private void FinishPlaylistInit(bool playFirstClip = true, [Optional] string clipName)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x15A8EAC", Offset = "0x15A8EAC", VA = "0x15A8EAC")]
		public void RestartPlaylist([Optional] string clipName)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x15A90B8", Offset = "0x15A90B8", VA = "0x15A90B8")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x15A91E8", Offset = "0x15A91E8", VA = "0x15A91E8")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x15A5FA0", Offset = "0x15A5FA0", VA = "0x15A5FA0")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x15A460C", Offset = "0x15A460C", VA = "0x15A460C")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x15A475C", Offset = "0x15A475C", VA = "0x15A475C")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x15A5D70", Offset = "0x15A5D70", VA = "0x15A5D70")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x15A7B54", Offset = "0x15A7B54", VA = "0x15A7B54")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x15A7578", Offset = "0x15A7578", VA = "0x15A7578")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x15AA108", Offset = "0x15AA108", VA = "0x15AA108")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x15A9570", Offset = "0x15A9570", VA = "0x15A9570")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x15AA3DC", Offset = "0x15AA3DC", VA = "0x15AA3DC")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x15A84B4", Offset = "0x15A84B4", VA = "0x15A84B4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x15A609C", Offset = "0x15A609C", VA = "0x15A609C")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x15AA1C8", Offset = "0x15AA1C8", VA = "0x15AA1C8")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x15AA484", Offset = "0x15AA484", VA = "0x15AA484")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x15A406C", Offset = "0x15A406C", VA = "0x15A406C")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause, bool addDspTime = true)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x15AA2AC", Offset = "0x15AA2AC", VA = "0x15AA2AC")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x15A57F4", Offset = "0x15A57F4", VA = "0x15A57F4")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x15A5BC8", Offset = "0x15A5BC8", VA = "0x15A5BC8")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x15A60A4", Offset = "0x15A60A4", VA = "0x15A60A4")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x15AA500", Offset = "0x15AA500", VA = "0x15AA500")]
		private void ResetDuckingState()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x15A9434", Offset = "0x15A9434", VA = "0x15A9434")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x15AA788", Offset = "0x15AA788", VA = "0x15AA788")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x15AA89C", Offset = "0x15AA89C", VA = "0x15AA89C")]
		public PlaylistController()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x400065D")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x400065E")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000CD")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1B2B76C", Offset = "0x1B2B76C", VA = "0x1B2B76C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1B2B808", Offset = "0x1B2B808", VA = "0x1B2B808")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1B2B858", Offset = "0x1B2B858", VA = "0x1B2B858")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1B2B800", Offset = "0x1B2B800", VA = "0x1B2B800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1B2B8A8", Offset = "0x1B2B8A8", VA = "0x1B2B8A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1B2B8B0", Offset = "0x1B2B8B0", VA = "0x1B2B8B0")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1B2BA18", Offset = "0x1B2BA18", VA = "0x1B2BA18")]
		private static void SetSpatializerToggleOnSource(AudioSource source, bool enabled)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public static class UtilStrings
	{
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1B2D058", Offset = "0x1B2D058", VA = "0x1B2D058")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1B2D0D4", Offset = "0x1B2D0D4", VA = "0x1B2D0D4")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x20000BD")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x8C99DC", Offset = "0x8C99DC", VA = "0x8C99DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x8C99E0", Offset = "0x8C99E0", VA = "0x8C99E0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x8C9B20", Offset = "0x8C9B20", VA = "0x8C9B20")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x8C9B28", Offset = "0x8C9B28", VA = "0x8C9B28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x8C9B8C", Offset = "0x8C9B8C", VA = "0x8C9B8C")]
		private void Update()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x8C9C28", Offset = "0x8C9C28", VA = "0x8C9C28")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x8C9C30", Offset = "0x8C9C30", VA = "0x8C9C30")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x8C9CB8", Offset = "0x8C9CB8", VA = "0x8C9CB8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x8C9DA8", Offset = "0x8C9DA8", VA = "0x8C9DA8")]
		private void Update()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x8C9EE4", Offset = "0x8C9EE4", VA = "0x8C9EE4")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x8C9EEC", Offset = "0x8C9EEC", VA = "0x8C9EEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x8C9F58", Offset = "0x8C9F58", VA = "0x8C9F58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x8CA100", Offset = "0x8CA100", VA = "0x8CA100")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8CA108", Offset = "0x8CA108", VA = "0x8CA108")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x8CA1BC", Offset = "0x8CA1BC", VA = "0x8CA1BC")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x8CA1C4", Offset = "0x8CA1C4", VA = "0x8CA1C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8CA1FC", Offset = "0x8CA1FC", VA = "0x8CA1FC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8CA2EC", Offset = "0x8CA2EC", VA = "0x8CA2EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8CA3D4", Offset = "0x8CA3D4", VA = "0x8CA3D4")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8CA3DC", Offset = "0x8CA3DC", VA = "0x8CA3DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8CA490", Offset = "0x8CA490", VA = "0x8CA490")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x400066B")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8CA498", Offset = "0x8CA498", VA = "0x8CA498")]
		private void Awake()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8CA4D0", Offset = "0x8CA4D0", VA = "0x8CA4D0")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x8CA57C", Offset = "0x8CA57C", VA = "0x8CA57C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x8CA580", Offset = "0x8CA580", VA = "0x8CA580")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x8CA584", Offset = "0x8CA584", VA = "0x8CA584")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8CA588", Offset = "0x8CA588", VA = "0x8CA588")]
		private void Update()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x8CA7D4", Offset = "0x8CA7D4", VA = "0x8CA7D4")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x170000D2")]
		private bool PlayerActive
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x8CA814", Offset = "0x8CA814", VA = "0x8CA814")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x8CA7E4", Offset = "0x8CA7E4", VA = "0x8CA7E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x8CA830", Offset = "0x8CA830", VA = "0x8CA830")]
		private void Update()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x8CA8B4", Offset = "0x8CA8B4", VA = "0x8CA8B4")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x8CA8BC", Offset = "0x8CA8BC", VA = "0x8CA8BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x8CA8C0", Offset = "0x8CA8C0", VA = "0x8CA8C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x8CAA30", Offset = "0x8CAA30", VA = "0x8CAA30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x8CAAAC", Offset = "0x8CAAAC", VA = "0x8CAAAC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x8CA8C4", Offset = "0x8CA8C4", VA = "0x8CA8C4", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x8CAC30", Offset = "0x8CAC30", VA = "0x8CAC30", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x8CAD7C", Offset = "0x8CAD7C", VA = "0x8CAD7C", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x8CAA34", Offset = "0x8CAA34", VA = "0x8CAA34", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8CABD0", Offset = "0x8CABD0", VA = "0x8CABD0", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x8CAE04", Offset = "0x8CAE04", VA = "0x8CAE04", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x8CAF48", Offset = "0x8CAF48", VA = "0x8CAF48")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x8CB02C", Offset = "0x8CB02C", VA = "0x8CB02C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x8CB0E0", Offset = "0x8CB0E0", VA = "0x8CB0E0")]
		public MA_TestUI()
		{
		}
	}
}
