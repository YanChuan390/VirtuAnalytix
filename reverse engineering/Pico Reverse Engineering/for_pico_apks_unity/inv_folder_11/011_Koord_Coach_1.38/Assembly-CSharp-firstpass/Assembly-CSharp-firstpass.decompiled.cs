using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[assembly: AssemblyVersion("0.0.0.0")]
namespace BezierSolution;

[Token(Token = "0x2000002")]
public class BezierPoint : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public struct ExtraData
	{
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x0")]
		public float c1;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x4")]
		public float c2;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		public float c3;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0xC")]
		public float c4;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x14504A8", Offset = "0x14504A8", VA = "0x14504A8")]
		public ExtraData(float c1 = 0f, float c2 = 0f, float c3 = 0f, float c4 = 0f)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x14504B4", Offset = "0x14504B4", VA = "0x14504B4")]
		public static ExtraData Lerp(ExtraData a, ExtraData b, float t)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1450544", Offset = "0x1450544", VA = "0x1450544")]
		public static ExtraData LerpUnclamped(ExtraData a, ExtraData b, float t)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x145057C", Offset = "0x145057C", VA = "0x145057C")]
		public static implicit operator ExtraData(Vector2 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1450588", Offset = "0x1450588", VA = "0x1450588")]
		public static implicit operator ExtraData(Vector3 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1450590", Offset = "0x1450590", VA = "0x1450590")]
		public static implicit operator ExtraData(Vector4 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x144E9F8", Offset = "0x144E9F8", VA = "0x144E9F8")]
		public static implicit operator ExtraData(Quaternion q)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1450594", Offset = "0x1450594", VA = "0x1450594")]
		public static implicit operator ExtraData(Rect r)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1450610", Offset = "0x1450610", VA = "0x1450610")]
		public static implicit operator ExtraData(Vector2Int v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1450628", Offset = "0x1450628", VA = "0x1450628")]
		public static implicit operator ExtraData(Vector3Int v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x145068C", Offset = "0x145068C", VA = "0x145068C")]
		public static implicit operator ExtraData(RectInt r)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1450704", Offset = "0x1450704", VA = "0x1450704")]
		public static implicit operator Vector2(ExtraData v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1450708", Offset = "0x1450708", VA = "0x1450708")]
		public static implicit operator Vector3(ExtraData v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x145070C", Offset = "0x145070C", VA = "0x145070C")]
		public static implicit operator Vector4(ExtraData v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x144E9C8", Offset = "0x144E9C8", VA = "0x144E9C8")]
		public static implicit operator Quaternion(ExtraData v)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x145073C", Offset = "0x145073C", VA = "0x145073C")]
		public static implicit operator Rect(ExtraData v)
		{
			return default(Rect);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x145076C", Offset = "0x145076C", VA = "0x145076C")]
		public static implicit operator Vector2Int(ExtraData v)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x14507B4", Offset = "0x14507B4", VA = "0x14507B4")]
		public static implicit operator Vector3Int(ExtraData v)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1450814", Offset = "0x1450814", VA = "0x1450814")]
		public static implicit operator RectInt(ExtraData v)
		{
			return default(RectInt);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x14508B4", Offset = "0x14508B4", VA = "0x14508B4")]
		public static bool operator ==(ExtraData d1, ExtraData d2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x14508E4", Offset = "0x14508E4", VA = "0x14508E4")]
		public static bool operator !=(ExtraData d1, ExtraData d2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1450914", Offset = "0x1450914", VA = "0x1450914", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x14509D8", Offset = "0x14509D8", VA = "0x14509D8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1450A28", Offset = "0x1450A28", VA = "0x1450A28", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x2000004")]
	public enum HandleMode
	{
		[Token(Token = "0x400000D")]
		Free,
		[Token(Token = "0x400000E")]
		Aligned,
		[Token(Token = "0x400000F")]
		Mirrored
	}

	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[HideInInspector]
	private Vector3 m_position;

	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	[HideInInspector]
	private Vector3 m_precedingControlPointLocalPosition;

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x30")]
	[HideInInspector]
	[SerializeField]
	private Vector3 m_precedingControlPointPosition;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[HideInInspector]
	private Vector3 m_followingControlPointLocalPosition;

	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private Vector3 m_followingControlPointPosition;

	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x54")]
	[SerializeField]
	[HideInInspector]
	private HandleMode m_handleMode;

	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public ExtraData extraData;

	[Token(Token = "0x17000001")]
	public Vector3 localPosition
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1449D94", Offset = "0x1449D94", VA = "0x1449D94")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1449DB8", Offset = "0x1449DB8", VA = "0x1449DB8")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Vector3 position
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1449E04", Offset = "0x1449E04", VA = "0x1449E04")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1449EF0", Offset = "0x1449EF0", VA = "0x1449EF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public Quaternion localRotation
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1449F3C", Offset = "0x1449F3C", VA = "0x1449F3C")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1449F60", Offset = "0x1449F60", VA = "0x1449F60")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public Quaternion rotation
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x1449FB4", Offset = "0x1449FB4", VA = "0x1449FB4")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1449FD8", Offset = "0x1449FD8", VA = "0x1449FD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Vector3 localEulerAngles
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x144A02C", Offset = "0x144A02C", VA = "0x144A02C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x144A050", Offset = "0x144A050", VA = "0x144A050")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 eulerAngles
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x144A09C", Offset = "0x144A09C", VA = "0x144A09C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x144A0C0", Offset = "0x144A0C0", VA = "0x144A0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 localScale
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x144A10C", Offset = "0x144A10C", VA = "0x144A10C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x144A130", Offset = "0x144A130", VA = "0x144A130")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 precedingControlPointLocalPosition
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x144A17C", Offset = "0x144A17C", VA = "0x144A17C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x144A188", Offset = "0x144A188", VA = "0x144A188")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 precedingControlPointPosition
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x144A28C", Offset = "0x144A28C", VA = "0x144A28C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x144A2D4", Offset = "0x144A2D4", VA = "0x144A2D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 followingControlPointLocalPosition
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x144A48C", Offset = "0x144A48C", VA = "0x144A48C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x144A498", Offset = "0x144A498", VA = "0x144A498")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector3 followingControlPointPosition
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x144A59C", Offset = "0x144A59C", VA = "0x144A59C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x144A5E4", Offset = "0x144A5E4", VA = "0x144A5E4")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public HandleMode handleMode
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x144A79C", Offset = "0x144A79C", VA = "0x144A79C")]
		get
		{
			return default(HandleMode);
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x144A7A4", Offset = "0x144A7A4", VA = "0x144A7A4")]
		set
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x144A7C4", Offset = "0x144A7C4", VA = "0x144A7C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x144A7EC", Offset = "0x144A7EC", VA = "0x144A7EC")]
	public void CopyTo(BezierPoint other)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x1449E4C", Offset = "0x1449E4C", VA = "0x1449E4C")]
	private void Revalidate()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x144A8EC", Offset = "0x144A8EC", VA = "0x144A8EC")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x607A60", Offset = "0x607A60")]
	private void SetSplineDirty()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x144A8F0", Offset = "0x144A8F0", VA = "0x144A8F0")]
	public void Reset()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x144A978", Offset = "0x144A978", VA = "0x144A978")]
	public BezierPoint()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x607740", Offset = "0x607740")]
[ExecuteInEditMode]
public class BezierSpline : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	public struct PointIndexTuple
	{
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x0")]
		public readonly int index1;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x4")]
		public readonly int index2;

		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x8")]
		public readonly float t;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x144CE60", Offset = "0x144CE60", VA = "0x144CE60")]
		public PointIndexTuple(int index1, int index2, float t)
		{
		}
	}

	[Token(Token = "0x2000007")]
	public delegate BezierPoint.ExtraData ExtraDataLerpFunction(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT);

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ExtraDataLerpFunction defaultExtraDataLerpFunction;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x8")]
	private static Material gizmoMaterial;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x18")]
	private List<BezierPoint> endPoints;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x20")]
	public bool loop;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x21")]
	public bool drawGizmos;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x24")]
	public Color gizmoColor;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x34")]
	private float gizmoStep;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int m_gizmoSmoothness;

	[Token(Token = "0x1700000D")]
	public int gizmoSmoothness
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x144A9C4", Offset = "0x144A9C4", VA = "0x144A9C4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x144A9CC", Offset = "0x144A9CC", VA = "0x144A9CC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public int Count
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x144AA50", Offset = "0x144AA50", VA = "0x144AA50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000F")]
	public float Length
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x144AA9C", Offset = "0x144AA9C", VA = "0x144AA9C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000010")]
	public BezierPoint Item
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x144AC00", Offset = "0x144AC00", VA = "0x144AC00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x144AD40", Offset = "0x144AD40", VA = "0x144AD40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x144ADC8", Offset = "0x144ADC8", VA = "0x144ADC8")]
	public void Initialize(int endPointsCount)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x144AD44", Offset = "0x144AD44", VA = "0x144AD44")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x144AFB0", Offset = "0x144AFB0", VA = "0x144AFB0")]
	public BezierPoint InsertNewPointAt(int index)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x144B414", Offset = "0x144B414", VA = "0x144B414")]
	public BezierPoint DuplicatePointAt(int index)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x144B6F0", Offset = "0x144B6F0", VA = "0x144B6F0")]
	public void RemovePointAt(int index)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x144BA68", Offset = "0x144BA68", VA = "0x144BA68")]
	public void SwapPointsAt(int index1, int index2)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x144BD80", Offset = "0x144BD80", VA = "0x144BD80")]
	public void MovePoint(int previousIndex, int newIndex)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x144BD84", Offset = "0x144BD84", VA = "0x144BD84")]
	public void Internal_MovePoint(int previousIndex, int newIndex, string undo)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x144C15C", Offset = "0x144C15C", VA = "0x144C15C")]
	public int IndexOf(BezierPoint point)
	{
		return default(int);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x144C1C0", Offset = "0x144C1C0", VA = "0x144C1C0")]
	public Vector3 GetPoint(float normalizedT)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x144C424", Offset = "0x144C424", VA = "0x144C424")]
	public Vector3 GetTangent(float normalizedT)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x144C75C", Offset = "0x144C75C", VA = "0x144C75C")]
	public BezierPoint.ExtraData GetExtraData(float normalizedT)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x144C7D8", Offset = "0x144C7D8", VA = "0x144C7D8")]
	public BezierPoint.ExtraData GetExtraData(float normalizedT, ExtraDataLerpFunction lerpFunction)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x144AAB0", Offset = "0x144AAB0", VA = "0x144AAB0")]
	public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
	{
		return default(float);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x144CD54", Offset = "0x144CD54", VA = "0x144CD54")]
	public PointIndexTuple GetNearestPointIndicesTo(float normalizedT)
	{
		return default(PointIndexTuple);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x144CE6C", Offset = "0x144CE6C", VA = "0x144CE6C")]
	public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x144CE90", Offset = "0x144CE90", VA = "0x144CE90")]
	public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x144CFB4", Offset = "0x144CFB4", VA = "0x144CFB4")]
	public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x144D090", Offset = "0x144D090", VA = "0x144D090")]
	public void ConstructLinearPath()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x144D334", Offset = "0x144D334", VA = "0x144D334")]
	public void AutoConstructSpline()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x144DD74", Offset = "0x144DD74", VA = "0x144DD74")]
	private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x144DF90", Offset = "0x144DF90", VA = "0x144DF90")]
	public void AutoConstructSpline2()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x144CD20", Offset = "0x144CD20", VA = "0x144CD20")]
	private float AccuracyToStepSize(float accuracy)
	{
		return default(float);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x144E46C", Offset = "0x144E46C", VA = "0x144E46C")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x144E7D4", Offset = "0x144E7D4", VA = "0x144E7D4")]
	public BezierSpline()
	{
	}
}
[Token(Token = "0x2000008")]
public enum TravelMode
{
	[Token(Token = "0x400001C")]
	Once,
	[Token(Token = "0x400001D")]
	Loop,
	[Token(Token = "0x400001E")]
	PingPong
}
[Token(Token = "0x2000009")]
public enum LookAtMode
{
	[Token(Token = "0x4000020")]
	None,
	[Token(Token = "0x4000021")]
	Forward,
	[Token(Token = "0x4000022")]
	SplineExtraData
}
[Token(Token = "0x200000A")]
public abstract class BezierWalker : MonoBehaviour
{
	[Token(Token = "0x4000023")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly BezierSpline.ExtraDataLerpFunction extraDataLerpAsQuaternionFunction;

	[Token(Token = "0x17000011")]
	public abstract BezierSpline Spline
	{
		[Token(Token = "0x600005C")]
		get;
	}

	[Token(Token = "0x17000012")]
	public abstract bool MovingForward
	{
		[Token(Token = "0x600005D")]
		get;
	}

	[Token(Token = "0x17000013")]
	public abstract float NormalizedT
	{
		[Token(Token = "0x600005E")]
		get;
		[Token(Token = "0x600005F")]
		set;
	}

	[Token(Token = "0x6000060")]
	public abstract void Execute(float deltaTime);

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x144E92C", Offset = "0x144E92C", VA = "0x144E92C")]
	private static BezierPoint.ExtraData InterpolateExtraDataAsQuaternion(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x144E9FC", Offset = "0x144E9FC", VA = "0x144E9FC")]
	protected BezierWalker()
	{
	}
}
[Token(Token = "0x200000B")]
public class BezierWalkerLocomotion : BezierWalker
{
	[Token(Token = "0x4000024")]
	[FieldOffset(Offset = "0x18")]
	public BezierWalker walker;

	[Token(Token = "0x4000025")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> tailObjects;

	[Token(Token = "0x4000026")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<float> tailObjectDistances;

	[Token(Token = "0x4000027")]
	[FieldOffset(Offset = "0x30")]
	public float movementLerpModifier;

	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x34")]
	public float rotationLerpModifier;

	[NonSerialized]
	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x60792C", Offset = "0x60792C")]
	public bool lookForward;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	public LookAtMode lookAt;

	[Token(Token = "0x17000014")]
	public List<Transform> Tail
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x144EAA4", Offset = "0x144EAA4", VA = "0x144EAA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public List<float> TailDistances
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x144EAAC", Offset = "0x144EAAC", VA = "0x144EAAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public override BezierSpline Spline
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x144EAB4", Offset = "0x144EAB4", VA = "0x144EAB4", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public override bool MovingForward
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x144EAD4", Offset = "0x144EAD4", VA = "0x144EAD4", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x144EAF4", Offset = "0x144EAF4", VA = "0x144EAF4", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x144EB14", Offset = "0x144EB14", VA = "0x144EB14", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x144EB34", Offset = "0x144EB34", VA = "0x144EB34")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x144ECC8", Offset = "0x144ECC8", VA = "0x144ECC8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x144ECF8", Offset = "0x144ECF8", VA = "0x144ECF8", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x144F054", Offset = "0x144F054", VA = "0x144F054")]
	public void AddToTail(Transform transform, float distanceToPreviousObject)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x144F188", Offset = "0x144F188", VA = "0x144F188")]
	public void InsertIntoTail(int index, Transform transform, float distanceToPreviousObject)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x144F2C8", Offset = "0x144F2C8", VA = "0x144F2C8")]
	public void RemoveFromTail(Transform transform)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x144F494", Offset = "0x144F494", VA = "0x144F494")]
	public BezierWalkerLocomotion()
	{
	}
}
[Token(Token = "0x200000C")]
public class BezierWalkerWithSpeed : BezierWalker
{
	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	public BezierSpline spline;

	[Token(Token = "0x400002C")]
	[FieldOffset(Offset = "0x20")]
	public TravelMode travelMode;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x607968", Offset = "0x607968")]
	private float m_normalizedT;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x2C")]
	public float rotationLerpModifier;

	[NonSerialized]
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x6079A8", Offset = "0x6079A8")]
	public bool lookForward;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x34")]
	public LookAtMode lookAt;

	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x38")]
	private bool isGoingForward;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent onPathCompleted;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x48")]
	private bool onPathCompletedCalledAt1;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x49")]
	private bool onPathCompletedCalledAt0;

	[Token(Token = "0x17000019")]
	public override BezierSpline Spline
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x144F50C", Offset = "0x144F50C", VA = "0x144F50C", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x144F514", Offset = "0x144F514", VA = "0x144F514", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x144F51C", Offset = "0x144F51C", VA = "0x144F51C", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public override bool MovingForward
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x144F524", Offset = "0x144F524", VA = "0x144F524", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x144F544", Offset = "0x144F544", VA = "0x144F544")]
	private void Update()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x144F574", Offset = "0x144F574", VA = "0x144F574", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x144F8B8", Offset = "0x144F8B8", VA = "0x144F8B8")]
	public BezierWalkerWithSpeed()
	{
	}
}
[Token(Token = "0x200000D")]
public class BezierWalkerWithTime : BezierWalker
{
	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x18")]
	public BezierSpline spline;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x20")]
	public TravelMode travelMode;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x24")]
	public float travelTime;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x6079E4", Offset = "0x6079E4")]
	private float m_normalizedT;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x2C")]
	public float movementLerpModifier;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x30")]
	public float rotationLerpModifier;

	[NonSerialized]
	[Token(Token = "0x400003C")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x607A24", Offset = "0x607A24")]
	public bool lookForward;

	[Token(Token = "0x400003D")]
	[FieldOffset(Offset = "0x38")]
	public LookAtMode lookAt;

	[Token(Token = "0x400003E")]
	[FieldOffset(Offset = "0x3C")]
	private bool isGoingForward;

	[Token(Token = "0x400003F")]
	[FieldOffset(Offset = "0x40")]
	public UnityEvent onPathCompleted;

	[Token(Token = "0x4000040")]
	[FieldOffset(Offset = "0x48")]
	private bool onPathCompletedCalledAt1;

	[Token(Token = "0x4000041")]
	[FieldOffset(Offset = "0x49")]
	private bool onPathCompletedCalledAt0;

	[Token(Token = "0x1700001C")]
	public override BezierSpline Spline
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x144F974", Offset = "0x144F974", VA = "0x144F974", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x144F97C", Offset = "0x144F97C", VA = "0x144F97C", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x144F984", Offset = "0x144F984", VA = "0x144F984", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public override bool MovingForward
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x144F98C", Offset = "0x144F98C", VA = "0x144F98C", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x144F994", Offset = "0x144F994", VA = "0x144F994")]
	private void Update()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x144F9C4", Offset = "0x144F9C4", VA = "0x144F9C4", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x144FD38", Offset = "0x144FD38", VA = "0x144FD38")]
	public BezierWalkerWithTime()
	{
	}
}
[Token(Token = "0x200000E")]
[ExecuteInEditMode]
public class ParticlesFollowBezier : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	public enum FollowMode
	{
		[Token(Token = "0x400004B")]
		Relaxed,
		[Token(Token = "0x400004C")]
		Strict
	}

	[Token(Token = "0x4000042")]
	private const int MAX_PARTICLE_COUNT = 25000;

	[Token(Token = "0x4000043")]
	[FieldOffset(Offset = "0x18")]
	public BezierSpline spline;

	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x20")]
	public FollowMode followMode;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x28")]
	private Transform cachedTransform;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x30")]
	private ParticleSystem cachedPS;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem.MainModule cachedMainModule;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector4> particleData;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x144FDF4", Offset = "0x144FDF4", VA = "0x144FDF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x144FF50", Offset = "0x144FF50", VA = "0x144FF50")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x14504A0", Offset = "0x14504A0", VA = "0x14504A0")]
	public ParticlesFollowBezier()
	{
	}
}
