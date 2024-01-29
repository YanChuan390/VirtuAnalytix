using System.Collections;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Cameras;

[Token(Token = "0x2000002")]
public abstract class AbstractTargetFollower : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	public enum UpdateType
	{
		[Token(Token = "0x4000034")]
		FixedUpdate,
		[Token(Token = "0x4000035")]
		LateUpdate,
		[Token(Token = "0x4000036")]
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
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1AED020", Offset = "0x1AED020", VA = "0x1AED020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1AECBE8", Offset = "0x1AECBE8", VA = "0x1AECBE8", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x1AECD58", Offset = "0x1AECD58", VA = "0x1AECD58")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1AECE40", Offset = "0x1AECE40", VA = "0x1AECE40")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1AECF2C", Offset = "0x1AECF2C", VA = "0x1AECF2C")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	protected abstract void FollowTarget(float deltaTime);

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1AECC98", Offset = "0x1AECC98", VA = "0x1AECC98")]
	public void FindAndTargetPlayer()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1AED018", Offset = "0x1AED018", VA = "0x1AED018", Slot = "6")]
	public virtual void SetTarget(Transform newTransform)
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1AED028", Offset = "0x1AED028", VA = "0x1AED028")]
	protected AbstractTargetFollower()
	{
	}
}
[Token(Token = "0x2000003")]
[ExecuteInEditMode]
public class AutoCam : PivotBasedCameraRig
{
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float m_MoveSpeed;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private float m_TurnSpeed;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	private float m_RollSpeed;

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool m_FollowVelocity;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	private bool m_FollowTilt;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private float m_SpinTurnLimit;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float m_TargetVelocityLowerLimit;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_SmoothTurnTime;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x68")]
	private float m_LastFlatAngle;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x6C")]
	private float m_CurrentTurnAmount;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x70")]
	private float m_TurnSpeedVelocityChange;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_RollUp;

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1AED038", Offset = "0x1AED038", VA = "0x1AED038", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1AED650", Offset = "0x1AED650", VA = "0x1AED650")]
	public AutoCam()
	{
	}
}
[Token(Token = "0x2000004")]
public class HandHeldCam : LookatTarget
{
	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float m_SwaySpeed;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float m_BaseSwayAmount;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float m_TrackingSwayAmount;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x70")]
	[Attribute(Name = "RangeAttribute", RVA = "0x871CC8", Offset = "0x871CC8")]
	[SerializeField]
	private float m_TrackingBias;

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1AED70C", Offset = "0x1AED70C", VA = "0x1AED70C", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1AEDC54", Offset = "0x1AEDC54", VA = "0x1AEDC54")]
	public HandHeldCam()
	{
	}
}
[Token(Token = "0x2000005")]
public class LookatTarget : AbstractTargetFollower
{
	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 m_RotationRange;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float m_FollowSpeed;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_FollowAngles;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x48")]
	private Quaternion m_OriginalRotation;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x58")]
	protected Vector3 m_FollowVelocity;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1AEDC90", Offset = "0x1AEDC90", VA = "0x1AEDC90", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1AED880", Offset = "0x1AED880", VA = "0x1AED880", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1AEDC78", Offset = "0x1AEDC78", VA = "0x1AEDC78")]
	public LookatTarget()
	{
	}
}
[Token(Token = "0x2000006")]
public abstract class PivotBasedCameraRig : AbstractTargetFollower
{
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x30")]
	protected Transform m_Cam;

	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x38")]
	protected Transform m_Pivot;

	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x40")]
	protected Vector3 m_LastTargetPosition;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1AEDCDC", Offset = "0x1AEDCDC", VA = "0x1AEDCDC", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1AED6FC", Offset = "0x1AED6FC", VA = "0x1AED6FC")]
	protected PivotBasedCameraRig()
	{
	}
}
[Token(Token = "0x2000007")]
public class ProtectCameraFromWallClip : MonoBehaviour
{
	[Token(Token = "0x200000A")]
	public class RayHitComparer : IComparer
	{
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1AEE720", Offset = "0x1AEE720", VA = "0x1AEE720", Slot = "4")]
		public int Compare(object x, object y)
		{
			return default(int);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1AEDE70", Offset = "0x1AEDE70", VA = "0x1AEDE70")]
		public RayHitComparer()
		{
		}
	}

	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x18")]
	public float clipMoveTime;

	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x1C")]
	public float returnTime;

	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x20")]
	public float sphereCastRadius;

	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x24")]
	public bool visualiseInEditor;

	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x28")]
	public float closestDistance;

	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x871D28", Offset = "0x871D28")]
	private bool <protecting>k__BackingField;

	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x30")]
	public string dontClipTag;

	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_Cam;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_Pivot;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x48")]
	private float m_OriginalDist;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x4C")]
	private float m_MoveVelocity;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentDist;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x54")]
	private Ray m_Ray;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x70")]
	private RaycastHit[] m_Hits;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x78")]
	private RayHitComparer m_RayHitComparer;

	[Token(Token = "0x17000002")]
	public bool protecting
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1AEDD68", Offset = "0x1AEDD68", VA = "0x1AEDD68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x871D68", Offset = "0x871D68")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1AEDD70", Offset = "0x1AEDD70", VA = "0x1AEDD70")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x871D78", Offset = "0x871D78")]
		private set
		{
		}
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1AEDD7C", Offset = "0x1AEDD7C", VA = "0x1AEDD7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1AEDE78", Offset = "0x1AEDE78", VA = "0x1AEDE78")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1AEE6A0", Offset = "0x1AEE6A0", VA = "0x1AEE6A0")]
	public ProtectCameraFromWallClip()
	{
	}
}
[Token(Token = "0x2000008")]
public class TargetFieldOfView : AbstractTargetFollower
{
	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float m_FovAdjustTime;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float m_ZoomAmountMultiplier;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_IncludeEffectsInSize;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x3C")]
	private float m_BoundSize;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x40")]
	private float m_FovAdjustVelocity;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x48")]
	private Camera m_Cam;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_LastTarget;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1AEE8D4", Offset = "0x1AEE8D4", VA = "0x1AEE8D4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x1AEEB98", Offset = "0x1AEEB98", VA = "0x1AEEB98", Slot = "5")]
	protected override void FollowTarget(float deltaTime)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x1AEED44", Offset = "0x1AEED44", VA = "0x1AEED44", Slot = "6")]
	public override void SetTarget(Transform newTransform)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1AEE944", Offset = "0x1AEE944", VA = "0x1AEE944")]
	public static float MaxBoundsExtent(Transform obj, bool includeEffects)
	{
		return default(float);
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1AEED74", Offset = "0x1AEED74", VA = "0x1AEED74")]
	public TargetFieldOfView()
	{
	}
}
