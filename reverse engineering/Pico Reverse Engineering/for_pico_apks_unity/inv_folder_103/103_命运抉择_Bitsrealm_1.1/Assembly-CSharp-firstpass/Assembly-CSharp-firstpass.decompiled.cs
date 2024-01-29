using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using DarkTonic.MasterAudio;
using IniParser.Model;
using IniParser.Model.Formatting;
using IniParser.Parser;
using KEngine;
using MiniJSON;
using TableML;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Networking;
using UnityEngine.Profiling;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyVersion("0.0.0.0")]
public struct IntIntPair
{
	public int key;

	public int value;
}
public struct IntFloatPair
{
	public int key;

	public float value;
}
public struct AlbumItem
{
	public uint id;

	public string image_url;

	public string image_thumb_url;

	public uint type;
}
public struct ConfigItem
{
	public int PlayType;

	public string Value;

	public override string ToString()
	{
		return PlayType + "+" + Value.ToString();
	}
}
public struct CustomAvatarData
{
	public string avatar_name;

	public ulong res_id;

	public string icon_url;

	public string res_url;
}
public struct ActorData
{
	public uint actor_type;

	public ulong actor_uuid;

	public ulong home_uuid;

	public string actor_name;

	public int race;

	public List<IntFloatPair> dnas;

	public List<IntIntPair> wardrobe;

	public CustomAvatarData custom_avatar_data;

	public bool has_profile_photo;

	public AlbumItem profile_photo;
}
public struct PlayerTransform
{
	public Vector3 pos;

	public Vector3 dir;
}
public struct PlayerInfo
{
	public ulong player_id;

	public PlayerTransform player_transform;

	public ActorData actor_data;

	public uint cam_view_type;
}
public struct RoomInfo
{
	public ulong room_id;

	public string room_name;

	public bool has_pwd;

	public ulong world_id;

	public uint capacity;

	public ulong owner_id;

	public uint num_of_people;

	public string owner_nick_name;

	public string world_name;

	public uint tag;

	public string loader_script;

	public string res_url;
}
public struct DynamicObjectInfo
{
	public ulong obj_id;

	public Vector3 pos;

	public Vector3 dir;

	public uint obj_type;

	public ulong owner_id;

	public string res_url;

	public ulong room_id;

	public ulong res_id;
}
public enum TextResType
{
	LUA,
	RAW_CFG,
	XLS
}
public class BaseUtil
{
	private static bool enableEncrypting = true;

	private static byte[] Keys = new byte[8] { 18, 52, 86, 120, 144, 171, 205, 239 };

	private static long encryptKey = 40028789L;

	private static bool isLuaFinished = false;

	private static bool isRawCfgFinished = false;

	private static bool isXlsCfgFinished = false;

	public static byte[] EncryptText(byte[] encryptBytes)
	{
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(encryptKey.ToString().Substring(0, 8));
			byte[] keys = Keys;
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateEncryptor(bytes, keys), CryptoStreamMode.Write);
			cryptoStream.Write(encryptBytes, 0, encryptBytes.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch
		{
			return encryptBytes;
		}
	}

	public static byte[] DecryptBytes(byte[] decryptBytes)
	{
		if (!enableEncrypting)
		{
			return decryptBytes;
		}
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(encryptKey.ToString());
			byte[] keys = Keys;
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, dESCryptoServiceProvider.CreateDecryptor(bytes, keys), CryptoStreamMode.Write);
			cryptoStream.Write(decryptBytes, 0, decryptBytes.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch
		{
			return decryptBytes;
		}
	}

	public static byte[] DecryptText(byte[] decryptBytes)
	{
		if (!enableEncrypting)
		{
			return decryptBytes;
		}
		try
		{
			return DecryptBytes(decryptBytes);
		}
		catch
		{
			return decryptBytes;
		}
	}

	public static string ReadFileText(string path)
	{
		if (!File.Exists(path))
		{
			return null;
		}
		return File.ReadAllText(path);
	}

	public static byte[] ReadFileBytes(string path)
	{
		if (!File.Exists(path))
		{
			return null;
		}
		return File.ReadAllBytes(path);
	}

	public static void WriteFileText(string path, string str)
	{
		File.WriteAllText(path, str);
	}

	public static void WriteFileBytes(string path, byte[] bytes)
	{
		File.WriteAllBytes(path, bytes);
	}

	public static void Encrypting(string fileName)
	{
		if (enableEncrypting)
		{
			byte[] bytes = EncryptText(ReadFileBytes(fileName));
			WriteFileBytes(fileName, bytes);
		}
	}

	public static void ConfigProcessFinished(TextResType type)
	{
	}
}
[AudioScriptOrder(-10)]
public class ListenerFollower : MonoBehaviour
{
	private Transform _transToFollow;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	public SphereCollider Trigger
	{
		get
		{
			if (_collider != null)
			{
				return _collider;
			}
			_collider = GameObj.AddComponent<SphereCollider>();
			_collider.isTrigger = true;
			return _collider;
		}
	}

	public GameObject GameObj
	{
		get
		{
			if (_go != null)
			{
				return _go;
			}
			_go = base.gameObject;
			return _go;
		}
	}

	public Transform Trans
	{
		get
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			return _trans;
		}
	}

	private void Awake()
	{
		_ = Trigger == null;
	}

	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
		_transToFollow = transToFollow;
		_goToFollow = transToFollow.gameObject;
		Trigger.radius = trigRadius;
	}

	public void ManualUpdate()
	{
		BatchOcclusionRaycasts();
		if (!(_transToFollow == null) && DTMonoHelper.IsActive(_goToFollow))
		{
			Trans.position = _transToFollow.position;
		}
	}

	private void BatchOcclusionRaycasts()
	{
		if (!MasterAudio.Instance.useOcclusion)
		{
			return;
		}
		int num = 0;
		while (num < MasterAudio.Instance.occlusionMaxRayCastsPerFrame && MasterAudio.HasQueuedOcclusionRays())
		{
			SoundGroupVariationUpdater soundGroupVariationUpdater = MasterAudio.OldestQueuedOcclusionRay();
			if (!(soundGroupVariationUpdater == null) && soundGroupVariationUpdater.enabled && soundGroupVariationUpdater.RayCastForOcclusion())
			{
				num++;
			}
		}
	}
}
public static class OculusAudioHelper
{
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return false;
	}

	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
public static class ResonanceAudioHelper
{
	public static bool ResonanceAudioOptionExists => true;

	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return false;
	}

	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
public class TransformFollower : MonoBehaviour
{
	[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
	public Transform RuntimeFollowingTransform;

	private GameObject _goToFollow;

	private Transform _trans;

	private GameObject _go;

	private SphereCollider _collider;

	private string _soundType;

	private string _variationName;

	private bool _willFollowSource;

	private bool _isInsideTrigger;

	private bool _hasPlayedSound;

	private float _playVolume;

	private bool _positionAtClosestColliderPoint;

	private MasterAudio.AmbientSoundExitMode _exitMode;

	private float _exitFadeTime;

	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	private float _reEnterFadeTime;

	private readonly List<Collider> _actorColliders = new List<Collider>();

	private Vector3 _lastListenerPos = new Vector3(float.MinValue, float.MinValue, float.MinValue);

	private readonly Dictionary<Collider, Vector3> _lastPositionByCollider = new Dictionary<Collider, Vector3>();

	private PlaySoundResult playingVariation;

	private PlaySoundResult fadingVariation;

	public SphereCollider Trigger
	{
		get
		{
			if (_collider != null)
			{
				return _collider;
			}
			_collider = GameObj.AddComponent<SphereCollider>();
			_collider.isTrigger = true;
			return _collider;
		}
	}

	public GameObject GameObj
	{
		get
		{
			if (_go != null)
			{
				return _go;
			}
			_go = base.gameObject;
			return _go;
		}
	}

	public Transform Trans
	{
		get
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			return _trans;
		}
	}

	private void Awake()
	{
		if (!(Trigger == null))
		{
			_ = _actorColliders.Count;
		}
		if (!(_lastListenerPos == Vector3.zero) && playingVariation == null)
		{
			_ = _positionAtClosestColliderPoint;
		}
	}

	private void OnDisable()
	{
		AmbientUtil.RemoveTransformFollower(this);
		PerformTriggerExit();
	}

	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
		RuntimeFollowingTransform = transToFollow;
		_goToFollow = transToFollow.gameObject;
		Trigger.radius = trigRadius;
		_soundType = soundType;
		_variationName = variationName;
		_playVolume = volume;
		_willFollowSource = willFollowSource;
		_exitMode = exitMode;
		_exitFadeTime = exitFadeTime;
		_reEnterMode = reEnterMode;
		_reEnterFadeTime = reEnterFadeTime;
		_lastPositionByCollider.Clear();
		if (useTopCollider)
		{
			Collider component = transToFollow.GetComponent<Collider>();
			if (component != null)
			{
				_actorColliders.Add(component);
				_lastPositionByCollider.Add(component, transToFollow.position);
			}
		}
		if (useChildColliders && transToFollow != null)
		{
			for (int i = 0; i < transToFollow.childCount; i++)
			{
				Collider component2 = transToFollow.GetChild(i).GetComponent<Collider>();
				if (component2 != null)
				{
					_actorColliders.Add(component2);
					_lastPositionByCollider.Add(component2, transToFollow.position);
				}
			}
		}
		_lastListenerPos = MasterAudio.ListenerTrans.position;
		int num = 0;
		if (_actorColliders.Count == 0 && num == 0 && positionAtClosestColliderPoint)
		{
			UnityEngine.Debug.Log("Can't follow collider of '" + transToFollow.name + "' because it doesn't have any colliders.");
			return;
		}
		_positionAtClosestColliderPoint = positionAtClosestColliderPoint;
		if (_positionAtClosestColliderPoint)
		{
			RecalcClosestColliderPosition(forceRecalc: true);
			MasterAudio.QueueTransformFollowerForColliderPositionRecalc(this);
		}
	}

	private void StopFollowing()
	{
		RuntimeFollowingTransform = null;
		UnityEngine.Object.Destroy(GameObj);
	}

	private void PlaySound()
	{
		bool flag = !string.IsNullOrEmpty(_variationName);
		bool flag2 = _positionAtClosestColliderPoint || _exitMode == MasterAudio.AmbientSoundExitMode.FadeSound;
		if (fadingVariation != null && fadingVariation.ActingVariation != null)
		{
			MasterAudio.AmbientSoundReEnterMode ambientSoundReEnterMode = _reEnterMode;
			if (!fadingVariation.ActingVariation.IsPlaying)
			{
				ambientSoundReEnterMode = MasterAudio.AmbientSoundReEnterMode.StopExistingSound;
			}
			switch (ambientSoundReEnterMode)
			{
			case MasterAudio.AmbientSoundReEnterMode.FadeInSameSound:
				fadingVariation.ActingVariation.FadeToVolume(_playVolume, _reEnterFadeTime);
				playingVariation = fadingVariation;
				fadingVariation = null;
				_hasPlayedSound = true;
				return;
			case MasterAudio.AmbientSoundReEnterMode.StopExistingSound:
				fadingVariation.ActingVariation.Stop();
				break;
			}
		}
		if (_willFollowSource)
		{
			if (flag2)
			{
				if (flag)
				{
					playingVariation = MasterAudio.PlaySound3DFollowTransform(_soundType, RuntimeFollowingTransform, _playVolume, 1f, 0f, _variationName);
				}
				else
				{
					playingVariation = MasterAudio.PlaySound3DFollowTransform(_soundType, RuntimeFollowingTransform, _playVolume);
				}
			}
			else if (flag)
			{
				MasterAudio.PlaySound3DFollowTransformAndForget(_soundType, RuntimeFollowingTransform, _playVolume, 1f, 0f, _variationName);
			}
			else
			{
				MasterAudio.PlaySound3DFollowTransformAndForget(_soundType, RuntimeFollowingTransform, _playVolume);
			}
		}
		else if (flag2)
		{
			if (flag)
			{
				playingVariation = MasterAudio.PlaySound3DAtTransform(_soundType, RuntimeFollowingTransform, _playVolume, 1f, 0f, _variationName);
			}
			else
			{
				playingVariation = MasterAudio.PlaySound3DAtTransform(_soundType, RuntimeFollowingTransform, _playVolume);
			}
		}
		else if (flag)
		{
			MasterAudio.PlaySound3DAtTransformAndForget(_soundType, RuntimeFollowingTransform, _playVolume, 1f, 0f, _variationName);
		}
		else
		{
			MasterAudio.PlaySound3DAtTransformAndForget(_soundType, RuntimeFollowingTransform, _playVolume);
		}
		fadingVariation = null;
		_hasPlayedSound = true;
	}

	public void ManualUpdate()
	{
		if (RuntimeFollowingTransform == null || !DTMonoHelper.IsActive(_goToFollow))
		{
			StopFollowing();
			return;
		}
		if (!_positionAtClosestColliderPoint)
		{
			Trans.position = RuntimeFollowingTransform.position;
		}
		if (_isInsideTrigger && !_hasPlayedSound)
		{
			PlaySound();
		}
	}

	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		Vector3 position = MasterAudio.ListenerTrans.position;
		bool flag = _lastListenerPos != position;
		Vector3 position2 = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
		bool flag2 = false;
		int count = _actorColliders.Count;
		int num = 0;
		if (count > 0)
		{
			float num2 = float.MaxValue;
			if (count == 1)
			{
				Collider collider = _actorColliders[0];
				if (collider == null)
				{
					return false;
				}
				Vector3 position3 = collider.transform.position;
				if (!forceRecalc && _lastPositionByCollider[collider] == position3 && !flag)
				{
					return false;
				}
				flag2 = true;
				position2 = collider.ClosestPoint(position);
				_lastPositionByCollider[collider] = position3;
			}
			else
			{
				for (int i = 0; i < _actorColliders.Count; i++)
				{
					Collider collider2 = _actorColliders[i];
					Vector3 position4 = collider2.transform.position;
					if (forceRecalc || !(_lastPositionByCollider[collider2] == position4) || flag)
					{
						flag2 = true;
						Vector3 vector = collider2.ClosestPoint(position);
						float sqrMagnitude = (position - vector).sqrMagnitude;
						if (sqrMagnitude < num2)
						{
							position2 = vector;
							num2 = sqrMagnitude;
						}
						_lastPositionByCollider[collider2] = position4;
					}
				}
			}
		}
		else if (num <= 0)
		{
			return false;
		}
		if (!flag2)
		{
			return false;
		}
		Trans.position = position2;
		Trans.LookAt(MasterAudio.ListenerTrans);
		if (playingVariation != null && playingVariation.ActingVariation != null)
		{
			playingVariation.ActingVariation.transform.position = position2;
		}
		_lastListenerPos = position;
		return true;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(RuntimeFollowingTransform == null) && !(other == null) && !(base.name == "~ListenerFollower~") && !(other.name != "~ListenerFollower~"))
		{
			_isInsideTrigger = true;
			PlaySound();
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (!(RuntimeFollowingTransform == null) && !(other == null) && !(other.name != "~ListenerFollower~"))
		{
			PerformTriggerExit();
		}
	}

	private void PerformTriggerExit()
	{
		_isInsideTrigger = false;
		_hasPlayedSound = false;
		if (!(MasterAudio.GrabGroup(_soundType, logIfMissing: false) == null))
		{
			switch (_exitMode)
			{
			case MasterAudio.AmbientSoundExitMode.StopSound:
				MasterAudio.StopSoundGroupOfTransform(RuntimeFollowingTransform, _soundType);
				break;
			case MasterAudio.AmbientSoundExitMode.FadeSound:
				MasterAudio.FadeOutSoundGroupOfTransform(RuntimeFollowingTransform, _soundType, _exitFadeTime);
				break;
			}
			fadingVariation = playingVariation;
			playingVariation = null;
		}
	}
}
public delegate void KCallback(object[] data, Exception err = null);
public class KSerializeMaterial : ScriptableObject
{
	public string MaterialName;

	public string ShaderName;

	public string ShaderPath;

	public List<KSerializeMaterialProperty> Props = new List<KSerializeMaterialProperty>();
}
[Serializable]
public class KSerializeMaterialProperty
{
	public enum ShaderType
	{
		Texture,
		Color,
		Range,
		Vector,
		RenderTexture
	}

	public ShaderType Type;

	public string PropName;

	public string PropValue;
}
public abstract class KBehaviour : MonoBehaviour
{
	private Transform _cachedTransform;

	private GameObject _cacheGameObject;

	protected bool IsDestroyed;

	private static bool _isApplicationQuited;

	public static Action ApplicationQuitEvent;

	private float _TimeScale = 1f;

	public Transform CachedTransform => _cachedTransform ?? (_cachedTransform = base.transform);

	public GameObject CachedGameObject => _cacheGameObject ?? (_cacheGameObject = base.gameObject);

	public static bool IsApplicationQuited => _isApplicationQuited;

	public virtual float TimeScale
	{
		get
		{
			return _TimeScale;
		}
		set
		{
			_TimeScale = value;
		}
	}

	public static event Action<KBehaviour> StaticDestroyEvent;

	public event Action<KBehaviour> DestroyEvent;

	public virtual void Delete()
	{
		Delete(0f);
	}

	public virtual void Delete(float time)
	{
		if (!IsApplicationQuited)
		{
			UnityEngine.Object.Destroy(base.gameObject, time);
		}
	}

	public virtual void DeleteSelf()
	{
		UnityEngine.Object.Destroy(this);
	}

	protected virtual void OnDestroy()
	{
		IsDestroyed = true;
		if (this.DestroyEvent != null)
		{
			this.DestroyEvent(this);
		}
		if (KBehaviour.StaticDestroyEvent != null)
		{
			KBehaviour.StaticDestroyEvent(this);
		}
	}

	private void OnApplicationQuit()
	{
		if (!_isApplicationQuited)
		{
			Log.Info("OnApplicationQuit!");
		}
		_isApplicationQuited = true;
		if (ApplicationQuitEvent != null)
		{
			ApplicationQuitEvent();
		}
	}
}
public enum UnityLayerDef
{
	Default = 0,
	TransparentFX = 1,
	IgnoreRaycast = 2,
	Water = 4,
	UI = 5
}
public interface IKTabReadble
{
	bool HasColumn(string columnName);

	int GetInteger(int row, string columnName);

	string GetString(int row, string columnName);

	string GetString(int row, int columnIndex);

	float GetFloat(int row, string columnName);

	bool GetBool(int row, string columnName);

	double GetDouble(int row, string columnName);

	uint GetUInteger(int row, string columnName);

	int GetHeight();

	int GetColumnCount();

	void Close();
}
public static class KEngineExtensions
{
	public static void SetWidth(this RectTransform rectTrans, float width)
	{
		Vector2 sizeDelta = rectTrans.sizeDelta;
		sizeDelta.x = width;
		rectTrans.sizeDelta = sizeDelta;
	}

	public static void SetHeight(this RectTransform rectTrans, float height)
	{
		Vector2 sizeDelta = rectTrans.sizeDelta;
		sizeDelta.y = height;
		rectTrans.sizeDelta = sizeDelta;
	}

	public static void SetPositionX(this Transform t, float newX)
	{
		t.position = new Vector3(newX, t.position.y, t.position.z);
	}

	public static void SetPositionY(this Transform t, float newY)
	{
		t.position = new Vector3(t.position.x, newY, t.position.z);
	}

	public static void SetLocalPositionX(this Transform t, float newX)
	{
		t.localPosition = new Vector3(newX, t.localPosition.y, t.localPosition.z);
	}

	public static void SetLocalPositionY(this Transform t, float newY)
	{
		t.localPosition = new Vector3(t.localPosition.x, newY, t.localPosition.z);
	}

	public static void SetPositionZ(this Transform t, float newZ)
	{
		t.position = new Vector3(t.position.x, t.position.y, newZ);
	}

	public static void SetLocalPositionZ(this Transform t, float newZ)
	{
		t.localPosition = new Vector3(t.localPosition.x, t.localPosition.y, newZ);
	}

	public static void SetLocalScale(this Transform t, Vector3 newScale)
	{
		t.localScale = newScale;
	}

	public static void SetLocalScaleZero(this Transform t)
	{
		t.localScale = Vector3.zero;
	}

	public static float GetPositionX(this Transform t)
	{
		return t.position.x;
	}

	public static float GetPositionY(this Transform t)
	{
		return t.position.y;
	}

	public static float GetPositionZ(this Transform t)
	{
		return t.position.z;
	}

	public static float GetLocalPositionX(this Transform t)
	{
		return t.localPosition.x;
	}

	public static float GetLocalPositionY(this Transform t)
	{
		return t.localPosition.y;
	}

	public static float GetLocalPositionZ(this Transform t)
	{
		return t.localPosition.z;
	}

	public static bool HasRigidbody(this GameObject gobj)
	{
		return gobj.GetComponent<Rigidbody>() != null;
	}

	public static bool HasAnimation(this GameObject gobj)
	{
		return gobj.GetComponent<Animation>() != null;
	}

	public static void SetSpeed(this Animation anim, float newSpeed)
	{
		anim[anim.clip.name].speed = newSpeed;
	}

	public static Vector2 ToVector2(this Vector3 vec)
	{
		return new Vector2(vec.x, vec.y);
	}

	public static byte ToByte(this string val)
	{
		byte result = 0;
		try
		{
			if (!string.IsNullOrEmpty(val))
			{
				result = Convert.ToByte(val);
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static long ToInt64(this string val)
	{
		long result = 0L;
		try
		{
			if (!string.IsNullOrEmpty(val))
			{
				result = Convert.ToInt64(val);
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static float ToFloat(this string val)
	{
		float result = 0f;
		try
		{
			if (!string.IsNullOrEmpty(val))
			{
				result = Convert.ToSingle(val);
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static int ToInt32(this string str)
	{
		int result = 0;
		try
		{
			if (!string.IsNullOrEmpty(str))
			{
				result = Convert.ToInt32(str);
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static int ToInt32(this object obj)
	{
		int result = 0;
		try
		{
			if (obj != null)
			{
				result = Convert.ToInt32(obj);
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static T GetArgForm<T>(object[] openArgs, int offset, bool isLog = true)
	{
		if (openArgs == null)
		{
			return default(T);
		}
		return openArgs.GetArg<T>(offset, isLog);
	}

	public static T GetArg<T>(this object[] openArgs, int offset, bool isLog = true)
	{
		T result;
		if (openArgs.Length - 1 >= offset)
		{
			object obj = openArgs[offset];
			if (obj == null)
			{
				result = default(T);
			}
			else
			{
				try
				{
					return (T)Convert.ChangeType(obj, typeof(T));
				}
				catch (Exception)
				{
					if (obj is string && string.IsNullOrEmpty(obj as string))
					{
						result = default(T);
					}
					else
					{
						Log.Error("[Error get from object[],  '{0}' change to type {1}", obj, typeof(T));
						result = default(T);
					}
				}
			}
		}
		else
		{
			result = default(T);
			if (isLog)
			{
				Log.Error("[GetArg] {0} args - offset: {1}", openArgs, offset);
			}
		}
		return result;
	}
}
public static class KEngineToolExtensions
{
	public delegate bool KFilterAction<T>(T t);

	public delegate bool KFilterAction<T, K>(T t, K k);

	public static void Shuffle<T>(this IList<T> list)
	{
		System.Random random = new System.Random();
		int num = list.Count;
		while (num > 1)
		{
			num--;
			int index = random.Next(num + 1);
			T value = list[index];
			list[index] = list[num];
			list[num] = value;
		}
	}

	public static T KFirstOrDefault<T>(this IEnumerable<T> source)
	{
		if (source != null)
		{
			using IEnumerator<T> enumerator = source.GetEnumerator();
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return default(T);
	}

	public static List<T> KFirst<T>(this IEnumerable<T> source, int num)
	{
		int num2 = 0;
		List<T> list = new List<T>();
		if (source != null)
		{
			foreach (T item in source)
			{
				if (++num2 > num)
				{
					break;
				}
				list.Add(item);
			}
		}
		return list;
	}

	public static List<T> KFilter<T>(this IEnumerable<T> source, KFilterAction<T> testAction)
	{
		List<T> list = new List<T>();
		if (source != null)
		{
			foreach (T item in source)
			{
				if (testAction(item))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static Dictionary<T, K> KFilter<T, K>(this IEnumerable<KeyValuePair<T, K>> source, KFilterAction<T, K> testAction)
	{
		Dictionary<T, K> dictionary = new Dictionary<T, K>();
		if (source != null)
		{
			foreach (KeyValuePair<T, K> item in source)
			{
				if (testAction(item.Key, item.Value))
				{
					dictionary.Add(item.Key, item.Value);
				}
			}
		}
		return dictionary;
	}

	public static T KLastOrDefault<T>(this IEnumerable<T> source)
	{
		T result = default(T);
		foreach (T item in source)
		{
			result = item;
		}
		return result;
	}

	public static List<T> KLast<T>(this IEnumerable<T> source, int num)
	{
		int num2 = Math.Max(0, source.KToList().Count - num);
		int num3 = 0;
		List<T> list = new List<T>();
		if (source != null)
		{
			foreach (T item in source)
			{
				if (num3 >= num2)
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static bool AddRange<T>(this HashSet<T> @this, IEnumerable<T> items)
	{
		bool flag = true;
		foreach (T item in items)
		{
			flag &= @this.Add(item);
		}
		return flag;
	}

	public static T[] KToArray<T>(this IEnumerable<T> source)
	{
		List<T> list = new List<T>();
		foreach (T item in source)
		{
			list.Add(item);
		}
		return list.ToArray();
	}

	public static List<T> KToList<T>(this IEnumerable<T> source)
	{
		List<T> list = new List<T>();
		foreach (T item in source)
		{
			list.Add(item);
		}
		return list;
	}

	public static List<T> KUnion<T>(this List<T> first, List<T> second, IEqualityComparer<T> comparer)
	{
		List<T> list = new List<T>();
		List<T> list2 = first.KToList();
		list2.AddRange(second);
		foreach (T item in list2)
		{
			bool flag = false;
			foreach (T item2 in list)
			{
				if (comparer.Equals(item2, item))
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static string KJoin<T>(this IEnumerable<T> source, string sp)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (T item in source)
		{
			if (stringBuilder.Length == 0)
			{
				stringBuilder.Append(item);
			}
			else
			{
				stringBuilder.Append(sp).Append(item);
			}
		}
		return stringBuilder.ToString();
	}

	public static bool KContains<TSource>(this IEnumerable<TSource> source, TSource value)
	{
		foreach (TSource item in source)
		{
			if (object.Equals(item, value))
			{
				return true;
			}
		}
		return false;
	}
}
public class KTabFileDef
{
	public static char[] Separators = new char[1] { '\t' };
}
public class KTabFile : IDisposable, IKTabReadble, IEnumerable<KTabFile.RowInterator>, IEnumerable
{
	public class HeaderInfo
	{
		public int ColumnIndex;

		public string HeaderName;

		public string HeaderDef;
	}

	public class RowInterator
	{
		internal KTabFile TabFile;

		public int Row { get; internal set; }

		internal RowInterator(KTabFile tabFile)
		{
			TabFile = tabFile;
		}

		public string GetString(string colName)
		{
			return TabFile.GetString(Row, colName);
		}

		public int GetInteger(string colName)
		{
			return TabFile.GetInteger(Row, colName);
		}
	}

	private readonly RowInterator _rowInteratorCache;

	private int ColCount;

	protected Dictionary<string, HeaderInfo> ColIndex = new Dictionary<string, HeaderInfo>();

	protected Dictionary<int, string[]> TabInfo = new Dictionary<int, string[]>();

	public KTabFile()
	{
		_rowInteratorCache = new RowInterator(this);
	}

	public static KTabFile LoadFromString(string content)
	{
		KTabFile kTabFile = new KTabFile();
		kTabFile.ParseString(content);
		return kTabFile;
	}

	public static KTabFile LoadFromFile(string fileFullPath)
	{
		KTabFile kTabFile = new KTabFile();
		if (kTabFile.LoadByIO(fileFullPath))
		{
			return kTabFile;
		}
		return null;
	}

	public bool LoadByIO(string fileName)
	{
		using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
		{
			StreamReader oReader;
			try
			{
				oReader = new StreamReader(stream, Encoding.UTF8);
			}
			catch
			{
				return false;
			}
			ParseReader(oReader);
		}
		return true;
	}

	protected bool ParseReader(TextReader oReader)
	{
		string text = oReader.ReadLine();
		Debuger.Assert(text != null);
		string text2 = oReader.ReadLine();
		Debuger.Assert(text2 != null);
		string[] array = text2.Split(KTabFileDef.Separators, StringSplitOptions.None);
		string[] array2 = text.Split(KTabFileDef.Separators, StringSplitOptions.None);
		string[] array3 = new string[array2.Length];
		Array.Copy(array, 0, array3, 0, array.Length);
		for (int i = 1; i <= array2.Length; i++)
		{
			string headerName = array2[i - 1];
			HeaderInfo headerInfo = new HeaderInfo
			{
				ColumnIndex = i,
				HeaderName = headerName,
				HeaderDef = array3[i - 1]
			};
			ColIndex[headerInfo.HeaderName] = headerInfo;
		}
		ColCount = array2.Length;
		string text3 = "";
		int num = 1;
		while (text3 != null)
		{
			text3 = oReader.ReadLine();
			if (text3 != null)
			{
				string[] value = text3.Split(KTabFileDef.Separators, StringSplitOptions.None);
				TabInfo[num] = value;
				num++;
			}
		}
		return true;
	}

	protected bool ParseString(string content)
	{
		using (StringReader oReader = new StringReader(content))
		{
			ParseReader(oReader);
		}
		return true;
	}

	public bool Save(string fileName)
	{
		bool result = false;
		StringBuilder stringBuilder = new StringBuilder();
		foreach (HeaderInfo value3 in ColIndex.Values)
		{
			stringBuilder.Append($"{value3.HeaderName}\t");
		}
		stringBuilder.Append("\r\n");
		foreach (HeaderInfo value4 in ColIndex.Values)
		{
			stringBuilder.Append($"{value4.HeaderDef}\t");
		}
		stringBuilder.Append("\r\n");
		foreach (KeyValuePair<int, string[]> item in TabInfo)
		{
			int num = 0;
			string[] value = item.Value;
			for (int i = 0; i < value.Length; i++)
			{
				if (string.IsNullOrEmpty(value[i]))
				{
					num++;
				}
			}
			if (num == item.Value.Length)
			{
				continue;
			}
			int num2 = 0;
			value = item.Value;
			foreach (string value2 in value)
			{
				if (num2 < ColIndex.Count)
				{
					stringBuilder.Append(value2);
					stringBuilder.Append('\t');
					num2++;
				}
			}
			stringBuilder.Append("\r\n");
		}
		string directoryName = Path.GetDirectoryName(fileName);
		if (!Directory.Exists(directoryName))
		{
			Directory.CreateDirectory(directoryName);
		}
		try
		{
			using FileStream stream = new FileStream(fileName, FileMode.Create);
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(stringBuilder);
			result = true;
		}
		catch (IOException ex)
		{
			UnityEngine.Debug.LogError("可能文件正在被Excel打开?" + ex.Message);
			result = false;
		}
		return result;
	}

	private string _GetString(int row, int column)
	{
		if (column == 0)
		{
			return string.Empty;
		}
		string[] array = TabInfo[row];
		if (column - 1 < array.Length)
		{
			return array[column - 1].ToString();
		}
		return "";
	}

	public string GetString(int row, int column)
	{
		return _GetString(row, column);
	}

	public string GetString(int row, string columnName)
	{
		if (!ColIndex.TryGetValue(columnName, out var value))
		{
			return string.Empty;
		}
		return GetString(row, value.ColumnIndex);
	}

	public int GetInteger(int row, int column)
	{
		try
		{
			return (int)float.Parse(GetString(row, column));
		}
		catch
		{
			return 0;
		}
	}

	public int GetInteger(int row, string columnName)
	{
		try
		{
			return (int)float.Parse(GetString(row, columnName));
		}
		catch
		{
			return 0;
		}
	}

	public uint GetUInteger(int row, int column)
	{
		try
		{
			return (uint)float.Parse(GetString(row, column));
		}
		catch
		{
			return 0u;
		}
	}

	public uint GetUInteger(int row, string columnName)
	{
		try
		{
			return (uint)float.Parse(GetString(row, columnName));
		}
		catch
		{
			return 0u;
		}
	}

	public double GetDouble(int row, int column)
	{
		try
		{
			return double.Parse(GetString(row, column));
		}
		catch
		{
			return 0.0;
		}
	}

	public double GetDouble(int row, string columnName)
	{
		try
		{
			return double.Parse(GetString(row, columnName));
		}
		catch
		{
			return 0.0;
		}
	}

	public float GetFloat(int row, int column)
	{
		try
		{
			return float.Parse(GetString(row, column));
		}
		catch
		{
			return 0f;
		}
	}

	public float GetFloat(int row, string columnName)
	{
		try
		{
			return float.Parse(GetString(row, columnName));
		}
		catch
		{
			return 0f;
		}
	}

	public bool GetBool(int row, int column)
	{
		return GetInteger(row, column) != 0;
	}

	public bool GetBool(int row, string columnName)
	{
		return GetInteger(row, columnName) != 0;
	}

	public bool HasColumn(string colName)
	{
		return ColIndex.ContainsKey(colName);
	}

	public int NewColumn(string colName, string defineStr = "")
	{
		Debuger.Assert(!string.IsNullOrEmpty(colName));
		HeaderInfo value = new HeaderInfo
		{
			ColumnIndex = ColIndex.Count + 1,
			HeaderName = colName,
			HeaderDef = defineStr
		};
		ColIndex.Add(colName, value);
		ColCount++;
		return ColCount;
	}

	public int NewRow()
	{
		string[] value = new string[ColCount];
		int num = TabInfo.Count + 1;
		TabInfo.Add(num, value);
		return num;
	}

	public int GetHeight()
	{
		return TabInfo.Count;
	}

	public int GetColumnCount()
	{
		return ColCount;
	}

	public int GetWidth()
	{
		return ColCount;
	}

	public bool SetValue<T>(int row, int column, T value)
	{
		if (row > TabInfo.Count || column > ColCount || row <= 0 || column <= 0)
		{
			Log.Error("Wrong row-{0} or column-{1}", row, column);
			return false;
		}
		string text = Convert.ToString(value);
		if (row == 0)
		{
			foreach (KeyValuePair<string, HeaderInfo> item in ColIndex)
			{
				if (item.Value.ColumnIndex == column)
				{
					ColIndex.Remove(item.Key);
					ColIndex[text] = item.Value;
					break;
				}
			}
		}
		string[] array = TabInfo[row];
		if (column - 1 >= array.Length)
		{
			string[] array2 = array;
			string[] array4 = (TabInfo[row] = new string[column]);
			array = array4;
			array2.CopyTo(array, 0);
		}
		array[column - 1] = text;
		return true;
	}

	public bool SetValue<T>(int row, string columnName, T value)
	{
		if (!ColIndex.TryGetValue(columnName, out var value2))
		{
			return false;
		}
		return SetValue(row, value2.ColumnIndex, value);
	}

	IEnumerator<RowInterator> IEnumerable<RowInterator>.GetEnumerator()
	{
		int num = 1;
		for (int i = num; i <= GetHeight(); i++)
		{
			_rowInteratorCache.Row = i;
			yield return _rowInteratorCache;
		}
	}

	public IEnumerator GetEnumerator()
	{
		int num = 1;
		for (int i = num; i <= GetHeight(); i++)
		{
			_rowInteratorCache.Row = i;
			yield return _rowInteratorCache;
		}
	}

	public void Dispose()
	{
		ColIndex.Clear();
		TabInfo.Clear();
	}

	public void Close()
	{
		Dispose();
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[AttributeUsage(AttributeTargets.Class)]
	public class AutoBackendAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatedAttribute : Attribute
	{
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class RelatingAttribute : Attribute
	{
	}
}
namespace MiniJSON
{
	public static class Json
	{
		private sealed class Parser : IDisposable
		{
			private enum TOKEN
			{
				NONE,
				CURLY_OPEN,
				CURLY_CLOSE,
				SQUARED_OPEN,
				SQUARED_CLOSE,
				COLON,
				COMMA,
				STRING,
				NUMBER,
				TRUE,
				FALSE,
				NULL
			}

			private const string WORD_BREAK = "{}[],:\"";

			private StringReader json;

			private char PeekChar => Convert.ToChar(json.Peek());

			private char NextChar => Convert.ToChar(json.Read());

			private string NextWord
			{
				get
				{
					StringBuilder stringBuilder = new StringBuilder();
					while (!IsWordBreak(PeekChar))
					{
						stringBuilder.Append(NextChar);
						if (json.Peek() == -1)
						{
							break;
						}
					}
					return stringBuilder.ToString();
				}
			}

			private TOKEN NextToken
			{
				get
				{
					EatWhitespace();
					if (json.Peek() == -1)
					{
						return TOKEN.NONE;
					}
					switch (PeekChar)
					{
					case '{':
						return TOKEN.CURLY_OPEN;
					case '}':
						json.Read();
						return TOKEN.CURLY_CLOSE;
					case '[':
						return TOKEN.SQUARED_OPEN;
					case ']':
						json.Read();
						return TOKEN.SQUARED_CLOSE;
					case ',':
						json.Read();
						return TOKEN.COMMA;
					case '"':
						return TOKEN.STRING;
					case ':':
						return TOKEN.COLON;
					case '#':
						while (PeekChar != '\n' && PeekChar != '\r')
						{
							json.Read();
							if (json.Peek() == -1)
							{
								break;
							}
						}
						return TOKEN.COMMA;
					case '-':
					case '0':
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
						return TOKEN.NUMBER;
					default:
						return NextWord switch
						{
							"false" => TOKEN.FALSE, 
							"true" => TOKEN.TRUE, 
							"null" => TOKEN.NULL, 
							_ => TOKEN.NONE, 
						};
					}
				}
			}

			public static bool IsWordBreak(char c)
			{
				if (!char.IsWhiteSpace(c))
				{
					return "{}[],:\"".IndexOf(c) != -1;
				}
				return true;
			}

			private Parser(string jsonString)
			{
				json = new StringReader(jsonString);
			}

			public static object Parse(string jsonString)
			{
				using Parser parser = new Parser(jsonString);
				return parser.ParseValue();
			}

			public void Dispose()
			{
				json.Dispose();
				json = null;
			}

			private Dictionary<string, object> ParseObject()
			{
				Dictionary<string, object> dictionary = new Dictionary<string, object>();
				json.Read();
				while (true)
				{
					switch (NextToken)
					{
					case TOKEN.COMMA:
						continue;
					case TOKEN.NONE:
						return null;
					case TOKEN.CURLY_CLOSE:
						return dictionary;
					}
					string text = ParseString();
					if (text == null)
					{
						return null;
					}
					if (NextToken != TOKEN.COLON)
					{
						return null;
					}
					json.Read();
					dictionary[text] = ParseValue();
				}
			}

			private List<object> ParseArray()
			{
				List<object> list = new List<object>();
				json.Read();
				bool flag = true;
				while (flag)
				{
					TOKEN nextToken = NextToken;
					switch (nextToken)
					{
					case TOKEN.NONE:
						return null;
					case TOKEN.SQUARED_CLOSE:
						flag = false;
						break;
					default:
					{
						object item = ParseByToken(nextToken);
						list.Add(item);
						break;
					}
					case TOKEN.COMMA:
						break;
					}
				}
				return list;
			}

			private object ParseValue()
			{
				TOKEN nextToken = NextToken;
				return ParseByToken(nextToken);
			}

			private object ParseByToken(TOKEN token)
			{
				return token switch
				{
					TOKEN.STRING => ParseString(), 
					TOKEN.NUMBER => ParseNumber(), 
					TOKEN.CURLY_OPEN => ParseObject(), 
					TOKEN.SQUARED_OPEN => ParseArray(), 
					TOKEN.TRUE => true, 
					TOKEN.FALSE => false, 
					TOKEN.NULL => null, 
					_ => null, 
				};
			}

			private string ParseString()
			{
				StringBuilder stringBuilder = new StringBuilder();
				json.Read();
				bool flag = true;
				while (flag)
				{
					if (json.Peek() == -1)
					{
						flag = false;
						break;
					}
					char nextChar = NextChar;
					switch (nextChar)
					{
					case '"':
						flag = false;
						break;
					case '\\':
						if (json.Peek() == -1)
						{
							flag = false;
							break;
						}
						nextChar = NextChar;
						switch (nextChar)
						{
						case '"':
						case '/':
						case '\\':
							stringBuilder.Append(nextChar);
							break;
						case 'b':
							stringBuilder.Append('\b');
							break;
						case 'f':
							stringBuilder.Append('\f');
							break;
						case 'n':
							stringBuilder.Append('\n');
							break;
						case 'r':
							stringBuilder.Append('\r');
							break;
						case 't':
							stringBuilder.Append('\t');
							break;
						case 'u':
						{
							char[] array = new char[4];
							for (int i = 0; i < 4; i++)
							{
								array[i] = NextChar;
							}
							stringBuilder.Append((char)Convert.ToInt32(new string(array), 16));
							break;
						}
						}
						break;
					default:
						stringBuilder.Append(nextChar);
						break;
					}
				}
				return stringBuilder.ToString();
			}

			private object ParseNumber()
			{
				string nextWord = NextWord;
				if (nextWord.IndexOf('.') == -1)
				{
					long.TryParse(nextWord, out var result);
					return result;
				}
				double.TryParse(nextWord, out var result2);
				return result2;
			}

			private void EatWhitespace()
			{
				while (char.IsWhiteSpace(PeekChar))
				{
					json.Read();
					if (json.Peek() == -1)
					{
						break;
					}
				}
			}
		}

		private sealed class Serializer
		{
			private StringBuilder builder;

			private Serializer()
			{
				builder = new StringBuilder();
			}

			public static string Serialize(object obj)
			{
				Serializer serializer = new Serializer();
				serializer.SerializeValue(obj);
				return serializer.builder.ToString();
			}

			private void SerializeValue(object value)
			{
				if (value == null)
				{
					builder.Append("null");
				}
				else if (value is string str)
				{
					SerializeString(str);
				}
				else if (value is bool)
				{
					builder.Append(((bool)value) ? "true" : "false");
				}
				else if (value is IList anArray)
				{
					SerializeArray(anArray);
				}
				else if (value is IDictionary obj)
				{
					SerializeObject(obj);
				}
				else if (value is char)
				{
					SerializeString(new string((char)value, 1));
				}
				else
				{
					SerializeOther(value);
				}
			}

			private void SerializeObject(IDictionary obj)
			{
				bool flag = true;
				builder.Append('{');
				foreach (object key in obj.Keys)
				{
					if (!flag)
					{
						builder.Append(',');
					}
					SerializeString(key.ToString());
					builder.Append(':');
					SerializeValue(obj[key]);
					flag = false;
				}
				builder.Append('}');
			}

			private void SerializeArray(IList anArray)
			{
				builder.Append('[');
				bool flag = true;
				foreach (object item in anArray)
				{
					if (!flag)
					{
						builder.Append(',');
					}
					SerializeValue(item);
					flag = false;
				}
				builder.Append(']');
			}

			private void SerializeString(string str)
			{
				builder.Append('"');
				char[] array = str.ToCharArray();
				foreach (char c in array)
				{
					switch (c)
					{
					case '"':
						builder.Append("\\\"");
						continue;
					case '\\':
						builder.Append("\\\\");
						continue;
					case '\b':
						builder.Append("\\b");
						continue;
					case '\f':
						builder.Append("\\f");
						continue;
					case '\n':
						builder.Append("\\n");
						continue;
					case '\r':
						builder.Append("\\r");
						continue;
					case '\t':
						builder.Append("\\t");
						continue;
					}
					int num = Convert.ToInt32(c);
					if (num >= 32 && num <= 126)
					{
						builder.Append(c);
						continue;
					}
					builder.Append("\\u");
					builder.Append(num.ToString("x4"));
				}
				builder.Append('"');
			}

			private void SerializeOther(object value)
			{
				if (value is float)
				{
					builder.Append(((float)value).ToString("R"));
				}
				else if (value is int || value is uint || value is long || value is sbyte || value is byte || value is short || value is ushort || value is ulong)
				{
					builder.Append(value);
				}
				else if (value is double || value is decimal)
				{
					builder.Append(Convert.ToDouble(value).ToString("R"));
				}
				else
				{
					SerializeString(value.ToString());
				}
			}
		}

		public static object Deserialize(string json)
		{
			if (json == null)
			{
				return null;
			}
			return Parser.Parse(json);
		}

		public static string Serialize(object obj)
		{
			return Serializer.Serialize(obj);
		}
	}
}
namespace KEngine
{
	public class AppVersion : IComparable, ICloneable
	{
		public uint Major;

		public uint Minor;

		public uint Patch;

		public uint Build;

		public string VersionType { get; set; }

		public string VersionDesc { get; set; }

		public AppVersion(string versionStr)
		{
			string[] array = versionStr.Split('.');
			if (array.Length >= 1)
			{
				uint.TryParse(array[0], out Major);
			}
			if (array.Length >= 2)
			{
				uint.TryParse(array[1], out Minor);
			}
			if (array.Length >= 3)
			{
				uint.TryParse(array[2], out Patch);
			}
			if (array.Length >= 4)
			{
				uint.TryParse(array[3], out Build);
			}
			if (array.Length >= 5)
			{
				string versionType = array[4];
				VersionType = versionType;
			}
			if (array.Length >= 6)
			{
				VersionDesc = string.Join(".", array, 5, array.Length - 5);
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("{0}.{1}.{2}.{3}.{4}", Major, Minor, Patch, Build, VersionType.ToString().ToLower());
			if (!string.IsNullOrEmpty(VersionDesc))
			{
				stringBuilder.AppendFormat(".{0}", VersionDesc);
			}
			return stringBuilder.ToString();
		}

		public object Clone()
		{
			return MemberwiseClone();
		}

		public string ToVersion2()
		{
			return $"{Major}.{Minor}";
		}

		public string ToVersion3()
		{
			return $"{Major}.{Minor}.{Patch}";
		}

		public string ToVersion4()
		{
			return $"{Major}.{Minor}.{Patch}.{Build}";
		}

		private uint[] GetVersionNumbers(int limit = 4)
		{
			if (limit != 4)
			{
				if (limit != 3)
				{
					if (limit != 2)
					{
						if (limit > 1)
						{
							return new uint[4] { Major, Minor, Patch, Build };
						}
						return new uint[1] { Major };
					}
					return new uint[2] { Major, Minor };
				}
				return new uint[3] { Major, Minor, Patch };
			}
			return new uint[4] { Major, Minor, Patch, Build };
		}

		public int CompareTo(object obj)
		{
			return CompareTo(obj, 100);
		}

		public int CompareTo(object v2o, int limitNumber)
		{
			AppVersion obj = v2o as AppVersion;
			if (obj == null)
			{
				throw new ArgumentException("Arg_MustBeVersion");
			}
			uint[] versionNumbers = GetVersionNumbers(limitNumber);
			uint[] versionNumbers2 = obj.GetVersionNumbers(limitNumber);
			for (int i = 0; i < versionNumbers.Length; i++)
			{
				uint num = versionNumbers[i];
				uint num2 = versionNumbers2[i];
				if (num != num2)
				{
					return num.CompareTo(num2);
				}
			}
			return 0;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as AppVersion);
		}

		protected bool Equals(AppVersion other)
		{
			if ((object)other == null)
			{
				return false;
			}
			if ((object)this == other)
			{
				return true;
			}
			if (other.GetType() != GetType())
			{
				return false;
			}
			return CompareTo(other) == 0;
		}

		public override int GetHashCode()
		{
			return (int)(((((((((Major * 397) ^ Minor) * 397) ^ Patch) * 397) ^ Build) * 397) ^ (uint)((VersionType != null) ? VersionType.GetHashCode() : 0)) * 397) ^ ((VersionDesc != null) ? VersionDesc.GetHashCode() : 0);
		}

		public static bool operator ==(AppVersion v1, AppVersion v2)
		{
			return v1?.Equals(v2) ?? ((object)v2 == null);
		}

		public static bool operator !=(AppVersion v1, AppVersion v2)
		{
			return !(v1 == v2);
		}

		public static bool operator <(AppVersion v1, AppVersion v2)
		{
			if ((object)v1 == null)
			{
				throw new ArgumentNullException("v1");
			}
			return v1.CompareTo(v2) < 0;
		}

		public static bool operator <=(AppVersion v1, AppVersion v2)
		{
			if ((object)v1 == null)
			{
				throw new ArgumentNullException("v1");
			}
			return v1.CompareTo(v2) <= 0;
		}

		public static bool operator >(AppVersion v1, AppVersion v2)
		{
			return v2 < v1;
		}

		public static bool operator >=(AppVersion v1, AppVersion v2)
		{
			return v2 <= v1;
		}
	}
	public class Debuger
	{
		private static float[] RecordTime = new float[10];

		private static string[] RecordKey = new string[10];

		private static int RecordPos = 0;

		public static bool Check(object obj, string formatStr = null, params object[] args)
		{
			if (obj != null)
			{
				return true;
			}
			if (string.IsNullOrEmpty(formatStr))
			{
				formatStr = "[Check Null] Failed!";
			}
			Log.Error("[!!!]" + formatStr, args);
			return false;
		}

		public static void Assert(bool result)
		{
			Assert(result, null);
		}

		public static void Assert(bool result, string msg, params object[] args)
		{
			if (!result)
			{
				string text = "Assert Failed! ";
				if (!string.IsNullOrEmpty(msg))
				{
					text += string.Format(msg, args);
				}
				Log.LogErrorWithStack(text);
				throw new Exception(text);
			}
		}

		public static void Assert(int result)
		{
			Assert(result != 0);
		}

		public static void Assert(long result)
		{
			Assert(result != 0);
		}

		public static void Assert(object obj)
		{
			Assert(obj != null);
		}

		public static void BeginRecordTime(string key)
		{
			RecordTime[RecordPos] = Time.realtimeSinceStartup;
			RecordKey[RecordPos] = key;
			RecordPos++;
		}

		public static string EndRecordTime(bool printLog = true)
		{
			RecordPos--;
			double num = Time.realtimeSinceStartup - RecordTime[RecordPos];
			if (printLog)
			{
				Log.Info("[RecordTime] {0} use {1}s", RecordKey[RecordPos], num);
			}
			return $"[RecordTime] {RecordKey[RecordPos]} use {num}s.";
		}

		public static void WatchPerformance(Action del)
		{
			WatchPerformance("执行耗费时间: {0}s", del);
		}

		public static void WatchPerformance(string outputStr, Action del)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			del?.Invoke();
			stopwatch.Stop();
			decimal num = (decimal)stopwatch.Elapsed.TotalMilliseconds / 1000m;
			Log.Warning(outputStr, num.ToString("F7"));
		}
	}
	public class EngineConfigs
	{
		public static string DefaultEngineConfigs = "\r\n\r\n[KEngine]\r\nProductRelPath\t= Product\t\r\n\r\nAssetBundleBuildRelPath\t= Product/Bundles\t\r\nStreamingBundlesFolderName = Bundles\t\r\nAssetBundleExt = .bytes\t\r\nIsLoadAssetBundle = 1\t\r\n\r\n;whether use assetdata.loadassetatpath insead of load asset bundle, editor only\r\nIsEditorLoadAsset = 0\r\n\r\n[KEngine.Setting]\r\nSettingSourcePath = Product/SettingSource\t\r\n\r\n;settings where compile to?\t\r\nSettingCompiledPath = Product/Setting\r\n\r\n;Folder in Resources\r\nSettingResourcesPath = Setting\r\n\r\n; Ignore genereate code for these excel.\r\nSettingCodeIgnorePattern = (I18N/.*)|(StringsTable.*)\r\n\r\n[KEngine.UI]\r\nUIModuleBridge = KEngine.UI.UGUIBridge\t\r\n\r\n";

		private readonly IniData _iniData;

		public EngineConfigs(string customConfigs)
		{
			IniDataParser iniDataParser = new IniDataParser();
			_iniData = iniDataParser.Parse(DefaultEngineConfigs);
			if (!string.IsNullOrEmpty(customConfigs) && customConfigs.Trim() != "")
			{
				IniData toMergeIniData = iniDataParser.Parse(customConfigs);
				_iniData.Merge(toMergeIniData);
			}
		}

		public string GetConfig(string section, string key, bool throwError = true)
		{
			KeyDataCollection keyDataCollection = _iniData[section];
			if (keyDataCollection == null)
			{
				if (throwError)
				{
					throw new Exception("Not found section from ini config: " + section);
				}
				return null;
			}
			string text = keyDataCollection[key];
			if (text == null && throwError)
			{
				throw new Exception($"Not found section:`{section}`, key:`{key}` config");
			}
			return text;
		}

		public SectionDataCollection GetSections()
		{
			return _iniData.Sections;
		}

		public string ToIniString()
		{
			return _iniData.ToString(new DefaultIniDataFormatter());
		}
	}
	public interface IModuleInitable
	{
		double InitProgress { get; }

		IEnumerator Init();
	}
	public enum LogLevel
	{
		All,
		Trace,
		Debug,
		Info,
		Warning,
		Error
	}
	[Obsolete("The name 'Logger' conflict with Unity 5 'Logger', use 'Log' instead, at 2016/04/08")]
	public class Logger : Log
	{
	}
	public class Log
	{
		public delegate void LogCallback(string condition, string stackTrace, LogLevel type);

		public static LogLevel LogLevel;

		private static bool _hasRegisterLogCallback;

		public static readonly bool IsUnityEditor;

		private static bool _isLogFile;

		public static bool IsLogFile
		{
			get
			{
				return _isLogFile;
			}
			set
			{
				_isLogFile = value;
				if (_isLogFile)
				{
					AddLogCallback(LogFileCallbackHandler);
				}
				else
				{
					RemoveLogCallback(LogFileCallbackHandler);
				}
			}
		}

		private static event LogCallback LogCallbackEvent;

		public static event Action<string> LogErrorEvent;

		public static void AddLogCallback(LogCallback callback)
		{
			if (!_hasRegisterLogCallback)
			{
				Application.logMessageReceivedThreaded += GetUnityLogCallback(OnLogCallback);
				_hasRegisterLogCallback = true;
			}
			LogCallbackEvent += callback;
		}

		private static Application.LogCallback GetUnityLogCallback(LogCallback callback)
		{
			return delegate(string c, string s, LogType type)
			{
				OnLogCallback(c, s, type switch
				{
					LogType.Error => LogLevel.Error, 
					LogType.Warning => LogLevel.Warning, 
					_ => LogLevel.Info, 
				});
			};
		}

		public static void RemoveLogCallback(LogCallback callback)
		{
			if (!_hasRegisterLogCallback)
			{
				Application.logMessageReceivedThreaded += GetUnityLogCallback(callback);
				_hasRegisterLogCallback = true;
			}
			LogCallbackEvent -= callback;
		}

		static Log()
		{
			LogLevel = LogLevel.Info;
			_hasRegisterLogCallback = false;
			IsUnityEditor = false;
			_isLogFile = false;
			try
			{
				IsUnityEditor = Application.isEditor;
			}
			catch (Exception ex)
			{
				LogConsole_MultiThread("Log Static Constructor Failed!");
				LogConsole_MultiThread(ex.Message + " , " + ex.StackTrace);
			}
		}

		public static void LogFileCallbackHandler(string condition, string stacktrace, LogLevel type)
		{
			try
			{
				if (type > LogLevel.Warning)
				{
					LogToFile(condition + "\n\n");
				}
				else
				{
					LogToFile(condition + stacktrace + "\n\n");
				}
			}
			catch (Exception ex)
			{
				LogToFile($"LogFileError: {condition}, {ex.Message}");
			}
		}

		private static void OnLogCallback(string condition, string stacktrace, LogLevel type)
		{
			if (Log.LogCallbackEvent != null)
			{
				lock (Log.LogCallbackEvent)
				{
					Log.LogCallbackEvent(condition, stacktrace, type);
				}
			}
		}

		[Obsolete("Use Debugger.Check instead")]
		public static bool Check(object obj, string formatStr = null, params object[] args)
		{
			if (obj != null)
			{
				return true;
			}
			if (string.IsNullOrEmpty(formatStr))
			{
				formatStr = "[Check Null] Failed!";
			}
			LogError("[!!!]" + formatStr, args);
			return false;
		}

		[Obsolete("Use Debugger.Assert instead")]
		public static void Assert(bool result)
		{
			if (result)
			{
				return;
			}
			LogErrorWithStack("Assertion Failed!");
			throw new Exception("Assert");
		}

		[Obsolete("Use Debugger.Assert instead")]
		public static void Assert(int result)
		{
			Assert(result != 0);
		}

		[Obsolete("Use Debugger.Assert instead")]
		public static void Assert(long result)
		{
			Assert(result != 0);
		}

		[Obsolete("Use Debugger.Assert instead")]
		public static void Assert(object obj)
		{
			Assert(obj != null);
		}

		public static void LogConsole_MultiThread(string log, params object[] args)
		{
			if (IsUnityEditor)
			{
				DoLog(log, args, LogLevel.Info);
			}
			else
			{
				Console.WriteLine(log, args);
			}
		}

		public static void Trace(string log, params object[] args)
		{
			DoLog(log, args, LogLevel.Trace);
		}

		public static void Debug(string log, params object[] args)
		{
			DoLog(log, args, LogLevel.Debug);
		}

		public static void Info(string log, params object[] args)
		{
			DoLog(log, args, LogLevel.Info);
		}

		public static void Logs(params object[] logs)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < logs.Length; i++)
			{
				stringBuilder.Append(logs[i].ToString());
				stringBuilder.Append(", ");
			}
			DoLog(stringBuilder.ToString(), null, LogLevel.Info);
		}

		public static void LogException(Exception e)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendFormat("Exception: {0}", e.Message);
			if (e.InnerException != null)
			{
				stringBuilder.AppendFormat(" InnerException: {0}", e.InnerException.Message);
			}
			LogErrorWithStack(stringBuilder.ToString() + " , " + e.StackTrace);
		}

		public static void LogErrorWithStack(string err = "", int stack = 2)
		{
			StackFrame topStack = GetTopStack(stack);
			string text = $"[ERROR]{err}\n\n{topStack.GetFileName()}:{topStack.GetFileLineNumber()}\t{topStack.GetMethod()}";
			Console.Write(text);
			DoLog(text, null, LogLevel.Error);
			if (Log.LogErrorEvent != null)
			{
				Log.LogErrorEvent(err);
			}
		}

		public static StackFrame GetTopStack(int stack = 2)
		{
			StackFrame[] frames = new StackTrace(fNeedFileInfo: true).GetFrames();
			return frames[Math.Min(stack, frames.Length - 1)];
		}

		public static void Error(string err, params object[] args)
		{
			LogErrorWithStack(string.Format(err, args));
		}

		public static void LogError(string err, params object[] args)
		{
			LogErrorWithStack(string.Format(err, args));
		}

		public static void Warning(string err, params object[] args)
		{
			DoLog(err, args, LogLevel.Warning);
		}

		public static void LogWarning(string err, params object[] args)
		{
			DoLog(err, args, LogLevel.Warning);
		}

		private static void DoLog(string szMsg, object[] args, LogLevel emLevel)
		{
			if (LogLevel <= emLevel)
			{
				if (args != null)
				{
					szMsg = string.Format(szMsg, args);
				}
				szMsg = string.Format("[{0}]{1}\n\n=================================================================\n\n", DateTime.Now.ToString("HH:mm:ss.ffff"), szMsg);
				switch (emLevel)
				{
				case LogLevel.Trace:
				case LogLevel.Warning:
					UnityEngine.Debug.LogWarning(szMsg);
					break;
				case LogLevel.Error:
					UnityEngine.Debug.LogError(szMsg);
					break;
				default:
					UnityEngine.Debug.Log(szMsg);
					break;
				}
			}
		}

		public static void LogToFile(string szMsg)
		{
			LogToFile(szMsg, append: true);
		}

		public static bool HasLogFile()
		{
			return File.Exists(GetLogPath());
		}

		public static void LogToFile(string szMsg, bool append)
		{
			string logPath = GetLogPath();
			string directoryName = Path.GetDirectoryName(logPath);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			using FileStream fileStream = new FileStream(logPath, (!append) ? FileMode.CreateNew : FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			lock (fileStream)
			{
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.Write(szMsg);
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		public static string GetLogPath()
		{
			string text = ((!IsUnityEditor) ? Path.Combine(Application.persistentDataPath, "logs/") : "logs/");
			DateTime now = DateTime.Now;
			string text2 = $"game_{now.Year}_{now.Month}_{now.Day}.log";
			return text + text2;
		}
	}
	public interface IAppEntry
	{
		IEnumerator OnBeforeInit();

		IEnumerator OnGameStart();
	}
	public class AppEngine : MonoBehaviour
	{
		public bool ShowFps;

		public static bool IsRootUser;

		private bool _isNewByStatic;

		private static EngineConfigs _engineConfigs;

		public static bool IsDebugBuild { get; private set; }

		public static FpsWatcher RenderWatcher { get; set; }

		public static AppEngine EngineInstance { get; private set; }

		public IList<IModuleInitable> GameModules { get; private set; }

		public bool IsInited { get; private set; }

		public bool IsBeforeInit { get; private set; }

		public bool IsOnInit { get; private set; }

		public bool IsStartGame { get; private set; }

		public IAppEntry AppEntry { get; private set; }

		[Obsolete("Use New(GameObject, IAppEntry, IModuleInitable[]) instead!")]
		public static AppEngine New(GameObject gameObjectToAttach, IModuleInitable[] modules)
		{
			return New(gameObjectToAttach, null, modules);
		}

		public static AppEngine New(GameObject gameObjectToAttach, IAppEntry entry, IList<IModuleInitable> modules)
		{
			Debuger.Assert(gameObjectToAttach != null && modules != null);
			AppEngine appEngine = gameObjectToAttach.AddComponent<AppEngine>();
			appEngine._isNewByStatic = true;
			appEngine.GameModules = modules;
			appEngine.AppEntry = entry;
			return appEngine;
		}

		private void Awake()
		{
			IsDebugBuild = UnityEngine.Debug.isDebugBuild;
			ShowFps = IsDebugBuild;
			if (EngineInstance != null)
			{
				Log.Error("Duplicated Instance Engine!!!");
			}
			EngineInstance = this;
			Init();
		}

		private void Start()
		{
			Debuger.Assert(_isNewByStatic);
		}

		private void Init()
		{
			IsRootUser = KTool.HasWriteAccessToFolder(Application.dataPath);
			if (UnityEngine.Debug.isDebugBuild)
			{
				Log.Info("====================================================================================");
				Log.Info("Application.platform = {0}", Application.platform);
				Log.Info("Application.dataPath = {0} , WritePermission: {1}", Application.dataPath, IsRootUser);
				Log.Info("Application.streamingAssetsPath = {0} , WritePermission: {1}", Application.streamingAssetsPath, KTool.HasWriteAccessToFolder(Application.streamingAssetsPath));
				Log.Info("Application.persistentDataPath = {0} , WritePermission: {1}", Application.persistentDataPath, KTool.HasWriteAccessToFolder(Application.persistentDataPath));
				Log.Info("Application.temporaryCachePath = {0} , WritePermission: {1}", Application.temporaryCachePath, KTool.HasWriteAccessToFolder(Application.temporaryCachePath));
				Log.Info("Application.unityVersion = {0}", Application.unityVersion);
				Log.Info("SystemInfo.deviceModel = {0}", SystemInfo.deviceModel);
				Log.Info("SystemInfo.deviceUniqueIdentifier = {0}", SystemInfo.deviceUniqueIdentifier);
				Log.Info("SystemInfo.graphicsDeviceVersion = {0}", SystemInfo.graphicsDeviceVersion);
				Log.Info("====================================================================================");
			}
			StartCoroutine(DoInit());
		}

		private IEnumerator DoInit()
		{
			yield return null;
			IsBeforeInit = true;
			if (AppEntry != null)
			{
				yield return StartCoroutine(AppEntry.OnBeforeInit());
			}
			IsOnInit = true;
			yield return StartCoroutine(DoInitModules(GameModules));
			IsStartGame = true;
			if (AppEntry != null)
			{
				yield return StartCoroutine(AppEntry.OnGameStart());
			}
			IsInited = true;
		}

		private IEnumerator DoInitModules(IList<IModuleInitable> modules)
		{
			float startInitTime = 0f;
			float startMem = 0f;
			foreach (IModuleInitable initModule in modules)
			{
				if (UnityEngine.Debug.isDebugBuild)
				{
					startInitTime = Time.time;
					startMem = GC.GetTotalMemory(forceFullCollection: false);
				}
				yield return StartCoroutine(initModule.Init());
				if (UnityEngine.Debug.isDebugBuild)
				{
					long totalMemory = GC.GetTotalMemory(forceFullCollection: false);
					Log.Info("Init Module: #{0}# Time:{1}, DiffMem:{2}, NowMem:{3}", initModule.GetType().FullName, Time.time - startInitTime, (float)totalMemory - startMem, totalMemory);
				}
			}
		}

		protected virtual void Update()
		{
			if (RenderWatcher != null)
			{
				RenderWatcher.OnUIUpdate(ShowFps);
			}
		}

		public static EngineConfigs PreloadConfigs(bool forceReload = false)
		{
			if (_engineConfigs != null && !forceReload)
			{
				return _engineConfigs;
			}
			string customConfigs = null;
			if (Application.isEditor && !Application.isPlaying)
			{
				string path = "Assets/Resources/AppConfigs.txt";
				if (File.Exists(path))
				{
					customConfigs = File.ReadAllText(path);
				}
			}
			else
			{
				TextAsset textAsset = Resources.Load<TextAsset>("AppConfigs");
				if (textAsset != null)
				{
					customConfigs = textAsset.text;
				}
			}
			_engineConfigs = new EngineConfigs(customConfigs);
			return _engineConfigs;
		}

		public static string GetConfig(string section, string key, bool showLog = true)
		{
			PreloadConfigs();
			string config = _engineConfigs.GetConfig(section, key, throwError: false);
			if (config == null && showLog)
			{
				Log.Error("Cannot get config, section: {0}, key: {1}", section, key);
			}
			return config;
		}

		public static string GetConfig(KEngineDefaultConfigs cfg)
		{
			return GetConfig("KEngine", cfg.ToString());
		}
	}
	public enum KEngineDefaultConfigs
	{
		AssetBundleExt,
		ProductRelPath,
		AssetBundleBuildRelPath,
		StreamingBundlesFolderName
	}
	public class FpsWatcher
	{
		private float _value;

		private float _sensitivity;

		private string _cacheMemoryStr;

		private string _cacheFPSStr;

		private Text CacheText;

		public float Value => _value;

		public FpsWatcher(float sensitivity)
		{
			_value = 0f;
			_sensitivity = sensitivity;
			Canvas canvas = new GameObject("__FPSCanvas__").AddComponent<Canvas>();
			canvas.renderMode = RenderMode.ScreenSpaceOverlay;
			Text text = new GameObject("FPSText").AddComponent<Text>();
			text.transform.SetParent(canvas.transform);
			text.rectTransform.pivot = new Vector2(0f, 1f);
			text.rectTransform.localPosition = Vector3.zero;
			text.rectTransform.anchorMin = new Vector2(0f, 1f);
			text.rectTransform.anchorMax = new Vector2(0f, 1f);
			text.rectTransform.sizeDelta = new Vector2(300f, 100f);
			Font builtinResource = Resources.GetBuiltinResource<Font>("Arial.ttf");
			text.font = builtinResource;
			CacheText = text;
		}

		public void OnUIUpdate(bool bShowFps)
		{
			if (Time.frameCount % 30 == 0 || _cacheMemoryStr == null || _cacheFPSStr == null)
			{
				_cacheMemoryStr = $"Memory: {(float)Profiler.GetMonoUsedSizeLong() / 1024f:F3}KB";
				_cacheFPSStr = Watch("FPS: {0:N0}", 1f / Time.deltaTime);
				if (bShowFps && !(CacheText == null))
				{
					CacheText.text = _cacheMemoryStr + "\n" + _cacheFPSStr;
				}
			}
		}

		public string Watch(string format, float value)
		{
			_value = _value * _sensitivity + value * (1f - _sensitivity);
			return string.Format(format, _value);
		}
	}
	public class KEngineInfo
	{
		private static KEngineInfo _instance;

		private TableFileRow _row;

		public string Key => _row["Key"];

		public string Value
		{
			get
			{
				return _row["Value"];
			}
			set
			{
				_row["Value"] = value;
			}
		}

		public static KEngineInfo Wrap(TableFileRow row)
		{
			if (_instance == null)
			{
				_instance = new KEngineInfo();
			}
			_instance._row = row;
			return _instance;
		}

		private KEngineInfo()
		{
		}
	}
	internal class AssetBundleInfo
	{
		public string bundleName;

		public string assetName;

		public List<string> dependencies;

		public void AddDependence(string dep)
		{
			if (dependencies == null)
			{
				dependencies = new List<string>();
			}
			dependencies.Add(dep);
		}
	}
	public class ABLoader : AbstractResourceLoader
	{
		public delegate void ABLoaderDelegate(bool isOk, object result);

		private AssetBundle _assetBundle;

		private Dictionary<string, AssetBundleInfo> bundleMap = new Dictionary<string, AssetBundleInfo>();

		public static ABLoader Load(string path, ABLoaderDelegate callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj);
				};
			}
			return AbstractResourceLoader.AutoNew<ABLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			KResourceModule.Instance.StartCoroutine(CoLoadAB());
		}

		private IEnumerator CoLoadAB()
		{
			int num = base.Url.LastIndexOf('\\');
			int num2 = base.Url.LastIndexOf('.');
			base.Url.Substring(num + 1, num2 - num - 1);
			LoadResDesc(base.Url);
			if (!bundleMap.ContainsKey(base.Url))
			{
				yield break;
			}
			num2 = base.Url.LastIndexOf('\\');
			string rootPath = base.Url.Substring(0, num2);
			AssetBundleInfo info = bundleMap[base.Url];
			string bundlePath2 = rootPath + "\\" + info.bundleName;
			bundlePath2 = bundlePath2.Replace('\\', '/');
			if (!File.Exists(bundlePath2))
			{
				UnityEngine.Debug.Log(bundlePath2 + " is not exist");
				yield break;
			}
			AssetBundleCreateRequest req = AssetBundle.LoadFromFileAsync(bundlePath2);
			while (!req.isDone)
			{
				Progress = req.progress;
				yield return null;
			}
			_assetBundle = req.assetBundle;
			if (null == _assetBundle)
			{
				UnityEngine.Debug.Log(bundlePath2 + " load failed");
				yield break;
			}
			if (info.dependencies != null)
			{
				foreach (string dependency in info.dependencies)
				{
					yield return AssetBundle.LoadFromFileAsync(rootPath + "\\" + dependency);
				}
			}
			UnityEngine.Object resultObj = _assetBundle.LoadAsset(info.assetName);
			OnFinish(resultObj);
		}

		public void LoadResDesc(string descName)
		{
			if (bundleMap.ContainsKey(descName))
			{
				return;
			}
			string path = descName.Replace('\\', '/');
			Dictionary<string, object> dictionary = Json.Deserialize(ReadFileText(path)) as Dictionary<string, object>;
			AssetBundleInfo assetBundleInfo = new AssetBundleInfo();
			dictionary["fileName"].ToString();
			assetBundleInfo.assetName = dictionary["assetName"].ToString();
			assetBundleInfo.bundleName = dictionary["bundleName"].ToString();
			if (dictionary.ContainsKey("deps"))
			{
				foreach (string item in dictionary["deps"] as List<object>)
				{
					assetBundleInfo.AddDependence(item);
				}
			}
			bundleMap.Add(descName, assetBundleInfo);
		}

		public string ReadFileText(string path)
		{
			if (!File.Exists(path))
			{
				return null;
			}
			return File.ReadAllText(path);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			_assetBundle.Unload(unloadAllLoadedObjects: true);
		}
	}
	public abstract class AbstractResourceLoader : IAsyncObject
	{
		public delegate void LoaderDelgate(bool isOk, object resultObject);

		private static readonly Dictionary<Type, Dictionary<string, AbstractResourceLoader>> _loadersPool = new Dictionary<Type, Dictionary<string, AbstractResourceLoader>>();

		private readonly List<LoaderDelgate> _afterFinishedCallbacks = new List<LoaderDelgate>();

		private const float LoaderDisposeTime = 0f;

		private static float _lastGcTime = -1f;

		private static readonly List<AbstractResourceLoader> CacheLoaderToRemoveFromUnUsed = new List<AbstractResourceLoader>();

		internal static readonly Dictionary<AbstractResourceLoader, float> UnUsesLoaders = new Dictionary<AbstractResourceLoader, float>();

		private bool _isQuitApplication;

		protected bool IsForceNew;

		[NonSerialized]
		public float InitTiming = -1f;

		[NonSerialized]
		public float FinishTiming = -1f;

		private string _desc = "";

		public static float GcIntervalTime
		{
			get
			{
				if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
				{
					return 1f;
				}
				if (!UnityEngine.Debug.isDebugBuild)
				{
					return 10f;
				}
				return 5f;
			}
		}

		public object ResultObject { get; private set; }

		public bool IsCompleted { get; private set; }

		public bool IsError { get; private set; }

		public virtual string AsyncMessage => null;

		public object AsyncResult => ResultObject;

		public bool IsSuccess
		{
			get
			{
				if (!IsError && ResultObject != null)
				{
					return !IsReadyDisposed;
				}
				return false;
			}
		}

		protected bool IsReadyDisposed { get; private set; }

		public float FinishUsedTime
		{
			get
			{
				if (!IsCompleted)
				{
					return -1f;
				}
				return FinishTiming - InitTiming;
			}
		}

		public int RefCount { get; protected set; }

		public string Url { get; private set; }

		public virtual float Progress { get; protected set; }

		public virtual string Desc
		{
			get
			{
				return _desc;
			}
			set
			{
				_desc = value;
				if (this.SetDescEvent != null)
				{
					this.SetDescEvent(_desc);
				}
			}
		}

		public event Action DisposeEvent;

		public event Action<string> SetDescEvent;

		protected static int GetCount<T>()
		{
			return GetTypeDict(typeof(T)).Count;
		}

		protected static Dictionary<string, AbstractResourceLoader> GetTypeDict(Type type)
		{
			if (!_loadersPool.TryGetValue(type, out var value))
			{
				return _loadersPool[type] = new Dictionary<string, AbstractResourceLoader>();
			}
			return value;
		}

		public static int GetRefCount<T>(string url)
		{
			if (GetTypeDict(typeof(T)).TryGetValue(url, out var value))
			{
				return value.RefCount;
			}
			return 0;
		}

		protected static T AutoNew<T>(string url, LoaderDelgate callback = null, bool forceCreateNew = false, params object[] initArgs) where T : AbstractResourceLoader, new()
		{
			Dictionary<string, AbstractResourceLoader> typeDict = GetTypeDict(typeof(T));
			if (string.IsNullOrEmpty(url))
			{
				Log.Error("[{0}:AutoNew]url为空", typeof(T));
			}
			if (forceCreateNew || !typeDict.TryGetValue(url, out var value))
			{
				value = new T();
				if (!forceCreateNew)
				{
					typeDict[url] = value;
				}
				value.IsForceNew = forceCreateNew;
				value.Init(url, initArgs);
				if (Application.isEditor)
				{
					KResourceLoaderDebugger.Create(typeof(T).Name, url, value);
				}
			}
			else if (value.RefCount < 0)
			{
				Log.Error("Error RefCount!");
			}
			value.RefCount++;
			if (UnUsesLoaders.ContainsKey(value))
			{
				UnityEngine.Debug.Log("Path = " + url + " ;loaded obj =" + value.ResultObject.ToString() + "revive!");
				UnUsesLoaders.Remove(value);
				value.Revive();
			}
			value.AddCallback(callback);
			return value as T;
		}

		public static void CheckGcCollect()
		{
			if (_lastGcTime.Equals(-1f) || Time.time - _lastGcTime >= GcIntervalTime)
			{
				DoGarbageCollect();
				_lastGcTime = Time.time;
			}
		}

		internal static void DoGarbageCollect()
		{
			foreach (KeyValuePair<AbstractResourceLoader, float> unUsesLoader in UnUsesLoaders)
			{
				AbstractResourceLoader key = unUsesLoader.Key;
				float value = unUsesLoader.Value;
				if (Time.time - value >= 0f)
				{
					CacheLoaderToRemoveFromUnUsed.Add(key);
				}
			}
			for (int num = CacheLoaderToRemoveFromUnUsed.Count - 1; num >= 0; num--)
			{
				try
				{
					AbstractResourceLoader abstractResourceLoader = CacheLoaderToRemoveFromUnUsed[num];
					UnUsesLoaders.Remove(abstractResourceLoader);
					CacheLoaderToRemoveFromUnUsed.RemoveAt(num);
					abstractResourceLoader.Dispose();
				}
				catch (Exception e)
				{
					Log.LogException(e);
				}
			}
			if (CacheLoaderToRemoveFromUnUsed.Count > 0)
			{
				Log.Error("[DoGarbageCollect]CacheLoaderToRemoveFromUnUsed muse be empty!!");
			}
		}

		protected virtual void Revive()
		{
			IsReadyDisposed = false;
		}

		protected AbstractResourceLoader()
		{
			RefCount = 0;
		}

		protected virtual void Init(string url, params object[] args)
		{
			InitTiming = Time.realtimeSinceStartup;
			ResultObject = null;
			IsReadyDisposed = false;
			IsError = false;
			IsCompleted = false;
			Url = url;
			Progress = 0f;
		}

		protected virtual void OnFinish(object resultObj)
		{
			((Action)delegate
			{
				ResultObject = resultObj;
				object obj = ((!IsReadyDisposed) ? ResultObject : null);
				FinishTiming = Time.realtimeSinceStartup;
				Progress = 1f;
				IsError = obj == null;
				IsCompleted = true;
				DoCallback(IsSuccess, obj);
				if (IsReadyDisposed)
				{
					Log.Trace("[BaseResourceLoader:OnFinish]时，准备Disposed {0}", Url);
				}
			})();
		}

		protected void AddCallback(LoaderDelgate callback)
		{
			if (callback == null)
			{
				return;
			}
			if (IsCompleted)
			{
				if (ResultObject == null)
				{
					Log.Warning("Null ResultAsset {0}", Url);
				}
				callback(ResultObject != null, ResultObject);
			}
			else
			{
				_afterFinishedCallbacks.Add(callback);
			}
		}

		protected void DoCallback(bool isOk, object resultObj)
		{
			((Action)delegate
			{
				foreach (LoaderDelgate afterFinishedCallback in _afterFinishedCallbacks)
				{
					afterFinishedCallback(isOk, resultObj);
				}
				_afterFinishedCallbacks.Clear();
			})();
		}

		public virtual void Release(bool now)
		{
			Release();
			if (now)
			{
				KResourceModule.Collect();
			}
		}

		public virtual void Release()
		{
			if (IsReadyDisposed && UnityEngine.Debug.isDebugBuild)
			{
				Log.Warning("[{0}]Too many dipose! {1}, Count: {2}", GetType().Name, Url, RefCount);
			}
			RefCount--;
			if (RefCount > 0)
			{
				return;
			}
			if (UnityEngine.Debug.isDebugBuild)
			{
				if (RefCount < 0)
				{
					Log.Error("[{3}]RefCount< 0, {0} : {1}, NowRefCount: {2}, Will be fix to 0", GetType().Name, Url, RefCount, GetType());
					RefCount = Mathf.Max(0, RefCount);
				}
				if (UnUsesLoaders.ContainsKey(this))
				{
					Log.Error("[{1}]UnUsesLoader exists: {0}", this, GetType());
				}
			}
			UnUsesLoaders[this] = Time.time;
			IsReadyDisposed = true;
			OnReadyDisposed();
		}

		protected virtual void OnReadyDisposed()
		{
		}

		private void Dispose()
		{
			if (this.DisposeEvent != null)
			{
				this.DisposeEvent();
			}
			if (!IsForceNew)
			{
				Type type = GetType();
				if (!GetTypeDict(type).Remove(Url))
				{
					Log.Warning("[{0}:Dispose]No Url: {1}, Cur RefCount: {2}", type.Name, Url, RefCount);
				}
			}
			if (IsCompleted)
			{
				DoDispose();
			}
		}

		protected virtual void DoDispose()
		{
			ResultObject = null;
		}

		public virtual void ForceDispose()
		{
			if (!_isQuitApplication)
			{
				if (RefCount != 1)
				{
					Log.Warning("[ForceDisose]Use force dispose to dispose loader, recommend this loader RefCount == 1");
				}
				Dispose();
			}
		}

		protected void OnApplicationQuit()
		{
			_isQuitApplication = true;
		}
	}
	public enum LoaderMode
	{
		Async,
		Sync
	}
	public class AssetBundleLoader : AbstractResourceLoader
	{
		public delegate void CAssetBundleLoaderDelegate(bool isOk, AssetBundle ab);

		public static Action<string> NewAssetBundleLoaderEvent;

		public static Action<AssetBundleLoader> AssetBundlerLoaderErrorEvent;

		private KWWWRequestBundleLoader _wwwLoader;

		private KAssetBundleParser BundleParser;

		private string RelativeResourceUrl;

		private List<UnityEngine.Object> _loadedAssets;

		private LoaderMode _loaderMode;

		private static bool _hasPreloadAssetBundleManifest;

		private static AssetBundle _mainAssetBundle;

		private static AssetBundleManifest _assetBundleManifest;

		private AssetBundleLoader[] _depLoaders;

		public AssetBundle Bundle => base.ResultObject as AssetBundle;

		public static AssetBundleLoader Load(string url, CAssetBundleLoaderDelegate callback = null, LoaderMode loaderMode = LoaderMode.Async)
		{
			url = url.ToLower();
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as AssetBundle);
				};
			}
			return AbstractResourceLoader.AutoNew<AssetBundleLoader>(url, callback2, forceCreateNew: false, new object[1] { loaderMode });
		}

		public static void PreLoadManifest(bool isForce = false)
		{
			if (!_hasPreloadAssetBundleManifest || isForce)
			{
				_hasPreloadAssetBundleManifest = true;
				HotBytesLoader hotBytesLoader = HotBytesLoader.Load(KResourceModule.BundlesPathRelative + KResourceModule.BuildPlatformName, LoaderMode.Sync);
				_mainAssetBundle = AssetBundle.LoadFromMemory(hotBytesLoader.Bytes);
				_assetBundleManifest = _mainAssetBundle.LoadAsset("AssetBundleManifest") as AssetBundleManifest;
				hotBytesLoader.Release();
				Debuger.Assert(_mainAssetBundle);
				Debuger.Assert(_assetBundleManifest);
			}
		}

		protected override void Init(string url, params object[] args)
		{
			PreLoadManifest();
			base.Init(url);
			_loaderMode = (LoaderMode)args[0];
			if (NewAssetBundleLoaderEvent != null)
			{
				NewAssetBundleLoaderEvent(url);
			}
			RelativeResourceUrl = url;
			KResourceModule.LogRequest("AssetBundle", RelativeResourceUrl);
			KResourceModule.Instance.StartCoroutine(LoadAssetBundle(url));
		}

		private IEnumerator LoadAssetBundle(string relativeUrl)
		{
			string assetBundleName = relativeUrl.ToLower();
			string[] deps = _assetBundleManifest.GetDirectDependencies(assetBundleName);
			_depLoaders = new AssetBundleLoader[deps.Length];
			for (int d2 = 0; d2 < deps.Length; d2++)
			{
				string url2 = deps[d2];
				_depLoaders[d2] = Load(url2, null, _loaderMode);
				yield return null;
			}
			for (int d2 = 0; d2 < _depLoaders.Length; d2++)
			{
				AssetBundleLoader loader = _depLoaders[d2];
				while (!loader.IsCompleted)
				{
					yield return null;
				}
			}
			relativeUrl = relativeUrl.ToLower();
			string url = KResourceModule.BundlesPathRelative + relativeUrl;
			if (KResourceModule.GetResourceFullPath(url, _loaderMode == LoaderMode.Async, out var fullPath) == KResourceModule.GetResourceFullPathType.Invalid)
			{
				if (UnityEngine.Debug.isDebugBuild)
				{
					Log.Error("[HotBytesLoader]Error Path: {0}", url);
				}
				OnFinish(null);
				yield break;
			}
			_wwwLoader = KWWWRequestBundleLoader.Load(fullPath);
			while (!_wwwLoader.IsCompleted)
			{
				Progress = _wwwLoader.Progress;
				yield return null;
			}
			if (!_wwwLoader.IsSuccess)
			{
				Log.Error("[HotBytesLoader]Error Load WWW: {0}", url);
				OnFinish(null);
			}
			else
			{
				DownloadHandlerAssetBundle downloadHandlerAssetBundle = _wwwLoader.Www.downloadHandler as DownloadHandlerAssetBundle;
				OnFinish(downloadHandlerAssetBundle.assetBundle);
			}
		}

		protected override void OnFinish(object resultObj)
		{
			if (_wwwLoader != null)
			{
				_wwwLoader.Release();
				_wwwLoader = null;
			}
			base.OnFinish(resultObj);
		}

		protected override void DoDispose()
		{
			if (Bundle != null)
			{
				Bundle.Unload(unloadAllLoadedObjects: false);
			}
			base.DoDispose();
			if (BundleParser != null)
			{
				BundleParser.Dispose(unloadAllAssets: false);
			}
			AssetBundleLoader[] depLoaders = _depLoaders;
			for (int i = 0; i < depLoaders.Length; i++)
			{
				depLoaders[i].Release();
			}
			_depLoaders = null;
			if (_loadedAssets != null)
			{
				_loadedAssets.Clear();
				_loadedAssets = null;
			}
		}

		public override void Release()
		{
			if (Application.isEditor && base.Url.Contains("Arial"))
			{
				Log.Error("要释放Arial字体！！错啦！！builtinextra:{0}", base.Url);
			}
			base.Release();
		}

		public void PushLoadedAsset(UnityEngine.Object getAsset)
		{
			if (_loadedAssets == null)
			{
				_loadedAssets = new List<UnityEngine.Object>();
			}
			_loadedAssets.Add(getAsset);
		}
	}
	public class KAssetBundleParser
	{
		public enum CAssetBundleParserMode
		{
			Async,
			Sync
		}

		public static CAssetBundleParserMode Mode = CAssetBundleParserMode.Async;

		private bool IsDisposed;

		private bool UnloadAllAssets;

		private readonly Action<AssetBundle> Callback;

		public bool IsFinished;

		public AssetBundle Bundle;

		public static Func<string, byte[], byte[]> BundleBytesFilter = null;

		private static int _autoPriority = 1;

		private readonly AssetBundleCreateRequest CreateRequest;

		public string RelativePath;

		private readonly float _startTime;

		public float Progress => CreateRequest.progress;

		public KAssetBundleParser(string relativePath, byte[] bytes, Action<AssetBundle> callback = null)
		{
			if (UnityEngine.Debug.isDebugBuild)
			{
				_startTime = Time.realtimeSinceStartup;
			}
			Callback = callback;
			RelativePath = relativePath;
			byte[] binary = (BundleBytesFilter ?? new Func<string, byte[], byte[]>(DefaultParseAb))(relativePath, bytes);
			switch (Mode)
			{
			case CAssetBundleParserMode.Async:
				CreateRequest = AssetBundle.LoadFromMemoryAsync(binary);
				CreateRequest.priority = _autoPriority++;
				KResourceModule.Instance.StartCoroutine(WaitCreateAssetBundle(CreateRequest));
				break;
			case CAssetBundleParserMode.Sync:
				OnFinish(AssetBundle.LoadFromMemory(binary));
				break;
			default:
				throw new Exception("Error CAssetBundleParserMode: " + Mode);
			}
		}

		private void OnFinish(AssetBundle bundle)
		{
			IsFinished = true;
			Bundle = bundle;
			if (IsDisposed)
			{
				DisposeBundle();
			}
			else if (Callback != null)
			{
				Callback(Bundle);
			}
			if (Application.isEditor && UnityEngine.Debug.isDebugBuild)
			{
				float num = Time.realtimeSinceStartup - _startTime;
				float num2 = ((Mode == CAssetBundleParserMode.Async) ? 1f : 0.3f);
				if (num > num2)
				{
					Log.Warning("[KAssetBundleParser] Parse Too long time: {0},  used time: {1}", RelativePath, num);
				}
			}
		}

		private IEnumerator WaitCreateAssetBundle(AssetBundleCreateRequest req)
		{
			float startTime = Time.time;
			while (!req.isDone)
			{
				yield return null;
			}
			if (Application.isEditor && Time.time - startTime > 5f)
			{
				Log.Warning("[CAssetBundlerParser]{0} 解压/读取Asset太久了! 花了{1}秒, 超过 {2}秒", RelativePath, Time.time - startTime, 5f);
			}
			OnFinish(req.assetBundle);
		}

		private static byte[] DefaultParseAb(string relativePath, byte[] bytes)
		{
			return bytes;
		}

		private void DisposeBundle()
		{
			Bundle.Unload(UnloadAllAssets);
		}

		public void Dispose(bool unloadAllAssets)
		{
			UnloadAllAssets = unloadAllAssets;
			if (Bundle != null)
			{
				DisposeBundle();
			}
			IsDisposed = true;
		}
	}
	public class AssetFileLoader : AbstractResourceLoader
	{
		public delegate void AssetFileBridgeDelegate(bool isOk, UnityEngine.Object resultObj);

		private bool IsLoadAssetBundle;

		private AssetBundleLoader _bundleLoader;

		public UnityEngine.Object Asset => base.ResultObject as UnityEngine.Object;

		public override float Progress
		{
			get
			{
				if (_bundleLoader != null)
				{
					return _bundleLoader.Progress;
				}
				return 0f;
			}
		}

		public static AssetFileLoader Load(string path, AssetFileBridgeDelegate assetFileLoadedCallback = null, LoaderMode loaderMode = LoaderMode.Async)
		{
			if (!KResourceModule.IsEditorLoadAsset)
			{
				path += AppEngine.GetConfig(KEngineDefaultConfigs.AssetBundleExt);
			}
			LoaderDelgate callback = null;
			if (assetFileLoadedCallback != null)
			{
				callback = delegate(bool isOk, object obj)
				{
					assetFileLoadedCallback(isOk, obj as UnityEngine.Object);
				};
			}
			return AbstractResourceLoader.AutoNew<AssetFileLoader>(path, callback, forceCreateNew: false, new object[1] { loaderMode });
		}

		public static bool IsBundleResourceExist(string url)
		{
			if (KResourceModule.IsEditorLoadAsset && File.Exists("Assets/BundleResources/" + url))
			{
				return true;
			}
			return KResourceModule.IsResourceExist(KResourceModule.BundlesPathRelative + url.ToLower() + AppEngine.GetConfig(KEngineDefaultConfigs.AssetBundleExt));
		}

		protected override void Init(string url, params object[] args)
		{
			LoaderMode loaderMode = (LoaderMode)args[0];
			base.Init(url, args);
			KResourceModule.Instance.StartCoroutine(_Init(base.Url, loaderMode));
		}

		private IEnumerator _Init(string path, LoaderMode loaderMode)
		{
			IsLoadAssetBundle = AppEngine.GetConfig("KEngine", "IsLoadAssetBundle").ToInt32() != 0;
			UnityEngine.Object @object = null;
			if (KResourceModule.IsEditorLoadAsset && Application.isEditor)
			{
				Log.Error("`IsEditorLoadAsset` is Unity Editor only");
			}
			else if (!IsLoadAssetBundle)
			{
				string extension = Path.GetExtension(path);
				path = path.Substring(0, path.Length - extension.Length);
				@object = Resources.Load<UnityEngine.Object>(path);
				if (@object == null)
				{
					Log.Error("Asset is NULL(from Resources Folder): {0}", path);
				}
			}
			else
			{
				_bundleLoader = AssetBundleLoader.Load(path, null, loaderMode);
				while (!_bundleLoader.IsCompleted)
				{
					if (base.IsReadyDisposed)
					{
						UnityEngine.Debug.Log("release bundleLoader:" + _bundleLoader.ToString());
						_bundleLoader.Release();
						OnFinish(null);
						yield break;
					}
					yield return null;
				}
				if (!_bundleLoader.IsSuccess)
				{
					Log.Error("[AssetFileLoader]Load BundleLoader Failed(Error) when Finished: {0}", path);
					_bundleLoader.Release();
					OnFinish(null);
					yield break;
				}
				AssetBundle bundle = _bundleLoader.Bundle;
				DateTime beginTime = DateTime.Now;
				string text = Path.GetFileNameWithoutExtension(base.Url).ToLower();
				if (!bundle.isStreamedSceneAssetBundle)
				{
					if (loaderMode == LoaderMode.Sync)
					{
						@object = bundle.LoadAsset(text);
						Debuger.Assert(@object);
						_bundleLoader.PushLoadedAsset(@object);
					}
					else
					{
						UnityEngine.Debug.Log("assetName:" + text);
						AssetBundleRequest request = bundle.LoadAssetAsync(text);
						while (!request.isDone)
						{
							yield return null;
						}
						Debuger.Assert(@object = request.asset);
						_bundleLoader.PushLoadedAsset(@object);
					}
				}
				else
				{
					@object = KResourceModule.Instance;
				}
				KResourceModule.LogLoadTime("AssetFileBridge", path, beginTime);
				if (@object == null)
				{
					Log.Error("Asset is NULL: {0}", path);
				}
			}
			if (Application.isEditor)
			{
				if (@object != null)
				{
					KResoourceLoadedAssetDebugger.Create(@object.GetType().Name, base.Url, @object);
				}
				if (@object is GameObject)
				{
					Renderer[] componentsInChildren = (@object as GameObject).GetComponentsInChildren<Renderer>(includeInactive: true);
					for (int i = 0; i < componentsInChildren.Length; i++)
					{
						RefreshMaterialsShaders(componentsInChildren[i]);
					}
				}
			}
			OnFinish(@object);
		}

		public static void RefreshMaterialsShaders(Renderer renderer)
		{
			if (renderer.sharedMaterials == null)
			{
				return;
			}
			Material[] sharedMaterials = renderer.sharedMaterials;
			foreach (Material material in sharedMaterials)
			{
				if (material != null && material.shader != null)
				{
					material.shader = Shader.Find(material.shader.name);
				}
			}
		}

		protected override void DoDispose()
		{
			if (_bundleLoader != null)
			{
				_bundleLoader.Release();
			}
			if (!IsLoadAssetBundle)
			{
				Resources.UnloadAsset(base.ResultObject as UnityEngine.Object);
			}
			else
			{
				UnityEngine.Debug.Log("releasing " + base.ResultObject.ToString());
				_ = Application.isEditor;
			}
			base.DoDispose();
		}
	}
	public class AudioLoader : AbstractResourceLoader
	{
		private AssetFileLoader AssetFileBridge;

		private AudioClip ResultAudioClip => base.ResultObject as AudioClip;

		public override float Progress => AssetFileBridge.Progress;

		public static AudioLoader Load(string url, Action<bool, AudioClip> callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as AudioClip);
				};
			}
			return AbstractResourceLoader.AutoNew<AudioLoader>(url, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			AssetFileBridge = AssetFileLoader.Load(url, delegate(bool isOk, UnityEngine.Object obj)
			{
				OnFinish(obj);
			});
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			AssetFileBridge.Release();
		}
	}
	public class HotBytesLoader : AbstractResourceLoader
	{
		private KWWWLoader _wwwLoader;

		private LoaderMode _loaderMode;

		private string _fullUrl;

		public byte[] Bytes { get; private set; }

		public static HotBytesLoader Load(string path, LoaderMode loaderMode)
		{
			return AbstractResourceLoader.AutoNew<HotBytesLoader>(path, null, forceCreateNew: false, new object[1] { loaderMode });
		}

		public static byte[] LoadSync(string url)
		{
			string fullPath;
			switch (KResourceModule.GetResourceFullPath(url, withFileProtocol: false, out fullPath))
			{
			case KResourceModule.GetResourceFullPathType.Invalid:
				if (UnityEngine.Debug.isDebugBuild)
				{
					Log.Error("[HotBytesLoader]Error Path: {0}", url);
				}
				return null;
			case KResourceModule.GetResourceFullPathType.InApp:
				if (Application.isEditor)
				{
					return KResourceModule.ReadAllBytes(Path.Combine(KResourceModule.ProductPathWithoutFileProtocol, url));
				}
				return KResourceModule.LoadSyncFromStreamingAssets(url);
			default:
				return KResourceModule.ReadAllBytes(fullPath);
			}
		}

		private IEnumerator CoLoad(string url)
		{
			if (_loaderMode == LoaderMode.Sync)
			{
				Bytes = LoadSync(url);
			}
			else
			{
				if (KResourceModule.GetResourceFullPath(url, _loaderMode == LoaderMode.Async, out _fullUrl) == KResourceModule.GetResourceFullPathType.Invalid)
				{
					if (UnityEngine.Debug.isDebugBuild)
					{
						Log.Error("[HotBytesLoader]Error Path: {0}", url);
					}
					OnFinish(null);
					yield break;
				}
				_wwwLoader = KWWWLoader.Load(_fullUrl);
				while (!_wwwLoader.IsCompleted)
				{
					Progress = _wwwLoader.Progress;
					yield return null;
				}
				if (!_wwwLoader.IsSuccess)
				{
					Log.Error("[HotBytesLoader]Error Load WWW: {0}", url);
					OnFinish(null);
					yield break;
				}
				Bytes = _wwwLoader.Www.downloadHandler.data;
			}
			OnFinish(Bytes);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			if (_wwwLoader != null)
			{
				_wwwLoader.Release();
			}
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			_loaderMode = (LoaderMode)args[0];
			KResourceModule.Instance.StartCoroutine(CoLoad(url));
		}
	}
	public class KEngineAndroidPlugin
	{
		private static AndroidJavaClass _helper;

		private static AndroidJavaClass AndroidHelper
		{
			get
			{
				if (_helper != null)
				{
					return _helper;
				}
				_helper = new AndroidJavaClass("com.github.KEngine.AndroidHelper");
				if (_helper == null)
				{
					ErrorNotSupport();
				}
				return _helper;
			}
		}

		private static void ErrorNotSupport()
		{
			throw new Exception("[KEngineAndroidPlugin.cs]Error on Android Plugin. Check if KEngine.Android.jar file exist in your Plugins/Android/libs? KEngine DLL mode also not support.");
		}

		public static bool IsAssetExists(string path)
		{
			return AndroidHelper.CallStatic<bool>("isAssetExists", new object[1] { path });
		}

		public static string GetAssetString(string path)
		{
			return AndroidHelper.CallStatic<string>("getAssetString", new object[1] { path });
		}

		public static byte[] GetAssetBytes(string path)
		{
			return AndroidHelper.CallStatic<byte[]>("getAssetBytes", new object[1] { path });
		}
	}
	public class FontLoader : AbstractResourceLoader
	{
		private AssetFileLoader _bridge;

		public override float Progress => _bridge.Progress;

		public static FontLoader Load(string path, Action<bool, Font> callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as Font);
				};
			}
			return AbstractResourceLoader.AutoNew<FontLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			_bridge = AssetFileLoader.Load(base.Url, delegate(bool _isOk, UnityEngine.Object _obj)
			{
				OnFinish(_obj);
			});
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			_bridge.Release();
		}
	}
	public class KHttpDownloader : MonoBehaviour, IDisposable
	{
		private string _saveFullPath;

		private float TIME_OUT_DEF;

		private bool FinishedFlag;

		private bool ErrorFlag;

		private bool _useContinue;

		private bool UseCache;

		private int ExpireDays = 1;

		public float Progress;

		public int TotalSize = int.MaxValue;

		public string SaveFullPath => _saveFullPath;

		public string Url { get; private set; }

		public bool IsFinished
		{
			get
			{
				if (!ErrorFlag)
				{
					return FinishedFlag;
				}
				return true;
			}
		}

		public bool IsError => ErrorFlag;

		public string TmpDownloadPath => _saveFullPath + ".download";

		private KHttpDownloader()
		{
		}

		public static KHttpDownloader Load(string fullUrl, string saveFullPath, bool useContinue = false, bool useCache = false, int expireDays = 1, int timeout = 5)
		{
			KHttpDownloader kHttpDownloader = new GameObject("HttpDownloader+" + fullUrl).AddComponent<KHttpDownloader>();
			kHttpDownloader.Init(fullUrl, saveFullPath, useContinue, useCache, expireDays, timeout);
			UnityEngine.Object.DontDestroyOnLoad(kHttpDownloader.gameObject);
			return kHttpDownloader;
		}

		public static string GetFullSavePath(string relativePath)
		{
			return Application.persistentDataPath + "/" + relativePath;
		}

		private void Init(string fullUrl, string saveFullPath, bool useContinue, bool useCache = false, int expireDays = 1, int timeout = 10)
		{
			Url = fullUrl;
			_saveFullPath = saveFullPath;
			UseCache = useCache;
			_useContinue = useContinue;
			ExpireDays = expireDays;
			TIME_OUT_DEF = timeout;
			StartCoroutine(StartDownload(fullUrl));
		}

		public static KHttpDownloader Load(string fullUrl, string saveFullPath, int expireDays, int timeout = 5)
		{
			return Load(fullUrl, saveFullPath, expireDays != 0, useCache: true, expireDays, timeout);
		}

		private IEnumerator StartDownload(string fullUrl)
		{
			if (UseCache && File.Exists(_saveFullPath))
			{
				DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(_saveFullPath);
				UnityEngine.Debug.Log($"缓存文件: {_saveFullPath}, 最后修改时间: {lastWriteTimeUtc}");
				if ((DateTime.Now - lastWriteTimeUtc).TotalDays < (double)ExpireDays)
				{
					UnityEngine.Debug.Log($"缓存文件未过期 {_saveFullPath}");
					FinishedFlag = true;
					ErrorFlag = false;
					yield break;
				}
			}
			string directoryName = Path.GetDirectoryName(_saveFullPath);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			int totalSize = int.MaxValue;
			int downloadSize = 0;
			bool isThreadError = false;
			bool isThreadFinish = false;
			bool isThreadStart = false;
			ThreadPool.QueueUserWorkItem(delegate
			{
				ThreadableResumeDownload(fullUrl, delegate(int totalSizeNow, int downSizeNow)
				{
					totalSize = totalSizeNow;
					downloadSize = downSizeNow;
					isThreadStart = true;
				}, delegate
				{
					isThreadError = true;
					isThreadFinish = true;
					isThreadStart = true;
				}, delegate
				{
					isThreadFinish = true;
				});
			});
			float timeCounter = 0f;
			float MaxTime = TIME_OUT_DEF;
			while (!isThreadFinish && !isThreadError)
			{
				timeCounter += Time.deltaTime;
				if (timeCounter > MaxTime && !isThreadStart)
				{
					UnityEngine.Debug.LogError($"[KHttpDownloader]下载线程超时！: {fullUrl}");
					isThreadError = true;
					break;
				}
				Progress = (float)downloadSize / (float)totalSize;
				yield return null;
			}
			if (isThreadError)
			{
				UnityEngine.Debug.LogError($"Download WWW Error: {fullUrl}");
				ErrorFlag = true;
				OnFinish();
			}
			else
			{
				OnFinish();
			}
		}

		private void OnFinish()
		{
			FinishedFlag = true;
		}

		public byte[] GetDatas()
		{
			if (!IsFinished || IsError)
			{
				throw new Exception("GetDatas: Error");
			}
			return File.ReadAllBytes(_saveFullPath);
		}

		private void ThreadableResumeDownload(string url, Action<int, int> stepCallback, Action errorCallback, Action successCallback)
		{
			long num = 0L;
			FileStream fileStream;
			if (_useContinue && File.Exists(TmpDownloadPath))
			{
				fileStream = File.OpenWrite(TmpDownloadPath);
				num = fileStream.Length;
				fileStream.Seek(num, SeekOrigin.Current);
				Console.WriteLine("Resume.... from {0}", num);
			}
			else
			{
				fileStream = new FileStream(TmpDownloadPath, FileMode.OpenOrCreate);
				num = 0L;
			}
			HttpWebRequest httpWebRequest = null;
			try
			{
				httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
				if (num > 0)
				{
					httpWebRequest.AddRange((int)num);
				}
				Console.WriteLine("Getting Response : {0}", url);
				using (WebResponse webResponse = httpWebRequest.GetResponse())
				{
					TotalSize = (int)webResponse.ContentLength;
					Console.WriteLine("Getted Response : {0}", url);
					if (IsFinished)
					{
						throw new Exception($"Get Response ok, but is finished , maybe timeout! : {url}");
					}
					int totalSize = TotalSize;
					using Stream stream = webResponse.GetResponseStream();
					Console.WriteLine("Start Stream: {0}", url);
					int num2 = (int)num;
					int num3 = 10240;
					byte[] buffer = new byte[num3];
					int num4 = (int)num;
					while ((num4 = stream.Read(buffer, 0, num3)) > 0)
					{
						if (IsFinished)
						{
							throw new Exception("When Reading Web stream but Downloder Finished!");
						}
						fileStream.Write(buffer, 0, num4);
						num2 += num4;
						stepCallback(totalSize, num2);
					}
					stepCallback(totalSize, totalSize);
					httpWebRequest.Abort();
					fileStream.Close();
				}
				Console.WriteLine("下载完成: {0}", url);
				if (File.Exists(_saveFullPath))
				{
					File.Delete(_saveFullPath);
				}
				File.Move(TmpDownloadPath, _saveFullPath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("下载过程中出现错误:" + ex.ToString());
				fileStream.Close();
				httpWebRequest?.Abort();
				try
				{
					if (File.Exists(TmpDownloadPath))
					{
						File.Delete(TmpDownloadPath);
					}
				}
				catch (Exception ex2)
				{
					Console.WriteLine(ex2.Message);
				}
				errorCallback();
			}
			successCallback();
		}

		private void OnDestroy()
		{
			if (!FinishedFlag)
			{
				FinishedFlag = true;
				ErrorFlag = true;
				Console.WriteLine($"[HttpDownloader]Not finish but destroy: {Url}");
			}
		}

		public void Dispose()
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
	}
	public class InstanceAssetLoader : AbstractResourceLoader
	{
		public delegate void KAssetLoaderDelegate(bool isOk, UnityEngine.Object asset, object[] args);

		private AssetFileLoader _assetFileBridge;

		public GameObject InstanceAsset { get; private set; }

		public override float Progress => _assetFileBridge.Progress;

		public static InstanceAssetLoader Load(string url, AssetFileLoader.AssetFileBridgeDelegate callback = null)
		{
			return AbstractResourceLoader.AutoNew<InstanceAssetLoader>(url, delegate(bool ok, object resultObject)
			{
				if (callback != null)
				{
					callback(ok, resultObject as UnityEngine.Object);
				}
			}, forceCreateNew: true, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			_assetFileBridge = AssetFileLoader.Load(url, delegate(bool isOk, UnityEngine.Object asset)
			{
				if (base.IsReadyDisposed)
				{
					OnFinish(null);
				}
				else if (!isOk)
				{
					OnFinish(null);
					Log.Error("[InstanceAssetLoader]Error on assetfilebridge loaded... {0}", url);
				}
				else
				{
					try
					{
						InstanceAsset = UnityEngine.Object.Instantiate(asset as GameObject);
					}
					catch (Exception e)
					{
						Log.LogException(e);
					}
					if (Application.isEditor)
					{
						KResoourceLoadedAssetDebugger.Create("AssetCopy", url, InstanceAsset);
					}
					OnFinish(InstanceAsset);
				}
			});
		}

		public static AssetFileLoader Preload(string path, Action<bool> callback = null)
		{
			return AssetFileLoader.Load(path, delegate(bool isOk, UnityEngine.Object asset)
			{
				if (callback != null)
				{
					callback(isOk);
				}
			});
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			_assetFileBridge.Release();
			if (InstanceAsset != null)
			{
				UnityEngine.Object.Destroy(InstanceAsset);
				InstanceAsset = null;
			}
		}

		public static IEnumerator CoPreload(string path, Action<bool> callback = null)
		{
			AssetFileLoader w = AssetFileLoader.Load(path);
			while (!w.IsCompleted)
			{
				yield return null;
			}
			callback?.Invoke(!w.IsError);
		}
	}
	public class MaterialLoader : AbstractResourceLoader
	{
		public delegate void CCMaterialLoaderDelegate(bool isOk, Material mat);

		private List<TextureLoader> TextureLoaders;

		public Material Mat { get; private set; }

		public static MaterialLoader Load(string path, CCMaterialLoaderDelegate callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as Material);
				};
			}
			return AbstractResourceLoader.AutoNew<MaterialLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			KResourceModule.Instance.StartCoroutine(CoLoadSerializeMaterial());
		}

		private IEnumerator CoLoadSerializeMaterial()
		{
			AssetFileLoader matLoadBridge = AssetFileLoader.Load(base.Url);
			while (!matLoadBridge.IsCompleted)
			{
				Progress = matLoadBridge.Progress;
				yield return null;
			}
			KSerializeMaterial kSerializeMaterial = matLoadBridge.ResultObject as KSerializeMaterial;
			Debuger.Assert(kSerializeMaterial);
			Desc = kSerializeMaterial.ShaderName;
			Debuger.Assert(Mat == null);
			yield return KResourceModule.Instance.StartCoroutine(CoGenerateMaterial(base.Url, kSerializeMaterial));
			Debuger.Assert(Mat);
			matLoadBridge.Release();
			if (Application.isEditor)
			{
				KResoourceLoadedAssetDebugger.Create("Material", base.Url, Mat);
			}
			OnFinish(Mat);
		}

		protected override void OnFinish(object resultObj)
		{
			if (resultObj == null)
			{
				Log.Error("[MaterialLoader:OnFinishe] Null Material: {0}", base.Url);
			}
			base.OnFinish(resultObj);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			if (TextureLoaders != null)
			{
				foreach (TextureLoader textureLoader in TextureLoaders)
				{
					textureLoader.Release();
				}
				TextureLoaders.Clear();
			}
			UnityEngine.Object.Destroy(Mat);
		}

		private string ParseMaterialStr(string materialTextureStr, out Vector2 tiling, out Vector2 offset)
		{
			string[] array = materialTextureStr.Split('|');
			Debuger.Assert(array.Length != 0);
			string result = array[0];
			tiling = Vector2.one;
			offset = Vector2.zero;
			if (array.Length > 1)
			{
				tiling = new Vector2(array[1].ToFloat(), array[2].ToFloat());
				offset = new Vector2(array[3].ToFloat(), array[4].ToFloat());
			}
			return result;
		}

		private IEnumerator CoGenerateMaterial(string matPath, KSerializeMaterial sMat)
		{
			ShaderLoader shaderLoader = ShaderLoader.Load(sMat.ShaderPath);
			while (!shaderLoader.IsCompleted)
			{
				yield return null;
			}
			Shader shader = shaderLoader.ShaderAsset;
			if (shader == null)
			{
				shader = KTool.FindShader(sMat.ShaderName);
				Log.Warning("无法加载Shader资源: {0}, 使用Shaders.Find代替", sMat.ShaderName);
				if (shader == null)
				{
					Log.Warning("找不到Shader: {0}, 使用Diffuse临时代替", sMat.ShaderName);
					shader = KTool.FindShader("Diffuse");
				}
			}
			Debuger.Assert(shader);
			Mat = new Material(shader);
			Mat.name = sMat.MaterialName;
			foreach (KSerializeMaterialProperty shaderProp in sMat.Props)
			{
				Vector2 tiling;
				Vector2 offset;
				switch (shaderProp.Type)
				{
				case KSerializeMaterialProperty.ShaderType.Texture:
				{
					string texturePath = ParseMaterialStr(shaderProp.PropValue, out tiling, out offset);
					if (TextureLoaders == null)
					{
						TextureLoaders = new List<TextureLoader>();
					}
					TextureLoader texLoader = TextureLoader.Load(texturePath);
					TextureLoaders.Add(texLoader);
					while (!texLoader.IsCompleted)
					{
						yield return null;
					}
					Texture asset = texLoader.Asset;
					if (asset == null)
					{
						Log.Error("找不到纹理: {0}", texturePath);
					}
					else
					{
						_SetMatTex(Mat, shaderProp.PropName, asset, tiling, offset);
					}
					break;
				}
				case KSerializeMaterialProperty.ShaderType.Color:
					_SetMatColor(Mat, shaderProp.PropName, shaderProp.PropValue);
					break;
				case KSerializeMaterialProperty.ShaderType.Range:
					_SetMatRange(Mat, shaderProp.PropName, shaderProp.PropValue);
					break;
				case KSerializeMaterialProperty.ShaderType.Vector:
					_SetMatVector(Mat, shaderProp.PropName, shaderProp.PropValue);
					break;
				}
				tiling = default(Vector2);
				offset = default(Vector2);
			}
		}

		private void _SetMatVector(Material mat, string propName, string propValue)
		{
			if (mat.HasProperty(propName))
			{
				propValue = propValue.Trim('(', ')');
				string[] array = propValue.Split(',');
				Vector4 value = new Vector4(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]), float.Parse(array[3]));
				mat.SetVector(propName, value);
			}
		}

		private void _SetMatRange(Material mat, string propName, string propValue)
		{
			if (mat.HasProperty(propName))
			{
				mat.SetFloat(propName, float.Parse(propValue));
				return;
			}
			Log.Error("[_SetMatRange]Cannot find shader property: {0}", propName);
		}

		private void _SetMatColor(Material mat, string colorPropName, string _colorStr)
		{
			if (mat.HasProperty(colorPropName))
			{
				_colorStr = _colorStr.Replace("RGBA(", "").Replace(")", "");
				string[] array = _colorStr.Split(',');
				Color value = new Color(float.Parse(array[0]), float.Parse(array[1]), float.Parse(array[2]), float.Parse(array[3]));
				if (mat.HasProperty(colorPropName))
				{
					mat.SetColor(colorPropName, value);
					return;
				}
				Log.Error("[_SetMatColor]Cannot find shader property: {0}", colorPropName);
			}
		}

		private void _SetMatTex(Material mat, string matPropName, Texture tex, Vector2 tiling, Vector2 offset)
		{
			mat.SetTexture(matPropName, tex);
			mat.SetTextureScale(matPropName, tiling);
			mat.SetTextureOffset(matPropName, offset);
		}
	}
	public enum KResourceQuality
	{
		Sd = 2,
		Hd = 1,
		Ld = 4
	}
	public enum KResourcePathPriorityType
	{
		Invalid,
		InAppPathPriority,
		PersistentDataPathPriority
	}
	public class KResourceModule : MonoBehaviour
	{
		public delegate void AsyncLoadABAssetDelegate(UnityEngine.Object asset, object[] args);

		public enum LoadingLogLevel
		{
			None,
			ShowTime,
			ShowDetail
		}

		public enum GetResourceFullPathType
		{
			Invalid,
			InApp,
			InDocument
		}

		public static KResourceQuality Quality;

		private static KResourceModule _Instance;

		public static bool LoadByQueue;

		public static int LogLevel;

		public static string DocumentResourcesPath;

		public static KResourcePathPriorityType ResourcePathPriorityType;

		public static Func<string, string> CustomGetResourcesPath;

		private static string _unityEditorEditorUserBuildSettingsActiveBuildTarget;

		public static float TextureScale => 1f / (float)Quality;

		public static KResourceModule Instance
		{
			get
			{
				if (_Instance == null)
				{
					GameObject gameObject = GameObject.Find("_ResourceModule_");
					if (gameObject == null)
					{
						gameObject = new GameObject("_ResourceModule_");
						UnityEngine.Object.DontDestroyOnLoad(gameObject);
					}
					_Instance = gameObject.AddComponent<KResourceModule>();
				}
				return _Instance;
			}
		}

		public static string BuildPlatformName => GetBuildPlatformName();

		public static string FileProtocol => GetFileProtocol();

		public static string ProductRelPath => AppEngine.GetConfig(KEngineDefaultConfigs.ProductRelPath);

		public static string EditorProductFullPath => Path.GetFullPath(ProductRelPath);

		public static string ProductPathWithProtocol { get; private set; }

		public static string ProductPathWithoutFileProtocol { get; private set; }

		public static string BundlesPathRelative { get; private set; }

		public static string ApplicationPath { get; private set; }

		public static string DocumentResourcesPathWithoutFileProtocol => $"{GetAppDataPath()}/";

		public static bool IsEditorLoadAsset
		{
			get
			{
				if (AppEngine.GetConfig("KEngine", "IsEditorLoadAsset").ToInt32() != 0)
				{
					return Application.isEditor;
				}
				return false;
			}
		}

		public static bool UsePersistentData => AppEngine.GetConfig("KEngine", "UsePersistentData").ToInt32() != 0;

		public static string UnityEditor_EditorUserBuildSettings_activeBuildTarget
		{
			get
			{
				if (Application.isPlaying && !string.IsNullOrEmpty(_unityEditorEditorUserBuildSettingsActiveBuildTarget))
				{
					return _unityEditorEditorUserBuildSettingsActiveBuildTarget;
				}
				Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
				foreach (Assembly assembly in assemblies)
				{
					if (assembly.GetName().Name == "UnityEditor")
					{
						return _unityEditorEditorUserBuildSettingsActiveBuildTarget = assembly.GetType("UnityEditor.EditorUserBuildSettings").GetProperty("activeBuildTarget").GetGetMethod()
							.Invoke(null, new object[0])
							.ToString();
					}
				}
				return null;
			}
		}

		public static string BundlesDirName => AppEngine.GetConfig(KEngineDefaultConfigs.StreamingBundlesFolderName);

		public static string EditorAssetBundleFullPath => Path.GetFullPath(AppEngine.GetConfig(KEngineDefaultConfigs.AssetBundleBuildRelPath));

		static KResourceModule()
		{
			Quality = KResourceQuality.Sd;
			LoadByQueue = false;
			LogLevel = 0;
			ResourcePathPriorityType = KResourcePathPriorityType.PersistentDataPathPriority;
			InitResourcePath();
		}

		public static string GetAssetBundlePath(string path, params object[] formats)
		{
			return string.Format(path + AppEngine.GetConfig("KEngine", "AssetBundleExt"), formats);
		}

		public static bool ContainsResourceUrl(string resourceUrl)
		{
			string fullPath;
			return GetResourceFullPath(resourceUrl, withFileProtocol: false, out fullPath, isLog: false) != GetResourceFullPathType.Invalid;
		}

		public static string GetResourceFullPath(string url, bool withFileProtocol = true, bool isLog = true)
		{
			if (GetResourceFullPath(url, withFileProtocol, out var fullPath, isLog) != 0)
			{
				return fullPath;
			}
			return null;
		}

		public static bool IsResourceExist(string url)
		{
			string newUrl;
			bool num = TryGetDocumentResourceUrl(url, withFileProtocol: false, out newUrl);
			bool flag = TryGetInAppStreamingUrl(url, withFileProtocol: false, out newUrl);
			return num || flag;
		}

		public static GetResourceFullPathType GetResourceFullPath(string url, bool withFileProtocol, out string fullPath, bool isLog = true)
		{
			if (string.IsNullOrEmpty(url))
			{
				Log.Error("尝试获取一个空的资源路径！");
			}
			string newUrl;
			bool flag = TryGetDocumentResourceUrl(url, withFileProtocol, out newUrl);
			string newUrl2;
			bool flag2 = TryGetInAppStreamingUrl(url, withFileProtocol, out newUrl2);
			if (ResourcePathPriorityType == KResourcePathPriorityType.PersistentDataPathPriority && flag)
			{
				if (Application.isEditor)
				{
					Log.Warning("[Use PersistentDataPath] {0}", newUrl);
				}
				fullPath = newUrl;
				return GetResourceFullPathType.InDocument;
			}
			if (!flag2)
			{
				if (isLog)
				{
					Log.Error("[Not Found] StreamingAssetsPath Url Resource: {0}", url);
				}
				fullPath = null;
				return GetResourceFullPathType.Invalid;
			}
			fullPath = newUrl2;
			return GetResourceFullPathType.InApp;
		}

		public static string GetAppDataPath()
		{
			return Application.persistentDataPath;
		}

		public static bool TryGetInAppStreamingUrl(string url, bool withFileProtocol, out string newUrl)
		{
			if (withFileProtocol)
			{
				newUrl = ProductPathWithProtocol + url;
			}
			else
			{
				newUrl = ProductPathWithoutFileProtocol + url;
			}
			if (!Application.isEditor && Application.platform == RuntimePlatform.Android)
			{
				if (!KEngineAndroidPlugin.IsAssetExists(url))
				{
					return false;
				}
			}
			else if (!File.Exists(ProductPathWithoutFileProtocol + url))
			{
				return false;
			}
			if (Application.isEditor && !FileExistsWithDifferentCase(ProductPathWithoutFileProtocol + url))
			{
				Log.Error("[大小写敏感]发现一个资源 {0}，大小写出现问题，在Windows可以读取，手机不行，请改表修改！", url);
			}
			return true;
		}

		private static bool FileExistsWithDifferentCase(string filePath)
		{
			if (File.Exists(filePath))
			{
				string directoryName = Path.GetDirectoryName(filePath);
				string fileName = Path.GetFileName(filePath);
				string strA = Directory.GetFiles(directoryName, fileName)[0].Replace("\\", "/");
				filePath = filePath.Replace("\\", "/");
				filePath = filePath.Replace("//", "/");
				return string.CompareOrdinal(strA, filePath) == 0;
			}
			return false;
		}

		public static bool TryGetDocumentResourceUrl(string url, bool withFileProtocol, out string newUrl)
		{
			if (withFileProtocol)
			{
				newUrl = DocumentResourcesPath + url;
			}
			else
			{
				newUrl = DocumentResourcesPathWithoutFileProtocol + url;
			}
			if (File.Exists(DocumentResourcesPathWithoutFileProtocol + url))
			{
				return true;
			}
			return false;
		}

		private void Awake()
		{
			if (_Instance != null)
			{
				Debuger.Assert(_Instance == this);
			}
			if (UnityEngine.Debug.isDebugBuild)
			{
				Log.Info("ResourceManager ApplicationPath: {0}", ApplicationPath);
				Log.Info("ResourceManager ProductPathWithProtocol: {0}", ProductPathWithProtocol);
				Log.Info("ResourceManager ProductPathWithoutProtocol: {0}", ProductPathWithoutFileProtocol);
				Log.Info("ResourceManager DocumentResourcesPath: {0}", DocumentResourcesPath);
				Log.Info("================================================================================");
			}
		}

		private void Update()
		{
			AbstractResourceLoader.CheckGcCollect();
		}

		public static string GetBuildPlatformName()
		{
			string text = "Windows";
			if (Application.isEditor)
			{
				switch (UnityEditor_EditorUserBuildSettings_activeBuildTarget)
				{
				case "StandaloneOSXIntel":
				case "StandaloneOSXIntel64":
				case "StandaloneOSXUniversal":
					text = "MacOS";
					break;
				case "StandaloneWindows":
				case "StandaloneWindows64":
					text = "Windows";
					break;
				case "Android":
					text = "Android";
					break;
				case "iPhone":
				case "iOS":
					text = "iOS";
					break;
				default:
					Debuger.Assert(result: false);
					break;
				}
			}
			else
			{
				switch (Application.platform)
				{
				case RuntimePlatform.OSXPlayer:
					text = "MacOS";
					break;
				case RuntimePlatform.Android:
					text = "Android";
					break;
				case RuntimePlatform.IPhonePlayer:
					text = "iOS";
					break;
				case RuntimePlatform.WindowsPlayer:
					text = "Windows";
					break;
				default:
					Debuger.Assert(result: false);
					break;
				}
			}
			if (Quality != KResourceQuality.Sd)
			{
				text += Quality.ToString().ToUpper();
			}
			return text;
		}

		public static string GetFileProtocol()
		{
			string result = "file://";
			if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
			{
				result = "file:///";
			}
			return result;
		}

		public static AbstractResourceLoader LoadBundleAsync(string path, AssetFileLoader.AssetFileBridgeDelegate callback = null)
		{
			return AssetFileLoader.Load(path, callback);
		}

		public static AbstractResourceLoader LoadBundle(string path, AssetFileLoader.AssetFileBridgeDelegate callback = null)
		{
			return AssetFileLoader.Load(path, callback, LoaderMode.Sync);
		}

		public static bool IsStreamingAssetsExists(string path)
		{
			if (Application.platform == RuntimePlatform.Android)
			{
				return KEngineAndroidPlugin.IsAssetExists(path);
			}
			return File.Exists(Path.Combine(Application.streamingAssetsPath, path));
		}

		public static byte[] LoadSyncFromStreamingAssets(string path)
		{
			if (!IsStreamingAssetsExists(path))
			{
				throw new Exception("Not exist StreamingAssets path: " + path);
			}
			if (Application.platform == RuntimePlatform.Android)
			{
				return KEngineAndroidPlugin.GetAssetBytes(path);
			}
			return ReadAllBytes(Path.Combine(Application.streamingAssetsPath, path));
		}

		public static byte[] ReadAllBytes(string resPath)
		{
			using FileStream fileStream = File.Open(resPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			byte[] array = new byte[fileStream.Length];
			fileStream.Read(array, 0, (int)fileStream.Length);
			return array;
		}

		private static void InitResourcePath()
		{
			string editorProductFullPath = EditorProductFullPath;
			BundlesPathRelative = $"{BundlesDirName}/{GetBuildPlatformName()}/";
			DocumentResourcesPath = FileProtocol + DocumentResourcesPathWithoutFileProtocol;
			switch (Application.platform)
			{
			case RuntimePlatform.OSXEditor:
			case RuntimePlatform.WindowsEditor:
				ApplicationPath = $"{GetFileProtocol()}{editorProductFullPath}";
				ProductPathWithProtocol = GetFileProtocol() + EditorProductFullPath + "/";
				ProductPathWithoutFileProtocol = EditorProductFullPath + "/";
				break;
			case RuntimePlatform.OSXPlayer:
			case RuntimePlatform.WindowsPlayer:
			{
				string text = Application.streamingAssetsPath.Replace('\\', '/');
				ApplicationPath = $"{GetFileProtocol()}{Application.dataPath}";
				ProductPathWithProtocol = $"{GetFileProtocol()}{text}/";
				ProductPathWithoutFileProtocol = $"{text}/";
				break;
			}
			case RuntimePlatform.Android:
				ApplicationPath = "jar:" + GetFileProtocol() + Application.dataPath + "!/assets";
				ProductPathWithProtocol = ApplicationPath + "/";
				ProductPathWithoutFileProtocol = Application.dataPath + "!/assets/";
				break;
			case RuntimePlatform.IPhonePlayer:
				ApplicationPath = Uri.EscapeUriString(GetFileProtocol() + Application.streamingAssetsPath);
				ProductPathWithProtocol = $"{ApplicationPath}/";
				ProductPathWithoutFileProtocol = Application.streamingAssetsPath + "/";
				break;
			default:
				Debuger.Assert(result: false);
				break;
			}
		}

		public static void LogRequest(string resType, string resPath)
		{
			if (LogLevel >= 2)
			{
				Log.Info("[Request] {0}, {1}", resType, resPath);
			}
		}

		public static void LogLoadTime(string resType, string resPath, DateTime begin)
		{
			if (LogLevel >= 1)
			{
				Log.Info("[Load] {0}, {1}, {2}s", resType, resPath, (DateTime.Now - begin).TotalSeconds);
			}
		}

		public static void Collect()
		{
			while (AbstractResourceLoader.UnUsesLoaders.Count > 0)
			{
				AbstractResourceLoader.DoGarbageCollect();
			}
			Resources.UnloadUnusedAssets();
		}
	}
	public class ShaderLoader : AbstractResourceLoader
	{
		public delegate void ShaderLoaderDelegate(bool isOk, Shader shader);

		public Shader ShaderAsset => base.ResultObject as Shader;

		public static ShaderLoader Load(string path, ShaderLoaderDelegate callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as Shader);
				};
			}
			return AbstractResourceLoader.AutoNew<ShaderLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			KResourceModule.Instance.StartCoroutine(CoLoadShader());
		}

		private IEnumerator CoLoadShader()
		{
			AssetBundleLoader loader = AssetBundleLoader.Load(base.Url);
			while (!loader.IsCompleted)
			{
				Progress = loader.Progress;
				yield return null;
			}
			Shader shader = loader.Bundle.mainAsset as Shader;
			Debuger.Assert(shader);
			Desc = shader.name;
			if (Application.isEditor)
			{
				KResoourceLoadedAssetDebugger.Create("Shader", base.Url, shader);
			}
			loader.Release();
			OnFinish(shader);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			UnityEngine.Object.Destroy(ShaderAsset);
		}
	}
	public class SpriteLoader : AbstractResourceLoader
	{
		public delegate void CSpriteLoaderDelegate(bool isOk, Sprite tex);

		private AssetFileLoader AssetFileBridge;

		public Sprite Asset => base.ResultObject as Sprite;

		public override float Progress => AssetFileBridge.Progress;

		public string Path { get; private set; }

		public static SpriteLoader Load(string path, CSpriteLoaderDelegate callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					Texture2D texture2D = obj as Texture2D;
					Sprite tex = Sprite.Create(texture2D, new Rect(0f, 0f, texture2D.width, texture2D.height), new Vector2(0.5f, 0.5f));
					callback(isOk, tex);
				};
			}
			return AbstractResourceLoader.AutoNew<SpriteLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			Path = url;
			AssetFileBridge = AssetFileLoader.Load(Path, OnAssetLoaded);
		}

		private void OnAssetLoaded(bool isOk, UnityEngine.Object obj)
		{
			OnFinish(obj);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			AssetFileBridge.Release();
		}
	}
	public class StaticAssetLoader : AbstractResourceLoader
	{
		private AssetFileLoader _assetFileLoader;

		public UnityEngine.Object TheAsset => (UnityEngine.Object)base.ResultObject;

		public override float Progress => _assetFileLoader.Progress;

		public static StaticAssetLoader Load(string url, AssetFileLoader.AssetFileBridgeDelegate callback = null, LoaderMode loaderMode = LoaderMode.Async)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as UnityEngine.Object);
				};
			}
			return AbstractResourceLoader.AutoNew<StaticAssetLoader>(url, callback2, forceCreateNew: false, new object[1] { loaderMode });
		}

		protected override void Init(string path, params object[] args)
		{
			LoaderMode loaderMode = (LoaderMode)args[0];
			base.Init(path, args);
			if (string.IsNullOrEmpty(path))
			{
				Log.Error("StaticAssetLoader 空资源路径!");
			}
			_assetFileLoader = AssetFileLoader.Load(path, delegate(bool _isOk, UnityEngine.Object _obj)
			{
				OnFinish(_obj);
				if (Application.isEditor && TheAsset != null)
				{
					KResoourceLoadedAssetDebugger.Create("StaticAsset", path, TheAsset);
				}
			}, loaderMode);
		}

		protected override void OnFinish(object resultObj)
		{
			UnityEngine.Object resultObj2 = UnityEngine.Object.Instantiate(resultObj as UnityEngine.Object);
			base.OnFinish(resultObj2);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			_assetFileLoader.Release();
			UnityEngine.Object.Destroy(TheAsset);
		}
	}
	public class TextureLoader : AbstractResourceLoader
	{
		public delegate void CTextureLoaderDelegate(bool isOk, Texture tex);

		private AssetFileLoader AssetFileBridge;

		public Texture Asset => base.ResultObject as Texture;

		public override float Progress => AssetFileBridge.Progress;

		public string Path { get; private set; }

		public static TextureLoader Load(string path, CTextureLoaderDelegate callback = null)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk, obj as Texture);
				};
			}
			return AbstractResourceLoader.AutoNew<TextureLoader>(path, callback2, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			Path = url;
			AssetFileBridge = AssetFileLoader.Load(Path, OnAssetLoaded);
		}

		private void OnAssetLoaded(bool isOk, UnityEngine.Object obj)
		{
			if (!isOk)
			{
				Log.Error("[TextureLoader:OnAssetLoaded]Is not OK: {0}", base.Url);
			}
			OnFinish(obj);
			if (isOk)
			{
				Texture2D texture2D = Asset as Texture2D;
				string text = ((texture2D != null) ? texture2D.format.ToString() : "");
				Desc = $"{Asset.width}*{Asset.height}-{Asset.width * Asset.height}-{text}";
			}
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			AssetFileBridge.Release();
		}
	}
	public class KWWWLoader : AbstractResourceLoader
	{
		private static Coroutine CachedWWWLoaderMonitorSC;

		private const int MAX_WWW_COUNT = 5;

		private static int WWWLoadingCount = 0;

		private static readonly Stack<KWWWLoader> WWWLoadersStack = new Stack<KWWWLoader>();

		public float BeginLoadTime;

		public float FinishLoadTime;

		public UnityWebRequest Www;

		public ulong Size => Www.downloadedBytes;

		public float LoadSpeed
		{
			get
			{
				if (!base.IsCompleted)
				{
					return 0f;
				}
				return (float)Size / (FinishLoadTime - BeginLoadTime);
			}
		}

		public static event Action<string> WWWFinishCallback;

		public static KWWWLoader Load(string url, LoaderDelgate callback = null)
		{
			return AbstractResourceLoader.AutoNew<KWWWLoader>(url, callback, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			WWWLoadersStack.Push(this);
			if (CachedWWWLoaderMonitorSC == null)
			{
				CachedWWWLoaderMonitorSC = KResourceModule.Instance.StartCoroutine(WWWLoaderMonitorCoroutine());
			}
		}

		protected void StartLoad()
		{
			KResourceModule.Instance.StartCoroutine(CoLoad(base.Url));
		}

		private IEnumerator CoLoad(string url)
		{
			Log.Info(url);
			KResourceModule.LogRequest("WWW", url);
			DateTime beginTime = DateTime.Now;
			Www = UnityWebRequest.Get(url);
			BeginLoadTime = Time.time;
			WWWLoadingCount++;
			Www.SendWebRequest();
			while (!Www.isDone)
			{
				Progress = Www.downloadProgress;
				yield return null;
			}
			WWWLoadingCount--;
			Progress = 1f;
			if (base.IsReadyDisposed)
			{
				Log.Error("[KWWWLoader]Too early release: {0}", url);
				OnFinish(null);
				yield break;
			}
			if (!string.IsNullOrEmpty(Www.error))
			{
				_ = Application.platform;
				string fileProtocol = KResourceModule.GetFileProtocol();
				if (url.StartsWith(fileProtocol))
				{
					string text = url.Replace(fileProtocol, "");
					Log.Error("File {0} Exist State: {1}", text, File.Exists(text));
				}
				Log.Error("[KWWWLoader:Error]{0} {1}", Www.error, url);
				OnFinish(null);
				yield break;
			}
			KResourceModule.LogLoadTime("WWW", url, beginTime);
			if (KWWWLoader.WWWFinishCallback != null)
			{
				KWWWLoader.WWWFinishCallback(url);
			}
			Desc = $"{(float)Www.downloadedBytes / 1024f}K";
			UnityEngine.Debug.Log("<color=#EF2FBEFF> www url = " + url + " gc  " + Desc + " </color>");
			OnFinish(Www);
			if (Application.isEditor)
			{
				while (AbstractResourceLoader.GetCount<KWWWLoader>() > 0)
				{
					yield return null;
				}
				yield return new WaitForSeconds(5f);
				while (UnityEngine.Debug.isDebugBuild && !base.IsReadyDisposed)
				{
					Log.Error("[KWWWLoader]Not Disposed Yet! : {0}", base.Url);
					yield return null;
				}
			}
		}

		protected override void OnFinish(object resultObj)
		{
			FinishLoadTime = Time.time;
			base.OnFinish(resultObj);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			UnityEngine.Debug.Log("<color=#D781C1FF> www.Dispose()  url = " + base.Url + "</color>");
			Www.Dispose();
			Www = null;
		}

		protected static IEnumerator WWWLoaderMonitorCoroutine()
		{
			yield return null;
			while (WWWLoadersStack.Count > 0)
			{
				if (KResourceModule.LoadByQueue)
				{
					while (AbstractResourceLoader.GetCount<KWWWLoader>() != 0)
					{
						yield return null;
					}
				}
				while (WWWLoadingCount >= 5)
				{
					yield return null;
				}
				WWWLoadersStack.Pop().StartLoad();
			}
			CachedWWWLoaderMonitorSC = null;
		}
	}
	public class KWWWRequestBundleLoader : AbstractResourceLoader
	{
		private static Coroutine CachedWWWLoaderMonitorSC;

		private const int MAX_WWW_COUNT = 3;

		private static int WWWLoadingCount = 0;

		private static readonly Stack<KWWWRequestBundleLoader> WWWLoadersStack = new Stack<KWWWRequestBundleLoader>();

		public float BeginLoadTime;

		public float FinishLoadTime;

		public UnityWebRequest Www;

		public ulong Size => Www.downloadedBytes;

		public float LoadSpeed
		{
			get
			{
				if (!base.IsCompleted)
				{
					return 0f;
				}
				return (float)Size / (FinishLoadTime - BeginLoadTime);
			}
		}

		public static event Action<string> WWWFinishCallback;

		public static KWWWRequestBundleLoader Load(string url, LoaderDelgate callback = null)
		{
			return AbstractResourceLoader.AutoNew<KWWWRequestBundleLoader>(url, callback, forceCreateNew: false, Array.Empty<object>());
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			WWWLoadersStack.Push(this);
			if (CachedWWWLoaderMonitorSC == null)
			{
				CachedWWWLoaderMonitorSC = KResourceModule.Instance.StartCoroutine(WWWLoaderMonitorCoroutine());
			}
		}

		protected void StartLoad()
		{
			KResourceModule.Instance.StartCoroutine(CoLoad(base.Url));
		}

		private IEnumerator CoLoad(string url)
		{
			Log.Info(url);
			KResourceModule.LogRequest("WWWRequest", url);
			DateTime beginTime = DateTime.Now;
			Www = UnityWebRequestAssetBundle.GetAssetBundle(url);
			BeginLoadTime = Time.time;
			WWWLoadingCount++;
			Www.SendWebRequest();
			while (!Www.isDone)
			{
				Progress = Www.downloadProgress;
				yield return null;
			}
			WWWLoadingCount--;
			Progress = 1f;
			if (base.IsReadyDisposed)
			{
				Log.Error("[KWWWRequestLoader]Too early release: {0}", url);
				OnFinish(null);
				yield break;
			}
			if (!string.IsNullOrEmpty(Www.error))
			{
				_ = Application.platform;
				string fileProtocol = KResourceModule.GetFileProtocol();
				if (url.StartsWith(fileProtocol))
				{
					string text = url.Replace(fileProtocol, "");
					Log.Error("File {0} Exist State: {1}", text, File.Exists(text));
				}
				Log.Error("[KWWWRequestLoader:Error]{0} {1}", Www.error, url);
				OnFinish(null);
				yield break;
			}
			KResourceModule.LogLoadTime("WWWRequest", url, beginTime);
			if (KWWWRequestBundleLoader.WWWFinishCallback != null)
			{
				KWWWRequestBundleLoader.WWWFinishCallback(url);
			}
			Desc = $"{(float)Www.downloadedBytes / 1024f}K";
			UnityEngine.Debug.Log("<color=#EF2FBEFF> www url = " + url + " gc  " + Desc + " </color>");
			OnFinish(Www);
			if (Application.isEditor)
			{
				while (AbstractResourceLoader.GetCount<KWWWRequestBundleLoader>() > 0)
				{
					yield return null;
				}
				yield return new WaitForSeconds(5f);
				while (UnityEngine.Debug.isDebugBuild && !base.IsReadyDisposed)
				{
					Log.Error("[KWWWRequestLoader]Not Disposed Yet! : {0}", base.Url);
					yield return null;
				}
			}
		}

		protected override void OnFinish(object resultObj)
		{
			FinishLoadTime = Time.time;
			base.OnFinish(resultObj);
		}

		protected override void DoDispose()
		{
			base.DoDispose();
			UnityEngine.Debug.Log("<color=#D781C1FF> www.Dispose()  url = " + base.Url + "</color>");
			Www.Dispose();
			Www = null;
		}

		protected static IEnumerator WWWLoaderMonitorCoroutine()
		{
			yield return null;
			while (WWWLoadersStack.Count > 0)
			{
				if (KResourceModule.LoadByQueue)
				{
					while (AbstractResourceLoader.GetCount<KWWWRequestBundleLoader>() != 0)
					{
						yield return null;
					}
				}
				while (WWWLoadingCount >= 3)
				{
					yield return null;
				}
				WWWLoadersStack.Pop().StartLoad();
			}
			CachedWWWLoaderMonitorSC = null;
		}
	}
	public class KDebuggerObjectTool
	{
		private static readonly Dictionary<string, Transform> Parents = new Dictionary<string, Transform>();

		private static readonly Dictionary<string, int> Counts = new Dictionary<string, int>();

		private static string GetUri(string bigType, string smallType)
		{
			return $"{bigType}/{smallType}";
		}

		public static void SetParent(string bigType, string smallType, GameObject obj)
		{
			string uri = GetUri(bigType, smallType);
			Transform parent = GetParent(bigType, smallType);
			if (!Counts.TryGetValue(uri, out var value))
			{
				Counts[uri] = 0;
			}
			value = ++Counts[uri];
			try
			{
				KTool.SetChild(obj, parent.gameObject);
			}
			catch (Exception ex)
			{
				Log.Error($"[SetParent]{bigType}->{smallType}->{ex.Message}");
			}
			parent.gameObject.name = GetNameWithCount(smallType, value);
		}

		public static void RemoveFromParent(string bigType, string smallType, GameObject obj)
		{
			if (!KBehaviour.IsApplicationQuited)
			{
				if (obj != null)
				{
					UnityEngine.Object.Destroy(obj);
				}
				int count = --Counts[GetUri(bigType, smallType)];
				GetParent(bigType, smallType).name = GetNameWithCount(smallType, count);
			}
		}

		protected static string GetNameWithCount(string smallType, int count)
		{
			return $"{smallType}({count})";
		}

		protected static Transform GetParent(string bigType, string smallType)
		{
			string uri = GetUri(bigType, smallType);
			if (!Parents.TryGetValue(uri, out var value))
			{
				string name = $"__{bigType}__";
				GameObject gameObject = GameObject.Find(name) ?? new GameObject(name);
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				gameObject.transform.SetAsFirstSibling();
				value = new GameObject(smallType).transform;
				KTool.SetChild(value, gameObject.transform);
				Parents[uri] = value;
			}
			return value;
		}
	}
	public class KResoourceLoadedAssetDebugger : MonoBehaviour
	{
		public string MemorySize;

		public UnityEngine.Object TheObject;

		private const string bigType = "LoadedAssetDebugger";

		public string Type;

		private bool IsRemoveFromParent;

		public static KResoourceLoadedAssetDebugger Create(string type, string url, UnityEngine.Object theObject)
		{
			GameObject gameObject = new GameObject($"LoadedObject-{type}-{url}");
			KDebuggerObjectTool.SetParent("LoadedAssetDebugger", type, gameObject);
			KResoourceLoadedAssetDebugger kResoourceLoadedAssetDebugger = gameObject.AddComponent<KResoourceLoadedAssetDebugger>();
			kResoourceLoadedAssetDebugger.Type = type;
			kResoourceLoadedAssetDebugger.TheObject = theObject;
			kResoourceLoadedAssetDebugger.MemorySize = $"{(float)Profiler.GetRuntimeMemorySizeLong(theObject) / 1024f:F5}KB";
			return kResoourceLoadedAssetDebugger;
		}

		private void Update()
		{
			if (TheObject == null && !IsRemoveFromParent)
			{
				KDebuggerObjectTool.RemoveFromParent("LoadedAssetDebugger", Type, base.gameObject);
				IsRemoveFromParent = true;
			}
		}

		private void OnDestroy()
		{
			if (!IsRemoveFromParent)
			{
				KDebuggerObjectTool.RemoveFromParent("LoadedAssetDebugger", Type, base.gameObject);
				IsRemoveFromParent = true;
			}
		}
	}
	public class KResourceLoaderDebugger : MonoBehaviour
	{
		public AbstractResourceLoader TheLoader;

		public int RefCount;

		public float FinishUsedTime;

		public static bool IsApplicationQuit;

		public static KResourceLoaderDebugger Create(string type, string url, AbstractResourceLoader loader)
		{
			if (IsApplicationQuit)
			{
				return null;
			}
			Func<string> getName = () => $"{type}-{url}-{loader.Desc}";
			GameObject newHelpGameObject = new GameObject(getName());
			KDebuggerObjectTool.SetParent("ResourceLoaderDebuger", type, newHelpGameObject);
			KResourceLoaderDebugger kResourceLoaderDebugger = newHelpGameObject.AddComponent<KResourceLoaderDebugger>();
			kResourceLoaderDebugger.TheLoader = loader;
			loader.SetDescEvent += delegate
			{
				if (loader.RefCount > 0)
				{
					newHelpGameObject.name = getName();
				}
			};
			loader.DisposeEvent += delegate
			{
				if (!IsApplicationQuit)
				{
					KDebuggerObjectTool.RemoveFromParent("ResourceLoaderDebuger", type, newHelpGameObject);
				}
			};
			return kResourceLoaderDebugger;
		}

		private void Update()
		{
			if (TheLoader.RefCount != RefCount)
			{
				RefCount = TheLoader.RefCount;
			}
			if (!TheLoader.FinishUsedTime.Equals(FinishUsedTime))
			{
				FinishUsedTime = TheLoader.FinishUsedTime;
			}
		}

		private void OnApplicationQuit()
		{
			IsApplicationQuit = true;
		}
	}
	public class SceneLoader : AbstractResourceLoader
	{
		private AssetFileLoader _assetFileBridge;

		private LoaderMode _mode;

		private string _url;

		private string _sceneName;

		private bool _isAdditive;

		public Action DisposeFinishedAction;

		public string SceneName => _sceneName;

		public static SceneLoader Load(string url, Action<bool> callback = null, LoaderMode mode = LoaderMode.Async, bool isAdditive = true)
		{
			LoaderDelgate callback2 = null;
			if (callback != null)
			{
				callback2 = delegate(bool isOk, object obj)
				{
					callback(isOk);
				};
			}
			return AbstractResourceLoader.AutoNew<SceneLoader>(url, callback2, forceCreateNew: true, new object[2] { mode, isAdditive });
		}

		protected override void Init(string url, params object[] args)
		{
			base.Init(url, args);
			_mode = (LoaderMode)args[0];
			_isAdditive = (bool)args[1];
			_url = url;
			_sceneName = Path.GetFileNameWithoutExtension(_url);
			KResourceModule.Instance.StartCoroutine(Start());
		}

		private IEnumerator Start()
		{
			if (_mode == LoaderMode.Sync)
			{
				if (_isAdditive)
				{
					SceneManager.LoadScene(_sceneName, LoadSceneMode.Additive);
				}
				else
				{
					SceneManager.LoadScene(_sceneName, LoadSceneMode.Single);
				}
			}
			else if (_isAdditive)
			{
				AsyncOperation op = SceneManager.LoadSceneAsync(_sceneName, LoadSceneMode.Additive);
				while (!op.isDone)
				{
					Progress = op.progress;
					yield return null;
				}
			}
			else
			{
				AsyncOperation op = SceneManager.LoadSceneAsync(_sceneName, LoadSceneMode.Single);
				while (!op.isDone)
				{
					Progress = op.progress;
					yield return null;
				}
			}
			if (Application.isEditor)
			{
				KResourceModule.Instance.StartCoroutine(EditorLoadSceneBugFix(null));
			}
			OnFinish(_assetFileBridge);
		}

		private static IEnumerator EditorLoadSceneBugFix(AsyncOperation op)
		{
			if (op != null)
			{
				while (!op.isDone)
				{
					yield return null;
				}
			}
			yield return null;
			RefreshAllMaterialsShaders();
		}

		private static void RefreshAllMaterialsShaders()
		{
			Renderer[] array = UnityEngine.Object.FindObjectsOfType<Renderer>();
			for (int i = 0; i < array.Length; i++)
			{
				AssetFileLoader.RefreshMaterialsShaders(array[i]);
			}
		}

		protected override void DoDispose()
		{
			UnityEngine.Debug.Log("unload scene = " + _sceneName);
			base.DoDispose();
			SceneManager.UnloadSceneAsync(_sceneName, UnloadSceneOptions.UnloadAllEmbeddedSceneObjects).completed += delegate
			{
				DisposeFinishedAction?.Invoke();
			};
		}
	}
	public interface IAsyncObject
	{
		object AsyncResult { get; }

		bool IsCompleted { get; }

		bool IsError { get; }

		string AsyncMessage { get; }

		bool IsSuccess { get; }
	}
	public class KAsync
	{
		private delegate void AsyncWaitNextDelegate(Action nextFunc);

		public delegate void AsyncThreadDelegateFull(object param, Action next);

		public delegate void AsyncThreadDelegate(Action next);

		public delegate void AsyncThenDelegateEasy(Action next);

		public delegate void AsyncThenDelegate(Action next, Action kill);

		private Queue<AsyncWaitNextDelegate> _cacheCallbacks;

		private bool _canNext;

		public bool IsFinished { get; private set; }

		private KAsync()
		{
			_canNext = true;
		}

		public Coroutine WaitFinish()
		{
			return KAsyncManager.Instance.StartCoroutine(EmWaitFinish());
		}

		private IEnumerator EmWaitFinish()
		{
			while (!IsFinished)
			{
				yield return null;
			}
		}

		private void WaitNext(AsyncWaitNextDelegate callback)
		{
			if (!_canNext)
			{
				if (_cacheCallbacks == null)
				{
					_cacheCallbacks = new Queue<AsyncWaitNextDelegate>();
				}
				_cacheCallbacks.Enqueue(callback);
			}
			else
			{
				_canNext = false;
				callback(Next);
			}
		}

		private void Next()
		{
			_canNext = true;
			if (_cacheCallbacks != null && _cacheCallbacks.Count > 0)
			{
				WaitNext(_cacheCallbacks.Dequeue());
			}
			else
			{
				IsFinished = true;
			}
		}

		public static void AddMainThreadCall(Action call)
		{
			KAsyncManager.Instance._mainThreadCallbacks.Add(call);
		}

		public static KAsync Start()
		{
			return new KAsync();
		}

		public static KAsync Start(Action callback)
		{
			return new KAsync().Then(callback);
		}

		public static KAsync Start(AsyncThenDelegateEasy callback)
		{
			return new KAsync().Then(callback);
		}

		public KAsync Then(Action callback)
		{
			WaitNext(delegate(Action next)
			{
				callback();
				next();
			});
			return this;
		}

		public KAsync Then(AsyncThenDelegate thenFunc)
		{
			WaitNext(delegate(Action next)
			{
				thenFunc(next, delegate
				{
					UnityEngine.Debug.LogError("TODO: kill!");
				});
			});
			return this;
		}

		public KAsync Until(Func<bool> retBool, float timeout = 20f)
		{
			return When(retBool, timeout);
		}

		public KAsync When(Func<bool> retBool, float timeout = 20f)
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_CoWhen(retBool, timeout, next));
			});
			return this;
		}

		private IEnumerator _CoWhen(Func<bool> retBool, float timeout, Action next)
		{
			float time = 0f;
			while (!retBool())
			{
				time += Time.deltaTime;
				if (time > timeout)
				{
					Log.Error("[KAsync:When]A WHEN Timeout!!!");
					break;
				}
				yield return null;
			}
			next();
		}

		public KAsync Then(AsyncThenDelegateEasy thenFunc)
		{
			WaitNext(delegate(Action next)
			{
				thenFunc(next);
			});
			return this;
		}

		public KAsync Thread(AsyncThreadDelegate threadCalAction)
		{
			return Coroutine(_Thread(delegate(object thread, Action next)
			{
				threadCalAction(next);
			}));
		}

		public KAsync Thread(AsyncThreadDelegateFull threadCalAction, object param)
		{
			return Coroutine(_Thread(threadCalAction));
		}

		public KAsync Thread(Action threadCalAction)
		{
			return Coroutine(_Thread(delegate(object thread, Action next)
			{
				threadCalAction();
				next();
			}));
		}

		public IEnumerator _Thread(AsyncThreadDelegateFull threadCalAction, object param = null)
		{
			bool waitThreadFinish = false;
			Thread thread = new Thread((ThreadStart)delegate
			{
				Action next = delegate
				{
					waitThreadFinish = true;
				};
				threadCalAction(param, next);
			});
			thread.Start();
			KAsyncManager.Instance._threads.Add(thread);
			while (!waitThreadFinish)
			{
				yield return null;
			}
			KAsyncManager.Instance._threads.Remove(thread);
		}

		public KAsync Coroutine(IEnumerator enumtor)
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_StartCoroutine(enumtor, next));
			});
			return this;
		}

		private IEnumerator _StartCoroutine(IEnumerator enumtor, Action next)
		{
			yield return KAsyncManager.Instance.StartCoroutine(enumtor);
			next();
		}

		public KAsync Coroutine(Coroutine co)
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_Coroutine(co, next));
			});
			return this;
		}

		private IEnumerator _Coroutine(Coroutine co, Action next)
		{
			yield return co;
			next();
		}

		public KAsync WaitForFrames(int frameCount)
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_WaitForFrames(frameCount, next));
			});
			return this;
		}

		private IEnumerator _WaitForFrames(int frameCount, Action next)
		{
			for (int i = 0; i < frameCount; i++)
			{
				yield return null;
			}
			next();
		}

		public KAsync WaitForSeconds(float time)
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_CoWaitForSeconds(time, next));
			});
			return this;
		}

		private IEnumerator _CoWaitForSeconds(float time, Action next)
		{
			yield return new WaitForSeconds(time);
			next();
		}

		public KAsync WaitForEndOfFrame()
		{
			WaitNext(delegate(Action next)
			{
				KAsyncManager.Instance.StartCoroutine(_WaitForEndOfFrame(next));
			});
			return this;
		}

		private IEnumerator _WaitForEndOfFrame(Action next)
		{
			yield return new WaitForEndOfFrame();
			next();
		}
	}
	public class CCoroutineState
	{
		public bool IsOk = true;

		public object Param;
	}
	internal class KAsyncManager : KBehaviour
	{
		private static KAsyncManager _instance;

		public readonly List<Action> _mainThreadCallbacks = new List<Action>();

		public readonly HashSet<Thread> _threads = new HashSet<Thread>();

		public static KAsyncManager Instance
		{
			get
			{
				if (!Application.isPlaying || KBehaviour.IsApplicationQuited)
				{
					return null;
				}
				if (_instance != null)
				{
					return _instance;
				}
				GameObject gameObject = new GameObject("[AsyncManager]");
				UnityEngine.Object.DontDestroyOnLoad(gameObject);
				_instance = gameObject.GetComponent<KAsyncManager>() ?? gameObject.AddComponent<KAsyncManager>();
				return _instance;
			}
		}

		private void Update()
		{
			foreach (Action mainThreadCallback in _mainThreadCallbacks)
			{
				mainThreadCallback();
			}
			_mainThreadCallbacks.Clear();
		}

		private void StopAllThreads()
		{
			foreach (Thread thread in _threads)
			{
				thread?.Abort();
			}
			_threads.Clear();
		}

		private void OnApplicationQuit()
		{
			StopAllThreads();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			StopAllThreads();
		}
	}
	public class KEngineDef
	{
		public const string ResourcesBuildDir = "BundleResources";

		public const string ResourcesEditDir = "BundleEditing";

		public const string ResourcesBuildCacheDir = "_ResourcesCache_";

		public const string ResourcesBuildInfosDir = "ResourcesBuildInfos";

		public const string RedundaciesDir = "_Redundancies_";
	}
	public class KObject : IDisposable
	{
		public virtual void Dispose()
		{
		}
	}
	public static class KObjectDebuggerExtensions
	{
		public static void CreateDebugObject(this object obj)
		{
			KObjectDebugger.CreateDebugObject(obj);
		}

		public static void RemoveDebugObject(this object obj)
		{
			KObjectDebugger.RemoveDebugObject(obj);
		}
	}
	public class KObjectDebugger : KBehaviour
	{
		public static Dictionary<object, KObjectDebugger> Cache = new Dictionary<object, KObjectDebugger>();

		public static IEnumerator GlobalDebugCoroutine;

		public const string ContainerName = "KObjectDebugger";

		public object WatchObject;

		public List<string> DebugStrs = new List<string>();

		private GameObject _cacheGameObject;

		public static void RemoveDebugObject(object obj)
		{
			if (!Application.isEditor || !Application.isPlaying || KBehaviour.IsApplicationQuited)
			{
				return;
			}
			KAsync.AddMainThreadCall(delegate
			{
				try
				{
					if (Cache.TryGetValue(obj, out var value))
					{
						UnityEngine.Object.Destroy(value.gameObject);
					}
				}
				catch (Exception ex)
				{
					Log.Error(ex.Message);
				}
			});
		}

		public static void CreateDebugObject(object obj)
		{
			if (!Application.isEditor || !Application.isPlaying || KBehaviour.IsApplicationQuited)
			{
				return;
			}
			KAsync.AddMainThreadCall(delegate
			{
				try
				{
					KObjectDebugger kObjectDebugger = new GameObject($"{obj.ToString()}-{obj.GetType()}").AddComponent<KObjectDebugger>();
					kObjectDebugger.WatchObject = obj;
					KDebuggerObjectTool.SetParent("KObjectDebugger", obj.GetType().Name, kObjectDebugger.gameObject);
					Cache[obj] = kObjectDebugger;
				}
				catch (Exception ex)
				{
					Log.Error(ex.Message);
				}
			});
		}

		private void Awake()
		{
			if (!Application.isEditor)
			{
				Log.Error("Error Open KObjectDebugger on not Unity Editor");
				return;
			}
			_cacheGameObject = base.gameObject;
			if (GlobalDebugCoroutine == null)
			{
				GlobalDebugCoroutine = CoGlobalDebugCoroutine();
				AppEngine.EngineInstance.StartCoroutine(GlobalDebugCoroutine);
			}
		}

		private static IEnumerator CoGlobalDebugCoroutine()
		{
			while (true)
			{
				if (Cache.Count <= 0)
				{
					yield return null;
					continue;
				}
				Dictionary<object, KObjectDebugger> dictionary = new Dictionary<object, KObjectDebugger>();
				foreach (KeyValuePair<object, KObjectDebugger> item in Cache)
				{
					dictionary[item.Key] = item.Value;
				}
				foreach (KeyValuePair<object, KObjectDebugger> item2 in dictionary)
				{
					KObjectDebugger value = item2.Value;
					if (value.WatchObject == null)
					{
						UnityEngine.Object.Destroy(value._cacheGameObject);
					}
					else if (!value.IsDestroyed && value._cacheGameObject.name != value.WatchObject.ToString())
					{
						value._cacheGameObject.name = value.WatchObject.ToString();
					}
					yield return null;
				}
			}
		}
	}
	public class KProfiler
	{
		public static bool bEnable;

		private static Dictionary<string, Stopwatch> m_WachterDictionary;

		private static Dictionary<Stopwatch, long> m_WachterMems;

		public static bool CanWatch => UnityEngine.Debug.isDebugBuild;

		public static void BeginWatch(Enum emKey)
		{
			if (CanWatch)
			{
				BeginWatch(emKey.ToString());
			}
		}

		public static void EndWatch(Enum emKey)
		{
			if (CanWatch)
			{
				EndWatch(emKey.ToString());
			}
		}

		public static void BeginWatch(string key)
		{
			if (CanWatch)
			{
				if (m_WachterDictionary == null)
				{
					m_WachterDictionary = new Dictionary<string, Stopwatch>();
				}
				if (m_WachterMems == null)
				{
					m_WachterMems = new Dictionary<Stopwatch, long>();
				}
				if (!m_WachterDictionary.TryGetValue(key, out var value))
				{
					Stopwatch stopwatch2 = (m_WachterDictionary[key] = new Stopwatch());
					value = stopwatch2;
				}
				m_WachterMems[value] = GC.GetTotalMemory(forceFullCollection: false);
				if (value.IsRunning)
				{
					Log.Error("Running stopwatch need reset: {0}", key);
				}
				value.Reset();
				value.Start();
			}
		}

		public static void EndWatch(string key, string name = null)
		{
			if (CanWatch)
			{
				if (m_WachterDictionary == null)
				{
					m_WachterDictionary = new Dictionary<string, Stopwatch>();
				}
				if (m_WachterMems == null)
				{
					m_WachterMems = new Dictionary<Stopwatch, long>();
				}
				if (!m_WachterDictionary.TryGetValue(key, out var value))
				{
					Log.Error("Not exist Stopwatch: {0}", key);
					return;
				}
				long value2 = 0L;
				m_WachterMems.TryGetValue(value, out value2);
				value.Stop();
				decimal num = (decimal)value.Elapsed.TotalMilliseconds / 1000m;
				Log.Error(string.Format("[Watcher] {0}, Time: {1}s, MemDiff: {2}KB", arg2: (float)(GC.GetTotalMemory(forceFullCollection: false) - value2) / 1000f, arg0: string.IsNullOrEmpty(name) ? key : name, arg1: num.ToString("F7")));
			}
		}

		public static void BeginSample(string strName)
		{
			_ = CanWatch;
		}

		public static void EndSample()
		{
			_ = CanWatch;
		}
	}
	public class KTool
	{
		public struct FromToNumber
		{
			public float From;

			public float To;
		}

		private static readonly Dictionary<string, Shader> CacheShaders = new Dictionary<string, Shader>();

		public static bool IsWifi()
		{
			return Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork;
		}

		public static int GetNearestPower2(int num)
		{
			return (int)Mathf.Pow(2f, Mathf.Ceil(Mathf.Log(num) / Mathf.Log(2f)));
		}

		public static bool CheckPow2(int num)
		{
			int num2 = 1;
			while (true)
			{
				if (num2 > num)
				{
					return false;
				}
				if (num2 == num)
				{
					break;
				}
				num2 *= 2;
			}
			return true;
		}

		public static void ResetLocalTransform(Transform t)
		{
			t.localPosition = Vector3.zero;
			t.localRotation = Quaternion.identity;
			t.localScale = Vector3.one;
		}

		public static int GetGCD(int a, int b)
		{
			if (a < b)
			{
				int num = a;
				a = b;
				b = num;
			}
			while (b > 0)
			{
				int num2 = a % b;
				a = b;
				b = num2;
			}
			return a;
		}

		public static Type FindType(string qualifiedTypeName)
		{
			Type type = Type.GetType(qualifiedTypeName);
			if (type != null)
			{
				return type;
			}
			Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
			for (int i = 0; i < assemblies.Length; i++)
			{
				type = assemblies[i].GetType(qualifiedTypeName);
				if (type != null)
				{
					return type;
				}
			}
			return null;
		}

		public static void DestroyGameObjectChildren(GameObject go)
		{
			Transform transform = go.transform;
			while (transform.childCount > 0)
			{
				Transform child = transform.GetChild(0);
				if (Application.isEditor && !Application.isPlaying)
				{
					child.parent = null;
					UnityEngine.Object.DestroyImmediate(child.gameObject);
				}
				else
				{
					UnityEngine.Object.Destroy(child.gameObject);
					child.parent = null;
				}
			}
		}

		public static string DictToSplitStr<T, K>(Dictionary<T, K> dict, char delimeter1 = '|', char delimeter2 = ':')
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (KeyValuePair<T, K> item in dict)
			{
				stringBuilder.AppendFormat("{0}{1}{2}{3}", item.Key, delimeter2, item.Value, delimeter1);
			}
			return stringBuilder.ToString();
		}

		public static Dictionary<T, K> SplitToDict<T, K>(string str, char delimeter1 = '|', char delimeter2 = ':')
		{
			Dictionary<T, K> dictionary = new Dictionary<T, K>();
			if (!string.IsNullOrEmpty(str))
			{
				string[] array = str.Split(delimeter1);
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (!string.IsNullOrEmpty(text))
					{
						string[] array2 = text.Split(delimeter2);
						K value = default(K);
						T key = default(T);
						if (array2.Length != 0)
						{
							key = (T)Convert.ChangeType(array2[0], typeof(T));
						}
						if (array2.Length == 2)
						{
							value = (K)Convert.ChangeType(array2[1], typeof(K));
						}
						dictionary[key] = value;
					}
				}
			}
			return dictionary;
		}

		public static List<T> Split<T>(string str, params char[] args)
		{
			if (args.Length == 0)
			{
				args = new char[1] { '|' };
			}
			List<T> list = new List<T>();
			if (!string.IsNullOrEmpty(str))
			{
				string[] array = str.Split(args);
				for (int i = 0; i < array.Length; i++)
				{
					string value = array[i].Trim();
					if (!string.IsNullOrEmpty(value))
					{
						T val = (T)Convert.ChangeType(value, typeof(T));
						if (val != null)
						{
							list.Add(val);
						}
					}
				}
			}
			return list;
		}

		public static T GetRandomItemFromList<T>(IList<T> list)
		{
			if (list.Count == 0)
			{
				return default(T);
			}
			return list[UnityEngine.Random.Range(0, list.Count)];
		}

		public static int GetWaveRandomNumberInt(string waveNumberStr)
		{
			return Mathf.RoundToInt(GetWaveRandomNumber(waveNumberStr));
		}

		public static float GetWaveRandomNumber(string waveNumberStr)
		{
			if (string.IsNullOrEmpty(waveNumberStr))
			{
				return 0f;
			}
			string[] array = waveNumberStr.Split('-', '~');
			if (array.Length == 1)
			{
				return waveNumberStr.ToFloat();
			}
			return UnityEngine.Random.Range(array[0].ToFloat(), array[1].ToFloat());
		}

		public static FromToNumber ParseMinMaxNumber(string str)
		{
			List<float> list = Split<float>(str, new char[2] { '~', '-' });
			FromToNumber result = default(FromToNumber);
			if (list.Count > 0)
			{
				result.From = list[0];
			}
			if (list.Count > 1)
			{
				result.To = list[1];
			}
			return result;
		}

		public static bool IsBetweenWave(string waveNumberStr, int testNumber)
		{
			if (string.IsNullOrEmpty(waveNumberStr))
			{
				return false;
			}
			string[] array = waveNumberStr.Split('~');
			if (array.Length == 1)
			{
				return array[0].ToInt32() == testNumber;
			}
			int num = array[0].ToInt32();
			int num2 = array[1].ToInt32();
			if (testNumber >= num)
			{
				return testNumber <= num2;
			}
			return false;
		}

		public static bool IsContains(string numberStr, string testValue, char sp = ',')
		{
			if (string.IsNullOrEmpty(numberStr))
			{
				return false;
			}
			return numberStr.Split(sp).KContains(testValue);
		}

		public static Shader FindShader(string shaderName)
		{
			if (!CacheShaders.TryGetValue(shaderName, out var value))
			{
				value = Shader.Find(shaderName);
				CacheShaders[shaderName] = value;
				if (value == null)
				{
					Log.Error("缺少Shader：{0}  ， 检查Graphics Settings的预置shader", shaderName);
				}
			}
			return value;
		}

		public static byte[] StructToBytes(object structObject)
		{
			byte[] array = new byte[Marshal.SizeOf(structObject)];
			GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			IntPtr ptr = gCHandle.AddrOfPinnedObject();
			Marshal.StructureToPtr(structObject, ptr, fDeleteOld: false);
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			return array;
		}

		public static T BytesToStruct<T>(byte[] bytes, int offset = 0)
		{
			GCHandle gCHandle = GCHandle.Alloc(bytes, GCHandleType.Pinned);
			T result = (T)Marshal.PtrToStructure((IntPtr)(gCHandle.AddrOfPinnedObject().ToInt32() + offset), typeof(T));
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			return result;
		}

		public static T[] StrBytesToArray<T>(string str, int arraySize)
		{
			int num = Marshal.SizeOf(typeof(T));
			byte[] bytes = Encoding.Unicode.GetBytes(str);
			byte[] array = new byte[num * arraySize];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			T[] array2 = new T[array.Length / num];
			int num2 = 0;
			for (int j = 0; j < array2.Length; j++)
			{
				object obj = null;
				TypeCode typeCode = Type.GetTypeCode(typeof(T));
				switch (typeCode)
				{
				case TypeCode.Byte:
					obj = array[num2];
					break;
				case TypeCode.Int16:
					obj = BitConverter.ToInt16(array, num2);
					break;
				case TypeCode.Int32:
					obj = BitConverter.ToInt32(array, num2);
					break;
				case TypeCode.Int64:
					obj = BitConverter.ToInt64(array, num2);
					break;
				case TypeCode.UInt16:
					obj = BitConverter.ToUInt16(array, num2);
					break;
				case TypeCode.UInt32:
					obj = BitConverter.ToUInt32(array, num2);
					break;
				case TypeCode.UInt64:
					obj = BitConverter.ToUInt64(array, num2);
					break;
				default:
					Log.Error("Unsupport Type {0} in StrBytesToArray(), You can custom this.", typeCode);
					Debuger.Assert(result: false);
					break;
				}
				array2[j] = (T)obj;
				num2 += num;
			}
			return array2;
		}

		public static uint MakeDword(ushort high, ushort low)
		{
			return (uint)((ushort)(low & 0xFFFFu) | ((ushort)(high & 0xFFFF) << 16));
		}

		public static ushort LoWord(uint low)
		{
			return (ushort)(low & 0xFFFFu);
		}

		public static ushort HiWord(uint high)
		{
			return (ushort)((high >> 16) & 0xFFFFu);
		}

		public static ulong MakeLong(uint high, uint low)
		{
			return ((ulong)high << 32) | low;
		}

		public static uint HiInt(ulong l)
		{
			return (uint)(l >> 32);
		}

		public static uint LowInt(ulong l)
		{
			return (uint)l;
		}

		public static string HumanizeTimeString(int seconds)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(seconds);
			return string.Format("{0}{1}{2}{3}", (timeSpan.Days == 0) ? "" : (timeSpan.Days + "天"), (timeSpan.Hours == 0) ? "" : (timeSpan.Hours + "小时"), (timeSpan.Minutes == 0) ? "" : (timeSpan.Minutes + "分钟"), (timeSpan.Seconds == 0) ? "" : (timeSpan.Seconds + "秒"));
		}

		public static int GetUtcDay()
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return (DateTime.UtcNow - dateTime).Days;
		}

		public static int GetDeltaMinutes(DateTime origin)
		{
			return (DateTime.UtcNow - origin).Minutes;
		}

		public static int GetDeltaHours(DateTime origin)
		{
			return (DateTime.UtcNow - origin).Hours;
		}

		public static int GetDeltaDay(DateTime origin)
		{
			return (DateTime.UtcNow - origin).Days;
		}

		public static DateTime GetDateTimeByUtcMilliseconds(long utcTime, int zone = 0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddMilliseconds(utcTime).AddHours(zone);
		}

		public static DateTime GetDateTimeByUtcSeconds(double unixTimeStamp, int zone = 0)
		{
			return new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTimeStamp).AddHours(zone);
		}

		public static double GetUtcMilliseconds()
		{
			return GetUtcMilliseconds(DateTime.UtcNow);
		}

		public static double GetUtcMilliseconds(DateTime date)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return (date - dateTime).TotalMilliseconds;
		}

		public static double GetUtcSeconds()
		{
			return GetUtcSeconds(DateTime.UtcNow);
		}

		public static double GetUtcSeconds(DateTime date)
		{
			DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return (date - dateTime).TotalSeconds;
		}

		public static string HumanizeNumber(int number)
		{
			if (number > 100000000)
			{
				return string.Format("{0}{1}", number / 100000000, "亿");
			}
			if (number > 10000000)
			{
				return string.Format("{0}{1}", number / 10000000, "千万");
			}
			if (number > 1000000)
			{
				return string.Format("{0}{1}", number / 1000000, "百万");
			}
			if (number > 10000)
			{
				return string.Format("{0}{1}", number / 10000, "万");
			}
			return number.ToString();
		}

		public static string[] Match(string find, string pattern)
		{
			int num = 0;
			Match match = new Regex(pattern).Match(find);
			num = match.Groups.Count - 1;
			if (num < 1)
			{
				return null;
			}
			string[] array = new string[num];
			for (int i = 1; match.Groups[i].Value != ""; i++)
			{
				array[i - 1] = match.Groups[i].Value;
			}
			return array;
		}

		public static string Format(string source, params object[] args)
		{
			return FormatArgs(source, args);
		}

		public static string FormatArgs(string source, object[] args)
		{
			if (args == null)
			{
				return source;
			}
			string text = source;
			foreach (Match item in new Regex("\\{\\d+\\}").Matches(source))
			{
				string value = item.Value;
				string text2 = value.Substring(1, value.Length - 2).Trim();
				try
				{
					int num = text2.ToInt32();
					if (args.Length > num)
					{
						string newValue = args[num].ToString();
						text = text.Replace(value, newValue);
					}
				}
				catch (Exception)
				{
					Log.Error("not find argument index: \"{0}\" in array: {1}", text2, args);
				}
			}
			return text;
		}

		public static void SetLayer(GameObject go, int layer)
		{
			go.layer = layer;
			Transform transform = go.transform;
			int i = 0;
			for (int childCount = transform.childCount; i < childCount; i++)
			{
				SetLayer(transform.GetChild(i).gameObject, layer);
			}
		}

		public static T GetChildComponent<T>(Transform findTrans, string uri, bool isLog = true) where T : Component
		{
			Transform transform = findTrans.Find(uri);
			if (transform == null)
			{
				if (isLog)
				{
					Log.Error("Get Child Error: " + uri);
				}
				return null;
			}
			return (T)transform.GetComponent(typeof(T));
		}

		public static T GetChildComponent<T>(string uri, Transform findTrans, bool isLog = true) where T : Component
		{
			if (findTrans == null)
			{
				return null;
			}
			Transform transform = findTrans.Find(uri);
			if (transform == null)
			{
				if (isLog)
				{
					Log.Error("Get Child Error: " + uri);
				}
				return null;
			}
			return (T)transform.GetComponent(typeof(T));
		}

		public static GameObject DFSFindObject(Transform parent, string name)
		{
			for (int i = 0; i < parent.childCount; i++)
			{
				Transform child = parent.GetChild(i);
				if (child.name == name)
				{
					return child.gameObject;
				}
				GameObject gameObject = DFSFindObject(child, name);
				if (gameObject != null)
				{
					return gameObject;
				}
			}
			return null;
		}

		public static GameObject GetGameObject(string name, Transform findTrans, bool isLog = true)
		{
			GameObject gameObject = DFSFindObject(findTrans, name);
			if (gameObject == null)
			{
				Log.Error("Find GemeObject Error: " + name);
				return null;
			}
			return gameObject;
		}

		public static void SetChild(GameObject child, GameObject parent, bool selfRotation = false, bool selfScale = false)
		{
			SetChild(child.transform, parent.transform, selfRotation, selfScale);
		}

		public static void SetChild(Transform child, Transform parent, bool selfRotation = false, bool selfScale = false)
		{
			child.parent = parent;
			ResetTransform(child, selfRotation, selfScale);
		}

		public static void ResetTransform(Transform transform, bool selfRotation = false, bool selfScale = false)
		{
			transform.localPosition = Vector3.zero;
			if (!selfRotation)
			{
				transform.localEulerAngles = Vector3.zero;
			}
			if (!selfScale)
			{
				transform.localScale = Vector3.one;
			}
		}

		public static string GetRootPathName(Transform transform)
		{
			string text = "/" + transform.name;
			while (transform.parent != null)
			{
				transform = transform.parent;
				text = text + "/" + transform.name;
			}
			return text;
		}

		public static string MD5_Stream(Stream stream)
		{
			return BitConverter.ToString(new MD5CryptoServiceProvider().ComputeHash(stream)).Replace("-", "");
		}

		public static string MD5_File(string filePath)
		{
			try
			{
				using FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
				return MD5_Stream(stream);
			}
			catch (Exception ex)
			{
				return ex.ToString();
			}
		}

		public static byte[] MD5_bytes(string str)
		{
			return new MD5CryptoServiceProvider().ComputeHash(Encoding.Unicode.GetBytes(str));
		}

		public static string MD5_16bit(string str)
		{
			str = BitConverter.ToString(MD5_bytes(str), 4, 8);
			str = str.Replace("-", "");
			return str;
		}

		public static T ToEnum<T>(string e)
		{
			return (T)Enum.Parse(typeof(T), e);
		}

		public static int IntLerp(int from, int to)
		{
			if (from > to)
			{
				return from - 1;
			}
			if (from < to)
			{
				return from + 1;
			}
			return from;
		}

		public static void ScaleParticleSystem(GameObject gameObj, float scale)
		{
			bool flag = true;
			ParticleSystem[] componentsInChildren = gameObj.GetComponentsInChildren<ParticleSystem>(includeInactive: true);
			foreach (ParticleSystem obj in componentsInChildren)
			{
				flag = false;
				obj.startSize *= scale;
				obj.startSpeed *= scale;
				obj.startRotation *= scale;
				obj.transform.localScale *= scale;
			}
			if (flag)
			{
				gameObj.transform.localScale = new Vector3(scale, scale, 1f);
			}
		}

		public static void SetParticleSystemRenderQueue(Transform parent, int renderQueue = 3900)
		{
			int childCount = parent.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = parent.GetChild(i);
				if (child.childCount > 0)
				{
					SetParticleSystemRenderQueue(child, renderQueue);
				}
				if (child.GetComponent<ParticleSystem>() != null)
				{
					ParticleSystem component = child.GetComponent<ParticleSystem>();
					if (component.GetComponent<Renderer>().sharedMaterial != null)
					{
						component.GetComponent<Renderer>().sharedMaterial.renderQueue = renderQueue;
					}
				}
			}
			if (parent.GetComponent<ParticleSystem>() != null)
			{
				ParticleSystem component2 = parent.GetComponent<ParticleSystem>();
				if (component2.GetComponent<Renderer>().sharedMaterial != null)
				{
					component2.GetComponent<Renderer>().sharedMaterial.renderQueue = renderQueue;
				}
			}
		}

		public static void CopyTransformToTarget(Transform sourceTrans, Transform targetTrans)
		{
			targetTrans.localPosition = sourceTrans.localPosition;
			targetTrans.localRotation = sourceTrans.localRotation;
			targetTrans.localScale = sourceTrans.localScale;
		}

		public static bool HasWriteAccessToFolder(string folderPath)
		{
			try
			{
				string path = Path.Combine(folderPath, Path.GetRandomFileName());
				using (FileStream stream = new FileStream(path, FileMode.CreateNew, FileAccess.ReadWrite, FileShare.ReadWrite))
				{
					new StreamWriter(stream).Write("1");
				}
				File.Delete(path);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static void SetStaticRecursively(GameObject obj)
		{
			LinkedList<Transform> linkedList = new LinkedList<Transform>();
			linkedList.AddLast(obj.transform);
			while (linkedList.Count > 0)
			{
				Transform value = linkedList.First.Value;
				linkedList.RemoveFirst();
				value.gameObject.isStatic = true;
				for (int i = 0; i < value.childCount; i++)
				{
					linkedList.AddLast(value.GetChild(i));
				}
			}
		}

		public static float GetNormalizedAngle(float _anyAngle)
		{
			_anyAngle %= 360f;
			if (_anyAngle < 0f)
			{
				_anyAngle += 360f;
			}
			return _anyAngle;
		}

		public static void AdjustCollidersCenterZ(GameObject gameObj, float z = 0f)
		{
			Collider[] componentsInChildren = gameObj.GetComponentsInChildren<Collider>();
			foreach (Collider collider in componentsInChildren)
			{
				if (collider is BoxCollider)
				{
					BoxCollider boxCollider = (BoxCollider)collider;
					float num = boxCollider.center.z + collider.gameObject.transform.position.z - z;
					boxCollider.center = new Vector3(boxCollider.center.x, boxCollider.center.y, 0f - num);
				}
				else if (collider is SphereCollider)
				{
					SphereCollider sphereCollider = (SphereCollider)collider;
					float num2 = sphereCollider.center.z + collider.gameObject.transform.position.z - z;
					sphereCollider.center = new Vector3(sphereCollider.center.x, sphereCollider.center.y, 0f - num2);
				}
			}
		}

		public static string ToTitleCase(string word)
		{
			return word.Substring(0, 1).ToUpper() + ((word.Length > 1) ? word.Substring(1).ToLower() : "");
		}

		public static string ToSentenceCase(string str)
		{
			str = char.ToLower(str[0]) + str.Substring(1);
			return Regex.Replace(str, "[a-z][A-Z]", (Match m) => char.ToLower(m.Value[0]) + "_" + char.ToLower(m.Value[1]));
		}

		public static bool Probability(float chancePercent)
		{
			if (UnityEngine.Random.Range(0f, 100f) <= chancePercent)
			{
				return true;
			}
			return false;
		}

		public static bool Probability(byte chancePercent)
		{
			if (UnityEngine.Random.Range(1, 101) <= chancePercent)
			{
				return true;
			}
			return false;
		}

		public static bool ArraysEqual<T>(T[] a1, T[] a2)
		{
			if (a1 == a2)
			{
				return true;
			}
			if (a1 == null || a2 == null)
			{
				return false;
			}
			if (a1.Length != a2.Length)
			{
				return false;
			}
			EqualityComparer<T> @default = EqualityComparer<T>.Default;
			for (int i = 0; i < a1.Length; i++)
			{
				if (!@default.Equals(a1[i], a2[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static Vector3[] GetSmartNpcPoints(Vector3 startDirection, int nNum, Vector3 pAnchorPos, float fAngle, float nRadius)
		{
			bool flag = nNum % 2 == 0;
			int num = (flag ? (nNum / 2) : (nNum / 2 + 1));
			Vector3 vector = startDirection * nRadius;
			Vector3[] array = new Vector3[nNum];
			for (int i = 1; i <= nNum; i++)
			{
				float num2 = 0f;
				num2 = ((!flag) ? ((i <= num) ? ((i >= num) ? 0f : ((0f - fAngle) * (float)(i % num))) : (fAngle * (float)(i % num))) : ((i <= num) ? ((0f - fAngle) * (float)(i % num + 1) + fAngle / 2f) : (fAngle * (float)(i % num + 1) - fAngle / 2f)));
				Vector3 vector2 = pAnchorPos + Quaternion.AngleAxis(num2, Vector3.forward) * vector;
				array[i - 1] = vector2;
			}
			return array;
		}

		public static Vector3[] GetParallelPoints(Vector3 startPos, Vector3 startDirection, int nNum, float meterInterval)
		{
			bool flag = nNum % 2 == 0;
			int num = (flag ? (nNum / 2) : (nNum / 2 + 1));
			Vector3[] array = new Vector3[nNum];
			for (int i = 1; i <= nNum; i++)
			{
				float num2 = 0f;
				num2 = ((!flag) ? ((i <= num) ? ((i >= num) ? 0f : ((0f - meterInterval) * (float)(i % num + 1))) : (meterInterval * (float)(i % num + 1))) : ((i <= num) ? ((0f - meterInterval) * (float)(i % num + 1) + meterInterval / 2f) : (meterInterval * (float)(i % num + 1) - meterInterval / 2f)));
				Vector3 vector = startPos + Quaternion.AngleAxis(90f, Vector3.forward) * startDirection * num2;
				array[i - 1] = vector;
			}
			return array;
		}

		public static bool LineIntersectionPoint(out Vector2 intersectPoint, Vector2 ps1, Vector2 pe1, Vector2 ps2, Vector2 pe2)
		{
			intersectPoint = Vector2.zero;
			float num = pe1.y - ps1.y;
			float num2 = ps1.x - pe1.x;
			float num3 = num * ps1.x + num2 * ps1.y;
			float num4 = pe2.y - ps2.y;
			float num5 = ps2.x - pe2.x;
			float num6 = num4 * ps2.x + num5 * ps2.y;
			float num7 = num * num5 - num4 * num2;
			if (num7 == 0f)
			{
				return false;
			}
			intersectPoint = new Vector2((num5 * num3 - num2 * num6) / num7, (num * num6 - num4 * num3) / num7);
			return true;
		}

		public static bool IsNumber(string str)
		{
			if (string.IsNullOrEmpty(str))
			{
				Log.Warning("传入的值为空！请检查");
				return false;
			}
			string pattern = "^\\d*$";
			return Regex.IsMatch(str, pattern);
		}

		public static Vector2 GetRelativePositionOfEllipse(float 长半轴即目标距离, float 短半轴, float angle)
		{
			float f = angle * ((float)Math.PI / 180f);
			return new Vector2(长半轴即目标距离 * Mathf.Cos(f), 短半轴 * Mathf.Sin(f));
		}

		public static float Angle(Vector2 from, Vector2 to)
		{
			return Quaternion.FromToRotation(from.normalized, to.normalized).eulerAngles.z;
		}

		public static string NumberFormatTo3(long num, string sp = ",")
		{
			return num.ToString("##" + sp + "###", CultureInfo.InvariantCulture);
		}

		public static IPAddress GetIpAddressFromIpHostEntry(IPHostEntry ipHostEntry)
		{
			IPAddress[] addressList = ipHostEntry.AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
				{
					return iPAddress;
				}
			}
			return null;
		}

		public static void GetIpAddress(string host, Action<IPAddress> callback = null)
		{
			IPAddress ipAddress = null;
			if (!IPAddress.TryParse(host, out ipAddress))
			{
				Dns.BeginGetHostAddresses(host, delegate(IAsyncResult asyncResult)
				{
					IPAddress[] array = Dns.EndGetHostAddresses(asyncResult);
					if (callback != null)
					{
						if (array.Length != 0)
						{
							ipAddress = array[0];
						}
						callback(ipAddress);
					}
				}, null);
			}
			else if (callback != null)
			{
				callback(ipAddress);
			}
		}
	}
	public class XMemoryParser<T>
	{
		private readonly int MaxCount;

		private readonly byte[] SourceBytes;

		private readonly GCHandle SourceBytesHandle;

		private readonly IntPtr SourceBytesPtr;

		public T this[int index]
		{
			get
			{
				Debuger.Assert(index < MaxCount);
				return (T)Marshal.PtrToStructure((IntPtr)(SourceBytesPtr.ToInt32() + Marshal.SizeOf(typeof(T)) * index), typeof(T));
			}
		}

		public XMemoryParser(byte[] bytes, int maxCount)
		{
			SourceBytes = bytes;
			MaxCount = maxCount;
			SourceBytesHandle = GCHandle.Alloc(SourceBytes, GCHandleType.Pinned);
			SourceBytesPtr = SourceBytesHandle.AddrOfPinnedObject();
		}

		public XMemoryParser(IntPtr bytesPtr, int maxCount)
		{
			MaxCount = maxCount;
			SourceBytesPtr = bytesPtr;
		}

		~XMemoryParser()
		{
			if (SourceBytesHandle.IsAllocated)
			{
				SourceBytesHandle.Free();
			}
		}
	}
}
namespace KEngine.UI
{
	public interface IUIBridge
	{
		void InitBridge();

		UIController CreateUIController(GameObject uiObj, string uiTemplateName);

		void UIObjectFilter(UIController controller, GameObject uiObject);

		IEnumerator LoadUIAsset(UILoadState loadState, UILoadRequest request);
	}
	public class UILoadRequest
	{
		public UnityEngine.Object Asset;
	}
	[Obsolete("Use UIModule instead of KUIModule")]
	public class KUIModule : UIModule
	{
	}
	public class UIModule
	{
		private class _InstanceClass
		{
			public static UIModule _Instance = new UIModule();
		}

		private int _loadingUICount;

		public IUIBridge UiBridge;

		public Dictionary<string, UILoadState> UIWindows = new Dictionary<string, UILoadState>();

		public static Action<UIController> OnInitEvent;

		public static Action<UIController> OnOpenEvent;

		public static Action<UIController> OnCloseEvent;

		public static UIModule Instance => _InstanceClass._Instance;

		public int LoadingUICount
		{
			get
			{
				return _loadingUICount;
			}
			set
			{
				_loadingUICount = value;
				if (_loadingUICount < 0)
				{
					Log.Error("Error ---- LoadingUICount < 0");
				}
			}
		}

		public UIModule()
		{
			string config = AppEngine.GetConfig("KEngine.UI", "UIModuleBridge");
			if (!string.IsNullOrEmpty(config))
			{
				string text = $"{config}";
				Type type = KTool.FindType(text);
				if (type != null)
				{
					UiBridge = Activator.CreateInstance(type) as IUIBridge;
					Log.Debug("Use UI Bridge: {0}", type);
				}
				else
				{
					Log.Error("Cannot find UIBridge Type: {0}", text);
				}
			}
			if (UiBridge == null)
			{
				UiBridge = new UGUIBridge();
			}
			UiBridge.InitBridge();
		}

		public UILoadState OpenWindow(string uiTemplateName, params object[] args)
		{
			if (!UIWindows.TryGetValue(uiTemplateName, out var value))
			{
				return LoadWindow(uiTemplateName, openWhenFinish: true, args);
			}
			OnOpen(value, args);
			return value;
		}

		public void ToggleWindow<T>(params object[] args)
		{
			string name = typeof(T).Name.Remove(0, 3);
			ToggleWindow(name, args);
		}

		public void ToggleWindow(string name, params object[] args)
		{
			if (IsOpen(name))
			{
				CloseWindow(name);
			}
			else
			{
				OpenWindow(name, args);
			}
		}

		public UILoadState OpenDynamicWindow(string template, string instanceName, params object[] args)
		{
			UILoadState uILoadState = _GetUIState(instanceName);
			if (uILoadState != null)
			{
				OnOpen(uILoadState, args);
				return uILoadState;
			}
			if (!UIWindows.TryGetValue(instanceName, out var value))
			{
				value = new UILoadState(template, instanceName);
				value.IsStaticUI = false;
				value.IsLoading = true;
				value.UIWindow = null;
				value.OpenWhenFinish = true;
				value.OpenArgs = args;
				UIWindows[instanceName] = value;
			}
			CallUI(template, delegate
			{
				UILoadState uILoadState2 = _GetUIState(instanceName);
				UILoadState uILoadState3 = _GetUIState(template);
				object[] array = new object[uILoadState2.OpenArgs.Length + 2];
				array[0] = template;
				array[1] = instanceName;
				uILoadState2.OpenArgs.CopyTo(array, 2);
				OnDynamicWindowCallback(uILoadState3.UIWindow, array);
			});
			return value;
		}

		private void OnDynamicWindowCallback(UIController _ui, object[] _args)
		{
			string uITemplateName = (string)_args[0];
			string text = (string)_args[1];
			GameObject gameObject = UnityEngine.Object.Instantiate(_ui.gameObject);
			gameObject.name = text;
			UiBridge.UIObjectFilter(_ui, gameObject);
			UILoadState uILoadState = UIWindows[text];
			uILoadState.IsLoading = false;
			UIController component = gameObject.GetComponent<UIController>();
			component.UITemplateName = uITemplateName;
			component.UIName = text;
			uILoadState.UIWindow = component;
			object[] array = new object[_args.Length - 2];
			for (int i = 2; i < _args.Length; i++)
			{
				array[i - 2] = _args[i];
			}
			InitWindow(uILoadState, component, uILoadState.OpenWhenFinish, array);
		}

		public void CloseWindow(Type t)
		{
			CloseWindow(t.Name.Remove(0, 3));
		}

		public void CloseWindow<T>()
		{
			CloseWindow(typeof(T));
		}

		public void CloseWindow(string name)
		{
			if (!UIWindows.TryGetValue(name, out var value))
			{
				if (UnityEngine.Debug.isDebugBuild)
				{
					Log.Warning("[CloseWindow]没有加载的UIWindow: {0}", name);
				}
				return;
			}
			if (value.IsLoading)
			{
				if (UnityEngine.Debug.isDebugBuild)
				{
					Log.Info("[CloseWindow]IsLoading的{0}", name);
				}
				value.OpenWhenFinish = false;
				return;
			}
			value.UIWindow.OnClose();
			if (OnCloseEvent != null)
			{
				OnCloseEvent(value.UIWindow);
			}
			if (!value.IsStaticUI)
			{
				DestroyWindow(name);
			}
			value.UIWindow.gameObject.SetActive(value: false);
		}

		public void DestroyAllWindows()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, UILoadState> uIWindow in UIWindows)
			{
				if (IsLoad(uIWindow.Key))
				{
					list.Add(uIWindow.Key);
				}
			}
			foreach (string item in list)
			{
				DestroyWindow(item);
			}
		}

		[Obsolete("Deprecated: Please don't use this")]
		public void CloseAllWindows()
		{
			List<string> list = new List<string>();
			foreach (KeyValuePair<string, UILoadState> uIWindow in UIWindows)
			{
				if (IsOpen(uIWindow.Key))
				{
					list.Add(uIWindow.Key);
				}
			}
			for (int num = list.Count - 1; num >= 0; num--)
			{
				CloseWindow(list[num]);
			}
		}

		private UILoadState _GetUIState(string name)
		{
			UIWindows.TryGetValue(name, out var value);
			if (value != null)
			{
				return value;
			}
			return null;
		}

		private UIController GetUIBase(string name)
		{
			UIWindows.TryGetValue(name, out var value);
			if (value != null && value.UIWindow != null)
			{
				return value.UIWindow;
			}
			return null;
		}

		public bool IsOpen<T>() where T : UIController
		{
			string name = typeof(T).Name.Remove(0, 3);
			return IsOpen(name);
		}

		public bool IsOpen(string name)
		{
			UIController uIBase = GetUIBase(name);
			if (!(uIBase == null))
			{
				return uIBase.gameObject.activeSelf;
			}
			return false;
		}

		public bool IsLoad(string name)
		{
			if (UIWindows.ContainsKey(name))
			{
				return true;
			}
			return false;
		}

		public UILoadState LoadWindow(string windowTemplateName, bool openWhenFinish, params object[] args)
		{
			if (UIWindows.ContainsKey(windowTemplateName))
			{
				Log.Error("[LoadWindow]多次重复LoadWindow: {0}", windowTemplateName);
			}
			Debuger.Assert(!UIWindows.ContainsKey(windowTemplateName));
			UILoadState uILoadState = new UILoadState(windowTemplateName, windowTemplateName);
			uILoadState.IsStaticUI = true;
			uILoadState.OpenArgs = args;
			uILoadState.OpenWhenFinish = openWhenFinish;
			UIWindows.Add(windowTemplateName, uILoadState);
			KResourceModule.Instance.StartCoroutine(LoadUIAssetBundle(windowTemplateName, uILoadState));
			return uILoadState;
		}

		private IEnumerator LoadUIAssetBundle(string name, UILoadState openState, KCallback callback = null)
		{
			if (openState.UIResourceLoader != null)
			{
				openState.UIResourceLoader.Release();
				KResourceModule.Collect();
				Log.Info("Release UI ResourceLoader: {0}", openState.UIResourceLoader.Url);
				openState.UIResourceLoader = null;
			}
			LoadingUICount++;
			UILoadRequest request = new UILoadRequest();
			yield return KResourceModule.Instance.StartCoroutine(UiBridge.LoadUIAsset(openState, request));
			GameObject gameObject = (GameObject)request.Asset;
			gameObject.SetActive(value: false);
			gameObject.name = openState.TemplateName;
			UIController uIController = UiBridge.CreateUIController(gameObject, openState.TemplateName);
			if (openState.UIWindow != null)
			{
				Log.Info("Destroy exist UI Window, maybe for reload");
				UnityEngine.Object.Destroy(openState.UIWindow.CachedGameObject);
				openState.UIWindow = null;
			}
			openState.UIWindow = uIController;
			uIController.UIName = (uIController.UITemplateName = openState.TemplateName);
			UiBridge.UIObjectFilter(uIController, gameObject);
			openState.IsLoading = false;
			InitWindow(openState, uIController, openState.OpenWhenFinish, openState.OpenArgs);
			LoadingUICount--;
			callback?.Invoke(null);
		}

		public Coroutine ReloadWindow(string windowTemplateName, KCallback callback)
		{
			UIWindows.TryGetValue(windowTemplateName, out var value);
			if (value == null || value.UIWindow == null)
			{
				Log.Info("{0} has been destroyed", windowTemplateName);
				return null;
			}
			return KResourceModule.Instance.StartCoroutine(LoadUIAssetBundle(windowTemplateName, value));
		}

		public void DestroyWindow(string uiTemplateName)
		{
			UIWindows.TryGetValue(uiTemplateName, out var value);
			if (value == null || value.UIWindow == null)
			{
				Log.Info("{0} has been destroyed", uiTemplateName);
				return;
			}
			UnityEngine.Object.Destroy(value.UIWindow.gameObject);
			if (value.UIResourceLoader != null)
			{
				value.UIResourceLoader.Release();
			}
			value.UIWindow = null;
			UIWindows.Remove(uiTemplateName);
		}

		public void CallUI(string uiTemplateName, Action<UIController, object[]> callback, params object[] args)
		{
			Debuger.Assert(callback);
			if (!UIWindows.TryGetValue(uiTemplateName, out var value))
			{
				value = LoadWindow(uiTemplateName, false);
			}
			value.DoCallback(callback, args);
		}

		public void CallDynamicUI(string uiName, Action<UIController, object[]> callback, params object[] args)
		{
			Debuger.Assert(callback);
			if (!UIWindows.TryGetValue(uiName, out var _))
			{
				Log.Error("找不到UIState: {0}", uiName);
			}
			else
			{
				UIWindows[uiName].DoCallback(callback, args);
			}
		}

		[Obsolete("Use string ui name instead for more flexible!")]
		public void CallUI<T>(Action<T> callback) where T : UIController
		{
			CallUI(delegate(T _ui, object[] _args)
			{
				callback(_ui);
			});
		}

		[Obsolete("Use string ui name instead for more flexible!")]
		public void CallUI<T>(Action<T, object[]> callback, params object[] args) where T : UIController
		{
			string uiTemplateName = typeof(T).Name.Remove(0, 3);
			CallUI(uiTemplateName, delegate(UIController _uibase, object[] _args)
			{
				callback(_uibase as T, _args);
			}, args);
		}

		private void OnOpen(UILoadState uiState, params object[] args)
		{
			if (uiState.IsLoading)
			{
				uiState.OpenWhenFinish = true;
				uiState.OpenArgs = args;
				return;
			}
			UIController uiBase = uiState.UIWindow;
			if (uiBase.gameObject.activeSelf)
			{
				uiBase.OnClose();
				if (OnCloseEvent != null)
				{
					OnCloseEvent(uiBase);
				}
			}
			uiBase.BeforeOpen(args, delegate
			{
				uiBase.gameObject.SetActive(value: true);
				uiBase.OnOpen(args);
				if (OnOpenEvent != null)
				{
					OnOpenEvent(uiBase);
				}
			});
		}

		private void InitWindow(UILoadState uiState, UIController uiBase, bool open, params object[] args)
		{
			uiBase.OnInit();
			if (OnInitEvent != null)
			{
				OnInitEvent(uiBase);
			}
			if (open)
			{
				OnOpen(uiState, args);
			}
			if (!open)
			{
				if (!uiState.IsStaticUI)
				{
					CloseWindow(uiBase.UIName);
					return;
				}
				uiBase.gameObject.SetActive(value: false);
			}
			uiState.OnUIWindowLoadedCallbacks(uiState, uiBase);
		}
	}
	public class UILoadState
	{
		public string TemplateName;

		public string InstanceName;

		public UIController UIWindow;

		public Type UIType;

		public bool IsLoading;

		public bool IsStaticUI;

		public bool OpenWhenFinish;

		public object[] OpenArgs;

		internal Queue<Action<UIController, object[]>> CallbacksWhenFinish;

		internal Queue<object[]> CallbacksArgsWhenFinish;

		public AbstractResourceLoader UIResourceLoader;

		public UILoadState(string uiTemplateName, string uiInstanceName, Type uiControllerType = null)
		{
			if (uiControllerType == null)
			{
				uiControllerType = typeof(UIController);
			}
			TemplateName = uiTemplateName;
			InstanceName = uiInstanceName;
			UIWindow = null;
			UIType = uiControllerType;
			IsLoading = true;
			OpenWhenFinish = false;
			OpenArgs = null;
			CallbacksWhenFinish = new Queue<Action<UIController, object[]>>();
			CallbacksArgsWhenFinish = new Queue<object[]>();
		}

		public void DoCallback(Action<UIController, object[]> callback, object[] args = null)
		{
			if (args == null)
			{
				args = new object[0];
			}
			if (IsLoading)
			{
				CallbacksWhenFinish.Enqueue(callback);
				CallbacksArgsWhenFinish.Enqueue(args);
			}
			else
			{
				callback(UIWindow, args);
			}
		}

		internal void OnUIWindowLoadedCallbacks(UILoadState uiState, UIController uiObject)
		{
			while (uiState.CallbacksWhenFinish.Count > 0)
			{
				Action<UIController, object[]> callback = uiState.CallbacksWhenFinish.Dequeue();
				object[] args = uiState.CallbacksArgsWhenFinish.Dequeue();
				DoCallback(callback, args);
			}
		}
	}
	public class UGUIBridge : IUIBridge
	{
		public EventSystem EventSystem;

		public void InitBridge()
		{
			EventSystem = new GameObject("EventSystem").AddComponent<EventSystem>();
			EventSystem.gameObject.AddComponent<StandaloneInputModule>();
		}

		public UIController CreateUIController(GameObject uiObj, string uiTemplateName)
		{
			UIController obj = uiObj.AddComponent(Type.GetType("KUI" + uiTemplateName + ", Assembly-CSharp")) as UIController;
			Debuger.Assert(obj);
			return obj;
		}

		public void UIObjectFilter(UIController ui, GameObject uiObject)
		{
		}

		public IEnumerator LoadUIAsset(UILoadState loadState, UILoadRequest request)
		{
			string url = $"UI/{loadState.TemplateName}.prefab";
			StaticAssetLoader assetLoader = (StaticAssetLoader)(loadState.UIResourceLoader = StaticAssetLoader.Load(url));
			while (!assetLoader.IsCompleted)
			{
				yield return null;
			}
			request.Asset = assetLoader.TheAsset;
		}
	}
	public class UIController : KBehaviour
	{
		public string UITemplateName = "";

		public string UIName = "";

		public virtual void OnInit()
		{
		}

		public virtual void BeforeOpen(object[] onOpenArgs, Action doOpen)
		{
			doOpen();
		}

		public virtual void OnOpen(params object[] args)
		{
		}

		public virtual void OnClose()
		{
		}

		public T GetControl<T>(string uri, Transform findTrans = null, bool isLog = true) where T : UnityEngine.Object
		{
			return (T)GetControl(typeof(T), uri, findTrans, isLog);
		}

		public object GetControl(Type type, string uri, Transform findTrans = null, bool isLog = true)
		{
			if (findTrans == null)
			{
				findTrans = base.transform;
			}
			Transform transform = findTrans.Find(uri);
			if (transform == null)
			{
				if (isLog)
				{
					Log.Error("Get UI<{0}> Control Error: " + uri, this);
				}
				return null;
			}
			if (type == typeof(GameObject))
			{
				return transform.gameObject;
			}
			return transform.GetComponent(type);
		}

		public T FindControl<T>(string name) where T : Component
		{
			GameObject gameObject = DFSFindObject(base.transform, name);
			if (gameObject == null)
			{
				Log.Error("Find UI Control Error: " + name);
				return null;
			}
			return gameObject.GetComponent<T>();
		}

		public GameObject FindGameObject(string name)
		{
			GameObject gameObject = DFSFindObject(base.transform, name);
			if (gameObject == null)
			{
				Log.Error("Find GemeObject Error: " + name);
				return null;
			}
			return gameObject;
		}

		public GameObject DFSFindObject(Transform parent, string name)
		{
			for (int i = 0; i < parent.childCount; i++)
			{
				Transform child = parent.GetChild(i);
				if (child.name == name)
				{
					return child.gameObject;
				}
				GameObject gameObject = DFSFindObject(child, name);
				if (gameObject != null)
				{
					return gameObject;
				}
			}
			return null;
		}

		public void DestroyGameObjectChildren(GameObject go)
		{
			KTool.DestroyGameObjectChildren(go);
		}

		protected void OpenWindow(string uiName, params object[] args)
		{
			UIModule.Instance.OpenWindow(uiName, args);
		}

		protected void CloseWindow(string uiName = null)
		{
			UIModule.Instance.CloseWindow(uiName ?? UIName);
		}

		protected T GetFromArgs<T>(object[] openArgs, int offset, bool isLog = true)
		{
			return openArgs.GetArg<T>(offset, isLog);
		}

		[Obsolete("Use CallUI(stringName) insted!")]
		public static void CallUI<T>(Action<T> callback) where T : UIController
		{
			UIModule.Instance.CallUI(callback);
		}
	}
	[AddComponentMenu("KEngine/KUIWindowAsset")]
	public class UIWindowAsset : MonoBehaviour
	{
		public string StringArgument;
	}
}
namespace KEngine.Modules
{
	public interface IReloadableSettings
	{
		int Count { get; }

		void ReloadAll();
	}
	public abstract class SettingModuleBase
	{
		private readonly Dictionary<string, object> _tableFilesCache = new Dictionary<string, object>();

		protected abstract string LoadSetting(string path);

		public TableFile GetTableFile(string path, bool useCache = false)
		{
			if (!useCache || !_tableFilesCache.TryGetValue(path, out var value))
			{
				string text = LoadSetting(path);
				TableFile tableFile = TableFile.LoadFromString(text);
				value = (_tableFilesCache[path] = tableFile);
				return tableFile;
			}
			return value as TableFile;
		}
	}
	public class SettingModule : SettingModuleBase
	{
		public delegate byte[] LoadSettingFuncDelegate(string filePath);

		public delegate byte[] SettingBytesFilterDelegate(byte[] bytes);

		public static SettingBytesFilterDelegate SettingBytesFilter;

		public static LoadSettingFuncDelegate CustomLoadSetting;

		private static readonly bool IsEditor;

		private static SettingModule _instance;

		protected static string SettingFolderName => AppEngine.GetConfig("KEngine.Setting", "SettingResourcesPath");

		public static bool IsFileSystemMode
		{
			get
			{
				if (IsEditor)
				{
					return true;
				}
				return false;
			}
		}

		static SettingModule()
		{
			IsEditor = Application.isEditor;
		}

		internal SettingModule()
		{
		}

		public static TableFile Get(string path, bool useCache = true)
		{
			if (_instance == null)
			{
				_instance = new SettingModule();
			}
			return _instance.GetTableFile(path, useCache);
		}

		protected override string LoadSetting(string path)
		{
			byte[] bytes = ((CustomLoadSetting != null) ? CustomLoadSetting(path) : DefaultLoadSetting(path));
			return Encoding.UTF8.GetString(bytes);
		}

		public static byte[] DefaultLoadSetting(string path)
		{
			HotBytesLoader hotBytesLoader = HotBytesLoader.Load(SettingFolderName + "/" + path, LoaderMode.Sync);
			Debuger.Assert(!hotBytesLoader.IsError);
			byte[] bytes = hotBytesLoader.Bytes;
			hotBytesLoader.Release();
			return BaseUtil.DecryptBytes(bytes);
		}

		private static string GetFileSystemPath(string path)
		{
			return Path.Combine(AppEngine.GetConfig("KEngine.Setting", "SettingCompiledPath"), path);
		}
	}
}
namespace KEngine.Table
{
	public class TabFileWriter : IDisposable
	{
		public readonly TableFile TabFile;

		public TabFileWriter()
		{
			TabFile = new TableFile();
		}

		public TabFileWriter(TableFile tabFile)
		{
			TabFile = tabFile;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (HeaderInfo value2 in TabFile.Headers.Values)
			{
				stringBuilder.Append($"{value2.HeaderName}\t");
			}
			stringBuilder.Append("\r\n");
			foreach (HeaderInfo value3 in TabFile.Headers.Values)
			{
				stringBuilder.Append($"{value3.HeaderMeta}\t");
			}
			stringBuilder.Append("\r\n");
			foreach (KeyValuePair<int, TableRow> row in TabFile.Rows)
			{
				TableRow value = row.Value;
				int num = value.Values.Length;
				for (int i = 0; i < num; i++)
				{
					stringBuilder.Append(value.Values[i]);
					if (i != num - 1)
					{
						stringBuilder.Append('\t');
					}
				}
				stringBuilder.Append("\r\n");
			}
			return stringBuilder.ToString();
		}

		public bool Save(string fileName)
		{
			lock (this)
			{
				bool result = false;
				try
				{
					using StreamWriter streamWriter = new StreamWriter(new FileStream(fileName, FileMode.Create), Encoding.UTF8);
					streamWriter.Write(ToString());
					result = true;
				}
				catch (IOException ex)
				{
					result = false;
					throw new Exception("可能文件正在被Excel打开?" + ex.Message);
				}
				return result;
			}
		}

		public TableRow NewRow()
		{
			int num = TabFile.Rows.Count + 1;
			TableRow tableRow = new TableRow(num, TabFile.Headers);
			TabFile.Rows.Add(num, tableRow);
			return tableRow;
		}

		public bool RemoveRow(int row)
		{
			return TabFile.Rows.Remove(row);
		}

		public TableRow GetRow(int row)
		{
			if (TabFile.Rows.TryGetValue(row, out var value))
			{
				return value;
			}
			return null;
		}

		public int NewColumn(string colName)
		{
			return NewColumn(colName, "");
		}

		public int NewColumn(string colName, string defineStr)
		{
			if (string.IsNullOrEmpty(colName))
			{
				throw new Exception("Null Col Name : " + colName);
			}
			HeaderInfo value = new HeaderInfo
			{
				ColumnIndex = TabFile.Headers.Count,
				HeaderName = colName,
				HeaderMeta = defineStr
			};
			TabFile.Headers.Add(colName, value);
			TabFile._colCount++;
			return TabFile._colCount;
		}

		public void Dispose()
		{
			TabFile.Dispose();
		}
	}
	public enum TableFileExceptionType
	{
		DuplicatedKey,
		HeadLineNull,
		MetaLineNull,
		NotFoundHeader,
		NotFoundGetMethod,
		NotFoundPrimaryKey,
		NotFoundRow
	}
	public class HeaderInfo
	{
		public int ColumnIndex;

		public string HeaderName;

		public string HeaderMeta;
	}
	public delegate void TableFileExceptionDelegate(TableFileExceptionType exceptionType, string[] args);
	public class TableFileStaticConfig
	{
		public static TableFileExceptionDelegate GlobalExceptionEvent;
	}
	public class TableFileConfig
	{
		public string Content;

		public char[] Separators = new char[1] { '\t' };

		public TableFileExceptionDelegate OnExceptionEvent;
	}
	public class TableFile : TableFile<TableRow>
	{
		public TableFile(string content)
			: base(content)
		{
		}

		public TableFile()
		{
		}

		public TableFile(string fileFullPath, Encoding encoding)
			: base(fileFullPath, encoding)
		{
		}

		public new static TableFile LoadFromString(string content)
		{
			return new TableFile(content);
		}

		public new static TableFile LoadFromFile(string fileFullPath, Encoding encoding = null)
		{
			return new TableFile(fileFullPath, encoding);
		}
	}
	public class TableFile<T> : IDisposable, IEnumerable<TableRow>, IEnumerable where T : TableRow
	{
		private readonly TableFileConfig _config;

		protected internal int _colCount;

		public readonly Dictionary<string, HeaderInfo> Headers = new Dictionary<string, HeaderInfo>();

		protected internal Dictionary<int, string[]> TabInfo = new Dictionary<int, string[]>();

		protected internal Dictionary<int, TableRow> Rows = new Dictionary<int, TableRow>();

		protected Dictionary<object, TableRow> PrimaryKey2Row = new Dictionary<object, TableRow>();

		public Dictionary<string, HeaderInfo>.KeyCollection HeaderNames => Headers.Keys;

		internal FieldInfo[] AutoTabFields => typeof(TableRow).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

		public TableFile(string content)
			: this(new TableFileConfig
			{
				Content = content
			})
		{
		}

		public TableFile()
			: this(new TableFileConfig())
		{
		}

		public TableFile(TableFileConfig config)
		{
			_config = config;
			if (!string.IsNullOrEmpty(_config.Content))
			{
				ParseString(_config.Content);
			}
		}

		public TableFile(string fileFullPath, Encoding encoding)
		{
			if (encoding == null)
			{
				encoding = Encoding.UTF8;
			}
			using FileStream stream = new FileStream(fileFullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			StreamReader streamReader = new StreamReader(stream, encoding);
			TableFileConfig config = new TableFileConfig
			{
				Content = streamReader.ReadToEnd()
			};
			_config = config;
			if (!string.IsNullOrEmpty(_config.Content))
			{
				ParseString(_config.Content);
			}
		}

		public static TableFile<T> LoadFromString(string content)
		{
			return new TableFile<T>(content);
		}

		public static TableFile<T> LoadFromFile(string fileFullPath, Encoding encoding = null)
		{
			return new TableFile<T>(fileFullPath, encoding);
		}

		protected bool ParseReader(TextReader oReader)
		{
			string text = oReader.ReadLine();
			if (text == null)
			{
				OnException(TableFileExceptionType.HeadLineNull);
				return false;
			}
			string text2 = oReader.ReadLine();
			if (text2 == null)
			{
				OnException(TableFileExceptionType.MetaLineNull);
				return false;
			}
			string[] array = text.Split(_config.Separators, StringSplitOptions.None);
			string[] array2 = new string[array.Length];
			string[] array3 = text2.Split(_config.Separators, StringSplitOptions.None);
			Array.Copy(array3, 0, array2, 0, array3.Length);
			for (int i = 0; i < array.Length; i++)
			{
				string headerName = array[i];
				HeaderInfo headerInfo = new HeaderInfo
				{
					ColumnIndex = i,
					HeaderName = headerName,
					HeaderMeta = array2[i]
				};
				Headers[headerInfo.HeaderName] = headerInfo;
			}
			_colCount = array.Length;
			string text3 = "";
			int num = 1;
			while (text3 != null)
			{
				text3 = oReader.ReadLine();
				if (text3 == null)
				{
					continue;
				}
				string[] array4 = text3.Split(_config.Separators, StringSplitOptions.None);
				TabInfo[num] = array4;
				T val = (T)Activator.CreateInstance(typeof(T), num, Headers);
				val.Values = array4;
				if (!val.IsAutoParse)
				{
					val.Parse(array4);
				}
				else
				{
					AutoParse(val, array4);
				}
				if (val.PrimaryKey != null)
				{
					if (!PrimaryKey2Row.TryGetValue(val.PrimaryKey, out var value))
					{
						PrimaryKey2Row[val.PrimaryKey] = val;
					}
					else
					{
						TableRow tableRow = value;
						OnException(TableFileExceptionType.DuplicatedKey, tableRow.PrimaryKey.ToString());
						val = (T)tableRow;
					}
				}
				Rows[num] = val;
				num++;
			}
			return true;
		}

		protected void AutoParse(TableRow tableRow, string[] cellStrs)
		{
			Type type = tableRow.GetType();
			List<FieldInfo> list = new List<FieldInfo>();
			FieldInfo[] autoTabFields = AutoTabFields;
			foreach (FieldInfo fieldInfo in autoTabFields)
			{
				if (!HasColumn(fieldInfo.Name))
				{
					OnException(TableFileExceptionType.NotFoundHeader, type.Name, fieldInfo.Name);
				}
				else
				{
					list.Add(fieldInfo);
				}
			}
			foreach (FieldInfo item in list)
			{
				string name = item.Name;
				Type fieldType = item.FieldType;
				string text = $"Get_{fieldType.Name}";
				MethodInfo method = type.GetMethod(text, BindingFlags.Instance | BindingFlags.NonPublic);
				if (method != null)
				{
					int columnIndex = Headers[name].ColumnIndex;
					string text2 = "";
					string headerMeta = Headers[name].HeaderMeta;
					if (!string.IsNullOrEmpty(headerMeta))
					{
						string[] array = headerMeta.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
						if (array.Length >= 2)
						{
							text2 = array[1];
						}
					}
					item.SetValue(tableRow, method.Invoke(tableRow, new object[2]
					{
						cellStrs[columnIndex],
						text2
					}));
				}
				else
				{
					OnException(TableFileExceptionType.NotFoundGetMethod, text);
				}
			}
		}

		protected bool ParseString(string content)
		{
			using (StringReader oReader = new StringReader(content))
			{
				ParseReader(oReader);
			}
			return true;
		}

		public bool HasColumn(string colName)
		{
			return Headers.ContainsKey(colName);
		}

		protected internal void OnException(TableFileExceptionType message, params string[] args)
		{
			if (TableFileStaticConfig.GlobalExceptionEvent != null)
			{
				TableFileStaticConfig.GlobalExceptionEvent(message, args);
			}
			if (_config.OnExceptionEvent != null)
			{
				_config.OnExceptionEvent(message, args);
			}
			if (TableFileStaticConfig.GlobalExceptionEvent != null || _config.OnExceptionEvent != null)
			{
				return;
			}
			string[] array = new string[args.Length];
			for (int i = 0; i < array.Length; i++)
			{
				string text = args[i];
				if (text != null)
				{
					array[i] = text.ToString();
				}
			}
			throw new Exception(string.Format("{0} - {1}", message, string.Join("|", array)));
		}

		[Obsolete("Use GetRowCount() instead")]
		public int GetHeight()
		{
			return Rows.Count;
		}

		public int GetRowCount()
		{
			return Rows.Count;
		}

		public int GetColumnCount()
		{
			return _colCount;
		}

		public int GetWidth()
		{
			return _colCount;
		}

		public T GetRow(int row)
		{
			if (!Rows.TryGetValue(row, out var value))
			{
				OnException(TableFileExceptionType.NotFoundRow, row.ToString());
				return null;
			}
			return (T)value;
		}

		public void Dispose()
		{
			Headers.Clear();
			TabInfo.Clear();
			Rows.Clear();
			PrimaryKey2Row.Clear();
		}

		public void Close()
		{
			Dispose();
		}

		public bool HasPrimaryKey(object primaryKey)
		{
			return PrimaryKey2Row.ContainsKey(primaryKey);
		}

		public T FindByPrimaryKey(object primaryKey, bool throwError = true)
		{
			if (PrimaryKey2Row.TryGetValue(primaryKey, out var value))
			{
				return (T)value;
			}
			if (throwError)
			{
				OnException(TableFileExceptionType.NotFoundPrimaryKey, primaryKey.ToString());
			}
			return null;
		}

		public T GetByPrimaryKey(object primaryKey)
		{
			return FindByPrimaryKey(primaryKey);
		}

		public IEnumerable<TableRow> GetAll()
		{
			return Rows.Values;
		}

		public IEnumerator<TableRow> GetEnumerator()
		{
			return Rows.Values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return Rows.Values.GetEnumerator();
		}
	}
	public class TableRowParser
	{
		public string Get_String(string value, string defaultValue)
		{
			return Get_string(value, defaultValue);
		}

		public string Get_string(string value, string defaultValue)
		{
			if (string.IsNullOrEmpty(value))
			{
				return defaultValue;
			}
			return value;
		}

		public int Get_Int32(string value, string defaultValue)
		{
			return Get_int(value, defaultValue);
		}

		public bool Get_bool(string value, string defaultValue)
		{
			return Get_Boolean(value, defaultValue);
		}

		public bool Get_Boolean(string value, string defaultValue)
		{
			if (bool.TryParse(Get_string(value, defaultValue), out var result))
			{
				return result;
			}
			return Get_int(value, defaultValue) != 0;
		}

		public int Get_int(string value, string defaultValue)
		{
			string text = Get_string(value, defaultValue);
			if (!string.IsNullOrEmpty(text))
			{
				return int.Parse(text);
			}
			return 0;
		}

		public double Get_double(string value, string defaultValue)
		{
			string text = Get_string(value, defaultValue);
			if (!string.IsNullOrEmpty(text))
			{
				return double.Parse(text);
			}
			return 0.0;
		}

		public float Get_float(string value, string defaultValue)
		{
			string text = Get_string(value, defaultValue);
			if (!string.IsNullOrEmpty(text))
			{
				return float.Parse(text);
			}
			return 0f;
		}

		public uint Get_uint(string value, string defaultValue)
		{
			string text = Get_string(value, defaultValue);
			if (!string.IsNullOrEmpty(text))
			{
				return uint.Parse(text);
			}
			return 0u;
		}

		public string[] Get_string_array(string value, string defaultValue)
		{
			return Get_string(value, defaultValue).Split(',');
		}

		public Dictionary<string, int> Get_Dictionary_string_int(string value, string defaultValue)
		{
			return GetDictionary<string, int>(value, defaultValue);
		}

		protected Dictionary<TKey, TValue> GetDictionary<TKey, TValue>(string value, string defaultValue)
		{
			Dictionary<TKey, TValue> dictionary = new Dictionary<TKey, TValue>();
			string[] array = Get_String(value, defaultValue).Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[1] { ':' }, StringSplitOptions.RemoveEmptyEntries);
				TKey key = ConvertString<TKey>(array2[0]);
				TValue value2 = ConvertString<TValue>(array2[1]);
				dictionary[key] = value2;
			}
			return dictionary;
		}

		protected T ConvertString<T>(string value)
		{
			return (T)Convert.ChangeType(value, typeof(T));
		}
	}
	public class TableRow : TableRowParser
	{
		public int RowNumber { get; internal set; }

		public virtual bool IsAutoParse => false;

		public Dictionary<string, HeaderInfo> HeaderInfos { get; internal set; }

		public string[] Values { get; internal set; }

		public virtual string PrimaryKey => this[0];

		public string this[int index]
		{
			get
			{
				if (index > Values.Length || index < 0)
				{
					throw new Exception($"Overflow index `{index}`");
				}
				return Values[index];
			}
			set
			{
				Values[index] = value;
			}
		}

		public string this[string headerName]
		{
			get
			{
				if (!HeaderInfos.TryGetValue(headerName, out var value))
				{
					throw new Exception("not found header: " + headerName);
				}
				return this[value.ColumnIndex];
			}
			set
			{
				if (!HeaderInfos.TryGetValue(headerName, out var value2))
				{
					throw new Exception("not found header: " + headerName);
				}
				this[value2.ColumnIndex] = value;
			}
		}

		public TableRow(int rowNumber, Dictionary<string, HeaderInfo> headerInfos)
		{
			Ctor(rowNumber, headerInfos);
		}

		private void Ctor(int rowNumber, Dictionary<string, HeaderInfo> headerInfos)
		{
			RowNumber = rowNumber;
			HeaderInfos = headerInfos;
			Values = new string[headerInfos.Count];
		}

		public virtual void Parse(string[] cellStrs)
		{
		}

		public string Get(int index)
		{
			return this[index];
		}

		public string Get(string headerName)
		{
			return this[headerName];
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[AddComponentMenu("Dark Tonic/Master Audio/Ambient Sound")]
	[AudioScriptOrder(-20)]
	public class AmbientSound : MonoBehaviour
	{
		[SoundGroup]
		public string AmbientSoundGroup = "[None]";

		public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;

		public string variationName = string.Empty;

		public float playVolume = 1f;

		public MasterAudio.AmbientSoundExitMode exitMode;

		public float exitFadeTime = 0.5f;

		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		public float reEnterFadeTime = 0.5f;

		[Tooltip("This option is useful if your caller ever moves, as it will make the Audio Source follow to the location of the caller every frame.")]
		public bool FollowCaller;

		[Tooltip("Using this option, the Audio Source will be updated every frame to the closest position on the caller's collider, if any. This will override the Follow Caller option above and happen instead.")]
		public bool UseClosestColliderPosition;

		public bool UseTopCollider = true;

		public bool IncludeChildColliders;

		[Tooltip("This is for diagnostic purposes only. Do not change or assign this field.")]
		public Transform RuntimeFollower;

		private Transform _trans;

		public float colliderMaxDistance;

		public long lastTimeMaxDistanceCalced;

		public bool IsValidSoundGroup => !MasterAudio.SoundGroupHardCodedNames.Contains(AmbientSoundGroup);

		public Transform Trans
		{
			get
			{
				if (_trans == null)
				{
					_trans = base.transform;
				}
				return _trans;
			}
		}

		private void OnEnable()
		{
			MasterAudio.SetupAmbientNextFrame(this);
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown && IsValidSoundGroup && !(MasterAudio.SafeInstance == null))
			{
				MasterAudio.RemoveDelayedAmbient(this);
				StopTrackers();
			}
		}

		private void StopTrackers()
		{
			if (MasterAudio.GrabGroup(AmbientSoundGroup, logIfMissing: false) != null)
			{
				switch (exitMode)
				{
				case MasterAudio.AmbientSoundExitMode.StopSound:
					MasterAudio.StopSoundGroupOfTransform(Trans, AmbientSoundGroup);
					break;
				case MasterAudio.AmbientSoundExitMode.FadeSound:
					MasterAudio.FadeOutSoundGroupOfTransform(Trans, AmbientSoundGroup, exitFadeTime);
					break;
				}
			}
			RuntimeFollower = null;
		}

		public void CalculateRadius()
		{
			AudioSource namedOrFirstAudioSource = GetNamedOrFirstAudioSource();
			if (namedOrFirstAudioSource == null)
			{
				colliderMaxDistance = 0f;
				return;
			}
			colliderMaxDistance = namedOrFirstAudioSource.maxDistance;
			lastTimeMaxDistanceCalced = DateTime.Now.Ticks;
		}

		public AudioSource GetNamedOrFirstAudioSource()
		{
			if (string.IsNullOrEmpty(AmbientSoundGroup))
			{
				colliderMaxDistance = 0f;
				return null;
			}
			if (MasterAudio.SafeInstance == null)
			{
				colliderMaxDistance = 0f;
				return null;
			}
			Transform transform = MasterAudio.Instance.transform.Find(AmbientSoundGroup);
			if (transform == null)
			{
				colliderMaxDistance = 0f;
				return null;
			}
			Transform transform2 = null;
			switch (variationType)
			{
			case EventSounds.VariationType.PlayRandom:
				transform2 = transform.GetChild(0);
				break;
			case EventSounds.VariationType.PlaySpecific:
				transform2 = transform.transform.Find(variationName);
				break;
			}
			if (transform2 == null)
			{
				colliderMaxDistance = 0f;
				return null;
			}
			return transform2.GetComponent<AudioSource>();
		}

		public List<AudioSource> GetAllVariationAudioSources()
		{
			if (string.IsNullOrEmpty(AmbientSoundGroup))
			{
				colliderMaxDistance = 0f;
				return null;
			}
			if (MasterAudio.SafeInstance == null)
			{
				colliderMaxDistance = 0f;
				return null;
			}
			Transform transform = MasterAudio.Instance.transform.Find(AmbientSoundGroup);
			if (transform == null)
			{
				colliderMaxDistance = 0f;
				return null;
			}
			List<AudioSource> list = new List<AudioSource>(transform.childCount);
			for (int i = 0; i < transform.childCount; i++)
			{
				AudioSource component = transform.GetChild(i).GetComponent<AudioSource>();
				list.Add(component);
			}
			return list;
		}

		private void OnDrawGizmos()
		{
			if (MasterAudio.SafeInstance == null || !MasterAudio.Instance.showRangeSoundGizmos)
			{
				return;
			}
			if (lastTimeMaxDistanceCalced < DateTime.Now.AddHours(-1.0).Ticks)
			{
				lastTimeMaxDistanceCalced = DateTime.Now.Ticks;
				CalculateRadius();
			}
			if (colliderMaxDistance != 0f)
			{
				Color color = Color.green;
				if (MasterAudio.SafeInstance != null)
				{
					color = MasterAudio.Instance.rangeGizmoColor;
				}
				Gizmos.color = color;
				Gizmos.DrawWireSphere(base.transform.position, colliderMaxDistance);
			}
		}

		private void OnDrawGizmosSelected()
		{
			if (MasterAudio.SafeInstance == null || !MasterAudio.Instance.showSelectedRangeSoundGizmos)
			{
				return;
			}
			if (lastTimeMaxDistanceCalced < DateTime.Now.AddHours(-1.0).Ticks)
			{
				lastTimeMaxDistanceCalced = DateTime.Now.Ticks;
				CalculateRadius();
			}
			if (colliderMaxDistance != 0f)
			{
				Color color = Color.green;
				if (MasterAudio.SafeInstance != null)
				{
					color = MasterAudio.Instance.selectedRangeGizmoColor;
				}
				Gizmos.color = color;
				Gizmos.DrawWireSphere(base.transform.position, colliderMaxDistance);
			}
		}

		public void StartTrackers()
		{
			if (!IsValidSoundGroup)
			{
				return;
			}
			if (Physics.GetIgnoreLayerCollision(2, 2))
			{
				MasterAudio.LogWarningIfNeverLogged("You have disabled collisions between Ignore Raycast layer and itself on the Physics Layer Collision matrix. This must be turned back on or Ambient Sounds script will not function.", 1);
				return;
			}
			if (!AmbientUtil.InitListenerFollower())
			{
				MasterAudio.LogWarning("Your Ambient Sound script on Game Object '" + base.name + "' will not function because you have no Audio Listener component in any active Game Object in the Scene.");
				return;
			}
			if (!AmbientUtil.HasListenerFolowerRigidBody)
			{
				MasterAudio.LogWarning("Your Ambient Sound script on Game Object '" + base.name + "' will not function because you have turned off the Listener Follower RigidBody in Advanced Settings.");
			}
			string followerName = base.name + "_" + AmbientSoundGroup + "_" + UnityEngine.Random.Range(0, 9) + "_Follower";
			RuntimeFollower = AmbientUtil.InitAudioSourceFollower(Trans, followerName, AmbientSoundGroup, variationName, playVolume, FollowCaller, UseClosestColliderPosition, UseTopCollider, IncludeChildColliders, exitMode, exitFadeTime, reEnterMode, reEnterFadeTime);
		}
	}
	[AddComponentMenu("Dark Tonic/Master Audio/Button Clicker")]
	public class ButtonClicker : MonoBehaviour
	{
		public const float SmallSizeMultiplier = 0.9f;

		public const float LargeSizeMultiplier = 1.1f;

		public bool resizeOnClick = true;

		public bool resizeClickAllSiblings;

		public bool resizeOnHover;

		public bool resizeHoverAllSiblings;

		public string mouseDownSound = string.Empty;

		public string mouseUpSound = string.Empty;

		public string mouseClickSound = string.Empty;

		public string mouseOverSound = string.Empty;

		public string mouseOutSound = string.Empty;

		private Vector3 _originalSize;

		private Vector3 _smallerSize;

		private Vector3 _largerSize;

		private Transform _trans;

		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform = new Dictionary<Transform, Vector3>();

		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform = new Dictionary<Transform, Vector3>();

		private void Awake()
		{
			_trans = base.transform;
			_originalSize = _trans.localScale;
			_smallerSize = _originalSize * 0.9f;
			_largerSize = _originalSize * 1.1f;
			Transform parent = _trans.parent;
			if (resizeOnClick && resizeClickAllSiblings && parent != null)
			{
				for (int i = 0; i < parent.transform.childCount; i++)
				{
					Transform child = parent.transform.GetChild(i);
					_siblingClickScaleByTransform.Add(child, child.localScale);
				}
			}
			if (resizeOnHover && resizeHoverAllSiblings && !(parent == null))
			{
				for (int j = 0; j < parent.transform.childCount; j++)
				{
					Transform child2 = parent.transform.GetChild(j);
					_siblingHoverScaleByTransform.Add(child2, child2.localScale);
				}
			}
		}

		private void OnPress(bool isDown)
		{
			if (isDown)
			{
				if (!base.enabled)
				{
					return;
				}
				MasterAudio.PlaySoundAndForget(mouseDownSound);
				if (resizeOnClick)
				{
					_trans.localScale = _smallerSize;
					Dictionary<Transform, Vector3>.Enumerator enumerator = _siblingClickScaleByTransform.GetEnumerator();
					while (enumerator.MoveNext())
					{
						enumerator.Current.Key.localScale = enumerator.Current.Value * 0.9f;
					}
				}
				return;
			}
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseUpSound);
			}
			if (resizeOnClick)
			{
				_trans.localScale = _originalSize;
				Dictionary<Transform, Vector3>.Enumerator enumerator2 = _siblingClickScaleByTransform.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Key.localScale = enumerator2.Current.Value;
				}
			}
		}

		private void OnClick()
		{
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseClickSound);
			}
		}

		private void OnHover(bool isOver)
		{
			if (isOver)
			{
				if (!base.enabled)
				{
					return;
				}
				MasterAudio.PlaySoundAndForget(mouseOverSound);
				if (resizeOnHover)
				{
					_trans.localScale = _largerSize;
					Dictionary<Transform, Vector3>.Enumerator enumerator = _siblingHoverScaleByTransform.GetEnumerator();
					while (enumerator.MoveNext())
					{
						enumerator.Current.Key.localScale = enumerator.Current.Value * 1.1f;
					}
				}
				return;
			}
			if (base.enabled)
			{
				MasterAudio.PlaySoundAndForget(mouseOutSound);
			}
			if (resizeOnHover)
			{
				_trans.localScale = _originalSize;
				Dictionary<Transform, Vector3>.Enumerator enumerator2 = _siblingHoverScaleByTransform.GetEnumerator();
				while (enumerator2.MoveNext())
				{
					enumerator2.Current.Key.localScale = enumerator2.Current.Value;
				}
			}
		}
	}
	[AudioScriptOrder(-30)]
	[AddComponentMenu("Dark Tonic/Master Audio/Event Sounds")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		public enum UnityUIVersion
		{
			Legacy,
			uGUI
		}

		public enum EventType
		{
			OnStart,
			OnVisible,
			OnInvisible,
			OnCollision,
			OnTriggerEnter,
			OnTriggerExit,
			OnMouseEnter,
			OnMouseClick,
			OnSpawned,
			OnDespawned,
			OnEnable,
			OnDisable,
			OnCollision2D,
			OnTriggerEnter2D,
			OnTriggerExit2D,
			OnParticleCollision,
			UserDefinedEvent,
			OnCollisionExit,
			OnCollisionExit2D,
			OnMouseUp,
			OnMouseExit,
			OnMouseDrag,
			NGUIOnClick,
			NGUIMouseDown,
			NGUIMouseUp,
			NGUIMouseEnter,
			NGUIMouseExit,
			MechanimStateChanged,
			UnitySliderChanged,
			UnityButtonClicked,
			UnityPointerDown,
			UnityPointerUp,
			UnityPointerEnter,
			UnityPointerExit,
			UnityDrag,
			UnityDrop,
			UnityScroll,
			UnityUpdateSelected,
			UnitySelect,
			UnityDeselect,
			UnityMove,
			UnityInitializePotentialDrag,
			UnityBeginDrag,
			UnityEndDrag,
			UnitySubmit,
			UnityCancel,
			UnityToggle,
			OnTriggerStay,
			OnTriggerStay2D
		}

		public enum GlidePitchType
		{
			None,
			RaisePitch,
			LowerPitch
		}

		public enum VariationType
		{
			PlaySpecific,
			PlayRandom
		}

		public enum PreviousSoundStopMode
		{
			None,
			Stop,
			FadeOut
		}

		public enum RetriggerLimMode
		{
			None,
			FrameBased,
			TimeBased
		}

		public MasterAudio.SoundSpawnLocationMode soundSpawnMode = MasterAudio.SoundSpawnLocationMode.AttachToCaller;

		public bool disableSounds;

		public bool showPoolManager;

		public bool showNGUI;

		public AudioEvent eventToGizmo;

		public UnityUIVersion unityUIMode = UnityUIVersion.uGUI;

		public bool logMissingEvents = true;

		public static List<string> LayerTagFilterEvents = new List<string>
		{
			EventType.OnCollision.ToString(),
			EventType.OnTriggerEnter.ToString(),
			EventType.OnTriggerExit.ToString(),
			EventType.OnCollision2D.ToString(),
			EventType.OnTriggerEnter2D.ToString(),
			EventType.OnTriggerExit2D.ToString(),
			EventType.OnParticleCollision.ToString(),
			EventType.OnCollisionExit.ToString(),
			EventType.OnCollisionExit2D.ToString()
		};

		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll = new List<MasterAudio.PlaylistCommand>
		{
			MasterAudio.PlaylistCommand.FadeToVolume,
			MasterAudio.PlaylistCommand.Pause,
			MasterAudio.PlaylistCommand.PlayNextSong,
			MasterAudio.PlaylistCommand.PlayRandomSong,
			MasterAudio.PlaylistCommand.Resume,
			MasterAudio.PlaylistCommand.Stop,
			MasterAudio.PlaylistCommand.Mute,
			MasterAudio.PlaylistCommand.Unmute,
			MasterAudio.PlaylistCommand.ToggleMute,
			MasterAudio.PlaylistCommand.Restart,
			MasterAudio.PlaylistCommand.StopLoopingCurrentSong,
			MasterAudio.PlaylistCommand.StopPlaylistAfterCurrentSong
		};

		public AudioEventGroup startSound;

		public AudioEventGroup visibleSound;

		public AudioEventGroup invisibleSound;

		public AudioEventGroup collisionSound;

		public AudioEventGroup collisionExitSound;

		public AudioEventGroup triggerSound;

		public AudioEventGroup triggerExitSound;

		public AudioEventGroup triggerStaySound;

		public AudioEventGroup mouseEnterSound;

		public AudioEventGroup mouseExitSound;

		public AudioEventGroup mouseClickSound;

		public AudioEventGroup mouseUpSound;

		public AudioEventGroup mouseDragSound;

		public AudioEventGroup spawnedSound;

		public AudioEventGroup despawnedSound;

		public AudioEventGroup enableSound;

		public AudioEventGroup disableSound;

		public AudioEventGroup collision2dSound;

		public AudioEventGroup collisionExit2dSound;

		public AudioEventGroup triggerEnter2dSound;

		public AudioEventGroup triggerStay2dSound;

		public AudioEventGroup triggerExit2dSound;

		public AudioEventGroup particleCollisionSound;

		public AudioEventGroup nguiOnClickSound;

		public AudioEventGroup nguiMouseDownSound;

		public AudioEventGroup nguiMouseUpSound;

		public AudioEventGroup nguiMouseEnterSound;

		public AudioEventGroup nguiMouseExitSound;

		public AudioEventGroup unitySliderChangedSound;

		public AudioEventGroup unityButtonClickedSound;

		public AudioEventGroup unityPointerDownSound;

		public AudioEventGroup unityDragSound;

		public AudioEventGroup unityPointerUpSound;

		public AudioEventGroup unityPointerEnterSound;

		public AudioEventGroup unityPointerExitSound;

		public AudioEventGroup unityDropSound;

		public AudioEventGroup unityScrollSound;

		public AudioEventGroup unityUpdateSelectedSound;

		public AudioEventGroup unitySelectSound;

		public AudioEventGroup unityDeselectSound;

		public AudioEventGroup unityMoveSound;

		public AudioEventGroup unityInitializePotentialDragSound;

		public AudioEventGroup unityBeginDragSound;

		public AudioEventGroup unityEndDragSound;

		public AudioEventGroup unitySubmitSound;

		public AudioEventGroup unityCancelSound;

		public AudioEventGroup unityToggleSound;

		public List<AudioEventGroup> userDefinedSounds = new List<AudioEventGroup>();

		public List<AudioEventGroup> mechanimStateChangedSounds = new List<AudioEventGroup>();

		public bool useStartSound;

		public bool useVisibleSound;

		public bool useInvisibleSound;

		public bool useCollisionSound;

		public bool useCollisionExitSound;

		public bool useTriggerEnterSound;

		public bool useTriggerExitSound;

		public bool useTriggerStaySound;

		public bool useMouseEnterSound;

		public bool useMouseExitSound;

		public bool useMouseClickSound;

		public bool useMouseUpSound;

		public bool useMouseDragSound;

		public bool useSpawnedSound;

		public bool useDespawnedSound;

		public bool useEnableSound;

		public bool useDisableSound;

		public bool useCollision2dSound;

		public bool useCollisionExit2dSound;

		public bool useTriggerEnter2dSound;

		public bool useTriggerStay2dSound;

		public bool useTriggerExit2dSound;

		public bool useParticleCollisionSound;

		public bool useNguiOnClickSound;

		public bool useNguiMouseDownSound;

		public bool useNguiMouseUpSound;

		public bool useNguiMouseEnterSound;

		public bool useNguiMouseExitSound;

		public bool useUnitySliderChangedSound;

		public bool useUnityButtonClickedSound;

		public bool useUnityPointerDownSound;

		public bool useUnityDragSound;

		public bool useUnityPointerUpSound;

		public bool useUnityPointerEnterSound;

		public bool useUnityPointerExitSound;

		public bool useUnityDropSound;

		public bool useUnityScrollSound;

		public bool useUnityUpdateSelectedSound;

		public bool useUnitySelectSound;

		public bool useUnityDeselectSound;

		public bool useUnityMoveSound;

		public bool useUnityInitializePotentialDragSound;

		public bool useUnityBeginDragSound;

		public bool useUnityEndDragSound;

		public bool useUnitySubmitSound;

		public bool useUnityCancelSound;

		public bool useUnityToggleSound;

		private Slider _slider;

		private Toggle _toggle;

		private Button _button;

		private bool _isVisible;

		private bool _needsCoroutine;

		private float? _triggerEnterTime;

		private float? _triggerEnter2dTime;

		private Transform _trans;

		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds = new List<AudioEventGroup>();

		private Animator _anim;

		private bool IsSetToUGUI => unityUIMode != UnityUIVersion.Legacy;

		private bool IsSetToLegacyUI => unityUIMode == UnityUIVersion.Legacy;

		private void Awake()
		{
			_trans = base.transform;
			_anim = GetComponent<Animator>();
			_slider = GetComponent<Slider>();
			_button = GetComponent<Button>();
			_toggle = GetComponent<Toggle>();
			if (IsSetToUGUI)
			{
				AddUGUIComponents();
			}
			SpawnedOrAwake();
		}

		protected virtual void SpawnedOrAwake()
		{
			_isVisible = false;
			_validMechanimStateChangedSounds.Clear();
			_needsCoroutine = false;
			if (disableSounds || _anim == null)
			{
				return;
			}
			for (int i = 0; i < mechanimStateChangedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = mechanimStateChangedSounds[i];
				if (audioEventGroup.mechanimEventActive && !string.IsNullOrEmpty(audioEventGroup.mechanimStateName))
				{
					_needsCoroutine = true;
					_validMechanimStateChangedSounds.Add(audioEventGroup);
				}
			}
		}

		private IEnumerator CoUpdate()
		{
			while (true)
			{
				yield return MasterAudio.EndOfFrameDelay;
				for (int i = 0; i < _validMechanimStateChangedSounds.Count; i++)
				{
					AudioEventGroup audioEventGroup = _validMechanimStateChangedSounds[i];
					if (!_anim.GetCurrentAnimatorStateInfo(0).IsName(audioEventGroup.mechanimStateName))
					{
						audioEventGroup.mechEventPlayedForState = false;
					}
					else if (!audioEventGroup.mechEventPlayedForState)
					{
						audioEventGroup.mechEventPlayedForState = true;
						PlaySounds(audioEventGroup, EventType.MechanimStateChanged);
					}
				}
			}
		}

		private void Start()
		{
			CheckForIllegalCustomEvents();
			if (useStartSound)
			{
				PlaySounds(startSound, EventType.OnStart);
			}
		}

		private void OnBecameVisible()
		{
			if (useVisibleSound && !_isVisible)
			{
				_isVisible = true;
				PlaySounds(visibleSound, EventType.OnVisible);
			}
		}

		private void OnBecameInvisible()
		{
			if (useInvisibleSound)
			{
				_isVisible = false;
				PlaySounds(invisibleSound, EventType.OnInvisible);
			}
		}

		private void OnEnable()
		{
			if (_slider != null)
			{
				_slider.onValueChanged.AddListener(SliderChanged);
				RestorePersistentSliders();
			}
			if (_button != null)
			{
				_button.onClick.AddListener(ButtonClicked);
			}
			if (_toggle != null)
			{
				_toggle.onValueChanged.AddListener(ToggleChanged);
			}
			RegisterReceiver();
			if (_needsCoroutine)
			{
				StopAllCoroutines();
				StartCoroutine(CoUpdate());
			}
			if (useEnableSound)
			{
				PlaySounds(enableSound, EventType.OnEnable);
			}
		}

		private void RestorePersistentSliders()
		{
			if (!useUnitySliderChangedSound)
			{
				return;
			}
			foreach (AudioEvent soundEvent in unitySliderChangedSound.SoundEvents)
			{
				if (soundEvent.currentSoundFunctionType != MasterAudio.EventSoundFunctionType.PersistentSettingsControl || soundEvent.targetVolMode != 0)
				{
					continue;
				}
				switch (soundEvent.currentPersistentSettingsCommand)
				{
				case MasterAudio.PersistentSettingsCommand.SetMusicVolume:
				{
					float? musicVolume = PersistentAudioSettings.MusicVolume;
					if (musicVolume.HasValue)
					{
						_slider.value = musicVolume.Value;
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetBusVolume:
					if (!soundEvent.allSoundTypesForBusCmd)
					{
						float? busVolume = PersistentAudioSettings.GetBusVolume(soundEvent.busName);
						if (busVolume.HasValue)
						{
							_slider.value = busVolume.Value;
						}
					}
					break;
				case MasterAudio.PersistentSettingsCommand.SetMixerVolume:
				{
					float? mixerVolume = PersistentAudioSettings.MixerVolume;
					if (mixerVolume.HasValue)
					{
						_slider.value = mixerVolume.Value;
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetGroupVolume:
					if (!soundEvent.allSoundTypesForGroupCmd)
					{
						float? groupVolume = PersistentAudioSettings.GetGroupVolume(soundEvent.soundType);
						if (groupVolume.HasValue)
						{
							_slider.value = groupVolume.Value;
						}
					}
					break;
				}
			}
		}

		private void OnDisable()
		{
			if (!(MasterAudio.SafeInstance == null) && !MasterAudio.AppIsShuttingDown)
			{
				if (_slider != null)
				{
					_slider.onValueChanged.RemoveListener(SliderChanged);
				}
				if (_button != null)
				{
					_button.onClick.RemoveListener(ButtonClicked);
				}
				if (_toggle != null)
				{
					_toggle.onValueChanged.RemoveListener(ToggleChanged);
				}
				UnregisterReceiver();
				if (useDisableSound && !MasterAudio.AppIsShuttingDown)
				{
					PlaySounds(disableSound, EventType.OnDisable);
				}
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (useCollisionSound && (!collisionSound.useLayerFilter || collisionSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collisionSound.useTagFilter || collisionSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collisionSound, EventType.OnCollision);
			}
		}

		private void OnCollisionExit(Collision collision)
		{
			if (useCollisionExitSound && (!collisionExitSound.useLayerFilter || collisionExitSound.matchingLayers.Contains(collision.gameObject.layer)) && (!collisionExitSound.useTagFilter || collisionExitSound.matchingTags.Contains(collision.gameObject.tag)))
			{
				PlaySounds(collisionExitSound, EventType.OnCollisionExit);
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			_triggerEnterTime = Time.realtimeSinceStartup;
			if (useTriggerEnterSound && (!triggerSound.useLayerFilter || triggerSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerSound.useTagFilter || triggerSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerSound, EventType.OnTriggerEnter);
			}
		}

		private void OnTriggerStay(Collider other)
		{
			if (useTriggerStaySound)
			{
				float num = 0f;
				num = (_triggerEnterTime.HasValue ? (Time.realtimeSinceStartup - _triggerEnterTime.Value) : 0f);
				if (!(triggerStaySound.triggerStayForTime > num) && PlaySounds(triggerStaySound, EventType.OnTriggerStay) && triggerStaySound.doesTriggerStayRepeat)
				{
					_triggerEnterTime = Time.realtimeSinceStartup;
				}
			}
		}

		private void OnTriggerExit(Collider other)
		{
			_triggerEnterTime = null;
			if (useTriggerExitSound && (!triggerExitSound.useLayerFilter || triggerExitSound.matchingLayers.Contains(other.gameObject.layer)) && (!triggerExitSound.useTagFilter || triggerExitSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(triggerExitSound, EventType.OnTriggerExit);
			}
		}

		private void OnParticleCollision(GameObject other)
		{
			if (useParticleCollisionSound && (!particleCollisionSound.useLayerFilter || particleCollisionSound.matchingLayers.Contains(other.gameObject.layer)) && (!particleCollisionSound.useTagFilter || particleCollisionSound.matchingTags.Contains(other.gameObject.tag)))
			{
				PlaySounds(particleCollisionSound, EventType.OnParticleCollision);
			}
		}

		public void OnPointerEnter(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerEnterSound)
			{
				PlaySounds(unityPointerEnterSound, EventType.UnityPointerEnter);
			}
		}

		public void OnPointerExit(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerExitSound)
			{
				PlaySounds(unityPointerExitSound, EventType.UnityPointerExit);
			}
		}

		public void OnPointerDown(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerDownSound)
			{
				PlaySounds(unityPointerDownSound, EventType.UnityPointerDown);
			}
		}

		public void OnPointerUp(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityPointerUpSound)
			{
				PlaySounds(unityPointerUpSound, EventType.UnityPointerUp);
			}
		}

		private void OnDrag(Vector2 delta)
		{
		}

		public void OnDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityDragSound)
			{
				PlaySounds(unityDragSound, EventType.UnityDrag);
			}
		}

		private void OnDrop(GameObject go)
		{
		}

		public void OnDrop(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityDropSound)
			{
				PlaySounds(unityDropSound, EventType.UnityDrop);
			}
		}

		public void OnScroll(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityScrollSound)
			{
				PlaySounds(unityScrollSound, EventType.UnityScroll);
			}
		}

		public void OnUpdateSelected(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityUpdateSelectedSound)
			{
				PlaySounds(unityUpdateSelectedSound, EventType.UnityUpdateSelected);
			}
		}

		private void OnSelect(bool isSelected)
		{
		}

		public void OnSelect(BaseEventData data)
		{
			if (IsSetToUGUI && useUnitySelectSound)
			{
				PlaySounds(unitySelectSound, EventType.UnitySelect);
			}
		}

		public void OnDeselect(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityDeselectSound)
			{
				PlaySounds(unityDeselectSound, EventType.UnityDeselect);
			}
		}

		public void OnMove(AxisEventData data)
		{
			if (IsSetToUGUI && useUnityMoveSound)
			{
				PlaySounds(unityMoveSound, EventType.UnityMove);
			}
		}

		public void OnInitializePotentialDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityInitializePotentialDragSound)
			{
				PlaySounds(unityInitializePotentialDragSound, EventType.UnityInitializePotentialDrag);
			}
		}

		public void OnBeginDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityBeginDragSound)
			{
				PlaySounds(unityBeginDragSound, EventType.UnityBeginDrag);
			}
		}

		public void OnEndDrag(PointerEventData data)
		{
			if (IsSetToUGUI && useUnityEndDragSound)
			{
				PlaySounds(unityEndDragSound, EventType.UnityEndDrag);
			}
		}

		public void OnSubmit(BaseEventData data)
		{
			if (IsSetToUGUI && useUnitySubmitSound)
			{
				PlaySounds(unitySubmitSound, EventType.UnitySubmit);
			}
		}

		public void OnCancel(BaseEventData data)
		{
			if (IsSetToUGUI && useUnityCancelSound)
			{
				PlaySounds(unityCancelSound, EventType.UnityCancel);
			}
		}

		private void SliderChanged(float newValue)
		{
			if (useUnitySliderChangedSound)
			{
				unitySliderChangedSound.sliderValue = newValue;
				PlaySounds(unitySliderChangedSound, EventType.UnitySliderChanged);
			}
		}

		private void ToggleChanged(bool newValue)
		{
			if (useUnityToggleSound)
			{
				PlaySounds(unityToggleSound, EventType.UnityToggle);
			}
		}

		private void ButtonClicked()
		{
			if (useUnityButtonClickedSound)
			{
				PlaySounds(unityButtonClickedSound, EventType.UnityButtonClicked);
			}
		}

		private void OnPress(bool isDown)
		{
			if (!showNGUI)
			{
				return;
			}
			if (isDown)
			{
				if (useNguiMouseDownSound)
				{
					PlaySounds(nguiMouseDownSound, EventType.NGUIMouseDown);
				}
			}
			else if (useNguiMouseUpSound)
			{
				PlaySounds(nguiMouseUpSound, EventType.NGUIMouseUp);
			}
		}

		private void OnClick()
		{
			if (showNGUI && useNguiOnClickSound)
			{
				PlaySounds(nguiOnClickSound, EventType.NGUIOnClick);
			}
		}

		private void OnHover(bool isOver)
		{
			if (!showNGUI)
			{
				return;
			}
			if (isOver)
			{
				if (useNguiMouseEnterSound)
				{
					PlaySounds(nguiMouseEnterSound, EventType.NGUIMouseEnter);
				}
			}
			else if (useNguiMouseExitSound)
			{
				PlaySounds(nguiMouseExitSound, EventType.NGUIMouseExit);
			}
		}

		private void OnSpawned()
		{
			SpawnedOrAwake();
			if (showPoolManager && useSpawnedSound)
			{
				PlaySounds(spawnedSound, EventType.OnSpawned);
			}
		}

		private void OnDespawned()
		{
			if (showPoolManager && useDespawnedSound)
			{
				PlaySounds(despawnedSound, EventType.OnDespawned);
			}
		}

		public void CalculateRadius(AudioEvent anEvent)
		{
			AudioSource namedOrFirstAudioSource = GetNamedOrFirstAudioSource(anEvent);
			if (namedOrFirstAudioSource == null)
			{
				anEvent.colliderMaxDistance = 0f;
			}
			else
			{
				anEvent.colliderMaxDistance = namedOrFirstAudioSource.maxDistance;
			}
		}

		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			if (string.IsNullOrEmpty(anEvent.soundType))
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			if (MasterAudio.SafeInstance == null)
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			Transform transform = MasterAudio.Instance.transform.Find(anEvent.soundType);
			if (transform == null)
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			Transform transform2 = null;
			switch (anEvent.variationType)
			{
			case VariationType.PlayRandom:
				transform2 = transform.GetChild(0);
				break;
			case VariationType.PlaySpecific:
				transform2 = transform.transform.Find(anEvent.variationName);
				break;
			}
			if (transform2 == null)
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			return transform2.GetComponent<AudioSource>();
		}

		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			if (string.IsNullOrEmpty(anEvent.soundType))
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			if (MasterAudio.SafeInstance == null)
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			Transform transform = MasterAudio.Instance.transform.Find(anEvent.soundType);
			if (transform == null)
			{
				anEvent.colliderMaxDistance = 0f;
				return null;
			}
			List<AudioSource> list = new List<AudioSource>(transform.childCount);
			for (int i = 0; i < transform.childCount; i++)
			{
				AudioSource component = transform.GetChild(i).GetComponent<AudioSource>();
				list.Add(component);
			}
			return list;
		}

		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return _validMechanimStateChangedSounds.Find((AudioEventGroup grp) => grp.mechanimStateName == stateName);
		}

		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			if (!CheckForRetriggerLimit(eventGrp))
			{
				return false;
			}
			if (MasterAudio.SafeInstance == null)
			{
				return false;
			}
			switch (eventGrp.retriggerLimitMode)
			{
			case RetriggerLimMode.FrameBased:
				eventGrp.triggeredLastFrame = AudioUtil.FrameCount;
				break;
			case RetriggerLimMode.TimeBased:
				eventGrp.triggeredLastTime = AudioUtil.Time;
				break;
			}
			if (!MasterAudio.AppIsShuttingDown && MasterAudio.IsWarming)
			{
				AudioEvent aEvent = new AudioEvent();
				PerformSingleAction(eventGrp, aEvent, eType);
				return true;
			}
			for (int i = 0; i < eventGrp.SoundEvents.Count; i++)
			{
				PerformSingleAction(eventGrp, eventGrp.SoundEvents[i], eType);
			}
			return true;
		}

		private void OnDrawGizmos()
		{
			if (!(MasterAudio.SafeInstance == null) && MasterAudio.Instance.showRangeSoundGizmos && eventToGizmo != null && eventToGizmo.colliderMaxDistance != 0f)
			{
				Color color = Color.green;
				if (MasterAudio.SafeInstance != null)
				{
					color = MasterAudio.Instance.rangeGizmoColor;
				}
				Gizmos.color = color;
				Gizmos.DrawWireSphere(base.transform.position, eventToGizmo.colliderMaxDistance);
			}
		}

		private void OnDrawGizmosSelected()
		{
			if (!(MasterAudio.SafeInstance == null) && MasterAudio.Instance.showSelectedRangeSoundGizmos && eventToGizmo != null && eventToGizmo.colliderMaxDistance != 0f)
			{
				Color color = Color.green;
				if (MasterAudio.SafeInstance != null)
				{
					color = MasterAudio.Instance.selectedRangeGizmoColor;
				}
				Gizmos.color = color;
				Gizmos.DrawWireSphere(base.transform.position, eventToGizmo.colliderMaxDistance);
			}
		}

		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			switch (grp.retriggerLimitMode)
			{
			case RetriggerLimMode.FrameBased:
				if (grp.triggeredLastFrame > 0 && AudioUtil.FrameCount - grp.triggeredLastFrame < grp.limitPerXFrm)
				{
					return false;
				}
				break;
			case RetriggerLimMode.TimeBased:
				if (grp.triggeredLastTime > 0f && AudioUtil.Time - grp.triggeredLastTime < grp.limitPerXSec)
				{
					return false;
				}
				break;
			}
			return true;
		}

		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
			if (disableSounds || MasterAudio.AppIsShuttingDown || MasterAudio.SafeInstance == null)
			{
				return;
			}
			bool flag = eType == EventType.UnitySliderChanged && aEvent.targetVolMode == AudioEvent.TargetVolumeMode.UseSliderValue;
			float volumePercentage = aEvent.volume;
			string soundType = aEvent.soundType;
			float? pitch = aEvent.pitch;
			if (!aEvent.useFixedPitch)
			{
				pitch = null;
			}
			PlaySoundResult playSoundResult = null;
			MasterAudio.SoundSpawnLocationMode soundSpawnLocationMode = soundSpawnMode;
			if (eType == EventType.OnDisable || eType == EventType.OnDespawned)
			{
				soundSpawnLocationMode = MasterAudio.SoundSpawnLocationMode.CallerLocation;
			}
			bool flag2 = eType == EventType.OnMouseDrag || aEvent.glidePitchType != GlidePitchType.None;
			switch (aEvent.currentSoundFunctionType)
			{
			case MasterAudio.EventSoundFunctionType.PlaySound:
			{
				string variationName = null;
				if (aEvent.variationType == VariationType.PlaySpecific)
				{
					variationName = aEvent.variationName;
				}
				if (flag)
				{
					volumePercentage = grp.sliderValue;
				}
				switch (soundSpawnLocationMode)
				{
				case MasterAudio.SoundSpawnLocationMode.CallerLocation:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound3DAtTransform(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound3DFollowTransform(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
					if (flag2)
					{
						playSoundResult = MasterAudio.PlaySound(soundType, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					else
					{
						MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound, variationName);
					}
					break;
				}
				if (playSoundResult != null && playSoundResult.ActingVariation != null && aEvent.glidePitchType != 0)
				{
					switch (aEvent.glidePitchType)
					{
					case GlidePitchType.RaisePitch:
						playSoundResult.ActingVariation.GlideByPitch(aEvent.targetGlidePitch, aEvent.pitchGlideTime);
						break;
					case GlidePitchType.LowerPitch:
						playSoundResult.ActingVariation.GlideByPitch(0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.PlaylistControl:
				playSoundResult = new PlaySoundResult
				{
					ActingVariation = null,
					SoundPlayed = true,
					SoundScheduled = false
				};
				if (string.IsNullOrEmpty(aEvent.playlistControllerName))
				{
					aEvent.playlistControllerName = "~only~";
				}
				switch (aEvent.currentPlaylistCommand)
				{
				case MasterAudio.PlaylistCommand.None:
					playSoundResult.SoundPlayed = false;
					break;
				case MasterAudio.PlaylistCommand.Restart:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.RestartAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.RestartPlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Start:
					if (!(aEvent.playlistControllerName == "[None]") && !(aEvent.playlistName == "[None]"))
					{
						MasterAudio.StartPlaylist(aEvent.playlistControllerName, aEvent.playlistName);
					}
					break;
				case MasterAudio.PlaylistCommand.ChangePlaylist:
					if (string.IsNullOrEmpty(aEvent.playlistName))
					{
						UnityEngine.Debug.Log("You have not specified a Playlist name for Event Sounds on '" + _trans.name + "'.");
						playSoundResult.SoundPlayed = false;
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.ChangePlaylistByName(aEvent.playlistControllerName, aEvent.playlistName, aEvent.startPlaylist);
					}
					break;
				case MasterAudio.PlaylistCommand.StopLoopingCurrentSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopLoopingAllCurrentSongs();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopLoopingCurrentSong(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.StopPlaylistAfterCurrentSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopAllPlaylistsAfterCurrentSongs();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopPlaylistAfterCurrentSong(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.FadeToVolume:
				{
					float targetVolume = (flag ? grp.sliderValue : aEvent.fadeVolume);
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.FadeAllPlaylistsToVolume(targetVolume, aEvent.fadeTime);
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.FadePlaylistToVolume(aEvent.playlistControllerName, targetVolume, aEvent.fadeTime);
					}
					break;
				}
				case MasterAudio.PlaylistCommand.Mute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.MuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.MutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Unmute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.UnmuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.UnmutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.ToggleMute:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.ToggleMuteAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.ToggleMutePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.PlaySong:
					if (string.IsNullOrEmpty(aEvent.clipName))
					{
						UnityEngine.Debug.Log("You have not specified a song name for Event Sounds on '" + _trans.name + "'.");
						playSoundResult.SoundPlayed = false;
					}
					else if (!(aEvent.playlistControllerName == "[None]") && !MasterAudio.TriggerPlaylistClip(aEvent.playlistControllerName, aEvent.clipName))
					{
						playSoundResult.SoundPlayed = false;
					}
					break;
				case MasterAudio.PlaylistCommand.AddSongToQueue:
					playSoundResult.SoundPlayed = false;
					if (string.IsNullOrEmpty(aEvent.clipName))
					{
						UnityEngine.Debug.Log("You have not specified a song name for Event Sounds on '" + _trans.name + "'.");
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.QueuePlaylistClip(aEvent.playlistControllerName, aEvent.clipName);
						playSoundResult.SoundPlayed = true;
					}
					break;
				case MasterAudio.PlaylistCommand.PlayRandomSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.TriggerRandomClipAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.TriggerRandomPlaylistClip(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.PlayNextSong:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.TriggerNextClipAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.TriggerNextPlaylistClip(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Pause:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.PauseAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.PausePlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Stop:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.StopAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.StopPlaylist(aEvent.playlistControllerName);
					}
					break;
				case MasterAudio.PlaylistCommand.Resume:
					if (aEvent.allPlaylistControllersForGroupCmd)
					{
						MasterAudio.UnpauseAllPlaylists();
					}
					else if (!(aEvent.playlistControllerName == "[None]"))
					{
						MasterAudio.UnpausePlaylist(aEvent.playlistControllerName);
					}
					break;
				}
				break;
			case MasterAudio.EventSoundFunctionType.GroupControl:
			{
				playSoundResult = new PlaySoundResult
				{
					ActingVariation = null,
					SoundPlayed = true,
					SoundScheduled = false
				};
				List<string> list5 = new List<string>();
				if (!aEvent.allSoundTypesForGroupCmd || MasterAudio.GroupCommandsWithNoAllGroupSelector.Contains(aEvent.currentSoundGroupCommand))
				{
					list5.Add(aEvent.soundType);
				}
				else
				{
					list5.AddRange(MasterAudio.RuntimeSoundGroupNames);
				}
				for (int l = 0; l < list5.Count; l++)
				{
					string sType = list5[l];
					switch (aEvent.currentSoundGroupCommand)
					{
					case MasterAudio.SoundGroupCommand.None:
						playSoundResult.SoundPlayed = false;
						break;
					case MasterAudio.SoundGroupCommand.ToggleSoundGroup:
						if (MasterAudio.IsSoundGroupPlaying(sType))
						{
							MasterAudio.FadeOutAllOfSound(sType, aEvent.fadeTime);
							break;
						}
						switch (soundSpawnLocationMode)
						{
						case MasterAudio.SoundSpawnLocationMode.CallerLocation:
							MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
							MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
							MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound);
							break;
						}
						break;
					case MasterAudio.SoundGroupCommand.ToggleSoundGroupOfTransform:
						if (MasterAudio.IsTransformPlayingSoundGroup(sType, _trans))
						{
							MasterAudio.FadeOutSoundGroupOfTransform(_trans, sType, aEvent.fadeTime);
							break;
						}
						switch (soundSpawnLocationMode)
						{
						case MasterAudio.SoundSpawnLocationMode.CallerLocation:
							MasterAudio.PlaySound3DAtTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
							MasterAudio.PlaySound3DFollowTransformAndForget(soundType, _trans, volumePercentage, pitch, aEvent.delaySound);
							break;
						case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
							MasterAudio.PlaySoundAndForget(soundType, volumePercentage, pitch, aEvent.delaySound);
							break;
						}
						break;
					case MasterAudio.SoundGroupCommand.RefillSoundGroupPool:
						MasterAudio.RefillSoundGroupPool(sType);
						break;
					case MasterAudio.SoundGroupCommand.FadeToVolume:
					{
						float newVolume = (flag ? grp.sliderValue : aEvent.fadeVolume);
						MasterAudio.FadeSoundGroupToVolume(sType, newVolume, aEvent.fadeTime, null, aEvent.stopAfterFade, aEvent.restoreVolumeAfterFade);
						break;
					}
					case MasterAudio.SoundGroupCommand.FadeOutAllOfSound:
						MasterAudio.FadeOutAllOfSound(sType, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.Mute:
						MasterAudio.MuteGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Pause:
						MasterAudio.PauseSoundGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Solo:
						MasterAudio.SoloGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.StopAllOfSound:
						MasterAudio.StopAllOfSound(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unmute:
						MasterAudio.UnmuteGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unpause:
						MasterAudio.UnpauseSoundGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.Unsolo:
						MasterAudio.UnsoloGroup(sType);
						break;
					case MasterAudio.SoundGroupCommand.StopAllSoundsOfTransform:
						MasterAudio.StopAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.StopSoundGroupOfTransform:
						MasterAudio.StopSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.PauseAllSoundsOfTransform:
						MasterAudio.PauseAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.PauseSoundGroupOfTransform:
						MasterAudio.PauseSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.UnpauseAllSoundsOfTransform:
						MasterAudio.UnpauseAllSoundsOfTransform(_trans);
						break;
					case MasterAudio.SoundGroupCommand.UnpauseSoundGroupOfTransform:
						MasterAudio.UnpauseSoundGroupOfTransform(_trans, sType);
						break;
					case MasterAudio.SoundGroupCommand.FadeOutSoundGroupOfTransform:
						MasterAudio.FadeOutSoundGroupOfTransform(_trans, sType, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.FadeOutAllSoundsOfTransform:
						MasterAudio.FadeOutAllSoundsOfTransform(_trans, aEvent.fadeTime);
						break;
					case MasterAudio.SoundGroupCommand.RouteToBus:
					{
						string text = aEvent.busName;
						if (text == "[None]")
						{
							text = null;
						}
						MasterAudio.RouteGroupToBus(sType, text);
						break;
					}
					case MasterAudio.SoundGroupCommand.GlideByPitch:
						switch (aEvent.glidePitchType)
						{
						case GlidePitchType.RaisePitch:
							MasterAudio.GlideSoundGroupByPitch(sType, aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						case GlidePitchType.LowerPitch:
							MasterAudio.GlideSoundGroupByPitch(sType, 0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						}
						break;
					case MasterAudio.SoundGroupCommand.StopOldSoundGroupVoices:
						MasterAudio.StopOldSoundGroupVoices(sType, aEvent.minAge);
						break;
					case MasterAudio.SoundGroupCommand.FadeOutOldSoundGroupVoices:
						MasterAudio.FadeOutOldSoundGroupVoices(sType, aEvent.minAge, aEvent.fadeTime);
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.BusControl:
			{
				playSoundResult = new PlaySoundResult
				{
					ActingVariation = null,
					SoundPlayed = true,
					SoundScheduled = false
				};
				List<string> list6 = new List<string>();
				if (!aEvent.allSoundTypesForBusCmd)
				{
					list6.Add(aEvent.busName);
				}
				else
				{
					list6.AddRange(MasterAudio.RuntimeBusNames);
				}
				for (int m = 0; m < list6.Count; m++)
				{
					string busName2 = list6[m];
					switch (aEvent.currentBusCommand)
					{
					case MasterAudio.BusCommand.None:
						playSoundResult.SoundPlayed = false;
						break;
					case MasterAudio.BusCommand.FadeToVolume:
					{
						float newVolume2 = (flag ? grp.sliderValue : aEvent.fadeVolume);
						MasterAudio.FadeBusToVolume(busName2, newVolume2, aEvent.fadeTime, null, aEvent.stopAfterFade, aEvent.restoreVolumeAfterFade);
						break;
					}
					case MasterAudio.BusCommand.GlideByPitch:
						switch (aEvent.glidePitchType)
						{
						case GlidePitchType.RaisePitch:
							MasterAudio.GlideBusByPitch(busName2, aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						case GlidePitchType.LowerPitch:
							MasterAudio.GlideBusByPitch(busName2, 0f - aEvent.targetGlidePitch, aEvent.pitchGlideTime);
							break;
						}
						break;
					case MasterAudio.BusCommand.Pause:
						MasterAudio.PauseBus(busName2);
						break;
					case MasterAudio.BusCommand.Stop:
						MasterAudio.StopBus(busName2);
						break;
					case MasterAudio.BusCommand.Unpause:
						MasterAudio.UnpauseBus(busName2);
						break;
					case MasterAudio.BusCommand.Mute:
						MasterAudio.MuteBus(busName2);
						break;
					case MasterAudio.BusCommand.Unmute:
						MasterAudio.UnmuteBus(busName2);
						break;
					case MasterAudio.BusCommand.ToggleMute:
						MasterAudio.ToggleMuteBus(busName2);
						break;
					case MasterAudio.BusCommand.Solo:
						MasterAudio.SoloBus(busName2);
						break;
					case MasterAudio.BusCommand.Unsolo:
						MasterAudio.UnsoloBus(busName2);
						break;
					case MasterAudio.BusCommand.ChangePitch:
						MasterAudio.ChangeBusPitch(busName2, aEvent.pitch);
						break;
					case MasterAudio.BusCommand.PauseBusOfTransform:
						MasterAudio.PauseBusOfTransform(_trans, aEvent.busName);
						break;
					case MasterAudio.BusCommand.UnpauseBusOfTransform:
						MasterAudio.UnpauseBusOfTransform(_trans, aEvent.busName);
						break;
					case MasterAudio.BusCommand.StopBusOfTransform:
						MasterAudio.StopBusOfTransform(_trans, aEvent.busName);
						break;
					case MasterAudio.BusCommand.StopOldBusVoices:
						MasterAudio.StopOldBusVoices(busName2, aEvent.minAge);
						break;
					case MasterAudio.BusCommand.FadeOutOldBusVoices:
						MasterAudio.FadeOutOldBusVoices(busName2, aEvent.minAge, aEvent.fadeTime);
						break;
					}
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.CustomEventControl:
			{
				if (eType == EventType.UserDefinedEvent)
				{
					UnityEngine.Debug.LogError("Custom Event Receivers cannot fire events. Occured in Transform '" + base.name + "'.");
					break;
				}
				MasterAudio.CustomEventCommand currentCustomEventCommand = aEvent.currentCustomEventCommand;
				if (currentCustomEventCommand == MasterAudio.CustomEventCommand.FireEvent)
				{
					MasterAudio.FireCustomEvent(aEvent.theCustomEventName, _trans);
				}
				break;
			}
			case MasterAudio.EventSoundFunctionType.GlobalControl:
				switch (aEvent.currentGlobalCommand)
				{
				case MasterAudio.GlobalCommand.SetMasterMixerVolume:
					MasterAudio.MasterVolumeLevel = (flag ? grp.sliderValue : aEvent.volume);
					break;
				case MasterAudio.GlobalCommand.SetMasterPlaylistVolume:
					MasterAudio.PlaylistMasterVolume = (flag ? grp.sliderValue : aEvent.volume);
					break;
				case MasterAudio.GlobalCommand.PauseMixer:
					MasterAudio.PauseMixer();
					break;
				case MasterAudio.GlobalCommand.UnpauseMixer:
					MasterAudio.UnpauseMixer();
					break;
				case MasterAudio.GlobalCommand.StopMixer:
					MasterAudio.StopMixer();
					break;
				case MasterAudio.GlobalCommand.MuteEverything:
					MasterAudio.MuteEverything();
					break;
				case MasterAudio.GlobalCommand.UnmuteEverything:
					MasterAudio.UnmuteEverything();
					break;
				case MasterAudio.GlobalCommand.PauseEverything:
					MasterAudio.PauseEverything();
					break;
				case MasterAudio.GlobalCommand.UnpauseEverything:
					MasterAudio.UnpauseEverything();
					break;
				case MasterAudio.GlobalCommand.StopEverything:
					MasterAudio.StopEverything();
					break;
				}
				break;
			case MasterAudio.EventSoundFunctionType.UnityMixerControl:
				switch (aEvent.currentMixerCommand)
				{
				case MasterAudio.UnityMixerCommand.TransitionToSnapshot:
				{
					AudioMixerSnapshot snapshotToTransitionTo = aEvent.snapshotToTransitionTo;
					if (snapshotToTransitionTo != null)
					{
						snapshotToTransitionTo.audioMixer.TransitionToSnapshots(new AudioMixerSnapshot[1] { snapshotToTransitionTo }, new float[1] { 1f }, aEvent.snapshotTransitionTime);
					}
					break;
				}
				case MasterAudio.UnityMixerCommand.TransitionToSnapshotBlend:
				{
					List<AudioMixerSnapshot> list3 = new List<AudioMixerSnapshot>();
					List<float> list4 = new List<float>();
					AudioMixer audioMixer = null;
					for (int k = 0; k < aEvent.snapshotsToBlend.Count; k++)
					{
						AudioEvent.MA_SnapshotInfo mA_SnapshotInfo = aEvent.snapshotsToBlend[k];
						if (!(mA_SnapshotInfo.snapshot == null))
						{
							if (audioMixer == null)
							{
								audioMixer = mA_SnapshotInfo.snapshot.audioMixer;
							}
							else if (audioMixer != mA_SnapshotInfo.snapshot.audioMixer)
							{
								UnityEngine.Debug.LogError("Snapshot '" + mA_SnapshotInfo.snapshot.name + "' isn't in the same Audio Mixer as the previous snapshot in EventSounds on GameObject '" + base.name + "'. Please make sure all the Snapshots to blend are on the same mixer.");
								break;
							}
							list3.Add(mA_SnapshotInfo.snapshot);
							list4.Add(mA_SnapshotInfo.weight);
						}
					}
					if (list3.Count > 0)
					{
						UnityEngine.Debug.Log("trans");
						audioMixer.TransitionToSnapshots(list3.ToArray(), list4.ToArray(), aEvent.snapshotTransitionTime);
					}
					break;
				}
				}
				break;
			case MasterAudio.EventSoundFunctionType.PersistentSettingsControl:
				switch (aEvent.currentPersistentSettingsCommand)
				{
				case MasterAudio.PersistentSettingsCommand.SetBusVolume:
				{
					List<string> list2 = new List<string>();
					if (!aEvent.allSoundTypesForBusCmd)
					{
						list2.Add(aEvent.busName);
					}
					else
					{
						list2.AddRange(MasterAudio.RuntimeBusNames);
					}
					for (int j = 0; j < list2.Count; j++)
					{
						string busName = list2[j];
						float vol2 = (flag ? grp.sliderValue : aEvent.volume);
						PersistentAudioSettings.SetBusVolume(busName, vol2);
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetGroupVolume:
				{
					List<string> list = new List<string>();
					if (!aEvent.allSoundTypesForGroupCmd)
					{
						list.Add(aEvent.soundType);
					}
					else
					{
						list.AddRange(MasterAudio.RuntimeSoundGroupNames);
					}
					for (int i = 0; i < list.Count; i++)
					{
						string grpName = list[i];
						float vol = (flag ? grp.sliderValue : aEvent.volume);
						PersistentAudioSettings.SetGroupVolume(grpName, vol);
					}
					break;
				}
				case MasterAudio.PersistentSettingsCommand.SetMixerVolume:
					PersistentAudioSettings.MixerVolume = (flag ? grp.sliderValue : aEvent.volume);
					break;
				case MasterAudio.PersistentSettingsCommand.SetMusicVolume:
					PersistentAudioSettings.MusicVolume = (flag ? grp.sliderValue : aEvent.volume);
					break;
				case MasterAudio.PersistentSettingsCommand.MixerMuteToggle:
					if (PersistentAudioSettings.MixerMuted.HasValue)
					{
						PersistentAudioSettings.MixerMuted = !PersistentAudioSettings.MixerMuted.Value;
					}
					else
					{
						PersistentAudioSettings.MixerMuted = true;
					}
					break;
				case MasterAudio.PersistentSettingsCommand.MusicMuteToggle:
					if (PersistentAudioSettings.MusicMuted.HasValue)
					{
						PersistentAudioSettings.MusicMuted = !PersistentAudioSettings.MusicMuted.Value;
					}
					else
					{
						PersistentAudioSettings.MusicMuted = true;
					}
					break;
				}
				break;
			}
		}

		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
			if (!logMissingEvents || (eventGroup.isCustomEvent && (!eventGroup.customSoundActive || string.IsNullOrEmpty(eventGroup.customEventName))))
			{
				return;
			}
			for (int i = 0; i < eventGroup.SoundEvents.Count; i++)
			{
				AudioEvent audioEvent = eventGroup.SoundEvents[i];
				if (audioEvent.currentSoundFunctionType == MasterAudio.EventSoundFunctionType.CustomEventControl)
				{
					string theCustomEventName = audioEvent.theCustomEventName;
					if (!MasterAudio.CustomEventExists(theCustomEventName))
					{
						MasterAudio.LogWarning("Transform '" + base.name + "' is set up to receive or fire Custom Event '" + theCustomEventName + "', which does not exist in Master Audio.");
					}
				}
			}
		}

		public void CheckForIllegalCustomEvents()
		{
			if (useStartSound)
			{
				LogIfCustomEventMissing(startSound);
			}
			if (useVisibleSound)
			{
				LogIfCustomEventMissing(visibleSound);
			}
			if (useInvisibleSound)
			{
				LogIfCustomEventMissing(invisibleSound);
			}
			if (useCollisionSound)
			{
				LogIfCustomEventMissing(collisionSound);
			}
			if (useCollisionExitSound)
			{
				LogIfCustomEventMissing(collisionExitSound);
			}
			if (useTriggerEnterSound)
			{
				LogIfCustomEventMissing(triggerSound);
			}
			if (useTriggerExitSound)
			{
				LogIfCustomEventMissing(triggerExitSound);
			}
			if (useMouseEnterSound)
			{
				LogIfCustomEventMissing(mouseEnterSound);
			}
			if (useMouseExitSound)
			{
				LogIfCustomEventMissing(mouseExitSound);
			}
			if (useMouseClickSound)
			{
				LogIfCustomEventMissing(mouseClickSound);
			}
			if (useMouseDragSound)
			{
				LogIfCustomEventMissing(mouseDragSound);
			}
			if (useMouseUpSound)
			{
				LogIfCustomEventMissing(mouseUpSound);
			}
			if (useNguiMouseDownSound)
			{
				LogIfCustomEventMissing(nguiMouseDownSound);
			}
			if (useNguiMouseUpSound)
			{
				LogIfCustomEventMissing(nguiMouseUpSound);
			}
			if (useNguiOnClickSound)
			{
				LogIfCustomEventMissing(nguiOnClickSound);
			}
			if (useNguiMouseEnterSound)
			{
				LogIfCustomEventMissing(nguiMouseEnterSound);
			}
			if (useNguiMouseExitSound)
			{
				LogIfCustomEventMissing(nguiMouseExitSound);
			}
			if (useSpawnedSound)
			{
				LogIfCustomEventMissing(spawnedSound);
			}
			if (useDespawnedSound)
			{
				LogIfCustomEventMissing(despawnedSound);
			}
			if (useEnableSound)
			{
				LogIfCustomEventMissing(enableSound);
			}
			if (useDisableSound)
			{
				LogIfCustomEventMissing(disableSound);
			}
			if (useCollision2dSound)
			{
				LogIfCustomEventMissing(collision2dSound);
			}
			if (useCollisionExit2dSound)
			{
				LogIfCustomEventMissing(collisionExit2dSound);
			}
			if (useTriggerEnter2dSound)
			{
				LogIfCustomEventMissing(triggerEnter2dSound);
			}
			if (useTriggerExit2dSound)
			{
				LogIfCustomEventMissing(triggerExit2dSound);
			}
			if (useParticleCollisionSound)
			{
				LogIfCustomEventMissing(particleCollisionSound);
			}
			if (useUnitySliderChangedSound)
			{
				LogIfCustomEventMissing(unitySliderChangedSound);
			}
			if (useUnityButtonClickedSound)
			{
				LogIfCustomEventMissing(unityButtonClickedSound);
			}
			if (useUnityPointerDownSound)
			{
				LogIfCustomEventMissing(unityPointerDownSound);
			}
			if (useUnityDragSound)
			{
				LogIfCustomEventMissing(unityDragSound);
			}
			if (useUnityDropSound)
			{
				LogIfCustomEventMissing(unityDropSound);
			}
			if (useUnityPointerUpSound)
			{
				LogIfCustomEventMissing(unityPointerUpSound);
			}
			if (useUnityPointerEnterSound)
			{
				LogIfCustomEventMissing(unityPointerEnterSound);
			}
			if (useUnityPointerExitSound)
			{
				LogIfCustomEventMissing(unityPointerExitSound);
			}
			if (useUnityScrollSound)
			{
				LogIfCustomEventMissing(unityScrollSound);
			}
			if (useUnityUpdateSelectedSound)
			{
				LogIfCustomEventMissing(unityUpdateSelectedSound);
			}
			if (useUnitySelectSound)
			{
				LogIfCustomEventMissing(unitySelectSound);
			}
			if (useUnityDeselectSound)
			{
				LogIfCustomEventMissing(unityDeselectSound);
			}
			if (useUnityMoveSound)
			{
				LogIfCustomEventMissing(unityMoveSound);
			}
			if (useUnityInitializePotentialDragSound)
			{
				LogIfCustomEventMissing(unityInitializePotentialDragSound);
			}
			if (useUnityBeginDragSound)
			{
				LogIfCustomEventMissing(unityBeginDragSound);
			}
			if (useUnityEndDragSound)
			{
				LogIfCustomEventMissing(unityEndDragSound);
			}
			if (useUnitySubmitSound)
			{
				LogIfCustomEventMissing(unitySubmitSound);
			}
			if (useUnityCancelSound)
			{
				LogIfCustomEventMissing(unityCancelSound);
			}
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup eventGroup = userDefinedSounds[i];
				LogIfCustomEventMissing(eventGroup);
			}
		}

		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = userDefinedSounds[i];
				if (audioEventGroup.customSoundActive && !string.IsNullOrEmpty(audioEventGroup.customEventName) && audioEventGroup.customEventName.Equals(customEventName))
				{
					PlaySounds(audioEventGroup, EventType.UserDefinedEvent);
				}
			}
		}

		public bool SubscribesToEvent(string customEventName)
		{
			for (int i = 0; i < userDefinedSounds.Count; i++)
			{
				AudioEventGroup audioEventGroup = userDefinedSounds[i];
				if (audioEventGroup.customSoundActive && !string.IsNullOrEmpty(audioEventGroup.customEventName) && audioEventGroup.customEventName.Equals(customEventName))
				{
					return true;
				}
			}
			return false;
		}

		public void RegisterReceiver()
		{
			if (userDefinedSounds.Count > 0)
			{
				MasterAudio.AddCustomEventReceiver(this, _trans);
			}
		}

		public void UnregisterReceiver()
		{
			if (userDefinedSounds.Count > 0)
			{
				MasterAudio.RemoveCustomEventReceiver(this);
			}
		}

		public IList<AudioEventGroup> GetAllEvents()
		{
			return userDefinedSounds.AsReadOnly();
		}

		private void AddUGUIComponents()
		{
			AddUGUIHandler<EventSoundsPointerEnterHandler>(useUnityPointerEnterSound);
			AddUGUIHandler<EventSoundsPointerExitHandler>(useUnityPointerExitSound);
			AddUGUIHandler<EventSoundsPointerDownHandler>(useUnityPointerDownSound);
			AddUGUIHandler<EventSoundsPointerUpHandler>(useUnityPointerUpSound);
			AddUGUIHandler<EventSoundsDragHandler>(useUnityDragSound);
			AddUGUIHandler<EventSoundsDropHandler>(useUnityDropSound);
			AddUGUIHandler<EventSoundsScrollHandler>(useUnityScrollSound);
			AddUGUIHandler<EventSoundsUpdateSelectedHandler>(useUnityUpdateSelectedSound);
			AddUGUIHandler<EventSoundsSelectHandler>(useUnitySelectSound);
			AddUGUIHandler<EventSoundsDeselectHandler>(useUnityDeselectSound);
			AddUGUIHandler<EventSoundsMoveHandler>(useUnityMoveSound);
			AddUGUIHandler<EventSoundsInitializePotentialDragHandler>(useUnityInitializePotentialDragSound);
			AddUGUIHandler<EventSoundsBeginDragHandler>(useUnityBeginDragSound);
			AddUGUIHandler<EventSoundsEndDragHandler>(useUnityEndDragSound);
			AddUGUIHandler<EventSoundsSubmitHandler>(useUnitySubmitSound);
			AddUGUIHandler<EventSoundsCancelHandler>(useUnityCancelSound);
		}

		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
			if (useSound)
			{
				base.gameObject.AddComponent<T>().eventSounds = this;
			}
		}
	}
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		public EventSounds eventSounds { get; set; }
	}
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		public void OnPointerEnter(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerEnter(data);
			}
		}
	}
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		public void OnPointerExit(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerExit(data);
			}
		}
	}
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		public void OnPointerDown(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerDown(data);
			}
		}
	}
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		public void OnPointerUp(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnPointerUp(data);
			}
		}
	}
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		public void OnDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDrag(data);
			}
		}
	}
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		public void OnDrop(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDrop(data);
			}
		}
	}
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		public void OnScroll(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnScroll(data);
			}
		}
	}
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		public void OnUpdateSelected(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnUpdateSelected(data);
			}
		}
	}
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		public void OnSelect(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnSelect(data);
			}
		}
	}
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		public void OnDeselect(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnDeselect(data);
			}
		}
	}
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		public void OnMove(AxisEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnMove(data);
			}
		}
	}
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		public void OnInitializePotentialDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnInitializePotentialDrag(data);
			}
		}
	}
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		public void OnBeginDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnBeginDrag(data);
			}
		}
	}
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		public void OnEndDrag(PointerEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnEndDrag(data);
			}
		}
	}
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		public void OnSubmit(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnSubmit(data);
			}
		}
	}
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		public void OnCancel(BaseEventData data)
		{
			if (base.eventSounds != null)
			{
				base.eventSounds.OnCancel(data);
			}
		}
	}
	[AddComponentMenu("Dark Tonic/Master Audio/Footstep Sounds")]
	public class FootstepSounds : MonoBehaviour
	{
		public enum FootstepTriggerMode
		{
			None,
			OnCollision,
			OnTriggerEnter,
			OnCollision2D,
			OnTriggerEnter2D
		}

		public MasterAudio.SoundSpawnLocationMode soundSpawnMode = MasterAudio.SoundSpawnLocationMode.AttachToCaller;

		public FootstepTriggerMode footstepEvent;

		public List<FootstepGroup> footstepGroups = new List<FootstepGroup>();

		public EventSounds.RetriggerLimMode retriggerLimitMode;

		public int limitPerXFrm;

		public float limitPerXSec;

		public int triggeredLastFrame = -100;

		public float triggeredLastTime = -100f;

		private Transform _trans;

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		private void OnTriggerEnter(Collider other)
		{
			if (footstepEvent == FootstepTriggerMode.OnTriggerEnter)
			{
				PlaySoundsIfMatch(other.gameObject);
			}
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (footstepEvent == FootstepTriggerMode.OnCollision)
			{
				PlaySoundsIfMatch(collision.gameObject);
			}
		}

		private bool CheckForRetriggerLimit()
		{
			switch (retriggerLimitMode)
			{
			case EventSounds.RetriggerLimMode.FrameBased:
				if (triggeredLastFrame > 0 && AudioUtil.FrameCount - triggeredLastFrame < limitPerXFrm)
				{
					return false;
				}
				break;
			case EventSounds.RetriggerLimMode.TimeBased:
				if (triggeredLastTime > 0f && AudioUtil.Time - triggeredLastTime < limitPerXSec)
				{
					return false;
				}
				break;
			}
			return true;
		}

		private void PlaySoundsIfMatch(GameObject go)
		{
			if (!CheckForRetriggerLimit())
			{
				return;
			}
			switch (retriggerLimitMode)
			{
			case EventSounds.RetriggerLimMode.FrameBased:
				triggeredLastFrame = AudioUtil.FrameCount;
				break;
			case EventSounds.RetriggerLimMode.TimeBased:
				triggeredLastTime = AudioUtil.Time;
				break;
			}
			for (int i = 0; i < footstepGroups.Count; i++)
			{
				FootstepGroup footstepGroup = footstepGroups[i];
				if ((!footstepGroup.useLayerFilter || footstepGroup.matchingLayers.Contains(go.layer)) && (!footstepGroup.useTagFilter || footstepGroup.matchingTags.Contains(go.tag)))
				{
					float volume = footstepGroup.volume;
					float? pitch = footstepGroup.pitch;
					if (!footstepGroup.useFixedPitch)
					{
						pitch = null;
					}
					string variationName = null;
					if (footstepGroup.variationType == EventSounds.VariationType.PlaySpecific)
					{
						variationName = footstepGroup.variationName;
					}
					switch (soundSpawnMode)
					{
					case MasterAudio.SoundSpawnLocationMode.CallerLocation:
						MasterAudio.PlaySound3DAtTransform(footstepGroup.soundType, Trans, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					case MasterAudio.SoundSpawnLocationMode.AttachToCaller:
						MasterAudio.PlaySound3DFollowTransform(footstepGroup.soundType, Trans, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					case MasterAudio.SoundSpawnLocationMode.MasterAudioLocation:
						MasterAudio.PlaySound(footstepGroup.soundType, volume, pitch, footstepGroup.delaySound, variationName);
						break;
					}
				}
			}
		}
	}
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Tooltip("Select for event to re-fire each time animation loops without exiting state")]
		[Header("Retrigger Events Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Tooltip("Fire A Custom Event When State Is Entered")]
		[Header("Enter Custom Event")]
		public bool fireEnterEvent;

		[MasterCustomEvent]
		public string enterCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event when state is Exited")]
		[Header("Exit Custom Event")]
		public bool fireExitEvent;

		[MasterCustomEvent]
		public string exitCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.")]
		[Header("Fire Custom EventTimed to Animation")]
		public bool fireAnimTimeEvent;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireEvent;

		[MasterCustomEvent]
		public string timedCustomEvent = "[None]";

		[Tooltip("Fire a Custom Event with timed to the animation.  This allows you to time your Custom Events to the actions in you animation. Select the number of Custom Events to be fired, up to 4. Then set the time you want each Custom Event to fire with each subsequent time greater than the previous time.")]
		[Header("Fire Multiple Custom Events Timed to Anim")]
		public bool fireMultiAnimTimeEvent;

		[Range(0f, 4f)]
		public int numOfMultiEventsToFire;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent1;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent2;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent3;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToFireMultiEvent4;

		[MasterCustomEvent]
		public string MultiTimedEvent = "[None]";

		private bool _playMultiEvent1 = true;

		private bool _playMultiEvent2 = true;

		private bool _playMultiEvent3 = true;

		private bool _playMultiEvent4 = true;

		private bool _fireTimedEvent = true;

		private Transform _actorTrans;

		private int _lastRepetition = -1;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			_lastRepetition = 0;
			_actorTrans = ActorTrans(animator);
			if (fireEnterEvent && !(enterCustomEvent == "[None]") && !string.IsNullOrEmpty(enterCustomEvent))
			{
				MasterAudio.FireCustomEvent(enterCustomEvent, _actorTrans);
			}
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			int num = (int)stateInfo.normalizedTime;
			float num2 = stateInfo.normalizedTime - (float)num;
			if (fireAnimTimeEvent)
			{
				if (!_fireTimedEvent && RetriggerWhenStateLoops && _lastRepetition >= 0 && num > _lastRepetition)
				{
					_fireTimedEvent = true;
				}
				if (_fireTimedEvent && num2 > whenToFireEvent)
				{
					_fireTimedEvent = false;
					MasterAudio.FireCustomEvent(timedCustomEvent, _actorTrans);
				}
			}
			if (fireMultiAnimTimeEvent)
			{
				if (RetriggerWhenStateLoops)
				{
					if (!_playMultiEvent1 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent1 = true;
					}
					if (!_playMultiEvent2 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent2 = true;
					}
					if (!_playMultiEvent3 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent3 = true;
					}
					if (!_playMultiEvent4 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						_playMultiEvent4 = true;
					}
				}
				if (_playMultiEvent1 && !(num2 < whenToFireMultiEvent1) && numOfMultiEventsToFire >= 1)
				{
					_playMultiEvent1 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent2 && !(num2 < whenToFireMultiEvent2) && numOfMultiEventsToFire >= 2)
				{
					_playMultiEvent2 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent3 && !(num2 < whenToFireMultiEvent3) && numOfMultiEventsToFire >= 3)
				{
					_playMultiEvent3 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
				if (_playMultiEvent4 && !(num2 < whenToFireMultiEvent4) && numOfMultiEventsToFire >= 4)
				{
					_playMultiEvent4 = false;
					MasterAudio.FireCustomEvent(MultiTimedEvent, _actorTrans);
				}
			}
			_lastRepetition = num;
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if (fireExitEvent && exitCustomEvent != "[None]" && !string.IsNullOrEmpty(exitCustomEvent))
			{
				MasterAudio.FireCustomEvent(exitCustomEvent, _actorTrans);
			}
			if (fireMultiAnimTimeEvent)
			{
				_playMultiEvent1 = true;
				_playMultiEvent2 = true;
				_playMultiEvent3 = true;
				_playMultiEvent4 = true;
			}
			if (fireAnimTimeEvent)
			{
				_fireTimedEvent = true;
			}
		}

		private Transform ActorTrans(Animator anim)
		{
			if (_actorTrans != null)
			{
				return _actorTrans;
			}
			_actorTrans = anim.transform;
			return _actorTrans;
		}
	}
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Header("Select For Sounds To Follow Object")]
		public bool SoundFollowsObject;

		[Tooltip("Select for sounds to retrigger each time animation loops without exiting state")]
		[Header("Retrigger Sounds Each Time Anim Loops w/o Exiting State")]
		public bool RetriggerWhenStateLoops;

		[Tooltip("Play a Sound Group when state is Entered")]
		[Header("Enter Sound Group")]
		public bool playEnterSound;

		public bool stopEnterSoundOnExit;

		[SoundGroup]
		public string enterSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string enterVariationName;

		private bool wasEnterSoundPlayed;

		[Tooltip("Play a Sound Group when state is Exited")]
		[Header("Exit Sound Group")]
		public bool playExitSound;

		[SoundGroup]
		public string exitSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string exitVariationName;

		[Tooltip("Play a Sound Group (Normal or Looped Chain Variation Mode) timed to the animation state's normalized time.  Normalized time is simply the length in time of the animation.  Time is represented as a float from 0f - 1f.  0f is the beginning, .5f is the middle, 1f is the end...etc.etc.  Select a Start time from 0 - 1.  Select a stop time greater than the start time or leave stop time equals to zero and select Stop Anim Time Sound On Exit.  This can be used for Looped Chain Sound Groups since you have to define a stop time.")]
		[Header("Play Sound Group Timed to Animation")]
		public bool playAnimTimeSound;

		public bool stopAnimTimeSoundOnExit;

		[Tooltip("If selected, When To Stop Sound (below) will be used. Otherwise the sound will not be stopped unless you have Stop Anim Time Sound On Exit selected above.")]
		public bool useStopTime;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartSound;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStopSound;

		[SoundGroup]
		public string TimedSoundGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string timedVariationName;

		private bool playSoundStart = true;

		private bool playSoundStop = true;

		[Tooltip("Play a Sound Group with each variation timed to the animation.  This allows you to time your sounds to the actions in you animation.  Example: A sword swing combo where you want swoosh soundsor character grunts timed to the acceleration phase of the sword swing.  Select the number of sounds to be played, up to 4.  Then set the time you want each sound to start with each subsequent time greater than the previous time.")]
		[Header("Play Multiple Sounds Timed to Anim")]
		public bool playMultiAnimTimeSounds;

		public bool StopMultiAnimTimeSoundsOnExit;

		[Range(0f, 4f)]
		public int numOfMultiSoundsToPlay;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound1;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound2;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound3;

		[Tooltip("This value will be compared to the normalizedTime of the animation you are playing. NormalizedTime is represented as a float so 0 is the beginning, 1 is the end and .5f would be the middle etc.")]
		[Range(0f, 1f)]
		public float whenToStartMultiSound4;

		[SoundGroup]
		public string MultiSoundsTimedGroup = "[None]";

		[Tooltip("Random Variation plays if blank, otherwise name a Variation from the above Sound Group to play.")]
		public string multiTimedVariationName;

		private bool playMultiSound1 = true;

		private bool playMultiSound2 = true;

		private bool playMultiSound3 = true;

		private bool playMultiSound4 = true;

		private Transform _actorTrans;

		private int _lastRepetition = -1;

		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			_lastRepetition = 0;
			_actorTrans = ActorTrans(animator);
			if (!playEnterSound)
			{
				return;
			}
			string variationName = GetVariationName(enterVariationName);
			if (SoundFollowsObject)
			{
				if (variationName == null)
				{
					MasterAudio.PlaySound3DFollowTransformAndForget(enterSoundGroup, _actorTrans);
				}
				else
				{
					MasterAudio.PlaySound3DFollowTransformAndForget(enterSoundGroup, _actorTrans, 1f, null, 0f, variationName);
				}
			}
			else if (variationName == null)
			{
				MasterAudio.PlaySound3DAtTransformAndForget(enterSoundGroup, _actorTrans);
			}
			else
			{
				MasterAudio.PlaySound3DAtTransformAndForget(enterSoundGroup, _actorTrans, 1f, null, 0f, variationName);
			}
			wasEnterSoundPlayed = true;
		}

		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			int num = (int)stateInfo.normalizedTime;
			float num2 = stateInfo.normalizedTime - (float)num;
			if (playAnimTimeSound)
			{
				if (!playSoundStart && RetriggerWhenStateLoops && _lastRepetition >= 0 && num > _lastRepetition)
				{
					playSoundStart = true;
				}
				if (playSoundStart && num2 > whenToStartSound)
				{
					playSoundStart = false;
					if (useStopTime && whenToStopSound < whenToStartSound)
					{
						UnityEngine.Debug.LogError("Stop time must be greater than start time when Use Stop Time is selected.");
					}
					else
					{
						string variationName = GetVariationName(timedVariationName);
						if (SoundFollowsObject)
						{
							if (variationName == null)
							{
								MasterAudio.PlaySound3DFollowTransformAndForget(TimedSoundGroup, _actorTrans);
							}
							else
							{
								MasterAudio.PlaySound3DFollowTransformAndForget(TimedSoundGroup, _actorTrans, 1f, null, 0f, variationName);
							}
						}
						else if (variationName == null)
						{
							MasterAudio.PlaySound3DAtTransformAndForget(TimedSoundGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DAtTransformAndForget(TimedSoundGroup, _actorTrans, 1f, null, 0f, variationName);
						}
					}
				}
				if (useStopTime && playSoundStop && num2 > whenToStartSound && !stopAnimTimeSoundOnExit && num2 > whenToStopSound)
				{
					playSoundStop = false;
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, TimedSoundGroup);
				}
			}
			if (playMultiAnimTimeSounds)
			{
				if (RetriggerWhenStateLoops)
				{
					if (!playMultiSound1 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound1 = true;
					}
					if (!playMultiSound2 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound2 = true;
					}
					if (!playMultiSound3 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound3 = true;
					}
					if (!playMultiSound4 && _lastRepetition >= 0 && num > _lastRepetition)
					{
						playMultiSound4 = true;
					}
				}
				string variationName2 = GetVariationName(multiTimedVariationName);
				if (playMultiSound1 && num2 > whenToStartMultiSound1 && numOfMultiSoundsToPlay >= 1)
				{
					playMultiSound1 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound2 && num2 > whenToStartMultiSound2 && numOfMultiSoundsToPlay >= 2)
				{
					playMultiSound2 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound3 && num2 > whenToStartMultiSound3 && numOfMultiSoundsToPlay >= 3)
				{
					playMultiSound3 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
				if (playMultiSound4 && num2 > whenToStartMultiSound4 && numOfMultiSoundsToPlay >= 4)
				{
					playMultiSound4 = false;
					if (SoundFollowsObject)
					{
						if (variationName2 == null)
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
						}
						else
						{
							MasterAudio.PlaySound3DFollowTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
						}
					}
					else if (variationName2 == null)
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DAtTransformAndForget(MultiSoundsTimedGroup, _actorTrans, 1f, null, 0f, variationName2);
					}
				}
			}
			_lastRepetition = num;
		}

		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
			if (wasEnterSoundPlayed && stopEnterSoundOnExit)
			{
				MasterAudio.StopSoundGroupOfTransform(_actorTrans, enterSoundGroup);
			}
			wasEnterSoundPlayed = false;
			if (playExitSound)
			{
				string variationName = GetVariationName(exitVariationName);
				if (SoundFollowsObject)
				{
					if (variationName == null)
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(exitSoundGroup, _actorTrans);
					}
					else
					{
						MasterAudio.PlaySound3DFollowTransformAndForget(exitSoundGroup, _actorTrans, 1f, null, 0f, variationName);
					}
				}
				else if (variationName == null)
				{
					MasterAudio.PlaySound3DAtTransformAndForget(exitSoundGroup, _actorTrans);
				}
				else
				{
					MasterAudio.PlaySound3DAtTransformAndForget(exitSoundGroup, _actorTrans, 1f, null, 0f, variationName);
				}
			}
			if (playAnimTimeSound)
			{
				if (stopAnimTimeSoundOnExit)
				{
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, TimedSoundGroup);
				}
				playSoundStart = true;
				playSoundStop = true;
			}
			if (playMultiAnimTimeSounds)
			{
				if (StopMultiAnimTimeSoundsOnExit)
				{
					MasterAudio.StopSoundGroupOfTransform(_actorTrans, MultiSoundsTimedGroup);
				}
				playMultiSound1 = true;
				playMultiSound2 = true;
				playMultiSound3 = true;
				playMultiSound4 = true;
			}
		}

		private Transform ActorTrans(Animator anim)
		{
			if (_actorTrans != null)
			{
				return _actorTrans;
			}
			_actorTrans = anim.transform;
			return _actorTrans;
		}

		private static string GetVariationName(string varName)
		{
			if (string.IsNullOrEmpty(varName))
			{
				return null;
			}
			varName = varName.Trim();
			if (string.IsNullOrEmpty(varName))
			{
				return null;
			}
			return varName;
		}
	}
	[SerializeField]
	public class PlaySoundResult
	{
		public bool SoundPlayed { get; set; }

		public bool SoundScheduled { get; set; }

		public SoundGroupVariation ActingVariation { get; set; }

		public PlaySoundResult()
		{
			SoundPlayed = false;
			SoundScheduled = false;
			ActingVariation = null;
		}
	}
	[Serializable]
	public class AmbientSoundToTriggerInfo
	{
		public int frameToTrigger;

		public AmbientSound ambient;
	}
	[Serializable]
	public class AudioEvent
	{
		public enum TargetVolumeMode
		{
			UseSliderValue,
			UseSpecificValue
		}

		[Serializable]
		public class MA_SnapshotInfo
		{
			public AudioMixerSnapshot snapshot;

			public float weight;

			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
				snapshot = snap;
				weight = wt;
			}
		}

		public string actionName = "Your action name";

		public bool isExpanded = true;

		public string soundType = "[None]";

		public bool allPlaylistControllersForGroupCmd;

		public bool allSoundTypesForGroupCmd;

		public bool allSoundTypesForBusCmd;

		public float volume = 1f;

		public bool useFixedPitch;

		public float pitch = 1f;

		public EventSounds.GlidePitchType glidePitchType;

		public float targetGlidePitch = 1f;

		public float pitchGlideTime = 1f;

		public float delaySound;

		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		public MasterAudio.BusCommand currentBusCommand;

		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		public MasterAudio.GlobalCommand currentGlobalCommand;

		public MasterAudio.UnityMixerCommand currentMixerCommand;

		public AudioMixerSnapshot snapshotToTransitionTo;

		public float snapshotTransitionTime = 1f;

		public List<MA_SnapshotInfo> snapshotsToBlend = new List<MA_SnapshotInfo>
		{
			new MA_SnapshotInfo(null, 1f)
		};

		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		public string busName = string.Empty;

		public string playlistName = string.Empty;

		public string playlistControllerName = string.Empty;

		public bool startPlaylist = true;

		public float fadeVolume;

		public float fadeTime = 1f;

		public float minAge = 1f;

		public bool stopAfterFade;

		public bool restoreVolumeAfterFade;

		public TargetVolumeMode targetVolMode;

		public string clipName = "[None]";

		public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;

		public string variationName = string.Empty;

		public float colliderMaxDistance;

		public bool showSphereGizmo;

		public string theCustomEventName = string.Empty;

		public bool IsFadeCommand
		{
			get
			{
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.PlaylistControl && currentPlaylistCommand == MasterAudio.PlaylistCommand.FadeToVolume)
				{
					return true;
				}
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.BusControl && currentBusCommand == MasterAudio.BusCommand.FadeToVolume)
				{
					return true;
				}
				if (currentSoundFunctionType == MasterAudio.EventSoundFunctionType.GroupControl && (currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeToVolume || currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeOutAllOfSound || currentSoundGroupCommand == MasterAudio.SoundGroupCommand.FadeOutSoundGroupOfTransform))
				{
					return true;
				}
				return false;
			}
		}
	}
	[Serializable]
	public class AudioEventGroup
	{
		public bool isExpanded = true;

		public bool allPlayersShouldHear;

		public bool useLayerFilter;

		public bool useTagFilter;

		public List<int> matchingLayers = new List<int> { 0 };

		public List<string> matchingTags = new List<string> { "Default" };

		public bool customSoundActive;

		public bool isCustomEvent;

		public string customEventName = string.Empty;

		public bool mechanimEventActive;

		public bool isMechanimStateCheckEvent;

		public string mechanimStateName = string.Empty;

		public bool mechEventPlayedForState;

		public List<AudioEvent> SoundEvents = new List<AudioEvent>();

		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		public float mouseDragFadeOutTime = 1f;

		public EventSounds.RetriggerLimMode retriggerLimitMode;

		public int limitPerXFrm;

		public float limitPerXSec;

		public int triggeredLastFrame = -100;

		public float triggeredLastTime = -100f;

		public float triggerStayForTime;

		public bool doesTriggerStayRepeat = true;

		public float sliderValue;
	}
	public class AudioScriptOrder : Attribute
	{
		public int Order;

		public AudioScriptOrder(int order)
		{
			Order = order;
		}
	}
	[Serializable]
	public class BusFadeInfo
	{
		public string NameOfBus;

		public GroupBus ActingBus;

		public float StartVolume;

		public float TargetVolume;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;

		public bool WillStopGroupAfterFade;

		public bool WillResetVolumeAfterFade;

		public Action completionAction;
	}
	[Serializable]
	public class BusPitchGlideInfo
	{
		public string NameOfBus;

		public float CompletionTime;

		public bool IsActive = true;

		public List<SoundGroupVariation> GlidingVariations;

		public Action completionAction;
	}
	[Serializable]
	public class CustomEvent
	{
		public string EventName;

		public string ProspectiveName;

		public bool IsEditing;

		public bool eventExpanded = true;

		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		public float distanceThreshold = 1f;

		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		public int filterModeQty = 1;

		public bool isTemporary;

		public int frameLastFired = -1;

		public string categoryName = "[Uncategorized]";

		public CustomEvent(string eventName)
		{
			EventName = eventName;
			ProspectiveName = eventName;
		}
	}
	[Serializable]
	public class CustomEventCategory
	{
		public string CatName = "[Uncategorized]";

		public bool IsExpanded = true;

		public bool IsEditing;

		public bool IsTemporary;

		public string ProspectiveName = "[Uncategorized]";
	}
	[Serializable]
	public class CustomEventToFireInfo
	{
		public string eventName;

		public Transform eventOrigin;
	}
	[Serializable]
	public class DuckGroupInfo
	{
		public string soundType = "[None]";

		public float riseVolStart = 0.5f;

		public float unduckTime = 1f;

		public float duckedVolumeCut = -6f;

		public bool isTemporary;
	}
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Range(0f, 1f)]
		public int probabilityToPlay = 100;

		public bool useLocalization;

		public bool useRandomPitch;

		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public int weight = 1;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public bool isExpanded = true;

		public bool isChecked = true;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useCustomLooping;

		public int minCustomLoops = 1;

		public int maxCustomLoops = 5;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent = 100f;

		public float randomEndPercent = 100f;

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private DynamicSoundGroup _parentGroupScript;

		private Transform _trans;

		private AudioSource _aud;

		public AudioDistortionFilter DistortionFilter
		{
			get
			{
				if (_distFilter != null)
				{
					return _distFilter;
				}
				_distFilter = GetComponent<AudioDistortionFilter>();
				return _distFilter;
			}
		}

		public AudioReverbFilter ReverbFilter
		{
			get
			{
				if (_reverbFilter != null)
				{
					return _reverbFilter;
				}
				_reverbFilter = GetComponent<AudioReverbFilter>();
				return _reverbFilter;
			}
		}

		public AudioChorusFilter ChorusFilter
		{
			get
			{
				if (_chorusFilter != null)
				{
					return _chorusFilter;
				}
				_chorusFilter = GetComponent<AudioChorusFilter>();
				return _chorusFilter;
			}
		}

		public AudioEchoFilter EchoFilter
		{
			get
			{
				if (_echoFilter != null)
				{
					return _echoFilter;
				}
				_echoFilter = GetComponent<AudioEchoFilter>();
				return _echoFilter;
			}
		}

		public AudioLowPassFilter LowPassFilter
		{
			get
			{
				if (_lpFilter != null)
				{
					return _lpFilter;
				}
				_lpFilter = GetComponent<AudioLowPassFilter>();
				return _lpFilter;
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				if (_hpFilter != null)
				{
					return _hpFilter;
				}
				_hpFilter = GetComponent<AudioHighPassFilter>();
				return _hpFilter;
			}
		}

		public DynamicSoundGroup ParentGroup
		{
			get
			{
				if (_parentGroupScript == null)
				{
					_parentGroupScript = Trans.parent.GetComponent<DynamicSoundGroup>();
				}
				if (_parentGroupScript == null)
				{
					UnityEngine.Debug.LogError("The Group that Dynamic Sound Variation '" + base.name + "' is in does not have a DynamicSoundGroup script in it!");
				}
				return _parentGroupScript;
			}
		}

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				if (HighPassFilter != null && HighPassFilter.enabled)
				{
					return true;
				}
				if (LowPassFilter != null && LowPassFilter.enabled)
				{
					return true;
				}
				if (ReverbFilter != null && ReverbFilter.enabled)
				{
					return true;
				}
				if (DistortionFilter != null && DistortionFilter.enabled)
				{
					return true;
				}
				if (EchoFilter != null && EchoFilter.enabled)
				{
					return true;
				}
				if (ChorusFilter != null && ChorusFilter.enabled)
				{
					return true;
				}
				return false;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				if (_aud != null)
				{
					return _aud;
				}
				_aud = GetComponent<AudioSource>();
				return _aud;
			}
		}
	}
	public class DynamicSoundGroup : MonoBehaviour
	{
		public GameObject variationTemplate;

		public bool alwaysHighestPriority;

		public float groupMasterVolume = 1f;

		public int retriggerPercentage = 50;

		public MasterAudioGroup.VariationSequence curVariationSequence;

		public bool useNoRepeatRefill = true;

		public bool useInactivePeriodPoolRefill;

		public float inactivePeriodSeconds = 5f;

		public MasterAudioGroup.VariationMode curVariationMode;

		public MasterAudio.AudioLocation bulkVariationMode;

		public float chainLoopDelayMin;

		public float chainLoopDelayMax;

		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		public int chainLoopNumLoops;

		public bool useDialogFadeOut;

		public float dialogFadeOutTime = 0.5f;

		public string comments;

		public bool logSound;

		public bool soundPlayedEventActive;

		public string soundPlayedCustomEvent = string.Empty;

		public int busIndex = -1;

		public MasterAudio.ItemSpatialBlendType spatialBlendType = MasterAudio.ItemSpatialBlendType.ForceTo3D;

		public float spatialBlend = 1f;

		public string busName = string.Empty;

		public bool isExistingBus;

		public bool isCopiedFromDGSC;

		public MasterAudioGroup.LimitMode limitMode;

		public int limitPerXFrames = 1;

		public float minimumTimeBetween = 0.1f;

		public bool limitPolyphony;

		public int voiceLimitCount = 1;

		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior = MasterAudioGroup.TargetDespawnedBehavior.FadeOut;

		public float despawnFadeTime = 0.3f;

		public bool isUsingOcclusion;

		public bool willOcclusionOverrideRaycastOffset;

		public float occlusionRayCastOffset;

		public bool willOcclusionOverrideFrequencies;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public bool copySettingsExpanded;

		public bool expandLinkedGroups;

		public List<string> childSoundGroups = new List<string>();

		public List<string> endLinkedGroups = new List<string>();

		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		public List<DynamicGroupVariation> groupVariations = new List<DynamicGroupVariation>();
	}
	[Serializable]
	public class FootstepGroup
	{
		public bool isExpanded = true;

		public bool useLayerFilter;

		public bool useTagFilter;

		public List<int> matchingLayers = new List<int> { 0 };

		public List<string> matchingTags = new List<string> { "Default" };

		public string soundType = "[None]";

		public EventSounds.VariationType variationType = EventSounds.VariationType.PlayRandom;

		public string variationName = string.Empty;

		public float volume = 1f;

		public bool useFixedPitch;

		public float pitch = 1f;

		public float delaySound;
	}
	[Serializable]
	public class GroupBus
	{
		public string busName;

		public float volume = 1f;

		public bool isSoloed;

		public bool isMuted;

		public int voiceLimit = -1;

		public bool stopOldest;

		public bool isExisting;

		public bool isTemporary;

		public bool isUsingOcclusion;

		public Color busColor = Color.white;

		public AudioMixerGroup mixerChannel;

		public bool forceTo2D;

		private readonly List<int> _activeAudioSourcesIds = new List<int>(50);

		private float _originalVolume = 1f;

		public int ActiveVoices => _activeAudioSourcesIds.Count;

		public bool BusVoiceLimitReached
		{
			get
			{
				if (voiceLimit <= 0)
				{
					return false;
				}
				return _activeAudioSourcesIds.Count >= voiceLimit;
			}
		}

		public float OriginalVolume
		{
			get
			{
				return _originalVolume;
			}
			set
			{
				_originalVolume = value;
			}
		}

		public void AddActiveAudioSourceId(int id)
		{
			if (!_activeAudioSourcesIds.Contains(id))
			{
				_activeAudioSourcesIds.Add(id);
			}
		}

		public void RemoveActiveAudioSourceId(int id)
		{
			_activeAudioSourcesIds.Remove(id);
		}
	}
	[Serializable]
	public class GroupFadeInfo
	{
		public MasterAudioGroup ActingGroup;

		public string NameOfGroup;

		public float StartVolume;

		public float TargetVolume;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;

		public bool WillStopGroupAfterFade;

		public bool WillResetVolumeAfterFade;

		public Action completionAction;
	}
	[Serializable]
	public class GroupPitchGlideInfo
	{
		public MasterAudioGroup ActingGroup;

		public string NameOfGroup;

		public float CompletionTime;

		public bool IsActive = true;

		public List<SoundGroupVariation> GlidingVariations;

		public Action completionAction;
	}
	public interface ICustomEventReceiver
	{
		void CheckForIllegalCustomEvents();

		void ReceiveEvent(string customEventName, Vector3 originPoint);

		bool SubscribesToEvent(string customEventName);

		void RegisterReceiver();

		void UnregisterReceiver();

		IList<AudioEventGroup> GetAllEvents();
	}
	public class MasterAudioGroup : MonoBehaviour
	{
		public enum TargetDespawnedBehavior
		{
			None,
			Stop,
			FadeOut
		}

		public enum VariationSequence
		{
			Randomized,
			TopToBottom
		}

		public enum VariationMode
		{
			Normal,
			LoopedChain,
			Dialog
		}

		public enum ChainedLoopLoopMode
		{
			Endless,
			NumberOfLoops
		}

		public enum LimitMode
		{
			None,
			FrameBased,
			TimeBased
		}

		public const float UseCurveSpatialBlend = -99f;

		public const string NoBus = "[NO BUS]";

		public const int MinNoRepeatVariations = 3;

		public int busIndex = -1;

		public MasterAudio.ItemSpatialBlendType spatialBlendType = MasterAudio.ItemSpatialBlendType.ForceTo3D;

		public float spatialBlend = 1f;

		public bool isSelected;

		public bool isExpanded = true;

		public float groupMasterVolume = 1f;

		public int retriggerPercentage = 100;

		public VariationMode curVariationMode;

		public bool alwaysHighestPriority;

		public float chainLoopDelayMin;

		public float chainLoopDelayMax;

		public ChainedLoopLoopMode chainLoopMode;

		public int chainLoopNumLoops;

		public bool useDialogFadeOut;

		public float dialogFadeOutTime = 0.5f;

		public VariationSequence curVariationSequence;

		public bool useNoRepeatRefill = true;

		public bool useInactivePeriodPoolRefill;

		public float inactivePeriodSeconds = 5f;

		public List<SoundGroupVariation> groupVariations = new List<SoundGroupVariation>();

		public MasterAudio.AudioLocation bulkVariationMode;

		public string comments;

		public bool logSound;

		public bool copySettingsExpanded;

		public bool expandLinkedGroups;

		public List<string> childSoundGroups = new List<string>();

		public List<string> endLinkedGroups = new List<string>();

		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		public LimitMode limitMode;

		public int limitPerXFrames = 1;

		public float minimumTimeBetween = 0.1f;

		public bool useClipAgePriority;

		public bool limitPolyphony;

		public int voiceLimitCount = 1;

		public TargetDespawnedBehavior targetDespawnedBehavior = TargetDespawnedBehavior.FadeOut;

		public float despawnFadeTime = 0.3f;

		public bool isUsingOcclusion;

		public bool willOcclusionOverrideRaycastOffset;

		public float occlusionRayCastOffset;

		public bool willOcclusionOverrideFrequencies;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public bool isSoloed;

		public bool isMuted;

		public bool soundPlayedEventActive;

		public string soundPlayedCustomEvent = string.Empty;

		public bool willCleanUpDelegatesAfterStop = true;

		public int frames;

		private List<int> _activeAudioSourcesIds;

		private string _objectName = string.Empty;

		private Transform _trans;

		private float _originalVolume = 1f;

		public float SpatialBlendForGroup => MasterAudio.Instance.mixerSpatialBlendType switch
		{
			MasterAudio.AllMixerSpatialBlendType.ForceAllTo2D => 0f, 
			MasterAudio.AllMixerSpatialBlendType.ForceAllTo3D => 1f, 
			MasterAudio.AllMixerSpatialBlendType.ForceAllToCustom => MasterAudio.Instance.mixerSpatialBlend, 
			_ => spatialBlendType switch
			{
				MasterAudio.ItemSpatialBlendType.ForceTo2D => 0f, 
				MasterAudio.ItemSpatialBlendType.ForceTo3D => 1f, 
				MasterAudio.ItemSpatialBlendType.ForceToCustom => spatialBlend, 
				_ => -99f, 
			}, 
		};

		public int ActiveVoices => ActiveAudioSourceIds.Count;

		public int TotalVoices => base.transform.childCount;

		public bool WillCleanUpDelegatesAfterStop
		{
			set
			{
				willCleanUpDelegatesAfterStop = value;
			}
		}

		public GroupBus BusForGroup
		{
			get
			{
				if (busIndex < 2)
				{
					return null;
				}
				int num = busIndex - 2;
				if (num >= MasterAudio.GroupBuses.Count)
				{
					return null;
				}
				return MasterAudio.GroupBuses[num];
			}
		}

		public float OriginalVolume
		{
			get
			{
				return _originalVolume;
			}
			set
			{
				_originalVolume = value;
			}
		}

		public bool LoggingEnabledForGroup
		{
			get
			{
				if (!logSound)
				{
					return MasterAudio.LogSoundsEnabled;
				}
				return true;
			}
		}

		public int ChainLoopCount { get; set; }

		public string GameObjectName
		{
			get
			{
				if (string.IsNullOrEmpty(_objectName))
				{
					_objectName = base.name;
				}
				return _objectName;
			}
		}

		public bool UsesNoRepeat
		{
			get
			{
				if (curVariationSequence == VariationSequence.Randomized && groupVariations.Count >= 3)
				{
					return useNoRepeatRefill;
				}
				return false;
			}
		}

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		private List<int> ActiveAudioSourceIds
		{
			get
			{
				if (_activeAudioSourcesIds != null)
				{
					return _activeAudioSourcesIds;
				}
				_activeAudioSourcesIds = new List<int>(Trans.childCount);
				return _activeAudioSourcesIds;
			}
		}

		public event Action LastVariationFinishedPlay;

		private void Start()
		{
			_objectName = base.name;
			_ = ActiveAudioSourceIds.Count;
			_ = 0;
			if (Trans.parent != null)
			{
				base.gameObject.layer = Trans.parent.gameObject.layer;
			}
		}

		public void AddActiveAudioSourceId(int varInstanceId)
		{
			if (!ActiveAudioSourceIds.Contains(varInstanceId))
			{
				ActiveAudioSourceIds.Add(varInstanceId);
				BusForGroup?.AddActiveAudioSourceId(varInstanceId);
			}
		}

		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
			ActiveAudioSourceIds.Remove(varInstanceId);
			BusForGroup?.RemoveActiveAudioSourceId(varInstanceId);
		}

		public void FireLastVariationFinishedPlay()
		{
			if (this.LastVariationFinishedPlay != null)
			{
				this.LastVariationFinishedPlay();
			}
		}

		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
			this.LastVariationFinishedPlay = null;
			LastVariationFinishedPlay += finishedCallback;
		}

		public void UnsubscribeFromLastVariationFinishedPlay()
		{
			this.LastVariationFinishedPlay = null;
		}
	}
	public class MasterCustomEventAttribute : PropertyAttribute
	{
	}
	[Serializable]
	public class MusicSetting
	{
		public string alias = string.Empty;

		public MasterAudio.AudioLocation audLocation;

		public AudioClip clip;

		public string songName = string.Empty;

		public string resourceFileName = string.Empty;

		public float volume = 1f;

		public float pitch = 1f;

		public bool isExpanded = true;

		public bool isLoop;

		public bool isChecked = true;

		public List<SongMetadataStringValue> metadataStringValues = new List<SongMetadataStringValue>();

		public List<SongMetadataBoolValue> metadataBoolValues = new List<SongMetadataBoolValue>();

		public List<SongMetadataIntValue> metadataIntValues = new List<SongMetadataIntValue>();

		public List<SongMetadataFloatValue> metadataFloatValues = new List<SongMetadataFloatValue>();

		public bool metadataExpanded = true;

		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		public float customStartTime;

		public float customStartTimeMax;

		public int lastKnownTimePoint;

		public bool wasLastKnownTimePointSet;

		public int songIndex;

		public bool songStartedEventExpanded;

		public string songStartedCustomEvent = string.Empty;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent = string.Empty;

		public bool HasMetadataProperties => MetadataPropertyCount > 0;

		public int MetadataPropertyCount => metadataStringValues.Count + metadataBoolValues.Count + metadataIntValues.Count + metadataFloatValues.Count;

		public float SongStartTime => songStartTimeMode switch
		{
			MasterAudio.CustomSongStartTimeMode.SpecificTime => customStartTime, 
			MasterAudio.CustomSongStartTimeMode.RandomTime => UnityEngine.Random.Range(customStartTime, customStartTimeMax), 
			_ => 0f, 
		};

		public MusicSetting()
		{
			songChangedEventExpanded = false;
		}

		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			MusicSetting musicSetting = new MusicSetting
			{
				alias = mus.alias,
				audLocation = mus.audLocation,
				clip = mus.clip,
				songName = mus.songName,
				resourceFileName = mus.resourceFileName,
				volume = mus.volume,
				pitch = mus.pitch,
				isExpanded = mus.isExpanded,
				isLoop = mus.isLoop,
				isChecked = mus.isChecked,
				customStartTime = mus.customStartTime,
				songStartedEventExpanded = mus.songStartedEventExpanded,
				songStartedCustomEvent = mus.songStartedCustomEvent,
				songChangedEventExpanded = mus.songChangedEventExpanded,
				songChangedCustomEvent = mus.songChangedCustomEvent,
				metadataExpanded = mus.metadataExpanded
			};
			for (int i = 0; i < mus.metadataStringValues.Count; i++)
			{
				SongMetadataStringValue valToClone2 = mus.metadataStringValues[i];
				SongMetadataStringValue songMetadataStringValue = new SongMetadataStringValue(aList.songMetadataProps.Find((SongMetadataProperty p) => p.PropertyName == valToClone2.PropertyName));
				songMetadataStringValue.Value = valToClone2.Value;
				musicSetting.metadataStringValues.Add(songMetadataStringValue);
			}
			for (int j = 0; j < mus.metadataFloatValues.Count; j++)
			{
				SongMetadataFloatValue valToClone3 = mus.metadataFloatValues[j];
				SongMetadataFloatValue songMetadataFloatValue = new SongMetadataFloatValue(aList.songMetadataProps.Find((SongMetadataProperty p) => p.PropertyName == valToClone3.PropertyName));
				songMetadataFloatValue.Value = valToClone3.Value;
				musicSetting.metadataFloatValues.Add(songMetadataFloatValue);
			}
			for (int k = 0; k < mus.metadataBoolValues.Count; k++)
			{
				SongMetadataBoolValue valToClone4 = mus.metadataBoolValues[k];
				SongMetadataBoolValue songMetadataBoolValue = new SongMetadataBoolValue(aList.songMetadataProps.Find((SongMetadataProperty p) => p.PropertyName == valToClone4.PropertyName));
				songMetadataBoolValue.Value = valToClone4.Value;
				musicSetting.metadataBoolValues.Add(songMetadataBoolValue);
			}
			for (int l = 0; l < mus.metadataIntValues.Count; l++)
			{
				SongMetadataIntValue valToClone = mus.metadataIntValues[l];
				SongMetadataIntValue songMetadataIntValue = new SongMetadataIntValue(aList.songMetadataProps.Find((SongMetadataProperty p) => p.PropertyName == valToClone.PropertyName));
				songMetadataIntValue.Value = valToClone.Value;
				musicSetting.metadataIntValues.Add(songMetadataIntValue);
			}
			return musicSetting;
		}
	}
	[Serializable]
	public class OcclusionFreqChangeInfo
	{
		public SoundGroupVariation ActingVariation;

		public float StartFrequency;

		public float TargetFrequency;

		public float StartTime;

		public float CompletionTime;

		public bool IsActive = true;
	}
	public class PlaylistAttribute : PropertyAttribute
	{
	}
	[Serializable]
	public class SongMetadataBoolValue
	{
		public string PropertyName;

		public bool Value;

		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
			if (prop != null)
			{
				PropertyName = prop.PropertyName;
			}
		}
	}
	[Serializable]
	public class SongMetadataFloatValue
	{
		public string PropertyName;

		public float Value;

		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
			if (prop != null)
			{
				PropertyName = prop.PropertyName;
			}
		}
	}
	[Serializable]
	public class SongMetadataIntValue
	{
		public string PropertyName;

		public int Value;

		public SongMetadataIntValue(SongMetadataProperty prop)
		{
			if (prop != null)
			{
				PropertyName = prop.PropertyName;
			}
		}
	}
	[Serializable]
	public class SongMetadataProperty
	{
		public enum MetadataPropertyType
		{
			Boolean,
			String,
			Integer,
			Float
		}

		public MetadataPropertyType PropertyType;

		public string PropertyName;

		public string ProspectiveName;

		public bool IsEditing;

		public bool PropertyExpanded = true;

		public bool AllSongsMustContain = true;

		public bool CanSongHaveMultiple;

		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
			PropertyName = propertyName;
			ProspectiveName = propertyName;
			PropertyType = propertyType;
			AllSongsMustContain = allSongsMustContain;
			CanSongHaveMultiple = canSongHaveMultiple;
		}
	}
	[Serializable]
	public class SongMetadataStringValue
	{
		public string PropertyName;

		public string Value;

		public SongMetadataStringValue(SongMetadataProperty prop)
		{
			if (prop != null)
			{
				PropertyName = prop.PropertyName;
			}
		}
	}
	public class SoundGroupAttribute : PropertyAttribute
	{
	}
	[AudioScriptOrder(-40)]
	[RequireComponent(typeof(SoundGroupVariationUpdater))]
	public class SoundGroupVariation : MonoBehaviour
	{
		public delegate void SoundFinishedEventHandler();

		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		public class PlaySoundParams
		{
			public string SoundType;

			public float VolumePercentage;

			public float? Pitch;

			public double? TimeToSchedulePlay;

			public Transform SourceTrans;

			public bool AttachToSource;

			public float DelaySoundTime;

			public bool IsChainLoop;

			public bool IsSingleSubscribedPlay;

			public float GroupCalcVolume;

			public bool IsPlaying;

			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
				SoundType = soundType;
				VolumePercentage = volPercent;
				GroupCalcVolume = groupCalcVolume;
				Pitch = pitch;
				SourceTrans = sourceTrans;
				AttachToSource = attach;
				DelaySoundTime = delaySoundTime;
				TimeToSchedulePlay = timeToSchedulePlay;
				IsChainLoop = isChainLoop;
				IsSingleSubscribedPlay = isSingleSubscribedPlay;
				IsPlaying = false;
			}
		}

		public enum PitchMode
		{
			None,
			Gliding
		}

		public enum FadeMode
		{
			None,
			FadeInOut,
			FadeOutEarly,
			GradualFade
		}

		public enum RandomPitchMode
		{
			AddToClipPitch,
			IgnoreClipPitch
		}

		public enum RandomVolumeMode
		{
			AddToClipVolume,
			IgnoreClipVolume
		}

		public enum DetectEndMode
		{
			None,
			DetectEnd
		}

		public int weight = 1;

		[Range(0f, 1f)]
		public int probabilityToPlay = 100;

		public bool useLocalization;

		public bool useRandomPitch;

		public RandomPitchMode randomPitchMode;

		public float randomPitchMin;

		public float randomPitchMax;

		public bool useRandomVolume;

		public RandomVolumeMode randomVolumeMode;

		public float randomVolumeMin;

		public float randomVolumeMax;

		public MasterAudio.AudioLocation audLocation;

		public string resourceFileName;

		public float original_pitch;

		public float original_volume;

		public bool isExpanded = true;

		public bool isChecked = true;

		public bool useFades;

		public float fadeInTime;

		public float fadeOutTime;

		public bool useCustomLooping;

		public int minCustomLoops = 1;

		public int maxCustomLoops = 5;

		public bool useRandomStartTime;

		public float randomStartMinPercent;

		public float randomStartMaxPercent = 100f;

		public float randomEndPercent = 100f;

		public bool useIntroSilence;

		public float introSilenceMin;

		public float introSilenceMax;

		public float fadeMaxVolume;

		public FadeMode curFadeMode;

		public PitchMode curPitchMode;

		public DetectEndMode curDetectEndMode;

		public int frames;

		private AudioSource _audioSource;

		private readonly PlaySoundParams _playSndParam = new PlaySoundParams(string.Empty, 1f, 1f, 1f, null, attach: false, 0f, null, isChainLoop: false, isSingleSubscribedPlay: false);

		private AudioDistortionFilter _distFilter;

		private AudioEchoFilter _echoFilter;

		private AudioHighPassFilter _hpFilter;

		private AudioLowPassFilter _lpFilter;

		private AudioReverbFilter _reverbFilter;

		private AudioChorusFilter _chorusFilter;

		private float _maxVol = 1f;

		private int _instanceId = -1;

		private bool? _audioLoops;

		private int _maxLoops;

		private SoundGroupVariationUpdater _varUpdater;

		private int _previousSoundFinishedFrame = -1;

		private string _soundGroupName;

		private MasterAudio.VariationLoadStatus _loadStatus;

		private bool _isStopRequested;

		private bool _isPaused;

		private bool _isWarmingPlay;

		private Transform _trans;

		private GameObject _go;

		private Transform _objectToFollow;

		private Transform _objectToTriggerFrom;

		private MasterAudioGroup _parentGroupScript;

		private bool _attachToSource;

		private string _resFileName = string.Empty;

		private bool _hasStartedEndLinkedGroups;

		private Coroutine _loadResourceFileCoroutine;

		private Coroutine _loadAddressableCoroutine;

		private bool _isUnloadAddressableCoroutineRunning;

		public AudioDistortionFilter DistortionFilter
		{
			get
			{
				if (_distFilter != null)
				{
					return _distFilter;
				}
				_distFilter = GetComponent<AudioDistortionFilter>();
				return _distFilter;
			}
		}

		public AudioReverbFilter ReverbFilter
		{
			get
			{
				if (_reverbFilter != null)
				{
					return _reverbFilter;
				}
				_reverbFilter = GetComponent<AudioReverbFilter>();
				return _reverbFilter;
			}
		}

		public AudioChorusFilter ChorusFilter
		{
			get
			{
				if (_chorusFilter != null)
				{
					return _chorusFilter;
				}
				_chorusFilter = GetComponent<AudioChorusFilter>();
				return _chorusFilter;
			}
		}

		public AudioEchoFilter EchoFilter
		{
			get
			{
				if (_echoFilter != null)
				{
					return _echoFilter;
				}
				_echoFilter = GetComponent<AudioEchoFilter>();
				return _echoFilter;
			}
		}

		public AudioLowPassFilter LowPassFilter
		{
			get
			{
				return _lpFilter;
			}
			set
			{
				_lpFilter = value;
			}
		}

		public AudioHighPassFilter HighPassFilter
		{
			get
			{
				if (_hpFilter != null)
				{
					return _hpFilter;
				}
				_hpFilter = GetComponent<AudioHighPassFilter>();
				return _hpFilter;
			}
		}

		public Transform ObjectToFollow
		{
			get
			{
				return _objectToFollow;
			}
			set
			{
				_objectToFollow = value;
				UpdateTransformTracker(value);
			}
		}

		public Transform ObjectToTriggerFrom
		{
			get
			{
				return _objectToTriggerFrom;
			}
			set
			{
				_objectToTriggerFrom = value;
				UpdateTransformTracker(value);
			}
		}

		public bool HasActiveFXFilter
		{
			get
			{
				if (HighPassFilter != null && HighPassFilter.enabled)
				{
					return true;
				}
				if (LowPassFilter != null && LowPassFilter.enabled)
				{
					return true;
				}
				if (ReverbFilter != null && ReverbFilter.enabled)
				{
					return true;
				}
				if (DistortionFilter != null && DistortionFilter.enabled)
				{
					return true;
				}
				if (EchoFilter != null && EchoFilter.enabled)
				{
					return true;
				}
				if (ChorusFilter != null && ChorusFilter.enabled)
				{
					return true;
				}
				return false;
			}
		}

		public MasterAudioGroup ParentGroup
		{
			get
			{
				if (Trans.parent == null)
				{
					return null;
				}
				if (_parentGroupScript == null)
				{
					_parentGroupScript = Trans.parent.GetComponent<MasterAudioGroup>();
				}
				if (_parentGroupScript == null)
				{
					UnityEngine.Debug.LogError("The Group that Sound Variation '" + base.name + "' is in does not have a MasterAudioGroup script in it!");
				}
				return _parentGroupScript;
			}
		}

		public float OriginalPitch
		{
			get
			{
				if (original_pitch == 0f)
				{
					original_pitch = VarAudio.pitch;
				}
				return original_pitch;
			}
		}

		public float OriginalVolume
		{
			get
			{
				if (original_volume == 0f)
				{
					original_volume = VarAudio.volume;
				}
				return original_volume;
			}
		}

		public string SoundGroupName
		{
			get
			{
				if (_soundGroupName != null)
				{
					return _soundGroupName;
				}
				_soundGroupName = ParentGroup.GameObjectName;
				return _soundGroupName;
			}
		}

		public bool IsAvailableToPlay
		{
			get
			{
				if (weight == 0)
				{
					return false;
				}
				if (!_playSndParam.IsPlaying && VarAudio.time == 0f)
				{
					return true;
				}
				if (_loadStatus == MasterAudio.VariationLoadStatus.Loading)
				{
					return false;
				}
				return AudioUtil.GetAudioPlayedPercentage(VarAudio) >= (float)ParentGroup.retriggerPercentage;
			}
		}

		public float LastTimePlayed { get; set; }

		public bool ClipIsLoaded => _loadStatus == MasterAudio.VariationLoadStatus.Loaded;

		public bool IsPlaying => _playSndParam.IsPlaying;

		public MasterAudio.VariationLoadStatus LoadStatus
		{
			get
			{
				return _loadStatus;
			}
			set
			{
				if (_loadStatus != value)
				{
					_loadStatus = value;
				}
			}
		}

		public int InstanceId
		{
			get
			{
				if (_instanceId < 0)
				{
					_instanceId = GetInstanceID();
				}
				return _instanceId;
			}
		}

		public bool IsStopRequested => _isStopRequested;

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public GameObject GameObj
		{
			get
			{
				if (_go != null)
				{
					return _go;
				}
				_go = base.gameObject;
				return _go;
			}
		}

		public AudioSource VarAudio
		{
			get
			{
				if (_audioSource != null)
				{
					return _audioSource;
				}
				_audioSource = GetComponent<AudioSource>();
				return _audioSource;
			}
		}

		public bool AudioLoops
		{
			get
			{
				if (!_audioLoops.HasValue)
				{
					_audioLoops = VarAudio.loop;
				}
				return _audioLoops.Value;
			}
		}

		public string ResFileName
		{
			get
			{
				if (string.IsNullOrEmpty(_resFileName))
				{
					_resFileName = AudioResourceOptimizer.GetLocalizedFileName(useLocalization, resourceFileName);
				}
				return _resFileName;
			}
		}

		public SoundGroupVariationUpdater VariationUpdater
		{
			get
			{
				if (_varUpdater != null)
				{
					return _varUpdater;
				}
				_varUpdater = GetComponent<SoundGroupVariationUpdater>();
				return _varUpdater;
			}
		}

		public PlaySoundParams PlaySoundParm => _playSndParam;

		public float SetGroupVolume
		{
			get
			{
				return _playSndParam.GroupCalcVolume;
			}
			set
			{
				_playSndParam.GroupCalcVolume = value;
			}
		}

		public int MaxLoops => _maxLoops;

		private bool Is2D => VarAudio.spatialBlend <= 0f;

		public bool UsesOcclusion
		{
			get
			{
				if (!VariationUpdater.MAThisFrame.useOcclusion)
				{
					return false;
				}
				MasterAudio.RaycastMode occlusionRaycastMode = VariationUpdater.MAThisFrame.occlusionRaycastMode;
				if (occlusionRaycastMode != 0 && occlusionRaycastMode == MasterAudio.RaycastMode.Physics2D)
				{
					return false;
				}
				if (Is2D)
				{
					return false;
				}
				MasterAudio.OcclusionSelectionType occlusionSelectType = VariationUpdater.MAThisFrame.occlusionSelectType;
				if (occlusionSelectType == MasterAudio.OcclusionSelectionType.AllGroups || occlusionSelectType != MasterAudio.OcclusionSelectionType.TurnOnPerBusOrGroup)
				{
					return true;
				}
				if (ParentGroup.isUsingOcclusion)
				{
					return true;
				}
				GroupBus busForGroup = ParentGroup.BusForGroup;
				if (busForGroup != null && busForGroup.isUsingOcclusion)
				{
					return true;
				}
				return false;
			}
		}

		public bool IsPaused => _isPaused;

		public event SoundFinishedEventHandler SoundFinished;

		public event SoundLoopedEventHandler SoundLooped;

		private void Awake()
		{
			original_pitch = VarAudio.pitch;
			original_volume = VarAudio.volume;
			_audioLoops = VarAudio.loop;
			AudioClip clip = VarAudio.clip;
			GameObject gameObj = GameObj;
			if (!(clip != null) && !(gameObj != null))
			{
				_ = _isWarmingPlay;
			}
			if (VarAudio.playOnAwake)
			{
				UnityEngine.Debug.LogWarning("The 'Play on Awake' checkbox in the Variation named: '" + base.name + "' is checked. This is not used in Master Audio and can lead to buggy behavior. Make sure to uncheck it before hitting Play next time. To play ambient sounds, use an EventSounds component and activate the Start event to play a Sound Group of your choice.");
			}
		}

		private void Start()
		{
			if (ParentGroup == null)
			{
				UnityEngine.Debug.LogError("Sound Variation '" + base.name + "' has no parent!");
				return;
			}
			GameObj.layer = MasterAudio.Instance.gameObject.layer;
			bool flag = true;
			_ = audLocation;
			SetMixerGroup();
			SetSpatialBlend();
			SetPriority();
			SetOcclusion();
			SpatializerHelper.TurnOnSpatializerIfEnabled(VarAudio);
			if (flag)
			{
				DTMonoHelper.SetActive(GameObj, isActive: false);
			}
		}

		public void SetMixerGroup()
		{
			GroupBus busForGroup = ParentGroup.BusForGroup;
			if (busForGroup != null)
			{
				VarAudio.outputAudioMixerGroup = busForGroup.mixerChannel;
			}
			else
			{
				VarAudio.outputAudioMixerGroup = null;
			}
		}

		public void SetSpatialBlend()
		{
			float spatialBlendForGroup = ParentGroup.SpatialBlendForGroup;
			if (spatialBlendForGroup != -99f)
			{
				VarAudio.spatialBlend = spatialBlendForGroup;
			}
			GroupBus busForGroup = ParentGroup.BusForGroup;
			if (busForGroup != null && MasterAudio.Instance.mixerSpatialBlendType != 0 && busForGroup.forceTo2D)
			{
				VarAudio.spatialBlend = 0f;
			}
		}

		private void SetOcclusion()
		{
			VariationUpdater.UpdateCachedObjects();
			if (!UsesOcclusion)
			{
				return;
			}
			if (LowPassFilter == null)
			{
				_lpFilter = GetComponent<AudioLowPassFilter>();
				if (_lpFilter == null)
				{
					_lpFilter = base.gameObject.AddComponent<AudioLowPassFilter>();
				}
			}
			else
			{
				_lpFilter = GetComponent<AudioLowPassFilter>();
			}
			LowPassFilter.cutoffFrequency = AudioUtil.MinCutoffFreq(VariationUpdater);
		}

		private void SetPriority()
		{
			if (MasterAudio.Instance.prioritizeOnDistance)
			{
				if (ParentGroup.alwaysHighestPriority)
				{
					AudioPrioritizer.Set2DSoundPriority(VarAudio);
				}
				else
				{
					AudioPrioritizer.SetSoundGroupInitialPriority(VarAudio);
				}
			}
		}

		public void DisableUpdater()
		{
			if (!(VariationUpdater == null))
			{
				VariationUpdater.enabled = false;
			}
		}

		private void OnDestroy()
		{
			StopSoundEarly();
		}

		private void OnDisable()
		{
			StopSoundEarly();
		}

		private void StopSoundEarly()
		{
			if (!MasterAudio.AppIsShuttingDown)
			{
				Stop();
			}
		}

		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
			LoadStatus = MasterAudio.VariationLoadStatus.None;
			_isStopRequested = false;
			_isWarmingPlay = MasterAudio.IsWarming;
			MaybeCleanupFinishedDelegate();
			_hasStartedEndLinkedGroups = false;
			_isPaused = false;
			SetPlaySoundParams(gameObjectName, volPercent, targetVol, targetPitch, sourceTrans, attach, delayTime, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
			SetPriority();
			if (pitch.HasValue)
			{
				VarAudio.pitch = pitch.Value;
			}
			else if (useRandomPitch)
			{
				float num = UnityEngine.Random.Range(randomPitchMin, randomPitchMax);
				if (randomPitchMode == RandomPitchMode.AddToClipPitch)
				{
					num += OriginalPitch;
				}
				VarAudio.pitch = num;
			}
			else
			{
				VarAudio.pitch = OriginalPitch;
			}
			SetSpatialBlend();
			curFadeMode = FadeMode.None;
			curPitchMode = PitchMode.None;
			curDetectEndMode = DetectEndMode.DetectEnd;
			_maxVol = maxVolume;
			if (maxCustomLoops == minCustomLoops)
			{
				_maxLoops = minCustomLoops;
			}
			else
			{
				_maxLoops = UnityEngine.Random.Range(minCustomLoops, maxCustomLoops + 1);
			}
			LoadStatus = MasterAudio.VariationLoadStatus.Loading;
			switch (audLocation)
			{
			case MasterAudio.AudioLocation.Clip:
				FinishSetupToPlay();
				break;
			case MasterAudio.AudioLocation.ResourceFile:
				if (_loadResourceFileCoroutine != null)
				{
					StopCoroutine(_loadResourceFileCoroutine);
				}
				_loadResourceFileCoroutine = StartCoroutine(AudioResourceOptimizer.PopulateSourcesWithResourceClipAsync(ResFileName, this, FinishSetupToPlay, ResourceFailedToLoad));
				break;
			}
		}

		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
			_playSndParam.SoundType = gameObjectName;
			_playSndParam.VolumePercentage = volPercent;
			_playSndParam.GroupCalcVolume = targetVol;
			_playSndParam.Pitch = targetPitch;
			_playSndParam.SourceTrans = sourceTrans;
			_playSndParam.AttachToSource = attach;
			_playSndParam.DelaySoundTime = delayTime;
			_playSndParam.TimeToSchedulePlay = timeToSchedulePlay;
			_playSndParam.IsChainLoop = isChaining || ParentGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
			_playSndParam.IsSingleSubscribedPlay = isSingleSubscribedPlay;
			_playSndParam.IsPlaying = true;
		}

		private void MaybeCleanupFinishedDelegate()
		{
			if (ParentGroup.willCleanUpDelegatesAfterStop)
			{
				ClearSubscribers();
			}
		}

		private void ResourceFailedToLoad()
		{
			LoadStatus = MasterAudio.VariationLoadStatus.LoadFailed;
			Stop();
		}

		private void FinishSetupToPlay()
		{
			LoadStatus = MasterAudio.VariationLoadStatus.Loaded;
			if ((VarAudio.isPlaying || !(VarAudio.time > 0f)) && useFades && (fadeInTime > 0f || fadeOutTime > 0f))
			{
				fadeMaxVolume = _maxVol;
				if (fadeInTime > 0f)
				{
					VarAudio.volume = 0f;
				}
				if (VariationUpdater != null)
				{
					EnableUpdater(waitForSoundFinish: false);
					VariationUpdater.FadeInOut();
				}
			}
			VarAudio.loop = AudioLoops;
			if (_playSndParam.IsPlaying && (_playSndParam.IsChainLoop || _playSndParam.IsSingleSubscribedPlay || (useRandomStartTime && randomEndPercent != 100f)))
			{
				VarAudio.loop = false;
			}
			if (!_playSndParam.IsPlaying)
			{
				return;
			}
			ParentGroup.AddActiveAudioSourceId(InstanceId);
			EnableUpdater();
			_attachToSource = false;
			bool flag = MasterAudio.Instance.prioritizeOnDistance && (MasterAudio.Instance.useClipAgePriority || ParentGroup.useClipAgePriority);
			if (_playSndParam.AttachToSource || flag)
			{
				_attachToSource = _playSndParam.AttachToSource;
				if (VariationUpdater != null)
				{
					VariationUpdater.FollowObject(_attachToSource, ObjectToFollow, flag);
				}
			}
		}

		public void JumpToTime(float timeToJumpTo)
		{
			if (_playSndParam.IsPlaying)
			{
				VarAudio.time = timeToJumpTo;
			}
		}

		public void GlideByPitch(float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			float num = VarAudio.pitch + pitchAddition;
			if (num < -3f)
			{
				num = -3f;
			}
			if (num > 3f)
			{
				num = 3f;
			}
			if (!VarAudio.clip.IsClipReadyToPlay())
			{
				if (ParentGroup.LoggingEnabledForGroup)
				{
					MasterAudio.LogWarning("Cannot GlideToPitch Variation '" + base.name + "' because it is still loading.");
				}
			}
			else if (glideTime <= 0.1f)
			{
				if (VarAudio.pitch != num)
				{
					VarAudio.pitch = num;
				}
				completionCallback?.Invoke();
			}
			else if (VariationUpdater != null)
			{
				VariationUpdater.GlidePitch(num, glideTime, completionCallback);
			}
		}

		public void AdjustVolume(float volumePercentage)
		{
			if (!_playSndParam.IsPlaying)
			{
				return;
			}
			float volume = _playSndParam.GroupCalcVolume * volumePercentage;
			VarAudio.volume = volume;
			_playSndParam.VolumePercentage = volumePercentage;
			List<MasterAudio.AudioInfo> allVariationsOfGroup = MasterAudio.GetAllVariationsOfGroup(ParentGroup.name);
			for (int i = 0; i < allVariationsOfGroup.Count; i++)
			{
				MasterAudio.AudioInfo audioInfo = allVariationsOfGroup[i];
				if (!(audioInfo.Variation != this))
				{
					audioInfo.LastPercentageVolume = volumePercentage;
					break;
				}
			}
		}

		public void Pause()
		{
			if (!MasterAudio.Instance.resourceClipsPauseDoNotUnload)
			{
				switch (audLocation)
				{
				case MasterAudio.AudioLocation.ResourceFile:
					Stop();
					return;
				case MasterAudio.AudioLocation.Clip:
					if (!AudioUtil.AudioClipWillPreload(VarAudio.clip))
					{
						Stop();
						return;
					}
					break;
				}
			}
			_isPaused = true;
			VarAudio.Pause();
			if (VariationUpdater.enabled)
			{
				VariationUpdater.Pause();
			}
			curFadeMode = FadeMode.None;
			curPitchMode = PitchMode.None;
		}

		public void Unpause()
		{
			if (_isPaused && IsPlaying)
			{
				_isPaused = false;
				VarAudio.Play();
				if (VariationUpdater != null)
				{
					VariationUpdater.enabled = true;
					VariationUpdater.Unpause();
				}
			}
		}

		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
			EnableUpdater(waitForSoundFinish: false);
			SetPlaySoundParams(ParentGroup.GameObjectName, volumePercentage, volumePercentage, pitch, transActor, attach, 0f, null, isChaining: true, isSingleSubscribedPlay: false);
			VariationUpdater.MaybeChain();
			VariationUpdater.StopWaitingForFinish();
		}

		public void PlayEndLinkedGroups(double? timeToPlayClip = null)
		{
			if (MasterAudio.AppIsShuttingDown || MasterAudio.IsWarming || ParentGroup.endLinkedGroups.Count == 0 || _hasStartedEndLinkedGroups)
			{
				return;
			}
			_hasStartedEndLinkedGroups = true;
			if (VariationUpdater == null || VariationUpdater.FramesPlayed == 0)
			{
				return;
			}
			switch (ParentGroup.linkedStopGroupSelectionType)
			{
			case MasterAudio.LinkedGroupSelectionType.All:
			{
				for (int i = 0; i < ParentGroup.endLinkedGroups.Count; i++)
				{
					PlayEndLinkedGroup(ParentGroup.endLinkedGroups[i], timeToPlayClip);
				}
				break;
			}
			case MasterAudio.LinkedGroupSelectionType.OneAtRandom:
			{
				int index = UnityEngine.Random.Range(0, ParentGroup.endLinkedGroups.Count);
				PlayEndLinkedGroup(ParentGroup.endLinkedGroups[index], timeToPlayClip);
				break;
			}
			}
		}

		private void EnableUpdater(bool waitForSoundFinish = true)
		{
			if (VariationUpdater != null)
			{
				VariationUpdater.enabled = true;
				VariationUpdater.Initialize();
				if (waitForSoundFinish)
				{
					VariationUpdater.WaitForSoundFinish();
				}
			}
		}

		private void MaybeUnloadClip()
		{
			VarAudio.Stop();
			VarAudio.time = 0f;
			switch (audLocation)
			{
			case MasterAudio.AudioLocation.ResourceFile:
				AudioResourceOptimizer.UnloadClipIfUnused(_resFileName);
				break;
			case MasterAudio.AudioLocation.Clip:
				AudioUtil.UnloadNonPreloadedAudioData(VarAudio.clip, GameObj);
				break;
			}
			LoadStatus = MasterAudio.VariationLoadStatus.None;
		}

		private void PlayEndLinkedGroup(string sType, double? timeToPlayClip = null)
		{
			if (_playSndParam.AttachToSource && _playSndParam.SourceTrans != null)
			{
				MasterAudio.PlaySound3DFollowTransformAndForget(sType, _playSndParam.SourceTrans, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
			else if (_playSndParam.SourceTrans != null)
			{
				MasterAudio.PlaySound3DAtTransformAndForget(sType, _playSndParam.SourceTrans, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
			else
			{
				MasterAudio.PlaySound3DAtVector3AndForget(sType, Trans.position, _playSndParam.VolumePercentage, _playSndParam.Pitch, 0f, null, timeToPlayClip);
			}
		}

		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
			if (IsPlaying && !_isStopRequested)
			{
				_isStopRequested = true;
			}
			_isPaused = false;
			bool flag = false;
			if (stopEndDetection && VariationUpdater != null)
			{
				VariationUpdater.StopWaitingForFinish();
				flag = true;
			}
			if (!skipLinked)
			{
				PlayEndLinkedGroups();
			}
			_objectToFollow = null;
			_objectToTriggerFrom = null;
			VarAudio.pitch = OriginalPitch;
			ParentGroup.RemoveActiveAudioSourceId(InstanceId);
			MasterAudio.StopTrackingOcclusionForSource(GameObj);
			if (VariationUpdater != null)
			{
				VariationUpdater.StopFollowing();
				VariationUpdater.StopFading();
				VariationUpdater.StopPitchGliding();
			}
			if (!flag && VariationUpdater != null)
			{
				VariationUpdater.StopWaitingForFinish();
			}
			_playSndParam.IsPlaying = false;
			if (this.SoundFinished != null)
			{
				bool num = _previousSoundFinishedFrame == AudioUtil.FrameCount;
				_previousSoundFinishedFrame = AudioUtil.FrameCount;
				if (!num)
				{
					this.SoundFinished();
				}
				MaybeCleanupFinishedDelegate();
			}
			Trans.localPosition = Vector3.zero;
			switch (_loadStatus)
			{
			case MasterAudio.VariationLoadStatus.None:
			case MasterAudio.VariationLoadStatus.Loaded:
			case MasterAudio.VariationLoadStatus.LoadFailed:
				StopEndCleanup();
				break;
			case MasterAudio.VariationLoadStatus.Loading:
				if (!_isUnloadAddressableCoroutineRunning)
				{
					StartCoroutine(WaitForLoadToUnloadClipAndDeactivate());
				}
				break;
			}
		}

		private void StopEndCleanup()
		{
			MaybeUnloadClip();
			if (!_isWarmingPlay)
			{
				DTMonoHelper.SetActive(GameObj, isActive: false);
			}
		}

		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			_isUnloadAddressableCoroutineRunning = true;
			while (_loadStatus == MasterAudio.VariationLoadStatus.Loading)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
			_isUnloadAddressableCoroutineRunning = false;
			StopEndCleanup();
		}

		public void FadeToVolume(float newVolume, float fadeTime)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1.");
			}
			else if (!VarAudio.clip.IsClipReadyToPlay())
			{
				if (ParentGroup.LoggingEnabledForGroup)
				{
					MasterAudio.LogWarning("Cannot Fade Variation '" + base.name + "' because it is still loading.");
				}
			}
			else if (fadeTime <= 0.1f)
			{
				VarAudio.volume = newVolume;
				if (VarAudio.volume <= 0f)
				{
					Stop();
				}
			}
			else if (VariationUpdater != null)
			{
				VariationUpdater.FadeOverTimeToVolume(newVolume, fadeTime);
			}
		}

		public void FadeOutNow()
		{
			if (!MasterAudio.AppIsShuttingDown && IsPlaying && useFades && VariationUpdater != null)
			{
				VariationUpdater.FadeOutEarly(fadeOutTime);
			}
		}

		public void FadeOutNow(float fadeTime)
		{
			if (!MasterAudio.AppIsShuttingDown && IsPlaying && VariationUpdater != null)
			{
				VariationUpdater.FadeOutEarly(fadeTime);
			}
		}

		public bool WasTriggeredFromTransform(Transform trans)
		{
			if (ObjectToFollow == trans || ObjectToTriggerFrom == trans)
			{
				return true;
			}
			return false;
		}

		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			if (ObjectToFollow != null && transMap.Contains(ObjectToFollow))
			{
				return true;
			}
			if (ObjectToTriggerFrom != null && transMap.Contains(ObjectToTriggerFrom))
			{
				return true;
			}
			return false;
		}

		public void UpdateTransformTracker(Transform sourceTrans)
		{
			if (!(sourceTrans == null) && Application.isEditor && !MasterAudio.IsWarming && sourceTrans.GetComponent<AudioTransformTracker>() == null)
			{
				sourceTrans.gameObject.AddComponent<AudioTransformTracker>();
			}
		}

		public void SoundLoopStarted(int numberOfLoops)
		{
			if (this.SoundLooped != null)
			{
				this.SoundLooped(numberOfLoops);
			}
		}

		public void ClearSubscribers()
		{
			this.SoundFinished = null;
			this.SoundLooped = null;
		}
	}
	[AudioScriptOrder(-15)]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		private enum WaitForSoundFinishMode
		{
			None,
			Play,
			WaitForEnd,
			StopOrRepeat
		}

		private const float TimeEarlyToScheduleNextClip = 0.1f;

		private const float FakeNegativeFloatValue = -10f;

		private Transform _objectToFollow;

		private GameObject _objectToFollowGo;

		private bool _isFollowing;

		private SoundGroupVariation _variation;

		private float _priorityLastUpdated = -10f;

		private bool _useClipAgePriority;

		private WaitForSoundFinishMode _waitMode;

		private AudioSource _varAudio;

		private MasterAudioGroup _parentGrp;

		private Transform _trans;

		private int _frameNum = -1;

		private bool _inited;

		private float _fadeOutStartTime = -5f;

		private bool _fadeInOutWillFadeOut;

		private bool _hasFadeInOutSetMaxVolume;

		private float _fadeInOutInFactor;

		private float _fadeInOutOutFactor;

		private int _fadeOutEarlyTotalFrames;

		private float _fadeOutEarlyFrameVolChange;

		private int _fadeOutEarlyFrameNumber;

		private float _fadeOutEarlyOrigVol;

		private float _fadeToTargetFrameVolChange;

		private int _fadeToTargetFrameNumber;

		private float _fadeToTargetOrigVol;

		private int _fadeToTargetTotalFrames;

		private float _fadeToTargetVolume;

		private bool _fadeOutStarted;

		private float _lastFrameClipTime = -1f;

		private bool _isPlayingBackward;

		private int _pitchGlideToTargetTotalFrames;

		private float _pitchGlideToTargetFramePitchChange;

		private int _pitchGlideToTargetFrameNumber;

		private float _glideToTargetPitch;

		private float _glideToTargetOrigPitch;

		private Action _glideToPitchCompletionCallback;

		private bool _hasStartedNextInChain;

		private bool _isWaitingForQueuedOcclusionRay;

		private int _framesPlayed;

		private float? _clipStartPosition;

		private float? _clipEndPosition;

		private double? _clipSchedEndTime;

		private bool _hasScheduledNextClip;

		private bool _hasScheduledEndLinkedGroups;

		private int _lastFrameClipPosition = -1;

		private int _timesLooped;

		private bool _isPaused;

		private double _pauseTime;

		private static int _maCachedFromFrame = -1;

		private static MasterAudio _maThisFrame;

		private static Transform _listenerThisFrame;

		public float ClipStartPosition
		{
			get
			{
				if (_clipStartPosition.HasValue)
				{
					return _clipStartPosition.Value;
				}
				if (GrpVariation.useRandomStartTime)
				{
					_clipStartPosition = UnityEngine.Random.Range(GrpVariation.randomStartMinPercent, GrpVariation.randomStartMaxPercent) * 0.01f * VarAudio.clip.length;
				}
				else
				{
					_clipStartPosition = 0f;
				}
				return _clipStartPosition.Value;
			}
		}

		public float ClipEndPosition
		{
			get
			{
				if (_clipEndPosition.HasValue)
				{
					return _clipEndPosition.Value;
				}
				if (GrpVariation.useRandomStartTime)
				{
					_clipEndPosition = GrpVariation.randomEndPercent * 0.01f * VarAudio.clip.length;
				}
				else
				{
					_clipEndPosition = VarAudio.clip.length;
				}
				return _clipEndPosition.Value;
			}
		}

		public int FramesPlayed => _framesPlayed;

		public MasterAudio MAThisFrame => _maThisFrame;

		public float MaxOcclusionFreq
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideFrequencies)
				{
					return ParentGroup.occlusionMaxCutoffFreq;
				}
				return _maThisFrame.occlusionMaxCutoffFreq;
			}
		}

		public float MinOcclusionFreq
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideFrequencies)
				{
					return ParentGroup.occlusionMinCutoffFreq;
				}
				return _maThisFrame.occlusionMinCutoffFreq;
			}
		}

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = GrpVariation.Trans;
				return _trans;
			}
		}

		private AudioSource VarAudio
		{
			get
			{
				if (_varAudio != null)
				{
					return _varAudio;
				}
				_varAudio = GrpVariation.VarAudio;
				return _varAudio;
			}
		}

		private MasterAudioGroup ParentGroup
		{
			get
			{
				if (_parentGrp != null)
				{
					return _parentGrp;
				}
				_parentGrp = GrpVariation.ParentGroup;
				return _parentGrp;
			}
		}

		private SoundGroupVariation GrpVariation
		{
			get
			{
				if (_variation != null)
				{
					return _variation;
				}
				_variation = GetComponent<SoundGroupVariation>();
				return _variation;
			}
		}

		private float RayCastOriginOffset
		{
			get
			{
				if (GrpVariation.UsesOcclusion && ParentGroup.willOcclusionOverrideRaycastOffset)
				{
					return ParentGroup.occlusionRayCastOffset;
				}
				return _maThisFrame.occlusionRayCastOffset;
			}
		}

		private bool IsOcclusionMeasuringPaused
		{
			get
			{
				if (!_isWaitingForQueuedOcclusionRay)
				{
					return MasterAudio.IsOcclusionFreqencyTransitioning(GrpVariation);
				}
				return true;
			}
		}

		private bool HasEndLinkedGroups
		{
			get
			{
				if (GrpVariation.ParentGroup.endLinkedGroups.Count > 0)
				{
					return true;
				}
				return false;
			}
		}

		public void GlidePitch(float targetPitch, float glideTime, Action completionCallback = null)
		{
			GrpVariation.curPitchMode = SoundGroupVariation.PitchMode.Gliding;
			float num = targetPitch - VarAudio.pitch;
			_pitchGlideToTargetTotalFrames = (int)(glideTime / AudioUtil.FrameTime);
			_pitchGlideToTargetFramePitchChange = num / (float)_pitchGlideToTargetTotalFrames;
			_pitchGlideToTargetFrameNumber = 0;
			_glideToTargetPitch = targetPitch;
			_glideToTargetOrigPitch = VarAudio.pitch;
			_glideToPitchCompletionCallback = completionCallback;
		}

		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.GradualFade;
			float num = targetVolume - VarAudio.volume;
			float time = VarAudio.time;
			float clipEndPosition = ClipEndPosition;
			if (!VarAudio.loop && VarAudio.clip != null && fadeTime + time > clipEndPosition)
			{
				fadeTime = clipEndPosition - time;
			}
			_fadeToTargetTotalFrames = (int)(fadeTime / AudioUtil.FrameTime);
			_fadeToTargetFrameVolChange = num / (float)_fadeToTargetTotalFrames;
			_fadeToTargetFrameNumber = 0;
			_fadeToTargetOrigVol = VarAudio.volume;
			_fadeToTargetVolume = targetVolume;
		}

		public void FadeOutEarly(float fadeTime)
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.FadeOutEarly;
			if (!VarAudio.loop && VarAudio.clip != null && VarAudio.time + fadeTime > ClipEndPosition)
			{
				fadeTime = ClipEndPosition - VarAudio.time;
			}
			float num = AudioUtil.FrameTime;
			if (num == 0f)
			{
				num = AudioUtil.FixedDeltaTime;
			}
			_fadeOutEarlyTotalFrames = (int)(fadeTime / num);
			_fadeOutEarlyFrameVolChange = (0f - VarAudio.volume) / (float)_fadeOutEarlyTotalFrames;
			_fadeOutEarlyFrameNumber = 0;
			_fadeOutEarlyOrigVol = VarAudio.volume;
		}

		public void Initialize()
		{
			if (!_inited)
			{
				_lastFrameClipPosition = -1;
				_timesLooped = 0;
				_isPaused = false;
				_pauseTime = -1.0;
				_clipStartPosition = null;
				_clipEndPosition = null;
				_clipSchedEndTime = null;
				_hasScheduledNextClip = false;
				_hasScheduledEndLinkedGroups = false;
				_inited = true;
			}
		}

		public void FadeInOut()
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.FadeInOut;
			_fadeOutStartTime = ClipEndPosition - GrpVariation.fadeOutTime;
			if (GrpVariation.fadeInTime > 0f)
			{
				VarAudio.volume = 0f;
				_fadeInOutInFactor = GrpVariation.fadeMaxVolume / GrpVariation.fadeInTime;
			}
			else
			{
				_fadeInOutInFactor = 0f;
			}
			_fadeInOutWillFadeOut = GrpVariation.fadeOutTime > 0f && !VarAudio.loop;
			if (_fadeInOutWillFadeOut)
			{
				_fadeInOutOutFactor = GrpVariation.fadeMaxVolume / (ClipEndPosition - _fadeOutStartTime);
			}
			else
			{
				_fadeInOutOutFactor = 0f;
			}
		}

		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
			_isFollowing = follow;
			if (objToFollow != null)
			{
				_objectToFollow = objToFollow;
				_objectToFollowGo = objToFollow.gameObject;
			}
			_useClipAgePriority = clipAgePriority;
			UpdateCachedObjects();
			UpdateAudioLocationAndPriority(rePrioritize: false);
		}

		public void WaitForSoundFinish()
		{
			if (MasterAudio.IsWarming)
			{
				PlaySoundAndWait();
			}
			else
			{
				_waitMode = WaitForSoundFinishMode.Play;
			}
		}

		public void StopPitchGliding()
		{
			GrpVariation.curPitchMode = SoundGroupVariation.PitchMode.None;
			if (_glideToPitchCompletionCallback != null)
			{
				_glideToPitchCompletionCallback();
				_glideToPitchCompletionCallback = null;
			}
			DisableIfFinished();
		}

		public void StopFading()
		{
			GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.None;
			DisableIfFinished();
		}

		public void StopWaitingForFinish()
		{
			_waitMode = WaitForSoundFinishMode.None;
			GrpVariation.curDetectEndMode = SoundGroupVariation.DetectEndMode.None;
			DisableIfFinished();
		}

		public void StopFollowing()
		{
			_isFollowing = false;
			_useClipAgePriority = false;
			_objectToFollow = null;
			_objectToFollowGo = null;
			DisableIfFinished();
		}

		private void DisableIfFinished()
		{
			if (!_isFollowing && GrpVariation.curDetectEndMode != SoundGroupVariation.DetectEndMode.DetectEnd && GrpVariation.curFadeMode == SoundGroupVariation.FadeMode.None && GrpVariation.curPitchMode == SoundGroupVariation.PitchMode.None)
			{
				base.enabled = false;
			}
		}

		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
			if (_isFollowing && _objectToFollow != null)
			{
				Trans.position = _objectToFollow.position;
			}
			if (_maThisFrame.prioritizeOnDistance && rePrioritize && !ParentGroup.alwaysHighestPriority && !(Time.realtimeSinceStartup - _priorityLastUpdated <= MasterAudio.ReprioritizeTime))
			{
				AudioPrioritizer.Set3DPriority(GrpVariation, _useClipAgePriority);
				_priorityLastUpdated = AudioUtil.Time;
			}
		}

		private void ResetToNonOcclusionSetting()
		{
			AudioLowPassFilter lowPassFilter = GrpVariation.LowPassFilter;
			if (lowPassFilter != null)
			{
				lowPassFilter.cutoffFrequency = 22000f;
			}
		}

		private void UpdateOcclusion()
		{
			if (!GrpVariation.UsesOcclusion)
			{
				MasterAudio.StopTrackingOcclusionForSource(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
			}
			else if (!(_listenerThisFrame == null) && !IsOcclusionMeasuringPaused)
			{
				MasterAudio.AddToQueuedOcclusionRays(this);
				_isWaitingForQueuedOcclusionRay = true;
			}
		}

		private void DoneWithOcclusion()
		{
			_isWaitingForQueuedOcclusionRay = false;
			MasterAudio.RemoveFromOcclusionFrequencyTransitioning(GrpVariation);
		}

		public bool RayCastForOcclusion()
		{
			DoneWithOcclusion();
			Vector3 vector = Trans.position;
			float rayCastOriginOffset = RayCastOriginOffset;
			if (rayCastOriginOffset > 0f)
			{
				vector = Vector3.MoveTowards(vector, _listenerThisFrame.position, rayCastOriginOffset);
			}
			Vector3 direction = _listenerThisFrame.position - vector;
			float magnitude = direction.magnitude;
			if (magnitude > VarAudio.maxDistance)
			{
				MasterAudio.AddToOcclusionOutOfRangeSources(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
				return false;
			}
			MasterAudio.AddToOcclusionInRangeSources(GrpVariation.GameObj);
			bool flag = _maThisFrame.occlusionRaycastMode == MasterAudio.RaycastMode.Physics2D;
			if (GrpVariation.LowPassFilter == null)
			{
				AudioLowPassFilter lowPassFilter = GrpVariation.gameObject.AddComponent<AudioLowPassFilter>();
				GrpVariation.LowPassFilter = lowPassFilter;
			}
			bool queriesHitTriggers = true;
			if (!flag)
			{
				queriesHitTriggers = Physics.queriesHitTriggers;
				Physics.queriesHitTriggers = _maThisFrame.occlusionRaycastsHitTriggers;
			}
			Vector3 vector2 = Vector3.zero;
			float? num = null;
			bool flag2 = false;
			if (_maThisFrame.occlusionUseLayerMask)
			{
				switch (_maThisFrame.occlusionRaycastMode)
				{
				case MasterAudio.RaycastMode.Physics3D:
				{
					if (Physics.Raycast(vector, direction, out var hitInfo, magnitude, _maThisFrame.occlusionLayerMask.value))
					{
						flag2 = true;
						vector2 = hitInfo.point;
						num = hitInfo.distance;
					}
					break;
				}
				}
			}
			else
			{
				switch (_maThisFrame.occlusionRaycastMode)
				{
				case MasterAudio.RaycastMode.Physics3D:
				{
					if (Physics.Raycast(vector, direction, out var hitInfo2, magnitude))
					{
						flag2 = true;
						vector2 = hitInfo2.point;
						num = hitInfo2.distance;
					}
					break;
				}
				}
			}
			if (!flag)
			{
				Physics.queriesHitTriggers = queriesHitTriggers;
			}
			if (_maThisFrame.occlusionShowRaycasts)
			{
				Vector3 end = (flag2 ? vector2 : _listenerThisFrame.position);
				Color color = (flag2 ? Color.red : Color.green);
				UnityEngine.Debug.DrawLine(vector, end, color, 0.1f);
			}
			if (!flag2)
			{
				MasterAudio.RemoveFromBlockedOcclusionSources(GrpVariation.GameObj);
				ResetToNonOcclusionSetting();
				return true;
			}
			MasterAudio.AddToBlockedOcclusionSources(GrpVariation.GameObj);
			float occlusionCutoffFrequencyByDistanceRatio = AudioUtil.GetOcclusionCutoffFrequencyByDistanceRatio(num.Value / VarAudio.maxDistance, this);
			float occlusionFreqChangeSeconds = _maThisFrame.occlusionFreqChangeSeconds;
			if (occlusionFreqChangeSeconds <= 0.1f)
			{
				GrpVariation.LowPassFilter.cutoffFrequency = occlusionCutoffFrequencyByDistanceRatio;
				return true;
			}
			MasterAudio.GradualOcclusionFreqChange(GrpVariation, occlusionFreqChangeSeconds, occlusionCutoffFrequencyByDistanceRatio);
			return true;
		}

		private void PlaySoundAndWait()
		{
			if (VarAudio.clip == null)
			{
				return;
			}
			double num = AudioSettings.dspTime;
			if (GrpVariation.PlaySoundParm.TimeToSchedulePlay.HasValue)
			{
				num = GrpVariation.PlaySoundParm.TimeToSchedulePlay.Value;
			}
			float num2 = 0f;
			if (GrpVariation.useIntroSilence && GrpVariation.introSilenceMax > 0f)
			{
				float num3 = UnityEngine.Random.Range(GrpVariation.introSilenceMin, GrpVariation.introSilenceMax);
				num2 += num3;
			}
			num2 += GrpVariation.PlaySoundParm.DelaySoundTime;
			if (num2 > 0f)
			{
				num += (double)num2;
			}
			VarAudio.PlayScheduled(num);
			_ = GrpVariation.audLocation;
			AudioUtil.ClipPlayed(VarAudio.clip, GrpVariation.GameObj);
			if (GrpVariation.useRandomStartTime)
			{
				VarAudio.time = ClipStartPosition;
				if (!VarAudio.loop)
				{
					float num4 = AudioUtil.AdjustAudioClipDurationForPitch(ClipEndPosition - ClipStartPosition, VarAudio);
					_clipSchedEndTime = num + (double)num4;
					VarAudio.SetScheduledEndTime(_clipSchedEndTime.Value);
				}
			}
			GrpVariation.LastTimePlayed = AudioUtil.Time;
			DuckIfNotSilent();
			_isPlayingBackward = GrpVariation.OriginalPitch < 0f;
			_lastFrameClipTime = (_isPlayingBackward ? (ClipEndPosition + 1f) : (-1f));
			_waitMode = WaitForSoundFinishMode.WaitForEnd;
		}

		private void DuckIfNotSilent()
		{
			bool flag = false;
			if (GrpVariation.PlaySoundParm.VolumePercentage <= 0f)
			{
				flag = true;
			}
			else if (GrpVariation.ParentGroup.groupMasterVolume <= 0f)
			{
				flag = true;
			}
			else if (GrpVariation.VarAudio.mute)
			{
				flag = true;
			}
			else if (MasterAudio.MixerMuted)
			{
				flag = true;
			}
			else if (GrpVariation.ParentGroup.isMuted)
			{
				flag = true;
			}
			else
			{
				GroupBus busForGroup = GrpVariation.ParentGroup.BusForGroup;
				if (busForGroup != null && busForGroup.isMuted)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				MasterAudio.DuckSoundGroup(ParentGroup.GameObjectName, VarAudio);
			}
		}

		private void StopOrChain()
		{
			SoundGroupVariation.PlaySoundParams playSoundParm = GrpVariation.PlaySoundParm;
			bool flag = playSoundParm.IsPlaying && playSoundParm.IsChainLoop;
			if (!VarAudio.loop || flag)
			{
				GrpVariation.Stop();
			}
			if (flag)
			{
				StopWaitingForFinish();
				MaybeChain();
			}
		}

		public void Pause()
		{
			_isPaused = true;
			_pauseTime = AudioSettings.dspTime;
		}

		public void Unpause()
		{
			_isPaused = false;
			if (_clipSchedEndTime.HasValue)
			{
				_clipSchedEndTime += AudioSettings.dspTime - _pauseTime;
				VarAudio.SetScheduledEndTime(_clipSchedEndTime.Value);
			}
		}

		public void MaybeChain()
		{
			if (_hasStartedNextInChain)
			{
				return;
			}
			_hasStartedNextInChain = true;
			SoundGroupVariation.PlaySoundParams playSoundParm = GrpVariation.PlaySoundParm;
			int num = MasterAudio.RemainingClipsInGroup(ParentGroup.GameObjectName);
			int num2 = MasterAudio.VoicesForGroup(ParentGroup.GameObjectName);
			if (num == num2)
			{
				ParentGroup.FireLastVariationFinishedPlay();
			}
			if (ParentGroup.chainLoopMode == MasterAudioGroup.ChainedLoopLoopMode.NumberOfLoops && ParentGroup.ChainLoopCount >= ParentGroup.chainLoopNumLoops)
			{
				return;
			}
			float delaySoundTime = playSoundParm.DelaySoundTime;
			if (ParentGroup.chainLoopDelayMin > 0f || ParentGroup.chainLoopDelayMax > 0f)
			{
				delaySoundTime = UnityEngine.Random.Range(ParentGroup.chainLoopDelayMin, ParentGroup.chainLoopDelayMax);
			}
			if (playSoundParm.AttachToSource || playSoundParm.SourceTrans != null)
			{
				if (playSoundParm.AttachToSource)
				{
					MasterAudio.PlaySound3DFollowTransform(playSoundParm.SoundType, playSoundParm.SourceTrans, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
				}
				else
				{
					MasterAudio.PlaySound3DAtTransform(playSoundParm.SoundType, playSoundParm.SourceTrans, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
				}
			}
			else
			{
				MasterAudio.PlaySound(playSoundParm.SoundType, playSoundParm.VolumePercentage, playSoundParm.Pitch, delaySoundTime, null, _clipSchedEndTime, isChaining: true);
			}
		}

		private void UpdatePitch()
		{
			SoundGroupVariation.PitchMode curPitchMode = GrpVariation.curPitchMode;
			if (curPitchMode != 0 && curPitchMode == SoundGroupVariation.PitchMode.Gliding && VarAudio.isPlaying)
			{
				_pitchGlideToTargetFrameNumber++;
				if (_pitchGlideToTargetFrameNumber >= _pitchGlideToTargetTotalFrames)
				{
					VarAudio.pitch = _glideToTargetPitch;
					StopPitchGliding();
				}
				else
				{
					VarAudio.pitch = (float)_pitchGlideToTargetFrameNumber * _pitchGlideToTargetFramePitchChange + _glideToTargetOrigPitch;
				}
			}
		}

		private void PerformFading()
		{
			switch (GrpVariation.curFadeMode)
			{
			case SoundGroupVariation.FadeMode.FadeInOut:
			{
				if (!VarAudio.isPlaying)
				{
					break;
				}
				float time = VarAudio.time;
				if (GrpVariation.fadeInTime > 0f && time < GrpVariation.fadeInTime)
				{
					VarAudio.volume = time * _fadeInOutInFactor;
				}
				else if (time >= GrpVariation.fadeInTime && !_hasFadeInOutSetMaxVolume)
				{
					VarAudio.volume = GrpVariation.fadeMaxVolume;
					_hasFadeInOutSetMaxVolume = true;
					if (!_fadeInOutWillFadeOut)
					{
						StopFading();
					}
				}
				else if (_fadeInOutWillFadeOut && time >= _fadeOutStartTime)
				{
					if (GrpVariation.PlaySoundParm.IsChainLoop && !_fadeOutStarted)
					{
						MaybeChain();
						_fadeOutStarted = true;
					}
					VarAudio.volume = (ClipEndPosition - time) * _fadeInOutOutFactor;
				}
				break;
			}
			case SoundGroupVariation.FadeMode.FadeOutEarly:
				if (VarAudio.isPlaying)
				{
					_fadeOutEarlyFrameNumber++;
					VarAudio.volume = (float)_fadeOutEarlyFrameNumber * _fadeOutEarlyFrameVolChange + _fadeOutEarlyOrigVol;
					if (_fadeOutEarlyFrameNumber >= _fadeOutEarlyTotalFrames)
					{
						GrpVariation.curFadeMode = SoundGroupVariation.FadeMode.None;
						GrpVariation.Stop();
					}
				}
				break;
			case SoundGroupVariation.FadeMode.GradualFade:
				if (VarAudio.isPlaying)
				{
					_fadeToTargetFrameNumber++;
					if (_fadeToTargetFrameNumber >= _fadeToTargetTotalFrames)
					{
						VarAudio.volume = _fadeToTargetVolume;
						StopFading();
					}
					else
					{
						VarAudio.volume = (float)_fadeToTargetFrameNumber * _fadeToTargetFrameVolChange + _fadeToTargetOrigVol;
					}
				}
				break;
			case SoundGroupVariation.FadeMode.None:
				break;
			}
		}

		private void OnEnable()
		{
			_inited = false;
			_fadeInOutWillFadeOut = false;
			_hasFadeInOutSetMaxVolume = false;
			_fadeOutStarted = false;
			_hasStartedNextInChain = false;
			_framesPlayed = 0;
			_clipStartPosition = null;
			_clipEndPosition = null;
			DoneWithOcclusion();
			MasterAudio.RegisterUpdaterForUpdates(this);
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown)
			{
				_framesPlayed = 0;
				DoneWithOcclusion();
				MasterAudio.UnregisterUpdaterForUpdates(this);
			}
		}

		public void UpdateCachedObjects()
		{
			_frameNum = AudioUtil.FrameCount;
			if (_maCachedFromFrame < _frameNum)
			{
				_maCachedFromFrame = _frameNum;
				_maThisFrame = MasterAudio.Instance;
				_listenerThisFrame = MasterAudio.ListenerTrans;
			}
		}

		public void ManualUpdate()
		{
			UpdateCachedObjects();
			_framesPlayed++;
			if (VarAudio.loop)
			{
				if (VarAudio.timeSamples < _lastFrameClipPosition)
				{
					_timesLooped++;
					if (VarAudio.loop && GrpVariation.useCustomLooping && _timesLooped >= GrpVariation.MaxLoops)
					{
						GrpVariation.Stop();
					}
					else
					{
						GrpVariation.SoundLoopStarted(_timesLooped);
					}
				}
				_lastFrameClipPosition = VarAudio.timeSamples;
			}
			if (_isFollowing && ParentGroup.targetDespawnedBehavior != 0 && (_objectToFollowGo == null || !DTMonoHelper.IsActive(_objectToFollowGo)))
			{
				switch (ParentGroup.targetDespawnedBehavior)
				{
				case MasterAudioGroup.TargetDespawnedBehavior.Stop:
					GrpVariation.Stop();
					break;
				case MasterAudioGroup.TargetDespawnedBehavior.FadeOut:
					GrpVariation.FadeOutNow(ParentGroup.despawnFadeTime);
					break;
				}
				StopFollowing();
			}
			PerformFading();
			UpdateAudioLocationAndPriority(rePrioritize: true);
			UpdateOcclusion();
			UpdatePitch();
			switch (_waitMode)
			{
			case WaitForSoundFinishMode.Play:
				PlaySoundAndWait();
				break;
			case WaitForSoundFinishMode.WaitForEnd:
			{
				if (_isPaused)
				{
					break;
				}
				if (_clipSchedEndTime.HasValue && AudioSettings.dspTime + 0.10000000149011612 >= _clipSchedEndTime.Value)
				{
					if (GrpVariation.PlaySoundParm.IsChainLoop && !_hasScheduledNextClip)
					{
						MaybeChain();
						_hasScheduledNextClip = true;
					}
					if (HasEndLinkedGroups && !_hasScheduledEndLinkedGroups)
					{
						GrpVariation.PlayEndLinkedGroups(_clipSchedEndTime.Value);
						_hasScheduledEndLinkedGroups = true;
					}
				}
				bool flag = false;
				if (_isPlayingBackward)
				{
					if (VarAudio.time > _lastFrameClipTime)
					{
						flag = true;
					}
				}
				else if (VarAudio.time < _lastFrameClipTime)
				{
					flag = true;
				}
				_lastFrameClipTime = VarAudio.time;
				if (flag)
				{
					_waitMode = WaitForSoundFinishMode.StopOrRepeat;
				}
				break;
			}
			case WaitForSoundFinishMode.StopOrRepeat:
				StopOrChain();
				break;
			case WaitForSoundFinishMode.None:
				break;
			}
		}
	}
	public static class AudioLoaderOptimizer
	{
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName = new Dictionary<string, List<GameObject>>(StringComparer.OrdinalIgnoreCase);

		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
			if (clip == null)
			{
				return;
			}
			string name = clip.name;
			if (!PlayingGameObjectsByClipName.ContainsKey(name))
			{
				PlayingGameObjectsByClipName.Add(name, new List<GameObject> { maHolderGameObject });
				return;
			}
			List<GameObject> list = PlayingGameObjectsByClipName[name];
			if (!list.Contains(maHolderGameObject))
			{
				list.Add(maHolderGameObject);
			}
		}

		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
			if (clip == null)
			{
				return;
			}
			string name = clip.name;
			if (PlayingGameObjectsByClipName.ContainsKey(name))
			{
				List<GameObject> list = PlayingGameObjectsByClipName[name];
				list.Remove(maHolderGameObject);
				if (list.Count == 0)
				{
					PlayingGameObjectsByClipName.Remove(name);
				}
			}
		}

		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			if (clip == null)
			{
				return false;
			}
			return PlayingGameObjectsByClipName.ContainsKey(clip.name);
		}
	}
	public static class AudioPrioritizer
	{
		private const int MaxPriority = 0;

		private const int HighestPriority = 16;

		private const int LowestPriority = 128;

		public static void Set2DSoundPriority(AudioSource audio)
		{
			audio.priority = 16;
		}

		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
			audio.priority = 128;
		}

		public static void SetPreviewPriority(AudioSource audio)
		{
			audio.priority = 0;
		}

		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
			if (MasterAudio.ListenerTrans == null)
			{
				return;
			}
			AudioSource varAudio = variation.VarAudio;
			if (varAudio.spatialBlend == 0f)
			{
				Set2DSoundPriority(variation.VarAudio);
				return;
			}
			float num = Vector3.Distance(varAudio.transform.position, MasterAudio.ListenerTrans.position);
			float num2 = varAudio.rolloffMode switch
			{
				AudioRolloffMode.Logarithmic => varAudio.volume / Mathf.Max(varAudio.minDistance, num - varAudio.minDistance), 
				AudioRolloffMode.Linear => Mathf.Lerp(varAudio.volume, 0f, Mathf.Max(0f, num - varAudio.minDistance) / (varAudio.maxDistance - varAudio.minDistance)), 
				_ => Mathf.Lerp(varAudio.volume, 0f, Mathf.Max(0f, num - varAudio.minDistance) / (varAudio.maxDistance - varAudio.minDistance)), 
			};
			if (useClipAgePriority && !varAudio.loop)
			{
				num2 = Mathf.Lerp(num2, num2 * 0.1f, AudioUtil.GetAudioPlayedPercentage(varAudio) * 0.01f);
			}
			varAudio.priority = (int)Mathf.Lerp(16f, 128f, Mathf.InverseLerp(1f, 0f, num2));
		}
	}
	public static class AudioResourceOptimizer
	{
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName = new Dictionary<string, List<AudioSource>>(StringComparer.OrdinalIgnoreCase);

		private static readonly Dictionary<string, AudioClip> AudioClipsByName = new Dictionary<string, AudioClip>(StringComparer.OrdinalIgnoreCase);

		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName = new Dictionary<string, List<AudioClip>>(5, StringComparer.OrdinalIgnoreCase);

		private static string _supportedLanguageFolder = string.Empty;

		public static void ClearAudioClips()
		{
			AudioClipsByName.Clear();
			AudioResourceTargetsByName.Clear();
		}

		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			if (!useLocalization)
			{
				return resourceFileName;
			}
			if (MasterAudio.Instance != null)
			{
				return GetLocalizedFileName(useLocalization, resourceFileName);
			}
			return localLanguage.ToString() + "/" + resourceFileName;
		}

		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			if (!useLocalization)
			{
				return resourceFileName;
			}
			return SupportedLanguageFolder() + "/" + resourceFileName;
		}

		public static void AddTargetForClip(string clipName, AudioSource source)
		{
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				AudioResourceTargetsByName.Add(clipName, new List<AudioSource> { source });
				return;
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			AudioClip audioClip = null;
			for (int i = 0; i < list.Count; i++)
			{
				AudioClip clip = list[i].clip;
				if (!(clip == null))
				{
					audioClip = clip;
					break;
				}
			}
			if (audioClip != null)
			{
				source.clip = audioClip;
			}
			list.Add(source);
		}

		private static string SupportedLanguageFolder()
		{
			if (!string.IsNullOrEmpty(_supportedLanguageFolder))
			{
				return _supportedLanguageFolder;
			}
			SystemLanguage item = Application.systemLanguage;
			if (MasterAudio.Instance != null)
			{
				switch (MasterAudio.Instance.langMode)
				{
				case MasterAudio.LanguageMode.SpecificLanguage:
					item = MasterAudio.Instance.testLanguage;
					break;
				case MasterAudio.LanguageMode.DynamicallySet:
					item = MasterAudio.DynamicLanguage;
					break;
				}
			}
			if (MasterAudio.Instance.supportedLanguages.Contains(item))
			{
				_supportedLanguageFolder = item.ToString();
			}
			else
			{
				_supportedLanguageFolder = MasterAudio.Instance.defaultLanguage.ToString();
			}
			return _supportedLanguageFolder;
		}

		public static void ClearSupportLanguageFolder()
		{
			_supportedLanguageFolder = string.Empty;
		}

		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
			List<AudioClip> list;
			if (!PlaylistClipsByPlaylistName.ContainsKey(controllerName))
			{
				list = new List<AudioClip>(5);
				PlaylistClipsByPlaylistName.Add(controllerName, list);
			}
			else
			{
				list = PlaylistClipsByPlaylistName[controllerName];
			}
			list.Add(resAudioClip);
		}

		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			ResourceRequest asyncRes = Resources.LoadAsync(songResourceName, typeof(AudioClip));
			while (!asyncRes.isDone)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
			AudioClip audioClip = asyncRes.asset as AudioClip;
			if (audioClip == null)
			{
				MasterAudio.LogWarning("Resource file '" + songResourceName + "' could not be located from Playlist '" + playlistName + "'.");
				yield break;
			}
			if (!AudioUtil.AudioClipWillPreload(audioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + songResourceName + "' from Playlist '" + playlistName + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			FinishRecordingPlaylistClip(controller.ControllerName, audioClip);
			controller.FinishLoadingNewSong(songSetting, audioClip, playType);
		}

		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			if (AudioClipsByName.ContainsKey(clipName))
			{
				successAction?.Invoke();
				yield break;
			}
			ResourceRequest asyncRes = Resources.LoadAsync(clipName, typeof(AudioClip));
			while (!asyncRes.isDone)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
			AudioClip audioClip = asyncRes.asset as AudioClip;
			if (audioClip == null)
			{
				MasterAudio.LogError("Resource file '" + clipName + "' could not be located.");
				failureAction?.Invoke();
				yield break;
			}
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				MasterAudio.LogError("No Audio Sources found to add Resource file '" + clipName + "'.");
				failureAction?.Invoke();
				yield break;
			}
			if (!AudioUtil.AudioClipWillPreload(audioClip))
			{
				MasterAudio.LogWarning("Audio Clip for Resource file '" + clipName + "' of Sound Group '" + variation.ParentGroup.name + "' has 'Preload Audio Data' turned off, which can cause audio glitches. Resource files should always Preload Audio Data. Please turn it on.");
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			for (int i = 0; i < list.Count; i++)
			{
				list[i].clip = audioClip;
			}
			if (!AudioClipsByName.ContainsKey(clipName))
			{
				AudioClipsByName.Add(clipName, audioClip);
			}
			successAction?.Invoke();
		}

		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
			if (clipToRemove == null || !PlaylistClipsByPlaylistName.ContainsKey(controllerName))
			{
				return;
			}
			List<AudioClip> list = PlaylistClipsByPlaylistName[controllerName];
			if (list.Contains(clipToRemove))
			{
				list.Remove(clipToRemove);
				if (!list.Contains(clipToRemove))
				{
					Resources.UnloadAsset(clipToRemove);
				}
			}
		}

		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
			if (!AudioResourceTargetsByName.ContainsKey(clipName))
			{
				MasterAudio.LogError("No Audio Sources found for Resource file '" + clipName + "'.");
				return;
			}
			List<AudioSource> list = AudioResourceTargetsByName[clipName];
			list.Remove(source);
			if (list.Count == 0)
			{
				AudioResourceTargetsByName.Remove(clipName);
			}
		}

		public static void UnloadClipIfUnused(string clipName)
		{
			if (!AudioClipsByName.ContainsKey(clipName))
			{
				return;
			}
			List<AudioSource> list = new List<AudioSource>();
			if (AudioResourceTargetsByName.ContainsKey(clipName))
			{
				list = AudioResourceTargetsByName[clipName];
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].GetComponent<SoundGroupVariation>().IsPlaying)
					{
						return;
					}
				}
			}
			AudioClip assetToUnload = AudioClipsByName[clipName];
			for (int j = 0; j < list.Count; j++)
			{
				list[j].clip = null;
			}
			AudioClipsByName.Remove(clipName);
			Resources.UnloadAsset(assetToUnload);
		}
	}
	[AudioScriptOrder(-50)]
	public class MasterAudio : MonoBehaviour
	{
		public enum AmbientSoundExitMode
		{
			StopSound,
			FadeSound
		}

		public enum AmbientSoundReEnterMode
		{
			StopExistingSound,
			FadeInSameSound
		}

		public enum VariationFollowerType
		{
			LateUpdate,
			FixedUpdate
		}

		public enum LinkedGroupSelectionType
		{
			All,
			OneAtRandom
		}

		public enum OcclusionSelectionType
		{
			AllGroups,
			TurnOnPerBusOrGroup
		}

		public enum RaycastMode
		{
			Physics3D,
			Physics2D
		}

		public enum AllMusicSpatialBlendType
		{
			ForceAllTo2D,
			ForceAllTo3D,
			ForceAllToCustom,
			AllowDifferentPerController
		}

		public enum AllMixerSpatialBlendType
		{
			ForceAllTo2D,
			ForceAllTo3D,
			ForceAllToCustom,
			AllowDifferentPerGroup
		}

		public enum ItemSpatialBlendType
		{
			ForceTo2D,
			ForceTo3D,
			ForceToCustom,
			UseCurveFromAudioSource
		}

		public enum MixerWidthMode
		{
			Narrow,
			Normal,
			Wide
		}

		public enum CustomEventReceiveMode
		{
			Always,
			WhenDistanceLessThan,
			WhenDistanceMoreThan,
			Never,
			OnSameGameObject,
			OnChildGameObject,
			OnParentGameObject,
			OnSameOrChildGameObject,
			OnSameOrParentGameObject
		}

		public enum EventReceiveFilter
		{
			All,
			Closest,
			Random
		}

		public enum VariationLoadStatus
		{
			None,
			Loading,
			Loaded,
			LoadFailed
		}

		public enum AudioLocation
		{
			Clip,
			ResourceFile
		}

		public enum CustomSongStartTimeMode
		{
			Beginning,
			SpecificTime,
			RandomTime
		}

		public enum BusCommand
		{
			None,
			FadeToVolume,
			Mute,
			Pause,
			Solo,
			Unmute,
			Unpause,
			Unsolo,
			Stop,
			ChangePitch,
			ToggleMute,
			StopBusOfTransform,
			PauseBusOfTransform,
			UnpauseBusOfTransform,
			GlideByPitch,
			StopOldBusVoices,
			FadeOutOldBusVoices
		}

		public enum DragGroupMode
		{
			OneGroupPerClip,
			OneGroupWithVariations
		}

		public enum EventSoundFunctionType
		{
			PlaySound,
			GroupControl,
			BusControl,
			PlaylistControl,
			CustomEventControl,
			GlobalControl,
			UnityMixerControl,
			PersistentSettingsControl
		}

		public enum LanguageMode
		{
			UseDeviceSetting,
			SpecificLanguage,
			DynamicallySet
		}

		public enum UnityMixerCommand
		{
			None,
			TransitionToSnapshot,
			TransitionToSnapshotBlend
		}

		public enum PlaylistCommand
		{
			None,
			ChangePlaylist,
			FadeToVolume,
			PlaySong,
			PlayRandomSong,
			PlayNextSong,
			Pause,
			Resume,
			Stop,
			Mute,
			Unmute,
			ToggleMute,
			Restart,
			Start,
			StopLoopingCurrentSong,
			StopPlaylistAfterCurrentSong,
			AddSongToQueue
		}

		public enum CustomEventCommand
		{
			None,
			FireEvent
		}

		public enum GlobalCommand
		{
			None,
			PauseMixer,
			UnpauseMixer,
			StopMixer,
			StopEverything,
			PauseEverything,
			UnpauseEverything,
			MuteEverything,
			UnmuteEverything,
			SetMasterMixerVolume,
			SetMasterPlaylistVolume
		}

		public enum SoundGroupCommand
		{
			None,
			FadeToVolume,
			FadeOutAllOfSound,
			Mute,
			Pause,
			Solo,
			StopAllOfSound,
			Unmute,
			Unpause,
			Unsolo,
			StopAllSoundsOfTransform,
			PauseAllSoundsOfTransform,
			UnpauseAllSoundsOfTransform,
			StopSoundGroupOfTransform,
			PauseSoundGroupOfTransform,
			UnpauseSoundGroupOfTransform,
			FadeOutSoundGroupOfTransform,
			RefillSoundGroupPool,
			RouteToBus,
			GlideByPitch,
			ToggleSoundGroup,
			ToggleSoundGroupOfTransform,
			FadeOutAllSoundsOfTransform,
			StopOldSoundGroupVoices,
			FadeOutOldSoundGroupVoices
		}

		public enum PersistentSettingsCommand
		{
			None,
			SetBusVolume,
			SetGroupVolume,
			SetMixerVolume,
			SetMusicVolume,
			MixerMuteToggle,
			MusicMuteToggle
		}

		public enum SongFadeInPosition
		{
			NewClipFromBeginning = 1,
			NewClipFromLastKnownPosition = 3,
			SynchronizeClips = 5
		}

		public enum SoundSpawnLocationMode
		{
			MasterAudioLocation,
			CallerLocation,
			AttachToCaller
		}

		public enum VariationCommand
		{
			None,
			Stop,
			Pause,
			Unpause
		}

		[Serializable]
		public struct CustomEventCandidate
		{
			public float DistanceAway;

			public ICustomEventReceiver Receiver;

			public Transform Trans;

			public int RandomId;

			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
				DistanceAway = distance;
				Receiver = rec;
				Trans = trans;
				RandomId = randomId;
			}
		}

		[Serializable]
		public class AudioGroupInfo
		{
			public List<AudioInfo> Sources;

			public int LastFramePlayed;

			public float LastTimePlayed;

			public MasterAudioGroup Group;

			public bool PlayedForWarming;

			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
				Sources = sources;
				LastFramePlayed = -50;
				LastTimePlayed = -50f;
				Group = groupScript;
				PlayedForWarming = false;
			}
		}

		[Serializable]
		public class AudioInfo
		{
			public AudioSource Source;

			public float OriginalVolume;

			public float LastPercentageVolume;

			public float LastRandomVolume;

			public SoundGroupVariation Variation;

			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
				Variation = variation;
				Source = source;
				OriginalVolume = origVol;
				LastPercentageVolume = 1f;
				LastRandomVolume = 0f;
			}
		}

		[Serializable]
		public class Playlist
		{
			public enum CrossfadeTimeMode
			{
				UseMasterSetting,
				Override
			}

			public bool isExpanded = true;

			public string playlistName = "new playlist";

			public SongFadeInPosition songTransitionType = SongFadeInPosition.NewClipFromBeginning;

			public List<MusicSetting> MusicSettings;

			public AudioLocation bulkLocationMode;

			public CrossfadeTimeMode crossfadeMode;

			public float crossFadeTime = 1f;

			public bool fadeInFirstSong;

			public bool fadeOutLastSong;

			public bool bulkEditMode;

			public bool isTemporary;

			public bool showMetadata;

			public List<SongMetadataProperty> songMetadataProps = new List<SongMetadataProperty>();

			public string newMetadataPropName = "PropertyName";

			public SongMetadataProperty.MetadataPropertyType newMetadataPropType = SongMetadataProperty.MetadataPropertyType.String;

			public bool newMetadataPropRequired = true;

			public bool newMetadataPropCanHaveMult;

			public Playlist()
			{
				MusicSettings = new List<MusicSetting>();
			}
		}

		[Serializable]
		public class SoundGroupRefillInfo
		{
			public float LastTimePlayed;

			public float InactivePeriodSeconds;

			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
				LastTimePlayed = lastTimePlayed;
				InactivePeriodSeconds = inactivePeriodSeconds;
			}
		}

		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		public const string NoCategory = "[Uncategorized]";

		public const float SemiTonePitchFactor = 1.05946f;

		public const float SpatialBlend_2DValue = 0f;

		public const float SpatialBlend_3DValue = 1f;

		public const float MaxCrossFadeTimeSeconds = 120f;

		public const float DefaultDuckVolCut = -6f;

		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		public const int PHYSICS_DISABLED = 2;

		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		public static readonly YieldInstruction EndOfFrameDelay = new WaitForEndOfFrame();

		public static readonly List<string> ExemptChildNames = new List<string> { "_Followers" };

		public static readonly HashSet<int> ErrorNumbersLogged = new HashSet<int>();

		public static Action NumberOfAudioSourcesChanged;

		public const int HardCodedBusOptions = 2;

		public const string AllBusesName = "[All]";

		public const string NoGroupName = "[None]";

		public const string DynamicGroupName = "[Type In]";

		public const string NoPlaylistName = "[No Playlist]";

		public const string NoVoiceLimitName = "[NO LMT]";

		public const string OnlyPlaylistControllerName = "~only~";

		public const float InnerLoopCheckInterval = 0.1f;

		private const int MaxComponents = 20;

		public AudioLocation bulkLocationMode;

		public string groupTemplateName = "Default Single";

		public string audioSourceTemplateName = "Max Distance 500";

		public bool showGroupCreation = true;

		public bool useGroupTemplates;

		public DragGroupMode curDragGroupMode;

		public List<GameObject> groupTemplates = new List<GameObject>(10);

		public List<GameObject> audioSourceTemplates = new List<GameObject>(10);

		public bool mixerMuted;

		public bool playlistsMuted;

		public LanguageMode langMode;

		public SystemLanguage testLanguage = SystemLanguage.English;

		public SystemLanguage defaultLanguage = SystemLanguage.English;

		public List<SystemLanguage> supportedLanguages = new List<SystemLanguage> { SystemLanguage.English };

		public string busFilter = string.Empty;

		public bool useTextGroupFilter;

		public string textGroupFilter = string.Empty;

		public bool resourceClipsPauseDoNotUnload;

		public Transform playlistControllerPrefab;

		public bool persistBetweenScenes;

		public bool shouldLogDestroys;

		public bool showBusColors;

		public bool areGroupsExpanded = true;

		public Transform soundGroupTemplate;

		public Transform soundGroupVariationTemplate;

		public List<GroupBus> groupBuses = new List<GroupBus>();

		public bool groupByBus = true;

		public bool sortAlpha = true;

		public bool showRangeSoundGizmos = true;

		public bool showSelectedRangeSoundGizmos = true;

		public Color rangeGizmoColor = Color.green;

		public Color selectedRangeGizmoColor = Color.cyan;

		public bool showAdvancedSettings = true;

		public bool showLocalization = true;

		public bool playListExpanded = true;

		public bool playlistsExpanded = true;

		public AllMusicSpatialBlendType musicSpatialBlendType;

		public float musicSpatialBlend;

		public AllMixerSpatialBlendType mixerSpatialBlendType = AllMixerSpatialBlendType.ForceAllTo3D;

		public float mixerSpatialBlend = 1f;

		public ItemSpatialBlendType newGroupSpatialType = ItemSpatialBlendType.ForceTo3D;

		public float newGroupSpatialBlend = 1f;

		public List<Playlist> musicPlaylists = new List<Playlist>
		{
			new Playlist()
		};

		public float _masterAudioVolume = 1f;

		public bool vrSettingsExpanded;

		public bool useSpatializer;

		public bool useSpatializerPostFX;

		public bool addOculusAudioSources;

		public bool addResonanceAudioSources;

		public bool ignoreTimeScale;

		public bool useGaplessPlaylists;

		public bool saveRuntimeChanges;

		public bool prioritizeOnDistance;

		public int rePrioritizeEverySecIndex = 1;

		public bool useOcclusion;

		public float occlusionMaxCutoffFreq;

		public float occlusionMinCutoffFreq = 22000f;

		public float occlusionFreqChangeSeconds;

		public OcclusionSelectionType occlusionSelectType;

		public int occlusionMaxRayCastsPerFrame = 4;

		public float occlusionRayCastOffset;

		public bool occlusionUseLayerMask;

		public LayerMask occlusionLayerMask;

		public bool occlusionShowRaycasts = true;

		public bool occlusionShowCategories;

		public RaycastMode occlusionRaycastMode;

		public bool occlusionIncludeStartRaycast2DCollider = true;

		public bool occlusionRaycastsHitTriggers = true;

		public bool ambientAdvancedExpanded;

		public int ambientMaxRecalcsPerFrame = 4;

		public bool visualAdvancedExpanded = true;

		public bool logAdvancedExpanded = true;

		public bool listenerAdvancedExpanded;

		public bool listenerFollowerHasRigidBody = true;

		public VariationFollowerType variationFollowerType;

		public bool showFadingSettings;

		public bool stopZeroVolumeGroups;

		public bool stopZeroVolumeBuses;

		public bool stopZeroVolumePlaylists;

		public float stopOldestBusFadeTime = 0.3f;

		public bool resourceAdvancedExpanded = true;

		public bool useClipAgePriority;

		public bool logOutOfVoices = true;

		public bool LogSounds;

		public bool logCustomEvents;

		public bool disableLogging;

		public bool showMusicDucking;

		public bool enableMusicDucking = true;

		public List<DuckGroupInfo> musicDuckingSounds = new List<DuckGroupInfo>();

		public float defaultRiseVolStart = 0.5f;

		public float defaultUnduckTime = 1f;

		public float defaultDuckedVolumeCut = -6f;

		public float crossFadeTime = 1f;

		public float _masterPlaylistVolume = 1f;

		public bool showGroupSelect;

		public bool hideGroupsWithNoActiveVars;

		public bool logPerfExpanded = true;

		public bool willWarm = true;

		public string newEventName = "my event";

		public bool showCustomEvents = true;

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		public List<CustomEvent> customEvents = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public Dictionary<string, DuckGroupInfo> duckingBySoundType = new Dictionary<string, DuckGroupInfo>(StringComparer.OrdinalIgnoreCase);

		public int frames;

		public bool showUnityMixerGroupAssignment = true;

		public static readonly PlaySoundResult AndForgetSuccessResult = new PlaySoundResult
		{
			SoundPlayed = true
		};

		private static readonly PlaySoundResult failedResultDuringInit = new PlaySoundResult
		{
			SoundPlayed = false
		};

		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType = new Dictionary<string, AudioGroupInfo>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizer = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizerOrigin = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _randomizerLeftovers = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);

		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters = new List<SoundGroupVariationUpdater>(32);

		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove = new List<SoundGroupVariationUpdater>();

		private readonly List<CustomEventCandidate> ValidReceivers = new List<CustomEventCandidate>(10);

		private readonly List<MasterAudioGroup> SoloedGroups = new List<MasterAudioGroup>();

		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger = new List<AmbientSoundToTriggerInfo>();

		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire = new Queue<CustomEventToFireInfo>(32);

		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs = new Queue<TransformFollower>(32);

		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs = new List<TransformFollower>(32);

		private readonly List<BusFadeInfo> BusFades = new List<BusFadeInfo>();

		private readonly List<GroupFadeInfo> GroupFades = new List<GroupFadeInfo>();

		private readonly List<GroupPitchGlideInfo> GroupPitchGlides = new List<GroupPitchGlideInfo>();

		private readonly List<BusPitchGlideInfo> BusPitchGlides = new List<BusPitchGlideInfo>();

		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges = new List<OcclusionFreqChangeInfo>();

		private readonly List<AudioSource> AllAudioSources = new List<AudioSource>(100);

		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName = new Dictionary<string, Dictionary<ICustomEventReceiver, Transform>>(StringComparer.OrdinalIgnoreCase);

		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName = new Dictionary<string, PlaylistController>(StringComparer.OrdinalIgnoreCase);

		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed = new Dictionary<string, SoundGroupRefillInfo>(StringComparer.OrdinalIgnoreCase);

		private readonly List<GameObject> OcclusionSourcesInRange = new List<GameObject>(32);

		private readonly List<GameObject> OcclusionSourcesOutOfRange = new List<GameObject>(32);

		private readonly List<GameObject> OcclusionSourcesBlocked = new List<GameObject>(32);

		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays = new Queue<SoundGroupVariationUpdater>(32);

		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop = new List<SoundGroupVariation>(16);

		private bool _isStoppingMultiple;

		private float _repriTime = -1f;

		private List<string> _groupsToRemove;

		private bool _mustRescanGroups;

		private Transform _trans;

		private bool _soundsLoaded;

		private bool _warming;

		private static MasterAudio _instance;

		private static string _prospectiveMAFolder = string.Empty;

		private static Transform _listenerTrans;

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector = new List<SoundGroupCommand>
		{
			SoundGroupCommand.None,
			SoundGroupCommand.PauseAllSoundsOfTransform,
			SoundGroupCommand.StopAllSoundsOfTransform,
			SoundGroupCommand.UnpauseAllSoundsOfTransform,
			SoundGroupCommand.FadeOutAllSoundsOfTransform
		};

		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector = new List<SoundGroupCommand>
		{
			SoundGroupCommand.None,
			SoundGroupCommand.FadeOutSoundGroupOfTransform,
			SoundGroupCommand.PauseSoundGroupOfTransform,
			SoundGroupCommand.UnpauseSoundGroupOfTransform,
			SoundGroupCommand.StopSoundGroupOfTransform,
			SoundGroupCommand.ToggleSoundGroupOfTransform,
			SoundGroupCommand.ToggleSoundGroup,
			SoundGroupCommand.FadeOutAllSoundsOfTransform
		};

		public static float PlaylistMasterVolume
		{
			get
			{
				return Instance._masterPlaylistVolume;
			}
			set
			{
				Instance._masterPlaylistVolume = value;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					instances[i].UpdateMasterVolume();
				}
			}
		}

		public static bool LogSoundsEnabled
		{
			get
			{
				return Instance.LogSounds;
			}
			set
			{
				Instance.LogSounds = value;
			}
		}

		public static bool LogOutOfVoices
		{
			get
			{
				return Instance.logOutOfVoices;
			}
			set
			{
				Instance.logOutOfVoices = value;
			}
		}

		public static List<AudioSource> MasterAudioSources => Instance.AllAudioSources;

		public static Transform ListenerTrans
		{
			get
			{
				if (_listenerTrans == null || !DTMonoHelper.IsActive(_listenerTrans.gameObject))
				{
					_listenerTrans = null;
					AudioListener[] array = UnityEngine.Object.FindObjectsOfType<AudioListener>();
					foreach (AudioListener audioListener in array)
					{
						if (DTMonoHelper.IsActive(audioListener.gameObject))
						{
							_listenerTrans = audioListener.transform;
						}
					}
				}
				return _listenerTrans;
			}
		}

		public static PlaylistController OnlyPlaylistController
		{
			get
			{
				List<PlaylistController> instances = PlaylistController.Instances;
				if (instances.Count != 0)
				{
					return instances[0];
				}
				UnityEngine.Debug.LogError("There are no Playlist Controller in this Scene.");
				return null;
			}
		}

		public static bool IsWarming
		{
			get
			{
				if (SafeInstance != null)
				{
					return Instance._warming;
				}
				return false;
			}
		}

		public static bool MixerMuted
		{
			get
			{
				return Instance.mixerMuted;
			}
			set
			{
				Instance.mixerMuted = value;
				if (value)
				{
					foreach (string key in Instance.AudioSourcesBySoundType.Keys)
					{
						MuteGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName, shouldCheckMuteStatus: false);
					}
				}
				else
				{
					foreach (string key2 in Instance.AudioSourcesBySoundType.Keys)
					{
						UnmuteGroup(Instance.AudioSourcesBySoundType[key2].Group.GameObjectName, shouldCheckMuteStatus: false);
					}
				}
				if (Application.isPlaying)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static bool PlaylistsMuted
		{
			get
			{
				return Instance.playlistsMuted;
			}
			set
			{
				Instance.playlistsMuted = value;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					if (value)
					{
						instances[i].MutePlaylist();
					}
					else
					{
						instances[i].UnmutePlaylist();
					}
				}
			}
		}

		public bool EnableMusicDucking
		{
			get
			{
				return enableMusicDucking;
			}
			set
			{
				enableMusicDucking = value;
			}
		}

		public float MasterCrossFadeTime => crossFadeTime;

		public static List<Playlist> MusicPlaylists => Instance.musicPlaylists;

		public static List<GroupBus> GroupBuses => Instance.groupBuses;

		public static List<string> RuntimeSoundGroupNames
		{
			get
			{
				if (!Application.isPlaying)
				{
					return new List<string>();
				}
				return new List<string>(Instance.AudioSourcesBySoundType.Keys);
			}
		}

		public static List<string> RuntimeBusNames
		{
			get
			{
				if (!Application.isPlaying)
				{
					return new List<string>();
				}
				List<string> list = new List<string>();
				for (int i = 0; i < Instance.groupBuses.Count; i++)
				{
					list.Add(Instance.groupBuses[i].busName);
				}
				return list;
			}
		}

		public static MasterAudio SafeInstance
		{
			get
			{
				if (_instance != null)
				{
					return _instance;
				}
				_instance = (MasterAudio)UnityEngine.Object.FindObjectOfType(typeof(MasterAudio));
				return _instance;
			}
		}

		public static MasterAudio Instance
		{
			get
			{
				if (_instance != null)
				{
					return _instance;
				}
				_instance = (MasterAudio)UnityEngine.Object.FindObjectOfType(typeof(MasterAudio));
				if (_instance == null && Application.isPlaying)
				{
					UnityEngine.Debug.LogError("There is no Master Audio prefab in this Scene. Subsequent method calls will fail.");
				}
				return _instance;
			}
			set
			{
				_instance = null;
			}
		}

		public static bool SoundsReady
		{
			get
			{
				if (Instance != null)
				{
					return Instance._soundsLoaded;
				}
				return false;
			}
		}

		public static bool AppIsShuttingDown { get; set; }

		public List<string> GroupNames
		{
			get
			{
				List<string> soundGroupHardCodedNames = SoundGroupHardCodedNames;
				List<string> list = new List<string>(Trans.childCount);
				for (int i = 0; i < Trans.childCount; i++)
				{
					string item = Trans.GetChild(i).name;
					if (!ArrayListUtil.IsExcludedChildName(item))
					{
						list.Add(item);
					}
				}
				DynamicSoundGroupCreator[] array = UnityEngine.Object.FindObjectsOfType(typeof(DynamicSoundGroupCreator)) as DynamicSoundGroupCreator[];
				for (int j = 0; j < array.Length; j++)
				{
					Transform transform = array[j].transform;
					for (int k = 0; k < transform.childCount; k++)
					{
						DynamicSoundGroup component = transform.GetChild(k).GetComponent<DynamicSoundGroup>();
						if (!(component == null) && !list.Contains(component.name))
						{
							list.Add(component.name);
						}
					}
				}
				list.Sort();
				soundGroupHardCodedNames.AddRange(list);
				return soundGroupHardCodedNames;
			}
		}

		public static List<string> SoundGroupHardCodedNames => new List<string> { "[Type In]", "[None]" };

		public List<string> BusNames
		{
			get
			{
				List<string> list = new List<string> { "[Type In]", "[None]" };
				for (int i = 0; i < groupBuses.Count; i++)
				{
					list.Add(groupBuses[i].busName);
				}
				return list;
			}
		}

		public List<string> PlaylistNames
		{
			get
			{
				List<string> list = new List<string> { "[Type In]", "[No Playlist]" };
				for (int i = 0; i < musicPlaylists.Count; i++)
				{
					list.Add(musicPlaylists[i].playlistName);
				}
				return list;
			}
		}

		public List<string> PlaylistNamesOnly
		{
			get
			{
				List<string> list = new List<string>(musicPlaylists.Count);
				for (int i = 0; i < musicPlaylists.Count; i++)
				{
					list.Add(musicPlaylists[i].playlistName);
				}
				return list;
			}
		}

		public Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = GetComponent<Transform>();
				return _trans;
			}
		}

		public bool ShouldShowUnityAudioMixerGroupAssignments => showUnityMixerGroupAssignment;

		public List<string> CustomEventNames
		{
			get
			{
				List<string> customEventHardCodedNames = CustomEventHardCodedNames;
				List<CustomEvent> list = Instance.customEvents;
				for (int i = 0; i < list.Count; i++)
				{
					customEventHardCodedNames.Add(list[i].EventName);
				}
				return customEventHardCodedNames;
			}
		}

		public List<string> CustomEventNamesOnly
		{
			get
			{
				List<string> list = new List<string>(customEvents.Count);
				List<CustomEvent> list2 = Instance.customEvents;
				for (int i = 0; i < list2.Count; i++)
				{
					list.Add(list2[i].EventName);
				}
				return list;
			}
		}

		public static List<string> CustomEventHardCodedNames => new List<string> { "[Type In]", "[None]" };

		public static float MasterVolumeLevel
		{
			get
			{
				return Instance._masterAudioVolume;
			}
			set
			{
				Instance._masterAudioVolume = value;
				if (Application.isPlaying)
				{
					Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
					while (enumerator.MoveNext())
					{
						MasterAudioGroup group = enumerator.Current.Value.Group;
						SetGroupVolume(group.GameObjectName, group.groupMasterVolume);
					}
				}
			}
		}

		private static bool SceneHasMasterAudio => Instance != null;

		public static bool IgnoreTimeScale => Instance.ignoreTimeScale;

		public static SystemLanguage DynamicLanguage
		{
			get
			{
				if (!PlayerPrefs.HasKey("~MA_Language_Key~") || string.IsNullOrEmpty(PlayerPrefs.GetString("~MA_Language_Key~")))
				{
					PlayerPrefs.SetString("~MA_Language_Key~", SystemLanguage.Unknown.ToString());
				}
				return (SystemLanguage)Enum.Parse(typeof(SystemLanguage), PlayerPrefs.GetString("~MA_Language_Key~"));
			}
			set
			{
				PlayerPrefs.SetString("~MA_Language_Key~", value.ToString());
				AudioResourceOptimizer.ClearSupportLanguageFolder();
			}
		}

		public static float ReprioritizeTime
		{
			get
			{
				if (Instance._repriTime < 0f)
				{
					Instance._repriTime = (float)(Instance.rePrioritizeEverySecIndex + 1) * 0.1f;
				}
				return Instance._repriTime;
			}
		}

		public static bool ShouldRescanGroups
		{
			get
			{
				if (SafeInstance == null)
				{
					return false;
				}
				return Instance._mustRescanGroups;
			}
		}

		public static string ProspectiveMAPath
		{
			get
			{
				return _prospectiveMAFolder;
			}
			set
			{
				_prospectiveMAFolder = value;
			}
		}

		private void Awake()
		{
			UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(MasterAudio));
			if (array.Length > 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				bool flag = false;
				for (int i = 0; i < array.Length; i++)
				{
					MasterAudio masterAudio = array[i] as MasterAudio;
					if (masterAudio.persistBetweenScenes && masterAudio.shouldLogDestroys)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					UnityEngine.Debug.Log("More than one Master Audio prefab exists in this Scene. Destroying the newer one called '" + base.name + "'. You may wish to set up a Bootstrapper Scene so this does not occur.");
				}
				return;
			}
			base.useGUILayout = false;
			_soundsLoaded = false;
			_mustRescanGroups = false;
			Transform listenerTrans = ListenerTrans;
			if (listenerTrans != null)
			{
				AudioSource component = listenerTrans.GetComponent<AudioSource>();
				if (component != null)
				{
					UnityEngine.Object.Destroy(component);
				}
			}
			AmbientUtil.InitFollowerHolder();
			AudioSourcesBySoundType.Clear();
			PlaylistControllersByName.Clear();
			LastTimeSoundGroupPlayed.Clear();
			ErrorNumbersLogged.Clear();
			AllAudioSources.Clear();
			OcclusionSourcesInRange.Clear();
			OcclusionSourcesOutOfRange.Clear();
			OcclusionSourcesBlocked.Clear();
			QueuedOcclusionRays.Clear();
			TransFollowerColliderPositionRecalcs.Clear();
			CustomEventsToFire.Clear();
			AmbientsToDelayedTrigger.Clear();
			ProcessedColliderPositionRecalcs.Clear();
			ActiveVariationUpdaters.Clear();
			ActiveUpdatersToRemove.Clear();
			List<string> list = new List<string>();
			AudioResourceOptimizer.ClearAudioClips();
			PlaylistController.Instances = null;
			List<PlaylistController> instances = PlaylistController.Instances;
			for (int j = 0; j < instances.Count; j++)
			{
				PlaylistController playlistController = instances[j];
				if (list.Contains(playlistController.name))
				{
					UnityEngine.Debug.LogError("You have more than 1 Playlist Controller with the name '" + playlistController.name + "'. You must name them all uniquely or the same-named ones will be deleted once they awake.");
					continue;
				}
				list.Add(playlistController.name);
				PlaylistControllersByName.Add(playlistController.name, playlistController);
				if (persistBetweenScenes)
				{
					UnityEngine.Object.DontDestroyOnLoad(playlistController);
				}
			}
			if (persistBetweenScenes)
			{
				UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			}
			List<int> list2 = new List<int>();
			_randomizer = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_randomizerOrigin = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_randomizerLeftovers = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			_clipsPlayedBySoundTypeOldestFirst = new Dictionary<string, List<int>>(StringComparer.OrdinalIgnoreCase);
			List<SoundGroupVariation> list3 = new List<SoundGroupVariation>();
			_groupsToRemove = new List<string>(Trans.childCount);
			List<string> list4 = new List<string>();
			for (int k = 0; k < Trans.childCount; k++)
			{
				Transform child = Trans.GetChild(k);
				List<AudioInfo> list5 = new List<AudioInfo>();
				MasterAudioGroup component2 = child.GetComponent<MasterAudioGroup>();
				if (component2 == null)
				{
					if (!ArrayListUtil.IsExcludedChildName(child.name))
					{
						UnityEngine.Debug.LogError("MasterAudio could not find 'MasterAudioGroup' script for group '" + child.name + "'. Skipping this group.");
					}
					continue;
				}
				string text = child.name;
				List<Transform> list6 = new List<Transform>();
				List<int> list7 = new List<int>();
				for (int l = 0; l < child.childCount; l++)
				{
					Transform child2 = child.GetChild(l);
					SoundGroupVariation component3 = child2.GetComponent<SoundGroupVariation>();
					AudioSource component4 = child2.GetComponent<AudioSource>();
					int weight = component3.weight;
					for (int m = 0; m < weight; m++)
					{
						if (m > 0)
						{
							GameObject gameObject = UnityEngine.Object.Instantiate(child2.gameObject, child.transform.position, Quaternion.identity);
							gameObject.transform.name = child2.gameObject.name;
							SoundGroupVariation component5 = gameObject.GetComponent<SoundGroupVariation>();
							component5.weight = 1;
							list6.Add(gameObject.transform);
							component4 = gameObject.GetComponent<AudioSource>();
							list5.Add(new AudioInfo(component5, component4, component4.volume));
							list3.Add(component5);
							AudioLocation audLocation = component5.audLocation;
							if (audLocation == AudioLocation.ResourceFile)
							{
								AudioResourceOptimizer.AddTargetForClip(component5.resourceFileName, component4);
							}
						}
						else
						{
							list5.Add(new AudioInfo(component3, component4, component4.volume));
							list3.Add(component3);
							AudioLocation audLocation = component3.audLocation;
							if (audLocation == AudioLocation.ResourceFile)
							{
								AudioResourceOptimizer.AddTargetForClip(AudioResourceOptimizer.GetLocalizedFileName(component3.useLocalization, component3.resourceFileName), component4);
							}
						}
					}
				}
				for (int n = 0; n < list6.Count; n++)
				{
					list6[n].parent = child;
				}
				AudioGroupInfo audioGroupInfo = new AudioGroupInfo(list5, component2);
				if (component2.isSoloed)
				{
					SoloedGroups.Add(component2);
				}
				if (component2.isMuted)
				{
					if (list4.Contains(component2.name))
					{
						continue;
					}
					list4.Add(component2.name);
				}
				if (AudioSourcesBySoundType.ContainsKey(text))
				{
					UnityEngine.Debug.LogError("You have more than one SoundGroup named '" + text + "'. Ignoring the 2nd one. Please rename it.");
					continue;
				}
				audioGroupInfo.Group.OriginalVolume = audioGroupInfo.Group.groupMasterVolume;
				float? groupVolume = PersistentAudioSettings.GetGroupVolume(text);
				if (groupVolume.HasValue)
				{
					audioGroupInfo.Group.groupMasterVolume = groupVolume.Value;
				}
				AddRuntimeGroupInfo(text, audioGroupInfo);
				for (int num = 0; num < list5.Count; num++)
				{
					list2.Add(num);
				}
				if (audioGroupInfo.Group.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
				{
					ArrayListUtil.SortIntArray(ref list2);
				}
				_randomizer.Add(text, list2);
				list7.Clear();
				list7.AddRange(list2);
				_randomizerOrigin.Add(text, list7);
				_randomizerLeftovers.Add(text, new List<int>(list2.Count));
				_randomizerLeftovers[text].AddRange(list2);
				_clipsPlayedBySoundTypeOldestFirst.Add(text, new List<int>());
				list2 = new List<int>();
			}
			GroupFades.Clear();
			BusFades.Clear();
			GroupPitchGlides.Clear();
			BusPitchGlides.Clear();
			VariationOcclusionFreqChanges.Clear();
			for (int num2 = 0; num2 < groupBuses.Count; num2++)
			{
				GroupBus groupBus = groupBuses[num2];
				groupBus.OriginalVolume = groupBus.volume;
				string busName = groupBus.busName;
				float? busVolume = PersistentAudioSettings.GetBusVolume(busName);
				if (busVolume.HasValue)
				{
					SetBusVolumeByName(busName, busVolume.Value);
				}
			}
			duckingBySoundType.Clear();
			for (int num3 = 0; num3 < musicDuckingSounds.Count; num3++)
			{
				DuckGroupInfo duckGroupInfo = musicDuckingSounds[num3];
				if (duckingBySoundType.ContainsKey(duckGroupInfo.soundType))
				{
					UnityEngine.Debug.LogWarning("You have more than one Duck Group set up with the Sound Group '" + duckGroupInfo.soundType + "'. Please delete the duplicates before running again.");
				}
				else
				{
					duckingBySoundType.Add(duckGroupInfo.soundType, duckGroupInfo);
				}
			}
			_soundsLoaded = true;
			if (willWarm)
			{
				_warming = true;
				string text2 = SoundGroupForWarming();
				if (!string.IsNullOrEmpty(text2))
				{
					PlaySoundResult playSoundResult = PlaySound3DFollowTransform(text2, Trans, 0f);
					if (playSoundResult != null && playSoundResult.SoundPlayed)
					{
						playSoundResult.ActingVariation.Stop();
					}
				}
				FireCustomEvent("FakeEvent", _trans);
				for (int num4 = 0; num4 < customEvents.Count; num4++)
				{
					customEvents[num4].frameLastFired = -1;
				}
				frames = 0;
				UnityEngine.Object[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(EventSounds));
				if (array2.Length != 0)
				{
					EventSounds obj = array2[0] as EventSounds;
					obj.PlaySounds(obj.particleCollisionSound, EventSounds.EventType.UserDefinedEvent);
				}
				for (int num5 = 0; num5 < list4.Count; num5++)
				{
					MuteGroup(list4[num5], shouldCheckMuteStatus: false);
				}
				_warming = false;
			}
			for (int num6 = 0; num6 < list3.Count; num6++)
			{
				list3[num6].DisableUpdater();
			}
			AmbientUtil.InitListenerFollower();
			PersistentAudioSettings.RestoreMasterSettings();
		}

		private void Start()
		{
			if (musicPlaylists.Count > 0 && musicPlaylists[0].MusicSettings != null && musicPlaylists[0].MusicSettings.Count > 0 && musicPlaylists[0].MusicSettings[0].clip != null && PlaylistControllersByName.Count == 0)
			{
				UnityEngine.Debug.Log("No Playlist Controllers exist in the Scene. Music will not play.");
			}
		}

		private void OnDisable()
		{
			StopTrackingRuntimeAudioSources(GetComponentsInChildren<AudioSource>().ToList());
		}

		private void Update()
		{
			frames++;
			PerformOcclusionFrequencyChanges();
			PerformBusFades();
			PerformBusPitchGlides();
			PerformGroupFades();
			PerformGroupPitchGlides();
			PerformDelayedAmbientTriggers();
			RefillInactiveGroupPools();
			FireCustomEventsWaiting();
		}

		private void LateUpdate()
		{
			if (variationFollowerType == VariationFollowerType.LateUpdate)
			{
				ManualUpdate();
			}
		}

		private void FixedUpdate()
		{
			if (variationFollowerType == VariationFollowerType.FixedUpdate)
			{
				ManualUpdate();
			}
		}

		private void ManualUpdate()
		{
			RecalcClosestColliderPositions();
			AmbientUtil.ManualUpdate();
			UpdateActiveVariations();
		}

		public string SoundGroupForWarming()
		{
			string text = null;
			for (int i = 0; i < Trans.childCount; i++)
			{
				Transform child = Trans.GetChild(i);
				if (child.name == "_Followers")
				{
					continue;
				}
				if (text == null)
				{
					text = child.name;
				}
				for (int j = 0; j < child.childCount; j++)
				{
					SoundGroupVariation component = child.GetChild(j).GetComponent<SoundGroupVariation>();
					if (!(component == null) && component.audLocation == AudioLocation.Clip)
					{
						return child.name;
					}
				}
			}
			return text;
		}

		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
			if (!Instance.ActiveVariationUpdaters.Contains(updater))
			{
				Instance.ActiveVariationUpdaters.Add(updater);
			}
		}

		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
			Instance.ActiveVariationUpdaters.Remove(updater);
		}

		private void UpdateActiveVariations()
		{
			ActiveUpdatersToRemove.Clear();
			for (int i = 0; i < ActiveVariationUpdaters.Count; i++)
			{
				SoundGroupVariationUpdater soundGroupVariationUpdater = ActiveVariationUpdaters[i];
				if (soundGroupVariationUpdater == null || !soundGroupVariationUpdater.enabled)
				{
					ActiveUpdatersToRemove.Add(soundGroupVariationUpdater);
				}
				else
				{
					soundGroupVariationUpdater.ManualUpdate();
				}
			}
			for (int j = 0; j < ActiveUpdatersToRemove.Count; j++)
			{
				ActiveVariationUpdaters.Remove(ActiveUpdatersToRemove[j]);
			}
		}

		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
			if (!Instance.LastTimeSoundGroupPlayed.ContainsKey(sType))
			{
				Instance.LastTimeSoundGroupPlayed.Add(sType, new SoundGroupRefillInfo(Time.realtimeSinceStartup, inactivePeriodSeconds));
			}
			else
			{
				Instance.LastTimeSoundGroupPlayed[sType].LastTimePlayed = AudioUtil.Time;
			}
		}

		private static void RecalcClosestColliderPositions()
		{
			if (!AmbientUtil.HasListenerFollower)
			{
				AmbientUtil.InitListenerFollower();
			}
			Instance.ProcessedColliderPositionRecalcs.Clear();
			int count = Instance.TransFollowerColliderPositionRecalcs.Count;
			int num = 0;
			while (num < count && Instance.TransFollowerColliderPositionRecalcs.Count != 0)
			{
				TransformFollower transformFollower = Instance.TransFollowerColliderPositionRecalcs.Dequeue();
				if (!(transformFollower == null) && transformFollower.enabled)
				{
					bool num2 = transformFollower.RecalcClosestColliderPosition();
					Instance.ProcessedColliderPositionRecalcs.Add(transformFollower);
					if (num2)
					{
						num++;
					}
				}
			}
			for (int i = 0; i < Instance.ProcessedColliderPositionRecalcs.Count; i++)
			{
				Instance.TransFollowerColliderPositionRecalcs.Enqueue(Instance.ProcessedColliderPositionRecalcs[i]);
			}
		}

		private static void FireCustomEventsWaiting()
		{
			while (Instance.CustomEventsToFire.Count > 0)
			{
				CustomEventToFireInfo customEventToFireInfo = Instance.CustomEventsToFire.Dequeue();
				FireCustomEvent(customEventToFireInfo.eventName, customEventToFireInfo.eventOrigin);
			}
		}

		private static void RefillInactiveGroupPools()
		{
			Dictionary<string, SoundGroupRefillInfo>.Enumerator enumerator = Instance.LastTimeSoundGroupPlayed.GetEnumerator();
			if (Instance._groupsToRemove == null)
			{
				Instance._groupsToRemove = new List<string>();
			}
			Instance._groupsToRemove.Clear();
			while (enumerator.MoveNext())
			{
				KeyValuePair<string, SoundGroupRefillInfo> current = enumerator.Current;
				if (current.Value.LastTimePlayed + current.Value.InactivePeriodSeconds < AudioUtil.Time)
				{
					RefillSoundGroupPool(current.Key);
					Instance._groupsToRemove.Add(current.Key);
				}
			}
			for (int i = 0; i < Instance._groupsToRemove.Count; i++)
			{
				Instance.LastTimeSoundGroupPlayed.Remove(Instance._groupsToRemove[i]);
			}
		}

		private static void PerformOcclusionFrequencyChanges()
		{
			if (!AmbientUtil.HasListenerFollower)
			{
				AmbientUtil.InitListenerFollower();
			}
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				OcclusionFreqChangeInfo occlusionFreqChangeInfo = Instance.VariationOcclusionFreqChanges[i];
				if (occlusionFreqChangeInfo.IsActive)
				{
					float val = 1f - (occlusionFreqChangeInfo.CompletionTime - AudioUtil.Time) / (occlusionFreqChangeInfo.CompletionTime - occlusionFreqChangeInfo.StartTime);
					val = Math.Min(val, 1f);
					val = Math.Max(val, 0f);
					float val2 = occlusionFreqChangeInfo.StartFrequency + (occlusionFreqChangeInfo.TargetFrequency - occlusionFreqChangeInfo.StartFrequency) * val;
					val2 = ((!(occlusionFreqChangeInfo.TargetFrequency > occlusionFreqChangeInfo.StartFrequency)) ? Math.Max(val2, occlusionFreqChangeInfo.TargetFrequency) : Math.Min(val2, occlusionFreqChangeInfo.TargetFrequency));
					occlusionFreqChangeInfo.ActingVariation.LowPassFilter.cutoffFrequency = val2;
					if (!(AudioUtil.Time < occlusionFreqChangeInfo.CompletionTime))
					{
						occlusionFreqChangeInfo.IsActive = false;
					}
				}
			}
			Instance.VariationOcclusionFreqChanges.RemoveAll((OcclusionFreqChangeInfo obj) => !obj.IsActive);
		}

		private void PerformBusFades()
		{
			for (int i = 0; i < BusFades.Count; i++)
			{
				BusFadeInfo busFadeInfo = BusFades[i];
				if (!busFadeInfo.IsActive)
				{
					continue;
				}
				GroupBus actingBus = busFadeInfo.ActingBus;
				if (actingBus == null)
				{
					busFadeInfo.IsActive = false;
					continue;
				}
				float val = 1f - (busFadeInfo.CompletionTime - AudioUtil.Time) / (busFadeInfo.CompletionTime - busFadeInfo.StartTime);
				val = Math.Min(val, 1f);
				val = Math.Max(val, 0f);
				float val2 = busFadeInfo.StartVolume + (busFadeInfo.TargetVolume - busFadeInfo.StartVolume) * val;
				SetBusVolumeByName(newVolume: (!(busFadeInfo.TargetVolume > busFadeInfo.StartVolume)) ? Math.Max(val2, busFadeInfo.TargetVolume) : Math.Min(val2, busFadeInfo.TargetVolume), busName: actingBus.busName);
				if (!(AudioUtil.Time < busFadeInfo.CompletionTime))
				{
					busFadeInfo.IsActive = false;
					if (stopZeroVolumeBuses && busFadeInfo.TargetVolume == 0f)
					{
						StopBus(busFadeInfo.NameOfBus);
					}
					else if (busFadeInfo.WillStopGroupAfterFade)
					{
						StopBus(busFadeInfo.NameOfBus);
					}
					if (busFadeInfo.WillResetVolumeAfterFade)
					{
						SetBusVolumeByName(actingBus.busName, busFadeInfo.StartVolume);
					}
					if (busFadeInfo.completionAction != null)
					{
						busFadeInfo.completionAction();
					}
				}
			}
			BusFades.RemoveAll((BusFadeInfo obj) => !obj.IsActive);
		}

		private void PerformGroupFades()
		{
			for (int i = 0; i < GroupFades.Count; i++)
			{
				GroupFadeInfo groupFadeInfo = GroupFades[i];
				if (!groupFadeInfo.IsActive)
				{
					continue;
				}
				MasterAudioGroup actingGroup = groupFadeInfo.ActingGroup;
				if (actingGroup == null)
				{
					groupFadeInfo.IsActive = false;
					continue;
				}
				float val = 1f - (groupFadeInfo.CompletionTime - AudioUtil.Time) / (groupFadeInfo.CompletionTime - groupFadeInfo.StartTime);
				val = Math.Min(val, 1f);
				val = Math.Max(val, 0f);
				float val2 = groupFadeInfo.StartVolume + (groupFadeInfo.TargetVolume - groupFadeInfo.StartVolume) * val;
				SetGroupVolume(volumeLevel: (!(groupFadeInfo.TargetVolume > groupFadeInfo.StartVolume)) ? Math.Max(val2, groupFadeInfo.TargetVolume) : Math.Min(val2, groupFadeInfo.TargetVolume), sType: actingGroup.GameObjectName);
				if (!(AudioUtil.Time < groupFadeInfo.CompletionTime))
				{
					groupFadeInfo.IsActive = false;
					if (groupFadeInfo.completionAction != null)
					{
						groupFadeInfo.completionAction();
					}
					if (stopZeroVolumeGroups && groupFadeInfo.TargetVolume == 0f)
					{
						StopAllOfSound(groupFadeInfo.NameOfGroup);
					}
					else if (groupFadeInfo.WillStopGroupAfterFade)
					{
						StopAllOfSound(groupFadeInfo.NameOfGroup);
					}
					if (groupFadeInfo.WillResetVolumeAfterFade)
					{
						SetGroupVolume(actingGroup.GameObjectName, groupFadeInfo.StartVolume);
					}
				}
			}
			GroupFades.RemoveAll((GroupFadeInfo obj) => !obj.IsActive);
		}

		public static void PerformDelayedAmbientTriggers()
		{
			if (AppIsShuttingDown || Instance.AmbientsToDelayedTrigger.Count == 0)
			{
				return;
			}
			List<AmbientSoundToTriggerInfo> list = Instance.AmbientsToDelayedTrigger.FindAll((AmbientSoundToTriggerInfo obj) => Time.frameCount >= obj.frameToTrigger);
			if (list.Count == 0)
			{
				return;
			}
			foreach (AmbientSoundToTriggerInfo item in list)
			{
				if (item.ambient != null)
				{
					item.ambient.StartTrackers();
				}
				Instance.AmbientsToDelayedTrigger.Remove(item);
			}
		}

		private void PerformGroupPitchGlides()
		{
			for (int i = 0; i < GroupPitchGlides.Count; i++)
			{
				GroupPitchGlideInfo groupPitchGlideInfo = GroupPitchGlides[i];
				if (!groupPitchGlideInfo.IsActive)
				{
					continue;
				}
				if (groupPitchGlideInfo.ActingGroup == null)
				{
					groupPitchGlideInfo.IsActive = false;
				}
				else if (!(AudioUtil.Time < groupPitchGlideInfo.CompletionTime))
				{
					groupPitchGlideInfo.IsActive = false;
					if (groupPitchGlideInfo.completionAction != null)
					{
						groupPitchGlideInfo.completionAction();
						groupPitchGlideInfo.completionAction = null;
					}
				}
			}
			GroupPitchGlides.RemoveAll((GroupPitchGlideInfo obj) => !obj.IsActive);
		}

		private void PerformBusPitchGlides()
		{
			for (int i = 0; i < BusPitchGlides.Count; i++)
			{
				BusPitchGlideInfo busPitchGlideInfo = BusPitchGlides[i];
				if (!busPitchGlideInfo.IsActive)
				{
					continue;
				}
				if (GetBusIndex(busPitchGlideInfo.NameOfBus, alertMissing: true) < 0)
				{
					busPitchGlideInfo.IsActive = false;
				}
				else if (!(AudioUtil.Time < busPitchGlideInfo.CompletionTime))
				{
					busPitchGlideInfo.IsActive = false;
					if (busPitchGlideInfo.completionAction != null)
					{
						busPitchGlideInfo.completionAction();
						busPitchGlideInfo.completionAction = null;
					}
				}
			}
			BusPitchGlides.RemoveAll((BusPitchGlideInfo obj) => !obj.IsActive);
		}

		private void OnApplicationQuit()
		{
			AppIsShuttingDown = true;
		}

		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			return PSRAsSuccessBool(PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime));
		}

		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return failedResultDuringInit;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return failedResultDuringInit;
		}

		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			return PSRAsSuccessBool(PlaySoundAtVolume(sType, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: true));
		}

		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return failedResultDuringInit;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, sourcePosition, timeToSchedulePlay, pitch, null, variationName, attachToSource: false, delaySoundTime, useVector3: true, makePlaySoundResult: true);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return failedResultDuringInit;
		}

		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			return PSRAsSuccessBool(PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: false, delaySoundTime));
		}

		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return failedResultDuringInit;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: false, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return failedResultDuringInit;
		}

		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				return false;
			}
			return PSRAsSuccessBool(PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: true, delaySoundTime));
		}

		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (!SceneHasMasterAudio)
			{
				return failedResultDuringInit;
			}
			if (SoundsReady)
			{
				return PlaySoundAtVolume(sType, volumePercentage, Vector3.zero, timeToSchedulePlay, pitch, sourceTrans, variationName, attachToSource: true, delaySoundTime, useVector3: false, makePlaySoundResult: true, isChaining, isSingleSubscribedPlay);
			}
			UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
			return failedResultDuringInit;
		}

		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult playSoundResult = PlaySound(sType, volumePercentage, pitch, delaySoundTime, variationName, null, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (playSoundResult != null && !(playSoundResult.ActingVariation == null))
			{
				playSoundResult.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult playSoundResult = PlaySound3DAtTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (playSoundResult != null && !(playSoundResult.ActingVariation == null))
			{
				playSoundResult.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			if (!SceneHasMasterAudio)
			{
				yield break;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot play: " + sType);
				yield break;
			}
			PlaySoundResult playSoundResult = PlaySound3DFollowTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, isChaining: false, isSingleSubscribedPlay: true);
			bool done = false;
			if (playSoundResult != null && !(playSoundResult.ActingVariation == null))
			{
				playSoundResult.ActingVariation.SoundFinished += delegate
				{
					done = true;
				};
				while (!done)
				{
					yield return EndOfFrameDelay;
				}
				completedAction?.Invoke();
			}
		}

		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			if (psr != null)
			{
				if (!psr.SoundPlayed)
				{
					return psr.SoundScheduled;
				}
				return true;
			}
			return false;
		}

		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, float? pitch = null, Transform sourceTrans = null, string variationName = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (!SoundsReady || sType == string.Empty || sType == "[None]")
			{
				return null;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				string text = "MasterAudio could not find sound: " + sType + ". If your Scene just changed, this could happen when an OnDisable or OnInvisible event sound happened to a per-scene sound, which is expected.";
				if (sourceTrans != null)
				{
					text = text + " Triggered by prefab: " + sourceTrans.name;
				}
				LogWarning(text);
				return null;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			MasterAudioGroup group = audioGroupInfo.Group;
			bool flag = LoggingEnabledForGroup(group);
			if (Instance.mixerMuted)
			{
				if (flag)
				{
					LogMessage("MasterAudio playing sound: " + sType + " silently because the Mixer is muted.");
				}
			}
			else if (group.isMuted && flag)
			{
				LogMessage("MasterAudio playing sound: " + sType + " silently because the Group is muted.");
			}
			if (Instance.SoloedGroups.Count > 0 && !Instance.SoloedGroups.Contains(group) && flag)
			{
				LogMessage("MasterAudio playing sound: " + sType + " silently because there are one or more Groups soloed. This one is not.");
			}
			audioGroupInfo.PlayedForWarming = IsWarming;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal)
			{
				switch (group.limitMode)
				{
				case MasterAudioGroup.LimitMode.TimeBased:
					if (group.minimumTimeBetween > 0f && Time.realtimeSinceStartup < audioGroupInfo.LastTimePlayed + group.minimumTimeBetween)
					{
						if (flag)
						{
							LogMessage("MasterAudio skipped playing sound: " + sType + " due to Group's Min Seconds Between setting.");
						}
						return null;
					}
					break;
				case MasterAudioGroup.LimitMode.FrameBased:
					if (Time.frameCount - audioGroupInfo.LastFramePlayed < group.limitPerXFrames)
					{
						if (flag)
						{
							LogMessage("Master Audio skipped playing sound: " + sType + " due to Group's Per Frame Limit.");
						}
						return null;
					}
					break;
				}
			}
			SetLastPlayed(audioGroupInfo);
			List<AudioInfo> sources = audioGroupInfo.Sources;
			bool flag2 = string.IsNullOrEmpty(variationName);
			if (sources.Count == 0)
			{
				if (flag)
				{
					LogMessage("Sound Group {" + sType + "} has no active Variations.");
				}
				return null;
			}
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal && audioGroupInfo.Group.limitPolyphony)
			{
				int voiceLimitCount = audioGroupInfo.Group.voiceLimitCount;
				int num = 0;
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					if (audioGroupInfo.Sources[i].Source == null || !audioGroupInfo.Sources[i].Source.isPlaying)
					{
						continue;
					}
					num++;
					if (num >= voiceLimitCount)
					{
						if (flag || LogOutOfVoices)
						{
							LogMessage("Polyphony limit of group: " + audioGroupInfo.Group.GameObjectName + " exceeded. Will not play this sound for this instance.");
						}
						return null;
					}
				}
			}
			GroupBus busForGroup = audioGroupInfo.Group.BusForGroup;
			if (busForGroup != null && busForGroup.BusVoiceLimitReached)
			{
				if (!busForGroup.stopOldest)
				{
					if (flag || LogOutOfVoices)
					{
						LogMessage("Bus voice limit has been reached. Cannot play the sound: " + audioGroupInfo.Group.GameObjectName + " until one voice has stopped playing. You can turn on the 'Stop Oldest' option for the bus to change ");
					}
					return null;
				}
				StopOldestSoundOnBus(busForGroup);
			}
			AudioInfo audioInfo = null;
			bool isSingleVarLoop = false;
			if (sources.Count == 1)
			{
				if (flag)
				{
					LogMessage("Cueing only child of " + sType);
				}
				audioInfo = sources[0];
				if (group.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
				{
					isSingleVarLoop = true;
				}
			}
			List<int> list = null;
			int? randomIndex = null;
			List<int> list2 = null;
			int num2 = -1;
			if (audioInfo == null)
			{
				if (!Instance._randomizer.ContainsKey(sType))
				{
					UnityEngine.Debug.Log("Sound Group '" + sType + "' has no active Variations.");
					return null;
				}
				if (flag2)
				{
					list = Instance._randomizer[sType];
					randomIndex = 0;
					num2 = list[randomIndex.Value];
					audioInfo = sources[num2];
					list2 = Instance._randomizerLeftovers[sType];
					list2.Remove(num2);
					if (flag)
					{
						LogMessage($"Cueing child {list[randomIndex.Value]} of {sType}");
					}
				}
				else
				{
					bool flag3 = false;
					int num3 = 0;
					for (int j = 0; j < sources.Count; j++)
					{
						AudioInfo audioInfo2 = sources[j];
						if (!(audioInfo2.Source.name != variationName))
						{
							num3++;
							if (audioInfo2.Variation.IsAvailableToPlay)
							{
								audioInfo = audioInfo2;
								flag3 = true;
								num2 = j;
								break;
							}
						}
					}
					if (!flag3)
					{
						if (num3 == 0)
						{
							if (flag)
							{
								LogMessage("Can't find variation {" + variationName + "} of " + sType);
							}
						}
						else if (flag || LogOutOfVoices)
						{
							LogMessage("Can't find non-busy variation {" + variationName + "} of " + sType);
						}
						return null;
					}
					if (flag)
					{
						LogMessage($"Cueing child named '{variationName}' of {sType}");
					}
				}
			}
			if (audioInfo.Variation == null)
			{
				if (AppIsShuttingDown || audioInfo.Source == null)
				{
					return null;
				}
				SoundGroupVariation component = audioInfo.Source.GetComponent<SoundGroupVariation>();
				if (component == null)
				{
					return null;
				}
				audioInfo.Variation = component;
			}
			if (audioInfo.Variation.audLocation == AudioLocation.Clip && audioInfo.Variation.VarAudio.clip == null)
			{
				if (flag)
				{
					LogMessage($"Child named '{audioInfo.Variation.name}' of {sType} has no audio assigned to it so nothing will be played.");
				}
				RemoveClipAndRefillIfEmpty(audioGroupInfo, flag2, randomIndex, list, sType, num2, flag, isSingleVarLoop: false);
				MaybeChainNextVar(isChaining, audioInfo.Variation, volumePercentage, pitch, sourceTrans, attachToSource);
				return null;
			}
			if (audioInfo.Variation.probabilityToPlay < 100 && UnityEngine.Random.Range(0, 100) >= audioInfo.Variation.probabilityToPlay)
			{
				if (flag)
				{
					LogMessage($"Child named '{audioInfo.Variation.name}' of {sType} failed its Random number check for 'Probability to Play' to it so nothing will be played this time.");
				}
				MaybeChainNextVar(isChaining, audioInfo.Variation, volumePercentage, pitch, sourceTrans, attachToSource);
				return null;
			}
			if (audioGroupInfo.Group.curVariationMode == MasterAudioGroup.VariationMode.Dialog)
			{
				if (audioGroupInfo.Group.useDialogFadeOut)
				{
					FadeOutAllOfSound(audioGroupInfo.Group.GameObjectName, audioGroupInfo.Group.dialogFadeOutTime);
				}
				else
				{
					StopAllOfSound(audioGroupInfo.Group.GameObjectName);
				}
			}
			bool flag4 = false;
			bool forgetSoundPlayed = false;
			bool flag5 = false;
			bool flag6;
			PlaySoundResult playSoundResult;
			bool flag8;
			do
			{
				flag6 = false;
				playSoundResult = PlaySoundIfAvailable(audioInfo, sourcePosition, volumePercentage, ref forgetSoundPlayed, pitch, audioGroupInfo, sourceTrans, attachToSource, delaySoundTime, useVector3, makePlaySoundResult, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
				bool num4 = makePlaySoundResult && playSoundResult != null && (playSoundResult.SoundPlayed || playSoundResult.SoundScheduled);
				bool flag7 = !makePlaySoundResult && forgetSoundPlayed;
				flag8 = num4 || flag7;
				if (flag8)
				{
					flag4 = true;
					if (!IsWarming)
					{
						RemoveClipAndRefillIfEmpty(audioGroupInfo, flag2, randomIndex, list, sType, num2, flag, isSingleVarLoop);
					}
				}
				else if (flag2)
				{
					if (list2 == null)
					{
						continue;
					}
					if (list2.Count <= 0)
					{
						if (flag5)
						{
							continue;
						}
						RefillSoundGroupPool(sType);
						flag5 = true;
						list2.Clear();
						list2.AddRange(list);
					}
					audioInfo = sources[list2[0]];
					if (audioInfo.Variation == null)
					{
						SoundGroupVariation component2 = audioInfo.Source.GetComponent<SoundGroupVariation>();
						if (component2 == null)
						{
							break;
						}
						audioInfo.Variation = component2;
					}
					if (flag)
					{
						LogMessage("Child was busy. Cueing child {" + audioInfo.Source.name + "} of " + sType);
					}
					list2.RemoveAt(0);
					if (flag5 && list2.Count == 0)
					{
						flag6 = true;
					}
				}
				else
				{
					if (flag)
					{
						LogMessage("Child was busy. Since you wanted a named Variation, no others to try. Aborting.");
					}
					list2?.Clear();
				}
			}
			while (!flag4 && list2 != null && (list2.Count > 0 || !flag5 || flag6));
			if (!flag8)
			{
				if (flag || LogOutOfVoices)
				{
					LogMessage("All " + sources.Count + " children of " + sType + " were busy. Will not play this sound for this instance. If you need more voices, increase the 'Voices (Weight)' field on the Variation(s) in your Sound Group.");
				}
			}
			else
			{
				if (!triggeredAsChildGroup && !IsWarming)
				{
					switch (audioGroupInfo.Group.linkedStartGroupSelectionType)
					{
					case LinkedGroupSelectionType.All:
					{
						for (int k = 0; k < audioGroupInfo.Group.childSoundGroups.Count; k++)
						{
							PlaySoundAtVolume(audioGroupInfo.Group.childSoundGroups[k], volumePercentage, sourcePosition, timeToSchedulePlay, pitch, sourceTrans, null, attachToSource, delaySoundTime, useVector3, makePlaySoundResult: false, isChaining: false, isSingleSubscribedPlay: false, triggeredAsChildGroup: true);
						}
						break;
					}
					case LinkedGroupSelectionType.OneAtRandom:
					{
						int index = UnityEngine.Random.Range(0, audioGroupInfo.Group.childSoundGroups.Count);
						PlaySoundAtVolume(audioGroupInfo.Group.childSoundGroups[index], volumePercentage, sourcePosition, timeToSchedulePlay, pitch, sourceTrans, null, attachToSource, delaySoundTime, useVector3, makePlaySoundResult: false, isChaining: false, isSingleSubscribedPlay: false, triggeredAsChildGroup: true);
						break;
					}
					}
				}
				if (audioGroupInfo.Group.soundPlayedEventActive)
				{
					FireCustomEvent(audioGroupInfo.Group.soundPlayedCustomEvent, Instance._trans);
				}
			}
			if (!makePlaySoundResult && flag8)
			{
				return AndForgetSuccessResult;
			}
			return playSoundResult;
		}

		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
			if (isChaining)
			{
				variation.DoNextChain(volumePercentage, pitch, sourceTrans, attachToSource);
			}
		}

		private static void SetLastPlayed(AudioGroupInfo grp)
		{
			grp.LastTimePlayed = AudioUtil.Time;
			grp.LastFramePlayed = AudioUtil.FrameCount;
		}

		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
			if (isSingleVarLoop)
			{
				grp.Group.ChainLoopCount++;
				return;
			}
			if (isNonSpecific && randomIndex.HasValue)
			{
				choices.RemoveAt(randomIndex.Value);
				Instance._clipsPlayedBySoundTypeOldestFirst[sType].Add(pickedChoice);
				if (choices.Count == 0)
				{
					if (loggingEnabledForGrp)
					{
						LogMessage("Refilling Variation pool: " + sType);
					}
					RefillSoundGroupPool(sType);
				}
			}
			if (grp.Group.curVariationSequence == MasterAudioGroup.VariationSequence.TopToBottom && grp.Group.useInactivePeriodPoolRefill)
			{
				UpdateRefillTime(sType, grp.Group.inactivePeriodSeconds);
			}
		}

		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, float? pitch = null, AudioGroupInfo audioGroup = null, Transform sourceTrans = null, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, double? timeToSchedulePlay = null, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			if (info.Source == null)
			{
				return null;
			}
			if (info.Variation.LoadStatus == VariationLoadStatus.Loading)
			{
				return null;
			}
			MasterAudioGroup group = audioGroup.Group;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.Normal && info.Source.isPlaying && info.Variation.ClipIsLoaded)
			{
				float audioPlayedPercentage = AudioUtil.GetAudioPlayedPercentage(info.Source);
				int retriggerPercentage = group.retriggerPercentage;
				if (audioPlayedPercentage < (float)retriggerPercentage)
				{
					return null;
				}
			}
			info.Variation.Stop(stopEndDetection: false, skipLinked: true);
			info.Variation.ObjectToFollow = null;
			bool flag = Instance.prioritizeOnDistance && (Instance.useClipAgePriority || info.Variation.ParentGroup.useClipAgePriority);
			if (useVector3)
			{
				info.Source.transform.position = sourcePosition;
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set3DPriority(info.Variation, flag);
				}
			}
			else if (sourceTrans != null)
			{
				if (attachToSource)
				{
					info.Variation.ObjectToFollow = sourceTrans;
				}
				else
				{
					info.Source.transform.position = sourceTrans.position;
					info.Variation.ObjectToTriggerFrom = sourceTrans;
				}
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set3DPriority(info.Variation, flag);
				}
			}
			else
			{
				if (Instance.prioritizeOnDistance)
				{
					AudioPrioritizer.Set2DSoundPriority(info.Source);
				}
				info.Source.transform.localPosition = Vector3.zero;
			}
			float groupMasterVolume = group.groupMasterVolume;
			float busVolume = GetBusVolume(group);
			float num = info.OriginalVolume;
			float num2 = 0f;
			if (info.Variation.useRandomVolume)
			{
				num2 = UnityEngine.Random.Range(info.Variation.randomVolumeMin, info.Variation.randomVolumeMax);
				switch (info.Variation.randomVolumeMode)
				{
				case SoundGroupVariation.RandomVolumeMode.AddToClipVolume:
					num += num2;
					break;
				case SoundGroupVariation.RandomVolumeMode.IgnoreClipVolume:
					num = num2;
					break;
				}
			}
			float num3 = num * groupMasterVolume * busVolume * Instance._masterAudioVolume;
			float num4 = num3 * volumePercentage;
			info.Source.volume = num4;
			info.LastPercentageVolume = volumePercentage;
			info.LastRandomVolume = num2;
			if (!info.Variation.GameObj.activeInHierarchy)
			{
				DTMonoHelper.SetActive(info.Variation.GameObj, isActive: true);
				if (!info.Variation.GameObj.activeInHierarchy)
				{
					return null;
				}
				info.Variation.DisableUpdater();
			}
			PlaySoundResult playSoundResult = null;
			if (makePlaySoundResult)
			{
				playSoundResult = new PlaySoundResult
				{
					ActingVariation = info.Variation
				};
				if (delaySoundTime > 0f)
				{
					playSoundResult.SoundScheduled = true;
				}
				else
				{
					playSoundResult.SoundPlayed = true;
				}
			}
			else
			{
				forgetSoundPlayed = true;
			}
			string gameObjectName = group.GameObjectName;
			if (group.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
			{
				if (!isChaining)
				{
					group.ChainLoopCount = 0;
				}
				Transform objectToFollow = info.Variation.ObjectToFollow;
				if (group.ActiveVoices > 0 && !isChaining)
				{
					StopAllOfSound(gameObjectName);
				}
				info.Variation.ObjectToFollow = objectToFollow;
			}
			info.Variation.Play(pitch, num4, gameObjectName, volumePercentage, num3, pitch, sourceTrans, attachToSource, delaySoundTime, timeToSchedulePlay, isChaining, isSingleSubscribedPlay);
			if (Instance._isStoppingMultiple)
			{
				Instance.VariationsStartedDuringMultiStop.Add(info.Variation);
			}
			return playSoundResult;
		}

		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
			MasterAudio instance = Instance;
			if (instance.EnableMusicDucking && instance.duckingBySoundType.ContainsKey(soundGroupName) && !(aSource.clip == null))
			{
				DuckGroupInfo duckGroupInfo = instance.duckingBySoundType[soundGroupName];
				float length = aSource.clip.length;
				float pitch = aSource.pitch;
				List<PlaylistController> instances = PlaylistController.Instances;
				for (int i = 0; i < instances.Count; i++)
				{
					instances[i].DuckMusicForTime(length, duckGroupInfo.unduckTime, pitch, duckGroupInfo.riseVolStart, duckGroupInfo.duckedVolumeCut);
				}
			}
		}

		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
			MasterAudioGroup masterAudioGroup = null;
			for (int i = 0; i < varList.Count; i++)
			{
				SoundGroupVariation variation = varList[i].Variation;
				if (variation.WasTriggeredFromTransform(trans))
				{
					if (masterAudioGroup == null)
					{
						masterAudioGroup = GrabGroup(variation.ParentGroup.GameObjectName);
					}
					bool stopEndDetection = masterAudioGroup != null && masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
					switch (varCmd)
					{
					case VariationCommand.Stop:
						variation.Stop(stopEndDetection);
						break;
					case VariationCommand.Pause:
						variation.Pause();
						break;
					case VariationCommand.Unpause:
						variation.Unpause();
						break;
					}
				}
			}
		}

		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Stop);
			}
			Instance._isStoppingMultiple = false;
		}

		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio && !(sourceTrans == null))
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Stop);
			}
		}

		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Pause);
			}
		}

		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio && !(sourceTrans == null))
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Pause);
			}
		}

		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Unpause);
			}
		}

		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
			if (SceneHasMasterAudio && !(sourceTrans == null))
			{
				if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
				{
					UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
					return;
				}
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				StopPauseOrUnpauseSoundsOfTransform(sourceTrans, sources, VariationCommand.Unpause);
			}
		}

		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			List<SoundGroupVariation> allPlayingVariationsOfTransform = GetAllPlayingVariationsOfTransform(sourceTrans);
			HashSet<string> hashSet = new HashSet<string>();
			for (int i = 0; i < allPlayingVariationsOfTransform.Count; i++)
			{
				string text = allPlayingVariationsOfTransform[i].ParentGroup.name;
				if (!hashSet.Contains(text))
				{
					hashSet.Add(text);
					FadeOutSoundGroupOfTransform(sourceTrans, text, fadeTime);
				}
			}
		}

		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if (variation.WasTriggeredFromTransform(sourceTrans))
				{
					variation.FadeOutNow(fadeTime);
				}
			}
		}

		public static void StopAllOfSound(string sType)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			bool stopEndDetection = masterAudioGroup != null && masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain;
			foreach (AudioInfo item in sources)
			{
				if (!(item.Variation == null) && !IsLinkedGroupPlay(item.Variation))
				{
					item.Variation.Stop(stopEndDetection);
				}
			}
		}

		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			foreach (AudioInfo source in Instance.AudioSourcesBySoundType[sType].Sources)
			{
				source.Variation.FadeOutNow(fadeTime);
			}
		}

		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					if (variation.IsPlaying)
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return list;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					SoundGroupVariation variation = sources[i].Variation;
					if (variation.WasTriggeredFromTransform(sourceTrans))
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			if (!SceneHasMasterAudio)
			{
				return list;
			}
			HashSet<Transform> hashSet = new HashSet<Transform>();
			for (int i = 0; i < sourceTransList.Count; i++)
			{
				hashSet.Add(sourceTransList[i]);
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int j = 0; j < sources.Count; j++)
				{
					SoundGroupVariation variation = sources[j].Variation;
					if (variation.WasTriggeredFromAnyOfTransformMap(hashSet))
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(32);
			int busIndex = GetBusIndex(busName, alertMissing: false);
			if (busIndex < 0)
			{
				return list;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				if (value.Group.busIndex != busIndex)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if (variation.IsPlaying)
					{
						list.Add(variation);
					}
				}
			}
			return list;
		}

		public static void DeleteGroupVariation(string sType, string variationName)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot delete Variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			List<AudioInfo> list = new List<AudioInfo>();
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (!(audioInfo.Variation.name != variationName))
				{
					list.Add(audioInfo);
				}
			}
			if (list.Count == 0)
			{
				LogWarning("Could not find Variation for '" + sType + "' Group named '" + variationName + "'.\nWill not delete any Variations.");
				return;
			}
			for (int j = 0; j < list.Count; j++)
			{
				AudioInfo audioInfo2 = list[j];
				SoundGroupVariation variation = audioInfo2.Variation;
				variation.Stop();
				variation.DisableUpdater();
				AudioLocation audLocation = variation.audLocation;
				if (audLocation == AudioLocation.ResourceFile)
				{
					AudioResourceOptimizer.DeleteAudioSourceFromList((variation.VarAudio.clip == null) ? string.Empty : variation.VarAudio.clip.name, variation.VarAudio);
				}
				int num = audioGroupInfo.Sources.IndexOf(audioInfo2);
				if (num >= 0)
				{
					Instance._randomizer[sType].Remove(num);
					for (int k = 0; k < Instance._randomizer[sType].Count; k++)
					{
						if (Instance._randomizer[sType][k] > num)
						{
							Instance._randomizer[sType][k]--;
						}
					}
					Instance._randomizerOrigin[sType].Remove(num);
					for (int l = 0; l < Instance._randomizerOrigin[sType].Count; l++)
					{
						if (Instance._randomizerOrigin[sType][l] > num)
						{
							Instance._randomizerOrigin[sType][l]--;
						}
					}
					Instance._randomizerLeftovers[sType].Remove(num);
					for (int m = 0; m < Instance._randomizerLeftovers[sType].Count; m++)
					{
						if (Instance._randomizerLeftovers[sType][m] > num)
						{
							Instance._randomizerLeftovers[sType][m]--;
						}
					}
					Instance._clipsPlayedBySoundTypeOldestFirst[sType].Remove(num);
					audioGroupInfo.Sources.RemoveAt(num);
				}
				Instance.OcclusionSourcesInRange.Remove(variation.GameObj);
				Instance.OcclusionSourcesOutOfRange.Remove(variation.GameObj);
				Instance.OcclusionSourcesBlocked.Remove(variation.GameObj);
				RemoveFromOcclusionFrequencyTransitioning(variation);
				Instance.AllAudioSources.Remove(variation.VarAudio);
				UnityEngine.Object.Destroy(variation.GameObj);
			}
		}

		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			bool flag = false;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				if (!(audioGroupInfo.Sources[i].Variation.name != variationName))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				LogWarning("You already have a Variation for this Group named '" + variationName + "'. \n\nPlease rename these Variations when finished to be unique, or you may not be able to play them by name if you have a need to.");
			}
			GameObject obj = UnityEngine.Object.Instantiate(Instance.soundGroupVariationTemplate.gameObject, audioGroupInfo.Group.transform.position, Quaternion.identity);
			obj.transform.name = variationName;
			obj.transform.parent = audioGroupInfo.Group.transform;
			AudioSource component = obj.GetComponent<AudioSource>();
			component.clip = clip;
			component.pitch = pitch;
			Instance.AllAudioSources.Add(component);
			SoundGroupVariation component2 = obj.GetComponent<SoundGroupVariation>();
			component2.DisableUpdater();
			AudioInfo item = new AudioInfo(component2, component2.VarAudio, volume);
			audioGroupInfo.Sources.Add(item);
			if (Instance._randomizer.ContainsKey(sType))
			{
				int item2 = audioGroupInfo.Sources.Count - 1;
				Instance._randomizer[sType].Add(item2);
				Instance._randomizerOrigin[sType].Add(item2);
				Instance._randomizerLeftovers[sType].Add(audioGroupInfo.Sources.Count - 1);
			}
		}

		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			int num = 0;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || !(audioInfo.Source.transform.name != variationName))
				{
					audioInfo.Variation.original_pitch = pitch;
					AudioSource varAudio = audioInfo.Variation.VarAudio;
					if (varAudio != null)
					{
						varAudio.pitch = pitch;
					}
					num++;
				}
			}
			if (num == 0 && !changeAllVariations)
			{
				UnityEngine.Debug.Log("Could not find any matching variations of Sound Group '" + sType + "' to change the pitch of.");
			}
		}

		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			int num = 0;
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || !(audioInfo.Source.transform.name != variationName))
				{
					audioInfo.OriginalVolume = volume;
					num++;
				}
			}
			if (num == 0 && !changeAllVariations)
			{
				UnityEngine.Debug.Log("Could not find any matching variations of Sound Group '" + sType + "' to change the volume of.");
			}
		}

		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			AudioClip audioClip = Resources.Load(resourceFileName) as AudioClip;
			if (audioClip == null)
			{
				LogWarning("Resource file '" + resourceFileName + "' could not be located.");
			}
			else
			{
				ChangeVariationClip(sType, changeAllVariations, variationName, audioClip);
			}
		}

		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create change variation clip yet.");
				return;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				if (changeAllVariations || audioInfo.Source.transform.name == variationName)
				{
					if (audioInfo.Variation.IsPlaying)
					{
						audioInfo.Variation.Stop();
					}
					audioInfo.Source.clip = clip;
				}
			}
		}

		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
			if (IsOcclusionFreqencyTransitioning(variation))
			{
				LogWarning("Occlusion is already fading for: " + variation.name + ". This is a bug.");
				return;
			}
			OcclusionFreqChangeInfo item = new OcclusionFreqChangeInfo
			{
				ActingVariation = variation,
				CompletionTime = Time.realtimeSinceStartup + fadeTime,
				IsActive = true,
				StartFrequency = variation.LowPassFilter.cutoffFrequency,
				StartTime = Time.realtimeSinceStartup,
				TargetFrequency = newCutoffFreq
			};
			Instance.VariationOcclusionFreqChanges.Add(item);
		}

		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return null;
			}
			if (masterAudioGroup.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				UnityEngine.Debug.LogWarning("Cannot determine the next Variation of randomly sequenced Sound Group '" + sType + "'.");
				return null;
			}
			if (!Instance._randomizer.ContainsKey(sType))
			{
				UnityEngine.Debug.Log("Sound Group '" + sType + "' has no active Variations.");
				return null;
			}
			List<int> list = Instance._randomizer[sType];
			return Instance.AudioSourcesBySoundType[sType].Sources[list[0]].Source;
		}

		public static bool IsSoundGroupPlaying(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return false;
			}
			return masterAudioGroup.ActiveVoices > 0;
		}

		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			if (!SceneHasMasterAudio)
			{
				return false;
			}
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogWarning("Could not locate group '" + sType + "'.");
				return false;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				if (sources[i].Variation.WasTriggeredFromTransform(sourceTrans))
				{
					return true;
				}
			}
			return false;
		}

		public static void RouteGroupToBus(string sType, string busName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				LogError("Could not find Sound Group '" + sType + "'");
				return;
			}
			int num = 0;
			if (busName != null)
			{
				int num2 = GroupBuses.FindIndex((GroupBus x) => x.busName == busName);
				if (num2 < 0)
				{
					LogError("Could not find bus '" + busName + "' to assign to Sound Group '" + sType + "'");
					return;
				}
				num = 2 + num2;
			}
			GroupBus busByIndex = GetBusByIndex(masterAudioGroup.busIndex);
			masterAudioGroup.busIndex = num;
			GroupBus groupBus = null;
			bool flag = false;
			if (num > 0)
			{
				groupBus = GroupBuses.Find((GroupBus x) => x.busName == busName);
				if (groupBus.isMuted)
				{
					MuteGroup(masterAudioGroup.name, shouldCheckMuteStatus: false);
					flag = true;
				}
				else if (groupBus.isSoloed)
				{
					SoloGroup(masterAudioGroup.name, shouldCheckMuteStatus: false);
					flag = true;
				}
			}
			bool flag2 = false;
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				variation.SetMixerGroup();
				variation.SetSpatialBlend();
				if (variation.IsPlaying)
				{
					groupBus?.AddActiveAudioSourceId(variation.InstanceId);
					busByIndex?.RemoveActiveAudioSourceId(variation.InstanceId);
					flag2 = true;
				}
			}
			if (flag2)
			{
				SetBusVolume(groupBus, groupBus?.volume ?? 0f);
			}
			if (Application.isPlaying && flag)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static float GetVariationLength(string sType, string variationName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return -1f;
			}
			SoundGroupVariation soundGroupVariation = null;
			foreach (SoundGroupVariation groupVariation in masterAudioGroup.groupVariations)
			{
				if (!(groupVariation.name != variationName))
				{
					soundGroupVariation = groupVariation;
					break;
				}
			}
			if (soundGroupVariation == null)
			{
				LogError("Could not find Variation '" + variationName + "' in Sound Group '" + sType + "'.");
				return -1f;
			}
			AudioLocation audLocation = soundGroupVariation.audLocation;
			if (audLocation == AudioLocation.ResourceFile)
			{
				LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' length cannot be determined because it's a Resource Files.");
				return -1f;
			}
			AudioClip clip = soundGroupVariation.VarAudio.clip;
			if (clip == null)
			{
				LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' has no Audio Clip.");
				return -1f;
			}
			if (!(soundGroupVariation.VarAudio.pitch <= 0f))
			{
				return AudioUtil.AdjustAudioClipDurationForPitch(clip.length, soundGroupVariation.VarAudio);
			}
			LogError("Variation '" + variationName + "' in Sound Group '" + sType + "' has negative or zero pitch. Cannot compute length.");
			return -1f;
		}

		public static void RefillSoundGroupPool(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, logIfMissing: false);
			if (masterAudioGroup == null)
			{
				return;
			}
			List<int> list = Instance._randomizer[sType];
			List<int> list2 = Instance._clipsPlayedBySoundTypeOldestFirst[sType];
			if (list.Count > 0)
			{
				for (int i = 0; i < list.Count; i++)
				{
					int item = list[i];
					if (!list2.Contains(item))
					{
						list2.Add(item);
					}
				}
			}
			List<int> list3 = Instance._randomizerOrigin[sType];
			if (list2.Count < list3.Count)
			{
				for (int j = 0; j < list3.Count; j++)
				{
					int item2 = list3[j];
					if (!list2.Contains(item2))
					{
						list2.Add(item2);
					}
				}
			}
			list.Clear();
			if (masterAudioGroup.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				int? num = null;
				if (masterAudioGroup.UsesNoRepeat && list2.Count > 0)
				{
					num = list2[list2.Count - 1];
				}
				ArrayListUtil.SortIntArray(ref list2);
				if (num.HasValue && num.Value == list2[0])
				{
					int item3 = list2[0];
					list2.RemoveAt(0);
					list2.Insert(UnityEngine.Random.Range(1, list2.Count), item3);
				}
			}
			list.AddRange(list2);
			Instance._randomizerLeftovers[sType].AddRange(list2);
			list2.Clear();
			if (masterAudioGroup.curVariationMode == MasterAudioGroup.VariationMode.LoopedChain)
			{
				masterAudioGroup.ChainLoopCount++;
			}
		}

		public static bool SoundGroupExists(string sType)
		{
			return GrabGroup(sType, logIfMissing: false) != null;
		}

		public static void PauseSoundGroup(string sType)
		{
			if (!(GrabGroup(sType) == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.Pause();
				}
			}
		}

		public static void SetGroupSpatialBlend(string sType)
		{
			if (!(GrabGroup(sType) == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.SetSpatialBlend();
				}
			}
		}

		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
			if (Application.isPlaying && !(GrabGroup(sType, logIfMissing: false) == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.VarAudio.outputAudioMixerGroup = mixerGroup;
				}
			}
		}

		public static void UnpauseSoundGroup(string sType)
		{
			if (!(GrabGroup(sType) == null))
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.Unpause();
				}
			}
		}

		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeSoundGroupToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				SetGroupVolume(sType, newVolume);
				completionCallback?.Invoke();
				if (willStopAfterFade)
				{
					StopAllOfSound(sType);
				}
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.Log("Cannot fade Sound Group '" + sType + "'. Invalid volume specified. Volume should be between 0 and 1.");
				return;
			}
			GroupFadeInfo groupFadeInfo = Instance.GroupFades.Find((GroupFadeInfo obj) => obj.NameOfGroup == sType);
			if (groupFadeInfo != null)
			{
				groupFadeInfo.IsActive = false;
			}
			GroupFadeInfo groupFadeInfo2 = new GroupFadeInfo
			{
				NameOfGroup = sType,
				ActingGroup = masterAudioGroup,
				StartTime = AudioUtil.Time,
				CompletionTime = AudioUtil.Time + fadeTime,
				StartVolume = masterAudioGroup.groupMasterVolume,
				TargetVolume = newVolume,
				WillStopGroupAfterFade = willStopAfterFade,
				WillResetVolumeAfterFade = willResetVolumeAfterFade
			};
			if (completionCallback != null)
			{
				groupFadeInfo2.completionAction = completionCallback;
			}
			Instance.GroupFades.Add(groupFadeInfo2);
		}

		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
			if (!SceneHasMasterAudio || !Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if ((variation.IsPaused || variation.IsPlaying) && !(AudioUtil.Time - variation.LastTimePlayed <= minimumPlayTime))
				{
					if (fadeTime <= 0f)
					{
						variation.Stop();
					}
					else
					{
						variation.FadeOutNow(fadeTime);
					}
				}
			}
		}

		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
			if (!SceneHasMasterAudio || !Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return;
			}
			List<AudioInfo> sources = Instance.AudioSourcesBySoundType[sType].Sources;
			for (int i = 0; i < sources.Count; i++)
			{
				SoundGroupVariation variation = sources[i].Variation;
				if ((variation.IsPaused || variation.IsPlaying) && !(AudioUtil.Time - variation.LastTimePlayed <= minimumPlayTime))
				{
					variation.Stop();
				}
			}
		}

		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition < -3f || pitchAddition > 3f)
			{
				UnityEngine.Debug.LogError("Illegal pitch passed to GlideSoundGroupByPitch: '" + pitchAddition + "'. Legal pitches are between -3 and 3");
				return;
			}
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			GroupPitchGlideInfo groupPitchGlideInfo = Instance.GroupPitchGlides.Find((GroupPitchGlideInfo obj) => obj.NameOfGroup == sType);
			if (groupPitchGlideInfo != null)
			{
				groupPitchGlideInfo.IsActive = false;
				if (groupPitchGlideInfo.completionAction != null)
				{
					groupPitchGlideInfo.completionAction();
				}
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			if (glideTime <= 0.1f)
			{
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					audioGroupInfo.Sources[i].Variation.GlideByPitch(pitchAddition, 0f);
				}
				completionCallback?.Invoke();
				return;
			}
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(audioGroupInfo.Sources.Count);
			for (int j = 0; j < audioGroupInfo.Sources.Count; j++)
			{
				SoundGroupVariation variation = audioGroupInfo.Sources[j].Variation;
				if (variation.IsPlaying)
				{
					if (variation.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
					{
						variation.VariationUpdater.StopPitchGliding();
					}
					variation.GlideByPitch(pitchAddition, glideTime);
					list.Add(variation);
				}
			}
			if (list.Count == 0 || completionCallback == null)
			{
				completionCallback?.Invoke();
				return;
			}
			GroupPitchGlideInfo groupPitchGlideInfo2 = new GroupPitchGlideInfo
			{
				NameOfGroup = sType,
				ActingGroup = masterAudioGroup,
				CompletionTime = AudioUtil.Time + glideTime,
				GlidingVariations = list
			};
			if (completionCallback != null)
			{
				groupPitchGlideInfo2.completionAction = completionCallback;
			}
			Instance.GroupPitchGlides.Add(groupPitchGlideInfo2);
		}

		public static void DeleteSoundGroup(string sType)
		{
			if (SafeInstance == null)
			{
				return;
			}
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return;
			}
			StopAllOfSound(sType);
			Transform transform = masterAudioGroup.transform;
			MasterAudio instance = Instance;
			if (instance.duckingBySoundType.ContainsKey(sType))
			{
				instance.duckingBySoundType.Remove(sType);
			}
			Instance._randomizer.Remove(sType);
			Instance._randomizerLeftovers.Remove(sType);
			Instance._randomizerOrigin.Remove(sType);
			Instance._clipsPlayedBySoundTypeOldestFirst.Remove(sType);
			RemoveRuntimeGroupInfo(sType);
			Instance.LastTimeSoundGroupPlayed.Remove(sType);
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				AudioSource component = child.GetComponent<AudioSource>();
				SoundGroupVariation component2 = child.GetComponent<SoundGroupVariation>();
				AudioLocation audLocation = component2.audLocation;
				if (audLocation == AudioLocation.ResourceFile)
				{
					AudioResourceOptimizer.DeleteAudioSourceFromList(AudioResourceOptimizer.GetLocalizedFileName(component2.useLocalization, component2.resourceFileName), component);
				}
			}
			transform.parent = null;
			UnityEngine.Object.Destroy(transform.gameObject);
			RescanGroupsNow();
		}

		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			if (!SceneHasMasterAudio)
			{
				return null;
			}
			if (!SoundsReady)
			{
				UnityEngine.Debug.LogError("MasterAudio not finished initializing sounds. Cannot create new group yet.");
				return null;
			}
			string text = aGroup.transform.name;
			MasterAudio instance = Instance;
			if (Instance.AudioSourcesBySoundType.ContainsKey(text))
			{
				if (errorOnExisting)
				{
					UnityEngine.Debug.LogError("Cannot add a new Sound Group named '" + text + "' because there is already a Sound Group of that name.");
				}
				return null;
			}
			GameObject gameObject = UnityEngine.Object.Instantiate(instance.soundGroupTemplate.gameObject, instance.Trans.position, Quaternion.identity);
			Transform transform = gameObject.transform;
			transform.name = UtilStrings.TrimSpace(text);
			transform.parent = Instance.Trans;
			transform.gameObject.layer = Instance.gameObject.layer;
			for (int i = 0; i < aGroup.groupVariations.Count; i++)
			{
				DynamicGroupVariation dynamicGroupVariation = aGroup.groupVariations[i];
				for (int j = 0; j < dynamicGroupVariation.weight; j++)
				{
					GameObject obj = UnityEngine.Object.Instantiate(dynamicGroupVariation.gameObject, transform.position, Quaternion.identity);
					obj.transform.parent = transform;
					obj.transform.gameObject.layer = transform.gameObject.layer;
					UnityEngine.Object.Destroy(obj.GetComponent<DynamicGroupVariation>());
					obj.AddComponent<SoundGroupVariation>();
					SoundGroupVariation component = obj.GetComponent<SoundGroupVariation>();
					string text2 = component.name;
					int num = text2.IndexOf("(Clone)");
					if (num >= 0)
					{
						text2 = text2.Substring(0, num);
					}
					AudioSource component2 = dynamicGroupVariation.GetComponent<AudioSource>();
					switch (dynamicGroupVariation.audLocation)
					{
					case AudioLocation.Clip:
					{
						AudioClip clip = component2.clip;
						component.VarAudio.clip = clip;
						break;
					}
					case AudioLocation.ResourceFile:
						AudioResourceOptimizer.AddTargetForClip(AudioResourceOptimizer.GetLocalizedFileName(dynamicGroupVariation.useLocalization, dynamicGroupVariation.resourceFileName), component.VarAudio);
						component.resourceFileName = dynamicGroupVariation.resourceFileName;
						component.useLocalization = dynamicGroupVariation.useLocalization;
						break;
					}
					component.audLocation = dynamicGroupVariation.audLocation;
					component.original_pitch = component2.pitch;
					component.transform.name = text2;
					component.isExpanded = dynamicGroupVariation.isExpanded;
					component.probabilityToPlay = dynamicGroupVariation.probabilityToPlay;
					component.useRandomPitch = dynamicGroupVariation.useRandomPitch;
					component.randomPitchMode = dynamicGroupVariation.randomPitchMode;
					component.randomPitchMin = dynamicGroupVariation.randomPitchMin;
					component.randomPitchMax = dynamicGroupVariation.randomPitchMax;
					component.useRandomVolume = dynamicGroupVariation.useRandomVolume;
					component.randomVolumeMode = dynamicGroupVariation.randomVolumeMode;
					component.randomVolumeMin = dynamicGroupVariation.randomVolumeMin;
					component.randomVolumeMax = dynamicGroupVariation.randomVolumeMax;
					component.useCustomLooping = dynamicGroupVariation.useCustomLooping;
					component.minCustomLoops = dynamicGroupVariation.minCustomLoops;
					component.maxCustomLoops = dynamicGroupVariation.maxCustomLoops;
					component.useFades = dynamicGroupVariation.useFades;
					component.fadeInTime = dynamicGroupVariation.fadeInTime;
					component.fadeOutTime = dynamicGroupVariation.fadeOutTime;
					component.useIntroSilence = dynamicGroupVariation.useIntroSilence;
					component.introSilenceMin = dynamicGroupVariation.introSilenceMin;
					component.introSilenceMax = dynamicGroupVariation.introSilenceMax;
					component.useRandomStartTime = dynamicGroupVariation.useRandomStartTime;
					component.randomStartMinPercent = dynamicGroupVariation.randomStartMinPercent;
					component.randomStartMaxPercent = dynamicGroupVariation.randomStartMaxPercent;
					component.randomEndPercent = dynamicGroupVariation.randomEndPercent;
					if (Instance.addResonanceAudioSources && ResonanceAudioHelper.DarkTonicResonanceAudioPackageInstalled())
					{
						ResonanceAudioHelper.AddResonanceAudioSourceToVariation(component);
					}
					else if (Instance.addOculusAudioSources && OculusAudioHelper.DarkTonicOculusAudioPackageInstalled())
					{
						OculusAudioHelper.AddOculusAudioSourceToVariation(component);
					}
					if (component.LowPassFilter != null && !component.LowPassFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.LowPassFilter);
					}
					if (component.HighPassFilter != null && !component.HighPassFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.HighPassFilter);
					}
					if (component.DistortionFilter != null && !component.DistortionFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.DistortionFilter);
					}
					if (component.ChorusFilter != null && !component.ChorusFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.ChorusFilter);
					}
					if (component.EchoFilter != null && !component.EchoFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.EchoFilter);
					}
					if (component.ReverbFilter != null && !component.ReverbFilter.enabled)
					{
						UnityEngine.Object.Destroy(component.ReverbFilter);
					}
				}
			}
			MasterAudioGroup component3 = gameObject.GetComponent<MasterAudioGroup>();
			component3.retriggerPercentage = aGroup.retriggerPercentage;
			float? groupVolume = PersistentAudioSettings.GetGroupVolume(aGroup.name);
			component3.OriginalVolume = aGroup.groupMasterVolume;
			if (groupVolume.HasValue)
			{
				component3.groupMasterVolume = groupVolume.Value;
			}
			else
			{
				component3.groupMasterVolume = aGroup.groupMasterVolume;
			}
			component3.limitMode = aGroup.limitMode;
			component3.limitPerXFrames = aGroup.limitPerXFrames;
			component3.minimumTimeBetween = aGroup.minimumTimeBetween;
			component3.limitPolyphony = aGroup.limitPolyphony;
			component3.voiceLimitCount = aGroup.voiceLimitCount;
			component3.curVariationSequence = aGroup.curVariationSequence;
			component3.useInactivePeriodPoolRefill = aGroup.useInactivePeriodPoolRefill;
			component3.inactivePeriodSeconds = aGroup.inactivePeriodSeconds;
			component3.curVariationMode = aGroup.curVariationMode;
			component3.useNoRepeatRefill = aGroup.useNoRepeatRefill;
			component3.useDialogFadeOut = aGroup.useDialogFadeOut;
			component3.dialogFadeOutTime = aGroup.dialogFadeOutTime;
			component3.isUsingOcclusion = aGroup.isUsingOcclusion;
			component3.willOcclusionOverrideRaycastOffset = aGroup.willOcclusionOverrideRaycastOffset;
			component3.occlusionRayCastOffset = aGroup.occlusionRayCastOffset;
			component3.willOcclusionOverrideFrequencies = aGroup.willOcclusionOverrideFrequencies;
			component3.occlusionMaxCutoffFreq = aGroup.occlusionMaxCutoffFreq;
			component3.occlusionMinCutoffFreq = aGroup.occlusionMinCutoffFreq;
			component3.chainLoopDelayMin = aGroup.chainLoopDelayMin;
			component3.chainLoopDelayMax = aGroup.chainLoopDelayMax;
			component3.chainLoopMode = aGroup.chainLoopMode;
			component3.chainLoopNumLoops = aGroup.chainLoopNumLoops;
			component3.expandLinkedGroups = aGroup.expandLinkedGroups;
			component3.childSoundGroups = aGroup.childSoundGroups;
			component3.endLinkedGroups = aGroup.endLinkedGroups;
			component3.linkedStartGroupSelectionType = aGroup.linkedStartGroupSelectionType;
			component3.linkedStopGroupSelectionType = aGroup.linkedStopGroupSelectionType;
			component3.soundPlayedEventActive = aGroup.soundPlayedEventActive;
			component3.soundPlayedCustomEvent = aGroup.soundPlayedCustomEvent;
			component3.targetDespawnedBehavior = aGroup.targetDespawnedBehavior;
			component3.despawnFadeTime = aGroup.despawnFadeTime;
			component3.logSound = aGroup.logSound;
			component3.alwaysHighestPriority = aGroup.alwaysHighestPriority;
			component3.spatialBlendType = aGroup.spatialBlendType;
			component3.spatialBlend = aGroup.spatialBlend;
			List<AudioInfo> list = new List<AudioInfo>();
			List<int> list2 = new List<int>();
			for (int k = 0; k < gameObject.transform.childCount; k++)
			{
				list2.Add(k);
				Transform child = gameObject.transform.GetChild(k);
				AudioSource component4 = child.GetComponent<AudioSource>();
				SoundGroupVariation component = child.GetComponent<SoundGroupVariation>();
				list.Add(new AudioInfo(component, component4, component4.volume));
				component.DisableUpdater();
			}
			AddRuntimeGroupInfo(text, new AudioGroupInfo(list, component3));
			if (component3.curVariationSequence == MasterAudioGroup.VariationSequence.Randomized)
			{
				ArrayListUtil.SortIntArray(ref list2);
			}
			Instance._randomizer.Add(text, list2);
			List<int> list3 = new List<int>(list2.Count);
			list3.AddRange(list2);
			Instance._randomizerOrigin.Add(text, list3);
			Instance._randomizerLeftovers.Add(text, new List<int>(list2.Count));
			Instance._randomizerLeftovers[text].AddRange(list2);
			Instance._clipsPlayedBySoundTypeOldestFirst.Add(text, new List<int>(list2.Count));
			RescanGroupsNow();
			if (string.IsNullOrEmpty(aGroup.busName))
			{
				return transform;
			}
			component3.busIndex = GetBusIndex(aGroup.busName, alertMissing: true);
			if (component3.BusForGroup != null && component3.BusForGroup.isMuted)
			{
				MuteGroup(component3.name, shouldCheckMuteStatus: false);
			}
			else if (Instance.mixerMuted)
			{
				MuteGroup(component3.name, shouldCheckMuteStatus: false);
			}
			return transform;
		}

		public static float GetGroupVolume(string sType)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (masterAudioGroup == null)
			{
				return 0f;
			}
			return masterAudioGroup.groupMasterVolume;
		}

		public static void SetGroupVolume(string sType, float volumeLevel)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType, Application.isPlaying);
			if (masterAudioGroup == null || AppIsShuttingDown)
			{
				return;
			}
			masterAudioGroup.groupMasterVolume = volumeLevel;
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			float busVolume = GetBusVolume(masterAudioGroup);
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				AudioInfo audioInfo = audioGroupInfo.Sources[i];
				AudioSource source = audioInfo.Source;
				if (!(source == null))
				{
					float volume = ((audioInfo.Variation.randomVolumeMode != 0) ? (audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * masterAudioGroup.groupMasterVolume * busVolume * Instance._masterAudioVolume) : (audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * masterAudioGroup.groupMasterVolume * busVolume * Instance._masterAudioVolume + audioInfo.LastRandomVolume));
					source.volume = volume;
				}
			}
		}

		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				Instance.SoloedGroups.Remove(masterAudioGroup);
				masterAudioGroup.isSoloed = false;
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: true);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: false);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
			Instance.AudioSourcesBySoundType.Add(groupName, groupInfo);
			List<AudioSource> list = new List<AudioSource>(groupInfo.Sources.Count);
			for (int i = 0; i < groupInfo.Sources.Count; i++)
			{
				list.Add(groupInfo.Sources[i].Source);
			}
			TrackRuntimeAudioSources(list);
		}

		private static void FireAudioSourcesNumberChangedEvent()
		{
			if (NumberOfAudioSourcesChanged != null)
			{
				NumberOfAudioSourcesChanged();
			}
		}

		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
			bool flag = false;
			for (int i = 0; i < sources.Count; i++)
			{
				AudioSource item = sources[i];
				if (!Instance.AllAudioSources.Contains(item))
				{
					Instance.AllAudioSources.Add(item);
					flag = true;
				}
			}
			if (flag)
			{
				FireAudioSourcesNumberChangedEvent();
			}
		}

		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
			if (AppIsShuttingDown || SafeInstance == null)
			{
				return;
			}
			bool flag = false;
			for (int i = 0; i < sources.Count; i++)
			{
				AudioSource item = sources[i];
				if (Instance.AllAudioSources.Contains(item))
				{
					Instance.AllAudioSources.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				FireAudioSourcesNumberChangedEvent();
			}
		}

		private static void RemoveRuntimeGroupInfo(string groupName)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(groupName);
			if (masterAudioGroup != null)
			{
				List<AudioSource> list = new List<AudioSource>(masterAudioGroup.groupVariations.Count);
				for (int i = 0; i < masterAudioGroup.groupVariations.Count; i++)
				{
					list.Add(masterAudioGroup.groupVariations[i].VarAudio);
				}
				StopTrackingRuntimeAudioSources(list);
			}
			Instance.AudioSourcesBySoundType.Remove(groupName);
		}

		private static void RescanChildren(MasterAudioGroup group)
		{
			List<SoundGroupVariation> list = new List<SoundGroupVariation>();
			List<string> list2 = new List<string>();
			for (int i = 0; i < group.transform.childCount; i++)
			{
				Transform child = group.transform.GetChild(i);
				if (!list2.Contains(child.name))
				{
					list2.Add(child.name);
					SoundGroupVariation component = child.GetComponent<SoundGroupVariation>();
					list.Add(component);
				}
			}
			group.groupVariations = list;
		}

		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
			aGroup.isMuted = isMute;
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
			{
				audioGroupInfo.Sources[i].Source.mute = isMute;
			}
		}

		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				masterAudioGroup.isMuted = false;
				masterAudioGroup.isSoloed = true;
				Instance.SoloedGroups.Add(masterAudioGroup);
				SetGroupMuteStatus(masterAudioGroup, sType, isMute: false);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
			if (Instance.SoloedGroups.Count > 0)
			{
				SilenceNonSoloedGroups();
			}
			else
			{
				UnsilenceNonSoloedGroups();
			}
		}

		private static void UnsilenceNonSoloedGroups()
		{
			foreach (AudioGroupInfo value in Instance.AudioSourcesBySoundType.Values)
			{
				if (!value.Group.isMuted)
				{
					UnsilenceGroup(value.Group.GameObjectName);
				}
			}
		}

		private static void UnsilenceGroup(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					audioGroupInfo.Sources[i].Source.mute = false;
				}
			}
		}

		private static void SilenceNonSoloedGroups()
		{
			foreach (AudioGroupInfo value in Instance.AudioSourcesBySoundType.Values)
			{
				if (!value.Group.isSoloed && !value.Group.isMuted)
				{
					SilenceGroup(value.Group.GameObjectName);
				}
			}
		}

		private static void SilenceGroup(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
				for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
				{
					audioGroupInfo.Sources[i].Source.mute = true;
				}
			}
		}

		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
			MasterAudioGroup masterAudioGroup = GrabGroup(sType);
			if (!(masterAudioGroup == null))
			{
				masterAudioGroup.isSoloed = false;
				Instance.SoloedGroups.Remove(masterAudioGroup);
				if (shouldCheckMuteStatus)
				{
					SilenceOrUnsilenceGroupsFromSoloChange();
				}
			}
		}

		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				if (logIfMissing)
				{
					UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
				}
				return null;
			}
			AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[sType];
			if (audioGroupInfo.Group == null)
			{
				Transform childTransform = Instance.Trans.GetChildTransform(sType);
				if (!(childTransform != null))
				{
					return null;
				}
				MasterAudioGroup component = childTransform.GetComponent<MasterAudioGroup>();
				audioGroupInfo.Group = component;
			}
			MasterAudioGroup group = audioGroupInfo.Group;
			if (group.groupVariations.Count == 0)
			{
				RescanChildren(group);
			}
			return group;
		}

		public static int VoicesForGroup(string sType)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return -1;
			}
			return Instance.AudioSourcesBySoundType[sType].Sources.Count;
		}

		public static Transform FindGroupTransform(string sType)
		{
			if (SafeInstance != null)
			{
				Transform childTransform = Instance.Trans.GetChildTransform(sType);
				if (childTransform != null)
				{
					return childTransform;
				}
			}
			DynamicSoundGroupCreator[] array = UnityEngine.Object.FindObjectsOfType<DynamicSoundGroupCreator>();
			for (int i = 0; i < array.Count(); i++)
			{
				Transform childTransform = array[i].transform.GetChildTransform(sType);
				if (childTransform != null)
				{
					return childTransform;
				}
			}
			return null;
		}

		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				if (logIfMissing)
				{
					UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
				}
				return null;
			}
			return Instance.AudioSourcesBySoundType[sType].Sources;
		}

		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				return null;
			}
			return Instance.AudioSourcesBySoundType[sType];
		}

		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
			if (!Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				UnityEngine.Debug.LogError("Could not grab Sound Group '" + sType + "' because it does not exist in this scene.");
			}
			else
			{
				Instance.AudioSourcesBySoundType[sType].Group.SubscribeToLastVariationFinishedPlay(finishedCallback);
			}
		}

		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
			if (Instance.AudioSourcesBySoundType.ContainsKey(sType))
			{
				Instance.AudioSourcesBySoundType[sType].Group.UnsubscribeFromLastVariationFinishedPlay();
			}
		}

		public void SetSpatialBlendForMixer()
		{
			foreach (string key in AudioSourcesBySoundType.Keys)
			{
				SetGroupSpatialBlend(key);
			}
		}

		public static void PauseMixer()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				PauseSoundGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
		}

		public static void UnpauseMixer()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				UnpauseSoundGroup(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
		}

		public static void StopMixer()
		{
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				StopAllOfSound(Instance.AudioSourcesBySoundType[key].Group.GameObjectName);
			}
			Instance._isStoppingMultiple = false;
		}

		public static void UnsubscribeFromAllVariations()
		{
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				List<AudioInfo> sources = Instance.AudioSourcesBySoundType[key].Sources;
				for (int i = 0; i < sources.Count; i++)
				{
					sources[i].Variation.ClearSubscribers();
				}
			}
		}

		public static void StopEverything()
		{
			StopMixer();
			StopAllPlaylists();
		}

		public static void PauseEverything()
		{
			PauseMixer();
			PauseAllPlaylists();
		}

		public static void UnpauseEverything()
		{
			UnpauseMixer();
			UnpauseAllPlaylists();
		}

		public static void MuteEverything()
		{
			MixerMuted = true;
			MuteAllPlaylists();
		}

		public static void UnmuteEverything()
		{
			MixerMuted = false;
			UnmuteAllPlaylists();
		}

		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			List<string> list = new List<string>();
			for (int i = 0; i < Instance.transform.childCount; i++)
			{
				MasterAudioGroup component = Instance.transform.GetChild(i).GetComponent<MasterAudioGroup>();
				for (int j = 0; j < component.transform.childCount; j++)
				{
					SoundGroupVariation component2 = component.transform.GetChild(j).GetComponent<SoundGroupVariation>();
					string text = string.Empty;
					switch (component2.audLocation)
					{
					case AudioLocation.Clip:
					{
						AudioClip clip = component2.VarAudio.clip;
						if (clip != null)
						{
							text = clip.name;
						}
						break;
					}
					case AudioLocation.ResourceFile:
						text = component2.resourceFileName;
						break;
					}
					if (!string.IsNullOrEmpty(text) && !list.Contains(text))
					{
						list.Add(text);
					}
				}
			}
			return list;
		}

		private static int GetBusIndex(string busName, bool alertMissing)
		{
			if (!SceneHasMasterAudio)
			{
				return -1;
			}
			for (int i = 0; i < GroupBuses.Count; i++)
			{
				if (GroupBuses[i].busName == busName)
				{
					return i + 2;
				}
			}
			if (alertMissing)
			{
				LogWarning("Could not find bus '" + busName + "'.");
			}
			return -1;
		}

		private static GroupBus GetBusByIndex(int busIndex)
		{
			if (busIndex < 2)
			{
				return null;
			}
			return GroupBuses[busIndex - 2];
		}

		public static void ChangeBusPitch(string busName, float pitch)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					ChangeVariationPitch(group.GameObjectName, changeAllVariations: true, string.Empty, pitch);
				}
			}
		}

		public static void MuteBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isMuted = true;
			if (groupBus.isSoloed)
			{
				UnsoloBus(busName);
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					MuteGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (Application.isPlaying)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GrabBusByName(busName).isMuted = false;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					UnmuteGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (shouldCheckMuteStatus)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void ToggleMuteBus(string busName)
		{
			if (GetBusIndex(busName, alertMissing: true) >= 0)
			{
				if (GrabBusByName(busName).isMuted)
				{
					UnmuteBus(busName);
				}
				else
				{
					MuteBus(busName);
				}
			}
		}

		public static void PauseBus(string busName)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					PauseSoundGroup(group.GameObjectName);
				}
			}
		}

		public static void SoloBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			groupBus.isSoloed = true;
			if (groupBus.isMuted)
			{
				UnmuteBus(busName);
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					SoloGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (Application.isPlaying)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			GrabBusByName(busName).isSoloed = false;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					UnsoloGroup(group.GameObjectName, shouldCheckMuteStatus: false);
				}
			}
			if (shouldCheckMuteStatus)
			{
				SilenceOrUnsilenceGroupsFromSoloChange();
			}
		}

		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
			if (!Application.isPlaying)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					RouteGroupToUnityMixerGroup(group.name, mixerGroup);
				}
			}
		}

		private static void StopOldestSoundOnBus(GroupBus bus)
		{
			int busIndex = GetBusIndex(bus.busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			SoundGroupVariation soundGroupVariation = null;
			float num = -1f;
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex != busIndex || group.ActiveVoices == 0)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if (variation.PlaySoundParm.IsPlaying)
					{
						if (variation.curFadeMode == SoundGroupVariation.FadeMode.FadeOutEarly)
						{
							variation.Stop();
						}
						else if (soundGroupVariation == null)
						{
							soundGroupVariation = variation;
							num = variation.LastTimePlayed;
						}
						else if (variation.LastTimePlayed < num)
						{
							soundGroupVariation = variation;
							num = variation.LastTimePlayed;
						}
					}
				}
			}
			if (soundGroupVariation != null)
			{
				soundGroupVariation.FadeOutNow(Instance.stopOldestBusFadeTime);
			}
		}

		public static void StopBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					StopAllOfSound(group.GameObjectName);
				}
			}
			Instance._isStoppingMultiple = false;
		}

		public static void UnpauseBus(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					UnpauseSoundGroup(group.GameObjectName);
				}
			}
		}

		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			if (GroupBuses.FindAll((GroupBus obj) => obj.busName == busName).Count > 0)
			{
				if (errorOnExisting)
				{
					LogError("You already have a bus named '" + busName + "'. Not creating a second one.");
				}
				return false;
			}
			GroupBus item = new GroupBus
			{
				busName = busName,
				isTemporary = isTemporary
			};
			float? busVolume = PersistentAudioSettings.GetBusVolume(busName);
			GroupBuses.Add(item);
			if (busVolume.HasValue)
			{
				SetBusVolumeByName(busName, busVolume.Value);
			}
			return true;
		}

		public static void DeleteBusByName(string busName)
		{
			int busIndex = GetBusIndex(busName, alertMissing: false);
			if (busIndex > 0)
			{
				DeleteBusByIndex(busIndex);
			}
		}

		public static void DeleteBusByIndex(int busIndex)
		{
			int index = busIndex - 2;
			if (Application.isPlaying)
			{
				GroupBus groupBus = GroupBuses[index];
				if (groupBus.isSoloed)
				{
					UnsoloBus(groupBus.busName, shouldCheckMuteStatus: false);
				}
				else if (groupBus.isMuted)
				{
					UnmuteBus(groupBus.busName, shouldCheckMuteStatus: false);
				}
			}
			GroupBuses.RemoveAt(index);
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				MasterAudioGroup group = value.Group;
				if (group.busIndex == -1)
				{
					continue;
				}
				if (group.busIndex == busIndex)
				{
					group.busIndex = -1;
					RouteGroupToUnityMixerGroup(group.name, null);
					for (int i = 0; i < value.Sources.Count; i++)
					{
						value.Sources[i].Variation.SetSpatialBlend();
					}
					RecalculateGroupVolumes(value, null);
				}
				else if (group.busIndex > busIndex)
				{
					group.busIndex--;
				}
			}
		}

		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			float result = 1f;
			if (maGroup.busIndex >= 2)
			{
				result = GroupBuses[maGroup.busIndex - 2].volume;
			}
			return result;
		}

		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, Action completionCallback = null, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
			if (newVolume < 0f || newVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadeBusToVolume: '" + newVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				SetBusVolumeByName(busName, newVolume);
				completionCallback?.Invoke();
				if (willStopAfterFade)
				{
					StopBus(busName);
				}
				return;
			}
			GroupBus groupBus = GrabBusByName(busName);
			if (groupBus == null)
			{
				UnityEngine.Debug.Log("Could not find bus '" + busName + "' to fade it.");
				return;
			}
			BusFadeInfo busFadeInfo = Instance.BusFades.Find((BusFadeInfo obj) => obj.NameOfBus == busName);
			if (busFadeInfo != null)
			{
				busFadeInfo.IsActive = false;
			}
			BusFadeInfo busFadeInfo2 = new BusFadeInfo
			{
				NameOfBus = busName,
				ActingBus = groupBus,
				StartVolume = groupBus.volume,
				TargetVolume = newVolume,
				StartTime = AudioUtil.Time,
				CompletionTime = AudioUtil.Time + fadeTime,
				WillStopGroupAfterFade = willStopAfterFade,
				WillResetVolumeAfterFade = willResetVolumeAfterFade
			};
			if (completionCallback != null)
			{
				busFadeInfo2.completionAction = completionCallback;
			}
			Instance.BusFades.Add(busFadeInfo2);
		}

		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				if (value.Group.busIndex != busIndex)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if ((variation.IsPaused || variation.IsPlaying) && !(AudioUtil.Time - variation.LastTimePlayed <= minimumPlayTime))
					{
						if (fadeTime <= 0f)
						{
							variation.Stop();
						}
						else
						{
							variation.FadeOutNow(fadeTime);
						}
					}
				}
			}
		}

		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
			if (!SceneHasMasterAudio)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				if (value.Group.busIndex != busIndex)
				{
					continue;
				}
				for (int i = 0; i < value.Sources.Count; i++)
				{
					SoundGroupVariation variation = value.Sources[i].Variation;
					if ((variation.IsPaused || variation.IsPlaying) && !(AudioUtil.Time - variation.LastTimePlayed <= minimumPlayTime))
					{
						variation.Stop();
					}
				}
			}
		}

		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, Action completionCallback = null)
		{
			if (pitchAddition < -3f || pitchAddition > 3f)
			{
				UnityEngine.Debug.LogError("Illegal pitch passed to GlideBusByPitch: '" + pitchAddition + "'. Legal pitches are between -3 and 3");
				return;
			}
			if (pitchAddition == 0f)
			{
				completionCallback?.Invoke();
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			if (glideTime <= 0.1f)
			{
				while (enumerator.MoveNext())
				{
					AudioGroupInfo value = enumerator.Current.Value;
					AudioGroupInfo audioGroupInfo = Instance.AudioSourcesBySoundType[value.Group.name];
					if (audioGroupInfo.Group.busIndex != busIndex)
					{
						continue;
					}
					for (int i = 0; i < audioGroupInfo.Sources.Count; i++)
					{
						SoundGroupVariation variation = audioGroupInfo.Sources[i].Variation;
						if (variation.IsPlaying)
						{
							if (variation.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
							{
								variation.VariationUpdater.StopPitchGliding();
							}
							variation.GlideByPitch(pitchAddition, 0f);
						}
					}
				}
				completionCallback?.Invoke();
				return;
			}
			BusPitchGlideInfo busPitchGlideInfo = Instance.BusPitchGlides.Find((BusPitchGlideInfo obj) => obj.NameOfBus == busName);
			if (busPitchGlideInfo != null)
			{
				busPitchGlideInfo.IsActive = false;
				if (busPitchGlideInfo.completionAction != null)
				{
					busPitchGlideInfo.completionAction();
					busPitchGlideInfo.completionAction = null;
				}
			}
			List<SoundGroupVariation> list = new List<SoundGroupVariation>(16);
			while (enumerator.MoveNext())
			{
				AudioGroupInfo value = enumerator.Current.Value;
				AudioGroupInfo audioGroupInfo2 = Instance.AudioSourcesBySoundType[value.Group.name];
				if (audioGroupInfo2.Group.busIndex != busIndex)
				{
					continue;
				}
				for (int j = 0; j < audioGroupInfo2.Sources.Count; j++)
				{
					SoundGroupVariation variation2 = audioGroupInfo2.Sources[j].Variation;
					if (variation2.IsPlaying)
					{
						if (variation2.curPitchMode == SoundGroupVariation.PitchMode.Gliding)
						{
							variation2.VariationUpdater.StopPitchGliding();
						}
						variation2.GlideByPitch(pitchAddition, glideTime);
						list.Add(variation2);
					}
				}
			}
			if (list.Count == 0)
			{
				completionCallback?.Invoke();
				return;
			}
			BusPitchGlideInfo busPitchGlideInfo2 = new BusPitchGlideInfo
			{
				NameOfBus = busName,
				CompletionTime = AudioUtil.Time + glideTime,
				GlidingVariations = list
			};
			if (completionCallback != null)
			{
				busPitchGlideInfo2.completionAction = completionCallback;
			}
			Instance.BusPitchGlides.Add(busPitchGlideInfo2);
		}

		public static void SetBusVolumeByName(string busName, float newVolume)
		{
			GroupBus groupBus = GrabBusByName(busName);
			if (groupBus == null)
			{
				UnityEngine.Debug.LogError("bus '" + busName + "' not found!");
			}
			else
			{
				SetBusVolume(groupBus, newVolume);
			}
		}

		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
			GroupBus busByIndex = GetBusByIndex(aGroup.Group.busIndex);
			bool num = busByIndex != null && bus != null && busByIndex.busName == bus.busName;
			float num2 = 1f;
			if (num)
			{
				num2 = bus.volume;
			}
			else if (busByIndex != null)
			{
				num2 = busByIndex.volume;
			}
			for (int i = 0; i < aGroup.Sources.Count; i++)
			{
				AudioInfo audioInfo = aGroup.Sources[i];
				AudioSource source = audioInfo.Source;
				if (audioInfo.Variation.IsPlaying)
				{
					float num3 = aGroup.Group.groupMasterVolume * num2 * Instance._masterAudioVolume;
					float volume = audioInfo.OriginalVolume * audioInfo.LastPercentageVolume * num3 + audioInfo.LastRandomVolume;
					source.volume = volume;
					source.GetComponent<SoundGroupVariation>().SetGroupVolume = num3;
				}
			}
		}

		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
			if (bus != null)
			{
				bus.volume = newVolume;
			}
			foreach (string key in Instance.AudioSourcesBySoundType.Keys)
			{
				RecalculateGroupVolumes(Instance.AudioSourcesBySoundType[key], bus);
			}
		}

		public static GroupBus GrabBusByName(string busName)
		{
			for (int i = 0; i < GroupBuses.Count; i++)
			{
				GroupBus groupBus = GroupBuses[i];
				if (groupBus.busName == busName)
				{
					return groupBus;
				}
			}
			return null;
		}

		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					PauseSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
		}

		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					UnpauseSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
		}

		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
			if (!SceneHasMasterAudio || sourceTrans == null)
			{
				return;
			}
			int busIndex = GetBusIndex(busName, alertMissing: true);
			if (busIndex < 0)
			{
				return;
			}
			Dictionary<string, AudioGroupInfo>.Enumerator enumerator = Instance.AudioSourcesBySoundType.GetEnumerator();
			Instance.VariationsStartedDuringMultiStop.Clear();
			Instance._isStoppingMultiple = true;
			while (enumerator.MoveNext())
			{
				MasterAudioGroup group = enumerator.Current.Value.Group;
				if (group.busIndex == busIndex)
				{
					StopSoundGroupOfTransform(sourceTrans, group.GameObjectName);
				}
			}
			Instance._isStoppingMultiple = false;
		}

		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
			MasterAudio instance = Instance;
			if (!instance.duckingBySoundType.ContainsKey(sType))
			{
				DuckGroupInfo duckGroupInfo = new DuckGroupInfo
				{
					soundType = sType,
					riseVolStart = riseVolumeStart,
					duckedVolumeCut = duckedVolCut,
					unduckTime = unduckTime,
					isTemporary = isTemporary
				};
				instance.duckingBySoundType.Add(sType, duckGroupInfo);
				instance.musicDuckingSounds.Add(duckGroupInfo);
			}
		}

		public static void RemoveSoundGroupFromDuckList(string sType)
		{
			MasterAudio instance = Instance;
			if (instance.duckingBySoundType.ContainsKey(sType))
			{
				DuckGroupInfo item = instance.duckingBySoundType[sType];
				instance.musicDuckingSounds.Remove(item);
				instance.duckingBySoundType.Remove(sType);
			}
		}

		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			if (playlistName == "[None]")
			{
				return null;
			}
			for (int i = 0; i < MusicPlaylists.Count; i++)
			{
				Playlist playlist = MusicPlaylists[i];
				if (playlist.playlistName == playlistName)
				{
					return playlist;
				}
			}
			if (logErrorIfNotFound)
			{
				UnityEngine.Debug.LogError("Could not find Playlist '" + playlistName + "'.");
			}
			return null;
		}

		public static void ChangePlaylistPitch(string playlistName, float pitch, string songName = null)
		{
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist == null)
			{
				return;
			}
			for (int i = 0; i < playlist.MusicSettings.Count; i++)
			{
				MusicSetting musicSetting = playlist.MusicSettings[i];
				if (string.IsNullOrEmpty(songName) || !(musicSetting.alias != songName) || !(musicSetting.songName != songName))
				{
					musicSetting.pitch = pitch;
				}
			}
		}

		public static void MutePlaylist()
		{
			MutePlaylist("~only~");
		}

		public static void MutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			MutePlaylists(list);
		}

		public static void MuteAllPlaylists()
		{
			MutePlaylists(PlaylistController.Instances);
		}

		private static void MutePlaylists(List<PlaylistController> playlists)
		{
			if (playlists.Count == PlaylistController.Instances.Count)
			{
				PlaylistsMuted = true;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].MutePlaylist();
			}
		}

		public static void UnmutePlaylist()
		{
			UnmutePlaylist("~only~");
		}

		public static void UnmutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			UnmutePlaylists(list);
		}

		public static void UnmuteAllPlaylists()
		{
			UnmutePlaylists(PlaylistController.Instances);
		}

		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
			if (playlists.Count == PlaylistController.Instances.Count)
			{
				PlaylistsMuted = false;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].UnmutePlaylist();
			}
		}

		public static void ToggleMutePlaylist()
		{
			ToggleMutePlaylist("~only~");
		}

		public static void ToggleMutePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			ToggleMutePlaylists(list);
		}

		public static void ToggleMuteAllPlaylists()
		{
			ToggleMutePlaylists(PlaylistController.Instances);
		}

		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].ToggleMutePlaylist();
			}
		}

		public static void PausePlaylist()
		{
			PausePlaylist("~only~");
		}

		public static void PausePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "PausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			PausePlaylists(list);
		}

		public static void PauseAllPlaylists()
		{
			PausePlaylists(PlaylistController.Instances);
		}

		private static void PausePlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].PausePlaylist();
			}
		}

		public static void UnpausePlaylist()
		{
			UnpausePlaylist("~only~");
		}

		public static void UnpausePlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "UnpausePlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			UnpausePlaylists(list);
		}

		public static void UnpauseAllPlaylists()
		{
			UnpausePlaylists(PlaylistController.Instances);
		}

		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
			for (int i = 0; i < controllers.Count; i++)
			{
				controllers[i].UnpausePlaylist();
			}
		}

		public static void StopPlaylist()
		{
			StopPlaylist("~only~");
		}

		public static void StopPlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopPlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			StopPlaylists(list);
		}

		public static void StopAllPlaylists()
		{
			StopPlaylists(PlaylistController.Instances);
		}

		private static void StopPlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].StopPlaylist();
			}
		}

		public static void TriggerNextPlaylistClip()
		{
			TriggerNextPlaylistClip("~only~");
		}

		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerNextPlaylistClip"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			NextPlaylistClips(list);
		}

		public static void TriggerNextClipAllPlaylists()
		{
			NextPlaylistClips(PlaylistController.Instances);
		}

		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].PlayNextSong();
			}
		}

		public static void TriggerRandomPlaylistClip()
		{
			TriggerRandomPlaylistClip("~only~");
		}

		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerRandomPlaylistClip"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			RandomPlaylistClips(list);
		}

		public static void TriggerRandomClipAllPlaylists()
		{
			RandomPlaylistClips(PlaylistController.Instances);
		}

		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].PlayRandomSong();
			}
		}

		public static void RestartPlaylist()
		{
			RestartPlaylist("~only~");
		}

		public static void RestartPlaylist(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "RestartPlaylist"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				RestartPlaylists(new List<PlaylistController> { playlistController });
			}
		}

		public static void RestartAllPlaylists()
		{
			RestartPlaylists(PlaylistController.Instances);
		}

		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].RestartPlaylist();
			}
		}

		public static void StartPlaylist(string playlistName)
		{
			StartPlaylist("~only~", playlistName);
		}

		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StartPlaylist"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				list[i].StartPlaylist(playlistName);
			}
		}

		public static void StopLoopingAllCurrentSongs()
		{
			StopLoopingCurrentSongs(PlaylistController.Instances);
		}

		public static void StopLoopingCurrentSong()
		{
			StopLoopingCurrentSong("~only~");
		}

		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopLoopingCurrentSong"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				StopLoopingCurrentSongs(new List<PlaylistController> { playlistController });
			}
		}

		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
			for (int i = 0; i < playlistControllers.Count; i++)
			{
				playlistControllers[i].StopLoopingCurrentSong();
			}
		}

		public static void StopAllPlaylistsAfterCurrentSongs()
		{
			StopPlaylistAfterCurrentSongs(PlaylistController.Instances);
		}

		public static void StopPlaylistAfterCurrentSong()
		{
			StopPlaylistAfterCurrentSong("~only~");
		}

		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "StopPlaylistAfterCurrentSong"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				StopPlaylistAfterCurrentSongs(new List<PlaylistController> { playlistController });
			}
		}

		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
			for (int i = 0; i < playlistControllers.Count; i++)
			{
				playlistControllers[i].StopPlaylistAfterCurrentSong();
			}
		}

		public static void QueuePlaylistClip(string clipName)
		{
			QueuePlaylistClip("~only~", clipName);
		}

		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "QueuePlaylistClip"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				playlistController.QueuePlaylistClip(clipName);
			}
		}

		public static bool TriggerPlaylistClip(string clipName)
		{
			return TriggerPlaylistClip("~only~", clipName);
		}

		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "TriggerPlaylistClip"))
				{
					return false;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return false;
				}
				playlistController = playlistController2;
			}
			if (playlistController == null)
			{
				return false;
			}
			return playlistController.TriggerPlaylistClip(clipName);
		}

		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
			ChangePlaylistByName("~only~", playlistName, playFirstClip);
		}

		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			PlaylistController playlistController;
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "ChangePlaylistByName"))
				{
					return;
				}
				playlistController = instances[0];
			}
			else
			{
				PlaylistController playlistController2 = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController2 == null)
				{
					return;
				}
				playlistController = playlistController2;
			}
			if (playlistController != null)
			{
				playlistController.ChangePlaylist(playlistName, playFirstClip);
			}
		}

		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
			FadePlaylistToVolume("~only~", targetVolume, fadeTime);
		}

		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
			List<PlaylistController> instances = PlaylistController.Instances;
			List<PlaylistController> list = new List<PlaylistController>();
			if (playlistControllerName == "~only~")
			{
				if (!IsOkToCallOnlyPlaylistMethod(instances, "FadePlaylistToVolume"))
				{
					return;
				}
				list.Add(instances[0]);
			}
			else
			{
				PlaylistController playlistController = PlaylistController.InstanceByName(playlistControllerName);
				if (playlistController != null)
				{
					list.Add(playlistController);
				}
			}
			FadePlaylists(list, targetVolume, fadeTime);
		}

		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
			FadePlaylists(PlaylistController.Instances, targetVolume, fadeTime);
		}

		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
			if (targetVolume < 0f || targetVolume > 1f)
			{
				UnityEngine.Debug.LogError("Illegal volume passed to FadePlaylistToVolume: '" + targetVolume + "'. Legal volumes are between 0 and 1");
				return;
			}
			for (int i = 0; i < playlists.Count; i++)
			{
				playlists[i].FadeToVolume(targetVolume, fadeTime);
			}
		}

		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
			Playlist playlist2 = GrabPlaylist(playlist.playlistName, logErrorIfNotFound: false);
			if (playlist2 != null)
			{
				if (errorOnDuplicate)
				{
					UnityEngine.Debug.LogError("You already have a Playlist Controller with the name '" + playlist2.playlistName + "'. You must name them all uniquely. Not adding duplicate named Playlist.");
				}
			}
			else
			{
				MusicPlaylists.Add(playlist);
			}
		}

		public static void DeletePlaylist(string playlistName)
		{
			if (SafeInstance == null)
			{
				return;
			}
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist == null)
			{
				return;
			}
			for (int i = 0; i < PlaylistController.Instances.Count; i++)
			{
				PlaylistController playlistController = PlaylistController.Instances[i];
				if (!(playlistController.PlaylistName != playlistName))
				{
					playlistController.StopPlaylist();
					break;
				}
			}
			MusicPlaylists.Remove(playlist);
		}

		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
			Playlist playlist = GrabPlaylist(playlistName);
			if (playlist != null)
			{
				MusicSetting item = new MusicSetting
				{
					clip = song,
					isExpanded = true,
					isLoop = loopSong,
					pitch = songPitch,
					volume = songVolume
				};
				playlist.MusicSettings.Add(item);
			}
		}

		public static void AudioListenerChanged(AudioListener listener)
		{
			_listenerTrans = listener.GetComponent<Transform>();
			ListenerFollower listenerFollower = AmbientUtil.ListenerFollower;
			if (listenerFollower != null)
			{
				listenerFollower.StartFollowing(_listenerTrans, 0.01f);
			}
		}

		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
			if (!AppIsShuttingDown && !("[None]" == customEventName) && !string.IsNullOrEmpty(customEventName))
			{
				if (!CustomEventExists(customEventName) && !IsWarming)
				{
					UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' was not found in Master Audio.");
					return;
				}
				Instance.CustomEventsToFire.Enqueue(new CustomEventToFireInfo
				{
					eventName = customEventName,
					eventOrigin = eventOrigin
				});
			}
		}

		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
			if (AppIsShuttingDown)
			{
				return;
			}
			IList<AudioEventGroup> allEvents = receiver.GetAllEvents();
			for (int i = 0; i < allEvents.Count; i++)
			{
				AudioEventGroup audioEventGroup = allEvents[i];
				if (!receiver.SubscribesToEvent(audioEventGroup.customEventName))
				{
					continue;
				}
				if (!Instance.ReceiversByEventName.ContainsKey(audioEventGroup.customEventName))
				{
					Instance.ReceiversByEventName.Add(audioEventGroup.customEventName, new Dictionary<ICustomEventReceiver, Transform> { { receiver, receiverTrans } });
					continue;
				}
				Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[audioEventGroup.customEventName];
				if (!dictionary.ContainsKey(receiver))
				{
					dictionary.Add(receiver, receiverTrans);
				}
			}
		}

		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
			if (AppIsShuttingDown || SafeInstance == null)
			{
				if (!(SafeInstance != null))
				{
					return;
				}
				{
					foreach (string key in Instance.ReceiversByEventName.Keys)
					{
						Instance.ReceiversByEventName[key].Remove(receiver);
					}
					return;
				}
			}
			for (int i = 0; i < Instance.customEvents.Count; i++)
			{
				CustomEvent customEvent = Instance.customEvents[i];
				if (receiver.SubscribesToEvent(customEvent.EventName))
				{
					Instance.ReceiversByEventName[customEvent.EventName].Remove(receiver);
				}
			}
		}

		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			List<Transform> list = new List<Transform>();
			if (!Instance.ReceiversByEventName.ContainsKey(customEventName))
			{
				return list;
			}
			Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[customEventName];
			foreach (ICustomEventReceiver key in dictionary.Keys)
			{
				if (key.SubscribesToEvent(customEventName))
				{
					list.Add(dictionary[key]);
				}
			}
			return list;
		}

		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			if (AppIsShuttingDown)
			{
				return null;
			}
			if (Instance.customEventCategories.FindAll((CustomEventCategory cat) => cat.CatName == categoryName).Count > 0)
			{
				return null;
			}
			CustomEventCategory customEventCategory = new CustomEventCategory
			{
				CatName = categoryName,
				ProspectiveName = categoryName,
				IsTemporary = isTemporary
			};
			Instance.customEventCategories.Add(customEventCategory);
			return customEventCategory;
		}

		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
			if (AppIsShuttingDown)
			{
				return;
			}
			if (Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName).Count > 0)
			{
				if (errorOnDuplicate)
				{
					UnityEngine.Debug.LogError("You already have a Custom Event named '" + customEventName + "'. No need to add it again.");
				}
				return;
			}
			if (string.IsNullOrEmpty(categoryName))
			{
				categoryName = Instance.customEventCategories[0].CatName;
			}
			CustomEvent item = new CustomEvent(customEventName)
			{
				eventReceiveMode = eventReceiveMode,
				distanceThreshold = distanceThreshold,
				eventRcvFilterMode = receiveFilter,
				filterModeQty = filterModeQty,
				categoryName = categoryName,
				isTemporary = isTemporary
			};
			Instance.customEvents.Add(item);
		}

		public static void DeleteCustomEvent(string customEventName)
		{
			if (!AppIsShuttingDown && !(SafeInstance == null))
			{
				Instance.customEvents.RemoveAll((CustomEvent obj) => obj.EventName == customEventName);
			}
		}

		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			List<CustomEvent> list = Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName);
			if (list.Count <= 0)
			{
				return null;
			}
			return list[0];
		}

		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
			if (AppIsShuttingDown || "[None]" == customEventName || string.IsNullOrEmpty(customEventName))
			{
				return;
			}
			if (originObject == null)
			{
				UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' cannot be fired without an originObject passed in.");
				return;
			}
			if (!CustomEventExists(customEventName) && !IsWarming)
			{
				UnityEngine.Debug.LogError("Custom Event '" + customEventName + "' was not found in Master Audio.");
				return;
			}
			CustomEvent customEventByName = GetCustomEventByName(customEventName);
			if (customEventByName == null)
			{
				return;
			}
			if (customEventByName.frameLastFired >= AudioUtil.FrameCount)
			{
				if (logDupe)
				{
					UnityEngine.Debug.LogWarning("Already fired Custom Event '" + customEventName + "' this frame or later. Cannot be fired twice in the same frame.");
				}
				return;
			}
			customEventByName.frameLastFired = AudioUtil.FrameCount;
			if (!Instance.disableLogging && Instance.logCustomEvents)
			{
				UnityEngine.Debug.Log("Firing Custom Event: " + customEventName);
			}
			if (!Instance.ReceiversByEventName.ContainsKey(customEventName))
			{
				return;
			}
			Vector3 position = originObject.position;
			float? num = null;
			Dictionary<ICustomEventReceiver, Transform> dictionary = Instance.ReceiversByEventName[customEventName];
			List<ICustomEventReceiver> list = null;
			switch (customEventByName.eventReceiveMode)
			{
			case CustomEventReceiveMode.Never:
				if (Instance.LogSounds)
				{
					UnityEngine.Debug.LogWarning("Custom Event '" + customEventName + "' not being transmitted because it is set to 'Never transmit'.");
				}
				return;
			case CustomEventReceiveMode.OnChildGameObject:
				list = GetChildReceivers(originObject, customEventName, includeSelf: false);
				break;
			case CustomEventReceiveMode.OnParentGameObject:
				list = GetParentReceivers(originObject, customEventName, includeSelf: false);
				break;
			case CustomEventReceiveMode.OnSameOrChildGameObject:
				list = GetChildReceivers(originObject, customEventName, includeSelf: true);
				break;
			case CustomEventReceiveMode.OnSameOrParentGameObject:
				list = GetParentReceivers(originObject, customEventName, includeSelf: true);
				break;
			case CustomEventReceiveMode.WhenDistanceLessThan:
			case CustomEventReceiveMode.WhenDistanceMoreThan:
				num = customEventByName.distanceThreshold * customEventByName.distanceThreshold;
				break;
			}
			if (list == null)
			{
				list = new List<ICustomEventReceiver>();
				foreach (ICustomEventReceiver key in dictionary.Keys)
				{
					switch (customEventByName.eventReceiveMode)
					{
					case CustomEventReceiveMode.WhenDistanceLessThan:
						if ((dictionary[key].position - position).sqrMagnitude > num)
						{
							continue;
						}
						break;
					case CustomEventReceiveMode.WhenDistanceMoreThan:
						if ((dictionary[key].position - position).sqrMagnitude < num)
						{
							continue;
						}
						break;
					case CustomEventReceiveMode.OnSameGameObject:
						if (originObject != dictionary[key])
						{
							continue;
						}
						break;
					}
					list.Add(key);
				}
			}
			if (customEventByName.eventRcvFilterMode == EventReceiveFilter.All || customEventByName.filterModeQty >= list.Count || list.Count <= 1)
			{
				for (int i = 0; i < list.Count; i++)
				{
					list[i].ReceiveEvent(customEventName, position);
				}
				return;
			}
			Instance.ValidReceivers.Clear();
			for (int j = 0; j < list.Count; j++)
			{
				ICustomEventReceiver customEventReceiver = list[j];
				Transform transform = dictionary[customEventReceiver];
				float distance = 0f;
				int randomId = 0;
				switch (customEventByName.eventRcvFilterMode)
				{
				case EventReceiveFilter.Random:
					randomId = UnityEngine.Random.Range(0, 1000);
					break;
				case EventReceiveFilter.Closest:
					distance = (transform.position - position).sqrMagnitude;
					break;
				}
				Instance.ValidReceivers.Add(new CustomEventCandidate(distance, customEventReceiver, transform, randomId));
			}
			switch (customEventByName.eventRcvFilterMode)
			{
			case EventReceiveFilter.Closest:
			{
				Instance.ValidReceivers.Sort((CustomEventCandidate x, CustomEventCandidate y) => x.DistanceAway.CompareTo(y.DistanceAway));
				int filterModeQty = customEventByName.filterModeQty;
				int count = Instance.ValidReceivers.Count - filterModeQty;
				Instance.ValidReceivers.RemoveRange(filterModeQty, count);
				break;
			}
			case EventReceiveFilter.Random:
			{
				Instance.ValidReceivers.Sort((CustomEventCandidate x, CustomEventCandidate y) => x.RandomId.CompareTo(y.RandomId));
				int filterModeQty = customEventByName.filterModeQty;
				int count = Instance.ValidReceivers.Count - filterModeQty;
				Instance.ValidReceivers.RemoveRange(filterModeQty, count);
				break;
			}
			}
			for (int k = 0; k < Instance.ValidReceivers.Count; k++)
			{
				Instance.ValidReceivers[k].Receiver.ReceiveEvent(customEventName, position);
			}
		}

		public static bool CustomEventExists(string customEventName)
		{
			if (AppIsShuttingDown)
			{
				return true;
			}
			return Instance.customEvents.FindAll((CustomEvent obj) => obj.EventName == customEventName).Count > 0;
		}

		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			List<ICustomEventReceiver> list = origin.GetComponentsInChildren<ICustomEventReceiver>().ToList();
			list.RemoveAll((ICustomEventReceiver rec) => !rec.SubscribesToEvent(eventName));
			if (includeSelf)
			{
				return list;
			}
			return FilterOutSelf(list, origin);
		}

		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			List<ICustomEventReceiver> list = origin.GetComponentsInParent<ICustomEventReceiver>().ToList();
			list.RemoveAll((ICustomEventReceiver rec) => !rec.SubscribesToEvent(eventName));
			if (includeSelf)
			{
				return list;
			}
			return FilterOutSelf(list, origin);
		}

		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			List<ICustomEventReceiver> list = new List<ICustomEventReceiver>();
			foreach (ICustomEventReceiver source in sourceList)
			{
				MonoBehaviour monoBehaviour = source as MonoBehaviour;
				if (!(monoBehaviour == null) && !(monoBehaviour.transform != origin))
				{
					list.Add(source);
				}
			}
			int num = 0;
			while (list.Count > 0 && num < 20)
			{
				sourceList.Remove(list[0]);
				list.RemoveAt(0);
				num++;
			}
			return sourceList;
		}

		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			if (IsWarming)
			{
				return false;
			}
			if (Instance.disableLogging)
			{
				return false;
			}
			if (grp != null && grp.logSound)
			{
				return true;
			}
			return Instance.LogSounds;
		}

		private static void LogMessage(string message)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.Log("T: " + Time.time + " - MasterAudio: " + message);
			}
		}

		public static void LogWarning(string msg)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.LogWarning(msg);
			}
		}

		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
			if (!ErrorNumbersLogged.Contains(errorNumber))
			{
				UnityEngine.Debug.LogWarning(msg);
				ErrorNumbersLogged.Add(errorNumber);
			}
		}

		public static void LogError(string msg)
		{
			if (!Instance.disableLogging)
			{
				UnityEngine.Debug.LogError(msg);
			}
		}

		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
			LogWarning("There is currently no Playlist assigned to Playlist Controller '" + playlistControllerName + "'. Cannot call '" + methodName + "' method.");
		}

		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			if (pcs.Count == 0)
			{
				LogError($"You have no Playlist Controllers in the Scene. You cannot '{methodName}'.");
				return false;
			}
			if (pcs.Count > 1)
			{
				LogError($"You cannot call '{methodName}' without specifying a Playlist Controller name when you have more than one Playlist Controller.");
				return false;
			}
			return true;
		}

		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
			if (!AppIsShuttingDown && !(ambient == null) && Instance.AmbientsToDelayedTrigger.Find((AmbientSoundToTriggerInfo obj) => obj.ambient == ambient) == null)
			{
				Instance.AmbientsToDelayedTrigger.Add(new AmbientSoundToTriggerInfo
				{
					frameToTrigger = Time.frameCount + 1,
					ambient = ambient
				});
			}
		}

		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
			if (!AppIsShuttingDown && !(ambient == null))
			{
				Instance.AmbientsToDelayedTrigger.RemoveAll((AmbientSoundToTriggerInfo obj) => obj.ambient == ambient);
			}
		}

		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
			if (SafeInstance == null)
			{
				return;
			}
			foreach (TransformFollower transFollowerColliderPositionRecalc in Instance.TransFollowerColliderPositionRecalcs)
			{
				if (transFollowerColliderPositionRecalc == follower)
				{
					return;
				}
			}
			Instance.TransFollowerColliderPositionRecalcs.Enqueue(follower);
		}

		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
			if (SafeInstance == null)
			{
				return;
			}
			foreach (SoundGroupVariationUpdater queuedOcclusionRay in Instance.QueuedOcclusionRays)
			{
				if (queuedOcclusionRay == updater)
				{
					return;
				}
			}
			Instance.QueuedOcclusionRays.Enqueue(updater);
		}

		public static void AddToOcclusionInRangeSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (!Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Add(src);
				}
				if (Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Remove(src);
				}
			}
		}

		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (!Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Add(src);
				}
				if (Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Remove(src);
				}
				RemoveFromBlockedOcclusionSources(src);
			}
		}

		public static void AddToBlockedOcclusionSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories && !Instance.OcclusionSourcesBlocked.Contains(src))
			{
				Instance.OcclusionSourcesBlocked.Add(src);
			}
		}

		public static bool HasQueuedOcclusionRays()
		{
			return Instance.QueuedOcclusionRays.Count > 0;
		}

		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			if (SafeInstance == null)
			{
				return null;
			}
			return Instance.QueuedOcclusionRays.Dequeue();
		}

		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				if (Instance.VariationOcclusionFreqChanges[i].ActingVariation == variation)
				{
					return true;
				}
			}
			return false;
		}

		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
			for (int i = 0; i < Instance.VariationOcclusionFreqChanges.Count; i++)
			{
				if (!(Instance.VariationOcclusionFreqChanges[i].ActingVariation != variation))
				{
					Instance.VariationOcclusionFreqChanges.RemoveAt(i);
					break;
				}
			}
		}

		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories && Instance.OcclusionSourcesBlocked.Contains(src))
			{
				Instance.OcclusionSourcesBlocked.Remove(src);
			}
		}

		public static void StopTrackingOcclusionForSource(GameObject src)
		{
			if (Application.isEditor && !(SafeInstance == null) && Instance.occlusionShowCategories)
			{
				if (Instance.OcclusionSourcesOutOfRange.Contains(src))
				{
					Instance.OcclusionSourcesOutOfRange.Remove(src);
				}
				if (Instance.OcclusionSourcesInRange.Contains(src))
				{
					Instance.OcclusionSourcesInRange.Remove(src);
				}
				if (Instance.OcclusionSourcesBlocked.Contains(src))
				{
					Instance.OcclusionSourcesBlocked.Remove(src);
				}
			}
		}

		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			if (!Instance._isStoppingMultiple)
			{
				return false;
			}
			return Instance.VariationsStartedDuringMultiStop.Contains(variation);
		}

		public static int RemainingClipsInGroup(string sType)
		{
			if (!Instance._randomizer.ContainsKey(sType))
			{
				return 0;
			}
			return Instance._randomizer[sType].Count;
		}

		public static void RescanGroupsNow()
		{
			Instance._mustRescanGroups = true;
		}

		public static void DoneRescanningGroups()
		{
			Instance._mustRescanGroups = false;
		}

		public static GameObject CreateMasterAudio()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/MasterAudio.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find MasterAudio prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject obj = UnityEngine.Object.Instantiate(@object) as GameObject;
			obj.name = "MasterAudio";
			return obj;
		}

		public static GameObject CreatePlaylistController()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/PlaylistController.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find PlaylistController prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject obj = UnityEngine.Object.Instantiate(@object) as GameObject;
			obj.name = "PlaylistController";
			return obj;
		}

		public static GameObject CreateDynamicSoundGroupCreator()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/DynamicSoundGroupCreator.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find DynamicSoundGroupCreator prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject obj = UnityEngine.Object.Instantiate(@object) as GameObject;
			obj.name = "DynamicSoundGroupCreator";
			return obj;
		}

		public static GameObject CreateSoundGroupOrganizer()
		{
			UnityEngine.Object @object = Resources.Load("Assets/Plugins/DarkTonic/MasterAudio/Prefabs/SoundGroupOrganizer.prefab", typeof(GameObject));
			if (@object == null)
			{
				UnityEngine.Debug.LogError("Could not find SoundGroupOrganizer prefab. Please update the Installation Path in the Master Audio Manager window if you have moved the folder from its default location, then try again.");
				return null;
			}
			GameObject obj = UnityEngine.Object.Instantiate(@object) as GameObject;
			obj.name = "SoundGroupOrganizer";
			return obj;
		}
	}
	public static class PersistentAudioSettings
	{
		public const string SfxVolKey = "MA_sfxVolume";

		public const string MusicVolKey = "MA_musicVolume";

		public const string SfxMuteKey = "MA_sfxMute";

		public const string MusicMuteKey = "MA_musicMute";

		public const string BusVolKey = "MA_BusVolume_";

		public const string GroupVolKey = "MA_GroupVolume_";

		public const string BusKeysKey = "MA_BusKeys";

		public const string GroupKeysKey = "MA_GroupsKeys";

		public const string Separator = ";";

		public static string BusesUpdatedKeys
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_BusKeys"))
				{
					PlayerPrefs.SetString("MA_BusKeys", ";");
				}
				return PlayerPrefs.GetString("MA_BusKeys");
			}
			set
			{
				PlayerPrefs.SetString("MA_BusKeys", value);
			}
		}

		public static string GroupsUpdatedKeys
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_GroupsKeys"))
				{
					PlayerPrefs.SetString("MA_GroupsKeys", ";");
				}
				return PlayerPrefs.GetString("MA_GroupsKeys");
			}
			set
			{
				PlayerPrefs.SetString("MA_GroupsKeys", value);
			}
		}

		public static bool? MixerMuted
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_sfxMute"))
				{
					return null;
				}
				return PlayerPrefs.GetInt("MA_sfxMute") != 0;
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_sfxMute");
					return;
				}
				bool value2 = value.Value;
				PlayerPrefs.SetInt("MA_sfxMute", value2 ? 1 : 0);
				if (MasterAudio.SafeInstance != null)
				{
					MasterAudio.MixerMuted = value2;
				}
			}
		}

		public static float? MixerVolume
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_sfxVolume"))
				{
					return null;
				}
				return PlayerPrefs.GetFloat("MA_sfxVolume");
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_sfxVolume");
					return;
				}
				float value2 = value.Value;
				PlayerPrefs.SetFloat("MA_sfxVolume", value2);
				if (MasterAudio.SafeInstance != null)
				{
					MasterAudio.MasterVolumeLevel = value2;
				}
			}
		}

		public static bool? MusicMuted
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_musicMute"))
				{
					return null;
				}
				return PlayerPrefs.GetInt("MA_musicMute") != 0;
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_musicMute");
					return;
				}
				bool value2 = value.Value;
				PlayerPrefs.SetInt("MA_musicMute", value2 ? 1 : 0);
				if (MasterAudio.SafeInstance != null)
				{
					MasterAudio.PlaylistsMuted = value2;
				}
			}
		}

		public static float? MusicVolume
		{
			get
			{
				if (!PlayerPrefs.HasKey("MA_musicVolume"))
				{
					return null;
				}
				return PlayerPrefs.GetFloat("MA_musicVolume");
			}
			set
			{
				if (!value.HasValue)
				{
					PlayerPrefs.DeleteKey("MA_musicVolume");
					return;
				}
				float value2 = value.Value;
				PlayerPrefs.SetFloat("MA_musicVolume", value2);
				if (MasterAudio.SafeInstance != null)
				{
					MasterAudio.PlaylistMasterVolume = value2;
				}
			}
		}

		public static void SetBusVolume(string busName, float vol)
		{
			PlayerPrefs.SetFloat(MakeBusKey(busName), vol);
			if (!(MasterAudio.SafeInstance == null))
			{
				if (MasterAudio.GrabBusByName(busName) != null)
				{
					MasterAudio.SetBusVolumeByName(busName, vol);
				}
				if (!BusesUpdatedKeys.Contains(";" + busName + ";"))
				{
					BusesUpdatedKeys = BusesUpdatedKeys + busName + ";";
				}
			}
		}

		public static string MakeBusKey(string busName)
		{
			return "MA_BusVolume_" + busName;
		}

		public static float? GetBusVolume(string busName)
		{
			string key = MakeBusKey(busName);
			if (!PlayerPrefs.HasKey(key))
			{
				return null;
			}
			return PlayerPrefs.GetFloat(key);
		}

		public static string GetGroupKey(string groupName)
		{
			return "MA_GroupVolume_" + groupName;
		}

		public static void SetGroupVolume(string grpName, float vol)
		{
			PlayerPrefs.SetFloat(GetGroupKey(grpName), vol);
			if (!(MasterAudio.SafeInstance == null))
			{
				if (MasterAudio.GrabGroup(grpName, logIfMissing: false) != null)
				{
					MasterAudio.SetGroupVolume(grpName, vol);
				}
				if (!GroupsUpdatedKeys.Contains(";" + grpName + ";"))
				{
					GroupsUpdatedKeys = GroupsUpdatedKeys + grpName + ";";
				}
			}
		}

		public static float? GetGroupVolume(string grpName)
		{
			string groupKey = GetGroupKey(grpName);
			if (!PlayerPrefs.HasKey(groupKey))
			{
				return null;
			}
			return PlayerPrefs.GetFloat(groupKey);
		}

		public static void RestoreMasterSettings()
		{
			if (MixerVolume.HasValue)
			{
				MasterAudio.MasterVolumeLevel = MixerVolume.Value;
			}
			if (MixerMuted.HasValue)
			{
				MasterAudio.MixerMuted = MixerMuted.Value;
			}
			if (MusicVolume.HasValue)
			{
				MasterAudio.PlaylistMasterVolume = MusicVolume.Value;
			}
			if (MusicMuted.HasValue)
			{
				MasterAudio.PlaylistsMuted = MusicMuted.Value;
			}
		}
	}
	public class SoundGroupOrganizer : MonoBehaviour
	{
		public class CustomEventSelection
		{
			public CustomEvent Event;

			public bool IsSelected;

			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
				Event = cEvent;
				IsSelected = isSelected;
			}
		}

		public class SoundGroupSelection
		{
			public GameObject Go;

			public bool IsSelected;

			public SoundGroupSelection(GameObject go, bool isSelected)
			{
				Go = go;
				IsSelected = isSelected;
			}
		}

		public enum MAItemType
		{
			SoundGroups,
			CustomEvents
		}

		public enum TransferMode
		{
			None,
			Import,
			Export
		}

		public GameObject dynGroupTemplate;

		public GameObject dynVariationTemplate;

		public GameObject maGroupTemplate;

		public GameObject maVariationTemplate;

		public MasterAudio.DragGroupMode curDragGroupMode;

		public MasterAudio.AudioLocation bulkVariationMode;

		public SystemLanguage previewLanguage = SystemLanguage.English;

		public bool useTextGroupFilter;

		public string textGroupFilter = string.Empty;

		public TransferMode transMode;

		public GameObject sourceObject;

		public List<SoundGroupSelection> selectedSourceSoundGroups = new List<SoundGroupSelection>();

		public GameObject destObject;

		public List<SoundGroupSelection> selectedDestSoundGroups = new List<SoundGroupSelection>();

		public MAItemType itemType;

		public List<CustomEventSelection> selectedSourceCustomEvents = new List<CustomEventSelection>();

		public List<CustomEventSelection> selectedDestCustomEvents = new List<CustomEventSelection>();

		public List<CustomEvent> customEvents = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public string newEventName = "my event";

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		private void Awake()
		{
			UnityEngine.Debug.LogError("You have a Sound Group Organizer prefab in this Scene. You should never play a Scene with that type of prefab as it could take up tremendous amounts of audio memory. Please use a Sandbox Scene for that, which is only used to make changes to that prefab and apply them. This Sandbox Scene should never be a Scene that is played in the game.");
		}
	}
	public static class AmbientUtil
	{
		public const string FollowerHolderName = "_Followers";

		public const string ListenerFollowerName = "~ListenerFollower~";

		public const float ListenerFollowerTrigRadius = 0.01f;

		public const int IgnoreRaycastLayerNumber = 2;

		private static Transform _followerHolder;

		private static ListenerFollower _listenerFollower;

		private static Rigidbody _listenerFollowerRB;

		private static List<TransformFollower> _transformFollowers = new List<TransformFollower>();

		public static ListenerFollower ListenerFollower
		{
			get
			{
				if (_listenerFollower != null)
				{
					return _listenerFollower;
				}
				if (FollowerHolder == null)
				{
					return null;
				}
				Transform transform = FollowerHolder.GetChildTransform("~ListenerFollower~");
				if (transform == null)
				{
					transform = new GameObject("~ListenerFollower~").transform;
					transform.parent = FollowerHolder;
					transform.gameObject.layer = FollowerHolder.gameObject.layer;
				}
				_listenerFollower = transform.GetComponent<ListenerFollower>();
				if (_listenerFollower == null)
				{
					_listenerFollower = transform.gameObject.AddComponent<ListenerFollower>();
				}
				if (MasterAudio.Instance.listenerFollowerHasRigidBody)
				{
					Rigidbody rigidbody = transform.gameObject.GetComponent<Rigidbody>();
					if (rigidbody == null)
					{
						rigidbody = transform.gameObject.AddComponent<Rigidbody>();
					}
					rigidbody.useGravity = false;
					_listenerFollowerRB = rigidbody;
				}
				return _listenerFollower;
			}
		}

		public static Transform FollowerHolder
		{
			get
			{
				if (!Application.isPlaying || MasterAudio.SafeInstance == null)
				{
					return null;
				}
				if (_followerHolder != null)
				{
					return _followerHolder;
				}
				Transform trans = MasterAudio.SafeInstance.Trans;
				_followerHolder = trans.GetChildTransform("_Followers");
				if (_followerHolder != null)
				{
					return _followerHolder;
				}
				_followerHolder = new GameObject("_Followers").transform;
				_followerHolder.parent = trans;
				_followerHolder.gameObject.layer = trans.gameObject.layer;
				return _followerHolder;
			}
		}

		public static bool HasListenerFollower => _listenerFollower != null;

		public static bool HasListenerFolowerRigidBody => _listenerFollowerRB != null;

		public static void InitFollowerHolder()
		{
			Transform followerHolder = FollowerHolder;
			if (followerHolder != null)
			{
				followerHolder.DestroyAllChildren();
			}
		}

		public static bool InitListenerFollower()
		{
			Transform listenerTrans = MasterAudio.ListenerTrans;
			if (listenerTrans == null)
			{
				return false;
			}
			ListenerFollower listenerFollower = ListenerFollower;
			if (listenerFollower == null)
			{
				return false;
			}
			listenerFollower.StartFollowing(listenerTrans, 0.01f);
			return true;
		}

		public static void RemoveTransformFollower(TransformFollower follower)
		{
			_transformFollowers.Remove(follower);
		}

		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			if (ListenerFollower == null || FollowerHolder == null)
			{
				return null;
			}
			MasterAudioGroup masterAudioGroup = MasterAudio.GrabGroup(soundGroupName);
			if (masterAudioGroup == null)
			{
				return null;
			}
			if (masterAudioGroup.groupVariations.Count == 0)
			{
				return null;
			}
			SoundGroupVariation soundGroupVariation = null;
			if (!string.IsNullOrEmpty(variationName))
			{
				soundGroupVariation = masterAudioGroup.groupVariations.Find((SoundGroupVariation v) => v.name == variationName);
				if (soundGroupVariation == null)
				{
					UnityEngine.Debug.LogError("Could not find Variation '" + variationName + "' in Sound Group '" + soundGroupName);
					return null;
				}
			}
			else
			{
				soundGroupVariation = masterAudioGroup.groupVariations[0];
			}
			float maxDistance = soundGroupVariation.VarAudio.maxDistance;
			GameObject gameObject = new GameObject(followerName);
			Transform childTransform = FollowerHolder.GetChildTransform(followerName);
			if (childTransform != null)
			{
				UnityEngine.Object.Destroy(childTransform.gameObject);
			}
			gameObject.transform.parent = FollowerHolder;
			gameObject.gameObject.layer = FollowerHolder.gameObject.layer;
			TransformFollower transformFollower = gameObject.gameObject.AddComponent<TransformFollower>();
			transformFollower.StartFollowing(transToFollow, soundGroupName, variationName, volume, maxDistance, willFollowSource, willPositionOnClosestColliderPoint, useTopCollider, useChildColliders, exitMode, exitFadeTime, reEnterMode, reEnterFadeTime);
			_transformFollowers.Add(transformFollower);
			return gameObject.transform;
		}

		public static void ManualUpdate()
		{
			UpdateListenerFollower();
			for (int i = 0; i < _transformFollowers.Count; i++)
			{
				_transformFollowers[i].ManualUpdate();
			}
		}

		private static void UpdateListenerFollower()
		{
			if (_listenerFollower != null)
			{
				_listenerFollower.ManualUpdate();
			}
		}
	}
	public static class ArrayListUtil
	{
		public static void SortIntArray(ref List<int> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				int value = list[i];
				int index = UnityEngine.Random.Range(i, list.Count);
				list[i] = list[index];
				list[index] = value;
			}
		}

		public static bool IsExcludedChildName(string name)
		{
			return MasterAudio.ExemptChildNames.Contains(name);
		}
	}
	public static class AudioTransformExtensions
	{
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
			MasterAudio.FadeOutSoundGroupOfTransform(sourceTrans, sType, fadeTime);
		}

		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return MasterAudio.GetAllPlayingVariationsOfTransform(sourceTrans);
		}

		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DAtTransformAndForget(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DAtTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DFollowTransformAndForget(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null)
		{
			return MasterAudio.PlaySound3DFollowTransform(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName);
		}

		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			return MasterAudio.PlaySound3DAtTransformAndWaitUntilFinished(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, completedAction);
		}

		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, float? pitch = null, float delaySoundTime = 0f, string variationName = null, double? timeToSchedulePlay = null, Action completedAction = null)
		{
			return MasterAudio.PlaySound3DFollowTransformAndWaitUntilFinished(sType, sourceTrans, volumePercentage, pitch, delaySoundTime, variationName, timeToSchedulePlay, completedAction);
		}

		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
			MasterAudio.PauseAllSoundsOfTransform(sourceTrans);
		}

		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.PauseBusOfTransform(sourceTrans, busName);
		}

		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.PauseSoundGroupOfTransform(sourceTrans, sType);
		}

		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
			MasterAudio.StopAllSoundsOfTransform(sourceTrans);
		}

		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.StopBusOfTransform(sourceTrans, busName);
		}

		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.StopSoundGroupOfTransform(sourceTrans, sType);
		}

		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
			MasterAudio.UnpauseAllSoundsOfTransform(sourceTrans);
		}

		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
			MasterAudio.UnpauseBusOfTransform(sourceTrans, busName);
		}

		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
			MasterAudio.UnpauseSoundGroupOfTransform(sourceTrans, sType);
		}

		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return MasterAudio.IsTransformPlayingSoundGroup(sType, sourceTrans);
		}
	}
	public class AudioTransformTracker : MonoBehaviour
	{
		public int _frames;

		private Transform _trans;

		public Transform Trans
		{
			get
			{
				if (_trans == null)
				{
					_trans = base.transform;
				}
				return _trans;
			}
		}

		private void Update()
		{
			_frames++;
		}
	}
	public static class AudioUtil
	{
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		private const float SemitonePitchChangeAmt = 1.0594635f;

		public static float FixedDeltaTime => UnityEngine.Time.fixedDeltaTime;

		public static float FrameTime => UnityEngine.Time.unscaledDeltaTime;

		public static float Time => UnityEngine.Time.unscaledTime;

		public static int FrameCount => UnityEngine.Time.frameCount;

		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return updater.MinOcclusionFreq - updater.MaxOcclusionFreq;
		}

		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return updater.MaxOcclusionFreq;
		}

		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return updater.MinOcclusionFreq;
		}

		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return MaxCutoffFreq(updater) + distRatio * CutoffRange(updater);
		}

		public static float GetSemitonesFromPitch(float pitch)
		{
			if (pitch < 1f && pitch > 0f)
			{
				return Mathf.Log(1f / pitch, 1.0594635f) * -1f;
			}
			return Mathf.Log(pitch, 1.0594635f);
		}

		public static float GetPitchFromSemitones(float semitones)
		{
			if (semitones >= 0f)
			{
				return Mathf.Pow(1.0594635f, semitones);
			}
			return 1f / Mathf.Pow(1.0594635f, Mathf.Abs(semitones));
		}

		public static float GetDbFromFloatVolume(float vol)
		{
			return Mathf.Log10(vol) * 20f;
		}

		public static float GetFloatVolumeFromDb(float db)
		{
			return Mathf.Pow(10f, db / 20f);
		}

		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			if (source.clip == null || source.time == 0f)
			{
				return 0f;
			}
			return source.time / source.clip.length * 100f;
		}

		public static bool IsClipPaused(AudioSource source)
		{
			if (!source.isPlaying)
			{
				return GetAudioPlayedPercentage(source) > 0f;
			}
			return false;
		}

		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
			if (!AudioClipWillPreload(clip))
			{
				AudioLoaderOptimizer.AddNonPreloadedPlayingClip(clip, actor);
			}
		}

		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
			if (!(clip == null) && !AudioClipWillPreload(clip))
			{
				AudioLoaderOptimizer.RemoveNonPreloadedPlayingClip(clip, actor);
				if (!AudioLoaderOptimizer.IsAnyOfNonPreloadedClipPlaying(clip))
				{
					clip.UnloadAudioData();
				}
			}
		}

		public static bool AudioClipWillPreload(AudioClip clip)
		{
			if (clip == null)
			{
				return false;
			}
			return clip.preloadAudioData;
		}

		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			if (clip != null)
			{
				return clip.loadType != AudioClipLoadType.Streaming;
			}
			return false;
		}

		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return GetPositiveUsablePitch(source.pitch);
		}

		private static float GetPositiveUsablePitch(float pitch)
		{
			if (!(pitch > 0f))
			{
				return 1f;
			}
			return pitch;
		}

		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return AdjustAudioClipDurationForPitch(duration, sourceWithPitch.pitch);
		}

		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return duration / GetPositiveUsablePitch(pitch);
		}

		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return duration * GetPositiveUsablePitch(sourceWithPitch);
		}
	}
	public static class CoroutineHelper
	{
		public static IEnumerator WaitForActualSeconds(float time)
		{
			float start = AudioUtil.Time;
			while (AudioUtil.Time < start + time)
			{
				yield return MasterAudio.EndOfFrameDelay;
			}
		}
	}
	public class DelayBetweenSongs : MonoBehaviour
	{
		public float minTimeToWait = 1f;

		public float maxTimeToWait = 2f;

		public string playlistControllerName = "PlaylistControllerBass";

		private PlaylistController _controller;

		private void Start()
		{
			_controller = PlaylistController.InstanceByName(playlistControllerName);
			_controller.SongEnded += SongEnded;
		}

		private void OnDisable()
		{
			_controller.SongEnded -= SongEnded;
		}

		private void SongEnded(string songName)
		{
			StopAllCoroutines();
			StartCoroutine(PlaySongWithDelay());
		}

		private IEnumerator PlaySongWithDelay()
		{
			float num = UnityEngine.Random.Range(minTimeToWait, maxTimeToWait);
			if (MasterAudio.IgnoreTimeScale)
			{
				yield return StartCoroutine(CoroutineHelper.WaitForActualSeconds(num));
			}
			else
			{
				yield return new WaitForSeconds(num);
			}
			_controller.PlayNextSong();
		}
	}
	public static class DTMonoHelper
	{
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return transParent.Find(childName);
		}

		public static bool IsActive(GameObject go)
		{
			return go.activeInHierarchy;
		}

		public static void SetActive(GameObject go, bool isActive)
		{
			go.SetActive(isActive);
		}

		public static void DestroyAllChildren(this Transform tran)
		{
			List<GameObject> list = new List<GameObject>();
			for (int i = 0; i < tran.childCount; i++)
			{
				list.Add(tran.GetChild(i).gameObject);
			}
			int num = 0;
			while (list.Count > 0 && num < 200)
			{
				GameObject gameObject = list[0];
				UnityEngine.Object.Destroy(gameObject);
				if (list[0] == gameObject)
				{
					list.RemoveAt(0);
				}
				num++;
			}
		}
	}
	[AudioScriptOrder(-35)]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		public enum CreateItemsWhen
		{
			FirstEnableOnly,
			EveryEnable
		}

		public const int ExtraHardCodedBusOptions = 1;

		public SystemLanguage previewLanguage = SystemLanguage.English;

		public MasterAudio.DragGroupMode curDragGroupMode;

		public GameObject groupTemplate;

		public GameObject variationTemplate;

		public bool errorOnDuplicates;

		public bool createOnAwake = true;

		public bool soundGroupsAreExpanded = true;

		public bool removeGroupsOnSceneChange = true;

		public CreateItemsWhen reUseMode;

		public bool showCustomEvents = true;

		public MasterAudio.AudioLocation bulkVariationMode;

		public List<CustomEvent> customEventsToCreate = new List<CustomEvent>();

		public List<CustomEventCategory> customEventCategories = new List<CustomEventCategory>
		{
			new CustomEventCategory()
		};

		public string newEventName = "my event";

		public string newCustomEventCategoryName = "New Category";

		public string addToCustomEventCategoryName = "New Category";

		public bool showMusicDucking = true;

		public List<DuckGroupInfo> musicDuckingSounds = new List<DuckGroupInfo>();

		public List<GroupBus> groupBuses = new List<GroupBus>();

		public bool playListExpanded;

		public bool playlistEditorExp = true;

		public List<MasterAudio.Playlist> musicPlaylists = new List<MasterAudio.Playlist>();

		public List<GameObject> audioSourceTemplates = new List<GameObject>(10);

		public string audioSourceTemplateName = "Max Distance 500";

		public bool groupByBus;

		public bool itemsCreatedEventExpanded;

		public string itemsCreatedCustomEvent = string.Empty;

		public bool showUnityMixerGroupAssignment = true;

		private bool _hasCreated;

		private readonly List<Transform> _groupsToRemove = new List<Transform>();

		private Transform _trans;

		private readonly List<DynamicSoundGroup> _groupsToCreate = new List<DynamicSoundGroup>();

		public static int HardCodedBusOptions => 3;

		public List<DynamicSoundGroup> GroupsToCreate => _groupsToCreate;

		public bool ShouldShowUnityAudioMixerGroupAssignments => showUnityMixerGroupAssignment;

		private void Awake()
		{
			_trans = base.transform;
			_hasCreated = false;
			AudioSource component = GetComponent<AudioSource>();
			if (component != null)
			{
				UnityEngine.Object.Destroy(component);
			}
		}

		private void OnEnable()
		{
			CreateItemsIfReady();
		}

		private void Start()
		{
			CreateItemsIfReady();
		}

		private void OnDisable()
		{
			if (!MasterAudio.AppIsShuttingDown && removeGroupsOnSceneChange && MasterAudio.SafeInstance != null)
			{
				RemoveItems();
			}
		}

		private void CreateItemsIfReady()
		{
			if (!(MasterAudio.SafeInstance == null) && createOnAwake && MasterAudio.SoundsReady && !_hasCreated)
			{
				CreateItems();
			}
		}

		public void RemoveItems()
		{
			for (int i = 0; i < groupBuses.Count; i++)
			{
				GroupBus groupBus = groupBuses[i];
				if (!groupBus.isExisting)
				{
					MasterAudio.DeleteBusByName(groupBus.busName);
				}
			}
			for (int j = 0; j < _groupsToRemove.Count; j++)
			{
				string sType = _groupsToRemove[j].name;
				MasterAudio.RemoveSoundGroupFromDuckList(sType);
				MasterAudio.DeleteSoundGroup(sType);
			}
			_groupsToRemove.Clear();
			for (int k = 0; k < customEventsToCreate.Count; k++)
			{
				MasterAudio.DeleteCustomEvent(customEventsToCreate[k].EventName);
			}
			for (int l = 0; l < customEventCategories.Count; l++)
			{
				CustomEventCategory aCat = customEventCategories[l];
				MasterAudio.Instance.customEventCategories.RemoveAll((CustomEventCategory cat) => cat.CatName == aCat.CatName && cat.IsTemporary);
			}
			for (int m = 0; m < musicPlaylists.Count; m++)
			{
				MasterAudio.DeletePlaylist(musicPlaylists[m].playlistName);
			}
			if (reUseMode == CreateItemsWhen.EveryEnable)
			{
				_hasCreated = false;
			}
			MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange();
		}

		public void CreateItems()
		{
			if (_hasCreated)
			{
				UnityEngine.Debug.LogWarning("DynamicSoundGroupCreator '" + base.transform.name + "' has already created its items. Cannot create again.");
			}
			else
			{
				if (MasterAudio.Instance == null)
				{
					return;
				}
				PopulateGroupData();
				for (int i = 0; i < groupBuses.Count; i++)
				{
					GroupBus groupBus = groupBuses[i];
					if (groupBus.isExisting)
					{
						if (MasterAudio.GrabBusByName(groupBus.busName) == null)
						{
							MasterAudio.LogWarning("Existing bus '" + groupBus.busName + "' was not found, specified in prefab '" + base.name + "'.");
						}
					}
					else
					{
						if (!MasterAudio.CreateBus(groupBus.busName, errorOnDuplicates, isTemporary: true))
						{
							continue;
						}
						GroupBus groupBus2 = MasterAudio.GrabBusByName(groupBus.busName);
						if (groupBus2 != null)
						{
							if (!PersistentAudioSettings.GetBusVolume(groupBus.busName).HasValue)
							{
								groupBus2.volume = groupBus.volume;
								groupBus2.OriginalVolume = groupBus2.volume;
							}
							groupBus2.voiceLimit = groupBus.voiceLimit;
							groupBus2.stopOldest = groupBus.stopOldest;
							groupBus2.forceTo2D = groupBus.forceTo2D;
							groupBus2.mixerChannel = groupBus.mixerChannel;
							groupBus2.busColor = groupBus.busColor;
							groupBus2.isUsingOcclusion = groupBus.isUsingOcclusion;
						}
					}
				}
				for (int j = 0; j < _groupsToCreate.Count; j++)
				{
					DynamicSoundGroup dynamicSoundGroup = _groupsToCreate[j];
					string busName = string.Empty;
					int num = ((dynamicSoundGroup.busIndex != -1) ? dynamicSoundGroup.busIndex : 0);
					if (num >= HardCodedBusOptions)
					{
						busName = groupBuses[num - HardCodedBusOptions].busName;
					}
					dynamicSoundGroup.busName = busName;
					Transform transform = MasterAudio.CreateSoundGroup(dynamicSoundGroup, _trans.name, errorOnDuplicates);
					for (int k = 0; k < dynamicSoundGroup.groupVariations.Count; k++)
					{
						DynamicGroupVariation dynamicGroupVariation = dynamicSoundGroup.groupVariations[k];
						if (dynamicGroupVariation.LowPassFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.LowPassFilter);
						}
						if (dynamicGroupVariation.HighPassFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.HighPassFilter);
						}
						if (dynamicGroupVariation.DistortionFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.DistortionFilter);
						}
						if (dynamicGroupVariation.ChorusFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.ChorusFilter);
						}
						if (dynamicGroupVariation.EchoFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.EchoFilter);
						}
						if (dynamicGroupVariation.ReverbFilter != null)
						{
							UnityEngine.Object.Destroy(dynamicGroupVariation.ReverbFilter);
						}
					}
					if (!(transform == null))
					{
						_groupsToRemove.Add(transform);
					}
				}
				for (int l = 0; l < musicDuckingSounds.Count; l++)
				{
					DuckGroupInfo duckGroupInfo = musicDuckingSounds[l];
					if (!(duckGroupInfo.soundType == "[None]"))
					{
						MasterAudio.AddSoundGroupToDuckList(duckGroupInfo.soundType, duckGroupInfo.riseVolStart, duckGroupInfo.duckedVolumeCut, duckGroupInfo.unduckTime, isTemporary: true);
					}
				}
				for (int m = 0; m < customEventCategories.Count; m++)
				{
					MasterAudio.CreateCustomEventCategoryIfNotThere(customEventCategories[m].CatName, isTemporary: true);
				}
				for (int n = 0; n < customEventsToCreate.Count; n++)
				{
					CustomEvent customEvent = customEventsToCreate[n];
					MasterAudio.CreateCustomEvent(customEvent.EventName, customEvent.eventReceiveMode, customEvent.distanceThreshold, customEvent.eventRcvFilterMode, customEvent.filterModeQty, customEvent.categoryName, isTemporary: true, errorOnDuplicates);
				}
				for (int num2 = 0; num2 < musicPlaylists.Count; num2++)
				{
					MasterAudio.Playlist playlist = musicPlaylists[num2];
					playlist.isTemporary = true;
					MasterAudio.CreatePlaylist(playlist, errorOnDuplicates);
				}
				MasterAudio.SilenceOrUnsilenceGroupsFromSoloChange();
				_hasCreated = true;
				if (itemsCreatedEventExpanded)
				{
					FireEvents();
				}
			}
		}

		private void FireEvents()
		{
			MasterAudio.FireCustomEventNextFrame(itemsCreatedCustomEvent, _trans);
		}

		public void PopulateGroupData()
		{
			if (_trans == null)
			{
				_trans = base.transform;
			}
			_groupsToCreate.Clear();
			for (int i = 0; i < _trans.childCount; i++)
			{
				DynamicSoundGroup component = _trans.GetChild(i).GetComponent<DynamicSoundGroup>();
				if (component == null)
				{
					continue;
				}
				component.groupVariations.Clear();
				for (int j = 0; j < component.transform.childCount; j++)
				{
					DynamicGroupVariation component2 = component.transform.GetChild(j).GetComponent<DynamicGroupVariation>();
					if (!(component2 == null))
					{
						component.groupVariations.Add(component2);
					}
				}
				_groupsToCreate.Add(component);
			}
		}
	}
	public static class FilePlayerPrefs
	{
		private static readonly Hashtable PlayerPrefsHashtable;

		private static bool _hashTableChanged;

		private static string _serializedOutput;

		private static readonly string SerializedInput;

		private const string ParametersSeperator = ";";

		private const string KeyValueSeperator = ":";

		private static readonly string FileName;

		static FilePlayerPrefs()
		{
			PlayerPrefsHashtable = new Hashtable();
			_serializedOutput = "";
			SerializedInput = "";
			FileName = Application.persistentDataPath + "/MAPlayerPrefs.txt";
			if (File.Exists(FileName))
			{
				StreamReader streamReader = new StreamReader(FileName);
				SerializedInput = streamReader.ReadLine();
				Deserialize();
				streamReader.Close();
			}
		}

		public static bool HasKey(string key)
		{
			return PlayerPrefsHashtable.ContainsKey(key);
		}

		public static void SetString(string key, string value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetInt(string key, int value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetFloat(string key, float value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static void SetBool(string key, bool value)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				PlayerPrefsHashtable.Add(key, value);
			}
			else
			{
				PlayerPrefsHashtable[key] = value;
			}
			_hashTableChanged = true;
		}

		public static string GetString(string key)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return PlayerPrefsHashtable[key].ToString();
			}
			return null;
		}

		public static string GetString(string key, string defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return PlayerPrefsHashtable[key].ToString();
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static int GetInt(string key)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				return 0;
			}
			object obj = PlayerPrefsHashtable[key];
			if (obj is int)
			{
				return (int)obj;
			}
			int num = int.Parse(obj.ToString());
			PlayerPrefsHashtable[key] = num;
			obj = num;
			return (int)obj;
		}

		public static int GetInt(string key, int defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (int)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static float GetFloat(string key)
		{
			if (!PlayerPrefsHashtable.ContainsKey(key))
			{
				return 0f;
			}
			object obj = PlayerPrefsHashtable[key];
			if (obj is float)
			{
				return (float)obj;
			}
			float num = float.Parse(obj.ToString());
			PlayerPrefsHashtable[key] = num;
			obj = num;
			return (float)obj;
		}

		public static float GetFloat(string key, float defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (float)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static bool GetBool(string key)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (bool)PlayerPrefsHashtable[key];
			}
			return false;
		}

		public static bool GetBool(string key, bool defaultValue)
		{
			if (PlayerPrefsHashtable.ContainsKey(key))
			{
				return (bool)PlayerPrefsHashtable[key];
			}
			PlayerPrefsHashtable.Add(key, defaultValue);
			_hashTableChanged = true;
			return defaultValue;
		}

		public static void DeleteKey(string key)
		{
			PlayerPrefsHashtable.Remove(key);
		}

		public static void DeleteAll()
		{
			PlayerPrefsHashtable.Clear();
		}

		public static void Flush()
		{
			if (_hashTableChanged)
			{
				Serialize();
				StreamWriter streamWriter = File.CreateText(FileName);
				if (streamWriter == null)
				{
					UnityEngine.Debug.LogWarning("PlayerPrefs::Flush() opening file for writing failed: " + FileName);
				}
				streamWriter.WriteLine(_serializedOutput);
				streamWriter.Close();
				_serializedOutput = "";
			}
		}

		private static void Serialize()
		{
			IDictionaryEnumerator enumerator = PlayerPrefsHashtable.GetEnumerator();
			while (enumerator.MoveNext())
			{
				if (_serializedOutput != "")
				{
					_serializedOutput += " ; ";
				}
				_serializedOutput = _serializedOutput + EscapeNonSeperators(enumerator.Key.ToString()) + " : " + EscapeNonSeperators(enumerator.Value.ToString()) + " : " + enumerator.Value.GetType();
			}
		}

		private static void Deserialize()
		{
			string[] array = SerializedInput.Split(new string[1] { " ; " }, StringSplitOptions.None);
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new string[1] { " : " }, StringSplitOptions.None);
				PlayerPrefsHashtable.Add(DeEscapeNonSeperators(array2[0]), GetTypeValue(array2[2], DeEscapeNonSeperators(array2[1])));
				if (array2.Length > 3)
				{
					UnityEngine.Debug.LogWarning("PlayerPrefs::Deserialize() parameterContent has " + array2.Length + " elements");
				}
			}
		}

		private static string EscapeNonSeperators(string inputToEscape)
		{
			inputToEscape = inputToEscape.Replace(":", "\\:");
			inputToEscape = inputToEscape.Replace(";", "\\;");
			return inputToEscape;
		}

		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			inputToDeEscape = inputToDeEscape.Replace("\\:", ":");
			inputToDeEscape = inputToDeEscape.Replace("\\;", ";");
			return inputToDeEscape;
		}

		public static object GetTypeValue(string typeName, string value)
		{
			switch (typeName)
			{
			case "System.String":
				return value;
			case "System.Int32":
				return Convert.ToInt32(value);
			case "System.Boolean":
				return Convert.ToBoolean(value);
			case "System.Single":
				return Convert.ToSingle(value);
			default:
				UnityEngine.Debug.Log("Unsupported type: " + typeName);
				return null;
			}
		}
	}
	[AudioScriptOrder(-80)]
	[RequireComponent(typeof(AudioSource))]
	public class PlaylistController : MonoBehaviour
	{
		public enum AudioPlayType
		{
			PlayNow,
			Schedule,
			AlreadyScheduled
		}

		public enum PlaylistStates
		{
			NotInScene,
			Stopped,
			Playing,
			Paused,
			Crossfading
		}

		public enum FadeMode
		{
			None,
			GradualFade
		}

		public enum AudioDuckingMode
		{
			NotDucking,
			SetToDuck,
			Ducked
		}

		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		public delegate void SongEndedEventHandler(string songName);

		public delegate void SongLoopedEventHandler(string songName);

		public delegate void PlaylistEndedEventHandler();

		public const float ScheduledSongMinBadOffset = 0.5f;

		public const int FramesEarlyToTrigger = 2;

		public const int FramesEarlyToBeSyncable = 10;

		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		private const float MinSongLength = 0.5f;

		private const float SlowestFrameTimeForCalc = 0.3f;

		public bool startPlaylistOnAwake = true;

		public bool isShuffle;

		public bool isAutoAdvance = true;

		public bool loopPlaylist = true;

		public float _playlistVolume = 1f;

		public bool isMuted;

		public string startPlaylistName = string.Empty;

		public int syncGroupNum = -1;

		public AudioMixerGroup mixerChannel;

		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		public float spatialBlend;

		public bool initializedEventExpanded;

		public string initializedCustomEvent = string.Empty;

		public bool crossfadeStartedExpanded;

		public string crossfadeStartedCustomEvent = string.Empty;

		public bool songChangedEventExpanded;

		public string songChangedCustomEvent = string.Empty;

		public bool songEndedEventExpanded;

		public string songEndedCustomEvent = string.Empty;

		public bool songLoopedEventExpanded;

		public string songLoopedCustomEvent = string.Empty;

		public bool playlistStartedEventExpanded;

		public string playlistStartedCustomEvent = string.Empty;

		public bool playlistEndedEventExpanded;

		public string playlistEndedCustomEvent = string.Empty;

		private AudioSource _activeAudio;

		private AudioSource _transitioningAudio;

		private float _activeAudioEndVolume;

		private float _transitioningAudioStartVolume;

		private float _crossFadeStartTime;

		private readonly List<int> _clipsRemaining = new List<int>(10);

		private int _currentSequentialClipIndex;

		private AudioDuckingMode _duckingMode;

		private float _timeToStartUnducking;

		private float _timeToFinishUnducking;

		private float _originalMusicVolume;

		private float _initialDuckVolume;

		private float _duckRange;

		private MusicSetting _currentSong;

		private GameObject _go;

		private string _name;

		private FadeMode _curFadeMode;

		private float _slowFadeStartTime;

		private float _slowFadeCompletionTime;

		private float _slowFadeStartVolume;

		private float _slowFadeTargetVolume;

		private MasterAudio.Playlist _currentPlaylist;

		private float _lastTimeMissingPlaylistLogged = -5f;

		private Action _fadeCompleteCallback;

		private readonly List<MusicSetting> _queuedSongs = new List<MusicSetting>(5);

		private bool _lostFocus;

		private bool _autoStartedPlaylist;

		private AudioSource _audioClip;

		private AudioSource _transClip;

		private MusicSetting _newSongSetting;

		private bool _nextSongRequested;

		private bool _nextSongScheduled;

		private int _lastRandomClipIndex = -1;

		private float _lastTimeSongRequested = -1f;

		private float _currentDuckVolCut;

		private int? _lastSongPosition;

		private double? _currentSchedSongDspStartTime;

		private double? _currentSchedSongDspEndTime;

		private int _lastFrameSongPosition = -1;

		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource = new Dictionary<AudioSource, double>(2);

		public int _frames;

		private static List<PlaylistController> _instances;

		private Coroutine _resourceCoroutine;

		private int _songsPlayedFromPlaylist;

		private AudioSource _audio1;

		private AudioSource _audio2;

		private string _activeSongAlias;

		private Transform _trans;

		private bool _willPersist;

		private double? _songPauseTime;

		private int framesOfSongPlayed;

		private bool SongIsNonAdvancible
		{
			get
			{
				if (CurrentPlaylist != null && CurrentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.SynchronizeClips)
				{
					return CrossFadeTime > 0f;
				}
				return false;
			}
		}

		public bool ControllerIsReady { get; private set; }

		public PlaylistStates PlaylistState
		{
			get
			{
				if (_activeAudio == null || _transitioningAudio == null)
				{
					return PlaylistStates.NotInScene;
				}
				if (!ActiveAudioSource.isPlaying)
				{
					if (ActiveAudioSource.time != 0f)
					{
						return PlaylistStates.Paused;
					}
					return PlaylistStates.Stopped;
				}
				if (IsCrossFading)
				{
					return PlaylistStates.Crossfading;
				}
				return PlaylistStates.Playing;
			}
		}

		public AudioSource ActiveAudioSource
		{
			get
			{
				if (_activeAudio != null && _activeAudio.clip == null)
				{
					return _transitioningAudio;
				}
				return _activeAudio;
			}
		}

		public static List<PlaylistController> Instances
		{
			get
			{
				if (_instances != null)
				{
					return _instances;
				}
				_instances = new List<PlaylistController>();
				UnityEngine.Object[] array = UnityEngine.Object.FindObjectsOfType(typeof(PlaylistController));
				for (int i = 0; i < array.Length; i++)
				{
					_instances.Add(array[i] as PlaylistController);
				}
				return _instances;
			}
			set
			{
				_instances = value;
			}
		}

		public GameObject PlaylistControllerGameObject => _go;

		public AudioSource CurrentPlaylistSource => _activeAudio;

		public AudioClip CurrentPlaylistClip
		{
			get
			{
				if (_activeAudio == null)
				{
					return null;
				}
				return _activeAudio.clip;
			}
		}

		public AudioClip FadingPlaylistClip
		{
			get
			{
				if (!IsCrossFading)
				{
					return null;
				}
				if (_transitioningAudio == null)
				{
					return null;
				}
				return _transitioningAudio.clip;
			}
		}

		public AudioSource FadingSource
		{
			get
			{
				if (!IsCrossFading)
				{
					return null;
				}
				return _transitioningAudio;
			}
		}

		public bool IsCrossFading { get; private set; }

		public bool IsFading
		{
			get
			{
				if (!IsCrossFading)
				{
					return _curFadeMode != FadeMode.None;
				}
				return true;
			}
		}

		public float PlaylistVolume
		{
			get
			{
				return MasterAudio.PlaylistMasterVolume * _playlistVolume;
			}
			set
			{
				_playlistVolume = value;
				UpdateMasterVolume();
			}
		}

		public MasterAudio.Playlist CurrentPlaylist
		{
			get
			{
				if (_currentPlaylist != null || !(Time.realtimeSinceStartup - _lastTimeMissingPlaylistLogged > 2f))
				{
					return _currentPlaylist;
				}
				UnityEngine.Debug.LogWarning("Current Playlist is NULL. Subsequent calls will fail.");
				_lastTimeMissingPlaylistLogged = AudioUtil.Time;
				return _currentPlaylist;
			}
		}

		public bool HasPlaylist => _currentPlaylist != null;

		public string PlaylistName
		{
			get
			{
				if (CurrentPlaylist == null)
				{
					return string.Empty;
				}
				return CurrentPlaylist.playlistName;
			}
		}

		private bool IsMuted => isMuted;

		private bool PlaylistIsMuted
		{
			set
			{
				isMuted = value;
				if (Application.isPlaying)
				{
					if (_activeAudio != null)
					{
						_activeAudio.mute = value;
					}
					if (_transitioningAudio != null)
					{
						_transitioningAudio.mute = value;
					}
				}
				else
				{
					AudioSource[] components = GetComponents<AudioSource>();
					for (int i = 0; i < components.Length; i++)
					{
						components[i].mute = value;
					}
				}
			}
		}

		private float CrossFadeTime
		{
			get
			{
				if (_currentPlaylist != null)
				{
					if (_currentPlaylist.crossfadeMode != 0)
					{
						return _currentPlaylist.crossFadeTime;
					}
					return MasterAudio.Instance.MasterCrossFadeTime;
				}
				return MasterAudio.Instance.MasterCrossFadeTime;
			}
		}

		private bool IsAutoAdvance
		{
			get
			{
				if (SongIsNonAdvancible)
				{
					return false;
				}
				return isAutoAdvance;
			}
		}

		public GameObject GameObj
		{
			get
			{
				if (_go != null)
				{
					return _go;
				}
				_go = base.gameObject;
				return _go;
			}
		}

		public string ControllerName
		{
			get
			{
				if (_name != null)
				{
					return _name;
				}
				_name = GameObj.name;
				return _name;
			}
		}

		public bool CanSchedule
		{
			get
			{
				if (MasterAudio.Instance.useGaplessPlaylists)
				{
					return IsAutoAdvance;
				}
				return false;
			}
		}

		private bool IsFrameFastEnough => AudioUtil.FrameTime < 0.3f;

		private bool ShouldNotSwitchEarly
		{
			get
			{
				if (CrossFadeTime <= 0f)
				{
					return CanSchedule;
				}
				return false;
			}
		}

		private Transform Trans
		{
			get
			{
				if (_trans != null)
				{
					return _trans;
				}
				_trans = base.transform;
				return _trans;
			}
		}

		public int ClipsRemainingInCurrentPlaylist => _clipsRemaining.Count;

		public event SongChangedEventHandler SongChanged;

		public event SongEndedEventHandler SongEnded;

		public event SongLoopedEventHandler SongLooped;

		public event PlaylistEndedEventHandler PlaylistEnded;

		private void Awake()
		{
			base.useGUILayout = false;
			if (ControllerIsReady)
			{
				return;
			}
			ControllerIsReady = false;
			PlaylistController[] array = (PlaylistController[])UnityEngine.Object.FindObjectsOfType(typeof(PlaylistController));
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].ControllerName == ControllerName)
				{
					num++;
				}
			}
			if (num > 1)
			{
				UnityEngine.Object.DestroyImmediate(base.gameObject);
				UnityEngine.Object[] array2 = UnityEngine.Object.FindObjectsOfType(typeof(MasterAudio));
				bool flag = false;
				for (int j = 0; j < array2.Length; j++)
				{
					MasterAudio masterAudio = array2[j] as MasterAudio;
					if (masterAudio.persistBetweenScenes && masterAudio.shouldLogDestroys)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					UnityEngine.Debug.Log("More than one Playlist Controller prefab exists in this Scene with the same name. Destroying the one called '" + ControllerName + "'. You may wish to set up a Bootstrapper Scene so this does not occur.");
				}
				return;
			}
			_autoStartedPlaylist = false;
			_duckingMode = AudioDuckingMode.NotDucking;
			_currentSong = null;
			_songsPlayedFromPlaylist = 0;
			AudioSource[] components = GetComponents<AudioSource>();
			if (components.Length < 2)
			{
				UnityEngine.Debug.LogError("This prefab should have exactly two Audio Source components. Please revert it.");
				return;
			}
			MasterAudio safeInstance = MasterAudio.SafeInstance;
			_willPersist = safeInstance != null && safeInstance.persistBetweenScenes;
			_audio1 = components[0];
			_audio2 = components[1];
			_audio1.clip = null;
			_audio2.clip = null;
			if (_audio1.playOnAwake || _audio2.playOnAwake)
			{
				UnityEngine.Debug.LogWarning("One or more 'Play on Awake' checkboxes in the Audio Sources on Playlist Controller '" + base.name + "' are checked. These are not used in Master Audio. Make sure to uncheck them before hitting Play next time. For Playlist Controllers, use the similarly named checkbox 'Start Playlist on Awake' in the Playlist Controller's Inspector.");
			}
			_activeAudio = _audio1;
			_transitioningAudio = _audio2;
			_audio1.outputAudioMixerGroup = mixerChannel;
			_audio2.outputAudioMixerGroup = mixerChannel;
			SetSpatialBlend();
			_curFadeMode = FadeMode.None;
			_fadeCompleteCallback = null;
			_lostFocus = false;
		}

		public void SetSpatialBlend()
		{
			if (MasterAudio.SafeInstance == null)
			{
				return;
			}
			switch (MasterAudio.Instance.musicSpatialBlendType)
			{
			case MasterAudio.AllMusicSpatialBlendType.ForceAllTo2D:
				SetAudioSpatialBlend(0f);
				break;
			case MasterAudio.AllMusicSpatialBlendType.ForceAllTo3D:
				SetAudioSpatialBlend(1f);
				break;
			case MasterAudio.AllMusicSpatialBlendType.ForceAllToCustom:
				SetAudioSpatialBlend(MasterAudio.Instance.musicSpatialBlend);
				break;
			case MasterAudio.AllMusicSpatialBlendType.AllowDifferentPerController:
				switch (spatialBlendType)
				{
				case MasterAudio.ItemSpatialBlendType.ForceTo2D:
					SetAudioSpatialBlend(0f);
					break;
				case MasterAudio.ItemSpatialBlendType.ForceTo3D:
					SetAudioSpatialBlend(1f);
					break;
				case MasterAudio.ItemSpatialBlendType.ForceToCustom:
					SetAudioSpatialBlend(spatialBlend);
					break;
				case MasterAudio.ItemSpatialBlendType.UseCurveFromAudioSource:
					break;
				}
				break;
			}
		}

		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			MusicSetting musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => obj.alias == clipName);
			if (musicSetting == null)
			{
				musicSetting = _currentPlaylist.MusicSettings.Find(delegate(MusicSetting obj)
				{
					if (obj.audLocation == MasterAudio.AudioLocation.Clip)
					{
						if (obj.clip != null)
						{
							return obj.clip.name == clipName;
						}
						return false;
					}
					return obj.audLocation == MasterAudio.AudioLocation.ResourceFile && obj.resourceFileName == clipName;
				});
			}
			return musicSetting;
		}

		private void SetAudiosIfEmpty()
		{
			AudioSource[] components = GetComponents<AudioSource>();
			_audio1 = components[0];
			_audio2 = components[1];
		}

		private void SetAudioSpatialBlend(float blend)
		{
			if (_audio1 == null)
			{
				SetAudiosIfEmpty();
			}
			_audio1.spatialBlend = blend;
			_audio2.spatialBlend = blend;
		}

		private void Start()
		{
			if (ControllerIsReady)
			{
				return;
			}
			if (MasterAudio.SafeInstance == null)
			{
				UnityEngine.Debug.LogError("No Master Audio game object exists in the Hierarchy. Aborting Playlist Controller setup code.");
				return;
			}
			if (!string.IsNullOrEmpty(startPlaylistName) && _currentPlaylist == null)
			{
				InitializePlaylist();
			}
			ControllerIsReady = true;
			if (initializedEventExpanded && initializedCustomEvent != string.Empty && initializedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(initializedCustomEvent, Trans, logDupe: false);
			}
			AutoStartPlaylist();
			if (IsMuted)
			{
				MutePlaylist();
			}
		}

		private void AutoStartPlaylist()
		{
			if (_currentPlaylist != null && startPlaylistOnAwake && IsFrameFastEnough && !_autoStartedPlaylist)
			{
				PlayNextOrRandom(AudioPlayType.PlayNow);
				_autoStartedPlaylist = true;
			}
		}

		private void CoUpdate()
		{
			if (MasterAudio.SafeInstance == null || _curFadeMode != FadeMode.GradualFade || _activeAudio == null)
			{
				return;
			}
			float val = 1f - (_slowFadeCompletionTime - AudioUtil.Time) / (_slowFadeCompletionTime - _slowFadeStartTime);
			val = Math.Min(val, 1f);
			val = Math.Max(val, 0f);
			float val2 = _slowFadeStartVolume + (_slowFadeTargetVolume - _slowFadeStartVolume) * val;
			val2 = ((!(_slowFadeTargetVolume > _slowFadeStartVolume)) ? Math.Max(val2, _slowFadeTargetVolume) : Math.Min(val2, _slowFadeTargetVolume));
			_playlistVolume = val2;
			UpdateMasterVolume();
			if (!(AudioUtil.Time < _slowFadeCompletionTime))
			{
				if (MasterAudio.Instance.stopZeroVolumePlaylists && _slowFadeTargetVolume == 0f)
				{
					StopPlaylist();
				}
				if (_fadeCompleteCallback != null)
				{
					_fadeCompleteCallback();
					_fadeCompleteCallback = null;
				}
				_curFadeMode = FadeMode.None;
			}
		}

		private void OnEnable()
		{
			_instances = null;
			MasterAudio.TrackRuntimeAudioSources(new List<AudioSource> { _audio1, _audio2 });
		}

		private void OnDisable()
		{
			_instances = null;
			if (!(MasterAudio.SafeInstance == null) && !MasterAudio.AppIsShuttingDown)
			{
				if (ActiveAudioSource != null && ActiveAudioSource.clip != null && !_willPersist)
				{
					StopPlaylist();
				}
				MasterAudio.StopTrackingRuntimeAudioSources(new List<AudioSource> { _audio1, _audio2 });
			}
		}

		private void OnApplicationPause(bool pauseStatus)
		{
			_lostFocus = pauseStatus;
		}

		private void Update()
		{
			_frames++;
			CoUpdate();
			if (_lostFocus || !ControllerIsReady)
			{
				return;
			}
			AutoStartPlaylist();
			if (_activeAudio.isPlaying)
			{
				framesOfSongPlayed++;
			}
			if (IsCrossFading)
			{
				if (_activeAudio.volume >= _activeAudioEndVolume)
				{
					CeaseAudioSource(_transitioningAudio);
					IsCrossFading = false;
					if (CanSchedule && !_nextSongScheduled)
					{
						PlayNextOrRandom(AudioPlayType.Schedule);
					}
					SetDuckProperties();
				}
				float num = Math.Max(CrossFadeTime, 0.001f);
				float num2 = Mathf.Clamp01((Time.realtimeSinceStartup - _crossFadeStartTime) / num);
				_activeAudio.volume = num2 * _activeAudioEndVolume;
				_transitioningAudio.volume = _transitioningAudioStartVolume * (1f - num2);
			}
			if (!_activeAudio.loop && _activeAudio.clip != null)
			{
				if (AudioUtil.IsClipPaused(_activeAudio))
				{
					goto IL_03b3;
				}
				if (!_activeAudio.isPlaying)
				{
					if (!IsAutoAdvance)
					{
						FirePlaylistEndedEventIfAny();
						CeaseAudioSource(_activeAudio);
						return;
					}
					bool flag = false;
					flag = ((!isShuffle) ? (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count) : (_clipsRemaining.Count == 0));
					if (flag && !_activeAudio.isPlaying)
					{
						FirePlaylistEndedEventIfAny();
						CeaseAudioSource(_activeAudio);
						return;
					}
				}
				bool flag2 = false;
				if (ShouldNotSwitchEarly)
				{
					if (_currentSchedSongDspStartTime.HasValue && AudioSettings.dspTime > _currentSchedSongDspStartTime.Value)
					{
						flag2 = true;
					}
				}
				else if (PlaylistState == PlaylistStates.Stopped)
				{
					flag2 = true;
				}
				else if (IsFrameFastEnough)
				{
					float num3 = _activeAudio.clip.length - _activeAudio.time - AudioUtil.AdjustEndLeadTimeForPitch(CrossFadeTime, _activeAudio);
					float num4 = AudioUtil.AdjustEndLeadTimeForPitch(AudioUtil.FrameTime * 2f, _activeAudio);
					flag2 = num3 <= num4;
				}
				if (flag2)
				{
					if (_currentPlaylist.fadeOutLastSong)
					{
						if (isShuffle)
						{
							if (_clipsRemaining.Count == 0 || !IsAutoAdvance)
							{
								FadeOutPlaylist();
								return;
							}
						}
						else if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count || _currentPlaylist.MusicSettings.Count == 1 || !IsAutoAdvance)
						{
							FadeOutPlaylist();
							return;
						}
					}
					if (IsAutoAdvance && !_nextSongRequested && _lastTimeSongRequested + 0.5f <= AudioUtil.Time)
					{
						_lastTimeSongRequested = AudioUtil.Time;
						if (CanSchedule)
						{
							_lastSongPosition = null;
							FadeInScheduledSong();
						}
						else
						{
							_lastSongPosition = 0;
							PlayNextOrRandom(AudioPlayType.PlayNow);
						}
					}
				}
			}
			if (_activeAudio.loop && _activeAudio.clip != null)
			{
				if (_activeAudio.timeSamples < _lastFrameSongPosition)
				{
					string text = _activeAudio.clip.name;
					if (this.SongLooped != null && !string.IsNullOrEmpty(text))
					{
						this.SongLooped(text);
					}
					if (songLoopedEventExpanded && songLoopedCustomEvent != string.Empty && songLoopedCustomEvent != "[None]")
					{
						MasterAudio.FireCustomEvent(songLoopedCustomEvent, Trans, logDupe: false);
					}
				}
				_lastFrameSongPosition = _activeAudio.timeSamples;
			}
			goto IL_03b3;
			IL_03b3:
			if (!IsCrossFading)
			{
				AudioDucking();
			}
		}

		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			PlaylistController playlistController = Instances.Find((PlaylistController obj) => obj != null && obj.ControllerName == playlistControllerName);
			if (playlistController != null)
			{
				return playlistController;
			}
			if (errorIfNotFound)
			{
				UnityEngine.Debug.LogError("Could not find Playlist Controller '" + playlistControllerName + "'.");
			}
			return null;
		}

		public bool IsSongPlaying(string songName)
		{
			if (!HasPlaylist)
			{
				return false;
			}
			if (ActiveAudioSource == null || ActiveAudioSource.clip == null)
			{
				return false;
			}
			if (ActiveAudioSource.clip.name == songName)
			{
				return true;
			}
			return _activeSongAlias == songName;
		}

		public void ClearQueue()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				_queuedSongs.Clear();
			}
		}

		public void ToggleMutePlaylist()
		{
			if (Application.isPlaying && !ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (IsMuted)
			{
				UnmutePlaylist();
			}
			else
			{
				MutePlaylist();
			}
		}

		public void MutePlaylist()
		{
			PlaylistIsMuted = true;
		}

		public void UnmutePlaylist()
		{
			PlaylistIsMuted = false;
		}

		public void PausePlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (!(_activeAudio == null) && !(_transitioningAudio == null))
			{
				if (_activeAudio.clip != null)
				{
					_activeAudio.Pause();
				}
				if (!_songPauseTime.HasValue)
				{
					_songPauseTime = AudioSettings.dspTime;
				}
				if (_transitioningAudio.clip != null)
				{
					_transitioningAudio.Pause();
				}
			}
		}

		public bool UnpausePlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				_songPauseTime = null;
				return false;
			}
			if (PlaylistState == PlaylistStates.Playing || PlaylistState == PlaylistStates.Crossfading || PlaylistState == PlaylistStates.Stopped)
			{
				_songPauseTime = null;
				return false;
			}
			if (_activeAudio == null || _transitioningAudio == null)
			{
				_songPauseTime = null;
				return false;
			}
			if (_activeAudio.clip == null && _currentPlaylist != null)
			{
				FinishPlaylistInit();
				_songPauseTime = null;
				return true;
			}
			if (_activeAudio.clip == null)
			{
				_songPauseTime = null;
				return false;
			}
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_activeAudio))
			{
				_activeAudio.Play();
				framesOfSongPlayed = 0;
				AudioUtil.ClipPlayed(_activeAudio.clip, GameObj);
			}
			else if (_songPauseTime.HasValue && _currentSchedSongDspStartTime.HasValue)
			{
				double num = AudioSettings.dspTime - _songPauseTime.Value;
				double scheduledPlayTimeOffset = _currentSchedSongDspStartTime.Value - AudioSettings.dspTime + num;
				_songPauseTime = null;
				_activeAudio.Stop();
				ScheduleClipPlay(scheduledPlayTimeOffset, _activeAudio, calledAfterPause: true);
			}
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_transitioningAudio))
			{
				_transitioningAudio.Play();
				AudioUtil.ClipPlayed(_transitioningAudio.clip, GameObj);
			}
			else if (_songPauseTime.HasValue && _currentSchedSongDspStartTime.HasValue)
			{
				double num2 = AudioSettings.dspTime - _songPauseTime.Value;
				double scheduledPlayTimeOffset2 = _currentSchedSongDspStartTime.Value - AudioSettings.dspTime + num2;
				_songPauseTime = null;
				_transitioningAudio.Stop();
				ScheduleClipPlay(scheduledPlayTimeOffset2, _transitioningAudio, calledAfterPause: true);
			}
			return true;
		}

		public void StopPlaylist(bool onlyFadingClip = false)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				if (!Application.isPlaying)
				{
					return;
				}
				_currentSchedSongDspStartTime = null;
				_currentSchedSongDspEndTime = null;
				_currentSong = null;
				PlaylistStates playlistState = PlaylistState;
				if ((uint)playlistState > 1u)
				{
					if (!onlyFadingClip)
					{
						CeaseAudioSource(_activeAudio);
					}
					CeaseAudioSource(_transitioningAudio);
					if (!onlyFadingClip && _clipsRemaining.Count == 0 && this.PlaylistEnded != null)
					{
						this.PlaylistEnded();
					}
				}
			}
		}

		public void FadeToVolume(float targetVolume, float fadeTime, Action callback = null)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (fadeTime <= 0.1f)
			{
				_playlistVolume = targetVolume;
				UpdateMasterVolume();
				_curFadeMode = FadeMode.None;
				return;
			}
			_curFadeMode = FadeMode.GradualFade;
			if (_duckingMode == AudioDuckingMode.NotDucking)
			{
				_slowFadeStartVolume = _playlistVolume;
			}
			else
			{
				_slowFadeStartVolume = _activeAudio.volume;
			}
			_slowFadeTargetVolume = targetVolume;
			_slowFadeStartTime = AudioUtil.Time;
			_slowFadeCompletionTime = AudioUtil.Time + fadeTime;
			_fadeCompleteCallback = callback;
		}

		public void PlayRandomSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				PlayARandomSong(AudioPlayType.PlayNow);
			}
		}

		public void PlayARandomSong(AudioPlayType playType)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (_clipsRemaining.Count == 0)
			{
				UnityEngine.Debug.LogWarning("There are no clips left in this Playlist. Turn on Loop Playlist if you want to loop the entire song selection.");
			}
			else
			{
				if (IsCrossFading && playType == AudioPlayType.Schedule)
				{
					return;
				}
				if (framesOfSongPlayed > 0)
				{
					_nextSongScheduled = false;
				}
				int num = UnityEngine.Random.Range(0, _clipsRemaining.Count);
				int index = _clipsRemaining[num];
				switch (playType)
				{
				case AudioPlayType.PlayNow:
					RemoveRandomClip(num);
					break;
				case AudioPlayType.Schedule:
					_lastRandomClipIndex = num;
					break;
				case AudioPlayType.AlreadyScheduled:
					if (_lastRandomClipIndex >= 0)
					{
						RemoveRandomClip(_lastRandomClipIndex);
					}
					break;
				}
				PlaySong(_currentPlaylist.MusicSettings[index], playType);
			}
		}

		private void RemoveRandomClip(int randIndex)
		{
			_clipsRemaining.RemoveAt(randIndex);
			if (loopPlaylist && _clipsRemaining.Count == 0)
			{
				FillClips();
			}
		}

		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
			if (_queuedSongs.Count == 0)
			{
				UnityEngine.Debug.LogWarning("There are zero queued songs in PlaylistController '" + ControllerName + "'. Cannot play first queued song.");
				return;
			}
			MusicSetting musicSetting = _queuedSongs[0];
			_queuedSongs.RemoveAt(0);
			_currentSequentialClipIndex = musicSetting.songIndex;
			PlaySong(musicSetting, playType);
		}

		public void PlayNextSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				PlayTheNextSong(AudioPlayType.PlayNow);
			}
		}

		public void PlayTheNextSong(AudioPlayType playType)
		{
			if (_currentPlaylist == null || (IsCrossFading && playType == AudioPlayType.Schedule))
			{
				return;
			}
			if (playType != AudioPlayType.AlreadyScheduled && _songsPlayedFromPlaylist > 0 && !_nextSongScheduled)
			{
				AdvanceSongCounter();
			}
			if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count)
			{
				UnityEngine.Debug.LogWarning("There are no clips left in this Playlist. Turn on Loop Playlist if you want to loop the entire song selection.");
				return;
			}
			if (framesOfSongPlayed > 0)
			{
				_nextSongScheduled = false;
				_lastSongPosition = ActiveAudioSource.timeSamples;
			}
			PlaySong(_currentPlaylist.MusicSettings[_currentSequentialClipIndex], playType);
		}

		private void AdvanceSongCounter()
		{
			_currentSequentialClipIndex++;
			if (_currentSequentialClipIndex >= _currentPlaylist.MusicSettings.Count && loopPlaylist)
			{
				_currentSequentialClipIndex = 0;
			}
		}

		public void StopPlaylistAfterCurrentSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "StopPlaylistAfterCurrentSong");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				UnityEngine.Debug.Log("No song is currently playing.");
				return;
			}
			_activeAudio.loop = false;
			_queuedSongs.Clear();
			isAutoAdvance = false;
			if (_scheduledSongOffsetByAudioSource.ContainsKey(_activeAudio))
			{
				CeaseAudioSource(_activeAudio);
			}
			if (_scheduledSongOffsetByAudioSource.ContainsKey(_transitioningAudio))
			{
				CeaseAudioSource(_transitioningAudio);
			}
		}

		public void StopLoopingCurrentSong()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "StopLoopingCurrentSong");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				UnityEngine.Debug.Log("No song is currently playing.");
				return;
			}
			_activeAudio.loop = false;
			if (CanSchedule && _queuedSongs.Count == 0)
			{
				ScheduleNextSong();
			}
		}

		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "QueuePlaylistClip");
				return;
			}
			if (!_activeAudio.isPlaying)
			{
				TriggerPlaylistClip(clipName);
				return;
			}
			MusicSetting musicSetting = FindSongByAliasOrName(clipName);
			if (musicSetting == null)
			{
				UnityEngine.Debug.LogWarning("Could not find clip '" + clipName + "' in current Playlist in '" + ControllerName + "'.");
			}
			else
			{
				_activeAudio.loop = false;
				_queuedSongs.Add(musicSetting);
				if (CanSchedule && scheduleNow)
				{
					PlayNextOrRandom(AudioPlayType.Schedule);
				}
			}
		}

		public bool TriggerPlaylistClip(string clipName)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return false;
			}
			if (_currentPlaylist == null)
			{
				MasterAudio.LogNoPlaylist(ControllerName, "TriggerPlaylistClip");
				return false;
			}
			MusicSetting musicSetting = FindSongByAliasOrName(clipName);
			if (musicSetting == null)
			{
				UnityEngine.Debug.LogWarning("Could not find clip '" + clipName + "' in current Playlist in '" + ControllerName + "'.");
				return false;
			}
			_nextSongScheduled = false;
			_currentSequentialClipIndex = musicSetting.songIndex;
			PlaySong(musicSetting, AudioPlayType.PlayNow);
			return true;
		}

		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
			if (MasterAudio.IsWarming)
			{
				return;
			}
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (!IsCrossFading)
			{
				float num = AudioUtil.AdjustAudioClipDurationForPitch(duckLength, pitch);
				_currentDuckVolCut = duckedVolCut;
				float num2 = (_initialDuckVolume = AudioUtil.GetFloatVolumeFromDb(AudioUtil.GetDbFromFloatVolume(_originalMusicVolume) + duckedVolCut));
				_duckRange = _originalMusicVolume - num2;
				_duckingMode = AudioDuckingMode.SetToDuck;
				_timeToStartUnducking = AudioUtil.Time + num * duckedTimePercentage;
				float num3 = _timeToStartUnducking + unduckTime;
				if (num3 > AudioUtil.Time + num)
				{
					num3 = AudioUtil.Time + num;
				}
				_timeToFinishUnducking = num3;
			}
		}

		private void InitControllerIfNot()
		{
			if (!ControllerIsReady)
			{
				Awake();
				Start();
			}
		}

		public void UpdateMasterVolume()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			InitControllerIfNot();
			if (_currentSong != null)
			{
				float num = _currentSong.volume * PlaylistVolume;
				if (!IsCrossFading)
				{
					if (_activeAudio != null)
					{
						_activeAudio.volume = num;
					}
					if (_transitioningAudio != null)
					{
						_transitioningAudio.volume = num;
					}
				}
				_activeAudioEndVolume = num;
			}
			SetDuckProperties();
		}

		public void StartPlaylist(string playlistName)
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else if (_currentPlaylist != null && _currentPlaylist.playlistName == playlistName)
			{
				RestartPlaylist();
			}
			else
			{
				ChangePlaylist(playlistName);
			}
		}

		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
			InitControllerIfNot();
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
				return;
			}
			if (_currentPlaylist != null && _currentPlaylist.playlistName == playlistName)
			{
				UnityEngine.Debug.LogWarning("The Playlist '" + playlistName + "' is already loaded. Ignoring Change Playlist request.");
				return;
			}
			startPlaylistName = playlistName;
			FinishPlaylistInit(playFirstClip);
		}

		private void FinishPlaylistInit(bool playFirstClip = true)
		{
			if (IsCrossFading)
			{
				StopPlaylist(onlyFadingClip: true);
			}
			InitializePlaylist();
			if (Application.isPlaying)
			{
				_queuedSongs.Clear();
				if (playFirstClip)
				{
					PlayNextOrRandom(AudioPlayType.PlayNow);
				}
			}
		}

		public void RestartPlaylist()
		{
			if (!ControllerIsReady)
			{
				UnityEngine.Debug.LogError("Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.");
			}
			else
			{
				FinishPlaylistInit();
			}
		}

		private void CheckIfPlaylistStarted()
		{
			if (_songsPlayedFromPlaylist <= 0 && playlistStartedEventExpanded && playlistStartedCustomEvent != string.Empty && playlistStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(playlistStartedCustomEvent, Trans);
			}
		}

		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			if (syncGroupNum <= 0 || _currentPlaylist.songTransitionType != MasterAudio.SongFadeInPosition.SynchronizeClips)
			{
				return null;
			}
			return Instances.Find((PlaylistController obj) => obj != this && obj.syncGroupNum == syncGroupNum && obj.ActiveAudioSource != null && obj.ActiveAudioSource.isPlaying);
		}

		private void FadeOutPlaylist()
		{
			if (_curFadeMode != FadeMode.GradualFade)
			{
				float volumeBeforeFade = _playlistVolume;
				FadeToVolume(0f, CrossFadeTime, delegate
				{
					StopPlaylist();
					_playlistVolume = volumeBeforeFade;
				});
			}
		}

		private void InitializePlaylist()
		{
			FillClips();
			_songsPlayedFromPlaylist = 0;
			_currentSequentialClipIndex = 0;
			_nextSongScheduled = false;
			_lastRandomClipIndex = -1;
		}

		private void PlayNextOrRandom(AudioPlayType playType)
		{
			_nextSongRequested = true;
			if (_queuedSongs.Count > 0)
			{
				PlayFirstQueuedSong(playType);
			}
			else if (!isShuffle)
			{
				PlayTheNextSong(playType);
			}
			else
			{
				PlayARandomSong(playType);
			}
		}

		private void FirePlaylistEndedEventIfAny()
		{
			if (playlistEndedEventExpanded && playlistEndedCustomEvent != string.Empty && playlistStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(playlistEndedCustomEvent, Trans);
			}
		}

		private void FillClips()
		{
			_clipsRemaining.Clear();
			if (startPlaylistName == "[No Playlist]")
			{
				return;
			}
			_currentPlaylist = MasterAudio.GrabPlaylist(startPlaylistName);
			if (_currentPlaylist == null)
			{
				return;
			}
			for (int i = 0; i < _currentPlaylist.MusicSettings.Count; i++)
			{
				MusicSetting musicSetting = _currentPlaylist.MusicSettings[i];
				musicSetting.songIndex = i;
				switch (musicSetting.audLocation)
				{
				case MasterAudio.AudioLocation.Clip:
					if (musicSetting.clip == null)
					{
						continue;
					}
					break;
				case MasterAudio.AudioLocation.ResourceFile:
					if (string.IsNullOrEmpty(musicSetting.resourceFileName))
					{
						continue;
					}
					break;
				}
				_clipsRemaining.Add(i);
			}
		}

		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
			_newSongSetting = setting;
			if (_activeAudio == null)
			{
				UnityEngine.Debug.LogError("PlaylistController prefab is not in your scene. Cannot play a song.");
				return;
			}
			AudioClip audioClip = null;
			int num;
			if (playType != 0)
			{
				num = ((playType == AudioPlayType.AlreadyScheduled) ? 1 : 0);
				if (num == 0)
				{
					goto IL_0036;
				}
			}
			else
			{
				num = 1;
			}
			_lastFrameSongPosition = -1;
			goto IL_0036;
			IL_0036:
			if (num != 0 && _currentSong != null && !CanSchedule && _currentSong.songChangedEventExpanded && _currentSong.songChangedCustomEvent != string.Empty && _currentSong.songChangedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(_currentSong.songChangedCustomEvent, Trans);
			}
			if (playType != AudioPlayType.AlreadyScheduled)
			{
				if (_activeAudio.clip != null)
				{
					string value = string.Empty;
					switch (setting.audLocation)
					{
					case MasterAudio.AudioLocation.Clip:
						if (setting.clip != null)
						{
							value = setting.clip.name;
						}
						break;
					case MasterAudio.AudioLocation.ResourceFile:
						value = setting.resourceFileName;
						break;
					}
					if (string.IsNullOrEmpty(value))
					{
						UnityEngine.Debug.LogWarning("The next song has no clip or Resource file assigned. Please fix. Ignoring song change request.");
						return;
					}
				}
				if (_activeAudio.clip == null)
				{
					_audioClip = _activeAudio;
					_transClip = _transitioningAudio;
				}
				else if (_transitioningAudio.clip == null)
				{
					_audioClip = _transitioningAudio;
					_transClip = _activeAudio;
				}
				else
				{
					_audioClip = _transitioningAudio;
					_transClip = _activeAudio;
				}
				_audioClip.loop = SongShouldLoop(setting);
				switch (setting.audLocation)
				{
				case MasterAudio.AudioLocation.Clip:
					if (setting.clip == null)
					{
						MasterAudio.LogWarning("MasterAudio will not play empty Playlist clip for PlaylistController '" + ControllerName + "'.");
						return;
					}
					audioClip = setting.clip;
					break;
				case MasterAudio.AudioLocation.ResourceFile:
					if (_resourceCoroutine != null)
					{
						StopCoroutine(_resourceCoroutine);
					}
					_resourceCoroutine = StartCoroutine(AudioResourceOptimizer.PopulateResourceSongToPlaylistControllerAsync(setting, setting.resourceFileName, CurrentPlaylist.playlistName, this, playType));
					break;
				}
			}
			else
			{
				FinishLoadingNewSong(setting, null, AudioPlayType.AlreadyScheduled);
			}
			if (audioClip != null)
			{
				FinishLoadingNewSong(setting, audioClip, playType);
			}
		}

		public double? ScheduledGaplessNextSongStartTime()
		{
			if (!_scheduledSongOffsetByAudioSource.ContainsKey(_audioClip))
			{
				return null;
			}
			return _scheduledSongOffsetByAudioSource[_audioClip];
		}

		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
			_nextSongRequested = false;
			bool flag = playType == AudioPlayType.Schedule;
			bool num = playType == AudioPlayType.PlayNow || flag;
			bool flag2 = playType == AudioPlayType.PlayNow || playType == AudioPlayType.AlreadyScheduled;
			double? num2 = null;
			if (num)
			{
				if (flag && CanSchedule)
				{
					num2 = CalculateNextTrackStartTimeOffset();
				}
				_audioClip.clip = clipToPlay;
				_audioClip.pitch = _newSongSetting.pitch;
				_activeSongAlias = songSetting.alias;
			}
			if (_currentSong != null)
			{
				_currentSong.lastKnownTimePoint = _activeAudio.timeSamples;
				_currentSong.wasLastKnownTimePointSet = true;
			}
			if (flag2)
			{
				if (CrossFadeTime == 0f || _transClip.clip == null)
				{
					CeaseAudioSource(_transClip);
					_audioClip.volume = _newSongSetting.volume * PlaylistVolume;
					if (!ActiveAudioSource.isPlaying && _currentPlaylist != null && _currentPlaylist.fadeInFirstSong && CrossFadeTime > 0f)
					{
						CrossFadeNow(_audioClip);
					}
				}
				else
				{
					CrossFadeNow(_audioClip);
				}
				SetDuckProperties();
			}
			bool flag3 = false;
			switch (playType)
			{
			case AudioPlayType.AlreadyScheduled:
				_nextSongScheduled = false;
				RemoveScheduledClip();
				break;
			case AudioPlayType.PlayNow:
			{
				if (_audioClip.clip != null && _audioClip.timeSamples >= _audioClip.clip.samples - 1)
				{
					_audioClip.timeSamples = 0;
				}
				_audioClip.Play();
				framesOfSongPlayed = 0;
				AudioUtil.ClipPlayed(_activeAudio.clip, GameObj);
				CheckIfPlaylistStarted();
				_songsPlayedFromPlaylist++;
				PlaylistController playlistController = FindOtherControllerInSameSyncGroup();
				if (playlistController != null)
				{
					int timeSamples = playlistController._activeAudio.timeSamples;
					float time = playlistController._audioClip.time;
					bool flag4 = Math.Abs(_audioClip.clip.length - time) >= AudioUtil.FrameTime * 10f;
					if (_audioClip.clip != null && timeSamples < _audioClip.clip.samples && flag4)
					{
						_audioClip.timeSamples = timeSamples;
						flag3 = true;
					}
				}
				break;
			}
			case AudioPlayType.Schedule:
				if (!num2.HasValue)
				{
					num2 = CalculateNextTrackStartTimeOffset();
				}
				ScheduleClipPlay(num2.Value, _audioClip, calledAfterPause: false);
				_nextSongScheduled = true;
				CheckIfPlaylistStarted();
				_songsPlayedFromPlaylist++;
				break;
			}
			if (_currentPlaylist != null)
			{
				if (_songsPlayedFromPlaylist <= 1 && !flag3)
				{
					_audioClip.timeSamples = 0;
				}
				else
				{
					switch (_currentPlaylist.songTransitionType)
					{
					case MasterAudio.SongFadeInPosition.SynchronizeClips:
						if (flag3)
						{
							break;
						}
						if (playType == AudioPlayType.PlayNow)
						{
							int num3 = (_lastSongPosition.HasValue ? _lastSongPosition.Value : _activeAudio.timeSamples);
							if (_transitioningAudio.clip != null && num3 >= _transitioningAudio.clip.samples - 1)
							{
								num3 = 0;
							}
							_lastSongPosition = null;
							_transitioningAudio.timeSamples = num3;
						}
						else if (!ShouldNotSwitchEarly)
						{
							_transitioningAudio.timeSamples = 0;
						}
						break;
					case MasterAudio.SongFadeInPosition.NewClipFromLastKnownPosition:
					{
						MusicSetting musicSetting = _currentPlaylist.MusicSettings.Find((MusicSetting obj) => obj == _newSongSetting);
						if (musicSetting != null)
						{
							int num4 = musicSetting.lastKnownTimePoint;
							if (_transitioningAudio.clip != null && num4 >= _transitioningAudio.clip.samples - 1)
							{
								num4 = 0;
							}
							_transitioningAudio.timeSamples = num4;
						}
						break;
					}
					case MasterAudio.SongFadeInPosition.NewClipFromBeginning:
						if (!ShouldNotSwitchEarly)
						{
							_audioClip.timeSamples = 0;
						}
						break;
					}
				}
				bool flag5 = _currentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.NewClipFromLastKnownPosition && !_newSongSetting.wasLastKnownTimePointSet;
				if (_currentPlaylist.songTransitionType == MasterAudio.SongFadeInPosition.NewClipFromBeginning || flag5)
				{
					float songStartTime = _newSongSetting.SongStartTime;
					if (songStartTime > 0f)
					{
						_audioClip.timeSamples = (int)(songStartTime * (float)_audioClip.clip.frequency);
					}
				}
			}
			if (flag)
			{
				UpdateMasterVolume();
			}
			if (flag2)
			{
				_activeAudio = _audioClip;
				_transitioningAudio = _transClip;
				if (songChangedCustomEvent != string.Empty && songChangedEventExpanded && songChangedCustomEvent != "[None]")
				{
					MasterAudio.FireCustomEvent(songChangedCustomEvent, Trans);
				}
				if (this.SongChanged != null)
				{
					string empty = string.Empty;
					if (_audioClip != null)
					{
						empty = _audioClip.clip.name;
					}
					this.SongChanged(empty, _newSongSetting);
				}
			}
			_activeAudioEndVolume = _newSongSetting.volume * PlaylistVolume;
			float volume = _transitioningAudio.volume;
			if (_currentSong != null)
			{
				volume = _currentSong.volume;
			}
			_transitioningAudioStartVolume = volume * PlaylistVolume;
			_currentSong = _newSongSetting;
			if (flag2 && _currentSong.songStartedEventExpanded && _currentSong.songStartedCustomEvent != string.Empty && _currentSong.songStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(_currentSong.songStartedCustomEvent, Trans);
			}
			if (CanSchedule && playType != AudioPlayType.Schedule && !_currentSong.isLoop)
			{
				ScheduleNextSong();
			}
		}

		private void RemoveScheduledClip()
		{
			if (_audioClip != null)
			{
				_scheduledSongOffsetByAudioSource.Remove(_audioClip);
			}
		}

		private void ScheduleNextSong()
		{
			PlayNextOrRandom(AudioPlayType.Schedule);
		}

		private void FadeInScheduledSong()
		{
			PlayNextOrRandom(AudioPlayType.AlreadyScheduled);
		}

		private double CalculateNextTrackStartTimeOffset()
		{
			PlaylistController playlistController = FindOtherControllerInSameSyncGroup();
			if (playlistController != null)
			{
				double? num = playlistController.ScheduledGaplessNextSongStartTime();
				if (num.HasValue)
				{
					return num.Value;
				}
			}
			return GetClipDuration(_activeAudio);
		}

		private double GetClipDuration(AudioSource src)
		{
			return AudioUtil.AdjustAudioClipDurationForPitch(src.clip.length - src.time, src) - CrossFadeTime;
		}

		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
			double num = AudioSettings.dspTime + scheduledPlayTimeOffset;
			if (ShouldNotSwitchEarly && _currentSchedSongDspEndTime.HasValue && !calledAfterPause)
			{
				num = _currentSchedSongDspEndTime.Value;
				scheduledPlayTimeOffset = num - AudioSettings.dspTime;
			}
			source.PlayScheduled(num);
			_currentSchedSongDspStartTime = num;
			RemoveScheduledClip();
			_scheduledSongOffsetByAudioSource.Add(source, scheduledPlayTimeOffset);
		}

		private void CrossFadeNow(AudioSource audioClip)
		{
			audioClip.volume = 0f;
			IsCrossFading = true;
			_duckingMode = AudioDuckingMode.NotDucking;
			_crossFadeStartTime = AudioUtil.Time;
			if (crossfadeStartedExpanded && crossfadeStartedCustomEvent != string.Empty && crossfadeStartedCustomEvent != "[None]")
			{
				MasterAudio.FireCustomEvent(crossfadeStartedCustomEvent, Trans, logDupe: false);
			}
		}

		private void CeaseAudioSource(AudioSource source)
		{
			if (source == null)
			{
				return;
			}
			if (source == _activeAudio)
			{
				framesOfSongPlayed = 0;
				_activeSongAlias = null;
			}
			bool num = source.clip != null;
			string text = ((source.clip == null) ? string.Empty : source.clip.name);
			source.Stop();
			AudioUtil.UnloadNonPreloadedAudioData(source.clip, GameObj);
			AudioResourceOptimizer.UnloadPlaylistSongIfUnused(ControllerName, source.clip);
			source.clip = null;
			RemoveScheduledClip();
			if (num)
			{
				if (!string.IsNullOrEmpty(text) && songEndedEventExpanded && songEndedCustomEvent != string.Empty && songEndedCustomEvent != "[None]")
				{
					MasterAudio.FireCustomEvent(songEndedCustomEvent, Trans, logDupe: false);
				}
				if (this.SongEnded != null && !string.IsNullOrEmpty(text))
				{
					this.SongEnded(text);
				}
			}
		}

		private void SetDuckProperties()
		{
			_originalMusicVolume = ((_activeAudio == null) ? 1f : _activeAudio.volume);
			if (_currentSong != null)
			{
				_originalMusicVolume = _currentSong.volume * PlaylistVolume;
			}
			float floatVolumeFromDb = AudioUtil.GetFloatVolumeFromDb(AudioUtil.GetDbFromFloatVolume(_originalMusicVolume) - _currentDuckVolCut);
			_duckRange = _originalMusicVolume - floatVolumeFromDb;
			_initialDuckVolume = floatVolumeFromDb;
			_duckingMode = AudioDuckingMode.NotDucking;
		}

		private void AudioDucking()
		{
			switch (_duckingMode)
			{
			case AudioDuckingMode.SetToDuck:
				_activeAudio.volume = _initialDuckVolume;
				_duckingMode = AudioDuckingMode.Ducked;
				break;
			case AudioDuckingMode.Ducked:
				if (Time.realtimeSinceStartup >= _timeToFinishUnducking)
				{
					_activeAudio.volume = _originalMusicVolume;
					_duckingMode = AudioDuckingMode.NotDucking;
				}
				else if (Time.realtimeSinceStartup >= _timeToStartUnducking)
				{
					_activeAudio.volume = _initialDuckVolume + (Time.realtimeSinceStartup - _timeToStartUnducking) / (_timeToFinishUnducking - _timeToStartUnducking) * _duckRange;
				}
				break;
			case AudioDuckingMode.NotDucking:
				break;
			}
		}

		private bool SongShouldLoop(MusicSetting setting)
		{
			if (_queuedSongs.Count > 0)
			{
				return false;
			}
			if (SongIsNonAdvancible)
			{
				return true;
			}
			return setting.isLoop;
		}

		public void RouteToMixerChannel(AudioMixerGroup group)
		{
			_activeAudio.outputAudioMixerGroup = group;
			_transitioningAudio.outputAudioMixerGroup = group;
		}
	}
	public static class SpatializerHelper
	{
		private const string OculusSpatializer = "OculusSpatializer";

		private const string ResonanceAudioSpatializer = "Resonance Audio";

		public static bool IsSupportedSpatializer
		{
			get
			{
				string selectedSpatializer = SelectedSpatializer;
				if (!(selectedSpatializer == "OculusSpatializer"))
				{
					if (selectedSpatializer == "Resonance Audio")
					{
						return true;
					}
					return false;
				}
				return true;
			}
		}

		public static bool IsOculusAudioSpatializer => SelectedSpatializer == "OculusSpatializer";

		public static bool IsResonanceAudioSpatializer => SelectedSpatializer == "Resonance Audio";

		public static string SelectedSpatializer => AudioSettings.GetSpatializerPluginName();

		public static bool SpatializerOptionExists => true;

		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
			if (SpatializerOptionExists && !(MasterAudio.SafeInstance == null) && MasterAudio.Instance.useSpatializer)
			{
				source.spatialize = true;
				if (ResonanceAudioHelper.ResonanceAudioOptionExists && MasterAudio.Instance.useSpatializerPostFX)
				{
					source.spatializePostEffects = true;
				}
			}
		}
	}
	public static class UtilStrings
	{
		public static string TrimSpace(string untrimmed)
		{
			if (string.IsNullOrEmpty(untrimmed))
			{
				return string.Empty;
			}
			return untrimmed.Trim();
		}

		public static string ReplaceUnsafeChars(string source)
		{
			source = source.Replace("'", "&apos;");
			source = source.Replace("\"", "&quot;");
			source = source.Replace("&", "&amp;");
			return source;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	public class MA_Bootstrapper : MonoBehaviour
	{
		private void Awake()
		{
		}

		private void OnGUI()
		{
			GUI.Label(new Rect(20f, 40f, 640f, 190f), "This is the Bootstrapper Scene. Set it up in BuildSettings as the first Scene. Then add '_AfterBootstrapperScene' as the second Scene. Hit play. Master Audio is configured in 'persist between Scenes' mode. Finally, click 'Load Game Scene' button and notice how the music doesn't get interruped even though we're changing Scenes. Normally a Bootstrapper Scene would not be seen. We are illustrating how to set up though. Notice that no Sound Groups are set up in Master Audio. Sample music provided by Alchemy Studios. This music 'The Epic Trailer' (longer version) is available on the Asset Store!");
			if (GUI.Button(new Rect(100f, 150f, 150f, 100f), "Load Game Scene"))
			{
				SceneManager.LoadScene(1);
			}
		}
	}
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		private ParticleSystem particles;

		private void Awake()
		{
			base.useGUILayout = false;
			particles = GetComponent<ParticleSystem>();
		}

		private void Update()
		{
			if (!particles.IsAlive())
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}
	public class MA_EnemyOne : MonoBehaviour
	{
		public GameObject ExplosionParticlePrefab;

		private Transform _trans;

		private float _speed;

		private float _horizSpeed;

		private void Awake()
		{
			base.useGUILayout = false;
			_trans = base.transform;
			_speed = (float)UnityEngine.Random.Range(-3, -8) * AudioUtil.FrameTime;
			_horizSpeed = (float)UnityEngine.Random.Range(-3, 3) * AudioUtil.FrameTime;
		}

		private void OnCollisionEnter(Collision collision)
		{
			UnityEngine.Object.Instantiate(ExplosionParticlePrefab, _trans.position, Quaternion.identity);
		}

		private void Update()
		{
			Vector3 position = _trans.position;
			position.x += _horizSpeed;
			position.y += _speed;
			_trans.position = position;
			_trans.Rotate(Vector3.down * 300f * AudioUtil.FrameTime);
			if (_trans.position.y < -5f)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}
	public class MA_EnemySpawner : MonoBehaviour
	{
		public GameObject Enemy;

		public bool spawnerEnabled;

		private Transform trans;

		private float nextSpawnTime;

		private void Awake()
		{
			base.useGUILayout = false;
			trans = base.transform;
			nextSpawnTime = AudioUtil.Time + UnityEngine.Random.Range(0.3f, 0.7f);
		}

		private void Update()
		{
			if (spawnerEnabled && Time.time >= nextSpawnTime)
			{
				Vector3 position = trans.position;
				int num = UnityEngine.Random.Range(1, 3);
				for (int i = 0; i < num; i++)
				{
					position.x = UnityEngine.Random.Range(position.x - 6f, position.x + 6f);
					UnityEngine.Object.Instantiate(Enemy, position, Enemy.transform.rotation);
				}
				nextSpawnTime = AudioUtil.Time + UnityEngine.Random.Range(0.3f, 0.7f);
			}
		}
	}
	public class MA_GameScene : MonoBehaviour
	{
		private void OnGUI()
		{
			GUI.Label(new Rect(20f, 40f, 640f, 190f), "This is the Game Scene. We have used a Dynamic Sound Group Creator prefab to populate temporary Sound Groups into Master Audio as soon as that prefab becomes enabled (on Scene change for us). If we were to load a different Scene now, those sounds would vanish from the mixer.");
		}
	}
	public class MA_Laser : MonoBehaviour
	{
		private Transform _trans;

		private void Awake()
		{
			base.useGUILayout = false;
			_trans = base.transform;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.name.StartsWith("Enemy("))
			{
				UnityEngine.Object.Destroy(collision.gameObject);
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		private void Update()
		{
			float num = 10f * AudioUtil.FrameTime;
			Vector3 position = _trans.position;
			position.y += num;
			_trans.position = position;
			if (_trans.position.y > 7f)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}
	}
	public class MA_LocalizationUI : MonoBehaviour
	{
		private void OnGUI()
		{
			GUI.Label(new Rect(20f, 40f, 640f, 200f), "This scene shows the automatic Localization of Resource files. Preview the 'hello' sound from the mixer, which will be in Spanish first. Then press stop, and change the 'Use Specific Language' language to another language up in the top section of the Master Audio prefab's Inspector, hit play and hear the difference! The correct folder's audio file will be loaded automatically according to your language settings.");
		}
	}
	public class MA_PlayerControl : MonoBehaviour
	{
		public GameObject ProjectilePrefab;

		public bool canShoot = true;

		private const float MoveSpeed = 10f;

		private Transform _trans;

		private float _lastMoveAmt;

		private void Awake()
		{
			base.useGUILayout = false;
			_trans = base.transform;
		}

		private void OnCollisionEnter(Collision collision)
		{
			if (collision.gameObject.name.StartsWith("Enemy("))
			{
				base.gameObject.SetActive(value: false);
			}
		}

		private void OnDisable()
		{
		}

		private void OnBecameInvisible()
		{
		}

		private void OnBecameVisible()
		{
		}

		private void Update()
		{
			float num = Input.GetAxis("Horizontal") * 10f * AudioUtil.FrameTime;
			if (num != 0f)
			{
				if (_lastMoveAmt == 0f)
				{
					MasterAudio.FireCustomEvent("PlayerMoved", _trans);
				}
			}
			else if (_lastMoveAmt != 0f)
			{
				MasterAudio.FireCustomEvent("PlayerStoppedMoving", _trans);
			}
			_lastMoveAmt = num;
			Vector3 position = _trans.position;
			position.x += num;
			_trans.position = position;
			if (canShoot && Input.GetMouseButtonDown(0))
			{
				Vector3 position2 = _trans.position;
				position2.y += 1f;
				UnityEngine.Object.Instantiate(ProjectilePrefab, position2, ProjectilePrefab.transform.rotation);
			}
		}
	}
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		public GameObject Player;

		private float nextSpawnTime;

		private bool PlayerActive => Player.activeInHierarchy;

		private void Awake()
		{
			base.useGUILayout = false;
			nextSpawnTime = -1f;
		}

		private void Update()
		{
			if (!PlayerActive)
			{
				if (nextSpawnTime < 0f)
				{
					nextSpawnTime = AudioUtil.Time + 1f;
				}
				if (Time.time >= nextSpawnTime)
				{
					Player.SetActive(value: true);
					nextSpawnTime = -1f;
				}
			}
		}
	}
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		private readonly List<string> _eventsSubscribedTo = new List<string> { "PlayerMoved", "PlayerStoppedMoving" };

		private void Awake()
		{
		}

		private void Start()
		{
			CheckForIllegalCustomEvents();
		}

		private void OnEnable()
		{
			RegisterReceiver();
		}

		private void OnDisable()
		{
			if (!(MasterAudio.SafeInstance == null) && !MasterAudio.AppIsShuttingDown)
			{
				UnregisterReceiver();
			}
		}

		public void CheckForIllegalCustomEvents()
		{
			for (int i = 0; i < _eventsSubscribedTo.Count; i++)
			{
				if (!MasterAudio.CustomEventExists(_eventsSubscribedTo[i]))
				{
					UnityEngine.Debug.LogError("Custom Event, listened to by '" + base.name + "', could not be found in MasterAudio.");
				}
			}
		}

		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
			if (!(customEventName == "PlayerMoved"))
			{
				if (customEventName == "PlayerStoppedMoving")
				{
					UnityEngine.Debug.Log("PlayerStoppedMoving event recieved by '" + base.name + "'.");
				}
			}
			else
			{
				UnityEngine.Debug.Log("PlayerMoved event recieved by '" + base.name + "'.");
			}
		}

		public bool SubscribesToEvent(string customEventName)
		{
			if (string.IsNullOrEmpty(customEventName))
			{
				return false;
			}
			return _eventsSubscribedTo.Contains(customEventName);
		}

		public void RegisterReceiver()
		{
			MasterAudio.AddCustomEventReceiver(this, base.transform);
		}

		public void UnregisterReceiver()
		{
			MasterAudio.RemoveCustomEventReceiver(this);
		}

		public IList<AudioEventGroup> GetAllEvents()
		{
			List<AudioEventGroup> list = new List<AudioEventGroup>();
			for (int i = 0; i < _eventsSubscribedTo.Count; i++)
			{
				list.Add(new AudioEventGroup
				{
					customEventName = _eventsSubscribedTo[i]
				});
			}
			return list;
		}
	}
	public class MA_TestUI : MonoBehaviour
	{
		private void OnGUI()
		{
			GUI.Label(new Rect(20f, 40f, 640f, 260f), "Use left/right arrow keys and left mouse button to play. Music ducks (gets quieter) for Screams, then ramps back up soon after. Sound FX have variations. No code needed to be written for any of the sound triggering or ducking. See ReadMe.pdf for more information on how to set things up. Note the Jukebox control that handles the Playlist Controller in the scene! It's in the Master Audio prefab's Inspector. Also, take note of the DynamicSoundGroupCreator prefab, which adds a new temporary Sound Group during the current Scene only! Go ahead and click on the 'Enemy Spawner' script and turn on the checkbox for 'Spawner Enabled' for enemies! There's one Custom Event 'PlayerOffscreen' that gets triggered from EventSounds on the Player when you move offscreen. The EventSounds script on PlayerSpawner receives that event and plays an arrow sound when it happens. We've also implemented a sample class 'MA_SampleICustomEventReceiver' that implements the ICustomEventReciever class if you wish to see how to do that. It's attached to the main camera prefab. A linked group of Blast is set up in the Scream Group, take a look! Sample music provided by Alchemy Studios. \n\nHappy gaming - DarkTonic, Inc.");
		}
	}
}
