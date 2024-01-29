using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EasyRoads3Dv3;
using Fusion;
using Fusion.Sockets;
using Fusion.StatsInternal;
using HurricaneVR.Framework.Core.HandPoser;
using HurricaneVR.Framework.Core.Player;
using HurricaneVR.Framework.Weapons.Bow;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class ExplosionsLightCurves : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve LightCurve;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float GraphTimeMultiplier;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float GraphIntensityMultiplier;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool canUpdate;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light lightSource;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xB6BF80", Offset = "0xB6BF80", VA = "0xB6BF80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB6C004", Offset = "0xB6C004", VA = "0xB6C004")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB6C028", Offset = "0xB6C028", VA = "0xB6C028")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB6C09C", Offset = "0xB6C09C", VA = "0xB6C09C")]
	public ExplosionsLightCurves()
	{
	}
}
[Token(Token = "0x2000003")]
public class TemporarySkewerEquipper : MonoBehaviour
{
	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject skewer;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject weapon;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xB6C0E4", Offset = "0xB6C0E4", VA = "0xB6C0E4")]
	public void EquipSkewer()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB6C11C", Offset = "0xB6C11C", VA = "0xB6C11C")]
	public void EquipLastWeapon()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB6C154", Offset = "0xB6C154", VA = "0xB6C154")]
	public TemporarySkewerEquipper()
	{
	}
}
[Token(Token = "0x2000004")]
public class TestPathPanelController : MonoBehaviour
{
	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> playerPathTesters;

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xB6C15C", Offset = "0xB6C15C", VA = "0xB6C15C")]
	public void TestPlayerPath(int id)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB6C298", Offset = "0xB6C298", VA = "0xB6C298")]
	public TestPathPanelController()
	{
	}
}
[Token(Token = "0x2000005")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class AGGlobalSettings : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float AOIntensity;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float TranslucencyIntensity;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float TranslucencyDistance;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool EnableTintColor;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float TintToggle;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture2D TintNoiseTexture;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float TintNoiseTile;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float TintNoiseContrast;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xB6C2A0", Offset = "0xB6C2A0", VA = "0xB6C2A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB6C318", Offset = "0xB6C318", VA = "0xB6C318")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB6C46C", Offset = "0xB6C46C", VA = "0xB6C46C")]
	public AGGlobalSettings()
	{
	}
}
[Token(Token = "0x2000006")]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[DisallowMultipleComponent]
public class AGGlobalSnow : MonoBehaviour
{
	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableGlobalWind;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float WindToggle;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float WindGrassAmplitude;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float WindGrassSpeed;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float WindGrassScale;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float WindGrassStiffness;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool EnableTintColor;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float TintToggle;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture2D TintNoiseTexture;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float TintNoiseTile;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float TintNoiseContrast;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float SnowPropsIntensity;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float SnowPropsOffset;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float SnowPropsContrast;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float SnowMinimumHeight;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float SnowFadeHeight;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xB6C490", Offset = "0xB6C490", VA = "0xB6C490")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB6C508", Offset = "0xB6C508", VA = "0xB6C508")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB6C7BC", Offset = "0xB6C7BC", VA = "0xB6C7BC")]
	public AGGlobalSnow()
	{
	}
}
[Token(Token = "0x2000007")]
[RequireComponent(typeof(MeshRenderer))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class AGGlobalSnowGrass : MonoBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float SnowGrassIntensity;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SnowGrassOffset;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float SnowGrassContrast;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xB6C7F8", Offset = "0xB6C7F8", VA = "0xB6C7F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB6C870", Offset = "0xB6C870", VA = "0xB6C870")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB6C90C", Offset = "0xB6C90C", VA = "0xB6C90C")]
	public AGGlobalSnowGrass()
	{
	}
}
[Token(Token = "0x2000008")]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
public class AGGlobalSnowHeight : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float SnowMinimumHeight;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SnowFadeHeight;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xB6C924", Offset = "0xB6C924", VA = "0xB6C924")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB6C99C", Offset = "0xB6C99C", VA = "0xB6C99C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB6CA14", Offset = "0xB6CA14", VA = "0xB6CA14")]
	public AGGlobalSnowHeight()
	{
	}
}
[Token(Token = "0x2000009")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
public class AGGlobalSnowProps : MonoBehaviour
{
	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float SnowPropsIntensity;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SnowPropsOffset;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float SnowPropsContrast;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xB6CA28", Offset = "0xB6CA28", VA = "0xB6CA28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB6CAA0", Offset = "0xB6CAA0", VA = "0xB6CAA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB6CB3C", Offset = "0xB6CB3C", VA = "0xB6CB3C")]
	public AGGlobalSnowProps()
	{
	}
}
[Token(Token = "0x200000A")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class AGGlobalSnowTree : MonoBehaviour
{
	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float SnowTreeIntensity;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SnowTreeOffset;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float SnowTreeContrast;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float SnowTreeArrowDirection;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xB6CB54", Offset = "0xB6CB54", VA = "0xB6CB54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB6CBCC", Offset = "0xB6CBCC", VA = "0xB6CBCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB6CC94", Offset = "0xB6CC94", VA = "0xB6CC94")]
	public AGGlobalSnowTree()
	{
	}
}
[Token(Token = "0x200000B")]
[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(MeshRenderer))]
public class AGGlobalWind : MonoBehaviour
{
	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableGlobalWind;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float WindToggle;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float WindTreeAmplitude;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float WindTreeSpeed;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float WindTreeScale;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float WindTreeStiffness;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float WindGrassAmplitude;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float WindGrassSpeed;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float WindGrassScale;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float WindGrassStiffness;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xB6CCA4", Offset = "0xB6CCA4", VA = "0xB6CCA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB6CD1C", Offset = "0xB6CD1C", VA = "0xB6CD1C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB6CF0C", Offset = "0xB6CF0C", VA = "0xB6CF0C")]
	public AGGlobalWind()
	{
	}
}
[Token(Token = "0x200000C")]
[NetworkBehaviourWeaved(1)]
public class CameraOffsetSynchronizer : NetworkBehaviour
{
	[Token(Token = "0x4000038")]
	private const float cameraOffsetSetupDelay = 0.1f;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private HVRCameraRig cameraRig;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float _Offset;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private WaitForSeconds waitForCameraOffsetSetupDelay;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<CameraOffsetSynchronizer> $IL2CPP_CHANGED;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<CameraOffsetSynchronizer> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<CameraOffsetSynchronizer> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x17000001")]
	[Networked(OnChanged = "OnCameraOffsetChange", OnChangedTargets = OnChangedTargets.Proxies)]
	[NetworkedWeaved(0, 1)]
	public float Offset
	{
		[Token(Token = "0x600001F")]
		[Address(RVA = "0xB6CF30", Offset = "0xB6CF30", VA = "0xB6CF30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB6CFA4", Offset = "0xB6CFA4", VA = "0xB6CFA4")]
		set
		{
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB6D044", Offset = "0xB6D044", VA = "0xB6D044")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB6D11C", Offset = "0xB6D11C", VA = "0xB6D11C", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB6D15C", Offset = "0xB6D15C", VA = "0xB6D15C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB6D13C", Offset = "0xB6D13C", VA = "0xB6D13C")]
	private void SetCameraOffset()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB6D25C", Offset = "0xB6D25C", VA = "0xB6D25C")]
	[Preserve]
	private static void OnCameraOffsetChange(Changed<CameraOffsetSynchronizer> changed)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB6D1E8", Offset = "0xB6D1E8", VA = "0xB6D1E8")]
	private IEnumerator SetCameraOffsetAfterSpawn()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB6D2D8", Offset = "0xB6D2D8", VA = "0xB6D2D8")]
	public CameraOffsetSynchronizer()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB6D2E0", Offset = "0xB6D2E0", VA = "0xB6D2E0", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB6D2E8", Offset = "0xB6D2E8", VA = "0xB6D2E8", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x200000E")]
public class DynamicBowOffset : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float offsetValueY;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float offsetValueX;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private HVRBowBase hVRBowBase;

	[Token(Token = "0x17000004")]
	public float OffsetValueY
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0xB6D434", Offset = "0xB6D434", VA = "0xB6D434")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000005")]
	public float OffsetValueX
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0xB6D43C", Offset = "0xB6D43C", VA = "0xB6D43C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000006")]
	public HVRBowBase HVRBowBase
	{
		[Token(Token = "0x6000032")]
		[Address(RVA = "0xB6D444", Offset = "0xB6D444", VA = "0xB6D444")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB6D44C", Offset = "0xB6D44C", VA = "0xB6D44C")]
	public DynamicBowOffset()
	{
	}
}
[Token(Token = "0x200000F")]
public class DynamicBowOffsetController : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform LeftOffset;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform RightOffset;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform HandTransformLeft;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform HandTranformRight;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private InventoryController inventoryController;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Camera mainCamera;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private DynamicBowOffset offsetObject;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float horizontalOffset;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float verticalOffset;

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB6D454", Offset = "0xB6D454", VA = "0xB6D454")]
	private void Start()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB6D4B4", Offset = "0xB6D4B4", VA = "0xB6D4B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB6D59C", Offset = "0xB6D59C", VA = "0xB6D59C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB6D890", Offset = "0xB6D890", VA = "0xB6D890")]
	private void OnItemChange(ItemBehavior itemBehavior)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB6D8F4", Offset = "0xB6D8F4", VA = "0xB6D8F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB6D9FC", Offset = "0xB6D9FC", VA = "0xB6D9FC")]
	private bool ShouldProceedOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB6D69C", Offset = "0xB6D69C", VA = "0xB6D69C")]
	private void ResetOffset()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB6DADC", Offset = "0xB6DADC", VA = "0xB6DADC")]
	public DynamicBowOffsetController()
	{
	}
}
[Token(Token = "0x2000010")]
public class ERVegetationStudio : ScriptableObject
{
	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB6DAE4", Offset = "0xB6DAE4", VA = "0xB6DAE4")]
	public static bool VegetationStudio()
	{
		return default(bool);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB6DAEC", Offset = "0xB6DAEC", VA = "0xB6DAEC")]
	public static bool VegetationStudioPro()
	{
		return default(bool);
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB6DAF4", Offset = "0xB6DAF4", VA = "0xB6DAF4")]
	public ERVegetationStudio()
	{
	}
}
[Token(Token = "0x2000011")]
public class runtimeScript : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ERRoadNetwork roadNetwork;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ERRoad road;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject go;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currentElement;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distance;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB6DAFC", Offset = "0xB6DAFC", VA = "0xB6DAFC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB6DE24", Offset = "0xB6DE24", VA = "0xB6DE24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB6DF0C", Offset = "0xB6DF0C", VA = "0xB6DF0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB6DF9C", Offset = "0xB6DF9C", VA = "0xB6DF9C")]
	public runtimeScript()
	{
	}
}
[Token(Token = "0x2000012")]
[RequireComponent(typeof(VRIK))]
public class HVRVRIKTeleportHandler : MonoBehaviour
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRIK VRIK;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB6DFAC", Offset = "0xB6DFAC", VA = "0xB6DFAC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB6E004", Offset = "0xB6E004", VA = "0xB6E004")]
	public void AfterTeleport()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xB6E028", Offset = "0xB6E028", VA = "0xB6E028")]
	public HVRVRIKTeleportHandler()
	{
	}
}
[Token(Token = "0x2000013")]
internal class UVTextureAnimator : MonoBehaviour
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Rows;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Columns;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Fps;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int OffsetMat;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float StartDelay;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool IsInterpolateFrames;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BFX_TextureShaderProperties[] TextureNames;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] TextureNamesCached;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve FrameOverTime;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer currentRenderer;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Projector projector;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material instanceMaterial;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float animationStartTime;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool canUpdate;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int previousIndex;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int totalFrames;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float currentInterpolatedTime;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int currentIndex;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 size;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isInitialized;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool startDelayIsBroken;

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xB6E030", Offset = "0xB6E030", VA = "0xB6E030")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xB6E1FC", Offset = "0xB6E1FC", VA = "0xB6E1FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xB6E354", Offset = "0xB6E354", VA = "0xB6E354")]
	private void Update()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xB6E364", Offset = "0xB6E364", VA = "0xB6E364")]
	private void ManualUpdate()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xB6E8AC", Offset = "0xB6E8AC", VA = "0xB6E8AC")]
	private void StartDelayFunc()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xB6E040", Offset = "0xB6E040", VA = "0xB6E040")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB6E8D0", Offset = "0xB6E8D0", VA = "0xB6E8D0")]
	private void InitializeMaterial()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xB6E39C", Offset = "0xB6E39C", VA = "0xB6E39C")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB6E590", Offset = "0xB6E590", VA = "0xB6E590")]
	private void SetSpriteAnimation()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB6E754", Offset = "0xB6E754", VA = "0xB6E754")]
	private void SetSpriteAnimationIterpolated()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB6EB30", Offset = "0xB6EB30", VA = "0xB6EB30")]
	public UVTextureAnimator()
	{
	}
}
[Token(Token = "0x2000014")]
public enum BFX_TextureShaderProperties
{
	[Token(Token = "0x400006B")]
	_MainTex,
	[Token(Token = "0x400006C")]
	_DistortTex,
	[Token(Token = "0x400006D")]
	_Mask,
	[Token(Token = "0x400006E")]
	_Cutout,
	[Token(Token = "0x400006F")]
	_CutoutTex,
	[Token(Token = "0x4000070")]
	_Bump,
	[Token(Token = "0x4000071")]
	_BumpTex,
	[Token(Token = "0x4000072")]
	_EmissionTex
}
[Token(Token = "0x2000015")]
[NetworkBehaviourWeaved(1)]
public class MasterHeadsetStateChecker : NetworkBehaviour, IStateAuthorityChanged
{
	[Token(Token = "0x4000073")]
	private const float defaultPlayerNotMovingTimer = 1f;

	[Token(Token = "0x4000074")]
	private const float timeToCheckMasterHeadsetState = 0.1f;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private MasterClientTimeoutController masterClientTimeoutController;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool detectRemoveOfMasterHeadset;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 previousPlayerPosition;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float playerNotMovingTimer;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float lastCheckOfMasterHeadsetState;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float treshold;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private bool _IsMasterHeadsetRemoved;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<MasterHeadsetStateChecker> $IL2CPP_CHANGED;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<MasterHeadsetStateChecker> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<MasterHeadsetStateChecker> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x17000007")]
	[Networked(OnChanged = "OnIsMasterHeadsetRemovedChanged", OnChangedTargets = OnChangedTargets.Proxies)]
	[NetworkedWeaved(0, 1)]
	public bool IsMasterHeadsetRemoved
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0xB6EBD4", Offset = "0xB6EBD4", VA = "0xB6EBD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xB6EC40", Offset = "0xB6EC40", VA = "0xB6EC40")]
		set
		{
		}
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB6ECA8", Offset = "0xB6ECA8", VA = "0xB6ECA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB6ECB8", Offset = "0xB6ECB8", VA = "0xB6ECB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB6EEAC", Offset = "0xB6EEAC", VA = "0xB6EEAC", Slot = "19")]
	public void StateAuthorityChanged()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB6ED20", Offset = "0xB6ED20", VA = "0xB6ED20")]
	private void CheckMasterHeadsetState()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB6EF10", Offset = "0xB6EF10", VA = "0xB6EF10")]
	[Preserve]
	private static void OnIsMasterHeadsetRemovedChanged(Changed<MasterHeadsetStateChecker> changed)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB6EFB8", Offset = "0xB6EFB8", VA = "0xB6EFB8")]
	public MasterHeadsetStateChecker()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB6F028", Offset = "0xB6F028", VA = "0xB6F028", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB6F030", Offset = "0xB6F030", VA = "0xB6F030", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000016")]
public class FusionGraph : FusionGraphBase
{
	[Token(Token = "0x2000017")]
	public enum Layouts
	{
		[Token(Token = "0x40000A3")]
		Auto,
		[Token(Token = "0x40000A4")]
		FullAuto,
		[Token(Token = "0x40000A5")]
		FullNoOverlap,
		[Token(Token = "0x40000A6")]
		CenteredAuto,
		[Token(Token = "0x40000A7")]
		CenteredNoGraph,
		[Token(Token = "0x40000A8")]
		CenteredNoOverlap,
		[Token(Token = "0x40000A9")]
		CompactAuto,
		[Token(Token = "0x40000AA")]
		CompactNoGraph
	}

	[Token(Token = "0x2000018")]
	public enum ShowGraphOptions
	{
		[Token(Token = "0x40000AC")]
		Never,
		[Token(Token = "0x40000AD")]
		OverlayOnly,
		[Token(Token = "0x40000AE")]
		Always
	}

	[Token(Token = "0x2000019")]
	private enum ShaderType
	{
		[Token(Token = "0x40000B0")]
		None,
		[Token(Token = "0x40000B1")]
		Overlay,
		[Token(Token = "0x40000B2")]
		GameObject
	}

	[Token(Token = "0x400007F")]
	private const int GRPH_TOP_PAD = 36;

	[Token(Token = "0x4000080")]
	private const int GRPH_BTM_PAD = 36;

	[Token(Token = "0x4000081")]
	private const int HIDE_XTRAS_WDTH = 200;

	[Token(Token = "0x4000082")]
	private const int INTERMITTENT_DATA_ARRAYSIZE = 128;

	[Token(Token = "0x4000083")]
	private const int EXPAND_GRPH_THRESH = 112;

	[Token(Token = "0x4000084")]
	private const int COMPACT_THRESH = 52;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public float Height;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private Layouts _layout;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ShowGraphOptions _showGraph;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float Padding;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private bool _alwaysExpandGraph;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	[SerializeField]
	private bool _showUITargets;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image GraphImg;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text LabelMin;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Text LabelMax;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Text LabelAvg;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Text LabelLast;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text LabelPer;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Dropdown _viewDropdown;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button _avgBttn;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float _min;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float _max;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float[] _values;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float[] _intensity;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float[] _histogram;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<int> DropdownLookup;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private FusionGraphVisualization _graphVisualization;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private ShaderType _currentShader;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private (int, float)[] _cachedValues;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private double _lastCachedTickTime;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int _lastCachedTick;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int _histoHighestUsedBucketIndex;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int _histoAvgSampleCount;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private double _histoStepInverse;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private double _histoAvg;

	[Token(Token = "0x17000008")]
	private static Shader Shader
	{
		[Token(Token = "0x600005B")]
		[Address(RVA = "0xB6F04C", Offset = "0xB6F04C", VA = "0xB6F04C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000009")]
	public Layouts Layout
	{
		[Token(Token = "0x600005C")]
		[Address(RVA = "0xB6F0A4", Offset = "0xB6F0A4", VA = "0xB6F0A4")]
		get
		{
			return default(Layouts);
		}
		[Token(Token = "0x600005D")]
		[Address(RVA = "0xB6F0AC", Offset = "0xB6F0AC", VA = "0xB6F0AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public ShowGraphOptions ShowGraph
	{
		[Token(Token = "0x600005E")]
		[Address(RVA = "0xB6F0BC", Offset = "0xB6F0BC", VA = "0xB6F0BC")]
		get
		{
			return default(ShowGraphOptions);
		}
		[Token(Token = "0x600005F")]
		[Address(RVA = "0xB6F0C4", Offset = "0xB6F0C4", VA = "0xB6F0C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public bool AlwaysExpandGraph
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0xB6F0EC", Offset = "0xB6F0EC", VA = "0xB6F0EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0xB6F0F4", Offset = "0xB6F0F4", VA = "0xB6F0F4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public FusionGraphVisualization GraphVisualization
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0xB6F9CC", Offset = "0xB6F9CC", VA = "0xB6F9CC")]
		set
		{
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB6F120", Offset = "0xB6F120", VA = "0xB6F120", Slot = "14")]
	protected override bool TryConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB6F9D4", Offset = "0xB6F9D4", VA = "0xB6F9D4")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xB6FCB4", Offset = "0xB6FCB4", VA = "0xB6FCB4")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xB6FD50", Offset = "0xB6FD50", VA = "0xB6FD50", Slot = "10")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xB6FE5C", Offset = "0xB6FE5C", VA = "0xB6FE5C")]
	public void OnDropdownChanged(int value)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xB6FEC8", Offset = "0xB6FEC8", VA = "0xB6FEC8")]
	private void ResetShaderButton()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xB6FA1C", Offset = "0xB6FA1C", VA = "0xB6FA1C")]
	private void ResetGraphShader()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xB70174", Offset = "0xB70174", VA = "0xB70174", Slot = "11")]
	public override void CyclePer()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xB6F7E4", Offset = "0xB6F7E4", VA = "0xB6F7E4")]
	private void SetPerText()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xB70200", Offset = "0xB70200", VA = "0xB70200", Slot = "13")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xB704F8", Offset = "0xB704F8", VA = "0xB704F8")]
	private void UpdateContinuousTick(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xB70B38", Offset = "0xB70B38", VA = "0xB70B38")]
	private void UpdateIntermittentTick(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xB71058", Offset = "0xB71058", VA = "0xB71058")]
	private void UpdateIntermittentTime(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xB71D68", Offset = "0xB71D68", VA = "0xB71D68")]
	private void ApplyScaling(ref float min, ref float max)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xB71E88", Offset = "0xB71E88", VA = "0xB71E88")]
	private void UpdateUiText(float min, float max, float avg, float last)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xB72564", Offset = "0xB72564", VA = "0xB72564")]
	private float GetIntermittentAverageInfo(ref IStatsBuffer data, float sum)
	{
		return default(float);
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xB71304", Offset = "0xB71304", VA = "0xB71304")]
	private void UpdateTickValueHistogram(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xB7281C", Offset = "0xB7281C", VA = "0xB7281C")]
	public static FusionGraph Create(FusionStats iFusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, RectTransform parentRT)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xB72940", Offset = "0xB72940", VA = "0xB72940")]
	public void Generate(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform root)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xB73034", Offset = "0xB73034", VA = "0xB73034", Slot = "12")]
	public override void CalculateLayout()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xB73CB4", Offset = "0xB73CB4", VA = "0xB73CB4")]
	public FusionGraph()
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteAlways]
public class FusionStats : Fusion.Behaviour
{
	[Token(Token = "0x200001B")]
	public enum StatCanvasTypes
	{
		[Token(Token = "0x4000121")]
		Overlay,
		[Token(Token = "0x4000122")]
		GameObject
	}

	[Token(Token = "0x200001C")]
	public enum DefaultLayouts
	{
		[Token(Token = "0x4000124")]
		Custom,
		[Token(Token = "0x4000125")]
		Left,
		[Token(Token = "0x4000126")]
		Right,
		[Token(Token = "0x4000127")]
		UpperLeft,
		[Token(Token = "0x4000128")]
		UpperRight,
		[Token(Token = "0x4000129")]
		Full
	}

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<NetworkRunner, List<FusionStats>> _statsForRunnerLookup;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, FusionStats> _activeGuids;

	[Token(Token = "0x40000B5")]
	public const Simulation.Statistics.SimStatFlags DefaultSimStatsMask = Simulation.Statistics.SimStatFlags.ForwardSimCount | Simulation.Statistics.SimStatFlags.ResimCount | Simulation.Statistics.SimStatFlags.PacketSize;

	[Token(Token = "0x40000B6")]
	private const int SCREEN_SCALE_W = 1080;

	[Token(Token = "0x40000B7")]
	private const int SCREEN_SCALE_H = 1080;

	[Token(Token = "0x40000B8")]
	private const float TEXT_MARGIN = 0.25f;

	[Token(Token = "0x40000B9")]
	private const float TITLE_HEIGHT = 20f;

	[Token(Token = "0x40000BA")]
	private const int MARGIN = 6;

	[Token(Token = "0x40000BB")]
	private const int PAD = 10;

	[Token(Token = "0x40000BC")]
	private const string PLAY_TEXT = "PLAY";

	[Token(Token = "0x40000BD")]
	private const string PAUS_TEXT = "PAUSE";

	[Token(Token = "0x40000BE")]
	private const string SHOW_TEXT = "SHOW";

	[Token(Token = "0x40000BF")]
	private const string HIDE_TEXT = "HIDE";

	[Token(Token = "0x40000C0")]
	private const string CLER_TEXT = "CLEAR";

	[Token(Token = "0x40000C1")]
	private const string CNVS_TEXT = "CANVAS";

	[Token(Token = "0x40000C2")]
	private const string CLSE_TEXT = "CLOSE";

	[Token(Token = "0x40000C3")]
	private const string PLAY_ICON = "►";

	[Token(Token = "0x40000C4")]
	private const string PAUS_ICON = "װ";

	[Token(Token = "0x40000C5")]
	private const string HIDE_ICON = "▼";

	[Token(Token = "0x40000C6")]
	private const string SHOW_ICON = "▲";

	[Token(Token = "0x40000C7")]
	private const string CLER_ICON = "ᴓ";

	[Token(Token = "0x40000C8")]
	private const string CNVS_ICON = "ﬦ";

	[Token(Token = "0x40000C9")]
	private const string CLSE_ICON = "x";

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RedrawInterval;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private StatCanvasTypes _canvasType;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _showButtonLabels;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _maxHeaderHeight;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float CanvasScale;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float CanvasDistance;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rect _gameObjectRect;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rect _overlayRect;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private FusionGraph.Layouts _defaultLayout;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _noTextOverlap;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _noGraphShader;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int GraphColumnCount;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int _graphMaxWidth;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _enableObjectStats;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private NetworkObject _object;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _objectTitleHeight;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private int _objectIdsHeight;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int _objectMetersHeight;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private NetworkRunner _runner;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool InitializeAllGraphs;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public SimulationModes ConnectTo;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Simulation.Statistics.ObjStatFlags _includedObjStats;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private Simulation.Statistics.NetStatFlags _includedNetStats;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Simulation.Statistics.SimStatFlags _includedSimStats;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public bool AutoDestroy;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	[SerializeField]
	public bool EnforceSingle;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public string Guid;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool _modifyColors;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private Color _graphColorGood;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private Color _graphColorWarn;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Color _graphColorBad;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Color _graphColorFlag;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[SerializeField]
	private Color _fontColor;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[SerializeField]
	private Color PanelColor;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	[SerializeField]
	private Color _simDataBackColor;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private Color _netDataBackColor;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	[SerializeField]
	private Color _objDataBackColor;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private FusionGraph[] _simGraphs;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private FusionGraph[] _objGraphs;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private FusionGraph[] _netGraphs;

	[NonSerialized]
	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<IFusionStatsView> _foundViews;

	[NonSerialized]
	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<FusionGraph> _foundGraphs;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Text _titleText;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Text _clearIcon;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private Text _pauseIcon;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Text _togglIcon;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private Text _closeIcon;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Text _canvsIcon;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private Text _clearLabel;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Text _pauseLabel;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private Text _togglLabel;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private Text _closeLabel;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private Text _canvsLabel;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private Text _objectNameText;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private GridLayoutGroup _graphGridLayoutGroup;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private RectTransform _canvasRT;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private RectTransform _rootPanelRT;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private RectTransform _guidesRT;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private RectTransform _headerRT;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private RectTransform _statsPanelRT;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private RectTransform _graphsLayoutRT;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[SerializeField]
	private RectTransform _titleRT;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[SerializeField]
	private RectTransform _buttonsRT;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[SerializeField]
	private RectTransform _objectTitlePanelRT;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[SerializeField]
	private RectTransform _objectIdsGroupRT;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	[SerializeField]
	private RectTransform _objectMetersPanelRT;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	[SerializeField]
	private RectTransform _clientIdPanelRT;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[SerializeField]
	private RectTransform _authorityPanelRT;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[SerializeField]
	private Button _titleButton;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	[SerializeField]
	private Button _objctButton;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	[SerializeField]
	private Button _clearButton;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private Button _togglButton;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[SerializeField]
	private Button _pauseButton;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[SerializeField]
	private Button _closeButton;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[SerializeField]
	private Button _canvsButton;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Font _font;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private bool _hidden;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x281")]
	private bool _paused;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private int _layoutDirty;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private bool _activeDirty;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private double _currentDrawTime;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private double _delayDrawUntil;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool? _newInputSystemFound;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private string _previousObjectTitle;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private float _lastLayoutUpdate;

	[Token(Token = "0x1700000D")]
	public static Simulation.Statistics.NetStatFlags DefaultNetStatsMask
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB7450C", Offset = "0xB7450C", VA = "0xB7450C")]
		get
		{
			return default(Simulation.Statistics.NetStatFlags);
		}
	}

	[Token(Token = "0x1700000E")]
	private bool ShowColorControls
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB74514", Offset = "0xB74514", VA = "0xB74514")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	private bool IsNotPlaying
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB74544", Offset = "0xB74544", VA = "0xB74544")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000010")]
	public StatCanvasTypes CanvasType
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB74560", Offset = "0xB74560", VA = "0xB74560")]
		get
		{
			return default(StatCanvasTypes);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB74568", Offset = "0xB74568", VA = "0xB74568")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public bool ShowButtonLabels
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB74598", Offset = "0xB74598", VA = "0xB74598")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB745A0", Offset = "0xB745A0", VA = "0xB745A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public int MaxHeaderHeight
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB745C4", Offset = "0xB745C4", VA = "0xB745C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB745CC", Offset = "0xB745CC", VA = "0xB745CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public Rect GameObjectRect
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB745EC", Offset = "0xB745EC", VA = "0xB745EC")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB745F8", Offset = "0xB745F8", VA = "0xB745F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public Rect OverlayRect
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB7461C", Offset = "0xB7461C", VA = "0xB7461C")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB74628", Offset = "0xB74628", VA = "0xB74628")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public FusionGraph.Layouts DefaultLayout
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB7464C", Offset = "0xB7464C", VA = "0xB7464C")]
		get
		{
			return default(FusionGraph.Layouts);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB74654", Offset = "0xB74654", VA = "0xB74654")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public bool NoTextOverlap
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB74674", Offset = "0xB74674", VA = "0xB74674")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB7467C", Offset = "0xB7467C", VA = "0xB7467C")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public bool NoGraphShader
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB746A0", Offset = "0xB746A0", VA = "0xB746A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB746A8", Offset = "0xB746A8", VA = "0xB746A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public int GraphMaxWidth
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB746CC", Offset = "0xB746CC", VA = "0xB746CC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB746D4", Offset = "0xB746D4", VA = "0xB746D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public bool EnableObjectStats
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB746F4", Offset = "0xB746F4", VA = "0xB746F4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB746FC", Offset = "0xB746FC", VA = "0xB746FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	private bool ShowMissingNetObjWarning
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB74720", Offset = "0xB74720", VA = "0xB74720")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700001B")]
	public NetworkObject Object
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB747A4", Offset = "0xB747A4", VA = "0xB747A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	public int ObjectTitleHeight
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB7484C", Offset = "0xB7484C", VA = "0xB7484C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB74854", Offset = "0xB74854", VA = "0xB74854")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public int ObjectIdsHeight
	{
		[Token(Token = "0x6000096")]
		[Address(RVA = "0xB74874", Offset = "0xB74874", VA = "0xB74874")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB7487C", Offset = "0xB7487C", VA = "0xB7487C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public int ObjectMetersHeight
	{
		[Token(Token = "0x6000098")]
		[Address(RVA = "0xB7489C", Offset = "0xB7489C", VA = "0xB7489C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000099")]
		[Address(RVA = "0xB748A4", Offset = "0xB748A4", VA = "0xB748A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public NetworkRunner Runner
	{
		[Token(Token = "0x600009A")]
		[Address(RVA = "0xB723B8", Offset = "0xB723B8", VA = "0xB723B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0xB743A4", Offset = "0xB743A4", VA = "0xB743A4")]
		set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public Simulation.Statistics.ObjStatFlags IncludedObjectStats
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0xB74D14", Offset = "0xB74D14", VA = "0xB74D14")]
		get
		{
			return default(Simulation.Statistics.ObjStatFlags);
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0xB74D1C", Offset = "0xB74D1C", VA = "0xB74D1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public Simulation.Statistics.NetStatFlags IncludedNetStats
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB74D2C", Offset = "0xB74D2C", VA = "0xB74D2C")]
		get
		{
			return default(Simulation.Statistics.NetStatFlags);
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0xB74D34", Offset = "0xB74D34", VA = "0xB74D34")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Simulation.Statistics.SimStatFlags IncludedSimStats
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB74D44", Offset = "0xB74D44", VA = "0xB74D44")]
		get
		{
			return default(Simulation.Statistics.SimStatFlags);
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xB74D4C", Offset = "0xB74D4C", VA = "0xB74D4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public bool ModifyColors
	{
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xB74D5C", Offset = "0xB74D5C", VA = "0xB74D5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000024")]
	public Color FontColor
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xB74D64", Offset = "0xB74D64", VA = "0xB74D64")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000025")]
	public Color GraphColorGood
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xB74D70", Offset = "0xB74D70", VA = "0xB74D70")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000026")]
	public Color GraphColorWarn
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xB74D7C", Offset = "0xB74D7C", VA = "0xB74D7C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000027")]
	public Color GraphColorBad
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xB74D88", Offset = "0xB74D88", VA = "0xB74D88")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000028")]
	public Color GraphColorFlag
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xB74D94", Offset = "0xB74D94", VA = "0xB74D94")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000029")]
	public Color SimDataBackColor
	{
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xB74DA0", Offset = "0xB74DA0", VA = "0xB74DA0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700002A")]
	public Color NetDataBackColor
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xB74DB4", Offset = "0xB74DB4", VA = "0xB74DB4")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700002B")]
	public Color ObjDataBackColor
	{
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xB74DC8", Offset = "0xB74DC8", VA = "0xB74DC8")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x1700002C")]
	public Rect CurrentRect
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xB74DDC", Offset = "0xB74DDC", VA = "0xB74DDC")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x1700002D")]
	private Shader Shader
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xB74E20", Offset = "0xB74E20", VA = "0xB74E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002E")]
	public static bool NewInputSystemFound
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB76BA0", Offset = "0xB76BA0", VA = "0xB76BA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002F")]
	private bool _graphsAreMissing
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB76DC8", Offset = "0xB76DC8", VA = "0xB76DC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xB73D68", Offset = "0xB73D68", VA = "0xB73D68")]
	internal static FusionStats CreateInternal([Optional] NetworkRunner runner, DefaultLayouts layout = DefaultLayouts.Left, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xB73E30", Offset = "0xB73E30", VA = "0xB73E30")]
	public static FusionStats Create([Optional] Transform parent, [Optional] NetworkRunner runner, [Optional] DefaultLayouts? screenLayout, [Optional] DefaultLayouts? objectLayout, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xB74458", Offset = "0xB74458", VA = "0xB74458")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xB74C34", Offset = "0xB74C34", VA = "0xB74C34")]
	private void UpdateTitle()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB74584", Offset = "0xB74584", VA = "0xB74584")]
	private void DirtyLayout(int minimumRefreshes = 1)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB74004", Offset = "0xB74004", VA = "0xB74004")]
	private void ResetInternal([Optional] bool? enableObjectStats, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask, [Optional] DefaultLayouts? objectLayout, [Optional] DefaultLayouts? screenLayout)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xB75EF4", Offset = "0xB75EF4", VA = "0xB75EF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB761F4", Offset = "0xB761F4", VA = "0xB761F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xB769CC", Offset = "0xB769CC", VA = "0xB769CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xB76AF4", Offset = "0xB76AF4", VA = "0xB76AF4")]
	private void DestroyGraphs()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xB76228", Offset = "0xB76228", VA = "0xB76228")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xB75214", Offset = "0xB75214", VA = "0xB75214")]
	private void GenerateGraphs()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xB749EC", Offset = "0xB749EC", VA = "0xB749EC")]
	private void AssociateWithRunner(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xB748C4", Offset = "0xB748C4", VA = "0xB748C4")]
	private void DisassociateWithRunner(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xB77204", Offset = "0xB77204", VA = "0xB77204")]
	private void Pause()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xB774D0", Offset = "0xB774D0", VA = "0xB774D0")]
	private void Toggle()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB77808", Offset = "0xB77808", VA = "0xB77808")]
	private void Clear()
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xB77A00", Offset = "0xB77A00", VA = "0xB77A00")]
	private void ToggleCanvasType()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xB78850", Offset = "0xB78850", VA = "0xB78850")]
	private void Close()
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xB788BC", Offset = "0xB788BC", VA = "0xB788BC")]
	private void PingSelectObject()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xB788C0", Offset = "0xB788C0", VA = "0xB788C0")]
	private void PingSelectFusionStats()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB788C4", Offset = "0xB788C4", VA = "0xB788C4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xB79014", Offset = "0xB79014", VA = "0xB79014")]
	private void RefreshObjectValues()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB770B8", Offset = "0xB770B8", VA = "0xB770B8")]
	public FusionGraph CreateGraph(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform parentRT)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB78C20", Offset = "0xB78C20", VA = "0xB78C20")]
	private void ReapplyEnabled()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB77A2C", Offset = "0xB77A2C", VA = "0xB77A2C")]
	private void CalculateLayout()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xB74F98", Offset = "0xB74F98", VA = "0xB74F98")]
	private void ApplyDefaultLayout(DefaultLayouts defaults, [Optional] StatCanvasTypes? applyForCanvasType)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB790F0", Offset = "0xB790F0", VA = "0xB790F0")]
	public FusionStats()
	{
	}
}
[Token(Token = "0x200001D")]
public abstract class FusionGraphBase : Fusion.Behaviour, IFusionStatsView
{
	[Token(Token = "0x200001E")]
	public enum StatsPer
	{
		[Token(Token = "0x400013D")]
		Default = 0,
		[Token(Token = "0x400013E")]
		Individual = 1,
		[Token(Token = "0x400013F")]
		Tick = 2,
		[Token(Token = "0x4000140")]
		Second = 4
	}

	[Token(Token = "0x400012A")]
	protected const int PAD = 10;

	[Token(Token = "0x400012B")]
	protected const int MRGN = 6;

	[Token(Token = "0x400012C")]
	protected const int MAX_FONT_SIZE_WITH_GRAPH = 24;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Text LabelTitle;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Image BackImage;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Simulation.Statistics.StatSourceTypes _statSourceType;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected int _statId;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public StatsPer StatsPerDefault;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float WarnThreshold;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float ErrorThreshold;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected IStatsBuffer _statsBuffer;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool _isOverlay;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected FusionStats _fusionStats;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool _layoutDirty;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected Simulation.Statistics.StatsPer CurrentPer;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Simulation.Statistics.StatSourceInfo StatSourceInfo;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Simulation.Statistics.StatSourceTypes _prevStatSourceType;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private int _prevStatId;

	[Token(Token = "0x17000030")]
	public Simulation.Statistics.StatSourceTypes StateSourceType
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xB79330", Offset = "0xB79330", VA = "0xB79330")]
		get
		{
			return default(Simulation.Statistics.StatSourceTypes);
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB79338", Offset = "0xB79338", VA = "0xB79338")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public int StatId
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB7934C", Offset = "0xB7934C", VA = "0xB7934C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xB79354", Offset = "0xB79354", VA = "0xB79354")]
		set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public IStatsBuffer StatsBuffer
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xB704C8", Offset = "0xB704C8", VA = "0xB704C8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000033")]
	public bool IsOverlay
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xB793A0", Offset = "0xB793A0", VA = "0xB793A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xB79368", Offset = "0xB79368", VA = "0xB79368")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	protected virtual Color BackColor
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB793A8", Offset = "0xB793A8", VA = "0xB793A8", Slot = "9")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000035")]
	protected Type CastToStatType
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xB7941C", Offset = "0xB7941C", VA = "0xB7941C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xB700CC", Offset = "0xB700CC", VA = "0xB700CC")]
	protected FusionStats LocateParentFusionStats()
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xB794D4", Offset = "0xB794D4", VA = "0xB794D4", Slot = "10")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xB701A8", Offset = "0xB701A8", VA = "0xB701A8", Slot = "11")]
	public virtual void CyclePer()
	{
	}

	[Token(Token = "0x60000D5")]
	public abstract void CalculateLayout();

	[Token(Token = "0x60000D6")]
	public abstract void Refresh();

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xB6F478", Offset = "0xB6F478", VA = "0xB6F478", Slot = "14")]
	protected virtual bool TryConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xB73B84", Offset = "0xB73B84", VA = "0xB73B84")]
	protected void ApplyTitleText()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xB794D8", Offset = "0xB794D8", VA = "0xB794D8")]
	protected void CheckIfValidIncurrentMode(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xB73D58", Offset = "0xB73D58", VA = "0xB73D58")]
	protected FusionGraphBase()
	{
	}

	[SpecialName]
	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xB7967C", Offset = "0xB7967C", VA = "0xB7967C", Slot = "7")]
	private bool Fusion.StatsInternal.IFusionStatsView.get_isActiveAndEnabled()
	{
		return default(bool);
	}

	[SpecialName]
	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xB79684", Offset = "0xB79684", VA = "0xB79684", Slot = "8")]
	private Transform Fusion.StatsInternal.IFusionStatsView.get_transform()
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
[ExecuteAlways]
public class FusionStatsBillboard : Fusion.Behaviour
{
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera Camera;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float _lastCameraFindTime;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Camera _currentCam;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private FusionStats _fusionStats;

	[Token(Token = "0x17000036")]
	private Camera MainCamera
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xB79768", Offset = "0xB79768", VA = "0xB79768")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xB79718", Offset = "0xB79718", VA = "0xB79718")]
		set
		{
		}
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xB7968C", Offset = "0xB7968C", VA = "0xB7968C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xB796E4", Offset = "0xB796E4", VA = "0xB796E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xB796E8", Offset = "0xB796E8", VA = "0xB796E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xB797F4", Offset = "0xB797F4", VA = "0xB797F4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xB74E78", Offset = "0xB74E78", VA = "0xB74E78")]
	public void UpdateLookAt()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xB797F8", Offset = "0xB797F8", VA = "0xB797F8")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xB79854", Offset = "0xB79854", VA = "0xB79854")]
	public FusionStatsBillboard()
	{
	}
}
[Token(Token = "0x2000020")]
public class FusionStatsMeterBar : FusionGraphBase
{
	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float HoldPeakTime;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float DecayTime;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int MeterMax;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private bool _showUITargets;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text ValueLabel;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image Bar;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private double _currentDisplayValue;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private double _currentBarValue;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Color CurrentColor;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private double _lastImportedSampleTickTime;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private double _max;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private double _total;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float _lastPeakSetTime;

	[Token(Token = "0x17000037")]
	protected override Color BackColor
	{
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xB7985C", Offset = "0xB7985C", VA = "0xB7985C", Slot = "9")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xB7987C", Offset = "0xB7987C", VA = "0xB7987C", Slot = "10")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xB79AC0", Offset = "0xB79AC0", VA = "0xB79AC0", Slot = "13")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xB7A2EC", Offset = "0xB7A2EC", VA = "0xB7A2EC")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xB7A14C", Offset = "0xB7A14C", VA = "0xB7A14C")]
	public void SetValue(double rawvalue)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xB7A3CC", Offset = "0xB7A3CC", VA = "0xB7A3CC")]
	private void SetBar(double value)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xB7A54C", Offset = "0xB7A54C", VA = "0xB7A54C", Slot = "12")]
	public override void CalculateLayout()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xB76F3C", Offset = "0xB76F3C", VA = "0xB76F3C")]
	public static FusionStatsMeterBar Create(RectTransform parent, FusionStats fusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, float warnThreshold, float alertThreshold)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xB7A6A8", Offset = "0xB7A6A8", VA = "0xB7A6A8")]
	public void GenerateMeter()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xB7AAB4", Offset = "0xB7AAB4", VA = "0xB7AAB4")]
	public FusionStatsMeterBar()
	{
	}
}
[Token(Token = "0x2000021")]
public class FusionStatsObjectIds : Fusion.Behaviour, IFusionStatsView
{
	[Token(Token = "0x4000152")]
	protected const int PAD = 10;

	[Token(Token = "0x4000153")]
	protected const int MARGIN = 6;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _inputValueText;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text _stateValueText;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text _objectIdLabel;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image _stateAuthBackImage;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image _inputAuthBackImage;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FusionStats _fusionStats;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Color _noneAuthColor;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Color _inputAuthColor;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Color _stateAuthColor;

	[Token(Token = "0x400015D")]
	private const float LABEL_DIVIDING_POINT = 0.7f;

	[Token(Token = "0x400015E")]
	private const float TEXT_PAD = 4f;

	[Token(Token = "0x400015F")]
	private const float TEXT_PAD_HORIZ = 6f;

	[Token(Token = "0x4000160")]
	private const int MAX_TAG_FONT_SIZE = 18;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _previousHasInputAuth;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _previousHasStateAuth;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int _previousInputAuthValue;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int _previousStateAuthValue;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private uint _previousObjectIdValue;

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xB7AAD0", Offset = "0xB7AAD0", VA = "0xB7AAD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xB7AB28", Offset = "0xB7AB28", VA = "0xB7AB28", Slot = "4")]
	private void Fusion.StatsInternal.IFusionStatsView.Initialize()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xB76E28", Offset = "0xB76E28", VA = "0xB76E28")]
	public static RectTransform Create(RectTransform parent, FusionStats fusionStats)
	{
		return null;
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xB7AB2C", Offset = "0xB7AB2C", VA = "0xB7AB2C")]
	public void Generate()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xB7AE48", Offset = "0xB7AE48", VA = "0xB7AE48")]
	private RectTransform AddAuthorityPanel(RectTransform parent, string label, ref Text valueText, ref Image backImage)
	{
		return null;
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xB7B0E8", Offset = "0xB7B0E8", VA = "0xB7B0E8", Slot = "5")]
	private void Fusion.StatsInternal.IFusionStatsView.CalculateLayout()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xB7B0EC", Offset = "0xB7B0EC", VA = "0xB7B0EC", Slot = "6")]
	private void Fusion.StatsInternal.IFusionStatsView.Refresh()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xB7B4D4", Offset = "0xB7B4D4", VA = "0xB7B4D4")]
	public FusionStatsObjectIds()
	{
	}

	[SpecialName]
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xB7B558", Offset = "0xB7B558", VA = "0xB7B558", Slot = "7")]
	private bool Fusion.StatsInternal.IFusionStatsView.get_isActiveAndEnabled()
	{
		return default(bool);
	}

	[SpecialName]
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xB7B560", Offset = "0xB7B560", VA = "0xB7B560", Slot = "8")]
	private Transform Fusion.StatsInternal.IFusionStatsView.get_transform()
	{
		return null;
	}
}
[Token(Token = "0x2000022")]
[NetworkBehaviourWeaved(0)]
public class PlayerAOIPrototype : NetworkBehaviour
{
	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected bool DrawAreaOfInterestRadius;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float Radius;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<PlayerAOIPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<PlayerAOIPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<PlayerAOIPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xB7B568", Offset = "0xB7B568", VA = "0xB7B568", Slot = "8")]
	public override void FixedUpdateNetwork()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xB7B670", Offset = "0xB7B670", VA = "0xB7B670")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xB7B714", Offset = "0xB7B714", VA = "0xB7B714")]
	public PlayerAOIPrototype()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xB7B724", Offset = "0xB7B724", VA = "0xB7B724", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xB7B728", Offset = "0xB7B728", VA = "0xB7B728", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000023")]
[NetworkBehaviourWeaved(3)]
public class ControllerPrototype : NetworkBehaviour
{
	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected NetworkCharacterControllerPrototype _ncc;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected NetworkRigidbody _nrb;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected NetworkRigidbody2D _nrb2d;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected NetworkTransform _nt;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Vector3 _MovementDirection;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool TransformLocal;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float Speed;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<ControllerPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<ControllerPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<ControllerPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x17000038")]
	[NetworkedWeaved(0, 3)]
	[Networked]
	public Vector3 MovementDirection
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0xB7B72C", Offset = "0xB7B72C", VA = "0xB7B72C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000101")]
		[Address(RVA = "0xB7B7B4", Offset = "0xB7B7B4", VA = "0xB7B7B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	private bool ShowSpeed
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0xB7B898", Offset = "0xB7B898", VA = "0xB7B898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xB7B938", Offset = "0xB7B938", VA = "0xB7B938")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xB7BAF0", Offset = "0xB7BAF0", VA = "0xB7BAF0", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xB7B93C", Offset = "0xB7B93C", VA = "0xB7B93C")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xB7BAF4", Offset = "0xB7BAF4", VA = "0xB7BAF4", Slot = "8")]
	public override void FixedUpdateNetwork()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xB7C0C0", Offset = "0xB7C0C0", VA = "0xB7C0C0")]
	public ControllerPrototype()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xB7C0D0", Offset = "0xB7C0D0", VA = "0xB7C0D0", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xB7C0DC", Offset = "0xB7C0DC", VA = "0xB7C0DC", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000024")]
public class InputBehaviourPrototype : Fusion.Behaviour, INetworkRunnerCallbacks
{
	[Token(Token = "0x600010A")]
	[Address(RVA = "0xB7D0F8", Offset = "0xB7D0F8", VA = "0xB7D0F8", Slot = "6")]
	public void OnInput(NetworkRunner runner, NetworkInput input)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xB7D324", Offset = "0xB7D324", VA = "0xB7D324", Slot = "7")]
	public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xB7D328", Offset = "0xB7D328", VA = "0xB7D328", Slot = "9")]
	public void OnConnectedToServer(NetworkRunner runner)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xB7D32C", Offset = "0xB7D32C", VA = "0xB7D32C", Slot = "12")]
	public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xB7D330", Offset = "0xB7D330", VA = "0xB7D330", Slot = "11")]
	public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xB7D334", Offset = "0xB7D334", VA = "0xB7D334", Slot = "10")]
	public void OnDisconnectedFromServer(NetworkRunner runner)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xB7D338", Offset = "0xB7D338", VA = "0xB7D338", Slot = "4")]
	public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xB7D33C", Offset = "0xB7D33C", VA = "0xB7D33C", Slot = "5")]
	public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xB7D340", Offset = "0xB7D340", VA = "0xB7D340", Slot = "13")]
	public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xB7D344", Offset = "0xB7D344", VA = "0xB7D344", Slot = "8")]
	public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xB7D348", Offset = "0xB7D348", VA = "0xB7D348", Slot = "14")]
	public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xB7D34C", Offset = "0xB7D34C", VA = "0xB7D34C", Slot = "17")]
	public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xB7D350", Offset = "0xB7D350", VA = "0xB7D350", Slot = "18")]
	public void OnSceneLoadDone(NetworkRunner runner)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xB7D354", Offset = "0xB7D354", VA = "0xB7D354", Slot = "19")]
	public void OnSceneLoadStart(NetworkRunner runner)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xB7D358", Offset = "0xB7D358", VA = "0xB7D358", Slot = "15")]
	public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xB7D35C", Offset = "0xB7D35C", VA = "0xB7D35C", Slot = "16")]
	public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xB7D360", Offset = "0xB7D360", VA = "0xB7D360")]
	public InputBehaviourPrototype()
	{
	}
}
[StructLayout(2)]
[Token(Token = "0x2000025")]
[NetworkInputWeaved(4)]
public struct NetworkInputPrototype : INetworkInput
{
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public NetworkButtons Buttons;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public byte Weapon;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Angle Yaw;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Angle Pitch;

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xB7D368", Offset = "0xB7D368", VA = "0xB7D368")]
	public bool IsDown(int button)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000026")]
[RequireComponent(typeof(CharacterController))]
[NetworkBehaviourWeaved(24)]
[OrderBefore(new Type[] { typeof(NetworkTransform) })]
[DisallowMultipleComponent]
public class NetworkCharacterControllerPrototype : NetworkTransform
{
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public float gravity;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float jumpImpulse;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float acceleration;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public float braking;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float maxSpeed;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float rotationSpeed;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	[SerializeField]
	private bool _IsGrounded;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private Vector3 _Velocity;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<NetworkCharacterControllerPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<NetworkCharacterControllerPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<NetworkCharacterControllerPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x1700003A")]
	[Networked]
	[NetworkedWeaved(20, 1)]
	public bool IsGrounded
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xB7D370", Offset = "0xB7D370", VA = "0xB7D370")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB7D3DC", Offset = "0xB7D3DC", VA = "0xB7D3DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	[Networked]
	[NetworkedWeaved(21, 3)]
	public Vector3 Velocity
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xB7D444", Offset = "0xB7D444", VA = "0xB7D444")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xB7D4CC", Offset = "0xB7D4CC", VA = "0xB7D4CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	protected override Vector3 DefaultTeleportInterpolationVelocity
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB7D5B0", Offset = "0xB7D5B0", VA = "0xB7D5B0", Slot = "49")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700003D")]
	protected override Vector3 DefaultTeleportInterpolationAngularVelocity
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB7D5B4", Offset = "0xB7D5B4", VA = "0xB7D5B4", Slot = "50")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700003E")]
	public CharacterController Controller
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xB7D5C4", Offset = "0xB7D5C4", VA = "0xB7D5C4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB7D5CC", Offset = "0xB7D5CC", VA = "0xB7D5CC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xB7D5DC", Offset = "0xB7D5DC", VA = "0xB7D5DC", Slot = "26")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xB7D69C", Offset = "0xB7D69C", VA = "0xB7D69C", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xB7D5F8", Offset = "0xB7D5F8", VA = "0xB7D5F8")]
	private void CacheController()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xB7D6B8", Offset = "0xB7D6B8", VA = "0xB7D6B8", Slot = "32")]
	protected override void CopyFromBufferToEngine()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xB7D7A8", Offset = "0xB7D7A8", VA = "0xB7D7A8", Slot = "56")]
	public virtual void Jump(bool ignoreGrounded = false, [Optional] float? overrideImpulse)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xB7D844", Offset = "0xB7D844", VA = "0xB7D844", Slot = "57")]
	public virtual void Move(Vector3 direction)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xB7DC0C", Offset = "0xB7DC0C", VA = "0xB7DC0C")]
	public NetworkCharacterControllerPrototype()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xB7DC34", Offset = "0xB7DC34", VA = "0xB7DC34", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xB7DC6C", Offset = "0xB7DC6C", VA = "0xB7DC6C", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000027")]
[DisallowMultipleComponent]
public class NetworkDebugStart : Fusion.Behaviour
{
	[Token(Token = "0x2000028")]
	public enum StartModes
	{
		[Token(Token = "0x4000194")]
		UserInterface,
		[Token(Token = "0x4000195")]
		Automatic,
		[Token(Token = "0x4000196")]
		Manual
	}

	[Token(Token = "0x2000029")]
	public enum Stage
	{
		[Token(Token = "0x4000198")]
		Disconnected,
		[Token(Token = "0x4000199")]
		StartingUp,
		[Token(Token = "0x400019A")]
		UnloadOriginalScene,
		[Token(Token = "0x400019B")]
		ConnectingServer,
		[Token(Token = "0x400019C")]
		ConnectingClients,
		[Token(Token = "0x400019D")]
		AllConnected
	}

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NetworkRunner RunnerPrefab;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StartModes StartMode;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("Server")]
	public GameMode AutoStartAs;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool AutoHideGUI;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int AutoClients;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ushort ServerPort;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string DefaultRoomName;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool AlwaysShowStats;

	[NonSerialized]
	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NetworkRunner _server;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string InitialScenePath;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _initialScenePath;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Stage _currentStage;

	[Token(Token = "0x1700003F")]
	public Stage CurrentStage
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB7DCA8", Offset = "0xB7DCA8", VA = "0xB7DCA8")]
		get
		{
			return default(Stage);
		}
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xB7DCB0", Offset = "0xB7DCB0", VA = "0xB7DCB0")]
		internal set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public int LastCreatedClientIndex
	{
		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB7DCB8", Offset = "0xB7DCB8", VA = "0xB7DCB8")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000130")]
		[Address(RVA = "0xB7DCC0", Offset = "0xB7DCC0", VA = "0xB7DCC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public GameMode CurrentServerMode
	{
		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB7DCC8", Offset = "0xB7DCC8", VA = "0xB7DCC8")]
		[CompilerGenerated]
		get
		{
			return default(GameMode);
		}
		[Token(Token = "0x6000132")]
		[Address(RVA = "0xB7DCD0", Offset = "0xB7DCD0", VA = "0xB7DCD0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x17000042")]
	protected bool CanAddClients
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xB7DCD8", Offset = "0xB7DCD8", VA = "0xB7DCD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	protected bool CanAddSharedClients
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xB7DD04", Offset = "0xB7DD04", VA = "0xB7DD04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000044")]
	protected bool IsShutdown
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0xB7DD28", Offset = "0xB7DD28", VA = "0xB7DD28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000045")]
	protected bool IsShutdownAndMultiPeer
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xB7DD38", Offset = "0xB7DD38", VA = "0xB7DD38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000046")]
	protected bool UsingMultiPeerMode
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0xB7DD70", Offset = "0xB7DD70", VA = "0xB7DD70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000047")]
	protected bool ShowAutoClients
	{
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xB7DD98", Offset = "0xB7DD98", VA = "0xB7DD98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xB7DDE4", Offset = "0xB7DDE4", VA = "0xB7DDE4", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xB7E160", Offset = "0xB7E160", VA = "0xB7E160")]
	protected bool TryGetSceneRef(out SceneRef sceneRef)
	{
		return default(bool);
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xB7E2CC", Offset = "0xB7E2CC", VA = "0xB7E2CC", Slot = "5")]
	public virtual void StartSinglePlayer()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xB7E318", Offset = "0xB7E318", VA = "0xB7E318", Slot = "6")]
	public virtual void StartServer()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xB7E364", Offset = "0xB7E364", VA = "0xB7E364", Slot = "7")]
	public virtual void StartHost()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xB7E3B0", Offset = "0xB7E3B0", VA = "0xB7E3B0", Slot = "8")]
	public virtual void StartClient()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xB7E3DC", Offset = "0xB7E3DC", VA = "0xB7E3DC", Slot = "9")]
	public virtual void StartSharedClient()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xB7E428", Offset = "0xB7E428", VA = "0xB7E428", Slot = "10")]
	public virtual void StartAutoClient()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xB7E474", Offset = "0xB7E474", VA = "0xB7E474", Slot = "11")]
	public virtual void StartServerPlusClients()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xB7E484", Offset = "0xB7E484", VA = "0xB7E484")]
	public void StartHostPlusClients()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xB7E55C", Offset = "0xB7E55C", VA = "0xB7E55C")]
	public void Shutdown()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xB7E840", Offset = "0xB7E840", VA = "0xB7E840", Slot = "12")]
	public virtual void StartServerPlusClients(int clientCount)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xB7E48C", Offset = "0xB7E48C", VA = "0xB7E48C")]
	public void StartHostPlusClients(int clientCount)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xB7E910", Offset = "0xB7E910", VA = "0xB7E910")]
	public void StartMultipleClients(int clientCount)
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xB7E9E0", Offset = "0xB7E9E0", VA = "0xB7E9E0")]
	public void StartMultipleSharedClients(int clientCount)
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xB7EAB0", Offset = "0xB7EAB0", VA = "0xB7EAB0")]
	public void StartMultipleAutoClients(int clientCount)
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xB7E560", Offset = "0xB7E560", VA = "0xB7E560")]
	public void ShutdownAll()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xB7E234", Offset = "0xB7E234", VA = "0xB7E234")]
	protected IEnumerator StartWithClients(GameMode serverMode, SceneRef sceneRef, int clientCount)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xB7EBA8", Offset = "0xB7EBA8", VA = "0xB7EBA8")]
	public void AddClient()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xB7EE3C", Offset = "0xB7EE3C", VA = "0xB7EE3C")]
	public void AddSharedClient()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB7EBE0", Offset = "0xB7EBE0", VA = "0xB7EBE0")]
	public Task AddClient(GameMode serverMode, SceneRef sceneRef)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB7EE74", Offset = "0xB7EE74", VA = "0xB7EE74")]
	protected IEnumerator StartClients(int clientCount, GameMode serverMode, [Optional] SceneRef sceneRef)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xB7EF34", Offset = "0xB7EF34", VA = "0xB7EF34", Slot = "13")]
	protected virtual Task InitializeNetworkRunner(NetworkRunner runner, GameMode gameMode, NetAddress address, SceneRef scene, Action<NetworkRunner> initialized)
	{
		return null;
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xB7F1CC", Offset = "0xB7F1CC", VA = "0xB7F1CC")]
	public NetworkDebugStart()
	{
	}
}
[Token(Token = "0x200002D")]
[RequireComponent(typeof(NetworkDebugStart))]
public class NetworkDebugStartGUI : Fusion.Behaviour
{
	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableHotkeys;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUISkin BaseSkin;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NetworkDebugStart _networkDebugStart;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _clientCount;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isMultiplePeerMode;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<NetworkDebugStart.Stage, string> _nicifiedStageNames;

	[Token(Token = "0x6000160")]
	[Address(RVA = "0xB7FEF0", Offset = "0xB7FEF0", VA = "0xB7FEF0", Slot = "4")]
	protected virtual void OnValidate()
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xB7FEF4", Offset = "0xB7FEF4", VA = "0xB7FEF4")]
	protected void ValidateClientCount()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xB7FFBC", Offset = "0xB7FFBC", VA = "0xB7FFBC")]
	protected int GetClientCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xB80094", Offset = "0xB80094", VA = "0xB80094", Slot = "5")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xB802C0", Offset = "0xB802C0", VA = "0xB802C0", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xB80158", Offset = "0xB80158", VA = "0xB80158")]
	protected NetworkDebugStart EnsureNetworkDebugStartExists()
	{
		return null;
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xB802F0", Offset = "0xB802F0", VA = "0xB802F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xB808A0", Offset = "0xB808A0", VA = "0xB808A0", Slot = "7")]
	protected virtual void OnGUI()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xB80488", Offset = "0xB80488", VA = "0xB80488")]
	private void StartHostWithClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xB8057C", Offset = "0xB8057C", VA = "0xB8057C")]
	private void StartServerWithClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xB80678", Offset = "0xB80678", VA = "0xB80678")]
	private void StartMultipleClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xB8076C", Offset = "0xB8076C", VA = "0xB8076C")]
	private void StartMultipleAutoClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xB807AC", Offset = "0xB807AC", VA = "0xB807AC")]
	private void StartMultipleSharedClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x600016D")]
	public static Dictionary<T, string> ConvertEnumToNicifiedNameLookup<T>([Optional] string prefix, [Optional] Dictionary<T, string> nonalloc) where T : Enum
	{
		return null;
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xB817D8", Offset = "0xB817D8", VA = "0xB817D8")]
	public NetworkDebugStartGUI()
	{
	}
}
[Token(Token = "0x200002E")]
[DisallowMultipleComponent]
public class ToggleRunnerProvideInput : Fusion.Behaviour
{
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ToggleRunnerProvideInput _instance;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xB817E0", Offset = "0xB817E0", VA = "0xB817E0")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xB81924", Offset = "0xB81924", VA = "0xB81924")]
	public void Update()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xB81A54", Offset = "0xB81A54", VA = "0xB81A54")]
	private void ToggleAll(int runnerIndex)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xB81BA0", Offset = "0xB81BA0", VA = "0xB81BA0")]
	public ToggleRunnerProvideInput()
	{
	}
}
[Token(Token = "0x200002F")]
[DisallowMultipleComponent]
public class ToggleRunnerVisibility : Fusion.Behaviour
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ToggleRunnerVisibility _instance;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xB81BA8", Offset = "0xB81BA8", VA = "0xB81BA8")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xB81CEC", Offset = "0xB81CEC", VA = "0xB81CEC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xB81E2C", Offset = "0xB81E2C", VA = "0xB81E2C")]
	private void ToggleAll(int runnerIndex)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xB81F78", Offset = "0xB81F78", VA = "0xB81F78")]
	public ToggleRunnerVisibility()
	{
	}
}
[Token(Token = "0x2000030")]
public static class FusionScalableIMGUI
{
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GUISkin _scalableSkin;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xB81F80", Offset = "0xB81F80", VA = "0xB81F80")]
	private static void InitializedGUIStyles(GUISkin baseSkin)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xB816E4", Offset = "0xB816E4", VA = "0xB816E4")]
	public static GUISkin GetScaledSkin(GUISkin baseSkin, out float height, out float width, out int padding, out int margin, out float boxLeft)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xB823B4", Offset = "0xB823B4", VA = "0xB823B4")]
	public static (float, float, int, int, float) ScaleGuiSkinToScreenHeight()
	{
		return default((float, float, int, int, float));
	}
}
[Token(Token = "0x2000031")]
public class PicoSettingsSetter : MonoBehaviour
{
	[Token(Token = "0x600017A")]
	[Address(RVA = "0xB82790", Offset = "0xB82790", VA = "0xB82790")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xB827BC", Offset = "0xB827BC", VA = "0xB827BC")]
	public PicoSettingsSetter()
	{
	}
}
namespace Fusion
{
	[Token(Token = "0x2000032")]
	internal static class FusionRuntimeCheck
	{
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB827C4", Offset = "0xB827C4", VA = "0xB827C4")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeCheck()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000033")]
	public class FusionUnityLogger : ILogger
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StringBuilder _builder;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseGlobalPrefix;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UseColorTags;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string GlobalPrefixColor;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color32 MinRandomColor;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color32 MaxRandomColor;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color ServerColor;

		[Token(Token = "0x1700004C")]
		public Func<object, int> GetColor
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xB827E4", Offset = "0xB827E4", VA = "0xB827E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xB827EC", Offset = "0xB827EC", VA = "0xB827EC")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB827F4", Offset = "0xB827F4", VA = "0xB827F4")]
		public FusionUnityLogger()
		{
		}

		[Token(Token = "0x6000180")]
		public void Log<T>(LogType logType, string prefix, ref T context, string message) where T : ILogBuilder
		{
		}

		[Token(Token = "0x6000181")]
		public void LogException<T>(string prefix, ref T context, Exception ex) where T : ILogBuilder
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xB8298C", Offset = "0xB8298C", VA = "0xB8298C")]
		private int GetRandomColor(int seed)
		{
			return default(int);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB82C70", Offset = "0xB82C70", VA = "0xB82C70")]
		private static int GetRandomColor(int seed, Color32 min, Color32 max, Color32 svr)
		{
			return default(int);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB82D78", Offset = "0xB82D78", VA = "0xB82D78")]
		private static int Color32ToRGB24(Color32 c)
		{
			return default(int);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB82900", Offset = "0xB82900", VA = "0xB82900")]
		private static string Color32ToRGBString(Color32 c)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB82D8C", Offset = "0xB82D8C", VA = "0xB82D8C")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public abstract class NetworkSceneManagerBase : Behaviour, INetworkSceneManager
	{
		[Token(Token = "0x2000035")]
		protected delegate void FinishedLoadingDelegate(IEnumerable<NetworkObject> sceneObjects);

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WeakReference<NetworkSceneManagerBase> s_currentlyLoading;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowHierarchyWindowOverlay;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnumerator _runningCoroutine;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _currentSceneOutdated;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private SceneRef _currentScene;

		[Token(Token = "0x1700004D")]
		public NetworkRunner Runner
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xB82EBC", Offset = "0xB82EBC", VA = "0xB82EBC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xB82EC4", Offset = "0xB82EC4", VA = "0xB82EC4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xB82ECC", Offset = "0xB82ECC", VA = "0xB82ECC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB83114", Offset = "0xB83114", VA = "0xB83114")]
		public static bool IsScenePathOrNameEqual(Scene scene, string nameOrPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB83170", Offset = "0xB83170", VA = "0xB83170")]
		public static bool TryGetScenePathFromBuildSettings(SceneRef sceneRef, out string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xB8321C", Offset = "0xB8321C", VA = "0xB8321C", Slot = "8")]
		public virtual bool TryGetScenePath(SceneRef sceneRef, out string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB83280", Offset = "0xB83280", VA = "0xB83280", Slot = "9")]
		public virtual bool TryGetSceneRef(string nameOrPath, out SceneRef sceneRef)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB833B4", Offset = "0xB833B4", VA = "0xB833B4")]
		public bool IsScenePathOrNameEqual(Scene scene, SceneRef sceneRef)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB83450", Offset = "0xB83450", VA = "0xB83450")]
		public List<NetworkObject> FindNetworkObjects(Scene scene, bool disable = true, bool addVisibilityNodes = false)
		{
			return null;
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB838CC", Offset = "0xB838CC", VA = "0xB838CC", Slot = "4")]
		private void Fusion.INetworkSceneManager.Initialize(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB838D8", Offset = "0xB838D8", VA = "0xB838D8", Slot = "5")]
		private void Fusion.INetworkSceneManager.Shutdown(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB838E4", Offset = "0xB838E4", VA = "0xB838E4", Slot = "6")]
		private bool Fusion.INetworkSceneManager.IsReady(NetworkRunner runner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB83938", Offset = "0xB83938", VA = "0xB83938", Slot = "10")]
		protected virtual void Initialize(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB83940", Offset = "0xB83940", VA = "0xB83940", Slot = "11")]
		protected virtual void Shutdown(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000196")]
		protected abstract IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished);

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB83C3C", Offset = "0xB83C3C", VA = "0xB83C3C")]
		protected void LogError(string msg)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB83B2C", Offset = "0xB83B2C", VA = "0xB83B2C")]
		protected void LogWarn(string msg)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xB8308C", Offset = "0xB8308C", VA = "0xB8308C")]
		private IEnumerator SwitchSceneWrapper(SceneRef prevScene, SceneRef newScene)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0xB83D74", Offset = "0xB83D74", VA = "0xB83D74")]
		protected NetworkSceneManagerBase()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class NetworkSceneManagerDefault : NetworkSceneManagerBase
	{
		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int PostLoadDelayFrames;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB84940", Offset = "0xB84940", VA = "0xB84940", Slot = "13")]
		protected virtual YieldInstruction LoadSceneAsync(SceneRef sceneRef, LoadSceneParameters parameters, Action<Scene> loaded)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xB84B74", Offset = "0xB84B74", VA = "0xB84B74", Slot = "14")]
		protected virtual YieldInstruction UnloadSceneAsync(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xB84BCC", Offset = "0xB84BCC", VA = "0xB84BCC", Slot = "12")]
		protected override IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xB84C14", Offset = "0xB84C14", VA = "0xB84C14", Slot = "15")]
		protected virtual IEnumerator SwitchSceneMultiplePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB84CE4", Offset = "0xB84CE4", VA = "0xB84CE4", Slot = "16")]
		protected virtual IEnumerator SwitchSceneSinglePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB84DB4", Offset = "0xB84DB4", VA = "0xB84DB4")]
		public NetworkSceneManagerDefault()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class FusionUnitySceneManagerUtils
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB832B8", Offset = "0xB832B8", VA = "0xB832B8")]
		public static int GetSceneBuildIndex(string nameOrPath)
		{
			return default(int);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB858BC", Offset = "0xB858BC", VA = "0xB858BC")]
		public static void GetFileNameWithoutExtensionPosition(string nameOrPath, out int index, out int length)
		{
		}
	}
}
namespace Fusion.StatsInternal
{
	[Token(Token = "0x200003F")]
	public interface IFusionStatsView
	{
		[Token(Token = "0x17000054")]
		bool isActiveAndEnabled
		{
			[Token(Token = "0x60001C5")]
			get;
		}

		[Token(Token = "0x17000055")]
		Transform transform
		{
			[Token(Token = "0x60001C6")]
			get;
		}

		[Token(Token = "0x60001C2")]
		void Initialize();

		[Token(Token = "0x60001C3")]
		void CalculateLayout();

		[Token(Token = "0x60001C4")]
		void Refresh();
	}
	[Token(Token = "0x2000040")]
	public static class FusionStatsUtilities
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> _cachedGraphVisualizationNames;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Font _font;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D _meterTexture;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Sprite _meterSprite;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D _circle32Texture;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Sprite _circle32Sprite;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Color DARK_GREEN;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Color DARK_BLUE;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Color DARK_RED;

		[Token(Token = "0x17000056")]
		public static List<string> CachedTelemetryNames
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xB85924", Offset = "0xB85924", VA = "0xB85924")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public static Font Font
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xB85D78", Offset = "0xB85D78", VA = "0xB85D78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		private static Texture2D MeterTexture
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0xB85E88", Offset = "0xB85E88", VA = "0xB85E88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		public static Sprite MeterSprite
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0xB86018", Offset = "0xB86018", VA = "0xB86018")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005A")]
		private static Texture2D Circle32Texture
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0xB86140", Offset = "0xB86140", VA = "0xB86140")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		public static Sprite CircleSprite
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0xB863C4", Offset = "0xB863C4", VA = "0xB863C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xB86508", Offset = "0xB86508", VA = "0xB86508")]
		public static bool TryFindActiveRunner(FusionStats fusionStats, out NetworkRunner runner, [Optional] SimulationModes? mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB86704", Offset = "0xB86704", VA = "0xB86704")]
		public static RectTransform CreateRectTransform(this Transform parent, string name, bool expand = false)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB86964", Offset = "0xB86964", VA = "0xB86964")]
		public static Dropdown CreateDropdown(this RectTransform rt, float padding, Color fontColor)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB87088", Offset = "0xB87088", VA = "0xB87088")]
		public static Text AddText(this RectTransform rt, string label, TextAnchor anchor, Color FontColor)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB871FC", Offset = "0xB871FC", VA = "0xB871FC")]
		internal static void MakeButton(this RectTransform parent, ref Button button, string iconText, string labelText, out Text icon, out Text text, UnityAction action)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB87678", Offset = "0xB87678", VA = "0xB87678")]
		public static RectTransform AddVerticalLayoutGroup(this RectTransform rt, float spacing, [Optional] int? rgtPad, [Optional] int? lftPad, [Optional] int? topPad, [Optional] int? botPad)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB8771C", Offset = "0xB8771C", VA = "0xB8771C")]
		public static GridLayoutGroup AddGridlLayoutGroup(this RectTransform rt, float spacing, [Optional] int? rgtPad, [Optional] int? lftPad, [Optional] int? topPad, [Optional] int? botPad)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB877A4", Offset = "0xB877A4", VA = "0xB877A4")]
		public static RectTransform AddCircleSprite(this RectTransform rt, Color color)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB8783C", Offset = "0xB8783C", VA = "0xB8783C")]
		public static RectTransform AddCircleSprite(this RectTransform rt, Color color, out Image image)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xB86828", Offset = "0xB86828", VA = "0xB86828")]
		public static RectTransform ExpandAnchor(this RectTransform rt, [Optional] float? padding)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB86E68", Offset = "0xB86E68", VA = "0xB86E68")]
		public static RectTransform ExpandTopAnchor(this RectTransform rt, [Optional] float? padding)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xB87064", Offset = "0xB87064", VA = "0xB87064")]
		public static RectTransform SetSizeDelta(this RectTransform rt, float offsetX, float offsetY)
		{
			return null;
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xB86FA8", Offset = "0xB86FA8", VA = "0xB86FA8")]
		public static RectTransform SetOffsets(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB87040", Offset = "0xB87040", VA = "0xB87040")]
		public static RectTransform SetPivot(this RectTransform rt, float pivotX, float pivotY)
		{
			return null;
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB86FF4", Offset = "0xB86FF4", VA = "0xB86FF4")]
		public static RectTransform SetAnchors(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}
	}
}
namespace Knife.Effects
{
	[Token(Token = "0x2000041")]
	public class AutoDestroyer : MonoBehaviour
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float destroyDelay;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xB879F4", Offset = "0xB879F4", VA = "0xB879F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xB87A70", Offset = "0xB87A70", VA = "0xB87A70")]
		public AutoDestroyer()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class CollisionPlacer : MonoBehaviour
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask mask;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float autoPlaceMaxDistance;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xB87A80", Offset = "0xB87A80", VA = "0xB87A80", Slot = "4")]
		public void CollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB87DC4", Offset = "0xB87DC4", VA = "0xB87DC4", Slot = "5")]
		public void AutoPlace()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xB8800C", Offset = "0xB8800C", VA = "0xB8800C")]
		public CollisionPlacer()
		{
		}
	}
	[Token(Token = "0x2000043")]
	[RequireComponent(typeof(Camera))]
	public class FlashbangPostprocess : MonoBehaviour
	{
		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float blindDuration;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve whiteScreenCurve;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve lastFrameCurve;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve distanceAmountCurve;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float maxDistance;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve angleAmountCurve;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture lastFrame;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isBlinded;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float blindTime;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float blindAmount;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool updateLastFrame;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera attachedCamera;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xB88038", Offset = "0xB88038", VA = "0xB88038", Slot = "4")]
		public void Blind(float amount, Vector3 position)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xB88214", Offset = "0xB88214", VA = "0xB88214")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xB8830C", Offset = "0xB8830C", VA = "0xB8830C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xB88318", Offset = "0xB88318", VA = "0xB88318")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB8835C", Offset = "0xB8835C", VA = "0xB8835C")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xB88510", Offset = "0xB88510", VA = "0xB88510")]
		public FlashbangPostprocess()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class ParticleGroupEmitter : MonoBehaviour
	{
		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] particleSystems;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int countMultiplier;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float emissionProbability;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool emitOnEnable;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool allowNoEmitSeries;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool wasPreviousEmitStopped;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xB88528", Offset = "0xB88528", VA = "0xB88528")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xB8853C", Offset = "0xB8853C", VA = "0xB8853C")]
		public void Emit(int count = 1)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xB88814", Offset = "0xB88814", VA = "0xB88814")]
		private IEnumerator PlayDelayed(ParticleSystem particleSystem, int count)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xB88664", Offset = "0xB88664", VA = "0xB88664")]
		private void Emit(ParticleSystem particleSystem, int count)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xB888D4", Offset = "0xB888D4", VA = "0xB888D4")]
		public ParticleGroupEmitter()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class ParticleGroupPlayer : MonoBehaviour
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] particleSystems;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xB88A48", Offset = "0xB88A48", VA = "0xB88A48")]
		public void Play()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xB88AB8", Offset = "0xB88AB8", VA = "0xB88AB8")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xB88B28", Offset = "0xB88B28", VA = "0xB88B28")]
		public ParticleGroupPlayer()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class SimpleDecal : MonoBehaviour
	{
		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool canRotate;

		[Token(Token = "0x1700005E")]
		public bool CanRotate
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0xB88B30", Offset = "0xB88B30", VA = "0xB88B30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xB88B38", Offset = "0xB88B38", VA = "0xB88B38")]
		public SimpleDecal()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[RequireComponent(typeof(ParticleSystem))]
	public class SmokeController : MonoBehaviour
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color startColor;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color endColor;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float startEmission;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float endEmission;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float shapeRadiusStart;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float shapeRadiusEnd;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float duration;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem particles;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float elapsedTime;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xB88B40", Offset = "0xB88B40", VA = "0xB88B40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB88B9C", Offset = "0xB88B9C", VA = "0xB88B9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB88D0C", Offset = "0xB88D0C", VA = "0xB88D0C")]
		public SmokeController()
		{
		}
	}
}
namespace HurricaneVR.Framework.Shared.HandPoser
{
	[Token(Token = "0x2000049")]
	[RequireComponent(typeof(HVRIKTargets))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(VRIK))]
	public class HVREditorIK : MonoBehaviour
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HVRIKTargets Targets;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ForceEditorIK;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x1700005F")]
		public Transform LeftTarget
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0xB88D40", Offset = "0xB88D40", VA = "0xB88D40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Transform RightTarget
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0xB88D5C", Offset = "0xB88D5C", VA = "0xB88D5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB88D78", Offset = "0xB88D78", VA = "0xB88D78")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB88ED4", Offset = "0xB88ED4", VA = "0xB88ED4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB88ED8", Offset = "0xB88ED8", VA = "0xB88ED8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB890B0", Offset = "0xB890B0", VA = "0xB890B0")]
		public HVREditorIK()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200004A")]
	public class CameraFly : MonoBehaviour
	{
		[Token(Token = "0x200004B")]
		private class CameraState
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000205")]
			[Address(RVA = "0xB8910C", Offset = "0xB8910C", VA = "0xB8910C")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000206")]
			[Address(RVA = "0xB89664", Offset = "0xB89664", VA = "0xB89664")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000207")]
			[Address(RVA = "0xB896E4", Offset = "0xB896E4", VA = "0xB896E4")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000208")]
			[Address(RVA = "0xB8976C", Offset = "0xB8976C", VA = "0xB8976C")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000209")]
			[Address(RVA = "0xB89990", Offset = "0xB89990", VA = "0xB89990")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float positionLerpTime;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rotationLerpTime;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB890B8", Offset = "0xB890B8", VA = "0xB890B8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB89190", Offset = "0xB89190", VA = "0xB89190")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB893C0", Offset = "0xB893C0", VA = "0xB893C0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0xB897B4", Offset = "0xB897B4", VA = "0xB897B4")]
		public CameraFly()
		{
		}
	}
}
