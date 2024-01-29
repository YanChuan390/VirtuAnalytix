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
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF7FA0", Offset = "0xBF7FA0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2CB4104", Offset = "0x2CB4104", VA = "0x2CB4104")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2CBEBB4", Offset = "0x2CBEBB4", VA = "0x2CBEBB4")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2CBEBD4", Offset = "0x2CBEBD4", VA = "0x2CBEBD4")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF7FB0", Offset = "0xBF7FB0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2CB42CC", Offset = "0x2CB42CC", VA = "0x2CB42CC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2CBEBF4", Offset = "0x2CBEBF4", VA = "0x2CBEBF4")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2CBEC14", Offset = "0x2CBEC14", VA = "0x2CBEC14")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000005")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF7FC0", Offset = "0xBF7FC0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2CB44A8", Offset = "0x2CB44A8", VA = "0x2CB44A8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2CBEC34", Offset = "0x2CBEC34", VA = "0x2CBEC34")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2CBEC74", Offset = "0x2CBEC74", VA = "0x2CBEC74")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x2CB3F1C", Offset = "0x2CB3F1C", VA = "0x2CB3F1C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2CB410C", Offset = "0x2CB410C", VA = "0x2CB410C")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2CB42D4", Offset = "0x2CB42D4", VA = "0x2CB42D4")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x2CB44B0", Offset = "0x2CB44B0", VA = "0x2CB44B0")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2CB4524", Offset = "0x2CB4524", VA = "0x2CB4524")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2CB4598", Offset = "0x2CB4598", VA = "0x2CB4598")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x2CB4604", Offset = "0x2CB4604", VA = "0x2CB4604")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2CB4688", Offset = "0x2CB4688", VA = "0x2CB4688")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2CB46F4", Offset = "0x2CB46F4", VA = "0x2CB46F4")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2CB4760", Offset = "0x2CB4760", VA = "0x2CB4760")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2CB47CC", Offset = "0x2CB47CC", VA = "0x2CB47CC")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2CB4838", Offset = "0x2CB4838", VA = "0x2CB4838")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2CB48AC", Offset = "0x2CB48AC", VA = "0x2CB48AC")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2CB491C", Offset = "0x2CB491C", VA = "0x2CB491C")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2CB4988", Offset = "0x2CB4988", VA = "0x2CB4988")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x2000007")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF7FE0", Offset = "0xBF7FE0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2CB4BEC", Offset = "0x2CB4BEC", VA = "0x2CB4BEC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2CBEC9C", Offset = "0x2CBEC9C", VA = "0x2CBEC9C")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000008")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF7FF0", Offset = "0xBF7FF0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2CB4DE0", Offset = "0x2CB4DE0", VA = "0x2CB4DE0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2CBEDDC", Offset = "0x2CBEDDC", VA = "0x2CBEDDC")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000009")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8000", Offset = "0xBF8000")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2CB4FD4", Offset = "0x2CB4FD4", VA = "0x2CB4FD4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2CBEDFC", Offset = "0x2CBEDFC", VA = "0x2CBEDFC")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8010", Offset = "0xBF8010")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2CB51C8", Offset = "0x2CB51C8", VA = "0x2CB51C8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2CBEE1C", Offset = "0x2CBEE1C", VA = "0x2CBEE1C")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8020", Offset = "0xBF8020")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2CB53C4", Offset = "0x2CB53C4", VA = "0x2CB53C4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2CBEE3C", Offset = "0x2CBEE3C", VA = "0x2CBEE3C")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8030", Offset = "0xBF8030")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2CB5638", Offset = "0x2CB5638", VA = "0x2CB5638")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2CBEE5C", Offset = "0x2CBEE5C", VA = "0x2CBEE5C")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8040", Offset = "0xBF8040")]
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
		[Address(RVA = "0x2CB5B9C", Offset = "0x2CB5B9C", VA = "0x2CB5B9C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2CBEE7C", Offset = "0x2CBEE7C", VA = "0x2CBEE7C")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2CBEE9C", Offset = "0x2CBEE9C", VA = "0x2CBEE9C")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2CBEED0", Offset = "0x2CBEED0", VA = "0x2CBEED0")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2CBEEF0", Offset = "0x2CBEEF0", VA = "0x2CBEEF0")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2CBEF10", Offset = "0x2CBEF10", VA = "0x2CBEF10")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8050", Offset = "0xBF8050")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2CB5E20", Offset = "0x2CB5E20", VA = "0x2CB5E20")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2CBEFD0", Offset = "0x2CBEFD0", VA = "0x2CBEFD0")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8060", Offset = "0xBF8060")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2CB60D4", Offset = "0x2CB60D4", VA = "0x2CB60D4")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2CBEFF0", Offset = "0x2CBEFF0", VA = "0x2CBEFF0")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2CBF010", Offset = "0x2CBF010", VA = "0x2CBF010")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8070", Offset = "0xBF8070")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2CB62E0", Offset = "0x2CB62E0", VA = "0x2CB62E0")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2CBF110", Offset = "0x2CBF110", VA = "0x2CBF110")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8080", Offset = "0xBF8080")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2CB6500", Offset = "0x2CB6500", VA = "0x2CB6500")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2CBECBC", Offset = "0x2CBECBC", VA = "0x2CBECBC")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2CBECDC", Offset = "0x2CBECDC", VA = "0x2CBECDC")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x2CB49F4", Offset = "0x2CB49F4", VA = "0x2CB49F4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x2CB4BF4", Offset = "0x2CB4BF4", VA = "0x2CB4BF4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x2CB4DE8", Offset = "0x2CB4DE8", VA = "0x2CB4DE8")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x2CB4FDC", Offset = "0x2CB4FDC", VA = "0x2CB4FDC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x2CB51D0", Offset = "0x2CB51D0", VA = "0x2CB51D0")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x2CB53CC", Offset = "0x2CB53CC", VA = "0x2CB53CC")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x2CB5640", Offset = "0x2CB5640", VA = "0x2CB5640")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2CB5BA4", Offset = "0x2CB5BA4", VA = "0x2CB5BA4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2CB5E28", Offset = "0x2CB5E28", VA = "0x2CB5E28")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2CB60DC", Offset = "0x2CB60DC", VA = "0x2CB60DC")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2CB62E8", Offset = "0x2CB62E8", VA = "0x2CB62E8")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000012")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80A0", Offset = "0xBF80A0")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2CB66F0", Offset = "0x2CB66F0", VA = "0x2CB66F0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2CBF130", Offset = "0x2CBF130", VA = "0x2CBF130")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80B0", Offset = "0xBF80B0")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2CB68E0", Offset = "0x2CB68E0", VA = "0x2CB68E0")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2CBF150", Offset = "0x2CBF150", VA = "0x2CBF150")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80C0", Offset = "0xBF80C0")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2CB6AD0", Offset = "0x2CB6AD0", VA = "0x2CB6AD0")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2CBF170", Offset = "0x2CBF170", VA = "0x2CBF170")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80D0", Offset = "0xBF80D0")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2CB6C9C", Offset = "0x2CB6C9C", VA = "0x2CB6C9C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2CBF190", Offset = "0x2CBF190", VA = "0x2CBF190")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80E0", Offset = "0xBF80E0")]
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
		[Address(RVA = "0x2CB7114", Offset = "0x2CB7114", VA = "0x2CB7114")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2CBF1B0", Offset = "0x2CBF1B0", VA = "0x2CBF1B0")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2CBF1D0", Offset = "0x2CBF1D0", VA = "0x2CBF1D0")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2CBF1F0", Offset = "0x2CBF1F0", VA = "0x2CBF1F0")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2CBF224", Offset = "0x2CBF224", VA = "0x2CBF224")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2CBF244", Offset = "0x2CBF244", VA = "0x2CBF244")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2CBF264", Offset = "0x2CBF264", VA = "0x2CBF264")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF80F0", Offset = "0xBF80F0")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2CB7430", Offset = "0x2CB7430", VA = "0x2CB7430")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2CBF31C", Offset = "0x2CBF31C", VA = "0x2CBF31C")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2CBF344", Offset = "0x2CBF344", VA = "0x2CBF344")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8100", Offset = "0xBF8100")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2CB7770", Offset = "0x2CB7770", VA = "0x2CB7770")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2CBF364", Offset = "0x2CBF364", VA = "0x2CBF364")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2CBF384", Offset = "0x2CBF384", VA = "0x2CBF384")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2CB6508", Offset = "0x2CB6508", VA = "0x2CB6508")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x2CB66F8", Offset = "0x2CB66F8", VA = "0x2CB66F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2CB68E8", Offset = "0x2CB68E8", VA = "0x2CB68E8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2CB6AD8", Offset = "0x2CB6AD8", VA = "0x2CB6AD8")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2CB6CA4", Offset = "0x2CB6CA4", VA = "0x2CB6CA4")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2CB711C", Offset = "0x2CB711C", VA = "0x2CB711C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2CB7438", Offset = "0x2CB7438", VA = "0x2CB7438")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x200001A")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8120", Offset = "0xBF8120")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2CB7960", Offset = "0x2CB7960", VA = "0x2CB7960")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2CBF47C", Offset = "0x2CBF47C", VA = "0x2CBF47C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2CBF49C", Offset = "0x2CBF49C", VA = "0x2CBF49C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8130", Offset = "0xBF8130")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2CB7B28", Offset = "0x2CB7B28", VA = "0x2CB7B28")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x2CBF4BC", Offset = "0x2CBF4BC", VA = "0x2CBF4BC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2CBF4DC", Offset = "0x2CBF4DC", VA = "0x2CBF4DC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8140", Offset = "0xBF8140")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x2CB7F94", Offset = "0x2CB7F94", VA = "0x2CB7F94")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x2CBF4FC", Offset = "0x2CBF4FC", VA = "0x2CBF4FC")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x2CBF508", Offset = "0x2CBF508", VA = "0x2CBF508")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2CB7778", Offset = "0x2CB7778", VA = "0x2CB7778")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2CB7968", Offset = "0x2CB7968", VA = "0x2CB7968")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2CB7B30", Offset = "0x2CB7B30", VA = "0x2CB7B30")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2CB7D20", Offset = "0x2CB7D20", VA = "0x2CB7D20")]
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
		[Address(RVA = "0x2CC0558", Offset = "0x2CC0558", VA = "0x2CC0558")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8160", Offset = "0xBF8160")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2CB815C", Offset = "0x2CB815C", VA = "0x2CB815C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2CBF5B4", Offset = "0x2CBF5B4", VA = "0x2CBF5B4")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2CBF5D4", Offset = "0x2CBF5D4", VA = "0x2CBF5D4")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8170", Offset = "0xBF8170")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2CB834C", Offset = "0x2CB834C", VA = "0x2CB834C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2CBF87C", Offset = "0x2CBF87C", VA = "0x2CBF87C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2CBF8A4", Offset = "0x2CBF8A4", VA = "0x2CBF8A4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8180", Offset = "0xBF8180")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x2CB8514", Offset = "0x2CB8514", VA = "0x2CB8514")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x2CBFC8C", Offset = "0x2CBFC8C", VA = "0x2CBFC8C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2CBFCB4", Offset = "0x2CBFCB4", VA = "0x2CBFCB4")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8190", Offset = "0xBF8190")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2CB8704", Offset = "0x2CB8704", VA = "0x2CB8704")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2CC0170", Offset = "0x2CC0170", VA = "0x2CC0170")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2CC0198", Offset = "0x2CC0198", VA = "0x2CC0198")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81A0", Offset = "0xBF81A0")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2CB88CC", Offset = "0x2CB88CC", VA = "0x2CB88CC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2CC0288", Offset = "0x2CC0288", VA = "0x2CC0288")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2CC02B0", Offset = "0x2CC02B0", VA = "0x2CC02B0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81B0", Offset = "0xBF81B0")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2CB8AB8", Offset = "0x2CB8AB8", VA = "0x2CB8AB8")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2CC02D8", Offset = "0x2CC02D8", VA = "0x2CC02D8")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2CC02F8", Offset = "0x2CC02F8", VA = "0x2CC02F8")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81C0", Offset = "0xBF81C0")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2CB8E9C", Offset = "0x2CB8E9C", VA = "0x2CB8E9C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2CC0318", Offset = "0x2CC0318", VA = "0x2CC0318")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2CC037C", Offset = "0x2CC037C", VA = "0x2CC037C")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81D0", Offset = "0xBF81D0")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2CB9088", Offset = "0x2CB9088", VA = "0x2CB9088")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2CC03D8", Offset = "0x2CC03D8", VA = "0x2CC03D8")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2CC043C", Offset = "0x2CC043C", VA = "0x2CC043C")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81E0", Offset = "0xBF81E0")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2CB9274", Offset = "0x2CB9274", VA = "0x2CB9274")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2CC0498", Offset = "0x2CC0498", VA = "0x2CC0498")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x2CC04FC", Offset = "0x2CC04FC", VA = "0x2CC04FC")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF81F0", Offset = "0xBF81F0")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2CB9464", Offset = "0x2CB9464", VA = "0x2CB9464")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2CBF5F4", Offset = "0x2CBF5F4", VA = "0x2CBF5F4")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2CBF618", Offset = "0x2CBF618", VA = "0x2CBF618")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8200", Offset = "0xBF8200")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2CB962C", Offset = "0x2CB962C", VA = "0x2CB962C")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2CBF638", Offset = "0x2CBF638", VA = "0x2CBF638")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2CBF65C", Offset = "0x2CBF65C", VA = "0x2CBF65C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8210", Offset = "0xBF8210")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2CB9804", Offset = "0x2CB9804", VA = "0x2CB9804")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2CBF67C", Offset = "0x2CBF67C", VA = "0x2CBF67C")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2CBF69C", Offset = "0x2CBF69C", VA = "0x2CBF69C")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8220", Offset = "0xBF8220")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2CB99F0", Offset = "0x2CB99F0", VA = "0x2CB99F0")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x2CBF6BC", Offset = "0x2CBF6BC", VA = "0x2CBF6BC")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x2CBF6DC", Offset = "0x2CBF6DC", VA = "0x2CBF6DC")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8230", Offset = "0xBF8230")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x2CB9BDC", Offset = "0x2CB9BDC", VA = "0x2CB9BDC")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x2CBF6FC", Offset = "0x2CBF6FC", VA = "0x2CBF6FC")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x2CBF71C", Offset = "0x2CBF71C", VA = "0x2CBF71C")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8240", Offset = "0xBF8240")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x2CB9DC8", Offset = "0x2CB9DC8", VA = "0x2CB9DC8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2CBF73C", Offset = "0x2CBF73C", VA = "0x2CBF73C")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2CBF75C", Offset = "0x2CBF75C", VA = "0x2CBF75C")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8250", Offset = "0xBF8250")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2CB9FC4", Offset = "0x2CB9FC4", VA = "0x2CB9FC4")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2CBF77C", Offset = "0x2CBF77C", VA = "0x2CBF77C")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x2CBF79C", Offset = "0x2CBF79C", VA = "0x2CBF79C")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8260", Offset = "0xBF8260")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x2CBA1B4", Offset = "0x2CBA1B4", VA = "0x2CBA1B4")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x2CBF7BC", Offset = "0x2CBF7BC", VA = "0x2CBF7BC")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x2CBF7DC", Offset = "0x2CBF7DC", VA = "0x2CBF7DC")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8270", Offset = "0xBF8270")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x2CBA3A4", Offset = "0x2CBA3A4", VA = "0x2CBA3A4")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x2CBF7FC", Offset = "0x2CBF7FC", VA = "0x2CBF7FC")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x2CBF81C", Offset = "0x2CBF81C", VA = "0x2CBF81C")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8280", Offset = "0xBF8280")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x2CBA594", Offset = "0x2CBA594", VA = "0x2CBA594")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x2CBF83C", Offset = "0x2CBF83C", VA = "0x2CBF83C")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x2CBF85C", Offset = "0x2CBF85C", VA = "0x2CBF85C")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8290", Offset = "0xBF8290")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x2CBA780", Offset = "0x2CBA780", VA = "0x2CBA780")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x2CBF8CC", Offset = "0x2CBF8CC", VA = "0x2CBF8CC")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x2CBF8EC", Offset = "0x2CBF8EC", VA = "0x2CBF8EC")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82A0", Offset = "0xBF82A0")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x2CBA96C", Offset = "0x2CBA96C", VA = "0x2CBA96C")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x2CBF90C", Offset = "0x2CBF90C", VA = "0x2CBF90C")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x2CBF92C", Offset = "0x2CBF92C", VA = "0x2CBF92C")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82B0", Offset = "0xBF82B0")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2CBAB44", Offset = "0x2CBAB44", VA = "0x2CBAB44")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2CBF94C", Offset = "0x2CBF94C", VA = "0x2CBF94C")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2CBF96C", Offset = "0x2CBF96C", VA = "0x2CBF96C")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82C0", Offset = "0xBF82C0")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2CBAD20", Offset = "0x2CBAD20", VA = "0x2CBAD20")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2CBF98C", Offset = "0x2CBF98C", VA = "0x2CBF98C")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2CBF9AC", Offset = "0x2CBF9AC", VA = "0x2CBF9AC")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82D0", Offset = "0xBF82D0")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2CBAEFC", Offset = "0x2CBAEFC", VA = "0x2CBAEFC")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2CBF9CC", Offset = "0x2CBF9CC", VA = "0x2CBF9CC")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2CBF9EC", Offset = "0x2CBF9EC", VA = "0x2CBF9EC")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82E0", Offset = "0xBF82E0")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2CBB0E8", Offset = "0x2CBB0E8", VA = "0x2CBB0E8")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2CBFA0C", Offset = "0x2CBFA0C", VA = "0x2CBFA0C")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2CBFA2C", Offset = "0x2CBFA2C", VA = "0x2CBFA2C")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF82F0", Offset = "0xBF82F0")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2CBB2E0", Offset = "0x2CBB2E0", VA = "0x2CBB2E0")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2CBFA4C", Offset = "0x2CBFA4C", VA = "0x2CBFA4C")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2CBFA74", Offset = "0x2CBFA74", VA = "0x2CBFA74")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8300", Offset = "0xBF8300")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2CBB4FC", Offset = "0x2CBB4FC", VA = "0x2CBB4FC")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2CBFA94", Offset = "0x2CBFA94", VA = "0x2CBFA94")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2CBFABC", Offset = "0x2CBFABC", VA = "0x2CBFABC")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8310", Offset = "0xBF8310")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2CBB71C", Offset = "0x2CBB71C", VA = "0x2CBB71C")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2CBFADC", Offset = "0x2CBFADC", VA = "0x2CBFADC")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2CBFB04", Offset = "0x2CBFB04", VA = "0x2CBFB04")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8320", Offset = "0xBF8320")]
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
		[Address(RVA = "0x2CBBB84", Offset = "0x2CBBB84", VA = "0x2CBBB84")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2CBFB24", Offset = "0x2CBFB24", VA = "0x2CBFB24")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2CBFB44", Offset = "0x2CBFB44", VA = "0x2CBFB44")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2CBFB64", Offset = "0x2CBFB64", VA = "0x2CBFB64")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2CBFB98", Offset = "0x2CBFB98", VA = "0x2CBFB98")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x2CBFBB8", Offset = "0x2CBFBB8", VA = "0x2CBFBB8")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2CBFBD8", Offset = "0x2CBFBD8", VA = "0x2CBFBD8")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8330", Offset = "0xBF8330")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2CBBD64", Offset = "0x2CBBD64", VA = "0x2CBBD64")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2CBFCDC", Offset = "0x2CBFCDC", VA = "0x2CBFCDC")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2CBFD30", Offset = "0x2CBFD30", VA = "0x2CBFD30")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8340", Offset = "0xBF8340")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x2CBBF3C", Offset = "0x2CBBF3C", VA = "0x2CBBF3C")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x2CBFD7C", Offset = "0x2CBFD7C", VA = "0x2CBFD7C")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2CBFD9C", Offset = "0x2CBFD9C", VA = "0x2CBFD9C")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8350", Offset = "0xBF8350")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2CBC114", Offset = "0x2CBC114", VA = "0x2CBC114")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2CBFDBC", Offset = "0x2CBFDBC", VA = "0x2CBFDBC")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2CBFDDC", Offset = "0x2CBFDDC", VA = "0x2CBFDDC")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8360", Offset = "0xBF8360")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2CBC2F8", Offset = "0x2CBC2F8", VA = "0x2CBC2F8")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2CBFDFC", Offset = "0x2CBFDFC", VA = "0x2CBFDFC")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2CBFE24", Offset = "0x2CBFE24", VA = "0x2CBFE24")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8370", Offset = "0xBF8370")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2CBC4E8", Offset = "0x2CBC4E8", VA = "0x2CBC4E8")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2CBFE4C", Offset = "0x2CBFE4C", VA = "0x2CBFE4C")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x2CBFE74", Offset = "0x2CBFE74", VA = "0x2CBFE74")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8380", Offset = "0xBF8380")]
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
		[Address(RVA = "0x2CBC720", Offset = "0x2CBC720", VA = "0x2CBC720")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x2CBFE9C", Offset = "0x2CBFE9C", VA = "0x2CBFE9C")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2CBFEA4", Offset = "0x2CBFEA4", VA = "0x2CBFEA4")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8390", Offset = "0xBF8390")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2CBC8E8", Offset = "0x2CBC8E8", VA = "0x2CBC8E8")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x2CBFF40", Offset = "0x2CBFF40", VA = "0x2CBFF40")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2CBFF68", Offset = "0x2CBFF68", VA = "0x2CBFF68")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF83A0", Offset = "0xBF83A0")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x2CBCB54", Offset = "0x2CBCB54", VA = "0x2CBCB54")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x2CBFF90", Offset = "0x2CBFF90", VA = "0x2CBFF90")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x2CBFFB8", Offset = "0x2CBFFB8", VA = "0x2CBFFB8")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF83B0", Offset = "0xBF83B0")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x2CBCDD8", Offset = "0x2CBCDD8", VA = "0x2CBCDD8")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2CBFFE0", Offset = "0x2CBFFE0", VA = "0x2CBFFE0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2CBFFEC", Offset = "0x2CBFFEC", VA = "0x2CBFFEC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF83C0", Offset = "0xBF83C0")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2CBD05C", Offset = "0x2CBD05C", VA = "0x2CBD05C")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2CC00A8", Offset = "0x2CC00A8", VA = "0x2CC00A8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2CC00B4", Offset = "0x2CC00B4", VA = "0x2CC00B4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF83D0", Offset = "0xBF83D0")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2CBD2E0", Offset = "0x2CBD2E0", VA = "0x2CBD2E0")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2CC01C0", Offset = "0x2CC01C0", VA = "0x2CC01C0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x2CC01CC", Offset = "0x2CC01CC", VA = "0x2CC01CC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2CB7F9C", Offset = "0x2CB7F9C", VA = "0x2CB7F9C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x2CB8164", Offset = "0x2CB8164", VA = "0x2CB8164")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x2CB8354", Offset = "0x2CB8354", VA = "0x2CB8354")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x2CB851C", Offset = "0x2CB851C", VA = "0x2CB851C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x2CB870C", Offset = "0x2CB870C", VA = "0x2CB870C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2CB88D4", Offset = "0x2CB88D4", VA = "0x2CB88D4")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2CB8AC0", Offset = "0x2CB8AC0", VA = "0x2CB8AC0")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2CB8CB8", Offset = "0x2CB8CB8", VA = "0x2CB8CB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2CB8EA4", Offset = "0x2CB8EA4", VA = "0x2CB8EA4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2CB9090", Offset = "0x2CB9090", VA = "0x2CB9090")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x2CB927C", Offset = "0x2CB927C", VA = "0x2CB927C")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x2CB946C", Offset = "0x2CB946C", VA = "0x2CB946C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x2CB9634", Offset = "0x2CB9634", VA = "0x2CB9634")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x2CB980C", Offset = "0x2CB980C", VA = "0x2CB980C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x2CB99F8", Offset = "0x2CB99F8", VA = "0x2CB99F8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x2CB9BE4", Offset = "0x2CB9BE4", VA = "0x2CB9BE4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x2CB9DD0", Offset = "0x2CB9DD0", VA = "0x2CB9DD0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x2CB9FCC", Offset = "0x2CB9FCC", VA = "0x2CB9FCC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2CBA1BC", Offset = "0x2CBA1BC", VA = "0x2CBA1BC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2CBA3AC", Offset = "0x2CBA3AC", VA = "0x2CBA3AC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x2CBA59C", Offset = "0x2CBA59C", VA = "0x2CBA59C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x2CBA788", Offset = "0x2CBA788", VA = "0x2CBA788")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x2CBA974", Offset = "0x2CBA974", VA = "0x2CBA974")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x2CBAB4C", Offset = "0x2CBAB4C", VA = "0x2CBAB4C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2CBAD28", Offset = "0x2CBAD28", VA = "0x2CBAD28")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2CBAF04", Offset = "0x2CBAF04", VA = "0x2CBAF04")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2CBB0F0", Offset = "0x2CBB0F0", VA = "0x2CBB0F0")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2CBB2E8", Offset = "0x2CBB2E8", VA = "0x2CBB2E8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x2CBB504", Offset = "0x2CBB504", VA = "0x2CBB504")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2CBB724", Offset = "0x2CBB724", VA = "0x2CBB724")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2CBBB8C", Offset = "0x2CBBB8C", VA = "0x2CBBB8C")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2CBBD6C", Offset = "0x2CBBD6C", VA = "0x2CBBD6C")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2CBBF44", Offset = "0x2CBBF44", VA = "0x2CBBF44")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2CBC11C", Offset = "0x2CBC11C", VA = "0x2CBC11C")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2CBC300", Offset = "0x2CBC300", VA = "0x2CBC300")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2CBC4F0", Offset = "0x2CBC4F0", VA = "0x2CBC4F0")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2CBC728", Offset = "0x2CBC728", VA = "0x2CBC728")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2CBC8F0", Offset = "0x2CBC8F0", VA = "0x2CBC8F0")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x2CBCB5C", Offset = "0x2CBCB5C", VA = "0x2CBCB5C")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x2CBCDE0", Offset = "0x2CBCDE0", VA = "0x2CBCDE0")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x2CBD064", Offset = "0x2CBD064", VA = "0x2CBD064")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000048")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF83F0", Offset = "0xBF83F0")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2CBDF6C", Offset = "0x2CBDF6C", VA = "0x2CBDF6C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x2CC079C", Offset = "0x2CC079C", VA = "0x2CC079C")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x2CC07C4", Offset = "0x2CC07C4", VA = "0x2CC07C4")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8400", Offset = "0xBF8400")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2CBE1B4", Offset = "0x2CBE1B4", VA = "0x2CBE1B4")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2CC07EC", Offset = "0x2CC07EC", VA = "0x2CC07EC")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2CC0814", Offset = "0x2CC0814", VA = "0x2CC0814")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8410", Offset = "0xBF8410")]
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
		[Address(RVA = "0x2CC083C", Offset = "0x2CC083C", VA = "0x2CC083C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2CC0A80", Offset = "0x2CC0A80", VA = "0x2CC0A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8420", Offset = "0xBF8420")]
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
		[Address(RVA = "0x2CC1190", Offset = "0x2CC1190", VA = "0x2CC1190", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2CC13F8", Offset = "0x2CC13F8", VA = "0x2CC13F8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8430", Offset = "0xBF8430")]
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
		[Address(RVA = "0x2CC0CE4", Offset = "0x2CC0CE4", VA = "0x2CC0CE4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2CC0F14", Offset = "0x2CC0F14", VA = "0x2CC0F14", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8440", Offset = "0xBF8440")]
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
		[Address(RVA = "0x2CC0A8C", Offset = "0x2CC0A8C", VA = "0x2CC0A8C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x2CC0CD8", Offset = "0x2CC0CD8", VA = "0x2CC0CD8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8450", Offset = "0xBF8450")]
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
		[Address(RVA = "0x2CC0F20", Offset = "0x2CC0F20", VA = "0x2CC0F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x2CC1184", Offset = "0x2CC1184", VA = "0x2CC1184", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0xBF8460", Offset = "0xBF8460")]
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
		[Address(RVA = "0x2CC1404", Offset = "0x2CC1404", VA = "0x2CC1404", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2CC163C", Offset = "0x2CC163C", VA = "0x2CC163C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2CBD2E8", Offset = "0x2CBD2E8", VA = "0x2CBD2E8")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2CBD4DC", Offset = "0x2CBD4DC", VA = "0x2CBD4DC")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2CBD6E4", Offset = "0x2CBD6E4", VA = "0x2CBD6E4")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2CBD7E4", Offset = "0x2CBD7E4", VA = "0x2CBD7E4")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2CBD8E4", Offset = "0x2CBD8E4", VA = "0x2CBD8E4")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x2CBD9E4", Offset = "0x2CBD9E4", VA = "0x2CBD9E4")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x2CBDB08", Offset = "0x2CBDB08", VA = "0x2CBDB08")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x2CBDC2C", Offset = "0x2CBDC2C", VA = "0x2CBDC2C")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2CBDD2C", Offset = "0x2CBDD2C", VA = "0x2CBDD2C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2CBDF74", Offset = "0x2CBDF74", VA = "0x2CBDF74")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2CBE1BC", Offset = "0x2CBE1BC", VA = "0x2CBE1BC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF89F0", Offset = "0xBF89F0")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2CBE2DC", Offset = "0x2CBE2DC", VA = "0x2CBE2DC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF8A68", Offset = "0xBF8A68")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2CBE3FC", Offset = "0x2CBE3FC", VA = "0x2CBE3FC")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF8AE0", Offset = "0xBF8AE0")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2CBE51C", Offset = "0x2CBE51C", VA = "0x2CBE51C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF8B58", Offset = "0xBF8B58")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2CBE64C", Offset = "0x2CBE64C", VA = "0x2CBE64C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF8BD0", Offset = "0xBF8BD0")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2CBE77C", Offset = "0x2CBE77C", VA = "0x2CBE77C")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0xBF8C48", Offset = "0xBF8C48")]
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
			[Address(RVA = "0x2CBEA14", Offset = "0x2CBEA14", VA = "0x2CBEA14", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2CBD7B0", Offset = "0x2CBD7B0", VA = "0x2CBD7B0")]
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
			[Address(RVA = "0x2CBEB18", Offset = "0x2CBEB18", VA = "0x2CBEB18", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2CBD8B0", Offset = "0x2CBD8B0", VA = "0x2CBD8B0")]
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
			[Address(RVA = "0x2CBEA94", Offset = "0x2CBEA94", VA = "0x2CBEA94", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2CBD9B0", Offset = "0x2CBD9B0", VA = "0x2CBD9B0")]
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
			[Address(RVA = "0x2CBEA48", Offset = "0x2CBEA48", VA = "0x2CBEA48", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2CBDAC0", Offset = "0x2CBDAC0", VA = "0x2CBDAC0")]
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
			[Address(RVA = "0x2CBEAB4", Offset = "0x2CBEAB4", VA = "0x2CBEAB4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2CBDBE4", Offset = "0x2CBDBE4", VA = "0x2CBDBE4")]
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
			[Address(RVA = "0x2CBEB7C", Offset = "0x2CBEB7C", VA = "0x2CBEB7C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x2CBDCF8", Offset = "0x2CBDCF8", VA = "0x2CBDCF8")]
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
		[Address(RVA = "0x2CC1648", Offset = "0x2CC1648", VA = "0x2CC1648")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x2CC174C", Offset = "0x2CC174C", VA = "0x2CC174C")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2CC17E4", Offset = "0x2CC17E4", VA = "0x2CC17E4")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2CC187C", Offset = "0x2CC187C", VA = "0x2CC187C")]
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
	[Address(RVA = "0x2CBE89C", Offset = "0x2CBE89C", VA = "0x2CBE89C")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2CBE960", Offset = "0x2CBE960", VA = "0x2CBE960")]
	[Preserve]
	private static void Preserver()
	{
	}
}
