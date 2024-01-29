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
	[Token(Token = "0x200000A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE948", Offset = "0x6FE948")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x12717B8", Offset = "0x12717B8", VA = "0x12717B8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1271F78", Offset = "0x1271F78", VA = "0x1271F78")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1271F94", Offset = "0x1271F94", VA = "0x1271F94")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE958", Offset = "0x6FE958")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioSource target;

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x12718FC", Offset = "0x12718FC", VA = "0x12718FC")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1271FB0", Offset = "0x1271FB0", VA = "0x1271FB0")]
		internal float <DOPitch>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1271FCC", Offset = "0x1271FCC", VA = "0x1271FCC")]
		internal void <DOPitch>b__1(float x)
		{
		}
	}

	[Token(Token = "0x200000C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE968", Offset = "0x6FE968")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AudioMixer target;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string floatName;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1271A44", Offset = "0x1271A44", VA = "0x1271A44")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1271FE8", Offset = "0x1271FE8", VA = "0x1271FE8")]
		internal float <DOSetFloat>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1272028", Offset = "0x1272028", VA = "0x1272028")]
		internal void <DOSetFloat>b__1(float x)
		{
		}
	}

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x1271654", Offset = "0x1271654", VA = "0x1271654")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x12717C0", Offset = "0x12717C0", VA = "0x12717C0")]
	public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1271904", Offset = "0x1271904", VA = "0x1271904")]
	public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x1271A4C", Offset = "0x1271A4C", VA = "0x1271A4C")]
	public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1271AC4", Offset = "0x1271AC4", VA = "0x1271AC4")]
	public static int DOKill(this AudioMixer target, bool complete = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x1271B3C", Offset = "0x1271B3C", VA = "0x1271B3C")]
	public static int DOFlip(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1271BA4", Offset = "0x1271BA4", VA = "0x1271BA4")]
	public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1271C2C", Offset = "0x1271C2C", VA = "0x1271C2C")]
	public static int DOPause(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1271C94", Offset = "0x1271C94", VA = "0x1271C94")]
	public static int DOPlay(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1271CFC", Offset = "0x1271CFC", VA = "0x1271CFC")]
	public static int DOPlayBackwards(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1271D64", Offset = "0x1271D64", VA = "0x1271D64")]
	public static int DOPlayForward(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1271DCC", Offset = "0x1271DCC", VA = "0x1271DCC")]
	public static int DORestart(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1271E3C", Offset = "0x1271E3C", VA = "0x1271E3C")]
	public static int DORewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1271EA8", Offset = "0x1271EA8", VA = "0x1271EA8")]
	public static int DOSmoothRewind(this AudioMixer target)
	{
		return default(int);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1271F10", Offset = "0x1271F10", VA = "0x1271F10")]
	public static int DOTogglePause(this AudioMixer target)
	{
		return default(int);
	}
}
[Token(Token = "0x2000003")]
public static class DOTweenModulePhysics
{
	[Token(Token = "0x200000D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE978", Offset = "0x6FE978")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x12721BC", Offset = "0x12721BC", VA = "0x12721BC")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1273558", Offset = "0x1273558", VA = "0x1273558")]
		internal Vector3 <DOMove>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE988", Offset = "0x6FE988")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x127234C", Offset = "0x127234C", VA = "0x127234C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1273694", Offset = "0x1273694", VA = "0x1273694")]
		internal Vector3 <DOMoveX>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200000F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE998", Offset = "0x6FE998")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x12724DC", Offset = "0x12724DC", VA = "0x12724DC")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x12736B0", Offset = "0x12736B0", VA = "0x12736B0")]
		internal Vector3 <DOMoveY>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000010")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9A8", Offset = "0x6FE9A8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x127266C", Offset = "0x127266C", VA = "0x127266C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x12736CC", Offset = "0x12736CC", VA = "0x12736CC")]
		internal Vector3 <DOMoveZ>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000011")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9B8", Offset = "0x6FE9B8")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x12727E0", Offset = "0x12727E0", VA = "0x12727E0")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x12736E8", Offset = "0x12736E8", VA = "0x12736E8")]
		internal Quaternion <DORotate>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000012")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9C8", Offset = "0x6FE9C8")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x12729CC", Offset = "0x12729CC", VA = "0x12729CC")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1273704", Offset = "0x1273704", VA = "0x1273704")]
		internal Quaternion <DOLookAt>b__0()
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x2000013")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9D8", Offset = "0x6FE9D8")]
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

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1272E48", Offset = "0x1272E48", VA = "0x1272E48")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1273720", Offset = "0x1273720", VA = "0x1273720")]
		internal Vector3 <DOJump>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x127373C", Offset = "0x127373C", VA = "0x127373C")]
		internal void <DOJump>b__1()
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1273770", Offset = "0x1273770", VA = "0x1273770")]
		internal Vector3 <DOJump>b__2()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x127378C", Offset = "0x127378C", VA = "0x127378C")]
		internal Vector3 <DOJump>b__3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x12737A8", Offset = "0x12737A8", VA = "0x12737A8")]
		internal void <DOJump>b__4()
		{
		}
	}

	[Token(Token = "0x2000014")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9E8", Offset = "0x6FE9E8")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x127303C", Offset = "0x127303C", VA = "0x127303C")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1273868", Offset = "0x1273868", VA = "0x1273868")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000015")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FE9F8", Offset = "0x6FE9F8")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1273244", Offset = "0x1273244", VA = "0x1273244")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1273884", Offset = "0x1273884", VA = "0x1273884")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x12738A0", Offset = "0x12738A0", VA = "0x12738A0")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000016")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA08", Offset = "0x6FEA08")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody target;

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x12733C4", Offset = "0x12733C4", VA = "0x12733C4")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x12739A4", Offset = "0x12739A4", VA = "0x12739A4")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x2000017")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA18", Offset = "0x6FEA18")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody target;

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1273550", Offset = "0x1273550", VA = "0x1273550")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1273574", Offset = "0x1273574", VA = "0x1273574")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1273590", Offset = "0x1273590", VA = "0x1273590")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x127204C", Offset = "0x127204C", VA = "0x127204C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x12721C4", Offset = "0x12721C4", VA = "0x12721C4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1272354", Offset = "0x1272354", VA = "0x1272354")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x12724E4", Offset = "0x12724E4", VA = "0x12724E4")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1272674", Offset = "0x1272674", VA = "0x1272674")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x12727E8", Offset = "0x12727E8", VA = "0x12727E8")]
	public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x12729D4", Offset = "0x12729D4", VA = "0x12729D4")]
	public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1272E50", Offset = "0x1272E50", VA = "0x1272E50")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x1273044", Offset = "0x1273044", VA = "0x1273044")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x127324C", Offset = "0x127324C", VA = "0x127324C")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x12733CC", Offset = "0x12733CC", VA = "0x12733CC")]
	internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
	{
		return null;
	}
}
[Token(Token = "0x2000004")]
public static class DOTweenModulePhysics2D
{
	[Token(Token = "0x2000018")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA28", Offset = "0x6FEA28")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1273B28", Offset = "0x1273B28", VA = "0x1273B28")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1274868", Offset = "0x1274868", VA = "0x1274868")]
		internal Vector2 <DOMove>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000019")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA38", Offset = "0x6FEA38")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1273CA4", Offset = "0x1273CA4", VA = "0x1273CA4")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1274884", Offset = "0x1274884", VA = "0x1274884")]
		internal Vector2 <DOMoveX>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA48", Offset = "0x6FEA48")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1273E20", Offset = "0x1273E20", VA = "0x1273E20")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x12748A0", Offset = "0x12748A0", VA = "0x12748A0")]
		internal Vector2 <DOMoveY>b__0()
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x200001B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA58", Offset = "0x6FEA58")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1273F68", Offset = "0x1273F68", VA = "0x1273F68")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x12748BC", Offset = "0x12748BC", VA = "0x12748BC")]
		internal float <DORotate>b__0()
		{
			return default(float);
		}
	}

	[Token(Token = "0x200001C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA68", Offset = "0x6FEA68")]
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

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x12742E8", Offset = "0x12742E8", VA = "0x12742E8")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x12748D8", Offset = "0x12748D8", VA = "0x12748D8")]
		internal Vector2 <DOJump>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x12748F4", Offset = "0x12748F4", VA = "0x12748F4")]
		internal void <DOJump>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1274910", Offset = "0x1274910", VA = "0x1274910")]
		internal void <DOJump>b__2()
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1274944", Offset = "0x1274944", VA = "0x1274944")]
		internal Vector2 <DOJump>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1274960", Offset = "0x1274960", VA = "0x1274960")]
		internal void <DOJump>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x127497C", Offset = "0x127497C", VA = "0x127497C")]
		internal void <DOJump>b__5()
		{
		}
	}

	[Token(Token = "0x200001D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA78", Offset = "0x6FEA78")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody2D target;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x127459C", Offset = "0x127459C", VA = "0x127459C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1274AA4", Offset = "0x1274AA4", VA = "0x1274AA4")]
		internal Vector3 <DOPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1274B34", Offset = "0x1274B34", VA = "0x1274B34")]
		internal void <DOPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200001E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA88", Offset = "0x6FEA88")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody2D target;

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1274860", Offset = "0x1274860", VA = "0x1274860")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1274BD8", Offset = "0x1274BD8", VA = "0x1274BD8")]
		internal Vector3 <DOLocalPath>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1274BF4", Offset = "0x1274BF4", VA = "0x1274BF4")]
		internal void <DOLocalPath>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x12739C0", Offset = "0x12739C0", VA = "0x12739C0")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x1273B30", Offset = "0x1273B30", VA = "0x1273B30")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x1273CAC", Offset = "0x1273CAC", VA = "0x1273CAC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x1273E28", Offset = "0x1273E28", VA = "0x1273E28")]
	public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x1273F70", Offset = "0x1273F70", VA = "0x1273F70")]
	public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x12742F0", Offset = "0x12742F0", VA = "0x12742F0")]
	public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x12745A4", Offset = "0x12745A4", VA = "0x12745A4")]
	public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody2D target, Vector2[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
	{
		return null;
	}
}
[Token(Token = "0x2000005")]
public static class DOTweenModuleSprite
{
	[Token(Token = "0x200001F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEA98", Offset = "0x6FEA98")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1274E84", Offset = "0x1274E84", VA = "0x1274E84")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1275394", Offset = "0x1275394", VA = "0x1275394")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x12753B0", Offset = "0x12753B0", VA = "0x12753B0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000020")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAA8", Offset = "0x6FEAA8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpriteRenderer target;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1274FC8", Offset = "0x1274FC8", VA = "0x1274FC8")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x12753CC", Offset = "0x12753CC", VA = "0x12753CC")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x12753E8", Offset = "0x12753E8", VA = "0x12753E8")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000021")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAB8", Offset = "0x6FEAB8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpriteRenderer target;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x127538C", Offset = "0x127538C", VA = "0x127538C")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1275404", Offset = "0x1275404", VA = "0x1275404")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1275410", Offset = "0x1275410", VA = "0x1275410")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x1274D20", Offset = "0x1274D20", VA = "0x1274D20")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x1274E8C", Offset = "0x1274E8C", VA = "0x1274E8C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x1274FD0", Offset = "0x1274FD0", VA = "0x1274FD0")]
	public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x12751A8", Offset = "0x12751A8", VA = "0x12751A8")]
	public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000006")]
public static class DOTweenModuleUI
{
	[Token(Token = "0x2000022")]
	public static class Utils
	{
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x127A548", Offset = "0x127A548", VA = "0x127A548")]
		public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x2000023")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAC8", Offset = "0x6FEAC8")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CanvasGroup target;

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x12755F8", Offset = "0x12755F8", VA = "0x12755F8")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x127935C", Offset = "0x127935C", VA = "0x127935C")]
		internal float <DOFade>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1279378", Offset = "0x1279378", VA = "0x1279378")]
		internal void <DOFade>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000024")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAD8", Offset = "0x6FEAD8")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1275764", Offset = "0x1275764", VA = "0x1275764")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x12795CC", Offset = "0x12795CC", VA = "0x12795CC")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x12795F0", Offset = "0x12795F0", VA = "0x12795F0")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000025")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAE8", Offset = "0x6FEAE8")]
	private sealed class <>c__DisplayClass2_0
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Graphic target;

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x12758A8", Offset = "0x12758A8", VA = "0x12758A8")]
		public <>c__DisplayClass2_0()
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1279C58", Offset = "0x1279C58", VA = "0x1279C58")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1279C7C", Offset = "0x1279C7C", VA = "0x1279C7C")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000026")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEAF8", Offset = "0x6FEAF8")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1275A14", Offset = "0x1275A14", VA = "0x1275A14")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x127A124", Offset = "0x127A124", VA = "0x127A124")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x127A148", Offset = "0x127A148", VA = "0x127A148")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000027")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB08", Offset = "0x6FEB08")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1275B58", Offset = "0x1275B58", VA = "0x1275B58")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x127A234", Offset = "0x127A234", VA = "0x127A234")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x127A258", Offset = "0x127A258", VA = "0x127A258")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000028")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB18", Offset = "0x6FEB18")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Image target;

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1275CC0", Offset = "0x1275CC0", VA = "0x1275CC0")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x127A27C", Offset = "0x127A27C", VA = "0x127A27C")]
		internal float <DOFillAmount>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x127A298", Offset = "0x127A298", VA = "0x127A298")]
		internal void <DOFillAmount>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000029")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB28", Offset = "0x6FEB28")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1276004", Offset = "0x1276004", VA = "0x1276004")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x127A2B4", Offset = "0x127A2B4", VA = "0x127A2B4")]
		internal Vector2 <DOFlexibleSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x127A334", Offset = "0x127A334", VA = "0x127A334")]
		internal void <DOFlexibleSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB38", Offset = "0x6FEB38")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1276168", Offset = "0x1276168", VA = "0x1276168")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x127A390", Offset = "0x127A390", VA = "0x127A390")]
		internal Vector2 <DOMinSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x127A410", Offset = "0x127A410", VA = "0x127A410")]
		internal void <DOMinSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB48", Offset = "0x6FEB48")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LayoutElement target;

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x12762CC", Offset = "0x12762CC", VA = "0x12762CC")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x127A46C", Offset = "0x127A46C", VA = "0x127A46C")]
		internal Vector2 <DOPreferredSize>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x127A4EC", Offset = "0x127A4EC", VA = "0x127A4EC")]
		internal void <DOPreferredSize>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB58", Offset = "0x6FEB58")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1276438", Offset = "0x1276438", VA = "0x1276438")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1279394", Offset = "0x1279394", VA = "0x1279394")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x12793B4", Offset = "0x12793B4", VA = "0x12793B4")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB68", Offset = "0x6FEB68")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x127657C", Offset = "0x127657C", VA = "0x127657C")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x12793D0", Offset = "0x12793D0", VA = "0x12793D0")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x12793F0", Offset = "0x12793F0", VA = "0x12793F0")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200002E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB78", Offset = "0x6FEB78")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Outline target;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x12766D0", Offset = "0x12766D0", VA = "0x12766D0")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x127940C", Offset = "0x127940C", VA = "0x127940C")]
		internal Vector2 <DOScale>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1279428", Offset = "0x1279428", VA = "0x1279428")]
		internal void <DOScale>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200002F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB88", Offset = "0x6FEB88")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1276834", Offset = "0x1276834", VA = "0x1276834")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1279444", Offset = "0x1279444", VA = "0x1279444")]
		internal Vector2 <DOAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1279460", Offset = "0x1279460", VA = "0x1279460")]
		internal void <DOAnchorPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000030")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEB98", Offset = "0x6FEB98")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x12769AC", Offset = "0x12769AC", VA = "0x12769AC")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x127947C", Offset = "0x127947C", VA = "0x127947C")]
		internal Vector2 <DOAnchorPosX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1279498", Offset = "0x1279498", VA = "0x1279498")]
		internal void <DOAnchorPosX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000031")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBA8", Offset = "0x6FEBA8")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1276B24", Offset = "0x1276B24", VA = "0x1276B24")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x12794B4", Offset = "0x12794B4", VA = "0x12794B4")]
		internal Vector2 <DOAnchorPosY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x12794D0", Offset = "0x12794D0", VA = "0x12794D0")]
		internal void <DOAnchorPosY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000032")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBB8", Offset = "0x6FEBB8")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1276C90", Offset = "0x1276C90", VA = "0x1276C90")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x12794EC", Offset = "0x12794EC", VA = "0x12794EC")]
		internal Vector3 <DOAnchorPos3D>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1279508", Offset = "0x1279508", VA = "0x1279508")]
		internal void <DOAnchorPos3D>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000033")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBC8", Offset = "0x6FEBC8")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1276E14", Offset = "0x1276E14", VA = "0x1276E14")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1279524", Offset = "0x1279524", VA = "0x1279524")]
		internal Vector3 <DOAnchorPos3DX>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1279540", Offset = "0x1279540", VA = "0x1279540")]
		internal void <DOAnchorPos3DX>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000034")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBD8", Offset = "0x6FEBD8")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1276F98", Offset = "0x1276F98", VA = "0x1276F98")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x127955C", Offset = "0x127955C", VA = "0x127955C")]
		internal Vector3 <DOAnchorPos3DY>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1279578", Offset = "0x1279578", VA = "0x1279578")]
		internal void <DOAnchorPos3DY>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000035")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBE8", Offset = "0x6FEBE8")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x127711C", Offset = "0x127711C", VA = "0x127711C")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1279594", Offset = "0x1279594", VA = "0x1279594")]
		internal Vector3 <DOAnchorPos3DZ>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x12795B0", Offset = "0x12795B0", VA = "0x12795B0")]
		internal void <DOAnchorPos3DZ>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x2000036")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEBF8", Offset = "0x6FEBF8")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1277280", Offset = "0x1277280", VA = "0x1277280")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1279614", Offset = "0x1279614", VA = "0x1279614")]
		internal Vector2 <DOAnchorMax>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1279630", Offset = "0x1279630", VA = "0x1279630")]
		internal void <DOAnchorMax>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000037")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC08", Offset = "0x6FEC08")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x12773E4", Offset = "0x12773E4", VA = "0x12773E4")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x127964C", Offset = "0x127964C", VA = "0x127964C")]
		internal Vector2 <DOAnchorMin>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1279668", Offset = "0x1279668", VA = "0x1279668")]
		internal void <DOAnchorMin>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000038")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC18", Offset = "0x6FEC18")]
	private sealed class <>c__DisplayClass22_0
	{
		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1277538", Offset = "0x1277538", VA = "0x1277538")]
		public <>c__DisplayClass22_0()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1279684", Offset = "0x1279684", VA = "0x1279684")]
		internal Vector2 <DOPivot>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x12796A0", Offset = "0x12796A0", VA = "0x12796A0")]
		internal void <DOPivot>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000039")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC28", Offset = "0x6FEC28")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x12776A4", Offset = "0x12776A4", VA = "0x12776A4")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x12796BC", Offset = "0x12796BC", VA = "0x12796BC")]
		internal Vector2 <DOPivotX>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x12796D8", Offset = "0x12796D8", VA = "0x12796D8")]
		internal void <DOPivotX>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC38", Offset = "0x6FEC38")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1277810", Offset = "0x1277810", VA = "0x1277810")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x12796F4", Offset = "0x12796F4", VA = "0x12796F4")]
		internal Vector2 <DOPivotY>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1279710", Offset = "0x1279710", VA = "0x1279710")]
		internal void <DOPivotY>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC48", Offset = "0x6FEC48")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1277974", Offset = "0x1277974", VA = "0x1277974")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x127972C", Offset = "0x127972C", VA = "0x127972C")]
		internal Vector2 <DOSizeDelta>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1279748", Offset = "0x1279748", VA = "0x1279748")]
		internal void <DOSizeDelta>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200003C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC58", Offset = "0x6FEC58")]
	private sealed class <>c__DisplayClass26_0
	{
		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1277B2C", Offset = "0x1277B2C", VA = "0x1277B2C")]
		public <>c__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1279764", Offset = "0x1279764", VA = "0x1279764")]
		internal Vector3 <DOPunchAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x12797F4", Offset = "0x12797F4", VA = "0x12797F4")]
		internal void <DOPunchAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC68", Offset = "0x6FEC68")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1277CB4", Offset = "0x1277CB4", VA = "0x1277CB4")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1279898", Offset = "0x1279898", VA = "0x1279898")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1279928", Offset = "0x1279928", VA = "0x1279928")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC78", Offset = "0x6FEC78")]
	private sealed class <>c__DisplayClass28_0
	{
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1277E88", Offset = "0x1277E88", VA = "0x1277E88")]
		public <>c__DisplayClass28_0()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x12799CC", Offset = "0x12799CC", VA = "0x12799CC")]
		internal Vector3 <DOShakeAnchorPos>b__0()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1279A5C", Offset = "0x1279A5C", VA = "0x1279A5C")]
		internal void <DOShakeAnchorPos>b__1(Vector3 x)
		{
		}
	}

	[Token(Token = "0x200003F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC88", Offset = "0x6FEC88")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RectTransform target;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float startPosY;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool offsetYSet;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float offsetY;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sequence s;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector2 endValue;

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x127820C", Offset = "0x127820C", VA = "0x127820C")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x1279B00", Offset = "0x1279B00", VA = "0x1279B00")]
		internal Vector2 <DOJumpAnchorPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1279B1C", Offset = "0x1279B1C", VA = "0x1279B1C")]
		internal void <DOJumpAnchorPos>b__1(Vector2 x)
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1279B38", Offset = "0x1279B38", VA = "0x1279B38")]
		internal void <DOJumpAnchorPos>b__2()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1279B6C", Offset = "0x1279B6C", VA = "0x1279B6C")]
		internal Vector2 <DOJumpAnchorPos>b__3()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1279B88", Offset = "0x1279B88", VA = "0x1279B88")]
		internal void <DOJumpAnchorPos>b__4(Vector2 x)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1279BA4", Offset = "0x1279BA4", VA = "0x1279BA4")]
		internal void <DOJumpAnchorPos>b__5()
		{
		}
	}

	[Token(Token = "0x2000040")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEC98", Offset = "0x6FEC98")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1278364", Offset = "0x1278364", VA = "0x1278364")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1279CA0", Offset = "0x1279CA0", VA = "0x1279CA0")]
		internal Vector2 <DONormalizedPos>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1279D10", Offset = "0x1279D10", VA = "0x1279D10")]
		internal void <DONormalizedPos>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x2000041")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECA8", Offset = "0x6FECA8")]
	private sealed class <>c__DisplayClass31_0
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x12784AC", Offset = "0x12784AC", VA = "0x12784AC")]
		public <>c__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1279D5C", Offset = "0x1279D5C", VA = "0x1279D5C")]
		internal float <DOHorizontalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1279D78", Offset = "0x1279D78", VA = "0x1279D78")]
		internal void <DOHorizontalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000042")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECB8", Offset = "0x6FECB8")]
	private sealed class <>c__DisplayClass32_0
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ScrollRect target;

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x12785F4", Offset = "0x12785F4", VA = "0x12785F4")]
		public <>c__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1279D94", Offset = "0x1279D94", VA = "0x1279D94")]
		internal float <DOVerticalNormalizedPos>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1279DB0", Offset = "0x1279DB0", VA = "0x1279DB0")]
		internal void <DOVerticalNormalizedPos>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000043")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECC8", Offset = "0x6FECC8")]
	private sealed class <>c__DisplayClass33_0
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Slider target;

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1278748", Offset = "0x1278748", VA = "0x1278748")]
		public <>c__DisplayClass33_0()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1279DCC", Offset = "0x1279DCC", VA = "0x1279DCC")]
		internal float <DOValue>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1279DF0", Offset = "0x1279DF0", VA = "0x1279DF0")]
		internal void <DOValue>b__1(float x)
		{
		}
	}

	[Token(Token = "0x2000044")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECD8", Offset = "0x6FECD8")]
	private sealed class <>c__DisplayClass34_0
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12788B4", Offset = "0x12788B4", VA = "0x12788B4")]
		public <>c__DisplayClass34_0()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1279E14", Offset = "0x1279E14", VA = "0x1279E14")]
		internal Color <DOColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1279E38", Offset = "0x1279E38", VA = "0x1279E38")]
		internal void <DOColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000045")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECE8", Offset = "0x6FECE8")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int v;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text target;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool addThousandsSeparator;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CultureInfo cInfo;

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1278A58", Offset = "0x1278A58", VA = "0x1278A58")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1279E5C", Offset = "0x1279E5C", VA = "0x1279E5C")]
		internal int <DOCounter>b__0()
		{
			return default(int);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1279E64", Offset = "0x1279E64", VA = "0x1279E64")]
		internal void <DOCounter>b__1(int x)
		{
		}
	}

	[Token(Token = "0x2000046")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FECF8", Offset = "0x6FECF8")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1278B9C", Offset = "0x1278B9C", VA = "0x1278B9C")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1279F04", Offset = "0x1279F04", VA = "0x1279F04")]
		internal Color <DOFade>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1279F28", Offset = "0x1279F28", VA = "0x1279F28")]
		internal void <DOFade>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000047")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED08", Offset = "0x6FED08")]
	private sealed class <>c__DisplayClass37_0
	{
		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Text target;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1278D78", Offset = "0x1278D78", VA = "0x1278D78")]
		public <>c__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1279F4C", Offset = "0x1279F4C", VA = "0x1279F4C")]
		internal string <DOText>b__0()
		{
			return null;
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1279F70", Offset = "0x1279F70", VA = "0x1279F70")]
		internal void <DOText>b__1(string x)
		{
		}
	}

	[Token(Token = "0x2000048")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED18", Offset = "0x6FED18")]
	private sealed class <>c__DisplayClass38_0
	{
		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Graphic target;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1278F6C", Offset = "0x1278F6C", VA = "0x1278F6C")]
		public <>c__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x1279F94", Offset = "0x1279F94", VA = "0x1279F94")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1279FA0", Offset = "0x1279FA0", VA = "0x1279FA0")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x2000049")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED28", Offset = "0x6FED28")]
	private sealed class <>c__DisplayClass39_0
	{
		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image target;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1279160", Offset = "0x1279160", VA = "0x1279160")]
		public <>c__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x127A05C", Offset = "0x127A05C", VA = "0x127A05C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x127A068", Offset = "0x127A068", VA = "0x127A068")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x200004A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED38", Offset = "0x6FED38")]
	private sealed class <>c__DisplayClass40_0
	{
		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Color to;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text target;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1279354", Offset = "0x1279354", VA = "0x1279354")]
		public <>c__DisplayClass40_0()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x127A16C", Offset = "0x127A16C", VA = "0x127A16C")]
		internal Color <DOBlendableColor>b__0()
		{
			return default(Color);
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x127A178", Offset = "0x127A178", VA = "0x127A178")]
		internal void <DOBlendableColor>b__1(Color x)
		{
		}
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x12754BC", Offset = "0x12754BC", VA = "0x12754BC")]
	public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x1275600", Offset = "0x1275600", VA = "0x1275600")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x127576C", Offset = "0x127576C", VA = "0x127576C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x12758B0", Offset = "0x12758B0", VA = "0x12758B0")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1275A1C", Offset = "0x1275A1C", VA = "0x1275A1C")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1275B60", Offset = "0x1275B60", VA = "0x1275B60")]
	public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x1275CC8", Offset = "0x1275CC8", VA = "0x1275CC8")]
	public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1275EA8", Offset = "0x1275EA8", VA = "0x1275EA8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x127600C", Offset = "0x127600C", VA = "0x127600C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1276170", Offset = "0x1276170", VA = "0x1276170")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x12762D4", Offset = "0x12762D4", VA = "0x12762D4")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1276440", Offset = "0x1276440", VA = "0x1276440")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1276584", Offset = "0x1276584", VA = "0x1276584")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x12766D8", Offset = "0x12766D8", VA = "0x12766D8")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x127683C", Offset = "0x127683C", VA = "0x127683C")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x12769B4", Offset = "0x12769B4", VA = "0x12769B4")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1276B2C", Offset = "0x1276B2C", VA = "0x1276B2C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x1276C98", Offset = "0x1276C98", VA = "0x1276C98")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1276E1C", Offset = "0x1276E1C", VA = "0x1276E1C")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1276FA0", Offset = "0x1276FA0", VA = "0x1276FA0")]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1277124", Offset = "0x1277124", VA = "0x1277124")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1277288", Offset = "0x1277288", VA = "0x1277288")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x12773EC", Offset = "0x12773EC", VA = "0x12773EC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1277540", Offset = "0x1277540", VA = "0x1277540")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x12776AC", Offset = "0x12776AC", VA = "0x12776AC")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x1277818", Offset = "0x1277818", VA = "0x1277818")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x127797C", Offset = "0x127797C", VA = "0x127797C")]
	public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x1277B34", Offset = "0x1277B34", VA = "0x1277B34")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x1277CBC", Offset = "0x1277CBC", VA = "0x1277CBC")]
	public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
	{
		return null;
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1277E90", Offset = "0x1277E90", VA = "0x1277E90")]
	public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x1278214", Offset = "0x1278214", VA = "0x1278214")]
	public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x127836C", Offset = "0x127836C", VA = "0x127836C")]
	public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x12784B4", Offset = "0x12784B4", VA = "0x12784B4")]
	public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x12785FC", Offset = "0x12785FC", VA = "0x12785FC")]
	public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
	{
		return null;
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x1278750", Offset = "0x1278750", VA = "0x1278750")]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x12788BC", Offset = "0x12788BC", VA = "0x12788BC")]
	public static TweenerCore<int, int, NoOptions> DOCounter(this Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, [Optional] CultureInfo culture)
	{
		return null;
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x1278A60", Offset = "0x1278A60", VA = "0x1278A60")]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1278BA4", Offset = "0x1278BA4", VA = "0x1278BA4")]
	public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x1278D80", Offset = "0x1278D80", VA = "0x1278D80")]
	public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x1278F74", Offset = "0x1278F74", VA = "0x1278F74")]
	public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x1279168", Offset = "0x1279168", VA = "0x1279168")]
	public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
	{
		return null;
	}
}
[Token(Token = "0x2000007")]
public static class DOTweenModuleUnityVersion
{
	[Token(Token = "0x200004B")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED48", Offset = "0x6FED48")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x127B250", Offset = "0x127B250", VA = "0x127B250")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x127B9E0", Offset = "0x127B9E0", VA = "0x127B9E0")]
		internal Vector2 <DOOffset>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x127BA04", Offset = "0x127BA04", VA = "0x127BA04")]
		internal void <DOOffset>b__1(Vector2 x)
		{
		}
	}

	[Token(Token = "0x200004C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED58", Offset = "0x6FED58")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material target;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int propertyID;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x127B418", Offset = "0x127B418", VA = "0x127B418")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x127BA28", Offset = "0x127BA28", VA = "0x127BA28")]
		internal Vector2 <DOTiling>b__0()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x127BA4C", Offset = "0x127BA4C", VA = "0x127BA4C")]
		internal void <DOTiling>b__1(Vector2 x)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004D")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED68", Offset = "0x6FED68")]
	private struct <AsyncWaitForCompletion>d__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x127BA70", Offset = "0x127BA70", VA = "0x127BA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x127BCB4", Offset = "0x127BCB4", VA = "0x127BCB4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED78", Offset = "0x6FED78")]
	private struct <AsyncWaitForRewind>d__11 : IAsyncStateMachine
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

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x127C3C4", Offset = "0x127C3C4", VA = "0x127C3C4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x127C62C", Offset = "0x127C62C", VA = "0x127C62C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200004F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED88", Offset = "0x6FED88")]
	private struct <AsyncWaitForKill>d__12 : IAsyncStateMachine
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

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x127BF18", Offset = "0x127BF18", VA = "0x127BF18", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x127C148", Offset = "0x127C148", VA = "0x127C148", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000050")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FED98", Offset = "0x6FED98")]
	private struct <AsyncWaitForElapsedLoops>d__13 : IAsyncStateMachine
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
		public int elapsedLoops;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x127BCC0", Offset = "0x127BCC0", VA = "0x127BCC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x127BF0C", Offset = "0x127BF0C", VA = "0x127BF0C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000051")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEDA8", Offset = "0x6FEDA8")]
	private struct <AsyncWaitForPosition>d__14 : IAsyncStateMachine
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float position;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x127C154", Offset = "0x127C154", VA = "0x127C154", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x127C3B8", Offset = "0x127C3B8", VA = "0x127C3B8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000052")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FEDB8", Offset = "0x6FEDB8")]
	private struct <AsyncWaitForStart>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Tween t;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x127C638", Offset = "0x127C638", VA = "0x127C638", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x127C870", Offset = "0x127C870", VA = "0x127C870", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x127A7F4", Offset = "0x127A7F4", VA = "0x127A7F4")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x127A9D0", Offset = "0x127A9D0", VA = "0x127A9D0")]
	public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x127ABC0", Offset = "0x127ABC0", VA = "0x127ABC0")]
	public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x127AC88", Offset = "0x127AC88", VA = "0x127AC88")]
	public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x127AD50", Offset = "0x127AD50", VA = "0x127AD50")]
	public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x127AE18", Offset = "0x127AE18", VA = "0x127AE18")]
	public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x127AEF0", Offset = "0x127AEF0", VA = "0x127AEF0")]
	public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x127AFC8", Offset = "0x127AFC8", VA = "0x127AFC8")]
	public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
	{
		return null;
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x127B090", Offset = "0x127B090", VA = "0x127B090")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x127B258", Offset = "0x127B258", VA = "0x127B258")]
	public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x127B420", Offset = "0x127B420", VA = "0x127B420")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF348", Offset = "0x6FF348")]
	public static Task AsyncWaitForCompletion(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x127B510", Offset = "0x127B510", VA = "0x127B510")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF3BC", Offset = "0x6FF3BC")]
	public static Task AsyncWaitForRewind(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x127B600", Offset = "0x127B600", VA = "0x127B600")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF430", Offset = "0x6FF430")]
	public static Task AsyncWaitForKill(this Tween t)
	{
		return null;
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x127B6F0", Offset = "0x127B6F0", VA = "0x127B6F0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF4A4", Offset = "0x6FF4A4")]
	public static Task AsyncWaitForElapsedLoops(this Tween t, int elapsedLoops)
	{
		return null;
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x127B7F0", Offset = "0x127B7F0", VA = "0x127B7F0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF518", Offset = "0x6FF518")]
	public static Task AsyncWaitForPosition(this Tween t, float position)
	{
		return null;
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x127B8F0", Offset = "0x127B8F0", VA = "0x127B8F0")]
	[Attribute(Name = "AsyncStateMachineAttribute", RVA = "0x6FF58C", Offset = "0x6FF58C")]
	public static Task AsyncWaitForStart(this Tween t)
	{
		return null;
	}
}
[Token(Token = "0x2000008")]
public static class DOTweenCYInstruction
{
	[Token(Token = "0x2000053")]
	public class WaitForCompletion : CustomYieldInstruction
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000001")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x1271394", Offset = "0x1271394", VA = "0x1271394", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x12713C8", Offset = "0x12713C8", VA = "0x12713C8")]
		public WaitForCompletion(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000054")]
	public class WaitForRewind : CustomYieldInstruction
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000002")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1271564", Offset = "0x1271564", VA = "0x1271564", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x12715C8", Offset = "0x12715C8", VA = "0x12715C8")]
		public WaitForRewind(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000055")]
	public class WaitForKill : CustomYieldInstruction
	{
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000003")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x127147C", Offset = "0x127147C", VA = "0x127147C", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1271498", Offset = "0x1271498", VA = "0x1271498")]
		public WaitForKill(Tween tween)
		{
		}
	}

	[Token(Token = "0x2000056")]
	public class WaitForElapsedLoops : CustomYieldInstruction
	{
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly int elapsedLoops;

		[Token(Token = "0x17000004")]
		public override bool keepWaiting
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x12713F4", Offset = "0x12713F4", VA = "0x12713F4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1271440", Offset = "0x1271440", VA = "0x1271440")]
		public WaitForElapsedLoops(Tween tween, int elapsedLoops)
		{
		}
	}

	[Token(Token = "0x2000057")]
	public class WaitForPosition : CustomYieldInstruction
	{
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly float position;

		[Token(Token = "0x17000005")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x12714C4", Offset = "0x12714C4", VA = "0x12714C4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1271528", Offset = "0x1271528", VA = "0x1271528")]
		public WaitForPosition(Tween tween, float position)
		{
		}
	}

	[Token(Token = "0x2000058")]
	public class WaitForStart : CustomYieldInstruction
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Tween t;

		[Token(Token = "0x17000006")]
		public override bool keepWaiting
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x12715F4", Offset = "0x12715F4", VA = "0x12715F4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1271628", Offset = "0x1271628", VA = "0x1271628")]
		public WaitForStart(Tween tween)
		{
		}
	}
}
[Token(Token = "0x2000009")]
public static class DOTweenModuleUtils
{
	[Token(Token = "0x2000059")]
	public static class Physics
	{
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x127C9C0", Offset = "0x127C9C0", VA = "0x127C9C0")]
		public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x127CAC8", Offset = "0x127CAC8", VA = "0x127CAC8")]
		public static bool HasRigidbody2D(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x127CB58", Offset = "0x127CB58", VA = "0x127CB58")]
		[Preserve]
		public static bool HasRigidbody(Component target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x127CBE8", Offset = "0x127CBE8", VA = "0x127CBE8")]
		[Preserve]
		public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
		{
			return null;
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool _initialized;

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x127C87C", Offset = "0x127C87C", VA = "0x127C87C")]
	[Preserve]
	public static void Init()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x127C920", Offset = "0x127C920", VA = "0x127C920")]
	[Preserve]
	private static void Preserver()
	{
	}
}
