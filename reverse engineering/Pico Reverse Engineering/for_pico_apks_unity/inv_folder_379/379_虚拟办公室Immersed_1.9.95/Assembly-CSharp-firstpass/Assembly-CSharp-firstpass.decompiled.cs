using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UI.ProceduralImage;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public static class EmptySprite
{
	[Token(Token = "0x4000001")]
	[FieldOffset(Offset = "0x0")]
	private static Sprite instance;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xDB9A64", Offset = "0xDB9A64", VA = "0xDB9A64")]
	public static Sprite Get()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDB9B40", Offset = "0xDB9B40", VA = "0xDB9B40")]
	public static bool IsEmptySprite(Sprite s)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000003")]
[ModifierID("Free")]
public class FreeModifier : ProceduralImageModifier
{
	[Token(Token = "0x4000002")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Vector4 radius;

	[Token(Token = "0x17000001")]
	public Vector4 Radius
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0xDB9BA8", Offset = "0xDB9BA8", VA = "0xDB9BA8")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xDB9BB4", Offset = "0xDB9BB4", VA = "0xDB9BB4")]
		set
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDB9C8C", Offset = "0xDB9C8C", VA = "0xDB9C8C", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDB9C98", Offset = "0xDB9C98", VA = "0xDB9C98")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDB9CC0", Offset = "0xDB9CC0", VA = "0xDB9CC0")]
	public FreeModifier()
	{
	}
}
[Token(Token = "0x2000004")]
[ModifierID("Only One Edge")]
public class OnlyOneEdgeModifier : ProceduralImageModifier
{
	[Token(Token = "0x2000005")]
	public enum ProceduralImageEdge
	{
		[Token(Token = "0x4000006")]
		Top,
		[Token(Token = "0x4000007")]
		Bottom,
		[Token(Token = "0x4000008")]
		Left,
		[Token(Token = "0x4000009")]
		Right
	}

	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private ProceduralImageEdge side;

	[Token(Token = "0x17000002")]
	public float Radius
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xDB9CD0", Offset = "0xDB9CD0", VA = "0xDB9CD0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xDB9CD8", Offset = "0xDB9CD8", VA = "0xDB9CD8")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public ProceduralImageEdge Side
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xDB9D00", Offset = "0xDB9D00", VA = "0xDB9D00")]
		get
		{
			return default(ProceduralImageEdge);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xDB9D08", Offset = "0xDB9D08", VA = "0xDB9D08")]
		set
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDB9D10", Offset = "0xDB9D10", VA = "0xDB9D10", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDB9D90", Offset = "0xDB9D90", VA = "0xDB9D90")]
	public OnlyOneEdgeModifier()
	{
	}
}
[Token(Token = "0x2000006")]
[ModifierID("Round")]
public class RoundModifier : ProceduralImageModifier
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDB9D98", Offset = "0xDB9D98", VA = "0xDB9D98", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDB9DF4", Offset = "0xDB9DF4", VA = "0xDB9DF4")]
	public RoundModifier()
	{
	}
}
[Token(Token = "0x2000007")]
[ModifierID("Uniform")]
public class UniformModifier : ProceduralImageModifier
{
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float radius;

	[Token(Token = "0x17000004")]
	public float Radius
	{
		[Token(Token = "0x6000010")]
		[Address(RVA = "0xDB9DFC", Offset = "0xDB9DFC", VA = "0xDB9DFC")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xDB9E04", Offset = "0xDB9E04", VA = "0xDB9E04")]
		set
		{
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDB9E2C", Offset = "0xDB9E2C", VA = "0xDB9E2C", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xDB9E40", Offset = "0xDB9E40", VA = "0xDB9E40")]
	public UniformModifier()
	{
	}
}
namespace JoshH.Extensions
{
	[Token(Token = "0x2000008")]
	public static class Vector2Extension
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0xDB9E48", Offset = "0xDB9E48", VA = "0xDB9E48")]
		public static Vector2 Rotate(this Vector2 v, float degrees)
		{
			return default(Vector2);
		}
	}
}
namespace JoshH.UI
{
	[Token(Token = "0x2000009")]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Effects/UI Gradient")]
	public class UIGradient : BaseMeshEffect
	{
		[Token(Token = "0x200000A")]
		public enum UIGradientBlendMode
		{
			[Token(Token = "0x4000018")]
			Override,
			[Token(Token = "0x4000019")]
			Multiply
		}

		[Token(Token = "0x200000B")]
		public enum UIGradientType
		{
			[Token(Token = "0x400001B")]
			Linear,
			[Token(Token = "0x400001C")]
			Corner,
			[Token(Token = "0x400001D")]
			ComplexLinear
		}

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("How the gradient color will be blended with the graphics color.")]
		[SerializeField]
		private UIGradientBlendMode blendMode;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Range(0f, 1f)]
		private float intensity;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIGradientType gradientType;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Color linearColor1;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Color linearColor2;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Color cornerColorUpperLeft;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private Color cornerColorUpperRight;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Color cornerColorLowerRight;

		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Color cornerColorLowerLeft;

		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Gradient linearGradient;

		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 360f)]
		[SerializeField]
		private float angle;

		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0xA0")]
		private RectTransform _rectTransform;

		[Token(Token = "0x17000005")]
		protected RectTransform rectTransform
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xDB9E98", Offset = "0xDB9E98", VA = "0xDB9E98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public UIGradientBlendMode BlendMode
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xDB9F68", Offset = "0xDB9F68", VA = "0xDB9F68")]
			get
			{
				return default(UIGradientBlendMode);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xDB9F70", Offset = "0xDB9F70", VA = "0xDB9F70")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float Intensity
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xDBA01C", Offset = "0xDBA01C", VA = "0xDBA01C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xDBA024", Offset = "0xDBA024", VA = "0xDBA024")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public UIGradientType GradientType
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xDBA040", Offset = "0xDBA040", VA = "0xDBA040")]
			get
			{
				return default(UIGradientType);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xDBA048", Offset = "0xDBA048", VA = "0xDBA048")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color LinearColor1
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xDBA050", Offset = "0xDBA050", VA = "0xDBA050")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xDBA05C", Offset = "0xDBA05C", VA = "0xDBA05C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color LinearColor2
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xDBA068", Offset = "0xDBA068", VA = "0xDBA068")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xDBA074", Offset = "0xDBA074", VA = "0xDBA074")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color CornerColorUpperLeft
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xDBA080", Offset = "0xDBA080", VA = "0xDBA080")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xDBA08C", Offset = "0xDBA08C", VA = "0xDBA08C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color CornerColorUpperRight
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xDBA098", Offset = "0xDBA098", VA = "0xDBA098")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xDBA0A4", Offset = "0xDBA0A4", VA = "0xDBA0A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color CornerColorLowerRight
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xDBA0B0", Offset = "0xDBA0B0", VA = "0xDBA0B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xDBA0BC", Offset = "0xDBA0BC", VA = "0xDBA0BC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color CornerColorLowerLeft
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xDBA0C8", Offset = "0xDBA0C8", VA = "0xDBA0C8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xDBA0D4", Offset = "0xDBA0D4", VA = "0xDBA0D4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Angle
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xDBA0E0", Offset = "0xDBA0E0", VA = "0xDBA0E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xDBA0E8", Offset = "0xDBA0E8", VA = "0xDBA0E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Gradient LinearGradient
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xDBA128", Offset = "0xDBA128", VA = "0xDBA128")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xDBA130", Offset = "0xDBA130", VA = "0xDBA130")]
			set
			{
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xDBA14C", Offset = "0xDBA14C", VA = "0xDBA14C", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xDBA6D8", Offset = "0xDBA6D8", VA = "0xDBA6D8")]
		protected void CutMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xDBC44C", Offset = "0xDBC44C", VA = "0xDBC44C")]
		private UIVertex UIVertexLerp(UIVertex v1, UIVertex v2, float f)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xDBB15C", Offset = "0xDBB15C", VA = "0xDBB15C")]
		private Vector2 GetCutDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xDBB914", Offset = "0xDBB914", VA = "0xDBB914")]
		private void CutTriangle(List<UIVertex> tris, int idx, List<UIVertex> list, Vector2 cutDirection, Vector2 point)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xDBC904", Offset = "0xDBC904", VA = "0xDBC904")]
		private bool IsOnLine(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xDBC8C4", Offset = "0xDBC8C4", VA = "0xDBC8C4")]
		private float OnLine(Vector2 p1, Vector2 p2, Vector2 o, Vector2 dir)
		{
			return default(float);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDBC920", Offset = "0xDBC920", VA = "0xDBC920")]
		private float ProjectedDistance(Vector2 p1, Vector2 p2, Vector2 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xDBB27C", Offset = "0xDBB27C", VA = "0xDBB27C")]
		private Vector2 GetCutOrigin(float f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xDBAF70", Offset = "0xDBAF70", VA = "0xDBAF70")]
		private Color BlendColor(Color c1, Color c2, UIGradientBlendMode mode, float intensity)
		{
			return default(Color);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xDBADC4", Offset = "0xDBADC4", VA = "0xDBADC4")]
		private Vector2 RotateNormalizedPosition(Vector2 normalizedPosition, float angle)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xDB9F78", Offset = "0xDB9F78", VA = "0xDB9F78")]
		public void ForceUpdateGraphic()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xDBAEC8", Offset = "0xDBAEC8", VA = "0xDBAEC8")]
		private Color GetColorInGradient(Color ul, Color ur, Color lr, Color ll, Vector2 normalizedPosition)
		{
			return default(Color);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xDBCB10", Offset = "0xDBCB10", VA = "0xDBCB10")]
		public UIGradient()
		{
		}
	}
}
namespace UnityEngine.UI.ProceduralImage
{
	[Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.Class)]
	public class ModifierID : Attribute
	{
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x17000011")]
		public string Name
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0xDBCC24", Offset = "0xDBCC24", VA = "0xDBCC24")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xDBCBF4", Offset = "0xDBCBF4", VA = "0xDBCBF4")]
		public ModifierID(string name)
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AddComponentMenu("UI/Procedural Image")]
	[ExecuteInEditMode]
	public class ProceduralImage : Image
	{
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float borderWidth;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x110")]
		private ProceduralImageModifier modifier;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x0")]
		private static Material materialInstance;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float falloffDistance;

		[Token(Token = "0x17000012")]
		private static Material DefaultProceduralImageMaterial
		{
			[Token(Token = "0x6000040")]
			[Address(RVA = "0xDBCC2C", Offset = "0xDBCC2C", VA = "0xDBCC2C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xDBCD30", Offset = "0xDBCD30", VA = "0xDBCD30")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float BorderWidth
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xDBCD88", Offset = "0xDBCD88", VA = "0xDBCD88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xDBCD90", Offset = "0xDBCD90", VA = "0xDBCD90")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float FalloffDistance
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xDBCDA4", Offset = "0xDBCDA4", VA = "0xDBCDA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xDBCDAC", Offset = "0xDBCDAC", VA = "0xDBCDAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		protected ProceduralImageModifier Modifier
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xDBCDC0", Offset = "0xDBCDC0", VA = "0xDBCDC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xDBD0B4", Offset = "0xDBD0B4", VA = "0xDBD0B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public System.Type ModifierType
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xDBD0C4", Offset = "0xDBD0C4", VA = "0xDBD0C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xDBCEE8", Offset = "0xDBCEE8", VA = "0xDBCEE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public override Material material
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xDBD970", Offset = "0xDBD970", VA = "0xDBD970", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xDBD9EC", Offset = "0xDBD9EC", VA = "0xDBD9EC", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDBD0E0", Offset = "0xDBD0E0", VA = "0xDBD0E0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xDBD260", Offset = "0xDBD260", VA = "0xDBD260", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xDBD0FC", Offset = "0xDBD0FC", VA = "0xDBD0FC")]
		private void Init()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xDBD3DC", Offset = "0xDBD3DC", VA = "0xDBD3DC")]
		protected void OnVerticesDirty()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xDBD340", Offset = "0xDBD340", VA = "0xDBD340")]
		protected void FixTexCoordsInCanvas()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xDBD460", Offset = "0xDBD460", VA = "0xDBD460")]
		protected void FixTexCoordsInCanvas(Canvas c)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xDBD490", Offset = "0xDBD490", VA = "0xDBD490")]
		private Vector4 FixRadius(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDBD588", Offset = "0xDBD588", VA = "0xDBD588", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xDBD8E4", Offset = "0xDBD8E4", VA = "0xDBD8E4", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDBD5D0", Offset = "0xDBD5D0", VA = "0xDBD5D0")]
		private ProceduralImageInfo CalculateInfo()
		{
			return default(ProceduralImageInfo);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xDBD728", Offset = "0xDBD728", VA = "0xDBD728")]
		private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xDBD934", Offset = "0xDBD934", VA = "0xDBD934")]
		private float EncodeFloats_0_1_16_16(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xDBD9F4", Offset = "0xDBD9F4", VA = "0xDBD9F4")]
		public ProceduralImage()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public struct ProceduralImageInfo
	{
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x0")]
		public float width;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x4")]
		public float height;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x8")]
		public float fallOffDistance;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0xC")]
		public Vector4 radius;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x1C")]
		public float borderWidth;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x20")]
		public float pixelSize;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xDBD900", Offset = "0xDBD900", VA = "0xDBD900")]
		public ProceduralImageInfo(float width, float height, float fallOffDistance, float pixelSize, Vector4 radius, float borderWidth)
		{
		}
	}
	[Token(Token = "0x2000010")]
	[DisallowMultipleComponent]
	public abstract class ProceduralImageModifier : MonoBehaviour
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x18")]
		protected Graphic graphic;

		[Token(Token = "0x17000018")]
		protected Graphic _Graphic
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xDB9BE0", Offset = "0xDB9BE0", VA = "0xDB9BE0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005B")]
		public abstract Vector4 CalculateRadius(Rect imageRect);

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xDB9CC8", Offset = "0xDB9CC8", VA = "0xDB9CC8")]
		protected ProceduralImageModifier()
		{
		}
	}
}
