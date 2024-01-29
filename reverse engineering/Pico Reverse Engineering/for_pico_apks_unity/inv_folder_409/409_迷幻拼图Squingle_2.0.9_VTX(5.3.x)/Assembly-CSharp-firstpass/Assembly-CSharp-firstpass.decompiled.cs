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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839208", Offset = "0x839208")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x19C26A4", Offset = "0x19C26A4", VA = "0x19C26A4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x19CCB08", Offset = "0x19CCB08", VA = "0x19CCB08")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x19CCB24", Offset = "0x19CCB24", VA = "0x19CCB24")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839218", Offset = "0x839218")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x19C2854", Offset = "0x19C2854", VA = "0x19C2854")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x19CCB40", Offset = "0x19CCB40", VA = "0x19CCB40")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x19CCB5C", Offset = "0x19CCB5C", VA = "0x19CCB5C")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839228", Offset = "0x839228")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x19C2A18", Offset = "0x19C2A18", VA = "0x19C2A18")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x19CCB78", Offset = "0x19CCB78", VA = "0x19CCB78")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x19CCBB8", Offset = "0x19CCBB8", VA = "0x19CCBB8")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x19C24D4", Offset = "0x19C24D4", VA = "0x19C24D4")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x19C26AC", Offset = "0x19C26AC", VA = "0x19C26AC")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x19C285C", Offset = "0x19C285C", VA = "0x19C285C")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x19C2A20", Offset = "0x19C2A20", VA = "0x19C2A20")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x19C2A94", Offset = "0x19C2A94", VA = "0x19C2A94")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x19C2B08", Offset = "0x19C2B08", VA = "0x19C2B08")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x19C2B6C", Offset = "0x19C2B6C", VA = "0x19C2B6C")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x19C2BF0", Offset = "0x19C2BF0", VA = "0x19C2BF0")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x19C2C54", Offset = "0x19C2C54", VA = "0x19C2C54")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x19C2CB8", Offset = "0x19C2CB8", VA = "0x19C2CB8")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x19C2D1C", Offset = "0x19C2D1C", VA = "0x19C2D1C")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x19C2D80", Offset = "0x19C2D80", VA = "0x19C2D80")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x19C2DEC", Offset = "0x19C2DEC", VA = "0x19C2DEC")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x19C2E54", Offset = "0x19C2E54", VA = "0x19C2E54")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x19C2EB8", Offset = "0x19C2EB8", VA = "0x19C2EB8")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839248", Offset = "0x839248")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x19C30F8", Offset = "0x19C30F8", VA = "0x19C30F8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x19CCBDC", Offset = "0x19CCBDC", VA = "0x19CCBDC")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839258", Offset = "0x839258")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x19C32D0", Offset = "0x19C32D0", VA = "0x19C32D0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x19CCD14", Offset = "0x19CCD14", VA = "0x19CCD14")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839268", Offset = "0x839268")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x19C34A8", Offset = "0x19C34A8", VA = "0x19C34A8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x19CCD30", Offset = "0x19CCD30", VA = "0x19CCD30")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839278", Offset = "0x839278")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x19C3680", Offset = "0x19C3680", VA = "0x19C3680")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x19CCD4C", Offset = "0x19CCD4C", VA = "0x19CCD4C")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839288", Offset = "0x839288")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x19C3860", Offset = "0x19C3860", VA = "0x19C3860")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x19CCD68", Offset = "0x19CCD68", VA = "0x19CCD68")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839298", Offset = "0x839298")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x19C3ABC", Offset = "0x19C3ABC", VA = "0x19C3ABC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x19CCD84", Offset = "0x19CCD84", VA = "0x19CCD84")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392A8", Offset = "0x8392A8")]
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
		[Address(RVA = "0x19C3FF8", Offset = "0x19C3FF8", VA = "0x19C3FF8")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x19CCDA0", Offset = "0x19CCDA0", VA = "0x19CCDA0")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x19CCDBC", Offset = "0x19CCDBC", VA = "0x19CCDBC")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x19CCDF0", Offset = "0x19CCDF0", VA = "0x19CCDF0")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x19CCE0C", Offset = "0x19CCE0C", VA = "0x19CCE0C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x19CCE28", Offset = "0x19CCE28", VA = "0x19CCE28")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392B8", Offset = "0x8392B8")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x19C427C", Offset = "0x19C427C", VA = "0x19C427C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x19CCEE8", Offset = "0x19CCEE8", VA = "0x19CCEE8")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392C8", Offset = "0x8392C8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x19C4520", Offset = "0x19C4520", VA = "0x19C4520")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x19CCF04", Offset = "0x19CCF04", VA = "0x19CCF04")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x19CCF20", Offset = "0x19CCF20", VA = "0x19CCF20")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392D8", Offset = "0x8392D8")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x19C4718", Offset = "0x19C4718", VA = "0x19C4718")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x19CD020", Offset = "0x19CD020", VA = "0x19CD020")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8392E8", Offset = "0x8392E8")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x19C4930", Offset = "0x19C4930", VA = "0x19C4930")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x19CCBF8", Offset = "0x19CCBF8", VA = "0x19CCBF8")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x19CCC14", Offset = "0x19CCC14", VA = "0x19CCC14")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x19C2F1C", Offset = "0x19C2F1C", VA = "0x19C2F1C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x19C3100", Offset = "0x19C3100", VA = "0x19C3100")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x19C32D8", Offset = "0x19C32D8", VA = "0x19C32D8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x19C34B0", Offset = "0x19C34B0", VA = "0x19C34B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x19C3688", Offset = "0x19C3688", VA = "0x19C3688")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x19C3868", Offset = "0x19C3868", VA = "0x19C3868")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x19C3AC4", Offset = "0x19C3AC4", VA = "0x19C3AC4")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x19C4000", Offset = "0x19C4000", VA = "0x19C4000")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x19C4284", Offset = "0x19C4284", VA = "0x19C4284")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x19C4528", Offset = "0x19C4528", VA = "0x19C4528")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x19C4720", Offset = "0x19C4720", VA = "0x19C4720")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839308", Offset = "0x839308")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x19C4B0C", Offset = "0x19C4B0C", VA = "0x19C4B0C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x19CD03C", Offset = "0x19CD03C", VA = "0x19CD03C")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839318", Offset = "0x839318")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x19C4CE0", Offset = "0x19C4CE0", VA = "0x19C4CE0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x19CD058", Offset = "0x19CD058", VA = "0x19CD058")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839328", Offset = "0x839328")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x19C4EB4", Offset = "0x19C4EB4", VA = "0x19C4EB4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x19CD074", Offset = "0x19CD074", VA = "0x19CD074")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839338", Offset = "0x839338")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x19C5068", Offset = "0x19C5068", VA = "0x19C5068")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x19CD090", Offset = "0x19CD090", VA = "0x19CD090")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839348", Offset = "0x839348")]
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
		[Address(RVA = "0x19C54CC", Offset = "0x19C54CC", VA = "0x19C54CC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x19CD0AC", Offset = "0x19CD0AC", VA = "0x19CD0AC")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x19CD0C8", Offset = "0x19CD0C8", VA = "0x19CD0C8")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x19CD0E4", Offset = "0x19CD0E4", VA = "0x19CD0E4")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x19CD118", Offset = "0x19CD118", VA = "0x19CD118")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x19CD134", Offset = "0x19CD134", VA = "0x19CD134")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x19CD150", Offset = "0x19CD150", VA = "0x19CD150")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839358", Offset = "0x839358")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x19C57D4", Offset = "0x19C57D4", VA = "0x19C57D4")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x19CD208", Offset = "0x19CD208", VA = "0x19CD208")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x19CD230", Offset = "0x19CD230", VA = "0x19CD230")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839368", Offset = "0x839368")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x19C5B00", Offset = "0x19C5B00", VA = "0x19C5B00")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x19CD24C", Offset = "0x19CD24C", VA = "0x19CD24C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x19CD268", Offset = "0x19CD268", VA = "0x19CD268")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x19C4938", Offset = "0x19C4938", VA = "0x19C4938")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x19C4B14", Offset = "0x19C4B14", VA = "0x19C4B14")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x19C4CE8", Offset = "0x19C4CE8", VA = "0x19C4CE8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x19C4EBC", Offset = "0x19C4EBC", VA = "0x19C4EBC")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x19C5070", Offset = "0x19C5070", VA = "0x19C5070")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x19C54D4", Offset = "0x19C54D4", VA = "0x19C54D4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x19C57DC", Offset = "0x19C57DC", VA = "0x19C57DC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839388", Offset = "0x839388")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x19C5CD8", Offset = "0x19C5CD8", VA = "0x19C5CD8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x19CD360", Offset = "0x19CD360", VA = "0x19CD360")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x19CD37C", Offset = "0x19CD37C", VA = "0x19CD37C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839398", Offset = "0x839398")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x19C5E88", Offset = "0x19C5E88", VA = "0x19C5E88")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x19CD398", Offset = "0x19CD398", VA = "0x19CD398")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x19CD3B4", Offset = "0x19CD3B4", VA = "0x19CD3B4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393A8", Offset = "0x8393A8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x19C62D8", Offset = "0x19C62D8", VA = "0x19C62D8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x19CD3D0", Offset = "0x19CD3D0", VA = "0x19CD3D0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x19CD3DC", Offset = "0x19CD3DC", VA = "0x19CD3DC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x19C5B08", Offset = "0x19C5B08", VA = "0x19C5B08")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x19C5CE0", Offset = "0x19C5CE0", VA = "0x19C5CE0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x19C5E90", Offset = "0x19C5E90", VA = "0x19C5E90")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x19C607C", Offset = "0x19C607C", VA = "0x19C607C")]
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
		[Address(RVA = "0x19CE330", Offset = "0x19CE330", VA = "0x19CE330")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393C8", Offset = "0x8393C8")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x19C6488", Offset = "0x19C6488", VA = "0x19C6488")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x19CD488", Offset = "0x19CD488", VA = "0x19CD488")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x19CD4A4", Offset = "0x19CD4A4", VA = "0x19CD4A4")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393D8", Offset = "0x8393D8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x19C6660", Offset = "0x19C6660", VA = "0x19C6660")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x19CD6F8", Offset = "0x19CD6F8", VA = "0x19CD6F8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x19CD71C", Offset = "0x19CD71C", VA = "0x19CD71C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393E8", Offset = "0x8393E8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x19C6810", Offset = "0x19C6810", VA = "0x19C6810")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x19CDAB4", Offset = "0x19CDAB4", VA = "0x19CDAB4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x19CDAD8", Offset = "0x19CDAD8", VA = "0x19CDAD8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8393F8", Offset = "0x8393F8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x19C69E8", Offset = "0x19C69E8", VA = "0x19C69E8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x19CDF60", Offset = "0x19CDF60", VA = "0x19CDF60")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x19CDF84", Offset = "0x19CDF84", VA = "0x19CDF84")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839408", Offset = "0x839408")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x19C6B98", Offset = "0x19C6B98", VA = "0x19C6B98")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x19CE070", Offset = "0x19CE070", VA = "0x19CE070")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x19CE094", Offset = "0x19CE094", VA = "0x19CE094")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839418", Offset = "0x839418")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x19C6D6C", Offset = "0x19C6D6C", VA = "0x19C6D6C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x19CE0B8", Offset = "0x19CE0B8", VA = "0x19CE0B8")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x19CE0D4", Offset = "0x19CE0D4", VA = "0x19CE0D4")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839428", Offset = "0x839428")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x19C7138", Offset = "0x19C7138", VA = "0x19C7138")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x19CE0F0", Offset = "0x19CE0F0", VA = "0x19CE0F0")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x19CE154", Offset = "0x19CE154", VA = "0x19CE154")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839438", Offset = "0x839438")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x19C7310", Offset = "0x19C7310", VA = "0x19C7310")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x19CE1B0", Offset = "0x19CE1B0", VA = "0x19CE1B0")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x19CE214", Offset = "0x19CE214", VA = "0x19CE214")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839448", Offset = "0x839448")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x19C74E8", Offset = "0x19C74E8", VA = "0x19C74E8")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x19CE270", Offset = "0x19CE270", VA = "0x19CE270")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x19CE2D4", Offset = "0x19CE2D4", VA = "0x19CE2D4")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839458", Offset = "0x839458")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x19C76C0", Offset = "0x19C76C0", VA = "0x19C76C0")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x19CD4C0", Offset = "0x19CD4C0", VA = "0x19CD4C0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x19CD4E0", Offset = "0x19CD4E0", VA = "0x19CD4E0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839468", Offset = "0x839468")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x19C7870", Offset = "0x19C7870", VA = "0x19C7870")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x19CD4FC", Offset = "0x19CD4FC", VA = "0x19CD4FC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x19CD51C", Offset = "0x19CD51C", VA = "0x19CD51C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839478", Offset = "0x839478")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x19C7A30", Offset = "0x19C7A30", VA = "0x19C7A30")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x19CD538", Offset = "0x19CD538", VA = "0x19CD538")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x19CD554", Offset = "0x19CD554", VA = "0x19CD554")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839488", Offset = "0x839488")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x19C7C08", Offset = "0x19C7C08", VA = "0x19C7C08")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x19CD570", Offset = "0x19CD570", VA = "0x19CD570")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x19CD58C", Offset = "0x19CD58C", VA = "0x19CD58C")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839498", Offset = "0x839498")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x19C7DD8", Offset = "0x19C7DD8", VA = "0x19C7DD8")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x19CD5A8", Offset = "0x19CD5A8", VA = "0x19CD5A8")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x19CD5C4", Offset = "0x19CD5C4", VA = "0x19CD5C4")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394A8", Offset = "0x8394A8")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x19C7FA8", Offset = "0x19C7FA8", VA = "0x19C7FA8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x19CD5E0", Offset = "0x19CD5E0", VA = "0x19CD5E0")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x19CD5FC", Offset = "0x19CD5FC", VA = "0x19CD5FC")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394B8", Offset = "0x8394B8")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x19C8188", Offset = "0x19C8188", VA = "0x19C8188")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x19CD618", Offset = "0x19CD618", VA = "0x19CD618")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x19CD634", Offset = "0x19CD634", VA = "0x19CD634")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394C8", Offset = "0x8394C8")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x19C835C", Offset = "0x19C835C", VA = "0x19C835C")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x19CD650", Offset = "0x19CD650", VA = "0x19CD650")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x19CD66C", Offset = "0x19CD66C", VA = "0x19CD66C")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394D8", Offset = "0x8394D8")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x19C8530", Offset = "0x19C8530", VA = "0x19C8530")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x19CD688", Offset = "0x19CD688", VA = "0x19CD688")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x19CD6A4", Offset = "0x19CD6A4", VA = "0x19CD6A4")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394E8", Offset = "0x8394E8")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x19C8704", Offset = "0x19C8704", VA = "0x19C8704")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x19CD6C0", Offset = "0x19CD6C0", VA = "0x19CD6C0")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x19CD6DC", Offset = "0x19CD6DC", VA = "0x19CD6DC")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8394F8", Offset = "0x8394F8")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x19C88DC", Offset = "0x19C88DC", VA = "0x19C88DC")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x19CD740", Offset = "0x19CD740", VA = "0x19CD740")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x19CD75C", Offset = "0x19CD75C", VA = "0x19CD75C")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839508", Offset = "0x839508")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x19C8AB4", Offset = "0x19C8AB4", VA = "0x19C8AB4")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x19CD778", Offset = "0x19CD778", VA = "0x19CD778")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x19CD794", Offset = "0x19CD794", VA = "0x19CD794")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839518", Offset = "0x839518")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x19C8C74", Offset = "0x19C8C74", VA = "0x19C8C74")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x19CD7B0", Offset = "0x19CD7B0", VA = "0x19CD7B0")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x19CD7CC", Offset = "0x19CD7CC", VA = "0x19CD7CC")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839528", Offset = "0x839528")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x19C8E38", Offset = "0x19C8E38", VA = "0x19C8E38")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x19CD7E8", Offset = "0x19CD7E8", VA = "0x19CD7E8")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x19CD804", Offset = "0x19CD804", VA = "0x19CD804")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839538", Offset = "0x839538")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x19C8FFC", Offset = "0x19C8FFC", VA = "0x19C8FFC")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x19CD820", Offset = "0x19CD820", VA = "0x19CD820")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x19CD83C", Offset = "0x19CD83C", VA = "0x19CD83C")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839548", Offset = "0x839548")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x19C91D4", Offset = "0x19C91D4", VA = "0x19C91D4")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x19CD858", Offset = "0x19CD858", VA = "0x19CD858")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x19CD874", Offset = "0x19CD874", VA = "0x19CD874")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839558", Offset = "0x839558")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x19C93B4", Offset = "0x19C93B4", VA = "0x19C93B4")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x19CD890", Offset = "0x19CD890", VA = "0x19CD890")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x19CD8B8", Offset = "0x19CD8B8", VA = "0x19CD8B8")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839568", Offset = "0x839568")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x19C95BC", Offset = "0x19C95BC", VA = "0x19C95BC")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x19CD8D4", Offset = "0x19CD8D4", VA = "0x19CD8D4")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x19CD8FC", Offset = "0x19CD8FC", VA = "0x19CD8FC")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839578", Offset = "0x839578")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x19C97CC", Offset = "0x19C97CC", VA = "0x19C97CC")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x19CD918", Offset = "0x19CD918", VA = "0x19CD918")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x19CD940", Offset = "0x19CD940", VA = "0x19CD940")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839588", Offset = "0x839588")]
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
		[Address(RVA = "0x19C9C28", Offset = "0x19C9C28", VA = "0x19C9C28")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x19CD95C", Offset = "0x19CD95C", VA = "0x19CD95C")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x19CD978", Offset = "0x19CD978", VA = "0x19CD978")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x19CD994", Offset = "0x19CD994", VA = "0x19CD994")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x19CD9C8", Offset = "0x19CD9C8", VA = "0x19CD9C8")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x19CD9E4", Offset = "0x19CD9E4", VA = "0x19CD9E4")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x19CDA00", Offset = "0x19CDA00", VA = "0x19CDA00")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839598", Offset = "0x839598")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x19C9DF4", Offset = "0x19C9DF4", VA = "0x19C9DF4")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x19CDAFC", Offset = "0x19CDAFC", VA = "0x19CDAFC")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x19CDB50", Offset = "0x19CDB50", VA = "0x19CDB50")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395A8", Offset = "0x8395A8")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x19C9FB0", Offset = "0x19C9FB0", VA = "0x19C9FB0")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x19CDB9C", Offset = "0x19CDB9C", VA = "0x19CDB9C")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x19CDBB8", Offset = "0x19CDBB8", VA = "0x19CDBB8")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395B8", Offset = "0x8395B8")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x19CA16C", Offset = "0x19CA16C", VA = "0x19CA16C")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x19CDBD4", Offset = "0x19CDBD4", VA = "0x19CDBD4")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x19CDBF0", Offset = "0x19CDBF0", VA = "0x19CDBF0")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395C8", Offset = "0x8395C8")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x19CA334", Offset = "0x19CA334", VA = "0x19CA334")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x19CDC0C", Offset = "0x19CDC0C", VA = "0x19CDC0C")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x19CDC30", Offset = "0x19CDC30", VA = "0x19CDC30")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395D8", Offset = "0x8395D8")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x19CA50C", Offset = "0x19CA50C", VA = "0x19CA50C")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x19CDC54", Offset = "0x19CDC54", VA = "0x19CDC54")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x19CDC78", Offset = "0x19CDC78", VA = "0x19CDC78")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395E8", Offset = "0x8395E8")]
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
		[Address(RVA = "0x19CA73C", Offset = "0x19CA73C", VA = "0x19CA73C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x19CDC9C", Offset = "0x19CDC9C", VA = "0x19CDC9C")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x19CDCA4", Offset = "0x19CDCA4", VA = "0x19CDCA4")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8395F8", Offset = "0x8395F8")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x19CA8EC", Offset = "0x19CA8EC", VA = "0x19CA8EC")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x19CDD40", Offset = "0x19CDD40", VA = "0x19CDD40")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x19CDD64", Offset = "0x19CDD64", VA = "0x19CDD64")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839608", Offset = "0x839608")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x19CAB48", Offset = "0x19CAB48", VA = "0x19CAB48")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x19CDD88", Offset = "0x19CDD88", VA = "0x19CDD88")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x19CDDAC", Offset = "0x19CDDAC", VA = "0x19CDDAC")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839618", Offset = "0x839618")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x19CADB4", Offset = "0x19CADB4", VA = "0x19CADB4")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x19CDDD0", Offset = "0x19CDDD0", VA = "0x19CDDD0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x19CDDDC", Offset = "0x19CDDDC", VA = "0x19CDDDC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839628", Offset = "0x839628")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x19CB020", Offset = "0x19CB020", VA = "0x19CB020")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x19CDE98", Offset = "0x19CDE98", VA = "0x19CDE98")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x19CDEA4", Offset = "0x19CDEA4", VA = "0x19CDEA4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839638", Offset = "0x839638")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x19CB28C", Offset = "0x19CB28C", VA = "0x19CB28C")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x19CDFA8", Offset = "0x19CDFA8", VA = "0x19CDFA8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x19CDFB4", Offset = "0x19CDFB4", VA = "0x19CDFB4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x19C62E0", Offset = "0x19C62E0", VA = "0x19C62E0")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x19C6490", Offset = "0x19C6490", VA = "0x19C6490")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x19C6668", Offset = "0x19C6668", VA = "0x19C6668")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x19C6818", Offset = "0x19C6818", VA = "0x19C6818")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x19C69F0", Offset = "0x19C69F0", VA = "0x19C69F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x19C6BA0", Offset = "0x19C6BA0", VA = "0x19C6BA0")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x19C6D74", Offset = "0x19C6D74", VA = "0x19C6D74")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x19C6F68", Offset = "0x19C6F68", VA = "0x19C6F68")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x19C7140", Offset = "0x19C7140", VA = "0x19C7140")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x19C7318", Offset = "0x19C7318", VA = "0x19C7318")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x19C74F0", Offset = "0x19C74F0", VA = "0x19C74F0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x19C76C8", Offset = "0x19C76C8", VA = "0x19C76C8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x19C7878", Offset = "0x19C7878", VA = "0x19C7878")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x19C7A38", Offset = "0x19C7A38", VA = "0x19C7A38")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x19C7C10", Offset = "0x19C7C10", VA = "0x19C7C10")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x19C7DE0", Offset = "0x19C7DE0", VA = "0x19C7DE0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x19C7FB0", Offset = "0x19C7FB0", VA = "0x19C7FB0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x19C8190", Offset = "0x19C8190", VA = "0x19C8190")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x19C8364", Offset = "0x19C8364", VA = "0x19C8364")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x19C8538", Offset = "0x19C8538", VA = "0x19C8538")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x19C870C", Offset = "0x19C870C", VA = "0x19C870C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x19C88E4", Offset = "0x19C88E4", VA = "0x19C88E4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x19C8ABC", Offset = "0x19C8ABC", VA = "0x19C8ABC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x19C8C7C", Offset = "0x19C8C7C", VA = "0x19C8C7C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x19C8E40", Offset = "0x19C8E40", VA = "0x19C8E40")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x19C9004", Offset = "0x19C9004", VA = "0x19C9004")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x19C91DC", Offset = "0x19C91DC", VA = "0x19C91DC")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x19C93BC", Offset = "0x19C93BC", VA = "0x19C93BC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x19C95C4", Offset = "0x19C95C4", VA = "0x19C95C4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x19C97D4", Offset = "0x19C97D4", VA = "0x19C97D4")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x19C9C30", Offset = "0x19C9C30", VA = "0x19C9C30")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x19C9DFC", Offset = "0x19C9DFC", VA = "0x19C9DFC")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x19C9FB8", Offset = "0x19C9FB8", VA = "0x19C9FB8")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x19CA174", Offset = "0x19CA174", VA = "0x19CA174")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x19CA33C", Offset = "0x19CA33C", VA = "0x19CA33C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x19CA514", Offset = "0x19CA514", VA = "0x19CA514")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x19CA744", Offset = "0x19CA744", VA = "0x19CA744")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x19CA8F4", Offset = "0x19CA8F4", VA = "0x19CA8F4")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x19CAB50", Offset = "0x19CAB50", VA = "0x19CAB50")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x19CADBC", Offset = "0x19CADBC", VA = "0x19CADBC")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x19CB028", Offset = "0x19CB028", VA = "0x19CB028")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839658", Offset = "0x839658")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x19CBEF8", Offset = "0x19CBEF8", VA = "0x19CBEF8")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x19CE574", Offset = "0x19CE574", VA = "0x19CE574")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x19CE598", Offset = "0x19CE598", VA = "0x19CE598")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839668", Offset = "0x839668")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x19CC128", Offset = "0x19CC128", VA = "0x19CC128")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x19CE5BC", Offset = "0x19CE5BC", VA = "0x19CE5BC")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x19CE5E0", Offset = "0x19CE5E0", VA = "0x19CE5E0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839678", Offset = "0x839678")]
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
		[Address(RVA = "0x19CE604", Offset = "0x19CE604", VA = "0x19CE604", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x19CE848", Offset = "0x19CE848", VA = "0x19CE848", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839688", Offset = "0x839688")]
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
		[Address(RVA = "0x19CEF58", Offset = "0x19CEF58", VA = "0x19CEF58", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x19CF1C0", Offset = "0x19CF1C0", VA = "0x19CF1C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x839698", Offset = "0x839698")]
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
		[Address(RVA = "0x19CEAAC", Offset = "0x19CEAAC", VA = "0x19CEAAC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x19CECDC", Offset = "0x19CECDC", VA = "0x19CECDC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396A8", Offset = "0x8396A8")]
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
		[Address(RVA = "0x19CE854", Offset = "0x19CE854", VA = "0x19CE854", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x19CEAA0", Offset = "0x19CEAA0", VA = "0x19CEAA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396B8", Offset = "0x8396B8")]
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
		[Address(RVA = "0x19CECE8", Offset = "0x19CECE8", VA = "0x19CECE8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x19CEF4C", Offset = "0x19CEF4C", VA = "0x19CEF4C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8396C8", Offset = "0x8396C8")]
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
		[Address(RVA = "0x19CF1CC", Offset = "0x19CF1CC", VA = "0x19CF1CC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x19CF404", Offset = "0x19CF404", VA = "0x19CF404", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x19CB294", Offset = "0x19CB294", VA = "0x19CB294")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x19CB484", Offset = "0x19CB484", VA = "0x19CB484")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x19CB688", Offset = "0x19CB688", VA = "0x19CB688")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x19CB788", Offset = "0x19CB788", VA = "0x19CB788")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x19CB888", Offset = "0x19CB888", VA = "0x19CB888")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x19CB988", Offset = "0x19CB988", VA = "0x19CB988")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x19CBAAC", Offset = "0x19CBAAC", VA = "0x19CBAAC")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x19CBBD0", Offset = "0x19CBBD0", VA = "0x19CBBD0")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x19CBCD0", Offset = "0x19CBCD0", VA = "0x19CBCD0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x19CBF00", Offset = "0x19CBF00", VA = "0x19CBF00")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x19CC130", Offset = "0x19CC130", VA = "0x19CC130")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839C58", Offset = "0x839C58")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x19CC24C", Offset = "0x19CC24C", VA = "0x19CC24C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839CC8", Offset = "0x839CC8")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x19CC368", Offset = "0x19CC368", VA = "0x19CC368")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839D38", Offset = "0x839D38")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x19CC484", Offset = "0x19CC484", VA = "0x19CC484")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839DA8", Offset = "0x839DA8")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x19CC5B0", Offset = "0x19CC5B0", VA = "0x19CC5B0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839E18", Offset = "0x839E18")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x19CC6DC", Offset = "0x19CC6DC", VA = "0x19CC6DC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x839E88", Offset = "0x839E88")]
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
			[Address(RVA = "0x19CC970", Offset = "0x19CC970", VA = "0x19CC970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x19CB754", Offset = "0x19CB754", VA = "0x19CB754")]
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
			[Address(RVA = "0x19CCA70", Offset = "0x19CCA70", VA = "0x19CCA70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x19CB854", Offset = "0x19CB854", VA = "0x19CB854")]
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
			[Address(RVA = "0x19CC9F0", Offset = "0x19CC9F0", VA = "0x19CC9F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x19CB954", Offset = "0x19CB954", VA = "0x19CB954")]
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
			[Address(RVA = "0x19CC9A4", Offset = "0x19CC9A4", VA = "0x19CC9A4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x19CBA64", Offset = "0x19CBA64", VA = "0x19CBA64")]
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
			[Address(RVA = "0x19CCA0C", Offset = "0x19CCA0C", VA = "0x19CCA0C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x19CBB88", Offset = "0x19CBB88", VA = "0x19CBB88")]
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
			[Address(RVA = "0x19CCAD4", Offset = "0x19CCAD4", VA = "0x19CCAD4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x19CBC9C", Offset = "0x19CBC9C", VA = "0x19CBC9C")]
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
		[Address(RVA = "0x19CF410", Offset = "0x19CF410", VA = "0x19CF410")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x19CF514", Offset = "0x19CF514", VA = "0x19CF514")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x19CF5AC", Offset = "0x19CF5AC", VA = "0x19CF5AC")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x19CF644", Offset = "0x19CF644", VA = "0x19CF644")]
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
	[Address(RVA = "0x19CC7F8", Offset = "0x19CC7F8", VA = "0x19CC7F8")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x19CC8BC", Offset = "0x19CC8BC", VA = "0x19CC8BC")]
	[Preserve]
	private static void Preserver()
	{
	}
}
