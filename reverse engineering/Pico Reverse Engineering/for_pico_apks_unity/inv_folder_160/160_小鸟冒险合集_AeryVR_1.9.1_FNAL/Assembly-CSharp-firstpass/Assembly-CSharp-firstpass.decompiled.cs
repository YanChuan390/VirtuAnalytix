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
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44A6BC", Offset = "0x44A6BC")]
public class ListenerFollower : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform _transToFollow;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x17000001")]
	public GameObject GameObj
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5D8A30", Offset = "0x5D8A30", VA = "0x5D8A30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000002")]
	public Transform Trans
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5D85EC", Offset = "0x5D85EC", VA = "0x5D85EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x5D8388", Offset = "0x5D8388", VA = "0x5D8388")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x5D838C", Offset = "0x5D838C", VA = "0x5D838C")]
	public void StartFollowing(Transform transToFollow, float trigRadius)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x5D83D4", Offset = "0x5D83D4", VA = "0x5D83D4")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x5D8498", Offset = "0x5D8498", VA = "0x5D8498")]
	private void BatchOcclusionRaycasts()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x5D8AD0", Offset = "0x5D8AD0", VA = "0x5D8AD0")]
	public ListenerFollower()
	{
	}
}
[Token(Token = "0x2000003")]
public static class OculusAudioHelper
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xAA6824", Offset = "0xAA6824", VA = "0xAA6824")]
	public static bool DarkTonicOculusAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xAA682C", Offset = "0xAA682C", VA = "0xAA682C")]
	public static void AddOculusAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xAA6830", Offset = "0xAA6830", VA = "0xAA6830")]
	public static void AddOculusAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xAA6834", Offset = "0xAA6834", VA = "0xAA6834")]
	public static void RemoveOculusAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xAA6838", Offset = "0xAA6838", VA = "0xAA6838")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xAA683C", Offset = "0xAA683C", VA = "0xAA683C")]
	public static void CopyOculusAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xAA6840", Offset = "0xAA6840", VA = "0xAA6840")]
	public static void CopyOculusAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000004")]
public static class ResonanceAudioHelper
{
	[Token(Token = "0x17000003")]
	public static bool ResonanceAudioOptionExists
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0xAB145C", Offset = "0xAB145C", VA = "0xAB145C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xAB1464", Offset = "0xAB1464", VA = "0xAB1464")]
	public static bool DarkTonicResonanceAudioPackageInstalled()
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xAB146C", Offset = "0xAB146C", VA = "0xAB146C")]
	public static void AddResonanceAudioSourceToVariation(SoundGroupVariation variation)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xAB1470", Offset = "0xAB1470", VA = "0xAB1470")]
	public static void AddResonanceAudioSourceToAllVariations()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xAB1474", Offset = "0xAB1474", VA = "0xAB1474")]
	public static void RemoveResonanceAudioSourceFromAllVariations()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xAB1478", Offset = "0xAB1478", VA = "0xAB1478")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xAB147C", Offset = "0xAB147C", VA = "0xAB147C")]
	public static void CopyResonanceAudioSource(DynamicGroupVariation sourceVariation, SoundGroupVariation destVariation)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xAB1480", Offset = "0xAB1480", VA = "0xAB1480")]
	public static void CopyResonanceAudioSource(SoundGroupVariation sourceVariation, DynamicGroupVariation destVariation)
	{
	}
}
[Token(Token = "0x2000005")]
public class TransformFollower : MonoBehaviour
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B064", Offset = "0x44B064")]
	public Transform RuntimeFollowingTransform;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _goToFollow;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform _trans;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject _go;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string _soundType;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _variationName;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _willFollowSource;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _isInsideTrigger;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	private bool _hasPlayedSound;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float _playVolume;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _positionAtClosestColliderPoint;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private MasterAudio.AmbientSoundExitMode _exitMode;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float _exitFadeTime;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private MasterAudio.AmbientSoundReEnterMode _reEnterMode;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _reEnterFadeTime;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 _lastListenerPos;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private PlaySoundResult playingVariation;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private PlaySoundResult fadingVariation;

	[Token(Token = "0x17000004")]
	public GameObject GameObj
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x9DAED0", Offset = "0x9DAED0", VA = "0x9DAED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Transform Trans
	{
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x9DB4D8", Offset = "0x9DB4D8", VA = "0x9DB4D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x9DA8DC", Offset = "0x9DA8DC", VA = "0x9DA8DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x9DA928", Offset = "0x9DA928", VA = "0x9DA928")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x9DAB0C", Offset = "0x9DAB0C", VA = "0x9DAB0C")]
	public void StartFollowing(Transform transToFollow, string soundType, string variationName, float volume, float trigRadius, bool willFollowSource, bool positionAtClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x9DAE4C", Offset = "0x9DAE4C", VA = "0x9DAE4C")]
	private void StopFollowing()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x9DAF70", Offset = "0x9DAF70", VA = "0x9DAF70")]
	private void PlaySound()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x9DB3E8", Offset = "0x9DB3E8", VA = "0x9DB3E8")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x9DADA4", Offset = "0x9DADA4", VA = "0x9DADA4")]
	public bool RecalcClosestColliderPosition(bool forceRecalc = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x9DA994", Offset = "0x9DA994", VA = "0x9DA994")]
	private void PerformTriggerExit()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x9DB578", Offset = "0x9DB578", VA = "0x9DB578")]
	public TransformFollower()
	{
	}
}
[Token(Token = "0x2000006")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x6BFA5C", Offset = "0x6BFA5C", VA = "0x6BFA5C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x6BFC58", Offset = "0x6BFC58", VA = "0x6BFC58", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x6BFF50", Offset = "0x6BFF50", VA = "0x6BFF50")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000007")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x6D1DA4", Offset = "0x6D1DA4", VA = "0x6D1DA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x6D1EB8", Offset = "0x6D1EB8", VA = "0x6D1EB8")]
	public EventSystemChecker()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000008")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000009")]
		public enum Mode
		{
			[Token(Token = "0x400001E")]
			Trigger,
			[Token(Token = "0x400001F")]
			Replace,
			[Token(Token = "0x4000020")]
			Activate,
			[Token(Token = "0x4000021")]
			Enable,
			[Token(Token = "0x4000022")]
			Animate,
			[Token(Token = "0x4000023")]
			Deactivate
		}

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x6BEC54", Offset = "0x6BEC54", VA = "0x6BEC54")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x6BF0F4", Offset = "0x6BF0F4", VA = "0x6BF0F4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x6BF0F8", Offset = "0x6BF0F8", VA = "0x6BF0F8")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000B")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x600002C")]
			[Address(RVA = "0x9E0AE0", Offset = "0x9E0AE0", VA = "0x9E0AE0")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200000C")]
		public class ReplacementList
		{
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x600002D")]
			[Address(RVA = "0x9E0AE8", Offset = "0x9E0AE8", VA = "0x9E0AE8")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x6C5714", Offset = "0x6C5714", VA = "0x6C5714")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x6C61F0", Offset = "0x6C61F0", VA = "0x6C61F0")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200000E")]
		public class Vector3andSpace
		{
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x6000031")]
			[Address(RVA = "0x9E0B50", Offset = "0x9E0B50", VA = "0x9E0B50")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x6C61F8", Offset = "0x6C61F8", VA = "0x6C61F8")]
		private void Start()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x6C6220", Offset = "0x6C6220", VA = "0x6C6220")]
		private void Update()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x6C62F0", Offset = "0x6C62F0", VA = "0x6C62F0")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class CameraRefocus
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x6C7C20", Offset = "0x6C7C20", VA = "0x6C7C20")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x6C7C94", Offset = "0x6C7C94", VA = "0x6C7C94")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x6C7C9C", Offset = "0x6C7C9C", VA = "0x6C7C9C")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x6C7CA4", Offset = "0x6C7CA4", VA = "0x6C7CA4")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x6C7DA0", Offset = "0x6C7DA0", VA = "0x6C7DA0")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000010")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x6C8680", Offset = "0x6C8680", VA = "0x6C8680")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x6C8724", Offset = "0x6C8724", VA = "0x6C8724")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x6C8820", Offset = "0x6C8820", VA = "0x6C8820")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000012")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A6D0", Offset = "0x44A6D0")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000006")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000041")]
				[Address(RVA = "0x9E1384", Offset = "0x9E1384", VA = "0x9E1384", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000007")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000043")]
				[Address(RVA = "0x9E13CC", Offset = "0x9E13CC", VA = "0x9E13CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600003E")]
			[Address(RVA = "0x9E10FC", Offset = "0x9E10FC", VA = "0x9E10FC")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600003F")]
			[Address(RVA = "0x9E1128", Offset = "0x9E1128", VA = "0x9E1128", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000040")]
			[Address(RVA = "0x9E112C", Offset = "0x9E112C", VA = "0x9E112C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x9E138C", Offset = "0x9E138C", VA = "0x9E138C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003C")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400003D")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400003E")]
		private const float k_Drag = 10f;

		[Token(Token = "0x400003F")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000040")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000041")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x6C8F24", Offset = "0x6C8F24", VA = "0x6C8F24")]
		private void Update()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x6C9374", Offset = "0x6C9374", VA = "0x6C9374")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C080", Offset = "0x44C080")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x6C92BC", Offset = "0x6C92BC", VA = "0x6C92BC")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x6C93FC", Offset = "0x6C93FC", VA = "0x6C93FC")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x6C9E14", Offset = "0x6C9E14", VA = "0x6C9E14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x6C9E48", Offset = "0x6C9E48", VA = "0x6C9E48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x6CA004", Offset = "0x6CA004", VA = "0x6CA004")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000014")]
	public class FOVKick
	{
		[Token(Token = "0x2000015")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A6E0", Offset = "0x44A6E0")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x17000008")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000050")]
				[Address(RVA = "0x9E267C", Offset = "0x9E267C", VA = "0x9E267C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000009")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000052")]
				[Address(RVA = "0x9E26C4", Offset = "0x9E26C4", VA = "0x9E26C4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600004D")]
			[Address(RVA = "0x9E2510", Offset = "0x9E2510", VA = "0x9E2510")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600004E")]
			[Address(RVA = "0x9E253C", Offset = "0x9E253C", VA = "0x9E253C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600004F")]
			[Address(RVA = "0x9E2540", Offset = "0x9E2540", VA = "0x9E2540", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000051")]
			[Address(RVA = "0x9E2684", Offset = "0x9E2684", VA = "0x9E2684", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000016")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A6F0", Offset = "0x44A6F0")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700000A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000056")]
				[Address(RVA = "0x9E24C0", Offset = "0x9E24C0", VA = "0x9E24C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000058")]
				[Address(RVA = "0x9E2508", Offset = "0x9E2508", VA = "0x9E2508", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000053")]
			[Address(RVA = "0x9E2340", Offset = "0x9E2340", VA = "0x9E2340")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000054")]
			[Address(RVA = "0x9E236C", Offset = "0x9E236C", VA = "0x9E236C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000055")]
			[Address(RVA = "0x9E2370", Offset = "0x9E2370", VA = "0x9E2370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000057")]
			[Address(RVA = "0x9E24C8", Offset = "0x9E24C8", VA = "0x9E24C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x6D2300", Offset = "0x6D2300", VA = "0x6D2300")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x6D234C", Offset = "0x6D234C", VA = "0x6D234C")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x6D2438", Offset = "0x6D2438", VA = "0x6D2438")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x6D2440", Offset = "0x6D2440", VA = "0x6D2440")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C130", Offset = "0x44C130")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x6D24B8", Offset = "0x6D24B8", VA = "0x6D24B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C190", Offset = "0x44C190")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x6D2530", Offset = "0x6D2530", VA = "0x6D2530")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A700", Offset = "0x44A700")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000063")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000067")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x6D254C", Offset = "0x6D254C", VA = "0x6D254C")]
		private void Start()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x6D25BC", Offset = "0x6D25BC", VA = "0x6D25BC")]
		private void Update()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x6D26C0", Offset = "0x6D26C0", VA = "0x6D26C0")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x5D605C", Offset = "0x5D605C", VA = "0x5D605C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5D60BC", Offset = "0x5D60BC", VA = "0x5D60BC")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000019")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200001A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A760", Offset = "0x44A760")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000064")]
				[Address(RVA = "0x9E28A0", Offset = "0x9E28A0", VA = "0x9E28A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x9E28E8", Offset = "0x9E28E8", VA = "0x9E28E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000061")]
			[Address(RVA = "0x9E26CC", Offset = "0x9E26CC", VA = "0x9E26CC")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000062")]
			[Address(RVA = "0x9E26F8", Offset = "0x9E26F8", VA = "0x9E26F8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000063")]
			[Address(RVA = "0x9E26FC", Offset = "0x9E26FC", VA = "0x9E26FC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000065")]
			[Address(RVA = "0x9E28A8", Offset = "0x9E28A8", VA = "0x9E28A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x5D8380", Offset = "0x5D8380", VA = "0x5D8380")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x5D7BE4", Offset = "0x5D7BE4", VA = "0x5D7BE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C290", Offset = "0x44C290")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x5D7D04", Offset = "0x5D7D04", VA = "0x5D7D04")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200001C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A770", Offset = "0x44A770")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x1700000E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600006F")]
				[Address(RVA = "0x9E3F38", Offset = "0x9E3F38", VA = "0x9E3F38", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000071")]
				[Address(RVA = "0x9E3F80", Offset = "0x9E3F80", VA = "0x9E3F80", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600006C")]
			[Address(RVA = "0x9E3D78", Offset = "0x9E3D78", VA = "0x9E3D78")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600006D")]
			[Address(RVA = "0x9E3DA4", Offset = "0x9E3DA4", VA = "0x9E3DA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600006E")]
			[Address(RVA = "0x9E3DA8", Offset = "0x9E3DA8", VA = "0x9E3DA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000070")]
			[Address(RVA = "0x9E3F40", Offset = "0x9E3F40", VA = "0x9E3F40", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xAA6668", Offset = "0xAA6668", VA = "0xAA6668")]
		private void Start()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xAA6708", Offset = "0xAA6708", VA = "0xAA6708")]
		public void SetOriginals(Transform t)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xAA6758", Offset = "0xAA6758", VA = "0xAA6758")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xAA6784", Offset = "0xAA6784", VA = "0xAA6784")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C340", Offset = "0x44C340")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xAA680C", Offset = "0xAA680C", VA = "0xAA680C")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200001E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A780", Offset = "0x44A780")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000010")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000078")]
				[Address(RVA = "0x9E4318", Offset = "0x9E4318", VA = "0x9E4318", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000011")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x9E4360", Offset = "0x9E4360", VA = "0x9E4360", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000075")]
			[Address(RVA = "0x9E3F88", Offset = "0x9E3F88", VA = "0x9E3F88")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000076")]
			[Address(RVA = "0x9E3FB4", Offset = "0x9E3FB4", VA = "0x9E3FB4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x9E3FB8", Offset = "0x9E3FB8", VA = "0x9E3FB8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x9E4320", Offset = "0x9E4320", VA = "0x9E4320", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xAA6844", Offset = "0xAA6844", VA = "0xAA6844")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C3F0", Offset = "0x44C3F0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xAA68BC", Offset = "0xAA68BC", VA = "0xAA68BC")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xAA68C8", Offset = "0xAA68C8", VA = "0xAA68C8")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000020")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000087")]
			Standalone,
			[Token(Token = "0x4000088")]
			Mobile
		}

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xAA92D0", Offset = "0xAA92D0", VA = "0xAA92D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xAA92D4", Offset = "0xAA92D4", VA = "0xAA92D4")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xAA92F0", Offset = "0xAA92F0", VA = "0xAA92F0")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xAA96A0", Offset = "0xAA96A0", VA = "0xAA96A0")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xAB201C", Offset = "0xAB201C", VA = "0xAB201C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xAB2058", Offset = "0xAB2058", VA = "0xAB2058")]
		private void Update()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xAB23B0", Offset = "0xAB23B0", VA = "0xAB23B0")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xAB2494", Offset = "0xAB2494", VA = "0xAB2494")]
		private void Start()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xAB2498", Offset = "0xAB2498", VA = "0xAB2498")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xAB2740", Offset = "0xAB2740", VA = "0xAB2740")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000024")]
		public enum Action
		{
			[Token(Token = "0x400009A")]
			Activate,
			[Token(Token = "0x400009B")]
			Deactivate,
			[Token(Token = "0x400009C")]
			Destroy,
			[Token(Token = "0x400009D")]
			ReloadLevel,
			[Token(Token = "0x400009E")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000025")]
		public class Entry
		{
			[Token(Token = "0x400009F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x40000A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x40000A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x600008A")]
			[Address(RVA = "0x9E6214", Offset = "0x9E6214", VA = "0x9E6214")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000026")]
		public class Entries
		{
			[Token(Token = "0x40000A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x9DA214", Offset = "0x9DA214", VA = "0x9DA214")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000027")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A790", Offset = "0x44A790")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000012")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x9E5F40", Offset = "0x9E5F40", VA = "0x9E5F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000013")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000091")]
				[Address(RVA = "0x9E5F88", Offset = "0x9E5F88", VA = "0x9E5F88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x9DA120", Offset = "0x9DA120", VA = "0x9DA120")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x9E5E6C", Offset = "0x9E5E6C", VA = "0x9E5E6C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600008E")]
			[Address(RVA = "0x9E5E70", Offset = "0x9E5E70", VA = "0x9E5E70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000090")]
			[Address(RVA = "0x9E5F48", Offset = "0x9E5F48", VA = "0x9E5F48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000028")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A7A0", Offset = "0x44A7A0")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000014")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000095")]
				[Address(RVA = "0x9E6064", Offset = "0x9E6064", VA = "0x9E6064", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x9E60AC", Offset = "0x9E60AC", VA = "0x9E60AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000092")]
			[Address(RVA = "0x9DA14C", Offset = "0x9DA14C", VA = "0x9DA14C")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000093")]
			[Address(RVA = "0x9E5F90", Offset = "0x9E5F90", VA = "0x9E5F90", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000094")]
			[Address(RVA = "0x9E5F94", Offset = "0x9E5F94", VA = "0x9E5F94", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000096")]
			[Address(RVA = "0x9E606C", Offset = "0x9E606C", VA = "0x9E606C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000029")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A7B0", Offset = "0x44A7B0")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000016")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x9E61C4", Offset = "0x9E61C4", VA = "0x9E61C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0x9E620C", Offset = "0x9E620C", VA = "0x9E620C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000098")]
			[Address(RVA = "0x9DA178", Offset = "0x9DA178", VA = "0x9DA178")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000099")]
			[Address(RVA = "0x9E60B4", Offset = "0x9E60B4", VA = "0x9E60B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600009A")]
			[Address(RVA = "0x9E60B8", Offset = "0x9E60B8", VA = "0x9E60B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600009C")]
			[Address(RVA = "0x9E61CC", Offset = "0x9E61CC", VA = "0x9E61CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x9D9E90", Offset = "0x9D9E90", VA = "0x9D9E90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x9D9FB8", Offset = "0x9D9FB8", VA = "0x9D9FB8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C4A0", Offset = "0x44C4A0")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x9DA030", Offset = "0x9DA030", VA = "0x9DA030")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C500", Offset = "0x44C500")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x9DA0A8", Offset = "0x9DA0A8", VA = "0x9DA0A8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C560", Offset = "0x44C560")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x9DA1A4", Offset = "0x9DA1A4", VA = "0x9DA1A4")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9DA21C", Offset = "0x9DA21C", VA = "0x9DA21C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9DA270", Offset = "0x9DA270", VA = "0x9DA270")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9DA30C", Offset = "0x9DA30C", VA = "0x9DA30C")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		public class WaypointList
		{
			[Token(Token = "0x40000BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40000BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x9DF50C", Offset = "0x9DF50C", VA = "0x9DF50C")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x200002D")]
		public struct RoutePoint
		{
			[Token(Token = "0x40000C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x9DF0E4", Offset = "0x9DF0E4", VA = "0x9DF0E4")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B17C", Offset = "0x44B17C")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x17000018")]
		public float Length
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x9DEA70", Offset = "0x9DEA70", VA = "0x9DEA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C6B0", Offset = "0x44C6B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x9DEA78", Offset = "0x9DEA78", VA = "0x9DEA78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C6C0", Offset = "0x44C6C0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x9DEA80", Offset = "0x9DEA80", VA = "0x9DEA80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9DEA9C", Offset = "0x9DEA9C", VA = "0x9DEA9C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9DEDCC", Offset = "0x9DEDCC", VA = "0x9DEDCC")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9DEE58", Offset = "0x9DEE58", VA = "0x9DEE58")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9DF0F4", Offset = "0x9DF0F4", VA = "0x9DF0F4")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9DEAF8", Offset = "0x9DEAF8", VA = "0x9DEAF8")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9DF200", Offset = "0x9DF200", VA = "0x9DF200")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9DF488", Offset = "0x9DF488", VA = "0x9DF488")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9DF208", Offset = "0x9DF208", VA = "0x9DF208")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9DF490", Offset = "0x9DF490", VA = "0x9DF490")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x200002F")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40000D2")]
			SmoothAlongRoute,
			[Token(Token = "0x40000D3")]
			PointToPoint
		}

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B1FC", Offset = "0x44B1FC")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B20C", Offset = "0x44B20C")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B21C", Offset = "0x44B21C")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x1700001A")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x9DF574", Offset = "0x9DF574", VA = "0x9DF574")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C6D0", Offset = "0x44C6D0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x9DF588", Offset = "0x9DF588", VA = "0x9DF588")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C6E0", Offset = "0x44C6E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x9DF59C", Offset = "0x9DF59C", VA = "0x9DF59C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C6F0", Offset = "0x44C6F0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x9DF5B0", Offset = "0x9DF5B0", VA = "0x9DF5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C700", Offset = "0x44C700")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x9DF5C4", Offset = "0x9DF5C4", VA = "0x9DF5C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C710", Offset = "0x44C710")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x9DF5D8", Offset = "0x9DF5D8", VA = "0x9DF5D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C720", Offset = "0x44C720")]
			private set
			{
			}
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9DF5EC", Offset = "0x9DF5EC", VA = "0x9DF5EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9DF6F4", Offset = "0x9DF6F4", VA = "0x9DF6F4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9DF7CC", Offset = "0x9DF7CC", VA = "0x9DF7CC")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9DFBC8", Offset = "0x9DFBC8", VA = "0x9DFBC8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9DFD18", Offset = "0x9DFD18", VA = "0x9DFD18")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A7C0", Offset = "0x44A7C0")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x6BF110", Offset = "0x6BF110", VA = "0x6BF110")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x6BF1B4", Offset = "0x6BF1B4", VA = "0x6BF1B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x6BF5C0", Offset = "0x6BF5C0", VA = "0x6BF5C0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x6BFA48", Offset = "0x6BFA48", VA = "0x6BFA48")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x2000032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A820", Offset = "0x44A820")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000C4")]
				[Address(RVA = "0x9E1BD0", Offset = "0x9E1BD0", VA = "0x9E1BD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000C6")]
				[Address(RVA = "0x9E1C18", Offset = "0x9E1C18", VA = "0x9E1C18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x9E1678", Offset = "0x9E1678", VA = "0x9E1678")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x9E16A4", Offset = "0x9E16A4", VA = "0x9E16A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x9E16A8", Offset = "0x9E16A8", VA = "0x9E16A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x9E1BD8", Offset = "0x9E1BD8", VA = "0x9E1BD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x6D1EC0", Offset = "0x6D1EC0", VA = "0x6D1EC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C730", Offset = "0x44C730")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x6D1F38", Offset = "0x6D1F38", VA = "0x6D1F38")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x6D205C", Offset = "0x6D205C", VA = "0x6D205C")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x2000034")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A830", Offset = "0x44A830")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000CC")]
				[Address(RVA = "0x9E1FD0", Offset = "0x9E1FD0", VA = "0x9E1FD0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000CE")]
				[Address(RVA = "0x9E2018", Offset = "0x9E2018", VA = "0x9E2018", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x9E1C20", Offset = "0x9E1C20", VA = "0x9E1C20")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x9E1C4C", Offset = "0x9E1C4C", VA = "0x9E1C4C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x9E1C50", Offset = "0x9E1C50", VA = "0x9E1C50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x9E1FD8", Offset = "0x9E1FD8", VA = "0x9E1FD8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x6D2064", Offset = "0x6D2064", VA = "0x6D2064")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C7E0", Offset = "0x44C7E0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x6D20DC", Offset = "0x6D20DC", VA = "0x6D20DC")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x2000036")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44A840", Offset = "0x44A840")]
		private sealed class <OnCollisionEnter>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision col;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000D6")]
				[Address(RVA = "0x9E22F0", Offset = "0x9E22F0", VA = "0x9E22F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000D8")]
				[Address(RVA = "0x9E2338", Offset = "0x9E2338", VA = "0x9E2338", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x9E2020", Offset = "0x9E2020", VA = "0x9E2020")]
			[DebuggerHidden]
			public <OnCollisionEnter>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x9E204C", Offset = "0x9E204C", VA = "0x9E204C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x9E2050", Offset = "0x9E2050", VA = "0x9E2050", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x9E22F8", Offset = "0x9E22F8", VA = "0x9E22F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform explosionPrefab;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float detonationImpactVelocity;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float sizeMultiplier;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool reset;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float resetTimeDelay;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_Exploded;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObjectResetter m_ObjectResetter;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x6D20EC", Offset = "0x6D20EC", VA = "0x6D20EC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x6D2148", Offset = "0x6D2148", VA = "0x6D2148")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44C890", Offset = "0x44C890")]
		private IEnumerator OnCollisionEnter(Collision col)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x6D21DC", Offset = "0x6D21DC", VA = "0x6D21DC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x6D21E4", Offset = "0x6D21E4", VA = "0x6D21E4")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x6D2208", Offset = "0x6D2208", VA = "0x6D2208")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x6D2264", Offset = "0x6D2264", VA = "0x6D2264")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x6D22F0", Offset = "0x6D22F0", VA = "0x6D22F0")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x6D48AC", Offset = "0x6D48AC", VA = "0x6D48AC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x6D4920", Offset = "0x6D4920", VA = "0x6D4920")]
		private void Update()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x6D4ADC", Offset = "0x6D4ADC", VA = "0x6D4ADC")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x6D4B04", Offset = "0x6D4B04", VA = "0x6D4B04")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x5D7D0C", Offset = "0x5D7D0C", VA = "0x5D7D0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x5D7E88", Offset = "0x5D7E88", VA = "0x5D7E88")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xAA68DC", Offset = "0xAA68DC", VA = "0xAA68DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xAA6A3C", Offset = "0xAA6A3C", VA = "0xAA6A3C")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xAB23D0", Offset = "0xAB23D0", VA = "0xAB23D0")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xAB248C", Offset = "0xAB248C", VA = "0xAB248C")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9DE414", Offset = "0x9DE414", VA = "0x9DE414")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9DE470", Offset = "0x9DE470", VA = "0x9DE470")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9DE6E4", Offset = "0x9DE6E4", VA = "0x9DE6E4")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace UnityStandardAssets.Water
{
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	public class WaterBasic : MonoBehaviour
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9DE1E0", Offset = "0x9DE1E0", VA = "0x9DE1E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9DE40C", Offset = "0x9DE40C", VA = "0x9DE40C")]
		public WaterBasic()
		{
		}
	}
	[Token(Token = "0x200003E")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A860", Offset = "0x44A860")]
	public class Displace : MonoBehaviour
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x6C8E28", Offset = "0x6C8E28", VA = "0x6C8E28")]
		public void Awake()
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x6C8E4C", Offset = "0x6C8E4C", VA = "0x6C8E4C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x6C8EB4", Offset = "0x6C8EB4", VA = "0x6C8EB4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x6C8F1C", Offset = "0x6C8F1C", VA = "0x6C8F1C")]
		public Displace()
		{
		}
	}
	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A8D0", Offset = "0x44A8D0")]
	[ExecuteInEditMode]
	public class GerstnerDisplace : Displace
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x5D7338", Offset = "0x5D7338", VA = "0x5D7338")]
		public GerstnerDisplace()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class MeshContainer
	{
		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Mesh mesh;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] vertices;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] normals;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xAA4A78", Offset = "0xAA4A78", VA = "0xAA4A78")]
		public MeshContainer(Mesh m)
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xAA4AEC", Offset = "0xAA4AEC", VA = "0xAA4AEC")]
		public void Update()
		{
		}
	}
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A940", Offset = "0x44A940")]
	public class PlanarReflection : MonoBehaviour
	{
		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask reflectionMask;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool reflectSkybox;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color clearColor;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string reflectionSampler;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float clipPlaneOffset;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool onlyCalculateOnStart;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Texture savedTexture;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 m_Oldpos;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Camera m_ReflectionCamera;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material m_SharedMaterial;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Dictionary<Camera, bool> m_HelperCameras;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xAA7B54", Offset = "0xAA7B54", VA = "0xAA7B54")]
		public void Start()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xAA7C5C", Offset = "0xAA7C5C", VA = "0xAA7C5C")]
		private Camera CreateReflectionCameraFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xAA7FB4", Offset = "0xAA7FB4", VA = "0xAA7FB4")]
		private void SetStandardCameraParameter(Camera cam, LayerMask mask)
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xAA8064", Offset = "0xAA8064", VA = "0xAA8064")]
		private RenderTexture CreateTextureFor(Camera cam)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xAA8140", Offset = "0xAA8140", VA = "0xAA8140")]
		public void RenderHelpCameras(Camera currentCam)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xAA8A0C", Offset = "0xAA8A0C", VA = "0xAA8A0C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xAA8A68", Offset = "0xAA8A68", VA = "0xAA8A68")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xAA8B5C", Offset = "0xAA8B5C", VA = "0xAA8B5C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xAA8BC4", Offset = "0xAA8BC4", VA = "0xAA8BC4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xAA8304", Offset = "0xAA8304", VA = "0xAA8304")]
		private void RenderReflectionFor(Camera cam, Camera reflectCamera)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xAA8C2C", Offset = "0xAA8C2C", VA = "0xAA8C2C")]
		private void SaneCameraSettings(Camera helperCam)
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xAA9074", Offset = "0xAA9074", VA = "0xAA9074")]
		private static Matrix4x4 CalculateObliqueMatrix(Matrix4x4 projection, Vector4 clipPlane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xAA8C90", Offset = "0xAA8C90", VA = "0xAA8C90")]
		private static Matrix4x4 CalculateReflectionMatrix(Matrix4x4 reflectionMat, Vector4 plane)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xAA9238", Offset = "0xAA9238", VA = "0xAA9238")]
		private static float Sgn(float a)
		{
			return default(float);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xAA8F48", Offset = "0xAA8F48", VA = "0xAA8F48")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xAA9258", Offset = "0xAA9258", VA = "0xAA9258")]
		public PlanarReflection()
		{
		}
	}
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44A9B0", Offset = "0x44A9B0")]
	[ExecuteInEditMode]
	public class SpecularLighting : MonoBehaviour
	{
		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform specularLight;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private WaterBase m_WaterBase;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x9D9080", Offset = "0x9D9080", VA = "0x9D9080")]
		public void Start()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x9D9190", Offset = "0x9D9190", VA = "0x9D9190")]
		public void Update()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x9D93B8", Offset = "0x9D93B8", VA = "0x9D93B8")]
		public SpecularLighting()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		[Token(Token = "0x2000044")]
		public enum WaterMode
		{
			[Token(Token = "0x4000121")]
			Simple,
			[Token(Token = "0x4000122")]
			Reflective,
			[Token(Token = "0x4000123")]
			Refractive
		}

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaterMode waterMode;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disablePixelLights;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int textureSize;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float clipPlaneOffset;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask reflectLayers;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask refractLayers;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<Camera, Camera> m_ReflectionCameras;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<Camera, Camera> m_RefractionCameras;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RenderTexture m_ReflectionTexture;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private RenderTexture m_RefractionTexture;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private WaterMode m_HardwareWaterSupport;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_OldReflectionTextureSize;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_OldRefractionTextureSize;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool s_InsideWater;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x9DBC88", Offset = "0x9DBC88", VA = "0x9DBC88")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x9DD7A0", Offset = "0x9DD7A0", VA = "0x9DD7A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x9DDB38", Offset = "0x9DDB38", VA = "0x9DDB38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x9DD16C", Offset = "0x9DD16C", VA = "0x9DD16C")]
		private void UpdateCameraModes(Camera src, Camera dest)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x9DC7C0", Offset = "0x9DC7C0", VA = "0x9DC7C0")]
		private void CreateWaterObjects(Camera currentCamera, out Camera reflectionCamera, out Camera refractionCamera)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x9DC7AC", Offset = "0x9DC7AC", VA = "0x9DC7AC")]
		private WaterMode GetWaterMode()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x9DC638", Offset = "0x9DC638", VA = "0x9DC638")]
		private WaterMode FindHardwareWaterSupport()
		{
			return default(WaterMode);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x9DD674", Offset = "0x9DD674", VA = "0x9DD674")]
		private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x9DD3D0", Offset = "0x9DD3D0", VA = "0x9DD3D0")]
		private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x9DDE08", Offset = "0x9DDE08", VA = "0x9DDE08")]
		public Water()
		{
		}
	}
	[Token(Token = "0x2000045")]
	public enum WaterQuality
	{
		[Token(Token = "0x4000125")]
		High = 2,
		[Token(Token = "0x4000126")]
		Medium = 1,
		[Token(Token = "0x4000127")]
		Low = 0
	}
	[Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material sharedMaterial;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterQuality waterQuality;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool edgeBlend;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x9DDF04", Offset = "0x9DDF04", VA = "0x9DDF04")]
		public void UpdateShader()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x9DE098", Offset = "0x9DE098", VA = "0x9DE098")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x9DE148", Offset = "0x9DE148", VA = "0x9DE148")]
		public void Update()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x9DE1C8", Offset = "0x9DE1C8", VA = "0x9DE1C8")]
		public WaterBase()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	public class WaterTile : MonoBehaviour
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlanarReflection reflection;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WaterBase waterBase;

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x9DE770", Offset = "0x9DE770", VA = "0x9DE770")]
		public void Start()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x9DE774", Offset = "0x9DE774", VA = "0x9DE774")]
		private void AcquireComponents()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x9DE958", Offset = "0x9DE958", VA = "0x9DE958")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x9DEA68", Offset = "0x9DEA68", VA = "0x9DEA68")]
		public WaterTile()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000048")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x6C62F8", Offset = "0x6C62F8", VA = "0x6C62F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x6C6574", Offset = "0x6C6574", VA = "0x6C6574")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x6C6724", Offset = "0x6C6724", VA = "0x6C6724")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x6C6740", Offset = "0x6C6740", VA = "0x6C6740", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x6C6800", Offset = "0x6C6800", VA = "0x6C6800", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x6C6854", Offset = "0x6C6854", VA = "0x6C6854")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x6C77B0", Offset = "0x6C77B0", VA = "0x6C77B0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x6C77B4", Offset = "0x6C77B4", VA = "0x6C77B4")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x6C7894", Offset = "0x6C7894", VA = "0x6C7894")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x6C7974", Offset = "0x6C7974", VA = "0x6C7974")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x6C7A54", Offset = "0x6C7A54", VA = "0x6C7A54")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x6C7B34", Offset = "0x6C7B34", VA = "0x6C7B34")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x6C7C14", Offset = "0x6C7C14", VA = "0x6C7C14")]
		public void Update()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x6C7C18", Offset = "0x6C7C18", VA = "0x6C7C18")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x200004B")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x4000138")]
			Hardware,
			[Token(Token = "0x4000139")]
			Touch
		}

		[Token(Token = "0x200004C")]
		public class VirtualAxis
		{
			[Token(Token = "0x400013A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B22C", Offset = "0x44B22C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400013B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x400013C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B23C", Offset = "0x44B23C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x17000024")]
			public string name
			{
				[Token(Token = "0x600013E")]
				[Address(RVA = "0x9E0CAC", Offset = "0x9E0CAC", VA = "0x9E0CAC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C940", Offset = "0x44C940")]
				get
				{
					return null;
				}
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x9E0CB4", Offset = "0x9E0CB4", VA = "0x9E0CB4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C950", Offset = "0x44C950")]
				private set
				{
				}
			}

			[Token(Token = "0x17000025")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0x9E0CBC", Offset = "0x9E0CBC", VA = "0x9E0CBC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C960", Offset = "0x44C960")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000141")]
				[Address(RVA = "0x9E0CC4", Offset = "0x9E0CC4", VA = "0x9E0CC4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C970", Offset = "0x44C970")]
				private set
				{
				}
			}

			[Token(Token = "0x17000026")]
			public float GetValue
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x9E0D24", Offset = "0x9E0D24", VA = "0x9E0D24")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000027")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000147")]
				[Address(RVA = "0x9E0D2C", Offset = "0x9E0D2C", VA = "0x9E0D2C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000142")]
			[Address(RVA = "0x9D9B98", Offset = "0x9D9B98", VA = "0x9D9B98")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000143")]
			[Address(RVA = "0x9E0CD0", Offset = "0x9E0CD0", VA = "0x9E0CD0")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x9D9E18", Offset = "0x9D9E18", VA = "0x9D9E18")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x9E0D1C", Offset = "0x9E0D1C", VA = "0x9E0D1C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200004D")]
		public class VirtualButton
		{
			[Token(Token = "0x400013D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B24C", Offset = "0x44B24C")]
			private string <name>k__BackingField;

			[Token(Token = "0x400013E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B25C", Offset = "0x44B25C")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x400013F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x4000140")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x4000141")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x17000028")]
			public string name
			{
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x9E0D34", Offset = "0x9E0D34", VA = "0x9E0D34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C980", Offset = "0x44C980")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x9E0D3C", Offset = "0x9E0D3C", VA = "0x9E0D3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C990", Offset = "0x44C990")]
				private set
				{
				}
			}

			[Token(Token = "0x17000029")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600014A")]
				[Address(RVA = "0x9E0D44", Offset = "0x9E0D44", VA = "0x9E0D44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9A0", Offset = "0x44C9A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600014B")]
				[Address(RVA = "0x9E0D4C", Offset = "0x9E0D4C", VA = "0x9E0D4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9B0", Offset = "0x44C9B0")]
				private set
				{
				}
			}

			[Token(Token = "0x1700002A")]
			public bool GetButton
			{
				[Token(Token = "0x6000151")]
				[Address(RVA = "0x9E0EC4", Offset = "0x9E0EC4", VA = "0x9E0EC4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002B")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x9E0ECC", Offset = "0x9E0ECC", VA = "0x9E0ECC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700002C")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000153")]
				[Address(RVA = "0x9E0EFC", Offset = "0x9E0EFC", VA = "0x9E0EFC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x9E0D58", Offset = "0x9E0D58", VA = "0x9E0D58")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x9E0DA0", Offset = "0x9E0DA0", VA = "0x9E0DA0")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x9E0DF4", Offset = "0x9E0DF4", VA = "0x9E0DF4")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x9E0E30", Offset = "0x9E0E30", VA = "0x9E0E30")]
			public void Released()
			{
			}

			[Token(Token = "0x6000150")]
			[Address(RVA = "0x9E0E5C", Offset = "0x9E0E5C", VA = "0x9E0E5C")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000023")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x6C8488", Offset = "0x6C8488", VA = "0x6C8488")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x6C7E68", Offset = "0x6C7E68", VA = "0x6C7E68")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x6C7F30", Offset = "0x6C7F30", VA = "0x6C7F30")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x6C640C", Offset = "0x6C640C", VA = "0x6C640C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x6C7FE4", Offset = "0x6C7FE4", VA = "0x6C7FE4")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x6C6484", Offset = "0x6C6484", VA = "0x6C6484")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x6C805C", Offset = "0x6C805C", VA = "0x6C805C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x6C80D4", Offset = "0x6C80D4", VA = "0x6C80D4")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x6C8198", Offset = "0x6C8198", VA = "0x6C8198")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x6C64FC", Offset = "0x6C64FC", VA = "0x6C64FC")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x6C6D70", Offset = "0x6C6D70", VA = "0x6C6D70")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x6C829C", Offset = "0x6C829C", VA = "0x6C829C")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x6C8210", Offset = "0x6C8210", VA = "0x6C8210")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x6C6DD4", Offset = "0x6C6DD4", VA = "0x6C6DD4")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x6C8300", Offset = "0x6C8300", VA = "0x6C8300")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x6C837C", Offset = "0x6C837C", VA = "0x6C837C")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x6C7818", Offset = "0x6C7818", VA = "0x6C7818")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x6C78F8", Offset = "0x6C78F8", VA = "0x6C78F8")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x6C79D8", Offset = "0x6C79D8", VA = "0x6C79D8")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x6C7B98", Offset = "0x6C7B98", VA = "0x6C7B98")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x6C7AB8", Offset = "0x6C7AB8", VA = "0x6C7AB8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x6C83F8", Offset = "0x6C83F8", VA = "0x6C83F8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x6C8500", Offset = "0x6C8500", VA = "0x6C8500")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x6C8580", Offset = "0x6C8580", VA = "0x6C8580")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x6C8600", Offset = "0x6C8600", VA = "0x6C8600")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5D7EA4", Offset = "0x5D7EA4", VA = "0x5D7EA4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5D7EA8", Offset = "0x5D7EA8", VA = "0x5D7EA8")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5D7F28", Offset = "0x5D7F28", VA = "0x5D7F28")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000050")]
		public enum AxisOption
		{
			[Token(Token = "0x400014D")]
			Both,
			[Token(Token = "0x400014E")]
			OnlyHorizontal,
			[Token(Token = "0x400014F")]
			OnlyVertical
		}

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x5D7F30", Offset = "0x5D7F30", VA = "0x5D7F30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x5D8090", Offset = "0x5D8090", VA = "0x5D8090")]
		private void Start()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5D80CC", Offset = "0x5D80CC", VA = "0x5D80CC")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x5D7F34", Offset = "0x5D7F34", VA = "0x5D7F34")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5D8130", Offset = "0x5D8130", VA = "0x5D8130", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x5D8254", Offset = "0x5D8254", VA = "0x5D8254", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5D829C", Offset = "0x5D829C", VA = "0x5D829C", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x5D82A0", Offset = "0x5D82A0", VA = "0x5D82A0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5D82F8", Offset = "0x5D82F8", VA = "0x5D82F8")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000051")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000160")]
		[Address(RVA = "0xAA4B30", Offset = "0xAA4B30", VA = "0xAA4B30")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xAA4B40", Offset = "0xAA4B40", VA = "0xAA4B40")]
		private void Start()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xAA4B38", Offset = "0xAA4B38", VA = "0xAA4B38")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xAA4C54", Offset = "0xAA4C54", VA = "0xAA4C54")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xAA4F10", Offset = "0xAA4F10", VA = "0xAA4F10")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000053")]
		public enum AxisOptions
		{
			[Token(Token = "0x4000156")]
			ForwardAxis,
			[Token(Token = "0x4000157")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x2000054")]
		public class AxisMapping
		{
			[Token(Token = "0x2000055")]
			public enum MappingType
			{
				[Token(Token = "0x400015B")]
				NamedAxis,
				[Token(Token = "0x400015C")]
				MousePositionX,
				[Token(Token = "0x400015D")]
				MousePositionY,
				[Token(Token = "0x400015E")]
				MousePositionZ
			}

			[Token(Token = "0x4000158")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x4000159")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000169")]
			[Address(RVA = "0x9E5E64", Offset = "0x9E5E64", VA = "0x9E5E64")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x9D9AB0", Offset = "0x9D9AB0", VA = "0x9D9AB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9D9BD8", Offset = "0x9D9BD8", VA = "0x9D9BD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9D9E00", Offset = "0x9D9E00", VA = "0x9D9E00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9D9E80", Offset = "0x9D9E80", VA = "0x9D9E80")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44AA60", Offset = "0x44AA60")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000057")]
		public enum AxisOption
		{
			[Token(Token = "0x4000172")]
			Both,
			[Token(Token = "0x4000173")]
			OnlyHorizontal,
			[Token(Token = "0x4000174")]
			OnlyVertical
		}

		[Token(Token = "0x2000058")]
		public enum ControlStyle
		{
			[Token(Token = "0x4000176")]
			Absolute,
			[Token(Token = "0x4000177")]
			Relative,
			[Token(Token = "0x4000178")]
			Swipe
		}

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9DA31C", Offset = "0x9DA31C", VA = "0x9DA31C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x9DA4A4", Offset = "0x9DA4A4", VA = "0x9DA4A4")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9DA320", Offset = "0x9DA320", VA = "0x9DA320")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9DA52C", Offset = "0x9DA52C", VA = "0x9DA52C")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x9DA598", Offset = "0x9DA598", VA = "0x9DA598", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x9DA5D0", Offset = "0x9DA5D0", VA = "0x9DA5D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x9DA718", Offset = "0x9DA718", VA = "0x9DA718", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x9DA74C", Offset = "0x9DA74C", VA = "0x9DA74C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x9DA84C", Offset = "0x9DA84C", VA = "0x9DA84C")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B26C", Offset = "0x44B26C")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x1700002D")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x9DB6F4", Offset = "0x9DB6F4", VA = "0x9DB6F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9C0", Offset = "0x44C9C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x9DB700", Offset = "0x9DB700", VA = "0x9DB700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9D0", Offset = "0x44C9D0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x9DB70C", Offset = "0x9DB70C", VA = "0x9DB70C")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9DB770", Offset = "0x9DB770", VA = "0x9DB770")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x9DB7D4", Offset = "0x9DB7D4", VA = "0x9DB7D4")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x9DB934", Offset = "0x9DB934", VA = "0x9DB934")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x9DBA94", Offset = "0x9DBA94", VA = "0x9DBA94")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x9DBB34", Offset = "0x9DBB34", VA = "0x9DBB34")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x9DBBD4", Offset = "0x9DBBD4", VA = "0x9DBBD4")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x9DBC70", Offset = "0x9DBC70", VA = "0x9DBC70")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x9DBC78", Offset = "0x9DBC78", VA = "0x9DBC78")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9DBC80", Offset = "0x9DBC80", VA = "0x9DBC80")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x600017F")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000180")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000181")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000182")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000183")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000184")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000185")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000186")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x6000187")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x6000188")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x6000189")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x9D95FC", Offset = "0x9D95FC", VA = "0x9D95FC")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200005A")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0xAA4F18", Offset = "0xAA4F18", VA = "0xAA4F18")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xAA4FA8", Offset = "0xAA4FA8", VA = "0xAA4FA8")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xAA5038", Offset = "0xAA5038", VA = "0xAA5038", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xAA50DC", Offset = "0xAA50DC", VA = "0xAA50DC", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xAA5180", Offset = "0xAA5180", VA = "0xAA5180", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xAA5224", Offset = "0xAA5224", VA = "0xAA5224", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xAA52CC", Offset = "0xAA52CC", VA = "0xAA52CC", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xAA5374", Offset = "0xAA5374", VA = "0xAA5374", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xAA5418", Offset = "0xAA5418", VA = "0xAA5418", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xAA54C8", Offset = "0xAA54C8", VA = "0xAA54C8", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xAA556C", Offset = "0xAA556C", VA = "0xAA556C", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xAA5610", Offset = "0xAA5610", VA = "0xAA5610", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xAA56B4", Offset = "0xAA56B4", VA = "0xAA56B4", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xAA56C0", Offset = "0xAA56C0", VA = "0xAA56C0")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x9D93C0", Offset = "0x9D93C0", VA = "0x9D93C0", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x9D93D4", Offset = "0x9D93D4", VA = "0x9D93D4", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x9D93E0", Offset = "0x9D93E0", VA = "0x9D93E0", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x9D93EC", Offset = "0x9D93EC", VA = "0x9D93EC", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x9D93F8", Offset = "0x9D93F8", VA = "0x9D93F8", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x9D944C", Offset = "0x9D944C", VA = "0x9D944C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x9D94A0", Offset = "0x9D94A0", VA = "0x9D94A0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x9D94F4", Offset = "0x9D94F4", VA = "0x9D94F4", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x9D9548", Offset = "0x9D9548", VA = "0x9D9548", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x9D959C", Offset = "0x9D959C", VA = "0x9D959C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x9D95F0", Offset = "0x9D95F0", VA = "0x9D95F0", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x9D95F8", Offset = "0x9D95F8", VA = "0x9D95F8")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x200005C")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000181")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x6C68C4", Offset = "0x6C68C4", VA = "0x6C68C4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x6C6940", Offset = "0x6C6940", VA = "0x6C6940")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x6C6A58", Offset = "0x6C6A58", VA = "0x6C6A58")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x6C6A7C", Offset = "0x6C6A7C", VA = "0x6C6A7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x6C6BA4", Offset = "0x6C6BA4", VA = "0x6C6BA4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x6C6E50", Offset = "0x6C6E50", VA = "0x6C6E50")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x6C6E8C", Offset = "0x6C6E8C", VA = "0x6C6E8C")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x200005E")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B2BC", Offset = "0x44B2BC")]
		public float RunningStrideLengthen;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5D7980", Offset = "0x5D7980", VA = "0x5D7980")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x5D79DC", Offset = "0x5D79DC", VA = "0x5D79DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5D7C5C", Offset = "0x5D7C5C", VA = "0x5D7C5C")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class MouseLook
	{
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xAA56C8", Offset = "0xAA56C8", VA = "0xAA56C8")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xAA571C", Offset = "0xAA571C", VA = "0xAA571C")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xAA5A6C", Offset = "0xAA5A6C", VA = "0xAA5A6C")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xAA5A5C", Offset = "0xAA5A5C", VA = "0xAA5A5C")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xAA5AA0", Offset = "0xAA5AA0", VA = "0xAA5AA0")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xAA59F4", Offset = "0xAA59F4", VA = "0xAA59F4")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xAA5B1C", Offset = "0xAA5B1C", VA = "0xAA5B1C")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44AAC0", Offset = "0x44AAC0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44AAC0", Offset = "0x44AAC0")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000061")]
		public class MovementSettings
		{
			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40001AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x9E5430", Offset = "0x9E5430", VA = "0x9E5430")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x9E54C0", Offset = "0x9E54C0", VA = "0x9E54C0")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000062")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40001B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40001B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40001B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B2E4", Offset = "0x44B2E4")]
			public float shellOffset;

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x9E5414", Offset = "0x9E5414", VA = "0x9E5414")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x1700002E")]
		public Vector3 Velocity
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0xAB1484", Offset = "0xAB1484", VA = "0xAB1484")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002F")]
		public bool Grounded
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xAB14A0", Offset = "0xAB14A0", VA = "0xAB14A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000030")]
		public bool Jumping
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0xAB14A8", Offset = "0xAB14A8", VA = "0xAB14A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public bool Running
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0xAB14B0", Offset = "0xAB14B0", VA = "0xAB14B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xAB14B8", Offset = "0xAB14B8", VA = "0xAB14B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xAB1584", Offset = "0xAB1584", VA = "0xAB1584")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xAB1790", Offset = "0xAB1790", VA = "0xAB1790")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xAB1CC4", Offset = "0xAB1CC4", VA = "0xAB1CC4")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xAB1D38", Offset = "0xAB1D38", VA = "0xAB1D38")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xAB1BF4", Offset = "0xAB1BF4", VA = "0xAB1BF4")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xAB161C", Offset = "0xAB161C", VA = "0xAB161C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xAB1A74", Offset = "0xAB1A74", VA = "0xAB1A74")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xAB1F10", Offset = "0xAB1F10", VA = "0xAB1F10")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x2000063")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000064")]
		public enum UpdateType
		{
			[Token(Token = "0x40001B9")]
			FixedUpdate,
			[Token(Token = "0x40001BA")]
			LateUpdate,
			[Token(Token = "0x40001BB")]
			ManualUpdate
		}

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x17000032")]
		public Transform Target
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x6BEC3C", Offset = "0x6BEC3C", VA = "0x6BEC3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x6BE834", Offset = "0x6BE834", VA = "0x6BE834", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x6BE9BC", Offset = "0x6BE9BC", VA = "0x6BE9BC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x6BEA8C", Offset = "0x6BEA8C", VA = "0x6BEA8C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x6BEB60", Offset = "0x6BEB60", VA = "0x6BEB60")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001CA")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x6BE8F8", Offset = "0x6BE8F8", VA = "0x6BE8F8")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x6BEC34", Offset = "0x6BEC34", VA = "0x6BEC34", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x6BEC44", Offset = "0x6BEC44", VA = "0x6BEC44")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x17000033")]
		public float TurnSpeed
		{
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x6C52A4", Offset = "0x6C52A4", VA = "0x6C52A4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x6C52AC", Offset = "0x6C52AC", VA = "0x6C52AC")]
			set
			{
			}
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x6C52B4", Offset = "0x6C52B4", VA = "0x6C52B4", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x6C56B0", Offset = "0x6C56B0", VA = "0x6C56B0")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B3DC", Offset = "0x44B3DC")]
		private float m_TurnSpeed;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x40001D1")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x5D6DAC", Offset = "0x5D6DAC", VA = "0x5D6DAC", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x5D6E70", Offset = "0x5D6E70", VA = "0x5D6E70")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5D71AC", Offset = "0x5D71AC", VA = "0x5D71AC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x5D71D0", Offset = "0x5D71D0", VA = "0x5D71D0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5D6ED0", Offset = "0x5D6ED0", VA = "0x5D6ED0")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5D7318", Offset = "0x5D7318", VA = "0x5D7318")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B49C", Offset = "0x44B49C")]
		private float m_TrackingBias;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5D75DC", Offset = "0x5D75DC", VA = "0x5D75DC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x5D7950", Offset = "0x5D7950", VA = "0x5D7950")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x5D8AD8", Offset = "0x5D8AD8", VA = "0x5D8AD8", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x5D7718", Offset = "0x5D7718", VA = "0x5D7718", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x5D7970", Offset = "0x5D7970", VA = "0x5D7970")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xAA7ABC", Offset = "0xAA7ABC", VA = "0xAA7ABC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xAA7B4C", Offset = "0xAA7B4C", VA = "0xAA7B4C")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x200006B")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x9E5308", Offset = "0x9E5308", VA = "0x9E5308", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x9E540C", Offset = "0x9E540C", VA = "0x9E540C")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B4FC", Offset = "0x44B4FC")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x17000034")]
		public bool protecting
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0xAB0D48", Offset = "0xAB0D48", VA = "0xAB0D48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9E0", Offset = "0x44C9E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0xAB0D50", Offset = "0xAB0D50", VA = "0xAB0D50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C9F0", Offset = "0x44C9F0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xAB0D5C", Offset = "0xAB0D5C", VA = "0xAB0D5C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xAB0E68", Offset = "0xAB0E68", VA = "0xAB0E68")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xAB13D0", Offset = "0xAB13D0", VA = "0xAB13D0")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x9D9718", Offset = "0x9D9718", VA = "0x9D9718", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x9D9970", Offset = "0x9D9970", VA = "0x9D9970", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x9D9A60", Offset = "0x9D9A60", VA = "0x9D9A60", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x9D9790", Offset = "0x9D9790", VA = "0x9D9790")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x9D9A9C", Offset = "0x9D9A9C", VA = "0x9D9A9C")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace RelationsInspector.Backend.AutoBackend
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44AB64", Offset = "0x44AB64")]
	public class AutoBackendAttribute : Attribute
	{
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x6C529C", Offset = "0x6C529C", VA = "0x6C529C")]
		public AutoBackendAttribute()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44AB78", Offset = "0x44AB78")]
	public class RelatedAttribute : Attribute
	{
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xAB144C", Offset = "0xAB144C", VA = "0xAB144C")]
		public RelatedAttribute()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x44AB8C", Offset = "0x44AB8C")]
	public class RelatingAttribute : Attribute
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xAB1454", Offset = "0xAB1454", VA = "0xAB1454")]
		public RelatingAttribute()
		{
		}
	}
}
namespace DarkTonic.MasterAudio
{
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44ABA0", Offset = "0x44ABA0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44ABA0", Offset = "0x44ABA0")]
	public class AmbientSound : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SoundGroup]
		public string AmbientSoundGroup;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string variationName;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float playVolume;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public MasterAudio.AmbientSoundExitMode exitMode;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float exitFadeTime;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AmbientSoundReEnterMode reEnterMode;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float reEnterFadeTime;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B54C", Offset = "0x44B54C")]
		public bool FollowCaller;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B584", Offset = "0x44B584")]
		public bool UseClosestColliderPosition;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool UseTopCollider;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool IncludeChildColliders;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B5BC", Offset = "0x44B5BC")]
		public Transform RuntimeFollower;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _trans;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public long lastTimeMaxDistanceCalced;

		[Token(Token = "0x17000035")]
		public bool IsValidSoundGroup
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x6C0114", Offset = "0x6C0114", VA = "0x6C0114")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public Transform Trans
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x6C0310", Offset = "0x6C0310", VA = "0x6C0310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x6BFF58", Offset = "0x6BFF58", VA = "0x6BFF58")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x6BFFBC", Offset = "0x6BFFBC", VA = "0x6BFFBC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x6C01A8", Offset = "0x6C01A8", VA = "0x6C01A8")]
		private void StopTrackers()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x6C03B0", Offset = "0x6C03B0", VA = "0x6C03B0")]
		public void CalculateRadius()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x6C04A4", Offset = "0x6C04A4", VA = "0x6C04A4")]
		public AudioSource GetNamedOrFirstAudioSource()
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x6C068C", Offset = "0x6C068C", VA = "0x6C068C")]
		public List<AudioSource> GetAllVariationAudioSources()
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x6C08BC", Offset = "0x6C08BC", VA = "0x6C08BC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x6C0B3C", Offset = "0x6C0B3C", VA = "0x6C0B3C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x6C0DBC", Offset = "0x6C0DBC", VA = "0x6C0DBC")]
		public void StartTrackers()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x6C0FE0", Offset = "0x6C0FE0", VA = "0x6C0FE0")]
		public AmbientSound()
		{
		}
	}
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44ABF0", Offset = "0x44ABF0")]
	public class ButtonClicker : MonoBehaviour
	{
		[Token(Token = "0x4000207")]
		public const float SmallSizeMultiplier = 0.9f;

		[Token(Token = "0x4000208")]
		public const float LargeSizeMultiplier = 1.1f;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool resizeOnClick;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool resizeClickAllSiblings;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool resizeOnHover;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool resizeHoverAllSiblings;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mouseDownSound;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string mouseUpSound;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mouseClickSound;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mouseOverSound;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mouseOutSound;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _originalSize;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _smallerSize;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _largerSize;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _trans;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private readonly Dictionary<Transform, Vector3> _siblingClickScaleByTransform;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<Transform, Vector3> _siblingHoverScaleByTransform;

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x6C6EB4", Offset = "0x6C6EB4", VA = "0x6C6EB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x6C7128", Offset = "0x6C7128", VA = "0x6C7128")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x6C737C", Offset = "0x6C737C", VA = "0x6C737C")]
		private void OnClick()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x6C7418", Offset = "0x6C7418", VA = "0x6C7418")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x6C766C", Offset = "0x6C766C", VA = "0x6C766C")]
		public ButtonClicker()
		{
		}
	}
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44AC28", Offset = "0x44AC28")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44AC28", Offset = "0x44AC28")]
	public class EventSounds : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x2000073")]
		public enum UnityUIVersion
		{
			[Token(Token = "0x400028C")]
			Legacy,
			[Token(Token = "0x400028D")]
			uGUI
		}

		[Token(Token = "0x2000074")]
		public enum EventType
		{
			[Token(Token = "0x400028F")]
			OnStart,
			[Token(Token = "0x4000290")]
			OnVisible,
			[Token(Token = "0x4000291")]
			OnInvisible,
			[Token(Token = "0x4000292")]
			OnCollision,
			[Token(Token = "0x4000293")]
			OnTriggerEnter,
			[Token(Token = "0x4000294")]
			OnTriggerExit,
			[Token(Token = "0x4000295")]
			OnMouseEnter,
			[Token(Token = "0x4000296")]
			OnMouseClick,
			[Token(Token = "0x4000297")]
			OnSpawned,
			[Token(Token = "0x4000298")]
			OnDespawned,
			[Token(Token = "0x4000299")]
			OnEnable,
			[Token(Token = "0x400029A")]
			OnDisable,
			[Token(Token = "0x400029B")]
			OnCollision2D,
			[Token(Token = "0x400029C")]
			OnTriggerEnter2D,
			[Token(Token = "0x400029D")]
			OnTriggerExit2D,
			[Token(Token = "0x400029E")]
			OnParticleCollision,
			[Token(Token = "0x400029F")]
			UserDefinedEvent,
			[Token(Token = "0x40002A0")]
			OnCollisionExit,
			[Token(Token = "0x40002A1")]
			OnCollisionExit2D,
			[Token(Token = "0x40002A2")]
			OnMouseUp,
			[Token(Token = "0x40002A3")]
			OnMouseExit,
			[Token(Token = "0x40002A4")]
			OnMouseDrag,
			[Token(Token = "0x40002A5")]
			NGUIOnClick,
			[Token(Token = "0x40002A6")]
			NGUIMouseDown,
			[Token(Token = "0x40002A7")]
			NGUIMouseUp,
			[Token(Token = "0x40002A8")]
			NGUIMouseEnter,
			[Token(Token = "0x40002A9")]
			NGUIMouseExit,
			[Token(Token = "0x40002AA")]
			MechanimStateChanged,
			[Token(Token = "0x40002AB")]
			UnitySliderChanged,
			[Token(Token = "0x40002AC")]
			UnityButtonClicked,
			[Token(Token = "0x40002AD")]
			UnityPointerDown,
			[Token(Token = "0x40002AE")]
			UnityPointerUp,
			[Token(Token = "0x40002AF")]
			UnityPointerEnter,
			[Token(Token = "0x40002B0")]
			UnityPointerExit,
			[Token(Token = "0x40002B1")]
			UnityDrag,
			[Token(Token = "0x40002B2")]
			UnityDrop,
			[Token(Token = "0x40002B3")]
			UnityScroll,
			[Token(Token = "0x40002B4")]
			UnityUpdateSelected,
			[Token(Token = "0x40002B5")]
			UnitySelect,
			[Token(Token = "0x40002B6")]
			UnityDeselect,
			[Token(Token = "0x40002B7")]
			UnityMove,
			[Token(Token = "0x40002B8")]
			UnityInitializePotentialDrag,
			[Token(Token = "0x40002B9")]
			UnityBeginDrag,
			[Token(Token = "0x40002BA")]
			UnityEndDrag,
			[Token(Token = "0x40002BB")]
			UnitySubmit,
			[Token(Token = "0x40002BC")]
			UnityCancel,
			[Token(Token = "0x40002BD")]
			UnityToggle,
			[Token(Token = "0x40002BE")]
			OnTriggerStay,
			[Token(Token = "0x40002BF")]
			OnTriggerStay2D
		}

		[Token(Token = "0x2000075")]
		public enum GlidePitchType
		{
			[Token(Token = "0x40002C1")]
			None,
			[Token(Token = "0x40002C2")]
			RaisePitch,
			[Token(Token = "0x40002C3")]
			LowerPitch
		}

		[Token(Token = "0x2000076")]
		public enum VariationType
		{
			[Token(Token = "0x40002C5")]
			PlaySpecific,
			[Token(Token = "0x40002C6")]
			PlayRandom
		}

		[Token(Token = "0x2000077")]
		public enum PreviousSoundStopMode
		{
			[Token(Token = "0x40002C8")]
			None,
			[Token(Token = "0x40002C9")]
			Stop,
			[Token(Token = "0x40002CA")]
			FadeOut
		}

		[Token(Token = "0x2000078")]
		public enum RetriggerLimMode
		{
			[Token(Token = "0x40002CC")]
			None,
			[Token(Token = "0x40002CD")]
			FrameBased,
			[Token(Token = "0x40002CE")]
			TimeBased
		}

		[Token(Token = "0x2000079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AC78", Offset = "0x44AC78")]
		private sealed class <CoUpdate>d__123 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventSounds <>4__this;

			[Token(Token = "0x17000039")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0x9E1628", Offset = "0x9E1628", VA = "0x9E1628", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700003A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000240")]
				[Address(RVA = "0x9E1670", Offset = "0x9E1670", VA = "0x9E1670", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x9E145C", Offset = "0x9E145C", VA = "0x9E145C")]
			[DebuggerHidden]
			public <CoUpdate>d__123(int <>1__state)
			{
			}

			[Token(Token = "0x600023C")]
			[Address(RVA = "0x9E1488", Offset = "0x9E1488", VA = "0x9E1488", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x9E148C", Offset = "0x9E148C", VA = "0x9E148C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x9E1630", Offset = "0x9E1630", VA = "0x9E1630", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200007A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AC88", Offset = "0x44AC88")]
		private sealed class <>c__DisplayClass165_0
		{
			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string stateName;

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x9E1430", Offset = "0x9E1430", VA = "0x9E1430")]
			public <>c__DisplayClass165_0()
			{
			}

			[Token(Token = "0x6000242")]
			[Address(RVA = "0x9E1438", Offset = "0x9E1438", VA = "0x9E1438")]
			internal bool <GetMechanimAudioEventGroup>b__0(AudioEventGroup grp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool disableSounds;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool showPoolManager;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool showNGUI;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioEvent eventToGizmo;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityUIVersion unityUIMode;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool logMissingEvents;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static List<string> LayerTagFilterEvents;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static List<MasterAudio.PlaylistCommand> PlaylistCommandsWithAll;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioEventGroup startSound;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioEventGroup visibleSound;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AudioEventGroup invisibleSound;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioEventGroup collisionSound;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioEventGroup collisionExitSound;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioEventGroup triggerSound;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AudioEventGroup triggerExitSound;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioEventGroup triggerStaySound;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AudioEventGroup mouseEnterSound;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AudioEventGroup mouseExitSound;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AudioEventGroup mouseClickSound;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public AudioEventGroup mouseUpSound;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public AudioEventGroup mouseDragSound;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AudioEventGroup spawnedSound;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public AudioEventGroup despawnedSound;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AudioEventGroup enableSound;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public AudioEventGroup disableSound;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public AudioEventGroup collision2dSound;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public AudioEventGroup collisionExit2dSound;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public AudioEventGroup triggerEnter2dSound;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AudioEventGroup triggerStay2dSound;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AudioEventGroup triggerExit2dSound;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AudioEventGroup particleCollisionSound;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public AudioEventGroup nguiOnClickSound;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public AudioEventGroup nguiMouseDownSound;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public AudioEventGroup nguiMouseUpSound;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public AudioEventGroup nguiMouseEnterSound;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public AudioEventGroup nguiMouseExitSound;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public AudioEventGroup unitySliderChangedSound;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public AudioEventGroup unityButtonClickedSound;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public AudioEventGroup unityPointerDownSound;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public AudioEventGroup unityDragSound;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public AudioEventGroup unityPointerUpSound;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public AudioEventGroup unityPointerEnterSound;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public AudioEventGroup unityPointerExitSound;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public AudioEventGroup unityDropSound;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public AudioEventGroup unityScrollSound;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public AudioEventGroup unityUpdateSelectedSound;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public AudioEventGroup unitySelectSound;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public AudioEventGroup unityDeselectSound;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public AudioEventGroup unityMoveSound;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public AudioEventGroup unityInitializePotentialDragSound;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public AudioEventGroup unityBeginDragSound;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public AudioEventGroup unityEndDragSound;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public AudioEventGroup unitySubmitSound;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public AudioEventGroup unityCancelSound;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public AudioEventGroup unityToggleSound;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public List<AudioEventGroup> userDefinedSounds;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public List<AudioEventGroup> mechanimStateChangedSounds;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public bool useStartSound;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B9")]
		public bool useVisibleSound;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BA")]
		public bool useInvisibleSound;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BB")]
		public bool useCollisionSound;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
		public bool useCollisionExitSound;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BD")]
		public bool useTriggerEnterSound;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BE")]
		public bool useTriggerExitSound;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1BF")]
		public bool useTriggerStaySound;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public bool useMouseEnterSound;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
		public bool useMouseExitSound;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C2")]
		public bool useMouseClickSound;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C3")]
		public bool useMouseUpSound;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		public bool useMouseDragSound;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C5")]
		public bool useSpawnedSound;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C6")]
		public bool useDespawnedSound;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C7")]
		public bool useEnableSound;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public bool useDisableSound;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		public bool useCollision2dSound;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		public bool useCollisionExit2dSound;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CB")]
		public bool useTriggerEnter2dSound;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		public bool useTriggerStay2dSound;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CD")]
		public bool useTriggerExit2dSound;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CE")]
		public bool useParticleCollisionSound;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CF")]
		public bool useNguiOnClickSound;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public bool useNguiMouseDownSound;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D1")]
		public bool useNguiMouseUpSound;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D2")]
		public bool useNguiMouseEnterSound;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D3")]
		public bool useNguiMouseExitSound;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		public bool useUnitySliderChangedSound;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D5")]
		public bool useUnityButtonClickedSound;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D6")]
		public bool useUnityPointerDownSound;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D7")]
		public bool useUnityDragSound;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public bool useUnityPointerUpSound;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		public bool useUnityPointerEnterSound;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DA")]
		public bool useUnityPointerExitSound;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DB")]
		public bool useUnityDropSound;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public bool useUnityScrollSound;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DD")]
		public bool useUnityUpdateSelectedSound;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DE")]
		public bool useUnitySelectSound;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DF")]
		public bool useUnityDeselectSound;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool useUnityMoveSound;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
		public bool useUnityInitializePotentialDragSound;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
		public bool useUnityBeginDragSound;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E3")]
		public bool useUnityEndDragSound;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public bool useUnitySubmitSound;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		public bool useUnityCancelSound;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E6")]
		public bool useUnityToggleSound;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Slider _slider;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Toggle _toggle;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Button _button;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private bool _isVisible;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x201")]
		private bool _needsCoroutine;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private float? _triggerEnterTime;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private float? _triggerEnter2dTime;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _trans;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<AudioEventGroup> _validMechanimStateChangedSounds;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private Animator _anim;

		[Token(Token = "0x17000037")]
		private bool IsSetToUGUI
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x6CBD8C", Offset = "0x6CBD8C", VA = "0x6CBD8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000038")]
		private bool IsSetToLegacyUI
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x6CD6FC", Offset = "0x6CD6FC", VA = "0x6CD6FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x6CBC64", Offset = "0x6CBC64", VA = "0x6CBC64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x6CC008", Offset = "0x6CC008", VA = "0x6CC008", Slot = "10")]
		protected virtual void SpawnedOrAwake()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x6CC168", Offset = "0x6CC168", VA = "0x6CC168")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CA00", Offset = "0x44CA00")]
		private IEnumerator CoUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x6CC1E0", Offset = "0x6CC1E0", VA = "0x6CC1E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x6CC898", Offset = "0x6CC898", VA = "0x6CC898")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x6CC8C0", Offset = "0x6CC8C0", VA = "0x6CC8C0")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x6CC8DC", Offset = "0x6CC8DC", VA = "0x6CC8DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x6CCB98", Offset = "0x6CCB98", VA = "0x6CCB98")]
		private void RestorePersistentSliders()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x6CCF28", Offset = "0x6CCF28", VA = "0x6CCF28")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x6CD374", Offset = "0x6CD374", VA = "0x6CD374")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x6CD490", Offset = "0x6CD490", VA = "0x6CD490")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x6CD4B0", Offset = "0x6CD4B0", VA = "0x6CD4B0")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x6CD4D0", Offset = "0x6CD4D0", VA = "0x6CD4D0")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x6CD4F0", Offset = "0x6CD4F0", VA = "0x6CD4F0")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x6CD510", Offset = "0x6CD510", VA = "0x6CD510")]
		private void OnDrag(Vector2 delta)
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x6CD514", Offset = "0x6CD514", VA = "0x6CD514")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x6CD534", Offset = "0x6CD534", VA = "0x6CD534")]
		private void OnDrop(GameObject go)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x6CD538", Offset = "0x6CD538", VA = "0x6CD538")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x6CD558", Offset = "0x6CD558", VA = "0x6CD558")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x6CD578", Offset = "0x6CD578", VA = "0x6CD578")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x6CD598", Offset = "0x6CD598", VA = "0x6CD598")]
		private void OnSelect(bool isSelected)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x6CD59C", Offset = "0x6CD59C", VA = "0x6CD59C")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x6CD5BC", Offset = "0x6CD5BC", VA = "0x6CD5BC")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x6CD5DC", Offset = "0x6CD5DC", VA = "0x6CD5DC")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x6CD5FC", Offset = "0x6CD5FC", VA = "0x6CD5FC")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x6CD61C", Offset = "0x6CD61C", VA = "0x6CD61C")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x6CD63C", Offset = "0x6CD63C", VA = "0x6CD63C")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x6CD65C", Offset = "0x6CD65C", VA = "0x6CD65C")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x6CD67C", Offset = "0x6CD67C", VA = "0x6CD67C")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x6CD69C", Offset = "0x6CD69C", VA = "0x6CD69C")]
		private void SliderChanged(float newValue)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x6CD6CC", Offset = "0x6CD6CC", VA = "0x6CD6CC")]
		private void ToggleChanged(bool newValue)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x6CD6E4", Offset = "0x6CD6E4", VA = "0x6CD6E4")]
		private void ButtonClicked()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x6CD70C", Offset = "0x6CD70C", VA = "0x6CD70C")]
		private void OnPress(bool isDown)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x6CD744", Offset = "0x6CD744", VA = "0x6CD744")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x6CD764", Offset = "0x6CD764", VA = "0x6CD764")]
		private void OnHover(bool isOver)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x6CD79C", Offset = "0x6CD79C", VA = "0x6CD79C")]
		private void OnSpawned()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x6CD7EC", Offset = "0x6CD7EC", VA = "0x6CD7EC")]
		private void OnDespawned()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x6CD80C", Offset = "0x6CD80C", VA = "0x6CD80C")]
		public void CalculateRadius(AudioEvent anEvent)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x6CD8B4", Offset = "0x6CD8B4", VA = "0x6CD8B4")]
		public AudioSource GetNamedOrFirstAudioSource(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x6CDAA0", Offset = "0x6CDAA0", VA = "0x6CDAA0")]
		public List<AudioSource> GetAllVariationAudioSources(AudioEvent anEvent)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x6CDCD4", Offset = "0x6CDCD4", VA = "0x6CDCD4")]
		public AudioEventGroup GetMechanimAudioEventGroup(string stateName)
		{
			return null;
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x6CC630", Offset = "0x6CC630", VA = "0x6CC630")]
		public bool PlaySounds(AudioEventGroup eventGrp, EventType eType)
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x6D0440", Offset = "0x6D0440", VA = "0x6D0440")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x6D0638", Offset = "0x6D0638", VA = "0x6D0638")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x6CDDD0", Offset = "0x6CDDD0", VA = "0x6CDDD0")]
		private static bool CheckForRetriggerLimit(AudioEventGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x6CDE68", Offset = "0x6CDE68", VA = "0x6CDE68")]
		private void PerformSingleAction(AudioEventGroup grp, AudioEvent aEvent, EventType eType)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x6D0830", Offset = "0x6D0830", VA = "0x6D0830")]
		private void LogIfCustomEventMissing(AudioEventGroup eventGroup)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x6CC220", Offset = "0x6CC220", VA = "0x6CC220", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x6D0B38", Offset = "0x6D0B38", VA = "0x6D0B38", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x6D0C14", Offset = "0x6D0C14", VA = "0x6D0C14", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x6CCE8C", Offset = "0x6CCE8C", VA = "0x6CCE8C", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x6CD2E0", Offset = "0x6CD2E0", VA = "0x6CD2E0", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x6D0CEC", Offset = "0x6D0CEC", VA = "0x6D0CEC", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x6CBD9C", Offset = "0x6CBD9C", VA = "0x6CBD9C")]
		private void AddUGUIComponents()
		{
		}

		[Token(Token = "0x6000238")]
		private void AddUGUIHandler<T>(bool useSound) where T : EventSoundsUGUIHandler
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x6D0D40", Offset = "0x6D0D40", VA = "0x6D0D40")]
		public EventSounds()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class EventSoundsUGUIHandler : MonoBehaviour
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B5F4", Offset = "0x44B5F4")]
		private EventSounds <eventSounds>k__BackingField;

		[Token(Token = "0x1700003B")]
		public EventSounds eventSounds
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x6D1CE8", Offset = "0x6D1CE8", VA = "0x6D1CE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CAB0", Offset = "0x44CAB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x6D1CF0", Offset = "0x6D1CF0", VA = "0x6D1CF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CAC0", Offset = "0x44CAC0")]
			set
			{
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x6D1378", Offset = "0x6D1378", VA = "0x6D1378")]
		public EventSoundsUGUIHandler()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class EventSoundsPointerEnterHandler : EventSoundsUGUIHandler, IPointerEnterHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x6D18E0", Offset = "0x6D18E0", VA = "0x6D18E0", Slot = "4")]
		public void OnPointerEnter(PointerEventData data)
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x6D1984", Offset = "0x6D1984", VA = "0x6D1984")]
		public EventSoundsPointerEnterHandler()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class EventSoundsPointerExitHandler : EventSoundsUGUIHandler, IPointerExitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x6D198C", Offset = "0x6D198C", VA = "0x6D198C", Slot = "4")]
		public void OnPointerExit(PointerEventData data)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x6D1A30", Offset = "0x6D1A30", VA = "0x6D1A30")]
		public EventSoundsPointerExitHandler()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class EventSoundsPointerDownHandler : EventSoundsUGUIHandler, IPointerDownHandler, IEventSystemHandler
	{
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x6D1834", Offset = "0x6D1834", VA = "0x6D1834", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x6D18D8", Offset = "0x6D18D8", VA = "0x6D18D8")]
		public EventSoundsPointerDownHandler()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class EventSoundsPointerUpHandler : EventSoundsUGUIHandler, IPointerUpHandler, IEventSystemHandler
	{
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x6D1A38", Offset = "0x6D1A38", VA = "0x6D1A38", Slot = "4")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x6D1ADC", Offset = "0x6D1ADC", VA = "0x6D1ADC")]
		public EventSoundsPointerUpHandler()
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class EventSoundsDragHandler : EventSoundsUGUIHandler, IDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x6D14D8", Offset = "0x6D14D8", VA = "0x6D14D8", Slot = "4")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x6D157C", Offset = "0x6D157C", VA = "0x6D157C")]
		public EventSoundsDragHandler()
		{
		}
	}
	[Token(Token = "0x2000081")]
	public class EventSoundsDropHandler : EventSoundsUGUIHandler, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x6D1584", Offset = "0x6D1584", VA = "0x6D1584", Slot = "4")]
		public void OnDrop(PointerEventData data)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x6D1628", Offset = "0x6D1628", VA = "0x6D1628")]
		public EventSoundsDropHandler()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class EventSoundsScrollHandler : EventSoundsUGUIHandler, IScrollHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x6D1AE4", Offset = "0x6D1AE4", VA = "0x6D1AE4", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x6D1B88", Offset = "0x6D1B88", VA = "0x6D1B88")]
		public EventSoundsScrollHandler()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class EventSoundsUpdateSelectedHandler : EventSoundsUGUIHandler, IUpdateSelectedHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x6D1CF8", Offset = "0x6D1CF8", VA = "0x6D1CF8", Slot = "4")]
		public void OnUpdateSelected(BaseEventData data)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x6D1D9C", Offset = "0x6D1D9C", VA = "0x6D1D9C")]
		public EventSoundsUpdateSelectedHandler()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class EventSoundsSelectHandler : EventSoundsUGUIHandler, ISelectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x6D1B90", Offset = "0x6D1B90", VA = "0x6D1B90", Slot = "4")]
		public void OnSelect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x6D1C34", Offset = "0x6D1C34", VA = "0x6D1C34")]
		public EventSoundsSelectHandler()
		{
		}
	}
	[Token(Token = "0x2000085")]
	public class EventSoundsDeselectHandler : EventSoundsUGUIHandler, IDeselectHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x6D142C", Offset = "0x6D142C", VA = "0x6D142C", Slot = "4")]
		public void OnDeselect(BaseEventData data)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x6D14D0", Offset = "0x6D14D0", VA = "0x6D14D0")]
		public EventSoundsDeselectHandler()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public class EventSoundsMoveHandler : EventSoundsUGUIHandler, IMoveHandler, IEventSystemHandler
	{
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x6D1788", Offset = "0x6D1788", VA = "0x6D1788", Slot = "4")]
		public void OnMove(AxisEventData data)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x6D182C", Offset = "0x6D182C", VA = "0x6D182C")]
		public EventSoundsMoveHandler()
		{
		}
	}
	[Token(Token = "0x2000087")]
	public class EventSoundsInitializePotentialDragHandler : EventSoundsUGUIHandler, IInitializePotentialDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x6D16DC", Offset = "0x6D16DC", VA = "0x6D16DC", Slot = "4")]
		public void OnInitializePotentialDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x6D1780", Offset = "0x6D1780", VA = "0x6D1780")]
		public EventSoundsInitializePotentialDragHandler()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class EventSoundsBeginDragHandler : EventSoundsUGUIHandler, IBeginDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x6D12CC", Offset = "0x6D12CC", VA = "0x6D12CC", Slot = "4")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x6D1370", Offset = "0x6D1370", VA = "0x6D1370")]
		public EventSoundsBeginDragHandler()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class EventSoundsEndDragHandler : EventSoundsUGUIHandler, IEndDragHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x6D1630", Offset = "0x6D1630", VA = "0x6D1630", Slot = "4")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x6D16D4", Offset = "0x6D16D4", VA = "0x6D16D4")]
		public EventSoundsEndDragHandler()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class EventSoundsSubmitHandler : EventSoundsUGUIHandler, ISubmitHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x6D1C3C", Offset = "0x6D1C3C", VA = "0x6D1C3C", Slot = "4")]
		public void OnSubmit(BaseEventData data)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x6D1CE0", Offset = "0x6D1CE0", VA = "0x6D1CE0")]
		public EventSoundsSubmitHandler()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class EventSoundsCancelHandler : EventSoundsUGUIHandler, ICancelHandler, IEventSystemHandler
	{
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x6D1380", Offset = "0x6D1380", VA = "0x6D1380", Slot = "4")]
		public void OnCancel(BaseEventData data)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x6D1424", Offset = "0x6D1424", VA = "0x6D1424")]
		public EventSoundsCancelHandler()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x44AC98", Offset = "0x44AC98")]
	public class FootstepSounds : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		public enum FootstepTriggerMode
		{
			[Token(Token = "0x40002DE")]
			None,
			[Token(Token = "0x40002DF")]
			OnCollision,
			[Token(Token = "0x40002E0")]
			OnTriggerEnter,
			[Token(Token = "0x40002E1")]
			OnCollision2D,
			[Token(Token = "0x40002E2")]
			OnTriggerEnter2D
		}

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.SoundSpawnLocationMode soundSpawnMode;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public FootstepTriggerMode footstepEvent;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<FootstepGroup> footstepGroups;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int limitPerXFrm;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float limitPerXSec;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int triggeredLastFrame;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float triggeredLastTime;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform _trans;

		[Token(Token = "0x1700003C")]
		private Transform Trans
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x5D6634", Offset = "0x5D6634", VA = "0x5D6634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x5D6278", Offset = "0x5D6278", VA = "0x5D6278")]
		private bool CheckForRetriggerLimit()
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x5D6308", Offset = "0x5D6308", VA = "0x5D6308")]
		private void PlaySoundsIfMatch(GameObject go)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x5D6D10", Offset = "0x5D6D10", VA = "0x5D6D10")]
		public FootstepSounds()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class MechanimStateCustomEvents : StateMachineBehaviour
	{
		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B604", Offset = "0x44B604")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B604", Offset = "0x44B604")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B664", Offset = "0x44B664")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B664", Offset = "0x44B664")]
		public bool fireEnterEvent;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[MasterCustomEvent]
		public string enterCustomEvent;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B6D4", Offset = "0x44B6D4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B6D4", Offset = "0x44B6D4")]
		public bool fireExitEvent;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[MasterCustomEvent]
		public string exitCustomEvent;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B744", Offset = "0x44B744")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B744", Offset = "0x44B744")]
		public bool fireAnimTimeEvent;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B7A4", Offset = "0x44B7A4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B7A4", Offset = "0x44B7A4")]
		public float whenToFireEvent;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[MasterCustomEvent]
		public string timedCustomEvent;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B808", Offset = "0x44B808")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B808", Offset = "0x44B808")]
		public bool fireMultiAnimTimeEvent;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B868", Offset = "0x44B868")]
		public int numOfMultiEventsToFire;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B880", Offset = "0x44B880")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B880", Offset = "0x44B880")]
		public float whenToFireMultiEvent1;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B8D4", Offset = "0x44B8D4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B8D4", Offset = "0x44B8D4")]
		public float whenToFireMultiEvent2;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B928", Offset = "0x44B928")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B928", Offset = "0x44B928")]
		public float whenToFireMultiEvent3;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44B97C", Offset = "0x44B97C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44B97C", Offset = "0x44B97C")]
		public float whenToFireMultiEvent4;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[MasterCustomEvent]
		public string MultiTimedEvent;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _playMultiEvent1;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _playMultiEvent2;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool _playMultiEvent3;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool _playMultiEvent4;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fireTimedEvent;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform _actorTrans;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _lastRepetition;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0xAA3708", Offset = "0xAA3708", VA = "0xAA3708", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0xAA38A0", Offset = "0xAA38A0", VA = "0xAA38A0", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0xAA3BC8", Offset = "0xAA3BC8", VA = "0xAA3BC8", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0xAA37F8", Offset = "0xAA37F8", VA = "0xAA37F8")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0xAA3CA8", Offset = "0xAA3CA8", VA = "0xAA3CA8")]
		public MechanimStateCustomEvents()
		{
		}
	}
	[Token(Token = "0x200008F")]
	public class MechanimStateSounds : StateMachineBehaviour
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44B9E0", Offset = "0x44B9E0")]
		public bool SoundFollowsObject;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BA18", Offset = "0x44BA18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44BA18", Offset = "0x44BA18")]
		public bool RetriggerWhenStateLoops;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BA78", Offset = "0x44BA78")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44BA78", Offset = "0x44BA78")]
		public bool playEnterSound;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool stopEnterSoundOnExit;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SoundGroup]
		public string enterSoundGroup;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BAE8", Offset = "0x44BAE8")]
		public string enterVariationName;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool wasEnterSoundPlayed;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BB20", Offset = "0x44BB20")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44BB20", Offset = "0x44BB20")]
		public bool playExitSound;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SoundGroup]
		public string exitSoundGroup;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BB90", Offset = "0x44BB90")]
		public string exitVariationName;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44BBC8", Offset = "0x44BBC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BBC8", Offset = "0x44BBC8")]
		public bool playAnimTimeSound;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool stopAnimTimeSoundOnExit;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BC28", Offset = "0x44BC28")]
		public bool useStopTime;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BC60", Offset = "0x44BC60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BC60", Offset = "0x44BC60")]
		public float whenToStartSound;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BCB4", Offset = "0x44BCB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BCB4", Offset = "0x44BCB4")]
		public float whenToStopSound;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SoundGroup]
		public string TimedSoundGroup;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BD18", Offset = "0x44BD18")]
		public string timedVariationName;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool playSoundStart;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool playSoundStop;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x44BD50", Offset = "0x44BD50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BD50", Offset = "0x44BD50")]
		public bool playMultiAnimTimeSounds;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool StopMultiAnimTimeSoundsOnExit;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BDB0", Offset = "0x44BDB0")]
		public int numOfMultiSoundsToPlay;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BDC8", Offset = "0x44BDC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BDC8", Offset = "0x44BDC8")]
		public float whenToStartMultiSound1;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BE1C", Offset = "0x44BE1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BE1C", Offset = "0x44BE1C")]
		public float whenToStartMultiSound2;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BE70", Offset = "0x44BE70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BE70", Offset = "0x44BE70")]
		public float whenToStartMultiSound3;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BEC4", Offset = "0x44BEC4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BEC4", Offset = "0x44BEC4")]
		public float whenToStartMultiSound4;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SoundGroup]
		public string MultiSoundsTimedGroup;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x44BF28", Offset = "0x44BF28")]
		public string multiTimedVariationName;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool playMultiSound1;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool playMultiSound2;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool playMultiSound3;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x93")]
		private bool playMultiSound4;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform _actorTrans;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int _lastRepetition;

		[Token(Token = "0x600026F")]
		[Address(RVA = "0xAA3D4C", Offset = "0xAA3D4C", VA = "0xAA3D4C", Slot = "4")]
		public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0xAA3FD4", Offset = "0xAA3FD4", VA = "0xAA3FD4", Slot = "5")]
		public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0xAA478C", Offset = "0xAA478C", VA = "0xAA478C", Slot = "6")]
		public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0xAA3ED4", Offset = "0xAA3ED4", VA = "0xAA3ED4")]
		private Transform ActorTrans(Animator anim)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0xAA3F7C", Offset = "0xAA3F7C", VA = "0xAA3F7C")]
		private static string GetVariationName(string varName)
		{
			return null;
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0xAA49D4", Offset = "0xAA49D4", VA = "0xAA49D4")]
		public MechanimStateSounds()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[SerializeField]
	public class PlaySoundResult
	{
		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BF60", Offset = "0x44BF60")]
		private bool <SoundPlayed>k__BackingField;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BF70", Offset = "0x44BF70")]
		private bool <SoundScheduled>k__BackingField;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BF80", Offset = "0x44BF80")]
		private SoundGroupVariation <ActingVariation>k__BackingField;

		[Token(Token = "0x1700003D")]
		public bool SoundPlayed
		{
			[Token(Token = "0x6000276")]
			[Address(RVA = "0xAA976C", Offset = "0xAA976C", VA = "0xAA976C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CAD0", Offset = "0x44CAD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000277")]
			[Address(RVA = "0xAA9774", Offset = "0xAA9774", VA = "0xAA9774")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CAE0", Offset = "0x44CAE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool SoundScheduled
		{
			[Token(Token = "0x6000278")]
			[Address(RVA = "0xAA9780", Offset = "0xAA9780", VA = "0xAA9780")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CAF0", Offset = "0x44CAF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000279")]
			[Address(RVA = "0xAA9788", Offset = "0xAA9788", VA = "0xAA9788")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB00", Offset = "0x44CB00")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public SoundGroupVariation ActingVariation
		{
			[Token(Token = "0x600027A")]
			[Address(RVA = "0xAA9794", Offset = "0xAA9794", VA = "0xAA9794")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB10", Offset = "0x44CB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600027B")]
			[Address(RVA = "0xAA979C", Offset = "0xAA979C", VA = "0xAA979C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB20", Offset = "0x44CB20")]
			set
			{
			}
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0xAA9738", Offset = "0xAA9738", VA = "0xAA9738")]
		public PlaySoundResult()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000091")]
	public class AmbientSoundToTriggerInfo
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int frameToTrigger;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AmbientSound ambient;

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x6C1088", Offset = "0x6C1088", VA = "0x6C1088")]
		public AmbientSoundToTriggerInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class AudioEvent
	{
		[Token(Token = "0x2000093")]
		public enum TargetVolumeMode
		{
			[Token(Token = "0x4000349")]
			UseSliderValue,
			[Token(Token = "0x400034A")]
			UseSpecificValue
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class MA_SnapshotInfo
		{
			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixerSnapshot snapshot;

			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float weight;

			[Token(Token = "0x600027F")]
			[Address(RVA = "0x9DFD34", Offset = "0x9DFD34", VA = "0x9DFD34")]
			public MA_SnapshotInfo(AudioMixerSnapshot snap, float wt)
			{
			}
		}

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string actionName;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isExpanded;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string soundType;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allPlaylistControllersForGroupCmd;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool allSoundTypesForGroupCmd;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool allSoundTypesForBusCmd;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float volume;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useFixedPitch;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float pitch;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public EventSounds.GlidePitchType glidePitchType;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float targetGlidePitch;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pitchGlideTime;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float delaySound;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudio.EventSoundFunctionType currentSoundFunctionType;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public MasterAudio.PlaylistCommand currentPlaylistCommand;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public MasterAudio.SoundGroupCommand currentSoundGroupCommand;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MasterAudio.BusCommand currentBusCommand;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MasterAudio.CustomEventCommand currentCustomEventCommand;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public MasterAudio.GlobalCommand currentGlobalCommand;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public MasterAudio.UnityMixerCommand currentMixerCommand;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioMixerSnapshot snapshotToTransitionTo;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float snapshotTransitionTime;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<MA_SnapshotInfo> snapshotsToBlend;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MasterAudio.PersistentSettingsCommand currentPersistentSettingsCommand;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string busName;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string playlistName;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string playlistControllerName;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool startPlaylist;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float fadeVolume;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float fadeTime;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float minAge;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool stopAfterFade;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool restoreVolumeAfterFade;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public TargetVolumeMode targetVolMode;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public string clipName;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public string variationName;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float colliderMaxDistance;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public bool showSphereGizmo;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public string theCustomEventName;

		[Token(Token = "0x17000040")]
		public bool IsFadeCommand
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0x6C1EE0", Offset = "0x6C1EE0", VA = "0x6C1EE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x6C1F48", Offset = "0x6C1F48", VA = "0x6C1F48")]
		public AudioEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000095")]
	public class AudioEventGroup
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool allPlayersShouldHear;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useLayerFilter;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool useTagFilter;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool customSoundActive;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool isCustomEvent;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string customEventName;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool mechanimEventActive;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool isMechanimStateCheckEvent;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mechanimStateName;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mechEventPlayedForState;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<AudioEvent> SoundEvents;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public EventSounds.PreviousSoundStopMode mouseDragStopMode;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float mouseDragFadeOutTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public EventSounds.RetriggerLimMode retriggerLimitMode;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int limitPerXFrm;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float limitPerXSec;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int triggeredLastFrame;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float triggeredLastTime;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float triggerStayForTime;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool doesTriggerStayRepeat;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float sliderValue;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x6C2154", Offset = "0x6C2154", VA = "0x6C2154")]
		public AudioEventGroup()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class AudioScriptOrder : Attribute
	{
		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Order;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x6C42E8", Offset = "0x6C42E8", VA = "0x6C42E8")]
		public AudioScriptOrder(int order)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class BusFadeInfo
	{
		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GroupBus ActingBus;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartVolume;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TargetVolume;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float StartTime;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float CompletionTime;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool IsActive;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool WillStopGroupAfterFade;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool WillResetVolumeAfterFade;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action completionAction;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x6C6E94", Offset = "0x6C6E94", VA = "0x6C6E94")]
		public BusFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class BusPitchGlideInfo
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string NameOfBus;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float CompletionTime;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool IsActive;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<SoundGroupVariation> GlidingVariations;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action completionAction;

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x6C6EA4", Offset = "0x6C6EA4", VA = "0x6C6EA4")]
		public BusPitchGlideInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class CustomEvent
	{
		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string EventName;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ProspectiveName;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsEditing;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool eventExpanded;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MasterAudio.CustomEventReceiveMode eventReceiveMode;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float distanceThreshold;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudio.EventReceiveFilter eventRcvFilterMode;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int filterModeQty;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool isTemporary;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int frameLastFired;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string categoryName;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x6C8A74", Offset = "0x6C8A74", VA = "0x6C8A74")]
		public CustomEvent(string eventName)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class CustomEventCategory
	{
		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string CatName;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsExpanded;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool IsEditing;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool IsTemporary;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x6C8B18", Offset = "0x6C8B18", VA = "0x6C8B18")]
		public CustomEventCategory()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class CustomEventToFireInfo
	{
		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string eventName;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform eventOrigin;

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x6C8B8C", Offset = "0x6C8B8C", VA = "0x6C8B8C")]
		public CustomEventToFireInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class DuckGroupInfo
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string soundType;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float riseVolStart;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float unduckTime;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float duckedVolumeCut;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool isTemporary;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x6C9404", Offset = "0x6C9404", VA = "0x6C9404")]
		public DuckGroupInfo()
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class DynamicGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BF90", Offset = "0x44BF90")]
		public int probabilityToPlay;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool useLocalization;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool useRandomPitch;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SoundGroupVariation.RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float randomPitchMin;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMax;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool useRandomVolume;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public SoundGroupVariation.RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float randomVolumeMin;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMax;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int weight;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool isExpanded;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool isChecked;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool useFades;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float fadeInTime;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float fadeOutTime;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public bool useCustomLooping;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int minCustomLoops;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxCustomLoops;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useIntroSilence;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float introSilenceMin;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float introSilenceMax;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool useRandomStartTime;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMinPercent;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float randomEndPercent;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private DynamicSoundGroup _parentGroupScript;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioSource _aud;

		[Token(Token = "0x17000041")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x6C9474", Offset = "0x6C9474", VA = "0x6C9474")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x6C9528", Offset = "0x6C9528", VA = "0x6C9528")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x6C95DC", Offset = "0x6C95DC", VA = "0x6C95DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x6C9690", Offset = "0x6C9690", VA = "0x6C9690")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x600028C")]
			[Address(RVA = "0x6C9744", Offset = "0x6C9744", VA = "0x6C9744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x600028D")]
			[Address(RVA = "0x6C97F8", Offset = "0x6C97F8", VA = "0x6C97F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public DynamicSoundGroup ParentGroup
		{
			[Token(Token = "0x600028E")]
			[Address(RVA = "0x6C98AC", Offset = "0x6C98AC", VA = "0x6C98AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public Transform Trans
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0x6C9A34", Offset = "0x6C9A34", VA = "0x6C9A34")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x6C9AD4", Offset = "0x6C9AD4", VA = "0x6C9AD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x6C9D28", Offset = "0x6C9D28", VA = "0x6C9D28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x6C9DDC", Offset = "0x6C9DDC", VA = "0x6C9DDC")]
		public DynamicGroupVariation()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class DynamicSoundGroup : MonoBehaviour
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject variationTemplate;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float groupMasterVolume;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int retriggerPercentage;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public MasterAudioGroup.VariationSequence curVariationSequence;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudioGroup.VariationMode curVariationMode;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float chainLoopDelayMin;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float chainLoopDelayMax;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public MasterAudioGroup.ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int chainLoopNumLoops;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool useDialogFadeOut;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float dialogFadeOutTime;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string comments;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool logSound;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int busIndex;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float spatialBlend;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string busName;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool isExistingBus;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool isCopiedFromDGSC;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public MasterAudioGroup.LimitMode limitMode;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public int limitPerXFrames;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float minimumTimeBetween;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool limitPolyphony;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int voiceLimitCount;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public MasterAudioGroup.TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float despawnFadeTime;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool copySettingsExpanded;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
		public bool expandLinkedGroups;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public List<string> childSoundGroups;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public List<DynamicGroupVariation> groupVariations;

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x6CA038", Offset = "0x6CA038", VA = "0x6CA038")]
		public DynamicSoundGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009F")]
	public class FootstepGroup
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isExpanded;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool useLayerFilter;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool useTagFilter;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<int> matchingLayers;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<string> matchingTags;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string soundType;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EventSounds.VariationType variationType;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string variationName;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float volume;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useFixedPitch;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float pitch;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float delaySound;

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5D60D4", Offset = "0x5D60D4", VA = "0x5D60D4")]
		public FootstepGroup()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A0")]
	public class GroupBus
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string busName;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float volume;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isSoloed;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool isMuted;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int voiceLimit;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool stopOldest;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExisting;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool isTemporary;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool isUsingOcclusion;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color busColor;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool forceTo2D;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly List<int> _activeAudioSourcesIds;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _originalVolume;

		[Token(Token = "0x1700004B")]
		public int ActiveVoices
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x5D7444", Offset = "0x5D7444", VA = "0x5D7444")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		public bool BusVoiceLimitReached
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x5D7490", Offset = "0x5D7490", VA = "0x5D7490")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x5D74F8", Offset = "0x5D74F8", VA = "0x5D74F8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x5D7500", Offset = "0x5D7500", VA = "0x5D7500")]
			set
			{
			}
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5D7340", Offset = "0x5D7340", VA = "0x5D7340")]
		public void AddActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x5D73E0", Offset = "0x5D73E0", VA = "0x5D73E0")]
		public void RemoveActiveAudioSourceId(int id)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x5D7508", Offset = "0x5D7508", VA = "0x5D7508")]
		public GroupBus()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A1")]
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

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x5D75BC", Offset = "0x5D75BC", VA = "0x5D75BC")]
		public GroupFadeInfo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000A2")]
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

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5D75CC", Offset = "0x5D75CC", VA = "0x5D75CC")]
		public GroupPitchGlideInfo()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public interface ICustomEventReceiver
	{
		[Token(Token = "0x600029E")]
		void CheckForIllegalCustomEvents();

		[Token(Token = "0x600029F")]
		void ReceiveEvent(string customEventName, Vector3 originPoint);

		[Token(Token = "0x60002A0")]
		bool SubscribesToEvent(string customEventName);

		[Token(Token = "0x60002A1")]
		void RegisterReceiver();

		[Token(Token = "0x60002A2")]
		void UnregisterReceiver();

		[Token(Token = "0x60002A3")]
		IList<AudioEventGroup> GetAllEvents();
	}
	[Token(Token = "0x20000A4")]
	public class MasterAudioGroup : MonoBehaviour
	{
		[Token(Token = "0x20000A5")]
		public enum TargetDespawnedBehavior
		{
			[Token(Token = "0x4000444")]
			None,
			[Token(Token = "0x4000445")]
			Stop,
			[Token(Token = "0x4000446")]
			FadeOut
		}

		[Token(Token = "0x20000A6")]
		public enum VariationSequence
		{
			[Token(Token = "0x4000448")]
			Randomized,
			[Token(Token = "0x4000449")]
			TopToBottom
		}

		[Token(Token = "0x20000A7")]
		public enum VariationMode
		{
			[Token(Token = "0x400044B")]
			Normal,
			[Token(Token = "0x400044C")]
			LoopedChain,
			[Token(Token = "0x400044D")]
			Dialog
		}

		[Token(Token = "0x20000A8")]
		public enum ChainedLoopLoopMode
		{
			[Token(Token = "0x400044F")]
			Endless,
			[Token(Token = "0x4000450")]
			NumberOfLoops
		}

		[Token(Token = "0x20000A9")]
		public enum LimitMode
		{
			[Token(Token = "0x4000452")]
			None,
			[Token(Token = "0x4000453")]
			FrameBased,
			[Token(Token = "0x4000454")]
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
		public bool isSelected;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool isExpanded;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float groupMasterVolume;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int retriggerPercentage;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VariationMode curVariationMode;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool alwaysHighestPriority;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float chainLoopDelayMin;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float chainLoopDelayMax;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChainedLoopLoopMode chainLoopMode;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int chainLoopNumLoops;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool useDialogFadeOut;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float dialogFadeOutTime;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public VariationSequence curVariationSequence;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool useNoRepeatRefill;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool useInactivePeriodPoolRefill;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float inactivePeriodSeconds;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupVariation> groupVariations;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string comments;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool logSound;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		public bool copySettingsExpanded;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		public bool expandLinkedGroups;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<string> childSoundGroups;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<string> endLinkedGroups;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public MasterAudio.LinkedGroupSelectionType linkedStartGroupSelectionType;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public MasterAudio.LinkedGroupSelectionType linkedStopGroupSelectionType;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public LimitMode limitMode;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int limitPerXFrames;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float minimumTimeBetween;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public bool useClipAgePriority;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		public bool limitPolyphony;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public int voiceLimitCount;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public TargetDespawnedBehavior targetDespawnedBehavior;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float despawnFadeTime;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public bool isUsingOcclusion;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		public bool willOcclusionOverrideRaycastOffset;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public bool willOcclusionOverrideFrequencies;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public bool isSoloed;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		public bool isMuted;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCA")]
		public bool soundPlayedEventActive;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public string soundPlayedCustomEvent;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public bool willCleanUpDelegatesAfterStop;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public int frames;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<int> _activeAudioSourcesIds;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private string _objectName;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Transform _trans;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private float _originalVolume;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BFB8", Offset = "0x44BFB8")]
		private int <ChainLoopCount>k__BackingField;

		[Token(Token = "0x1700004E")]
		public float SpatialBlendForGroup
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0xAA3228", Offset = "0xAA3228", VA = "0xAA3228")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public int ActiveVoices
		{
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0xAA3314", Offset = "0xAA3314", VA = "0xAA3314")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000050")]
		public int TotalVoices
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0xAA3364", Offset = "0xAA3364", VA = "0xAA3364")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000051")]
		public bool WillCleanUpDelegatesAfterStop
		{
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0xAA3388", Offset = "0xAA3388", VA = "0xAA3388")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public GroupBus BusForGroup
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0xAA30AC", Offset = "0xAA30AC", VA = "0xAA30AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public float OriginalVolume
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0xAA3394", Offset = "0xAA3394", VA = "0xAA3394")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0xAA339C", Offset = "0xAA339C", VA = "0xAA339C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool LoggingEnabledForGroup
		{
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0xAA33A4", Offset = "0xAA33A4", VA = "0xAA33A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public int ChainLoopCount
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xAA3470", Offset = "0xAA3470", VA = "0xAA3470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB50", Offset = "0x44CB50")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xAA3478", Offset = "0xAA3478", VA = "0xAA3478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB60", Offset = "0x44CB60")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public string GameObjectName
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0xAA3480", Offset = "0xAA3480", VA = "0xAA3480")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public bool UsesNoRepeat
		{
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0xAA34D0", Offset = "0xAA34D0", VA = "0xAA34D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		private Transform Trans
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0xAA2F4C", Offset = "0xAA2F4C", VA = "0xAA2F4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private List<int> ActiveAudioSourceIds
		{
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0xAA2E94", Offset = "0xAA2E94", VA = "0xAA2E94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000001")]
		public event Action LastVariationFinishedPlay
		{
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0xAA2C38", Offset = "0xAA2C38", VA = "0xAA2C38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB30", Offset = "0x44CB30")]
			add
			{
			}
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0xAA2CD8", Offset = "0xAA2CD8", VA = "0xAA2CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB40", Offset = "0x44CB40")]
			remove
			{
			}
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xAA2D78", Offset = "0xAA2D78", VA = "0xAA2D78")]
		private void Start()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xAA2FEC", Offset = "0xAA2FEC", VA = "0xAA2FEC")]
		public void AddActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xAA3198", Offset = "0xAA3198", VA = "0xAA3198")]
		public void RemoveActiveAudioSourceId(int varInstanceId)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xAA341C", Offset = "0xAA341C", VA = "0xAA341C")]
		public void FireLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xAA3430", Offset = "0xAA3430", VA = "0xAA3430")]
		public void SubscribeToLastVariationFinishedPlay(Action finishedCallback)
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0xAA3464", Offset = "0xAA3464", VA = "0xAA3464")]
		public void UnsubscribeFromLastVariationFinishedPlay()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xAA3540", Offset = "0xAA3540", VA = "0xAA3540")]
		public MasterAudioGroup()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class MasterCustomEventAttribute : PropertyAttribute
	{
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xAA3700", Offset = "0xAA3700", VA = "0xAA3700")]
		public MasterCustomEventAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000AB")]
	public class MusicSetting
	{
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ACE0", Offset = "0x44ACE0")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataStringValue valToClone;

			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x9E3CA8", Offset = "0x9E3CA8", VA = "0x9E3CA8")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x9E3CB0", Offset = "0x9E3CB0", VA = "0x9E3CB0")]
			internal bool <Clone>b__0(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ACF0", Offset = "0x44ACF0")]
		private sealed class <>c__DisplayClass32_1
		{
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataFloatValue valToClone;

			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x9E3CDC", Offset = "0x9E3CDC", VA = "0x9E3CDC")]
			public <>c__DisplayClass32_1()
			{
			}

			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x9E3CE4", Offset = "0x9E3CE4", VA = "0x9E3CE4")]
			internal bool <Clone>b__1(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AD00", Offset = "0x44AD00")]
		private sealed class <>c__DisplayClass32_2
		{
			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataBoolValue valToClone;

			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x9E3D10", Offset = "0x9E3D10", VA = "0x9E3D10")]
			public <>c__DisplayClass32_2()
			{
			}

			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x9E3D18", Offset = "0x9E3D18", VA = "0x9E3D18")]
			internal bool <Clone>b__2(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000AF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AD10", Offset = "0x44AD10")]
		private sealed class <>c__DisplayClass32_3
		{
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SongMetadataIntValue valToClone;

			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x9E3D44", Offset = "0x9E3D44", VA = "0x9E3D44")]
			public <>c__DisplayClass32_3()
			{
			}

			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x9E3D4C", Offset = "0x9E3D4C", VA = "0x9E3D4C")]
			internal bool <Clone>b__3(SongMetadataProperty p)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string alias;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string songName;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string resourceFileName;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float volume;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float pitch;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isExpanded;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool isLoop;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		public bool isChecked;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<SongMetadataStringValue> metadataStringValues;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<SongMetadataBoolValue> metadataBoolValues;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SongMetadataIntValue> metadataIntValues;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SongMetadataFloatValue> metadataFloatValues;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool metadataExpanded;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public MasterAudio.CustomSongStartTimeMode songStartTimeMode;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float customStartTime;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float customStartTimeMax;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int lastKnownTimePoint;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public bool wasLastKnownTimePointSet;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public int songIndex;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool songStartedEventExpanded;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string songStartedCustomEvent;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string songChangedCustomEvent;

		[Token(Token = "0x1700005A")]
		public bool HasMetadataProperties
		{
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xAA5D6C", Offset = "0xAA5D6C", VA = "0xAA5D6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public int MetadataPropertyCount
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0xAA5D88", Offset = "0xAA5D88", VA = "0xAA5D88")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005C")]
		public float SongStartTime
		{
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0xAA5E28", Offset = "0xAA5E28", VA = "0xAA5E28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0xAA5B50", Offset = "0xAA5B50", VA = "0xAA5B50")]
		public MusicSetting()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0xAA5E54", Offset = "0xAA5E54", VA = "0xAA5E54")]
		public static MusicSetting Clone(MusicSetting mus, MasterAudio.Playlist aList)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20000B0")]
	public class OcclusionFreqChangeInfo
	{
		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SoundGroupVariation ActingVariation;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float StartFrequency;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float TargetFrequency;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float StartTime;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float CompletionTime;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsActive;

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xAA6814", Offset = "0xAA6814", VA = "0xAA6814")]
		public OcclusionFreqChangeInfo()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class PlaylistAttribute : PropertyAttribute
	{
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xAA97A4", Offset = "0xAA97A4", VA = "0xAA97A4")]
		public PlaylistAttribute()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B2")]
	public class SongMetadataBoolValue
	{
		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Value;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xAA65E0", Offset = "0xAA65E0", VA = "0xAA65E0")]
		public SongMetadataBoolValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B3")]
	public class SongMetadataFloatValue
	{
		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xAA659C", Offset = "0xAA659C", VA = "0xAA659C")]
		public SongMetadataFloatValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B4")]
	public class SongMetadataIntValue
	{
		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xAA6624", Offset = "0xAA6624", VA = "0xAA6624")]
		public SongMetadataIntValue(SongMetadataProperty prop)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class SongMetadataProperty
	{
		[Token(Token = "0x20000B6")]
		public enum MetadataPropertyType
		{
			[Token(Token = "0x4000486")]
			Boolean,
			[Token(Token = "0x4000487")]
			String,
			[Token(Token = "0x4000488")]
			Integer,
			[Token(Token = "0x4000489")]
			Float
		}

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MetadataPropertyType PropertyType;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string PropertyName;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ProspectiveName;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool IsEditing;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool PropertyExpanded;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool AllSongsMustContain;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool CanSongHaveMultiple;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xAB2754", Offset = "0xAB2754", VA = "0xAB2754")]
		public SongMetadataProperty(string propertyName, MetadataPropertyType propertyType, bool allSongsMustContain, bool canSongHaveMultiple)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B7")]
	public class SongMetadataStringValue
	{
		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Value;

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xAA6558", Offset = "0xAA6558", VA = "0xAA6558")]
		public SongMetadataStringValue(SongMetadataProperty prop)
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class SoundGroupAttribute : PropertyAttribute
	{
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xAB27D4", Offset = "0xAB27D4", VA = "0xAB27D4")]
		public SoundGroupAttribute()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44AD20", Offset = "0x44AD20")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44AD20", Offset = "0x44AD20")]
	public class SoundGroupVariation : MonoBehaviour
	{
		[Token(Token = "0x20000BA")]
		public delegate void SoundFinishedEventHandler();

		[Token(Token = "0x20000BB")]
		public delegate void SoundLoopedEventHandler(int loopNumberStarted);

		[Token(Token = "0x20000BC")]
		public class PlaySoundParams
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string SoundType;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float VolumePercentage;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float? Pitch;

			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double? TimeToSchedulePlay;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform SourceTrans;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool AttachToSource;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float DelaySoundTime;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public bool IsChainLoop;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
			public bool IsSingleSubscribedPlay;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float GroupCalcVolume;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public bool IsPlaying;

			[Token(Token = "0x6000328")]
			[Address(RVA = "0x9E587C", Offset = "0x9E587C", VA = "0x9E587C")]
			public PlaySoundParams(string soundType, float volPercent, float groupCalcVolume, float? pitch, Transform sourceTrans, bool attach, float delaySoundTime, double? timeToSchedulePlay, bool isChainLoop, bool isSingleSubscribedPlay)
			{
			}
		}

		[Token(Token = "0x20000BD")]
		public enum PitchMode
		{
			[Token(Token = "0x40004DC")]
			None,
			[Token(Token = "0x40004DD")]
			Gliding
		}

		[Token(Token = "0x20000BE")]
		public enum FadeMode
		{
			[Token(Token = "0x40004DF")]
			None,
			[Token(Token = "0x40004E0")]
			FadeInOut,
			[Token(Token = "0x40004E1")]
			FadeOutEarly,
			[Token(Token = "0x40004E2")]
			GradualFade
		}

		[Token(Token = "0x20000BF")]
		public enum RandomPitchMode
		{
			[Token(Token = "0x40004E4")]
			AddToClipPitch,
			[Token(Token = "0x40004E5")]
			IgnoreClipPitch
		}

		[Token(Token = "0x20000C0")]
		public enum RandomVolumeMode
		{
			[Token(Token = "0x40004E7")]
			AddToClipVolume,
			[Token(Token = "0x40004E8")]
			IgnoreClipVolume
		}

		[Token(Token = "0x20000C1")]
		public enum DetectEndMode
		{
			[Token(Token = "0x40004EA")]
			None,
			[Token(Token = "0x40004EB")]
			DetectEnd
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AD94", Offset = "0x44AD94")]
		private sealed class <WaitForLoadToUnloadClipAndDeactivate>d__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoundGroupVariation <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600032C")]
				[Address(RVA = "0x9E582C", Offset = "0x9E582C", VA = "0x9E582C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600032E")]
				[Address(RVA = "0x9E5874", Offset = "0x9E5874", VA = "0x9E5874", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000329")]
			[Address(RVA = "0x9E5724", Offset = "0x9E5724", VA = "0x9E5724")]
			[DebuggerHidden]
			public <WaitForLoadToUnloadClipAndDeactivate>d__106(int <>1__state)
			{
			}

			[Token(Token = "0x600032A")]
			[Address(RVA = "0x9E5750", Offset = "0x9E5750", VA = "0x9E5750", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600032B")]
			[Address(RVA = "0x9E5754", Offset = "0x9E5754", VA = "0x9E5754", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x9E5834", Offset = "0x9E5834", VA = "0x9E5834", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int weight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x44BFC8", Offset = "0x44BFC8")]
		public int probabilityToPlay;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool useLocalization;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool useRandomPitch;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public RandomPitchMode randomPitchMode;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float randomPitchMin;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float randomPitchMax;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool useRandomVolume;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RandomVolumeMode randomVolumeMode;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float randomVolumeMin;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float randomVolumeMax;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.AudioLocation audLocation;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string resourceFileName;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float original_pitch;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float original_volume;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool isExpanded;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool isChecked;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool useFades;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float fadeInTime;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float fadeOutTime;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool useCustomLooping;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int minCustomLoops;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int maxCustomLoops;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool useRandomStartTime;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float randomStartMinPercent;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float randomStartMaxPercent;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float randomEndPercent;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool useIntroSilence;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float introSilenceMin;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float introSilenceMax;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float fadeMaxVolume;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FadeMode curFadeMode;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public PitchMode curPitchMode;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DetectEndMode curDetectEndMode;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int frames;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource _audioSource;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly PlaySoundParams _playSndParam;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private AudioDistortionFilter _distFilter;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioEchoFilter _echoFilter;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioHighPassFilter _hpFilter;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private AudioLowPassFilter _lpFilter;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private AudioReverbFilter _reverbFilter;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioChorusFilter _chorusFilter;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float _maxVol;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private int _instanceId;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool? _audioLoops;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private int _maxLoops;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private SoundGroupVariationUpdater _varUpdater;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _previousSoundFinishedFrame;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private string _soundGroupName;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private MasterAudio.VariationLoadStatus _loadStatus;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool _isStopRequested;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10D")]
		private bool _isPaused;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10E")]
		private bool _isWarmingPlay;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Transform _trans;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject _go;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Transform _objectToFollow;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Transform _objectToTriggerFrom;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private MasterAudioGroup _parentGroupScript;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool _attachToSource;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private string _resFileName;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _hasStartedEndLinkedGroups;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Coroutine _loadResourceFileCoroutine;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Coroutine _loadAddressableCoroutine;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _isUnloadAddressableCoroutineRunning;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C000", Offset = "0x44C000")]
		private float <LastTimePlayed>k__BackingField;

		[Token(Token = "0x1700005D")]
		public AudioDistortionFilter DistortionFilter
		{
			[Token(Token = "0x60002F6")]
			[Address(RVA = "0xAB5F24", Offset = "0xAB5F24", VA = "0xAB5F24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005E")]
		public AudioReverbFilter ReverbFilter
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xAB5FD8", Offset = "0xAB5FD8", VA = "0xAB5FD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		public AudioChorusFilter ChorusFilter
		{
			[Token(Token = "0x60002F8")]
			[Address(RVA = "0xAB608C", Offset = "0xAB608C", VA = "0xAB608C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public AudioEchoFilter EchoFilter
		{
			[Token(Token = "0x60002F9")]
			[Address(RVA = "0xAB6140", Offset = "0xAB6140", VA = "0xAB6140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		public AudioLowPassFilter LowPassFilter
		{
			[Token(Token = "0x60002FA")]
			[Address(RVA = "0xAB61F4", Offset = "0xAB61F4", VA = "0xAB61F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xAB61FC", Offset = "0xAB61FC", VA = "0xAB61FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public AudioHighPassFilter HighPassFilter
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0xAB6204", Offset = "0xAB6204", VA = "0xAB6204")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		public Transform ObjectToFollow
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xAB62B8", Offset = "0xAB62B8", VA = "0xAB62B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0xAB62C0", Offset = "0xAB62C0", VA = "0xAB62C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Transform ObjectToTriggerFrom
		{
			[Token(Token = "0x60002FF")]
			[Address(RVA = "0xAB6434", Offset = "0xAB6434", VA = "0xAB6434")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000300")]
			[Address(RVA = "0xAB643C", Offset = "0xAB643C", VA = "0xAB643C")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool HasActiveFXFilter
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xAB646C", Offset = "0xAB646C", VA = "0xAB646C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xAB3280", Offset = "0xAB3280", VA = "0xAB3280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		public float OriginalPitch
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xAB43C8", Offset = "0xAB43C8", VA = "0xAB43C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000068")]
		public float OriginalVolume
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xAB66B0", Offset = "0xAB66B0", VA = "0xAB66B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000069")]
		public string SoundGroupName
		{
			[Token(Token = "0x6000306")]
			[Address(RVA = "0xAB66F0", Offset = "0xAB66F0", VA = "0xAB66F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		public bool IsAvailableToPlay
		{
			[Token(Token = "0x6000307")]
			[Address(RVA = "0xAB6740", Offset = "0xAB6740", VA = "0xAB6740")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public float LastTimePlayed
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0xAB67E8", Offset = "0xAB67E8", VA = "0xAB67E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CC10", Offset = "0x44CC10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xAB67F0", Offset = "0xAB67F0", VA = "0xAB67F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CC20", Offset = "0x44CC20")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public bool ClipIsLoaded
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0xAB67F8", Offset = "0xAB67F8", VA = "0xAB67F8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public bool IsPlaying
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xAB5028", Offset = "0xAB5028", VA = "0xAB5028")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006E")]
		public MasterAudio.VariationLoadStatus LoadStatus
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0xAB6808", Offset = "0xAB6808", VA = "0xAB6808")]
			get
			{
				return default(MasterAudio.VariationLoadStatus);
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0xAB4228", Offset = "0xAB4228", VA = "0xAB4228")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public int InstanceId
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0xAB49DC", Offset = "0xAB49DC", VA = "0xAB49DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000070")]
		public bool IsStopRequested
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xAB6810", Offset = "0xAB6810", VA = "0xAB6810")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000071")]
		public Transform Trans
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0xAB56E4", Offset = "0xAB56E4", VA = "0xAB56E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public GameObject GameObj
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xAB3018", Offset = "0xAB3018", VA = "0xAB3018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public AudioSource VarAudio
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0xAB2F64", Offset = "0xAB2F64", VA = "0xAB2F64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		public bool AudioLoops
		{
			[Token(Token = "0x6000313")]
			[Address(RVA = "0xAB4920", Offset = "0xAB4920", VA = "0xAB4920")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000075")]
		public string ResFileName
		{
			[Token(Token = "0x6000314")]
			[Address(RVA = "0xAB4740", Offset = "0xAB4740", VA = "0xAB4740")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public SoundGroupVariationUpdater VariationUpdater
		{
			[Token(Token = "0x6000315")]
			[Address(RVA = "0xAB37C8", Offset = "0xAB37C8", VA = "0xAB37C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		public PlaySoundParams PlaySoundParm
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0xAB6818", Offset = "0xAB6818", VA = "0xAB6818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		public float SetGroupVolume
		{
			[Token(Token = "0x6000317")]
			[Address(RVA = "0xAB6820", Offset = "0xAB6820", VA = "0xAB6820")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000318")]
			[Address(RVA = "0xAB683C", Offset = "0xAB683C", VA = "0xAB683C")]
			set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public int MaxLoops
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0xAB6858", Offset = "0xAB6858", VA = "0xAB6858")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700007A")]
		private bool Is2D
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0xAB6860", Offset = "0xAB6860", VA = "0xAB6860")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007B")]
		public bool UsesOcclusion
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xAB387C", Offset = "0xAB387C", VA = "0xAB387C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007C")]
		public bool IsPaused
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xAB688C", Offset = "0xAB688C", VA = "0xAB688C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x14000002")]
		public event SoundFinishedEventHandler SoundFinished
		{
			[Token(Token = "0x60002D1")]
			[Address(RVA = "0xAB2AE8", Offset = "0xAB2AE8", VA = "0xAB2AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB70", Offset = "0x44CB70")]
			add
			{
			}
			[Token(Token = "0x60002D2")]
			[Address(RVA = "0xAB2B8C", Offset = "0xAB2B8C", VA = "0xAB2B8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB80", Offset = "0x44CB80")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event SoundLoopedEventHandler SoundLooped
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0xAB2C30", Offset = "0xAB2C30", VA = "0xAB2C30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CB90", Offset = "0x44CB90")]
			add
			{
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0xAB2CD4", Offset = "0xAB2CD4", VA = "0xAB2CD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CBA0", Offset = "0x44CBA0")]
			remove
			{
			}
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xAB2D78", Offset = "0xAB2D78", VA = "0xAB2D78")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xAB30B8", Offset = "0xAB30B8", VA = "0xAB30B8")]
		private void Start()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xAB3458", Offset = "0xAB3458", VA = "0xAB3458")]
		public void SetMixerGroup()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xAB34AC", Offset = "0xAB34AC", VA = "0xAB34AC")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xAB3654", Offset = "0xAB3654", VA = "0xAB3654")]
		private void SetOcclusion()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xAB35A8", Offset = "0xAB35A8", VA = "0xAB35A8")]
		private void SetPriority()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xAB3A08", Offset = "0xAB3A08", VA = "0xAB3A08")]
		public void DisableUpdater()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xAB3AAC", Offset = "0xAB3AAC", VA = "0xAB3AAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xAB3B78", Offset = "0xAB3B78", VA = "0xAB3B78")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xAB3AB0", Offset = "0xAB3AB0", VA = "0xAB3AB0")]
		private void StopSoundEarly()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xAB3ED8", Offset = "0xAB3ED8", VA = "0xAB3ED8")]
		public void Play(float? pitch, float maxVolume, string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xAB4294", Offset = "0xAB4294", VA = "0xAB4294")]
		public void SetPlaySoundParams(string gameObjectName, float volPercent, float targetVol, float? targetPitch, Transform sourceTrans, bool attach, float delayTime, double? timeToSchedulePlay, bool isChaining, bool isSingleSubscribedPlay)
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xAB423C", Offset = "0xAB423C", VA = "0xAB423C")]
		private void MaybeCleanupFinishedDelegate()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xAB4820", Offset = "0xAB4820", VA = "0xAB4820")]
		private void ResourceFailedToLoad()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xAB4408", Offset = "0xAB4408", VA = "0xAB4408")]
		private void FinishSetupToPlay()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xAB4A10", Offset = "0xAB4A10", VA = "0xAB4A10")]
		public void JumpToTime(float timeToJumpTo)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xAB4A5C", Offset = "0xAB4A5C", VA = "0xAB4A5C")]
		public void GlideByPitch(float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xAB4CA8", Offset = "0xAB4CA8", VA = "0xAB4CA8")]
		public void AdjustVolume(float volumePercentage)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xAB4E34", Offset = "0xAB4E34", VA = "0xAB4E34")]
		public void Pause()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xAB4F40", Offset = "0xAB4F40", VA = "0xAB4F40")]
		public void Unpause()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xAB5044", Offset = "0xAB5044", VA = "0xAB5044")]
		public void DoNextChain(float volumePercentage, float? pitch, Transform transActor, bool attach)
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xAB50FC", Offset = "0xAB50FC", VA = "0xAB50FC")]
		public void PlayEndLinkedGroups([Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xAB4840", Offset = "0xAB4840", VA = "0xAB4840")]
		private void EnableUpdater(bool waitForSoundFinish = true)
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xAB55F8", Offset = "0xAB55F8", VA = "0xAB55F8")]
		private void MaybeUnloadClip()
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xAB5398", Offset = "0xAB5398", VA = "0xAB5398")]
		private void PlayEndLinkedGroup(string sType, [Optional] double? timeToPlayClip)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xAB3B7C", Offset = "0xAB3B7C", VA = "0xAB3B7C")]
		public void Stop(bool stopEndDetection = false, bool skipLinked = false)
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xAB5784", Offset = "0xAB5784", VA = "0xAB5784")]
		private void StopEndCleanup()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xAB57C8", Offset = "0xAB57C8", VA = "0xAB57C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CBB0", Offset = "0x44CBB0")]
		private IEnumerator WaitForLoadToUnloadClipAndDeactivate()
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xAB5840", Offset = "0xAB5840", VA = "0xAB5840")]
		public void FadeToVolume(float newVolume, float fadeTime)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xAB5ADC", Offset = "0xAB5ADC", VA = "0xAB5ADC")]
		public void FadeOutNow()
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xAB5C18", Offset = "0xAB5C18", VA = "0xAB5C18")]
		public void FadeOutNow(float fadeTime)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xAB5D5C", Offset = "0xAB5D5C", VA = "0xAB5D5C")]
		public bool WasTriggeredFromTransform(Transform trans)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xAB5E18", Offset = "0xAB5E18", VA = "0xAB5E18")]
		public bool WasTriggeredFromAnyOfTransformMap(HashSet<Transform> transMap)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xAB62F0", Offset = "0xAB62F0", VA = "0xAB62F0")]
		public void UpdateTransformTracker(Transform sourceTrans)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0xAB6894", Offset = "0xAB6894", VA = "0xAB6894")]
		public void SoundLoopStarted(int numberOfLoops)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0xAB47E8", Offset = "0xAB47E8", VA = "0xAB47E8")]
		public void ClearSubscribers()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xAB68A8", Offset = "0xAB68A8", VA = "0xAB68A8")]
		public SoundGroupVariation()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44ADA4", Offset = "0x44ADA4")]
	public class SoundGroupVariationUpdater : MonoBehaviour
	{
		[Token(Token = "0x20000C4")]
		private enum WaitForSoundFinishMode
		{
			[Token(Token = "0x4000524")]
			None,
			[Token(Token = "0x4000525")]
			Play,
			[Token(Token = "0x4000526")]
			WaitForEnd,
			[Token(Token = "0x4000527")]
			StopOrRepeat
		}

		[Token(Token = "0x40004EF")]
		private const float TimeEarlyToScheduleNextClip = 0.1f;

		[Token(Token = "0x40004F0")]
		private const float FakeNegativeFloatValue = -10f;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _objectToFollow;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject _objectToFollowGo;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _isFollowing;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SoundGroupVariation _variation;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _priorityLastUpdated;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _useClipAgePriority;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSoundFinishMode _waitMode;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AudioSource _varAudio;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MasterAudioGroup _parentGrp;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _trans;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _frameNum;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool _inited;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _fadeOutStartTime;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool _fadeInOutWillFadeOut;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		private bool _hasFadeInOutSetMaxVolume;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _fadeInOutInFactor;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _fadeInOutOutFactor;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _fadeOutEarlyTotalFrames;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _fadeOutEarlyFrameVolChange;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _fadeOutEarlyFrameNumber;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float _fadeOutEarlyOrigVol;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float _fadeToTargetFrameVolChange;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int _fadeToTargetFrameNumber;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float _fadeToTargetOrigVol;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private int _fadeToTargetTotalFrames;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _fadeToTargetVolume;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool _fadeOutStarted;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastFrameClipTime;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isPlayingBackward;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _pitchGlideToTargetTotalFrames;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _pitchGlideToTargetFramePitchChange;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private int _pitchGlideToTargetFrameNumber;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float _glideToTargetPitch;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float _glideToTargetOrigPitch;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Action _glideToPitchCompletionCallback;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool _hasStartedNextInChain;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool _isWaitingForQueuedOcclusionRay;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int _framesPlayed;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float? _clipStartPosition;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float? _clipEndPosition;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private double? _clipSchedEndTime;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool _hasScheduledNextClip;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool _hasScheduledEndLinkedGroups;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _lastFrameClipPosition;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int _timesLooped;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool _isPaused;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private double _pauseTime;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _maCachedFromFrame;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MasterAudio _maThisFrame;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Transform _listenerThisFrame;

		[Token(Token = "0x1700007F")]
		public float ClipStartPosition
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x9D7A80", Offset = "0x9D7A80", VA = "0x9D7A80")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000080")]
		public float ClipEndPosition
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x9D63AC", Offset = "0x9D63AC", VA = "0x9D63AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000081")]
		public int FramesPlayed
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x9D8B98", Offset = "0x9D8B98", VA = "0x9D8B98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000082")]
		public MasterAudio MAThisFrame
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x9D8BA0", Offset = "0x9D8BA0", VA = "0x9D8BA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		public float MaxOcclusionFreq
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x9D8C04", Offset = "0x9D8C04", VA = "0x9D8C04")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000084")]
		public float MinOcclusionFreq
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x9D8CBC", Offset = "0x9D8CBC", VA = "0x9D8CBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000085")]
		private Transform Trans
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x9D70D8", Offset = "0x9D70D8", VA = "0x9D70D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private AudioSource VarAudio
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x9D6178", Offset = "0x9D6178", VA = "0x9D6178")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private MasterAudioGroup ParentGroup
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x9D7184", Offset = "0x9D7184", VA = "0x9D7184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private SoundGroupVariation GrpVariation
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x9D60C4", Offset = "0x9D60C4", VA = "0x9D60C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000089")]
		private float RayCastOriginOffset
		{
			[Token(Token = "0x6000356")]
			[Address(RVA = "0x9D79C8", Offset = "0x9D79C8", VA = "0x9D79C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700008A")]
		private bool IsOcclusionMeasuringPaused
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x9D7444", Offset = "0x9D7444", VA = "0x9D7444")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700008B")]
		private bool HasEndLinkedGroups
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x9D8B2C", Offset = "0x9D8B2C", VA = "0x9D8B2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x9D5FFC", Offset = "0x9D5FFC", VA = "0x9D5FFC")]
		public void GlidePitch(float targetPitch, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x9D6224", Offset = "0x9D6224", VA = "0x9D6224")]
		public void FadeOverTimeToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x9D64F0", Offset = "0x9D64F0", VA = "0x9D64F0")]
		public void FadeOutEarly(float fadeTime)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x9D6688", Offset = "0x9D6688", VA = "0x9D6688")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x9D66C0", Offset = "0x9D66C0", VA = "0x9D66C0")]
		public void FadeInOut()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x9D67EC", Offset = "0x9D67EC", VA = "0x9D67EC")]
		public void FollowObject(bool follow, Transform objToFollow, bool clipAgePriority)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x9D6B80", Offset = "0x9D6B80", VA = "0x9D6B80")]
		public void WaitForSoundFinish()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x9D6F60", Offset = "0x9D6F60", VA = "0x9D6F60")]
		public void StopPitchGliding()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x9D7030", Offset = "0x9D7030", VA = "0x9D7030")]
		public void StopFading()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x9D7060", Offset = "0x9D7060", VA = "0x9D7060")]
		public void StopWaitingForFinish()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x9D7094", Offset = "0x9D7094", VA = "0x9D7094")]
		public void StopFollowing()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x9D6FB4", Offset = "0x9D6FB4", VA = "0x9D6FB4")]
		private void DisableIfFinished()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9D69F0", Offset = "0x9D69F0", VA = "0x9D69F0")]
		private void UpdateAudioLocationAndPriority(bool rePrioritize)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9D7230", Offset = "0x9D7230", VA = "0x9D7230")]
		private void ResetToNonOcclusionSetting()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9D72D8", Offset = "0x9D72D8", VA = "0x9D72D8")]
		private void UpdateOcclusion()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9D74D0", Offset = "0x9D74D0", VA = "0x9D74D0")]
		private void DoneWithOcclusion()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9D7548", Offset = "0x9D7548", VA = "0x9D7548")]
		public bool RayCastForOcclusion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x9D6C00", Offset = "0x9D6C00", VA = "0x9D6C00")]
		private void PlaySoundAndWait()
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9D7BD0", Offset = "0x9D7BD0", VA = "0x9D7BD0")]
		private void DuckIfNotSilent()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x9D7D54", Offset = "0x9D7D54", VA = "0x9D7D54")]
		private void StopOrChain()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x9D8114", Offset = "0x9D8114", VA = "0x9D8114")]
		public void Pause()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x9D8144", Offset = "0x9D8144", VA = "0x9D8144")]
		public void Unpause()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x9D7DF4", Offset = "0x9D7DF4", VA = "0x9D7DF4")]
		public void MaybeChain()
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x9D8240", Offset = "0x9D8240", VA = "0x9D8240")]
		private void UpdatePitch()
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9D8304", Offset = "0x9D8304", VA = "0x9D8304")]
		private void PerformFading()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9D85C8", Offset = "0x9D85C8", VA = "0x9D85C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x9D8650", Offset = "0x9D8650", VA = "0x9D8650")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x9D68CC", Offset = "0x9D68CC", VA = "0x9D68CC")]
		public void UpdateCachedObjects()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x9D8738", Offset = "0x9D8738", VA = "0x9D8738")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x9D8D74", Offset = "0x9D8D74", VA = "0x9D8D74")]
		public SoundGroupVariationUpdater()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public static class AudioLoaderOptimizer
	{
		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<GameObject>> PlayingGameObjectsByClipName;

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x6C2344", Offset = "0x6C2344", VA = "0x6C2344")]
		public static void AddNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x6C2594", Offset = "0x6C2594", VA = "0x6C2594")]
		public static void RemoveNonPreloadedPlayingClip(AudioClip clip, GameObject maHolderGameObject)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x6C2764", Offset = "0x6C2764", VA = "0x6C2764")]
		public static bool IsAnyOfNonPreloadedClipPlaying(AudioClip clip)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000C6")]
	public static class AudioPrioritizer
	{
		[Token(Token = "0x4000529")]
		private const int MaxPriority = 0;

		[Token(Token = "0x400052A")]
		private const int HighestPriority = 16;

		[Token(Token = "0x400052B")]
		private const int LowestPriority = 128;

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x6C2954", Offset = "0x6C2954", VA = "0x6C2954")]
		public static void Set2DSoundPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x6C2970", Offset = "0x6C2970", VA = "0x6C2970")]
		public static void SetSoundGroupInitialPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x6C298C", Offset = "0x6C298C", VA = "0x6C298C")]
		public static void SetPreviewPriority(AudioSource audio)
		{
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x6C29A8", Offset = "0x6C29A8", VA = "0x6C29A8")]
		public static void Set3DPriority(SoundGroupVariation variation, bool useClipAgePriority)
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public static class AudioResourceOptimizer
	{
		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ADB8", Offset = "0x44ADB8")]
		private sealed class <PopulateResourceSongToPlaylistControllerAsync>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string songResourceName;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string playlistName;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public PlaylistController controller;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MusicSetting songSetting;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public PlaylistController.AudioPlayType playType;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700008C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x9E0388", Offset = "0x9E0388", VA = "0x9E0388", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000375")]
				[Address(RVA = "0x9E03D0", Offset = "0x9E03D0", VA = "0x9E03D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x9DFD7C", Offset = "0x9DFD7C", VA = "0x9DFD7C")]
			[DebuggerHidden]
			public <PopulateResourceSongToPlaylistControllerAsync>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x9DFDA8", Offset = "0x9DFDA8", VA = "0x9DFDA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x9DFDAC", Offset = "0x9DFDAC", VA = "0x9DFDAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x9E0390", Offset = "0x9E0390", VA = "0x9E0390", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ADC8", Offset = "0x44ADC8")]
		private sealed class <PopulateSourcesWithResourceClipAsync>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string clipName;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action successAction;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action failureAction;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public SoundGroupVariation variation;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ResourceRequest <asyncRes>5__2;

			[Token(Token = "0x1700008E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x9E0A90", Offset = "0x9E0A90", VA = "0x9E0A90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700008F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x9E0AD8", Offset = "0x9E0AD8", VA = "0x9E0AD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x9E03D8", Offset = "0x9E03D8", VA = "0x9E03D8")]
			[DebuggerHidden]
			public <PopulateSourcesWithResourceClipAsync>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x9E0404", Offset = "0x9E0404", VA = "0x9E0404", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x9E0408", Offset = "0x9E0408", VA = "0x9E0408", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x9E0A98", Offset = "0x9E0A98", VA = "0x9E0A98", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<string, List<AudioSource>> AudioResourceTargetsByName;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly Dictionary<string, AudioClip> AudioClipsByName;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly Dictionary<string, List<AudioClip>> PlaylistClipsByPlaylistName;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static string _supportedLanguageFolder;

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x6C2D84", Offset = "0x6C2D84", VA = "0x6C2D84")]
		public static void ClearAudioClips()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x6C2E34", Offset = "0x6C2E34", VA = "0x6C2E34")]
		public static string GetLocalizedDynamicSoundGroupFileName(SystemLanguage localLanguage, bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x6C2FB4", Offset = "0x6C2FB4", VA = "0x6C2FB4")]
		public static string GetLocalizedFileName(bool useLocalization, string resourceFileName)
		{
			return null;
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x6C3358", Offset = "0x6C3358", VA = "0x6C3358")]
		public static void AddTargetForClip(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x6C3058", Offset = "0x6C3058", VA = "0x6C3058")]
		private static string SupportedLanguageFolder()
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x6C361C", Offset = "0x6C361C", VA = "0x6C361C")]
		public static void ClearSupportLanguageFolder()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x6C36A4", Offset = "0x6C36A4", VA = "0x6C36A4")]
		private static void FinishRecordingPlaylistClip(string controllerName, AudioClip resAudioClip)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x6C3848", Offset = "0x6C3848", VA = "0x6C3848")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CC80", Offset = "0x44CC80")]
		public static IEnumerator PopulateResourceSongToPlaylistControllerAsync(MusicSetting songSetting, string songResourceName, string playlistName, PlaylistController controller, PlaylistController.AudioPlayType playType)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x6C3914", Offset = "0x6C3914", VA = "0x6C3914")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CCE0", Offset = "0x44CCE0")]
		public static IEnumerator PopulateSourcesWithResourceClipAsync(string clipName, SoundGroupVariation variation, Action successAction, Action failureAction)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x6C39D8", Offset = "0x6C39D8", VA = "0x6C39D8")]
		public static void UnloadPlaylistSongIfUnused(string controllerName, AudioClip clipToRemove)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x6C3B7C", Offset = "0x6C3B7C", VA = "0x6C3B7C")]
		public static void DeleteAudioSourceFromList(string clipName, AudioSource source)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x6C3D7C", Offset = "0x6C3D7C", VA = "0x6C3D7C")]
		public static void UnloadClipIfUnused(string clipName)
		{
		}
	}
	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44ADD8", Offset = "0x44ADD8")]
	public class MasterAudio : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public enum AmbientSoundExitMode
		{
			[Token(Token = "0x40005F0")]
			StopSound,
			[Token(Token = "0x40005F1")]
			FadeSound
		}

		[Token(Token = "0x20000CC")]
		public enum AmbientSoundReEnterMode
		{
			[Token(Token = "0x40005F3")]
			StopExistingSound,
			[Token(Token = "0x40005F4")]
			FadeInSameSound
		}

		[Token(Token = "0x20000CD")]
		public enum VariationFollowerType
		{
			[Token(Token = "0x40005F6")]
			LateUpdate,
			[Token(Token = "0x40005F7")]
			FixedUpdate
		}

		[Token(Token = "0x20000CE")]
		public enum LinkedGroupSelectionType
		{
			[Token(Token = "0x40005F9")]
			All,
			[Token(Token = "0x40005FA")]
			OneAtRandom
		}

		[Token(Token = "0x20000CF")]
		public enum OcclusionSelectionType
		{
			[Token(Token = "0x40005FC")]
			AllGroups,
			[Token(Token = "0x40005FD")]
			TurnOnPerBusOrGroup
		}

		[Token(Token = "0x20000D0")]
		public enum RaycastMode
		{
			[Token(Token = "0x40005FF")]
			Physics3D,
			[Token(Token = "0x4000600")]
			Physics2D
		}

		[Token(Token = "0x20000D1")]
		public enum AllMusicSpatialBlendType
		{
			[Token(Token = "0x4000602")]
			ForceAllTo2D,
			[Token(Token = "0x4000603")]
			ForceAllTo3D,
			[Token(Token = "0x4000604")]
			ForceAllToCustom,
			[Token(Token = "0x4000605")]
			AllowDifferentPerController
		}

		[Token(Token = "0x20000D2")]
		public enum AllMixerSpatialBlendType
		{
			[Token(Token = "0x4000607")]
			ForceAllTo2D,
			[Token(Token = "0x4000608")]
			ForceAllTo3D,
			[Token(Token = "0x4000609")]
			ForceAllToCustom,
			[Token(Token = "0x400060A")]
			AllowDifferentPerGroup
		}

		[Token(Token = "0x20000D3")]
		public enum ItemSpatialBlendType
		{
			[Token(Token = "0x400060C")]
			ForceTo2D,
			[Token(Token = "0x400060D")]
			ForceTo3D,
			[Token(Token = "0x400060E")]
			ForceToCustom,
			[Token(Token = "0x400060F")]
			UseCurveFromAudioSource
		}

		[Token(Token = "0x20000D4")]
		public enum MixerWidthMode
		{
			[Token(Token = "0x4000611")]
			Narrow,
			[Token(Token = "0x4000612")]
			Normal,
			[Token(Token = "0x4000613")]
			Wide
		}

		[Token(Token = "0x20000D5")]
		public enum CustomEventReceiveMode
		{
			[Token(Token = "0x4000615")]
			Always,
			[Token(Token = "0x4000616")]
			WhenDistanceLessThan,
			[Token(Token = "0x4000617")]
			WhenDistanceMoreThan,
			[Token(Token = "0x4000618")]
			Never,
			[Token(Token = "0x4000619")]
			OnSameGameObject,
			[Token(Token = "0x400061A")]
			OnChildGameObject,
			[Token(Token = "0x400061B")]
			OnParentGameObject,
			[Token(Token = "0x400061C")]
			OnSameOrChildGameObject,
			[Token(Token = "0x400061D")]
			OnSameOrParentGameObject
		}

		[Token(Token = "0x20000D6")]
		public enum EventReceiveFilter
		{
			[Token(Token = "0x400061F")]
			All,
			[Token(Token = "0x4000620")]
			Closest,
			[Token(Token = "0x4000621")]
			Random
		}

		[Token(Token = "0x20000D7")]
		public enum VariationLoadStatus
		{
			[Token(Token = "0x4000623")]
			None,
			[Token(Token = "0x4000624")]
			Loading,
			[Token(Token = "0x4000625")]
			Loaded,
			[Token(Token = "0x4000626")]
			LoadFailed
		}

		[Token(Token = "0x20000D8")]
		public enum AudioLocation
		{
			[Token(Token = "0x4000628")]
			Clip,
			[Token(Token = "0x4000629")]
			ResourceFile
		}

		[Token(Token = "0x20000D9")]
		public enum CustomSongStartTimeMode
		{
			[Token(Token = "0x400062B")]
			Beginning,
			[Token(Token = "0x400062C")]
			SpecificTime,
			[Token(Token = "0x400062D")]
			RandomTime
		}

		[Token(Token = "0x20000DA")]
		public enum BusCommand
		{
			[Token(Token = "0x400062F")]
			None,
			[Token(Token = "0x4000630")]
			FadeToVolume,
			[Token(Token = "0x4000631")]
			Mute,
			[Token(Token = "0x4000632")]
			Pause,
			[Token(Token = "0x4000633")]
			Solo,
			[Token(Token = "0x4000634")]
			Unmute,
			[Token(Token = "0x4000635")]
			Unpause,
			[Token(Token = "0x4000636")]
			Unsolo,
			[Token(Token = "0x4000637")]
			Stop,
			[Token(Token = "0x4000638")]
			ChangePitch,
			[Token(Token = "0x4000639")]
			ToggleMute,
			[Token(Token = "0x400063A")]
			StopBusOfTransform,
			[Token(Token = "0x400063B")]
			PauseBusOfTransform,
			[Token(Token = "0x400063C")]
			UnpauseBusOfTransform,
			[Token(Token = "0x400063D")]
			GlideByPitch,
			[Token(Token = "0x400063E")]
			StopOldBusVoices,
			[Token(Token = "0x400063F")]
			FadeOutOldBusVoices
		}

		[Token(Token = "0x20000DB")]
		public enum DragGroupMode
		{
			[Token(Token = "0x4000641")]
			OneGroupPerClip,
			[Token(Token = "0x4000642")]
			OneGroupWithVariations
		}

		[Token(Token = "0x20000DC")]
		public enum EventSoundFunctionType
		{
			[Token(Token = "0x4000644")]
			PlaySound,
			[Token(Token = "0x4000645")]
			GroupControl,
			[Token(Token = "0x4000646")]
			BusControl,
			[Token(Token = "0x4000647")]
			PlaylistControl,
			[Token(Token = "0x4000648")]
			CustomEventControl,
			[Token(Token = "0x4000649")]
			GlobalControl,
			[Token(Token = "0x400064A")]
			UnityMixerControl,
			[Token(Token = "0x400064B")]
			PersistentSettingsControl
		}

		[Token(Token = "0x20000DD")]
		public enum LanguageMode
		{
			[Token(Token = "0x400064D")]
			UseDeviceSetting,
			[Token(Token = "0x400064E")]
			SpecificLanguage,
			[Token(Token = "0x400064F")]
			DynamicallySet
		}

		[Token(Token = "0x20000DE")]
		public enum UnityMixerCommand
		{
			[Token(Token = "0x4000651")]
			None,
			[Token(Token = "0x4000652")]
			TransitionToSnapshot,
			[Token(Token = "0x4000653")]
			TransitionToSnapshotBlend
		}

		[Token(Token = "0x20000DF")]
		public enum PlaylistCommand
		{
			[Token(Token = "0x4000655")]
			None,
			[Token(Token = "0x4000656")]
			ChangePlaylist,
			[Token(Token = "0x4000657")]
			FadeToVolume,
			[Token(Token = "0x4000658")]
			PlaySong,
			[Token(Token = "0x4000659")]
			PlayRandomSong,
			[Token(Token = "0x400065A")]
			PlayNextSong,
			[Token(Token = "0x400065B")]
			Pause,
			[Token(Token = "0x400065C")]
			Resume,
			[Token(Token = "0x400065D")]
			Stop,
			[Token(Token = "0x400065E")]
			Mute,
			[Token(Token = "0x400065F")]
			Unmute,
			[Token(Token = "0x4000660")]
			ToggleMute,
			[Token(Token = "0x4000661")]
			Restart,
			[Token(Token = "0x4000662")]
			Start,
			[Token(Token = "0x4000663")]
			StopLoopingCurrentSong,
			[Token(Token = "0x4000664")]
			StopPlaylistAfterCurrentSong,
			[Token(Token = "0x4000665")]
			AddSongToQueue
		}

		[Token(Token = "0x20000E0")]
		public enum CustomEventCommand
		{
			[Token(Token = "0x4000667")]
			None,
			[Token(Token = "0x4000668")]
			FireEvent
		}

		[Token(Token = "0x20000E1")]
		public enum GlobalCommand
		{
			[Token(Token = "0x400066A")]
			None,
			[Token(Token = "0x400066B")]
			PauseMixer,
			[Token(Token = "0x400066C")]
			UnpauseMixer,
			[Token(Token = "0x400066D")]
			StopMixer,
			[Token(Token = "0x400066E")]
			StopEverything,
			[Token(Token = "0x400066F")]
			PauseEverything,
			[Token(Token = "0x4000670")]
			UnpauseEverything,
			[Token(Token = "0x4000671")]
			MuteEverything,
			[Token(Token = "0x4000672")]
			UnmuteEverything,
			[Token(Token = "0x4000673")]
			SetMasterMixerVolume,
			[Token(Token = "0x4000674")]
			SetMasterPlaylistVolume
		}

		[Token(Token = "0x20000E2")]
		public enum SoundGroupCommand
		{
			[Token(Token = "0x4000676")]
			None,
			[Token(Token = "0x4000677")]
			FadeToVolume,
			[Token(Token = "0x4000678")]
			FadeOutAllOfSound,
			[Token(Token = "0x4000679")]
			Mute,
			[Token(Token = "0x400067A")]
			Pause,
			[Token(Token = "0x400067B")]
			Solo,
			[Token(Token = "0x400067C")]
			StopAllOfSound,
			[Token(Token = "0x400067D")]
			Unmute,
			[Token(Token = "0x400067E")]
			Unpause,
			[Token(Token = "0x400067F")]
			Unsolo,
			[Token(Token = "0x4000680")]
			StopAllSoundsOfTransform,
			[Token(Token = "0x4000681")]
			PauseAllSoundsOfTransform,
			[Token(Token = "0x4000682")]
			UnpauseAllSoundsOfTransform,
			[Token(Token = "0x4000683")]
			StopSoundGroupOfTransform,
			[Token(Token = "0x4000684")]
			PauseSoundGroupOfTransform,
			[Token(Token = "0x4000685")]
			UnpauseSoundGroupOfTransform,
			[Token(Token = "0x4000686")]
			FadeOutSoundGroupOfTransform,
			[Token(Token = "0x4000687")]
			RefillSoundGroupPool,
			[Token(Token = "0x4000688")]
			RouteToBus,
			[Token(Token = "0x4000689")]
			GlideByPitch,
			[Token(Token = "0x400068A")]
			ToggleSoundGroup,
			[Token(Token = "0x400068B")]
			ToggleSoundGroupOfTransform,
			[Token(Token = "0x400068C")]
			FadeOutAllSoundsOfTransform,
			[Token(Token = "0x400068D")]
			StopOldSoundGroupVoices,
			[Token(Token = "0x400068E")]
			FadeOutOldSoundGroupVoices
		}

		[Token(Token = "0x20000E3")]
		public enum PersistentSettingsCommand
		{
			[Token(Token = "0x4000690")]
			None,
			[Token(Token = "0x4000691")]
			SetBusVolume,
			[Token(Token = "0x4000692")]
			SetGroupVolume,
			[Token(Token = "0x4000693")]
			SetMixerVolume,
			[Token(Token = "0x4000694")]
			SetMusicVolume,
			[Token(Token = "0x4000695")]
			MixerMuteToggle,
			[Token(Token = "0x4000696")]
			MusicMuteToggle
		}

		[Token(Token = "0x20000E4")]
		public enum SongFadeInPosition
		{
			[Token(Token = "0x4000698")]
			NewClipFromBeginning = 1,
			[Token(Token = "0x4000699")]
			NewClipFromLastKnownPosition = 3,
			[Token(Token = "0x400069A")]
			SynchronizeClips = 5
		}

		[Token(Token = "0x20000E5")]
		public enum SoundSpawnLocationMode
		{
			[Token(Token = "0x400069C")]
			MasterAudioLocation,
			[Token(Token = "0x400069D")]
			CallerLocation,
			[Token(Token = "0x400069E")]
			AttachToCaller
		}

		[Token(Token = "0x20000E6")]
		public enum VariationCommand
		{
			[Token(Token = "0x40006A0")]
			None,
			[Token(Token = "0x40006A1")]
			Stop,
			[Token(Token = "0x40006A2")]
			Pause,
			[Token(Token = "0x40006A3")]
			Unpause
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public struct CustomEventCandidate
		{
			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float DistanceAway;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ICustomEventReceiver Receiver;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform Trans;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int RandomId;

			[Token(Token = "0x60004A6")]
			[Address(RVA = "0x9E3AE8", Offset = "0x9E3AE8", VA = "0x9E3AE8")]
			public CustomEventCandidate(float distance, ICustomEventReceiver rec, Transform trans, int randomId)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class AudioGroupInfo
		{
			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<AudioInfo> Sources;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int LastFramePlayed;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastTimePlayed;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MasterAudioGroup Group;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool PlayedForWarming;

			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x9E3A10", Offset = "0x9E3A10", VA = "0x9E3A10")]
			public AudioGroupInfo(List<AudioInfo> sources, MasterAudioGroup groupScript)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class AudioInfo
		{
			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource Source;

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float OriginalVolume;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LastPercentageVolume;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float LastRandomVolume;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public SoundGroupVariation Variation;

			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x9E3A78", Offset = "0x9E3A78", VA = "0x9E3A78")]
			public AudioInfo(SoundGroupVariation variation, AudioSource source, float origVol)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Playlist
		{
			[Token(Token = "0x20000EB")]
			public enum CrossfadeTimeMode
			{
				[Token(Token = "0x40006C4")]
				UseMasterSetting,
				[Token(Token = "0x40006C5")]
				Override
			}

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool isExpanded;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string playlistName;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SongFadeInPosition songTransitionType;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<MusicSetting> MusicSettings;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AudioLocation bulkLocationMode;

			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public CrossfadeTimeMode crossfadeMode;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float crossFadeTime;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public bool fadeInFirstSong;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
			public bool fadeOutLastSong;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
			public bool bulkEditMode;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
			public bool isTemporary;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool showMetadata;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<SongMetadataProperty> songMetadataProps;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public string newMetadataPropName;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public SongMetadataProperty.MetadataPropertyType newMetadataPropType;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public bool newMetadataPropRequired;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
			public bool newMetadataPropCanHaveMult;

			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x9E3B34", Offset = "0x9E3B34", VA = "0x9E3B34")]
			public Playlist()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EC")]
		public class SoundGroupRefillInfo
		{
			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float LastTimePlayed;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float InactivePeriodSeconds;

			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x9E3C70", Offset = "0x9E3C70", VA = "0x9E3C70")]
			public SoundGroupRefillInfo(float lastTimePlayed, float inactivePeriodSeconds)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000ED")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ADEC", Offset = "0x44ADEC")]
		private sealed class <>c
		{
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<OcclusionFreqChangeInfo> <>9__224_0;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<BusFadeInfo> <>9__225_0;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Predicate<GroupFadeInfo> <>9__226_0;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Predicate<AmbientSoundToTriggerInfo> <>9__227_0;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Predicate<GroupPitchGlideInfo> <>9__228_0;

			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Predicate<BusPitchGlideInfo> <>9__229_0;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static Comparison<CustomEventCandidate> <>9__427_0;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static Comparison<CustomEventCandidate> <>9__427_1;

			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x9E2954", Offset = "0x9E2954", VA = "0x9E2954")]
			public <>c()
			{
			}

			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x9E295C", Offset = "0x9E295C", VA = "0x9E295C")]
			internal bool <PerformOcclusionFrequencyChanges>b__224_0(OcclusionFreqChangeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004AE")]
			[Address(RVA = "0x9E297C", Offset = "0x9E297C", VA = "0x9E297C")]
			internal bool <PerformBusFades>b__225_0(BusFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x9E299C", Offset = "0x9E299C", VA = "0x9E299C")]
			internal bool <PerformGroupFades>b__226_0(GroupFadeInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x9E29BC", Offset = "0x9E29BC", VA = "0x9E29BC")]
			internal bool <PerformDelayedAmbientTriggers>b__227_0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x9E29F4", Offset = "0x9E29F4", VA = "0x9E29F4")]
			internal bool <PerformGroupPitchGlides>b__228_0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x9E2A14", Offset = "0x9E2A14", VA = "0x9E2A14")]
			internal bool <PerformBusPitchGlides>b__229_0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x9E2A34", Offset = "0x9E2A34", VA = "0x9E2A34")]
			internal int <FireCustomEvent>b__427_0(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}

			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x9E2A44", Offset = "0x9E2A44", VA = "0x9E2A44")]
			internal int <FireCustomEvent>b__427_1(CustomEventCandidate x, CustomEventCandidate y)
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000EE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44ADFC", Offset = "0x44ADFC")]
		private sealed class <>c__DisplayClass239_0
		{
			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x9E2A58", Offset = "0x9E2A58", VA = "0x9E2A58")]
			public <>c__DisplayClass239_0()
			{
			}

			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x9E2A60", Offset = "0x9E2A60", VA = "0x9E2A60")]
			internal void <PlaySoundAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000EF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE0C", Offset = "0x44AE0C")]
		private sealed class <PlaySoundAndWaitUntilFinished>d__239 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float volumePercentage;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float? pitch;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float delaySoundTime;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string variationName;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private <>c__DisplayClass239_0 <>8__1;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action completedAction;

			[Token(Token = "0x170000B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004BA")]
				[Address(RVA = "0x9E39C0", Offset = "0x9E39C0", VA = "0x9E39C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004BC")]
				[Address(RVA = "0x9E3A08", Offset = "0x9E3A08", VA = "0x9E3A08", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x9E3698", Offset = "0x9E3698", VA = "0x9E3698")]
			[DebuggerHidden]
			public <PlaySoundAndWaitUntilFinished>d__239(int <>1__state)
			{
			}

			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x9E36C4", Offset = "0x9E36C4", VA = "0x9E36C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x9E36C8", Offset = "0x9E36C8", VA = "0x9E36C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004BB")]
			[Address(RVA = "0x9E39C8", Offset = "0x9E39C8", VA = "0x9E39C8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE1C", Offset = "0x44AE1C")]
		private sealed class <>c__DisplayClass240_0
		{
			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60004BD")]
			[Address(RVA = "0x9E2A6C", Offset = "0x9E2A6C", VA = "0x9E2A6C")]
			public <>c__DisplayClass240_0()
			{
			}

			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x9E2A74", Offset = "0x9E2A74", VA = "0x9E2A74")]
			internal void <PlaySound3DAtTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000F1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE2C", Offset = "0x44AE2C")]
		private sealed class <PlaySound3DAtTransformAndWaitUntilFinished>d__240 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass240_0 <>8__1;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004C2")]
				[Address(RVA = "0x9E32B4", Offset = "0x9E32B4", VA = "0x9E32B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004C4")]
				[Address(RVA = "0x9E32FC", Offset = "0x9E32FC", VA = "0x9E32FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x9E2F5C", Offset = "0x9E2F5C", VA = "0x9E2F5C")]
			[DebuggerHidden]
			public <PlaySound3DAtTransformAndWaitUntilFinished>d__240(int <>1__state)
			{
			}

			[Token(Token = "0x60004C0")]
			[Address(RVA = "0x9E2F88", Offset = "0x9E2F88", VA = "0x9E2F88", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x9E2F8C", Offset = "0x9E2F8C", VA = "0x9E2F8C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x9E32BC", Offset = "0x9E32BC", VA = "0x9E32BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE3C", Offset = "0x44AE3C")]
		private sealed class <>c__DisplayClass241_0
		{
			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool done;

			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x9E2A80", Offset = "0x9E2A80", VA = "0x9E2A80")]
			public <>c__DisplayClass241_0()
			{
			}

			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x9E2A88", Offset = "0x9E2A88", VA = "0x9E2A88")]
			internal void <PlaySound3DFollowTransformAndWaitUntilFinished>b__0()
			{
			}
		}

		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE4C", Offset = "0x44AE4C")]
		private sealed class <PlaySound3DFollowTransformAndWaitUntilFinished>d__241 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string sType;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform sourceTrans;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float volumePercentage;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float? pitch;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float delaySoundTime;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string variationName;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public double? timeToSchedulePlay;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private <>c__DisplayClass241_0 <>8__1;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Action completedAction;

			[Token(Token = "0x170000B8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004CA")]
				[Address(RVA = "0x9E3648", Offset = "0x9E3648", VA = "0x9E3648", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004CC")]
				[Address(RVA = "0x9E3690", Offset = "0x9E3690", VA = "0x9E3690", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x9E3304", Offset = "0x9E3304", VA = "0x9E3304")]
			[DebuggerHidden]
			public <PlaySound3DFollowTransformAndWaitUntilFinished>d__241(int <>1__state)
			{
			}

			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x9E3330", Offset = "0x9E3330", VA = "0x9E3330", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004C9")]
			[Address(RVA = "0x9E3334", Offset = "0x9E3334", VA = "0x9E3334", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x9E3650", Offset = "0x9E3650", VA = "0x9E3650", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE5C", Offset = "0x44AE5C")]
		private sealed class <>c__DisplayClass274_0
		{
			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x9E2A94", Offset = "0x9E2A94", VA = "0x9E2A94")]
			public <>c__DisplayClass274_0()
			{
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x9E2A9C", Offset = "0x9E2A9C", VA = "0x9E2A9C")]
			internal bool <RouteGroupToBus>b__1(GroupBus x)
			{
				return default(bool);
			}

			[Token(Token = "0x60004CF")]
			[Address(RVA = "0x9E2AC0", Offset = "0x9E2AC0", VA = "0x9E2AC0")]
			internal bool <RouteGroupToBus>b__0(GroupBus x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE6C", Offset = "0x44AE6C")]
		private sealed class <>c__DisplayClass282_0
		{
			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x9E2AE4", Offset = "0x9E2AE4", VA = "0x9E2AE4")]
			public <>c__DisplayClass282_0()
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x9E2AEC", Offset = "0x9E2AEC", VA = "0x9E2AEC")]
			internal bool <FadeSoundGroupToVolume>b__0(GroupFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE7C", Offset = "0x44AE7C")]
		private sealed class <>c__DisplayClass285_0
		{
			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string sType;

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x9E2B10", Offset = "0x9E2B10", VA = "0x9E2B10")]
			public <>c__DisplayClass285_0()
			{
			}

			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x9E2B18", Offset = "0x9E2B18", VA = "0x9E2B18")]
			internal bool <GlideSoundGroupByPitch>b__0(GroupPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE8C", Offset = "0x44AE8C")]
		private sealed class <>c__DisplayClass337_0
		{
			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x9E2B3C", Offset = "0x9E2B3C", VA = "0x9E2B3C")]
			public <>c__DisplayClass337_0()
			{
			}

			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x9E2B44", Offset = "0x9E2B44", VA = "0x9E2B44")]
			internal bool <CreateBus>b__0(GroupBus obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AE9C", Offset = "0x44AE9C")]
		private sealed class <>c__DisplayClass341_0
		{
			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x9E2B68", Offset = "0x9E2B68", VA = "0x9E2B68")]
			public <>c__DisplayClass341_0()
			{
			}

			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x9E2B70", Offset = "0x9E2B70", VA = "0x9E2B70")]
			internal bool <FadeBusToVolume>b__0(BusFadeInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000F9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AEAC", Offset = "0x44AEAC")]
		private sealed class <>c__DisplayClass344_0
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string busName;

			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x9E2B94", Offset = "0x9E2B94", VA = "0x9E2B94")]
			public <>c__DisplayClass344_0()
			{
			}

			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x9E2B9C", Offset = "0x9E2B9C", VA = "0x9E2B9C")]
			internal bool <GlideBusByPitch>b__0(BusPitchGlideInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AEBC", Offset = "0x44AEBC")]
		private sealed class <>c__DisplayClass423_0
		{
			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string categoryName;

			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x9E2BC0", Offset = "0x9E2BC0", VA = "0x9E2BC0")]
			public <>c__DisplayClass423_0()
			{
			}

			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x9E2BC8", Offset = "0x9E2BC8", VA = "0x9E2BC8")]
			internal bool <CreateCustomEventCategoryIfNotThere>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AECC", Offset = "0x44AECC")]
		private sealed class <>c__DisplayClass424_0
		{
			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x9E2BEC", Offset = "0x9E2BEC", VA = "0x9E2BEC")]
			public <>c__DisplayClass424_0()
			{
			}

			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x9E2BF4", Offset = "0x9E2BF4", VA = "0x9E2BF4")]
			internal bool <CreateCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AEDC", Offset = "0x44AEDC")]
		private sealed class <>c__DisplayClass425_0
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x9E2C18", Offset = "0x9E2C18", VA = "0x9E2C18")]
			public <>c__DisplayClass425_0()
			{
			}

			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x9E2C20", Offset = "0x9E2C20", VA = "0x9E2C20")]
			internal bool <DeleteCustomEvent>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AEEC", Offset = "0x44AEEC")]
		private sealed class <>c__DisplayClass426_0
		{
			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x9E2C44", Offset = "0x9E2C44", VA = "0x9E2C44")]
			public <>c__DisplayClass426_0()
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x9E2C4C", Offset = "0x9E2C4C", VA = "0x9E2C4C")]
			internal bool <GetCustomEventByName>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AEFC", Offset = "0x44AEFC")]
		private sealed class <>c__DisplayClass428_0
		{
			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string customEventName;

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x9E2C70", Offset = "0x9E2C70", VA = "0x9E2C70")]
			public <>c__DisplayClass428_0()
			{
			}

			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x9E2C78", Offset = "0x9E2C78", VA = "0x9E2C78")]
			internal bool <CustomEventExists>b__0(CustomEvent obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF0C", Offset = "0x44AF0C")]
		private sealed class <>c__DisplayClass429_0
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x9E2C9C", Offset = "0x9E2C9C", VA = "0x9E2C9C")]
			public <>c__DisplayClass429_0()
			{
			}

			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x9E2CA4", Offset = "0x9E2CA4", VA = "0x9E2CA4")]
			internal bool <GetChildReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF1C", Offset = "0x44AF1C")]
		private sealed class <>c__DisplayClass430_0
		{
			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string eventName;

			[Token(Token = "0x60004E6")]
			[Address(RVA = "0x9E2D70", Offset = "0x9E2D70", VA = "0x9E2D70")]
			public <>c__DisplayClass430_0()
			{
			}

			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x9E2D78", Offset = "0x9E2D78", VA = "0x9E2D78")]
			internal bool <GetParentReceivers>b__0(ICustomEventReceiver rec)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF2C", Offset = "0x44AF2C")]
		private sealed class <>c__DisplayClass445_0
		{
			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x9E2E44", Offset = "0x9E2E44", VA = "0x9E2E44")]
			public <>c__DisplayClass445_0()
			{
			}

			[Token(Token = "0x60004E9")]
			[Address(RVA = "0x9E2E4C", Offset = "0x9E2E4C", VA = "0x9E2E4C")]
			internal bool <SetupAmbientNextFrame>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF3C", Offset = "0x44AF3C")]
		private sealed class <>c__DisplayClass446_0
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AmbientSound ambient;

			[Token(Token = "0x60004EA")]
			[Address(RVA = "0x9E2ED0", Offset = "0x9E2ED0", VA = "0x9E2ED0")]
			public <>c__DisplayClass446_0()
			{
			}

			[Token(Token = "0x60004EB")]
			[Address(RVA = "0x9E2ED8", Offset = "0x9E2ED8", VA = "0x9E2ED8")]
			internal bool <RemoveDelayedAmbient>b__0(AmbientSoundToTriggerInfo obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400053F")]
		public const string MasterAudioDefaultFolder = "Assets/Plugins/DarkTonic/MasterAudio";

		[Token(Token = "0x4000540")]
		public const string PreviewText = "Random delay, custom fading & start/end position settings are ignored by preview in edit mode.";

		[Token(Token = "0x4000541")]
		public const string LoopDisabledLoopedChain = "Loop Clip is always OFF for Looped Chain Groups";

		[Token(Token = "0x4000542")]
		public const string LoopDisabledCustomEnd = "Loop Clip is always OFF when using Custom End Position";

		[Token(Token = "0x4000543")]
		public const string DragAudioTip = "Drag Audio clips or a folder containing some here";

		[Token(Token = "0x4000544")]
		public const string NoCategory = "[Uncategorized]";

		[Token(Token = "0x4000545")]
		public const float SemiTonePitchFactor = 1.05946f;

		[Token(Token = "0x4000546")]
		public const float SpatialBlend_2DValue = 0f;

		[Token(Token = "0x4000547")]
		public const float SpatialBlend_3DValue = 1f;

		[Token(Token = "0x4000548")]
		public const float MaxCrossFadeTimeSeconds = 120f;

		[Token(Token = "0x4000549")]
		public const float DefaultDuckVolCut = -6f;

		[Token(Token = "0x400054A")]
		public const int ERROR_MA_LAYER_COLLISIONS_DISABLED = 1;

		[Token(Token = "0x400054B")]
		public const int PHYSICS_DISABLED = 2;

		[Token(Token = "0x400054C")]
		public const string StoredLanguageNameKey = "~MA_Language_Key~";

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly YieldInstruction EndOfFrameDelay;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly List<string> ExemptChildNames;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly HashSet<int> ErrorNumbersLogged;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Action NumberOfAudioSourcesChanged;

		[Token(Token = "0x4000551")]
		public const int HardCodedBusOptions = 2;

		[Token(Token = "0x4000552")]
		public const string AllBusesName = "[All]";

		[Token(Token = "0x4000553")]
		public const string NoGroupName = "[None]";

		[Token(Token = "0x4000554")]
		public const string DynamicGroupName = "[Type In]";

		[Token(Token = "0x4000555")]
		public const string NoPlaylistName = "[No Playlist]";

		[Token(Token = "0x4000556")]
		public const string NoVoiceLimitName = "[NO LMT]";

		[Token(Token = "0x4000557")]
		public const string OnlyPlaylistControllerName = "~only~";

		[Token(Token = "0x4000558")]
		public const float InnerLoopCheckInterval = 0.1f;

		[Token(Token = "0x4000559")]
		private const int MaxComponents = 20;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioLocation bulkLocationMode;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string groupTemplateName;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool showGroupCreation;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool useGroupTemplates;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<GameObject> groupTemplates;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool mixerMuted;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool playlistsMuted;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public LanguageMode langMode;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SystemLanguage testLanguage;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public SystemLanguage defaultLanguage;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SystemLanguage> supportedLanguages;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string busFilter;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useTextGroupFilter;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string textGroupFilter;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool resourceClipsPauseDoNotUnload;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform playlistControllerPrefab;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool persistBetweenScenes;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		public bool shouldLogDestroys;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
		public bool showBusColors;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
		public bool areGroupsExpanded;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform soundGroupTemplate;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Transform soundGroupVariationTemplate;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool groupByBus;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool sortAlpha;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA")]
		public bool showRangeSoundGizmos;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB")]
		public bool showSelectedRangeSoundGizmos;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Color rangeGizmoColor;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public Color selectedRangeGizmoColor;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public bool showAdvancedSettings;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		public bool showLocalization;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		public bool playListExpanded;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCF")]
		public bool playlistsExpanded;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public AllMusicSpatialBlendType musicSpatialBlendType;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float musicSpatialBlend;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public AllMixerSpatialBlendType mixerSpatialBlendType;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float mixerSpatialBlend;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public ItemSpatialBlendType newGroupSpatialType;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float newGroupSpatialBlend;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public List<Playlist> musicPlaylists;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float _masterAudioVolume;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public bool vrSettingsExpanded;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF5")]
		public bool useSpatializer;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF6")]
		public bool useSpatializerPostFX;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF7")]
		public bool addOculusAudioSources;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool addResonanceAudioSources;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool ignoreTimeScale;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		public bool useGaplessPlaylists;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		public bool saveRuntimeChanges;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		public bool prioritizeOnDistance;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public int rePrioritizeEverySecIndex;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public bool useOcclusion;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float occlusionMaxCutoffFreq;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float occlusionMinCutoffFreq;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float occlusionFreqChangeSeconds;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public OcclusionSelectionType occlusionSelectType;

		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public int occlusionMaxRayCastsPerFrame;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		public float occlusionRayCastOffset;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public bool occlusionUseLayerMask;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		public LayerMask occlusionLayerMask;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		public bool occlusionShowRaycasts;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		public bool occlusionShowCategories;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		public RaycastMode occlusionRaycastMode;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public bool occlusionIncludeStartRaycast2DCollider;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x131")]
		public bool occlusionRaycastsHitTriggers;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x132")]
		public bool ambientAdvancedExpanded;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		public int ambientMaxRecalcsPerFrame;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public bool visualAdvancedExpanded;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
		public bool logAdvancedExpanded;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
		public bool listenerAdvancedExpanded;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13B")]
		public bool listenerFollowerHasRigidBody;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		public VariationFollowerType variationFollowerType;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public bool showFadingSettings;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x141")]
		public bool stopZeroVolumeGroups;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x142")]
		public bool stopZeroVolumeBuses;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x143")]
		public bool stopZeroVolumePlaylists;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public float stopOldestBusFadeTime;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public bool resourceAdvancedExpanded;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
		public bool useClipAgePriority;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14A")]
		public bool logOutOfVoices;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14B")]
		public bool LogSounds;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		public bool logCustomEvents;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14D")]
		public bool disableLogging;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14E")]
		public bool showMusicDucking;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14F")]
		public bool enableMusicDucking;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float defaultRiseVolStart;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		public float defaultUnduckTime;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public float defaultDuckedVolumeCut;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		public float crossFadeTime;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public float _masterPlaylistVolume;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		public bool showGroupSelect;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16D")]
		public bool hideGroupsWithNoActiveVars;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16E")]
		public bool logPerfExpanded;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16F")]
		public bool willWarm;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public string newEventName;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public bool showCustomEvents;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Dictionary<string, DuckGroupInfo> duckingBySoundType;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public int frames;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly PlaySoundResult AndForgetSuccessResult;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly PlaySoundResult failedResultDuringInit;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<string, AudioGroupInfo> AudioSourcesBySoundType;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Dictionary<string, List<int>> _randomizer;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Dictionary<string, List<int>> _randomizerOrigin;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Dictionary<string, List<int>> _randomizerLeftovers;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Dictionary<string, List<int>> _clipsPlayedBySoundTypeOldestFirst;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private readonly List<SoundGroupVariationUpdater> ActiveVariationUpdaters;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private readonly List<SoundGroupVariationUpdater> ActiveUpdatersToRemove;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly List<CustomEventCandidate> ValidReceivers;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly List<MasterAudioGroup> SoloedGroups;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly List<AmbientSoundToTriggerInfo> AmbientsToDelayedTrigger;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly Queue<CustomEventToFireInfo> CustomEventsToFire;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly Queue<TransformFollower> TransFollowerColliderPositionRecalcs;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private readonly List<TransformFollower> ProcessedColliderPositionRecalcs;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly List<BusFadeInfo> BusFades;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly List<GroupFadeInfo> GroupFades;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly List<GroupPitchGlideInfo> GroupPitchGlides;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly List<BusPitchGlideInfo> BusPitchGlides;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly List<OcclusionFreqChangeInfo> VariationOcclusionFreqChanges;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly List<AudioSource> AllAudioSources;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly Dictionary<string, Dictionary<ICustomEventReceiver, Transform>> ReceiversByEventName;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private readonly Dictionary<string, PlaylistController> PlaylistControllersByName;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private readonly Dictionary<string, SoundGroupRefillInfo> LastTimeSoundGroupPlayed;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly List<GameObject> OcclusionSourcesInRange;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private readonly List<GameObject> OcclusionSourcesOutOfRange;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private readonly List<GameObject> OcclusionSourcesBlocked;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private readonly Queue<SoundGroupVariationUpdater> QueuedOcclusionRays;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private readonly List<SoundGroupVariation> VariationsStartedDuringMultiStop;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private bool _isStoppingMultiple;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28C")]
		private float _repriTime;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private List<string> _groupsToRemove;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private bool _mustRescanGroups;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Transform _trans;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private bool _soundsLoaded;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A9")]
		private bool _warming;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static MasterAudio _instance;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static string _prospectiveMAFolder;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Transform _listenerTrans;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoGroupSelector;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly List<SoundGroupCommand> GroupCommandsWithNoAllGroupSelector;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C010", Offset = "0x44C010")]
		private static bool <AppIsShuttingDown>k__BackingField;

		[Token(Token = "0x17000090")]
		public static float PlaylistMasterVolume
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x5F782C", Offset = "0x5F782C", VA = "0x5F782C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x5F7894", Offset = "0x5F7894", VA = "0x5F7894")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public static bool LogSoundsEnabled
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x5F9030", Offset = "0x5F9030", VA = "0x5F9030")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x5F9098", Offset = "0x5F9098", VA = "0x5F9098")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public static bool LogOutOfVoices
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x5E40A4", Offset = "0x5E40A4", VA = "0x5E40A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x5F9108", Offset = "0x5F9108", VA = "0x5F9108")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public static List<AudioSource> MasterAudioSources
		{
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x5FA794", Offset = "0x5FA794", VA = "0x5FA794")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		public static Transform ListenerTrans
		{
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x5DD8AC", Offset = "0x5DD8AC", VA = "0x5DD8AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000095")]
		public static PlaylistController OnlyPlaylistController
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x5FA8F4", Offset = "0x5FA8F4", VA = "0x5FA8F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public static bool IsWarming
		{
			[Token(Token = "0x6000478")]
			[Address(RVA = "0x5E3F8C", Offset = "0x5E3F8C", VA = "0x5E3F8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000097")]
		public static bool MixerMuted
		{
			[Token(Token = "0x6000479")]
			[Address(RVA = "0x5FA9AC", Offset = "0x5FA9AC", VA = "0x5FA9AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047A")]
			[Address(RVA = "0x5F0528", Offset = "0x5F0528", VA = "0x5F0528")]
			set
			{
			}
		}

		[Token(Token = "0x17000098")]
		public static bool PlaylistsMuted
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x5FAA14", Offset = "0x5FAA14", VA = "0x5FAA14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x5F4474", Offset = "0x5F4474", VA = "0x5F4474")]
			set
			{
			}
		}

		[Token(Token = "0x17000099")]
		public bool EnableMusicDucking
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x5FAA7C", Offset = "0x5FAA7C", VA = "0x5FAA7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x5FAA84", Offset = "0x5FAA84", VA = "0x5FAA84")]
			set
			{
			}
		}

		[Token(Token = "0x1700009A")]
		public float MasterCrossFadeTime
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x5FAA90", Offset = "0x5FAA90", VA = "0x5FAA90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009B")]
		public static List<Playlist> MusicPlaylists
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x5F3EAC", Offset = "0x5F3EAC", VA = "0x5F3EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		public static List<GroupBus> GroupBuses
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x5EA840", Offset = "0x5EA840", VA = "0x5EA840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009D")]
		public static List<string> RuntimeSoundGroupNames
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x5FAA98", Offset = "0x5FAA98", VA = "0x5FAA98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		public static List<string> RuntimeBusNames
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x5FABAC", Offset = "0x5FABAC", VA = "0x5FABAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009F")]
		public static MasterAudio SafeInstance
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x5DAA70", Offset = "0x5DAA70", VA = "0x5DAA70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		public static MasterAudio Instance
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x5D868C", Offset = "0x5D868C", VA = "0x5D868C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x5FAD20", Offset = "0x5FAD20", VA = "0x5FAD20")]
			set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public static bool SoundsReady
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x5E1738", Offset = "0x5E1738", VA = "0x5E1738")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A2")]
		public static bool AppIsShuttingDown
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x5FAD88", Offset = "0x5FAD88", VA = "0x5FAD88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CF14", Offset = "0x44CF14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x5FADEC", Offset = "0x5FADEC", VA = "0x5FADEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CF24", Offset = "0x44CF24")]
			set
			{
			}
		}

		[Token(Token = "0x170000A3")]
		public List<string> GroupNames
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x5FAE58", Offset = "0x5FAE58", VA = "0x5FAE58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		public static List<string> SoundGroupHardCodedNames
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x5FB218", Offset = "0x5FB218", VA = "0x5FB218")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A5")]
		public List<string> BusNames
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x5FB2E8", Offset = "0x5FB2E8", VA = "0x5FB2E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		public List<string> PlaylistNames
		{
			[Token(Token = "0x600048D")]
			[Address(RVA = "0x5FB438", Offset = "0x5FB438", VA = "0x5FB438")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public List<string> PlaylistNamesOnly
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x5FB588", Offset = "0x5FB588", VA = "0x5FB588")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public Transform Trans
		{
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x5DDAC0", Offset = "0x5DDAC0", VA = "0x5DDAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0x5FB6A0", Offset = "0x5FB6A0", VA = "0x5FB6A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public List<string> CustomEventNames
		{
			[Token(Token = "0x6000491")]
			[Address(RVA = "0x5FB6A8", Offset = "0x5FB6A8", VA = "0x5FB6A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AB")]
		public List<string> CustomEventNamesOnly
		{
			[Token(Token = "0x6000492")]
			[Address(RVA = "0x5FB878", Offset = "0x5FB878", VA = "0x5FB878")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		public static List<string> CustomEventHardCodedNames
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x5FB7A8", Offset = "0x5FB7A8", VA = "0x5FB7A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AD")]
		public static float MasterVolumeLevel
		{
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x5FB9C0", Offset = "0x5FB9C0", VA = "0x5FB9C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000495")]
			[Address(RVA = "0x5FBA28", Offset = "0x5FBA28", VA = "0x5FBA28")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		private static bool SceneHasMasterAudio
		{
			[Token(Token = "0x6000496")]
			[Address(RVA = "0x5E169C", Offset = "0x5E169C", VA = "0x5E169C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AF")]
		public static bool IgnoreTimeScale
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x5FBB9C", Offset = "0x5FBB9C", VA = "0x5FBB9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B0")]
		public static SystemLanguage DynamicLanguage
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x5FBC04", Offset = "0x5FBC04", VA = "0x5FBC04")]
			get
			{
				return default(SystemLanguage);
			}
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x5FBDB4", Offset = "0x5FBDB4", VA = "0x5FBDB4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public static float ReprioritizeTime
		{
			[Token(Token = "0x600049A")]
			[Address(RVA = "0x5FBE90", Offset = "0x5FBE90", VA = "0x5FBE90")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000B2")]
		public static bool ShouldRescanGroups
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x5FBFD4", Offset = "0x5FBFD4", VA = "0x5FBFD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B3")]
		public static string ProspectiveMAPath
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0x5FC0B0", Offset = "0x5FC0B0", VA = "0x5FC0B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600049F")]
			[Address(RVA = "0x5FC114", Offset = "0x5FC114", VA = "0x5FC114")]
			set
			{
			}
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x5DBC4C", Offset = "0x5DBC4C", VA = "0x5DBC4C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x44CDE0", Offset = "0x44CDE0")]
		private static void Init()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x5DBCE8", Offset = "0x5DBCE8", VA = "0x5DBCE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x5DE148", Offset = "0x5DE148", VA = "0x5DE148")]
		private void Start()
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x5DE2F0", Offset = "0x5DE2F0", VA = "0x5DE2F0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x5DE5DC", Offset = "0x5DE5DC", VA = "0x5DE5DC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x5DFCF8", Offset = "0x5DFCF8", VA = "0x5DFCF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x5DFDA0", Offset = "0x5DFDA0", VA = "0x5DFDA0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x5DFD08", Offset = "0x5DFD08", VA = "0x5DFD08")]
		private void ManualUpdate()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x5DDE38", Offset = "0x5DDE38", VA = "0x5DDE38")]
		public string SoundGroupForWarming()
		{
			return null;
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x5E02A8", Offset = "0x5E02A8", VA = "0x5E02A8")]
		public static void RegisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x5E038C", Offset = "0x5E038C", VA = "0x5E038C")]
		public static void UnregisterUpdaterForUpdates(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x5E00E8", Offset = "0x5E00E8", VA = "0x5E00E8")]
		private void UpdateActiveVariations()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x5E0418", Offset = "0x5E0418", VA = "0x5E0418")]
		private static void UpdateRefillTime(string sType, float inactivePeriodSeconds)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x5DFDB4", Offset = "0x5DFDB4", VA = "0x5DFDB4")]
		private static void RecalcClosestColliderPositions()
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x5DFC18", Offset = "0x5DFC18", VA = "0x5DFC18")]
		private static void FireCustomEventsWaiting()
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x5DF8E8", Offset = "0x5DF8E8", VA = "0x5DF8E8")]
		private static void RefillInactiveGroupPools()
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5DE670", Offset = "0x5DE670", VA = "0x5DE670")]
		private static void PerformOcclusionFrequencyChanges()
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x5DE9DC", Offset = "0x5DE9DC", VA = "0x5DE9DC")]
		private void PerformBusFades()
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x5DEF50", Offset = "0x5DEF50", VA = "0x5DEF50")]
		private void PerformGroupFades()
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x5DF528", Offset = "0x5DF528", VA = "0x5DF528")]
		public static void PerformDelayedAmbientTriggers()
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x5DF314", Offset = "0x5DF314", VA = "0x5DF314")]
		private void PerformGroupPitchGlides()
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x5DED40", Offset = "0x5DED40", VA = "0x5DED40")]
		private void PerformBusPitchGlides()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5E1430", Offset = "0x5E1430", VA = "0x5E1430")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x5E14D0", Offset = "0x5E14D0", VA = "0x5E14D0")]
		public static bool PlaySoundAndForget(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x5D6B04", Offset = "0x5D6B04", VA = "0x5D6B04")]
		public static PlaySoundResult PlaySound(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x5E328C", Offset = "0x5E328C", VA = "0x5E328C")]
		public static bool PlaySound3DAtVector3AndForget(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x5E3450", Offset = "0x5E3450", VA = "0x5E3450")]
		public static PlaySoundResult PlaySound3DAtVector3(string sType, Vector3 sourcePosition, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return null;
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x5E363C", Offset = "0x5E363C", VA = "0x5E363C")]
		public static bool PlaySound3DAtTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x5D66D4", Offset = "0x5D66D4", VA = "0x5D66D4")]
		public static PlaySoundResult PlaySound3DAtTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x5E3814", Offset = "0x5E3814", VA = "0x5E3814")]
		public static bool PlaySound3DFollowTransformAndForget(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay)
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x5D68EC", Offset = "0x5D68EC", VA = "0x5D68EC")]
		public static PlaySoundResult PlaySound3DFollowTransform(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5E39EC", Offset = "0x5E39EC", VA = "0x5E39EC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CDF4", Offset = "0x44CDF4")]
		public static IEnumerator PlaySoundAndWaitUntilFinished(string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5E3ABC", Offset = "0x5E3ABC", VA = "0x5E3ABC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CE54", Offset = "0x44CE54")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5E3BB4", Offset = "0x5E3BB4", VA = "0x5E3BB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44CEB4", Offset = "0x44CEB4")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(string sType, Transform sourceTrans, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x5E3268", Offset = "0x5E3268", VA = "0x5E3268")]
		public static bool PSRAsSuccessBool(PlaySoundResult psr)
		{
			return default(bool);
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x5E1814", Offset = "0x5E1814", VA = "0x5E1814")]
		private static PlaySoundResult PlaySoundAtVolume(string sType, float volumePercentage, Vector3 sourcePosition, double? timeToSchedulePlay, [Optional] float? pitch, [Optional] Transform sourceTrans, [Optional] string variationName, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, bool isChaining = false, bool isSingleSubscribedPlay = false, bool triggeredAsChildGroup = false)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5E4648", Offset = "0x5E4648", VA = "0x5E4648")]
		private static void MaybeChainNextVar(bool isChaining, SoundGroupVariation variation, float volumePercentage, float? pitch, Transform sourceTrans, bool attachToSource)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x5E4068", Offset = "0x5E4068", VA = "0x5E4068")]
		private static void SetLastPlayed(AudioGroupInfo grp)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x5E43F0", Offset = "0x5E43F0", VA = "0x5E43F0")]
		private static void RemoveClipAndRefillIfEmpty(AudioGroupInfo grp, bool isNonSpecific, int? randomIndex, List<int> choices, string sType, int pickedChoice, bool loggingEnabledForGrp, bool isSingleVarLoop)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x5E4900", Offset = "0x5E4900", VA = "0x5E4900")]
		private static PlaySoundResult PlaySoundIfAvailable(AudioInfo info, Vector3 sourcePosition, float volumePercentage, ref bool forgetSoundPlayed, [Optional] float? pitch, [Optional] AudioGroupInfo audioGroup, [Optional] Transform sourceTrans, bool attachToSource = false, float delaySoundTime = 0f, bool useVector3 = false, bool makePlaySoundResult = false, [Optional] double? timeToSchedulePlay, bool isChaining = false, bool isSingleSubscribedPlay = false)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5E5034", Offset = "0x5E5034", VA = "0x5E5034")]
		public static void DuckSoundGroup(string soundGroupName, AudioSource aSource)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5E521C", Offset = "0x5E521C", VA = "0x5E521C")]
		private static void StopPauseOrUnpauseSoundsOfTransform(Transform trans, List<AudioInfo> varList, VariationCommand varCmd)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5E56BC", Offset = "0x5E56BC", VA = "0x5E56BC")]
		public static void StopAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5E5974", Offset = "0x5E5974", VA = "0x5E5974")]
		public static void StopSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x5E5B64", Offset = "0x5E5B64", VA = "0x5E5B64")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x5E5DBC", Offset = "0x5E5DBC", VA = "0x5E5DBC")]
		public static void PauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5E5FAC", Offset = "0x5E5FAC", VA = "0x5E5FAC")]
		public static void UnpauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5E6204", Offset = "0x5E6204", VA = "0x5E6204")]
		public static void UnpauseSoundGroupOfTransform(Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x5E63F4", Offset = "0x5E63F4", VA = "0x5E63F4")]
		public static void FadeOutAllSoundsOfTransform(Transform sourceTrans, float fadeTime)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x5E6978", Offset = "0x5E6978", VA = "0x5E6978")]
		public static void FadeOutSoundGroupOfTransform(Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5E0F1C", Offset = "0x5E0F1C", VA = "0x5E0F1C")]
		public static void StopAllOfSound(string sType)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5E467C", Offset = "0x5E467C", VA = "0x5E467C")]
		public static void FadeOutAllOfSound(string sType, float fadeTime)
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5E6CAC", Offset = "0x5E6CAC", VA = "0x5E6CAC")]
		public static List<SoundGroupVariation> GetAllPlayingVariations()
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x5E6610", Offset = "0x5E6610", VA = "0x5E6610")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x5E6FA4", Offset = "0x5E6FA4", VA = "0x5E6FA4")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransformList(List<Transform> sourceTransList)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5E7384", Offset = "0x5E7384", VA = "0x5E7384")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsInBus(string busName)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x5E75BC", Offset = "0x5E75BC", VA = "0x5E75BC")]
		public static void DeleteGroupVariation(string sType, string variationName)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x5E8444", Offset = "0x5E8444", VA = "0x5E8444")]
		public static void CreateGroupVariationFromClip(string sType, AudioClip clip, string variationName, float volume = 1f, float pitch = 1f)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x5E8B0C", Offset = "0x5E8B0C", VA = "0x5E8B0C")]
		public static void ChangeVariationPitch(string sType, bool changeAllVariations, string variationName, float pitch)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x5E8ED0", Offset = "0x5E8ED0", VA = "0x5E8ED0")]
		public static void ChangeVariationVolume(string sType, bool changeAllVariations, string variationName, float volume)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x5E9220", Offset = "0x5E9220", VA = "0x5E9220")]
		public static void ChangeVariationClipFromResources(string sType, bool changeAllVariations, string variationName, string resourceFileName)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x5E9414", Offset = "0x5E9414", VA = "0x5E9414")]
		public static void ChangeVariationClip(string sType, bool changeAllVariations, string variationName, AudioClip clip)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x5E96E8", Offset = "0x5E96E8", VA = "0x5E96E8")]
		public static void GradualOcclusionFreqChange(SoundGroupVariation variation, float fadeTime, float newCutoffFreq)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x5E99FC", Offset = "0x5E99FC", VA = "0x5E99FC")]
		public static AudioSource GetNextVariationForSoundGroup(string sType)
		{
			return null;
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x5E9D54", Offset = "0x5E9D54", VA = "0x5E9D54")]
		public static bool IsSoundGroupPlaying(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x5E9E90", Offset = "0x5E9E90", VA = "0x5E9E90")]
		public static bool IsTransformPlayingSoundGroup(string sType, Transform sourceTrans)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x5EA0A0", Offset = "0x5EA0A0", VA = "0x5EA0A0")]
		public static void RouteGroupToBus(string sType, string busName)
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x5EAD50", Offset = "0x5EAD50", VA = "0x5EAD50")]
		public static float GetVariationLength(string sType, string variationName)
		{
			return default(float);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x5E05B8", Offset = "0x5E05B8", VA = "0x5E05B8")]
		public static void RefillSoundGroupPool(string sType)
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x5EB54C", Offset = "0x5EB54C", VA = "0x5EB54C")]
		public static bool SoundGroupExists(string sType)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x5EB5F4", Offset = "0x5EB5F4", VA = "0x5EB5F4")]
		public static void PauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x5EB76C", Offset = "0x5EB76C", VA = "0x5EB76C")]
		public static void SetGroupSpatialBlend(string sType)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x5EB8E4", Offset = "0x5EB8E4", VA = "0x5EB8E4")]
		public static void RouteGroupToUnityMixerGroup(string sType, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x5EBA7C", Offset = "0x5EBA7C", VA = "0x5EBA7C")]
		public static void UnpauseSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x5EBBF4", Offset = "0x5EBBF4", VA = "0x5EBBF4")]
		public static void FadeSoundGroupToVolume(string sType, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x5EC01C", Offset = "0x5EC01C", VA = "0x5EC01C")]
		public static void FadeOutOldSoundGroupVoices(string sType, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x5EC1F8", Offset = "0x5EC1F8", VA = "0x5EC1F8")]
		public static void StopOldSoundGroupVoices(string sType, float minimumPlayTime)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x5EC3B8", Offset = "0x5EC3B8", VA = "0x5EC3B8")]
		public static void GlideSoundGroupByPitch(string sType, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x5EC974", Offset = "0x5EC974", VA = "0x5EC974")]
		public static void DeleteSoundGroup(string sType)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x5ECFEC", Offset = "0x5ECFEC", VA = "0x5ECFEC")]
		public static Transform CreateSoundGroup(DynamicSoundGroup aGroup, string creatorObjectName, bool errorOnExisting = true)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x5EE208", Offset = "0x5EE208", VA = "0x5EE208")]
		public static float GetGroupVolume(string sType)
		{
			return default(float);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x5E0C48", Offset = "0x5E0C48", VA = "0x5E0C48")]
		public static void SetGroupVolume(string sType, float volumeLevel)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x5DDFFC", Offset = "0x5DDFFC", VA = "0x5DDFFC")]
		public static void MuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x5EE3EC", Offset = "0x5EE3EC", VA = "0x5EE3EC")]
		public static void UnmuteGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x5DDB74", Offset = "0x5DDB74", VA = "0x5DDB74")]
		private static void AddRuntimeGroupInfo(string groupName, AudioGroupInfo groupInfo)
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x5EE684", Offset = "0x5EE684", VA = "0x5EE684")]
		private static void FireAudioSourcesNumberChangedEvent()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x5EE4FC", Offset = "0x5EE4FC", VA = "0x5EE4FC")]
		public static void TrackRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x5DE394", Offset = "0x5DE394", VA = "0x5DE394")]
		public static void StopTrackingRuntimeAudioSources(List<AudioSource> sources)
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x5ECD70", Offset = "0x5ECD70", VA = "0x5ECD70")]
		private static void RemoveRuntimeGroupInfo(string groupName)
		{
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x5EE728", Offset = "0x5EE728", VA = "0x5EE728")]
		private static void RescanChildren(MasterAudioGroup group)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x5EE2C8", Offset = "0x5EE2C8", VA = "0x5EE2C8")]
		private static void SetGroupMuteStatus(MasterAudioGroup aGroup, string sType, bool isMute)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x5EA950", Offset = "0x5EA950", VA = "0x5EA950")]
		public static void SoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5EAC98", Offset = "0x5EAC98", VA = "0x5EAC98")]
		public static void SilenceOrUnsilenceGroupsFromSoloChange()
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x5EEAC4", Offset = "0x5EEAC4", VA = "0x5EEAC4")]
		private static void UnsilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5EEC74", Offset = "0x5EEC74", VA = "0x5EEC74")]
		private static void UnsilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x5EE90C", Offset = "0x5EE90C", VA = "0x5EE90C")]
		private static void SilenceNonSoloedGroups()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x5EEDD0", Offset = "0x5EEDD0", VA = "0x5EEDD0")]
		private static void SilenceGroup(string sType)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x5EEF2C", Offset = "0x5EEF2C", VA = "0x5EEF2C")]
		public static void UnsoloGroup(string sType, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x5E5414", Offset = "0x5E5414", VA = "0x5E5414")]
		public static MasterAudioGroup GrabGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x5EF068", Offset = "0x5EF068", VA = "0x5EF068")]
		public static int VoicesForGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x5EF168", Offset = "0x5EF168", VA = "0x5EF168")]
		public static Transform FindGroupTransform(string sType)
		{
			return null;
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5EF380", Offset = "0x5EF380", VA = "0x5EF380")]
		public static List<AudioInfo> GetAllVariationsOfGroup(string sType, bool logIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x5EF4F8", Offset = "0x5EF4F8", VA = "0x5EF4F8")]
		public static AudioGroupInfo GetGroupInfo(string sType)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x5EF5DC", Offset = "0x5EF5DC", VA = "0x5EF5DC")]
		public static void SubscribeToLastVariationPlayed(string sType, Action finishedCallback)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x5EF760", Offset = "0x5EF760", VA = "0x5EF760")]
		public static void UnsubscribeFromLastVariationPlayed(string sType)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x5EF858", Offset = "0x5EF858", VA = "0x5EF858")]
		public void SetSpatialBlendForMixer()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5EF9B8", Offset = "0x5EF9B8", VA = "0x5EF9B8")]
		public static void PauseMixer()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5EFBB0", Offset = "0x5EFBB0", VA = "0x5EFBB0")]
		public static void UnpauseMixer()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5EFDA8", Offset = "0x5EFDA8", VA = "0x5EFDA8")]
		public static void StopMixer()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5F0000", Offset = "0x5F0000", VA = "0x5F0000")]
		public static void UnsubscribeFromAllVariations()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x5F0270", Offset = "0x5F0270", VA = "0x5F0270")]
		public static void StopEverything()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x5F0338", Offset = "0x5F0338", VA = "0x5F0338")]
		public static void PauseEverything()
		{
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x5F0400", Offset = "0x5F0400", VA = "0x5F0400")]
		public static void UnpauseEverything()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x5F04C8", Offset = "0x5F04C8", VA = "0x5F04C8")]
		public static void MuteEverything()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x5F0980", Offset = "0x5F0980", VA = "0x5F0980")]
		public static void UnmuteEverything()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5F0A4C", Offset = "0x5F0A4C", VA = "0x5F0A4C")]
		public static List<string> ListOfAudioClipsInGroupsEditTime()
		{
			return null;
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x5E1294", Offset = "0x5E1294", VA = "0x5E1294")]
		private static int GetBusIndex(string busName, bool alertMissing)
		{
			return default(int);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5EA8A8", Offset = "0x5EA8A8", VA = "0x5EA8A8")]
		private static GroupBus GetBusByIndex(int busIndex)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x5F0D18", Offset = "0x5F0D18", VA = "0x5F0D18")]
		public static void ChangeBusPitch(string busName, float pitch)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5F0ECC", Offset = "0x5F0ECC", VA = "0x5F0ECC")]
		public static void MuteBus(string busName)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x5F1364", Offset = "0x5F1364", VA = "0x5F1364")]
		public static void UnmuteBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x5F150C", Offset = "0x5F150C", VA = "0x5F150C")]
		public static void ToggleMuteBus(string busName)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5F15F8", Offset = "0x5F15F8", VA = "0x5F15F8")]
		public static void PauseBus(string busName)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5F1780", Offset = "0x5F1780", VA = "0x5F1780")]
		public static void SoloBus(string busName)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5F11BC", Offset = "0x5F11BC", VA = "0x5F11BC")]
		public static void UnsoloBus(string busName, bool shouldCheckMuteStatus = true)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x5F196C", Offset = "0x5F196C", VA = "0x5F196C")]
		public static void RouteBusToUnityMixerGroup(string busName, AudioMixerGroup mixerGroup)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x5E410C", Offset = "0x5E410C", VA = "0x5E410C")]
		private static void StopOldestSoundOnBus(GroupBus bus)
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x5E0A80", Offset = "0x5E0A80", VA = "0x5E0A80")]
		public static void StopBus(string busName)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x5F1AF0", Offset = "0x5F1AF0", VA = "0x5F1AF0")]
		public static void UnpauseBus(string busName)
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x5F1C58", Offset = "0x5F1C58", VA = "0x5F1C58")]
		public static bool CreateBus(string busName, bool errorOnExisting = true, bool isTemporary = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x5F1F44", Offset = "0x5F1F44", VA = "0x5F1F44")]
		public static void DeleteBusByName(string busName)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x5F1FE0", Offset = "0x5F1FE0", VA = "0x5F1FE0")]
		public static void DeleteBusByIndex(int busIndex)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x5E4F74", Offset = "0x5E4F74", VA = "0x5E4F74")]
		public static float GetBusVolume(MasterAudioGroup maGroup)
		{
			return default(float);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x5F24D0", Offset = "0x5F24D0", VA = "0x5F24D0")]
		public static void FadeBusToVolume(string busName, float newVolume, float fadeTime, [Optional] Action completionCallback, bool willStopAfterFade = false, bool willResetVolumeAfterFade = false)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x5F291C", Offset = "0x5F291C", VA = "0x5F291C")]
		public static void FadeOutOldBusVoices(string busName, float minimumPlayTime, float fadeTime)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x5F2B48", Offset = "0x5F2B48", VA = "0x5F2B48")]
		public static void StopOldBusVoices(string busName, float minimumPlayTime)
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x5F2D58", Offset = "0x5F2D58", VA = "0x5F2D58")]
		public static void GlideBusByPitch(string busName, float pitchAddition, float glideTime, [Optional] Action completionCallback)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x5DDD0C", Offset = "0x5DDD0C", VA = "0x5DDD0C")]
		public static void SetBusVolumeByName(string busName, float newVolume)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x5F22F8", Offset = "0x5F22F8", VA = "0x5F22F8")]
		private static void RecalculateGroupVolumes(AudioGroupInfo aGroup, GroupBus bus)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x5EAAA0", Offset = "0x5EAAA0", VA = "0x5EAAA0")]
		private static void SetBusVolume(GroupBus bus, float newVolume)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x5F10B8", Offset = "0x5F10B8", VA = "0x5F10B8")]
		public static GroupBus GrabBusByName(string busName)
		{
			return null;
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x5F3468", Offset = "0x5F3468", VA = "0x5F3468")]
		public static void PauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x5F3640", Offset = "0x5F3640", VA = "0x5F3640")]
		public static void UnpauseBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5F3818", Offset = "0x5F3818", VA = "0x5F3818")]
		public static void StopBusOfTransform(Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x5F3A50", Offset = "0x5F3A50", VA = "0x5F3A50")]
		public static void AddSoundGroupToDuckList(string sType, float riseVolumeStart, float duckedVolCut, float unduckTime, bool isTemporary = false)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x5F3BD4", Offset = "0x5F3BD4", VA = "0x5F3BD4")]
		public static void RemoveSoundGroupFromDuckList(string sType)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x5F3CF0", Offset = "0x5F3CF0", VA = "0x5F3CF0")]
		public static Playlist GrabPlaylist(string playlistName, bool logErrorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x5F3F14", Offset = "0x5F3F14", VA = "0x5F3F14")]
		public static void ChangePlaylistPitch(string playlistName, float pitch, [Optional] string songName)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x5F4044", Offset = "0x5F4044", VA = "0x5F4044")]
		public static void MutePlaylist()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x5F40B4", Offset = "0x5F40B4", VA = "0x5F40B4")]
		public static void MutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x5F0914", Offset = "0x5F0914", VA = "0x5F0914")]
		public static void MuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5F438C", Offset = "0x5F438C", VA = "0x5F438C")]
		private static void MutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x5F4568", Offset = "0x5F4568", VA = "0x5F4568")]
		public static void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x5F45D8", Offset = "0x5F45D8", VA = "0x5F45D8")]
		public static void UnmutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x5F09E0", Offset = "0x5F09E0", VA = "0x5F09E0")]
		public static void UnmuteAllPlaylists()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x5F47CC", Offset = "0x5F47CC", VA = "0x5F47CC")]
		private static void UnmutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x5F48B4", Offset = "0x5F48B4", VA = "0x5F48B4")]
		public static void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x5F4924", Offset = "0x5F4924", VA = "0x5F4924")]
		public static void ToggleMutePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x5F4BB0", Offset = "0x5F4BB0", VA = "0x5F4BB0")]
		public static void ToggleMuteAllPlaylists()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x5F4B18", Offset = "0x5F4B18", VA = "0x5F4B18")]
		private static void ToggleMutePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x5F4C1C", Offset = "0x5F4C1C", VA = "0x5F4C1C")]
		public static void PausePlaylist()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x5F4C8C", Offset = "0x5F4C8C", VA = "0x5F4C8C")]
		public static void PausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x5F0394", Offset = "0x5F0394", VA = "0x5F0394")]
		public static void PauseAllPlaylists()
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x5F4E80", Offset = "0x5F4E80", VA = "0x5F4E80")]
		private static void PausePlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x5F4F18", Offset = "0x5F4F18", VA = "0x5F4F18")]
		public static void UnpausePlaylist()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x5F4F88", Offset = "0x5F4F88", VA = "0x5F4F88")]
		public static void UnpausePlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x5F045C", Offset = "0x5F045C", VA = "0x5F045C")]
		public static void UnpauseAllPlaylists()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x5F517C", Offset = "0x5F517C", VA = "0x5F517C")]
		private static void UnpausePlaylists(List<PlaylistController> controllers)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x5F5214", Offset = "0x5F5214", VA = "0x5F5214")]
		public static void StopPlaylist()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x5F5284", Offset = "0x5F5284", VA = "0x5F5284")]
		public static void StopPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x5F02CC", Offset = "0x5F02CC", VA = "0x5F02CC")]
		public static void StopAllPlaylists()
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5F5478", Offset = "0x5F5478", VA = "0x5F5478")]
		private static void StopPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5F5514", Offset = "0x5F5514", VA = "0x5F5514")]
		public static void TriggerNextPlaylistClip()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x5F5584", Offset = "0x5F5584", VA = "0x5F5584")]
		public static void TriggerNextPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x5F5810", Offset = "0x5F5810", VA = "0x5F5810")]
		public static void TriggerNextClipAllPlaylists()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5F5778", Offset = "0x5F5778", VA = "0x5F5778")]
		private static void NextPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x5F587C", Offset = "0x5F587C", VA = "0x5F587C")]
		public static void TriggerRandomPlaylistClip()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x5F58EC", Offset = "0x5F58EC", VA = "0x5F58EC")]
		public static void TriggerRandomPlaylistClip(string playlistControllerName)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x5F5B78", Offset = "0x5F5B78", VA = "0x5F5B78")]
		public static void TriggerRandomClipAllPlaylists()
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5F5AE0", Offset = "0x5F5AE0", VA = "0x5F5AE0")]
		private static void RandomPlaylistClips(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5F5BE4", Offset = "0x5F5BE4", VA = "0x5F5BE4")]
		public static void RestartPlaylist()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x5F5C54", Offset = "0x5F5C54", VA = "0x5F5C54")]
		public static void RestartPlaylist(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x5F5EF0", Offset = "0x5F5EF0", VA = "0x5F5EF0")]
		public static void RestartAllPlaylists()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x5F5E58", Offset = "0x5F5E58", VA = "0x5F5E58")]
		private static void RestartPlaylists(List<PlaylistController> playlists)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x5F5F5C", Offset = "0x5F5F5C", VA = "0x5F5F5C")]
		public static void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x5F5FD4", Offset = "0x5F5FD4", VA = "0x5F5FD4")]
		public static void StartPlaylist(string playlistControllerName, string playlistName)
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x5F61F8", Offset = "0x5F61F8", VA = "0x5F61F8")]
		public static void StopLoopingAllCurrentSongs()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x5F62FC", Offset = "0x5F62FC", VA = "0x5F62FC")]
		public static void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x5F636C", Offset = "0x5F636C", VA = "0x5F636C")]
		public static void StopLoopingCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x5F6264", Offset = "0x5F6264", VA = "0x5F6264")]
		private static void StopLoopingCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x5F6570", Offset = "0x5F6570", VA = "0x5F6570")]
		public static void StopAllPlaylistsAfterCurrentSongs()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x5F6674", Offset = "0x5F6674", VA = "0x5F6674")]
		public static void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x5F66E4", Offset = "0x5F66E4", VA = "0x5F66E4")]
		public static void StopPlaylistAfterCurrentSong(string playlistControllerName)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5F65DC", Offset = "0x5F65DC", VA = "0x5F65DC")]
		private static void StopPlaylistAfterCurrentSongs(List<PlaylistController> playlistControllers)
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5F68E8", Offset = "0x5F68E8", VA = "0x5F68E8")]
		public static void QueuePlaylistClip(string clipName)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x5F6960", Offset = "0x5F6960", VA = "0x5F6960")]
		public static void QueuePlaylistClip(string playlistControllerName, string clipName)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x5F6B00", Offset = "0x5F6B00", VA = "0x5F6B00")]
		public static bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x5F6B78", Offset = "0x5F6B78", VA = "0x5F6B78")]
		public static bool TriggerPlaylistClip(string playlistControllerName, string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x5F6D18", Offset = "0x5F6D18", VA = "0x5F6D18")]
		public static void ChangePlaylistByName(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x5F6DA0", Offset = "0x5F6DA0", VA = "0x5F6DA0")]
		public static void ChangePlaylistByName(string playlistControllerName, string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x5F6F44", Offset = "0x5F6F44", VA = "0x5F6F44")]
		public static void FadePlaylistToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x5F6FCC", Offset = "0x5F6FCC", VA = "0x5F6FCC")]
		public static void FadePlaylistToVolume(string playlistControllerName, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x5F7340", Offset = "0x5F7340", VA = "0x5F7340")]
		public static void FadeAllPlaylistsToVolume(float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x5F71DC", Offset = "0x5F71DC", VA = "0x5F71DC")]
		private static void FadePlaylists(List<PlaylistController> playlists, float targetVolume, float fadeTime)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x5F73C4", Offset = "0x5F73C4", VA = "0x5F73C4")]
		public static void CreatePlaylist(Playlist playlist, bool errorOnDuplicate)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x5F7520", Offset = "0x5F7520", VA = "0x5F7520")]
		public static void DeletePlaylist(string playlistName)
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x5F7700", Offset = "0x5F7700", VA = "0x5F7700")]
		public static void AddSongToPlaylist(string playlistName, AudioClip song, bool loopSong = false, float songPitch = 1f, float songVolume = 1f)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x5F7978", Offset = "0x5F7978", VA = "0x5F7978")]
		public static void AudioListenerChanged(AudioListener listener)
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x5F7ACC", Offset = "0x5F7ACC", VA = "0x5F7ACC")]
		public static void FireCustomEventNextFrame(string customEventName, Transform eventOrigin)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x5DB010", Offset = "0x5DB010", VA = "0x5DB010")]
		public static void AddCustomEventReceiver(ICustomEventReceiver receiver, Transform receiverTrans)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x5DB4A4", Offset = "0x5DB4A4", VA = "0x5DB4A4")]
		public static void RemoveCustomEventReceiver(ICustomEventReceiver receiver)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x5F7D28", Offset = "0x5F7D28", VA = "0x5F7D28")]
		public static List<Transform> ReceiversForEvent(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x5F8040", Offset = "0x5F8040", VA = "0x5F8040")]
		public static CustomEventCategory CreateCustomEventCategoryIfNotThere(string categoryName, bool isTemporary)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x5F82A4", Offset = "0x5F82A4", VA = "0x5F82A4")]
		public static void CreateCustomEvent(string customEventName, CustomEventReceiveMode eventReceiveMode, float distanceThreshold, EventReceiveFilter receiveFilter, int filterModeQty, string categoryName = "", bool isTemporary = false, bool errorOnDuplicate = true)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x5F866C", Offset = "0x5F866C", VA = "0x5F866C")]
		public static void DeleteCustomEvent(string customEventName)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x5F8868", Offset = "0x5F8868", VA = "0x5F8868")]
		public static CustomEvent GetCustomEventByName(string customEventName)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x5D97E4", Offset = "0x5D97E4", VA = "0x5D97E4")]
		public static void FireCustomEvent(string customEventName, Transform originObject, bool logDupe = true)
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x5DAC8C", Offset = "0x5DAC8C", VA = "0x5DAC8C")]
		public static bool CustomEventExists(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x5F89D0", Offset = "0x5F89D0", VA = "0x5F89D0")]
		private static List<ICustomEventReceiver> GetChildReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5F8B70", Offset = "0x5F8B70", VA = "0x5F8B70")]
		private static List<ICustomEventReceiver> GetParentReceivers(Transform origin, string eventName, bool includeSelf)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x5F8D10", Offset = "0x5F8D10", VA = "0x5F8D10")]
		private static List<ICustomEventReceiver> FilterOutSelf(List<ICustomEventReceiver> sourceList, Transform origin)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x5E3D5C", Offset = "0x5E3D5C", VA = "0x5E3D5C")]
		private static bool LoggingEnabledForGroup(MasterAudioGroup grp)
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x5E3E74", Offset = "0x5E3E74", VA = "0x5E3E74")]
		private static void LogMessage(string message)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x5E3CAC", Offset = "0x5E3CAC", VA = "0x5E3CAC")]
		public static void LogWarning(string msg)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5F9178", Offset = "0x5F9178", VA = "0x5F9178")]
		public static void LogWarningIfNeverLogged(string msg, int errorNumber)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x5EA790", Offset = "0x5EA790", VA = "0x5EA790")]
		public static void LogError(string msg)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x5F92A4", Offset = "0x5F92A4", VA = "0x5F92A4")]
		public static void LogNoPlaylist(string playlistControllerName, string methodName)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5F42A8", Offset = "0x5F42A8", VA = "0x5F42A8")]
		private static bool IsOkToCallOnlyPlaylistMethod(List<PlaylistController> pcs, string methodName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5F94BC", Offset = "0x5F94BC", VA = "0x5F94BC")]
		public static void SetupAmbientNextFrame(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x5F9748", Offset = "0x5F9748", VA = "0x5F9748")]
		public static void RemoveDelayedAmbient(AmbientSound ambient)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x5F992C", Offset = "0x5F992C", VA = "0x5F992C")]
		public static void QueueTransformFollowerForColliderPositionRecalc(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x5F9B88", Offset = "0x5F9B88", VA = "0x5F9B88")]
		public static void AddToQueuedOcclusionRays(SoundGroupVariationUpdater updater)
		{
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x5F9DE4", Offset = "0x5F9DE4", VA = "0x5F9DE4")]
		public static void AddToOcclusionInRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x5F9FEC", Offset = "0x5F9FEC", VA = "0x5F9FEC")]
		public static void AddToOcclusionOutOfRangeSources(GameObject src)
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x5FA39C", Offset = "0x5FA39C", VA = "0x5FA39C")]
		public static void AddToBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x5D88B8", Offset = "0x5D88B8", VA = "0x5D88B8")]
		public static bool HasQueuedOcclusionRays()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x5D893C", Offset = "0x5D893C", VA = "0x5D893C")]
		public static SoundGroupVariationUpdater OldestQueuedOcclusionRay()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5E98B4", Offset = "0x5E98B4", VA = "0x5E98B4")]
		public static bool IsOcclusionFreqencyTransitioning(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x5E82AC", Offset = "0x5E82AC", VA = "0x5E82AC")]
		public static void RemoveFromOcclusionFrequencyTransitioning(SoundGroupVariation variation)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5FA214", Offset = "0x5FA214", VA = "0x5FA214")]
		public static void RemoveFromBlockedOcclusionSources(GameObject src)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5FA524", Offset = "0x5FA524", VA = "0x5FA524")]
		public static void StopTrackingOcclusionForSource(GameObject src)
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x5E6BE8", Offset = "0x5E6BE8", VA = "0x5E6BE8")]
		private static bool IsLinkedGroupPlay(SoundGroupVariation variation)
		{
			return default(bool);
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x5FA7FC", Offset = "0x5FA7FC", VA = "0x5FA7FC")]
		public static int RemainingClipsInGroup(string sType)
		{
			return default(int);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x5ECF80", Offset = "0x5ECF80", VA = "0x5ECF80")]
		public static void RescanGroupsNow()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x5FBF6C", Offset = "0x5FBF6C", VA = "0x5FBF6C")]
		public static void DoneRescanningGroups()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x5FC180", Offset = "0x5FC180", VA = "0x5FC180")]
		public static GameObject CreateMasterAudio()
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x5FC33C", Offset = "0x5FC33C", VA = "0x5FC33C")]
		public static GameObject CreatePlaylistController()
		{
			return null;
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x5FC4F8", Offset = "0x5FC4F8", VA = "0x5FC4F8")]
		public static GameObject CreateDynamicSoundGroupCreator()
		{
			return null;
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x5FC6B4", Offset = "0x5FC6B4", VA = "0x5FC6B4")]
		public static GameObject CreateSoundGroupOrganizer()
		{
			return null;
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x5FC870", Offset = "0x5FC870", VA = "0x5FC870")]
		public MasterAudio()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public static class PersistentAudioSettings
	{
		[Token(Token = "0x4000702")]
		public const string SfxVolKey = "MA_sfxVolume";

		[Token(Token = "0x4000703")]
		public const string MusicVolKey = "MA_musicVolume";

		[Token(Token = "0x4000704")]
		public const string SfxMuteKey = "MA_sfxMute";

		[Token(Token = "0x4000705")]
		public const string MusicMuteKey = "MA_musicMute";

		[Token(Token = "0x4000706")]
		public const string BusVolKey = "MA_BusVolume_";

		[Token(Token = "0x4000707")]
		public const string GroupVolKey = "MA_GroupVolume_";

		[Token(Token = "0x4000708")]
		public const string BusKeysKey = "MA_BusKeys";

		[Token(Token = "0x4000709")]
		public const string GroupKeysKey = "MA_GroupsKeys";

		[Token(Token = "0x400070A")]
		public const string Separator = ";";

		[Token(Token = "0x170000BA")]
		public static string BusesUpdatedKeys
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xAA6C34", Offset = "0xAA6C34", VA = "0xAA6C34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xAA6CB0", Offset = "0xAA6CB0", VA = "0xAA6CB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public static string GroupsUpdatedKeys
		{
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xAA6DE0", Offset = "0xAA6DE0", VA = "0xAA6DE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xAA6E5C", Offset = "0xAA6E5C", VA = "0xAA6E5C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static bool? MixerMuted
		{
			[Token(Token = "0x60004F6")]
			[Address(RVA = "0xAA7108", Offset = "0xAA7108", VA = "0xAA7108")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xAA71A0", Offset = "0xAA71A0", VA = "0xAA71A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000BD")]
		public static float? MixerVolume
		{
			[Token(Token = "0x60004F8")]
			[Address(RVA = "0xAA7300", Offset = "0xAA7300", VA = "0xAA7300")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0xAA7390", Offset = "0xAA7390", VA = "0xAA7390")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public static bool? MusicMuted
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0xAA74E4", Offset = "0xAA74E4", VA = "0xAA74E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xAA757C", Offset = "0xAA757C", VA = "0xAA757C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public static float? MusicVolume
		{
			[Token(Token = "0x60004FC")]
			[Address(RVA = "0xAA76DC", Offset = "0xAA76DC", VA = "0xAA76DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xAA776C", Offset = "0xAA776C", VA = "0xAA776C")]
			set
			{
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xAA6A4C", Offset = "0xAA6A4C", VA = "0xAA6A4C")]
		public static void SetBusVolume(string busName, float vol)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0xAA6BE4", Offset = "0xAA6BE4", VA = "0xAA6BE4")]
		public static string MakeBusKey(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xAA6D00", Offset = "0xAA6D00", VA = "0xAA6D00")]
		public static float? GetBusVolume(string busName)
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0xAA6D90", Offset = "0xAA6D90", VA = "0xAA6D90")]
		public static string GetGroupKey(string groupName)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xAA6EAC", Offset = "0xAA6EAC", VA = "0xAA6EAC")]
		public static void SetGroupVolume(string grpName, float vol)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0xAA7078", Offset = "0xAA7078", VA = "0xAA7078")]
		public static float? GetGroupVolume(string grpName)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xAA78C0", Offset = "0xAA78C0", VA = "0xAA78C0")]
		public static void RestoreMasterSettings()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class SoundGroupOrganizer : MonoBehaviour
	{
		[Token(Token = "0x2000105")]
		public class CustomEventSelection
		{
			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEvent Event;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000501")]
			[Address(RVA = "0x9E568C", Offset = "0x9E568C", VA = "0x9E568C")]
			public CustomEventSelection(CustomEvent cEvent, bool isSelected)
			{
			}
		}

		[Token(Token = "0x2000106")]
		public class SoundGroupSelection
		{
			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject Go;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool IsSelected;

			[Token(Token = "0x6000502")]
			[Address(RVA = "0x9E56D8", Offset = "0x9E56D8", VA = "0x9E56D8")]
			public SoundGroupSelection(GameObject go, bool isSelected)
			{
			}
		}

		[Token(Token = "0x2000107")]
		public enum MAItemType
		{
			[Token(Token = "0x4000726")]
			SoundGroups,
			[Token(Token = "0x4000727")]
			CustomEvents
		}

		[Token(Token = "0x2000108")]
		public enum TransferMode
		{
			[Token(Token = "0x4000729")]
			None,
			[Token(Token = "0x400072A")]
			Import,
			[Token(Token = "0x400072B")]
			Export
		}

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject dynGroupTemplate;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject dynVariationTemplate;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject maGroupTemplate;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject maVariationTemplate;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool useTextGroupFilter;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string textGroupFilter;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public TransferMode transMode;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public GameObject sourceObject;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<SoundGroupSelection> selectedSourceSoundGroups;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public GameObject destObject;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<SoundGroupSelection> selectedDestSoundGroups;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public MAItemType itemType;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public List<CustomEventSelection> selectedSourceCustomEvents;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<CustomEventSelection> selectedDestCustomEvents;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<CustomEvent> customEvents;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string newEventName;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xAB27DC", Offset = "0xAB27DC", VA = "0xAB27DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xAB2850", Offset = "0xAB2850", VA = "0xAB2850")]
		public SoundGroupOrganizer()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public static class AmbientUtil
	{
		[Token(Token = "0x400072C")]
		public const string FollowerHolderName = "_Followers";

		[Token(Token = "0x400072D")]
		public const string ListenerFollowerName = "~ListenerFollower~";

		[Token(Token = "0x400072E")]
		public const float ListenerFollowerTrigRadius = 0.01f;

		[Token(Token = "0x400072F")]
		public const int IgnoreRaycastLayerNumber = 2;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Transform _followerHolder;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ListenerFollower _listenerFollower;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<TransformFollower> _transformFollowers;

		[Token(Token = "0x170000C0")]
		public static ListenerFollower ListenerFollower
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x6C169C", Offset = "0x6C169C", VA = "0x6C169C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public static Transform FollowerHolder
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x6C1144", Offset = "0x6C1144", VA = "0x6C1144")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public static bool HasListenerFollower
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x6C1C04", Offset = "0x6C1C04", VA = "0x6C1C04")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C3")]
		public static bool HasListenerFolowerRigidBody
		{
			[Token(Token = "0x600050C")]
			[Address(RVA = "0x6C0FD0", Offset = "0x6C0FD0", VA = "0x6C0FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x6C1090", Offset = "0x6C1090", VA = "0x6C1090")]
		public static void InitFollowerHolder()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x6C0F28", Offset = "0x6C0F28", VA = "0x6C0F28")]
		public static bool InitListenerFollower()
		{
			return default(bool);
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x6C1610", Offset = "0x6C1610", VA = "0x6C1610")]
		public static void RemoveTransformFollower(TransformFollower follower)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x6C0FD8", Offset = "0x6C0FD8", VA = "0x6C0FD8")]
		public static Transform InitAudioSourceFollower(Transform transToFollow, string followerName, string soundGroupName, string variationName, float volume, bool willFollowSource, bool willPositionOnClosestColliderPoint, bool useTopCollider, bool useChildColliders, MasterAudio.AmbientSoundExitMode exitMode, float exitFadeTime, MasterAudio.AmbientSoundReEnterMode reEnterMode, float reEnterFadeTime)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x6C1A10", Offset = "0x6C1A10", VA = "0x6C1A10")]
		public static void ManualUpdate()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x6C1B20", Offset = "0x6C1B20", VA = "0x6C1B20")]
		private static void UpdateListenerFollower()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public static class ArrayListUtil
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x6C1D30", Offset = "0x6C1D30", VA = "0x6C1D30")]
		public static void SortIntArray(ref List<int> list)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x6C1E54", Offset = "0x6C1E54", VA = "0x6C1E54")]
		public static bool IsExcludedChildName(string name)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010B")]
	public static class AudioTransformExtensions
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x6C4314", Offset = "0x6C4314", VA = "0x6C4314")]
		public static void FadeOutSoundGroupOfTransform(this Transform sourceTrans, string sType, float fadeTime)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x6C4398", Offset = "0x6C4398", VA = "0x6C4398")]
		public static List<SoundGroupVariation> GetAllPlayingVariationsOfTransform(this Transform sourceTrans)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x6C43FC", Offset = "0x6C43FC", VA = "0x6C43FC")]
		public static bool PlaySound3DAtTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x6C44A8", Offset = "0x6C44A8", VA = "0x6C44A8")]
		public static PlaySoundResult PlaySound3DAtTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x6C4568", Offset = "0x6C4568", VA = "0x6C4568")]
		public static bool PlaySound3DFollowTransformAndForget(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x6C4614", Offset = "0x6C4614", VA = "0x6C4614")]
		public static PlaySoundResult PlaySound3DFollowTransform(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x6C46D4", Offset = "0x6C46D4", VA = "0x6C46D4")]
		public static IEnumerator PlaySound3DAtTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x6C4798", Offset = "0x6C4798", VA = "0x6C4798")]
		public static IEnumerator PlaySound3DFollowTransformAndWaitUntilFinished(this Transform sourceTrans, string sType, float volumePercentage = 1f, [Optional] float? pitch, float delaySoundTime = 0f, [Optional] string variationName, [Optional] double? timeToSchedulePlay, [Optional] Action completedAction)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x6C485C", Offset = "0x6C485C", VA = "0x6C485C")]
		public static void PauseAllSoundsOfTransform(Transform sourceTrans)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x6C48C0", Offset = "0x6C48C0", VA = "0x6C48C0")]
		public static void PauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x6C4934", Offset = "0x6C4934", VA = "0x6C4934")]
		public static void PauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x6C49A8", Offset = "0x6C49A8", VA = "0x6C49A8")]
		public static void StopAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x6C4A0C", Offset = "0x6C4A0C", VA = "0x6C4A0C")]
		public static void StopBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x6C4A80", Offset = "0x6C4A80", VA = "0x6C4A80")]
		public static void StopSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x6C4AF4", Offset = "0x6C4AF4", VA = "0x6C4AF4")]
		public static void UnpauseAllSoundsOfTransform(this Transform sourceTrans)
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x6C4B58", Offset = "0x6C4B58", VA = "0x6C4B58")]
		public static void UnpauseBusOfTransform(this Transform sourceTrans, string busName)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x6C4BCC", Offset = "0x6C4BCC", VA = "0x6C4BCC")]
		public static void UnpauseSoundGroupOfTransform(this Transform sourceTrans, string sType)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x6C4C40", Offset = "0x6C4C40", VA = "0x6C4C40")]
		public static bool IsTransformPlayingSoundGroup(this Transform sourceTrans, string sType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200010C")]
	public class AudioTransformTracker : MonoBehaviour
	{
		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int _frames;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x170000C4")]
		public Transform Trans
		{
			[Token(Token = "0x6000522")]
			[Address(RVA = "0x6C4CB4", Offset = "0x6C4CB4", VA = "0x6C4CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x6C4D54", Offset = "0x6C4D54", VA = "0x6C4D54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x6C4D64", Offset = "0x6C4D64", VA = "0x6C4D64")]
		public AudioTransformTracker()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public static class AudioUtil
	{
		[Token(Token = "0x4000735")]
		public const float DefaultMinOcclusionCutoffFrequency = 22000f;

		[Token(Token = "0x4000736")]
		public const float DefaultMaxOcclusionCutoffFrequency = 0f;

		[Token(Token = "0x4000737")]
		private const float SemitonePitchChangeAmt = 1.0594635f;

		[Token(Token = "0x170000C5")]
		public static float FixedDeltaTime
		{
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x6C4DE4", Offset = "0x6C4DE4", VA = "0x6C4DE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C6")]
		public static float FrameTime
		{
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x6C4DEC", Offset = "0x6C4DEC", VA = "0x6C4DEC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C7")]
		public static float Time
		{
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x6C4DF4", Offset = "0x6C4DF4", VA = "0x6C4DF4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C8")]
		public static int FrameCount
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0x6C4DFC", Offset = "0x6C4DFC", VA = "0x6C4DFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x6C4D6C", Offset = "0x6C4D6C", VA = "0x6C4D6C")]
		private static float CutoffRange(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x6C4DB4", Offset = "0x6C4DB4", VA = "0x6C4DB4")]
		private static float MaxCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x6C4DCC", Offset = "0x6C4DCC", VA = "0x6C4DCC")]
		public static float MinCutoffFreq(SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x6C4E04", Offset = "0x6C4E04", VA = "0x6C4E04")]
		public static float GetOcclusionCutoffFrequencyByDistanceRatio(float distRatio, SoundGroupVariationUpdater updater)
		{
			return default(float);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x6C4E50", Offset = "0x6C4E50", VA = "0x6C4E50")]
		public static float GetSemitonesFromPitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x6C4E9C", Offset = "0x6C4E9C", VA = "0x6C4E9C")]
		public static float GetPitchFromSemitones(float semitones)
		{
			return default(float);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x6C4EDC", Offset = "0x6C4EDC", VA = "0x6C4EDC")]
		public static float GetDbFromFloatVolume(float vol)
		{
			return default(float);
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x6C4EF8", Offset = "0x6C4EF8", VA = "0x6C4EF8")]
		public static float GetFloatVolumeFromDb(float db)
		{
			return default(float);
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x6C2C9C", Offset = "0x6C2C9C", VA = "0x6C2C9C")]
		public static float GetAudioPlayedPercentage(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x6C4F08", Offset = "0x6C4F08", VA = "0x6C4F08")]
		public static bool IsClipPaused(AudioSource source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x6C4F50", Offset = "0x6C4F50", VA = "0x6C4F50")]
		public static void ClipPlayed(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x6C506C", Offset = "0x6C506C", VA = "0x6C506C")]
		public static void UnloadNonPreloadedAudioData(AudioClip clip, GameObject actor)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x6C4FDC", Offset = "0x6C4FDC", VA = "0x6C4FDC")]
		public static bool AudioClipWillPreload(AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x6C5158", Offset = "0x6C5158", VA = "0x6C5158")]
		public static bool IsClipReadyToPlay(this AudioClip clip)
		{
			return default(bool);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x6C51EC", Offset = "0x6C51EC", VA = "0x6C51EC")]
		private static float GetPositiveUsablePitch(AudioSource source)
		{
			return default(float);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x6C5218", Offset = "0x6C5218", VA = "0x6C5218")]
		private static float GetPositiveUsablePitch(float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x6C5228", Offset = "0x6C5228", VA = "0x6C5228")]
		public static float AdjustAudioClipDurationForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x6C5264", Offset = "0x6C5264", VA = "0x6C5264")]
		public static float AdjustAudioClipDurationForPitch(float duration, float pitch)
		{
			return default(float);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x6C5278", Offset = "0x6C5278", VA = "0x6C5278")]
		public static float AdjustEndLeadTimeForPitch(float duration, AudioSource sourceWithPitch)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200010E")]
	public static class CoroutineHelper
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF6C", Offset = "0x44AF6C")]
		private sealed class <WaitForActualSeconds>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float time;

			[Token(Token = "0x400073B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private float <start>5__2;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0x9E0C5C", Offset = "0x9E0C5C", VA = "0x9E0C5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x9E0CA4", Offset = "0x9E0CA4", VA = "0x9E0CA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x9E0B60", Offset = "0x9E0B60", VA = "0x9E0B60")]
			[DebuggerHidden]
			public <WaitForActualSeconds>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0x9E0B8C", Offset = "0x9E0B8C", VA = "0x9E0B8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0x9E0B90", Offset = "0x9E0B90", VA = "0x9E0B90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0x9E0C64", Offset = "0x9E0C64", VA = "0x9E0C64", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x6C7DF4", Offset = "0x6C7DF4", VA = "0x6C7DF4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44D144", Offset = "0x44D144")]
		public static IEnumerator WaitForActualSeconds(float time)
		{
			return null;
		}
	}
	[Token(Token = "0x2000110")]
	public static class DTMonoHelper
	{
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x6C19F8", Offset = "0x6C19F8", VA = "0x6C19F8")]
		public static Transform GetChildTransform(this Transform transParent, string childName)
		{
			return null;
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x6C8B94", Offset = "0x6C8B94", VA = "0x6C8B94")]
		public static bool IsActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x6C8BAC", Offset = "0x6C8BAC", VA = "0x6C8BAC")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x6C1448", Offset = "0x6C1448", VA = "0x6C1448")]
		public static void DestroyAllChildren(this Transform tran)
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class DelayBetweenSongs : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF8C", Offset = "0x44AF8C")]
		private sealed class <PlaySongWithDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DelayBetweenSongs <>4__this;

			[Token(Token = "0x170000CB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x9E10AC", Offset = "0x9E10AC", VA = "0x9E10AC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000551")]
				[Address(RVA = "0x9E10F4", Offset = "0x9E10F4", VA = "0x9E10F4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x9E0F2C", Offset = "0x9E0F2C", VA = "0x9E0F2C")]
			[DebuggerHidden]
			public <PlaySongWithDelay>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x9E0F58", Offset = "0x9E0F58", VA = "0x9E0F58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x9E0F5C", Offset = "0x9E0F5C", VA = "0x9E0F5C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000550")]
			[Address(RVA = "0x9E10B4", Offset = "0x9E10B4", VA = "0x9E10B4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minTimeToWait;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxTimeToWait;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string playlistControllerName;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PlaylistController _controller;

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x6C8BC8", Offset = "0x6C8BC8", VA = "0x6C8BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x6C8C7C", Offset = "0x6C8C7C", VA = "0x6C8C7C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x6C8D10", Offset = "0x6C8D10", VA = "0x6C8D10")]
		private void SongEnded(string songName)
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x6C8D48", Offset = "0x6C8D48", VA = "0x6C8D48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x44D214", Offset = "0x44D214")]
		private IEnumerator PlaySongWithDelay()
		{
			return null;
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x6C8DC0", Offset = "0x6C8DC0", VA = "0x6C8DC0")]
		public DelayBetweenSongs()
		{
		}
	}
	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44AF9C", Offset = "0x44AF9C")]
	public class DynamicSoundGroupCreator : MonoBehaviour
	{
		[Token(Token = "0x2000114")]
		public enum CreateItemsWhen
		{
			[Token(Token = "0x4000765")]
			FirstEnableOnly,
			[Token(Token = "0x4000766")]
			EveryEnable
		}

		[Token(Token = "0x2000115")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AFB0", Offset = "0x44AFB0")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000767")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CustomEventCategory aCat;

			[Token(Token = "0x600055F")]
			[Address(RVA = "0x9E13D4", Offset = "0x9E13D4", VA = "0x9E13D4")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000560")]
			[Address(RVA = "0x9E13DC", Offset = "0x9E13DC", VA = "0x9E13DC")]
			internal bool <RemoveItems>b__0(CustomEventCategory cat)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000743")]
		public const int ExtraHardCodedBusOptions = 1;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SystemLanguage previewLanguage;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public MasterAudio.DragGroupMode curDragGroupMode;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject groupTemplate;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject variationTemplate;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool errorOnDuplicates;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool createOnAwake;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool soundGroupsAreExpanded;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool removeGroupsOnSceneChange;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public CreateItemsWhen reUseMode;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool showCustomEvents;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public MasterAudio.AudioLocation bulkVariationMode;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<CustomEvent> customEventsToCreate;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<CustomEventCategory> customEventCategories;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string newEventName;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string newCustomEventCategoryName;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string addToCustomEventCategoryName;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool showMusicDucking;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<DuckGroupInfo> musicDuckingSounds;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public List<GroupBus> groupBuses;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public bool playListExpanded;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool playlistEditorExp;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public List<MasterAudio.Playlist> musicPlaylists;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<GameObject> audioSourceTemplates;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string audioSourceTemplateName;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public bool groupByBus;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		public bool itemsCreatedEventExpanded;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string itemsCreatedCustomEvent;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public bool showUnityMixerGroupAssignment;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		private bool _hasCreated;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private readonly List<Transform> _groupsToRemove;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _trans;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly List<DynamicSoundGroup> _groupsToCreate;

		[Token(Token = "0x170000CD")]
		public static int HardCodedBusOptions
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x6CB818", Offset = "0x6CB818", VA = "0x6CB818")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000CE")]
		public List<DynamicSoundGroup> GroupsToCreate
		{
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x6CB890", Offset = "0x6CB890", VA = "0x6CB890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CF")]
		public bool ShouldShowUnityAudioMixerGroupAssignments
		{
			[Token(Token = "0x600055D")]
			[Address(RVA = "0x6CB898", Offset = "0x6CB898", VA = "0x6CB898")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x6CA1E4", Offset = "0x6CA1E4", VA = "0x6CA1E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x6CA2C8", Offset = "0x6CA2C8", VA = "0x6CA2C8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x6CA3C8", Offset = "0x6CA3C8", VA = "0x6CA3C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x6CA3CC", Offset = "0x6CA3CC", VA = "0x6CA3CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x6CA2CC", Offset = "0x6CA2CC", VA = "0x6CA2CC")]
		private void CreateItemsIfReady()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x6CA4F8", Offset = "0x6CA4F8", VA = "0x6CA4F8")]
		public void RemoveItems()
		{
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x6CA930", Offset = "0x6CA930", VA = "0x6CA930")]
		public void CreateItems()
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x6CB820", Offset = "0x6CB820", VA = "0x6CB820")]
		private void FireEvents()
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x6CB588", Offset = "0x6CB588", VA = "0x6CB588")]
		public void PopulateGroupData()
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x6CB8A0", Offset = "0x6CB8A0", VA = "0x6CB8A0")]
		public DynamicSoundGroupCreator()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public static class FilePlayerPrefs
	{
		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Hashtable PlayerPrefsHashtable;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool _hashTableChanged;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static string _serializedOutput;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly string SerializedInput;

		[Token(Token = "0x400076C")]
		private const string ParametersSeperator = ";";

		[Token(Token = "0x400076D")]
		private const string KeyValueSeperator = ":";

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string FileName;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x6D26C8", Offset = "0x6D26C8", VA = "0x6D26C8")]
		static FilePlayerPrefs()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x6D2B74", Offset = "0x6D2B74", VA = "0x6D2B74")]
		public static bool HasKey(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x6D2BF4", Offset = "0x6D2BF4", VA = "0x6D2BF4")]
		public static void SetString(string key, string value)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x6D2D28", Offset = "0x6D2D28", VA = "0x6D2D28")]
		public static void SetInt(string key, int value)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x6D2EA8", Offset = "0x6D2EA8", VA = "0x6D2EA8")]
		public static void SetFloat(string key, float value)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x6D3030", Offset = "0x6D3030", VA = "0x6D3030")]
		public static void SetBool(string key, bool value)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x6D31B4", Offset = "0x6D31B4", VA = "0x6D31B4")]
		public static string GetString(string key)
		{
			return null;
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x6D3294", Offset = "0x6D3294", VA = "0x6D3294")]
		public static string GetString(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x6D33D4", Offset = "0x6D33D4", VA = "0x6D33D4")]
		public static int GetInt(string key)
		{
			return default(int);
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x6D357C", Offset = "0x6D357C", VA = "0x6D357C")]
		public static int GetInt(string key, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x6D3704", Offset = "0x6D3704", VA = "0x6D3704")]
		public static float GetFloat(string key)
		{
			return default(float);
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x6D38AC", Offset = "0x6D38AC", VA = "0x6D38AC")]
		public static float GetFloat(string key, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x6D3A3C", Offset = "0x6D3A3C", VA = "0x6D3A3C")]
		public static bool GetBool(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x6D3B4C", Offset = "0x6D3B4C", VA = "0x6D3B4C")]
		public static bool GetBool(string key, bool defaultValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x6D3CE0", Offset = "0x6D3CE0", VA = "0x6D3CE0")]
		public static void DeleteKey(string key)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x6D3D60", Offset = "0x6D3D60", VA = "0x6D3D60")]
		public static void DeleteAll()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x6D3DD8", Offset = "0x6D3DD8", VA = "0x6D3DD8")]
		public static void Flush()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x6D3F84", Offset = "0x6D3F84", VA = "0x6D3F84")]
		private static void Serialize()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x6D286C", Offset = "0x6D286C", VA = "0x6D286C")]
		private static void Deserialize()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x6D44F8", Offset = "0x6D44F8", VA = "0x6D44F8")]
		private static string EscapeNonSeperators(string inputToEscape)
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x6D45A4", Offset = "0x6D45A4", VA = "0x6D45A4")]
		private static string DeEscapeNonSeperators(string inputToDeEscape)
		{
			return null;
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x6D4650", Offset = "0x6D4650", VA = "0x6D4650")]
		public static object GetTypeValue(string typeName, string value)
		{
			return null;
		}
	}
	[Token(Token = "0x2000117")]
	[AttributeAttribute(Name = "AudioScriptOrder", RVA = "0x44AFC0", Offset = "0x44AFC0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x44AFC0", Offset = "0x44AFC0")]
	public class PlaylistController : MonoBehaviour
	{
		[Token(Token = "0x2000118")]
		public enum AudioPlayType
		{
			[Token(Token = "0x40007C8")]
			PlayNow,
			[Token(Token = "0x40007C9")]
			Schedule,
			[Token(Token = "0x40007CA")]
			AlreadyScheduled
		}

		[Token(Token = "0x2000119")]
		public enum PlaylistStates
		{
			[Token(Token = "0x40007CC")]
			NotInScene,
			[Token(Token = "0x40007CD")]
			Stopped,
			[Token(Token = "0x40007CE")]
			Playing,
			[Token(Token = "0x40007CF")]
			Paused,
			[Token(Token = "0x40007D0")]
			Crossfading
		}

		[Token(Token = "0x200011A")]
		public enum FadeMode
		{
			[Token(Token = "0x40007D2")]
			None,
			[Token(Token = "0x40007D3")]
			GradualFade
		}

		[Token(Token = "0x200011B")]
		public enum AudioDuckingMode
		{
			[Token(Token = "0x40007D5")]
			NotDucking,
			[Token(Token = "0x40007D6")]
			SetToDuck,
			[Token(Token = "0x40007D7")]
			Ducked
		}

		[Token(Token = "0x200011C")]
		public delegate void SongChangedEventHandler(string newSongName, MusicSetting song);

		[Token(Token = "0x200011D")]
		public delegate void SongEndedEventHandler(string songName);

		[Token(Token = "0x200011E")]
		public delegate void SongLoopedEventHandler(string songName);

		[Token(Token = "0x200011F")]
		public delegate void PlaylistEndedEventHandler();

		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B034", Offset = "0x44B034")]
		private sealed class <>c__DisplayClass104_0
		{
			[Token(Token = "0x40007D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string clipName;

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x9E4368", Offset = "0x9E4368", VA = "0x9E4368")]
			public <>c__DisplayClass104_0()
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x9E4370", Offset = "0x9E4370", VA = "0x9E4370")]
			internal bool <FindSongByAliasOrName>b__0(MusicSetting obj)
			{
				return default(bool);
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x9E4394", Offset = "0x9E4394", VA = "0x9E4394")]
			internal bool <FindSongByAliasOrName>b__1(MusicSetting obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B044", Offset = "0x44B044")]
		private sealed class <>c__DisplayClass114_0
		{
			[Token(Token = "0x40007D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string playlistControllerName;

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x9E4460", Offset = "0x9E4460", VA = "0x9E4460")]
			public <>c__DisplayClass114_0()
			{
			}

			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x9E4468", Offset = "0x9E4468", VA = "0x9E4468")]
			internal bool <InstanceByName>b__0(PlaylistController obj)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44B054", Offset = "0x44B054")]
		private sealed class <>c__DisplayClass144_0
		{
			[Token(Token = "0x40007DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PlaylistController <>4__this;

			[Token(Token = "0x40007DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volumeBeforeFade;

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x9E4514", Offset = "0x9E4514", VA = "0x9E4514")]
			public <>c__DisplayClass144_0()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x9E451C", Offset = "0x9E451C", VA = "0x9E451C")]
			internal void <FadeOutPlaylist>b__0()
			{
			}
		}

		[Token(Token = "0x400076F")]
		public const float ScheduledSongMinBadOffset = 0.5f;

		[Token(Token = "0x4000770")]
		public const int FramesEarlyToTrigger = 2;

		[Token(Token = "0x4000771")]
		public const int FramesEarlyToBeSyncable = 10;

		[Token(Token = "0x4000772")]
		private const string NotReadyMessage = "Playlist Controller is not initialized yet. It must call its own Awake & Start method before any other methods are called. If you have a script with an Awake or Start event that needs to call it, make sure PlaylistController.cs is set to execute first (Script Execution Order window in Unity). Awake event is still not guaranteed to work, so use Start where possible.";

		[Token(Token = "0x4000773")]
		private const float MinSongLength = 0.5f;

		[Token(Token = "0x4000774")]
		private const float SlowestFrameTimeForCalc = 0.3f;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool startPlaylistOnAwake;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool isShuffle;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool isAutoAdvance;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool loopPlaylist;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float _playlistVolume;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool isMuted;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startPlaylistName;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int syncGroupNum;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AudioMixerGroup mixerChannel;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MasterAudio.ItemSpatialBlendType spatialBlendType;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float spatialBlend;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool initializedEventExpanded;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string initializedCustomEvent;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool crossfadeStartedExpanded;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string crossfadeStartedCustomEvent;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool songChangedEventExpanded;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string songChangedCustomEvent;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool songEndedEventExpanded;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string songEndedCustomEvent;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool songLoopedEventExpanded;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string songLoopedCustomEvent;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool playlistStartedEventExpanded;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string playlistStartedCustomEvent;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool playlistEndedEventExpanded;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public string playlistEndedCustomEvent;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AudioSource _activeAudio;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private AudioSource _transitioningAudio;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float _activeAudioEndVolume;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float _transitioningAudioStartVolume;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float _crossFadeStartTime;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly List<int> _clipsRemaining;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int _currentSequentialClipIndex;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private AudioDuckingMode _duckingMode;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _timeToStartUnducking;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _timeToFinishUnducking;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalMusicVolume;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float _initialDuckVolume;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _duckRange;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private MusicSetting _currentSong;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private GameObject _go;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private string _name;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private FadeMode _curFadeMode;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float _slowFadeStartTime;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private float _slowFadeCompletionTime;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private float _slowFadeStartVolume;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private float _slowFadeTargetVolume;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private MasterAudio.Playlist _currentPlaylist;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _lastTimeMissingPlaylistLogged;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Action _fadeCompleteCallback;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private readonly List<MusicSetting> _queuedSongs;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool _lostFocus;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x151")]
		private bool _autoStartedPlaylist;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private AudioSource _audioClip;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private AudioSource _transClip;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private MusicSetting _newSongSetting;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private bool _nextSongRequested;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x171")]
		private bool _nextSongScheduled;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private int _lastRandomClipIndex;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float _lastTimeSongRequested;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float _currentDuckVolCut;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int? _lastSongPosition;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private double? _currentSchedSongDspStartTime;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private double? _currentSchedSongDspEndTime;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private int _lastFrameSongPosition;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private readonly Dictionary<AudioSource, double> _scheduledSongOffsetByAudioSource;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public int _frames;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<PlaylistController> _instances;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Coroutine _resourceCoroutine;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private int _songsPlayedFromPlaylist;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private AudioSource _audio1;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private AudioSource _audio2;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private string _activeSongAlias;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private Transform _trans;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private bool _willPersist;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private double? _songPauseTime;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int framesOfSongPlayed;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C060", Offset = "0x44C060")]
		private bool <ControllerIsReady>k__BackingField;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x231")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C070", Offset = "0x44C070")]
		private bool <IsCrossFading>k__BackingField;

		[Token(Token = "0x170000D0")]
		private bool SongIsNonAdvancible
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xAB06A4", Offset = "0xAB06A4", VA = "0xAB06A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		public bool ControllerIsReady
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0xAB06FC", Offset = "0xAB06FC", VA = "0xAB06FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D344", Offset = "0x44D344")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0xAB0704", Offset = "0xAB0704", VA = "0xAB0704")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D354", Offset = "0x44D354")]
			private set
			{
			}
		}

		[Token(Token = "0x170000D2")]
		public PlaylistStates PlaylistState
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xAAC190", Offset = "0xAAC190", VA = "0xAAC190")]
			get
			{
				return default(PlaylistStates);
			}
		}

		[Token(Token = "0x170000D3")]
		public AudioSource ActiveAudioSource
		{
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0xAAB3B4", Offset = "0xAAB3B4", VA = "0xAAB3B4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public static List<PlaylistController> Instances
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xAAC678", Offset = "0xAAC678", VA = "0xAAC678")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0xAB0710", Offset = "0xAB0710", VA = "0xAB0710")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public GameObject PlaylistControllerGameObject
		{
			[Token(Token = "0x60005C3")]
			[Address(RVA = "0xAB0764", Offset = "0xAB0764", VA = "0xAB0764")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public AudioSource CurrentPlaylistSource
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0xAB076C", Offset = "0xAB076C", VA = "0xAB076C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D7")]
		public AudioClip CurrentPlaylistClip
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xAB0774", Offset = "0xAB0774", VA = "0xAB0774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		public AudioClip FadingPlaylistClip
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0xAB0808", Offset = "0xAB0808", VA = "0xAB0808")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D9")]
		public AudioSource FadingSource
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xAB08A4", Offset = "0xAB08A4", VA = "0xAB08A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		public bool IsCrossFading
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0xAB08BC", Offset = "0xAB08BC", VA = "0xAB08BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D364", Offset = "0x44D364")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xAB08C4", Offset = "0xAB08C4", VA = "0xAB08C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D374", Offset = "0x44D374")]
			private set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public bool IsFading
		{
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0xAB08D0", Offset = "0xAB08D0", VA = "0xAB08D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public float PlaylistVolume
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xAAF178", Offset = "0xAAF178", VA = "0xAAF178")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0xAB08F0", Offset = "0xAB08F0", VA = "0xAB08F0")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public MasterAudio.Playlist CurrentPlaylist
		{
			[Token(Token = "0x60005CE")]
			[Address(RVA = "0xAAF71C", Offset = "0xAAF71C", VA = "0xAAF71C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		public bool HasPlaylist
		{
			[Token(Token = "0x60005CF")]
			[Address(RVA = "0xAAC9A8", Offset = "0xAAC9A8", VA = "0xAAC9A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DF")]
		public string PlaylistName
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0xAB093C", Offset = "0xAB093C", VA = "0xAB093C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		private bool IsMuted
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xAB09B0", Offset = "0xAB09B0", VA = "0xAB09B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E1")]
		private bool PlaylistIsMuted
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xAACB24", Offset = "0xAACB24", VA = "0xAACB24")]
			set
			{
			}
		}

		[Token(Token = "0x170000E2")]
		private float CrossFadeTime
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xAABFA4", Offset = "0xAABFA4", VA = "0xAABFA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000E3")]
		private bool IsAutoAdvance
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0xAAC030", Offset = "0xAAC030", VA = "0xAAC030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E4")]
		public GameObject GameObj
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0xAAD358", Offset = "0xAAD358", VA = "0xAAD358")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		public string ControllerName
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0xAAA2B0", Offset = "0xAAA2B0", VA = "0xAAA2B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		public bool CanSchedule
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xAABE30", Offset = "0xAABE30", VA = "0xAABE30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E7")]
		private bool IsFrameFastEnough
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0xAAAA8C", Offset = "0xAAAA8C", VA = "0xAAAA8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E8")]
		private bool ShouldNotSwitchEarly
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xAAC154", Offset = "0xAAC154", VA = "0xAAC154")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000E9")]
		private Transform Trans
		{
			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xAAA984", Offset = "0xAAA984", VA = "0xAAA984")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		public int ClipsRemainingInCurrentPlaylist
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xAB09B8", Offset = "0xAB09B8", VA = "0xAB09B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000004")]
		public event SongChangedEventHandler SongChanged
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0xAA97AC", Offset = "0xAA97AC", VA = "0xAA97AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D2C4", Offset = "0x44D2C4")]
			add
			{
			}
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xAA9850", Offset = "0xAA9850", VA = "0xAA9850")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D2D4", Offset = "0x44D2D4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event SongEndedEventHandler SongEnded
		{
			[Token(Token = "0x6000579")]
			[Address(RVA = "0xAA98F4", Offset = "0xAA98F4", VA = "0xAA98F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D2E4", Offset = "0x44D2E4")]
			add
			{
			}
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xAA9998", Offset = "0xAA9998", VA = "0xAA9998")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D2F4", Offset = "0x44D2F4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event SongLoopedEventHandler SongLooped
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0xAA9A3C", Offset = "0xAA9A3C", VA = "0xAA9A3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D304", Offset = "0x44D304")]
			add
			{
			}
			[Token(Token = "0x600057C")]
			[Address(RVA = "0xAA9AE0", Offset = "0xAA9AE0", VA = "0xAA9AE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D314", Offset = "0x44D314")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event PlaylistEndedEventHandler PlaylistEnded
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0xAA9B84", Offset = "0xAA9B84", VA = "0xAA9B84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D324", Offset = "0x44D324")]
			add
			{
			}
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xAA9C28", Offset = "0xAA9C28", VA = "0xAA9C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D334", Offset = "0x44D334")]
			remove
			{
			}
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xAA9CCC", Offset = "0xAA9CCC", VA = "0xAA9CCC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xAAA304", Offset = "0xAAA304", VA = "0xAAA304")]
		public void SetSpatialBlend()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xAAA520", Offset = "0xAAA520", VA = "0xAAA520")]
		private MusicSetting FindSongByAliasOrName(string clipName)
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xAAA6A0", Offset = "0xAAA6A0", VA = "0xAAA6A0")]
		private void SetAudiosIfEmpty()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xAAA470", Offset = "0xAAA470", VA = "0xAAA470")]
		private void SetAudioSpatialBlend(float blend)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xAAA738", Offset = "0xAAA738", VA = "0xAAA738")]
		private void Start()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xAAAA24", Offset = "0xAAAA24", VA = "0xAAAA24")]
		private void AutoStartPlaylist()
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xAAAB5C", Offset = "0xAAAB5C", VA = "0xAAAB5C")]
		private void CoUpdate()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xAAB02C", Offset = "0xAAB02C", VA = "0xAAB02C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xAAB138", Offset = "0xAAB138", VA = "0xAAB138")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xAAB488", Offset = "0xAAB488", VA = "0xAAB488")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0xAAB494", Offset = "0xAAB494", VA = "0xAAB494")]
		private void Update()
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xAAC48C", Offset = "0xAAC48C", VA = "0xAAC48C")]
		public static PlaylistController InstanceByName(string playlistControllerName, bool errorIfNotFound = true)
		{
			return null;
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0xAAC870", Offset = "0xAAC870", VA = "0xAAC870")]
		public bool IsSongPlaying(string songName)
		{
			return default(bool);
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xAAC9B8", Offset = "0xAAC9B8", VA = "0xAAC9B8")]
		public void ClearQueue()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xAACA68", Offset = "0xAACA68", VA = "0xAACA68")]
		public void ToggleMutePlaylist()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xAAAA84", Offset = "0xAAAA84", VA = "0xAAAA84")]
		public void MutePlaylist()
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xAACB1C", Offset = "0xAACB1C", VA = "0xAACB1C")]
		public void UnmutePlaylist()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xAACC94", Offset = "0xAACC94", VA = "0xAACC94")]
		public void PausePlaylist()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xAACEA4", Offset = "0xAACEA4", VA = "0xAACEA4")]
		public bool UnpausePlaylist()
		{
			return default(bool);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xAAAEEC", Offset = "0xAAAEEC", VA = "0xAAAEEC")]
		public void StopPlaylist(bool onlyFadingClip = false)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xAAD52C", Offset = "0xAAD52C", VA = "0xAAD52C")]
		public void FadeToVolume(float targetVolume, float fadeTime, [Optional] Action callback)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xAAD670", Offset = "0xAAD670", VA = "0xAAD670")]
		public void PlayRandomSong()
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xAAD704", Offset = "0xAAD704", VA = "0xAAD704")]
		public void PlayARandomSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xAAD900", Offset = "0xAAD900", VA = "0xAAD900")]
		private void RemoveRandomClip(int randIndex)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xAAE160", Offset = "0xAAE160", VA = "0xAAE160")]
		private void PlayFirstQueuedSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xAAE29C", Offset = "0xAAE29C", VA = "0xAAE29C")]
		public void PlayNextSong()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xAAE330", Offset = "0xAAE330", VA = "0xAAE330")]
		public void PlayTheNextSong(AudioPlayType playType)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xAAE4DC", Offset = "0xAAE4DC", VA = "0xAAE4DC")]
		private void AdvanceSongCounter()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xAAE550", Offset = "0xAAE550", VA = "0xAAE550")]
		public void StopPlaylistAfterCurrentSong()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xAAE74C", Offset = "0xAAE74C", VA = "0xAAE74C")]
		public void StopLoopingCurrentSong()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xAAE900", Offset = "0xAAE900", VA = "0xAAE900")]
		public void QueuePlaylistClip(string clipName, bool scheduleNow = true)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xAAECA8", Offset = "0xAAECA8", VA = "0xAAECA8")]
		public bool TriggerPlaylistClip(string clipName)
		{
			return default(bool);
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xAAEFC4", Offset = "0xAAEFC4", VA = "0xAAEFC4")]
		public void DuckMusicForTime(float duckLength, float unduckTime, float pitch, float duckedTimePercentage, float duckedVolCut)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xAAF148", Offset = "0xAAF148", VA = "0xAAF148")]
		private void InitControllerIfNot()
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xAAADBC", Offset = "0xAAADBC", VA = "0xAAADBC")]
		public void UpdateMasterVolume()
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xAAF1E4", Offset = "0xAAF1E4", VA = "0xAAF1E4")]
		public void StartPlaylist(string playlistName)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0xAAF350", Offset = "0xAAF350", VA = "0xAAF350")]
		public void ChangePlaylist(string playlistName, bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0xAAD29C", Offset = "0xAAD29C", VA = "0xAAD29C")]
		private void FinishPlaylistInit(bool playFirstClip = true)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xAAF2BC", Offset = "0xAAF2BC", VA = "0xAAF2BC")]
		public void RestartPlaylist()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xAAF4A8", Offset = "0xAAF4A8", VA = "0xAAF4A8")]
		private void CheckIfPlaylistStarted()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xAAF5A0", Offset = "0xAAF5A0", VA = "0xAAF5A0")]
		private PlaylistController FindOtherControllerInSameSyncGroup()
		{
			return null;
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0xAAC298", Offset = "0xAAC298", VA = "0xAAC298")]
		private void FadeOutPlaylist()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xAAA950", Offset = "0xAAA950", VA = "0xAAA950")]
		private void InitializePlaylist()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xAAAAB4", Offset = "0xAAAAB4", VA = "0xAAAAB4")]
		private void PlayNextOrRandom(AudioPlayType playType)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xAAC068", Offset = "0xAAC068", VA = "0xAAC068")]
		private void FirePlaylistEndedEventIfAny()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0xAADF84", Offset = "0xAADF84", VA = "0xAADF84")]
		private void FillClips()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xAAD9A0", Offset = "0xAAD9A0", VA = "0xAAD9A0")]
		private void PlaySong(MusicSetting setting, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xAB02B0", Offset = "0xAB02B0", VA = "0xAB02B0")]
		public double? ScheduledGaplessNextSongStartTime()
		{
			return null;
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xAAF7CC", Offset = "0xAAF7CC", VA = "0xAAF7CC")]
		public void FinishLoadingNewSong(MusicSetting songSetting, AudioClip clipToPlay, AudioPlayType playType)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xAB0580", Offset = "0xAB0580", VA = "0xAB0580")]
		private void RemoveScheduledClip()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xAAE8F8", Offset = "0xAAE8F8", VA = "0xAAE8F8")]
		private void ScheduleNextSong()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xAAC3A0", Offset = "0xAAC3A0", VA = "0xAAC3A0")]
		private void FadeInScheduledSong()
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xAB0370", Offset = "0xAB0370", VA = "0xAB0370")]
		private double CalculateNextTrackStartTimeOffset()
		{
			return default(double);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xAB0628", Offset = "0xAB0628", VA = "0xAB0628")]
		private double GetClipDuration(AudioSource src)
		{
			return default(double);
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xAAD3F8", Offset = "0xAAD3F8", VA = "0xAAD3F8")]
		private void ScheduleClipPlay(double scheduledPlayTimeOffset, AudioSource source, bool calledAfterPause)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xAB0454", Offset = "0xAB0454", VA = "0xAB0454")]
		private void CrossFadeNow(AudioSource audioClip)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xAABB24", Offset = "0xAABB24", VA = "0xAABB24")]
		private void CeaseAudioSource(AudioSource source)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xAABEC4", Offset = "0xAABEC4", VA = "0xAABEC4")]
		private void SetDuckProperties()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xAAC3A8", Offset = "0xAAC3A8", VA = "0xAAC3A8")]
		private void AudioDucking()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xAAF690", Offset = "0xAAF690", VA = "0xAAF690")]
		private bool SongShouldLoop(MusicSetting setting)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xAB08F8", Offset = "0xAB08F8", VA = "0xAB08F8")]
		public void RouteToMixerChannel(AudioMixerGroup group)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xAB0A04", Offset = "0xAB0A04", VA = "0xAB0A04")]
		public PlaylistController()
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0xAB0C44", Offset = "0xAB0C44", VA = "0xAB0C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D384", Offset = "0x44D384")]
		private bool <FindOtherControllerInSameSyncGroup>b__143_0(PlaylistController obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xAB0D38", Offset = "0xAB0D38", VA = "0xAB0D38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44D394", Offset = "0x44D394")]
		private bool <FinishLoadingNewSong>b__151_0(MusicSetting obj)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000123")]
	public static class SpatializerHelper
	{
		[Token(Token = "0x40007DC")]
		private const string OculusSpatializer = "OculusSpatializer";

		[Token(Token = "0x40007DD")]
		private const string ResonanceAudioSpatializer = "Resonance Audio";

		[Token(Token = "0x170000EB")]
		public static bool IsSupportedSpatializer
		{
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x9D8DF0", Offset = "0x9D8DF0", VA = "0x9D8DF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EC")]
		public static bool IsOculusAudioSpatializer
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x9D8E8C", Offset = "0x9D8E8C", VA = "0x9D8E8C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000ED")]
		public static bool IsResonanceAudioSpatializer
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x9D8EDC", Offset = "0x9D8EDC", VA = "0x9D8EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public static string SelectedSpatializer
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x9D8E84", Offset = "0x9D8E84", VA = "0x9D8E84")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		public static bool SpatializerOptionExists
		{
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x9D8F2C", Offset = "0x9D8F2C", VA = "0x9D8F2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x9D8F34", Offset = "0x9D8F34", VA = "0x9D8F34")]
		public static void TurnOnSpatializerIfEnabled(AudioSource source)
		{
		}
	}
	[Token(Token = "0x2000124")]
	public static class UtilStrings
	{
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x9DB590", Offset = "0x9DB590", VA = "0x9DB590")]
		public static string TrimSpace(string untrimmed)
		{
			return null;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x9DB60C", Offset = "0x9DB60C", VA = "0x9DB60C")]
		public static string ReplaceUnsafeChars(string source)
		{
			return null;
		}
	}
}
namespace DarkTonic.MasterAudio.Examples
{
	[Token(Token = "0x2000125")]
	public class MA_Bootstrapper : MonoBehaviour
	{
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x5D8B20", Offset = "0x5D8B20", VA = "0x5D8B20")]
		private void Awake()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x5D8B24", Offset = "0x5D8B24", VA = "0x5D8B24")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5D8C64", Offset = "0x5D8C64", VA = "0x5D8C64")]
		public MA_Bootstrapper()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class MA_DestroyFinishedParticle : MonoBehaviour
	{
		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ParticleSystem particles;

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x5D8C6C", Offset = "0x5D8C6C", VA = "0x5D8C6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x5D8CD8", Offset = "0x5D8CD8", VA = "0x5D8CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x5D8D74", Offset = "0x5D8D74", VA = "0x5D8D74")]
		public MA_DestroyFinishedParticle()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class MA_EnemyOne : MonoBehaviour
	{
		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ExplosionParticlePrefab;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _trans;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _speed;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _horizSpeed;

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x5D8D7C", Offset = "0x5D8D7C", VA = "0x5D8D7C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x5D8E70", Offset = "0x5D8E70", VA = "0x5D8E70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x5D8FAC", Offset = "0x5D8FAC", VA = "0x5D8FAC")]
		public MA_EnemyOne()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class MA_EnemySpawner : MonoBehaviour
	{
		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Enemy;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool spawnerEnabled;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform trans;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float nextSpawnTime;

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x5D8FB4", Offset = "0x5D8FB4", VA = "0x5D8FB4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5D902C", Offset = "0x5D902C", VA = "0x5D902C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x5D91D4", Offset = "0x5D91D4", VA = "0x5D91D4")]
		public MA_EnemySpawner()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class MA_GameScene : MonoBehaviour
	{
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5D91DC", Offset = "0x5D91DC", VA = "0x5D91DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5D9290", Offset = "0x5D9290", VA = "0x5D9290")]
		public MA_GameScene()
		{
		}
	}
	[Token(Token = "0x200012A")]
	public class MA_Laser : MonoBehaviour
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform _trans;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x5D9298", Offset = "0x5D9298", VA = "0x5D9298")]
		private void Awake()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x5D933C", Offset = "0x5D933C", VA = "0x5D933C")]
		private void Update()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x5D9424", Offset = "0x5D9424", VA = "0x5D9424")]
		public MA_Laser()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class MA_LocalizationUI : MonoBehaviour
	{
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5D942C", Offset = "0x5D942C", VA = "0x5D942C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x5D94E0", Offset = "0x5D94E0", VA = "0x5D94E0")]
		public MA_LocalizationUI()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class MA_PlayerControl : MonoBehaviour
	{
		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool canShoot;

		[Token(Token = "0x40007EA")]
		private const float MoveSpeed = 10f;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform _trans;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _lastMoveAmt;

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5D94E8", Offset = "0x5D94E8", VA = "0x5D94E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x5D958C", Offset = "0x5D958C", VA = "0x5D958C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x5D9590", Offset = "0x5D9590", VA = "0x5D9590")]
		private void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5D9594", Offset = "0x5D9594", VA = "0x5D9594")]
		private void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x5D9598", Offset = "0x5D9598", VA = "0x5D9598")]
		private void Update()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x5DA674", Offset = "0x5DA674", VA = "0x5DA674")]
		public MA_PlayerControl()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class MA_PlayerSpawnerControl : MonoBehaviour
	{
		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Player;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float nextSpawnTime;

		[Token(Token = "0x170000F0")]
		private bool PlayerActive
		{
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x5DA6B4", Offset = "0x5DA6B4", VA = "0x5DA6B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x5DA684", Offset = "0x5DA684", VA = "0x5DA684")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5DA6D0", Offset = "0x5DA6D0", VA = "0x5DA6D0")]
		private void Update()
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x5DA754", Offset = "0x5DA754", VA = "0x5DA754")]
		public MA_PlayerSpawnerControl()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class MA_SampleICustomEventReceiver : MonoBehaviour, ICustomEventReceiver
	{
		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly List<string> _eventsSubscribedTo;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x5DA75C", Offset = "0x5DA75C", VA = "0x5DA75C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x5DA760", Offset = "0x5DA760", VA = "0x5DA760")]
		private void Start()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x5DA8D0", Offset = "0x5DA8D0", VA = "0x5DA8D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x5DA94C", Offset = "0x5DA94C", VA = "0x5DA94C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x5DA764", Offset = "0x5DA764", VA = "0x5DA764", Slot = "4")]
		public void CheckForIllegalCustomEvents()
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x5DAE3C", Offset = "0x5DAE3C", VA = "0x5DAE3C", Slot = "5")]
		public void ReceiveEvent(string customEventName, Vector3 originPoint)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x5DAF88", Offset = "0x5DAF88", VA = "0x5DAF88", Slot = "6")]
		public bool SubscribesToEvent(string customEventName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x5DA8D4", Offset = "0x5DA8D4", VA = "0x5DA8D4", Slot = "7")]
		public void RegisterReceiver()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x5DAC2C", Offset = "0x5DAC2C", VA = "0x5DAC2C", Slot = "8")]
		public void UnregisterReceiver()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x5DB950", Offset = "0x5DB950", VA = "0x5DB950", Slot = "9")]
		public IList<AudioEventGroup> GetAllEvents()
		{
			return null;
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x5DBAA0", Offset = "0x5DBAA0", VA = "0x5DBAA0")]
		public MA_SampleICustomEventReceiver()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class MA_TestUI : MonoBehaviour
	{
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x5DBB90", Offset = "0x5DBB90", VA = "0x5DBB90")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x5DBC44", Offset = "0x5DBC44", VA = "0x5DBC44")]
		public MA_TestUI()
		{
		}
	}
}
