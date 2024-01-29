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
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModuleAudio
{
	[Token(Token = "0x2000003")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936644", Offset = "0x936644")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x178ED44", Offset = "0x178ED44", VA = "0x178ED44")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1798040", Offset = "0x1798040", VA = "0x1798040")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1798060", Offset = "0x1798060", VA = "0x1798060")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936654", Offset = "0x936654")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x178EF0C", Offset = "0x178EF0C", VA = "0x178EF0C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1798080", Offset = "0x1798080", VA = "0x1798080")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17980A0", Offset = "0x17980A0", VA = "0x17980A0")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936664", Offset = "0x936664")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x178F0E8", Offset = "0x178F0E8", VA = "0x178F0E8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17980C0", Offset = "0x17980C0", VA = "0x17980C0")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1798100", Offset = "0x1798100", VA = "0x1798100")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x178EB5C", Offset = "0x178EB5C", VA = "0x178EB5C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x178ED4C", Offset = "0x178ED4C", VA = "0x178ED4C")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x178EF14", Offset = "0x178EF14", VA = "0x178EF14")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x178F0F0", Offset = "0x178F0F0", VA = "0x178F0F0")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x178F164", Offset = "0x178F164", VA = "0x178F164")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x178F1D8", Offset = "0x178F1D8", VA = "0x178F1D8")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x178F244", Offset = "0x178F244", VA = "0x178F244")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x178F2C8", Offset = "0x178F2C8", VA = "0x178F2C8")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x178F334", Offset = "0x178F334", VA = "0x178F334")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x178F3A0", Offset = "0x178F3A0", VA = "0x178F3A0")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x178F40C", Offset = "0x178F40C", VA = "0x178F40C")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x178F478", Offset = "0x178F478", VA = "0x178F478")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x178F4EC", Offset = "0x178F4EC", VA = "0x178F4EC")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x178F55C", Offset = "0x178F55C", VA = "0x178F55C")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x178F5C8", Offset = "0x178F5C8", VA = "0x178F5C8")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936684", Offset = "0x936684")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x178F634", Offset = "0x178F634", VA = "0x178F634")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1798128", Offset = "0x1798128", VA = "0x1798128")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936694", Offset = "0x936694")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x178F828", Offset = "0x178F828", VA = "0x178F828")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1798268", Offset = "0x1798268", VA = "0x1798268")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366A4", Offset = "0x9366A4")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x178FA1C", Offset = "0x178FA1C", VA = "0x178FA1C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1798288", Offset = "0x1798288", VA = "0x1798288")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366B4", Offset = "0x9366B4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x178FC10", Offset = "0x178FC10", VA = "0x178FC10")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17982A8", Offset = "0x17982A8", VA = "0x17982A8")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366C4", Offset = "0x9366C4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x178FC18", Offset = "0x178FC18", VA = "0x178FC18")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x17982C8", Offset = "0x17982C8", VA = "0x17982C8")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366D4", Offset = "0x9366D4")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x178FE8C", Offset = "0x178FE8C", VA = "0x178FE8C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17982E8", Offset = "0x17982E8", VA = "0x17982E8")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366E4", Offset = "0x9366E4")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 endValue;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Tween yTween;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17903F0", Offset = "0x17903F0", VA = "0x17903F0")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1798308", Offset = "0x1798308", VA = "0x1798308")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1798328", Offset = "0x1798328", VA = "0x1798328")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x179835C", Offset = "0x179835C", VA = "0x179835C")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x179837C", Offset = "0x179837C", VA = "0x179837C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x179839C", Offset = "0x179839C", VA = "0x179839C")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9366F4", Offset = "0x9366F4")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1790674", Offset = "0x1790674", VA = "0x1790674")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x179845C", Offset = "0x179845C", VA = "0x179845C")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936704", Offset = "0x936704")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1790928", Offset = "0x1790928", VA = "0x1790928")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x179847C", Offset = "0x179847C", VA = "0x179847C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x179849C", Offset = "0x179849C", VA = "0x179849C")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936714", Offset = "0x936714")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1790B34", Offset = "0x1790B34", VA = "0x1790B34")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x179859C", Offset = "0x179859C", VA = "0x179859C")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936724", Offset = "0x936724")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1790D54", Offset = "0x1790D54", VA = "0x1790D54")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1798148", Offset = "0x1798148", VA = "0x1798148")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1798168", Offset = "0x1798168", VA = "0x1798168")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x178BC64", Offset = "0x178BC64", VA = "0x178BC64")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x178F63C", Offset = "0x178F63C", VA = "0x178F63C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x178F830", Offset = "0x178F830", VA = "0x178F830")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x178FA24", Offset = "0x178FA24", VA = "0x178FA24")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x178C044", Offset = "0x178C044", VA = "0x178C044")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x178FC20", Offset = "0x178FC20", VA = "0x178FC20")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x178FE94", Offset = "0x178FE94", VA = "0x178FE94")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x17903F8", Offset = "0x17903F8", VA = "0x17903F8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x179067C", Offset = "0x179067C", VA = "0x179067C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1790930", Offset = "0x1790930", VA = "0x1790930")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1790B3C", Offset = "0x1790B3C", VA = "0x1790B3C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936744", Offset = "0x936744")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x1790D5C", Offset = "0x1790D5C", VA = "0x1790D5C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x17985BC", Offset = "0x17985BC", VA = "0x17985BC")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936754", Offset = "0x936754")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x1790F4C", Offset = "0x1790F4C", VA = "0x1790F4C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17985DC", Offset = "0x17985DC", VA = "0x17985DC")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936764", Offset = "0x936764")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x179113C", Offset = "0x179113C", VA = "0x179113C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x17985FC", Offset = "0x17985FC", VA = "0x17985FC")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936774", Offset = "0x936774")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1791144", Offset = "0x1791144", VA = "0x1791144")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x179861C", Offset = "0x179861C", VA = "0x179861C")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936784", Offset = "0x936784")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Tween yTween;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17915BC", Offset = "0x17915BC", VA = "0x17915BC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x179863C", Offset = "0x179863C", VA = "0x179863C")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x179865C", Offset = "0x179865C", VA = "0x179865C")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x179867C", Offset = "0x179867C", VA = "0x179867C")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x17986B0", Offset = "0x17986B0", VA = "0x17986B0")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17986D0", Offset = "0x17986D0", VA = "0x17986D0")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x17986F0", Offset = "0x17986F0", VA = "0x17986F0")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936794", Offset = "0x936794")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x17918D8", Offset = "0x17918D8", VA = "0x17918D8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x17987A8", Offset = "0x17987A8", VA = "0x17987A8")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x17987D0", Offset = "0x17987D0", VA = "0x17987D0")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9367A4", Offset = "0x9367A4")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1791C18", Offset = "0x1791C18", VA = "0x1791C18")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x17987F0", Offset = "0x17987F0", VA = "0x17987F0")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1798810", Offset = "0x1798810", VA = "0x1798810")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x178BE5C", Offset = "0x178BE5C", VA = "0x178BE5C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1790D64", Offset = "0x1790D64", VA = "0x1790D64")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1790F54", Offset = "0x1790F54", VA = "0x1790F54")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x178C238", Offset = "0x178C238", VA = "0x178C238")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x179114C", Offset = "0x179114C", VA = "0x179114C")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x17915C4", Offset = "0x17915C4", VA = "0x17915C4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x17918E0", Offset = "0x17918E0", VA = "0x17918E0")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9367C4", Offset = "0x9367C4")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1791C20", Offset = "0x1791C20", VA = "0x1791C20")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1798908", Offset = "0x1798908", VA = "0x1798908")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1798928", Offset = "0x1798928", VA = "0x1798928")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9367D4", Offset = "0x9367D4")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1791C28", Offset = "0x1791C28", VA = "0x1791C28")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1798948", Offset = "0x1798948", VA = "0x1798948")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1798968", Offset = "0x1798968", VA = "0x1798968")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9367E4", Offset = "0x9367E4")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1792094", Offset = "0x1792094", VA = "0x1792094")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1798988", Offset = "0x1798988", VA = "0x1798988")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1798994", Offset = "0x1798994", VA = "0x1798994")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x178C5E0", Offset = "0x178C5E0", VA = "0x178C5E0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x178CB98", Offset = "0x178CB98", VA = "0x178CB98")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1791C30", Offset = "0x1791C30", VA = "0x1791C30")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1791E20", Offset = "0x1791E20", VA = "0x1791E20")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x200001E")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x200001F")]
	public static class Utils
	{
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x178B82C", Offset = "0x178B82C", VA = "0x178B82C")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936804", Offset = "0x936804")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x179209C", Offset = "0x179209C", VA = "0x179209C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1798A40", Offset = "0x1798A40", VA = "0x1798A40")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1798A60", Offset = "0x1798A60", VA = "0x1798A60")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936814", Offset = "0x936814")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x17920A4", Offset = "0x17920A4", VA = "0x17920A4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1798D08", Offset = "0x1798D08", VA = "0x1798D08")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1798D30", Offset = "0x1798D30", VA = "0x1798D30")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936824", Offset = "0x936824")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x17920AC", Offset = "0x17920AC", VA = "0x17920AC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1799118", Offset = "0x1799118", VA = "0x1799118")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1799140", Offset = "0x1799140", VA = "0x1799140")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936834", Offset = "0x936834")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x179229C", Offset = "0x179229C", VA = "0x179229C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x17995FC", Offset = "0x17995FC", VA = "0x17995FC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1799624", Offset = "0x1799624", VA = "0x1799624")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936844", Offset = "0x936844")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1792464", Offset = "0x1792464", VA = "0x1792464")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1799714", Offset = "0x1799714", VA = "0x1799714")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x179973C", Offset = "0x179973C", VA = "0x179973C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936854", Offset = "0x936854")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1792650", Offset = "0x1792650", VA = "0x1792650")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1799764", Offset = "0x1799764", VA = "0x1799764")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1799784", Offset = "0x1799784", VA = "0x1799784")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936864", Offset = "0x936864")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1792A34", Offset = "0x1792A34", VA = "0x1792A34")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x17997A4", Offset = "0x17997A4", VA = "0x17997A4")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1799808", Offset = "0x1799808", VA = "0x1799808")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936874", Offset = "0x936874")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1792C20", Offset = "0x1792C20", VA = "0x1792C20")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1799864", Offset = "0x1799864", VA = "0x1799864")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x17998C8", Offset = "0x17998C8", VA = "0x17998C8")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936884", Offset = "0x936884")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1792E0C", Offset = "0x1792E0C", VA = "0x1792E0C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1799924", Offset = "0x1799924", VA = "0x1799924")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1799988", Offset = "0x1799988", VA = "0x1799988")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936894", Offset = "0x936894")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1792FFC", Offset = "0x1792FFC", VA = "0x1792FFC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1798A80", Offset = "0x1798A80", VA = "0x1798A80")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1798AA4", Offset = "0x1798AA4", VA = "0x1798AA4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368A4", Offset = "0x9368A4")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x17931C4", Offset = "0x17931C4", VA = "0x17931C4")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1798AC4", Offset = "0x1798AC4", VA = "0x1798AC4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1798AE8", Offset = "0x1798AE8", VA = "0x1798AE8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368B4", Offset = "0x9368B4")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x179339C", Offset = "0x179339C", VA = "0x179339C")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1798B08", Offset = "0x1798B08", VA = "0x1798B08")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1798B28", Offset = "0x1798B28", VA = "0x1798B28")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368C4", Offset = "0x9368C4")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1793588", Offset = "0x1793588", VA = "0x1793588")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1798B48", Offset = "0x1798B48", VA = "0x1798B48")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1798B68", Offset = "0x1798B68", VA = "0x1798B68")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368D4", Offset = "0x9368D4")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1793774", Offset = "0x1793774", VA = "0x1793774")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1798B88", Offset = "0x1798B88", VA = "0x1798B88")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1798BA8", Offset = "0x1798BA8", VA = "0x1798BA8")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368E4", Offset = "0x9368E4")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1793960", Offset = "0x1793960", VA = "0x1793960")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1798BC8", Offset = "0x1798BC8", VA = "0x1798BC8")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1798BE8", Offset = "0x1798BE8", VA = "0x1798BE8")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9368F4", Offset = "0x9368F4")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1793968", Offset = "0x1793968", VA = "0x1793968")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1798C08", Offset = "0x1798C08", VA = "0x1798C08")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1798C28", Offset = "0x1798C28", VA = "0x1798C28")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936904", Offset = "0x936904")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1793B58", Offset = "0x1793B58", VA = "0x1793B58")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1798C48", Offset = "0x1798C48", VA = "0x1798C48")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1798C68", Offset = "0x1798C68", VA = "0x1798C68")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936914", Offset = "0x936914")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1793D48", Offset = "0x1793D48", VA = "0x1793D48")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1798C88", Offset = "0x1798C88", VA = "0x1798C88")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1798CA8", Offset = "0x1798CA8", VA = "0x1798CA8")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936924", Offset = "0x936924")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1793F38", Offset = "0x1793F38", VA = "0x1793F38")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1798CC8", Offset = "0x1798CC8", VA = "0x1798CC8")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1798CE8", Offset = "0x1798CE8", VA = "0x1798CE8")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936934", Offset = "0x936934")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1794124", Offset = "0x1794124", VA = "0x1794124")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1798D58", Offset = "0x1798D58", VA = "0x1798D58")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1798D78", Offset = "0x1798D78", VA = "0x1798D78")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936944", Offset = "0x936944")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1794310", Offset = "0x1794310", VA = "0x1794310")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1798D98", Offset = "0x1798D98", VA = "0x1798D98")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1798DB8", Offset = "0x1798DB8", VA = "0x1798DB8")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936954", Offset = "0x936954")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17944E8", Offset = "0x17944E8", VA = "0x17944E8")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1798DD8", Offset = "0x1798DD8", VA = "0x1798DD8")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1798DF8", Offset = "0x1798DF8", VA = "0x1798DF8")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936964", Offset = "0x936964")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x17946C4", Offset = "0x17946C4", VA = "0x17946C4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1798E18", Offset = "0x1798E18", VA = "0x1798E18")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1798E38", Offset = "0x1798E38", VA = "0x1798E38")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936974", Offset = "0x936974")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x17948A0", Offset = "0x17948A0", VA = "0x17948A0")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1798E58", Offset = "0x1798E58", VA = "0x1798E58")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1798E78", Offset = "0x1798E78", VA = "0x1798E78")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936984", Offset = "0x936984")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x17948A8", Offset = "0x17948A8", VA = "0x17948A8")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1798E98", Offset = "0x1798E98", VA = "0x1798E98")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1798EB8", Offset = "0x1798EB8", VA = "0x1798EB8")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936994", Offset = "0x936994")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17948B0", Offset = "0x17948B0", VA = "0x17948B0")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1798ED8", Offset = "0x1798ED8", VA = "0x1798ED8")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1798F00", Offset = "0x1798F00", VA = "0x1798F00")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369A4", Offset = "0x9369A4")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1794ACC", Offset = "0x1794ACC", VA = "0x1794ACC")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1798F20", Offset = "0x1798F20", VA = "0x1798F20")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1798F48", Offset = "0x1798F48", VA = "0x1798F48")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369B4", Offset = "0x9369B4")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1794AD4", Offset = "0x1794AD4", VA = "0x1794AD4")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1798F68", Offset = "0x1798F68", VA = "0x1798F68")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1798F90", Offset = "0x1798F90", VA = "0x1798F90")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369C4", Offset = "0x9369C4")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1794F3C", Offset = "0x1794F3C", VA = "0x1794F3C")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1798FB0", Offset = "0x1798FB0", VA = "0x1798FB0")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1798FD0", Offset = "0x1798FD0", VA = "0x1798FD0")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1798FF0", Offset = "0x1798FF0", VA = "0x1798FF0")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1799024", Offset = "0x1799024", VA = "0x1799024")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1799044", Offset = "0x1799044", VA = "0x1799044")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1799064", Offset = "0x1799064", VA = "0x1799064")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369D4", Offset = "0x9369D4")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x179511C", Offset = "0x179511C", VA = "0x179511C")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1799168", Offset = "0x1799168", VA = "0x1799168")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x17991BC", Offset = "0x17991BC", VA = "0x17991BC")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369E4", Offset = "0x9369E4")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17952F4", Offset = "0x17952F4", VA = "0x17952F4")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1799208", Offset = "0x1799208", VA = "0x1799208")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1799228", Offset = "0x1799228", VA = "0x1799228")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9369F4", Offset = "0x9369F4")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17954CC", Offset = "0x17954CC", VA = "0x17954CC")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1799248", Offset = "0x1799248", VA = "0x1799248")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1799268", Offset = "0x1799268", VA = "0x1799268")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A04", Offset = "0x936A04")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17956B0", Offset = "0x17956B0", VA = "0x17956B0")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1799288", Offset = "0x1799288", VA = "0x1799288")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17992B0", Offset = "0x17992B0", VA = "0x17992B0")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A14", Offset = "0x936A14")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17956B8", Offset = "0x17956B8", VA = "0x17956B8")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17992D8", Offset = "0x17992D8", VA = "0x17992D8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1799300", Offset = "0x1799300", VA = "0x1799300")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A24", Offset = "0x936A24")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17958F0", Offset = "0x17958F0", VA = "0x17958F0")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1799328", Offset = "0x1799328", VA = "0x1799328")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1799330", Offset = "0x1799330", VA = "0x1799330")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A34", Offset = "0x936A34")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17958F8", Offset = "0x17958F8", VA = "0x17958F8")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17993CC", Offset = "0x17993CC", VA = "0x17993CC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17993F4", Offset = "0x17993F4", VA = "0x17993F4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A44", Offset = "0x936A44")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1795900", Offset = "0x1795900", VA = "0x1795900")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x179941C", Offset = "0x179941C", VA = "0x179941C")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1799444", Offset = "0x1799444", VA = "0x1799444")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A54", Offset = "0x936A54")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1795B84", Offset = "0x1795B84", VA = "0x1795B84")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x179946C", Offset = "0x179946C", VA = "0x179946C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1799478", Offset = "0x1799478", VA = "0x1799478")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A64", Offset = "0x936A64")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1795E08", Offset = "0x1795E08", VA = "0x1795E08")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1799534", Offset = "0x1799534", VA = "0x1799534")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1799540", Offset = "0x1799540", VA = "0x1799540")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A74", Offset = "0x936A74")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x179608C", Offset = "0x179608C", VA = "0x179608C")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x179964C", Offset = "0x179964C", VA = "0x179964C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1799658", Offset = "0x1799658", VA = "0x1799658")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x178D0D8", Offset = "0x178D0D8", VA = "0x178D0D8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x178C7C8", Offset = "0x178C7C8", VA = "0x178C7C8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x178CD58", Offset = "0x178CD58", VA = "0x178CD58")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x17920B4", Offset = "0x17920B4", VA = "0x17920B4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x17922A4", Offset = "0x17922A4", VA = "0x17922A4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x179246C", Offset = "0x179246C", VA = "0x179246C")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1792658", Offset = "0x1792658", VA = "0x1792658")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x1792850", Offset = "0x1792850", VA = "0x1792850")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x1792A3C", Offset = "0x1792A3C", VA = "0x1792A3C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x1792C28", Offset = "0x1792C28", VA = "0x1792C28")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1792E14", Offset = "0x1792E14", VA = "0x1792E14")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x1793004", Offset = "0x1793004", VA = "0x1793004")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x17931CC", Offset = "0x17931CC", VA = "0x17931CC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x17933A4", Offset = "0x17933A4", VA = "0x17933A4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x1793590", Offset = "0x1793590", VA = "0x1793590")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x179377C", Offset = "0x179377C", VA = "0x179377C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x178BA70", Offset = "0x178BA70", VA = "0x178BA70")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1793970", Offset = "0x1793970", VA = "0x1793970")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1793B60", Offset = "0x1793B60", VA = "0x1793B60")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x1793D50", Offset = "0x1793D50", VA = "0x1793D50")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1793F40", Offset = "0x1793F40", VA = "0x1793F40")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x179412C", Offset = "0x179412C", VA = "0x179412C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1794318", Offset = "0x1794318", VA = "0x1794318")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x17944F0", Offset = "0x17944F0", VA = "0x17944F0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x17946CC", Offset = "0x17946CC", VA = "0x17946CC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x178C3FC", Offset = "0x178C3FC", VA = "0x178C3FC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x178D4FC", Offset = "0x178D4FC", VA = "0x178D4FC")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x17948B8", Offset = "0x17948B8", VA = "0x17948B8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x178D6EC", Offset = "0x178D6EC", VA = "0x178D6EC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1794ADC", Offset = "0x1794ADC", VA = "0x1794ADC")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1794F44", Offset = "0x1794F44", VA = "0x1794F44")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1795124", Offset = "0x1795124", VA = "0x1795124")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x17952FC", Offset = "0x17952FC", VA = "0x17952FC")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x17954D4", Offset = "0x17954D4", VA = "0x17954D4")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x178C9B0", Offset = "0x178C9B0", VA = "0x178C9B0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x17956C0", Offset = "0x17956C0", VA = "0x17956C0")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x178CF18", Offset = "0x178CF18", VA = "0x178CF18")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x178D298", Offset = "0x178D298", VA = "0x178D298")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1795908", Offset = "0x1795908", VA = "0x1795908")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1795B8C", Offset = "0x1795B8C", VA = "0x1795B8C")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1795E10", Offset = "0x1795E10", VA = "0x1795E10")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936A94", Offset = "0x936A94")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1796D18", Offset = "0x1796D18", VA = "0x1796D18")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x17999E4", Offset = "0x17999E4", VA = "0x17999E4")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1799A0C", Offset = "0x1799A0C", VA = "0x1799A0C")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AA4", Offset = "0x936AA4")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1796F60", Offset = "0x1796F60", VA = "0x1796F60")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1799A34", Offset = "0x1799A34", VA = "0x1799A34")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1799A5C", Offset = "0x1799A5C", VA = "0x1799A5C")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x200004B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AB4", Offset = "0x936AB4")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
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
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1799A84", Offset = "0x1799A84", VA = "0x1799A84", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1799CC8", Offset = "0x1799CC8", VA = "0x1799CC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AC4", Offset = "0x936AC4")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x179A3D8", Offset = "0x179A3D8", VA = "0x179A3D8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x179A640", Offset = "0x179A640", VA = "0x179A640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AD4", Offset = "0x936AD4")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1799F2C", Offset = "0x1799F2C", VA = "0x1799F2C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x179A15C", Offset = "0x179A15C", VA = "0x179A15C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AE4", Offset = "0x936AE4")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1799CD4", Offset = "0x1799CD4", VA = "0x1799CD4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1799F20", Offset = "0x1799F20", VA = "0x1799F20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936AF4", Offset = "0x936AF4")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x179A168", Offset = "0x179A168", VA = "0x179A168", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x179A3CC", Offset = "0x179A3CC", VA = "0x179A3CC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936B04", Offset = "0x936B04")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x179A64C", Offset = "0x179A64C", VA = "0x179A64C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x179A884", Offset = "0x179A884", VA = "0x179A884", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x1796094", Offset = "0x1796094", VA = "0x1796094")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x1796288", Offset = "0x1796288", VA = "0x1796288")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1796490", Offset = "0x1796490", VA = "0x1796490")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x1796590", Offset = "0x1796590", VA = "0x1796590")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x1796690", Offset = "0x1796690", VA = "0x1796690")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x1796790", Offset = "0x1796790", VA = "0x1796790")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x17968B4", Offset = "0x17968B4", VA = "0x17968B4")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x17969D8", Offset = "0x17969D8", VA = "0x17969D8")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x1796AD8", Offset = "0x1796AD8", VA = "0x1796AD8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x1796D20", Offset = "0x1796D20", VA = "0x1796D20")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x1796F68", Offset = "0x1796F68", VA = "0x1796F68")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x93711C", Offset = "0x93711C")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1797088", Offset = "0x1797088", VA = "0x1797088")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x937194", Offset = "0x937194")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x17971A8", Offset = "0x17971A8", VA = "0x17971A8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x93720C", Offset = "0x93720C")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x17972C8", Offset = "0x17972C8", VA = "0x17972C8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x937284", Offset = "0x937284")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x17973F8", Offset = "0x17973F8", VA = "0x17973F8")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x9372FC", Offset = "0x9372FC")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1797528", Offset = "0x1797528", VA = "0x1797528")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0x937374", Offset = "0x937374")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000051")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000052")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x1797EA0", Offset = "0x1797EA0", VA = "0x1797EA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x179655C", Offset = "0x179655C", VA = "0x179655C")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000053")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1797FA4", Offset = "0x1797FA4", VA = "0x1797FA4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x179665C", Offset = "0x179665C", VA = "0x179665C")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000054")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1797F20", Offset = "0x1797F20", VA = "0x1797F20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x179675C", Offset = "0x179675C", VA = "0x179675C")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000055")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1797ED4", Offset = "0x1797ED4", VA = "0x1797ED4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x179686C", Offset = "0x179686C", VA = "0x179686C")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000056")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x1797F40", Offset = "0x1797F40", VA = "0x1797F40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1796990", Offset = "0x1796990", VA = "0x1796990")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x1798008", Offset = "0x1798008", VA = "0x1798008", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1796AA4", Offset = "0x1796AA4", VA = "0x1796AA4")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000058")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000059")]
	public static class Physics
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x179A890", Offset = "0x179A890", VA = "0x179A890")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x179A994", Offset = "0x179A994", VA = "0x179A994")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x179AA2C", Offset = "0x179AA2C", VA = "0x179AA2C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x179AAC4", Offset = "0x179AAC4", VA = "0x179AAC4")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x1797648", Offset = "0x1797648", VA = "0x1797648")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x179770C", Offset = "0x179770C", VA = "0x179770C")]
	[Preserve]
	private static void Preserver()
	{
	}
}
[Token(Token = "0x200005A")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x936B14", Offset = "0x936B14")]
public class DOTweenAnimation : ABSAnimationComponent
{
	[Token(Token = "0x200005B")]
	public enum AnimationType
	{
		[Token(Token = "0x40000AB")]
		None,
		[Token(Token = "0x40000AC")]
		Move,
		[Token(Token = "0x40000AD")]
		LocalMove,
		[Token(Token = "0x40000AE")]
		Rotate,
		[Token(Token = "0x40000AF")]
		LocalRotate,
		[Token(Token = "0x40000B0")]
		Scale,
		[Token(Token = "0x40000B1")]
		Color,
		[Token(Token = "0x40000B2")]
		Fade,
		[Token(Token = "0x40000B3")]
		Text,
		[Token(Token = "0x40000B4")]
		PunchPosition,
		[Token(Token = "0x40000B5")]
		PunchRotation,
		[Token(Token = "0x40000B6")]
		PunchScale,
		[Token(Token = "0x40000B7")]
		ShakePosition,
		[Token(Token = "0x40000B8")]
		ShakeRotation,
		[Token(Token = "0x40000B9")]
		ShakeScale,
		[Token(Token = "0x40000BA")]
		CameraAspect,
		[Token(Token = "0x40000BB")]
		CameraBackgroundColor,
		[Token(Token = "0x40000BC")]
		CameraFieldOfView,
		[Token(Token = "0x40000BD")]
		CameraOrthoSize,
		[Token(Token = "0x40000BE")]
		CameraPixelRect,
		[Token(Token = "0x40000BF")]
		CameraRect,
		[Token(Token = "0x40000C0")]
		UIWidthHeight
	}

	[Token(Token = "0x200005C")]
	public enum TargetType
	{
		[Token(Token = "0x40000C2")]
		Unset,
		[Token(Token = "0x40000C3")]
		Camera,
		[Token(Token = "0x40000C4")]
		CanvasGroup,
		[Token(Token = "0x40000C5")]
		Image,
		[Token(Token = "0x40000C6")]
		Light,
		[Token(Token = "0x40000C7")]
		RectTransform,
		[Token(Token = "0x40000C8")]
		Renderer,
		[Token(Token = "0x40000C9")]
		SpriteRenderer,
		[Token(Token = "0x40000CA")]
		Rigidbody,
		[Token(Token = "0x40000CB")]
		Rigidbody2D,
		[Token(Token = "0x40000CC")]
		Text,
		[Token(Token = "0x40000CD")]
		Transform,
		[Token(Token = "0x40000CE")]
		tk2dBaseSprite,
		[Token(Token = "0x40000CF")]
		tk2dTextMesh,
		[Token(Token = "0x40000D0")]
		TextMeshPro,
		[Token(Token = "0x40000D1")]
		TextMeshProUGUI
	}

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool targetIsSelf;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject targetGO;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool tweenTargetIsTargetGO;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float delay;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float duration;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Ease easeType;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AnimationCurve easeCurve;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public LoopType loopType;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public int loops;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public string id;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool isRelative;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	public bool isFrom;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	public bool isIndependentUpdate;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	public bool autoKill;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool isActive;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
	public bool isValid;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Component target;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public AnimationType animationType;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public TargetType targetType;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TargetType forcedTargetType;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public bool autoPlay;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	public bool useTargetAsV3;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float endValueFloat;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public Vector3 endValueV3;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Vector2 endValueV2;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Color endValueColor;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public string endValueString;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Rect endValueRect;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform endValueTransform;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public bool optionalBool0;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
	public float optionalFloat0;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int optionalInt0;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	public RotateMode optionalRotationMode;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public ScrambleMode optionalScrambleMode;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string optionalString;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool _tweenCreated;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private int _playCount;

	[Token(Token = "0x14000001")]
	public static event Action<DOTweenAnimation> OnReset
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1789E74", Offset = "0x1789E74", VA = "0x1789E74")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93748C", Offset = "0x93748C")]
		add
		{
		}
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1789F30", Offset = "0x1789F30", VA = "0x1789F30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x93749C", Offset = "0x93749C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x1789FEC", Offset = "0x1789FEC", VA = "0x1789FEC")]
	private static void Dispatch_OnReset(DOTweenAnimation anim)
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x178A074", Offset = "0x178A074", VA = "0x178A074")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x178B554", Offset = "0x178B554", VA = "0x178B554")]
	private void Start()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x178B598", Offset = "0x178B598", VA = "0x178B598")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x178B59C", Offset = "0x178B59C", VA = "0x178B59C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x178A0C4", Offset = "0x178A0C4", VA = "0x178A0C4")]
	public void CreateTween()
	{
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x178D904", Offset = "0x178D904", VA = "0x178D904", Slot = "4")]
	public override void DOPlay()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x178D984", Offset = "0x178D984", VA = "0x178D984", Slot = "5")]
	public override void DOPlayBackwards()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x178DA04", Offset = "0x178DA04", VA = "0x178DA04", Slot = "6")]
	public override void DOPlayForward()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x178DA84", Offset = "0x178DA84", VA = "0x178DA84", Slot = "7")]
	public override void DOPause()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x178DB04", Offset = "0x178DB04", VA = "0x178DB04", Slot = "8")]
	public override void DOTogglePause()
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x178DB84", Offset = "0x178DB84", VA = "0x178DB84", Slot = "9")]
	public override void DORewind()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x178DC7C", Offset = "0x178DC7C", VA = "0x178DC7C", Slot = "10")]
	public override void DORestart()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x178DC8C", Offset = "0x178DC8C", VA = "0x178DC8C", Slot = "11")]
	public override void DORestart(bool fromHere)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x178E014", Offset = "0x178E014", VA = "0x178E014", Slot = "12")]
	public override void DOComplete()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x178E098", Offset = "0x178E098", VA = "0x178E098", Slot = "13")]
	public override void DOKill()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x178E12C", Offset = "0x178E12C", VA = "0x178E12C")]
	public void DOPlayById(string id)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x178E1B4", Offset = "0x178E1B4", VA = "0x178E1B4")]
	public void DOPlayAllById(string id)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x178E220", Offset = "0x178E220", VA = "0x178E220")]
	public void DOPauseAllById(string id)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x178E28C", Offset = "0x178E28C", VA = "0x178E28C")]
	public void DOPlayBackwardsById(string id)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x178E314", Offset = "0x178E314", VA = "0x178E314")]
	public void DOPlayBackwardsAllById(string id)
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x178E380", Offset = "0x178E380", VA = "0x178E380")]
	public void DOPlayForwardById(string id)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x178E408", Offset = "0x178E408", VA = "0x178E408")]
	public void DOPlayForwardAllById(string id)
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x178E474", Offset = "0x178E474", VA = "0x178E474")]
	public void DOPlayNext()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x178E5CC", Offset = "0x178E5CC", VA = "0x178E5CC")]
	public void DORewindAndPlayNext()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x178E660", Offset = "0x178E660", VA = "0x178E660")]
	public void DORewindAllById(string id)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x178E6DC", Offset = "0x178E6DC", VA = "0x178E6DC")]
	public void DORestartById(string id)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x178E774", Offset = "0x178E774", VA = "0x178E774")]
	public void DORestartAllById(string id)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x178E7F4", Offset = "0x178E7F4", VA = "0x178E7F4")]
	public List<Tween> GetTweens()
	{
		return null;
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x178B600", Offset = "0x178B600", VA = "0x178B600")]
	public static TargetType TypeToDOTargetType(Type t)
	{
		return default(TargetType);
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x178E908", Offset = "0x178E908", VA = "0x178E908")]
	public Tween CreateEditorPreview()
	{
		return null;
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x178B5E8", Offset = "0x178B5E8", VA = "0x178B5E8")]
	private GameObject GetTweenGO()
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x178DDA0", Offset = "0x178DDA0", VA = "0x178DDA0")]
	private void ReEvaluateRelativeTween()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x178E944", Offset = "0x178E944", VA = "0x178E944")]
	public DOTweenAnimation()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x178EB50", Offset = "0x178EB50", VA = "0x178EB50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9374AC", Offset = "0x9374AC")]
	private void <CreateTween>b__47_0()
	{
	}
}
[Token(Token = "0x200005D")]
public static class DOTweenAnimationExtensions
{
	[Token(Token = "0x6000168")]
	public static bool IsSameOrSubclassOf<T>(this Component t)
	{
		return default(bool);
	}
}
[Token(Token = "0x200005E")]
public static class DOTweenProShortcuts
{
	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936B6C", Offset = "0x936B6C")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform target;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1797B4C", Offset = "0x1797B4C", VA = "0x1797B4C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x179AC14", Offset = "0x179AC14", VA = "0x179AC14")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x179AC34", Offset = "0x179AC34", VA = "0x179AC34")]
		internal void <DOSpiral>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x936B7C", Offset = "0x936B7C")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x1797E98", Offset = "0x1797E98", VA = "0x1797E98")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x179AC54", Offset = "0x179AC54", VA = "0x179AC54")]
		internal Vector3 <DOSpiral>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x17977C0", Offset = "0x17977C0", VA = "0x17977C0")]
	static DOTweenProShortcuts()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x179780C", Offset = "0x179780C", VA = "0x179780C")]
	public static Tweener DOSpiral(this Transform target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x1797B54", Offset = "0x1797B54", VA = "0x1797B54")]
	public static Tweener DOSpiral(this Rigidbody target, float duration, [Optional] Vector3? axis, SpiralMode mode = SpiralMode.Expand, float speed = 1f, float frequency = 10f, float depth = 0f, bool snapping = false)
	{
		return null;
	}
}
