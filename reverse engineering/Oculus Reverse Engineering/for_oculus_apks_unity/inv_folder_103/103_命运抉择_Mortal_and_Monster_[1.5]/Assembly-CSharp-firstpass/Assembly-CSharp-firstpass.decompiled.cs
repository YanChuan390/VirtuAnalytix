using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using DarkTonic.MasterAudio;
using Il2CppDummyDll;
using IniParser.Model;
using TableML;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public struct IntIntPair
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int key;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public int value;
}
[Token(Token = "0x2000003")]
public struct IntFloatPair
{
	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int key;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public float value;
}
[Token(Token = "0x2000004")]
public struct AlbumItem
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint id;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string image_url;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string image_thumb_url;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public uint type;
}
[Token(Token = "0x2000005")]
public struct ConfigItem
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int PlayType;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string Value;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xA16F3C", Offset = "0xA16F3C", VA = "0xA16F3C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public struct CustomAvatarData
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string avatar_name;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong res_id;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string icon_url;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string res_url;
}
[Token(Token = "0x2000007")]
public struct ActorData
{
	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public uint actor_type;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public ulong actor_uuid;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong home_uuid;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string actor_name;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int race;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<IntFloatPair> dnas;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<IntIntPair> wardrobe;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CustomAvatarData custom_avatar_data;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool has_profile_photo;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AlbumItem profile_photo;
}
[Token(Token = "0x2000008")]
public struct PlayerTransform
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public Vector3 pos;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Vector3 dir;
}
[Token(Token = "0x2000009")]
public struct PlayerInfo
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong player_id;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public PlayerTransform player_transform;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActorData actor_data;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public uint cam_view_type;
}
[Token(Token = "0x200000A")]
public struct RoomInfo
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong room_id;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string room_name;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool has_pwd;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ulong world_id;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint capacity;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong owner_id;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public uint num_of_people;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string owner_nick_name;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string world_name;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public uint tag;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string loader_script;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string res_url;
}
[Token(Token = "0x200000B")]
public struct DynamicObjectInfo
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public ulong obj_id;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Vector3 pos;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public Vector3 dir;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public uint obj_type;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ulong owner_id;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string res_url;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ulong room_id;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ulong res_id;
}
[Token(Token = "0x200000C")]
public enum TextResType
{
	[Token(Token = "0x4000034")]
	LUA,
	[Token(Token = "0x4000035")]
	RAW_CFG,
	[Token(Token = "0x4000036")]
	XLS
}
[Token(Token = "0x200000D")]
public class BaseUtil
{
	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool enableEncrypting;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static byte[] Keys;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static long encryptKey;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool isLuaFinished;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	private static bool isRawCfgFinished;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	private static bool isXlsCfgFinished;

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xC70590", Offset = "0xC70590", VA = "0xC70590")]
	public BaseUtil()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xC70598", Offset = "0xC70598", VA = "0xC70598")]
	public static byte[] EncryptText(byte[] encryptBytes)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xC70820", Offset = "0xC70820", VA = "0xC70820")]
	public static byte[] DecryptBytes(byte[] decryptBytes)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xC70AA8", Offset = "0xC70AA8", VA = "0xC70AA8")]
	public static byte[] DecryptText(byte[] decryptBytes)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xC70BAC", Offset = "0xC70BAC", VA = "0xC70BAC")]
	public static string ReadFileText(string path)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xC70BEC", Offset = "0xC70BEC", VA = "0xC70BEC")]
	public static byte[] ReadFileBytes(string path)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xC70C2C", Offset = "0xC70C2C", VA = "0xC70C2C")]
	public static void WriteFileText(string path, string str)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xC70C34", Offset = "0xC70C34", VA = "0xC70C34")]
	public static void WriteFileBytes(string path, byte[] bytes)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xC70C3C", Offset = "0xC70C3C", VA = "0xC70C3C")]
	public static void Encrypting(string fileName)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xC70D00", Offset = "0xC70D00", VA = "0xC70D00")]
	public static void ConfigProcessFinished(TextResType type)
	{
	}
}
[Token(Token = "0x200000E")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB11284", Offset = "0xB11284")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x17000001")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x11F6690", Offset = "0x11F6690", VA = "0x11F6690")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Transform Trans
	{
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x11F6600", Offset = "0x11F6600", VA = "0x11F6600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x11F633C", Offset = "0x11F633C", VA = "0x11F633C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x11F6340", Offset = "0x11F6340", VA = "0x11F6340")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x11F6380", Offset = "0x11F6380", VA = "0x11F6380")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x11F6484", Offset = "0x11F6484", VA = "0x11F6484")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x11F6720", Offset = "0x11F6720", VA = "0x11F6720")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x200000F")]
public static class OculusAudioHelper
{
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x11F8504", Offset = "0x11F8504", VA = "0x11F8504")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x11F850C", Offset = "0x11F850C", VA = "0x11F850C")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x11F8510", Offset = "0x11F8510", VA = "0x11F8510")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x11F8514", Offset = "0x11F8514", VA = "0x11F8514")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x11F8518", Offset = "0x11F8518", VA = "0x11F8518")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x11F851C", Offset = "0x11F851C", VA = "0x11F851C")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x11F8520", Offset = "0x11F8520", VA = "0x11F8520")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000010")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000003")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x11F853C", Offset = "0x11F853C", VA = "0x11F853C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x11F8544", Offset = "0x11F8544", VA = "0x11F8544")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x11F854C", Offset = "0x11F854C", VA = "0x11F854C")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x11F8550", Offset = "0x11F8550", VA = "0x11F8550")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x11F8554", Offset = "0x11F8554", VA = "0x11F8554")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x11F8558", Offset = "0x11F8558", VA = "0x11F8558")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x11F855C", Offset = "0x11F855C", VA = "0x11F855C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x11F8560", Offset = "0x11F8560", VA = "0x11F8560")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000011")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB11D68", Offset = "0xB11D68")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _soundType;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _variationName;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _willFollowSource;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _isInsideTrigger;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool _hasPlayedSound;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _playVolume;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _exitFadeTime;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000004")]
	public GameObject GameObj
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x11F8BAC", Offset = "0x11F8BAC", VA = "0x11F8BAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Transform Trans
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x11F9228", Offset = "0x11F9228", VA = "0x11F9228")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x11F8564", Offset = "0x11F8564", VA = "0x11F8564")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x11F8600", Offset = "0x11F8600", VA = "0x11F8600")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x11F87B8", Offset = "0x11F87B8", VA = "0x11F87B8")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x11F8B30", Offset = "0x11F8B30", VA = "0x11F8B30")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x11F8C3C", Offset = "0x11F8C3C", VA = "0x11F8C3C")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x11F90E0", Offset = "0x11F90E0", VA = "0x11F90E0")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x11F8A14", Offset = "0x11F8A14", VA = "0x11F8A14")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x11F8670", Offset = "0x11F8670", VA = "0x11F8670")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x11F92B8", Offset = "0x11F92B8", VA = "0x11F92B8")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000012")]
public delegate void KCallback(object[] data, [Optional] Exception err);
[Token(Token = "0x2000013")]
public class KSerializeMaterial : ScriptableObject
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string MaterialName;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ShaderName;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string ShaderPath;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<KSerializeMaterialProperty> Props;

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x11F3E6C", Offset = "0x11F3E6C", VA = "0x11F3E6C")]
	public KSerializeMaterial()
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class KSerializeMaterialProperty
{
	[Token(Token = "0x20000BC")]
	public enum ShaderType
	{
		[Token(Token = "0x400058C")]
		Texture,
		[Token(Token = "0x400058D")]
		Color,
		[Token(Token = "0x400058E")]
		Range,
		[Token(Token = "0x400058F")]
		Vector,
		[Token(Token = "0x4000590")]
		RenderTexture
	}

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ShaderType Type;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string PropName;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string PropValue;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x11F3EDC", Offset = "0x11F3EDC", VA = "0x11F3EDC")]
	public KSerializeMaterialProperty()
	{
	}
}
[Token(Token = "0x2000015")]
public abstract class KBehaviour : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _cachedTransform;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _cacheGameObject;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected bool IsDestroyed;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool _isApplicationQuited;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Action ApplicationQuitEvent;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float _TimeScale;

	[Token(Token = "0x17000006")]
	public Transform CachedTransform
	{
		[Token(Token = "0x6000034")]
		[Address(RVA = "0xE54190", Offset = "0xE54190", VA = "0xE54190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000007")]
	public GameObject CachedGameObject
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE541C4", Offset = "0xE541C4", VA = "0xE541C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000008")]
	public static bool IsApplicationQuited
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0xE54628", Offset = "0xE54628", VA = "0xE54628")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public virtual float TimeScale
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE54690", Offset = "0xE54690", VA = "0xE54690", Slot = "4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0xE54698", Offset = "0xE54698", VA = "0xE54698", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public static event Action<KBehaviour> StaticDestroyEvent
	{
		[Token(Token = "0x6000036")]
		[Address(RVA = "0xE541F8", Offset = "0xE541F8", VA = "0xE541F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B74", Offset = "0xB12B74")]
		add
		{
		}
		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE54324", Offset = "0xE54324", VA = "0xE54324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B84", Offset = "0xB12B84")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action<KBehaviour> DestroyEvent
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE54450", Offset = "0xE54450", VA = "0xE54450")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B94", Offset = "0xB12B94")]
		add
		{
		}
		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE5453C", Offset = "0xE5453C", VA = "0xE5453C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12BA4", Offset = "0xB12BA4")]
		remove
		{
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xE546A0", Offset = "0xE546A0", VA = "0xE546A0", Slot = "6")]
	public virtual void Delete()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xE546B0", Offset = "0xE546B0", VA = "0xE546B0", Slot = "7")]
	public virtual void Delete(float time)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xE54774", Offset = "0xE54774", VA = "0xE54774", Slot = "8")]
	public virtual void DeleteSelf()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xE547DC", Offset = "0xE547DC", VA = "0xE547DC", Slot = "9")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xE548C0", Offset = "0xE548C0", VA = "0xE548C0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xE549F4", Offset = "0xE549F4", VA = "0xE549F4")]
	protected KBehaviour()
	{
	}
}
[Token(Token = "0x2000016")]
public enum UnityLayerDef
{
	[Token(Token = "0x4000063")]
	Default = 0,
	[Token(Token = "0x4000064")]
	TransparentFX = 1,
	[Token(Token = "0x4000065")]
	IgnoreRaycast = 2,
	[Token(Token = "0x4000066")]
	Water = 4,
	[Token(Token = "0x4000067")]
	UI = 5
}
[Token(Token = "0x2000017")]
public interface IKTabReadble
{
	[Token(Token = "0x6000044")]
	bool HasColumn(string columnName);

	[Token(Token = "0x6000045")]
	int GetInteger(int row, string columnName);

	[Token(Token = "0x6000046")]
	string GetString(int row, string columnName);

	[Token(Token = "0x6000047")]
	string GetString(int row, int columnIndex);

	[Token(Token = "0x6000048")]
	float GetFloat(int row, string columnName);

	[Token(Token = "0x6000049")]
	bool GetBool(int row, string columnName);

	[Token(Token = "0x600004A")]
	double GetDouble(int row, string columnName);

	[Token(Token = "0x600004B")]
	uint GetUInteger(int row, string columnName);

	[Token(Token = "0x600004C")]
	int GetHeight();

	[Token(Token = "0x600004D")]
	int GetColumnCount();

	[Token(Token = "0x600004E")]
	void Close();
}
[Token(Token = "0x2000018")]
public static class KEngineExtensions
{
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x11F31C0", Offset = "0x11F31C0", VA = "0x11F31C0")]
	public static void SetWidth(this RectTransform rectTrans, float width)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x11F322C", Offset = "0x11F322C", VA = "0x11F322C")]
	public static void SetHeight(this RectTransform rectTrans, float height)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x11F3298", Offset = "0x11F3298", VA = "0x11F3298")]
	public static void SetPositionX(this Transform t, float newX)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x11F3344", Offset = "0x11F3344", VA = "0x11F3344")]
	public static void SetPositionY(this Transform t, float newY)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x11F33F0", Offset = "0x11F33F0", VA = "0x11F33F0")]
	public static void SetLocalPositionX(this Transform t, float newX)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x11F349C", Offset = "0x11F349C", VA = "0x11F349C")]
	public static void SetLocalPositionY(this Transform t, float newY)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x11F3548", Offset = "0x11F3548", VA = "0x11F3548")]
	public static void SetPositionZ(this Transform t, float newZ)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x11F35F4", Offset = "0x11F35F4", VA = "0x11F35F4")]
	public static void SetLocalPositionZ(this Transform t, float newZ)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x11F36A0", Offset = "0x11F36A0", VA = "0x11F36A0")]
	public static void SetLocalScale(this Transform t, Vector3 newScale)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x11F36F4", Offset = "0x11F36F4", VA = "0x11F36F4")]
	public static void SetLocalScaleZero(this Transform t)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x11F3798", Offset = "0x11F3798", VA = "0x11F3798")]
	public static float GetPositionX(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x11F37C4", Offset = "0x11F37C4", VA = "0x11F37C4")]
	public static float GetPositionY(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x11F37F8", Offset = "0x11F37F8", VA = "0x11F37F8")]
	public static float GetPositionZ(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x11F382C", Offset = "0x11F382C", VA = "0x11F382C")]
	public static float GetLocalPositionX(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x11F3858", Offset = "0x11F3858", VA = "0x11F3858")]
	public static float GetLocalPositionY(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x11F388C", Offset = "0x11F388C", VA = "0x11F388C")]
	public static float GetLocalPositionZ(this Transform t)
	{
		return default(float);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x11F38C0", Offset = "0x11F38C0", VA = "0x11F38C0")]
	public static bool HasRigidbody(this GameObject gobj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x11F3954", Offset = "0x11F3954", VA = "0x11F3954")]
	public static bool HasAnimation(this GameObject gobj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x11F39E8", Offset = "0x11F39E8", VA = "0x11F39E8")]
	public static void SetSpeed(this Animation anim, float newSpeed)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x11F3A74", Offset = "0x11F3A74", VA = "0x11F3A74")]
	public static Vector2 ToVector2(this Vector3 vec)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x11F3AA0", Offset = "0x11F3AA0", VA = "0x11F3AA0")]
	public static byte ToByte(this string val)
	{
		return default(byte);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x11F3B98", Offset = "0x11F3B98", VA = "0x11F3B98")]
	public static long ToInt64(this string val)
	{
		return default(long);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x11E6AF4", Offset = "0x11E6AF4", VA = "0x11E6AF4")]
	public static float ToFloat(this string val)
	{
		return default(float);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x11F3C90", Offset = "0x11F3C90", VA = "0x11F3C90")]
	public static int ToInt32(this string str)
	{
		return default(int);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x11F3D88", Offset = "0x11F3D88", VA = "0x11F3D88")]
	public static int ToInt32(this object obj)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	public static T GetArgForm<T>(object[] openArgs, int offset, bool isLog = true)
	{
		return (T)null;
	}

	[Token(Token = "0x6000069")]
	public static T GetArg<T>(this object[] openArgs, int offset, bool isLog = true)
	{
		return (T)null;
	}
}
[Token(Token = "0x2000019")]
public static class KEngineToolExtensions
{
	[Token(Token = "0x20000BD")]
	public delegate bool KFilterAction<T>(T t);

	[Token(Token = "0x20000BE")]
	public delegate bool KFilterAction<T, K>(T t, K k);

	[Token(Token = "0x600006A")]
	public static void Shuffle<T>(this IList<T> list)
	{
	}

	[Token(Token = "0x600006B")]
	public static T KFirstOrDefault<T>(this IEnumerable<T> source)
	{
		return (T)null;
	}

	[Token(Token = "0x600006C")]
	public static List<T> KFirst<T>(this IEnumerable<T> source, int num)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	public static List<T> KFilter<T>(this IEnumerable<T> source, KFilterAction<T> testAction)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	public static Dictionary<T, K> KFilter<T, K>(this IEnumerable<KeyValuePair<T, K>> source, KFilterAction<T, K> testAction)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	public static T KLastOrDefault<T>(this IEnumerable<T> source)
	{
		return (T)null;
	}

	[Token(Token = "0x6000070")]
	public static List<T> KLast<T>(this IEnumerable<T> source, int num)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	public static bool AddRange<T>(this HashSet<T> @this, IEnumerable<T> items)
	{
		return default(bool);
	}

	[Token(Token = "0x6000072")]
	public static T[] KToArray<T>(this IEnumerable<T> source)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	public static List<T> KToList<T>(this IEnumerable<T> source)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	public static List<T> KUnion<T>(this List<T> first, List<T> second, IEqualityComparer<T> comparer)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	public static string KJoin<T>(this IEnumerable<T> source, string sp)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	public static bool KContains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001A")]
public class KTabFileDef
{
	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static char[] Separators;

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x11F62A4", Offset = "0x11F62A4", VA = "0x11F62A4")]
	public KTabFileDef()
	{
	}
}
[Token(Token = "0x200001B")]
public class KTabFile : IDisposable, IKTabReadble, IEnumerable<KTabFile.RowInterator>, IEnumerable
{
	[Token(Token = "0x20000BF")]
	public class HeaderInfo
	{
		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ColumnIndex;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string HeaderName;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string HeaderDef;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x11F4790", Offset = "0x11F4790", VA = "0x11F4790")]
		public HeaderInfo()
		{
		}
	}

	[Token(Token = "0x20000C0")]
	public class RowInterator
	{
		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal KTabFile TabFile;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B64", Offset = "0xB12B64")]
		private int <Row>k__BackingField;

		[Token(Token = "0x17000117")]
		public int Row
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0x11F6214", Offset = "0x11F6214", VA = "0x11F6214")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB148AC", Offset = "0xB148AC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x11F6054", Offset = "0x11F6054", VA = "0x11F6054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB148BC", Offset = "0xB148BC")]
			internal set
			{
			}
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x11F3FA4", Offset = "0x11F3FA4", VA = "0x11F3FA4")]
		internal RowInterator(KTabFile tabFile)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x11F621C", Offset = "0x11F621C", VA = "0x11F621C")]
		public string GetString(string colName)
		{
			return null;
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x11F6260", Offset = "0x11F6260", VA = "0x11F6260")]
		public int GetInteger(string colName)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116A8", Offset = "0xB116A8")]
	private sealed class <System-Collections-Generic-IEnumerable<KTabFile-RowInterator>-GetEnumerator>d__33 : IEnumerator<RowInterator>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RowInterator <>2__current;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KTabFile <>4__this;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000118")]
		private RowInterator System.Collections.Generic.IEnumerator<KTabFile.RowInterator>.Current
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x11F619C", Offset = "0x11F619C", VA = "0x11F619C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000119")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x11F620C", Offset = "0x11F620C", VA = "0x11F620C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x11F5E38", Offset = "0x11F5E38", VA = "0x11F5E38")]
		[DebuggerHidden]
		public <System-Collections-Generic-IEnumerable<KTabFile-RowInterator>-GetEnumerator>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x11F60D4", Offset = "0x11F60D4", VA = "0x11F60D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x11F60D8", Offset = "0x11F60D8", VA = "0x11F60D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x11F61A4", Offset = "0x11F61A4", VA = "0x11F61A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116B8", Offset = "0xB116B8")]
	private sealed class <GetEnumerator>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public KTabFile <>4__this;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700011A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x11F605C", Offset = "0x11F605C", VA = "0x11F605C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070A")]
			[Address(RVA = "0x11F60CC", Offset = "0x11F60CC", VA = "0x11F60CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x11F5ED8", Offset = "0x11F5ED8", VA = "0x11F5ED8")]
		[DebuggerHidden]
		public <GetEnumerator>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x11F5F8C", Offset = "0x11F5F8C", VA = "0x11F5F8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x11F5F90", Offset = "0x11F5F90", VA = "0x11F5F90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x11F6064", Offset = "0x11F6064", VA = "0x11F6064", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly RowInterator _rowInteratorCache;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int ColCount;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Dictionary<string, HeaderInfo> ColIndex;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Dictionary<int, string[]> TabInfo;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x11F3EE4", Offset = "0x11F3EE4", VA = "0x11F3EE4")]
	public KTabFile()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x11F3FD0", Offset = "0x11F3FD0", VA = "0x11F3FD0")]
	public static KTabFile LoadFromString(string content)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x11F4174", Offset = "0x11F4174", VA = "0x11F4174")]
	public static KTabFile LoadFromFile(string fileFullPath)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x11F41EC", Offset = "0x11F41EC", VA = "0x11F41EC")]
	public bool LoadByIO(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x11F4440", Offset = "0x11F4440", VA = "0x11F4440")]
	protected bool ParseReader(TextReader oReader)
	{
		return default(bool);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x11F4044", Offset = "0x11F4044", VA = "0x11F4044")]
	protected bool ParseString(string content)
	{
		return default(bool);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x11F4798", Offset = "0x11F4798", VA = "0x11F4798")]
	public bool Save(string fileName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x11F516C", Offset = "0x11F516C", VA = "0x11F516C")]
	private string _GetString(int row, int column)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x11F5270", Offset = "0x11F5270", VA = "0x11F5270", Slot = "8")]
	public string GetString(int row, int column)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x11F5274", Offset = "0x11F5274", VA = "0x11F5274", Slot = "7")]
	public string GetString(int row, string columnName)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x11F5338", Offset = "0x11F5338", VA = "0x11F5338")]
	public int GetInteger(int row, int column)
	{
		return default(int);
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x11F541C", Offset = "0x11F541C", VA = "0x11F541C", Slot = "6")]
	public int GetInteger(int row, string columnName)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x11F5500", Offset = "0x11F5500", VA = "0x11F5500")]
	public uint GetUInteger(int row, int column)
	{
		return default(uint);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x11F55E4", Offset = "0x11F55E4", VA = "0x11F55E4", Slot = "12")]
	public uint GetUInteger(int row, string columnName)
	{
		return default(uint);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x11F56C8", Offset = "0x11F56C8", VA = "0x11F56C8")]
	public double GetDouble(int row, int column)
	{
		return default(double);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x11F57D0", Offset = "0x11F57D0", VA = "0x11F57D0", Slot = "11")]
	public double GetDouble(int row, string columnName)
	{
		return default(double);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x11F58D8", Offset = "0x11F58D8", VA = "0x11F58D8")]
	public float GetFloat(int row, int column)
	{
		return default(float);
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x11F59B8", Offset = "0x11F59B8", VA = "0x11F59B8", Slot = "9")]
	public float GetFloat(int row, string columnName)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x11F5A98", Offset = "0x11F5A98", VA = "0x11F5A98")]
	public bool GetBool(int row, int column)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x11F5AB4", Offset = "0x11F5AB4", VA = "0x11F5AB4", Slot = "10")]
	public bool GetBool(int row, string columnName)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x11F5AD0", Offset = "0x11F5AD0", VA = "0x11F5AD0", Slot = "5")]
	public bool HasColumn(string colName)
	{
		return default(bool);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x11F5B40", Offset = "0x11F5B40", VA = "0x11F5B40")]
	public int NewColumn(string colName, string defineStr = "")
	{
		return default(int);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x11F5C9C", Offset = "0x11F5C9C", VA = "0x11F5C9C")]
	public int NewRow()
	{
		return default(int);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x11F5D54", Offset = "0x11F5D54", VA = "0x11F5D54", Slot = "13")]
	public int GetHeight()
	{
		return default(int);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x11F5DB4", Offset = "0x11F5DB4", VA = "0x11F5DB4", Slot = "14")]
	public int GetColumnCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x11F5DBC", Offset = "0x11F5DBC", VA = "0x11F5DBC")]
	public int GetWidth()
	{
		return default(int);
	}

	[Token(Token = "0x6000093")]
	public bool SetValue<T>(int row, int column, T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000094")]
	public bool SetValue<T>(int row, string columnName, T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x11F5DC4", Offset = "0x11F5DC4", VA = "0x11F5DC4", Slot = "16")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB12E24", Offset = "0xB12E24")]
	private IEnumerator<RowInterator> System.Collections.Generic.IEnumerable<KTabFile.RowInterator>.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x11F5E64", Offset = "0x11F5E64", VA = "0x11F5E64", Slot = "17")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB12E88", Offset = "0xB12E88")]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x11F5F04", Offset = "0x11F5F04", VA = "0x11F5F04", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x11F5F88", Offset = "0x11F5F88", VA = "0x11F5F88", Slot = "15")]
	public void Close()
	{
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB112B8", Offset = "0xB112B8")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x11F8524", Offset = "0x11F8524", VA = "0x11F8524")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB112CC", Offset = "0xB112CC")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x11F852C", Offset = "0x11F852C", VA = "0x11F852C")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0xB112E0", Offset = "0xB112E0")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x11F8534", Offset = "0x11F8534", VA = "0x11F8534")]
		public RelatingAttribute()
		{
		}
	}
}
namespace MiniJSON
{
	[Token(Token = "0x200001F")]
	public static class Json
	{
		[Token(Token = "0x20000C3")]
		private sealed class Parser : IDisposable
		{
			[Token(Token = "0x200018C")]
			private enum TOKEN
			{
				[Token(Token = "0x4000866")]
				NONE,
				[Token(Token = "0x4000867")]
				CURLY_OPEN,
				[Token(Token = "0x4000868")]
				CURLY_CLOSE,
				[Token(Token = "0x4000869")]
				SQUARED_OPEN,
				[Token(Token = "0x400086A")]
				SQUARED_CLOSE,
				[Token(Token = "0x400086B")]
				COLON,
				[Token(Token = "0x400086C")]
				COMMA,
				[Token(Token = "0x400086D")]
				STRING,
				[Token(Token = "0x400086E")]
				NUMBER,
				[Token(Token = "0x400086F")]
				TRUE,
				[Token(Token = "0x4000870")]
				FALSE,
				[Token(Token = "0x4000871")]
				NULL
			}

			[Token(Token = "0x400059E")]
			private const string WORD_BREAK = "{}[],:\"";

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringReader json;

			[Token(Token = "0x1700011C")]
			private char PeekChar
			{
				[Token(Token = "0x6000716")]
				[Address(RVA = "0x11F7614", Offset = "0x11F7614", VA = "0x11F7614")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700011D")]
			private char NextChar
			{
				[Token(Token = "0x6000717")]
				[Address(RVA = "0x11F73E0", Offset = "0x11F73E0", VA = "0x11F73E0")]
				get
				{
					return default(char);
				}
			}

			[Token(Token = "0x1700011E")]
			private string NextWord
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x11F7470", Offset = "0x11F7470", VA = "0x11F7470")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011F")]
			private TOKEN NextToken
			{
				[Token(Token = "0x6000719")]
				[Address(RVA = "0x11F6BE0", Offset = "0x11F6BE0", VA = "0x11F6BE0")]
				get
				{
					return default(TOKEN);
				}
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x11F6920", Offset = "0x11F6920", VA = "0x11F6920")]
			public static bool IsWordBreak(char c)
			{
				return default(bool);
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x11F69C4", Offset = "0x11F69C4", VA = "0x11F69C4")]
			private Parser(string jsonString)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x11F6734", Offset = "0x11F6734", VA = "0x11F6734")]
			public static object Parse(string jsonString)
			{
				return null;
			}

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x11F6A68", Offset = "0x11F6A68", VA = "0x11F6A68", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x11F6AA4", Offset = "0x11F6AA4", VA = "0x11F6AA4")]
			private Dictionary<string, object> ParseObject()
			{
				return null;
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x11F7138", Offset = "0x11F7138", VA = "0x11F7138")]
			private List<object> ParseArray()
			{
				return null;
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x11F6A40", Offset = "0x11F6A40", VA = "0x11F6A40")]
			private object ParseValue()
			{
				return null;
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x11F7224", Offset = "0x11F7224", VA = "0x11F7224")]
			private object ParseByToken(TOKEN token)
			{
				return null;
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x11F6E34", Offset = "0x11F6E34", VA = "0x11F6E34")]
			private string ParseString()
			{
				return null;
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x11F7300", Offset = "0x11F7300", VA = "0x11F7300")]
			private object ParseNumber()
			{
				return null;
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x11F754C", Offset = "0x11F754C", VA = "0x11F754C")]
			private void EatWhitespace()
			{
			}
		}

		[Token(Token = "0x20000C4")]
		private sealed class Serializer
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private StringBuilder builder;

			[Token(Token = "0x600071A")]
			[Address(RVA = "0x11F76A4", Offset = "0x11F76A4", VA = "0x11F76A4")]
			private Serializer()
			{
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x11F687C", Offset = "0x11F687C", VA = "0x11F687C")]
			public static string Serialize(object obj)
			{
				return null;
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x11F7710", Offset = "0x11F7710", VA = "0x11F7710")]
			private void SerializeValue(object value)
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x11F7E98", Offset = "0x11F7E98", VA = "0x11F7E98")]
			private void SerializeObject(IDictionary obj)
			{
			}

			[Token(Token = "0x600071E")]
			[Address(RVA = "0x11F7B9C", Offset = "0x11F7B9C", VA = "0x11F7B9C")]
			private void SerializeArray(IList anArray)
			{
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x11F78CC", Offset = "0x11F78CC", VA = "0x11F78CC")]
			private void SerializeString(string str)
			{
			}

			[Token(Token = "0x6000720")]
			[Address(RVA = "0x11F82DC", Offset = "0x11F82DC", VA = "0x11F82DC")]
			private void SerializeOther(object value)
			{
			}
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x11F6728", Offset = "0x11F6728", VA = "0x11F6728")]
		public static object Deserialize(string json)
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x11F6878", Offset = "0x11F6878", VA = "0x11F6878")]
		public static string Serialize(object obj)
		{
			return null;
		}
	}
}
namespace KEngine
{
	[Token(Token = "0x2000020")]
	public class AppVersion : IComparable, ICloneable
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint Major;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public uint Minor;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint Patch;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint Build;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11DC0", Offset = "0xB11DC0")]
		private string <VersionType>k__BackingField;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11DD0", Offset = "0xB11DD0")]
		private string <VersionDesc>k__BackingField;

		[Token(Token = "0x1700000A")]
		public string VersionType
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xE00458", Offset = "0xE00458", VA = "0xE00458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12EEC", Offset = "0xB12EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xE00460", Offset = "0xE00460", VA = "0xE00460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12EFC", Offset = "0xB12EFC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public string VersionDesc
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xE00468", Offset = "0xE00468", VA = "0xE00468")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F0C", Offset = "0xB12F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xE00470", Offset = "0xE00470", VA = "0xE00470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F1C", Offset = "0xB12F1C")]
			set
			{
			}
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xE00478", Offset = "0xE00478", VA = "0xE00478")]
		public AppVersion(string versionStr)
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xE005E8", Offset = "0xE005E8", VA = "0xE005E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xE00910", Offset = "0xE00910", VA = "0xE00910", Slot = "5")]
		public object Clone()
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xE00918", Offset = "0xE00918", VA = "0xE00918")]
		public string ToVersion2()
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xE009B4", Offset = "0xE009B4", VA = "0xE009B4")]
		public string ToVersion3()
		{
			return null;
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xE00A74", Offset = "0xE00A74", VA = "0xE00A74")]
		public string ToVersion4()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xE00C8C", Offset = "0xE00C8C", VA = "0xE00C8C")]
		private uint[] GetVersionNumbers(int limit = 4)
		{
			return null;
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xE00ED0", Offset = "0xE00ED0", VA = "0xE00ED0", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xE00ED8", Offset = "0xE00ED8", VA = "0xE00ED8")]
		public int CompareTo(object v2o, int limitNumber)
		{
			return default(int);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xE010A4", Offset = "0xE010A4", VA = "0xE010A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xE01134", Offset = "0xE01134", VA = "0xE01134")]
		protected bool Equals(AppVersion other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xE0120C", Offset = "0xE0120C", VA = "0xE0120C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xE01090", Offset = "0xE01090", VA = "0xE01090")]
		public static bool operator ==(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xE01298", Offset = "0xE01298", VA = "0xE01298")]
		public static bool operator !=(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xE012C4", Offset = "0xE012C4", VA = "0xE012C4")]
		public static bool operator <(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xE0136C", Offset = "0xE0136C", VA = "0xE0136C")]
		public static bool operator <=(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xE01418", Offset = "0xE01418", VA = "0xE01418")]
		public static bool operator >(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xE01428", Offset = "0xE01428", VA = "0xE01428")]
		public static bool operator >=(AppVersion v1, AppVersion v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000021")]
	public class Debuger
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float[] RecordTime;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string[] RecordKey;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int RecordPos;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xE05694", Offset = "0xE05694", VA = "0xE05694")]
		public static bool Check(object obj, [Optional] string formatStr, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xDFE2B0", Offset = "0xDFE2B0", VA = "0xDFE2B0")]
		public static void Assert(bool result)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xE05764", Offset = "0xE05764", VA = "0xE05764")]
		public static void Assert(bool result, string msg, params object[] args)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xE05870", Offset = "0xE05870", VA = "0xE05870")]
		public static void Assert(int result)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xE058D8", Offset = "0xE058D8", VA = "0xE058D8")]
		public static void Assert(long result)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xE05940", Offset = "0xE05940", VA = "0xE05940")]
		public static void Assert(object obj)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xE059A8", Offset = "0xE059A8", VA = "0xE059A8")]
		public static void BeginRecordTime(string key)
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xE05AE8", Offset = "0xE05AE8", VA = "0xE05AE8")]
		public static string EndRecordTime(bool printLog = true)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xE05DB4", Offset = "0xE05DB4", VA = "0xE05DB4")]
		public static void WatchPerformance(Action del)
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xE05E24", Offset = "0xE05E24", VA = "0xE05E24")]
		public static void WatchPerformance(string outputStr, Action del)
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xE0603C", Offset = "0xE0603C", VA = "0xE0603C")]
		public Debuger()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class EngineConfigs
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string DefaultEngineConfigs;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly IniData _iniData;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xDFF4B8", Offset = "0xDFF4B8", VA = "0xDFF4B8")]
		public EngineConfigs(string customConfigs)
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xDFF784", Offset = "0xDFF784", VA = "0xDFF784")]
		public string GetConfig(string section, string key, bool throwError = true)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xE060D0", Offset = "0xE060D0", VA = "0xE060D0")]
		public SectionDataCollection GetSections()
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xE06100", Offset = "0xE06100", VA = "0xE06100")]
		public string ToIniString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000023")]
	public interface IModuleInitable
	{
		[Token(Token = "0x1700000C")]
		double InitProgress
		{
			[Token(Token = "0x60000C6")]
			get;
		}

		[Token(Token = "0x60000C5")]
		IEnumerator Init();
	}
	[Token(Token = "0x2000024")]
	public enum LogLevel
	{
		[Token(Token = "0x4000079")]
		All,
		[Token(Token = "0x400007A")]
		Trace,
		[Token(Token = "0x400007B")]
		Debug,
		[Token(Token = "0x400007C")]
		Info,
		[Token(Token = "0x400007D")]
		Warning,
		[Token(Token = "0x400007E")]
		Error
	}
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB112F4", Offset = "0xB112F4")]
	public class Logger : Log
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x11E6354", Offset = "0x11E6354", VA = "0x11E6354")]
		public Logger()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class Log
	{
		[Token(Token = "0x20000C5")]
		public delegate void LogCallback(string condition, string stackTrace, LogLevel type);

		[Serializable]
		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116C8", Offset = "0xB116C8")]
		private sealed class <>c
		{
			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Application.LogCallback <>9__7_0;

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x11E620C", Offset = "0x11E620C", VA = "0x11E620C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x11E6214", Offset = "0x11E6214", VA = "0x11E6214")]
			internal void <GetUnityLogCallback>b__7_0(string c, string s, LogType type)
			{
			}
		}

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static LogLevel LogLevel;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _hasRegisterLogCallback;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public static readonly bool IsUnityEditor;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _isLogFile;

		[Token(Token = "0x1700000D")]
		public static bool IsLogFile
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x11E4184", Offset = "0x11E4184", VA = "0x11E4184")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x11E41EC", Offset = "0x11E41EC", VA = "0x11E41EC")]
			set
			{
			}
		}

		[Token(Token = "0x14000003")]
		private static event LogCallback LogCallbackEvent
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x11E37CC", Offset = "0x11E37CC", VA = "0x11E37CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F2C", Offset = "0xB12F2C")]
			add
			{
			}
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x11E38FC", Offset = "0x11E38FC", VA = "0x11E38FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F3C", Offset = "0xB12F3C")]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event Action<string> LogErrorEvent
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x11E3CA8", Offset = "0x11E3CA8", VA = "0x11E3CA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F4C", Offset = "0xB12F4C")]
			add
			{
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x11E3DD8", Offset = "0x11E3DD8", VA = "0x11E3DD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12F5C", Offset = "0xB12F5C")]
			remove
			{
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x11E3A2C", Offset = "0x11E3A2C", VA = "0x11E3A2C")]
		public static void AddLogCallback(LogCallback callback)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x11E3B20", Offset = "0x11E3B20", VA = "0x11E3B20")]
		private static Application.LogCallback GetUnityLogCallback(LogCallback callback)
		{
			return null;
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x11E3BF0", Offset = "0x11E3BF0", VA = "0x11E3BF0")]
		public static void RemoveLogCallback(LogCallback callback)
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x11E3F08", Offset = "0x11E3F08", VA = "0x11E3F08")]
		static Log()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x11E42DC", Offset = "0x11E42DC", VA = "0x11E42DC")]
		public static void LogFileCallbackHandler(string condition, string stacktrace, LogLevel type)
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x11E4518", Offset = "0x11E4518", VA = "0x11E4518")]
		private static void OnLogCallback(string condition, string stacktrace, LogLevel type)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x11E4E38", Offset = "0x11E4E38", VA = "0x11E4E38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB12F6C", Offset = "0xB12F6C")]
		public static bool Check(object obj, [Optional] string formatStr, params object[] args)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x11E4F90", Offset = "0x11E4F90", VA = "0x11E4F90")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB12FA4", Offset = "0xB12FA4")]
		public static void Assert(bool result)
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x11E5320", Offset = "0x11E5320", VA = "0x11E5320")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB12FDC", Offset = "0xB12FDC")]
		public static void Assert(int result)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x11E5388", Offset = "0x11E5388", VA = "0x11E5388")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB13014", Offset = "0xB13014")]
		public static void Assert(long result)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x11E53F0", Offset = "0x11E53F0", VA = "0x11E53F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB1304C", Offset = "0xB1304C")]
		public static void Assert(object obj)
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x11E40AC", Offset = "0x11E40AC", VA = "0x11E40AC")]
		public static void LogConsole_MultiThread(string log, params object[] args)
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x11E560C", Offset = "0x11E560C", VA = "0x11E560C")]
		public static void Trace(string log, params object[] args)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x11E5684", Offset = "0x11E5684", VA = "0x11E5684")]
		public static void Debug(string log, params object[] args)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x11E56FC", Offset = "0x11E56FC", VA = "0x11E56FC")]
		public static void Info(string log, params object[] args)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x11E5774", Offset = "0x11E5774", VA = "0x11E5774")]
		public static void Logs(params object[] logs)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x11E58E8", Offset = "0x11E58E8", VA = "0x11E58E8")]
		public static void LogException(Exception e)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x11E504C", Offset = "0x11E504C", VA = "0x11E504C")]
		public static void LogErrorWithStack(string err = "", int stack = 2)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x11E5A74", Offset = "0x11E5A74", VA = "0x11E5A74")]
		public static StackFrame GetTopStack(int stack = 2)
		{
			return null;
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x11E5B68", Offset = "0x11E5B68", VA = "0x11E5B68")]
		public static void Error(string err, params object[] args)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x11E4F04", Offset = "0x11E4F04", VA = "0x11E4F04")]
		public static void LogError(string err, params object[] args)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x11E5BF4", Offset = "0x11E5BF4", VA = "0x11E5BF4")]
		public static void Warning(string err, params object[] args)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x11E5C6C", Offset = "0x11E5C6C", VA = "0x11E5C6C")]
		public static void LogWarning(string err, params object[] args)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x11E5458", Offset = "0x11E5458", VA = "0x11E5458")]
		private static void DoLog(string szMsg, object[] args, LogLevel emLevel)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x11E44B0", Offset = "0x11E44B0", VA = "0x11E44B0")]
		public static void LogToFile(string szMsg)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x11E5F90", Offset = "0x11E5F90", VA = "0x11E5F90")]
		public static bool HasLogFile()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x11E5CE4", Offset = "0x11E5CE4", VA = "0x11E5CE4")]
		public static void LogToFile(string szMsg, bool append)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x11E5FF4", Offset = "0x11E5FF4", VA = "0x11E5FF4")]
		public static string GetLogPath()
		{
			return null;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x11E61A0", Offset = "0x11E61A0", VA = "0x11E61A0")]
		public Log()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public interface IAppEntry
	{
		[Token(Token = "0x60000EB")]
		IEnumerator OnBeforeInit();

		[Token(Token = "0x60000EC")]
		IEnumerator OnGameStart();
	}
	[Token(Token = "0x2000028")]
	public class AppEngine : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116D8", Offset = "0xB116D8")]
		private sealed class <DoInit>d__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AppEngine <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072B")]
				[Address(RVA = "0xDFFC34", Offset = "0xDFFC34", VA = "0xDFFC34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072D")]
				[Address(RVA = "0xDFFCA4", Offset = "0xDFFCA4", VA = "0xDFFCA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0xDFF084", Offset = "0xDFF084", VA = "0xDFF084")]
			[DebuggerHidden]
			public <DoInit>d__44(int <>1__state)
			{
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0xDFF954", Offset = "0xDFF954", VA = "0xDFF954", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0xDFF958", Offset = "0xDFF958", VA = "0xDFF958", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072C")]
			[Address(RVA = "0xDFFC3C", Offset = "0xDFFC3C", VA = "0xDFFC3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116E8", Offset = "0xB116E8")]
		private sealed class <DoInitModules>d__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IList<IModuleInitable> modules;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AppEngine <>4__this;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startInitTime>5__2;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startMem>5__3;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<IModuleInitable> <>7__wrap3;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private IModuleInitable <initModule>5__5;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000732")]
				[Address(RVA = "0xE003E0", Offset = "0xE003E0", VA = "0xE003E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000734")]
				[Address(RVA = "0xE00450", Offset = "0xE00450", VA = "0xE00450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072E")]
			[Address(RVA = "0xDFF148", Offset = "0xDFF148", VA = "0xDFF148")]
			[DebuggerHidden]
			public <DoInitModules>d__45(int <>1__state)
			{
			}

			[Token(Token = "0x600072F")]
			[Address(RVA = "0xDFFCAC", Offset = "0xDFFCAC", VA = "0xDFFCAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0xDFFD88", Offset = "0xDFFD88", VA = "0xDFFD88", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0xDFFCC8", Offset = "0xDFFCC8", VA = "0xDFFCC8")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000733")]
			[Address(RVA = "0xE003E8", Offset = "0xE003E8", VA = "0xE003E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E00", Offset = "0xB11E00")]
		private static bool <IsDebugBuild>k__BackingField;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowFps;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E10", Offset = "0xB11E10")]
		private static FpsWatcher <RenderWatcher>k__BackingField;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool IsRootUser;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E20", Offset = "0xB11E20")]
		private static AppEngine <EngineInstance>k__BackingField;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E30", Offset = "0xB11E30")]
		private IList<IModuleInitable> <GameModules>k__BackingField;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E40", Offset = "0xB11E40")]
		private bool <IsInited>k__BackingField;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E50", Offset = "0xB11E50")]
		private bool <IsBeforeInit>k__BackingField;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E60", Offset = "0xB11E60")]
		private bool <IsOnInit>k__BackingField;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E70", Offset = "0xB11E70")]
		private bool <IsStartGame>k__BackingField;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool _isNewByStatic;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E80", Offset = "0xB11E80")]
		private IAppEntry <AppEntry>k__BackingField;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static EngineConfigs _engineConfigs;

		[Token(Token = "0x1700000E")]
		public static bool IsDebugBuild
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xDFDF24", Offset = "0xDFDF24", VA = "0xDFDF24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13084", Offset = "0xB13084")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xDFDF74", Offset = "0xDFDF74", VA = "0xDFDF74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13094", Offset = "0xB13094")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public static FpsWatcher RenderWatcher
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0xDFDFCC", Offset = "0xDFDFCC", VA = "0xDFDFCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130A4", Offset = "0xB130A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0xDFE01C", Offset = "0xDFE01C", VA = "0xDFE01C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130B4", Offset = "0xB130B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public static AppEngine EngineInstance
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xDFE070", Offset = "0xDFE070", VA = "0xDFE070")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130C4", Offset = "0xB130C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xDFE0C0", Offset = "0xDFE0C0", VA = "0xDFE0C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130D4", Offset = "0xB130D4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public IList<IModuleInitable> GameModules
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xDFE114", Offset = "0xDFE114", VA = "0xDFE114")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130E4", Offset = "0xB130E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xDFE11C", Offset = "0xDFE11C", VA = "0xDFE11C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB130F4", Offset = "0xB130F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsInited
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0xDFE124", Offset = "0xDFE124", VA = "0xDFE124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13104", Offset = "0xB13104")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0xDFE12C", Offset = "0xDFE12C", VA = "0xDFE12C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13114", Offset = "0xB13114")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsBeforeInit
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0xDFE138", Offset = "0xDFE138", VA = "0xDFE138")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13124", Offset = "0xB13124")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0xDFE140", Offset = "0xDFE140", VA = "0xDFE140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13134", Offset = "0xB13134")]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public bool IsOnInit
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xDFE14C", Offset = "0xDFE14C", VA = "0xDFE14C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13144", Offset = "0xB13144")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0xDFE154", Offset = "0xDFE154", VA = "0xDFE154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13154", Offset = "0xB13154")]
			private set
			{
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsStartGame
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0xDFE160", Offset = "0xDFE160", VA = "0xDFE160")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13164", Offset = "0xB13164")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0xDFE168", Offset = "0xDFE168", VA = "0xDFE168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13174", Offset = "0xB13174")]
			private set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public IAppEntry AppEntry
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0xDFE174", Offset = "0xDFE174", VA = "0xDFE174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13184", Offset = "0xB13184")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0xDFE17C", Offset = "0xDFE17C", VA = "0xDFE17C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13194", Offset = "0xB13194")]
			private set
			{
			}
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xDFE184", Offset = "0xDFE184", VA = "0xDFE184")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB131A4", Offset = "0xB131A4")]
		public static AppEngine New(GameObject gameObjectToAttach, IModuleInitable[] modules)
		{
			return null;
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xDFE194", Offset = "0xDFE194", VA = "0xDFE194")]
		public static AppEngine New(GameObject gameObjectToAttach, IAppEntry entry, IList<IModuleInitable> modules)
		{
			return null;
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xDFE334", Offset = "0xDFE334", VA = "0xDFE334")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xDFED0C", Offset = "0xDFED0C", VA = "0xDFED0C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xDFE500", Offset = "0xDFE500", VA = "0xDFE500")]
		private void Init()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xDFF010", Offset = "0xDFF010", VA = "0xDFF010")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB131DC", Offset = "0xB131DC")]
		private IEnumerator DoInit()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xDFF0B0", Offset = "0xDFF0B0", VA = "0xDFF0B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13240", Offset = "0xB13240")]
		private IEnumerator DoInitModules(IList<IModuleInitable> modules)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xDFF174", Offset = "0xDFF174", VA = "0xDFF174", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xDFF364", Offset = "0xDFF364", VA = "0xDFF364")]
		public static EngineConfigs PreloadConfigs(bool forceReload = false)
		{
			return null;
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xDFF604", Offset = "0xDFF604", VA = "0xDFF604")]
		public static string GetConfig(string section, string key, bool showLog = true)
		{
			return null;
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xDFF89C", Offset = "0xDFF89C", VA = "0xDFF89C")]
		public static string GetConfig(KEngineDefaultConfigs cfg)
		{
			return null;
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xDFF94C", Offset = "0xDFF94C", VA = "0xDFF94C")]
		public AppEngine()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public enum KEngineDefaultConfigs
	{
		[Token(Token = "0x4000093")]
		AssetBundleExt,
		[Token(Token = "0x4000094")]
		ProductRelPath,
		[Token(Token = "0x4000095")]
		AssetBundleBuildRelPath,
		[Token(Token = "0x4000096")]
		StreamingBundlesFolderName
	}
	[Token(Token = "0x200002A")]
	public class FpsWatcher
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private float _value;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float _sensitivity;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _cacheMemoryStr;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string _cacheFPSStr;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text CacheText;

		[Token(Token = "0x17000017")]
		public float Value
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0xE06544", Offset = "0xE06544", VA = "0xE06544")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xE0654C", Offset = "0xE0654C", VA = "0xE0654C")]
		public FpsWatcher(float sensitivity)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xDFF1DC", Offset = "0xDFF1DC", VA = "0xDFF1DC")]
		public void OnUIUpdate(bool bShowFps)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xE068BC", Offset = "0xE068BC", VA = "0xE068BC")]
		public string Watch(string format, float value)
		{
			return null;
		}
	}
	[Token(Token = "0x200002B")]
	public class KEngineInfo
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KEngineInfo _instance;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TableFileRow _row;

		[Token(Token = "0x17000018")]
		public string Key
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE0EC48", Offset = "0xE0EC48", VA = "0xE0EC48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public string Value
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xE0ECAC", Offset = "0xE0ECAC", VA = "0xE0ECAC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000113")]
			[Address(RVA = "0xE0ED10", Offset = "0xE0ED10", VA = "0xE0ED10")]
			set
			{
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xE0EBA0", Offset = "0xE0EBA0", VA = "0xE0EBA0")]
		public static KEngineInfo Wrap(TableFileRow row)
		{
			return null;
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xE0EC40", Offset = "0xE0EC40", VA = "0xE0EC40")]
		private KEngineInfo()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal class AssetBundleInfo
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string bundleName;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string assetName;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> dependencies;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xE01438", Offset = "0xE01438", VA = "0xE01438")]
		public void AddDependence(string dep)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xE014D4", Offset = "0xE014D4", VA = "0xE014D4")]
		public AssetBundleInfo()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class ABLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000C9")]
		public delegate void ABLoaderDelegate(bool isOk, object result);

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB116F8", Offset = "0xB116F8")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ABLoaderDelegate callback;

			[Token(Token = "0x6000739")]
			[Address(RVA = "0xE552EC", Offset = "0xE552EC", VA = "0xE552EC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0xE55AB4", Offset = "0xE55AB4", VA = "0xE55AB4")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11708", Offset = "0xB11708")]
		private sealed class <CoLoadAB>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ABLoader <>4__this;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <rootPath>5__2;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AssetBundleInfo <info>5__3;

			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string <bundlePath>5__4;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AssetBundleCreateRequest <req>5__5;

			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<string>.Enumerator <>7__wrap5;

			[Token(Token = "0x17000124")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073F")]
				[Address(RVA = "0xE565D4", Offset = "0xE565D4", VA = "0xE565D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000741")]
				[Address(RVA = "0xE56644", Offset = "0xE56644", VA = "0xE56644", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0xE55480", Offset = "0xE55480", VA = "0xE55480")]
			[DebuggerHidden]
			public <CoLoadAB>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600073C")]
			[Address(RVA = "0xE55F60", Offset = "0xE55F60", VA = "0xE55F60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073D")]
			[Address(RVA = "0xE55FD4", Offset = "0xE55FD4", VA = "0xE55FD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073E")]
			[Address(RVA = "0xE55F7C", Offset = "0xE55F7C", VA = "0xE55F7C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000740")]
			[Address(RVA = "0xE565DC", Offset = "0xE565DC", VA = "0xE565DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetBundle _assetBundle;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<string, AssetBundleInfo> bundleMap;

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xE551D4", Offset = "0xE551D4", VA = "0xE551D4")]
		public static ABLoader Load(string path, [Optional] ABLoaderDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xE552F4", Offset = "0xE552F4", VA = "0xE552F4", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE5540C", Offset = "0xE5540C", VA = "0xE5540C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB132A4", Offset = "0xB132A4")]
		private IEnumerator CoLoadAB()
		{
			return null;
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xE554AC", Offset = "0xE554AC", VA = "0xE554AC")]
		public void LoadResDesc(string descName)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xE55910", Offset = "0xE55910", VA = "0xE55910")]
		public string ReadFileText(string path)
		{
			return null;
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xE55954", Offset = "0xE55954", VA = "0xE55954", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xE55994", Offset = "0xE55994", VA = "0xE55994")]
		public ABLoader()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public abstract class AbstractResourceLoader : IAsyncObject
	{
		[Token(Token = "0x20000CC")]
		public delegate void LoaderDelgate(bool isOk, object resultObject);

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11718", Offset = "0xB11718")]
		private sealed class <>c__DisplayClass68_0
		{
			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AbstractResourceLoader <>4__this;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object resultObj;

			[Token(Token = "0x6000746")]
			[Address(RVA = "0xDFD5F4", Offset = "0xDFD5F4", VA = "0xDFD5F4")]
			public <>c__DisplayClass68_0()
			{
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0xDFD5FC", Offset = "0xDFD5FC", VA = "0xDFD5FC")]
			internal void <OnFinish>b__0()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11728", Offset = "0xB11728")]
		private sealed class <>c__DisplayClass70_0
		{
			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AbstractResourceLoader <>4__this;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool isOk;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object resultObj;

			[Token(Token = "0x6000748")]
			[Address(RVA = "0xDFD878", Offset = "0xDFD878", VA = "0xDFD878")]
			public <>c__DisplayClass70_0()
			{
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0xDFD880", Offset = "0xDFD880", VA = "0xDFD880")]
			internal void <DoCallback>b__0()
			{
			}
		}

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, Dictionary<string, AbstractResourceLoader>> _loadersPool;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly List<LoaderDelgate> _afterFinishedCallbacks;

		[Token(Token = "0x40000A5")]
		private const float LoaderDisposeTime = 0f;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float _lastGcTime;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly List<AbstractResourceLoader> CacheLoaderToRemoveFromUnUsed;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly Dictionary<AbstractResourceLoader, float> UnUsesLoaders;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11E90", Offset = "0xB11E90")]
		private object <ResultObject>k__BackingField;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11EA0", Offset = "0xB11EA0")]
		private bool <IsCompleted>k__BackingField;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11EB0", Offset = "0xB11EB0")]
		private bool <IsError>k__BackingField;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		private bool _isQuitApplication;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		protected bool IsForceNew;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11EC0", Offset = "0xB11EC0")]
		private bool <IsReadyDisposed>k__BackingField;

		[NonSerialized]
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float InitTiming;

		[NonSerialized]
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float FinishTiming;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11EE0", Offset = "0xB11EE0")]
		private int <RefCount>k__BackingField;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11EF0", Offset = "0xB11EF0")]
		private string <Url>k__BackingField;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F00", Offset = "0xB11F00")]
		private float <Progress>k__BackingField;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string _desc;

		[Token(Token = "0x1700001A")]
		public static float GcIntervalTime
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0xE56704", Offset = "0xE56704", VA = "0xE56704")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001B")]
		public object ResultObject
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xE5679C", Offset = "0xE5679C", VA = "0xE5679C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13308", Offset = "0xB13308")]
			get
			{
				return null;
			}
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xE567A4", Offset = "0xE567A4", VA = "0xE567A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13318", Offset = "0xB13318")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0xE567AC", Offset = "0xE567AC", VA = "0xE567AC", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13328", Offset = "0xB13328")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000121")]
			[Address(RVA = "0xE567B4", Offset = "0xE567B4", VA = "0xE567B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13338", Offset = "0xB13338")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public bool IsError
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xE567C0", Offset = "0xE567C0", VA = "0xE567C0", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13348", Offset = "0xB13348")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000123")]
			[Address(RVA = "0xE567C8", Offset = "0xE567C8", VA = "0xE567C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13358", Offset = "0xB13358")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual string AsyncMessage
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xE567D4", Offset = "0xE567D4", VA = "0xE567D4", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public object AsyncResult
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xE567DC", Offset = "0xE567DC", VA = "0xE567DC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public bool IsSuccess
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xE567E4", Offset = "0xE567E4", VA = "0xE567E4", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		protected bool IsReadyDisposed
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0xE5680C", Offset = "0xE5680C", VA = "0xE5680C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13368", Offset = "0xB13368")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xE56814", Offset = "0xE56814", VA = "0xE56814")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13378", Offset = "0xB13378")]
			private set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public float FinishUsedTime
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0xE569F8", Offset = "0xE569F8", VA = "0xE569F8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000023")]
		public int RefCount
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0xE56A14", Offset = "0xE56A14", VA = "0xE56A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133A8", Offset = "0xB133A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600012D")]
			[Address(RVA = "0xE56A1C", Offset = "0xE56A1C", VA = "0xE56A1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133B8", Offset = "0xB133B8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public string Url
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xE565CC", Offset = "0xE565CC", VA = "0xE565CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133C8", Offset = "0xB133C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xE56A24", Offset = "0xE56A24", VA = "0xE56A24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133D8", Offset = "0xB133D8")]
			private set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public virtual float Progress
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xE56A2C", Offset = "0xE56A2C", VA = "0xE56A2C", Slot = "10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133E8", Offset = "0xB133E8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000131")]
			[Address(RVA = "0xE56A34", Offset = "0xE56A34", VA = "0xE56A34", Slot = "11")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB133F8", Offset = "0xB133F8")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000026")]
		public virtual string Desc
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xE56C14", Offset = "0xE56C14", VA = "0xE56C14", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000135")]
			[Address(RVA = "0xE56C1C", Offset = "0xE56C1C", VA = "0xE56C1C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event Action DisposeEvent
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0xE56820", Offset = "0xE56820", VA = "0xE56820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13388", Offset = "0xB13388")]
			add
			{
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xE5690C", Offset = "0xE5690C", VA = "0xE5690C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13398", Offset = "0xB13398")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event Action<string> SetDescEvent
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0xE56A3C", Offset = "0xE56A3C", VA = "0xE56A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13408", Offset = "0xB13408")]
			add
			{
			}
			[Token(Token = "0x6000133")]
			[Address(RVA = "0xE56B28", Offset = "0xE56B28", VA = "0xE56B28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13418", Offset = "0xB13418")]
			remove
			{
			}
		}

		[Token(Token = "0x6000136")]
		protected static int GetCount<T>()
		{
			return default(int);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xE56C94", Offset = "0xE56C94", VA = "0xE56C94")]
		protected static Dictionary<string, AbstractResourceLoader> GetTypeDict(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		public static int GetRefCount<T>(string url)
		{
			return default(int);
		}

		[Token(Token = "0x6000139")]
		protected static T AutoNew<T>(string url, [Optional] LoaderDelgate callback, bool forceCreateNew = false, params object[] initArgs) where T : AbstractResourceLoader, new()
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xE56DB8", Offset = "0xE56DB8", VA = "0xE56DB8")]
		public static void CheckGcCollect()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xE56EA8", Offset = "0xE56EA8", VA = "0xE56EA8")]
		internal static void DoGarbageCollect()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xE57584", Offset = "0xE57584", VA = "0xE57584", Slot = "14")]
		protected virtual void Revive()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xE55A20", Offset = "0xE55A20", VA = "0xE55A20")]
		protected AbstractResourceLoader()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xE553C0", Offset = "0xE553C0", VA = "0xE553C0", Slot = "15")]
		protected virtual void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xE5758C", Offset = "0xE5758C", VA = "0xE5758C", Slot = "16")]
		protected virtual void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xE5765C", Offset = "0xE5765C", VA = "0xE5765C")]
		protected void AddCallback(LoaderDelgate callback)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xE577B4", Offset = "0xE577B4", VA = "0xE577B4")]
		protected void DoCallback(bool isOk, object resultObj)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xE578A4", Offset = "0xE578A4", VA = "0xE578A4", Slot = "17")]
		public virtual void Release(bool now)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xE5793C", Offset = "0xE5793C", VA = "0xE5793C", Slot = "18")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xE57F60", Offset = "0xE57F60", VA = "0xE57F60", Slot = "19")]
		protected virtual void OnReadyDisposed()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xE57324", Offset = "0xE57324", VA = "0xE57324")]
		private void Dispose()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xE5598C", Offset = "0xE5598C", VA = "0xE5598C", Slot = "20")]
		protected virtual void DoDispose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xE57F64", Offset = "0xE57F64", VA = "0xE57F64", Slot = "21")]
		public virtual void ForceDispose()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xE58018", Offset = "0xE58018", VA = "0xE58018")]
		protected void OnApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public enum LoaderMode
	{
		[Token(Token = "0x40000B8")]
		Async,
		[Token(Token = "0x40000B9")]
		Sync
	}
	[Token(Token = "0x2000030")]
	public class AssetBundleLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000CF")]
		public delegate void CAssetBundleLoaderDelegate(bool isOk, AssetBundle ab);

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11738", Offset = "0xB11738")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CAssetBundleLoaderDelegate callback;

			[Token(Token = "0x600074E")]
			[Address(RVA = "0xE01710", Offset = "0xE01710", VA = "0xE01710")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0xE0251C", Offset = "0xE0251C", VA = "0xE0251C")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11748", Offset = "0xB11748")]
		private sealed class <LoadAssetBundle>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string relativeUrl;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AssetBundleLoader <>4__this;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string[] <deps>5__2;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private string <url>5__3;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <d>5__4;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private AssetBundleLoader <loader>5__5;

			[Token(Token = "0x17000126")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000753")]
				[Address(RVA = "0xE033E0", Offset = "0xE033E0", VA = "0xE033E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000755")]
				[Address(RVA = "0xE03450", Offset = "0xE03450", VA = "0xE03450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0xE0206C", Offset = "0xE0206C", VA = "0xE0206C")]
			[DebuggerHidden]
			public <LoadAssetBundle>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0xE02A34", Offset = "0xE02A34", VA = "0xE02A34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0xE02A38", Offset = "0xE02A38", VA = "0xE02A38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0xE033E8", Offset = "0xE033E8", VA = "0xE033E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<string> NewAssetBundleLoaderEvent;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<AssetBundleLoader> AssetBundlerLoaderErrorEvent;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private KWWWRequestBundleLoader _wwwLoader;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private KAssetBundleParser BundleParser;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string RelativeResourceUrl;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<UnityEngine.Object> _loadedAssets;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private LoaderMode _loaderMode;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool _hasPreloadAssetBundleManifest;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AssetBundle _mainAssetBundle;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AssetBundleManifest _assetBundleManifest;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AssetBundleLoader[] _depLoaders;

		[Token(Token = "0x17000027")]
		public AssetBundle Bundle
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xE014DC", Offset = "0xE014DC", VA = "0xE014DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xE01568", Offset = "0xE01568", VA = "0xE01568")]
		public static AssetBundleLoader Load(string url, [Optional] CAssetBundleLoaderDelegate callback, LoaderMode loaderMode = LoaderMode.Async)
		{
			return null;
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xE01718", Offset = "0xE01718", VA = "0xE01718")]
		public static void PreLoadManifest(bool isForce = false)
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xE01B20", Offset = "0xE01B20", VA = "0xE01B20", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xE01FD4", Offset = "0xE01FD4", VA = "0xE01FD4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13428", Offset = "0xB13428")]
		private IEnumerator LoadAssetBundle(string relativeUrl)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xE02098", Offset = "0xE02098", VA = "0xE02098", Slot = "16")]
		protected override void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xE020E0", Offset = "0xE020E0", VA = "0xE020E0", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xE022D4", Offset = "0xE022D4", VA = "0xE022D4", Slot = "18")]
		public override void Release()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xE02414", Offset = "0xE02414", VA = "0xE02414")]
		public void PushLoadedAsset(UnityEngine.Object getAsset)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xE024B0", Offset = "0xE024B0", VA = "0xE024B0")]
		public AssetBundleLoader()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class KAssetBundleParser
	{
		[Token(Token = "0x20000D2")]
		public enum CAssetBundleParserMode
		{
			[Token(Token = "0x40005C6")]
			Async,
			[Token(Token = "0x40005C7")]
			Sync
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11758", Offset = "0xB11758")]
		private sealed class <WaitCreateAssetBundle>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetBundleCreateRequest req;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public KAssetBundleParser <>4__this;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startTime>5__2;

			[Token(Token = "0x17000128")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000759")]
				[Address(RVA = "0xE08F14", Offset = "0xE08F14", VA = "0xE08F14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600075B")]
				[Address(RVA = "0xE08F84", Offset = "0xE08F84", VA = "0xE08F84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0xE08BD8", Offset = "0xE08BD8", VA = "0xE08BD8")]
			[DebuggerHidden]
			public <WaitCreateAssetBundle>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0xE08C74", Offset = "0xE08C74", VA = "0xE08C74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0xE08C78", Offset = "0xE08C78", VA = "0xE08C78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0xE08F1C", Offset = "0xE08F1C", VA = "0xE08F1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static CAssetBundleParserMode Mode;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool IsDisposed;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool UnloadAllAssets;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Action<AssetBundle> Callback;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsFinished;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AssetBundle Bundle;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<string, byte[], byte[]> BundleBytesFilter;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static int _autoPriority;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly AssetBundleCreateRequest CreateRequest;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RelativePath;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly float _startTime;

		[Token(Token = "0x17000028")]
		public float Progress
		{
			[Token(Token = "0x6000155")]
			[Address(RVA = "0xE085CC", Offset = "0xE085CC", VA = "0xE085CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xE085FC", Offset = "0xE085FC", VA = "0xE085FC")]
		public KAssetBundleParser(string relativePath, byte[] bytes, [Optional] Action<AssetBundle> callback)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xE08970", Offset = "0xE08970", VA = "0xE08970")]
		private void OnFinish(AssetBundle bundle)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xE088D8", Offset = "0xE088D8", VA = "0xE088D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB1348C", Offset = "0xB1348C")]
		private IEnumerator WaitCreateAssetBundle(AssetBundleCreateRequest req)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xE08C04", Offset = "0xE08C04", VA = "0xE08C04")]
		private static byte[] DefaultParseAb(string relativePath, byte[] bytes)
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xE08B9C", Offset = "0xE08B9C", VA = "0xE08B9C")]
		private void DisposeBundle()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xE02238", Offset = "0xE02238", VA = "0xE02238")]
		public void Dispose(bool unloadAllAssets)
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class AssetFileLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000D4")]
		public delegate void AssetFileBridgeDelegate(bool isOk, UnityEngine.Object resultObj);

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11768", Offset = "0xB11768")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AssetFileBridgeDelegate assetFileLoadedCallback;

			[Token(Token = "0x6000760")]
			[Address(RVA = "0xE03788", Offset = "0xE03788", VA = "0xE03788")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x6000761")]
			[Address(RVA = "0xE03EBC", Offset = "0xE03EBC", VA = "0xE03EBC")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11778", Offset = "0xB11778")]
		private sealed class <_Init>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AssetFileLoader <>4__this;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string path;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LoaderMode loaderMode;

			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private DateTime <beginTime>5__2;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private AssetBundleRequest <request>5__3;

			[Token(Token = "0x1700012A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000765")]
				[Address(RVA = "0xE05194", Offset = "0xE05194", VA = "0xE05194", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000767")]
				[Address(RVA = "0xE05204", Offset = "0xE05204", VA = "0xE05204", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000762")]
			[Address(RVA = "0xE03B40", Offset = "0xE03B40", VA = "0xE03B40")]
			[DebuggerHidden]
			public <_Init>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000763")]
			[Address(RVA = "0xE043D4", Offset = "0xE043D4", VA = "0xE043D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000764")]
			[Address(RVA = "0xE043D8", Offset = "0xE043D8", VA = "0xE043D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0xE0519C", Offset = "0xE0519C", VA = "0xE0519C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool IsLoadAssetBundle;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AssetBundleLoader _bundleLoader;

		[Token(Token = "0x17000029")]
		public UnityEngine.Object Asset
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0xE03510", Offset = "0xE03510", VA = "0xE03510")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public override float Progress
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0xE0359C", Offset = "0xE0359C", VA = "0xE0359C", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xE035B8", Offset = "0xE035B8", VA = "0xE035B8")]
		public static AssetFileLoader Load(string path, [Optional] AssetFileBridgeDelegate assetFileLoadedCallback, LoaderMode loaderMode = LoaderMode.Async)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xE03808", Offset = "0xE03808", VA = "0xE03808")]
		public static bool IsBundleResourceExist(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xE03994", Offset = "0xE03994", VA = "0xE03994", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xE03A94", Offset = "0xE03A94", VA = "0xE03A94")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB134F0", Offset = "0xB134F0")]
		private IEnumerator _Init(string path, LoaderMode loaderMode)
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xE03B6C", Offset = "0xE03B6C", VA = "0xE03B6C")]
		public static void RefreshMaterialsShaders(Renderer renderer)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xE03D14", Offset = "0xE03D14", VA = "0xE03D14", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xE03E54", Offset = "0xE03E54", VA = "0xE03E54")]
		public AssetFileLoader()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class AudioLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11788", Offset = "0xB11788")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, AudioClip> callback;

			[Token(Token = "0x6000768")]
			[Address(RVA = "0xE05478", Offset = "0xE05478", VA = "0xE05478")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000769")]
			[Address(RVA = "0xE055E8", Offset = "0xE055E8", VA = "0xE055E8")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader AssetFileBridge;

		[Token(Token = "0x1700002B")]
		private AudioClip ResultAudioClip
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xE052C4", Offset = "0xE052C4", VA = "0xE052C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public override float Progress
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xE0532C", Offset = "0xE0532C", VA = "0xE0532C", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0xE05360", Offset = "0xE05360", VA = "0xE05360")]
		public static AudioLoader Load(string url, [Optional] Action<bool, AudioClip> callback)
		{
			return null;
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xE05480", Offset = "0xE05480", VA = "0xE05480", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xE05524", Offset = "0xE05524", VA = "0xE05524", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xE05568", Offset = "0xE05568", VA = "0xE05568")]
		public AudioLoader()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xE055D0", Offset = "0xE055D0", VA = "0xE055D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13554", Offset = "0xB13554")]
		private void <Init>b__6_0(bool isOk, UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class HotBytesLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11798", Offset = "0xB11798")]
		private sealed class <CoLoad>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HotBytesLoader <>4__this;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x1700012C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600076D")]
				[Address(RVA = "0xE07548", Offset = "0xE07548", VA = "0xE07548", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600076F")]
				[Address(RVA = "0xE075B8", Offset = "0xE075B8", VA = "0xE075B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0xE06F5C", Offset = "0xE06F5C", VA = "0xE06F5C")]
			[DebuggerHidden]
			public <CoLoad>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0xE07128", Offset = "0xE07128", VA = "0xE07128", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0xE0712C", Offset = "0xE0712C", VA = "0xE0712C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0xE07550", Offset = "0xE07550", VA = "0xE07550", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F20", Offset = "0xB11F20")]
		private byte[] <Bytes>k__BackingField;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private KWWWLoader _wwwLoader;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private LoaderMode _loaderMode;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _fullUrl;

		[Token(Token = "0x1700002D")]
		public byte[] Bytes
		{
			[Token(Token = "0x600016D")]
			[Address(RVA = "0xE01B18", Offset = "0xE01B18", VA = "0xE01B18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13564", Offset = "0xB13564")]
			get
			{
				return null;
			}
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xE06960", Offset = "0xE06960", VA = "0xE06960")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13574", Offset = "0xB13574")]
			private set
			{
			}
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE01A00", Offset = "0xE01A00", VA = "0xE01A00")]
		public static HotBytesLoader Load(string path, LoaderMode loaderMode)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE06968", Offset = "0xE06968", VA = "0xE06968")]
		public static byte[] LoadSync(string url)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE06EC4", Offset = "0xE06EC4", VA = "0xE06EC4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13584", Offset = "0xB13584")]
		private IEnumerator CoLoad(string url)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE06F88", Offset = "0xE06F88", VA = "0xE06F88", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE06FCC", Offset = "0xE06FCC", VA = "0xE06FCC", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE070C0", Offset = "0xE070C0", VA = "0xE070C0")]
		public HotBytesLoader()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class KEngineAndroidPlugin
	{
		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaClass _helper;

		[Token(Token = "0x1700002E")]
		private static AndroidJavaClass AndroidHelper
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0xE0E7BC", Offset = "0xE0E7BC", VA = "0xE0E7BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE0E858", Offset = "0xE0E858", VA = "0xE0E858")]
		private static void ErrorNotSupport()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE0E8CC", Offset = "0xE0E8CC", VA = "0xE0E8CC")]
		public static bool IsAssetExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE0E9B8", Offset = "0xE0E9B8", VA = "0xE0E9B8")]
		public static string GetAssetString(string path)
		{
			return null;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE0EAA4", Offset = "0xE0EAA4", VA = "0xE0EAA4")]
		public static byte[] GetAssetBytes(string path)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE0EB90", Offset = "0xE0EB90", VA = "0xE0EB90")]
		public KEngineAndroidPlugin()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class FontLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000D9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117A8", Offset = "0xB117A8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, Font> callback;

			[Token(Token = "0x6000770")]
			[Address(RVA = "0xE06324", Offset = "0xE06324", VA = "0xE06324")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0xE064A8", Offset = "0xE064A8", VA = "0xE064A8")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader _bridge;

		[Token(Token = "0x1700002F")]
		public override float Progress
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0xE061D8", Offset = "0xE061D8", VA = "0xE061D8", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE0620C", Offset = "0xE0620C", VA = "0xE0620C")]
		public static FontLoader Load(string path, [Optional] Action<bool, Font> callback)
		{
			return null;
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xE0632C", Offset = "0xE0632C", VA = "0xE0632C", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xE063E4", Offset = "0xE063E4", VA = "0xE063E4", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xE06428", Offset = "0xE06428", VA = "0xE06428")]
		public FontLoader()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xE06490", Offset = "0xE06490", VA = "0xE06490")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB135E8", Offset = "0xB135E8")]
		private void <Init>b__4_0(bool _isOk, UnityEngine.Object _obj)
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class KHttpDownloader : MonoBehaviour, IDisposable
	{
		[Token(Token = "0x20000DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117B8", Offset = "0xB117B8")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KHttpDownloader <>4__this;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string fullUrl;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int totalSize;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int downloadSize;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isThreadStart;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			public bool isThreadError;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
			public bool isThreadFinish;

			[Token(Token = "0x40005E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action<int, int> <>9__1;

			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action <>9__2;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Action <>9__3;

			[Token(Token = "0x6000772")]
			[Address(RVA = "0xE0FD00", Offset = "0xE0FD00", VA = "0xE0FD00")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0xE0FD08", Offset = "0xE0FD08", VA = "0xE0FD08")]
			internal void <StartDownload>b__0(object _)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0xE0FE34", Offset = "0xE0FE34", VA = "0xE0FE34")]
			internal void <StartDownload>b__1(int totalSizeNow, int downSizeNow)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0xE0FE44", Offset = "0xE0FE44", VA = "0xE0FE44")]
			internal void <StartDownload>b__2()
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0xE0FE58", Offset = "0xE0FE58", VA = "0xE0FE58")]
			internal void <StartDownload>b__3()
			{
			}
		}

		[Token(Token = "0x20000DB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117C8", Offset = "0xB117C8")]
		private sealed class <StartDownload>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KHttpDownloader <>4__this;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string fullUrl;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass24_0 <>8__1;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <timeCounter>5__2;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <MaxTime>5__3;

			[Token(Token = "0x1700012E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600077A")]
				[Address(RVA = "0xE1037C", Offset = "0xE1037C", VA = "0xE1037C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700012F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600077C")]
				[Address(RVA = "0xE103EC", Offset = "0xE103EC", VA = "0xE103EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0xE0F0A0", Offset = "0xE0F0A0", VA = "0xE0F0A0")]
			[DebuggerHidden]
			public <StartDownload>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0xE0FE64", Offset = "0xE0FE64", VA = "0xE0FE64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000779")]
			[Address(RVA = "0xE0FE68", Offset = "0xE0FE68", VA = "0xE0FE68", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0xE10384", Offset = "0xE10384", VA = "0xE10384", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string _saveFullPath;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F30", Offset = "0xB11F30")]
		private string <Url>k__BackingField;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float TIME_OUT_DEF;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool FinishedFlag;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		private bool ErrorFlag;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		private bool _useContinue;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
		private bool UseCache;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int ExpireDays;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Progress;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int TotalSize;

		[Token(Token = "0x17000030")]
		public string SaveFullPath
		{
			[Token(Token = "0x6000181")]
			[Address(RVA = "0xE0ED84", Offset = "0xE0ED84", VA = "0xE0ED84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public string Url
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xE0ED8C", Offset = "0xE0ED8C", VA = "0xE0ED8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB135F8", Offset = "0xB135F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xE0ED94", Offset = "0xE0ED94", VA = "0xE0ED94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13608", Offset = "0xB13608")]
			private set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool IsFinished
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xE0ED9C", Offset = "0xE0ED9C", VA = "0xE0ED9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsError
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xE0EDBC", Offset = "0xE0EDBC", VA = "0xE0EDBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000034")]
		public string TmpDownloadPath
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0xE0F174", Offset = "0xE0F174", VA = "0xE0F174")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xE0EDC4", Offset = "0xE0EDC4", VA = "0xE0EDC4")]
		private KHttpDownloader()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xE0EDDC", Offset = "0xE0EDDC", VA = "0xE0EDDC")]
		public static KHttpDownloader Load(string fullUrl, string saveFullPath, bool useContinue = false, bool useCache = false, int expireDays = 1, int timeout = 5)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xE0EF8C", Offset = "0xE0EF8C", VA = "0xE0EF8C")]
		public static string GetFullSavePath(string relativePath)
		{
			return null;
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xE0EF40", Offset = "0xE0EF40", VA = "0xE0EF40")]
		private void Init(string fullUrl, string saveFullPath, bool useContinue, bool useCache = false, int expireDays = 1, int timeout = 10)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xE0F080", Offset = "0xE0F080", VA = "0xE0F080")]
		public static KHttpDownloader Load(string fullUrl, string saveFullPath, int expireDays, int timeout = 5)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xE0EFE8", Offset = "0xE0EFE8", VA = "0xE0EFE8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13618", Offset = "0xB13618")]
		private IEnumerator StartDownload(string fullUrl)
		{
			return null;
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xE0F0CC", Offset = "0xE0F0CC", VA = "0xE0F0CC")]
		private void OnFinish()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xE0F0D8", Offset = "0xE0F0D8", VA = "0xE0F0D8")]
		public byte[] GetDatas()
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xE0F1C8", Offset = "0xE0F1C8", VA = "0xE0F1C8")]
		private void ThreadableResumeDownload(string url, Action<int, int> stepCallback, Action errorCallback, Action successCallback)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xE0FBE0", Offset = "0xE0FBE0", VA = "0xE0FBE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xE0FC84", Offset = "0xE0FC84", VA = "0xE0FC84", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class InstanceAssetLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000DC")]
		public delegate void KAssetLoaderDelegate(bool isOk, UnityEngine.Object asset, object[] args);

		[Token(Token = "0x20000DD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117D8", Offset = "0xB117D8")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AssetFileLoader.AssetFileBridgeDelegate callback;

			[Token(Token = "0x6000781")]
			[Address(RVA = "0xE076FC", Offset = "0xE076FC", VA = "0xE076FC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000782")]
			[Address(RVA = "0xE07B64", Offset = "0xE07B64", VA = "0xE07B64")]
			internal void <Load>b__0(bool ok, object resultObject)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117E8", Offset = "0xB117E8")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InstanceAssetLoader <>4__this;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x6000783")]
			[Address(RVA = "0xE07828", Offset = "0xE07828", VA = "0xE07828")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000784")]
			[Address(RVA = "0xE07C10", Offset = "0xE07C10", VA = "0xE07C10")]
			internal void <Init>b__0(bool isOk, UnityEngine.Object asset)
			{
			}
		}

		[Token(Token = "0x20000DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB117F8", Offset = "0xB117F8")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x6000785")]
			[Address(RVA = "0xE078E0", Offset = "0xE078E0", VA = "0xE078E0")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000786")]
			[Address(RVA = "0xE07AF0", Offset = "0xE07AF0", VA = "0xE07AF0")]
			internal void <Preload>b__0(bool isOk, UnityEngine.Object asset)
			{
			}
		}

		[Token(Token = "0x20000E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11808", Offset = "0xB11808")]
		private sealed class <CoPreload>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string path;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> callback;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AssetFileLoader <w>5__2;

			[Token(Token = "0x17000130")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0xE07FF4", Offset = "0xE07FF4", VA = "0xE07FF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000131")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0xE08064", Offset = "0xE08064", VA = "0xE08064", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000787")]
			[Address(RVA = "0xE07A5C", Offset = "0xE07A5C", VA = "0xE07A5C")]
			[DebuggerHidden]
			public <CoPreload>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000788")]
			[Address(RVA = "0xE07EEC", Offset = "0xE07EEC", VA = "0xE07EEC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000789")]
			[Address(RVA = "0xE07EF0", Offset = "0xE07EF0", VA = "0xE07EF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600078B")]
			[Address(RVA = "0xE07FFC", Offset = "0xE07FFC", VA = "0xE07FFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F40", Offset = "0xB11F40")]
		private GameObject <InstanceAsset>k__BackingField;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AssetFileLoader _assetFileBridge;

		[Token(Token = "0x17000035")]
		public GameObject InstanceAsset
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0xE075C0", Offset = "0xE075C0", VA = "0xE075C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1367C", Offset = "0xB1367C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xE075C8", Offset = "0xE075C8", VA = "0xE075C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1368C", Offset = "0xB1368C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public override float Progress
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0xE075D0", Offset = "0xE075D0", VA = "0xE075D0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xE07604", Offset = "0xE07604", VA = "0xE07604")]
		public static InstanceAssetLoader Load(string url, [Optional] AssetFileLoader.AssetFileBridgeDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xE07704", Offset = "0xE07704", VA = "0xE07704", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xE07830", Offset = "0xE07830", VA = "0xE07830")]
		public static AssetFileLoader Preload(string path, [Optional] Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xE078E8", Offset = "0xE078E8", VA = "0xE078E8", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xE079C4", Offset = "0xE079C4", VA = "0xE079C4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB1369C", Offset = "0xB1369C")]
		public static IEnumerator CoPreload(string path, [Optional] Action<bool> callback)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xE07A88", Offset = "0xE07A88", VA = "0xE07A88")]
		public InstanceAssetLoader()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class MaterialLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000E1")]
		public delegate void CCMaterialLoaderDelegate(bool isOk, Material mat);

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11818", Offset = "0xB11818")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CCMaterialLoaderDelegate callback;

			[Token(Token = "0x6000791")]
			[Address(RVA = "0x11E64E4", Offset = "0x11E64E4", VA = "0x11E64E4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000792")]
			[Address(RVA = "0x11E74B8", Offset = "0x11E74B8", VA = "0x11E74B8")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11828", Offset = "0xB11828")]
		private sealed class <CoLoadSerializeMaterial>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MaterialLoader <>4__this;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AssetFileLoader <matLoadBridge>5__2;

			[Token(Token = "0x17000132")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000796")]
				[Address(RVA = "0x11E8AC4", Offset = "0x11E8AC4", VA = "0x11E8AC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000133")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x11E8B34", Offset = "0x11E8B34", VA = "0x11E8B34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x11E6614", Offset = "0x11E6614", VA = "0x11E6614")]
			[DebuggerHidden]
			public <CoLoadSerializeMaterial>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x11E8728", Offset = "0x11E8728", VA = "0x11E8728", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000795")]
			[Address(RVA = "0x11E872C", Offset = "0x11E872C", VA = "0x11E872C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000797")]
			[Address(RVA = "0x11E8ACC", Offset = "0x11E8ACC", VA = "0x11E8ACC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11838", Offset = "0xB11838")]
		private sealed class <CoGenerateMaterial>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KSerializeMaterial sMat;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MaterialLoader <>4__this;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ShaderLoader <shaderLoader>5__2;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<KSerializeMaterialProperty>.Enumerator <>7__wrap2;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private KSerializeMaterialProperty <shaderProp>5__4;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Vector2 <tiling>5__5;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Vector2 <offset>5__6;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private string <texturePath>5__7;

			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private TextureLoader <texLoader>5__8;

			[Token(Token = "0x17000134")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x11E86B0", Offset = "0x11E86B0", VA = "0x11E86B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000135")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x11E8720", Offset = "0x11E8720", VA = "0x11E8720", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000799")]
			[Address(RVA = "0x11E6C84", Offset = "0x11E6C84", VA = "0x11E6C84")]
			[DebuggerHidden]
			public <CoGenerateMaterial>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600079A")]
			[Address(RVA = "0x11E79D0", Offset = "0x11E79D0", VA = "0x11E79D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x11E7A44", Offset = "0x11E7A44", VA = "0x11E7A44", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600079C")]
			[Address(RVA = "0x11E79EC", Offset = "0x11E79EC", VA = "0x11E79EC")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600079E")]
			[Address(RVA = "0x11E86B8", Offset = "0x11E86B8", VA = "0x11E86B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F50", Offset = "0xB11F50")]
		private Material <Mat>k__BackingField;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<TextureLoader> TextureLoaders;

		[Token(Token = "0x17000037")]
		public Material Mat
		{
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x11E63BC", Offset = "0x11E63BC", VA = "0x11E63BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13700", Offset = "0xB13700")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x11E63C4", Offset = "0x11E63C4", VA = "0x11E63C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13710", Offset = "0xB13710")]
			private set
			{
			}
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x11E63CC", Offset = "0x11E63CC", VA = "0x11E63CC")]
		public static MaterialLoader Load(string path, [Optional] CCMaterialLoaderDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11E64EC", Offset = "0x11E64EC", VA = "0x11E64EC", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x11E65A0", Offset = "0x11E65A0", VA = "0x11E65A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13720", Offset = "0xB13720")]
		private IEnumerator CoLoadSerializeMaterial()
		{
			return null;
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x11E6640", Offset = "0x11E6640", VA = "0x11E6640", Slot = "16")]
		protected override void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x11E6748", Offset = "0x11E6748", VA = "0x11E6748", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11E68CC", Offset = "0x11E68CC", VA = "0x11E68CC")]
		private string ParseMaterialStr(string materialTextureStr, out Vector2 tiling, out Vector2 offset)
		{
			return null;
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x11E6BEC", Offset = "0x11E6BEC", VA = "0x11E6BEC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13784", Offset = "0xB13784")]
		private IEnumerator CoGenerateMaterial(string matPath, KSerializeMaterial sMat)
		{
			return null;
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11E6CB0", Offset = "0x11E6CB0", VA = "0x11E6CB0")]
		private void _SetMatVector(Material mat, string propName, string propValue)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x11E6F24", Offset = "0x11E6F24", VA = "0x11E6F24")]
		private void _SetMatRange(Material mat, string propName, string propValue)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x11E7070", Offset = "0x11E7070", VA = "0x11E7070")]
		private void _SetMatColor(Material mat, string colorPropName, string _colorStr)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11E7378", Offset = "0x11E7378", VA = "0x11E7378")]
		private void _SetMatTex(Material mat, string matPropName, Texture tex, Vector2 tiling, Vector2 offset)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x11E7450", Offset = "0x11E7450", VA = "0x11E7450")]
		public MaterialLoader()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public enum KResourceQuality
	{
		[Token(Token = "0x40000E8")]
		Sd = 2,
		[Token(Token = "0x40000E9")]
		Hd = 1,
		[Token(Token = "0x40000EA")]
		Ld = 4
	}
	[Token(Token = "0x200003B")]
	public enum KResourcePathPriorityType
	{
		[Token(Token = "0x40000EC")]
		Invalid,
		[Token(Token = "0x40000ED")]
		InAppPathPriority,
		[Token(Token = "0x40000EE")]
		PersistentDataPathPriority
	}
	[Token(Token = "0x200003C")]
	public class KResourceModule : MonoBehaviour
	{
		[Token(Token = "0x20000E5")]
		public delegate void AsyncLoadABAssetDelegate(UnityEngine.Object asset, object[] args);

		[Token(Token = "0x20000E6")]
		public enum LoadingLogLevel
		{
			[Token(Token = "0x4000606")]
			None,
			[Token(Token = "0x4000607")]
			ShowTime,
			[Token(Token = "0x4000608")]
			ShowDetail
		}

		[Token(Token = "0x20000E7")]
		public enum GetResourceFullPathType
		{
			[Token(Token = "0x400060A")]
			Invalid,
			[Token(Token = "0x400060B")]
			InApp,
			[Token(Token = "0x400060C")]
			InDocument
		}

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static KResourceQuality Quality;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static KResourceModule _Instance;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool LoadByQueue;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int LogLevel;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F60", Offset = "0xB11F60")]
		private static string <ProductPathWithProtocol>k__BackingField;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F70", Offset = "0xB11F70")]
		private static string <ProductPathWithoutFileProtocol>k__BackingField;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F80", Offset = "0xB11F80")]
		private static string <BundlesPathRelative>k__BackingField;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11F90", Offset = "0xB11F90")]
		private static string <ApplicationPath>k__BackingField;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string DocumentResourcesPath;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static KResourcePathPriorityType ResourcePathPriorityType;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static Func<string, string> CustomGetResourcesPath;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string _unityEditorEditorUserBuildSettingsActiveBuildTarget;

		[Token(Token = "0x17000038")]
		public static float TextureScale
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xE12A60", Offset = "0xE12A60", VA = "0xE12A60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000039")]
		public static KResourceModule Instance
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xE01E28", Offset = "0xE01E28", VA = "0xE01E28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public static string BuildPlatformName
		{
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0xE019A4", Offset = "0xE019A4", VA = "0xE019A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public static string FileProtocol
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0xE12E0C", Offset = "0xE12E0C", VA = "0xE12E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public static string ProductRelPath
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xE12EE0", Offset = "0xE12EE0", VA = "0xE12EE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public static string EditorProductFullPath
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xE12EE8", Offset = "0xE12EE8", VA = "0xE12EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public static string ProductPathWithProtocol
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xE12F7C", Offset = "0xE12F7C", VA = "0xE12F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB137E8", Offset = "0xB137E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xE12FE4", Offset = "0xE12FE4", VA = "0xE12FE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB137F8", Offset = "0xB137F8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public static string ProductPathWithoutFileProtocol
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0xE06B78", Offset = "0xE06B78", VA = "0xE06B78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13808", Offset = "0xB13808")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0xE13050", Offset = "0xE13050", VA = "0xE13050")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13818", Offset = "0xB13818")]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public static string BundlesPathRelative
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0xE0193C", Offset = "0xE0193C", VA = "0xE0193C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13828", Offset = "0xB13828")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xE130BC", Offset = "0xE130BC", VA = "0xE130BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13838", Offset = "0xB13838")]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public static string ApplicationPath
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xE13128", Offset = "0xE13128", VA = "0xE13128")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13848", Offset = "0xB13848")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xE13190", Offset = "0xE13190", VA = "0xE13190")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13858", Offset = "0xB13858")]
			private set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public static string DocumentResourcesPathWithoutFileProtocol
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xE131FC", Offset = "0xE131FC", VA = "0xE131FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public static bool IsEditorLoadAsset
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0xE03790", Offset = "0xE03790", VA = "0xE03790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public static bool UsePersistentData
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0xE136DC", Offset = "0xE136DC", VA = "0xE136DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public static string UnityEditor_EditorUserBuildSettings_activeBuildTarget
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xE13CE4", Offset = "0xE13CE4", VA = "0xE13CE4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public static string BundlesDirName
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xE13F4C", Offset = "0xE13F4C", VA = "0xE13F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public static string EditorAssetBundleFullPath
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xE13F54", Offset = "0xE13F54", VA = "0xE13F54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xE1265C", Offset = "0xE1265C", VA = "0xE1265C")]
		static KResourceModule()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xE13280", Offset = "0xE13280", VA = "0xE13280")]
		public static string GetAssetBundlePath(string path, params object[] formats)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xE13304", Offset = "0xE13304", VA = "0xE13304")]
		public static bool ContainsResourceUrl(string resourceUrl)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xE1338C", Offset = "0xE1338C", VA = "0xE1338C")]
		public static string GetResourceFullPath(string url, bool withFileProtocol = true, bool isLog = true)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xE038FC", Offset = "0xE038FC", VA = "0xE038FC")]
		public static bool IsResourceExist(string url)
		{
			return default(bool);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xE0309C", Offset = "0xE0309C", VA = "0xE0309C")]
		public static GetResourceFullPathType GetResourceFullPath(string url, bool withFileProtocol, out string fullPath, bool isLog = true)
		{
			return default(GetResourceFullPathType);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xE13278", Offset = "0xE13278", VA = "0xE13278")]
		public static string GetAppDataPath()
		{
			return null;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xE134FC", Offset = "0xE134FC", VA = "0xE134FC")]
		public static bool TryGetInAppStreamingUrl(string url, bool withFileProtocol, out string newUrl)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xE13748", Offset = "0xE13748", VA = "0xE13748")]
		private static bool FileExistsWithDifferentCase(string filePath)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0xE13428", Offset = "0xE13428", VA = "0xE13428")]
		public static bool TryGetDocumentResourceUrl(string url, bool withFileProtocol, out string newUrl)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0xE138B0", Offset = "0xE138B0", VA = "0xE138B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0xE13C84", Offset = "0xE13C84", VA = "0xE13C84")]
		private void Update()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0xE12AD4", Offset = "0xE12AD4", VA = "0xE12AD4")]
		public static string GetBuildPlatformName()
		{
			return null;
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0xE12E68", Offset = "0xE12E68", VA = "0xE12E68")]
		public static string GetFileProtocol()
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xE13FC8", Offset = "0xE13FC8", VA = "0xE13FC8")]
		public static AbstractResourceLoader LoadBundleAsync(string path, [Optional] AssetFileLoader.AssetFileBridgeDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xE13FD0", Offset = "0xE13FD0", VA = "0xE13FD0")]
		public static AbstractResourceLoader LoadBundle(string path, [Optional] AssetFileLoader.AssetFileBridgeDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xE13FD8", Offset = "0xE13FD8", VA = "0xE13FD8")]
		public static bool IsStreamingAssetsExists(string path)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE06D6C", Offset = "0xE06D6C", VA = "0xE06D6C")]
		public static byte[] LoadSyncFromStreamingAssets(string path)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE06BE0", Offset = "0xE06BE0", VA = "0xE06BE0")]
		public static byte[] ReadAllBytes(string resPath)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE126CC", Offset = "0xE126CC", VA = "0xE126CC")]
		private static void InitResourcePath()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xE01CB8", Offset = "0xE01CB8", VA = "0xE01CB8")]
		public static void LogRequest(string resType, string resPath)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE04DF0", Offset = "0xE04DF0", VA = "0xE04DF0")]
		public static void LogLoadTime(string resType, string resPath, DateTime begin)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xE1407C", Offset = "0xE1407C", VA = "0xE1407C")]
		public static void Collect()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xE14134", Offset = "0xE14134", VA = "0xE14134")]
		public KResourceModule()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class ShaderLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000E8")]
		public delegate void ShaderLoaderDelegate(bool isOk, Shader shader);

		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11848", Offset = "0xB11848")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ShaderLoaderDelegate callback;

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x11EADDC", Offset = "0x11EADDC", VA = "0x11EADDC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x11EB024", Offset = "0x11EB024", VA = "0x11EB024")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11858", Offset = "0xB11858")]
		private sealed class <CoLoadShader>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderLoader <>4__this;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AssetBundleLoader <loader>5__2;

			[Token(Token = "0x17000136")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x11EB7E0", Offset = "0x11EB7E0", VA = "0x11EB7E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000137")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x11EB850", Offset = "0x11EB850", VA = "0x11EB850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x11EAF0C", Offset = "0x11EAF0C", VA = "0x11EAF0C")]
			[DebuggerHidden]
			public <CoLoadShader>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x11EB51C", Offset = "0x11EB51C", VA = "0x11EB51C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x11EB520", Offset = "0x11EB520", VA = "0x11EB520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x11EB7E8", Offset = "0x11EB7E8", VA = "0x11EB7E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x17000048")]
		public Shader ShaderAsset
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x11E84A4", Offset = "0x11E84A4", VA = "0x11E84A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x11E838C", Offset = "0x11E838C", VA = "0x11E838C")]
		public static ShaderLoader Load(string path, [Optional] ShaderLoaderDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x11EADE4", Offset = "0x11EADE4", VA = "0x11EADE4", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x11EAE98", Offset = "0x11EAE98", VA = "0x11EAE98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13868", Offset = "0xB13868")]
		private IEnumerator CoLoadShader()
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x11EAF38", Offset = "0x11EAF38", VA = "0x11EAF38", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x11EAFBC", Offset = "0x11EAFBC", VA = "0x11EAFBC")]
		public ShaderLoader()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class SpriteLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000EB")]
		public delegate void CSpriteLoaderDelegate(bool isOk, Sprite tex);

		[Token(Token = "0x20000EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11868", Offset = "0xB11868")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CSpriteLoaderDelegate callback;

			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x11EBAD4", Offset = "0x11EBAD4", VA = "0x11EBAD4")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x11EBC4C", Offset = "0x11EBC4C", VA = "0x11EBC4C")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader AssetFileBridge;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11FA0", Offset = "0xB11FA0")]
		private string <Path>k__BackingField;

		[Token(Token = "0x17000049")]
		public Sprite Asset
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x11EB910", Offset = "0x11EB910", VA = "0x11EB910")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public override float Progress
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x11EB978", Offset = "0x11EB978", VA = "0x11EB978", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004B")]
		public string Path
		{
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x11EB9AC", Offset = "0x11EB9AC", VA = "0x11EB9AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB138CC", Offset = "0xB138CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x11EB9B4", Offset = "0x11EB9B4", VA = "0x11EB9B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB138DC", Offset = "0xB138DC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x11EB9BC", Offset = "0x11EB9BC", VA = "0x11EB9BC")]
		public static SpriteLoader Load(string path, [Optional] CSpriteLoaderDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x11EBADC", Offset = "0x11EBADC", VA = "0x11EBADC", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x11EBB88", Offset = "0x11EBB88", VA = "0x11EBB88")]
		private void OnAssetLoaded(bool isOk, UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x11EBBA0", Offset = "0x11EBBA0", VA = "0x11EBBA0", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x11EBBE4", Offset = "0x11EBBE4", VA = "0x11EBBE4")]
		public SpriteLoader()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class StaticAssetLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11878", Offset = "0xB11878")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AssetFileLoader.AssetFileBridgeDelegate callback;

			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x11EC550", Offset = "0x11EC550", VA = "0x11EC550")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x11EC8BC", Offset = "0x11EC8BC", VA = "0x11EC8BC")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11888", Offset = "0xB11888")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public StaticAssetLoader <>4__this;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string path;

			[Token(Token = "0x60007B8")]
			[Address(RVA = "0x11EC6E8", Offset = "0x11EC6E8", VA = "0x11EC6E8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x11EC970", Offset = "0x11EC970", VA = "0x11EC970")]
			internal void <Init>b__0(bool _isOk, UnityEngine.Object _obj)
			{
			}
		}

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader _assetFileLoader;

		[Token(Token = "0x1700004C")]
		public UnityEngine.Object TheAsset
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x11EC2AC", Offset = "0x11EC2AC", VA = "0x11EC2AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public override float Progress
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x11EC380", Offset = "0x11EC380", VA = "0x11EC380", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x11EC3B4", Offset = "0x11EC3B4", VA = "0x11EC3B4")]
		public static StaticAssetLoader Load(string url, [Optional] AssetFileLoader.AssetFileBridgeDelegate callback, LoaderMode loaderMode = LoaderMode.Async)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x11EC558", Offset = "0x11EC558", VA = "0x11EC558", Slot = "15")]
		protected override void Init(string path, params object[] args)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x11EC6F0", Offset = "0x11EC6F0", VA = "0x11EC6F0", Slot = "16")]
		protected override void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x11EC7AC", Offset = "0x11EC7AC", VA = "0x11EC7AC", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x11EC854", Offset = "0x11EC854", VA = "0x11EC854")]
		public StaticAssetLoader()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class TextureLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000EF")]
		public delegate void CTextureLoaderDelegate(bool isOk, Texture tex);

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11898", Offset = "0xB11898")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CTextureLoaderDelegate callback;

			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x11EE9C8", Offset = "0x11EE9C8", VA = "0x11EE9C8")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x11EEF8C", Offset = "0x11EEF8C", VA = "0x11EEF8C")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader AssetFileBridge;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11FB0", Offset = "0xB11FB0")]
		private string <Path>k__BackingField;

		[Token(Token = "0x1700004E")]
		public Texture Asset
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x11E8624", Offset = "0x11E8624", VA = "0x11E8624")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public override float Progress
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x11EE984", Offset = "0x11EE984", VA = "0x11EE984", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public string Path
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x11EE9B8", Offset = "0x11EE9B8", VA = "0x11EE9B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB138EC", Offset = "0xB138EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x11EE9C0", Offset = "0x11EE9C0", VA = "0x11EE9C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB138FC", Offset = "0xB138FC")]
			private set
			{
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x11E850C", Offset = "0x11E850C", VA = "0x11E850C")]
		public static TextureLoader Load(string path, [Optional] CTextureLoaderDelegate callback)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x11EE9D0", Offset = "0x11EE9D0", VA = "0x11EE9D0", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x11EEA7C", Offset = "0x11EEA7C", VA = "0x11EEA7C")]
		private void OnAssetLoaded(bool isOk, UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x11EEEE0", Offset = "0x11EEEE0", VA = "0x11EEEE0", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x11EEF24", Offset = "0x11EEF24", VA = "0x11EEF24")]
		public TextureLoader()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class KWWWLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118A8", Offset = "0xB118A8")]
		private sealed class <CoLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public KWWWLoader <>4__this;

			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private DateTime <beginTime>5__2;

			[Token(Token = "0x17000138")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0xE1A6DC", Offset = "0xE1A6DC", VA = "0xE1A6DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000139")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0xE1A74C", Offset = "0xE1A74C", VA = "0xE1A74C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C0")]
			[Address(RVA = "0xE19964", Offset = "0xE19964", VA = "0xE19964")]
			[DebuggerHidden]
			public <CoLoad>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60007C1")]
			[Address(RVA = "0xE19BB0", Offset = "0xE19BB0", VA = "0xE19BB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C2")]
			[Address(RVA = "0xE19BB4", Offset = "0xE19BB4", VA = "0xE19BB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007C4")]
			[Address(RVA = "0xE1A6E4", Offset = "0xE1A6E4", VA = "0xE1A6E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118B8", Offset = "0xB118B8")]
		private sealed class <WWWLoaderMonitorCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700013A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007C9")]
				[Address(RVA = "0xE1A988", Offset = "0xE1A988", VA = "0xE1A988", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0xE1A9F8", Offset = "0xE1A9F8", VA = "0xE1A9F8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007C6")]
			[Address(RVA = "0xE19A9C", Offset = "0xE19A9C", VA = "0xE19A9C")]
			[DebuggerHidden]
			public <WWWLoaderMonitorCoroutine>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60007C7")]
			[Address(RVA = "0xE1A754", Offset = "0xE1A754", VA = "0xE1A754", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007C8")]
			[Address(RVA = "0xE1A758", Offset = "0xE1A758", VA = "0xE1A758", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007CA")]
			[Address(RVA = "0xE1A990", Offset = "0xE1A990", VA = "0xE1A990", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Coroutine CachedWWWLoaderMonitorSC;

		[Token(Token = "0x4000101")]
		private const int MAX_WWW_COUNT = 5;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int WWWLoadingCount;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Stack<KWWWLoader> WWWLoadersStack;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float BeginLoadTime;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float FinishLoadTime;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityWebRequest Www;

		[Token(Token = "0x17000051")]
		public ulong Size
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xE19620", Offset = "0xE19620", VA = "0xE19620")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000052")]
		public float LoadSpeed
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xE19650", Offset = "0xE19650", VA = "0xE19650")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x14000007")]
		public static event Action<string> WWWFinishCallback
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0xE193C0", Offset = "0xE193C0", VA = "0xE193C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1390C", Offset = "0xB1390C")]
			add
			{
			}
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0xE194F0", Offset = "0xE194F0", VA = "0xE194F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1391C", Offset = "0xB1391C")]
			remove
			{
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xE074A8", Offset = "0xE074A8", VA = "0xE074A8")]
		public static KWWWLoader Load(string url, [Optional] LoaderDelgate callback)
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xE19698", Offset = "0xE19698", VA = "0xE19698", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xE19830", Offset = "0xE19830", VA = "0xE19830")]
		protected void StartLoad()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xE198CC", Offset = "0xE198CC", VA = "0xE198CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB1392C", Offset = "0xB1392C")]
		private IEnumerator CoLoad(string url)
		{
			return null;
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xE19990", Offset = "0xE19990", VA = "0xE19990", Slot = "16")]
		protected override void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xE199C8", Offset = "0xE199C8", VA = "0xE199C8", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xE197D0", Offset = "0xE197D0", VA = "0xE197D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13990", Offset = "0xB13990")]
		protected static IEnumerator WWWLoaderMonitorCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xE19AC8", Offset = "0xE19AC8", VA = "0xE19AC8")]
		public KWWWLoader()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class KWWWRequestBundleLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118C8", Offset = "0xB118C8")]
		private sealed class <CoLoad>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string url;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public KWWWRequestBundleLoader <>4__this;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private DateTime <beginTime>5__2;

			[Token(Token = "0x1700013C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0xE1BCF0", Offset = "0xE1BCF0", VA = "0xE1BCF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D1")]
				[Address(RVA = "0xE1BD60", Offset = "0xE1BD60", VA = "0xE1BD60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007CC")]
			[Address(RVA = "0xE1AFA4", Offset = "0xE1AFA4", VA = "0xE1AFA4")]
			[DebuggerHidden]
			public <CoLoad>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xE1B1C4", Offset = "0xE1B1C4", VA = "0xE1B1C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007CE")]
			[Address(RVA = "0xE1B1C8", Offset = "0xE1B1C8", VA = "0xE1B1C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0xE1BCF8", Offset = "0xE1BCF8", VA = "0xE1BCF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118D8", Offset = "0xB118D8")]
		private sealed class <WWWLoaderMonitorCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x1700013E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x11E3754", Offset = "0x11E3754", VA = "0x11E3754", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D7")]
				[Address(RVA = "0x11E37C4", Offset = "0x11E37C4", VA = "0x11E37C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x11E34F0", Offset = "0x11E34F0", VA = "0x11E34F0")]
			[DebuggerHidden]
			public <WWWLoaderMonitorCoroutine>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x11E351C", Offset = "0x11E351C", VA = "0x11E351C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x11E3520", Offset = "0x11E3520", VA = "0x11E3520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x11E375C", Offset = "0x11E375C", VA = "0x11E375C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Coroutine CachedWWWLoaderMonitorSC;

		[Token(Token = "0x4000109")]
		private const int MAX_WWW_COUNT = 3;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int WWWLoadingCount;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Stack<KWWWRequestBundleLoader> WWWLoadersStack;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float BeginLoadTime;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float FinishLoadTime;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public UnityWebRequest Www;

		[Token(Token = "0x17000053")]
		public ulong Size
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0xE1AC60", Offset = "0xE1AC60", VA = "0xE1AC60")]
			get
			{
				return default(ulong);
			}
		}

		[Token(Token = "0x17000054")]
		public float LoadSpeed
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xE1AC90", Offset = "0xE1AC90", VA = "0xE1AC90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x14000008")]
		public static event Action<string> WWWFinishCallback
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0xE1AA00", Offset = "0xE1AA00", VA = "0xE1AA00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB139F4", Offset = "0xB139F4")]
			add
			{
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0xE1AB30", Offset = "0xE1AB30", VA = "0xE1AB30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13A04", Offset = "0xB13A04")]
			remove
			{
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xE03340", Offset = "0xE03340", VA = "0xE03340")]
		public static KWWWRequestBundleLoader Load(string url, [Optional] LoaderDelgate callback)
		{
			return null;
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xE1ACD8", Offset = "0xE1ACD8", VA = "0xE1ACD8", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0xE1AE70", Offset = "0xE1AE70", VA = "0xE1AE70")]
		protected void StartLoad()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xE1AF0C", Offset = "0xE1AF0C", VA = "0xE1AF0C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13A14", Offset = "0xB13A14")]
		private IEnumerator CoLoad(string url)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0xE1AFD0", Offset = "0xE1AFD0", VA = "0xE1AFD0", Slot = "16")]
		protected override void OnFinish(object resultObj)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xE1B008", Offset = "0xE1B008", VA = "0xE1B008", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xE1AE10", Offset = "0xE1AE10", VA = "0xE1AE10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13A78", Offset = "0xB13A78")]
		protected static IEnumerator WWWLoaderMonitorCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xE1B0DC", Offset = "0xE1B0DC", VA = "0xE1B0DC")]
		public KWWWRequestBundleLoader()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class KDebuggerObjectTool
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Transform> Parents;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, int> Counts;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xE0DD30", Offset = "0xE0DD30", VA = "0xE0DD30")]
		private static string GetUri(string bigType, string smallType)
		{
			return null;
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0xE0DD94", Offset = "0xE0DD94", VA = "0xE0DD94")]
		public static void SetParent(string bigType, string smallType, GameObject obj)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xE0E4B8", Offset = "0xE0E4B8", VA = "0xE0E4B8")]
		public static void RemoveFromParent(string bigType, string smallType, GameObject obj)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xE0E434", Offset = "0xE0E434", VA = "0xE0E434")]
		protected static string GetNameWithCount(string smallType, int count)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xE0E11C", Offset = "0xE0E11C", VA = "0xE0E11C")]
		protected static Transform GetParent(string bigType, string smallType)
		{
			return null;
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0xE0E710", Offset = "0xE0E710", VA = "0xE0E710")]
		public KDebuggerObjectTool()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class KResoourceLoadedAssetDebugger : MonoBehaviour
	{
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MemorySize;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object TheObject;

		[Token(Token = "0x4000114")]
		private const string bigType = "LoadedAssetDebugger";

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Type;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool IsRemoveFromParent;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0xE0500C", Offset = "0xE0500C", VA = "0xE0500C")]
		public static KResoourceLoadedAssetDebugger Create(string type, string url, UnityEngine.Object theObject)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xE11F08", Offset = "0xE11F08", VA = "0xE11F08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xE11FE8", Offset = "0xE11FE8", VA = "0xE11FE8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xE12090", Offset = "0xE12090", VA = "0xE12090")]
		public KResoourceLoadedAssetDebugger()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public class KResourceLoaderDebugger : MonoBehaviour
	{
		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118E8", Offset = "0xB118E8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string type;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string url;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AbstractResourceLoader loader;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject newHelpGameObject;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Func<string> getName;

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xE12320", Offset = "0xE12320", VA = "0xE12320")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0xE12464", Offset = "0xE12464", VA = "0xE12464")]
			internal string <Create>b__0()
			{
				return null;
			}

			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xE124F4", Offset = "0xE124F4", VA = "0xE124F4")]
			internal void <Create>b__1(string newDesc)
			{
			}

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0xE125A4", Offset = "0xE125A4", VA = "0xE125A4")]
			internal void <Create>b__2()
			{
			}
		}

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AbstractResourceLoader TheLoader;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int RefCount;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float FinishUsedTime;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool IsApplicationQuit;

		[Token(Token = "0x6000219")]
		[Address(RVA = "0xE12098", Offset = "0xE12098", VA = "0xE12098")]
		public static KResourceLoaderDebugger Create(string type, string url, AbstractResourceLoader loader)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xE12328", Offset = "0xE12328", VA = "0xE12328")]
		private void Update()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0xE123EC", Offset = "0xE123EC", VA = "0xE123EC")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xE12458", Offset = "0xE12458", VA = "0xE12458")]
		public KResourceLoaderDebugger()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class SceneLoader : AbstractResourceLoader
	{
		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB118F8", Offset = "0xB118F8")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool> callback;

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x11EA410", Offset = "0x11EA410", VA = "0x11EA410")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x11EA900", Offset = "0x11EA900", VA = "0x11EA900")]
			internal void <Load>b__0(bool isOk, object obj)
			{
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11908", Offset = "0xB11908")]
		private sealed class <Start>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SceneLoader <>4__this;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <op>5__2;

			[Token(Token = "0x17000140")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E1")]
				[Address(RVA = "0x11EAD64", Offset = "0x11EAD64", VA = "0x11EAD64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000141")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E3")]
				[Address(RVA = "0x11EADD4", Offset = "0x11EADD4", VA = "0x11EADD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x11EA5EC", Offset = "0x11EA5EC", VA = "0x11EA5EC")]
			[DebuggerHidden]
			public <Start>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x11EAA8C", Offset = "0x11EAA8C", VA = "0x11EAA8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x11EAA90", Offset = "0x11EAA90", VA = "0x11EAA90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x11EAD6C", Offset = "0x11EAD6C", VA = "0x11EAD6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11918", Offset = "0xB11918")]
		private sealed class <EditorLoadSceneBugFix>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncOperation op;

			[Token(Token = "0x17000142")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007E7")]
				[Address(RVA = "0x11EAA14", Offset = "0x11EAA14", VA = "0x11EAA14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000143")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007E9")]
				[Address(RVA = "0x11EAA84", Offset = "0x11EAA84", VA = "0x11EAA84", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x11EA68C", Offset = "0x11EA68C", VA = "0x11EA68C")]
			[DebuggerHidden]
			public <EditorLoadSceneBugFix>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x11EA970", Offset = "0x11EA970", VA = "0x11EA970", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x11EA974", Offset = "0x11EA974", VA = "0x11EA974", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x11EAA1C", Offset = "0x11EAA1C", VA = "0x11EAA1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private AssetFileLoader _assetFileBridge;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private LoaderMode _mode;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private string _url;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _sceneName;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _isAdditive;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Action DisposeFinishedAction;

		[Token(Token = "0x17000055")]
		public string SceneName
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x11EA200", Offset = "0x11EA200", VA = "0x11EA200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x11EA208", Offset = "0x11EA208", VA = "0x11EA208")]
		public static SceneLoader Load(string url, [Optional] Action<bool> callback, LoaderMode mode = LoaderMode.Async, bool isAdditive = true)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x11EA418", Offset = "0x11EA418", VA = "0x11EA418", Slot = "15")]
		protected override void Init(string url, params object[] args)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x11EA578", Offset = "0x11EA578", VA = "0x11EA578")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13ADC", Offset = "0xB13ADC")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x11EA618", Offset = "0x11EA618", VA = "0x11EA618")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13B40", Offset = "0xB13B40")]
		private static IEnumerator EditorLoadSceneBugFix(AsyncOperation op)
		{
			return null;
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x11EA6B8", Offset = "0x11EA6B8", VA = "0x11EA6B8")]
		private static void RefreshAllMaterialsShaders()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x11EA780", Offset = "0x11EA780", VA = "0x11EA780", Slot = "20")]
		protected override void DoDispose()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x11EA884", Offset = "0x11EA884", VA = "0x11EA884")]
		public SceneLoader()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x11EA8EC", Offset = "0x11EA8EC", VA = "0x11EA8EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13BA4", Offset = "0xB13BA4")]
		private void <DoDispose>b__13_0(AsyncOperation o)
		{
		}
	}
	[Token(Token = "0x2000047")]
	public interface IAsyncObject
	{
		[Token(Token = "0x17000056")]
		object AsyncResult
		{
			[Token(Token = "0x6000227")]
			get;
		}

		[Token(Token = "0x17000057")]
		bool IsCompleted
		{
			[Token(Token = "0x6000228")]
			get;
		}

		[Token(Token = "0x17000058")]
		bool IsError
		{
			[Token(Token = "0x6000229")]
			get;
		}

		[Token(Token = "0x17000059")]
		string AsyncMessage
		{
			[Token(Token = "0x600022A")]
			get;
		}

		[Token(Token = "0x1700005A")]
		bool IsSuccess
		{
			[Token(Token = "0x600022B")]
			get;
		}
	}
	[Token(Token = "0x2000048")]
	public class KAsync
	{
		[Token(Token = "0x20000F9")]
		private delegate void AsyncWaitNextDelegate(Action nextFunc);

		[Token(Token = "0x20000FA")]
		public delegate void AsyncThreadDelegateFull(object param, Action next);

		[Token(Token = "0x20000FB")]
		public delegate void AsyncThreadDelegate(Action next);

		[Token(Token = "0x20000FC")]
		public delegate void AsyncThenDelegateEasy(Action next);

		[Token(Token = "0x20000FD")]
		public delegate void AsyncThenDelegate(Action next, Action kill);

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11928", Offset = "0xB11928")]
		private sealed class <EmWaitFinish>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KAsync <>4__this;

			[Token(Token = "0x17000144")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000801")]
				[Address(RVA = "0xE0CE94", Offset = "0xE0CE94", VA = "0xE0CE94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000145")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000803")]
				[Address(RVA = "0xE0CF04", Offset = "0xE0CF04", VA = "0xE0CF04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0xE09204", Offset = "0xE09204", VA = "0xE09204")]
			[DebuggerHidden]
			public <EmWaitFinish>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xE0CE34", Offset = "0xE0CE34", VA = "0xE0CE34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000800")]
			[Address(RVA = "0xE0CE38", Offset = "0xE0CE38", VA = "0xE0CE38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000802")]
			[Address(RVA = "0xE0CE9C", Offset = "0xE0CE9C", VA = "0xE0CE9C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11938", Offset = "0xB11938")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action callback;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0xE09E30", Offset = "0xE09E30", VA = "0xE09E30")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0xE0ABF8", Offset = "0xE0ABF8", VA = "0xE0ABF8")]
			internal void <Then>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11948", Offset = "0xB11948")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncThenDelegate thenFunc;

			[Token(Token = "0x6000806")]
			[Address(RVA = "0xE09EFC", Offset = "0xE09EFC", VA = "0xE09EFC")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0xE0AC44", Offset = "0xE0AC44", VA = "0xE0AC44")]
			internal void <Then>b__0(Action next)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11958", Offset = "0xB11958")]
		private sealed class <>c
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Action <>9__21_1;

			[Token(Token = "0x6000809")]
			[Address(RVA = "0xE0AB84", Offset = "0xE0AB84", VA = "0xE0AB84")]
			public <>c()
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0xE0AB8C", Offset = "0xE0AB8C", VA = "0xE0AB8C")]
			internal void <Then>b__21_1()
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11968", Offset = "0xB11968")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KAsync <>4__this;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<bool> retBool;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeout;

			[Token(Token = "0x600080B")]
			[Address(RVA = "0xE09FF0", Offset = "0xE09FF0", VA = "0xE09FF0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0xE0B4C4", Offset = "0xE0B4C4", VA = "0xE0B4C4")]
			internal void <When>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11978", Offset = "0xB11978")]
		private sealed class <_CoWhen>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float timeout;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Func<bool> retBool;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action next;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <time>5__2;

			[Token(Token = "0x17000146")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000810")]
				[Address(RVA = "0xE0D180", Offset = "0xE0D180", VA = "0xE0D180", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000147")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000812")]
				[Address(RVA = "0xE0D1F0", Offset = "0xE0D1F0", VA = "0xE0D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0xE0A0B0", Offset = "0xE0A0B0", VA = "0xE0A0B0")]
			[DebuggerHidden]
			public <_CoWhen>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600080E")]
			[Address(RVA = "0xE0D044", Offset = "0xE0D044", VA = "0xE0D044", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0xE0D048", Offset = "0xE0D048", VA = "0xE0D048", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0xE0D188", Offset = "0xE0D188", VA = "0xE0D188", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000104")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11988", Offset = "0xB11988")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncThenDelegateEasy thenFunc;

			[Token(Token = "0x6000813")]
			[Address(RVA = "0xE0A0DC", Offset = "0xE0A0DC", VA = "0xE0A0DC")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0xE0B53C", Offset = "0xE0B53C", VA = "0xE0B53C")]
			internal void <Then>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x2000105")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11998", Offset = "0xB11998")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AsyncThreadDelegate threadCalAction;

			[Token(Token = "0x6000815")]
			[Address(RVA = "0xE0A198", Offset = "0xE0A198", VA = "0xE0A198")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0xE0BCA4", Offset = "0xE0BCA4", VA = "0xE0BCA4")]
			internal void <Thread>b__0(object thread, Action next)
			{
			}
		}

		[Token(Token = "0x2000106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119A8", Offset = "0xB119A8")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action threadCalAction;

			[Token(Token = "0x6000817")]
			[Address(RVA = "0xE0A3F4", Offset = "0xE0A3F4", VA = "0xE0A3F4")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xE0C40C", Offset = "0xE0C40C", VA = "0xE0C40C")]
			internal void <Thread>b__0(object thread, Action next)
			{
			}
		}

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119B8", Offset = "0xB119B8")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool waitThreadFinish;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncThreadDelegateFull threadCalAction;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public object param;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action <>9__1;

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xE0C458", Offset = "0xE0C458", VA = "0xE0C458")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0xE0C460", Offset = "0xE0C460", VA = "0xE0C460")]
			internal void <_Thread>b__0()
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xE0CC80", Offset = "0xE0CC80", VA = "0xE0CC80")]
			internal void <_Thread>b__1()
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119C8", Offset = "0xB119C8")]
		private sealed class <_Thread>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AsyncThreadDelegateFull threadCalAction;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object param;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private <>c__DisplayClass29_0 <>8__1;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Thread <thread>5__2;

			[Token(Token = "0x17000148")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0xE0D5DC", Offset = "0xE0D5DC", VA = "0xE0D5DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000149")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000821")]
				[Address(RVA = "0xE0D64C", Offset = "0xE0D64C", VA = "0xE0D64C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0xE0A3FC", Offset = "0xE0A3FC", VA = "0xE0A3FC")]
			[DebuggerHidden]
			public <_Thread>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0xE0D3F8", Offset = "0xE0D3F8", VA = "0xE0D3F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0xE0D3FC", Offset = "0xE0D3FC", VA = "0xE0D3FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0xE0D5E4", Offset = "0xE0D5E4", VA = "0xE0D5E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000109")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119D8", Offset = "0xB119D8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KAsync <>4__this;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerator enumtor;

			[Token(Token = "0x6000822")]
			[Address(RVA = "0xE0A428", Offset = "0xE0A428", VA = "0xE0A428")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0xE0CC8C", Offset = "0xE0CC8C", VA = "0xE0CC8C")]
			internal void <Coroutine>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119E8", Offset = "0xB119E8")]
		private sealed class <_StartCoroutine>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator enumtor;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action next;

			[Token(Token = "0x1700014A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0xE0D380", Offset = "0xE0D380", VA = "0xE0D380", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000829")]
				[Address(RVA = "0xE0D3F0", Offset = "0xE0D3F0", VA = "0xE0D3F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0xE0A4C8", Offset = "0xE0A4C8", VA = "0xE0A4C8")]
			[DebuggerHidden]
			public <_StartCoroutine>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0xE0D2E4", Offset = "0xE0D2E4", VA = "0xE0D2E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0xE0D2E8", Offset = "0xE0D2E8", VA = "0xE0D2E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0xE0D388", Offset = "0xE0D388", VA = "0xE0D388", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB119F8", Offset = "0xB119F8")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KAsync <>4__this;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Coroutine co;

			[Token(Token = "0x600082A")]
			[Address(RVA = "0xE0A5C0", Offset = "0xE0A5C0", VA = "0xE0A5C0")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0xE0CCF4", Offset = "0xE0CCF4", VA = "0xE0CCF4")]
			internal void <Coroutine>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A08", Offset = "0xB11A08")]
		private sealed class <_Coroutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Coroutine co;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action next;

			[Token(Token = "0x1700014C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0xE0D26C", Offset = "0xE0D26C", VA = "0xE0D26C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000831")]
				[Address(RVA = "0xE0D2DC", Offset = "0xE0D2DC", VA = "0xE0D2DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0xE0A660", Offset = "0xE0A660", VA = "0xE0A660")]
			[DebuggerHidden]
			public <_Coroutine>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0xE0D1F8", Offset = "0xE0D1F8", VA = "0xE0D1F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0xE0D1FC", Offset = "0xE0D1FC", VA = "0xE0D1FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0xE0D274", Offset = "0xE0D274", VA = "0xE0D274", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A18", Offset = "0xB11A18")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KAsync <>4__this;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int frameCount;

			[Token(Token = "0x6000832")]
			[Address(RVA = "0xE0A758", Offset = "0xE0A758", VA = "0xE0A758")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0xE0CD5C", Offset = "0xE0CD5C", VA = "0xE0CD5C")]
			internal void <WaitForFrames>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A28", Offset = "0xB11A28")]
		private sealed class <_WaitForFrames>d__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int frameCount;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action next;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <i>5__2;

			[Token(Token = "0x1700014E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000837")]
				[Address(RVA = "0xE0D814", Offset = "0xE0D814", VA = "0xE0D814", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000839")]
				[Address(RVA = "0xE0D884", Offset = "0xE0D884", VA = "0xE0D884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xE0A7F8", Offset = "0xE0A7F8", VA = "0xE0A7F8")]
			[DebuggerHidden]
			public <_WaitForFrames>d__35(int <>1__state)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0xE0D77C", Offset = "0xE0D77C", VA = "0xE0D77C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xE0D780", Offset = "0xE0D780", VA = "0xE0D780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xE0D81C", Offset = "0xE0D81C", VA = "0xE0D81C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A38", Offset = "0xB11A38")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public KAsync <>4__this;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float time;

			[Token(Token = "0x600083A")]
			[Address(RVA = "0xE0A8F0", Offset = "0xE0A8F0", VA = "0xE0A8F0")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0xE0CDC8", Offset = "0xE0CDC8", VA = "0xE0CDC8")]
			internal void <WaitForSeconds>b__0(Action next)
			{
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A48", Offset = "0xB11A48")]
		private sealed class <_CoWaitForSeconds>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action next;

			[Token(Token = "0x17000150")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0xE0CFCC", Offset = "0xE0CFCC", VA = "0xE0CFCC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000151")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0xE0D03C", Offset = "0xE0D03C", VA = "0xE0D03C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083C")]
			[Address(RVA = "0xE0A990", Offset = "0xE0A990", VA = "0xE0A990")]
			[DebuggerHidden]
			public <_CoWaitForSeconds>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xE0CF0C", Offset = "0xE0CF0C", VA = "0xE0CF0C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xE0CF10", Offset = "0xE0CF10", VA = "0xE0CF10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xE0CFD4", Offset = "0xE0CFD4", VA = "0xE0CFD4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A58", Offset = "0xB11A58")]
		private sealed class <_WaitForEndOfFrame>d__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action next;

			[Token(Token = "0x17000152")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000845")]
				[Address(RVA = "0xE0D704", Offset = "0xE0D704", VA = "0xE0D704", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000153")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000847")]
				[Address(RVA = "0xE0D774", Offset = "0xE0D774", VA = "0xE0D774", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0xE0AAAC", Offset = "0xE0AAAC", VA = "0xE0AAAC")]
			[DebuggerHidden]
			public <_WaitForEndOfFrame>d__39(int <>1__state)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0xE0D654", Offset = "0xE0D654", VA = "0xE0D654", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000844")]
			[Address(RVA = "0xE0D658", Offset = "0xE0D658", VA = "0xE0D658", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0xE0D70C", Offset = "0xE0D70C", VA = "0xE0D70C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Queue<AsyncWaitNextDelegate> _cacheCallbacks;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _canNext;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11FE0", Offset = "0xB11FE0")]
		private bool <IsFinished>k__BackingField;

		[Token(Token = "0x1700005B")]
		public bool IsFinished
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xE08FB8", Offset = "0xE08FB8", VA = "0xE08FB8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13BB4", Offset = "0xB13BB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xE08FC0", Offset = "0xE08FC0", VA = "0xE08FC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13BC4", Offset = "0xB13BC4")]
			private set
			{
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xE08F8C", Offset = "0xE08F8C", VA = "0xE08F8C")]
		private KAsync()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0xE08FCC", Offset = "0xE08FCC", VA = "0xE08FCC")]
		public Coroutine WaitFinish()
		{
			return null;
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0xE09190", Offset = "0xE09190", VA = "0xE09190")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13BD4", Offset = "0xB13BD4")]
		private IEnumerator EmWaitFinish()
		{
			return null;
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0xE09230", Offset = "0xE09230", VA = "0xE09230")]
		private void WaitNext(AsyncWaitNextDelegate callback)
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0xE09A5C", Offset = "0xE09A5C", VA = "0xE09A5C")]
		private void Next()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0xE09B00", Offset = "0xE09B00", VA = "0xE09B00")]
		public static void AddMainThreadCall(Action call)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0xE09B74", Offset = "0xE09B74", VA = "0xE09B74")]
		public static KAsync Start()
		{
			return null;
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0xE09BD8", Offset = "0xE09BD8", VA = "0xE09BD8")]
		public static KAsync Start(Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0xE09D04", Offset = "0xE09D04", VA = "0xE09D04")]
		public static KAsync Start(AsyncThenDelegateEasy callback)
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0xE09C50", Offset = "0xE09C50", VA = "0xE09C50")]
		public KAsync Then(Action callback)
		{
			return null;
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0xE09E48", Offset = "0xE09E48", VA = "0xE09E48")]
		public KAsync Then(AsyncThenDelegate thenFunc)
		{
			return null;
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0xE09F04", Offset = "0xE09F04", VA = "0xE09F04")]
		public KAsync Until(Func<bool> retBool, float timeout = 20f)
		{
			return null;
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0xE09F08", Offset = "0xE09F08", VA = "0xE09F08")]
		public KAsync When(Func<bool> retBool, float timeout = 20f)
		{
			return null;
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0xE09FF8", Offset = "0xE09FF8", VA = "0xE09FF8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13C38", Offset = "0xB13C38")]
		private IEnumerator _CoWhen(Func<bool> retBool, float timeout, Action next)
		{
			return null;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0xE09D7C", Offset = "0xE09D7C", VA = "0xE09D7C")]
		public KAsync Then(AsyncThenDelegateEasy thenFunc)
		{
			return null;
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0xE0A0E4", Offset = "0xE0A0E4", VA = "0xE0A0E4")]
		public KAsync Thread(AsyncThreadDelegate threadCalAction)
		{
			return null;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xE0A314", Offset = "0xE0A314", VA = "0xE0A314")]
		public KAsync Thread(AsyncThreadDelegateFull threadCalAction, object param)
		{
			return null;
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xE0A340", Offset = "0xE0A340", VA = "0xE0A340")]
		public KAsync Thread(Action threadCalAction)
		{
			return null;
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xE0A1B0", Offset = "0xE0A1B0", VA = "0xE0A1B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13C9C", Offset = "0xB13C9C")]
		public IEnumerator _Thread(AsyncThreadDelegateFull threadCalAction, [Optional] object param)
		{
			return null;
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE0A248", Offset = "0xE0A248", VA = "0xE0A248")]
		public KAsync Coroutine(IEnumerator enumtor)
		{
			return null;
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE0A430", Offset = "0xE0A430", VA = "0xE0A430")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13D00", Offset = "0xB13D00")]
		private IEnumerator _StartCoroutine(IEnumerator enumtor, Action next)
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE0A4F4", Offset = "0xE0A4F4", VA = "0xE0A4F4")]
		public KAsync Coroutine(Coroutine co)
		{
			return null;
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0xE0A5C8", Offset = "0xE0A5C8", VA = "0xE0A5C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13D64", Offset = "0xB13D64")]
		private IEnumerator _Coroutine(Coroutine co, Action next)
		{
			return null;
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE0A68C", Offset = "0xE0A68C", VA = "0xE0A68C")]
		public KAsync WaitForFrames(int frameCount)
		{
			return null;
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xE0A760", Offset = "0xE0A760", VA = "0xE0A760")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13DC8", Offset = "0xB13DC8")]
		private IEnumerator _WaitForFrames(int frameCount, Action next)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE0A824", Offset = "0xE0A824", VA = "0xE0A824")]
		public KAsync WaitForSeconds(float time)
		{
			return null;
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE0A8F8", Offset = "0xE0A8F8", VA = "0xE0A8F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13E2C", Offset = "0xB13E2C")]
		private IEnumerator _CoWaitForSeconds(float time, Action next)
		{
			return null;
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE0A9BC", Offset = "0xE0A9BC", VA = "0xE0A9BC")]
		public KAsync WaitForEndOfFrame()
		{
			return null;
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xE0AA38", Offset = "0xE0AA38", VA = "0xE0AA38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13E90", Offset = "0xB13E90")]
		private IEnumerator _WaitForEndOfFrame(Action next)
		{
			return null;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE0AAD8", Offset = "0xE0AAD8", VA = "0xE0AAD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB13EF4", Offset = "0xB13EF4")]
		private void <WaitForEndOfFrame>b__38_0(Action next)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class CCoroutineState
	{
		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool IsOk;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object Param;

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xE05684", Offset = "0xE05684", VA = "0xE05684")]
		public CCoroutineState()
		{
		}
	}
	[Token(Token = "0x200004A")]
	internal class KAsyncManager : KBehaviour
	{
		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static KAsyncManager _instance;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<Action> _mainThreadCallbacks;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly HashSet<Thread> _threads;

		[Token(Token = "0x1700005C")]
		public static KAsyncManager Instance
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0xE09014", Offset = "0xE09014", VA = "0xE09014")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE0D9C4", Offset = "0xE0D9C4", VA = "0xE0D9C4")]
		private void Update()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE0DB10", Offset = "0xE0DB10", VA = "0xE0DB10")]
		private void StopAllThreads()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE0DC4C", Offset = "0xE0DC4C", VA = "0xE0DC4C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0xE0DC50", Offset = "0xE0DC50", VA = "0xE0DC50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE0DC78", Offset = "0xE0DC78", VA = "0xE0DC78")]
		public KAsyncManager()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class KEngineDef
	{
		[Token(Token = "0x4000129")]
		public const string ResourcesBuildDir = "BundleResources";

		[Token(Token = "0x400012A")]
		public const string ResourcesEditDir = "BundleEditing";

		[Token(Token = "0x400012B")]
		public const string ResourcesBuildCacheDir = "_ResourcesCache_";

		[Token(Token = "0x400012C")]
		public const string ResourcesBuildInfosDir = "ResourcesBuildInfos";

		[Token(Token = "0x400012D")]
		public const string RedundaciesDir = "_Redundancies_";

		[Token(Token = "0x6000253")]
		[Address(RVA = "0xE0EB98", Offset = "0xE0EB98", VA = "0xE0EB98")]
		public KEngineDef()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class KObject : IDisposable
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE103F4", Offset = "0xE103F4", VA = "0xE103F4")]
		public KObject()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE103FC", Offset = "0xE103FC", VA = "0xE103FC", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public static class KObjectDebuggerExtensions
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE113D8", Offset = "0xE113D8", VA = "0xE113D8")]
		public static void CreateDebugObject(this object obj)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE1143C", Offset = "0xE1143C", VA = "0xE1143C")]
		public static void RemoveDebugObject(this object obj)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class KObjectDebugger : KBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A68", Offset = "0xB11A68")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object obj;

			[Token(Token = "0x6000848")]
			[Address(RVA = "0xE104EC", Offset = "0xE104EC", VA = "0xE104EC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000849")]
			[Address(RVA = "0xE108E8", Offset = "0xE108E8", VA = "0xE108E8")]
			internal void <RemoveDebugObject>b__0()
			{
			}
		}

		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A78", Offset = "0xB11A78")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public object obj;

			[Token(Token = "0x600084A")]
			[Address(RVA = "0xE105E0", Offset = "0xE105E0", VA = "0xE105E0")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0xE10AC4", Offset = "0xE10AC4", VA = "0xE10AC4")]
			internal void <CreateDebugObject>b__0()
			{
			}
		}

		[Token(Token = "0x2000114")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A88", Offset = "0xB11A88")]
		private sealed class <CoGlobalDebugCoroutine>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Dictionary<object, KObjectDebugger>.Enumerator <>7__wrap1;

			[Token(Token = "0x17000154")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000850")]
				[Address(RVA = "0xE11360", Offset = "0xE11360", VA = "0xE11360", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000155")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000852")]
				[Address(RVA = "0xE113D0", Offset = "0xE113D0", VA = "0xE113D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0xE107B8", Offset = "0xE107B8", VA = "0xE107B8")]
			[DebuggerHidden]
			public <CoGlobalDebugCoroutine>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600084D")]
			[Address(RVA = "0xE10DB4", Offset = "0xE10DB4", VA = "0xE10DB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0xE10E28", Offset = "0xE10E28", VA = "0xE10E28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0xE10DD0", Offset = "0xE10DD0", VA = "0xE10DD0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0xE11368", Offset = "0xE11368", VA = "0xE11368", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<object, KObjectDebugger> Cache;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static IEnumerator GlobalDebugCoroutine;

		[Token(Token = "0x4000130")]
		public const string ContainerName = "KObjectDebugger";

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public object WatchObject;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<string> DebugStrs;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GameObject _cacheGameObject;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE10400", Offset = "0xE10400", VA = "0xE10400")]
		public static void RemoveDebugObject(object obj)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE104F4", Offset = "0xE104F4", VA = "0xE104F4")]
		public static void CreateDebugObject(object obj)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE105E8", Offset = "0xE105E8", VA = "0xE105E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE10758", Offset = "0xE10758", VA = "0xE10758")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13F24", Offset = "0xB13F24")]
		private static IEnumerator CoGlobalDebugCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0xE107E4", Offset = "0xE107E4", VA = "0xE107E4")]
		public KObjectDebugger()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class KProfiler
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool bEnable;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<string, Stopwatch> m_WachterDictionary;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<Stopwatch, long> m_WachterMems;

		[Token(Token = "0x1700005D")]
		public static bool CanWatch
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xE114A0", Offset = "0xE114A0", VA = "0xE114A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0xE11500", Offset = "0xE11500", VA = "0xE11500")]
		public static void BeginWatch(Enum emKey)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0xE11938", Offset = "0xE11938", VA = "0xE11938")]
		public static void EndWatch(Enum emKey)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0xE115B4", Offset = "0xE115B4", VA = "0xE115B4")]
		public static void BeginWatch(string key)
		{
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE119F0", Offset = "0xE119F0", VA = "0xE119F0")]
		public static void EndWatch(string key, [Optional] string name)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE11E44", Offset = "0xE11E44", VA = "0xE11E44")]
		public static void BeginSample(string strName)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE11EA0", Offset = "0xE11EA0", VA = "0xE11EA0")]
		public static void EndSample()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE11EFC", Offset = "0xE11EFC", VA = "0xE11EFC")]
		public KProfiler()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class KTool
	{
		[Token(Token = "0x2000115")]
		public struct FromToNumber
		{
			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float From;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float To;
		}

		[Serializable]
		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11A98", Offset = "0xB11A98")]
		private sealed class <>c
		{
			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static MatchEvaluator <>9__66_0;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0xE19198", Offset = "0xE19198", VA = "0xE19198")]
			public <>c()
			{
			}

			[Token(Token = "0x6000855")]
			[Address(RVA = "0xE191A0", Offset = "0xE191A0", VA = "0xE191A0")]
			internal string <ToSentenceCase>b__66_0(Match m)
			{
				return null;
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AA8", Offset = "0xB11AA8")]
		private sealed class <>c__DisplayClass78_0
		{
			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<IPAddress> callback;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IPAddress ipAddress;

			[Token(Token = "0x6000856")]
			[Address(RVA = "0xE190B0", Offset = "0xE190B0", VA = "0xE190B0")]
			public <>c__DisplayClass78_0()
			{
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0xE192D0", Offset = "0xE192D0", VA = "0xE192D0")]
			internal void <GetIpAddress>b__0(IAsyncResult asyncResult)
			{
			}
		}

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, Shader> CacheShaders;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0xE14908", Offset = "0xE14908", VA = "0xE14908")]
		public static bool IsWifi()
		{
			return default(bool);
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0xE14928", Offset = "0xE14928", VA = "0xE14928")]
		public static int GetNearestPower2(int num)
		{
			return default(int);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0xE149A8", Offset = "0xE149A8", VA = "0xE149A8")]
		public static bool CheckPow2(int num)
		{
			return default(bool);
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xE149D8", Offset = "0xE149D8", VA = "0xE149D8")]
		public static void ResetLocalTransform(Transform t)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xE14B14", Offset = "0xE14B14", VA = "0xE14B14")]
		public static int GetGCD(int a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xE14B4C", Offset = "0xE14B4C", VA = "0xE14B4C")]
		public static Type FindType(string qualifiedTypeName)
		{
			return null;
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xE14CCC", Offset = "0xE14CCC", VA = "0xE14CCC")]
		public static void DestroyGameObjectChildren(GameObject go)
		{
		}

		[Token(Token = "0x600026E")]
		public static string DictToSplitStr<T, K>(Dictionary<T, K> dict, char delimeter1 = '|', char delimeter2 = ':')
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		public static Dictionary<T, K> SplitToDict<T, K>(string str, char delimeter1 = '|', char delimeter2 = ':')
		{
			return null;
		}

		[Token(Token = "0x6000270")]
		public static List<T> Split<T>(string str, params char[] args)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		public static T GetRandomItemFromList<T>(IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xE14E68", Offset = "0xE14E68", VA = "0xE14E68")]
		public static int GetWaveRandomNumberInt(string waveNumberStr)
		{
			return default(int);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xE14F04", Offset = "0xE14F04", VA = "0xE14F04")]
		public static float GetWaveRandomNumber(string waveNumberStr)
		{
			return default(float);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xE15078", Offset = "0xE15078", VA = "0xE15078")]
		public static FromToNumber ParseMinMaxNumber(string str)
		{
			return default(FromToNumber);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xE15208", Offset = "0xE15208", VA = "0xE15208")]
		public static bool IsBetweenWave(string waveNumberStr, int testNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0xE15370", Offset = "0xE15370", VA = "0xE15370")]
		public static bool IsContains(string numberStr, string testValue, char sp = ',')
		{
			return default(bool);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0xE1544C", Offset = "0xE1544C", VA = "0xE1544C")]
		public static Shader FindShader(string shaderName)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0xE15630", Offset = "0xE15630", VA = "0xE15630")]
		public static byte[] StructToBytes(object structObject)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		public static T BytesToStruct<T>(byte[] bytes, int offset = 0)
		{
			return (T)null;
		}

		[Token(Token = "0x600027A")]
		public static T[] StrBytesToArray<T>(string str, int arraySize)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE15714", Offset = "0xE15714", VA = "0xE15714")]
		public static uint MakeDword(ushort high, ushort low)
		{
			return default(uint);
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE15720", Offset = "0xE15720", VA = "0xE15720")]
		public static ushort LoWord(uint low)
		{
			return default(ushort);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE15724", Offset = "0xE15724", VA = "0xE15724")]
		public static ushort HiWord(uint high)
		{
			return default(ushort);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE1572C", Offset = "0xE1572C", VA = "0xE1572C")]
		public static ulong MakeLong(uint high, uint low)
		{
			return default(ulong);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE1573C", Offset = "0xE1573C", VA = "0xE1573C")]
		public static uint HiInt(ulong l)
		{
			return default(uint);
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE15744", Offset = "0xE15744", VA = "0xE15744")]
		public static uint LowInt(ulong l)
		{
			return default(uint);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE15748", Offset = "0xE15748", VA = "0xE15748")]
		public static string HumanizeTimeString(int seconds)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE15ABC", Offset = "0xE15ABC", VA = "0xE15ABC")]
		public static int GetUtcDay()
		{
			return default(int);
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE15B70", Offset = "0xE15B70", VA = "0xE15B70")]
		public static int GetDeltaMinutes(DateTime origin)
		{
			return default(int);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE15C00", Offset = "0xE15C00", VA = "0xE15C00")]
		public static int GetDeltaHours(DateTime origin)
		{
			return default(int);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE15C90", Offset = "0xE15C90", VA = "0xE15C90")]
		public static int GetDeltaDay(DateTime origin)
		{
			return default(int);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE15D20", Offset = "0xE15D20", VA = "0xE15D20")]
		public static DateTime GetDateTimeByUtcMilliseconds(long utcTime, int zone = 0)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xE15D98", Offset = "0xE15D98", VA = "0xE15D98")]
		public static DateTime GetDateTimeByUtcSeconds(double unixTimeStamp, int zone = 0)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE15E18", Offset = "0xE15E18", VA = "0xE15E18")]
		public static double GetUtcMilliseconds()
		{
			return default(double);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE15EA8", Offset = "0xE15EA8", VA = "0xE15EA8")]
		public static double GetUtcMilliseconds(DateTime date)
		{
			return default(double);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE15F60", Offset = "0xE15F60", VA = "0xE15F60")]
		public static double GetUtcSeconds()
		{
			return default(double);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE15FF0", Offset = "0xE15FF0", VA = "0xE15FF0")]
		public static double GetUtcSeconds(DateTime date)
		{
			return default(double);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE160A8", Offset = "0xE160A8", VA = "0xE160A8")]
		public static string HumanizeNumber(int number)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE16220", Offset = "0xE16220", VA = "0xE16220")]
		public static string[] Match(string find, string pattern)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE16430", Offset = "0xE16430", VA = "0xE16430")]
		public static string Format(string source, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE164A4", Offset = "0xE164A4", VA = "0xE164A4")]
		public static string FormatArgs(string source, object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE16AD0", Offset = "0xE16AD0", VA = "0xE16AD0")]
		public static void SetLayer(GameObject go, int layer)
		{
		}

		[Token(Token = "0x6000291")]
		public static T GetChildComponent<T>(Transform findTrans, string uri, bool isLog = true) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		public static T GetChildComponent<T>(string uri, Transform findTrans, bool isLog = true) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE16C04", Offset = "0xE16C04", VA = "0xE16C04")]
		public static GameObject DFSFindObject(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0xE16D60", Offset = "0xE16D60", VA = "0xE16D60")]
		public static GameObject GetGameObject(string name, Transform findTrans, bool isLog = true)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0xE0E36C", Offset = "0xE0E36C", VA = "0xE0E36C")]
		public static void SetChild(GameObject child, GameObject parent, bool selfRotation = false, bool selfScale = false)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0xE0E66C", Offset = "0xE0E66C", VA = "0xE0E66C")]
		public static void SetChild(Transform child, Transform parent, bool selfRotation = false, bool selfScale = false)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0xE16E84", Offset = "0xE16E84", VA = "0xE16E84")]
		public static void ResetTransform(Transform transform, bool selfRotation = false, bool selfScale = false)
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0xE16FF8", Offset = "0xE16FF8", VA = "0xE16FF8")]
		public static string GetRootPathName(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0xE17124", Offset = "0xE17124", VA = "0xE17124")]
		public static string MD5_Stream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0xE171FC", Offset = "0xE171FC", VA = "0xE171FC")]
		public static string MD5_File(string filePath)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0xE17444", Offset = "0xE17444", VA = "0xE17444")]
		public static byte[] MD5_bytes(string str)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0xE174F0", Offset = "0xE174F0", VA = "0xE174F0")]
		public static string MD5_16bit(string str)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		public static T ToEnum<T>(string e)
		{
			return (T)null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0xE175C0", Offset = "0xE175C0", VA = "0xE175C0")]
		public static int IntLerp(int from, int to)
		{
			return default(int);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0xE175D8", Offset = "0xE175D8", VA = "0xE175D8")]
		public static void ScaleParticleSystem(GameObject gameObj, float scale)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0xE178A8", Offset = "0xE178A8", VA = "0xE178A8")]
		public static void SetParticleSystemRenderQueue(Transform parent, int renderQueue = 3900)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xE17BF0", Offset = "0xE17BF0", VA = "0xE17BF0")]
		public static void CopyTransformToTarget(Transform sourceTrans, Transform targetTrans)
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xDFED78", Offset = "0xDFED78", VA = "0xDFED78")]
		public static bool HasWriteAccessToFolder(string folderPath)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xE17CF8", Offset = "0xE17CF8", VA = "0xE17CF8")]
		public static void SetStaticRecursively(GameObject obj)
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xE17EE8", Offset = "0xE17EE8", VA = "0xE17EE8")]
		public static float GetNormalizedAngle(float _anyAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xE17F1C", Offset = "0xE17F1C", VA = "0xE17F1C")]
		public static void AdjustCollidersCenterZ(GameObject gameObj, float z = 0f)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xE1819C", Offset = "0xE1819C", VA = "0xE1819C")]
		public static string ToTitleCase(string word)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xE18288", Offset = "0xE18288", VA = "0xE18288")]
		public static string ToSentenceCase(string str)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xE18440", Offset = "0xE18440", VA = "0xE18440")]
		public static bool Probability(float chancePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xE18478", Offset = "0xE18478", VA = "0xE18478")]
		public static bool Probability(byte chancePercent)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		public static bool ArraysEqual<T>(T[] a1, T[] a2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xE184AC", Offset = "0xE184AC", VA = "0xE184AC")]
		public static Vector3[] GetSmartNpcPoints(Vector3 startDirection, int nNum, Vector3 pAnchorPos, float fAngle, float nRadius)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xE18738", Offset = "0xE18738", VA = "0xE18738")]
		public static Vector3[] GetParallelPoints(Vector3 startPos, Vector3 startDirection, int nNum, float meterInterval)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xE1899C", Offset = "0xE1899C", VA = "0xE1899C")]
		public static bool LineIntersectionPoint(out Vector2 intersectPoint, Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xE18AD0", Offset = "0xE18AD0", VA = "0xE18AD0")]
		public static bool IsNumber(string str)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xE18BB8", Offset = "0xE18BB8", VA = "0xE18BB8")]
		public static Vector2 GetRelativePositionOfEllipse(float 长半轴即目标距离, float 短半轴, float angle)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xE18C70", Offset = "0xE18C70", VA = "0xE18C70")]
		public static float Angle(Vector2 from, Vector2 to)
		{
			return default(float);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xE18DA0", Offset = "0xE18DA0", VA = "0xE18DA0")]
		public static string NumberFormatTo3(long num, string sp = ",")
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xE18E54", Offset = "0xE18E54", VA = "0xE18E54")]
		public static IPAddress GetIpAddressFromIpHostEntry(IPHostEntry ipHostEntry)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xE18F00", Offset = "0xE18F00", VA = "0xE18F00")]
		public static void GetIpAddress(string host, [Optional] Action<IPAddress> callback)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xE190B8", Offset = "0xE190B8", VA = "0xE190B8")]
		public KTool()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB1133C", Offset = "0xB1133C")]
	public class XMemoryParser<T>
	{
		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int MaxCount;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly byte[] SourceBytes;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly GCHandle SourceBytesHandle;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly IntPtr SourceBytesPtr;

		[Token(Token = "0x1700005E")]
		public T Item
		{
			[Token(Token = "0x60002B9")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x60002B6")]
		public XMemoryParser(byte[] bytes, int maxCount)
		{
		}

		[Token(Token = "0x60002B7")]
		public XMemoryParser(IntPtr bytesPtr, int maxCount)
		{
		}

		[Token(Token = "0x60002B8")]
		~XMemoryParser()
		{
		}
	}
}
namespace KEngine.UI
{
	[Token(Token = "0x2000052")]
	public interface IUIBridge
	{
		[Token(Token = "0x60002BA")]
		void InitBridge();

		[Token(Token = "0x60002BB")]
		UIController CreateUIController(GameObject uiObj, string uiTemplateName);

		[Token(Token = "0x60002BC")]
		void UIObjectFilter(UIController controller, GameObject uiObject);

		[Token(Token = "0x60002BD")]
		IEnumerator LoadUIAsset(UILoadState loadState, UILoadRequest request);
	}
	[Token(Token = "0x2000053")]
	public class UILoadRequest
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public UnityEngine.Object Asset;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x11F07CC", Offset = "0x11F07CC", VA = "0x11F07CC")]
		public UILoadRequest()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB11374", Offset = "0xB11374")]
	public class KUIModule : UIModule
	{
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x11EF55C", Offset = "0x11EF55C", VA = "0x11EF55C")]
		public KUIModule()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class UIModule
	{
		[Token(Token = "0x2000118")]
		private class _InstanceClass
		{
			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static UIModule _Instance;

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x11F3148", Offset = "0x11F3148", VA = "0x11F3148")]
			public _InstanceClass()
			{
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AB8", Offset = "0xB11AB8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000677")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIModule <>4__this;

			[Token(Token = "0x4000678")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string instanceName;

			[Token(Token = "0x4000679")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string template;

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x11F13A4", Offset = "0x11F13A4", VA = "0x11F13A4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x11F2704", Offset = "0x11F2704", VA = "0x11F2704")]
			internal void <OpenDynamicWindow>b__0(UIController _ui, object[] _args)
			{
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AC8", Offset = "0xB11AC8")]
		private sealed class <LoadUIAssetBundle>d__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400067A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILoadState openState;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIModule <>4__this;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public KCallback callback;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private UILoadRequest <request>5__2;

			[Token(Token = "0x17000156")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600085F")]
				[Address(RVA = "0x11F30D0", Offset = "0x11F30D0", VA = "0x11F30D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000157")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x11F3140", Offset = "0x11F3140", VA = "0x11F3140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x11F237C", Offset = "0x11F237C", VA = "0x11F237C")]
			[DebuggerHidden]
			public <LoadUIAssetBundle>d__29(int <>1__state)
			{
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x11F29A0", Offset = "0x11F29A0", VA = "0x11F29A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x11F29A4", Offset = "0x11F29A4", VA = "0x11F29A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x11F30D8", Offset = "0x11F30D8", VA = "0x11F30D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AD8", Offset = "0xB11AD8")]
		private sealed class <>c__DisplayClass34_0<T> where T : UIController
		{
			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> callback;

			[Token(Token = "0x6000862")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000863")]
			internal void <CallUI>b__0(T _ui, object[] _args)
			{
			}
		}

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AE8", Offset = "0xB11AE8")]
		private sealed class <>c__DisplayClass35_0<T> where T : UIController
		{
			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T, object[]> callback;

			[Token(Token = "0x6000864")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000865")]
			internal void <CallUI>b__0(UIController _uibase, object[] _args)
			{
			}
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11AF8", Offset = "0xB11AF8")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIController uiBase;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public object[] args;

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x11F26FC", Offset = "0x11F26FC", VA = "0x11F26FC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x11F28C4", Offset = "0x11F28C4", VA = "0x11F28C4")]
			internal void <OnOpen>b__0()
			{
			}
		}

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _loadingUICount;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IUIBridge UiBridge;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, UILoadState> UIWindows;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<UIController> OnInitEvent;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<UIController> OnOpenEvent;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<UIController> OnCloseEvent;

		[Token(Token = "0x1700005F")]
		public static UIModule Instance
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x11F02C0", Offset = "0x11F02C0", VA = "0x11F02C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public int LoadingUICount
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x11F0AE8", Offset = "0x11F0AE8", VA = "0x11F0AE8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x11F0AF0", Offset = "0x11F0AF0", VA = "0x11F0AF0")]
			set
			{
			}
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x11EF560", Offset = "0x11EF560", VA = "0x11EF560")]
		public UIModule()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x11F0328", Offset = "0x11F0328", VA = "0x11F0328")]
		public UILoadState OpenWindow(string uiTemplateName, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60002C5")]
		public void ToggleWindow<T>(params object[] args)
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x11F0FBC", Offset = "0x11F0FBC", VA = "0x11F0FBC")]
		public void ToggleWindow(string name, params object[] args)
		{
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x11F10E8", Offset = "0x11F10E8", VA = "0x11F10E8")]
		public UILoadState OpenDynamicWindow(string template, string instanceName, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x11F153C", Offset = "0x11F153C", VA = "0x11F153C")]
		private void OnDynamicWindowCallback(UIController _ui, object[] _args)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x11F1A38", Offset = "0x11F1A38", VA = "0x11F1A38")]
		public void CloseWindow(Type t)
		{
		}

		[Token(Token = "0x60002CA")]
		public void CloseWindow<T>()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x11F0434", Offset = "0x11F0434", VA = "0x11F0434")]
		public void CloseWindow(string name)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x11F1CDC", Offset = "0x11F1CDC", VA = "0x11F1CDC")]
		public void DestroyAllWindows()
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x11F1FD4", Offset = "0x11F1FD4", VA = "0x11F1FD4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB13F88", Offset = "0xB13F88")]
		public void CloseAllWindows()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x11F13AC", Offset = "0x11F13AC", VA = "0x11F13AC")]
		private UILoadState _GetUIState(string name)
		{
			return null;
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x11F21F0", Offset = "0x11F21F0", VA = "0x11F21F0")]
		private UIController GetUIBase(string name)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		public bool IsOpen<T>() where T : UIController
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x11F1014", Offset = "0x11F1014", VA = "0x11F1014")]
		public bool IsOpen(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x11F1F64", Offset = "0x11F1F64", VA = "0x11F1F64")]
		public bool IsLoad(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x11F0B9C", Offset = "0x11F0B9C", VA = "0x11F0B9C")]
		public UILoadState LoadWindow(string windowTemplateName, bool openWhenFinish, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x11F22D0", Offset = "0x11F22D0", VA = "0x11F22D0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB13FC0", Offset = "0xB13FC0")]
		private IEnumerator LoadUIAssetBundle(string name, UILoadState openState, [Optional] KCallback callback)
		{
			return null;
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x11F23A8", Offset = "0x11F23A8", VA = "0x11F23A8")]
		public Coroutine ReloadWindow(string windowTemplateName, KCallback callback)
		{
			return null;
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x11F1A9C", Offset = "0x11F1A9C", VA = "0x11F1A9C")]
		public void DestroyWindow(string uiTemplateName)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x11F142C", Offset = "0x11F142C", VA = "0x11F142C")]
		public void CallUI(string uiTemplateName, Action<UIController, object[]> callback, params object[] args)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x11F2560", Offset = "0x11F2560", VA = "0x11F2560")]
		public void CallDynamicUI(string uiName, Action<UIController, object[]> callback, params object[] args)
		{
		}

		[Token(Token = "0x60002D9")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB14024", Offset = "0xB14024")]
		public void CallUI<T>(Action<T> callback) where T : UIController
		{
		}

		[Token(Token = "0x60002DA")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB1405C", Offset = "0xB1405C")]
		public void CallUI<T>(Action<T, object[]> callback, params object[] args) where T : UIController
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x11F0E08", Offset = "0x11F0E08", VA = "0x11F0E08")]
		private void OnOpen(UILoadState uiState, params object[] args)
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x11F1910", Offset = "0x11F1910", VA = "0x11F1910")]
		private void InitWindow(UILoadState uiState, UIController uiBase, bool open, params object[] args)
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class UILoadState
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string TemplateName;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string InstanceName;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UIController UIWindow;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Type UIType;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsLoading;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool IsStaticUI;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool OpenWhenFinish;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object[] OpenArgs;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		internal Queue<Action<UIController, object[]>> CallbacksWhenFinish;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		internal Queue<object[]> CallbacksArgsWhenFinish;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AbstractResourceLoader UIResourceLoader;

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x11F07D4", Offset = "0x11F07D4", VA = "0x11F07D4")]
		public UILoadState(string uiTemplateName, string uiInstanceName, [Optional] Type uiControllerType)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x11F090C", Offset = "0x11F090C", VA = "0x11F090C")]
		public void DoCallback(Action<UIController, object[]> callback, [Optional] object[] args)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x11F0A04", Offset = "0x11F0A04", VA = "0x11F0A04")]
		internal void OnUIWindowLoadedCallbacks(UILoadState uiState, UIController uiObject)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class UGUIBridge : IUIBridge
	{
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B08", Offset = "0xB11B08")]
		private sealed class <LoadUIAsset>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UILoadState loadState;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UILoadRequest request;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private StaticAssetLoader <assetLoader>5__2;

			[Token(Token = "0x17000158")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600086B")]
				[Address(RVA = "0x11EFCDC", Offset = "0x11EFCDC", VA = "0x11EFCDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000159")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086D")]
				[Address(RVA = "0x11EFD4C", Offset = "0x11EFD4C", VA = "0x11EFD4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x11EFB78", Offset = "0x11EFB78", VA = "0x11EFB78")]
			[DebuggerHidden]
			public <LoadUIAsset>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x11EFBAC", Offset = "0x11EFBAC", VA = "0x11EFBAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x11EFBB0", Offset = "0x11EFBB0", VA = "0x11EFBB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x11EFCE4", Offset = "0x11EFCE4", VA = "0x11EFCE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public EventSystem EventSystem;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x11EF88C", Offset = "0x11EF88C", VA = "0x11EF88C", Slot = "4")]
		public void InitBridge()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x11EF94C", Offset = "0x11EF94C", VA = "0x11EF94C", Slot = "5")]
		public UIController CreateUIController(GameObject uiObj, string uiTemplateName)
		{
			return null;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x11EFADC", Offset = "0x11EFADC", VA = "0x11EFADC", Slot = "6")]
		public void UIObjectFilter(UIController ui, GameObject uiObject)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x11EFAE0", Offset = "0x11EFAE0", VA = "0x11EFAE0", Slot = "7")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB14094", Offset = "0xB14094")]
		public IEnumerator LoadUIAsset(UILoadState loadState, UILoadRequest request)
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x11EFBA4", Offset = "0x11EFBA4", VA = "0x11EFBA4")]
		public UGUIBridge()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class UIController : KBehaviour
	{
		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string UITemplateName;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string UIName;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x11EFD54", Offset = "0x11EFD54", VA = "0x11EFD54", Slot = "10")]
		public virtual void OnInit()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x11EFD58", Offset = "0x11EFD58", VA = "0x11EFD58", Slot = "11")]
		public virtual void BeforeOpen(object[] onOpenArgs, Action doOpen)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x11EFD88", Offset = "0x11EFD88", VA = "0x11EFD88", Slot = "12")]
		public virtual void OnOpen(params object[] args)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x11EFD8C", Offset = "0x11EFD8C", VA = "0x11EFD8C", Slot = "13")]
		public virtual void OnClose()
		{
		}

		[Token(Token = "0x60002E9")]
		public T GetControl<T>(string uri, [Optional] Transform findTrans, bool isLog = true) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x11EFD90", Offset = "0x11EFD90", VA = "0x11EFD90")]
		public object GetControl(Type type, string uri, [Optional] Transform findTrans, bool isLog = true)
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		public T FindControl<T>(string name) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x11EFFC0", Offset = "0x11EFFC0", VA = "0x11EFFC0")]
		public GameObject FindGameObject(string name)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x11F00D0", Offset = "0x11F00D0", VA = "0x11F00D0")]
		public GameObject DFSFindObject(Transform parent, string name)
		{
			return null;
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x11F0214", Offset = "0x11F0214", VA = "0x11F0214")]
		public void DestroyGameObjectChildren(GameObject go)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x11F027C", Offset = "0x11F027C", VA = "0x11F027C")]
		protected void OpenWindow(string uiName, params object[] args)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x11F03E0", Offset = "0x11F03E0", VA = "0x11F03E0")]
		protected void CloseWindow([Optional] string uiName)
		{
		}

		[Token(Token = "0x60002F1")]
		protected T GetFromArgs<T>(object[] openArgs, int offset, bool isLog = true)
		{
			return (T)null;
		}

		[Token(Token = "0x60002F2")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB140F8", Offset = "0xB140F8")]
		public static void CallUI<T>(Action<T> callback) where T : UIController
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x11F0754", Offset = "0x11F0754", VA = "0x11F0754")]
		public UIController()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB113AC", Offset = "0xB113AC")]
	public class UIWindowAsset : MonoBehaviour
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string StringArgument;

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x11F31B8", Offset = "0x11F31B8", VA = "0x11F31B8")]
		public UIWindowAsset()
		{
		}
	}
}
namespace KEngine.Modules
{
	[Token(Token = "0x200005A")]
	public interface IReloadableSettings
	{
		[Token(Token = "0x17000061")]
		int Count
		{
			[Token(Token = "0x60002F6")]
			get;
		}

		[Token(Token = "0x60002F5")]
		void ReloadAll();
	}
	[Token(Token = "0x200005B")]
	public abstract class SettingModuleBase
	{
		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<string, object> _tableFilesCache;

		[Token(Token = "0x60002F7")]
		protected abstract string LoadSetting(string path);

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x11E8E04", Offset = "0x11E8E04", VA = "0x11E8E04")]
		public TableFile GetTableFile(string path, bool useCache = false)
		{
			return null;
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x11E8C54", Offset = "0x11E8C54", VA = "0x11E8C54")]
		protected SettingModuleBase()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class SettingModule : SettingModuleBase
	{
		[Token(Token = "0x200011F")]
		public delegate byte[] LoadSettingFuncDelegate(string filePath);

		[Token(Token = "0x2000120")]
		public delegate byte[] SettingBytesFilterDelegate(byte[] bytes);

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SettingBytesFilterDelegate SettingBytesFilter;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static LoadSettingFuncDelegate CustomLoadSetting;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly bool IsEditor;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static SettingModule _instance;

		[Token(Token = "0x17000062")]
		protected static string SettingFolderName
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x11E8CC4", Offset = "0x11E8CC4", VA = "0x11E8CC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public static bool IsFileSystemMode
		{
			[Token(Token = "0x6000301")]
			[Address(RVA = "0x11E99C8", Offset = "0x11E99C8", VA = "0x11E99C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x11E8BF4", Offset = "0x11E8BF4", VA = "0x11E8BF4")]
		static SettingModule()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x11E8C50", Offset = "0x11E8C50", VA = "0x11E8C50")]
		internal SettingModule()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x11E8D20", Offset = "0x11E8D20", VA = "0x11E8D20")]
		public static TableFile Get(string path, bool useCache = true)
		{
			return null;
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x11E8FA0", Offset = "0x11E8FA0", VA = "0x11E8FA0", Slot = "4")]
		protected override string LoadSetting(string path)
		{
			return null;
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x11E9094", Offset = "0x11E9094", VA = "0x11E9094")]
		public static byte[] DefaultLoadSetting(string path)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x11E9930", Offset = "0x11E9930", VA = "0x11E9930")]
		private static string GetFileSystemPath(string path)
		{
			return null;
		}
	}
}
namespace KEngine.Table
{
	[Token(Token = "0x200005D")]
	public class TabFileWriter : IDisposable
	{
		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly TableFile TabFile;

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x11ECA90", Offset = "0x11ECA90", VA = "0x11ECA90")]
		public TabFileWriter()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x11ECB48", Offset = "0x11ECB48", VA = "0x11ECB48")]
		public TabFileWriter(TableFile tabFile)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x11ECB74", Offset = "0x11ECB74", VA = "0x11ECB74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x11ED100", Offset = "0x11ED100", VA = "0x11ED100")]
		public bool Save(string fileName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x11ED4B4", Offset = "0x11ED4B4", VA = "0x11ED4B4")]
		public TableRow NewRow()
		{
			return null;
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x11ED5F4", Offset = "0x11ED5F4", VA = "0x11ED5F4")]
		public bool RemoveRow(int row)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x11ED674", Offset = "0x11ED674", VA = "0x11ED674")]
		public TableRow GetRow(int row)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x11ED70C", Offset = "0x11ED70C", VA = "0x11ED70C")]
		public int NewColumn(string colName)
		{
			return default(int);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x11ED76C", Offset = "0x11ED76C", VA = "0x11ED76C")]
		public int NewColumn(string colName, string defineStr)
		{
			return default(int);
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x11ED940", Offset = "0x11ED940", VA = "0x11ED940", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public enum TableFileExceptionType
	{
		[Token(Token = "0x4000159")]
		DuplicatedKey,
		[Token(Token = "0x400015A")]
		HeadLineNull,
		[Token(Token = "0x400015B")]
		MetaLineNull,
		[Token(Token = "0x400015C")]
		NotFoundHeader,
		[Token(Token = "0x400015D")]
		NotFoundGetMethod,
		[Token(Token = "0x400015E")]
		NotFoundPrimaryKey,
		[Token(Token = "0x400015F")]
		NotFoundRow
	}
	[Token(Token = "0x200005F")]
	public class HeaderInfo
	{
		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ColumnIndex;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string HeaderName;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string HeaderMeta;

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x11ECA88", Offset = "0x11ECA88", VA = "0x11ECA88")]
		public HeaderInfo()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public delegate void TableFileExceptionDelegate(TableFileExceptionType exceptionType, string[] args);
	[Token(Token = "0x2000061")]
	public class TableFileStaticConfig
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TableFileExceptionDelegate GlobalExceptionEvent;

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x11EE0E0", Offset = "0x11EE0E0", VA = "0x11EE0E0")]
		public TableFileStaticConfig()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class TableFileConfig
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Content;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public char[] Separators;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TableFileExceptionDelegate OnExceptionEvent;

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x11EDB38", Offset = "0x11EDB38", VA = "0x11EDB38")]
		public TableFileConfig()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class TableFile : TableFile<TableRow>
	{
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x11ED9A0", Offset = "0x11ED9A0", VA = "0x11ED9A0")]
		public TableFile(string content)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x11ECAF8", Offset = "0x11ECAF8", VA = "0x11ECAF8")]
		public TableFile()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x11EDA00", Offset = "0x11EDA00", VA = "0x11EDA00")]
		public TableFile(string fileFullPath, Encoding encoding)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x11EDA68", Offset = "0x11EDA68", VA = "0x11EDA68")]
		public new static TableFile LoadFromString(string content)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x11EDAC8", Offset = "0x11EDAC8", VA = "0x11EDAC8")]
		public new static TableFile LoadFromFile(string fileFullPath, [Optional] Encoding encoding)
		{
			return null;
		}
	}
	[Token(Token = "0x2000064")]
	public class TableFile<T> : IDisposable, IEnumerable<TableRow>, IEnumerable where T : TableRow
	{
		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly TableFileConfig _config;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal int _colCount;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly Dictionary<string, HeaderInfo> Headers;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal Dictionary<int, string[]> TabInfo;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected internal Dictionary<int, TableRow> Rows;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected Dictionary<object, TableRow> PrimaryKey2Row;

		[Token(Token = "0x17000064")]
		public Dictionary<string, HeaderInfo>.KeyCollection HeaderNames
		{
			[Token(Token = "0x600031C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		internal FieldInfo[] AutoTabFields
		{
			[Token(Token = "0x6000320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000318")]
		public TableFile(string content)
		{
		}

		[Token(Token = "0x6000319")]
		public TableFile()
		{
		}

		[Token(Token = "0x600031A")]
		public TableFile(TableFileConfig config)
		{
		}

		[Token(Token = "0x600031B")]
		public TableFile(string fileFullPath, Encoding encoding)
		{
		}

		[Token(Token = "0x600031D")]
		public static TableFile<T> LoadFromString(string content)
		{
			return null;
		}

		[Token(Token = "0x600031E")]
		public static TableFile<T> LoadFromFile(string fileFullPath, [Optional] Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		protected bool ParseReader(TextReader oReader)
		{
			return default(bool);
		}

		[Token(Token = "0x6000321")]
		protected void AutoParse(TableRow tableRow, string[] cellStrs)
		{
		}

		[Token(Token = "0x6000322")]
		protected bool ParseString(string content)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		public bool HasColumn(string colName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		protected internal void OnException(TableFileExceptionType message, params string[] args)
		{
		}

		[Token(Token = "0x6000325")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xB14130", Offset = "0xB14130")]
		public int GetHeight()
		{
			return default(int);
		}

		[Token(Token = "0x6000326")]
		public int GetRowCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000327")]
		public int GetColumnCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000328")]
		public int GetWidth()
		{
			return default(int);
		}

		[Token(Token = "0x6000329")]
		public T GetRow(int row)
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600032B")]
		public void Close()
		{
		}

		[Token(Token = "0x600032C")]
		public bool HasPrimaryKey(object primaryKey)
		{
			return default(bool);
		}

		[Token(Token = "0x600032D")]
		public T FindByPrimaryKey(object primaryKey, bool throwError = true)
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		public T GetByPrimaryKey(object primaryKey)
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		public IEnumerable<TableRow> GetAll()
		{
			return null;
		}

		[Token(Token = "0x6000330")]
		public IEnumerator<TableRow> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000331")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000065")]
	public class TableRowParser
	{
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x11EE574", Offset = "0x11EE574", VA = "0x11EE574")]
		public string Get_String(string value, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11EE5A8", Offset = "0x11EE5A8", VA = "0x11EE5A8")]
		public string Get_string(string value, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11EE5DC", Offset = "0x11EE5DC", VA = "0x11EE5DC")]
		public int Get_Int32(string value, string defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11EE63C", Offset = "0x11EE63C", VA = "0x11EE63C")]
		public bool Get_bool(string value, string defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x11EE640", Offset = "0x11EE640", VA = "0x11EE640")]
		public bool Get_Boolean(string value, string defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11EE5E0", Offset = "0x11EE5E0", VA = "0x11EE5E0")]
		public int Get_int(string value, string defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x11EE6FC", Offset = "0x11EE6FC", VA = "0x11EE6FC")]
		public double Get_double(string value, string defaultValue)
		{
			return default(double);
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x11EE7A8", Offset = "0x11EE7A8", VA = "0x11EE7A8")]
		public float Get_float(string value, string defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11EE804", Offset = "0x11EE804", VA = "0x11EE804")]
		public uint Get_uint(string value, string defaultValue)
		{
			return default(uint);
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x11EE860", Offset = "0x11EE860", VA = "0x11EE860")]
		public string[] Get_string_array(string value, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x11EE91C", Offset = "0x11EE91C", VA = "0x11EE91C")]
		public Dictionary<string, int> Get_Dictionary_string_int(string value, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600033D")]
		protected Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(string value, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		protected T ConvertString<T>(string value)
		{
			return (T)null;
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x11EE100", Offset = "0x11EE100", VA = "0x11EE100")]
		public TableRowParser()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xB113E4", Offset = "0xB113E4")]
	public class TableRow : TableRowParser
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11FF0", Offset = "0xB11FF0")]
		private int <RowNumber>k__BackingField;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12000", Offset = "0xB12000")]
		private Dictionary<string, HeaderInfo> <HeaderInfos>k__BackingField;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12010", Offset = "0xB12010")]
		private string[] <Values>k__BackingField;

		[Token(Token = "0x17000066")]
		public int RowNumber
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x11EE0E8", Offset = "0x11EE0E8", VA = "0x11EE0E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14168", Offset = "0xB14168")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x11EE0F0", Offset = "0x11EE0F0", VA = "0x11EE0F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14178", Offset = "0xB14178")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000067")]
		public virtual bool IsAutoParse
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x11EE0F8", Offset = "0x11EE0F8", VA = "0x11EE0F8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public Dictionary<string, HeaderInfo> HeaderInfos
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x11EE1AC", Offset = "0x11EE1AC", VA = "0x11EE1AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14188", Offset = "0xB14188")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x11EE19C", Offset = "0x11EE19C", VA = "0x11EE19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14198", Offset = "0xB14198")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public string[] Values
		{
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x11ED0F8", Offset = "0x11ED0F8", VA = "0x11ED0F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB141A8", Offset = "0xB141A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x11EE1A4", Offset = "0x11EE1A4", VA = "0x11EE1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB141B8", Offset = "0xB141B8")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700006A")]
		public virtual string PrimaryKey
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x11EE1B8", Offset = "0x11EE1B8", VA = "0x11EE1B8", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006B")]
		public string Item
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x11EE1C0", Offset = "0x11EE1C0", VA = "0x11EE1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x11EE3DC", Offset = "0x11EE3DC", VA = "0x11EE3DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public string Item
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x11EE2E4", Offset = "0x11EE2E4", VA = "0x11EE2E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x11EE46C", Offset = "0x11EE46C", VA = "0x11EE46C")]
			set
			{
			}
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x11ED5B4", Offset = "0x11ED5B4", VA = "0x11ED5B4")]
		public TableRow(int rowNumber, Dictionary<string, HeaderInfo> headerInfos)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x11EE108", Offset = "0x11EE108", VA = "0x11EE108")]
		private void Ctor(int rowNumber, Dictionary<string, HeaderInfo> headerInfos)
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x11EE1B4", Offset = "0x11EE1B4", VA = "0x11EE1B4", Slot = "5")]
		public virtual void Parse(string[] cellStrs)
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x11EE2DC", Offset = "0x11EE2DC", VA = "0x11EE2DC")]
		public string Get(int index)
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x11EE2E0", Offset = "0x11EE2E0", VA = "0x11EE2E0")]
		public string Get(string headerName)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB1141C", Offset = "0xB1141C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB1141C", Offset = "0xB1141C")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12030", Offset = "0xB12030")]
		public bool FollowCaller;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12068", Offset = "0xB12068")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB120A0", Offset = "0xB120A0")]
		public Transform RuntimeFollower;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x1700006D")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0xC7122C", Offset = "0xC7122C", VA = "0xC7122C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public Transform Trans
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xC719FC", Offset = "0xC719FC", VA = "0xC719FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xC70E40", Offset = "0xC70E40", VA = "0xC70E40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xC710BC", Offset = "0xC710BC", VA = "0xC710BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xC715F8", Offset = "0xC715F8", VA = "0xC715F8")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xC71EE4", Offset = "0xC71EE4", VA = "0xC71EE4")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xC71FD4", Offset = "0xC71FD4", VA = "0xC71FD4")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xC7240C", Offset = "0xC7240C", VA = "0xC7240C")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xC7263C", Offset = "0xC7263C", VA = "0xC7263C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xC728B0", Offset = "0xC728B0", VA = "0xC728B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xC72B24", Offset = "0xC72B24", VA = "0xC72B24")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xC72F80", Offset = "0xC72F80", VA = "0xC72F80")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB1146C", Offset = "0xB1146C")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x4000181")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xC7A938", Offset = "0xC7A938", VA = "0xC7A938")]
		private void Awake()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xC7AC8C", Offset = "0xC7AC8C", VA = "0xC7AC8C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xC7B238", Offset = "0xC7B238", VA = "0xC7B238")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xC7B2D4", Offset = "0xC7B2D4", VA = "0xC7B2D4")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xC7B6A8", Offset = "0xC7B6A8", VA = "0xC7B6A8")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB114A4", Offset = "0xB114A4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB114A4", Offset = "0xB114A4")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000121")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x400068A")]
			Legacy,
			[Token(Token = "0x400068B")]
			uGUI
		}

		[Token(Token = "0x2000122")]
		public enum EventType
		{
			[Token(Token = "0x400068D")]
			OnStart,
			[Token(Token = "0x400068E")]
			OnVisible,
			[Token(Token = "0x400068F")]
			OnInvisible,
			[Token(Token = "0x4000690")]
			OnCollision,
			[Token(Token = "0x4000691")]
			OnTriggerEnter,
			[Token(Token = "0x4000692")]
			OnTriggerExit,
			[Token(Token = "0x4000693")]
			OnMouseEnter,
			[Token(Token = "0x4000694")]
			OnMouseClick,
			[Token(Token = "0x4000695")]
			OnSpawned,
			[Token(Token = "0x4000696")]
			OnDespawned,
			[Token(Token = "0x4000697")]
			OnEnable,
			[Token(Token = "0x4000698")]
			OnDisable,
			[Token(Token = "0x4000699")]
			OnCollision2D,
			[Token(Token = "0x400069A")]
			OnTriggerEnter2D,
			[Token(Token = "0x400069B")]
			OnTriggerExit2D,
			[Token(Token = "0x400069C")]
			OnParticleCollision,
			[Token(Token = "0x400069D")]
			UserDefinedEvent,
			[Token(Token = "0x400069E")]
			OnCollisionExit,
			[Token(Token = "0x400069F")]
			OnCollisionExit2D,
			[Token(Token = "0x40006A0")]
			OnMouseUp,
			[Token(Token = "0x40006A1")]
			OnMouseExit,
			[Token(Token = "0x40006A2")]
			OnMouseDrag,
			[Token(Token = "0x40006A3")]
			NGUIOnClick,
			[Token(Token = "0x40006A4")]
			NGUIMouseDown,
			[Token(Token = "0x40006A5")]
			NGUIMouseUp,
			[Token(Token = "0x40006A6")]
			NGUIMouseEnter,
			[Token(Token = "0x40006A7")]
			NGUIMouseExit,
			[Token(Token = "0x40006A8")]
			MechanimStateChanged,
			[Token(Token = "0x40006A9")]
			UnitySliderChanged,
			[Token(Token = "0x40006AA")]
			UnityButtonClicked,
			[Token(Token = "0x40006AB")]
			UnityPointerDown,
			[Token(Token = "0x40006AC")]
			UnityPointerUp,
			[Token(Token = "0x40006AD")]
			UnityPointerEnter,
			[Token(Token = "0x40006AE")]
			UnityPointerExit,
			[Token(Token = "0x40006AF")]
			UnityDrag,
			[Token(Token = "0x40006B0")]
			UnityDrop,
			[Token(Token = "0x40006B1")]
			UnityScroll,
			[Token(Token = "0x40006B2")]
			UnityUpdateSelected,
			[Token(Token = "0x40006B3")]
			UnitySelect,
			[Token(Token = "0x40006B4")]
			UnityDeselect,
			[Token(Token = "0x40006B5")]
			UnityMove,
			[Token(Token = "0x40006B6")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40006B7")]
			UnityBeginDrag,
			[Token(Token = "0x40006B8")]
			UnityEndDrag,
			[Token(Token = "0x40006B9")]
			UnitySubmit,
			[Token(Token = "0x40006BA")]
			UnityCancel,
			[Token(Token = "0x40006BB")]
			UnityToggle,
			[Token(Token = "0x40006BC")]
			OnTriggerStay,
			[Token(Token = "0x40006BD")]
			OnTriggerStay2D
		}

		[Token(Token = "0x2000123")]
		public enum GlidePitchType
		{
			[Token(Token = "0x40006BF")]
			None,
			[Token(Token = "0x40006C0")]
			RaisePitch,
			[Token(Token = "0x40006C1")]
			LowerPitch
		}

		[Token(Token = "0x2000124")]
		public enum VariationType
		{
			[Token(Token = "0x40006C3")]
			PlaySpecific,
			[Token(Token = "0x40006C4")]
			PlayRandom
		}

		[Token(Token = "0x2000125")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40006C6")]
			None,
			[Token(Token = "0x40006C7")]
			Stop,
			[Token(Token = "0x40006C8")]
			FadeOut
		}

		[Token(Token = "0x2000126")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40006CA")]
			None,
			[Token(Token = "0x40006CB")]
			FrameBased,
			[Token(Token = "0x40006CC")]
			TimeBased
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B18", Offset = "0xB11B18")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x1700015A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000879")]
				[Address(RVA = "0xC90BA0", Offset = "0xC90BA0", VA = "0xC90BA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087B")]
				[Address(RVA = "0xC90C10", Offset = "0xC90C10", VA = "0xC90C10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0xC81730", Offset = "0xC81730", VA = "0xC81730")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0xC909C8", Offset = "0xC909C8", VA = "0xC909C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0xC909CC", Offset = "0xC909CC", VA = "0xC909CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087A")]
			[Address(RVA = "0xC90BA8", Offset = "0xC90BA8", VA = "0xC90BA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B28", Offset = "0xB11B28")]
		private sealed class <>c__DisplayClass165_0
		{
			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x600087C")]
			[Address(RVA = "0xC83368", Offset = "0xC83368", VA = "0xC83368")]
			public <>c__DisplayClass165_0()
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0xC90990", Offset = "0xC90990", VA = "0xC90990")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x1700006F")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000382")]
			[Address(RVA = "0xC81378", Offset = "0xC81378", VA = "0xC81378")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xC82C70", Offset = "0xC82C70", VA = "0xC82C70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xC812AC", Offset = "0xC812AC", VA = "0xC812AC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xC81544", Offset = "0xC81544", VA = "0xC81544", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xC816BC", Offset = "0xC816BC", VA = "0xC816BC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB141C8", Offset = "0xB141C8")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xC8175C", Offset = "0xC8175C", VA = "0xC8175C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xC81DE0", Offset = "0xC81DE0", VA = "0xC81DE0")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xC81E08", Offset = "0xC81E08", VA = "0xC81E08")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xC81E24", Offset = "0xC81E24", VA = "0xC81E24")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xC820B8", Offset = "0xC820B8", VA = "0xC820B8")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xC824B4", Offset = "0xC824B4", VA = "0xC824B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xC82854", Offset = "0xC82854", VA = "0xC82854")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xC829D4", Offset = "0xC829D4", VA = "0xC829D4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xC829F4", Offset = "0xC829F4", VA = "0xC829F4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xC82A14", Offset = "0xC82A14", VA = "0xC82A14")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xC82A34", Offset = "0xC82A34", VA = "0xC82A34")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0xC82A54", Offset = "0xC82A54", VA = "0xC82A54")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0xC82A58", Offset = "0xC82A58", VA = "0xC82A58")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xC82A78", Offset = "0xC82A78", VA = "0xC82A78")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xC82A7C", Offset = "0xC82A7C", VA = "0xC82A7C")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xC82A9C", Offset = "0xC82A9C", VA = "0xC82A9C")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0xC82ABC", Offset = "0xC82ABC", VA = "0xC82ABC")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0xC82ADC", Offset = "0xC82ADC", VA = "0xC82ADC")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xC82AE0", Offset = "0xC82AE0", VA = "0xC82AE0")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xC82B00", Offset = "0xC82B00", VA = "0xC82B00")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xC82B20", Offset = "0xC82B20", VA = "0xC82B20")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xC82B40", Offset = "0xC82B40", VA = "0xC82B40")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xC82B60", Offset = "0xC82B60", VA = "0xC82B60")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xC82B80", Offset = "0xC82B80", VA = "0xC82B80")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xC82BA0", Offset = "0xC82BA0", VA = "0xC82BA0")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xC82BC0", Offset = "0xC82BC0", VA = "0xC82BC0")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xC82BE0", Offset = "0xC82BE0", VA = "0xC82BE0")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xC82C40", Offset = "0xC82C40", VA = "0xC82C40")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0xC82C58", Offset = "0xC82C58", VA = "0xC82C58")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0xC82C80", Offset = "0xC82C80", VA = "0xC82C80")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0xC82CB8", Offset = "0xC82CB8", VA = "0xC82CB8")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0xC82CD8", Offset = "0xC82CD8", VA = "0xC82CD8")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0xC82D10", Offset = "0xC82D10", VA = "0xC82D10")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xC82D60", Offset = "0xC82D60", VA = "0xC82D60")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0xC82D80", Offset = "0xC82D80", VA = "0xC82D80")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0xC82E44", Offset = "0xC82E44", VA = "0xC82E44")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0xC8305C", Offset = "0xC8305C", VA = "0xC8305C")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0xC83298", Offset = "0xC83298", VA = "0xC83298")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0xC81BC8", Offset = "0xC81BC8", VA = "0xC81BC8")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xC85F98", Offset = "0xC85F98", VA = "0xC85F98")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0xC861B0", Offset = "0xC861B0", VA = "0xC861B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0xC83370", Offset = "0xC83370", VA = "0xC83370")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0xC834E0", Offset = "0xC834E0", VA = "0xC834E0")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0xC8F268", Offset = "0xC8F268", VA = "0xC8F268")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0xC8179C", Offset = "0xC8179C", VA = "0xC8179C", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0xC8F700", Offset = "0xC8F700", VA = "0xC8F700", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xC8F814", Offset = "0xC8F814", VA = "0xC8F814", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xC82410", Offset = "0xC82410", VA = "0xC82410", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xC827B8", Offset = "0xC827B8", VA = "0xC827B8", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xC901F4", Offset = "0xC901F4", VA = "0xC901F4", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xC81388", Offset = "0xC81388", VA = "0xC81388")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x600039A")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xC90254", Offset = "0xC90254", VA = "0xC90254")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB120D8", Offset = "0xB120D8")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x17000071")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0xC90CC8", Offset = "0xC90CC8", VA = "0xC90CC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1422C", Offset = "0xB1422C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600039E")]
			[Address(RVA = "0xC916F0", Offset = "0xC916F0", VA = "0xC916F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1423C", Offset = "0xB1423C")]
			set
			{
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xC90CD8", Offset = "0xC90CD8", VA = "0xC90CD8")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xC912A0", Offset = "0xC912A0", VA = "0xC912A0", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xC91350", Offset = "0xC91350", VA = "0xC91350")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xC91358", Offset = "0xC91358", VA = "0xC91358", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xC91408", Offset = "0xC91408", VA = "0xC91408")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xC911E8", Offset = "0xC911E8", VA = "0xC911E8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xC91298", Offset = "0xC91298", VA = "0xC91298")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xC91410", Offset = "0xC91410", VA = "0xC91410", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xC914C0", Offset = "0xC914C0", VA = "0xC914C0")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xC90E50", Offset = "0xC90E50", VA = "0xC90E50", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xC90F00", Offset = "0xC90F00", VA = "0xC90F00")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xC90F08", Offset = "0xC90F08", VA = "0xC90F08", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xC90FB8", Offset = "0xC90FB8", VA = "0xC90FB8")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xC914C8", Offset = "0xC914C8", VA = "0xC914C8", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xC91578", Offset = "0xC91578", VA = "0xC91578")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xC916F8", Offset = "0xC916F8", VA = "0xC916F8", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xC917A8", Offset = "0xC917A8", VA = "0xC917A8")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xC91580", Offset = "0xC91580", VA = "0xC91580", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xC91630", Offset = "0xC91630", VA = "0xC91630")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xC90D98", Offset = "0xC90D98", VA = "0xC90D98", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xC90E48", Offset = "0xC90E48", VA = "0xC90E48")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xC91130", Offset = "0xC91130", VA = "0xC91130", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xC911E0", Offset = "0xC911E0", VA = "0xC911E0")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xC91078", Offset = "0xC91078", VA = "0xC91078", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xC91128", Offset = "0xC91128", VA = "0xC91128")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xC90C18", Offset = "0xC90C18", VA = "0xC90C18", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xC90CD0", Offset = "0xC90CD0", VA = "0xC90CD0")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xC90FC0", Offset = "0xC90FC0", VA = "0xC90FC0", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xC91070", Offset = "0xC91070", VA = "0xC91070")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xC91638", Offset = "0xC91638", VA = "0xC91638", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xC916E8", Offset = "0xC916E8", VA = "0xC916E8")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xC90CE0", Offset = "0xC90CE0", VA = "0xC90CE0", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xC90D90", Offset = "0xC90D90", VA = "0xC90D90")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB114F4", Offset = "0xB114F4")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x2000129")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x40006D2")]
			None,
			[Token(Token = "0x40006D3")]
			OnCollision,
			[Token(Token = "0x40006D4")]
			OnTriggerEnter,
			[Token(Token = "0x40006D5")]
			OnCollision2D,
			[Token(Token = "0x40006D6")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x17000072")]
		private Transform Trans
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xC954B0", Offset = "0xC954B0", VA = "0xC954B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xC950E0", Offset = "0xC950E0", VA = "0xC950E0")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xC95170", Offset = "0xC95170", VA = "0xC95170")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xC95540", Offset = "0xC95540", VA = "0xC95540")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB120E8", Offset = "0xB120E8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB120E8", Offset = "0xB120E8")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12148", Offset = "0xB12148")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB12148", Offset = "0xB12148")]
		public bool fireEnterEvent;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB121B8", Offset = "0xB121B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB121B8", Offset = "0xB121B8")]
		public bool fireExitEvent;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12228", Offset = "0xB12228")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB12228", Offset = "0xB12228")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12288", Offset = "0xB12288")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12288", Offset = "0xB12288")]
		public float whenToFireEvent;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB122EC", Offset = "0xB122EC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB122EC", Offset = "0xB122EC")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB1234C", Offset = "0xB1234C")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12364", Offset = "0xB12364")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12364", Offset = "0xB12364")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB123B8", Offset = "0xB123B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB123B8", Offset = "0xB123B8")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB1240C", Offset = "0xB1240C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB1240C", Offset = "0xB1240C")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12460", Offset = "0xB12460")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12460", Offset = "0xB12460")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xE3F374", Offset = "0xE3F374", VA = "0xE3F374", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xE3F4F8", Offset = "0xE3F4F8", VA = "0xE3F4F8", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE3F80C", Offset = "0xE3F80C", VA = "0xE3F80C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xE3F450", Offset = "0xE3F450", VA = "0xE3F450")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE3F8E4", Offset = "0xE3F8E4", VA = "0xE3F8E4")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB124C4", Offset = "0xB124C4")]
		public bool SoundFollowsObject;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB124FC", Offset = "0xB124FC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB124FC", Offset = "0xB124FC")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB1255C", Offset = "0xB1255C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB1255C", Offset = "0xB1255C")]
		public bool playEnterSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB125CC", Offset = "0xB125CC")]
		public string enterVariationName;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12604", Offset = "0xB12604")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB12604", Offset = "0xB12604")]
		public bool playExitSound;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12674", Offset = "0xB12674")]
		public string exitVariationName;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB126AC", Offset = "0xB126AC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB126AC", Offset = "0xB126AC")]
		public bool playAnimTimeSound;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB1270C", Offset = "0xB1270C")]
		public bool useStopTime;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12744", Offset = "0xB12744")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12744", Offset = "0xB12744")]
		public float whenToStartSound;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12798", Offset = "0xB12798")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12798", Offset = "0xB12798")]
		public float whenToStopSound;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB127FC", Offset = "0xB127FC")]
		public string timedVariationName;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12834", Offset = "0xB12834")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB12834", Offset = "0xB12834")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12894", Offset = "0xB12894")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB128AC", Offset = "0xB128AC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB128AC", Offset = "0xB128AC")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12900", Offset = "0xB12900")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12900", Offset = "0xB12900")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12954", Offset = "0xB12954")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12954", Offset = "0xB12954")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB129A8", Offset = "0xB129A8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB129A8", Offset = "0xB129A8")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB12A0C", Offset = "0xB12A0C")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE3F960", Offset = "0xE3F960", VA = "0xE3F960", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xE3FBE4", Offset = "0xE3FBE4", VA = "0xE3FBE4", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xE40370", Offset = "0xE40370", VA = "0xE40370", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xE3FAE0", Offset = "0xE3FAE0", VA = "0xE3FAE0")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xE3FB88", Offset = "0xE3FB88", VA = "0xE3FB88")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xE405BC", Offset = "0xE405BC", VA = "0xE405BC")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x200007E")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12A44", Offset = "0xB12A44")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12A54", Offset = "0xB12A54")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12A64", Offset = "0xB12A64")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x17000073")]
		public bool SoundPlayed
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xE422A8", Offset = "0xE422A8", VA = "0xE422A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1424C", Offset = "0xB1424C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xE42288", Offset = "0xE42288", VA = "0xE42288")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1425C", Offset = "0xB1425C")]
			set
			{
			}
		}

		[Token(Token = "0x17000074")]
		public bool SoundScheduled
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xE422B0", Offset = "0xE422B0", VA = "0xE422B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1426C", Offset = "0xB1426C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xE42294", Offset = "0xE42294", VA = "0xE42294")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1427C", Offset = "0xB1427C")]
			set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xE3DE24", Offset = "0xE3DE24", VA = "0xE3DE24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1428C", Offset = "0xB1428C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xE422A0", Offset = "0xE422A0", VA = "0xE422A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1429C", Offset = "0xB1429C")]
			set
			{
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xE4225C", Offset = "0xE4225C", VA = "0xE4225C")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xC73010", Offset = "0xC73010", VA = "0xC73010")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class AudioEvent
	{
		[Token(Token = "0x200012A")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x40006D8")]
			UseSliderValue,
			[Token(Token = "0x40006D9")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x200012B")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600087E")]
			[Address(RVA = "0xC743E0", Offset = "0xC743E0", VA = "0xC743E0")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000076")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0xC74208", Offset = "0xC74208", VA = "0xC74208")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xC74274", Offset = "0xC74274", VA = "0xC74274")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class AudioEventGroup
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xC7441C", Offset = "0xC7441C", VA = "0xC7441C")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xC77650", Offset = "0xC77650", VA = "0xC77650")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class BusFadeInfo
	{
		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xC7A918", Offset = "0xC7A918", VA = "0xC7A918")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xC7A928", Offset = "0xC7A928", VA = "0xC7A928")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class CustomEvent
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xC7B974", Offset = "0xC7B974", VA = "0xC7B974")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class CustomEventCategory
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xC7B9FC", Offset = "0xC7B9FC", VA = "0xC7B9FC")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xC7BA60", Offset = "0xC7BA60", VA = "0xC7BA60")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xC7BF80", Offset = "0xC7BF80", VA = "0xC7BF80")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12A74", Offset = "0xB12A74")]
		public int probabilityToPlay;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x17000077")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0xC7BFE8", Offset = "0xC7BFE8", VA = "0xC7BFE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0xC7C080", Offset = "0xC7C080", VA = "0xC7C080")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0xC7C118", Offset = "0xC7C118", VA = "0xC7C118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xC7C1B0", Offset = "0xC7C1B0", VA = "0xC7C1B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xC7C248", Offset = "0xC7C248", VA = "0xC7C248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xC7C2E0", Offset = "0xC7C2E0", VA = "0xC7C2E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0xC7C378", Offset = "0xC7C378", VA = "0xC7C378")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		public Transform Trans
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0xC7C4E0", Offset = "0xC7C4E0", VA = "0xC7C4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007F")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0xC7C570", Offset = "0xC7C570", VA = "0xC7C570")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000080")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xC7C80C", Offset = "0xC7C80C", VA = "0xC7C80C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xC7C8A4", Offset = "0xC7C8A4", VA = "0xC7C8A4")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float spatialBlend;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string busName;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isExistingBus;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int limitPerXFrames;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float minimumTimeBetween;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool limitPolyphony;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int voiceLimitCount;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float despawnFadeTime;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xC7C8D8", Offset = "0xC7C8D8", VA = "0xC7C8D8")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class FootstepGroup
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xC94FB4", Offset = "0xC94FB4", VA = "0xC94FB4")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class GroupBus
	{
		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x17000081")]
		public int ActiveVoices
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xC956E4", Offset = "0xC956E4", VA = "0xC956E4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000082")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0xC95744", Offset = "0xC95744", VA = "0xC95744")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000083")]
		public float OriginalVolume
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xC957C8", Offset = "0xC957C8", VA = "0xC957C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0xC7F044", Offset = "0xC7F044", VA = "0xC7F044")]
			set
			{
			}
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xC955C8", Offset = "0xC955C8", VA = "0xC955C8")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xC95674", Offset = "0xC95674", VA = "0xC95674")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xC957D0", Offset = "0xC957D0", VA = "0xC957D0")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class GroupFadeInfo
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xC95870", Offset = "0xC95870", VA = "0xC95870")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class GroupPitchGlideInfo
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MasterAudioGroup ActingGroup;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string NameOfGroup;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CompletionTime;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool IsActive;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action completionAction;

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xC95880", Offset = "0xC95880", VA = "0xC95880")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x60003F7")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x60003F8")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60003F9")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60003FA")]
		void RegisterReceiver();

		[Token(Token = "0x60003FB")]
		void UnregisterReceiver();

		[Token(Token = "0x60003FC")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x2000090")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x200012C")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x40006DD")]
			None,
			[Token(Token = "0x40006DE")]
			Stop,
			[Token(Token = "0x40006DF")]
			FadeOut
		}

		[Token(Token = "0x200012D")]
		public enum VariationSequence
		{
			[Token(Token = "0x40006E1")]
			Randomized,
			[Token(Token = "0x40006E2")]
			TopToBottom
		}

		[Token(Token = "0x200012E")]
		public enum VariationMode
		{
			[Token(Token = "0x40006E4")]
			Normal,
			[Token(Token = "0x40006E5")]
			LoopedChain,
			[Token(Token = "0x40006E6")]
			Dialog
		}

		[Token(Token = "0x200012F")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x40006E8")]
			Endless,
			[Token(Token = "0x40006E9")]
			NumberOfLoops
		}

		[Token(Token = "0x2000130")]
		public enum LimitMode
		{
			[Token(Token = "0x40006EB")]
			None,
			[Token(Token = "0x40006EC")]
			FrameBased,
			[Token(Token = "0x40006ED")]
			TimeBased
		}

		[Token(Token = "0x400032F")]
		public const float UseCurveSpatialBlend = -99f;

		[Token(Token = "0x4000330")]
		public const string NoBus = "[NO BUS]";

		[Token(Token = "0x4000331")]
		public const int MinNoRepeatVariations = 3;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int busIndex;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float spatialBlend;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isSelected;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12A9C", Offset = "0xB12A9C")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x17000084")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xE3EEE4", Offset = "0xE3EEE4", VA = "0xE3EEE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000085")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xE3EFE8", Offset = "0xE3EFE8", VA = "0xE3EFE8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000086")]
		public int TotalVoices
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xE3F04C", Offset = "0xE3F04C", VA = "0xE3F04C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000087")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0xE3F080", Offset = "0xE3F080", VA = "0xE3F080")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x6000406")]
			[Address(RVA = "0xE3ED58", Offset = "0xE3ED58", VA = "0xE3ED58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0xE3F08C", Offset = "0xE3F08C", VA = "0xE3F08C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0xE3F094", Offset = "0xE3F094", VA = "0xE3F094")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0xE3F09C", Offset = "0xE3F09C", VA = "0xE3F09C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		public int ChainLoopCount
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0xE3F13C", Offset = "0xE3F13C", VA = "0xE3F13C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142CC", Offset = "0xB142CC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xE3F144", Offset = "0xE3F144", VA = "0xE3F144")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142DC", Offset = "0xB142DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public string GameObjectName
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xE3F14C", Offset = "0xE3F14C", VA = "0xE3F14C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008D")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xE3F190", Offset = "0xE3F190", VA = "0xE3F190")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008E")]
		private Transform Trans
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xE3EBFC", Offset = "0xE3EBFC", VA = "0xE3EBFC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xE3EB54", Offset = "0xE3EB54", VA = "0xE3EB54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000009")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0xE3E820", Offset = "0xE3E820", VA = "0xE3E820")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142AC", Offset = "0xB142AC")]
			add
			{
			}
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xE3E90C", Offset = "0xE3E90C", VA = "0xE3E90C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142BC", Offset = "0xB142BC")]
			remove
			{
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xE3E9F8", Offset = "0xE3E9F8", VA = "0xE3E9F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xE3EC8C", Offset = "0xE3EC8C", VA = "0xE3EC8C")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xE3EE48", Offset = "0xE3EE48", VA = "0xE3EE48")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xE3F118", Offset = "0xE3F118", VA = "0xE3F118")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xE3F12C", Offset = "0xE3F12C", VA = "0xE3F12C")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xE3F134", Offset = "0xE3F134", VA = "0xE3F134")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE3F218", Offset = "0xE3F218", VA = "0xE3F218")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE3F36C", Offset = "0xE3F36C", VA = "0xE3F36C")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class MusicSetting
	{
		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B38", Offset = "0xB11B38")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x600087F")]
			[Address(RVA = "0xE41088", Offset = "0xE41088", VA = "0xE41088")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0xE41178", Offset = "0xE41178", VA = "0xE41178")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B48", Offset = "0xB11B48")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x6000881")]
			[Address(RVA = "0xE410C4", Offset = "0xE410C4", VA = "0xE410C4")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0xE411C4", Offset = "0xE411C4", VA = "0xE411C4")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B58", Offset = "0xB11B58")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x6000883")]
			[Address(RVA = "0xE41100", Offset = "0xE41100", VA = "0xE41100")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0xE41210", Offset = "0xE41210", VA = "0xE41210")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B68", Offset = "0xB11B68")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x6000885")]
			[Address(RVA = "0xE4113C", Offset = "0xE4113C", VA = "0xE4113C")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0xE4125C", Offset = "0xE4125C", VA = "0xE4125C")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x17000090")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x6000416")]
			[Address(RVA = "0xE40790", Offset = "0xE40790", VA = "0xE40790")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000091")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xE407AC", Offset = "0xE407AC", VA = "0xE407AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000092")]
		public float SongStartTime
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0xE4089C", Offset = "0xE4089C", VA = "0xE4089C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0xE40638", Offset = "0xE40638", VA = "0xE40638")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0xE408C8", Offset = "0xE408C8", VA = "0xE408C8")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x600041A")]
		[Address(RVA = "0xE412A8", Offset = "0xE412A8", VA = "0xE412A8")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x600041B")]
		[Address(RVA = "0xE422B8", Offset = "0xE422B8", VA = "0xE422B8")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xE41108", Offset = "0xE41108", VA = "0xE41108")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xE410CC", Offset = "0xE410CC", VA = "0xE410CC")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xE41144", Offset = "0xE41144", VA = "0xE41144")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x2000135")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x40006F3")]
			Boolean,
			[Token(Token = "0x40006F4")]
			String,
			[Token(Token = "0x40006F5")]
			Integer,
			[Token(Token = "0x40006F6")]
			Float
		}

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x600041F")]
		[Address(RVA = "0xE4BA98", Offset = "0xE4BA98", VA = "0xE4BA98")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xE41090", Offset = "0xE41090", VA = "0xE41090")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000421")]
		[Address(RVA = "0xE4BAFC", Offset = "0xE4BAFC", VA = "0xE4BAFC")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB1153C", Offset = "0xB1153C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB1153C", Offset = "0xB1153C")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x2000136")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x2000137")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x2000138")]
		public class PlaySoundParams
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x600088F")]
			[Address(RVA = "0xE51720", Offset = "0xE51720", VA = "0xE51720")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x2000139")]
		public enum PitchMode
		{
			[Token(Token = "0x4000703")]
			None,
			[Token(Token = "0x4000704")]
			Gliding
		}

		[Token(Token = "0x200013A")]
		public enum FadeMode
		{
			[Token(Token = "0x4000706")]
			None,
			[Token(Token = "0x4000707")]
			FadeInOut,
			[Token(Token = "0x4000708")]
			FadeOutEarly,
			[Token(Token = "0x4000709")]
			GradualFade
		}

		[Token(Token = "0x200013B")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x400070B")]
			AddToClipPitch,
			[Token(Token = "0x400070C")]
			IgnoreClipPitch
		}

		[Token(Token = "0x200013C")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x400070E")]
			AddToClipVolume,
			[Token(Token = "0x400070F")]
			IgnoreClipVolume
		}

		[Token(Token = "0x200013D")]
		public enum DetectEndMode
		{
			[Token(Token = "0x4000711")]
			None,
			[Token(Token = "0x4000712")]
			DetectEnd
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B78", Offset = "0xB11B78")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x1700015C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000893")]
				[Address(RVA = "0xE518BC", Offset = "0xE518BC", VA = "0xE518BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000895")]
				[Address(RVA = "0xE5192C", Offset = "0xE5192C", VA = "0xE5192C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0xE4FDFC", Offset = "0xE4FDFC", VA = "0xE4FDFC")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0xE517D8", Offset = "0xE517D8", VA = "0xE517D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0xE517DC", Offset = "0xE517DC", VA = "0xE517DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0xE518C4", Offset = "0xE518C4", VA = "0xE518C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB12AAC", Offset = "0xB12AAC")]
		public int probabilityToPlay;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12AE4", Offset = "0xB12AE4")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x17000093")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xE50828", Offset = "0xE50828", VA = "0xE50828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xE508C0", Offset = "0xE508C0", VA = "0xE508C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xE50958", Offset = "0xE50958", VA = "0xE50958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0xE509F0", Offset = "0xE509F0", VA = "0xE509F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xE4CEE4", Offset = "0xE4CEE4", VA = "0xE4CEE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0xE50A88", Offset = "0xE50A88", VA = "0xE50A88")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600044D")]
			[Address(RVA = "0xE50A90", Offset = "0xE50A90", VA = "0xE50A90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xE4E1C4", Offset = "0xE4E1C4", VA = "0xE4E1C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xE50B28", Offset = "0xE50B28", VA = "0xE50B28")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xE50708", Offset = "0xE50708", VA = "0xE50708")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xE50C70", Offset = "0xE50C70", VA = "0xE50C70")]
			set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000453")]
			[Address(RVA = "0xE50C78", Offset = "0xE50C78", VA = "0xE50C78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700009C")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0xE4C544", Offset = "0xE4C544", VA = "0xE4C544")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xE4D91C", Offset = "0xE4D91C", VA = "0xE4D91C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009E")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0xE50F04", Offset = "0xE50F04", VA = "0xE50F04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009F")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xE50F50", Offset = "0xE50F50", VA = "0xE50F50")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0xE50F94", Offset = "0xE50F94", VA = "0xE50F94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0xE51054", Offset = "0xE51054", VA = "0xE51054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB14390", Offset = "0xB14390")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0xE5105C", Offset = "0xE5105C", VA = "0xE5105C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB143A0", Offset = "0xB143A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xE51064", Offset = "0xE51064", VA = "0xE51064")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A3")]
		public bool IsPlaying
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0xE4EA94", Offset = "0xE4EA94", VA = "0xE4EA94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A4")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xE51074", Offset = "0xE51074", VA = "0xE51074")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0xE4D740", Offset = "0xE4D740", VA = "0xE4D740")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public int InstanceId
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0xE4E190", Offset = "0xE4E190", VA = "0xE4E190")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A6")]
		public bool IsStopRequested
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xE5107C", Offset = "0xE5107C", VA = "0xE5107C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A7")]
		public Transform Trans
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xE4F828", Offset = "0xE4F828", VA = "0xE4F828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0xE4C2F0", Offset = "0xE4C2F0", VA = "0xE4C2F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xE4C258", Offset = "0xE4C258", VA = "0xE4C258")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000464")]
			[Address(RVA = "0xE4E0D0", Offset = "0xE4E0D0", VA = "0xE4E0D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AB")]
		public string ResFileName
		{
			[Token(Token = "0x6000465")]
			[Address(RVA = "0xE4DD68", Offset = "0xE4DD68", VA = "0xE4DD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000466")]
			[Address(RVA = "0xE4CC5C", Offset = "0xE4CC5C", VA = "0xE4CC5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xE51084", Offset = "0xE51084", VA = "0xE51084")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xE5108C", Offset = "0xE5108C", VA = "0xE5108C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xE510B8", Offset = "0xE510B8", VA = "0xE510B8")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public int MaxLoops
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xE510F0", Offset = "0xE510F0", VA = "0xE510F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B0")]
		private bool Is2D
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xE510F8", Offset = "0xE510F8", VA = "0xE510F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B1")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xE4CDEC", Offset = "0xE4CDEC", VA = "0xE4CDEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B2")]
		public bool IsPaused
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xE5119C", Offset = "0xE5119C", VA = "0xE5119C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1400000A")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xE3DE3C", Offset = "0xE3DE3C", VA = "0xE3DE3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142EC", Offset = "0xB142EC")]
			add
			{
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xE4BD90", Offset = "0xE4BD90", VA = "0xE4BD90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB142FC", Offset = "0xB142FC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xE4BE80", Offset = "0xE4BE80", VA = "0xE4BE80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1430C", Offset = "0xB1430C")]
			add
			{
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xE4BF70", Offset = "0xE4BF70", VA = "0xE4BF70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1431C", Offset = "0xB1431C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xE4C060", Offset = "0xE4C060", VA = "0xE4C060")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0xE4C380", Offset = "0xE4C380", VA = "0xE4C380")]
		private void Start()
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xE4C708", Offset = "0xE4C708", VA = "0xE4C708")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xE4C784", Offset = "0xE4C784", VA = "0xE4C784")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xE4C980", Offset = "0xE4C980", VA = "0xE4C980")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xE4C8C4", Offset = "0xE4C8C4", VA = "0xE4C8C4")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xE4CEEC", Offset = "0xE4CEEC", VA = "0xE4CEEC")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xE4CF9C", Offset = "0xE4CF9C", VA = "0xE4CF9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xE4D024", Offset = "0xE4D024", VA = "0xE4D024")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xE4CFA0", Offset = "0xE4CFA0", VA = "0xE4CFA0")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xE4D430", Offset = "0xE4D430", VA = "0xE4D430")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xE4D78C", Offset = "0xE4D78C", VA = "0xE4D78C")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xE4D754", Offset = "0xE4D754", VA = "0xE4D754")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xE4DE10", Offset = "0xE4DE10", VA = "0xE4DE10")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xE4D968", Offset = "0xE4D968", VA = "0xE4D968")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xE4E29C", Offset = "0xE4E29C", VA = "0xE4E29C")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xE4E30C", Offset = "0xE4E30C", VA = "0xE4E30C")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0xE4E644", Offset = "0xE4E644", VA = "0xE4E644")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xE4E808", Offset = "0xE4E808", VA = "0xE4E808")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xE4E984", Offset = "0xE4E984", VA = "0xE4E984")]
		public void Unpause()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xE4EBE8", Offset = "0xE4EBE8", VA = "0xE4EBE8")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xE4F074", Offset = "0xE4F074", VA = "0xE4F074")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xE4DE30", Offset = "0xE4DE30", VA = "0xE4DE30")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xE4F718", Offset = "0xE4F718", VA = "0xE4F718")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xE4F344", Offset = "0xE4F344", VA = "0xE4F344")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xE4D028", Offset = "0xE4D028", VA = "0xE4D028")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xE4FD44", Offset = "0xE4FD44", VA = "0xE4FD44")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xE4FD88", Offset = "0xE4FD88", VA = "0xE4FD88")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB1432C", Offset = "0xB1432C")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xE4FE28", Offset = "0xE4FE28", VA = "0xE4FE28")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xE50270", Offset = "0xE50270", VA = "0xE50270")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xE50548", Offset = "0xE50548", VA = "0xE50548")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0xE50648", Offset = "0xE50648", VA = "0xE50648")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xE50710", Offset = "0xE50710", VA = "0xE50710")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xE50B30", Offset = "0xE50B30", VA = "0xE50B30")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xE511A4", Offset = "0xE511A4", VA = "0xE511A4")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xE4DE08", Offset = "0xE4DE08", VA = "0xE4DE08")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xE515F4", Offset = "0xE515F4", VA = "0xE515F4")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB115B4", Offset = "0xB115B4")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x200013F")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000717")]
			None,
			[Token(Token = "0x4000718")]
			Play,
			[Token(Token = "0x4000719")]
			WaitForEnd,
			[Token(Token = "0x400071A")]
			StopOrRepeat
		}

		[Token(Token = "0x40003DB")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x40003DC")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x170000B3")]
		public float ClipStartPosition
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0xE52DBC", Offset = "0xE52DBC", VA = "0xE52DBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B4")]
		public float ClipEndPosition
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xE51B54", Offset = "0xE51B54", VA = "0xE51B54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B5")]
		public int FramesPlayed
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xE4F33C", Offset = "0xE4F33C", VA = "0xE4F33C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B6")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xE51134", Offset = "0xE51134", VA = "0xE51134")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0xE53CD4", Offset = "0xE53CD4", VA = "0xE53CD4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B8")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0xE53DAC", Offset = "0xE53DAC", VA = "0xE53DAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B9")]
		private Transform Trans
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0xE52320", Offset = "0xE52320", VA = "0xE52320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x6000495")]
			[Address(RVA = "0xE51AB4", Offset = "0xE51AB4", VA = "0xE51AB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0xE523C0", Offset = "0xE523C0", VA = "0xE523C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0xE51A1C", Offset = "0xE51A1C", VA = "0xE51A1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0xE52CE4", Offset = "0xE52CE4", VA = "0xE52CE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000BE")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0xE52678", Offset = "0xE52678", VA = "0xE52678")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000BF")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0xE53C40", Offset = "0xE53C40", VA = "0xE53C40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xE4E578", Offset = "0xE4E578", VA = "0xE4E578")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xE500BC", Offset = "0xE500BC", VA = "0xE500BC")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xE50378", Offset = "0xE50378", VA = "0xE50378")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xE4F65C", Offset = "0xE4F65C", VA = "0xE4F65C")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xE4DF58", Offset = "0xE4DF58", VA = "0xE4DF58")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0xE4E1CC", Offset = "0xE4E1CC", VA = "0xE4E1CC")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0xE4F694", Offset = "0xE4F694", VA = "0xE4F694")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0xE4F8FC", Offset = "0xE4F8FC", VA = "0xE4F8FC")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0xE4F8C8", Offset = "0xE4F8C8", VA = "0xE4F8C8")]
		public void StopFading()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0xE4F03C", Offset = "0xE4F03C", VA = "0xE4F03C")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0xE4F8B8", Offset = "0xE4F8B8", VA = "0xE4F8B8")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0xE5228C", Offset = "0xE5228C", VA = "0xE5228C")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0xE51CC0", Offset = "0xE51CC0", VA = "0xE51CC0")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0xE52460", Offset = "0xE52460", VA = "0xE52460")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0xE52514", Offset = "0xE52514", VA = "0xE52514")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0xE52708", Offset = "0xE52708", VA = "0xE52708")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0xE52784", Offset = "0xE52784", VA = "0xE52784")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0xE51E78", Offset = "0xE51E78", VA = "0xE51E78")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0xE52F24", Offset = "0xE52F24", VA = "0xE52F24")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xE53104", Offset = "0xE53104", VA = "0xE53104")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xE4E954", Offset = "0xE4E954", VA = "0xE4E954")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xE4EAC0", Offset = "0xE4EAC0", VA = "0xE4EAC0")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xE4ECC0", Offset = "0xE4ECC0", VA = "0xE4ECC0")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0xE531D0", Offset = "0xE531D0", VA = "0xE531D0")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0xE532D8", Offset = "0xE532D8", VA = "0xE532D8")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0xE53678", Offset = "0xE53678", VA = "0xE53678")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0xE53704", Offset = "0xE53704", VA = "0xE53704")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0xE4CCF4", Offset = "0xE4CCF4", VA = "0xE4CCF4")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0xE537A8", Offset = "0xE537A8", VA = "0xE537A8")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE53E84", Offset = "0xE53E84", VA = "0xE53E84")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xC74574", Offset = "0xC74574", VA = "0xC74574")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xC747A8", Offset = "0xC747A8", VA = "0xC747A8")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xC74998", Offset = "0xC74998", VA = "0xC74998")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009E")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000410")]
		private const int MaxPriority = 0;

		[Token(Token = "0x4000411")]
		private const int HighestPriority = 16;

		[Token(Token = "0x4000412")]
		private const int LowestPriority = 128;

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xC74B2C", Offset = "0xC74B2C", VA = "0xC74B2C")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xC74B5C", Offset = "0xC74B5C", VA = "0xC74B5C")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xC74B8C", Offset = "0xC74B8C", VA = "0xC74B8C")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xC74BBC", Offset = "0xC74BBC", VA = "0xC74BBC")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B88", Offset = "0xB11B88")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700015E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000899")]
				[Address(RVA = "0xC76EE0", Offset = "0xC76EE0", VA = "0xC76EE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700015F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600089B")]
				[Address(RVA = "0xC76F50", Offset = "0xC76F50", VA = "0xC76F50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0xC75E44", Offset = "0xC75E44", VA = "0xC75E44")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0xC76840", Offset = "0xC76840", VA = "0xC76840", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0xC76844", Offset = "0xC76844", VA = "0xC76844", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0xC76EE8", Offset = "0xC76EE8", VA = "0xC76EE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11B98", Offset = "0xB11B98")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x17000160")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089F")]
				[Address(RVA = "0xC775D8", Offset = "0xC775D8", VA = "0xC775D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000161")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A1")]
				[Address(RVA = "0xC77648", Offset = "0xC77648", VA = "0xC77648", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0xC75F3C", Offset = "0xC75F3C", VA = "0xC75F3C")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0xC76F58", Offset = "0xC76F58", VA = "0xC76F58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0xC76F5C", Offset = "0xC76F5C", VA = "0xC76F5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0xC775E0", Offset = "0xC775E0", VA = "0xC775E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xC75180", Offset = "0xC75180", VA = "0xC75180")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xC75230", Offset = "0xC75230", VA = "0xC75230")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xC75390", Offset = "0xC75390", VA = "0xC75390")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xC7572C", Offset = "0xC7572C", VA = "0xC7572C")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0xC7542C", Offset = "0xC7542C", VA = "0xC7542C")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xC75B60", Offset = "0xC75B60", VA = "0xC75B60")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xC75BDC", Offset = "0xC75BDC", VA = "0xC75BDC")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xC75D64", Offset = "0xC75D64", VA = "0xC75D64")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB143B0", Offset = "0xB143B0")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0xC75E70", Offset = "0xC75E70", VA = "0xC75E70")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB14414", Offset = "0xB14414")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xC75F68", Offset = "0xC75F68", VA = "0xC75F68")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xC76120", Offset = "0xC76120", VA = "0xC76120")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xC763C8", Offset = "0xC763C8", VA = "0xC763C8")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB115C8", Offset = "0xB115C8")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x2000142")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x400072B")]
			StopSound,
			[Token(Token = "0x400072C")]
			FadeSound
		}

		[Token(Token = "0x2000143")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x400072E")]
			StopExistingSound,
			[Token(Token = "0x400072F")]
			FadeInSameSound
		}

		[Token(Token = "0x2000144")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x4000731")]
			LateUpdate,
			[Token(Token = "0x4000732")]
			FixedUpdate
		}

		[Token(Token = "0x2000145")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x4000734")]
			All,
			[Token(Token = "0x4000735")]
			OneAtRandom
		}

		[Token(Token = "0x2000146")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x4000737")]
			AllGroups,
			[Token(Token = "0x4000738")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x2000147")]
		public enum RaycastMode
		{
			[Token(Token = "0x400073A")]
			Physics3D,
			[Token(Token = "0x400073B")]
			Physics2D
		}

		[Token(Token = "0x2000148")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x400073D")]
			ForceAllTo2D,
			[Token(Token = "0x400073E")]
			ForceAllTo3D,
			[Token(Token = "0x400073F")]
			ForceAllToCustom,
			[Token(Token = "0x4000740")]
			AllowDifferentPerController
		}

		[Token(Token = "0x2000149")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000742")]
			ForceAllTo2D,
			[Token(Token = "0x4000743")]
			ForceAllTo3D,
			[Token(Token = "0x4000744")]
			ForceAllToCustom,
			[Token(Token = "0x4000745")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x200014A")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x4000747")]
			ForceTo2D,
			[Token(Token = "0x4000748")]
			ForceTo3D,
			[Token(Token = "0x4000749")]
			ForceToCustom,
			[Token(Token = "0x400074A")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x200014B")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x400074C")]
			Narrow,
			[Token(Token = "0x400074D")]
			Normal,
			[Token(Token = "0x400074E")]
			Wide
		}

		[Token(Token = "0x200014C")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x4000750")]
			Always,
			[Token(Token = "0x4000751")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000752")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000753")]
			Never,
			[Token(Token = "0x4000754")]
			OnSameGameObject,
			[Token(Token = "0x4000755")]
			OnChildGameObject,
			[Token(Token = "0x4000756")]
			OnParentGameObject,
			[Token(Token = "0x4000757")]
			OnSameOrChildGameObject,
			[Token(Token = "0x4000758")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x200014D")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x400075A")]
			All,
			[Token(Token = "0x400075B")]
			Closest,
			[Token(Token = "0x400075C")]
			Random
		}

		[Token(Token = "0x200014E")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x400075E")]
			None,
			[Token(Token = "0x400075F")]
			Loading,
			[Token(Token = "0x4000760")]
			Loaded,
			[Token(Token = "0x4000761")]
			LoadFailed
		}

		[Token(Token = "0x200014F")]
		public enum AudioLocation
		{
			[Token(Token = "0x4000763")]
			Clip,
			[Token(Token = "0x4000764")]
			ResourceFile
		}

		[Token(Token = "0x2000150")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x4000766")]
			Beginning,
			[Token(Token = "0x4000767")]
			SpecificTime,
			[Token(Token = "0x4000768")]
			RandomTime
		}

		[Token(Token = "0x2000151")]
		public enum BusCommand
		{
			[Token(Token = "0x400076A")]
			None,
			[Token(Token = "0x400076B")]
			FadeToVolume,
			[Token(Token = "0x400076C")]
			Mute,
			[Token(Token = "0x400076D")]
			Pause,
			[Token(Token = "0x400076E")]
			Solo,
			[Token(Token = "0x400076F")]
			Unmute,
			[Token(Token = "0x4000770")]
			Unpause,
			[Token(Token = "0x4000771")]
			Unsolo,
			[Token(Token = "0x4000772")]
			Stop,
			[Token(Token = "0x4000773")]
			ChangePitch,
			[Token(Token = "0x4000774")]
			ToggleMute,
			[Token(Token = "0x4000775")]
			StopBusOfTransform,
			[Token(Token = "0x4000776")]
			PauseBusOfTransform,
			[Token(Token = "0x4000777")]
			UnpauseBusOfTransform,
			[Token(Token = "0x4000778")]
			GlideByPitch,
			[Token(Token = "0x4000779")]
			StopOldBusVoices,
			[Token(Token = "0x400077A")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x2000152")]
		public enum DragGroupMode
		{
			[Token(Token = "0x400077C")]
			OneGroupPerClip,
			[Token(Token = "0x400077D")]
			OneGroupWithVariations
		}

		[Token(Token = "0x2000153")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x400077F")]
			PlaySound,
			[Token(Token = "0x4000780")]
			GroupControl,
			[Token(Token = "0x4000781")]
			BusControl,
			[Token(Token = "0x4000782")]
			PlaylistControl,
			[Token(Token = "0x4000783")]
			CustomEventControl,
			[Token(Token = "0x4000784")]
			GlobalControl,
			[Token(Token = "0x4000785")]
			UnityMixerControl,
			[Token(Token = "0x4000786")]
			PersistentSettingsControl
		}

		[Token(Token = "0x2000154")]
		public enum LanguageMode
		{
			[Token(Token = "0x4000788")]
			UseDeviceSetting,
			[Token(Token = "0x4000789")]
			SpecificLanguage,
			[Token(Token = "0x400078A")]
			DynamicallySet
		}

		[Token(Token = "0x2000155")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x400078C")]
			None,
			[Token(Token = "0x400078D")]
			TransitionToSnapshot,
			[Token(Token = "0x400078E")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x2000156")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000790")]
			None,
			[Token(Token = "0x4000791")]
			ChangePlaylist,
			[Token(Token = "0x4000792")]
			FadeToVolume,
			[Token(Token = "0x4000793")]
			PlaySong,
			[Token(Token = "0x4000794")]
			PlayRandomSong,
			[Token(Token = "0x4000795")]
			PlayNextSong,
			[Token(Token = "0x4000796")]
			Pause,
			[Token(Token = "0x4000797")]
			Resume,
			[Token(Token = "0x4000798")]
			Stop,
			[Token(Token = "0x4000799")]
			Mute,
			[Token(Token = "0x400079A")]
			Unmute,
			[Token(Token = "0x400079B")]
			ToggleMute,
			[Token(Token = "0x400079C")]
			Restart,
			[Token(Token = "0x400079D")]
			Start,
			[Token(Token = "0x400079E")]
			StopLoopingCurrentSong,
			[Token(Token = "0x400079F")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x40007A0")]
			AddSongToQueue
		}

		[Token(Token = "0x2000157")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x40007A2")]
			None,
			[Token(Token = "0x40007A3")]
			FireEvent
		}

		[Token(Token = "0x2000158")]
		public enum GlobalCommand
		{
			[Token(Token = "0x40007A5")]
			None,
			[Token(Token = "0x40007A6")]
			PauseMixer,
			[Token(Token = "0x40007A7")]
			UnpauseMixer,
			[Token(Token = "0x40007A8")]
			StopMixer,
			[Token(Token = "0x40007A9")]
			StopEverything,
			[Token(Token = "0x40007AA")]
			PauseEverything,
			[Token(Token = "0x40007AB")]
			UnpauseEverything,
			[Token(Token = "0x40007AC")]
			MuteEverything,
			[Token(Token = "0x40007AD")]
			UnmuteEverything,
			[Token(Token = "0x40007AE")]
			SetMasterMixerVolume,
			[Token(Token = "0x40007AF")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x2000159")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x40007B1")]
			None,
			[Token(Token = "0x40007B2")]
			FadeToVolume,
			[Token(Token = "0x40007B3")]
			FadeOutAllOfSound,
			[Token(Token = "0x40007B4")]
			Mute,
			[Token(Token = "0x40007B5")]
			Pause,
			[Token(Token = "0x40007B6")]
			Solo,
			[Token(Token = "0x40007B7")]
			StopAllOfSound,
			[Token(Token = "0x40007B8")]
			Unmute,
			[Token(Token = "0x40007B9")]
			Unpause,
			[Token(Token = "0x40007BA")]
			Unsolo,
			[Token(Token = "0x40007BB")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x40007BC")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x40007BD")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x40007BE")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x40007BF")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x40007C0")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x40007C1")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x40007C2")]
			RefillSoundGroupPool,
			[Token(Token = "0x40007C3")]
			RouteToBus,
			[Token(Token = "0x40007C4")]
			GlideByPitch,
			[Token(Token = "0x40007C5")]
			ToggleSoundGroup,
			[Token(Token = "0x40007C6")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x40007C7")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x40007C8")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x40007C9")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x200015A")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x40007CB")]
			None,
			[Token(Token = "0x40007CC")]
			SetBusVolume,
			[Token(Token = "0x40007CD")]
			SetGroupVolume,
			[Token(Token = "0x40007CE")]
			SetMixerVolume,
			[Token(Token = "0x40007CF")]
			SetMusicVolume,
			[Token(Token = "0x40007D0")]
			MixerMuteToggle,
			[Token(Token = "0x40007D1")]
			MusicMuteToggle
		}

		[Token(Token = "0x200015B")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x40007D3")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x40007D4")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x40007D5")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x200015C")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x40007D7")]
			MasterAudioLocation,
			[Token(Token = "0x40007D8")]
			CallerLocation,
			[Token(Token = "0x40007D9")]
			AttachToCaller
		}

		[Token(Token = "0x200015D")]
		public enum VariationCommand
		{
			[Token(Token = "0x40007DB")]
			None,
			[Token(Token = "0x40007DC")]
			Stop,
			[Token(Token = "0x40007DD")]
			Pause,
			[Token(Token = "0x40007DE")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x200015E")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x40007DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x40007E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0xA1ABB8", Offset = "0xA1ABB8", VA = "0xA1ABB8")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200015F")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x40007E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x40007E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x40007E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x40007E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0xE3E658", Offset = "0xE3E658", VA = "0xE3E658")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000160")]
		public class AudioInfo
		{
			[Token(Token = "0x40007E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x40007E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x40007EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x40007EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x40007EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0xE3E6A4", Offset = "0xE3E6A4", VA = "0xE3E6A4")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000161")]
		public class Playlist
		{
			[Token(Token = "0x200018D")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x4000873")]
				UseMasterSetting,
				[Token(Token = "0x4000874")]
				Override
			}

			[Token(Token = "0x40007ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x40007EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x40007EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x40007F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x40007F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x40007F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x40007F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x40007FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x40007FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x40007FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x40007FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xE3E708", Offset = "0xE3E708", VA = "0xE3E708")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000162")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40007FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40007FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0xE3E7E8", Offset = "0xE3E7E8", VA = "0xE3E7E8")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BA8", Offset = "0xB11BA8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__223_0;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__224_0;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__225_0;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<AmbientSoundToTriggerInfo> <>9__226_0;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<GroupPitchGlideInfo> <>9__227_0;

			[Token(Token = "0x4000806")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<BusPitchGlideInfo> <>9__228_0;

			[Token(Token = "0x4000807")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__426_0;

			[Token(Token = "0x4000808")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Comparison<CustomEventCandidate> <>9__426_1;

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0xE3D3B0", Offset = "0xE3D3B0", VA = "0xE3D3B0")]
			public <>c()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0xE3D3B8", Offset = "0xE3D3B8", VA = "0xE3D3B8")]
			internal bool <PerformOcclusionFrequencyChanges>b__223_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0xE3D3EC", Offset = "0xE3D3EC", VA = "0xE3D3EC")]
			internal bool <PerformBusFades>b__224_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0xE3D420", Offset = "0xE3D420", VA = "0xE3D420")]
			internal bool <PerformGroupFades>b__225_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0xE3D454", Offset = "0xE3D454", VA = "0xE3D454")]
			internal bool <PerformDelayedAmbientTriggers>b__226_0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0xE3D494", Offset = "0xE3D494", VA = "0xE3D494")]
			internal bool <PerformGroupPitchGlides>b__227_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0xE3D4C8", Offset = "0xE3D4C8", VA = "0xE3D4C8")]
			internal bool <PerformBusPitchGlides>b__228_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0xE3D4FC", Offset = "0xE3D4FC", VA = "0xE3D4FC")]
			internal int <FireCustomEvent>b__426_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0xE3D50C", Offset = "0xE3D50C", VA = "0xE3D50C")]
			internal int <FireCustomEvent>b__426_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BB8", Offset = "0xB11BB8")]
		private sealed class <>c__DisplayClass238_0
		{
			[Token(Token = "0x4000809")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0xE3D520", Offset = "0xE3D520", VA = "0xE3D520")]
			public <>c__DisplayClass238_0()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0xE3D528", Offset = "0xE3D528", VA = "0xE3D528")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BC8", Offset = "0xB11BC8")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__238 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400080A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400080B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400080C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x400080D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x400080E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x400080F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x4000810")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x4000811")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass238_0 <>8__1;

			[Token(Token = "0x4000812")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x17000162")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008B6")]
				[Address(RVA = "0xE3E5E0", Offset = "0xE3E5E0", VA = "0xE3E5E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000163")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008B8")]
				[Address(RVA = "0xE3E650", Offset = "0xE3E650", VA = "0xE3E650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0xE3E30C", Offset = "0xE3E30C", VA = "0xE3E30C")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__238(int <>1__state)
			{
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0xE3E338", Offset = "0xE3E338", VA = "0xE3E338", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0xE3E33C", Offset = "0xE3E33C", VA = "0xE3E33C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0xE3E5E8", Offset = "0xE3E5E8", VA = "0xE3E5E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BD8", Offset = "0xB11BD8")]
		private sealed class <>c__DisplayClass239_0
		{
			[Token(Token = "0x4000813")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0xE3D534", Offset = "0xE3D534", VA = "0xE3D534")]
			public <>c__DisplayClass239_0()
			{
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0xE3D53C", Offset = "0xE3D53C", VA = "0xE3D53C")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BE8", Offset = "0xB11BE8")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__239 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000814")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000815")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000816")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000817")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000818")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000819")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x400081A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x400081B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x400081C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass239_0 <>8__1;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x17000164")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008BE")]
				[Address(RVA = "0xE3DF2C", Offset = "0xE3DF2C", VA = "0xE3DF2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000165")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C0")]
				[Address(RVA = "0xE3DF9C", Offset = "0xE3DF9C", VA = "0xE3DF9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0xE3DB34", Offset = "0xE3DB34", VA = "0xE3DB34")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__239(int <>1__state)
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0xE3DB60", Offset = "0xE3DB60", VA = "0xE3DB60", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0xE3DB64", Offset = "0xE3DB64", VA = "0xE3DB64", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0xE3DF34", Offset = "0xE3DF34", VA = "0xE3DF34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11BF8", Offset = "0xB11BF8")]
		private sealed class <>c__DisplayClass240_0
		{
			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0xE3D548", Offset = "0xE3D548", VA = "0xE3D548")]
			public <>c__DisplayClass240_0()
			{
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0xE3D550", Offset = "0xE3D550", VA = "0xE3D550")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C08", Offset = "0xB11C08")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__240 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000820")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000821")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000822")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x4000823")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x4000824")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x4000825")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x4000826")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x4000827")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x4000828")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x4000829")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass240_0 <>8__1;

			[Token(Token = "0x400082A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x17000166")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008C6")]
				[Address(RVA = "0xE3E294", Offset = "0xE3E294", VA = "0xE3E294", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000167")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008C8")]
				[Address(RVA = "0xE3E304", Offset = "0xE3E304", VA = "0xE3E304", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0xE3DFA4", Offset = "0xE3DFA4", VA = "0xE3DFA4")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__240(int <>1__state)
			{
			}

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0xE3DFD0", Offset = "0xE3DFD0", VA = "0xE3DFD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0xE3DFD4", Offset = "0xE3DFD4", VA = "0xE3DFD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0xE3E29C", Offset = "0xE3E29C", VA = "0xE3E29C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C18", Offset = "0xB11C18")]
		private sealed class <>c__DisplayClass273_0
		{
			[Token(Token = "0x400082B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0xE3D55C", Offset = "0xE3D55C", VA = "0xE3D55C")]
			public <>c__DisplayClass273_0()
			{
			}

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0xE3D564", Offset = "0xE3D564", VA = "0xE3D564")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0xE3D59C", Offset = "0xE3D59C", VA = "0xE3D59C")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C28", Offset = "0xB11C28")]
		private sealed class <>c__DisplayClass281_0
		{
			[Token(Token = "0x400082C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0xE3D5D4", Offset = "0xE3D5D4", VA = "0xE3D5D4")]
			public <>c__DisplayClass281_0()
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0xE3D5DC", Offset = "0xE3D5DC", VA = "0xE3D5DC")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C38", Offset = "0xB11C38")]
		private sealed class <>c__DisplayClass284_0
		{
			[Token(Token = "0x400082D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0xE3D614", Offset = "0xE3D614", VA = "0xE3D614")]
			public <>c__DisplayClass284_0()
			{
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0xE3D61C", Offset = "0xE3D61C", VA = "0xE3D61C")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C48", Offset = "0xB11C48")]
		private sealed class <>c__DisplayClass336_0
		{
			[Token(Token = "0x400082E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0xE3D654", Offset = "0xE3D654", VA = "0xE3D654")]
			public <>c__DisplayClass336_0()
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0xE3D65C", Offset = "0xE3D65C", VA = "0xE3D65C")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C58", Offset = "0xB11C58")]
		private sealed class <>c__DisplayClass340_0
		{
			[Token(Token = "0x400082F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0xE3D694", Offset = "0xE3D694", VA = "0xE3D694")]
			public <>c__DisplayClass340_0()
			{
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0xE3D69C", Offset = "0xE3D69C", VA = "0xE3D69C")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C68", Offset = "0xB11C68")]
		private sealed class <>c__DisplayClass343_0
		{
			[Token(Token = "0x4000830")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0xE3D6D4", Offset = "0xE3D6D4", VA = "0xE3D6D4")]
			public <>c__DisplayClass343_0()
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0xE3D6DC", Offset = "0xE3D6DC", VA = "0xE3D6DC")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C78", Offset = "0xB11C78")]
		private sealed class <>c__DisplayClass422_0
		{
			[Token(Token = "0x4000831")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0xE3D714", Offset = "0xE3D714", VA = "0xE3D714")]
			public <>c__DisplayClass422_0()
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0xE3D71C", Offset = "0xE3D71C", VA = "0xE3D71C")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C88", Offset = "0xB11C88")]
		private sealed class <>c__DisplayClass423_0
		{
			[Token(Token = "0x4000832")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0xE3D754", Offset = "0xE3D754", VA = "0xE3D754")]
			public <>c__DisplayClass423_0()
			{
			}

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0xE3D75C", Offset = "0xE3D75C", VA = "0xE3D75C")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11C98", Offset = "0xB11C98")]
		private sealed class <>c__DisplayClass424_0
		{
			[Token(Token = "0x4000833")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0xE3D794", Offset = "0xE3D794", VA = "0xE3D794")]
			public <>c__DisplayClass424_0()
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0xE3D79C", Offset = "0xE3D79C", VA = "0xE3D79C")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CA8", Offset = "0xB11CA8")]
		private sealed class <>c__DisplayClass425_0
		{
			[Token(Token = "0x4000834")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0xE3D7D4", Offset = "0xE3D7D4", VA = "0xE3D7D4")]
			public <>c__DisplayClass425_0()
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0xE3D7DC", Offset = "0xE3D7DC", VA = "0xE3D7DC")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CB8", Offset = "0xB11CB8")]
		private sealed class <>c__DisplayClass427_0
		{
			[Token(Token = "0x4000835")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0xE3D814", Offset = "0xE3D814", VA = "0xE3D814")]
			public <>c__DisplayClass427_0()
			{
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0xE3D81C", Offset = "0xE3D81C", VA = "0xE3D81C")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CC8", Offset = "0xB11CC8")]
		private sealed class <>c__DisplayClass428_0
		{
			[Token(Token = "0x4000836")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0xE3D854", Offset = "0xE3D854", VA = "0xE3D854")]
			public <>c__DisplayClass428_0()
			{
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xE3D85C", Offset = "0xE3D85C", VA = "0xE3D85C")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CD8", Offset = "0xB11CD8")]
		private sealed class <>c__DisplayClass429_0
		{
			[Token(Token = "0x4000837")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0xE3D930", Offset = "0xE3D930", VA = "0xE3D930")]
			public <>c__DisplayClass429_0()
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xE3D938", Offset = "0xE3D938", VA = "0xE3D938")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CE8", Offset = "0xB11CE8")]
		private sealed class <>c__DisplayClass444_0
		{
			[Token(Token = "0x4000838")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0xE3DA0C", Offset = "0xE3DA0C", VA = "0xE3DA0C")]
			public <>c__DisplayClass444_0()
			{
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0xE3DA14", Offset = "0xE3DA14", VA = "0xE3DA14")]
			internal bool <SetupAmbientNextFrame>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11CF8", Offset = "0xB11CF8")]
		private sealed class <>c__DisplayClass445_0
		{
			[Token(Token = "0x4000839")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0xE3DAA0", Offset = "0xE3DAA0", VA = "0xE3DAA0")]
			public <>c__DisplayClass445_0()
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xE3DAA8", Offset = "0xE3DAA8", VA = "0xE3DAA8")]
			internal bool <RemoveDelayedAmbient>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000417")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000418")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000419")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x400041A")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x400041B")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x400041C")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x400041D")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x400041E")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x400041F")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000420")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000421")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x4000422")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x4000423")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x4000424")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000429")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x400042A")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x400042B")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x400042C")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x400042D")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x400042E")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x400042F")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x4000430")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000431")]
		private const int MaxComponents = 20;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool logPerfExpanded;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool willWarm;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private float _repriTime;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool _mustRescanGroups;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Transform _trans;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _soundsLoaded;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		private bool _warming;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12AF4", Offset = "0xB12AF4")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x170000C0")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xCA66A4", Offset = "0xCA66A4", VA = "0xCA66A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000581")]
			[Address(RVA = "0xC8E8FC", Offset = "0xC8E8FC", VA = "0xC8E8FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xCA7240", Offset = "0xCA7240", VA = "0xCA7240")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0xCA72B0", Offset = "0xCA72B0", VA = "0xCA72B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0xC9C8F8", Offset = "0xC9C8F8", VA = "0xC9C8F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0xCA7328", Offset = "0xCA7328", VA = "0xCA7328")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0xCA8628", Offset = "0xCA8628", VA = "0xCA8628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xC735C0", Offset = "0xC735C0", VA = "0xC735C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xCA87BC", Offset = "0xCA87BC", VA = "0xCA87BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public static bool IsWarming
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xC83408", Offset = "0xC83408", VA = "0xC83408")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C7")]
		public static bool MixerMuted
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0xCA8884", Offset = "0xCA8884", VA = "0xCA8884")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xCA4008", Offset = "0xCA4008", VA = "0xCA4008")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0xCA88F4", Offset = "0xCA88F4", VA = "0xCA88F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0xCA547C", Offset = "0xCA547C", VA = "0xCA547C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0xC9DC1C", Offset = "0xC9DC1C", VA = "0xC9DC1C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xCA8964", Offset = "0xCA8964", VA = "0xCA8964")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0xCA8970", Offset = "0xCA8970", VA = "0xCA8970")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000CB")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xCA5038", Offset = "0xCA5038", VA = "0xCA5038")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0xCA13D0", Offset = "0xCA13D0", VA = "0xCA13D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CD")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x60005B7")]
			[Address(RVA = "0xC885E4", Offset = "0xC885E4", VA = "0xC885E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0xC8B3EC", Offset = "0xC8B3EC", VA = "0xC8B3EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xC712C0", Offset = "0xC712C0", VA = "0xC712C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xC721E0", Offset = "0xC721E0", VA = "0xC721E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xCA8978", Offset = "0xCA8978", VA = "0xCA8978")]
			set
			{
			}
		}

		[Token(Token = "0x170000D1")]
		public static bool SoundsReady
		{
			[Token(Token = "0x60005BC")]
			[Address(RVA = "0xC7D0D0", Offset = "0xC7D0D0", VA = "0xC7D0D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xC711C4", Offset = "0xC711C4", VA = "0xC711C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB145A4", Offset = "0xB145A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xC9A3CC", Offset = "0xC9A3CC", VA = "0xC9A3CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB145B4", Offset = "0xB145B4")]
			set
			{
			}
		}

		[Token(Token = "0x170000D3")]
		public List<string> GroupNames
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xCA89E0", Offset = "0xCA89E0", VA = "0xCA89E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xC72EA4", Offset = "0xC72EA4", VA = "0xC72EA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public List<string> BusNames
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xCA8DB4", Offset = "0xCA8DB4", VA = "0xCA8DB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xCA8F38", Offset = "0xCA8F38", VA = "0xCA8F38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xCA90BC", Offset = "0xCA90BC", VA = "0xCA90BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public Transform Trans
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xC73C54", Offset = "0xC73C54", VA = "0xC73C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xCA91F8", Offset = "0xCA91F8", VA = "0xCA91F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DA")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xCA9200", Offset = "0xCA9200", VA = "0xCA9200")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xCA93FC", Offset = "0xCA93FC", VA = "0xCA93FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xCA9320", Offset = "0xCA9320", VA = "0xCA9320")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DD")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xCA9564", Offset = "0xCA9564", VA = "0xCA9564")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xC8E730", Offset = "0xC8E730", VA = "0xC8E730")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xC9A43C", Offset = "0xC9A43C", VA = "0xC9A43C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xC7BE98", Offset = "0xC7BE98", VA = "0xC7BE98")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E0")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xC759E8", Offset = "0xC759E8", VA = "0xC759E8")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xCA95D4", Offset = "0xCA95D4", VA = "0xCA95D4")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xCA96A8", Offset = "0xCA96A8", VA = "0xCA96A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E2")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xCA981C", Offset = "0xCA981C", VA = "0xCA981C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E3")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xCA98F4", Offset = "0xCA98F4", VA = "0xCA98F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xCA995C", Offset = "0xCA995C", VA = "0xCA995C")]
			set
			{
			}
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xC95890", Offset = "0xC95890", VA = "0xC95890")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xC979C4", Offset = "0xC979C4", VA = "0xC979C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xC97BCC", Offset = "0xC97BCC", VA = "0xC97BCC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xC97E80", Offset = "0xC97E80", VA = "0xC97E80")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xC99570", Offset = "0xC99570", VA = "0xC99570")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xC9960C", Offset = "0xC9960C", VA = "0xC9960C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xC99580", Offset = "0xC99580", VA = "0xC99580")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xC977CC", Offset = "0xC977CC", VA = "0xC977CC")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xC99BA4", Offset = "0xC99BA4", VA = "0xC99BA4")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0xC99CA4", Offset = "0xC99CA4", VA = "0xC99CA4")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xC999B4", Offset = "0xC999B4", VA = "0xC999B4")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xC99D38", Offset = "0xC99D38", VA = "0xC99D38")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xC99620", Offset = "0xC99620", VA = "0xC99620")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0xC99454", Offset = "0xC99454", VA = "0xC99454")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xC990B0", Offset = "0xC990B0", VA = "0xC990B0")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xC97F18", Offset = "0xC97F18", VA = "0xC97F18")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xC98288", Offset = "0xC98288", VA = "0xC98288")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xC987B4", Offset = "0xC987B4", VA = "0xC987B4")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xC98D4C", Offset = "0xC98D4C", VA = "0xC98D4C")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0xC98B5C", Offset = "0xC98B5C", VA = "0xC98B5C")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xC985C8", Offset = "0xC985C8", VA = "0xC985C8")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0xC9A36C", Offset = "0xC9A36C", VA = "0xC9A36C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xC7B060", Offset = "0xC7B060", VA = "0xC7B060")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xC863C8", Offset = "0xC863C8", VA = "0xC863C8")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xC9C09C", Offset = "0xC9C09C", VA = "0xC9C09C")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xC9C24C", Offset = "0xC9C24C", VA = "0xC9C24C")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xC77B50", Offset = "0xC77B50", VA = "0xC77B50")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xC77DF8", Offset = "0xC77DF8", VA = "0xC77DF8")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xC780C8", Offset = "0xC780C8", VA = "0xC780C8")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xC78370", Offset = "0xC78370", VA = "0xC78370")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xC9C424", Offset = "0xC9C424", VA = "0xC9C424")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB14478", Offset = "0xB14478")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xC78658", Offset = "0xC78658", VA = "0xC78658")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB144DC", Offset = "0xB144DC")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xC7885C", Offset = "0xC7885C", VA = "0xC7885C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB14540", Offset = "0xB14540")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xC9C054", Offset = "0xC9C054", VA = "0xC9C054")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xC9A4D0", Offset = "0xC9A4D0", VA = "0xC9A4D0")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xC9CFB8", Offset = "0xC9CFB8", VA = "0xC9CFB8")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xC9C888", Offset = "0xC9C888", VA = "0xC9C888")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xC9CCEC", Offset = "0xC9CCEC", VA = "0xC9CCEC")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xC9D030", Offset = "0xC9D030", VA = "0xC9D030")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xC9D9B8", Offset = "0xC9D9B8", VA = "0xC9D9B8")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xC9DC24", Offset = "0xC9DC24", VA = "0xC9DC24")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xC79174", Offset = "0xC79174", VA = "0xC79174")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xC71A8C", Offset = "0xC71A8C", VA = "0xC71A8C")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xC78A00", Offset = "0xC78A00", VA = "0xC78A00")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xC78F38", Offset = "0xC78F38", VA = "0xC78F38")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xC79810", Offset = "0xC79810", VA = "0xC79810")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xC79D48", Offset = "0xC79D48", VA = "0xC79D48")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xC8A00C", Offset = "0xC8A00C", VA = "0xC8A00C")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xC71C64", Offset = "0xC71C64", VA = "0xC71C64")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0xC898D8", Offset = "0xC898D8", VA = "0xC898D8")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xC887CC", Offset = "0xC887CC", VA = "0xC887CC")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0xC9DF50", Offset = "0xC9DF50", VA = "0xC9DF50")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xC77764", Offset = "0xC77764", VA = "0xC77764")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xC9E234", Offset = "0xC9E234", VA = "0xC9E234")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xC9E5E4", Offset = "0xC9E5E4", VA = "0xC9E5E4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xC9E840", Offset = "0xC9E840", VA = "0xC9E840")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xC9F964", Offset = "0xC9F964", VA = "0xC9F964")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xCA0148", Offset = "0xCA0148", VA = "0xCA0148")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xCA0534", Offset = "0xCA0534", VA = "0xCA0534")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xCA0898", Offset = "0xCA0898", VA = "0xCA0898")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xCA0A48", Offset = "0xCA0A48", VA = "0xCA0A48")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xCA0D78", Offset = "0xCA0D78", VA = "0xCA0D78")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xCA10DC", Offset = "0xCA10DC", VA = "0xCA10DC")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xC886DC", Offset = "0xC886DC", VA = "0xC886DC")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xC79F94", Offset = "0xC79F94", VA = "0xC79F94")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xC8A220", Offset = "0xC8A220", VA = "0xC8A220")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xCA16C4", Offset = "0xCA16C4", VA = "0xCA16C4")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xC88A4C", Offset = "0xC88A4C", VA = "0xC88A4C")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xCA1FAC", Offset = "0xCA1FAC", VA = "0xCA1FAC")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0xC895C8", Offset = "0xC895C8", VA = "0xC895C8")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xCA204C", Offset = "0xCA204C", VA = "0xCA204C")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xCA21E4", Offset = "0xCA21E4", VA = "0xCA21E4")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xC89D34", Offset = "0xC89D34", VA = "0xC89D34")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xC89088", Offset = "0xC89088", VA = "0xC89088")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xC8B1A0", Offset = "0xC8B1A0", VA = "0xC8B1A0")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xC8AF78", Offset = "0xC8AF78", VA = "0xC8AF78")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xC8A940", Offset = "0xC8A940", VA = "0xC8A940")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xC7E128", Offset = "0xC7E128", VA = "0xC7E128")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xC7F054", Offset = "0xC7F054", VA = "0xC7F054")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xCA2648", Offset = "0xCA2648", VA = "0xCA2648")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xC99EEC", Offset = "0xC99EEC", VA = "0xC99EEC")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xC8946C", Offset = "0xC8946C", VA = "0xC8946C")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xC89C2C", Offset = "0xC89C2C", VA = "0xC89C2C")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xC97500", Offset = "0xC97500", VA = "0xC97500")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xCA2A10", Offset = "0xCA2A10", VA = "0xCA2A10")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xCA2864", Offset = "0xCA2864", VA = "0xCA2864")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xC97C5C", Offset = "0xC97C5C", VA = "0xC97C5C")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xCA23A8", Offset = "0xCA23A8", VA = "0xCA23A8")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xCA2AC0", Offset = "0xCA2AC0", VA = "0xCA2AC0")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xCA2704", Offset = "0xCA2704", VA = "0xCA2704")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xC89760", Offset = "0xC89760", VA = "0xC89760")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0xC7E90C", Offset = "0xC7E90C", VA = "0xC7E90C")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xCA2EA4", Offset = "0xCA2EA4", VA = "0xCA2EA4")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0xCA3078", Offset = "0xCA3078", VA = "0xCA3078")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xCA2CB4", Offset = "0xCA2CB4", VA = "0xCA2CB4")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xCA3210", Offset = "0xCA3210", VA = "0xCA3210")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xC89ECC", Offset = "0xC89ECC", VA = "0xC89ECC")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xC71744", Offset = "0xC71744", VA = "0xC71744")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xCA33A8", Offset = "0xCA33A8", VA = "0xCA33A8")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0xCA34DC", Offset = "0xCA34DC", VA = "0xCA34DC")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xCA3710", Offset = "0xCA3710", VA = "0xCA3710")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xCA387C", Offset = "0xCA387C", VA = "0xCA387C")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xCA3978", Offset = "0xCA3978", VA = "0xCA3978")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xCA3AFC", Offset = "0xCA3AFC", VA = "0xCA3AFC")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xCA3C24", Offset = "0xCA3C24", VA = "0xCA3C24")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xC8EA04", Offset = "0xC8EA04", VA = "0xC8EA04")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xC8EC00", Offset = "0xC8EC00", VA = "0xC8EC00")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xC8EDFC", Offset = "0xC8EDFC", VA = "0xC8EDFC")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xCA3D7C", Offset = "0xCA3D7C", VA = "0xCA3D7C")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xC8F208", Offset = "0xC8F208", VA = "0xC8F208")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xC8F148", Offset = "0xC8F148", VA = "0xC8F148")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xC8F1A8", Offset = "0xC8F1A8", VA = "0xC8F1A8")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xC8F080", Offset = "0xC8F080", VA = "0xC8F080")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xC8F0E4", Offset = "0xC8F0E4", VA = "0xC8F0E4")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xCA4408", Offset = "0xCA4408", VA = "0xCA4408")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xC9A1DC", Offset = "0xC9A1DC", VA = "0xC9A1DC")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xCA1440", Offset = "0xCA1440", VA = "0xCA1440")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xC8D040", Offset = "0xC8D040", VA = "0xC8D040")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xC8C6D8", Offset = "0xC8C6D8", VA = "0xC8C6D8")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xC8C920", Offset = "0xC8C920", VA = "0xC8C920")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xC8CB0C", Offset = "0xC8CB0C", VA = "0xC8CB0C")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0xC8C154", Offset = "0xC8C154", VA = "0xC8C154")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xC8CC0C", Offset = "0xC8CC0C", VA = "0xC8CC0C")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0xC8CE54", Offset = "0xC8CE54", VA = "0xC8CE54")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xCA4718", Offset = "0xCA4718", VA = "0xCA4718")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xC9C968", Offset = "0xC9C968", VA = "0xC9C968")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xC8C318", Offset = "0xC8C318", VA = "0xC8C318")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xC8C534", Offset = "0xC8C534", VA = "0xC8C534")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xC7EDB8", Offset = "0xC7EDB8", VA = "0xC7EDB8")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xC7DF5C", Offset = "0xC7DF5C", VA = "0xC7DF5C")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xCA48D8", Offset = "0xCA48D8", VA = "0xCA48D8")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xC9D8FC", Offset = "0xC9D8FC", VA = "0xC9D8FC")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xC8B568", Offset = "0xC8B568", VA = "0xC8B568")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xC8D4BC", Offset = "0xC8D4BC", VA = "0xC8D4BC")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xC8D218", Offset = "0xC8D218", VA = "0xC8D218")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xC8B944", Offset = "0xC8B944", VA = "0xC8B944")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xC976C0", Offset = "0xC976C0", VA = "0xC976C0")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xCA4C30", Offset = "0xCA4C30", VA = "0xCA4C30")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xCA14D8", Offset = "0xCA14D8", VA = "0xCA14D8")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0xC7ECA8", Offset = "0xC7ECA8", VA = "0xC7ECA8")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xC78CBC", Offset = "0xC78CBC", VA = "0xC78CBC")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0xC79ACC", Offset = "0xC79ACC", VA = "0xC79ACC")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xC794B8", Offset = "0xC794B8", VA = "0xC794B8")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xC80534", Offset = "0xC80534", VA = "0xC80534")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xC7DFFC", Offset = "0xC7DFFC", VA = "0xC7DFFC")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0xCA4EA0", Offset = "0xCA4EA0", VA = "0xCA4EA0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xCA50A8", Offset = "0xCA50A8", VA = "0xCA50A8")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xCA51F8", Offset = "0xCA51F8", VA = "0xCA51F8")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xC872AC", Offset = "0xC872AC", VA = "0xC872AC")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xC8723C", Offset = "0xC8723C", VA = "0xC8723C")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xCA5350", Offset = "0xCA5350", VA = "0xCA5350")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xCA5598", Offset = "0xCA5598", VA = "0xCA5598")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xC874C0", Offset = "0xC874C0", VA = "0xC874C0")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xC87450", Offset = "0xC87450", VA = "0xC87450")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xCA5600", Offset = "0xCA5600", VA = "0xCA5600")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xCA572C", Offset = "0xCA572C", VA = "0xCA572C")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xC876D4", Offset = "0xC876D4", VA = "0xC876D4")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xC87664", Offset = "0xC87664", VA = "0xC87664")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xCA5794", Offset = "0xCA5794", VA = "0xCA5794")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xCA5854", Offset = "0xCA5854", VA = "0xCA5854")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xC88018", Offset = "0xC88018", VA = "0xC88018")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xC87FA8", Offset = "0xC87FA8", VA = "0xC87FA8")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xCA58BC", Offset = "0xCA58BC", VA = "0xCA58BC")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xCA597C", Offset = "0xCA597C", VA = "0xCA597C")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0xC88440", Offset = "0xC88440", VA = "0xC88440")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0xC883D0", Offset = "0xC883D0", VA = "0xC883D0")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0xCA59E4", Offset = "0xCA59E4", VA = "0xCA59E4")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0xCA5AA4", Offset = "0xCA5AA4", VA = "0xCA5AA4")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0xC8822C", Offset = "0xC8822C", VA = "0xC8822C")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xC881BC", Offset = "0xC881BC", VA = "0xC881BC")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xCA5B0C", Offset = "0xCA5B0C", VA = "0xCA5B0C")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xCA5BD0", Offset = "0xCA5BD0", VA = "0xCA5BD0")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0xC87E04", Offset = "0xC87E04", VA = "0xC87E04")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xC87D94", Offset = "0xC87D94", VA = "0xC87D94")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0xCA5C38", Offset = "0xCA5C38", VA = "0xCA5C38")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xCA5CF8", Offset = "0xCA5CF8", VA = "0xCA5CF8")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xC87BF0", Offset = "0xC87BF0", VA = "0xC87BF0")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xC87B80", Offset = "0xC87B80", VA = "0xC87B80")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xCA5D60", Offset = "0xCA5D60", VA = "0xCA5D60")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xCA5E20", Offset = "0xCA5E20", VA = "0xCA5E20")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xC86650", Offset = "0xC86650", VA = "0xC86650")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xC865E0", Offset = "0xC865E0", VA = "0xC865E0")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xCA5E88", Offset = "0xCA5E88", VA = "0xCA5E88")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xCA5F48", Offset = "0xCA5F48", VA = "0xCA5F48")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xC86814", Offset = "0xC86814", VA = "0xC86814")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xC86B8C", Offset = "0xC86B8C", VA = "0xC86B8C")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xCA6078", Offset = "0xCA6078", VA = "0xCA6078")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xC86BFC", Offset = "0xC86BFC", VA = "0xC86BFC")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xCA5FB8", Offset = "0xCA5FB8", VA = "0xCA5FB8")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xC86DC0", Offset = "0xC86DC0", VA = "0xC86DC0")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xCA61A0", Offset = "0xCA61A0", VA = "0xCA61A0")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xC86E30", Offset = "0xC86E30", VA = "0xC86E30")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xCA60E0", Offset = "0xCA60E0", VA = "0xCA60E0")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xCA6208", Offset = "0xCA6208", VA = "0xCA6208")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0xC879FC", Offset = "0xC879FC", VA = "0xC879FC")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xCA6278", Offset = "0xCA6278", VA = "0xCA6278")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xC87878", Offset = "0xC87878", VA = "0xC87878")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xCA62E8", Offset = "0xCA62E8", VA = "0xCA62E8")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0xC86A04", Offset = "0xC86A04", VA = "0xC86A04")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xCA6368", Offset = "0xCA6368", VA = "0xCA6368")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0xC8707C", Offset = "0xC8707C", VA = "0xC8707C")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xC86FF4", Offset = "0xC86FF4", VA = "0xC86FF4")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xCA63E8", Offset = "0xCA63E8", VA = "0xCA63E8")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xC80C54", Offset = "0xC80C54", VA = "0xC80C54")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xC7E72C", Offset = "0xC7E72C", VA = "0xC7E72C")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xCA6550", Offset = "0xCA6550", VA = "0xCA6550")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xCA6714", Offset = "0xCA6714", VA = "0xCA6714")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xC80E04", Offset = "0xC80E04", VA = "0xC80E04")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xC8F91C", Offset = "0xC8F91C", VA = "0xC8F91C")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xC8FD5C", Offset = "0xC8FD5C", VA = "0xC8FD5C")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xCA6858", Offset = "0xCA6858", VA = "0xCA6858")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xC806D8", Offset = "0xC806D8", VA = "0xC806D8")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xC808EC", Offset = "0xC808EC", VA = "0xC808EC")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xC7E5A0", Offset = "0xC7E5A0", VA = "0xC7E5A0")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xCA6B44", Offset = "0xCA6B44", VA = "0xCA6B44")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xC8D794", Offset = "0xC8D794", VA = "0xC8D794")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xC8F5B0", Offset = "0xC8F5B0", VA = "0xC8F5B0")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xCA6C98", Offset = "0xCA6C98", VA = "0xCA6C98")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xCA6DF0", Offset = "0xCA6DF0", VA = "0xCA6DF0")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xCA6F48", Offset = "0xCA6F48", VA = "0xCA6F48")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xC9C524", Offset = "0xC9C524", VA = "0xC9C524")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xC9C650", Offset = "0xC9C650", VA = "0xC9C650")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xC72DE8", Offset = "0xC72DE8", VA = "0xC72DE8")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xC72C2C", Offset = "0xC72C2C", VA = "0xC72C2C")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xC7631C", Offset = "0xC7631C", VA = "0xC7631C")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xCA73A0", Offset = "0xCA73A0", VA = "0xCA73A0")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xCA5260", Offset = "0xCA5260", VA = "0xCA5260")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xC70EA4", Offset = "0xC70EA4", VA = "0xC70EA4")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xC71494", Offset = "0xC71494", VA = "0xC71494")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xCA75CC", Offset = "0xCA75CC", VA = "0xCA75CC")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xCA77FC", Offset = "0xCA77FC", VA = "0xCA77FC")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xCA7A2C", Offset = "0xCA7A2C", VA = "0xCA7A2C")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xCA7C5C", Offset = "0xCA7C5C", VA = "0xCA7C5C")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xCA8040", Offset = "0xCA8040", VA = "0xCA8040")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xCA81D4", Offset = "0xCA81D4", VA = "0xCA81D4")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xCA826C", Offset = "0xCA826C", VA = "0xCA826C")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xCA0F80", Offset = "0xCA0F80", VA = "0xCA0F80")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xC9F7AC", Offset = "0xC9F7AC", VA = "0xC9F7AC")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xCA7EAC", Offset = "0xCA7EAC", VA = "0xCA7EAC")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xCA835C", Offset = "0xCA835C", VA = "0xCA835C")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xC9DE70", Offset = "0xC9DE70", VA = "0xC9DE70")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xCA8698", Offset = "0xCA8698", VA = "0xCA8698")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xCA25D4", Offset = "0xCA25D4", VA = "0xCA25D4")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xCA97AC", Offset = "0xCA97AC", VA = "0xCA97AC")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xCA99C8", Offset = "0xCA99C8", VA = "0xCA99C8")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xCA9B40", Offset = "0xCA9B40", VA = "0xCA9B40")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0xCA9CB8", Offset = "0xCA9CB8", VA = "0xCA9CB8")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xCA9E30", Offset = "0xCA9E30", VA = "0xCA9E30")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0xCA9FA8", Offset = "0xCA9FA8", VA = "0xCA9FA8")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x40004C7")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x40004C8")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x40004C9")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x40004CA")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x40004CB")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x40004CC")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x40004CD")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x40004CE")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x40004CF")]
		public const string Separator = ";";

		[Token(Token = "0x170000E4")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xE4149C", Offset = "0xE4149C", VA = "0xE4149C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xE41510", Offset = "0xE41510", VA = "0xE41510")]
			set
			{
			}
		}

		[Token(Token = "0x170000E5")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0xE4164C", Offset = "0xE4164C", VA = "0xE4164C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0xE416C0", Offset = "0xE416C0", VA = "0xE416C0")]
			set
			{
			}
		}

		[Token(Token = "0x170000E6")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xE4196C", Offset = "0xE4196C", VA = "0xE4196C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xE419FC", Offset = "0xE419FC", VA = "0xE419FC")]
			set
			{
			}
		}

		[Token(Token = "0x170000E7")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xE41B30", Offset = "0xE41B30", VA = "0xE41B30")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xE41BB8", Offset = "0xE41BB8", VA = "0xE41BB8")]
			set
			{
			}
		}

		[Token(Token = "0x170000E8")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0xE41CE4", Offset = "0xE41CE4", VA = "0xE41CE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0xE41D74", Offset = "0xE41D74", VA = "0xE41D74")]
			set
			{
			}
		}

		[Token(Token = "0x170000E9")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0xE41EA8", Offset = "0xE41EA8", VA = "0xE41EA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0xE41F30", Offset = "0xE41F30", VA = "0xE41F30")]
			set
			{
			}
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xE412B8", Offset = "0xE412B8", VA = "0xE412B8")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xE41448", Offset = "0xE41448", VA = "0xE41448")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0xE41564", Offset = "0xE41564", VA = "0xE41564")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0xE415F8", Offset = "0xE415F8", VA = "0xE415F8")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0xE41714", Offset = "0xE41714", VA = "0xE41714")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0xE418D8", Offset = "0xE418D8", VA = "0xE418D8")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xE4205C", Offset = "0xE4205C", VA = "0xE4205C")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x2000179")]
		public class CustomEventSelection
		{
			[Token(Token = "0x400083A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x400083B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0xE4BD10", Offset = "0xE4BD10", VA = "0xE4BD10")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200017A")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x400083C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xE4BD50", Offset = "0xE4BD50", VA = "0xE4BD50")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x200017B")]
		public enum MAItemType
		{
			[Token(Token = "0x400083F")]
			SoundGroups,
			[Token(Token = "0x4000840")]
			CustomEvents
		}

		[Token(Token = "0x200017C")]
		public enum TransferMode
		{
			[Token(Token = "0x4000842")]
			None,
			[Token(Token = "0x4000843")]
			Import,
			[Token(Token = "0x4000844")]
			Export
		}

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xE4BB04", Offset = "0xE4BB04", VA = "0xE4BB04")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xE4BB70", Offset = "0xE4BB70", VA = "0xE4BB70")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public static class AmbientUtil
	{
		[Token(Token = "0x40004E6")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x40004E7")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x40004E8")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x40004E9")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x170000EA")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0xC73888", Offset = "0xC73888", VA = "0xC73888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xC730C4", Offset = "0xC730C4", VA = "0xC730C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0xC73EF8", Offset = "0xC73EF8", VA = "0xC73EF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xC72E94", Offset = "0xC72E94", VA = "0xC72E94")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xC73018", Offset = "0xC73018", VA = "0xC73018")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xC72D4C", Offset = "0xC72D4C", VA = "0xC72D4C")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xC737FC", Offset = "0xC737FC", VA = "0xC737FC")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xC72E9C", Offset = "0xC72E9C", VA = "0xC72E9C")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xC73CEC", Offset = "0xC73CEC", VA = "0xC73CEC")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xC73E14", Offset = "0xC73E14", VA = "0xC73E14")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xC74004", Offset = "0xC74004", VA = "0xC74004")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xC7417C", Offset = "0xC7417C", VA = "0xC7417C")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A5")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xC7767C", Offset = "0xC7767C", VA = "0xC7767C")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xC77700", Offset = "0xC77700", VA = "0xC77700")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xC77AA4", Offset = "0xC77AA4", VA = "0xC77AA4")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xC77D38", Offset = "0xC77D38", VA = "0xC77D38")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xC7801C", Offset = "0xC7801C", VA = "0xC7801C")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xC782B0", Offset = "0xC782B0", VA = "0xC782B0")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xC78594", Offset = "0xC78594", VA = "0xC78594")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xC78798", Offset = "0xC78798", VA = "0xC78798")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xC7899C", Offset = "0xC7899C", VA = "0xC7899C")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xC78C48", Offset = "0xC78C48", VA = "0xC78C48")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0xC78EC4", Offset = "0xC78EC4", VA = "0xC78EC4")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xC79110", Offset = "0xC79110", VA = "0xC79110")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xC79444", Offset = "0xC79444", VA = "0xC79444")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xC79738", Offset = "0xC79738", VA = "0xC79738")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xC797AC", Offset = "0xC797AC", VA = "0xC797AC")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xC79A58", Offset = "0xC79A58", VA = "0xC79A58")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xC79CD4", Offset = "0xC79CD4", VA = "0xC79CD4")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xC79F20", Offset = "0xC79F20", VA = "0xC79F20")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A6")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170000EE")]
		public Transform Trans
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0xC7A1AC", Offset = "0xC7A1AC", VA = "0xC7A1AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xC7A23C", Offset = "0xC7A23C", VA = "0xC7A23C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xC7A24C", Offset = "0xC7A24C", VA = "0xC7A24C")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public static class AudioUtil
	{
		[Token(Token = "0x40004EF")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x40004F0")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x40004F1")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000EF")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0xC7A314", Offset = "0xC7A314", VA = "0xC7A314")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F0")]
		public static float FrameTime
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0xC7A31C", Offset = "0xC7A31C", VA = "0xC7A31C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F1")]
		public static float Time
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xC7A324", Offset = "0xC7A324", VA = "0xC7A324")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F2")]
		public static int FrameCount
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0xC7A32C", Offset = "0xC7A32C", VA = "0xC7A32C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xC7A254", Offset = "0xC7A254", VA = "0xC7A254")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0xC7A2BC", Offset = "0xC7A2BC", VA = "0xC7A2BC")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xC7A2E8", Offset = "0xC7A2E8", VA = "0xC7A2E8")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0xC7A334", Offset = "0xC7A334", VA = "0xC7A334")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xC7A384", Offset = "0xC7A384", VA = "0xC7A384")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xC7A448", Offset = "0xC7A448", VA = "0xC7A448")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xC7A4FC", Offset = "0xC7A4FC", VA = "0xC7A4FC")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xC7A574", Offset = "0xC7A574", VA = "0xC7A574")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xC75050", Offset = "0xC75050", VA = "0xC75050")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xC7A5E8", Offset = "0xC7A5E8", VA = "0xC7A5E8")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xC7A634", Offset = "0xC7A634", VA = "0xC7A634")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xC7A6C4", Offset = "0xC7A6C4", VA = "0xC7A6C4")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xC76E48", Offset = "0xC76E48", VA = "0xC76E48")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xC7A7AC", Offset = "0xC7A7AC", VA = "0xC7A7AC")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xC7A848", Offset = "0xC7A848", VA = "0xC7A848")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xC7A884", Offset = "0xC7A884", VA = "0xC7A884")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xC7A894", Offset = "0xC7A894", VA = "0xC7A894")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xC7A8E0", Offset = "0xC7A8E0", VA = "0xC7A8E0")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xC7A8F4", Offset = "0xC7A8F4", VA = "0xC7A8F4")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000A8")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D08", Offset = "0xB11D08")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000845")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000846")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000847")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x4000848")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x17000168")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0xC7B8FC", Offset = "0xC7B8FC", VA = "0xC7B8FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000169")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EF")]
				[Address(RVA = "0xC7B96C", Offset = "0xC7B96C", VA = "0xC7B96C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0xC7B804", Offset = "0xC7B804", VA = "0xC7B804")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0xC7B830", Offset = "0xC7B830", VA = "0xC7B830", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0xC7B834", Offset = "0xC7B834", VA = "0xC7B834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0xC7B904", Offset = "0xC7B904", VA = "0xC7B904", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xC7B788", Offset = "0xC7B788", VA = "0xC7B788")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB146E4", Offset = "0xB146E4")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A9")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D18", Offset = "0xB11D18")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000849")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400084A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400084B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x1700016A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F3")]
				[Address(RVA = "0xC7BF08", Offset = "0xC7BF08", VA = "0xC7BF08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700016B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F5")]
				[Address(RVA = "0xC7BF78", Offset = "0xC7BF78", VA = "0xC7BF78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0xC7BCA8", Offset = "0xC7BCA8", VA = "0xC7BCA8")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0xC7BD38", Offset = "0xC7BD38", VA = "0xC7BD38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0xC7BD3C", Offset = "0xC7BD3C", VA = "0xC7BD3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0xC7BF10", Offset = "0xC7BF10", VA = "0xC7BF10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xC7BAC8", Offset = "0xC7BAC8", VA = "0xC7BAC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xC7BB6C", Offset = "0xC7BB6C", VA = "0xC7BB6C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0xC7BBFC", Offset = "0xC7BBFC", VA = "0xC7BBFC")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xC7BC34", Offset = "0xC7BC34", VA = "0xC7BC34")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB14748", Offset = "0xB14748")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xC7BCD4", Offset = "0xC7BCD4", VA = "0xC7BCD4")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0xC73C20", Offset = "0xC73C20", VA = "0xC73C20")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xC7BA68", Offset = "0xC7BA68", VA = "0xC7BA68")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xC7BA94", Offset = "0xC7BA94", VA = "0xC7BA94")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xC733D8", Offset = "0xC733D8", VA = "0xC733D8")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB1160C", Offset = "0xB1160C")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x200017F")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x400084D")]
			FirstEnableOnly,
			[Token(Token = "0x400084E")]
			EveryEnable
		}

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D28", Offset = "0xB11D28")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400084F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0xC7E724", Offset = "0xC7E724", VA = "0xC7E724")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0xC8123C", Offset = "0xC8123C", VA = "0xC8123C")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004F6")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000F3")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xC7F04C", Offset = "0xC7F04C", VA = "0xC7F04C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F4")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0xC80FEC", Offset = "0xC80FEC", VA = "0xC80FEC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600063E")]
			[Address(RVA = "0xC80FF4", Offset = "0xC80FF4", VA = "0xC80FF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xC7CA18", Offset = "0xC7CA18", VA = "0xC7CA18")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xC7CAE8", Offset = "0xC7CAE8", VA = "0xC7CAE8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xC7CBD8", Offset = "0xC7CBD8", VA = "0xC7CBD8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xC7CBDC", Offset = "0xC7CBDC", VA = "0xC7CBDC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xC7CAEC", Offset = "0xC7CAEC", VA = "0xC7CAEC")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xC7CCB4", Offset = "0xC7CCB4", VA = "0xC7CCB4")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xC7D1A8", Offset = "0xC7D1A8", VA = "0xC7D1A8")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xC80D94", Offset = "0xC80D94", VA = "0xC80D94")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xC7E9E0", Offset = "0xC7E9E0", VA = "0xC7E9E0")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xC80FFC", Offset = "0xC80FFC", VA = "0xC80FFC")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x400051B")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x400051C")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xC92D4C", Offset = "0xC92D4C", VA = "0xC92D4C")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xC931E8", Offset = "0xC931E8", VA = "0xC931E8")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0xC93274", Offset = "0xC93274", VA = "0xC93274")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xC933C8", Offset = "0xC933C8", VA = "0xC933C8")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xC9355C", Offset = "0xC9355C", VA = "0xC9355C")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xC936F0", Offset = "0xC936F0", VA = "0xC936F0")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xC93888", Offset = "0xC93888", VA = "0xC93888")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xC93998", Offset = "0xC93998", VA = "0xC93998")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xC93B08", Offset = "0xC93B08", VA = "0xC93B08")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xC93CCC", Offset = "0xC93CCC", VA = "0xC93CCC")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xC93E50", Offset = "0xC93E50", VA = "0xC93E50")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xC9400C", Offset = "0xC9400C", VA = "0xC9400C")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0xC94190", Offset = "0xC94190", VA = "0xC94190")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xC94298", Offset = "0xC94298", VA = "0xC94298")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0xC94428", Offset = "0xC94428", VA = "0xC94428")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xC944B4", Offset = "0xC944B4", VA = "0xC944B4")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xC94538", Offset = "0xC94538", VA = "0xC94538")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xC946C8", Offset = "0xC946C8", VA = "0xC946C8")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xC92E9C", Offset = "0xC92E9C", VA = "0xC92E9C")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xC94C8C", Offset = "0xC94C8C", VA = "0xC94C8C")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xC94D28", Offset = "0xC94D28", VA = "0xC94D28")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xC94DC4", Offset = "0xC94DC4", VA = "0xC94DC4")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0xB11620", Offset = "0xB11620")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB11620", Offset = "0xB11620")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		public enum AudioPlayType
		{
			[Token(Token = "0x4000851")]
			PlayNow,
			[Token(Token = "0x4000852")]
			Schedule,
			[Token(Token = "0x4000853")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000182")]
		public enum PlaylistStates
		{
			[Token(Token = "0x4000855")]
			NotInScene,
			[Token(Token = "0x4000856")]
			Stopped,
			[Token(Token = "0x4000857")]
			Playing,
			[Token(Token = "0x4000858")]
			Paused,
			[Token(Token = "0x4000859")]
			Crossfading
		}

		[Token(Token = "0x2000183")]
		public enum FadeMode
		{
			[Token(Token = "0x400085B")]
			None,
			[Token(Token = "0x400085C")]
			GradualFade
		}

		[Token(Token = "0x2000184")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x400085E")]
			NotDucking,
			[Token(Token = "0x400085F")]
			SetToDuck,
			[Token(Token = "0x4000860")]
			Ducked
		}

		[Token(Token = "0x2000185")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x2000186")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x2000187")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x2000188")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D38", Offset = "0xB11D38")]
		private sealed class <>c__DisplayClass104_0
		{
			[Token(Token = "0x4000861")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x6000908")]
			[Address(RVA = "0xE4340C", Offset = "0xE4340C", VA = "0xE4340C")]
			public <>c__DisplayClass104_0()
			{
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0xE4B738", Offset = "0xE4B738", VA = "0xE4B738")]
			internal bool <FindSongByAliasOrName>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0xE4B770", Offset = "0xE4B770", VA = "0xE4B770")]
			internal bool <FindSongByAliasOrName>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200018A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D48", Offset = "0xB11D48")]
		private sealed class <>c__DisplayClass114_0
		{
			[Token(Token = "0x4000862")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x600090B")]
			[Address(RVA = "0xE45C00", Offset = "0xE45C00", VA = "0xE45C00")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0xE4B87C", Offset = "0xE4B87C", VA = "0xE4B87C")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200018B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB11D58", Offset = "0xB11D58")]
		private sealed class <>c__DisplayClass144_0
		{
			[Token(Token = "0x4000863")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x600090D")]
			[Address(RVA = "0xE49058", Offset = "0xE49058", VA = "0xE49058")]
			public <>c__DisplayClass144_0()
			{
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0xE4B92C", Offset = "0xE4B92C", VA = "0xE4B92C")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x400051E")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x400051F")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x4000520")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x4000521")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000522")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000523")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private AudioSource _audio1;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private AudioSource _audio2;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string _activeSongAlias;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Transform _trans;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _willPersist;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private double? _songPauseTime;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int framesOfSongPlayed;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B44", Offset = "0xB12B44")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x231")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB12B54", Offset = "0xB12B54")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000F6")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x600069A")]
			[Address(RVA = "0xE4B11C", Offset = "0xE4B11C", VA = "0xE4B11C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F7")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0xE43018", Offset = "0xE43018", VA = "0xE43018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1484C", Offset = "0xB1484C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600069D")]
			[Address(RVA = "0xE43020", Offset = "0xE43020", VA = "0xE43020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1485C", Offset = "0xB1485C")]
			private set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0xE45010", Offset = "0xE45010", VA = "0xE45010")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000F9")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xE44098", Offset = "0xE44098", VA = "0xE44098")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0xE45C08", Offset = "0xE45C08", VA = "0xE45C08")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xE4B178", Offset = "0xE4B178", VA = "0xE4B178")]
			set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0xE4B1CC", Offset = "0xE4B1CC", VA = "0xE4B1CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0xE4B1D4", Offset = "0xE4B1D4", VA = "0xE4B1D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FD")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0xE4B1DC", Offset = "0xE4B1DC", VA = "0xE4B1DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xE4B27C", Offset = "0xE4B27C", VA = "0xE4B27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FF")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0xE4B324", Offset = "0xE4B324", VA = "0xE4B324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		public bool IsCrossFading
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xE4494C", Offset = "0xE4494C", VA = "0xE4494C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1486C", Offset = "0xB1486C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0xE44C94", Offset = "0xE44C94", VA = "0xE44C94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1487C", Offset = "0xB1487C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public bool IsFading
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0xE4B33C", Offset = "0xE4B33C", VA = "0xE4B33C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000102")]
		public float PlaylistVolume
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0xE48BA0", Offset = "0xE48BA0", VA = "0xE48BA0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xE4B35C", Offset = "0xE4B35C", VA = "0xE4B35C")]
			set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xE4910C", Offset = "0xE4910C", VA = "0xE4910C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		public bool HasPlaylist
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0xE45F20", Offset = "0xE45F20", VA = "0xE45F20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000105")]
		public string PlaylistName
		{
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0xE4B3C8", Offset = "0xE4B3C8", VA = "0xE4B3C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private bool IsMuted
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0xE437BC", Offset = "0xE437BC", VA = "0xE437BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000107")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xE46088", Offset = "0xE46088", VA = "0xE46088")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		private float CrossFadeTime
		{
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0xE44E28", Offset = "0xE44E28", VA = "0xE44E28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000109")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xE44EC4", Offset = "0xE44EC4", VA = "0xE44EC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010A")]
		public GameObject GameObj
		{
			[Token(Token = "0x60006B4")]
			[Address(RVA = "0xE46958", Offset = "0xE46958", VA = "0xE46958")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		public string ControllerName
		{
			[Token(Token = "0x60006B5")]
			[Address(RVA = "0xE4302C", Offset = "0xE4302C", VA = "0xE4302C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		public bool CanSchedule
		{
			[Token(Token = "0x60006B6")]
			[Address(RVA = "0xE44CA0", Offset = "0xE44CA0", VA = "0xE44CA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010D")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xE437CC", Offset = "0xE437CC", VA = "0xE437CC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010E")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0xE44FD4", Offset = "0xE44FD4", VA = "0xE44FD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700010F")]
		private Transform Trans
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xE436CC", Offset = "0xE436CC", VA = "0xE436CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0xE4B444", Offset = "0xE4B444", VA = "0xE4B444")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1400000C")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xE422C0", Offset = "0xE422C0", VA = "0xE422C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB147CC", Offset = "0xB147CC")]
			add
			{
			}
			[Token(Token = "0x6000657")]
			[Address(RVA = "0xE423B0", Offset = "0xE423B0", VA = "0xE423B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB147DC", Offset = "0xB147DC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xE424A0", Offset = "0xE424A0", VA = "0xE424A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB147EC", Offset = "0xB147EC")]
			add
			{
			}
			[Token(Token = "0x6000659")]
			[Address(RVA = "0xE42590", Offset = "0xE42590", VA = "0xE42590")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB147FC", Offset = "0xB147FC")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xE42680", Offset = "0xE42680", VA = "0xE42680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1480C", Offset = "0xB1480C")]
			add
			{
			}
			[Token(Token = "0x600065B")]
			[Address(RVA = "0xE42770", Offset = "0xE42770", VA = "0xE42770")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1481C", Offset = "0xB1481C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0xE42860", Offset = "0xE42860", VA = "0xE42860")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1482C", Offset = "0xB1482C")]
			add
			{
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0xE42950", Offset = "0xE42950", VA = "0xE42950")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1483C", Offset = "0xB1483C")]
			remove
			{
			}
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xE42A40", Offset = "0xE42A40", VA = "0xE42A40")]
		private void Awake()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xE43074", Offset = "0xE43074", VA = "0xE43074")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xE432AC", Offset = "0xE432AC", VA = "0xE432AC")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xE43414", Offset = "0xE43414", VA = "0xE43414")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xE431E4", Offset = "0xE431E4", VA = "0xE431E4")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xE434B8", Offset = "0xE434B8", VA = "0xE434B8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0xE4375C", Offset = "0xE4375C", VA = "0xE4375C")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xE438B4", Offset = "0xE438B4", VA = "0xE438B4")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0xE43D78", Offset = "0xE43D78", VA = "0xE43D78")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xE43E68", Offset = "0xE43E68", VA = "0xE43E68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xE44178", Offset = "0xE44178", VA = "0xE44178")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xE44184", Offset = "0xE44184", VA = "0xE44184")]
		private void Update()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xE45A7C", Offset = "0xE45A7C", VA = "0xE45A7C")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xE45DC4", Offset = "0xE45DC4", VA = "0xE45DC4")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xE45F30", Offset = "0xE45F30", VA = "0xE45F30")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0xE45FD4", Offset = "0xE45FD4", VA = "0xE45FD4")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0xE437C4", Offset = "0xE437C4", VA = "0xE437C4")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0xE46080", Offset = "0xE46080", VA = "0xE46080")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0xE46218", Offset = "0xE46218", VA = "0xE46218")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0xE46434", Offset = "0xE46434", VA = "0xE46434")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xE43C3C", Offset = "0xE43C3C", VA = "0xE43C3C")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xE46F1C", Offset = "0xE46F1C", VA = "0xE46F1C")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xE47044", Offset = "0xE47044", VA = "0xE47044")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xE470D0", Offset = "0xE470D0", VA = "0xE470D0")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xE472D4", Offset = "0xE472D4", VA = "0xE472D4")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xE47B48", Offset = "0xE47B48", VA = "0xE47B48")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xE47CA0", Offset = "0xE47CA0", VA = "0xE47CA0")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xE47D2C", Offset = "0xE47D2C", VA = "0xE47D2C")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xE47EE0", Offset = "0xE47EE0", VA = "0xE47EE0")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xE47F7C", Offset = "0xE47F7C", VA = "0xE47F7C")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xE4818C", Offset = "0xE4818C", VA = "0xE4818C")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xE48334", Offset = "0xE48334", VA = "0xE48334")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xE486E4", Offset = "0xE486E4", VA = "0xE486E4")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xE489F4", Offset = "0xE489F4", VA = "0xE489F4")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xE48B64", Offset = "0xE48B64", VA = "0xE48B64")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xE43AF4", Offset = "0xE43AF4", VA = "0xE43AF4")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xE48C10", Offset = "0xE48C10", VA = "0xE48C10")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xE48D6C", Offset = "0xE48D6C", VA = "0xE48D6C")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xE46890", Offset = "0xE46890", VA = "0xE46890")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xE48CE0", Offset = "0xE48CE0", VA = "0xE48CE0")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xE48E98", Offset = "0xE48E98", VA = "0xE48E98")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0xE48F7C", Offset = "0xE48F7C", VA = "0xE48F7C")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xE45130", Offset = "0xE45130", VA = "0xE45130")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0xE43698", Offset = "0xE43698", VA = "0xE43698")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xE437F4", Offset = "0xE437F4", VA = "0xE437F4")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xE44EFC", Offset = "0xE44EFC", VA = "0xE44EFC")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xE47948", Offset = "0xE47948", VA = "0xE47948")]
		private void FillClips()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xE4738C", Offset = "0xE4738C", VA = "0xE4738C")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xE49E48", Offset = "0xE49E48", VA = "0xE49E48")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xE491B4", Offset = "0xE491B4", VA = "0xE491B4")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xE4A11C", Offset = "0xE4A11C", VA = "0xE4A11C")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xE4832C", Offset = "0xE4832C", VA = "0xE4832C")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xE4521C", Offset = "0xE4521C", VA = "0xE4521C")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xE49F18", Offset = "0xE49F18", VA = "0xE49F18")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xE4A948", Offset = "0xE4A948", VA = "0xE4A948")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xE469E8", Offset = "0xE469E8", VA = "0xE469E8")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xE4A000", Offset = "0xE4A000", VA = "0xE4A000")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xE44954", Offset = "0xE44954", VA = "0xE44954")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xE44D3C", Offset = "0xE44D3C", VA = "0xE44D3C")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xE45958", Offset = "0xE45958", VA = "0xE45958")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0xE49060", Offset = "0xE49060", VA = "0xE49060")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xE4B364", Offset = "0xE4B364", VA = "0xE4B364")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xE4B4A4", Offset = "0xE4B4A4", VA = "0xE4B4A4")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xE4B620", Offset = "0xE4B620", VA = "0xE4B620")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1488C", Offset = "0xB1488C")]
		private bool <FindOtherControllerInSameSyncGroup>b__143_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xE4B728", Offset = "0xE4B728", VA = "0xE4B728")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB1489C", Offset = "0xB1489C")]
		private bool <FinishLoadingNewSong>b__151_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AE")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x4000576")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x4000577")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x17000111")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0xE53F04", Offset = "0xE53F04", VA = "0xE53F04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000112")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xE53F90", Offset = "0xE53F90", VA = "0xE53F90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000113")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x60006C0")]
			[Address(RVA = "0xE53FE4", Offset = "0xE53FE4", VA = "0xE53FE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000114")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0xE53F88", Offset = "0xE53F88", VA = "0xE53F88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0xE54038", Offset = "0xE54038", VA = "0xE54038")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xE4CAF8", Offset = "0xE4CAF8", VA = "0xE4CAF8")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public static class UtilStrings
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xE54040", Offset = "0xE54040", VA = "0xE54040")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xE540C4", Offset = "0xE540C4", VA = "0xE540C4")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x20000B0")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xC917B0", Offset = "0xC917B0", VA = "0xC917B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xC917B4", Offset = "0xC917B4", VA = "0xC917B4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xC918B4", Offset = "0xC918B4", VA = "0xC918B4")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xC918BC", Offset = "0xC918BC", VA = "0xC918BC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xC91924", Offset = "0xC91924", VA = "0xC91924")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xC919CC", Offset = "0xC919CC", VA = "0xC919CC")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xC919D4", Offset = "0xC919D4", VA = "0xC919D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xC91AB4", Offset = "0xC91AB4", VA = "0xC91AB4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xC91C68", Offset = "0xC91C68", VA = "0xC91C68")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xC91C70", Offset = "0xC91C70", VA = "0xC91C70")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xC91CDC", Offset = "0xC91CDC", VA = "0xC91CDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xC91E90", Offset = "0xC91E90", VA = "0xC91E90")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xC91E98", Offset = "0xC91E98", VA = "0xC91E98")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xC91F44", Offset = "0xC91F44", VA = "0xC91F44")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xC91F4C", Offset = "0xC91F4C", VA = "0xC91F4C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xC91FDC", Offset = "0xC91FDC", VA = "0xC91FDC")]
		private void Update()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xC92104", Offset = "0xC92104", VA = "0xC92104")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xC9210C", Offset = "0xC9210C", VA = "0xC9210C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xC921B8", Offset = "0xC921B8", VA = "0xC921B8")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x4000584")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xC921C0", Offset = "0xC921C0", VA = "0xC921C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xC92250", Offset = "0xC92250", VA = "0xC92250")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xC92254", Offset = "0xC92254", VA = "0xC92254")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xC92258", Offset = "0xC92258", VA = "0xC92258")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xC9225C", Offset = "0xC9225C", VA = "0xC9225C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xC924B8", Offset = "0xC924B8", VA = "0xC924B8")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x17000116")]
		private bool PlayerActive
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0xC924F8", Offset = "0xC924F8", VA = "0xC924F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xC924C8", Offset = "0xC924C8", VA = "0xC924C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xC92528", Offset = "0xC92528", VA = "0xC92528")]
		private void Update()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xC925A8", Offset = "0xC925A8", VA = "0xC925A8")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xC925B0", Offset = "0xC925B0", VA = "0xC925B0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xC925B4", Offset = "0xC925B4", VA = "0xC925B4")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xC92714", Offset = "0xC92714", VA = "0xC92714")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xC92794", Offset = "0xC92794", VA = "0xC92794")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xC925B8", Offset = "0xC925B8", VA = "0xC925B8", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xC928D4", Offset = "0xC928D4", VA = "0xC928D4", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xC929E4", Offset = "0xC929E4", VA = "0xC929E4", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xC92718", Offset = "0xC92718", VA = "0xC92718", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xC92870", Offset = "0xC92870", VA = "0xC92870", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xC92A78", Offset = "0xC92A78", VA = "0xC92A78", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xC92BB0", Offset = "0xC92BB0", VA = "0xC92BB0")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xC92C98", Offset = "0xC92C98", VA = "0xC92C98")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xC92D44", Offset = "0xC92D44", VA = "0xC92D44")]
		public MA_TestUI()
		{
		}
	}
}
