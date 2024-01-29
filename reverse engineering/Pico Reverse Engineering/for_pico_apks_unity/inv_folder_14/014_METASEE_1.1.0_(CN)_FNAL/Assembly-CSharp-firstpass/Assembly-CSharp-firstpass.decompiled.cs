using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED4CC", Offset = "0x6ED4CC")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xFE7888", Offset = "0xFE7888", VA = "0xFE7888")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xFED43C", Offset = "0xFED43C", VA = "0xFED43C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xFED458", Offset = "0xFED458", VA = "0xFED458")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED4DC", Offset = "0x6ED4DC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xFE7890", Offset = "0xFE7890", VA = "0xFE7890")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xFED474", Offset = "0xFED474", VA = "0xFED474")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xFED490", Offset = "0xFED490", VA = "0xFED490")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED4EC", Offset = "0x6ED4EC")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xFE7CD0", Offset = "0xFE7CD0", VA = "0xFE7CD0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xFED4AC", Offset = "0xFED4AC", VA = "0xFED4AC")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xFED4B8", Offset = "0xFED4B8", VA = "0xFED4B8")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xFE5218", Offset = "0xFE5218", VA = "0xFE5218")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xFE5758", Offset = "0xFE5758", VA = "0xFE5758")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xFE7898", Offset = "0xFE7898", VA = "0xFE7898")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xFE7A84", Offset = "0xFE7A84", VA = "0xFE7A84")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000007")]
	public static class Utils
	{
		[Token(Token = "0x6000038")]
		[Address(RVA = "0xFE4C5C", Offset = "0xFE4C5C", VA = "0xFE4C5C")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED50C", Offset = "0x6ED50C")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xFE7CD8", Offset = "0xFE7CD8", VA = "0xFE7CD8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xFED564", Offset = "0xFED564", VA = "0xFED564")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xFED580", Offset = "0xFED580", VA = "0xFED580")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED51C", Offset = "0x6ED51C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xFE7CE0", Offset = "0xFE7CE0", VA = "0xFE7CE0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xFED7D4", Offset = "0xFED7D4", VA = "0xFED7D4")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFED7F8", Offset = "0xFED7F8", VA = "0xFED7F8")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED52C", Offset = "0x6ED52C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xFE7CE8", Offset = "0xFE7CE8", VA = "0xFE7CE8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFEDB90", Offset = "0xFEDB90", VA = "0xFEDB90")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFEDBB4", Offset = "0xFEDBB4", VA = "0xFEDBB4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED53C", Offset = "0x6ED53C")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFE7EB0", Offset = "0xFE7EB0", VA = "0xFE7EB0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFEE03C", Offset = "0xFEE03C", VA = "0xFEE03C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xFEE060", Offset = "0xFEE060", VA = "0xFEE060")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED54C", Offset = "0x6ED54C")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xFE8050", Offset = "0xFE8050", VA = "0xFE8050")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xFEE184", Offset = "0xFEE184", VA = "0xFEE184")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFEE1A8", Offset = "0xFEE1A8", VA = "0xFEE1A8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED55C", Offset = "0x6ED55C")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFE8214", Offset = "0xFE8214", VA = "0xFE8214")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xFEE1CC", Offset = "0xFEE1CC", VA = "0xFEE1CC")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xFEE1E8", Offset = "0xFEE1E8", VA = "0xFEE1E8")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED56C", Offset = "0x6ED56C")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0xFE85C8", Offset = "0xFE85C8", VA = "0xFE85C8")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFEE204", Offset = "0xFEE204", VA = "0xFEE204")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0xFEE268", Offset = "0xFEE268", VA = "0xFEE268")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED57C", Offset = "0x6ED57C")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x600004E")]
		[Address(RVA = "0xFE8788", Offset = "0xFE8788", VA = "0xFE8788")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0xFEE2C4", Offset = "0xFEE2C4", VA = "0xFEE2C4")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0xFEE328", Offset = "0xFEE328", VA = "0xFEE328")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED58C", Offset = "0x6ED58C")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000051")]
		[Address(RVA = "0xFE8948", Offset = "0xFE8948", VA = "0xFE8948")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xFEE384", Offset = "0xFEE384", VA = "0xFEE384")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFEE3E8", Offset = "0xFEE3E8", VA = "0xFEE3E8")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED59C", Offset = "0x6ED59C")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFE8B10", Offset = "0xFE8B10", VA = "0xFE8B10")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFED59C", Offset = "0xFED59C", VA = "0xFED59C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xFED5BC", Offset = "0xFED5BC", VA = "0xFED5BC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5AC", Offset = "0x6ED5AC")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xFE8CB0", Offset = "0xFE8CB0", VA = "0xFE8CB0")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xFED5D8", Offset = "0xFED5D8", VA = "0xFED5D8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xFED5F8", Offset = "0xFED5F8", VA = "0xFED5F8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5BC", Offset = "0x6ED5BC")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xFE8E60", Offset = "0xFE8E60", VA = "0xFE8E60")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xFED614", Offset = "0xFED614", VA = "0xFED614")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xFED630", Offset = "0xFED630", VA = "0xFED630")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5CC", Offset = "0x6ED5CC")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xFE9020", Offset = "0xFE9020", VA = "0xFE9020")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xFED64C", Offset = "0xFED64C", VA = "0xFED64C")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xFED668", Offset = "0xFED668", VA = "0xFED668")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5DC", Offset = "0x6ED5DC")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFE91D8", Offset = "0xFE91D8", VA = "0xFE91D8")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xFED684", Offset = "0xFED684", VA = "0xFED684")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFED6A0", Offset = "0xFED6A0", VA = "0xFED6A0")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5EC", Offset = "0x6ED5EC")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xFE9390", Offset = "0xFE9390", VA = "0xFE9390")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xFED6BC", Offset = "0xFED6BC", VA = "0xFED6BC")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xFED6D8", Offset = "0xFED6D8", VA = "0xFED6D8")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED5FC", Offset = "0x6ED5FC")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFE9398", Offset = "0xFE9398", VA = "0xFE9398")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFED6F4", Offset = "0xFED6F4", VA = "0xFED6F4")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xFED710", Offset = "0xFED710", VA = "0xFED710")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED60C", Offset = "0x6ED60C")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xFE9554", Offset = "0xFE9554", VA = "0xFE9554")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xFED72C", Offset = "0xFED72C", VA = "0xFED72C")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xFED748", Offset = "0xFED748", VA = "0xFED748")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED61C", Offset = "0x6ED61C")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xFE9710", Offset = "0xFE9710", VA = "0xFE9710")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xFED764", Offset = "0xFED764", VA = "0xFED764")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xFED780", Offset = "0xFED780", VA = "0xFED780")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED62C", Offset = "0x6ED62C")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFE98CC", Offset = "0xFE98CC", VA = "0xFE98CC")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFED79C", Offset = "0xFED79C", VA = "0xFED79C")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFED7B8", Offset = "0xFED7B8", VA = "0xFED7B8")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED63C", Offset = "0x6ED63C")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFE9A8C", Offset = "0xFE9A8C", VA = "0xFE9A8C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFED81C", Offset = "0xFED81C", VA = "0xFED81C")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFED838", Offset = "0xFED838", VA = "0xFED838")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED64C", Offset = "0x6ED64C")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xFE9C4C", Offset = "0xFE9C4C", VA = "0xFE9C4C")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xFED854", Offset = "0xFED854", VA = "0xFED854")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xFED870", Offset = "0xFED870", VA = "0xFED870")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED65C", Offset = "0x6ED65C")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xFE9DFC", Offset = "0xFE9DFC", VA = "0xFE9DFC")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xFED88C", Offset = "0xFED88C", VA = "0xFED88C")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFED8A8", Offset = "0xFED8A8", VA = "0xFED8A8")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED66C", Offset = "0x6ED66C")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFE9FB0", Offset = "0xFE9FB0", VA = "0xFE9FB0")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xFED8C4", Offset = "0xFED8C4", VA = "0xFED8C4")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFED8E0", Offset = "0xFED8E0", VA = "0xFED8E0")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED67C", Offset = "0x6ED67C")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFEA164", Offset = "0xFEA164", VA = "0xFEA164")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFED8FC", Offset = "0xFED8FC", VA = "0xFED8FC")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xFED918", Offset = "0xFED918", VA = "0xFED918")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED68C", Offset = "0x6ED68C")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xFEA16C", Offset = "0xFEA16C", VA = "0xFEA16C")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xFED934", Offset = "0xFED934", VA = "0xFED934")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xFED950", Offset = "0xFED950", VA = "0xFED950")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED69C", Offset = "0x6ED69C")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xFEA174", Offset = "0xFEA174", VA = "0xFEA174")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xFED96C", Offset = "0xFED96C", VA = "0xFED96C")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xFED994", Offset = "0xFED994", VA = "0xFED994")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6AC", Offset = "0x6ED6AC")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xFEA364", Offset = "0xFEA364", VA = "0xFEA364")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xFED9B0", Offset = "0xFED9B0", VA = "0xFED9B0")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xFED9D8", Offset = "0xFED9D8", VA = "0xFED9D8")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6BC", Offset = "0x6ED6BC")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xFEA36C", Offset = "0xFEA36C", VA = "0xFEA36C")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xFED9F4", Offset = "0xFED9F4", VA = "0xFED9F4")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xFEDA1C", Offset = "0xFEDA1C", VA = "0xFEDA1C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6CC", Offset = "0x6ED6CC")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xFEA7A0", Offset = "0xFEA7A0", VA = "0xFEA7A0")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xFEDA38", Offset = "0xFEDA38", VA = "0xFEDA38")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xFEDA54", Offset = "0xFEDA54", VA = "0xFEDA54")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xFEDA70", Offset = "0xFEDA70", VA = "0xFEDA70")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xFEDAA4", Offset = "0xFEDAA4", VA = "0xFEDAA4")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xFEDAC0", Offset = "0xFEDAC0", VA = "0xFEDAC0")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xFEDADC", Offset = "0xFEDADC", VA = "0xFEDADC")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6DC", Offset = "0x6ED6DC")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xFEA954", Offset = "0xFEA954", VA = "0xFEA954")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xFEDBD8", Offset = "0xFEDBD8", VA = "0xFEDBD8")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xFEDC2C", Offset = "0xFEDC2C", VA = "0xFEDC2C")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6EC", Offset = "0x6ED6EC")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xFEAAF8", Offset = "0xFEAAF8", VA = "0xFEAAF8")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xFEDC78", Offset = "0xFEDC78", VA = "0xFEDC78")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xFEDC94", Offset = "0xFEDC94", VA = "0xFEDC94")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED6FC", Offset = "0x6ED6FC")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xFEAC9C", Offset = "0xFEAC9C", VA = "0xFEAC9C")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xFEDCB0", Offset = "0xFEDCB0", VA = "0xFEDCB0")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xFEDCCC", Offset = "0xFEDCCC", VA = "0xFEDCCC")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED70C", Offset = "0x6ED70C")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xFEAE4C", Offset = "0xFEAE4C", VA = "0xFEAE4C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xFEDCE8", Offset = "0xFEDCE8", VA = "0xFEDCE8")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xFEDD0C", Offset = "0xFEDD0C", VA = "0xFEDD0C")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED71C", Offset = "0x6ED71C")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xFEAE54", Offset = "0xFEAE54", VA = "0xFEAE54")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xFEDD30", Offset = "0xFEDD30", VA = "0xFEDD30")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xFEDD54", Offset = "0xFEDD54", VA = "0xFEDD54")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED72C", Offset = "0x6ED72C")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xFEB060", Offset = "0xFEB060", VA = "0xFEB060")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xFEDD78", Offset = "0xFEDD78", VA = "0xFEDD78")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xFEDD80", Offset = "0xFEDD80", VA = "0xFEDD80")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED73C", Offset = "0x6ED73C")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xFEB068", Offset = "0xFEB068", VA = "0xFEB068")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xFEDE1C", Offset = "0xFEDE1C", VA = "0xFEDE1C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xFEDE40", Offset = "0xFEDE40", VA = "0xFEDE40")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED74C", Offset = "0x6ED74C")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xFEB070", Offset = "0xFEB070", VA = "0xFEB070")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xFEDE64", Offset = "0xFEDE64", VA = "0xFEDE64")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFEDE88", Offset = "0xFEDE88", VA = "0xFEDE88")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED75C", Offset = "0x6ED75C")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xFEB2CC", Offset = "0xFEB2CC", VA = "0xFEB2CC")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xFEDEAC", Offset = "0xFEDEAC", VA = "0xFEDEAC")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xFEDEB8", Offset = "0xFEDEB8", VA = "0xFEDEB8")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED76C", Offset = "0x6ED76C")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xFEB528", Offset = "0xFEB528", VA = "0xFEB528")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xFEDF74", Offset = "0xFEDF74", VA = "0xFEDF74")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xFEDF80", Offset = "0xFEDF80", VA = "0xFEDF80")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED77C", Offset = "0x6ED77C")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xFEB784", Offset = "0xFEB784", VA = "0xFEB784")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xFEE084", Offset = "0xFEE084", VA = "0xFEE084")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xFEE090", Offset = "0xFEE090", VA = "0xFEE090")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED78C", Offset = "0x6ED78C")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xFEB984", Offset = "0xFEB984", VA = "0xFEB984")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xFEE14C", Offset = "0xFEE14C", VA = "0xFEE14C")]
		internal Vector2 <DOShapeCircle>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xFEE168", Offset = "0xFEE168", VA = "0xFEE168")]
		internal void <DOShapeCircle>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xFE5C20", Offset = "0xFE5C20", VA = "0xFE5C20")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xFE53D8", Offset = "0xFE53D8", VA = "0xFE53D8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xFE58F0", Offset = "0xFE58F0", VA = "0xFE58F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xFE7CF0", Offset = "0xFE7CF0", VA = "0xFE7CF0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xFE7EB8", Offset = "0xFE7EB8", VA = "0xFE7EB8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xFE8058", Offset = "0xFE8058", VA = "0xFE8058")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xFE821C", Offset = "0xFE821C", VA = "0xFE821C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xFE8410", Offset = "0xFE8410", VA = "0xFE8410")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xFE85D0", Offset = "0xFE85D0", VA = "0xFE85D0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xFE8790", Offset = "0xFE8790", VA = "0xFE8790")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xFE8950", Offset = "0xFE8950", VA = "0xFE8950")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xFE8B18", Offset = "0xFE8B18", VA = "0xFE8B18")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xFE8CB8", Offset = "0xFE8CB8", VA = "0xFE8CB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xFE8E68", Offset = "0xFE8E68", VA = "0xFE8E68")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xFE9028", Offset = "0xFE9028", VA = "0xFE9028")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xFE91E0", Offset = "0xFE91E0", VA = "0xFE91E0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xFE4EA0", Offset = "0xFE4EA0", VA = "0xFE4EA0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xFE93A0", Offset = "0xFE93A0", VA = "0xFE93A0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xFE955C", Offset = "0xFE955C", VA = "0xFE955C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xFE9718", Offset = "0xFE9718", VA = "0xFE9718")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xFE98D4", Offset = "0xFE98D4", VA = "0xFE98D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xFE9A94", Offset = "0xFE9A94", VA = "0xFE9A94")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xFE9C54", Offset = "0xFE9C54", VA = "0xFE9C54")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xFE9E04", Offset = "0xFE9E04", VA = "0xFE9E04")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xFE9FB8", Offset = "0xFE9FB8", VA = "0xFE9FB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xFE5060", Offset = "0xFE5060", VA = "0xFE5060")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xFE5FFC", Offset = "0xFE5FFC", VA = "0xFE5FFC")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xFEA17C", Offset = "0xFEA17C", VA = "0xFEA17C")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xFE61C4", Offset = "0xFE61C4", VA = "0xFE61C4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xFEA374", Offset = "0xFEA374", VA = "0xFEA374")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xFEA7A8", Offset = "0xFEA7A8", VA = "0xFEA7A8")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xFEA95C", Offset = "0xFEA95C", VA = "0xFEA95C")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xFEAB00", Offset = "0xFEAB00", VA = "0xFEAB00")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xFEACA4", Offset = "0xFEACA4", VA = "0xFEACA4")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xFE5598", Offset = "0xFE5598", VA = "0xFE5598")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xFEAE5C", Offset = "0xFEAE5C", VA = "0xFEAE5C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xFE5A88", Offset = "0xFE5A88", VA = "0xFE5A88")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xFE5DB8", Offset = "0xFE5DB8", VA = "0xFE5DB8")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xFEB078", Offset = "0xFEB078", VA = "0xFEB078")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xFEB2D4", Offset = "0xFEB2D4", VA = "0xFEB2D4")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xFEB530", Offset = "0xFEB530", VA = "0xFEB530")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xFEB78C", Offset = "0xFEB78C", VA = "0xFEB78C")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7AC", Offset = "0x6ED7AC")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xFEC560", Offset = "0xFEC560", VA = "0xFEC560")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xFEE444", Offset = "0xFEE444", VA = "0xFEE444")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xFEE468", Offset = "0xFEE468", VA = "0xFEE468")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7BC", Offset = "0x6ED7BC")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xFEC780", Offset = "0xFEC780", VA = "0xFEC780")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xFEE48C", Offset = "0xFEE48C", VA = "0xFEE48C")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xFEE4B0", Offset = "0xFEE4B0", VA = "0xFEE4B0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7CC", Offset = "0x6ED7CC")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xFEE4D4", Offset = "0xFEE4D4", VA = "0xFEE4D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xFEE718", Offset = "0xFEE718", VA = "0xFEE718", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7DC", Offset = "0x6ED7DC")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xFEEE28", Offset = "0xFEEE28", VA = "0xFEEE28", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xFEF090", Offset = "0xFEF090", VA = "0xFEF090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7EC", Offset = "0x6ED7EC")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xFEE97C", Offset = "0xFEE97C", VA = "0xFEE97C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xFEEBAC", Offset = "0xFEEBAC", VA = "0xFEEBAC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED7FC", Offset = "0x6ED7FC")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xFEE724", Offset = "0xFEE724", VA = "0xFEE724", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xFEE970", Offset = "0xFEE970", VA = "0xFEE970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED80C", Offset = "0x6ED80C")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xFEEBB8", Offset = "0xFEEBB8", VA = "0xFEEBB8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xFEEE1C", Offset = "0xFEEE1C", VA = "0xFEEE1C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED81C", Offset = "0x6ED81C")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xFEF09C", Offset = "0xFEF09C", VA = "0xFEF09C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xFEF2D4", Offset = "0xFEF2D4", VA = "0xFEF2D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xFEB98C", Offset = "0xFEB98C", VA = "0xFEB98C")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xFEBB7C", Offset = "0xFEBB7C", VA = "0xFEBB7C")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xFEBD80", Offset = "0xFEBD80", VA = "0xFEBD80")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xFEBE6C", Offset = "0xFEBE6C", VA = "0xFEBE6C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xFEBF58", Offset = "0xFEBF58", VA = "0xFEBF58")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xFEC044", Offset = "0xFEC044", VA = "0xFEC044")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xFEC150", Offset = "0xFEC150", VA = "0xFEC150")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xFEC25C", Offset = "0xFEC25C", VA = "0xFEC25C")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xFEC348", Offset = "0xFEC348", VA = "0xFEC348")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xFEC568", Offset = "0xFEC568", VA = "0xFEC568")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xFEC788", Offset = "0xFEC788", VA = "0xFEC788")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDC24", Offset = "0x6EDC24")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xFEC88C", Offset = "0xFEC88C", VA = "0xFEC88C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDC94", Offset = "0x6EDC94")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xFEC990", Offset = "0xFEC990", VA = "0xFEC990")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDD04", Offset = "0x6EDD04")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xFECA94", Offset = "0xFECA94", VA = "0xFECA94")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDD74", Offset = "0x6EDD74")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xFECBA8", Offset = "0xFECBA8", VA = "0xFECBA8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDDE4", Offset = "0x6EDDE4")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xFECCBC", Offset = "0xFECCBC", VA = "0xFECCBC")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x6EDE54", Offset = "0x6EDE54")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x200003A")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x200003B")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xFED2A4", Offset = "0xFED2A4", VA = "0xFED2A4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xFEBE40", Offset = "0xFEBE40", VA = "0xFEBE40")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x200003C")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xFED3A4", Offset = "0xFED3A4", VA = "0xFED3A4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xFEBF2C", Offset = "0xFEBF2C", VA = "0xFEBF2C")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x200003D")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xFED324", Offset = "0xFED324", VA = "0xFED324", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xFEC018", Offset = "0xFEC018", VA = "0xFEC018")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x200003E")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xFED2D8", Offset = "0xFED2D8", VA = "0xFED2D8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xFEC114", Offset = "0xFEC114", VA = "0xFEC114")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x200003F")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0xFED340", Offset = "0xFED340", VA = "0xFED340", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xFEC220", Offset = "0xFEC220", VA = "0xFEC220")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000040")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0xFED408", Offset = "0xFED408", VA = "0xFED408", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xFEC31C", Offset = "0xFEC31C", VA = "0xFEC31C")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000041")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000042")]
	public static class Physics
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xFEF2E0", Offset = "0xFEF2E0", VA = "0xFEF2E0")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xFEF2FC", Offset = "0xFEF2FC", VA = "0xFEF2FC")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFEF304", Offset = "0xFEF304", VA = "0xFEF304")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFEF30C", Offset = "0xFEF30C", VA = "0xFEF30C")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xFECDC0", Offset = "0xFECDC0", VA = "0xFECDC0")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xFECE84", Offset = "0xFECE84", VA = "0xFECE84")]
	[Preserve]
	private static void Preserver()
	{
	}
}
[Token(Token = "0x2000043")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x6ED82C", Offset = "0x6ED82C")]
public class DOTweenAnimation : ABSAnimationComponent
{
	[Token(Token = "0x2000044")]
	public enum AnimationType
	{
		[Token(Token = "0x4000089")]
		None,
		[Token(Token = "0x400008A")]
		Move,
		[Token(Token = "0x400008B")]
		LocalMove,
		[Token(Token = "0x400008C")]
		Rotate,
		[Token(Token = "0x400008D")]
		LocalRotate,
		[Token(Token = "0x400008E")]
		Scale,
		[Token(Token = "0x400008F")]
		Color,
		[Token(Token = "0x4000090")]
		Fade,
		[Token(Token = "0x4000091")]
		Text,
		[Token(Token = "0x4000092")]
		PunchPosition,
		[Token(Token = "0x4000093")]
		PunchRotation,
		[Token(Token = "0x4000094")]
		PunchScale,
		[Token(Token = "0x4000095")]
		ShakePosition,
		[Token(Token = "0x4000096")]
		ShakeRotation,
		[Token(Token = "0x4000097")]
		ShakeScale,
		[Token(Token = "0x4000098")]
		CameraAspect,
		[Token(Token = "0x4000099")]
		CameraBackgroundColor,
		[Token(Token = "0x400009A")]
		CameraFieldOfView,
		[Token(Token = "0x400009B")]
		CameraOrthoSize,
		[Token(Token = "0x400009C")]
		CameraPixelRect,
		[Token(Token = "0x400009D")]
		CameraRect,
		[Token(Token = "0x400009E")]
		UIWidthHeight
	}

	[Token(Token = "0x2000045")]
	public enum TargetType
	{
		[Token(Token = "0x40000A0")]
		Unset,
		[Token(Token = "0x40000A1")]
		Camera,
		[Token(Token = "0x40000A2")]
		CanvasGroup,
		[Token(Token = "0x40000A3")]
		Image,
		[Token(Token = "0x40000A4")]
		Light,
		[Token(Token = "0x40000A5")]
		RectTransform,
		[Token(Token = "0x40000A6")]
		Renderer,
		[Token(Token = "0x40000A7")]
		SpriteRenderer,
		[Token(Token = "0x40000A8")]
		Rigidbody,
		[Token(Token = "0x40000A9")]
		Rigidbody2D,
		[Token(Token = "0x40000AA")]
		Text,
		[Token(Token = "0x40000AB")]
		Transform,
		[Token(Token = "0x40000AC")]
		tk2dBaseSprite,
		[Token(Token = "0x40000AD")]
		tk2dTextMesh,
		[Token(Token = "0x40000AE")]
		TextMeshPro,
		[Token(Token = "0x40000AF")]
		TextMeshProUGUI
	}

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool targetIsSelf;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject targetGO;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool tweenTargetIsTargetGO;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float delay;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float duration;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Ease easeType;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve easeCurve;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LoopType loopType;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int loops;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string id;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isRelative;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool isFrom;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool isIndependentUpdate;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	public bool autoKill;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool autoGenerate;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool isActive;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
	public bool isValid;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Component target;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AnimationType animationType;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public TargetType targetType;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TargetType forcedTargetType;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool autoPlay;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool useTargetAsV3;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float endValueFloat;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Vector3 endValueV3;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Vector2 endValueV2;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Color endValueColor;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string endValueString;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Rect endValueRect;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform endValueTransform;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool optionalBool0;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool optionalBool1;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float optionalFloat0;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int optionalInt0;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public RotateMode optionalRotationMode;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ScrambleMode optionalScrambleMode;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string optionalString;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _tweenAutoGenerationCalled;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int _playCount;

	[Token(Token = "0x14000001")]
	public static event Action<DOTweenAnimation> OnReset
	{
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFE3250", Offset = "0xFE3250", VA = "0xFE3250")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EDF64", Offset = "0x6EDF64")]
		add
		{
		}
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFE330C", Offset = "0xFE330C", VA = "0xFE330C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EDF74", Offset = "0x6EDF74")]
		remove
		{
		}
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xFE33C8", Offset = "0xFE33C8", VA = "0xFE33C8")]
	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xFE3444", Offset = "0xFE3444", VA = "0xFE3444")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xFE48F4", Offset = "0xFE48F4", VA = "0xFE48F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xFE4940", Offset = "0xFE4940", VA = "0xFE4940")]
	private void Reset()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xFE4944", Offset = "0xFE4944", VA = "0xFE4944")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xFE4980", Offset = "0xFE4980", VA = "0xFE4980")]
	public void RewindThenRecreateTween()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xFE49C4", Offset = "0xFE49C4", VA = "0xFE49C4")]
	public void RewindThenRecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xFE4A08", Offset = "0xFE4A08", VA = "0xFE4A08")]
	public void RecreateTween()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xFE4A14", Offset = "0xFE4A14", VA = "0xFE4A14")]
	public void RecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xFE349C", Offset = "0xFE349C", VA = "0xFE349C")]
	public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xFE63D4", Offset = "0xFE63D4", VA = "0xFE63D4")]
	public List<Tween> GetTweens()
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xFE64EC", Offset = "0xFE64EC", VA = "0xFE64EC")]
	public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xFE65C8", Offset = "0xFE65C8", VA = "0xFE65C8", Slot = "4")]
	public override void DOPlay()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xFE6654", Offset = "0xFE6654", VA = "0xFE6654", Slot = "5")]
	public override void DOPlayBackwards()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xFE66E0", Offset = "0xFE66E0", VA = "0xFE66E0", Slot = "6")]
	public override void DOPlayForward()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xFE676C", Offset = "0xFE676C", VA = "0xFE676C", Slot = "7")]
	public override void DOPause()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xFE67F8", Offset = "0xFE67F8", VA = "0xFE67F8", Slot = "8")]
	public override void DOTogglePause()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xFE6884", Offset = "0xFE6884", VA = "0xFE6884", Slot = "9")]
	public override void DORewind()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xFE697C", Offset = "0xFE697C", VA = "0xFE697C", Slot = "10")]
	public override void DORestart()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xFE698C", Offset = "0xFE698C", VA = "0xFE698C", Slot = "11")]
	public override void DORestart(bool fromHere)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xFE6D1C", Offset = "0xFE6D1C", VA = "0xFE6D1C", Slot = "12")]
	public override void DOComplete()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xFE6DAC", Offset = "0xFE6DAC", VA = "0xFE6DAC", Slot = "13")]
	public override void DOKill()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xFE6E44", Offset = "0xFE6E44", VA = "0xFE6E44")]
	public void DOPlayById(string id)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xFE6EE0", Offset = "0xFE6EE0", VA = "0xFE6EE0")]
	public void DOPlayAllById(string id)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xFE6F44", Offset = "0xFE6F44", VA = "0xFE6F44")]
	public void DOPauseAllById(string id)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xFE6FA8", Offset = "0xFE6FA8", VA = "0xFE6FA8")]
	public void DOPlayBackwardsById(string id)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xFE7044", Offset = "0xFE7044", VA = "0xFE7044")]
	public void DOPlayBackwardsAllById(string id)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xFE70A8", Offset = "0xFE70A8", VA = "0xFE70A8")]
	public void DOPlayForwardById(string id)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xFE7144", Offset = "0xFE7144", VA = "0xFE7144")]
	public void DOPlayForwardAllById(string id)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xFE71A8", Offset = "0xFE71A8", VA = "0xFE71A8")]
	public void DOPlayNext()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xFE72F8", Offset = "0xFE72F8", VA = "0xFE72F8")]
	public void DORewindAndPlayNext()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xFE7398", Offset = "0xFE7398", VA = "0xFE7398")]
	public void DORewindAllById(string id)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xFE7414", Offset = "0xFE7414", VA = "0xFE7414")]
	public void DORestartById(string id)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xFE74C0", Offset = "0xFE74C0", VA = "0xFE74C0")]
	public void DORestartAllById(string id)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xFE7540", Offset = "0xFE7540", VA = "0xFE7540")]
	public void DOKillById(string id)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xFE75E0", Offset = "0xFE75E0", VA = "0xFE75E0")]
	public void DOKillAllById(string id)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xFE4A38", Offset = "0xFE4A38", VA = "0xFE4A38")]
	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xFE7648", Offset = "0xFE7648", VA = "0xFE7648")]
	public Tween CreateEditorPreview()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xFE4A20", Offset = "0xFE4A20", VA = "0xFE4A20")]
	private GameObject GetTweenGO()
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xFE63B4", Offset = "0xFE63B4", VA = "0xFE63B4")]
	private GameObject GetTweenTarget()
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xFE6AB4", Offset = "0xFE6AB4", VA = "0xFE6AB4")]
	private void ReEvaluateRelativeTween()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xFE768C", Offset = "0xFE768C", VA = "0xFE768C")]
	public DOTweenAnimation()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xFE7880", Offset = "0xFE7880", VA = "0xFE7880")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6EDF84", Offset = "0x6EDF84")]
	private void <CreateTween>b__53_0()
	{
	}
}
[Token(Token = "0x2000046")]
public static class DOTweenAnimationExtensions
{
	[Token(Token = "0x6000119")]
	public static bool IsSameOrSubclassOf<T>(this Component t)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000047")]
public static class DOTweenProShortcuts
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6ED884", Offset = "0x6ED884")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFED29C", Offset = "0xFED29C", VA = "0xFED29C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFEF37C", Offset = "0xFEF37C", VA = "0xFEF37C")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFEF398", Offset = "0xFEF398", VA = "0xFEF398")]
		internal void <DOSpiral>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xFECF38", Offset = "0xFECF38", VA = "0xFECF38")]
	static DOTweenProShortcuts()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xFECF84", Offset = "0xFECF84", VA = "0xFECF84")]
	public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}
}
