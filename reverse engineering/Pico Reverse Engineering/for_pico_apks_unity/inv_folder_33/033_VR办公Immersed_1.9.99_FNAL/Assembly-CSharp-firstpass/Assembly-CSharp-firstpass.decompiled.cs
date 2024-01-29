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
	[Address(RVA = "0xDBA7E4", Offset = "0xDBA7E4", VA = "0xDBA7E4")]
	public static Sprite Get()
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDBA8C0", Offset = "0xDBA8C0", VA = "0xDBA8C0")]
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
		[Address(RVA = "0xDBA928", Offset = "0xDBA928", VA = "0xDBA928")]
		get
		{
			return default(Vector4);
		}
		[Token(Token = "0x6000004")]
		[Address(RVA = "0xDBA934", Offset = "0xDBA934", VA = "0xDBA934")]
		set
		{
		}
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xDBAA0C", Offset = "0xDBAA0C", VA = "0xDBAA0C", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xDBAA18", Offset = "0xDBAA18", VA = "0xDBAA18")]
	protected void OnValidate()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xDBAA40", Offset = "0xDBAA40", VA = "0xDBAA40")]
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
		[Address(RVA = "0xDBAA50", Offset = "0xDBAA50", VA = "0xDBAA50")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xDBAA58", Offset = "0xDBAA58", VA = "0xDBAA58")]
		set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public ProceduralImageEdge Side
	{
		[Token(Token = "0x600000A")]
		[Address(RVA = "0xDBAA80", Offset = "0xDBAA80", VA = "0xDBAA80")]
		get
		{
			return default(ProceduralImageEdge);
		}
		[Token(Token = "0x600000B")]
		[Address(RVA = "0xDBAA88", Offset = "0xDBAA88", VA = "0xDBAA88")]
		set
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDBAA90", Offset = "0xDBAA90", VA = "0xDBAA90", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDBAB10", Offset = "0xDBAB10", VA = "0xDBAB10")]
	public OnlyOneEdgeModifier()
	{
	}
}
[Token(Token = "0x2000006")]
[ModifierID("Round")]
public class RoundModifier : ProceduralImageModifier
{
	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDBAB18", Offset = "0xDBAB18", VA = "0xDBAB18", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDBAB74", Offset = "0xDBAB74", VA = "0xDBAB74")]
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
		[Address(RVA = "0xDBAB7C", Offset = "0xDBAB7C", VA = "0xDBAB7C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000011")]
		[Address(RVA = "0xDBAB84", Offset = "0xDBAB84", VA = "0xDBAB84")]
		set
		{
		}
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xDBABAC", Offset = "0xDBABAC", VA = "0xDBABAC", Slot = "4")]
	public override Vector4 CalculateRadius(Rect imageRect)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xDBABC0", Offset = "0xDBABC0", VA = "0xDBABC0")]
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
		[Address(RVA = "0xDBABC8", Offset = "0xDBABC8", VA = "0xDBABC8")]
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
			[Address(RVA = "0xDBAC18", Offset = "0xDBAC18", VA = "0xDBAC18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public UIGradientBlendMode BlendMode
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xDBACE8", Offset = "0xDBACE8", VA = "0xDBACE8")]
			get
			{
				return default(UIGradientBlendMode);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0xDBACF0", Offset = "0xDBACF0", VA = "0xDBACF0")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float Intensity
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0xDBAD9C", Offset = "0xDBAD9C", VA = "0xDBAD9C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0xDBADA4", Offset = "0xDBADA4", VA = "0xDBADA4")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public UIGradientType GradientType
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0xDBADC0", Offset = "0xDBADC0", VA = "0xDBADC0")]
			get
			{
				return default(UIGradientType);
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0xDBADC8", Offset = "0xDBADC8", VA = "0xDBADC8")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public Color LinearColor1
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xDBADD0", Offset = "0xDBADD0", VA = "0xDBADD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xDBADDC", Offset = "0xDBADDC", VA = "0xDBADDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public Color LinearColor2
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xDBADE8", Offset = "0xDBADE8", VA = "0xDBADE8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xDBADF4", Offset = "0xDBADF4", VA = "0xDBADF4")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public Color CornerColorUpperLeft
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0xDBAE00", Offset = "0xDBAE00", VA = "0xDBAE00")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0xDBAE0C", Offset = "0xDBAE0C", VA = "0xDBAE0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public Color CornerColorUpperRight
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0xDBAE18", Offset = "0xDBAE18", VA = "0xDBAE18")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0xDBAE24", Offset = "0xDBAE24", VA = "0xDBAE24")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Color CornerColorLowerRight
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0xDBAE30", Offset = "0xDBAE30", VA = "0xDBAE30")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000025")]
			[Address(RVA = "0xDBAE3C", Offset = "0xDBAE3C", VA = "0xDBAE3C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public Color CornerColorLowerLeft
		{
			[Token(Token = "0x6000026")]
			[Address(RVA = "0xDBAE48", Offset = "0xDBAE48", VA = "0xDBAE48")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000027")]
			[Address(RVA = "0xDBAE54", Offset = "0xDBAE54", VA = "0xDBAE54")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public float Angle
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xDBAE60", Offset = "0xDBAE60", VA = "0xDBAE60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000029")]
			[Address(RVA = "0xDBAE68", Offset = "0xDBAE68", VA = "0xDBAE68")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Gradient LinearGradient
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xDBAEA8", Offset = "0xDBAEA8", VA = "0xDBAEA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002B")]
			[Address(RVA = "0xDBAEB0", Offset = "0xDBAEB0", VA = "0xDBAEB0")]
			set
			{
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xDBAECC", Offset = "0xDBAECC", VA = "0xDBAECC", Slot = "20")]
		public override void ModifyMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xDBB458", Offset = "0xDBB458", VA = "0xDBB458")]
		protected void CutMesh(VertexHelper vh)
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xDBD1CC", Offset = "0xDBD1CC", VA = "0xDBD1CC")]
		private UIVertex UIVertexLerp(UIVertex v1, UIVertex v2, float f)
		{
			return default(UIVertex);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xDBBEDC", Offset = "0xDBBEDC", VA = "0xDBBEDC")]
		private Vector2 GetCutDirection()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xDBC694", Offset = "0xDBC694", VA = "0xDBC694")]
		private void CutTriangle(List<UIVertex> tris, int idx, List<UIVertex> list, Vector2 cutDirection, Vector2 point)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xDBD684", Offset = "0xDBD684", VA = "0xDBD684")]
		private bool IsOnLine(float f)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xDBD644", Offset = "0xDBD644", VA = "0xDBD644")]
		private float OnLine(Vector2 p1, Vector2 p2, Vector2 o, Vector2 dir)
		{
			return default(float);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xDBD6A0", Offset = "0xDBD6A0", VA = "0xDBD6A0")]
		private float ProjectedDistance(Vector2 p1, Vector2 p2, Vector2 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xDBBFFC", Offset = "0xDBBFFC", VA = "0xDBBFFC")]
		private Vector2 GetCutOrigin(float f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xDBBCF0", Offset = "0xDBBCF0", VA = "0xDBBCF0")]
		private Color BlendColor(Color c1, Color c2, UIGradientBlendMode mode, float intensity)
		{
			return default(Color);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0xDBBB44", Offset = "0xDBBB44", VA = "0xDBBB44")]
		private Vector2 RotateNormalizedPosition(Vector2 normalizedPosition, float angle)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xDBACF8", Offset = "0xDBACF8", VA = "0xDBACF8")]
		public void ForceUpdateGraphic()
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xDBBC48", Offset = "0xDBBC48", VA = "0xDBBC48")]
		private Color GetColorInGradient(Color ul, Color ur, Color lr, Color ll, Vector2 normalizedPosition)
		{
			return default(Color);
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xDBD890", Offset = "0xDBD890", VA = "0xDBD890")]
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
			[Address(RVA = "0xDBD9A4", Offset = "0xDBD9A4", VA = "0xDBD9A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xDBD974", Offset = "0xDBD974", VA = "0xDBD974")]
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
			[Address(RVA = "0xDBD9AC", Offset = "0xDBD9AC", VA = "0xDBD9AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xDBDAB0", Offset = "0xDBDAB0", VA = "0xDBDAB0")]
			set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public float BorderWidth
		{
			[Token(Token = "0x6000042")]
			[Address(RVA = "0xDBDB08", Offset = "0xDBDB08", VA = "0xDBDB08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xDBDB10", Offset = "0xDBDB10", VA = "0xDBDB10")]
			set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public float FalloffDistance
		{
			[Token(Token = "0x6000044")]
			[Address(RVA = "0xDBDB24", Offset = "0xDBDB24", VA = "0xDBDB24")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000045")]
			[Address(RVA = "0xDBDB2C", Offset = "0xDBDB2C", VA = "0xDBDB2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000015")]
		protected ProceduralImageModifier Modifier
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0xDBDB40", Offset = "0xDBDB40", VA = "0xDBDB40")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000047")]
			[Address(RVA = "0xDBDE34", Offset = "0xDBDE34", VA = "0xDBDE34")]
			set
			{
			}
		}

		[Token(Token = "0x17000016")]
		public System.Type ModifierType
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0xDBDE44", Offset = "0xDBDE44", VA = "0xDBDE44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xDBDC68", Offset = "0xDBDC68", VA = "0xDBDC68")]
			set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public override Material material
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xDBE6F0", Offset = "0xDBE6F0", VA = "0xDBE6F0", Slot = "32")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0xDBE76C", Offset = "0xDBE76C", VA = "0xDBE76C", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xDBDE60", Offset = "0xDBDE60", VA = "0xDBDE60", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xDBDFE0", Offset = "0xDBDFE0", VA = "0xDBDFE0", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xDBDE7C", Offset = "0xDBDE7C", VA = "0xDBDE7C")]
		private void Init()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xDBE15C", Offset = "0xDBE15C", VA = "0xDBE15C")]
		protected void OnVerticesDirty()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xDBE0C0", Offset = "0xDBE0C0", VA = "0xDBE0C0")]
		protected void FixTexCoordsInCanvas()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xDBE1E0", Offset = "0xDBE1E0", VA = "0xDBE1E0")]
		protected void FixTexCoordsInCanvas(Canvas c)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xDBE210", Offset = "0xDBE210", VA = "0xDBE210")]
		private Vector4 FixRadius(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xDBE308", Offset = "0xDBE308", VA = "0xDBE308", Slot = "44")]
		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xDBE664", Offset = "0xDBE664", VA = "0xDBE664", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xDBE350", Offset = "0xDBE350", VA = "0xDBE350")]
		private ProceduralImageInfo CalculateInfo()
		{
			return default(ProceduralImageInfo);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xDBE4A8", Offset = "0xDBE4A8", VA = "0xDBE4A8")]
		private void EncodeAllInfoIntoVertices(VertexHelper vh, ProceduralImageInfo info)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xDBE6B4", Offset = "0xDBE6B4", VA = "0xDBE6B4")]
		private float EncodeFloats_0_1_16_16(float a, float b)
		{
			return default(float);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xDBE774", Offset = "0xDBE774", VA = "0xDBE774")]
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
		[Address(RVA = "0xDBE680", Offset = "0xDBE680", VA = "0xDBE680")]
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
			[Address(RVA = "0xDBA960", Offset = "0xDBA960", VA = "0xDBA960")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600005B")]
		public abstract Vector4 CalculateRadius(Rect imageRect);

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xDBAA48", Offset = "0xDBAA48", VA = "0xDBAA48")]
		protected ProceduralImageModifier()
		{
		}
	}
}
