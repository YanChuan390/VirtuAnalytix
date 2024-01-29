using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000006")]
	public static class Utils
	{
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x21BDFAC", Offset = "0x21BDFAC", VA = "0x21BDFAC")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CA8", Offset = "0xD08CA8")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x21B905C", Offset = "0x21B905C", VA = "0x21B905C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x21BCDC0", Offset = "0x21BCDC0", VA = "0x21BCDC0")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x21BCDDC", Offset = "0x21BCDDC", VA = "0x21BCDDC")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CB8", Offset = "0xD08CB8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x21B91C8", Offset = "0x21B91C8", VA = "0x21B91C8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x21BD030", Offset = "0x21BD030", VA = "0x21BD030")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x21BD054", Offset = "0x21BD054", VA = "0x21BD054")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CC8", Offset = "0xD08CC8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x21B930C", Offset = "0x21B930C", VA = "0x21B930C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x21BD6BC", Offset = "0x21BD6BC", VA = "0x21BD6BC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x21BD6E0", Offset = "0x21BD6E0", VA = "0x21BD6E0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CD8", Offset = "0xD08CD8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x21B9478", Offset = "0x21B9478", VA = "0x21B9478")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x21BDB88", Offset = "0x21BDB88", VA = "0x21BDB88")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x21BDBAC", Offset = "0x21BDBAC", VA = "0x21BDBAC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CE8", Offset = "0xD08CE8")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x21B95BC", Offset = "0x21B95BC", VA = "0x21B95BC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x21BDC98", Offset = "0x21BDC98", VA = "0x21BDC98")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x21BDCBC", Offset = "0x21BDCBC", VA = "0x21BDCBC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08CF8", Offset = "0xD08CF8")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x21B9724", Offset = "0x21B9724", VA = "0x21B9724")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x21BDCE0", Offset = "0x21BDCE0", VA = "0x21BDCE0")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x21BDCFC", Offset = "0x21BDCFC", VA = "0x21BDCFC")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D08", Offset = "0xD08D08")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x21B9A68", Offset = "0x21B9A68", VA = "0x21B9A68")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x21BDD18", Offset = "0x21BDD18", VA = "0x21BDD18")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x21BDD98", Offset = "0x21BDD98", VA = "0x21BDD98")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D18", Offset = "0xD08D18")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x21B9BCC", Offset = "0x21B9BCC", VA = "0x21B9BCC")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x21BDDF4", Offset = "0x21BDDF4", VA = "0x21BDDF4")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x21BDE74", Offset = "0x21BDE74", VA = "0x21BDE74")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D28", Offset = "0xD08D28")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x21B9D30", Offset = "0x21B9D30", VA = "0x21B9D30")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x21BDED0", Offset = "0x21BDED0", VA = "0x21BDED0")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x21BDF50", Offset = "0x21BDF50", VA = "0x21BDF50")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D38", Offset = "0xD08D38")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x21B9E9C", Offset = "0x21B9E9C", VA = "0x21B9E9C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x21BCDF8", Offset = "0x21BCDF8", VA = "0x21BCDF8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x21BCE18", Offset = "0x21BCE18", VA = "0x21BCE18")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D48", Offset = "0xD08D48")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x21B9FE0", Offset = "0x21B9FE0", VA = "0x21B9FE0")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x21BCE34", Offset = "0x21BCE34", VA = "0x21BCE34")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x21BCE54", Offset = "0x21BCE54", VA = "0x21BCE54")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D58", Offset = "0xD08D58")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x21BA134", Offset = "0x21BA134", VA = "0x21BA134")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x21BCE70", Offset = "0x21BCE70", VA = "0x21BCE70")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x21BCE8C", Offset = "0x21BCE8C", VA = "0x21BCE8C")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D68", Offset = "0xD08D68")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x21BA298", Offset = "0x21BA298", VA = "0x21BA298")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x21BCEA8", Offset = "0x21BCEA8", VA = "0x21BCEA8")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x21BCEC4", Offset = "0x21BCEC4", VA = "0x21BCEC4")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D78", Offset = "0xD08D78")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x21BA410", Offset = "0x21BA410", VA = "0x21BA410")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x21BCEE0", Offset = "0x21BCEE0", VA = "0x21BCEE0")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x21BCEFC", Offset = "0x21BCEFC", VA = "0x21BCEFC")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D88", Offset = "0xD08D88")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x21BA588", Offset = "0x21BA588", VA = "0x21BA588")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x21BCF18", Offset = "0x21BCF18", VA = "0x21BCF18")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x21BCF34", Offset = "0x21BCF34", VA = "0x21BCF34")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08D98", Offset = "0xD08D98")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x21BA6F4", Offset = "0x21BA6F4", VA = "0x21BA6F4")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x21BCF50", Offset = "0x21BCF50", VA = "0x21BCF50")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x21BCF6C", Offset = "0x21BCF6C", VA = "0x21BCF6C")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DA8", Offset = "0xD08DA8")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x21BA878", Offset = "0x21BA878", VA = "0x21BA878")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x21BCF88", Offset = "0x21BCF88", VA = "0x21BCF88")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x21BCFA4", Offset = "0x21BCFA4", VA = "0x21BCFA4")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DB8", Offset = "0xD08DB8")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x21BA9FC", Offset = "0x21BA9FC", VA = "0x21BA9FC")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x21BCFC0", Offset = "0x21BCFC0", VA = "0x21BCFC0")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x21BCFDC", Offset = "0x21BCFDC", VA = "0x21BCFDC")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DC8", Offset = "0xD08DC8")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x21BAB80", Offset = "0x21BAB80", VA = "0x21BAB80")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x21BCFF8", Offset = "0x21BCFF8", VA = "0x21BCFF8")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x21BD014", Offset = "0x21BD014", VA = "0x21BD014")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DD8", Offset = "0xD08DD8")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x21BACE4", Offset = "0x21BACE4", VA = "0x21BACE4")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x21BD078", Offset = "0x21BD078", VA = "0x21BD078")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x21BD094", Offset = "0x21BD094", VA = "0x21BD094")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DE8", Offset = "0xD08DE8")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x21BAE48", Offset = "0x21BAE48", VA = "0x21BAE48")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x21BD0B0", Offset = "0x21BD0B0", VA = "0x21BD0B0")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x21BD0CC", Offset = "0x21BD0CC", VA = "0x21BD0CC")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08DF8", Offset = "0xD08DF8")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x21BAF9C", Offset = "0x21BAF9C", VA = "0x21BAF9C")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x21BD0E8", Offset = "0x21BD0E8", VA = "0x21BD0E8")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x21BD104", Offset = "0x21BD104", VA = "0x21BD104")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E08", Offset = "0xD08E08")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x21BB108", Offset = "0x21BB108", VA = "0x21BB108")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x21BD120", Offset = "0x21BD120", VA = "0x21BD120")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x21BD13C", Offset = "0x21BD13C", VA = "0x21BD13C")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E18", Offset = "0xD08E18")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x21BB274", Offset = "0x21BB274", VA = "0x21BB274")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x21BD158", Offset = "0x21BD158", VA = "0x21BD158")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x21BD174", Offset = "0x21BD174", VA = "0x21BD174")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E28", Offset = "0xD08E28")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x21BB3D8", Offset = "0x21BB3D8", VA = "0x21BB3D8")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x21BD190", Offset = "0x21BD190", VA = "0x21BD190")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x21BD1AC", Offset = "0x21BD1AC", VA = "0x21BD1AC")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E38", Offset = "0xD08E38")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x21BB590", Offset = "0x21BB590", VA = "0x21BB590")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x21BD1C8", Offset = "0x21BD1C8", VA = "0x21BD1C8")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x21BD258", Offset = "0x21BD258", VA = "0x21BD258")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E48", Offset = "0xD08E48")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x21BB718", Offset = "0x21BB718", VA = "0x21BB718")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x21BD2FC", Offset = "0x21BD2FC", VA = "0x21BD2FC")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x21BD38C", Offset = "0x21BD38C", VA = "0x21BD38C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E58", Offset = "0xD08E58")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x21BB8EC", Offset = "0x21BB8EC", VA = "0x21BB8EC")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x21BD430", Offset = "0x21BD430", VA = "0x21BD430")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x21BD4C0", Offset = "0x21BD4C0", VA = "0x21BD4C0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E68", Offset = "0xD08E68")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x21BBC70", Offset = "0x21BBC70", VA = "0x21BBC70")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x21BD564", Offset = "0x21BD564", VA = "0x21BD564")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x21BD580", Offset = "0x21BD580", VA = "0x21BD580")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x21BD59C", Offset = "0x21BD59C", VA = "0x21BD59C")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x21BD5D0", Offset = "0x21BD5D0", VA = "0x21BD5D0")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x21BD5EC", Offset = "0x21BD5EC", VA = "0x21BD5EC")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x21BD608", Offset = "0x21BD608", VA = "0x21BD608")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E78", Offset = "0xD08E78")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x21BBDC8", Offset = "0x21BBDC8", VA = "0x21BBDC8")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x21BD704", Offset = "0x21BD704", VA = "0x21BD704")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x21BD774", Offset = "0x21BD774", VA = "0x21BD774")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E88", Offset = "0xD08E88")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x21BBF10", Offset = "0x21BBF10", VA = "0x21BBF10")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x21BD7C0", Offset = "0x21BD7C0", VA = "0x21BD7C0")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x21BD7DC", Offset = "0x21BD7DC", VA = "0x21BD7DC")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08E98", Offset = "0xD08E98")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x21BC058", Offset = "0x21BC058", VA = "0x21BC058")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x21BD7F8", Offset = "0x21BD7F8", VA = "0x21BD7F8")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x21BD814", Offset = "0x21BD814", VA = "0x21BD814")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08EA8", Offset = "0xD08EA8")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x21BC1AC", Offset = "0x21BC1AC", VA = "0x21BC1AC")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x21BD830", Offset = "0x21BD830", VA = "0x21BD830")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x21BD854", Offset = "0x21BD854", VA = "0x21BD854")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08EB8", Offset = "0xD08EB8")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x21BC318", Offset = "0x21BC318", VA = "0x21BC318")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x21BD878", Offset = "0x21BD878", VA = "0x21BD878")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x21BD89C", Offset = "0x21BD89C", VA = "0x21BD89C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08EC8", Offset = "0xD08EC8")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x21BC4BC", Offset = "0x21BC4BC", VA = "0x21BC4BC")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x21BD8C0", Offset = "0x21BD8C0", VA = "0x21BD8C0")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x21BD8C8", Offset = "0x21BD8C8", VA = "0x21BD8C8")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08ED8", Offset = "0xD08ED8")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x21BC600", Offset = "0x21BC600", VA = "0x21BC600")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x21BD968", Offset = "0x21BD968", VA = "0x21BD968")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x21BD98C", Offset = "0x21BD98C", VA = "0x21BD98C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08EE8", Offset = "0xD08EE8")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x21BC7DC", Offset = "0x21BC7DC", VA = "0x21BC7DC")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x21BD9B0", Offset = "0x21BD9B0", VA = "0x21BD9B0")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x21BD9D4", Offset = "0x21BD9D4", VA = "0x21BD9D4")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08EF8", Offset = "0xD08EF8")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x21BC9D0", Offset = "0x21BC9D0", VA = "0x21BC9D0")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x21BD9F8", Offset = "0x21BD9F8", VA = "0x21BD9F8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x21BDA04", Offset = "0x21BDA04", VA = "0x21BDA04")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F08", Offset = "0xD08F08")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x21BCBC4", Offset = "0x21BCBC4", VA = "0x21BCBC4")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x21BDAC0", Offset = "0x21BDAC0", VA = "0x21BDAC0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x21BDACC", Offset = "0x21BDACC", VA = "0x21BDACC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F18", Offset = "0xD08F18")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x21BCDB8", Offset = "0x21BCDB8", VA = "0x21BCDB8")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x21BDBD0", Offset = "0x21BDBD0", VA = "0x21BDBD0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x21BDBDC", Offset = "0x21BDBDC", VA = "0x21BDBDC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x21B8F20", Offset = "0x21B8F20", VA = "0x21B8F20")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x21B9064", Offset = "0x21B9064", VA = "0x21B9064")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x21B91D0", Offset = "0x21B91D0", VA = "0x21B91D0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x21B9314", Offset = "0x21B9314", VA = "0x21B9314")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x21B9480", Offset = "0x21B9480", VA = "0x21B9480")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x21B95C4", Offset = "0x21B95C4", VA = "0x21B95C4")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x21B972C", Offset = "0x21B972C", VA = "0x21B972C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x21B990C", Offset = "0x21B990C", VA = "0x21B990C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x21B9A70", Offset = "0x21B9A70", VA = "0x21B9A70")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x21B9BD4", Offset = "0x21B9BD4", VA = "0x21B9BD4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x21B9D38", Offset = "0x21B9D38", VA = "0x21B9D38")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x21B9EA4", Offset = "0x21B9EA4", VA = "0x21B9EA4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x21B9FE8", Offset = "0x21B9FE8", VA = "0x21B9FE8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x21BA13C", Offset = "0x21BA13C", VA = "0x21BA13C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x21BA2A0", Offset = "0x21BA2A0", VA = "0x21BA2A0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x21BA418", Offset = "0x21BA418", VA = "0x21BA418")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x21BA590", Offset = "0x21BA590", VA = "0x21BA590")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x21BA6FC", Offset = "0x21BA6FC", VA = "0x21BA6FC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x21BA880", Offset = "0x21BA880", VA = "0x21BA880")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x21BAA04", Offset = "0x21BAA04", VA = "0x21BAA04")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x21BAB88", Offset = "0x21BAB88", VA = "0x21BAB88")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x21BACEC", Offset = "0x21BACEC", VA = "0x21BACEC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x21BAE50", Offset = "0x21BAE50", VA = "0x21BAE50")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x21BAFA4", Offset = "0x21BAFA4", VA = "0x21BAFA4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x21BB110", Offset = "0x21BB110", VA = "0x21BB110")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x21BB27C", Offset = "0x21BB27C", VA = "0x21BB27C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x21BB3E0", Offset = "0x21BB3E0", VA = "0x21BB3E0")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x21BB598", Offset = "0x21BB598", VA = "0x21BB598")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x21BB720", Offset = "0x21BB720", VA = "0x21BB720")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x21BB8F4", Offset = "0x21BB8F4", VA = "0x21BB8F4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x21BBC78", Offset = "0x21BBC78", VA = "0x21BBC78")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x21BBDD0", Offset = "0x21BBDD0", VA = "0x21BBDD0")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x21BBF18", Offset = "0x21BBF18", VA = "0x21BBF18")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x21BC060", Offset = "0x21BC060", VA = "0x21BC060")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x21BC1B4", Offset = "0x21BC1B4", VA = "0x21BC1B4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x21BC320", Offset = "0x21BC320", VA = "0x21BC320")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x21BC4C4", Offset = "0x21BC4C4", VA = "0x21BC4C4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x21BC608", Offset = "0x21BC608", VA = "0x21BC608")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x21BC7E4", Offset = "0x21BC7E4", VA = "0x21BC7E4")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x21BC9D8", Offset = "0x21BC9D8", VA = "0x21BC9D8")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x21BCBCC", Offset = "0x21BCBCC", VA = "0x21BCBCC")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F28", Offset = "0xD08F28")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x21BECB4", Offset = "0x21BECB4", VA = "0x21BECB4")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x21BF444", Offset = "0x21BF444", VA = "0x21BF444")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x21BF468", Offset = "0x21BF468", VA = "0x21BF468")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F38", Offset = "0xD08F38")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x21BEE7C", Offset = "0x21BEE7C", VA = "0x21BEE7C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x21BF48C", Offset = "0x21BF48C", VA = "0x21BF48C")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x21BF4B0", Offset = "0x21BF4B0", VA = "0x21BF4B0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F48", Offset = "0xD08F48")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x21BF4D4", Offset = "0x21BF4D4", VA = "0x21BF4D4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x21BF718", Offset = "0x21BF718", VA = "0x21BF718", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F58", Offset = "0xD08F58")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
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

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x21BFE28", Offset = "0x21BFE28", VA = "0x21BFE28", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x21C0090", Offset = "0x21C0090", VA = "0x21C0090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F68", Offset = "0xD08F68")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
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

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x21BF97C", Offset = "0x21BF97C", VA = "0x21BF97C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x21BFBAC", Offset = "0x21BFBAC", VA = "0x21BFBAC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F78", Offset = "0xD08F78")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
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
		public int elapsedLoops;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x21BF724", Offset = "0x21BF724", VA = "0x21BF724", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x21BF970", Offset = "0x21BF970", VA = "0x21BF970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F88", Offset = "0xD08F88")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x21BFBB8", Offset = "0x21BFBB8", VA = "0x21BFBB8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x21BFE1C", Offset = "0x21BFE1C", VA = "0x21BFE1C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xD08F98", Offset = "0xD08F98")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x21C009C", Offset = "0x21C009C", VA = "0x21C009C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x21C02D4", Offset = "0x21C02D4", VA = "0x21C02D4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x21BE258", Offset = "0x21BE258", VA = "0x21BE258")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x21BE434", Offset = "0x21BE434", VA = "0x21BE434")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x21BE624", Offset = "0x21BE624", VA = "0x21BE624")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x21BE6EC", Offset = "0x21BE6EC", VA = "0x21BE6EC")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x21BE7B4", Offset = "0x21BE7B4", VA = "0x21BE7B4")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x21BE87C", Offset = "0x21BE87C", VA = "0x21BE87C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x21BE954", Offset = "0x21BE954", VA = "0x21BE954")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x21BEA2C", Offset = "0x21BEA2C", VA = "0x21BEA2C")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x21BEAF4", Offset = "0x21BEAF4", VA = "0x21BEAF4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x21BECBC", Offset = "0x21BECBC", VA = "0x21BECBC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x21BEE84", Offset = "0x21BEE84", VA = "0x21BEE84")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD092D8", Offset = "0xD092D8")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x21BEF74", Offset = "0x21BEF74", VA = "0x21BEF74")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD0934C", Offset = "0xD0934C")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x21BF064", Offset = "0x21BF064", VA = "0x21BF064")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD093C0", Offset = "0xD093C0")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x21BF154", Offset = "0x21BF154", VA = "0x21BF154")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD09434", Offset = "0xD09434")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x21BF254", Offset = "0x21BF254", VA = "0x21BF254")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD094A8", Offset = "0xD094A8")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x21BF354", Offset = "0x21BF354", VA = "0x21BF354")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xD0951C", Offset = "0xD0951C")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000037")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x21B8C60", Offset = "0x21B8C60", VA = "0x21B8C60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x21B8C94", Offset = "0x21B8C94", VA = "0x21B8C94")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000038")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x21B8E30", Offset = "0x21B8E30", VA = "0x21B8E30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x21B8E94", Offset = "0x21B8E94", VA = "0x21B8E94")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000039")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x21B8D48", Offset = "0x21B8D48", VA = "0x21B8D48", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x21B8D64", Offset = "0x21B8D64", VA = "0x21B8D64")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x200003A")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x21B8CC0", Offset = "0x21B8CC0", VA = "0x21B8CC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x21B8D0C", Offset = "0x21B8D0C", VA = "0x21B8D0C")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x200003B")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x21B8D90", Offset = "0x21B8D90", VA = "0x21B8D90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x21B8DF4", Offset = "0x21B8DF4", VA = "0x21B8DF4")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x200003C")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x21B8EC0", Offset = "0x21B8EC0", VA = "0x21B8EC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x21B8EF4", Offset = "0x21B8EF4", VA = "0x21B8EF4")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200003D")]
	public static class Physics
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x21C0424", Offset = "0x21C0424", VA = "0x21C0424")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x21C0440", Offset = "0x21C0440", VA = "0x21C0440")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x21C0448", Offset = "0x21C0448", VA = "0x21C0448")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x21C0450", Offset = "0x21C0450", VA = "0x21C0450")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x21C02E0", Offset = "0x21C02E0", VA = "0x21C02E0")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x21C0384", Offset = "0x21C0384", VA = "0x21C0384")]
	[Preserve]
	private static void Preserver()
	{
	}
}
