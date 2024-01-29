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
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566954", Offset = "0x566954")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x10251F0", Offset = "0x10251F0", VA = "0x10251F0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x102CB4C", Offset = "0x102CB4C", VA = "0x102CB4C")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566964", Offset = "0x566964")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x10253C8", Offset = "0x10253C8", VA = "0x10253C8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x102CC84", Offset = "0x102CC84", VA = "0x102CC84")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566974", Offset = "0x566974")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x10255A0", Offset = "0x10255A0", VA = "0x10255A0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x102CCA0", Offset = "0x102CCA0", VA = "0x102CCA0")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566984", Offset = "0x566984")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1025778", Offset = "0x1025778", VA = "0x1025778")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x102CCBC", Offset = "0x102CCBC", VA = "0x102CCBC")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566994", Offset = "0x566994")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1025780", Offset = "0x1025780", VA = "0x1025780")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x102CCD8", Offset = "0x102CCD8", VA = "0x102CCD8")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669A4", Offset = "0x5669A4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x10259DC", Offset = "0x10259DC", VA = "0x10259DC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x102CCF4", Offset = "0x102CCF4", VA = "0x102CCF4")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669B4", Offset = "0x5669B4")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 endValue;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Tween yTween;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1025F18", Offset = "0x1025F18", VA = "0x1025F18")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x102CD10", Offset = "0x102CD10", VA = "0x102CD10")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x102CD2C", Offset = "0x102CD2C", VA = "0x102CD2C")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x102CD60", Offset = "0x102CD60", VA = "0x102CD60")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x102CD7C", Offset = "0x102CD7C", VA = "0x102CD7C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x102CD98", Offset = "0x102CD98", VA = "0x102CD98")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669C4", Offset = "0x5669C4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x102619C", Offset = "0x102619C", VA = "0x102619C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x102CE58", Offset = "0x102CE58", VA = "0x102CE58")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669D4", Offset = "0x5669D4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1026440", Offset = "0x1026440", VA = "0x1026440")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x102CE74", Offset = "0x102CE74", VA = "0x102CE74")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x102CE90", Offset = "0x102CE90", VA = "0x102CE90")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669E4", Offset = "0x5669E4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1026638", Offset = "0x1026638", VA = "0x1026638")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x102CF90", Offset = "0x102CF90", VA = "0x102CF90")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5669F4", Offset = "0x5669F4")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1026850", Offset = "0x1026850", VA = "0x1026850")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x102CB68", Offset = "0x102CB68", VA = "0x102CB68")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x102CB84", Offset = "0x102CB84", VA = "0x102CB84")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1022508", Offset = "0x1022508", VA = "0x1022508")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x10251F8", Offset = "0x10251F8", VA = "0x10251F8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x10253D0", Offset = "0x10253D0", VA = "0x10253D0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x10255A8", Offset = "0x10255A8", VA = "0x10255A8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x10226E4", Offset = "0x10226E4", VA = "0x10226E4")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1025788", Offset = "0x1025788", VA = "0x1025788")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x10259E4", Offset = "0x10259E4", VA = "0x10259E4")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1025F20", Offset = "0x1025F20", VA = "0x1025F20")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x10261A4", Offset = "0x10261A4", VA = "0x10261A4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1026448", Offset = "0x1026448", VA = "0x1026448")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1026640", Offset = "0x1026640", VA = "0x1026640")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200000E")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A14", Offset = "0x566A14")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1026858", Offset = "0x1026858", VA = "0x1026858")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x102CFAC", Offset = "0x102CFAC", VA = "0x102CFAC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x102CFC8", Offset = "0x102CFC8", VA = "0x102CFC8")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A24", Offset = "0x566A24")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1026860", Offset = "0x1026860", VA = "0x1026860")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x102CFE4", Offset = "0x102CFE4", VA = "0x102CFE4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x102D000", Offset = "0x102D000", VA = "0x102D000")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A34", Offset = "0x566A34")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1026CB0", Offset = "0x1026CB0", VA = "0x1026CB0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x102D01C", Offset = "0x102D01C", VA = "0x102D01C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x102D028", Offset = "0x102D028", VA = "0x102D028")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x1022A8C", Offset = "0x1022A8C", VA = "0x1022A8C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1022FFC", Offset = "0x1022FFC", VA = "0x1022FFC")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1026868", Offset = "0x1026868", VA = "0x1026868")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1026A54", Offset = "0x1026A54", VA = "0x1026A54")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000013")]
	public static class Utils
	{
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x10220EC", Offset = "0x10220EC", VA = "0x10220EC")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A54", Offset = "0x566A54")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1026CB8", Offset = "0x1026CB8", VA = "0x1026CB8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x102D0D4", Offset = "0x102D0D4", VA = "0x102D0D4")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x102D0F0", Offset = "0x102D0F0", VA = "0x102D0F0")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A64", Offset = "0x566A64")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1026CC0", Offset = "0x1026CC0", VA = "0x1026CC0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x102D344", Offset = "0x102D344", VA = "0x102D344")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x102D368", Offset = "0x102D368", VA = "0x102D368")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A74", Offset = "0x566A74")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1026CC8", Offset = "0x1026CC8", VA = "0x1026CC8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x102D700", Offset = "0x102D700", VA = "0x102D700")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x102D724", Offset = "0x102D724", VA = "0x102D724")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A84", Offset = "0x566A84")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1026EA0", Offset = "0x1026EA0", VA = "0x1026EA0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x102DBAC", Offset = "0x102DBAC", VA = "0x102DBAC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x102DBD0", Offset = "0x102DBD0", VA = "0x102DBD0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566A94", Offset = "0x566A94")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1027050", Offset = "0x1027050", VA = "0x1027050")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x102DCF4", Offset = "0x102DCF4", VA = "0x102DCF4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x102DD18", Offset = "0x102DD18", VA = "0x102DD18")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AA4", Offset = "0x566AA4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1027224", Offset = "0x1027224", VA = "0x1027224")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x102DD3C", Offset = "0x102DD3C", VA = "0x102DD3C")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x102DD58", Offset = "0x102DD58", VA = "0x102DD58")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AB4", Offset = "0x566AB4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x10275F0", Offset = "0x10275F0", VA = "0x10275F0")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x102DD74", Offset = "0x102DD74", VA = "0x102DD74")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x102DDD8", Offset = "0x102DDD8", VA = "0x102DDD8")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AC4", Offset = "0x566AC4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x10277C8", Offset = "0x10277C8", VA = "0x10277C8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x102DE34", Offset = "0x102DE34", VA = "0x102DE34")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x102DE98", Offset = "0x102DE98", VA = "0x102DE98")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AD4", Offset = "0x566AD4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x10279A0", Offset = "0x10279A0", VA = "0x10279A0")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x102DEF4", Offset = "0x102DEF4", VA = "0x102DEF4")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x102DF58", Offset = "0x102DF58", VA = "0x102DF58")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AE4", Offset = "0x566AE4")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1027B78", Offset = "0x1027B78", VA = "0x1027B78")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x102D10C", Offset = "0x102D10C", VA = "0x102D10C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x102D12C", Offset = "0x102D12C", VA = "0x102D12C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566AF4", Offset = "0x566AF4")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1027D28", Offset = "0x1027D28", VA = "0x1027D28")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x102D148", Offset = "0x102D148", VA = "0x102D148")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x102D168", Offset = "0x102D168", VA = "0x102D168")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B04", Offset = "0x566B04")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1027EE8", Offset = "0x1027EE8", VA = "0x1027EE8")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x102D184", Offset = "0x102D184", VA = "0x102D184")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x102D1A0", Offset = "0x102D1A0", VA = "0x102D1A0")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B14", Offset = "0x566B14")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x10280C0", Offset = "0x10280C0", VA = "0x10280C0")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x102D1BC", Offset = "0x102D1BC", VA = "0x102D1BC")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x102D1D8", Offset = "0x102D1D8", VA = "0x102D1D8")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B24", Offset = "0x566B24")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1028290", Offset = "0x1028290", VA = "0x1028290")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x102D1F4", Offset = "0x102D1F4", VA = "0x102D1F4")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x102D210", Offset = "0x102D210", VA = "0x102D210")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B34", Offset = "0x566B34")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1028460", Offset = "0x1028460", VA = "0x1028460")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x102D22C", Offset = "0x102D22C", VA = "0x102D22C")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x102D248", Offset = "0x102D248", VA = "0x102D248")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B44", Offset = "0x566B44")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1028468", Offset = "0x1028468", VA = "0x1028468")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x102D264", Offset = "0x102D264", VA = "0x102D264")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x102D280", Offset = "0x102D280", VA = "0x102D280")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B54", Offset = "0x566B54")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x102863C", Offset = "0x102863C", VA = "0x102863C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x102D29C", Offset = "0x102D29C", VA = "0x102D29C")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x102D2B8", Offset = "0x102D2B8", VA = "0x102D2B8")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B64", Offset = "0x566B64")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1028810", Offset = "0x1028810", VA = "0x1028810")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x102D2D4", Offset = "0x102D2D4", VA = "0x102D2D4")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x102D2F0", Offset = "0x102D2F0", VA = "0x102D2F0")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B74", Offset = "0x566B74")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x10289E4", Offset = "0x10289E4", VA = "0x10289E4")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x102D30C", Offset = "0x102D30C", VA = "0x102D30C")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x102D328", Offset = "0x102D328", VA = "0x102D328")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B84", Offset = "0x566B84")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1028BBC", Offset = "0x1028BBC", VA = "0x1028BBC")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x102D38C", Offset = "0x102D38C", VA = "0x102D38C")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x102D3A8", Offset = "0x102D3A8", VA = "0x102D3A8")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566B94", Offset = "0x566B94")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1028D94", Offset = "0x1028D94", VA = "0x1028D94")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x102D3C4", Offset = "0x102D3C4", VA = "0x102D3C4")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x102D3E0", Offset = "0x102D3E0", VA = "0x102D3E0")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BA4", Offset = "0x566BA4")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1028F54", Offset = "0x1028F54", VA = "0x1028F54")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x102D3FC", Offset = "0x102D3FC", VA = "0x102D3FC")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x102D418", Offset = "0x102D418", VA = "0x102D418")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BB4", Offset = "0x566BB4")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1029118", Offset = "0x1029118", VA = "0x1029118")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x102D434", Offset = "0x102D434", VA = "0x102D434")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x102D450", Offset = "0x102D450", VA = "0x102D450")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BC4", Offset = "0x566BC4")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x10292DC", Offset = "0x10292DC", VA = "0x10292DC")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x102D46C", Offset = "0x102D46C", VA = "0x102D46C")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x102D488", Offset = "0x102D488", VA = "0x102D488")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BD4", Offset = "0x566BD4")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x10292E4", Offset = "0x10292E4", VA = "0x10292E4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x102D4A4", Offset = "0x102D4A4", VA = "0x102D4A4")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x102D4C0", Offset = "0x102D4C0", VA = "0x102D4C0")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BE4", Offset = "0x566BE4")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x10292EC", Offset = "0x10292EC", VA = "0x10292EC")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x102D4DC", Offset = "0x102D4DC", VA = "0x102D4DC")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x102D504", Offset = "0x102D504", VA = "0x102D504")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566BF4", Offset = "0x566BF4")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x10294FC", Offset = "0x10294FC", VA = "0x10294FC")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x102D520", Offset = "0x102D520", VA = "0x102D520")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x102D548", Offset = "0x102D548", VA = "0x102D548")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C04", Offset = "0x566C04")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1029504", Offset = "0x1029504", VA = "0x1029504")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x102D564", Offset = "0x102D564", VA = "0x102D564")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x102D58C", Offset = "0x102D58C", VA = "0x102D58C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C14", Offset = "0x566C14")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1029960", Offset = "0x1029960", VA = "0x1029960")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x102D5A8", Offset = "0x102D5A8", VA = "0x102D5A8")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x102D5C4", Offset = "0x102D5C4", VA = "0x102D5C4")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x102D5E0", Offset = "0x102D5E0", VA = "0x102D5E0")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x102D614", Offset = "0x102D614", VA = "0x102D614")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x102D630", Offset = "0x102D630", VA = "0x102D630")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x102D64C", Offset = "0x102D64C", VA = "0x102D64C")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C24", Offset = "0x566C24")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1029B2C", Offset = "0x1029B2C", VA = "0x1029B2C")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x102D748", Offset = "0x102D748", VA = "0x102D748")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x102D79C", Offset = "0x102D79C", VA = "0x102D79C")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C34", Offset = "0x566C34")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1029CE8", Offset = "0x1029CE8", VA = "0x1029CE8")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x102D7E8", Offset = "0x102D7E8", VA = "0x102D7E8")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x102D804", Offset = "0x102D804", VA = "0x102D804")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C44", Offset = "0x566C44")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1029EA4", Offset = "0x1029EA4", VA = "0x1029EA4")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x102D820", Offset = "0x102D820", VA = "0x102D820")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x102D83C", Offset = "0x102D83C", VA = "0x102D83C")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C54", Offset = "0x566C54")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x102A06C", Offset = "0x102A06C", VA = "0x102A06C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x102D858", Offset = "0x102D858", VA = "0x102D858")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x102D87C", Offset = "0x102D87C", VA = "0x102D87C")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C64", Offset = "0x566C64")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x102A074", Offset = "0x102A074", VA = "0x102A074")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x102D8A0", Offset = "0x102D8A0", VA = "0x102D8A0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x102D8C4", Offset = "0x102D8C4", VA = "0x102D8C4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C74", Offset = "0x566C74")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x102A2A4", Offset = "0x102A2A4", VA = "0x102A2A4")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x102D8E8", Offset = "0x102D8E8", VA = "0x102D8E8")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x102D8F0", Offset = "0x102D8F0", VA = "0x102D8F0")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C84", Offset = "0x566C84")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x102A2AC", Offset = "0x102A2AC", VA = "0x102A2AC")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x102D98C", Offset = "0x102D98C", VA = "0x102D98C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x102D9B0", Offset = "0x102D9B0", VA = "0x102D9B0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566C94", Offset = "0x566C94")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x102A2B4", Offset = "0x102A2B4", VA = "0x102A2B4")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x102D9D4", Offset = "0x102D9D4", VA = "0x102D9D4")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x102D9F8", Offset = "0x102D9F8", VA = "0x102D9F8")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566CA4", Offset = "0x566CA4")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x102A520", Offset = "0x102A520", VA = "0x102A520")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x102DA1C", Offset = "0x102DA1C", VA = "0x102DA1C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x102DA28", Offset = "0x102DA28", VA = "0x102DA28")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566CB4", Offset = "0x566CB4")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x102A78C", Offset = "0x102A78C", VA = "0x102A78C")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x102DAE4", Offset = "0x102DAE4", VA = "0x102DAE4")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x102DAF0", Offset = "0x102DAF0", VA = "0x102DAF0")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566CC4", Offset = "0x566CC4")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x102A9F8", Offset = "0x102A9F8", VA = "0x102A9F8")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x102DBF4", Offset = "0x102DBF4", VA = "0x102DBF4")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x102DC00", Offset = "0x102DC00", VA = "0x102DC00")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566CD4", Offset = "0x566CD4")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x102AC10", Offset = "0x102AC10", VA = "0x102AC10")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x102DCBC", Offset = "0x102DCBC", VA = "0x102DCBC")]
		internal Vector2 <DOShapeCircle>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x102DCD8", Offset = "0x102DCD8", VA = "0x102DCD8")]
		internal void <DOShapeCircle>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x10234F4", Offset = "0x10234F4", VA = "0x10234F4")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1022C5C", Offset = "0x1022C5C", VA = "0x1022C5C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x10231A4", Offset = "0x10231A4", VA = "0x10231A4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1026CD0", Offset = "0x1026CD0", VA = "0x1026CD0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1026EA8", Offset = "0x1026EA8", VA = "0x1026EA8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1027058", Offset = "0x1027058", VA = "0x1027058")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x102722C", Offset = "0x102722C", VA = "0x102722C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1027420", Offset = "0x1027420", VA = "0x1027420")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x10275F8", Offset = "0x10275F8", VA = "0x10275F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x10277D0", Offset = "0x10277D0", VA = "0x10277D0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x10279A8", Offset = "0x10279A8", VA = "0x10279A8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x1027B80", Offset = "0x1027B80", VA = "0x1027B80")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1027D30", Offset = "0x1027D30", VA = "0x1027D30")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1027EF0", Offset = "0x1027EF0", VA = "0x1027EF0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x10280C8", Offset = "0x10280C8", VA = "0x10280C8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1028298", Offset = "0x1028298", VA = "0x1028298")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1022330", Offset = "0x1022330", VA = "0x1022330")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1028470", Offset = "0x1028470", VA = "0x1028470")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1028644", Offset = "0x1028644", VA = "0x1028644")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1028818", Offset = "0x1028818", VA = "0x1028818")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10289EC", Offset = "0x10289EC", VA = "0x10289EC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1028BC4", Offset = "0x1028BC4", VA = "0x1028BC4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1028D9C", Offset = "0x1028D9C", VA = "0x1028D9C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1028F5C", Offset = "0x1028F5C", VA = "0x1028F5C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1029120", Offset = "0x1029120", VA = "0x1029120")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x10228BC", Offset = "0x10228BC", VA = "0x10228BC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x10238F0", Offset = "0x10238F0", VA = "0x10238F0")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x10292F4", Offset = "0x10292F4", VA = "0x10292F4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1023AC8", Offset = "0x1023AC8", VA = "0x1023AC8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x102950C", Offset = "0x102950C", VA = "0x102950C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1029968", Offset = "0x1029968", VA = "0x1029968")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1029B34", Offset = "0x1029B34", VA = "0x1029B34")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1029CF0", Offset = "0x1029CF0", VA = "0x1029CF0")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1029EAC", Offset = "0x1029EAC", VA = "0x1029EAC")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x1022E2C", Offset = "0x1022E2C", VA = "0x1022E2C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x102A07C", Offset = "0x102A07C", VA = "0x102A07C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x102334C", Offset = "0x102334C", VA = "0x102334C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x102369C", Offset = "0x102369C", VA = "0x102369C")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x102A2BC", Offset = "0x102A2BC", VA = "0x102A2BC")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x102A528", Offset = "0x102A528", VA = "0x102A528")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x102A794", Offset = "0x102A794", VA = "0x102A794")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x102AA00", Offset = "0x102AA00", VA = "0x102AA00")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x200003D")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566CF4", Offset = "0x566CF4")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x102B87C", Offset = "0x102B87C", VA = "0x102B87C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x102DFB4", Offset = "0x102DFB4", VA = "0x102DFB4")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x102DFD8", Offset = "0x102DFD8", VA = "0x102DFD8")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D04", Offset = "0x566D04")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x102BAAC", Offset = "0x102BAAC", VA = "0x102BAAC")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x102DFFC", Offset = "0x102DFFC", VA = "0x102DFFC")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x102E020", Offset = "0x102E020", VA = "0x102E020")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D14", Offset = "0x566D14")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x102E044", Offset = "0x102E044", VA = "0x102E044", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x102E288", Offset = "0x102E288", VA = "0x102E288", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D24", Offset = "0x566D24")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x102E998", Offset = "0x102E998", VA = "0x102E998", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x102EC00", Offset = "0x102EC00", VA = "0x102EC00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D34", Offset = "0x566D34")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x102E4EC", Offset = "0x102E4EC", VA = "0x102E4EC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x102E71C", Offset = "0x102E71C", VA = "0x102E71C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D44", Offset = "0x566D44")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x102E294", Offset = "0x102E294", VA = "0x102E294", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x102E4E0", Offset = "0x102E4E0", VA = "0x102E4E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D54", Offset = "0x566D54")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x102E728", Offset = "0x102E728", VA = "0x102E728", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x102E98C", Offset = "0x102E98C", VA = "0x102E98C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566D64", Offset = "0x566D64")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x102EC0C", Offset = "0x102EC0C", VA = "0x102EC0C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x102EE44", Offset = "0x102EE44", VA = "0x102EE44", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x102AC18", Offset = "0x102AC18", VA = "0x102AC18")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x102AE08", Offset = "0x102AE08", VA = "0x102AE08")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x102B00C", Offset = "0x102B00C", VA = "0x102B00C")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x102B10C", Offset = "0x102B10C", VA = "0x102B10C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x102B20C", Offset = "0x102B20C", VA = "0x102B20C")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x102B30C", Offset = "0x102B30C", VA = "0x102B30C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x102B430", Offset = "0x102B430", VA = "0x102B430")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x102B554", Offset = "0x102B554", VA = "0x102B554")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x102B654", Offset = "0x102B654", VA = "0x102B654")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x102B884", Offset = "0x102B884", VA = "0x102B884")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x102BAB4", Offset = "0x102BAB4", VA = "0x102BAB4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x56722C", Offset = "0x56722C")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x102BBD0", Offset = "0x102BBD0", VA = "0x102BBD0")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x56729C", Offset = "0x56729C")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x102BCEC", Offset = "0x102BCEC", VA = "0x102BCEC")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x56730C", Offset = "0x56730C")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x102BE08", Offset = "0x102BE08", VA = "0x102BE08")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x56737C", Offset = "0x56737C")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x102BF34", Offset = "0x102BF34", VA = "0x102BF34")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x5673EC", Offset = "0x5673EC")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x102C060", Offset = "0x102C060", VA = "0x102C060")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x56745C", Offset = "0x56745C")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000046")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000047")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x102C9B4", Offset = "0x102C9B4", VA = "0x102C9B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x102B0D8", Offset = "0x102B0D8", VA = "0x102B0D8")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000048")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x102CAB4", Offset = "0x102CAB4", VA = "0x102CAB4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x102B1D8", Offset = "0x102B1D8", VA = "0x102B1D8")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000049")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x102CA34", Offset = "0x102CA34", VA = "0x102CA34", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x102B2D8", Offset = "0x102B2D8", VA = "0x102B2D8")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x200004A")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x102C9E8", Offset = "0x102C9E8", VA = "0x102C9E8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x102B3E8", Offset = "0x102B3E8", VA = "0x102B3E8")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x200004B")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x102CA50", Offset = "0x102CA50", VA = "0x102CA50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x102B50C", Offset = "0x102B50C", VA = "0x102B50C")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x200004C")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x102CB18", Offset = "0x102CB18", VA = "0x102CB18", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x102B620", Offset = "0x102B620", VA = "0x102B620")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x200004D")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200004E")]
	public static class Physics
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x102EE50", Offset = "0x102EE50", VA = "0x102EE50")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x102EF54", Offset = "0x102EF54", VA = "0x102EF54")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x102EF5C", Offset = "0x102EF5C", VA = "0x102EF5C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x102EFF4", Offset = "0x102EFF4", VA = "0x102EFF4")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x102C17C", Offset = "0x102C17C", VA = "0x102C17C")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x102C240", Offset = "0x102C240", VA = "0x102C240")]
	[Preserve]
	private static void Preserver()
	{
	}
}
[Token(Token = "0x200004F")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x566D74", Offset = "0x566D74")]
public class DOTweenAnimation : ABSAnimationComponent
{
	[Token(Token = "0x2000050")]
	public enum AnimationType
	{
		[Token(Token = "0x400009D")]
		None,
		[Token(Token = "0x400009E")]
		Move,
		[Token(Token = "0x400009F")]
		LocalMove,
		[Token(Token = "0x40000A0")]
		Rotate,
		[Token(Token = "0x40000A1")]
		LocalRotate,
		[Token(Token = "0x40000A2")]
		Scale,
		[Token(Token = "0x40000A3")]
		Color,
		[Token(Token = "0x40000A4")]
		Fade,
		[Token(Token = "0x40000A5")]
		Text,
		[Token(Token = "0x40000A6")]
		PunchPosition,
		[Token(Token = "0x40000A7")]
		PunchRotation,
		[Token(Token = "0x40000A8")]
		PunchScale,
		[Token(Token = "0x40000A9")]
		ShakePosition,
		[Token(Token = "0x40000AA")]
		ShakeRotation,
		[Token(Token = "0x40000AB")]
		ShakeScale,
		[Token(Token = "0x40000AC")]
		CameraAspect,
		[Token(Token = "0x40000AD")]
		CameraBackgroundColor,
		[Token(Token = "0x40000AE")]
		CameraFieldOfView,
		[Token(Token = "0x40000AF")]
		CameraOrthoSize,
		[Token(Token = "0x40000B0")]
		CameraPixelRect,
		[Token(Token = "0x40000B1")]
		CameraRect,
		[Token(Token = "0x40000B2")]
		UIWidthHeight
	}

	[Token(Token = "0x2000051")]
	public enum TargetType
	{
		[Token(Token = "0x40000B4")]
		Unset,
		[Token(Token = "0x40000B5")]
		Camera,
		[Token(Token = "0x40000B6")]
		CanvasGroup,
		[Token(Token = "0x40000B7")]
		Image,
		[Token(Token = "0x40000B8")]
		Light,
		[Token(Token = "0x40000B9")]
		RectTransform,
		[Token(Token = "0x40000BA")]
		Renderer,
		[Token(Token = "0x40000BB")]
		SpriteRenderer,
		[Token(Token = "0x40000BC")]
		Rigidbody,
		[Token(Token = "0x40000BD")]
		Rigidbody2D,
		[Token(Token = "0x40000BE")]
		Text,
		[Token(Token = "0x40000BF")]
		Transform,
		[Token(Token = "0x40000C0")]
		tk2dBaseSprite,
		[Token(Token = "0x40000C1")]
		tk2dTextMesh,
		[Token(Token = "0x40000C2")]
		TextMeshPro,
		[Token(Token = "0x40000C3")]
		TextMeshProUGUI
	}

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool targetIsSelf;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject targetGO;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool tweenTargetIsTargetGO;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float delay;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float duration;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Ease easeType;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve easeCurve;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LoopType loopType;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int loops;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string id;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isRelative;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool isFrom;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool isIndependentUpdate;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	public bool autoKill;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool autoGenerate;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool isActive;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
	public bool isValid;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Component target;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AnimationType animationType;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public TargetType targetType;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TargetType forcedTargetType;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool autoPlay;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool useTargetAsV3;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float endValueFloat;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Vector3 endValueV3;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Vector2 endValueV2;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Color endValueColor;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string endValueString;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Rect endValueRect;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform endValueTransform;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool optionalBool0;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	public bool optionalBool1;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float optionalFloat0;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int optionalInt0;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public RotateMode optionalRotationMode;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ScrambleMode optionalScrambleMode;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public ShakeRandomnessMode optionalShakeRandomnessMode;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string optionalString;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _tweenAutoGenerationCalled;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int _playCount;

	[Token(Token = "0x14000001")]
	public static event Action<DOTweenAnimation> OnReset
	{
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x10205B4", Offset = "0x10205B4", VA = "0x10205B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56756C", Offset = "0x56756C")]
		add
		{
		}
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1020670", Offset = "0x1020670", VA = "0x1020670")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56757C", Offset = "0x56757C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x102072C", Offset = "0x102072C", VA = "0x102072C")]
	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x10207A8", Offset = "0x10207A8", VA = "0x10207A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1021D7C", Offset = "0x1021D7C", VA = "0x1021D7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1021DC8", Offset = "0x1021DC8", VA = "0x1021DC8")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1021DCC", Offset = "0x1021DCC", VA = "0x1021DCC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1021E10", Offset = "0x1021E10", VA = "0x1021E10")]
	public void RewindThenRecreateTween()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1021E54", Offset = "0x1021E54", VA = "0x1021E54")]
	public void RewindThenRecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1021E98", Offset = "0x1021E98", VA = "0x1021E98")]
	public void RecreateTween()
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1021EA4", Offset = "0x1021EA4", VA = "0x1021EA4")]
	public void RecreateTweenAndPlay()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1020800", Offset = "0x1020800", VA = "0x1020800")]
	public void CreateTween(bool regenerateIfExists = false, bool andPlay = true)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x1023CF8", Offset = "0x1023CF8", VA = "0x1023CF8")]
	public List<Tween> GetTweens()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x1023E10", Offset = "0x1023E10", VA = "0x1023E10")]
	public void SetAnimationTarget(Component tweenTarget, bool useTweenTargetGameObjectForGroupOperations = true)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1023F08", Offset = "0x1023F08", VA = "0x1023F08", Slot = "4")]
	public override void DOPlay()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1023F94", Offset = "0x1023F94", VA = "0x1023F94", Slot = "5")]
	public override void DOPlayBackwards()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1024020", Offset = "0x1024020", VA = "0x1024020", Slot = "6")]
	public override void DOPlayForward()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x10240AC", Offset = "0x10240AC", VA = "0x10240AC", Slot = "7")]
	public override void DOPause()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1024138", Offset = "0x1024138", VA = "0x1024138", Slot = "8")]
	public override void DOTogglePause()
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x10241C4", Offset = "0x10241C4", VA = "0x10241C4", Slot = "9")]
	public override void DORewind()
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x10242BC", Offset = "0x10242BC", VA = "0x10242BC", Slot = "10")]
	public override void DORestart()
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x10242CC", Offset = "0x10242CC", VA = "0x10242CC", Slot = "11")]
	public override void DORestart(bool fromHere)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x102465C", Offset = "0x102465C", VA = "0x102465C", Slot = "12")]
	public override void DOComplete()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x10246EC", Offset = "0x10246EC", VA = "0x10246EC", Slot = "13")]
	public override void DOKill()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x102478C", Offset = "0x102478C", VA = "0x102478C")]
	public void DOPlayById(string id)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1024828", Offset = "0x1024828", VA = "0x1024828")]
	public void DOPlayAllById(string id)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x102488C", Offset = "0x102488C", VA = "0x102488C")]
	public void DOPauseAllById(string id)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x10248F0", Offset = "0x10248F0", VA = "0x10248F0")]
	public void DOPlayBackwardsById(string id)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x102498C", Offset = "0x102498C", VA = "0x102498C")]
	public void DOPlayBackwardsAllById(string id)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x10249F0", Offset = "0x10249F0", VA = "0x10249F0")]
	public void DOPlayForwardById(string id)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1024A8C", Offset = "0x1024A8C", VA = "0x1024A8C")]
	public void DOPlayForwardAllById(string id)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x1024AF0", Offset = "0x1024AF0", VA = "0x1024AF0")]
	public void DOPlayNext()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1024C40", Offset = "0x1024C40", VA = "0x1024C40")]
	public void DORewindAndPlayNext()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1024CE0", Offset = "0x1024CE0", VA = "0x1024CE0")]
	public void DORewindAllById(string id)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x1024D5C", Offset = "0x1024D5C", VA = "0x1024D5C")]
	public void DORestartById(string id)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x1024E08", Offset = "0x1024E08", VA = "0x1024E08")]
	public void DORestartAllById(string id)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x1024E88", Offset = "0x1024E88", VA = "0x1024E88")]
	public void DOKillById(string id)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x1024F28", Offset = "0x1024F28", VA = "0x1024F28")]
	public void DOKillAllById(string id)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x1021EC8", Offset = "0x1021EC8", VA = "0x1021EC8")]
	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x1024F90", Offset = "0x1024F90", VA = "0x1024F90")]
	public Tween CreateEditorPreview()
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x1021EB0", Offset = "0x1021EB0", VA = "0x1021EB0")]
	private GameObject GetTweenGO()
	{
		return null;
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x1023CD8", Offset = "0x1023CD8", VA = "0x1023CD8")]
	private GameObject GetTweenTarget()
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x10243F4", Offset = "0x10243F4", VA = "0x10243F4")]
	private void ReEvaluateRelativeTween()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x1024FD4", Offset = "0x1024FD4", VA = "0x1024FD4")]
	public DOTweenAnimation()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x10251E4", Offset = "0x10251E4", VA = "0x10251E4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56758C", Offset = "0x56758C")]
	private void <CreateTween>b__54_0()
	{
	}
}
[Token(Token = "0x2000052")]
public static class DOTweenAnimationExtensions
{
	[Token(Token = "0x6000140")]
	public static bool IsSameOrSubclassOf<T>(this Component t)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000053")]
public static class DOTweenProShortcuts
{
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566DCC", Offset = "0x566DCC")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x102C670", Offset = "0x102C670", VA = "0x102C670")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x102F144", Offset = "0x102F144", VA = "0x102F144")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x102F160", Offset = "0x102F160", VA = "0x102F160")]
		internal void <DOSpiral>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000055")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x566DDC", Offset = "0x566DDC")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x102C9AC", Offset = "0x102C9AC", VA = "0x102C9AC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x102F17C", Offset = "0x102F17C", VA = "0x102F17C")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x102C2F4", Offset = "0x102C2F4", VA = "0x102C2F4")]
	static DOTweenProShortcuts()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x102C340", Offset = "0x102C340", VA = "0x102C340")]
	public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x102C678", Offset = "0x102C678", VA = "0x102C678")]
	public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}
}
