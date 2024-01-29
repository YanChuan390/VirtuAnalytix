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
	[Address(RVA = "0xB16790", Offset = "0xB16790", VA = "0xB16790")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xB16814", Offset = "0xB16814", VA = "0xB16814")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xB16838", Offset = "0xB16838", VA = "0xB16838")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xB168AC", Offset = "0xB168AC", VA = "0xB168AC")]
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
	[Address(RVA = "0xB168F4", Offset = "0xB168F4", VA = "0xB168F4")]
	public void EquipSkewer()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xB1692C", Offset = "0xB1692C", VA = "0xB1692C")]
	public void EquipLastWeapon()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xB16964", Offset = "0xB16964", VA = "0xB16964")]
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
	[Address(RVA = "0xB1696C", Offset = "0xB1696C", VA = "0xB1696C")]
	public void TestPlayerPath(int id)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xB16AA8", Offset = "0xB16AA8", VA = "0xB16AA8")]
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
	[Address(RVA = "0xB16AB0", Offset = "0xB16AB0", VA = "0xB16AB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xB16B28", Offset = "0xB16B28", VA = "0xB16B28")]
	private void Update()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xB16C7C", Offset = "0xB16C7C", VA = "0xB16C7C")]
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
	[Address(RVA = "0xB16CA0", Offset = "0xB16CA0", VA = "0xB16CA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xB16D18", Offset = "0xB16D18", VA = "0xB16D18")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xB16FCC", Offset = "0xB16FCC", VA = "0xB16FCC")]
	public AGGlobalSnow()
	{
	}
}
[Token(Token = "0x2000007")]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[DisallowMultipleComponent]
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
	[Address(RVA = "0xB17008", Offset = "0xB17008", VA = "0xB17008")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xB17080", Offset = "0xB17080", VA = "0xB17080")]
	private void Update()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xB1711C", Offset = "0xB1711C", VA = "0xB1711C")]
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
	[Address(RVA = "0xB17134", Offset = "0xB17134", VA = "0xB17134")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xB171AC", Offset = "0xB171AC", VA = "0xB171AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xB17224", Offset = "0xB17224", VA = "0xB17224")]
	public AGGlobalSnowHeight()
	{
	}
}
[Token(Token = "0x2000009")]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[DisallowMultipleComponent]
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
	[Address(RVA = "0xB17238", Offset = "0xB17238", VA = "0xB17238")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xB172B0", Offset = "0xB172B0", VA = "0xB172B0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xB1734C", Offset = "0xB1734C", VA = "0xB1734C")]
	public AGGlobalSnowProps()
	{
	}
}
[Token(Token = "0x200000A")]
[RequireComponent(typeof(MeshRenderer))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
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
	[Address(RVA = "0xB17364", Offset = "0xB17364", VA = "0xB17364")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xB173DC", Offset = "0xB173DC", VA = "0xB173DC")]
	private void Update()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xB174A4", Offset = "0xB174A4", VA = "0xB174A4")]
	public AGGlobalSnowTree()
	{
	}
}
[Token(Token = "0x200000B")]
[RequireComponent(typeof(MeshRenderer))]
[DisallowMultipleComponent]
[ExecuteInEditMode]
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
	[Address(RVA = "0xB174B4", Offset = "0xB174B4", VA = "0xB174B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xB1752C", Offset = "0xB1752C", VA = "0xB1752C")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xB1771C", Offset = "0xB1771C", VA = "0xB1771C")]
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
		[Address(RVA = "0xB17740", Offset = "0xB17740", VA = "0xB17740")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000020")]
		[Address(RVA = "0xB177B4", Offset = "0xB177B4", VA = "0xB177B4")]
		set
		{
		}
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xB17854", Offset = "0xB17854", VA = "0xB17854")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xB1792C", Offset = "0xB1792C", VA = "0xB1792C", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xB1796C", Offset = "0xB1796C", VA = "0xB1796C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xB1794C", Offset = "0xB1794C", VA = "0xB1794C")]
	private void SetCameraOffset()
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xB17A6C", Offset = "0xB17A6C", VA = "0xB17A6C")]
	[Preserve]
	private static void OnCameraOffsetChange(Changed<CameraOffsetSynchronizer> changed)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xB179F8", Offset = "0xB179F8", VA = "0xB179F8")]
	private IEnumerator SetCameraOffsetAfterSpawn()
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xB17AE8", Offset = "0xB17AE8", VA = "0xB17AE8")]
	public CameraOffsetSynchronizer()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xB17AF0", Offset = "0xB17AF0", VA = "0xB17AF0", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xB17AF8", Offset = "0xB17AF8", VA = "0xB17AF8", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x200000E")]
public class ERVegetationStudio : ScriptableObject
{
	[Token(Token = "0x6000030")]
	[Address(RVA = "0xB17C44", Offset = "0xB17C44", VA = "0xB17C44")]
	public static bool VegetationStudio()
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xB17C4C", Offset = "0xB17C4C", VA = "0xB17C4C")]
	public static bool VegetationStudioPro()
	{
		return default(bool);
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xB17C54", Offset = "0xB17C54", VA = "0xB17C54")]
	public ERVegetationStudio()
	{
	}
}
[Token(Token = "0x200000F")]
public class runtimeScript : MonoBehaviour
{
	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ERRoadNetwork roadNetwork;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ERRoad road;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject go;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int currentElement;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float distance;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xB17C5C", Offset = "0xB17C5C", VA = "0xB17C5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xB17F84", Offset = "0xB17F84", VA = "0xB17F84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xB1806C", Offset = "0xB1806C", VA = "0xB1806C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xB180FC", Offset = "0xB180FC", VA = "0xB180FC")]
	public runtimeScript()
	{
	}
}
[Token(Token = "0x2000010")]
[RequireComponent(typeof(VRIK))]
public class HVRVRIKTeleportHandler : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRIK VRIK;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xB1810C", Offset = "0xB1810C", VA = "0xB1810C")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xB18164", Offset = "0xB18164", VA = "0xB18164")]
	public void AfterTeleport()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xB18188", Offset = "0xB18188", VA = "0xB18188")]
	public HVRVRIKTeleportHandler()
	{
	}
}
[Token(Token = "0x2000011")]
internal class UVTextureAnimator : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Rows;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Columns;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float Fps;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int OffsetMat;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float StartDelay;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool IsInterpolateFrames;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BFX_TextureShaderProperties[] TextureNames;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] TextureNamesCached;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve FrameOverTime;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer currentRenderer;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Projector projector;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material instanceMaterial;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float animationStartTime;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool canUpdate;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int previousIndex;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int totalFrames;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float currentInterpolatedTime;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int currentIndex;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector2 size;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private bool isInitialized;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool startDelayIsBroken;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xB18190", Offset = "0xB18190", VA = "0xB18190")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xB1835C", Offset = "0xB1835C", VA = "0xB1835C")]
	private void Start()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xB184B4", Offset = "0xB184B4", VA = "0xB184B4")]
	private void Update()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xB184C4", Offset = "0xB184C4", VA = "0xB184C4")]
	private void ManualUpdate()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xB18A0C", Offset = "0xB18A0C", VA = "0xB18A0C")]
	private void StartDelayFunc()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xB181A0", Offset = "0xB181A0", VA = "0xB181A0")]
	private void InitDefaultVariables()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xB18A30", Offset = "0xB18A30", VA = "0xB18A30")]
	private void InitializeMaterial()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xB184FC", Offset = "0xB184FC", VA = "0xB184FC")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xB186F0", Offset = "0xB186F0", VA = "0xB186F0")]
	private void SetSpriteAnimation()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xB188B4", Offset = "0xB188B4", VA = "0xB188B4")]
	private void SetSpriteAnimationIterpolated()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xB18C90", Offset = "0xB18C90", VA = "0xB18C90")]
	public UVTextureAnimator()
	{
	}
}
[Token(Token = "0x2000012")]
public enum BFX_TextureShaderProperties
{
	[Token(Token = "0x400005F")]
	_MainTex,
	[Token(Token = "0x4000060")]
	_DistortTex,
	[Token(Token = "0x4000061")]
	_Mask,
	[Token(Token = "0x4000062")]
	_Cutout,
	[Token(Token = "0x4000063")]
	_CutoutTex,
	[Token(Token = "0x4000064")]
	_Bump,
	[Token(Token = "0x4000065")]
	_BumpTex,
	[Token(Token = "0x4000066")]
	_EmissionTex
}
[Token(Token = "0x2000013")]
public class FusionGraph : FusionGraphBase
{
	[Token(Token = "0x2000014")]
	public enum Layouts
	{
		[Token(Token = "0x400008B")]
		Auto,
		[Token(Token = "0x400008C")]
		FullAuto,
		[Token(Token = "0x400008D")]
		FullNoOverlap,
		[Token(Token = "0x400008E")]
		CenteredAuto,
		[Token(Token = "0x400008F")]
		CenteredNoGraph,
		[Token(Token = "0x4000090")]
		CenteredNoOverlap,
		[Token(Token = "0x4000091")]
		CompactAuto,
		[Token(Token = "0x4000092")]
		CompactNoGraph
	}

	[Token(Token = "0x2000015")]
	public enum ShowGraphOptions
	{
		[Token(Token = "0x4000094")]
		Never,
		[Token(Token = "0x4000095")]
		OverlayOnly,
		[Token(Token = "0x4000096")]
		Always
	}

	[Token(Token = "0x2000016")]
	private enum ShaderType
	{
		[Token(Token = "0x4000098")]
		None,
		[Token(Token = "0x4000099")]
		Overlay,
		[Token(Token = "0x400009A")]
		GameObject
	}

	[Token(Token = "0x4000067")]
	private const int GRPH_TOP_PAD = 36;

	[Token(Token = "0x4000068")]
	private const int GRPH_BTM_PAD = 36;

	[Token(Token = "0x4000069")]
	private const int HIDE_XTRAS_WDTH = 200;

	[Token(Token = "0x400006A")]
	private const int INTERMITTENT_DATA_ARRAYSIZE = 128;

	[Token(Token = "0x400006B")]
	private const int EXPAND_GRPH_THRESH = 112;

	[Token(Token = "0x400006C")]
	private const int COMPACT_THRESH = 52;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[SerializeField]
	public float Height;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[SerializeField]
	private Layouts _layout;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private ShowGraphOptions _showGraph;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float Padding;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private bool _alwaysExpandGraph;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
	[SerializeField]
	private bool _showUITargets;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image GraphImg;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Text LabelMin;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Text LabelMax;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Text LabelAvg;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Text LabelLast;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Text LabelPer;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Dropdown _viewDropdown;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Button _avgBttn;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float _min;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	private float _max;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private float[] _values;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private float[] _intensity;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private float[] _histogram;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private List<int> DropdownLookup;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private FusionGraphVisualization _graphVisualization;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private ShaderType _currentShader;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private (int, float)[] _cachedValues;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private double _lastCachedTickTime;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private int _lastCachedTick;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private int _histoHighestUsedBucketIndex;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private int _histoAvgSampleCount;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private double _histoStepInverse;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private double _histoAvg;

	[Token(Token = "0x17000004")]
	private static Shader Shader
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0xB18D34", Offset = "0xB18D34", VA = "0xB18D34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000005")]
	public Layouts Layout
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xB18D8C", Offset = "0xB18D8C", VA = "0xB18D8C")]
		get
		{
			return default(Layouts);
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0xB18D94", Offset = "0xB18D94", VA = "0xB18D94")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public ShowGraphOptions ShowGraph
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0xB18DA4", Offset = "0xB18DA4", VA = "0xB18DA4")]
		get
		{
			return default(ShowGraphOptions);
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0xB18DAC", Offset = "0xB18DAC", VA = "0xB18DAC")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public bool AlwaysExpandGraph
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xB18DD4", Offset = "0xB18DD4", VA = "0xB18DD4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xB18DDC", Offset = "0xB18DDC", VA = "0xB18DDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public FusionGraphVisualization GraphVisualization
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0xB196B4", Offset = "0xB196B4", VA = "0xB196B4")]
		set
		{
		}
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xB18E08", Offset = "0xB18E08", VA = "0xB18E08", Slot = "14")]
	protected override bool TryConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xB196BC", Offset = "0xB196BC", VA = "0xB196BC")]
	private void Reset()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xB1999C", Offset = "0xB1999C", VA = "0xB1999C")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xB19A38", Offset = "0xB19A38", VA = "0xB19A38", Slot = "10")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xB19B44", Offset = "0xB19B44", VA = "0xB19B44")]
	public void OnDropdownChanged(int value)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xB19BB0", Offset = "0xB19BB0", VA = "0xB19BB0")]
	private void ResetShaderButton()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xB19704", Offset = "0xB19704", VA = "0xB19704")]
	private void ResetGraphShader()
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xB19E5C", Offset = "0xB19E5C", VA = "0xB19E5C", Slot = "11")]
	public override void CyclePer()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xB194CC", Offset = "0xB194CC", VA = "0xB194CC")]
	private void SetPerText()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xB19EE8", Offset = "0xB19EE8", VA = "0xB19EE8", Slot = "13")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xB1A1E0", Offset = "0xB1A1E0", VA = "0xB1A1E0")]
	private void UpdateContinuousTick(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xB1A820", Offset = "0xB1A820", VA = "0xB1A820")]
	private void UpdateIntermittentTick(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xB1AD40", Offset = "0xB1AD40", VA = "0xB1AD40")]
	private void UpdateIntermittentTime(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xB1BA50", Offset = "0xB1BA50", VA = "0xB1BA50")]
	private void ApplyScaling(ref float min, ref float max)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xB1BB70", Offset = "0xB1BB70", VA = "0xB1BB70")]
	private void UpdateUiText(float min, float max, float avg, float last)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xB1C24C", Offset = "0xB1C24C", VA = "0xB1C24C")]
	private float GetIntermittentAverageInfo(ref IStatsBuffer data, float sum)
	{
		return default(float);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xB1AFEC", Offset = "0xB1AFEC", VA = "0xB1AFEC")]
	private void UpdateTickValueHistogram(ref IStatsBuffer data)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xB1C504", Offset = "0xB1C504", VA = "0xB1C504")]
	public static FusionGraph Create(FusionStats iFusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, RectTransform parentRT)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xB1C628", Offset = "0xB1C628", VA = "0xB1C628")]
	public void Generate(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform root)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xB1CD1C", Offset = "0xB1CD1C", VA = "0xB1CD1C", Slot = "12")]
	public override void CalculateLayout()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xB1D99C", Offset = "0xB1D99C", VA = "0xB1D99C")]
	public FusionGraph()
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteAlways]
public class FusionStats : Fusion.Behaviour
{
	[Token(Token = "0x2000018")]
	public enum StatCanvasTypes
	{
		[Token(Token = "0x4000109")]
		Overlay,
		[Token(Token = "0x400010A")]
		GameObject
	}

	[Token(Token = "0x2000019")]
	public enum DefaultLayouts
	{
		[Token(Token = "0x400010C")]
		Custom,
		[Token(Token = "0x400010D")]
		Left,
		[Token(Token = "0x400010E")]
		Right,
		[Token(Token = "0x400010F")]
		UpperLeft,
		[Token(Token = "0x4000110")]
		UpperRight,
		[Token(Token = "0x4000111")]
		Full
	}

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Dictionary<NetworkRunner, List<FusionStats>> _statsForRunnerLookup;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, FusionStats> _activeGuids;

	[Token(Token = "0x400009D")]
	public const Simulation.Statistics.SimStatFlags DefaultSimStatsMask = Simulation.Statistics.SimStatFlags.ForwardSimCount | Simulation.Statistics.SimStatFlags.ResimCount | Simulation.Statistics.SimStatFlags.PacketSize;

	[Token(Token = "0x400009E")]
	private const int SCREEN_SCALE_W = 1080;

	[Token(Token = "0x400009F")]
	private const int SCREEN_SCALE_H = 1080;

	[Token(Token = "0x40000A0")]
	private const float TEXT_MARGIN = 0.25f;

	[Token(Token = "0x40000A1")]
	private const float TITLE_HEIGHT = 20f;

	[Token(Token = "0x40000A2")]
	private const int MARGIN = 6;

	[Token(Token = "0x40000A3")]
	private const int PAD = 10;

	[Token(Token = "0x40000A4")]
	private const string PLAY_TEXT = "PLAY";

	[Token(Token = "0x40000A5")]
	private const string PAUS_TEXT = "PAUSE";

	[Token(Token = "0x40000A6")]
	private const string SHOW_TEXT = "SHOW";

	[Token(Token = "0x40000A7")]
	private const string HIDE_TEXT = "HIDE";

	[Token(Token = "0x40000A8")]
	private const string CLER_TEXT = "CLEAR";

	[Token(Token = "0x40000A9")]
	private const string CNVS_TEXT = "CANVAS";

	[Token(Token = "0x40000AA")]
	private const string CLSE_TEXT = "CLOSE";

	[Token(Token = "0x40000AB")]
	private const string PLAY_ICON = "►";

	[Token(Token = "0x40000AC")]
	private const string PAUS_ICON = "װ";

	[Token(Token = "0x40000AD")]
	private const string HIDE_ICON = "▼";

	[Token(Token = "0x40000AE")]
	private const string SHOW_ICON = "▲";

	[Token(Token = "0x40000AF")]
	private const string CLER_ICON = "ᴓ";

	[Token(Token = "0x40000B0")]
	private const string CNVS_ICON = "ﬦ";

	[Token(Token = "0x40000B1")]
	private const string CLSE_ICON = "x";

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float RedrawInterval;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private StatCanvasTypes _canvasType;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _showButtonLabels;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int _maxHeaderHeight;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float CanvasScale;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float CanvasDistance;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rect _gameObjectRect;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Rect _overlayRect;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private FusionGraph.Layouts _defaultLayout;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	private bool _noTextOverlap;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	[SerializeField]
	private bool _noGraphShader;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int GraphColumnCount;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private int _graphMaxWidth;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private bool _enableObjectStats;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private NetworkObject _object;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private int _objectTitleHeight;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private int _objectIdsHeight;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private int _objectMetersHeight;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private NetworkRunner _runner;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool InitializeAllGraphs;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public SimulationModes ConnectTo;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Simulation.Statistics.ObjStatFlags _includedObjStats;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[SerializeField]
	private Simulation.Statistics.NetStatFlags _includedNetStats;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Simulation.Statistics.SimStatFlags _includedSimStats;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[SerializeField]
	public bool AutoDestroy;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9D")]
	[SerializeField]
	public bool EnforceSingle;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[SerializeField]
	public string Guid;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private bool _modifyColors;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private Color _graphColorGood;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private Color _graphColorWarn;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[SerializeField]
	private Color _graphColorBad;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[SerializeField]
	private Color _graphColorFlag;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	[SerializeField]
	private Color _fontColor;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	[SerializeField]
	private Color PanelColor;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	[SerializeField]
	private Color _simDataBackColor;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	[SerializeField]
	private Color _netDataBackColor;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	[SerializeField]
	private Color _objDataBackColor;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[SerializeField]
	private FusionGraph[] _simGraphs;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private FusionGraph[] _objGraphs;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private FusionGraph[] _netGraphs;

	[NonSerialized]
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private List<IFusionStatsView> _foundViews;

	[NonSerialized]
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private List<FusionGraph> _foundGraphs;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	private Text _titleText;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private Text _clearIcon;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private Text _pauseIcon;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private Text _togglIcon;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private Text _closeIcon;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private Text _canvsIcon;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	[SerializeField]
	private Text _clearLabel;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	[SerializeField]
	private Text _pauseLabel;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[SerializeField]
	private Text _togglLabel;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[SerializeField]
	private Text _closeLabel;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[SerializeField]
	private Text _canvsLabel;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[SerializeField]
	private Text _objectNameText;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	[SerializeField]
	private GridLayoutGroup _graphGridLayoutGroup;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	[SerializeField]
	private Canvas _canvas;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	[SerializeField]
	private RectTransform _canvasRT;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	[SerializeField]
	private RectTransform _rootPanelRT;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	[SerializeField]
	private RectTransform _guidesRT;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	private RectTransform _headerRT;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[SerializeField]
	private RectTransform _statsPanelRT;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	[SerializeField]
	private RectTransform _graphsLayoutRT;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	[SerializeField]
	private RectTransform _titleRT;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	[SerializeField]
	private RectTransform _buttonsRT;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	[SerializeField]
	private RectTransform _objectTitlePanelRT;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[SerializeField]
	private RectTransform _objectIdsGroupRT;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	[SerializeField]
	private RectTransform _objectMetersPanelRT;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	[SerializeField]
	private RectTransform _clientIdPanelRT;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[SerializeField]
	private RectTransform _authorityPanelRT;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	[SerializeField]
	private Button _titleButton;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	[SerializeField]
	private Button _objctButton;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	[SerializeField]
	private Button _clearButton;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	[SerializeField]
	private Button _togglButton;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	[SerializeField]
	private Button _pauseButton;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[SerializeField]
	private Button _closeButton;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[SerializeField]
	private Button _canvsButton;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	private Font _font;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	private bool _hidden;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x281")]
	private bool _paused;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x284")]
	private int _layoutDirty;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	private bool _activeDirty;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	private double _currentDrawTime;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private double _delayDrawUntil;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static bool? _newInputSystemFound;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private string _previousObjectTitle;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private float _lastLayoutUpdate;

	[Token(Token = "0x17000009")]
	public static Simulation.Statistics.NetStatFlags DefaultNetStatsMask
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0xB1E1F4", Offset = "0xB1E1F4", VA = "0xB1E1F4")]
		get
		{
			return default(Simulation.Statistics.NetStatFlags);
		}
	}

	[Token(Token = "0x1700000A")]
	private bool ShowColorControls
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0xB1E1FC", Offset = "0xB1E1FC", VA = "0xB1E1FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	private bool IsNotPlaying
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0xB1E22C", Offset = "0xB1E22C", VA = "0xB1E22C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public StatCanvasTypes CanvasType
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0xB1E248", Offset = "0xB1E248", VA = "0xB1E248")]
		get
		{
			return default(StatCanvasTypes);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0xB1E250", Offset = "0xB1E250", VA = "0xB1E250")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool ShowButtonLabels
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0xB1E280", Offset = "0xB1E280", VA = "0xB1E280")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0xB1E288", Offset = "0xB1E288", VA = "0xB1E288")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public int MaxHeaderHeight
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xB1E2AC", Offset = "0xB1E2AC", VA = "0xB1E2AC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0xB1E2B4", Offset = "0xB1E2B4", VA = "0xB1E2B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public Rect GameObjectRect
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xB1E2D4", Offset = "0xB1E2D4", VA = "0xB1E2D4")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0xB1E2E0", Offset = "0xB1E2E0", VA = "0xB1E2E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public Rect OverlayRect
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xB1E304", Offset = "0xB1E304", VA = "0xB1E304")]
		get
		{
			return default(Rect);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0xB1E310", Offset = "0xB1E310", VA = "0xB1E310")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public FusionGraph.Layouts DefaultLayout
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xB1E334", Offset = "0xB1E334", VA = "0xB1E334")]
		get
		{
			return default(FusionGraph.Layouts);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xB1E33C", Offset = "0xB1E33C", VA = "0xB1E33C")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public bool NoTextOverlap
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0xB1E35C", Offset = "0xB1E35C", VA = "0xB1E35C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0xB1E364", Offset = "0xB1E364", VA = "0xB1E364")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public bool NoGraphShader
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xB1E388", Offset = "0xB1E388", VA = "0xB1E388")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xB1E390", Offset = "0xB1E390", VA = "0xB1E390")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public int GraphMaxWidth
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xB1E3B4", Offset = "0xB1E3B4", VA = "0xB1E3B4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000079")]
		[Address(RVA = "0xB1E3BC", Offset = "0xB1E3BC", VA = "0xB1E3BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public bool EnableObjectStats
	{
		[Token(Token = "0x600007A")]
		[Address(RVA = "0xB1E3DC", Offset = "0xB1E3DC", VA = "0xB1E3DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xB1E3E4", Offset = "0xB1E3E4", VA = "0xB1E3E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	private bool ShowMissingNetObjWarning
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xB1E408", Offset = "0xB1E408", VA = "0xB1E408")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000017")]
	public NetworkObject Object
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xB1E48C", Offset = "0xB1E48C", VA = "0xB1E48C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000018")]
	public int ObjectTitleHeight
	{
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xB1E534", Offset = "0xB1E534", VA = "0xB1E534")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600007F")]
		[Address(RVA = "0xB1E53C", Offset = "0xB1E53C", VA = "0xB1E53C")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public int ObjectIdsHeight
	{
		[Token(Token = "0x6000080")]
		[Address(RVA = "0xB1E55C", Offset = "0xB1E55C", VA = "0xB1E55C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0xB1E564", Offset = "0xB1E564", VA = "0xB1E564")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public int ObjectMetersHeight
	{
		[Token(Token = "0x6000082")]
		[Address(RVA = "0xB1E584", Offset = "0xB1E584", VA = "0xB1E584")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000083")]
		[Address(RVA = "0xB1E58C", Offset = "0xB1E58C", VA = "0xB1E58C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public NetworkRunner Runner
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0xB1C0A0", Offset = "0xB1C0A0", VA = "0xB1C0A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0xB1E08C", Offset = "0xB1E08C", VA = "0xB1E08C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Simulation.Statistics.ObjStatFlags IncludedObjectStats
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xB1E9FC", Offset = "0xB1E9FC", VA = "0xB1E9FC")]
		get
		{
			return default(Simulation.Statistics.ObjStatFlags);
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xB1EA04", Offset = "0xB1EA04", VA = "0xB1EA04")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public Simulation.Statistics.NetStatFlags IncludedNetStats
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xB1EA14", Offset = "0xB1EA14", VA = "0xB1EA14")]
		get
		{
			return default(Simulation.Statistics.NetStatFlags);
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xB1EA1C", Offset = "0xB1EA1C", VA = "0xB1EA1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public Simulation.Statistics.SimStatFlags IncludedSimStats
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0xB1EA2C", Offset = "0xB1EA2C", VA = "0xB1EA2C")]
		get
		{
			return default(Simulation.Statistics.SimStatFlags);
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0xB1EA34", Offset = "0xB1EA34", VA = "0xB1EA34")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool ModifyColors
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0xB1EA44", Offset = "0xB1EA44", VA = "0xB1EA44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public Color FontColor
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0xB1EA4C", Offset = "0xB1EA4C", VA = "0xB1EA4C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000021")]
	public Color GraphColorGood
	{
		[Token(Token = "0x600008E")]
		[Address(RVA = "0xB1EA58", Offset = "0xB1EA58", VA = "0xB1EA58")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000022")]
	public Color GraphColorWarn
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0xB1EA64", Offset = "0xB1EA64", VA = "0xB1EA64")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000023")]
	public Color GraphColorBad
	{
		[Token(Token = "0x6000090")]
		[Address(RVA = "0xB1EA70", Offset = "0xB1EA70", VA = "0xB1EA70")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000024")]
	public Color GraphColorFlag
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xB1EA7C", Offset = "0xB1EA7C", VA = "0xB1EA7C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000025")]
	public Color SimDataBackColor
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xB1EA88", Offset = "0xB1EA88", VA = "0xB1EA88")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000026")]
	public Color NetDataBackColor
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xB1EA9C", Offset = "0xB1EA9C", VA = "0xB1EA9C")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000027")]
	public Color ObjDataBackColor
	{
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xB1EAB0", Offset = "0xB1EAB0", VA = "0xB1EAB0")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000028")]
	public Rect CurrentRect
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0xB1EAC4", Offset = "0xB1EAC4", VA = "0xB1EAC4")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x17000029")]
	private Shader Shader
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0xB1EB08", Offset = "0xB1EB08", VA = "0xB1EB08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002A")]
	public static bool NewInputSystemFound
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0xB20888", Offset = "0xB20888", VA = "0xB20888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002B")]
	private bool _graphsAreMissing
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xB20AB0", Offset = "0xB20AB0", VA = "0xB20AB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xB1DA50", Offset = "0xB1DA50", VA = "0xB1DA50")]
	internal static FusionStats CreateInternal([Optional] NetworkRunner runner, DefaultLayouts layout = DefaultLayouts.Left, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask)
	{
		return null;
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xB1DB18", Offset = "0xB1DB18", VA = "0xB1DB18")]
	public static FusionStats Create([Optional] Transform parent, [Optional] NetworkRunner runner, [Optional] DefaultLayouts? screenLayout, [Optional] DefaultLayouts? objectLayout, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xB1E140", Offset = "0xB1E140", VA = "0xB1E140")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xB1E91C", Offset = "0xB1E91C", VA = "0xB1E91C")]
	private void UpdateTitle()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xB1E26C", Offset = "0xB1E26C", VA = "0xB1E26C")]
	private void DirtyLayout(int minimumRefreshes = 1)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xB1DCEC", Offset = "0xB1DCEC", VA = "0xB1DCEC")]
	private void ResetInternal([Optional] bool? enableObjectStats, [Optional] Simulation.Statistics.NetStatFlags? netStatsMask, [Optional] Simulation.Statistics.SimStatFlags? simStatsMask, [Optional] DefaultLayouts? objectLayout, [Optional] DefaultLayouts? screenLayout)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xB1FBDC", Offset = "0xB1FBDC", VA = "0xB1FBDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xB1FEDC", Offset = "0xB1FEDC", VA = "0xB1FEDC")]
	private void Start()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xB206B4", Offset = "0xB206B4", VA = "0xB206B4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xB207DC", Offset = "0xB207DC", VA = "0xB207DC")]
	private void DestroyGraphs()
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xB1FF10", Offset = "0xB1FF10", VA = "0xB1FF10")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xB1EEFC", Offset = "0xB1EEFC", VA = "0xB1EEFC")]
	private void GenerateGraphs()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xB1E6D4", Offset = "0xB1E6D4", VA = "0xB1E6D4")]
	private void AssociateWithRunner(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xB1E5AC", Offset = "0xB1E5AC", VA = "0xB1E5AC")]
	private void DisassociateWithRunner(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xB20EEC", Offset = "0xB20EEC", VA = "0xB20EEC")]
	private void Pause()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xB211B8", Offset = "0xB211B8", VA = "0xB211B8")]
	private void Toggle()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xB214F0", Offset = "0xB214F0", VA = "0xB214F0")]
	private void Clear()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xB216E8", Offset = "0xB216E8", VA = "0xB216E8")]
	private void ToggleCanvasType()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xB22538", Offset = "0xB22538", VA = "0xB22538")]
	private void Close()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xB225A4", Offset = "0xB225A4", VA = "0xB225A4")]
	private void PingSelectObject()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xB225A8", Offset = "0xB225A8", VA = "0xB225A8")]
	private void PingSelectFusionStats()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xB225AC", Offset = "0xB225AC", VA = "0xB225AC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xB22CFC", Offset = "0xB22CFC", VA = "0xB22CFC")]
	private void RefreshObjectValues()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xB20DA0", Offset = "0xB20DA0", VA = "0xB20DA0")]
	public FusionGraph CreateGraph(Simulation.Statistics.StatSourceTypes type, int statId, RectTransform parentRT)
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xB22908", Offset = "0xB22908", VA = "0xB22908")]
	private void ReapplyEnabled()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xB21714", Offset = "0xB21714", VA = "0xB21714")]
	private void CalculateLayout()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xB1EC80", Offset = "0xB1EC80", VA = "0xB1EC80")]
	private void ApplyDefaultLayout(DefaultLayouts defaults, [Optional] StatCanvasTypes? applyForCanvasType)
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xB22DD8", Offset = "0xB22DD8", VA = "0xB22DD8")]
	public FusionStats()
	{
	}
}
[Token(Token = "0x200001A")]
public abstract class FusionGraphBase : Fusion.Behaviour, IFusionStatsView
{
	[Token(Token = "0x200001B")]
	public enum StatsPer
	{
		[Token(Token = "0x4000125")]
		Default = 0,
		[Token(Token = "0x4000126")]
		Individual = 1,
		[Token(Token = "0x4000127")]
		Tick = 2,
		[Token(Token = "0x4000128")]
		Second = 4
	}

	[Token(Token = "0x4000112")]
	protected const int PAD = 10;

	[Token(Token = "0x4000113")]
	protected const int MRGN = 6;

	[Token(Token = "0x4000114")]
	protected const int MAX_FONT_SIZE_WITH_GRAPH = 24;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Text LabelTitle;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected Image BackImage;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected Simulation.Statistics.StatSourceTypes _statSourceType;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	protected int _statId;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public StatsPer StatsPerDefault;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float WarnThreshold;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float ErrorThreshold;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected IStatsBuffer _statsBuffer;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool _isOverlay;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected FusionStats _fusionStats;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected bool _layoutDirty;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	protected Simulation.Statistics.StatsPer CurrentPer;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Simulation.Statistics.StatSourceInfo StatSourceInfo;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private Simulation.Statistics.StatSourceTypes _prevStatSourceType;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[SerializeField]
	private int _prevStatId;

	[Token(Token = "0x1700002C")]
	public Simulation.Statistics.StatSourceTypes StateSourceType
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xB23018", Offset = "0xB23018", VA = "0xB23018")]
		get
		{
			return default(Simulation.Statistics.StatSourceTypes);
		}
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xB23020", Offset = "0xB23020", VA = "0xB23020")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public int StatId
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xB23034", Offset = "0xB23034", VA = "0xB23034")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xB2303C", Offset = "0xB2303C", VA = "0xB2303C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002E")]
	public IStatsBuffer StatsBuffer
	{
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xB1A1B0", Offset = "0xB1A1B0", VA = "0xB1A1B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700002F")]
	public bool IsOverlay
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xB23088", Offset = "0xB23088", VA = "0xB23088")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xB23050", Offset = "0xB23050", VA = "0xB23050")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	protected virtual Color BackColor
	{
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xB23090", Offset = "0xB23090", VA = "0xB23090", Slot = "9")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x17000031")]
	protected Type CastToStatType
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xB23104", Offset = "0xB23104", VA = "0xB23104")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xB19DB4", Offset = "0xB19DB4", VA = "0xB19DB4")]
	protected FusionStats LocateParentFusionStats()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xB231BC", Offset = "0xB231BC", VA = "0xB231BC", Slot = "10")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xB19E90", Offset = "0xB19E90", VA = "0xB19E90", Slot = "11")]
	public virtual void CyclePer()
	{
	}

	[Token(Token = "0x60000BF")]
	public abstract void CalculateLayout();

	[Token(Token = "0x60000C0")]
	public abstract void Refresh();

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xB19160", Offset = "0xB19160", VA = "0xB19160", Slot = "14")]
	protected virtual bool TryConnect()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xB1D86C", Offset = "0xB1D86C", VA = "0xB1D86C")]
	protected void ApplyTitleText()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xB231C0", Offset = "0xB231C0", VA = "0xB231C0")]
	protected void CheckIfValidIncurrentMode(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xB1DA40", Offset = "0xB1DA40", VA = "0xB1DA40")]
	protected FusionGraphBase()
	{
	}

	[SpecialName]
	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xB23364", Offset = "0xB23364", VA = "0xB23364", Slot = "7")]
	private bool Fusion.StatsInternal.IFusionStatsView.get_isActiveAndEnabled()
	{
		return default(bool);
	}

	[SpecialName]
	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xB2336C", Offset = "0xB2336C", VA = "0xB2336C", Slot = "8")]
	private Transform Fusion.StatsInternal.IFusionStatsView.get_transform()
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
[ExecuteAlways]
public class FusionStatsBillboard : Fusion.Behaviour
{
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera Camera;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float _lastCameraFindTime;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Camera _currentCam;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private FusionStats _fusionStats;

	[Token(Token = "0x17000032")]
	private Camera MainCamera
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xB23450", Offset = "0xB23450", VA = "0xB23450")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xB23400", Offset = "0xB23400", VA = "0xB23400")]
		set
		{
		}
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xB23374", Offset = "0xB23374", VA = "0xB23374")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xB233CC", Offset = "0xB233CC", VA = "0xB233CC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xB233D0", Offset = "0xB233D0", VA = "0xB233D0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xB234DC", Offset = "0xB234DC", VA = "0xB234DC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xB1EB60", Offset = "0xB1EB60", VA = "0xB1EB60")]
	public void UpdateLookAt()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xB234E0", Offset = "0xB234E0", VA = "0xB234E0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
	private static void ResetStatics()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xB2353C", Offset = "0xB2353C", VA = "0xB2353C")]
	public FusionStatsBillboard()
	{
	}
}
[Token(Token = "0x200001D")]
public class FusionStatsMeterBar : FusionGraphBase
{
	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float HoldPeakTime;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float DecayTime;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public int MeterMax;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[SerializeField]
	private bool _showUITargets;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Text ValueLabel;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Image Bar;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private double _currentDisplayValue;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private double _currentBarValue;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Color CurrentColor;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private double _lastImportedSampleTickTime;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private double _max;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private double _total;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private float _lastPeakSetTime;

	[Token(Token = "0x17000033")]
	protected override Color BackColor
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xB23544", Offset = "0xB23544", VA = "0xB23544", Slot = "9")]
		get
		{
			return default(Color);
		}
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xB23564", Offset = "0xB23564", VA = "0xB23564", Slot = "10")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xB237A8", Offset = "0xB237A8", VA = "0xB237A8", Slot = "13")]
	public override void Refresh()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xB23FD4", Offset = "0xB23FD4", VA = "0xB23FD4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xB23E34", Offset = "0xB23E34", VA = "0xB23E34")]
	public void SetValue(double rawvalue)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xB240B4", Offset = "0xB240B4", VA = "0xB240B4")]
	private void SetBar(double value)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xB24234", Offset = "0xB24234", VA = "0xB24234", Slot = "12")]
	public override void CalculateLayout()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xB20C24", Offset = "0xB20C24", VA = "0xB20C24")]
	public static FusionStatsMeterBar Create(RectTransform parent, FusionStats fusionStats, Simulation.Statistics.StatSourceTypes statSourceType, int statId, float warnThreshold, float alertThreshold)
	{
		return null;
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xB24390", Offset = "0xB24390", VA = "0xB24390")]
	public void GenerateMeter()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xB2479C", Offset = "0xB2479C", VA = "0xB2479C")]
	public FusionStatsMeterBar()
	{
	}
}
[Token(Token = "0x200001E")]
public class FusionStatsObjectIds : Fusion.Behaviour, IFusionStatsView
{
	[Token(Token = "0x400013A")]
	protected const int PAD = 10;

	[Token(Token = "0x400013B")]
	protected const int MARGIN = 6;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Text _inputValueText;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Text _stateValueText;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Text _objectIdLabel;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Image _stateAuthBackImage;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Image _inputAuthBackImage;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FusionStats _fusionStats;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Color _noneAuthColor;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Color _inputAuthColor;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Color _stateAuthColor;

	[Token(Token = "0x4000145")]
	private const float LABEL_DIVIDING_POINT = 0.7f;

	[Token(Token = "0x4000146")]
	private const float TEXT_PAD = 4f;

	[Token(Token = "0x4000147")]
	private const float TEXT_PAD_HORIZ = 6f;

	[Token(Token = "0x4000148")]
	private const int MAX_TAG_FONT_SIZE = 18;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool _previousHasInputAuth;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private bool _previousHasStateAuth;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int _previousInputAuthValue;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int _previousStateAuthValue;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private uint _previousObjectIdValue;

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xB247B8", Offset = "0xB247B8", VA = "0xB247B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xB24810", Offset = "0xB24810", VA = "0xB24810", Slot = "4")]
	private void Fusion.StatsInternal.IFusionStatsView.Initialize()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xB20B10", Offset = "0xB20B10", VA = "0xB20B10")]
	public static RectTransform Create(RectTransform parent, FusionStats fusionStats)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xB24814", Offset = "0xB24814", VA = "0xB24814")]
	public void Generate()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xB24B30", Offset = "0xB24B30", VA = "0xB24B30")]
	private RectTransform AddAuthorityPanel(RectTransform parent, string label, ref Text valueText, ref Image backImage)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xB24DD0", Offset = "0xB24DD0", VA = "0xB24DD0", Slot = "5")]
	private void Fusion.StatsInternal.IFusionStatsView.CalculateLayout()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xB24DD4", Offset = "0xB24DD4", VA = "0xB24DD4", Slot = "6")]
	private void Fusion.StatsInternal.IFusionStatsView.Refresh()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xB251BC", Offset = "0xB251BC", VA = "0xB251BC")]
	public FusionStatsObjectIds()
	{
	}

	[SpecialName]
	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xB25240", Offset = "0xB25240", VA = "0xB25240", Slot = "7")]
	private bool Fusion.StatsInternal.IFusionStatsView.get_isActiveAndEnabled()
	{
		return default(bool);
	}

	[SpecialName]
	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xB25248", Offset = "0xB25248", VA = "0xB25248", Slot = "8")]
	private Transform Fusion.StatsInternal.IFusionStatsView.get_transform()
	{
		return null;
	}
}
[Token(Token = "0x200001F")]
[NetworkBehaviourWeaved(0)]
public class PlayerAOIPrototype : NetworkBehaviour
{
	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected bool DrawAreaOfInterestRadius;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public float Radius;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<PlayerAOIPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<PlayerAOIPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<PlayerAOIPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xB25250", Offset = "0xB25250", VA = "0xB25250", Slot = "8")]
	public override void FixedUpdateNetwork()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xB25358", Offset = "0xB25358", VA = "0xB25358")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xB253FC", Offset = "0xB253FC", VA = "0xB253FC")]
	public PlayerAOIPrototype()
	{
	}
}
[Token(Token = "0x2000020")]
[NetworkBehaviourWeaved(3)]
public class ControllerPrototype : NetworkBehaviour
{
	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected NetworkCharacterControllerPrototype _ncc;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected NetworkRigidbody _nrb;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected NetworkRigidbody2D _nrb2d;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected NetworkTransform _nt;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Vector3 _MovementDirection;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool TransformLocal;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float Speed;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<ControllerPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<ControllerPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<ControllerPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x17000034")]
	[Networked]
	[NetworkedWeaved(0, 3)]
	public Vector3 MovementDirection
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xB2540C", Offset = "0xB2540C", VA = "0xB2540C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xB25494", Offset = "0xB25494", VA = "0xB25494")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	private bool ShowSpeed
	{
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xB25578", Offset = "0xB25578", VA = "0xB25578")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xB25618", Offset = "0xB25618", VA = "0xB25618")]
	public void Awake()
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xB257D0", Offset = "0xB257D0", VA = "0xB257D0", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xB2561C", Offset = "0xB2561C", VA = "0xB2561C")]
	private void CacheComponents()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xB257D4", Offset = "0xB257D4", VA = "0xB257D4", Slot = "8")]
	public override void FixedUpdateNetwork()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xB25DA8", Offset = "0xB25DA8", VA = "0xB25DA8")]
	public ControllerPrototype()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xB25DB8", Offset = "0xB25DB8", VA = "0xB25DB8", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xB25DC4", Offset = "0xB25DC4", VA = "0xB25DC4", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000021")]
public class InputBehaviourPrototype : Fusion.Behaviour, INetworkRunnerCallbacks
{
	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xB25DE0", Offset = "0xB25DE0", VA = "0xB25DE0", Slot = "6")]
	public void OnInput(NetworkRunner runner, NetworkInput input)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xB2600C", Offset = "0xB2600C", VA = "0xB2600C", Slot = "7")]
	public void OnInputMissing(NetworkRunner runner, PlayerRef player, NetworkInput input)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xB26010", Offset = "0xB26010", VA = "0xB26010", Slot = "9")]
	public void OnConnectedToServer(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xB26014", Offset = "0xB26014", VA = "0xB26014", Slot = "12")]
	public void OnConnectFailed(NetworkRunner runner, NetAddress remoteAddress, NetConnectFailedReason reason)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xB26018", Offset = "0xB26018", VA = "0xB26018", Slot = "11")]
	public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xB2601C", Offset = "0xB2601C", VA = "0xB2601C", Slot = "10")]
	public void OnDisconnectedFromServer(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xB26020", Offset = "0xB26020", VA = "0xB26020", Slot = "4")]
	public void OnPlayerJoined(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xB26024", Offset = "0xB26024", VA = "0xB26024", Slot = "5")]
	public void OnPlayerLeft(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xB26028", Offset = "0xB26028", VA = "0xB26028", Slot = "13")]
	public void OnUserSimulationMessage(NetworkRunner runner, SimulationMessagePtr message)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xB2602C", Offset = "0xB2602C", VA = "0xB2602C", Slot = "8")]
	public void OnShutdown(NetworkRunner runner, ShutdownReason shutdownReason)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xB26030", Offset = "0xB26030", VA = "0xB26030", Slot = "14")]
	public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xB26034", Offset = "0xB26034", VA = "0xB26034", Slot = "17")]
	public void OnReliableDataReceived(NetworkRunner runner, PlayerRef player, ArraySegment<byte> data)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xB26038", Offset = "0xB26038", VA = "0xB26038", Slot = "18")]
	public void OnSceneLoadDone(NetworkRunner runner)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xB2603C", Offset = "0xB2603C", VA = "0xB2603C", Slot = "19")]
	public void OnSceneLoadStart(NetworkRunner runner)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xB26040", Offset = "0xB26040", VA = "0xB26040", Slot = "15")]
	public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xB26044", Offset = "0xB26044", VA = "0xB26044", Slot = "16")]
	public void OnHostMigration(NetworkRunner runner, HostMigrationToken hostMigrationToken)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xB26048", Offset = "0xB26048", VA = "0xB26048")]
	public InputBehaviourPrototype()
	{
	}
}
[StructLayout(2)]
[Token(Token = "0x2000022")]
[NetworkInputWeaved(4)]
public struct NetworkInputPrototype : INetworkInput
{
	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public NetworkButtons Buttons;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public byte Weapon;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Angle Yaw;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public Angle Pitch;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xB25DA0", Offset = "0xB25DA0", VA = "0xB25DA0")]
	public bool IsDown(int button)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000023")]
[OrderBefore(new Type[] { typeof(NetworkTransform) })]
[DisallowMultipleComponent]
[RequireComponent(typeof(CharacterController))]
[NetworkBehaviourWeaved(24)]
public class NetworkCharacterControllerPrototype : NetworkTransform
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public float gravity;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float jumpImpulse;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float acceleration;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public float braking;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float maxSpeed;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float rotationSpeed;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	[SerializeField]
	private bool _IsGrounded;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	private Vector3 _Velocity;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Changed<NetworkCharacterControllerPrototype> $IL2CPP_CHANGED;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static ChangedDelegate<NetworkCharacterControllerPrototype> $IL2CPP_CHANGED_DELEGATE;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static NetworkBehaviourCallbacks<NetworkCharacterControllerPrototype> $IL2CPP_NETWORK_BEHAVIOUR_CALLBACKS;

	[Token(Token = "0x17000036")]
	[NetworkedWeaved(20, 1)]
	[Networked]
	public bool IsGrounded
	{
		[Token(Token = "0x6000104")]
		[Address(RVA = "0xB26050", Offset = "0xB26050", VA = "0xB26050")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000105")]
		[Address(RVA = "0xB260BC", Offset = "0xB260BC", VA = "0xB260BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	[NetworkedWeaved(21, 3)]
	[Networked]
	public Vector3 Velocity
	{
		[Token(Token = "0x6000106")]
		[Address(RVA = "0xB26124", Offset = "0xB26124", VA = "0xB26124")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000107")]
		[Address(RVA = "0xB261AC", Offset = "0xB261AC", VA = "0xB261AC")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	protected override Vector3 DefaultTeleportInterpolationVelocity
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xB26290", Offset = "0xB26290", VA = "0xB26290", Slot = "49")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000039")]
	protected override Vector3 DefaultTeleportInterpolationAngularVelocity
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xB26294", Offset = "0xB26294", VA = "0xB26294", Slot = "50")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x1700003A")]
	public CharacterController Controller
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xB262A4", Offset = "0xB262A4", VA = "0xB262A4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600010B")]
		[Address(RVA = "0xB262AC", Offset = "0xB262AC", VA = "0xB262AC")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xB262BC", Offset = "0xB262BC", VA = "0xB262BC", Slot = "26")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xB2637C", Offset = "0xB2637C", VA = "0xB2637C", Slot = "16")]
	public override void Spawned()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xB262D8", Offset = "0xB262D8", VA = "0xB262D8")]
	private void CacheController()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xB26398", Offset = "0xB26398", VA = "0xB26398", Slot = "32")]
	protected override void CopyFromBufferToEngine()
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xB26488", Offset = "0xB26488", VA = "0xB26488", Slot = "56")]
	public virtual void Jump(bool ignoreGrounded = false, [Optional] float? overrideImpulse)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xB26524", Offset = "0xB26524", VA = "0xB26524", Slot = "57")]
	public virtual void Move(Vector3 direction)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xB268EC", Offset = "0xB268EC", VA = "0xB268EC")]
	public NetworkCharacterControllerPrototype()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xB26914", Offset = "0xB26914", VA = "0xB26914", Slot = "13")]
	public override void CopyBackingFieldsToState(bool P_0)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xB2694C", Offset = "0xB2694C", VA = "0xB2694C", Slot = "14")]
	public override void CopyStateToBackingFields()
	{
	}
}
[Token(Token = "0x2000024")]
[DisallowMultipleComponent]
public class NetworkDebugStart : Fusion.Behaviour
{
	[Token(Token = "0x2000025")]
	public enum StartModes
	{
		[Token(Token = "0x400017C")]
		UserInterface,
		[Token(Token = "0x400017D")]
		Automatic,
		[Token(Token = "0x400017E")]
		Manual
	}

	[Token(Token = "0x2000026")]
	public enum Stage
	{
		[Token(Token = "0x4000180")]
		Disconnected,
		[Token(Token = "0x4000181")]
		StartingUp,
		[Token(Token = "0x4000182")]
		UnloadOriginalScene,
		[Token(Token = "0x4000183")]
		ConnectingServer,
		[Token(Token = "0x4000184")]
		ConnectingClients,
		[Token(Token = "0x4000185")]
		AllConnected
	}

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NetworkRunner RunnerPrefab;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StartModes StartMode;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("Server")]
	public GameMode AutoStartAs;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool AutoHideGUI;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int AutoClients;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ushort ServerPort;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string DefaultRoomName;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool AlwaysShowStats;

	[NonSerialized]
	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private NetworkRunner _server;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string InitialScenePath;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _initialScenePath;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected Stage _currentStage;

	[Token(Token = "0x1700003B")]
	public Stage CurrentStage
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0xB2697C", Offset = "0xB2697C", VA = "0xB2697C")]
		get
		{
			return default(Stage);
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0xB26984", Offset = "0xB26984", VA = "0xB26984")]
		internal set
		{
		}
	}

	[Token(Token = "0x1700003C")]
	public int LastCreatedClientIndex
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0xB2698C", Offset = "0xB2698C", VA = "0xB2698C")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xB26994", Offset = "0xB26994", VA = "0xB26994")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public GameMode CurrentServerMode
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0xB2699C", Offset = "0xB2699C", VA = "0xB2699C")]
		[CompilerGenerated]
		get
		{
			return default(GameMode);
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0xB269A4", Offset = "0xB269A4", VA = "0xB269A4")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	protected bool CanAddClients
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0xB269AC", Offset = "0xB269AC", VA = "0xB269AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003F")]
	protected bool CanAddSharedClients
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0xB269D8", Offset = "0xB269D8", VA = "0xB269D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000040")]
	protected bool IsShutdown
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB269FC", Offset = "0xB269FC", VA = "0xB269FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000041")]
	protected bool IsShutdownAndMultiPeer
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xB26A0C", Offset = "0xB26A0C", VA = "0xB26A0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000042")]
	protected bool UsingMultiPeerMode
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0xB26A44", Offset = "0xB26A44", VA = "0xB26A44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	protected bool ShowAutoClients
	{
		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB26A6C", Offset = "0xB26A6C", VA = "0xB26A6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xB26AB8", Offset = "0xB26AB8", VA = "0xB26AB8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xB26E34", Offset = "0xB26E34", VA = "0xB26E34")]
	protected bool TryGetSceneRef(out SceneRef sceneRef)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xB26FA0", Offset = "0xB26FA0", VA = "0xB26FA0", Slot = "5")]
	public virtual void StartSinglePlayer()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xB26FEC", Offset = "0xB26FEC", VA = "0xB26FEC", Slot = "6")]
	public virtual void StartServer()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xB27038", Offset = "0xB27038", VA = "0xB27038", Slot = "7")]
	public virtual void StartHost()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xB27084", Offset = "0xB27084", VA = "0xB27084", Slot = "8")]
	public virtual void StartClient()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xB270B0", Offset = "0xB270B0", VA = "0xB270B0", Slot = "9")]
	public virtual void StartSharedClient()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xB270FC", Offset = "0xB270FC", VA = "0xB270FC", Slot = "10")]
	public virtual void StartAutoClient()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0xB27148", Offset = "0xB27148", VA = "0xB27148", Slot = "11")]
	public virtual void StartServerPlusClients()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0xB27158", Offset = "0xB27158", VA = "0xB27158")]
	public void StartHostPlusClients()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0xB27230", Offset = "0xB27230", VA = "0xB27230")]
	public void Shutdown()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0xB27514", Offset = "0xB27514", VA = "0xB27514", Slot = "12")]
	public virtual void StartServerPlusClients(int clientCount)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xB27160", Offset = "0xB27160", VA = "0xB27160")]
	public void StartHostPlusClients(int clientCount)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0xB275E4", Offset = "0xB275E4", VA = "0xB275E4")]
	public void StartMultipleClients(int clientCount)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xB276B4", Offset = "0xB276B4", VA = "0xB276B4")]
	public void StartMultipleSharedClients(int clientCount)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xB27784", Offset = "0xB27784", VA = "0xB27784")]
	public void StartMultipleAutoClients(int clientCount)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xB27234", Offset = "0xB27234", VA = "0xB27234")]
	public void ShutdownAll()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xB26F08", Offset = "0xB26F08", VA = "0xB26F08")]
	protected IEnumerator StartWithClients(GameMode serverMode, SceneRef sceneRef, int clientCount)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xB2787C", Offset = "0xB2787C", VA = "0xB2787C")]
	public void AddClient()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xB27B10", Offset = "0xB27B10", VA = "0xB27B10")]
	public void AddSharedClient()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xB278B4", Offset = "0xB278B4", VA = "0xB278B4")]
	public Task AddClient(GameMode serverMode, SceneRef sceneRef)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0xB27B48", Offset = "0xB27B48", VA = "0xB27B48")]
	protected IEnumerator StartClients(int clientCount, GameMode serverMode, [Optional] SceneRef sceneRef)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xB27C08", Offset = "0xB27C08", VA = "0xB27C08", Slot = "13")]
	protected virtual Task InitializeNetworkRunner(NetworkRunner runner, GameMode gameMode, NetAddress address, SceneRef scene, Action<NetworkRunner> initialized)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xB27EA0", Offset = "0xB27EA0", VA = "0xB27EA0")]
	public NetworkDebugStart()
	{
	}
}
[Token(Token = "0x200002A")]
[RequireComponent(typeof(NetworkDebugStart))]
public class NetworkDebugStartGUI : Fusion.Behaviour
{
	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool EnableHotkeys;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GUISkin BaseSkin;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private NetworkDebugStart _networkDebugStart;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _clientCount;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _isMultiplePeerMode;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<NetworkDebugStart.Stage, string> _nicifiedStageNames;

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xB28BC4", Offset = "0xB28BC4", VA = "0xB28BC4", Slot = "4")]
	protected virtual void OnValidate()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xB28BC8", Offset = "0xB28BC8", VA = "0xB28BC8")]
	protected void ValidateClientCount()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xB28C90", Offset = "0xB28C90", VA = "0xB28C90")]
	protected int GetClientCount()
	{
		return default(int);
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xB28D68", Offset = "0xB28D68", VA = "0xB28D68", Slot = "5")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xB28F94", Offset = "0xB28F94", VA = "0xB28F94", Slot = "6")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB28E2C", Offset = "0xB28E2C", VA = "0xB28E2C")]
	protected NetworkDebugStart EnsureNetworkDebugStartExists()
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB28FC4", Offset = "0xB28FC4", VA = "0xB28FC4")]
	private void Update()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xB29574", Offset = "0xB29574", VA = "0xB29574", Slot = "7")]
	protected virtual void OnGUI()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xB2915C", Offset = "0xB2915C", VA = "0xB2915C")]
	private void StartHostWithClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xB29250", Offset = "0xB29250", VA = "0xB29250")]
	private void StartServerWithClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xB2934C", Offset = "0xB2934C", VA = "0xB2934C")]
	private void StartMultipleClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xB29440", Offset = "0xB29440", VA = "0xB29440")]
	private void StartMultipleAutoClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xB29480", Offset = "0xB29480", VA = "0xB29480")]
	private void StartMultipleSharedClients(NetworkDebugStart nds)
	{
	}

	[Token(Token = "0x6000155")]
	public static Dictionary<T, string> ConvertEnumToNicifiedNameLookup<T>([Optional] string prefix, [Optional] Dictionary<T, string> nonalloc) where T : Enum
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xB2A4AC", Offset = "0xB2A4AC", VA = "0xB2A4AC")]
	public NetworkDebugStartGUI()
	{
	}
}
[Token(Token = "0x200002B")]
public interface ISpawnPointManagerPrototype<T> where T : Component, ISpawnPointPrototype
{
	[Token(Token = "0x6000157")]
	Transform GetNextSpawnPoint(NetworkRunner runner, PlayerRef player, bool skipIfBlocked = true);
}
[Token(Token = "0x200002C")]
public interface ISpawnPointPrototype
{
}
[Token(Token = "0x200002D")]
public class PlayerSpawnPointManagerPrototype : SpawnPointManagerPrototype<PlayerSpawnPointPrototype>
{
	[Token(Token = "0x6000158")]
	[Address(RVA = "0xB2A4B4", Offset = "0xB2A4B4", VA = "0xB2A4B4")]
	public PlayerSpawnPointManagerPrototype()
	{
	}
}
[Token(Token = "0x200002E")]
public class PlayerSpawnPointPrototype : SimulationBehaviour, ISpawnPointPrototype
{
	[Token(Token = "0x6000159")]
	[Address(RVA = "0xB2A4FC", Offset = "0xB2A4FC", VA = "0xB2A4FC")]
	public PlayerSpawnPointPrototype()
	{
	}
}
[Token(Token = "0x200002F")]
public class SpawnerPrototype<T> : SimulationBehaviour, IPlayerJoined, IPlayerLeft, ISpawned, ISceneLoadDone where T : Component, ISpawnPointPrototype
{
	[Token(Token = "0x2000030")]
	public enum SpawnMethods
	{
		[Token(Token = "0x40001A5")]
		AutoOnNetworkStart,
		[Token(Token = "0x40001A6")]
		ByScriptOnly
	}

	[Token(Token = "0x2000031")]
	public enum AuthorityOptions
	{
		[Token(Token = "0x40001A8")]
		Auto,
		[Token(Token = "0x40001A9")]
		Server,
		[Token(Token = "0x40001AA")]
		Player
	}

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected Dictionary<PlayerRef, List<NetworkObject>> _spawnedLookup;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public NetworkObject PlayerPrefab;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public SpawnMethods SpawnMethod;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public AuthorityOptions StateAuthority;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected ISpawnPointManagerPrototype<T> spawnManager;

	[Token(Token = "0x17000048")]
	protected bool _AllowClientObjects
	{
		[Token(Token = "0x600015A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600015B")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x600015C")]
	public void Spawned()
	{
	}

	[Token(Token = "0x600015D")]
	public void SceneLoadDone()
	{
	}

	[Token(Token = "0x600015E")]
	public void PlayerJoined(PlayerRef player)
	{
	}

	[Token(Token = "0x600015F")]
	public void PlayerLeft(PlayerRef player)
	{
	}

	[Token(Token = "0x6000160")]
	private void PlayerJoined(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x6000161")]
	private void PlayerLeft(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x6000162")]
	public NetworkObject TrySpawn(NetworkRunner runner, PlayerRef player)
	{
		return null;
	}

	[Token(Token = "0x6000163")]
	public void TrySpawnAll()
	{
	}

	[Token(Token = "0x6000164")]
	protected virtual void RegisterPlayerAndObject(PlayerRef player, NetworkObject playerObject)
	{
	}

	[Token(Token = "0x6000165")]
	protected void DespawnPlayersObjects(NetworkRunner runner, PlayerRef player)
	{
	}

	[Token(Token = "0x6000166")]
	protected void UnregisterPlayer(PlayerRef player)
	{
	}

	[Token(Token = "0x6000167")]
	public SpawnerPrototype()
	{
	}
}
[Token(Token = "0x2000032")]
public abstract class SpawnPointManagerPrototype<T> : Fusion.Behaviour, ISpawnPointManagerPrototype<T> where T : Component, ISpawnPointPrototype
{
	[Token(Token = "0x2000033")]
	public enum SpawnSequence
	{
		[Token(Token = "0x40001B3")]
		PlayerId,
		[Token(Token = "0x40001B4")]
		RoundRobin,
		[Token(Token = "0x40001B5")]
		Random
	}

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public SpawnSequence Sequence;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public LayerMask BlockingLayers;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public float BlockedCheckRadius;

	[NonSerialized]
	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal List<Component> _spawnPoints;

	[NonSerialized]
	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int LastSpawnIndex;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private NetworkRNG rng;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static Collider[] blocked3D;

	[Token(Token = "0x6000168")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000169")]
	public void CollectSpawnPoints(NetworkRunner runner)
	{
	}

	[Token(Token = "0x600016A")]
	public virtual Transform GetNextSpawnPoint(NetworkRunner runner, PlayerRef player, bool skipIfBlocked = true)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	public virtual Transform AllSpawnPointsBlockedFallback()
	{
		return null;
	}

	[Token(Token = "0x600016C")]
	public virtual (int, Component) GetNextUnblocked(int failedIndex)
	{
		return default((int, Component));
	}

	[Token(Token = "0x600016D")]
	public virtual bool IsBlocked(Component spawnPoint)
	{
		return default(bool);
	}

	[Token(Token = "0x600016E")]
	protected SpawnPointManagerPrototype()
	{
	}
}
[Token(Token = "0x2000034")]
[DisallowMultipleComponent]
public class ToggleRunnerProvideInput : Fusion.Behaviour
{
	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ToggleRunnerProvideInput _instance;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xB2A504", Offset = "0xB2A504", VA = "0xB2A504")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xB2A648", Offset = "0xB2A648", VA = "0xB2A648")]
	public void Update()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xB2A778", Offset = "0xB2A778", VA = "0xB2A778")]
	private void ToggleAll(int runnerIndex)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xB2A8C4", Offset = "0xB2A8C4", VA = "0xB2A8C4")]
	public ToggleRunnerProvideInput()
	{
	}
}
[Token(Token = "0x2000035")]
[DisallowMultipleComponent]
public class ToggleRunnerVisibility : Fusion.Behaviour
{
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ToggleRunnerVisibility _instance;

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xB2A8CC", Offset = "0xB2A8CC", VA = "0xB2A8CC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xB2AA10", Offset = "0xB2AA10", VA = "0xB2AA10")]
	public void Update()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xB2AB50", Offset = "0xB2AB50", VA = "0xB2AB50")]
	private void ToggleAll(int runnerIndex)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xB2AC9C", Offset = "0xB2AC9C", VA = "0xB2AC9C")]
	public ToggleRunnerVisibility()
	{
	}
}
[Token(Token = "0x2000036")]
public static class FusionScalableIMGUI
{
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GUISkin _scalableSkin;

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xB2ACA4", Offset = "0xB2ACA4", VA = "0xB2ACA4")]
	private static void InitializedGUIStyles(GUISkin baseSkin)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xB2A3B8", Offset = "0xB2A3B8", VA = "0xB2A3B8")]
	public static GUISkin GetScaledSkin(GUISkin baseSkin, out float height, out float width, out int padding, out int margin, out float boxLeft)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xB2B0D8", Offset = "0xB2B0D8", VA = "0xB2B0D8")]
	public static (float, float, int, int, float) ScaleGuiSkinToScreenHeight()
	{
		return default((float, float, int, int, float));
	}
}
[Token(Token = "0x2000037")]
public class PicoSettingsSetter : MonoBehaviour
{
	[Token(Token = "0x600017A")]
	[Address(RVA = "0xB2B4B4", Offset = "0xB2B4B4", VA = "0xB2B4B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xB2B4E0", Offset = "0xB2B4E0", VA = "0xB2B4E0")]
	public PicoSettingsSetter()
	{
	}
}
namespace Fusion
{
	[Token(Token = "0x2000038")]
	internal static class FusionRuntimeCheck
	{
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xB2B4E8", Offset = "0xB2B4E8", VA = "0xB2B4E8")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void RuntimeCheck()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000039")]
	public class FusionUnityLogger : ILogger
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private StringBuilder _builder;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UseGlobalPrefix;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UseColorTags;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string GlobalPrefixColor;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color32 MinRandomColor;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Color32 MaxRandomColor;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color ServerColor;

		[Token(Token = "0x17000049")]
		public Func<object, int> GetColor
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0xB2B508", Offset = "0xB2B508", VA = "0xB2B508")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xB2B510", Offset = "0xB2B510", VA = "0xB2B510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xB2B518", Offset = "0xB2B518", VA = "0xB2B518")]
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
		[Address(RVA = "0xB2B6B0", Offset = "0xB2B6B0", VA = "0xB2B6B0")]
		private int GetRandomColor(int seed)
		{
			return default(int);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xB2B994", Offset = "0xB2B994", VA = "0xB2B994")]
		private static int GetRandomColor(int seed, Color32 min, Color32 max, Color32 svr)
		{
			return default(int);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xB2BA9C", Offset = "0xB2BA9C", VA = "0xB2BA9C")]
		private static int Color32ToRGB24(Color32 c)
		{
			return default(int);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xB2B624", Offset = "0xB2B624", VA = "0xB2B624")]
		private static string Color32ToRGBString(Color32 c)
		{
			return null;
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xB2BAB0", Offset = "0xB2BAB0", VA = "0xB2BAB0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void Initialize()
		{
		}
	}
	[Token(Token = "0x200003A")]
	public abstract class NetworkSceneManagerBase : Behaviour, INetworkSceneManager
	{
		[Token(Token = "0x200003B")]
		protected delegate void FinishedLoadingDelegate(IEnumerable<NetworkObject> sceneObjects);

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WeakReference<NetworkSceneManagerBase> s_currentlyLoading;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowHierarchyWindowOverlay;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnumerator _runningCoroutine;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _currentSceneOutdated;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private SceneRef _currentScene;

		[Token(Token = "0x1700004A")]
		public NetworkRunner Runner
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0xB2BBE0", Offset = "0xB2BBE0", VA = "0xB2BBE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0xB2BBE8", Offset = "0xB2BBE8", VA = "0xB2BBE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xB2BBF0", Offset = "0xB2BBF0", VA = "0xB2BBF0", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xB2BE38", Offset = "0xB2BE38", VA = "0xB2BE38")]
		public static bool IsScenePathOrNameEqual(Scene scene, string nameOrPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xB2BE94", Offset = "0xB2BE94", VA = "0xB2BE94")]
		public static bool TryGetScenePathFromBuildSettings(SceneRef sceneRef, out string path)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xB2BF40", Offset = "0xB2BF40", VA = "0xB2BF40")]
		public bool IsScenePathOrNameEqual(Scene scene, SceneRef sceneRef)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xB2BFDC", Offset = "0xB2BFDC", VA = "0xB2BFDC")]
		public List<NetworkObject> FindNetworkObjects(Scene scene, bool disable = true, bool addVisibilityNodes = false)
		{
			return null;
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xB2C458", Offset = "0xB2C458", VA = "0xB2C458", Slot = "4")]
		private void Fusion.INetworkSceneManager.Initialize(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xB2C464", Offset = "0xB2C464", VA = "0xB2C464", Slot = "5")]
		private void Fusion.INetworkSceneManager.Shutdown(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xB2C470", Offset = "0xB2C470", VA = "0xB2C470", Slot = "6")]
		private bool Fusion.INetworkSceneManager.IsReady(NetworkRunner runner)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xB2C4C4", Offset = "0xB2C4C4", VA = "0xB2C4C4", Slot = "8")]
		protected virtual void Initialize(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB2C4CC", Offset = "0xB2C4CC", VA = "0xB2C4CC", Slot = "9")]
		protected virtual void Shutdown(NetworkRunner runner)
		{
		}

		[Token(Token = "0x6000194")]
		protected abstract IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished);

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB2C7C8", Offset = "0xB2C7C8", VA = "0xB2C7C8")]
		protected void LogError(string msg)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xB2C6B8", Offset = "0xB2C6B8", VA = "0xB2C6B8")]
		protected void LogWarn(string msg)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB2BDB0", Offset = "0xB2BDB0", VA = "0xB2BDB0")]
		private IEnumerator SwitchSceneWrapper(SceneRef prevScene, SceneRef newScene)
		{
			return null;
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xB2C900", Offset = "0xB2C900", VA = "0xB2C900")]
		protected NetworkSceneManagerBase()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class NetworkSceneManagerDefault : NetworkSceneManagerBase
	{
		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int PostLoadDelayFrames;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xB2D4F8", Offset = "0xB2D4F8", VA = "0xB2D4F8", Slot = "11")]
		protected virtual YieldInstruction LoadSceneAsync(SceneRef sceneRef, LoadSceneParameters parameters, Action<Scene> loaded)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xB2D744", Offset = "0xB2D744", VA = "0xB2D744", Slot = "12")]
		protected virtual YieldInstruction UnloadSceneAsync(Scene scene)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xB2D79C", Offset = "0xB2D79C", VA = "0xB2D79C", Slot = "10")]
		protected override IEnumerator SwitchScene(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xB2D7E4", Offset = "0xB2D7E4", VA = "0xB2D7E4", Slot = "13")]
		protected virtual IEnumerator SwitchSceneMultiplePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xB2D8B4", Offset = "0xB2D8B4", VA = "0xB2D8B4", Slot = "14")]
		protected virtual IEnumerator SwitchSceneSinglePeer(SceneRef prevScene, SceneRef newScene, FinishedLoadingDelegate finished)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xB2D984", Offset = "0xB2D984", VA = "0xB2D984")]
		public NetworkSceneManagerDefault()
		{
		}
	}
}
namespace Fusion.StatsInternal
{
	[Token(Token = "0x2000044")]
	public interface IFusionStatsView
	{
		[Token(Token = "0x17000051")]
		bool isActiveAndEnabled
		{
			[Token(Token = "0x60001C1")]
			get;
		}

		[Token(Token = "0x17000052")]
		Transform transform
		{
			[Token(Token = "0x60001C2")]
			get;
		}

		[Token(Token = "0x60001BE")]
		void Initialize();

		[Token(Token = "0x60001BF")]
		void CalculateLayout();

		[Token(Token = "0x60001C0")]
		void Refresh();
	}
	[Token(Token = "0x2000045")]
	public static class FusionStatsUtilities
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<string> _cachedGraphVisualizationNames;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Font _font;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Texture2D _meterTexture;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Sprite _meterSprite;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Texture2D _circle32Texture;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Sprite _circle32Sprite;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Color DARK_GREEN;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static Color DARK_BLUE;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static Color DARK_RED;

		[Token(Token = "0x17000053")]
		public static List<string> CachedTelemetryNames
		{
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0xB2E470", Offset = "0xB2E470", VA = "0xB2E470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		public static Font Font
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0xB2E8C4", Offset = "0xB2E8C4", VA = "0xB2E8C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private static Texture2D MeterTexture
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0xB2E9D4", Offset = "0xB2E9D4", VA = "0xB2E9D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		public static Sprite MeterSprite
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0xB2EB64", Offset = "0xB2EB64", VA = "0xB2EB64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private static Texture2D Circle32Texture
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0xB2EC8C", Offset = "0xB2EC8C", VA = "0xB2EC8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000058")]
		public static Sprite CircleSprite
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0xB2EF10", Offset = "0xB2EF10", VA = "0xB2EF10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0xB2F054", Offset = "0xB2F054", VA = "0xB2F054")]
		public static bool TryFindActiveRunner(FusionStats fusionStats, out NetworkRunner runner, [Optional] SimulationModes? mode)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0xB2F250", Offset = "0xB2F250", VA = "0xB2F250")]
		public static RectTransform CreateRectTransform(this Transform parent, string name, bool expand = false)
		{
			return null;
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0xB2F4B0", Offset = "0xB2F4B0", VA = "0xB2F4B0")]
		public static Dropdown CreateDropdown(this RectTransform rt, float padding, Color fontColor)
		{
			return null;
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0xB2FBD4", Offset = "0xB2FBD4", VA = "0xB2FBD4")]
		public static Text AddText(this RectTransform rt, string label, TextAnchor anchor, Color FontColor)
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0xB2FD48", Offset = "0xB2FD48", VA = "0xB2FD48")]
		internal static void MakeButton(this RectTransform parent, ref Button button, string iconText, string labelText, out Text icon, out Text text, UnityAction action)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xB301C4", Offset = "0xB301C4", VA = "0xB301C4")]
		public static RectTransform AddVerticalLayoutGroup(this RectTransform rt, float spacing, [Optional] int? rgtPad, [Optional] int? lftPad, [Optional] int? topPad, [Optional] int? botPad)
		{
			return null;
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB30268", Offset = "0xB30268", VA = "0xB30268")]
		public static GridLayoutGroup AddGridlLayoutGroup(this RectTransform rt, float spacing, [Optional] int? rgtPad, [Optional] int? lftPad, [Optional] int? topPad, [Optional] int? botPad)
		{
			return null;
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB302F0", Offset = "0xB302F0", VA = "0xB302F0")]
		public static RectTransform AddCircleSprite(this RectTransform rt, Color color)
		{
			return null;
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB30388", Offset = "0xB30388", VA = "0xB30388")]
		public static RectTransform AddCircleSprite(this RectTransform rt, Color color, out Image image)
		{
			return null;
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xB2F374", Offset = "0xB2F374", VA = "0xB2F374")]
		public static RectTransform ExpandAnchor(this RectTransform rt, [Optional] float? padding)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB2F9B4", Offset = "0xB2F9B4", VA = "0xB2F9B4")]
		public static RectTransform ExpandTopAnchor(this RectTransform rt, [Optional] float? padding)
		{
			return null;
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0xB2FBB0", Offset = "0xB2FBB0", VA = "0xB2FBB0")]
		public static RectTransform SetSizeDelta(this RectTransform rt, float offsetX, float offsetY)
		{
			return null;
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xB2FAF4", Offset = "0xB2FAF4", VA = "0xB2FAF4")]
		public static RectTransform SetOffsets(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xB2FB8C", Offset = "0xB2FB8C", VA = "0xB2FB8C")]
		public static RectTransform SetPivot(this RectTransform rt, float pivotX, float pivotY)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xB2FB40", Offset = "0xB2FB40", VA = "0xB2FB40")]
		public static RectTransform SetAnchors(this RectTransform rt, float minX, float maxX, float minY, float maxY)
		{
			return null;
		}
	}
}
namespace Knife.Effects
{
	[Token(Token = "0x2000046")]
	public class AutoDestroyer : MonoBehaviour
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float destroyDelay;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xB30540", Offset = "0xB30540", VA = "0xB30540")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xB305BC", Offset = "0xB305BC", VA = "0xB305BC")]
		public AutoDestroyer()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class CollisionPlacer : MonoBehaviour
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LayerMask mask;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float autoPlaceMaxDistance;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0xB305CC", Offset = "0xB305CC", VA = "0xB305CC", Slot = "4")]
		public void CollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0xB30910", Offset = "0xB30910", VA = "0xB30910", Slot = "5")]
		public void AutoPlace()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0xB30B58", Offset = "0xB30B58", VA = "0xB30B58")]
		public CollisionPlacer()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[RequireComponent(typeof(Camera))]
	public class FlashbangPostprocess : MonoBehaviour
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float blindDuration;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AnimationCurve whiteScreenCurve;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationCurve lastFrameCurve;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material material;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationCurve distanceAmountCurve;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float maxDistance;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve angleAmountCurve;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RenderTexture lastFrame;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isBlinded;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float blindTime;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float blindAmount;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool updateLastFrame;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Camera attachedCamera;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0xB30B84", Offset = "0xB30B84", VA = "0xB30B84", Slot = "4")]
		public void Blind(float amount, Vector3 position)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0xB30D60", Offset = "0xB30D60", VA = "0xB30D60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0xB30E58", Offset = "0xB30E58", VA = "0xB30E58")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0xB30E64", Offset = "0xB30E64", VA = "0xB30E64")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0xB30EA8", Offset = "0xB30EA8", VA = "0xB30EA8")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xB3105C", Offset = "0xB3105C", VA = "0xB3105C")]
		public FlashbangPostprocess()
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ParticleGroupEmitter : MonoBehaviour
	{
		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] particleSystems;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int countMultiplier;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float emissionProbability;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool emitOnEnable;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xB31074", Offset = "0xB31074", VA = "0xB31074")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xB31088", Offset = "0xB31088", VA = "0xB31088")]
		public void Emit(int count = 1)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0xB31340", Offset = "0xB31340", VA = "0xB31340")]
		private IEnumerator PlayDelayed(ParticleSystem particleSystem, int count)
		{
			return null;
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xB31190", Offset = "0xB31190", VA = "0xB31190")]
		private void Emit(ParticleSystem particleSystem, int count)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xB31400", Offset = "0xB31400", VA = "0xB31400")]
		public ParticleGroupEmitter()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class ParticleGroupPlayer : MonoBehaviour
	{
		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem[] particleSystems;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xB31574", Offset = "0xB31574", VA = "0xB31574")]
		public void Play()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xB315E4", Offset = "0xB315E4", VA = "0xB315E4")]
		public void Stop()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xB31654", Offset = "0xB31654", VA = "0xB31654")]
		public ParticleGroupPlayer()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class SimpleDecal : MonoBehaviour
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool canRotate;

		[Token(Token = "0x1700005B")]
		public bool CanRotate
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0xB3165C", Offset = "0xB3165C", VA = "0xB3165C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xB31664", Offset = "0xB31664", VA = "0xB31664")]
		public SimpleDecal()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[RequireComponent(typeof(ParticleSystem))]
	public class SmokeController : MonoBehaviour
	{
		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Color startColor;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color endColor;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float startEmission;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float endEmission;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float shapeRadiusStart;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float shapeRadiusEnd;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float duration;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ParticleSystem particles;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float elapsedTime;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xB3166C", Offset = "0xB3166C", VA = "0xB3166C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xB316C8", Offset = "0xB316C8", VA = "0xB316C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xB31838", Offset = "0xB31838", VA = "0xB31838")]
		public SmokeController()
		{
		}
	}
}
namespace HurricaneVR.Framework.Shared.HandPoser
{
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(HVRIKTargets))]
	[RequireComponent(typeof(VRIK))]
	[ExecuteInEditMode]
	public class HVREditorIK : MonoBehaviour
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HVRIKTargets Targets;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ForceEditorIK;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x1700005C")]
		public Transform LeftTarget
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0xB3186C", Offset = "0xB3186C", VA = "0xB3186C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public Transform RightTarget
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0xB31888", Offset = "0xB31888", VA = "0xB31888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xB318A4", Offset = "0xB318A4", VA = "0xB318A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xB31A00", Offset = "0xB31A00", VA = "0xB31A00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xB31A04", Offset = "0xB31A04", VA = "0xB31A04")]
		private void Update()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xB31BDC", Offset = "0xB31BDC", VA = "0xB31BDC")]
		public HVREditorIK()
		{
		}
	}
}
namespace UnityTemplateProjects
{
	[Token(Token = "0x200004F")]
	public class CameraFly : MonoBehaviour
	{
		[Token(Token = "0x2000050")]
		private class CameraState
		{
			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yaw;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pitch;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float roll;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float x;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float y;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float z;

			[Token(Token = "0x6000201")]
			[Address(RVA = "0xB31C38", Offset = "0xB31C38", VA = "0xB31C38")]
			public void SetFromTransform(Transform t)
			{
			}

			[Token(Token = "0x6000202")]
			[Address(RVA = "0xB32190", Offset = "0xB32190", VA = "0xB32190")]
			public void Translate(Vector3 translation)
			{
			}

			[Token(Token = "0x6000203")]
			[Address(RVA = "0xB32210", Offset = "0xB32210", VA = "0xB32210")]
			public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
			{
			}

			[Token(Token = "0x6000204")]
			[Address(RVA = "0xB32298", Offset = "0xB32298", VA = "0xB32298")]
			public void UpdateTransform(Transform t)
			{
			}

			[Token(Token = "0x6000205")]
			[Address(RVA = "0xB324BC", Offset = "0xB324BC", VA = "0xB324BC")]
			public CameraState()
			{
			}
		}

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CameraState m_TargetCameraState;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CameraState m_InterpolatingCameraState;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float boost;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float positionLerpTime;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve mouseSensitivityCurve;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rotationLerpTime;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool invertY;

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xB31BE4", Offset = "0xB31BE4", VA = "0xB31BE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xB31CBC", Offset = "0xB31CBC", VA = "0xB31CBC")]
		private Vector3 GetInputTranslationDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xB31EEC", Offset = "0xB31EEC", VA = "0xB31EEC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xB322E0", Offset = "0xB322E0", VA = "0xB322E0")]
		public CameraFly()
		{
		}
	}
}
