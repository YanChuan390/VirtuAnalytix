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
	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552A98", Offset = "0x552A98")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xD89DD0", Offset = "0xD89DD0", VA = "0xD89DD0")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xD8A590", Offset = "0xD8A590", VA = "0xD8A590")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xD8A5AC", Offset = "0xD8A5AC", VA = "0xD8A5AC")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AA8", Offset = "0x552AA8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xD89F14", Offset = "0xD89F14", VA = "0xD89F14")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xD8A5C8", Offset = "0xD8A5C8", VA = "0xD8A5C8")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xD8A5E4", Offset = "0xD8A5E4", VA = "0xD8A5E4")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AB8", Offset = "0x552AB8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0xD8A05C", Offset = "0xD8A05C", VA = "0xD8A05C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xD8A600", Offset = "0xD8A600", VA = "0xD8A600")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xD8A640", Offset = "0xD8A640", VA = "0xD8A640")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xD89C6C", Offset = "0xD89C6C", VA = "0xD89C6C")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xD89DD8", Offset = "0xD89DD8", VA = "0xD89DD8")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xD89F1C", Offset = "0xD89F1C", VA = "0xD89F1C")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xD8A064", Offset = "0xD8A064", VA = "0xD8A064")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xD8A0DC", Offset = "0xD8A0DC", VA = "0xD8A0DC")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xD8A154", Offset = "0xD8A154", VA = "0xD8A154")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xD8A1BC", Offset = "0xD8A1BC", VA = "0xD8A1BC")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xD8A244", Offset = "0xD8A244", VA = "0xD8A244")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xD8A2AC", Offset = "0xD8A2AC", VA = "0xD8A2AC")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xD8A314", Offset = "0xD8A314", VA = "0xD8A314")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xD8A37C", Offset = "0xD8A37C", VA = "0xD8A37C")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xD8A3E4", Offset = "0xD8A3E4", VA = "0xD8A3E4")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xD8A454", Offset = "0xD8A454", VA = "0xD8A454")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xD8A4C0", Offset = "0xD8A4C0", VA = "0xD8A4C0")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xD8A528", Offset = "0xD8A528", VA = "0xD8A528")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AC8", Offset = "0x552AC8")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xD8A7D4", Offset = "0xD8A7D4", VA = "0xD8A7D4")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xD8BB70", Offset = "0xD8BB70", VA = "0xD8BB70")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AD8", Offset = "0x552AD8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xD8A964", Offset = "0xD8A964", VA = "0xD8A964")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xD8BCAC", Offset = "0xD8BCAC", VA = "0xD8BCAC")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AE8", Offset = "0x552AE8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xD8AAF4", Offset = "0xD8AAF4", VA = "0xD8AAF4")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xD8BCC8", Offset = "0xD8BCC8", VA = "0xD8BCC8")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552AF8", Offset = "0x552AF8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xD8AC84", Offset = "0xD8AC84", VA = "0xD8AC84")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xD8BCE4", Offset = "0xD8BCE4", VA = "0xD8BCE4")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B08", Offset = "0x552B08")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000075")]
		[Address(RVA = "0xD8ADF8", Offset = "0xD8ADF8", VA = "0xD8ADF8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0xD8BD00", Offset = "0xD8BD00", VA = "0xD8BD00")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B18", Offset = "0x552B18")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000077")]
		[Address(RVA = "0xD8AFE4", Offset = "0xD8AFE4", VA = "0xD8AFE4")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xD8BD1C", Offset = "0xD8BD1C", VA = "0xD8BD1C")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B28", Offset = "0x552B28")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 endValue;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Tween yTween;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xD8B460", Offset = "0xD8B460", VA = "0xD8B460")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xD8BD38", Offset = "0xD8BD38", VA = "0xD8BD38")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xD8BD54", Offset = "0xD8BD54", VA = "0xD8BD54")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xD8BD88", Offset = "0xD8BD88", VA = "0xD8BD88")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xD8BDA4", Offset = "0xD8BDA4", VA = "0xD8BDA4")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xD8BDC0", Offset = "0xD8BDC0", VA = "0xD8BDC0")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B38", Offset = "0x552B38")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xD8B654", Offset = "0xD8B654", VA = "0xD8B654")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xD8BE80", Offset = "0xD8BE80", VA = "0xD8BE80")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B48", Offset = "0x552B48")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xD8B85C", Offset = "0xD8B85C", VA = "0xD8B85C")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xD8BE9C", Offset = "0xD8BE9C", VA = "0xD8BE9C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xD8BEB8", Offset = "0xD8BEB8", VA = "0xD8BEB8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B58", Offset = "0x552B58")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xD8B9DC", Offset = "0xD8B9DC", VA = "0xD8B9DC")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xD8BFBC", Offset = "0xD8BFBC", VA = "0xD8BFBC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B68", Offset = "0x552B68")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0xD8BB68", Offset = "0xD8BB68", VA = "0xD8BB68")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xD8BB8C", Offset = "0xD8BB8C", VA = "0xD8BB8C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xD8BBA8", Offset = "0xD8BBA8", VA = "0xD8BBA8")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xD8A664", Offset = "0xD8A664", VA = "0xD8A664")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xD8A7DC", Offset = "0xD8A7DC", VA = "0xD8A7DC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xD8A96C", Offset = "0xD8A96C", VA = "0xD8A96C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xD8AAFC", Offset = "0xD8AAFC", VA = "0xD8AAFC")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xD8AC8C", Offset = "0xD8AC8C", VA = "0xD8AC8C")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xD8AE00", Offset = "0xD8AE00", VA = "0xD8AE00")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xD8AFEC", Offset = "0xD8AFEC", VA = "0xD8AFEC")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xD8B468", Offset = "0xD8B468", VA = "0xD8B468")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xD8B65C", Offset = "0xD8B65C", VA = "0xD8B65C")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xD8B864", Offset = "0xD8B864", VA = "0xD8B864")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xD8B9E4", Offset = "0xD8B9E4", VA = "0xD8B9E4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B78", Offset = "0x552B78")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xD8C140", Offset = "0xD8C140", VA = "0xD8C140")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0xD8D180", Offset = "0xD8D180", VA = "0xD8D180")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B88", Offset = "0x552B88")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xD8C2BC", Offset = "0xD8C2BC", VA = "0xD8C2BC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0xD8D19C", Offset = "0xD8D19C", VA = "0xD8D19C")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552B98", Offset = "0x552B98")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0xD8C438", Offset = "0xD8C438", VA = "0xD8C438")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0xD8D1B8", Offset = "0xD8D1B8", VA = "0xD8D1B8")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BA8", Offset = "0x552BA8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008F")]
		[Address(RVA = "0xD8C580", Offset = "0xD8C580", VA = "0xD8C580")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0xD8D1D4", Offset = "0xD8D1D4", VA = "0xD8D1D4")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BB8", Offset = "0x552BB8")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Tween yTween;

		[Token(Token = "0x6000091")]
		[Address(RVA = "0xD8C900", Offset = "0xD8C900", VA = "0xD8C900")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0xD8D1F0", Offset = "0xD8D1F0", VA = "0xD8D1F0")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0xD8D20C", Offset = "0xD8D20C", VA = "0xD8D20C")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0xD8D228", Offset = "0xD8D228", VA = "0xD8D228")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0xD8D25C", Offset = "0xD8D25C", VA = "0xD8D25C")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0xD8D278", Offset = "0xD8D278", VA = "0xD8D278")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0xD8D294", Offset = "0xD8D294", VA = "0xD8D294")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BC8", Offset = "0x552BC8")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0xD8CBB4", Offset = "0xD8CBB4", VA = "0xD8CBB4")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0xD8D3BC", Offset = "0xD8D3BC", VA = "0xD8D3BC")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0xD8D44C", Offset = "0xD8D44C", VA = "0xD8D44C")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BD8", Offset = "0x552BD8")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0xD8CE78", Offset = "0xD8CE78", VA = "0xD8CE78")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0xD8D4F0", Offset = "0xD8D4F0", VA = "0xD8D4F0")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xD8D50C", Offset = "0xD8D50C", VA = "0xD8D50C")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BE8", Offset = "0x552BE8")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xD8CFEC", Offset = "0xD8CFEC", VA = "0xD8CFEC")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xD8D638", Offset = "0xD8D638", VA = "0xD8D638")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0xD8D6C8", Offset = "0xD8D6C8", VA = "0xD8D6C8")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552BF8", Offset = "0x552BF8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xD8D178", Offset = "0xD8D178", VA = "0xD8D178")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0xD8D76C", Offset = "0xD8D76C", VA = "0xD8D76C")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xD8D788", Offset = "0xD8D788", VA = "0xD8D788")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xD8BFD8", Offset = "0xD8BFD8", VA = "0xD8BFD8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xD8C148", Offset = "0xD8C148", VA = "0xD8C148")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xD8C2C4", Offset = "0xD8C2C4", VA = "0xD8C2C4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xD8C440", Offset = "0xD8C440", VA = "0xD8C440")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xD8C588", Offset = "0xD8C588", VA = "0xD8C588")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xD8C908", Offset = "0xD8C908", VA = "0xD8C908")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xD8CBBC", Offset = "0xD8CBBC", VA = "0xD8CBBC")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xD8CE80", Offset = "0xD8CE80", VA = "0xD8CE80")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xD8CFF4", Offset = "0xD8CFF4", VA = "0xD8CFF4")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C08", Offset = "0x552C08")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xD8DA18", Offset = "0xD8DA18", VA = "0xD8DA18")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xD8DF28", Offset = "0xD8DF28", VA = "0xD8DF28")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xD8DF44", Offset = "0xD8DF44", VA = "0xD8DF44")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000022")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C18", Offset = "0x552C18")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xD8DB5C", Offset = "0xD8DB5C", VA = "0xD8DB5C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xD8DF60", Offset = "0xD8DF60", VA = "0xD8DF60")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xD8DF7C", Offset = "0xD8DF7C", VA = "0xD8DF7C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C28", Offset = "0x552C28")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xD8DF20", Offset = "0xD8DF20", VA = "0xD8DF20")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xD8DF98", Offset = "0xD8DF98", VA = "0xD8DF98")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xD8DFA4", Offset = "0xD8DFA4", VA = "0xD8DFA4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xD8D8B4", Offset = "0xD8D8B4", VA = "0xD8D8B4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xD8DA20", Offset = "0xD8DA20", VA = "0xD8DA20")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xD8DB64", Offset = "0xD8DB64", VA = "0xD8DB64")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xD8DD3C", Offset = "0xD8DD3C", VA = "0xD8DD3C")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000024")]
	public static class Utils
	{
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xD932CC", Offset = "0xD932CC", VA = "0xD932CC")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C38", Offset = "0x552C38")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xD8E18C", Offset = "0xD8E18C", VA = "0xD8E18C")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0xD920A8", Offset = "0xD920A8", VA = "0xD920A8")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xD920C4", Offset = "0xD920C4", VA = "0xD920C4")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C48", Offset = "0x552C48")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0xD8E2F8", Offset = "0xD8E2F8", VA = "0xD8E2F8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xD92318", Offset = "0xD92318", VA = "0xD92318")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xD9233C", Offset = "0xD9233C", VA = "0xD9233C")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C58", Offset = "0x552C58")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xD8E43C", Offset = "0xD8E43C", VA = "0xD8E43C")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xD929A4", Offset = "0xD929A4", VA = "0xD929A4")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xD929C8", Offset = "0xD929C8", VA = "0xD929C8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C68", Offset = "0x552C68")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xD8E5A8", Offset = "0xD8E5A8", VA = "0xD8E5A8")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xD92E70", Offset = "0xD92E70", VA = "0xD92E70")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xD92E94", Offset = "0xD92E94", VA = "0xD92E94")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C78", Offset = "0x552C78")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xD8E6EC", Offset = "0xD8E6EC", VA = "0xD8E6EC")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xD92FB8", Offset = "0xD92FB8", VA = "0xD92FB8")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xD92FDC", Offset = "0xD92FDC", VA = "0xD92FDC")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C88", Offset = "0x552C88")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xD8E854", Offset = "0xD8E854", VA = "0xD8E854")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xD93000", Offset = "0xD93000", VA = "0xD93000")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xD9301C", Offset = "0xD9301C", VA = "0xD9301C")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552C98", Offset = "0x552C98")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xD8EB98", Offset = "0xD8EB98", VA = "0xD8EB98")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xD93038", Offset = "0xD93038", VA = "0xD93038")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xD930B8", Offset = "0xD930B8", VA = "0xD930B8")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CA8", Offset = "0x552CA8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xD8ECFC", Offset = "0xD8ECFC", VA = "0xD8ECFC")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xD93114", Offset = "0xD93114", VA = "0xD93114")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xD93194", Offset = "0xD93194", VA = "0xD93194")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CB8", Offset = "0x552CB8")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xD8EE60", Offset = "0xD8EE60", VA = "0xD8EE60")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xD931F0", Offset = "0xD931F0", VA = "0xD931F0")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xD93270", Offset = "0xD93270", VA = "0xD93270")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CC8", Offset = "0x552CC8")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xD8EFCC", Offset = "0xD8EFCC", VA = "0xD8EFCC")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xD920E0", Offset = "0xD920E0", VA = "0xD920E0")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xD92100", Offset = "0xD92100", VA = "0xD92100")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CD8", Offset = "0x552CD8")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0xD8F110", Offset = "0xD8F110", VA = "0xD8F110")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0xD9211C", Offset = "0xD9211C", VA = "0xD9211C")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0xD9213C", Offset = "0xD9213C", VA = "0xD9213C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CE8", Offset = "0x552CE8")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xD8F264", Offset = "0xD8F264", VA = "0xD8F264")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0xD92158", Offset = "0xD92158", VA = "0xD92158")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0xD92174", Offset = "0xD92174", VA = "0xD92174")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552CF8", Offset = "0x552CF8")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0xD8F3C8", Offset = "0xD8F3C8", VA = "0xD8F3C8")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xD92190", Offset = "0xD92190", VA = "0xD92190")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xD921AC", Offset = "0xD921AC", VA = "0xD921AC")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D08", Offset = "0x552D08")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xD8F540", Offset = "0xD8F540", VA = "0xD8F540")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0xD921C8", Offset = "0xD921C8", VA = "0xD921C8")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xD921E4", Offset = "0xD921E4", VA = "0xD921E4")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D18", Offset = "0x552D18")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0xD8F6B8", Offset = "0xD8F6B8", VA = "0xD8F6B8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0xD92200", Offset = "0xD92200", VA = "0xD92200")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0xD9221C", Offset = "0xD9221C", VA = "0xD9221C")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D28", Offset = "0x552D28")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0xD8F824", Offset = "0xD8F824", VA = "0xD8F824")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xD92238", Offset = "0xD92238", VA = "0xD92238")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xD92254", Offset = "0xD92254", VA = "0xD92254")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D38", Offset = "0x552D38")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xD8F9A8", Offset = "0xD8F9A8", VA = "0xD8F9A8")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0xD92270", Offset = "0xD92270", VA = "0xD92270")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xD9228C", Offset = "0xD9228C", VA = "0xD9228C")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D48", Offset = "0x552D48")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0xD8FB2C", Offset = "0xD8FB2C", VA = "0xD8FB2C")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xD922A8", Offset = "0xD922A8", VA = "0xD922A8")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xD922C4", Offset = "0xD922C4", VA = "0xD922C4")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D58", Offset = "0x552D58")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xD8FCB0", Offset = "0xD8FCB0", VA = "0xD8FCB0")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xD922E0", Offset = "0xD922E0", VA = "0xD922E0")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xD922FC", Offset = "0xD922FC", VA = "0xD922FC")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D68", Offset = "0x552D68")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xD8FE14", Offset = "0xD8FE14", VA = "0xD8FE14")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xD92360", Offset = "0xD92360", VA = "0xD92360")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xD9237C", Offset = "0xD9237C", VA = "0xD9237C")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D78", Offset = "0x552D78")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xD8FF78", Offset = "0xD8FF78", VA = "0xD8FF78")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xD92398", Offset = "0xD92398", VA = "0xD92398")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xD923B4", Offset = "0xD923B4", VA = "0xD923B4")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D88", Offset = "0x552D88")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xD900CC", Offset = "0xD900CC", VA = "0xD900CC")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0xD923D0", Offset = "0xD923D0", VA = "0xD923D0")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xD923EC", Offset = "0xD923EC", VA = "0xD923EC")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552D98", Offset = "0x552D98")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xD90238", Offset = "0xD90238", VA = "0xD90238")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xD92408", Offset = "0xD92408", VA = "0xD92408")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xD92424", Offset = "0xD92424", VA = "0xD92424")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DA8", Offset = "0x552DA8")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xD903A4", Offset = "0xD903A4", VA = "0xD903A4")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xD92440", Offset = "0xD92440", VA = "0xD92440")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xD9245C", Offset = "0xD9245C", VA = "0xD9245C")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DB8", Offset = "0x552DB8")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xD90508", Offset = "0xD90508", VA = "0xD90508")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xD92478", Offset = "0xD92478", VA = "0xD92478")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xD92494", Offset = "0xD92494", VA = "0xD92494")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DC8", Offset = "0x552DC8")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0xD906C0", Offset = "0xD906C0", VA = "0xD906C0")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xD924B0", Offset = "0xD924B0", VA = "0xD924B0")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xD92540", Offset = "0xD92540", VA = "0xD92540")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DD8", Offset = "0x552DD8")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xD90858", Offset = "0xD90858", VA = "0xD90858")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xD925E4", Offset = "0xD925E4", VA = "0xD925E4")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xD92674", Offset = "0xD92674", VA = "0xD92674")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DE8", Offset = "0x552DE8")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xD90A3C", Offset = "0xD90A3C", VA = "0xD90A3C")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xD92718", Offset = "0xD92718", VA = "0xD92718")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xD927A8", Offset = "0xD927A8", VA = "0xD927A8")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552DF8", Offset = "0x552DF8")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xD90DC0", Offset = "0xD90DC0", VA = "0xD90DC0")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xD9284C", Offset = "0xD9284C", VA = "0xD9284C")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xD92868", Offset = "0xD92868", VA = "0xD92868")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0xD92884", Offset = "0xD92884", VA = "0xD92884")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0xD928B8", Offset = "0xD928B8", VA = "0xD928B8")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0xD928D4", Offset = "0xD928D4", VA = "0xD928D4")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0xD928F0", Offset = "0xD928F0", VA = "0xD928F0")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E08", Offset = "0x552E08")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0xD90F18", Offset = "0xD90F18", VA = "0xD90F18")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0xD929EC", Offset = "0xD929EC", VA = "0xD929EC")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0xD92A5C", Offset = "0xD92A5C", VA = "0xD92A5C")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E18", Offset = "0x552E18")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0xD91060", Offset = "0xD91060", VA = "0xD91060")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xD92AA8", Offset = "0xD92AA8", VA = "0xD92AA8")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xD92AC4", Offset = "0xD92AC4", VA = "0xD92AC4")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E28", Offset = "0x552E28")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xD911A8", Offset = "0xD911A8", VA = "0xD911A8")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xD92AE0", Offset = "0xD92AE0", VA = "0xD92AE0")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xD92AFC", Offset = "0xD92AFC", VA = "0xD92AFC")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E38", Offset = "0x552E38")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xD912FC", Offset = "0xD912FC", VA = "0xD912FC")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xD92B18", Offset = "0xD92B18", VA = "0xD92B18")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xD92B3C", Offset = "0xD92B3C", VA = "0xD92B3C")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E48", Offset = "0x552E48")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xD91468", Offset = "0xD91468", VA = "0xD91468")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xD92B60", Offset = "0xD92B60", VA = "0xD92B60")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xD92B84", Offset = "0xD92B84", VA = "0xD92B84")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E58", Offset = "0x552E58")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xD9160C", Offset = "0xD9160C", VA = "0xD9160C")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xD92BA8", Offset = "0xD92BA8", VA = "0xD92BA8")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xD92BB0", Offset = "0xD92BB0", VA = "0xD92BB0")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E68", Offset = "0x552E68")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xD91750", Offset = "0xD91750", VA = "0xD91750")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xD92C50", Offset = "0xD92C50", VA = "0xD92C50")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xD92C74", Offset = "0xD92C74", VA = "0xD92C74")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E78", Offset = "0x552E78")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0xD9192C", Offset = "0xD9192C", VA = "0xD9192C")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xD92C98", Offset = "0xD92C98", VA = "0xD92C98")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xD92CBC", Offset = "0xD92CBC", VA = "0xD92CBC")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E88", Offset = "0x552E88")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xD91B20", Offset = "0xD91B20", VA = "0xD91B20")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0xD92CE0", Offset = "0xD92CE0", VA = "0xD92CE0")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xD92CEC", Offset = "0xD92CEC", VA = "0xD92CEC")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552E98", Offset = "0x552E98")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xD91D14", Offset = "0xD91D14", VA = "0xD91D14")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xD92DA8", Offset = "0xD92DA8", VA = "0xD92DA8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xD92DB4", Offset = "0xD92DB4", VA = "0xD92DB4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552EA8", Offset = "0x552EA8")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xD91F08", Offset = "0xD91F08", VA = "0xD91F08")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xD92EB8", Offset = "0xD92EB8", VA = "0xD92EB8")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xD92EC4", Offset = "0xD92EC4", VA = "0xD92EC4")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552EB8", Offset = "0x552EB8")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xD920A0", Offset = "0xD920A0", VA = "0xD920A0")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xD92F80", Offset = "0xD92F80", VA = "0xD92F80")]
		internal Vector2 <DOShapeCircle>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xD92F9C", Offset = "0xD92F9C", VA = "0xD92F9C")]
		internal void <DOShapeCircle>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xD8E050", Offset = "0xD8E050", VA = "0xD8E050")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xD8E194", Offset = "0xD8E194", VA = "0xD8E194")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0xD8E300", Offset = "0xD8E300", VA = "0xD8E300")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xD8E444", Offset = "0xD8E444", VA = "0xD8E444")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xD8E5B0", Offset = "0xD8E5B0", VA = "0xD8E5B0")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xD8E6F4", Offset = "0xD8E6F4", VA = "0xD8E6F4")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xD8E85C", Offset = "0xD8E85C", VA = "0xD8E85C")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xD8EA3C", Offset = "0xD8EA3C", VA = "0xD8EA3C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xD8EBA0", Offset = "0xD8EBA0", VA = "0xD8EBA0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xD8ED04", Offset = "0xD8ED04", VA = "0xD8ED04")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xD8EE68", Offset = "0xD8EE68", VA = "0xD8EE68")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xD8EFD4", Offset = "0xD8EFD4", VA = "0xD8EFD4")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xD8F118", Offset = "0xD8F118", VA = "0xD8F118")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xD8F26C", Offset = "0xD8F26C", VA = "0xD8F26C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xD8F3D0", Offset = "0xD8F3D0", VA = "0xD8F3D0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xD8F548", Offset = "0xD8F548", VA = "0xD8F548")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xD8F6C0", Offset = "0xD8F6C0", VA = "0xD8F6C0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xD8F82C", Offset = "0xD8F82C", VA = "0xD8F82C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xD8F9B0", Offset = "0xD8F9B0", VA = "0xD8F9B0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xD8FB34", Offset = "0xD8FB34", VA = "0xD8FB34")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xD8FCB8", Offset = "0xD8FCB8", VA = "0xD8FCB8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xD8FE1C", Offset = "0xD8FE1C", VA = "0xD8FE1C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xD8FF80", Offset = "0xD8FF80", VA = "0xD8FF80")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xD900D4", Offset = "0xD900D4", VA = "0xD900D4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xD90240", Offset = "0xD90240", VA = "0xD90240")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xD903AC", Offset = "0xD903AC", VA = "0xD903AC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xD90510", Offset = "0xD90510", VA = "0xD90510")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xD906C8", Offset = "0xD906C8", VA = "0xD906C8")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xD90860", Offset = "0xD90860", VA = "0xD90860")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true, ShakeRandomnessMode randomnessMode = ShakeRandomnessMode.Full)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xD90A44", Offset = "0xD90A44", VA = "0xD90A44")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xD90DC8", Offset = "0xD90DC8", VA = "0xD90DC8")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xD90F20", Offset = "0xD90F20", VA = "0xD90F20")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xD91068", Offset = "0xD91068", VA = "0xD91068")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xD911B0", Offset = "0xD911B0", VA = "0xD911B0")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xD91304", Offset = "0xD91304", VA = "0xD91304")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xD91470", Offset = "0xD91470", VA = "0xD91470")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xD91614", Offset = "0xD91614", VA = "0xD91614")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xD91758", Offset = "0xD91758", VA = "0xD91758")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xD91934", Offset = "0xD91934", VA = "0xD91934")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xD91B28", Offset = "0xD91B28", VA = "0xD91B28")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xD91D1C", Offset = "0xD91D1C", VA = "0xD91D1C")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xD91F10", Offset = "0xD91F10", VA = "0xD91F10")]
	public static TweenerCore<Vector2, Vector2, CircleOptions> DOShapeCircle(this RectTransform target, Vector2 center, float endValueDegrees, float duration, bool relativeCenter = false, bool snapping = false)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552EC8", Offset = "0x552EC8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xD93FD4", Offset = "0xD93FD4", VA = "0xD93FD4")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xD94764", Offset = "0xD94764", VA = "0xD94764")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xD94788", Offset = "0xD94788", VA = "0xD94788")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552ED8", Offset = "0x552ED8")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xD9419C", Offset = "0xD9419C", VA = "0xD9419C")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xD947AC", Offset = "0xD947AC", VA = "0xD947AC")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xD947D0", Offset = "0xD947D0", VA = "0xD947D0")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552EE8", Offset = "0x552EE8")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
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

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xD947F4", Offset = "0xD947F4", VA = "0xD947F4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xD94A38", Offset = "0xD94A38", VA = "0xD94A38", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552EF8", Offset = "0x552EF8")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
	{
		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xD95148", Offset = "0xD95148", VA = "0xD95148", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xD953B0", Offset = "0xD953B0", VA = "0xD953B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552F08", Offset = "0x552F08")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xD94C9C", Offset = "0xD94C9C", VA = "0xD94C9C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xD94ECC", Offset = "0xD94ECC", VA = "0xD94ECC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000053")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552F18", Offset = "0x552F18")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
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
		public int elapsedLoops;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xD94A44", Offset = "0xD94A44", VA = "0xD94A44", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xD94C90", Offset = "0xD94C90", VA = "0xD94C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000054")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552F28", Offset = "0x552F28")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
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
		public float position;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xD94ED8", Offset = "0xD94ED8", VA = "0xD94ED8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xD9513C", Offset = "0xD9513C", VA = "0xD9513C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000055")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x552F38", Offset = "0x552F38")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xD953BC", Offset = "0xD953BC", VA = "0xD953BC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xD955F4", Offset = "0xD955F4", VA = "0xD955F4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xD93578", Offset = "0xD93578", VA = "0xD93578")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xD93754", Offset = "0xD93754", VA = "0xD93754")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0xD93944", Offset = "0xD93944", VA = "0xD93944")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0xD93A0C", Offset = "0xD93A0C", VA = "0xD93A0C")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0xD93AD4", Offset = "0xD93AD4", VA = "0xD93AD4")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xD93B9C", Offset = "0xD93B9C", VA = "0xD93B9C")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xD93C74", Offset = "0xD93C74", VA = "0xD93C74")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xD93D4C", Offset = "0xD93D4C", VA = "0xD93D4C")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xD93E14", Offset = "0xD93E14", VA = "0xD93E14")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xD93FDC", Offset = "0xD93FDC", VA = "0xD93FDC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xD941A4", Offset = "0xD941A4", VA = "0xD941A4")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x5534F8", Offset = "0x5534F8")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xD94294", Offset = "0xD94294", VA = "0xD94294")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x55356C", Offset = "0x55356C")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xD94384", Offset = "0xD94384", VA = "0xD94384")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x5535E0", Offset = "0x5535E0")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xD94474", Offset = "0xD94474", VA = "0xD94474")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x553654", Offset = "0x553654")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xD94574", Offset = "0xD94574", VA = "0xD94574")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x5536C8", Offset = "0x5536C8")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xD94674", Offset = "0xD94674", VA = "0xD94674")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x55373C", Offset = "0x55373C")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000056")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0xD899AC", Offset = "0xD899AC", VA = "0xD899AC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xD899E0", Offset = "0xD899E0", VA = "0xD899E0")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0xD89B7C", Offset = "0xD89B7C", VA = "0xD89B7C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xD89BE0", Offset = "0xD89BE0", VA = "0xD89BE0")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000058")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0xD89A94", Offset = "0xD89A94", VA = "0xD89A94", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xD89AB0", Offset = "0xD89AB0", VA = "0xD89AB0")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000059")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0xD89A0C", Offset = "0xD89A0C", VA = "0xD89A0C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xD89A58", Offset = "0xD89A58", VA = "0xD89A58")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x200005A")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0xD89ADC", Offset = "0xD89ADC", VA = "0xD89ADC", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xD89B40", Offset = "0xD89B40", VA = "0xD89B40")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x200005B")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xD89C0C", Offset = "0xD89C0C", VA = "0xD89C0C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0xD89C40", Offset = "0xD89C40", VA = "0xD89C40")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000009")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x200005C")]
	public static class Physics
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xD95744", Offset = "0xD95744", VA = "0xD95744")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0xD9584C", Offset = "0xD9584C", VA = "0xD9584C")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0xD958DC", Offset = "0xD958DC", VA = "0xD958DC")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xD9596C", Offset = "0xD9596C", VA = "0xD9596C")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xD95600", Offset = "0xD95600", VA = "0xD95600")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xD956A4", Offset = "0xD956A4", VA = "0xD956A4")]
	[Preserve]
	private static void Preserver()
	{
	}
}
