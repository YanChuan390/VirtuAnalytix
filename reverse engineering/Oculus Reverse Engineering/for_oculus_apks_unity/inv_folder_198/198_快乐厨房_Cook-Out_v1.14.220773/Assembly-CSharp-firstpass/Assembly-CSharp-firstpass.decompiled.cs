using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using DarkTonic.MasterAudio;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using Il2CppDummyDll;
using POpusCodec;
using POpusCodec.Enums;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MA_Bootstrapper : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0x8A687C", Offset = "0x8A687C", VA = "0x8A687C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x8A6880", Offset = "0x8A6880", VA = "0x8A6880")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x8A69AC", Offset = "0x8A69AC", VA = "0x8A69AC")]
	public MA_Bootstrapper()
	{
	}
}
[Token(Token = "0x2000003")]
public class MA_DestroyFinishedParticle : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem particles;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x8A69B4", Offset = "0x8A69B4", VA = "0x8A69B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x8A6A14", Offset = "0x8A6A14", VA = "0x8A6A14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x8A6AA4", Offset = "0x8A6AA4", VA = "0x8A6AA4")]
	public MA_DestroyFinishedParticle()
	{
	}
}
[Token(Token = "0x2000004")]
public class MA_EnemyOne : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ExplosionParticlePrefab;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform _trans;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _speed;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _horizSpeed;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x8A6AAC", Offset = "0x8A6AAC", VA = "0x8A6AAC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x8A6B30", Offset = "0x8A6B30", VA = "0x8A6B30")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x8A6C34", Offset = "0x8A6C34", VA = "0x8A6C34")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x8A6D7C", Offset = "0x8A6D7C", VA = "0x8A6D7C")]
	public MA_EnemyOne()
	{
	}
}
[Token(Token = "0x2000005")]
public class MA_EnemySpawner : MonoBehaviour
{
	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Enemy;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool spawnerEnabled;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform trans;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float nextSpawnTime;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x8A6D84", Offset = "0x8A6D84", VA = "0x8A6D84")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x8A6DE4", Offset = "0x8A6DE4", VA = "0x8A6DE4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x8A6F70", Offset = "0x8A6F70", VA = "0x8A6F70")]
	public MA_EnemySpawner()
	{
	}
}
[Token(Token = "0x2000006")]
public class MA_GameScene : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x8A6F78", Offset = "0x8A6F78", VA = "0x8A6F78")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x8A7020", Offset = "0x8A7020", VA = "0x8A7020")]
	public MA_GameScene()
	{
	}
}
[Token(Token = "0x2000007")]
public class MA_Laser : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _trans;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x8A7028", Offset = "0x8A7028", VA = "0x8A7028")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x8A7054", Offset = "0x8A7054", VA = "0x8A7054")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x8A712C", Offset = "0x8A712C", VA = "0x8A712C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x8A7208", Offset = "0x8A7208", VA = "0x8A7208")]
	public MA_Laser()
	{
	}
}
[Token(Token = "0x2000008")]
public class MA_LocalizationUI : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x8A7210", Offset = "0x8A7210", VA = "0x8A7210")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x8A72B8", Offset = "0x8A72B8", VA = "0x8A72B8")]
	public MA_LocalizationUI()
	{
	}
}
[Token(Token = "0x2000009")]
public class MA_PlayerControl : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject ProjectilePrefab;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool canShoot;

	[Token(Token = "0x400000D")]
	private const float MoveSpeed = 10f;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float _lastMoveAmt;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x8A72C0", Offset = "0x8A72C0", VA = "0x8A72C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x8A72EC", Offset = "0x8A72EC", VA = "0x8A72EC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x8A7388", Offset = "0x8A7388", VA = "0x8A7388")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x8A738C", Offset = "0x8A738C", VA = "0x8A738C")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x8A7390", Offset = "0x8A7390", VA = "0x8A7390")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x8A7394", Offset = "0x8A7394", VA = "0x8A7394")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x8A75C0", Offset = "0x8A75C0", VA = "0x8A75C0")]
	public MA_PlayerControl()
	{
	}
}
[Token(Token = "0x200000A")]
public class MA_PlayerSpawnerControl : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Player;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float nextSpawnTime;

	[Token(Token = "0x17000001")]
	private bool PlayerActive
	{
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x8A75F4", Offset = "0x8A75F4", VA = "0x8A75F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x8A75D0", Offset = "0x8A75D0", VA = "0x8A75D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x8A7610", Offset = "0x8A7610", VA = "0x8A7610")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x8A7688", Offset = "0x8A7688", VA = "0x8A7688")]
	public MA_PlayerSpawnerControl()
	{
	}
}
[Token(Token = "0x200000B")]
public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly List<string> _eventsSubscribedTo;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x8A7690", Offset = "0x8A7690", VA = "0x8A7690")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x8A7694", Offset = "0x8A7694", VA = "0x8A7694")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x8A77F0", Offset = "0x8A77F0", VA = "0x8A77F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x8A7864", Offset = "0x8A7864", VA = "0x8A7864")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x8A7698", Offset = "0x8A7698", VA = "0x8A7698", Slot = "4")]
	public void CheckForIllegalCustomEvents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x8A79B4", Offset = "0x8A79B4", VA = "0x8A79B4", Slot = "5")]
	public void ReceiveEvent(string customEventName, Vector3 originPoint)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x8A7AE4", Offset = "0x8A7AE4", VA = "0x8A7AE4", Slot = "6")]
	public bool SubscribesToEvent(string customEventName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x8A77F4", Offset = "0x8A77F4", VA = "0x8A77F4", Slot = "7")]
	public void RegisterReceiver()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x8A795C", Offset = "0x8A795C", VA = "0x8A795C", Slot = "8")]
	public void UnregisterReceiver()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x8A7B5C", Offset = "0x8A7B5C", VA = "0x8A7B5C", Slot = "9")]
	public IList<AudioEventGroup> GetAllEvents()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x8A7CD4", Offset = "0x8A7CD4", VA = "0x8A7CD4")]
	public MA_SampleICustomEventReceiver()
	{
	}
}
[Token(Token = "0x200000C")]
public class MA_TestUI : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x8A7E40", Offset = "0x8A7E40", VA = "0x8A7E40")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x8A7EE8", Offset = "0x8A7EE8", VA = "0x8A7EE8")]
	public MA_TestUI()
	{
	}
}
[Token(Token = "0x200000D")]
public static class AudioLoaderOptimizer
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x8A7EF0", Offset = "0x8A7EF0", VA = "0x8A7EF0")]
	public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x8A8198", Offset = "0x8A8198", VA = "0x8A8198")]
	public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x8A8344", Offset = "0x8A8344", VA = "0x8A8344")]
	public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000E")]
[AudioScriptOrder(-10)]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x17000002")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x8A857C", Offset = "0x8A857C", VA = "0x8A857C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x8A88E4", Offset = "0x8A88E4", VA = "0x8A88E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000004")]
	public Transform Trans
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x8A8864", Offset = "0x8A8864", VA = "0x8A8864")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x8A8510", Offset = "0x8A8510", VA = "0x8A8510")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x8A8628", Offset = "0x8A8628", VA = "0x8A8628")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x8A8674", Offset = "0x8A8674", VA = "0x8A8674")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x8A872C", Offset = "0x8A872C", VA = "0x8A872C")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x8A8964", Offset = "0x8A8964", VA = "0x8A8964")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200000F")]
public static class OculusAudioHelper
{
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x8A896C", Offset = "0x8A896C", VA = "0x8A896C")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x8A8974", Offset = "0x8A8974", VA = "0x8A8974")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x8A8978", Offset = "0x8A8978", VA = "0x8A8978")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x8A897C", Offset = "0x8A897C", VA = "0x8A897C")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x8A8980", Offset = "0x8A8980", VA = "0x8A8980")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x8A8984", Offset = "0x8A8984", VA = "0x8A8984")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x8A8988", Offset = "0x8A8988", VA = "0x8A8988")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000010")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000005")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x8A898C", Offset = "0x8A898C", VA = "0x8A898C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x8A8994", Offset = "0x8A8994", VA = "0x8A8994")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x8A899C", Offset = "0x8A899C", VA = "0x8A899C")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x8A89A0", Offset = "0x8A89A0", VA = "0x8A89A0")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x8A89A4", Offset = "0x8A89A4", VA = "0x8A89A4")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x8A89A8", Offset = "0x8A89A8", VA = "0x8A89A8")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x8A89AC", Offset = "0x8A89AC", VA = "0x8A89AC")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x8A89B0", Offset = "0x8A89B0", VA = "0x8A89B0")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000011")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SphereCollider _collider;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _soundType;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _variationName;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _willFollowSource;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool _isInsideTrigger;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool _hasPlayedSound;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool _groupLoadFailed;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MasterAudioGroup _groupToPlay;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _playVolume;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float _exitFadeTime;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float _reEnterFadeTime;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly List<Collider> _actorColliders;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly List<Collider2D> _actorColliders2D;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<Collider2D, Vector3> _lastPositionByCollider2D;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000006")]
	public SphereCollider Trigger
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x8A8A74", Offset = "0x8A8A74", VA = "0x8A8A74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x8A9B1C", Offset = "0x8A9B1C", VA = "0x8A9B1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public Transform Trans
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x8AA21C", Offset = "0x8AA21C", VA = "0x8AA21C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x8A89B4", Offset = "0x8A89B4", VA = "0x8A89B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x8A8B20", Offset = "0x8A8B20", VA = "0x8A8B20")]
	private void Start()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x8A8B88", Offset = "0x8A8B88", VA = "0x8A8B88")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x8A8D2C", Offset = "0x8A8D2C", VA = "0x8A8D2C")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x8A9AB0", Offset = "0x8A9AB0", VA = "0x8A9AB0")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x8A9B9C", Offset = "0x8A9B9C", VA = "0x8A9B9C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x8A9F50", Offset = "0x8A9F50", VA = "0x8A9F50")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x8A93A8", Offset = "0x8A93A8", VA = "0x8A93A8")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x8AA29C", Offset = "0x8AA29C", VA = "0x8AA29C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x8AA5AC", Offset = "0x8AA5AC", VA = "0x8AA5AC")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x8A8BE8", Offset = "0x8A8BE8", VA = "0x8A8BE8")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x8AA690", Offset = "0x8AA690", VA = "0x8AA690")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000012")]
public class LeanAudioStream
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int position;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip audioClip;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float[] audioArr;

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x8AA7E8", Offset = "0x8AA7E8", VA = "0x8AA7E8")]
	public LeanAudioStream(float[] audioArr)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x8AA810", Offset = "0x8AA810", VA = "0x8AA810")]
	public void OnAudioRead(float[] data)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x8AA884", Offset = "0x8AA884", VA = "0x8AA884")]
	public void OnAudioSetPosition(int newPosition)
	{
	}
}
[Token(Token = "0x2000013")]
public class LeanAudio
{
	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float MIN_FREQEUNCY_PERIOD;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int PROCESSING_ITERATIONS_MAX;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float[] generatedWaveDistances;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static int generatedWaveDistancesCount;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static float[] longList;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x8AA88C", Offset = "0x8AA88C", VA = "0x8AA88C")]
	public static LeanAudioOptions options()
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x8AA9B4", Offset = "0x8AA9B4", VA = "0x8AA9B4")]
	public static LeanAudioStream createAudioStream(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x8AB2F8", Offset = "0x8AB2F8", VA = "0x8AB2F8")]
	public static AudioClip createAudio(AnimationCurve volume, AnimationCurve frequency, [Optional] LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x8AAA84", Offset = "0x8AAA84", VA = "0x8AAA84")]
	private static int createAudioWave(AnimationCurve volume, AnimationCurve frequency, LeanAudioOptions options)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x8AAE10", Offset = "0x8AAE10", VA = "0x8AAE10")]
	private static AudioClip createAudioFromWave(int waveLength, LeanAudioOptions options)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x8AB3BC", Offset = "0x8AB3BC", VA = "0x8AB3BC")]
	private static void OnAudioSetPosition(int newPosition)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x8AB3C0", Offset = "0x8AB3C0", VA = "0x8AB3C0")]
	public static AudioClip generateAudioFromCurve(AnimationCurve curve, int frequencyRate = 44100)
	{
		return null;
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x8AB52C", Offset = "0x8AB52C", VA = "0x8AB52C")]
	public static AudioSource play(AudioClip audio, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x8AB728", Offset = "0x8AB728", VA = "0x8AB728")]
	public static AudioSource play(AudioClip audio)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x8AB7D0", Offset = "0x8AB7D0", VA = "0x8AB7D0")]
	public static AudioSource play(AudioClip audio, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x8AB84C", Offset = "0x8AB84C", VA = "0x8AB84C")]
	public static AudioSource play(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x8AB5F8", Offset = "0x8AB5F8", VA = "0x8AB5F8")]
	public static AudioSource playClipAt(AudioClip clip, Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x8AB8FC", Offset = "0x8AB8FC", VA = "0x8AB8FC")]
	public static void printOutAudioClip(AudioClip audioClip, ref AnimationCurve curve, float scaleX = 1f)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x8ABA98", Offset = "0x8ABA98", VA = "0x8ABA98")]
	public LeanAudio()
	{
	}
}
[Token(Token = "0x2000014")]
public class LeanAudioOptions
{
	[Token(Token = "0x2000015")]
	public enum LeanAudioWaveStyle
	{
		[Token(Token = "0x4000043")]
		Sine,
		[Token(Token = "0x4000044")]
		Square,
		[Token(Token = "0x4000045")]
		Sawtooth,
		[Token(Token = "0x4000046")]
		Noise
	}

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LeanAudioWaveStyle waveStyle;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] vibrato;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] modulation;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int frequencyRate;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float waveNoiseScale;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float waveNoiseInfluence;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool useSetData;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LeanAudioStream stream;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x8AA990", Offset = "0x8AA990", VA = "0x8AA990")]
	public LeanAudioOptions()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x8ABAF8", Offset = "0x8ABAF8", VA = "0x8ABAF8")]
	public LeanAudioOptions setFrequency(int frequencyRate)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x8ABB00", Offset = "0x8ABB00", VA = "0x8ABB00")]
	public LeanAudioOptions setVibrato(Vector3[] vibrato)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x8ABB08", Offset = "0x8ABB08", VA = "0x8ABB08")]
	public LeanAudioOptions setWaveSine()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x8ABB10", Offset = "0x8ABB10", VA = "0x8ABB10")]
	public LeanAudioOptions setWaveSquare()
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x8ABB1C", Offset = "0x8ABB1C", VA = "0x8ABB1C")]
	public LeanAudioOptions setWaveSawtooth()
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x8ABB28", Offset = "0x8ABB28", VA = "0x8ABB28")]
	public LeanAudioOptions setWaveNoise()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x8ABB34", Offset = "0x8ABB34", VA = "0x8ABB34")]
	public LeanAudioOptions setWaveStyle(LeanAudioWaveStyle style)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x8ABB3C", Offset = "0x8ABB3C", VA = "0x8ABB3C")]
	public LeanAudioOptions setWaveNoiseScale(float waveScale)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x8ABB44", Offset = "0x8ABB44", VA = "0x8ABB44")]
	public LeanAudioOptions setWaveNoiseInfluence(float influence)
	{
		return null;
	}
}
[Token(Token = "0x2000016")]
public class LeanTester : MonoBehaviour
{
	[Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class <timeoutCheck>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LeanTester <>4__this;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <pauseEndTime>5__2;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x8AC0F8", Offset = "0x8AC0F8", VA = "0x8AC0F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x8AC140", Offset = "0x8AC140", VA = "0x8AC140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x8ABBD4", Offset = "0x8ABBD4", VA = "0x8ABBD4")]
		[DebuggerHidden]
		public <timeoutCheck>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x8ABC0C", Offset = "0x8ABC0C", VA = "0x8ABC0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x8ABC10", Offset = "0x8ABC10", VA = "0x8ABC10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x8AC100", Offset = "0x8AC100", VA = "0x8AC100", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float timeout;

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x8ABB4C", Offset = "0x8ABB4C", VA = "0x8ABB4C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x8ABB6C", Offset = "0x8ABB6C", VA = "0x8ABB6C")]
	[IteratorStateMachine(typeof(<timeoutCheck>d__2))]
	private IEnumerator timeoutCheck()
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x8ABBFC", Offset = "0x8ABBFC", VA = "0x8ABBFC")]
	public LeanTester()
	{
	}
}
[Token(Token = "0x2000018")]
public class LeanTest
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int expected;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int tests;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static int passes;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float timeout;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool timeoutStarted;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public static bool testsFinished;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x8AC148", Offset = "0x8AC148", VA = "0x8AC148")]
	public static void debug(string name, bool didPass, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x8AC1B4", Offset = "0x8AC1B4", VA = "0x8AC1B4")]
	public static void expect(bool didPass, string definition, [Optional] string failExplaination)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x8ACA64", Offset = "0x8ACA64", VA = "0x8ACA64")]
	public static string padRight(int len)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x8AC7B0", Offset = "0x8AC7B0", VA = "0x8AC7B0")]
	public static float printOutLength(string str)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x8ACAD8", Offset = "0x8ACAD8", VA = "0x8ACAD8")]
	public static string formatBC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x8ABD64", Offset = "0x8ABD64", VA = "0x8ABD64")]
	public static string formatB(string str)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x8AC8DC", Offset = "0x8AC8DC", VA = "0x8AC8DC")]
	public static string formatC(string str, string color)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x8ABDD0", Offset = "0x8ABDD0", VA = "0x8ABDD0")]
	public static void overview()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x8ACB40", Offset = "0x8ACB40", VA = "0x8ACB40")]
	public LeanTest()
	{
	}
}
[Token(Token = "0x2000019")]
public enum TweenAction
{
	[Token(Token = "0x4000053")]
	MOVE_X,
	[Token(Token = "0x4000054")]
	MOVE_Y,
	[Token(Token = "0x4000055")]
	MOVE_Z,
	[Token(Token = "0x4000056")]
	MOVE_LOCAL_X,
	[Token(Token = "0x4000057")]
	MOVE_LOCAL_Y,
	[Token(Token = "0x4000058")]
	MOVE_LOCAL_Z,
	[Token(Token = "0x4000059")]
	MOVE_CURVED,
	[Token(Token = "0x400005A")]
	MOVE_CURVED_LOCAL,
	[Token(Token = "0x400005B")]
	MOVE_SPLINE,
	[Token(Token = "0x400005C")]
	MOVE_SPLINE_LOCAL,
	[Token(Token = "0x400005D")]
	SCALE_X,
	[Token(Token = "0x400005E")]
	SCALE_Y,
	[Token(Token = "0x400005F")]
	SCALE_Z,
	[Token(Token = "0x4000060")]
	ROTATE_X,
	[Token(Token = "0x4000061")]
	ROTATE_Y,
	[Token(Token = "0x4000062")]
	ROTATE_Z,
	[Token(Token = "0x4000063")]
	ROTATE_AROUND,
	[Token(Token = "0x4000064")]
	ROTATE_AROUND_LOCAL,
	[Token(Token = "0x4000065")]
	CANVAS_ROTATEAROUND,
	[Token(Token = "0x4000066")]
	CANVAS_ROTATEAROUND_LOCAL,
	[Token(Token = "0x4000067")]
	CANVAS_PLAYSPRITE,
	[Token(Token = "0x4000068")]
	ALPHA,
	[Token(Token = "0x4000069")]
	TEXT_ALPHA,
	[Token(Token = "0x400006A")]
	CANVAS_ALPHA,
	[Token(Token = "0x400006B")]
	CANVASGROUP_ALPHA,
	[Token(Token = "0x400006C")]
	ALPHA_VERTEX,
	[Token(Token = "0x400006D")]
	COLOR,
	[Token(Token = "0x400006E")]
	CALLBACK_COLOR,
	[Token(Token = "0x400006F")]
	TEXT_COLOR,
	[Token(Token = "0x4000070")]
	CANVAS_COLOR,
	[Token(Token = "0x4000071")]
	CANVAS_MOVE_X,
	[Token(Token = "0x4000072")]
	CANVAS_MOVE_Y,
	[Token(Token = "0x4000073")]
	CANVAS_MOVE_Z,
	[Token(Token = "0x4000074")]
	CALLBACK,
	[Token(Token = "0x4000075")]
	MOVE,
	[Token(Token = "0x4000076")]
	MOVE_LOCAL,
	[Token(Token = "0x4000077")]
	MOVE_TO_TRANSFORM,
	[Token(Token = "0x4000078")]
	ROTATE,
	[Token(Token = "0x4000079")]
	ROTATE_LOCAL,
	[Token(Token = "0x400007A")]
	SCALE,
	[Token(Token = "0x400007B")]
	VALUE3,
	[Token(Token = "0x400007C")]
	GUI_MOVE,
	[Token(Token = "0x400007D")]
	GUI_MOVE_MARGIN,
	[Token(Token = "0x400007E")]
	GUI_SCALE,
	[Token(Token = "0x400007F")]
	GUI_ALPHA,
	[Token(Token = "0x4000080")]
	GUI_ROTATE,
	[Token(Token = "0x4000081")]
	DELAYED_SOUND,
	[Token(Token = "0x4000082")]
	CANVAS_MOVE,
	[Token(Token = "0x4000083")]
	CANVAS_SCALE,
	[Token(Token = "0x4000084")]
	CANVAS_SIZEDELTA
}
[Token(Token = "0x200001A")]
public enum LeanTweenType
{
	[Token(Token = "0x4000086")]
	notUsed,
	[Token(Token = "0x4000087")]
	linear,
	[Token(Token = "0x4000088")]
	easeOutQuad,
	[Token(Token = "0x4000089")]
	easeInQuad,
	[Token(Token = "0x400008A")]
	easeInOutQuad,
	[Token(Token = "0x400008B")]
	easeInCubic,
	[Token(Token = "0x400008C")]
	easeOutCubic,
	[Token(Token = "0x400008D")]
	easeInOutCubic,
	[Token(Token = "0x400008E")]
	easeInQuart,
	[Token(Token = "0x400008F")]
	easeOutQuart,
	[Token(Token = "0x4000090")]
	easeInOutQuart,
	[Token(Token = "0x4000091")]
	easeInQuint,
	[Token(Token = "0x4000092")]
	easeOutQuint,
	[Token(Token = "0x4000093")]
	easeInOutQuint,
	[Token(Token = "0x4000094")]
	easeInSine,
	[Token(Token = "0x4000095")]
	easeOutSine,
	[Token(Token = "0x4000096")]
	easeInOutSine,
	[Token(Token = "0x4000097")]
	easeInExpo,
	[Token(Token = "0x4000098")]
	easeOutExpo,
	[Token(Token = "0x4000099")]
	easeInOutExpo,
	[Token(Token = "0x400009A")]
	easeInCirc,
	[Token(Token = "0x400009B")]
	easeOutCirc,
	[Token(Token = "0x400009C")]
	easeInOutCirc,
	[Token(Token = "0x400009D")]
	easeInBounce,
	[Token(Token = "0x400009E")]
	easeOutBounce,
	[Token(Token = "0x400009F")]
	easeInOutBounce,
	[Token(Token = "0x40000A0")]
	easeInBack,
	[Token(Token = "0x40000A1")]
	easeOutBack,
	[Token(Token = "0x40000A2")]
	easeInOutBack,
	[Token(Token = "0x40000A3")]
	easeInElastic,
	[Token(Token = "0x40000A4")]
	easeOutElastic,
	[Token(Token = "0x40000A5")]
	easeInOutElastic,
	[Token(Token = "0x40000A6")]
	easeSpring,
	[Token(Token = "0x40000A7")]
	easeShake,
	[Token(Token = "0x40000A8")]
	punch,
	[Token(Token = "0x40000A9")]
	once,
	[Token(Token = "0x40000AA")]
	clamp,
	[Token(Token = "0x40000AB")]
	pingPong,
	[Token(Token = "0x40000AC")]
	animationCurve
}
[Token(Token = "0x200001B")]
public class LeanTween : MonoBehaviour
{
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool throwErrors;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float tau;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float PI_DIV2;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTSeq[] sequences;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static LTDescr[] tweens;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static int[] tweensFinished;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] tweensFinishedIds;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static LTDescr tween;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static int tweenMaxSearch;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static int maxTweens;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static int maxSequences;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static int frameRendered;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static GameObject _tweenEmpty;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static float dtEstimated;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public static float dtManual;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static float dtActual;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private static uint global_counter;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static int i;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private static int j;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static int finishedCnt;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static AnimationCurve punch;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static AnimationCurve shake;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static int maxTweenReached;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public static int startSearch;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static LTDescr d;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static Action<LTEvent>[] eventListeners;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static GameObject[] goListeners;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static int eventsMaxSearch;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public static int EVENTS_MAX;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static int LISTENERS_MAX;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private static int INIT_LISTENERS_MAX;

	[Token(Token = "0x1700000B")]
	public static int maxSearch
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x8ACC50", Offset = "0x8ACC50", VA = "0x8ACC50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000C")]
	public static int maxSimulataneousTweens
	{
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x8ACCA8", Offset = "0x8ACCA8", VA = "0x8ACCA8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000D")]
	public static int tweensRunning
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x8ACD00", Offset = "0x8ACD00", VA = "0x8ACD00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000E")]
	public static GameObject tweenEmpty
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x8B0B84", Offset = "0x8B0B84", VA = "0x8B0B84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x8ACB98", Offset = "0x8ACB98", VA = "0x8ACB98")]
	public static void init()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x8ACBF0", Offset = "0x8ACBF0", VA = "0x8ACBF0")]
	public static void init(int maxSimultaneousTweens)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x8ACDB8", Offset = "0x8ACDB8", VA = "0x8ACDB8")]
	public static void init(int maxSimultaneousTweens, int maxSimultaneousSequences)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x8AD274", Offset = "0x8AD274", VA = "0x8AD274")]
	public static void reset()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x8AD3BC", Offset = "0x8AD3BC", VA = "0x8AD3BC")]
	public void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x8AD824", Offset = "0x8AD824", VA = "0x8AD824")]
	private static void onLevelWasLoaded54(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x8AD884", Offset = "0x8AD884", VA = "0x8AD884")]
	private static void internalOnLevelWasLoaded(int lvl)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x8AD408", Offset = "0x8AD408", VA = "0x8AD408")]
	public static void update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x8AE0FC", Offset = "0x8AE0FC", VA = "0x8AE0FC")]
	public static void removeTween(int i, int uniqueId)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x8ADCF4", Offset = "0x8ADCF4", VA = "0x8ADCF4")]
	public static void removeTween(int i)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x8AE314", Offset = "0x8AE314", VA = "0x8AE314")]
	public static Vector3[] add(Vector3[] a, Vector3 b)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x8AE480", Offset = "0x8AE480", VA = "0x8AE480")]
	public static float closestRot(float from, float to)
	{
		return default(float);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x8AE4D0", Offset = "0x8AE4D0", VA = "0x8AE4D0")]
	public static void cancelAll()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x8AE520", Offset = "0x8AE520", VA = "0x8AE520")]
	public static void cancelAll(bool callComplete)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x8AE6E8", Offset = "0x8AE6E8", VA = "0x8AE6E8")]
	public static void cancel(GameObject gameObject)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x8AE740", Offset = "0x8AE740", VA = "0x8AE740")]
	public static void cancel(GameObject gameObject, bool callOnComplete)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x8AE95C", Offset = "0x8AE95C", VA = "0x8AE95C")]
	public static void cancel(RectTransform rect)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x8AE9D0", Offset = "0x8AE9D0", VA = "0x8AE9D0")]
	public static void cancel(GameObject gameObject, int uniqueId, bool callOnComplete = false)
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x8AEC34", Offset = "0x8AEC34", VA = "0x8AEC34")]
	public static void cancel(LTRect ltRect, int uniqueId)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x8AED44", Offset = "0x8AED44", VA = "0x8AED44")]
	public static void cancel(int uniqueId)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x8AED9C", Offset = "0x8AED9C", VA = "0x8AED9C")]
	public static void cancel(int uniqueId, bool callOnComplete)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x8AEFBC", Offset = "0x8AEFBC", VA = "0x8AEFBC")]
	public static LTDescr descr(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x8AF1FC", Offset = "0x8AF1FC", VA = "0x8AF1FC")]
	public static LTDescr description(int uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x8AF250", Offset = "0x8AF250", VA = "0x8AF250")]
	public static LTDescr[] descriptions([Optional] GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x8AF4DC", Offset = "0x8AF4DC", VA = "0x8AF4DC")]
	[Obsolete("Use 'pause( id )' instead")]
	public static void pause(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x8AF530", Offset = "0x8AF530", VA = "0x8AF530")]
	public static void pause(int uniqueId)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x8AF624", Offset = "0x8AF624", VA = "0x8AF624")]
	public static void pause(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x8AF780", Offset = "0x8AF780", VA = "0x8AF780")]
	public static void pauseAll()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x8AF850", Offset = "0x8AF850", VA = "0x8AF850")]
	public static void resumeAll()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x8AF920", Offset = "0x8AF920", VA = "0x8AF920")]
	[Obsolete("Use 'resume( id )' instead")]
	public static void resume(GameObject gameObject, int uniqueId)
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x8AF974", Offset = "0x8AF974", VA = "0x8AF974")]
	public static void resume(int uniqueId)
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x8AFA44", Offset = "0x8AFA44", VA = "0x8AFA44")]
	public static void resume(GameObject gameObject)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x8AFB94", Offset = "0x8AFB94", VA = "0x8AFB94")]
	public static bool isTweening([Optional] GameObject gameObject)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x8AFD74", Offset = "0x8AFD74", VA = "0x8AFD74")]
	public static bool isTweening(RectTransform rect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x8AFDE4", Offset = "0x8AFDE4", VA = "0x8AFDE4")]
	public static bool isTweening(int uniqueId)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x8AFEE0", Offset = "0x8AFEE0", VA = "0x8AFEE0")]
	public static bool isTweening(LTRect ltRect)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x8AFFF4", Offset = "0x8AFFF4", VA = "0x8AFFF4")]
	public static void drawBezierPath(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float arrowSize = 0f, [Optional] Transform arrowTransform)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x8B0624", Offset = "0x8B0624", VA = "0x8B0624")]
	public static object logError(string error)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x8B06C4", Offset = "0x8B06C4", VA = "0x8B06C4")]
	public static LTDescr options(LTDescr seed)
	{
		return null;
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x8B0734", Offset = "0x8B0734", VA = "0x8B0734")]
	public static LTDescr options()
	{
		return null;
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x8B0BEC", Offset = "0x8B0BEC", VA = "0x8B0BEC")]
	private static LTDescr pushNewTween(GameObject gameObject, Vector3 to, float time, LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x8B0CF4", Offset = "0x8B0CF4", VA = "0x8B0CF4")]
	public static LTDescr play(RectTransform rectTransform, Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x8B0F00", Offset = "0x8B0F00", VA = "0x8B0F00")]
	public static LTDescr alpha(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x8B1084", Offset = "0x8B1084", VA = "0x8B1084")]
	public static LTSeq sequence(bool initSequence = true)
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x8B12AC", Offset = "0x8B12AC", VA = "0x8B12AC")]
	public static LTDescr alpha(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x8B1434", Offset = "0x8B1434", VA = "0x8B1434")]
	public static LTDescr textAlpha(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x8B1598", Offset = "0x8B1598", VA = "0x8B1598")]
	public static LTDescr alphaText(RectTransform rectTransform, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x8B163C", Offset = "0x8B163C", VA = "0x8B163C")]
	public static LTDescr alphaCanvas(CanvasGroup canvasGroup, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x8B17A0", Offset = "0x8B17A0", VA = "0x8B17A0")]
	public static LTDescr alphaVertex(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x8B18EC", Offset = "0x8B18EC", VA = "0x8B18EC")]
	public static LTDescr color(GameObject gameObject, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x8B1ABC", Offset = "0x8B1ABC", VA = "0x8B1ABC")]
	public static LTDescr textColor(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x8B1C4C", Offset = "0x8B1C4C", VA = "0x8B1C4C")]
	public static LTDescr colorText(RectTransform rectTransform, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x8B1D1C", Offset = "0x8B1D1C", VA = "0x8B1D1C")]
	public static LTDescr delayedCall(float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x8B1F44", Offset = "0x8B1F44", VA = "0x8B1F44")]
	public static LTDescr delayedCall(float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x8B204C", Offset = "0x8B204C", VA = "0x8B204C")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x8B2134", Offset = "0x8B2134", VA = "0x8B2134")]
	public static LTDescr delayedCall(GameObject gameObject, float delayTime, Action<object> callback)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x8B221C", Offset = "0x8B221C", VA = "0x8B221C")]
	public static LTDescr destroyAfter(LTRect rect, float delayTime)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x8B230C", Offset = "0x8B230C", VA = "0x8B230C")]
	public static LTDescr move(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x8B2468", Offset = "0x8B2468", VA = "0x8B2468")]
	public static LTDescr move(GameObject gameObject, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x8B2520", Offset = "0x8B2520", VA = "0x8B2520")]
	public static LTDescr move(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x8B2A88", Offset = "0x8B2A88", VA = "0x8B2A88")]
	public static LTDescr move(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x8B2B34", Offset = "0x8B2B34", VA = "0x8B2B34")]
	public static LTDescr move(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x8B2CA0", Offset = "0x8B2CA0", VA = "0x8B2CA0")]
	public static LTDescr moveSpline(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x8B2DCC", Offset = "0x8B2DCC", VA = "0x8B2DCC")]
	public static LTDescr moveSpline(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x8B2E78", Offset = "0x8B2E78", VA = "0x8B2E78")]
	public static LTDescr moveSplineLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x8B302C", Offset = "0x8B302C", VA = "0x8B302C")]
	public static LTDescr move(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x8B3198", Offset = "0x8B3198", VA = "0x8B3198")]
	public static LTDescr moveMargin(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x8B3304", Offset = "0x8B3304", VA = "0x8B3304")]
	public static LTDescr moveX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x8B344C", Offset = "0x8B344C", VA = "0x8B344C")]
	public static LTDescr moveY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x8B3598", Offset = "0x8B3598", VA = "0x8B3598")]
	public static LTDescr moveZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x8B36E4", Offset = "0x8B36E4", VA = "0x8B36E4")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x8B3840", Offset = "0x8B3840", VA = "0x8B3840")]
	public static LTDescr moveLocal(GameObject gameObject, Vector3[] to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x8B3A40", Offset = "0x8B3A40", VA = "0x8B3A40")]
	public static LTDescr moveLocalX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x8B3B8C", Offset = "0x8B3B8C", VA = "0x8B3B8C")]
	public static LTDescr moveLocalY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x8B3CD8", Offset = "0x8B3CD8", VA = "0x8B3CD8")]
	public static LTDescr moveLocalZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x8B3E24", Offset = "0x8B3E24", VA = "0x8B3E24")]
	public static LTDescr moveLocal(GameObject gameObject, LTBezierPath to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x8B3ED0", Offset = "0x8B3ED0", VA = "0x8B3ED0")]
	public static LTDescr moveLocal(GameObject gameObject, LTSpline to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x8B3F7C", Offset = "0x8B3F7C", VA = "0x8B3F7C")]
	public static LTDescr move(GameObject gameObject, Transform to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x8B413C", Offset = "0x8B413C", VA = "0x8B413C")]
	public static LTDescr rotate(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x8B4298", Offset = "0x8B4298", VA = "0x8B4298")]
	public static LTDescr rotate(LTRect ltRect, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x8B43F8", Offset = "0x8B43F8", VA = "0x8B43F8")]
	public static LTDescr rotateLocal(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x8B4554", Offset = "0x8B4554", VA = "0x8B4554")]
	public static LTDescr rotateX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x8B46A0", Offset = "0x8B46A0", VA = "0x8B46A0")]
	public static LTDescr rotateY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x8B47EC", Offset = "0x8B47EC", VA = "0x8B47EC")]
	public static LTDescr rotateZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x8B4938", Offset = "0x8B4938", VA = "0x8B4938")]
	public static LTDescr rotateAround(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x8B4AD4", Offset = "0x8B4AD4", VA = "0x8B4AD4")]
	public static LTDescr rotateAroundLocal(GameObject gameObject, Vector3 axis, float add, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x8B4C4C", Offset = "0x8B4C4C", VA = "0x8B4C4C")]
	public static LTDescr scale(GameObject gameObject, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x8B4DA8", Offset = "0x8B4DA8", VA = "0x8B4DA8")]
	public static LTDescr scale(LTRect ltRect, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x8B4F14", Offset = "0x8B4F14", VA = "0x8B4F14")]
	public static LTDescr scaleX(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x8B5060", Offset = "0x8B5060", VA = "0x8B5060")]
	public static LTDescr scaleY(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x8B51AC", Offset = "0x8B51AC", VA = "0x8B51AC")]
	public static LTDescr scaleZ(GameObject gameObject, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x8B52F8", Offset = "0x8B52F8", VA = "0x8B52F8")]
	public static LTDescr value(GameObject gameObject, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x8B5464", Offset = "0x8B5464", VA = "0x8B5464")]
	public static LTDescr value(float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x8B5510", Offset = "0x8B5510", VA = "0x8B5510")]
	public static LTDescr value(GameObject gameObject, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x8B5750", Offset = "0x8B5750", VA = "0x8B5750")]
	public static LTDescr value(GameObject gameObject, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x8B5818", Offset = "0x8B5818", VA = "0x8B5818")]
	public static LTDescr value(GameObject gameObject, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x8B5A4C", Offset = "0x8B5A4C", VA = "0x8B5A4C")]
	public static LTDescr value(GameObject gameObject, Action<float> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x8B5B74", Offset = "0x8B5B74", VA = "0x8B5B74")]
	public static LTDescr value(GameObject gameObject, Action<float, float> callOnUpdateRatio, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x8B5C9C", Offset = "0x8B5C9C", VA = "0x8B5C9C")]
	public static LTDescr value(GameObject gameObject, Action<Color> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x8B5DD8", Offset = "0x8B5DD8", VA = "0x8B5DD8")]
	public static LTDescr value(GameObject gameObject, Action<Color, object> callOnUpdate, Color from, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x8B5F14", Offset = "0x8B5F14", VA = "0x8B5F14")]
	public static LTDescr value(GameObject gameObject, Action<Vector2> callOnUpdate, Vector2 from, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x8B6044", Offset = "0x8B6044", VA = "0x8B6044")]
	public static LTDescr value(GameObject gameObject, Action<Vector3> callOnUpdate, Vector3 from, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x8B6180", Offset = "0x8B6180", VA = "0x8B6180")]
	public static LTDescr value(GameObject gameObject, Action<float, object> callOnUpdate, float from, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x8B62B8", Offset = "0x8B62B8", VA = "0x8B62B8")]
	public static LTDescr delayedSound(AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x8B6484", Offset = "0x8B6484", VA = "0x8B6484")]
	public static LTDescr delayedSound(GameObject gameObject, AudioClip audio, Vector3 pos, float volume)
	{
		return null;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x8B6578", Offset = "0x8B6578", VA = "0x8B6578")]
	public static LTDescr move(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x8B66F8", Offset = "0x8B66F8", VA = "0x8B66F8")]
	public static LTDescr moveX(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x8B6860", Offset = "0x8B6860", VA = "0x8B6860")]
	public static LTDescr moveY(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x8B69C8", Offset = "0x8B69C8", VA = "0x8B69C8")]
	public static LTDescr moveZ(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x8B6B30", Offset = "0x8B6B30", VA = "0x8B6B30")]
	public static LTDescr rotate(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x8B6CE0", Offset = "0x8B6CE0", VA = "0x8B6CE0")]
	public static LTDescr rotate(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x8B6DE0", Offset = "0x8B6DE0", VA = "0x8B6DE0")]
	public static LTDescr rotateAround(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x8B6EB4", Offset = "0x8B6EB4", VA = "0x8B6EB4")]
	public static LTDescr rotateAroundLocal(RectTransform rectTrans, Vector3 axis, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x8B7048", Offset = "0x8B7048", VA = "0x8B7048")]
	public static LTDescr scale(RectTransform rectTrans, Vector3 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x8B71C0", Offset = "0x8B71C0", VA = "0x8B71C0")]
	public static LTDescr size(RectTransform rectTrans, Vector2 to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x8B7334", Offset = "0x8B7334", VA = "0x8B7334")]
	public static LTDescr alpha(RectTransform rectTrans, float to, float time)
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x8B749C", Offset = "0x8B749C", VA = "0x8B749C")]
	public static LTDescr color(RectTransform rectTrans, Color to, float time)
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x8B7630", Offset = "0x8B7630", VA = "0x8B7630")]
	public static float tweenOnCurve(LTDescr tweenDescr, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x8B7678", Offset = "0x8B7678", VA = "0x8B7678")]
	public static Vector3 tweenOnCurveVector(LTDescr tweenDescr, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x8B7750", Offset = "0x8B7750", VA = "0x8B7750")]
	public static float easeOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x8B7768", Offset = "0x8B7768", VA = "0x8B7768")]
	public static float easeInQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x8B7778", Offset = "0x8B7778", VA = "0x8B7778")]
	public static float easeInOutQuadOpt(float start, float diff, float ratioPassed)
	{
		return default(float);
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x8B77C8", Offset = "0x8B77C8", VA = "0x8B77C8")]
	public static Vector3 easeInOutQuadOpt(Vector3 start, Vector3 diff, float ratioPassed)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x8B7848", Offset = "0x8B7848", VA = "0x8B7848")]
	public static float linear(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x8B786C", Offset = "0x8B786C", VA = "0x8B786C")]
	public static float clerp(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x8B78D0", Offset = "0x8B78D0", VA = "0x8B78D0")]
	public static float spring(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x8B7980", Offset = "0x8B7980", VA = "0x8B7980")]
	public static float easeInQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x8B7994", Offset = "0x8B7994", VA = "0x8B7994")]
	public static float easeOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x8B79B0", Offset = "0x8B79B0", VA = "0x8B79B0")]
	public static float easeInOutQuad(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x8B7A04", Offset = "0x8B7A04", VA = "0x8B7A04")]
	public static float easeInOutQuadOpt2(float start, float diffBy2, float val, float val2)
	{
		return default(float);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x8B7A3C", Offset = "0x8B7A3C", VA = "0x8B7A3C")]
	public static float easeInCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x8B7A54", Offset = "0x8B7A54", VA = "0x8B7A54")]
	public static float easeOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x8B7A7C", Offset = "0x8B7A7C", VA = "0x8B7A7C")]
	public static float easeInOutCubic(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x8B7AD4", Offset = "0x8B7AD4", VA = "0x8B7AD4")]
	public static float easeInQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x8B7AF0", Offset = "0x8B7AF0", VA = "0x8B7AF0")]
	public static float easeOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x8B7B18", Offset = "0x8B7B18", VA = "0x8B7B18")]
	public static float easeInOutQuart(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x8B7B74", Offset = "0x8B7B74", VA = "0x8B7B74")]
	public static float easeInQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x8B7B94", Offset = "0x8B7B94", VA = "0x8B7B94")]
	public static float easeOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x8B7BC4", Offset = "0x8B7BC4", VA = "0x8B7BC4")]
	public static float easeInOutQuint(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x8B7C2C", Offset = "0x8B7C2C", VA = "0x8B7C2C")]
	public static float easeInSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x8B7C64", Offset = "0x8B7C64", VA = "0x8B7C64")]
	public static float easeOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x8B7C98", Offset = "0x8B7C98", VA = "0x8B7C98")]
	public static float easeInOutSine(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x8B7CDC", Offset = "0x8B7CDC", VA = "0x8B7CDC")]
	public static float easeInExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x8B7D14", Offset = "0x8B7D14", VA = "0x8B7D14")]
	public static float easeOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x8B7D4C", Offset = "0x8B7D4C", VA = "0x8B7D4C")]
	public static float easeInOutExpo(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x8B7DBC", Offset = "0x8B7DBC", VA = "0x8B7DBC")]
	public static float easeInCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x8B7DE4", Offset = "0x8B7DE4", VA = "0x8B7DE4")]
	public static float easeOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x8B7E0C", Offset = "0x8B7E0C", VA = "0x8B7E0C")]
	public static float easeInOutCirc(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x8B7E60", Offset = "0x8B7E60", VA = "0x8B7E60")]
	public static float easeInBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x8B7EE8", Offset = "0x8B7EE8", VA = "0x8B7EE8")]
	public static float easeOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x8B7FB0", Offset = "0x8B7FB0", VA = "0x8B7FB0")]
	public static float easeInOutBounce(float start, float end, float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x8B8064", Offset = "0x8B8064", VA = "0x8B8064")]
	public static float easeInBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x8B8098", Offset = "0x8B8098", VA = "0x8B8098")]
	public static float easeOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x8B80D8", Offset = "0x8B80D8", VA = "0x8B80D8")]
	public static float easeInOutBack(float start, float end, float val, float overshoot = 1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x8B8170", Offset = "0x8B8170", VA = "0x8B8170")]
	public static float easeInElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x8B8248", Offset = "0x8B8248", VA = "0x8B8248")]
	public static float easeOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x8B8318", Offset = "0x8B8318", VA = "0x8B8318")]
	public static float easeInOutElastic(float start, float end, float val, float overshoot = 1f, float period = 0.3f)
	{
		return default(float);
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x8B8468", Offset = "0x8B8468", VA = "0x8B8468")]
	public static void addListener(int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x8B84D0", Offset = "0x8B84D0", VA = "0x8B84D0")]
	public static void addListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x8B88F0", Offset = "0x8B88F0", VA = "0x8B88F0")]
	public static bool removeListener(int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x8B8B48", Offset = "0x8B8B48", VA = "0x8B8B48")]
	public static bool removeListener(int eventId)
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x8B8958", Offset = "0x8B8958", VA = "0x8B8958")]
	public static bool removeListener(GameObject caller, int eventId, Action<LTEvent> callback)
	{
		return default(bool);
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x8B8BFC", Offset = "0x8B8BFC", VA = "0x8B8BFC")]
	public static void dispatchEvent(int eventId)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x8B8C54", Offset = "0x8B8C54", VA = "0x8B8C54")]
	public static void dispatchEvent(int eventId, object data)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x8B8E54", Offset = "0x8B8E54", VA = "0x8B8E54")]
	public LeanTween()
	{
	}
}
[Token(Token = "0x200001C")]
public class LTUtility
{
	[Token(Token = "0x6000131")]
	[Address(RVA = "0x8B93CC", Offset = "0x8B93CC", VA = "0x8B93CC")]
	public static Vector3[] reverse(Vector3[] arr)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x8B9468", Offset = "0x8B9468", VA = "0x8B9468")]
	public LTUtility()
	{
	}
}
[Token(Token = "0x200001D")]
public class LTBezier
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float length;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private Vector3 a;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3 aa;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 bb;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 cc;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float len;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float[] arcLengths;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x8B9470", Offset = "0x8B9470", VA = "0x8B9470")]
	public LTBezier(Vector3 a, Vector3 b, Vector3 c, Vector3 d, float precision)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x8B9744", Offset = "0x8B9744", VA = "0x8B9744")]
	private float map(float u)
	{
		return default(float);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x8B96EC", Offset = "0x8B96EC", VA = "0x8B96EC")]
	private Vector3 bezierPoint(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x8B9864", Offset = "0x8B9864", VA = "0x8B9864")]
	public Vector3 point(float t)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200001E")]
public class LTBezierPath
{
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3[] pts;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float length;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orientToPath;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private LTBezier[] beziers;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float[] lengthRatio;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int currentBezier;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int previousBezier;

	[Token(Token = "0x1700000F")]
	public float distance
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x8B9884", Offset = "0x8B9884", VA = "0x8B9884")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x8B987C", Offset = "0x8B987C", VA = "0x8B987C")]
	public LTBezierPath()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x8B2720", Offset = "0x8B2720", VA = "0x8B2720")]
	public LTBezierPath(Vector3[] pts_)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x8B274C", Offset = "0x8B274C", VA = "0x8B274C")]
	public void setPoints(Vector3[] pts_)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x8B988C", Offset = "0x8B988C", VA = "0x8B988C")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x8B9950", Offset = "0x8B9950", VA = "0x8B9950")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x8B9A04", Offset = "0x8B9A04", VA = "0x8B9A04")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x8B9AB8", Offset = "0x8B9AB8", VA = "0x8B9AB8")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x8B9B24", Offset = "0x8B9B24", VA = "0x8B9B24")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x8B9BC0", Offset = "0x8B9BC0", VA = "0x8B9BC0")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x8B9C2C", Offset = "0x8B9C2C", VA = "0x8B9C2C")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x8B9D14", Offset = "0x8B9D14", VA = "0x8B9D14")]
	public void gizmoDraw(float t = -1f)
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class LTSpline
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int DISTANCE_COUNT;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int SUBLINE_COUNT;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float distance;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool constantSpeed;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] pts;

	[NonSerialized]
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3[] ptsAdj;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ptsAdjLength;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool orientToPath;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool orientToPath2d;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int numSections;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int currPt;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x8B2D94", Offset = "0x8B2D94", VA = "0x8B2D94")]
	public LTSpline(Vector3[] pts)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x8BA1D4", Offset = "0x8BA1D4", VA = "0x8BA1D4")]
	public LTSpline(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x8B9DF4", Offset = "0x8B9DF4", VA = "0x8B9DF4")]
	private void init(Vector3[] pts, bool constantSpeed)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x8BA418", Offset = "0x8BA418", VA = "0x8BA418")]
	public Vector3 map(float u)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x8BA214", Offset = "0x8BA214", VA = "0x8BA214")]
	public Vector3 interp(float t)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x8BA514", Offset = "0x8BA514", VA = "0x8BA514")]
	public float ratioAtPoint(Vector3 pt)
	{
		return default(float);
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x8BA640", Offset = "0x8BA640", VA = "0x8BA640")]
	public Vector3 point(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x8BA658", Offset = "0x8BA658", VA = "0x8BA658")]
	public void place2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x8BA70C", Offset = "0x8BA70C", VA = "0x8BA70C")]
	public void placeLocal2d(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x8BA844", Offset = "0x8BA844", VA = "0x8BA844")]
	public void place(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x8BA8B0", Offset = "0x8BA8B0", VA = "0x8BA8B0")]
	public void place(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x8BA94C", Offset = "0x8BA94C", VA = "0x8BA94C")]
	public void placeLocal(Transform transform, float ratio)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x8BA9B8", Offset = "0x8BA9B8", VA = "0x8BA9B8")]
	public void placeLocal(Transform transform, float ratio, Vector3 worldUp)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x8BAA78", Offset = "0x8BAA78", VA = "0x8BAA78")]
	public void gizmoDraw(float t = -1f)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x8BAB2C", Offset = "0x8BAB2C", VA = "0x8BAB2C")]
	public void drawGizmo(Color color)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x8BAC78", Offset = "0x8BAC78", VA = "0x8BAC78")]
	public static void drawGizmo(Transform[] arr, Color color)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x8BAEA8", Offset = "0x8BAEA8", VA = "0x8BAEA8")]
	public static void drawLine(Transform[] arr, float width, Color color)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x8BAEB8", Offset = "0x8BAEB8", VA = "0x8BAEB8")]
	public void drawLinesGLLines(Material outlineMaterial, Color color, float width)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x8BB080", Offset = "0x8BB080", VA = "0x8BB080")]
	public Vector3[] generateVectors()
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000020")]
public class LTRect
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Rect _rect;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float alpha;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float rotation;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 pivot;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 margin;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rect relativeRect;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool rotateEnabled;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[HideInInspector]
	public bool rotateFinished;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool alphaEnabled;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string labelStr;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public LTGUI.Element_Type type;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GUIStyle style;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool useColor;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Color color;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool fontScaleToFit;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool useSimpleScale;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7E")]
	public bool sizeByHeight;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Texture texture;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private int _id;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public int counter;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool colorTouched;

	[Token(Token = "0x17000010")]
	public bool hasInitiliazed
	{
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x8BB934", Offset = "0x8BB934", VA = "0x8BB934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public int id
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x8AE1CC", Offset = "0x8AE1CC", VA = "0x8AE1CC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000012")]
	public float x
	{
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x8BB94C", Offset = "0x8BB94C", VA = "0x8BB94C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x8BB958", Offset = "0x8BB958", VA = "0x8BB958")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float y
	{
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x8BB964", Offset = "0x8BB964", VA = "0x8BB964")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x8BB970", Offset = "0x8BB970", VA = "0x8BB970")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float width
	{
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x8BB97C", Offset = "0x8BB97C", VA = "0x8BB97C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x8BB988", Offset = "0x8BB988", VA = "0x8BB988")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public float height
	{
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x8BB994", Offset = "0x8BB994", VA = "0x8BB994")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x8BB9A0", Offset = "0x8BB9A0", VA = "0x8BB9A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Rect rect
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x8BB9AC", Offset = "0x8BB9AC", VA = "0x8BB9AC")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x8BBB94", Offset = "0x8BBB94", VA = "0x8BBB94")]
		set
		{
		}
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x8BB2B4", Offset = "0x8BB2B4", VA = "0x8BB2B4")]
	public LTRect()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x8BB3C4", Offset = "0x8BB3C4", VA = "0x8BB3C4")]
	public LTRect(Rect rect)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x8BB45C", Offset = "0x8BB45C", VA = "0x8BB45C")]
	public LTRect(float x, float y, float width, float height)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x8BB520", Offset = "0x8BB520", VA = "0x8BB520")]
	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x8BB5EC", Offset = "0x8BB5EC", VA = "0x8BB5EC")]
	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x8BB944", Offset = "0x8BB944", VA = "0x8BB944")]
	public void setId(int id, int counter)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x8BB358", Offset = "0x8BB358", VA = "0x8BB358")]
	public void reset()
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x8BB6D0", Offset = "0x8BB6D0", VA = "0x8BB6D0")]
	public void resetForRotation()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x8BBBA0", Offset = "0x8BBBA0", VA = "0x8BBBA0")]
	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x8BBBA8", Offset = "0x8BBBA8", VA = "0x8BBBA8")]
	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x8BBBB4", Offset = "0x8BBBB4", VA = "0x8BBBB4")]
	public LTRect setColor(Color color)
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x8BBBC8", Offset = "0x8BBBC8", VA = "0x8BBBC8")]
	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x8BBBD0", Offset = "0x8BBBD0", VA = "0x8BBBD0")]
	public LTRect setLabel(string str)
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x8BBBD8", Offset = "0x8BBBD8", VA = "0x8BBBD8")]
	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x8BBBEC", Offset = "0x8BBBEC", VA = "0x8BBBEC")]
	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x8BBC54", Offset = "0x8BBC54", VA = "0x8BBC54")]
	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x8BBC60", Offset = "0x8BBC60", VA = "0x8BBC60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000021")]
public class LTEvent
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public object data;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x8B8E24", Offset = "0x8B8E24", VA = "0x8B8E24")]
	public LTEvent(int id, object data)
	{
	}
}
[Token(Token = "0x2000022")]
public class LTGUI
{
	[Token(Token = "0x2000023")]
	public enum Element_Type
	{
		[Token(Token = "0x400010A")]
		Texture,
		[Token(Token = "0x400010B")]
		Label
	}

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int RECT_LEVELS;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static int RECTS_PER_LEVEL;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int BUTTONS_MAX;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static LTRect[] levels;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static int[] levelDepths;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Rect[] buttons;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static int[] buttonLevels;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static int[] buttonLastFrame;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static LTRect r;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Color color;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static bool isGUIEnabled;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private static int global_counter;

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x8BBF00", Offset = "0x8BBF00", VA = "0x8BBF00")]
	public static void init()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x8BBFCC", Offset = "0x8BBFCC", VA = "0x8BBFCC")]
	public static void initRectCheck()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x8AD8D0", Offset = "0x8AD8D0", VA = "0x8AD8D0")]
	public static void reset()
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x8BC120", Offset = "0x8BC120", VA = "0x8BC120")]
	public static void update(int updateLevel)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x8BCA4C", Offset = "0x8BCA4C", VA = "0x8BCA4C")]
	public static bool checkOnScreen(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x8AE1D8", Offset = "0x8AE1D8", VA = "0x8AE1D8")]
	public static void destroy(int id)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x8BCB28", Offset = "0x8BCB28", VA = "0x8BCB28")]
	public static void destroyAll(int depth)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x8BCC04", Offset = "0x8BCC04", VA = "0x8BCC04")]
	public static LTRect label(Rect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x8BCCC8", Offset = "0x8BCCC8", VA = "0x8BCCC8")]
	public static LTRect label(LTRect rect, string label, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x8BD078", Offset = "0x8BD078", VA = "0x8BD078")]
	public static LTRect texture(Rect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x8BD13C", Offset = "0x8BD13C", VA = "0x8BD13C")]
	public static LTRect texture(LTRect rect, Texture texture, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x8BCD44", Offset = "0x8BCD44", VA = "0x8BCD44")]
	public static LTRect element(LTRect rect, int depth)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x8BD1B4", Offset = "0x8BD1B4", VA = "0x8BD1B4")]
	public static bool hasNoOverlap(Rect rect, int depth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x8BD474", Offset = "0x8BD474", VA = "0x8BD474")]
	public static bool pressedWithinRect(Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x8BD5F8", Offset = "0x8BD5F8", VA = "0x8BD5F8")]
	public static bool checkWithinRect(Vector2 vec2, Rect rect)
	{
		return default(bool);
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x8BD588", Offset = "0x8BD588", VA = "0x8BD588")]
	public static Vector2 firstTouch()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x8BD6C0", Offset = "0x8BD6C0", VA = "0x8BD6C0")]
	public LTGUI()
	{
	}
}
[Token(Token = "0x2000024")]
public class LTDescr
{
	[Token(Token = "0x2000025")]
	public delegate Vector3 EaseTypeDelegate();

	[Token(Token = "0x2000026")]
	public delegate void ActionMethodDelegate();

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool toggle;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool useEstimatedTime;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool useFrames;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
	public bool useManualTime;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool usesNormalDt;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool hasInitiliazed;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool hasExtraOnCompletes;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool hasPhysics;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool onCompleteOnRepeat;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool onCompleteOnStart;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool useRecursion;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float ratioPassed;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float passed;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float delay;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float time;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float lastVal;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private uint _id;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int loopCount;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public uint counter;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float direction;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float directionLast;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float overshoot;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float period;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float scale;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool destroyOnComplete;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform trans;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal Vector3 fromInternal;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	internal Vector3 toInternal;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal Vector3 diff;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	internal Vector3 diffDiv2;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TweenAction type;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private LeanTweenType easeType;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LeanTweenType loopType;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool hasUpdateCallback;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public EaseTypeDelegate easeMethod;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public SpriteRenderer spriteRen;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RectTransform rectTransform;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Text uiText;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Image uiImage;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public RawImage rawImage;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Sprite[] sprites;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public LTDescrOptional _optional;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float val;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float dt;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Vector3 newVect;

	[Token(Token = "0x17000017")]
	public Vector3 from
	{
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x8BD734", Offset = "0x8BD734", VA = "0x8BD734")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x8BD740", Offset = "0x8BD740", VA = "0x8BD740")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public Vector3 to
	{
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x8BD74C", Offset = "0x8BD74C", VA = "0x8BD74C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x8BD758", Offset = "0x8BD758", VA = "0x8BD758")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public ActionMethodDelegate easeInternal
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x8BD764", Offset = "0x8BD764", VA = "0x8BD764")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x8BD76C", Offset = "0x8BD76C", VA = "0x8BD76C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public ActionMethodDelegate initInternal
	{
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x8BD774", Offset = "0x8BD774", VA = "0x8BD774")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x8BD77C", Offset = "0x8BD77C", VA = "0x8BD77C")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public int uniqueId
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x8AE1BC", Offset = "0x8AE1BC", VA = "0x8AE1BC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001C")]
	public int id
	{
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x8ADCE4", Offset = "0x8ADCE4", VA = "0x8ADCE4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001D")]
	public LTDescrOptional optional
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x8BE050", Offset = "0x8BE050", VA = "0x8BE050")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x8BE058", Offset = "0x8BE058", VA = "0x8BE058")]
		set
		{
		}
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x8BD784", Offset = "0x8BD784", VA = "0x8BD784", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x8AD204", Offset = "0x8AD204", VA = "0x8AD204")]
	public LTDescr()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x8BDF8C", Offset = "0x8BDF8C", VA = "0x8BDF8C")]
	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x8B0A4C", Offset = "0x8B0A4C", VA = "0x8B0A4C")]
	public void reset()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x8B3390", Offset = "0x8B3390", VA = "0x8B3390")]
	public LTDescr setMoveX()
	{
		return null;
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x8B34D8", Offset = "0x8B34D8", VA = "0x8B34D8")]
	public LTDescr setMoveY()
	{
		return null;
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x8B3624", Offset = "0x8B3624", VA = "0x8B3624")]
	public LTDescr setMoveZ()
	{
		return null;
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x8B3ACC", Offset = "0x8B3ACC", VA = "0x8B3ACC")]
	public LTDescr setMoveLocalX()
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x8B3C18", Offset = "0x8B3C18", VA = "0x8B3C18")]
	public LTDescr setMoveLocalY()
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x8B3D64", Offset = "0x8B3D64", VA = "0x8B3D64")]
	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x8BE05C", Offset = "0x8BE05C", VA = "0x8BE05C")]
	private void initFromInternal()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x8B2660", Offset = "0x8B2660", VA = "0x8B2660")]
	public LTDescr setMoveCurved()
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x8B3980", Offset = "0x8B3980", VA = "0x8B3980")]
	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x8B2BE0", Offset = "0x8B2BE0", VA = "0x8B2BE0")]
	public LTDescr setMoveSpline()
	{
		return null;
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x8B2F6C", Offset = "0x8B2F6C", VA = "0x8B2F6C")]
	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x8B4FA0", Offset = "0x8B4FA0", VA = "0x8B4FA0")]
	public LTDescr setScaleX()
	{
		return null;
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x8B50EC", Offset = "0x8B50EC", VA = "0x8B50EC")]
	public LTDescr setScaleY()
	{
		return null;
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x8B5238", Offset = "0x8B5238", VA = "0x8B5238")]
	public LTDescr setScaleZ()
	{
		return null;
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x8B45E0", Offset = "0x8B45E0", VA = "0x8B45E0")]
	public LTDescr setRotateX()
	{
		return null;
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x8B472C", Offset = "0x8B472C", VA = "0x8B472C")]
	public LTDescr setRotateY()
	{
		return null;
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x8B4878", Offset = "0x8B4878", VA = "0x8B4878")]
	public LTDescr setRotateZ()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x8B4A14", Offset = "0x8B4A14", VA = "0x8B4A14")]
	public LTDescr setRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x8B4B8C", Offset = "0x8B4B8C", VA = "0x8B4B8C")]
	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x8B0FC4", Offset = "0x8B0FC4", VA = "0x8B0FC4")]
	public LTDescr setAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x8B14D8", Offset = "0x8B14D8", VA = "0x8B14D8")]
	public LTDescr setTextAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x8B182C", Offset = "0x8B182C", VA = "0x8B182C")]
	public LTDescr setAlphaVertex()
	{
		return null;
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x8B19DC", Offset = "0x8B19DC", VA = "0x8B19DC")]
	public LTDescr setColor()
	{
		return null;
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x8B5944", Offset = "0x8B5944", VA = "0x8B5944")]
	public LTDescr setCallbackColor()
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x8B1B8C", Offset = "0x8B1B8C", VA = "0x8B1B8C")]
	public LTDescr setTextColor()
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x8B73DC", Offset = "0x8B73DC", VA = "0x8B73DC")]
	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x8B16E0", Offset = "0x8B16E0", VA = "0x8B16E0")]
	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x8B7570", Offset = "0x8B7570", VA = "0x8B7570")]
	public LTDescr setCanvasColor()
	{
		return null;
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x8B67A0", Offset = "0x8B67A0", VA = "0x8B67A0")]
	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x8B6908", Offset = "0x8B6908", VA = "0x8B6908")]
	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x8B6A70", Offset = "0x8B6A70", VA = "0x8B6A70")]
	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x8BE064", Offset = "0x8BE064", VA = "0x8BE064")]
	private void initCanvasRotateAround()
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x8B6C20", Offset = "0x8B6C20", VA = "0x8B6C20")]
	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x8B6F88", Offset = "0x8B6F88", VA = "0x8B6F88")]
	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x8B0DF4", Offset = "0x8B0DF4", VA = "0x8B0DF4")]
	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x8B6630", Offset = "0x8B6630", VA = "0x8B6630")]
	public LTDescr setCanvasMove()
	{
		return null;
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x8B7100", Offset = "0x8B7100", VA = "0x8B7100")]
	public LTDescr setCanvasScale()
	{
		return null;
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x8B7274", Offset = "0x8B7274", VA = "0x8B7274")]
	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x8BE0A0", Offset = "0x8BE0A0", VA = "0x8BE0A0")]
	private void callback()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x8B1E00", Offset = "0x8B1E00", VA = "0x8B1E00")]
	public LTDescr setCallback()
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x8B5600", Offset = "0x8B5600", VA = "0x8B5600")]
	public LTDescr setValue3()
	{
		return null;
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x8B23A8", Offset = "0x8B23A8", VA = "0x8B23A8")]
	public LTDescr setMove()
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x8B3780", Offset = "0x8B3780", VA = "0x8B3780")]
	public LTDescr setMoveLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x8B407C", Offset = "0x8B407C", VA = "0x8B407C")]
	public LTDescr setMoveToTransform()
	{
		return null;
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x8B41D8", Offset = "0x8B41D8", VA = "0x8B41D8")]
	public LTDescr setRotate()
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x8B4494", Offset = "0x8B4494", VA = "0x8B4494")]
	public LTDescr setRotateLocal()
	{
		return null;
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x8B4CE8", Offset = "0x8B4CE8", VA = "0x8B4CE8")]
	public LTDescr setScale()
	{
		return null;
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x8B30D8", Offset = "0x8B30D8", VA = "0x8B30D8")]
	public LTDescr setGUIMove()
	{
		return null;
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x8B3244", Offset = "0x8B3244", VA = "0x8B3244")]
	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x8B4E54", Offset = "0x8B4E54", VA = "0x8B4E54")]
	public LTDescr setGUIScale()
	{
		return null;
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x8B1358", Offset = "0x8B1358", VA = "0x8B1358")]
	public LTDescr setGUIAlpha()
	{
		return null;
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x8B4338", Offset = "0x8B4338", VA = "0x8B4338")]
	public LTDescr setGUIRotate()
	{
		return null;
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x8B63A8", Offset = "0x8B63A8", VA = "0x8B63A8")]
	public LTDescr setDelayedSound()
	{
		return null;
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x8BE118", Offset = "0x8BE118", VA = "0x8BE118")]
	private void init()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x8BE25C", Offset = "0x8BE25C", VA = "0x8BE25C")]
	private void initSpeed()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x8BE350", Offset = "0x8BE350", VA = "0x8BE350")]
	public LTDescr updateNow()
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x8ADA18", Offset = "0x8ADA18", VA = "0x8ADA18")]
	public bool updateInternal()
	{
		return default(bool);
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x8AE004", Offset = "0x8AE004", VA = "0x8AE004")]
	public void callOnCompletes()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x8B5A04", Offset = "0x8B5A04", VA = "0x8B5A04")]
	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x8BE368", Offset = "0x8BE368", VA = "0x8BE368")]
	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x8BE7E0", Offset = "0x8BE7E0", VA = "0x8BE7E0")]
	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x8BEBC4", Offset = "0x8BEBC4", VA = "0x8BEBC4")]
	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x8BF004", Offset = "0x8BF004", VA = "0x8BF004")]
	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x8BF3DC", Offset = "0x8BF3DC", VA = "0x8BF3DC")]
	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x8BF7DC", Offset = "0x8BF7DC", VA = "0x8BF7DC")]
	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x8BFC14", Offset = "0x8BFC14", VA = "0x8BFC14")]
	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x8BFFCC", Offset = "0x8BFFCC", VA = "0x8BFFCC")]
	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x8C034C", Offset = "0x8C034C", VA = "0x8C034C")]
	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x8C0708", Offset = "0x8C0708", VA = "0x8C0708")]
	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x8AF60C", Offset = "0x8AF60C", VA = "0x8AF60C")]
	public LTDescr pause()
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x8AF914", Offset = "0x8AF914", VA = "0x8AF914")]
	public LTDescr resume()
	{
		return null;
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x8B49F4", Offset = "0x8B49F4", VA = "0x8B49F4")]
	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x8C0764", Offset = "0x8C0764", VA = "0x8C0764")]
	public LTDescr setDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x8C076C", Offset = "0x8C076C", VA = "0x8C076C")]
	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x8C08A8", Offset = "0x8C08A8", VA = "0x8C08A8")]
	public LTDescr setEaseLinear()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x8C1AB8", Offset = "0x8C1AB8", VA = "0x8C1AB8")]
	public LTDescr setEaseSpring()
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x8C09B8", Offset = "0x8C09B8", VA = "0x8C09B8")]
	public LTDescr setEaseInQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x8C0930", Offset = "0x8C0930", VA = "0x8C0930")]
	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x8C0A40", Offset = "0x8C0A40", VA = "0x8C0A40")]
	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x8C0AC8", Offset = "0x8C0AC8", VA = "0x8C0AC8")]
	public LTDescr setEaseInCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x8C0B50", Offset = "0x8C0B50", VA = "0x8C0B50")]
	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x8C0BD8", Offset = "0x8C0BD8", VA = "0x8C0BD8")]
	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x8C0C60", Offset = "0x8C0C60", VA = "0x8C0C60")]
	public LTDescr setEaseInQuart()
	{
		return null;
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x8C0CE8", Offset = "0x8C0CE8", VA = "0x8C0CE8")]
	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x8C0D70", Offset = "0x8C0D70", VA = "0x8C0D70")]
	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x8C0DF8", Offset = "0x8C0DF8", VA = "0x8C0DF8")]
	public LTDescr setEaseInQuint()
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x8C0E80", Offset = "0x8C0E80", VA = "0x8C0E80")]
	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x8C0F08", Offset = "0x8C0F08", VA = "0x8C0F08")]
	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x8C0F90", Offset = "0x8C0F90", VA = "0x8C0F90")]
	public LTDescr setEaseInSine()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x8C1018", Offset = "0x8C1018", VA = "0x8C1018")]
	public LTDescr setEaseOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x8C10A0", Offset = "0x8C10A0", VA = "0x8C10A0")]
	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x8C1128", Offset = "0x8C1128", VA = "0x8C1128")]
	public LTDescr setEaseInExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x8C11B0", Offset = "0x8C11B0", VA = "0x8C11B0")]
	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x8C1238", Offset = "0x8C1238", VA = "0x8C1238")]
	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x8C12C0", Offset = "0x8C12C0", VA = "0x8C12C0")]
	public LTDescr setEaseInCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x8C1348", Offset = "0x8C1348", VA = "0x8C1348")]
	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x8C13D0", Offset = "0x8C13D0", VA = "0x8C13D0")]
	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x8C1458", Offset = "0x8C1458", VA = "0x8C1458")]
	public LTDescr setEaseInBounce()
	{
		return null;
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x8C14E0", Offset = "0x8C14E0", VA = "0x8C14E0")]
	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x8C1568", Offset = "0x8C1568", VA = "0x8C1568")]
	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x8C15F0", Offset = "0x8C15F0", VA = "0x8C15F0")]
	public LTDescr setEaseInBack()
	{
		return null;
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x8C1678", Offset = "0x8C1678", VA = "0x8C1678")]
	public LTDescr setEaseOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x8C1700", Offset = "0x8C1700", VA = "0x8C1700")]
	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x8C1788", Offset = "0x8C1788", VA = "0x8C1788")]
	public LTDescr setEaseInElastic()
	{
		return null;
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x8C1810", Offset = "0x8C1810", VA = "0x8C1810")]
	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x8C1898", Offset = "0x8C1898", VA = "0x8C1898")]
	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x8C1920", Offset = "0x8C1920", VA = "0x8C1920")]
	public LTDescr setEasePunch()
	{
		return null;
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x8C19EC", Offset = "0x8C19EC", VA = "0x8C19EC")]
	public LTDescr setEaseShake()
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x8C1B40", Offset = "0x8C1B40", VA = "0x8C1B40")]
	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x8C1C00", Offset = "0x8C1C00", VA = "0x8C1C00")]
	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x8C1CA4", Offset = "0x8C1CA4", VA = "0x8C1CA4")]
	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x8C1D1C", Offset = "0x8C1D1C", VA = "0x8C1D1C")]
	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x8C1DA0", Offset = "0x8C1DA0", VA = "0x8C1DA0")]
	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x8C1E18", Offset = "0x8C1E18", VA = "0x8C1E18")]
	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x8C1F14", Offset = "0x8C1F14", VA = "0x8C1F14")]
	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x8C1F90", Offset = "0x8C1F90", VA = "0x8C1F90")]
	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x8C201C", Offset = "0x8C201C", VA = "0x8C201C")]
	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x8C20C8", Offset = "0x8C20C8", VA = "0x8C20C8")]
	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x8C2148", Offset = "0x8C2148", VA = "0x8C2148")]
	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x8C21D8", Offset = "0x8C21D8", VA = "0x8C21D8")]
	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0x8C22AC", Offset = "0x8C22AC", VA = "0x8C22AC")]
	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000210")]
	[Address(RVA = "0x8C2330", Offset = "0x8C2330", VA = "0x8C2330")]
	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0x8C23C4", Offset = "0x8C23C4", VA = "0x8C23C4")]
	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0x8C2480", Offset = "0x8C2480", VA = "0x8C2480")]
	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x8C2540", Offset = "0x8C2540", VA = "0x8C2540")]
	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x8C25F4", Offset = "0x8C25F4", VA = "0x8C25F4")]
	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x8C2684", Offset = "0x8C2684", VA = "0x8C2684")]
	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x8C270C", Offset = "0x8C270C", VA = "0x8C270C")]
	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x8C2794", Offset = "0x8C2794", VA = "0x8C2794")]
	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x8C2860", Offset = "0x8C2860", VA = "0x8C2860")]
	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x8C28F0", Offset = "0x8C28F0", VA = "0x8C28F0")]
	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x8C297C", Offset = "0x8C297C", VA = "0x8C297C")]
	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x8C2A4C", Offset = "0x8C2A4C", VA = "0x8C2A4C")]
	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x8C2B68", Offset = "0x8C2B68", VA = "0x8C2B68")]
	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x8C2CB8", Offset = "0x8C2CB8", VA = "0x8C2CB8")]
	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x8C2E80", Offset = "0x8C2E80", VA = "0x8C2E80")]
	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x8C2F28", Offset = "0x8C2F28", VA = "0x8C2F28")]
	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x8C2FD0", Offset = "0x8C2FD0", VA = "0x8C2FD0")]
	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x8C30D4", Offset = "0x8C30D4", VA = "0x8C30D4")]
	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x8C31C8", Offset = "0x8C31C8", VA = "0x8C31C8")]
	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x8C32BC", Offset = "0x8C32BC", VA = "0x8C32BC")]
	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x8C33B0", Offset = "0x8C33B0", VA = "0x8C33B0")]
	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x8C33B8", Offset = "0x8C33B8", VA = "0x8C33B8")]
	public LTDescr setPeriod(float period)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x8C33C0", Offset = "0x8C33C0", VA = "0x8C33C0")]
	public LTDescr setScale(float scale)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x8C33C8", Offset = "0x8C33C8", VA = "0x8C33C8")]
	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x8B5720", Offset = "0x8B5720", VA = "0x8B5720")]
	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x8B4060", Offset = "0x8B4060", VA = "0x8B4060")]
	public LTDescr setTo(Transform to)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x8B53A0", Offset = "0x8B53A0", VA = "0x8B53A0")]
	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x8C3460", Offset = "0x8C3460", VA = "0x8C3460")]
	public LTDescr setFrom(float from)
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x8C346C", Offset = "0x8C346C", VA = "0x8C346C")]
	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x8B5A40", Offset = "0x8B5A40", VA = "0x8B5A40")]
	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x8B0B78", Offset = "0x8B0B78", VA = "0x8B0B78")]
	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x8C3478", Offset = "0x8C3478", VA = "0x8C3478")]
	public LTDescr setPassed(float passed)
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x8C3480", Offset = "0x8C3480", VA = "0x8C3480")]
	public LTDescr setTime(float time)
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x8C349C", Offset = "0x8C349C", VA = "0x8C349C")]
	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x8B0EBC", Offset = "0x8B0EBC", VA = "0x8B0EBC")]
	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x8C34D0", Offset = "0x8C34D0", VA = "0x8C34D0")]
	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0x8C34D8", Offset = "0x8C34D8", VA = "0x8C34D8")]
	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0x8C34E8", Offset = "0x8C34E8", VA = "0x8C34E8")]
	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0x8C34F8", Offset = "0x8C34F8", VA = "0x8C34F8")]
	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	[Token(Token = "0x6000237")]
	[Address(RVA = "0x8C3508", Offset = "0x8C3508", VA = "0x8C3508")]
	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0x8C3518", Offset = "0x8C3518", VA = "0x8C3518")]
	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	[Token(Token = "0x6000239")]
	[Address(RVA = "0x8C3528", Offset = "0x8C3528", VA = "0x8C3528")]
	public LTDescr setLoopOnce()
	{
		return null;
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0x8C3534", Offset = "0x8C3534", VA = "0x8C3534")]
	public LTDescr setLoopClamp()
	{
		return null;
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x8C3554", Offset = "0x8C3554", VA = "0x8C3554")]
	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x8C355C", Offset = "0x8C355C", VA = "0x8C355C")]
	public LTDescr setLoopPingPong()
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x8C357C", Offset = "0x8C357C", VA = "0x8C357C")]
	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x8B1F20", Offset = "0x8B1F20", VA = "0x8B1F20")]
	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x8B2028", Offset = "0x8B2028", VA = "0x8B2028")]
	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x8C35A8", Offset = "0x8C35A8", VA = "0x8C35A8")]
	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x8C35D4", Offset = "0x8C35D4", VA = "0x8C35D4")]
	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x8B5B50", Offset = "0x8B5B50", VA = "0x8B5B50")]
	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x8B5C78", Offset = "0x8B5C78", VA = "0x8B5C78")]
	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x8C35F8", Offset = "0x8C35F8", VA = "0x8C35F8")]
	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x8B6020", Offset = "0x8B6020", VA = "0x8B6020")]
	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x8B615C", Offset = "0x8B615C", VA = "0x8B615C")]
	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x8B5DB4", Offset = "0x8B5DB4", VA = "0x8B5DB4")]
	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x8B5EF0", Offset = "0x8B5EF0", VA = "0x8B5EF0")]
	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x8C361C", Offset = "0x8C361C", VA = "0x8C361C")]
	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x8C3640", Offset = "0x8C3640", VA = "0x8C3640")]
	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x8B628C", Offset = "0x8B628C", VA = "0x8B628C")]
	public LTDescr setOnUpdate(Action<float, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x8C3664", Offset = "0x8C3664", VA = "0x8C3664")]
	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x8C3690", Offset = "0x8C3690", VA = "0x8C3690")]
	public LTDescr setOnUpdate(Action<Vector2> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x8C36BC", Offset = "0x8C36BC", VA = "0x8C36BC")]
	public LTDescr setOnUpdate(Action<Vector3> onUpdate, [Optional] object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x8C36E8", Offset = "0x8C36E8", VA = "0x8C36E8")]
	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x8C3704", Offset = "0x8C3704", VA = "0x8C3704")]
	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x8C37C4", Offset = "0x8C37C4", VA = "0x8C37C4")]
	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x8B1418", Offset = "0x8B1418", VA = "0x8B1418")]
	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x8C381C", Offset = "0x8C381C", VA = "0x8C381C")]
	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x8C38B4", Offset = "0x8C38B4", VA = "0x8C38B4")]
	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x8B1A9C", Offset = "0x8B1A9C", VA = "0x8B1A9C")]
	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x8B2300", Offset = "0x8B2300", VA = "0x8B2300")]
	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x8B6468", Offset = "0x8B6468", VA = "0x8B6468")]
	public LTDescr setAudio(object audio)
	{
		return null;
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x8C34C4", Offset = "0x8C34C4", VA = "0x8C34C4")]
	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x8C38D0", Offset = "0x8C38D0", VA = "0x8C38D0")]
	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x8B66F0", Offset = "0x8B66F0", VA = "0x8B66F0")]
	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x8B0EB4", Offset = "0x8B0EB4", VA = "0x8B0EB4")]
	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x8C38DC", Offset = "0x8C38DC", VA = "0x8C38DC")]
	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x8C3904", Offset = "0x8C3904", VA = "0x8C3904")]
	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x8C3920", Offset = "0x8C3920", VA = "0x8C3920")]
	public LTDescr setDirection(float direction)
	{
		return null;
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x8C3AE8", Offset = "0x8C3AE8", VA = "0x8C3AE8")]
	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
[Token(Token = "0x2000028")]
public class LTDescrOptional
{
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int initFrameCount;

	[Token(Token = "0x1700001E")]
	public Transform toTrans
	{
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x8C80C8", Offset = "0x8C80C8", VA = "0x8C80C8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x8C80D0", Offset = "0x8C80D0", VA = "0x8C80D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public Vector3 point
	{
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x8C80D8", Offset = "0x8C80D8", VA = "0x8C80D8")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x8C80E4", Offset = "0x8C80E4", VA = "0x8C80E4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Vector3 axis
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x8C80F0", Offset = "0x8C80F0", VA = "0x8C80F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x8C80FC", Offset = "0x8C80FC", VA = "0x8C80FC")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public float lastVal
	{
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x8C8108", Offset = "0x8C8108", VA = "0x8C8108")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x8C8110", Offset = "0x8C8110", VA = "0x8C8110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Quaternion origRotation
	{
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x8C8118", Offset = "0x8C8118", VA = "0x8C8118")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x8C8124", Offset = "0x8C8124", VA = "0x8C8124")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public LTBezierPath path
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x8C8130", Offset = "0x8C8130", VA = "0x8C8130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x8C8138", Offset = "0x8C8138", VA = "0x8C8138")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public LTSpline spline
	{
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x8C8140", Offset = "0x8C8140", VA = "0x8C8140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x8C8148", Offset = "0x8C8148", VA = "0x8C8148")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public LTRect ltRect
	{
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x8C8150", Offset = "0x8C8150", VA = "0x8C8150")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x8C8158", Offset = "0x8C8158", VA = "0x8C8158")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public Action<float> onUpdateFloat
	{
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x8C8160", Offset = "0x8C8160", VA = "0x8C8160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x8C8168", Offset = "0x8C8168", VA = "0x8C8168")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public Action<float, float> onUpdateFloatRatio
	{
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x8C8170", Offset = "0x8C8170", VA = "0x8C8170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x8C8178", Offset = "0x8C8178", VA = "0x8C8178")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public Action<float, object> onUpdateFloatObject
	{
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x8C8180", Offset = "0x8C8180", VA = "0x8C8180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x8C8188", Offset = "0x8C8188", VA = "0x8C8188")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public Action<Vector2> onUpdateVector2
	{
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x8C8190", Offset = "0x8C8190", VA = "0x8C8190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x8C8198", Offset = "0x8C8198", VA = "0x8C8198")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public Action<Vector3> onUpdateVector3
	{
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x8C81A0", Offset = "0x8C81A0", VA = "0x8C81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x8C81A8", Offset = "0x8C81A8", VA = "0x8C81A8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public Action<Vector3, object> onUpdateVector3Object
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x8C81B0", Offset = "0x8C81B0", VA = "0x8C81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x8C81B8", Offset = "0x8C81B8", VA = "0x8C81B8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public Action<Color> onUpdateColor
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x8C81C0", Offset = "0x8C81C0", VA = "0x8C81C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x8C81C8", Offset = "0x8C81C8", VA = "0x8C81C8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public Action<Color, object> onUpdateColorObject
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x8C81D0", Offset = "0x8C81D0", VA = "0x8C81D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x8C81D8", Offset = "0x8C81D8", VA = "0x8C81D8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public Action onComplete
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x8C81E0", Offset = "0x8C81E0", VA = "0x8C81E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x8C81E8", Offset = "0x8C81E8", VA = "0x8C81E8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public Action<object> onCompleteObject
	{
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x8C81F0", Offset = "0x8C81F0", VA = "0x8C81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x8C81F8", Offset = "0x8C81F8", VA = "0x8C81F8")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public object onCompleteParam
	{
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x8C8200", Offset = "0x8C8200", VA = "0x8C8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x8C8208", Offset = "0x8C8208", VA = "0x8C8208")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public object onUpdateParam
	{
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x8C8210", Offset = "0x8C8210", VA = "0x8C8210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x8C8218", Offset = "0x8C8218", VA = "0x8C8218")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Action onStart
	{
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x8C8220", Offset = "0x8C8220", VA = "0x8C8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x8C8228", Offset = "0x8C8228", VA = "0x8C8228")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x8C8230", Offset = "0x8C8230", VA = "0x8C8230")]
	public void reset()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x8C82AC", Offset = "0x8C82AC", VA = "0x8C82AC")]
	public void callOnUpdate(float val, float ratioPassed)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x8C8400", Offset = "0x8C8400", VA = "0x8C8400")]
	public LTDescrOptional()
	{
	}
}
[Token(Token = "0x2000029")]
public class LTSeq
{
	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LTSeq previous;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LTSeq current;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LTDescr tween;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float totalDelay;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float timeScale;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int debugIter;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public uint counter;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool toggle;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private uint _id;

	[Token(Token = "0x17000033")]
	public int id
	{
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x8C8408", Offset = "0x8C8408", VA = "0x8C8408")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x8C8418", Offset = "0x8C8418", VA = "0x8C8418")]
	public void reset()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x8C8428", Offset = "0x8C8428", VA = "0x8C8428")]
	public void init(uint id, uint global_counter)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x8C8440", Offset = "0x8C8440", VA = "0x8C8440")]
	private LTSeq addOn()
	{
		return null;
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x8C85A8", Offset = "0x8C85A8", VA = "0x8C85A8")]
	private float addPreviousDelays()
	{
		return default(float);
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x8C85E4", Offset = "0x8C85E4", VA = "0x8C85E4")]
	public LTSeq append(float delay)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x8C8608", Offset = "0x8C8608", VA = "0x8C8608")]
	public LTSeq append(Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x8C86D8", Offset = "0x8C86D8", VA = "0x8C86D8")]
	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x8C876C", Offset = "0x8C876C", VA = "0x8C876C")]
	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x8C87F0", Offset = "0x8C87F0", VA = "0x8C87F0")]
	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x8C8684", Offset = "0x8C8684", VA = "0x8C8684")]
	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x8C8894", Offset = "0x8C8894", VA = "0x8C8894")]
	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x8C88D8", Offset = "0x8C88D8", VA = "0x8C88D8")]
	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x8C88F8", Offset = "0x8C88F8", VA = "0x8C88F8")]
	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x8C898C", Offset = "0x8C898C", VA = "0x8C898C")]
	public LTSeq reverse()
	{
		return null;
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x8C8990", Offset = "0x8C8990", VA = "0x8C8990")]
	public LTSeq()
	{
	}
}
[Token(Token = "0x200002A")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Token(Token = "0x200002B")]
	private class DataCallback : AndroidJavaProxy
	{
		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Action<short[]> callback;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr javaBuf;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int cntFrame;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int cntShort;

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x8C9320", Offset = "0x8C9320", VA = "0x8C9320")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x8C93B8", Offset = "0x8C93B8", VA = "0x8C93B8")]
		public void OnData()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x8C9410", Offset = "0x8C9410", VA = "0x8C9410")]
		public void OnStop()
		{
		}
	}

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AndroidJavaObject audioIn;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private IntPtr javaBuf;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DataCallback callback;

	[Token(Token = "0x17000034")]
	public int Channels
	{
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x8C93B0", Offset = "0x8C93B0", VA = "0x8C93B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000035")]
	public int SamplingRate
	{
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x8C93A8", Offset = "0x8C93A8", VA = "0x8C93A8", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x8C8998", Offset = "0x8C8998", VA = "0x8C8998")]
	public AndroidAudioInAEC()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x8C89A0", Offset = "0x8C89A0", VA = "0x8C89A0", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x8C9260", Offset = "0x8C9260", VA = "0x8C9260", Slot = "7")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x200002C")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip audioClip;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int readPos;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float startTime;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	private bool playing;

	[Token(Token = "0x17000036")]
	public bool Loop
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x8C941C", Offset = "0x8C941C", VA = "0x8C941C")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x8C9424", Offset = "0x8C9424", VA = "0x8C9424")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public int SamplingRate
	{
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x8C9574", Offset = "0x8C9574", VA = "0x8C9574", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000038")]
	public int Channels
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x8C9590", Offset = "0x8C9590", VA = "0x8C9590", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x8C9430", Offset = "0x8C9430", VA = "0x8C9430")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x8C946C", Offset = "0x8C946C", VA = "0x8C946C", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x8C95AC", Offset = "0x8C95AC", VA = "0x8C95AC", Slot = "5")]
	public void Dispose()
	{
	}
}
[Token(Token = "0x200002D")]
public class AudioOutCapture : MonoBehaviour
{
	[Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x8C95B0", Offset = "0x8C95B0", VA = "0x8C95B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x8C9660", Offset = "0x8C9660", VA = "0x8C9660")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x8C9710", Offset = "0x8C9710", VA = "0x8C9710")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x8C972C", Offset = "0x8C972C", VA = "0x8C972C")]
	public AudioOutCapture()
	{
	}
}
[Token(Token = "0x200002E")]
public class AudioStreamPlayer : IAudioOut
{
	[Token(Token = "0x400016C")]
	private const int maxPlayLagMs = 100;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private int maxPlayLagSamples;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private int playDelaySamples;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int bufferSamples;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int channels;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int frameSize;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int frameSamples;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int streamSamplePos;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int streamSamplePosAvg;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioSource source;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string logPrefix;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool debugInfo;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int sourceTimeSamplesPrev;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int playLoopCount;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Queue<float[]> frameQueue;

	[Token(Token = "0x400017C")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private PrimitiveArrayPool<float> framePool;

	[Token(Token = "0x17000039")]
	public int CurrentBufferLag
	{
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x8C9734", Offset = "0x8C9734", VA = "0x8C9734", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x8C973C", Offset = "0x8C973C", VA = "0x8C973C")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public AudioSource AudioSource
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x8C9744", Offset = "0x8C9744", VA = "0x8C9744")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003B")]
	private int playSamplePos
	{
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x8C9854", Offset = "0x8C9854", VA = "0x8C9854")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x8C98F8", Offset = "0x8C98F8", VA = "0x8C98F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public bool IsPlaying
	{
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x8C99C4", Offset = "0x8C99C4", VA = "0x8C99C4", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x8C974C", Offset = "0x8C974C", VA = "0x8C974C")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x8C99E0", Offset = "0x8C99E0", VA = "0x8C99E0", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x8C9B50", Offset = "0x8C9B50", VA = "0x8C9B50", Slot = "8")]
	public void Service()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x8CA214", Offset = "0x8CA214", VA = "0x8CA214", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x8CA4BC", Offset = "0x8CA4BC", VA = "0x8CA4BC", Slot = "6")]
	public void Stop()
	{
	}
}
[Token(Token = "0x200002F")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Token(Token = "0x6000321")]
	[Address(RVA = "0x8CA4F0", Offset = "0x8CA4F0", VA = "0x8CA4F0")]
	private void PhotonVoiceCreated()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x8CA4F4", Offset = "0x8CA4F4", VA = "0x8CA4F4")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Token(Token = "0x2000030")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private AudioClip mic;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string device;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int micPrevPos;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int micLoopCnt;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int readAbsPos;

	[Token(Token = "0x1700003D")]
	public int SamplingRate
	{
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x8CA70C", Offset = "0x8CA70C", VA = "0x8CA70C", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003E")]
	public int Channels
	{
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x8CA728", Offset = "0x8CA728", VA = "0x8CA728", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x8CA4FC", Offset = "0x8CA4FC", VA = "0x8CA4FC")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x8CA744", Offset = "0x8CA744", VA = "0x8CA744", Slot = "5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x8CA750", Offset = "0x8CA750", VA = "0x8CA750", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000031")]
public class SpeexDSP : MonoBehaviour
{
	[Token(Token = "0x2000032")]
	private class Logger : ExitGames.Client.Photon.Voice.ILogger
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x8CBAF4", Offset = "0x8CBAF4", VA = "0x8CBAF4", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x8CBB5C", Offset = "0x8CBB5C", VA = "0x8CBB5C", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x8CBBC4", Offset = "0x8CBBC4", VA = "0x8CBBC4", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x8CBC2C", Offset = "0x8CBC2C", VA = "0x8CBC2C", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x8CB658", Offset = "0x8CB658", VA = "0x8CB658")]
		public Logger()
		{
		}
	}

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Platforms")]
	public bool Windows;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool Mac;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Header("Effects")]
	[Tooltip("Acoustic Echo Cancellation")]
	public bool AEC;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int AECPlaybackDelayMs;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int AECFilterLengthMs;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool Denoise;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[Tooltip("Automatic Gain Control")]
	public bool AGC;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(1f, 32768f)]
	public float AGCLevel;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int AECPlayDelayCurrentFrames;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool AECLatencyDetect;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SpeexProcessor proc;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private bool prevAEC;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int aecLDState;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float aecLDStart;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource aecLDPing;

	[Token(Token = "0x1700003F")]
	public SpeexProcessor Processor
	{
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x8CA828", Offset = "0x8CA828", VA = "0x8CA828")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public bool Active
	{
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x8CA830", Offset = "0x8CA830", VA = "0x8CA830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x8CA838", Offset = "0x8CA838", VA = "0x8CA838")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x8CA844", Offset = "0x8CA844", VA = "0x8CA844")]
	public void ResetAEC()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x8CA908", Offset = "0x8CA908", VA = "0x8CA908")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x8CA94C", Offset = "0x8CA94C", VA = "0x8CA94C")]
	private void Start()
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x8CA950", Offset = "0x8CA950", VA = "0x8CA950")]
	private void UpdateProcProps()
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x8CAAFC", Offset = "0x8CAAFC", VA = "0x8CAAFC")]
	private void setOutputListener(bool set)
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x8CB07C", Offset = "0x8CB07C", VA = "0x8CB07C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x8CAE2C", Offset = "0x8CAE2C", VA = "0x8CAE2C")]
	private void InitAECLatencyDetect()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x8CB214", Offset = "0x8CB214", VA = "0x8CB214")]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x8CB964", Offset = "0x8CB964", VA = "0x8CB964")]
	private void PhotonVoiceRemoved()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x8CB99C", Offset = "0x8CB99C", VA = "0x8CB99C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x8CB968", Offset = "0x8CB968", VA = "0x8CB968")]
	private void reset()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x8CBAC0", Offset = "0x8CBAC0", VA = "0x8CBAC0")]
	public SpeexDSP()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000034")]
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x8CBD38", Offset = "0x8CBD38", VA = "0x8CBD38")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x8CBD40", Offset = "0x8CBD40", VA = "0x8CBD40")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x8CBD48", Offset = "0x8CBD48", VA = "0x8CBD48")]
		public RelatingAttribute()
		{
		}
	}
}
namespace POpusCodec
{
	[Token(Token = "0x2000037")]
	public class OpusDecoder : IDisposable
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x4000197")]
		private const int MaxFrameSize = 5760;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _previousPacketInvalid;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _channelCount;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] EmptyBufferFloat;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly short[] EmptyBufferShort;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Bandwidth? _previousPacketBandwidth;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] bufferFloat;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private short[] bufferShort;

		[Token(Token = "0x17000041")]
		public string Version
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x8CBD50", Offset = "0x8CBD50", VA = "0x8CBD50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x8CBD58", Offset = "0x8CBD58", VA = "0x8CBD58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x8CBD60", Offset = "0x8CBD60", VA = "0x8CBD60")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x8CC234", Offset = "0x8CC234", VA = "0x8CC234")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x8CC518", Offset = "0x8CC518", VA = "0x8CC518")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x8CC77C", Offset = "0x8CC77C", VA = "0x8CC77C", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class OpusEncoder : IDisposable
	{
		[Token(Token = "0x400019F")]
		public const int BitrateMax = -1;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IntPtr _handle;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _version;

		[Token(Token = "0x40001A2")]
		private const int RecommendedMaxPacketSize = 4000;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _frameSizePerChannel;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private SamplingRate _inputSamplingRate;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Channels _inputChannels;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly byte[] writePacket;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Delay _encoderDelay;

		[Token(Token = "0x17000043")]
		public SamplingRate InputSamplingRate
		{
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x8CC8E4", Offset = "0x8CC8E4", VA = "0x8CC8E4")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Token(Token = "0x17000044")]
		public Channels InputChannels
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x8CC8EC", Offset = "0x8CC8EC", VA = "0x8CC8EC")]
			get
			{
				return default(Channels);
			}
		}

		[Token(Token = "0x17000045")]
		public string Version
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x8CC8F4", Offset = "0x8CC8F4", VA = "0x8CC8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public Delay EncoderDelay
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x8CCA10", Offset = "0x8CCA10", VA = "0x8CCA10")]
			get
			{
				return default(Delay);
			}
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x8CC8FC", Offset = "0x8CC8FC", VA = "0x8CC8FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000047")]
		public int FrameSizePerChannel
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x8CCA18", Offset = "0x8CCA18", VA = "0x8CCA18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public int Bitrate
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x8CCA20", Offset = "0x8CCA20", VA = "0x8CCA20")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x8CCB00", Offset = "0x8CCB00", VA = "0x8CCB00")]
			set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public Bandwidth MaxBandwidth
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x8CCBD8", Offset = "0x8CCBD8", VA = "0x8CCBD8")]
			get
			{
				return default(Bandwidth);
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x8CCBE4", Offset = "0x8CCBE4", VA = "0x8CCBE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public Complexity Complexity
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x8CCBF4", Offset = "0x8CCBF4", VA = "0x8CCBF4")]
			get
			{
				return default(Complexity);
			}
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x8CCC00", Offset = "0x8CCC00", VA = "0x8CCC00")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int ExpectedPacketLossPercentage
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x8CCC10", Offset = "0x8CCC10", VA = "0x8CCC10")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x8CCC1C", Offset = "0x8CCC1C", VA = "0x8CCC1C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public SignalHint SignalHint
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x8CCC2C", Offset = "0x8CCC2C", VA = "0x8CCC2C")]
			get
			{
				return default(SignalHint);
			}
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x8CCC38", Offset = "0x8CCC38", VA = "0x8CCC38")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public ForceChannels ForceChannels
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x8CCC48", Offset = "0x8CCC48", VA = "0x8CCC48")]
			get
			{
				return default(ForceChannels);
			}
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x8CCC54", Offset = "0x8CCC54", VA = "0x8CCC54")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool UseInbandFEC
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x8CCC64", Offset = "0x8CCC64", VA = "0x8CCC64")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x8CCC84", Offset = "0x8CCC84", VA = "0x8CCC84")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public bool UseUnconstrainedVBR
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x8CCC94", Offset = "0x8CCC94", VA = "0x8CCC94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x8CCCB4", Offset = "0x8CCCB4", VA = "0x8CCCB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool DtxEnabled
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x8CCCC8", Offset = "0x8CCCC8", VA = "0x8CCCC8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x8CCCE8", Offset = "0x8CCCE8", VA = "0x8CCCE8")]
			set
			{
			}
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x8CCCF8", Offset = "0x8CCCF8", VA = "0x8CCCF8")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x8CD2B8", Offset = "0x8CD2B8", VA = "0x8CD2B8")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x8CD474", Offset = "0x8CD474", VA = "0x8CD474")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x8CD630", Offset = "0x8CD630", VA = "0x8CD630", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class OpusException : Exception
	{
		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private OpusStatusCode _statusCode;

		[Token(Token = "0x17000051")]
		public OpusStatusCode StatusCode
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x8CD7A0", Offset = "0x8CD7A0", VA = "0x8CD7A0")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x8CC1C0", Offset = "0x8CC1C0", VA = "0x8CC1C0")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Token(Token = "0x200003A")]
	internal class Wrapper
	{
		[Token(Token = "0x40001AA")]
		private const string lib_name = "opus_egpv";

		[PreserveSig]
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x8CD7A8", Offset = "0x8CD7A8", VA = "0x8CD7A8")]
		private static extern int opus_encoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x8CD824", Offset = "0x8CD824", VA = "0x8CD824")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x8CC15C", Offset = "0x8CC15C", VA = "0x8CC15C")]
		public static extern IntPtr opus_get_version_string();

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x8CD8C0", Offset = "0x8CD8C0", VA = "0x8CD8C0")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x8CD97C", Offset = "0x8CD97C", VA = "0x8CD97C")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x8CDA38", Offset = "0x8CDA38", VA = "0x8CDA38")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x8CDACC", Offset = "0x8CDACC", VA = "0x8CDACC")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x8CDB5C", Offset = "0x8CDB5C", VA = "0x8CDB5C")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x8CDBF0", Offset = "0x8CDBF0", VA = "0x8CDBF0")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x8CDC80", Offset = "0x8CDC80", VA = "0x8CDC80")]
		private static extern int opus_decoder_get_size(Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x8CDCFC", Offset = "0x8CDCFC", VA = "0x8CDCFC")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x8CDD90", Offset = "0x8CDD90", VA = "0x8CDD90")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x8CDE54", Offset = "0x8CDE54", VA = "0x8CDE54")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x8CC494", Offset = "0x8CC494", VA = "0x8CC494")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x8CDF18", Offset = "0x8CDF18", VA = "0x8CDF18")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x8CDF9C", Offset = "0x8CDF9C", VA = "0x8CDF9C")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x8CD160", Offset = "0x8CD160", VA = "0x8CD160")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x8CD534", Offset = "0x8CD534", VA = "0x8CD534")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x8CD378", Offset = "0x8CD378", VA = "0x8CD378")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x8CD6A4", Offset = "0x8CD6A4", VA = "0x8CD6A4")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x8CCA2C", Offset = "0x8CCA2C", VA = "0x8CCA2C")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x8CCB10", Offset = "0x8CCB10", VA = "0x8CCB10")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x8CE094", Offset = "0x8CE094", VA = "0x8CE094")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x8CE168", Offset = "0x8CE168", VA = "0x8CE168")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x8CC00C", Offset = "0x8CC00C", VA = "0x8CC00C")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x8CC7F0", Offset = "0x8CC7F0", VA = "0x8CC7F0")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x8CC648", Offset = "0x8CC648", VA = "0x8CC648")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x8CC360", Offset = "0x8CC360", VA = "0x8CC360")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x8CE018", Offset = "0x8CE018", VA = "0x8CE018")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x8CE230", Offset = "0x8CE230", VA = "0x8CE230")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[Token(Token = "0x200003B")]
	public enum Bandwidth
	{
		[Token(Token = "0x40001AC")]
		Narrowband = 1101,
		[Token(Token = "0x40001AD")]
		Mediumband,
		[Token(Token = "0x40001AE")]
		Wideband,
		[Token(Token = "0x40001AF")]
		SuperWideband,
		[Token(Token = "0x40001B0")]
		Fullband
	}
	[Token(Token = "0x200003C")]
	public enum Channels
	{
		[Token(Token = "0x40001B2")]
		Mono = 1,
		[Token(Token = "0x40001B3")]
		Stereo
	}
	[Token(Token = "0x200003D")]
	public enum Complexity
	{
		[Token(Token = "0x40001B5")]
		Complexity0,
		[Token(Token = "0x40001B6")]
		Complexity1,
		[Token(Token = "0x40001B7")]
		Complexity2,
		[Token(Token = "0x40001B8")]
		Complexity3,
		[Token(Token = "0x40001B9")]
		Complexity4,
		[Token(Token = "0x40001BA")]
		Complexity5,
		[Token(Token = "0x40001BB")]
		Complexity6,
		[Token(Token = "0x40001BC")]
		Complexity7,
		[Token(Token = "0x40001BD")]
		Complexity8,
		[Token(Token = "0x40001BE")]
		Complexity9,
		[Token(Token = "0x40001BF")]
		Complexity10
	}
	[Token(Token = "0x200003E")]
	public enum Delay
	{
		[Token(Token = "0x40001C1")]
		Delay2dot5ms = 5,
		[Token(Token = "0x40001C2")]
		Delay5ms = 10,
		[Token(Token = "0x40001C3")]
		Delay10ms = 20,
		[Token(Token = "0x40001C4")]
		Delay20ms = 40,
		[Token(Token = "0x40001C5")]
		Delay40ms = 80,
		[Token(Token = "0x40001C6")]
		Delay60ms = 120
	}
	[Token(Token = "0x200003F")]
	public enum ForceChannels
	{
		[Token(Token = "0x40001C8")]
		NoForce = -1000,
		[Token(Token = "0x40001C9")]
		Mono = 1,
		[Token(Token = "0x40001CA")]
		Stereo = 2
	}
	[Token(Token = "0x2000040")]
	public enum OpusApplicationType
	{
		[Token(Token = "0x40001CC")]
		Voip = 2048,
		[Token(Token = "0x40001CD")]
		Audio = 2049,
		[Token(Token = "0x40001CE")]
		RestrictedLowDelay = 2051
	}
	[Token(Token = "0x2000041")]
	internal enum OpusCtlGetRequest
	{
		[Token(Token = "0x40001D0")]
		Application = 4001,
		[Token(Token = "0x40001D1")]
		Bitrate = 4003,
		[Token(Token = "0x40001D2")]
		MaxBandwidth = 4005,
		[Token(Token = "0x40001D3")]
		VBR = 4007,
		[Token(Token = "0x40001D4")]
		Bandwidth = 4009,
		[Token(Token = "0x40001D5")]
		Complexity = 4011,
		[Token(Token = "0x40001D6")]
		InbandFec = 4013,
		[Token(Token = "0x40001D7")]
		PacketLossPercentage = 4015,
		[Token(Token = "0x40001D8")]
		Dtx = 4017,
		[Token(Token = "0x40001D9")]
		VBRConstraint = 4021,
		[Token(Token = "0x40001DA")]
		ForceChannels = 4023,
		[Token(Token = "0x40001DB")]
		Signal = 4025,
		[Token(Token = "0x40001DC")]
		LookAhead = 4027,
		[Token(Token = "0x40001DD")]
		SampleRate = 4029,
		[Token(Token = "0x40001DE")]
		FinalRange = 4031,
		[Token(Token = "0x40001DF")]
		Pitch = 4033,
		[Token(Token = "0x40001E0")]
		Gain = 4035,
		[Token(Token = "0x40001E1")]
		LsbDepth = 4037,
		[Token(Token = "0x40001E2")]
		LastPacketDurationRequest = 4039
	}
	[Token(Token = "0x2000042")]
	internal enum OpusCtlSetRequest
	{
		[Token(Token = "0x40001E4")]
		Application = 4000,
		[Token(Token = "0x40001E5")]
		Bitrate = 4002,
		[Token(Token = "0x40001E6")]
		MaxBandwidth = 4004,
		[Token(Token = "0x40001E7")]
		VBR = 4006,
		[Token(Token = "0x40001E8")]
		Bandwidth = 4008,
		[Token(Token = "0x40001E9")]
		Complexity = 4010,
		[Token(Token = "0x40001EA")]
		InbandFec = 4012,
		[Token(Token = "0x40001EB")]
		PacketLossPercentage = 4014,
		[Token(Token = "0x40001EC")]
		Dtx = 4016,
		[Token(Token = "0x40001ED")]
		VBRConstraint = 4020,
		[Token(Token = "0x40001EE")]
		ForceChannels = 4022,
		[Token(Token = "0x40001EF")]
		Signal = 4024,
		[Token(Token = "0x40001F0")]
		Gain = 4034,
		[Token(Token = "0x40001F1")]
		LsbDepth = 4036
	}
	[Token(Token = "0x2000043")]
	public enum OpusStatusCode
	{
		[Token(Token = "0x40001F3")]
		OK = 0,
		[Token(Token = "0x40001F4")]
		BadArguments = -1,
		[Token(Token = "0x40001F5")]
		BufferTooSmall = -2,
		[Token(Token = "0x40001F6")]
		InternalError = -3,
		[Token(Token = "0x40001F7")]
		InvalidPacket = -4,
		[Token(Token = "0x40001F8")]
		Unimplemented = -5,
		[Token(Token = "0x40001F9")]
		InvalidState = -6,
		[Token(Token = "0x40001FA")]
		AllocFail = -7
	}
	[Token(Token = "0x2000044")]
	public enum SamplingRate
	{
		[Token(Token = "0x40001FC")]
		Sampling08000 = 8000,
		[Token(Token = "0x40001FD")]
		Sampling12000 = 12000,
		[Token(Token = "0x40001FE")]
		Sampling16000 = 16000,
		[Token(Token = "0x40001FF")]
		Sampling24000 = 24000,
		[Token(Token = "0x4000200")]
		Sampling48000 = 48000
	}
	[Token(Token = "0x2000045")]
	public enum SignalHint
	{
		[Token(Token = "0x4000202")]
		Auto = -1000,
		[Token(Token = "0x4000203")]
		Voice = 3001,
		[Token(Token = "0x4000204")]
		Music = 3002
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Token(Token = "0x2000046")]
	public static class AudioUtil
	{
		[Token(Token = "0x2000047")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected T[] frameResampled;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int channels;

			[Token(Token = "0x600038D")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Token(Token = "0x600038E")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x600038F")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000048")]
		public interface ILevelMeter
		{
			[Token(Token = "0x17000052")]
			float CurrentAvgAmp
			{
				[Token(Token = "0x6000390")]
				get;
			}

			[Token(Token = "0x17000053")]
			float CurrentPeakAmp
			{
				[Token(Token = "0x6000391")]
				get;
			}

			[Token(Token = "0x17000054")]
			float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000392")]
				get;
			}

			[Token(Token = "0x6000393")]
			void ResetAccumAvgPeakAmp();
		}

		[Token(Token = "0x2000049")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Token(Token = "0x17000055")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x6000394")]
				[Address(RVA = "0x8CE6F4", Offset = "0x8CE6F4", VA = "0x8CE6F4", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000056")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x6000395")]
				[Address(RVA = "0x8CE6FC", Offset = "0x8CE6FC", VA = "0x8CE6FC", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000057")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x8CE704", Offset = "0x8CE704", VA = "0x8CE704", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x8CE70C", Offset = "0x8CE70C", VA = "0x8CE70C", Slot = "7")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x8CE710", Offset = "0x8CE710", VA = "0x8CE710")]
			public LevelMetterDummy()
			{
			}
		}

		[Token(Token = "0x200004A")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampSum;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float ampPeak;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int bufferSize;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float[] buffer;

			[Token(Token = "0x400020B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int prevValuesPtr;

			[Token(Token = "0x400020C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected float accumAvgPeakAmpSum;

			[Token(Token = "0x400020D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int accumAvgPeakAmpCount;

			[Token(Token = "0x17000058")]
			public float CurrentAvgAmp
			{
				[Token(Token = "0x600039A")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000059")]
			public float CurrentPeakAmp
			{
				[Token(Token = "0x600039B")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600039C")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Token(Token = "0x1700005A")]
			public float AccumAvgPeakAmp
			{
				[Token(Token = "0x600039D")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000399")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x600039E")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Token(Token = "0x600039F")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x60003A0")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200004B")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x8CE718", Offset = "0x8CE718", VA = "0x8CE718")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x8CE778", Offset = "0x8CE778", VA = "0x8CE778", Slot = "10")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x200004C")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x8CE890", Offset = "0x8CE890", VA = "0x8CE890")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x8CE8F0", Offset = "0x8CE8F0", VA = "0x8CE8F0", Slot = "10")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Token(Token = "0x200004D")]
		public interface IVoiceDetector
		{
			[Token(Token = "0x1700005B")]
			bool On
			{
				[Token(Token = "0x60003A5")]
				get;
				[Token(Token = "0x60003A6")]
				set;
			}

			[Token(Token = "0x1700005C")]
			float Threshold
			{
				[Token(Token = "0x60003A7")]
				get;
				[Token(Token = "0x60003A8")]
				set;
			}

			[Token(Token = "0x1700005D")]
			bool Detected
			{
				[Token(Token = "0x60003A9")]
				get;
			}

			[Token(Token = "0x1700005E")]
			DateTime DetectedTime
			{
				[Token(Token = "0x60003AA")]
				get;
			}

			[Token(Token = "0x1700005F")]
			int ActivityDelayMs
			{
				[Token(Token = "0x60003AD")]
				get;
				[Token(Token = "0x60003AE")]
				set;
			}

			[Token(Token = "0x14000002")]
			event Action OnDetected;
		}

		[Token(Token = "0x200004E")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IVoiceDetector voiceDetector;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ILevelMeter levelMeter;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int valuesPerSec;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int voiceDetectorCalibrateCount;

			[Token(Token = "0x17000060")]
			public bool VoiceDetectorCalibrating
			{
				[Token(Token = "0x60003AF")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60003B0")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Token(Token = "0x60003B1")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Token(Token = "0x60003B2")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x60003B3")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x200004F")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Token(Token = "0x17000061")]
			public bool On
			{
				[Token(Token = "0x60003B4")]
				[Address(RVA = "0x8CEA0C", Offset = "0x8CEA0C", VA = "0x8CEA0C", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003B5")]
				[Address(RVA = "0x8CEA14", Offset = "0x8CEA14", VA = "0x8CEA14", Slot = "5")]
				set
				{
				}
			}

			[Token(Token = "0x17000062")]
			public float Threshold
			{
				[Token(Token = "0x60003B6")]
				[Address(RVA = "0x8CEA18", Offset = "0x8CEA18", VA = "0x8CEA18", Slot = "6")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003B7")]
				[Address(RVA = "0x8CEA20", Offset = "0x8CEA20", VA = "0x8CEA20", Slot = "7")]
				set
				{
				}
			}

			[Token(Token = "0x17000063")]
			public bool Detected
			{
				[Token(Token = "0x60003B8")]
				[Address(RVA = "0x8CEA24", Offset = "0x8CEA24", VA = "0x8CEA24", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000064")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x60003B9")]
				[Address(RVA = "0x8CEA2C", Offset = "0x8CEA2C", VA = "0x8CEA2C", Slot = "12")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003BA")]
				[Address(RVA = "0x8CEA34", Offset = "0x8CEA34", VA = "0x8CEA34", Slot = "13")]
				set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x60003BB")]
				[Address(RVA = "0x8CEA38", Offset = "0x8CEA38", VA = "0x8CEA38", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x60003BC")]
				[Address(RVA = "0x8CEA40", Offset = "0x8CEA40", VA = "0x8CEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x14000003")]
			public event Action OnDetected
			{
				[Token(Token = "0x60003BD")]
				[Address(RVA = "0x8CEA48", Offset = "0x8CEA48", VA = "0x8CEA48", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60003BE")]
				[Address(RVA = "0x8CEAE4", Offset = "0x8CEAE4", VA = "0x8CEAE4", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x8CEB80", Offset = "0x8CEB80", VA = "0x8CEB80")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Token(Token = "0x2000050")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool detected;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelay;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int autoSilenceCounter;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int valuesCountPerSec;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected int activityDelayValuesCount;

			[Token(Token = "0x17000066")]
			public bool On
			{
				[Token(Token = "0x60003C0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003C1")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000067")]
			public float Threshold
			{
				[Token(Token = "0x60003C2")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60003C3")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Token(Token = "0x17000068")]
			public bool Detected
			{
				[Token(Token = "0x60003C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60003C5")]
				protected set
				{
				}
			}

			[Token(Token = "0x17000069")]
			public DateTime DetectedTime
			{
				[Token(Token = "0x60003C6")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Token(Token = "0x60003C7")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006A")]
			public int ActivityDelayMs
			{
				[Token(Token = "0x60003C8")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60003C9")]
				set
				{
				}
			}

			[Token(Token = "0x14000004")]
			public event Action OnDetected
			{
				[Token(Token = "0x60003CA")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x60003CB")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Token(Token = "0x60003CC")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60003CD")]
			public abstract T[] Process(T[] buf);

			[Token(Token = "0x60003CE")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x2000051")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x8CEB88", Offset = "0x8CEB88", VA = "0x8CEB88")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x8CEC04", Offset = "0x8CEC04", VA = "0x8CEC04", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000052")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x8CED20", Offset = "0x8CED20", VA = "0x8CED20")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x8CED9C", Offset = "0x8CED9C", VA = "0x8CED9C", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Token(Token = "0x2000053")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private VoiceDetectorCalibration<T> c;

			[Token(Token = "0x1700006B")]
			public ILevelMeter Level
			{
				[Token(Token = "0x60003D3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700006C")]
			public IVoiceDetector Detector
			{
				[Token(Token = "0x60003D5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60003D6")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x60003D7")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Token(Token = "0x60003D8")]
			public void Calibrate(int durationMs)
			{
			}

			[Token(Token = "0x60003D9")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Token(Token = "0x60003DA")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x6000386")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x8CE238", Offset = "0x8CE238", VA = "0x8CE238")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x8CE400", Offset = "0x8CE400", VA = "0x8CE400")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x8CE604", Offset = "0x8CE604", VA = "0x8CE604")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x8CE684", Offset = "0x8CE684", VA = "0x8CE684")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Token(Token = "0x600038B")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Token(Token = "0x600038C")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Token(Token = "0x2000054")]
	public interface IAudioOut
	{
		[Token(Token = "0x1700006D")]
		bool IsPlaying
		{
			[Token(Token = "0x60003DB")]
			get;
		}

		[Token(Token = "0x1700006E")]
		int CurrentBufferLag
		{
			[Token(Token = "0x60003E0")]
			get;
		}

		[Token(Token = "0x60003DC")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Token(Token = "0x60003DD")]
		void Stop();

		[Token(Token = "0x60003DE")]
		void OnAudioFrame(float[] frame);

		[Token(Token = "0x60003DF")]
		void Service();
	}
	[Token(Token = "0x2000055")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int capacity;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected TInfo info;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TType[] freeObj;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int pos;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected string name;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool inited;

		[Token(Token = "0x1700006F")]
		internal string LogPrefix
		{
			[Token(Token = "0x60003E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public TInfo Info
		{
			[Token(Token = "0x60003E8")]
			get
			{
				return (TInfo)null;
			}
		}

		[Token(Token = "0x60003E1")]
		protected abstract TType createObject(TInfo info);

		[Token(Token = "0x60003E2")]
		protected abstract void destroyObject(TType obj);

		[Token(Token = "0x60003E3")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Token(Token = "0x60003E5")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Token(Token = "0x60003E6")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Token(Token = "0x60003E7")]
		public void Init(TInfo info)
		{
		}

		[Token(Token = "0x60003E9")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Token(Token = "0x60003EA")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Token(Token = "0x60003EB")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Token(Token = "0x60003EE")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Token(Token = "0x60003EF")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Token(Token = "0x60003F0")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Token(Token = "0x60003F2")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000057")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Token(Token = "0x2000058")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Factory factory;

		[Token(Token = "0x60003F3")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Token(Token = "0x60003F4")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x60003F5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Token(Token = "0x60003F6")]
		protected override void destroyObject(T obj)
		{
		}

		[Token(Token = "0x60003F7")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000059")]
	public class OpusCodec
	{
		[Token(Token = "0x200005A")]
		public enum FrameDuration
		{
			[Token(Token = "0x4000229")]
			Frame2dot5ms = 2500,
			[Token(Token = "0x400022A")]
			Frame5ms = 5000,
			[Token(Token = "0x400022B")]
			Frame10ms = 10000,
			[Token(Token = "0x400022C")]
			Frame20ms = 20000,
			[Token(Token = "0x400022D")]
			Frame40ms = 40000,
			[Token(Token = "0x400022E")]
			Frame60ms = 60000
		}

		[Token(Token = "0x200005B")]
		public static class EncoderFactory
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x8CEEC4", Offset = "0x8CEEC4", VA = "0x8CEEC4")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Token(Token = "0x200005C")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Token(Token = "0x400022F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected OpusEncoder encoder;

			[Token(Token = "0x4000230")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			protected bool disposed;

			[Token(Token = "0x60003FE")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Token(Token = "0x60003FF")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000400")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Token(Token = "0x200005D")]
		public class EncoderFloat : Encoder<float>
		{
			[Token(Token = "0x4000231")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x8CF0BC", Offset = "0x8CF0BC", VA = "0x8CF0BC")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x8CF2E4", Offset = "0x8CF2E4", VA = "0x8CF2E4", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x200005E")]
		public class EncoderShort : Encoder<short>
		{
			[Token(Token = "0x4000232")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x8CF138", Offset = "0x8CF138", VA = "0x8CF138")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x8CF4C8", Offset = "0x8CF4C8", VA = "0x8CF4C8", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Token(Token = "0x200005F")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Token(Token = "0x4000233")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private OpusDecoder decoder;

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x8CF6AC", Offset = "0x8CF6AC", VA = "0x8CF6AC", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x8CF724", Offset = "0x8CF724", VA = "0x8CF724", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x8CF764", Offset = "0x8CF764", VA = "0x8CF764", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x8CF77C", Offset = "0x8CF77C", VA = "0x8CF77C", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x8CF794", Offset = "0x8CF794", VA = "0x8CF794", Slot = "8")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x8CF7AC", Offset = "0x8CF7AC", VA = "0x8CF7AC")]
			public Decoder()
			{
			}
		}

		[Token(Token = "0x2000060")]
		public class Util
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x8CF7B4", Offset = "0x8CF7B4", VA = "0x8CF7B4")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x8CFB84", Offset = "0x8CFB84", VA = "0x8CFB84")]
			public Util()
			{
			}
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x8CEEBC", Offset = "0x8CEEBC", VA = "0x8CEEBC")]
		public OpusCodec()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Token(Token = "0x2000062")]
		public struct AECLatencyResultType
		{
			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int LatencyMs;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int LatencyDelayedMs;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public bool PlayDetected;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			public bool PlayDelayedDetected;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			public bool RecDetected;
		}

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _AEC;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int _AECPlaybackDelayMs;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool _AECLatencyDetect;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int frameSamples;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int samplingRate;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int channels;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int playDelayFrames;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int playDelayMaxFrames;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr stEcho;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IntPtr st;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool disposed;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private short[] resultBuf;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Queue<short[]> playBufQueue;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Framer<float> playFramer;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int playSamplingRate;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int playChannels;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ILogger logger;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Func<long> clockMs;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private long detectTimePlay;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private long detectTimePlayDelayed;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private long detectTimeRec;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private int frameCntRec;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int frameCntPlay;

		[Token(Token = "0x17000071")]
		public bool AEC
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0x8CFB8C", Offset = "0x8CFB8C", VA = "0x8CFB8C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x8CACF4", Offset = "0x8CACF4", VA = "0x8CACF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public int AECFilterLengthMs
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0x8CFB94", Offset = "0x8CFB94", VA = "0x8CFB94")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x8CFB9C", Offset = "0x8CFB9C", VA = "0x8CFB9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public int AECPlaybackDelayMs
		{
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x8CFBA4", Offset = "0x8CFBA4", VA = "0x8CFBA4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000414")]
			[Address(RVA = "0x8CAD64", Offset = "0x8CAD64", VA = "0x8CAD64")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public int AECurrentPlayDelayFrames
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0x8CADE4", Offset = "0x8CADE4", VA = "0x8CADE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public bool AECLatencyDetect
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0x8CFC7C", Offset = "0x8CFC7C", VA = "0x8CFC7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x8CB058", Offset = "0x8CB058", VA = "0x8CB058")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public AECLatencyResultType AECLatencyResult
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x8CFFB4", Offset = "0x8CFFB4", VA = "0x8CFFB4")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Token(Token = "0x17000077")]
		public bool Denoise
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x8D0264", Offset = "0x8D0264", VA = "0x8D0264")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x8CAD7C", Offset = "0x8CAD7C", VA = "0x8CAD7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public bool AGC
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x8D02D8", Offset = "0x8D02D8", VA = "0x8D02D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x8CADA0", Offset = "0x8CADA0", VA = "0x8CADA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public float AGCLevel
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x8D0304", Offset = "0x8D0304", VA = "0x8D0304")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x8CADC4", Offset = "0x8CADC4", VA = "0x8CADC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x8CA854", Offset = "0x8CA854", VA = "0x8CA854")]
		public void ResetAEC()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x8CB184", Offset = "0x8CB184", VA = "0x8CB184")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x8D02B8", Offset = "0x8D02B8", VA = "0x8D02B8")]
		private void set(int param, bool val)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x8D0348", Offset = "0x8D0348", VA = "0x8D0348")]
		private void set(int param, float val)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x8D0290", Offset = "0x8D0290", VA = "0x8D0290")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x8D0328", Offset = "0x8D0328", VA = "0x8D0328")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x8CB660", Offset = "0x8CB660", VA = "0x8CB660")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x8CFC84", Offset = "0x8CFC84", VA = "0x8CFC84")]
		private void InitLatencyDetect()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x8D0610", Offset = "0x8D0610", VA = "0x8D0610")]
		public void InitAEC()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x8CFBAC", Offset = "0x8CFBAC", VA = "0x8CFBAC")]
		private void InitPlayDelay(int ms)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x8D1038", Offset = "0x8D1038", VA = "0x8D1038", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x8D14E8", Offset = "0x8D14E8", VA = "0x8D14E8")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x8CB180", Offset = "0x8CB180", VA = "0x8CB180")]
		public void PrintInfo()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x8D01D8", Offset = "0x8D01D8", VA = "0x8D01D8")]
		private void DestroyEchoState()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x8CB9A0", Offset = "0x8CB9A0", VA = "0x8CB9A0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class SpeexLib
	{
		[Token(Token = "0x4000257")]
		private const string lib_name = "libspeexdsp";

		[Token(Token = "0x4000258")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Token(Token = "0x4000259")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Token(Token = "0x400025A")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Token(Token = "0x400025B")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Token(Token = "0x400025C")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Token(Token = "0x400025D")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Token(Token = "0x400025E")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Token(Token = "0x400025F")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Token(Token = "0x4000260")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Token(Token = "0x4000261")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Token(Token = "0x4000262")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Token(Token = "0x4000263")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Token(Token = "0x4000264")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Token(Token = "0x4000265")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Token(Token = "0x4000266")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Token(Token = "0x4000267")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Token(Token = "0x4000268")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Token(Token = "0x4000269")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Token(Token = "0x400026A")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Token(Token = "0x400026B")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Token(Token = "0x400026C")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Token(Token = "0x400026D")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Token(Token = "0x400026E")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Token(Token = "0x400026F")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Token(Token = "0x4000270")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Token(Token = "0x4000271")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Token(Token = "0x4000272")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Token(Token = "0x4000273")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Token(Token = "0x4000274")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Token(Token = "0x4000275")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Token(Token = "0x4000276")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Token(Token = "0x4000277")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Token(Token = "0x4000278")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Token(Token = "0x4000279")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Token(Token = "0x400027A")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Token(Token = "0x400027B")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Token(Token = "0x400027C")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Token(Token = "0x400027D")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Token(Token = "0x400027E")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Token(Token = "0x400027F")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Token(Token = "0x4000280")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Token(Token = "0x4000281")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Token(Token = "0x4000282")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Token(Token = "0x4000283")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Token(Token = "0x4000284")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Token(Token = "0x4000285")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[PreserveSig]
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x8D058C", Offset = "0x8D058C", VA = "0x8D058C")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[PreserveSig]
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x8D1EDC", Offset = "0x8D1EDC", VA = "0x8D1EDC")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x8D145C", Offset = "0x8D145C", VA = "0x8D145C")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[PreserveSig]
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x8D0FA8", Offset = "0x8D0FA8", VA = "0x8D0FA8")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x8D0364", Offset = "0x8D0364", VA = "0x8D0364")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x8D047C", Offset = "0x8D047C", VA = "0x8D047C")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[PreserveSig]
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x8D20C0", Offset = "0x8D20C0", VA = "0x8D20C0")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[PreserveSig]
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x8D0DF4", Offset = "0x8D0DF4", VA = "0x8D0DF4")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[PreserveSig]
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x8D1E60", Offset = "0x8D1E60", VA = "0x8D1E60")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x8D13A8", Offset = "0x8D13A8", VA = "0x8D13A8")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x8D2144", Offset = "0x8D2144", VA = "0x8D2144")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[PreserveSig]
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x8D21E8", Offset = "0x8D21E8", VA = "0x8D21E8")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[PreserveSig]
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x8D2274", Offset = "0x8D2274", VA = "0x8D2274")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[PreserveSig]
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x8D22F0", Offset = "0x8D22F0", VA = "0x8D22F0")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x8D0E90", Offset = "0x8D0E90", VA = "0x8D0E90")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x8D2384", Offset = "0x8D2384", VA = "0x8D2384")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x8D0584", Offset = "0x8D0584", VA = "0x8D0584")]
		public SpeexLib()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public interface IDataReader<T> : IDisposable
	{
		[Token(Token = "0x6000445")]
		bool Read(T[] buffer);
	}
	[Token(Token = "0x2000066")]
	public interface IServiceable
	{
		[Token(Token = "0x6000446")]
		void Service(LocalVoice localVoice);
	}
	[Token(Token = "0x2000067")]
	public class LocalVoice : IDisposable
	{
		[Token(Token = "0x4000286")]
		public const int DATA_POOL_CAPACITY = 50;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool debugEchoMode;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal VoiceInfo info;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected IEncoder encoder;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		internal byte id;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		internal int channelId;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		internal byte evNumber;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		protected bool disposed;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected object disposeLock;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int noTransmitCnt;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		internal Dictionary<byte, int> eventTimestamps;

		[Token(Token = "0x1700007A")]
		public byte Group
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0x8D249C", Offset = "0x8D249C", VA = "0x8D249C")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x8D24A4", Offset = "0x8D24A4", VA = "0x8D24A4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public VoiceInfo Info
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0x8D24AC", Offset = "0x8D24AC", VA = "0x8D24AC")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Token(Token = "0x1700007C")]
		public bool Transmit
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x8D24C4", Offset = "0x8D24C4", VA = "0x8D24C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x8D24CC", Offset = "0x8D24CC", VA = "0x8D24CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700007D")]
		public bool IsTransmitting
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x8D24D8", Offset = "0x8D24D8", VA = "0x8D24D8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x8D24E0", Offset = "0x8D24E0", VA = "0x8D24E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public int FramesSent
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0x8D24EC", Offset = "0x8D24EC", VA = "0x8D24EC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x8D24F4", Offset = "0x8D24F4", VA = "0x8D24F4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public int FramesSentBytes
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x8D24FC", Offset = "0x8D24FC", VA = "0x8D24FC")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x8D2504", Offset = "0x8D2504", VA = "0x8D2504")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool Reliable
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x8D250C", Offset = "0x8D250C", VA = "0x8D250C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x8D2514", Offset = "0x8D2514", VA = "0x8D2514")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool Encrypt
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x8D2520", Offset = "0x8D2520", VA = "0x8D2520")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x8D2528", Offset = "0x8D2528", VA = "0x8D2528")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public object LocalUserObject
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x8D2534", Offset = "0x8D2534", VA = "0x8D2534")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x8D253C", Offset = "0x8D253C", VA = "0x8D253C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public IServiceable LocalUserServiceable
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x8D2544", Offset = "0x8D2544", VA = "0x8D2544")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x8D254C", Offset = "0x8D254C", VA = "0x8D254C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool DebugEchoMode
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x8D2554", Offset = "0x8D2554", VA = "0x8D2554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x8D255C", Offset = "0x8D255C", VA = "0x8D255C")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		internal string Name
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x8D27DC", Offset = "0x8D27DC", VA = "0x8D27DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		internal string LogPrefix
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x8D297C", Offset = "0x8D297C", VA = "0x8D297C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x8D2628", Offset = "0x8D2628", VA = "0x8D2628")]
		internal LocalVoice()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x8D26D4", Offset = "0x8D26D4", VA = "0x8D26D4")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x8D29D4", Offset = "0x8D29D4", VA = "0x8D29D4")]
		protected void resetNoTransmitCnt()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x8D29E0", Offset = "0x8D29E0", VA = "0x8D29E0", Slot = "5")]
		internal virtual void service()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x8D2EC0", Offset = "0x8D2EC0", VA = "0x8D2EC0")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x8D301C", Offset = "0x8D301C", VA = "0x8D301C")]
		public void RemoveSelf()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x8D32FC", Offset = "0x8D32FC", VA = "0x8D32FC", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public struct RemoteVoiceOptions
	{
		[Token(Token = "0x17000087")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0x8D33B4", Offset = "0x8D33B4", VA = "0x8D33B4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000466")]
			[Address(RVA = "0x8D33BC", Offset = "0x8D33BC", VA = "0x8D33BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x8D33C4", Offset = "0x8D33C4", VA = "0x8D33C4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x8D33CC", Offset = "0x8D33CC", VA = "0x8D33CC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x8D33D4", Offset = "0x8D33D4", VA = "0x8D33D4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x8D33DC", Offset = "0x8D33DC", VA = "0x8D33DC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0x8D33E4", Offset = "0x8D33E4", VA = "0x8D33E4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x8D33EC", Offset = "0x8D33EC", VA = "0x8D33EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public object LocalUserObject
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0x8D33F4", Offset = "0x8D33F4", VA = "0x8D33F4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600046E")]
			[Address(RVA = "0x8D33FC", Offset = "0x8D33FC", VA = "0x8D33FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public IDecoder Decoder
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0x8D3404", Offset = "0x8D3404", VA = "0x8D3404")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000470")]
			[Address(RVA = "0x8D340C", Offset = "0x8D340C", VA = "0x8D340C")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000069")]
	internal class RemoteVoice : IDisposable
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		internal RemoteVoiceOptions options;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int channelId;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int playerId;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private byte voiceId;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool disposed;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private object disposeLock;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		internal byte lastEvNumber;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private VoiceClient voiceClient;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Queue<byte[]> frameQueue;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AutoResetEvent frameQueueReady;

		[Token(Token = "0x1700008D")]
		internal VoiceInfo Info
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x8D3414", Offset = "0x8D3414", VA = "0x8D3414")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x8D3428", Offset = "0x8D3428", VA = "0x8D3428")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		protected string Name
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x8D37DC", Offset = "0x8D37DC", VA = "0x8D37DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		protected string LogPrefix
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x8D3784", Offset = "0x8D3784", VA = "0x8D3784")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x8D343C", Offset = "0x8D343C", VA = "0x8D343C")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x8D39BC", Offset = "0x8D39BC", VA = "0x8D39BC")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x8D39C8", Offset = "0x8D39C8", VA = "0x8D39C8")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x8D3FD0", Offset = "0x8D3FD0", VA = "0x8D3FD0")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x8D3DD0", Offset = "0x8D3DD0", VA = "0x8D3DD0")]
		private void receiveNullFrames(int count)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x8D41B0", Offset = "0x8D41B0", VA = "0x8D41B0")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x8D47C0", Offset = "0x8D47C0", VA = "0x8D47C0")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x8D4978", Offset = "0x8D4978", VA = "0x8D4978")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x8D4C1C", Offset = "0x8D4C1C", VA = "0x8D4C1C")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x8D4EC8", Offset = "0x8D4EC8", VA = "0x8D4EC8")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x8D5174", Offset = "0x8D5174", VA = "0x8D5174")]
		internal void removeAndDispose()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x8D51A0", Offset = "0x8D51A0", VA = "0x8D51A0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public interface IAudioSource : IDisposable
	{
		[Token(Token = "0x17000090")]
		int SamplingRate
		{
			[Token(Token = "0x6000482")]
			get;
		}

		[Token(Token = "0x17000091")]
		int Channels
		{
			[Token(Token = "0x6000483")]
			get;
		}
	}
	[Token(Token = "0x200006B")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Token(Token = "0x200006C")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Token(Token = "0x6000484")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Token(Token = "0x200006D")]
	public interface ILocalVoiceAudio
	{
		[Token(Token = "0x17000092")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x6000485")]
			get;
		}

		[Token(Token = "0x17000093")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x6000486")]
			get;
		}

		[Token(Token = "0x17000094")]
		bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000487")]
			get;
		}

		[Token(Token = "0x6000488")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Token(Token = "0x200006E")]
	public static class LocalVoiceAudio
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LocalVoiceAudioDummy Dummy;

		[Token(Token = "0x6000489")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Token(Token = "0x200006F")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int channels;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected int sourceSamplingRateHz;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected bool resampleSource;

		[Token(Token = "0x17000095")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x600048B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x600048C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x600048E")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600048D")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x600048F")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Token(Token = "0x6000490")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Token(Token = "0x17000098")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x8D53AC", Offset = "0x8D53AC", VA = "0x8D53AC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x8D53B4", Offset = "0x8D53B4", VA = "0x8D53B4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		public bool VoiceDetectorCalibrating
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x8D53BC", Offset = "0x8D53BC", VA = "0x8D53BC", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x8D53C4", Offset = "0x8D53C4", VA = "0x8D53C4", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x8D5314", Offset = "0x8D5314", VA = "0x8D5314")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x8D53C8", Offset = "0x8D53C8", VA = "0x8D53C8")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x8D5510", Offset = "0x8D5510", VA = "0x8D5510")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Token(Token = "0x2000073")]
	internal enum EventSubcode : byte
	{
		[Token(Token = "0x40002B6")]
		VoiceInfo = 1,
		[Token(Token = "0x40002B7")]
		VoiceRemove,
		[Token(Token = "0x40002B8")]
		Frame
	}
	[Token(Token = "0x2000074")]
	internal enum EventParam : byte
	{
		[Token(Token = "0x40002BA")]
		VoiceId = 1,
		[Token(Token = "0x40002BB")]
		SamplingRate = 2,
		[Token(Token = "0x40002BC")]
		Channels = 3,
		[Token(Token = "0x40002BD")]
		FrameDurationUs = 4,
		[Token(Token = "0x40002BE")]
		Bitrate = 5,
		[Token(Token = "0x40002BF")]
		UserData = 10,
		[Token(Token = "0x40002C0")]
		EventNumber = 11,
		[Token(Token = "0x40002C1")]
		Codec = 12
	}
	[Token(Token = "0x2000075")]
	public interface ILogger
	{
		[Token(Token = "0x6000498")]
		void LogError(string fmt, params object[] args);

		[Token(Token = "0x6000499")]
		void LogWarning(string fmt, params object[] args);

		[Token(Token = "0x600049A")]
		void LogInfo(string fmt, params object[] args);

		[Token(Token = "0x600049B")]
		void LogDebug(string fmt, params object[] args);
	}
	[Token(Token = "0x2000076")]
	internal interface IVoiceFrontend : ILogger
	{
		[Token(Token = "0x600049C")]
		int AssignChannel(VoiceInfo v);

		[Token(Token = "0x600049D")]
		bool IsChannelJoined(int channelId);

		[Token(Token = "0x600049E")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Token(Token = "0x600049F")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Token(Token = "0x60004A0")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Token(Token = "0x60004A1")]
		string ChannelIdStr(int channelId);

		[Token(Token = "0x60004A2")]
		string PlayerIdStr(int playerId);

		[Token(Token = "0x60004A3")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Token(Token = "0x2000077")]
	public class VoiceClient : IDisposable
	{
		[Token(Token = "0x2000078")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RemoteVoiceInfo <>2__current;

			[Token(Token = "0x40002D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40002D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x40002D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Token(Token = "0x40002D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Token(Token = "0x40002D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Token(Token = "0x40002DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Token(Token = "0x170000A8")]
			private RemoteVoiceInfo System.Collections.Generic.IEnumerator<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.Current
			{
				[Token(Token = "0x60004DC")]
				[Address(RVA = "0x8DBBA0", Offset = "0x8DBBA0", VA = "0x8DBBA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004DE")]
				[Address(RVA = "0x8DBBE8", Offset = "0x8DBBE8", VA = "0x8DBBE8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x8D5BC4", Offset = "0x8D5BC4", VA = "0x8D5BC4")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x8DB52C", Offset = "0x8DB52C", VA = "0x8DB52C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x8DB660", Offset = "0x8DB660", VA = "0x8DB660", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x8DBB50", Offset = "0x8DBB50", VA = "0x8DBB50")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x8DBB00", Offset = "0x8DBB00", VA = "0x8DBB00")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x8DBAB0", Offset = "0x8DBAB0", VA = "0x8DBAB0")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x8DBBA8", Offset = "0x8DBBA8", VA = "0x8DBBA8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x8DBBF0", Offset = "0x8DBBF0", VA = "0x8DBBF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RemoteVoiceInfo> System.Collections.Generic.IEnumerable<ExitGames.Client.Photon.Voice.RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x8DBC94", Offset = "0x8DBC94", VA = "0x8DBC94", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x200007A")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40002DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public VoiceClient <>4__this;

			[Token(Token = "0x40002DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Token(Token = "0x170000AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E7")]
				[Address(RVA = "0x8DC1E4", Offset = "0x8DC1E4", VA = "0x8DC1E4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E9")]
				[Address(RVA = "0x8DC22C", Offset = "0x8DC22C", VA = "0x8DC22C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x8D5C70", Offset = "0x8D5C70", VA = "0x8D5C70")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x8DBC98", Offset = "0x8DBC98", VA = "0x8DBC98", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x8DBDCC", Offset = "0x8DBDCC", VA = "0x8DBDCC", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x8DC194", Offset = "0x8DC194", VA = "0x8DC194")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x8DC144", Offset = "0x8DC144", VA = "0x8DC144")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x8DC0F4", Offset = "0x8DC0F4", VA = "0x8DC0F4")]
			private void <>m__Finally3()
			{
			}

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x8DC1EC", Offset = "0x8DC1EC", VA = "0x8DC1EC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x8DC234", Offset = "0x8DC234", VA = "0x8DC234", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x8DC2D8", Offset = "0x8DC2D8", VA = "0x8DC2D8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IVoiceFrontend frontend;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int prevRtt;

		[Token(Token = "0x40002CB")]
		public const int ChannelAuto = -1;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private byte globalGroup;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private byte voiceIdCnt;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private System.Random rnd;

		[Token(Token = "0x1700009B")]
		public int FramesLost
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x8D5658", Offset = "0x8D5658", VA = "0x8D5658")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x8D5660", Offset = "0x8D5660", VA = "0x8D5660")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public int FramesReceived
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x8D5668", Offset = "0x8D5668", VA = "0x8D5668")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x8D5670", Offset = "0x8D5670", VA = "0x8D5670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public int FramesSent
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x8D5678", Offset = "0x8D5678", VA = "0x8D5678")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009E")]
		public int FramesSentBytes
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x8D57D8", Offset = "0x8D57D8", VA = "0x8D57D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700009F")]
		public int RoundTripTime
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x8D5938", Offset = "0x8D5938", VA = "0x8D5938")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x8D5940", Offset = "0x8D5940", VA = "0x8D5940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public int RoundTripTimeVariance
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x8D5948", Offset = "0x8D5948", VA = "0x8D5948")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x8D5950", Offset = "0x8D5950", VA = "0x8D5950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public bool SuppressInfoDuplicateWarning
		{
			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x8D5958", Offset = "0x8D5958", VA = "0x8D5958")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x8D5960", Offset = "0x8D5960", VA = "0x8D5960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x8D596C", Offset = "0x8D596C", VA = "0x8D596C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x8D5974", Offset = "0x8D5974", VA = "0x8D5974")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public int DebugLostPercent
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x8D597C", Offset = "0x8D597C", VA = "0x8D597C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x8D5984", Offset = "0x8D5984", VA = "0x8D5984")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x8D598C", Offset = "0x8D598C", VA = "0x8D598C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x8D5B4C", Offset = "0x8D5B4C", VA = "0x8D5B4C")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x8D5BF8", Offset = "0x8D5BF8", VA = "0x8D5BF8")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		internal byte GlobalGroup
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x8D9098", Offset = "0x8D9098", VA = "0x8D9098")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x8D90A0", Offset = "0x8D90A0", VA = "0x8D90A0")]
			set
			{
			}
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x8D5A5C", Offset = "0x8D5A5C", VA = "0x8D5A5C")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x8D5CA4", Offset = "0x8D5CA4", VA = "0x8D5CA4")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x8D5DEC", Offset = "0x8D5DEC", VA = "0x8D5DEC")]
		public void Service()
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x8D5F4C", Offset = "0x8D5F4C", VA = "0x8D5F4C")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x8D6C38", Offset = "0x8D6C38", VA = "0x8D6C38")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x60004BD")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x8D61D0", Offset = "0x8D61D0", VA = "0x8D61D0")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x8D63DC", Offset = "0x8D63DC", VA = "0x8D63DC")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x8D3038", Offset = "0x8D3038", VA = "0x8D3038")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x8D6D4C", Offset = "0x8D6D4C", VA = "0x8D6D4C")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x8D6EAC", Offset = "0x8D6EAC", VA = "0x8D6EAC")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x8D701C", Offset = "0x8D701C", VA = "0x8D701C")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x8D91F0", Offset = "0x8D91F0", VA = "0x8D91F0")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x8D9B38", Offset = "0x8D9B38", VA = "0x8D9B38")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x8D9DC4", Offset = "0x8D9DC4", VA = "0x8D9DC4")]
		internal void clearRemoteVoices()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x8DA2AC", Offset = "0x8DA2AC", VA = "0x8DA2AC")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x8D746C", Offset = "0x8D746C", VA = "0x8D746C")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x8D7EDC", Offset = "0x8D7EDC", VA = "0x8D7EDC")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x8D88EC", Offset = "0x8D88EC", VA = "0x8D88EC")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x8DAA48", Offset = "0x8DAA48", VA = "0x8DAA48")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x8DABAC", Offset = "0x8DABAC", VA = "0x8DABAC")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x8D2870", Offset = "0x8D2870", VA = "0x8D2870")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x8DA8C8", Offset = "0x8DA8C8", VA = "0x8DA8C8")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x8DADBC", Offset = "0x8DADBC", VA = "0x8DADBC", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public interface IEncoder : IDisposable
	{
	}
	[Token(Token = "0x200007F")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Token(Token = "0x2000080")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Token(Token = "0x60004F2")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Token(Token = "0x2000081")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Token(Token = "0x60004F3")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Token(Token = "0x2000082")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Token(Token = "0x60004F4")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Token(Token = "0x2000083")]
	public interface IDecoder : IDisposable
	{
		[Token(Token = "0x60004F5")]
		void Open(VoiceInfo info);
	}
	[Token(Token = "0x2000084")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Token(Token = "0x60004F6")]
		byte[] DecodeToByte(byte[] buf);

		[Token(Token = "0x60004F7")]
		float[] DecodeToFloat(byte[] buf);

		[Token(Token = "0x60004F8")]
		short[] DecodeToShort(byte[] buf);
	}
	[Token(Token = "0x2000085")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Token(Token = "0x60004F9")]
		void Decode(byte[] buf);
	}
	[Token(Token = "0x2000086")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Token(Token = "0x2000087")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Token(Token = "0x170000AC")]
		ImageFormat OutputImageFormat
		{
			[Token(Token = "0x60004FE")]
			get;
			[Token(Token = "0x60004FF")]
			set;
		}

		[Token(Token = "0x170000AD")]
		Flip OutputImageFlip
		{
			[Token(Token = "0x6000500")]
			get;
			[Token(Token = "0x6000501")]
			set;
		}

		[Token(Token = "0x170000AE")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Token(Token = "0x6000502")]
			get;
			[Token(Token = "0x6000503")]
			set;
		}

		[Token(Token = "0x170000AF")]
		OnImageOutputNative OnOutputImage
		{
			[Token(Token = "0x6000504")]
			get;
			[Token(Token = "0x6000505")]
			set;
		}
	}
	[Token(Token = "0x2000088")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x8DC54C", Offset = "0x8DC54C", VA = "0x8DC54C")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Token(Token = "0x2000089")]
	internal class UnsupportedCodecException : Exception
	{
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x8CF1B4", Offset = "0x8CF1B4", VA = "0x8CF1B4")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public enum Codec
	{
		[Token(Token = "0x40002ED")]
		AudioOpus = 11
	}
	[Token(Token = "0x200008B")]
	public enum ImageFormat
	{
		[Token(Token = "0x40002EF")]
		I420,
		[Token(Token = "0x40002F0")]
		YV12,
		[Token(Token = "0x40002F1")]
		Android420,
		[Token(Token = "0x40002F2")]
		RGBA,
		[Token(Token = "0x40002F3")]
		ABGR,
		[Token(Token = "0x40002F4")]
		BGRA,
		[Token(Token = "0x40002F5")]
		ARGB
	}
	[Token(Token = "0x200008C")]
	public enum Rotation
	{
		[Token(Token = "0x40002F7")]
		Rotate0 = 0,
		[Token(Token = "0x40002F8")]
		Rotate90 = 90,
		[Token(Token = "0x40002F9")]
		Rotate180 = 180,
		[Token(Token = "0x40002FA")]
		Rotate270 = 270
	}
	[Token(Token = "0x200008D")]
	public enum Flip
	{
		[Token(Token = "0x40002FC")]
		None,
		[Token(Token = "0x40002FD")]
		Vertical,
		[Token(Token = "0x40002FE")]
		Horizontal
	}
	[Token(Token = "0x200008E")]
	public class ImageBufferInfo
	{
		[Token(Token = "0x170000B0")]
		public int Width
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x8DC600", Offset = "0x8DC600", VA = "0x8DC600")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x8DC608", Offset = "0x8DC608", VA = "0x8DC608")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public int Height
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x8DC610", Offset = "0x8DC610", VA = "0x8DC610")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x8DC618", Offset = "0x8DC618", VA = "0x8DC618")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public int[] Stride
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x8DC620", Offset = "0x8DC620", VA = "0x8DC620")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x8DC628", Offset = "0x8DC628", VA = "0x8DC628")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B3")]
		public ImageFormat Format
		{
			[Token(Token = "0x600050E")]
			[Address(RVA = "0x8DC630", Offset = "0x8DC630", VA = "0x8DC630")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Token(Token = "0x600050F")]
			[Address(RVA = "0x8DC638", Offset = "0x8DC638", VA = "0x8DC638")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		public Rotation Rotation
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0x8DC640", Offset = "0x8DC640", VA = "0x8DC640")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Token(Token = "0x6000511")]
			[Address(RVA = "0x8DC648", Offset = "0x8DC648", VA = "0x8DC648")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000B5")]
		public Flip Flip
		{
			[Token(Token = "0x6000512")]
			[Address(RVA = "0x8DC650", Offset = "0x8DC650", VA = "0x8DC650")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Token(Token = "0x6000513")]
			[Address(RVA = "0x8DC658", Offset = "0x8DC658", VA = "0x8DC658")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x8DC660", Offset = "0x8DC660", VA = "0x8DC660")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class ImageBufferNative
	{
		[Token(Token = "0x170000B6")]
		public ImageBufferInfo Info
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0x8DC6CC", Offset = "0x8DC6CC", VA = "0x8DC6CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0x8DC6D4", Offset = "0x8DC6D4", VA = "0x8DC6D4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000B7")]
		public IntPtr[] Planes
		{
			[Token(Token = "0x6000518")]
			[Address(RVA = "0x8DC6DC", Offset = "0x8DC6DC", VA = "0x8DC6DC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000519")]
			[Address(RVA = "0x8DC6E4", Offset = "0x8DC6E4", VA = "0x8DC6E4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x8DC6A4", Offset = "0x8DC6A4", VA = "0x8DC6A4")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x8DC6EC", Offset = "0x8DC6EC", VA = "0x8DC6EC", Slot = "4")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x8DC6F0", Offset = "0x8DC6F0", VA = "0x8DC6F0", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x2000090")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x8DC6F4", Offset = "0x8DC6F4", VA = "0x8DC6F4")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x8DC808", Offset = "0x8DC808", VA = "0x8DC808", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x8DC824", Offset = "0x8DC824", VA = "0x8DC824", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle planeHandle;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x8DC8D8", Offset = "0x8DC8D8", VA = "0x8DC8D8")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x8DC9F4", Offset = "0x8DC9F4", VA = "0x8DC9F4")]
		public void PinPlane(byte[] plane)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x8DCA4C", Offset = "0x8DCA4C", VA = "0x8DCA4C", Slot = "4")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x8DCA84", Offset = "0x8DCA84", VA = "0x8DCA84", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000092")]
	internal static class VoiceCodec
	{
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x8DCA88", Offset = "0x8DCA88", VA = "0x8DCA88")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x8DA9D4", Offset = "0x8DA9D4", VA = "0x8DA9D4")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[Token(Token = "0x2000093")]
	public class Framer<T>
	{
		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] <>2__current;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Framer<T> <>4__this;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T[] buf;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T[] <>3__buf;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <s>5__2;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <bufPos>5__3;

			[Token(Token = "0x170000B8")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Token(Token = "0x600052B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600052D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000528")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x6000529")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052A")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600052C")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600052E")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600052F")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] frame;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int sizeofT;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framePos;

		[Token(Token = "0x6000525")]
		public Framer(int frameSize)
		{
		}

		[Token(Token = "0x6000526")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Token(Token = "0x6000527")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Token(Token = "0x170000BA")]
		public int FrameSize
		{
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x8DCB0C", Offset = "0x8DCB0C", VA = "0x8DCB0C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x8DCB14", Offset = "0x8DCB14", VA = "0x8DCB14")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x8DCB1C", Offset = "0x8DCB1C", VA = "0x8DCB1C")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Token(Token = "0x2000097")]
		public interface IProcessor : IDisposable
		{
			[Token(Token = "0x600053E")]
			T[] Process(T[] buf);
		}

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Framer<T> framer;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int preProcessorsCnt;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<IProcessor> processors;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool dataEncodeThreadStarted;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Queue<T[]> pushDataQueue;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private AutoResetEvent pushDataQueueReady;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int framesSkipped;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool exitThread;

		[Token(Token = "0x170000BB")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Token(Token = "0x6000538")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public bool PushDataAsyncReady
		{
			[Token(Token = "0x6000539")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000533")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Token(Token = "0x6000534")]
		public void AddPostProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000535")]
		public void AddPreProcessor(params IProcessor[] processors)
		{
		}

		[Token(Token = "0x6000536")]
		public void ClearProcessors()
		{
		}

		[Token(Token = "0x6000537")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Token(Token = "0x600053A")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Token(Token = "0x600053B")]
		private void PushDataAsyncThread()
		{
		}

		[Token(Token = "0x600053C")]
		public void PushData(T[] buf)
		{
		}

		[Token(Token = "0x600053D")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public struct VoiceInfo
	{
		[Token(Token = "0x170000BD")]
		public Codec Codec
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x8DCBAC", Offset = "0x8DCBAC", VA = "0x8DCBAC")]
			[CompilerGenerated]
			readonly get
			{
				return default(Codec);
			}
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x8DCBB4", Offset = "0x8DCBB4", VA = "0x8DCBB4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public int SamplingRate
		{
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x8DCBBC", Offset = "0x8DCBBC", VA = "0x8DCBBC")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x8DCBC4", Offset = "0x8DCBC4", VA = "0x8DCBC4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public int SourceSamplingRate
		{
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x8DCBCC", Offset = "0x8DCBCC", VA = "0x8DCBCC")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x8DCBD4", Offset = "0x8DCBD4", VA = "0x8DCBD4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public int Channels
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x8DCBDC", Offset = "0x8DCBDC", VA = "0x8DCBDC")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x8DCBE4", Offset = "0x8DCBE4", VA = "0x8DCBE4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public int FrameDurationUs
		{
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x8DCBEC", Offset = "0x8DCBEC", VA = "0x8DCBEC")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x8DCBF4", Offset = "0x8DCBF4", VA = "0x8DCBF4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public int Bitrate
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x8DCBFC", Offset = "0x8DCBFC", VA = "0x8DCBFC")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x8DCC04", Offset = "0x8DCC04", VA = "0x8DCC04")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public object UserData
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x8DCC0C", Offset = "0x8DCC0C", VA = "0x8DCC0C")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x8DCC14", Offset = "0x8DCC14", VA = "0x8DCC14")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public int FrameDurationSamples
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x8DCC1C", Offset = "0x8DCC1C", VA = "0x8DCC1C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C5")]
		public int FrameSize
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x8DCB74", Offset = "0x8DCB74", VA = "0x8DCB74")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C6")]
		public int Width
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x8DCC4C", Offset = "0x8DCC4C", VA = "0x8DCC4C")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x8DCC54", Offset = "0x8DCC54", VA = "0x8DCC54")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public int Height
		{
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x8DCC5C", Offset = "0x8DCC5C", VA = "0x8DCC5C")]
			[CompilerGenerated]
			readonly get
			{
				return default(int);
			}
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x8DCC64", Offset = "0x8DCC64", VA = "0x8DCC64")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x8DCB5C", Offset = "0x8DCB5C", VA = "0x8DCB5C")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x8D66E0", Offset = "0x8D66E0", VA = "0x8D66E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x8DA718", Offset = "0x8DA718", VA = "0x8DA718")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Token(Token = "0x2000099")]
	public class RemoteVoiceInfo
	{
		[Token(Token = "0x170000C8")]
		public VoiceInfo Info
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x8DCC6C", Offset = "0x8DCC6C", VA = "0x8DCC6C")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x8DCC80", Offset = "0x8DCC80", VA = "0x8DCC80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public int ChannelId
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x8DCC94", Offset = "0x8DCC94", VA = "0x8DCC94")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x8DCC9C", Offset = "0x8DCC9C", VA = "0x8DCC9C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public int PlayerId
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x8DCCA4", Offset = "0x8DCCA4", VA = "0x8DCCA4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x8DCCAC", Offset = "0x8DCCAC", VA = "0x8DCCAC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public byte VoiceId
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x8DCCB4", Offset = "0x8DCCB4", VA = "0x8DCCB4")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x8DCCBC", Offset = "0x8DCCBC", VA = "0x8DCCBC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public object LocalUserObject
		{
			[Token(Token = "0x600055F")]
			[Address(RVA = "0x8DCCC4", Offset = "0x8DCCC4", VA = "0x8DCCC4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000560")]
			[Address(RVA = "0x8DCCCC", Offset = "0x8DCCCC", VA = "0x8DCCCC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x8DBA50", Offset = "0x8DBA50", VA = "0x8DBA50")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IDataReader<T> reader;

		[Token(Token = "0x6000561")]
		public abstract void Service(LocalVoice localVoice);

		[Token(Token = "0x6000562")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Token(Token = "0x6000563")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200009B")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x6000564")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x6000565")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x200009C")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x6000566")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x6000567")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected T[] buffer;

		[Token(Token = "0x6000568")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Token(Token = "0x6000569")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float[] buffer;

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x8DCCD4", Offset = "0x8DCCD4", VA = "0x8DCCD4")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x8DCDA8", Offset = "0x8DCDA8", VA = "0x8DCDA8", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Token(Token = "0x200009F")]
	internal class VoiceEventCode
	{
		[Token(Token = "0x4000331")]
		public const byte Code0 = 201;

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x8DCFD0", Offset = "0x8DCFD0", VA = "0x8DCFD0")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x8DCFD8", Offset = "0x8DCFD8", VA = "0x8DCFD8")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x8DD00C", Offset = "0x8DD00C", VA = "0x8DD00C")]
		public VoiceEventCode()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		protected VoiceClient voiceClient;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private object sendLock;

		[Token(Token = "0x170000CD")]
		public VoiceClient VoiceClient
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x8DD014", Offset = "0x8DD014", VA = "0x8DD014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public new Action<EventData> OnEventAction
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x8DD6EC", Offset = "0x8DD6EC", VA = "0x8DD6EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x8DD6F4", Offset = "0x8DD6F4", VA = "0x8DD6F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x8DD6FC", Offset = "0x8DD6FC", VA = "0x8DD6FC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x8DD704", Offset = "0x8DD704", VA = "0x8DD704")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D0")]
		public byte GlobalAudioGroup
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x8DDCB4", Offset = "0x8DDCB4", VA = "0x8DDCB4")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x8DDCD0", Offset = "0x8DDCD0", VA = "0x8DDCD0")]
			set
			{
			}
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x8DD01C", Offset = "0x8DD01C", VA = "0x8DD01C", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x8DD054", Offset = "0x8DD054", VA = "0x8DD054", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x8DD08C", Offset = "0x8DD08C", VA = "0x8DD08C", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x8DD0C4", Offset = "0x8DD0C4", VA = "0x8DD0C4", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x8DD0FC", Offset = "0x8DD0FC", VA = "0x8DD0FC", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x8DD1F0", Offset = "0x8DD1F0", VA = "0x8DD1F0", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x8DD200", Offset = "0x8DD200", VA = "0x8DD200", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x8DD70C", Offset = "0x8DD70C", VA = "0x8DD70C")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x8DDC48", Offset = "0x8DDC48", VA = "0x8DDC48")]
		public new void Service()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x8DDC90", Offset = "0x8DDC90", VA = "0x8DDC90", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x8DD350", Offset = "0x8DD350", VA = "0x8DD350", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x8DDDD0", Offset = "0x8DDDD0", VA = "0x8DDDD0")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x8DD524", Offset = "0x8DD524", VA = "0x8DD524", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x8DDF44", Offset = "0x8DDF44", VA = "0x8DDF44", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x8DE218", Offset = "0x8DE218", VA = "0x8DE218", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x8DE220", Offset = "0x8DE220", VA = "0x8DE220", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x8DE228", Offset = "0x8DE228", VA = "0x8DE228")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x8DE4EC", Offset = "0x8DE4EC", VA = "0x8DE4EC")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x8DE41C", Offset = "0x8DE41C", VA = "0x8DE41C")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x8DE614", Offset = "0x8DE614", VA = "0x8DE614", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class AudioInEnumerator : IDisposable
	{
		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly bool IsSupported;

		[Token(Token = "0x170000D1")]
		public int Count
		{
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x8DE6BC", Offset = "0x8DE6BC", VA = "0x8DE6BC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x8DE6B0", Offset = "0x8DE6B0", VA = "0x8DE6B0")]
		public AudioInEnumerator()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x8DE6B8", Offset = "0x8DE6B8", VA = "0x8DE6B8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x8DE6C4", Offset = "0x8DE6C4", VA = "0x8DE6C4")]
		public string NameAtIndex(int i)
		{
			return null;
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x8DE6CC", Offset = "0x8DE6CC", VA = "0x8DE6CC")]
		public int IDAtIndex(int i)
		{
			return default(int);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x8DE6D4", Offset = "0x8DE6D4", VA = "0x8DE6D4")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x8DE6E0", Offset = "0x8DE6E0", VA = "0x8DE6E0", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Token(Token = "0x20000A3")]
	public static class Extensions
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x8DE6E4", Offset = "0x8DE6E4", VA = "0x8DE6E4")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x8DEB24", Offset = "0x8DEB24", VA = "0x8DEB24")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x8DEF8C", Offset = "0x8DEF8C", VA = "0x8DEF8C")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x8DEFE8", Offset = "0x8DEFE8", VA = "0x8DEFE8")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x8DF130", Offset = "0x8DF130", VA = "0x8DF130")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x8DF554", Offset = "0x8DF554", VA = "0x8DF554")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x8DF7FC", Offset = "0x8DF7FC", VA = "0x8DF7FC")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A4")]
	public class FriendInfo
	{
		[Token(Token = "0x170000D2")]
		[Obsolete("Use UserId.")]
		public string Name
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x8DF850", Offset = "0x8DF850", VA = "0x8DF850")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D3")]
		public string UserId
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x8DF858", Offset = "0x8DF858", VA = "0x8DF858")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x8DF860", Offset = "0x8DF860", VA = "0x8DF860")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000D4")]
		public bool IsOnline
		{
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x8DF868", Offset = "0x8DF868", VA = "0x8DF868")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x8DF870", Offset = "0x8DF870", VA = "0x8DF870")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public string Room
		{
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x8DF87C", Offset = "0x8DF87C", VA = "0x8DF87C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x8DF884", Offset = "0x8DF884", VA = "0x8DF884")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000D6")]
		public bool IsInRoom
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x8DF88C", Offset = "0x8DF88C", VA = "0x8DF88C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x8DF8B4", Offset = "0x8DF8B4", VA = "0x8DF8B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x8DF970", Offset = "0x8DF970", VA = "0x8DF970")]
		public FriendInfo()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public enum ClientState
	{
		[Token(Token = "0x400033D")]
		PeerCreated = 0,
		[Token(Token = "0x400033E")]
		Authenticating = 1,
		[Token(Token = "0x400033F")]
		Authenticated = 2,
		[Token(Token = "0x4000340")]
		JoinedLobby = 3,
		[Token(Token = "0x4000341")]
		DisconnectingFromMasterserver = 4,
		[Token(Token = "0x4000342")]
		ConnectingToGameserver = 5,
		[Token(Token = "0x4000343")]
		ConnectedToGameserver = 6,
		[Token(Token = "0x4000344")]
		Joining = 7,
		[Token(Token = "0x4000345")]
		Joined = 8,
		[Token(Token = "0x4000346")]
		Leaving = 9,
		[Token(Token = "0x4000347")]
		DisconnectingFromGameserver = 10,
		[Token(Token = "0x4000348")]
		ConnectingToMasterserver = 11,
		[Token(Token = "0x4000349")]
		Disconnecting = 12,
		[Token(Token = "0x400034A")]
		Disconnected = 13,
		[Token(Token = "0x400034B")]
		ConnectedToMasterserver = 14,
		[Token(Token = "0x400034C")]
		[Obsolete("Renamed to ConnectedToMasterserver.")]
		ConnectedToMaster = 14,
		[Token(Token = "0x400034D")]
		ConnectingToNameServer = 15,
		[Token(Token = "0x400034E")]
		ConnectedToNameServer = 16,
		[Token(Token = "0x400034F")]
		DisconnectingFromNameServer = 17
	}
	[Token(Token = "0x20000A6")]
	internal enum JoinType
	{
		[Token(Token = "0x4000351")]
		CreateRoom,
		[Token(Token = "0x4000352")]
		JoinRoom,
		[Token(Token = "0x4000353")]
		JoinRandomRoom,
		[Token(Token = "0x4000354")]
		JoinOrCreateRoom
	}
	[Token(Token = "0x20000A7")]
	public enum DisconnectCause
	{
		[Token(Token = "0x4000356")]
		None,
		[Token(Token = "0x4000357")]
		DisconnectByServerUserLimit,
		[Token(Token = "0x4000358")]
		ExceptionOnConnect,
		[Token(Token = "0x4000359")]
		DisconnectByServer,
		[Token(Token = "0x400035A")]
		TimeoutDisconnect,
		[Token(Token = "0x400035B")]
		Exception,
		[Token(Token = "0x400035C")]
		InvalidAuthentication,
		[Token(Token = "0x400035D")]
		MaxCcuReached,
		[Token(Token = "0x400035E")]
		InvalidRegion,
		[Token(Token = "0x400035F")]
		OperationNotAllowedInCurrentState,
		[Token(Token = "0x4000360")]
		CustomAuthenticationFailed,
		[Token(Token = "0x4000361")]
		DisconnectByServerLogic,
		[Token(Token = "0x4000362")]
		AuthenticationTicketExpired
	}
	[Token(Token = "0x20000A8")]
	public enum ServerConnection
	{
		[Token(Token = "0x4000364")]
		MasterServer,
		[Token(Token = "0x4000365")]
		GameServer,
		[Token(Token = "0x4000366")]
		NameServer
	}
	[Token(Token = "0x20000A9")]
	public enum EncryptionMode
	{
		[Token(Token = "0x4000368")]
		PayloadEncryption = 0,
		[Token(Token = "0x4000369")]
		DatagramEncryption = 10,
		[Token(Token = "0x400036A")]
		DatagramEncryptionRandomSequence = 11
	}
	[Token(Token = "0x20000AA")]
	public static class EncryptionDataParameters
	{
		[Token(Token = "0x400036B")]
		public const byte Mode = 0;

		[Token(Token = "0x400036C")]
		public const byte Secret1 = 1;

		[Token(Token = "0x400036D")]
		public const byte Secret2 = 2;
	}
	[Token(Token = "0x20000AB")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoadBalancingPeer loadBalancingPeer;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AuthModeOption AuthMode;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public EncryptionMode EncryptionMode;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ConnectionProtocol ExpectedProtocol;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string NameServerHost;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string NameServerHttp;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private ClientState state;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool inLobby;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool autoJoinLobby;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool EnableLobbyStatistics;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Room CurrentRoom;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private JoinType lastJoinType;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool didAuthenticate;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private string[] friendListRequested;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int friendListTimestamp;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private bool isFetchingFriendList;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private byte[] encryptionSecret;

		[Token(Token = "0x170000D7")]
		public string AppVersion
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x8DF978", Offset = "0x8DF978", VA = "0x8DF978")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x8DF980", Offset = "0x8DF980", VA = "0x8DF980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public string AppId
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x8DF988", Offset = "0x8DF988", VA = "0x8DF988")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x8DF990", Offset = "0x8DF990", VA = "0x8DF990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D9")]
		public AuthenticationValues AuthValues
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x8DF998", Offset = "0x8DF998", VA = "0x8DF998")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x8DF9A0", Offset = "0x8DF9A0", VA = "0x8DF9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public ConnectionProtocol TransportProtocol
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x8DF9A8", Offset = "0x8DF9A8", VA = "0x8DF9A8")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x8DF9C4", Offset = "0x8DF9C4", VA = "0x8DF9C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x8DFAFC", Offset = "0x8DFAFC", VA = "0x8DFAFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		private string TokenForInit
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x8DFB18", Offset = "0x8DFB18", VA = "0x8DFB18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public bool IsUsingNameServer
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x8DFB38", Offset = "0x8DFB38", VA = "0x8DFB38")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x8DFB40", Offset = "0x8DFB40", VA = "0x8DFB40")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public string NameServerAddress
		{
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x8DFB4C", Offset = "0x8DFB4C", VA = "0x8DFB4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DF")]
		public string CurrentServerAddress
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x8DFCF4", Offset = "0x8DFCF4", VA = "0x8DFCF4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		public string MasterServerAddress
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x8DFD10", Offset = "0x8DFD10", VA = "0x8DFD10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x8DFD18", Offset = "0x8DFD18", VA = "0x8DFD18")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public string GameServerAddress
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x8DFD20", Offset = "0x8DFD20", VA = "0x8DFD20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x8DFD28", Offset = "0x8DFD28", VA = "0x8DFD28")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		public ServerConnection Server
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0x8DFD30", Offset = "0x8DFD30", VA = "0x8DFD30")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x8DFD38", Offset = "0x8DFD38", VA = "0x8DFD38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000E3")]
		public ClientState State
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x8DFD40", Offset = "0x8DFD40", VA = "0x8DFD40")]
			get
			{
				return default(ClientState);
			}
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0x8DFD48", Offset = "0x8DFD48", VA = "0x8DFD48")]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000E4")]
		public bool IsConnected
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0x8DFD68", Offset = "0x8DFD68", VA = "0x8DFD68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E5")]
		public bool IsConnectedAndReady
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0x8DFD94", Offset = "0x8DFD94", VA = "0x8DFD94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E6")]
		public DisconnectCause DisconnectedCause
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0x8E0088", Offset = "0x8E0088", VA = "0x8E0088")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x8E0090", Offset = "0x8E0090", VA = "0x8E0090")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public TypedLobby CurrentLobby
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x8E0098", Offset = "0x8E0098", VA = "0x8E0098")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x8E00A0", Offset = "0x8E00A0", VA = "0x8E00A0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public bool AutoJoinLobby
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x8E00A8", Offset = "0x8E00A8", VA = "0x8E00A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x8E00B0", Offset = "0x8E00B0", VA = "0x8E00B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x8E00BC", Offset = "0x8E00BC", VA = "0x8E00BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x8E00C4", Offset = "0x8E00C4", VA = "0x8E00C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000EA")]
		public Player LocalPlayer
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x8E00CC", Offset = "0x8E00CC", VA = "0x8E00CC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x8E00D4", Offset = "0x8E00D4", VA = "0x8E00D4")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000EB")]
		public string NickName
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0x8E00DC", Offset = "0x8E00DC", VA = "0x8E00DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x8E00F8", Offset = "0x8E00F8", VA = "0x8E00F8")]
			set
			{
			}
		}

		[Token(Token = "0x170000EC")]
		public string UserId
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x8E010C", Offset = "0x8E010C", VA = "0x8E010C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x8E0124", Offset = "0x8E0124", VA = "0x8E0124")]
			set
			{
			}
		}

		[Token(Token = "0x170000ED")]
		public int PlayersOnMasterCount
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x8E0194", Offset = "0x8E0194", VA = "0x8E0194")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x8E019C", Offset = "0x8E019C", VA = "0x8E019C")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000EE")]
		public int PlayersInRoomsCount
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x8E01A4", Offset = "0x8E01A4", VA = "0x8E01A4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x8E01AC", Offset = "0x8E01AC", VA = "0x8E01AC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public int RoomsCount
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x8E01B4", Offset = "0x8E01B4", VA = "0x8E01B4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x8E01BC", Offset = "0x8E01BC", VA = "0x8E01BC")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public List<FriendInfo> FriendList
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x8E01C4", Offset = "0x8E01C4", VA = "0x8E01C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x8E01CC", Offset = "0x8E01CC", VA = "0x8E01CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F1")]
		public int FriendListAge
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0x8E01D4", Offset = "0x8E01D4", VA = "0x8E01D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F2")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0x8E020C", Offset = "0x8E020C", VA = "0x8E020C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F3")]
		public string[] AvailableRegions
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x8E0234", Offset = "0x8E0234", VA = "0x8E0234")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x8E023C", Offset = "0x8E023C", VA = "0x8E023C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F4")]
		public string[] AvailableRegionsServers
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x8E0244", Offset = "0x8E0244", VA = "0x8E0244")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x8E024C", Offset = "0x8E024C", VA = "0x8E024C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public string CloudRegion
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x8E0254", Offset = "0x8E0254", VA = "0x8E0254")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x8E025C", Offset = "0x8E025C", VA = "0x8E025C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x8DDB98", Offset = "0x8DDB98", VA = "0x8DDB98")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x8DFDC8", Offset = "0x8DFDC8", VA = "0x8DFDC8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<EventData> OnEventAction
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x8DDAE8", Offset = "0x8DDAE8", VA = "0x8DDAE8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x8DFE78", Offset = "0x8DFE78", VA = "0x8DFE78")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0x8DFF28", Offset = "0x8DFF28", VA = "0x8DFF28")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x8DFFD8", Offset = "0x8DFFD8", VA = "0x8DFFD8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x8DD928", Offset = "0x8DD928", VA = "0x8DD928")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x8E0264", Offset = "0x8E0264", VA = "0x8E0264")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x8DFB50", Offset = "0x8DFB50", VA = "0x8DFB50")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x8E02A0", Offset = "0x8E02A0", VA = "0x8E02A0")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x8E034C", Offset = "0x8E034C", VA = "0x8E034C", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x8E03D4", Offset = "0x8E03D4", VA = "0x8E03D4")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x8E04C0", Offset = "0x8E04C0", VA = "0x8E04C0")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x8E064C", Offset = "0x8E064C", VA = "0x8E064C")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x8E05D4", Offset = "0x8E05D4", VA = "0x8E05D4")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x8DDC78", Offset = "0x8DDC78", VA = "0x8DDC78")]
		public void Service()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x8E06A8", Offset = "0x8E06A8", VA = "0x8E06A8")]
		private void DisconnectToReconnect()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x8E0750", Offset = "0x8E0750", VA = "0x8E0750")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x8E07D4", Offset = "0x8E07D4", VA = "0x8E07D4")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x8E0824", Offset = "0x8E0824", VA = "0x8E0824")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x8E0BCC", Offset = "0x8E0BCC", VA = "0x8E0BCC")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x8E0C64", Offset = "0x8E0C64", VA = "0x8E0C64")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x8E0C88", Offset = "0x8E0C88", VA = "0x8E0C88")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x8E0E6C", Offset = "0x8E0E6C", VA = "0x8E0E6C")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x8E0D18", Offset = "0x8E0D18", VA = "0x8E0D18")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x8E0EFC", Offset = "0x8E0EFC", VA = "0x8E0EFC")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x8E0FC8", Offset = "0x8E0FC8", VA = "0x8E0FC8")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x8E1090", Offset = "0x8E1090", VA = "0x8E1090")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x8E117C", Offset = "0x8E117C", VA = "0x8E117C")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x8E125C", Offset = "0x8E125C", VA = "0x8E125C")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x8E1268", Offset = "0x8E1268", VA = "0x8E1268")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x8E12FC", Offset = "0x8E12FC", VA = "0x8E12FC")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x8E1320", Offset = "0x8E1320", VA = "0x8E1320")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x8E161C", Offset = "0x8E161C", VA = "0x8E161C")]
		[Obsolete("Use the overload with WebFlags.")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x8E14A8", Offset = "0x8E14A8", VA = "0x8E14A8")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x8E16C4", Offset = "0x8E16C4", VA = "0x8E16C4")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x8E18A4", Offset = "0x8E18A4", VA = "0x8E18A4")]
		[Obsolete("Use the overload with WebFlags.")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x8E1758", Offset = "0x8E1758", VA = "0x8E1758")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x8E193C", Offset = "0x8E193C", VA = "0x8E193C", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x8E1958", Offset = "0x8E1958", VA = "0x8E1958", Slot = "10")]
		[Obsolete("Use OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions) instead. Parameter 'sendReliable' moved to: RaiseEventOptions.SendOptions.")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x8E19E0", Offset = "0x8E19E0", VA = "0x8E19E0", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x8E19FC", Offset = "0x8E19FC", VA = "0x8E19FC")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x8E1DF8", Offset = "0x8E1DF8", VA = "0x8E1DF8")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x8E1EF8", Offset = "0x8E1EF8", VA = "0x8E1EF8")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x8E2058", Offset = "0x8E2058", VA = "0x8E2058")]
		private void CleanCachedValues()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x8E20F8", Offset = "0x8E20F8", VA = "0x8E20F8")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x8E2348", Offset = "0x8E2348", VA = "0x8E2348")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x8E243C", Offset = "0x8E243C", VA = "0x8E243C", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x8E24C8", Offset = "0x8E24C8", VA = "0x8E24C8", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x8E253C", Offset = "0x8E253C", VA = "0x8E253C", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x8E264C", Offset = "0x8E264C", VA = "0x8E264C", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x8E3614", Offset = "0x8E3614", VA = "0x8E3614", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x8E3CB0", Offset = "0x8E3CB0", VA = "0x8E3CB0", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x8E4768", Offset = "0x8E4768", VA = "0x8E4768", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x8E3414", Offset = "0x8E3414", VA = "0x8E3414")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x8E47DC", Offset = "0x8E47DC", VA = "0x8E47DC")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AC")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Token(Token = "0x20000AD")]
		private enum RoomOptionBit
		{
			[Token(Token = "0x400039A")]
			CheckUserOnJoin = 1,
			[Token(Token = "0x400039B")]
			DeleteCacheOnLeave = 2,
			[Token(Token = "0x400039C")]
			SuppressRoomEvents = 4,
			[Token(Token = "0x400039D")]
			PublishUserId = 8,
			[Token(Token = "0x400039E")]
			DeleteNullProps = 0x10,
			[Token(Token = "0x400039F")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal static Type PingImplementation;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<byte, object> opParameters;

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x8E5A20", Offset = "0x8E5A20", VA = "0x8E5A20")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x8E5D0C", Offset = "0x8E5D0C", VA = "0x8E5D0C")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x8E5AD8", Offset = "0x8E5AD8", VA = "0x8E5AD8")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x8E5D7C", Offset = "0x8E5D7C", VA = "0x8E5D7C", Slot = "18")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x8E5E64", Offset = "0x8E5E64", VA = "0x8E5E64", Slot = "19")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x8E606C", Offset = "0x8E606C", VA = "0x8E606C", Slot = "20")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x8E6180", Offset = "0x8E6180", VA = "0x8E6180")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x8E6604", Offset = "0x8E6604", VA = "0x8E6604", Slot = "21")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x8E68C8", Offset = "0x8E68C8", VA = "0x8E68C8", Slot = "22")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x8E6BDC", Offset = "0x8E6BDC", VA = "0x8E6BDC", Slot = "23")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x8E6F04", Offset = "0x8E6F04", VA = "0x8E6F04", Slot = "24")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x8E705C", Offset = "0x8E705C", VA = "0x8E705C", Slot = "25")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x8E7344", Offset = "0x8E7344", VA = "0x8E7344", Slot = "26")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x8E7430", Offset = "0x8E7430", VA = "0x8E7430")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x8E746C", Offset = "0x8E746C", VA = "0x8E746C")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x8E77C4", Offset = "0x8E77C4", VA = "0x8E77C4")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x8E7AEC", Offset = "0x8E7AEC", VA = "0x8E7AEC")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x8E7884", Offset = "0x8E7884", VA = "0x8E7884")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x8E7B18", Offset = "0x8E7B18", VA = "0x8E7B18", Slot = "27")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x8E7E48", Offset = "0x8E7E48", VA = "0x8E7E48", Slot = "28")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x8E818C", Offset = "0x8E818C", VA = "0x8E818C", Slot = "29")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x8E8334", Offset = "0x8E8334", VA = "0x8E8334", Slot = "30")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x8E8564", Offset = "0x8E8564", VA = "0x8E8564", Slot = "31")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AE")]
	public class OpJoinRandomRoomParams
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Hashtable ExpectedCustomRoomProperties;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public byte ExpectedMaxPlayers;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public MatchmakingMode MatchingType;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby TypedLobby;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string SqlLobbyFilter;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x8E8738", Offset = "0x8E8738", VA = "0x8E8738")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class EnterRoomParams
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string RoomName;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RoomOptions RoomOptions;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TypedLobby Lobby;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Hashtable PlayerProperties;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool OnGameServer;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool CreateIfNotExists;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool RejoinOnly;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string[] ExpectedUsers;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x8E8740", Offset = "0x8E8740", VA = "0x8E8740")]
		public EnterRoomParams()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class ErrorCode
	{
		[Token(Token = "0x40003AE")]
		public const int Ok = 0;

		[Token(Token = "0x40003AF")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Token(Token = "0x40003B0")]
		[Obsolete("Use InvalidOperation.")]
		public const int InvalidOperationCode = -2;

		[Token(Token = "0x40003B1")]
		public const int InvalidOperation = -2;

		[Token(Token = "0x40003B2")]
		public const int InternalServerError = -1;

		[Token(Token = "0x40003B3")]
		public const int InvalidAuthentication = 32767;

		[Token(Token = "0x40003B4")]
		public const int GameIdAlreadyExists = 32766;

		[Token(Token = "0x40003B5")]
		public const int GameFull = 32765;

		[Token(Token = "0x40003B6")]
		public const int GameClosed = 32764;

		[Token(Token = "0x40003B7")]
		[Obsolete("No longer used, cause random matchmaking is no longer a process.")]
		public const int AlreadyMatched = 32763;

		[Token(Token = "0x40003B8")]
		public const int ServerFull = 32762;

		[Token(Token = "0x40003B9")]
		public const int UserBlocked = 32761;

		[Token(Token = "0x40003BA")]
		public const int NoRandomMatchFound = 32760;

		[Token(Token = "0x40003BB")]
		public const int GameDoesNotExist = 32758;

		[Token(Token = "0x40003BC")]
		public const int MaxCcuReached = 32757;

		[Token(Token = "0x40003BD")]
		public const int InvalidRegion = 32756;

		[Token(Token = "0x40003BE")]
		public const int CustomAuthenticationFailed = 32755;

		[Token(Token = "0x40003BF")]
		public const int AuthenticationTicketExpired = 32753;

		[Token(Token = "0x40003C0")]
		public const int PluginReportedError = 32752;

		[Token(Token = "0x40003C1")]
		public const int PluginMismatch = 32751;

		[Token(Token = "0x40003C2")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Token(Token = "0x40003C3")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Token(Token = "0x40003C4")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Token(Token = "0x40003C5")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Token(Token = "0x40003C6")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Token(Token = "0x40003C7")]
		public const int HttpLimitReached = 32745;

		[Token(Token = "0x40003C8")]
		public const int ExternalHttpCallFailed = 32744;

		[Token(Token = "0x40003C9")]
		public const int SlotError = 32742;

		[Token(Token = "0x40003CA")]
		public const int InvalidEncryptionParameters = 32741;

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x8E8750", Offset = "0x8E8750", VA = "0x8E8750")]
		public ErrorCode()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class ActorProperties
	{
		[Token(Token = "0x40003CB")]
		public const byte PlayerName = byte.MaxValue;

		[Token(Token = "0x40003CC")]
		public const byte IsInactive = 254;

		[Token(Token = "0x40003CD")]
		public const byte UserId = 253;

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x8E8758", Offset = "0x8E8758", VA = "0x8E8758")]
		public ActorProperties()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GamePropertyKey
	{
		[Token(Token = "0x40003CE")]
		public const byte MaxPlayers = byte.MaxValue;

		[Token(Token = "0x40003CF")]
		public const byte IsVisible = 254;

		[Token(Token = "0x40003D0")]
		public const byte IsOpen = 253;

		[Token(Token = "0x40003D1")]
		public const byte PlayerCount = 252;

		[Token(Token = "0x40003D2")]
		public const byte Removed = 251;

		[Token(Token = "0x40003D3")]
		public const byte PropsListedInLobby = 250;

		[Token(Token = "0x40003D4")]
		public const byte CleanupCacheOnLeave = 249;

		[Token(Token = "0x40003D5")]
		public const byte MasterClientId = 248;

		[Token(Token = "0x40003D6")]
		public const byte ExpectedUsers = 247;

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x8E8760", Offset = "0x8E8760", VA = "0x8E8760")]
		public GamePropertyKey()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class EventCode
	{
		[Token(Token = "0x40003D7")]
		public const byte GameList = 230;

		[Token(Token = "0x40003D8")]
		public const byte GameListUpdate = 229;

		[Token(Token = "0x40003D9")]
		public const byte QueueState = 228;

		[Token(Token = "0x40003DA")]
		public const byte Match = 227;

		[Token(Token = "0x40003DB")]
		public const byte AppStats = 226;

		[Token(Token = "0x40003DC")]
		public const byte LobbyStats = 224;

		[Token(Token = "0x40003DD")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x40003DE")]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x40003DF")]
		public const byte Leave = 254;

		[Token(Token = "0x40003E0")]
		public const byte PropertiesChanged = 253;

		[Token(Token = "0x40003E1")]
		[Obsolete("Use PropertiesChanged now.")]
		public const byte SetProperties = 253;

		[Token(Token = "0x40003E2")]
		public const byte ErrorInfo = 251;

		[Token(Token = "0x40003E3")]
		public const byte CacheSliceChanged = 250;

		[Token(Token = "0x40003E4")]
		public const byte AuthEvent = 223;

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x8E8768", Offset = "0x8E8768", VA = "0x8E8768")]
		public EventCode()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class ParameterCode
	{
		[Token(Token = "0x40003E5")]
		public const byte SuppressRoomEvents = 237;

		[Token(Token = "0x40003E6")]
		public const byte EmptyRoomTTL = 236;

		[Token(Token = "0x40003E7")]
		public const byte PlayerTTL = 235;

		[Token(Token = "0x40003E8")]
		public const byte EventForward = 234;

		[Token(Token = "0x40003E9")]
		[Obsolete("Use: IsInactive")]
		public const byte IsComingBack = 233;

		[Token(Token = "0x40003EA")]
		public const byte IsInactive = 233;

		[Token(Token = "0x40003EB")]
		public const byte CheckUserOnJoin = 232;

		[Token(Token = "0x40003EC")]
		public const byte ExpectedValues = 231;

		[Token(Token = "0x40003ED")]
		public const byte Address = 230;

		[Token(Token = "0x40003EE")]
		public const byte PeerCount = 229;

		[Token(Token = "0x40003EF")]
		public const byte GameCount = 228;

		[Token(Token = "0x40003F0")]
		public const byte MasterPeerCount = 227;

		[Token(Token = "0x40003F1")]
		public const byte UserId = 225;

		[Token(Token = "0x40003F2")]
		public const byte ApplicationId = 224;

		[Token(Token = "0x40003F3")]
		public const byte Position = 223;

		[Token(Token = "0x40003F4")]
		public const byte MatchMakingType = 223;

		[Token(Token = "0x40003F5")]
		public const byte GameList = 222;

		[Token(Token = "0x40003F6")]
		public const byte Secret = 221;

		[Token(Token = "0x40003F7")]
		public const byte AppVersion = 220;

		[Token(Token = "0x40003F8")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureNodeInfo = 210;

		[Token(Token = "0x40003F9")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureLocalNodeId = 209;

		[Token(Token = "0x40003FA")]
		[Obsolete("TCP routing was removed after becoming obsolete.")]
		public const byte AzureMasterNodeId = 208;

		[Token(Token = "0x40003FB")]
		public const byte RoomName = byte.MaxValue;

		[Token(Token = "0x40003FC")]
		public const byte Broadcast = 250;

		[Token(Token = "0x40003FD")]
		public const byte ActorList = 252;

		[Token(Token = "0x40003FE")]
		public const byte ActorNr = 254;

		[Token(Token = "0x40003FF")]
		public const byte PlayerProperties = 249;

		[Token(Token = "0x4000400")]
		public const byte CustomEventContent = 245;

		[Token(Token = "0x4000401")]
		public const byte Data = 245;

		[Token(Token = "0x4000402")]
		public const byte Code = 244;

		[Token(Token = "0x4000403")]
		public const byte GameProperties = 248;

		[Token(Token = "0x4000404")]
		public const byte Properties = 251;

		[Token(Token = "0x4000405")]
		public const byte TargetActorNr = 253;

		[Token(Token = "0x4000406")]
		public const byte ReceiverGroup = 246;

		[Token(Token = "0x4000407")]
		public const byte Cache = 247;

		[Token(Token = "0x4000408")]
		public const byte CleanupCacheOnLeave = 241;

		[Token(Token = "0x4000409")]
		public const byte Group = 240;

		[Token(Token = "0x400040A")]
		public const byte Remove = 239;

		[Token(Token = "0x400040B")]
		public const byte PublishUserId = 239;

		[Token(Token = "0x400040C")]
		public const byte Add = 238;

		[Token(Token = "0x400040D")]
		public const byte Info = 218;

		[Token(Token = "0x400040E")]
		public const byte ClientAuthenticationType = 217;

		[Token(Token = "0x400040F")]
		public const byte ClientAuthenticationParams = 216;

		[Token(Token = "0x4000410")]
		public const byte JoinMode = 215;

		[Token(Token = "0x4000411")]
		public const byte ClientAuthenticationData = 214;

		[Token(Token = "0x4000412")]
		public const byte MasterClientId = 203;

		[Token(Token = "0x4000413")]
		public const byte FindFriendsRequestList = 1;

		[Token(Token = "0x4000414")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Token(Token = "0x4000415")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Token(Token = "0x4000416")]
		public const byte LobbyName = 213;

		[Token(Token = "0x4000417")]
		public const byte LobbyType = 212;

		[Token(Token = "0x4000418")]
		public const byte LobbyStats = 211;

		[Token(Token = "0x4000419")]
		public const byte Region = 210;

		[Token(Token = "0x400041A")]
		public const byte UriPath = 209;

		[Token(Token = "0x400041B")]
		public const byte WebRpcParameters = 208;

		[Token(Token = "0x400041C")]
		public const byte WebRpcReturnCode = 207;

		[Token(Token = "0x400041D")]
		public const byte WebRpcReturnMessage = 206;

		[Token(Token = "0x400041E")]
		public const byte CacheSliceIndex = 205;

		[Token(Token = "0x400041F")]
		public const byte Plugins = 204;

		[Token(Token = "0x4000420")]
		public const byte NickName = 202;

		[Token(Token = "0x4000421")]
		public const byte PluginName = 201;

		[Token(Token = "0x4000422")]
		public const byte PluginVersion = 200;

		[Token(Token = "0x4000423")]
		public const byte ExpectedProtocol = 195;

		[Token(Token = "0x4000424")]
		public const byte CustomInitData = 194;

		[Token(Token = "0x4000425")]
		public const byte EncryptionMode = 193;

		[Token(Token = "0x4000426")]
		public const byte EncryptionData = 192;

		[Token(Token = "0x4000427")]
		public const byte RoomOptionFlags = 191;

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x8E8770", Offset = "0x8E8770", VA = "0x8E8770")]
		public ParameterCode()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class OperationCode
	{
		[Token(Token = "0x4000428")]
		[Obsolete("Exchanging encrpytion keys is done internally in the lib now. Don't expect this operation-result.")]
		public const byte ExchangeKeysForEncryption = 250;

		[Token(Token = "0x4000429")]
		[Obsolete]
		public const byte Join = byte.MaxValue;

		[Token(Token = "0x400042A")]
		public const byte AuthenticateOnce = 231;

		[Token(Token = "0x400042B")]
		public const byte Authenticate = 230;

		[Token(Token = "0x400042C")]
		public const byte JoinLobby = 229;

		[Token(Token = "0x400042D")]
		public const byte LeaveLobby = 228;

		[Token(Token = "0x400042E")]
		public const byte CreateGame = 227;

		[Token(Token = "0x400042F")]
		public const byte JoinGame = 226;

		[Token(Token = "0x4000430")]
		public const byte JoinRandomGame = 225;

		[Token(Token = "0x4000431")]
		public const byte Leave = 254;

		[Token(Token = "0x4000432")]
		public const byte RaiseEvent = 253;

		[Token(Token = "0x4000433")]
		public const byte SetProperties = 252;

		[Token(Token = "0x4000434")]
		public const byte GetProperties = 251;

		[Token(Token = "0x4000435")]
		public const byte ChangeGroups = 248;

		[Token(Token = "0x4000436")]
		public const byte FindFriends = 222;

		[Token(Token = "0x4000437")]
		public const byte GetLobbyStats = 221;

		[Token(Token = "0x4000438")]
		public const byte GetRegions = 220;

		[Token(Token = "0x4000439")]
		public const byte WebRpc = 219;

		[Token(Token = "0x400043A")]
		public const byte ServerSettings = 218;

		[Token(Token = "0x400043B")]
		public const byte GetGameList = 217;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x8E8778", Offset = "0x8E8778", VA = "0x8E8778")]
		public OperationCode()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public enum JoinMode : byte
	{
		[Token(Token = "0x400043D")]
		Default,
		[Token(Token = "0x400043E")]
		CreateIfNotExists,
		[Token(Token = "0x400043F")]
		JoinOrRejoin,
		[Token(Token = "0x4000440")]
		RejoinOnly
	}
	[Token(Token = "0x20000B7")]
	public enum MatchmakingMode : byte
	{
		[Token(Token = "0x4000442")]
		FillRoom,
		[Token(Token = "0x4000443")]
		SerialMatching,
		[Token(Token = "0x4000444")]
		RandomMatching
	}
	[Token(Token = "0x20000B8")]
	public enum ReceiverGroup : byte
	{
		[Token(Token = "0x4000446")]
		Others,
		[Token(Token = "0x4000447")]
		All,
		[Token(Token = "0x4000448")]
		MasterClient
	}
	[Token(Token = "0x20000B9")]
	public enum EventCaching : byte
	{
		[Token(Token = "0x400044A")]
		DoNotCache = 0,
		[Token(Token = "0x400044B")]
		[Obsolete]
		MergeCache = 1,
		[Token(Token = "0x400044C")]
		[Obsolete]
		ReplaceCache = 2,
		[Token(Token = "0x400044D")]
		[Obsolete]
		RemoveCache = 3,
		[Token(Token = "0x400044E")]
		AddToRoomCache = 4,
		[Token(Token = "0x400044F")]
		AddToRoomCacheGlobal = 5,
		[Token(Token = "0x4000450")]
		RemoveFromRoomCache = 6,
		[Token(Token = "0x4000451")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Token(Token = "0x4000452")]
		SliceIncreaseIndex = 10,
		[Token(Token = "0x4000453")]
		SliceSetIndex = 11,
		[Token(Token = "0x4000454")]
		SlicePurgeIndex = 12,
		[Token(Token = "0x4000455")]
		SlicePurgeUpToIndex = 13
	}
	[Token(Token = "0x20000BA")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Token(Token = "0x4000457")]
		None = 0,
		[Token(Token = "0x4000458")]
		Game = 1,
		[Token(Token = "0x4000459")]
		Actor = 2,
		[Token(Token = "0x400045A")]
		GameAndActor = 3
	}
	[Token(Token = "0x20000BB")]
	public class RoomOptions
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool isVisible;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool isOpen;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public byte MaxPlayers;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int PlayerTtl;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int EmptyRoomTtl;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool cleanupCacheOnLeave;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Hashtable CustomRoomProperties;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] CustomRoomPropertiesForLobby;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string[] Plugins;

		[Token(Token = "0x170000F6")]
		public bool IsVisible
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x8E8780", Offset = "0x8E8780", VA = "0x8E8780")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x8E8788", Offset = "0x8E8788", VA = "0x8E8788")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool IsOpen
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x8E8794", Offset = "0x8E8794", VA = "0x8E8794")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x8E879C", Offset = "0x8E879C", VA = "0x8E879C")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public bool CleanupCacheOnLeave
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x8E87A8", Offset = "0x8E87A8", VA = "0x8E87A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x8E87B0", Offset = "0x8E87B0", VA = "0x8E87B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000F9")]
		public bool SuppressRoomEvents
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x8E87BC", Offset = "0x8E87BC", VA = "0x8E87BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x8E87C4", Offset = "0x8E87C4", VA = "0x8E87C4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public bool PublishUserId
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x8E87D0", Offset = "0x8E87D0", VA = "0x8E87D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x8E87D8", Offset = "0x8E87D8", VA = "0x8E87D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public bool DeleteNullProperties
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x8E87E4", Offset = "0x8E87E4", VA = "0x8E87E4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x8E87EC", Offset = "0x8E87EC", VA = "0x8E87EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x8E659C", Offset = "0x8E659C", VA = "0x8E659C")]
		public RoomOptions()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public class RaiseEventOptions
	{
		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly RaiseEventOptions Default;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventCaching CachingOption;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public byte InterestGroup;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] TargetActors;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReceiverGroup Receivers;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[Obsolete("Not used where SendOptions are a parameter too. Use SendOptions.Channel instead.")]
		public byte SequenceChannel;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WebFlags Flags;

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x8E87F8", Offset = "0x8E87F8", VA = "0x8E87F8")]
		public RaiseEventOptions()
		{
		}
	}
	[Token(Token = "0x20000BD")]
	public enum LobbyType : byte
	{
		[Token(Token = "0x400046F")]
		Default = 0,
		[Token(Token = "0x4000470")]
		SqlLobby = 2,
		[Token(Token = "0x4000471")]
		AsyncRandomLobby = 3
	}
	[Token(Token = "0x20000BE")]
	public class TypedLobby
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LobbyType Type;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly TypedLobby Default;

		[Token(Token = "0x170000FC")]
		public bool IsDefault
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x8E6050", Offset = "0x8E6050", VA = "0x8E6050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x8E88C0", Offset = "0x8E88C0", VA = "0x8E88C0")]
		public TypedLobby()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x8E8920", Offset = "0x8E8920", VA = "0x8E8920")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x8E8950", Offset = "0x8E8950", VA = "0x8E8950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000BF")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int PlayerCount;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RoomCount;

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x8E8A3C", Offset = "0x8E8A3C", VA = "0x8E8A3C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x8E8BE8", Offset = "0x8E8BE8", VA = "0x8E8BE8")]
		public TypedLobbyInfo()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public enum AuthModeOption
	{
		[Token(Token = "0x4000478")]
		Auth,
		[Token(Token = "0x4000479")]
		AuthOnce,
		[Token(Token = "0x400047A")]
		AuthOnceWss
	}
	[Token(Token = "0x20000C1")]
	public enum CustomAuthenticationType : byte
	{
		[Token(Token = "0x400047C")]
		Custom = 0,
		[Token(Token = "0x400047D")]
		Steam = 1,
		[Token(Token = "0x400047E")]
		Facebook = 2,
		[Token(Token = "0x400047F")]
		Oculus = 3,
		[Token(Token = "0x4000480")]
		PlayStation = 4,
		[Token(Token = "0x4000481")]
		Xbox = 5,
		[Token(Token = "0x4000482")]
		None = byte.MaxValue
	}
	[Token(Token = "0x20000C2")]
	public class AuthenticationValues
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CustomAuthenticationType authType;

		[Token(Token = "0x170000FD")]
		public CustomAuthenticationType AuthType
		{
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x8E8C3C", Offset = "0x8E8C3C", VA = "0x8E8C3C")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x8E8C44", Offset = "0x8E8C44", VA = "0x8E8C44")]
			set
			{
			}
		}

		[Token(Token = "0x170000FE")]
		public string AuthGetParameters
		{
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x8E8C4C", Offset = "0x8E8C4C", VA = "0x8E8C4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x8E8C54", Offset = "0x8E8C54", VA = "0x8E8C54")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public object AuthPostData
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x8E8C5C", Offset = "0x8E8C5C", VA = "0x8E8C5C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x8E8C64", Offset = "0x8E8C64", VA = "0x8E8C64")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public string Token
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x8E8C6C", Offset = "0x8E8C6C", VA = "0x8E8C6C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x8E8C74", Offset = "0x8E8C74", VA = "0x8E8C74")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public string UserId
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x8E8C7C", Offset = "0x8E8C7C", VA = "0x8E8C7C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000652")]
			[Address(RVA = "0x8E8C84", Offset = "0x8E8C84", VA = "0x8E8C84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x8E8C8C", Offset = "0x8E8C8C", VA = "0x8E8C8C")]
		public AuthenticationValues()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x8E8C9C", Offset = "0x8E8C9C", VA = "0x8E8C9C")]
		public AuthenticationValues(string userId)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x8E8CCC", Offset = "0x8E8CCC", VA = "0x8E8CCC", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x8E8D08", Offset = "0x8E8D08", VA = "0x8E8D08", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x8E8D10", Offset = "0x8E8D10", VA = "0x8E8D10", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x8E8EDC", Offset = "0x8E8EDC", VA = "0x8E8EDC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C3")]
	public abstract class PhotonPing : IDisposable
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string DebugString;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Successful;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected internal bool GotResult;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected internal int PingLength;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected internal byte[] PingBytes;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected internal byte PingId;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x8E8F74", Offset = "0x8E8F74", VA = "0x8E8F74", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x8E8FB4", Offset = "0x8E8FB4", VA = "0x8E8FB4", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x8E8FF4", Offset = "0x8E8FF4", VA = "0x8E8FF4", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x8E9034", Offset = "0x8E9034", VA = "0x8E9034")]
		protected internal void Init()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x8E9074", Offset = "0x8E9074", VA = "0x8E9074")]
		protected PhotonPing()
		{
		}
	}
	[Token(Token = "0x20000C4")]
	public class PingMono : PhotonPing
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Socket sock;

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x8E911C", Offset = "0x8E911C", VA = "0x8E911C", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x8E9394", Offset = "0x8E9394", VA = "0x8E9394", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x8E94BC", Offset = "0x8E94BC", VA = "0x8E94BC", Slot = "7")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x8E955C", Offset = "0x8E955C", VA = "0x8E955C")]
		public PingMono()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class Player
	{
		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int actorID;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public readonly bool IsLocal;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string nickName;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object TagObject;

		[Token(Token = "0x17000102")]
		protected internal Room RoomReference
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x8E9560", Offset = "0x8E9560", VA = "0x8E9560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x8E9568", Offset = "0x8E9568", VA = "0x8E9568")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public int ID
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x8E9570", Offset = "0x8E9570", VA = "0x8E9570")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000104")]
		public string NickName
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x8E9578", Offset = "0x8E9578", VA = "0x8E9578")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x8E9580", Offset = "0x8E9580", VA = "0x8E9580")]
			set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public string UserId
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x8E96D0", Offset = "0x8E96D0", VA = "0x8E96D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x8E96D8", Offset = "0x8E96D8", VA = "0x8E96D8")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public bool IsMasterClient
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x8E96E0", Offset = "0x8E96E0", VA = "0x8E96E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000107")]
		public bool IsInactive
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x8E9704", Offset = "0x8E9704", VA = "0x8E9704")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x8E970C", Offset = "0x8E970C", VA = "0x8E970C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x8E9718", Offset = "0x8E9718", VA = "0x8E9718")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x8E9720", Offset = "0x8E9720", VA = "0x8E9720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public Hashtable AllProperties
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x8E9728", Offset = "0x8E9728", VA = "0x8E9728")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x8E97DC", Offset = "0x8E97DC", VA = "0x8E97DC")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x8E97E8", Offset = "0x8E97E8", VA = "0x8E97E8")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8E98A0", Offset = "0x8E98A0", VA = "0x8E98A0")]
		public Player Get(int id)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8E98B8", Offset = "0x8E98B8", VA = "0x8E98B8")]
		public Player GetNext()
		{
			return null;
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8E9ABC", Offset = "0x8E9ABC", VA = "0x8E9ABC")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x8E98C0", Offset = "0x8E98C0", VA = "0x8E98C0")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x8E9AD0", Offset = "0x8E9AD0", VA = "0x8E9AD0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x8E9D38", Offset = "0x8E9D38", VA = "0x8E9D38", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x8E9DC0", Offset = "0x8E9DC0", VA = "0x8E9DC0")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x8E9F6C", Offset = "0x8E9F6C", VA = "0x8E9F6C", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x8EA020", Offset = "0x8EA020", VA = "0x8EA020", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x8EA028", Offset = "0x8EA028", VA = "0x8EA028")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x8EA038", Offset = "0x8EA038", VA = "0x8EA038")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x8E95F4", Offset = "0x8E95F4", VA = "0x8E95F4")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class Room : RoomInfo
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected internal int PlayerTTL;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		protected internal int RoomTTL;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<int, Player> players;

		[Token(Token = "0x1700010A")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x8EA124", Offset = "0x8EA124", VA = "0x8EA124")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x8EA12C", Offset = "0x8EA12C", VA = "0x8EA12C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public new string Name
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x8EA134", Offset = "0x8EA134", VA = "0x8EA134")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x8EA13C", Offset = "0x8EA13C", VA = "0x8EA13C")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public new bool IsOpen
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x8EA144", Offset = "0x8EA144", VA = "0x8EA144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000682")]
			[Address(RVA = "0x8EA14C", Offset = "0x8EA14C", VA = "0x8EA14C")]
			set
			{
			}
		}

		[Token(Token = "0x1700010D")]
		public new bool IsVisible
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0x8EA2B0", Offset = "0x8EA2B0", VA = "0x8EA2B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000684")]
			[Address(RVA = "0x8EA2B8", Offset = "0x8EA2B8", VA = "0x8EA2B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public new byte MaxPlayers
		{
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x8EA41C", Offset = "0x8EA41C", VA = "0x8EA41C")]
			get
			{
				return default(byte);
			}
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x8EA424", Offset = "0x8EA424", VA = "0x8EA424")]
			set
			{
			}
		}

		[Token(Token = "0x1700010F")]
		public new byte PlayerCount
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x8EA56C", Offset = "0x8EA56C", VA = "0x8EA56C")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000110")]
		public Dictionary<int, Player> Players
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x8EA5BC", Offset = "0x8EA5BC", VA = "0x8EA5BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x8EA5C4", Offset = "0x8EA5C4", VA = "0x8EA5C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000111")]
		public string[] ExpectedUsers
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x8EA5CC", Offset = "0x8EA5CC", VA = "0x8EA5CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		public int MasterClientId
		{
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x8EA5D4", Offset = "0x8EA5D4", VA = "0x8EA5D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000113")]
		public string[] PropertiesListedInLobby
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x8EA5DC", Offset = "0x8EA5DC", VA = "0x8EA5DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x8EA5E4", Offset = "0x8EA5E4", VA = "0x8EA5E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public bool AutoCleanUp
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x8EA5EC", Offset = "0x8EA5EC", VA = "0x8EA5EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x8EA5F4", Offset = "0x8EA5F4", VA = "0x8EA5F4")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x8EA774", Offset = "0x8EA774", VA = "0x8EA774", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x8EA840", Offset = "0x8EA840", VA = "0x8EA840")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x8EA908", Offset = "0x8EA908", VA = "0x8EA908", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x8EA96C", Offset = "0x8EA96C", VA = "0x8EA96C", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x8EA998", Offset = "0x8EA998", VA = "0x8EA998")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x8EAB54", Offset = "0x8EAB54", VA = "0x8EAB54", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x8EABD8", Offset = "0x8EABD8", VA = "0x8EABD8", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x8EAC5C", Offset = "0x8EAC5C", VA = "0x8EAC5C", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x8EACCC", Offset = "0x8EACCC", VA = "0x8EACCC")]
		public void ClearExpectedUsers()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x8EADF4", Offset = "0x8EADF4", VA = "0x8EADF4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x8EB018", Offset = "0x8EB018", VA = "0x8EB018")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C7")]
	public class RoomInfo
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected internal bool removedFromList;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Hashtable customProperties;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected byte maxPlayers;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected string[] expectedUsers;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool isOpen;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool isVisible;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		protected bool autoCleanUp;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected string name;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected internal int masterClientId;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected string[] propertiesListedInLobby;

		[Token(Token = "0x17000115")]
		public Hashtable CustomProperties
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x8EB274", Offset = "0x8EB274", VA = "0x8EB274")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		public string Name
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x8EB27C", Offset = "0x8EB27C", VA = "0x8EB27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000117")]
		public int PlayerCount
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x8EB284", Offset = "0x8EB284", VA = "0x8EB284")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x8EB28C", Offset = "0x8EB28C", VA = "0x8EB28C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000118")]
		public bool IsLocalClientInside
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x8EB294", Offset = "0x8EB294", VA = "0x8EB294")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x8EB29C", Offset = "0x8EB29C", VA = "0x8EB29C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000119")]
		public byte MaxPlayers
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x8EB2A8", Offset = "0x8EB2A8", VA = "0x8EB2A8")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x1700011A")]
		public bool IsOpen
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x8EB2B0", Offset = "0x8EB2B0", VA = "0x8EB2B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700011B")]
		public bool IsVisible
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x8EB2B8", Offset = "0x8EB2B8", VA = "0x8EB2B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x8EA6D0", Offset = "0x8EA6D0", VA = "0x8EA6D0")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x8EB2C0", Offset = "0x8EB2C0", VA = "0x8EB2C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x8EB360", Offset = "0x8EB360", VA = "0x8EB360", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x8EB380", Offset = "0x8EB380", VA = "0x8EB380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x8EB5A8", Offset = "0x8EB5A8", VA = "0x8EB5A8")]
		public string ToStringFull()
		{
			return null;
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x8EB808", Offset = "0x8EB808", VA = "0x8EB808", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class WebRpcResponse
	{
		[Token(Token = "0x1700011C")]
		public string Name
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x8EBD14", Offset = "0x8EBD14", VA = "0x8EBD14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x8EBD1C", Offset = "0x8EBD1C", VA = "0x8EBD1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public int ReturnCode
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x8EBD24", Offset = "0x8EBD24", VA = "0x8EBD24")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x8EBD2C", Offset = "0x8EBD2C", VA = "0x8EBD2C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011E")]
		public string DebugMessage
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x8EBD34", Offset = "0x8EBD34", VA = "0x8EBD34")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x8EBD3C", Offset = "0x8EBD3C", VA = "0x8EBD3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public Dictionary<string, object> Parameters
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x8EBD44", Offset = "0x8EBD44", VA = "0x8EBD44")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x8EBD4C", Offset = "0x8EBD4C", VA = "0x8EBD4C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x8EBD54", Offset = "0x8EBD54", VA = "0x8EBD54")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x8EBF04", Offset = "0x8EBF04", VA = "0x8EBF04")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C9")]
	public class WebFlags
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly WebFlags Default;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public byte WebhookFlags;

		[Token(Token = "0x40004AD")]
		public const byte HttpForwardConst = 1;

		[Token(Token = "0x40004AE")]
		public const byte SendAuthCookieConst = 2;

		[Token(Token = "0x40004AF")]
		public const byte SendSyncConst = 4;

		[Token(Token = "0x40004B0")]
		public const byte SendStateConst = 8;

		[Token(Token = "0x17000120")]
		public bool HttpForward
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x8E77B8", Offset = "0x8E77B8", VA = "0x8E77B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x8EC0A0", Offset = "0x8EC0A0", VA = "0x8EC0A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public bool SendAuthCookie
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x8EC0BC", Offset = "0x8EC0BC", VA = "0x8EC0BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x8EC0C8", Offset = "0x8EC0C8", VA = "0x8EC0C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000122")]
		public bool SendSync
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x8EC0E4", Offset = "0x8EC0E4", VA = "0x8EC0E4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x8EC0F0", Offset = "0x8EC0F0", VA = "0x8EC0F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000123")]
		public bool SendState
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x8EC10C", Offset = "0x8EC10C", VA = "0x8EC10C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x8EC118", Offset = "0x8EC118", VA = "0x8EC118")]
			set
			{
			}
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x8EC134", Offset = "0x8EC134", VA = "0x8EC134")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
namespace DentedPixel
{
	[Token(Token = "0x20000CA")]
	public class LeanDummy
	{
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x8EC1C4", Offset = "0x8EC1C4", VA = "0x8EC1C4")]
		public LeanDummy()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x20000CB")]
	[AddComponentMenu("Dark Tonic/Master Audio/Ambient Sound")]
	[AudioScriptOrder(-20)]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("This option is useful if your caller ever moves, as it will make the Audio Source follow to the location of the caller every frame.")]
		public bool FollowCaller;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Tooltip("Using this option, the Audio Source will be updated every frame to the closest position on the caller's collider, if any. This will override the Follow Caller option above and happen instead.")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
		public Transform RuntimeFollower;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000124")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x8EC7DC", Offset = "0x8EC7DC", VA = "0x8EC7DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000125")]
		public Transform Trans
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x8EC864", Offset = "0x8EC864", VA = "0x8EC864")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x8EC1CC", Offset = "0x8EC1CC", VA = "0x8EC1CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x8EC600", Offset = "0x8EC600", VA = "0x8EC600")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x8EC8E4", Offset = "0x8EC8E4", VA = "0x8EC8E4")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x8EC9C4", Offset = "0x8EC9C4", VA = "0x8EC9C4")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x8ECB88", Offset = "0x8ECB88", VA = "0x8ECB88")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x8ECDD4", Offset = "0x8ECDD4", VA = "0x8ECDD4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x8ECFEC", Offset = "0x8ECFEC", VA = "0x8ECFEC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x8EC1D0", Offset = "0x8EC1D0", VA = "0x8EC1D0")]
		private void StartTrackers()
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x8ED204", Offset = "0x8ED204", VA = "0x8ED204")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[AddComponentMenu("Dark Tonic/Master Audio/Button Clicker")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x40004C1")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x40004C2")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x8ED2A0", Offset = "0x8ED2A0", VA = "0x8ED2A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x8ED4E0", Offset = "0x8ED4E0", VA = "0x8ED4E0")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x8ED708", Offset = "0x8ED708", VA = "0x8ED708")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x8ED798", Offset = "0x8ED798", VA = "0x8ED798")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x8ED9C0", Offset = "0x8ED9C0", VA = "0x8ED9C0")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	[AddComponentMenu("Dark Tonic/Master Audio/Event Sounds")]
	[AudioScriptOrder(-30)]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x20000CE")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x4000546")]
			Legacy,
			[Token(Token = "0x4000547")]
			uGUI
		}

		[Token(Token = "0x20000CF")]
		public enum EventType
		{
			[Token(Token = "0x4000549")]
			OnStart,
			[Token(Token = "0x400054A")]
			OnVisible,
			[Token(Token = "0x400054B")]
			OnInvisible,
			[Token(Token = "0x400054C")]
			OnCollision,
			[Token(Token = "0x400054D")]
			OnTriggerEnter,
			[Token(Token = "0x400054E")]
			OnTriggerExit,
			[Token(Token = "0x400054F")]
			OnMouseEnter,
			[Token(Token = "0x4000550")]
			OnMouseClick,
			[Token(Token = "0x4000551")]
			OnSpawned,
			[Token(Token = "0x4000552")]
			OnDespawned,
			[Token(Token = "0x4000553")]
			OnEnable,
			[Token(Token = "0x4000554")]
			OnDisable,
			[Token(Token = "0x4000555")]
			OnCollision2D,
			[Token(Token = "0x4000556")]
			OnTriggerEnter2D,
			[Token(Token = "0x4000557")]
			OnTriggerExit2D,
			[Token(Token = "0x4000558")]
			OnParticleCollision,
			[Token(Token = "0x4000559")]
			UserDefinedEvent,
			[Token(Token = "0x400055A")]
			OnCollisionExit,
			[Token(Token = "0x400055B")]
			OnCollisionExit2D,
			[Token(Token = "0x400055C")]
			OnMouseUp,
			[Token(Token = "0x400055D")]
			OnMouseExit,
			[Token(Token = "0x400055E")]
			OnMouseDrag,
			[Token(Token = "0x400055F")]
			NGUIOnClick,
			[Token(Token = "0x4000560")]
			NGUIMouseDown,
			[Token(Token = "0x4000561")]
			NGUIMouseUp,
			[Token(Token = "0x4000562")]
			NGUIMouseEnter,
			[Token(Token = "0x4000563")]
			NGUIMouseExit,
			[Token(Token = "0x4000564")]
			MechanimStateChanged,
			[Token(Token = "0x4000565")]
			UnitySliderChanged,
			[Token(Token = "0x4000566")]
			UnityButtonClicked,
			[Token(Token = "0x4000567")]
			UnityPointerDown,
			[Token(Token = "0x4000568")]
			UnityPointerUp,
			[Token(Token = "0x4000569")]
			UnityPointerEnter,
			[Token(Token = "0x400056A")]
			UnityPointerExit,
			[Token(Token = "0x400056B")]
			UnityDrag,
			[Token(Token = "0x400056C")]
			UnityDrop,
			[Token(Token = "0x400056D")]
			UnityScroll,
			[Token(Token = "0x400056E")]
			UnityUpdateSelected,
			[Token(Token = "0x400056F")]
			UnitySelect,
			[Token(Token = "0x4000570")]
			UnityDeselect,
			[Token(Token = "0x4000571")]
			UnityMove,
			[Token(Token = "0x4000572")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x4000573")]
			UnityBeginDrag,
			[Token(Token = "0x4000574")]
			UnityEndDrag,
			[Token(Token = "0x4000575")]
			UnitySubmit,
			[Token(Token = "0x4000576")]
			UnityCancel,
			[Token(Token = "0x4000577")]
			UnityToggle,
			[Token(Token = "0x4000578")]
			OnTriggerStay,
			[Token(Token = "0x4000579")]
			OnTriggerStay2D
		}

		[Token(Token = "0x20000D0")]
		public enum GlidePitchType
		{
			[Token(Token = "0x400057B")]
			None,
			[Token(Token = "0x400057C")]
			RaisePitch,
			[Token(Token = "0x400057D")]
			LowerPitch
		}

		[Token(Token = "0x20000D1")]
		public enum VariationType
		{
			[Token(Token = "0x400057F")]
			PlaySpecific,
			[Token(Token = "0x4000580")]
			PlayRandom
		}

		[Token(Token = "0x20000D2")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x4000582")]
			None,
			[Token(Token = "0x4000583")]
			Stop,
			[Token(Token = "0x4000584")]
			FadeOut
		}

		[Token(Token = "0x20000D3")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x4000586")]
			None,
			[Token(Token = "0x4000587")]
			FrameBased,
			[Token(Token = "0x4000588")]
			TimeBased
		}

		[Token(Token = "0x20000D4")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x8F3F20", Offset = "0x8F3F20", VA = "0x8F3F20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x8F3F68", Offset = "0x8F3F68", VA = "0x8F3F68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x8EE038", Offset = "0x8EE038", VA = "0x8EE038")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x8F3D98", Offset = "0x8F3D98", VA = "0x8F3D98", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x8F3D9C", Offset = "0x8F3D9C", VA = "0x8F3D9C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000718")]
			[Address(RVA = "0x8F3F28", Offset = "0x8F3F28", VA = "0x8F3F28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x17000126")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x60006F9")]
			[Address(RVA = "0x8EDB8C", Offset = "0x8EDB8C", VA = "0x8EDB8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000127")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x8EFF44", Offset = "0x8EFF44", VA = "0x8EFF44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x8EDA94", Offset = "0x8EDA94", VA = "0x8EDA94")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x8EDE24", Offset = "0x8EDE24", VA = "0x8EDE24", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x8EDFD0", Offset = "0x8EDFD0", VA = "0x8EDFD0")]
		[IteratorStateMachine(typeof(<CoUpdate>d__123))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x8EE060", Offset = "0x8EE060", VA = "0x8EE060")]
		private void Start()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x8EE6B4", Offset = "0x8EE6B4", VA = "0x8EE6B4")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x8EE6DC", Offset = "0x8EE6DC", VA = "0x8EE6DC")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x8EE6F8", Offset = "0x8EE6F8", VA = "0x8EE6F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x8EE97C", Offset = "0x8EE97C", VA = "0x8EE97C")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x8EED24", Offset = "0x8EED24", VA = "0x8EED24")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x8EF0FC", Offset = "0x8EF0FC", VA = "0x8EF0FC")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x8EF240", Offset = "0x8EF240", VA = "0x8EF240")]
		private void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x8EF338", Offset = "0x8EF338", VA = "0x8EF338")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x8EF44C", Offset = "0x8EF44C", VA = "0x8EF44C")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x8EF558", Offset = "0x8EF558", VA = "0x8EF558")]
		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x8EF664", Offset = "0x8EF664", VA = "0x8EF664")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x8EF770", Offset = "0x8EF770", VA = "0x8EF770")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x8EF87C", Offset = "0x8EF87C", VA = "0x8EF87C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x8EF9C0", Offset = "0x8EF9C0", VA = "0x8EF9C0")]
		private void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x8EFAB8", Offset = "0x8EFAB8", VA = "0x8EFAB8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x8EFBCC", Offset = "0x8EFBCC", VA = "0x8EFBCC")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x8EFCD8", Offset = "0x8EFCD8", VA = "0x8EFCD8")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x8EFCF8", Offset = "0x8EFCF8", VA = "0x8EFCF8")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x8EFD18", Offset = "0x8EFD18", VA = "0x8EFD18")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x8EFD38", Offset = "0x8EFD38", VA = "0x8EFD38")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x8EFD58", Offset = "0x8EFD58", VA = "0x8EFD58")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x8EFD5C", Offset = "0x8EFD5C", VA = "0x8EFD5C")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x8EFD7C", Offset = "0x8EFD7C", VA = "0x8EFD7C")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x8EFD80", Offset = "0x8EFD80", VA = "0x8EFD80")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x8EFDA0", Offset = "0x8EFDA0", VA = "0x8EFDA0")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x8EFDC0", Offset = "0x8EFDC0", VA = "0x8EFDC0")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x8EFDE0", Offset = "0x8EFDE0", VA = "0x8EFDE0")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x8EFDE4", Offset = "0x8EFDE4", VA = "0x8EFDE4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x8EFE04", Offset = "0x8EFE04", VA = "0x8EFE04")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x8EFE24", Offset = "0x8EFE24", VA = "0x8EFE24")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x8EFE44", Offset = "0x8EFE44", VA = "0x8EFE44")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x8EFE64", Offset = "0x8EFE64", VA = "0x8EFE64")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x8EFE84", Offset = "0x8EFE84", VA = "0x8EFE84")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x8EFEA4", Offset = "0x8EFEA4", VA = "0x8EFEA4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x8EFEC4", Offset = "0x8EFEC4", VA = "0x8EFEC4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x8EFEE4", Offset = "0x8EFEE4", VA = "0x8EFEE4")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x8EFF14", Offset = "0x8EFF14", VA = "0x8EFF14")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x8EFF2C", Offset = "0x8EFF2C", VA = "0x8EFF2C")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x8EFF54", Offset = "0x8EFF54", VA = "0x8EFF54")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x8EFF8C", Offset = "0x8EFF8C", VA = "0x8EFF8C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x8EFFAC", Offset = "0x8EFFAC", VA = "0x8EFFAC")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x8EFFE4", Offset = "0x8EFFE4", VA = "0x8EFFE4")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x8F0024", Offset = "0x8F0024", VA = "0x8F0024")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x8F0044", Offset = "0x8F0044", VA = "0x8F0044")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x8F00E0", Offset = "0x8F00E0", VA = "0x8F00E0")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x8F02A8", Offset = "0x8F02A8", VA = "0x8F02A8")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x8F04F8", Offset = "0x8F04F8", VA = "0x8F04F8")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x8EE48C", Offset = "0x8EE48C", VA = "0x8EE48C")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x8F2AA4", Offset = "0x8F2AA4", VA = "0x8F2AA4")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x8F2C3C", Offset = "0x8F2C3C", VA = "0x8F2C3C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x8F05DC", Offset = "0x8F05DC", VA = "0x8F05DC")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x8F0838", Offset = "0x8F0838", VA = "0x8F0838")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x8F2DF4", Offset = "0x8F2DF4", VA = "0x8F2DF4")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x8EE090", Offset = "0x8EE090", VA = "0x8EE090", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x8F3094", Offset = "0x8F3094", VA = "0x8F3094", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x8F3168", Offset = "0x8F3168", VA = "0x8F3168", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x8EEC94", Offset = "0x8EEC94", VA = "0x8EEC94", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x8EF074", Offset = "0x8EF074", VA = "0x8EF074", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x8F3238", Offset = "0x8F3238", VA = "0x8F3238", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x8EDB9C", Offset = "0x8EDB9C", VA = "0x8EDB9C")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x6000711")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x8F3288", Offset = "0x8F3288", VA = "0x8F3288")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x1700012A")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x8F3F94", Offset = "0x8F3F94", VA = "0x8F3F94")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x8F3F9C", Offset = "0x8F3F9C", VA = "0x8F3F9C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x8F3FA4", Offset = "0x8F3FA4", VA = "0x8F3FA4")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x8F3FAC", Offset = "0x8F3FAC", VA = "0x8F3FAC", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x8F4044", Offset = "0x8F4044", VA = "0x8F4044")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x8F404C", Offset = "0x8F404C", VA = "0x8F404C", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x8F40E4", Offset = "0x8F40E4", VA = "0x8F40E4")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x8F40EC", Offset = "0x8F40EC", VA = "0x8F40EC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x8F4184", Offset = "0x8F4184", VA = "0x8F4184")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x8F418C", Offset = "0x8F418C", VA = "0x8F418C", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x8F4224", Offset = "0x8F4224", VA = "0x8F4224")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x8F422C", Offset = "0x8F422C", VA = "0x8F422C", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x8F42C4", Offset = "0x8F42C4", VA = "0x8F42C4")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x8F42CC", Offset = "0x8F42CC", VA = "0x8F42CC", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x8F4364", Offset = "0x8F4364", VA = "0x8F4364")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x8F436C", Offset = "0x8F436C", VA = "0x8F436C", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x8F4404", Offset = "0x8F4404", VA = "0x8F4404")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x8F440C", Offset = "0x8F440C", VA = "0x8F440C", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x8F44A4", Offset = "0x8F44A4", VA = "0x8F44A4")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x8F44AC", Offset = "0x8F44AC", VA = "0x8F44AC", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x8F4544", Offset = "0x8F4544", VA = "0x8F4544")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x8F454C", Offset = "0x8F454C", VA = "0x8F454C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0x8F45E4", Offset = "0x8F45E4", VA = "0x8F45E4")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x8F45EC", Offset = "0x8F45EC", VA = "0x8F45EC", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0x8F4684", Offset = "0x8F4684", VA = "0x8F4684")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x8F468C", Offset = "0x8F468C", VA = "0x8F468C", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x8F4724", Offset = "0x8F4724", VA = "0x8F4724")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x8F472C", Offset = "0x8F472C", VA = "0x8F472C", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x8F47C4", Offset = "0x8F47C4", VA = "0x8F47C4")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x8F47CC", Offset = "0x8F47CC", VA = "0x8F47CC", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0x8F4864", Offset = "0x8F4864", VA = "0x8F4864")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x8F486C", Offset = "0x8F486C", VA = "0x8F486C", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0x8F4904", Offset = "0x8F4904", VA = "0x8F4904")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x8F490C", Offset = "0x8F490C", VA = "0x8F490C", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x8F49A4", Offset = "0x8F49A4", VA = "0x8F49A4")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	[AddComponentMenu("Dark Tonic/Master Audio/Footstep Sounds")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x20000E8")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000598")]
			None,
			[Token(Token = "0x4000599")]
			OnCollision,
			[Token(Token = "0x400059A")]
			OnTriggerEnter,
			[Token(Token = "0x400059B")]
			OnCollision2D,
			[Token(Token = "0x400059C")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700012B")]
		private Transform Trans
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x8F4E48", Offset = "0x8F4E48", VA = "0x8F4E48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0x8F49AC", Offset = "0x8F49AC", VA = "0x8F49AC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x8F4D04", Offset = "0x8F4D04", VA = "0x8F4D04")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x8F4D44", Offset = "0x8F4D44", VA = "0x8F4D44")]
		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x8F4D84", Offset = "0x8F4D84", VA = "0x8F4D84")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0x8F4DC4", Offset = "0x8F4DC4", VA = "0x8F4DC4")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0x8F49EC", Offset = "0x8F49EC", VA = "0x8F49EC")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x8F4EC8", Offset = "0x8F4EC8", VA = "0x8F4EC8")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Select for event to re-fire each time animation loops without exiting state")]
		[Header("Retrigger Events Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Header("Enter Custom Event")]
		[Tooltip("Fire A Custom Event When State Is Entered")]
		public bool fireEnterEvent;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Exit Custom Event")]
		[Tooltip("Fire a Custom Event when state is Exited")]
		public bool fireExitEvent;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Fire Custom EventTimed to Animation")]
		[Tooltip("Fire a Custom Event timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireEvent;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Fire Multiple Custom Events Timed to Anim")]
		[Tooltip("Fire a Custom Event with timed to the animation.  This allows you to time your Custom Events to the actions in you animation. Select the number of Custom Events to be fired, up to 4. Then set the time you want each Custom Event to fire with each subsequent time greater than the previous time.")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 4f)]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x8F4F5C", Offset = "0x8F4F5C", VA = "0x8F4F5C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x8F50BC", Offset = "0x8F50BC", VA = "0x8F50BC", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x8F5394", Offset = "0x8F5394", VA = "0x8F5394", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x8F5028", Offset = "0x8F5028", VA = "0x8F5028")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x8F5460", Offset = "0x8F5460", VA = "0x8F5460")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Select For Sounds To Follow Object")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("Select for sounds to retrigger each time animation loops without exiting state")]
		[Header("Retrigger Sounds Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Tooltip("Play a Sound Group when state is Entered")]
		[Header("Enter Sound Group")]
		public bool playEnterSound;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string enterVariationName;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Tooltip("Play a Sound Group when state is Exited")]
		[Header("Exit Sound Group")]
		public bool playExitSound;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string exitVariationName;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Play Sound Group Timed to Animation")]
		[Tooltip("Play a Sound Group (Normal or Looped Chain Variation Mode) timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.  Select a stop time greater than the start time or leave stop time equals to zero and select Stop Anim Time Sound On Exit.  This can be used for Looped Chain Sound Groups since you have to define a stop time.")]
		public bool playAnimTimeSound;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[Tooltip("If selected, When To Stop Sound (below) will be used. Otherwise the sound will not be stopped unless you have Stop Anim Time Sound On Exit selected above.")]
		public bool useStopTime;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartSound;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStopSound;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string timedVariationName;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[Header("Play Multiple Sounds Timed to Anim")]
		[Tooltip("Play a Sound Group with each variation timed to the animation.  This allows you to time your sounds to the actions in you animation.  Example: A sword swing combo where you want swoosh soundsor character grunts timed to the acceleration phase of the sword swing.  Select the number of sounds to be played, up to 4.  Then set the time you want each sound to start with each subsequent time greater than the previous time.")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 4f)]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound2;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound4;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string multiTimedVariationName;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x8F54D0", Offset = "0x8F54D0", VA = "0x8F54D0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x8F56A8", Offset = "0x8F56A8", VA = "0x8F56A8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x8F5BD0", Offset = "0x8F5BD0", VA = "0x8F5BD0", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x8F55C8", Offset = "0x8F55C8", VA = "0x8F55C8")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x8F565C", Offset = "0x8F565C", VA = "0x8F565C")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x8F5D6C", Offset = "0x8F5D6C", VA = "0x8F5D6C")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x1700012C")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x8F5DE0", Offset = "0x8F5DE0", VA = "0x8F5DE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x8F5DE8", Offset = "0x8F5DE8", VA = "0x8F5DE8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012D")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x8F5DF4", Offset = "0x8F5DF4", VA = "0x8F5DF4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x8F5DFC", Offset = "0x8F5DFC", VA = "0x8F5DFC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700012E")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x8F5E08", Offset = "0x8F5E08", VA = "0x8F5E08")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x8F5E10", Offset = "0x8F5E10", VA = "0x8F5E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x8F2DD4", Offset = "0x8F2DD4", VA = "0x8F2DD4")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EC")]
	public class AudioEvent
	{
		[Token(Token = "0x20000ED")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000601")]
			UseSliderValue,
			[Token(Token = "0x4000602")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x20000EE")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x8F5E80", Offset = "0x8F5E80", VA = "0x8F5E80")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x1700012F")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x8F5E18", Offset = "0x8F5E18", VA = "0x8F5E18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x8F0668", Offset = "0x8F0668", VA = "0x8F0668")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000EF")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x8F5EB8", Offset = "0x8F5EB8", VA = "0x8F5EB8")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x8F6100", Offset = "0x8F6100", VA = "0x8F6100")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F1")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x8F6128", Offset = "0x8F6128", VA = "0x8F6128")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x8F6138", Offset = "0x8F6138", VA = "0x8F6138")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F3")]
	public class CustomEvent
	{
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x8F6148", Offset = "0x8F6148", VA = "0x8F6148")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F4")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x8F61C8", Offset = "0x8F61C8", VA = "0x8F61C8")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F5")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x8F6224", Offset = "0x8F6224", VA = "0x8F6224")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F6")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x8F622C", Offset = "0x8F622C", VA = "0x8F622C")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useIntroSilence;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float introSilenceMin;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float introSilenceMax;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform _trans;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioSource _aud;

		[Token(Token = "0x17000130")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x8F6290", Offset = "0x8F6290", VA = "0x8F6290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000765")]
			[Address(RVA = "0x8F6324", Offset = "0x8F6324", VA = "0x8F6324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x8F63B8", Offset = "0x8F63B8", VA = "0x8F63B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000133")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x6000767")]
			[Address(RVA = "0x8F644C", Offset = "0x8F644C", VA = "0x8F644C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x6000768")]
			[Address(RVA = "0x8F64E0", Offset = "0x8F64E0", VA = "0x8F64E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x8F6574", Offset = "0x8F6574", VA = "0x8F6574")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x8F6608", Offset = "0x8F6608", VA = "0x8F6608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000137")]
		public Transform Trans
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x8F676C", Offset = "0x8F676C", VA = "0x8F676C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x8F67EC", Offset = "0x8F67EC", VA = "0x8F67EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000139")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x8F6A04", Offset = "0x8F6A04", VA = "0x8F6A04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x8F6A98", Offset = "0x8F6A98", VA = "0x8F6A98")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string comments;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool logSound;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int busIndex;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float spatialBlend;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool isExistingBus;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int limitPerXFrames;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool limitPolyphony;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public int voiceLimitCount;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float despawnFadeTime;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC5")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x91AAE8", Offset = "0x91AAE8", VA = "0x91AAE8")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F9")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x91AC64", Offset = "0x91AC64", VA = "0x91AC64")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FA")]
	public class GroupBus
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x1700013A")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000773")]
			[Address(RVA = "0x91AF9C", Offset = "0x91AF9C", VA = "0x91AF9C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700013B")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x91AFE4", Offset = "0x91AFE4", VA = "0x91AFE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700013C")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x91B048", Offset = "0x91B048", VA = "0x91B048")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x91B050", Offset = "0x91B050", VA = "0x91B050")]
			set
			{
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x91AE70", Offset = "0x91AE70", VA = "0x91AE70")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x91AF44", Offset = "0x91AF44", VA = "0x91AF44")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x91B058", Offset = "0x91B058", VA = "0x91B058")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FB")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x91B0F4", Offset = "0x91B0F4", VA = "0x91B0F4")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FC")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x91B104", Offset = "0x91B104", VA = "0x91B104")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x600077A")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x600077B")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x600077C")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x600077D")]
		void RegisterReceiver();

		[Token(Token = "0x600077E")]
		void UnregisterReceiver();

		[Token(Token = "0x600077F")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x20000FE")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000FF")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x40006FF")]
			None,
			[Token(Token = "0x4000700")]
			Stop,
			[Token(Token = "0x4000701")]
			FadeOut
		}

		[Token(Token = "0x2000100")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000703")]
			Randomized,
			[Token(Token = "0x4000704")]
			TopToBottom
		}

		[Token(Token = "0x2000101")]
		public enum VariationMode
		{
			[Token(Token = "0x4000706")]
			Normal,
			[Token(Token = "0x4000707")]
			LoopedChain,
			[Token(Token = "0x4000708")]
			Dialog
		}

		[Token(Token = "0x2000102")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x400070A")]
			Endless,
			[Token(Token = "0x400070B")]
			NumberOfLoops
		}

		[Token(Token = "0x2000103")]
		public enum LimitMode
		{
			[Token(Token = "0x400070D")]
			None,
			[Token(Token = "0x400070E")]
			FrameBased,
			[Token(Token = "0x400070F")]
			TimeBased
		}

		[Token(Token = "0x40006C3")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x40006C4")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x40006C5")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x1700013D")]
		public MasterAudio.InternetFileLoadStatus GroupLoadStatus
		{
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x91B24C", Offset = "0x91B24C", VA = "0x91B24C")]
			get
			{
				return default(MasterAudio.InternetFileLoadStatus);
			}
		}

		[Token(Token = "0x1700013E")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000787")]
			[Address(RVA = "0x91BB80", Offset = "0x91BB80", VA = "0x91BB80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700013F")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000788")]
			[Address(RVA = "0x91BC5C", Offset = "0x91BC5C", VA = "0x91BC5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000140")]
		public int TotalVoices
		{
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x91BCA8", Offset = "0x91BCA8", VA = "0x91BCA8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000141")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x91BCC8", Offset = "0x91BCC8", VA = "0x91BCC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x91BA38", Offset = "0x91BA38", VA = "0x91BA38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000143")]
		public float OriginalVolume
		{
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x91BCD4", Offset = "0x91BCD4", VA = "0x91BCD4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600078D")]
			[Address(RVA = "0x91BCDC", Offset = "0x91BCDC", VA = "0x91BCDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x91BCE4", Offset = "0x91BCE4", VA = "0x91BCE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000145")]
		public int ChainLoopCount
		{
			[Token(Token = "0x6000792")]
			[Address(RVA = "0x91BD7C", Offset = "0x91BD7C", VA = "0x91BD7C")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x91BD84", Offset = "0x91BD84", VA = "0x91BD84")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public string GameObjectName
		{
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x91BD8C", Offset = "0x91BD8C", VA = "0x91BD8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000147")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x91BDC4", Offset = "0x91BDC4", VA = "0x91BDC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000148")]
		private Transform Trans
		{
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x91B31C", Offset = "0x91B31C", VA = "0x91B31C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000149")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000797")]
			[Address(RVA = "0x91B4A0", Offset = "0x91B4A0", VA = "0x91B4A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000008")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x91B114", Offset = "0x91B114", VA = "0x91B114")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x91B1B0", Offset = "0x91B1B0", VA = "0x91B1B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x91B39C", Offset = "0x91B39C", VA = "0x91B39C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x91B540", Offset = "0x91B540", VA = "0x91B540")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x91B944", Offset = "0x91B944", VA = "0x91B944")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x91BB04", Offset = "0x91BB04", VA = "0x91BB04")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x91BD50", Offset = "0x91BD50", VA = "0x91BD50")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x91BD6C", Offset = "0x91BD6C", VA = "0x91BD6C")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x91BD74", Offset = "0x91BD74", VA = "0x91BD74")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x91BE30", Offset = "0x91BE30", VA = "0x91BE30")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x91BFC0", Offset = "0x91BFC0", VA = "0x91BFC0")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000105")]
	public class MusicSetting
	{
		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700014A")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x91C178", Offset = "0x91C178", VA = "0x91C178")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700014B")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x91C190", Offset = "0x91C190", VA = "0x91C190")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700014C")]
		public float SongStartTime
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x91C22C", Offset = "0x91C22C", VA = "0x91C22C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x91BFC8", Offset = "0x91BFC8", VA = "0x91BFC8")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x91C258", Offset = "0x91C258", VA = "0x91C258")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200010A")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x91CB60", Offset = "0x91CB60", VA = "0x91CB60")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x91CB70", Offset = "0x91CB70", VA = "0x91CB70")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010C")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x91CA58", Offset = "0x91CA58", VA = "0x91CA58")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010D")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x91CA20", Offset = "0x91CA20", VA = "0x91CA20")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010E")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x91CA90", Offset = "0x91CA90", VA = "0x91CA90")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010F")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x2000110")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000741")]
			Boolean,
			[Token(Token = "0x4000742")]
			String,
			[Token(Token = "0x4000743")]
			Integer,
			[Token(Token = "0x4000744")]
			Float
		}

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x91CB78", Offset = "0x91CB78", VA = "0x91CB78")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000111")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x91C9E8", Offset = "0x91C9E8", VA = "0x91C9E8")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x91CBC8", Offset = "0x91CBC8", VA = "0x91CBC8")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[RequireComponent(typeof(SoundGroupVariationUpdater))]
	[AudioScriptOrder(-40)]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000115")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000116")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000789")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x400078A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x400078B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x400078C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x921EE0", Offset = "0x921EE0", VA = "0x921EE0")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000117")]
		public enum PitchMode
		{
			[Token(Token = "0x4000793")]
			None,
			[Token(Token = "0x4000794")]
			Gliding
		}

		[Token(Token = "0x2000118")]
		public enum FadeMode
		{
			[Token(Token = "0x4000796")]
			None,
			[Token(Token = "0x4000797")]
			FadeInOut,
			[Token(Token = "0x4000798")]
			FadeOutEarly,
			[Token(Token = "0x4000799")]
			GradualFade
		}

		[Token(Token = "0x2000119")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x400079B")]
			AddToClipPitch,
			[Token(Token = "0x400079C")]
			IgnoreClipPitch
		}

		[Token(Token = "0x200011A")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x400079E")]
			AddToClipVolume,
			[Token(Token = "0x400079F")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200011B")]
		public enum DetectEndMode
		{
			[Token(Token = "0x40007A1")]
			None,
			[Token(Token = "0x40007A2")]
			DetectEnd
		}

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string internetFileUrl;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.InternetFileLoadStatus internetFileLoadStatus;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float original_pitch;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float original_volume;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool isExpanded;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool isChecked;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool useFades;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float fadeInTime;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float fadeOutTime;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useCustomLooping;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public int minCustomLoops;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int maxCustomLoops;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool useRandomStartTime;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomStartMinPercent;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float randomStartMaxPercent;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float randomEndPercent;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool useIntroSilence;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float introSilenceMin;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float introSilenceMax;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float fadeMaxVolume;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public FadeMode curFadeMode;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public PitchMode curPitchMode;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int frames;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioSource _audioSource;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _maxVol;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _instanceId;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool? _audioLoops;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int _maxLoops;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _soundGroupName;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool _isPaused;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _trans;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject _go;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _attachToSource;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private string _resFileName;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x1700014D")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x921458", Offset = "0x921458", VA = "0x921458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x9214EC", Offset = "0x9214EC", VA = "0x9214EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x921580", Offset = "0x921580", VA = "0x921580")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x921614", Offset = "0x921614", VA = "0x921614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x9216A8", Offset = "0x9216A8", VA = "0x9216A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0x9216B0", Offset = "0x9216B0", VA = "0x9216B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x9216B8", Offset = "0x9216B8", VA = "0x9216B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000153")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x92174C", Offset = "0x92174C", VA = "0x92174C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x921754", Offset = "0x921754", VA = "0x921754")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x921884", Offset = "0x921884", VA = "0x921884")]
			get
			{
				return null;
			}
			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x92188C", Offset = "0x92188C", VA = "0x92188C")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x921894", Offset = "0x921894", VA = "0x921894")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000156")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x91D340", Offset = "0x91D340", VA = "0x91D340")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000157")]
		public float OriginalPitch
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x91E6CC", Offset = "0x91E6CC", VA = "0x91E6CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000158")]
		public float OriginalVolume
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x921A9C", Offset = "0x921A9C", VA = "0x921A9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000159")]
		public string SoundGroupName
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x921AD0", Offset = "0x921AD0", VA = "0x921AD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x921B00", Offset = "0x921B00", VA = "0x921B00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015B")]
		public float LastTimePlayed
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x921C68", Offset = "0x921C68", VA = "0x921C68")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x921C70", Offset = "0x921C70", VA = "0x921C70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700015C")]
		public bool IsPlaying
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x91FBE0", Offset = "0x91FBE0", VA = "0x91FBE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015D")]
		public int InstanceId
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x91F33C", Offset = "0x91F33C", VA = "0x91F33C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015E")]
		public Transform Trans
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x920A20", Offset = "0x920A20", VA = "0x920A20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		public GameObject GameObj
		{
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x91D0AC", Offset = "0x91D0AC", VA = "0x91D0AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x91D018", Offset = "0x91D018", VA = "0x91D018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		public bool AudioLoops
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x91F28C", Offset = "0x91F28C", VA = "0x91F28C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000162")]
		public string ResFileName
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x91E9F0", Offset = "0x91E9F0", VA = "0x91E9F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x91D9B8", Offset = "0x91D9B8", VA = "0x91D9B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x921D08", Offset = "0x921D08", VA = "0x921D08")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		public float SetGroupVolume
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x921D10", Offset = "0x921D10", VA = "0x921D10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x921D2C", Offset = "0x921D2C", VA = "0x921D2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000166")]
		public int MaxLoops
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x921D48", Offset = "0x921D48", VA = "0x921D48")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000167")]
		private bool Is2D
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x921D50", Offset = "0x921D50", VA = "0x921D50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000168")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x91E644", Offset = "0x91E644", VA = "0x91E644")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000169")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x91DB28", Offset = "0x91DB28", VA = "0x91DB28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700016A")]
		public bool IsPaused
		{
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x921D78", Offset = "0x921D78", VA = "0x921D78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000009")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x91CBD0", Offset = "0x91CBD0", VA = "0x91CBD0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0x91CC70", Offset = "0x91CC70", VA = "0x91CC70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60007B1")]
			[Address(RVA = "0x91CD10", Offset = "0x91CD10", VA = "0x91CD10")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x91CDB0", Offset = "0x91CDB0", VA = "0x91CDB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x91CE50", Offset = "0x91CE50", VA = "0x91CE50")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x91D12C", Offset = "0x91D12C", VA = "0x91D12C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x91D5E8", Offset = "0x91D5E8", VA = "0x91D5E8")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x91D638", Offset = "0x91D638", VA = "0x91D638")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x91D4EC", Offset = "0x91D4EC", VA = "0x91D4EC")]
		public void LoadInternetFile()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x91D7D0", Offset = "0x91D7D0", VA = "0x91D7D0")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x91D728", Offset = "0x91D728", VA = "0x91D728")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x91DCC4", Offset = "0x91DCC4", VA = "0x91DCC4")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x91DD5C", Offset = "0x91DD5C", VA = "0x91DD5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x91DE08", Offset = "0x91DE08", VA = "0x91DE08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x91DD60", Offset = "0x91DD60", VA = "0x91DD60")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x91E148", Offset = "0x91E148", VA = "0x91E148")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x91E5A4", Offset = "0x91E5A4", VA = "0x91E5A4")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x91EF90", Offset = "0x91EF90", VA = "0x91EF90")]
		private void InternetFileFailedToLoad()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x91E57C", Offset = "0x91E57C", VA = "0x91E57C")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x91EFA4", Offset = "0x91EFA4", VA = "0x91EFA4")]
		private void InternetFileLoaded()
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x91F064", Offset = "0x91F064", VA = "0x91F064")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x91E700", Offset = "0x91E700", VA = "0x91E700")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x91F41C", Offset = "0x91F41C", VA = "0x91F41C")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x91F464", Offset = "0x91F464", VA = "0x91F464")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x91F7DC", Offset = "0x91F7DC", VA = "0x91F7DC")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x91F954", Offset = "0x91F954", VA = "0x91F954")]
		public void Pause()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x91FB08", Offset = "0x91FB08", VA = "0x91FB08")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x91FD04", Offset = "0x91FD04", VA = "0x91FD04")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x9200C8", Offset = "0x9200C8", VA = "0x9200C8")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x91F070", Offset = "0x91F070", VA = "0x91F070")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x9205E4", Offset = "0x9205E4", VA = "0x9205E4")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x92031C", Offset = "0x92031C", VA = "0x92031C")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x91DE0C", Offset = "0x91DE0C", VA = "0x91DE0C")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x920B1C", Offset = "0x920B1C", VA = "0x920B1C")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x920F10", Offset = "0x920F10", VA = "0x920F10")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x9211A8", Offset = "0x9211A8", VA = "0x9211A8")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x9212C0", Offset = "0x9212C0", VA = "0x9212C0")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x921368", Offset = "0x921368", VA = "0x921368")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x92175C", Offset = "0x92175C", VA = "0x92175C")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x921D80", Offset = "0x921D80", VA = "0x921D80")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x91EF9C", Offset = "0x91EF9C", VA = "0x91EF9C")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x921D9C", Offset = "0x921D9C", VA = "0x921D9C")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x200011C")]
	[AudioScriptOrder(-15)]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200011D")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x40007D8")]
			None,
			[Token(Token = "0x40007D9")]
			Play,
			[Token(Token = "0x40007DA")]
			WaitForEnd,
			[Token(Token = "0x40007DB")]
			StopOrRepeat
		}

		[Token(Token = "0x40007A3")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x40007A4")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x1700016B")]
		public float ClipStartPosition
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x923BF0", Offset = "0x923BF0", VA = "0x923BF0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700016C")]
		public float ClipEndPosition
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x92230C", Offset = "0x92230C", VA = "0x92230C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700016D")]
		public int FramesPlayed
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x924864", Offset = "0x924864", VA = "0x924864")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700016E")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x92486C", Offset = "0x92486C", VA = "0x92486C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016F")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x9248C4", Offset = "0x9248C4", VA = "0x9248C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000170")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x92496C", Offset = "0x92496C", VA = "0x92496C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000171")]
		private Transform Trans
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x922960", Offset = "0x922960", VA = "0x922960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000172")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x92227C", Offset = "0x92227C", VA = "0x92227C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000173")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x9229E8", Offset = "0x9229E8", VA = "0x9229E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x9221E8", Offset = "0x9221E8", VA = "0x9221E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000175")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x923A94", Offset = "0x923A94", VA = "0x923A94")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000176")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x922F84", Offset = "0x922F84", VA = "0x922F84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000177")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x924800", Offset = "0x924800", VA = "0x924800")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x91F724", Offset = "0x91F724", VA = "0x91F724")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x920D98", Offset = "0x920D98", VA = "0x920D98")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x921020", Offset = "0x921020", VA = "0x921020")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x920538", Offset = "0x920538", VA = "0x920538")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x91F16C", Offset = "0x91F16C", VA = "0x91F16C")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x91F364", Offset = "0x91F364", VA = "0x91F364")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x920570", Offset = "0x920570", VA = "0x920570")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x920AD4", Offset = "0x920AD4", VA = "0x920AD4")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x920AB0", Offset = "0x920AB0", VA = "0x920AB0")]
		public void StopFading()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x9200A0", Offset = "0x9200A0", VA = "0x9200A0")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x920AA0", Offset = "0x920AA0", VA = "0x920AA0")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x9228F4", Offset = "0x9228F4", VA = "0x9228F4")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x922460", Offset = "0x922460", VA = "0x922460")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x922DA4", Offset = "0x922DA4", VA = "0x922DA4")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x922E40", Offset = "0x922E40", VA = "0x922E40")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x923004", Offset = "0x923004", VA = "0x923004")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x923070", Offset = "0x923070", VA = "0x923070")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x9225C8", Offset = "0x9225C8", VA = "0x9225C8")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x923D7C", Offset = "0x923D7C", VA = "0x923D7C")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x923EC8", Offset = "0x923EC8", VA = "0x923EC8")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x91FAE4", Offset = "0x91FAE4", VA = "0x91FAE4")]
		public void Pause()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x91FBFC", Offset = "0x91FBFC", VA = "0x91FBFC")]
		public void Unpause()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x91FDB0", Offset = "0x91FDB0", VA = "0x91FDB0")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x923F60", Offset = "0x923F60", VA = "0x923F60")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x924010", Offset = "0x924010", VA = "0x924010")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x9242B8", Offset = "0x9242B8", VA = "0x9242B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x924334", Offset = "0x924334", VA = "0x924334")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x91DA4C", Offset = "0x91DA4C", VA = "0x91DA4C")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x9243F4", Offset = "0x9243F4", VA = "0x9243F4")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x924A14", Offset = "0x924A14", VA = "0x924A14")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x40007DC")]
		private const int MaxPriority = 0;

		[Token(Token = "0x40007DD")]
		private const int HighestPriority = 16;

		[Token(Token = "0x40007DE")]
		private const int LowestPriority = 128;

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x91DC94", Offset = "0x91DC94", VA = "0x91DC94")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000832")]
		[Address(RVA = "0x91DCAC", Offset = "0x91DCAC", VA = "0x91DCAC")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000833")]
		[Address(RVA = "0x924A8C", Offset = "0x924A8C", VA = "0x924A8C")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000834")]
		[Address(RVA = "0x922A70", Offset = "0x922A70", VA = "0x922A70")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x200011F")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000178")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000849")]
				[Address(RVA = "0x926EAC", Offset = "0x926EAC", VA = "0x926EAC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000179")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0x926EF4", Offset = "0x926EF4", VA = "0x926EF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0x925928", Offset = "0x925928", VA = "0x925928")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0x925F80", Offset = "0x925F80", VA = "0x925F80", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0x925F84", Offset = "0x925F84", VA = "0x925F84", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x926EB4", Offset = "0x926EB4", VA = "0x926EB4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000121")]
		[CompilerGenerated]
		private sealed class <PopulateSourceWithInternetFile>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string fileUrl;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action failureAction;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x1700017A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000850")]
				[Address(RVA = "0x927A14", Offset = "0x927A14", VA = "0x927A14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0x927A5C", Offset = "0x927A5C", VA = "0x927A5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x925950", Offset = "0x925950", VA = "0x925950")]
			[DebuggerHidden]
			public <PopulateSourceWithInternetFile>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x926EFC", Offset = "0x926EFC", VA = "0x926EFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x926F18", Offset = "0x926F18", VA = "0x926F18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x927964", Offset = "0x927964", VA = "0x927964")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x927A1C", Offset = "0x927A1C", VA = "0x927A1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700017C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000856")]
				[Address(RVA = "0x928014", Offset = "0x928014", VA = "0x928014", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700017D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000858")]
				[Address(RVA = "0x92805C", Offset = "0x92805C", VA = "0x92805C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x925978", Offset = "0x925978", VA = "0x925978")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x927A64", Offset = "0x927A64", VA = "0x927A64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x927A68", Offset = "0x927A68", VA = "0x927A68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x92801C", Offset = "0x92801C", VA = "0x92801C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly List<string> InternetFilesStartedLoading;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x6000835")]
		[Address(RVA = "0x924AA4", Offset = "0x924AA4", VA = "0x924AA4")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000836")]
		[Address(RVA = "0x924B48", Offset = "0x924B48", VA = "0x924B48")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x921C78", Offset = "0x921C78", VA = "0x921C78")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x924EF8", Offset = "0x924EF8", VA = "0x924EF8")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x924C98", Offset = "0x924C98", VA = "0x924C98")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x925268", Offset = "0x925268", VA = "0x925268")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x9252E0", Offset = "0x9252E0", VA = "0x9252E0")]
		public static AudioClip PopulateResourceSongToPlaylistController(string controllerName, string songResourceName, string playlistName)
		{
			return null;
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x9256BC", Offset = "0x9256BC", VA = "0x9256BC")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x925898", Offset = "0x925898", VA = "0x925898")]
		[IteratorStateMachine(typeof(<PopulateResourceSongToPlaylistControllerAsync>d__13))]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x91D930", Offset = "0x91D930", VA = "0x91D930")]
		[IteratorStateMachine(typeof(<PopulateSourceWithInternetFile>d__14))]
		public static IEnumerator PopulateSourceWithInternetFile(string fileUrl, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x91B668", Offset = "0x91B668", VA = "0x91B668")]
		public static void RemoveLoadedInternetClip(string fileUrl)
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x91EA74", Offset = "0x91EA74", VA = "0x91EA74")]
		[IteratorStateMachine(typeof(<PopulateSourcesWithResourceClipAsync>d__16))]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x9259A0", Offset = "0x9259A0", VA = "0x9259A0")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x91EAFC", Offset = "0x91EAFC", VA = "0x91EAFC")]
		public static bool PopulateSourcesWithResourceClip(string clipName, SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x925B28", Offset = "0x925B28", VA = "0x925B28")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x920678", Offset = "0x920678", VA = "0x920678")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AudioScriptOrder(-50)]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000124")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x40008A9")]
			StopSound,
			[Token(Token = "0x40008AA")]
			FadeSound
		}

		[Token(Token = "0x2000125")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x40008AC")]
			StopExistingSound,
			[Token(Token = "0x40008AD")]
			FadeInSameSound
		}

		[Token(Token = "0x2000126")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40008AF")]
			LateUpdate,
			[Token(Token = "0x40008B0")]
			FixedUpdate
		}

		[Token(Token = "0x2000127")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40008B2")]
			All,
			[Token(Token = "0x40008B3")]
			OneAtRandom
		}

		[Token(Token = "0x2000128")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40008B5")]
			AllGroups,
			[Token(Token = "0x40008B6")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000129")]
		public enum RaycastMode
		{
			[Token(Token = "0x40008B8")]
			Physics3D,
			[Token(Token = "0x40008B9")]
			Physics2D
		}

		[Token(Token = "0x200012A")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x40008BB")]
			ForceAllTo2D,
			[Token(Token = "0x40008BC")]
			ForceAllTo3D,
			[Token(Token = "0x40008BD")]
			ForceAllToCustom,
			[Token(Token = "0x40008BE")]
			AllowDifferentPerController
		}

		[Token(Token = "0x200012B")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x40008C0")]
			ForceAllTo2D,
			[Token(Token = "0x40008C1")]
			ForceAllTo3D,
			[Token(Token = "0x40008C2")]
			ForceAllToCustom,
			[Token(Token = "0x40008C3")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x200012C")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x40008C5")]
			ForceTo2D,
			[Token(Token = "0x40008C6")]
			ForceTo3D,
			[Token(Token = "0x40008C7")]
			ForceToCustom,
			[Token(Token = "0x40008C8")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x200012D")]
		public enum InternetFileLoadStatus
		{
			[Token(Token = "0x40008CA")]
			Loading,
			[Token(Token = "0x40008CB")]
			Loaded,
			[Token(Token = "0x40008CC")]
			Failed
		}

		[Token(Token = "0x200012E")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x40008CE")]
			Narrow,
			[Token(Token = "0x40008CF")]
			Normal,
			[Token(Token = "0x40008D0")]
			Wide
		}

		[Token(Token = "0x200012F")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x40008D2")]
			Always,
			[Token(Token = "0x40008D3")]
			WhenDistanceLessThan,
			[Token(Token = "0x40008D4")]
			WhenDistanceMoreThan,
			[Token(Token = "0x40008D5")]
			Never,
			[Token(Token = "0x40008D6")]
			OnSameGameObject,
			[Token(Token = "0x40008D7")]
			OnChildGameObject,
			[Token(Token = "0x40008D8")]
			OnParentGameObject,
			[Token(Token = "0x40008D9")]
			OnSameOrChildGameObject,
			[Token(Token = "0x40008DA")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x2000130")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x40008DC")]
			All,
			[Token(Token = "0x40008DD")]
			Closest,
			[Token(Token = "0x40008DE")]
			Random
		}

		[Token(Token = "0x2000131")]
		public enum AudioLocation
		{
			[Token(Token = "0x40008E0")]
			Clip,
			[Token(Token = "0x40008E1")]
			ResourceFile,
			[Token(Token = "0x40008E2")]
			FileOnInternet
		}

		[Token(Token = "0x2000132")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x40008E4")]
			Beginning,
			[Token(Token = "0x40008E5")]
			SpecificTime,
			[Token(Token = "0x40008E6")]
			RandomTime
		}

		[Token(Token = "0x2000133")]
		public enum BusCommand
		{
			[Token(Token = "0x40008E8")]
			None,
			[Token(Token = "0x40008E9")]
			FadeToVolume,
			[Token(Token = "0x40008EA")]
			Mute,
			[Token(Token = "0x40008EB")]
			Pause,
			[Token(Token = "0x40008EC")]
			Solo,
			[Token(Token = "0x40008ED")]
			Unmute,
			[Token(Token = "0x40008EE")]
			Unpause,
			[Token(Token = "0x40008EF")]
			Unsolo,
			[Token(Token = "0x40008F0")]
			Stop,
			[Token(Token = "0x40008F1")]
			ChangePitch,
			[Token(Token = "0x40008F2")]
			ToggleMute,
			[Token(Token = "0x40008F3")]
			StopBusOfTransform,
			[Token(Token = "0x40008F4")]
			PauseBusOfTransform,
			[Token(Token = "0x40008F5")]
			UnpauseBusOfTransform,
			[Token(Token = "0x40008F6")]
			GlideByPitch,
			[Token(Token = "0x40008F7")]
			StopOldBusVoices,
			[Token(Token = "0x40008F8")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x2000134")]
		public enum DragGroupMode
		{
			[Token(Token = "0x40008FA")]
			OneGroupPerClip,
			[Token(Token = "0x40008FB")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000135")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x40008FD")]
			PlaySound,
			[Token(Token = "0x40008FE")]
			GroupControl,
			[Token(Token = "0x40008FF")]
			BusControl,
			[Token(Token = "0x4000900")]
			PlaylistControl,
			[Token(Token = "0x4000901")]
			CustomEventControl,
			[Token(Token = "0x4000902")]
			GlobalControl,
			[Token(Token = "0x4000903")]
			UnityMixerControl,
			[Token(Token = "0x4000904")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000136")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000906")]
			UseDeviceSetting,
			[Token(Token = "0x4000907")]
			SpecificLanguage,
			[Token(Token = "0x4000908")]
			DynamicallySet
		}

		[Token(Token = "0x2000137")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400090A")]
			None,
			[Token(Token = "0x400090B")]
			TransitionToSnapshot,
			[Token(Token = "0x400090C")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x2000138")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x400090E")]
			None,
			[Token(Token = "0x400090F")]
			ChangePlaylist,
			[Token(Token = "0x4000910")]
			FadeToVolume,
			[Token(Token = "0x4000911")]
			PlaySong,
			[Token(Token = "0x4000912")]
			PlayRandomSong,
			[Token(Token = "0x4000913")]
			PlayNextSong,
			[Token(Token = "0x4000914")]
			Pause,
			[Token(Token = "0x4000915")]
			Resume,
			[Token(Token = "0x4000916")]
			Stop,
			[Token(Token = "0x4000917")]
			Mute,
			[Token(Token = "0x4000918")]
			Unmute,
			[Token(Token = "0x4000919")]
			ToggleMute,
			[Token(Token = "0x400091A")]
			Restart,
			[Token(Token = "0x400091B")]
			Start,
			[Token(Token = "0x400091C")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400091D")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x400091E")]
			AddSongToQueue
		}

		[Token(Token = "0x2000139")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000920")]
			None,
			[Token(Token = "0x4000921")]
			FireEvent
		}

		[Token(Token = "0x200013A")]
		public enum GlobalCommand
		{
			[Token(Token = "0x4000923")]
			None,
			[Token(Token = "0x4000924")]
			PauseMixer,
			[Token(Token = "0x4000925")]
			UnpauseMixer,
			[Token(Token = "0x4000926")]
			StopMixer,
			[Token(Token = "0x4000927")]
			StopEverything,
			[Token(Token = "0x4000928")]
			PauseEverything,
			[Token(Token = "0x4000929")]
			UnpauseEverything,
			[Token(Token = "0x400092A")]
			MuteEverything,
			[Token(Token = "0x400092B")]
			UnmuteEverything,
			[Token(Token = "0x400092C")]
			SetMasterMixerVolume,
			[Token(Token = "0x400092D")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x200013B")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x400092F")]
			None,
			[Token(Token = "0x4000930")]
			FadeToVolume,
			[Token(Token = "0x4000931")]
			FadeOutAllOfSound,
			[Token(Token = "0x4000932")]
			Mute,
			[Token(Token = "0x4000933")]
			Pause,
			[Token(Token = "0x4000934")]
			Solo,
			[Token(Token = "0x4000935")]
			StopAllOfSound,
			[Token(Token = "0x4000936")]
			Unmute,
			[Token(Token = "0x4000937")]
			Unpause,
			[Token(Token = "0x4000938")]
			Unsolo,
			[Token(Token = "0x4000939")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x400093A")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x400093B")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x400093C")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x400093D")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x400093E")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x400093F")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000940")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000941")]
			RouteToBus,
			[Token(Token = "0x4000942")]
			GlideByPitch,
			[Token(Token = "0x4000943")]
			ToggleSoundGroup,
			[Token(Token = "0x4000944")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x4000945")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x4000946")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x4000947")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x200013C")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000949")]
			None,
			[Token(Token = "0x400094A")]
			SetBusVolume,
			[Token(Token = "0x400094B")]
			SetGroupVolume,
			[Token(Token = "0x400094C")]
			SetMixerVolume,
			[Token(Token = "0x400094D")]
			SetMusicVolume,
			[Token(Token = "0x400094E")]
			MixerMuteToggle,
			[Token(Token = "0x400094F")]
			MusicMuteToggle
		}

		[Token(Token = "0x200013D")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000951")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000952")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x4000953")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x200013E")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x4000955")]
			MasterAudioLocation,
			[Token(Token = "0x4000956")]
			CallerLocation,
			[Token(Token = "0x4000957")]
			AttachToCaller
		}

		[Token(Token = "0x200013F")]
		public enum VariationCommand
		{
			[Token(Token = "0x4000959")]
			None,
			[Token(Token = "0x400095A")]
			Stop,
			[Token(Token = "0x400095B")]
			Pause,
			[Token(Token = "0x400095C")]
			Unpause
		}

		[Token(Token = "0x2000140")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x400095F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x4000960")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x928064", Offset = "0x928064", VA = "0x928064")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000141")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x928074", Offset = "0x928074", VA = "0x928074")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000142")]
		public class AudioInfo
		{
			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x9280B4", Offset = "0x9280B4", VA = "0x9280B4")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000143")]
		public class Playlist
		{
			[Token(Token = "0x2000144")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x400097E")]
				UseMasterSetting,
				[Token(Token = "0x400097F")]
				Override
			}

			[Token(Token = "0x400096B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x400096C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x400096D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x400096E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x400096F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x4000970")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool resourceClipsAllLoadAsync;

			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isTemporary;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool showMetadata;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x4000979")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x400097A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x928100", Offset = "0x928100", VA = "0x928100")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000145")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x4000980")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x4000981")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x928220", Offset = "0x928220", VA = "0x928220")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Token(Token = "0x2000147")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass234_0
		{
			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x92837C", Offset = "0x92837C", VA = "0x92837C")]
			public <>c__DisplayClass234_0()
			{
			}

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x928384", Offset = "0x928384", VA = "0x928384")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000148")]
		[CompilerGenerated]
		private sealed class <PlaySoundAndWaitUntilFinished>d__234 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400098E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x400098F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000990")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000991")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000992")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass234_0 <>8__1;

			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170001A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000992")]
				[Address(RVA = "0x928650", Offset = "0x928650", VA = "0x928650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0x928698", Offset = "0x928698", VA = "0x928698", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x928390", Offset = "0x928390", VA = "0x928390")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__234(int <>1__state)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x9283B8", Offset = "0x9283B8", VA = "0x9283B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x9283BC", Offset = "0x9283BC", VA = "0x9283BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x928658", Offset = "0x928658", VA = "0x928658", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000149")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass235_0
		{
			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x9286A0", Offset = "0x9286A0", VA = "0x9286A0")]
			public <>c__DisplayClass235_0()
			{
			}

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x9286A8", Offset = "0x9286A8", VA = "0x9286A8")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200014A")]
		[CompilerGenerated]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__235 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass235_0 <>8__1;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170001A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600099A")]
				[Address(RVA = "0x928998", Offset = "0x928998", VA = "0x928998", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600099C")]
				[Address(RVA = "0x9289E0", Offset = "0x9289E0", VA = "0x9289E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x9286B4", Offset = "0x9286B4", VA = "0x9286B4")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__235(int <>1__state)
			{
			}

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x9286DC", Offset = "0x9286DC", VA = "0x9286DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x9286E0", Offset = "0x9286E0", VA = "0x9286E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x9289A0", Offset = "0x9289A0", VA = "0x9289A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200014B")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass236_0
		{
			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x9289E8", Offset = "0x9289E8", VA = "0x9289E8")]
			public <>c__DisplayClass236_0()
			{
			}

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x9289F0", Offset = "0x9289F0", VA = "0x9289F0")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x200014C")]
		[CompilerGenerated]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__236 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40009A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40009A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40009A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40009A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40009A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40009A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40009AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass236_0 <>8__1;

			[Token(Token = "0x40009AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170001A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009A2")]
				[Address(RVA = "0x928CE0", Offset = "0x928CE0", VA = "0x928CE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009A4")]
				[Address(RVA = "0x928D28", Offset = "0x928D28", VA = "0x928D28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x9289FC", Offset = "0x9289FC", VA = "0x9289FC")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__236(int <>1__state)
			{
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x928A24", Offset = "0x928A24", VA = "0x928A24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x928A28", Offset = "0x928A28", VA = "0x928A28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x928CE8", Offset = "0x928CE8", VA = "0x928CE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007FA")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x40007FB")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x40007FC")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x40007FD")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x40007FE")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x40007FF")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000800")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000801")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000802")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000803")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000804")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x4000805")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x4000806")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x4000807")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x400080C")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x400080D")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x400080E")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x400080F")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000810")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x4000811")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x4000812")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x4000813")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000814")]
		private const int MaxComponents = 20;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool resourceClipsAllLoadAsync;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x4000889")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x400088A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x400088B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
		private float _repriTime;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private bool _mustRescanGroups;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private Transform _trans;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private bool _soundsLoaded;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A1")]
		private bool _warming;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x1700017E")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x9129CC", Offset = "0x9129CC", VA = "0x9129CC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000926")]
			[Address(RVA = "0x912A28", Offset = "0x912A28", VA = "0x912A28")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000938")]
			[Address(RVA = "0x914F90", Offset = "0x914F90", VA = "0x914F90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x914FEC", Offset = "0x914FEC", VA = "0x914FEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x8FF9F0", Offset = "0x8FF9F0", VA = "0x8FF9F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x915050", Offset = "0x915050", VA = "0x915050")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x600094D")]
			[Address(RVA = "0x9162AC", Offset = "0x9162AC", VA = "0x9162AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x600094F")]
			[Address(RVA = "0x8F88BC", Offset = "0x8F88BC", VA = "0x8F88BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000950")]
			[Address(RVA = "0x9163EC", Offset = "0x9163EC", VA = "0x9163EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x8FF900", Offset = "0x8FF900", VA = "0x8FF900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000185")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000952")]
			[Address(RVA = "0x91649C", Offset = "0x91649C", VA = "0x91649C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000953")]
			[Address(RVA = "0x90B928", Offset = "0x90B928", VA = "0x90B928")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x9164F8", Offset = "0x9164F8", VA = "0x9164F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000955")]
			[Address(RVA = "0x90F3FC", Offset = "0x90F3FC", VA = "0x90F3FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x916554", Offset = "0x916554", VA = "0x916554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x91655C", Offset = "0x91655C", VA = "0x91655C")]
			set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x916568", Offset = "0x916568", VA = "0x916568")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000189")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x90EE20", Offset = "0x90EE20", VA = "0x90EE20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x905C24", Offset = "0x905C24", VA = "0x905C24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018B")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x916570", Offset = "0x916570", VA = "0x916570")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x916678", Offset = "0x916678", VA = "0x916678")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018D")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x908094", Offset = "0x908094", VA = "0x908094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x8FBC18", Offset = "0x8FBC18", VA = "0x8FBC18")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x91680C", Offset = "0x91680C", VA = "0x91680C")]
			set
			{
			}
		}

		[Token(Token = "0x1700018F")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x8FD0E8", Offset = "0x8FD0E8", VA = "0x8FD0E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000190")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x916864", Offset = "0x916864", VA = "0x916864")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x9168BC", Offset = "0x9168BC", VA = "0x9168BC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public List<string> GroupNames
		{
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x916918", Offset = "0x916918", VA = "0x916918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x916D24", Offset = "0x916D24", VA = "0x916D24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000193")]
		public List<string> BusNames
		{
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x916E7C", Offset = "0x916E7C", VA = "0x916E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x91708C", Offset = "0x91708C", VA = "0x91708C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000195")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x91729C", Offset = "0x91729C", VA = "0x91729C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000196")]
		public Transform Trans
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x8F8A7C", Offset = "0x8F8A7C", VA = "0x8F8A7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000197")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x9173E8", Offset = "0x9173E8", VA = "0x9173E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000198")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x9173F0", Offset = "0x9173F0", VA = "0x9173F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000199")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x917680", Offset = "0x917680", VA = "0x917680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019A")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x917528", Offset = "0x917528", VA = "0x917528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019B")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x917800", Offset = "0x917800", VA = "0x917800")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x91785C", Offset = "0x91785C", VA = "0x91785C")]
			set
			{
			}
		}

		[Token(Token = "0x1700019C")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x8FD060", Offset = "0x8FD060", VA = "0x8FD060")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019D")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x9179A8", Offset = "0x9179A8", VA = "0x9179A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019E")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x917A04", Offset = "0x917A04", VA = "0x917A04")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x917B84", Offset = "0x917B84", VA = "0x917B84")]
			set
			{
			}
		}

		[Token(Token = "0x1700019F")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x917C44", Offset = "0x917C44", VA = "0x917C44")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001A0")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x917D60", Offset = "0x917D60", VA = "0x917D60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001A1")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x917E20", Offset = "0x917E20", VA = "0x917E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x917E78", Offset = "0x917E78", VA = "0x917E78")]
			set
			{
			}
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x8F6AD0", Offset = "0x8F6AD0", VA = "0x8F6AD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x8F9F18", Offset = "0x8F9F18", VA = "0x8F9F18")]
		private void Start()
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x8FA0C4", Offset = "0x8FA0C4", VA = "0x8FA0C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x8FA374", Offset = "0x8FA374", VA = "0x8FA374")]
		private void Update()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x8FB524", Offset = "0x8FB524", VA = "0x8FB524")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x8FB5B8", Offset = "0x8FB5B8", VA = "0x8FB5B8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x8FB534", Offset = "0x8FB534", VA = "0x8FB534")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x8FBB04", Offset = "0x8FBB04", VA = "0x8FBB04")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x8FBE1C", Offset = "0x8FBE1C", VA = "0x8FBE1C")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x8FB908", Offset = "0x8FB908", VA = "0x8FB908")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x8FBE9C", Offset = "0x8FBE9C", VA = "0x8FBE9C")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x8FB5CC", Offset = "0x8FB5CC", VA = "0x8FB5CC")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x8FB458", Offset = "0x8FB458", VA = "0x8FB458")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x6000866")]
		[Address(RVA = "0x8FB118", Offset = "0x8FB118", VA = "0x8FB118")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x6000867")]
		[Address(RVA = "0x8FA3F8", Offset = "0x8FA3F8", VA = "0x8FA3F8")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x8FA6DC", Offset = "0x8FA6DC", VA = "0x8FA6DC")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x8FABCC", Offset = "0x8FABCC", VA = "0x8FABCC")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x8FAF28", Offset = "0x8FAF28", VA = "0x8FAF28")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x8FA9E0", Offset = "0x8FA9E0", VA = "0x8FA9E0")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x8FCE08", Offset = "0x8FCE08", VA = "0x8FCE08")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x8FCE94", Offset = "0x8FCE94", VA = "0x8FCE94")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x8FE944", Offset = "0x8FE944", VA = "0x8FE944")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x8FEB3C", Offset = "0x8FEB3C", VA = "0x8FEB3C")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x8FECDC", Offset = "0x8FECDC", VA = "0x8FECDC")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x8FEE90", Offset = "0x8FEE90", VA = "0x8FEE90")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x8FF068", Offset = "0x8FF068", VA = "0x8FF068")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x8FF26C", Offset = "0x8FF26C", VA = "0x8FF26C")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x8F8DD8", Offset = "0x8F8DD8", VA = "0x8F8DD8")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x8FF444", Offset = "0x8FF444", VA = "0x8FF444")]
		[IteratorStateMachine(typeof(<PlaySoundAndWaitUntilFinished>d__234))]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x8FF4EC", Offset = "0x8FF4EC", VA = "0x8FF4EC")]
		[IteratorStateMachine(typeof(<PlaySound3DAtTransformAndWaitUntilFinished>d__235))]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x8FF5AC", Offset = "0x8FF5AC", VA = "0x8FF5AC")]
		[IteratorStateMachine(typeof(<PlaySound3DFollowTransformAndWaitUntilFinished>d__236))]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x8FE920", Offset = "0x8FE920", VA = "0x8FE920")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x8FD1A8", Offset = "0x8FD1A8", VA = "0x8FD1A8")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x8FFF58", Offset = "0x8FFF58", VA = "0x8FFF58")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x8FF9C0", Offset = "0x8FF9C0", VA = "0x8FF9C0")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x8FFCF4", Offset = "0x8FFCF4", VA = "0x8FFCF4")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x900220", Offset = "0x900220", VA = "0x900220")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x900910", Offset = "0x900910", VA = "0x900910")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x900AE0", Offset = "0x900AE0", VA = "0x900AE0")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x900F1C", Offset = "0x900F1C", VA = "0x900F1C")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x9011AC", Offset = "0x9011AC", VA = "0x9011AC")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x901338", Offset = "0x901338", VA = "0x901338")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x90155C", Offset = "0x90155C", VA = "0x90155C")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x9016E8", Offset = "0x9016E8", VA = "0x9016E8")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x90190C", Offset = "0x90190C", VA = "0x90190C")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x901A98", Offset = "0x901A98", VA = "0x901A98")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x901FCC", Offset = "0x901FCC", VA = "0x901FCC")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x8FC934", Offset = "0x8FC934", VA = "0x8FC934")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x8FFF88", Offset = "0x8FFF88", VA = "0x8FFF88")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x902284", Offset = "0x902284", VA = "0x902284")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x901C54", Offset = "0x901C54", VA = "0x901C54")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x9025D8", Offset = "0x9025D8", VA = "0x9025D8")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x600088D")]
		[Address(RVA = "0x902A08", Offset = "0x902A08", VA = "0x902A08")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x600088E")]
		[Address(RVA = "0x902C68", Offset = "0x902C68", VA = "0x902C68")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x600088F")]
		[Address(RVA = "0x90394C", Offset = "0x90394C", VA = "0x90394C")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0x904168", Offset = "0x904168", VA = "0x904168")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0x9044E4", Offset = "0x9044E4", VA = "0x9044E4")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0x9047FC", Offset = "0x9047FC", VA = "0x9047FC")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x9049C4", Offset = "0x9049C4", VA = "0x9049C4")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x904C5C", Offset = "0x904C5C", VA = "0x904C5C")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x904F78", Offset = "0x904F78", VA = "0x904F78")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x90527C", Offset = "0x90527C", VA = "0x90527C")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x90538C", Offset = "0x90538C", VA = "0x90538C")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0x905574", Offset = "0x905574", VA = "0x905574")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x6000899")]
		[Address(RVA = "0x906120", Offset = "0x906120", VA = "0x906120")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0x8FC008", Offset = "0x8FC008", VA = "0x8FC008")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x9069C8", Offset = "0x9069C8", VA = "0x9069C8")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x906A5C", Offset = "0x906A5C", VA = "0x906A5C")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x906BAC", Offset = "0x906BAC", VA = "0x906BAC")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x906CFC", Offset = "0x906CFC", VA = "0x906CFC")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x906E74", Offset = "0x906E74", VA = "0x906E74")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x906FC4", Offset = "0x906FC4", VA = "0x906FC4")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x9073A8", Offset = "0x9073A8", VA = "0x9073A8")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x907564", Offset = "0x907564", VA = "0x907564")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x907704", Offset = "0x907704", VA = "0x907704")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x907CB8", Offset = "0x907CB8", VA = "0x907CB8")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x9084BC", Offset = "0x9084BC", VA = "0x9084BC")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x90968C", Offset = "0x90968C", VA = "0x90968C")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x8FC6C0", Offset = "0x8FC6C0", VA = "0x8FC6C0")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x8F9DF0", Offset = "0x8F9DF0", VA = "0x8F9DF0")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x90984C", Offset = "0x90984C", VA = "0x90984C")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x8F8B10", Offset = "0x8F8B10", VA = "0x8F8B10")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x909AF0", Offset = "0x909AF0", VA = "0x909AF0")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x909938", Offset = "0x909938", VA = "0x909938")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x8FA164", Offset = "0x8FA164", VA = "0x8FA164")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x908238", Offset = "0x908238", VA = "0x908238")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x909B84", Offset = "0x909B84", VA = "0x909B84")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x909738", Offset = "0x909738", VA = "0x909738")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x905D10", Offset = "0x905D10", VA = "0x905D10")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x90608C", Offset = "0x90608C", VA = "0x90608C")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x909FC0", Offset = "0x909FC0", VA = "0x909FC0")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x90A184", Offset = "0x90A184", VA = "0x90A184")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x909DE4", Offset = "0x909DE4", VA = "0x909DE4")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x90A2BC", Offset = "0x90A2BC", VA = "0x90A2BC")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x90A3F4", Offset = "0x90A3F4", VA = "0x90A3F4")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x900CB8", Offset = "0x900CB8", VA = "0x900CB8")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x90A50C", Offset = "0x90A50C", VA = "0x90A50C")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x90A5F8", Offset = "0x90A5F8", VA = "0x90A5F8")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x90A7CC", Offset = "0x90A7CC", VA = "0x90A7CC")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x90A928", Offset = "0x90A928", VA = "0x90A928")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x90A9FC", Offset = "0x90A9FC", VA = "0x90A9FC")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x90AB64", Offset = "0x90AB64", VA = "0x90AB64")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x90AC48", Offset = "0x90AC48", VA = "0x90AC48")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x90ADC4", Offset = "0x90ADC4", VA = "0x90ADC4")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x90AFCC", Offset = "0x90AFCC", VA = "0x90AFCC")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x90B1D4", Offset = "0x90B1D4", VA = "0x90B1D4")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x90B448", Offset = "0x90B448", VA = "0x90B448")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x90B6C4", Offset = "0x90B6C4", VA = "0x90B6C4")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x90B774", Offset = "0x90B774", VA = "0x90B774")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x90B824", Offset = "0x90B824", VA = "0x90B824")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x90B8D4", Offset = "0x90B8D4", VA = "0x90B8D4")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x90BD18", Offset = "0x90BD18", VA = "0x90BD18")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x90BDCC", Offset = "0x90BDCC", VA = "0x90BDCC")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x8FCC98", Offset = "0x8FCC98", VA = "0x8FCC98")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x905C80", Offset = "0x905C80", VA = "0x905C80")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x90C0D4", Offset = "0x90C0D4", VA = "0x90C0D4")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x90C268", Offset = "0x90C268", VA = "0x90C268")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x90C678", Offset = "0x90C678", VA = "0x90C678")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x90C7F0", Offset = "0x90C7F0", VA = "0x90C7F0")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x90C8B4", Offset = "0x90C8B4", VA = "0x90C8B4")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x90CA14", Offset = "0x90CA14", VA = "0x90CA14")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x90C500", Offset = "0x90C500", VA = "0x90C500")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x90CBC8", Offset = "0x90CBC8", VA = "0x90CBC8")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x8FFA4C", Offset = "0x8FFA4C", VA = "0x8FFA4C")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x8FC50C", Offset = "0x8FC50C", VA = "0x8FC50C")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x90CD24", Offset = "0x90CD24", VA = "0x90CD24")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x90CE6C", Offset = "0x90CE6C", VA = "0x90CE6C")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x90D148", Offset = "0x90D148", VA = "0x90D148")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x90D1D0", Offset = "0x90D1D0", VA = "0x90D1D0")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x900870", Offset = "0x900870", VA = "0x900870")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x90D640", Offset = "0x90D640", VA = "0x90D640")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x90DA48", Offset = "0x90DA48", VA = "0x90DA48")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x90DC60", Offset = "0x90DC60", VA = "0x90DC60")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x90DE5C", Offset = "0x90DE5C", VA = "0x90DE5C")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x8F8CD4", Offset = "0x8F8CD4", VA = "0x8F8CD4")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x90D480", Offset = "0x90D480", VA = "0x90D480")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x905E84", Offset = "0x905E84", VA = "0x905E84")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x90C41C", Offset = "0x90C41C", VA = "0x90C41C")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x90E530", Offset = "0x90E530", VA = "0x90E530")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x90E698", Offset = "0x90E698", VA = "0x90E698")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x90E800", Offset = "0x90E800", VA = "0x90E800")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x90E9D4", Offset = "0x90E9D4", VA = "0x90E9D4")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x90EB74", Offset = "0x90EB74", VA = "0x90EB74")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x90EC84", Offset = "0x90EC84", VA = "0x90EC84")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x90EE7C", Offset = "0x90EE7C", VA = "0x90EE7C")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x90EF98", Offset = "0x90EF98", VA = "0x90EF98")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0x90EFFC", Offset = "0x90EFFC", VA = "0x90EFFC")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0x90BCB8", Offset = "0x90BCB8", VA = "0x90BCB8")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x90F324", Offset = "0x90F324", VA = "0x90F324")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x90F4E0", Offset = "0x90F4E0", VA = "0x90F4E0")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x90F544", Offset = "0x90F544", VA = "0x90F544")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x90BD6C", Offset = "0x90BD6C", VA = "0x90BD6C")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x90F79C", Offset = "0x90F79C", VA = "0x90F79C")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x90F874", Offset = "0x90F874", VA = "0x90F874")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x90F8D8", Offset = "0x90F8D8", VA = "0x90F8D8")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x90FBC0", Offset = "0x90FBC0", VA = "0x90FBC0")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x90FB30", Offset = "0x90FB30", VA = "0x90FB30")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x90FC20", Offset = "0x90FC20", VA = "0x90FC20")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x90FC84", Offset = "0x90FC84", VA = "0x90FC84")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x90B7C4", Offset = "0x90B7C4", VA = "0x90B7C4")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x90FEDC", Offset = "0x90FEDC", VA = "0x90FEDC")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x90FF6C", Offset = "0x90FF6C", VA = "0x90FF6C")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x90FFD0", Offset = "0x90FFD0", VA = "0x90FFD0")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x90B874", Offset = "0x90B874", VA = "0x90B874")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x910228", Offset = "0x910228", VA = "0x910228")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x9102B8", Offset = "0x9102B8", VA = "0x9102B8")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x91031C", Offset = "0x91031C", VA = "0x91031C")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x90B714", Offset = "0x90B714", VA = "0x90B714")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x910574", Offset = "0x910574", VA = "0x910574")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x910608", Offset = "0x910608", VA = "0x910608")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x91066C", Offset = "0x91066C", VA = "0x91066C")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000904")]
		[Address(RVA = "0x910954", Offset = "0x910954", VA = "0x910954")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x9108C4", Offset = "0x9108C4", VA = "0x9108C4")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x9109B4", Offset = "0x9109B4", VA = "0x9109B4")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x910A18", Offset = "0x910A18", VA = "0x910A18")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x910D00", Offset = "0x910D00", VA = "0x910D00")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x910C70", Offset = "0x910C70", VA = "0x910C70")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x910D60", Offset = "0x910D60", VA = "0x910D60")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x910DC4", Offset = "0x910DC4", VA = "0x910DC4")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x91107C", Offset = "0x91107C", VA = "0x91107C")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x910FEC", Offset = "0x910FEC", VA = "0x910FEC")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x9110DC", Offset = "0x9110DC", VA = "0x9110DC")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x911148", Offset = "0x911148", VA = "0x911148")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x9113C8", Offset = "0x9113C8", VA = "0x9113C8")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x9114B8", Offset = "0x9114B8", VA = "0x9114B8")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x91151C", Offset = "0x91151C", VA = "0x91151C")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x911428", Offset = "0x911428", VA = "0x911428")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x911744", Offset = "0x911744", VA = "0x911744")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x911834", Offset = "0x911834", VA = "0x911834")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x911898", Offset = "0x911898", VA = "0x911898")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x9117A4", Offset = "0x9117A4", VA = "0x9117A4")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x911AC0", Offset = "0x911AC0", VA = "0x911AC0")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x911B2C", Offset = "0x911B2C", VA = "0x911B2C")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x911CAC", Offset = "0x911CAC", VA = "0x911CAC")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x911D18", Offset = "0x911D18", VA = "0x911D18")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x911E98", Offset = "0x911E98", VA = "0x911E98")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x911F14", Offset = "0x911F14", VA = "0x911F14")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x912098", Offset = "0x912098", VA = "0x912098")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x912114", Offset = "0x912114", VA = "0x912114")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x9124DC", Offset = "0x9124DC", VA = "0x9124DC")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x912388", Offset = "0x912388", VA = "0x912388")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x912554", Offset = "0x912554", VA = "0x912554")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x9126D8", Offset = "0x9126D8", VA = "0x9126D8")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x912884", Offset = "0x912884", VA = "0x912884")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x912AFC", Offset = "0x912AFC", VA = "0x912AFC")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x912C30", Offset = "0x912C30", VA = "0x912C30")]
		public static void ReDownloadAllInternetFiles()
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x91313C", Offset = "0x91313C", VA = "0x91313C")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x9134B8", Offset = "0x9134B8", VA = "0x9134B8")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x9138B8", Offset = "0x9138B8", VA = "0x9138B8")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x913D08", Offset = "0x913D08", VA = "0x913D08")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x914074", Offset = "0x914074", VA = "0x914074")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x9142BC", Offset = "0x9142BC", VA = "0x9142BC")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x914644", Offset = "0x914644", VA = "0x914644")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x9147EC", Offset = "0x9147EC", VA = "0x9147EC")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x8F8FDC", Offset = "0x8F8FDC", VA = "0x8F8FDC")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x913348", Offset = "0x913348", VA = "0x913348")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x914934", Offset = "0x914934", VA = "0x914934")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x914A94", Offset = "0x914A94", VA = "0x914A94")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x914BF4", Offset = "0x914BF4", VA = "0x914BF4")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x8FF708", Offset = "0x8FF708", VA = "0x8FF708")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x8FF7FC", Offset = "0x8FF7FC", VA = "0x8FF7FC")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x8FF66C", Offset = "0x8FF66C", VA = "0x8FF66C")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x9150B4", Offset = "0x9150B4", VA = "0x9150B4")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x600093E")]
		[Address(RVA = "0x905B88", Offset = "0x905B88", VA = "0x905B88")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x9151C4", Offset = "0x9151C4", VA = "0x9151C4")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0x90F254", Offset = "0x90F254", VA = "0x90F254")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000941")]
		[Address(RVA = "0x915380", Offset = "0x915380", VA = "0x915380")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x9155DC", Offset = "0x9155DC", VA = "0x9155DC")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x915838", Offset = "0x915838", VA = "0x915838")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x915A40", Offset = "0x915A40", VA = "0x915A40")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x915DB0", Offset = "0x915DB0", VA = "0x915DB0")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x915F44", Offset = "0x915F44", VA = "0x915F44")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x915FBC", Offset = "0x915FBC", VA = "0x915FBC")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x904E54", Offset = "0x904E54", VA = "0x904E54")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x9037E0", Offset = "0x9037E0", VA = "0x9037E0")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x915C60", Offset = "0x915C60", VA = "0x915C60")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x916098", Offset = "0x916098", VA = "0x916098")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x9021D4", Offset = "0x9021D4", VA = "0x9021D4")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x916308", Offset = "0x916308", VA = "0x916308")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0x90845C", Offset = "0x90845C", VA = "0x90845C")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0x917D04", Offset = "0x917D04", VA = "0x917D04")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x6000979")]
		[Address(RVA = "0x917ED4", Offset = "0x917ED4", VA = "0x917ED4")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x600097A")]
		[Address(RVA = "0x91806C", Offset = "0x91806C", VA = "0x91806C")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x600097B")]
		[Address(RVA = "0x918204", Offset = "0x918204", VA = "0x918204")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x600097C")]
		[Address(RVA = "0x91839C", Offset = "0x91839C", VA = "0x91839C")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		[Address(RVA = "0x918534", Offset = "0x918534", VA = "0x918534")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x200015A")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x40009B9")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x40009BA")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x40009BB")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x40009BC")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x40009BD")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x40009BE")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x40009BF")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x40009C0")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x40009C1")]
		public const string Separator = ";";

		[Token(Token = "0x170001A8")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x929278", Offset = "0x929278", VA = "0x929278")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x9292F0", Offset = "0x9292F0", VA = "0x9292F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001A9")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x92940C", Offset = "0x92940C", VA = "0x92940C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x929484", Offset = "0x929484", VA = "0x929484")]
			set
			{
			}
		}

		[Token(Token = "0x170001AA")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x9296F4", Offset = "0x9296F4", VA = "0x9296F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x929788", Offset = "0x929788", VA = "0x929788")]
			set
			{
			}
		}

		[Token(Token = "0x170001AB")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x9298C0", Offset = "0x9298C0", VA = "0x9298C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x92994C", Offset = "0x92994C", VA = "0x92994C")]
			set
			{
			}
		}

		[Token(Token = "0x170001AC")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x929A7C", Offset = "0x929A7C", VA = "0x929A7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x929B10", Offset = "0x929B10", VA = "0x929B10")]
			set
			{
			}
		}

		[Token(Token = "0x170001AD")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x929C48", Offset = "0x929C48", VA = "0x929C48")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x929CD4", Offset = "0x929CD4", VA = "0x929CD4")]
			set
			{
			}
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x9290B8", Offset = "0x9290B8", VA = "0x9290B8")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0x92922C", Offset = "0x92922C", VA = "0x92922C")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0x92933C", Offset = "0x92933C", VA = "0x92933C")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x9293C0", Offset = "0x9293C0", VA = "0x9293C0")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x9294D0", Offset = "0x9294D0", VA = "0x9294D0")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x929670", Offset = "0x929670", VA = "0x929670")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x929E04", Offset = "0x929E04", VA = "0x929E04")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x200015B")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x200015C")]
		public class CustomEventSelection
		{
			[Token(Token = "0x40009D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x40009D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x92A29C", Offset = "0x92A29C", VA = "0x92A29C")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200015D")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x40009DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x40009DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x92A2CC", Offset = "0x92A2CC", VA = "0x92A2CC")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200015E")]
		public enum MAItemType
		{
			[Token(Token = "0x40009DD")]
			SoundGroups,
			[Token(Token = "0x40009DE")]
			CustomEvents
		}

		[Token(Token = "0x200015F")]
		public enum TransferMode
		{
			[Token(Token = "0x40009E0")]
			None,
			[Token(Token = "0x40009E1")]
			Import,
			[Token(Token = "0x40009E2")]
			Export
		}

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x929FB4", Offset = "0x929FB4", VA = "0x929FB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x92A01C", Offset = "0x92A01C", VA = "0x92A01C")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public static class AmbientUtil
	{
		[Token(Token = "0x40009E3")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x40009E4")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x40009E5")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x40009E6")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x40009E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Rigidbody _listenerFollowerRB;

		[Token(Token = "0x40009EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x170001AE")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x92A960", Offset = "0x92A960", VA = "0x92A960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001AF")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x92A39C", Offset = "0x92A39C", VA = "0x92A39C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B0")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x92B53C", Offset = "0x92B53C", VA = "0x92B53C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B1")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x92B5C8", Offset = "0x92B5C8", VA = "0x92B5C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x92A2FC", Offset = "0x92A2FC", VA = "0x92A2FC")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x92A84C", Offset = "0x92A84C", VA = "0x92A84C")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x92AD38", Offset = "0x92AD38", VA = "0x92AD38")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x92ADB8", Offset = "0x92ADB8", VA = "0x92ADB8")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x92B390", Offset = "0x92B390", VA = "0x92B390")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x92B474", Offset = "0x92B474", VA = "0x92B474")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x2000162")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x92B70C", Offset = "0x92B70C", VA = "0x92B70C")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x92B814", Offset = "0x92B814", VA = "0x92B814")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000163")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x92B894", Offset = "0x92B894", VA = "0x92B894")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0x92B90C", Offset = "0x92B90C", VA = "0x92B90C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0x92B964", Offset = "0x92B964", VA = "0x92B964")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x92BA04", Offset = "0x92BA04", VA = "0x92BA04")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x92BAB8", Offset = "0x92BAB8", VA = "0x92BAB8")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x92BB58", Offset = "0x92BB58", VA = "0x92BB58")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x92BC0C", Offset = "0x92BC0C", VA = "0x92BC0C")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60009ED")]
		[Address(RVA = "0x92BCC4", Offset = "0x92BCC4", VA = "0x92BCC4")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x92BD7C", Offset = "0x92BD7C", VA = "0x92BD7C")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x92BDD4", Offset = "0x92BDD4", VA = "0x92BDD4")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x92BE3C", Offset = "0x92BE3C", VA = "0x92BE3C")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x92BEA4", Offset = "0x92BEA4", VA = "0x92BEA4")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x92BEFC", Offset = "0x92BEFC", VA = "0x92BEFC")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x92BF64", Offset = "0x92BF64", VA = "0x92BF64")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x92BFCC", Offset = "0x92BFCC", VA = "0x92BFCC")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x92C024", Offset = "0x92C024", VA = "0x92C024")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x92C08C", Offset = "0x92C08C", VA = "0x92C08C")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x92C0F4", Offset = "0x92C0F4", VA = "0x92C0F4")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000164")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170001B2")]
		public Transform Trans
		{
			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x92C15C", Offset = "0x92C15C", VA = "0x92C15C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x92C1DC", Offset = "0x92C1DC", VA = "0x92C1DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x92C1EC", Offset = "0x92C1EC", VA = "0x92C1EC")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x2000165")]
	public static class AudioUtil
	{
		[Token(Token = "0x40009EE")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x40009EF")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x40009F0")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170001B3")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x922458", Offset = "0x922458", VA = "0x922458")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001B4")]
		public static float FrameTime
		{
			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x922304", Offset = "0x922304", VA = "0x922304")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001B5")]
		public static float Time
		{
			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x922D9C", Offset = "0x922D9C", VA = "0x922D9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001B6")]
		public static int FrameCount
		{
			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x920B14", Offset = "0x920B14", VA = "0x920B14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x92C1F4", Offset = "0x92C1F4", VA = "0x92C1F4")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x92C228", Offset = "0x92C228", VA = "0x92C228")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x91DC84", Offset = "0x91DC84", VA = "0x91DC84")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x923B3C", Offset = "0x923B3C", VA = "0x923B3C")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x92C238", Offset = "0x92C238", VA = "0x92C238")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x92C310", Offset = "0x92C310", VA = "0x92C310")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x92C350", Offset = "0x92C350", VA = "0x92C350")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x6000A06")]
		[Address(RVA = "0x92C368", Offset = "0x92C368", VA = "0x92C368")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x921B8C", Offset = "0x921B8C", VA = "0x921B8C")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x92C378", Offset = "0x92C378", VA = "0x92C378")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x923B78", Offset = "0x923B78", VA = "0x923B78")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000A0A")]
		[Address(RVA = "0x920940", Offset = "0x920940", VA = "0x920940")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x91FA60", Offset = "0x91FA60", VA = "0x91FA60")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x91F69C", Offset = "0x91F69C", VA = "0x91F69C")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x92C3B4", Offset = "0x92C3B4", VA = "0x92C3B4")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x92C3DC", Offset = "0x92C3DC", VA = "0x92C3DC")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x923D44", Offset = "0x923D44", VA = "0x923D44")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x92C3EC", Offset = "0x92C3EC", VA = "0x92C3EC")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x92C400", Offset = "0x92C400", VA = "0x92C400")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000166")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x40009F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170001B7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A16")]
				[Address(RVA = "0x92C574", Offset = "0x92C574", VA = "0x92C574", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A18")]
				[Address(RVA = "0x92C5BC", Offset = "0x92C5BC", VA = "0x92C5BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x92C490", Offset = "0x92C490", VA = "0x92C490")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x92C4B8", Offset = "0x92C4B8", VA = "0x92C4B8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x92C4BC", Offset = "0x92C4BC", VA = "0x92C4BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x92C57C", Offset = "0x92C57C", VA = "0x92C57C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x92C420", Offset = "0x92C420", VA = "0x92C420")]
		[IteratorStateMachine(typeof(<WaitForActualSeconds>d__0))]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000168")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40009F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40009FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40009FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170001B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A21")]
				[Address(RVA = "0x92CCA0", Offset = "0x92CCA0", VA = "0x92CCA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A23")]
				[Address(RVA = "0x92CCE8", Offset = "0x92CCE8", VA = "0x92CCE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x92CA68", Offset = "0x92CA68", VA = "0x92CA68")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x92CAEC", Offset = "0x92CAEC", VA = "0x92CAEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x92CAF0", Offset = "0x92CAF0", VA = "0x92CAF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x92CCA8", Offset = "0x92CCA8", VA = "0x92CCA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x92C5C4", Offset = "0x92C5C4", VA = "0x92C5C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x92C8AC", Offset = "0x92C8AC", VA = "0x92C8AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x92C9D4", Offset = "0x92C9D4", VA = "0x92C9D4")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x92CA00", Offset = "0x92CA00", VA = "0x92CA00")]
		[IteratorStateMachine(typeof(<PlaySongWithDelay>d__7))]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x92CA90", Offset = "0x92CA90", VA = "0x92CA90")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0x92B37C", Offset = "0x92B37C", VA = "0x92B37C")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0x9247EC", Offset = "0x9247EC", VA = "0x9247EC")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0x91D918", Offset = "0x91D918", VA = "0x91D918")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x92A63C", Offset = "0x92A63C", VA = "0x92A63C")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x200016B")]
	[AudioScriptOrder(-35)]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x200016C")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000A1E")]
			FirstEnableOnly,
			[Token(Token = "0x4000A1F")]
			EveryEnable
		}

		[Token(Token = "0x40009FC")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170001BB")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x92E204", Offset = "0x92E204", VA = "0x92E204")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001BC")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x92E270", Offset = "0x92E270", VA = "0x92E270")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x92E278", Offset = "0x92E278", VA = "0x92E278")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0x92CCF0", Offset = "0x92CCF0", VA = "0x92CCF0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0x92CDC0", Offset = "0x92CDC0", VA = "0x92CDC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0x92CE98", Offset = "0x92CE98", VA = "0x92CE98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0x92CE9C", Offset = "0x92CE9C", VA = "0x92CE9C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x92CDC4", Offset = "0x92CDC4", VA = "0x92CDC4")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x92CF98", Offset = "0x92CF98", VA = "0x92CF98")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x92D374", Offset = "0x92D374", VA = "0x92D374")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0x92E20C", Offset = "0x92E20C", VA = "0x92E20C")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0x92DEE8", Offset = "0x92DEE8", VA = "0x92DEE8")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0x92E280", Offset = "0x92E280", VA = "0x92E280")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x4000A25")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x4000A26")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x92E670", Offset = "0x92E670", VA = "0x92E670")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x92EA94", Offset = "0x92EA94", VA = "0x92EA94")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x92EB08", Offset = "0x92EB08", VA = "0x92EB08")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x92EBFC", Offset = "0x92EBFC", VA = "0x92EBFC")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x92ED3C", Offset = "0x92ED3C", VA = "0x92ED3C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x92EE84", Offset = "0x92EE84", VA = "0x92EE84")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x92EFC8", Offset = "0x92EFC8", VA = "0x92EFC8")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x92F094", Offset = "0x92F094", VA = "0x92F094")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x92F1A0", Offset = "0x92F1A0", VA = "0x92F1A0")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x92F324", Offset = "0x92F324", VA = "0x92F324")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x92F478", Offset = "0x92F478", VA = "0x92F478")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x92F5F4", Offset = "0x92F5F4", VA = "0x92F5F4")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x92F748", Offset = "0x92F748", VA = "0x92F748")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A44")]
		[Address(RVA = "0x92F844", Offset = "0x92F844", VA = "0x92F844")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x92F9A4", Offset = "0x92F9A4", VA = "0x92F9A4")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x92FA18", Offset = "0x92FA18", VA = "0x92FA18")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x92FA84", Offset = "0x92FA84", VA = "0x92FA84")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x92FBF4", Offset = "0x92FBF4", VA = "0x92FBF4")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x92E7D0", Offset = "0x92E7D0", VA = "0x92E7D0")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x9300A8", Offset = "0x9300A8", VA = "0x9300A8")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x930150", Offset = "0x930150", VA = "0x930150")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x9301F8", Offset = "0x9301F8", VA = "0x9301F8")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x200016F")]
	[AudioScriptOrder(-80)]
	[RequireComponent(typeof(AudioSource))]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x2000170")]
		public enum AudioPlayType
		{
			[Token(Token = "0x4000A80")]
			PlayNow,
			[Token(Token = "0x4000A81")]
			Schedule,
			[Token(Token = "0x4000A82")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000171")]
		public enum PlaylistStates
		{
			[Token(Token = "0x4000A84")]
			NotInScene,
			[Token(Token = "0x4000A85")]
			Stopped,
			[Token(Token = "0x4000A86")]
			Playing,
			[Token(Token = "0x4000A87")]
			Paused,
			[Token(Token = "0x4000A88")]
			Crossfading
		}

		[Token(Token = "0x2000172")]
		public enum FadeMode
		{
			[Token(Token = "0x4000A8A")]
			None,
			[Token(Token = "0x4000A8B")]
			GradualFade
		}

		[Token(Token = "0x2000173")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000A8D")]
			NotDucking,
			[Token(Token = "0x4000A8E")]
			SetToDuck,
			[Token(Token = "0x4000A8F")]
			Ducked
		}

		[Token(Token = "0x2000174")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000175")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000176")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x2000177")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x4000A28")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x4000A29")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x4000A2A")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x4000A2B")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000A2C")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000A2D")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x4000A39")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x4000A3A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000A6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000A6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000A6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private AudioSource _audio1;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private AudioSource _audio2;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private string _activeSongAlias;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private Transform _trans;

		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private bool _willPersist;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private double? _songPauseTime;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private int framesOfSongPlayed;

		[Token(Token = "0x170001BE")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x935F28", Offset = "0x935F28", VA = "0x935F28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BF")]
		private bool ShouldLoadAsync
		{
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x935A44", Offset = "0x935A44", VA = "0x935A44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C0")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x935F74", Offset = "0x935F74", VA = "0x935F74")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x935F7C", Offset = "0x935F7C", VA = "0x935F7C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x932878", Offset = "0x932878", VA = "0x932878")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170001C2")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x931B74", Offset = "0x931B74", VA = "0x931B74")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C3")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x932B3C", Offset = "0x932B3C", VA = "0x932B3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x935F88", Offset = "0x935F88", VA = "0x935F88")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x935FD4", Offset = "0x935FD4", VA = "0x935FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C5")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x935FDC", Offset = "0x935FDC", VA = "0x935FDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C6")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x935FE4", Offset = "0x935FE4", VA = "0x935FE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C7")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x93606C", Offset = "0x93606C", VA = "0x93606C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C8")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x9360FC", Offset = "0x9360FC", VA = "0x9360FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001C9")]
		public bool IsCrossFading
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x936114", Offset = "0x936114", VA = "0x936114")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x93611C", Offset = "0x93611C", VA = "0x93611C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public bool IsFading
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x936128", Offset = "0x936128", VA = "0x936128")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CB")]
		public float PlaylistVolume
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x93552C", Offset = "0x93552C", VA = "0x93552C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x936148", Offset = "0x936148", VA = "0x936148")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x935ACC", Offset = "0x935ACC", VA = "0x935ACC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CD")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x932E78", Offset = "0x932E78", VA = "0x932E78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CE")]
		public string PlaylistName
		{
			[Token(Token = "0x6000AA6")]
			[Address(RVA = "0x936190", Offset = "0x936190", VA = "0x936190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001CF")]
		private bool IsMuted
		{
			[Token(Token = "0x6000AA7")]
			[Address(RVA = "0x936200", Offset = "0x936200", VA = "0x936200")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D0")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000AA8")]
			[Address(RVA = "0x932FFC", Offset = "0x932FFC", VA = "0x932FFC")]
			set
			{
			}
		}

		[Token(Token = "0x170001D1")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000AA9")]
			[Address(RVA = "0x9326C0", Offset = "0x9326C0", VA = "0x9326C0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001D2")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x932740", Offset = "0x932740", VA = "0x932740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D3")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x9337A8", Offset = "0x9337A8", VA = "0x9337A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D4")]
		public string ControllerName
		{
			[Token(Token = "0x6000AAC")]
			[Address(RVA = "0x92645C", Offset = "0x92645C", VA = "0x92645C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D5")]
		public bool CanSchedule
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x932558", Offset = "0x932558", VA = "0x932558")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D6")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x6000AAE")]
			[Address(RVA = "0x931238", Offset = "0x931238", VA = "0x931238")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D7")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x6000AAF")]
			[Address(RVA = "0x93284C", Offset = "0x93284C", VA = "0x93284C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D8")]
		private Transform Trans
		{
			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x93115C", Offset = "0x93115C", VA = "0x93115C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x936208", Offset = "0x936208", VA = "0x936208")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1400000B")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000A4D")]
			[Address(RVA = "0x930420", Offset = "0x930420", VA = "0x930420")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A4E")]
			[Address(RVA = "0x9304C0", Offset = "0x9304C0", VA = "0x9304C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000A4F")]
			[Address(RVA = "0x92C80C", Offset = "0x92C80C", VA = "0x92C80C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A50")]
			[Address(RVA = "0x92C934", Offset = "0x92C934", VA = "0x92C934")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x6000A51")]
			[Address(RVA = "0x930560", Offset = "0x930560", VA = "0x930560")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A52")]
			[Address(RVA = "0x930600", Offset = "0x930600", VA = "0x930600")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x9306A0", Offset = "0x9306A0", VA = "0x9306A0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x930740", Offset = "0x930740", VA = "0x930740")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x9307E0", Offset = "0x9307E0", VA = "0x9307E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x930CF4", Offset = "0x930CF4", VA = "0x930CF4")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x930ED8", Offset = "0x930ED8", VA = "0x930ED8")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x930E34", Offset = "0x930E34", VA = "0x930E34")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x930F50", Offset = "0x930F50", VA = "0x930F50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x9311DC", Offset = "0x9311DC", VA = "0x9311DC")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x9312F0", Offset = "0x9312F0", VA = "0x9312F0")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x93172C", Offset = "0x93172C", VA = "0x93172C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x9318B0", Offset = "0x9318B0", VA = "0x9318B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x931C34", Offset = "0x931C34", VA = "0x931C34")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x931C40", Offset = "0x931C40", VA = "0x931C40")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x92C65C", Offset = "0x92C65C", VA = "0x92C65C")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x932D54", Offset = "0x932D54", VA = "0x932D54")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x932E88", Offset = "0x932E88", VA = "0x932E88")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x932F4C", Offset = "0x932F4C", VA = "0x932F4C")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x931230", Offset = "0x931230", VA = "0x931230")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x932FF4", Offset = "0x932FF4", VA = "0x932FF4")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x933150", Offset = "0x933150", VA = "0x933150")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x933334", Offset = "0x933334", VA = "0x933334")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x93160C", Offset = "0x93160C", VA = "0x93160C")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x933958", Offset = "0x933958", VA = "0x933958")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x933A6C", Offset = "0x933A6C", VA = "0x933A6C")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x933AF4", Offset = "0x933AF4", VA = "0x933AF4")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x933CC4", Offset = "0x933CC4", VA = "0x933CC4")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x9344EC", Offset = "0x9344EC", VA = "0x9344EC")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x92CC18", Offset = "0x92CC18", VA = "0x92CC18")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x934638", Offset = "0x934638", VA = "0x934638")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x9347C0", Offset = "0x9347C0", VA = "0x9347C0")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x934830", Offset = "0x934830", VA = "0x934830")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x934A1C", Offset = "0x934A1C", VA = "0x934A1C")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x934BAC", Offset = "0x934BAC", VA = "0x934BAC")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x934FE8", Offset = "0x934FE8", VA = "0x934FE8")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x935390", Offset = "0x935390", VA = "0x935390")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x935504", Offset = "0x935504", VA = "0x935504")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x9314FC", Offset = "0x9314FC", VA = "0x9314FC")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x93558C", Offset = "0x93558C", VA = "0x93558C")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x9356D0", Offset = "0x9356D0", VA = "0x9356D0")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x9336E8", Offset = "0x9336E8", VA = "0x9336E8")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x935648", Offset = "0x935648", VA = "0x935648")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x935800", Offset = "0x935800", VA = "0x935800")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x9358EC", Offset = "0x9358EC", VA = "0x9358EC")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x932964", Offset = "0x932964", VA = "0x932964")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x931134", Offset = "0x931134", VA = "0x931134")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x93125C", Offset = "0x93125C", VA = "0x93125C")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x93276C", Offset = "0x93276C", VA = "0x93276C")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000A82")]
		[Address(RVA = "0x9342FC", Offset = "0x9342FC", VA = "0x9342FC")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x933D54", Offset = "0x933D54", VA = "0x933D54")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x935B70", Offset = "0x935B70", VA = "0x935B70")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x926490", Offset = "0x926490", VA = "0x926490")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x935E18", Offset = "0x935E18", VA = "0x935E18")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x934BA4", Offset = "0x934BA4", VA = "0x934BA4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x932A54", Offset = "0x932A54", VA = "0x932A54")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x935C2C", Offset = "0x935C2C", VA = "0x935C2C")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x935EB4", Offset = "0x935EB4", VA = "0x935EB4")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x933828", Offset = "0x933828", VA = "0x933828")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x935D04", Offset = "0x935D04", VA = "0x935D04")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x93228C", Offset = "0x93228C", VA = "0x93228C")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x9325E0", Offset = "0x9325E0", VA = "0x9325E0")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0x932A5C", Offset = "0x932A5C", VA = "0x932A5C")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0x9359C4", Offset = "0x9359C4", VA = "0x9359C4")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x936150", Offset = "0x936150", VA = "0x936150")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x936250", Offset = "0x936250", VA = "0x936250")]
		public PlaylistController()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x4000A95")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x4000A96")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170001DA")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x937BC8", Offset = "0x937BC8", VA = "0x937BC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DB")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x937C58", Offset = "0x937C58", VA = "0x937C58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DC")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x937CA4", Offset = "0x937CA4", VA = "0x937CA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001DD")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x937C50", Offset = "0x937C50", VA = "0x937C50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DE")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x937CF0", Offset = "0x937CF0", VA = "0x937CF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x937CF8", Offset = "0x937CF8", VA = "0x937CF8")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x200017D")]
	public static class UtilStrings
	{
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x937E14", Offset = "0x937E14", VA = "0x937E14")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x937E8C", Offset = "0x937E8C", VA = "0x937E8C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
