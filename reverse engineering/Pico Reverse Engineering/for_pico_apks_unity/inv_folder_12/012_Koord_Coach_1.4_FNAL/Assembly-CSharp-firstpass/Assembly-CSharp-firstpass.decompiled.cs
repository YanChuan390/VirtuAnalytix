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
		[Address(RVA = "0x1532954", Offset = "0x1532954", VA = "0x1532954")]
		public ExtraData(float c1 = 0f, float c2 = 0f, float c3 = 0f, float c4 = 0f)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1532960", Offset = "0x1532960", VA = "0x1532960")]
		public static ExtraData Lerp(ExtraData a, ExtraData b, float t)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x15329F0", Offset = "0x15329F0", VA = "0x15329F0")]
		public static ExtraData LerpUnclamped(ExtraData a, ExtraData b, float t)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1532A28", Offset = "0x1532A28", VA = "0x1532A28")]
		public static implicit operator ExtraData(Vector2 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1532A34", Offset = "0x1532A34", VA = "0x1532A34")]
		public static implicit operator ExtraData(Vector3 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1532A3C", Offset = "0x1532A3C", VA = "0x1532A3C")]
		public static implicit operator ExtraData(Vector4 v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1530EA4", Offset = "0x1530EA4", VA = "0x1530EA4")]
		public static implicit operator ExtraData(Quaternion q)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1532A40", Offset = "0x1532A40", VA = "0x1532A40")]
		public static implicit operator ExtraData(Rect r)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1532ABC", Offset = "0x1532ABC", VA = "0x1532ABC")]
		public static implicit operator ExtraData(Vector2Int v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1532AD4", Offset = "0x1532AD4", VA = "0x1532AD4")]
		public static implicit operator ExtraData(Vector3Int v)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1532B38", Offset = "0x1532B38", VA = "0x1532B38")]
		public static implicit operator ExtraData(RectInt r)
		{
			return default(ExtraData);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1532BB0", Offset = "0x1532BB0", VA = "0x1532BB0")]
		public static implicit operator Vector2(ExtraData v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1532BB4", Offset = "0x1532BB4", VA = "0x1532BB4")]
		public static implicit operator Vector3(ExtraData v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1532BB8", Offset = "0x1532BB8", VA = "0x1532BB8")]
		public static implicit operator Vector4(ExtraData v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1530E74", Offset = "0x1530E74", VA = "0x1530E74")]
		public static implicit operator Quaternion(ExtraData v)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1532BE8", Offset = "0x1532BE8", VA = "0x1532BE8")]
		public static implicit operator Rect(ExtraData v)
		{
			return default(Rect);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1532C18", Offset = "0x1532C18", VA = "0x1532C18")]
		public static implicit operator Vector2Int(ExtraData v)
		{
			return default(Vector2Int);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1532C60", Offset = "0x1532C60", VA = "0x1532C60")]
		public static implicit operator Vector3Int(ExtraData v)
		{
			return default(Vector3Int);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1532CC0", Offset = "0x1532CC0", VA = "0x1532CC0")]
		public static implicit operator RectInt(ExtraData v)
		{
			return default(RectInt);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1532D60", Offset = "0x1532D60", VA = "0x1532D60")]
		public static bool operator ==(ExtraData d1, ExtraData d2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1532D90", Offset = "0x1532D90", VA = "0x1532D90")]
		public static bool operator !=(ExtraData d1, ExtraData d2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1532DC0", Offset = "0x1532DC0", VA = "0x1532DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1532E84", Offset = "0x1532E84", VA = "0x1532E84", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1532ED4", Offset = "0x1532ED4", VA = "0x1532ED4", Slot = "3")]
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
		[Address(RVA = "0x152C240", Offset = "0x152C240", VA = "0x152C240")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x152C264", Offset = "0x152C264", VA = "0x152C264")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public Vector3 position
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x152C2B0", Offset = "0x152C2B0", VA = "0x152C2B0")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x152C39C", Offset = "0x152C39C", VA = "0x152C39C")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public Quaternion localRotation
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x152C3E8", Offset = "0x152C3E8", VA = "0x152C3E8")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x152C40C", Offset = "0x152C40C", VA = "0x152C40C")]
		set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public Quaternion rotation
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x152C460", Offset = "0x152C460", VA = "0x152C460")]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x152C484", Offset = "0x152C484", VA = "0x152C484")]
		set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public Vector3 localEulerAngles
	{
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x152C4D8", Offset = "0x152C4D8", VA = "0x152C4D8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x152C4FC", Offset = "0x152C4FC", VA = "0x152C4FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public Vector3 eulerAngles
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x152C548", Offset = "0x152C548", VA = "0x152C548")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x152C56C", Offset = "0x152C56C", VA = "0x152C56C")]
		set
		{
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 localScale
	{
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x152C5B8", Offset = "0x152C5B8", VA = "0x152C5B8")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x152C5DC", Offset = "0x152C5DC", VA = "0x152C5DC")]
		set
		{
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 precedingControlPointLocalPosition
	{
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x152C628", Offset = "0x152C628", VA = "0x152C628")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x152C634", Offset = "0x152C634", VA = "0x152C634")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public Vector3 precedingControlPointPosition
	{
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x152C738", Offset = "0x152C738", VA = "0x152C738")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000012")]
		[Address(RVA = "0x152C780", Offset = "0x152C780", VA = "0x152C780")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Vector3 followingControlPointLocalPosition
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x152C938", Offset = "0x152C938", VA = "0x152C938")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x152C944", Offset = "0x152C944", VA = "0x152C944")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public Vector3 followingControlPointPosition
	{
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x152CA48", Offset = "0x152CA48", VA = "0x152CA48")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x152CA90", Offset = "0x152CA90", VA = "0x152CA90")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public HandleMode handleMode
	{
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x152CC48", Offset = "0x152CC48", VA = "0x152CC48")]
		get
		{
			return default(HandleMode);
		}
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x152CC50", Offset = "0x152CC50", VA = "0x152CC50")]
		set
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x152CC70", Offset = "0x152CC70", VA = "0x152CC70")]
	private void Awake()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x152CC98", Offset = "0x152CC98", VA = "0x152CC98")]
	public void CopyTo(BezierPoint other)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x152C2F8", Offset = "0x152C2F8", VA = "0x152C2F8")]
	private void Revalidate()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x152CD98", Offset = "0x152CD98", VA = "0x152CD98")]
	[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x65B9D0", Offset = "0x65B9D0")]
	private void SetSplineDirty()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x152CD9C", Offset = "0x152CD9C", VA = "0x152CD9C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x152CE24", Offset = "0x152CE24", VA = "0x152CE24")]
	public BezierPoint()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x65B6B0", Offset = "0x65B6B0")]
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
		[Address(RVA = "0x152F30C", Offset = "0x152F30C", VA = "0x152F30C")]
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
		[Address(RVA = "0x152CE70", Offset = "0x152CE70", VA = "0x152CE70")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x152CE78", Offset = "0x152CE78", VA = "0x152CE78")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public int Count
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x152CEFC", Offset = "0x152CEFC", VA = "0x152CEFC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000F")]
	public float Length
	{
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x152CF48", Offset = "0x152CF48", VA = "0x152CF48")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000010")]
	public BezierPoint Item
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x152D0AC", Offset = "0x152D0AC", VA = "0x152D0AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x152D1EC", Offset = "0x152D1EC", VA = "0x152D1EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x152D274", Offset = "0x152D274", VA = "0x152D274")]
	public void Initialize(int endPointsCount)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x152D1F0", Offset = "0x152D1F0", VA = "0x152D1F0")]
	public void Refresh()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x152D45C", Offset = "0x152D45C", VA = "0x152D45C")]
	public BezierPoint InsertNewPointAt(int index)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x152D8C0", Offset = "0x152D8C0", VA = "0x152D8C0")]
	public BezierPoint DuplicatePointAt(int index)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x152DB9C", Offset = "0x152DB9C", VA = "0x152DB9C")]
	public void RemovePointAt(int index)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x152DF14", Offset = "0x152DF14", VA = "0x152DF14")]
	public void SwapPointsAt(int index1, int index2)
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x152E22C", Offset = "0x152E22C", VA = "0x152E22C")]
	public void MovePoint(int previousIndex, int newIndex)
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x152E230", Offset = "0x152E230", VA = "0x152E230")]
	public void Internal_MovePoint(int previousIndex, int newIndex, string undo)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x152E608", Offset = "0x152E608", VA = "0x152E608")]
	public int IndexOf(BezierPoint point)
	{
		return default(int);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x152E66C", Offset = "0x152E66C", VA = "0x152E66C")]
	public Vector3 GetPoint(float normalizedT)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x152E8D0", Offset = "0x152E8D0", VA = "0x152E8D0")]
	public Vector3 GetTangent(float normalizedT)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x152EC08", Offset = "0x152EC08", VA = "0x152EC08")]
	public BezierPoint.ExtraData GetExtraData(float normalizedT)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x152EC84", Offset = "0x152EC84", VA = "0x152EC84")]
	public BezierPoint.ExtraData GetExtraData(float normalizedT, ExtraDataLerpFunction lerpFunction)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x152CF5C", Offset = "0x152CF5C", VA = "0x152CF5C")]
	public float GetLengthApproximately(float startNormalizedT, float endNormalizedT, float accuracy = 50f)
	{
		return default(float);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x152F200", Offset = "0x152F200", VA = "0x152F200")]
	public PointIndexTuple GetNearestPointIndicesTo(float normalizedT)
	{
		return default(PointIndexTuple);
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x152F318", Offset = "0x152F318", VA = "0x152F318")]
	public Vector3 FindNearestPointTo(Vector3 worldPos, float accuracy = 100f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x152F33C", Offset = "0x152F33C", VA = "0x152F33C")]
	public Vector3 FindNearestPointTo(Vector3 worldPos, out float normalizedT, float accuracy = 100f)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x152F460", Offset = "0x152F460", VA = "0x152F460")]
	public Vector3 MoveAlongSpline(ref float normalizedT, float deltaMovement, int accuracy = 3)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x152F53C", Offset = "0x152F53C", VA = "0x152F53C")]
	public void ConstructLinearPath()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x152F7E0", Offset = "0x152F7E0", VA = "0x152F7E0")]
	public void AutoConstructSpline()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1530220", Offset = "0x1530220", VA = "0x1530220")]
	private static Vector3[] GetFirstControlPoints(Vector3[] rhs)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x153043C", Offset = "0x153043C", VA = "0x153043C")]
	public void AutoConstructSpline2()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x152F1CC", Offset = "0x152F1CC", VA = "0x152F1CC")]
	private float AccuracyToStepSize(float accuracy)
	{
		return default(float);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1530918", Offset = "0x1530918", VA = "0x1530918")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1530C80", Offset = "0x1530C80", VA = "0x1530C80")]
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
	[Address(RVA = "0x1530DD8", Offset = "0x1530DD8", VA = "0x1530DD8")]
	private static BezierPoint.ExtraData InterpolateExtraDataAsQuaternion(BezierPoint.ExtraData data1, BezierPoint.ExtraData data2, float normalizedT)
	{
		return default(BezierPoint.ExtraData);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1530EA8", Offset = "0x1530EA8", VA = "0x1530EA8")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x65B89C", Offset = "0x65B89C")]
	public bool lookForward;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x3C")]
	public LookAtMode lookAt;

	[Token(Token = "0x17000014")]
	public List<Transform> Tail
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1530F50", Offset = "0x1530F50", VA = "0x1530F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000015")]
	public List<float> TailDistances
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1530F58", Offset = "0x1530F58", VA = "0x1530F58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public override BezierSpline Spline
	{
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1530F60", Offset = "0x1530F60", VA = "0x1530F60", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public override bool MovingForward
	{
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1530F80", Offset = "0x1530F80", VA = "0x1530F80", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000018")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1530FA0", Offset = "0x1530FA0", VA = "0x1530FA0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1530FC0", Offset = "0x1530FC0", VA = "0x1530FC0", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1530FE0", Offset = "0x1530FE0", VA = "0x1530FE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x1531174", Offset = "0x1531174", VA = "0x1531174")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x15311A4", Offset = "0x15311A4", VA = "0x15311A4", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x1531500", Offset = "0x1531500", VA = "0x1531500")]
	public void AddToTail(Transform transform, float distanceToPreviousObject)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1531634", Offset = "0x1531634", VA = "0x1531634")]
	public void InsertIntoTail(int index, Transform transform, float distanceToPreviousObject)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1531774", Offset = "0x1531774", VA = "0x1531774")]
	public void RemoveFromTail(Transform transform)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1531940", Offset = "0x1531940", VA = "0x1531940")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B8D8", Offset = "0x65B8D8")]
	private float m_normalizedT;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x2C")]
	public float rotationLerpModifier;

	[NonSerialized]
	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x65B918", Offset = "0x65B918")]
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
		[Address(RVA = "0x15319B8", Offset = "0x15319B8", VA = "0x15319B8", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001A")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x15319C0", Offset = "0x15319C0", VA = "0x15319C0", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x15319C8", Offset = "0x15319C8", VA = "0x15319C8", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public override bool MovingForward
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x15319D0", Offset = "0x15319D0", VA = "0x15319D0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15319F0", Offset = "0x15319F0", VA = "0x15319F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1531A20", Offset = "0x1531A20", VA = "0x1531A20", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1531D64", Offset = "0x1531D64", VA = "0x1531D64")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x65B954", Offset = "0x65B954")]
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
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x65B994", Offset = "0x65B994")]
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
		[Address(RVA = "0x1531E20", Offset = "0x1531E20", VA = "0x1531E20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001D")]
	public override float NormalizedT
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1531E28", Offset = "0x1531E28", VA = "0x1531E28", Slot = "6")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1531E30", Offset = "0x1531E30", VA = "0x1531E30", Slot = "7")]
		set
		{
		}
	}

	[Token(Token = "0x1700001E")]
	public override bool MovingForward
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1531E38", Offset = "0x1531E38", VA = "0x1531E38", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1531E40", Offset = "0x1531E40", VA = "0x1531E40")]
	private void Update()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1531E70", Offset = "0x1531E70", VA = "0x1531E70", Slot = "8")]
	public override void Execute(float deltaTime)
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x15321E4", Offset = "0x15321E4", VA = "0x15321E4")]
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
	[Address(RVA = "0x15322A0", Offset = "0x15322A0", VA = "0x15322A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15323FC", Offset = "0x15323FC", VA = "0x15323FC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x153294C", Offset = "0x153294C", VA = "0x153294C")]
	public ParticlesFollowBezier()
	{
	}
}
