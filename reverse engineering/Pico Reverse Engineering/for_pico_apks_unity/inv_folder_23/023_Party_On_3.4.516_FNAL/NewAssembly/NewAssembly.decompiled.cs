using System;
using System.Reflection;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace XR.AvatarIK;

[Token(Token = "0x2000002")]
public class AvatarFootIKMgr : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	private FullBodyBipedIK m_FBBIK;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x28")]
	public AvatarIKGoal UIKGoal;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x2C")]
	public AvatarIKHint UIKUnit;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x30")]
	private VRIK m_VRIK;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private readonly GameObject[] m_FootTargets;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private readonly FootWeightController[] WeightCtr;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private readonly Vector3[] m_FootTargetPositions;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x50")]
	private readonly Quaternion[] m_FootTargetRotations;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ECE4", Offset = "0x122ECE4")]
	private Transform <LFootTrans>k__BackingField;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ECF4", Offset = "0x122ECF4")]
	private Transform <RFootTrans>k__BackingField;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x68")]
	public IKType mIKtype;

	[Token(Token = "0x400000D")]
	private const float DefaultWeightSpeed = 1f / 6f;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x6C")]
	private float m_deltaSpeed;

	[Token(Token = "0x400000F")]
	private const float FootTragerConstrainAngle = 60f;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 footTargetIdlePos;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x80")]
	private GameObject oLeftFootTarget;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x88")]
	private GameObject oRightFootTarget;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x90")]
	public bool Debug;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x91")]
	private bool m_bInited;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x92")]
	public bool EnableIK;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x93")]
	private bool m_Lerp;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x94")]
	private float m_SmoothRatio;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x98")]
	private ELODLevel CurrentLODLevel;

	[Token(Token = "0x17000001")]
	public Transform LFootTrans
	{
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1E4438C", Offset = "0x1E4438C", VA = "0x1E4438C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F190", Offset = "0x122F190")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1E44394", Offset = "0x1E44394", VA = "0x1E44394")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1A0", Offset = "0x122F1A0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Transform RFootTrans
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1E4439C", Offset = "0x1E4439C", VA = "0x1E4439C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1B0", Offset = "0x122F1B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1E443A4", Offset = "0x1E443A4", VA = "0x1E443A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1C0", Offset = "0x122F1C0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float WeightSpeed
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1E443AC", Offset = "0x1E443AC", VA = "0x1E443AC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x1E443B4", Offset = "0x1E443B4", VA = "0x1E443B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool ShowDebug
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1E443BC", Offset = "0x1E443BC", VA = "0x1E443BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	public bool IsReady
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x1E443C4", Offset = "0x1E443C4", VA = "0x1E443C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	public bool UseIK
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x1E443CC", Offset = "0x1E443CC", VA = "0x1E443CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x1E443D4", Offset = "0x1E443D4", VA = "0x1E443D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x1E4448C", Offset = "0x1E4448C", VA = "0x1E4448C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1E44494", Offset = "0x1E44494", VA = "0x1E44494")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 RFoot_Target_Position
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1E45764", Offset = "0x1E45764", VA = "0x1E45764")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1E4576C", Offset = "0x1E4576C", VA = "0x1E4576C")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 LFoot_Target_Position
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1E45774", Offset = "0x1E45774", VA = "0x1E45774")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1E4577C", Offset = "0x1E4577C", VA = "0x1E4577C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Quaternion RFoot_Target_Rotation
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1E45784", Offset = "0x1E45784", VA = "0x1E45784")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1E4578C", Offset = "0x1E4578C", VA = "0x1E4578C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Quaternion LFoot_Target_Rotation
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1E45794", Offset = "0x1E45794", VA = "0x1E45794")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1E4579C", Offset = "0x1E4579C", VA = "0x1E4579C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float RFoot_PositionWeight
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1E457A4", Offset = "0x1E457A4", VA = "0x1E457A4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1E457AC", Offset = "0x1E457AC", VA = "0x1E457AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float LFoot_PositionWeight
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1E457B4", Offset = "0x1E457B4", VA = "0x1E457B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1E457BC", Offset = "0x1E457BC", VA = "0x1E457BC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public float RFoot_RotationWeight
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1E457C4", Offset = "0x1E457C4", VA = "0x1E457C4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1E457CC", Offset = "0x1E457CC", VA = "0x1E457CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public float LFoot_RotationWeight
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1E457D4", Offset = "0x1E457D4", VA = "0x1E457D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1E457DC", Offset = "0x1E457DC", VA = "0x1E457DC")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1E4389C", Offset = "0x1E4389C", VA = "0x1E4389C")]
	private void SetupFBBIKTargets()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1E43BE4", Offset = "0x1E43BE4", VA = "0x1E43BE4")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1E43BE8", Offset = "0x1E43BE8", VA = "0x1E43BE8")]
	private void SetupUNITYIKTargets()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1E43C18", Offset = "0x1E43C18", VA = "0x1E43C18")]
	private void UpdateVRIK()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1E440C0", Offset = "0x1E440C0", VA = "0x1E440C0")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1E4449C", Offset = "0x1E4449C", VA = "0x1E4449C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1E4465C", Offset = "0x1E4465C", VA = "0x1E4465C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1E4456C", Offset = "0x1E4456C", VA = "0x1E4456C")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1E44D0C", Offset = "0x1E44D0C", VA = "0x1E44D0C")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1E44760", Offset = "0x1E44760", VA = "0x1E44760")]
	private void SetupIKTargets()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1E447B0", Offset = "0x1E447B0", VA = "0x1E447B0")]
	private void InitFootWeightControllers()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1E443E0", Offset = "0x1E443E0", VA = "0x1E443E0")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1E44AE0", Offset = "0x1E44AE0", VA = "0x1E44AE0")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1E45090", Offset = "0x1E45090", VA = "0x1E45090")]
	private float _GetFootPosW(FootIndex index)
	{
		return default(float);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1E450D0", Offset = "0x1E450D0", VA = "0x1E450D0")]
	private float _GetFootRotW(FootIndex index)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1E45110", Offset = "0x1E45110", VA = "0x1E45110")]
	private void _SetFootPosW(FootIndex index, float v)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1E45180", Offset = "0x1E45180", VA = "0x1E45180")]
	private void _SetFootRotW(FootIndex index, float v)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1E451E0", Offset = "0x1E451E0", VA = "0x1E451E0")]
	private Vector3 _GetFootTargetPos(FootIndex index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1E45228", Offset = "0x1E45228", VA = "0x1E45228")]
	private void _SetFootTargetPos(FootIndex index, Vector3 vPos)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1E45394", Offset = "0x1E45394", VA = "0x1E45394")]
	private Quaternion _GetFootTargetRot(FootIndex index)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x1E453D8", Offset = "0x1E453D8", VA = "0x1E453D8")]
	private void _SetFootTargetRot(FootIndex index, Quaternion qRot)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1E4400C", Offset = "0x1E4400C", VA = "0x1E4400C")]
	public Transform GetFoot(FootIndex index)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1E45554", Offset = "0x1E45554", VA = "0x1E45554")]
	public void SwitchOffFoot(FootIndex id, bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1E45660", Offset = "0x1E45660", VA = "0x1E45660")]
	public bool TryGetFixedPosition(FootIndex index, Vector3 vPos, out Vector3 fixedPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x1E455E4", Offset = "0x1E455E4", VA = "0x1E455E4")]
	public void SetFootWeight(FootIndex _Foot, float _weight)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1E457E4", Offset = "0x1E457E4", VA = "0x1E457E4")]
	public float GetFootWeight(FootIndex _foot)
	{
		return default(float);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1E45804", Offset = "0x1E45804", VA = "0x1E45804")]
	public void SetupUpdateRatio(float ratio)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1E4582C", Offset = "0x1E4582C", VA = "0x1E4582C")]
	public void SetupLerp(bool lerp)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1E45838", Offset = "0x1E45838", VA = "0x1E45838")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1E44A1C", Offset = "0x1E44A1C", VA = "0x1E44A1C")]
	public void UpdateLODLevel()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1E45850", Offset = "0x1E45850", VA = "0x1E45850")]
	public AvatarFootIKMgr()
	{
	}
}
[Token(Token = "0x2000003")]
public class AvatarGroundIKMgr : MonoBehaviour
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x18")]
	private GrounderFBBIK m_GroundFBBIK;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x28")]
	public AvatarIKGoal UIKGoal;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x2C")]
	public AvatarIKHint UIKUnit;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x30")]
	private GrounderVRIK m_GroundVRIK;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x38")]
	private bool m_bInited;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x3C")]
	private ELODLevel CurrentLODLevel;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	public bool EnableIK;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x44")]
	public IKType mIKtype;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x48")]
	private GroundWeightController WeightCtr;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x80")]
	private float m_SmoothRatio;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x84")]
	private float m_deltaSpeed;

	[Token(Token = "0x17000010")]
	public bool IsReady
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1E45D7C", Offset = "0x1E45D7C", VA = "0x1E45D7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool UseIK
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x1E45D84", Offset = "0x1E45D84", VA = "0x1E45D84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1E45D70", Offset = "0x1E45D70", VA = "0x1E45D70")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x1E45DD4", Offset = "0x1E45DD4", VA = "0x1E45DD4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1E45DDC", Offset = "0x1E45DDC", VA = "0x1E45DDC")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float WeightSpeed
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x1E45DE4", Offset = "0x1E45DE4", VA = "0x1E45DE4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1E45DEC", Offset = "0x1E45DEC", VA = "0x1E45DEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float Ground_Weight
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1E46288", Offset = "0x1E46288", VA = "0x1E46288")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1E46290", Offset = "0x1E46290", VA = "0x1E46290")]
		set
		{
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1E45938", Offset = "0x1E45938", VA = "0x1E45938")]
	private void InitGroundFBBIKComponent()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1E45AC8", Offset = "0x1E45AC8", VA = "0x1E45AC8")]
	private void InitGroundUnityIKComponent()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1E45AF4", Offset = "0x1E45AF4", VA = "0x1E45AF4")]
	private void InitGroundVRIKComponent()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1E45C84", Offset = "0x1E45C84", VA = "0x1E45C84")]
	public void SetLayer(int mask = -1)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1E45CC0", Offset = "0x1E45CC0", VA = "0x1E45CC0")]
	public void UpdateLODLevel()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1E45DF4", Offset = "0x1E45DF4", VA = "0x1E45DF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x1E45F38", Offset = "0x1E45F38", VA = "0x1E45F38")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1E45EC4", Offset = "0x1E45EC4", VA = "0x1E45EC4")]
	private void _Init()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1E460F8", Offset = "0x1E460F8", VA = "0x1E460F8")]
	private void InitGroundWeightControllers()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1E45D8C", Offset = "0x1E45D8C", VA = "0x1E45D8C")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1E46204", Offset = "0x1E46204", VA = "0x1E46204")]
	private float _GetGroundW()
	{
		return default(float);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1E4620C", Offset = "0x1E4620C", VA = "0x1E4620C")]
	private void _SetGroundW(float v)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1E46234", Offset = "0x1E46234", VA = "0x1E46234")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1E4624C", Offset = "0x1E4624C", VA = "0x1E4624C")]
	public void SwitchOffGround(bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1E461B8", Offset = "0x1E461B8", VA = "0x1E461B8")]
	public void SetGroundWeight(float _weight)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1E462A4", Offset = "0x1E462A4", VA = "0x1E462A4")]
	public AvatarGroundIKMgr()
	{
	}
}
[Token(Token = "0x2000004")]
public class AvatarHandIKMgr : MonoBehaviour
{
	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x18")]
	private FullBodyBipedIK m_FBBIK;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x20")]
	private Animator m_Animator;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x28")]
	private AvatarIKGoal[] UIKGoal;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x30")]
	private AvatarIKHint[] UIKHint;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	private VRIK m_VRIK;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x40")]
	private readonly GameObject[] m_HandTargets;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x48")]
	private readonly HandWeightController[] WeightCtr;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x50")]
	private readonly GameObject[] m_HandBendGoals;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x58")]
	private readonly Vector3[] m_HandBendGoalsDefault;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED04", Offset = "0x122ED04")]
	private Transform <SpineTrans>k__BackingField;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED14", Offset = "0x122ED14")]
	private Transform <LHandTrans>k__BackingField;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED24", Offset = "0x122ED24")]
	private Transform <RHandTrans>k__BackingField;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x78")]
	private Vector3[] m_HandBendGoalsPos;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x80")]
	private readonly Vector3[] m_HandTargetPositions;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x88")]
	private readonly Quaternion[] m_HandTargetRotations;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x0")]
	public static IKType mIKtype;

	[Token(Token = "0x4000035")]
	private const float DefaultWeightSpeed = 1f / 6f;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x90")]
	private float fDeltaSpeed;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x94")]
	private Vector2 vAvatarXZ;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x9C")]
	public bool USE_TWISTER_RELAXER;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x9D")]
	public bool USE_ROT_LIMITER;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x9E")]
	public bool USE_BDOY_CONSTRAINT;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0xA0")]
	private float fAvatarRadius;

	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0xA8")]
	private XRTwistRelaxer IK_TRL;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0xB0")]
	private XRTwistRelaxer IK_TRR;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0xB8")]
	private int TWIST_ANGLE;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0xC0")]
	private RotationLimiter HLimit_R;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0xC8")]
	private RotationLimiter HLimit_L;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0xD0")]
	private bool bLerp;

	[Token(Token = "0x4000042")]
	[FieldOffset(Offset = "0xD4")]
	private float m_fSwivel;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0xD8")]
	private float fSmoothRatio;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0xDC")]
	private bool bDebug;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0xDD")]
	private bool bInited;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0xDE")]
	private bool EnableIK;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0xE0")]
	private ELODLevel CurrentLODLevel;

	[Token(Token = "0x17000015")]
	public Transform SpineTrans
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1E48050", Offset = "0x1E48050", VA = "0x1E48050")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1D0", Offset = "0x122F1D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1E48058", Offset = "0x1E48058", VA = "0x1E48058")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1E0", Offset = "0x122F1E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Transform LHandTrans
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1E48060", Offset = "0x1E48060", VA = "0x1E48060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F1F0", Offset = "0x122F1F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1E48068", Offset = "0x1E48068", VA = "0x1E48068")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F200", Offset = "0x122F200")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Transform RHandTrans
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1E48070", Offset = "0x1E48070", VA = "0x1E48070")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F210", Offset = "0x122F210")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1E48078", Offset = "0x1E48078", VA = "0x1E48078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F220", Offset = "0x122F220")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public IKType IKType
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1E48080", Offset = "0x1E48080", VA = "0x1E48080")]
		get
		{
			return default(IKType);
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1E480E4", Offset = "0x1E480E4", VA = "0x1E480E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float WeightRatio
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1E4814C", Offset = "0x1E4814C", VA = "0x1E4814C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1E48154", Offset = "0x1E48154", VA = "0x1E48154")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public Vector2 AVATAR_CENTERxz
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1E48184", Offset = "0x1E48184", VA = "0x1E48184")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1E4817C", Offset = "0x1E4817C", VA = "0x1E4817C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float AVATAR_RADIUS
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1E48194", Offset = "0x1E48194", VA = "0x1E48194")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1E4818C", Offset = "0x1E4818C", VA = "0x1E4818C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public bool IsLerp
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1E4819C", Offset = "0x1E4819C", VA = "0x1E4819C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1E481A4", Offset = "0x1E481A4", VA = "0x1E481A4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public float SWIVEL_SCALE
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1E481B0", Offset = "0x1E481B0", VA = "0x1E481B0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1E481B8", Offset = "0x1E481B8", VA = "0x1E481B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1E481C0", Offset = "0x1E481C0", VA = "0x1E481C0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1E481C8", Offset = "0x1E481C8", VA = "0x1E481C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool ShowDebug
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1E481D0", Offset = "0x1E481D0", VA = "0x1E481D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool IsReady
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1E481D8", Offset = "0x1E481D8", VA = "0x1E481D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public bool UseIK
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1E481E0", Offset = "0x1E481E0", VA = "0x1E481E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1E481E8", Offset = "0x1E481E8", VA = "0x1E481E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Vector3 RHand_Target_Position
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1E4AAB0", Offset = "0x1E4AAB0", VA = "0x1E4AAB0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1E4AAB8", Offset = "0x1E4AAB8", VA = "0x1E4AAB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Vector3 LHand_Target_Position
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1E4AAC0", Offset = "0x1E4AAC0", VA = "0x1E4AAC0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1E4AAC8", Offset = "0x1E4AAC8", VA = "0x1E4AAC8")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Quaternion RHand_Target_Rotation
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1E4AAD0", Offset = "0x1E4AAD0", VA = "0x1E4AAD0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1E4AAD8", Offset = "0x1E4AAD8", VA = "0x1E4AAD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Quaternion LHand_Target_Rotation
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1E4AAE0", Offset = "0x1E4AAE0", VA = "0x1E4AAE0")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1E4AAE8", Offset = "0x1E4AAE8", VA = "0x1E4AAE8")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public float RHand_PositionWeight
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1E4AAF0", Offset = "0x1E4AAF0", VA = "0x1E4AAF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1E4A970", Offset = "0x1E4A970", VA = "0x1E4A970")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float LHand_PositionWeight
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1E4AAF8", Offset = "0x1E4AAF8", VA = "0x1E4AAF8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1E4A960", Offset = "0x1E4A960", VA = "0x1E4A960")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float RHand_RotationWeight
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1E4AB00", Offset = "0x1E4AB00", VA = "0x1E4AB00")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1E4A978", Offset = "0x1E4A978", VA = "0x1E4A978")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public float LHand_RotationWeight
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1E4AB08", Offset = "0x1E4AB08", VA = "0x1E4AB08")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E4A968", Offset = "0x1E4A968", VA = "0x1E4A968")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public float RHand_FakePositionWeight
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E4AB10", Offset = "0x1E4AB10", VA = "0x1E4AB10")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E4AB18", Offset = "0x1E4AB18", VA = "0x1E4AB18")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public float LHand_FakePositionWeight
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E4AB20", Offset = "0x1E4AB20", VA = "0x1E4AB20")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1E4AB28", Offset = "0x1E4AB28", VA = "0x1E4AB28")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public float RHand_SlowDwonTime
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E4AB30", Offset = "0x1E4AB30", VA = "0x1E4AB30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1E4AB38", Offset = "0x1E4AB38", VA = "0x1E4AB38")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public float LHand_SlowDwonTime
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E4AB40", Offset = "0x1E4AB40", VA = "0x1E4AB40")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E4AB48", Offset = "0x1E4AB48", VA = "0x1E4AB48")]
		set
		{
		}
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1E462C0", Offset = "0x1E462C0", VA = "0x1E462C0")]
	private void SetupFBBIKTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1E466A4", Offset = "0x1E466A4", VA = "0x1E466A4")]
	private void SetupFBBIKConfig()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1E46754", Offset = "0x1E46754", VA = "0x1E46754")]
	private void SetupUnityIKTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1E46AB0", Offset = "0x1E46AB0", VA = "0x1E46AB0")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1E46CA0", Offset = "0x1E46CA0", VA = "0x1E46CA0")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1E470D4", Offset = "0x1E470D4", VA = "0x1E470D4")]
	private void SetupVRIKConfig()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1E4716C", Offset = "0x1E4716C", VA = "0x1E4716C")]
	private void InitHandRotateLimiter()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x1E47368", Offset = "0x1E47368", VA = "0x1E47368")]
	private void InitHandTwisterRelaxer()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1E476AC", Offset = "0x1E476AC", VA = "0x1E476AC")]
	private void UpdateVRIK()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1E47CD8", Offset = "0x1E47CD8", VA = "0x1E47CD8")]
	private void UpdateHandTwisterRelaxer()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1E47EB8", Offset = "0x1E47EB8", VA = "0x1E47EB8")]
	private void UpdateHandRotationLimiter()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1E48290", Offset = "0x1E48290", VA = "0x1E48290")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1E48404", Offset = "0x1E48404", VA = "0x1E48404")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1E48360", Offset = "0x1E48360", VA = "0x1E48360")]
	private void Init()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1E4979C", Offset = "0x1E4979C", VA = "0x1E4979C")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1E48938", Offset = "0x1E48938", VA = "0x1E48938")]
	private void SetupIKTargets()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1E48A18", Offset = "0x1E48A18", VA = "0x1E48A18")]
	private void InitWeightControllers()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1E481F4", Offset = "0x1E481F4", VA = "0x1E481F4")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1E49FB4", Offset = "0x1E49FB4", VA = "0x1E49FB4")]
	private void SetupIKBodyConstraint()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1E48DB4", Offset = "0x1E48DB4", VA = "0x1E48DB4")]
	private void UpdateLODLevel()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1E4A088", Offset = "0x1E4A088", VA = "0x1E4A088")]
	private Vector3 CaulBodyConstraint(HandIndex id, float rate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1E4804C", Offset = "0x1E4804C", VA = "0x1E4804C")]
	private void UpdateHandBendGoal()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1E4A22C", Offset = "0x1E4A22C", VA = "0x1E4A22C")]
	private Transform GetBendGoal(HandIndex id)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1E4A284", Offset = "0x1E4A284", VA = "0x1E4A284")]
	private Vector3 GetBendGoalDefault(HandIndex id)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1E4A2E4", Offset = "0x1E4A2E4", VA = "0x1E4A2E4")]
	private void SetHandPosW(int i, float w)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1E4A34C", Offset = "0x1E4A34C", VA = "0x1E4A34C")]
	private float GetHandPosW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1E4A38C", Offset = "0x1E4A38C", VA = "0x1E4A38C")]
	private void SetHandRotW(int i, float w)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1E4A3F4", Offset = "0x1E4A3F4", VA = "0x1E4A3F4")]
	private float GetHandRotW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1E4A434", Offset = "0x1E4A434", VA = "0x1E4A434")]
	private void SetFakeHandPosW(int i, float w)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1E4A4B0", Offset = "0x1E4A4B0", VA = "0x1E4A4B0")]
	private float GetFakeHandPosW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1E4A4F0", Offset = "0x1E4A4F0", VA = "0x1E4A4F0")]
	private void SetHandSlowDownTime(int i, float v)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1E4A530", Offset = "0x1E4A530", VA = "0x1E4A530")]
	private float GetHandSlowDownTime(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1E4A570", Offset = "0x1E4A570", VA = "0x1E4A570")]
	private void SetHandTargetPos(int i, Vector3 v)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1E4A6DC", Offset = "0x1E4A6DC", VA = "0x1E4A6DC")]
	private Vector3 GetHandTargetPos(int i)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1E4A724", Offset = "0x1E4A724", VA = "0x1E4A724")]
	private void SetHandTargetRot(int i, Quaternion q)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1E4A8A0", Offset = "0x1E4A8A0", VA = "0x1E4A8A0")]
	private Quaternion GetHandTargetRot(int i)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1E48ED8", Offset = "0x1E48ED8", VA = "0x1E48ED8")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1E47B4C", Offset = "0x1E47B4C", VA = "0x1E47B4C")]
	public Transform GetHand(HandIndex id)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1E4A8E4", Offset = "0x1E4A8E4", VA = "0x1E4A8E4")]
	public void SetHandWeight(HandIndex id, float w)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1E4A980", Offset = "0x1E4A980", VA = "0x1E4A980")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x1E4A998", Offset = "0x1E4A998", VA = "0x1E4A998")]
	public void SwitchOffHand(HandIndex id, bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x1E4AA28", Offset = "0x1E4AA28", VA = "0x1E4AA28")]
	public void SwitchOffHandFake(HandIndex id)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1E4AB50", Offset = "0x1E4AB50", VA = "0x1E4AB50")]
	public AvatarHandIKMgr()
	{
	}
}
[Token(Token = "0x2000005")]
public class AvatarHeadIKMgr : MonoBehaviour
{
	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x18")]
	private float MAX_HEAD_YAW_ANGLE;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x1C")]
	private float MAX_HEAD_PITCH_ANGLE;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x20")]
	private float MAX_HEAD_ROLL_ANGLE;

	[Token(Token = "0x400004B")]
	[FieldOffset(Offset = "0x28")]
	private FBBIKHeadEffector m_IKHeadEffector;

	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_HeadBone;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_IKHeadEffectObject;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x40")]
	private Animator m_Animator;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x48")]
	private float fBodyWeight;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x4C")]
	private float fHeadWeight;

	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x50")]
	private float fEyesWeight;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x54")]
	private float fClampWeight;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x58")]
	private VRIK m_VRIK;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x60")]
	private float VRIK_MAX_HEAD_YAW_ANGLE;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x64")]
	private float VRIK_MAX_HEAD_PITCH_ANGLE_UP;

	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x68")]
	private float VRIK_MAX_HEAD_PITCH_ANGLE_DOWN;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x6C")]
	private float VRIK_MAX_HEAD_ROLL_ANGLE;

	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x70")]
	private float VRIK_MAX_HEAD_PITCH_ANGLE_UP_FAKE;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x74")]
	private float VRIK_MAX_HEAD_PITCH_ANGLE_DOWN_FAKE;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x78")]
	private float m_Vangle_o;

	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x7C")]
	private float m_Hangle_o;

	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x0")]
	public static IKType mIKtype;

	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_HeadTarget;

	[Token(Token = "0x400005E")]
	[FieldOffset(Offset = "0x88")]
	private GameObject m_HeadFakeTarget;

	[Token(Token = "0x400005F")]
	[FieldOffset(Offset = "0x90")]
	private GameObject m_PelvisTarget;

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x98")]
	private HeadWeightController WeightCtr;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED34", Offset = "0x122ED34")]
	private Transform <ChestTrans>k__BackingField;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED44", Offset = "0x122ED44")]
	private Transform <UpperChestTrans>k__BackingField;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED54", Offset = "0x122ED54")]
	private Transform <NeckTrans>k__BackingField;

	[Token(Token = "0x4000064")]
	[FieldOffset(Offset = "0xE0")]
	private bool bVRM;

	[Token(Token = "0x4000065")]
	[FieldOffset(Offset = "0xE1")]
	private bool m_Lerp;

	[Token(Token = "0x4000066")]
	[FieldOffset(Offset = "0xE4")]
	private float m_SmoothRatio;

	[Token(Token = "0x4000067")]
	[FieldOffset(Offset = "0xE8")]
	private Vector3 OriginalHeadEuler;

	[Token(Token = "0x4000068")]
	[FieldOffset(Offset = "0xF4")]
	private bool m_bTurnedWeight;

	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0xF5")]
	private bool m_bTrunOn;

	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0xF8")]
	private float fSoftWeight;

	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0xFC")]
	private float fSoftScale;

	[Token(Token = "0x400006C")]
	[FieldOffset(Offset = "0x100")]
	private bool bRotConstraint;

	[Token(Token = "0x400006D")]
	[FieldOffset(Offset = "0x101")]
	public bool USE_ROT_CONSTRAINT;

	[Token(Token = "0x400006E")]
	[FieldOffset(Offset = "0x102")]
	private bool Debug;

	[Token(Token = "0x400006F")]
	private const float DefaultWeightSpeed = 1f / 6f;

	[Token(Token = "0x4000070")]
	[FieldOffset(Offset = "0x104")]
	private float m_deltaSpeed;

	[Token(Token = "0x4000071")]
	[FieldOffset(Offset = "0x108")]
	private Vector3 m_HeadTargetPositions;

	[Token(Token = "0x4000072")]
	[FieldOffset(Offset = "0x114")]
	private Quaternion m_HeadTargetRotations;

	[Token(Token = "0x4000073")]
	[FieldOffset(Offset = "0x124")]
	private bool m_bInited;

	[Token(Token = "0x4000074")]
	[FieldOffset(Offset = "0x128")]
	private ELODLevel CurrentLODLevel;

	[Token(Token = "0x4000075")]
	[FieldOffset(Offset = "0x12C")]
	private bool bNoHeadPos;

	[Token(Token = "0x1700002E")]
	public GameObject HeadTarget
	{
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E4C1AC", Offset = "0x1E4C1AC", VA = "0x1E4C1AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E4C1B4", Offset = "0x1E4C1B4", VA = "0x1E4C1B4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public GameObject HeadFakeTarget
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E4C1BC", Offset = "0x1E4C1BC", VA = "0x1E4C1BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1E4C1C4", Offset = "0x1E4C1C4", VA = "0x1E4C1C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public GameObject PelvisTarget
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1E4C1CC", Offset = "0x1E4C1CC", VA = "0x1E4C1CC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1E4C1D4", Offset = "0x1E4C1D4", VA = "0x1E4C1D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Transform ChestTrans
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1E4C1DC", Offset = "0x1E4C1DC", VA = "0x1E4C1DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F230", Offset = "0x122F230")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1E4C1E4", Offset = "0x1E4C1E4", VA = "0x1E4C1E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F240", Offset = "0x122F240")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Transform UpperChestTrans
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1E4C1EC", Offset = "0x1E4C1EC", VA = "0x1E4C1EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F250", Offset = "0x122F250")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1E4C1F4", Offset = "0x1E4C1F4", VA = "0x1E4C1F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F260", Offset = "0x122F260")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public Transform NeckTrans
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E4C1FC", Offset = "0x1E4C1FC", VA = "0x1E4C1FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F270", Offset = "0x122F270")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E4C204", Offset = "0x1E4C204", VA = "0x1E4C204")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F280", Offset = "0x122F280")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public bool VRM
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E4C2A0", Offset = "0x1E4C2A0", VA = "0x1E4C2A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E4C20C", Offset = "0x1E4C20C", VA = "0x1E4C20C")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public bool LERP
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E4C2B4", Offset = "0x1E4C2B4", VA = "0x1E4C2B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E4C2A8", Offset = "0x1E4C2A8", VA = "0x1E4C2A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1E4C2BC", Offset = "0x1E4C2BC", VA = "0x1E4C2BC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1E4C2C4", Offset = "0x1E4C2C4", VA = "0x1E4C2C4")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public bool TurnOn
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1E4C2CC", Offset = "0x1E4C2CC", VA = "0x1E4C2CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1E4C2D4", Offset = "0x1E4C2D4", VA = "0x1E4C2D4")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public bool ROT_CONSTRAINT
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1E4C2E4", Offset = "0x1E4C2E4", VA = "0x1E4C2E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1E4C2EC", Offset = "0x1E4C2EC", VA = "0x1E4C2EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public bool ShowDebug
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1E4C2F8", Offset = "0x1E4C2F8", VA = "0x1E4C2F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003A")]
	public float WeightSpeed
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1E4C300", Offset = "0x1E4C300", VA = "0x1E4C300")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1E4C308", Offset = "0x1E4C308", VA = "0x1E4C308")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public bool IsReady
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1E4C310", Offset = "0x1E4C310", VA = "0x1E4C310")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public float Head_PositionWeight
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1E4D4FC", Offset = "0x1E4D4FC", VA = "0x1E4D4FC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1E4D504", Offset = "0x1E4D504", VA = "0x1E4D504")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public Vector3 Head_Target_Position
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1E4D544", Offset = "0x1E4D544", VA = "0x1E4D544")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1E4D554", Offset = "0x1E4D554", VA = "0x1E4D554")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public Quaternion Head_Target_Rotation
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1E4D564", Offset = "0x1E4D564", VA = "0x1E4D564")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1E4D578", Offset = "0x1E4D578", VA = "0x1E4D578")]
		set
		{
		}
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x1E4ACD8", Offset = "0x1E4ACD8", VA = "0x1E4ACD8")]
	private void _CalDeltaRotation()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x1E4B218", Offset = "0x1E4B218", VA = "0x1E4B218")]
	private void InitHeadFBBIKComponent()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x1E4B678", Offset = "0x1E4B678", VA = "0x1E4B678")]
	private void SetupUNITYIKTargets()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x1E4B75C", Offset = "0x1E4B75C", VA = "0x1E4B75C")]
	private void SetupUNITYIKConfig()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1E4B76C", Offset = "0x1E4B76C", VA = "0x1E4B76C")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x1E4B874", Offset = "0x1E4B874", VA = "0x1E4B874")]
	private void UpdateDeltaRotation()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1E4BEF8", Offset = "0x1E4BEF8", VA = "0x1E4BEF8")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1E4C05C", Offset = "0x1E4C05C", VA = "0x1E4C05C")]
	private void SetupVRIKConfig()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x1E4C318", Offset = "0x1E4C318", VA = "0x1E4C318")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x1E4C54C", Offset = "0x1E4C54C", VA = "0x1E4C54C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x1E4C690", Offset = "0x1E4C690", VA = "0x1E4C690")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x1E4C3E8", Offset = "0x1E4C3E8", VA = "0x1E4C3E8")]
	private void _Init()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x1E4C788", Offset = "0x1E4C788", VA = "0x1E4C788")]
	private void InitWeightControllers()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x1E4CE5C", Offset = "0x1E4CE5C", VA = "0x1E4CE5C")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x1E4C728", Offset = "0x1E4C728", VA = "0x1E4C728")]
	private void InitHeadVRIKComponent()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x1E4C754", Offset = "0x1E4C754", VA = "0x1E4C754")]
	private void InitHeadUnityIKComponent()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x1E4D210", Offset = "0x1E4D210", VA = "0x1E4D210")]
	private float _GetHeadPosW()
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x1E4D218", Offset = "0x1E4D218", VA = "0x1E4D218")]
	private void _SetHeadPosW(float v)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x1E4D258", Offset = "0x1E4D258", VA = "0x1E4D258")]
	private Vector3 GetHeadTargetPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x1E4D268", Offset = "0x1E4D268", VA = "0x1E4D268")]
	private void SetHeadTargetPos(Vector3 vPos)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x1E4D278", Offset = "0x1E4D278", VA = "0x1E4D278")]
	private Quaternion GetHeadTargetRot()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1E4D28C", Offset = "0x1E4D28C", VA = "0x1E4D28C")]
	private void SetHeadTargetRot(Quaternion qRot)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x1E4C840", Offset = "0x1E4C840", VA = "0x1E4C840")]
	private void ApplyLODLevel()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x1E4C878", Offset = "0x1E4C878", VA = "0x1E4C878")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1E4C258", Offset = "0x1E4C258", VA = "0x1E4C258")]
	private void GetOriginalHeadEuler()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x1E4D2A0", Offset = "0x1E4D2A0", VA = "0x1E4D2A0")]
	public void SetupUpdateRatio(float ratio)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x1E4D2C8", Offset = "0x1E4D2C8", VA = "0x1E4D2C8")]
	public void SetupSitState(bool bSit)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x1E4D4A8", Offset = "0x1E4D4A8", VA = "0x1E4D4A8")]
	public void SetupSitTarget(Vector3 vPos)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1E4D58C", Offset = "0x1E4D58C", VA = "0x1E4D58C")]
	public void SetHeadPosWeight(float fWeight)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1E4D5C4", Offset = "0x1E4D5C4", VA = "0x1E4D5C4")]
	public void SwitchOffHeadPos(bool bSwitchOff)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1E4D640", Offset = "0x1E4D640", VA = "0x1E4D640")]
	public void SetupSoftnessScale(float fScale)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1E4D648", Offset = "0x1E4D648", VA = "0x1E4D648")]
	public void SetupChestRotate(bool bRot, bool bUseHeadPos = false)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1E4D40C", Offset = "0x1E4D40C", VA = "0x1E4D40C")]
	public void SetYawAngle(bool bSit)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1E4D730", Offset = "0x1E4D730", VA = "0x1E4D730")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1E4D774", Offset = "0x1E4D774", VA = "0x1E4D774")]
	public AvatarHeadIKMgr()
	{
	}
}
[Token(Token = "0x2000006")]
public class AvatarIKMgr : MonoBehaviour
{
	[Token(Token = "0x4000076")]
	[FieldOffset(Offset = "0x18")]
	public IKType mIKtype;

	[Token(Token = "0x4000077")]
	[FieldOffset(Offset = "0x1C")]
	public bool UseHeadIK;

	[Token(Token = "0x4000078")]
	[FieldOffset(Offset = "0x1D")]
	public bool UseHandIK;

	[Token(Token = "0x4000079")]
	[FieldOffset(Offset = "0x1E")]
	public bool UseFootIK;

	[Token(Token = "0x400007A")]
	[FieldOffset(Offset = "0x1F")]
	public bool UseGroundIK;

	[Token(Token = "0x400007B")]
	[FieldOffset(Offset = "0x20")]
	public bool UseLocomotion;

	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x21")]
	public bool UseHeadRotConstraint;

	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x22")]
	public bool UseHeadPos;

	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x23")]
	public bool UseHeadPosForward;

	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x24")]
	public bool UseHandValidRange;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x25")]
	public bool UseHandRotLimiter;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x26")]
	public bool UseHandTwisterRelaxer;

	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x27")]
	public bool UseReBuildCameraRelation;

	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x28")]
	public bool UseNoInputeReset;

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x29")]
	protected bool bInited;

	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x2A")]
	private bool bHostplayer;

	[Token(Token = "0x4000086")]
	[FieldOffset(Offset = "0x2C")]
	private ELODLevel CurrentLODLevel;

	[Token(Token = "0x4000087")]
	[FieldOffset(Offset = "0x30")]
	protected bool bForceDownHand;

	[Token(Token = "0x4000088")]
	[FieldOffset(Offset = "0x31")]
	private bool bForceIKEnable;

	[Token(Token = "0x4000089")]
	[FieldOffset(Offset = "0x32")]
	private bool bIKTurnOn;

	[Token(Token = "0x400008A")]
	[FieldOffset(Offset = "0x34")]
	protected float fEyeHeight;

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 vPelvis;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x44")]
	private float fSmoothRatio;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x48")]
	private VRIK m_VRIK;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x50")]
	private FullBodyBipedIK m_FBBIK;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x58")]
	private Animator m_Animator;

	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x60")]
	private bool bIKSwitchOn;

	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x61")]
	protected bool bVRM;

	[Token(Token = "0x4000092")]
	[FieldOffset(Offset = "0x62")]
	private bool bFakeDisableIK;

	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x63")]
	private bool bSit;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x64")]
	private bool bMove;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x65")]
	private bool bChangeSkeletal;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x68")]
	public Action OnNoInput;

	[Token(Token = "0x4000097")]
	private const float NO_INPUT_TIME = 3f;

	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x70")]
	private float fNoInputTimer;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x78")]
	private IKWeightController WeightCtr;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x98")]
	private LocoMotionWeightController locomotionWeightCtr;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0xB8")]
	private IKConstraintMgr m_IKConstraintMgr;

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0xC0")]
	protected GameObject oHeadSrc;

	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0xC8")]
	protected GameObject oHeadOriSrc;

	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0xD0")]
	protected GameObject oHeadOriSrcFake;

	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED64", Offset = "0x122ED64")]
	private Transform <HeadTrans>k__BackingField;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122ED74", Offset = "0x122ED74")]
	private Transform[] <EyesTrans>k__BackingField;

	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0xE8")]
	private AvatarHeadIKMgr m_HeadIKMgr;

	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0xF0")]
	private AvatarHandIKMgr m_HandIKMgr;

	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0xF8")]
	private AvatarGroundIKMgr m_GroundIKMgr;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x100")]
	private AvatarFootIKMgr m_FootIKMgr;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x108")]
	private bool Debug;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x109")]
	protected bool srcHeadLerp;

	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x10A")]
	protected bool srcHeadEnable;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x10C")]
	protected Vector3 srcHeadPos;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x118")]
	protected Quaternion srcHeadRot;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x128")]
	protected bool srcLHandLerp;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x129")]
	protected bool srcLHandEnable;

	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x12C")]
	protected Vector3 srcLHandPos;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x138")]
	protected Quaternion srcLHandRot;

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x148")]
	private Vector3 srcLHandPos_r;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x154")]
	private Quaternion srcLHandRot_r;

	[Token(Token = "0x40000B0")]
	[FieldOffset(Offset = "0x164")]
	protected bool srcRHandLerp;

	[Token(Token = "0x40000B1")]
	[FieldOffset(Offset = "0x165")]
	protected bool srcRHandEnable;

	[Token(Token = "0x40000B2")]
	[FieldOffset(Offset = "0x168")]
	protected Vector3 srcRHandPos;

	[Token(Token = "0x40000B3")]
	[FieldOffset(Offset = "0x174")]
	protected Quaternion srcRHandRot;

	[Token(Token = "0x40000B4")]
	[FieldOffset(Offset = "0x184")]
	private Vector3 srcRHandPos_r;

	[Token(Token = "0x40000B5")]
	[FieldOffset(Offset = "0x190")]
	private Quaternion srcRHandRot_r;

	[Token(Token = "0x40000B6")]
	[FieldOffset(Offset = "0x1A0")]
	protected float fBaseSyncError;

	[Token(Token = "0x40000B7")]
	[FieldOffset(Offset = "0x1A4")]
	private Vector3 srcPelvisPos;

	[Token(Token = "0x1700003F")]
	public bool IsHostPlayer
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1E50D30", Offset = "0x1E50D30", VA = "0x1E50D30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E50D38", Offset = "0x1E50D38", VA = "0x1E50D38")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public bool ENFORCE_IK_ENABLE
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E50D44", Offset = "0x1E50D44", VA = "0x1E50D44")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1E50D4C", Offset = "0x1E50D4C", VA = "0x1E50D4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1E50D58", Offset = "0x1E50D58", VA = "0x1E50D58")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1E50D60", Offset = "0x1E50D60", VA = "0x1E50D60")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public VRIK VRIKref
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1E4E67C", Offset = "0x1E4E67C", VA = "0x1E4E67C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1E50D68", Offset = "0x1E50D68", VA = "0x1E50D68")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public FullBodyBipedIK FBBIKref
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1E4EC84", Offset = "0x1E4EC84", VA = "0x1E4EC84")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1E50D70", Offset = "0x1E50D70", VA = "0x1E50D70")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public Animator AnimatorRef
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1E4E8C0", Offset = "0x1E4E8C0", VA = "0x1E4E8C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1E50D78", Offset = "0x1E50D78", VA = "0x1E50D78")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public bool IsFakeDisableIK
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1E50D80", Offset = "0x1E50D80", VA = "0x1E50D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1E50D88", Offset = "0x1E50D88", VA = "0x1E50D88")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public bool IsSit
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1E50D94", Offset = "0x1E50D94", VA = "0x1E50D94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1E50D9C", Offset = "0x1E50D9C", VA = "0x1E50D9C")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public bool IsMove
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1E50DA8", Offset = "0x1E50DA8", VA = "0x1E50DA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1E50DB0", Offset = "0x1E50DB0", VA = "0x1E50DB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public float NoInputTimer
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1E50DBC", Offset = "0x1E50DBC", VA = "0x1E50DBC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1E4F770", Offset = "0x1E4F770", VA = "0x1E4F770")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public IKConstraintMgr ConstraintMgr
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1E50DC4", Offset = "0x1E50DC4", VA = "0x1E50DC4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1E50DCC", Offset = "0x1E50DCC", VA = "0x1E50DCC")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public Transform HeadTrans
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1E50DD4", Offset = "0x1E50DD4", VA = "0x1E50DD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F290", Offset = "0x122F290")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1E50DDC", Offset = "0x1E50DDC", VA = "0x1E50DDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F2A0", Offset = "0x122F2A0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public Transform[] EyesTrans
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1E50DE4", Offset = "0x1E50DE4", VA = "0x1E50DE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F2B0", Offset = "0x122F2B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1E50DEC", Offset = "0x1E50DEC", VA = "0x1E50DEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x122F2C0", Offset = "0x122F2C0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public AvatarHeadIKMgr HeadIKMgr
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1E50DF4", Offset = "0x1E50DF4", VA = "0x1E50DF4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1E50DFC", Offset = "0x1E50DFC", VA = "0x1E50DFC")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public AvatarHandIKMgr HandIKMgr
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1E50E04", Offset = "0x1E50E04", VA = "0x1E50E04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E50E0C", Offset = "0x1E50E0C", VA = "0x1E50E0C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public AvatarGroundIKMgr GroundIKMgr
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E50E14", Offset = "0x1E50E14", VA = "0x1E50E14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E50E1C", Offset = "0x1E50E1C", VA = "0x1E50E1C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public AvatarFootIKMgr FootIKMgr
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E50E24", Offset = "0x1E50E24", VA = "0x1E50E24")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1E50E2C", Offset = "0x1E50E2C", VA = "0x1E50E2C")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public bool ShowDebug
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1E50E34", Offset = "0x1E50E34", VA = "0x1E50E34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000051")]
	public Vector3 SrcHeadPos
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E50E3C", Offset = "0x1E50E3C", VA = "0x1E50E3C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E50E4C", Offset = "0x1E50E4C", VA = "0x1E50E4C")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public Quaternion SrcHeadRot
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1E50E5C", Offset = "0x1E50E5C", VA = "0x1E50E5C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1E50E70", Offset = "0x1E50E70", VA = "0x1E50E70")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public bool SrcLHandEnable
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1E50E84", Offset = "0x1E50E84", VA = "0x1E50E84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1E50E8C", Offset = "0x1E50E8C", VA = "0x1E50E8C")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public Vector3 SrcLHandPos
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1E50E98", Offset = "0x1E50E98", VA = "0x1E50E98")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1E50EA8", Offset = "0x1E50EA8", VA = "0x1E50EA8")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public bool SrcRHandEnable
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1E50EB8", Offset = "0x1E50EB8", VA = "0x1E50EB8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1E50EC0", Offset = "0x1E50EC0", VA = "0x1E50EC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public Vector3 SrcRHandPos
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1E50ECC", Offset = "0x1E50ECC", VA = "0x1E50ECC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1E50EDC", Offset = "0x1E50EDC", VA = "0x1E50EDC")]
		set
		{
		}
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1E43A6C", Offset = "0x1E43A6C", VA = "0x1E43A6C")]
	public static FullBodyBipedIK GetFBBIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1E4425C", Offset = "0x1E4425C", VA = "0x1E4425C")]
	public static VRIK GetVRIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1E43C14", Offset = "0x1E43C14", VA = "0x1E43C14")]
	public static Animator GetUnityIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1E48868", Offset = "0x1E48868", VA = "0x1E48868")]
	public static Animator GetAnimatorRef(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1E4D844", Offset = "0x1E4D844", VA = "0x1E4D844")]
	public void Init(bool bNPC = false)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x1E4EA54", Offset = "0x1E4EA54", VA = "0x1E4EA54")]
	public bool InitPureNPCState()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x1E4EB30", Offset = "0x1E4EB30", VA = "0x1E4EB30")]
	public bool IsIKEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1E4ED10", Offset = "0x1E4ED10", VA = "0x1E4ED10")]
	public void SetupHeadPosition(Vector3 vPos, Quaternion qRot, bool IsLerp = true, bool IsInput = true)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1E4F79C", Offset = "0x1E4F79C", VA = "0x1E4F79C")]
	public void SetupHandPosition(HandIndex hand, Vector3 vPos, Quaternion qRot, bool IsLerp = true, bool IsInput = true)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1E503A8", Offset = "0x1E503A8", VA = "0x1E503A8")]
	public void SetupFootPosition(FootIndex foot, Vector3 vPos, Quaternion qRot, bool IsLerp = true)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1E4E9EC", Offset = "0x1E4E9EC", VA = "0x1E4E9EC")]
	public void TurnOnIK(bool bTurnOn = true)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1E50658", Offset = "0x1E50658", VA = "0x1E50658")]
	public void TurnOnLocoMotion(bool bTurnOn = true, bool lerp = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1E50724", Offset = "0x1E50724", VA = "0x1E50724")]
	public void TurnOnHead(bool bTurnOn = true, bool lerp = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1E508F0", Offset = "0x1E508F0", VA = "0x1E508F0")]
	public void TurnOnHand(HandIndex hand, bool bTurnOn = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1E509EC", Offset = "0x1E509EC", VA = "0x1E509EC")]
	public void TurnOnFoot(FootIndex foot, bool bTurnOn = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1E50A84", Offset = "0x1E50A84", VA = "0x1E50A84")]
	public void TurnOnGround(bool bTurnOn = true)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1E50AF4", Offset = "0x1E50AF4", VA = "0x1E50AF4")]
	public void FakeDisableIK(bool bDisable)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1E50C20", Offset = "0x1E50C20", VA = "0x1E50C20")]
	public void UpdateTurnAroundConfig()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1E50C24", Offset = "0x1E50C24", VA = "0x1E50C24")]
	public void SetupSitState(bool bSit, Vector3 vPos)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x1E4E7A4", Offset = "0x1E4E7A4", VA = "0x1E4E7A4")]
	public void SetupLODLevel(ELODLevel level = ELODLevel.NEAR)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1E50EEC", Offset = "0x1E50EEC", VA = "0x1E50EEC")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1E51034", Offset = "0x1E51034", VA = "0x1E51034")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1E51284", Offset = "0x1E51284", VA = "0x1E51284")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1E51310", Offset = "0x1E51310", VA = "0x1E51310")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1E4E94C", Offset = "0x1E4E94C", VA = "0x1E4E94C")]
	protected void InitConstraint(Transform t, bool bVRM)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1E4E04C", Offset = "0x1E4E04C", VA = "0x1E4E04C")]
	private void InitHeadIKComponent()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1E4E218", Offset = "0x1E4E218", VA = "0x1E4E218")]
	private void InitHandIKComponent()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x1E4E50C", Offset = "0x1E4E50C", VA = "0x1E4E50C")]
	private void InitGroundIKComponent()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x1E4E3B8", Offset = "0x1E4E3B8", VA = "0x1E4E3B8")]
	private void InitFootIKComponent()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x1E4E708", Offset = "0x1E4E708", VA = "0x1E4E708")]
	private void InitWeightController()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x1E50198", Offset = "0x1E50198", VA = "0x1E50198")]
	private void ReBuildCameraHandRelation(ref Vector3 vPos)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x1E510C8", Offset = "0x1E510C8", VA = "0x1E510C8")]
	private void PersistentInputData()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x1E4E9E8", Offset = "0x1E4E9E8", VA = "0x1E4E9E8")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1E5130C", Offset = "0x1E5130C", VA = "0x1E5130C")]
	private void UpdaetDebugObjects()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x1E513BC", Offset = "0x1E513BC", VA = "0x1E513BC")]
	protected void _OnSkeletonChanged()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x1E513C8", Offset = "0x1E513C8", VA = "0x1E513C8")]
	private void OnNoInputImp()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x1E513E0", Offset = "0x1E513E0", VA = "0x1E513E0")]
	public AvatarIKMgr()
	{
	}
}
[Token(Token = "0x2000007")]
public enum IKType
{
	[Token(Token = "0x40000B9")]
	NONE = -1,
	[Token(Token = "0x40000BA")]
	FIK_VRIK,
	[Token(Token = "0x40000BB")]
	FIK_FBBIK,
	[Token(Token = "0x40000BC")]
	UIK
}
[Token(Token = "0x2000008")]
public enum ELODLevel
{
	[Token(Token = "0x40000BE")]
	NONE = -1,
	[Token(Token = "0x40000BF")]
	NEAR,
	[Token(Token = "0x40000C0")]
	MIDDLE,
	[Token(Token = "0x40000C1")]
	FAR
}
[Token(Token = "0x2000009")]
public enum HandIndex
{
	[Token(Token = "0x40000C3")]
	Left,
	[Token(Token = "0x40000C4")]
	Right
}
[Token(Token = "0x200000A")]
public enum FootIndex
{
	[Token(Token = "0x40000C6")]
	Left,
	[Token(Token = "0x40000C7")]
	Right
}
[Token(Token = "0x200000B")]
public class IKConstraintMgr
{
	[Token(Token = "0x40000C8")]
	[FieldOffset(Offset = "0x10")]
	private bool bActive;

	[Token(Token = "0x40000C9")]
	[FieldOffset(Offset = "0x18")]
	private Collider BodyCollider;

	[Token(Token = "0x40000CA")]
	[FieldOffset(Offset = "0x20")]
	private Collider[] HandColliders;

	[Token(Token = "0x40000CB")]
	[FieldOffset(Offset = "0x28")]
	private Vector3[] vCenters;

	[Token(Token = "0x40000CC")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 lHand;

	[Token(Token = "0x40000CD")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 rHand;

	[Token(Token = "0x17000057")]
	public bool Enable
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x21B1BD4", Offset = "0x21B1BD4", VA = "0x21B1BD4")]
		set
		{
		}
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x21B1BE0", Offset = "0x21B1BE0", VA = "0x21B1BE0")]
	public void Init(Transform T, bool bVRM)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x21B216C", Offset = "0x21B216C", VA = "0x21B216C")]
	public Vector3 Get_Valid_Hand_Position(HandIndex hand, Vector3 vPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x21B241C", Offset = "0x21B241C", VA = "0x21B241C")]
	public void SetState(bool bSit = false)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x21B26D0", Offset = "0x21B26D0", VA = "0x21B26D0")]
	public IKConstraintMgr()
	{
	}
}
[Token(Token = "0x200000C")]
public class RotationLimiter : MonoBehaviour
{
	[Token(Token = "0x40000CE")]
	[FieldOffset(Offset = "0x18")]
	private GameObject _flatXBaseP;

	[Token(Token = "0x40000CF")]
	[FieldOffset(Offset = "0x20")]
	public bool OverwriteInput;

	[Token(Token = "0x40000D0")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 OverwriteEuler;

	[Token(Token = "0x40000D1")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 TwistLimit;

	[Token(Token = "0x40000D2")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 ZLimit;

	[Token(Token = "0x40000D3")]
	[FieldOffset(Offset = "0x48")]
	public Vector3 YLimit;

	[Token(Token = "0x40000D4")]
	[FieldOffset(Offset = "0x54")]
	public float ElbowLimit;

	[Token(Token = "0x40000D5")]
	[FieldOffset(Offset = "0x58")]
	public float ZEnlargePitch;

	[Token(Token = "0x40000D6")]
	[FieldOffset(Offset = "0x5C")]
	public bool ShowBox;

	[Token(Token = "0x40000D7")]
	[FieldOffset(Offset = "0x60")]
	private Quaternion _lastLegalRot;

	[Token(Token = "0x40000D8")]
	[FieldOffset(Offset = "0x70")]
	private float fWeight;

	[Token(Token = "0x40000D9")]
	[FieldOffset(Offset = "0x78")]
	private IK _IKSystem;

	[Token(Token = "0x40000DA")]
	[FieldOffset(Offset = "0x0")]
	private static float L1;

	[Token(Token = "0x40000DB")]
	[FieldOffset(Offset = "0x4")]
	private static float L2;

	[Token(Token = "0x17000058")]
	public float Weight
	{
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x21B287C", Offset = "0x21B287C", VA = "0x21B287C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x21B2884", Offset = "0x21B2884", VA = "0x21B2884")]
		set
		{
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x21B288C", Offset = "0x21B288C", VA = "0x21B288C")]
	private float calculateTwistX(ref Quaternion rotOnBase)
	{
		return default(float);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x21B2BE4", Offset = "0x21B2BE4", VA = "0x21B2BE4")]
	internal void init(IK ik, bool bRightHand)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x21B312C", Offset = "0x21B312C", VA = "0x21B312C")]
	internal void OnPostUpdate()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x21B3540", Offset = "0x21B3540", VA = "0x21B3540")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x21B3658", Offset = "0x21B3658", VA = "0x21B3658")]
	private void Start()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x21B365C", Offset = "0x21B365C", VA = "0x21B365C")]
	private Quaternion flatX(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x21B3850", Offset = "0x21B3850", VA = "0x21B3850")]
	private (float, bool) limitTwistY(float fTwist)
	{
		return default((float, bool));
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x21B3978", Offset = "0x21B3978", VA = "0x21B3978")]
	private void preventStraitElbow()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x21B3A54", Offset = "0x21B3A54", VA = "0x21B3A54")]
	private void shareTwistToParent(float degreeTwist)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x21B3280", Offset = "0x21B3280", VA = "0x21B3280")]
	internal void LimitHandRotation()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x21B3E4C", Offset = "0x21B3E4C", VA = "0x21B3E4C")]
	private static void normalizeYZ(ref Vector3 v)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x21B3ED8", Offset = "0x21B3ED8", VA = "0x21B3ED8")]
	private static void limitLocalAxis(ref Vector3 vNormaized, float nTangent, float pTangent)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x21B3BFC", Offset = "0x21B3BFC", VA = "0x21B3BFC")]
	public static Quaternion LimitHandBend(Quaternion handLocalRotation, Vector3 YLimit, Vector3 ZLimit)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x21B2A24", Offset = "0x21B2A24", VA = "0x21B2A24")]
	internal static (Vector3, Vector3, Vector3) getRotationAxies(Quaternion ro)
	{
		return default((Vector3, Vector3, Vector3));
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x21B3F78", Offset = "0x21B3F78", VA = "0x21B3F78")]
	internal static Matrix4x4 makeRotMarix(Vector3 x, Vector3 y, Vector3 z)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x21B40C8", Offset = "0x21B40C8", VA = "0x21B40C8")]
	internal static Quaternion makeRotationFromXY(Vector3 x, Vector3 y)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x21B3708", Offset = "0x21B3708", VA = "0x21B3708")]
	internal static Quaternion makeRotationFromYZ(Vector3 y, Vector3 z)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x21B4210", Offset = "0x21B4210", VA = "0x21B4210")]
	public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x21B44F4", Offset = "0x21B44F4", VA = "0x21B44F4")]
	public RotationLimiter()
	{
	}
}
[Token(Token = "0x200000D")]
public static class UFs
{
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x21B45C8", Offset = "0x21B45C8", VA = "0x21B45C8")]
	public static Vector2 Vec3Xz(Vector3 vec3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x21B20DC", Offset = "0x21B20DC", VA = "0x21B20DC")]
	public static void InitTransformIdentity(ref GameObject o, bool bLocal = true)
	{
	}
}
[Token(Token = "0x200000E")]
public class CreateCollider
{
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x1E5154C", Offset = "0x1E5154C", VA = "0x1E5154C")]
	public static Collider CreateRightBoxCollider(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x1E51600", Offset = "0x1E51600", VA = "0x1E51600")]
	public static Collider CreateLeftBoxCollider(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x1E516B4", Offset = "0x1E516B4", VA = "0x1E516B4")]
	public static Collider CreateBodyCollider(GameObject obj)
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
public class XRTwistRelaxer : MonoBehaviour
{
	[Token(Token = "0x40000DC")]
	[FieldOffset(Offset = "0x18")]
	public IK ik;

	[Token(Token = "0x40000DD")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122ED84", Offset = "0x122ED84")]
	public Transform parent;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EDBC", Offset = "0x122EDBC")]
	public Transform child;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EDF4", Offset = "0x122EDF4")]
	public bool clockwise;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EE2C", Offset = "0x122EE2C")]
	public bool bLimitRotate;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EE64", Offset = "0x122EE64")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EE64", Offset = "0x122EE64")]
	public float weight;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EEB8", Offset = "0x122EEB8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EEB8", Offset = "0x122EEB8")]
	public float parentChildCrossfade;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x122EF0C", Offset = "0x122EF0C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EF0C", Offset = "0x122EF0C")]
	public float twistAngleOffset;

	[Token(Token = "0x40000E4")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 twistAxis;

	[Token(Token = "0x40000E5")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 axis;

	[Token(Token = "0x40000E6")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 axisRelativeToParentDefault;

	[Token(Token = "0x40000E7")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 axisRelativeToChildDefault;

	[Token(Token = "0x40000E8")]
	[FieldOffset(Offset = "0x70")]
	private bool initialed;

	[Token(Token = "0x40000E9")]
	[FieldOffset(Offset = "0x74")]
	public Quaternion defaultLocalRotation;

	[Token(Token = "0x40000EA")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 axis2;

	[Token(Token = "0x40000EB")]
	[FieldOffset(Offset = "0x90")]
	public float limit;

	[Token(Token = "0x40000EC")]
	[FieldOffset(Offset = "0x94")]
	public float limit11;

	[Token(Token = "0x40000ED")]
	[FieldOffset(Offset = "0x98")]
	public float limit12;

	[Token(Token = "0x40000EE")]
	[FieldOffset(Offset = "0x9C")]
	public float limit21;

	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0xA0")]
	public float limit22;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0xA4")]
	public float limit31;

	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0xA8")]
	public float limit32;

	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0xAC")]
	public float limitTwist;

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x21B45D0", Offset = "0x21B45D0", VA = "0x21B45D0")]
	public void Relax(bool limit = true)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x21B4AC4", Offset = "0x21B4AC4", VA = "0x21B4AC4")]
	public void initValue()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x21B4E84", Offset = "0x21B4E84", VA = "0x21B4E84")]
	private void Start()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x21B4E88", Offset = "0x21B4E88", VA = "0x21B4E88")]
	private void OnPostUpdate()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x21B4F10", Offset = "0x21B4F10", VA = "0x21B4F10")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x21B4F98", Offset = "0x21B4F98", VA = "0x21B4F98")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x21B50B0", Offset = "0x21B50B0", VA = "0x21B50B0")]
	private float MapValidRange(float v, float s)
	{
		return default(float);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x21B4A24", Offset = "0x21B4A24", VA = "0x21B4A24")]
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x21B50FC", Offset = "0x21B50FC", VA = "0x21B50FC")]
	protected Quaternion LimitRotation(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x21B53C0", Offset = "0x21B53C0", VA = "0x21B53C0")]
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x21B5554", Offset = "0x21B5554", VA = "0x21B5554")]
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x21B55D0", Offset = "0x21B55D0", VA = "0x21B55D0")]
	public XRTwistRelaxer()
	{
	}
}
[Token(Token = "0x2000010")]
public struct FootWeightController
{
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x0")]
	private IKEffector m_IKEffector;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x8")]
	private FBIKChain m_IKChain;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x10")]
	private Animator m_Animator;

	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x18")]
	public AvatarIKGoal IKGoal;

	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x20")]
	private IKSolverVR.Leg m_IKSolverVR;

	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EF68", Offset = "0x122EF68")]
	public float fMaxThresholdW;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EF80", Offset = "0x122EF80")]
	public float fPosW;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EF98", Offset = "0x122EF98")]
	public float fLastPosW;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x34")]
	private bool bTurnedPos;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EFB0", Offset = "0x122EFB0")]
	public float fRotW;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EFC8", Offset = "0x122EFC8")]
	public float fLastRotW;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x40")]
	private bool bTurnedRot;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EFE0", Offset = "0x122EFE0")]
	public float fConstranitPosW;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x48")]
	private float fCurrentPosW;

	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x4C")]
	private float fCurrentRotW;

	[Token(Token = "0x17000059")]
	public IKEffector IkEffector
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1E51768", Offset = "0x1E51768", VA = "0x1E51768")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005A")]
	public FBIKChain IkChain
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1E51770", Offset = "0x1E51770", VA = "0x1E51770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005B")]
	public IKSolverVR.Leg GetSolver
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1E51870", Offset = "0x1E51870", VA = "0x1E51870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x1E45034", Offset = "0x1E45034", VA = "0x1E45034")]
	public void Init(IKEffector ikEffector, FBIKChain ikChain)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x1E446F4", Offset = "0x1E446F4", VA = "0x1E446F4")]
	public void UpdateW(float deltaSpeed, FullBodyBipedIK FBBIK)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x1E4505C", Offset = "0x1E4505C", VA = "0x1E4505C")]
	public void Init(Animator animator, FootIndex index)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x1E4500C", Offset = "0x1E4500C", VA = "0x1E4500C")]
	public void Init(IKSolverVR.Leg IKSolverVR, Transform ikArmChain)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1E44064", Offset = "0x1E44064", VA = "0x1E44064")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x1E51778", Offset = "0x1E51778", VA = "0x1E51778")]
	private void _Init()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1E5179C", Offset = "0x1E5179C", VA = "0x1E5179C")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x1E455C0", Offset = "0x1E455C0", VA = "0x1E455C0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1E45164", Offset = "0x1E45164", VA = "0x1E45164")]
	public void TurnPosW(float value)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x1E451CC", Offset = "0x1E451CC", VA = "0x1E451CC")]
	public void TurnRotW(float value)
	{
	}
}
[Token(Token = "0x2000011")]
public struct GroundWeightController
{
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x0")]
	private GrounderFBBIK mGroundFBBIK;

	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x8")]
	private Animator m_Animator;

	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x10")]
	public AvatarIKGoal IKGoal;

	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x18")]
	private GrounderVRIK mGroundVRIK;

	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122EFF8", Offset = "0x122EFF8")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F010", Offset = "0x122F010")]
	public float fWeight;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F028", Offset = "0x122F028")]
	public float fLastWeight;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x2C")]
	private bool bTurned;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x30")]
	private float fCurrentW;

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x1E461D4", Offset = "0x1E461D4", VA = "0x1E461D4")]
	public void Init(GrounderFBBIK ik)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1E45F6C", Offset = "0x1E45F6C", VA = "0x1E45F6C")]
	public void UpdateW(float deltaSpeed, GrounderFBBIK m_FBBIK)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1E461EC", Offset = "0x1E461EC", VA = "0x1E461EC")]
	public void Init(Animator animator)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x1E461A0", Offset = "0x1E461A0", VA = "0x1E461A0")]
	public void Init(GrounderVRIK ik)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1E46058", Offset = "0x1E46058", VA = "0x1E46058")]
	public void UpdateW(float deltaSpeed, GrounderVRIK VRIK)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x1E51878", Offset = "0x1E51878", VA = "0x1E51878")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x1E5188C", Offset = "0x1E5188C", VA = "0x1E5188C")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x1E46278", Offset = "0x1E46278", VA = "0x1E46278")]
	public void Reset()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x1E46220", Offset = "0x1E46220", VA = "0x1E46220")]
	public void TurnOn(float value)
	{
	}
}
[Token(Token = "0x2000012")]
public struct HandWeightController
{
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x0")]
	private IKEffector m_IKEffector;

	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x8")]
	private FBIKChain m_IKArmChain;

	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x10")]
	private Animator m_Animator;

	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x18")]
	public AvatarIKGoal UIKGoal;

	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x1C")]
	public AvatarIKHint UIKUnit;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x20")]
	private IKSolverVR.Arm m_IKSolverVR;

	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x28")]
	private XRTwistRelaxer IK_TR;

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x30")]
	private float TWIST_ANGLE;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F040", Offset = "0x122F040")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F058", Offset = "0x122F058")]
	public float fPosW;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F070", Offset = "0x122F070")]
	public float fLastPosW;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x40")]
	private bool bTurnedPos;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F088", Offset = "0x122F088")]
	public float fRotW;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F0A0", Offset = "0x122F0A0")]
	public float fLastRotW;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x4C")]
	private bool bTurnedRot;

	[Token(Token = "0x400011A")]
	[FieldOffset(Offset = "0x50")]
	public float fFakePosW;

	[Token(Token = "0x400011B")]
	[FieldOffset(Offset = "0x54")]
	public float fLastFakePosW;

	[Token(Token = "0x400011C")]
	[FieldOffset(Offset = "0x58")]
	public bool bFakeTurned;

	[Token(Token = "0x400011D")]
	[FieldOffset(Offset = "0x5C")]
	private float fCurrentPosW;

	[Token(Token = "0x400011E")]
	[FieldOffset(Offset = "0x60")]
	private float fCurrentRotW;

	[Token(Token = "0x400011F")]
	[FieldOffset(Offset = "0x64")]
	private float fOrinDelayTime;

	[Token(Token = "0x4000120")]
	[FieldOffset(Offset = "0x68")]
	public float fDelayTimer;

	[Token(Token = "0x4000121")]
	[FieldOffset(Offset = "0x6C")]
	private bool bRealReset;

	[Token(Token = "0x1700005C")]
	public IKEffector IkEffector
	{
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1E51900", Offset = "0x1E51900", VA = "0x1E51900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005D")]
	public FBIKChain IkArmChain
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1E51908", Offset = "0x1E51908", VA = "0x1E51908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005E")]
	public IKSolverVR.Arm GetSolver
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x1E51B88", Offset = "0x1E51B88", VA = "0x1E51B88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005F")]
	public float PosWeight
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1E51B90", Offset = "0x1E51B90", VA = "0x1E51B90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000060")]
	public float RotWeight
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1E51B98", Offset = "0x1E51B98", VA = "0x1E51B98")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000061")]
	public float DELAY_TIME
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x1E51BA8", Offset = "0x1E51BA8", VA = "0x1E51BA8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x1E51BA0", Offset = "0x1E51BA0", VA = "0x1E51BA0")]
		set
		{
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1E49F14", Offset = "0x1E49F14", VA = "0x1E49F14")]
	public void Init(IKEffector ikEffector, FBIKChain ikArmChain, XRTwistRelaxer tr, float twist_angle)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1E486D4", Offset = "0x1E486D4", VA = "0x1E486D4")]
	public void UpdateW(float deltaSpeed, FullBodyBipedIK FBBIK)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x1E49F60", Offset = "0x1E49F60", VA = "0x1E49F60")]
	public void Init(Animator animator, HandIndex index)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x1E487CC", Offset = "0x1E487CC", VA = "0x1E487CC")]
	public void UpdateW(float deltaSpeed, Animator animator)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x1E49ECC", Offset = "0x1E49ECC", VA = "0x1E49ECC")]
	public void Init(IKSolverVR.Arm IKSolverVR, Transform ikArmChain, XRTwistRelaxer tr, float twist_angle)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x1E47BA4", Offset = "0x1E47BA4", VA = "0x1E47BA4")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x1E51910", Offset = "0x1E51910", VA = "0x1E51910")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x1E51BB0", Offset = "0x1E51BB0", VA = "0x1E51BB0")]
	private void RealReset()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x1E51BD8", Offset = "0x1E51BD8", VA = "0x1E51BD8")]
	private void UpdateResetDelay(float rate)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x1E51950", Offset = "0x1E51950", VA = "0x1E51950")]
	private void _UpdateW(float deltaSpeed, bool bSlowUp = false)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x1E4AA08", Offset = "0x1E4AA08", VA = "0x1E4AA08")]
	public void Reset()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1E4AA8C", Offset = "0x1E4AA8C", VA = "0x1E4AA8C")]
	public void ResetFakeDisable()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1E4A334", Offset = "0x1E4A334", VA = "0x1E4A334")]
	public void TurnPosW(float value)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x1E4A3DC", Offset = "0x1E4A3DC", VA = "0x1E4A3DC")]
	public void TurnRotW(float value)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1E4A494", Offset = "0x1E4A494", VA = "0x1E4A494")]
	public void TurnFakePosW(float value)
	{
	}
}
[Token(Token = "0x2000013")]
public struct HeadWeightController
{
	[Token(Token = "0x4000122")]
	[FieldOffset(Offset = "0x0")]
	private IKEffector m_IKEffector;

	[Token(Token = "0x4000123")]
	[FieldOffset(Offset = "0x8")]
	private Animator m_Animator;

	[Token(Token = "0x4000124")]
	[FieldOffset(Offset = "0x10")]
	private IKSolverVR.Spine m_IKSolverVR;

	[Token(Token = "0x4000125")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F0B8", Offset = "0x122F0B8")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F0D0", Offset = "0x122F0D0")]
	public float fPosW;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F0E8", Offset = "0x122F0E8")]
	public float fLastPosW;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x24")]
	private bool bTurnedPos;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x28")]
	private float fCurrentPosW;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x21B19BC", Offset = "0x21B19BC", VA = "0x21B19BC")]
	public void Init(Animator animator)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x21B19F0", Offset = "0x21B19F0", VA = "0x21B19F0")]
	public void UpdateW(float deltaSpeed, Vector3 pos)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x21B1B58", Offset = "0x21B1B58", VA = "0x21B1B58")]
	public void Init(IKSolverVR.Spine IKSolverVR)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x21B1B74", Offset = "0x21B1B74", VA = "0x21B1B74")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x21B19D8", Offset = "0x21B19D8", VA = "0x21B19D8")]
	private void _Init()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x21B1AE4", Offset = "0x21B1AE4", VA = "0x21B1AE4")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x21B1BB0", Offset = "0x21B1BB0", VA = "0x21B1BB0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x21B1BC0", Offset = "0x21B1BC0", VA = "0x21B1BC0")]
	public void TurnPosW(float value)
	{
	}
}
[Token(Token = "0x2000014")]
public struct IKWeightController
{
	[Token(Token = "0x400012A")]
	[FieldOffset(Offset = "0x0")]
	private IKSolver m_IKSolver;

	[Token(Token = "0x400012B")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F100", Offset = "0x122F100")]
	public float fMaxThresholdW;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F118", Offset = "0x122F118")]
	public float fWeight;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F130", Offset = "0x122F130")]
	public float fLastWeight;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x14")]
	private float fCurrentW;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x18")]
	private bool bTurned;

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x21B2758", Offset = "0x21B2758", VA = "0x21B2758")]
	public void Init(IKSolver ik)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x21B2784", Offset = "0x21B2784", VA = "0x21B2784")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x21B2770", Offset = "0x21B2770", VA = "0x21B2770")]
	private void _Init()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x21B27C0", Offset = "0x21B27C0", VA = "0x21B27C0")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x21B2834", Offset = "0x21B2834", VA = "0x21B2834")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x21B2844", Offset = "0x21B2844", VA = "0x21B2844")]
	public void TurnOn(float value)
	{
	}
}
[Token(Token = "0x2000015")]
public struct LocoMotionWeightController
{
	[Token(Token = "0x4000130")]
	[FieldOffset(Offset = "0x0")]
	private IKSolverVR.Locomotion mLocoMotion;

	[Token(Token = "0x4000131")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F148", Offset = "0x122F148")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F160", Offset = "0x122F160")]
	public float fWeight;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x122F178", Offset = "0x122F178")]
	public float fLastWeight;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x14")]
	private float fCurrentW;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x18")]
	private bool bTurned;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x21B2858", Offset = "0x21B2858", VA = "0x21B2858")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x21B2868", Offset = "0x21B2868", VA = "0x21B2868")]
	public void TurnOn(float value)
	{
	}
}
