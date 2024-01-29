using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Odders.Chess.Core.Model;
using Odders.Chess.Core.Model.Board;
using Odders.Chess.GameFlow.GameStarter;
using Odders.Chess.Player;
using Odders.Chess.Player.Pieces;
using Odders.Platforms;
using Odders.UiComponents;
using Odders.UiComponents.OptionsToggles;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using Zenject;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LanguagePanel : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ToggleGroup _languageToggleGroup;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<LanguageToggle> _languageToggles;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button _startButtonIa;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD1982C", Offset = "0xD1982C", VA = "0xD1982C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD19A74", Offset = "0xD19A74", VA = "0xD19A74")]
	public void ChangeLanguage()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD198DC", Offset = "0xD198DC", VA = "0xD198DC")]
	private void ActivateSystemLanguageToggle()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD19B74", Offset = "0xD19B74", VA = "0xD19B74")]
	public LanguagePanel()
	{
	}
}
[Token(Token = "0x2000003")]
public class VoiceTest : MonoBehaviour
{
	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD19B7C", Offset = "0xD19B7C", VA = "0xD19B7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD19B80", Offset = "0xD19B80", VA = "0xD19B80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD19B84", Offset = "0xD19B84", VA = "0xD19B84")]
	public VoiceTest()
	{
	}
}
[Token(Token = "0x2000004")]
public class CollisionButton : MonoBehaviour
{
	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD19B8C", Offset = "0xD19B8C", VA = "0xD19B8C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD19B90", Offset = "0xD19B90", VA = "0xD19B90")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD19B94", Offset = "0xD19B94", VA = "0xD19B94")]
	public CollisionButton()
	{
	}
}
[Token(Token = "0x2000005")]
public class MicPartyTest : MonoBehaviour
{
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI TextMeshPro;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x20")]
	private string mictPermisions;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD19B9C", Offset = "0xD19B9C", VA = "0xD19B9C")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD19BA0", Offset = "0xD19BA0", VA = "0xD19BA0")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD19D04", Offset = "0xD19D04", VA = "0xD19D04")]
	public MicPartyTest()
	{
	}
}
[Token(Token = "0x2000006")]
public class ObjectsDisabler : MonoBehaviour
{
	[Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class <IEStart>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x20")]
		public ObjectsDisabler <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xD1A18C", Offset = "0xD1A18C", VA = "0xD1A18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xD1A1D4", Offset = "0xD1A1D4", VA = "0xD1A1D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0xD19E74", Offset = "0xD19E74", VA = "0xD19E74")]
		[DebuggerHidden]
		public <IEStart>d__5(int <>1__state)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0xD19EC8", Offset = "0xD19EC8", VA = "0xD19EC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xD19ECC", Offset = "0xD19ECC", VA = "0xD19ECC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xD1A194", Offset = "0xD1A194", VA = "0xD1A194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] ObjectsToFilter;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	public Toggle ToggleTemplate;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x28")]
	public Text Label;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD19DAC", Offset = "0xD19DAC", VA = "0xD19DAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD19E50", Offset = "0xD19E50", VA = "0xD19E50")]
	private void ToggleValueChanged(GameObject o, Toggle t)
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD19DE8", Offset = "0xD19DE8", VA = "0xD19DE8")]
	[IteratorStateMachine(typeof(<IEStart>d__5))]
	private IEnumerator IEStart()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD19E9C", Offset = "0xD19E9C", VA = "0xD19E9C")]
	public ObjectsDisabler()
	{
	}
}
[Token(Token = "0x2000009")]
public class LoadAvatarTest : MonoBehaviour
{
	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x18")]
	public SampleAvatarEntity avatar;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x20")]
	public string userId;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x28")]
	public bool LoadAvatar;

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD1A1DC", Offset = "0xD1A1DC", VA = "0xD1A1DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD1A220", Offset = "0xD1A220", VA = "0xD1A220")]
	public LoadAvatarTest()
	{
	}
}
[Token(Token = "0x200000A")]
public class PauseEditor : MonoBehaviour
{
	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD1A270", Offset = "0xD1A270", VA = "0xD1A270")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD1A2D0", Offset = "0xD1A2D0", VA = "0xD1A2D0")]
	public PauseEditor()
	{
	}
}
[Token(Token = "0x200000B")]
public class DisplayFrequencyManager : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private FrequencyToggle toggleRef;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ToggleGroup toggleGroup;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Button changeButton;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	private float[] _frequencies;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD1A2D8", Offset = "0xD1A2D8", VA = "0xD1A2D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD1A564", Offset = "0xD1A564", VA = "0xD1A564")]
	public void Set(float value)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD1A654", Offset = "0xD1A654", VA = "0xD1A654")]
	public void Change()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD1A710", Offset = "0xD1A710", VA = "0xD1A710")]
	public DisplayFrequencyManager()
	{
	}
}
[Token(Token = "0x200000C")]
public class MoveLocalizatorPanel : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <RepositionPanel>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xD1A864", Offset = "0xD1A864", VA = "0xD1A864", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xD1A8AC", Offset = "0xD1A8AC", VA = "0xD1A8AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xD1A79C", Offset = "0xD1A79C", VA = "0xD1A79C")]
		[DebuggerHidden]
		public <RepositionPanel>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xD1A7CC", Offset = "0xD1A7CC", VA = "0xD1A7CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xD1A7D0", Offset = "0xD1A7D0", VA = "0xD1A7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xD1A86C", Offset = "0xD1A86C", VA = "0xD1A86C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x18")]
	private ChessPlayerManagerController _player;

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD1A718", Offset = "0xD1A718", VA = "0xD1A718")]
	[Inject]
	public void Construct(ChessPlayerManagerController player)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD1A73C", Offset = "0xD1A73C", VA = "0xD1A73C")]
	[IteratorStateMachine(typeof(<RepositionPanel>d__2))]
	private IEnumerator RepositionPanel()
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD1A7C4", Offset = "0xD1A7C4", VA = "0xD1A7C4")]
	public MoveLocalizatorPanel()
	{
	}
}
[Token(Token = "0x200000E")]
public class RandomMaterial : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	public Renderer targetRenderer;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD1A8B4", Offset = "0xD1A8B4", VA = "0xD1A8B4")]
	public void Start()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD1A8B8", Offset = "0xD1A8B8", VA = "0xD1A8B8")]
	public void ChangeMaterial()
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD1A910", Offset = "0xD1A910", VA = "0xD1A910")]
	public RandomMaterial()
	{
	}
}
[Token(Token = "0x200000F")]
public class UnluckDistanceDisabler : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x18")]
	public int _distanceDisable;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public Transform _distanceFrom;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x28")]
	public bool _distanceFromMainCam;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x2C")]
	public float _disableCheckInterval;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x30")]
	public float _enableCheckInterval;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x34")]
	public bool _disableOnStart;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD1A918", Offset = "0xD1A918", VA = "0xD1A918")]
	public void Start()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD1AA18", Offset = "0xD1AA18", VA = "0xD1AA18")]
	public void DisableOnStart()
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD1AA4C", Offset = "0xD1AA4C", VA = "0xD1AA4C")]
	public void CheckDisable()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD1AB18", Offset = "0xD1AB18", VA = "0xD1AB18")]
	public void CheckEnable()
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD1ABE4", Offset = "0xD1ABE4", VA = "0xD1ABE4")]
	public UnluckDistanceDisabler()
	{
	}
}
[Token(Token = "0x2000010")]
public class LookAtCamera : MonoBehaviour
{
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public Camera lookAtCamera;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x20")]
	public bool lookOnlyOnAwake;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD1AC00", Offset = "0xD1AC00", VA = "0xD1AC00")]
	public void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD1ACD0", Offset = "0xD1ACD0", VA = "0xD1ACD0")]
	public void Update()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD1AC8C", Offset = "0xD1AC8C", VA = "0xD1AC8C")]
	public void LookCam()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD1ACE0", Offset = "0xD1ACE0", VA = "0xD1ACE0")]
	public LookAtCamera()
	{
	}
}
[Token(Token = "0x2000011")]
[AddComponentMenu("Camera-Control/Smooth Mouse Orbit - Unluck Software")]
public class SmoothCameraOrbit : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 targetOffset;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x2C")]
	public float distance;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x30")]
	public float maxDistance;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x34")]
	public float minDistance;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x38")]
	public float xSpeed;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x3C")]
	public float ySpeed;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x40")]
	public int yMinLimit;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x44")]
	public int yMaxLimit;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x48")]
	public int zoomRate;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x4C")]
	public float panSpeed;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x50")]
	public float zoomDampening;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x54")]
	public float autoRotate;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x58")]
	public float autoRotateSpeed;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x5C")]
	private float xDeg;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x60")]
	private float yDeg;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x64")]
	private float currentDistance;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x68")]
	private float desiredDistance;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion currentRotation;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x7C")]
	private Quaternion desiredRotation;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x8C")]
	private Quaternion rotation;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 position;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0xA8")]
	private float idleTimer;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0xAC")]
	private float idleSmooth;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD1ACE8", Offset = "0xD1ACE8", VA = "0xD1ACE8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD1B1D4", Offset = "0xD1B1D4", VA = "0xD1B1D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD1ACEC", Offset = "0xD1ACEC", VA = "0xD1ACEC")]
	public void Init()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD1B1D8", Offset = "0xD1B1D8", VA = "0xD1B1D8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD1B6B0", Offset = "0xD1B6B0", VA = "0xD1B6B0")]
	private static float ClampAngle(float angle, float min, float max)
	{
		return default(float);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD1B6EC", Offset = "0xD1B6EC", VA = "0xD1B6EC")]
	public SmoothCameraOrbit()
	{
	}
}
[Token(Token = "0x2000012")]
public class FlockChild : MonoBehaviour
{
	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockController _spawner;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Vector3 _wayPoint;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x2C")]
	public float _speed;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool _dived;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public float _stuckCounter;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public float _damping;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool _soar;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool _landing;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public float _targetSpeed;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public bool _move;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x48")]
	public GameObject _model;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x50")]
	public Transform _modelT;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public float _avoidValue;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public float _avoidDistance;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x60")]
	private float _soarTimer;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x64")]
	private bool _instantiated;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x0")]
	private static int _updateNextSeed;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x68")]
	private int _updateSeed;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public bool _avoid;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x70")]
	public Transform _thisT;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 _landingPosOffset;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD1B728", Offset = "0xD1B728", VA = "0xD1B728")]
	public void Start()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD1BE20", Offset = "0xD1BE20", VA = "0xD1BE20")]
	public void Update()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD1C530", Offset = "0xD1C530", VA = "0xD1C530")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD1C564", Offset = "0xD1C564", VA = "0xD1C564")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD1B80C", Offset = "0xD1B80C", VA = "0xD1B80C")]
	public void FindRequiredComponents()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD1BAC8", Offset = "0xD1BAC8", VA = "0xD1BAC8")]
	public void RandomizeStartAnimationFrame()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD1BDCC", Offset = "0xD1BDCC", VA = "0xD1BDCC")]
	public void InitAvoidanceValues()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD1B9CC", Offset = "0xD1B9CC", VA = "0xD1B9CC")]
	public void SetRandomScale()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD1BE7C", Offset = "0xD1BE7C", VA = "0xD1BE7C")]
	public void SoarTimeLimit()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD1BED4", Offset = "0xD1BED4", VA = "0xD1BED4")]
	public void CheckForDistanceToWaypoint()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD1BFE4", Offset = "0xD1BFE4", VA = "0xD1BFE4")]
	public void RotationBasedOnWaypointOrAvoidance()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD1C854", Offset = "0xD1C854", VA = "0xD1C854")]
	public bool Avoidance()
	{
		return default(bool);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD1C2D8", Offset = "0xD1C2D8", VA = "0xD1C2D8")]
	public void LimitRotationOfModel()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD1B924", Offset = "0xD1B924", VA = "0xD1B924")]
	public void Wander(float delay)
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD1CDD0", Offset = "0xD1CDD0", VA = "0xD1CDD0")]
	public void SetRandomMode()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD1C610", Offset = "0xD1C610", VA = "0xD1C610")]
	public void Flap()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD1BA08", Offset = "0xD1BA08", VA = "0xD1BA08")]
	public Vector3 findWaypoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD1CE90", Offset = "0xD1CE90", VA = "0xD1CE90")]
	public void Soar()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD1CF20", Offset = "0xD1CF20", VA = "0xD1CF20")]
	public void Dive()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD1D2BC", Offset = "0xD1D2BC", VA = "0xD1D2BC")]
	public void animationSpeed()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD1D600", Offset = "0xD1D600", VA = "0xD1D600")]
	public FlockChild()
	{
	}
}
[Token(Token = "0x2000013")]
[RequireComponent(typeof(AudioSource))]
public class FlockChildSound : MonoBehaviour
{
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x18")]
	public AudioClip[] _idleSounds;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x20")]
	public float _idleSoundRandomChance;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip[] _flightSounds;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x30")]
	public float _flightSoundRandomChance;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x38")]
	public AudioClip[] _scareSounds;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x40")]
	public float _pitchMin;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x44")]
	public float _pitchMax;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x48")]
	public float _volumeMin;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x4C")]
	public float _volumeMax;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x50")]
	private FlockChild _flockChild;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x58")]
	private AudioSource _audio;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x60")]
	private bool _hasLanded;

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD1D624", Offset = "0xD1D624", VA = "0xD1D624")]
	public void Start()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD1D724", Offset = "0xD1D724", VA = "0xD1D724")]
	public void PlayRandomSound()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD1D928", Offset = "0xD1D928", VA = "0xD1D928")]
	public void ScareSound()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD1DA24", Offset = "0xD1DA24", VA = "0xD1DA24")]
	public FlockChildSound()
	{
	}
}
[Token(Token = "0x2000014")]
public class FlockController : MonoBehaviour
{
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x18")]
	public FlockChild _childPrefab;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x20")]
	public int _childAmount;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x24")]
	public bool _slowSpawn;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x28")]
	public float _spawnSphere;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x2C")]
	public float _spawnSphereHeight;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x30")]
	public float _spawnSphereDepth;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x34")]
	public float _minSpeed;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x38")]
	public float _maxSpeed;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0x3C")]
	public float _minScale;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0x40")]
	public float _maxScale;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0x44")]
	public float _soarFrequency;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0x48")]
	public string _soarAnimation;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0x50")]
	public string _flapAnimation;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x58")]
	public string _idleAnimation;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x60")]
	public float _diveValue;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x64")]
	public float _diveFrequency;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x68")]
	public float _minDamping;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x6C")]
	public float _maxDamping;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x70")]
	public float _waypointDistance;

	[Token(Token = "0x400006F")]
	[FieldOffset(Offset = "0x74")]
	public float _minAnimationSpeed;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x78")]
	public float _maxAnimationSpeed;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x7C")]
	public float _randomPositionTimer;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x80")]
	public float _positionSphere;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x84")]
	public float _positionSphereHeight;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x88")]
	public float _positionSphereDepth;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x8C")]
	public bool _childTriggerPos;

	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x8D")]
	public bool _forceChildWaypoints;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x90")]
	public float _forcedRandomDelay;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x94")]
	public bool _flatFly;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x95")]
	public bool _flatSoar;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x96")]
	public bool _birdAvoid;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x98")]
	public int _birdAvoidHorizontalForce;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x9C")]
	public bool _birdAvoidDown;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x9D")]
	public bool _birdAvoidUp;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0xA0")]
	public int _birdAvoidVerticalForce;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0xA4")]
	public float _birdAvoidDistanceMax;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0xA8")]
	public float _birdAvoidDistanceMin;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0xAC")]
	public float _soarMaxTime;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0xB0")]
	public LayerMask _avoidanceMask;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0xB8")]
	public List<FlockChild> _roamers;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0xC0")]
	public Vector3 _posBuffer;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0xCC")]
	public int _updateDivisor;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0xD0")]
	public float _newDelta;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0xD4")]
	public int _updateCounter;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0xD8")]
	public float _activeChildren;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0xDC")]
	public bool _groupChildToNewTransform;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0xE0")]
	public Transform _groupTransform;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0xE8")]
	public string _groupName;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0xF0")]
	public bool _groupChildToFlock;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0xF4")]
	public Vector3 _startPosOffset;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x100")]
	public Transform _thisT;

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD1DA48", Offset = "0xD1DA48", VA = "0xD1DA48")]
	public void Start()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD1DB2C", Offset = "0xD1DB2C", VA = "0xD1DB2C")]
	public void AddChild(int amount)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD1DDC0", Offset = "0xD1DDC0", VA = "0xD1DDC0")]
	public void AddChildToParent(Transform obj)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD1DE10", Offset = "0xD1DE10", VA = "0xD1DE10")]
	public void RemoveChild(int amount)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD1DF18", Offset = "0xD1DF18", VA = "0xD1DF18")]
	public void Update()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD1DC6C", Offset = "0xD1DC6C", VA = "0xD1DC6C")]
	public void InstantiateGroup()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD1DF7C", Offset = "0xD1DF7C", VA = "0xD1DF7C")]
	public void UpdateChildAmount()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD1E00C", Offset = "0xD1E00C", VA = "0xD1E00C")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD1C6E4", Offset = "0xD1C6E4", VA = "0xD1C6E4")]
	public void SetFlockRandomPosition()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD1E1E4", Offset = "0xD1E1E4", VA = "0xD1E1E4")]
	public void destroyBirds()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD1E2F0", Offset = "0xD1E2F0", VA = "0xD1E2F0")]
	public FlockController()
	{
	}
}
[Token(Token = "0x2000015")]
public class FlockScare : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x18")]
	public LandingSpotController[] landingSpotControllers;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x20")]
	public float scareInterval;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x24")]
	public float distanceToScare;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x28")]
	public int checkEveryNthLandingSpot;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x2C")]
	public int InvokeAmounts;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x30")]
	private int lsc;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x34")]
	private int ls;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x38")]
	private LandingSpotController currentController;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD1E434", Offset = "0xD1E434", VA = "0xD1E434")]
	private void CheckProximityToLandingSpots()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD1E504", Offset = "0xD1E504", VA = "0xD1E504")]
	private void IterateLandingSpots()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xD1E5A0", Offset = "0xD1E5A0", VA = "0xD1E5A0")]
	private bool CheckDistanceToLandingSpot(LandingSpotController lc)
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xD1E6E4", Offset = "0xD1E6E4", VA = "0xD1E6E4")]
	private void Invoker()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xD1E76C", Offset = "0xD1E76C", VA = "0xD1E76C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xD1E7E0", Offset = "0xD1E7E0", VA = "0xD1E7E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xD1E82C", Offset = "0xD1E82C", VA = "0xD1E82C")]
	public FlockScare()
	{
	}
}
[Token(Token = "0x2000016")]
public class FlockWaypointTrigger : MonoBehaviour
{
	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x18")]
	public float _timer;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x20")]
	public FlockChild _flockChild;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xD1E844", Offset = "0xD1E844", VA = "0xD1E844")]
	public void Start()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xD1E924", Offset = "0xD1E924", VA = "0xD1E924")]
	public void Trigger()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xD1E940", Offset = "0xD1E940", VA = "0xD1E940")]
	public FlockWaypointTrigger()
	{
	}
}
[Token(Token = "0x2000017")]
public class LandingButtons : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x18")]
	public LandingSpotController _landingSpotController;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x20")]
	public FlockController _flockController;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x28")]
	public float hSliderValue;

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xD1E950", Offset = "0xD1E950", VA = "0xD1E950")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xD1EEBC", Offset = "0xD1EEBC", VA = "0xD1EEBC")]
	public LandingButtons()
	{
	}
}
[Token(Token = "0x2000018")]
public class LandingSpot : MonoBehaviour
{
	[Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class <GetFlockChild>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000A4")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x20")]
		public float minDelay;

		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0x24")]
		public float maxDelay;

		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x28")]
		public LandingSpot <>4__this;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xD20928", Offset = "0xD20928", VA = "0xD20928", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xD20970", Offset = "0xD20970", VA = "0xD20970", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD1FC38", Offset = "0xD1FC38", VA = "0xD1FC38")]
		[DebuggerHidden]
		public <GetFlockChild>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xD20214", Offset = "0xD20214", VA = "0xD20214", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD20218", Offset = "0xD20218", VA = "0xD20218", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xD20930", Offset = "0xD20930", VA = "0xD20930", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public FlockChild landingChild;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public bool landing;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x24")]
	private int lerpCounter;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public LandingSpotController _controller;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x30")]
	private bool _idle;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x38")]
	public Transform _thisT;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x40")]
	public bool _gotcha;

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xD1EECC", Offset = "0xD1EECC", VA = "0xD1EECC")]
	public void Start()
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xD1F060", Offset = "0xD1F060", VA = "0xD1F060")]
	public void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xD1F428", Offset = "0xD1F428", VA = "0xD1F428")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xD1FBCC", Offset = "0xD1FBCC", VA = "0xD1FBCC")]
	public void StraightenBird()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xD1FA08", Offset = "0xD1FA08", VA = "0xD1FA08")]
	public void RotateBird()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xD1EFE4", Offset = "0xD1EFE4", VA = "0xD1EFE4")]
	[IteratorStateMachine(typeof(<GetFlockChild>d__12))]
	public IEnumerator GetFlockChild(float minDelay, float maxDelay)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xD1FC60", Offset = "0xD1FC60", VA = "0xD1FC60")]
	public void InstantLand()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xD1FF8C", Offset = "0xD1FF8C", VA = "0xD1FF8C")]
	public void ReleaseFlockChild()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xD2020C", Offset = "0xD2020C", VA = "0xD2020C")]
	public LandingSpot()
	{
	}
}
[Token(Token = "0x200001A")]
public class LandingSpotController : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <InstantLandOnStart>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xD20F64", Offset = "0xD20F64", VA = "0xD20F64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xD20FAC", Offset = "0xD20FAC", VA = "0xD20FAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xD20D4C", Offset = "0xD20D4C", VA = "0xD20D4C")]
		[DebuggerHidden]
		public <InstantLandOnStart>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xD20DEC", Offset = "0xD20DEC", VA = "0xD20DEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xD20DF0", Offset = "0xD20DF0", VA = "0xD20DF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xD20F6C", Offset = "0xD20F6C", VA = "0xD20F6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class <InstantLand>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x28")]
		public LandingSpotController <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xD2112C", Offset = "0xD2112C", VA = "0xD2112C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xD21174", Offset = "0xD21174", VA = "0xD21174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD20D74", Offset = "0xD20D74", VA = "0xD20D74")]
		[DebuggerHidden]
		public <InstantLand>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xD20FB4", Offset = "0xD20FB4", VA = "0xD20FB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xD20FB8", Offset = "0xD20FB8", VA = "0xD20FB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xD21134", Offset = "0xD21134", VA = "0xD21134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x18")]
	public bool _randomRotate;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x1C")]
	public Vector2 _autoCatchDelay;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 _autoDismountDelay;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x2C")]
	public float _maxBirdDistance;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x30")]
	public float _minBirdDistance;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x34")]
	public bool _takeClosest;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x38")]
	public FlockController _flock;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x40")]
	public bool _landOnStart;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x41")]
	public bool _soarLand;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x42")]
	public bool _onlyBirdsAbove;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x44")]
	public float _landingSpeedModifier;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x48")]
	public float _landingTurnSpeedModifier;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x50")]
	public Transform _featherPS;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x58")]
	public Transform _thisT;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x60")]
	public int _activeLandingSpots;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x64")]
	public float _snapLandDistance;

	[Token(Token = "0x40000B8")]
	[FieldOffset(Offset = "0x68")]
	public float _landedRotateSpeed;

	[Token(Token = "0x40000B9")]
	[FieldOffset(Offset = "0x6C")]
	public float _gizmoSize;

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xD20978", Offset = "0xD20978", VA = "0xD20978")]
	public void Start()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xD1E6D8", Offset = "0xD1E6D8", VA = "0xD1E6D8")]
	public void ScareAll()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xD20C04", Offset = "0xD20C04", VA = "0xD20C04")]
	public void ScareAll(float minDelay, float maxDelay)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xD1ED24", Offset = "0xD1ED24", VA = "0xD1ED24")]
	public void LandAll()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xD20B8C", Offset = "0xD20B8C", VA = "0xD20B8C")]
	[IteratorStateMachine(typeof(<InstantLandOnStart>d__22))]
	public IEnumerator InstantLandOnStart(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xD1EE44", Offset = "0xD1EE44", VA = "0xD1EE44")]
	[IteratorStateMachine(typeof(<InstantLand>d__23))]
	public IEnumerator InstantLand(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xD20D9C", Offset = "0xD20D9C", VA = "0xD20D9C")]
	public LandingSpotController()
	{
	}
}
[Token(Token = "0x200001D")]
public class OddersInputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
{
	[Token(Token = "0x200001E")]
	public struct OddersHMDActions
	{
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000014")]
		public InputAction Position
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xD21B28", Offset = "0xD21B28", VA = "0xD21B28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xD21B44", Offset = "0xD21B44", VA = "0xD21B44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		public bool enabled
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xD21BC4", Offset = "0xD21BC4", VA = "0xD21BC4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xD21B20", Offset = "0xD21B20", VA = "0xD21B20")]
		public OddersHMDActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD21B60", Offset = "0xD21B60", VA = "0xD21B60")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xD21B7C", Offset = "0xD21B7C", VA = "0xD21B7C")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD21BA0", Offset = "0xD21BA0", VA = "0xD21BA0")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD21BE8", Offset = "0xD21BE8", VA = "0xD21BE8")]
		public static implicit operator InputActionMap(OddersHMDActions set)
		{
			return null;
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD21C00", Offset = "0xD21C00", VA = "0xD21C00")]
		public void SetCallbacks(IOddersHMDActions instance)
		{
		}
	}

	[Token(Token = "0x200001F")]
	public struct OddersLeftHandActions
	{
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000017")]
		public InputAction Position
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xD2238C", Offset = "0xD2238C", VA = "0xD2238C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xD223A8", Offset = "0xD223A8", VA = "0xD223A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public InputAction Grip
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xD223C4", Offset = "0xD223C4", VA = "0xD223C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public InputAction Trigger
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xD223E0", Offset = "0xD223E0", VA = "0xD223E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xD223FC", Offset = "0xD223FC", VA = "0xD223FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xD22418", Offset = "0xD22418", VA = "0xD22418")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public InputAction Menu
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xD22434", Offset = "0xD22434", VA = "0xD22434")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xD22450", Offset = "0xD22450", VA = "0xD22450")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xD2246C", Offset = "0xD2246C", VA = "0xD2246C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public InputAction Velocity
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xD22488", Offset = "0xD22488", VA = "0xD22488")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public InputAction Acceleration
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xD224A4", Offset = "0xD224A4", VA = "0xD224A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xD224C0", Offset = "0xD224C0", VA = "0xD224C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		public InputAction GrabAction
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xD224DC", Offset = "0xD224DC", VA = "0xD224DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		public InputAction GrabAnimationAction
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xD224F8", Offset = "0xD224F8", VA = "0xD224F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public bool enabled
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xD22578", Offset = "0xD22578", VA = "0xD22578")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xD22384", Offset = "0xD22384", VA = "0xD22384")]
		public OddersLeftHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD22514", Offset = "0xD22514", VA = "0xD22514")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD22530", Offset = "0xD22530", VA = "0xD22530")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD22554", Offset = "0xD22554", VA = "0xD22554")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD2259C", Offset = "0xD2259C", VA = "0xD2259C")]
		public static implicit operator InputActionMap(OddersLeftHandActions set)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xD225B4", Offset = "0xD225B4", VA = "0xD225B4")]
		public void SetCallbacks(IOddersLeftHandActions instance)
		{
		}
	}

	[Token(Token = "0x2000020")]
	public struct OddersRightHandActions
	{
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x0")]
		private OddersInputActions m_Wrapper;

		[Token(Token = "0x17000026")]
		public InputAction Position
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xD25800", Offset = "0xD25800", VA = "0xD25800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		public InputAction Rotation
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xD2581C", Offset = "0xD2581C", VA = "0xD2581C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		public InputAction Grip
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xD25838", Offset = "0xD25838", VA = "0xD25838")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public InputAction Trigger
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xD25854", Offset = "0xD25854", VA = "0xD25854")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		public InputAction HapticDevice
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xD25870", Offset = "0xD25870", VA = "0xD25870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		public InputAction SwapUIRay
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xD2588C", Offset = "0xD2588C", VA = "0xD2588C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		public InputAction Menu
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xD258A8", Offset = "0xD258A8", VA = "0xD258A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		public InputAction PrimaryButton
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xD258C4", Offset = "0xD258C4", VA = "0xD258C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public InputAction SecundaryButton
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xD258E0", Offset = "0xD258E0", VA = "0xD258E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public InputAction Velocity
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xD258FC", Offset = "0xD258FC", VA = "0xD258FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public InputAction Acceleration
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xD25918", Offset = "0xD25918", VA = "0xD25918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		public InputAction AngularAcceleration
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xD25934", Offset = "0xD25934", VA = "0xD25934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public InputAction GrabAction
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0xD25950", Offset = "0xD25950", VA = "0xD25950")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public InputAction GrabAnimationAction
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0xD2596C", Offset = "0xD2596C", VA = "0xD2596C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		public InputAction ShowFullVersion
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0xD25988", Offset = "0xD25988", VA = "0xD25988")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public bool enabled
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xD25A08", Offset = "0xD25A08", VA = "0xD25A08")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xD257F8", Offset = "0xD257F8", VA = "0xD257F8")]
		public OddersRightHandActions(OddersInputActions wrapper)
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD259A4", Offset = "0xD259A4", VA = "0xD259A4")]
		public InputActionMap Get()
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD259C0", Offset = "0xD259C0", VA = "0xD259C0")]
		public void Enable()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xD259E4", Offset = "0xD259E4", VA = "0xD259E4")]
		public void Disable()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD25A2C", Offset = "0xD25A2C", VA = "0xD25A2C")]
		public static implicit operator InputActionMap(OddersRightHandActions set)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD25A44", Offset = "0xD25A44", VA = "0xD25A44")]
		public void SetCallbacks(IOddersRightHandActions instance)
		{
		}
	}

	[Token(Token = "0x2000021")]
	public interface IOddersHMDActions
	{
		[Token(Token = "0x60000D8")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60000D9")]
		void OnRotation(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000022")]
	public interface IOddersLeftHandActions
	{
		[Token(Token = "0x60000DA")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60000DB")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x60000DC")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x60000DD")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x60000DE")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x60000DF")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x60000E0")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x60000E1")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000E2")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000E3")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x60000E4")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x60000E5")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x60000E6")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x60000E7")]
		void OnGrabAnimationAction(InputAction.CallbackContext context);
	}

	[Token(Token = "0x2000023")]
	public interface IOddersRightHandActions
	{
		[Token(Token = "0x60000E8")]
		void OnPosition(InputAction.CallbackContext context);

		[Token(Token = "0x60000E9")]
		void OnRotation(InputAction.CallbackContext context);

		[Token(Token = "0x60000EA")]
		void OnGrip(InputAction.CallbackContext context);

		[Token(Token = "0x60000EB")]
		void OnTrigger(InputAction.CallbackContext context);

		[Token(Token = "0x60000EC")]
		void OnHapticDevice(InputAction.CallbackContext context);

		[Token(Token = "0x60000ED")]
		void OnSwapUIRay(InputAction.CallbackContext context);

		[Token(Token = "0x60000EE")]
		void OnMenu(InputAction.CallbackContext context);

		[Token(Token = "0x60000EF")]
		void OnPrimaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000F0")]
		void OnSecundaryButton(InputAction.CallbackContext context);

		[Token(Token = "0x60000F1")]
		void OnVelocity(InputAction.CallbackContext context);

		[Token(Token = "0x60000F2")]
		void OnAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x60000F3")]
		void OnAngularAcceleration(InputAction.CallbackContext context);

		[Token(Token = "0x60000F4")]
		void OnGrabAction(InputAction.CallbackContext context);

		[Token(Token = "0x60000F5")]
		void OnGrabAnimationAction(InputAction.CallbackContext context);

		[Token(Token = "0x60000F6")]
		void OnShowFullVersion(InputAction.CallbackContext context);
	}

	[Token(Token = "0x40000C3")]
	[FieldOffset(Offset = "0x18")]
	private readonly InputActionMap m_OddersHMD;

	[Token(Token = "0x40000C4")]
	[FieldOffset(Offset = "0x20")]
	private IOddersHMDActions m_OddersHMDActionsCallbackInterface;

	[Token(Token = "0x40000C5")]
	[FieldOffset(Offset = "0x28")]
	private readonly InputAction m_OddersHMD_Position;

	[Token(Token = "0x40000C6")]
	[FieldOffset(Offset = "0x30")]
	private readonly InputAction m_OddersHMD_Rotation;

	[Token(Token = "0x40000C7")]
	[FieldOffset(Offset = "0x38")]
	private readonly InputActionMap m_OddersLeftHand;

	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x40")]
	private IOddersLeftHandActions m_OddersLeftHandActionsCallbackInterface;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x48")]
	private readonly InputAction m_OddersLeftHand_Position;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x50")]
	private readonly InputAction m_OddersLeftHand_Rotation;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x58")]
	private readonly InputAction m_OddersLeftHand_Grip;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x60")]
	private readonly InputAction m_OddersLeftHand_Trigger;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x68")]
	private readonly InputAction m_OddersLeftHand_HapticDevice;

	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x70")]
	private readonly InputAction m_OddersLeftHand_SwapUIRay;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x78")]
	private readonly InputAction m_OddersLeftHand_Menu;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x80")]
	private readonly InputAction m_OddersLeftHand_PrimaryButton;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x88")]
	private readonly InputAction m_OddersLeftHand_SecundaryButton;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x90")]
	private readonly InputAction m_OddersLeftHand_Velocity;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x98")]
	private readonly InputAction m_OddersLeftHand_Acceleration;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0xA0")]
	private readonly InputAction m_OddersLeftHand_AngularAcceleration;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0xA8")]
	private readonly InputAction m_OddersLeftHand_GrabAction;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0xB0")]
	private readonly InputAction m_OddersLeftHand_GrabAnimationAction;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0xB8")]
	private readonly InputActionMap m_OddersRightHand;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0xC0")]
	private IOddersRightHandActions m_OddersRightHandActionsCallbackInterface;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0xC8")]
	private readonly InputAction m_OddersRightHand_Position;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0xD0")]
	private readonly InputAction m_OddersRightHand_Rotation;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0xD8")]
	private readonly InputAction m_OddersRightHand_Grip;

	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0xE0")]
	private readonly InputAction m_OddersRightHand_Trigger;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0xE8")]
	private readonly InputAction m_OddersRightHand_HapticDevice;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0xF0")]
	private readonly InputAction m_OddersRightHand_SwapUIRay;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0xF8")]
	private readonly InputAction m_OddersRightHand_Menu;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x100")]
	private readonly InputAction m_OddersRightHand_PrimaryButton;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x108")]
	private readonly InputAction m_OddersRightHand_SecundaryButton;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x110")]
	private readonly InputAction m_OddersRightHand_Velocity;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x118")]
	private readonly InputAction m_OddersRightHand_Acceleration;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x120")]
	private readonly InputAction m_OddersRightHand_AngularAcceleration;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x128")]
	private readonly InputAction m_OddersRightHand_GrabAction;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x130")]
	private readonly InputAction m_OddersRightHand_GrabAnimationAction;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x138")]
	private readonly InputAction m_OddersRightHand_ShowFullVersion;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x140")]
	private int m_GenericXRControllerSchemeIndex;

	[Token(Token = "0x1700000B")]
	public InputActionAsset asset
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xD2117C", Offset = "0xD2117C", VA = "0xD2117C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000C")]
	public InputBinding? bindingMask
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xD21810", Offset = "0xD21810", VA = "0xD21810", Slot = "7")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xD21838", Offset = "0xD21838", VA = "0xD21838", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public ReadOnlyArray<InputDevice>? devices
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xD21884", Offset = "0xD21884", VA = "0xD21884", Slot = "9")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xD218C4", Offset = "0xD218C4", VA = "0xD218C4", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public ReadOnlyArray<InputControlScheme> controlSchemes
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xD21910", Offset = "0xD21910", VA = "0xD21910", Slot = "11")]
		get
		{
			return default(ReadOnlyArray<InputControlScheme>);
		}
	}

	[Token(Token = "0x1700000F")]
	public IEnumerable<InputBinding> bindings
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD219B8", Offset = "0xD219B8", VA = "0xD219B8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public OddersHMDActions OddersHMD
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD21A50", Offset = "0xD21A50", VA = "0xD21A50")]
		get
		{
			return default(OddersHMDActions);
		}
	}

	[Token(Token = "0x17000011")]
	public OddersLeftHandActions OddersLeftHand
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD21A54", Offset = "0xD21A54", VA = "0xD21A54")]
		get
		{
			return default(OddersLeftHandActions);
		}
	}

	[Token(Token = "0x17000012")]
	public OddersRightHandActions OddersRightHand
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD21A58", Offset = "0xD21A58", VA = "0xD21A58")]
		get
		{
			return default(OddersRightHandActions);
		}
	}

	[Token(Token = "0x17000013")]
	public InputControlScheme GenericXRControllerScheme
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xD21A5C", Offset = "0xD21A5C", VA = "0xD21A5C")]
		get
		{
			return default(InputControlScheme);
		}
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xD21184", Offset = "0xD21184", VA = "0xD21184")]
	public OddersInputActions()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xD217B4", Offset = "0xD217B4", VA = "0xD217B4", Slot = "17")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xD2192C", Offset = "0xD2192C", VA = "0xD2192C", Slot = "12")]
	public bool Contains(InputAction action)
	{
		return default(bool);
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xD21948", Offset = "0xD21948", VA = "0xD21948", Slot = "15")]
	public IEnumerator<InputAction> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xD21964", Offset = "0xD21964", VA = "0xD21964", Slot = "16")]
	private IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xD21980", Offset = "0xD21980", VA = "0xD21980", Slot = "13")]
	public void Enable()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xD2199C", Offset = "0xD2199C", VA = "0xD2199C", Slot = "14")]
	public void Disable()
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xD219D4", Offset = "0xD219D4", VA = "0xD219D4", Slot = "5")]
	public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xD219F4", Offset = "0xD219F4", VA = "0xD219F4", Slot = "6")]
	public int FindBinding(InputBinding bindingMask, out InputAction action)
	{
		return default(int);
	}
}
[Token(Token = "0x2000024")]
public class CheckVoicePermisions : MonoBehaviour
{
	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject voice;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameStarter gameStarter;

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xD29018", Offset = "0xD29018", VA = "0xD29018")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xD290C4", Offset = "0xD290C4", VA = "0xD290C4")]
	private void ActivateMic(bool micAvailable)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xD291EC", Offset = "0xD291EC", VA = "0xD291EC")]
	public CheckVoicePermisions()
	{
	}
}
[Token(Token = "0x2000025")]
public class DeviceInfo : MonoBehaviour
{
	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TMP_Dropdown infoDropdown;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI firstColumnInfo;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TextMeshProUGUI logText;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private XRController rightHand;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private XRController leftHand;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xD29268", Offset = "0xD29268", VA = "0xD29268")]
	private void Update()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xD2A230", Offset = "0xD2A230", VA = "0xD2A230")]
	private void MovePanel()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xD29280", Offset = "0xD29280", VA = "0xD29280")]
	private void GetStatus()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xD2A420", Offset = "0xD2A420", VA = "0xD2A420")]
	public DeviceInfo()
	{
	}
}
namespace Shaders.Tests
{
	[Token(Token = "0x2000027")]
	public class UpdatePosition : MonoBehaviour
	{
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material material2;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Range(0.1f, 1f)]
		private float radius;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Range(0.1f, 20f)]
		private float hardness;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color color;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _Position;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _ColorMulti;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _Color;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _Hardness;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _Radtest;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD2A4AC", Offset = "0xD2A4AC", VA = "0xD2A4AC")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD2A5CC", Offset = "0xD2A5CC", VA = "0xD2A5CC")]
		public UpdatePosition()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x2000028")]
	public class SimpleCameraController : MonoBehaviour
	{
		[Token(Token = "0x2000029")]
		private class CameraState
		{
			[Token(Token = "0x4000106")]
			[FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000107")]
			[FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000108")]
			[FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000109")]
			[FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x400010A")]
			[FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x400010B")]
			[FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000109")]
			[Address(RVA = "0xD2A750", Offset = "0xD2A750", VA = "0xD2A750")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x600010A")]
			[Address(RVA = "0xD2ACC8", Offset = "0xD2ACC8", VA = "0xD2ACC8")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x600010B")]
			[Address(RVA = "0xD2AD48", Offset = "0xD2AD48", VA = "0xD2AD48")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0xD2ADD0", Offset = "0xD2ADD0", VA = "0xD2ADD0")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0xD2AFC4", Offset = "0xD2AFC4", VA = "0xD2AFC4")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x28")]
		[Header("Movement Settings")]
		[Tooltip("Exponential boost factor on translation, controllable by mouse wheel.")]
		public float boost;

		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("Time it takes to interpolate camera position 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float positionLerpTime;

		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("X = Change in mouse position.\nY = Multiplicative factor for camera rotation.")]
		[Header("Rotation Settings")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0x38")]
		[Tooltip("Time it takes to interpolate camera rotation 99% of the way to the target.")]
		[Range(0.001f, 1f)]
		public float rotationLerpTime;

		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x3C")]
		[Tooltip("Whether or not to invert our Y axis for mouse input to rotation.")]
		public bool invertY;

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD2A6FC", Offset = "0xD2A6FC", VA = "0xD2A6FC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD2A7D4", Offset = "0xD2A7D4", VA = "0xD2A7D4")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD2AA04", Offset = "0xD2AA04", VA = "0xD2AA04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD2AE18", Offset = "0xD2AE18", VA = "0xD2AE18")]
		public SimpleCameraController()
		{
		}
	}
}
namespace SpaceNavigatorDriver
{
	[Token(Token = "0x200002A")]
	public static class QuaternionExtensions
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD2AFCC", Offset = "0xD2AFCC", VA = "0xD2AFCC")]
		public static Quaternion Inverse(this Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD2AFD4", Offset = "0xD2AFD4", VA = "0xD2AFD4")]
		public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD2B038", Offset = "0xD2B038", VA = "0xD2B038")]
		public static Quaternion RotateInSpecifiedCoordinateSystem(Quaternion rotation, Transform referenceCoordSys)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD2B16C", Offset = "0xD2B16C", VA = "0xD2B16C")]
		public static float Pitch(this Quaternion q)
		{
			return default(float);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD2B19C", Offset = "0xD2B19C", VA = "0xD2B19C")]
		public static float Yaw(this Quaternion q)
		{
			return default(float);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD2B1B4", Offset = "0xD2B1B4", VA = "0xD2B1B4")]
		public static float Roll(this Quaternion q)
		{
			return default(float);
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class Locks
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x10")]
		public bool X;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x11")]
		public bool Y;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x12")]
		public bool Z;

		[Token(Token = "0x400010F")]
		[FieldOffset(Offset = "0x13")]
		public bool All;

		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _name;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD2B1E4", Offset = "0xD2B1E4", VA = "0xD2B1E4")]
		public Locks(string name)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD2B20C", Offset = "0xD2B20C", VA = "0xD2B20C")]
		public void Write()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD2B328", Offset = "0xD2B328", VA = "0xD2B328")]
		public void Read()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public enum OperationMode
	{
		[Token(Token = "0x4000112")]
		Fly,
		[Token(Token = "0x4000113")]
		Orbit,
		[Token(Token = "0x4000114")]
		Telekinesis,
		[Token(Token = "0x4000115")]
		GrabMove
	}
	[Token(Token = "0x200002D")]
	public enum CoordinateSystem
	{
		[Token(Token = "0x4000117")]
		Camera,
		[Token(Token = "0x4000118")]
		World,
		[Token(Token = "0x4000119")]
		Parent,
		[Token(Token = "0x400011A")]
		Local
	}
	[Token(Token = "0x200002E")]
	public enum Axis
	{
		[Token(Token = "0x400011C")]
		X,
		[Token(Token = "0x400011D")]
		Y,
		[Token(Token = "0x400011E")]
		Z
	}
	[Token(Token = "0x200002F")]
	public enum DoF
	{
		[Token(Token = "0x4000120")]
		Translation,
		[Token(Token = "0x4000121")]
		Rotation
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public static class Settings
	{
		[Token(Token = "0x4000122")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		public static OperationMode Mode;

		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x4")]
		[SerializeField]
		public static CoordinateSystem CoordSys;

		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x8")]
		public static bool SnapRotation;

		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0xC")]
		public static int SnapAngle;

		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x10")]
		public static bool SnapTranslation;

		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x14")]
		public static float SnapDistance;

		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x18")]
		public static bool LockHorizon;

		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public static Locks NavTranslationLock;

		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		public static Locks NavRotationLock;

		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public static Locks ManipulateTranslationLock;

		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public static Locks ManipulateRotationLock;

		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x40")]
		private static int Gears;

		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x44")]
		public static int CurrentGear;

		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x48")]
		public static List<float> TransSensDefault;

		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x50")]
		public static List<float> TransSensMinDefault;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x58")]
		public static List<float> TransSensMaxDefault;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x60")]
		public static float PlayTransSens;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x68")]
		public static List<float> TransSens;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x70")]
		public static List<float> TransSensMin;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x78")]
		public static List<float> TransSensMax;

		[Token(Token = "0x4000136")]
		public const float RotSensDefault = 1f;

		[Token(Token = "0x4000137")]
		public const float RotSensMinDefault = 0f;

		[Token(Token = "0x4000138")]
		public const float RotSensMaxDefault = 5f;

		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0x80")]
		public static float PlayRotSens;

		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0x84")]
		public static float RotSens;

		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0x88")]
		public static float RotSensMin;

		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x8C")]
		public static float RotSensMax;

		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x90")]
		public static bool RuntimeEditorNav;

		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x94")]
		public static Vector3 FlyInvertTranslation;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xA0")]
		public static Vector3 FlyInvertRotation;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xAC")]
		public static Vector3 OrbitInvertTranslation;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xB8")]
		public static Vector3 OrbitInvertRotation;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xC4")]
		public static Vector3 TelekinesisInvertTranslation;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xD0")]
		public static Vector3 TelekinesisInvertRotation;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xDC")]
		public static Vector3 GrabMoveInvertTranslation;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xE8")]
		public static Vector3 GrabMoveInvertRotation;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xF4")]
		private static Vector2 _scrollPos;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD2B478", Offset = "0xD2B478", VA = "0xD2B478")]
		static Settings()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD2BB00", Offset = "0xD2BB00", VA = "0xD2BB00")]
		public static void OnGUI()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD2BB04", Offset = "0xD2BB04", VA = "0xD2BB04")]
		public static void Write()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD2C1F4", Offset = "0xD2C1F4", VA = "0xD2C1F4")]
		public static void Read()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD2C048", Offset = "0xD2C048", VA = "0xD2C048")]
		private static void WriteAxisInversions(Vector3 translation, Vector3 rotation, string baseName)
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD2C7B8", Offset = "0xD2C7B8", VA = "0xD2C7B8")]
		private static void ReadAxisInversions(ref Vector3 translation, ref Vector3 rotation, string baseName)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD2C95C", Offset = "0xD2C95C", VA = "0xD2C95C")]
		public static bool GetLock(DoF doF, Axis axis)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000031")]
	public abstract class SpaceNavigator : IDisposable
	{
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x0")]
		private static SpaceNavigator _instance;

		[Token(Token = "0x17000036")]
		public static Vector3 Translation
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xD2CB44", Offset = "0xD2CB44", VA = "0xD2CB44")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000037")]
		public static Quaternion Rotation
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0xD2CBE4", Offset = "0xD2CBE4", VA = "0xD2CBE4")]
			get
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x17000038")]
		public static SpaceNavigator Instance
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0xD2CB9C", Offset = "0xD2CB9C", VA = "0xD2CB9C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000126")]
			[Address(RVA = "0xD2CE3C", Offset = "0xD2CE3C", VA = "0xD2CE3C")]
			set
			{
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD2CC3C", Offset = "0xD2CC3C", VA = "0xD2CC3C")]
		public static Quaternion RotationInLocalCoordSys(Transform coordSys)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD2CD74", Offset = "0xD2CD74", VA = "0xD2CD74")]
		public static void SetTranslationSensitivity(float newPlayTransSens)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD2CDD8", Offset = "0xD2CDD8", VA = "0xD2CDD8")]
		public static void SetRotationSensitivity(float newPlayRotSens)
		{
		}

		[Token(Token = "0x6000123")]
		public abstract Vector3 GetTranslation();

		[Token(Token = "0x6000124")]
		public abstract Quaternion GetRotation();

		[Token(Token = "0x6000127")]
		public abstract void Dispose();

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD2CE88", Offset = "0xD2CE88", VA = "0xD2CE88")]
		protected SpaceNavigator()
		{
		}
	}
}
namespace Odders.Chess.Tools
{
	[Token(Token = "0x2000032")]
	public class AnimationTestTool : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Order: 0 = King, Queen, Rook, Bishop, Knight, Pawn")]
		private int startCharacter;

		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] cameras;

		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Order: 0 = King, Queen, Rook, Bishop, Knight, Pawn")]
		private PieceSetting[] pieceSettings;

		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle isWhiteTeamToggle;

		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AudioMixerGroup audioMixer3d;

		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AudioMixerGroup audioMixer2d;

		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform characterPivot;

		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle displacementToggle;

		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Toggle isEnemyWhiteTeamToggle;

		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform enemyPivotFront;

		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform enemyPivotDiagonal;

		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TMP_Dropdown turnDropdown;

		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TMP_Dropdown attackDropdown;

		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Slider subanimationSlider;

		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private ToggleGroup attackToggleGroup;

		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TMP_Dropdown dieDropdown;

		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Slider timeSlider;

		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TextMeshProUGUI txtTime;

		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _MainTex;

		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0xA8")]
		private int _currentIndex;

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0xB0")]
		private GameObject _currentCharacter;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0xB8")]
		private AnimationTestToolDummyPiece _currentAnimatorDummyPiece;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD2CE90", Offset = "0xD2CE90", VA = "0xD2CE90")]
		private void Start()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD2D6A8", Offset = "0xD2D6A8", VA = "0xD2D6A8")]
		private void TimeChange(float value)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD2D738", Offset = "0xD2D738", VA = "0xD2D738")]
		private void Update()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD2D050", Offset = "0xD2D050", VA = "0xD2D050")]
		public void ChangeCamera(int index)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD2D218", Offset = "0xD2D218", VA = "0xD2D218")]
		public void ChangeCharacter(int index)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD2D910", Offset = "0xD2D910", VA = "0xD2D910")]
		public void Walk(int walkType)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD2DF7C", Offset = "0xD2DF7C", VA = "0xD2DF7C")]
		public void BreakIdle(int idleType)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD2D938", Offset = "0xD2D938", VA = "0xD2D938")]
		public void StopWalk()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD2D954", Offset = "0xD2D954", VA = "0xD2D954")]
		public void Turn()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD2D97C", Offset = "0xD2D97C", VA = "0xD2D97C")]
		public void Attack()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD2DF98", Offset = "0xD2DF98", VA = "0xD2DF98")]
		public void Die()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD2E004", Offset = "0xD2E004", VA = "0xD2E004")]
		public AnimationTestTool()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class AnimationTestToolDummyPiece : MonoBehaviour
	{
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _WalkType;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _Walk;

		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _BreakType;

		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _BreakIdle;

		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _Turn;

		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int _TurnAngle;

		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int _Attack;

		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int _AttackToType;

		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int _AttackSubAnimation;

		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int _Die;

		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int _DieByType;

		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x2C")]
		private static readonly int _DieSubAnimation;

		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x18")]
		private Animator _animator;

		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0x20")]
		private Transform _transform;

		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public AudioSource audioSource3d;

		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public AudioSource audioSource2d;

		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x38")]
		public PieceColor pieceColor;

		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x3C")]
		private bool _displacement;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD2F07C", Offset = "0xD2F07C", VA = "0xD2F07C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD2F17C", Offset = "0xD2F17C", VA = "0xD2F17C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD2F1F0", Offset = "0xD2F1F0", VA = "0xD2F1F0")]
		private void RandomBreak()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD2F278", Offset = "0xD2F278", VA = "0xD2F278")]
		private void EndTurn()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD2F27C", Offset = "0xD2F27C", VA = "0xD2F27C")]
		private void DieEvent()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD2F3E0", Offset = "0xD2F3E0", VA = "0xD2F3E0")]
		private void FinishAttack()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD2F3E4", Offset = "0xD2F3E4", VA = "0xD2F3E4")]
		private void DoEffect(UnityEngine.Object effectInfo)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD2F474", Offset = "0xD2F474", VA = "0xD2F474")]
		private void PlaySound(UnityEngine.Object sound)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xD2F4E8", Offset = "0xD2F4E8", VA = "0xD2F4E8")]
		private void PlaySound2d(UnityEngine.Object sound)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD2F55C", Offset = "0xD2F55C", VA = "0xD2F55C")]
		public void BreakIdle(int idleType)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xD2F5F8", Offset = "0xD2F5F8", VA = "0xD2F5F8")]
		public void Walk(int walkType, bool displacement)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD2F6A0", Offset = "0xD2F6A0", VA = "0xD2F6A0")]
		public void StopWalk()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xD2F770", Offset = "0xD2F770", VA = "0xD2F770")]
		public void Turn(int value)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD2F82C", Offset = "0xD2F82C", VA = "0xD2F82C")]
		private int GetAngle(int value)
		{
			return default(int);
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xD2F850", Offset = "0xD2F850", VA = "0xD2F850")]
		public void Attack(int value, int subAnimation)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD2F910", Offset = "0xD2F910", VA = "0xD2F910")]
		public void Die(int value, int subtype)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xD2F9D0", Offset = "0xD2F9D0", VA = "0xD2F9D0")]
		public AnimationTestToolDummyPiece()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class AnimationTool : MonoBehaviour
	{
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform playerPosition;

		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform originPieces;

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform originSockets;

		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		public PieceSetting[] humanWhitePieces;

		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public GameObject[] humanBlackPieces;

		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float boardGap;

		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TriggerInteractor triggerInteractor;

		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float displacementTime;

		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RuntimeAnimatorController animatorController;

		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x68")]
		private PieceModel _queenPieceModel;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x70")]
		private Animator _queenAnimator;

		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x78")]
		private Sequence _queenSequence;

		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x80")]
		private PieceModel[] _queensDie;

		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _Walk;

		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _Atack;

		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _Die;

		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x88")]
		private TriggerInteractor _triggerInteractorLeft;

		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x90")]
		private TriggerInteractor _triggerInteractorRight;

		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x98")]
		private GameObject _socketPrefab;

		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0xA0")]
		private ChessPlayerManagerController _playerManager;

		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0xA8")]
		private GameObject _cameraFloorOffsetObject;

		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0xB0")]
		private PieceModel.Factory _pieceModelFactory;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0xB8")]
		private GameInfo _gameInfo;

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD2FCB8", Offset = "0xD2FCB8", VA = "0xD2FCB8")]
		[Inject]
		public void Construct(PieceModel.Factory pieceModelFactory, [Inject(Id = "baseSocket")] GameObject socketPrefab, GameObject cameraFloorOffsetObject, ChessPlayerManagerController playerManager, GameInfo gameInfo)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD2FCC8", Offset = "0xD2FCC8", VA = "0xD2FCC8")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD30258", Offset = "0xD30258", VA = "0xD30258")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD302E4", Offset = "0xD302E4", VA = "0xD302E4")]
		private void CheckQueensDie()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xD2FE24", Offset = "0xD2FE24", VA = "0xD2FE24")]
		private void CreateQueen()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xD300F4", Offset = "0xD300F4", VA = "0xD300F4")]
		private TriggerInteractor CreateInteractorInHand(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xD30750", Offset = "0xD30750", VA = "0xD30750")]
		private void UpdateQueenPosition(BoardPosition position)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xD30EA0", Offset = "0xD30EA0", VA = "0xD30EA0")]
		private void NormalSequence(Sequence sequence, BoardPosition position)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xD30850", Offset = "0xD30850", VA = "0xD30850")]
		private void AtackSequence(Sequence sequence, BoardPosition position)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xD30680", Offset = "0xD30680", VA = "0xD30680")]
		private void SetPosition(GameObject prefab, Piece piece)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xD2FF94", Offset = "0xD2FF94", VA = "0xD2FF94")]
		private void CreateSocket(int i, int j)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xD31218", Offset = "0xD31218", VA = "0xD31218")]
		private Vector3 GetRealBoardPosition(BoardPosition position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0xD31250", Offset = "0xD31250", VA = "0xD31250")]
		public AnimationTool()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class LoadDemoScene : MonoBehaviour
	{
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LoadSceneComponent loadSceneComponent;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x20")]
		private GameStarter.Settings _gameStarterSettings;

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xD31950", Offset = "0xD31950", VA = "0xD31950")]
		[Inject]
		private void Construct(GameStarter.Settings gameStarterSettings)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xD31958", Offset = "0xD31958", VA = "0xD31958")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xD31A08", Offset = "0xD31A08", VA = "0xD31A08")]
		public LoadDemoScene()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class LowPerformanceDeactivator : MonoBehaviour
	{
		[Token(Token = "0x6000166")]
		[Address(RVA = "0xD31A40", Offset = "0xD31A40", VA = "0xD31A40")]
		[Inject]
		private void Construct([InjectOptional] PlatformManager platformManager)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0xD31A88", Offset = "0xD31A88", VA = "0xD31A88")]
		public LowPerformanceDeactivator()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class PauseEditor : MonoBehaviour
	{
		[Token(Token = "0x6000168")]
		[Address(RVA = "0xD31A90", Offset = "0xD31A90", VA = "0xD31A90")]
		public PauseEditor()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public class PieceSizeTool : MonoBehaviour
	{
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform playerPosition;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform originPieces;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform originSockets;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string fenToCreate;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool startWithHumanPieces;

		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform board;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float boardGap;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x4C")]
		private float _currentBoardGap;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x50")]
		[Header("Piece Normal Size UI")]
		public Button activateNormalPiecesButton;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x58")]
		public TextMeshProUGUI totalCurrentPiecesSliderValue;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x60")]
		public Slider totalSlider;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x68")]
		public float kingRealSize;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x70")]
		public Slider kingSlider;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x78")]
		public TextMeshProUGUI kingFinalPiecesSize;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x80")]
		public TextMeshProUGUI kingCurrentSliderValue;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x88")]
		public float queenRealSize;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x90")]
		public Slider queenSlider;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x98")]
		public TextMeshProUGUI queenFinalPiecesSize;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xA0")]
		public TextMeshProUGUI queenCurrentSliderValue;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0xA8")]
		public float rookRealSize;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0xB0")]
		public Slider rookSlider;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0xB8")]
		public TextMeshProUGUI rookFinalPiecesSize;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0xC0")]
		public TextMeshProUGUI rookCurrentSliderValue;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0xC8")]
		public float bishopRealSize;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0xD0")]
		public Slider bishopSlider;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0xD8")]
		public TextMeshProUGUI bishopFinalPiecesSize;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0xE0")]
		public TextMeshProUGUI bishopCurrentSliderValue;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0xE8")]
		public float knightRealSize;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0xF0")]
		public Slider knightSlider;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0xF8")]
		public TextMeshProUGUI knightFinalPiecesSize;

		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x100")]
		public TextMeshProUGUI knightCurrentSliderValue;

		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x108")]
		public float pawnRealSize;

		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x110")]
		public Slider pawnSlider;

		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x118")]
		public TextMeshProUGUI pawnFinalPiecesSize;

		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x120")]
		public TextMeshProUGUI pawnCurrentSliderValue;

		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x128")]
		[Header("Piece Human Size UI")]
		public Button activateHumanPiecesButton;

		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x130")]
		public PieceSetting[] humanWhitePieces;

		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x138")]
		public GameObject[] humanBlackPieces;

		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x140")]
		public RuntimeAnimatorController pieceAnimator;

		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x148")]
		public TextMeshProUGUI totalHumanCurrentPiecesSliderValue;

		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x150")]
		public Slider totalHumanSlider;

		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x158")]
		public float kingHumanRealSize;

		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x160")]
		public Slider kingHumanSlider;

		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x168")]
		public TextMeshProUGUI kingHumanFinalPiecesSize;

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x170")]
		public TextMeshProUGUI kingHumanCurrentSliderValue;

		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x178")]
		public float queenHumanRealSize;

		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x180")]
		public Slider queenHumanSlider;

		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x188")]
		public TextMeshProUGUI queenHumanFinalPiecesSize;

		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x190")]
		public TextMeshProUGUI queenHumanCurrentSliderValue;

		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x198")]
		public float rookHumanRealSize;

		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x1A0")]
		public Slider rookHumanSlider;

		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x1A8")]
		public TextMeshProUGUI rookHumanFinalPiecesSize;

		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0x1B0")]
		public TextMeshProUGUI rookHumanCurrentSliderValue;

		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0x1B8")]
		public float bishopHumanRealSize;

		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0x1C0")]
		public Slider bishopHumanSlider;

		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0x1C8")]
		public TextMeshProUGUI bishopHumanFinalPiecesSize;

		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0x1D0")]
		public TextMeshProUGUI bishopHumanCurrentSliderValue;

		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x1D8")]
		public float knightHumanRealSize;

		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0x1E0")]
		public Slider knightHumanSlider;

		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x1E8")]
		public TextMeshProUGUI knightHumanFinalPiecesSize;

		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x1F0")]
		public TextMeshProUGUI knightHumanCurrentSliderValue;

		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x1F8")]
		public float pawnHumanRealSize;

		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x200")]
		public Slider pawnHumanSlider;

		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x208")]
		public TextMeshProUGUI pawnHumanFinalPiecesSize;

		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x210")]
		public TextMeshProUGUI pawnHumanCurrentSliderValue;

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x218")]
		[Header("Board Size UI")]
		public float distanceIncrement;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x220")]
		public TextMeshProUGUI startPosition;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x228")]
		public float boardRealSize;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x230")]
		public TextMeshProUGUI currentBoardSize;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x238")]
		public TextMeshProUGUI currentBoardSquareSize;

		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x240")]
		public TextMeshProUGUI currentBoardSliderValue;

		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x248")]
		public TextMeshProUGUI currentBoardDistance;

		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x250")]
		private GameObject _socketPrefab;

		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x258")]
		private GameObject _cameraFloorOffsetObject;

		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x260")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x268")]
		private List<ChessPieceInteractable> _normalPieces;

		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x270")]
		private List<ChessPieceInteractable> _humanPieces;

		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x278")]
		private PieceModel.Factory _pieceModelFactory;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xD31A98", Offset = "0xD31A98", VA = "0xD31A98")]
		[Inject]
		public void Construct(PieceModel.Factory pieceModelFactory, [Inject(Id = "baseSocket")] GameObject socketPrefab, GameObject cameraFloorOffsetObject)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xD31AA8", Offset = "0xD31AA8", VA = "0xD31AA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xD335C8", Offset = "0xD335C8", VA = "0xD335C8")]
		public void ChangePiecesVisibility(bool activeNormals)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xD33384", Offset = "0xD33384", VA = "0xD33384")]
		private void CreateSocket(int i, int j)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xD334EC", Offset = "0xD334EC", VA = "0xD334EC")]
		private void SetPosition(GameObject prefab, Piece piece)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xD33860", Offset = "0xD33860", VA = "0xD33860")]
		private Vector3 GetRealBoardPosition(BoardPosition position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xD33890", Offset = "0xD33890", VA = "0xD33890")]
		public void UpdatePieceSize(float value, float globalValue, TextMeshProUGUI finalText, TextMeshProUGUI sliderText, float realSize, List<ChessPieceInteractable> pieces)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xD33BC8", Offset = "0xD33BC8", VA = "0xD33BC8")]
		public void UpdateBoardSize(float value)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xD338D8", Offset = "0xD338D8", VA = "0xD338D8")]
		private void UpdateUiInfo(TextMeshProUGUI currentValue, TextMeshProUGUI sliderValue, float realSize, float value, float globalValue)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xD33E20", Offset = "0xD33E20", VA = "0xD33E20")]
		public void AddDistance(int sing)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xD33A44", Offset = "0xD33A44", VA = "0xD33A44")]
		private void ApplyPiecesScale(float scale, List<ChessPieceInteractable> pieces)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xD332E0", Offset = "0xD332E0", VA = "0xD332E0")]
		private void FormatPlayerPosition(TextMeshProUGUI uiText)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xD33EF0", Offset = "0xD33EF0", VA = "0xD33EF0")]
		public PieceSizeTool()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class QuestLowPerformance : MonoBehaviour
	{
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		public OVRManager.FixedFoveatedRenderingLevel fixedFoveatedRenderingLevel;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0.5f, 2f)]
		public float resolutionScale;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x20")]
		private PlatformManager _platformManager;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x28")]
		public TMP_Text textValue;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Toggle toggleAnimator;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] animators;

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xD362F8", Offset = "0xD362F8", VA = "0xD362F8")]
		[Inject]
		private void Construct(PlatformManager platformManager)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xD36300", Offset = "0xD36300", VA = "0xD36300")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xD36488", Offset = "0xD36488", VA = "0xD36488")]
		public void SetResolutionScale(float resolution)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xD36430", Offset = "0xD36430", VA = "0xD36430")]
		public void SetFovatedRendering(OVRManager.FixedFoveatedRenderingLevel fixedFRL)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xD364B4", Offset = "0xD364B4", VA = "0xD364B4")]
		public void SetText(float value)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xD3656C", Offset = "0xD3656C", VA = "0xD3656C")]
		public void SetFovatedRendering(int value)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xD36570", Offset = "0xD36570", VA = "0xD36570")]
		public QuestLowPerformance()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class TriggerInteractor : MonoBehaviour
	{
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputActionProperty interactActionRight;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputActionProperty interactActionLeft;

		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float minDistance;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<BoardPosition, PieceSocket> _socketsDictionary;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x58")]
		public Action<BoardPosition> targetPosition;

		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x60")]
		private Transform _transform;

		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x68")]
		private MeshRenderer _mesh;

		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x70")]
		private MeshRenderer _meshChildren;

		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x78")]
		private PieceSocket _savedSocket;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _Color;

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xD36670", Offset = "0xD36670", VA = "0xD36670")]
		private void Start()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xD36700", Offset = "0xD36700", VA = "0xD36700")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xD367EC", Offset = "0xD367EC", VA = "0xD367EC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xD36940", Offset = "0xD36940", VA = "0xD36940")]
		private void Update()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xD36D68", Offset = "0xD36D68", VA = "0xD36D68")]
		private void ClearSockets()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xD36ED8", Offset = "0xD36ED8", VA = "0xD36ED8")]
		private void DoAction(InputAction.CallbackContext obj)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xD370FC", Offset = "0xD370FC", VA = "0xD370FC")]
		public void InitSockets(Dictionary<BoardPosition, PieceSocket> sockets)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xD37104", Offset = "0xD37104", VA = "0xD37104")]
		public TriggerInteractor()
		{
		}
	}
}
namespace Odders.Chess.UI
{
	[Token(Token = "0x2000043")]
	public class EmptyScene : MonoBehaviour
	{
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SceneReference sceneReference;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xD3733C", Offset = "0xD3733C", VA = "0xD3733C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xD3739C", Offset = "0xD3739C", VA = "0xD3739C")]
		public void LoadScene()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0xD37408", Offset = "0xD37408", VA = "0xD37408")]
		public EmptyScene()
		{
		}
	}
}
namespace Odders.UiComponents.OptionsToggles
{
	[Token(Token = "0x2000044")]
	public class FrequencyToggle : ChessBaseToggle
	{
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x150")]
		public float value;

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xD37410", Offset = "0xD37410", VA = "0xD37410")]
		public FrequencyToggle()
		{
		}
	}
}
