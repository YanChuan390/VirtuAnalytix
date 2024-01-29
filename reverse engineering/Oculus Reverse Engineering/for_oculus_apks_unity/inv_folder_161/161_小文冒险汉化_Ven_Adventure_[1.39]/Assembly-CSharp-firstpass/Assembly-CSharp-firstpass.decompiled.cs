using System;
using System.Collections.Generic;
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
using UnityEngine.UI;

[assembly: AssemblyVersion("3.7.1.6")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF167D0", Offset = "0xF167D0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2736564", Offset = "0x2736564", VA = "0x2736564")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x2737870", Offset = "0x2737870", VA = "0x2737870")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF167E0", Offset = "0xF167E0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2736704", Offset = "0x2736704", VA = "0x2736704")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x27379AC", Offset = "0x27379AC", VA = "0x27379AC")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF167F0", Offset = "0xF167F0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x27368A4", Offset = "0x27368A4", VA = "0x27368A4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x27379C8", Offset = "0x27379C8", VA = "0x27379C8")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16800", Offset = "0xF16800")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x2736A44", Offset = "0x2736A44", VA = "0x2736A44")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x27379E4", Offset = "0x27379E4", VA = "0x27379E4")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16810", Offset = "0xF16810")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x2736A4C", Offset = "0x2736A4C", VA = "0x2736A4C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2737A00", Offset = "0x2737A00", VA = "0x2737A00")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16820", Offset = "0xF16820")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2736C48", Offset = "0x2736C48", VA = "0x2736C48")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x2737A1C", Offset = "0x2737A1C", VA = "0x2737A1C")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16830", Offset = "0xF16830")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 endValue;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Tween yTween;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x2737100", Offset = "0x2737100", VA = "0x2737100")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2737A38", Offset = "0x2737A38", VA = "0x2737A38")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2737A54", Offset = "0x2737A54", VA = "0x2737A54")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2737A88", Offset = "0x2737A88", VA = "0x2737A88")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2737AA4", Offset = "0x2737AA4", VA = "0x2737AA4")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2737AC0", Offset = "0x2737AC0", VA = "0x2737AC0")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16840", Offset = "0xF16840")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x2737304", Offset = "0x2737304", VA = "0x2737304")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x2737B80", Offset = "0x2737B80", VA = "0x2737B80")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16850", Offset = "0xF16850")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x2737528", Offset = "0x2737528", VA = "0x2737528")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2737B9C", Offset = "0x2737B9C", VA = "0x2737B9C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2737BB8", Offset = "0x2737BB8", VA = "0x2737BB8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16860", Offset = "0xF16860")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x27376B8", Offset = "0x27376B8", VA = "0x27376B8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2737CBC", Offset = "0x2737CBC", VA = "0x2737CBC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16870", Offset = "0xF16870")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2737868", Offset = "0x2737868", VA = "0x2737868")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x273788C", Offset = "0x273788C", VA = "0x273788C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x27378A8", Offset = "0x27378A8", VA = "0x27378A8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2733A10", Offset = "0x2733A10", VA = "0x2733A10")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x273656C", Offset = "0x273656C", VA = "0x273656C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x273670C", Offset = "0x273670C", VA = "0x273670C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x27368AC", Offset = "0x27368AC", VA = "0x27368AC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2733D08", Offset = "0x2733D08", VA = "0x2733D08")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2736A54", Offset = "0x2736A54", VA = "0x2736A54")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2736C50", Offset = "0x2736C50", VA = "0x2736C50")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2737108", Offset = "0x2737108", VA = "0x2737108")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x273730C", Offset = "0x273730C", VA = "0x273730C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2737530", Offset = "0x2737530", VA = "0x2737530")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x27376C0", Offset = "0x27376C0", VA = "0x27376C0")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16880", Offset = "0xF16880")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2737CD8", Offset = "0x2737CD8", VA = "0x2737CD8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x273895C", Offset = "0x273895C", VA = "0x273895C")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16890", Offset = "0xF16890")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2737E64", Offset = "0x2737E64", VA = "0x2737E64")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2738978", Offset = "0x2738978", VA = "0x2738978")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168A0", Offset = "0xF168A0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2737FF0", Offset = "0x2737FF0", VA = "0x2737FF0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2738994", Offset = "0x2738994", VA = "0x2738994")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168B0", Offset = "0xF168B0")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2737FF8", Offset = "0x2737FF8", VA = "0x2737FF8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x27389B0", Offset = "0x27389B0", VA = "0x27389B0")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168C0", Offset = "0xF168C0")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Tween yTween;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x27383AC", Offset = "0x27383AC", VA = "0x27383AC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x27389CC", Offset = "0x27389CC", VA = "0x27389CC")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x27389E8", Offset = "0x27389E8", VA = "0x27389E8")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2738A04", Offset = "0x2738A04", VA = "0x2738A04")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2738A38", Offset = "0x2738A38", VA = "0x2738A38")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2738A54", Offset = "0x2738A54", VA = "0x2738A54")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2738A70", Offset = "0x2738A70", VA = "0x2738A70")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168D0", Offset = "0xF168D0")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2738670", Offset = "0x2738670", VA = "0x2738670")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2738B98", Offset = "0x2738B98", VA = "0x2738B98")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2738C28", Offset = "0x2738C28", VA = "0x2738C28")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168E0", Offset = "0xF168E0")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2738954", Offset = "0x2738954", VA = "0x2738954")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2738CCC", Offset = "0x2738CCC", VA = "0x2738CCC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2738CE8", Offset = "0x2738CE8", VA = "0x2738CE8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2733B90", Offset = "0x2733B90", VA = "0x2733B90")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2737CE0", Offset = "0x2737CE0", VA = "0x2737CE0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2737E6C", Offset = "0x2737E6C", VA = "0x2737E6C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2733E84", Offset = "0x2733E84", VA = "0x2733E84")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2738000", Offset = "0x2738000", VA = "0x2738000")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x27383B4", Offset = "0x27383B4", VA = "0x27383B4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2738678", Offset = "0x2738678", VA = "0x2738678")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF168F0", Offset = "0xF168F0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2738E14", Offset = "0x2738E14", VA = "0x2738E14")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x27391F8", Offset = "0x27391F8", VA = "0x27391F8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2739214", Offset = "0x2739214", VA = "0x2739214")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16900", Offset = "0xF16900")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2738E1C", Offset = "0x2738E1C", VA = "0x2738E1C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2739230", Offset = "0x2739230", VA = "0x2739230")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x273924C", Offset = "0x273924C", VA = "0x273924C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16910", Offset = "0xF16910")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x27391F0", Offset = "0x27391F0", VA = "0x27391F0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2739268", Offset = "0x2739268", VA = "0x2739268")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2739274", Offset = "0x2739274", VA = "0x2739274")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2734148", Offset = "0x2734148", VA = "0x2734148")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x27345A4", Offset = "0x27345A4", VA = "0x27345A4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2738E24", Offset = "0x2738E24", VA = "0x2738E24")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2738FFC", Offset = "0x2738FFC", VA = "0x2738FFC")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000021")]
	public static class Utils
	{
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x27335E8", Offset = "0x27335E8", VA = "0x27335E8")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16920", Offset = "0xF16920")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2739320", Offset = "0x2739320", VA = "0x2739320")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x273C5C0", Offset = "0x273C5C0", VA = "0x273C5C0")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x273C5DC", Offset = "0x273C5DC", VA = "0x273C5DC")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16930", Offset = "0xF16930")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2739328", Offset = "0x2739328", VA = "0x2739328")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x273C830", Offset = "0x273C830", VA = "0x273C830")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x273C854", Offset = "0x273C854", VA = "0x273C854")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16940", Offset = "0xF16940")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2739330", Offset = "0x2739330", VA = "0x2739330")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x273CEBC", Offset = "0x273CEBC", VA = "0x273CEBC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x273CEE0", Offset = "0x273CEE0", VA = "0x273CEE0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16950", Offset = "0xF16950")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x27394AC", Offset = "0x27394AC", VA = "0x27394AC")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x273D388", Offset = "0x273D388", VA = "0x273D388")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x273D3AC", Offset = "0x273D3AC", VA = "0x273D3AC")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16960", Offset = "0xF16960")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2739600", Offset = "0x2739600", VA = "0x2739600")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x273D498", Offset = "0x273D498", VA = "0x273D498")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x273D4BC", Offset = "0x273D4BC", VA = "0x273D4BC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16970", Offset = "0xF16970")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2739778", Offset = "0x2739778", VA = "0x2739778")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x273D4E0", Offset = "0x273D4E0", VA = "0x273D4E0")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x273D4FC", Offset = "0x273D4FC", VA = "0x273D4FC")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16980", Offset = "0xF16980")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2739AD4", Offset = "0x2739AD4", VA = "0x2739AD4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x273D518", Offset = "0x273D518", VA = "0x273D518")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x273D598", Offset = "0x273D598", VA = "0x273D598")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16990", Offset = "0xF16990")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2739C50", Offset = "0x2739C50", VA = "0x2739C50")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x273D5F4", Offset = "0x273D5F4", VA = "0x273D5F4")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x273D674", Offset = "0x273D674", VA = "0x273D674")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169A0", Offset = "0xF169A0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2739DCC", Offset = "0x2739DCC", VA = "0x2739DCC")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x273D6D0", Offset = "0x273D6D0", VA = "0x273D6D0")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x273D750", Offset = "0x273D750", VA = "0x273D750")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169B0", Offset = "0xF169B0")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2739F48", Offset = "0x2739F48", VA = "0x2739F48")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x273C5F8", Offset = "0x273C5F8", VA = "0x273C5F8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x273C618", Offset = "0x273C618", VA = "0x273C618")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169C0", Offset = "0xF169C0")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x273A09C", Offset = "0x273A09C", VA = "0x273A09C")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x273C634", Offset = "0x273C634", VA = "0x273C634")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x273C654", Offset = "0x273C654", VA = "0x273C654")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169D0", Offset = "0xF169D0")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x273A200", Offset = "0x273A200", VA = "0x273A200")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x273C670", Offset = "0x273C670", VA = "0x273C670")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x273C68C", Offset = "0x273C68C", VA = "0x273C68C")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169E0", Offset = "0xF169E0")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x273A37C", Offset = "0x273A37C", VA = "0x273A37C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x273C6A8", Offset = "0x273C6A8", VA = "0x273C6A8")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x273C6C4", Offset = "0x273C6C4", VA = "0x273C6C4")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF169F0", Offset = "0xF169F0")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x273A504", Offset = "0x273A504", VA = "0x273A504")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x273C6E0", Offset = "0x273C6E0", VA = "0x273C6E0")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x273C6FC", Offset = "0x273C6FC", VA = "0x273C6FC")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A00", Offset = "0xF16A00")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x273A68C", Offset = "0x273A68C", VA = "0x273A68C")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x273C718", Offset = "0x273C718", VA = "0x273C718")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x273C734", Offset = "0x273C734", VA = "0x273C734")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A10", Offset = "0xF16A10")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x273A694", Offset = "0x273A694", VA = "0x273A694")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x273C750", Offset = "0x273C750", VA = "0x273C750")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x273C76C", Offset = "0x273C76C", VA = "0x273C76C")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A20", Offset = "0xF16A20")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x273A830", Offset = "0x273A830", VA = "0x273A830")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x273C788", Offset = "0x273C788", VA = "0x273C788")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x273C7A4", Offset = "0x273C7A4", VA = "0x273C7A4")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A30", Offset = "0xF16A30")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x273A9CC", Offset = "0x273A9CC", VA = "0x273A9CC")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x273C7C0", Offset = "0x273C7C0", VA = "0x273C7C0")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x273C7DC", Offset = "0x273C7DC", VA = "0x273C7DC")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A40", Offset = "0xF16A40")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x273AB68", Offset = "0x273AB68", VA = "0x273AB68")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x273C7F8", Offset = "0x273C7F8", VA = "0x273C7F8")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x273C814", Offset = "0x273C814", VA = "0x273C814")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A50", Offset = "0xF16A50")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x273ACE4", Offset = "0x273ACE4", VA = "0x273ACE4")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x273C878", Offset = "0x273C878", VA = "0x273C878")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x273C894", Offset = "0x273C894", VA = "0x273C894")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A60", Offset = "0xF16A60")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x273AE60", Offset = "0x273AE60", VA = "0x273AE60")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x273C8B0", Offset = "0x273C8B0", VA = "0x273C8B0")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x273C8CC", Offset = "0x273C8CC", VA = "0x273C8CC")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A70", Offset = "0xF16A70")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x273AFC4", Offset = "0x273AFC4", VA = "0x273AFC4")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x273C8E8", Offset = "0x273C8E8", VA = "0x273C8E8")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x273C904", Offset = "0x273C904", VA = "0x273C904")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A80", Offset = "0xF16A80")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x273B148", Offset = "0x273B148", VA = "0x273B148")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x273C920", Offset = "0x273C920", VA = "0x273C920")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x273C93C", Offset = "0x273C93C", VA = "0x273C93C")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16A90", Offset = "0xF16A90")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x273B2CC", Offset = "0x273B2CC", VA = "0x273B2CC")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x273C958", Offset = "0x273C958", VA = "0x273C958")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x273C974", Offset = "0x273C974", VA = "0x273C974")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AA0", Offset = "0xF16AA0")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x273B2D4", Offset = "0x273B2D4", VA = "0x273B2D4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x273C990", Offset = "0x273C990", VA = "0x273C990")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x273C9AC", Offset = "0x273C9AC", VA = "0x273C9AC")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AB0", Offset = "0xF16AB0")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x273B2DC", Offset = "0x273B2DC", VA = "0x273B2DC")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x273C9C8", Offset = "0x273C9C8", VA = "0x273C9C8")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x273CA58", Offset = "0x273CA58", VA = "0x273CA58")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AC0", Offset = "0xF16AC0")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x273B47C", Offset = "0x273B47C", VA = "0x273B47C")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x273CAFC", Offset = "0x273CAFC", VA = "0x273CAFC")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x273CB8C", Offset = "0x273CB8C", VA = "0x273CB8C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AD0", Offset = "0xF16AD0")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x273B484", Offset = "0x273B484", VA = "0x273B484")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x273CC30", Offset = "0x273CC30", VA = "0x273CC30")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x273CCC0", Offset = "0x273CCC0", VA = "0x273CCC0")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AE0", Offset = "0xF16AE0")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x273B830", Offset = "0x273B830", VA = "0x273B830")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x273CD64", Offset = "0x273CD64", VA = "0x273CD64")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x273CD80", Offset = "0x273CD80", VA = "0x273CD80")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x273CD9C", Offset = "0x273CD9C", VA = "0x273CD9C")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x273CDD0", Offset = "0x273CDD0", VA = "0x273CDD0")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x273CDEC", Offset = "0x273CDEC", VA = "0x273CDEC")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x273CE08", Offset = "0x273CE08", VA = "0x273CE08")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16AF0", Offset = "0xF16AF0")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x273B9A0", Offset = "0x273B9A0", VA = "0x273B9A0")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x273CF04", Offset = "0x273CF04", VA = "0x273CF04")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x273CF74", Offset = "0x273CF74", VA = "0x273CF74")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B00", Offset = "0xF16B00")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x273BB00", Offset = "0x273BB00", VA = "0x273BB00")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x273CFC0", Offset = "0x273CFC0", VA = "0x273CFC0")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x273CFDC", Offset = "0x273CFDC", VA = "0x273CFDC")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B10", Offset = "0xF16B10")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x273BC60", Offset = "0x273BC60", VA = "0x273BC60")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x273CFF8", Offset = "0x273CFF8", VA = "0x273CFF8")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x273D014", Offset = "0x273D014", VA = "0x273D014")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B20", Offset = "0xF16B20")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x273BDCC", Offset = "0x273BDCC", VA = "0x273BDCC")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x273D030", Offset = "0x273D030", VA = "0x273D030")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x273D054", Offset = "0x273D054", VA = "0x273D054")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B30", Offset = "0xF16B30")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x273BDD4", Offset = "0x273BDD4", VA = "0x273BDD4")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x273D078", Offset = "0x273D078", VA = "0x273D078")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x273D09C", Offset = "0x273D09C", VA = "0x273D09C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B40", Offset = "0xF16B40")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x273BF9C", Offset = "0x273BF9C", VA = "0x273BF9C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x273D0C0", Offset = "0x273D0C0", VA = "0x273D0C0")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x273D0C8", Offset = "0x273D0C8", VA = "0x273D0C8")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B50", Offset = "0xF16B50")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x273BFA4", Offset = "0x273BFA4", VA = "0x273BFA4")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x273D168", Offset = "0x273D168", VA = "0x273D168")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x273D18C", Offset = "0x273D18C", VA = "0x273D18C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B60", Offset = "0xF16B60")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x273BFAC", Offset = "0x273BFAC", VA = "0x273BFAC")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x273D1B0", Offset = "0x273D1B0", VA = "0x273D1B0")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x273D1D4", Offset = "0x273D1D4", VA = "0x273D1D4")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B70", Offset = "0xF16B70")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x273C1B0", Offset = "0x273C1B0", VA = "0x273C1B0")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x273D1F8", Offset = "0x273D1F8", VA = "0x273D1F8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x273D204", Offset = "0x273D204", VA = "0x273D204")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B80", Offset = "0xF16B80")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x273C3B4", Offset = "0x273C3B4", VA = "0x273C3B4")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x273D2C0", Offset = "0x273D2C0", VA = "0x273D2C0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x273D2CC", Offset = "0x273D2CC", VA = "0x273D2CC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16B90", Offset = "0xF16B90")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x273C5B8", Offset = "0x273C5B8", VA = "0x273C5B8")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x273D3D0", Offset = "0x273D3D0", VA = "0x273D3D0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x273D3DC", Offset = "0x273D3DC", VA = "0x273D3DC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2734988", Offset = "0x2734988", VA = "0x2734988")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x27342BC", Offset = "0x27342BC", VA = "0x27342BC")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x27346F0", Offset = "0x27346F0", VA = "0x27346F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2739338", Offset = "0x2739338", VA = "0x2739338")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x27394B4", Offset = "0x27394B4", VA = "0x27394B4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2739608", Offset = "0x2739608", VA = "0x2739608")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2739780", Offset = "0x2739780", VA = "0x2739780")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2739960", Offset = "0x2739960", VA = "0x2739960")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2739ADC", Offset = "0x2739ADC", VA = "0x2739ADC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2739C58", Offset = "0x2739C58", VA = "0x2739C58")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2739DD4", Offset = "0x2739DD4", VA = "0x2739DD4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2739F50", Offset = "0x2739F50", VA = "0x2739F50")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x273A0A4", Offset = "0x273A0A4", VA = "0x273A0A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x273A208", Offset = "0x273A208", VA = "0x273A208")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x273A384", Offset = "0x273A384", VA = "0x273A384")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x273A50C", Offset = "0x273A50C", VA = "0x273A50C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x2733894", Offset = "0x2733894", VA = "0x2733894")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x273A69C", Offset = "0x273A69C", VA = "0x273A69C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x273A838", Offset = "0x273A838", VA = "0x273A838")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x273A9D4", Offset = "0x273A9D4", VA = "0x273A9D4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x273AB70", Offset = "0x273AB70", VA = "0x273AB70")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x273ACEC", Offset = "0x273ACEC", VA = "0x273ACEC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x273AE68", Offset = "0x273AE68", VA = "0x273AE68")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x273AFCC", Offset = "0x273AFCC", VA = "0x273AFCC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x273B150", Offset = "0x273B150", VA = "0x273B150")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2733FD4", Offset = "0x2733FD4", VA = "0x2733FD4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x2734CB8", Offset = "0x2734CB8", VA = "0x2734CB8")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x273B2E4", Offset = "0x273B2E4", VA = "0x273B2E4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x2734E78", Offset = "0x2734E78", VA = "0x2734E78")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x273B48C", Offset = "0x273B48C", VA = "0x273B48C")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x273B838", Offset = "0x273B838", VA = "0x273B838")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x273B9A8", Offset = "0x273B9A8", VA = "0x273B9A8")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x273BB08", Offset = "0x273BB08", VA = "0x273BB08")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x273BC68", Offset = "0x273BC68", VA = "0x273BC68")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2734430", Offset = "0x2734430", VA = "0x2734430")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x273BDDC", Offset = "0x273BDDC", VA = "0x273BDDC")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x273483C", Offset = "0x273483C", VA = "0x273483C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2734AD4", Offset = "0x2734AD4", VA = "0x2734AD4")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x273BFB4", Offset = "0x273BFB4", VA = "0x273BFB4")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x273C1B8", Offset = "0x273C1B8", VA = "0x273C1B8")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x273C3BC", Offset = "0x273C3BC", VA = "0x273C3BC")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BA0", Offset = "0xF16BA0")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x273E260", Offset = "0x273E260", VA = "0x273E260")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x273EA90", Offset = "0x273EA90", VA = "0x273EA90")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x273EAB4", Offset = "0x273EAB4", VA = "0x273EAB4")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BB0", Offset = "0xF16BB0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x273E438", Offset = "0x273E438", VA = "0x273E438")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x273EAD8", Offset = "0x273EAD8", VA = "0x273EAD8")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x273EAFC", Offset = "0x273EAFC", VA = "0x273EAFC")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BC0", Offset = "0xF16BC0")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1080E34", Offset = "0x1080E34", VA = "0x1080E34", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1080E3C", Offset = "0x1080E3C", VA = "0x1080E3C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BD0", Offset = "0xF16BD0")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1080E84", Offset = "0x1080E84", VA = "0x1080E84", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1080E8C", Offset = "0x1080E8C", VA = "0x1080E8C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BE0", Offset = "0xF16BE0")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1080E5C", Offset = "0x1080E5C", VA = "0x1080E5C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1080E64", Offset = "0x1080E64", VA = "0x1080E64", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16BF0", Offset = "0xF16BF0")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1080E48", Offset = "0x1080E48", VA = "0x1080E48", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1080E50", Offset = "0x1080E50", VA = "0x1080E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16C00", Offset = "0xF16C00")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1080E70", Offset = "0x1080E70", VA = "0x1080E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1080E78", Offset = "0x1080E78", VA = "0x1080E78", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16C10", Offset = "0xF16C10")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1080E98", Offset = "0x1080E98", VA = "0x1080E98", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1080EA0", Offset = "0x1080EA0", VA = "0x1080EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x273D7AC", Offset = "0x273D7AC", VA = "0x273D7AC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x273D988", Offset = "0x273D988", VA = "0x273D988")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x273DB78", Offset = "0x273DB78", VA = "0x273DB78")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x273DC4C", Offset = "0x273DC4C", VA = "0x273DC4C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x273DD20", Offset = "0x273DD20", VA = "0x273DD20")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x273DDF4", Offset = "0x273DDF4", VA = "0x273DDF4")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x273DED8", Offset = "0x273DED8", VA = "0x273DED8")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x273DFBC", Offset = "0x273DFBC", VA = "0x273DFBC")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x273E090", Offset = "0x273E090", VA = "0x273E090")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x273E268", Offset = "0x273E268", VA = "0x273E268")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x273E440", Offset = "0x273E440", VA = "0x273E440")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF170E0", Offset = "0xF170E0")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x273E548", Offset = "0x273E548", VA = "0x273E548")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF17154", Offset = "0xF17154")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x273E650", Offset = "0x273E650", VA = "0x273E650")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF171C8", Offset = "0xF171C8")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x273E758", Offset = "0x273E758", VA = "0x273E758")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF1723C", Offset = "0xF1723C")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x273E870", Offset = "0x273E870", VA = "0x273E870")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF172B0", Offset = "0xF172B0")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x273E988", Offset = "0x273E988", VA = "0x273E988")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xF17324", Offset = "0xF17324")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000052")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x273626C", Offset = "0x273626C", VA = "0x273626C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x27362A0", Offset = "0x27362A0", VA = "0x27362A0")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000053")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2736464", Offset = "0x2736464", VA = "0x2736464", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x27364C8", Offset = "0x27364C8", VA = "0x27364C8")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000054")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2736368", Offset = "0x2736368", VA = "0x2736368", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2736384", Offset = "0x2736384", VA = "0x2736384")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000055")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x27362D4", Offset = "0x27362D4", VA = "0x27362D4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2736320", Offset = "0x2736320", VA = "0x2736320")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000056")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x27363B8", Offset = "0x27363B8", VA = "0x27363B8", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x273641C", Offset = "0x273641C", VA = "0x273641C")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x27364FC", Offset = "0x27364FC", VA = "0x27364FC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2736530", Offset = "0x2736530", VA = "0x2736530")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000008")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000058")]
	public static class Physics
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x273FA70", Offset = "0x273FA70", VA = "0x273FA70")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x273FB78", Offset = "0x273FB78", VA = "0x273FB78")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x273FC08", Offset = "0x273FC08", VA = "0x273FC08")]
		[AttributeAttribute(Name = "PreserveAttribute", RVA = "0xF17478", Offset = "0xF17478")]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x273FC98", Offset = "0x273FC98", VA = "0x273FC98")]
		[AttributeAttribute(Name = "PreserveAttribute", RVA = "0xF17488", Offset = "0xF17488")]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x273F92C", Offset = "0x273F92C", VA = "0x273F92C")]
	[AttributeAttribute(Name = "PreserveAttribute", RVA = "0xF17398", Offset = "0xF17398")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x273F9D0", Offset = "0x273F9D0", VA = "0x273F9D0")]
	[AttributeAttribute(Name = "PreserveAttribute", RVA = "0xF173A8", Offset = "0xF173A8")]
	private static void Preserver()
	{
	}
}
[Token(Token = "0x2000009")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xF16760", Offset = "0xF16760")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xF16760", Offset = "0xF16760")]
public class DOTweenAnimation : ABSAnimationComponent
{
	[Token(Token = "0x2000059")]
	public enum AnimationType
	{
		[Token(Token = "0x40000A7")]
		None,
		[Token(Token = "0x40000A8")]
		Move,
		[Token(Token = "0x40000A9")]
		LocalMove,
		[Token(Token = "0x40000AA")]
		Rotate,
		[Token(Token = "0x40000AB")]
		LocalRotate,
		[Token(Token = "0x40000AC")]
		Scale,
		[Token(Token = "0x40000AD")]
		Color,
		[Token(Token = "0x40000AE")]
		Fade,
		[Token(Token = "0x40000AF")]
		Text,
		[Token(Token = "0x40000B0")]
		PunchPosition,
		[Token(Token = "0x40000B1")]
		PunchRotation,
		[Token(Token = "0x40000B2")]
		PunchScale,
		[Token(Token = "0x40000B3")]
		ShakePosition,
		[Token(Token = "0x40000B4")]
		ShakeRotation,
		[Token(Token = "0x40000B5")]
		ShakeScale,
		[Token(Token = "0x40000B6")]
		CameraAspect,
		[Token(Token = "0x40000B7")]
		CameraBackgroundColor,
		[Token(Token = "0x40000B8")]
		CameraFieldOfView,
		[Token(Token = "0x40000B9")]
		CameraOrthoSize,
		[Token(Token = "0x40000BA")]
		CameraPixelRect,
		[Token(Token = "0x40000BB")]
		CameraRect,
		[Token(Token = "0x40000BC")]
		UIWidthHeight
	}

	[Token(Token = "0x200005A")]
	public enum TargetType
	{
		[Token(Token = "0x40000BE")]
		Unset,
		[Token(Token = "0x40000BF")]
		Camera,
		[Token(Token = "0x40000C0")]
		CanvasGroup,
		[Token(Token = "0x40000C1")]
		Image,
		[Token(Token = "0x40000C2")]
		Light,
		[Token(Token = "0x40000C3")]
		RectTransform,
		[Token(Token = "0x40000C4")]
		Renderer,
		[Token(Token = "0x40000C5")]
		SpriteRenderer,
		[Token(Token = "0x40000C6")]
		Rigidbody,
		[Token(Token = "0x40000C7")]
		Rigidbody2D,
		[Token(Token = "0x40000C8")]
		Text,
		[Token(Token = "0x40000C9")]
		Transform,
		[Token(Token = "0x40000CA")]
		tk2dBaseSprite,
		[Token(Token = "0x40000CB")]
		tk2dTextMesh,
		[Token(Token = "0x40000CC")]
		TextMeshPro,
		[Token(Token = "0x40000CD")]
		TextMeshProUGUI
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool targetIsSelf;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject targetGO;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool tweenTargetIsTargetGO;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float delay;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float duration;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Ease easeType;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve easeCurve;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LoopType loopType;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int loops;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string id;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isRelative;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool isFrom;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool isIndependentUpdate;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	public bool autoKill;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool isActive;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool isValid;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Component target;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AnimationType animationType;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public TargetType targetType;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TargetType forcedTargetType;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool autoPlay;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool useTargetAsV3;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float endValueFloat;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Vector3 endValueV3;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Vector2 endValueV2;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Color endValueColor;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string endValueString;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Rect endValueRect;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform endValueTransform;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool optionalBool0;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float optionalFloat0;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int optionalInt0;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public RotateMode optionalRotationMode;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ScrambleMode optionalScrambleMode;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string optionalString;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _tweenCreated;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int _playCount;

	[Token(Token = "0x14000001")]
	public static event Action<DOTweenAnimation> OnReset
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2731C74", Offset = "0x2731C74", VA = "0x2731C74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF173B8", Offset = "0xF173B8")]
		add
		{
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2731D28", Offset = "0x2731D28", VA = "0x2731D28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF173C8", Offset = "0xF173C8")]
		remove
		{
		}
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2731DDC", Offset = "0x2731DDC", VA = "0x2731DDC")]
	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2731E50", Offset = "0x2731E50", VA = "0x2731E50")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2733380", Offset = "0x2733380", VA = "0x2733380")]
	private void Start()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x27333C4", Offset = "0x27333C4", VA = "0x27333C4")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x27333C8", Offset = "0x27333C8", VA = "0x27333C8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2731EA0", Offset = "0x2731EA0", VA = "0x2731EA0")]
	public void CreateTween()
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x273505C", Offset = "0x273505C", VA = "0x273505C", Slot = "4")]
	public override void DOPlay()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x27350D8", Offset = "0x27350D8", VA = "0x27350D8", Slot = "5")]
	public override void DOPlayBackwards()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2735154", Offset = "0x2735154", VA = "0x2735154", Slot = "6")]
	public override void DOPlayForward()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x27351D0", Offset = "0x27351D0", VA = "0x27351D0", Slot = "7")]
	public override void DOPause()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x273524C", Offset = "0x273524C", VA = "0x273524C", Slot = "8")]
	public override void DOTogglePause()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x27352C8", Offset = "0x27352C8", VA = "0x27352C8", Slot = "9")]
	public override void DORewind()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x27353C4", Offset = "0x27353C4", VA = "0x27353C4", Slot = "10")]
	public override void DORestart()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x27353D4", Offset = "0x27353D4", VA = "0x27353D4", Slot = "11")]
	public override void DORestart(bool fromHere)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x2735788", Offset = "0x2735788", VA = "0x2735788", Slot = "12")]
	public override void DOComplete()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2735808", Offset = "0x2735808", VA = "0x2735808", Slot = "13")]
	public override void DOKill()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2735898", Offset = "0x2735898", VA = "0x2735898")]
	public void DOPlayById(string id)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2735924", Offset = "0x2735924", VA = "0x2735924")]
	public void DOPlayAllById(string id)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x273598C", Offset = "0x273598C", VA = "0x273598C")]
	public void DOPauseAllById(string id)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x27359F4", Offset = "0x27359F4", VA = "0x27359F4")]
	public void DOPlayBackwardsById(string id)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2735A80", Offset = "0x2735A80", VA = "0x2735A80")]
	public void DOPlayBackwardsAllById(string id)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2735AE8", Offset = "0x2735AE8", VA = "0x2735AE8")]
	public void DOPlayForwardById(string id)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2735B74", Offset = "0x2735B74", VA = "0x2735B74")]
	public void DOPlayForwardAllById(string id)
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2735BDC", Offset = "0x2735BDC", VA = "0x2735BDC")]
	public void DOPlayNext()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2735D10", Offset = "0x2735D10", VA = "0x2735D10")]
	public void DORewindAndPlayNext()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2735DA0", Offset = "0x2735DA0", VA = "0x2735DA0")]
	public void DORewindAllById(string id)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2735E20", Offset = "0x2735E20", VA = "0x2735E20")]
	public void DORestartById(string id)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2735EBC", Offset = "0x2735EBC", VA = "0x2735EBC")]
	public void DORestartAllById(string id)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2735F40", Offset = "0x2735F40", VA = "0x2735F40")]
	public List<Tween> GetTweens()
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x273342C", Offset = "0x273342C", VA = "0x273342C")]
	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x273602C", Offset = "0x273602C", VA = "0x273602C")]
	public Tween CreateEditorPreview()
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2733414", Offset = "0x2733414", VA = "0x2733414")]
	private GameObject GetTweenGO()
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x27354F0", Offset = "0x27354F0", VA = "0x27354F0")]
	private void ReEvaluateRelativeTween()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2736068", Offset = "0x2736068", VA = "0x2736068")]
	public DOTweenAnimation()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2736260", Offset = "0x2736260", VA = "0x2736260")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF173D8", Offset = "0xF173D8")]
	private void <CreateTween>b__47_0()
	{
	}
}
[Token(Token = "0x200000A")]
public static class DOTweenAnimationExtensions
{
	[Token(Token = "0x6000077")]
	public static bool IsSameOrSubclassOf<T>(this Component t)
	{
		return default(bool);
	}
}
[Token(Token = "0x200000B")]
public static class DOTweenProShortcuts
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16C20", Offset = "0xF16C20")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2740158", Offset = "0x2740158", VA = "0x2740158")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2740494", Offset = "0x2740494", VA = "0x2740494")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x27404B0", Offset = "0x27404B0", VA = "0x27404B0")]
		internal void <DOSpiral>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xF16C30", Offset = "0xF16C30")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x274048C", Offset = "0x274048C", VA = "0x274048C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x27404CC", Offset = "0x27404CC", VA = "0x27404CC")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x273FDE0", Offset = "0x273FDE0", VA = "0x273FDE0")]
	static DOTweenProShortcuts()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x273FE30", Offset = "0x273FE30", VA = "0x273FE30")]
	public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2740160", Offset = "0x2740160", VA = "0x2740160")]
	public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}
}
