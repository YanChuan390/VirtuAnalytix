using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using ExitGames.Client.Photon;
using Il2CppDummyDll;
using Odders.Chess.Core.Model;
using Odders.Chess.Core.Model.Board;
using Odders.Chess.GameFlow.GameStarter;
using Odders.Chess.Player;
using Odders.Chess.Player.Pieces;
using Odders.Platforms;
using Odders.UiComponents;
using Odders.UiComponents.OptionsToggles;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.PUN;
using Photon.Voice.Unity;
using Photon.Voice.Unity.UtilityScripts;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.XR.Interaction.Toolkit;
using Zenject;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LanguagePanel : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleGroup _languageToggleGroup;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<LanguageToggle> _languageToggles;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _startButtonIa;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD761D4", Offset = "0xD761D4", VA = "0xD761D4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD7641C", Offset = "0xD7641C", VA = "0xD7641C")]
	public void ChangeLanguage()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD76284", Offset = "0xD76284", VA = "0xD76284")]
	private void ActivateSystemLanguageToggle()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD7651C", Offset = "0xD7651C", VA = "0xD7651C")]
	public LanguagePanel()
	{
	}
}
[Token(Token = "0x2000003")]
public class VoiceTest : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD76524", Offset = "0xD76524", VA = "0xD76524")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD76528", Offset = "0xD76528", VA = "0xD76528")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD7652C", Offset = "0xD7652C", VA = "0xD7652C")]
	public VoiceTest()
	{
	}
}
[Token(Token = "0x2000004")]
public class CollisionButton : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD76534", Offset = "0xD76534", VA = "0xD76534")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD76538", Offset = "0xD76538", VA = "0xD76538")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD7653C", Offset = "0xD7653C", VA = "0xD7653C")]
	public CollisionButton()
	{
	}
}
[Token(Token = "0x2000005")]
public class ObjectsDisabler : MonoBehaviour
{
	[Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class <IEStart>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectsDisabler <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xD76924", Offset = "0xD76924", VA = "0xD76924", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xD7696C", Offset = "0xD7696C", VA = "0xD7696C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xD7660C", Offset = "0xD7660C", VA = "0xD7660C")]
		[DebuggerHidden]
		public <IEStart>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xD76660", Offset = "0xD76660", VA = "0xD76660", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xD76664", Offset = "0xD76664", VA = "0xD76664", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD7692C", Offset = "0xD7692C", VA = "0xD7692C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] ObjectsToFilter;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Toggle ToggleTemplate;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Text Label;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD76544", Offset = "0xD76544", VA = "0xD76544")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD765E8", Offset = "0xD765E8", VA = "0xD765E8")]
	private void ToggleValueChanged(GameObject o, Toggle t)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD76580", Offset = "0xD76580", VA = "0xD76580")]
	[IteratorStateMachine(typeof(<IEStart>d__5))]
	private IEnumerator IEStart()
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD76634", Offset = "0xD76634", VA = "0xD76634")]
	public ObjectsDisabler()
	{
	}
}
[Token(Token = "0x2000008")]
public class LoadAvatarTest : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SampleAvatarEntity avatar;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string userId;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool LoadAvatar;

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD76974", Offset = "0xD76974", VA = "0xD76974")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD769B8", Offset = "0xD769B8", VA = "0xD769B8")]
	public LoadAvatarTest()
	{
	}
}
[Token(Token = "0x2000009")]
public class PauseEditor : MonoBehaviour
{
	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD76A08", Offset = "0xD76A08", VA = "0xD76A08")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD76A68", Offset = "0xD76A68", VA = "0xD76A68")]
	public PauseEditor()
	{
	}
}
[Token(Token = "0x200000A")]
public class DisplayFrequencyManager : MonoBehaviour
{
	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FrequencyToggle toggleRef;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ToggleGroup toggleGroup;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button changeButton;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] _frequencies;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD76A70", Offset = "0xD76A70", VA = "0xD76A70")]
	private void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD76CFC", Offset = "0xD76CFC", VA = "0xD76CFC")]
	public void Set(float value)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD76DEC", Offset = "0xD76DEC", VA = "0xD76DEC")]
	public void Change()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD76EA8", Offset = "0xD76EA8", VA = "0xD76EA8")]
	public DisplayFrequencyManager()
	{
	}
}
[Token(Token = "0x200000B")]
public class MoveLocalizatorPanel : MonoBehaviour
{
	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class <RepositionPanel>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xD76FFC", Offset = "0xD76FFC", VA = "0xD76FFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xD77044", Offset = "0xD77044", VA = "0xD77044", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xD76F34", Offset = "0xD76F34", VA = "0xD76F34")]
		[DebuggerHidden]
		public <RepositionPanel>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xD76F64", Offset = "0xD76F64", VA = "0xD76F64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xD76F68", Offset = "0xD76F68", VA = "0xD76F68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xD77004", Offset = "0xD77004", VA = "0xD77004", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ChessPlayerManagerController _player;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD76EB0", Offset = "0xD76EB0", VA = "0xD76EB0")]
	[Inject]
	public void Construct(ChessPlayerManagerController player)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD76ED4", Offset = "0xD76ED4", VA = "0xD76ED4")]
	[IteratorStateMachine(typeof(<RepositionPanel>d__2))]
	private IEnumerator RepositionPanel()
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD76F5C", Offset = "0xD76F5C", VA = "0xD76F5C")]
	public MoveLocalizatorPanel()
	{
	}
}
[Token(Token = "0x200000D")]
public class RandomMaterial : MonoBehaviour
{
	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer targetRenderer;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD7704C", Offset = "0xD7704C", VA = "0xD7704C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD77050", Offset = "0xD77050", VA = "0xD77050")]
	public void ChangeMaterial()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD770A8", Offset = "0xD770A8", VA = "0xD770A8")]
	public RandomMaterial()
	{
	}
}
[Token(Token = "0x200000E")]
public class UnluckDistanceDisabler : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int _distanceDisable;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform _distanceFrom;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool _distanceFromMainCam;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _disableCheckInterval;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _enableCheckInterval;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool _disableOnStart;

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD770B0", Offset = "0xD770B0", VA = "0xD770B0")]
	public void Start()
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD771B0", Offset = "0xD771B0", VA = "0xD771B0")]
	public void DisableOnStart()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD771E4", Offset = "0xD771E4", VA = "0xD771E4")]
	public void CheckDisable()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD772B0", Offset = "0xD772B0", VA = "0xD772B0")]
	public void CheckEnable()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD7737C", Offset = "0xD7737C", VA = "0xD7737C")]
	public UnluckDistanceDisabler()
	{
	}
}
[Token(Token = "0x200000F")]
public class LookAtCamera : MonoBehaviour
{
	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera lookAtCamera;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool lookOnlyOnAwake;

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD77398", Offset = "0xD77398", VA = "0xD77398")]
	public void Start()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD77468", Offset = "0xD77468", VA = "0xD77468")]
	public void Update()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD77424", Offset = "0xD77424", VA = "0xD77424")]
	public void LookCam()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD77478", Offset = "0xD77478", VA = "0xD77478")]
	public LookAtCamera()
	{
	}
}
[Token(Token = "0x2000010")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 targetOffset;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float distance;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float maxDistance;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float xSpeed;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float ySpeed;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int yMinLimit;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int yMaxLimit;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int zoomRate;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float panSpeed;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float zoomDampening;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float autoRotate;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float autoRotateSpeed;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float xDeg;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float yDeg;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float currentDistance;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float desiredDistance;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion currentRotation;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Quaternion desiredRotation;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Quaternion rotation;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 position;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private float idleTimer;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float idleSmooth;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD77480", Offset = "0xD77480", VA = "0xD77480")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD7796C", Offset = "0xD7796C", VA = "0xD7796C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD77484", Offset = "0xD77484", VA = "0xD77484")]
	public void Init()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD77970", Offset = "0xD77970", VA = "0xD77970")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD77E48", Offset = "0xD77E48", VA = "0xD77E48")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD77E84", Offset = "0xD77E84", VA = "0xD77E84")]
	public SmoothCameraOrbit()
	{
	}
}
[Token(Token = "0x2000011")]
public class FlockChild : MonoBehaviour
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockController _spawner;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Vector3 _wayPoint;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _speed;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool _dived;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float _stuckCounter;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float _damping;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool _soar;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool _landing;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float _targetSpeed;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public bool _move;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject _model;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform _modelT;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public float _avoidValue;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public float _avoidDistance;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float _soarTimer;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool _instantiated;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int _updateNextSeed;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int _updateSeed;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public bool _avoid;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform _thisT;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 _landingPosOffset;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD77EC0", Offset = "0xD77EC0", VA = "0xD77EC0")]
	public void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD785B8", Offset = "0xD785B8", VA = "0xD785B8")]
	public void Update()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD78CC8", Offset = "0xD78CC8", VA = "0xD78CC8")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD78CFC", Offset = "0xD78CFC", VA = "0xD78CFC")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD77FA4", Offset = "0xD77FA4", VA = "0xD77FA4")]
	public void FindRequiredComponents()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD78260", Offset = "0xD78260", VA = "0xD78260")]
	public void RandomizeStartAnimationFrame()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD78564", Offset = "0xD78564", VA = "0xD78564")]
	public void InitAvoidanceValues()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD78164", Offset = "0xD78164", VA = "0xD78164")]
	public void SetRandomScale()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD78614", Offset = "0xD78614", VA = "0xD78614")]
	public void SoarTimeLimit()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD7866C", Offset = "0xD7866C", VA = "0xD7866C")]
	public void CheckForDistanceToWaypoint()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD7877C", Offset = "0xD7877C", VA = "0xD7877C")]
	public void RotationBasedOnWaypointOrAvoidance()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD78FEC", Offset = "0xD78FEC", VA = "0xD78FEC")]
	public bool Avoidance()
	{
		return default(bool);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD78A70", Offset = "0xD78A70", VA = "0xD78A70")]
	public void LimitRotationOfModel()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD780BC", Offset = "0xD780BC", VA = "0xD780BC")]
	public void Wander(float delay)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD79568", Offset = "0xD79568", VA = "0xD79568")]
	public void SetRandomMode()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD78DA8", Offset = "0xD78DA8", VA = "0xD78DA8")]
	public void Flap()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD781A0", Offset = "0xD781A0", VA = "0xD781A0")]
	public Vector3 findWaypoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD79628", Offset = "0xD79628", VA = "0xD79628")]
	public void Soar()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD796B8", Offset = "0xD796B8", VA = "0xD796B8")]
	public void Dive()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD79A54", Offset = "0xD79A54", VA = "0xD79A54")]
	public void animationSpeed()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD79D98", Offset = "0xD79D98", VA = "0xD79D98")]
	public FlockChild()
	{
	}
}
[Token(Token = "0x2000012")]
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip[] _idleSounds;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float _idleSoundRandomChance;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip[] _flightSounds;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _flightSoundRandomChance;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip[] _scareSounds;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _pitchMin;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _pitchMax;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float _volumeMin;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float _volumeMax;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private FlockChild _flockChild;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioSource _audio;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool _hasLanded;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD79DBC", Offset = "0xD79DBC", VA = "0xD79DBC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD79EBC", Offset = "0xD79EBC", VA = "0xD79EBC")]
	public void PlayRandomSound()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD7A0C0", Offset = "0xD7A0C0", VA = "0xD7A0C0")]
	public void ScareSound()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD7A1BC", Offset = "0xD7A1BC", VA = "0xD7A1BC")]
	public FlockChildSound()
	{
	}
}
[Token(Token = "0x2000013")]
public class FlockController : MonoBehaviour
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FlockChild _childPrefab;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int _childAmount;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool _slowSpawn;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float _spawnSphere;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _spawnSphereHeight;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _spawnSphereDepth;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float _minSpeed;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float _maxSpeed;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float _minScale;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float _maxScale;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _soarFrequency;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string _soarAnimation;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string _flapAnimation;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public string _idleAnimation;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float _diveValue;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float _diveFrequency;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _minDamping;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float _maxDamping;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float _waypointDistance;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float _minAnimationSpeed;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float _maxAnimationSpeed;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float _randomPositionTimer;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float _positionSphere;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float _positionSphereHeight;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float _positionSphereDepth;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool _childTriggerPos;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	public bool _forceChildWaypoints;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float _forcedRandomDelay;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool _flatFly;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool _flatSoar;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x96")]
	public bool _birdAvoid;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public int _birdAvoidHorizontalForce;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool _birdAvoidDown;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	public bool _birdAvoidUp;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public int _birdAvoidVerticalForce;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float _birdAvoidDistanceMax;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public float _birdAvoidDistanceMin;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public float _soarMaxTime;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public LayerMask _avoidanceMask;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<FlockChild> _roamers;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Vector3 _posBuffer;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int _updateDivisor;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float _newDelta;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int _updateCounter;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float _activeChildren;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public bool _groupChildToNewTransform;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform _groupTransform;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string _groupName;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool _groupChildToFlock;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public Vector3 _startPosOffset;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform _thisT;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD7A1E0", Offset = "0xD7A1E0", VA = "0xD7A1E0")]
	public void Start()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD7A2C4", Offset = "0xD7A2C4", VA = "0xD7A2C4")]
	public void AddChild(int amount)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD7A558", Offset = "0xD7A558", VA = "0xD7A558")]
	public void AddChildToParent(Transform obj)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD7A5A8", Offset = "0xD7A5A8", VA = "0xD7A5A8")]
	public void RemoveChild(int amount)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD7A6B0", Offset = "0xD7A6B0", VA = "0xD7A6B0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD7A404", Offset = "0xD7A404", VA = "0xD7A404")]
	public void InstantiateGroup()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD7A714", Offset = "0xD7A714", VA = "0xD7A714")]
	public void UpdateChildAmount()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD7A7A4", Offset = "0xD7A7A4", VA = "0xD7A7A4")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD78E7C", Offset = "0xD78E7C", VA = "0xD78E7C")]
	public void SetFlockRandomPosition()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD7A97C", Offset = "0xD7A97C", VA = "0xD7A97C")]
	public void destroyBirds()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD7AA88", Offset = "0xD7AA88", VA = "0xD7AA88")]
	public FlockController()
	{
	}
}
[Token(Token = "0x2000014")]
public class FlockScare : MonoBehaviour
{
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LandingSpotController[] landingSpotControllers;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float scareInterval;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float distanceToScare;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int checkEveryNthLandingSpot;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int InvokeAmounts;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int lsc;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int ls;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LandingSpotController currentController;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD7ABCC", Offset = "0xD7ABCC", VA = "0xD7ABCC")]
	private void CheckProximityToLandingSpots()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD7AC9C", Offset = "0xD7AC9C", VA = "0xD7AC9C")]
	private void IterateLandingSpots()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD7AD38", Offset = "0xD7AD38", VA = "0xD7AD38")]
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD7AE7C", Offset = "0xD7AE7C", VA = "0xD7AE7C")]
	private void Invoker()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD7AF04", Offset = "0xD7AF04", VA = "0xD7AF04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD7AF78", Offset = "0xD7AF78", VA = "0xD7AF78")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD7AFC4", Offset = "0xD7AFC4", VA = "0xD7AFC4")]
	public FlockScare()
	{
	}
}
[Token(Token = "0x2000015")]
public class FlockWaypointTrigger : MonoBehaviour
{
	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float _timer;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlockChild _flockChild;

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD7AFDC", Offset = "0xD7AFDC", VA = "0xD7AFDC")]
	public void Start()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD7B0BC", Offset = "0xD7B0BC", VA = "0xD7B0BC")]
	public void Trigger()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD7B0D8", Offset = "0xD7B0D8", VA = "0xD7B0D8")]
	public FlockWaypointTrigger()
	{
	}
}
[Token(Token = "0x2000016")]
public class LandingButtons : MonoBehaviour
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LandingSpotController _landingSpotController;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlockController _flockController;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float hSliderValue;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD7B0E8", Offset = "0xD7B0E8", VA = "0xD7B0E8")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xD7B654", Offset = "0xD7B654", VA = "0xD7B654")]
	public LandingButtons()
	{
	}
}
[Token(Token = "0x2000017")]
public class LandingSpot : MonoBehaviour
{
	[Token(Token = "0x2000018")]
	[CompilerGenerated]
	private sealed class <GetFlockChild>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float maxDelay;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpot <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xD7D0C0", Offset = "0xD7D0C0", VA = "0xD7D0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xD7D108", Offset = "0xD7D108", VA = "0xD7D108", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD7C3D0", Offset = "0xD7C3D0", VA = "0xD7C3D0")]
		[DebuggerHidden]
		public <GetFlockChild>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD7C9AC", Offset = "0xD7C9AC", VA = "0xD7C9AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD7C9B0", Offset = "0xD7C9B0", VA = "0xD7C9B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD7D0C8", Offset = "0xD7D0C8", VA = "0xD7D0C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockChild landingChild;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool landing;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int lerpCounter;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public LandingSpotController _controller;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _idle;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform _thisT;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _gotcha;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xD7B664", Offset = "0xD7B664", VA = "0xD7B664")]
	public void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD7B7F8", Offset = "0xD7B7F8", VA = "0xD7B7F8")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD7BBC0", Offset = "0xD7BBC0", VA = "0xD7BBC0")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD7C364", Offset = "0xD7C364", VA = "0xD7C364")]
	public void StraightenBird()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD7C1A0", Offset = "0xD7C1A0", VA = "0xD7C1A0")]
	public void RotateBird()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD7B77C", Offset = "0xD7B77C", VA = "0xD7B77C")]
	[IteratorStateMachine(typeof(<GetFlockChild>d__12))]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD7C3F8", Offset = "0xD7C3F8", VA = "0xD7C3F8")]
	public void InstantLand()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD7C724", Offset = "0xD7C724", VA = "0xD7C724")]
	public void ReleaseFlockChild()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD7C9A4", Offset = "0xD7C9A4", VA = "0xD7C9A4")]
	public LandingSpot()
	{
	}
}
[Token(Token = "0x2000019")]
public class LandingSpotController : MonoBehaviour
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <InstantLandOnStart>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0xD7D6FC", Offset = "0xD7D6FC", VA = "0xD7D6FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xD7D744", Offset = "0xD7D744", VA = "0xD7D744", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xD7D4E4", Offset = "0xD7D4E4", VA = "0xD7D4E4")]
		[DebuggerHidden]
		public <InstantLandOnStart>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xD7D584", Offset = "0xD7D584", VA = "0xD7D584", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xD7D588", Offset = "0xD7D588", VA = "0xD7D588", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xD7D704", Offset = "0xD7D704", VA = "0xD7D704", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <InstantLand>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD7D8C4", Offset = "0xD7D8C4", VA = "0xD7D8C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xD7D90C", Offset = "0xD7D90C", VA = "0xD7D90C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xD7D50C", Offset = "0xD7D50C", VA = "0xD7D50C")]
		[DebuggerHidden]
		public <InstantLand>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xD7D74C", Offset = "0xD7D74C", VA = "0xD7D74C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xD7D750", Offset = "0xD7D750", VA = "0xD7D750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD7D8CC", Offset = "0xD7D8CC", VA = "0xD7D8CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool _randomRotate;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 _autoCatchDelay;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 _autoDismountDelay;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float _maxBirdDistance;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float _minBirdDistance;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool _takeClosest;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public FlockController _flock;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool _landOnStart;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool _soarLand;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool _onlyBirdsAbove;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float _landingSpeedModifier;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float _landingTurnSpeedModifier;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform _featherPS;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform _thisT;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int _activeLandingSpots;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float _snapLandDistance;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float _landedRotateSpeed;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float _gizmoSize;

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xD7D110", Offset = "0xD7D110", VA = "0xD7D110")]
	public void Start()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xD7AE70", Offset = "0xD7AE70", VA = "0xD7AE70")]
	public void ScareAll()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xD7D39C", Offset = "0xD7D39C", VA = "0xD7D39C")]
	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xD7B4BC", Offset = "0xD7B4BC", VA = "0xD7B4BC")]
	public void LandAll()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD7D324", Offset = "0xD7D324", VA = "0xD7D324")]
	[IteratorStateMachine(typeof(<InstantLandOnStart>d__22))]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD7B5DC", Offset = "0xD7B5DC", VA = "0xD7B5DC")]
	[IteratorStateMachine(typeof(<InstantLand>d__23))]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD7D534", Offset = "0xD7D534", VA = "0xD7D534")]
	public LandingSpotController()
	{
	}
}
[Token(Token = "0x200001C")]
public class CameraHolder : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	public struct SVA
	{
		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float S;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float V;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float A;
	}

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Holder;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 cameraPos;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float currDistance;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float xRotate;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float yRotate;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float yMinLimit;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float yMaxLimit;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float prevDistance;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float x;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float y;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Header("GUI")]
	private float windowDpi;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject[] Prefabs;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int Prefab;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject Instance;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float StartColor;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float HueColor;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture HueTexture;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem[] particleSystems;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<SVA> svList;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float H;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xD7D914", Offset = "0xD7D914", VA = "0xD7D914")]
	private void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xD7DC68", Offset = "0xD7DC68", VA = "0xD7DC68")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xD7D9A0", Offset = "0xD7D9A0", VA = "0xD7D9A0")]
	private void Counter(int count)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xD7E050", Offset = "0xD7E050", VA = "0xD7E050")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xD7E4C4", Offset = "0xD7E4C4", VA = "0xD7E4C4")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD7E500", Offset = "0xD7E500", VA = "0xD7E500")]
	public CameraHolder()
	{
	}
}
[Token(Token = "0x200001E")]
public class CustomDefineTester : MonoBehaviour
{
	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD7E5BC", Offset = "0xD7E5BC", VA = "0xD7E5BC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xD7E5C0", Offset = "0xD7E5C0", VA = "0xD7E5C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xD7E5C4", Offset = "0xD7E5C4", VA = "0xD7E5C4")]
	public CustomDefineTester()
	{
	}
}
[Token(Token = "0x200001F")]
[RequireComponent(typeof(Renderer))]
[RequireComponent(typeof(PhotonView))]
public class ChangeColor : MonoBehaviour
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private PhotonView photonView;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xD7E5CC", Offset = "0xD7E5CC", VA = "0xD7E5CC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xD7E710", Offset = "0xD7E710", VA = "0xD7E710")]
	[PunRPC]
	private void ChangeColour(Vector3 randomColor)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xD7E7B8", Offset = "0xD7E7B8", VA = "0xD7E7B8")]
	public ChangeColor()
	{
	}
}
[Token(Token = "0x2000020")]
[RequireComponent(typeof(PhotonView))]
public class ChangeName : MonoBehaviour
{
	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD7E7C0", Offset = "0xD7E7C0", VA = "0xD7E7C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD7E884", Offset = "0xD7E884", VA = "0xD7E884")]
	public ChangeName()
	{
	}
}
[Token(Token = "0x2000021")]
[RequireComponent(typeof(PhotonVoiceView))]
public class PointersController : MonoBehaviour
{
	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject pointerDown;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject pointerUp;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD7E88C", Offset = "0xD7E88C", VA = "0xD7E88C")]
	private void Start()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD7E8DC", Offset = "0xD7E8DC", VA = "0xD7E8DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD7E934", Offset = "0xD7E934", VA = "0xD7E934")]
	private void SetActiveSafe(GameObject go, bool active)
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xD7E9DC", Offset = "0xD7E9DC", VA = "0xD7E9DC")]
	public PointersController()
	{
	}
}
[Token(Token = "0x2000022")]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class ProximityVoiceTrigger : VoiceComponent
{
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<byte> groupsToAdd;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<byte> groupsToRemove;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private byte[] subscribedGroups;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PhotonVoiceView photonVoiceView;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private PhotonView photonView;

	[Token(Token = "0x1700000B")]
	public byte TargetInterestGroup
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD7E9E4", Offset = "0xD7E9E4", VA = "0xD7E9E4")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD7EA68", Offset = "0xD7EA68", VA = "0xD7EA68", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xD7EB14", Offset = "0xD7EB14", VA = "0xD7EB14")]
	private void ToggleTransmission()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xD7EDE0", Offset = "0xD7EDE0", VA = "0xD7EDE0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xD7F030", Offset = "0xD7F030", VA = "0xD7F030")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xD7F2C0", Offset = "0xD7F2C0", VA = "0xD7F2C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xD7F8A4", Offset = "0xD7F8A4", VA = "0xD7F8A4")]
	public ProximityVoiceTrigger()
	{
	}
}
[Serializable]
[Token(Token = "0x2000023")]
public class MouseLookHelper
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float XSensitivity;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float YSensitivity;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool clampVerticalRotation;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MinimumX;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float MaximumX;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool smooth;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float smoothTime;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Quaternion m_CharacterTargetRot;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Quaternion m_CameraTargetRot;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xD7F944", Offset = "0xD7F944", VA = "0xD7F944")]
	public void Init(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xD7F994", Offset = "0xD7F994", VA = "0xD7F994")]
	public void LookRotation(Transform character, Transform camera)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xD7FCD4", Offset = "0xD7FCD4", VA = "0xD7FCD4")]
	private Quaternion ClampRotationAroundXAxis(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xD7FD38", Offset = "0xD7FD38", VA = "0xD7FD38")]
	public MouseLookHelper()
	{
	}
}
[Token(Token = "0x2000024")]
public class SoundsForJoinAndLeave : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip JoinClip;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioClip LeaveClip;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource source;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xD7FD64", Offset = "0xD7FD64", VA = "0xD7FD64", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xD7FE4C", Offset = "0xD7FE4C", VA = "0xD7FE4C", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xD7FF34", Offset = "0xD7FF34", VA = "0xD7FF34")]
	public SoundsForJoinAndLeave()
	{
	}
}
[Token(Token = "0x2000025")]
public class OddersInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x2000026")]
	public struct OddersHMDActions
	{
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000015")]
		public InputAction Position
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xD808E8", Offset = "0xD808E8", VA = "0xD808E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xD80904", Offset = "0xD80904", VA = "0xD80904")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		public bool enabled
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xD80984", Offset = "0xD80984", VA = "0xD80984")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD808E0", Offset = "0xD808E0", VA = "0xD808E0")]
		public OddersHMDActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xD80920", Offset = "0xD80920", VA = "0xD80920")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xD8093C", Offset = "0xD8093C", VA = "0xD8093C")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD80960", Offset = "0xD80960", VA = "0xD80960")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD809A8", Offset = "0xD809A8", VA = "0xD809A8")]
		public static implicit operator InputActionMap(OddersHMDActions set)
		{
			return null;
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD809C0", Offset = "0xD809C0", VA = "0xD809C0")]
		public void SetCallbacks(IOddersHMDActions instance)
		{
		}
	}

	[Token(Token = "0x2000027")]
	public struct OddersLeftHandActions
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000018")]
		public InputAction Position
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xD8114C", Offset = "0xD8114C", VA = "0xD8114C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xD81168", Offset = "0xD81168", VA = "0xD81168")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public InputAction Grip
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xD81184", Offset = "0xD81184", VA = "0xD81184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public InputAction Trigger
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xD811A0", Offset = "0xD811A0", VA = "0xD811A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xD811BC", Offset = "0xD811BC", VA = "0xD811BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xD811D8", Offset = "0xD811D8", VA = "0xD811D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public InputAction Menu
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xD811F4", Offset = "0xD811F4", VA = "0xD811F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xD81210", Offset = "0xD81210", VA = "0xD81210")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0xD8122C", Offset = "0xD8122C", VA = "0xD8122C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public InputAction Velocity
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0xD81248", Offset = "0xD81248", VA = "0xD81248")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public InputAction Acceleration
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0xD81264", Offset = "0xD81264", VA = "0xD81264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xD81280", Offset = "0xD81280", VA = "0xD81280")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public InputAction GrabAction
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xD8129C", Offset = "0xD8129C", VA = "0xD8129C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public InputAction GrabAnimationAction
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xD812B8", Offset = "0xD812B8", VA = "0xD812B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		public bool enabled
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xD81338", Offset = "0xD81338", VA = "0xD81338")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD81144", Offset = "0xD81144", VA = "0xD81144")]
		public OddersLeftHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD812D4", Offset = "0xD812D4", VA = "0xD812D4")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD812F0", Offset = "0xD812F0", VA = "0xD812F0")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD81314", Offset = "0xD81314", VA = "0xD81314")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD8135C", Offset = "0xD8135C", VA = "0xD8135C")]
		public static implicit operator InputActionMap(OddersLeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD81374", Offset = "0xD81374", VA = "0xD81374")]
		public void SetCallbacks(IOddersLeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x2000028")]
	public struct OddersRightHandActions
	{
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000027")]
		public InputAction Position
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xD845C0", Offset = "0xD845C0", VA = "0xD845C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xD845DC", Offset = "0xD845DC", VA = "0xD845DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public InputAction Grip
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xD845F8", Offset = "0xD845F8", VA = "0xD845F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public InputAction Trigger
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xD84614", Offset = "0xD84614", VA = "0xD84614")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0xD84630", Offset = "0xD84630", VA = "0xD84630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xD8464C", Offset = "0xD8464C", VA = "0xD8464C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public InputAction Menu
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xD84668", Offset = "0xD84668", VA = "0xD84668")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xD84684", Offset = "0xD84684", VA = "0xD84684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xD846A0", Offset = "0xD846A0", VA = "0xD846A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public InputAction Velocity
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xD846BC", Offset = "0xD846BC", VA = "0xD846BC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public InputAction Acceleration
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xD846D8", Offset = "0xD846D8", VA = "0xD846D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xD846F4", Offset = "0xD846F4", VA = "0xD846F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public InputAction GrabAction
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0xD84710", Offset = "0xD84710", VA = "0xD84710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public InputAction GrabAnimationAction
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xD8472C", Offset = "0xD8472C", VA = "0xD8472C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public InputAction ShowFullVersion
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0xD84748", Offset = "0xD84748", VA = "0xD84748")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		public bool enabled
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0xD847C8", Offset = "0xD847C8", VA = "0xD847C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD845B8", Offset = "0xD845B8", VA = "0xD845B8")]
		public OddersRightHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xD84764", Offset = "0xD84764", VA = "0xD84764")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xD84780", Offset = "0xD84780", VA = "0xD84780")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD847A4", Offset = "0xD847A4", VA = "0xD847A4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xD847EC", Offset = "0xD847EC", VA = "0xD847EC")]
		public static implicit operator InputActionMap(OddersRightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD84804", Offset = "0xD84804", VA = "0xD84804")]
		public void SetCallbacks(IOddersRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x2000029")]
	public interface IOddersHMDActions
	{
		[Token(Token = "0x60000F4")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60000F5")]
		void OnRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x200002A")]
	public interface IOddersLeftHandActions
	{
		[Token(Token = "0x60000F6")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60000F7")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x60000F8")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x60000F9")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x60000FA")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x60000FB")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x60000FC")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x60000FD")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000FE")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000FF")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x6000100")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000101")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000102")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x6000103")]
		void OnGrabAnimationAction(InputAction.CallbackContext context);
	}

	[Token(Token = "0x200002B")]
	public interface IOddersRightHandActions
	{
		[Token(Token = "0x6000104")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x6000105")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x6000106")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x6000107")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x6000108")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x6000109")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x600010A")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x600010B")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x600010C")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x600010D")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x600010E")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x600010F")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x6000110")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x6000111")]
		void OnGrabAnimationAction(InputAction.CallbackContext context);

		[Token(Token = "0x6000112")]
		void OnShowFullVersion(InputAction.CallbackContext context);
	}

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_OddersHMD;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private IOddersHMDActions m_OddersHMDActionsCallbackInterface;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InputAction m_OddersHMD_Position;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly InputAction m_OddersHMD_Rotation;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InputActionMap m_OddersLeftHand;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private IOddersLeftHandActions m_OddersLeftHandActionsCallbackInterface;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly InputAction m_OddersLeftHand_Position;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly InputAction m_OddersLeftHand_Rotation;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly InputAction m_OddersLeftHand_Grip;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly InputAction m_OddersLeftHand_Trigger;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly InputAction m_OddersLeftHand_HapticDevice;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly InputAction m_OddersLeftHand_SwapUIRay;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly InputAction m_OddersLeftHand_Menu;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly InputAction m_OddersLeftHand_PrimaryButton;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly InputAction m_OddersLeftHand_SecundaryButton;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly InputAction m_OddersLeftHand_Velocity;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly InputAction m_OddersLeftHand_Acceleration;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_OddersLeftHand_AngularAcceleration;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly InputAction m_OddersLeftHand_GrabAction;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private readonly InputAction m_OddersLeftHand_GrabAnimationAction;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private readonly InputActionMap m_OddersRightHand;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private IOddersRightHandActions m_OddersRightHandActionsCallbackInterface;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private readonly InputAction m_OddersRightHand_Position;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_OddersRightHand_Rotation;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly InputAction m_OddersRightHand_Grip;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly InputAction m_OddersRightHand_Trigger;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_OddersRightHand_HapticDevice;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_OddersRightHand_SwapUIRay;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_OddersRightHand_Menu;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly InputAction m_OddersRightHand_PrimaryButton;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly InputAction m_OddersRightHand_SecundaryButton;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly InputAction m_OddersRightHand_Velocity;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly InputAction m_OddersRightHand_Acceleration;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly InputAction m_OddersRightHand_AngularAcceleration;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly InputAction m_OddersRightHand_GrabAction;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private readonly InputAction m_OddersRightHand_GrabAnimationAction;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private readonly InputAction m_OddersRightHand_ShowFullVersion;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private int m_GenericXRControllerSchemeIndex;

	[Token(Token = "0x1700000C")]
	public InputActionAsset asset
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD7FF3C", Offset = "0xD7FF3C", VA = "0xD7FF3C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000D")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xD805D0", Offset = "0xD805D0", VA = "0xD805D0", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xD805F8", Offset = "0xD805F8", VA = "0xD805F8", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xD80644", Offset = "0xD80644", VA = "0xD80644", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xD80684", Offset = "0xD80684", VA = "0xD80684", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xD806D0", Offset = "0xD806D0", VA = "0xD806D0", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x17000010")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD80778", Offset = "0xD80778", VA = "0xD80778", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000011")]
	public OddersHMDActions OddersHMD
	{
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD80810", Offset = "0xD80810", VA = "0xD80810")]
		get
		{
			return default(OddersHMDActions);
		}
	}

	[Token(Token = "0x17000012")]
	public OddersLeftHandActions OddersLeftHand
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD80814", Offset = "0xD80814", VA = "0xD80814")]
		get
		{
			return default(OddersLeftHandActions);
		}
	}

	[Token(Token = "0x17000013")]
	public OddersRightHandActions OddersRightHand
	{
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD80818", Offset = "0xD80818", VA = "0xD80818")]
		get
		{
			return default(OddersRightHandActions);
		}
	}

	[Token(Token = "0x17000014")]
	public InputControlScheme GenericXRControllerScheme
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD8081C", Offset = "0xD8081C", VA = "0xD8081C")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xD7FF44", Offset = "0xD7FF44", VA = "0xD7FF44")]
	public OddersInputActions()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xD80574", Offset = "0xD80574", VA = "0xD80574", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xD806EC", Offset = "0xD806EC", VA = "0xD806EC", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xD80708", Offset = "0xD80708", VA = "0xD80708", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xD80724", Offset = "0xD80724", VA = "0xD80724", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xD80740", Offset = "0xD80740", VA = "0xD80740", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xD8075C", Offset = "0xD8075C", VA = "0xD8075C", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xD80794", Offset = "0xD80794", VA = "0xD80794", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xD807B4", Offset = "0xD807B4", VA = "0xD807B4", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
[Token(Token = "0x200002C")]
public class DebugUIBuilder : MonoBehaviour
{
	[Token(Token = "0x200002D")]
	public delegate void OnClick();

	[Token(Token = "0x200002E")]
	public delegate void OnToggleValueChange(Toggle t);

	[Token(Token = "0x200002F")]
	public delegate void OnSlider(float f);

	[Token(Token = "0x2000030")]
	public delegate bool ActiveUpdate();

	[Token(Token = "0x4000116")]
	public const int DEBUG_PANE_CENTER = 0;

	[Token(Token = "0x4000117")]
	public const int DEBUG_PANE_RIGHT = 1;

	[Token(Token = "0x4000118")]
	public const int DEBUG_PANE_LEFT = 2;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform buttonPrefab;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform[] additionalButtonPrefab;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform labelPrefab;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private RectTransform sliderPrefab;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private RectTransform dividerPrefab;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private RectTransform togglePrefab;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private RectTransform radioPrefab;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject uiHelpersToInstantiate;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Transform[] targetContentPanels;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool[] reEnable;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private List<GameObject> toEnable;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<GameObject> toDisable;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static DebugUIBuilder instance;

	[Token(Token = "0x4000127")]
	private const float elementSpacing = 16f;

	[Token(Token = "0x4000128")]
	public const float marginH = 16f;

	[Token(Token = "0x4000129")]
	public const float marginV = 16f;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector2[] insertPositions;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RectTransform>[] insertedElements;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 menuOffset;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private OVRCameraRig rig;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Dictionary<string, ToggleGroup> radioGroups;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private LaserPointer lp;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private LineRenderer lr;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public LaserPointer.LaserBeamBehavior laserBeamBehavior;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public bool isHorizontal;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xD87DD8", Offset = "0xD87DD8", VA = "0xD87DD8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xD88288", Offset = "0xD88288", VA = "0xD88288")]
	public void Show()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xD887FC", Offset = "0xD887FC", VA = "0xD887FC")]
	public void Hide()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xD885E0", Offset = "0xD885E0", VA = "0xD885E0")]
	private void Relayout()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xD88978", Offset = "0xD88978", VA = "0xD88978")]
	private void AddRect(RectTransform r, int targetCanvas)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xD88C7C", Offset = "0xD88C7C", VA = "0xD88C7C")]
	public RectTransform AddButton(string label, [Optional] OnClick handler, int buttonIndex = -1, int targetCanvas = 0, bool highResolutionText = false)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xD8900C", Offset = "0xD8900C", VA = "0xD8900C")]
	public RectTransform AddLabel(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xD89104", Offset = "0xD89104", VA = "0xD89104")]
	public RectTransform AddSlider(string label, float min, float max, OnSlider onValueChanged, bool wholeNumbersOnly = false, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xD892C0", Offset = "0xD892C0", VA = "0xD892C0")]
	public RectTransform AddDivider(int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xD89358", Offset = "0xD89358", VA = "0xD89358")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xD8950C", Offset = "0xD8950C", VA = "0xD8950C")]
	public RectTransform AddToggle(string label, OnToggleValueChange onValueChanged, bool defaultValue, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xD896E0", Offset = "0xD896E0", VA = "0xD896E0")]
	public RectTransform AddRadio(string label, string group, OnToggleValueChange handler, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xD899B4", Offset = "0xD899B4", VA = "0xD899B4")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xD89AA4", Offset = "0xD89AA4", VA = "0xD89AA4")]
	public void ToggleLaserPointer(bool isOn)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xD89B38", Offset = "0xD89B38", VA = "0xD89B38")]
	public DebugUIBuilder()
	{
	}
}
[Token(Token = "0x2000036")]
public class HandedInputSelector : MonoBehaviour
{
	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRCameraRig m_CameraRig;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private OVRInputModule m_InputModule;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xD8A184", Offset = "0xD8A184", VA = "0xD8A184")]
	private void Start()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xD8A214", Offset = "0xD8A214", VA = "0xD8A214")]
	private void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xD8A2B0", Offset = "0xD8A2B0", VA = "0xD8A2B0")]
	private void SetActiveController(OVRInput.Controller c)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xD8A2E8", Offset = "0xD8A2E8", VA = "0xD8A2E8")]
	public HandedInputSelector()
	{
	}
}
[Token(Token = "0x2000037")]
public class LaserPointer : OVRCursor
{
	[Token(Token = "0x2000038")]
	public enum LaserBeamBehavior
	{
		[Token(Token = "0x4000147")]
		On,
		[Token(Token = "0x4000148")]
		Off,
		[Token(Token = "0x4000149")]
		OnWhenHitTarget
	}

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject cursorVisual;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float maxLength;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private LaserBeamBehavior _laserBeamBehavior;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool m_restoreOnInputAcquired;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private Vector3 _startPoint;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 _forward;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 _endPoint;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool _hitTarget;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private LineRenderer lineRenderer;

	[Token(Token = "0x17000037")]
	public LaserBeamBehavior laserBeamBehavior
	{
		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD8A330", Offset = "0xD8A330", VA = "0xD8A330")]
		get
		{
			return default(LaserBeamBehavior);
		}
		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD8A2F0", Offset = "0xD8A2F0", VA = "0xD8A2F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xD8A338", Offset = "0xD8A338", VA = "0xD8A338")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xD8A388", Offset = "0xD8A388", VA = "0xD8A388")]
	private void Start()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xD8A4C0", Offset = "0xD8A4C0", VA = "0xD8A4C0", Slot = "5")]
	public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xD8A4DC", Offset = "0xD8A4DC", VA = "0xD8A4DC", Slot = "4")]
	public override void SetCursorRay(Transform t)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xD8A52C", Offset = "0xD8A52C", VA = "0xD8A52C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xD8A6CC", Offset = "0xD8A6CC", VA = "0xD8A6CC")]
	private void UpdateLaserBeam(Vector3 start, Vector3 end)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xD8A7DC", Offset = "0xD8A7DC", VA = "0xD8A7DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xD8A860", Offset = "0xD8A860", VA = "0xD8A860")]
	public void OnInputFocusLost()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xD8A920", Offset = "0xD8A920", VA = "0xD8A920")]
	public void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xD8A9C8", Offset = "0xD8A9C8", VA = "0xD8A9C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xD8AAB4", Offset = "0xD8AAB4", VA = "0xD8AAB4")]
	public LaserPointer()
	{
	}
}
[Token(Token = "0x2000039")]
public class CharacterCameraConstraint : MonoBehaviour
{
	[Token(Token = "0x400014A")]
	private const float FADE_RAY_LENGTH = 0.25f;

	[Token(Token = "0x400014B")]
	private const float FADE_OVERLAP_MAXIMUM = 0.1f;

	[Token(Token = "0x400014C")]
	private const float FADE_AMOUNT_MAXIMUM = 1f;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("This should be a reference to the OVRCameraRig that is usually a child of the PlayerController.")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("Collision layers to be used for the purposes of fading out the screen when the HMD is inside world geometry and adjusting the capsule height.")]
	public LayerMask CollideLayers;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Offset is added to camera's real world height, effectively treating it as though the player was taller/standing higher.")]
	public float HeightOffset;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("Minimum height that the character capsule can shrink to.  To disable, set to capsule's height.")]
	public float MinimumHeight;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("Maximum height that the character capsule can grow to.  To disable, set to capsule's height.")]
	public float MaximumHeight;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CapsuleCollider _character;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SimpleCapsuleWithStickMovement _simplePlayerController;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xD8AAC4", Offset = "0xD8AAC4", VA = "0xD8AAC4")]
	private CharacterCameraConstraint()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xD8AACC", Offset = "0xD8AACC", VA = "0xD8AACC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xD8AB48", Offset = "0xD8AB48", VA = "0xD8AB48")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xD8AC6C", Offset = "0xD8AC6C", VA = "0xD8AC6C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xD8AD90", Offset = "0xD8AD90", VA = "0xD8AD90")]
	private void CameraUpdate()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xD8B0B0", Offset = "0xD8B0B0", VA = "0xD8B0B0")]
	private bool CheckCameraOverlapped()
	{
		return default(bool);
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xD8B310", Offset = "0xD8B310", VA = "0xD8B310")]
	private bool CheckCameraNearClipping(out float result)
	{
		return default(bool);
	}
}
[Token(Token = "0x200003A")]
public class LocomotionController : MonoBehaviour
{
	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CapsuleCollider CharacterController;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SimpleCapsuleWithStickMovement PlayerController;

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xD8BA68", Offset = "0xD8BA68", VA = "0xD8BA68")]
	private void Start()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xD8BB00", Offset = "0xD8BB00", VA = "0xD8BB00")]
	public LocomotionController()
	{
	}
}
[Token(Token = "0x200003B")]
public class LocomotionTeleport : MonoBehaviour
{
	[Token(Token = "0x200003C")]
	public enum States
	{
		[Token(Token = "0x400017A")]
		Ready,
		[Token(Token = "0x400017B")]
		Aim,
		[Token(Token = "0x400017C")]
		CancelAim,
		[Token(Token = "0x400017D")]
		PreTeleport,
		[Token(Token = "0x400017E")]
		CancelTeleport,
		[Token(Token = "0x400017F")]
		Teleporting,
		[Token(Token = "0x4000180")]
		PostTeleport
	}

	[Token(Token = "0x200003D")]
	public enum TeleportIntentions
	{
		[Token(Token = "0x4000182")]
		None,
		[Token(Token = "0x4000183")]
		Aim,
		[Token(Token = "0x4000184")]
		PreTeleport,
		[Token(Token = "0x4000185")]
		Teleport
	}

	[Token(Token = "0x200003E")]
	public enum AimCollisionTypes
	{
		[Token(Token = "0x4000187")]
		Point,
		[Token(Token = "0x4000188")]
		Sphere,
		[Token(Token = "0x4000189")]
		Capsule
	}

	[Token(Token = "0x200003F")]
	public class AimData
	{
		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RaycastHit TargetHitInfo;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool TargetValid;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3? Destination;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float Radius;

		[Token(Token = "0x1700003B")]
		public List<Vector3> Points
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0xD8D7B0", Offset = "0xD8D7B0", VA = "0xD8D7B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0xD8D7B8", Offset = "0xD8D7B8", VA = "0xD8D7B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xD8D730", Offset = "0xD8D730", VA = "0xD8D730")]
		public AimData()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xD8D7C0", Offset = "0xD8D7C0", VA = "0xD8D7C0")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <ReadyStateCoroutine>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0xD8D908", Offset = "0xD8D908", VA = "0xD8D908", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0xD8D950", Offset = "0xD8D950", VA = "0xD8D950", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xD8C4CC", Offset = "0xD8C4CC", VA = "0xD8C4CC")]
		[DebuggerHidden]
		public <ReadyStateCoroutine>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xD8D818", Offset = "0xD8D818", VA = "0xD8D818", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xD8D81C", Offset = "0xD8D81C", VA = "0xD8D81C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xD8D910", Offset = "0xD8D910", VA = "0xD8D910", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class <AimStateCoroutine>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0xD8DA9C", Offset = "0xD8DA9C", VA = "0xD8DA9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000199")]
			[Address(RVA = "0xD8DAE4", Offset = "0xD8DAE4", VA = "0xD8DAE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xD8C948", Offset = "0xD8C948", VA = "0xD8C948")]
		[DebuggerHidden]
		public <AimStateCoroutine>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xD8D958", Offset = "0xD8D958", VA = "0xD8D958", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xD8D95C", Offset = "0xD8D95C", VA = "0xD8D95C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xD8DAA4", Offset = "0xD8DAA4", VA = "0xD8DAA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class <CancelAimStateCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019D")]
			[Address(RVA = "0xD8DB90", Offset = "0xD8DB90", VA = "0xD8DB90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0xD8DBD8", Offset = "0xD8DBD8", VA = "0xD8DBD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xD8CB10", Offset = "0xD8CB10", VA = "0xD8CB10")]
		[DebuggerHidden]
		public <CancelAimStateCoroutine>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0xD8DAEC", Offset = "0xD8DAEC", VA = "0xD8DAEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xD8DAF0", Offset = "0xD8DAF0", VA = "0xD8DAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xD8DB98", Offset = "0xD8DB98", VA = "0xD8DB98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class <PreTeleportStateCoroutine>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xD8DCBC", Offset = "0xD8DCBC", VA = "0xD8DCBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0xD8DD04", Offset = "0xD8DD04", VA = "0xD8DD04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xD8CCD8", Offset = "0xD8CCD8", VA = "0xD8CCD8")]
		[DebuggerHidden]
		public <PreTeleportStateCoroutine>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xD8DBE0", Offset = "0xD8DBE0", VA = "0xD8DBE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xD8DBE4", Offset = "0xD8DBE4", VA = "0xD8DBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD8DCC4", Offset = "0xD8DCC4", VA = "0xD8DCC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class <CancelTeleportStateCoroutine>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xD8DDB0", Offset = "0xD8DDB0", VA = "0xD8DDB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0xD8DDF8", Offset = "0xD8DDF8", VA = "0xD8DDF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD8CEA0", Offset = "0xD8CEA0", VA = "0xD8CEA0")]
		[DebuggerHidden]
		public <CancelTeleportStateCoroutine>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD8DD0C", Offset = "0xD8DD0C", VA = "0xD8DD0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD8DD10", Offset = "0xD8DD10", VA = "0xD8DD10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xD8DDB8", Offset = "0xD8DDB8", VA = "0xD8DDB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class <TeleportingStateCoroutine>d__80 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0xD8DED8", Offset = "0xD8DED8", VA = "0xD8DED8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0xD8DF20", Offset = "0xD8DF20", VA = "0xD8DF20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD8D068", Offset = "0xD8D068", VA = "0xD8D068")]
		[DebuggerHidden]
		public <TeleportingStateCoroutine>d__80(int <>1__state)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD8DE00", Offset = "0xD8DE00", VA = "0xD8DE00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD8DE04", Offset = "0xD8DE04", VA = "0xD8DE04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD8DEE0", Offset = "0xD8DEE0", VA = "0xD8DEE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class <PostTeleportStateCoroutine>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocomotionTeleport <>4__this;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0xD8E010", Offset = "0xD8E010", VA = "0xD8E010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0xD8E058", Offset = "0xD8E058", VA = "0xD8E058", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD8D230", Offset = "0xD8D230", VA = "0xD8D230")]
		[DebuggerHidden]
		public <PostTeleportStateCoroutine>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xD8DF28", Offset = "0xD8DF28", VA = "0xD8DF28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xD8DF2C", Offset = "0xD8DF2C", VA = "0xD8DF2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xD8E018", Offset = "0xD8E018", VA = "0xD8E018", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("Allow linear movement prior to the teleport system being activated.")]
	public bool EnableMovementDuringReady;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Tooltip("Allow linear movement while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableMovementDuringAim;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Tooltip("Allow linear movement while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableMovementDuringPreTeleport;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	[Tooltip("Allow linear movement after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableMovementDuringPostTeleport;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("Allow rotation prior to the teleport system being activated.")]
	public bool EnableRotationDuringReady;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[Tooltip("Allow rotation while the teleport system is in the process of aiming for a teleport target.")]
	public bool EnableRotationDuringAim;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[Tooltip("Allow rotation while the teleport system is in the process of configuring the landing orientation.")]
	public bool EnableRotationDuringPreTeleport;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[Tooltip("Allow rotation after the teleport has occurred but before the system has returned to the ready state.")]
	public bool EnableRotationDuringPostTeleport;

	[NonSerialized]
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TeleportAimHandler AimHandler;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("This prefab will be instantiated as needed and updated to match the current aim target.")]
	public TeleportDestination TeleportDestinationPrefab;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("TeleportDestinationPrefab will be instantiated into this layer.")]
	public int TeleportDestinationLayer;

	[NonSerialized]
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TeleportInputHandler InputHandler;

	[NonSerialized]
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TeleportIntentions CurrentIntention;

	[NonSerialized]
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public bool IsPreTeleportRequested;

	[NonSerialized]
	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	public bool IsTransitioning;

	[NonSerialized]
	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
	public bool IsPostTeleportRequested;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TeleportDestination _teleportDestination;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Tooltip("When aiming at possible destinations, the aim collision type determines which shape to use for collision tests.")]
	public AimCollisionTypes AimCollisionType;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Tooltip("Use the character collision radius/height/skinwidth for sphere/capsule collision tests.")]
	public bool UseCharacterCollisionData;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Tooltip("Radius of the sphere or capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionRadius;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Tooltip("Height of the capsule used for collision testing when aiming to possible teleport destinations. Ignored if UseCharacterCollisionData is true.")]
	public float AimCollisionHeight;

	[Token(Token = "0x17000038")]
	public States CurrentState
	{
		[Token(Token = "0x6000158")]
		[Address(RVA = "0xD8BB50", Offset = "0xD8BB50", VA = "0xD8BB50")]
		[CompilerGenerated]
		get
		{
			return default(States);
		}
		[Token(Token = "0x6000159")]
		[Address(RVA = "0xD8BB58", Offset = "0xD8BB58", VA = "0xD8BB58")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public Quaternion DestinationRotation
	{
		[Token(Token = "0x600015D")]
		[Address(RVA = "0xD8BD28", Offset = "0xD8BD28", VA = "0xD8BD28")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x1700003A")]
	public LocomotionController LocomotionController
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xD8BD4C", Offset = "0xD8BD4C", VA = "0xD8BD4C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600015F")]
		[Address(RVA = "0xD8BD54", Offset = "0xD8BD54", VA = "0xD8BD54")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event Action<bool, Vector3?, Quaternion?, Quaternion?> UpdateTeleportDestination
	{
		[Token(Token = "0x600015A")]
		[Address(RVA = "0xD8BB60", Offset = "0xD8BB60", VA = "0xD8BB60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600015B")]
		[Address(RVA = "0xD8BC10", Offset = "0xD8BC10", VA = "0xD8BC10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event Action EnterStateReady
	{
		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD8C394", Offset = "0xD8C394", VA = "0xD8C394")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD8C430", Offset = "0xD8C430", VA = "0xD8C430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event Action EnterStateAim
	{
		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD8C4F4", Offset = "0xD8C4F4", VA = "0xD8C4F4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xD8C590", Offset = "0xD8C590", VA = "0xD8C590")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event Action<AimData> UpdateAimData
	{
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD8C62C", Offset = "0xD8C62C", VA = "0xD8C62C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD8C6DC", Offset = "0xD8C6DC", VA = "0xD8C6DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event Action ExitStateAim
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD8C7A8", Offset = "0xD8C7A8", VA = "0xD8C7A8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD8C844", Offset = "0xD8C844", VA = "0xD8C844")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event Action EnterStateCancelAim
	{
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD8C970", Offset = "0xD8C970", VA = "0xD8C970")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD8CA0C", Offset = "0xD8CA0C", VA = "0xD8CA0C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event Action EnterStatePreTeleport
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xD8CB38", Offset = "0xD8CB38", VA = "0xD8CB38")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xD8CBD4", Offset = "0xD8CBD4", VA = "0xD8CBD4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action EnterStateCancelTeleport
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xD8CD00", Offset = "0xD8CD00", VA = "0xD8CD00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xD8CD9C", Offset = "0xD8CD9C", VA = "0xD8CD9C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action EnterStateTeleporting
	{
		[Token(Token = "0x600017D")]
		[Address(RVA = "0xD8CEC8", Offset = "0xD8CEC8", VA = "0xD8CEC8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600017E")]
		[Address(RVA = "0xD8CF64", Offset = "0xD8CF64", VA = "0xD8CF64")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action EnterStatePostTeleport
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0xD8D090", Offset = "0xD8D090", VA = "0xD8D090")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000181")]
		[Address(RVA = "0xD8D12C", Offset = "0xD8D12C", VA = "0xD8D12C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action<Transform, Vector3, Quaternion> Teleported
	{
		[Token(Token = "0x6000183")]
		[Address(RVA = "0xD8D258", Offset = "0xD8D258", VA = "0xD8D258")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000184")]
		[Address(RVA = "0xD8D308", Offset = "0xD8D308", VA = "0xD8D308")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xD8BB08", Offset = "0xD8BB08", VA = "0xD8BB08")]
	public void EnableMovement(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xD8BB2C", Offset = "0xD8BB2C", VA = "0xD8BB2C")]
	public void EnableRotation(bool ready, bool aim, bool pre, bool post)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xD8BCC0", Offset = "0xD8BCC0", VA = "0xD8BCC0")]
	public void OnUpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xD8BD5C", Offset = "0xD8BD5C", VA = "0xD8BD5C")]
	public bool AimCollisionTest(Vector3 start, Vector3 end, LayerMask aimCollisionLayerMask, out RaycastHit hitInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xD8C024", Offset = "0xD8C024", VA = "0xD8C024")]
	[Conditional("DEBUG_TELEPORT_STATES")]
	protected void LogState(string msg)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xD8C0CC", Offset = "0xD8C0CC", VA = "0xD8C0CC")]
	protected void CreateNewTeleportDestination()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xD8C190", Offset = "0xD8C190", VA = "0xD8C190")]
	private void DeactivateDestination()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xD8C1CC", Offset = "0xD8C1CC", VA = "0xD8C1CC")]
	public void RecycleTeleportDestination(TeleportDestination oldDestination)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xD8C27C", Offset = "0xD8C27C", VA = "0xD8C27C")]
	private void EnableMotion(bool enableLinear, bool enableRotation)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xD8C2AC", Offset = "0xD8C2AC", VA = "0xD8C2AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xD8C300", Offset = "0xD8C300", VA = "0xD8C300", Slot = "4")]
	public virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xD8C38C", Offset = "0xD8C38C", VA = "0xD8C38C", Slot = "5")]
	public virtual void OnDisable()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xD8C324", Offset = "0xD8C324", VA = "0xD8C324")]
	[IteratorStateMachine(typeof(<ReadyStateCoroutine>d__52))]
	protected IEnumerator ReadyStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xD8C78C", Offset = "0xD8C78C", VA = "0xD8C78C")]
	public void OnUpdateAimData(AimData aimData)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xD8C8E0", Offset = "0xD8C8E0", VA = "0xD8C8E0")]
	[IteratorStateMachine(typeof(<AimStateCoroutine>d__64))]
	protected IEnumerator AimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xD8CAA8", Offset = "0xD8CAA8", VA = "0xD8CAA8")]
	[IteratorStateMachine(typeof(<CancelAimStateCoroutine>d__68))]
	protected IEnumerator CancelAimStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xD8CC70", Offset = "0xD8CC70", VA = "0xD8CC70")]
	[IteratorStateMachine(typeof(<PreTeleportStateCoroutine>d__72))]
	protected IEnumerator PreTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xD8CE38", Offset = "0xD8CE38", VA = "0xD8CE38")]
	[IteratorStateMachine(typeof(<CancelTeleportStateCoroutine>d__76))]
	protected IEnumerator CancelTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xD8D000", Offset = "0xD8D000", VA = "0xD8D000")]
	[IteratorStateMachine(typeof(<TeleportingStateCoroutine>d__80))]
	protected IEnumerator TeleportingStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xD8D1C8", Offset = "0xD8D1C8", VA = "0xD8D1C8")]
	[IteratorStateMachine(typeof(<PostTeleportStateCoroutine>d__84))]
	protected IEnumerator PostTeleportStateCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xD8D3B8", Offset = "0xD8D3B8", VA = "0xD8D3B8")]
	public void DoTeleport()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xD8D4CC", Offset = "0xD8D4CC", VA = "0xD8D4CC")]
	public Vector3 GetCharacterPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xD8D4FC", Offset = "0xD8D4FC", VA = "0xD8D4FC")]
	public Quaternion GetHeadRotationY()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xD8D638", Offset = "0xD8D638", VA = "0xD8D638")]
	public void DoWarp(Vector3 startPos, float positionPercent)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xD8D720", Offset = "0xD8D720", VA = "0xD8D720")]
	public LocomotionTeleport()
	{
	}
}
[Token(Token = "0x2000047")]
public class SimpleCapsuleWithStickMovement : MonoBehaviour
{
	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableLinearMovement;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool EnableRotation;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool HMDRotatesPlayer;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool RotationEitherThumbstick;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float RotationAngle;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig CameraRig;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool ReadyToSnapTurn;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x1400000C")]
	public event Action CameraUpdated
	{
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xD8ABD0", Offset = "0xD8ABD0", VA = "0xD8ABD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD8ACF4", Offset = "0xD8ACF4", VA = "0xD8ACF4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event Action PreCharacterMove
	{
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD8E060", Offset = "0xD8E060", VA = "0xD8E060")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD8E0FC", Offset = "0xD8E0FC", VA = "0xD8E0FC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0xD8E198", Offset = "0xD8E198", VA = "0xD8E198")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0xD8E250", Offset = "0xD8E250", VA = "0xD8E250")]
	private void Start()
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0xD8E254", Offset = "0xD8E254", VA = "0xD8E254")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0xD8E2C8", Offset = "0xD8E2C8", VA = "0xD8E2C8")]
	private void RotatePlayerToHMD()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0xD8E3EC", Offset = "0xD8E3EC", VA = "0xD8E3EC")]
	private void StickMovement()
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0xD8E664", Offset = "0xD8E664", VA = "0xD8E664")]
	private void SnapTurn()
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xD8E884", Offset = "0xD8E884", VA = "0xD8E884")]
	public SimpleCapsuleWithStickMovement()
	{
	}
}
[Token(Token = "0x2000048")]
public abstract class TeleportAimHandler : TeleportSupport
{
	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xD8E8A4", Offset = "0xD8E8A4", VA = "0xD8E8A4", Slot = "4")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xD8E924", Offset = "0xD8E924", VA = "0xD8E924", Slot = "5")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60001C5")]
	public abstract void GetPoints(List<Vector3> points);

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xD8E9D8", Offset = "0xD8E9D8", VA = "0xD8E9D8")]
	protected TeleportAimHandler()
	{
	}
}
[Token(Token = "0x2000049")]
public class TeleportAimHandlerLaser : TeleportAimHandler
{
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xD8E9E8", Offset = "0xD8E9E8", VA = "0xD8E9E8", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xD8EB78", Offset = "0xD8EB78", VA = "0xD8EB78")]
	public TeleportAimHandlerLaser()
	{
	}
}
[Token(Token = "0x200004A")]
public class TeleportAimHandlerParabolic : TeleportAimHandler
{
	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("Maximum range for aiming.")]
	public float Range;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The MinimumElevation is relative to the AimPosition.")]
	public float MinimumElevation;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The Gravity is used in conjunction with AimVelocity and the aim direction to simulate a projectile.")]
	public float Gravity;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("The AimVelocity is the initial speed of the faked projectile.")]
	[Range(0.001f, 50f)]
	public float AimVelocity;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0.001f, 1f)]
	[Tooltip("The AimStep is the how much to subdivide the iteration.")]
	public float AimStep;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xD8EB88", Offset = "0xD8EB88", VA = "0xD8EB88", Slot = "8")]
	public override void GetPoints(List<Vector3> points)
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xD8ED5C", Offset = "0xD8ED5C", VA = "0xD8ED5C")]
	public TeleportAimHandlerParabolic()
	{
	}
}
[Token(Token = "0x200004B")]
public class TeleportAimVisualLaser : TeleportSupport
{
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This prefab will be instantiated when the aim visual is awakened, and will be set active when the user is aiming, and deactivated when they are done aiming.")]
	public LineRenderer LaserPrefab;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _enterAimStateAction;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Action _exitAimStateAction;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private LineRenderer _lineRenderer;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] _linePoints;

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xD8ED70", Offset = "0xD8ED70", VA = "0xD8ED70")]
	public TeleportAimVisualLaser()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xD8EE7C", Offset = "0xD8EE7C", VA = "0xD8EE7C")]
	private void EnterAimState()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xD8EEA8", Offset = "0xD8EEA8", VA = "0xD8EEA8")]
	private void ExitAimState()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xD8EED4", Offset = "0xD8EED4", VA = "0xD8EED4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xD8EF70", Offset = "0xD8EF70", VA = "0xD8EF70", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xD8EFC4", Offset = "0xD8EFC4", VA = "0xD8EFC4", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xD8F014", Offset = "0xD8F014", VA = "0xD8F014")]
	private void UpdateAimData(LocomotionTeleport.AimData obj)
	{
	}
}
[Token(Token = "0x200004C")]
public class TeleportDestination : MonoBehaviour
{
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("If the target handler provides a target position, this transform will be moved to that position and it's game object enabled. A target position being provided does not mean the position is valid, only that the aim handler found something to test as a destination.")]
	public Transform PositionIndicator;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("This transform will be rotated to match the rotation of the aiming target. Simple teleport destinations should assign this to the object containing this component. More complex teleport destinations might assign this to a sub-object that is used to indicate the landing orientation independently from the rest of the destination indicator, such as when world space effects are required. This will typically be a child of the PositionIndicator.")]
	public Transform OrientationIndicator;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("After the player teleports, the character controller will have it's rotation set to this value. It is different from the OrientationIndicator transform.rotation in order to support both head-relative and forward-facing teleport modes (See TeleportOrientationHandlerThumbstick.cs).")]
	public Quaternion LandingRotation;

	[NonSerialized]
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LocomotionTeleport LocomotionTeleport;

	[NonSerialized]
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public LocomotionTeleport.States TeleportState;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Action<bool, Vector3?, Quaternion?, Quaternion?> _updateTeleportDestinationAction;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool _eventsActive;

	[Token(Token = "0x1700004A")]
	public bool IsValidDestination
	{
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xD8F110", Offset = "0xD8F110", VA = "0xD8F110")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xD8F118", Offset = "0xD8F118", VA = "0xD8F118")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event Action<TeleportDestination> Deactivated
	{
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xD8F298", Offset = "0xD8F298", VA = "0xD8F298")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xD8F348", Offset = "0xD8F348", VA = "0xD8F348")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xD8F124", Offset = "0xD8F124", VA = "0xD8F124")]
	private TeleportDestination()
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xD8F1A0", Offset = "0xD8F1A0", VA = "0xD8F1A0")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xD8F264", Offset = "0xD8F264", VA = "0xD8F264")]
	private void TryDisableEventHandlers()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xD8F294", Offset = "0xD8F294", VA = "0xD8F294")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xD8C1A8", Offset = "0xD8C1A8", VA = "0xD8C1A8")]
	public void OnDeactivated()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xD8F3F8", Offset = "0xD8F3F8", VA = "0xD8F3F8")]
	public void Recycle()
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xD8F414", Offset = "0xD8F414", VA = "0xD8F414", Slot = "4")]
	public virtual void UpdateTeleportDestination(bool isValidDestination, Vector3? position, Quaternion? rotation, Quaternion? landingRotation)
	{
	}
}
[Token(Token = "0x200004D")]
public abstract class TeleportInputHandler : TeleportSupport
{
	[Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class <TeleportReadyCoroutine>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0xD8F990", Offset = "0xD8F990", VA = "0xD8F990", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0xD8F9D8", Offset = "0xD8F9D8", VA = "0xD8F9D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xD8F814", Offset = "0xD8F814", VA = "0xD8F814")]
		[DebuggerHidden]
		public <TeleportReadyCoroutine>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xD8F90C", Offset = "0xD8F90C", VA = "0xD8F90C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xD8F910", Offset = "0xD8F910", VA = "0xD8F910", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xD8F998", Offset = "0xD8F998", VA = "0xD8F998", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class <TeleportAimCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportInputHandler <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0xD8FA70", Offset = "0xD8FA70", VA = "0xD8FA70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0xD8FAB8", Offset = "0xD8FAB8", VA = "0xD8FAB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xD8F8A4", Offset = "0xD8F8A4", VA = "0xD8F8A4")]
		[DebuggerHidden]
		public <TeleportAimCoroutine>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xD8F9E0", Offset = "0xD8F9E0", VA = "0xD8F9E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xD8F9E4", Offset = "0xD8F9E4", VA = "0xD8F9E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xD8FA78", Offset = "0xD8FA78", VA = "0xD8FA78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _startReadyAction;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xD8F608", Offset = "0xD8F608", VA = "0xD8F608")]
	protected TeleportInputHandler()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xD8F6C8", Offset = "0xD8F6C8", VA = "0xD8F6C8", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xD8F704", Offset = "0xD8F704", VA = "0xD8F704", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xD8F7AC", Offset = "0xD8F7AC", VA = "0xD8F7AC")]
	[IteratorStateMachine(typeof(<TeleportReadyCoroutine>d__5))]
	private IEnumerator TeleportReadyCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xD8F83C", Offset = "0xD8F83C", VA = "0xD8F83C")]
	[IteratorStateMachine(typeof(<TeleportAimCoroutine>d__6))]
	private IEnumerator TeleportAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	public abstract LocomotionTeleport.TeleportIntentions GetIntention();

	[Token(Token = "0x60001E3")]
	public abstract void GetAimData(out Ray aimRay);
}
[Token(Token = "0x2000050")]
public class TeleportInputHandlerHMD : TeleportInputHandler
{
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("The button used to begin aiming for a teleport.")]
	public OVRInput.RawButton AimButton;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("The button used to trigger the teleport after aiming. It can be the same button as the AimButton, however you cannot abort a teleport if it is.")]
	public OVRInput.RawButton TeleportButton;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("When true, the system will not use the PreTeleport intention which will allow a teleport to occur on a button downpress. When false, the button downpress will trigger the PreTeleport intention and the Teleport intention when the button is released.")]
	public bool FastTeleport;

	[Token(Token = "0x1700004F")]
	public Transform Pointer
	{
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xD8FAC0", Offset = "0xD8FAC0", VA = "0xD8FAC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xD8FAC8", Offset = "0xD8FAC8", VA = "0xD8FAC8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xD8FAD0", Offset = "0xD8FAD0", VA = "0xD8FAD0", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xD8FBFC", Offset = "0xD8FBFC", VA = "0xD8FBFC", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xD8FCB0", Offset = "0xD8FCB0", VA = "0xD8FCB0")]
	public TeleportInputHandlerHMD()
	{
	}
}
[Token(Token = "0x2000051")]
public class TeleportInputHandlerTouch : TeleportInputHandlerHMD
{
	[Token(Token = "0x2000052")]
	public enum InputModes
	{
		[Token(Token = "0x40001DA")]
		CapacitiveButtonForAimAndTeleport,
		[Token(Token = "0x40001DB")]
		SeparateButtonsForAimAndTeleport,
		[Token(Token = "0x40001DC")]
		ThumbstickTeleport,
		[Token(Token = "0x40001DD")]
		ThumbstickTeleportForwardBackOnly
	}

	[Token(Token = "0x2000053")]
	public enum AimCapTouchButtons
	{
		[Token(Token = "0x40001DF")]
		A,
		[Token(Token = "0x40001E0")]
		B,
		[Token(Token = "0x40001E1")]
		LeftTrigger,
		[Token(Token = "0x40001E2")]
		LeftThumbstick,
		[Token(Token = "0x40001E3")]
		RightTrigger,
		[Token(Token = "0x40001E4")]
		RightThumbstick,
		[Token(Token = "0x40001E5")]
		X,
		[Token(Token = "0x40001E6")]
		Y
	}

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform LeftHand;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform RightHand;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Tooltip("CapacitiveButtonForAimAndTeleport=Activate aiming via cap touch detection, press the same button to teleport.\nSeparateButtonsForAimAndTeleport=Use one button to begin aiming, and another to trigger the teleport.\nThumbstickTeleport=Push a thumbstick to begin aiming, release to teleport.")]
	public InputModes InputMode;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly OVRInput.RawButton[] _rawButtons;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly OVRInput.RawTouch[] _rawTouch;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("Select the controller to be used for aiming. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller AimingController;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private OVRInput.Controller InitiatingController;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Tooltip("Select the button to use for triggering aim and teleport when InputMode==CapacitiveButtonForAimAndTeleport")]
	public AimCapTouchButtons CapacitiveAimAndTeleportButton;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Tooltip("The thumbstick magnitude required to trigger aiming and teleports when InputMode==InputModes.ThumbstickTeleport")]
	public float ThumbstickTeleportThreshold;

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xD8FCB4", Offset = "0xD8FCB4", VA = "0xD8FCB4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xD8FCB8", Offset = "0xD8FCB8", VA = "0xD8FCB8", Slot = "8")]
	public override LocomotionTeleport.TeleportIntentions GetIntention()
	{
		return default(LocomotionTeleport.TeleportIntentions);
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xD900EC", Offset = "0xD900EC", VA = "0xD900EC", Slot = "9")]
	public override void GetAimData(out Ray aimRay)
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xD901A8", Offset = "0xD901A8", VA = "0xD901A8")]
	public TeleportInputHandlerTouch()
	{
	}
}
[Token(Token = "0x2000054")]
public abstract class TeleportOrientationHandler : TeleportSupport
{
	[Token(Token = "0x2000055")]
	public enum OrientationModes
	{
		[Token(Token = "0x40001EB")]
		HeadRelative,
		[Token(Token = "0x40001EC")]
		ForwardFacing
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <UpdateOrientationCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportOrientationHandler <>4__this;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0xD90614", Offset = "0xD90614", VA = "0xD90614", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0xD9065C", Offset = "0xD9065C", VA = "0xD9065C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xD90430", Offset = "0xD90430", VA = "0xD90430")]
		[DebuggerHidden]
		public <UpdateOrientationCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xD90570", Offset = "0xD90570", VA = "0xD90570", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0xD90574", Offset = "0xD90574", VA = "0xD90574", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0xD9061C", Offset = "0xD9061C", VA = "0xD9061C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly Action _updateOrientationAction;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action<LocomotionTeleport.AimData> _updateAimDataAction;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected LocomotionTeleport.AimData AimData;

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xD90280", Offset = "0xD90280", VA = "0xD90280")]
	protected TeleportOrientationHandler()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xD90354", Offset = "0xD90354", VA = "0xD90354")]
	private void UpdateAimData(LocomotionTeleport.AimData aimData)
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xD9035C", Offset = "0xD9035C", VA = "0xD9035C", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xD90394", Offset = "0xD90394", VA = "0xD90394", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xD903C8", Offset = "0xD903C8", VA = "0xD903C8")]
	[IteratorStateMachine(typeof(<UpdateOrientationCoroutine>d__7))]
	private IEnumerator UpdateOrientationCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000200")]
	protected abstract void InitializeTeleportDestination();

	[Token(Token = "0x6000201")]
	protected abstract void UpdateTeleportDestination();

	[Token(Token = "0x6000202")]
	[Address(RVA = "0xD90458", Offset = "0xD90458", VA = "0xD90458")]
	protected Quaternion GetLandingOrientation(OrientationModes mode, Quaternion rotation)
	{
		return default(Quaternion);
	}
}
[Token(Token = "0x2000057")]
public class TeleportOrientationHandler360 : TeleportOrientationHandler
{
	[Token(Token = "0x600020A")]
	[Address(RVA = "0xD90664", Offset = "0xD90664", VA = "0xD90664", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0xD90668", Offset = "0xD90668", VA = "0xD90668", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0xD90710", Offset = "0xD90710", VA = "0xD90710")]
	public TeleportOrientationHandler360()
	{
	}
}
[Token(Token = "0x2000058")]
public class TeleportOrientationHandlerHMD : TeleportOrientationHandler
{
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Should the destination orientation be updated during the aim state in addition to the PreTeleport state?")]
	public bool UpdateOrientationDuringAim;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("How far from the destination must the HMD be pointing before using it for orientation")]
	public float AimDistanceThreshold;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Tooltip("How far from the destination must the HMD be pointing before rejecting the teleport")]
	public float AimDistanceMaxRange;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion _initialRotation;

	[Token(Token = "0x600020D")]
	[Address(RVA = "0xD90714", Offset = "0xD90714", VA = "0xD90714", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0xD90764", Offset = "0xD90764", VA = "0xD90764", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x600020F")]
	[Address(RVA = "0xD90C28", Offset = "0xD90C28", VA = "0xD90C28")]
	public TeleportOrientationHandlerHMD()
	{
	}
}
[Token(Token = "0x2000059")]
public class TeleportOrientationHandlerThumbstick : TeleportOrientationHandler
{
	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("HeadRelative=Character will orient to match the arrow. ForwardFacing=When user orients to match the arrow, they will be facing the sensors.")]
	public OrientationModes OrientationMode;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Which thumbstick is to be used for adjusting the teleport orientation. Supports LTouch, RTouch, or Touch for either.")]
	public OVRInput.Controller Thumbstick;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Tooltip("The orientation will only change if the thumbstick magnitude is above this value. This will usually be larger than the TeleportInputHandlerTouch.ThumbstickTeleportThreshold.")]
	public float RotateStickThreshold;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Quaternion _initialRotation;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion _currentRotation;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector2 _lastValidDirection;

	[Token(Token = "0x6000210")]
	[Address(RVA = "0xD90C2C", Offset = "0xD90C2C", VA = "0xD90C2C", Slot = "8")]
	protected override void InitializeTeleportDestination()
	{
	}

	[Token(Token = "0x6000211")]
	[Address(RVA = "0xD90C60", Offset = "0xD90C60", VA = "0xD90C60", Slot = "9")]
	protected override void UpdateTeleportDestination()
	{
	}

	[Token(Token = "0x6000212")]
	[Address(RVA = "0xD9115C", Offset = "0xD9115C", VA = "0xD9115C")]
	public TeleportOrientationHandlerThumbstick()
	{
	}
}
[Token(Token = "0x200005A")]
public class TeleportPoint : MonoBehaviour
{
	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float dimmingSpeed;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fullIntensity;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lowIntensity;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform destTransform;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float lastLookAtTime;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0xD9116C", Offset = "0xD9116C", VA = "0xD9116C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0xD91170", Offset = "0xD91170", VA = "0xD91170")]
	public Transform GetDestTransform()
	{
		return null;
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0xD91178", Offset = "0xD91178", VA = "0xD91178")]
	private void Update()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0xD91264", Offset = "0xD91264", VA = "0xD91264")]
	public void OnLookAt()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0xD91280", Offset = "0xD91280", VA = "0xD91280")]
	public TeleportPoint()
	{
	}
}
[Token(Token = "0x200005B")]
public abstract class TeleportSupport : MonoBehaviour
{
	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _eventsActive;

	[Token(Token = "0x17000052")]
	protected LocomotionTeleport LocomotionTeleport
	{
		[Token(Token = "0x6000218")]
		[Address(RVA = "0xD91298", Offset = "0xD91298", VA = "0xD91298")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000219")]
		[Address(RVA = "0xD912A0", Offset = "0xD912A0", VA = "0xD912A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0xD8E8C8", Offset = "0xD8E8C8", VA = "0xD8E8C8", Slot = "4")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0xD8E9B8", Offset = "0xD8E9B8", VA = "0xD8E9B8", Slot = "5")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0xD912A8", Offset = "0xD912A8", VA = "0xD912A8")]
	[Conditional("DEBUG_TELEPORT_EVENT_HANDLERS")]
	private void LogEventHandler(string msg)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0xD8EFB8", Offset = "0xD8EFB8", VA = "0xD8EFB8", Slot = "6")]
	protected virtual void AddEventHandlers()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0xD8F00C", Offset = "0xD8F00C", VA = "0xD8F00C", Slot = "7")]
	protected virtual void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0xD8E9E0", Offset = "0xD8E9E0", VA = "0xD8E9E0")]
	protected TeleportSupport()
	{
	}
}
[Token(Token = "0x200005C")]
public abstract class TeleportTargetHandler : TeleportSupport
{
	[Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class <TargetAimCoroutine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTargetHandler <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xD91960", Offset = "0xD91960", VA = "0xD91960", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xD919A8", Offset = "0xD919A8", VA = "0xD919A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0xD91524", Offset = "0xD91524", VA = "0xD91524")]
		[DebuggerHidden]
		public <TargetAimCoroutine>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0xD916A0", Offset = "0xD916A0", VA = "0xD916A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xD916A4", Offset = "0xD916A4", VA = "0xD916A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xD91968", Offset = "0xD91968", VA = "0xD91968", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("This bitmask controls which game object layers will be included in the targeting collision tests.")]
	public LayerMask AimCollisionLayerMask;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected readonly LocomotionTeleport.AimData AimData;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly Action _startAimAction;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<Vector3> _aimPoints;

	[Token(Token = "0x4000206")]
	private const float ERROR_MARGIN = 0.1f;

	[Token(Token = "0x6000220")]
	[Address(RVA = "0xD91378", Offset = "0xD91378", VA = "0xD91378")]
	protected TeleportTargetHandler()
	{
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0xD91470", Offset = "0xD91470", VA = "0xD91470", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xD91498", Offset = "0xD91498", VA = "0xD91498", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xD914BC", Offset = "0xD914BC", VA = "0xD914BC")]
	[IteratorStateMachine(typeof(<TargetAimCoroutine>d__7))]
	private IEnumerator TargetAimCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xD9154C", Offset = "0xD9154C", VA = "0xD9154C", Slot = "8")]
	protected virtual void ResetAimData()
	{
	}

	[Token(Token = "0x6000225")]
	protected abstract bool ConsiderTeleport(Vector3 start, ref Vector3 end);

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xD91564", Offset = "0xD91564", VA = "0xD91564", Slot = "10")]
	public virtual Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}
}
[Token(Token = "0x200005E")]
public class TeleportTargetHandlerNavMesh : TeleportTargetHandler
{
	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int NavMeshAreaMask;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NavMeshPath _path;

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xD919B0", Offset = "0xD919B0", VA = "0xD919B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xD91A10", Offset = "0xD91A10", VA = "0xD91A10", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xD91B78", Offset = "0xD91B78", VA = "0xD91B78", Slot = "10")]
	public override Vector3? ConsiderDestination(Vector3 location)
	{
		return null;
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xD91C64", Offset = "0xD91C64", VA = "0xD91C64")]
	[Conditional("SHOW_PATH_RESULT")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xD91C68", Offset = "0xD91C68", VA = "0xD91C68")]
	public TeleportTargetHandlerNavMesh()
	{
	}
}
[Token(Token = "0x200005F")]
public class TeleportTargetHandlerNode : TeleportTargetHandler
{
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Tooltip("When checking line of sight to the destination, add this value to the vertical offset for targeting collision checks.")]
	public float LOSOffset;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Tooltip("Teleport logic will only work with TeleportPoint components that exist in the layers specified by this mask.")]
	public LayerMask TeleportLayerMask;

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xD91C74", Offset = "0xD91C74", VA = "0xD91C74", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xD91E6C", Offset = "0xD91E6C", VA = "0xD91E6C")]
	public TeleportTargetHandlerNode()
	{
	}
}
[Token(Token = "0x2000060")]
public class TeleportTargetHandlerPhysical : TeleportTargetHandler
{
	[Token(Token = "0x6000235")]
	[Address(RVA = "0xD91E78", Offset = "0xD91E78", VA = "0xD91E78", Slot = "9")]
	protected override bool ConsiderTeleport(Vector3 start, ref Vector3 end)
	{
		return default(bool);
	}

	[Token(Token = "0x6000236")]
	[Address(RVA = "0xD91FE0", Offset = "0xD91FE0", VA = "0xD91FE0")]
	public TeleportTargetHandlerPhysical()
	{
	}
}
[Token(Token = "0x2000061")]
public abstract class TeleportTransition : TeleportSupport
{
	[Token(Token = "0x6000237")]
	[Address(RVA = "0xD91FE4", Offset = "0xD91FE4", VA = "0xD91FE4", Slot = "6")]
	protected override void AddEventHandlers()
	{
	}

	[Token(Token = "0x6000238")]
	[Address(RVA = "0xD92068", Offset = "0xD92068", VA = "0xD92068", Slot = "7")]
	protected override void RemoveEventHandlers()
	{
	}

	[Token(Token = "0x6000239")]
	protected abstract void LocomotionTeleportOnEnterStateTeleporting();

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xD920E8", Offset = "0xD920E8", VA = "0xD920E8")]
	protected TeleportTransition()
	{
	}
}
[Token(Token = "0x2000062")]
public class TeleportTransitionBlink : TeleportTransition
{
	[Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class <BlinkCoroutine>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionBlink <>4__this;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <teleportTime>5__3;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <teleported>5__4;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xD92428", Offset = "0xD92428", VA = "0xD92428", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0xD92470", Offset = "0xD92470", VA = "0xD92470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0xD92178", Offset = "0xD92178", VA = "0xD92178")]
		[DebuggerHidden]
		public <BlinkCoroutine>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0xD92330", Offset = "0xD92330", VA = "0xD92330", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0xD92334", Offset = "0xD92334", VA = "0xD92334", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xD92430", Offset = "0xD92430", VA = "0xD92430", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 2f)]
	[Tooltip("How long the transition takes. Usually this is greater than Teleport Delay.")]
	public float TransitionDuration;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Tooltip("At what percentage of the elapsed transition time does the teleport occur?")]
	public float TeleportDelay;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Fade to black over the duration of the transition")]
	public AnimationCurve FadeLevels;

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xD920F0", Offset = "0xD920F0", VA = "0xD920F0", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xD92110", Offset = "0xD92110", VA = "0xD92110")]
	[IteratorStateMachine(typeof(<BlinkCoroutine>d__4))]
	protected IEnumerator BlinkCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xD921A0", Offset = "0xD921A0", VA = "0xD921A0")]
	public TeleportTransitionBlink()
	{
	}
}
[Token(Token = "0x2000064")]
public class TeleportTransitionInstant : TeleportTransition
{
	[Token(Token = "0x6000244")]
	[Address(RVA = "0xD92478", Offset = "0xD92478", VA = "0xD92478", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xD92490", Offset = "0xD92490", VA = "0xD92490")]
	public TeleportTransitionInstant()
	{
	}
}
[Token(Token = "0x2000065")]
public class TeleportTransitionWarp : TeleportTransition
{
	[Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class <DoWarp>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TeleportTransitionWarp <>4__this;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <startPosition>5__2;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <elapsedTime>5__3;

		[Token(Token = "0x17000057")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xD92690", Offset = "0xD92690", VA = "0xD92690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0xD926D8", Offset = "0xD926D8", VA = "0xD926D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xD92520", Offset = "0xD92520", VA = "0xD92520")]
		[DebuggerHidden]
		public <DoWarp>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xD92584", Offset = "0xD92584", VA = "0xD92584", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xD92588", Offset = "0xD92588", VA = "0xD92588", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xD92698", Offset = "0xD92698", VA = "0xD92698", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0.01f, 1f)]
	[Tooltip("How much time the warp transition takes to complete.")]
	public float TransitionDuration;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public AnimationCurve PositionLerp;

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xD92498", Offset = "0xD92498", VA = "0xD92498", Slot = "8")]
	protected override void LocomotionTeleportOnEnterStateTeleporting()
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xD924B8", Offset = "0xD924B8", VA = "0xD924B8")]
	[IteratorStateMachine(typeof(<DoWarp>d__3))]
	private IEnumerator DoWarp()
	{
		return null;
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xD92548", Offset = "0xD92548", VA = "0xD92548")]
	public TeleportTransitionWarp()
	{
	}
}
[Token(Token = "0x2000067")]
public static class NativeVideoPlayer
{
	[Token(Token = "0x2000068")]
	public enum PlabackState
	{
		[Token(Token = "0x4000236")]
		Idle = 1,
		[Token(Token = "0x4000237")]
		Preparing,
		[Token(Token = "0x4000238")]
		Buffering,
		[Token(Token = "0x4000239")]
		Ready,
		[Token(Token = "0x400023A")]
		Ended
	}

	[Token(Token = "0x2000069")]
	public enum StereoMode
	{
		[Token(Token = "0x400023C")]
		Unknown = -1,
		[Token(Token = "0x400023D")]
		Mono,
		[Token(Token = "0x400023E")]
		TopBottom,
		[Token(Token = "0x400023F")]
		LeftRight,
		[Token(Token = "0x4000240")]
		Mesh
	}

	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IntPtr? _Activity;

	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static IntPtr? _VideoPlayerClass;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly jvalue[] EmptyParams;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static IntPtr getIsPlayingMethodId;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static IntPtr getCurrentPlaybackStateMethodId;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static IntPtr getDurationMethodId;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static IntPtr getStereoModeMethodId;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static IntPtr getWidthMethodId;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static IntPtr getHeightMethodId;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static IntPtr getPlaybackPositionMethodId;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static IntPtr setPlaybackPositionMethodId;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static jvalue[] setPlaybackPositionParams;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static IntPtr playVideoMethodId;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static jvalue[] playVideoParams;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static IntPtr stopMethodId;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private static IntPtr resumeMethodId;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private static IntPtr pauseMethodId;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private static IntPtr setPlaybackSpeedMethodId;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private static jvalue[] setPlaybackSpeedParams;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private static IntPtr setLoopingMethodId;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private static jvalue[] setLoopingParams;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private static IntPtr setListenerRotationQuaternionMethodId;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private static jvalue[] setListenerRotationQuaternionParams;

	[Token(Token = "0x17000059")]
	private static IntPtr VideoPlayerClass
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xD926E0", Offset = "0xD926E0", VA = "0xD926E0")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700005A")]
	private static IntPtr Activity
	{
		[Token(Token = "0x6000250")]
		[Address(RVA = "0xD929D0", Offset = "0xD929D0", VA = "0xD929D0")]
		get
		{
			return default(IntPtr);
		}
	}

	[Token(Token = "0x1700005B")]
	public static bool IsAvailable
	{
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xD92C50", Offset = "0xD92C50", VA = "0xD92C50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005C")]
	public static bool IsPlaying
	{
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xD92CC4", Offset = "0xD92CC4", VA = "0xD92CC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005D")]
	public static PlabackState CurrentPlaybackState
	{
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xD92DC8", Offset = "0xD92DC8", VA = "0xD92DC8")]
		get
		{
			return default(PlabackState);
		}
	}

	[Token(Token = "0x1700005E")]
	public static long Duration
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xD92ED0", Offset = "0xD92ED0", VA = "0xD92ED0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700005F")]
	public static StereoMode VideoStereoMode
	{
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xD92FD8", Offset = "0xD92FD8", VA = "0xD92FD8")]
		get
		{
			return default(StereoMode);
		}
	}

	[Token(Token = "0x17000060")]
	public static int VideoWidth
	{
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xD930E0", Offset = "0xD930E0", VA = "0xD930E0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000061")]
	public static int VideoHeight
	{
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xD931E8", Offset = "0xD931E8", VA = "0xD931E8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000062")]
	public static long PlaybackPosition
	{
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xD932F0", Offset = "0xD932F0", VA = "0xD932F0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xD933F8", Offset = "0xD933F8", VA = "0xD933F8")]
		set
		{
		}
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xD93558", Offset = "0xD93558", VA = "0xD93558")]
	public static void PlayVideo(string path, string drmLicenseUrl, IntPtr surfaceObj)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xD93764", Offset = "0xD93764", VA = "0xD93764")]
	public static void Stop()
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xD9386C", Offset = "0xD9386C", VA = "0xD9386C")]
	public static void Play()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xD93974", Offset = "0xD93974", VA = "0xD93974")]
	public static void Pause()
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xD93A7C", Offset = "0xD93A7C", VA = "0xD93A7C")]
	public static void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xD93BE4", Offset = "0xD93BE4", VA = "0xD93BE4")]
	public static void SetLooping(bool looping)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xD93D48", Offset = "0xD93D48", VA = "0xD93D48")]
	public static void SetListenerRotation(Quaternion rotation)
	{
	}
}
[Token(Token = "0x200006A")]
public class ButtonDownListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[Token(Token = "0x1400000F")]
	public event Action onButtonDown
	{
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xD93F8C", Offset = "0xD93F8C", VA = "0xD93F8C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xD94028", Offset = "0xD94028", VA = "0xD94028")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xD940C4", Offset = "0xD940C4", VA = "0xD940C4", Slot = "4")]
	public void OnPointerDown(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xD940E0", Offset = "0xD940E0", VA = "0xD940E0")]
	public ButtonDownListener()
	{
	}
}
[Token(Token = "0x200006B")]
public class MediaPlayerImage : Image
{
	[Token(Token = "0x200006C")]
	public enum ButtonType
	{
		[Token(Token = "0x4000244")]
		Play,
		[Token(Token = "0x4000245")]
		Pause,
		[Token(Token = "0x4000246")]
		FastForward,
		[Token(Token = "0x4000247")]
		Rewind,
		[Token(Token = "0x4000248")]
		SkipForward,
		[Token(Token = "0x4000249")]
		SkipBack,
		[Token(Token = "0x400024A")]
		Stop
	}

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[SerializeField]
	private ButtonType m_ButtonType;

	[Token(Token = "0x17000063")]
	public ButtonType buttonType
	{
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xD940E8", Offset = "0xD940E8", VA = "0xD940E8")]
		get
		{
			return default(ButtonType);
		}
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xD940F0", Offset = "0xD940F0", VA = "0xD940F0")]
		set
		{
		}
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xD94114", Offset = "0xD94114", VA = "0xD94114", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xD94F68", Offset = "0xD94F68", VA = "0xD94F68")]
	public MediaPlayerImage()
	{
	}
}
[Token(Token = "0x200006D")]
public class MoviePlayerSample : MonoBehaviour
{
	[Token(Token = "0x200006E")]
	public enum VideoShape
	{
		[Token(Token = "0x400025F")]
		_360,
		[Token(Token = "0x4000260")]
		_180,
		[Token(Token = "0x4000261")]
		Quad
	}

	[Token(Token = "0x200006F")]
	public enum VideoStereo
	{
		[Token(Token = "0x4000263")]
		Mono,
		[Token(Token = "0x4000264")]
		TopBottom,
		[Token(Token = "0x4000265")]
		LeftRight,
		[Token(Token = "0x4000266")]
		BottomTop
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class <Start>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MoviePlayerSample <>4__this;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000280")]
			[Address(RVA = "0xD96400", Offset = "0xD96400", VA = "0xD96400", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000282")]
			[Address(RVA = "0xD96448", Offset = "0xD96448", VA = "0xD96448", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0xD9560C", Offset = "0xD9560C", VA = "0xD9560C")]
		[DebuggerHidden]
		public <Start>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xD96260", Offset = "0xD96260", VA = "0xD96260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0xD96264", Offset = "0xD96264", VA = "0xD96264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xD96408", Offset = "0xD96408", VA = "0xD96408", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool videoPausedBeforeAppPause;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private VideoPlayer videoPlayer;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVROverlay overlay;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Renderer mediaRenderer;

	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private RenderTexture copyTexture;

	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material externalTex2DMaterial;

	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string MovieName;

	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string DrmLicenseUrl;

	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public bool LoopVideo;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public VideoShape Shape;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VideoStereo Stereo;

	[Token(Token = "0x4000259")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool AutoDetectStereoLayout;

	[Token(Token = "0x400025A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	public bool DisplayMono;

	[Token(Token = "0x400025B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private VideoShape _LastShape;

	[Token(Token = "0x400025C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private VideoStereo _LastStereo;

	[Token(Token = "0x400025D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool _LastDisplayMono;

	[Token(Token = "0x17000064")]
	public bool IsPlaying
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0xD94FC0", Offset = "0xD94FC0", VA = "0xD94FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600026B")]
		[Address(RVA = "0xD94FC8", Offset = "0xD94FC8", VA = "0xD94FC8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000065")]
	public long Duration
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xD94FD4", Offset = "0xD94FD4", VA = "0xD94FD4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xD94FDC", Offset = "0xD94FDC", VA = "0xD94FDC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000066")]
	public long PlaybackPosition
	{
		[Token(Token = "0x600026E")]
		[Address(RVA = "0xD94FE4", Offset = "0xD94FE4", VA = "0xD94FE4")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600026F")]
		[Address(RVA = "0xD94FEC", Offset = "0xD94FEC", VA = "0xD94FEC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xD94FF4", Offset = "0xD94FF4", VA = "0xD94FF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xD95244", Offset = "0xD95244", VA = "0xD95244")]
	private bool IsLocalVideo(string movieName)
	{
		return default(bool);
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xD952A4", Offset = "0xD952A4", VA = "0xD952A4")]
	private void UpdateShapeAndStereo()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xD955A4", Offset = "0xD955A4", VA = "0xD955A4")]
	[IteratorStateMachine(typeof(<Start>d__33))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xD95634", Offset = "0xD95634", VA = "0xD95634")]
	public void Play(string moviePath, string drmLicencesUrl)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xD958D4", Offset = "0xD958D4", VA = "0xD958D4")]
	public void Play()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xD95958", Offset = "0xD95958", VA = "0xD95958")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xD959D8", Offset = "0xD959D8", VA = "0xD959D8")]
	public void SeekTo(long position)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xD95AC4", Offset = "0xD95AC4", VA = "0xD95AC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xD96054", Offset = "0xD96054", VA = "0xD96054")]
	public void SetPlaybackSpeed(float speed)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xD960F0", Offset = "0xD960F0", VA = "0xD960F0")]
	public void Stop()
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0xD96170", Offset = "0xD96170", VA = "0xD96170")]
	private void OnApplicationPause(bool appWasPaused)
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0xD96250", Offset = "0xD96250", VA = "0xD96250")]
	public MoviePlayerSample()
	{
	}
}
[Token(Token = "0x2000072")]
public class MoviePlayerSampleControls : MonoBehaviour
{
	[Token(Token = "0x2000073")]
	private enum PlaybackState
	{
		[Token(Token = "0x4000283")]
		Playing,
		[Token(Token = "0x4000284")]
		Paused,
		[Token(Token = "0x4000285")]
		Rewinding,
		[Token(Token = "0x4000286")]
		FastForwarding
	}

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MoviePlayerSample Player;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRInputModule InputModule;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRGazePointer GazePointer;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject RightHand;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Canvas Canvas;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonDownListener PlayPause;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MediaPlayerImage PlayPauseImage;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Slider ProgressBar;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ButtonDownListener FastForward;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MediaPlayerImage FastForwardImage;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public ButtonDownListener Rewind;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MediaPlayerImage RewindImage;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float TimeoutTime;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool _isVisible;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float _lastButtonTime;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private bool _didSeek;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private long _seekPreviousPosition;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private long _rewindStartPosition;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float _rewindStartTime;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private PlaybackState _state;

	[Token(Token = "0x6000285")]
	[Address(RVA = "0xD96524", Offset = "0xD96524", VA = "0xD96524")]
	private void Start()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0xD96850", Offset = "0xD96850", VA = "0xD96850")]
	private void OnPlayPauseClicked()
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0xD96A20", Offset = "0xD96A20", VA = "0xD96A20")]
	private void OnFastForwardClicked()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xD96B44", Offset = "0xD96B44", VA = "0xD96B44")]
	private void OnRewindClicked()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xD96C40", Offset = "0xD96C40", VA = "0xD96C40")]
	private void OnSeekBarMoved(float value)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xD96B18", Offset = "0xD96B18", VA = "0xD96B18")]
	private void Seek(long pos)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xD96CA0", Offset = "0xD96CA0", VA = "0xD96CA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xD96750", Offset = "0xD96750", VA = "0xD96750")]
	private void SetVisible(bool visible)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xD96FAC", Offset = "0xD96FAC", VA = "0xD96FAC")]
	public MoviePlayerSampleControls()
	{
	}
}
[Token(Token = "0x2000074")]
public static class VectorUtil
{
	[Token(Token = "0x600028E")]
	[Address(RVA = "0xD95FDC", Offset = "0xD95FDC", VA = "0xD95FDC")]
	public static Vector4 ToVector(this Rect rect)
	{
		return default(Vector4);
	}
}
[Token(Token = "0x2000075")]
public class AppDeeplinkUI : MonoBehaviour
{
	[Token(Token = "0x4000287")]
	private const ulong UNITY_COMPANION_APP_ID = 3535750239844224uL;

	[Token(Token = "0x4000288")]
	private const ulong UNREAL_COMPANION_APP_ID = 4055411724486843uL;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform deeplinkAppId;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform deeplinkMessage;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform uiLaunchType;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RectTransform uiLaunchSource;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private RectTransform uiDeepLinkMessage;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool inMenu;

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xD96FBC", Offset = "0xD96FBC", VA = "0xD96FBC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xD975AC", Offset = "0xD975AC", VA = "0xD975AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xD97808", Offset = "0xD97808", VA = "0xD97808")]
	private void LaunchUnrealDeeplinkSample()
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xD9796C", Offset = "0xD9796C", VA = "0xD9796C")]
	private void LaunchSelf()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xD97AD4", Offset = "0xD97AD4", VA = "0xD97AD4")]
	private void LaunchOtherApp()
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xD97C58", Offset = "0xD97C58", VA = "0xD97C58")]
	public AppDeeplinkUI()
	{
	}
}
[Token(Token = "0x2000076")]
public class CustomDebugUI : MonoBehaviour
{
	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private RectTransform textPrefab;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static CustomDebugUI instance;

	[Token(Token = "0x4000291")]
	private const BindingFlags privateFlags = BindingFlags.Instance | BindingFlags.NonPublic;

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xD97C68", Offset = "0xD97C68", VA = "0xD97C68")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xD97CB4", Offset = "0xD97CB4", VA = "0xD97CB4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xD97CB8", Offset = "0xD97CB8", VA = "0xD97CB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xD9736C", Offset = "0xD9736C", VA = "0xD9736C")]
	public RectTransform AddTextField(string label, int targetCanvas = 0)
	{
		return null;
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xD97CBC", Offset = "0xD97CBC", VA = "0xD97CBC")]
	public void RemoveFromCanvas(RectTransform element, int targetCanvas = 0)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xD97ED8", Offset = "0xD97ED8", VA = "0xD97ED8")]
	public CustomDebugUI()
	{
	}
}
[Token(Token = "0x2000077")]
public class DebugUISample : MonoBehaviour
{
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool inMenu;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Text sliderText;

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xD97EE0", Offset = "0xD97EE0", VA = "0xD97EE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xD98418", Offset = "0xD98418", VA = "0xD98418")]
	public void TogglePressed(Toggle t)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xD984C4", Offset = "0xD984C4", VA = "0xD984C4")]
	public void RadioPressed(string radioLabel, string group, Toggle t)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xD986DC", Offset = "0xD986DC", VA = "0xD986DC")]
	public void SliderPressed(float f)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xD987B0", Offset = "0xD987B0", VA = "0xD987B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xD98888", Offset = "0xD98888", VA = "0xD98888")]
	private void LogButtonPressed()
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xD988F0", Offset = "0xD988F0", VA = "0xD988F0")]
	public DebugUISample()
	{
	}
}
[Token(Token = "0x2000078")]
public class AnalyticsUI : MonoBehaviour
{
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xD98A98", Offset = "0xD98A98", VA = "0xD98A98")]
	public AnalyticsUI()
	{
	}
}
[Token(Token = "0x2000079")]
public class SampleUI : MonoBehaviour
{
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private RectTransform collectionButton;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RectTransform inputText;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform valueText;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool inMenu;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xD98AA0", Offset = "0xD98AA0", VA = "0xD98AA0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xD98B38", Offset = "0xD98B38", VA = "0xD98B38")]
	private void Update()
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xD98C10", Offset = "0xD98C10", VA = "0xD98C10")]
	private string GetText()
	{
		return null;
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xD98C6C", Offset = "0xD98C6C", VA = "0xD98C6C")]
	public SampleUI()
	{
	}
}
[Token(Token = "0x200007A")]
public class StartCrashlytics : MonoBehaviour
{
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xD98C74", Offset = "0xD98C74", VA = "0xD98C74")]
	public StartCrashlytics()
	{
	}
}
[Token(Token = "0x200007B")]
public class HandsActiveChecker : MonoBehaviour
{
	[Token(Token = "0x200007C")]
	[CompilerGenerated]
	private sealed class <GetCenterEye>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandsActiveChecker <>4__this;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xD99040", Offset = "0xD99040", VA = "0xD99040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xD99088", Offset = "0xD99088", VA = "0xD99088", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xD98F08", Offset = "0xD98F08", VA = "0xD98F08")]
		[DebuggerHidden]
		public <GetCenterEye>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xD98F38", Offset = "0xD98F38", VA = "0xD98F38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0xD98F3C", Offset = "0xD98F3C", VA = "0xD98F3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0xD99048", Offset = "0xD99048", VA = "0xD99048", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _notificationPrefab;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject _notification;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRCameraRig _cameraRig;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform _centerEye;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xD98C7C", Offset = "0xD98C7C", VA = "0xD98C7C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xD98D70", Offset = "0xD98D70", VA = "0xD98D70")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xD98D08", Offset = "0xD98D08", VA = "0xD98D08")]
	[IteratorStateMachine(typeof(<GetCenterEye>d__6))]
	private IEnumerator GetCenterEye()
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xD98F30", Offset = "0xD98F30", VA = "0xD98F30")]
	public HandsActiveChecker()
	{
	}
}
[Token(Token = "0x200007D")]
[ExecuteInEditMode]
public class CharacterCapsule : MonoBehaviour
{
	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CharacterController _character;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private MeshFilter _meshFilter;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _height;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _radius;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Range(4f, 32f)]
	public int SubdivisionsU;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(4f, 32f)]
	public int SubdivisionsV;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int _subdivisionU;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int _subdivisionV;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3[] _vertices;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int[] _triangles;

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xD99090", Offset = "0xD99090", VA = "0xD99090")]
	private void Update()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xD9A9FC", Offset = "0xD9A9FC", VA = "0xD9A9FC")]
	public CharacterCapsule()
	{
	}
}
[Token(Token = "0x200007E")]
public class LocomotionSampleSupport : MonoBehaviour
{
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private LocomotionController lc;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool inMenu;

	[Token(Token = "0x1700006B")]
	private LocomotionTeleport TeleportController
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xD9AA04", Offset = "0xD9AA04", VA = "0xD9AA04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xD9AA54", Offset = "0xD9AA54", VA = "0xD9AA54")]
	public void Start()
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xD9AE60", Offset = "0xD9AE60", VA = "0xD9AE60")]
	public void Update()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xD9AF38", Offset = "0xD9AF38", VA = "0xD9AF38")]
	[Conditional("DEBUG_LOCOMOTION_PANEL")]
	private static void Log(string msg)
	{
	}

	[Token(Token = "0x60002BC")]
	public static TActivate ActivateCategory<TCategory, TActivate>(GameObject target) where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60002BD")]
	protected void ActivateHandlers<TInput, TAim, TTarget, TOrientation, TTransition>() where TInput : TeleportInputHandler where TAim : TeleportAimHandler where TTarget : TeleportTargetHandler where TOrientation : TeleportOrientationHandler where TTransition : TeleportTransition
	{
	}

	[Token(Token = "0x60002BE")]
	protected void ActivateInput<TActivate>() where TActivate : TeleportInputHandler
	{
	}

	[Token(Token = "0x60002BF")]
	protected void ActivateAim<TActivate>() where TActivate : TeleportAimHandler
	{
	}

	[Token(Token = "0x60002C0")]
	protected void ActivateTarget<TActivate>() where TActivate : TeleportTargetHandler
	{
	}

	[Token(Token = "0x60002C1")]
	protected void ActivateOrientation<TActivate>() where TActivate : TeleportOrientationHandler
	{
	}

	[Token(Token = "0x60002C2")]
	protected void ActivateTransition<TActivate>() where TActivate : TeleportTransition
	{
	}

	[Token(Token = "0x60002C3")]
	protected TActivate ActivateCategory<TCategory, TActivate>() where TCategory : MonoBehaviour where TActivate : MonoBehaviour
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xD9AF90", Offset = "0xD9AF90", VA = "0xD9AF90")]
	protected void UpdateToggle(Toggle toggle, bool enabled)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xD9AFD0", Offset = "0xD9AFD0", VA = "0xD9AFD0")]
	private void SetupNonCap()
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xD9B03C", Offset = "0xD9B03C", VA = "0xD9B03C")]
	private void SetupTeleportDefaults()
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xD9B160", Offset = "0xD9B160", VA = "0xD9B160")]
	protected GameObject AddInstance(GameObject template, string label)
	{
		return null;
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xD9B230", Offset = "0xD9B230", VA = "0xD9B230")]
	private void SetupNodeTeleport()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xD9AD5C", Offset = "0xD9AD5C", VA = "0xD9AD5C")]
	private void SetupTwoStickTeleport()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xD9B2F4", Offset = "0xD9B2F4", VA = "0xD9B2F4")]
	private void SetupWalkOnly()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xD9B340", Offset = "0xD9B340", VA = "0xD9B340")]
	private void SetupLeftStrafeRightTeleport()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xD9B434", Offset = "0xD9B434", VA = "0xD9B434")]
	public LocomotionSampleSupport()
	{
	}
}
[Token(Token = "0x200007F")]
[RequireComponent(typeof(Canvas))]
public class OVROverlayCanvas : MonoBehaviour
{
	[Token(Token = "0x2000080")]
	public enum DrawMode
	{
		[Token(Token = "0x40002C0")]
		Opaque,
		[Token(Token = "0x40002C1")]
		OpaqueWithClip,
		[Token(Token = "0x40002C2")]
		TransparentDefaultAlpha,
		[Token(Token = "0x40002C3")]
		TransparentCorrectAlpha
	}

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Shader _transparentShader;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[SerializeField]
	private Shader _opaqueShader;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RectTransform _rectTransform;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Canvas _canvas;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Camera _camera;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private OVROverlay _overlay;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private RenderTexture _renderTexture;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer _meshRenderer;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Mesh _quad;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Material _defaultMat;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public int MaxTextureSize;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int MinTextureSize;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float PixelsPerUnit;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int DrawRate;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int DrawFrameOffset;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public bool Expensive;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int Layer;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public DrawMode Opacity;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool ScaleViewport;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Plane[] _FrustumPlanes;

	[Token(Token = "0x1700006C")]
	public bool overlayEnabled
	{
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xD9C990", Offset = "0xD9C990", VA = "0xD9C990")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xD9CA14", Offset = "0xD9CA14", VA = "0xD9CA14")]
		set
		{
		}
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xD9B43C", Offset = "0xD9B43C", VA = "0xD9B43C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xD9C018", Offset = "0xD9C018", VA = "0xD9C018")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xD9C08C", Offset = "0xD9C08C", VA = "0xD9C08C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xD9C15C", Offset = "0xD9C15C", VA = "0xD9C15C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xD9C22C", Offset = "0xD9C22C", VA = "0xD9C22C", Slot = "4")]
	protected virtual bool ShouldRender()
	{
		return default(bool);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xD9C430", Offset = "0xD9C430", VA = "0xD9C430")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xD9CAD0", Offset = "0xD9CAD0", VA = "0xD9CAD0")]
	public OVROverlayCanvas()
	{
	}
}
[Token(Token = "0x2000081")]
public class AugmentedObject : MonoBehaviour
{
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform shadow;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool groundShadow;

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xD9CB80", Offset = "0xD9CB80", VA = "0xD9CB80")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xD9CECC", Offset = "0xD9CECC", VA = "0xD9CECC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xD9D060", Offset = "0xD9D060", VA = "0xD9D060")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xD9D068", Offset = "0xD9D068", VA = "0xD9D068")]
	public void Release()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xD9D050", Offset = "0xD9D050", VA = "0xD9D050")]
	private void ToggleShadowType()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xD9D070", Offset = "0xD9D070", VA = "0xD9D070")]
	public AugmentedObject()
	{
	}
}
[Token(Token = "0x2000082")]
public class BrushController : MonoBehaviour
{
	[Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class <FadeCameraClearColor>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fadeTime;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color newColor;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <timer>5__2;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E7")]
			[Address(RVA = "0xD9D724", Offset = "0xD9D724", VA = "0xD9D724", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xD9D76C", Offset = "0xD9D76C", VA = "0xD9D76C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xD9D5E0", Offset = "0xD9D5E0", VA = "0xD9D5E0")]
		[DebuggerHidden]
		public <FadeCameraClearColor>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xD9D638", Offset = "0xD9D638", VA = "0xD9D638", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xD9D63C", Offset = "0xD9D63C", VA = "0xD9D63C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xD9D72C", Offset = "0xD9D72C", VA = "0xD9D72C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class <FadeSphere>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrushController <>4__this;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool disableOnFinish;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0xD9D8E4", Offset = "0xD9D8E4", VA = "0xD9D8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xD9D92C", Offset = "0xD9D92C", VA = "0xD9D92C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xD9D608", Offset = "0xD9D608", VA = "0xD9D608")]
		[DebuggerHidden]
		public <FadeSphere>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xD9D774", Offset = "0xD9D774", VA = "0xD9D774", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xD9D778", Offset = "0xD9D778", VA = "0xD9D778", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xD9D8EC", Offset = "0xD9D8EC", VA = "0xD9D8EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PassthroughBrush brush;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer backgroundSphere;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator grabRoutine;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator releaseRoutine;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xD9D078", Offset = "0xD9D078", VA = "0xD9D078")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xD9D318", Offset = "0xD9D318", VA = "0xD9D318")]
	private void Update()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xD9D368", Offset = "0xD9D368", VA = "0xD9D368")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xD9D4BC", Offset = "0xD9D4BC", VA = "0xD9D4BC")]
	public void Release()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xD9D548", Offset = "0xD9D548", VA = "0xD9D548")]
	[IteratorStateMachine(typeof(<FadeCameraClearColor>d__8))]
	private IEnumerator FadeCameraClearColor(Color newColor, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xD9D408", Offset = "0xD9D408", VA = "0xD9D408")]
	[IteratorStateMachine(typeof(<FadeSphere>d__9))]
	private IEnumerator FadeSphere(Color newColor, float fadeTime, bool disableOnFinish = false)
	{
		return null;
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xD9D630", Offset = "0xD9D630", VA = "0xD9D630")]
	public BrushController()
	{
	}
}
[Token(Token = "0x2000085")]
public class EnableUnpremultipliedAlpha : MonoBehaviour
{
	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xD9D934", Offset = "0xD9D934", VA = "0xD9D934")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xD9D988", Offset = "0xD9D988", VA = "0xD9D988")]
	public EnableUnpremultipliedAlpha()
	{
	}
}
[Token(Token = "0x2000086")]
public class Flashlight : MonoBehaviour
{
	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject lightVolume;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Light spotlight;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bulbGlow;

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xD9D990", Offset = "0xD9D990", VA = "0xD9D990")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xD9DB64", Offset = "0xD9DB64", VA = "0xD9DB64")]
	public void ToggleFlashlight()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xD9DBF4", Offset = "0xD9DBF4", VA = "0xD9DBF4")]
	public void EnableFlashlight(bool doEnable)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xD9DC50", Offset = "0xD9DC50", VA = "0xD9DC50")]
	public Flashlight()
	{
	}
}
[Token(Token = "0x2000087")]
public class FlashlightController : MonoBehaviour
{
	[Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class <FadeLighting>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlashlightController <>4__this;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color newColor;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float sceneLightIntensity;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <timer>5__2;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Color <currentColor>5__3;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <currentLight>5__4;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0xD9ED94", Offset = "0xD9ED94", VA = "0xD9ED94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0xD9EDDC", Offset = "0xD9EDDC", VA = "0xD9EDDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xD9EB08", Offset = "0xD9EB08", VA = "0xD9EB08")]
		[DebuggerHidden]
		public <FadeLighting>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xD9EBD0", Offset = "0xD9EBD0", VA = "0xD9EBD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xD9EBD4", Offset = "0xD9EBD4", VA = "0xD9EBD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xD9ED9C", Offset = "0xD9ED9C", VA = "0xD9ED9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Light sceneLight;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform flashlightRoot;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 localPosition;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Quaternion localRotation;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMesh infoText;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GrabObject externalController;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private OVRSkeleton[] skeletons;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private OVRHand[] hands;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int handIndex;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool pinching;

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xD9DC58", Offset = "0xD9DC58", VA = "0xD9DC58")]
	private void Start()
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xD9DEF4", Offset = "0xD9DEF4", VA = "0xD9DEF4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xD9E1E0", Offset = "0xD9E1E0", VA = "0xD9E1E0")]
	private void FindHands()
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xD9E4D8", Offset = "0xD9E4D8", VA = "0xD9E4D8")]
	private void AlignWithHand(OVRHand hand, OVRSkeleton skeleton)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xD9E7B0", Offset = "0xD9E7B0", VA = "0xD9E7B0")]
	private void AlignWithController(OVRInput.Controller controller)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xD9E898", Offset = "0xD9E898", VA = "0xD9E898")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xD9EA24", Offset = "0xD9EA24", VA = "0xD9EA24")]
	public void Release()
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xD9E980", Offset = "0xD9E980", VA = "0xD9E980")]
	[IteratorStateMachine(typeof(<FadeLighting>d__17))]
	private IEnumerator FadeLighting(Color newColor, float sceneLightIntensity, float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xD9EB30", Offset = "0xD9EB30", VA = "0xD9EB30")]
	public FlashlightController()
	{
	}
}
[Token(Token = "0x2000089")]
public class GrabObject : MonoBehaviour
{
	[Token(Token = "0x200008A")]
	public enum ManipulationType
	{
		[Token(Token = "0x40002F8")]
		Default,
		[Token(Token = "0x40002F9")]
		ForcedHand,
		[Token(Token = "0x40002FA")]
		DollyHand,
		[Token(Token = "0x40002FB")]
		DollyAttached,
		[Token(Token = "0x40002FC")]
		HorizontalScaled,
		[Token(Token = "0x40002FD")]
		VerticalScaled,
		[Token(Token = "0x40002FE")]
		Menu
	}

	[Token(Token = "0x200008B")]
	public delegate void GrabbedObject(OVRInput.Controller grabHand);

	[Token(Token = "0x200008C")]
	public delegate void ReleasedObject();

	[Token(Token = "0x200008D")]
	public delegate void SetCursorPosition(Vector3 cursorPosition);

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[TextArea]
	public string ObjectName;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[TextArea]
	public string ObjectInstructions;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ManipulationType objectManipulationType;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool showLaserWhileGrabbed;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion grabbedRotation;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GrabbedObject GrabbedObjectDelegate;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ReleasedObject ReleasedObjectDelegate;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SetCursorPosition CursorPositionDelegate;

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xD9EDE4", Offset = "0xD9EDE4", VA = "0xD9EDE4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xD9EE44", Offset = "0xD9EE44", VA = "0xD9EE44")]
	public void Release()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xD9EE60", Offset = "0xD9EE60", VA = "0xD9EE60")]
	public void CursorPos(Vector3 cursorPos)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xD9EE7C", Offset = "0xD9EE7C", VA = "0xD9EE7C")]
	public GrabObject()
	{
	}
}
[Token(Token = "0x200008E")]
public class HandMeshMask : MonoBehaviour
{
	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRSkeleton referenceHand;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material maskMaterial;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("The segments around the tip of a finger")]
	public int radialDivisions;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Tooltip("The fade range (finger width is 2x this)")]
	public float borderSize;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Along the fingers, each knuckle scales down by this amount.  Default is zero for uniform width along entire finger.")]
	public float fingerTaper;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Tooltip("Shorten the last bone of each finger; need this to account for bone structure (end bone is at finger tip instead of center). Default is 1.")]
	public float fingerTipLength;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("Move the base of the 4 main fingers towards the tips, to avoid a visible mesh crack between finger webbing. Default is 0.")]
	public float webOffset;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float handScale;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject maskMeshObject;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Mesh maskMesh;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3[] handVertices;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector2[] handUVs;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color32[] handColors;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int[] handTriangles;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int vertCounter;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int triCounter;

	[Token(Token = "0x6000315")]
	[Address(RVA = "0xD9F124", Offset = "0xD9F124", VA = "0xD9F124")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xD9F358", Offset = "0xD9F358", VA = "0xD9F358")]
	private void Update()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xD9F520", Offset = "0xD9F520", VA = "0xD9F520")]
	private void CreateHandMesh()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xD9FB28", Offset = "0xD9FB28", VA = "0xD9FB28")]
	private void AddKnuckleMesh(int knuckleVerts, float point1scale, float point2scale, Vector3 point1, Vector3 point2)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xDA00C0", Offset = "0xDA00C0", VA = "0xDA00C0")]
	private void AddPalmMesh(int knuckleVerts)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xDA23C8", Offset = "0xDA23C8", VA = "0xDA23C8")]
	private void AddVertex(Vector3 position, Vector2 uv, Color color)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xDA273C", Offset = "0xDA273C", VA = "0xDA273C")]
	public HandMeshMask()
	{
	}
}
[Token(Token = "0x200008F")]
public class HandMeshUI : MonoBehaviour
{
	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider[] knobs;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMesh[] readouts;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rightHeldKnob;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private int leftHeldKnob;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public OVRSkeleton leftHand;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public OVRSkeleton rightHand;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public HandMeshMask leftMask;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public HandMeshMask rightMask;

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xDA2760", Offset = "0xDA2760", VA = "0xDA2760")]
	private void Start()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xDA2AC8", Offset = "0xDA2AC8", VA = "0xDA2AC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xDA27FC", Offset = "0xDA27FC", VA = "0xDA27FC")]
	private void SetSliderValue(int sliderID, float value, bool isNormalized)
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xDA2F30", Offset = "0xDA2F30", VA = "0xDA2F30")]
	private void CheckForHands()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xDA34A0", Offset = "0xDA34A0", VA = "0xDA34A0")]
	public HandMeshUI()
	{
	}
}
[Token(Token = "0x2000090")]
public class ObjectManipulator : MonoBehaviour
{
	[Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class <StartDemo>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ObjectManipulator <>4__this;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <timer>5__2;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <fadeTime>5__3;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0xDA5C8C", Offset = "0xDA5C8C", VA = "0xDA5C8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000332")]
			[Address(RVA = "0xDA5CD4", Offset = "0xDA5CD4", VA = "0xDA5CD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xDA55D8", Offset = "0xDA55D8", VA = "0xDA55D8")]
		[DebuggerHidden]
		public <StartDemo>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xDA59C0", Offset = "0xDA59C0", VA = "0xDA59C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xDA59C4", Offset = "0xDA59C4", VA = "0xDA59C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xDA5C94", Offset = "0xDA5C94", VA = "0xDA5C94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRInput.Controller controller;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject hoverObject;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject grabObject;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float grabTime;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 localGrabOffset;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion localGrabRotation;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 camGrabPosition;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion camGrabRotation;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 handGrabPosition;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Quaternion handGrabRotation;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float rotationOffset;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LineRenderer laser;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform objectInfo;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMesh objectNameLabel;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMesh objectInstructionsLabel;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Image objectInfoBG;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject demoObjects;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public OVRPassthroughLayer passthrough;

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xDA34B0", Offset = "0xDA34B0", VA = "0xDA34B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xDA36A0", Offset = "0xDA36A0", VA = "0xDA36A0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xDA454C", Offset = "0xDA454C", VA = "0xDA454C")]
	private void GrabHoverObject(GameObject grbObj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xDA52E0", Offset = "0xDA52E0", VA = "0xDA52E0")]
	private void ReleaseObject()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xDA3638", Offset = "0xDA3638", VA = "0xDA3638")]
	[IteratorStateMachine(typeof(<StartDemo>d__23))]
	private IEnumerator StartDemo()
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xDA38E8", Offset = "0xDA38E8", VA = "0xDA38E8")]
	private void FindHoverObject(Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xDA4840", Offset = "0xDA4840", VA = "0xDA4840")]
	private void ManipulateObject(GameObject obj, Vector3 controllerPos, Quaternion controllerRot)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xDA5600", Offset = "0xDA5600", VA = "0xDA5600")]
	private void ClampGrabOffset(ref Vector3 localOffset, float thumbY)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xDA56B4", Offset = "0xDA56B4", VA = "0xDA56B4")]
	private Vector3 ClampScale(Vector3 localScale, Vector2 thumb)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xDA56E4", Offset = "0xDA56E4", VA = "0xDA56E4")]
	private void CheckForDominantHand()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xDA54BC", Offset = "0xDA54BC", VA = "0xDA54BC")]
	private void AssignInstructions(GrabObject targetObject)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xDA57D4", Offset = "0xDA57D4", VA = "0xDA57D4")]
	public ObjectManipulator()
	{
	}
}
[Token(Token = "0x2000092")]
public class OverlayPassthrough : MonoBehaviour
{
	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xDA5CDC", Offset = "0xDA5CDC", VA = "0xDA5CDC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xDA5E3C", Offset = "0xDA5E3C", VA = "0xDA5E3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0xDA5EF0", Offset = "0xDA5EF0", VA = "0xDA5EF0")]
	public OverlayPassthrough()
	{
	}
}
[Token(Token = "0x2000093")]
public class PassthroughBrush : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	public enum BrushState
	{
		[Token(Token = "0x400033B")]
		Idle,
		[Token(Token = "0x400033C")]
		Inking
	}

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject lineSegmentPrefab;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject lineContainer;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool forceActive;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private LineRenderer currentLineSegment;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<Vector3> inkPositions;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float minInkDist;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private float strokeWidth;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float strokeLength;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private BrushState brushStatus;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xDA5EF8", Offset = "0xDA5EF8", VA = "0xDA5EF8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xDA5F00", Offset = "0xDA5F00", VA = "0xDA5F00")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0xDA61B0", Offset = "0xDA61B0", VA = "0xDA61B0")]
	private void StartLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xDA63D0", Offset = "0xDA63D0", VA = "0xDA63D0")]
	private void UpdateLine(Vector3 inkPos)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xDA6610", Offset = "0xDA6610", VA = "0xDA6610")]
	public void ClearLines()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xDA60C8", Offset = "0xDA60C8", VA = "0xDA60C8")]
	public void UndoInkLine()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xDA66E0", Offset = "0xDA66E0", VA = "0xDA66E0")]
	public PassthroughBrush()
	{
	}
}
[Token(Token = "0x2000095")]
public class PassthroughController : MonoBehaviour
{
	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xDA6770", Offset = "0xDA6770", VA = "0xDA6770")]
	private void Start()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xDA68D0", Offset = "0xDA68D0", VA = "0xDA68D0")]
	private void Update()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xDA6AB8", Offset = "0xDA6AB8", VA = "0xDA6AB8")]
	public PassthroughController()
	{
	}
}
[Token(Token = "0x2000096")]
public class PassthroughProjectionSurface : MonoBehaviour
{
	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer quadOutline;

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xDA6AC0", Offset = "0xDA6AC0", VA = "0xDA6AC0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xDA6C88", Offset = "0xDA6C88", VA = "0xDA6C88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xDA6E28", Offset = "0xDA6E28", VA = "0xDA6E28")]
	public PassthroughProjectionSurface()
	{
	}
}
[Token(Token = "0x2000097")]
public class PassthroughStyler : MonoBehaviour
{
	[Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class <FadeToCurrentStyle>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0xDA7A34", Offset = "0xDA7A34", VA = "0xDA7A34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0xDA7A7C", Offset = "0xDA7A7C", VA = "0xDA7A7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xDA7768", Offset = "0xDA7768", VA = "0xDA7768")]
		[DebuggerHidden]
		public <FadeToCurrentStyle>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xDA78CC", Offset = "0xDA78CC", VA = "0xDA78CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xDA78D0", Offset = "0xDA78D0", VA = "0xDA78D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xDA7A3C", Offset = "0xDA7A3C", VA = "0xDA7A3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class <FadeToDefaultPassthrough>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PassthroughStyler <>4__this;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeTime;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <timer>5__2;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <brightness>5__3;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <contrast>5__4;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <posterize>5__5;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Color <edgeCol>5__6;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0xDA7C00", Offset = "0xDA7C00", VA = "0xDA7C00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0xDA7C48", Offset = "0xDA7C48", VA = "0xDA7C48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xDA7790", Offset = "0xDA7790", VA = "0xDA7790")]
		[DebuggerHidden]
		public <FadeToDefaultPassthrough>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xDA7A84", Offset = "0xDA7A84", VA = "0xDA7A84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xDA7A88", Offset = "0xDA7A88", VA = "0xDA7A88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xDA7C08", Offset = "0xDA7C08", VA = "0xDA7C08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRInput.Controller controllerHand;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private IEnumerator fadeIn;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private IEnumerator fadeOut;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RectTransform[] menuOptions;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RectTransform colorWheel;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D colorTexture;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 cursorPosition;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool settingColor;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Color savedColor;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float savedBrightness;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float savedContrast;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float savedPosterize;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public CanvasGroup mainCanvas;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject[] compactObjects;

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xDA6E30", Offset = "0xDA6E30", VA = "0xDA6E30")]
	private void Start()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xDA7124", Offset = "0xDA7124", VA = "0xDA7124")]
	private void Update()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xDA74C4", Offset = "0xDA74C4", VA = "0xDA74C4")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xDA761C", Offset = "0xDA761C", VA = "0xDA761C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xDA75A4", Offset = "0xDA75A4", VA = "0xDA75A4")]
	[IteratorStateMachine(typeof(<FadeToCurrentStyle>d__19))]
	private IEnumerator FadeToCurrentStyle(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xDA76F0", Offset = "0xDA76F0", VA = "0xDA76F0")]
	[IteratorStateMachine(typeof(<FadeToDefaultPassthrough>d__20))]
	private IEnumerator FadeToDefaultPassthrough(float fadeTime)
	{
		return null;
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xDA77B8", Offset = "0xDA77B8", VA = "0xDA77B8")]
	public void OnBrightnessChanged(float newValue)
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xDA77D8", Offset = "0xDA77D8", VA = "0xDA77D8")]
	public void OnContrastChanged(float newValue)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xDA77F8", Offset = "0xDA77F8", VA = "0xDA77F8")]
	public void OnPosterizeChanged(float newValue)
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xDA7818", Offset = "0xDA7818", VA = "0xDA7818")]
	public void OnAlphaChanged(float newValue)
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xDA70BC", Offset = "0xDA70BC", VA = "0xDA70BC")]
	private void ShowFullMenu(bool doShow)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xDA784C", Offset = "0xDA784C", VA = "0xDA784C")]
	public void Cursor(Vector3 cP)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xDA7858", Offset = "0xDA7858", VA = "0xDA7858")]
	public void DoColorDrag(bool doDrag)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xDA713C", Offset = "0xDA713C", VA = "0xDA713C")]
	public void GetColorFromWheel()
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xDA7864", Offset = "0xDA7864", VA = "0xDA7864")]
	public PassthroughStyler()
	{
	}
}
[Token(Token = "0x200009A")]
public class PassthroughSurface : MonoBehaviour
{
	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xDA7C50", Offset = "0xDA7C50", VA = "0xDA7C50")]
	private void Start()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xDA7D04", Offset = "0xDA7D04", VA = "0xDA7D04")]
	public PassthroughSurface()
	{
	}
}
[Token(Token = "0x200009B")]
public class SceneSampler : MonoBehaviour
{
	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int currentSceneIndex;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject displayText;

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xDA7D0C", Offset = "0xDA7D0C", VA = "0xDA7D0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xDA7D78", Offset = "0xDA7D78", VA = "0xDA7D78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xDA806C", Offset = "0xDA806C", VA = "0xDA806C")]
	public SceneSampler()
	{
	}
}
[Token(Token = "0x200009C")]
public class SelectivePassthroughExperience : MonoBehaviour
{
	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject leftMaskObject;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject rightMaskObject;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xDA8074", Offset = "0xDA8074", VA = "0xDA8074")]
	private void Update()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xDA84C8", Offset = "0xDA84C8", VA = "0xDA84C8")]
	public SelectivePassthroughExperience()
	{
	}
}
[Token(Token = "0x200009D")]
public class SPPquad : MonoBehaviour
{
	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private OVRPassthroughLayer passthroughLayer;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter projectionObject;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private OVRInput.Controller controllerHand;

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xDA84D0", Offset = "0xDA84D0", VA = "0xDA84D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xDA86F0", Offset = "0xDA86F0", VA = "0xDA86F0")]
	public void Grab(OVRInput.Controller grabHand)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xDA873C", Offset = "0xDA873C", VA = "0xDA873C")]
	public void Release()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xDA877C", Offset = "0xDA877C", VA = "0xDA877C")]
	public SPPquad()
	{
	}
}
[Token(Token = "0x200009E")]
public class Anchor : MonoBehaviour
{
	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ulong anchorHandle_;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Canvas canvas_;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform pivot_;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject anchorMenu_;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isSelected_;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool isHovered_;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private TextMeshProUGUI anchorName_;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject saveIcon_;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Image labelImage_;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Color labelBaseColor_;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Color labelHighlightColor_;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Color labelSelectedColor_;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private AnchorUIManager uiManager_;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private MeshRenderer[] renderers_;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int menuIndex_;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Button selectedButton_;

	[Token(Token = "0x17000079")]
	public ulong anchorHandle
	{
		[Token(Token = "0x6000369")]
		[Address(RVA = "0xDA8784", Offset = "0xDA8784", VA = "0xDA8784")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xDA878C", Offset = "0xDA878C", VA = "0xDA878C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xDA8854", Offset = "0xDA8854", VA = "0xDA8854")]
	private void Update()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xDA8AB4", Offset = "0xDA8AB4", VA = "0xDA8AB4")]
	public void OnSaveLocalButtonPressed()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xDA8B18", Offset = "0xDA8B18", VA = "0xDA8B18")]
	public void OnHideButtonPressed()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xDA8B78", Offset = "0xDA8B78", VA = "0xDA8B78")]
	public void OnEraseButtonPressed()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xDA8BD8", Offset = "0xDA8BD8", VA = "0xDA8BD8")]
	public void OnHoverStart()
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xDA8CF4", Offset = "0xDA8CF4", VA = "0xDA8CF4")]
	public void OnHoverEnd()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0xDA8DFC", Offset = "0xDA8DFC", VA = "0xDA8DFC")]
	public void OnSelect()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0xDA8F00", Offset = "0xDA8F00", VA = "0xDA8F00")]
	public void SetAnchorHandle(ulong handle)
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0xDA8F90", Offset = "0xDA8F90", VA = "0xDA8F90")]
	public void ShowSaveIcon()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0xDA888C", Offset = "0xDA888C", VA = "0xDA888C")]
	private void BillboardPanel(Transform panel)
	{
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xDA89C0", Offset = "0xDA89C0", VA = "0xDA89C0")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xDA8FB0", Offset = "0xDA8FB0", VA = "0xDA8FB0")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xDA909C", Offset = "0xDA909C", VA = "0xDA909C")]
	public Anchor()
	{
	}
}
[Token(Token = "0x200009F")]
public class AnchorHelpers
{
	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Camera camera;

	[Token(Token = "0x1700007A")]
	private static Camera MainCamera
	{
		[Token(Token = "0x6000378")]
		[Address(RVA = "0xDA90A4", Offset = "0xDA90A4", VA = "0xDA90A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xDA9144", Offset = "0xDA9144", VA = "0xDA9144")]
	public static OVRPlugin.Posef UnityWorldSpacePoseToTrackingSpacePose(Transform pose)
	{
		return default(OVRPlugin.Posef);
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xDA91BC", Offset = "0xDA91BC", VA = "0xDA91BC")]
	public static OVRPose TrackingSpacePoseToUnityWorldSpacePose(OVRPlugin.Posef pose)
	{
		return default(OVRPose);
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xDA9224", Offset = "0xDA9224", VA = "0xDA9224")]
	public static OVRPose getTransformUnityWorldFromDevice()
	{
		return default(OVRPose);
	}

	[Token(Token = "0x600037C")]
	public static T ByteArrayToStruct<T>(byte[] bytes) where T : struct
	{
		return (T)null;
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xDA9270", Offset = "0xDA9270", VA = "0xDA9270")]
	public static string UuidToString(byte[] encodedMessage)
	{
		return null;
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xDA94F0", Offset = "0xDA94F0", VA = "0xDA94F0")]
	public static byte[] StringToUuid(string str)
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xDA9654", Offset = "0xDA9654", VA = "0xDA9654")]
	private static int GetHexVal(char hex)
	{
		return default(int);
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xDA970C", Offset = "0xDA970C", VA = "0xDA970C")]
	public AnchorHelpers()
	{
	}
}
[Token(Token = "0x20000A0")]
public abstract class AnchorSession : MonoBehaviour
{
	[Token(Token = "0x20000A1")]
	public enum StorageLocation
	{
		[Token(Token = "0x4000384")]
		LOCAL
	}

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSession Instance;

	[Token(Token = "0x400037E")]
	public const ulong kInvalidHandle = ulong.MaxValue;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Dictionary<ulong, Anchor> handleToAnchor;

	[Token(Token = "0x4000380")]
	protected const int maxEvents = 5;

	[Token(Token = "0x4000381")]
	protected const float eventPollingRate = 0.1f;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject anchorPrefab_;

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xDA9714", Offset = "0xDA9714", VA = "0xDA9714", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xDA9464", Offset = "0xDA9464", VA = "0xDA9464")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xDA97FC", Offset = "0xDA97FC", VA = "0xDA97FC")]
	protected static bool isFlagSet(uint bitset, uint flag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000384")]
	public abstract ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor);

	[Token(Token = "0x6000385")]
	public abstract void DestroyAnchor(ulong anchorHandle);

	[Token(Token = "0x6000386")]
	public abstract void SaveAnchor(ulong anchorHandle, StorageLocation location);

	[Token(Token = "0x6000387")]
	public abstract void EraseAnchor(ulong anchorHandle);

	[Token(Token = "0x6000388")]
	public abstract void QueryAllLocalAnchors();

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xDA9808", Offset = "0xDA9808", VA = "0xDA9808")]
	protected AnchorSession()
	{
	}
}
[Token(Token = "0x20000A2")]
public class AnchorSpawner : MonoBehaviour
{
	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorSpawner Instance;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject anchorPrefab_;

	[Token(Token = "0x1700007B")]
	public GameObject AnchorPrefab
	{
		[Token(Token = "0x600038A")]
		[Address(RVA = "0xDA9884", Offset = "0xDA9884", VA = "0xDA9884")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xDA988C", Offset = "0xDA988C", VA = "0xDA988C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xDA9970", Offset = "0xDA9970", VA = "0xDA9970")]
	public void PlaceAnchorAtTransform(Transform transform)
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xDA9B98", Offset = "0xDA9B98", VA = "0xDA9B98")]
	public AnchorSpawner()
	{
	}
}
[Token(Token = "0x20000A3")]
public class AnchorUIManager : MonoBehaviour
{
	[Token(Token = "0x20000A4")]
	public enum AnchorMode
	{
		[Token(Token = "0x400039A")]
		Create,
		[Token(Token = "0x400039B")]
		Select
	}

	[Token(Token = "0x20000A5")]
	private delegate void PrimaryPressDelegate();

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static AnchorUIManager Instance;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject mainMenu_;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject createModeButton_;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject selectModeButton_;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform trackedDevice_;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform raycastOrigin_;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool drawRaycast_;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private LineRenderer lineRenderer_;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Anchor hoveredAnchor_;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Anchor selectedAnchor_;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AnchorMode mode_;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Button> buttonList_;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int menuIndex_;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Button selectedButton_;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject placementPreview_;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Transform anchorPlacementTransform_;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private PrimaryPressDelegate primaryPressDelegate_;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool isFocused_;

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xDA9BA0", Offset = "0xDA9BA0", VA = "0xDA9BA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xDA9C60", Offset = "0xDA9C60", VA = "0xDA9C60")]
	private void Start()
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xDA9D80", Offset = "0xDA9D80", VA = "0xDA9D80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xDAA1F4", Offset = "0xDAA1F4", VA = "0xDAA1F4")]
	public void OnCreateModeButtonPressed()
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xDAA260", Offset = "0xDAA260", VA = "0xDAA260")]
	public void OnLoadAnchorsButtonPressed()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xDA9D30", Offset = "0xDA9D30", VA = "0xDA9D30")]
	private void ToggleCreateMode()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xDAA2D0", Offset = "0xDAA2D0", VA = "0xDAA2D0")]
	private void StartPlacementMode()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xDAA350", Offset = "0xDAA350", VA = "0xDAA350")]
	private void EndPlacementMode()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xDAA368", Offset = "0xDAA368", VA = "0xDAA368")]
	private void StartSelectMode()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xDAA2B8", Offset = "0xDAA2B8", VA = "0xDAA2B8")]
	private void EndSelectMode()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xDAA100", Offset = "0xDAA100", VA = "0xDAA100")]
	private void HandleMenuNavigation()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xDAA550", Offset = "0xDAA550", VA = "0xDAA550")]
	private void NavigateToIndexInMenu(bool moveNext)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xDAA3E8", Offset = "0xDAA3E8", VA = "0xDAA3E8")]
	private void ShowAnchorPreview()
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xDAA4C4", Offset = "0xDAA4C4", VA = "0xDAA4C4")]
	private void HideAnchorPreview()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xDAA63C", Offset = "0xDAA63C", VA = "0xDAA63C")]
	private void PlaceAnchor()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xDAA4E4", Offset = "0xDAA4E4", VA = "0xDAA4E4")]
	private void ShowRaycastLine()
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xDAA51C", Offset = "0xDAA51C", VA = "0xDAA51C")]
	private void HideRaycastLine()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xDA9E80", Offset = "0xDA9E80", VA = "0xDA9E80")]
	private void ControllerRaycast()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xDAA694", Offset = "0xDAA694", VA = "0xDAA694")]
	private void HoverAnchor(Anchor anchor)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xDAA6B0", Offset = "0xDAA6B0", VA = "0xDAA6B0")]
	private void UnhoverAnchor()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xDAA72C", Offset = "0xDAA72C", VA = "0xDAA72C")]
	private void SelectAnchor()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xDAA844", Offset = "0xDAA844", VA = "0xDAA844")]
	public AnchorUIManager()
	{
	}
}
[Token(Token = "0x20000A6")]
public class SpatialAnchorSession : AnchorSession
{
	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<ulong, ulong> locateAnchorRequest;

	[Token(Token = "0x400039D")]
	private const string numUuids = "numUuids";

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0xDAA894", Offset = "0xDAA894", VA = "0xDAA894")]
	private void Start()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0xDAAA90", Offset = "0xDAAA90", VA = "0xDAAA90")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0xDAAC8C", Offset = "0xDAAC8C", VA = "0xDAAC8C")]
	private void SpatialEntitySetComponentEnabled(ulong requestId, bool result, OVRPlugin.SpatialEntityComponentType componentType, ulong space)
	{
	}

	[Token(Token = "0x60003AB")]
	[Address(RVA = "0xDAAE84", Offset = "0xDAAE84", VA = "0xDAAE84")]
	private void SpatialAnchorSaved(ulong requestId, ulong space, bool result, OVRPlugin.SpatialEntityUuid uuid)
	{
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0xDAB2E0", Offset = "0xDAB2E0", VA = "0xDAB2E0")]
	private void SpatialEntityStorageErase(ulong requestId, bool result, OVRPlugin.SpatialEntityUuid uuid, OVRPlugin.SpatialEntityStorageLocation location)
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0xDAB580", Offset = "0xDAB580", VA = "0xDAB580")]
	private void SpatialEntityQueryResults(ulong requestId, int numResults, OVRPlugin.SpatialEntityQueryResult[] results)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0xDABB94", Offset = "0xDABB94", VA = "0xDABB94")]
	private void SpatialEntityQueryComplete(ulong requestId, bool result, int numFound)
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0xDAB214", Offset = "0xDAB214", VA = "0xDAB214")]
	private string GetUuidString(OVRPlugin.SpatialEntityUuid uuid)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0xDAB80C", Offset = "0xDAB80C", VA = "0xDAB80C")]
	private void tryEnableComponent(ulong anchorHandle, OVRPlugin.SpatialEntityComponentType type)
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0xDAAD78", Offset = "0xDAAD78", VA = "0xDAAD78")]
	private void CreateAnchorGameobject(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xDABD84", Offset = "0xDABD84", VA = "0xDABD84")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xDAC044", Offset = "0xDAC044", VA = "0xDAC044", Slot = "5")]
	public override ulong CreateSpatialAnchor(Transform T_UnityWorld_Anchor)
	{
		return default(ulong);
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xDAC1D4", Offset = "0xDAC1D4", VA = "0xDAC1D4", Slot = "6")]
	public override void DestroyAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xDAC374", Offset = "0xDAC374", VA = "0xDAC374", Slot = "8")]
	public override void EraseAnchor(ulong anchorHandle)
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xDAC524", Offset = "0xDAC524", VA = "0xDAC524")]
	public void QueryAnchorByUuid()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xDAC784", Offset = "0xDAC784", VA = "0xDAC784", Slot = "9")]
	public override void QueryAllLocalAnchors()
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xDAC888", Offset = "0xDAC888", VA = "0xDAC888", Slot = "7")]
	public override void SaveAnchor(ulong anchorHandle, StorageLocation location)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xDAC9CC", Offset = "0xDAC9CC", VA = "0xDAC9CC")]
	public SpatialAnchorSession()
	{
	}
}
[Token(Token = "0x20000A7")]
public class StartMenu : MonoBehaviour
{
	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public OVROverlay overlay;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public OVROverlay text;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public OVRCameraRig vrRig;

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xDACA44", Offset = "0xDACA44", VA = "0xDACA44")]
	private void Start()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0xDACC48", Offset = "0xDACC48", VA = "0xDACC48")]
	private void LoadScene(int idx)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0xDACD4C", Offset = "0xDACD4C", VA = "0xDACD4C")]
	public StartMenu()
	{
	}
}
[Token(Token = "0x20000A9")]
public class CheckVoicePermisions : MonoBehaviour
{
	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject voice;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameStarter gameStarter;

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0xDACD70", Offset = "0xDACD70", VA = "0xDACD70")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xDACE08", Offset = "0xDACE08", VA = "0xDACE08")]
	public CheckVoicePermisions()
	{
	}
}
[Token(Token = "0x20000AA")]
public class DeviceInfo : MonoBehaviour
{
	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TMP_Dropdown infoDropdown;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI firstColumnInfo;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI logText;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private XRController rightHand;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private XRController leftHand;

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xDACE10", Offset = "0xDACE10", VA = "0xDACE10")]
	private void Update()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xDADDD8", Offset = "0xDADDD8", VA = "0xDADDD8")]
	private void MovePanel()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xDACE28", Offset = "0xDACE28", VA = "0xDACE28")]
	private void GetStatus()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xDADFC8", Offset = "0xDADFC8", VA = "0xDADFC8")]
	public DeviceInfo()
	{
	}
}
namespace Shaders.Tests
{
	[Token(Token = "0x20000AC")]
	public class UpdatePosition : MonoBehaviour
	{
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material material2;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0.1f, 1f)]
		private float radius;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0.1f, 20f)]
		private float hardness;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Position;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _ColorMulti;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _Color;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _Hardness;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _Radtest;

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xDAE054", Offset = "0xDAE054", VA = "0xDAE054")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xDAE174", Offset = "0xDAE174", VA = "0xDAE174")]
		public UpdatePosition()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x20000AD")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x20000AE")]
		private class CameraState
		{
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x40003BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x40003C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x40003C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x40003C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0xDAE2F8", Offset = "0xDAE2F8", VA = "0xDAE2F8")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0xDAE870", Offset = "0xDAE870", VA = "0xDAE870")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0xDAE8F0", Offset = "0xDAE8F0", VA = "0xDAE8F0")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xDAE978", Offset = "0xDAE978", VA = "0xDAE978")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0xDAEB6C", Offset = "0xDAEB6C", VA = "0xDAEB6C")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		public float positionLerpTime;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		[Header("Rotation Settings")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0.001f, 1f)]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		public float rotationLerpTime;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xDAE2A4", Offset = "0xDAE2A4", VA = "0xDAE2A4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xDAE37C", Offset = "0xDAE37C", VA = "0xDAE37C")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xDAE5AC", Offset = "0xDAE5AC", VA = "0xDAE5AC")]
		private void Update()
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xDAE9C0", Offset = "0xDAE9C0", VA = "0xDAE9C0")]
		public SimpleCameraController()
		{
		}
	}
}
namespace OculusSampleFramework
{
	[Token(Token = "0x20000AF")]
	public class ColorGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Color COLOR_GRAB;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Color COLOR_HIGHLIGHT;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Color m_color;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MeshRenderer[] m_meshRenderers;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_highlight;

		[Token(Token = "0x1700007C")]
		public bool Highlight
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xDAEB74", Offset = "0xDAEB74", VA = "0xDAEB74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0xDAEB7C", Offset = "0xDAEB7C", VA = "0xDAEB7C")]
			set
			{
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xDAEB88", Offset = "0xDAEB88", VA = "0xDAEB88")]
		protected void UpdateColor()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xDAED28", Offset = "0xDAED28", VA = "0xDAED28", Slot = "4")]
		public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xDAED44", Offset = "0xDAED44", VA = "0xDAED44", Slot = "5")]
		public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xDAED60", Offset = "0xDAED60", VA = "0xDAED60")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xDAEC34", Offset = "0xDAEC34", VA = "0xDAEC34")]
		private void SetColor(Color color)
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xDAEFC4", Offset = "0xDAEFC4", VA = "0xDAEFC4")]
		public ColorGrabbable()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class DistanceGrabbable : OVRGrabbable
	{
		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string m_materialColorField;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabbableCrosshair m_crosshair;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabManager m_crosshairManager;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Renderer m_renderer;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MaterialPropertyBlock m_mpb;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_inRange;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool m_targeted;

		[Token(Token = "0x1700007D")]
		public bool InRange
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0xDAF03C", Offset = "0xDAF03C", VA = "0xDAF03C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xDAF044", Offset = "0xDAF044", VA = "0xDAF044")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public bool Targeted
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0xDAF1B4", Offset = "0xDAF1B4", VA = "0xDAF1B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xDAF1BC", Offset = "0xDAF1BC", VA = "0xDAF1BC")]
			set
			{
			}
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xDAF1C8", Offset = "0xDAF1C8", VA = "0xDAF1C8", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xDAF050", Offset = "0xDAF050", VA = "0xDAF050")]
		private void RefreshCrosshair()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xDAF2F8", Offset = "0xDAF2F8", VA = "0xDAF2F8")]
		public DistanceGrabbable()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[RequireComponent(typeof(Rigidbody))]
	public class DistanceGrabber : OVRGrabber
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_spherecastRadius;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_noSnapThreshhold;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_useSpherecast;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		public bool m_preventGrabThroughWalls;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private float m_objectPullVelocity;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private float m_objectPullMaxRotationRate;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool m_movingObjectToHand;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private float m_maxGrabDistance;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private int m_grabObjectsInLayer;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private int m_obstructionLayer;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private DistanceGrabber m_otherHand;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		protected DistanceGrabbable m_target;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		protected Collider m_targetCollider;

		[Token(Token = "0x1700007F")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xDAF300", Offset = "0xDAF300", VA = "0xDAF300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0xDAF308", Offset = "0xDAF308", VA = "0xDAF308")]
			set
			{
			}
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xDAF324", Offset = "0xDAF324", VA = "0xDAF324", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xDAF528", Offset = "0xDAF528", VA = "0xDAF528", Slot = "6")]
		public override void Update()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xDAFDBC", Offset = "0xDAFDBC", VA = "0xDAFDBC", Slot = "7")]
		protected override void GrabBegin()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xDB0310", Offset = "0xDB0310", VA = "0xDB0310", Slot = "8")]
		protected override void MoveGrabbedObject(Vector3 pos, Quaternion rot, bool forceTeleport = false)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xDB0720", Offset = "0xDB0720", VA = "0xDB0720")]
		private static DistanceGrabbable HitInfoToGrabbable(RaycastHit hitInfo)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xDAF730", Offset = "0xDAF730", VA = "0xDAF730")]
		protected bool FindTarget(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xDB080C", Offset = "0xDB080C", VA = "0xDB080C")]
		protected bool FindTargetWithSpherecast(out DistanceGrabbable dgOut, out Collider collOut)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xDB0BAC", Offset = "0xDB0BAC", VA = "0xDB0BAC", Slot = "9")]
		protected override void GrabVolumeEnable(bool enabled)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xDB0BC4", Offset = "0xDB0BC4", VA = "0xDB0BC4", Slot = "10")]
		protected override void OffhandGrabbed(OVRGrabbable grabbable)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xDB0BCC", Offset = "0xDB0BCC", VA = "0xDB0BCC")]
		public DistanceGrabber()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GrabbableCrosshair : MonoBehaviour
	{
		[Token(Token = "0x20000B3")]
		public enum CrosshairState
		{
			[Token(Token = "0x40003E1")]
			Disabled,
			[Token(Token = "0x40003E2")]
			Enabled,
			[Token(Token = "0x40003E3")]
			Targeted
		}

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CrosshairState m_state;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_centerEyeAnchor;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject m_targetedCrosshair;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject m_enabledCrosshair;

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xDB0BEC", Offset = "0xDB0BEC", VA = "0xDB0BEC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xDB0C4C", Offset = "0xDB0C4C", VA = "0xDB0C4C")]
		public void SetState(CrosshairState cs)
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xDB0CD8", Offset = "0xDB0CD8", VA = "0xDB0CD8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xDB0D10", Offset = "0xDB0D10", VA = "0xDB0D10")]
		public GrabbableCrosshair()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class GrabManager : MonoBehaviour
	{
		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Collider m_grabVolume;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color OutlineColorInRange;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color OutlineColorHighlighted;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Color OutlineColorOutOfRange;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xDB0D18", Offset = "0xDB0D18", VA = "0xDB0D18")]
		private void OnTriggerEnter(Collider otherCollider)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xDB0DC4", Offset = "0xDB0DC4", VA = "0xDB0DC4")]
		private void OnTriggerExit(Collider otherCollider)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xDB0E70", Offset = "0xDB0E70", VA = "0xDB0E70")]
		public GrabManager()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class PauseOnInputLoss : MonoBehaviour
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xDB0E78", Offset = "0xDB0E78", VA = "0xDB0E78")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xDB0F64", Offset = "0xDB0F64", VA = "0xDB0F64")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xDB0F70", Offset = "0xDB0F70", VA = "0xDB0F70")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xDB0F7C", Offset = "0xDB0F7C", VA = "0xDB0F7C")]
		public PauseOnInputLoss()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class BoneCapsuleTriggerLogic : MonoBehaviour
	{
		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableToolTags ToolTags;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HashSet<ColliderZone> CollidersTouchingUs;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<ColliderZone> _elementsToCleanUp;

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xDB0F84", Offset = "0xDB0F84", VA = "0xDB0F84")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xDB0FD4", Offset = "0xDB0FD4", VA = "0xDB0FD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xDB139C", Offset = "0xDB139C", VA = "0xDB139C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xDB1488", Offset = "0xDB1488", VA = "0xDB1488")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xDB0FD8", Offset = "0xDB0FD8", VA = "0xDB0FD8")]
		private void CleanUpDeadColliders()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xDB1574", Offset = "0xDB1574", VA = "0xDB1574")]
		public BoneCapsuleTriggerLogic()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class ButtonController : Interactable
	{
		[Token(Token = "0x20000B8")]
		public enum ContactTest
		{
			[Token(Token = "0x40003FA")]
			PerpenTest,
			[Token(Token = "0x40003FB")]
			BackwardsPress
		}

		[Token(Token = "0x40003EB")]
		private const float ENTRY_DOT_THRESHOLD = 0.8f;

		[Token(Token = "0x40003EC")]
		private const float PERP_DOT_THRESHOLD = 0.5f;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _proximityZone;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _contactZone;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _actionZone;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ContactTest[] _contactTests;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _buttonPlaneCenter;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _makeSureToolIsOnPositiveSide;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector3 _localButtonDirection;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InteractableToolTags[] _allValidToolsTags;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int _toolTagsMask;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private bool _allowMultipleNearFieldInteraction;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<InteractableTool, InteractableState> _toolToState;

		[Token(Token = "0x17000080")]
		public override int ValidToolTagsMask
		{
			[Token(Token = "0x6000401")]
			[Address(RVA = "0xDB1634", Offset = "0xDB1634", VA = "0xDB1634", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000081")]
		public Vector3 LocalButtonDirection
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xDB163C", Offset = "0xDB163C", VA = "0xDB163C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000082")]
		public InteractableState CurrentButtonState
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0xDB1648", Offset = "0xDB1648", VA = "0xDB1648")]
			[CompilerGenerated]
			get
			{
				return default(InteractableState);
			}
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xDB1650", Offset = "0xDB1650", VA = "0xDB1650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xDB1658", Offset = "0xDB1658", VA = "0xDB1658", Slot = "9")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xDB1788", Offset = "0xDB1788", VA = "0xDB1788")]
		private void FireInteractionEventsOnDepth(InteractableCollisionDepth oldDepth, InteractableTool collidingTool, InteractionType interactionType)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xDB1978", Offset = "0xDB1978", VA = "0xDB1978", Slot = "8")]
		public override void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xDB1F3C", Offset = "0xDB1F3C", VA = "0xDB1F3C")]
		private InteractableState GetUpcomingStateNearField(InteractableState oldState, InteractableCollisionDepth newCollisionDepth, bool toolIsInActionZone, bool toolIsInContactZone, bool toolIsInProximity, bool validContact, bool onPositiveSideOfInteractable)
		{
			return default(InteractableState);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xDB2080", Offset = "0xDB2080", VA = "0xDB2080")]
		public void ForceResetButton()
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xDB1E60", Offset = "0xDB1E60", VA = "0xDB1E60")]
		private bool IsValidContact(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xDB218C", Offset = "0xDB218C", VA = "0xDB218C")]
		private bool PassEntryTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xDB2298", Offset = "0xDB2298", VA = "0xDB2298")]
		private bool PassPerpTest(InteractableTool collidingTool, Vector3 buttonDirection)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xDB2320", Offset = "0xDB2320", VA = "0xDB2320")]
		public ButtonController()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class ButtonTriggerZone : MonoBehaviour, ColliderZone
	{
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _parentInteractableObj;

		[Token(Token = "0x17000083")]
		public Collider Collider
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0xDB242C", Offset = "0xDB242C", VA = "0xDB242C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xDB2434", Offset = "0xDB2434", VA = "0xDB2434")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public Interactable ParentInteractable
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0xDB243C", Offset = "0xDB243C", VA = "0xDB243C", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xDB2444", Offset = "0xDB2444", VA = "0xDB2444")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000412")]
			[Address(RVA = "0xDB244C", Offset = "0xDB244C", VA = "0xDB244C", Slot = "6")]
			get
			{
				return default(InteractableCollisionDepth);
			}
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xDB249C", Offset = "0xDB249C", VA = "0xDB249C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xDB251C", Offset = "0xDB251C", VA = "0xDB251C")]
		public ButtonTriggerZone()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public interface ColliderZone
	{
		[Token(Token = "0x17000086")]
		Collider Collider
		{
			[Token(Token = "0x6000415")]
			get;
		}

		[Token(Token = "0x17000087")]
		Interactable ParentInteractable
		{
			[Token(Token = "0x6000416")]
			get;
		}

		[Token(Token = "0x17000088")]
		InteractableCollisionDepth CollisionDepth
		{
			[Token(Token = "0x6000417")]
			get;
		}
	}
	[Token(Token = "0x20000BB")]
	public class ColliderZoneArgs : EventArgs
	{
		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly ColliderZone Collider;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly float FrameTime;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableTool CollidingTool;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly InteractionType InteractionT;

		[Token(Token = "0x6000418")]
		[Address(RVA = "0xDB18E4", Offset = "0xDB18E4", VA = "0xDB18E4")]
		public ColliderZoneArgs(ColliderZone collider, float frameTime, InteractableTool collidingTool, InteractionType interactionType)
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public enum InteractionType
	{
		[Token(Token = "0x4000404")]
		Enter,
		[Token(Token = "0x4000405")]
		Stay,
		[Token(Token = "0x4000406")]
		Exit
	}
	[Token(Token = "0x20000BD")]
	public class HandsManager : MonoBehaviour
	{
		[Token(Token = "0x20000BE")]
		public enum HandsVisualMode
		{
			[Token(Token = "0x4000418")]
			Mesh,
			[Token(Token = "0x4000419")]
			Skeleton,
			[Token(Token = "0x400041A")]
			Both
		}

		[Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <FindSkeletonVisualGameObjects>d__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandsManager <>4__this;

			[Token(Token = "0x17000094")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600043A")]
				[Address(RVA = "0xDB3878", Offset = "0xDB3878", VA = "0xDB3878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000095")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600043C")]
				[Address(RVA = "0xDB38C0", Offset = "0xDB38C0", VA = "0xDB38C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0xDB2EE4", Offset = "0xDB2EE4", VA = "0xDB2EE4")]
			[DebuggerHidden]
			public <FindSkeletonVisualGameObjects>d__52(int <>1__state)
			{
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0xDB368C", Offset = "0xDB368C", VA = "0xDB368C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000439")]
			[Address(RVA = "0xDB3690", Offset = "0xDB3690", VA = "0xDB3690", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0xDB3880", Offset = "0xDB3880", VA = "0xDB3880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000407")]
		private const string SKELETON_VISUALIZER_NAME = "SkeletonRenderer";

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _leftHand;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightHand;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HandsVisualMode VisualMode;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private OVRHand[] _hand;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private OVRSkeleton[] _handSkeleton;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRSkeletonRenderer[] _handSkeletonRenderer;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private OVRMesh[] _handMesh;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private OVRMeshRenderer[] _handMeshRenderer;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SkinnedMeshRenderer _leftMeshRenderer;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SkinnedMeshRenderer _rightMeshRenderer;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject _leftSkeletonVisual;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GameObject _rightSkeletonVisual;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float _currentHandAlpha;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int HandAlphaId;

		[Token(Token = "0x17000089")]
		public OVRHand RightHand
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0xDB2524", Offset = "0xDB2524", VA = "0xDB2524")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0xDB2550", Offset = "0xDB2550", VA = "0xDB2550")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public OVRSkeleton RightHandSkeleton
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0xDB25AC", Offset = "0xDB25AC", VA = "0xDB25AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0xDB25D8", Offset = "0xDB25D8", VA = "0xDB25D8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008B")]
		public OVRSkeletonRenderer RightHandSkeletonRenderer
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0xDB2634", Offset = "0xDB2634", VA = "0xDB2634")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0xDB2660", Offset = "0xDB2660", VA = "0xDB2660")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008C")]
		public OVRMesh RightHandMesh
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xDB26BC", Offset = "0xDB26BC", VA = "0xDB26BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0xDB26E8", Offset = "0xDB26E8", VA = "0xDB26E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008D")]
		public OVRMeshRenderer RightHandMeshRenderer
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xDB2744", Offset = "0xDB2744", VA = "0xDB2744")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000422")]
			[Address(RVA = "0xDB2770", Offset = "0xDB2770", VA = "0xDB2770")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public OVRHand LeftHand
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0xDB27CC", Offset = "0xDB27CC", VA = "0xDB27CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xDB27F4", Offset = "0xDB27F4", VA = "0xDB27F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public OVRSkeleton LeftHandSkeleton
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xDB284C", Offset = "0xDB284C", VA = "0xDB284C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xDB2874", Offset = "0xDB2874", VA = "0xDB2874")]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public OVRSkeletonRenderer LeftHandSkeletonRenderer
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xDB28CC", Offset = "0xDB28CC", VA = "0xDB28CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000428")]
			[Address(RVA = "0xDB28F4", Offset = "0xDB28F4", VA = "0xDB28F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public OVRMesh LeftHandMesh
		{
			[Token(Token = "0x6000429")]
			[Address(RVA = "0xDB294C", Offset = "0xDB294C", VA = "0xDB294C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042A")]
			[Address(RVA = "0xDB2974", Offset = "0xDB2974", VA = "0xDB2974")]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public OVRMeshRenderer LeftHandMeshRenderer
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xDB29CC", Offset = "0xDB29CC", VA = "0xDB29CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600042C")]
			[Address(RVA = "0xDB29F4", Offset = "0xDB29F4", VA = "0xDB29F4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public static HandsManager Instance
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xDB2A4C", Offset = "0xDB2A4C", VA = "0xDB2A4C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600042E")]
			[Address(RVA = "0xDB2A94", Offset = "0xDB2A94", VA = "0xDB2A94")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xDB2AE0", Offset = "0xDB2AE0", VA = "0xDB2AE0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xDB2E68", Offset = "0xDB2E68", VA = "0xDB2E68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xDB2E00", Offset = "0xDB2E00", VA = "0xDB2E00")]
		[IteratorStateMachine(typeof(<FindSkeletonVisualGameObjects>d__52))]
		private IEnumerator FindSkeletonVisualGameObjects()
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xDB2F0C", Offset = "0xDB2F0C", VA = "0xDB2F0C")]
		public void SwitchVisualization()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xDB2FD0", Offset = "0xDB2FD0", VA = "0xDB2FD0")]
		private void SetToCurrentVisualMode()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xDB31A0", Offset = "0xDB31A0", VA = "0xDB31A0")]
		public static List<OVRBoneCapsule> GetCapsulesPerBone(OVRSkeleton skeleton, OVRSkeleton.BoneId boneId)
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xDB3400", Offset = "0xDB3400", VA = "0xDB3400")]
		public bool IsInitialized()
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xDB3560", Offset = "0xDB3560", VA = "0xDB3560")]
		public HandsManager()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	public abstract class Interactable : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C1")]
		public class InteractableStateArgsEvent : UnityEvent<InteractableStateArgs>
		{
			[Token(Token = "0x600044E")]
			[Address(RVA = "0xDB3F10", Offset = "0xDB3F10", VA = "0xDB3F10")]
			public InteractableStateArgsEvent()
			{
			}
		}

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected ColliderZone _proximityZoneCollider;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected ColliderZone _contactZoneCollider;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected ColliderZone _actionZoneCollider;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractableStateArgsEvent InteractableStateChanged;

		[Token(Token = "0x17000096")]
		public ColliderZone ProximityCollider
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xDB38C8", Offset = "0xDB38C8", VA = "0xDB38C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000097")]
		public ColliderZone ContactCollider
		{
			[Token(Token = "0x600043E")]
			[Address(RVA = "0xDB38D0", Offset = "0xDB38D0", VA = "0xDB38D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		public ColliderZone ActionCollider
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xDB38D8", Offset = "0xDB38D8", VA = "0xDB38D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000099")]
		public virtual int ValidToolTagsMask
		{
			[Token(Token = "0x6000440")]
			[Address(RVA = "0xDB38E0", Offset = "0xDB38E0", VA = "0xDB38E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x14000010")]
		public event Action<ColliderZoneArgs> ProximityZoneEvent
		{
			[Token(Token = "0x6000441")]
			[Address(RVA = "0xDB38E8", Offset = "0xDB38E8", VA = "0xDB38E8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000442")]
			[Address(RVA = "0xDB3998", Offset = "0xDB3998", VA = "0xDB3998")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event Action<ColliderZoneArgs> ContactZoneEvent
		{
			[Token(Token = "0x6000444")]
			[Address(RVA = "0xDB3A64", Offset = "0xDB3A64", VA = "0xDB3A64")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xDB3B14", Offset = "0xDB3B14", VA = "0xDB3B14")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event Action<ColliderZoneArgs> ActionZoneEvent
		{
			[Token(Token = "0x6000447")]
			[Address(RVA = "0xDB3BE0", Offset = "0xDB3BE0", VA = "0xDB3BE0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000448")]
			[Address(RVA = "0xDB3C90", Offset = "0xDB3C90", VA = "0xDB3C90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0xDB3A48", Offset = "0xDB3A48", VA = "0xDB3A48", Slot = "5")]
		protected virtual void OnProximityZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xDB3BC4", Offset = "0xDB3BC4", VA = "0xDB3BC4", Slot = "6")]
		protected virtual void OnContactZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0xDB3D40", Offset = "0xDB3D40", VA = "0xDB3D40", Slot = "7")]
		protected virtual void OnActionZoneEvent(ColliderZoneArgs args)
		{
		}

		[Token(Token = "0x600044A")]
		public abstract void UpdateCollisionDepth(InteractableTool interactableTool, InteractableCollisionDepth oldCollisionDepth, InteractableCollisionDepth newCollisionDepth);

		[Token(Token = "0x600044B")]
		[Address(RVA = "0xDB1734", Offset = "0xDB1734", VA = "0xDB1734", Slot = "9")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xDB3E0C", Offset = "0xDB3E0C", VA = "0xDB3E0C", Slot = "10")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xDB2424", Offset = "0xDB2424", VA = "0xDB2424")]
		protected Interactable()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public enum InteractableCollisionDepth
	{
		[Token(Token = "0x4000426")]
		None,
		[Token(Token = "0x4000427")]
		Proximity,
		[Token(Token = "0x4000428")]
		Contact,
		[Token(Token = "0x4000429")]
		Action
	}
	[Token(Token = "0x20000C3")]
	public enum InteractableState
	{
		[Token(Token = "0x400042B")]
		Default,
		[Token(Token = "0x400042C")]
		ProximityState,
		[Token(Token = "0x400042D")]
		ContactState,
		[Token(Token = "0x400042E")]
		ActionState
	}
	[Token(Token = "0x20000C4")]
	public class InteractableStateArgs : EventArgs
	{
		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Interactable Interactable;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly InteractableTool Tool;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly InteractableState OldInteractableState;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public readonly InteractableState NewInteractableState;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ColliderZoneArgs ColliderArgs;

		[Token(Token = "0x600044F")]
		[Address(RVA = "0xDB1FEC", Offset = "0xDB1FEC", VA = "0xDB1FEC")]
		public InteractableStateArgs(Interactable interactable, InteractableTool tool, InteractableState newInteractableState, InteractableState oldState, ColliderZoneArgs colliderArgs)
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class InteractableRegistry : MonoBehaviour
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static HashSet<Interactable> _interactables;

		[Token(Token = "0x1700009A")]
		public static HashSet<Interactable> Interactables
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0xDB3F58", Offset = "0xDB3F58", VA = "0xDB3F58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0xDB3D5C", Offset = "0xDB3D5C", VA = "0xDB3D5C")]
		public static void RegisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xDB3E60", Offset = "0xDB3E60", VA = "0xDB3E60")]
		public static void UnregisterInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xDB3FB0", Offset = "0xDB3FB0", VA = "0xDB3FB0")]
		public InteractableRegistry()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class InteractableToolsCreator : MonoBehaviour
	{
		[Token(Token = "0x20000C7")]
		[CompilerGenerated]
		private sealed class <AttachToolsToHands>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform[] toolObjects;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool isRightHand;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public InteractableToolsCreator <>4__this;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private HandsManager <handsManagerObj>5__2;

			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private HashSet<Transform>.Enumerator <>7__wrap2;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Transform <toolObject>5__4;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private OVRSkeleton <handSkeletonToAttachTo>5__5;

			[Token(Token = "0x1700009B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600045D")]
				[Address(RVA = "0xDB46C4", Offset = "0xDB46C4", VA = "0xDB46C4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700009C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600045F")]
				[Address(RVA = "0xDB470C", Offset = "0xDB470C", VA = "0xDB470C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000459")]
			[Address(RVA = "0xDB4134", Offset = "0xDB4134", VA = "0xDB4134")]
			[DebuggerHidden]
			public <AttachToolsToHands>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600045A")]
			[Address(RVA = "0xDB4270", Offset = "0xDB4270", VA = "0xDB4270", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0xDB428C", Offset = "0xDB428C", VA = "0xDB428C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600045C")]
			[Address(RVA = "0xDB4674", Offset = "0xDB4674", VA = "0xDB4674")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600045E")]
			[Address(RVA = "0xDB46CC", Offset = "0xDB46CC", VA = "0xDB46CC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform[] LeftHandTools;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] RightHandTools;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0xDB4044", Offset = "0xDB4044", VA = "0xDB4044")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xDB40B0", Offset = "0xDB40B0", VA = "0xDB40B0")]
		[IteratorStateMachine(typeof(<AttachToolsToHands>d__3))]
		private IEnumerator AttachToolsToHands(Transform[] toolObjects, bool isRightHand)
		{
			return null;
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0xDB415C", Offset = "0xDB415C", VA = "0xDB415C")]
		private void AttachToolToHandTransform(Transform tool, bool isRightHanded)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xDB4268", Offset = "0xDB4268", VA = "0xDB4268")]
		public InteractableToolsCreator()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class InteractableToolsInputRouter : MonoBehaviour
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InteractableToolsInputRouter _instance;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool _leftPinch;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool _rightPinch;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HashSet<InteractableTool> _leftHandNearTools;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HashSet<InteractableTool> _leftHandFarTools;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<InteractableTool> _rightHandNearTools;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<InteractableTool> _rightHandFarTools;

		[Token(Token = "0x1700009D")]
		public static InteractableToolsInputRouter Instance
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0xDB4714", Offset = "0xDB4714", VA = "0xDB4714")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0xDB4860", Offset = "0xDB4860", VA = "0xDB4860")]
		public void RegisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xDB48FC", Offset = "0xDB48FC", VA = "0xDB48FC")]
		public void UnregisterInteractableTool(InteractableTool interactableTool)
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0xDB4998", Offset = "0xDB4998", VA = "0xDB4998")]
		private void Update()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xDB4C34", Offset = "0xDB4C34", VA = "0xDB4C34")]
		private bool UpdateToolsAndEnableState(HashSet<InteractableTool> tools, bool toolsAreEnabledThisFrame)
		{
			return default(bool);
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xDB4C70", Offset = "0xDB4C70", VA = "0xDB4C70")]
		private bool UpdateTools(HashSet<InteractableTool> tools, bool resetCollisionData = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xDB4F2C", Offset = "0xDB4F2C", VA = "0xDB4F2C")]
		private void ToggleToolsEnableState(HashSet<InteractableTool> tools, bool enableState)
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0xDB5134", Offset = "0xDB5134", VA = "0xDB5134")]
		public InteractableToolsInputRouter()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class FingerTipPokeTool : InteractableTool
	{
		[Token(Token = "0x20000CA")]
		[CompilerGenerated]
		private sealed class <AttachTriggerLogic>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FingerTipPokeTool <>4__this;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000479")]
				[Address(RVA = "0xDB6220", Offset = "0xDB6220", VA = "0xDB6220", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600047B")]
				[Address(RVA = "0xDB6268", Offset = "0xDB6268", VA = "0xDB6268", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000476")]
			[Address(RVA = "0xDB5378", Offset = "0xDB5378", VA = "0xDB5378")]
			[DebuggerHidden]
			public <AttachTriggerLogic>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000477")]
			[Address(RVA = "0xDB5DBC", Offset = "0xDB5DBC", VA = "0xDB5DBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000478")]
			[Address(RVA = "0xDB5DC0", Offset = "0xDB5DC0", VA = "0xDB5DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600047A")]
			[Address(RVA = "0xDB6228", Offset = "0xDB6228", VA = "0xDB6228", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000447")]
		private const int NUM_VELOCITY_FRAMES = 10;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private FingerTipPokeToolView _fingerTipPokeToolView;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private OVRPlugin.HandFinger _fingerToFollow;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] _velocityFrames;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int _currVelocityFrame;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private bool _sampledMaxFramesAlready;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 _position;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BoneCapsuleTriggerLogic[] _boneCapsuleTriggerLogic;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _lastScale;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool _isInitialized;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private OVRBoneCapsule _capsuleToTrack;

		[Token(Token = "0x1700009E")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x6000468")]
			[Address(RVA = "0xDB520C", Offset = "0xDB520C", VA = "0xDB520C", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x1700009F")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xDB5214", Offset = "0xDB5214", VA = "0xDB5214", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000A0")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0xDB521C", Offset = "0xDB521C", VA = "0xDB521C", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A1")]
		public override bool EnableState
		{
			[Token(Token = "0x600046B")]
			[Address(RVA = "0xDB5224", Offset = "0xDB5224", VA = "0xDB5224", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046C")]
			[Address(RVA = "0xDB524C", Offset = "0xDB524C", VA = "0xDB524C", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0xDB527C", Offset = "0xDB527C", VA = "0xDB527C", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xDB5310", Offset = "0xDB5310", VA = "0xDB5310")]
		[IteratorStateMachine(typeof(<AttachTriggerLogic>d__21))]
		private IEnumerator AttachTriggerLogic()
		{
			return null;
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0xDB53A0", Offset = "0xDB53A0", VA = "0xDB53A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0xDB5620", Offset = "0xDB5620", VA = "0xDB5620")]
		private void UpdateAverageVelocity()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0xDB57DC", Offset = "0xDB57DC", VA = "0xDB57DC")]
		private void CheckAndUpdateScale()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0xDB58C4", Offset = "0xDB58C4", VA = "0xDB58C4", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0xDB5C40", Offset = "0xDB5C40", VA = "0xDB5C40", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0xDB5C44", Offset = "0xDB5C44", VA = "0xDB5C44", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0xDB5C48", Offset = "0xDB5C48", VA = "0xDB5C48")]
		public FingerTipPokeTool()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class FingerTipPokeToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _sphereMeshRenderer;

		[Token(Token = "0x170000A4")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0xDB6270", Offset = "0xDB6270", VA = "0xDB6270", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0xDB6278", Offset = "0xDB6278", VA = "0xDB6278")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public bool EnableState
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0xDB6280", Offset = "0xDB6280", VA = "0xDB6280", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0xDB629C", Offset = "0xDB629C", VA = "0xDB629C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000A6")]
		public bool ToolActivateState
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0xDB62BC", Offset = "0xDB62BC", VA = "0xDB62BC", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0xDB62C4", Offset = "0xDB62C4", VA = "0xDB62C4", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000A7")]
		public float SphereRadius
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0xDB62D0", Offset = "0xDB62D0", VA = "0xDB62D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0xDB62D8", Offset = "0xDB62D8", VA = "0xDB62D8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0xDB62E0", Offset = "0xDB62E0", VA = "0xDB62E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0xDB631C", Offset = "0xDB631C", VA = "0xDB631C", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0xDB6320", Offset = "0xDB6320", VA = "0xDB6320")]
		public FingerTipPokeToolView()
		{
		}
	}
	[Token(Token = "0x20000CC")]
	[Flags]
	public enum InteractableToolTags
	{
		[Token(Token = "0x400045A")]
		None = 0,
		[Token(Token = "0x400045B")]
		Ray = 1,
		[Token(Token = "0x400045C")]
		Poke = 4,
		[Token(Token = "0x400045D")]
		All = -1
	}
	[Token(Token = "0x20000CD")]
	public enum ToolInputState
	{
		[Token(Token = "0x400045F")]
		Inactive,
		[Token(Token = "0x4000460")]
		PrimaryInputDown,
		[Token(Token = "0x4000461")]
		PrimaryInputDownStay,
		[Token(Token = "0x4000462")]
		PrimaryInputUp
	}
	[Token(Token = "0x20000CE")]
	public class InteractableCollisionInfo
	{
		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ColliderZone InteractableCollider;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractableCollisionDepth CollisionDepth;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractableTool CollidingTool;

		[Token(Token = "0x6000487")]
		[Address(RVA = "0xDB5C00", Offset = "0xDB5C00", VA = "0xDB5C00")]
		public InteractableCollisionInfo(ColliderZone collider, InteractableCollisionDepth collisionDepth, InteractableTool collidingTool)
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public abstract class InteractableTool : MonoBehaviour
	{
		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<InteractableCollisionInfo> _currentIntersectingObjects;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Interactable> _addedInteractables;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Interactable> _removedInteractables;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Interactable> _remainingInteractables;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Interactable, InteractableCollisionInfo> _currInteractableToCollisionInfos;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Interactable, InteractableCollisionInfo> _prevInteractableToCollisionInfos;

		[Token(Token = "0x170000A8")]
		public Transform ToolTransform
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0xDB2318", Offset = "0xDB2318", VA = "0xDB2318")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A9")]
		public bool IsRightHandedTool
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0xDB6328", Offset = "0xDB6328", VA = "0xDB6328")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0xDB6330", Offset = "0xDB6330", VA = "0xDB6330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000AA")]
		public abstract InteractableToolTags ToolTags
		{
			[Token(Token = "0x600048B")]
			get;
		}

		[Token(Token = "0x170000AB")]
		public abstract ToolInputState ToolInputState
		{
			[Token(Token = "0x600048C")]
			get;
		}

		[Token(Token = "0x170000AC")]
		public abstract bool IsFarFieldTool
		{
			[Token(Token = "0x600048D")]
			get;
		}

		[Token(Token = "0x170000AD")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0xDB633C", Offset = "0xDB633C", VA = "0xDB633C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0xDB6348", Offset = "0xDB6348", VA = "0xDB6348")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public Vector3 InteractionPosition
		{
			[Token(Token = "0x6000490")]
			[Address(RVA = "0xDB6354", Offset = "0xDB6354", VA = "0xDB6354")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000491")]
			[Address(RVA = "0xDB6360", Offset = "0xDB6360", VA = "0xDB6360")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public abstract bool EnableState
		{
			[Token(Token = "0x6000496")]
			get;
			[Token(Token = "0x6000497")]
			set;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0xDB636C", Offset = "0xDB636C", VA = "0xDB636C")]
		public List<InteractableCollisionInfo> GetCurrentIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		public abstract List<InteractableCollisionInfo> GetNextIntersectingObjects();

		[Token(Token = "0x6000494")]
		public abstract void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone);

		[Token(Token = "0x6000495")]
		public abstract void DeFocus();

		[Token(Token = "0x6000498")]
		public abstract void Initialize();

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xDB509C", Offset = "0xDB509C", VA = "0xDB509C")]
		public KeyValuePair<Interactable, InteractableCollisionInfo> GetFirstCurrentCollisionInfo()
		{
			return default(KeyValuePair<Interactable, InteractableCollisionInfo>);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xDB50E4", Offset = "0xDB50E4", VA = "0xDB50E4")]
		public void ClearAllCurrentCollisionInfos()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xDB6374", Offset = "0xDB6374", VA = "0xDB6374", Slot = "13")]
		public virtual void UpdateCurrentCollisionsBasedOnDepth()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xDB6620", Offset = "0xDB6620", VA = "0xDB6620", Slot = "14")]
		public virtual void UpdateLatestCollisionData()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xDB5C5C", Offset = "0xDB5C5C", VA = "0xDB5C5C")]
		protected InteractableTool()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public interface InteractableToolView
	{
		[Token(Token = "0x170000B0")]
		InteractableTool InteractableTool
		{
			[Token(Token = "0x600049E")]
			get;
		}

		[Token(Token = "0x170000B1")]
		bool EnableState
		{
			[Token(Token = "0x60004A0")]
			get;
			[Token(Token = "0x60004A1")]
			set;
		}

		[Token(Token = "0x170000B2")]
		bool ToolActivateState
		{
			[Token(Token = "0x60004A2")]
			get;
			[Token(Token = "0x60004A3")]
			set;
		}

		[Token(Token = "0x600049F")]
		void SetFocusedInteractable(Interactable interactable);
	}
	[Token(Token = "0x20000D1")]
	public class PinchStateModule
	{
		[Token(Token = "0x20000D2")]
		private enum PinchState
		{
			[Token(Token = "0x4000473")]
			None,
			[Token(Token = "0x4000474")]
			PinchDown,
			[Token(Token = "0x4000475")]
			PinchStay,
			[Token(Token = "0x4000476")]
			PinchUp
		}

		[Token(Token = "0x400046F")]
		private const float PINCH_STRENGTH_THRESHOLD = 1f;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private PinchState _currPinchState;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Interactable _firstFocusedInteractable;

		[Token(Token = "0x170000B3")]
		public bool PinchUpAndDownOnFocusedObject
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xDB6E68", Offset = "0xDB6E68", VA = "0xDB6E68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B4")]
		public bool PinchSteadyOnFocusedObject
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0xDB6EE4", Offset = "0xDB6EE4", VA = "0xDB6EE4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B5")]
		public bool PinchDownOnFocusedObject
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xDB6F60", Offset = "0xDB6F60", VA = "0xDB6F60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0xDB6FDC", Offset = "0xDB6FDC", VA = "0xDB6FDC")]
		public PinchStateModule()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xDB6FFC", Offset = "0xDB6FFC", VA = "0xDB6FFC")]
		public void UpdateState(OVRHand hand, Interactable currFocusedInteractable)
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class RayTool : InteractableTool
	{
		[Token(Token = "0x4000477")]
		private const float MINIMUM_RAY_CAST_DISTANCE = 0.8f;

		[Token(Token = "0x4000478")]
		private const float COLLIDER_RADIUS = 0.01f;

		[Token(Token = "0x4000479")]
		private const int NUM_MAX_PRIMARY_HITS = 10;

		[Token(Token = "0x400047A")]
		private const int NUM_MAX_SECONDARY_HITS = 25;

		[Token(Token = "0x400047B")]
		private const int NUM_COLLIDERS_TO_TEST = 20;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RayToolView _rayToolView;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Range(0f, 45f)]
		private float _coneAngleDegrees;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float _farFieldMaxDistance;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PinchStateModule _pinchStateModule;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Interactable _focusedInteractable;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] _collidersOverlapped;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Interactable _currInteractableCastedAgainst;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float _coneAngleReleaseDegrees;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RaycastHit[] _primaryHits;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Collider[] _secondaryOverlapResults;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _initialized;

		[Token(Token = "0x170000B6")]
		public override InteractableToolTags ToolTags
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xDB7148", Offset = "0xDB7148", VA = "0xDB7148", Slot = "4")]
			get
			{
				return default(InteractableToolTags);
			}
		}

		[Token(Token = "0x170000B7")]
		public override ToolInputState ToolInputState
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0xDB7150", Offset = "0xDB7150", VA = "0xDB7150", Slot = "5")]
			get
			{
				return default(ToolInputState);
			}
		}

		[Token(Token = "0x170000B8")]
		public override bool IsFarFieldTool
		{
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0xDB71AC", Offset = "0xDB71AC", VA = "0xDB71AC", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000B9")]
		public override bool EnableState
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0xDB71B4", Offset = "0xDB71B4", VA = "0xDB71B4", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xDB71F4", Offset = "0xDB71F4", VA = "0xDB71F4", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xDB7264", Offset = "0xDB7264", VA = "0xDB7264", Slot = "12")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0xDB72B0", Offset = "0xDB72B0", VA = "0xDB72B0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xDB733C", Offset = "0xDB733C", VA = "0xDB733C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xDB75E0", Offset = "0xDB75E0", VA = "0xDB75E0")]
		private Vector3 GetRayCastOrigin()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xDB765C", Offset = "0xDB765C", VA = "0xDB765C", Slot = "7")]
		public override List<InteractableCollisionInfo> GetNextIntersectingObjects()
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0xDB7A20", Offset = "0xDB7A20", VA = "0xDB7A20")]
		private bool HasRayReleasedInteractable(Interactable focusedInteractable)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xDB7BBC", Offset = "0xDB7BBC", VA = "0xDB7BBC")]
		private Interactable FindTargetInteractable()
		{
			return null;
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0xDB7CD4", Offset = "0xDB7CD4", VA = "0xDB7CD4")]
		private Interactable FindPrimaryRaycastHit(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xDB7FF8", Offset = "0xDB7FF8", VA = "0xDB7FF8")]
		private Interactable FindInteractableViaConeTest(Vector3 rayOrigin, Vector3 rayDirection)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xDB8374", Offset = "0xDB8374", VA = "0xDB8374", Slot = "8")]
		public override void FocusOnInteractable(Interactable focusedInteractable, ColliderZone colliderZone)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xDB8434", Offset = "0xDB8434", VA = "0xDB8434", Slot = "9")]
		public override void DeFocus()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0xDB845C", Offset = "0xDB845C", VA = "0xDB845C")]
		public RayTool()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class RayToolView : MonoBehaviour, InteractableToolView
	{
		[Token(Token = "0x4000487")]
		private const int NUM_RAY_LINE_POSITIONS = 25;

		[Token(Token = "0x4000488")]
		private const float DEFAULT_RAY_CAST_DISTANCE = 3f;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _targetTransform;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LineRenderer _lineRenderer;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _toolActivateState;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform _focusedTransform;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3[] linePositions;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Gradient _oldColorGradient;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Gradient _highLightColorGradient;

		[Token(Token = "0x170000BA")]
		public bool EnableState
		{
			[Token(Token = "0x60004BA")]
			[Address(RVA = "0xDB71D8", Offset = "0xDB71D8", VA = "0xDB71D8", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xDB7210", Offset = "0xDB7210", VA = "0xDB7210", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public bool ToolActivateState
		{
			[Token(Token = "0x60004BC")]
			[Address(RVA = "0xDB8534", Offset = "0xDB8534", VA = "0xDB8534", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004BD")]
			[Address(RVA = "0xDB75A4", Offset = "0xDB75A4", VA = "0xDB75A4", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public InteractableTool InteractableTool
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xDB873C", Offset = "0xDB873C", VA = "0xDB873C", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C0")]
			[Address(RVA = "0xDB8744", Offset = "0xDB8744", VA = "0xDB8744")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xDB853C", Offset = "0xDB853C", VA = "0xDB853C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0xDB83A4", Offset = "0xDB83A4", VA = "0xDB83A4", Slot = "5")]
		public void SetFocusedInteractable(Interactable interactable)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xDB874C", Offset = "0xDB874C", VA = "0xDB874C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xDB89F8", Offset = "0xDB89F8", VA = "0xDB89F8")]
		public static Vector3 GetPointOnBezierCurve(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xDB8AA0", Offset = "0xDB8AA0", VA = "0xDB8AA0")]
		public RayToolView()
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class DistanceGrabberSample : MonoBehaviour
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool useSpherecast;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool allowGrabThroughWalls;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private DistanceGrabber[] m_grabbers;

		[Token(Token = "0x170000BD")]
		public bool UseSpherecast
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xDB8AF8", Offset = "0xDB8AF8", VA = "0xDB8AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0xDB8B00", Offset = "0xDB8B00", VA = "0xDB8B00")]
			set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public bool AllowGrabThroughWalls
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xDB8B6C", Offset = "0xDB8B6C", VA = "0xDB8B6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xDB8B74", Offset = "0xDB8B74", VA = "0xDB8B74")]
			set
			{
			}
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xDB8BD0", Offset = "0xDB8BD0", VA = "0xDB8BD0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xDB8E70", Offset = "0xDB8E70", VA = "0xDB8E70")]
		public void ToggleSphereCasting(Toggle t)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0xDB8E80", Offset = "0xDB8E80", VA = "0xDB8E80")]
		public void ToggleGrabThroughWalls(Toggle t)
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xDB8E90", Offset = "0xDB8E90", VA = "0xDB8E90")]
		public DistanceGrabberSample()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class ControllerBoxController : MonoBehaviour
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TrainLocomotive _locomotive;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CowController _cowController;

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0xDB8E98", Offset = "0xDB8E98", VA = "0xDB8E98")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xDB8E9C", Offset = "0xDB8E9C", VA = "0xDB8E9C")]
		public void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xDB8F08", Offset = "0xDB8F08", VA = "0xDB8F08")]
		public void DecreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xDB8F98", Offset = "0xDB8F98", VA = "0xDB8F98")]
		public void IncreaseSpeedStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0xDB9028", Offset = "0xDB9028", VA = "0xDB9028")]
		public void SmokeButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xDB90D4", Offset = "0xDB90D4", VA = "0xDB90D4")]
		public void WhistleButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0xDB91B0", Offset = "0xDB91B0", VA = "0xDB91B0")]
		public void ReverseButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xDB91F4", Offset = "0xDB91F4", VA = "0xDB91F4")]
		public void SwitchVisualization(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xDB9254", Offset = "0xDB9254", VA = "0xDB9254")]
		public void GoMoo(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xDB92B4", Offset = "0xDB92B4", VA = "0xDB92B4")]
		public ControllerBoxController()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class CowController : MonoBehaviour
	{
		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animation _cowAnimation;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioSource _mooCowAudioSource;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0xDB92BC", Offset = "0xDB92BC", VA = "0xDB92BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xDB92C0", Offset = "0xDB92C0", VA = "0xDB92C0")]
		public void PlayMooSound()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0xDB9284", Offset = "0xDB9284", VA = "0xDB9284")]
		public void GoMooCowGo()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xDB92F4", Offset = "0xDB92F4", VA = "0xDB92F4")]
		public CowController()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class PanelHMDFollower : MonoBehaviour
	{
		[Token(Token = "0x20000D9")]
		[CompilerGenerated]
		private sealed class <LerpToHMD>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PanelHMDFollower <>4__this;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 <newPanelPosition>5__2;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <startTime>5__3;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <endTime>5__4;

			[Token(Token = "0x170000BF")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004E3")]
				[Address(RVA = "0xDB993C", Offset = "0xDB993C", VA = "0xDB993C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004E5")]
				[Address(RVA = "0xDB9984", Offset = "0xDB9984", VA = "0xDB9984", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004E0")]
			[Address(RVA = "0xDB96C4", Offset = "0xDB96C4", VA = "0xDB96C4")]
			[DebuggerHidden]
			public <LerpToHMD>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x60004E1")]
			[Address(RVA = "0xDB978C", Offset = "0xDB978C", VA = "0xDB978C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004E2")]
			[Address(RVA = "0xDB9790", Offset = "0xDB9790", VA = "0xDB9790", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004E4")]
			[Address(RVA = "0xDB9944", Offset = "0xDB9944", VA = "0xDB9944", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000498")]
		private const float TOTAL_DURATION = 3f;

		[Token(Token = "0x4000499")]
		private const float HMD_MOVEMENT_THRESHOLD = 0.3f;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _maxDistance;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _minDistance;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _minZDistance;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OVRCameraRig _cameraRig;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _panelInitialPosition;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _coroutine;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 _prevPos;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 _lastMovedToPos;

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xDB92FC", Offset = "0xDB92FC", VA = "0xDB92FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xDB9390", Offset = "0xDB9390", VA = "0xDB9390")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0xDB9684", Offset = "0xDB9684", VA = "0xDB9684")]
		private Vector3 CalculateIdealAnchorPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xDB961C", Offset = "0xDB961C", VA = "0xDB961C")]
		[IteratorStateMachine(typeof(<LerpToHMD>d__13))]
		private IEnumerator LerpToHMD()
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0xDB96EC", Offset = "0xDB96EC", VA = "0xDB96EC")]
		public PanelHMDFollower()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class SelectionCylinder : MonoBehaviour
	{
		[Token(Token = "0x20000DB")]
		public enum SelectionState
		{
			[Token(Token = "0x40004AF")]
			Off,
			[Token(Token = "0x40004B0")]
			Selected,
			[Token(Token = "0x40004B1")]
			Highlighted
		}

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _selectionMeshRenderer;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int _colorId;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material[] _selectionMaterials;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color[] _defaultSelectionColors;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Color[] _highlightColors;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SelectionState _currSelectionState;

		[Token(Token = "0x170000C1")]
		public SelectionState CurrSelectionState
		{
			[Token(Token = "0x60004E6")]
			[Address(RVA = "0xDB998C", Offset = "0xDB998C", VA = "0xDB998C")]
			get
			{
				return default(SelectionState);
			}
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0xDB9994", Offset = "0xDB9994", VA = "0xDB9994")]
			set
			{
			}
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xDB9AE8", Offset = "0xDB9AE8", VA = "0xDB9AE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xDB9C70", Offset = "0xDB9C70", VA = "0xDB9C70")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xDB9A08", Offset = "0xDB9A08", VA = "0xDB9A08")]
		private void AffectSelectionColor(Color[] newColors)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xDB9D38", Offset = "0xDB9D38", VA = "0xDB9D38")]
		public SelectionCylinder()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class TrackSegment : MonoBehaviour
	{
		[Token(Token = "0x20000DD")]
		public enum SegmentType
		{
			[Token(Token = "0x40004C0")]
			Straight,
			[Token(Token = "0x40004C1")]
			LeftTurn,
			[Token(Token = "0x40004C2")]
			RightTurn,
			[Token(Token = "0x40004C3")]
			Switch
		}

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SegmentType _segmentType;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshFilter _straight;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshFilter _leftTurn;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshFilter _rightTurn;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _gridSize;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _subDivCount;

		[Token(Token = "0x40004B8")]
		private const float _originalGridSize = 0.8f;

		[Token(Token = "0x40004B9")]
		private const float _trackWidth = 0.15f;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject _mesh;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Pose _p1;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Pose _p2;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Pose _endPose;

		[Token(Token = "0x170000C2")]
		public float StartDistance
		{
			[Token(Token = "0x60004ED")]
			[Address(RVA = "0xDB9DA8", Offset = "0xDB9DA8", VA = "0xDB9DA8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004EE")]
			[Address(RVA = "0xDB9DB0", Offset = "0xDB9DB0", VA = "0xDB9DB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public float GridSize
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xDB9DB8", Offset = "0xDB9DB8", VA = "0xDB9DB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0xDB9DC0", Offset = "0xDB9DC0", VA = "0xDB9DC0")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public int SubDivCount
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xDB9DC8", Offset = "0xDB9DC8", VA = "0xDB9DC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004F2")]
			[Address(RVA = "0xDB9DD0", Offset = "0xDB9DD0", VA = "0xDB9DD0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public SegmentType Type
		{
			[Token(Token = "0x60004F3")]
			[Address(RVA = "0xDB9DD8", Offset = "0xDB9DD8", VA = "0xDB9DD8")]
			get
			{
				return default(SegmentType);
			}
		}

		[Token(Token = "0x170000C6")]
		public Pose EndPose
		{
			[Token(Token = "0x60004F4")]
			[Address(RVA = "0xDB9DE0", Offset = "0xDB9DE0", VA = "0xDB9DE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C7")]
		public float Radius
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xDBA1B4", Offset = "0xDBA1B4", VA = "0xDBA1B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000C8")]
		public float SegmentLength
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xDB9E3C", Offset = "0xDB9E3C", VA = "0xDB9E3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xDBA1C4", Offset = "0xDBA1C4", VA = "0xDBA1C4")]
		public float setGridSize(float size)
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xDBA1DC", Offset = "0xDBA1DC", VA = "0xDBA1DC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xDB9E7C", Offset = "0xDB9E7C", VA = "0xDB9E7C")]
		public void UpdatePose(float distanceIntoSegment, Pose pose)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xDBA1E0", Offset = "0xDBA1E0", VA = "0xDBA1E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xDBA1E4", Offset = "0xDBA1E4", VA = "0xDBA1E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xDBA240", Offset = "0xDBA240", VA = "0xDBA240")]
		private void DrawDebugLines()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0xDBAB74", Offset = "0xDBAB74", VA = "0xDBAB74")]
		public void RegenerateTrackAndMesh()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xDBADCC", Offset = "0xDBADCC", VA = "0xDBADCC")]
		public TrackSegment()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class TrainButtonVisualController : MonoBehaviour
	{
		[Token(Token = "0x20000DF")]
		[CompilerGenerated]
		private sealed class <ResetPosition>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainButtonVisualController <>4__this;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <startTime>5__2;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <endTime>5__3;

			[Token(Token = "0x170000C9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600050D")]
				[Address(RVA = "0xDBB884", Offset = "0xDBB884", VA = "0xDBB884", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600050F")]
				[Address(RVA = "0xDBB8CC", Offset = "0xDBB8CC", VA = "0xDBB8CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0xDBB6C8", Offset = "0xDBB6C8", VA = "0xDBB6C8")]
			[DebuggerHidden]
			public <ResetPosition>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0xDBB718", Offset = "0xDBB718", VA = "0xDBB718", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0xDBB71C", Offset = "0xDBB71C", VA = "0xDBB71C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600050E")]
			[Address(RVA = "0xDBB88C", Offset = "0xDBB88C", VA = "0xDBB88C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004C4")]
		private const float LERP_TO_OLD_POS_DURATION = 1f;

		[Token(Token = "0x40004C5")]
		private const float LOCAL_SIZE_HALVED = 0.5f;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer _glowRenderer;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ButtonController _buttonController;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _buttonContactColor;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _buttonActionColor;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private AudioClip _actionSoundEffect;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform _buttonContactTransform;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _contactMaxDisplacementDistance;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Material _buttonMaterial;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Color _buttonDefaultColor;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _materialColorId;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private bool _buttonInContactOrActionStates;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine _lerpToOldPositionCr;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 _oldPosition;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xDBAF08", Offset = "0xDBAF08", VA = "0xDBAF08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xDBAFAC", Offset = "0xDBAFAC", VA = "0xDBAFAC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0xDBB03C", Offset = "0xDBB03C", VA = "0xDBB03C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xDBB184", Offset = "0xDBB184", VA = "0xDBB184")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0xDBB310", Offset = "0xDBB310", VA = "0xDBB310")]
		private void ActionOrInContactZoneStayEvent(ColliderZoneArgs collisionArgs)
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xDBB420", Offset = "0xDBB420", VA = "0xDBB420")]
		private void InteractableStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xDBB60C", Offset = "0xDBB60C", VA = "0xDBB60C")]
		private void PlaySound(AudioClip clip)
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xDBB530", Offset = "0xDBB530", VA = "0xDBB530")]
		private void StopResetLerping()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0xDBB544", Offset = "0xDBB544", VA = "0xDBB544")]
		private void LerpToOldPosition()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xDBB660", Offset = "0xDBB660", VA = "0xDBB660")]
		[IteratorStateMachine(typeof(<ResetPosition>d__26))]
		private IEnumerator ResetPosition()
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0xDBB6F0", Offset = "0xDBB6F0", VA = "0xDBB6F0")]
		public TrainButtonVisualController()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class TrainCar : TrainCarBase
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private TrainCarBase _parentLocomotive;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected float _distanceBehindParent;

		[Token(Token = "0x170000CB")]
		public float DistanceBehindParentScaled
		{
			[Token(Token = "0x6000510")]
			[Address(RVA = "0xDBB8D4", Offset = "0xDBB8D4", VA = "0xDBB8D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xDBB8E4", Offset = "0xDBB8E4", VA = "0xDBB8E4", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xDBB8EC", Offset = "0xDBB8EC", VA = "0xDBB8EC", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0xDBBC1C", Offset = "0xDBBC1C", VA = "0xDBBC1C")]
		public TrainCar()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public abstract class TrainCarBase : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Vector3 OFFSET;

		[Token(Token = "0x40004DD")]
		private const float WHEEL_RADIUS = 0.027f;

		[Token(Token = "0x40004DE")]
		private const float TWO_PI = (float)Math.PI * 2f;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform _frontWheels;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Transform _rearWheels;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TrainTrack _trainTrack;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Transform[] _individualWheels;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float scale;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Pose _frontPose;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Pose _rearPose;

		[Token(Token = "0x170000CC")]
		public float Distance
		{
			[Token(Token = "0x6000514")]
			[Address(RVA = "0xDBBD00", Offset = "0xDBBD00", VA = "0xDBBD00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xDBBD08", Offset = "0xDBBD08", VA = "0xDBBD08")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public float Scale
		{
			[Token(Token = "0x6000516")]
			[Address(RVA = "0xDBBD10", Offset = "0xDBBD10", VA = "0xDBBD10")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000517")]
			[Address(RVA = "0xDBBD18", Offset = "0xDBBD18", VA = "0xDBBD18")]
			set
			{
			}
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xDBB8E8", Offset = "0xDBB8E8", VA = "0xDBB8E8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0xDBBD20", Offset = "0xDBBD20", VA = "0xDBBD20")]
		public void UpdatePose(float distance, TrainCarBase train, Pose pose)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xDBB928", Offset = "0xDBB928", VA = "0xDBB928")]
		protected void UpdateCarPosition()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0xDBBB38", Offset = "0xDBBB38", VA = "0xDBBB38")]
		protected void RotateCarWheels()
		{
		}

		[Token(Token = "0x600051C")]
		public abstract void UpdatePosition();

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xDBBC7C", Offset = "0xDBBC7C", VA = "0xDBBC7C")]
		protected TrainCarBase()
		{
		}
	}
	[Token(Token = "0x20000E2")]
	public class TrainCrossingController : MonoBehaviour
	{
		[Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <AnimateCrossing>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TrainCrossingController <>4__this;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float animationLength;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <animationEndTime>5__2;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <lightBlinkDuration>5__3;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <lightBlinkStartTime>5__4;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <lightBlinkEndTime>5__5;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Material <lightToBlinkOn>5__6;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Material <lightToBlinkOff>5__7;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Color <onColor>5__8;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color <offColor>5__9;

			[Token(Token = "0x170000CE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600052B")]
				[Address(RVA = "0xDBC568", Offset = "0xDBC568", VA = "0xDBC568", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000CF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600052D")]
				[Address(RVA = "0xDBC5B0", Offset = "0xDBC5B0", VA = "0xDBC5B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000528")]
			[Address(RVA = "0xDBC22C", Offset = "0xDBC22C", VA = "0xDBC22C")]
			[DebuggerHidden]
			public <AnimateCrossing>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000529")]
			[Address(RVA = "0xDBC3A0", Offset = "0xDBC3A0", VA = "0xDBC3A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052A")]
			[Address(RVA = "0xDBC3A4", Offset = "0xDBC3A4", VA = "0xDBC3A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0xDBC570", Offset = "0xDBC570", VA = "0xDBC570", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip[] _crossingSounds;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MeshRenderer _lightSide1Renderer;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private MeshRenderer _lightSide2Renderer;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material _lightsSide1Mat;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material _lightsSide2Mat;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _colorId;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Coroutine _xingAnimationCr;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x600051F")]
		[Address(RVA = "0xDBBE90", Offset = "0xDBBE90", VA = "0xDBBE90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xDBBED0", Offset = "0xDBBED0", VA = "0xDBBED0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0xDBBFA8", Offset = "0xDBBFA8", VA = "0xDBBFA8")]
		public void CrossingButtonStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xDBC0EC", Offset = "0xDBC0EC", VA = "0xDBC0EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xDBC000", Offset = "0xDBC000", VA = "0xDBC000")]
		private void ActivateTrainCrossing()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xDBC1B4", Offset = "0xDBC1B4", VA = "0xDBC1B4")]
		[IteratorStateMachine(typeof(<AnimateCrossing>d__15))]
		private IEnumerator AnimateCrossing(float animationLength)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0xDBC254", Offset = "0xDBC254", VA = "0xDBC254")]
		private void AffectMaterials(Material[] materials, Color newColor)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xDBC2EC", Offset = "0xDBC2EC", VA = "0xDBC2EC")]
		private void ToggleLightObjects(bool enableState)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0xDBC348", Offset = "0xDBC348", VA = "0xDBC348")]
		public TrainCrossingController()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class TrainLocomotive : TrainCarBase
	{
		[Token(Token = "0x20000E5")]
		private enum EngineSoundState
		{
			[Token(Token = "0x400051B")]
			Start,
			[Token(Token = "0x400051C")]
			AccelerateOrSetProperSpeed,
			[Token(Token = "0x400051D")]
			Stop
		}

		[Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private sealed class <StartStopTrain>d__34 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool startTrain;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrainLocomotive <>4__this;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <endSpeed>5__2;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <timePeriodForSpeedChange>5__3;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private float <startTime>5__4;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <endTime>5__5;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <startSpeed>5__6;

			[Token(Token = "0x170000D0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000540")]
				[Address(RVA = "0xDBCE14", Offset = "0xDBCE14", VA = "0xDBCE14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000542")]
				[Address(RVA = "0xDBCE5C", Offset = "0xDBCE5C", VA = "0xDBCE5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0xDBC840", Offset = "0xDBC840", VA = "0xDBC840")]
			[DebuggerHidden]
			public <StartStopTrain>d__34(int <>1__state)
			{
			}

			[Token(Token = "0x600053E")]
			[Address(RVA = "0xDBCC08", Offset = "0xDBCC08", VA = "0xDBCC08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053F")]
			[Address(RVA = "0xDBCC0C", Offset = "0xDBCC0C", VA = "0xDBCC0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000541")]
			[Address(RVA = "0xDBCE1C", Offset = "0xDBCE1C", VA = "0xDBCE1C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004FD")]
		private const float MIN_SPEED = 0.2f;

		[Token(Token = "0x40004FE")]
		private const float MAX_SPEED = 2.7f;

		[Token(Token = "0x40004FF")]
		private const float SMOKE_SPEED_MULTIPLIER = 8f;

		[Token(Token = "0x4000500")]
		private const int MAX_PARTICLES_MULTIPLIER = 3;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(0.2f, 2.7f)]
		protected float _initialSpeed;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _decreaseSpeedButton;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _increaseSpeedButton;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _smokeButton;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _whistleButton;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _reverseButton;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private AudioSource _whistleAudioSource;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private AudioClip _whistleSound;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private AudioSource _engineAudioSource;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private AudioClip[] _accelerationSounds;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private AudioClip[] _decelerationSounds;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private AudioClip _startUpSound;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private AudioSource _smokeStackAudioSource;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private AudioClip _smokeSound;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private ParticleSystem _smoke1;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private ParticleSystem _smoke2;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private TrainCarBase[] _childCars;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool _isMoving;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		private bool _reverse;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _currentSpeed;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float _speedDiv;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float _standardRateOverTimeMultiplier;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private int _standardMaxParticles;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Coroutine _startStopTrainCr;

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xDBC5B8", Offset = "0xDBC5B8", VA = "0xDBC5B8")]
		private void Start()
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xDBC6FC", Offset = "0xDBC6FC", VA = "0xDBC6FC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xDBC708", Offset = "0xDBC708", VA = "0xDBC708", Slot = "5")]
		public override void UpdatePosition()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0xDB8ECC", Offset = "0xDB8ECC", VA = "0xDB8ECC")]
		public void StartStopStateChanged()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xDBC680", Offset = "0xDBC680", VA = "0xDBC680")]
		[IteratorStateMachine(typeof(<StartStopTrain>d__34))]
		private IEnumerator StartStopTrain(bool startTrain)
		{
			return null;
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0xDBC868", Offset = "0xDBC868", VA = "0xDBC868")]
		private float PlayEngineSound(EngineSoundState engineSoundState)
		{
			return default(float);
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xDBC7E0", Offset = "0xDBC7E0", VA = "0xDBC7E0")]
		private void UpdateDistance()
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xDB8F38", Offset = "0xDB8F38", VA = "0xDB8F38")]
		public void DecreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xDB8FC8", Offset = "0xDB8FC8", VA = "0xDB8FC8")]
		public void IncreaseSpeedStateChanged()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0xDBCA7C", Offset = "0xDBCA7C", VA = "0xDBCA7C")]
		private void UpdateSmokeEmissionBasedOnSpeed()
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xDBCB70", Offset = "0xDBCB70", VA = "0xDBCB70")]
		private float GetCurrentSmokeEmission()
		{
			return default(float);
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0xDB9058", Offset = "0xDB9058", VA = "0xDB9058")]
		public void SmokeButtonStateChanged()
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xDB9104", Offset = "0xDB9104", VA = "0xDB9104")]
		public void WhistleButtonStateChanged()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xDB91E4", Offset = "0xDB91E4", VA = "0xDB91E4")]
		public void ReverseButtonStateChanged()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xDBCBAC", Offset = "0xDBCBAC", VA = "0xDBCBAC")]
		public TrainLocomotive()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class TrainTrack : MonoBehaviour
	{
		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _gridSize;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private int _subDivCount;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _segmentParent;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _trainParent;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _regnerateTrackMeshOnAwake;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float _trainLength;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TrackSegment[] _trackSegments;

		[Token(Token = "0x170000D2")]
		public float TrackLength
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xDBCE64", Offset = "0xDBCE64", VA = "0xDBCE64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0xDBCE6C", Offset = "0xDBCE6C", VA = "0xDBCE6C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0xDBCE74", Offset = "0xDBCE74", VA = "0xDBCE74")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xDBBD88", Offset = "0xDBBD88", VA = "0xDBBD88")]
		public TrackSegment GetSegment(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xDBCE78", Offset = "0xDBCE78", VA = "0xDBCE78")]
		public void Regenerate()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xDBD064", Offset = "0xDBD064", VA = "0xDBD064")]
		private void SetScale(float ratio)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0xDBD144", Offset = "0xDBD144", VA = "0xDBD144")]
		public TrainTrack()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class Pose
	{
		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xDBAE70", Offset = "0xDBAE70", VA = "0xDBAE70")]
		public Pose()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0xDBD160", Offset = "0xDBD160", VA = "0xDBD160")]
		public Pose(Vector3 position, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class WindmillBladesController : MonoBehaviour
	{
		[Token(Token = "0x20000EA")]
		[CompilerGenerated]
		private sealed class <LerpToSpeed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float goalSpeed;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <totalTime>5__2;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <startSpeed>5__3;

			[Token(Token = "0x170000D4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0xDBD6EC", Offset = "0xDBD6EC", VA = "0xDBD6EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0xDBD734", Offset = "0xDBD734", VA = "0xDBD734", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0xDBD41C", Offset = "0xDBD41C", VA = "0xDBD41C")]
			[DebuggerHidden]
			public <LerpToSpeed>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0xDBD568", Offset = "0xDBD568", VA = "0xDBD568", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0xDBD56C", Offset = "0xDBD56C", VA = "0xDBD56C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0xDBD6F4", Offset = "0xDBD6F4", VA = "0xDBD6F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[CompilerGenerated]
		private sealed class <PlaySoundDelayed>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WindmillBladesController <>4__this;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AudioClip initial;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeDelayAfterInitial;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public AudioClip clip;

			[Token(Token = "0x170000D6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0xDBD804", Offset = "0xDBD804", VA = "0xDBD804", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0xDBD84C", Offset = "0xDBD84C", VA = "0xDBD84C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600055B")]
			[Address(RVA = "0xDBD4D0", Offset = "0xDBD4D0", VA = "0xDBD4D0")]
			[DebuggerHidden]
			public <PlaySoundDelayed>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0xDBD73C", Offset = "0xDBD73C", VA = "0xDBD73C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055D")]
			[Address(RVA = "0xDBD740", Offset = "0xDBD740", VA = "0xDBD740", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055F")]
			[Address(RVA = "0xDBD80C", Offset = "0xDBD80C", VA = "0xDBD80C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000530")]
		private const float MAX_TIME = 1f;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AudioSource _audioSource;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AudioClip _windMillRotationSound;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioClip _windMillStartSound;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AudioClip _windMillStopSound;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _currentSpeed;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Coroutine _lerpSpeedCoroutine;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine _audioChangeCr;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion _originalRotation;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float _rotAngle;

		[Token(Token = "0x170000D3")]
		public bool IsMoving
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0xDBD1C4", Offset = "0xDBD1C4", VA = "0xDBD1C4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0xDBD1CC", Offset = "0xDBD1CC", VA = "0xDBD1CC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xDBD1D8", Offset = "0xDBD1D8", VA = "0xDBD1D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xDBD208", Offset = "0xDBD208", VA = "0xDBD208")]
		private void Update()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xDBD348", Offset = "0xDBD348", VA = "0xDBD348")]
		public void SetMoveState(bool newMoveState, float goalSpeed)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0xDBD3A4", Offset = "0xDBD3A4", VA = "0xDBD3A4")]
		[IteratorStateMachine(typeof(<LerpToSpeed>d__17))]
		private IEnumerator LerpToSpeed(float goalSpeed)
		{
			return null;
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0xDBD444", Offset = "0xDBD444", VA = "0xDBD444")]
		[IteratorStateMachine(typeof(<PlaySoundDelayed>d__18))]
		private IEnumerator PlaySoundDelayed(AudioClip initial, AudioClip clip, float timeDelayAfterInitial)
		{
			return null;
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0xDBD4F8", Offset = "0xDBD4F8", VA = "0xDBD4F8")]
		private void PlaySound(AudioClip clip, bool loop = false)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xDBD560", Offset = "0xDBD560", VA = "0xDBD560")]
		public WindmillBladesController()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class WindmillController : MonoBehaviour
	{
		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _startStopButton;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _maxSpeed;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectionCylinder _selectionCylinder;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WindmillBladesController _bladesRotation;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private InteractableTool _toolInteractingWithMe;

		[Token(Token = "0x6000561")]
		[Address(RVA = "0xDBD854", Offset = "0xDBD854", VA = "0xDBD854")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0xDBD8B4", Offset = "0xDBD8B4", VA = "0xDBD8B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xDBD97C", Offset = "0xDBD97C", VA = "0xDBD97C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xDBDA8C", Offset = "0xDBDA8C", VA = "0xDBDA8C")]
		private void StartStopStateChanged(InteractableStateArgs obj)
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xDBDB04", Offset = "0xDBDB04", VA = "0xDBDB04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0xDBDBCC", Offset = "0xDBDBCC", VA = "0xDBDBCC")]
		public WindmillController()
		{
		}
	}
	[Token(Token = "0x20000ED")]
	public enum EUiDisplayType
	{
		[Token(Token = "0x400054D")]
		EUDT_WorldGeoQuad,
		[Token(Token = "0x400054E")]
		EUDT_OverlayQuad,
		[Token(Token = "0x400054F")]
		EUDT_None,
		[Token(Token = "0x4000550")]
		EUDT_MaxDislayTypes
	}
	[Token(Token = "0x20000EE")]
	public class OVROverlaySample : MonoBehaviour
	{
		[Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private sealed class <WaitforOVROverlay>d__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OVROverlaySample <>4__this;

			[Token(Token = "0x170000D8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0xDBF1D0", Offset = "0xDBF1D0", VA = "0xDBF1D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057C")]
				[Address(RVA = "0xDBF218", Offset = "0xDBF218", VA = "0xDBF218", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0xDBE894", Offset = "0xDBE894", VA = "0xDBE894")]
			[DebuggerHidden]
			public <WaitforOVROverlay>d__30(int <>1__state)
			{
			}

			[Token(Token = "0x6000578")]
			[Address(RVA = "0xDBEFF0", Offset = "0xDBEFF0", VA = "0xDBEFF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000579")]
			[Address(RVA = "0xDBEFF4", Offset = "0xDBEFF4", VA = "0xDBEFF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0xDBF1D8", Offset = "0xDBF1D8", VA = "0xDBF1D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inMenu;

		[Token(Token = "0x4000552")]
		private const string ovrOverlayID = "OVROverlayID";

		[Token(Token = "0x4000553")]
		private const string applicationID = "ApplicationID";

		[Token(Token = "0x4000554")]
		private const string noneID = "NoneID";

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Toggle applicationRadioButton;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Toggle noneRadioButton;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("App vs Compositor Comparison Settings")]
		public GameObject mainCamera;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject uiCamera;

		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject uiGeoParent;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject worldspaceGeoParent;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public OVROverlay cameraRenderOverlay;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OVROverlay renderingLabelOverlay;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Texture applicationLabelTexture;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Texture compositorLabelTexture;

		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Level Loading Sim Settings")]
		public GameObject prefabForLevelLoadSim;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public OVROverlay cubemapOverlay;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public OVROverlay loadingTextQuadOverlay;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float distanceFromCamToLoadText;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float cubeSpawnRadius;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float heightBetweenItems;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public int numObjectsPerLevel;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public int numLevels;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public int numLoopsTrigger;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<GameObject> spawnedCubes;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xDBDBDC", Offset = "0xDBDBDC", VA = "0xDBDBDC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0xDBE3F8", Offset = "0xDBE3F8", VA = "0xDBE3F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xDBE520", Offset = "0xDBE520", VA = "0xDBE520")]
		private void ActivateWorldGeo()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xDBE63C", Offset = "0xDBE63C", VA = "0xDBE63C")]
		private void ActivateOVROverlay()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xDBE758", Offset = "0xDBE758", VA = "0xDBE758")]
		private void ActivateNone()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0xDBE500", Offset = "0xDBE500", VA = "0xDBE500")]
		private void TriggerLoad()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xDBE82C", Offset = "0xDBE82C", VA = "0xDBE82C")]
		[IteratorStateMachine(typeof(<WaitforOVROverlay>d__30))]
		private IEnumerator WaitforOVROverlay()
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0xDBE8BC", Offset = "0xDBE8BC", VA = "0xDBE8BC")]
		private void TriggerUnload()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xDBE034", Offset = "0xDBE034", VA = "0xDBE034")]
		private void CameraAndRenderTargetSetup()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xDBEA04", Offset = "0xDBEA04", VA = "0xDBEA04")]
		private void SimulateLevelLoad()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xDBE8E4", Offset = "0xDBE8E4", VA = "0xDBE8E4")]
		private void ClearObjects()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0xDBED80", Offset = "0xDBED80", VA = "0xDBED80")]
		public void RadioPressed(string radioLabel, string group, Toggle t)
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xDBEE6C", Offset = "0xDBEE6C", VA = "0xDBEE6C")]
		public OVROverlaySample()
		{
		}
	}
}
namespace OVRTouchSample
{
	[Token(Token = "0x20000F0")]
	[RequireComponent(typeof(OVRGrabber))]
	public class Hand : MonoBehaviour
	{
		[Token(Token = "0x400056C")]
		public const string ANIM_LAYER_NAME_POINT = "Point Layer";

		[Token(Token = "0x400056D")]
		public const string ANIM_LAYER_NAME_THUMB = "Thumb Layer";

		[Token(Token = "0x400056E")]
		public const string ANIM_PARAM_NAME_FLEX = "Flex";

		[Token(Token = "0x400056F")]
		public const string ANIM_PARAM_NAME_POSE = "Pose";

		[Token(Token = "0x4000570")]
		public const float THRESH_COLLISION_FLEX = 0.9f;

		[Token(Token = "0x4000571")]
		public const float INPUT_RATE_CHANGE = 20f;

		[Token(Token = "0x4000572")]
		public const float COLLIDER_SCALE_MIN = 0.01f;

		[Token(Token = "0x4000573")]
		public const float COLLIDER_SCALE_MAX = 1f;

		[Token(Token = "0x4000574")]
		public const float COLLIDER_SCALE_PER_SECOND = 1f;

		[Token(Token = "0x4000575")]
		public const float TRIGGER_DEBOUNCE_TIME = 0.05f;

		[Token(Token = "0x4000576")]
		public const float THUMB_DEBOUNCE_TIME = 0.15f;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandPose m_defaultGrabPose;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider[] m_colliders;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_collisionEnabled;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private OVRGrabber m_grabber;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Renderer> m_showAfterInputFocusAcquired;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_animLayerIndexThumb;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_animLayerIndexPoint;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_animParamIndexFlex;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_animParamIndexPose;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isPointing;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool m_isGivingThumbsUp;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_pointBlend;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_thumbsUpBlend;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_collisionScaleCurrent;

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xDBF220", Offset = "0xDBF220", VA = "0xDBF220")]
		private void Awake()
		{
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0xDBF270", Offset = "0xDBF270", VA = "0xDBF270")]
		private void Start()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xDBF6A0", Offset = "0xDBF6A0", VA = "0xDBF6A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0xDBF78C", Offset = "0xDBF78C", VA = "0xDBF78C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xDBF8F0", Offset = "0xDBF8F0", VA = "0xDBF8F0")]
		private void UpdateCapTouchStates()
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xDBFBC0", Offset = "0xDBFBC0", VA = "0xDBFBC0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xDBFCA4", Offset = "0xDBFCA4", VA = "0xDBFCA4")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0xDBFE4C", Offset = "0xDBFE4C", VA = "0xDBFE4C")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xDBF97C", Offset = "0xDBF97C", VA = "0xDBF97C")]
		private float InputValueRateChange(bool isDown, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0xDBF9D0", Offset = "0xDBF9D0", VA = "0xDBF9D0")]
		private void UpdateAnimStates()
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xDBF560", Offset = "0xDBF560", VA = "0xDBF560")]
		private void CollisionEnable(bool enabled)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xDBFF70", Offset = "0xDBFF70", VA = "0xDBFF70")]
		public Hand()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public enum HandPoseId
	{
		[Token(Token = "0x400058B")]
		Default,
		[Token(Token = "0x400058C")]
		Generic,
		[Token(Token = "0x400058D")]
		PingPongBall,
		[Token(Token = "0x400058E")]
		Controller
	}
	[Token(Token = "0x20000F3")]
	public class HandPose : MonoBehaviour
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_allowPointing;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool m_allowThumbsUp;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private HandPoseId m_poseId;

		[Token(Token = "0x170000DA")]
		public bool AllowPointing
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xDC001C", Offset = "0xDC001C", VA = "0xDC001C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DB")]
		public bool AllowThumbsUp
		{
			[Token(Token = "0x600058D")]
			[Address(RVA = "0xDC0024", Offset = "0xDC0024", VA = "0xDC0024")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000DC")]
		public HandPoseId PoseId
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0xDC002C", Offset = "0xDC002C", VA = "0xDC002C")]
			get
			{
				return default(HandPoseId);
			}
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xDC0034", Offset = "0xDC0034", VA = "0xDC0034")]
		public HandPose()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class TouchController : MonoBehaviour
	{
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private OVRInput.Controller m_controller;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator m_animator;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_restoreOnInputAcquired;

		[Token(Token = "0x6000590")]
		[Address(RVA = "0xDC003C", Offset = "0xDC003C", VA = "0xDC003C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xDC0308", Offset = "0xDC0308", VA = "0xDC0308")]
		private void OnInputFocusLost()
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0xDC0358", Offset = "0xDC0358", VA = "0xDC0358")]
		private void OnInputFocusAcquired()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xDC0390", Offset = "0xDC0390", VA = "0xDC0390")]
		public TouchController()
		{
		}
	}
}
namespace SpaceNavigatorDriver
{
	[Token(Token = "0x20000F5")]
	public static class QuaternionExtensions
	{
		[Token(Token = "0x6000594")]
		[Address(RVA = "0xDC0398", Offset = "0xDC0398", VA = "0xDC0398")]
		public static Quaternion Inverse(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xDC03A0", Offset = "0xDC03A0", VA = "0xDC03A0")]
		public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0xDC0404", Offset = "0xDC0404", VA = "0xDC0404")]
		public static Quaternion RotateInSpecifiedCoordinateSystem(Quaternion rotation, Transform referenceCoordSys)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xDC0538", Offset = "0xDC0538", VA = "0xDC0538")]
		public static float Pitch(this Quaternion q)
		{
			return default(float);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0xDC0568", Offset = "0xDC0568", VA = "0xDC0568")]
		public static float Yaw(this Quaternion q)
		{
			return default(float);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0xDC0580", Offset = "0xDC0580", VA = "0xDC0580")]
		public static float Roll(this Quaternion q)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x20000F6")]
	public class Locks
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool X;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool Y;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool Z;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool All;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x600059A")]
		[Address(RVA = "0xDC05B0", Offset = "0xDC05B0", VA = "0xDC05B0")]
		public Locks(string name)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0xDC05D8", Offset = "0xDC05D8", VA = "0xDC05D8")]
		public void Write()
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0xDC06F4", Offset = "0xDC06F4", VA = "0xDC06F4")]
		public void Read()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public enum OperationMode
	{
		[Token(Token = "0x400059B")]
		Fly,
		[Token(Token = "0x400059C")]
		Orbit,
		[Token(Token = "0x400059D")]
		Telekinesis,
		[Token(Token = "0x400059E")]
		GrabMove
	}
	[Token(Token = "0x20000F8")]
	public enum CoordinateSystem
	{
		[Token(Token = "0x40005A0")]
		Camera,
		[Token(Token = "0x40005A1")]
		World,
		[Token(Token = "0x40005A2")]
		Parent,
		[Token(Token = "0x40005A3")]
		Local
	}
	[Token(Token = "0x20000F9")]
	public enum Axis
	{
		[Token(Token = "0x40005A5")]
		X,
		[Token(Token = "0x40005A6")]
		Y,
		[Token(Token = "0x40005A7")]
		Z
	}
	[Token(Token = "0x20000FA")]
	public enum DoF
	{
		[Token(Token = "0x40005A9")]
		Translation,
		[Token(Token = "0x40005AA")]
		Rotation
	}
	[Serializable]
	[Token(Token = "0x20000FB")]
	public static class Settings
	{
		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		public static OperationMode Mode;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		public static CoordinateSystem CoordSys;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool SnapRotation;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static int SnapAngle;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static bool SnapTranslation;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static float SnapDistance;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static bool LockHorizon;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		public static Locks NavTranslationLock;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		public static Locks NavRotationLock;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public static Locks ManipulateTranslationLock;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public static Locks ManipulateRotationLock;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static int Gears;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int CurrentGear;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static List<float> TransSensDefault;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static List<float> TransSensMinDefault;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static List<float> TransSensMaxDefault;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static float PlayTransSens;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static List<float> TransSens;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static List<float> TransSensMin;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static List<float> TransSensMax;

		[Token(Token = "0x40005BF")]
		public const float RotSensDefault = 1f;

		[Token(Token = "0x40005C0")]
		public const float RotSensMinDefault = 0f;

		[Token(Token = "0x40005C1")]
		public const float RotSensMaxDefault = 5f;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static float PlayRotSens;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public static float RotSens;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static float RotSensMin;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public static float RotSensMax;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public static bool RuntimeEditorNav;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public static Vector3 FlyInvertTranslation;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public static Vector3 FlyInvertRotation;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public static Vector3 OrbitInvertTranslation;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public static Vector3 OrbitInvertRotation;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public static Vector3 TelekinesisInvertTranslation;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public static Vector3 TelekinesisInvertRotation;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public static Vector3 GrabMoveInvertTranslation;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public static Vector3 GrabMoveInvertRotation;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private static Vector2 _scrollPos;

		[Token(Token = "0x600059D")]
		[Address(RVA = "0xDC0844", Offset = "0xDC0844", VA = "0xDC0844")]
		static Settings()
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0xDC0ECC", Offset = "0xDC0ECC", VA = "0xDC0ECC")]
		public static void OnGUI()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0xDC0ED0", Offset = "0xDC0ED0", VA = "0xDC0ED0")]
		public static void Write()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0xDC15C0", Offset = "0xDC15C0", VA = "0xDC15C0")]
		public static void Read()
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0xDC1414", Offset = "0xDC1414", VA = "0xDC1414")]
		private static void WriteAxisInversions(Vector3 translation, Vector3 rotation, string baseName)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0xDC1B84", Offset = "0xDC1B84", VA = "0xDC1B84")]
		private static void ReadAxisInversions(ref Vector3 translation, ref Vector3 rotation, string baseName)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0xDC1D28", Offset = "0xDC1D28", VA = "0xDC1D28")]
		public static bool GetLock(DoF doF, Axis axis)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FC")]
	public abstract class SpaceNavigator : IDisposable
	{
		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SpaceNavigator _instance;

		[Token(Token = "0x170000DD")]
		public static Vector3 Translation
		{
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0xDC1F10", Offset = "0xDC1F10", VA = "0xDC1F10")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000DE")]
		public static Quaternion Rotation
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0xDC1FB0", Offset = "0xDC1FB0", VA = "0xDC1FB0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x170000DF")]
		public static SpaceNavigator Instance
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0xDC1F68", Offset = "0xDC1F68", VA = "0xDC1F68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0xDC2208", Offset = "0xDC2208", VA = "0xDC2208")]
			set
			{
			}
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0xDC2008", Offset = "0xDC2008", VA = "0xDC2008")]
		public static Quaternion RotationInLocalCoordSys(Transform coordSys)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0xDC2140", Offset = "0xDC2140", VA = "0xDC2140")]
		public static void SetTranslationSensitivity(float newPlayTransSens)
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0xDC21A4", Offset = "0xDC21A4", VA = "0xDC21A4")]
		public static void SetRotationSensitivity(float newPlayRotSens)
		{
		}

		[Token(Token = "0x60005A9")]
		public abstract Vector3 GetTranslation();

		[Token(Token = "0x60005AA")]
		public abstract Quaternion GetRotation();

		[Token(Token = "0x60005AD")]
		public abstract void Dispose();

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xDC2254", Offset = "0xDC2254", VA = "0xDC2254")]
		protected SpaceNavigator()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x20000FD")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0xDC225C", Offset = "0xDC225C", VA = "0xDC225C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xDC24B8", Offset = "0xDC24B8", VA = "0xDC24B8")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xDC2634", Offset = "0xDC2634", VA = "0xDC2634")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xDC26A4", Offset = "0xDC26A4", VA = "0xDC26A4", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0xDC2770", Offset = "0xDC2770", VA = "0xDC2770", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xDC27D4", Offset = "0xDC27D4", VA = "0xDC27D4")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0xDC2838", Offset = "0xDC2838", VA = "0xDC2838")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xDC283C", Offset = "0xDC283C", VA = "0xDC283C")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xDC2904", Offset = "0xDC2904", VA = "0xDC2904")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xDC29CC", Offset = "0xDC29CC", VA = "0xDC29CC")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0xDC2A94", Offset = "0xDC2A94", VA = "0xDC2A94")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xDC2B5C", Offset = "0xDC2B5C", VA = "0xDC2B5C")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0xDC2C24", Offset = "0xDC2C24", VA = "0xDC2C24")]
		public void Update()
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xDC2C28", Offset = "0xDC2C28", VA = "0xDC2C28")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000100")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40005DC")]
			Hardware,
			[Token(Token = "0x40005DD")]
			Touch
		}

		[Token(Token = "0x2000101")]
		public class VirtualAxis
		{
			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x170000E1")]
			public string name
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0xDC3444", Offset = "0xDC3444", VA = "0xDC3444")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005D7")]
				[Address(RVA = "0xDC344C", Offset = "0xDC344C", VA = "0xDC344C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0xDC3454", Offset = "0xDC3454", VA = "0xDC3454")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0xDC345C", Offset = "0xDC345C", VA = "0xDC345C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E3")]
			public float GetValue
			{
				[Token(Token = "0x60005DE")]
				[Address(RVA = "0xDC34A4", Offset = "0xDC34A4", VA = "0xDC34A4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000E4")]
			public float GetValueRaw
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0xDC34AC", Offset = "0xDC34AC", VA = "0xDC34AC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005DA")]
			[Address(RVA = "0xDC23B0", Offset = "0xDC23B0", VA = "0xDC23B0")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x60005DB")]
			[Address(RVA = "0xDC3468", Offset = "0xDC3468", VA = "0xDC3468")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0xDC264C", Offset = "0xDC264C", VA = "0xDC264C")]
			public void Remove()
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xDC349C", Offset = "0xDC349C", VA = "0xDC349C")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x2000102")]
		public class VirtualButton
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x170000E5")]
			public string name
			{
				[Token(Token = "0x60005E0")]
				[Address(RVA = "0xDC34B4", Offset = "0xDC34B4", VA = "0xDC34B4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0xDC34BC", Offset = "0xDC34BC", VA = "0xDC34BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E6")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0xDC34C4", Offset = "0xDC34C4", VA = "0xDC34C4")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0xDC34CC", Offset = "0xDC34CC", VA = "0xDC34CC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E7")]
			public bool GetButton
			{
				[Token(Token = "0x60005E9")]
				[Address(RVA = "0xDC35F0", Offset = "0xDC35F0", VA = "0xDC35F0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E8")]
			public bool GetButtonDown
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0xDC35F8", Offset = "0xDC35F8", VA = "0xDC35F8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000E9")]
			public bool GetButtonUp
			{
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0xDC361C", Offset = "0xDC361C", VA = "0xDC361C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0xDC34D8", Offset = "0xDC34D8", VA = "0xDC34D8")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0xDC3510", Offset = "0xDC3510", VA = "0xDC3510")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0xDC354C", Offset = "0xDC354C", VA = "0xDC354C")]
			public void Pressed()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0xDC3578", Offset = "0xDC3578", VA = "0xDC3578")]
			public void Released()
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0xDC3598", Offset = "0xDC3598", VA = "0xDC3598")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x170000E0")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0xDC327C", Offset = "0xDC327C", VA = "0xDC327C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xDC2C30", Offset = "0xDC2C30", VA = "0xDC2C30")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xDC2CE8", Offset = "0xDC2CE8", VA = "0xDC2CE8")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0xDC2344", Offset = "0xDC2344", VA = "0xDC2344")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xDC2D78", Offset = "0xDC2D78", VA = "0xDC2D78")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0xDC23E0", Offset = "0xDC23E0", VA = "0xDC23E0")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xDC2DE4", Offset = "0xDC2DE4", VA = "0xDC2DE4")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xDC2E50", Offset = "0xDC2E50", VA = "0xDC2E50")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xDC2F0C", Offset = "0xDC2F0C", VA = "0xDC2F0C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0xDC244C", Offset = "0xDC244C", VA = "0xDC244C")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xDC2F78", Offset = "0xDC2F78", VA = "0xDC2F78")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0xDC3050", Offset = "0xDC3050", VA = "0xDC3050")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xDC2FD0", Offset = "0xDC2FD0", VA = "0xDC2FD0")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xDC30A8", Offset = "0xDC30A8", VA = "0xDC30A8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xDC3118", Offset = "0xDC3118", VA = "0xDC3118")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0xDC3188", Offset = "0xDC3188", VA = "0xDC3188")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xDC2894", Offset = "0xDC2894", VA = "0xDC2894")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0xDC295C", Offset = "0xDC295C", VA = "0xDC295C")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xDC2A24", Offset = "0xDC2A24", VA = "0xDC2A24")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xDC2BB4", Offset = "0xDC2BB4", VA = "0xDC2BB4")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xDC2AEC", Offset = "0xDC2AEC", VA = "0xDC2AEC")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0xDC31F8", Offset = "0xDC31F8", VA = "0xDC31F8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0xDC32E8", Offset = "0xDC32E8", VA = "0xDC32E8")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xDC335C", Offset = "0xDC335C", VA = "0xDC335C")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xDC33D0", Offset = "0xDC33D0", VA = "0xDC33D0")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0xDC3640", Offset = "0xDC3640", VA = "0xDC3640")]
		private void Update()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0xDC3644", Offset = "0xDC3644", VA = "0xDC3644")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0xDC36B4", Offset = "0xDC36B4", VA = "0xDC36B4")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x2000105")]
		public enum AxisOption
		{
			[Token(Token = "0x40005F1")]
			Both,
			[Token(Token = "0x40005F2")]
			OnlyHorizontal,
			[Token(Token = "0x40005F3")]
			OnlyVertical
		}

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0xDC36BC", Offset = "0xDC36BC", VA = "0xDC36BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xDC37E4", Offset = "0xDC37E4", VA = "0xDC37E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xDC3814", Offset = "0xDC3814", VA = "0xDC3814")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xDC36C0", Offset = "0xDC36C0", VA = "0xDC36C0")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0xDC3874", Offset = "0xDC3874", VA = "0xDC3874", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xDC39C0", Offset = "0xDC39C0", VA = "0xDC39C0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0xDC39FC", Offset = "0xDC39FC", VA = "0xDC39FC", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xDC3A00", Offset = "0xDC3A00", VA = "0xDC3A00")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xDC3A40", Offset = "0xDC3A40", VA = "0xDC3A40")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x2000106")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xDC3ABC", Offset = "0xDC3ABC", VA = "0xDC3ABC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0xDC3ACC", Offset = "0xDC3ACC", VA = "0xDC3ACC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xDC3AC4", Offset = "0xDC3AC4", VA = "0xDC3AC4")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0xDC3BD4", Offset = "0xDC3BD4", VA = "0xDC3BD4")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xDC3ECC", Offset = "0xDC3ECC", VA = "0xDC3ECC")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000108")]
		public enum AxisOption
		{
			[Token(Token = "0x4000607")]
			Both,
			[Token(Token = "0x4000608")]
			OnlyHorizontal,
			[Token(Token = "0x4000609")]
			OnlyVertical
		}

		[Token(Token = "0x2000109")]
		public enum ControlStyle
		{
			[Token(Token = "0x400060B")]
			Absolute,
			[Token(Token = "0x400060C")]
			Relative,
			[Token(Token = "0x400060D")]
			Swipe
		}

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xDC3ED4", Offset = "0xDC3ED4", VA = "0xDC3ED4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xDC3FFC", Offset = "0xDC3FFC", VA = "0xDC3FFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0xDC3ED8", Offset = "0xDC3ED8", VA = "0xDC3ED8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xDC4070", Offset = "0xDC4070", VA = "0xDC4070")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0xDC4170", Offset = "0xDC4170", VA = "0xDC4170", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xDC41A8", Offset = "0xDC41A8", VA = "0xDC41A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xDC4380", Offset = "0xDC4380", VA = "0xDC4380", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xDC43E0", Offset = "0xDC43E0", VA = "0xDC43E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0xDC44A0", Offset = "0xDC44A0", VA = "0xDC44A0")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x170000EA")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0xDC4524", Offset = "0xDC4524", VA = "0xDC4524")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xDC4530", Offset = "0xDC4530", VA = "0xDC4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xDC453C", Offset = "0xDC453C", VA = "0xDC453C")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xDC4594", Offset = "0xDC4594", VA = "0xDC4594")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xDC45EC", Offset = "0xDC45EC", VA = "0xDC45EC")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0xDC4774", Offset = "0xDC4774", VA = "0xDC4774")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xDC48FC", Offset = "0xDC48FC", VA = "0xDC48FC")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0xDC498C", Offset = "0xDC498C", VA = "0xDC498C")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xDC4A1C", Offset = "0xDC4A1C", VA = "0xDC4A1C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xDC4AB0", Offset = "0xDC4AB0", VA = "0xDC4AB0")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xDC4AB8", Offset = "0xDC4AB8", VA = "0xDC4AB8")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0xDC4AC0", Offset = "0xDC4AC0", VA = "0xDC4AC0")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000612")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000613")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000614")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000615")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000616")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x6000617")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x6000618")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x6000619")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600061A")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600061B")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600061C")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x600061D")]
		[Address(RVA = "0xDC4AC8", Offset = "0xDC4AC8", VA = "0xDC4AC8")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x200010B")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x600061E")]
		[Address(RVA = "0xDC4BCC", Offset = "0xDC4BCC", VA = "0xDC4BCC")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xDC4C58", Offset = "0xDC4C58", VA = "0xDC4C58")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xDC4CE4", Offset = "0xDC4CE4", VA = "0xDC4CE4", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xDC4D7C", Offset = "0xDC4D7C", VA = "0xDC4D7C", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xDC4E14", Offset = "0xDC4E14", VA = "0xDC4E14", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0xDC4EAC", Offset = "0xDC4EAC", VA = "0xDC4EAC", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xDC4F48", Offset = "0xDC4F48", VA = "0xDC4F48", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0xDC4FE4", Offset = "0xDC4FE4", VA = "0xDC4FE4", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xDC507C", Offset = "0xDC507C", VA = "0xDC507C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xDC5120", Offset = "0xDC5120", VA = "0xDC5120", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xDC51B8", Offset = "0xDC51B8", VA = "0xDC51B8", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0xDC5250", Offset = "0xDC5250", VA = "0xDC5250", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xDC52E8", Offset = "0xDC52E8", VA = "0xDC52E8", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0xDC52F4", Offset = "0xDC52F4", VA = "0xDC52F4")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600062C")]
		[Address(RVA = "0xDC52F8", Offset = "0xDC52F8", VA = "0xDC52F8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0xDC530C", Offset = "0xDC530C", VA = "0xDC530C", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0xDC5318", Offset = "0xDC5318", VA = "0xDC5318", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0xDC5324", Offset = "0xDC5324", VA = "0xDC5324", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0xDC5330", Offset = "0xDC5330", VA = "0xDC5330", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xDC5380", Offset = "0xDC5380", VA = "0xDC5380", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xDC53D0", Offset = "0xDC53D0", VA = "0xDC53D0", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xDC5420", Offset = "0xDC5420", VA = "0xDC5420", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0xDC5470", Offset = "0xDC5470", VA = "0xDC5470", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xDC54C0", Offset = "0xDC54C0", VA = "0xDC54C0", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0xDC5510", Offset = "0xDC5510", VA = "0xDC5510", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xDC5518", Offset = "0xDC5518", VA = "0xDC5518")]
		public StandaloneInput()
		{
		}
	}
}
namespace ExitGames.Demos.DemoPunVoice
{
	[Token(Token = "0x200010D")]
	[RequireComponent(typeof(PhotonView))]
	[RequireComponent(typeof(Animator))]
	[RequireComponent(typeof(Rigidbody))]
	public abstract class BaseController : MonoBehaviour
	{
		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera ControllerCamera;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Rigidbody rigidBody;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Animator animator;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform camTrans;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float h;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float v;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected float speed;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float cameraDistance;

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xDC551C", Offset = "0xDC551C", VA = "0xDC551C", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xDC5714", Offset = "0xDC5714", VA = "0xDC5714", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0xDC5838", Offset = "0xDC5838", VA = "0xDC5838", Slot = "6")]
		protected virtual void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xDC58E0", Offset = "0xDC58E0", VA = "0xDC58E0", Slot = "7")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0xDC5974", Offset = "0xDC5974", VA = "0xDC5974", Slot = "8")]
		protected virtual void Init()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xDC59F0", Offset = "0xDC59F0", VA = "0xDC59F0", Slot = "9")]
		protected virtual void SetCamera()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xDC5A88", Offset = "0xDC5A88", VA = "0xDC5A88", Slot = "10")]
		protected virtual void UpdateAnimator(float h, float v)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xDC5B00", Offset = "0xDC5B00", VA = "0xDC5B00", Slot = "11")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0xDC5BFC", Offset = "0xDC5BFC", VA = "0xDC5BFC", Slot = "12")]
		protected virtual void ShowCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xDC5C8C", Offset = "0xDC5C8C", VA = "0xDC5C8C", Slot = "13")]
		protected virtual void HideCamera(Camera camera)
		{
		}

		[Token(Token = "0x6000642")]
		protected abstract void Move(float h, float v);

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xDC5D1C", Offset = "0xDC5D1C", VA = "0xDC5D1C")]
		protected BaseController()
		{
		}
	}
	[Token(Token = "0x200010E")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(Toggle))]
	public class BetterToggle : MonoBehaviour
	{
		[Token(Token = "0x200010F")]
		public delegate void OnToggle(Toggle toggle);

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Toggle toggle;

		[Token(Token = "0x14000013")]
		public static event OnToggle ToggleValueChanged
		{
			[Token(Token = "0x6000644")]
			[Address(RVA = "0xDC5D2C", Offset = "0xDC5D2C", VA = "0xDC5D2C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000645")]
			[Address(RVA = "0xDC5DE4", Offset = "0xDC5DE4", VA = "0xDC5DE4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0xDC5E9C", Offset = "0xDC5E9C", VA = "0xDC5E9C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xDC5F64", Offset = "0xDC5F64", VA = "0xDC5F64")]
		public void OnToggleValueChanged()
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0xDC5FD0", Offset = "0xDC5FD0", VA = "0xDC5FD0")]
		public BetterToggle()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class ChangePOV : MonoBehaviour, IMatchmakingCallbacks
	{
		[Token(Token = "0x2000111")]
		public delegate void OnCameraChanged(Camera newCamera);

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FirstPersonController firstPersonController;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ThirdPersonController thirdPersonController;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OrthographicController orthographicController;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 initialCameraPosition;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion initialCameraRotation;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Camera defaultCamera;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject ButtonsHolder;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button FirstPersonCamActivator;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button ThirdPersonCamActivator;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button OrthographicCamActivator;

		[Token(Token = "0x14000014")]
		public static event OnCameraChanged CameraChanged
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xDC565C", Offset = "0xDC565C", VA = "0xDC565C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600064F")]
			[Address(RVA = "0xDC5780", Offset = "0xDC5780", VA = "0xDC5780")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xDC6148", Offset = "0xDC6148", VA = "0xDC6148")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xDC637C", Offset = "0xDC637C", VA = "0xDC637C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xDC64DC", Offset = "0xDC64DC", VA = "0xDC64DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xDC66EC", Offset = "0xDC66EC", VA = "0xDC66EC")]
		private void OnCharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0xDC67C4", Offset = "0xDC67C4", VA = "0xDC67C4")]
		private void FirstPersonMode()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xDC6948", Offset = "0xDC6948", VA = "0xDC6948")]
		private void ThirdPersonMode()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xDC6950", Offset = "0xDC6950", VA = "0xDC6950")]
		private void OrthographicMode()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xDC67CC", Offset = "0xDC67CC", VA = "0xDC67CC")]
		private void ToggleMode(BaseController controller)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0xDC6958", Offset = "0xDC6958", VA = "0xDC6958")]
		private void BroadcastChange(Camera camera)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xDC69FC", Offset = "0xDC69FC", VA = "0xDC69FC", Slot = "4")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0xDC6A00", Offset = "0xDC6A00", VA = "0xDC6A00", Slot = "5")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xDC6A04", Offset = "0xDC6A04", VA = "0xDC6A04", Slot = "6")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xDC6A08", Offset = "0xDC6A08", VA = "0xDC6A08", Slot = "7")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xDC6A0C", Offset = "0xDC6A0C", VA = "0xDC6A0C", Slot = "8")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0xDC6A10", Offset = "0xDC6A10", VA = "0xDC6A10", Slot = "9")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xDC6A14", Offset = "0xDC6A14", VA = "0xDC6A14", Slot = "10")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0xDC6B28", Offset = "0xDC6B28", VA = "0xDC6B28")]
		public ChangePOV()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class CharacterInstantiation : MonoBehaviourPunCallbacks, IOnEventCallback
	{
		[Token(Token = "0x2000113")]
		public enum SpawnSequence
		{
			[Token(Token = "0x4000636")]
			Connection,
			[Token(Token = "0x4000637")]
			Random,
			[Token(Token = "0x4000638")]
			RoundRobin
		}

		[Token(Token = "0x2000114")]
		public delegate void OnCharacterInstantiated(GameObject character);

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform SpawnPosition;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float PositionOffset;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject[] PrefabsToInstantiate;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Transform> SpawnPoints;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool AutoSpawn;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool UseRandomOffset;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public SpawnSequence Sequence;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private byte manualInstantiationEventCode;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected int lastUsedSpawnPointIndex;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool manualInstantiation;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool differentPrefabs;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string localPrefabSuffix;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string remotePrefabSuffix;

		[Token(Token = "0x14000015")]
		public static event OnCharacterInstantiated CharacterInstantiated
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0xDC62C4", Offset = "0xDC62C4", VA = "0xDC62C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xDC6424", Offset = "0xDC6424", VA = "0xDC6424")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0xDC6B70", Offset = "0xDC6B70", VA = "0xDC6B70", Slot = "41")]
		public override void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0xDC6D84", Offset = "0xDC6D84", VA = "0xDC6D84")]
		private void ManualInstantiation(int index, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0xDC7280", Offset = "0xDC7280", VA = "0xDC7280", Slot = "54")]
		public void OnEvent(EventData photonEvent)
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0xDC75E0", Offset = "0xDC75E0", VA = "0xDC75E0", Slot = "55")]
		protected virtual void GetSpawnPoint(out Vector3 spawnPos, out Quaternion spawnRot)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0xDC77F8", Offset = "0xDC77F8", VA = "0xDC77F8", Slot = "56")]
		protected virtual Transform GetSpawnPoint()
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0xDC7918", Offset = "0xDC7918", VA = "0xDC7918")]
		public CharacterInstantiation()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class FirstPersonController : BaseController
	{
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private MouseLookHelper mouseLook;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float oldYRotation;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Quaternion velRotation;

		[Token(Token = "0x170000EB")]
		public Vector3 Velocity
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0xDC7980", Offset = "0xDC7980", VA = "0xDC7980")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0xDC799C", Offset = "0xDC799C", VA = "0xDC799C", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0xDC79E0", Offset = "0xDC79E0", VA = "0xDC79E0", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0xDC7A68", Offset = "0xDC7A68", VA = "0xDC7A68")]
		private void Update()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0xDC7A6C", Offset = "0xDC7A6C", VA = "0xDC7A6C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0xDC7B94", Offset = "0xDC7B94", VA = "0xDC7B94")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000116")]
	[RequireComponent(typeof(Canvas))]
	public class Highlighter : MonoBehaviour
	{
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Canvas canvas;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PhotonVoiceView photonVoiceView;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image recorderSprite;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image speakerSprite;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool showSpeakerLag;

		[Token(Token = "0x6000677")]
		[Address(RVA = "0xDC7C04", Offset = "0xDC7C04", VA = "0xDC7C04")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0xDC7E44", Offset = "0xDC7E44", VA = "0xDC7E44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0xDC7FC0", Offset = "0xDC7FC0", VA = "0xDC7FC0")]
		private void VoiceDemoUI_DebugToggled(bool debugMode)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0xDC7FCC", Offset = "0xDC7FCC", VA = "0xDC7FCC")]
		private void ChangePOV_CameraChanged(Camera camera)
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0xDC7FE8", Offset = "0xDC7FE8", VA = "0xDC7FE8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0xDC8100", Offset = "0xDC8100", VA = "0xDC8100")]
		private void Update()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0xDC8260", Offset = "0xDC8260", VA = "0xDC8260")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xDC8378", Offset = "0xDC8378", VA = "0xDC8378")]
		public Highlighter()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class OrthographicController : ThirdPersonController
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float smoothing;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 offset;

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xDC8380", Offset = "0xDC8380", VA = "0xDC8380", Slot = "8")]
		protected override void Init()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xDC83A0", Offset = "0xDC83A0", VA = "0xDC83A0", Slot = "9")]
		protected override void SetCamera()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0xDC8410", Offset = "0xDC8410", VA = "0xDC8410", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xDC85A4", Offset = "0xDC85A4", VA = "0xDC85A4")]
		private void CameraFollow()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0xDC8678", Offset = "0xDC8678", VA = "0xDC8678")]
		public OrthographicController()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class ThirdPersonController : BaseController
	{
		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float movingTurnSpeed;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xDC8428", Offset = "0xDC8428", VA = "0xDC8428", Slot = "14")]
		protected override void Move(float h, float v)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xDC8694", Offset = "0xDC8694", VA = "0xDC8694")]
		public ThirdPersonController()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class VoiceDemoUI : MonoBehaviour
	{
		[Token(Token = "0x200011A")]
		public delegate void OnDebugToggle(bool debugMode);

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text punState;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text voiceState;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PhotonVoiceNetwork punVoiceNetwork;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Canvas canvas;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button punSwitch;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text punSwitchText;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button voiceSwitch;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text voiceSwitchText;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button calibrateButton;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Text calibrateText;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text voiceDebugText;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Recorder recorder;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject inGameSettings;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject globalSettings;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text devicesInfoText;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GameObject debugGO;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool debugMode;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float volumeBeforeMute;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private DebugLevel previousDebugLevel;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private int calibrationMilliSeconds;

		[Token(Token = "0x170000EC")]
		public bool DebugMode
		{
			[Token(Token = "0x6000686")]
			[Address(RVA = "0xDC86AC", Offset = "0xDC86AC", VA = "0xDC86AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xDC86B4", Offset = "0xDC86B4", VA = "0xDC86B4")]
			set
			{
			}
		}

		[Token(Token = "0x14000016")]
		public static event OnDebugToggle DebugToggled
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0xDC7D8C", Offset = "0xDC7D8C", VA = "0xDC7D8C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xDC7F08", Offset = "0xDC7F08", VA = "0xDC7F08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xDC87E4", Offset = "0xDC87E4", VA = "0xDC87E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xDC8840", Offset = "0xDC8840", VA = "0xDC8840")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xDC8A44", Offset = "0xDC8A44", VA = "0xDC8A44")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0xDC8C48", Offset = "0xDC8C48", VA = "0xDC8C48")]
		private void CharacterInstantiation_CharacterInstantiated(GameObject character)
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xDC8CF4", Offset = "0xDC8CF4", VA = "0xDC8CF4")]
		private void InitToggles(Toggle[] toggles)
		{
		}

		[Token(Token = "0x600068F")]
		[Address(RVA = "0xDC9074", Offset = "0xDC9074", VA = "0xDC9074")]
		private void BetterToggle_ToggleValueChanged(Toggle toggle)
		{
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xDC93C8", Offset = "0xDC93C8", VA = "0xDC93C8")]
		private void OnCameraChanged(Camera newCamera)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xDC93E4", Offset = "0xDC93E4", VA = "0xDC93E4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xDC9984", Offset = "0xDC9984", VA = "0xDC9984")]
		private void PunSwitchOnClick()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0xDC9A54", Offset = "0xDC9A54", VA = "0xDC9A54")]
		private void VoiceSwitchOnClick()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xDC9AD4", Offset = "0xDC9AD4", VA = "0xDC9AD4")]
		private void CalibrateButtonOnClick()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0xDC9B70", Offset = "0xDC9B70", VA = "0xDC9B70")]
		private void Update()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xDC9D80", Offset = "0xDC9D80", VA = "0xDC9D80")]
		private void PunClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xDCA348", Offset = "0xDCA348", VA = "0xDCA348")]
		private void VoiceClientStateChanged(ClientState fromState, ClientState toState)
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xDC9F14", Offset = "0xDC9F14", VA = "0xDC9F14")]
		private void UpdateUiBasedOnVoiceState(ClientState voiceClientState)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0xDCA350", Offset = "0xDCA350", VA = "0xDCA350")]
		public VoiceDemoUI()
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos
{
	[Token(Token = "0x200011B")]
	public class BackgroundMusicController : MonoBehaviour
	{
		[Token(Token = "0x400065A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text volumeText;

		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Slider volumeSlider;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AudioSource audioSource;

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float initialVolume;

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xDCA40C", Offset = "0xDCA40C", VA = "0xDCA40C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0xDCA54C", Offset = "0xDCA54C", VA = "0xDCA54C")]
		private void OnVolumeChanged(float newValue)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xDCA618", Offset = "0xDCA618", VA = "0xDCA618")]
		public BackgroundMusicController()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class SidebarToggle : MonoBehaviour
	{
		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Button sidebarButton;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform panelsHolder;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float sidebarWidth;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool sidebarOpen;

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0xDCA628", Offset = "0xDCA628", VA = "0xDCA628")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xDCA6F8", Offset = "0xDCA6F8", VA = "0xDCA6F8")]
		[ContextMenu("ToggleSidebar")]
		private void ToggleSidebar()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xDCA6E0", Offset = "0xDCA6E0", VA = "0xDCA6E0")]
		private void ToggleSidebar(bool open)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xDCA75C", Offset = "0xDCA75C", VA = "0xDCA75C")]
		public SidebarToggle()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public static class UiExtensions
	{
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0xDCA710", Offset = "0xDCA710", VA = "0xDCA710")]
		public static void SetPosX(this RectTransform rectTransform, float x)
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xDCA774", Offset = "0xDCA774", VA = "0xDCA774")]
		public static void SetHeight(this RectTransform rectTransform, float h)
		{
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0xDCA78C", Offset = "0xDCA78C", VA = "0xDCA78C")]
		public static void SetValue(this Toggle toggle, bool isOn)
		{
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xDCA7A4", Offset = "0xDCA7A4", VA = "0xDCA7A4")]
		public static void SetValue(this Slider slider, float v)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xDCA7C4", Offset = "0xDCA7C4", VA = "0xDCA7C4")]
		public static void SetValue(this InputField inputField, string v)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xDCA7D8", Offset = "0xDCA7D8", VA = "0xDCA7D8")]
		public static void DestroyChildren(this Transform transform)
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0xDCA8E0", Offset = "0xDCA8E0", VA = "0xDCA8E0")]
		public static void Hide(this CanvasGroup canvasGroup, bool blockRaycasts = false, bool interactable = false)
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xDCA930", Offset = "0xDCA930", VA = "0xDCA930")]
		public static void Show(this CanvasGroup canvasGroup, bool blockRaycasts = true, bool interactable = true)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0xDCA980", Offset = "0xDCA980", VA = "0xDCA980")]
		public static bool IsHidden(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xDCA9A4", Offset = "0xDCA9A4", VA = "0xDCA9A4")]
		public static bool IsShown(this CanvasGroup canvasGroup)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xDCA9C8", Offset = "0xDCA9C8", VA = "0xDCA9C8")]
		public static void SetSingleOnClickCallback(this Button button, UnityAction action)
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xDCAA0C", Offset = "0xDCAA0C", VA = "0xDCAA0C")]
		public static void SetSingleOnValueChangedCallback(this Toggle toggle, UnityAction<bool> action)
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0xDCAA78", Offset = "0xDCAA78", VA = "0xDCAA78")]
		public static void SetSingleOnValueChangedCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xDCAAE4", Offset = "0xDCAAE4", VA = "0xDCAAE4")]
		public static void SetSingleOnEndEditCallback(this InputField inputField, UnityAction<string> action)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0xDCAB50", Offset = "0xDCAB50", VA = "0xDCAB50")]
		public static void SetSingleOnValueChangedCallback(this Dropdown inputField, UnityAction<int> action)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xDCA4E0", Offset = "0xDCA4E0", VA = "0xDCA4E0")]
		public static void SetSingleOnValueChangedCallback(this Slider slider, UnityAction<float> action)
		{
		}
	}
}
namespace Photon.Voice.Unity.Demos.DemoVoiceUI
{
	[Token(Token = "0x200011E")]
	public class CodecSettingsUI : MonoBehaviour
	{
		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Dropdown frameDurationDropdown;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown samplingRateDropdown;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private InputField bitrateInputField;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> frameDurationOptions;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly List<string> samplingRateOptions;

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xDCABBC", Offset = "0xDCABBC", VA = "0xDCABBC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xDCAEC0", Offset = "0xDCAEC0", VA = "0xDCAEC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0xDCAEE0", Offset = "0xDCAEE0", VA = "0xDCAEE0")]
		private void OnBitrateChanged(string newBitrateString)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xDCAF48", Offset = "0xDCAF48", VA = "0xDCAF48")]
		private void OnFrameDurationChanged(int index)
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0xDCAFA8", Offset = "0xDCAFA8", VA = "0xDCAFA8")]
		private void OnSamplingRateChanged(int index)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xDCAD7C", Offset = "0xDCAD7C", VA = "0xDCAD7C")]
		private void InitFrameDuration()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xDCAE08", Offset = "0xDCAE08", VA = "0xDCAE08")]
		private void InitSamplingRate()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xDCAE70", Offset = "0xDCAE70", VA = "0xDCAE70")]
		private void InitBitrate()
		{
		}

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0xDCB008", Offset = "0xDCB008", VA = "0xDCB008")]
		public CodecSettingsUI()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[RequireComponent(typeof(VoiceConnection), typeof(ConnectAndJoin))]
	public class DemoVoiceUI : MonoBehaviour, IInRoomCallbacks, IMatchmakingCallbacks
	{
		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text connectionStatusText;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text serverStatusText;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text roomStatusText;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text inputWarningText;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text rttText;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text rttVariationText;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text packetLossWarningText;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField localNicknameText;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle debugEchoToggle;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Toggle reliableTransmissionToggle;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Toggle encryptionToggle;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject webRtcDspGameObject;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle aecToggle;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Toggle aecHighPassToggle;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private InputField reverseStreamDelayInputField;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Toggle noiseSuppressionToggle;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Toggle agcToggle;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider agcCompressionGainSlider;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Toggle vadToggle;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Toggle muteToggle;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Toggle streamAudioClipToggle;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Toggle audioToneToggle;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Toggle dspToggle;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Toggle highPassToggle;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Toggle photonVadToggle;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject microphoneSetupGameObject;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private bool defaultTransmitEnabled;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private int screenWidth;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private int screenHeight;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool fullScreen;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private InputField roomNameInputField;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private InputField globalMinDelaySoftInputField;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InputField globalMaxDelaySoftInputField;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private InputField globalMaxDelayHardInputField;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private int rttYellowThreshold;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private int rttRedThreshold;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private int rttVariationYellowThreshold;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private int rttVariationRedThreshold;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private GameObject compressionGainGameObject;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Text compressionGainText;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private GameObject aecOptionsGameObject;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public Transform RemoteVoicesPanel;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private WebRtcAudioDsp voiceAudioPreprocessor;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ConnectAndJoin connectAndJoin;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private readonly Color warningColor;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private readonly Color okColor;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private readonly Color redColor;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private readonly Color defaultColor;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0xDCB55C", Offset = "0xDCB55C", VA = "0xDCB55C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xDCC234", Offset = "0xDCC234", VA = "0xDCC234", Slot = "16")]
		protected virtual void SetDefaults()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xDCC260", Offset = "0xDCC260", VA = "0xDCC260")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xDCC2FC", Offset = "0xDCC2FC", VA = "0xDCC2FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0xDCC198", Offset = "0xDCC198", VA = "0xDCC198")]
		private void GetSavedNickname()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xDCC398", Offset = "0xDCC398", VA = "0xDCC398", Slot = "17")]
		protected virtual void OnSpeakerCreated(Speaker speaker)
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0xDCC4BC", Offset = "0xDCC4BC", VA = "0xDCC4BC")]
		private void OnRemoteVoiceRemove(Speaker speaker)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xDCC560", Offset = "0xDCC560", VA = "0xDCC560")]
		private void ToggleMute(bool isOn)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xDCC7AC", Offset = "0xDCC7AC", VA = "0xDCC7AC", Slot = "18")]
		protected virtual void ToggleIsRecording(bool isRecording)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xDCC7DC", Offset = "0xDCC7DC", VA = "0xDCC7DC")]
		private void ToggleDebugEcho(bool isOn)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0xDCC80C", Offset = "0xDCC80C", VA = "0xDCC80C")]
		private void ToggleReliable(bool isOn)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xDCC83C", Offset = "0xDCC83C", VA = "0xDCC83C")]
		private void ToggleEncryption(bool isOn)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0xDCC86C", Offset = "0xDCC86C", VA = "0xDCC86C")]
		private void ToggleAEC(bool isOn)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xDCC8B0", Offset = "0xDCC8B0", VA = "0xDCC8B0")]
		private void ToggleNoiseSuppression(bool isOn)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0xDCC8D0", Offset = "0xDCC8D0", VA = "0xDCC8D0")]
		private void ToggleAGC(bool isOn)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0xDCC914", Offset = "0xDCC914", VA = "0xDCC914")]
		private void ToggleVAD(bool isOn)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0xDCC934", Offset = "0xDCC934", VA = "0xDCC934")]
		private void ToggleHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0xDCC954", Offset = "0xDCC954", VA = "0xDCC954")]
		private void ToggleDsp(bool isOn)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0xDCC9B4", Offset = "0xDCC9B4", VA = "0xDCC9B4")]
		private void ToggleAudioClipStreaming(bool isOn)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0xDCCAAC", Offset = "0xDCCAAC", VA = "0xDCCAAC")]
		private void ToggleAudioToneFactory(bool isOn)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0xDCCCA8", Offset = "0xDCCCA8", VA = "0xDCCCA8")]
		private void TogglePhotonVAD(bool isOn)
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0xDCCCD8", Offset = "0xDCCCD8", VA = "0xDCCCD8")]
		private void ToggleAecHighPass(bool isOn)
		{
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0xDCCCF8", Offset = "0xDCCCF8", VA = "0xDCCCF8")]
		private void OnAgcCompressionGainChanged(float agcCompressionGain)
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0xDCCDC8", Offset = "0xDCCDC8", VA = "0xDCCDC8")]
		private void OnGlobalPlaybackDelayMinSoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0xDCCE98", Offset = "0xDCCE98", VA = "0xDCCE98")]
		private void OnGlobalPlaybackDelayMaxSoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0xDCCF64", Offset = "0xDCCF64", VA = "0xDCCF64")]
		private void OnGlobalPlaybackDelayMaxHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0xDCD030", Offset = "0xDCD030", VA = "0xDCD030")]
		private void OnReverseStreamDelayChanged(string newReverseStreamString)
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0xDCD0BC", Offset = "0xDCD0BC", VA = "0xDCD0BC")]
		private void UpdateSyncedNickname(string nickname)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0xDCD164", Offset = "0xDCD164", VA = "0xDCD164")]
		private void JoinOrCreateRoom(string roomName)
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0xDCD280", Offset = "0xDCD280", VA = "0xDCD280", Slot = "19")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0xDCD80C", Offset = "0xDCD80C", VA = "0xDCD80C")]
		private void SetTextColor(int textValue, Text text, int yellowThreshold, int redThreshold)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0xDCD7D4", Offset = "0xDCD7D4", VA = "0xDCD7D4")]
		private void ResetTextColor(Text text)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0xDCB6C8", Offset = "0xDCB6C8", VA = "0xDCB6C8")]
		private void InitUiCallbacks()
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0xDCBCFC", Offset = "0xDCBCFC", VA = "0xDCBCFC")]
		private void InitUiValues()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0xDCD954", Offset = "0xDCD954", VA = "0xDCD954")]
		private void SetRoomDebugText()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0xDCDC64", Offset = "0xDCDC64", VA = "0xDCDC64", Slot = "20")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0xDCDCD8", Offset = "0xDCDCD8", VA = "0xDCDCD8", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0xDCDCDC", Offset = "0xDCDCDC", VA = "0xDCDCDC", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xDCDCE0", Offset = "0xDCDCE0", VA = "0xDCDCE0", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xDCDCE4", Offset = "0xDCDCE4", VA = "0xDCDCE4", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xDCDCF4", Offset = "0xDCDCF4", VA = "0xDCDCF4", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0xDCDCF8", Offset = "0xDCDCF8", VA = "0xDCDCF8", Slot = "9")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xDCDCFC", Offset = "0xDCDCFC", VA = "0xDCDCFC", Slot = "10")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreatedRoom()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0xDCDD00", Offset = "0xDCDD00", VA = "0xDCDD00", Slot = "11")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xDCDD04", Offset = "0xDCDD04", VA = "0xDCDD04", Slot = "12")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinedRoom()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xDCDD08", Offset = "0xDCDD08", VA = "0xDCDD08", Slot = "13")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xDCDD0C", Offset = "0xDCDD0C", VA = "0xDCDD0C", Slot = "14")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0xDCDD10", Offset = "0xDCDD10", VA = "0xDCDD10", Slot = "15")]
		private void Photon.Realtime.IMatchmakingCallbacks.OnLeftRoom()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xDCDD84", Offset = "0xDCDD84", VA = "0xDCDD84")]
		public DemoVoiceUI()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public struct MicRef
	{
		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Recorder.MicType MicType;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Name;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int PhotonId;

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xDCDEC8", Offset = "0xDCDEC8", VA = "0xDCDEC8")]
		public MicRef(string name, int id)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0xDCDEDC", Offset = "0xDCDEDC", VA = "0xDCDEDC")]
		public MicRef(string name)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xDCDEF0", Offset = "0xDCDEF0", VA = "0xDCDEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000122")]
	public class MicrophoneDropdownFiller : MonoBehaviour
	{
		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<MicRef> micOptions;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Dropdown micDropdown;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Recorder recorder;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[FormerlySerializedAs("RefreshButton")]
		private GameObject refreshButton;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[FormerlySerializedAs("ToggleButton")]
		private GameObject toggleButton;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Toggle photonToggle;

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0xDCDF3C", Offset = "0xDCDF3C", VA = "0xDCDF3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xDCDFB8", Offset = "0xDCDFB8", VA = "0xDCDFB8")]
		private void SetupMicDropdown()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xDCE2C0", Offset = "0xDCE2C0", VA = "0xDCE2C0")]
		private void MicDropdownValueChanged(MicRef mic)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xDCE354", Offset = "0xDCE354", VA = "0xDCE354")]
		private void SetCurrentValue()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xDCE6F0", Offset = "0xDCE6F0", VA = "0xDCE6F0")]
		public void PhotonMicToggled(bool on)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xDCDFA0", Offset = "0xDCDFA0", VA = "0xDCDFA0")]
		public void RefreshMicrophones()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xDCE784", Offset = "0xDCE784", VA = "0xDCE784")]
		private void PhotonVoiceCreated()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xDCE79C", Offset = "0xDCE79C", VA = "0xDCE79C")]
		public MicrophoneDropdownFiller()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public static class PhotonDemoExtensions
	{
		[Token(Token = "0x40006A4")]
		internal const string IS_MUTED_PROPERTY_KEY = "mute";

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xDCC5C8", Offset = "0xDCC5C8", VA = "0xDCC5C8")]
		public static bool Mute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xDCC6BC", Offset = "0xDCC6BC", VA = "0xDCC6BC")]
		public static bool Unmute(this Player player)
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xDCD888", Offset = "0xDCD888", VA = "0xDCD888")]
		public static bool IsMuted(this Player player)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000124")]
	[RequireComponent(typeof(Speaker))]
	public class RemoteSpeakerUI : MonoBehaviour, IInRoomCallbacks
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text nameText;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected Image remoteIsMuting;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image remoteIsTalking;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField minDelaySoftInputField;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private InputField maxDelaySoftInputField;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField maxDelayHardInputField;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text bufferLagText;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Speaker speaker;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected VoiceConnection voiceConnection;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xDCE82C", Offset = "0xDCE82C", VA = "0xDCE82C", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xDCEB38", Offset = "0xDCEB38", VA = "0xDCEB38")]
		private void OnMinDelaySoftChanged(string newMinDelaySoftString)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xDCEC08", Offset = "0xDCEC08", VA = "0xDCEC08")]
		private void OnMaxDelaySoftChanged(string newMaxDelaySoftString)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xDCECD4", Offset = "0xDCECD4", VA = "0xDCECD4")]
		private void OnMaxDelayHardChanged(string newMaxDelayHardString)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xDCEDA0", Offset = "0xDCEDA0", VA = "0xDCEDA0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xDCEE80", Offset = "0xDCEE80", VA = "0xDCEE80")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xDCEA20", Offset = "0xDCEA20", VA = "0xDCEA20")]
		private void SetNickname()
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0xDCEB04", Offset = "0xDCEB04", VA = "0xDCEB04")]
		private void SetMutedState()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xDCEEB0", Offset = "0xDCEEB0", VA = "0xDCEEB0", Slot = "10")]
		protected virtual void SetMutedState(bool isMuted)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0xDCEED0", Offset = "0xDCEED0", VA = "0xDCEED0", Slot = "11")]
		protected virtual void OnActorPropertiesChanged(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xDCEF1C", Offset = "0xDCEF1C", VA = "0xDCEF1C", Slot = "12")]
		public virtual void Init(VoiceConnection vC)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xDCEF50", Offset = "0xDCEF50", VA = "0xDCEF50", Slot = "4")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerEnteredRoom(Player newPlayer)
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xDCEF54", Offset = "0xDCEF54", VA = "0xDCEF54", Slot = "5")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerLeftRoom(Player otherPlayer)
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0xDCEF58", Offset = "0xDCEF58", VA = "0xDCEF58", Slot = "6")]
		private void Photon.Realtime.IInRoomCallbacks.OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xDCEF5C", Offset = "0xDCEF5C", VA = "0xDCEF5C", Slot = "7")]
		private void Photon.Realtime.IInRoomCallbacks.OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0xDCEF68", Offset = "0xDCEF68", VA = "0xDCEF68", Slot = "8")]
		private void Photon.Realtime.IInRoomCallbacks.OnMasterClientSwitched(Player newMasterClient)
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0xDCEF6C", Offset = "0xDCEF6C", VA = "0xDCEF6C")]
		public RemoteSpeakerUI()
		{
		}
	}
}
namespace Photon.Realtime.Demo
{
	[Token(Token = "0x2000125")]
	public class ConnectAndJoinRandomLb : MonoBehaviour, IConnectionCallbacks, IMatchmakingCallbacks, ILobbyCallbacks
	{
		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AppSettings appSettings;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LoadBalancingClient lbc;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ConnectionHandler ch;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Text StateUiText;

		[Token(Token = "0x6000713")]
		[Address(RVA = "0xDCEF74", Offset = "0xDCEF74", VA = "0xDCEF74")]
		public void Start()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0xDCF0E8", Offset = "0xDCF0E8", VA = "0xDCF0E8")]
		public void Update()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0xDCF21C", Offset = "0xDCF21C", VA = "0xDCF21C", Slot = "4")]
		public void OnConnected()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0xDCF220", Offset = "0xDCF220", VA = "0xDCF220", Slot = "5")]
		public void OnConnectedToMaster()
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0xDCF2A4", Offset = "0xDCF2A4", VA = "0xDCF2A4", Slot = "6")]
		public void OnDisconnected(DisconnectCause cause)
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0xDCF390", Offset = "0xDCF390", VA = "0xDCF390", Slot = "8")]
		public void OnCustomAuthenticationResponse(Dictionary<string, object> data)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0xDCF394", Offset = "0xDCF394", VA = "0xDCF394", Slot = "9")]
		public void OnCustomAuthenticationFailed(string debugMessage)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0xDCF398", Offset = "0xDCF398", VA = "0xDCF398", Slot = "7")]
		public void OnRegionListReceived(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0xDCF474", Offset = "0xDCF474", VA = "0xDCF474", Slot = "19")]
		public void OnRoomListUpdate(List<RoomInfo> roomList)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0xDCF478", Offset = "0xDCF478", VA = "0xDCF478", Slot = "20")]
		public void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0xDCF47C", Offset = "0xDCF47C", VA = "0xDCF47C", Slot = "17")]
		public void OnJoinedLobby()
		{
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0xDCF480", Offset = "0xDCF480", VA = "0xDCF480", Slot = "18")]
		public void OnLeftLobby()
		{
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0xDCF484", Offset = "0xDCF484", VA = "0xDCF484", Slot = "10")]
		public void OnFriendListUpdate(List<FriendInfo> friendList)
		{
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0xDCF488", Offset = "0xDCF488", VA = "0xDCF488", Slot = "11")]
		public void OnCreatedRoom()
		{
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0xDCF48C", Offset = "0xDCF48C", VA = "0xDCF48C", Slot = "12")]
		public void OnCreateRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0xDCF490", Offset = "0xDCF490", VA = "0xDCF490", Slot = "13")]
		public void OnJoinedRoom()
		{
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0xDCF4F8", Offset = "0xDCF4F8", VA = "0xDCF4F8", Slot = "14")]
		public void OnJoinRoomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0xDCF4FC", Offset = "0xDCF4FC", VA = "0xDCF4FC", Slot = "15")]
		public void OnJoinRandomFailed(short returnCode, string message)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0xDCF5B0", Offset = "0xDCF5B0", VA = "0xDCF5B0", Slot = "16")]
		public void OnLeftRoom()
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0xDCF5B4", Offset = "0xDCF5B4", VA = "0xDCF5B4")]
		private void OnRegionPingCompleted(RegionHandler regionHandler)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0xDCF6D8", Offset = "0xDCF6D8", VA = "0xDCF6D8")]
		public ConnectAndJoinRandomLb()
		{
		}
	}
}
namespace Odders.Chess.Tools
{
	[Token(Token = "0x2000126")]
	public class AnimationTestTool : MonoBehaviour
	{
		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Order: 0 = King, Queen, Rook, Bishop, Knight, Pawn")]
		private int startCharacter;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] cameras;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Order: 0 = King, Queen, Rook, Bishop, Knight, Pawn")]
		[SerializeField]
		private PieceSetting[] pieceSettings;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle isWhiteTeamToggle;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioMixerGroup audioMixer3d;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioMixerGroup audioMixer2d;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform characterPivot;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle displacementToggle;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle isEnemyWhiteTeamToggle;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform enemyPivotFront;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform enemyPivotDiagonal;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Dropdown turnDropdown;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TMP_Dropdown attackDropdown;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Slider subanimationSlider;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ToggleGroup attackToggleGroup;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TMP_Dropdown dieDropdown;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Slider timeSlider;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI txtTime;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _MainTex;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _currentIndex;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject _currentCharacter;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private AnimationTestToolDummyPiece _currentAnimatorDummyPiece;

		[Token(Token = "0x6000728")]
		[Address(RVA = "0xDCF740", Offset = "0xDCF740", VA = "0xDCF740")]
		private void Start()
		{
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0xDCFF58", Offset = "0xDCFF58", VA = "0xDCFF58")]
		private void TimeChange(float value)
		{
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0xDCFFE8", Offset = "0xDCFFE8", VA = "0xDCFFE8")]
		private void Update()
		{
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0xDCF900", Offset = "0xDCF900", VA = "0xDCF900")]
		public void ChangeCamera(int index)
		{
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0xDCFAC8", Offset = "0xDCFAC8", VA = "0xDCFAC8")]
		public void ChangeCharacter(int index)
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0xDD01B4", Offset = "0xDD01B4", VA = "0xDD01B4")]
		public void Walk(int walkType)
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0xDD080C", Offset = "0xDD080C", VA = "0xDD080C")]
		public void BreakIdle(int idleType)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0xDD01D8", Offset = "0xDD01D8", VA = "0xDD01D8")]
		public void StopWalk()
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0xDD01F0", Offset = "0xDD01F0", VA = "0xDD01F0")]
		public void Turn()
		{
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xDD0214", Offset = "0xDD0214", VA = "0xDD0214")]
		public void Attack()
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xDD0C74", Offset = "0xDD0C74", VA = "0xDD0C74")]
		public void Die()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xDD0CDC", Offset = "0xDD0CDC", VA = "0xDD0CDC")]
		public AnimationTestTool()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class AnimationTestToolDummyPiece : MonoBehaviour
	{
		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _WalkType;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _Walk;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _BreakType;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int _BreakIdle;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int _Turn;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int _TurnAngle;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int _Attack;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int _AttackToType;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int _AttackSubAnimation;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int _Die;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int _DieByType;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int _DieSubAnimation;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator _animator;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform _transform;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource3d;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public AudioSource audioSource2d;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PieceColor pieceColor;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool _displacement;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xDD0D54", Offset = "0xDD0D54", VA = "0xDD0D54")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xDD0E54", Offset = "0xDD0E54", VA = "0xDD0E54")]
		private void Update()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xDD0EC8", Offset = "0xDD0EC8", VA = "0xDD0EC8")]
		private void RandomBreak()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xDD0F50", Offset = "0xDD0F50", VA = "0xDD0F50")]
		private void EndTurn()
		{
		}

		[Token(Token = "0x600073A")]
		[Address(RVA = "0xDD0F54", Offset = "0xDD0F54", VA = "0xDD0F54")]
		private void DieEvent()
		{
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xDD10B8", Offset = "0xDD10B8", VA = "0xDD10B8")]
		private void FinishAttack()
		{
		}

		[Token(Token = "0x600073C")]
		[Address(RVA = "0xDD10BC", Offset = "0xDD10BC", VA = "0xDD10BC")]
		private void DoEffect(UnityEngine.Object effectInfo)
		{
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xDD114C", Offset = "0xDD114C", VA = "0xDD114C")]
		private void PlaySound(UnityEngine.Object sound)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xDD11C0", Offset = "0xDD11C0", VA = "0xDD11C0")]
		private void PlaySound2d(UnityEngine.Object sound)
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xDD08CC", Offset = "0xDD08CC", VA = "0xDD08CC")]
		public void BreakIdle(int idleType)
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0xDD0824", Offset = "0xDD0824", VA = "0xDD0824")]
		public void Walk(int walkType, bool displacement)
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xDD0968", Offset = "0xDD0968", VA = "0xDD0968")]
		public void StopWalk()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0xDD0A38", Offset = "0xDD0A38", VA = "0xDD0A38")]
		public void Turn(int value)
		{
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xDD1234", Offset = "0xDD1234", VA = "0xDD1234")]
		private int GetAngle(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xDD0AF4", Offset = "0xDD0AF4", VA = "0xDD0AF4")]
		public void Attack(int value, int subAnimation)
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xDD0BB4", Offset = "0xDD0BB4", VA = "0xDD0BB4")]
		public void Die(int value, int subtype)
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0xDD1258", Offset = "0xDD1258", VA = "0xDD1258")]
		public AnimationTestToolDummyPiece()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class AnimationTool : MonoBehaviour
	{
		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform playerPosition;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform originPieces;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform originSockets;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public PieceSetting[] humanWhitePieces;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public GameObject[] humanBlackPieces;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float boardGap;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TriggerInteractor triggerInteractor;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float displacementTime;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RuntimeAnimatorController animatorController;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PieceModel _queenPieceModel;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator _queenAnimator;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Sequence _queenSequence;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private PieceModel[] _queensDie;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Walk;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int _Atack;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int _Die;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TriggerInteractor _triggerInteractorLeft;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TriggerInteractor _triggerInteractorRight;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private GameObject _socketPrefab;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ChessPlayerManagerController _playerManager;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private GameObject _cameraFloorOffsetObject;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private PieceModel.Factory _pieceModelFactory;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private GameInfo _gameInfo;

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xDD1540", Offset = "0xDD1540", VA = "0xDD1540")]
		[Inject]
		public void Construct(PieceModel.Factory pieceModelFactory, [Inject(Id = "baseSocket")] GameObject socketPrefab, GameObject cameraFloorOffsetObject, ChessPlayerManagerController playerManager, GameInfo gameInfo)
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xDD1550", Offset = "0xDD1550", VA = "0xDD1550")]
		private void Start()
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0xDD1AE0", Offset = "0xDD1AE0", VA = "0xDD1AE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xDD1B6C", Offset = "0xDD1B6C", VA = "0xDD1B6C")]
		private void CheckQueensDie()
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0xDD16AC", Offset = "0xDD16AC", VA = "0xDD16AC")]
		private void CreateQueen()
		{
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xDD197C", Offset = "0xDD197C", VA = "0xDD197C")]
		private TriggerInteractor CreateInteractorInHand(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xDD1FD8", Offset = "0xDD1FD8", VA = "0xDD1FD8")]
		private void UpdateQueenPosition(BoardPosition position)
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xDD2728", Offset = "0xDD2728", VA = "0xDD2728")]
		private void NormalSequence(Sequence sequence, BoardPosition position)
		{
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0xDD20D8", Offset = "0xDD20D8", VA = "0xDD20D8")]
		private void AtackSequence(Sequence sequence, BoardPosition position)
		{
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xDD1F08", Offset = "0xDD1F08", VA = "0xDD1F08")]
		private void SetPosition(GameObject prefab, Piece piece)
		{
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0xDD181C", Offset = "0xDD181C", VA = "0xDD181C")]
		private void CreateSocket(int i, int j)
		{
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0xDD2AA0", Offset = "0xDD2AA0", VA = "0xDD2AA0")]
		private Vector3 GetRealBoardPosition(BoardPosition position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0xDD2AD8", Offset = "0xDD2AD8", VA = "0xDD2AD8")]
		public AnimationTool()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class LoadDemoScene : MonoBehaviour
	{
		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LoadSceneComponent loadSceneComponent;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameStarter.Settings _gameStarterSettings;

		[Token(Token = "0x6000761")]
		[Address(RVA = "0xDD31D8", Offset = "0xDD31D8", VA = "0xDD31D8")]
		[Inject]
		private void Construct(GameStarter.Settings gameStarterSettings)
		{
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0xDD31E0", Offset = "0xDD31E0", VA = "0xDD31E0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0xDD3290", Offset = "0xDD3290", VA = "0xDD3290")]
		public LoadDemoScene()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class LowPerformanceDeactivator : MonoBehaviour
	{
		[Token(Token = "0x6000765")]
		[Address(RVA = "0xDD32C8", Offset = "0xDD32C8", VA = "0xDD32C8")]
		[Inject]
		private void Construct([InjectOptional] PlatformManager platformManager)
		{
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0xDD3310", Offset = "0xDD3310", VA = "0xDD3310")]
		public LowPerformanceDeactivator()
		{
		}
	}
	[Token(Token = "0x200012D")]
	public class PauseEditor : MonoBehaviour
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0xDD3318", Offset = "0xDD3318", VA = "0xDD3318")]
		public PauseEditor()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class PieceSizeTool : MonoBehaviour
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform playerPosition;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform originPieces;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform originSockets;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string fenToCreate;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool startWithHumanPieces;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform board;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float boardGap;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float _currentBoardGap;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Piece Normal Size UI")]
		public Button activateNormalPiecesButton;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI totalCurrentPiecesSliderValue;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Slider totalSlider;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float kingRealSize;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Slider kingSlider;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI kingFinalPiecesSize;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI kingCurrentSliderValue;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float queenRealSize;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Slider queenSlider;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI queenFinalPiecesSize;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI queenCurrentSliderValue;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float rookRealSize;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Slider rookSlider;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI rookFinalPiecesSize;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI rookCurrentSliderValue;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float bishopRealSize;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Slider bishopSlider;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI bishopFinalPiecesSize;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI bishopCurrentSliderValue;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float knightRealSize;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Slider knightSlider;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI knightFinalPiecesSize;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI knightCurrentSliderValue;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float pawnRealSize;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public Slider pawnSlider;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public TextMeshProUGUI pawnFinalPiecesSize;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public TextMeshProUGUI pawnCurrentSliderValue;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Header("Piece Human Size UI")]
		public Button activateHumanPiecesButton;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		public PieceSetting[] humanWhitePieces;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public GameObject[] humanBlackPieces;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		public RuntimeAnimatorController pieceAnimator;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI totalHumanCurrentPiecesSliderValue;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public Slider totalHumanSlider;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		public float kingHumanRealSize;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		public Slider kingHumanSlider;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public TextMeshProUGUI kingHumanFinalPiecesSize;

		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public TextMeshProUGUI kingHumanCurrentSliderValue;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		public float queenHumanRealSize;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		public Slider queenHumanSlider;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public TextMeshProUGUI queenHumanFinalPiecesSize;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public TextMeshProUGUI queenHumanCurrentSliderValue;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public float rookHumanRealSize;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public Slider rookHumanSlider;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public TextMeshProUGUI rookHumanFinalPiecesSize;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		public TextMeshProUGUI rookHumanCurrentSliderValue;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		public float bishopHumanRealSize;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		public Slider bishopHumanSlider;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		public TextMeshProUGUI bishopHumanFinalPiecesSize;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		public TextMeshProUGUI bishopHumanCurrentSliderValue;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		public float knightHumanRealSize;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public Slider knightHumanSlider;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public TextMeshProUGUI knightHumanFinalPiecesSize;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public TextMeshProUGUI knightHumanCurrentSliderValue;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		public float pawnHumanRealSize;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public Slider pawnHumanSlider;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public TextMeshProUGUI pawnHumanFinalPiecesSize;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		public TextMeshProUGUI pawnHumanCurrentSliderValue;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[Header("Board Size UI")]
		public float distanceIncrement;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		public TextMeshProUGUI startPosition;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		public float boardRealSize;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		public TextMeshProUGUI currentBoardSize;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		public TextMeshProUGUI currentBoardSquareSize;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		public TextMeshProUGUI currentBoardSliderValue;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		public TextMeshProUGUI currentBoardDistance;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private GameObject _socketPrefab;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private GameObject _cameraFloorOffsetObject;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private List<ChessPieceInteractable> _normalPieces;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private List<ChessPieceInteractable> _humanPieces;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private PieceModel.Factory _pieceModelFactory;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0xDD3320", Offset = "0xDD3320", VA = "0xDD3320")]
		[Inject]
		public void Construct(PieceModel.Factory pieceModelFactory, [Inject(Id = "baseSocket")] GameObject socketPrefab, GameObject cameraFloorOffsetObject)
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0xDD3330", Offset = "0xDD3330", VA = "0xDD3330")]
		private void Start()
		{
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0xDD4E50", Offset = "0xDD4E50", VA = "0xDD4E50")]
		public void ChangePiecesVisibility(bool activeNormals)
		{
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0xDD4C0C", Offset = "0xDD4C0C", VA = "0xDD4C0C")]
		private void CreateSocket(int i, int j)
		{
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xDD4D74", Offset = "0xDD4D74", VA = "0xDD4D74")]
		private void SetPosition(GameObject prefab, Piece piece)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xDD50E8", Offset = "0xDD50E8", VA = "0xDD50E8")]
		private Vector3 GetRealBoardPosition(BoardPosition position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xDD5118", Offset = "0xDD5118", VA = "0xDD5118")]
		public void UpdatePieceSize(float value, float globalValue, TextMeshProUGUI finalText, TextMeshProUGUI sliderText, float realSize, List<ChessPieceInteractable> pieces)
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0xDD5450", Offset = "0xDD5450", VA = "0xDD5450")]
		public void UpdateBoardSize(float value)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xDD5160", Offset = "0xDD5160", VA = "0xDD5160")]
		private void UpdateUiInfo(TextMeshProUGUI currentValue, TextMeshProUGUI sliderValue, float realSize, float value, float globalValue)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0xDD56A8", Offset = "0xDD56A8", VA = "0xDD56A8")]
		public void AddDistance(int sing)
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xDD52CC", Offset = "0xDD52CC", VA = "0xDD52CC")]
		private void ApplyPiecesScale(float scale, List<ChessPieceInteractable> pieces)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xDD4B68", Offset = "0xDD4B68", VA = "0xDD4B68")]
		private void FormatPlayerPosition(TextMeshProUGUI uiText)
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xDD5778", Offset = "0xDD5778", VA = "0xDD5778")]
		public PieceSizeTool()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class QuestLowPerformance : MonoBehaviour
	{
		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OVRManager.FixedFoveatedRenderingLevel fixedFoveatedRenderingLevel;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0.5f, 2f)]
		public float resolutionScale;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PlatformManager _platformManager;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_Text textValue;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle toggleAnimator;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] animators;

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xDD7B80", Offset = "0xDD7B80", VA = "0xDD7B80")]
		[Inject]
		private void Construct(PlatformManager platformManager)
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xDD7B88", Offset = "0xDD7B88", VA = "0xDD7B88")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0xDD7D10", Offset = "0xDD7D10", VA = "0xDD7D10")]
		public void SetResolutionScale(float resolution)
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xDD7CB8", Offset = "0xDD7CB8", VA = "0xDD7CB8")]
		public void SetFovatedRendering(OVRManager.FixedFoveatedRenderingLevel fixedFRL)
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0xDD7D3C", Offset = "0xDD7D3C", VA = "0xDD7D3C")]
		public void SetText(float value)
		{
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xDD7DF4", Offset = "0xDD7DF4", VA = "0xDD7DF4")]
		public void SetFovatedRendering(int value)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xDD7DF8", Offset = "0xDD7DF8", VA = "0xDD7DF8")]
		public QuestLowPerformance()
		{
		}
	}
	[Token(Token = "0x2000134")]
	public class TriggerInteractor : MonoBehaviour
	{
		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputActionProperty interactActionRight;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputActionProperty interactActionLeft;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float minDistance;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Action<BoardPosition> targetPosition;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform _transform;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private MeshRenderer _mesh;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private MeshRenderer _meshChildren;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private PieceSocket _savedSocket;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int _Color;

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0xDD7EF8", Offset = "0xDD7EF8", VA = "0xDD7EF8")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xDD7F88", Offset = "0xDD7F88", VA = "0xDD7F88")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0xDD8074", Offset = "0xDD8074", VA = "0xDD8074")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xDD81C8", Offset = "0xDD81C8", VA = "0xDD81C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xDD85E8", Offset = "0xDD85E8", VA = "0xDD85E8")]
		private void ClearSockets()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xDD8758", Offset = "0xDD8758", VA = "0xDD8758")]
		private void DoAction(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0xDD8974", Offset = "0xDD8974", VA = "0xDD8974")]
		public void InitSockets(Dictionary<BoardPosition, PieceSocket> sockets)
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xDD897C", Offset = "0xDD897C", VA = "0xDD897C")]
		public TriggerInteractor()
		{
		}
	}
}
namespace Odders.Chess.UI
{
	[Token(Token = "0x2000137")]
	public class EmptyScene : MonoBehaviour
	{
		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SceneReference sceneReference;

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0xDD9BC4", Offset = "0xDD9BC4", VA = "0xDD9BC4")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0xDD9C24", Offset = "0xDD9C24", VA = "0xDD9C24")]
		public void LoadScene()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0xDD9C90", Offset = "0xDD9C90", VA = "0xDD9C90")]
		public EmptyScene()
		{
		}
	}
}
namespace Odders.UiComponents.OptionsToggles
{
	[Token(Token = "0x2000138")]
	public class FrequencyToggle : ChessBaseToggle
	{
		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		public float value;

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xDD9C98", Offset = "0xDD9C98", VA = "0xDD9C98")]
		public FrequencyToggle()
		{
		}
	}
}
