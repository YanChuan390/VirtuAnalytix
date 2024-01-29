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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA424", Offset = "0x12BA424")]
	private Transform <LFootTrans>k__BackingField;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA434", Offset = "0x12BA434")]
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
		[Address(RVA = "0x2240DBC", Offset = "0x2240DBC", VA = "0x2240DBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA8D0", Offset = "0x12BA8D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2240DC4", Offset = "0x2240DC4", VA = "0x2240DC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA8E0", Offset = "0x12BA8E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Transform RFootTrans
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2240DCC", Offset = "0x2240DCC", VA = "0x2240DCC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA8F0", Offset = "0x12BA8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2240DD4", Offset = "0x2240DD4", VA = "0x2240DD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA900", Offset = "0x12BA900")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public float WeightSpeed
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2240DDC", Offset = "0x2240DDC", VA = "0x2240DDC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2240DE4", Offset = "0x2240DE4", VA = "0x2240DE4")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public bool ShowDebug
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2240DEC", Offset = "0x2240DEC", VA = "0x2240DEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000005")]
	public bool IsReady
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2240DF4", Offset = "0x2240DF4", VA = "0x2240DF4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000006")]
	public bool UseIK
	{
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2240DFC", Offset = "0x2240DFC", VA = "0x2240DFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2240E04", Offset = "0x2240E04", VA = "0x2240E04")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2240EBC", Offset = "0x2240EBC", VA = "0x2240EBC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2240EC4", Offset = "0x2240EC4", VA = "0x2240EC4")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 RFoot_Target_Position
	{
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2242194", Offset = "0x2242194", VA = "0x2242194")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x224219C", Offset = "0x224219C", VA = "0x224219C")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 LFoot_Target_Position
	{
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22421A4", Offset = "0x22421A4", VA = "0x22421A4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22421AC", Offset = "0x22421AC", VA = "0x22421AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Quaternion RFoot_Target_Rotation
	{
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22421B4", Offset = "0x22421B4", VA = "0x22421B4")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22421BC", Offset = "0x22421BC", VA = "0x22421BC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Quaternion LFoot_Target_Rotation
	{
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x22421C4", Offset = "0x22421C4", VA = "0x22421C4")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22421CC", Offset = "0x22421CC", VA = "0x22421CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float RFoot_PositionWeight
	{
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x22421D4", Offset = "0x22421D4", VA = "0x22421D4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x22421DC", Offset = "0x22421DC", VA = "0x22421DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public float LFoot_PositionWeight
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x22421E4", Offset = "0x22421E4", VA = "0x22421E4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x22421EC", Offset = "0x22421EC", VA = "0x22421EC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public float RFoot_RotationWeight
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22421F4", Offset = "0x22421F4", VA = "0x22421F4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x22421FC", Offset = "0x22421FC", VA = "0x22421FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public float LFoot_RotationWeight
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2242204", Offset = "0x2242204", VA = "0x2242204")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x224220C", Offset = "0x224220C", VA = "0x224220C")]
		set
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x22402CC", Offset = "0x22402CC", VA = "0x22402CC")]
	private void SetupFBBIKTargets()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2240614", Offset = "0x2240614", VA = "0x2240614")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2240618", Offset = "0x2240618", VA = "0x2240618")]
	private void SetupUNITYIKTargets()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2240648", Offset = "0x2240648", VA = "0x2240648")]
	private void UpdateVRIK()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2240AF0", Offset = "0x2240AF0", VA = "0x2240AF0")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2240ECC", Offset = "0x2240ECC", VA = "0x2240ECC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x224108C", Offset = "0x224108C", VA = "0x224108C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2240F9C", Offset = "0x2240F9C", VA = "0x2240F9C")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x224173C", Offset = "0x224173C", VA = "0x224173C")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2241190", Offset = "0x2241190", VA = "0x2241190")]
	private void SetupIKTargets()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x22411E0", Offset = "0x22411E0", VA = "0x22411E0")]
	private void InitFootWeightControllers()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2240E10", Offset = "0x2240E10", VA = "0x2240E10")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2241510", Offset = "0x2241510", VA = "0x2241510")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2241AC0", Offset = "0x2241AC0", VA = "0x2241AC0")]
	private float _GetFootPosW(FootIndex index)
	{
		return default(float);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2241B00", Offset = "0x2241B00", VA = "0x2241B00")]
	private float _GetFootRotW(FootIndex index)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2241B40", Offset = "0x2241B40", VA = "0x2241B40")]
	private void _SetFootPosW(FootIndex index, float v)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2241BB0", Offset = "0x2241BB0", VA = "0x2241BB0")]
	private void _SetFootRotW(FootIndex index, float v)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2241C10", Offset = "0x2241C10", VA = "0x2241C10")]
	private Vector3 _GetFootTargetPos(FootIndex index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2241C58", Offset = "0x2241C58", VA = "0x2241C58")]
	private void _SetFootTargetPos(FootIndex index, Vector3 vPos)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2241DC4", Offset = "0x2241DC4", VA = "0x2241DC4")]
	private Quaternion _GetFootTargetRot(FootIndex index)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2241E08", Offset = "0x2241E08", VA = "0x2241E08")]
	private void _SetFootTargetRot(FootIndex index, Quaternion qRot)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2240A3C", Offset = "0x2240A3C", VA = "0x2240A3C")]
	public Transform GetFoot(FootIndex index)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2241F84", Offset = "0x2241F84", VA = "0x2241F84")]
	public void SwitchOffFoot(FootIndex id, bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2242090", Offset = "0x2242090", VA = "0x2242090")]
	public bool TryGetFixedPosition(FootIndex index, Vector3 vPos, out Vector3 fixedPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x2242014", Offset = "0x2242014", VA = "0x2242014")]
	public void SetFootWeight(FootIndex _Foot, float _weight)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x2242214", Offset = "0x2242214", VA = "0x2242214")]
	public float GetFootWeight(FootIndex _foot)
	{
		return default(float);
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2242234", Offset = "0x2242234", VA = "0x2242234")]
	public void SetupUpdateRatio(float ratio)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x224225C", Offset = "0x224225C", VA = "0x224225C")]
	public void SetupLerp(bool lerp)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2242268", Offset = "0x2242268", VA = "0x2242268")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x224144C", Offset = "0x224144C", VA = "0x224144C")]
	public void UpdateLODLevel()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2242280", Offset = "0x2242280", VA = "0x2242280")]
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
		[Address(RVA = "0x22427AC", Offset = "0x22427AC", VA = "0x22427AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool UseIK
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x22427B4", Offset = "0x22427B4", VA = "0x22427B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x22427A0", Offset = "0x22427A0", VA = "0x22427A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2242804", Offset = "0x2242804", VA = "0x2242804")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x224280C", Offset = "0x224280C", VA = "0x224280C")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public float WeightSpeed
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2242814", Offset = "0x2242814", VA = "0x2242814")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x224281C", Offset = "0x224281C", VA = "0x224281C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public float Ground_Weight
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2242CB8", Offset = "0x2242CB8", VA = "0x2242CB8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2242CC0", Offset = "0x2242CC0", VA = "0x2242CC0")]
		set
		{
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2242368", Offset = "0x2242368", VA = "0x2242368")]
	private void InitGroundFBBIKComponent()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x22424F8", Offset = "0x22424F8", VA = "0x22424F8")]
	private void InitGroundUnityIKComponent()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x2242524", Offset = "0x2242524", VA = "0x2242524")]
	private void InitGroundVRIKComponent()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22426B4", Offset = "0x22426B4", VA = "0x22426B4")]
	public void SetLayer(int mask = -1)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22426F0", Offset = "0x22426F0", VA = "0x22426F0")]
	public void UpdateLODLevel()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2242824", Offset = "0x2242824", VA = "0x2242824")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2242968", Offset = "0x2242968", VA = "0x2242968")]
	private void Update()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x22428F4", Offset = "0x22428F4", VA = "0x22428F4")]
	private void _Init()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2242B28", Offset = "0x2242B28", VA = "0x2242B28")]
	private void InitGroundWeightControllers()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x22427BC", Offset = "0x22427BC", VA = "0x22427BC")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2242C34", Offset = "0x2242C34", VA = "0x2242C34")]
	private float _GetGroundW()
	{
		return default(float);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2242C3C", Offset = "0x2242C3C", VA = "0x2242C3C")]
	private void _SetGroundW(float v)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2242C64", Offset = "0x2242C64", VA = "0x2242C64")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2242C7C", Offset = "0x2242C7C", VA = "0x2242C7C")]
	public void SwitchOffGround(bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2242BE8", Offset = "0x2242BE8", VA = "0x2242BE8")]
	public void SetGroundWeight(float _weight)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2242CD4", Offset = "0x2242CD4", VA = "0x2242CD4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA444", Offset = "0x12BA444")]
	private Transform <SpineTrans>k__BackingField;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA454", Offset = "0x12BA454")]
	private Transform <LHandTrans>k__BackingField;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA464", Offset = "0x12BA464")]
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
		[Address(RVA = "0x2244A80", Offset = "0x2244A80", VA = "0x2244A80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA910", Offset = "0x12BA910")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2244A88", Offset = "0x2244A88", VA = "0x2244A88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA920", Offset = "0x12BA920")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public Transform LHandTrans
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2244A90", Offset = "0x2244A90", VA = "0x2244A90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA930", Offset = "0x12BA930")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2244A98", Offset = "0x2244A98", VA = "0x2244A98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA940", Offset = "0x12BA940")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public Transform RHandTrans
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2244AA0", Offset = "0x2244AA0", VA = "0x2244AA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA950", Offset = "0x12BA950")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2244AA8", Offset = "0x2244AA8", VA = "0x2244AA8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA960", Offset = "0x12BA960")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public IKType IKType
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2244AB0", Offset = "0x2244AB0", VA = "0x2244AB0")]
		get
		{
			return default(IKType);
		}
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2244B14", Offset = "0x2244B14", VA = "0x2244B14")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public float WeightRatio
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2244B7C", Offset = "0x2244B7C", VA = "0x2244B7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x2244B84", Offset = "0x2244B84", VA = "0x2244B84")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public Vector2 AVATAR_CENTERxz
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2244BB4", Offset = "0x2244BB4", VA = "0x2244BB4")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2244BAC", Offset = "0x2244BAC", VA = "0x2244BAC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public float AVATAR_RADIUS
	{
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2244BC4", Offset = "0x2244BC4", VA = "0x2244BC4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2244BBC", Offset = "0x2244BBC", VA = "0x2244BBC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public bool IsLerp
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x2244BCC", Offset = "0x2244BCC", VA = "0x2244BCC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x2244BD4", Offset = "0x2244BD4", VA = "0x2244BD4")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public float SWIVEL_SCALE
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x2244BE0", Offset = "0x2244BE0", VA = "0x2244BE0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x2244BE8", Offset = "0x2244BE8", VA = "0x2244BE8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x2244BF0", Offset = "0x2244BF0", VA = "0x2244BF0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x2244BF8", Offset = "0x2244BF8", VA = "0x2244BF8")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	public bool ShowDebug
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x2244C00", Offset = "0x2244C00", VA = "0x2244C00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool IsReady
	{
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x2244C08", Offset = "0x2244C08", VA = "0x2244C08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000021")]
	public bool UseIK
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x2244C10", Offset = "0x2244C10", VA = "0x2244C10")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x2244C18", Offset = "0x2244C18", VA = "0x2244C18")]
		set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public Vector3 RHand_Target_Position
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x22474E0", Offset = "0x22474E0", VA = "0x22474E0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x22474E8", Offset = "0x22474E8", VA = "0x22474E8")]
		set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public Vector3 LHand_Target_Position
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x22474F0", Offset = "0x22474F0", VA = "0x22474F0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x22474F8", Offset = "0x22474F8", VA = "0x22474F8")]
		set
		{
		}
	}

	[Token(Token = "0x17000024")]
	public Quaternion RHand_Target_Rotation
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2247500", Offset = "0x2247500", VA = "0x2247500")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2247508", Offset = "0x2247508", VA = "0x2247508")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	public Quaternion LHand_Target_Rotation
	{
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2247510", Offset = "0x2247510", VA = "0x2247510")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2247518", Offset = "0x2247518", VA = "0x2247518")]
		set
		{
		}
	}

	[Token(Token = "0x17000026")]
	public float RHand_PositionWeight
	{
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2247520", Offset = "0x2247520", VA = "0x2247520")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x22473A0", Offset = "0x22473A0", VA = "0x22473A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public float LHand_PositionWeight
	{
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2247528", Offset = "0x2247528", VA = "0x2247528")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2247390", Offset = "0x2247390", VA = "0x2247390")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public float RHand_RotationWeight
	{
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2247530", Offset = "0x2247530", VA = "0x2247530")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x22473A8", Offset = "0x22473A8", VA = "0x22473A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public float LHand_RotationWeight
	{
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2247538", Offset = "0x2247538", VA = "0x2247538")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2247398", Offset = "0x2247398", VA = "0x2247398")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public float RHand_FakePositionWeight
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2247540", Offset = "0x2247540", VA = "0x2247540")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2247548", Offset = "0x2247548", VA = "0x2247548")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public float LHand_FakePositionWeight
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2247550", Offset = "0x2247550", VA = "0x2247550")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2247558", Offset = "0x2247558", VA = "0x2247558")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public float RHand_SlowDwonTime
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2247560", Offset = "0x2247560", VA = "0x2247560")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2247568", Offset = "0x2247568", VA = "0x2247568")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public float LHand_SlowDwonTime
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2247570", Offset = "0x2247570", VA = "0x2247570")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2247578", Offset = "0x2247578", VA = "0x2247578")]
		set
		{
		}
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2242CF0", Offset = "0x2242CF0", VA = "0x2242CF0")]
	private void SetupFBBIKTargets()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x22430D4", Offset = "0x22430D4", VA = "0x22430D4")]
	private void SetupFBBIKConfig()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2243184", Offset = "0x2243184", VA = "0x2243184")]
	private void SetupUnityIKTargets()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x22434E0", Offset = "0x22434E0", VA = "0x22434E0")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x22436D0", Offset = "0x22436D0", VA = "0x22436D0")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2243B04", Offset = "0x2243B04", VA = "0x2243B04")]
	private void SetupVRIKConfig()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2243B9C", Offset = "0x2243B9C", VA = "0x2243B9C")]
	private void InitHandRotateLimiter()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2243D98", Offset = "0x2243D98", VA = "0x2243D98")]
	private void InitHandTwisterRelaxer()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x22440DC", Offset = "0x22440DC", VA = "0x22440DC")]
	private void UpdateVRIK()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2244708", Offset = "0x2244708", VA = "0x2244708")]
	private void UpdateHandTwisterRelaxer()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x22448E8", Offset = "0x22448E8", VA = "0x22448E8")]
	private void UpdateHandRotationLimiter()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2244CC0", Offset = "0x2244CC0", VA = "0x2244CC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2244E34", Offset = "0x2244E34", VA = "0x2244E34")]
	private void Update()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2244D90", Offset = "0x2244D90", VA = "0x2244D90")]
	private void Init()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x22461CC", Offset = "0x22461CC", VA = "0x22461CC")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2245368", Offset = "0x2245368", VA = "0x2245368")]
	private void SetupIKTargets()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2245448", Offset = "0x2245448", VA = "0x2245448")]
	private void InitWeightControllers()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2244C24", Offset = "0x2244C24", VA = "0x2244C24")]
	private void UpdateConfig()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x22469E4", Offset = "0x22469E4", VA = "0x22469E4")]
	private void SetupIKBodyConstraint()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x22457E4", Offset = "0x22457E4", VA = "0x22457E4")]
	private void UpdateLODLevel()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2246AB8", Offset = "0x2246AB8", VA = "0x2246AB8")]
	private Vector3 CaulBodyConstraint(HandIndex id, float rate)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2244A7C", Offset = "0x2244A7C", VA = "0x2244A7C")]
	private void UpdateHandBendGoal()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2246C5C", Offset = "0x2246C5C", VA = "0x2246C5C")]
	private Transform GetBendGoal(HandIndex id)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2246CB4", Offset = "0x2246CB4", VA = "0x2246CB4")]
	private Vector3 GetBendGoalDefault(HandIndex id)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2246D14", Offset = "0x2246D14", VA = "0x2246D14")]
	private void SetHandPosW(int i, float w)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2246D7C", Offset = "0x2246D7C", VA = "0x2246D7C")]
	private float GetHandPosW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2246DBC", Offset = "0x2246DBC", VA = "0x2246DBC")]
	private void SetHandRotW(int i, float w)
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2246E24", Offset = "0x2246E24", VA = "0x2246E24")]
	private float GetHandRotW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2246E64", Offset = "0x2246E64", VA = "0x2246E64")]
	private void SetFakeHandPosW(int i, float w)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2246EE0", Offset = "0x2246EE0", VA = "0x2246EE0")]
	private float GetFakeHandPosW(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2246F20", Offset = "0x2246F20", VA = "0x2246F20")]
	private void SetHandSlowDownTime(int i, float v)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2246F60", Offset = "0x2246F60", VA = "0x2246F60")]
	private float GetHandSlowDownTime(int i)
	{
		return default(float);
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2246FA0", Offset = "0x2246FA0", VA = "0x2246FA0")]
	private void SetHandTargetPos(int i, Vector3 v)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x224710C", Offset = "0x224710C", VA = "0x224710C")]
	private Vector3 GetHandTargetPos(int i)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2247154", Offset = "0x2247154", VA = "0x2247154")]
	private void SetHandTargetRot(int i, Quaternion q)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x22472D0", Offset = "0x22472D0", VA = "0x22472D0")]
	private Quaternion GetHandTargetRot(int i)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2245908", Offset = "0x2245908", VA = "0x2245908")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x224457C", Offset = "0x224457C", VA = "0x224457C")]
	public Transform GetHand(HandIndex id)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x2247314", Offset = "0x2247314", VA = "0x2247314")]
	public void SetHandWeight(HandIndex id, float w)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x22473B0", Offset = "0x22473B0", VA = "0x22473B0")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x22473C8", Offset = "0x22473C8", VA = "0x22473C8")]
	public void SwitchOffHand(HandIndex id, bool bSwitchOff = true)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x2247458", Offset = "0x2247458", VA = "0x2247458")]
	public void SwitchOffHandFake(HandIndex id)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2247580", Offset = "0x2247580", VA = "0x2247580")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA474", Offset = "0x12BA474")]
	private Transform <ChestTrans>k__BackingField;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA484", Offset = "0x12BA484")]
	private Transform <UpperChestTrans>k__BackingField;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA494", Offset = "0x12BA494")]
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
		[Address(RVA = "0x2248BDC", Offset = "0x2248BDC", VA = "0x2248BDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2248BE4", Offset = "0x2248BE4", VA = "0x2248BE4")]
		set
		{
		}
	}

	[Token(Token = "0x1700002F")]
	public GameObject HeadFakeTarget
	{
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2248BEC", Offset = "0x2248BEC", VA = "0x2248BEC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2248BF4", Offset = "0x2248BF4", VA = "0x2248BF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000030")]
	public GameObject PelvisTarget
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2248BFC", Offset = "0x2248BFC", VA = "0x2248BFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2248C04", Offset = "0x2248C04", VA = "0x2248C04")]
		set
		{
		}
	}

	[Token(Token = "0x17000031")]
	public Transform ChestTrans
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2248C0C", Offset = "0x2248C0C", VA = "0x2248C0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA970", Offset = "0x12BA970")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2248C14", Offset = "0x2248C14", VA = "0x2248C14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA980", Offset = "0x12BA980")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000032")]
	public Transform UpperChestTrans
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2248C1C", Offset = "0x2248C1C", VA = "0x2248C1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA990", Offset = "0x12BA990")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2248C24", Offset = "0x2248C24", VA = "0x2248C24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9A0", Offset = "0x12BA9A0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000033")]
	public Transform NeckTrans
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2248C2C", Offset = "0x2248C2C", VA = "0x2248C2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9B0", Offset = "0x12BA9B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2248C34", Offset = "0x2248C34", VA = "0x2248C34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9C0", Offset = "0x12BA9C0")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public bool VRM
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2248CD0", Offset = "0x2248CD0", VA = "0x2248CD0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2248C3C", Offset = "0x2248C3C", VA = "0x2248C3C")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public bool LERP
	{
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2248CE4", Offset = "0x2248CE4", VA = "0x2248CE4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2248CD8", Offset = "0x2248CD8", VA = "0x2248CD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2248CEC", Offset = "0x2248CEC", VA = "0x2248CEC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2248CF4", Offset = "0x2248CF4", VA = "0x2248CF4")]
		set
		{
		}
	}

	[Token(Token = "0x17000037")]
	public bool TurnOn
	{
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2248CFC", Offset = "0x2248CFC", VA = "0x2248CFC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2248D04", Offset = "0x2248D04", VA = "0x2248D04")]
		set
		{
		}
	}

	[Token(Token = "0x17000038")]
	public bool ROT_CONSTRAINT
	{
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2248D14", Offset = "0x2248D14", VA = "0x2248D14")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2248D1C", Offset = "0x2248D1C", VA = "0x2248D1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public bool ShowDebug
	{
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2248D28", Offset = "0x2248D28", VA = "0x2248D28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003A")]
	public float WeightSpeed
	{
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2248D30", Offset = "0x2248D30", VA = "0x2248D30")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2248D38", Offset = "0x2248D38", VA = "0x2248D38")]
		set
		{
		}
	}

	[Token(Token = "0x1700003B")]
	public bool IsReady
	{
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2248D40", Offset = "0x2248D40", VA = "0x2248D40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public float Head_PositionWeight
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2249F2C", Offset = "0x2249F2C", VA = "0x2249F2C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2249F34", Offset = "0x2249F34", VA = "0x2249F34")]
		set
		{
		}
	}

	[Token(Token = "0x1700003D")]
	public Vector3 Head_Target_Position
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2249F74", Offset = "0x2249F74", VA = "0x2249F74")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2249F84", Offset = "0x2249F84", VA = "0x2249F84")]
		set
		{
		}
	}

	[Token(Token = "0x1700003E")]
	public Quaternion Head_Target_Rotation
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2249F94", Offset = "0x2249F94", VA = "0x2249F94")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2249FA8", Offset = "0x2249FA8", VA = "0x2249FA8")]
		set
		{
		}
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x2247708", Offset = "0x2247708", VA = "0x2247708")]
	private void _CalDeltaRotation()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x2247C48", Offset = "0x2247C48", VA = "0x2247C48")]
	private void InitHeadFBBIKComponent()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x22480A8", Offset = "0x22480A8", VA = "0x22480A8")]
	private void SetupUNITYIKTargets()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x224818C", Offset = "0x224818C", VA = "0x224818C")]
	private void SetupUNITYIKConfig()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x224819C", Offset = "0x224819C", VA = "0x224819C")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x22482A4", Offset = "0x22482A4", VA = "0x22482A4")]
	private void UpdateDeltaRotation()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2248928", Offset = "0x2248928", VA = "0x2248928")]
	private void SetupVRIKTargets()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2248A8C", Offset = "0x2248A8C", VA = "0x2248A8C")]
	private void SetupVRIKConfig()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2248D48", Offset = "0x2248D48", VA = "0x2248D48")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2248F7C", Offset = "0x2248F7C", VA = "0x2248F7C")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x22490C0", Offset = "0x22490C0", VA = "0x22490C0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2248E18", Offset = "0x2248E18", VA = "0x2248E18")]
	private void _Init()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x22491B8", Offset = "0x22491B8", VA = "0x22491B8")]
	private void InitWeightControllers()
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x224988C", Offset = "0x224988C", VA = "0x224988C")]
	private void InitIKTargetObjects()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2249158", Offset = "0x2249158", VA = "0x2249158")]
	private void InitHeadVRIKComponent()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2249184", Offset = "0x2249184", VA = "0x2249184")]
	private void InitHeadUnityIKComponent()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2249C40", Offset = "0x2249C40", VA = "0x2249C40")]
	private float _GetHeadPosW()
	{
		return default(float);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2249C48", Offset = "0x2249C48", VA = "0x2249C48")]
	private void _SetHeadPosW(float v)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2249C88", Offset = "0x2249C88", VA = "0x2249C88")]
	private Vector3 GetHeadTargetPos()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2249C98", Offset = "0x2249C98", VA = "0x2249C98")]
	private void SetHeadTargetPos(Vector3 vPos)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2249CA8", Offset = "0x2249CA8", VA = "0x2249CA8")]
	private Quaternion GetHeadTargetRot()
	{
		return default(Quaternion);
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2249CBC", Offset = "0x2249CBC", VA = "0x2249CBC")]
	private void SetHeadTargetRot(Quaternion qRot)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2249270", Offset = "0x2249270", VA = "0x2249270")]
	private void ApplyLODLevel()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x22492A8", Offset = "0x22492A8", VA = "0x22492A8")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2248C88", Offset = "0x2248C88", VA = "0x2248C88")]
	private void GetOriginalHeadEuler()
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2249CD0", Offset = "0x2249CD0", VA = "0x2249CD0")]
	public void SetupUpdateRatio(float ratio)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2249CF8", Offset = "0x2249CF8", VA = "0x2249CF8")]
	public void SetupSitState(bool bSit)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2249ED8", Offset = "0x2249ED8", VA = "0x2249ED8")]
	public void SetupSitTarget(Vector3 vPos)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2249FBC", Offset = "0x2249FBC", VA = "0x2249FBC")]
	public void SetHeadPosWeight(float fWeight)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2249FF4", Offset = "0x2249FF4", VA = "0x2249FF4")]
	public void SwitchOffHeadPos(bool bSwitchOff)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x224A070", Offset = "0x224A070", VA = "0x224A070")]
	public void SetupSoftnessScale(float fScale)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x224A078", Offset = "0x224A078", VA = "0x224A078")]
	public void SetupChestRotate(bool bRot, bool bUseHeadPos = false)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2249E3C", Offset = "0x2249E3C", VA = "0x2249E3C")]
	public void SetYawAngle(bool bSit)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x224A160", Offset = "0x224A160", VA = "0x224A160")]
	public void SetupLODLevel(ELODLevel level)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x224A1A4", Offset = "0x224A1A4", VA = "0x224A1A4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA4A4", Offset = "0x12BA4A4")]
	private Transform <HeadTrans>k__BackingField;

	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA4B4", Offset = "0x12BA4B4")]
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
		[Address(RVA = "0x224D760", Offset = "0x224D760", VA = "0x224D760")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x224D768", Offset = "0x224D768", VA = "0x224D768")]
		protected set
		{
		}
	}

	[Token(Token = "0x17000040")]
	public bool ENFORCE_IK_ENABLE
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x224D774", Offset = "0x224D774", VA = "0x224D774")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x224D77C", Offset = "0x224D77C", VA = "0x224D77C")]
		set
		{
		}
	}

	[Token(Token = "0x17000041")]
	public float SMOOTH_RATIO
	{
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x224D788", Offset = "0x224D788", VA = "0x224D788")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x224D790", Offset = "0x224D790", VA = "0x224D790")]
		set
		{
		}
	}

	[Token(Token = "0x17000042")]
	public VRIK VRIKref
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x224B0AC", Offset = "0x224B0AC", VA = "0x224B0AC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x224D798", Offset = "0x224D798", VA = "0x224D798")]
		set
		{
		}
	}

	[Token(Token = "0x17000043")]
	public FullBodyBipedIK FBBIKref
	{
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x224B6B4", Offset = "0x224B6B4", VA = "0x224B6B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x224D7A0", Offset = "0x224D7A0", VA = "0x224D7A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000044")]
	public Animator AnimatorRef
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x224B2F0", Offset = "0x224B2F0", VA = "0x224B2F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x224D7A8", Offset = "0x224D7A8", VA = "0x224D7A8")]
		set
		{
		}
	}

	[Token(Token = "0x17000045")]
	public bool IsFakeDisableIK
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x224D7B0", Offset = "0x224D7B0", VA = "0x224D7B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x224D7B8", Offset = "0x224D7B8", VA = "0x224D7B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000046")]
	public bool IsSit
	{
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x224D7C4", Offset = "0x224D7C4", VA = "0x224D7C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x224D7CC", Offset = "0x224D7CC", VA = "0x224D7CC")]
		set
		{
		}
	}

	[Token(Token = "0x17000047")]
	public bool IsMove
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x224D7D8", Offset = "0x224D7D8", VA = "0x224D7D8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x224D7E0", Offset = "0x224D7E0", VA = "0x224D7E0")]
		set
		{
		}
	}

	[Token(Token = "0x17000048")]
	public float NoInputTimer
	{
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x224D7EC", Offset = "0x224D7EC", VA = "0x224D7EC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x224C1A0", Offset = "0x224C1A0", VA = "0x224C1A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000049")]
	public IKConstraintMgr ConstraintMgr
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x224D7F4", Offset = "0x224D7F4", VA = "0x224D7F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x224D7FC", Offset = "0x224D7FC", VA = "0x224D7FC")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public Transform HeadTrans
	{
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x224D804", Offset = "0x224D804", VA = "0x224D804")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9D0", Offset = "0x12BA9D0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x224D80C", Offset = "0x224D80C", VA = "0x224D80C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9E0", Offset = "0x12BA9E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public Transform[] EyesTrans
	{
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x224D814", Offset = "0x224D814", VA = "0x224D814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BA9F0", Offset = "0x12BA9F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x224D81C", Offset = "0x224D81C", VA = "0x224D81C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x12BAA00", Offset = "0x12BAA00")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public AvatarHeadIKMgr HeadIKMgr
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x224D824", Offset = "0x224D824", VA = "0x224D824")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x224D82C", Offset = "0x224D82C", VA = "0x224D82C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004D")]
	public AvatarHandIKMgr HandIKMgr
	{
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x224D834", Offset = "0x224D834", VA = "0x224D834")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x224D83C", Offset = "0x224D83C", VA = "0x224D83C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004E")]
	public AvatarGroundIKMgr GroundIKMgr
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x224D844", Offset = "0x224D844", VA = "0x224D844")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x224D84C", Offset = "0x224D84C", VA = "0x224D84C")]
		set
		{
		}
	}

	[Token(Token = "0x1700004F")]
	public AvatarFootIKMgr FootIKMgr
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x224D854", Offset = "0x224D854", VA = "0x224D854")]
		get
		{
			return null;
		}
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x224D85C", Offset = "0x224D85C", VA = "0x224D85C")]
		set
		{
		}
	}

	[Token(Token = "0x17000050")]
	public bool ShowDebug
	{
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x224D864", Offset = "0x224D864", VA = "0x224D864")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000051")]
	public Vector3 SrcHeadPos
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x224D86C", Offset = "0x224D86C", VA = "0x224D86C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x224D87C", Offset = "0x224D87C", VA = "0x224D87C")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public Quaternion SrcHeadRot
	{
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x224D88C", Offset = "0x224D88C", VA = "0x224D88C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x224D8A0", Offset = "0x224D8A0", VA = "0x224D8A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000053")]
	public bool SrcLHandEnable
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x224D8B4", Offset = "0x224D8B4", VA = "0x224D8B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x224D8BC", Offset = "0x224D8BC", VA = "0x224D8BC")]
		set
		{
		}
	}

	[Token(Token = "0x17000054")]
	public Vector3 SrcLHandPos
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x224D8C8", Offset = "0x224D8C8", VA = "0x224D8C8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x224D8D8", Offset = "0x224D8D8", VA = "0x224D8D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000055")]
	public bool SrcRHandEnable
	{
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x224D8E8", Offset = "0x224D8E8", VA = "0x224D8E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x224D8F0", Offset = "0x224D8F0", VA = "0x224D8F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000056")]
	public Vector3 SrcRHandPos
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x224D8FC", Offset = "0x224D8FC", VA = "0x224D8FC")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x224D90C", Offset = "0x224D90C", VA = "0x224D90C")]
		set
		{
		}
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x224049C", Offset = "0x224049C", VA = "0x224049C")]
	public static FullBodyBipedIK GetFBBIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2240C8C", Offset = "0x2240C8C", VA = "0x2240C8C")]
	public static VRIK GetVRIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2240644", Offset = "0x2240644", VA = "0x2240644")]
	public static Animator GetUnityIKref(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2245298", Offset = "0x2245298", VA = "0x2245298")]
	public static Animator GetAnimatorRef(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x224A274", Offset = "0x224A274", VA = "0x224A274")]
	public void Init(bool bNPC = false)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x224B484", Offset = "0x224B484", VA = "0x224B484")]
	public bool InitPureNPCState()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x224B560", Offset = "0x224B560", VA = "0x224B560")]
	public bool IsIKEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x224B740", Offset = "0x224B740", VA = "0x224B740")]
	public void SetupHeadPosition(Vector3 vPos, Quaternion qRot, bool IsLerp = true, bool IsInput = true)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x224C1CC", Offset = "0x224C1CC", VA = "0x224C1CC")]
	public void SetupHandPosition(HandIndex hand, Vector3 vPos, Quaternion qRot, bool IsLerp = true, bool IsInput = true)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x224CDD8", Offset = "0x224CDD8", VA = "0x224CDD8")]
	public void SetupFootPosition(FootIndex foot, Vector3 vPos, Quaternion qRot, bool IsLerp = true)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x224B41C", Offset = "0x224B41C", VA = "0x224B41C")]
	public void TurnOnIK(bool bTurnOn = true)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x224D088", Offset = "0x224D088", VA = "0x224D088")]
	public void TurnOnLocoMotion(bool bTurnOn = true, bool lerp = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x224D154", Offset = "0x224D154", VA = "0x224D154")]
	public void TurnOnHead(bool bTurnOn = true, bool lerp = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x224D320", Offset = "0x224D320", VA = "0x224D320")]
	public void TurnOnHand(HandIndex hand, bool bTurnOn = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x224D41C", Offset = "0x224D41C", VA = "0x224D41C")]
	public void TurnOnFoot(FootIndex foot, bool bTurnOn = true, float updateRatio = 0f)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x224D4B4", Offset = "0x224D4B4", VA = "0x224D4B4")]
	public void TurnOnGround(bool bTurnOn = true)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x224D524", Offset = "0x224D524", VA = "0x224D524")]
	public void FakeDisableIK(bool bDisable)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x224D650", Offset = "0x224D650", VA = "0x224D650")]
	public void UpdateTurnAroundConfig()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x224D654", Offset = "0x224D654", VA = "0x224D654")]
	public void SetupSitState(bool bSit, Vector3 vPos)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x224B1D4", Offset = "0x224B1D4", VA = "0x224B1D4")]
	public void SetupLODLevel(ELODLevel level = ELODLevel.NEAR)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x224D91C", Offset = "0x224D91C", VA = "0x224D91C")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x224DA64", Offset = "0x224DA64", VA = "0x224DA64")]
	protected void FixedUpdate()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x224DCB4", Offset = "0x224DCB4", VA = "0x224DCB4")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x224DD40", Offset = "0x224DD40", VA = "0x224DD40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x224B37C", Offset = "0x224B37C", VA = "0x224B37C")]
	protected void InitConstraint(Transform t, bool bVRM)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x224AA7C", Offset = "0x224AA7C", VA = "0x224AA7C")]
	private void InitHeadIKComponent()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x224AC48", Offset = "0x224AC48", VA = "0x224AC48")]
	private void InitHandIKComponent()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x224AF3C", Offset = "0x224AF3C", VA = "0x224AF3C")]
	private void InitGroundIKComponent()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x224ADE8", Offset = "0x224ADE8", VA = "0x224ADE8")]
	private void InitFootIKComponent()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x224B138", Offset = "0x224B138", VA = "0x224B138")]
	private void InitWeightController()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x224CBC8", Offset = "0x224CBC8", VA = "0x224CBC8")]
	private void ReBuildCameraHandRelation(ref Vector3 vPos)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x224DAF8", Offset = "0x224DAF8", VA = "0x224DAF8")]
	private void PersistentInputData()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x224B418", Offset = "0x224B418", VA = "0x224B418")]
	private void InitDebugObjects()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x224DD3C", Offset = "0x224DD3C", VA = "0x224DD3C")]
	private void UpdaetDebugObjects()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x224DDEC", Offset = "0x224DDEC", VA = "0x224DDEC")]
	protected void _OnSkeletonChanged()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x224DDF8", Offset = "0x224DDF8", VA = "0x224DDF8")]
	private void OnNoInputImp()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x224DE10", Offset = "0x224DE10", VA = "0x224DE10")]
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
		[Address(RVA = "0x26C0630", Offset = "0x26C0630", VA = "0x26C0630")]
		set
		{
		}
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x26C063C", Offset = "0x26C063C", VA = "0x26C063C")]
	public void Init(Transform T, bool bVRM)
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x26C0BC8", Offset = "0x26C0BC8", VA = "0x26C0BC8")]
	public Vector3 Get_Valid_Hand_Position(HandIndex hand, Vector3 vPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x26C0E78", Offset = "0x26C0E78", VA = "0x26C0E78")]
	public void SetState(bool bSit = false)
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x26C112C", Offset = "0x26C112C", VA = "0x26C112C")]
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
		[Address(RVA = "0x26C12D8", Offset = "0x26C12D8", VA = "0x26C12D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x26C12E0", Offset = "0x26C12E0", VA = "0x26C12E0")]
		set
		{
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x26C12E8", Offset = "0x26C12E8", VA = "0x26C12E8")]
	private float calculateTwistX(ref Quaternion rotOnBase)
	{
		return default(float);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x26C1640", Offset = "0x26C1640", VA = "0x26C1640")]
	internal void init(IK ik, bool bRightHand)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x26C1B88", Offset = "0x26C1B88", VA = "0x26C1B88")]
	internal void OnPostUpdate()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x26C1F9C", Offset = "0x26C1F9C", VA = "0x26C1F9C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x26C20B4", Offset = "0x26C20B4", VA = "0x26C20B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x26C20B8", Offset = "0x26C20B8", VA = "0x26C20B8")]
	private Quaternion flatX(Quaternion q)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x26C22AC", Offset = "0x26C22AC", VA = "0x26C22AC")]
	private (float, bool) limitTwistY(float fTwist)
	{
		return default((float, bool));
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x26C23D4", Offset = "0x26C23D4", VA = "0x26C23D4")]
	private void preventStraitElbow()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x26C24B0", Offset = "0x26C24B0", VA = "0x26C24B0")]
	private void shareTwistToParent(float degreeTwist)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x26C1CDC", Offset = "0x26C1CDC", VA = "0x26C1CDC")]
	internal void LimitHandRotation()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x26C28A8", Offset = "0x26C28A8", VA = "0x26C28A8")]
	private static void normalizeYZ(ref Vector3 v)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x26C2934", Offset = "0x26C2934", VA = "0x26C2934")]
	private static void limitLocalAxis(ref Vector3 vNormaized, float nTangent, float pTangent)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x26C2658", Offset = "0x26C2658", VA = "0x26C2658")]
	public static Quaternion LimitHandBend(Quaternion handLocalRotation, Vector3 YLimit, Vector3 ZLimit)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x26C1480", Offset = "0x26C1480", VA = "0x26C1480")]
	internal static (Vector3, Vector3, Vector3) getRotationAxies(Quaternion ro)
	{
		return default((Vector3, Vector3, Vector3));
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x26C29D4", Offset = "0x26C29D4", VA = "0x26C29D4")]
	internal static Matrix4x4 makeRotMarix(Vector3 x, Vector3 y, Vector3 z)
	{
		return default(Matrix4x4);
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x26C2B24", Offset = "0x26C2B24", VA = "0x26C2B24")]
	internal static Quaternion makeRotationFromXY(Vector3 x, Vector3 y)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x26C2164", Offset = "0x26C2164", VA = "0x26C2164")]
	internal static Quaternion makeRotationFromYZ(Vector3 y, Vector3 z)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x26C2C6C", Offset = "0x26C2C6C", VA = "0x26C2C6C")]
	public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x26C2F50", Offset = "0x26C2F50", VA = "0x26C2F50")]
	public RotationLimiter()
	{
	}
}
[Token(Token = "0x200000D")]
public static class UFs
{
	[Token(Token = "0x6000164")]
	[Address(RVA = "0x26C3024", Offset = "0x26C3024", VA = "0x26C3024")]
	public static Vector2 Vec3Xz(Vector3 vec3)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x26C0B38", Offset = "0x26C0B38", VA = "0x26C0B38")]
	public static void InitTransformIdentity(ref GameObject o, bool bLocal = true)
	{
	}
}
[Token(Token = "0x200000E")]
public class CreateCollider
{
	[Token(Token = "0x6000166")]
	[Address(RVA = "0x224DF7C", Offset = "0x224DF7C", VA = "0x224DF7C")]
	public static Collider CreateRightBoxCollider(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x224E030", Offset = "0x224E030", VA = "0x224E030")]
	public static Collider CreateLeftBoxCollider(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x224E0E4", Offset = "0x224E0E4", VA = "0x224E0E4")]
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
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA4C4", Offset = "0x12BA4C4")]
	public Transform parent;

	[Token(Token = "0x40000DE")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA4FC", Offset = "0x12BA4FC")]
	public Transform child;

	[Token(Token = "0x40000DF")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA534", Offset = "0x12BA534")]
	public bool clockwise;

	[Token(Token = "0x40000E0")]
	[FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA56C", Offset = "0x12BA56C")]
	public bool bLimitRotate;

	[Token(Token = "0x40000E1")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA5A4", Offset = "0x12BA5A4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA5A4", Offset = "0x12BA5A4")]
	public float weight;

	[Token(Token = "0x40000E2")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA5F8", Offset = "0x12BA5F8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA5F8", Offset = "0x12BA5F8")]
	public float parentChildCrossfade;

	[Token(Token = "0x40000E3")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x12BA64C", Offset = "0x12BA64C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA64C", Offset = "0x12BA64C")]
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
	[Address(RVA = "0x26C302C", Offset = "0x26C302C", VA = "0x26C302C")]
	public void Relax(bool limit = true)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x26C3520", Offset = "0x26C3520", VA = "0x26C3520")]
	public void initValue()
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x26C38E0", Offset = "0x26C38E0", VA = "0x26C38E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x26C38E4", Offset = "0x26C38E4", VA = "0x26C38E4")]
	private void OnPostUpdate()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x26C396C", Offset = "0x26C396C", VA = "0x26C396C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x26C39F4", Offset = "0x26C39F4", VA = "0x26C39F4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x26C3B0C", Offset = "0x26C3B0C", VA = "0x26C3B0C")]
	private float MapValidRange(float v, float s)
	{
		return default(float);
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x26C3480", Offset = "0x26C3480", VA = "0x26C3480")]
	public Quaternion GetLimitedLocalRotation(Quaternion localRotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x26C3B58", Offset = "0x26C3B58", VA = "0x26C3B58")]
	protected Quaternion LimitRotation(Quaternion rotation)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x26C3E1C", Offset = "0x26C3E1C", VA = "0x26C3E1C")]
	protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x26C3FB0", Offset = "0x26C3FB0", VA = "0x26C3FB0")]
	protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x26C402C", Offset = "0x26C402C", VA = "0x26C402C")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA6A8", Offset = "0x12BA6A8")]
	public float fMaxThresholdW;

	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA6C0", Offset = "0x12BA6C0")]
	public float fPosW;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA6D8", Offset = "0x12BA6D8")]
	public float fLastPosW;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x34")]
	private bool bTurnedPos;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA6F0", Offset = "0x12BA6F0")]
	public float fRotW;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA708", Offset = "0x12BA708")]
	public float fLastRotW;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x40")]
	private bool bTurnedRot;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA720", Offset = "0x12BA720")]
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
		[Address(RVA = "0x224E198", Offset = "0x224E198", VA = "0x224E198")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005A")]
	public FBIKChain IkChain
	{
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x224E1A0", Offset = "0x224E1A0", VA = "0x224E1A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005B")]
	public IKSolverVR.Leg GetSolver
	{
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x224E2A0", Offset = "0x224E2A0", VA = "0x224E2A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2241A64", Offset = "0x2241A64", VA = "0x2241A64")]
	public void Init(IKEffector ikEffector, FBIKChain ikChain)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2241124", Offset = "0x2241124", VA = "0x2241124")]
	public void UpdateW(float deltaSpeed, FullBodyBipedIK FBBIK)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2241A8C", Offset = "0x2241A8C", VA = "0x2241A8C")]
	public void Init(Animator animator, FootIndex index)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2241A3C", Offset = "0x2241A3C", VA = "0x2241A3C")]
	public void Init(IKSolverVR.Leg IKSolverVR, Transform ikArmChain)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2240A94", Offset = "0x2240A94", VA = "0x2240A94")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x224E1A8", Offset = "0x224E1A8", VA = "0x224E1A8")]
	private void _Init()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x224E1CC", Offset = "0x224E1CC", VA = "0x224E1CC")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2241FF0", Offset = "0x2241FF0", VA = "0x2241FF0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2241B94", Offset = "0x2241B94", VA = "0x2241B94")]
	public void TurnPosW(float value)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x2241BFC", Offset = "0x2241BFC", VA = "0x2241BFC")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA738", Offset = "0x12BA738")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA750", Offset = "0x12BA750")]
	public float fWeight;

	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA768", Offset = "0x12BA768")]
	public float fLastWeight;

	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x2C")]
	private bool bTurned;

	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x30")]
	private float fCurrentW;

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x2242C04", Offset = "0x2242C04", VA = "0x2242C04")]
	public void Init(GrounderFBBIK ik)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x224299C", Offset = "0x224299C", VA = "0x224299C")]
	public void UpdateW(float deltaSpeed, GrounderFBBIK m_FBBIK)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x2242C1C", Offset = "0x2242C1C", VA = "0x2242C1C")]
	public void Init(Animator animator)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x2242BD0", Offset = "0x2242BD0", VA = "0x2242BD0")]
	public void Init(GrounderVRIK ik)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x2242A88", Offset = "0x2242A88", VA = "0x2242A88")]
	public void UpdateW(float deltaSpeed, GrounderVRIK VRIK)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x224E2A8", Offset = "0x224E2A8", VA = "0x224E2A8")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x224E2BC", Offset = "0x224E2BC", VA = "0x224E2BC")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x2242CA8", Offset = "0x2242CA8", VA = "0x2242CA8")]
	public void Reset()
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x2242C50", Offset = "0x2242C50", VA = "0x2242C50")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA780", Offset = "0x12BA780")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA798", Offset = "0x12BA798")]
	public float fPosW;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA7B0", Offset = "0x12BA7B0")]
	public float fLastPosW;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x40")]
	private bool bTurnedPos;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA7C8", Offset = "0x12BA7C8")]
	public float fRotW;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA7E0", Offset = "0x12BA7E0")]
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
		[Address(RVA = "0x224E330", Offset = "0x224E330", VA = "0x224E330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005D")]
	public FBIKChain IkArmChain
	{
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x224E338", Offset = "0x224E338", VA = "0x224E338")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005E")]
	public IKSolverVR.Arm GetSolver
	{
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x224E5B8", Offset = "0x224E5B8", VA = "0x224E5B8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005F")]
	public float PosWeight
	{
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x224E5C0", Offset = "0x224E5C0", VA = "0x224E5C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000060")]
	public float RotWeight
	{
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x224E5C8", Offset = "0x224E5C8", VA = "0x224E5C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000061")]
	public float DELAY_TIME
	{
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x224E5D8", Offset = "0x224E5D8", VA = "0x224E5D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x224E5D0", Offset = "0x224E5D0", VA = "0x224E5D0")]
		set
		{
		}
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x2246944", Offset = "0x2246944", VA = "0x2246944")]
	public void Init(IKEffector ikEffector, FBIKChain ikArmChain, XRTwistRelaxer tr, float twist_angle)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2245104", Offset = "0x2245104", VA = "0x2245104")]
	public void UpdateW(float deltaSpeed, FullBodyBipedIK FBBIK)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2246990", Offset = "0x2246990", VA = "0x2246990")]
	public void Init(Animator animator, HandIndex index)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x22451FC", Offset = "0x22451FC", VA = "0x22451FC")]
	public void UpdateW(float deltaSpeed, Animator animator)
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x22468FC", Offset = "0x22468FC", VA = "0x22468FC")]
	public void Init(IKSolverVR.Arm IKSolverVR, Transform ikArmChain, XRTwistRelaxer tr, float twist_angle)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x22445D4", Offset = "0x22445D4", VA = "0x22445D4")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x224E340", Offset = "0x224E340", VA = "0x224E340")]
	private void _Init()
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x224E5E0", Offset = "0x224E5E0", VA = "0x224E5E0")]
	private void RealReset()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x224E608", Offset = "0x224E608", VA = "0x224E608")]
	private void UpdateResetDelay(float rate)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x224E380", Offset = "0x224E380", VA = "0x224E380")]
	private void _UpdateW(float deltaSpeed, bool bSlowUp = false)
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2247438", Offset = "0x2247438", VA = "0x2247438")]
	public void Reset()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x22474BC", Offset = "0x22474BC", VA = "0x22474BC")]
	public void ResetFakeDisable()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x2246D64", Offset = "0x2246D64", VA = "0x2246D64")]
	public void TurnPosW(float value)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2246E0C", Offset = "0x2246E0C", VA = "0x2246E0C")]
	public void TurnRotW(float value)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x2246EC4", Offset = "0x2246EC4", VA = "0x2246EC4")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA7F8", Offset = "0x12BA7F8")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000126")]
	[FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA810", Offset = "0x12BA810")]
	public float fPosW;

	[Token(Token = "0x4000127")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA828", Offset = "0x12BA828")]
	public float fLastPosW;

	[Token(Token = "0x4000128")]
	[FieldOffset(Offset = "0x24")]
	private bool bTurnedPos;

	[Token(Token = "0x4000129")]
	[FieldOffset(Offset = "0x28")]
	private float fCurrentPosW;

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x26C0418", Offset = "0x26C0418", VA = "0x26C0418")]
	public void Init(Animator animator)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x26C044C", Offset = "0x26C044C", VA = "0x26C044C")]
	public void UpdateW(float deltaSpeed, Vector3 pos)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x26C05B4", Offset = "0x26C05B4", VA = "0x26C05B4")]
	public void Init(IKSolverVR.Spine IKSolverVR)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x26C05D0", Offset = "0x26C05D0", VA = "0x26C05D0")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x26C0434", Offset = "0x26C0434", VA = "0x26C0434")]
	private void _Init()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x26C0540", Offset = "0x26C0540", VA = "0x26C0540")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x26C060C", Offset = "0x26C060C", VA = "0x26C060C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x26C061C", Offset = "0x26C061C", VA = "0x26C061C")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA840", Offset = "0x12BA840")]
	public float fMaxThresholdW;

	[Token(Token = "0x400012C")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA858", Offset = "0x12BA858")]
	public float fWeight;

	[Token(Token = "0x400012D")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA870", Offset = "0x12BA870")]
	public float fLastWeight;

	[Token(Token = "0x400012E")]
	[FieldOffset(Offset = "0x14")]
	private float fCurrentW;

	[Token(Token = "0x400012F")]
	[FieldOffset(Offset = "0x18")]
	private bool bTurned;

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x26C11B4", Offset = "0x26C11B4", VA = "0x26C11B4")]
	public void Init(IKSolver ik)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x26C11E0", Offset = "0x26C11E0", VA = "0x26C11E0")]
	public void UpdateW(float deltaSpeed, VRIK VRIK)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x26C11CC", Offset = "0x26C11CC", VA = "0x26C11CC")]
	private void _Init()
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x26C121C", Offset = "0x26C121C", VA = "0x26C121C")]
	private void _UpdateW(float deltaSpeed)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x26C1290", Offset = "0x26C1290", VA = "0x26C1290")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x26C12A0", Offset = "0x26C12A0", VA = "0x26C12A0")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA888", Offset = "0x12BA888")]
	public float fMaxThresholdW;

	[Token(Token = "0x4000132")]
	[FieldOffset(Offset = "0xC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA8A0", Offset = "0x12BA8A0")]
	public float fWeight;

	[Token(Token = "0x4000133")]
	[FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x12BA8B8", Offset = "0x12BA8B8")]
	public float fLastWeight;

	[Token(Token = "0x4000134")]
	[FieldOffset(Offset = "0x14")]
	private float fCurrentW;

	[Token(Token = "0x4000135")]
	[FieldOffset(Offset = "0x18")]
	private bool bTurned;

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x26C12B4", Offset = "0x26C12B4", VA = "0x26C12B4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x26C12C4", Offset = "0x26C12C4", VA = "0x26C12C4")]
	public void TurnOn(float value)
	{
	}
}
