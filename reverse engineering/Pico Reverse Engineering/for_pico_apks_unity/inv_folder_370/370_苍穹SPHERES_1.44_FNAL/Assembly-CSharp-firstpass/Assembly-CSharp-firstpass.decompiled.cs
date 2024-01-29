using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Cameras;

[Token(Token = "0x2000002")]
public abstract class AbstractTargetFollower : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	public enum UpdateType
	{
		[Token(Token = "0x4000006")]
		FixedUpdate,
		[Token(Token = "0x4000007")]
		LateUpdate,
		[Token(Token = "0x4000008")]
		ManualUpdate
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected Transform m_Target;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool m_AutoTargetPlayer;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private UpdateType m_UpdateType;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x28")]
	protected Rigidbody targetRigidbody;

	[Token(Token = "0x17000001")]
	public Transform Target
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1669524", Offset = "0x1669524", VA = "0x1669524")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x16690DC", Offset = "0x16690DC", VA = "0x16690DC")]
	protected AbstractTargetFollower()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x16690EC", Offset = "0x16690EC", VA = "0x16690EC", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x166925C", Offset = "0x166925C", VA = "0x166925C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1669344", Offset = "0x1669344", VA = "0x1669344")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1669430", Offset = "0x1669430", VA = "0x1669430")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	protected abstract void FollowTarget(float deltaTime);

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x166919C", Offset = "0x166919C", VA = "0x166919C")]
	public void FindAndTargetPlayer()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x166951C", Offset = "0x166951C", VA = "0x166951C", Slot = "6")]
	public virtual void SetTarget(Transform newTransform)
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class AutoCam : PivotBasedCameraRig
{
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float m_MoveSpeed;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float m_TurnSpeed;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float m_RollSpeed;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool m_FollowVelocity;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	private bool m_FollowTilt;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float m_SpinTurnLimit;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float m_TargetVelocityLowerLimit;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_SmoothTurnTime;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x68")]
	private float m_LastFlatAngle;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x6C")]
	private float m_CurrentTurnAmount;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x70")]
	private float m_TurnSpeedVelocityChange;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_RollUp;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x166952C", Offset = "0x166952C", VA = "0x166952C")]
	public AutoCam()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x16695E8", Offset = "0x16695E8", VA = "0x16695E8", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}
}
[Token(Token = "0x2000005")]
public class HandHeldCam : LookatTarget
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_SwaySpeed;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float m_BaseSwayAmount;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_TrackingSwayAmount;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "RangeAttribute", RVA = "0x673614", Offset = "0x673614")]
	[SerializeField]
	private float m_TrackingBias;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1669C08", Offset = "0x1669C08", VA = "0x1669C08")]
	public HandHeldCam()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1669C44", Offset = "0x1669C44", VA = "0x1669C44", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}
}
[Token(Token = "0x2000006")]
public class LookatTarget : AbstractTargetFollower
{
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 m_RotationRange;

	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_FollowSpeed;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_FollowAngles;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion m_OriginalRotation;

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 m_FollowVelocity;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1669C2C", Offset = "0x1669C2C", VA = "0x1669C2C")]
	public LookatTarget()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x166A18C", Offset = "0x166A18C", VA = "0x166A18C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1669DB8", Offset = "0x1669DB8", VA = "0x1669DB8", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}
}
[Token(Token = "0x2000007")]
public abstract class PivotBasedCameraRig : AbstractTargetFollower
{
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x30")]
	protected Transform m_Cam;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x38")]
	protected Transform m_Pivot;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 m_LastTargetPosition;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x16695D8", Offset = "0x16695D8", VA = "0x16695D8")]
	protected PivotBasedCameraRig()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x166A1D8", Offset = "0x166A1D8", VA = "0x166A1D8", Slot = "7")]
	protected virtual void Awake()
	{
	}
}
[Token(Token = "0x2000008")]
public class ProtectCameraFromWallClip : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public class RayHitComparer : IComparer
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x166A3F8", Offset = "0x166A3F8", VA = "0x166A3F8")]
		public RayHitComparer()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x166AC28", Offset = "0x166AC28", VA = "0x166AC28", Slot = "4")]
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x18")]
	public float clipMoveTime;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x1C")]
	public float returnTime;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x20")]
	public float sphereCastRadius;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x24")]
	public bool visualiseInEditor;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x28")]
	public float closestDistance;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x673674", Offset = "0x673674")]
	[Attribute(Name = "DebuggerBrowsableAttribute", RVA = "0x673674", Offset = "0x673674")]
	private bool <protecting>k__BackingField;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	public string dontClipTag;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_Cam;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_Pivot;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x48")]
	private float m_OriginalDist;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x4C")]
	private float m_MoveVelocity;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentDist;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x54")]
	private Ray m_Ray;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x70")]
	private RaycastHit[] m_Hits;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x78")]
	private RayHitComparer m_RayHitComparer;

	[Token(Token = "0x17000002")]
	public bool protecting
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x166A2F0", Offset = "0x166A2F0", VA = "0x166A2F0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6736E0", Offset = "0x6736E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x166A2F8", Offset = "0x166A2F8", VA = "0x166A2F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6736F0", Offset = "0x6736F0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x166A264", Offset = "0x166A264", VA = "0x166A264")]
	public ProtectCameraFromWallClip()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x166A304", Offset = "0x166A304", VA = "0x166A304")]
	private void Start()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x166A400", Offset = "0x166A400", VA = "0x166A400")]
	private void LateUpdate()
	{
	}
}
[Token(Token = "0x200000A")]
public class TargetFieldOfView : AbstractTargetFollower
{
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_FovAdjustTime;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_ZoomAmountMultiplier;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IncludeEffectsInSize;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x3C")]
	private float m_BoundSize;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x40")]
	private float m_FovAdjustVelocity;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x48")]
	private Camera m_Cam;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_LastTarget;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x166ADE4", Offset = "0x166ADE4", VA = "0x166ADE4")]
	public TargetFieldOfView()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x166AE00", Offset = "0x166AE00", VA = "0x166AE00", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x166B0C4", Offset = "0x166B0C4", VA = "0x166B0C4", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x166B270", Offset = "0x166B270", VA = "0x166B270", Slot = "6")]
	public override void SetTarget(Transform newTransform)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x166AE70", Offset = "0x166AE70", VA = "0x166AE70")]
	public static float MaxBoundsExtent(Transform obj, bool includeEffects)
	{
		return default(float);
	}
}
