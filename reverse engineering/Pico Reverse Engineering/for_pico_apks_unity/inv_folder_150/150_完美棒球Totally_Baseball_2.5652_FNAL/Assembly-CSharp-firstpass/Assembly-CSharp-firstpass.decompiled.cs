using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class MA_Bootstrapper : MonoBehaviour
{
	[Token(Token = "0x6000001")]
	[Address(RVA = "0xE0F2E8", Offset = "0xE0F2E8", VA = "0xE0F2E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xE0F2EC", Offset = "0xE0F2EC", VA = "0xE0F2EC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xE0F418", Offset = "0xE0F418", VA = "0xE0F418")]
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
	[Address(RVA = "0xE0F420", Offset = "0xE0F420", VA = "0xE0F420")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE0F488", Offset = "0xE0F488", VA = "0xE0F488")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE0F518", Offset = "0xE0F518", VA = "0xE0F518")]
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
	[Address(RVA = "0xE0F520", Offset = "0xE0F520", VA = "0xE0F520")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xE0F5B0", Offset = "0xE0F5B0", VA = "0xE0F5B0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xE0F6B4", Offset = "0xE0F6B4", VA = "0xE0F6B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xE0F7FC", Offset = "0xE0F7FC", VA = "0xE0F7FC")]
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
	[Address(RVA = "0xE0F804", Offset = "0xE0F804", VA = "0xE0F804")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xE0F870", Offset = "0xE0F870", VA = "0xE0F870")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xE0F9FC", Offset = "0xE0F9FC", VA = "0xE0F9FC")]
	public MA_EnemySpawner()
	{
	}
}
[Token(Token = "0x2000006")]
public class MA_GameScene : MonoBehaviour
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xE0FA04", Offset = "0xE0FA04", VA = "0xE0FA04")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xE0FAAC", Offset = "0xE0FAAC", VA = "0xE0FAAC")]
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
	[Address(RVA = "0xE0FAB4", Offset = "0xE0FAB4", VA = "0xE0FAB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xE0FAE8", Offset = "0xE0FAE8", VA = "0xE0FAE8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE0FBC0", Offset = "0xE0FBC0", VA = "0xE0FBC0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE0FC9C", Offset = "0xE0FC9C", VA = "0xE0FC9C")]
	public MA_Laser()
	{
	}
}
[Token(Token = "0x2000008")]
public class MA_LocalizationUI : MonoBehaviour
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE0FCA4", Offset = "0xE0FCA4", VA = "0xE0FCA4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE0FD4C", Offset = "0xE0FD4C", VA = "0xE0FD4C")]
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
	[Address(RVA = "0xE0FD54", Offset = "0xE0FD54", VA = "0xE0FD54")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE0FD88", Offset = "0xE0FD88", VA = "0xE0FD88")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE0FE24", Offset = "0xE0FE24", VA = "0xE0FE24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xE0FE28", Offset = "0xE0FE28", VA = "0xE0FE28")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xE0FE2C", Offset = "0xE0FE2C", VA = "0xE0FE2C")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xE0FE30", Offset = "0xE0FE30", VA = "0xE0FE30")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xE1005C", Offset = "0xE1005C", VA = "0xE1005C")]
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
		[Address(RVA = "0xE10090", Offset = "0xE10090", VA = "0xE10090")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xE1006C", Offset = "0xE1006C", VA = "0xE1006C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE100AC", Offset = "0xE100AC", VA = "0xE100AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE10124", Offset = "0xE10124", VA = "0xE10124")]
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
	[Address(RVA = "0xE1012C", Offset = "0xE1012C", VA = "0xE1012C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE10130", Offset = "0xE10130", VA = "0xE10130")]
	private void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE1028C", Offset = "0xE1028C", VA = "0xE1028C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE10300", Offset = "0xE10300", VA = "0xE10300")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE10134", Offset = "0xE10134", VA = "0xE10134", Slot = "4")]
	public void CheckForIllegalCustomEvents()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xE10450", Offset = "0xE10450", VA = "0xE10450", Slot = "5")]
	public void ReceiveEvent(string customEventName, Vector3 originPoint)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xE10580", Offset = "0xE10580", VA = "0xE10580", Slot = "6")]
	public bool SubscribesToEvent(string customEventName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xE10290", Offset = "0xE10290", VA = "0xE10290", Slot = "7")]
	public void RegisterReceiver()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xE103F8", Offset = "0xE103F8", VA = "0xE103F8", Slot = "8")]
	public void UnregisterReceiver()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xE105F8", Offset = "0xE105F8", VA = "0xE105F8", Slot = "9")]
	public IList<AudioEventGroup> GetAllEvents()
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xE10A0C", Offset = "0xE10A0C", VA = "0xE10A0C")]
	public MA_SampleICustomEventReceiver()
	{
	}
}
[Token(Token = "0x200000C")]
public class MA_TestUI : MonoBehaviour
{
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE10B90", Offset = "0xE10B90", VA = "0xE10B90")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE10C38", Offset = "0xE10C38", VA = "0xE10C38")]
	public MA_TestUI()
	{
	}
}
[Token(Token = "0x200000D")]
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

	[Token(Token = "0x17000002")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE10F0C", Offset = "0xE10F0C", VA = "0xE10F0C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000003")]
	public Transform Trans
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE10E78", Offset = "0xE10E78", VA = "0xE10E78")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE10C40", Offset = "0xE10C40", VA = "0xE10C40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE10C44", Offset = "0xE10C44", VA = "0xE10C44")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE10C88", Offset = "0xE10C88", VA = "0xE10C88")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xE10D40", Offset = "0xE10D40", VA = "0xE10D40")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xE10FA0", Offset = "0xE10FA0", VA = "0xE10FA0")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200000E")]
public static class OculusAudioHelper
{
	[Token(Token = "0x6000035")]
	[Address(RVA = "0xE10FA8", Offset = "0xE10FA8", VA = "0xE10FA8")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xE10FB0", Offset = "0xE10FB0", VA = "0xE10FB0")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xE10FB4", Offset = "0xE10FB4", VA = "0xE10FB4")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xE10FB8", Offset = "0xE10FB8", VA = "0xE10FB8")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xE10FBC", Offset = "0xE10FBC", VA = "0xE10FBC")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xE10FC0", Offset = "0xE10FC0", VA = "0xE10FC0")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xE10FC4", Offset = "0xE10FC4", VA = "0xE10FC4")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x200000F")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000004")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE10FC8", Offset = "0xE10FC8", VA = "0xE10FC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xE10FD0", Offset = "0xE10FD0", VA = "0xE10FD0")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE10FD8", Offset = "0xE10FD8", VA = "0xE10FD8")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE10FDC", Offset = "0xE10FDC", VA = "0xE10FDC")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE10FE0", Offset = "0xE10FE0", VA = "0xE10FE0")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE10FE4", Offset = "0xE10FE4", VA = "0xE10FE4")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE10FE8", Offset = "0xE10FE8", VA = "0xE10FE8")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xE10FEC", Offset = "0xE10FEC", VA = "0xE10FEC")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000010")]
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

	[Token(Token = "0x17000005")]
	public GameObject GameObj
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE1152C", Offset = "0xE1152C", VA = "0xE1152C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000006")]
	public Transform Trans
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0xE12060", Offset = "0xE12060", VA = "0xE12060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xE10FF0", Offset = "0xE10FF0", VA = "0xE10FF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xE1101C", Offset = "0xE1101C", VA = "0xE1101C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xE111D4", Offset = "0xE111D4", VA = "0xE111D4")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xE114B4", Offset = "0xE114B4", VA = "0xE114B4")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xE115C0", Offset = "0xE115C0", VA = "0xE115C0")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xE11F7C", Offset = "0xE11F7C", VA = "0xE11F7C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xE11440", Offset = "0xE11440", VA = "0xE11440")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xE1107C", Offset = "0xE1107C", VA = "0xE1107C")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xE120F4", Offset = "0xE120F4", VA = "0xE120F4")]
	public TransformFollower()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x2000011")]
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0xE1210C", Offset = "0xE1210C", VA = "0xE1210C")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xE12114", Offset = "0xE12114", VA = "0xE12114")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x2000013")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0xE1211C", Offset = "0xE1211C", VA = "0xE1211C")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000014")]
	[AddComponentMenu("Dark Tonic/Master Audio/Ambient Sound")]
	[AudioScriptOrder(-20)]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("This option is useful if your caller ever moves, as it will make the Audio Source follow to the location of the caller every frame.")]
		public bool FollowCaller;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Tooltip("Using this option, the Audio Source will be updated every frame to the closest position on the caller's collider, if any. This will override the Follow Caller option above and happen instead.")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
		public Transform RuntimeFollower;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000007")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0xE1229C", Offset = "0xE1229C", VA = "0xE1229C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public Transform Trans
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0xE12468", Offset = "0xE12468", VA = "0xE12468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xE12124", Offset = "0xE12124", VA = "0xE12124")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xE1217C", Offset = "0xE1217C", VA = "0xE1217C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xE12324", Offset = "0xE12324", VA = "0xE12324")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE124FC", Offset = "0xE124FC", VA = "0xE124FC")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE125DC", Offset = "0xE125DC", VA = "0xE125DC")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE127A0", Offset = "0xE127A0", VA = "0xE127A0")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xE129F0", Offset = "0xE129F0", VA = "0xE129F0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE12C08", Offset = "0xE12C08", VA = "0xE12C08")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xE12E20", Offset = "0xE12E20", VA = "0xE12E20")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xE132BC", Offset = "0xE132BC", VA = "0xE132BC")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[AddComponentMenu("Dark Tonic/Master Audio/Button Clicker")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000039")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x400003A")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xE13368", Offset = "0xE13368", VA = "0xE13368")]
		private void Awake()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xE135BC", Offset = "0xE135BC", VA = "0xE135BC")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xE137E4", Offset = "0xE137E4", VA = "0xE137E4")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xE13874", Offset = "0xE13874", VA = "0xE13874")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE13A9C", Offset = "0xE13A9C", VA = "0xE13A9C")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000016")]
	[AudioScriptOrder(-30)]
	[AddComponentMenu("Dark Tonic/Master Audio/Event Sounds")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000017")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x40000BE")]
			Legacy,
			[Token(Token = "0x40000BF")]
			uGUI
		}

		[Token(Token = "0x2000018")]
		public enum EventType
		{
			[Token(Token = "0x40000C1")]
			OnStart,
			[Token(Token = "0x40000C2")]
			OnVisible,
			[Token(Token = "0x40000C3")]
			OnInvisible,
			[Token(Token = "0x40000C4")]
			OnCollision,
			[Token(Token = "0x40000C5")]
			OnTriggerEnter,
			[Token(Token = "0x40000C6")]
			OnTriggerExit,
			[Token(Token = "0x40000C7")]
			OnMouseEnter,
			[Token(Token = "0x40000C8")]
			OnMouseClick,
			[Token(Token = "0x40000C9")]
			OnSpawned,
			[Token(Token = "0x40000CA")]
			OnDespawned,
			[Token(Token = "0x40000CB")]
			OnEnable,
			[Token(Token = "0x40000CC")]
			OnDisable,
			[Token(Token = "0x40000CD")]
			OnCollision2D,
			[Token(Token = "0x40000CE")]
			OnTriggerEnter2D,
			[Token(Token = "0x40000CF")]
			OnTriggerExit2D,
			[Token(Token = "0x40000D0")]
			OnParticleCollision,
			[Token(Token = "0x40000D1")]
			UserDefinedEvent,
			[Token(Token = "0x40000D2")]
			OnCollisionExit,
			[Token(Token = "0x40000D3")]
			OnCollisionExit2D,
			[Token(Token = "0x40000D4")]
			OnMouseUp,
			[Token(Token = "0x40000D5")]
			OnMouseExit,
			[Token(Token = "0x40000D6")]
			OnMouseDrag,
			[Token(Token = "0x40000D7")]
			NGUIOnClick,
			[Token(Token = "0x40000D8")]
			NGUIMouseDown,
			[Token(Token = "0x40000D9")]
			NGUIMouseUp,
			[Token(Token = "0x40000DA")]
			NGUIMouseEnter,
			[Token(Token = "0x40000DB")]
			NGUIMouseExit,
			[Token(Token = "0x40000DC")]
			MechanimStateChanged,
			[Token(Token = "0x40000DD")]
			UnitySliderChanged,
			[Token(Token = "0x40000DE")]
			UnityButtonClicked,
			[Token(Token = "0x40000DF")]
			UnityPointerDown,
			[Token(Token = "0x40000E0")]
			UnityPointerUp,
			[Token(Token = "0x40000E1")]
			UnityPointerEnter,
			[Token(Token = "0x40000E2")]
			UnityPointerExit,
			[Token(Token = "0x40000E3")]
			UnityDrag,
			[Token(Token = "0x40000E4")]
			UnityDrop,
			[Token(Token = "0x40000E5")]
			UnityScroll,
			[Token(Token = "0x40000E6")]
			UnityUpdateSelected,
			[Token(Token = "0x40000E7")]
			UnitySelect,
			[Token(Token = "0x40000E8")]
			UnityDeselect,
			[Token(Token = "0x40000E9")]
			UnityMove,
			[Token(Token = "0x40000EA")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40000EB")]
			UnityBeginDrag,
			[Token(Token = "0x40000EC")]
			UnityEndDrag,
			[Token(Token = "0x40000ED")]
			UnitySubmit,
			[Token(Token = "0x40000EE")]
			UnityCancel,
			[Token(Token = "0x40000EF")]
			UnityToggle,
			[Token(Token = "0x40000F0")]
			OnTriggerStay,
			[Token(Token = "0x40000F1")]
			OnTriggerStay2D
		}

		[Token(Token = "0x2000019")]
		public enum GlidePitchType
		{
			[Token(Token = "0x40000F3")]
			None,
			[Token(Token = "0x40000F4")]
			RaisePitch,
			[Token(Token = "0x40000F5")]
			LowerPitch
		}

		[Token(Token = "0x200001A")]
		public enum VariationType
		{
			[Token(Token = "0x40000F7")]
			PlaySpecific,
			[Token(Token = "0x40000F8")]
			PlayRandom
		}

		[Token(Token = "0x200001B")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40000FA")]
			None,
			[Token(Token = "0x40000FB")]
			Stop,
			[Token(Token = "0x40000FC")]
			FadeOut
		}

		[Token(Token = "0x200001C")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40000FE")]
			None,
			[Token(Token = "0x40000FF")]
			FrameBased,
			[Token(Token = "0x4000100")]
			TimeBased
		}

		[Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000101")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000102")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000103")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0xE19ABC", Offset = "0xE19ABC", VA = "0xE19ABC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0xE19B04", Offset = "0xE19B04", VA = "0xE19B04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600009E")]
			[Address(RVA = "0xE141E0", Offset = "0xE141E0", VA = "0xE141E0")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE1992C", Offset = "0xE1992C", VA = "0xE1992C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xE19930", Offset = "0xE19930", VA = "0xE19930", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xE19AC4", Offset = "0xE19AC4", VA = "0xE19AC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x17000009")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xE13D1C", Offset = "0xE13D1C", VA = "0xE13D1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000A")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xE15620", Offset = "0xE15620", VA = "0xE15620")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE13BE8", Offset = "0xE13BE8", VA = "0xE13BE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE13FB4", Offset = "0xE13FB4", VA = "0xE13FB4", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xE1416C", Offset = "0xE1416C", VA = "0xE1416C")]
		[IteratorStateMachine(typeof(<CoUpdate>d__123))]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE14208", Offset = "0xE14208", VA = "0xE14208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xE1485C", Offset = "0xE1485C", VA = "0xE1485C")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xE14884", Offset = "0xE14884", VA = "0xE14884")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xE148A0", Offset = "0xE148A0", VA = "0xE148A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xE14B24", Offset = "0xE14B24", VA = "0xE14B24")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xE14ED0", Offset = "0xE14ED0", VA = "0xE14ED0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xE152A8", Offset = "0xE152A8", VA = "0xE152A8")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xE153B4", Offset = "0xE153B4", VA = "0xE153B4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xE153D4", Offset = "0xE153D4", VA = "0xE153D4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xE153F4", Offset = "0xE153F4", VA = "0xE153F4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xE15414", Offset = "0xE15414", VA = "0xE15414")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xE15434", Offset = "0xE15434", VA = "0xE15434")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xE15438", Offset = "0xE15438", VA = "0xE15438")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xE15458", Offset = "0xE15458", VA = "0xE15458")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xE1545C", Offset = "0xE1545C", VA = "0xE1545C")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xE1547C", Offset = "0xE1547C", VA = "0xE1547C")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xE1549C", Offset = "0xE1549C", VA = "0xE1549C")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE154BC", Offset = "0xE154BC", VA = "0xE154BC")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE154C0", Offset = "0xE154C0", VA = "0xE154C0")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE154E0", Offset = "0xE154E0", VA = "0xE154E0")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE15500", Offset = "0xE15500", VA = "0xE15500")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE15520", Offset = "0xE15520", VA = "0xE15520")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE15540", Offset = "0xE15540", VA = "0xE15540")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE15560", Offset = "0xE15560", VA = "0xE15560")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE15580", Offset = "0xE15580", VA = "0xE15580")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xE155A0", Offset = "0xE155A0", VA = "0xE155A0")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xE155C0", Offset = "0xE155C0", VA = "0xE155C0")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xE155F0", Offset = "0xE155F0", VA = "0xE155F0")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xE15608", Offset = "0xE15608", VA = "0xE15608")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xE15630", Offset = "0xE15630", VA = "0xE15630")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xE15668", Offset = "0xE15668", VA = "0xE15668")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xE15688", Offset = "0xE15688", VA = "0xE15688")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xE156C0", Offset = "0xE156C0", VA = "0xE156C0")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xE15700", Offset = "0xE15700", VA = "0xE15700")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xE15720", Offset = "0xE15720", VA = "0xE15720")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xE157BC", Offset = "0xE157BC", VA = "0xE157BC")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xE15984", Offset = "0xE15984", VA = "0xE15984")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xE15BD8", Offset = "0xE15BD8", VA = "0xE15BD8")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xE14634", Offset = "0xE14634", VA = "0xE14634")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xE18324", Offset = "0xE18324", VA = "0xE18324")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xE184BC", Offset = "0xE184BC", VA = "0xE184BC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE15CC8", Offset = "0xE15CC8", VA = "0xE15CC8")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE15FC8", Offset = "0xE15FC8", VA = "0xE15FC8")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE188BC", Offset = "0xE188BC", VA = "0xE188BC")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE14238", Offset = "0xE14238", VA = "0xE14238", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xE18BC8", Offset = "0xE18BC8", VA = "0xE18BC8", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xE18C9C", Offset = "0xE18C9C", VA = "0xE18C9C", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xE14E40", Offset = "0xE14E40", VA = "0xE14E40", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xE15220", Offset = "0xE15220", VA = "0xE15220", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xE18D6C", Offset = "0xE18D6C", VA = "0xE18D6C", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xE13D2C", Offset = "0xE13D2C", VA = "0xE13D2C")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600009B")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xE18DBC", Offset = "0xE18DBC", VA = "0xE18DBC")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x1700000D")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xE19B30", Offset = "0xE19B30", VA = "0xE19B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xE19B38", Offset = "0xE19B38", VA = "0xE19B38")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE19B40", Offset = "0xE19B40", VA = "0xE19B40")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE19B48", Offset = "0xE19B48", VA = "0xE19B48", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE19BE0", Offset = "0xE19BE0", VA = "0xE19BE0")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE19BE8", Offset = "0xE19BE8", VA = "0xE19BE8", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE19C80", Offset = "0xE19C80", VA = "0xE19C80")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE19C88", Offset = "0xE19C88", VA = "0xE19C88", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE19D20", Offset = "0xE19D20", VA = "0xE19D20")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE19D28", Offset = "0xE19D28", VA = "0xE19D28", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE19DC0", Offset = "0xE19DC0", VA = "0xE19DC0")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE19DC8", Offset = "0xE19DC8", VA = "0xE19DC8", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE19E60", Offset = "0xE19E60", VA = "0xE19E60")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE19E68", Offset = "0xE19E68", VA = "0xE19E68", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE19F00", Offset = "0xE19F00", VA = "0xE19F00")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xE19F08", Offset = "0xE19F08", VA = "0xE19F08", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE19FA0", Offset = "0xE19FA0", VA = "0xE19FA0")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE19FA8", Offset = "0xE19FA8", VA = "0xE19FA8", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE1A040", Offset = "0xE1A040", VA = "0xE1A040")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE1A048", Offset = "0xE1A048", VA = "0xE1A048", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE1A0E0", Offset = "0xE1A0E0", VA = "0xE1A0E0")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE1A0E8", Offset = "0xE1A0E8", VA = "0xE1A0E8", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE1A180", Offset = "0xE1A180", VA = "0xE1A180")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE1A188", Offset = "0xE1A188", VA = "0xE1A188", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE1A220", Offset = "0xE1A220", VA = "0xE1A220")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xE1A228", Offset = "0xE1A228", VA = "0xE1A228", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xE1A2C0", Offset = "0xE1A2C0", VA = "0xE1A2C0")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xE1A2C8", Offset = "0xE1A2C8", VA = "0xE1A2C8", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE1A360", Offset = "0xE1A360", VA = "0xE1A360")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE1A368", Offset = "0xE1A368", VA = "0xE1A368", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xE1A400", Offset = "0xE1A400", VA = "0xE1A400")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xE1A408", Offset = "0xE1A408", VA = "0xE1A408", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xE1A4A0", Offset = "0xE1A4A0", VA = "0xE1A4A0")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xE1A4A8", Offset = "0xE1A4A8", VA = "0xE1A4A8", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xE1A540", Offset = "0xE1A540", VA = "0xE1A540")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AddComponentMenu("Dark Tonic/Master Audio/Footstep Sounds")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x2000031")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x4000110")]
			None,
			[Token(Token = "0x4000111")]
			OnCollision,
			[Token(Token = "0x4000112")]
			OnTriggerEnter,
			[Token(Token = "0x4000113")]
			OnCollision2D,
			[Token(Token = "0x4000114")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700000E")]
		private Transform Trans
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xE1A8E4", Offset = "0xE1A8E4", VA = "0xE1A8E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xE1A548", Offset = "0xE1A548", VA = "0xE1A548")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE1A5CC", Offset = "0xE1A5CC", VA = "0xE1A5CC")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xE1A978", Offset = "0xE1A978", VA = "0xE1A978")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Retrigger Events Each Time Anim Loops w/o Exiting State")]
		[Tooltip("Select for event to re-fire each time animation loops without exiting state")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Header("Enter Custom Event")]
		[Tooltip("Fire A Custom Event When State Is Entered")]
		public bool fireEnterEvent;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Fire a Custom Event when state is Exited")]
		[Header("Exit Custom Event")]
		public bool fireExitEvent;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Fire a Custom Event timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.")]
		[Header("Fire Custom EventTimed to Animation")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireEvent;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Fire a Custom Event with timed to the animation.  This allows you to time your Custom Events to the actions in you animation. Select the number of Custom Events to be fired, up to 4. Then set the time you want each Custom Event to fire with each subsequent time greater than the previous time.")]
		[Header("Fire Multiple Custom Events Timed to Anim")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 4f)]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xE1AA18", Offset = "0xE1AA18", VA = "0xE1AA18", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xE1AB90", Offset = "0xE1AB90", VA = "0xE1AB90", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xE1AE68", Offset = "0xE1AE68", VA = "0xE1AE68", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xE1AAF4", Offset = "0xE1AAF4", VA = "0xE1AAF4")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xE1AF34", Offset = "0xE1AF34", VA = "0xE1AF34")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Select For Sounds To Follow Object")]
		public bool SoundFollowsObject;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Header("Retrigger Sounds Each Time Anim Loops w/o Exiting State")]
		[Tooltip("Select for sounds to retrigger each time animation loops without exiting state")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[Tooltip("Play a Sound Group when state is Entered")]
		[Header("Enter Sound Group")]
		public bool playEnterSound;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string enterVariationName;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Header("Exit Sound Group")]
		[Tooltip("Play a Sound Group when state is Exited")]
		public bool playExitSound;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string exitVariationName;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Play Sound Group Timed to Animation")]
		[Tooltip("Play a Sound Group (Normal or Looped Chain Variation Mode) timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.  Select a stop time greater than the start time or leave stop time equals to zero and select Stop Anim Time Sound On Exit.  This can be used for Looped Chain Sound Groups since you have to define a stop time.")]
		public bool playAnimTimeSound;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[Tooltip("If selected, When To Stop Sound (below) will be used. Otherwise the sound will not be stopped unless you have Stop Anim Time Sound On Exit selected above.")]
		public bool useStopTime;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartSound;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStopSound;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string timedVariationName;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[Tooltip("Play a Sound Group with each variation timed to the animation.  This allows you to time your sounds to the actions in you animation.  Example: A sword swing combo where you want swoosh soundsor character grunts timed to the acceleration phase of the sword swing.  Select the number of sounds to be played, up to 4.  Then set the time you want each sound to start with each subsequent time greater than the previous time.")]
		[Header("Play Multiple Sounds Timed to Anim")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 4f)]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound4;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xE1AFD0", Offset = "0xE1AFD0", VA = "0xE1AFD0", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xE1B1C0", Offset = "0xE1B1C0", VA = "0xE1B1C0", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xE1B6E8", Offset = "0xE1B6E8", VA = "0xE1B6E8", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xE1B0D8", Offset = "0xE1B0D8", VA = "0xE1B0D8")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xE1B174", Offset = "0xE1B174", VA = "0xE1B174")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xE1B884", Offset = "0xE1B884", VA = "0xE1B884")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000034")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x1700000F")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xE1B924", Offset = "0xE1B924", VA = "0xE1B924")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xE1B92C", Offset = "0xE1B92C", VA = "0xE1B92C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xE1B938", Offset = "0xE1B938", VA = "0xE1B938")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xE1B940", Offset = "0xE1B940", VA = "0xE1B940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xE1B94C", Offset = "0xE1B94C", VA = "0xE1B94C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xE1B954", Offset = "0xE1B954", VA = "0xE1B954")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xE18894", Offset = "0xE18894", VA = "0xE18894")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000035")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xE1B95C", Offset = "0xE1B95C", VA = "0xE1B95C")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public class AudioEvent
	{
		[Token(Token = "0x2000037")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x400017B")]
			UseSliderValue,
			[Token(Token = "0x400017C")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x2000038")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x400017D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x400017E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xE1B9CC", Offset = "0xE1B9CC", VA = "0xE1B9CC")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000012")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xE1B964", Offset = "0xE1B964", VA = "0xE1B964")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xE15D54", Offset = "0xE15D54", VA = "0xE15D54")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class AudioEventGroup
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xE10780", Offset = "0xE10780", VA = "0xE10780")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xE1BA10", Offset = "0xE1BA10", VA = "0xE1BA10")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003B")]
	public class BusFadeInfo
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xE1BA38", Offset = "0xE1BA38", VA = "0xE1BA38")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003C")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xE1BA48", Offset = "0xE1BA48", VA = "0xE1BA48")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003D")]
	public class CustomEvent
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xE1BA58", Offset = "0xE1BA58", VA = "0xE1BA58")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003E")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xE1BAF8", Offset = "0xE1BAF8", VA = "0xE1BAF8")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003F")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xE1BB68", Offset = "0xE1BB68", VA = "0xE1BB68")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000040")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xE1BB70", Offset = "0xE1BB70", VA = "0xE1BB70")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x17000013")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xE1BBDC", Offset = "0xE1BBDC", VA = "0xE1BBDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xE1BC84", Offset = "0xE1BC84", VA = "0xE1BC84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xE1BD2C", Offset = "0xE1BD2C", VA = "0xE1BD2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xE1BDD4", Offset = "0xE1BDD4", VA = "0xE1BDD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xE1BE7C", Offset = "0xE1BE7C", VA = "0xE1BE7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xE1BF24", Offset = "0xE1BF24", VA = "0xE1BF24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xE1BFCC", Offset = "0xE1BFCC", VA = "0xE1BFCC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public Transform Trans
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xE1C138", Offset = "0xE1C138", VA = "0xE1C138")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xE1C1CC", Offset = "0xE1C1CC", VA = "0xE1C1CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xE1C3E4", Offset = "0xE1C3E4", VA = "0xE1C3E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xE1C48C", Offset = "0xE1C48C", VA = "0xE1C48C")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float spatialBlend;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string busName;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isExistingBus;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int limitPerXFrames;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool limitPolyphony;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int voiceLimitCount;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float despawnFadeTime;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xE1C4C4", Offset = "0xE1C4C4", VA = "0xE1C4C4")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xE1C680", Offset = "0xE1C680", VA = "0xE1C680")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class GroupBus
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x1700001D")]
		public int ActiveVoices
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xE1C9E8", Offset = "0xE1C9E8", VA = "0xE1C9E8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001E")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xE1CA30", Offset = "0xE1CA30", VA = "0xE1CA30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public float OriginalVolume
		{
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xE1CA94", Offset = "0xE1CA94", VA = "0xE1CA94")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xE1CA9C", Offset = "0xE1CA9C", VA = "0xE1CA9C")]
			set
			{
			}
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xE1C8BC", Offset = "0xE1C8BC", VA = "0xE1C8BC")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xE1C990", Offset = "0xE1C990", VA = "0xE1C990")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xE1CAA4", Offset = "0xE1CAA4", VA = "0xE1CAA4")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xE1CB4C", Offset = "0xE1CB4C", VA = "0xE1CB4C")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xE1CB5C", Offset = "0xE1CB5C", VA = "0xE1CB5C")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x6000101")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x6000102")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x6000103")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x6000104")]
		void RegisterReceiver();

		[Token(Token = "0x6000105")]
		void UnregisterReceiver();

		[Token(Token = "0x6000106")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x2000048")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x2000049")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000276")]
			None,
			[Token(Token = "0x4000277")]
			Stop,
			[Token(Token = "0x4000278")]
			FadeOut
		}

		[Token(Token = "0x200004A")]
		public enum VariationSequence
		{
			[Token(Token = "0x400027A")]
			Randomized,
			[Token(Token = "0x400027B")]
			TopToBottom
		}

		[Token(Token = "0x200004B")]
		public enum VariationMode
		{
			[Token(Token = "0x400027D")]
			Normal,
			[Token(Token = "0x400027E")]
			LoopedChain,
			[Token(Token = "0x400027F")]
			Dialog
		}

		[Token(Token = "0x200004C")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x4000281")]
			Endless,
			[Token(Token = "0x4000282")]
			NumberOfLoops
		}

		[Token(Token = "0x200004D")]
		public enum LimitMode
		{
			[Token(Token = "0x4000284")]
			None,
			[Token(Token = "0x4000285")]
			FrameBased,
			[Token(Token = "0x4000286")]
			TimeBased
		}

		[Token(Token = "0x400023B")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x400023C")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x400023D")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x17000020")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0xE1D12C", Offset = "0xE1D12C", VA = "0xE1D12C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public int ActiveVoices
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0xE1D208", Offset = "0xE1D208", VA = "0xE1D208")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000022")]
		public int TotalVoices
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xE1D254", Offset = "0xE1D254", VA = "0xE1D254")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000023")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xE1D274", Offset = "0xE1D274", VA = "0xE1D274")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xE1CFE4", Offset = "0xE1CFE4", VA = "0xE1CFE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE1D280", Offset = "0xE1D280", VA = "0xE1D280")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xE1D288", Offset = "0xE1D288", VA = "0xE1D288")]
			set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xE1D290", Offset = "0xE1D290", VA = "0xE1D290")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public int ChainLoopCount
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0xE1D350", Offset = "0xE1D350", VA = "0xE1D350")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xE1D358", Offset = "0xE1D358", VA = "0xE1D358")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public string GameObjectName
		{
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xE1D360", Offset = "0xE1D360", VA = "0xE1D360")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x600011A")]
			[Address(RVA = "0xE1D3AC", Offset = "0xE1D3AC", VA = "0xE1D3AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		private Transform Trans
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0xE1CE64", Offset = "0xE1CE64", VA = "0xE1CE64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xE1CDB4", Offset = "0xE1CDB4", VA = "0xE1CDB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xE1CB6C", Offset = "0xE1CB6C", VA = "0xE1CB6C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xE1CC08", Offset = "0xE1CC08", VA = "0xE1CC08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE1CCA4", Offset = "0xE1CCA4", VA = "0xE1CCA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE1CEF0", Offset = "0xE1CEF0", VA = "0xE1CEF0")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xE1D0B0", Offset = "0xE1D0B0", VA = "0xE1D0B0")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE1D2FC", Offset = "0xE1D2FC", VA = "0xE1D2FC")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE1D314", Offset = "0xE1D314", VA = "0xE1D314")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE1D344", Offset = "0xE1D344", VA = "0xE1D344")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xE1D418", Offset = "0xE1D418", VA = "0xE1D418")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xE1D5E4", Offset = "0xE1D5E4", VA = "0xE1D5E4")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004F")]
	public class MusicSetting
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700002C")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xE1D820", Offset = "0xE1D820", VA = "0xE1D820")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xE1D838", Offset = "0xE1D838", VA = "0xE1D838")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public float SongStartTime
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xE1D8D4", Offset = "0xE1D8D4", VA = "0xE1D8D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xE1D5EC", Offset = "0xE1D5EC", VA = "0xE1D5EC")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xE1D900", Offset = "0xE1D900", VA = "0xE1D900")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000054")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xE1E2CC", Offset = "0xE1E2CC", VA = "0xE1E2CC")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xE1E2DC", Offset = "0xE1E2DC", VA = "0xE1E2DC")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xE1E1A4", Offset = "0xE1E1A4", VA = "0xE1E1A4")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xE1E15C", Offset = "0xE1E15C", VA = "0xE1E15C")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xE1E1EC", Offset = "0xE1E1EC", VA = "0xE1E1EC")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x200005A")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x40002B8")]
			Boolean,
			[Token(Token = "0x40002B9")]
			String,
			[Token(Token = "0x40002BA")]
			Integer,
			[Token(Token = "0x40002BB")]
			Float
		}

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xE1E2E4", Offset = "0xE1E2E4", VA = "0xE1E2E4")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005B")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xE1E114", Offset = "0xE1E114", VA = "0xE1E114")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xE1E350", Offset = "0xE1E350", VA = "0xE1E350")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AudioScriptOrder(-40)]
	[RequireComponent(typeof(SoundGroupVariationUpdater))]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x200005E")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x200005F")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000060")]
		public class PlaySoundParams
		{
			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x600018B")]
			[Address(RVA = "0xE21800", Offset = "0xE21800", VA = "0xE21800")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000061")]
		public enum PitchMode
		{
			[Token(Token = "0x400030E")]
			None,
			[Token(Token = "0x400030F")]
			Gliding
		}

		[Token(Token = "0x2000062")]
		public enum FadeMode
		{
			[Token(Token = "0x4000311")]
			None,
			[Token(Token = "0x4000312")]
			FadeInOut,
			[Token(Token = "0x4000313")]
			FadeOutEarly,
			[Token(Token = "0x4000314")]
			GradualFade
		}

		[Token(Token = "0x2000063")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x4000316")]
			AddToClipPitch,
			[Token(Token = "0x4000317")]
			IgnoreClipPitch
		}

		[Token(Token = "0x2000064")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x4000319")]
			AddToClipVolume,
			[Token(Token = "0x400031A")]
			IgnoreClipVolume
		}

		[Token(Token = "0x2000065")]
		public enum DetectEndMode
		{
			[Token(Token = "0x400031C")]
			None,
			[Token(Token = "0x400031D")]
			DetectEnd
		}

		[Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0xE219B4", Offset = "0xE219B4", VA = "0xE219B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0xE219FC", Offset = "0xE219FC", VA = "0xE219FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018C")]
			[Address(RVA = "0xE218BC", Offset = "0xE218BC", VA = "0xE218BC")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x600018D")]
			[Address(RVA = "0xE218E4", Offset = "0xE218E4", VA = "0xE218E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0xE218E8", Offset = "0xE218E8", VA = "0xE218E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0xE219BC", Offset = "0xE219BC", VA = "0xE219BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public int probabilityToPlay;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x1700002F")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0xE20BDC", Offset = "0xE20BDC", VA = "0xE20BDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0xE20C84", Offset = "0xE20C84", VA = "0xE20C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0xE20D2C", Offset = "0xE20D2C", VA = "0xE20D2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0xE20DD4", Offset = "0xE20DD4", VA = "0xE20DD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xE20E7C", Offset = "0xE20E7C", VA = "0xE20E7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xE20E84", Offset = "0xE20E84", VA = "0xE20E84")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0xE20E8C", Offset = "0xE20E8C", VA = "0xE20E8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xE20F34", Offset = "0xE20F34", VA = "0xE20F34")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xE20F3C", Offset = "0xE20F3C", VA = "0xE20F3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xE21088", Offset = "0xE21088", VA = "0xE21088")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xE21090", Offset = "0xE21090", VA = "0xE21090")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xE210B4", Offset = "0xE210B4", VA = "0xE210B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xE1EA8C", Offset = "0xE1EA8C", VA = "0xE1EA8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xE1F774", Offset = "0xE1F774", VA = "0xE1F774")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003A")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xE212BC", Offset = "0xE212BC", VA = "0xE212BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0xE212F0", Offset = "0xE212F0", VA = "0xE212F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xE21334", Offset = "0xE21334", VA = "0xE21334")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003D")]
		public float LastTimePlayed
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0xE213D0", Offset = "0xE213D0", VA = "0xE213D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xE213D8", Offset = "0xE213D8", VA = "0xE213D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xE213E0", Offset = "0xE213E0", VA = "0xE213E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsPlaying
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xE11978", Offset = "0xE11978", VA = "0xE11978")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xE213F0", Offset = "0xE213F0", VA = "0xE213F0")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x6000170")]
			[Address(RVA = "0xE1F618", Offset = "0xE1F618", VA = "0xE1F618")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public int InstanceId
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0xE1FD18", Offset = "0xE1FD18", VA = "0xE1FD18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsStopRequested
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0xE213F8", Offset = "0xE213F8", VA = "0xE213F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000043")]
		public Transform Trans
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0xE206E0", Offset = "0xE206E0", VA = "0xE206E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE1E848", Offset = "0xE1E848", VA = "0xE1E848")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xE1E7A0", Offset = "0xE1E7A0", VA = "0xE1E7A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0xE1FC68", Offset = "0xE1FC68", VA = "0xE1FC68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000047")]
		public string ResFileName
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xE1FAB4", Offset = "0xE1FAB4", VA = "0xE1FAB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0xE1EF80", Offset = "0xE1EF80", VA = "0xE1EF80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xE21400", Offset = "0xE21400", VA = "0xE21400")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public float SetGroupVolume
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0xE21408", Offset = "0xE21408", VA = "0xE21408")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xE21424", Offset = "0xE21424", VA = "0xE21424")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int MaxLoops
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0xE21440", Offset = "0xE21440", VA = "0xE21440")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		private bool Is2D
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xE21448", Offset = "0xE21448", VA = "0xE21448")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE1F028", Offset = "0xE1F028", VA = "0xE1F028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool IsPaused
		{
			[Token(Token = "0x600017F")]
			[Address(RVA = "0xE21470", Offset = "0xE21470", VA = "0xE21470")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xE1E358", Offset = "0xE1E358", VA = "0xE1E358")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xE1E3F8", Offset = "0xE1E3F8", VA = "0xE1E3F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xE1E498", Offset = "0xE1E498", VA = "0xE1E498")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000137")]
			[Address(RVA = "0xE1E538", Offset = "0xE1E538", VA = "0xE1E538")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xE1E5D8", Offset = "0xE1E5D8", VA = "0xE1E5D8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE1E8D4", Offset = "0xE1E8D4", VA = "0xE1E8D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE1EC40", Offset = "0xE1EC40", VA = "0xE1EC40")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE1EC90", Offset = "0xE1EC90", VA = "0xE1EC90")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE1EE20", Offset = "0xE1EE20", VA = "0xE1EE20")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE1ED80", Offset = "0xE1ED80", VA = "0xE1ED80")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE1F190", Offset = "0xE1F190", VA = "0xE1F190")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE1F228", Offset = "0xE1F228", VA = "0xE1F228")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE1F2D4", Offset = "0xE1F2D4", VA = "0xE1F2D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE1F22C", Offset = "0xE1F22C", VA = "0xE1F22C")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE1F2D8", Offset = "0xE1F2D8", VA = "0xE1F2D8")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE1F674", Offset = "0xE1F674", VA = "0xE1F674")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE1F62C", Offset = "0xE1F62C", VA = "0xE1F62C")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE1FB74", Offset = "0xE1FB74", VA = "0xE1FB74")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE1F7A8", Offset = "0xE1F7A8", VA = "0xE1F7A8")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE1FD40", Offset = "0xE1FD40", VA = "0xE1FD40")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE18654", Offset = "0xE18654", VA = "0xE18654")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xE1FD88", Offset = "0xE1FD88", VA = "0xE1FD88")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xE1FF00", Offset = "0xE1FF00", VA = "0xE1FF00")]
		public void Pause()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE20000", Offset = "0xE20000", VA = "0xE20000")]
		public void Unpause()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE200DC", Offset = "0xE200DC", VA = "0xE200DC")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE20190", Offset = "0xE20190", VA = "0xE20190")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE1FB94", Offset = "0xE1FB94", VA = "0xE1FB94")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE20600", Offset = "0xE20600", VA = "0xE20600")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE203E4", Offset = "0xE203E4", VA = "0xE203E4")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE11C18", Offset = "0xE11C18", VA = "0xE11C18")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE2076C", Offset = "0xE2076C", VA = "0xE2076C")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE207A0", Offset = "0xE207A0", VA = "0xE207A0")]
		[IteratorStateMachine(typeof(<WaitForLoadToUnloadClipAndDeactivate>d__106))]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xE11994", Offset = "0xE11994", VA = "0xE11994")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE20814", Offset = "0xE20814", VA = "0xE20814")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE20928", Offset = "0xE20928", VA = "0xE20928")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE20A44", Offset = "0xE20A44", VA = "0xE20A44")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE20AEC", Offset = "0xE20AEC", VA = "0xE20AEC")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE20F60", Offset = "0xE20F60", VA = "0xE20F60")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE21478", Offset = "0xE21478", VA = "0xE21478")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0xE1FB48", Offset = "0xE1FB48", VA = "0xE1FB48")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xE21490", Offset = "0xE21490", VA = "0xE21490")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AudioScriptOrder(-15)]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x2000068")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000356")]
			None,
			[Token(Token = "0x4000357")]
			Play,
			[Token(Token = "0x4000358")]
			WaitForEnd,
			[Token(Token = "0x4000359")]
			StopOrRepeat
		}

		[Token(Token = "0x4000321")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x4000322")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x17000051")]
		public float ClipStartPosition
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xE24718", Offset = "0xE24718", VA = "0xE24718")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000052")]
		public float ClipEndPosition
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xE21D84", Offset = "0xE21D84", VA = "0xE21D84")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000053")]
		public int FramesPlayed
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xE26640", Offset = "0xE26640", VA = "0xE26640")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000054")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xE26648", Offset = "0xE26648", VA = "0xE26648")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xE266A0", Offset = "0xE266A0", VA = "0xE266A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000056")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xE2674C", Offset = "0xE2674C", VA = "0xE2674C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000057")]
		private Transform Trans
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xE22A94", Offset = "0xE22A94", VA = "0xE22A94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xE21B6C", Offset = "0xE21B6C", VA = "0xE21B6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xE22B34", Offset = "0xE22B34", VA = "0xE22B34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xE21AC4", Offset = "0xE21AC4", VA = "0xE21AC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xE23D24", Offset = "0xE23D24", VA = "0xE23D24")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005C")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0xE233B8", Offset = "0xE233B8", VA = "0xE233B8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005D")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0xE265D8", Offset = "0xE265D8", VA = "0xE265D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xE21A04", Offset = "0xE21A04", VA = "0xE21A04")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xE21C0C", Offset = "0xE21C0C", VA = "0xE21C0C")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xE21ED0", Offset = "0xE21ED0", VA = "0xE21ED0")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE22058", Offset = "0xE22058", VA = "0xE22058")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE22090", Offset = "0xE22090", VA = "0xE22090")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE221B0", Offset = "0xE221B0", VA = "0xE221B0")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE224D8", Offset = "0xE224D8", VA = "0xE224D8")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE22950", Offset = "0xE22950", VA = "0xE22950")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE22A10", Offset = "0xE22A10", VA = "0xE22A10")]
		public void StopFading()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xE22A34", Offset = "0xE22A34", VA = "0xE22A34")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xE22A5C", Offset = "0xE22A5C", VA = "0xE22A5C")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xE229A4", Offset = "0xE229A4", VA = "0xE229A4")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xE22374", Offset = "0xE22374", VA = "0xE22374")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0xE22FC4", Offset = "0xE22FC4", VA = "0xE22FC4")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xE23060", Offset = "0xE23060", VA = "0xE23060")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xE23684", Offset = "0xE23684", VA = "0xE23684")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xE23858", Offset = "0xE23858", VA = "0xE23858")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xE22608", Offset = "0xE22608", VA = "0xE22608")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xE2486C", Offset = "0xE2486C", VA = "0xE2486C")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xE24BF4", Offset = "0xE24BF4", VA = "0xE24BF4")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xE24F40", Offset = "0xE24F40", VA = "0xE24F40")]
		public void Pause()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xE24F64", Offset = "0xE24F64", VA = "0xE24F64")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xE24C90", Offset = "0xE24C90", VA = "0xE24C90")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE2583C", Offset = "0xE2583C", VA = "0xE2583C")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xE258EC", Offset = "0xE258EC", VA = "0xE258EC")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xE25B98", Offset = "0xE25B98", VA = "0xE25B98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xE25D38", Offset = "0xE25D38", VA = "0xE25D38")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xE22280", Offset = "0xE22280", VA = "0xE22280")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xE261F0", Offset = "0xE261F0", VA = "0xE261F0")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE2691C", Offset = "0xE2691C", VA = "0xE2691C")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE26994", Offset = "0xE26994", VA = "0xE26994")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xE26C54", Offset = "0xE26C54", VA = "0xE26C54")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xE26E00", Offset = "0xE26E00", VA = "0xE26E00")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200006A")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x400035B")]
		private const int MaxPriority = 0;

		[Token(Token = "0x400035C")]
		private const int HighestPriority = 16;

		[Token(Token = "0x400035D")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE26FD8", Offset = "0xE26FD8", VA = "0xE26FD8")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE26FF0", Offset = "0xE26FF0", VA = "0xE26FF0")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE27008", Offset = "0xE27008", VA = "0xE27008")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE22C94", Offset = "0xE22C94", VA = "0xE22C94")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x200006B")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001D6")]
				[Address(RVA = "0xE28D34", Offset = "0xE28D34", VA = "0xE28D34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001D8")]
				[Address(RVA = "0xE28D7C", Offset = "0xE28D7C", VA = "0xE28D7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xE27CA8", Offset = "0xE27CA8", VA = "0xE27CA8")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xE286D0", Offset = "0xE286D0", VA = "0xE286D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001D5")]
			[Address(RVA = "0xE286D4", Offset = "0xE286D4", VA = "0xE286D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001D7")]
			[Address(RVA = "0xE28D3C", Offset = "0xE28D3C", VA = "0xE28D3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001DC")]
				[Address(RVA = "0xE293AC", Offset = "0xE293AC", VA = "0xE293AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001DE")]
				[Address(RVA = "0xE293F4", Offset = "0xE293F4", VA = "0xE293F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001D9")]
			[Address(RVA = "0xE27D90", Offset = "0xE27D90", VA = "0xE27D90")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x60001DA")]
			[Address(RVA = "0xE28D84", Offset = "0xE28D84", VA = "0xE28D84", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001DB")]
			[Address(RVA = "0xE28D88", Offset = "0xE28D88", VA = "0xE28D88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001DD")]
			[Address(RVA = "0xE293B4", Offset = "0xE293B4", VA = "0xE293B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0xE27020", Offset = "0xE27020", VA = "0xE27020")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE270C4", Offset = "0xE270C4", VA = "0xE270C4")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE27210", Offset = "0xE27210", VA = "0xE27210")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xE274E0", Offset = "0xE274E0", VA = "0xE274E0")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xE272A0", Offset = "0xE272A0", VA = "0xE272A0")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE27984", Offset = "0xE27984", VA = "0xE27984")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE27A00", Offset = "0xE27A00", VA = "0xE27A00")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE27BE0", Offset = "0xE27BE0", VA = "0xE27BE0")]
		[IteratorStateMachine(typeof(<PopulateResourceSongToPlaylistControllerAsync>d__11))]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE27CD0", Offset = "0xE27CD0", VA = "0xE27CD0")]
		[IteratorStateMachine(typeof(<PopulateSourcesWithResourceClipAsync>d__12))]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE27DB8", Offset = "0xE27DB8", VA = "0xE27DB8")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE27F40", Offset = "0xE27F40", VA = "0xE27F40")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE281B4", Offset = "0xE281B4", VA = "0xE281B4")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AudioScriptOrder(-50)]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x4000422")]
			StopSound,
			[Token(Token = "0x4000423")]
			FadeSound
		}

		[Token(Token = "0x2000070")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x4000425")]
			StopExistingSound,
			[Token(Token = "0x4000426")]
			FadeInSameSound
		}

		[Token(Token = "0x2000071")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000428")]
			LateUpdate,
			[Token(Token = "0x4000429")]
			FixedUpdate
		}

		[Token(Token = "0x2000072")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x400042B")]
			All,
			[Token(Token = "0x400042C")]
			OneAtRandom
		}

		[Token(Token = "0x2000073")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x400042E")]
			AllGroups,
			[Token(Token = "0x400042F")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000074")]
		public enum RaycastMode
		{
			[Token(Token = "0x4000431")]
			Physics3D,
			[Token(Token = "0x4000432")]
			Physics2D
		}

		[Token(Token = "0x2000075")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000434")]
			ForceAllTo2D,
			[Token(Token = "0x4000435")]
			ForceAllTo3D,
			[Token(Token = "0x4000436")]
			ForceAllToCustom,
			[Token(Token = "0x4000437")]
			AllowDifferentPerController
		}

		[Token(Token = "0x2000076")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000439")]
			ForceAllTo2D,
			[Token(Token = "0x400043A")]
			ForceAllTo3D,
			[Token(Token = "0x400043B")]
			ForceAllToCustom,
			[Token(Token = "0x400043C")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x2000077")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400043E")]
			ForceTo2D,
			[Token(Token = "0x400043F")]
			ForceTo3D,
			[Token(Token = "0x4000440")]
			ForceToCustom,
			[Token(Token = "0x4000441")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x2000078")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x4000443")]
			Narrow,
			[Token(Token = "0x4000444")]
			Normal,
			[Token(Token = "0x4000445")]
			Wide
		}

		[Token(Token = "0x2000079")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x4000447")]
			Always,
			[Token(Token = "0x4000448")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000449")]
			WhenDistanceMoreThan,
			[Token(Token = "0x400044A")]
			Never,
			[Token(Token = "0x400044B")]
			OnSameGameObject,
			[Token(Token = "0x400044C")]
			OnChildGameObject,
			[Token(Token = "0x400044D")]
			OnParentGameObject,
			[Token(Token = "0x400044E")]
			OnSameOrChildGameObject,
			[Token(Token = "0x400044F")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x200007A")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x4000451")]
			All,
			[Token(Token = "0x4000452")]
			Closest,
			[Token(Token = "0x4000453")]
			Random
		}

		[Token(Token = "0x200007B")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x4000455")]
			None,
			[Token(Token = "0x4000456")]
			Loading,
			[Token(Token = "0x4000457")]
			Loaded,
			[Token(Token = "0x4000458")]
			LoadFailed
		}

		[Token(Token = "0x200007C")]
		public enum AudioLocation
		{
			[Token(Token = "0x400045A")]
			Clip,
			[Token(Token = "0x400045B")]
			ResourceFile
		}

		[Token(Token = "0x200007D")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x400045D")]
			Beginning,
			[Token(Token = "0x400045E")]
			SpecificTime,
			[Token(Token = "0x400045F")]
			RandomTime
		}

		[Token(Token = "0x200007E")]
		public enum BusCommand
		{
			[Token(Token = "0x4000461")]
			None,
			[Token(Token = "0x4000462")]
			FadeToVolume,
			[Token(Token = "0x4000463")]
			Mute,
			[Token(Token = "0x4000464")]
			Pause,
			[Token(Token = "0x4000465")]
			Solo,
			[Token(Token = "0x4000466")]
			Unmute,
			[Token(Token = "0x4000467")]
			Unpause,
			[Token(Token = "0x4000468")]
			Unsolo,
			[Token(Token = "0x4000469")]
			Stop,
			[Token(Token = "0x400046A")]
			ChangePitch,
			[Token(Token = "0x400046B")]
			ToggleMute,
			[Token(Token = "0x400046C")]
			StopBusOfTransform,
			[Token(Token = "0x400046D")]
			PauseBusOfTransform,
			[Token(Token = "0x400046E")]
			UnpauseBusOfTransform,
			[Token(Token = "0x400046F")]
			GlideByPitch,
			[Token(Token = "0x4000470")]
			StopOldBusVoices,
			[Token(Token = "0x4000471")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x200007F")]
		public enum DragGroupMode
		{
			[Token(Token = "0x4000473")]
			OneGroupPerClip,
			[Token(Token = "0x4000474")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000080")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x4000476")]
			PlaySound,
			[Token(Token = "0x4000477")]
			GroupControl,
			[Token(Token = "0x4000478")]
			BusControl,
			[Token(Token = "0x4000479")]
			PlaylistControl,
			[Token(Token = "0x400047A")]
			CustomEventControl,
			[Token(Token = "0x400047B")]
			GlobalControl,
			[Token(Token = "0x400047C")]
			UnityMixerControl,
			[Token(Token = "0x400047D")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000081")]
		public enum LanguageMode
		{
			[Token(Token = "0x400047F")]
			UseDeviceSetting,
			[Token(Token = "0x4000480")]
			SpecificLanguage,
			[Token(Token = "0x4000481")]
			DynamicallySet
		}

		[Token(Token = "0x2000082")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x4000483")]
			None,
			[Token(Token = "0x4000484")]
			TransitionToSnapshot,
			[Token(Token = "0x4000485")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x2000083")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000487")]
			None,
			[Token(Token = "0x4000488")]
			ChangePlaylist,
			[Token(Token = "0x4000489")]
			FadeToVolume,
			[Token(Token = "0x400048A")]
			PlaySong,
			[Token(Token = "0x400048B")]
			PlayRandomSong,
			[Token(Token = "0x400048C")]
			PlayNextSong,
			[Token(Token = "0x400048D")]
			Pause,
			[Token(Token = "0x400048E")]
			Resume,
			[Token(Token = "0x400048F")]
			Stop,
			[Token(Token = "0x4000490")]
			Mute,
			[Token(Token = "0x4000491")]
			Unmute,
			[Token(Token = "0x4000492")]
			ToggleMute,
			[Token(Token = "0x4000493")]
			Restart,
			[Token(Token = "0x4000494")]
			Start,
			[Token(Token = "0x4000495")]
			StopLoopingCurrentSong,
			[Token(Token = "0x4000496")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x4000497")]
			AddSongToQueue
		}

		[Token(Token = "0x2000084")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000499")]
			None,
			[Token(Token = "0x400049A")]
			FireEvent
		}

		[Token(Token = "0x2000085")]
		public enum GlobalCommand
		{
			[Token(Token = "0x400049C")]
			None,
			[Token(Token = "0x400049D")]
			PauseMixer,
			[Token(Token = "0x400049E")]
			UnpauseMixer,
			[Token(Token = "0x400049F")]
			StopMixer,
			[Token(Token = "0x40004A0")]
			StopEverything,
			[Token(Token = "0x40004A1")]
			PauseEverything,
			[Token(Token = "0x40004A2")]
			UnpauseEverything,
			[Token(Token = "0x40004A3")]
			MuteEverything,
			[Token(Token = "0x40004A4")]
			UnmuteEverything,
			[Token(Token = "0x40004A5")]
			SetMasterMixerVolume,
			[Token(Token = "0x40004A6")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x2000086")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40004A8")]
			None,
			[Token(Token = "0x40004A9")]
			FadeToVolume,
			[Token(Token = "0x40004AA")]
			FadeOutAllOfSound,
			[Token(Token = "0x40004AB")]
			Mute,
			[Token(Token = "0x40004AC")]
			Pause,
			[Token(Token = "0x40004AD")]
			Solo,
			[Token(Token = "0x40004AE")]
			StopAllOfSound,
			[Token(Token = "0x40004AF")]
			Unmute,
			[Token(Token = "0x40004B0")]
			Unpause,
			[Token(Token = "0x40004B1")]
			Unsolo,
			[Token(Token = "0x40004B2")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40004B3")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40004B4")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40004B5")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40004B6")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40004B7")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40004B8")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40004B9")]
			RefillSoundGroupPool,
			[Token(Token = "0x40004BA")]
			RouteToBus,
			[Token(Token = "0x40004BB")]
			GlideByPitch,
			[Token(Token = "0x40004BC")]
			ToggleSoundGroup,
			[Token(Token = "0x40004BD")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x40004BE")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x40004BF")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x40004C0")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x2000087")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x40004C2")]
			None,
			[Token(Token = "0x40004C3")]
			SetBusVolume,
			[Token(Token = "0x40004C4")]
			SetGroupVolume,
			[Token(Token = "0x40004C5")]
			SetMixerVolume,
			[Token(Token = "0x40004C6")]
			SetMusicVolume,
			[Token(Token = "0x40004C7")]
			MixerMuteToggle,
			[Token(Token = "0x40004C8")]
			MusicMuteToggle
		}

		[Token(Token = "0x2000088")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x40004CA")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x40004CB")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x40004CC")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x2000089")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x40004CE")]
			MasterAudioLocation,
			[Token(Token = "0x40004CF")]
			CallerLocation,
			[Token(Token = "0x40004D0")]
			AttachToCaller
		}

		[Token(Token = "0x200008A")]
		public enum VariationCommand
		{
			[Token(Token = "0x40004D2")]
			None,
			[Token(Token = "0x40004D3")]
			Stop,
			[Token(Token = "0x40004D4")]
			Pause,
			[Token(Token = "0x40004D5")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x200008B")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x600030A")]
			[Address(RVA = "0xE4C408", Offset = "0xE4C408", VA = "0xE4C408")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008C")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x600030B")]
			[Address(RVA = "0xE4C448", Offset = "0xE4C448", VA = "0xE4C448")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008D")]
		public class AudioInfo
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x600030C")]
			[Address(RVA = "0xE4C4A4", Offset = "0xE4C4A4", VA = "0xE4C4A4")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200008E")]
		public class Playlist
		{
			[Token(Token = "0x200008F")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x40004F6")]
				UseMasterSetting,
				[Token(Token = "0x40004F7")]
				Override
			}

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x600030D")]
			[Address(RVA = "0xE4C508", Offset = "0xE4C508", VA = "0xE4C508")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000090")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x600030E")]
			[Address(RVA = "0xE4C650", Offset = "0xE4C650", VA = "0xE4C650")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Token(Token = "0x2000092")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass240_0
		{
			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000319")]
			[Address(RVA = "0xE4C7E4", Offset = "0xE4C7E4", VA = "0xE4C7E4")]
			public <>c__DisplayClass240_0()
			{
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0xE4C7EC", Offset = "0xE4C7EC", VA = "0xE4C7EC")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000093")]
		[CompilerGenerated]
		private sealed class <PlaySoundAndWaitUntilFinished>d__240 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass240_0 <>8__1;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x17000086")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0xE4CADC", Offset = "0xE4CADC", VA = "0xE4CADC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000087")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000320")]
				[Address(RVA = "0xE4CB24", Offset = "0xE4CB24", VA = "0xE4CB24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600031B")]
			[Address(RVA = "0xE4C7F8", Offset = "0xE4C7F8", VA = "0xE4C7F8")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__240(int <>1__state)
			{
			}

			[Token(Token = "0x600031C")]
			[Address(RVA = "0xE4C820", Offset = "0xE4C820", VA = "0xE4C820", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600031D")]
			[Address(RVA = "0xE4C824", Offset = "0xE4C824", VA = "0xE4C824", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031F")]
			[Address(RVA = "0xE4CAE4", Offset = "0xE4CAE4", VA = "0xE4CAE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000094")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass241_0
		{
			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000321")]
			[Address(RVA = "0xE4CB2C", Offset = "0xE4CB2C", VA = "0xE4CB2C")]
			public <>c__DisplayClass241_0()
			{
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0xE4CB34", Offset = "0xE4CB34", VA = "0xE4CB34")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__241 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass241_0 <>8__1;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x17000088")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000326")]
				[Address(RVA = "0xE4CE40", Offset = "0xE4CE40", VA = "0xE4CE40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000089")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0xE4CE88", Offset = "0xE4CE88", VA = "0xE4CE88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0xE4CB40", Offset = "0xE4CB40", VA = "0xE4CB40")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__241(int <>1__state)
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0xE4CB68", Offset = "0xE4CB68", VA = "0xE4CB68", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0xE4CB6C", Offset = "0xE4CB6C", VA = "0xE4CB6C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000327")]
			[Address(RVA = "0xE4CE48", Offset = "0xE4CE48", VA = "0xE4CE48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass242_0
		{
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x6000329")]
			[Address(RVA = "0xE4CE90", Offset = "0xE4CE90", VA = "0xE4CE90")]
			public <>c__DisplayClass242_0()
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0xE4CE98", Offset = "0xE4CE98", VA = "0xE4CE98")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__242 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass242_0 <>8__1;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x1700008A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0xE4D1A4", Offset = "0xE4D1A4", VA = "0xE4D1A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000330")]
				[Address(RVA = "0xE4D1EC", Offset = "0xE4D1EC", VA = "0xE4D1EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0xE4CEA4", Offset = "0xE4CEA4", VA = "0xE4CEA4")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__242(int <>1__state)
			{
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0xE4CECC", Offset = "0xE4CECC", VA = "0xE4CECC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0xE4CED0", Offset = "0xE4CED0", VA = "0xE4CED0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0xE4D1AC", Offset = "0xE4D1AC", VA = "0xE4D1AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000371")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000372")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000373")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000374")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000375")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000376")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000377")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000378")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000379")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x400037A")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x400037B")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x400037C")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x400037D")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x400037E")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000383")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x4000384")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x4000385")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x4000386")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000387")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x4000388")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x4000389")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x400038A")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x400038B")]
		private const int MaxComponents = 20;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool logPerfExpanded;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool willWarm;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private float _repriTime;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool _mustRescanGroups;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Transform _trans;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _soundsLoaded;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		private bool _warming;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x17000062")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xE44E38", Offset = "0xE44E38", VA = "0xE44E38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xE44E94", Offset = "0xE44E94", VA = "0xE44E94")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xE46FF0", Offset = "0xE46FF0", VA = "0xE46FF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xE4704C", Offset = "0xE4704C", VA = "0xE4704C")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xE31ED8", Offset = "0xE31ED8", VA = "0xE31ED8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0xE470B0", Offset = "0xE470B0", VA = "0xE470B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0xE47C3C", Offset = "0xE47C3C", VA = "0xE47C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0xE26020", Offset = "0xE26020", VA = "0xE26020")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0xE47C98", Offset = "0xE47C98", VA = "0xE47C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		public static bool IsWarming
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0xE22548", Offset = "0xE22548", VA = "0xE22548")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public static bool MixerMuted
		{
			[Token(Token = "0x60002DD")]
			[Address(RVA = "0xE249C8", Offset = "0xE249C8", VA = "0xE249C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002DE")]
			[Address(RVA = "0xE3DB34", Offset = "0xE3DB34", VA = "0xE3DB34")]
			set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x60002DF")]
			[Address(RVA = "0xE47D48", Offset = "0xE47D48", VA = "0xE47D48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E0")]
			[Address(RVA = "0xE417C4", Offset = "0xE417C4", VA = "0xE417C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0xE47DA4", Offset = "0xE47DA4", VA = "0xE47DA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0xE47DAC", Offset = "0xE47DAC", VA = "0xE47DAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x60002E3")]
			[Address(RVA = "0xE47DB8", Offset = "0xE47DB8", VA = "0xE47DB8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700006D")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0xE411E0", Offset = "0xE411E0", VA = "0xE411E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x60002E5")]
			[Address(RVA = "0xE37D98", Offset = "0xE37D98", VA = "0xE37D98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x60002E6")]
			[Address(RVA = "0xE47DC0", Offset = "0xE47DC0", VA = "0xE47DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xE47EC8", Offset = "0xE47EC8", VA = "0xE47EC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0xE3A30C", Offset = "0xE3A30C", VA = "0xE3A30C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xE25E74", Offset = "0xE25E74", VA = "0xE25E74")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0xE48060", Offset = "0xE48060", VA = "0xE48060")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public static bool SoundsReady
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xE2F9AC", Offset = "0xE2F9AC", VA = "0xE2F9AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0xE480BC", Offset = "0xE480BC", VA = "0xE480BC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xE48114", Offset = "0xE48114", VA = "0xE48114")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0xE48170", Offset = "0xE48170", VA = "0xE48170")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xE48588", Offset = "0xE48588", VA = "0xE48588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public List<string> BusNames
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0xE486EC", Offset = "0xE486EC", VA = "0xE486EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xE4890C", Offset = "0xE4890C", VA = "0xE4890C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0xE48B2C", Offset = "0xE48B2C", VA = "0xE48B2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public Transform Trans
		{
			[Token(Token = "0x60002F3")]
			[Address(RVA = "0xE2B308", Offset = "0xE2B308", VA = "0xE2B308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60002F4")]
			[Address(RVA = "0xE48C7C", Offset = "0xE48C7C", VA = "0xE48C7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xE48C84", Offset = "0xE48C84", VA = "0xE48C84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xE48F24", Offset = "0xE48F24", VA = "0xE48F24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xE48DC0", Offset = "0xE48DC0", VA = "0xE48DC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xE490A8", Offset = "0xE490A8", VA = "0xE490A8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xE49104", Offset = "0xE49104", VA = "0xE49104")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xE2F924", Offset = "0xE2F924", VA = "0xE2F924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000081")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xE49250", Offset = "0xE49250", VA = "0xE49250")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xE27804", Offset = "0xE27804", VA = "0xE27804")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xE492AC", Offset = "0xE492AC", VA = "0xE492AC")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xE22BD4", Offset = "0xE22BD4", VA = "0xE22BD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000084")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0xE493C4", Offset = "0xE493C4", VA = "0xE493C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000085")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xE49484", Offset = "0xE49484", VA = "0xE49484")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xE494DC", Offset = "0xE494DC", VA = "0xE494DC")]
			set
			{
			}
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xE293FC", Offset = "0xE293FC", VA = "0xE293FC")]
		public static void StartPlaylistOnClip(string v1, string v2)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xE2943C", Offset = "0xE2943C", VA = "0xE2943C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Init()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xE294C4", Offset = "0xE294C4", VA = "0xE294C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xE2C778", Offset = "0xE2C778", VA = "0xE2C778")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xE2C924", Offset = "0xE2C924", VA = "0xE2C924")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xE2CBD4", Offset = "0xE2CBD4", VA = "0xE2CBD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xE2E168", Offset = "0xE2E168", VA = "0xE2E168")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xE2E1FC", Offset = "0xE2E1FC", VA = "0xE2E1FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xE2E178", Offset = "0xE2E178", VA = "0xE2E178")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xE2B674", Offset = "0xE2B674", VA = "0xE2B674")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xE25C10", Offset = "0xE25C10", VA = "0xE25C10")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xE25DF4", Offset = "0xE25DF4", VA = "0xE25DF4")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xE2E558", Offset = "0xE2E558", VA = "0xE2E558")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xE2E75C", Offset = "0xE2E75C", VA = "0xE2E75C")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xE2E210", Offset = "0xE2E210", VA = "0xE2E210")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xE2E09C", Offset = "0xE2E09C", VA = "0xE2E09C")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xE2DD44", Offset = "0xE2DD44", VA = "0xE2DD44")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xE2CC5C", Offset = "0xE2CC5C", VA = "0xE2CC5C")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xE2CF48", Offset = "0xE2CF48", VA = "0xE2CF48")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xE2D44C", Offset = "0xE2D44C", VA = "0xE2D44C")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xE2D9AC", Offset = "0xE2D9AC", VA = "0xE2D9AC")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xE2D7AC", Offset = "0xE2D7AC", VA = "0xE2D7AC")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xE2D250", Offset = "0xE2D250", VA = "0xE2D250")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xE2F6CC", Offset = "0xE2F6CC", VA = "0xE2F6CC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xE2F758", Offset = "0xE2F758", VA = "0xE2F758")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE25644", Offset = "0xE25644", VA = "0xE25644")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE312F8", Offset = "0xE312F8", VA = "0xE312F8")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE31498", Offset = "0xE31498", VA = "0xE31498")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE3164C", Offset = "0xE3164C", VA = "0xE3164C")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE25440", Offset = "0xE25440", VA = "0xE25440")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE31824", Offset = "0xE31824", VA = "0xE31824")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE2523C", Offset = "0xE2523C", VA = "0xE2523C")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE319FC", Offset = "0xE319FC", VA = "0xE319FC")]
		[IteratorStateMachine(typeof(<PlaySoundAndWaitUntilFinished>d__240))]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xE31AC8", Offset = "0xE31AC8", VA = "0xE31AC8")]
		[IteratorStateMachine(typeof(<PlaySound3DAtTransformAndWaitUntilFinished>d__241))]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xE31BBC", Offset = "0xE31BBC", VA = "0xE31BBC")]
		[IteratorStateMachine(typeof(<PlaySound3DFollowTransformAndWaitUntilFinished>d__242))]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xE312D4", Offset = "0xE312D4", VA = "0xE312D4")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xE2FA6C", Offset = "0xE2FA6C", VA = "0xE2FA6C")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xE32440", Offset = "0xE32440", VA = "0xE32440")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE31EA8", Offset = "0xE31EA8", VA = "0xE31EA8")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE321DC", Offset = "0xE321DC", VA = "0xE321DC")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE3270C", Offset = "0xE3270C", VA = "0xE3270C")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE24A24", Offset = "0xE24A24", VA = "0xE24A24")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE32E44", Offset = "0xE32E44", VA = "0xE32E44")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE33280", Offset = "0xE33280", VA = "0xE33280")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE3354C", Offset = "0xE3354C", VA = "0xE3354C")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE33710", Offset = "0xE33710", VA = "0xE33710")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0xE33970", Offset = "0xE33970", VA = "0xE33970")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE33B34", Offset = "0xE33B34", VA = "0xE33B34")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE33D94", Offset = "0xE33D94", VA = "0xE33D94")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE33F58", Offset = "0xE33F58", VA = "0xE33F58")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE34508", Offset = "0xE34508", VA = "0xE34508")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE2F1F4", Offset = "0xE2F1F4", VA = "0xE2F1F4")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE32470", Offset = "0xE32470", VA = "0xE32470")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xE347F8", Offset = "0xE347F8", VA = "0xE347F8")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE3414C", Offset = "0xE3414C", VA = "0xE3414C")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE34B58", Offset = "0xE34B58", VA = "0xE34B58")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE34F94", Offset = "0xE34F94", VA = "0xE34F94")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE351FC", Offset = "0xE351FC", VA = "0xE351FC")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE35DE4", Offset = "0xE35DE4", VA = "0xE35DE4")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE36618", Offset = "0xE36618", VA = "0xE36618")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE36994", Offset = "0xE36994", VA = "0xE36994")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE36CAC", Offset = "0xE36CAC", VA = "0xE36CAC")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xE36E74", Offset = "0xE36E74", VA = "0xE36E74")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xE24508", Offset = "0xE24508", VA = "0xE24508")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0xE3710C", Offset = "0xE3710C", VA = "0xE3710C")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xE37410", Offset = "0xE37410", VA = "0xE37410")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0xE37520", Offset = "0xE37520", VA = "0xE37520")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0xE37708", Offset = "0xE37708", VA = "0xE37708")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0xE382A4", Offset = "0xE382A4", VA = "0xE382A4")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0xE2E8C8", Offset = "0xE2E8C8", VA = "0xE2E8C8")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0xE38BA0", Offset = "0xE38BA0", VA = "0xE38BA0")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0xE38C34", Offset = "0xE38C34", VA = "0xE38C34")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0xE38D84", Offset = "0xE38D84", VA = "0xE38D84")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xE38ED4", Offset = "0xE38ED4", VA = "0xE38ED4")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xE3904C", Offset = "0xE3904C", VA = "0xE3904C")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xE3919C", Offset = "0xE3919C", VA = "0xE3919C")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xE395E0", Offset = "0xE395E0", VA = "0xE395E0")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE3979C", Offset = "0xE3979C", VA = "0xE3979C")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0xE3993C", Offset = "0xE3993C", VA = "0xE3993C")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xE39F64", Offset = "0xE39F64", VA = "0xE39F64")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE3A740", Offset = "0xE3A740", VA = "0xE3A740")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE3B958", Offset = "0xE3B958", VA = "0xE3B958")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE2EF80", Offset = "0xE2EF80", VA = "0xE2EF80")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE2C650", Offset = "0xE2C650", VA = "0xE2C650")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE3BB18", Offset = "0xE3BB18", VA = "0xE3BB18")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE2B3A8", Offset = "0xE2B3A8", VA = "0xE2B3A8")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE3BDC8", Offset = "0xE3BDC8", VA = "0xE3BDC8")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE3BC04", Offset = "0xE3BC04", VA = "0xE3BC04")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE2C9C4", Offset = "0xE2C9C4", VA = "0xE2C9C4")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE3A4B8", Offset = "0xE3A4B8", VA = "0xE3A4B8")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE3BE5C", Offset = "0xE3BE5C", VA = "0xE3BE5C")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE3BA04", Offset = "0xE3BA04", VA = "0xE3BA04")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE37E84", Offset = "0xE37E84", VA = "0xE37E84")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE38210", Offset = "0xE38210", VA = "0xE38210")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE3C29C", Offset = "0xE3C29C", VA = "0xE3C29C")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE3C464", Offset = "0xE3C464", VA = "0xE3C464")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE3C0CC", Offset = "0xE3C0CC", VA = "0xE3C0CC")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE3C59C", Offset = "0xE3C59C", VA = "0xE3C59C")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE3C6D4", Offset = "0xE3C6D4", VA = "0xE3C6D4")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE3301C", Offset = "0xE3301C", VA = "0xE3301C")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE25150", Offset = "0xE25150", VA = "0xE25150")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE3C7EC", Offset = "0xE3C7EC", VA = "0xE3C7EC")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE3C9C0", Offset = "0xE3C9C0", VA = "0xE3C9C0")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE3CB1C", Offset = "0xE3CB1C", VA = "0xE3CB1C")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE3CBF0", Offset = "0xE3CBF0", VA = "0xE3CBF0")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE3CD58", Offset = "0xE3CD58", VA = "0xE3CD58")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE3CE3C", Offset = "0xE3CE3C", VA = "0xE3CE3C")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE3CFC0", Offset = "0xE3CFC0", VA = "0xE3CFC0")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE3D1CC", Offset = "0xE3D1CC", VA = "0xE3D1CC")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE3D3D8", Offset = "0xE3D3D8", VA = "0xE3D3D8")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE3D650", Offset = "0xE3D650", VA = "0xE3D650")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE3D8D0", Offset = "0xE3D8D0", VA = "0xE3D8D0")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE3D980", Offset = "0xE3D980", VA = "0xE3D980")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE3DA30", Offset = "0xE3DA30", VA = "0xE3DA30")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE3DAE0", Offset = "0xE3DAE0", VA = "0xE3DAE0")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE3DF34", Offset = "0xE3DF34", VA = "0xE3DF34")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE3DFE8", Offset = "0xE3DFE8", VA = "0xE3DFE8")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE2F55C", Offset = "0xE2F55C", VA = "0xE2F55C")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE37DF4", Offset = "0xE37DF4", VA = "0xE37DF4")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE3E2E8", Offset = "0xE3E2E8", VA = "0xE3E2E8")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE3E47C", Offset = "0xE3E47C", VA = "0xE3E47C")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE3E88C", Offset = "0xE3E88C", VA = "0xE3E88C")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE3EA04", Offset = "0xE3EA04", VA = "0xE3EA04")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE3EAC8", Offset = "0xE3EAC8", VA = "0xE3EAC8")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE3EC28", Offset = "0xE3EC28", VA = "0xE3EC28")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE3E714", Offset = "0xE3E714", VA = "0xE3E714")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE3EDDC", Offset = "0xE3EDDC", VA = "0xE3EDDC")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0xE31F34", Offset = "0xE31F34", VA = "0xE31F34")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE2EDCC", Offset = "0xE2EDCC", VA = "0xE2EDCC")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE3EF38", Offset = "0xE3EF38", VA = "0xE3EF38")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE3F080", Offset = "0xE3F080", VA = "0xE3F080")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE3F380", Offset = "0xE3F380", VA = "0xE3F380")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE3F408", Offset = "0xE3F408", VA = "0xE3F408")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE32DA4", Offset = "0xE32DA4", VA = "0xE32DA4")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE3F878", Offset = "0xE3F878", VA = "0xE3F878")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0xE3FCE0", Offset = "0xE3FCE0", VA = "0xE3FCE0")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE3FEF8", Offset = "0xE3FEF8", VA = "0xE3FEF8")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE400F4", Offset = "0xE400F4", VA = "0xE400F4")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE2B570", Offset = "0xE2B570", VA = "0xE2B570")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE3F6B8", Offset = "0xE3F6B8", VA = "0xE3F6B8")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE38004", Offset = "0xE38004", VA = "0xE38004")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE3E630", Offset = "0xE3E630", VA = "0xE3E630")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE40818", Offset = "0xE40818", VA = "0xE40818")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xE409B8", Offset = "0xE409B8", VA = "0xE409B8")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xE40B58", Offset = "0xE40B58", VA = "0xE40B58")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xE40D64", Offset = "0xE40D64", VA = "0xE40D64")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xE40F34", Offset = "0xE40F34", VA = "0xE40F34")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE41044", Offset = "0xE41044", VA = "0xE41044")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE4123C", Offset = "0xE4123C", VA = "0xE4123C")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE41358", Offset = "0xE41358", VA = "0xE41358")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE413BC", Offset = "0xE413BC", VA = "0xE413BC")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE3DED4", Offset = "0xE3DED4", VA = "0xE3DED4")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE416EC", Offset = "0xE416EC", VA = "0xE416EC")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE418A8", Offset = "0xE418A8", VA = "0xE418A8")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0xE4190C", Offset = "0xE4190C", VA = "0xE4190C")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE3DF88", Offset = "0xE3DF88", VA = "0xE3DF88")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE41B6C", Offset = "0xE41B6C", VA = "0xE41B6C")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE41C44", Offset = "0xE41C44", VA = "0xE41C44")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE41CA8", Offset = "0xE41CA8", VA = "0xE41CA8")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE41F98", Offset = "0xE41F98", VA = "0xE41F98")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE41F08", Offset = "0xE41F08", VA = "0xE41F08")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE41FF8", Offset = "0xE41FF8", VA = "0xE41FF8")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE4205C", Offset = "0xE4205C", VA = "0xE4205C")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE3D9D0", Offset = "0xE3D9D0", VA = "0xE3D9D0")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE422BC", Offset = "0xE422BC", VA = "0xE422BC")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE4234C", Offset = "0xE4234C", VA = "0xE4234C")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE423B0", Offset = "0xE423B0", VA = "0xE423B0")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE3DA80", Offset = "0xE3DA80", VA = "0xE3DA80")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE42610", Offset = "0xE42610", VA = "0xE42610")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE426A0", Offset = "0xE426A0", VA = "0xE426A0")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE42704", Offset = "0xE42704", VA = "0xE42704")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE3D920", Offset = "0xE3D920", VA = "0xE3D920")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE42964", Offset = "0xE42964", VA = "0xE42964")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE429F8", Offset = "0xE429F8", VA = "0xE429F8")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE42A5C", Offset = "0xE42A5C", VA = "0xE42A5C")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE42D4C", Offset = "0xE42D4C", VA = "0xE42D4C")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE42CBC", Offset = "0xE42CBC", VA = "0xE42CBC")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE42DAC", Offset = "0xE42DAC", VA = "0xE42DAC")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE42E10", Offset = "0xE42E10", VA = "0xE42E10")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE43100", Offset = "0xE43100", VA = "0xE43100")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE43070", Offset = "0xE43070", VA = "0xE43070")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE43160", Offset = "0xE43160", VA = "0xE43160")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE431C4", Offset = "0xE431C4", VA = "0xE431C4")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE43484", Offset = "0xE43484", VA = "0xE43484")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE433F4", Offset = "0xE433F4", VA = "0xE433F4")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE434E4", Offset = "0xE434E4", VA = "0xE434E4")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE43550", Offset = "0xE43550", VA = "0xE43550")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE437D8", Offset = "0xE437D8", VA = "0xE437D8")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE438C8", Offset = "0xE438C8", VA = "0xE438C8")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE4392C", Offset = "0xE4392C", VA = "0xE4392C")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0xE43838", Offset = "0xE43838", VA = "0xE43838")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE43B5C", Offset = "0xE43B5C", VA = "0xE43B5C")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE43C4C", Offset = "0xE43C4C", VA = "0xE43C4C")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE43CB0", Offset = "0xE43CB0", VA = "0xE43CB0")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE43BBC", Offset = "0xE43BBC", VA = "0xE43BBC")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xE43EE0", Offset = "0xE43EE0", VA = "0xE43EE0")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE43F4C", Offset = "0xE43F4C", VA = "0xE43F4C")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE440CC", Offset = "0xE440CC", VA = "0xE440CC")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE44138", Offset = "0xE44138", VA = "0xE44138")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE442B8", Offset = "0xE442B8", VA = "0xE442B8")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE44334", Offset = "0xE44334", VA = "0xE44334")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE444B8", Offset = "0xE444B8", VA = "0xE444B8")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE44534", Offset = "0xE44534", VA = "0xE44534")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xE44904", Offset = "0xE44904", VA = "0xE44904")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE447B0", Offset = "0xE447B0", VA = "0xE447B0")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE4497C", Offset = "0xE4497C", VA = "0xE4497C")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE44B18", Offset = "0xE44B18", VA = "0xE44B18")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE44CC4", Offset = "0xE44CC4", VA = "0xE44CC4")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE44F68", Offset = "0xE44F68", VA = "0xE44F68")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE450B0", Offset = "0xE450B0", VA = "0xE450B0")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE45454", Offset = "0xE45454", VA = "0xE45454")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE45854", Offset = "0xE45854", VA = "0xE45854")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0xE45CA4", Offset = "0xE45CA4", VA = "0xE45CA4")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xE46018", Offset = "0xE46018", VA = "0xE46018")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xE4629C", Offset = "0xE4629C", VA = "0xE4629C")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xE46668", Offset = "0xE46668", VA = "0xE46668")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xE4681C", Offset = "0xE4681C", VA = "0xE4681C")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xE2B820", Offset = "0xE2B820", VA = "0xE2B820")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xE452D8", Offset = "0xE452D8", VA = "0xE452D8")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xE46970", Offset = "0xE46970", VA = "0xE46970")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0xE46ADC", Offset = "0xE46ADC", VA = "0xE46ADC")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xE46C48", Offset = "0xE46C48", VA = "0xE46C48")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0xE31CB0", Offset = "0xE31CB0", VA = "0xE31CB0")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xE31DA4", Offset = "0xE31DA4", VA = "0xE31DA4")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xE28C98", Offset = "0xE28C98", VA = "0xE28C98")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xE47114", Offset = "0xE47114", VA = "0xE47114")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xE28118", Offset = "0xE28118", VA = "0xE28118")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xE47224", Offset = "0xE47224", VA = "0xE47224")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xE4161C", Offset = "0xE4161C", VA = "0xE4161C")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xE4744C", Offset = "0xE4744C", VA = "0xE4744C")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xE476E8", Offset = "0xE476E8", VA = "0xE476E8")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xE47898", Offset = "0xE47898", VA = "0xE47898")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xE23434", Offset = "0xE23434", VA = "0xE23434")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xE23FFC", Offset = "0xE23FFC", VA = "0xE23FFC")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xE23DD0", Offset = "0xE23DD0", VA = "0xE23DD0")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xE24360", Offset = "0xE24360", VA = "0xE24360")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xE47AE8", Offset = "0xE47AE8", VA = "0xE47AE8")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xE47B60", Offset = "0xE47B60", VA = "0xE47B60")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xE267F8", Offset = "0xE267F8", VA = "0xE267F8")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xE236EC", Offset = "0xE236EC", VA = "0xE236EC")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xE24210", Offset = "0xE24210", VA = "0xE24210")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xE231A4", Offset = "0xE231A4", VA = "0xE231A4")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xE34748", Offset = "0xE34748", VA = "0xE34748")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xE2506C", Offset = "0xE2506C", VA = "0xE2506C")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE3A6E0", Offset = "0xE3A6E0", VA = "0xE3A6E0")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE49368", Offset = "0xE49368", VA = "0xE49368")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE4953C", Offset = "0xE4953C", VA = "0xE4953C")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xE496D4", Offset = "0xE496D4", VA = "0xE496D4")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE4986C", Offset = "0xE4986C", VA = "0xE4986C")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE49A04", Offset = "0xE49A04", VA = "0xE49A04")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xE49B9C", Offset = "0xE49B9C", VA = "0xE49B9C")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000534")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000535")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000536")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000537")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000538")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000539")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x400053A")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x400053B")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400053C")]
		public const string Separator = ";";

		[Token(Token = "0x1700008C")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0xE4D82C", Offset = "0xE4D82C", VA = "0xE4D82C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000352")]
			[Address(RVA = "0xE4D8A4", Offset = "0xE4D8A4", VA = "0xE4D8A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0xE4D9C0", Offset = "0xE4D9C0", VA = "0xE4D9C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xE4DA38", Offset = "0xE4DA38", VA = "0xE4DA38")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xE4DCA8", Offset = "0xE4DCA8", VA = "0xE4DCA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xE4DD3C", Offset = "0xE4DD3C", VA = "0xE4DD3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public static float? MixerVolume
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0xE4DE74", Offset = "0xE4DE74", VA = "0xE4DE74")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xE4DF00", Offset = "0xE4DF00", VA = "0xE4DF00")]
			set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0xE4E030", Offset = "0xE4E030", VA = "0xE4E030")]
			get
			{
				return null;
			}
			[Token(Token = "0x600035F")]
			[Address(RVA = "0xE4E0C4", Offset = "0xE4E0C4", VA = "0xE4E0C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public static float? MusicVolume
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0xE4E1FC", Offset = "0xE4E1FC", VA = "0xE4E1FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000361")]
			[Address(RVA = "0xE4E288", Offset = "0xE4E288", VA = "0xE4E288")]
			set
			{
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xE4D66C", Offset = "0xE4D66C", VA = "0xE4D66C")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xE4D7E0", Offset = "0xE4D7E0", VA = "0xE4D7E0")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xE4D8F0", Offset = "0xE4D8F0", VA = "0xE4D8F0")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xE4D974", Offset = "0xE4D974", VA = "0xE4D974")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xE4DA84", Offset = "0xE4DA84", VA = "0xE4DA84")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xE4DC24", Offset = "0xE4DC24", VA = "0xE4DC24")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xE4E3B8", Offset = "0xE4E3B8", VA = "0xE4E3B8")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x20000A9")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000365")]
			[Address(RVA = "0xE4E8CC", Offset = "0xE4E8CC", VA = "0xE4E8CC")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000AA")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000366")]
			[Address(RVA = "0xE4E908", Offset = "0xE4E908", VA = "0xE4E908")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x20000AB")]
		public enum MAItemType
		{
			[Token(Token = "0x4000558")]
			SoundGroups,
			[Token(Token = "0x4000559")]
			CustomEvents
		}

		[Token(Token = "0x20000AC")]
		public enum TransferMode
		{
			[Token(Token = "0x400055B")]
			None,
			[Token(Token = "0x400055C")]
			Import,
			[Token(Token = "0x400055D")]
			Export
		}

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xE4E568", Offset = "0xE4E568", VA = "0xE4E568")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xE4E5D0", Offset = "0xE4E5D0", VA = "0xE4E5D0")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public static class AmbientUtil
	{
		[Token(Token = "0x400055E")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x400055F")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x4000560")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x4000561")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x17000092")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0xE4EFD4", Offset = "0xE4EFD4", VA = "0xE4EFD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000093")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0xE4E9E4", Offset = "0xE4E9E4", VA = "0xE4E9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0xE4F494", Offset = "0xE4F494", VA = "0xE4F494")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000095")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xE4F520", Offset = "0xE4F520", VA = "0xE4F520")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xE4E944", Offset = "0xE4E944", VA = "0xE4E944")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xE4EEB8", Offset = "0xE4EEB8", VA = "0xE4EEB8")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xE4EF4C", Offset = "0xE4EF4C", VA = "0xE4EF4C")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xE4EFCC", Offset = "0xE4EFCC", VA = "0xE4EFCC")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xE4F2E8", Offset = "0xE4F2E8", VA = "0xE4F2E8")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xE4F3CC", Offset = "0xE4F3CC", VA = "0xE4F3CC")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xE4F5B8", Offset = "0xE4F5B8", VA = "0xE4F5B8")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xE4F6C0", Offset = "0xE4F6C0", VA = "0xE4F6C0")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AF")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xE4F740", Offset = "0xE4F740", VA = "0xE4F740")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xE4F7B8", Offset = "0xE4F7B8", VA = "0xE4F7B8")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xE4F810", Offset = "0xE4F810", VA = "0xE4F810")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xE4F8B0", Offset = "0xE4F8B0", VA = "0xE4F8B0")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xE4F964", Offset = "0xE4F964", VA = "0xE4F964")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xE4FA04", Offset = "0xE4FA04", VA = "0xE4FA04")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xE4FAB8", Offset = "0xE4FAB8", VA = "0xE4FAB8")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xE4FB70", Offset = "0xE4FB70", VA = "0xE4FB70")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xE4FC28", Offset = "0xE4FC28", VA = "0xE4FC28")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xE4FC80", Offset = "0xE4FC80", VA = "0xE4FC80")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xE4FCE8", Offset = "0xE4FCE8", VA = "0xE4FCE8")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xE4FD50", Offset = "0xE4FD50", VA = "0xE4FD50")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xE4FDA8", Offset = "0xE4FDA8", VA = "0xE4FDA8")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xE4FE10", Offset = "0xE4FE10", VA = "0xE4FE10")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xE4FE78", Offset = "0xE4FE78", VA = "0xE4FE78")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0xE4FED0", Offset = "0xE4FED0", VA = "0xE4FED0")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xE4FF38", Offset = "0xE4FF38", VA = "0xE4FF38")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xE4FFA0", Offset = "0xE4FFA0", VA = "0xE4FFA0")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B0")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x17000096")]
		public Transform Trans
		{
			[Token(Token = "0x6000386")]
			[Address(RVA = "0xE50008", Offset = "0xE50008", VA = "0xE50008")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xE5009C", Offset = "0xE5009C", VA = "0xE5009C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xE500AC", Offset = "0xE500AC", VA = "0xE500AC")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public static class AudioUtil
	{
		[Token(Token = "0x4000567")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x4000568")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x4000569")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x17000097")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x600038C")]
			[Address(RVA = "0xE50118", Offset = "0xE50118", VA = "0xE50118")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000098")]
		public static float FrameTime
		{
			[Token(Token = "0x600038D")]
			[Address(RVA = "0xE50120", Offset = "0xE50120", VA = "0xE50120")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000099")]
		public static float Time
		{
			[Token(Token = "0x600038E")]
			[Address(RVA = "0xE50128", Offset = "0xE50128", VA = "0xE50128")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009A")]
		public static int FrameCount
		{
			[Token(Token = "0x600038F")]
			[Address(RVA = "0xE50130", Offset = "0xE50130", VA = "0xE50130")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xE500B4", Offset = "0xE500B4", VA = "0xE500B4")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xE500F0", Offset = "0xE500F0", VA = "0xE500F0")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xE50104", Offset = "0xE50104", VA = "0xE50104")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xE50138", Offset = "0xE50138", VA = "0xE50138")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xE50178", Offset = "0xE50178", VA = "0xE50178")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xE50250", Offset = "0xE50250", VA = "0xE50250")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xE50290", Offset = "0xE50290", VA = "0xE50290")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xE502A8", Offset = "0xE502A8", VA = "0xE502A8")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xE502B8", Offset = "0xE502B8", VA = "0xE502B8")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xE50394", Offset = "0xE50394", VA = "0xE50394")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xE503D0", Offset = "0xE503D0", VA = "0xE503D0")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xE504CC", Offset = "0xE504CC", VA = "0xE504CC")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xE50448", Offset = "0xE50448", VA = "0xE50448")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xE505AC", Offset = "0xE505AC", VA = "0xE505AC")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xE50634", Offset = "0xE50634", VA = "0xE50634")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xE5065C", Offset = "0xE5065C", VA = "0xE5065C")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xE5066C", Offset = "0xE5066C", VA = "0xE5066C")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xE506A4", Offset = "0xE506A4", VA = "0xE506A4")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xE506B8", Offset = "0xE506B8", VA = "0xE506B8")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B2")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003A4")]
				[Address(RVA = "0xE50834", Offset = "0xE50834", VA = "0xE50834", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003A6")]
				[Address(RVA = "0xE5087C", Offset = "0xE5087C", VA = "0xE5087C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0xE50748", Offset = "0xE50748", VA = "0xE50748")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xE50770", Offset = "0xE50770", VA = "0xE50770", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0xE50774", Offset = "0xE50774", VA = "0xE50774", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0xE5083C", Offset = "0xE5083C", VA = "0xE5083C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xE506D8", Offset = "0xE506D8", VA = "0xE506D8")]
		[IteratorStateMachine(typeof(<WaitForActualSeconds>d__0))]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x20000B4")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x1700009D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60003AF")]
				[Address(RVA = "0xE51068", Offset = "0xE51068", VA = "0xE51068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0xE510B0", Offset = "0xE510B0", VA = "0xE510B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0xE50E10", Offset = "0xE50E10", VA = "0xE50E10")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0xE50E9C", Offset = "0xE50E9C", VA = "0xE50E9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xE50EA0", Offset = "0xE50EA0", VA = "0xE50EA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xE51070", Offset = "0xE51070", VA = "0xE51070", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xE50884", Offset = "0xE50884", VA = "0xE50884")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xE50C4C", Offset = "0xE50C4C", VA = "0xE50C4C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xE50D70", Offset = "0xE50D70", VA = "0xE50D70")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xE50D9C", Offset = "0xE50D9C", VA = "0xE50D9C")]
		[IteratorStateMachine(typeof(<PlaySongWithDelay>d__7))]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xE50E38", Offset = "0xE50E38", VA = "0xE50E38")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xE4F2D4", Offset = "0xE4F2D4", VA = "0xE4F2D4")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xE510B8", Offset = "0xE510B8", VA = "0xE510B8")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xE510CC", Offset = "0xE510CC", VA = "0xE510CC")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xE4ECA4", Offset = "0xE4ECA4", VA = "0xE4ECA4")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	[AudioScriptOrder(-35)]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x20000B8")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000597")]
			FirstEnableOnly,
			[Token(Token = "0x4000598")]
			EveryEnable
		}

		[Token(Token = "0x4000575")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x1700009F")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0xE526C0", Offset = "0xE526C0", VA = "0xE526C0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A0")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xE5272C", Offset = "0xE5272C", VA = "0xE5272C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A1")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0xE52734", Offset = "0xE52734", VA = "0xE52734")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xE510E4", Offset = "0xE510E4", VA = "0xE510E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xE511C0", Offset = "0xE511C0", VA = "0xE511C0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xE51298", Offset = "0xE51298", VA = "0xE51298")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xE5129C", Offset = "0xE5129C", VA = "0xE5129C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xE511C4", Offset = "0xE511C4", VA = "0xE511C4")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE51398", Offset = "0xE51398", VA = "0xE51398")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xE51780", Offset = "0xE51780", VA = "0xE51780")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xE526C8", Offset = "0xE526C8", VA = "0xE526C8")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xE5237C", Offset = "0xE5237C", VA = "0xE5237C")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xE5273C", Offset = "0xE5273C", VA = "0xE5273C")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x400059E")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x400059F")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xE52BD8", Offset = "0xE52BD8", VA = "0xE52BD8")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE53080", Offset = "0xE53080", VA = "0xE53080")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE530F4", Offset = "0xE530F4", VA = "0xE530F4")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE531E8", Offset = "0xE531E8", VA = "0xE531E8")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE53328", Offset = "0xE53328", VA = "0xE53328")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE53470", Offset = "0xE53470", VA = "0xE53470")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE535B4", Offset = "0xE535B4", VA = "0xE535B4")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE53680", Offset = "0xE53680", VA = "0xE53680")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE5378C", Offset = "0xE5378C", VA = "0xE5378C")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE53910", Offset = "0xE53910", VA = "0xE53910")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE53A64", Offset = "0xE53A64", VA = "0xE53A64")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xE53BE0", Offset = "0xE53BE0", VA = "0xE53BE0")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xE53D34", Offset = "0xE53D34", VA = "0xE53D34")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xE53E30", Offset = "0xE53E30", VA = "0xE53E30")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xE53F90", Offset = "0xE53F90", VA = "0xE53F90")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xE54004", Offset = "0xE54004", VA = "0xE54004")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xE54070", Offset = "0xE54070", VA = "0xE54070")]
		public static void Flush()
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xE541F0", Offset = "0xE541F0", VA = "0xE541F0")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xE52D84", Offset = "0xE52D84", VA = "0xE52D84")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xE54728", Offset = "0xE54728", VA = "0xE54728")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE547D0", Offset = "0xE547D0", VA = "0xE547D0")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xE54878", Offset = "0xE54878", VA = "0xE54878")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	[RequireComponent(typeof(AudioSource))]
	[AudioScriptOrder(-80)]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40005FA")]
			PlayNow,
			[Token(Token = "0x40005FB")]
			Schedule,
			[Token(Token = "0x40005FC")]
			AlreadyScheduled
		}

		[Token(Token = "0x20000BD")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40005FE")]
			NotInScene,
			[Token(Token = "0x40005FF")]
			Stopped,
			[Token(Token = "0x4000600")]
			Playing,
			[Token(Token = "0x4000601")]
			Paused,
			[Token(Token = "0x4000602")]
			Crossfading
		}

		[Token(Token = "0x20000BE")]
		public enum FadeMode
		{
			[Token(Token = "0x4000604")]
			None,
			[Token(Token = "0x4000605")]
			GradualFade
		}

		[Token(Token = "0x20000BF")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x4000607")]
			NotDucking,
			[Token(Token = "0x4000608")]
			SetToDuck,
			[Token(Token = "0x4000609")]
			Ducked
		}

		[Token(Token = "0x20000C0")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x20000C1")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x20000C2")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x20000C3")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x40005A1")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x40005A2")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x40005A3")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x40005A4")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x40005A5")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x40005A6")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private AudioSource _audio1;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private AudioSource _audio2;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string _activeSongAlias;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Transform _trans;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _willPersist;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private double? _songPauseTime;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int framesOfSongPlayed;

		[Token(Token = "0x170000A2")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xE5B154", Offset = "0xE5B154", VA = "0xE5B154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xE5B1A0", Offset = "0xE5B1A0", VA = "0xE5B1A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xE5B1A8", Offset = "0xE5B1A8", VA = "0xE5B1A8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000A4")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xE57184", Offset = "0xE57184", VA = "0xE57184")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000A5")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xE56468", Offset = "0xE56468", VA = "0xE56468")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xE5745C", Offset = "0xE5745C", VA = "0xE5745C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xE5B1B4", Offset = "0xE5B1B4", VA = "0xE5B1B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xE5B20C", Offset = "0xE5B20C", VA = "0xE5B20C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xE5B214", Offset = "0xE5B214", VA = "0xE5B214")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xE5B21C", Offset = "0xE5B21C", VA = "0xE5B21C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xE5B2A4", Offset = "0xE5B2A4", VA = "0xE5B2A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xE5B334", Offset = "0xE5B334", VA = "0xE5B334")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public bool IsCrossFading
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xE5B34C", Offset = "0xE5B34C", VA = "0xE5B34C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xE5B354", Offset = "0xE5B354", VA = "0xE5B354")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool IsFading
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xE5B360", Offset = "0xE5B360", VA = "0xE5B360")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AE")]
		public float PlaylistVolume
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0xE59D80", Offset = "0xE59D80", VA = "0xE59D80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000430")]
			[Address(RVA = "0xE5B380", Offset = "0xE5B380", VA = "0xE5B380")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x6000432")]
			[Address(RVA = "0xE5A2AC", Offset = "0xE5A2AC", VA = "0xE5A2AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		public bool HasPlaylist
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0xE577B0", Offset = "0xE577B0", VA = "0xE577B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public string PlaylistName
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0xE5B3C8", Offset = "0xE5B3C8", VA = "0xE5B3C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private bool IsMuted
		{
			[Token(Token = "0x6000435")]
			[Address(RVA = "0xE5B438", Offset = "0xE5B438", VA = "0xE5B438")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0xE57934", Offset = "0xE57934", VA = "0xE57934")]
			set
			{
			}
		}

		[Token(Token = "0x170000B4")]
		private float CrossFadeTime
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xE56FCC", Offset = "0xE56FCC", VA = "0xE56FCC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0xE5704C", Offset = "0xE5704C", VA = "0xE5704C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B6")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0xE580E0", Offset = "0xE580E0", VA = "0xE580E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public string ControllerName
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0xE553C8", Offset = "0xE553C8", VA = "0xE553C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public bool CanSchedule
		{
			[Token(Token = "0x600043B")]
			[Address(RVA = "0xE56E64", Offset = "0xE56E64", VA = "0xE56E64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x600043C")]
			[Address(RVA = "0xE55AE0", Offset = "0xE55AE0", VA = "0xE55AE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BA")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xE57158", Offset = "0xE57158", VA = "0xE57158")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BB")]
		private Transform Trans
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xE559F8", Offset = "0xE559F8", VA = "0xE559F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xE5B440", Offset = "0xE5B440", VA = "0xE5B440")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0xE54AA0", Offset = "0xE54AA0", VA = "0xE54AA0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0xE54B40", Offset = "0xE54B40", VA = "0xE54B40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xE50BAC", Offset = "0xE50BAC", VA = "0xE50BAC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xE50CD0", Offset = "0xE50CD0", VA = "0xE50CD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xE54BE0", Offset = "0xE54BE0", VA = "0xE54BE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xE54C80", Offset = "0xE54C80", VA = "0xE54C80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xE54D20", Offset = "0xE54D20", VA = "0xE54D20")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xE54DC0", Offset = "0xE54DC0", VA = "0xE54DC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xE54E60", Offset = "0xE54E60", VA = "0xE54E60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xE55410", Offset = "0xE55410", VA = "0xE55410")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xE555F4", Offset = "0xE555F4", VA = "0xE555F4")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xE55760", Offset = "0xE55760", VA = "0xE55760")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xE55550", Offset = "0xE55550", VA = "0xE55550")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xE557EC", Offset = "0xE557EC", VA = "0xE557EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xE55A84", Offset = "0xE55A84", VA = "0xE55A84")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xE55B98", Offset = "0xE55B98", VA = "0xE55B98")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xE55FE8", Offset = "0xE55FE8", VA = "0xE55FE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xE56188", Offset = "0xE56188", VA = "0xE56188")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xE56528", Offset = "0xE56528", VA = "0xE56528")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xE56534", Offset = "0xE56534", VA = "0xE56534")]
		private void Update()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xE50928", Offset = "0xE50928", VA = "0xE50928")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xE5768C", Offset = "0xE5768C", VA = "0xE5768C")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xE577C0", Offset = "0xE577C0", VA = "0xE577C0")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xE57884", Offset = "0xE57884", VA = "0xE57884")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xE55AD8", Offset = "0xE55AD8", VA = "0xE55AD8")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xE5792C", Offset = "0xE5792C", VA = "0xE5792C")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xE57A88", Offset = "0xE57A88", VA = "0xE57A88")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xE57C6C", Offset = "0xE57C6C", VA = "0xE57C6C")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xE55EC0", Offset = "0xE55EC0", VA = "0xE55EC0")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xE5829C", Offset = "0xE5829C", VA = "0xE5829C")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xE583C4", Offset = "0xE583C4", VA = "0xE583C4")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xE5844C", Offset = "0xE5844C", VA = "0xE5844C")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xE5861C", Offset = "0xE5861C", VA = "0xE5861C")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xE58E1C", Offset = "0xE58E1C", VA = "0xE58E1C")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xE50FE0", Offset = "0xE50FE0", VA = "0xE50FE0")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xE58F68", Offset = "0xE58F68", VA = "0xE58F68")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xE590F0", Offset = "0xE590F0", VA = "0xE590F0")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xE59160", Offset = "0xE59160", VA = "0xE59160")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xE5934C", Offset = "0xE5934C", VA = "0xE5934C")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xE594DC", Offset = "0xE594DC", VA = "0xE594DC")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xE598D0", Offset = "0xE598D0", VA = "0xE598D0")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xE59BE4", Offset = "0xE59BE4", VA = "0xE59BE4")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xE59D58", Offset = "0xE59D58", VA = "0xE59D58")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xE55DB0", Offset = "0xE55DB0", VA = "0xE55DB0")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xE59DE0", Offset = "0xE59DE0", VA = "0xE59DE0")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xE59F24", Offset = "0xE59F24", VA = "0xE59F24")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xE58020", Offset = "0xE58020", VA = "0xE58020")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xE59E9C", Offset = "0xE59E9C", VA = "0xE59E9C")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xE5A060", Offset = "0xE5A060", VA = "0xE5A060")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xE5A14C", Offset = "0xE5A14C", VA = "0xE5A14C")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xE57270", Offset = "0xE57270", VA = "0xE57270")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xE559D0", Offset = "0xE559D0", VA = "0xE559D0")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0xE55B04", Offset = "0xE55B04", VA = "0xE55B04")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE57078", Offset = "0xE57078", VA = "0xE57078")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0xE58C14", Offset = "0xE58C14", VA = "0xE58C14")]
		private void FillClips()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE586AC", Offset = "0xE586AC", VA = "0xE586AC")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE5AD9C", Offset = "0xE5AD9C", VA = "0xE5AD9C")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE5A350", Offset = "0xE5A350", VA = "0xE5A350")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE5B044", Offset = "0xE5B044", VA = "0xE5B044")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xE594D4", Offset = "0xE594D4", VA = "0xE594D4")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0xE5736C", Offset = "0xE5736C", VA = "0xE5736C")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xE5AE58", Offset = "0xE5AE58", VA = "0xE5AE58")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xE5B0E0", Offset = "0xE5B0E0", VA = "0xE5B0E0")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xE5816C", Offset = "0xE5816C", VA = "0xE5816C")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0xE5AF30", Offset = "0xE5AF30", VA = "0xE5AF30")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xE56B8C", Offset = "0xE56B8C", VA = "0xE56B8C")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xE56EEC", Offset = "0xE56EEC", VA = "0xE56EEC")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xE57374", Offset = "0xE57374", VA = "0xE57374")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xE5A22C", Offset = "0xE5A22C", VA = "0xE5A22C")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xE5B388", Offset = "0xE5B388", VA = "0xE5B388")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xE5B488", Offset = "0xE5B488", VA = "0xE5B488")]
		public PlaylistController()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x400060E")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x400060F")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000BD")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xE5BC84", Offset = "0xE5BC84", VA = "0xE5BC84")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BE")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xE5BD14", Offset = "0xE5BD14", VA = "0xE5BD14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xE5BD60", Offset = "0xE5BD60", VA = "0xE5BD60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C0")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xE5BD0C", Offset = "0xE5BD0C", VA = "0xE5BD0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xE5BDAC", Offset = "0xE5BDAC", VA = "0xE5BDAC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xE5BDB4", Offset = "0xE5BDB4", VA = "0xE5BDB4")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public static class UtilStrings
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0xE5BED0", Offset = "0xE5BED0", VA = "0xE5BED0")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xE5BF48", Offset = "0xE5BF48", VA = "0xE5BF48")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
