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
using UnityEngine.Audio;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace DG.Tweening;

[Token(Token = "0x2000002")]
public static class DOTweenModuleAudio
{
	[Token(Token = "0x2000003")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F00", Offset = "0x8C5F00")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x160B0B0", Offset = "0x160B0B0", VA = "0x160B0B0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x1615B38", Offset = "0x1615B38", VA = "0x1615B38")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1615B54", Offset = "0x1615B54", VA = "0x1615B54")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F10", Offset = "0x8C5F10")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x160B260", Offset = "0x160B260", VA = "0x160B260")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1615B70", Offset = "0x1615B70", VA = "0x1615B70")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1615B8C", Offset = "0x1615B8C", VA = "0x1615B8C")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F20", Offset = "0x8C5F20")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x160B424", Offset = "0x160B424", VA = "0x160B424")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1615BA8", Offset = "0x1615BA8", VA = "0x1615BA8")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1615BE8", Offset = "0x1615BE8", VA = "0x1615BE8")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x160AEE0", Offset = "0x160AEE0", VA = "0x160AEE0")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x160B0B8", Offset = "0x160B0B8", VA = "0x160B0B8")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x160B268", Offset = "0x160B268", VA = "0x160B268")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x160B42C", Offset = "0x160B42C", VA = "0x160B42C")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x160B4A0", Offset = "0x160B4A0", VA = "0x160B4A0")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x160B514", Offset = "0x160B514", VA = "0x160B514")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x160B578", Offset = "0x160B578", VA = "0x160B578")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x160B5FC", Offset = "0x160B5FC", VA = "0x160B5FC")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x160B660", Offset = "0x160B660", VA = "0x160B660")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x160B6C4", Offset = "0x160B6C4", VA = "0x160B6C4")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x160B728", Offset = "0x160B728", VA = "0x160B728")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x160B78C", Offset = "0x160B78C", VA = "0x160B78C")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x160B7F8", Offset = "0x160B7F8", VA = "0x160B7F8")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x160B860", Offset = "0x160B860", VA = "0x160B860")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x160B8C4", Offset = "0x160B8C4", VA = "0x160B8C4")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F40", Offset = "0x8C5F40")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x160BB04", Offset = "0x160BB04", VA = "0x160BB04")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1615C0C", Offset = "0x1615C0C", VA = "0x1615C0C")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F50", Offset = "0x8C5F50")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x160BCDC", Offset = "0x160BCDC", VA = "0x160BCDC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1615D44", Offset = "0x1615D44", VA = "0x1615D44")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F60", Offset = "0x8C5F60")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x160BEB4", Offset = "0x160BEB4", VA = "0x160BEB4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1615D60", Offset = "0x1615D60", VA = "0x1615D60")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F70", Offset = "0x8C5F70")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x160C08C", Offset = "0x160C08C", VA = "0x160C08C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1615D7C", Offset = "0x1615D7C", VA = "0x1615D7C")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F80", Offset = "0x8C5F80")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x160C26C", Offset = "0x160C26C", VA = "0x160C26C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1615D98", Offset = "0x1615D98", VA = "0x1615D98")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5F90", Offset = "0x8C5F90")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x160C4C8", Offset = "0x160C4C8", VA = "0x160C4C8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1615DB4", Offset = "0x1615DB4", VA = "0x1615DB4")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5FA0", Offset = "0x8C5FA0")]
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
		[Address(RVA = "0x160CA04", Offset = "0x160CA04", VA = "0x160CA04")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1615DD0", Offset = "0x1615DD0", VA = "0x1615DD0")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1615DEC", Offset = "0x1615DEC", VA = "0x1615DEC")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1615E20", Offset = "0x1615E20", VA = "0x1615E20")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1615E3C", Offset = "0x1615E3C", VA = "0x1615E3C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1615E58", Offset = "0x1615E58", VA = "0x1615E58")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5FB0", Offset = "0x8C5FB0")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x160CC88", Offset = "0x160CC88", VA = "0x160CC88")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x1615F18", Offset = "0x1615F18", VA = "0x1615F18")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5FC0", Offset = "0x8C5FC0")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x160CF2C", Offset = "0x160CF2C", VA = "0x160CF2C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1615F34", Offset = "0x1615F34", VA = "0x1615F34")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1615F50", Offset = "0x1615F50", VA = "0x1615F50")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5FD0", Offset = "0x8C5FD0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x160D124", Offset = "0x160D124", VA = "0x160D124")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1616050", Offset = "0x1616050", VA = "0x1616050")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C5FE0", Offset = "0x8C5FE0")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x160D33C", Offset = "0x160D33C", VA = "0x160D33C")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1615C28", Offset = "0x1615C28", VA = "0x1615C28")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x1615C44", Offset = "0x1615C44", VA = "0x1615C44")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x160B928", Offset = "0x160B928", VA = "0x160B928")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x160BB0C", Offset = "0x160BB0C", VA = "0x160BB0C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x160BCE4", Offset = "0x160BCE4", VA = "0x160BCE4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x160BEBC", Offset = "0x160BEBC", VA = "0x160BEBC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x160C094", Offset = "0x160C094", VA = "0x160C094")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x160C274", Offset = "0x160C274", VA = "0x160C274")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x160C4D0", Offset = "0x160C4D0", VA = "0x160C4D0")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x160CA0C", Offset = "0x160CA0C", VA = "0x160CA0C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x160CC90", Offset = "0x160CC90", VA = "0x160CC90")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x160CF34", Offset = "0x160CF34", VA = "0x160CF34")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x160D12C", Offset = "0x160D12C", VA = "0x160D12C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6000", Offset = "0x8C6000")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x160D518", Offset = "0x160D518", VA = "0x160D518")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x161606C", Offset = "0x161606C", VA = "0x161606C")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6010", Offset = "0x8C6010")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x160D6EC", Offset = "0x160D6EC", VA = "0x160D6EC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x1616088", Offset = "0x1616088", VA = "0x1616088")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6020", Offset = "0x8C6020")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x160D8C0", Offset = "0x160D8C0", VA = "0x160D8C0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x16160A4", Offset = "0x16160A4", VA = "0x16160A4")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6030", Offset = "0x8C6030")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x160DA74", Offset = "0x160DA74", VA = "0x160DA74")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x16160C0", Offset = "0x16160C0", VA = "0x16160C0")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6040", Offset = "0x8C6040")]
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

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x160DED8", Offset = "0x160DED8", VA = "0x160DED8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x16160DC", Offset = "0x16160DC", VA = "0x16160DC")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x16160F8", Offset = "0x16160F8", VA = "0x16160F8")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1616114", Offset = "0x1616114", VA = "0x1616114")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1616148", Offset = "0x1616148", VA = "0x1616148")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1616164", Offset = "0x1616164", VA = "0x1616164")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1616180", Offset = "0x1616180", VA = "0x1616180")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6050", Offset = "0x8C6050")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x160E1E0", Offset = "0x160E1E0", VA = "0x160E1E0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1616238", Offset = "0x1616238", VA = "0x1616238")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1616260", Offset = "0x1616260", VA = "0x1616260")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6060", Offset = "0x8C6060")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x160E50C", Offset = "0x160E50C", VA = "0x160E50C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x161627C", Offset = "0x161627C", VA = "0x161627C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1616298", Offset = "0x1616298", VA = "0x1616298")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6070", Offset = "0x8C6070")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x160E700", Offset = "0x160E700", VA = "0x160E700")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1616390", Offset = "0x1616390", VA = "0x1616390")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x16163B8", Offset = "0x16163B8", VA = "0x16163B8")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6080", Offset = "0x8C6080")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x160E918", Offset = "0x160E918", VA = "0x160E918")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x16163D4", Offset = "0x16163D4", VA = "0x16163D4")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x16163F0", Offset = "0x16163F0", VA = "0x16163F0")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x160D344", Offset = "0x160D344", VA = "0x160D344")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x160D520", Offset = "0x160D520", VA = "0x160D520")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x160D6F4", Offset = "0x160D6F4", VA = "0x160D6F4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x160D8C8", Offset = "0x160D8C8", VA = "0x160D8C8")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x160DA7C", Offset = "0x160DA7C", VA = "0x160DA7C")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x160DEE0", Offset = "0x160DEE0", VA = "0x160DEE0")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x160E1E8", Offset = "0x160E1E8", VA = "0x160E1E8")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x160E514", Offset = "0x160E514", VA = "0x160E514")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x160E708", Offset = "0x160E708", VA = "0x160E708")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C60A0", Offset = "0x8C60A0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x160EAF0", Offset = "0x160EAF0", VA = "0x160EAF0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x16164E8", Offset = "0x16164E8", VA = "0x16164E8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1616504", Offset = "0x1616504", VA = "0x1616504")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C60B0", Offset = "0x8C60B0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x160ECA0", Offset = "0x160ECA0", VA = "0x160ECA0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1616520", Offset = "0x1616520", VA = "0x1616520")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x161653C", Offset = "0x161653C", VA = "0x161653C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C60C0", Offset = "0x8C60C0")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x160F0F0", Offset = "0x160F0F0", VA = "0x160F0F0")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1616558", Offset = "0x1616558", VA = "0x1616558")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1616564", Offset = "0x1616564", VA = "0x1616564")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x160E920", Offset = "0x160E920", VA = "0x160E920")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x160EAF8", Offset = "0x160EAF8", VA = "0x160EAF8")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x160ECA8", Offset = "0x160ECA8", VA = "0x160ECA8")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x160EE94", Offset = "0x160EE94", VA = "0x160EE94")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000020")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000021")]
	public static class Utils
	{
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x16174F0", Offset = "0x16174F0", VA = "0x16174F0")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C60E0", Offset = "0x8C60E0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x160F2A0", Offset = "0x160F2A0", VA = "0x160F2A0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1616610", Offset = "0x1616610", VA = "0x1616610")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x161662C", Offset = "0x161662C", VA = "0x161662C")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C60F0", Offset = "0x8C60F0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x160F478", Offset = "0x160F478", VA = "0x160F478")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1616880", Offset = "0x1616880", VA = "0x1616880")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x16168A4", Offset = "0x16168A4", VA = "0x16168A4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6100", Offset = "0x8C6100")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x160F628", Offset = "0x160F628", VA = "0x160F628")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1616C3C", Offset = "0x1616C3C", VA = "0x1616C3C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1616C60", Offset = "0x1616C60", VA = "0x1616C60")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6110", Offset = "0x8C6110")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x160F800", Offset = "0x160F800", VA = "0x160F800")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x16170E8", Offset = "0x16170E8", VA = "0x16170E8")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x161710C", Offset = "0x161710C", VA = "0x161710C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6120", Offset = "0x8C6120")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x160F9B0", Offset = "0x160F9B0", VA = "0x160F9B0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1617230", Offset = "0x1617230", VA = "0x1617230")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1617254", Offset = "0x1617254", VA = "0x1617254")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6130", Offset = "0x8C6130")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x160FB84", Offset = "0x160FB84", VA = "0x160FB84")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1617278", Offset = "0x1617278", VA = "0x1617278")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1617294", Offset = "0x1617294", VA = "0x1617294")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6140", Offset = "0x8C6140")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x160FF50", Offset = "0x160FF50", VA = "0x160FF50")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x16172B0", Offset = "0x16172B0", VA = "0x16172B0")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1617314", Offset = "0x1617314", VA = "0x1617314")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6150", Offset = "0x8C6150")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1610128", Offset = "0x1610128", VA = "0x1610128")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1617370", Offset = "0x1617370", VA = "0x1617370")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x16173D4", Offset = "0x16173D4", VA = "0x16173D4")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6160", Offset = "0x8C6160")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1610300", Offset = "0x1610300", VA = "0x1610300")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1617430", Offset = "0x1617430", VA = "0x1617430")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1617494", Offset = "0x1617494", VA = "0x1617494")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6170", Offset = "0x8C6170")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x16104D8", Offset = "0x16104D8", VA = "0x16104D8")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1616648", Offset = "0x1616648", VA = "0x1616648")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1616668", Offset = "0x1616668", VA = "0x1616668")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6180", Offset = "0x8C6180")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1610688", Offset = "0x1610688", VA = "0x1610688")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1616684", Offset = "0x1616684", VA = "0x1616684")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x16166A4", Offset = "0x16166A4", VA = "0x16166A4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6190", Offset = "0x8C6190")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1610848", Offset = "0x1610848", VA = "0x1610848")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x16166C0", Offset = "0x16166C0", VA = "0x16166C0")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x16166DC", Offset = "0x16166DC", VA = "0x16166DC")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61A0", Offset = "0x8C61A0")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1610A20", Offset = "0x1610A20", VA = "0x1610A20")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16166F8", Offset = "0x16166F8", VA = "0x16166F8")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1616714", Offset = "0x1616714", VA = "0x1616714")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61B0", Offset = "0x8C61B0")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1610BF0", Offset = "0x1610BF0", VA = "0x1610BF0")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1616730", Offset = "0x1616730", VA = "0x1616730")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x161674C", Offset = "0x161674C", VA = "0x161674C")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61C0", Offset = "0x8C61C0")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1610DC0", Offset = "0x1610DC0", VA = "0x1610DC0")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1616768", Offset = "0x1616768", VA = "0x1616768")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1616784", Offset = "0x1616784", VA = "0x1616784")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61D0", Offset = "0x8C61D0")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1610FA0", Offset = "0x1610FA0", VA = "0x1610FA0")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x16167A0", Offset = "0x16167A0", VA = "0x16167A0")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x16167BC", Offset = "0x16167BC", VA = "0x16167BC")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61E0", Offset = "0x8C61E0")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1611174", Offset = "0x1611174", VA = "0x1611174")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x16167D8", Offset = "0x16167D8", VA = "0x16167D8")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x16167F4", Offset = "0x16167F4", VA = "0x16167F4")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C61F0", Offset = "0x8C61F0")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1611348", Offset = "0x1611348", VA = "0x1611348")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1616810", Offset = "0x1616810", VA = "0x1616810")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x161682C", Offset = "0x161682C", VA = "0x161682C")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6200", Offset = "0x8C6200")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x161151C", Offset = "0x161151C", VA = "0x161151C")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1616848", Offset = "0x1616848", VA = "0x1616848")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1616864", Offset = "0x1616864", VA = "0x1616864")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6210", Offset = "0x8C6210")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x16116F4", Offset = "0x16116F4", VA = "0x16116F4")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x16168C8", Offset = "0x16168C8", VA = "0x16168C8")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x16168E4", Offset = "0x16168E4", VA = "0x16168E4")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6220", Offset = "0x8C6220")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x16118CC", Offset = "0x16118CC", VA = "0x16118CC")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1616900", Offset = "0x1616900", VA = "0x1616900")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x161691C", Offset = "0x161691C", VA = "0x161691C")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6230", Offset = "0x8C6230")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1611A8C", Offset = "0x1611A8C", VA = "0x1611A8C")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1616938", Offset = "0x1616938", VA = "0x1616938")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1616954", Offset = "0x1616954", VA = "0x1616954")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6240", Offset = "0x8C6240")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1611C50", Offset = "0x1611C50", VA = "0x1611C50")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1616970", Offset = "0x1616970", VA = "0x1616970")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x161698C", Offset = "0x161698C", VA = "0x161698C")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6250", Offset = "0x8C6250")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1611E14", Offset = "0x1611E14", VA = "0x1611E14")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x16169A8", Offset = "0x16169A8", VA = "0x16169A8")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x16169C4", Offset = "0x16169C4", VA = "0x16169C4")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6260", Offset = "0x8C6260")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1611FEC", Offset = "0x1611FEC", VA = "0x1611FEC")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x16169E0", Offset = "0x16169E0", VA = "0x16169E0")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x16169FC", Offset = "0x16169FC", VA = "0x16169FC")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6270", Offset = "0x8C6270")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x16121CC", Offset = "0x16121CC", VA = "0x16121CC")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1616A18", Offset = "0x1616A18", VA = "0x1616A18")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1616A40", Offset = "0x1616A40", VA = "0x1616A40")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6280", Offset = "0x8C6280")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x16123D4", Offset = "0x16123D4", VA = "0x16123D4")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1616A5C", Offset = "0x1616A5C", VA = "0x1616A5C")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1616A84", Offset = "0x1616A84", VA = "0x1616A84")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6290", Offset = "0x8C6290")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x16125E4", Offset = "0x16125E4", VA = "0x16125E4")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1616AA0", Offset = "0x1616AA0", VA = "0x1616AA0")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1616AC8", Offset = "0x1616AC8", VA = "0x1616AC8")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62A0", Offset = "0x8C62A0")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1612A40", Offset = "0x1612A40", VA = "0x1612A40")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1616AE4", Offset = "0x1616AE4", VA = "0x1616AE4")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1616B00", Offset = "0x1616B00", VA = "0x1616B00")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1616B1C", Offset = "0x1616B1C", VA = "0x1616B1C")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1616B50", Offset = "0x1616B50", VA = "0x1616B50")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1616B6C", Offset = "0x1616B6C", VA = "0x1616B6C")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1616B88", Offset = "0x1616B88", VA = "0x1616B88")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62B0", Offset = "0x8C62B0")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1612C0C", Offset = "0x1612C0C", VA = "0x1612C0C")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1616C84", Offset = "0x1616C84", VA = "0x1616C84")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1616CD8", Offset = "0x1616CD8", VA = "0x1616CD8")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62C0", Offset = "0x8C62C0")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1612DC8", Offset = "0x1612DC8", VA = "0x1612DC8")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1616D24", Offset = "0x1616D24", VA = "0x1616D24")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1616D40", Offset = "0x1616D40", VA = "0x1616D40")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62D0", Offset = "0x8C62D0")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1612F84", Offset = "0x1612F84", VA = "0x1612F84")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1616D5C", Offset = "0x1616D5C", VA = "0x1616D5C")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1616D78", Offset = "0x1616D78", VA = "0x1616D78")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62E0", Offset = "0x8C62E0")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x161314C", Offset = "0x161314C", VA = "0x161314C")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1616D94", Offset = "0x1616D94", VA = "0x1616D94")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1616DB8", Offset = "0x1616DB8", VA = "0x1616DB8")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C62F0", Offset = "0x8C62F0")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1613324", Offset = "0x1613324", VA = "0x1613324")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1616DDC", Offset = "0x1616DDC", VA = "0x1616DDC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1616E00", Offset = "0x1616E00", VA = "0x1616E00")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6300", Offset = "0x8C6300")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1613554", Offset = "0x1613554", VA = "0x1613554")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1616E24", Offset = "0x1616E24", VA = "0x1616E24")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1616E2C", Offset = "0x1616E2C", VA = "0x1616E2C")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6310", Offset = "0x8C6310")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1613704", Offset = "0x1613704", VA = "0x1613704")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1616EC8", Offset = "0x1616EC8", VA = "0x1616EC8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1616EEC", Offset = "0x1616EEC", VA = "0x1616EEC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6320", Offset = "0x8C6320")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1613960", Offset = "0x1613960", VA = "0x1613960")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1616F10", Offset = "0x1616F10", VA = "0x1616F10")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1616F34", Offset = "0x1616F34", VA = "0x1616F34")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6330", Offset = "0x8C6330")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1613BCC", Offset = "0x1613BCC", VA = "0x1613BCC")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1616F58", Offset = "0x1616F58", VA = "0x1616F58")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1616F64", Offset = "0x1616F64", VA = "0x1616F64")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6340", Offset = "0x8C6340")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1613E38", Offset = "0x1613E38", VA = "0x1613E38")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1617020", Offset = "0x1617020", VA = "0x1617020")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x161702C", Offset = "0x161702C", VA = "0x161702C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6350", Offset = "0x8C6350")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x16140A4", Offset = "0x16140A4", VA = "0x16140A4")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1617130", Offset = "0x1617130", VA = "0x1617130")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x161713C", Offset = "0x161713C", VA = "0x161713C")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6360", Offset = "0x8C6360")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x16142BC", Offset = "0x16142BC", VA = "0x16142BC")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x16171F8", Offset = "0x16171F8", VA = "0x16171F8")]
		internal Vector2 <DOShapeCircle>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1617214", Offset = "0x1617214", VA = "0x1617214")]
		internal void <DOShapeCircle>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x160F0F8", Offset = "0x160F0F8", VA = "0x160F0F8")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x160F2A8", Offset = "0x160F2A8", VA = "0x160F2A8")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x160F480", Offset = "0x160F480", VA = "0x160F480")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x160F630", Offset = "0x160F630", VA = "0x160F630")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x160F808", Offset = "0x160F808", VA = "0x160F808")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x160F9B8", Offset = "0x160F9B8", VA = "0x160F9B8")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x160FB8C", Offset = "0x160FB8C", VA = "0x160FB8C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x160FD80", Offset = "0x160FD80", VA = "0x160FD80")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x160FF58", Offset = "0x160FF58", VA = "0x160FF58")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x1610130", Offset = "0x1610130", VA = "0x1610130")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1610308", Offset = "0x1610308", VA = "0x1610308")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x16104E0", Offset = "0x16104E0", VA = "0x16104E0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x1610690", Offset = "0x1610690", VA = "0x1610690")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1610850", Offset = "0x1610850", VA = "0x1610850")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1610A28", Offset = "0x1610A28", VA = "0x1610A28")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1610BF8", Offset = "0x1610BF8", VA = "0x1610BF8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x1610DC8", Offset = "0x1610DC8", VA = "0x1610DC8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1610FA8", Offset = "0x1610FA8", VA = "0x1610FA8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x161117C", Offset = "0x161117C", VA = "0x161117C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x1611350", Offset = "0x1611350", VA = "0x1611350")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1611524", Offset = "0x1611524", VA = "0x1611524")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x16116FC", Offset = "0x16116FC", VA = "0x16116FC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x16118D4", Offset = "0x16118D4", VA = "0x16118D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1611A94", Offset = "0x1611A94", VA = "0x1611A94")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1611C58", Offset = "0x1611C58", VA = "0x1611C58")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1611E1C", Offset = "0x1611E1C", VA = "0x1611E1C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1611FF4", Offset = "0x1611FF4", VA = "0x1611FF4")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x16121D4", Offset = "0x16121D4", VA = "0x16121D4")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x16123DC", Offset = "0x16123DC", VA = "0x16123DC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x16125EC", Offset = "0x16125EC", VA = "0x16125EC")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x1612A48", Offset = "0x1612A48", VA = "0x1612A48")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x1612C14", Offset = "0x1612C14", VA = "0x1612C14")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x1612DD0", Offset = "0x1612DD0", VA = "0x1612DD0")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x1612F8C", Offset = "0x1612F8C", VA = "0x1612F8C")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x1613154", Offset = "0x1613154", VA = "0x1613154")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x161332C", Offset = "0x161332C", VA = "0x161332C")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x161355C", Offset = "0x161355C", VA = "0x161355C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x161370C", Offset = "0x161370C", VA = "0x161370C")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x1613968", Offset = "0x1613968", VA = "0x1613968")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x1613BD4", Offset = "0x1613BD4", VA = "0x1613BD4")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x1613E40", Offset = "0x1613E40", VA = "0x1613E40")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x16140AC", Offset = "0x16140AC", VA = "0x16140AC")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x200004B")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6380", Offset = "0x8C6380")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1614F28", Offset = "0x1614F28", VA = "0x1614F28")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1617734", Offset = "0x1617734", VA = "0x1617734")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1617758", Offset = "0x1617758", VA = "0x1617758")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C6390", Offset = "0x8C6390")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1615158", Offset = "0x1615158", VA = "0x1615158")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x161777C", Offset = "0x161777C", VA = "0x161777C")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x16177A0", Offset = "0x16177A0", VA = "0x16177A0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63A0", Offset = "0x8C63A0")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
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

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x16177C4", Offset = "0x16177C4", VA = "0x16177C4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1617A08", Offset = "0x1617A08", VA = "0x1617A08", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63B0", Offset = "0x8C63B0")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
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

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1618118", Offset = "0x1618118", VA = "0x1618118", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1618380", Offset = "0x1618380", VA = "0x1618380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63C0", Offset = "0x8C63C0")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
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
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1617C6C", Offset = "0x1617C6C", VA = "0x1617C6C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1617E9C", Offset = "0x1617E9C", VA = "0x1617E9C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63D0", Offset = "0x8C63D0")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int elapsedLoops;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1617A14", Offset = "0x1617A14", VA = "0x1617A14", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1617C60", Offset = "0x1617C60", VA = "0x1617C60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63E0", Offset = "0x8C63E0")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1617EA8", Offset = "0x1617EA8", VA = "0x1617EA8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x161810C", Offset = "0x161810C", VA = "0x161810C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000053")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x8C63F0", Offset = "0x8C63F0")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x161838C", Offset = "0x161838C", VA = "0x161838C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x16185C4", Offset = "0x16185C4", VA = "0x16185C4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x16142C4", Offset = "0x16142C4", VA = "0x16142C4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x16144B4", Offset = "0x16144B4", VA = "0x16144B4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x16146B8", Offset = "0x16146B8", VA = "0x16146B8")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x16147B8", Offset = "0x16147B8", VA = "0x16147B8")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x16148B8", Offset = "0x16148B8", VA = "0x16148B8")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x16149B8", Offset = "0x16149B8", VA = "0x16149B8")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1614ADC", Offset = "0x1614ADC", VA = "0x1614ADC")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1614C00", Offset = "0x1614C00", VA = "0x1614C00")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1614D00", Offset = "0x1614D00", VA = "0x1614D00")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1614F30", Offset = "0x1614F30", VA = "0x1614F30")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1615160", Offset = "0x1615160", VA = "0x1615160")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C69B0", Offset = "0x8C69B0")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x161527C", Offset = "0x161527C", VA = "0x161527C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C6A20", Offset = "0x8C6A20")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x1615398", Offset = "0x1615398", VA = "0x1615398")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C6A90", Offset = "0x8C6A90")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x16154B4", Offset = "0x16154B4", VA = "0x16154B4")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C6B00", Offset = "0x8C6B00")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x16155E0", Offset = "0x16155E0", VA = "0x16155E0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C6B70", Offset = "0x8C6B70")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x161570C", Offset = "0x161570C", VA = "0x161570C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x8C6BE0", Offset = "0x8C6BE0")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000054")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000055")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x16159A0", Offset = "0x16159A0", VA = "0x16159A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1614784", Offset = "0x1614784", VA = "0x1614784")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000056")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1615AA0", Offset = "0x1615AA0", VA = "0x1615AA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1614884", Offset = "0x1614884", VA = "0x1614884")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1615A20", Offset = "0x1615A20", VA = "0x1615A20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1614984", Offset = "0x1614984", VA = "0x1614984")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000058")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x16159D4", Offset = "0x16159D4", VA = "0x16159D4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1614A94", Offset = "0x1614A94", VA = "0x1614A94")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000059")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1615A3C", Offset = "0x1615A3C", VA = "0x1615A3C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1614BB8", Offset = "0x1614BB8", VA = "0x1614BB8")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x200005A")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1615B04", Offset = "0x1615B04", VA = "0x1615B04", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1614CCC", Offset = "0x1614CCC", VA = "0x1614CCC")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x200005B")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200005C")]
	public static class Physics
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x16185D0", Offset = "0x16185D0", VA = "0x16185D0")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x16186D4", Offset = "0x16186D4", VA = "0x16186D4")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x161876C", Offset = "0x161876C", VA = "0x161876C")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1618804", Offset = "0x1618804", VA = "0x1618804")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x1615828", Offset = "0x1615828", VA = "0x1615828")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x16158EC", Offset = "0x16158EC", VA = "0x16158EC")]
	[Preserve]
	private static void Preserver()
	{
	}
}
